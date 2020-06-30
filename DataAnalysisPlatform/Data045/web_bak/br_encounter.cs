/*
               File: BR_Encounter
        Description: 就诊信息
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/27/2020 9:36:25.22
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
   public class br_encounter : GXDataArea, System.Web.SessionState.IRequiresSessionState
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
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxJX_Action46") == 0 )
         {
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            XC_46_0E15( ) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxCallCrl"+"_"+"BR_ENCOUNTER_DEPARTMENT") == 0 )
         {
            AV30tCurrentCode = GetNextPar( );
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV30tCurrentCode", AV30tCurrentCode);
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            GXDLABR_ENCOUNTER_DEPARTMENT0E15( AV30tCurrentCode) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxCallCrl"+"_"+"BR_ENCOUNTER_ENCTYPE") == 0 )
         {
            AV30tCurrentCode = GetNextPar( );
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV30tCurrentCode", AV30tCurrentCode);
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            GXDLABR_ENCOUNTER_ENCTYPE0E15( AV30tCurrentCode) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxCallCrl"+"_"+"BR_ENCOUNTER_ADMITSOURCE") == 0 )
         {
            AV30tCurrentCode = GetNextPar( );
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV30tCurrentCode", AV30tCurrentCode);
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            GXDLABR_ENCOUNTER_ADMITSOURCE0E15( AV30tCurrentCode) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxCallCrl"+"_"+"BR_ENCOUNTER_DISCHARGESTATUS") == 0 )
         {
            AV30tCurrentCode = GetNextPar( );
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV30tCurrentCode", AV30tCurrentCode);
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            GXDLABR_ENCOUNTER_DISCHARGESTATUS0E15( AV30tCurrentCode) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxAggSel12"+"_"+"BAS_TENANTTENANTCODE") == 0 )
         {
            AV29Insert_BAS_TenantTenantCode = GetNextPar( );
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV29Insert_BAS_TenantTenantCode", AV29Insert_BAS_TenantTenantCode);
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            GX12ASABAS_TENANTTENANTCODE0E15( AV29Insert_BAS_TenantTenantCode) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxAggSel13"+"_"+"BAS_TENANTTENANTCODE") == 0 )
         {
            Gx_mode = GetNextPar( );
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            GX13ASABAS_TENANTTENANTCODE0E15( Gx_mode) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxAggSel20"+"_"+"BR_ENCOUNTER_ENCID") == 0 )
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
            GX20ASABR_ENCOUNTER_ENCID0E15( A85BR_Information_ID) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxAggSel25"+"_"+"BR_ENCOUNTER_DEPARTMENT_CODE") == 0 )
         {
            A84BR_Encounter_Department = GetNextPar( );
            n84BR_Encounter_Department = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A84BR_Encounter_Department", A84BR_Encounter_Department);
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            GX25ASABR_ENCOUNTER_DEPARTMENT_CODE0E15( A84BR_Encounter_Department) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxAggSel26"+"_"+"BR_ENCOUNTER_DEPARTMENT_CODE") == 0 )
         {
            A84BR_Encounter_Department = GetNextPar( );
            n84BR_Encounter_Department = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A84BR_Encounter_Department", A84BR_Encounter_Department);
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            GX26ASABR_ENCOUNTER_DEPARTMENT_CODE0E15( A84BR_Encounter_Department) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxAggSel27"+"_"+"BR_ENCOUNTER_ENCTYPE_CODE") == 0 )
         {
            A90BR_Encounter_ENCType = GetNextPar( );
            n90BR_Encounter_ENCType = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A90BR_Encounter_ENCType", A90BR_Encounter_ENCType);
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            GX27ASABR_ENCOUNTER_ENCTYPE_CODE0E15( A90BR_Encounter_ENCType) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxAggSel28"+"_"+"BR_ENCOUNTER_ENCTYPE_CODE") == 0 )
         {
            A90BR_Encounter_ENCType = GetNextPar( );
            n90BR_Encounter_ENCType = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A90BR_Encounter_ENCType", A90BR_Encounter_ENCType);
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            GX28ASABR_ENCOUNTER_ENCTYPE_CODE0E15( A90BR_Encounter_ENCType) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxAggSel29"+"_"+"BR_ENCOUNTER_ADMITSOURCE_CODE") == 0 )
         {
            A92BR_Encounter_AdmitSource = GetNextPar( );
            n92BR_Encounter_AdmitSource = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A92BR_Encounter_AdmitSource", A92BR_Encounter_AdmitSource);
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            GX29ASABR_ENCOUNTER_ADMITSOURCE_CODE0E15( A92BR_Encounter_AdmitSource) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxAggSel30"+"_"+"BR_ENCOUNTER_ADMITSOURCE_CODE") == 0 )
         {
            A92BR_Encounter_AdmitSource = GetNextPar( );
            n92BR_Encounter_AdmitSource = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A92BR_Encounter_AdmitSource", A92BR_Encounter_AdmitSource);
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            GX30ASABR_ENCOUNTER_ADMITSOURCE_CODE0E15( A92BR_Encounter_AdmitSource) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxAggSel31"+"_"+"BR_ENCOUNTER_DISCHARGESTATUS_CODE") == 0 )
         {
            A94BR_Encounter_DischargeStatus = GetNextPar( );
            n94BR_Encounter_DischargeStatus = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A94BR_Encounter_DischargeStatus", A94BR_Encounter_DischargeStatus);
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            GX31ASABR_ENCOUNTER_DISCHARGESTATUS_CODE0E15( A94BR_Encounter_DischargeStatus) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxAggSel32"+"_"+"BR_ENCOUNTER_DISCHARGESTATUS_CODE") == 0 )
         {
            A94BR_Encounter_DischargeStatus = GetNextPar( );
            n94BR_Encounter_DischargeStatus = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A94BR_Encounter_DischargeStatus", A94BR_Encounter_DischargeStatus);
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            GX32ASABR_ENCOUNTER_DISCHARGESTATUS_CODE0E15( A94BR_Encounter_DischargeStatus) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxExecAct_"+"gxLoad_48") == 0 )
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
            gxLoad_48( A85BR_Information_ID) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxExecAct_"+"gxLoad_50") == 0 )
         {
            A85BR_Information_ID = (long)(NumberUtil.Val( GetNextPar( ), "."));
            n85BR_Information_ID = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A85BR_Information_ID", StringUtil.LTrim( StringUtil.Str( (decimal)(A85BR_Information_ID), 18, 0)));
            A360BAS_TenantTenantCode = GetNextPar( );
            n360BAS_TenantTenantCode = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A360BAS_TenantTenantCode", A360BAS_TenantTenantCode);
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            gxLoad_50( A85BR_Information_ID, A360BAS_TenantTenantCode) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxExecAct_"+"gxLoad_49") == 0 )
         {
            A360BAS_TenantTenantCode = GetNextPar( );
            n360BAS_TenantTenantCode = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A360BAS_TenantTenantCode", A360BAS_TenantTenantCode);
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            gxLoad_49( A360BAS_TenantTenantCode) ;
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
         if ( ! entryPointCalled && ! ( isAjaxCallMode( ) || isFullAjaxMode( ) ) )
         {
            Gx_mode = gxfirstwebparm;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
            if ( StringUtil.StrCmp(gxfirstwebparm, "viewer") != 0 )
            {
               AV7BR_EncounterID = (long)(NumberUtil.Val( GetNextPar( ), "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7BR_EncounterID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV7BR_EncounterID), 18, 0)));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vBR_ENCOUNTERID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV7BR_EncounterID), "ZZZZZZZZZZZZZZZZZZ"), context));
            }
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
            Form.Meta.addItem("description", "就诊信息", 0) ;
         }
         context.wjLoc = "";
         context.nUserReturn = 0;
         context.wbHandled = 0;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         GX_FocusControl = edtBR_Information_ID_Internalname;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         wbErr = false;
         context.SetDefaultTheme("WorkWithPlusTheme");
         if ( ! context.IsLocalStorageSupported( ) )
         {
            context.PushCurrentUrl();
         }
      }

      public br_encounter( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public br_encounter( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( String aP0_Gx_mode ,
                           long aP1_BR_EncounterID )
      {
         this.Gx_mode = aP0_Gx_mode;
         this.AV7BR_EncounterID = aP1_BR_EncounterID;
         executePrivate();
      }

      void executePrivate( )
      {
         isStatic = false;
         webExecute();
      }

      protected override void createObjects( )
      {
         dynBR_Encounter_Department = new GXCombobox();
         dynBR_Encounter_ENCType = new GXCombobox();
         dynBR_Encounter_AdmitSource = new GXCombobox();
         dynBR_Encounter_DischargeStatus = new GXCombobox();
         cmbBR_Encounter_Status = new GXCombobox();
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
         if ( dynBR_Encounter_Department.ItemCount > 0 )
         {
            A84BR_Encounter_Department = dynBR_Encounter_Department.getValidValue(A84BR_Encounter_Department);
            n84BR_Encounter_Department = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A84BR_Encounter_Department", A84BR_Encounter_Department);
         }
         if ( context.isAjaxRequest( ) )
         {
            dynBR_Encounter_Department.CurrentValue = StringUtil.RTrim( A84BR_Encounter_Department);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynBR_Encounter_Department_Internalname, "Values", dynBR_Encounter_Department.ToJavascriptSource(), true);
         }
         if ( dynBR_Encounter_ENCType.ItemCount > 0 )
         {
            A90BR_Encounter_ENCType = dynBR_Encounter_ENCType.getValidValue(A90BR_Encounter_ENCType);
            n90BR_Encounter_ENCType = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A90BR_Encounter_ENCType", A90BR_Encounter_ENCType);
         }
         if ( context.isAjaxRequest( ) )
         {
            dynBR_Encounter_ENCType.CurrentValue = StringUtil.RTrim( A90BR_Encounter_ENCType);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynBR_Encounter_ENCType_Internalname, "Values", dynBR_Encounter_ENCType.ToJavascriptSource(), true);
         }
         if ( dynBR_Encounter_AdmitSource.ItemCount > 0 )
         {
            A92BR_Encounter_AdmitSource = dynBR_Encounter_AdmitSource.getValidValue(A92BR_Encounter_AdmitSource);
            n92BR_Encounter_AdmitSource = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A92BR_Encounter_AdmitSource", A92BR_Encounter_AdmitSource);
         }
         if ( context.isAjaxRequest( ) )
         {
            dynBR_Encounter_AdmitSource.CurrentValue = StringUtil.RTrim( A92BR_Encounter_AdmitSource);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynBR_Encounter_AdmitSource_Internalname, "Values", dynBR_Encounter_AdmitSource.ToJavascriptSource(), true);
         }
         if ( dynBR_Encounter_DischargeStatus.ItemCount > 0 )
         {
            A94BR_Encounter_DischargeStatus = dynBR_Encounter_DischargeStatus.getValidValue(A94BR_Encounter_DischargeStatus);
            n94BR_Encounter_DischargeStatus = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A94BR_Encounter_DischargeStatus", A94BR_Encounter_DischargeStatus);
         }
         if ( context.isAjaxRequest( ) )
         {
            dynBR_Encounter_DischargeStatus.CurrentValue = StringUtil.RTrim( A94BR_Encounter_DischargeStatus);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynBR_Encounter_DischargeStatus_Internalname, "Values", dynBR_Encounter_DischargeStatus.ToJavascriptSource(), true);
         }
         if ( cmbBR_Encounter_Status.ItemCount > 0 )
         {
            A172BR_Encounter_Status = (short)(NumberUtil.Val( cmbBR_Encounter_Status.getValidValue(StringUtil.Trim( StringUtil.Str( (decimal)(A172BR_Encounter_Status), 4, 0))), "."));
            n172BR_Encounter_Status = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A172BR_Encounter_Status", StringUtil.LTrim( StringUtil.Str( (decimal)(A172BR_Encounter_Status), 4, 0)));
         }
         if ( context.isAjaxRequest( ) )
         {
            cmbBR_Encounter_Status.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(A172BR_Encounter_Status), 4, 0));
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbBR_Encounter_Status_Internalname, "Values", cmbBR_Encounter_Status.ToJavascriptSource(), true);
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
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
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
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-md-6 RequiredDataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtBR_Information_ID_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtBR_Information_ID_Internalname, "就诊序号", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 25,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtBR_Information_ID_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A85BR_Information_ID), 18, 0, ".", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(A85BR_Information_ID), "ZZZZZZZZZZZZZZZZZZ")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,25);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBR_Information_ID_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtBR_Information_ID_Enabled, 1, "number", "1", 18, "chr", 1, "row", 18, 0, 0, 0, 1, -1, 0, true, "ID", "right", false, "HLP_BR_Encounter.htm");
            /* Static images/pictures */
            ClassString = "gx-prompt Image";
            StyleString = "";
            sImgUrl = (String)(context.GetImagePath( "f5b04895-0024-488b-8e3b-b687ca4598ee", "", context.GetTheme( )));
            GxWebStd.gx_bitmap( context, imgprompt_85_Internalname, sImgUrl, imgprompt_85_Link, "", "", context.GetTheme( ), imgprompt_85_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 0, "", "", StyleString, ClassString, "", "", "", "", "", "", "", 1, false, false, context.GetImageSrcSet( sImgUrl), "HLP_BR_Encounter.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-md-6 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtBR_Information_PatientNo_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtBR_Information_PatientNo_Internalname, "患者编号", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtBR_Information_PatientNo_Internalname, A36BR_Information_PatientNo, StringUtil.RTrim( context.localUtil.Format( A36BR_Information_PatientNo, "")), "", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBR_Information_PatientNo_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtBR_Information_PatientNo_Enabled, 0, "text", "", 80, "chr", 1, "row", 2000, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_BR_Encounter.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-md-6 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divTablesplittedbr_encounter_department_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-3 MergeLabelCell", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblockbr_encounter_department_Internalname, "就诊科室", "", "", lblTextblockbr_encounter_department_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_BR_Encounter.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-9", "left", "top", "", "", "div");
            wb_table1_37_0E15( true) ;
         }
         return  ;
      }

      protected void wb_table1_37_0E15e( bool wbgen )
      {
         if ( wbgen )
         {
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-md-6 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divTablesplittedbr_encounter_enctype_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-3 MergeLabelCell", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblockbr_encounter_enctype_Internalname, "就诊方式", "", "", lblTextblockbr_encounter_enctype_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_BR_Encounter.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-9", "left", "top", "", "", "div");
            wb_table2_51_0E15( true) ;
         }
         return  ;
      }

      protected void wb_table2_51_0E15e( bool wbgen )
      {
         if ( wbgen )
         {
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-md-6 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtBR_Encounter_AdmitDate_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtBR_Encounter_AdmitDate_Internalname, "就诊/入院时间", "col-sm-3 AttributeDateLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 63,'',false,'',0)\"";
            context.WriteHtmlText( "<div id=\""+edtBR_Encounter_AdmitDate_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtBR_Encounter_AdmitDate_Internalname, context.localUtil.Format(A91BR_Encounter_AdmitDate, "9999/99/99"), context.localUtil.Format( A91BR_Encounter_AdmitDate, "9999/99/99"), TempTags+" onchange=\""+"gx.date.valid_date(this, 10,'YMD',0,24,'chs',false,1);"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,63);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBR_Encounter_AdmitDate_Jsonclick, 0, "AttributeDate", "", "", "", "", 1, edtBR_Encounter_AdmitDate_Enabled, 0, "text", "", 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, 0, true, "DM_Date", "right", false, "HLP_BR_Encounter.htm");
            GxWebStd.gx_bitmap( context, edtBR_Encounter_AdmitDate_Internalname+"_dp_trigger", context.GetImagePath( "61b9b5d3-dff6-4d59-9b00-da61bc2cbe93", "", context.GetTheme( )), "", "", "", "", ((1==0)||(edtBR_Encounter_AdmitDate_Enabled==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;", "", "", "", "", "", "", "", "", 1, false, false, "", "HLP_BR_Encounter.htm");
            context.WriteHtmlTextNl( "</div>") ;
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-md-6 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divTablesplittedbr_encounter_admitsource_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-3 MergeLabelCell", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblockbr_encounter_admitsource_Internalname, "入院原因", "", "", lblTextblockbr_encounter_admitsource_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_BR_Encounter.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-9", "left", "top", "", "", "div");
            wb_table3_70_0E15( true) ;
         }
         return  ;
      }

      protected void wb_table3_70_0E15e( bool wbgen )
      {
         if ( wbgen )
         {
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-md-6 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtBR_Encounter_DischargeDate_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtBR_Encounter_DischargeDate_Internalname, "出院时间", "col-sm-3 AttributeDateLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 82,'',false,'',0)\"";
            context.WriteHtmlText( "<div id=\""+edtBR_Encounter_DischargeDate_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtBR_Encounter_DischargeDate_Internalname, context.localUtil.Format(A93BR_Encounter_DischargeDate, "9999/99/99"), context.localUtil.Format( A93BR_Encounter_DischargeDate, "9999/99/99"), TempTags+" onchange=\""+"gx.date.valid_date(this, 10,'YMD',0,24,'chs',false,1);"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,82);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBR_Encounter_DischargeDate_Jsonclick, 0, "AttributeDate", "", "", "", "", 1, edtBR_Encounter_DischargeDate_Enabled, 0, "text", "", 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, 0, true, "DM_Date", "right", false, "HLP_BR_Encounter.htm");
            GxWebStd.gx_bitmap( context, edtBR_Encounter_DischargeDate_Internalname+"_dp_trigger", context.GetImagePath( "61b9b5d3-dff6-4d59-9b00-da61bc2cbe93", "", context.GetTheme( )), "", "", "", "", ((1==0)||(edtBR_Encounter_DischargeDate_Enabled==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;", "", "", "", "", "", "", "", "", 1, false, false, "", "HLP_BR_Encounter.htm");
            context.WriteHtmlTextNl( "</div>") ;
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-md-6 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+dynBR_Encounter_DischargeStatus_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, dynBR_Encounter_DischargeStatus_Internalname, "出院状态", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 86,'',false,'',0)\"";
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, dynBR_Encounter_DischargeStatus, dynBR_Encounter_DischargeStatus_Internalname, StringUtil.RTrim( A94BR_Encounter_DischargeStatus), 1, dynBR_Encounter_DischargeStatus_Jsonclick, 0, "'"+""+"'"+",false,"+"'"+""+"'", "svchar", "", 1, dynBR_Encounter_DischargeStatus.Enabled, 0, 0, 0, "em", 0, "", "", "Attribute", "", "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,86);\"", "", true, "HLP_BR_Encounter.htm");
            dynBR_Encounter_DischargeStatus.CurrentValue = StringUtil.RTrim( A94BR_Encounter_DischargeStatus);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynBR_Encounter_DischargeStatus_Internalname, "Values", (String)(dynBR_Encounter_DischargeStatus.ToJavascriptSource()), true);
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
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 91,'',false,'',0)\"";
            ClassString = "ButtonMaterial";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtntrn_enter_Internalname, "", "保存", bttBtntrn_enter_Jsonclick, 5, "确认", "", StyleString, ClassString, bttBtntrn_enter_Visible, bttBtntrn_enter_Enabled, "standard", "'"+""+"'"+",false,"+"'"+"EENTER."+"'", TempTags, "", context.GetButtonType( ), "HLP_BR_Encounter.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 93,'',false,'',0)\"";
            ClassString = "ButtonMaterialDefault";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtntrn_cancel_Internalname, "", "取消", bttBtntrn_cancel_Jsonclick, 1, "取消", "", StyleString, ClassString, bttBtntrn_cancel_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ECANCEL."+"'", TempTags, "", context.GetButtonType( ), "HLP_BR_Encounter.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 95,'',false,'',0)\"";
            ClassString = "ButtonMaterialDefault";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtntrn_delete_Internalname, "", "删除", bttBtntrn_delete_Jsonclick, 5, "删除", "", StyleString, ClassString, bttBtntrn_delete_Visible, bttBtntrn_delete_Enabled, "standard", "'"+""+"'"+",false,"+"'"+"EDELETE."+"'", TempTags, "", context.GetButtonType( ), "HLP_BR_Encounter.htm");
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
            GxWebStd.gx_single_line_edit( context, edtBR_EncounterID_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A19BR_EncounterID), 18, 0, ".", "")), ((edtBR_EncounterID_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A19BR_EncounterID), "ZZZZZZZZZZZZZZZZZZ")) : context.localUtil.Format( (decimal)(A19BR_EncounterID), "ZZZZZZZZZZZZZZZZZZ")), "", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBR_EncounterID_Jsonclick, 0, "Attribute", "", "", "", "", edtBR_EncounterID_Visible, edtBR_EncounterID_Enabled, 0, "number", "1", 18, "chr", 1, "row", 18, 0, 0, 0, 1, -1, 0, true, "ID", "right", false, "HLP_BR_Encounter.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 100,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtBR_Encounter_EncID_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A35BR_Encounter_EncID), 10, 0, ".", "")), ((edtBR_Encounter_EncID_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A35BR_Encounter_EncID), "ZZZZZZZZZZ")) : context.localUtil.Format( (decimal)(A35BR_Encounter_EncID), "ZZZZZZZZZZ")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,100);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBR_Encounter_EncID_Jsonclick, 0, "Attribute", "", "", "", "", edtBR_Encounter_EncID_Visible, edtBR_Encounter_EncID_Enabled, 0, "number", "1", 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_BR_Encounter.htm");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 101,'',false,'',0)\"";
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, cmbBR_Encounter_Status, cmbBR_Encounter_Status_Internalname, StringUtil.Trim( StringUtil.Str( (decimal)(A172BR_Encounter_Status), 4, 0)), 1, cmbBR_Encounter_Status_Jsonclick, 0, "'"+""+"'"+",false,"+"'"+""+"'", "int", "", cmbBR_Encounter_Status.Visible, cmbBR_Encounter_Status.Enabled, 1, 0, 0, "em", 0, "", "", "Attribute", "", "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,101);\"", "", true, "HLP_BR_Encounter.htm");
            cmbBR_Encounter_Status.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(A172BR_Encounter_Status), 4, 0));
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbBR_Encounter_Status_Internalname, "Values", (String)(cmbBR_Encounter_Status.ToJavascriptSource()), true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 102,'',false,'',0)\"";
            context.WriteHtmlText( "<div id=\""+edtBR_Encounter_CrtDate_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtBR_Encounter_CrtDate_Internalname, context.localUtil.TToC( A182BR_Encounter_CrtDate, 10, 8, 0, 0, "/", ":", " "), context.localUtil.Format( A182BR_Encounter_CrtDate, "9999/99/99 99:99:99"), TempTags+" onchange=\""+"gx.date.valid_date(this, 10,'YMD',8,24,'chs',false,1);"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,102);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBR_Encounter_CrtDate_Jsonclick, 0, "Attribute", "", "", "", "", edtBR_Encounter_CrtDate_Visible, edtBR_Encounter_CrtDate_Enabled, 0, "text", "", 19, "chr", 1, "row", 19, 0, 0, 0, 1, -1, 0, true, "UpdDate", "right", false, "HLP_BR_Encounter.htm");
            GxWebStd.gx_bitmap( context, edtBR_Encounter_CrtDate_Internalname+"_dp_trigger", context.GetImagePath( "61b9b5d3-dff6-4d59-9b00-da61bc2cbe93", "", context.GetTheme( )), "", "", "", "", ((edtBR_Encounter_CrtDate_Visible==0)||(edtBR_Encounter_CrtDate_Enabled==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;", "", "", "", "", "", "", "", "", 1, false, false, "", "HLP_BR_Encounter.htm");
            context.WriteHtmlTextNl( "</div>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 103,'',false,'',0)\"";
            context.WriteHtmlText( "<div id=\""+edtBR_Encounter_UpdDate_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtBR_Encounter_UpdDate_Internalname, context.localUtil.TToC( A187BR_Encounter_UpdDate, 10, 8, 0, 0, "/", ":", " "), context.localUtil.Format( A187BR_Encounter_UpdDate, "9999/99/99 99:99:99"), TempTags+" onchange=\""+"gx.date.valid_date(this, 10,'YMD',8,24,'chs',false,1);"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,103);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBR_Encounter_UpdDate_Jsonclick, 0, "Attribute", "", "", "", "", edtBR_Encounter_UpdDate_Visible, edtBR_Encounter_UpdDate_Enabled, 0, "text", "", 19, "chr", 1, "row", 19, 0, 0, 0, 1, -1, 0, true, "UpdDate", "right", false, "HLP_BR_Encounter.htm");
            GxWebStd.gx_bitmap( context, edtBR_Encounter_UpdDate_Internalname+"_dp_trigger", context.GetImagePath( "61b9b5d3-dff6-4d59-9b00-da61bc2cbe93", "", context.GetTheme( )), "", "", "", "", ((edtBR_Encounter_UpdDate_Visible==0)||(edtBR_Encounter_UpdDate_Enabled==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;", "", "", "", "", "", "", "", "", 1, false, false, "", "HLP_BR_Encounter.htm");
            context.WriteHtmlTextNl( "</div>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 104,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtBR_Encounter_CrtUser_Internalname, A183BR_Encounter_CrtUser, StringUtil.RTrim( context.localUtil.Format( A183BR_Encounter_CrtUser, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,104);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBR_Encounter_CrtUser_Jsonclick, 0, "Attribute", "", "", "", "", edtBR_Encounter_CrtUser_Visible, edtBR_Encounter_CrtUser_Enabled, 0, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, -1, true, "CrtUser", "left", true, "HLP_BR_Encounter.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 105,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtBR_Encounter_UpdUser_Internalname, A186BR_Encounter_UpdUser, StringUtil.RTrim( context.localUtil.Format( A186BR_Encounter_UpdUser, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,105);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBR_Encounter_UpdUser_Jsonclick, 0, "Attribute", "", "", "", "", edtBR_Encounter_UpdUser_Visible, edtBR_Encounter_UpdUser_Enabled, 0, "text", "", 40, "chr", 1, "row", 40, 0, 0, 0, 1, -1, -1, true, "UpdUser", "left", true, "HLP_BR_Encounter.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            fix_multi_value_controls( ) ;
         }
         /* Execute Exit event if defined. */
      }

      protected void wb_table3_70_0E15( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "";
            GxWebStd.gx_table_start( context, tblTablemergedbr_encounter_admitsource_Internalname, tblTablemergedbr_encounter_admitsource_Internalname, "", "TableMerged", 0, "", "", 0, 0, sStyleString, "", "", 0);
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td class='MergeDataCell'>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, dynBR_Encounter_AdmitSource_Internalname, "入院原因", "col-sm-3 AttributeLabel", 0, true);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 74,'',false,'',0)\"";
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, dynBR_Encounter_AdmitSource, dynBR_Encounter_AdmitSource_Internalname, StringUtil.RTrim( A92BR_Encounter_AdmitSource), 1, dynBR_Encounter_AdmitSource_Jsonclick, 0, "'"+""+"'"+",false,"+"'"+""+"'", "svchar", "", 1, dynBR_Encounter_AdmitSource.Enabled, 0, 0, 0, "em", 0, "", "", "Attribute", "", "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,74);\"", "", true, "HLP_BR_Encounter.htm");
            dynBR_Encounter_AdmitSource.CurrentValue = StringUtil.RTrim( A92BR_Encounter_AdmitSource);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynBR_Encounter_AdmitSource_Internalname, "Values", (String)(dynBR_Encounter_AdmitSource.ToJavascriptSource()), true);
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td id=\""+cellVreason_cell_Internalname+"\"  class='"+cellVreason_cell_Class+"'>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavVreason_Internalname, "v Reason", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 77,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavVreason_Internalname, AV27vReason, StringUtil.RTrim( context.localUtil.Format( AV27vReason, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,77);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "请填写其他入院原因", edtavVreason_Jsonclick, 0, "Attribute", "", "", "", "", edtavVreason_Visible, edtavVreason_Enabled, 0, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_BR_Encounter.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table3_70_0E15e( true) ;
         }
         else
         {
            wb_table3_70_0E15e( false) ;
         }
      }

      protected void wb_table2_51_0E15( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "";
            GxWebStd.gx_table_start( context, tblTablemergedbr_encounter_enctype_Internalname, tblTablemergedbr_encounter_enctype_Internalname, "", "TableMerged", 0, "", "", 0, 0, sStyleString, "", "", 0);
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td class='MergeDataCell'>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, dynBR_Encounter_ENCType_Internalname, "就诊方式", "col-sm-3 AttributeLabel", 0, true);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 55,'',false,'',0)\"";
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, dynBR_Encounter_ENCType, dynBR_Encounter_ENCType_Internalname, StringUtil.RTrim( A90BR_Encounter_ENCType), 1, dynBR_Encounter_ENCType_Jsonclick, 0, "'"+""+"'"+",false,"+"'"+""+"'", "svchar", "", 1, dynBR_Encounter_ENCType.Enabled, 0, 0, 0, "em", 0, "", "", "Attribute", "", "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,55);\"", "", true, "HLP_BR_Encounter.htm");
            dynBR_Encounter_ENCType.CurrentValue = StringUtil.RTrim( A90BR_Encounter_ENCType);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynBR_Encounter_ENCType_Internalname, "Values", (String)(dynBR_Encounter_ENCType.ToJavascriptSource()), true);
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td id=\""+cellVenctype_cell_Internalname+"\"  class='"+cellVenctype_cell_Class+"'>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavVenctype_Internalname, "v ENCType", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 58,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavVenctype_Internalname, AV26vENCType, StringUtil.RTrim( context.localUtil.Format( AV26vENCType, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,58);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "请填写其它就诊方式", edtavVenctype_Jsonclick, 0, "Attribute", "", "", "", "", edtavVenctype_Visible, edtavVenctype_Enabled, 0, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_BR_Encounter.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table2_51_0E15e( true) ;
         }
         else
         {
            wb_table2_51_0E15e( false) ;
         }
      }

      protected void wb_table1_37_0E15( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "";
            GxWebStd.gx_table_start( context, tblTablemergedbr_encounter_department_Internalname, tblTablemergedbr_encounter_department_Internalname, "", "TableMerged", 0, "", "", 0, 0, sStyleString, "", "", 0);
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td class='MergeDataCell'>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, dynBR_Encounter_Department_Internalname, "就诊科室", "col-sm-3 AttributeLabel", 0, true);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 41,'',false,'',0)\"";
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, dynBR_Encounter_Department, dynBR_Encounter_Department_Internalname, StringUtil.RTrim( A84BR_Encounter_Department), 1, dynBR_Encounter_Department_Jsonclick, 0, "'"+""+"'"+",false,"+"'"+""+"'", "svchar", "", 1, dynBR_Encounter_Department.Enabled, 0, 0, 0, "em", 0, "", "", "Attribute", "", "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,41);\"", "", true, "HLP_BR_Encounter.htm");
            dynBR_Encounter_Department.CurrentValue = StringUtil.RTrim( A84BR_Encounter_Department);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynBR_Encounter_Department_Internalname, "Values", (String)(dynBR_Encounter_Department.ToJavascriptSource()), true);
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td id=\""+cellVdepartment_cell_Internalname+"\"  class='"+cellVdepartment_cell_Class+"'>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavVdepartment_Internalname, "v Department", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 44,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavVdepartment_Internalname, AV24vDepartment, StringUtil.RTrim( context.localUtil.Format( AV24vDepartment, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,44);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "请填写其他就诊科室", edtavVdepartment_Jsonclick, 0, "Attribute", "", "", "", "", edtavVdepartment_Visible, edtavVdepartment_Enabled, 0, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_BR_Encounter.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table1_37_0E15e( true) ;
         }
         else
         {
            wb_table1_37_0E15e( false) ;
         }
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
         E110E2 ();
         context.wbGlbDoneStart = 1;
         assign_properties_default( ) ;
         if ( AnyError == 0 )
         {
            if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
            {
               /* Read saved SDTs. */
               /* Read variables values. */
               if ( ( ( context.localUtil.CToN( cgiGet( edtBR_Information_ID_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtBR_Information_ID_Internalname), ".", ",") > Convert.ToDecimal( 999999999999999999L )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "BR_INFORMATION_ID");
                  AnyError = 1;
                  GX_FocusControl = edtBR_Information_ID_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A85BR_Information_ID = 0;
                  n85BR_Information_ID = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A85BR_Information_ID", StringUtil.LTrim( StringUtil.Str( (decimal)(A85BR_Information_ID), 18, 0)));
               }
               else
               {
                  A85BR_Information_ID = (long)(context.localUtil.CToN( cgiGet( edtBR_Information_ID_Internalname), ".", ","));
                  n85BR_Information_ID = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A85BR_Information_ID", StringUtil.LTrim( StringUtil.Str( (decimal)(A85BR_Information_ID), 18, 0)));
               }
               n85BR_Information_ID = ((0==A85BR_Information_ID) ? true : false);
               A36BR_Information_PatientNo = cgiGet( edtBR_Information_PatientNo_Internalname);
               n36BR_Information_PatientNo = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A36BR_Information_PatientNo", A36BR_Information_PatientNo);
               dynBR_Encounter_Department.CurrentValue = cgiGet( dynBR_Encounter_Department_Internalname);
               A84BR_Encounter_Department = cgiGet( dynBR_Encounter_Department_Internalname);
               n84BR_Encounter_Department = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A84BR_Encounter_Department", A84BR_Encounter_Department);
               n84BR_Encounter_Department = (String.IsNullOrEmpty(StringUtil.RTrim( A84BR_Encounter_Department)) ? true : false);
               AV24vDepartment = cgiGet( edtavVdepartment_Internalname);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV24vDepartment", AV24vDepartment);
               dynBR_Encounter_ENCType.CurrentValue = cgiGet( dynBR_Encounter_ENCType_Internalname);
               A90BR_Encounter_ENCType = cgiGet( dynBR_Encounter_ENCType_Internalname);
               n90BR_Encounter_ENCType = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A90BR_Encounter_ENCType", A90BR_Encounter_ENCType);
               n90BR_Encounter_ENCType = (String.IsNullOrEmpty(StringUtil.RTrim( A90BR_Encounter_ENCType)) ? true : false);
               AV26vENCType = cgiGet( edtavVenctype_Internalname);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV26vENCType", AV26vENCType);
               if ( context.localUtil.VCDate( cgiGet( edtBR_Encounter_AdmitDate_Internalname), 0) == 0 )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_faildate", new   object[]  {"就诊/入院时间"}), 1, "BR_ENCOUNTER_ADMITDATE");
                  AnyError = 1;
                  GX_FocusControl = edtBR_Encounter_AdmitDate_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A91BR_Encounter_AdmitDate = DateTime.MinValue;
                  n91BR_Encounter_AdmitDate = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A91BR_Encounter_AdmitDate", context.localUtil.Format(A91BR_Encounter_AdmitDate, "9999/99/99"));
               }
               else
               {
                  A91BR_Encounter_AdmitDate = context.localUtil.CToD( cgiGet( edtBR_Encounter_AdmitDate_Internalname), 0);
                  n91BR_Encounter_AdmitDate = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A91BR_Encounter_AdmitDate", context.localUtil.Format(A91BR_Encounter_AdmitDate, "9999/99/99"));
               }
               n91BR_Encounter_AdmitDate = ((DateTime.MinValue==A91BR_Encounter_AdmitDate) ? true : false);
               dynBR_Encounter_AdmitSource.CurrentValue = cgiGet( dynBR_Encounter_AdmitSource_Internalname);
               A92BR_Encounter_AdmitSource = cgiGet( dynBR_Encounter_AdmitSource_Internalname);
               n92BR_Encounter_AdmitSource = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A92BR_Encounter_AdmitSource", A92BR_Encounter_AdmitSource);
               n92BR_Encounter_AdmitSource = (String.IsNullOrEmpty(StringUtil.RTrim( A92BR_Encounter_AdmitSource)) ? true : false);
               AV27vReason = cgiGet( edtavVreason_Internalname);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV27vReason", AV27vReason);
               if ( context.localUtil.VCDate( cgiGet( edtBR_Encounter_DischargeDate_Internalname), 0) == 0 )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_faildate", new   object[]  {"出院时间"}), 1, "BR_ENCOUNTER_DISCHARGEDATE");
                  AnyError = 1;
                  GX_FocusControl = edtBR_Encounter_DischargeDate_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A93BR_Encounter_DischargeDate = DateTime.MinValue;
                  n93BR_Encounter_DischargeDate = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A93BR_Encounter_DischargeDate", context.localUtil.Format(A93BR_Encounter_DischargeDate, "9999/99/99"));
               }
               else
               {
                  A93BR_Encounter_DischargeDate = context.localUtil.CToD( cgiGet( edtBR_Encounter_DischargeDate_Internalname), 0);
                  n93BR_Encounter_DischargeDate = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A93BR_Encounter_DischargeDate", context.localUtil.Format(A93BR_Encounter_DischargeDate, "9999/99/99"));
               }
               n93BR_Encounter_DischargeDate = ((DateTime.MinValue==A93BR_Encounter_DischargeDate) ? true : false);
               dynBR_Encounter_DischargeStatus.CurrentValue = cgiGet( dynBR_Encounter_DischargeStatus_Internalname);
               A94BR_Encounter_DischargeStatus = cgiGet( dynBR_Encounter_DischargeStatus_Internalname);
               n94BR_Encounter_DischargeStatus = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A94BR_Encounter_DischargeStatus", A94BR_Encounter_DischargeStatus);
               n94BR_Encounter_DischargeStatus = (String.IsNullOrEmpty(StringUtil.RTrim( A94BR_Encounter_DischargeStatus)) ? true : false);
               A19BR_EncounterID = (long)(context.localUtil.CToN( cgiGet( edtBR_EncounterID_Internalname), ".", ","));
               n19BR_EncounterID = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A19BR_EncounterID", StringUtil.LTrim( StringUtil.Str( (decimal)(A19BR_EncounterID), 18, 0)));
               if ( ( ( context.localUtil.CToN( cgiGet( edtBR_Encounter_EncID_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtBR_Encounter_EncID_Internalname), ".", ",") > Convert.ToDecimal( 9999999999L )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "BR_ENCOUNTER_ENCID");
                  AnyError = 1;
                  GX_FocusControl = edtBR_Encounter_EncID_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A35BR_Encounter_EncID = 0;
                  n35BR_Encounter_EncID = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A35BR_Encounter_EncID", StringUtil.LTrim( StringUtil.Str( (decimal)(A35BR_Encounter_EncID), 10, 0)));
               }
               else
               {
                  A35BR_Encounter_EncID = (long)(context.localUtil.CToN( cgiGet( edtBR_Encounter_EncID_Internalname), ".", ","));
                  n35BR_Encounter_EncID = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A35BR_Encounter_EncID", StringUtil.LTrim( StringUtil.Str( (decimal)(A35BR_Encounter_EncID), 10, 0)));
               }
               n35BR_Encounter_EncID = ((0==A35BR_Encounter_EncID) ? true : false);
               cmbBR_Encounter_Status.CurrentValue = cgiGet( cmbBR_Encounter_Status_Internalname);
               A172BR_Encounter_Status = (short)(NumberUtil.Val( cgiGet( cmbBR_Encounter_Status_Internalname), "."));
               n172BR_Encounter_Status = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A172BR_Encounter_Status", StringUtil.LTrim( StringUtil.Str( (decimal)(A172BR_Encounter_Status), 4, 0)));
               n172BR_Encounter_Status = ((0==A172BR_Encounter_Status) ? true : false);
               if ( context.localUtil.VCDateTime( cgiGet( edtBR_Encounter_CrtDate_Internalname), 0, 0) == 0 )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_baddatetime", new   object[]  {"创建时间"}), 1, "BR_ENCOUNTER_CRTDATE");
                  AnyError = 1;
                  GX_FocusControl = edtBR_Encounter_CrtDate_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A182BR_Encounter_CrtDate = (DateTime)(DateTime.MinValue);
                  n182BR_Encounter_CrtDate = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A182BR_Encounter_CrtDate", context.localUtil.TToC( A182BR_Encounter_CrtDate, 10, 8, 0, 0, "/", ":", " "));
               }
               else
               {
                  A182BR_Encounter_CrtDate = context.localUtil.CToT( cgiGet( edtBR_Encounter_CrtDate_Internalname));
                  n182BR_Encounter_CrtDate = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A182BR_Encounter_CrtDate", context.localUtil.TToC( A182BR_Encounter_CrtDate, 10, 8, 0, 0, "/", ":", " "));
               }
               n182BR_Encounter_CrtDate = ((DateTime.MinValue==A182BR_Encounter_CrtDate) ? true : false);
               if ( context.localUtil.VCDateTime( cgiGet( edtBR_Encounter_UpdDate_Internalname), 0, 0) == 0 )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_baddatetime", new   object[]  {"修改时间"}), 1, "BR_ENCOUNTER_UPDDATE");
                  AnyError = 1;
                  GX_FocusControl = edtBR_Encounter_UpdDate_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A187BR_Encounter_UpdDate = (DateTime)(DateTime.MinValue);
                  n187BR_Encounter_UpdDate = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A187BR_Encounter_UpdDate", context.localUtil.TToC( A187BR_Encounter_UpdDate, 10, 8, 0, 0, "/", ":", " "));
               }
               else
               {
                  A187BR_Encounter_UpdDate = context.localUtil.CToT( cgiGet( edtBR_Encounter_UpdDate_Internalname));
                  n187BR_Encounter_UpdDate = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A187BR_Encounter_UpdDate", context.localUtil.TToC( A187BR_Encounter_UpdDate, 10, 8, 0, 0, "/", ":", " "));
               }
               n187BR_Encounter_UpdDate = ((DateTime.MinValue==A187BR_Encounter_UpdDate) ? true : false);
               A183BR_Encounter_CrtUser = cgiGet( edtBR_Encounter_CrtUser_Internalname);
               n183BR_Encounter_CrtUser = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A183BR_Encounter_CrtUser", A183BR_Encounter_CrtUser);
               n183BR_Encounter_CrtUser = (String.IsNullOrEmpty(StringUtil.RTrim( A183BR_Encounter_CrtUser)) ? true : false);
               A186BR_Encounter_UpdUser = cgiGet( edtBR_Encounter_UpdUser_Internalname);
               n186BR_Encounter_UpdUser = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A186BR_Encounter_UpdUser", A186BR_Encounter_UpdUser);
               n186BR_Encounter_UpdUser = (String.IsNullOrEmpty(StringUtil.RTrim( A186BR_Encounter_UpdUser)) ? true : false);
               /* Read saved values. */
               Z19BR_EncounterID = (long)(context.localUtil.CToN( cgiGet( "Z19BR_EncounterID"), ".", ","));
               Z35BR_Encounter_EncID = (long)(context.localUtil.CToN( cgiGet( "Z35BR_Encounter_EncID"), ".", ","));
               n35BR_Encounter_EncID = ((0==A35BR_Encounter_EncID) ? true : false);
               Z172BR_Encounter_Status = (short)(context.localUtil.CToN( cgiGet( "Z172BR_Encounter_Status"), ".", ","));
               n172BR_Encounter_Status = ((0==A172BR_Encounter_Status) ? true : false);
               Z183BR_Encounter_CrtUser = cgiGet( "Z183BR_Encounter_CrtUser");
               n183BR_Encounter_CrtUser = (String.IsNullOrEmpty(StringUtil.RTrim( A183BR_Encounter_CrtUser)) ? true : false);
               Z512BR_Encounter_CrtDisplayName = cgiGet( "Z512BR_Encounter_CrtDisplayName");
               n512BR_Encounter_CrtDisplayName = (String.IsNullOrEmpty(StringUtil.RTrim( A512BR_Encounter_CrtDisplayName)) ? true : false);
               Z182BR_Encounter_CrtDate = context.localUtil.CToT( cgiGet( "Z182BR_Encounter_CrtDate"), 0);
               n182BR_Encounter_CrtDate = ((DateTime.MinValue==A182BR_Encounter_CrtDate) ? true : false);
               Z470BR_Encounter_Department_Code = cgiGet( "Z470BR_Encounter_Department_Code");
               n470BR_Encounter_Department_Code = (String.IsNullOrEmpty(StringUtil.RTrim( A470BR_Encounter_Department_Code)) ? true : false);
               Z471BR_Encounter_ENCType_Code = cgiGet( "Z471BR_Encounter_ENCType_Code");
               n471BR_Encounter_ENCType_Code = (String.IsNullOrEmpty(StringUtil.RTrim( A471BR_Encounter_ENCType_Code)) ? true : false);
               Z472BR_Encounter_AdmitSource_Code = cgiGet( "Z472BR_Encounter_AdmitSource_Code");
               n472BR_Encounter_AdmitSource_Code = (String.IsNullOrEmpty(StringUtil.RTrim( A472BR_Encounter_AdmitSource_Code)) ? true : false);
               Z473BR_Encounter_DischargeStatus_Code = cgiGet( "Z473BR_Encounter_DischargeStatus_Code");
               n473BR_Encounter_DischargeStatus_Code = (String.IsNullOrEmpty(StringUtil.RTrim( A473BR_Encounter_DischargeStatus_Code)) ? true : false);
               Z84BR_Encounter_Department = cgiGet( "Z84BR_Encounter_Department");
               n84BR_Encounter_Department = (String.IsNullOrEmpty(StringUtil.RTrim( A84BR_Encounter_Department)) ? true : false);
               Z570BR_Encounter_Departmentadm = cgiGet( "Z570BR_Encounter_Departmentadm");
               n570BR_Encounter_Departmentadm = (String.IsNullOrEmpty(StringUtil.RTrim( A570BR_Encounter_Departmentadm)) ? true : false);
               Z571BR_Encounter_Departmentadm_Code = cgiGet( "Z571BR_Encounter_Departmentadm_Code");
               n571BR_Encounter_Departmentadm_Code = (String.IsNullOrEmpty(StringUtil.RTrim( A571BR_Encounter_Departmentadm_Code)) ? true : false);
               Z572BR_Encounter_Departmentdisch = cgiGet( "Z572BR_Encounter_Departmentdisch");
               n572BR_Encounter_Departmentdisch = (String.IsNullOrEmpty(StringUtil.RTrim( A572BR_Encounter_Departmentdisch)) ? true : false);
               Z573BR_Encounter_Departmentdisch_Code = cgiGet( "Z573BR_Encounter_Departmentdisch_Code");
               n573BR_Encounter_Departmentdisch_Code = (String.IsNullOrEmpty(StringUtil.RTrim( A573BR_Encounter_Departmentdisch_Code)) ? true : false);
               Z90BR_Encounter_ENCType = cgiGet( "Z90BR_Encounter_ENCType");
               n90BR_Encounter_ENCType = (String.IsNullOrEmpty(StringUtil.RTrim( A90BR_Encounter_ENCType)) ? true : false);
               Z91BR_Encounter_AdmitDate = context.localUtil.CToD( cgiGet( "Z91BR_Encounter_AdmitDate"), 0);
               n91BR_Encounter_AdmitDate = ((DateTime.MinValue==A91BR_Encounter_AdmitDate) ? true : false);
               Z92BR_Encounter_AdmitSource = cgiGet( "Z92BR_Encounter_AdmitSource");
               n92BR_Encounter_AdmitSource = (String.IsNullOrEmpty(StringUtil.RTrim( A92BR_Encounter_AdmitSource)) ? true : false);
               Z93BR_Encounter_DischargeDate = context.localUtil.CToD( cgiGet( "Z93BR_Encounter_DischargeDate"), 0);
               n93BR_Encounter_DischargeDate = ((DateTime.MinValue==A93BR_Encounter_DischargeDate) ? true : false);
               Z94BR_Encounter_DischargeStatus = cgiGet( "Z94BR_Encounter_DischargeStatus");
               n94BR_Encounter_DischargeStatus = (String.IsNullOrEmpty(StringUtil.RTrim( A94BR_Encounter_DischargeStatus)) ? true : false);
               Z574BR_Encounter_Insurance = cgiGet( "Z574BR_Encounter_Insurance");
               n574BR_Encounter_Insurance = (String.IsNullOrEmpty(StringUtil.RTrim( A574BR_Encounter_Insurance)) ? true : false);
               Z575BR_Encounter_Insurance_Code = cgiGet( "Z575BR_Encounter_Insurance_Code");
               n575BR_Encounter_Insurance_Code = (String.IsNullOrEmpty(StringUtil.RTrim( A575BR_Encounter_Insurance_Code)) ? true : false);
               Z187BR_Encounter_UpdDate = context.localUtil.CToT( cgiGet( "Z187BR_Encounter_UpdDate"), 0);
               n187BR_Encounter_UpdDate = ((DateTime.MinValue==A187BR_Encounter_UpdDate) ? true : false);
               Z186BR_Encounter_UpdUser = cgiGet( "Z186BR_Encounter_UpdUser");
               n186BR_Encounter_UpdUser = (String.IsNullOrEmpty(StringUtil.RTrim( A186BR_Encounter_UpdUser)) ? true : false);
               Z333BR_Encounter_IsDLT = StringUtil.StrToBool( cgiGet( "Z333BR_Encounter_IsDLT"));
               n333BR_Encounter_IsDLT = ((false==A333BR_Encounter_IsDLT) ? true : false);
               Z184BR_Encounter_SubmitUser = cgiGet( "Z184BR_Encounter_SubmitUser");
               n184BR_Encounter_SubmitUser = (String.IsNullOrEmpty(StringUtil.RTrim( A184BR_Encounter_SubmitUser)) ? true : false);
               Z335BR_Encounter_Reason = cgiGet( "Z335BR_Encounter_Reason");
               n335BR_Encounter_Reason = (String.IsNullOrEmpty(StringUtil.RTrim( A335BR_Encounter_Reason)) ? true : false);
               Z185BR_Encounter_SubmitDate = context.localUtil.CToT( cgiGet( "Z185BR_Encounter_SubmitDate"), 0);
               n185BR_Encounter_SubmitDate = ((DateTime.MinValue==A185BR_Encounter_SubmitDate) ? true : false);
               Z188BR_Encounter_RecheckUser = cgiGet( "Z188BR_Encounter_RecheckUser");
               n188BR_Encounter_RecheckUser = (String.IsNullOrEmpty(StringUtil.RTrim( A188BR_Encounter_RecheckUser)) ? true : false);
               Z336BR_Encounter_FReason = cgiGet( "Z336BR_Encounter_FReason");
               n336BR_Encounter_FReason = (String.IsNullOrEmpty(StringUtil.RTrim( A336BR_Encounter_FReason)) ? true : false);
               Z189BR_Encounter_RecheckDate = context.localUtil.CToT( cgiGet( "Z189BR_Encounter_RecheckDate"), 0);
               n189BR_Encounter_RecheckDate = ((DateTime.MinValue==A189BR_Encounter_RecheckDate) ? true : false);
               Z190BR_Encounter_Approver = cgiGet( "Z190BR_Encounter_Approver");
               n190BR_Encounter_Approver = (String.IsNullOrEmpty(StringUtil.RTrim( A190BR_Encounter_Approver)) ? true : false);
               Z191BR_Encounter_ApproveDate = context.localUtil.CToT( cgiGet( "Z191BR_Encounter_ApproveDate"), 0);
               n191BR_Encounter_ApproveDate = ((DateTime.MinValue==A191BR_Encounter_ApproveDate) ? true : false);
               Z192BR_Encounter_IsRandApprove = StringUtil.StrToBool( cgiGet( "Z192BR_Encounter_IsRandApprove"));
               n192BR_Encounter_IsRandApprove = ((false==A192BR_Encounter_IsRandApprove) ? true : false);
               Z203BR_Encounter_IsRandApprover = cgiGet( "Z203BR_Encounter_IsRandApprover");
               n203BR_Encounter_IsRandApprover = (String.IsNullOrEmpty(StringUtil.RTrim( A203BR_Encounter_IsRandApprover)) ? true : false);
               Z204BR_Encounter_IsRandNoApprover = cgiGet( "Z204BR_Encounter_IsRandNoApprover");
               n204BR_Encounter_IsRandNoApprover = (String.IsNullOrEmpty(StringUtil.RTrim( A204BR_Encounter_IsRandNoApprover)) ? true : false);
               Z205BR_Encounter_IsRandApproveDate = context.localUtil.CToT( cgiGet( "Z205BR_Encounter_IsRandApproveDate"), 0);
               n205BR_Encounter_IsRandApproveDate = ((DateTime.MinValue==A205BR_Encounter_IsRandApproveDate) ? true : false);
               Z206BR_Encounter_IsRandNoApproveDate = context.localUtil.CToT( cgiGet( "Z206BR_Encounter_IsRandNoApproveDate"), 0);
               n206BR_Encounter_IsRandNoApproveDate = ((DateTime.MinValue==A206BR_Encounter_IsRandNoApproveDate) ? true : false);
               Z193BR_Encounter_IsRandRecheck = StringUtil.StrToBool( cgiGet( "Z193BR_Encounter_IsRandRecheck"));
               n193BR_Encounter_IsRandRecheck = ((false==A193BR_Encounter_IsRandRecheck) ? true : false);
               Z207BR_Encounter_IsRandRecheckr = cgiGet( "Z207BR_Encounter_IsRandRecheckr");
               n207BR_Encounter_IsRandRecheckr = (String.IsNullOrEmpty(StringUtil.RTrim( A207BR_Encounter_IsRandRecheckr)) ? true : false);
               Z208BR_Encounter_IsRandNoRecheckr = cgiGet( "Z208BR_Encounter_IsRandNoRecheckr");
               n208BR_Encounter_IsRandNoRecheckr = (String.IsNullOrEmpty(StringUtil.RTrim( A208BR_Encounter_IsRandNoRecheckr)) ? true : false);
               Z209BR_Encounter_IsRandRecheckDate = context.localUtil.CToT( cgiGet( "Z209BR_Encounter_IsRandRecheckDate"), 0);
               n209BR_Encounter_IsRandRecheckDate = ((DateTime.MinValue==A209BR_Encounter_IsRandRecheckDate) ? true : false);
               Z210BR_Encounter_IsRandNoRecheckDate = context.localUtil.CToT( cgiGet( "Z210BR_Encounter_IsRandNoRecheckDate"), 0);
               n210BR_Encounter_IsRandNoRecheckDate = ((DateTime.MinValue==A210BR_Encounter_IsRandNoRecheckDate) ? true : false);
               Z202BR_Encounter_IsUpdate = StringUtil.StrToBool( cgiGet( "Z202BR_Encounter_IsUpdate"));
               n202BR_Encounter_IsUpdate = ((false==A202BR_Encounter_IsUpdate) ? true : false);
               Z537BR_Encounter_Datasource = (short)(context.localUtil.CToN( cgiGet( "Z537BR_Encounter_Datasource"), ".", ","));
               n537BR_Encounter_Datasource = ((0==A537BR_Encounter_Datasource) ? true : false);
               Z560EncounterIDEncrypt = cgiGet( "Z560EncounterIDEncrypt");
               n560EncounterIDEncrypt = (String.IsNullOrEmpty(StringUtil.RTrim( A560EncounterIDEncrypt)) ? true : false);
               Z85BR_Information_ID = (long)(context.localUtil.CToN( cgiGet( "Z85BR_Information_ID"), ".", ","));
               n85BR_Information_ID = ((0==A85BR_Information_ID) ? true : false);
               Z360BAS_TenantTenantCode = cgiGet( "Z360BAS_TenantTenantCode");
               n360BAS_TenantTenantCode = (String.IsNullOrEmpty(StringUtil.RTrim( A360BAS_TenantTenantCode)) ? true : false);
               A512BR_Encounter_CrtDisplayName = cgiGet( "Z512BR_Encounter_CrtDisplayName");
               n512BR_Encounter_CrtDisplayName = false;
               n512BR_Encounter_CrtDisplayName = (String.IsNullOrEmpty(StringUtil.RTrim( A512BR_Encounter_CrtDisplayName)) ? true : false);
               A470BR_Encounter_Department_Code = cgiGet( "Z470BR_Encounter_Department_Code");
               n470BR_Encounter_Department_Code = false;
               n470BR_Encounter_Department_Code = (String.IsNullOrEmpty(StringUtil.RTrim( A470BR_Encounter_Department_Code)) ? true : false);
               A471BR_Encounter_ENCType_Code = cgiGet( "Z471BR_Encounter_ENCType_Code");
               n471BR_Encounter_ENCType_Code = false;
               n471BR_Encounter_ENCType_Code = (String.IsNullOrEmpty(StringUtil.RTrim( A471BR_Encounter_ENCType_Code)) ? true : false);
               A472BR_Encounter_AdmitSource_Code = cgiGet( "Z472BR_Encounter_AdmitSource_Code");
               n472BR_Encounter_AdmitSource_Code = false;
               n472BR_Encounter_AdmitSource_Code = (String.IsNullOrEmpty(StringUtil.RTrim( A472BR_Encounter_AdmitSource_Code)) ? true : false);
               A473BR_Encounter_DischargeStatus_Code = cgiGet( "Z473BR_Encounter_DischargeStatus_Code");
               n473BR_Encounter_DischargeStatus_Code = false;
               n473BR_Encounter_DischargeStatus_Code = (String.IsNullOrEmpty(StringUtil.RTrim( A473BR_Encounter_DischargeStatus_Code)) ? true : false);
               A570BR_Encounter_Departmentadm = cgiGet( "Z570BR_Encounter_Departmentadm");
               n570BR_Encounter_Departmentadm = false;
               n570BR_Encounter_Departmentadm = (String.IsNullOrEmpty(StringUtil.RTrim( A570BR_Encounter_Departmentadm)) ? true : false);
               A571BR_Encounter_Departmentadm_Code = cgiGet( "Z571BR_Encounter_Departmentadm_Code");
               n571BR_Encounter_Departmentadm_Code = false;
               n571BR_Encounter_Departmentadm_Code = (String.IsNullOrEmpty(StringUtil.RTrim( A571BR_Encounter_Departmentadm_Code)) ? true : false);
               A572BR_Encounter_Departmentdisch = cgiGet( "Z572BR_Encounter_Departmentdisch");
               n572BR_Encounter_Departmentdisch = false;
               n572BR_Encounter_Departmentdisch = (String.IsNullOrEmpty(StringUtil.RTrim( A572BR_Encounter_Departmentdisch)) ? true : false);
               A573BR_Encounter_Departmentdisch_Code = cgiGet( "Z573BR_Encounter_Departmentdisch_Code");
               n573BR_Encounter_Departmentdisch_Code = false;
               n573BR_Encounter_Departmentdisch_Code = (String.IsNullOrEmpty(StringUtil.RTrim( A573BR_Encounter_Departmentdisch_Code)) ? true : false);
               A574BR_Encounter_Insurance = cgiGet( "Z574BR_Encounter_Insurance");
               n574BR_Encounter_Insurance = false;
               n574BR_Encounter_Insurance = (String.IsNullOrEmpty(StringUtil.RTrim( A574BR_Encounter_Insurance)) ? true : false);
               A575BR_Encounter_Insurance_Code = cgiGet( "Z575BR_Encounter_Insurance_Code");
               n575BR_Encounter_Insurance_Code = false;
               n575BR_Encounter_Insurance_Code = (String.IsNullOrEmpty(StringUtil.RTrim( A575BR_Encounter_Insurance_Code)) ? true : false);
               A333BR_Encounter_IsDLT = StringUtil.StrToBool( cgiGet( "Z333BR_Encounter_IsDLT"));
               n333BR_Encounter_IsDLT = false;
               n333BR_Encounter_IsDLT = ((false==A333BR_Encounter_IsDLT) ? true : false);
               A184BR_Encounter_SubmitUser = cgiGet( "Z184BR_Encounter_SubmitUser");
               n184BR_Encounter_SubmitUser = false;
               n184BR_Encounter_SubmitUser = (String.IsNullOrEmpty(StringUtil.RTrim( A184BR_Encounter_SubmitUser)) ? true : false);
               A335BR_Encounter_Reason = cgiGet( "Z335BR_Encounter_Reason");
               n335BR_Encounter_Reason = false;
               n335BR_Encounter_Reason = (String.IsNullOrEmpty(StringUtil.RTrim( A335BR_Encounter_Reason)) ? true : false);
               A185BR_Encounter_SubmitDate = context.localUtil.CToT( cgiGet( "Z185BR_Encounter_SubmitDate"), 0);
               n185BR_Encounter_SubmitDate = false;
               n185BR_Encounter_SubmitDate = ((DateTime.MinValue==A185BR_Encounter_SubmitDate) ? true : false);
               A188BR_Encounter_RecheckUser = cgiGet( "Z188BR_Encounter_RecheckUser");
               n188BR_Encounter_RecheckUser = false;
               n188BR_Encounter_RecheckUser = (String.IsNullOrEmpty(StringUtil.RTrim( A188BR_Encounter_RecheckUser)) ? true : false);
               A336BR_Encounter_FReason = cgiGet( "Z336BR_Encounter_FReason");
               n336BR_Encounter_FReason = false;
               n336BR_Encounter_FReason = (String.IsNullOrEmpty(StringUtil.RTrim( A336BR_Encounter_FReason)) ? true : false);
               A189BR_Encounter_RecheckDate = context.localUtil.CToT( cgiGet( "Z189BR_Encounter_RecheckDate"), 0);
               n189BR_Encounter_RecheckDate = false;
               n189BR_Encounter_RecheckDate = ((DateTime.MinValue==A189BR_Encounter_RecheckDate) ? true : false);
               A190BR_Encounter_Approver = cgiGet( "Z190BR_Encounter_Approver");
               n190BR_Encounter_Approver = false;
               n190BR_Encounter_Approver = (String.IsNullOrEmpty(StringUtil.RTrim( A190BR_Encounter_Approver)) ? true : false);
               A191BR_Encounter_ApproveDate = context.localUtil.CToT( cgiGet( "Z191BR_Encounter_ApproveDate"), 0);
               n191BR_Encounter_ApproveDate = false;
               n191BR_Encounter_ApproveDate = ((DateTime.MinValue==A191BR_Encounter_ApproveDate) ? true : false);
               A192BR_Encounter_IsRandApprove = StringUtil.StrToBool( cgiGet( "Z192BR_Encounter_IsRandApprove"));
               n192BR_Encounter_IsRandApprove = false;
               n192BR_Encounter_IsRandApprove = ((false==A192BR_Encounter_IsRandApprove) ? true : false);
               A203BR_Encounter_IsRandApprover = cgiGet( "Z203BR_Encounter_IsRandApprover");
               n203BR_Encounter_IsRandApprover = false;
               n203BR_Encounter_IsRandApprover = (String.IsNullOrEmpty(StringUtil.RTrim( A203BR_Encounter_IsRandApprover)) ? true : false);
               A204BR_Encounter_IsRandNoApprover = cgiGet( "Z204BR_Encounter_IsRandNoApprover");
               n204BR_Encounter_IsRandNoApprover = false;
               n204BR_Encounter_IsRandNoApprover = (String.IsNullOrEmpty(StringUtil.RTrim( A204BR_Encounter_IsRandNoApprover)) ? true : false);
               A205BR_Encounter_IsRandApproveDate = context.localUtil.CToT( cgiGet( "Z205BR_Encounter_IsRandApproveDate"), 0);
               n205BR_Encounter_IsRandApproveDate = false;
               n205BR_Encounter_IsRandApproveDate = ((DateTime.MinValue==A205BR_Encounter_IsRandApproveDate) ? true : false);
               A206BR_Encounter_IsRandNoApproveDate = context.localUtil.CToT( cgiGet( "Z206BR_Encounter_IsRandNoApproveDate"), 0);
               n206BR_Encounter_IsRandNoApproveDate = false;
               n206BR_Encounter_IsRandNoApproveDate = ((DateTime.MinValue==A206BR_Encounter_IsRandNoApproveDate) ? true : false);
               A193BR_Encounter_IsRandRecheck = StringUtil.StrToBool( cgiGet( "Z193BR_Encounter_IsRandRecheck"));
               n193BR_Encounter_IsRandRecheck = false;
               n193BR_Encounter_IsRandRecheck = ((false==A193BR_Encounter_IsRandRecheck) ? true : false);
               A207BR_Encounter_IsRandRecheckr = cgiGet( "Z207BR_Encounter_IsRandRecheckr");
               n207BR_Encounter_IsRandRecheckr = false;
               n207BR_Encounter_IsRandRecheckr = (String.IsNullOrEmpty(StringUtil.RTrim( A207BR_Encounter_IsRandRecheckr)) ? true : false);
               A208BR_Encounter_IsRandNoRecheckr = cgiGet( "Z208BR_Encounter_IsRandNoRecheckr");
               n208BR_Encounter_IsRandNoRecheckr = false;
               n208BR_Encounter_IsRandNoRecheckr = (String.IsNullOrEmpty(StringUtil.RTrim( A208BR_Encounter_IsRandNoRecheckr)) ? true : false);
               A209BR_Encounter_IsRandRecheckDate = context.localUtil.CToT( cgiGet( "Z209BR_Encounter_IsRandRecheckDate"), 0);
               n209BR_Encounter_IsRandRecheckDate = false;
               n209BR_Encounter_IsRandRecheckDate = ((DateTime.MinValue==A209BR_Encounter_IsRandRecheckDate) ? true : false);
               A210BR_Encounter_IsRandNoRecheckDate = context.localUtil.CToT( cgiGet( "Z210BR_Encounter_IsRandNoRecheckDate"), 0);
               n210BR_Encounter_IsRandNoRecheckDate = false;
               n210BR_Encounter_IsRandNoRecheckDate = ((DateTime.MinValue==A210BR_Encounter_IsRandNoRecheckDate) ? true : false);
               A202BR_Encounter_IsUpdate = StringUtil.StrToBool( cgiGet( "Z202BR_Encounter_IsUpdate"));
               n202BR_Encounter_IsUpdate = false;
               n202BR_Encounter_IsUpdate = ((false==A202BR_Encounter_IsUpdate) ? true : false);
               A537BR_Encounter_Datasource = (short)(context.localUtil.CToN( cgiGet( "Z537BR_Encounter_Datasource"), ".", ","));
               n537BR_Encounter_Datasource = false;
               n537BR_Encounter_Datasource = ((0==A537BR_Encounter_Datasource) ? true : false);
               A560EncounterIDEncrypt = cgiGet( "Z560EncounterIDEncrypt");
               n560EncounterIDEncrypt = false;
               n560EncounterIDEncrypt = (String.IsNullOrEmpty(StringUtil.RTrim( A560EncounterIDEncrypt)) ? true : false);
               A360BAS_TenantTenantCode = cgiGet( "Z360BAS_TenantTenantCode");
               n360BAS_TenantTenantCode = false;
               n360BAS_TenantTenantCode = (String.IsNullOrEmpty(StringUtil.RTrim( A360BAS_TenantTenantCode)) ? true : false);
               IsConfirmed = (short)(context.localUtil.CToN( cgiGet( "IsConfirmed"), ".", ","));
               IsModified = (short)(context.localUtil.CToN( cgiGet( "IsModified"), ".", ","));
               Gx_mode = cgiGet( "Mode");
               N85BR_Information_ID = (long)(context.localUtil.CToN( cgiGet( "N85BR_Information_ID"), ".", ","));
               n85BR_Information_ID = ((0==A85BR_Information_ID) ? true : false);
               N360BAS_TenantTenantCode = cgiGet( "N360BAS_TenantTenantCode");
               n360BAS_TenantTenantCode = (String.IsNullOrEmpty(StringUtil.RTrim( A360BAS_TenantTenantCode)) ? true : false);
               AV7BR_EncounterID = (long)(context.localUtil.CToN( cgiGet( "vBR_ENCOUNTERID"), ".", ","));
               AV8Insert_BR_Information_ID = (long)(context.localUtil.CToN( cgiGet( "vINSERT_BR_INFORMATION_ID"), ".", ","));
               AV29Insert_BAS_TenantTenantCode = cgiGet( "vINSERT_BAS_TENANTTENANTCODE");
               A360BAS_TenantTenantCode = cgiGet( "BAS_TENANTTENANTCODE");
               n360BAS_TenantTenantCode = (String.IsNullOrEmpty(StringUtil.RTrim( A360BAS_TenantTenantCode)) ? true : false);
               A512BR_Encounter_CrtDisplayName = cgiGet( "BR_ENCOUNTER_CRTDISPLAYNAME");
               n512BR_Encounter_CrtDisplayName = (String.IsNullOrEmpty(StringUtil.RTrim( A512BR_Encounter_CrtDisplayName)) ? true : false);
               A470BR_Encounter_Department_Code = cgiGet( "BR_ENCOUNTER_DEPARTMENT_CODE");
               n470BR_Encounter_Department_Code = (String.IsNullOrEmpty(StringUtil.RTrim( A470BR_Encounter_Department_Code)) ? true : false);
               A471BR_Encounter_ENCType_Code = cgiGet( "BR_ENCOUNTER_ENCTYPE_CODE");
               n471BR_Encounter_ENCType_Code = (String.IsNullOrEmpty(StringUtil.RTrim( A471BR_Encounter_ENCType_Code)) ? true : false);
               A472BR_Encounter_AdmitSource_Code = cgiGet( "BR_ENCOUNTER_ADMITSOURCE_CODE");
               n472BR_Encounter_AdmitSource_Code = (String.IsNullOrEmpty(StringUtil.RTrim( A472BR_Encounter_AdmitSource_Code)) ? true : false);
               A473BR_Encounter_DischargeStatus_Code = cgiGet( "BR_ENCOUNTER_DISCHARGESTATUS_CODE");
               n473BR_Encounter_DischargeStatus_Code = (String.IsNullOrEmpty(StringUtil.RTrim( A473BR_Encounter_DischargeStatus_Code)) ? true : false);
               AV30tCurrentCode = cgiGet( "vTCURRENTCODE");
               A570BR_Encounter_Departmentadm = cgiGet( "BR_ENCOUNTER_DEPARTMENTADM");
               n570BR_Encounter_Departmentadm = (String.IsNullOrEmpty(StringUtil.RTrim( A570BR_Encounter_Departmentadm)) ? true : false);
               A571BR_Encounter_Departmentadm_Code = cgiGet( "BR_ENCOUNTER_DEPARTMENTADM_CODE");
               n571BR_Encounter_Departmentadm_Code = (String.IsNullOrEmpty(StringUtil.RTrim( A571BR_Encounter_Departmentadm_Code)) ? true : false);
               A572BR_Encounter_Departmentdisch = cgiGet( "BR_ENCOUNTER_DEPARTMENTDISCH");
               n572BR_Encounter_Departmentdisch = (String.IsNullOrEmpty(StringUtil.RTrim( A572BR_Encounter_Departmentdisch)) ? true : false);
               A573BR_Encounter_Departmentdisch_Code = cgiGet( "BR_ENCOUNTER_DEPARTMENTDISCH_CODE");
               n573BR_Encounter_Departmentdisch_Code = (String.IsNullOrEmpty(StringUtil.RTrim( A573BR_Encounter_Departmentdisch_Code)) ? true : false);
               A574BR_Encounter_Insurance = cgiGet( "BR_ENCOUNTER_INSURANCE");
               n574BR_Encounter_Insurance = (String.IsNullOrEmpty(StringUtil.RTrim( A574BR_Encounter_Insurance)) ? true : false);
               A575BR_Encounter_Insurance_Code = cgiGet( "BR_ENCOUNTER_INSURANCE_CODE");
               n575BR_Encounter_Insurance_Code = (String.IsNullOrEmpty(StringUtil.RTrim( A575BR_Encounter_Insurance_Code)) ? true : false);
               A333BR_Encounter_IsDLT = StringUtil.StrToBool( cgiGet( "BR_ENCOUNTER_ISDLT"));
               n333BR_Encounter_IsDLT = ((false==A333BR_Encounter_IsDLT) ? true : false);
               A184BR_Encounter_SubmitUser = cgiGet( "BR_ENCOUNTER_SUBMITUSER");
               n184BR_Encounter_SubmitUser = (String.IsNullOrEmpty(StringUtil.RTrim( A184BR_Encounter_SubmitUser)) ? true : false);
               A335BR_Encounter_Reason = cgiGet( "BR_ENCOUNTER_REASON");
               n335BR_Encounter_Reason = (String.IsNullOrEmpty(StringUtil.RTrim( A335BR_Encounter_Reason)) ? true : false);
               A185BR_Encounter_SubmitDate = context.localUtil.CToT( cgiGet( "BR_ENCOUNTER_SUBMITDATE"), 0);
               n185BR_Encounter_SubmitDate = ((DateTime.MinValue==A185BR_Encounter_SubmitDate) ? true : false);
               A188BR_Encounter_RecheckUser = cgiGet( "BR_ENCOUNTER_RECHECKUSER");
               n188BR_Encounter_RecheckUser = (String.IsNullOrEmpty(StringUtil.RTrim( A188BR_Encounter_RecheckUser)) ? true : false);
               A336BR_Encounter_FReason = cgiGet( "BR_ENCOUNTER_FREASON");
               n336BR_Encounter_FReason = (String.IsNullOrEmpty(StringUtil.RTrim( A336BR_Encounter_FReason)) ? true : false);
               A189BR_Encounter_RecheckDate = context.localUtil.CToT( cgiGet( "BR_ENCOUNTER_RECHECKDATE"), 0);
               n189BR_Encounter_RecheckDate = ((DateTime.MinValue==A189BR_Encounter_RecheckDate) ? true : false);
               A190BR_Encounter_Approver = cgiGet( "BR_ENCOUNTER_APPROVER");
               n190BR_Encounter_Approver = (String.IsNullOrEmpty(StringUtil.RTrim( A190BR_Encounter_Approver)) ? true : false);
               A191BR_Encounter_ApproveDate = context.localUtil.CToT( cgiGet( "BR_ENCOUNTER_APPROVEDATE"), 0);
               n191BR_Encounter_ApproveDate = ((DateTime.MinValue==A191BR_Encounter_ApproveDate) ? true : false);
               A192BR_Encounter_IsRandApprove = StringUtil.StrToBool( cgiGet( "BR_ENCOUNTER_ISRANDAPPROVE"));
               n192BR_Encounter_IsRandApprove = ((false==A192BR_Encounter_IsRandApprove) ? true : false);
               A203BR_Encounter_IsRandApprover = cgiGet( "BR_ENCOUNTER_ISRANDAPPROVER");
               n203BR_Encounter_IsRandApprover = (String.IsNullOrEmpty(StringUtil.RTrim( A203BR_Encounter_IsRandApprover)) ? true : false);
               A204BR_Encounter_IsRandNoApprover = cgiGet( "BR_ENCOUNTER_ISRANDNOAPPROVER");
               n204BR_Encounter_IsRandNoApprover = (String.IsNullOrEmpty(StringUtil.RTrim( A204BR_Encounter_IsRandNoApprover)) ? true : false);
               A205BR_Encounter_IsRandApproveDate = context.localUtil.CToT( cgiGet( "BR_ENCOUNTER_ISRANDAPPROVEDATE"), 0);
               n205BR_Encounter_IsRandApproveDate = ((DateTime.MinValue==A205BR_Encounter_IsRandApproveDate) ? true : false);
               A206BR_Encounter_IsRandNoApproveDate = context.localUtil.CToT( cgiGet( "BR_ENCOUNTER_ISRANDNOAPPROVEDATE"), 0);
               n206BR_Encounter_IsRandNoApproveDate = ((DateTime.MinValue==A206BR_Encounter_IsRandNoApproveDate) ? true : false);
               A193BR_Encounter_IsRandRecheck = StringUtil.StrToBool( cgiGet( "BR_ENCOUNTER_ISRANDRECHECK"));
               n193BR_Encounter_IsRandRecheck = ((false==A193BR_Encounter_IsRandRecheck) ? true : false);
               A207BR_Encounter_IsRandRecheckr = cgiGet( "BR_ENCOUNTER_ISRANDRECHECKR");
               n207BR_Encounter_IsRandRecheckr = (String.IsNullOrEmpty(StringUtil.RTrim( A207BR_Encounter_IsRandRecheckr)) ? true : false);
               A208BR_Encounter_IsRandNoRecheckr = cgiGet( "BR_ENCOUNTER_ISRANDNORECHECKR");
               n208BR_Encounter_IsRandNoRecheckr = (String.IsNullOrEmpty(StringUtil.RTrim( A208BR_Encounter_IsRandNoRecheckr)) ? true : false);
               A209BR_Encounter_IsRandRecheckDate = context.localUtil.CToT( cgiGet( "BR_ENCOUNTER_ISRANDRECHECKDATE"), 0);
               n209BR_Encounter_IsRandRecheckDate = ((DateTime.MinValue==A209BR_Encounter_IsRandRecheckDate) ? true : false);
               A210BR_Encounter_IsRandNoRecheckDate = context.localUtil.CToT( cgiGet( "BR_ENCOUNTER_ISRANDNORECHECKDATE"), 0);
               n210BR_Encounter_IsRandNoRecheckDate = ((DateTime.MinValue==A210BR_Encounter_IsRandNoRecheckDate) ? true : false);
               A202BR_Encounter_IsUpdate = StringUtil.StrToBool( cgiGet( "BR_ENCOUNTER_ISUPDATE"));
               n202BR_Encounter_IsUpdate = ((false==A202BR_Encounter_IsUpdate) ? true : false);
               A537BR_Encounter_Datasource = (short)(context.localUtil.CToN( cgiGet( "BR_ENCOUNTER_DATASOURCE"), ".", ","));
               n537BR_Encounter_Datasource = ((0==A537BR_Encounter_Datasource) ? true : false);
               A560EncounterIDEncrypt = cgiGet( "ENCOUNTERIDENCRYPT");
               n560EncounterIDEncrypt = (String.IsNullOrEmpty(StringUtil.RTrim( A560EncounterIDEncrypt)) ? true : false);
               AV32Pgmname = cgiGet( "vPGMNAME");
               AV31Pgmdesc = cgiGet( "vPGMDESC");
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
               forbiddenHiddens = "hsh" + "BR_Encounter";
               A19BR_EncounterID = (long)(context.localUtil.CToN( cgiGet( edtBR_EncounterID_Internalname), ".", ","));
               n19BR_EncounterID = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A19BR_EncounterID", StringUtil.LTrim( StringUtil.Str( (decimal)(A19BR_EncounterID), 18, 0)));
               forbiddenHiddens = forbiddenHiddens + context.localUtil.Format( (decimal)(A19BR_EncounterID), "ZZZZZZZZZZZZZZZZZZ");
               forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( AV30tCurrentCode, ""));
               forbiddenHiddens = forbiddenHiddens + context.localUtil.Format( (decimal)(AV8Insert_BR_Information_ID), "ZZZZZZZZZZZZZZZZZZ");
               forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( AV29Insert_BAS_TenantTenantCode, ""));
               forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!"));
               forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( A570BR_Encounter_Departmentadm, ""));
               forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( A571BR_Encounter_Departmentadm_Code, ""));
               forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( A572BR_Encounter_Departmentdisch, ""));
               forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( A573BR_Encounter_Departmentdisch_Code, ""));
               forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( A574BR_Encounter_Insurance, ""));
               forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( A575BR_Encounter_Insurance_Code, ""));
               forbiddenHiddens = forbiddenHiddens + StringUtil.BoolToStr( A333BR_Encounter_IsDLT);
               forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( A184BR_Encounter_SubmitUser, ""));
               forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( A335BR_Encounter_Reason, ""));
               forbiddenHiddens = forbiddenHiddens + context.localUtil.Format( A185BR_Encounter_SubmitDate, "9999/99/99 99:99:99");
               forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( A188BR_Encounter_RecheckUser, ""));
               forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( A336BR_Encounter_FReason, ""));
               forbiddenHiddens = forbiddenHiddens + context.localUtil.Format( A189BR_Encounter_RecheckDate, "9999/99/99 99:99:99");
               forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( A190BR_Encounter_Approver, ""));
               forbiddenHiddens = forbiddenHiddens + context.localUtil.Format( A191BR_Encounter_ApproveDate, "9999/99/99 99:99:99");
               forbiddenHiddens = forbiddenHiddens + StringUtil.BoolToStr( A192BR_Encounter_IsRandApprove);
               forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( A203BR_Encounter_IsRandApprover, ""));
               forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( A204BR_Encounter_IsRandNoApprover, ""));
               forbiddenHiddens = forbiddenHiddens + context.localUtil.Format( A205BR_Encounter_IsRandApproveDate, "9999/99/99 99:99:99");
               forbiddenHiddens = forbiddenHiddens + context.localUtil.Format( A206BR_Encounter_IsRandNoApproveDate, "9999/99/99 99:99:99");
               forbiddenHiddens = forbiddenHiddens + StringUtil.BoolToStr( A193BR_Encounter_IsRandRecheck);
               forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( A207BR_Encounter_IsRandRecheckr, ""));
               forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( A208BR_Encounter_IsRandNoRecheckr, ""));
               forbiddenHiddens = forbiddenHiddens + context.localUtil.Format( A209BR_Encounter_IsRandRecheckDate, "9999/99/99 99:99:99");
               forbiddenHiddens = forbiddenHiddens + context.localUtil.Format( A210BR_Encounter_IsRandNoRecheckDate, "9999/99/99 99:99:99");
               forbiddenHiddens = forbiddenHiddens + StringUtil.BoolToStr( A202BR_Encounter_IsUpdate);
               forbiddenHiddens = forbiddenHiddens + context.localUtil.Format( (decimal)(A537BR_Encounter_Datasource), "ZZZ9");
               forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( A560EncounterIDEncrypt, ""));
               hsh = cgiGet( "hsh");
               if ( ( ! ( ( A19BR_EncounterID != Z19BR_EncounterID ) ) || ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) ) && ! GXUtil.CheckEncryptedHash( forbiddenHiddens, hsh, GXKey) )
               {
                  GXUtil.WriteLog("br_encounter:[SecurityCheckFailed value for]"+"BR_EncounterID:"+context.localUtil.Format( (decimal)(A19BR_EncounterID), "ZZZZZZZZZZZZZZZZZZ"));
                  GXUtil.WriteLog("br_encounter:[SecurityCheckFailed value for]"+"tCurrentCode:"+StringUtil.RTrim( context.localUtil.Format( AV30tCurrentCode, "")));
                  GXUtil.WriteLog("br_encounter:[SecurityCheckFailed value for]"+"Insert_BR_Information_ID:"+context.localUtil.Format( (decimal)(AV8Insert_BR_Information_ID), "ZZZZZZZZZZZZZZZZZZ"));
                  GXUtil.WriteLog("br_encounter:[SecurityCheckFailed value for]"+"Insert_BAS_TenantTenantCode:"+StringUtil.RTrim( context.localUtil.Format( AV29Insert_BAS_TenantTenantCode, "")));
                  GXUtil.WriteLog("br_encounter:[SecurityCheckFailed value for]"+"Gx_mode:"+StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")));
                  GXUtil.WriteLog("br_encounter:[SecurityCheckFailed value for]"+"BR_Encounter_Departmentadm:"+StringUtil.RTrim( context.localUtil.Format( A570BR_Encounter_Departmentadm, "")));
                  GXUtil.WriteLog("br_encounter:[SecurityCheckFailed value for]"+"BR_Encounter_Departmentadm_Code:"+StringUtil.RTrim( context.localUtil.Format( A571BR_Encounter_Departmentadm_Code, "")));
                  GXUtil.WriteLog("br_encounter:[SecurityCheckFailed value for]"+"BR_Encounter_Departmentdisch:"+StringUtil.RTrim( context.localUtil.Format( A572BR_Encounter_Departmentdisch, "")));
                  GXUtil.WriteLog("br_encounter:[SecurityCheckFailed value for]"+"BR_Encounter_Departmentdisch_Code:"+StringUtil.RTrim( context.localUtil.Format( A573BR_Encounter_Departmentdisch_Code, "")));
                  GXUtil.WriteLog("br_encounter:[SecurityCheckFailed value for]"+"BR_Encounter_Insurance:"+StringUtil.RTrim( context.localUtil.Format( A574BR_Encounter_Insurance, "")));
                  GXUtil.WriteLog("br_encounter:[SecurityCheckFailed value for]"+"BR_Encounter_Insurance_Code:"+StringUtil.RTrim( context.localUtil.Format( A575BR_Encounter_Insurance_Code, "")));
                  GXUtil.WriteLog("br_encounter:[SecurityCheckFailed value for]"+"BR_Encounter_IsDLT:"+StringUtil.BoolToStr( A333BR_Encounter_IsDLT));
                  GXUtil.WriteLog("br_encounter:[SecurityCheckFailed value for]"+"BR_Encounter_SubmitUser:"+StringUtil.RTrim( context.localUtil.Format( A184BR_Encounter_SubmitUser, "")));
                  GXUtil.WriteLog("br_encounter:[SecurityCheckFailed value for]"+"BR_Encounter_Reason:"+StringUtil.RTrim( context.localUtil.Format( A335BR_Encounter_Reason, "")));
                  GXUtil.WriteLog("br_encounter:[SecurityCheckFailed value for]"+"BR_Encounter_SubmitDate:"+context.localUtil.Format( A185BR_Encounter_SubmitDate, "9999/99/99 99:99:99"));
                  GXUtil.WriteLog("br_encounter:[SecurityCheckFailed value for]"+"BR_Encounter_RecheckUser:"+StringUtil.RTrim( context.localUtil.Format( A188BR_Encounter_RecheckUser, "")));
                  GXUtil.WriteLog("br_encounter:[SecurityCheckFailed value for]"+"BR_Encounter_FReason:"+StringUtil.RTrim( context.localUtil.Format( A336BR_Encounter_FReason, "")));
                  GXUtil.WriteLog("br_encounter:[SecurityCheckFailed value for]"+"BR_Encounter_RecheckDate:"+context.localUtil.Format( A189BR_Encounter_RecheckDate, "9999/99/99 99:99:99"));
                  GXUtil.WriteLog("br_encounter:[SecurityCheckFailed value for]"+"BR_Encounter_Approver:"+StringUtil.RTrim( context.localUtil.Format( A190BR_Encounter_Approver, "")));
                  GXUtil.WriteLog("br_encounter:[SecurityCheckFailed value for]"+"BR_Encounter_ApproveDate:"+context.localUtil.Format( A191BR_Encounter_ApproveDate, "9999/99/99 99:99:99"));
                  GXUtil.WriteLog("br_encounter:[SecurityCheckFailed value for]"+"BR_Encounter_IsRandApprove:"+StringUtil.BoolToStr( A192BR_Encounter_IsRandApprove));
                  GXUtil.WriteLog("br_encounter:[SecurityCheckFailed value for]"+"BR_Encounter_IsRandApprover:"+StringUtil.RTrim( context.localUtil.Format( A203BR_Encounter_IsRandApprover, "")));
                  GXUtil.WriteLog("br_encounter:[SecurityCheckFailed value for]"+"BR_Encounter_IsRandNoApprover:"+StringUtil.RTrim( context.localUtil.Format( A204BR_Encounter_IsRandNoApprover, "")));
                  GXUtil.WriteLog("br_encounter:[SecurityCheckFailed value for]"+"BR_Encounter_IsRandApproveDate:"+context.localUtil.Format( A205BR_Encounter_IsRandApproveDate, "9999/99/99 99:99:99"));
                  GXUtil.WriteLog("br_encounter:[SecurityCheckFailed value for]"+"BR_Encounter_IsRandNoApproveDate:"+context.localUtil.Format( A206BR_Encounter_IsRandNoApproveDate, "9999/99/99 99:99:99"));
                  GXUtil.WriteLog("br_encounter:[SecurityCheckFailed value for]"+"BR_Encounter_IsRandRecheck:"+StringUtil.BoolToStr( A193BR_Encounter_IsRandRecheck));
                  GXUtil.WriteLog("br_encounter:[SecurityCheckFailed value for]"+"BR_Encounter_IsRandRecheckr:"+StringUtil.RTrim( context.localUtil.Format( A207BR_Encounter_IsRandRecheckr, "")));
                  GXUtil.WriteLog("br_encounter:[SecurityCheckFailed value for]"+"BR_Encounter_IsRandNoRecheckr:"+StringUtil.RTrim( context.localUtil.Format( A208BR_Encounter_IsRandNoRecheckr, "")));
                  GXUtil.WriteLog("br_encounter:[SecurityCheckFailed value for]"+"BR_Encounter_IsRandRecheckDate:"+context.localUtil.Format( A209BR_Encounter_IsRandRecheckDate, "9999/99/99 99:99:99"));
                  GXUtil.WriteLog("br_encounter:[SecurityCheckFailed value for]"+"BR_Encounter_IsRandNoRecheckDate:"+context.localUtil.Format( A210BR_Encounter_IsRandNoRecheckDate, "9999/99/99 99:99:99"));
                  GXUtil.WriteLog("br_encounter:[SecurityCheckFailed value for]"+"BR_Encounter_IsUpdate:"+StringUtil.BoolToStr( A202BR_Encounter_IsUpdate));
                  GXUtil.WriteLog("br_encounter:[SecurityCheckFailed value for]"+"BR_Encounter_Datasource:"+context.localUtil.Format( (decimal)(A537BR_Encounter_Datasource), "ZZZ9"));
                  GXUtil.WriteLog("br_encounter:[SecurityCheckFailed value for]"+"EncounterIDEncrypt:"+StringUtil.RTrim( context.localUtil.Format( A560EncounterIDEncrypt, "")));
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
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                  A19BR_EncounterID = (long)(NumberUtil.Val( GetNextPar( ), "."));
                  n19BR_EncounterID = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A19BR_EncounterID", StringUtil.LTrim( StringUtil.Str( (decimal)(A19BR_EncounterID), 18, 0)));
                  getEqualNoModal( ) ;
                  Gx_mode = "DSP";
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                  disable_std_buttons( ) ;
                  standaloneModal( ) ;
               }
               else
               {
                  if ( StringUtil.StrCmp(Gx_mode, "DSP") == 0 )
                  {
                     sMode15 = Gx_mode;
                     Gx_mode = "UPD";
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                     Gx_mode = sMode15;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                  }
                  standaloneModal( ) ;
                  if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
                  {
                     getByPrimaryKey( ) ;
                     if ( RcdFound15 == 1 )
                     {
                        if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
                        {
                           /* Confirm record */
                           CONFIRM_0E0( ) ;
                           if ( AnyError == 0 )
                           {
                              GX_FocusControl = bttBtntrn_enter_Internalname;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                           }
                        }
                     }
                     else
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_noinsert", ""), 1, "BR_ENCOUNTERID");
                        AnyError = 1;
                        GX_FocusControl = edtBR_EncounterID_Internalname;
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                     }
                  }
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
                           E110E2 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "AFTER TRN") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           /* Execute user event: After Trn */
                           E120E2 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "ENTER") == 0 )
                        {
                           context.wbHandled = 1;
                           if ( StringUtil.StrCmp(Gx_mode, "DSP") != 0 )
                           {
                              btn_enter( ) ;
                           }
                           /* No code required for Cancel button. It is implemented as the Reset button. */
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
            E120E2 ();
            trnEnded = 0;
            standaloneNotModal( ) ;
            standaloneModal( ) ;
            if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  )
            {
               /* Clear variables for new insertion. */
               InitAll0E15( ) ;
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
         bttBtntrn_delete_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtntrn_delete_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtntrn_delete_Visible), 5, 0)), true);
         if ( ( StringUtil.StrCmp(Gx_mode, "DSP") == 0 ) || ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 ) )
         {
            bttBtntrn_delete_Visible = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtntrn_delete_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtntrn_delete_Visible), 5, 0)), true);
            if ( StringUtil.StrCmp(Gx_mode, "DSP") == 0 )
            {
               bttBtntrn_enter_Visible = 0;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtntrn_enter_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtntrn_enter_Visible), 5, 0)), true);
            }
            DisableAttributes0E15( ) ;
         }
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavVdepartment_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavVdepartment_Enabled), 5, 0)), true);
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavVenctype_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavVenctype_Enabled), 5, 0)), true);
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavVreason_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavVreason_Enabled), 5, 0)), true);
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

      protected void CONFIRM_0E0( )
      {
         BeforeValidate0E15( ) ;
         if ( AnyError == 0 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
            {
               OnDeleteControls0E15( ) ;
            }
            else
            {
               CheckExtendedTable0E15( ) ;
               CloseExtendedTableCursors0E15( ) ;
            }
         }
         if ( AnyError == 0 )
         {
            IsConfirmed = 1;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "IsConfirmed", StringUtil.LTrim( StringUtil.Str( (decimal)(IsConfirmed), 4, 0)));
         }
      }

      protected void ResetCaption0E0( )
      {
      }

      protected void E110E2( )
      {
         /* Start Routine */
         GXt_char1 = AV30tCurrentCode;
         new zbr_getcurrenttcode(context ).execute( out  GXt_char1) ;
         AV30tCurrentCode = GXt_char1;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV30tCurrentCode", AV30tCurrentCode);
         AV31Pgmdesc = "Data Mgmt Portal -RAAP";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV31Pgmdesc", AV31Pgmdesc);
         new GeneXus.Programs.wwpbaseobjects.loadwwpcontext(context ).execute( out  AV14WWPContext) ;
         AV16IsAuthorized = true;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV16IsAuthorized", AV16IsAuthorized);
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            GXt_boolean2 = AV16IsAuthorized;
            new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "Manage_Encounter", out  GXt_boolean2) ;
            AV16IsAuthorized = GXt_boolean2;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV16IsAuthorized", AV16IsAuthorized);
         }
         if ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 )
         {
            GXt_boolean2 = AV16IsAuthorized;
            new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "Manage_Encounter", out  GXt_boolean2) ;
            AV16IsAuthorized = GXt_boolean2;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV16IsAuthorized", AV16IsAuthorized);
         }
         if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
         {
            GXt_boolean2 = AV16IsAuthorized;
            new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "Manage_Encounter", out  GXt_boolean2) ;
            AV16IsAuthorized = GXt_boolean2;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV16IsAuthorized", AV16IsAuthorized);
         }
         if ( ! AV16IsAuthorized )
         {
            CallWebObject(formatLink("wwpbaseobjects.notauthorized.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV32Pgmname)));
            context.wjLocDisableFrm = 1;
         }
         /* Execute user subroutine: 'ATTRIBUTESSECURITYCODE' */
         S112 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
         AV11TrnContext.FromXml(AV13WebSession.Get("TrnContext"), null, "WWPTransactionContext", "DataAnalysisPlatform");
         if ( ( StringUtil.StrCmp(AV11TrnContext.gxTpr_Transactionname, AV32Pgmname) == 0 ) && ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) )
         {
            AV33GXV1 = 1;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV33GXV1", StringUtil.LTrim( StringUtil.Str( (decimal)(AV33GXV1), 8, 0)));
            while ( AV33GXV1 <= AV11TrnContext.gxTpr_Attributes.Count )
            {
               AV12TrnContextAtt = ((GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext_Attribute)AV11TrnContext.gxTpr_Attributes.Item(AV33GXV1));
               if ( StringUtil.StrCmp(AV12TrnContextAtt.gxTpr_Attributename, "BR_Information_ID") == 0 )
               {
                  AV8Insert_BR_Information_ID = (long)(NumberUtil.Val( AV12TrnContextAtt.gxTpr_Attributevalue, "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8Insert_BR_Information_ID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV8Insert_BR_Information_ID), 18, 0)));
               }
               else if ( StringUtil.StrCmp(AV12TrnContextAtt.gxTpr_Attributename, "BAS_TenantTenantCode") == 0 )
               {
                  AV29Insert_BAS_TenantTenantCode = AV12TrnContextAtt.gxTpr_Attributevalue;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV29Insert_BAS_TenantTenantCode", AV29Insert_BAS_TenantTenantCode);
               }
               AV33GXV1 = (int)(AV33GXV1+1);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV33GXV1", StringUtil.LTrim( StringUtil.Str( (decimal)(AV33GXV1), 8, 0)));
            }
         }
         edtBR_EncounterID_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_EncounterID_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBR_EncounterID_Visible), 5, 0)), true);
         edtBR_Encounter_EncID_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Encounter_EncID_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBR_Encounter_EncID_Visible), 5, 0)), true);
         cmbBR_Encounter_Status.Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbBR_Encounter_Status_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(cmbBR_Encounter_Status.Visible), 5, 0)), true);
         edtBR_Encounter_CrtDate_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Encounter_CrtDate_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBR_Encounter_CrtDate_Visible), 5, 0)), true);
         edtBR_Encounter_UpdDate_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Encounter_UpdDate_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBR_Encounter_UpdDate_Visible), 5, 0)), true);
         edtBR_Encounter_CrtUser_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Encounter_CrtUser_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBR_Encounter_CrtUser_Visible), 5, 0)), true);
         edtBR_Encounter_UpdUser_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Encounter_UpdUser_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBR_Encounter_UpdUser_Visible), 5, 0)), true);
      }

      protected void E120E2( )
      {
         /* After Trn Routine */
         if ( ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 ) && ! AV11TrnContext.gxTpr_Callerondelete )
         {
            CallWebObject(formatLink("br_encounterww.aspx") );
            context.wjLocDisableFrm = 1;
         }
         context.setWebReturnParms(new Object[] {});
         context.setWebReturnParmsMetadata(new Object[] {});
         context.wjLocDisableFrm = 1;
         context.nUserReturn = 1;
         returnInSub = true;
         if (true) return;
      }

      protected void S112( )
      {
         /* 'ATTRIBUTESSECURITYCODE' Routine */
         edtavVdepartment_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavVdepartment_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavVdepartment_Visible), 5, 0)), true);
         cellVdepartment_cell_Class = "Invisible";
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cellVdepartment_cell_Internalname, "Class", cellVdepartment_cell_Class, true);
         edtavVenctype_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavVenctype_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavVenctype_Visible), 5, 0)), true);
         cellVenctype_cell_Class = "Invisible";
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cellVenctype_cell_Internalname, "Class", cellVenctype_cell_Class, true);
         edtavVreason_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavVreason_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavVreason_Visible), 5, 0)), true);
         cellVreason_cell_Class = "Invisible";
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cellVreason_cell_Internalname, "Class", cellVreason_cell_Class, true);
      }

      protected void ZM0E15( short GX_JID )
      {
         if ( ( GX_JID == 47 ) || ( GX_JID == 0 ) )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
            {
               Z35BR_Encounter_EncID = T000E3_A35BR_Encounter_EncID[0];
               Z172BR_Encounter_Status = T000E3_A172BR_Encounter_Status[0];
               Z183BR_Encounter_CrtUser = T000E3_A183BR_Encounter_CrtUser[0];
               Z512BR_Encounter_CrtDisplayName = T000E3_A512BR_Encounter_CrtDisplayName[0];
               Z182BR_Encounter_CrtDate = T000E3_A182BR_Encounter_CrtDate[0];
               Z470BR_Encounter_Department_Code = T000E3_A470BR_Encounter_Department_Code[0];
               Z471BR_Encounter_ENCType_Code = T000E3_A471BR_Encounter_ENCType_Code[0];
               Z472BR_Encounter_AdmitSource_Code = T000E3_A472BR_Encounter_AdmitSource_Code[0];
               Z473BR_Encounter_DischargeStatus_Code = T000E3_A473BR_Encounter_DischargeStatus_Code[0];
               Z84BR_Encounter_Department = T000E3_A84BR_Encounter_Department[0];
               Z570BR_Encounter_Departmentadm = T000E3_A570BR_Encounter_Departmentadm[0];
               Z571BR_Encounter_Departmentadm_Code = T000E3_A571BR_Encounter_Departmentadm_Code[0];
               Z572BR_Encounter_Departmentdisch = T000E3_A572BR_Encounter_Departmentdisch[0];
               Z573BR_Encounter_Departmentdisch_Code = T000E3_A573BR_Encounter_Departmentdisch_Code[0];
               Z90BR_Encounter_ENCType = T000E3_A90BR_Encounter_ENCType[0];
               Z91BR_Encounter_AdmitDate = T000E3_A91BR_Encounter_AdmitDate[0];
               Z92BR_Encounter_AdmitSource = T000E3_A92BR_Encounter_AdmitSource[0];
               Z93BR_Encounter_DischargeDate = T000E3_A93BR_Encounter_DischargeDate[0];
               Z94BR_Encounter_DischargeStatus = T000E3_A94BR_Encounter_DischargeStatus[0];
               Z574BR_Encounter_Insurance = T000E3_A574BR_Encounter_Insurance[0];
               Z575BR_Encounter_Insurance_Code = T000E3_A575BR_Encounter_Insurance_Code[0];
               Z187BR_Encounter_UpdDate = T000E3_A187BR_Encounter_UpdDate[0];
               Z186BR_Encounter_UpdUser = T000E3_A186BR_Encounter_UpdUser[0];
               Z333BR_Encounter_IsDLT = T000E3_A333BR_Encounter_IsDLT[0];
               Z184BR_Encounter_SubmitUser = T000E3_A184BR_Encounter_SubmitUser[0];
               Z335BR_Encounter_Reason = T000E3_A335BR_Encounter_Reason[0];
               Z185BR_Encounter_SubmitDate = T000E3_A185BR_Encounter_SubmitDate[0];
               Z188BR_Encounter_RecheckUser = T000E3_A188BR_Encounter_RecheckUser[0];
               Z336BR_Encounter_FReason = T000E3_A336BR_Encounter_FReason[0];
               Z189BR_Encounter_RecheckDate = T000E3_A189BR_Encounter_RecheckDate[0];
               Z190BR_Encounter_Approver = T000E3_A190BR_Encounter_Approver[0];
               Z191BR_Encounter_ApproveDate = T000E3_A191BR_Encounter_ApproveDate[0];
               Z192BR_Encounter_IsRandApprove = T000E3_A192BR_Encounter_IsRandApprove[0];
               Z203BR_Encounter_IsRandApprover = T000E3_A203BR_Encounter_IsRandApprover[0];
               Z204BR_Encounter_IsRandNoApprover = T000E3_A204BR_Encounter_IsRandNoApprover[0];
               Z205BR_Encounter_IsRandApproveDate = T000E3_A205BR_Encounter_IsRandApproveDate[0];
               Z206BR_Encounter_IsRandNoApproveDate = T000E3_A206BR_Encounter_IsRandNoApproveDate[0];
               Z193BR_Encounter_IsRandRecheck = T000E3_A193BR_Encounter_IsRandRecheck[0];
               Z207BR_Encounter_IsRandRecheckr = T000E3_A207BR_Encounter_IsRandRecheckr[0];
               Z208BR_Encounter_IsRandNoRecheckr = T000E3_A208BR_Encounter_IsRandNoRecheckr[0];
               Z209BR_Encounter_IsRandRecheckDate = T000E3_A209BR_Encounter_IsRandRecheckDate[0];
               Z210BR_Encounter_IsRandNoRecheckDate = T000E3_A210BR_Encounter_IsRandNoRecheckDate[0];
               Z202BR_Encounter_IsUpdate = T000E3_A202BR_Encounter_IsUpdate[0];
               Z537BR_Encounter_Datasource = T000E3_A537BR_Encounter_Datasource[0];
               Z560EncounterIDEncrypt = T000E3_A560EncounterIDEncrypt[0];
               Z85BR_Information_ID = T000E3_A85BR_Information_ID[0];
               Z360BAS_TenantTenantCode = T000E3_A360BAS_TenantTenantCode[0];
            }
            else
            {
               Z35BR_Encounter_EncID = A35BR_Encounter_EncID;
               Z172BR_Encounter_Status = A172BR_Encounter_Status;
               Z183BR_Encounter_CrtUser = A183BR_Encounter_CrtUser;
               Z512BR_Encounter_CrtDisplayName = A512BR_Encounter_CrtDisplayName;
               Z182BR_Encounter_CrtDate = A182BR_Encounter_CrtDate;
               Z470BR_Encounter_Department_Code = A470BR_Encounter_Department_Code;
               Z471BR_Encounter_ENCType_Code = A471BR_Encounter_ENCType_Code;
               Z472BR_Encounter_AdmitSource_Code = A472BR_Encounter_AdmitSource_Code;
               Z473BR_Encounter_DischargeStatus_Code = A473BR_Encounter_DischargeStatus_Code;
               Z84BR_Encounter_Department = A84BR_Encounter_Department;
               Z570BR_Encounter_Departmentadm = A570BR_Encounter_Departmentadm;
               Z571BR_Encounter_Departmentadm_Code = A571BR_Encounter_Departmentadm_Code;
               Z572BR_Encounter_Departmentdisch = A572BR_Encounter_Departmentdisch;
               Z573BR_Encounter_Departmentdisch_Code = A573BR_Encounter_Departmentdisch_Code;
               Z90BR_Encounter_ENCType = A90BR_Encounter_ENCType;
               Z91BR_Encounter_AdmitDate = A91BR_Encounter_AdmitDate;
               Z92BR_Encounter_AdmitSource = A92BR_Encounter_AdmitSource;
               Z93BR_Encounter_DischargeDate = A93BR_Encounter_DischargeDate;
               Z94BR_Encounter_DischargeStatus = A94BR_Encounter_DischargeStatus;
               Z574BR_Encounter_Insurance = A574BR_Encounter_Insurance;
               Z575BR_Encounter_Insurance_Code = A575BR_Encounter_Insurance_Code;
               Z187BR_Encounter_UpdDate = A187BR_Encounter_UpdDate;
               Z186BR_Encounter_UpdUser = A186BR_Encounter_UpdUser;
               Z333BR_Encounter_IsDLT = A333BR_Encounter_IsDLT;
               Z184BR_Encounter_SubmitUser = A184BR_Encounter_SubmitUser;
               Z335BR_Encounter_Reason = A335BR_Encounter_Reason;
               Z185BR_Encounter_SubmitDate = A185BR_Encounter_SubmitDate;
               Z188BR_Encounter_RecheckUser = A188BR_Encounter_RecheckUser;
               Z336BR_Encounter_FReason = A336BR_Encounter_FReason;
               Z189BR_Encounter_RecheckDate = A189BR_Encounter_RecheckDate;
               Z190BR_Encounter_Approver = A190BR_Encounter_Approver;
               Z191BR_Encounter_ApproveDate = A191BR_Encounter_ApproveDate;
               Z192BR_Encounter_IsRandApprove = A192BR_Encounter_IsRandApprove;
               Z203BR_Encounter_IsRandApprover = A203BR_Encounter_IsRandApprover;
               Z204BR_Encounter_IsRandNoApprover = A204BR_Encounter_IsRandNoApprover;
               Z205BR_Encounter_IsRandApproveDate = A205BR_Encounter_IsRandApproveDate;
               Z206BR_Encounter_IsRandNoApproveDate = A206BR_Encounter_IsRandNoApproveDate;
               Z193BR_Encounter_IsRandRecheck = A193BR_Encounter_IsRandRecheck;
               Z207BR_Encounter_IsRandRecheckr = A207BR_Encounter_IsRandRecheckr;
               Z208BR_Encounter_IsRandNoRecheckr = A208BR_Encounter_IsRandNoRecheckr;
               Z209BR_Encounter_IsRandRecheckDate = A209BR_Encounter_IsRandRecheckDate;
               Z210BR_Encounter_IsRandNoRecheckDate = A210BR_Encounter_IsRandNoRecheckDate;
               Z202BR_Encounter_IsUpdate = A202BR_Encounter_IsUpdate;
               Z537BR_Encounter_Datasource = A537BR_Encounter_Datasource;
               Z560EncounterIDEncrypt = A560EncounterIDEncrypt;
               Z85BR_Information_ID = A85BR_Information_ID;
               Z360BAS_TenantTenantCode = A360BAS_TenantTenantCode;
            }
         }
         if ( GX_JID == -47 )
         {
            Z19BR_EncounterID = A19BR_EncounterID;
            Z35BR_Encounter_EncID = A35BR_Encounter_EncID;
            Z172BR_Encounter_Status = A172BR_Encounter_Status;
            Z183BR_Encounter_CrtUser = A183BR_Encounter_CrtUser;
            Z512BR_Encounter_CrtDisplayName = A512BR_Encounter_CrtDisplayName;
            Z182BR_Encounter_CrtDate = A182BR_Encounter_CrtDate;
            Z470BR_Encounter_Department_Code = A470BR_Encounter_Department_Code;
            Z471BR_Encounter_ENCType_Code = A471BR_Encounter_ENCType_Code;
            Z472BR_Encounter_AdmitSource_Code = A472BR_Encounter_AdmitSource_Code;
            Z473BR_Encounter_DischargeStatus_Code = A473BR_Encounter_DischargeStatus_Code;
            Z84BR_Encounter_Department = A84BR_Encounter_Department;
            Z570BR_Encounter_Departmentadm = A570BR_Encounter_Departmentadm;
            Z571BR_Encounter_Departmentadm_Code = A571BR_Encounter_Departmentadm_Code;
            Z572BR_Encounter_Departmentdisch = A572BR_Encounter_Departmentdisch;
            Z573BR_Encounter_Departmentdisch_Code = A573BR_Encounter_Departmentdisch_Code;
            Z90BR_Encounter_ENCType = A90BR_Encounter_ENCType;
            Z91BR_Encounter_AdmitDate = A91BR_Encounter_AdmitDate;
            Z92BR_Encounter_AdmitSource = A92BR_Encounter_AdmitSource;
            Z93BR_Encounter_DischargeDate = A93BR_Encounter_DischargeDate;
            Z94BR_Encounter_DischargeStatus = A94BR_Encounter_DischargeStatus;
            Z574BR_Encounter_Insurance = A574BR_Encounter_Insurance;
            Z575BR_Encounter_Insurance_Code = A575BR_Encounter_Insurance_Code;
            Z187BR_Encounter_UpdDate = A187BR_Encounter_UpdDate;
            Z186BR_Encounter_UpdUser = A186BR_Encounter_UpdUser;
            Z333BR_Encounter_IsDLT = A333BR_Encounter_IsDLT;
            Z184BR_Encounter_SubmitUser = A184BR_Encounter_SubmitUser;
            Z335BR_Encounter_Reason = A335BR_Encounter_Reason;
            Z185BR_Encounter_SubmitDate = A185BR_Encounter_SubmitDate;
            Z188BR_Encounter_RecheckUser = A188BR_Encounter_RecheckUser;
            Z336BR_Encounter_FReason = A336BR_Encounter_FReason;
            Z189BR_Encounter_RecheckDate = A189BR_Encounter_RecheckDate;
            Z190BR_Encounter_Approver = A190BR_Encounter_Approver;
            Z191BR_Encounter_ApproveDate = A191BR_Encounter_ApproveDate;
            Z192BR_Encounter_IsRandApprove = A192BR_Encounter_IsRandApprove;
            Z203BR_Encounter_IsRandApprover = A203BR_Encounter_IsRandApprover;
            Z204BR_Encounter_IsRandNoApprover = A204BR_Encounter_IsRandNoApprover;
            Z205BR_Encounter_IsRandApproveDate = A205BR_Encounter_IsRandApproveDate;
            Z206BR_Encounter_IsRandNoApproveDate = A206BR_Encounter_IsRandNoApproveDate;
            Z193BR_Encounter_IsRandRecheck = A193BR_Encounter_IsRandRecheck;
            Z207BR_Encounter_IsRandRecheckr = A207BR_Encounter_IsRandRecheckr;
            Z208BR_Encounter_IsRandNoRecheckr = A208BR_Encounter_IsRandNoRecheckr;
            Z209BR_Encounter_IsRandRecheckDate = A209BR_Encounter_IsRandRecheckDate;
            Z210BR_Encounter_IsRandNoRecheckDate = A210BR_Encounter_IsRandNoRecheckDate;
            Z202BR_Encounter_IsUpdate = A202BR_Encounter_IsUpdate;
            Z537BR_Encounter_Datasource = A537BR_Encounter_Datasource;
            Z560EncounterIDEncrypt = A560EncounterIDEncrypt;
            Z85BR_Information_ID = A85BR_Information_ID;
            Z360BAS_TenantTenantCode = A360BAS_TenantTenantCode;
            Z36BR_Information_PatientNo = A36BR_Information_PatientNo;
         }
      }

      protected void standaloneNotModal( )
      {
         edtBR_EncounterID_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_EncounterID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBR_EncounterID_Enabled), 5, 0)), true);
         imgprompt_85_Link = ((StringUtil.StrCmp(Gx_mode, "DSP")==0) ? "" : "javascript:"+"gx.popup.openPrompt('"+"br_informationprompt.aspx"+"',["+"{Ctrl:gx.dom.el('"+"BR_INFORMATION_ID"+"'), id:'"+"BR_INFORMATION_ID"+"'"+",IOType:'inout'}"+","+"{Ctrl:gx.dom.el('"+"BR_INFORMATION_PATIENTNO"+"'), id:'"+"BR_INFORMATION_PATIENTNO"+"'"+",IOType:'inout'}"+"],"+"null"+","+"'', false"+","+"false"+");");
         edtBR_EncounterID_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_EncounterID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBR_EncounterID_Enabled), 5, 0)), true);
         bttBtntrn_delete_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtntrn_delete_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtntrn_delete_Enabled), 5, 0)), true);
         if ( ! (0==AV7BR_EncounterID) )
         {
            A19BR_EncounterID = AV7BR_EncounterID;
            n19BR_EncounterID = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A19BR_EncounterID", StringUtil.LTrim( StringUtil.Str( (decimal)(A19BR_EncounterID), 18, 0)));
         }
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) && ! (0==AV8Insert_BR_Information_ID) )
         {
            edtBR_Information_ID_Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Information_ID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBR_Information_ID_Enabled), 5, 0)), true);
         }
         else
         {
            edtBR_Information_ID_Enabled = 1;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Information_ID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBR_Information_ID_Enabled), 5, 0)), true);
         }
         GXABR_ENCOUNTER_DEPARTMENT_html0E15( AV30tCurrentCode) ;
         GXABR_ENCOUNTER_ENCTYPE_html0E15( AV30tCurrentCode) ;
         GXABR_ENCOUNTER_ADMITSOURCE_html0E15( AV30tCurrentCode) ;
         GXABR_ENCOUNTER_DISCHARGESTATUS_html0E15( AV30tCurrentCode) ;
      }

      protected void standaloneModal( )
      {
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) && ! String.IsNullOrEmpty(StringUtil.RTrim( AV29Insert_BAS_TenantTenantCode)) )
         {
            A360BAS_TenantTenantCode = AV29Insert_BAS_TenantTenantCode;
            n360BAS_TenantTenantCode = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A360BAS_TenantTenantCode", A360BAS_TenantTenantCode);
         }
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) && ! (0==AV8Insert_BR_Information_ID) )
         {
            A85BR_Information_ID = AV8Insert_BR_Information_ID;
            n85BR_Information_ID = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A85BR_Information_ID", StringUtil.LTrim( StringUtil.Str( (decimal)(A85BR_Information_ID), 18, 0)));
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
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) && ( Gx_BScreen == 0 ) )
         {
            AV32Pgmname = "BR_Encounter";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV32Pgmname", AV32Pgmname);
            AV31Pgmdesc = "就诊信息";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV31Pgmdesc", AV31Pgmdesc);
            edtavVdepartment_Visible = ((StringUtil.StrCmp(A84BR_Encounter_Department, "其它")==0) ? 1 : 0);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavVdepartment_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavVdepartment_Visible), 5, 0)), true);
            if ( ! ( ( StringUtil.StrCmp(A84BR_Encounter_Department, "其它") == 0 ) ) )
            {
               cellVdepartment_cell_Class = "Invisible";
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, cellVdepartment_cell_Internalname, "Class", cellVdepartment_cell_Class, true);
            }
            else
            {
               if ( StringUtil.StrCmp(A84BR_Encounter_Department, "其它") == 0 )
               {
                  cellVdepartment_cell_Class = "RequiredDataContentCell";
                  context.httpAjaxContext.ajax_rsp_assign_prop("", false, cellVdepartment_cell_Internalname, "Class", cellVdepartment_cell_Class, true);
               }
            }
            edtavVenctype_Visible = ((StringUtil.StrCmp(A90BR_Encounter_ENCType, "其它")==0) ? 1 : 0);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavVenctype_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavVenctype_Visible), 5, 0)), true);
            if ( ! ( ( StringUtil.StrCmp(A90BR_Encounter_ENCType, "其它") == 0 ) ) )
            {
               cellVenctype_cell_Class = "Invisible";
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, cellVenctype_cell_Internalname, "Class", cellVenctype_cell_Class, true);
            }
            else
            {
               if ( StringUtil.StrCmp(A90BR_Encounter_ENCType, "其它") == 0 )
               {
                  cellVenctype_cell_Class = "RequiredDataContentCell";
                  context.httpAjaxContext.ajax_rsp_assign_prop("", false, cellVenctype_cell_Internalname, "Class", cellVenctype_cell_Class, true);
               }
            }
            edtavVreason_Visible = ((StringUtil.StrCmp(A92BR_Encounter_AdmitSource, "其它")==0) ? 1 : 0);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavVreason_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavVreason_Visible), 5, 0)), true);
            if ( ! ( ( StringUtil.StrCmp(A92BR_Encounter_AdmitSource, "其它") == 0 ) ) )
            {
               cellVreason_cell_Class = "Invisible";
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, cellVreason_cell_Internalname, "Class", cellVreason_cell_Class, true);
            }
            else
            {
               if ( StringUtil.StrCmp(A92BR_Encounter_AdmitSource, "其它") == 0 )
               {
                  cellVreason_cell_Class = "RequiredDataContentCell";
                  context.httpAjaxContext.ajax_rsp_assign_prop("", false, cellVreason_cell_Internalname, "Class", cellVreason_cell_Class, true);
               }
            }
            /* Using cursor T000E4 */
            pr_default.execute(2, new Object[] {n85BR_Information_ID, A85BR_Information_ID});
            A36BR_Information_PatientNo = T000E4_A36BR_Information_PatientNo[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A36BR_Information_PatientNo", A36BR_Information_PatientNo);
            n36BR_Information_PatientNo = T000E4_n36BR_Information_PatientNo[0];
            pr_default.close(2);
         }
      }

      protected void Load0E15( )
      {
         /* Using cursor T000E7 */
         pr_default.execute(4, new Object[] {n19BR_EncounterID, A19BR_EncounterID});
         if ( (pr_default.getStatus(4) != 101) )
         {
            RcdFound15 = 1;
            A35BR_Encounter_EncID = T000E7_A35BR_Encounter_EncID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A35BR_Encounter_EncID", StringUtil.LTrim( StringUtil.Str( (decimal)(A35BR_Encounter_EncID), 10, 0)));
            n35BR_Encounter_EncID = T000E7_n35BR_Encounter_EncID[0];
            A172BR_Encounter_Status = T000E7_A172BR_Encounter_Status[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A172BR_Encounter_Status", StringUtil.LTrim( StringUtil.Str( (decimal)(A172BR_Encounter_Status), 4, 0)));
            n172BR_Encounter_Status = T000E7_n172BR_Encounter_Status[0];
            A183BR_Encounter_CrtUser = T000E7_A183BR_Encounter_CrtUser[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A183BR_Encounter_CrtUser", A183BR_Encounter_CrtUser);
            n183BR_Encounter_CrtUser = T000E7_n183BR_Encounter_CrtUser[0];
            A512BR_Encounter_CrtDisplayName = T000E7_A512BR_Encounter_CrtDisplayName[0];
            n512BR_Encounter_CrtDisplayName = T000E7_n512BR_Encounter_CrtDisplayName[0];
            A182BR_Encounter_CrtDate = T000E7_A182BR_Encounter_CrtDate[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A182BR_Encounter_CrtDate", context.localUtil.TToC( A182BR_Encounter_CrtDate, 10, 8, 0, 0, "/", ":", " "));
            n182BR_Encounter_CrtDate = T000E7_n182BR_Encounter_CrtDate[0];
            A470BR_Encounter_Department_Code = T000E7_A470BR_Encounter_Department_Code[0];
            n470BR_Encounter_Department_Code = T000E7_n470BR_Encounter_Department_Code[0];
            A471BR_Encounter_ENCType_Code = T000E7_A471BR_Encounter_ENCType_Code[0];
            n471BR_Encounter_ENCType_Code = T000E7_n471BR_Encounter_ENCType_Code[0];
            A472BR_Encounter_AdmitSource_Code = T000E7_A472BR_Encounter_AdmitSource_Code[0];
            n472BR_Encounter_AdmitSource_Code = T000E7_n472BR_Encounter_AdmitSource_Code[0];
            A473BR_Encounter_DischargeStatus_Code = T000E7_A473BR_Encounter_DischargeStatus_Code[0];
            n473BR_Encounter_DischargeStatus_Code = T000E7_n473BR_Encounter_DischargeStatus_Code[0];
            A84BR_Encounter_Department = T000E7_A84BR_Encounter_Department[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A84BR_Encounter_Department", A84BR_Encounter_Department);
            n84BR_Encounter_Department = T000E7_n84BR_Encounter_Department[0];
            A570BR_Encounter_Departmentadm = T000E7_A570BR_Encounter_Departmentadm[0];
            n570BR_Encounter_Departmentadm = T000E7_n570BR_Encounter_Departmentadm[0];
            A571BR_Encounter_Departmentadm_Code = T000E7_A571BR_Encounter_Departmentadm_Code[0];
            n571BR_Encounter_Departmentadm_Code = T000E7_n571BR_Encounter_Departmentadm_Code[0];
            A572BR_Encounter_Departmentdisch = T000E7_A572BR_Encounter_Departmentdisch[0];
            n572BR_Encounter_Departmentdisch = T000E7_n572BR_Encounter_Departmentdisch[0];
            A573BR_Encounter_Departmentdisch_Code = T000E7_A573BR_Encounter_Departmentdisch_Code[0];
            n573BR_Encounter_Departmentdisch_Code = T000E7_n573BR_Encounter_Departmentdisch_Code[0];
            A90BR_Encounter_ENCType = T000E7_A90BR_Encounter_ENCType[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A90BR_Encounter_ENCType", A90BR_Encounter_ENCType);
            n90BR_Encounter_ENCType = T000E7_n90BR_Encounter_ENCType[0];
            A91BR_Encounter_AdmitDate = T000E7_A91BR_Encounter_AdmitDate[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A91BR_Encounter_AdmitDate", context.localUtil.Format(A91BR_Encounter_AdmitDate, "9999/99/99"));
            n91BR_Encounter_AdmitDate = T000E7_n91BR_Encounter_AdmitDate[0];
            A92BR_Encounter_AdmitSource = T000E7_A92BR_Encounter_AdmitSource[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A92BR_Encounter_AdmitSource", A92BR_Encounter_AdmitSource);
            n92BR_Encounter_AdmitSource = T000E7_n92BR_Encounter_AdmitSource[0];
            A93BR_Encounter_DischargeDate = T000E7_A93BR_Encounter_DischargeDate[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A93BR_Encounter_DischargeDate", context.localUtil.Format(A93BR_Encounter_DischargeDate, "9999/99/99"));
            n93BR_Encounter_DischargeDate = T000E7_n93BR_Encounter_DischargeDate[0];
            A94BR_Encounter_DischargeStatus = T000E7_A94BR_Encounter_DischargeStatus[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A94BR_Encounter_DischargeStatus", A94BR_Encounter_DischargeStatus);
            n94BR_Encounter_DischargeStatus = T000E7_n94BR_Encounter_DischargeStatus[0];
            A574BR_Encounter_Insurance = T000E7_A574BR_Encounter_Insurance[0];
            n574BR_Encounter_Insurance = T000E7_n574BR_Encounter_Insurance[0];
            A575BR_Encounter_Insurance_Code = T000E7_A575BR_Encounter_Insurance_Code[0];
            n575BR_Encounter_Insurance_Code = T000E7_n575BR_Encounter_Insurance_Code[0];
            A36BR_Information_PatientNo = T000E7_A36BR_Information_PatientNo[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A36BR_Information_PatientNo", A36BR_Information_PatientNo);
            n36BR_Information_PatientNo = T000E7_n36BR_Information_PatientNo[0];
            A187BR_Encounter_UpdDate = T000E7_A187BR_Encounter_UpdDate[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A187BR_Encounter_UpdDate", context.localUtil.TToC( A187BR_Encounter_UpdDate, 10, 8, 0, 0, "/", ":", " "));
            n187BR_Encounter_UpdDate = T000E7_n187BR_Encounter_UpdDate[0];
            A186BR_Encounter_UpdUser = T000E7_A186BR_Encounter_UpdUser[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A186BR_Encounter_UpdUser", A186BR_Encounter_UpdUser);
            n186BR_Encounter_UpdUser = T000E7_n186BR_Encounter_UpdUser[0];
            A333BR_Encounter_IsDLT = T000E7_A333BR_Encounter_IsDLT[0];
            n333BR_Encounter_IsDLT = T000E7_n333BR_Encounter_IsDLT[0];
            A184BR_Encounter_SubmitUser = T000E7_A184BR_Encounter_SubmitUser[0];
            n184BR_Encounter_SubmitUser = T000E7_n184BR_Encounter_SubmitUser[0];
            A335BR_Encounter_Reason = T000E7_A335BR_Encounter_Reason[0];
            n335BR_Encounter_Reason = T000E7_n335BR_Encounter_Reason[0];
            A185BR_Encounter_SubmitDate = T000E7_A185BR_Encounter_SubmitDate[0];
            n185BR_Encounter_SubmitDate = T000E7_n185BR_Encounter_SubmitDate[0];
            A188BR_Encounter_RecheckUser = T000E7_A188BR_Encounter_RecheckUser[0];
            n188BR_Encounter_RecheckUser = T000E7_n188BR_Encounter_RecheckUser[0];
            A336BR_Encounter_FReason = T000E7_A336BR_Encounter_FReason[0];
            n336BR_Encounter_FReason = T000E7_n336BR_Encounter_FReason[0];
            A189BR_Encounter_RecheckDate = T000E7_A189BR_Encounter_RecheckDate[0];
            n189BR_Encounter_RecheckDate = T000E7_n189BR_Encounter_RecheckDate[0];
            A190BR_Encounter_Approver = T000E7_A190BR_Encounter_Approver[0];
            n190BR_Encounter_Approver = T000E7_n190BR_Encounter_Approver[0];
            A191BR_Encounter_ApproveDate = T000E7_A191BR_Encounter_ApproveDate[0];
            n191BR_Encounter_ApproveDate = T000E7_n191BR_Encounter_ApproveDate[0];
            A192BR_Encounter_IsRandApprove = T000E7_A192BR_Encounter_IsRandApprove[0];
            n192BR_Encounter_IsRandApprove = T000E7_n192BR_Encounter_IsRandApprove[0];
            A203BR_Encounter_IsRandApprover = T000E7_A203BR_Encounter_IsRandApprover[0];
            n203BR_Encounter_IsRandApprover = T000E7_n203BR_Encounter_IsRandApprover[0];
            A204BR_Encounter_IsRandNoApprover = T000E7_A204BR_Encounter_IsRandNoApprover[0];
            n204BR_Encounter_IsRandNoApprover = T000E7_n204BR_Encounter_IsRandNoApprover[0];
            A205BR_Encounter_IsRandApproveDate = T000E7_A205BR_Encounter_IsRandApproveDate[0];
            n205BR_Encounter_IsRandApproveDate = T000E7_n205BR_Encounter_IsRandApproveDate[0];
            A206BR_Encounter_IsRandNoApproveDate = T000E7_A206BR_Encounter_IsRandNoApproveDate[0];
            n206BR_Encounter_IsRandNoApproveDate = T000E7_n206BR_Encounter_IsRandNoApproveDate[0];
            A193BR_Encounter_IsRandRecheck = T000E7_A193BR_Encounter_IsRandRecheck[0];
            n193BR_Encounter_IsRandRecheck = T000E7_n193BR_Encounter_IsRandRecheck[0];
            A207BR_Encounter_IsRandRecheckr = T000E7_A207BR_Encounter_IsRandRecheckr[0];
            n207BR_Encounter_IsRandRecheckr = T000E7_n207BR_Encounter_IsRandRecheckr[0];
            A208BR_Encounter_IsRandNoRecheckr = T000E7_A208BR_Encounter_IsRandNoRecheckr[0];
            n208BR_Encounter_IsRandNoRecheckr = T000E7_n208BR_Encounter_IsRandNoRecheckr[0];
            A209BR_Encounter_IsRandRecheckDate = T000E7_A209BR_Encounter_IsRandRecheckDate[0];
            n209BR_Encounter_IsRandRecheckDate = T000E7_n209BR_Encounter_IsRandRecheckDate[0];
            A210BR_Encounter_IsRandNoRecheckDate = T000E7_A210BR_Encounter_IsRandNoRecheckDate[0];
            n210BR_Encounter_IsRandNoRecheckDate = T000E7_n210BR_Encounter_IsRandNoRecheckDate[0];
            A202BR_Encounter_IsUpdate = T000E7_A202BR_Encounter_IsUpdate[0];
            n202BR_Encounter_IsUpdate = T000E7_n202BR_Encounter_IsUpdate[0];
            A537BR_Encounter_Datasource = T000E7_A537BR_Encounter_Datasource[0];
            n537BR_Encounter_Datasource = T000E7_n537BR_Encounter_Datasource[0];
            A560EncounterIDEncrypt = T000E7_A560EncounterIDEncrypt[0];
            n560EncounterIDEncrypt = T000E7_n560EncounterIDEncrypt[0];
            A85BR_Information_ID = T000E7_A85BR_Information_ID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A85BR_Information_ID", StringUtil.LTrim( StringUtil.Str( (decimal)(A85BR_Information_ID), 18, 0)));
            n85BR_Information_ID = T000E7_n85BR_Information_ID[0];
            A360BAS_TenantTenantCode = T000E7_A360BAS_TenantTenantCode[0];
            n360BAS_TenantTenantCode = T000E7_n360BAS_TenantTenantCode[0];
            ZM0E15( -47) ;
         }
         pr_default.close(4);
         OnLoadActions0E15( ) ;
      }

      protected void OnLoadActions0E15( )
      {
         AV32Pgmname = "BR_Encounter";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV32Pgmname", AV32Pgmname);
         AV31Pgmdesc = "就诊信息";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV31Pgmdesc", AV31Pgmdesc);
         edtavVdepartment_Visible = ((StringUtil.StrCmp(A84BR_Encounter_Department, "其它")==0) ? 1 : 0);
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavVdepartment_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavVdepartment_Visible), 5, 0)), true);
         if ( ! ( ( StringUtil.StrCmp(A84BR_Encounter_Department, "其它") == 0 ) ) )
         {
            cellVdepartment_cell_Class = "Invisible";
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cellVdepartment_cell_Internalname, "Class", cellVdepartment_cell_Class, true);
         }
         else
         {
            if ( StringUtil.StrCmp(A84BR_Encounter_Department, "其它") == 0 )
            {
               cellVdepartment_cell_Class = "RequiredDataContentCell";
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, cellVdepartment_cell_Internalname, "Class", cellVdepartment_cell_Class, true);
            }
         }
         edtavVenctype_Visible = ((StringUtil.StrCmp(A90BR_Encounter_ENCType, "其它")==0) ? 1 : 0);
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavVenctype_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavVenctype_Visible), 5, 0)), true);
         if ( ! ( ( StringUtil.StrCmp(A90BR_Encounter_ENCType, "其它") == 0 ) ) )
         {
            cellVenctype_cell_Class = "Invisible";
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cellVenctype_cell_Internalname, "Class", cellVenctype_cell_Class, true);
         }
         else
         {
            if ( StringUtil.StrCmp(A90BR_Encounter_ENCType, "其它") == 0 )
            {
               cellVenctype_cell_Class = "RequiredDataContentCell";
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, cellVenctype_cell_Internalname, "Class", cellVenctype_cell_Class, true);
            }
         }
         edtavVreason_Visible = ((StringUtil.StrCmp(A92BR_Encounter_AdmitSource, "其它")==0) ? 1 : 0);
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavVreason_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavVreason_Visible), 5, 0)), true);
         if ( ! ( ( StringUtil.StrCmp(A92BR_Encounter_AdmitSource, "其它") == 0 ) ) )
         {
            cellVreason_cell_Class = "Invisible";
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cellVreason_cell_Internalname, "Class", cellVreason_cell_Class, true);
         }
         else
         {
            if ( StringUtil.StrCmp(A92BR_Encounter_AdmitSource, "其它") == 0 )
            {
               cellVreason_cell_Class = "RequiredDataContentCell";
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, cellVreason_cell_Internalname, "Class", cellVreason_cell_Class, true);
            }
         }
      }

      protected void CheckExtendedTable0E15( )
      {
         Gx_BScreen = 1;
         standaloneModal( ) ;
         AV32Pgmname = "BR_Encounter";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV32Pgmname", AV32Pgmname);
         AV31Pgmdesc = "就诊信息";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV31Pgmdesc", AV31Pgmdesc);
         edtavVdepartment_Visible = ((StringUtil.StrCmp(A84BR_Encounter_Department, "其它")==0) ? 1 : 0);
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavVdepartment_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavVdepartment_Visible), 5, 0)), true);
         if ( ! ( ( StringUtil.StrCmp(A84BR_Encounter_Department, "其它") == 0 ) ) )
         {
            cellVdepartment_cell_Class = "Invisible";
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cellVdepartment_cell_Internalname, "Class", cellVdepartment_cell_Class, true);
         }
         else
         {
            if ( StringUtil.StrCmp(A84BR_Encounter_Department, "其它") == 0 )
            {
               cellVdepartment_cell_Class = "RequiredDataContentCell";
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, cellVdepartment_cell_Internalname, "Class", cellVdepartment_cell_Class, true);
            }
         }
         edtavVenctype_Visible = ((StringUtil.StrCmp(A90BR_Encounter_ENCType, "其它")==0) ? 1 : 0);
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavVenctype_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavVenctype_Visible), 5, 0)), true);
         if ( ! ( ( StringUtil.StrCmp(A90BR_Encounter_ENCType, "其它") == 0 ) ) )
         {
            cellVenctype_cell_Class = "Invisible";
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cellVenctype_cell_Internalname, "Class", cellVenctype_cell_Class, true);
         }
         else
         {
            if ( StringUtil.StrCmp(A90BR_Encounter_ENCType, "其它") == 0 )
            {
               cellVenctype_cell_Class = "RequiredDataContentCell";
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, cellVenctype_cell_Internalname, "Class", cellVenctype_cell_Class, true);
            }
         }
         if ( ! ( (DateTime.MinValue==A91BR_Encounter_AdmitDate) || ( A91BR_Encounter_AdmitDate >= context.localUtil.YMDToD( 1753, 1, 1) ) ) )
         {
            GX_msglist.addItem("域������/������������超界", "OutOfRange", 1, "BR_ENCOUNTER_ADMITDATE");
            AnyError = 1;
            GX_FocusControl = edtBR_Encounter_AdmitDate_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         edtavVreason_Visible = ((StringUtil.StrCmp(A92BR_Encounter_AdmitSource, "其它")==0) ? 1 : 0);
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavVreason_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavVreason_Visible), 5, 0)), true);
         if ( ! ( ( StringUtil.StrCmp(A92BR_Encounter_AdmitSource, "其它") == 0 ) ) )
         {
            cellVreason_cell_Class = "Invisible";
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cellVreason_cell_Internalname, "Class", cellVreason_cell_Class, true);
         }
         else
         {
            if ( StringUtil.StrCmp(A92BR_Encounter_AdmitSource, "其它") == 0 )
            {
               cellVreason_cell_Class = "RequiredDataContentCell";
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, cellVreason_cell_Internalname, "Class", cellVreason_cell_Class, true);
            }
         }
         if ( ! ( (DateTime.MinValue==A93BR_Encounter_DischargeDate) || ( A93BR_Encounter_DischargeDate >= context.localUtil.YMDToD( 1753, 1, 1) ) ) )
         {
            GX_msglist.addItem("域������������超界", "OutOfRange", 1, "BR_ENCOUNTER_DISCHARGEDATE");
            AnyError = 1;
            GX_FocusControl = edtBR_Encounter_DischargeDate_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( ! ( ( A172BR_Encounter_Status == 1 ) || ( A172BR_Encounter_Status == 2 ) || ( A172BR_Encounter_Status == 3 ) || ( A172BR_Encounter_Status == 4 ) || ( A172BR_Encounter_Status == 5 ) || ( A172BR_Encounter_Status == 6 ) || (0==A172BR_Encounter_Status) ) )
         {
            GX_msglist.addItem("域������������超界", "OutOfRange", 1, "BR_ENCOUNTER_STATUS");
            AnyError = 1;
            GX_FocusControl = cmbBR_Encounter_Status_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         /* Using cursor T000E4 */
         pr_default.execute(2, new Object[] {n85BR_Information_ID, A85BR_Information_ID});
         if ( (pr_default.getStatus(2) == 101) )
         {
            if ( ! ( (0==A85BR_Information_ID) ) )
            {
               GX_msglist.addItem("不匹配' T16'", "ForeignKeyNotFound", 1, "BR_INFORMATION_ID");
               AnyError = 1;
               GX_FocusControl = edtBR_Information_ID_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
         }
         A36BR_Information_PatientNo = T000E4_A36BR_Information_PatientNo[0];
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A36BR_Information_PatientNo", A36BR_Information_PatientNo);
         n36BR_Information_PatientNo = T000E4_n36BR_Information_PatientNo[0];
         pr_default.close(2);
         /* Using cursor T000E6 */
         pr_default.execute(3, new Object[] {n85BR_Information_ID, A85BR_Information_ID, n360BAS_TenantTenantCode, A360BAS_TenantTenantCode});
         if ( (pr_default.getStatus(3) == 101) )
         {
            if ( ! ( (0==A85BR_Information_ID) || String.IsNullOrEmpty(StringUtil.RTrim( A360BAS_TenantTenantCode)) ) )
            {
               GX_msglist.addItem("不匹配' T64'", "ForeignKeyNotFound", 1, "BR_INFORMATION_ID");
               AnyError = 1;
               GX_FocusControl = edtBR_Information_ID_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
         }
         pr_default.close(3);
         if ( (0==A85BR_Information_ID) )
         {
            GX_msglist.addItem("患者是必须选择的", 1, "BR_INFORMATION_ID");
            AnyError = 1;
            GX_FocusControl = edtBR_Information_ID_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( ! ( (DateTime.MinValue==A182BR_Encounter_CrtDate) || ( A182BR_Encounter_CrtDate >= context.localUtil.YMDHMSToT( 1753, 1, 1, 0, 0, 0) ) ) )
         {
            GX_msglist.addItem("域������������超界", "OutOfRange", 1, "BR_ENCOUNTER_CRTDATE");
            AnyError = 1;
            GX_FocusControl = edtBR_Encounter_CrtDate_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( ! ( (DateTime.MinValue==A187BR_Encounter_UpdDate) || ( A187BR_Encounter_UpdDate >= context.localUtil.YMDHMSToT( 1753, 1, 1, 0, 0, 0) ) ) )
         {
            GX_msglist.addItem("域������������超界", "OutOfRange", 1, "BR_ENCOUNTER_UPDDATE");
            AnyError = 1;
            GX_FocusControl = edtBR_Encounter_UpdDate_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( ( ( StringUtil.StrCmp(A84BR_Encounter_Department, "其它") == 0 ) ) && String.IsNullOrEmpty(StringUtil.RTrim( AV24vDepartment)) )
         {
            GX_msglist.addItem("其他就诊科室是必填的", 1, "BR_ENCOUNTER_DEPARTMENT");
            AnyError = 1;
            GX_FocusControl = dynBR_Encounter_Department_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( ( ( StringUtil.StrCmp(A90BR_Encounter_ENCType, "其它") == 0 ) ) && String.IsNullOrEmpty(StringUtil.RTrim( AV26vENCType)) )
         {
            GX_msglist.addItem("其它就诊方式是必填的", 1, "BR_ENCOUNTER_ENCTYPE");
            AnyError = 1;
            GX_FocusControl = dynBR_Encounter_ENCType_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( ( ( StringUtil.StrCmp(A92BR_Encounter_AdmitSource, "其它") == 0 ) ) && String.IsNullOrEmpty(StringUtil.RTrim( AV27vReason)) )
         {
            GX_msglist.addItem("其它入院原因是必填的", 1, "BR_ENCOUNTER_ADMITSOURCE");
            AnyError = 1;
            GX_FocusControl = dynBR_Encounter_AdmitSource_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         /* Using cursor T000E5 */
         pr_datastore1.execute(0, new Object[] {n360BAS_TenantTenantCode, A360BAS_TenantTenantCode});
         if ( (pr_datastore1.getStatus(0) == 101) )
         {
            if ( ! ( String.IsNullOrEmpty(StringUtil.RTrim( A360BAS_TenantTenantCode)) ) )
            {
               GX_msglist.addItem("不匹配'BAS_Tenant'", "ForeignKeyNotFound", 1, "");
               AnyError = 1;
            }
         }
         pr_datastore1.close(0);
      }

      protected void CloseExtendedTableCursors0E15( )
      {
         pr_default.close(2);
         pr_default.close(3);
         pr_datastore1.close(0);
      }

      protected void enableDisable( )
      {
      }

      protected void gxLoad_48( long A85BR_Information_ID )
      {
         /* Using cursor T000E8 */
         pr_default.execute(5, new Object[] {n85BR_Information_ID, A85BR_Information_ID});
         if ( (pr_default.getStatus(5) == 101) )
         {
            if ( ! ( (0==A85BR_Information_ID) ) )
            {
               GX_msglist.addItem("不匹配' T16'", "ForeignKeyNotFound", 1, "BR_INFORMATION_ID");
               AnyError = 1;
               GX_FocusControl = edtBR_Information_ID_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
         }
         A36BR_Information_PatientNo = T000E8_A36BR_Information_PatientNo[0];
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A36BR_Information_PatientNo", A36BR_Information_PatientNo);
         n36BR_Information_PatientNo = T000E8_n36BR_Information_PatientNo[0];
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("[[");
         context.GX_webresponse.AddString("\""+GXUtil.EncodeJSConstant( A36BR_Information_PatientNo)+"\"");
         context.GX_webresponse.AddString("]");
         if ( (pr_default.getStatus(5) == 101) )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString("]");
         pr_default.close(5);
      }

      protected void gxLoad_50( long A85BR_Information_ID ,
                                String A360BAS_TenantTenantCode )
      {
         /* Using cursor T000E9 */
         pr_default.execute(6, new Object[] {n85BR_Information_ID, A85BR_Information_ID, n360BAS_TenantTenantCode, A360BAS_TenantTenantCode});
         if ( (pr_default.getStatus(6) == 101) )
         {
            if ( ! ( (0==A85BR_Information_ID) || String.IsNullOrEmpty(StringUtil.RTrim( A360BAS_TenantTenantCode)) ) )
            {
               GX_msglist.addItem("不匹配' T64'", "ForeignKeyNotFound", 1, "BR_INFORMATION_ID");
               AnyError = 1;
               GX_FocusControl = edtBR_Information_ID_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
         }
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("[[");
         context.GX_webresponse.AddString("");
         context.GX_webresponse.AddString("]");
         if ( (pr_default.getStatus(6) == 101) )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString("]");
         pr_default.close(6);
      }

      protected void gxLoad_49( String A360BAS_TenantTenantCode )
      {
         /* Using cursor T000E10 */
         pr_datastore1.execute(1, new Object[] {n360BAS_TenantTenantCode, A360BAS_TenantTenantCode});
         if ( (pr_datastore1.getStatus(1) == 101) )
         {
            if ( ! ( String.IsNullOrEmpty(StringUtil.RTrim( A360BAS_TenantTenantCode)) ) )
            {
               GX_msglist.addItem("不匹配'BAS_Tenant'", "ForeignKeyNotFound", 1, "");
               AnyError = 1;
            }
         }
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("[[");
         context.GX_webresponse.AddString("");
         context.GX_webresponse.AddString("]");
         if ( (pr_datastore1.getStatus(1) == 101) )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString("]");
         pr_datastore1.close(1);
      }

      protected void GetKey0E15( )
      {
         /* Using cursor T000E11 */
         pr_default.execute(7, new Object[] {n19BR_EncounterID, A19BR_EncounterID});
         if ( (pr_default.getStatus(7) != 101) )
         {
            RcdFound15 = 1;
         }
         else
         {
            RcdFound15 = 0;
         }
         pr_default.close(7);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor T000E3 */
         pr_default.execute(1, new Object[] {n19BR_EncounterID, A19BR_EncounterID});
         if ( (pr_default.getStatus(1) != 101) )
         {
            ZM0E15( 47) ;
            RcdFound15 = 1;
            A19BR_EncounterID = T000E3_A19BR_EncounterID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A19BR_EncounterID", StringUtil.LTrim( StringUtil.Str( (decimal)(A19BR_EncounterID), 18, 0)));
            n19BR_EncounterID = T000E3_n19BR_EncounterID[0];
            A35BR_Encounter_EncID = T000E3_A35BR_Encounter_EncID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A35BR_Encounter_EncID", StringUtil.LTrim( StringUtil.Str( (decimal)(A35BR_Encounter_EncID), 10, 0)));
            n35BR_Encounter_EncID = T000E3_n35BR_Encounter_EncID[0];
            A172BR_Encounter_Status = T000E3_A172BR_Encounter_Status[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A172BR_Encounter_Status", StringUtil.LTrim( StringUtil.Str( (decimal)(A172BR_Encounter_Status), 4, 0)));
            n172BR_Encounter_Status = T000E3_n172BR_Encounter_Status[0];
            A183BR_Encounter_CrtUser = T000E3_A183BR_Encounter_CrtUser[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A183BR_Encounter_CrtUser", A183BR_Encounter_CrtUser);
            n183BR_Encounter_CrtUser = T000E3_n183BR_Encounter_CrtUser[0];
            A512BR_Encounter_CrtDisplayName = T000E3_A512BR_Encounter_CrtDisplayName[0];
            n512BR_Encounter_CrtDisplayName = T000E3_n512BR_Encounter_CrtDisplayName[0];
            A182BR_Encounter_CrtDate = T000E3_A182BR_Encounter_CrtDate[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A182BR_Encounter_CrtDate", context.localUtil.TToC( A182BR_Encounter_CrtDate, 10, 8, 0, 0, "/", ":", " "));
            n182BR_Encounter_CrtDate = T000E3_n182BR_Encounter_CrtDate[0];
            A470BR_Encounter_Department_Code = T000E3_A470BR_Encounter_Department_Code[0];
            n470BR_Encounter_Department_Code = T000E3_n470BR_Encounter_Department_Code[0];
            A471BR_Encounter_ENCType_Code = T000E3_A471BR_Encounter_ENCType_Code[0];
            n471BR_Encounter_ENCType_Code = T000E3_n471BR_Encounter_ENCType_Code[0];
            A472BR_Encounter_AdmitSource_Code = T000E3_A472BR_Encounter_AdmitSource_Code[0];
            n472BR_Encounter_AdmitSource_Code = T000E3_n472BR_Encounter_AdmitSource_Code[0];
            A473BR_Encounter_DischargeStatus_Code = T000E3_A473BR_Encounter_DischargeStatus_Code[0];
            n473BR_Encounter_DischargeStatus_Code = T000E3_n473BR_Encounter_DischargeStatus_Code[0];
            A84BR_Encounter_Department = T000E3_A84BR_Encounter_Department[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A84BR_Encounter_Department", A84BR_Encounter_Department);
            n84BR_Encounter_Department = T000E3_n84BR_Encounter_Department[0];
            A570BR_Encounter_Departmentadm = T000E3_A570BR_Encounter_Departmentadm[0];
            n570BR_Encounter_Departmentadm = T000E3_n570BR_Encounter_Departmentadm[0];
            A571BR_Encounter_Departmentadm_Code = T000E3_A571BR_Encounter_Departmentadm_Code[0];
            n571BR_Encounter_Departmentadm_Code = T000E3_n571BR_Encounter_Departmentadm_Code[0];
            A572BR_Encounter_Departmentdisch = T000E3_A572BR_Encounter_Departmentdisch[0];
            n572BR_Encounter_Departmentdisch = T000E3_n572BR_Encounter_Departmentdisch[0];
            A573BR_Encounter_Departmentdisch_Code = T000E3_A573BR_Encounter_Departmentdisch_Code[0];
            n573BR_Encounter_Departmentdisch_Code = T000E3_n573BR_Encounter_Departmentdisch_Code[0];
            A90BR_Encounter_ENCType = T000E3_A90BR_Encounter_ENCType[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A90BR_Encounter_ENCType", A90BR_Encounter_ENCType);
            n90BR_Encounter_ENCType = T000E3_n90BR_Encounter_ENCType[0];
            A91BR_Encounter_AdmitDate = T000E3_A91BR_Encounter_AdmitDate[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A91BR_Encounter_AdmitDate", context.localUtil.Format(A91BR_Encounter_AdmitDate, "9999/99/99"));
            n91BR_Encounter_AdmitDate = T000E3_n91BR_Encounter_AdmitDate[0];
            A92BR_Encounter_AdmitSource = T000E3_A92BR_Encounter_AdmitSource[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A92BR_Encounter_AdmitSource", A92BR_Encounter_AdmitSource);
            n92BR_Encounter_AdmitSource = T000E3_n92BR_Encounter_AdmitSource[0];
            A93BR_Encounter_DischargeDate = T000E3_A93BR_Encounter_DischargeDate[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A93BR_Encounter_DischargeDate", context.localUtil.Format(A93BR_Encounter_DischargeDate, "9999/99/99"));
            n93BR_Encounter_DischargeDate = T000E3_n93BR_Encounter_DischargeDate[0];
            A94BR_Encounter_DischargeStatus = T000E3_A94BR_Encounter_DischargeStatus[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A94BR_Encounter_DischargeStatus", A94BR_Encounter_DischargeStatus);
            n94BR_Encounter_DischargeStatus = T000E3_n94BR_Encounter_DischargeStatus[0];
            A574BR_Encounter_Insurance = T000E3_A574BR_Encounter_Insurance[0];
            n574BR_Encounter_Insurance = T000E3_n574BR_Encounter_Insurance[0];
            A575BR_Encounter_Insurance_Code = T000E3_A575BR_Encounter_Insurance_Code[0];
            n575BR_Encounter_Insurance_Code = T000E3_n575BR_Encounter_Insurance_Code[0];
            A187BR_Encounter_UpdDate = T000E3_A187BR_Encounter_UpdDate[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A187BR_Encounter_UpdDate", context.localUtil.TToC( A187BR_Encounter_UpdDate, 10, 8, 0, 0, "/", ":", " "));
            n187BR_Encounter_UpdDate = T000E3_n187BR_Encounter_UpdDate[0];
            A186BR_Encounter_UpdUser = T000E3_A186BR_Encounter_UpdUser[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A186BR_Encounter_UpdUser", A186BR_Encounter_UpdUser);
            n186BR_Encounter_UpdUser = T000E3_n186BR_Encounter_UpdUser[0];
            A333BR_Encounter_IsDLT = T000E3_A333BR_Encounter_IsDLT[0];
            n333BR_Encounter_IsDLT = T000E3_n333BR_Encounter_IsDLT[0];
            A184BR_Encounter_SubmitUser = T000E3_A184BR_Encounter_SubmitUser[0];
            n184BR_Encounter_SubmitUser = T000E3_n184BR_Encounter_SubmitUser[0];
            A335BR_Encounter_Reason = T000E3_A335BR_Encounter_Reason[0];
            n335BR_Encounter_Reason = T000E3_n335BR_Encounter_Reason[0];
            A185BR_Encounter_SubmitDate = T000E3_A185BR_Encounter_SubmitDate[0];
            n185BR_Encounter_SubmitDate = T000E3_n185BR_Encounter_SubmitDate[0];
            A188BR_Encounter_RecheckUser = T000E3_A188BR_Encounter_RecheckUser[0];
            n188BR_Encounter_RecheckUser = T000E3_n188BR_Encounter_RecheckUser[0];
            A336BR_Encounter_FReason = T000E3_A336BR_Encounter_FReason[0];
            n336BR_Encounter_FReason = T000E3_n336BR_Encounter_FReason[0];
            A189BR_Encounter_RecheckDate = T000E3_A189BR_Encounter_RecheckDate[0];
            n189BR_Encounter_RecheckDate = T000E3_n189BR_Encounter_RecheckDate[0];
            A190BR_Encounter_Approver = T000E3_A190BR_Encounter_Approver[0];
            n190BR_Encounter_Approver = T000E3_n190BR_Encounter_Approver[0];
            A191BR_Encounter_ApproveDate = T000E3_A191BR_Encounter_ApproveDate[0];
            n191BR_Encounter_ApproveDate = T000E3_n191BR_Encounter_ApproveDate[0];
            A192BR_Encounter_IsRandApprove = T000E3_A192BR_Encounter_IsRandApprove[0];
            n192BR_Encounter_IsRandApprove = T000E3_n192BR_Encounter_IsRandApprove[0];
            A203BR_Encounter_IsRandApprover = T000E3_A203BR_Encounter_IsRandApprover[0];
            n203BR_Encounter_IsRandApprover = T000E3_n203BR_Encounter_IsRandApprover[0];
            A204BR_Encounter_IsRandNoApprover = T000E3_A204BR_Encounter_IsRandNoApprover[0];
            n204BR_Encounter_IsRandNoApprover = T000E3_n204BR_Encounter_IsRandNoApprover[0];
            A205BR_Encounter_IsRandApproveDate = T000E3_A205BR_Encounter_IsRandApproveDate[0];
            n205BR_Encounter_IsRandApproveDate = T000E3_n205BR_Encounter_IsRandApproveDate[0];
            A206BR_Encounter_IsRandNoApproveDate = T000E3_A206BR_Encounter_IsRandNoApproveDate[0];
            n206BR_Encounter_IsRandNoApproveDate = T000E3_n206BR_Encounter_IsRandNoApproveDate[0];
            A193BR_Encounter_IsRandRecheck = T000E3_A193BR_Encounter_IsRandRecheck[0];
            n193BR_Encounter_IsRandRecheck = T000E3_n193BR_Encounter_IsRandRecheck[0];
            A207BR_Encounter_IsRandRecheckr = T000E3_A207BR_Encounter_IsRandRecheckr[0];
            n207BR_Encounter_IsRandRecheckr = T000E3_n207BR_Encounter_IsRandRecheckr[0];
            A208BR_Encounter_IsRandNoRecheckr = T000E3_A208BR_Encounter_IsRandNoRecheckr[0];
            n208BR_Encounter_IsRandNoRecheckr = T000E3_n208BR_Encounter_IsRandNoRecheckr[0];
            A209BR_Encounter_IsRandRecheckDate = T000E3_A209BR_Encounter_IsRandRecheckDate[0];
            n209BR_Encounter_IsRandRecheckDate = T000E3_n209BR_Encounter_IsRandRecheckDate[0];
            A210BR_Encounter_IsRandNoRecheckDate = T000E3_A210BR_Encounter_IsRandNoRecheckDate[0];
            n210BR_Encounter_IsRandNoRecheckDate = T000E3_n210BR_Encounter_IsRandNoRecheckDate[0];
            A202BR_Encounter_IsUpdate = T000E3_A202BR_Encounter_IsUpdate[0];
            n202BR_Encounter_IsUpdate = T000E3_n202BR_Encounter_IsUpdate[0];
            A537BR_Encounter_Datasource = T000E3_A537BR_Encounter_Datasource[0];
            n537BR_Encounter_Datasource = T000E3_n537BR_Encounter_Datasource[0];
            A560EncounterIDEncrypt = T000E3_A560EncounterIDEncrypt[0];
            n560EncounterIDEncrypt = T000E3_n560EncounterIDEncrypt[0];
            A85BR_Information_ID = T000E3_A85BR_Information_ID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A85BR_Information_ID", StringUtil.LTrim( StringUtil.Str( (decimal)(A85BR_Information_ID), 18, 0)));
            n85BR_Information_ID = T000E3_n85BR_Information_ID[0];
            A360BAS_TenantTenantCode = T000E3_A360BAS_TenantTenantCode[0];
            n360BAS_TenantTenantCode = T000E3_n360BAS_TenantTenantCode[0];
            Z19BR_EncounterID = A19BR_EncounterID;
            sMode15 = Gx_mode;
            Gx_mode = "DSP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
            Load0E15( ) ;
            if ( AnyError == 1 )
            {
               RcdFound15 = 0;
               InitializeNonKey0E15( ) ;
            }
            Gx_mode = sMode15;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         }
         else
         {
            RcdFound15 = 0;
            InitializeNonKey0E15( ) ;
            sMode15 = Gx_mode;
            Gx_mode = "DSP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
            standaloneModal( ) ;
            Gx_mode = sMode15;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         }
         pr_default.close(1);
      }

      protected void getEqualNoModal( )
      {
         GetKey0E15( ) ;
         if ( RcdFound15 == 0 )
         {
         }
         else
         {
         }
         getByPrimaryKey( ) ;
      }

      protected void move_next( )
      {
         RcdFound15 = 0;
         /* Using cursor T000E12 */
         pr_default.execute(8, new Object[] {n19BR_EncounterID, A19BR_EncounterID});
         if ( (pr_default.getStatus(8) != 101) )
         {
            while ( (pr_default.getStatus(8) != 101) && ( ( T000E12_A19BR_EncounterID[0] < A19BR_EncounterID ) ) )
            {
               pr_default.readNext(8);
            }
            if ( (pr_default.getStatus(8) != 101) && ( ( T000E12_A19BR_EncounterID[0] > A19BR_EncounterID ) ) )
            {
               A19BR_EncounterID = T000E12_A19BR_EncounterID[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A19BR_EncounterID", StringUtil.LTrim( StringUtil.Str( (decimal)(A19BR_EncounterID), 18, 0)));
               n19BR_EncounterID = T000E12_n19BR_EncounterID[0];
               RcdFound15 = 1;
            }
         }
         pr_default.close(8);
      }

      protected void move_previous( )
      {
         RcdFound15 = 0;
         /* Using cursor T000E13 */
         pr_default.execute(9, new Object[] {n19BR_EncounterID, A19BR_EncounterID});
         if ( (pr_default.getStatus(9) != 101) )
         {
            while ( (pr_default.getStatus(9) != 101) && ( ( T000E13_A19BR_EncounterID[0] > A19BR_EncounterID ) ) )
            {
               pr_default.readNext(9);
            }
            if ( (pr_default.getStatus(9) != 101) && ( ( T000E13_A19BR_EncounterID[0] < A19BR_EncounterID ) ) )
            {
               A19BR_EncounterID = T000E13_A19BR_EncounterID[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A19BR_EncounterID", StringUtil.LTrim( StringUtil.Str( (decimal)(A19BR_EncounterID), 18, 0)));
               n19BR_EncounterID = T000E13_n19BR_EncounterID[0];
               RcdFound15 = 1;
            }
         }
         pr_default.close(9);
      }

      protected void btn_enter( )
      {
         nKeyPressed = 1;
         GetKey0E15( ) ;
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            /* Insert record */
            GX_FocusControl = edtBR_Information_ID_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            Insert0E15( ) ;
            if ( AnyError == 1 )
            {
               GX_FocusControl = "";
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
         }
         else
         {
            if ( RcdFound15 == 1 )
            {
               if ( A19BR_EncounterID != Z19BR_EncounterID )
               {
                  A19BR_EncounterID = Z19BR_EncounterID;
                  n19BR_EncounterID = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A19BR_EncounterID", StringUtil.LTrim( StringUtil.Str( (decimal)(A19BR_EncounterID), 18, 0)));
                  GX_msglist.addItem(context.GetMessage( "GXM_getbeforeupd", ""), "CandidateKeyNotFound", 1, "BR_ENCOUNTERID");
                  AnyError = 1;
                  GX_FocusControl = edtBR_EncounterID_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
               else if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
               {
                  delete( ) ;
                  AfterTrn( ) ;
                  GX_FocusControl = edtBR_Information_ID_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
               else
               {
                  /* Update record */
                  Update0E15( ) ;
                  GX_FocusControl = edtBR_Information_ID_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
            }
            else
            {
               if ( A19BR_EncounterID != Z19BR_EncounterID )
               {
                  /* Insert record */
                  GX_FocusControl = edtBR_Information_ID_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  Insert0E15( ) ;
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
                     GX_msglist.addItem(context.GetMessage( "GXM_recdeleted", ""), 1, "BR_ENCOUNTERID");
                     AnyError = 1;
                     GX_FocusControl = edtBR_EncounterID_Internalname;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  }
                  else
                  {
                     /* Insert record */
                     GX_FocusControl = edtBR_Information_ID_Internalname;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                     Insert0E15( ) ;
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
         if ( ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 ) || ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 ) )
         {
            if ( AnyError == 0 )
            {
               context.nUserReturn = 1;
            }
         }
      }

      protected void btn_delete( )
      {
         if ( A19BR_EncounterID != Z19BR_EncounterID )
         {
            A19BR_EncounterID = Z19BR_EncounterID;
            n19BR_EncounterID = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A19BR_EncounterID", StringUtil.LTrim( StringUtil.Str( (decimal)(A19BR_EncounterID), 18, 0)));
            GX_msglist.addItem(context.GetMessage( "GXM_getbeforedlt", ""), 1, "BR_ENCOUNTERID");
            AnyError = 1;
            GX_FocusControl = edtBR_EncounterID_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         else
         {
            delete( ) ;
            AfterTrn( ) ;
            GX_FocusControl = edtBR_Information_ID_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( AnyError != 0 )
         {
         }
      }

      protected void CheckOptimisticConcurrency0E15( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor T000E2 */
            pr_default.execute(0, new Object[] {n19BR_EncounterID, A19BR_EncounterID});
            if ( (pr_default.getStatus(0) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"BR_Encounter"}), "RecordIsLocked", 1, "");
               AnyError = 1;
               return  ;
            }
            Gx_longc = false;
            if ( (pr_default.getStatus(0) == 101) || ( Z35BR_Encounter_EncID != T000E2_A35BR_Encounter_EncID[0] ) || ( Z172BR_Encounter_Status != T000E2_A172BR_Encounter_Status[0] ) || ( StringUtil.StrCmp(Z183BR_Encounter_CrtUser, T000E2_A183BR_Encounter_CrtUser[0]) != 0 ) || ( StringUtil.StrCmp(Z512BR_Encounter_CrtDisplayName, T000E2_A512BR_Encounter_CrtDisplayName[0]) != 0 ) || ( Z182BR_Encounter_CrtDate != T000E2_A182BR_Encounter_CrtDate[0] ) )
            {
               Gx_longc = true;
            }
            if ( Gx_longc || ( StringUtil.StrCmp(Z470BR_Encounter_Department_Code, T000E2_A470BR_Encounter_Department_Code[0]) != 0 ) || ( StringUtil.StrCmp(Z471BR_Encounter_ENCType_Code, T000E2_A471BR_Encounter_ENCType_Code[0]) != 0 ) || ( StringUtil.StrCmp(Z472BR_Encounter_AdmitSource_Code, T000E2_A472BR_Encounter_AdmitSource_Code[0]) != 0 ) || ( StringUtil.StrCmp(Z473BR_Encounter_DischargeStatus_Code, T000E2_A473BR_Encounter_DischargeStatus_Code[0]) != 0 ) || ( StringUtil.StrCmp(Z84BR_Encounter_Department, T000E2_A84BR_Encounter_Department[0]) != 0 ) )
            {
               Gx_longc = true;
            }
            if ( Gx_longc || ( StringUtil.StrCmp(Z570BR_Encounter_Departmentadm, T000E2_A570BR_Encounter_Departmentadm[0]) != 0 ) || ( StringUtil.StrCmp(Z571BR_Encounter_Departmentadm_Code, T000E2_A571BR_Encounter_Departmentadm_Code[0]) != 0 ) || ( StringUtil.StrCmp(Z572BR_Encounter_Departmentdisch, T000E2_A572BR_Encounter_Departmentdisch[0]) != 0 ) || ( StringUtil.StrCmp(Z573BR_Encounter_Departmentdisch_Code, T000E2_A573BR_Encounter_Departmentdisch_Code[0]) != 0 ) || ( StringUtil.StrCmp(Z90BR_Encounter_ENCType, T000E2_A90BR_Encounter_ENCType[0]) != 0 ) )
            {
               Gx_longc = true;
            }
            if ( Gx_longc || ( Z91BR_Encounter_AdmitDate != T000E2_A91BR_Encounter_AdmitDate[0] ) || ( StringUtil.StrCmp(Z92BR_Encounter_AdmitSource, T000E2_A92BR_Encounter_AdmitSource[0]) != 0 ) || ( Z93BR_Encounter_DischargeDate != T000E2_A93BR_Encounter_DischargeDate[0] ) || ( StringUtil.StrCmp(Z94BR_Encounter_DischargeStatus, T000E2_A94BR_Encounter_DischargeStatus[0]) != 0 ) || ( StringUtil.StrCmp(Z574BR_Encounter_Insurance, T000E2_A574BR_Encounter_Insurance[0]) != 0 ) )
            {
               Gx_longc = true;
            }
            if ( Gx_longc || ( StringUtil.StrCmp(Z575BR_Encounter_Insurance_Code, T000E2_A575BR_Encounter_Insurance_Code[0]) != 0 ) || ( Z187BR_Encounter_UpdDate != T000E2_A187BR_Encounter_UpdDate[0] ) || ( StringUtil.StrCmp(Z186BR_Encounter_UpdUser, T000E2_A186BR_Encounter_UpdUser[0]) != 0 ) || ( Z333BR_Encounter_IsDLT != T000E2_A333BR_Encounter_IsDLT[0] ) || ( StringUtil.StrCmp(Z184BR_Encounter_SubmitUser, T000E2_A184BR_Encounter_SubmitUser[0]) != 0 ) )
            {
               Gx_longc = true;
            }
            if ( Gx_longc || ( StringUtil.StrCmp(Z335BR_Encounter_Reason, T000E2_A335BR_Encounter_Reason[0]) != 0 ) || ( Z185BR_Encounter_SubmitDate != T000E2_A185BR_Encounter_SubmitDate[0] ) || ( StringUtil.StrCmp(Z188BR_Encounter_RecheckUser, T000E2_A188BR_Encounter_RecheckUser[0]) != 0 ) || ( StringUtil.StrCmp(Z336BR_Encounter_FReason, T000E2_A336BR_Encounter_FReason[0]) != 0 ) || ( Z189BR_Encounter_RecheckDate != T000E2_A189BR_Encounter_RecheckDate[0] ) )
            {
               Gx_longc = true;
            }
            if ( Gx_longc || ( StringUtil.StrCmp(Z190BR_Encounter_Approver, T000E2_A190BR_Encounter_Approver[0]) != 0 ) || ( Z191BR_Encounter_ApproveDate != T000E2_A191BR_Encounter_ApproveDate[0] ) || ( Z192BR_Encounter_IsRandApprove != T000E2_A192BR_Encounter_IsRandApprove[0] ) || ( StringUtil.StrCmp(Z203BR_Encounter_IsRandApprover, T000E2_A203BR_Encounter_IsRandApprover[0]) != 0 ) || ( StringUtil.StrCmp(Z204BR_Encounter_IsRandNoApprover, T000E2_A204BR_Encounter_IsRandNoApprover[0]) != 0 ) )
            {
               Gx_longc = true;
            }
            if ( Gx_longc || ( Z205BR_Encounter_IsRandApproveDate != T000E2_A205BR_Encounter_IsRandApproveDate[0] ) || ( Z206BR_Encounter_IsRandNoApproveDate != T000E2_A206BR_Encounter_IsRandNoApproveDate[0] ) || ( Z193BR_Encounter_IsRandRecheck != T000E2_A193BR_Encounter_IsRandRecheck[0] ) || ( StringUtil.StrCmp(Z207BR_Encounter_IsRandRecheckr, T000E2_A207BR_Encounter_IsRandRecheckr[0]) != 0 ) || ( StringUtil.StrCmp(Z208BR_Encounter_IsRandNoRecheckr, T000E2_A208BR_Encounter_IsRandNoRecheckr[0]) != 0 ) )
            {
               Gx_longc = true;
            }
            if ( Gx_longc || ( Z209BR_Encounter_IsRandRecheckDate != T000E2_A209BR_Encounter_IsRandRecheckDate[0] ) || ( Z210BR_Encounter_IsRandNoRecheckDate != T000E2_A210BR_Encounter_IsRandNoRecheckDate[0] ) || ( Z202BR_Encounter_IsUpdate != T000E2_A202BR_Encounter_IsUpdate[0] ) || ( Z537BR_Encounter_Datasource != T000E2_A537BR_Encounter_Datasource[0] ) || ( StringUtil.StrCmp(Z560EncounterIDEncrypt, T000E2_A560EncounterIDEncrypt[0]) != 0 ) )
            {
               Gx_longc = true;
            }
            if ( Gx_longc || ( Z85BR_Information_ID != T000E2_A85BR_Information_ID[0] ) || ( StringUtil.StrCmp(Z360BAS_TenantTenantCode, T000E2_A360BAS_TenantTenantCode[0]) != 0 ) )
            {
               if ( Z35BR_Encounter_EncID != T000E2_A35BR_Encounter_EncID[0] )
               {
                  GXUtil.WriteLog("br_encounter:[seudo value changed for attri]"+"BR_Encounter_EncID");
                  GXUtil.WriteLogRaw("Old: ",Z35BR_Encounter_EncID);
                  GXUtil.WriteLogRaw("Current: ",T000E2_A35BR_Encounter_EncID[0]);
               }
               if ( Z172BR_Encounter_Status != T000E2_A172BR_Encounter_Status[0] )
               {
                  GXUtil.WriteLog("br_encounter:[seudo value changed for attri]"+"BR_Encounter_Status");
                  GXUtil.WriteLogRaw("Old: ",Z172BR_Encounter_Status);
                  GXUtil.WriteLogRaw("Current: ",T000E2_A172BR_Encounter_Status[0]);
               }
               if ( StringUtil.StrCmp(Z183BR_Encounter_CrtUser, T000E2_A183BR_Encounter_CrtUser[0]) != 0 )
               {
                  GXUtil.WriteLog("br_encounter:[seudo value changed for attri]"+"BR_Encounter_CrtUser");
                  GXUtil.WriteLogRaw("Old: ",Z183BR_Encounter_CrtUser);
                  GXUtil.WriteLogRaw("Current: ",T000E2_A183BR_Encounter_CrtUser[0]);
               }
               if ( StringUtil.StrCmp(Z512BR_Encounter_CrtDisplayName, T000E2_A512BR_Encounter_CrtDisplayName[0]) != 0 )
               {
                  GXUtil.WriteLog("br_encounter:[seudo value changed for attri]"+"BR_Encounter_CrtDisplayName");
                  GXUtil.WriteLogRaw("Old: ",Z512BR_Encounter_CrtDisplayName);
                  GXUtil.WriteLogRaw("Current: ",T000E2_A512BR_Encounter_CrtDisplayName[0]);
               }
               if ( Z182BR_Encounter_CrtDate != T000E2_A182BR_Encounter_CrtDate[0] )
               {
                  GXUtil.WriteLog("br_encounter:[seudo value changed for attri]"+"BR_Encounter_CrtDate");
                  GXUtil.WriteLogRaw("Old: ",Z182BR_Encounter_CrtDate);
                  GXUtil.WriteLogRaw("Current: ",T000E2_A182BR_Encounter_CrtDate[0]);
               }
               if ( StringUtil.StrCmp(Z470BR_Encounter_Department_Code, T000E2_A470BR_Encounter_Department_Code[0]) != 0 )
               {
                  GXUtil.WriteLog("br_encounter:[seudo value changed for attri]"+"BR_Encounter_Department_Code");
                  GXUtil.WriteLogRaw("Old: ",Z470BR_Encounter_Department_Code);
                  GXUtil.WriteLogRaw("Current: ",T000E2_A470BR_Encounter_Department_Code[0]);
               }
               if ( StringUtil.StrCmp(Z471BR_Encounter_ENCType_Code, T000E2_A471BR_Encounter_ENCType_Code[0]) != 0 )
               {
                  GXUtil.WriteLog("br_encounter:[seudo value changed for attri]"+"BR_Encounter_ENCType_Code");
                  GXUtil.WriteLogRaw("Old: ",Z471BR_Encounter_ENCType_Code);
                  GXUtil.WriteLogRaw("Current: ",T000E2_A471BR_Encounter_ENCType_Code[0]);
               }
               if ( StringUtil.StrCmp(Z472BR_Encounter_AdmitSource_Code, T000E2_A472BR_Encounter_AdmitSource_Code[0]) != 0 )
               {
                  GXUtil.WriteLog("br_encounter:[seudo value changed for attri]"+"BR_Encounter_AdmitSource_Code");
                  GXUtil.WriteLogRaw("Old: ",Z472BR_Encounter_AdmitSource_Code);
                  GXUtil.WriteLogRaw("Current: ",T000E2_A472BR_Encounter_AdmitSource_Code[0]);
               }
               if ( StringUtil.StrCmp(Z473BR_Encounter_DischargeStatus_Code, T000E2_A473BR_Encounter_DischargeStatus_Code[0]) != 0 )
               {
                  GXUtil.WriteLog("br_encounter:[seudo value changed for attri]"+"BR_Encounter_DischargeStatus_Code");
                  GXUtil.WriteLogRaw("Old: ",Z473BR_Encounter_DischargeStatus_Code);
                  GXUtil.WriteLogRaw("Current: ",T000E2_A473BR_Encounter_DischargeStatus_Code[0]);
               }
               if ( StringUtil.StrCmp(Z84BR_Encounter_Department, T000E2_A84BR_Encounter_Department[0]) != 0 )
               {
                  GXUtil.WriteLog("br_encounter:[seudo value changed for attri]"+"BR_Encounter_Department");
                  GXUtil.WriteLogRaw("Old: ",Z84BR_Encounter_Department);
                  GXUtil.WriteLogRaw("Current: ",T000E2_A84BR_Encounter_Department[0]);
               }
               if ( StringUtil.StrCmp(Z570BR_Encounter_Departmentadm, T000E2_A570BR_Encounter_Departmentadm[0]) != 0 )
               {
                  GXUtil.WriteLog("br_encounter:[seudo value changed for attri]"+"BR_Encounter_Departmentadm");
                  GXUtil.WriteLogRaw("Old: ",Z570BR_Encounter_Departmentadm);
                  GXUtil.WriteLogRaw("Current: ",T000E2_A570BR_Encounter_Departmentadm[0]);
               }
               if ( StringUtil.StrCmp(Z571BR_Encounter_Departmentadm_Code, T000E2_A571BR_Encounter_Departmentadm_Code[0]) != 0 )
               {
                  GXUtil.WriteLog("br_encounter:[seudo value changed for attri]"+"BR_Encounter_Departmentadm_Code");
                  GXUtil.WriteLogRaw("Old: ",Z571BR_Encounter_Departmentadm_Code);
                  GXUtil.WriteLogRaw("Current: ",T000E2_A571BR_Encounter_Departmentadm_Code[0]);
               }
               if ( StringUtil.StrCmp(Z572BR_Encounter_Departmentdisch, T000E2_A572BR_Encounter_Departmentdisch[0]) != 0 )
               {
                  GXUtil.WriteLog("br_encounter:[seudo value changed for attri]"+"BR_Encounter_Departmentdisch");
                  GXUtil.WriteLogRaw("Old: ",Z572BR_Encounter_Departmentdisch);
                  GXUtil.WriteLogRaw("Current: ",T000E2_A572BR_Encounter_Departmentdisch[0]);
               }
               if ( StringUtil.StrCmp(Z573BR_Encounter_Departmentdisch_Code, T000E2_A573BR_Encounter_Departmentdisch_Code[0]) != 0 )
               {
                  GXUtil.WriteLog("br_encounter:[seudo value changed for attri]"+"BR_Encounter_Departmentdisch_Code");
                  GXUtil.WriteLogRaw("Old: ",Z573BR_Encounter_Departmentdisch_Code);
                  GXUtil.WriteLogRaw("Current: ",T000E2_A573BR_Encounter_Departmentdisch_Code[0]);
               }
               if ( StringUtil.StrCmp(Z90BR_Encounter_ENCType, T000E2_A90BR_Encounter_ENCType[0]) != 0 )
               {
                  GXUtil.WriteLog("br_encounter:[seudo value changed for attri]"+"BR_Encounter_ENCType");
                  GXUtil.WriteLogRaw("Old: ",Z90BR_Encounter_ENCType);
                  GXUtil.WriteLogRaw("Current: ",T000E2_A90BR_Encounter_ENCType[0]);
               }
               if ( Z91BR_Encounter_AdmitDate != T000E2_A91BR_Encounter_AdmitDate[0] )
               {
                  GXUtil.WriteLog("br_encounter:[seudo value changed for attri]"+"BR_Encounter_AdmitDate");
                  GXUtil.WriteLogRaw("Old: ",Z91BR_Encounter_AdmitDate);
                  GXUtil.WriteLogRaw("Current: ",T000E2_A91BR_Encounter_AdmitDate[0]);
               }
               if ( StringUtil.StrCmp(Z92BR_Encounter_AdmitSource, T000E2_A92BR_Encounter_AdmitSource[0]) != 0 )
               {
                  GXUtil.WriteLog("br_encounter:[seudo value changed for attri]"+"BR_Encounter_AdmitSource");
                  GXUtil.WriteLogRaw("Old: ",Z92BR_Encounter_AdmitSource);
                  GXUtil.WriteLogRaw("Current: ",T000E2_A92BR_Encounter_AdmitSource[0]);
               }
               if ( Z93BR_Encounter_DischargeDate != T000E2_A93BR_Encounter_DischargeDate[0] )
               {
                  GXUtil.WriteLog("br_encounter:[seudo value changed for attri]"+"BR_Encounter_DischargeDate");
                  GXUtil.WriteLogRaw("Old: ",Z93BR_Encounter_DischargeDate);
                  GXUtil.WriteLogRaw("Current: ",T000E2_A93BR_Encounter_DischargeDate[0]);
               }
               if ( StringUtil.StrCmp(Z94BR_Encounter_DischargeStatus, T000E2_A94BR_Encounter_DischargeStatus[0]) != 0 )
               {
                  GXUtil.WriteLog("br_encounter:[seudo value changed for attri]"+"BR_Encounter_DischargeStatus");
                  GXUtil.WriteLogRaw("Old: ",Z94BR_Encounter_DischargeStatus);
                  GXUtil.WriteLogRaw("Current: ",T000E2_A94BR_Encounter_DischargeStatus[0]);
               }
               if ( StringUtil.StrCmp(Z574BR_Encounter_Insurance, T000E2_A574BR_Encounter_Insurance[0]) != 0 )
               {
                  GXUtil.WriteLog("br_encounter:[seudo value changed for attri]"+"BR_Encounter_Insurance");
                  GXUtil.WriteLogRaw("Old: ",Z574BR_Encounter_Insurance);
                  GXUtil.WriteLogRaw("Current: ",T000E2_A574BR_Encounter_Insurance[0]);
               }
               if ( StringUtil.StrCmp(Z575BR_Encounter_Insurance_Code, T000E2_A575BR_Encounter_Insurance_Code[0]) != 0 )
               {
                  GXUtil.WriteLog("br_encounter:[seudo value changed for attri]"+"BR_Encounter_Insurance_Code");
                  GXUtil.WriteLogRaw("Old: ",Z575BR_Encounter_Insurance_Code);
                  GXUtil.WriteLogRaw("Current: ",T000E2_A575BR_Encounter_Insurance_Code[0]);
               }
               if ( Z187BR_Encounter_UpdDate != T000E2_A187BR_Encounter_UpdDate[0] )
               {
                  GXUtil.WriteLog("br_encounter:[seudo value changed for attri]"+"BR_Encounter_UpdDate");
                  GXUtil.WriteLogRaw("Old: ",Z187BR_Encounter_UpdDate);
                  GXUtil.WriteLogRaw("Current: ",T000E2_A187BR_Encounter_UpdDate[0]);
               }
               if ( StringUtil.StrCmp(Z186BR_Encounter_UpdUser, T000E2_A186BR_Encounter_UpdUser[0]) != 0 )
               {
                  GXUtil.WriteLog("br_encounter:[seudo value changed for attri]"+"BR_Encounter_UpdUser");
                  GXUtil.WriteLogRaw("Old: ",Z186BR_Encounter_UpdUser);
                  GXUtil.WriteLogRaw("Current: ",T000E2_A186BR_Encounter_UpdUser[0]);
               }
               if ( Z333BR_Encounter_IsDLT != T000E2_A333BR_Encounter_IsDLT[0] )
               {
                  GXUtil.WriteLog("br_encounter:[seudo value changed for attri]"+"BR_Encounter_IsDLT");
                  GXUtil.WriteLogRaw("Old: ",Z333BR_Encounter_IsDLT);
                  GXUtil.WriteLogRaw("Current: ",T000E2_A333BR_Encounter_IsDLT[0]);
               }
               if ( StringUtil.StrCmp(Z184BR_Encounter_SubmitUser, T000E2_A184BR_Encounter_SubmitUser[0]) != 0 )
               {
                  GXUtil.WriteLog("br_encounter:[seudo value changed for attri]"+"BR_Encounter_SubmitUser");
                  GXUtil.WriteLogRaw("Old: ",Z184BR_Encounter_SubmitUser);
                  GXUtil.WriteLogRaw("Current: ",T000E2_A184BR_Encounter_SubmitUser[0]);
               }
               if ( StringUtil.StrCmp(Z335BR_Encounter_Reason, T000E2_A335BR_Encounter_Reason[0]) != 0 )
               {
                  GXUtil.WriteLog("br_encounter:[seudo value changed for attri]"+"BR_Encounter_Reason");
                  GXUtil.WriteLogRaw("Old: ",Z335BR_Encounter_Reason);
                  GXUtil.WriteLogRaw("Current: ",T000E2_A335BR_Encounter_Reason[0]);
               }
               if ( Z185BR_Encounter_SubmitDate != T000E2_A185BR_Encounter_SubmitDate[0] )
               {
                  GXUtil.WriteLog("br_encounter:[seudo value changed for attri]"+"BR_Encounter_SubmitDate");
                  GXUtil.WriteLogRaw("Old: ",Z185BR_Encounter_SubmitDate);
                  GXUtil.WriteLogRaw("Current: ",T000E2_A185BR_Encounter_SubmitDate[0]);
               }
               if ( StringUtil.StrCmp(Z188BR_Encounter_RecheckUser, T000E2_A188BR_Encounter_RecheckUser[0]) != 0 )
               {
                  GXUtil.WriteLog("br_encounter:[seudo value changed for attri]"+"BR_Encounter_RecheckUser");
                  GXUtil.WriteLogRaw("Old: ",Z188BR_Encounter_RecheckUser);
                  GXUtil.WriteLogRaw("Current: ",T000E2_A188BR_Encounter_RecheckUser[0]);
               }
               if ( StringUtil.StrCmp(Z336BR_Encounter_FReason, T000E2_A336BR_Encounter_FReason[0]) != 0 )
               {
                  GXUtil.WriteLog("br_encounter:[seudo value changed for attri]"+"BR_Encounter_FReason");
                  GXUtil.WriteLogRaw("Old: ",Z336BR_Encounter_FReason);
                  GXUtil.WriteLogRaw("Current: ",T000E2_A336BR_Encounter_FReason[0]);
               }
               if ( Z189BR_Encounter_RecheckDate != T000E2_A189BR_Encounter_RecheckDate[0] )
               {
                  GXUtil.WriteLog("br_encounter:[seudo value changed for attri]"+"BR_Encounter_RecheckDate");
                  GXUtil.WriteLogRaw("Old: ",Z189BR_Encounter_RecheckDate);
                  GXUtil.WriteLogRaw("Current: ",T000E2_A189BR_Encounter_RecheckDate[0]);
               }
               if ( StringUtil.StrCmp(Z190BR_Encounter_Approver, T000E2_A190BR_Encounter_Approver[0]) != 0 )
               {
                  GXUtil.WriteLog("br_encounter:[seudo value changed for attri]"+"BR_Encounter_Approver");
                  GXUtil.WriteLogRaw("Old: ",Z190BR_Encounter_Approver);
                  GXUtil.WriteLogRaw("Current: ",T000E2_A190BR_Encounter_Approver[0]);
               }
               if ( Z191BR_Encounter_ApproveDate != T000E2_A191BR_Encounter_ApproveDate[0] )
               {
                  GXUtil.WriteLog("br_encounter:[seudo value changed for attri]"+"BR_Encounter_ApproveDate");
                  GXUtil.WriteLogRaw("Old: ",Z191BR_Encounter_ApproveDate);
                  GXUtil.WriteLogRaw("Current: ",T000E2_A191BR_Encounter_ApproveDate[0]);
               }
               if ( Z192BR_Encounter_IsRandApprove != T000E2_A192BR_Encounter_IsRandApprove[0] )
               {
                  GXUtil.WriteLog("br_encounter:[seudo value changed for attri]"+"BR_Encounter_IsRandApprove");
                  GXUtil.WriteLogRaw("Old: ",Z192BR_Encounter_IsRandApprove);
                  GXUtil.WriteLogRaw("Current: ",T000E2_A192BR_Encounter_IsRandApprove[0]);
               }
               if ( StringUtil.StrCmp(Z203BR_Encounter_IsRandApprover, T000E2_A203BR_Encounter_IsRandApprover[0]) != 0 )
               {
                  GXUtil.WriteLog("br_encounter:[seudo value changed for attri]"+"BR_Encounter_IsRandApprover");
                  GXUtil.WriteLogRaw("Old: ",Z203BR_Encounter_IsRandApprover);
                  GXUtil.WriteLogRaw("Current: ",T000E2_A203BR_Encounter_IsRandApprover[0]);
               }
               if ( StringUtil.StrCmp(Z204BR_Encounter_IsRandNoApprover, T000E2_A204BR_Encounter_IsRandNoApprover[0]) != 0 )
               {
                  GXUtil.WriteLog("br_encounter:[seudo value changed for attri]"+"BR_Encounter_IsRandNoApprover");
                  GXUtil.WriteLogRaw("Old: ",Z204BR_Encounter_IsRandNoApprover);
                  GXUtil.WriteLogRaw("Current: ",T000E2_A204BR_Encounter_IsRandNoApprover[0]);
               }
               if ( Z205BR_Encounter_IsRandApproveDate != T000E2_A205BR_Encounter_IsRandApproveDate[0] )
               {
                  GXUtil.WriteLog("br_encounter:[seudo value changed for attri]"+"BR_Encounter_IsRandApproveDate");
                  GXUtil.WriteLogRaw("Old: ",Z205BR_Encounter_IsRandApproveDate);
                  GXUtil.WriteLogRaw("Current: ",T000E2_A205BR_Encounter_IsRandApproveDate[0]);
               }
               if ( Z206BR_Encounter_IsRandNoApproveDate != T000E2_A206BR_Encounter_IsRandNoApproveDate[0] )
               {
                  GXUtil.WriteLog("br_encounter:[seudo value changed for attri]"+"BR_Encounter_IsRandNoApproveDate");
                  GXUtil.WriteLogRaw("Old: ",Z206BR_Encounter_IsRandNoApproveDate);
                  GXUtil.WriteLogRaw("Current: ",T000E2_A206BR_Encounter_IsRandNoApproveDate[0]);
               }
               if ( Z193BR_Encounter_IsRandRecheck != T000E2_A193BR_Encounter_IsRandRecheck[0] )
               {
                  GXUtil.WriteLog("br_encounter:[seudo value changed for attri]"+"BR_Encounter_IsRandRecheck");
                  GXUtil.WriteLogRaw("Old: ",Z193BR_Encounter_IsRandRecheck);
                  GXUtil.WriteLogRaw("Current: ",T000E2_A193BR_Encounter_IsRandRecheck[0]);
               }
               if ( StringUtil.StrCmp(Z207BR_Encounter_IsRandRecheckr, T000E2_A207BR_Encounter_IsRandRecheckr[0]) != 0 )
               {
                  GXUtil.WriteLog("br_encounter:[seudo value changed for attri]"+"BR_Encounter_IsRandRecheckr");
                  GXUtil.WriteLogRaw("Old: ",Z207BR_Encounter_IsRandRecheckr);
                  GXUtil.WriteLogRaw("Current: ",T000E2_A207BR_Encounter_IsRandRecheckr[0]);
               }
               if ( StringUtil.StrCmp(Z208BR_Encounter_IsRandNoRecheckr, T000E2_A208BR_Encounter_IsRandNoRecheckr[0]) != 0 )
               {
                  GXUtil.WriteLog("br_encounter:[seudo value changed for attri]"+"BR_Encounter_IsRandNoRecheckr");
                  GXUtil.WriteLogRaw("Old: ",Z208BR_Encounter_IsRandNoRecheckr);
                  GXUtil.WriteLogRaw("Current: ",T000E2_A208BR_Encounter_IsRandNoRecheckr[0]);
               }
               if ( Z209BR_Encounter_IsRandRecheckDate != T000E2_A209BR_Encounter_IsRandRecheckDate[0] )
               {
                  GXUtil.WriteLog("br_encounter:[seudo value changed for attri]"+"BR_Encounter_IsRandRecheckDate");
                  GXUtil.WriteLogRaw("Old: ",Z209BR_Encounter_IsRandRecheckDate);
                  GXUtil.WriteLogRaw("Current: ",T000E2_A209BR_Encounter_IsRandRecheckDate[0]);
               }
               if ( Z210BR_Encounter_IsRandNoRecheckDate != T000E2_A210BR_Encounter_IsRandNoRecheckDate[0] )
               {
                  GXUtil.WriteLog("br_encounter:[seudo value changed for attri]"+"BR_Encounter_IsRandNoRecheckDate");
                  GXUtil.WriteLogRaw("Old: ",Z210BR_Encounter_IsRandNoRecheckDate);
                  GXUtil.WriteLogRaw("Current: ",T000E2_A210BR_Encounter_IsRandNoRecheckDate[0]);
               }
               if ( Z202BR_Encounter_IsUpdate != T000E2_A202BR_Encounter_IsUpdate[0] )
               {
                  GXUtil.WriteLog("br_encounter:[seudo value changed for attri]"+"BR_Encounter_IsUpdate");
                  GXUtil.WriteLogRaw("Old: ",Z202BR_Encounter_IsUpdate);
                  GXUtil.WriteLogRaw("Current: ",T000E2_A202BR_Encounter_IsUpdate[0]);
               }
               if ( Z537BR_Encounter_Datasource != T000E2_A537BR_Encounter_Datasource[0] )
               {
                  GXUtil.WriteLog("br_encounter:[seudo value changed for attri]"+"BR_Encounter_Datasource");
                  GXUtil.WriteLogRaw("Old: ",Z537BR_Encounter_Datasource);
                  GXUtil.WriteLogRaw("Current: ",T000E2_A537BR_Encounter_Datasource[0]);
               }
               if ( StringUtil.StrCmp(Z560EncounterIDEncrypt, T000E2_A560EncounterIDEncrypt[0]) != 0 )
               {
                  GXUtil.WriteLog("br_encounter:[seudo value changed for attri]"+"EncounterIDEncrypt");
                  GXUtil.WriteLogRaw("Old: ",Z560EncounterIDEncrypt);
                  GXUtil.WriteLogRaw("Current: ",T000E2_A560EncounterIDEncrypt[0]);
               }
               if ( Z85BR_Information_ID != T000E2_A85BR_Information_ID[0] )
               {
                  GXUtil.WriteLog("br_encounter:[seudo value changed for attri]"+"BR_Information_ID");
                  GXUtil.WriteLogRaw("Old: ",Z85BR_Information_ID);
                  GXUtil.WriteLogRaw("Current: ",T000E2_A85BR_Information_ID[0]);
               }
               if ( StringUtil.StrCmp(Z360BAS_TenantTenantCode, T000E2_A360BAS_TenantTenantCode[0]) != 0 )
               {
                  GXUtil.WriteLog("br_encounter:[seudo value changed for attri]"+"BAS_TenantTenantCode");
                  GXUtil.WriteLogRaw("Old: ",Z360BAS_TenantTenantCode);
                  GXUtil.WriteLogRaw("Current: ",T000E2_A360BAS_TenantTenantCode[0]);
               }
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"BR_Encounter"}), "RecordWasChanged", 1, "");
               AnyError = 1;
               return  ;
            }
         }
      }

      protected void Insert0E15( )
      {
         BeforeValidate0E15( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0E15( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM0E15( 0) ;
            CheckOptimisticConcurrency0E15( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0E15( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert0E15( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000E14 */
                     pr_default.execute(10, new Object[] {n35BR_Encounter_EncID, A35BR_Encounter_EncID, n172BR_Encounter_Status, A172BR_Encounter_Status, n183BR_Encounter_CrtUser, A183BR_Encounter_CrtUser, n512BR_Encounter_CrtDisplayName, A512BR_Encounter_CrtDisplayName, n182BR_Encounter_CrtDate, A182BR_Encounter_CrtDate, n470BR_Encounter_Department_Code, A470BR_Encounter_Department_Code, n471BR_Encounter_ENCType_Code, A471BR_Encounter_ENCType_Code, n472BR_Encounter_AdmitSource_Code, A472BR_Encounter_AdmitSource_Code, n473BR_Encounter_DischargeStatus_Code, A473BR_Encounter_DischargeStatus_Code, n84BR_Encounter_Department, A84BR_Encounter_Department, n570BR_Encounter_Departmentadm, A570BR_Encounter_Departmentadm, n571BR_Encounter_Departmentadm_Code, A571BR_Encounter_Departmentadm_Code, n572BR_Encounter_Departmentdisch, A572BR_Encounter_Departmentdisch, n573BR_Encounter_Departmentdisch_Code, A573BR_Encounter_Departmentdisch_Code, n90BR_Encounter_ENCType, A90BR_Encounter_ENCType, n91BR_Encounter_AdmitDate, A91BR_Encounter_AdmitDate, n92BR_Encounter_AdmitSource, A92BR_Encounter_AdmitSource, n93BR_Encounter_DischargeDate, A93BR_Encounter_DischargeDate, n94BR_Encounter_DischargeStatus, A94BR_Encounter_DischargeStatus, n574BR_Encounter_Insurance, A574BR_Encounter_Insurance, n575BR_Encounter_Insurance_Code, A575BR_Encounter_Insurance_Code, n187BR_Encounter_UpdDate, A187BR_Encounter_UpdDate, n186BR_Encounter_UpdUser, A186BR_Encounter_UpdUser, n333BR_Encounter_IsDLT, A333BR_Encounter_IsDLT, n184BR_Encounter_SubmitUser, A184BR_Encounter_SubmitUser, n335BR_Encounter_Reason, A335BR_Encounter_Reason, n185BR_Encounter_SubmitDate, A185BR_Encounter_SubmitDate, n188BR_Encounter_RecheckUser, A188BR_Encounter_RecheckUser, n336BR_Encounter_FReason, A336BR_Encounter_FReason, n189BR_Encounter_RecheckDate, A189BR_Encounter_RecheckDate, n190BR_Encounter_Approver, A190BR_Encounter_Approver, n191BR_Encounter_ApproveDate, A191BR_Encounter_ApproveDate, n192BR_Encounter_IsRandApprove, A192BR_Encounter_IsRandApprove, n203BR_Encounter_IsRandApprover, A203BR_Encounter_IsRandApprover, n204BR_Encounter_IsRandNoApprover, A204BR_Encounter_IsRandNoApprover, n205BR_Encounter_IsRandApproveDate, A205BR_Encounter_IsRandApproveDate, n206BR_Encounter_IsRandNoApproveDate, A206BR_Encounter_IsRandNoApproveDate, n193BR_Encounter_IsRandRecheck, A193BR_Encounter_IsRandRecheck, n207BR_Encounter_IsRandRecheckr, A207BR_Encounter_IsRandRecheckr, n208BR_Encounter_IsRandNoRecheckr, A208BR_Encounter_IsRandNoRecheckr, n209BR_Encounter_IsRandRecheckDate, A209BR_Encounter_IsRandRecheckDate, n210BR_Encounter_IsRandNoRecheckDate, A210BR_Encounter_IsRandNoRecheckDate, n202BR_Encounter_IsUpdate, A202BR_Encounter_IsUpdate, n537BR_Encounter_Datasource, A537BR_Encounter_Datasource, n560EncounterIDEncrypt, A560EncounterIDEncrypt, n85BR_Information_ID, A85BR_Information_ID, n360BAS_TenantTenantCode, A360BAS_TenantTenantCode});
                     A19BR_EncounterID = T000E14_A19BR_EncounterID[0];
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A19BR_EncounterID", StringUtil.LTrim( StringUtil.Str( (decimal)(A19BR_EncounterID), 18, 0)));
                     n19BR_EncounterID = T000E14_n19BR_EncounterID[0];
                     pr_default.close(10);
                     dsDefault.SmartCacheProvider.SetUpdated("BR_Encounter") ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( Insert) rules */
                        new zutil_recordlog(context ).execute(  StringUtil.Str( (decimal)(A19BR_EncounterID), 18, 0),  "就诊信息",  "Create",  1) ;
                        /* End of After( Insert) rules */
                        if ( AnyError == 0 )
                        {
                           /* Save values for previous() function. */
                           GX_msglist.addItem(context.GetMessage( "GXM_sucadded", ""), "SuccessfullyAdded", 0, "", true);
                           ResetCaption0E0( ) ;
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
               Load0E15( ) ;
            }
            EndLevel0E15( ) ;
         }
         CloseExtendedTableCursors0E15( ) ;
      }

      protected void Update0E15( )
      {
         BeforeValidate0E15( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0E15( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0E15( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0E15( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate0E15( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000E15 */
                     pr_default.execute(11, new Object[] {n35BR_Encounter_EncID, A35BR_Encounter_EncID, n172BR_Encounter_Status, A172BR_Encounter_Status, n183BR_Encounter_CrtUser, A183BR_Encounter_CrtUser, n512BR_Encounter_CrtDisplayName, A512BR_Encounter_CrtDisplayName, n182BR_Encounter_CrtDate, A182BR_Encounter_CrtDate, n470BR_Encounter_Department_Code, A470BR_Encounter_Department_Code, n471BR_Encounter_ENCType_Code, A471BR_Encounter_ENCType_Code, n472BR_Encounter_AdmitSource_Code, A472BR_Encounter_AdmitSource_Code, n473BR_Encounter_DischargeStatus_Code, A473BR_Encounter_DischargeStatus_Code, n84BR_Encounter_Department, A84BR_Encounter_Department, n570BR_Encounter_Departmentadm, A570BR_Encounter_Departmentadm, n571BR_Encounter_Departmentadm_Code, A571BR_Encounter_Departmentadm_Code, n572BR_Encounter_Departmentdisch, A572BR_Encounter_Departmentdisch, n573BR_Encounter_Departmentdisch_Code, A573BR_Encounter_Departmentdisch_Code, n90BR_Encounter_ENCType, A90BR_Encounter_ENCType, n91BR_Encounter_AdmitDate, A91BR_Encounter_AdmitDate, n92BR_Encounter_AdmitSource, A92BR_Encounter_AdmitSource, n93BR_Encounter_DischargeDate, A93BR_Encounter_DischargeDate, n94BR_Encounter_DischargeStatus, A94BR_Encounter_DischargeStatus, n574BR_Encounter_Insurance, A574BR_Encounter_Insurance, n575BR_Encounter_Insurance_Code, A575BR_Encounter_Insurance_Code, n187BR_Encounter_UpdDate, A187BR_Encounter_UpdDate, n186BR_Encounter_UpdUser, A186BR_Encounter_UpdUser, n333BR_Encounter_IsDLT, A333BR_Encounter_IsDLT, n184BR_Encounter_SubmitUser, A184BR_Encounter_SubmitUser, n335BR_Encounter_Reason, A335BR_Encounter_Reason, n185BR_Encounter_SubmitDate, A185BR_Encounter_SubmitDate, n188BR_Encounter_RecheckUser, A188BR_Encounter_RecheckUser, n336BR_Encounter_FReason, A336BR_Encounter_FReason, n189BR_Encounter_RecheckDate, A189BR_Encounter_RecheckDate, n190BR_Encounter_Approver, A190BR_Encounter_Approver, n191BR_Encounter_ApproveDate, A191BR_Encounter_ApproveDate, n192BR_Encounter_IsRandApprove, A192BR_Encounter_IsRandApprove, n203BR_Encounter_IsRandApprover, A203BR_Encounter_IsRandApprover, n204BR_Encounter_IsRandNoApprover, A204BR_Encounter_IsRandNoApprover, n205BR_Encounter_IsRandApproveDate, A205BR_Encounter_IsRandApproveDate, n206BR_Encounter_IsRandNoApproveDate, A206BR_Encounter_IsRandNoApproveDate, n193BR_Encounter_IsRandRecheck, A193BR_Encounter_IsRandRecheck, n207BR_Encounter_IsRandRecheckr, A207BR_Encounter_IsRandRecheckr, n208BR_Encounter_IsRandNoRecheckr, A208BR_Encounter_IsRandNoRecheckr, n209BR_Encounter_IsRandRecheckDate, A209BR_Encounter_IsRandRecheckDate, n210BR_Encounter_IsRandNoRecheckDate, A210BR_Encounter_IsRandNoRecheckDate, n202BR_Encounter_IsUpdate, A202BR_Encounter_IsUpdate, n537BR_Encounter_Datasource, A537BR_Encounter_Datasource, n560EncounterIDEncrypt, A560EncounterIDEncrypt, n85BR_Information_ID, A85BR_Information_ID, n360BAS_TenantTenantCode, A360BAS_TenantTenantCode, n19BR_EncounterID, A19BR_EncounterID});
                     pr_default.close(11);
                     dsDefault.SmartCacheProvider.SetUpdated("BR_Encounter") ;
                     if ( (pr_default.getStatus(11) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"BR_Encounter"}), "RecordIsLocked", 1, "");
                        AnyError = 1;
                     }
                     DeferredUpdate0E15( ) ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( update) rules */
                        /* End of After( update) rules */
                        if ( AnyError == 0 )
                        {
                           if ( ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 ) || ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 ) )
                           {
                              if ( AnyError == 0 )
                              {
                                 context.nUserReturn = 1;
                              }
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
            }
            EndLevel0E15( ) ;
         }
         CloseExtendedTableCursors0E15( ) ;
      }

      protected void DeferredUpdate0E15( )
      {
      }

      protected void delete( )
      {
         BeforeValidate0E15( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0E15( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls0E15( ) ;
            AfterConfirm0E15( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete0E15( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor T000E16 */
                  pr_default.execute(12, new Object[] {n19BR_EncounterID, A19BR_EncounterID});
                  pr_default.close(12);
                  dsDefault.SmartCacheProvider.SetUpdated("BR_Encounter") ;
                  if ( AnyError == 0 )
                  {
                     /* Start of After( delete) rules */
                     /* End of After( delete) rules */
                     if ( AnyError == 0 )
                     {
                        if ( ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 ) || ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 ) )
                        {
                           if ( AnyError == 0 )
                           {
                              context.nUserReturn = 1;
                           }
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
         }
         sMode15 = Gx_mode;
         Gx_mode = "DLT";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         EndLevel0E15( ) ;
         Gx_mode = sMode15;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
      }

      protected void OnDeleteControls0E15( )
      {
         standaloneModal( ) ;
         if ( AnyError == 0 )
         {
            /* Delete mode formulas */
            AV32Pgmname = "BR_Encounter";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV32Pgmname", AV32Pgmname);
            AV31Pgmdesc = "就诊信息";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV31Pgmdesc", AV31Pgmdesc);
            edtavVdepartment_Visible = ((StringUtil.StrCmp(A84BR_Encounter_Department, "其它")==0) ? 1 : 0);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavVdepartment_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavVdepartment_Visible), 5, 0)), true);
            if ( ! ( ( StringUtil.StrCmp(A84BR_Encounter_Department, "其它") == 0 ) ) )
            {
               cellVdepartment_cell_Class = "Invisible";
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, cellVdepartment_cell_Internalname, "Class", cellVdepartment_cell_Class, true);
            }
            else
            {
               if ( StringUtil.StrCmp(A84BR_Encounter_Department, "其它") == 0 )
               {
                  cellVdepartment_cell_Class = "RequiredDataContentCell";
                  context.httpAjaxContext.ajax_rsp_assign_prop("", false, cellVdepartment_cell_Internalname, "Class", cellVdepartment_cell_Class, true);
               }
            }
            edtavVenctype_Visible = ((StringUtil.StrCmp(A90BR_Encounter_ENCType, "其它")==0) ? 1 : 0);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavVenctype_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavVenctype_Visible), 5, 0)), true);
            if ( ! ( ( StringUtil.StrCmp(A90BR_Encounter_ENCType, "其它") == 0 ) ) )
            {
               cellVenctype_cell_Class = "Invisible";
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, cellVenctype_cell_Internalname, "Class", cellVenctype_cell_Class, true);
            }
            else
            {
               if ( StringUtil.StrCmp(A90BR_Encounter_ENCType, "其它") == 0 )
               {
                  cellVenctype_cell_Class = "RequiredDataContentCell";
                  context.httpAjaxContext.ajax_rsp_assign_prop("", false, cellVenctype_cell_Internalname, "Class", cellVenctype_cell_Class, true);
               }
            }
            edtavVreason_Visible = ((StringUtil.StrCmp(A92BR_Encounter_AdmitSource, "其它")==0) ? 1 : 0);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavVreason_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavVreason_Visible), 5, 0)), true);
            if ( ! ( ( StringUtil.StrCmp(A92BR_Encounter_AdmitSource, "其它") == 0 ) ) )
            {
               cellVreason_cell_Class = "Invisible";
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, cellVreason_cell_Internalname, "Class", cellVreason_cell_Class, true);
            }
            else
            {
               if ( StringUtil.StrCmp(A92BR_Encounter_AdmitSource, "其它") == 0 )
               {
                  cellVreason_cell_Class = "RequiredDataContentCell";
                  context.httpAjaxContext.ajax_rsp_assign_prop("", false, cellVreason_cell_Internalname, "Class", cellVreason_cell_Class, true);
               }
            }
            /* Using cursor T000E17 */
            pr_default.execute(13, new Object[] {n85BR_Information_ID, A85BR_Information_ID});
            A36BR_Information_PatientNo = T000E17_A36BR_Information_PatientNo[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A36BR_Information_PatientNo", A36BR_Information_PatientNo);
            n36BR_Information_PatientNo = T000E17_n36BR_Information_PatientNo[0];
            pr_default.close(13);
         }
         if ( AnyError == 0 )
         {
            /* Using cursor T000E18 */
            pr_default.execute(14, new Object[] {n19BR_EncounterID, A19BR_EncounterID});
            if ( (pr_default.getStatus(14) != 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_del", new   object[]  {" T42"}), "CannotDeleteReferencedRecord", 1, "");
               AnyError = 1;
            }
            pr_default.close(14);
            /* Using cursor T000E19 */
            pr_default.execute(15, new Object[] {n19BR_EncounterID, A19BR_EncounterID});
            if ( (pr_default.getStatus(15) != 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_del", new   object[]  {" T41"}), "CannotDeleteReferencedRecord", 1, "");
               AnyError = 1;
            }
            pr_default.close(15);
            /* Using cursor T000E20 */
            pr_default.execute(16, new Object[] {n19BR_EncounterID, A19BR_EncounterID});
            if ( (pr_default.getStatus(16) != 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_del", new   object[]  {" T39"}), "CannotDeleteReferencedRecord", 1, "");
               AnyError = 1;
            }
            pr_default.close(16);
            /* Using cursor T000E21 */
            pr_default.execute(17, new Object[] {n19BR_EncounterID, A19BR_EncounterID});
            if ( (pr_default.getStatus(17) != 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_del", new   object[]  {" T36"}), "CannotDeleteReferencedRecord", 1, "");
               AnyError = 1;
            }
            pr_default.close(17);
            /* Using cursor T000E22 */
            pr_default.execute(18, new Object[] {n19BR_EncounterID, A19BR_EncounterID});
            if ( (pr_default.getStatus(18) != 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_del", new   object[]  {" T30"}), "CannotDeleteReferencedRecord", 1, "");
               AnyError = 1;
            }
            pr_default.close(18);
            /* Using cursor T000E23 */
            pr_default.execute(19, new Object[] {n19BR_EncounterID, A19BR_EncounterID});
            if ( (pr_default.getStatus(19) != 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_del", new   object[]  {" T20"}), "CannotDeleteReferencedRecord", 1, "");
               AnyError = 1;
            }
            pr_default.close(19);
            /* Using cursor T000E24 */
            pr_default.execute(20, new Object[] {n19BR_EncounterID, A19BR_EncounterID});
            if ( (pr_default.getStatus(20) != 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_del", new   object[]  {" T19"}), "CannotDeleteReferencedRecord", 1, "");
               AnyError = 1;
            }
            pr_default.close(20);
            /* Using cursor T000E25 */
            pr_default.execute(21, new Object[] {n19BR_EncounterID, A19BR_EncounterID});
            if ( (pr_default.getStatus(21) != 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_del", new   object[]  {" T18"}), "CannotDeleteReferencedRecord", 1, "");
               AnyError = 1;
            }
            pr_default.close(21);
            /* Using cursor T000E26 */
            pr_default.execute(22, new Object[] {n19BR_EncounterID, A19BR_EncounterID});
            if ( (pr_default.getStatus(22) != 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_del", new   object[]  {" T17"}), "CannotDeleteReferencedRecord", 1, "");
               AnyError = 1;
            }
            pr_default.close(22);
            /* Using cursor T000E27 */
            pr_default.execute(23, new Object[] {n19BR_EncounterID, A19BR_EncounterID});
            if ( (pr_default.getStatus(23) != 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_del", new   object[]  {" T13"}), "CannotDeleteReferencedRecord", 1, "");
               AnyError = 1;
            }
            pr_default.close(23);
            /* Using cursor T000E28 */
            pr_default.execute(24, new Object[] {n19BR_EncounterID, A19BR_EncounterID});
            if ( (pr_default.getStatus(24) != 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_del", new   object[]  {" T12"}), "CannotDeleteReferencedRecord", 1, "");
               AnyError = 1;
            }
            pr_default.close(24);
            /* Using cursor T000E29 */
            pr_default.execute(25, new Object[] {n19BR_EncounterID, A19BR_EncounterID});
            if ( (pr_default.getStatus(25) != 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_del", new   object[]  {" T11"}), "CannotDeleteReferencedRecord", 1, "");
               AnyError = 1;
            }
            pr_default.close(25);
            /* Using cursor T000E30 */
            pr_default.execute(26, new Object[] {n19BR_EncounterID, A19BR_EncounterID});
            if ( (pr_default.getStatus(26) != 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_del", new   object[]  {" T10"}), "CannotDeleteReferencedRecord", 1, "");
               AnyError = 1;
            }
            pr_default.close(26);
            /* Using cursor T000E31 */
            pr_default.execute(27, new Object[] {n19BR_EncounterID, A19BR_EncounterID});
            if ( (pr_default.getStatus(27) != 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_del", new   object[]  {" T9"}), "CannotDeleteReferencedRecord", 1, "");
               AnyError = 1;
            }
            pr_default.close(27);
         }
      }

      protected void EndLevel0E15( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            pr_default.close(0);
         }
         if ( AnyError == 0 )
         {
            BeforeComplete0E15( ) ;
         }
         if ( AnyError == 0 )
         {
            pr_default.close(1);
            pr_default.close(13);
            context.CommitDataStores("br_encounter",pr_default);
            if ( AnyError == 0 )
            {
               ConfirmValues0E0( ) ;
            }
            /* After transaction rules */
            /* Execute 'After Trn' event if defined. */
            trnEnded = 1;
         }
         else
         {
            pr_default.close(1);
            pr_default.close(13);
            context.RollbackDataStores("br_encounter",pr_default);
         }
         IsModified = 0;
         if ( AnyError != 0 )
         {
            context.wjLoc = "";
            context.nUserReturn = 0;
         }
      }

      public void ScanStart0E15( )
      {
         /* Scan By routine */
         /* Using cursor T000E32 */
         pr_default.execute(28);
         RcdFound15 = 0;
         if ( (pr_default.getStatus(28) != 101) )
         {
            RcdFound15 = 1;
            A19BR_EncounterID = T000E32_A19BR_EncounterID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A19BR_EncounterID", StringUtil.LTrim( StringUtil.Str( (decimal)(A19BR_EncounterID), 18, 0)));
            n19BR_EncounterID = T000E32_n19BR_EncounterID[0];
         }
         /* Load Subordinate Levels */
      }

      protected void ScanNext0E15( )
      {
         /* Scan next routine */
         pr_default.readNext(28);
         RcdFound15 = 0;
         if ( (pr_default.getStatus(28) != 101) )
         {
            RcdFound15 = 1;
            A19BR_EncounterID = T000E32_A19BR_EncounterID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A19BR_EncounterID", StringUtil.LTrim( StringUtil.Str( (decimal)(A19BR_EncounterID), 18, 0)));
            n19BR_EncounterID = T000E32_n19BR_EncounterID[0];
         }
      }

      protected void ScanEnd0E15( )
      {
         pr_default.close(28);
      }

      protected void AfterConfirm0E15( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert0E15( )
      {
         /* Before Insert Rules */
         GXt_char1 = A360BAS_TenantTenantCode;
         new zbr_getcurrenttcode(context ).execute( out  GXt_char1) ;
         A360BAS_TenantTenantCode = GXt_char1;
         n360BAS_TenantTenantCode = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A360BAS_TenantTenantCode", A360BAS_TenantTenantCode);
         A172BR_Encounter_Status = 1;
         n172BR_Encounter_Status = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A172BR_Encounter_Status", StringUtil.LTrim( StringUtil.Str( (decimal)(A172BR_Encounter_Status), 4, 0)));
         A182BR_Encounter_CrtDate = DateTimeUtil.ServerNow( context, pr_default);
         n182BR_Encounter_CrtDate = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A182BR_Encounter_CrtDate", context.localUtil.TToC( A182BR_Encounter_CrtDate, 10, 8, 0, 0, "/", ":", " "));
         A183BR_Encounter_CrtUser = StringUtil.Trim( AV14WWPContext.gxTpr_Userguid);
         n183BR_Encounter_CrtUser = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A183BR_Encounter_CrtUser", A183BR_Encounter_CrtUser);
         A512BR_Encounter_CrtDisplayName = StringUtil.Trim( AV14WWPContext.gxTpr_Userdisplayname);
         n512BR_Encounter_CrtDisplayName = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A512BR_Encounter_CrtDisplayName", A512BR_Encounter_CrtDisplayName);
         GXt_int3 = A35BR_Encounter_EncID;
         new zutil_findcountbypatientno(context ).execute(  A85BR_Information_ID, out  GXt_int3) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A85BR_Information_ID", StringUtil.LTrim( StringUtil.Str( (decimal)(A85BR_Information_ID), 18, 0)));
         A35BR_Encounter_EncID = GXt_int3;
         n35BR_Encounter_EncID = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A35BR_Encounter_EncID", StringUtil.LTrim( StringUtil.Str( (decimal)(A35BR_Encounter_EncID), 10, 0)));
         GXt_char1 = A473BR_Encounter_DischargeStatus_Code;
         new zutil_findtargetcode(context ).execute(  6,  A94BR_Encounter_DischargeStatus, out  GXt_char1) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A94BR_Encounter_DischargeStatus", A94BR_Encounter_DischargeStatus);
         A473BR_Encounter_DischargeStatus_Code = GXt_char1;
         n473BR_Encounter_DischargeStatus_Code = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A473BR_Encounter_DischargeStatus_Code", A473BR_Encounter_DischargeStatus_Code);
         if ( StringUtil.StrCmp(A92BR_Encounter_AdmitSource, "其它") == 0 )
         {
            A92BR_Encounter_AdmitSource = AV27vReason;
            n92BR_Encounter_AdmitSource = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A92BR_Encounter_AdmitSource", A92BR_Encounter_AdmitSource);
         }
         GXt_char1 = A472BR_Encounter_AdmitSource_Code;
         new zutil_findtargetcode(context ).execute(  5,  A92BR_Encounter_AdmitSource, out  GXt_char1) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A92BR_Encounter_AdmitSource", A92BR_Encounter_AdmitSource);
         A472BR_Encounter_AdmitSource_Code = GXt_char1;
         n472BR_Encounter_AdmitSource_Code = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A472BR_Encounter_AdmitSource_Code", A472BR_Encounter_AdmitSource_Code);
         if ( StringUtil.StrCmp(A90BR_Encounter_ENCType, "其它") == 0 )
         {
            A90BR_Encounter_ENCType = AV26vENCType;
            n90BR_Encounter_ENCType = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A90BR_Encounter_ENCType", A90BR_Encounter_ENCType);
         }
         GXt_char1 = A471BR_Encounter_ENCType_Code;
         new zutil_findtargetcode(context ).execute(  4,  A90BR_Encounter_ENCType, out  GXt_char1) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A90BR_Encounter_ENCType", A90BR_Encounter_ENCType);
         A471BR_Encounter_ENCType_Code = GXt_char1;
         n471BR_Encounter_ENCType_Code = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A471BR_Encounter_ENCType_Code", A471BR_Encounter_ENCType_Code);
         if ( StringUtil.StrCmp(A84BR_Encounter_Department, "其它") == 0 )
         {
            A84BR_Encounter_Department = AV24vDepartment;
            n84BR_Encounter_Department = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A84BR_Encounter_Department", A84BR_Encounter_Department);
         }
         GXt_char1 = A470BR_Encounter_Department_Code;
         new zutil_findtargetcode(context ).execute(  3,  A84BR_Encounter_Department, out  GXt_char1) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A84BR_Encounter_Department", A84BR_Encounter_Department);
         A470BR_Encounter_Department_Code = GXt_char1;
         n470BR_Encounter_Department_Code = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A470BR_Encounter_Department_Code", A470BR_Encounter_Department_Code);
      }

      protected void BeforeUpdate0E15( )
      {
         /* Before Update Rules */
         GXt_char1 = A470BR_Encounter_Department_Code;
         new zutil_findtargetcode(context ).execute(  3,  A84BR_Encounter_Department, out  GXt_char1) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A84BR_Encounter_Department", A84BR_Encounter_Department);
         A470BR_Encounter_Department_Code = GXt_char1;
         n470BR_Encounter_Department_Code = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A470BR_Encounter_Department_Code", A470BR_Encounter_Department_Code);
         GXt_char1 = A471BR_Encounter_ENCType_Code;
         new zutil_findtargetcode(context ).execute(  4,  A90BR_Encounter_ENCType, out  GXt_char1) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A90BR_Encounter_ENCType", A90BR_Encounter_ENCType);
         A471BR_Encounter_ENCType_Code = GXt_char1;
         n471BR_Encounter_ENCType_Code = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A471BR_Encounter_ENCType_Code", A471BR_Encounter_ENCType_Code);
         GXt_char1 = A472BR_Encounter_AdmitSource_Code;
         new zutil_findtargetcode(context ).execute(  5,  A92BR_Encounter_AdmitSource, out  GXt_char1) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A92BR_Encounter_AdmitSource", A92BR_Encounter_AdmitSource);
         A472BR_Encounter_AdmitSource_Code = GXt_char1;
         n472BR_Encounter_AdmitSource_Code = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A472BR_Encounter_AdmitSource_Code", A472BR_Encounter_AdmitSource_Code);
         GXt_char1 = A473BR_Encounter_DischargeStatus_Code;
         new zutil_findtargetcode(context ).execute(  6,  A94BR_Encounter_DischargeStatus, out  GXt_char1) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A94BR_Encounter_DischargeStatus", A94BR_Encounter_DischargeStatus);
         A473BR_Encounter_DischargeStatus_Code = GXt_char1;
         n473BR_Encounter_DischargeStatus_Code = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A473BR_Encounter_DischargeStatus_Code", A473BR_Encounter_DischargeStatus_Code);
      }

      protected void BeforeDelete0E15( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete0E15( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate0E15( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes0E15( )
      {
         edtBR_Information_ID_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Information_ID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBR_Information_ID_Enabled), 5, 0)), true);
         edtBR_Information_PatientNo_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Information_PatientNo_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBR_Information_PatientNo_Enabled), 5, 0)), true);
         dynBR_Encounter_Department.Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynBR_Encounter_Department_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(dynBR_Encounter_Department.Enabled), 5, 0)), true);
         edtavVdepartment_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavVdepartment_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavVdepartment_Enabled), 5, 0)), true);
         dynBR_Encounter_ENCType.Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynBR_Encounter_ENCType_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(dynBR_Encounter_ENCType.Enabled), 5, 0)), true);
         edtavVenctype_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavVenctype_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavVenctype_Enabled), 5, 0)), true);
         edtBR_Encounter_AdmitDate_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Encounter_AdmitDate_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBR_Encounter_AdmitDate_Enabled), 5, 0)), true);
         dynBR_Encounter_AdmitSource.Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynBR_Encounter_AdmitSource_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(dynBR_Encounter_AdmitSource.Enabled), 5, 0)), true);
         edtavVreason_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavVreason_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavVreason_Enabled), 5, 0)), true);
         edtBR_Encounter_DischargeDate_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Encounter_DischargeDate_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBR_Encounter_DischargeDate_Enabled), 5, 0)), true);
         dynBR_Encounter_DischargeStatus.Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynBR_Encounter_DischargeStatus_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(dynBR_Encounter_DischargeStatus.Enabled), 5, 0)), true);
         edtBR_EncounterID_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_EncounterID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBR_EncounterID_Enabled), 5, 0)), true);
         edtBR_Encounter_EncID_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Encounter_EncID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBR_Encounter_EncID_Enabled), 5, 0)), true);
         cmbBR_Encounter_Status.Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbBR_Encounter_Status_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(cmbBR_Encounter_Status.Enabled), 5, 0)), true);
         edtBR_Encounter_CrtDate_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Encounter_CrtDate_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBR_Encounter_CrtDate_Enabled), 5, 0)), true);
         edtBR_Encounter_UpdDate_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Encounter_UpdDate_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBR_Encounter_UpdDate_Enabled), 5, 0)), true);
         edtBR_Encounter_CrtUser_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Encounter_CrtUser_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBR_Encounter_CrtUser_Enabled), 5, 0)), true);
         edtBR_Encounter_UpdUser_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Encounter_UpdUser_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBR_Encounter_UpdUser_Enabled), 5, 0)), true);
      }

      protected void send_integrity_lvl_hashes0E15( )
      {
      }

      protected void assign_properties_default( )
      {
      }

      protected void ConfirmValues0E0( )
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
         context.AddJavascriptSource("gxcfg.js", "?20202279363280", false);
         if ( context.isSpaRequest( ) )
         {
            enableOutput();
         }
         context.AddJavascriptSource("calendar.js", "?"+context.GetBuildNumber( 127771), false);
         context.AddJavascriptSource("calendar-setup.js", "?"+context.GetBuildNumber( 127771), false);
         context.AddJavascriptSource("calendar-zh.js", "?"+context.GetBuildNumber( 127771), false);
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" autocomplete=\"off\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("br_encounter.aspx") + "?" + UrlEncode(StringUtil.RTrim(Gx_mode)) + "," + UrlEncode("" +AV7BR_EncounterID)+"\">") ;
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
         forbiddenHiddens = "hsh" + "BR_Encounter";
         forbiddenHiddens = forbiddenHiddens + context.localUtil.Format( (decimal)(A19BR_EncounterID), "ZZZZZZZZZZZZZZZZZZ");
         forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( AV30tCurrentCode, ""));
         forbiddenHiddens = forbiddenHiddens + context.localUtil.Format( (decimal)(AV8Insert_BR_Information_ID), "ZZZZZZZZZZZZZZZZZZ");
         forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( AV29Insert_BAS_TenantTenantCode, ""));
         forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!"));
         forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( A570BR_Encounter_Departmentadm, ""));
         forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( A571BR_Encounter_Departmentadm_Code, ""));
         forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( A572BR_Encounter_Departmentdisch, ""));
         forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( A573BR_Encounter_Departmentdisch_Code, ""));
         forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( A574BR_Encounter_Insurance, ""));
         forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( A575BR_Encounter_Insurance_Code, ""));
         forbiddenHiddens = forbiddenHiddens + StringUtil.BoolToStr( A333BR_Encounter_IsDLT);
         forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( A184BR_Encounter_SubmitUser, ""));
         forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( A335BR_Encounter_Reason, ""));
         forbiddenHiddens = forbiddenHiddens + context.localUtil.Format( A185BR_Encounter_SubmitDate, "9999/99/99 99:99:99");
         forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( A188BR_Encounter_RecheckUser, ""));
         forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( A336BR_Encounter_FReason, ""));
         forbiddenHiddens = forbiddenHiddens + context.localUtil.Format( A189BR_Encounter_RecheckDate, "9999/99/99 99:99:99");
         forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( A190BR_Encounter_Approver, ""));
         forbiddenHiddens = forbiddenHiddens + context.localUtil.Format( A191BR_Encounter_ApproveDate, "9999/99/99 99:99:99");
         forbiddenHiddens = forbiddenHiddens + StringUtil.BoolToStr( A192BR_Encounter_IsRandApprove);
         forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( A203BR_Encounter_IsRandApprover, ""));
         forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( A204BR_Encounter_IsRandNoApprover, ""));
         forbiddenHiddens = forbiddenHiddens + context.localUtil.Format( A205BR_Encounter_IsRandApproveDate, "9999/99/99 99:99:99");
         forbiddenHiddens = forbiddenHiddens + context.localUtil.Format( A206BR_Encounter_IsRandNoApproveDate, "9999/99/99 99:99:99");
         forbiddenHiddens = forbiddenHiddens + StringUtil.BoolToStr( A193BR_Encounter_IsRandRecheck);
         forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( A207BR_Encounter_IsRandRecheckr, ""));
         forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( A208BR_Encounter_IsRandNoRecheckr, ""));
         forbiddenHiddens = forbiddenHiddens + context.localUtil.Format( A209BR_Encounter_IsRandRecheckDate, "9999/99/99 99:99:99");
         forbiddenHiddens = forbiddenHiddens + context.localUtil.Format( A210BR_Encounter_IsRandNoRecheckDate, "9999/99/99 99:99:99");
         forbiddenHiddens = forbiddenHiddens + StringUtil.BoolToStr( A202BR_Encounter_IsUpdate);
         forbiddenHiddens = forbiddenHiddens + context.localUtil.Format( (decimal)(A537BR_Encounter_Datasource), "ZZZ9");
         forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( A560EncounterIDEncrypt, ""));
         GxWebStd.gx_hidden_field( context, "hsh", GetEncryptedHash( forbiddenHiddens, GXKey));
         GXUtil.WriteLog("br_encounter:[SendSecurityCheck value for]"+"BR_EncounterID:"+context.localUtil.Format( (decimal)(A19BR_EncounterID), "ZZZZZZZZZZZZZZZZZZ"));
         GXUtil.WriteLog("br_encounter:[SendSecurityCheck value for]"+"tCurrentCode:"+StringUtil.RTrim( context.localUtil.Format( AV30tCurrentCode, "")));
         GXUtil.WriteLog("br_encounter:[SendSecurityCheck value for]"+"Insert_BR_Information_ID:"+context.localUtil.Format( (decimal)(AV8Insert_BR_Information_ID), "ZZZZZZZZZZZZZZZZZZ"));
         GXUtil.WriteLog("br_encounter:[SendSecurityCheck value for]"+"Insert_BAS_TenantTenantCode:"+StringUtil.RTrim( context.localUtil.Format( AV29Insert_BAS_TenantTenantCode, "")));
         GXUtil.WriteLog("br_encounter:[SendSecurityCheck value for]"+"Gx_mode:"+StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")));
         GXUtil.WriteLog("br_encounter:[SendSecurityCheck value for]"+"BR_Encounter_Departmentadm:"+StringUtil.RTrim( context.localUtil.Format( A570BR_Encounter_Departmentadm, "")));
         GXUtil.WriteLog("br_encounter:[SendSecurityCheck value for]"+"BR_Encounter_Departmentadm_Code:"+StringUtil.RTrim( context.localUtil.Format( A571BR_Encounter_Departmentadm_Code, "")));
         GXUtil.WriteLog("br_encounter:[SendSecurityCheck value for]"+"BR_Encounter_Departmentdisch:"+StringUtil.RTrim( context.localUtil.Format( A572BR_Encounter_Departmentdisch, "")));
         GXUtil.WriteLog("br_encounter:[SendSecurityCheck value for]"+"BR_Encounter_Departmentdisch_Code:"+StringUtil.RTrim( context.localUtil.Format( A573BR_Encounter_Departmentdisch_Code, "")));
         GXUtil.WriteLog("br_encounter:[SendSecurityCheck value for]"+"BR_Encounter_Insurance:"+StringUtil.RTrim( context.localUtil.Format( A574BR_Encounter_Insurance, "")));
         GXUtil.WriteLog("br_encounter:[SendSecurityCheck value for]"+"BR_Encounter_Insurance_Code:"+StringUtil.RTrim( context.localUtil.Format( A575BR_Encounter_Insurance_Code, "")));
         GXUtil.WriteLog("br_encounter:[SendSecurityCheck value for]"+"BR_Encounter_IsDLT:"+StringUtil.BoolToStr( A333BR_Encounter_IsDLT));
         GXUtil.WriteLog("br_encounter:[SendSecurityCheck value for]"+"BR_Encounter_SubmitUser:"+StringUtil.RTrim( context.localUtil.Format( A184BR_Encounter_SubmitUser, "")));
         GXUtil.WriteLog("br_encounter:[SendSecurityCheck value for]"+"BR_Encounter_Reason:"+StringUtil.RTrim( context.localUtil.Format( A335BR_Encounter_Reason, "")));
         GXUtil.WriteLog("br_encounter:[SendSecurityCheck value for]"+"BR_Encounter_SubmitDate:"+context.localUtil.Format( A185BR_Encounter_SubmitDate, "9999/99/99 99:99:99"));
         GXUtil.WriteLog("br_encounter:[SendSecurityCheck value for]"+"BR_Encounter_RecheckUser:"+StringUtil.RTrim( context.localUtil.Format( A188BR_Encounter_RecheckUser, "")));
         GXUtil.WriteLog("br_encounter:[SendSecurityCheck value for]"+"BR_Encounter_FReason:"+StringUtil.RTrim( context.localUtil.Format( A336BR_Encounter_FReason, "")));
         GXUtil.WriteLog("br_encounter:[SendSecurityCheck value for]"+"BR_Encounter_RecheckDate:"+context.localUtil.Format( A189BR_Encounter_RecheckDate, "9999/99/99 99:99:99"));
         GXUtil.WriteLog("br_encounter:[SendSecurityCheck value for]"+"BR_Encounter_Approver:"+StringUtil.RTrim( context.localUtil.Format( A190BR_Encounter_Approver, "")));
         GXUtil.WriteLog("br_encounter:[SendSecurityCheck value for]"+"BR_Encounter_ApproveDate:"+context.localUtil.Format( A191BR_Encounter_ApproveDate, "9999/99/99 99:99:99"));
         GXUtil.WriteLog("br_encounter:[SendSecurityCheck value for]"+"BR_Encounter_IsRandApprove:"+StringUtil.BoolToStr( A192BR_Encounter_IsRandApprove));
         GXUtil.WriteLog("br_encounter:[SendSecurityCheck value for]"+"BR_Encounter_IsRandApprover:"+StringUtil.RTrim( context.localUtil.Format( A203BR_Encounter_IsRandApprover, "")));
         GXUtil.WriteLog("br_encounter:[SendSecurityCheck value for]"+"BR_Encounter_IsRandNoApprover:"+StringUtil.RTrim( context.localUtil.Format( A204BR_Encounter_IsRandNoApprover, "")));
         GXUtil.WriteLog("br_encounter:[SendSecurityCheck value for]"+"BR_Encounter_IsRandApproveDate:"+context.localUtil.Format( A205BR_Encounter_IsRandApproveDate, "9999/99/99 99:99:99"));
         GXUtil.WriteLog("br_encounter:[SendSecurityCheck value for]"+"BR_Encounter_IsRandNoApproveDate:"+context.localUtil.Format( A206BR_Encounter_IsRandNoApproveDate, "9999/99/99 99:99:99"));
         GXUtil.WriteLog("br_encounter:[SendSecurityCheck value for]"+"BR_Encounter_IsRandRecheck:"+StringUtil.BoolToStr( A193BR_Encounter_IsRandRecheck));
         GXUtil.WriteLog("br_encounter:[SendSecurityCheck value for]"+"BR_Encounter_IsRandRecheckr:"+StringUtil.RTrim( context.localUtil.Format( A207BR_Encounter_IsRandRecheckr, "")));
         GXUtil.WriteLog("br_encounter:[SendSecurityCheck value for]"+"BR_Encounter_IsRandNoRecheckr:"+StringUtil.RTrim( context.localUtil.Format( A208BR_Encounter_IsRandNoRecheckr, "")));
         GXUtil.WriteLog("br_encounter:[SendSecurityCheck value for]"+"BR_Encounter_IsRandRecheckDate:"+context.localUtil.Format( A209BR_Encounter_IsRandRecheckDate, "9999/99/99 99:99:99"));
         GXUtil.WriteLog("br_encounter:[SendSecurityCheck value for]"+"BR_Encounter_IsRandNoRecheckDate:"+context.localUtil.Format( A210BR_Encounter_IsRandNoRecheckDate, "9999/99/99 99:99:99"));
         GXUtil.WriteLog("br_encounter:[SendSecurityCheck value for]"+"BR_Encounter_IsUpdate:"+StringUtil.BoolToStr( A202BR_Encounter_IsUpdate));
         GXUtil.WriteLog("br_encounter:[SendSecurityCheck value for]"+"BR_Encounter_Datasource:"+context.localUtil.Format( (decimal)(A537BR_Encounter_Datasource), "ZZZ9"));
         GXUtil.WriteLog("br_encounter:[SendSecurityCheck value for]"+"EncounterIDEncrypt:"+StringUtil.RTrim( context.localUtil.Format( A560EncounterIDEncrypt, "")));
      }

      protected void SendCloseFormHiddens( )
      {
         /* Send hidden variables. */
         /* Send saved values. */
         send_integrity_footer_hashes( ) ;
         GxWebStd.gx_hidden_field( context, "Z19BR_EncounterID", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z19BR_EncounterID), 18, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "Z35BR_Encounter_EncID", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z35BR_Encounter_EncID), 10, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "Z172BR_Encounter_Status", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z172BR_Encounter_Status), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "Z183BR_Encounter_CrtUser", Z183BR_Encounter_CrtUser);
         GxWebStd.gx_hidden_field( context, "Z512BR_Encounter_CrtDisplayName", Z512BR_Encounter_CrtDisplayName);
         GxWebStd.gx_hidden_field( context, "Z182BR_Encounter_CrtDate", context.localUtil.TToC( Z182BR_Encounter_CrtDate, 10, 8, 0, 0, "/", ":", " "));
         GxWebStd.gx_hidden_field( context, "Z470BR_Encounter_Department_Code", Z470BR_Encounter_Department_Code);
         GxWebStd.gx_hidden_field( context, "Z471BR_Encounter_ENCType_Code", Z471BR_Encounter_ENCType_Code);
         GxWebStd.gx_hidden_field( context, "Z472BR_Encounter_AdmitSource_Code", Z472BR_Encounter_AdmitSource_Code);
         GxWebStd.gx_hidden_field( context, "Z473BR_Encounter_DischargeStatus_Code", Z473BR_Encounter_DischargeStatus_Code);
         GxWebStd.gx_hidden_field( context, "Z84BR_Encounter_Department", Z84BR_Encounter_Department);
         GxWebStd.gx_hidden_field( context, "Z570BR_Encounter_Departmentadm", Z570BR_Encounter_Departmentadm);
         GxWebStd.gx_hidden_field( context, "Z571BR_Encounter_Departmentadm_Code", Z571BR_Encounter_Departmentadm_Code);
         GxWebStd.gx_hidden_field( context, "Z572BR_Encounter_Departmentdisch", Z572BR_Encounter_Departmentdisch);
         GxWebStd.gx_hidden_field( context, "Z573BR_Encounter_Departmentdisch_Code", Z573BR_Encounter_Departmentdisch_Code);
         GxWebStd.gx_hidden_field( context, "Z90BR_Encounter_ENCType", Z90BR_Encounter_ENCType);
         GxWebStd.gx_hidden_field( context, "Z91BR_Encounter_AdmitDate", context.localUtil.DToC( Z91BR_Encounter_AdmitDate, 0, "/"));
         GxWebStd.gx_hidden_field( context, "Z92BR_Encounter_AdmitSource", Z92BR_Encounter_AdmitSource);
         GxWebStd.gx_hidden_field( context, "Z93BR_Encounter_DischargeDate", context.localUtil.DToC( Z93BR_Encounter_DischargeDate, 0, "/"));
         GxWebStd.gx_hidden_field( context, "Z94BR_Encounter_DischargeStatus", Z94BR_Encounter_DischargeStatus);
         GxWebStd.gx_hidden_field( context, "Z574BR_Encounter_Insurance", Z574BR_Encounter_Insurance);
         GxWebStd.gx_hidden_field( context, "Z575BR_Encounter_Insurance_Code", Z575BR_Encounter_Insurance_Code);
         GxWebStd.gx_hidden_field( context, "Z187BR_Encounter_UpdDate", context.localUtil.TToC( Z187BR_Encounter_UpdDate, 10, 8, 0, 0, "/", ":", " "));
         GxWebStd.gx_hidden_field( context, "Z186BR_Encounter_UpdUser", Z186BR_Encounter_UpdUser);
         GxWebStd.gx_boolean_hidden_field( context, "Z333BR_Encounter_IsDLT", Z333BR_Encounter_IsDLT);
         GxWebStd.gx_hidden_field( context, "Z184BR_Encounter_SubmitUser", Z184BR_Encounter_SubmitUser);
         GxWebStd.gx_hidden_field( context, "Z335BR_Encounter_Reason", Z335BR_Encounter_Reason);
         GxWebStd.gx_hidden_field( context, "Z185BR_Encounter_SubmitDate", context.localUtil.TToC( Z185BR_Encounter_SubmitDate, 10, 8, 0, 0, "/", ":", " "));
         GxWebStd.gx_hidden_field( context, "Z188BR_Encounter_RecheckUser", Z188BR_Encounter_RecheckUser);
         GxWebStd.gx_hidden_field( context, "Z336BR_Encounter_FReason", Z336BR_Encounter_FReason);
         GxWebStd.gx_hidden_field( context, "Z189BR_Encounter_RecheckDate", context.localUtil.TToC( Z189BR_Encounter_RecheckDate, 10, 8, 0, 0, "/", ":", " "));
         GxWebStd.gx_hidden_field( context, "Z190BR_Encounter_Approver", Z190BR_Encounter_Approver);
         GxWebStd.gx_hidden_field( context, "Z191BR_Encounter_ApproveDate", context.localUtil.TToC( Z191BR_Encounter_ApproveDate, 10, 8, 0, 0, "/", ":", " "));
         GxWebStd.gx_boolean_hidden_field( context, "Z192BR_Encounter_IsRandApprove", Z192BR_Encounter_IsRandApprove);
         GxWebStd.gx_hidden_field( context, "Z203BR_Encounter_IsRandApprover", Z203BR_Encounter_IsRandApprover);
         GxWebStd.gx_hidden_field( context, "Z204BR_Encounter_IsRandNoApprover", Z204BR_Encounter_IsRandNoApprover);
         GxWebStd.gx_hidden_field( context, "Z205BR_Encounter_IsRandApproveDate", context.localUtil.TToC( Z205BR_Encounter_IsRandApproveDate, 10, 8, 0, 0, "/", ":", " "));
         GxWebStd.gx_hidden_field( context, "Z206BR_Encounter_IsRandNoApproveDate", context.localUtil.TToC( Z206BR_Encounter_IsRandNoApproveDate, 10, 8, 0, 0, "/", ":", " "));
         GxWebStd.gx_boolean_hidden_field( context, "Z193BR_Encounter_IsRandRecheck", Z193BR_Encounter_IsRandRecheck);
         GxWebStd.gx_hidden_field( context, "Z207BR_Encounter_IsRandRecheckr", Z207BR_Encounter_IsRandRecheckr);
         GxWebStd.gx_hidden_field( context, "Z208BR_Encounter_IsRandNoRecheckr", Z208BR_Encounter_IsRandNoRecheckr);
         GxWebStd.gx_hidden_field( context, "Z209BR_Encounter_IsRandRecheckDate", context.localUtil.TToC( Z209BR_Encounter_IsRandRecheckDate, 10, 8, 0, 0, "/", ":", " "));
         GxWebStd.gx_hidden_field( context, "Z210BR_Encounter_IsRandNoRecheckDate", context.localUtil.TToC( Z210BR_Encounter_IsRandNoRecheckDate, 10, 8, 0, 0, "/", ":", " "));
         GxWebStd.gx_boolean_hidden_field( context, "Z202BR_Encounter_IsUpdate", Z202BR_Encounter_IsUpdate);
         GxWebStd.gx_hidden_field( context, "Z537BR_Encounter_Datasource", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z537BR_Encounter_Datasource), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "Z560EncounterIDEncrypt", Z560EncounterIDEncrypt);
         GxWebStd.gx_hidden_field( context, "Z85BR_Information_ID", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z85BR_Information_ID), 18, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "Z360BAS_TenantTenantCode", Z360BAS_TenantTenantCode);
         GxWebStd.gx_hidden_field( context, "IsConfirmed", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsConfirmed), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "IsModified", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsModified), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "Mode", StringUtil.RTrim( Gx_mode));
         GxWebStd.gx_hidden_field( context, "gxhash_Mode", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         GxWebStd.gx_hidden_field( context, "N85BR_Information_ID", StringUtil.LTrim( StringUtil.NToC( (decimal)(A85BR_Information_ID), 18, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "N360BAS_TenantTenantCode", A360BAS_TenantTenantCode);
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vTRNCONTEXT", AV11TrnContext);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vTRNCONTEXT", AV11TrnContext);
         }
         GxWebStd.gx_hidden_field( context, "vBR_ENCOUNTERID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV7BR_EncounterID), 18, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "gxhash_vBR_ENCOUNTERID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV7BR_EncounterID), "ZZZZZZZZZZZZZZZZZZ"), context));
         GxWebStd.gx_hidden_field( context, "vINSERT_BR_INFORMATION_ID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV8Insert_BR_Information_ID), 18, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "vINSERT_BAS_TENANTTENANTCODE", AV29Insert_BAS_TenantTenantCode);
         GxWebStd.gx_hidden_field( context, "BAS_TENANTTENANTCODE", A360BAS_TenantTenantCode);
         GxWebStd.gx_hidden_field( context, "BR_ENCOUNTER_CRTDISPLAYNAME", A512BR_Encounter_CrtDisplayName);
         GxWebStd.gx_hidden_field( context, "BR_ENCOUNTER_DEPARTMENT_CODE", A470BR_Encounter_Department_Code);
         GxWebStd.gx_hidden_field( context, "BR_ENCOUNTER_ENCTYPE_CODE", A471BR_Encounter_ENCType_Code);
         GxWebStd.gx_hidden_field( context, "BR_ENCOUNTER_ADMITSOURCE_CODE", A472BR_Encounter_AdmitSource_Code);
         GxWebStd.gx_hidden_field( context, "BR_ENCOUNTER_DISCHARGESTATUS_CODE", A473BR_Encounter_DischargeStatus_Code);
         GxWebStd.gx_hidden_field( context, "vTCURRENTCODE", AV30tCurrentCode);
         GxWebStd.gx_hidden_field( context, "BR_ENCOUNTER_DEPARTMENTADM", A570BR_Encounter_Departmentadm);
         GxWebStd.gx_hidden_field( context, "BR_ENCOUNTER_DEPARTMENTADM_CODE", A571BR_Encounter_Departmentadm_Code);
         GxWebStd.gx_hidden_field( context, "BR_ENCOUNTER_DEPARTMENTDISCH", A572BR_Encounter_Departmentdisch);
         GxWebStd.gx_hidden_field( context, "BR_ENCOUNTER_DEPARTMENTDISCH_CODE", A573BR_Encounter_Departmentdisch_Code);
         GxWebStd.gx_hidden_field( context, "BR_ENCOUNTER_INSURANCE", A574BR_Encounter_Insurance);
         GxWebStd.gx_hidden_field( context, "BR_ENCOUNTER_INSURANCE_CODE", A575BR_Encounter_Insurance_Code);
         GxWebStd.gx_boolean_hidden_field( context, "BR_ENCOUNTER_ISDLT", A333BR_Encounter_IsDLT);
         GxWebStd.gx_hidden_field( context, "BR_ENCOUNTER_SUBMITUSER", A184BR_Encounter_SubmitUser);
         GxWebStd.gx_hidden_field( context, "BR_ENCOUNTER_REASON", A335BR_Encounter_Reason);
         GxWebStd.gx_hidden_field( context, "BR_ENCOUNTER_SUBMITDATE", context.localUtil.TToC( A185BR_Encounter_SubmitDate, 10, 8, 0, 0, "/", ":", " "));
         GxWebStd.gx_hidden_field( context, "BR_ENCOUNTER_RECHECKUSER", A188BR_Encounter_RecheckUser);
         GxWebStd.gx_hidden_field( context, "BR_ENCOUNTER_FREASON", A336BR_Encounter_FReason);
         GxWebStd.gx_hidden_field( context, "BR_ENCOUNTER_RECHECKDATE", context.localUtil.TToC( A189BR_Encounter_RecheckDate, 10, 8, 0, 0, "/", ":", " "));
         GxWebStd.gx_hidden_field( context, "BR_ENCOUNTER_APPROVER", A190BR_Encounter_Approver);
         GxWebStd.gx_hidden_field( context, "BR_ENCOUNTER_APPROVEDATE", context.localUtil.TToC( A191BR_Encounter_ApproveDate, 10, 8, 0, 0, "/", ":", " "));
         GxWebStd.gx_boolean_hidden_field( context, "BR_ENCOUNTER_ISRANDAPPROVE", A192BR_Encounter_IsRandApprove);
         GxWebStd.gx_hidden_field( context, "BR_ENCOUNTER_ISRANDAPPROVER", A203BR_Encounter_IsRandApprover);
         GxWebStd.gx_hidden_field( context, "BR_ENCOUNTER_ISRANDNOAPPROVER", A204BR_Encounter_IsRandNoApprover);
         GxWebStd.gx_hidden_field( context, "BR_ENCOUNTER_ISRANDAPPROVEDATE", context.localUtil.TToC( A205BR_Encounter_IsRandApproveDate, 10, 8, 0, 0, "/", ":", " "));
         GxWebStd.gx_hidden_field( context, "BR_ENCOUNTER_ISRANDNOAPPROVEDATE", context.localUtil.TToC( A206BR_Encounter_IsRandNoApproveDate, 10, 8, 0, 0, "/", ":", " "));
         GxWebStd.gx_boolean_hidden_field( context, "BR_ENCOUNTER_ISRANDRECHECK", A193BR_Encounter_IsRandRecheck);
         GxWebStd.gx_hidden_field( context, "BR_ENCOUNTER_ISRANDRECHECKR", A207BR_Encounter_IsRandRecheckr);
         GxWebStd.gx_hidden_field( context, "BR_ENCOUNTER_ISRANDNORECHECKR", A208BR_Encounter_IsRandNoRecheckr);
         GxWebStd.gx_hidden_field( context, "BR_ENCOUNTER_ISRANDRECHECKDATE", context.localUtil.TToC( A209BR_Encounter_IsRandRecheckDate, 10, 8, 0, 0, "/", ":", " "));
         GxWebStd.gx_hidden_field( context, "BR_ENCOUNTER_ISRANDNORECHECKDATE", context.localUtil.TToC( A210BR_Encounter_IsRandNoRecheckDate, 10, 8, 0, 0, "/", ":", " "));
         GxWebStd.gx_boolean_hidden_field( context, "BR_ENCOUNTER_ISUPDATE", A202BR_Encounter_IsUpdate);
         GxWebStd.gx_hidden_field( context, "BR_ENCOUNTER_DATASOURCE", StringUtil.LTrim( StringUtil.NToC( (decimal)(A537BR_Encounter_Datasource), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "ENCOUNTERIDENCRYPT", A560EncounterIDEncrypt);
         GxWebStd.gx_hidden_field( context, "vPGMNAME", StringUtil.RTrim( AV32Pgmname));
         GxWebStd.gx_hidden_field( context, "vPGMDESC", StringUtil.RTrim( AV31Pgmdesc));
         GxWebStd.gx_hidden_field( context, "vMODE", StringUtil.RTrim( Gx_mode));
         GxWebStd.gx_hidden_field( context, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
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
         return formatLink("br_encounter.aspx") + "?" + UrlEncode(StringUtil.RTrim(Gx_mode)) + "," + UrlEncode("" +AV7BR_EncounterID) ;
      }

      public override String GetPgmname( )
      {
         return "BR_Encounter" ;
      }

      public override String GetPgmdesc( )
      {
         return "就诊信息" ;
      }

      protected void InitializeNonKey0E15( )
      {
         A85BR_Information_ID = 0;
         n85BR_Information_ID = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A85BR_Information_ID", StringUtil.LTrim( StringUtil.Str( (decimal)(A85BR_Information_ID), 18, 0)));
         n85BR_Information_ID = ((0==A85BR_Information_ID) ? true : false);
         A360BAS_TenantTenantCode = "";
         n360BAS_TenantTenantCode = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A360BAS_TenantTenantCode", A360BAS_TenantTenantCode);
         AV24vDepartment = "";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV24vDepartment", AV24vDepartment);
         AV26vENCType = "";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV26vENCType", AV26vENCType);
         AV27vReason = "";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV27vReason", AV27vReason);
         A35BR_Encounter_EncID = 0;
         n35BR_Encounter_EncID = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A35BR_Encounter_EncID", StringUtil.LTrim( StringUtil.Str( (decimal)(A35BR_Encounter_EncID), 10, 0)));
         n35BR_Encounter_EncID = ((0==A35BR_Encounter_EncID) ? true : false);
         A172BR_Encounter_Status = 0;
         n172BR_Encounter_Status = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A172BR_Encounter_Status", StringUtil.LTrim( StringUtil.Str( (decimal)(A172BR_Encounter_Status), 4, 0)));
         n172BR_Encounter_Status = ((0==A172BR_Encounter_Status) ? true : false);
         A183BR_Encounter_CrtUser = "";
         n183BR_Encounter_CrtUser = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A183BR_Encounter_CrtUser", A183BR_Encounter_CrtUser);
         n183BR_Encounter_CrtUser = (String.IsNullOrEmpty(StringUtil.RTrim( A183BR_Encounter_CrtUser)) ? true : false);
         A512BR_Encounter_CrtDisplayName = "";
         n512BR_Encounter_CrtDisplayName = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A512BR_Encounter_CrtDisplayName", A512BR_Encounter_CrtDisplayName);
         A182BR_Encounter_CrtDate = (DateTime)(DateTime.MinValue);
         n182BR_Encounter_CrtDate = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A182BR_Encounter_CrtDate", context.localUtil.TToC( A182BR_Encounter_CrtDate, 10, 8, 0, 0, "/", ":", " "));
         n182BR_Encounter_CrtDate = ((DateTime.MinValue==A182BR_Encounter_CrtDate) ? true : false);
         A470BR_Encounter_Department_Code = "";
         n470BR_Encounter_Department_Code = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A470BR_Encounter_Department_Code", A470BR_Encounter_Department_Code);
         A471BR_Encounter_ENCType_Code = "";
         n471BR_Encounter_ENCType_Code = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A471BR_Encounter_ENCType_Code", A471BR_Encounter_ENCType_Code);
         A472BR_Encounter_AdmitSource_Code = "";
         n472BR_Encounter_AdmitSource_Code = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A472BR_Encounter_AdmitSource_Code", A472BR_Encounter_AdmitSource_Code);
         A473BR_Encounter_DischargeStatus_Code = "";
         n473BR_Encounter_DischargeStatus_Code = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A473BR_Encounter_DischargeStatus_Code", A473BR_Encounter_DischargeStatus_Code);
         A84BR_Encounter_Department = "";
         n84BR_Encounter_Department = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A84BR_Encounter_Department", A84BR_Encounter_Department);
         n84BR_Encounter_Department = (String.IsNullOrEmpty(StringUtil.RTrim( A84BR_Encounter_Department)) ? true : false);
         A570BR_Encounter_Departmentadm = "";
         n570BR_Encounter_Departmentadm = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A570BR_Encounter_Departmentadm", A570BR_Encounter_Departmentadm);
         A571BR_Encounter_Departmentadm_Code = "";
         n571BR_Encounter_Departmentadm_Code = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A571BR_Encounter_Departmentadm_Code", A571BR_Encounter_Departmentadm_Code);
         A572BR_Encounter_Departmentdisch = "";
         n572BR_Encounter_Departmentdisch = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A572BR_Encounter_Departmentdisch", A572BR_Encounter_Departmentdisch);
         A573BR_Encounter_Departmentdisch_Code = "";
         n573BR_Encounter_Departmentdisch_Code = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A573BR_Encounter_Departmentdisch_Code", A573BR_Encounter_Departmentdisch_Code);
         A90BR_Encounter_ENCType = "";
         n90BR_Encounter_ENCType = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A90BR_Encounter_ENCType", A90BR_Encounter_ENCType);
         n90BR_Encounter_ENCType = (String.IsNullOrEmpty(StringUtil.RTrim( A90BR_Encounter_ENCType)) ? true : false);
         A91BR_Encounter_AdmitDate = DateTime.MinValue;
         n91BR_Encounter_AdmitDate = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A91BR_Encounter_AdmitDate", context.localUtil.Format(A91BR_Encounter_AdmitDate, "9999/99/99"));
         n91BR_Encounter_AdmitDate = ((DateTime.MinValue==A91BR_Encounter_AdmitDate) ? true : false);
         A92BR_Encounter_AdmitSource = "";
         n92BR_Encounter_AdmitSource = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A92BR_Encounter_AdmitSource", A92BR_Encounter_AdmitSource);
         n92BR_Encounter_AdmitSource = (String.IsNullOrEmpty(StringUtil.RTrim( A92BR_Encounter_AdmitSource)) ? true : false);
         A93BR_Encounter_DischargeDate = DateTime.MinValue;
         n93BR_Encounter_DischargeDate = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A93BR_Encounter_DischargeDate", context.localUtil.Format(A93BR_Encounter_DischargeDate, "9999/99/99"));
         n93BR_Encounter_DischargeDate = ((DateTime.MinValue==A93BR_Encounter_DischargeDate) ? true : false);
         A94BR_Encounter_DischargeStatus = "";
         n94BR_Encounter_DischargeStatus = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A94BR_Encounter_DischargeStatus", A94BR_Encounter_DischargeStatus);
         n94BR_Encounter_DischargeStatus = (String.IsNullOrEmpty(StringUtil.RTrim( A94BR_Encounter_DischargeStatus)) ? true : false);
         A574BR_Encounter_Insurance = "";
         n574BR_Encounter_Insurance = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A574BR_Encounter_Insurance", A574BR_Encounter_Insurance);
         A575BR_Encounter_Insurance_Code = "";
         n575BR_Encounter_Insurance_Code = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A575BR_Encounter_Insurance_Code", A575BR_Encounter_Insurance_Code);
         A36BR_Information_PatientNo = "";
         n36BR_Information_PatientNo = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A36BR_Information_PatientNo", A36BR_Information_PatientNo);
         A187BR_Encounter_UpdDate = (DateTime)(DateTime.MinValue);
         n187BR_Encounter_UpdDate = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A187BR_Encounter_UpdDate", context.localUtil.TToC( A187BR_Encounter_UpdDate, 10, 8, 0, 0, "/", ":", " "));
         n187BR_Encounter_UpdDate = ((DateTime.MinValue==A187BR_Encounter_UpdDate) ? true : false);
         A186BR_Encounter_UpdUser = "";
         n186BR_Encounter_UpdUser = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A186BR_Encounter_UpdUser", A186BR_Encounter_UpdUser);
         n186BR_Encounter_UpdUser = (String.IsNullOrEmpty(StringUtil.RTrim( A186BR_Encounter_UpdUser)) ? true : false);
         A333BR_Encounter_IsDLT = false;
         n333BR_Encounter_IsDLT = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A333BR_Encounter_IsDLT", A333BR_Encounter_IsDLT);
         A184BR_Encounter_SubmitUser = "";
         n184BR_Encounter_SubmitUser = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A184BR_Encounter_SubmitUser", A184BR_Encounter_SubmitUser);
         A335BR_Encounter_Reason = "";
         n335BR_Encounter_Reason = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A335BR_Encounter_Reason", A335BR_Encounter_Reason);
         A185BR_Encounter_SubmitDate = (DateTime)(DateTime.MinValue);
         n185BR_Encounter_SubmitDate = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A185BR_Encounter_SubmitDate", context.localUtil.TToC( A185BR_Encounter_SubmitDate, 10, 8, 0, 0, "/", ":", " "));
         A188BR_Encounter_RecheckUser = "";
         n188BR_Encounter_RecheckUser = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A188BR_Encounter_RecheckUser", A188BR_Encounter_RecheckUser);
         A336BR_Encounter_FReason = "";
         n336BR_Encounter_FReason = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A336BR_Encounter_FReason", A336BR_Encounter_FReason);
         A189BR_Encounter_RecheckDate = (DateTime)(DateTime.MinValue);
         n189BR_Encounter_RecheckDate = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A189BR_Encounter_RecheckDate", context.localUtil.TToC( A189BR_Encounter_RecheckDate, 10, 8, 0, 0, "/", ":", " "));
         A190BR_Encounter_Approver = "";
         n190BR_Encounter_Approver = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A190BR_Encounter_Approver", A190BR_Encounter_Approver);
         A191BR_Encounter_ApproveDate = (DateTime)(DateTime.MinValue);
         n191BR_Encounter_ApproveDate = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A191BR_Encounter_ApproveDate", context.localUtil.TToC( A191BR_Encounter_ApproveDate, 10, 8, 0, 0, "/", ":", " "));
         A192BR_Encounter_IsRandApprove = false;
         n192BR_Encounter_IsRandApprove = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A192BR_Encounter_IsRandApprove", A192BR_Encounter_IsRandApprove);
         A203BR_Encounter_IsRandApprover = "";
         n203BR_Encounter_IsRandApprover = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A203BR_Encounter_IsRandApprover", A203BR_Encounter_IsRandApprover);
         A204BR_Encounter_IsRandNoApprover = "";
         n204BR_Encounter_IsRandNoApprover = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A204BR_Encounter_IsRandNoApprover", A204BR_Encounter_IsRandNoApprover);
         A205BR_Encounter_IsRandApproveDate = (DateTime)(DateTime.MinValue);
         n205BR_Encounter_IsRandApproveDate = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A205BR_Encounter_IsRandApproveDate", context.localUtil.TToC( A205BR_Encounter_IsRandApproveDate, 10, 8, 0, 0, "/", ":", " "));
         A206BR_Encounter_IsRandNoApproveDate = (DateTime)(DateTime.MinValue);
         n206BR_Encounter_IsRandNoApproveDate = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A206BR_Encounter_IsRandNoApproveDate", context.localUtil.TToC( A206BR_Encounter_IsRandNoApproveDate, 10, 8, 0, 0, "/", ":", " "));
         A193BR_Encounter_IsRandRecheck = false;
         n193BR_Encounter_IsRandRecheck = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A193BR_Encounter_IsRandRecheck", A193BR_Encounter_IsRandRecheck);
         A207BR_Encounter_IsRandRecheckr = "";
         n207BR_Encounter_IsRandRecheckr = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A207BR_Encounter_IsRandRecheckr", A207BR_Encounter_IsRandRecheckr);
         A208BR_Encounter_IsRandNoRecheckr = "";
         n208BR_Encounter_IsRandNoRecheckr = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A208BR_Encounter_IsRandNoRecheckr", A208BR_Encounter_IsRandNoRecheckr);
         A209BR_Encounter_IsRandRecheckDate = (DateTime)(DateTime.MinValue);
         n209BR_Encounter_IsRandRecheckDate = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A209BR_Encounter_IsRandRecheckDate", context.localUtil.TToC( A209BR_Encounter_IsRandRecheckDate, 10, 8, 0, 0, "/", ":", " "));
         A210BR_Encounter_IsRandNoRecheckDate = (DateTime)(DateTime.MinValue);
         n210BR_Encounter_IsRandNoRecheckDate = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A210BR_Encounter_IsRandNoRecheckDate", context.localUtil.TToC( A210BR_Encounter_IsRandNoRecheckDate, 10, 8, 0, 0, "/", ":", " "));
         A202BR_Encounter_IsUpdate = false;
         n202BR_Encounter_IsUpdate = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A202BR_Encounter_IsUpdate", A202BR_Encounter_IsUpdate);
         A537BR_Encounter_Datasource = 0;
         n537BR_Encounter_Datasource = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A537BR_Encounter_Datasource", StringUtil.LTrim( StringUtil.Str( (decimal)(A537BR_Encounter_Datasource), 4, 0)));
         A560EncounterIDEncrypt = "";
         n560EncounterIDEncrypt = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A560EncounterIDEncrypt", A560EncounterIDEncrypt);
         Z35BR_Encounter_EncID = 0;
         Z172BR_Encounter_Status = 0;
         Z183BR_Encounter_CrtUser = "";
         Z512BR_Encounter_CrtDisplayName = "";
         Z182BR_Encounter_CrtDate = (DateTime)(DateTime.MinValue);
         Z470BR_Encounter_Department_Code = "";
         Z471BR_Encounter_ENCType_Code = "";
         Z472BR_Encounter_AdmitSource_Code = "";
         Z473BR_Encounter_DischargeStatus_Code = "";
         Z84BR_Encounter_Department = "";
         Z570BR_Encounter_Departmentadm = "";
         Z571BR_Encounter_Departmentadm_Code = "";
         Z572BR_Encounter_Departmentdisch = "";
         Z573BR_Encounter_Departmentdisch_Code = "";
         Z90BR_Encounter_ENCType = "";
         Z91BR_Encounter_AdmitDate = DateTime.MinValue;
         Z92BR_Encounter_AdmitSource = "";
         Z93BR_Encounter_DischargeDate = DateTime.MinValue;
         Z94BR_Encounter_DischargeStatus = "";
         Z574BR_Encounter_Insurance = "";
         Z575BR_Encounter_Insurance_Code = "";
         Z187BR_Encounter_UpdDate = (DateTime)(DateTime.MinValue);
         Z186BR_Encounter_UpdUser = "";
         Z333BR_Encounter_IsDLT = false;
         Z184BR_Encounter_SubmitUser = "";
         Z335BR_Encounter_Reason = "";
         Z185BR_Encounter_SubmitDate = (DateTime)(DateTime.MinValue);
         Z188BR_Encounter_RecheckUser = "";
         Z336BR_Encounter_FReason = "";
         Z189BR_Encounter_RecheckDate = (DateTime)(DateTime.MinValue);
         Z190BR_Encounter_Approver = "";
         Z191BR_Encounter_ApproveDate = (DateTime)(DateTime.MinValue);
         Z192BR_Encounter_IsRandApprove = false;
         Z203BR_Encounter_IsRandApprover = "";
         Z204BR_Encounter_IsRandNoApprover = "";
         Z205BR_Encounter_IsRandApproveDate = (DateTime)(DateTime.MinValue);
         Z206BR_Encounter_IsRandNoApproveDate = (DateTime)(DateTime.MinValue);
         Z193BR_Encounter_IsRandRecheck = false;
         Z207BR_Encounter_IsRandRecheckr = "";
         Z208BR_Encounter_IsRandNoRecheckr = "";
         Z209BR_Encounter_IsRandRecheckDate = (DateTime)(DateTime.MinValue);
         Z210BR_Encounter_IsRandNoRecheckDate = (DateTime)(DateTime.MinValue);
         Z202BR_Encounter_IsUpdate = false;
         Z537BR_Encounter_Datasource = 0;
         Z560EncounterIDEncrypt = "";
         Z85BR_Information_ID = 0;
         Z360BAS_TenantTenantCode = "";
      }

      protected void InitAll0E15( )
      {
         A19BR_EncounterID = 0;
         n19BR_EncounterID = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A19BR_EncounterID", StringUtil.LTrim( StringUtil.Str( (decimal)(A19BR_EncounterID), 18, 0)));
         InitializeNonKey0E15( ) ;
      }

      protected void StandaloneModalInsert( )
      {
      }

      protected void define_styles( )
      {
         AddStyleSheetFile("calendar-system.css", "");
         AddThemeStyleSheetFile("", context.GetTheme( )+".css", "?"+GetCacheInvalidationToken( ));
         bool outputEnabled = isOutputEnabled( ) ;
         if ( context.isSpaRequest( ) )
         {
            enableOutput();
         }
         idxLst = 1;
         while ( idxLst <= Form.Jscriptsrc.Count )
         {
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?20202279363388", true);
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
         context.AddJavascriptSource("br_encounter.js", "?20202279363389", false);
         context.AddJavascriptSource("DVelop/Bootstrap/Shared/DVelopBootstrap.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/Panel/BootstrapPanelRender.js", "", false);
         /* End function include_jscripts */
      }

      protected void init_default_properties( )
      {
         edtBR_Information_ID_Internalname = "BR_INFORMATION_ID";
         edtBR_Information_PatientNo_Internalname = "BR_INFORMATION_PATIENTNO";
         lblTextblockbr_encounter_department_Internalname = "TEXTBLOCKBR_ENCOUNTER_DEPARTMENT";
         dynBR_Encounter_Department_Internalname = "BR_ENCOUNTER_DEPARTMENT";
         edtavVdepartment_Internalname = "vVDEPARTMENT";
         cellVdepartment_cell_Internalname = "VDEPARTMENT_CELL";
         tblTablemergedbr_encounter_department_Internalname = "TABLEMERGEDBR_ENCOUNTER_DEPARTMENT";
         divTablesplittedbr_encounter_department_Internalname = "TABLESPLITTEDBR_ENCOUNTER_DEPARTMENT";
         lblTextblockbr_encounter_enctype_Internalname = "TEXTBLOCKBR_ENCOUNTER_ENCTYPE";
         dynBR_Encounter_ENCType_Internalname = "BR_ENCOUNTER_ENCTYPE";
         edtavVenctype_Internalname = "vVENCTYPE";
         cellVenctype_cell_Internalname = "VENCTYPE_CELL";
         tblTablemergedbr_encounter_enctype_Internalname = "TABLEMERGEDBR_ENCOUNTER_ENCTYPE";
         divTablesplittedbr_encounter_enctype_Internalname = "TABLESPLITTEDBR_ENCOUNTER_ENCTYPE";
         edtBR_Encounter_AdmitDate_Internalname = "BR_ENCOUNTER_ADMITDATE";
         lblTextblockbr_encounter_admitsource_Internalname = "TEXTBLOCKBR_ENCOUNTER_ADMITSOURCE";
         dynBR_Encounter_AdmitSource_Internalname = "BR_ENCOUNTER_ADMITSOURCE";
         edtavVreason_Internalname = "vVREASON";
         cellVreason_cell_Internalname = "VREASON_CELL";
         tblTablemergedbr_encounter_admitsource_Internalname = "TABLEMERGEDBR_ENCOUNTER_ADMITSOURCE";
         divTablesplittedbr_encounter_admitsource_Internalname = "TABLESPLITTEDBR_ENCOUNTER_ADMITSOURCE";
         edtBR_Encounter_DischargeDate_Internalname = "BR_ENCOUNTER_DISCHARGEDATE";
         dynBR_Encounter_DischargeStatus_Internalname = "BR_ENCOUNTER_DISCHARGESTATUS";
         divTableattributes_Internalname = "TABLEATTRIBUTES";
         divLayout_tableattributes_Internalname = "LAYOUT_TABLEATTRIBUTES";
         Dvpanel_tableattributes_Internalname = "DVPANEL_TABLEATTRIBUTES";
         divHtml_dvpanel_tableattributes_Internalname = "HTML_DVPANEL_TABLEATTRIBUTES";
         divTablecontent_Internalname = "TABLECONTENT";
         bttBtntrn_enter_Internalname = "BTNTRN_ENTER";
         bttBtntrn_cancel_Internalname = "BTNTRN_CANCEL";
         bttBtntrn_delete_Internalname = "BTNTRN_DELETE";
         divTablemain_Internalname = "TABLEMAIN";
         edtBR_EncounterID_Internalname = "BR_ENCOUNTERID";
         edtBR_Encounter_EncID_Internalname = "BR_ENCOUNTER_ENCID";
         cmbBR_Encounter_Status_Internalname = "BR_ENCOUNTER_STATUS";
         edtBR_Encounter_CrtDate_Internalname = "BR_ENCOUNTER_CRTDATE";
         edtBR_Encounter_UpdDate_Internalname = "BR_ENCOUNTER_UPDDATE";
         edtBR_Encounter_CrtUser_Internalname = "BR_ENCOUNTER_CRTUSER";
         edtBR_Encounter_UpdUser_Internalname = "BR_ENCOUNTER_UPDUSER";
         divHtml_bottomauxiliarcontrols_Internalname = "HTML_BOTTOMAUXILIARCONTROLS";
         divLayoutmaintable_Internalname = "LAYOUTMAINTABLE";
         Form.Internalname = "FORM";
         imgprompt_85_Internalname = "PROMPT_85";
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
         Form.Caption = "就诊信息";
         edtavVdepartment_Jsonclick = "";
         edtavVdepartment_Enabled = 1;
         edtavVdepartment_Visible = 1;
         cellVdepartment_cell_Class = "";
         dynBR_Encounter_Department_Jsonclick = "";
         dynBR_Encounter_Department.Enabled = 1;
         edtavVenctype_Jsonclick = "";
         edtavVenctype_Enabled = 1;
         edtavVenctype_Visible = 1;
         cellVenctype_cell_Class = "";
         dynBR_Encounter_ENCType_Jsonclick = "";
         dynBR_Encounter_ENCType.Enabled = 1;
         edtavVreason_Jsonclick = "";
         edtavVreason_Enabled = 1;
         edtavVreason_Visible = 1;
         cellVreason_cell_Class = "";
         dynBR_Encounter_AdmitSource_Jsonclick = "";
         dynBR_Encounter_AdmitSource.Enabled = 1;
         edtBR_Encounter_UpdUser_Jsonclick = "";
         edtBR_Encounter_UpdUser_Enabled = 1;
         edtBR_Encounter_UpdUser_Visible = 1;
         edtBR_Encounter_CrtUser_Jsonclick = "";
         edtBR_Encounter_CrtUser_Enabled = 1;
         edtBR_Encounter_CrtUser_Visible = 1;
         edtBR_Encounter_UpdDate_Jsonclick = "";
         edtBR_Encounter_UpdDate_Enabled = 1;
         edtBR_Encounter_UpdDate_Visible = 1;
         edtBR_Encounter_CrtDate_Jsonclick = "";
         edtBR_Encounter_CrtDate_Enabled = 1;
         edtBR_Encounter_CrtDate_Visible = 1;
         cmbBR_Encounter_Status_Jsonclick = "";
         cmbBR_Encounter_Status.Enabled = 1;
         cmbBR_Encounter_Status.Visible = 1;
         edtBR_Encounter_EncID_Jsonclick = "";
         edtBR_Encounter_EncID_Enabled = 1;
         edtBR_Encounter_EncID_Visible = 1;
         edtBR_EncounterID_Jsonclick = "";
         edtBR_EncounterID_Enabled = 0;
         edtBR_EncounterID_Visible = 1;
         bttBtntrn_delete_Enabled = 0;
         bttBtntrn_delete_Visible = 1;
         bttBtntrn_cancel_Visible = 1;
         bttBtntrn_enter_Enabled = 1;
         bttBtntrn_enter_Visible = 1;
         dynBR_Encounter_DischargeStatus_Jsonclick = "";
         dynBR_Encounter_DischargeStatus.Enabled = 1;
         edtBR_Encounter_DischargeDate_Jsonclick = "";
         edtBR_Encounter_DischargeDate_Enabled = 1;
         edtBR_Encounter_AdmitDate_Jsonclick = "";
         edtBR_Encounter_AdmitDate_Enabled = 1;
         edtBR_Information_PatientNo_Jsonclick = "";
         edtBR_Information_PatientNo_Enabled = 0;
         imgprompt_85_Visible = 1;
         imgprompt_85_Link = "";
         edtBR_Information_ID_Jsonclick = "";
         edtBR_Information_ID_Enabled = 1;
         Dvpanel_tableattributes_Autoscroll = Convert.ToBoolean( 0);
         Dvpanel_tableattributes_Iconposition = "left";
         Dvpanel_tableattributes_Showcollapseicon = Convert.ToBoolean( 0);
         Dvpanel_tableattributes_Collapsed = Convert.ToBoolean( 0);
         Dvpanel_tableattributes_Collapsible = Convert.ToBoolean( 0);
         Dvpanel_tableattributes_Title = "就诊基础信息";
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

      protected void GXDLABR_ENCOUNTER_DEPARTMENT0E15( String AV30tCurrentCode )
      {
         if ( ! context.isAjaxRequest( ) )
         {
            context.GX_webresponse.AppendHeader("Cache-Control", "no-store");
         }
         context.GX_webresponse.AddString("[[");
         GXDLABR_ENCOUNTER_DEPARTMENT_data0E15( AV30tCurrentCode) ;
         gxdynajaxindex = 1;
         while ( gxdynajaxindex <= gxdynajaxctrlcodr.Count )
         {
            context.GX_webresponse.AddString(gxwrpcisep+"{\"c\":\""+GXUtil.EncodeJSConstant( ((String)gxdynajaxctrlcodr.Item(gxdynajaxindex)))+"\",\"d\":\""+GXUtil.EncodeJSConstant( ((String)gxdynajaxctrldescr.Item(gxdynajaxindex)))+"\"}");
            gxdynajaxindex = (int)(gxdynajaxindex+1);
            gxwrpcisep = ",";
         }
         context.GX_webresponse.AddString("]");
         if ( gxdynajaxctrlcodr.Count == 0 )
         {
            context.GX_webresponse.AddString(",101");
         }
         context.GX_webresponse.AddString("]");
      }

      protected void GXABR_ENCOUNTER_DEPARTMENT_html0E15( String AV30tCurrentCode )
      {
         String gxdynajaxvalue ;
         GXDLABR_ENCOUNTER_DEPARTMENT_data0E15( AV30tCurrentCode) ;
         gxdynajaxindex = 1;
         if ( ! ( gxdyncontrolsrefreshing && context.isAjaxRequest( ) ) )
         {
            dynBR_Encounter_Department.removeAllItems();
         }
         while ( gxdynajaxindex <= gxdynajaxctrlcodr.Count )
         {
            gxdynajaxvalue = ((String)gxdynajaxctrlcodr.Item(gxdynajaxindex));
            dynBR_Encounter_Department.addItem(gxdynajaxvalue, ((String)gxdynajaxctrldescr.Item(gxdynajaxindex)), 0);
            gxdynajaxindex = (int)(gxdynajaxindex+1);
         }
      }

      protected void GXDLABR_ENCOUNTER_DEPARTMENT_data0E15( String AV30tCurrentCode )
      {
         gxdynajaxctrlcodr.Clear();
         gxdynajaxctrldescr.Clear();
         gxdynajaxctrlcodr.Add("");
         gxdynajaxctrldescr.Add("(请选择)");
         /* Using cursor T000E33 */
         pr_default.execute(29, new Object[] {AV30tCurrentCode});
         while ( (pr_default.getStatus(29) != 101) )
         {
            gxdynajaxctrlcodr.Add(T000E33_A168XT_DefineCodeName[0]);
            gxdynajaxctrldescr.Add(T000E33_A168XT_DefineCodeName[0]);
            pr_default.readNext(29);
         }
         pr_default.close(29);
      }

      protected void GXDLABR_ENCOUNTER_ENCTYPE0E15( String AV30tCurrentCode )
      {
         if ( ! context.isAjaxRequest( ) )
         {
            context.GX_webresponse.AppendHeader("Cache-Control", "no-store");
         }
         context.GX_webresponse.AddString("[[");
         GXDLABR_ENCOUNTER_ENCTYPE_data0E15( AV30tCurrentCode) ;
         gxdynajaxindex = 1;
         while ( gxdynajaxindex <= gxdynajaxctrlcodr.Count )
         {
            context.GX_webresponse.AddString(gxwrpcisep+"{\"c\":\""+GXUtil.EncodeJSConstant( ((String)gxdynajaxctrlcodr.Item(gxdynajaxindex)))+"\",\"d\":\""+GXUtil.EncodeJSConstant( ((String)gxdynajaxctrldescr.Item(gxdynajaxindex)))+"\"}");
            gxdynajaxindex = (int)(gxdynajaxindex+1);
            gxwrpcisep = ",";
         }
         context.GX_webresponse.AddString("]");
         if ( gxdynajaxctrlcodr.Count == 0 )
         {
            context.GX_webresponse.AddString(",101");
         }
         context.GX_webresponse.AddString("]");
      }

      protected void GXABR_ENCOUNTER_ENCTYPE_html0E15( String AV30tCurrentCode )
      {
         String gxdynajaxvalue ;
         GXDLABR_ENCOUNTER_ENCTYPE_data0E15( AV30tCurrentCode) ;
         gxdynajaxindex = 1;
         if ( ! ( gxdyncontrolsrefreshing && context.isAjaxRequest( ) ) )
         {
            dynBR_Encounter_ENCType.removeAllItems();
         }
         while ( gxdynajaxindex <= gxdynajaxctrlcodr.Count )
         {
            gxdynajaxvalue = ((String)gxdynajaxctrlcodr.Item(gxdynajaxindex));
            dynBR_Encounter_ENCType.addItem(gxdynajaxvalue, ((String)gxdynajaxctrldescr.Item(gxdynajaxindex)), 0);
            gxdynajaxindex = (int)(gxdynajaxindex+1);
         }
      }

      protected void GXDLABR_ENCOUNTER_ENCTYPE_data0E15( String AV30tCurrentCode )
      {
         gxdynajaxctrlcodr.Clear();
         gxdynajaxctrldescr.Clear();
         gxdynajaxctrlcodr.Add("");
         gxdynajaxctrldescr.Add("(请选择)");
         /* Using cursor T000E34 */
         pr_default.execute(30, new Object[] {AV30tCurrentCode});
         while ( (pr_default.getStatus(30) != 101) )
         {
            gxdynajaxctrlcodr.Add(T000E34_A168XT_DefineCodeName[0]);
            gxdynajaxctrldescr.Add(T000E34_A168XT_DefineCodeName[0]);
            pr_default.readNext(30);
         }
         pr_default.close(30);
      }

      protected void GXDLABR_ENCOUNTER_ADMITSOURCE0E15( String AV30tCurrentCode )
      {
         if ( ! context.isAjaxRequest( ) )
         {
            context.GX_webresponse.AppendHeader("Cache-Control", "no-store");
         }
         context.GX_webresponse.AddString("[[");
         GXDLABR_ENCOUNTER_ADMITSOURCE_data0E15( AV30tCurrentCode) ;
         gxdynajaxindex = 1;
         while ( gxdynajaxindex <= gxdynajaxctrlcodr.Count )
         {
            context.GX_webresponse.AddString(gxwrpcisep+"{\"c\":\""+GXUtil.EncodeJSConstant( ((String)gxdynajaxctrlcodr.Item(gxdynajaxindex)))+"\",\"d\":\""+GXUtil.EncodeJSConstant( ((String)gxdynajaxctrldescr.Item(gxdynajaxindex)))+"\"}");
            gxdynajaxindex = (int)(gxdynajaxindex+1);
            gxwrpcisep = ",";
         }
         context.GX_webresponse.AddString("]");
         if ( gxdynajaxctrlcodr.Count == 0 )
         {
            context.GX_webresponse.AddString(",101");
         }
         context.GX_webresponse.AddString("]");
      }

      protected void GXABR_ENCOUNTER_ADMITSOURCE_html0E15( String AV30tCurrentCode )
      {
         String gxdynajaxvalue ;
         GXDLABR_ENCOUNTER_ADMITSOURCE_data0E15( AV30tCurrentCode) ;
         gxdynajaxindex = 1;
         if ( ! ( gxdyncontrolsrefreshing && context.isAjaxRequest( ) ) )
         {
            dynBR_Encounter_AdmitSource.removeAllItems();
         }
         while ( gxdynajaxindex <= gxdynajaxctrlcodr.Count )
         {
            gxdynajaxvalue = ((String)gxdynajaxctrlcodr.Item(gxdynajaxindex));
            dynBR_Encounter_AdmitSource.addItem(gxdynajaxvalue, ((String)gxdynajaxctrldescr.Item(gxdynajaxindex)), 0);
            gxdynajaxindex = (int)(gxdynajaxindex+1);
         }
      }

      protected void GXDLABR_ENCOUNTER_ADMITSOURCE_data0E15( String AV30tCurrentCode )
      {
         gxdynajaxctrlcodr.Clear();
         gxdynajaxctrldescr.Clear();
         gxdynajaxctrlcodr.Add("");
         gxdynajaxctrldescr.Add("(请选择)");
         /* Using cursor T000E35 */
         pr_default.execute(31, new Object[] {AV30tCurrentCode});
         while ( (pr_default.getStatus(31) != 101) )
         {
            gxdynajaxctrlcodr.Add(T000E35_A168XT_DefineCodeName[0]);
            gxdynajaxctrldescr.Add(T000E35_A168XT_DefineCodeName[0]);
            pr_default.readNext(31);
         }
         pr_default.close(31);
      }

      protected void GXDLABR_ENCOUNTER_DISCHARGESTATUS0E15( String AV30tCurrentCode )
      {
         if ( ! context.isAjaxRequest( ) )
         {
            context.GX_webresponse.AppendHeader("Cache-Control", "no-store");
         }
         context.GX_webresponse.AddString("[[");
         GXDLABR_ENCOUNTER_DISCHARGESTATUS_data0E15( AV30tCurrentCode) ;
         gxdynajaxindex = 1;
         while ( gxdynajaxindex <= gxdynajaxctrlcodr.Count )
         {
            context.GX_webresponse.AddString(gxwrpcisep+"{\"c\":\""+GXUtil.EncodeJSConstant( ((String)gxdynajaxctrlcodr.Item(gxdynajaxindex)))+"\",\"d\":\""+GXUtil.EncodeJSConstant( ((String)gxdynajaxctrldescr.Item(gxdynajaxindex)))+"\"}");
            gxdynajaxindex = (int)(gxdynajaxindex+1);
            gxwrpcisep = ",";
         }
         context.GX_webresponse.AddString("]");
         if ( gxdynajaxctrlcodr.Count == 0 )
         {
            context.GX_webresponse.AddString(",101");
         }
         context.GX_webresponse.AddString("]");
      }

      protected void GXABR_ENCOUNTER_DISCHARGESTATUS_html0E15( String AV30tCurrentCode )
      {
         String gxdynajaxvalue ;
         GXDLABR_ENCOUNTER_DISCHARGESTATUS_data0E15( AV30tCurrentCode) ;
         gxdynajaxindex = 1;
         if ( ! ( gxdyncontrolsrefreshing && context.isAjaxRequest( ) ) )
         {
            dynBR_Encounter_DischargeStatus.removeAllItems();
         }
         while ( gxdynajaxindex <= gxdynajaxctrlcodr.Count )
         {
            gxdynajaxvalue = ((String)gxdynajaxctrlcodr.Item(gxdynajaxindex));
            dynBR_Encounter_DischargeStatus.addItem(gxdynajaxvalue, ((String)gxdynajaxctrldescr.Item(gxdynajaxindex)), 0);
            gxdynajaxindex = (int)(gxdynajaxindex+1);
         }
      }

      protected void GXDLABR_ENCOUNTER_DISCHARGESTATUS_data0E15( String AV30tCurrentCode )
      {
         gxdynajaxctrlcodr.Clear();
         gxdynajaxctrldescr.Clear();
         gxdynajaxctrlcodr.Add("");
         gxdynajaxctrldescr.Add("(请选择)");
         /* Using cursor T000E36 */
         pr_default.execute(32, new Object[] {AV30tCurrentCode});
         while ( (pr_default.getStatus(32) != 101) )
         {
            gxdynajaxctrlcodr.Add(T000E36_A168XT_DefineCodeName[0]);
            gxdynajaxctrldescr.Add(T000E36_A168XT_DefineCodeName[0]);
            pr_default.readNext(32);
         }
         pr_default.close(32);
      }

      protected void GX12ASABAS_TENANTTENANTCODE0E15( String AV29Insert_BAS_TenantTenantCode )
      {
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) && ! String.IsNullOrEmpty(StringUtil.RTrim( AV29Insert_BAS_TenantTenantCode)) )
         {
            A360BAS_TenantTenantCode = AV29Insert_BAS_TenantTenantCode;
            n360BAS_TenantTenantCode = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A360BAS_TenantTenantCode", A360BAS_TenantTenantCode);
         }
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("[[");
         context.GX_webresponse.AddString("\""+GXUtil.EncodeJSConstant( A360BAS_TenantTenantCode)+"\"");
         context.GX_webresponse.AddString("]");
         if ( true )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString("]");
      }

      protected void GX13ASABAS_TENANTTENANTCODE0E15( String Gx_mode )
      {
         GXt_char1 = A360BAS_TenantTenantCode;
         new zbr_getcurrenttcode(context ).execute( out  GXt_char1) ;
         A360BAS_TenantTenantCode = GXt_char1;
         n360BAS_TenantTenantCode = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A360BAS_TenantTenantCode", A360BAS_TenantTenantCode);
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("[[");
         context.GX_webresponse.AddString("\""+GXUtil.EncodeJSConstant( A360BAS_TenantTenantCode)+"\"");
         context.GX_webresponse.AddString("]");
         if ( true )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString("]");
      }

      protected void GX20ASABR_ENCOUNTER_ENCID0E15( long A85BR_Information_ID )
      {
         GXt_int3 = A35BR_Encounter_EncID;
         new zutil_findcountbypatientno(context ).execute(  A85BR_Information_ID, out  GXt_int3) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A85BR_Information_ID", StringUtil.LTrim( StringUtil.Str( (decimal)(A85BR_Information_ID), 18, 0)));
         A35BR_Encounter_EncID = GXt_int3;
         n35BR_Encounter_EncID = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A35BR_Encounter_EncID", StringUtil.LTrim( StringUtil.Str( (decimal)(A35BR_Encounter_EncID), 10, 0)));
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("[[");
         context.GX_webresponse.AddString("\""+GXUtil.EncodeJSConstant( StringUtil.LTrim( StringUtil.NToC( (decimal)(A35BR_Encounter_EncID), 10, 0, ".", "")))+"\"");
         context.GX_webresponse.AddString("]");
         if ( true )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString("]");
      }

      protected void GX25ASABR_ENCOUNTER_DEPARTMENT_CODE0E15( String A84BR_Encounter_Department )
      {
         GXt_char1 = A470BR_Encounter_Department_Code;
         new zutil_findtargetcode(context ).execute(  3,  A84BR_Encounter_Department, out  GXt_char1) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A84BR_Encounter_Department", A84BR_Encounter_Department);
         A470BR_Encounter_Department_Code = GXt_char1;
         n470BR_Encounter_Department_Code = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A470BR_Encounter_Department_Code", A470BR_Encounter_Department_Code);
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("[[");
         context.GX_webresponse.AddString("\""+GXUtil.EncodeJSConstant( A470BR_Encounter_Department_Code)+"\"");
         context.GX_webresponse.AddString("]");
         if ( true )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString("]");
      }

      protected void GX26ASABR_ENCOUNTER_DEPARTMENT_CODE0E15( String A84BR_Encounter_Department )
      {
         GXt_char1 = A470BR_Encounter_Department_Code;
         new zutil_findtargetcode(context ).execute(  3,  A84BR_Encounter_Department, out  GXt_char1) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A84BR_Encounter_Department", A84BR_Encounter_Department);
         A470BR_Encounter_Department_Code = GXt_char1;
         n470BR_Encounter_Department_Code = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A470BR_Encounter_Department_Code", A470BR_Encounter_Department_Code);
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("[[");
         context.GX_webresponse.AddString("\""+GXUtil.EncodeJSConstant( A470BR_Encounter_Department_Code)+"\"");
         context.GX_webresponse.AddString("]");
         if ( true )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString("]");
      }

      protected void GX27ASABR_ENCOUNTER_ENCTYPE_CODE0E15( String A90BR_Encounter_ENCType )
      {
         GXt_char1 = A471BR_Encounter_ENCType_Code;
         new zutil_findtargetcode(context ).execute(  4,  A90BR_Encounter_ENCType, out  GXt_char1) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A90BR_Encounter_ENCType", A90BR_Encounter_ENCType);
         A471BR_Encounter_ENCType_Code = GXt_char1;
         n471BR_Encounter_ENCType_Code = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A471BR_Encounter_ENCType_Code", A471BR_Encounter_ENCType_Code);
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("[[");
         context.GX_webresponse.AddString("\""+GXUtil.EncodeJSConstant( A471BR_Encounter_ENCType_Code)+"\"");
         context.GX_webresponse.AddString("]");
         if ( true )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString("]");
      }

      protected void GX28ASABR_ENCOUNTER_ENCTYPE_CODE0E15( String A90BR_Encounter_ENCType )
      {
         GXt_char1 = A471BR_Encounter_ENCType_Code;
         new zutil_findtargetcode(context ).execute(  4,  A90BR_Encounter_ENCType, out  GXt_char1) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A90BR_Encounter_ENCType", A90BR_Encounter_ENCType);
         A471BR_Encounter_ENCType_Code = GXt_char1;
         n471BR_Encounter_ENCType_Code = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A471BR_Encounter_ENCType_Code", A471BR_Encounter_ENCType_Code);
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("[[");
         context.GX_webresponse.AddString("\""+GXUtil.EncodeJSConstant( A471BR_Encounter_ENCType_Code)+"\"");
         context.GX_webresponse.AddString("]");
         if ( true )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString("]");
      }

      protected void GX29ASABR_ENCOUNTER_ADMITSOURCE_CODE0E15( String A92BR_Encounter_AdmitSource )
      {
         GXt_char1 = A472BR_Encounter_AdmitSource_Code;
         new zutil_findtargetcode(context ).execute(  5,  A92BR_Encounter_AdmitSource, out  GXt_char1) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A92BR_Encounter_AdmitSource", A92BR_Encounter_AdmitSource);
         A472BR_Encounter_AdmitSource_Code = GXt_char1;
         n472BR_Encounter_AdmitSource_Code = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A472BR_Encounter_AdmitSource_Code", A472BR_Encounter_AdmitSource_Code);
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("[[");
         context.GX_webresponse.AddString("\""+GXUtil.EncodeJSConstant( A472BR_Encounter_AdmitSource_Code)+"\"");
         context.GX_webresponse.AddString("]");
         if ( true )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString("]");
      }

      protected void GX30ASABR_ENCOUNTER_ADMITSOURCE_CODE0E15( String A92BR_Encounter_AdmitSource )
      {
         GXt_char1 = A472BR_Encounter_AdmitSource_Code;
         new zutil_findtargetcode(context ).execute(  5,  A92BR_Encounter_AdmitSource, out  GXt_char1) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A92BR_Encounter_AdmitSource", A92BR_Encounter_AdmitSource);
         A472BR_Encounter_AdmitSource_Code = GXt_char1;
         n472BR_Encounter_AdmitSource_Code = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A472BR_Encounter_AdmitSource_Code", A472BR_Encounter_AdmitSource_Code);
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("[[");
         context.GX_webresponse.AddString("\""+GXUtil.EncodeJSConstant( A472BR_Encounter_AdmitSource_Code)+"\"");
         context.GX_webresponse.AddString("]");
         if ( true )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString("]");
      }

      protected void GX31ASABR_ENCOUNTER_DISCHARGESTATUS_CODE0E15( String A94BR_Encounter_DischargeStatus )
      {
         GXt_char1 = A473BR_Encounter_DischargeStatus_Code;
         new zutil_findtargetcode(context ).execute(  6,  A94BR_Encounter_DischargeStatus, out  GXt_char1) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A94BR_Encounter_DischargeStatus", A94BR_Encounter_DischargeStatus);
         A473BR_Encounter_DischargeStatus_Code = GXt_char1;
         n473BR_Encounter_DischargeStatus_Code = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A473BR_Encounter_DischargeStatus_Code", A473BR_Encounter_DischargeStatus_Code);
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("[[");
         context.GX_webresponse.AddString("\""+GXUtil.EncodeJSConstant( A473BR_Encounter_DischargeStatus_Code)+"\"");
         context.GX_webresponse.AddString("]");
         if ( true )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString("]");
      }

      protected void GX32ASABR_ENCOUNTER_DISCHARGESTATUS_CODE0E15( String A94BR_Encounter_DischargeStatus )
      {
         GXt_char1 = A473BR_Encounter_DischargeStatus_Code;
         new zutil_findtargetcode(context ).execute(  6,  A94BR_Encounter_DischargeStatus, out  GXt_char1) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A94BR_Encounter_DischargeStatus", A94BR_Encounter_DischargeStatus);
         A473BR_Encounter_DischargeStatus_Code = GXt_char1;
         n473BR_Encounter_DischargeStatus_Code = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A473BR_Encounter_DischargeStatus_Code", A473BR_Encounter_DischargeStatus_Code);
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("[[");
         context.GX_webresponse.AddString("\""+GXUtil.EncodeJSConstant( A473BR_Encounter_DischargeStatus_Code)+"\"");
         context.GX_webresponse.AddString("]");
         if ( true )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString("]");
      }

      protected void XC_46_0E15( )
      {
         new zutil_recordlog(context ).execute(  StringUtil.Str( (decimal)(A19BR_EncounterID), 18, 0),  "就诊信息",  "Create",  1) ;
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("[[");
         context.GX_webresponse.AddString("");
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
         dynBR_Encounter_Department.Name = "BR_ENCOUNTER_DEPARTMENT";
         dynBR_Encounter_Department.WebTags = "";
         dynBR_Encounter_ENCType.Name = "BR_ENCOUNTER_ENCTYPE";
         dynBR_Encounter_ENCType.WebTags = "";
         dynBR_Encounter_AdmitSource.Name = "BR_ENCOUNTER_ADMITSOURCE";
         dynBR_Encounter_AdmitSource.WebTags = "";
         dynBR_Encounter_DischargeStatus.Name = "BR_ENCOUNTER_DISCHARGESTATUS";
         dynBR_Encounter_DischargeStatus.WebTags = "";
         cmbBR_Encounter_Status.Name = "BR_ENCOUNTER_STATUS";
         cmbBR_Encounter_Status.WebTags = "";
         cmbBR_Encounter_Status.addItem(StringUtil.Trim( StringUtil.Str( (decimal)(0), 4, 0)), "(请选择)", 0);
         cmbBR_Encounter_Status.addItem("1", "录入中", 0);
         cmbBR_Encounter_Status.addItem("2", "待初审", 0);
         cmbBR_Encounter_Status.addItem("3", "初审不通过", 0);
         cmbBR_Encounter_Status.addItem("4", "待复审", 0);
         cmbBR_Encounter_Status.addItem("5", "复审不通过", 0);
         cmbBR_Encounter_Status.addItem("6", "完成", 0);
         if ( cmbBR_Encounter_Status.ItemCount > 0 )
         {
            A172BR_Encounter_Status = (short)(NumberUtil.Val( cmbBR_Encounter_Status.getValidValue(StringUtil.Trim( StringUtil.Str( (decimal)(A172BR_Encounter_Status), 4, 0))), "."));
            n172BR_Encounter_Status = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A172BR_Encounter_Status", StringUtil.LTrim( StringUtil.Str( (decimal)(A172BR_Encounter_Status), 4, 0)));
         }
         /* End function init_web_controls */
      }

      public void Valid_Br_information_id( long GX_Parm1 ,
                                           String GX_Parm2 )
      {
         A85BR_Information_ID = GX_Parm1;
         n85BR_Information_ID = false;
         A36BR_Information_PatientNo = GX_Parm2;
         n36BR_Information_PatientNo = false;
         /* Using cursor T000E37 */
         pr_default.execute(33, new Object[] {n85BR_Information_ID, A85BR_Information_ID});
         if ( (pr_default.getStatus(33) == 101) )
         {
            if ( ! ( (0==A85BR_Information_ID) ) )
            {
               GX_msglist.addItem("不匹配' T16'", "ForeignKeyNotFound", 1, "BR_INFORMATION_ID");
               AnyError = 1;
               GX_FocusControl = edtBR_Information_ID_Internalname;
            }
         }
         A36BR_Information_PatientNo = T000E37_A36BR_Information_PatientNo[0];
         n36BR_Information_PatientNo = T000E37_n36BR_Information_PatientNo[0];
         pr_default.close(33);
         if ( (0==A85BR_Information_ID) )
         {
            GX_msglist.addItem("患者是必须选择的", 1, "BR_INFORMATION_ID");
            AnyError = 1;
            GX_FocusControl = edtBR_Information_ID_Internalname;
         }
         dynload_actions( ) ;
         if ( AnyError == 1 )
         {
            A36BR_Information_PatientNo = "";
            n36BR_Information_PatientNo = false;
         }
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
         setEventMetadata("ENTER","{handler:'UserMainFullajax',iparms:[{postForm:true},{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV7BR_EncounterID',fld:'vBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true}]");
         setEventMetadata("ENTER",",oparms:[]}");
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV7BR_EncounterID',fld:'vBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true},{av:'A19BR_EncounterID',fld:'BR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV30tCurrentCode',fld:'vTCURRENTCODE',pic:''},{av:'AV8Insert_BR_Information_ID',fld:'vINSERT_BR_INFORMATION_ID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV29Insert_BAS_TenantTenantCode',fld:'vINSERT_BAS_TENANTTENANTCODE',pic:''},{av:'A570BR_Encounter_Departmentadm',fld:'BR_ENCOUNTER_DEPARTMENTADM',pic:''},{av:'A571BR_Encounter_Departmentadm_Code',fld:'BR_ENCOUNTER_DEPARTMENTADM_CODE',pic:''},{av:'A572BR_Encounter_Departmentdisch',fld:'BR_ENCOUNTER_DEPARTMENTDISCH',pic:''},{av:'A573BR_Encounter_Departmentdisch_Code',fld:'BR_ENCOUNTER_DEPARTMENTDISCH_CODE',pic:''},{av:'A574BR_Encounter_Insurance',fld:'BR_ENCOUNTER_INSURANCE',pic:''},{av:'A575BR_Encounter_Insurance_Code',fld:'BR_ENCOUNTER_INSURANCE_CODE',pic:''},{av:'A333BR_Encounter_IsDLT',fld:'BR_ENCOUNTER_ISDLT',pic:''},{av:'A184BR_Encounter_SubmitUser',fld:'BR_ENCOUNTER_SUBMITUSER',pic:''},{av:'A335BR_Encounter_Reason',fld:'BR_ENCOUNTER_REASON',pic:''},{av:'A185BR_Encounter_SubmitDate',fld:'BR_ENCOUNTER_SUBMITDATE',pic:'9999/99/99 99:99:99'},{av:'A188BR_Encounter_RecheckUser',fld:'BR_ENCOUNTER_RECHECKUSER',pic:''},{av:'A336BR_Encounter_FReason',fld:'BR_ENCOUNTER_FREASON',pic:''},{av:'A189BR_Encounter_RecheckDate',fld:'BR_ENCOUNTER_RECHECKDATE',pic:'9999/99/99 99:99:99'},{av:'A190BR_Encounter_Approver',fld:'BR_ENCOUNTER_APPROVER',pic:''},{av:'A191BR_Encounter_ApproveDate',fld:'BR_ENCOUNTER_APPROVEDATE',pic:'9999/99/99 99:99:99'},{av:'A192BR_Encounter_IsRandApprove',fld:'BR_ENCOUNTER_ISRANDAPPROVE',pic:''},{av:'A203BR_Encounter_IsRandApprover',fld:'BR_ENCOUNTER_ISRANDAPPROVER',pic:''},{av:'A204BR_Encounter_IsRandNoApprover',fld:'BR_ENCOUNTER_ISRANDNOAPPROVER',pic:''},{av:'A205BR_Encounter_IsRandApproveDate',fld:'BR_ENCOUNTER_ISRANDAPPROVEDATE',pic:'9999/99/99 99:99:99'},{av:'A206BR_Encounter_IsRandNoApproveDate',fld:'BR_ENCOUNTER_ISRANDNOAPPROVEDATE',pic:'9999/99/99 99:99:99'},{av:'A193BR_Encounter_IsRandRecheck',fld:'BR_ENCOUNTER_ISRANDRECHECK',pic:''},{av:'A207BR_Encounter_IsRandRecheckr',fld:'BR_ENCOUNTER_ISRANDRECHECKR',pic:''},{av:'A208BR_Encounter_IsRandNoRecheckr',fld:'BR_ENCOUNTER_ISRANDNORECHECKR',pic:''},{av:'A209BR_Encounter_IsRandRecheckDate',fld:'BR_ENCOUNTER_ISRANDRECHECKDATE',pic:'9999/99/99 99:99:99'},{av:'A210BR_Encounter_IsRandNoRecheckDate',fld:'BR_ENCOUNTER_ISRANDNORECHECKDATE',pic:'9999/99/99 99:99:99'},{av:'A202BR_Encounter_IsUpdate',fld:'BR_ENCOUNTER_ISUPDATE',pic:''},{av:'A537BR_Encounter_Datasource',fld:'BR_ENCOUNTER_DATASOURCE',pic:'ZZZ9'},{av:'A560EncounterIDEncrypt',fld:'ENCOUNTERIDENCRYPT',pic:''}]");
         setEventMetadata("REFRESH",",oparms:[]}");
         setEventMetadata("AFTER TRN","{handler:'E120E2',iparms:[{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV11TrnContext',fld:'vTRNCONTEXT',pic:''}]");
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
         pr_default.close(33);
         pr_default.close(13);
      }

      public override void initialize( )
      {
         sPrefix = "";
         wcpOGx_mode = "";
         Z183BR_Encounter_CrtUser = "";
         Z512BR_Encounter_CrtDisplayName = "";
         Z182BR_Encounter_CrtDate = (DateTime)(DateTime.MinValue);
         Z470BR_Encounter_Department_Code = "";
         Z471BR_Encounter_ENCType_Code = "";
         Z472BR_Encounter_AdmitSource_Code = "";
         Z473BR_Encounter_DischargeStatus_Code = "";
         Z84BR_Encounter_Department = "";
         Z570BR_Encounter_Departmentadm = "";
         Z571BR_Encounter_Departmentadm_Code = "";
         Z572BR_Encounter_Departmentdisch = "";
         Z573BR_Encounter_Departmentdisch_Code = "";
         Z90BR_Encounter_ENCType = "";
         Z91BR_Encounter_AdmitDate = DateTime.MinValue;
         Z92BR_Encounter_AdmitSource = "";
         Z93BR_Encounter_DischargeDate = DateTime.MinValue;
         Z94BR_Encounter_DischargeStatus = "";
         Z574BR_Encounter_Insurance = "";
         Z575BR_Encounter_Insurance_Code = "";
         Z187BR_Encounter_UpdDate = (DateTime)(DateTime.MinValue);
         Z186BR_Encounter_UpdUser = "";
         Z184BR_Encounter_SubmitUser = "";
         Z335BR_Encounter_Reason = "";
         Z185BR_Encounter_SubmitDate = (DateTime)(DateTime.MinValue);
         Z188BR_Encounter_RecheckUser = "";
         Z336BR_Encounter_FReason = "";
         Z189BR_Encounter_RecheckDate = (DateTime)(DateTime.MinValue);
         Z190BR_Encounter_Approver = "";
         Z191BR_Encounter_ApproveDate = (DateTime)(DateTime.MinValue);
         Z203BR_Encounter_IsRandApprover = "";
         Z204BR_Encounter_IsRandNoApprover = "";
         Z205BR_Encounter_IsRandApproveDate = (DateTime)(DateTime.MinValue);
         Z206BR_Encounter_IsRandNoApproveDate = (DateTime)(DateTime.MinValue);
         Z207BR_Encounter_IsRandRecheckr = "";
         Z208BR_Encounter_IsRandNoRecheckr = "";
         Z209BR_Encounter_IsRandRecheckDate = (DateTime)(DateTime.MinValue);
         Z210BR_Encounter_IsRandNoRecheckDate = (DateTime)(DateTime.MinValue);
         Z560EncounterIDEncrypt = "";
         Z360BAS_TenantTenantCode = "";
         N360BAS_TenantTenantCode = "";
         scmdbuf = "";
         gxfirstwebparm = "";
         gxfirstwebparm_bkp = "";
         AV30tCurrentCode = "";
         AV29Insert_BAS_TenantTenantCode = "";
         A84BR_Encounter_Department = "";
         A90BR_Encounter_ENCType = "";
         A92BR_Encounter_AdmitSource = "";
         A94BR_Encounter_DischargeStatus = "";
         A360BAS_TenantTenantCode = "";
         GXKey = "";
         PreviousTooltip = "";
         PreviousCaption = "";
         Form = new GXWebForm();
         GX_FocusControl = "";
         ClassString = "";
         StyleString = "";
         ucDvpanel_tableattributes = new GXUserControl();
         TempTags = "";
         sImgUrl = "";
         A36BR_Information_PatientNo = "";
         lblTextblockbr_encounter_department_Jsonclick = "";
         lblTextblockbr_encounter_enctype_Jsonclick = "";
         A91BR_Encounter_AdmitDate = DateTime.MinValue;
         lblTextblockbr_encounter_admitsource_Jsonclick = "";
         A93BR_Encounter_DischargeDate = DateTime.MinValue;
         bttBtntrn_enter_Jsonclick = "";
         bttBtntrn_cancel_Jsonclick = "";
         bttBtntrn_delete_Jsonclick = "";
         A182BR_Encounter_CrtDate = (DateTime)(DateTime.MinValue);
         A187BR_Encounter_UpdDate = (DateTime)(DateTime.MinValue);
         A183BR_Encounter_CrtUser = "";
         A186BR_Encounter_UpdUser = "";
         sStyleString = "";
         AV27vReason = "";
         AV26vENCType = "";
         AV24vDepartment = "";
         A512BR_Encounter_CrtDisplayName = "";
         A470BR_Encounter_Department_Code = "";
         A471BR_Encounter_ENCType_Code = "";
         A472BR_Encounter_AdmitSource_Code = "";
         A473BR_Encounter_DischargeStatus_Code = "";
         A570BR_Encounter_Departmentadm = "";
         A571BR_Encounter_Departmentadm_Code = "";
         A572BR_Encounter_Departmentdisch = "";
         A573BR_Encounter_Departmentdisch_Code = "";
         A574BR_Encounter_Insurance = "";
         A575BR_Encounter_Insurance_Code = "";
         A184BR_Encounter_SubmitUser = "";
         A335BR_Encounter_Reason = "";
         A185BR_Encounter_SubmitDate = (DateTime)(DateTime.MinValue);
         A188BR_Encounter_RecheckUser = "";
         A336BR_Encounter_FReason = "";
         A189BR_Encounter_RecheckDate = (DateTime)(DateTime.MinValue);
         A190BR_Encounter_Approver = "";
         A191BR_Encounter_ApproveDate = (DateTime)(DateTime.MinValue);
         A203BR_Encounter_IsRandApprover = "";
         A204BR_Encounter_IsRandNoApprover = "";
         A205BR_Encounter_IsRandApproveDate = (DateTime)(DateTime.MinValue);
         A206BR_Encounter_IsRandNoApproveDate = (DateTime)(DateTime.MinValue);
         A207BR_Encounter_IsRandRecheckr = "";
         A208BR_Encounter_IsRandNoRecheckr = "";
         A209BR_Encounter_IsRandRecheckDate = (DateTime)(DateTime.MinValue);
         A210BR_Encounter_IsRandNoRecheckDate = (DateTime)(DateTime.MinValue);
         A560EncounterIDEncrypt = "";
         AV32Pgmname = "";
         AV31Pgmdesc = "";
         Dvpanel_tableattributes_Objectcall = "";
         Dvpanel_tableattributes_Class = "";
         Dvpanel_tableattributes_Height = "";
         forbiddenHiddens = "";
         hsh = "";
         sMode15 = "";
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         AV14WWPContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPContext(context);
         AV11TrnContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext(context);
         AV13WebSession = context.GetSession();
         AV12TrnContextAtt = new GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext_Attribute(context);
         Z36BR_Information_PatientNo = "";
         T000E4_A36BR_Information_PatientNo = new String[] {""} ;
         T000E4_n36BR_Information_PatientNo = new bool[] {false} ;
         T000E7_A19BR_EncounterID = new long[1] ;
         T000E7_n19BR_EncounterID = new bool[] {false} ;
         T000E7_A35BR_Encounter_EncID = new long[1] ;
         T000E7_n35BR_Encounter_EncID = new bool[] {false} ;
         T000E7_A172BR_Encounter_Status = new short[1] ;
         T000E7_n172BR_Encounter_Status = new bool[] {false} ;
         T000E7_A183BR_Encounter_CrtUser = new String[] {""} ;
         T000E7_n183BR_Encounter_CrtUser = new bool[] {false} ;
         T000E7_A512BR_Encounter_CrtDisplayName = new String[] {""} ;
         T000E7_n512BR_Encounter_CrtDisplayName = new bool[] {false} ;
         T000E7_A182BR_Encounter_CrtDate = new DateTime[] {DateTime.MinValue} ;
         T000E7_n182BR_Encounter_CrtDate = new bool[] {false} ;
         T000E7_A470BR_Encounter_Department_Code = new String[] {""} ;
         T000E7_n470BR_Encounter_Department_Code = new bool[] {false} ;
         T000E7_A471BR_Encounter_ENCType_Code = new String[] {""} ;
         T000E7_n471BR_Encounter_ENCType_Code = new bool[] {false} ;
         T000E7_A472BR_Encounter_AdmitSource_Code = new String[] {""} ;
         T000E7_n472BR_Encounter_AdmitSource_Code = new bool[] {false} ;
         T000E7_A473BR_Encounter_DischargeStatus_Code = new String[] {""} ;
         T000E7_n473BR_Encounter_DischargeStatus_Code = new bool[] {false} ;
         T000E7_A84BR_Encounter_Department = new String[] {""} ;
         T000E7_n84BR_Encounter_Department = new bool[] {false} ;
         T000E7_A570BR_Encounter_Departmentadm = new String[] {""} ;
         T000E7_n570BR_Encounter_Departmentadm = new bool[] {false} ;
         T000E7_A571BR_Encounter_Departmentadm_Code = new String[] {""} ;
         T000E7_n571BR_Encounter_Departmentadm_Code = new bool[] {false} ;
         T000E7_A572BR_Encounter_Departmentdisch = new String[] {""} ;
         T000E7_n572BR_Encounter_Departmentdisch = new bool[] {false} ;
         T000E7_A573BR_Encounter_Departmentdisch_Code = new String[] {""} ;
         T000E7_n573BR_Encounter_Departmentdisch_Code = new bool[] {false} ;
         T000E7_A90BR_Encounter_ENCType = new String[] {""} ;
         T000E7_n90BR_Encounter_ENCType = new bool[] {false} ;
         T000E7_A91BR_Encounter_AdmitDate = new DateTime[] {DateTime.MinValue} ;
         T000E7_n91BR_Encounter_AdmitDate = new bool[] {false} ;
         T000E7_A92BR_Encounter_AdmitSource = new String[] {""} ;
         T000E7_n92BR_Encounter_AdmitSource = new bool[] {false} ;
         T000E7_A93BR_Encounter_DischargeDate = new DateTime[] {DateTime.MinValue} ;
         T000E7_n93BR_Encounter_DischargeDate = new bool[] {false} ;
         T000E7_A94BR_Encounter_DischargeStatus = new String[] {""} ;
         T000E7_n94BR_Encounter_DischargeStatus = new bool[] {false} ;
         T000E7_A574BR_Encounter_Insurance = new String[] {""} ;
         T000E7_n574BR_Encounter_Insurance = new bool[] {false} ;
         T000E7_A575BR_Encounter_Insurance_Code = new String[] {""} ;
         T000E7_n575BR_Encounter_Insurance_Code = new bool[] {false} ;
         T000E7_A36BR_Information_PatientNo = new String[] {""} ;
         T000E7_n36BR_Information_PatientNo = new bool[] {false} ;
         T000E7_A187BR_Encounter_UpdDate = new DateTime[] {DateTime.MinValue} ;
         T000E7_n187BR_Encounter_UpdDate = new bool[] {false} ;
         T000E7_A186BR_Encounter_UpdUser = new String[] {""} ;
         T000E7_n186BR_Encounter_UpdUser = new bool[] {false} ;
         T000E7_A333BR_Encounter_IsDLT = new bool[] {false} ;
         T000E7_n333BR_Encounter_IsDLT = new bool[] {false} ;
         T000E7_A184BR_Encounter_SubmitUser = new String[] {""} ;
         T000E7_n184BR_Encounter_SubmitUser = new bool[] {false} ;
         T000E7_A335BR_Encounter_Reason = new String[] {""} ;
         T000E7_n335BR_Encounter_Reason = new bool[] {false} ;
         T000E7_A185BR_Encounter_SubmitDate = new DateTime[] {DateTime.MinValue} ;
         T000E7_n185BR_Encounter_SubmitDate = new bool[] {false} ;
         T000E7_A188BR_Encounter_RecheckUser = new String[] {""} ;
         T000E7_n188BR_Encounter_RecheckUser = new bool[] {false} ;
         T000E7_A336BR_Encounter_FReason = new String[] {""} ;
         T000E7_n336BR_Encounter_FReason = new bool[] {false} ;
         T000E7_A189BR_Encounter_RecheckDate = new DateTime[] {DateTime.MinValue} ;
         T000E7_n189BR_Encounter_RecheckDate = new bool[] {false} ;
         T000E7_A190BR_Encounter_Approver = new String[] {""} ;
         T000E7_n190BR_Encounter_Approver = new bool[] {false} ;
         T000E7_A191BR_Encounter_ApproveDate = new DateTime[] {DateTime.MinValue} ;
         T000E7_n191BR_Encounter_ApproveDate = new bool[] {false} ;
         T000E7_A192BR_Encounter_IsRandApprove = new bool[] {false} ;
         T000E7_n192BR_Encounter_IsRandApprove = new bool[] {false} ;
         T000E7_A203BR_Encounter_IsRandApprover = new String[] {""} ;
         T000E7_n203BR_Encounter_IsRandApprover = new bool[] {false} ;
         T000E7_A204BR_Encounter_IsRandNoApprover = new String[] {""} ;
         T000E7_n204BR_Encounter_IsRandNoApprover = new bool[] {false} ;
         T000E7_A205BR_Encounter_IsRandApproveDate = new DateTime[] {DateTime.MinValue} ;
         T000E7_n205BR_Encounter_IsRandApproveDate = new bool[] {false} ;
         T000E7_A206BR_Encounter_IsRandNoApproveDate = new DateTime[] {DateTime.MinValue} ;
         T000E7_n206BR_Encounter_IsRandNoApproveDate = new bool[] {false} ;
         T000E7_A193BR_Encounter_IsRandRecheck = new bool[] {false} ;
         T000E7_n193BR_Encounter_IsRandRecheck = new bool[] {false} ;
         T000E7_A207BR_Encounter_IsRandRecheckr = new String[] {""} ;
         T000E7_n207BR_Encounter_IsRandRecheckr = new bool[] {false} ;
         T000E7_A208BR_Encounter_IsRandNoRecheckr = new String[] {""} ;
         T000E7_n208BR_Encounter_IsRandNoRecheckr = new bool[] {false} ;
         T000E7_A209BR_Encounter_IsRandRecheckDate = new DateTime[] {DateTime.MinValue} ;
         T000E7_n209BR_Encounter_IsRandRecheckDate = new bool[] {false} ;
         T000E7_A210BR_Encounter_IsRandNoRecheckDate = new DateTime[] {DateTime.MinValue} ;
         T000E7_n210BR_Encounter_IsRandNoRecheckDate = new bool[] {false} ;
         T000E7_A202BR_Encounter_IsUpdate = new bool[] {false} ;
         T000E7_n202BR_Encounter_IsUpdate = new bool[] {false} ;
         T000E7_A537BR_Encounter_Datasource = new short[1] ;
         T000E7_n537BR_Encounter_Datasource = new bool[] {false} ;
         T000E7_A560EncounterIDEncrypt = new String[] {""} ;
         T000E7_n560EncounterIDEncrypt = new bool[] {false} ;
         T000E7_A85BR_Information_ID = new long[1] ;
         T000E7_n85BR_Information_ID = new bool[] {false} ;
         T000E7_A360BAS_TenantTenantCode = new String[] {""} ;
         T000E7_n360BAS_TenantTenantCode = new bool[] {false} ;
         T000E6_A85BR_Information_ID = new long[1] ;
         T000E6_n85BR_Information_ID = new bool[] {false} ;
         T000E5_A360BAS_TenantTenantCode = new String[] {""} ;
         T000E5_n360BAS_TenantTenantCode = new bool[] {false} ;
         T000E8_A36BR_Information_PatientNo = new String[] {""} ;
         T000E8_n36BR_Information_PatientNo = new bool[] {false} ;
         T000E9_A85BR_Information_ID = new long[1] ;
         T000E9_n85BR_Information_ID = new bool[] {false} ;
         T000E10_A360BAS_TenantTenantCode = new String[] {""} ;
         T000E10_n360BAS_TenantTenantCode = new bool[] {false} ;
         T000E11_A19BR_EncounterID = new long[1] ;
         T000E11_n19BR_EncounterID = new bool[] {false} ;
         T000E3_A19BR_EncounterID = new long[1] ;
         T000E3_n19BR_EncounterID = new bool[] {false} ;
         T000E3_A35BR_Encounter_EncID = new long[1] ;
         T000E3_n35BR_Encounter_EncID = new bool[] {false} ;
         T000E3_A172BR_Encounter_Status = new short[1] ;
         T000E3_n172BR_Encounter_Status = new bool[] {false} ;
         T000E3_A183BR_Encounter_CrtUser = new String[] {""} ;
         T000E3_n183BR_Encounter_CrtUser = new bool[] {false} ;
         T000E3_A512BR_Encounter_CrtDisplayName = new String[] {""} ;
         T000E3_n512BR_Encounter_CrtDisplayName = new bool[] {false} ;
         T000E3_A182BR_Encounter_CrtDate = new DateTime[] {DateTime.MinValue} ;
         T000E3_n182BR_Encounter_CrtDate = new bool[] {false} ;
         T000E3_A470BR_Encounter_Department_Code = new String[] {""} ;
         T000E3_n470BR_Encounter_Department_Code = new bool[] {false} ;
         T000E3_A471BR_Encounter_ENCType_Code = new String[] {""} ;
         T000E3_n471BR_Encounter_ENCType_Code = new bool[] {false} ;
         T000E3_A472BR_Encounter_AdmitSource_Code = new String[] {""} ;
         T000E3_n472BR_Encounter_AdmitSource_Code = new bool[] {false} ;
         T000E3_A473BR_Encounter_DischargeStatus_Code = new String[] {""} ;
         T000E3_n473BR_Encounter_DischargeStatus_Code = new bool[] {false} ;
         T000E3_A84BR_Encounter_Department = new String[] {""} ;
         T000E3_n84BR_Encounter_Department = new bool[] {false} ;
         T000E3_A570BR_Encounter_Departmentadm = new String[] {""} ;
         T000E3_n570BR_Encounter_Departmentadm = new bool[] {false} ;
         T000E3_A571BR_Encounter_Departmentadm_Code = new String[] {""} ;
         T000E3_n571BR_Encounter_Departmentadm_Code = new bool[] {false} ;
         T000E3_A572BR_Encounter_Departmentdisch = new String[] {""} ;
         T000E3_n572BR_Encounter_Departmentdisch = new bool[] {false} ;
         T000E3_A573BR_Encounter_Departmentdisch_Code = new String[] {""} ;
         T000E3_n573BR_Encounter_Departmentdisch_Code = new bool[] {false} ;
         T000E3_A90BR_Encounter_ENCType = new String[] {""} ;
         T000E3_n90BR_Encounter_ENCType = new bool[] {false} ;
         T000E3_A91BR_Encounter_AdmitDate = new DateTime[] {DateTime.MinValue} ;
         T000E3_n91BR_Encounter_AdmitDate = new bool[] {false} ;
         T000E3_A92BR_Encounter_AdmitSource = new String[] {""} ;
         T000E3_n92BR_Encounter_AdmitSource = new bool[] {false} ;
         T000E3_A93BR_Encounter_DischargeDate = new DateTime[] {DateTime.MinValue} ;
         T000E3_n93BR_Encounter_DischargeDate = new bool[] {false} ;
         T000E3_A94BR_Encounter_DischargeStatus = new String[] {""} ;
         T000E3_n94BR_Encounter_DischargeStatus = new bool[] {false} ;
         T000E3_A574BR_Encounter_Insurance = new String[] {""} ;
         T000E3_n574BR_Encounter_Insurance = new bool[] {false} ;
         T000E3_A575BR_Encounter_Insurance_Code = new String[] {""} ;
         T000E3_n575BR_Encounter_Insurance_Code = new bool[] {false} ;
         T000E3_A187BR_Encounter_UpdDate = new DateTime[] {DateTime.MinValue} ;
         T000E3_n187BR_Encounter_UpdDate = new bool[] {false} ;
         T000E3_A186BR_Encounter_UpdUser = new String[] {""} ;
         T000E3_n186BR_Encounter_UpdUser = new bool[] {false} ;
         T000E3_A333BR_Encounter_IsDLT = new bool[] {false} ;
         T000E3_n333BR_Encounter_IsDLT = new bool[] {false} ;
         T000E3_A184BR_Encounter_SubmitUser = new String[] {""} ;
         T000E3_n184BR_Encounter_SubmitUser = new bool[] {false} ;
         T000E3_A335BR_Encounter_Reason = new String[] {""} ;
         T000E3_n335BR_Encounter_Reason = new bool[] {false} ;
         T000E3_A185BR_Encounter_SubmitDate = new DateTime[] {DateTime.MinValue} ;
         T000E3_n185BR_Encounter_SubmitDate = new bool[] {false} ;
         T000E3_A188BR_Encounter_RecheckUser = new String[] {""} ;
         T000E3_n188BR_Encounter_RecheckUser = new bool[] {false} ;
         T000E3_A336BR_Encounter_FReason = new String[] {""} ;
         T000E3_n336BR_Encounter_FReason = new bool[] {false} ;
         T000E3_A189BR_Encounter_RecheckDate = new DateTime[] {DateTime.MinValue} ;
         T000E3_n189BR_Encounter_RecheckDate = new bool[] {false} ;
         T000E3_A190BR_Encounter_Approver = new String[] {""} ;
         T000E3_n190BR_Encounter_Approver = new bool[] {false} ;
         T000E3_A191BR_Encounter_ApproveDate = new DateTime[] {DateTime.MinValue} ;
         T000E3_n191BR_Encounter_ApproveDate = new bool[] {false} ;
         T000E3_A192BR_Encounter_IsRandApprove = new bool[] {false} ;
         T000E3_n192BR_Encounter_IsRandApprove = new bool[] {false} ;
         T000E3_A203BR_Encounter_IsRandApprover = new String[] {""} ;
         T000E3_n203BR_Encounter_IsRandApprover = new bool[] {false} ;
         T000E3_A204BR_Encounter_IsRandNoApprover = new String[] {""} ;
         T000E3_n204BR_Encounter_IsRandNoApprover = new bool[] {false} ;
         T000E3_A205BR_Encounter_IsRandApproveDate = new DateTime[] {DateTime.MinValue} ;
         T000E3_n205BR_Encounter_IsRandApproveDate = new bool[] {false} ;
         T000E3_A206BR_Encounter_IsRandNoApproveDate = new DateTime[] {DateTime.MinValue} ;
         T000E3_n206BR_Encounter_IsRandNoApproveDate = new bool[] {false} ;
         T000E3_A193BR_Encounter_IsRandRecheck = new bool[] {false} ;
         T000E3_n193BR_Encounter_IsRandRecheck = new bool[] {false} ;
         T000E3_A207BR_Encounter_IsRandRecheckr = new String[] {""} ;
         T000E3_n207BR_Encounter_IsRandRecheckr = new bool[] {false} ;
         T000E3_A208BR_Encounter_IsRandNoRecheckr = new String[] {""} ;
         T000E3_n208BR_Encounter_IsRandNoRecheckr = new bool[] {false} ;
         T000E3_A209BR_Encounter_IsRandRecheckDate = new DateTime[] {DateTime.MinValue} ;
         T000E3_n209BR_Encounter_IsRandRecheckDate = new bool[] {false} ;
         T000E3_A210BR_Encounter_IsRandNoRecheckDate = new DateTime[] {DateTime.MinValue} ;
         T000E3_n210BR_Encounter_IsRandNoRecheckDate = new bool[] {false} ;
         T000E3_A202BR_Encounter_IsUpdate = new bool[] {false} ;
         T000E3_n202BR_Encounter_IsUpdate = new bool[] {false} ;
         T000E3_A537BR_Encounter_Datasource = new short[1] ;
         T000E3_n537BR_Encounter_Datasource = new bool[] {false} ;
         T000E3_A560EncounterIDEncrypt = new String[] {""} ;
         T000E3_n560EncounterIDEncrypt = new bool[] {false} ;
         T000E3_A85BR_Information_ID = new long[1] ;
         T000E3_n85BR_Information_ID = new bool[] {false} ;
         T000E3_A360BAS_TenantTenantCode = new String[] {""} ;
         T000E3_n360BAS_TenantTenantCode = new bool[] {false} ;
         T000E12_A19BR_EncounterID = new long[1] ;
         T000E12_n19BR_EncounterID = new bool[] {false} ;
         T000E13_A19BR_EncounterID = new long[1] ;
         T000E13_n19BR_EncounterID = new bool[] {false} ;
         T000E2_A19BR_EncounterID = new long[1] ;
         T000E2_n19BR_EncounterID = new bool[] {false} ;
         T000E2_A35BR_Encounter_EncID = new long[1] ;
         T000E2_n35BR_Encounter_EncID = new bool[] {false} ;
         T000E2_A172BR_Encounter_Status = new short[1] ;
         T000E2_n172BR_Encounter_Status = new bool[] {false} ;
         T000E2_A183BR_Encounter_CrtUser = new String[] {""} ;
         T000E2_n183BR_Encounter_CrtUser = new bool[] {false} ;
         T000E2_A512BR_Encounter_CrtDisplayName = new String[] {""} ;
         T000E2_n512BR_Encounter_CrtDisplayName = new bool[] {false} ;
         T000E2_A182BR_Encounter_CrtDate = new DateTime[] {DateTime.MinValue} ;
         T000E2_n182BR_Encounter_CrtDate = new bool[] {false} ;
         T000E2_A470BR_Encounter_Department_Code = new String[] {""} ;
         T000E2_n470BR_Encounter_Department_Code = new bool[] {false} ;
         T000E2_A471BR_Encounter_ENCType_Code = new String[] {""} ;
         T000E2_n471BR_Encounter_ENCType_Code = new bool[] {false} ;
         T000E2_A472BR_Encounter_AdmitSource_Code = new String[] {""} ;
         T000E2_n472BR_Encounter_AdmitSource_Code = new bool[] {false} ;
         T000E2_A473BR_Encounter_DischargeStatus_Code = new String[] {""} ;
         T000E2_n473BR_Encounter_DischargeStatus_Code = new bool[] {false} ;
         T000E2_A84BR_Encounter_Department = new String[] {""} ;
         T000E2_n84BR_Encounter_Department = new bool[] {false} ;
         T000E2_A570BR_Encounter_Departmentadm = new String[] {""} ;
         T000E2_n570BR_Encounter_Departmentadm = new bool[] {false} ;
         T000E2_A571BR_Encounter_Departmentadm_Code = new String[] {""} ;
         T000E2_n571BR_Encounter_Departmentadm_Code = new bool[] {false} ;
         T000E2_A572BR_Encounter_Departmentdisch = new String[] {""} ;
         T000E2_n572BR_Encounter_Departmentdisch = new bool[] {false} ;
         T000E2_A573BR_Encounter_Departmentdisch_Code = new String[] {""} ;
         T000E2_n573BR_Encounter_Departmentdisch_Code = new bool[] {false} ;
         T000E2_A90BR_Encounter_ENCType = new String[] {""} ;
         T000E2_n90BR_Encounter_ENCType = new bool[] {false} ;
         T000E2_A91BR_Encounter_AdmitDate = new DateTime[] {DateTime.MinValue} ;
         T000E2_n91BR_Encounter_AdmitDate = new bool[] {false} ;
         T000E2_A92BR_Encounter_AdmitSource = new String[] {""} ;
         T000E2_n92BR_Encounter_AdmitSource = new bool[] {false} ;
         T000E2_A93BR_Encounter_DischargeDate = new DateTime[] {DateTime.MinValue} ;
         T000E2_n93BR_Encounter_DischargeDate = new bool[] {false} ;
         T000E2_A94BR_Encounter_DischargeStatus = new String[] {""} ;
         T000E2_n94BR_Encounter_DischargeStatus = new bool[] {false} ;
         T000E2_A574BR_Encounter_Insurance = new String[] {""} ;
         T000E2_n574BR_Encounter_Insurance = new bool[] {false} ;
         T000E2_A575BR_Encounter_Insurance_Code = new String[] {""} ;
         T000E2_n575BR_Encounter_Insurance_Code = new bool[] {false} ;
         T000E2_A187BR_Encounter_UpdDate = new DateTime[] {DateTime.MinValue} ;
         T000E2_n187BR_Encounter_UpdDate = new bool[] {false} ;
         T000E2_A186BR_Encounter_UpdUser = new String[] {""} ;
         T000E2_n186BR_Encounter_UpdUser = new bool[] {false} ;
         T000E2_A333BR_Encounter_IsDLT = new bool[] {false} ;
         T000E2_n333BR_Encounter_IsDLT = new bool[] {false} ;
         T000E2_A184BR_Encounter_SubmitUser = new String[] {""} ;
         T000E2_n184BR_Encounter_SubmitUser = new bool[] {false} ;
         T000E2_A335BR_Encounter_Reason = new String[] {""} ;
         T000E2_n335BR_Encounter_Reason = new bool[] {false} ;
         T000E2_A185BR_Encounter_SubmitDate = new DateTime[] {DateTime.MinValue} ;
         T000E2_n185BR_Encounter_SubmitDate = new bool[] {false} ;
         T000E2_A188BR_Encounter_RecheckUser = new String[] {""} ;
         T000E2_n188BR_Encounter_RecheckUser = new bool[] {false} ;
         T000E2_A336BR_Encounter_FReason = new String[] {""} ;
         T000E2_n336BR_Encounter_FReason = new bool[] {false} ;
         T000E2_A189BR_Encounter_RecheckDate = new DateTime[] {DateTime.MinValue} ;
         T000E2_n189BR_Encounter_RecheckDate = new bool[] {false} ;
         T000E2_A190BR_Encounter_Approver = new String[] {""} ;
         T000E2_n190BR_Encounter_Approver = new bool[] {false} ;
         T000E2_A191BR_Encounter_ApproveDate = new DateTime[] {DateTime.MinValue} ;
         T000E2_n191BR_Encounter_ApproveDate = new bool[] {false} ;
         T000E2_A192BR_Encounter_IsRandApprove = new bool[] {false} ;
         T000E2_n192BR_Encounter_IsRandApprove = new bool[] {false} ;
         T000E2_A203BR_Encounter_IsRandApprover = new String[] {""} ;
         T000E2_n203BR_Encounter_IsRandApprover = new bool[] {false} ;
         T000E2_A204BR_Encounter_IsRandNoApprover = new String[] {""} ;
         T000E2_n204BR_Encounter_IsRandNoApprover = new bool[] {false} ;
         T000E2_A205BR_Encounter_IsRandApproveDate = new DateTime[] {DateTime.MinValue} ;
         T000E2_n205BR_Encounter_IsRandApproveDate = new bool[] {false} ;
         T000E2_A206BR_Encounter_IsRandNoApproveDate = new DateTime[] {DateTime.MinValue} ;
         T000E2_n206BR_Encounter_IsRandNoApproveDate = new bool[] {false} ;
         T000E2_A193BR_Encounter_IsRandRecheck = new bool[] {false} ;
         T000E2_n193BR_Encounter_IsRandRecheck = new bool[] {false} ;
         T000E2_A207BR_Encounter_IsRandRecheckr = new String[] {""} ;
         T000E2_n207BR_Encounter_IsRandRecheckr = new bool[] {false} ;
         T000E2_A208BR_Encounter_IsRandNoRecheckr = new String[] {""} ;
         T000E2_n208BR_Encounter_IsRandNoRecheckr = new bool[] {false} ;
         T000E2_A209BR_Encounter_IsRandRecheckDate = new DateTime[] {DateTime.MinValue} ;
         T000E2_n209BR_Encounter_IsRandRecheckDate = new bool[] {false} ;
         T000E2_A210BR_Encounter_IsRandNoRecheckDate = new DateTime[] {DateTime.MinValue} ;
         T000E2_n210BR_Encounter_IsRandNoRecheckDate = new bool[] {false} ;
         T000E2_A202BR_Encounter_IsUpdate = new bool[] {false} ;
         T000E2_n202BR_Encounter_IsUpdate = new bool[] {false} ;
         T000E2_A537BR_Encounter_Datasource = new short[1] ;
         T000E2_n537BR_Encounter_Datasource = new bool[] {false} ;
         T000E2_A560EncounterIDEncrypt = new String[] {""} ;
         T000E2_n560EncounterIDEncrypt = new bool[] {false} ;
         T000E2_A85BR_Information_ID = new long[1] ;
         T000E2_n85BR_Information_ID = new bool[] {false} ;
         T000E2_A360BAS_TenantTenantCode = new String[] {""} ;
         T000E2_n360BAS_TenantTenantCode = new bool[] {false} ;
         T000E14_A19BR_EncounterID = new long[1] ;
         T000E14_n19BR_EncounterID = new bool[] {false} ;
         T000E17_A36BR_Information_PatientNo = new String[] {""} ;
         T000E17_n36BR_Information_PatientNo = new bool[] {false} ;
         T000E18_A348BR_Encounter_RefuseReasonID = new long[1] ;
         T000E19_A347BR_Encounter_ID = new long[1] ;
         T000E20_A327BR_SchemeID = new long[1] ;
         T000E21_A226BR_PathologyID = new long[1] ;
         T000E22_A225BR_MedicalImagingID = new long[1] ;
         T000E23_A150BR_VitalID = new long[1] ;
         T000E24_A139BR_ProcedureID = new long[1] ;
         T000E25_A119BR_MedicationID = new long[1] ;
         T000E26_A101BR_LabID = new long[1] ;
         T000E27_A64BR_DiagnosisID = new long[1] ;
         T000E28_A61BR_Demographics_ID = new long[1] ;
         T000E29_A48BR_DeathID = new long[1] ;
         T000E30_A37BR_ComorbidityID = new long[1] ;
         T000E31_A20BR_BehaviorID = new long[1] ;
         T000E32_A19BR_EncounterID = new long[1] ;
         T000E32_n19BR_EncounterID = new bool[] {false} ;
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         gxdynajaxctrlcodr = new GeneXus.Utils.GxStringCollection();
         gxdynajaxctrldescr = new GeneXus.Utils.GxStringCollection();
         gxwrpcisep = "";
         T000E33_A167XT_DefineCodeID = new long[1] ;
         T000E33_A168XT_DefineCodeName = new String[] {""} ;
         T000E33_n168XT_DefineCodeName = new bool[] {false} ;
         T000E33_A165XT_DefindcodeTypeID = new long[1] ;
         T000E33_A432XT_TenantCode = new String[] {""} ;
         T000E33_n432XT_TenantCode = new bool[] {false} ;
         T000E34_A167XT_DefineCodeID = new long[1] ;
         T000E34_A168XT_DefineCodeName = new String[] {""} ;
         T000E34_n168XT_DefineCodeName = new bool[] {false} ;
         T000E34_A165XT_DefindcodeTypeID = new long[1] ;
         T000E34_A432XT_TenantCode = new String[] {""} ;
         T000E34_n432XT_TenantCode = new bool[] {false} ;
         T000E35_A167XT_DefineCodeID = new long[1] ;
         T000E35_A168XT_DefineCodeName = new String[] {""} ;
         T000E35_n168XT_DefineCodeName = new bool[] {false} ;
         T000E35_A165XT_DefindcodeTypeID = new long[1] ;
         T000E35_A432XT_TenantCode = new String[] {""} ;
         T000E35_n432XT_TenantCode = new bool[] {false} ;
         T000E36_A167XT_DefineCodeID = new long[1] ;
         T000E36_A168XT_DefineCodeName = new String[] {""} ;
         T000E36_n168XT_DefineCodeName = new bool[] {false} ;
         T000E36_A165XT_DefindcodeTypeID = new long[1] ;
         T000E36_A432XT_TenantCode = new String[] {""} ;
         T000E36_n432XT_TenantCode = new bool[] {false} ;
         GXt_char1 = "";
         T000E37_A36BR_Information_PatientNo = new String[] {""} ;
         T000E37_n36BR_Information_PatientNo = new bool[] {false} ;
         isValidOutput = new GxUnknownObjectCollection();
         pr_datastore1 = new DataStoreProvider(context, new GeneXus.Programs.br_encounter__datastore1(),
            new Object[][] {
                new Object[] {
               T000E5_A360BAS_TenantTenantCode
               }
               , new Object[] {
               T000E10_A360BAS_TenantTenantCode
               }
            }
         );
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.br_encounter__default(),
            new Object[][] {
                new Object[] {
               T000E2_A19BR_EncounterID, T000E2_A35BR_Encounter_EncID, T000E2_n35BR_Encounter_EncID, T000E2_A172BR_Encounter_Status, T000E2_n172BR_Encounter_Status, T000E2_A183BR_Encounter_CrtUser, T000E2_n183BR_Encounter_CrtUser, T000E2_A512BR_Encounter_CrtDisplayName, T000E2_n512BR_Encounter_CrtDisplayName, T000E2_A182BR_Encounter_CrtDate,
               T000E2_n182BR_Encounter_CrtDate, T000E2_A470BR_Encounter_Department_Code, T000E2_n470BR_Encounter_Department_Code, T000E2_A471BR_Encounter_ENCType_Code, T000E2_n471BR_Encounter_ENCType_Code, T000E2_A472BR_Encounter_AdmitSource_Code, T000E2_n472BR_Encounter_AdmitSource_Code, T000E2_A473BR_Encounter_DischargeStatus_Code, T000E2_n473BR_Encounter_DischargeStatus_Code, T000E2_A84BR_Encounter_Department,
               T000E2_n84BR_Encounter_Department, T000E2_A570BR_Encounter_Departmentadm, T000E2_n570BR_Encounter_Departmentadm, T000E2_A571BR_Encounter_Departmentadm_Code, T000E2_n571BR_Encounter_Departmentadm_Code, T000E2_A572BR_Encounter_Departmentdisch, T000E2_n572BR_Encounter_Departmentdisch, T000E2_A573BR_Encounter_Departmentdisch_Code, T000E2_n573BR_Encounter_Departmentdisch_Code, T000E2_A90BR_Encounter_ENCType,
               T000E2_n90BR_Encounter_ENCType, T000E2_A91BR_Encounter_AdmitDate, T000E2_n91BR_Encounter_AdmitDate, T000E2_A92BR_Encounter_AdmitSource, T000E2_n92BR_Encounter_AdmitSource, T000E2_A93BR_Encounter_DischargeDate, T000E2_n93BR_Encounter_DischargeDate, T000E2_A94BR_Encounter_DischargeStatus, T000E2_n94BR_Encounter_DischargeStatus, T000E2_A574BR_Encounter_Insurance,
               T000E2_n574BR_Encounter_Insurance, T000E2_A575BR_Encounter_Insurance_Code, T000E2_n575BR_Encounter_Insurance_Code, T000E2_A187BR_Encounter_UpdDate, T000E2_n187BR_Encounter_UpdDate, T000E2_A186BR_Encounter_UpdUser, T000E2_n186BR_Encounter_UpdUser, T000E2_A333BR_Encounter_IsDLT, T000E2_n333BR_Encounter_IsDLT, T000E2_A184BR_Encounter_SubmitUser,
               T000E2_n184BR_Encounter_SubmitUser, T000E2_A335BR_Encounter_Reason, T000E2_n335BR_Encounter_Reason, T000E2_A185BR_Encounter_SubmitDate, T000E2_n185BR_Encounter_SubmitDate, T000E2_A188BR_Encounter_RecheckUser, T000E2_n188BR_Encounter_RecheckUser, T000E2_A336BR_Encounter_FReason, T000E2_n336BR_Encounter_FReason, T000E2_A189BR_Encounter_RecheckDate,
               T000E2_n189BR_Encounter_RecheckDate, T000E2_A190BR_Encounter_Approver, T000E2_n190BR_Encounter_Approver, T000E2_A191BR_Encounter_ApproveDate, T000E2_n191BR_Encounter_ApproveDate, T000E2_A192BR_Encounter_IsRandApprove, T000E2_n192BR_Encounter_IsRandApprove, T000E2_A203BR_Encounter_IsRandApprover, T000E2_n203BR_Encounter_IsRandApprover, T000E2_A204BR_Encounter_IsRandNoApprover,
               T000E2_n204BR_Encounter_IsRandNoApprover, T000E2_A205BR_Encounter_IsRandApproveDate, T000E2_n205BR_Encounter_IsRandApproveDate, T000E2_A206BR_Encounter_IsRandNoApproveDate, T000E2_n206BR_Encounter_IsRandNoApproveDate, T000E2_A193BR_Encounter_IsRandRecheck, T000E2_n193BR_Encounter_IsRandRecheck, T000E2_A207BR_Encounter_IsRandRecheckr, T000E2_n207BR_Encounter_IsRandRecheckr, T000E2_A208BR_Encounter_IsRandNoRecheckr,
               T000E2_n208BR_Encounter_IsRandNoRecheckr, T000E2_A209BR_Encounter_IsRandRecheckDate, T000E2_n209BR_Encounter_IsRandRecheckDate, T000E2_A210BR_Encounter_IsRandNoRecheckDate, T000E2_n210BR_Encounter_IsRandNoRecheckDate, T000E2_A202BR_Encounter_IsUpdate, T000E2_n202BR_Encounter_IsUpdate, T000E2_A537BR_Encounter_Datasource, T000E2_n537BR_Encounter_Datasource, T000E2_A560EncounterIDEncrypt,
               T000E2_n560EncounterIDEncrypt, T000E2_A85BR_Information_ID, T000E2_n85BR_Information_ID, T000E2_A360BAS_TenantTenantCode, T000E2_n360BAS_TenantTenantCode
               }
               , new Object[] {
               T000E3_A19BR_EncounterID, T000E3_A35BR_Encounter_EncID, T000E3_n35BR_Encounter_EncID, T000E3_A172BR_Encounter_Status, T000E3_n172BR_Encounter_Status, T000E3_A183BR_Encounter_CrtUser, T000E3_n183BR_Encounter_CrtUser, T000E3_A512BR_Encounter_CrtDisplayName, T000E3_n512BR_Encounter_CrtDisplayName, T000E3_A182BR_Encounter_CrtDate,
               T000E3_n182BR_Encounter_CrtDate, T000E3_A470BR_Encounter_Department_Code, T000E3_n470BR_Encounter_Department_Code, T000E3_A471BR_Encounter_ENCType_Code, T000E3_n471BR_Encounter_ENCType_Code, T000E3_A472BR_Encounter_AdmitSource_Code, T000E3_n472BR_Encounter_AdmitSource_Code, T000E3_A473BR_Encounter_DischargeStatus_Code, T000E3_n473BR_Encounter_DischargeStatus_Code, T000E3_A84BR_Encounter_Department,
               T000E3_n84BR_Encounter_Department, T000E3_A570BR_Encounter_Departmentadm, T000E3_n570BR_Encounter_Departmentadm, T000E3_A571BR_Encounter_Departmentadm_Code, T000E3_n571BR_Encounter_Departmentadm_Code, T000E3_A572BR_Encounter_Departmentdisch, T000E3_n572BR_Encounter_Departmentdisch, T000E3_A573BR_Encounter_Departmentdisch_Code, T000E3_n573BR_Encounter_Departmentdisch_Code, T000E3_A90BR_Encounter_ENCType,
               T000E3_n90BR_Encounter_ENCType, T000E3_A91BR_Encounter_AdmitDate, T000E3_n91BR_Encounter_AdmitDate, T000E3_A92BR_Encounter_AdmitSource, T000E3_n92BR_Encounter_AdmitSource, T000E3_A93BR_Encounter_DischargeDate, T000E3_n93BR_Encounter_DischargeDate, T000E3_A94BR_Encounter_DischargeStatus, T000E3_n94BR_Encounter_DischargeStatus, T000E3_A574BR_Encounter_Insurance,
               T000E3_n574BR_Encounter_Insurance, T000E3_A575BR_Encounter_Insurance_Code, T000E3_n575BR_Encounter_Insurance_Code, T000E3_A187BR_Encounter_UpdDate, T000E3_n187BR_Encounter_UpdDate, T000E3_A186BR_Encounter_UpdUser, T000E3_n186BR_Encounter_UpdUser, T000E3_A333BR_Encounter_IsDLT, T000E3_n333BR_Encounter_IsDLT, T000E3_A184BR_Encounter_SubmitUser,
               T000E3_n184BR_Encounter_SubmitUser, T000E3_A335BR_Encounter_Reason, T000E3_n335BR_Encounter_Reason, T000E3_A185BR_Encounter_SubmitDate, T000E3_n185BR_Encounter_SubmitDate, T000E3_A188BR_Encounter_RecheckUser, T000E3_n188BR_Encounter_RecheckUser, T000E3_A336BR_Encounter_FReason, T000E3_n336BR_Encounter_FReason, T000E3_A189BR_Encounter_RecheckDate,
               T000E3_n189BR_Encounter_RecheckDate, T000E3_A190BR_Encounter_Approver, T000E3_n190BR_Encounter_Approver, T000E3_A191BR_Encounter_ApproveDate, T000E3_n191BR_Encounter_ApproveDate, T000E3_A192BR_Encounter_IsRandApprove, T000E3_n192BR_Encounter_IsRandApprove, T000E3_A203BR_Encounter_IsRandApprover, T000E3_n203BR_Encounter_IsRandApprover, T000E3_A204BR_Encounter_IsRandNoApprover,
               T000E3_n204BR_Encounter_IsRandNoApprover, T000E3_A205BR_Encounter_IsRandApproveDate, T000E3_n205BR_Encounter_IsRandApproveDate, T000E3_A206BR_Encounter_IsRandNoApproveDate, T000E3_n206BR_Encounter_IsRandNoApproveDate, T000E3_A193BR_Encounter_IsRandRecheck, T000E3_n193BR_Encounter_IsRandRecheck, T000E3_A207BR_Encounter_IsRandRecheckr, T000E3_n207BR_Encounter_IsRandRecheckr, T000E3_A208BR_Encounter_IsRandNoRecheckr,
               T000E3_n208BR_Encounter_IsRandNoRecheckr, T000E3_A209BR_Encounter_IsRandRecheckDate, T000E3_n209BR_Encounter_IsRandRecheckDate, T000E3_A210BR_Encounter_IsRandNoRecheckDate, T000E3_n210BR_Encounter_IsRandNoRecheckDate, T000E3_A202BR_Encounter_IsUpdate, T000E3_n202BR_Encounter_IsUpdate, T000E3_A537BR_Encounter_Datasource, T000E3_n537BR_Encounter_Datasource, T000E3_A560EncounterIDEncrypt,
               T000E3_n560EncounterIDEncrypt, T000E3_A85BR_Information_ID, T000E3_n85BR_Information_ID, T000E3_A360BAS_TenantTenantCode, T000E3_n360BAS_TenantTenantCode
               }
               , new Object[] {
               T000E4_A36BR_Information_PatientNo, T000E4_n36BR_Information_PatientNo
               }
               , new Object[] {
               T000E6_A85BR_Information_ID
               }
               , new Object[] {
               T000E7_A19BR_EncounterID, T000E7_A35BR_Encounter_EncID, T000E7_n35BR_Encounter_EncID, T000E7_A172BR_Encounter_Status, T000E7_n172BR_Encounter_Status, T000E7_A183BR_Encounter_CrtUser, T000E7_n183BR_Encounter_CrtUser, T000E7_A512BR_Encounter_CrtDisplayName, T000E7_n512BR_Encounter_CrtDisplayName, T000E7_A182BR_Encounter_CrtDate,
               T000E7_n182BR_Encounter_CrtDate, T000E7_A470BR_Encounter_Department_Code, T000E7_n470BR_Encounter_Department_Code, T000E7_A471BR_Encounter_ENCType_Code, T000E7_n471BR_Encounter_ENCType_Code, T000E7_A472BR_Encounter_AdmitSource_Code, T000E7_n472BR_Encounter_AdmitSource_Code, T000E7_A473BR_Encounter_DischargeStatus_Code, T000E7_n473BR_Encounter_DischargeStatus_Code, T000E7_A84BR_Encounter_Department,
               T000E7_n84BR_Encounter_Department, T000E7_A570BR_Encounter_Departmentadm, T000E7_n570BR_Encounter_Departmentadm, T000E7_A571BR_Encounter_Departmentadm_Code, T000E7_n571BR_Encounter_Departmentadm_Code, T000E7_A572BR_Encounter_Departmentdisch, T000E7_n572BR_Encounter_Departmentdisch, T000E7_A573BR_Encounter_Departmentdisch_Code, T000E7_n573BR_Encounter_Departmentdisch_Code, T000E7_A90BR_Encounter_ENCType,
               T000E7_n90BR_Encounter_ENCType, T000E7_A91BR_Encounter_AdmitDate, T000E7_n91BR_Encounter_AdmitDate, T000E7_A92BR_Encounter_AdmitSource, T000E7_n92BR_Encounter_AdmitSource, T000E7_A93BR_Encounter_DischargeDate, T000E7_n93BR_Encounter_DischargeDate, T000E7_A94BR_Encounter_DischargeStatus, T000E7_n94BR_Encounter_DischargeStatus, T000E7_A574BR_Encounter_Insurance,
               T000E7_n574BR_Encounter_Insurance, T000E7_A575BR_Encounter_Insurance_Code, T000E7_n575BR_Encounter_Insurance_Code, T000E7_A36BR_Information_PatientNo, T000E7_n36BR_Information_PatientNo, T000E7_A187BR_Encounter_UpdDate, T000E7_n187BR_Encounter_UpdDate, T000E7_A186BR_Encounter_UpdUser, T000E7_n186BR_Encounter_UpdUser, T000E7_A333BR_Encounter_IsDLT,
               T000E7_n333BR_Encounter_IsDLT, T000E7_A184BR_Encounter_SubmitUser, T000E7_n184BR_Encounter_SubmitUser, T000E7_A335BR_Encounter_Reason, T000E7_n335BR_Encounter_Reason, T000E7_A185BR_Encounter_SubmitDate, T000E7_n185BR_Encounter_SubmitDate, T000E7_A188BR_Encounter_RecheckUser, T000E7_n188BR_Encounter_RecheckUser, T000E7_A336BR_Encounter_FReason,
               T000E7_n336BR_Encounter_FReason, T000E7_A189BR_Encounter_RecheckDate, T000E7_n189BR_Encounter_RecheckDate, T000E7_A190BR_Encounter_Approver, T000E7_n190BR_Encounter_Approver, T000E7_A191BR_Encounter_ApproveDate, T000E7_n191BR_Encounter_ApproveDate, T000E7_A192BR_Encounter_IsRandApprove, T000E7_n192BR_Encounter_IsRandApprove, T000E7_A203BR_Encounter_IsRandApprover,
               T000E7_n203BR_Encounter_IsRandApprover, T000E7_A204BR_Encounter_IsRandNoApprover, T000E7_n204BR_Encounter_IsRandNoApprover, T000E7_A205BR_Encounter_IsRandApproveDate, T000E7_n205BR_Encounter_IsRandApproveDate, T000E7_A206BR_Encounter_IsRandNoApproveDate, T000E7_n206BR_Encounter_IsRandNoApproveDate, T000E7_A193BR_Encounter_IsRandRecheck, T000E7_n193BR_Encounter_IsRandRecheck, T000E7_A207BR_Encounter_IsRandRecheckr,
               T000E7_n207BR_Encounter_IsRandRecheckr, T000E7_A208BR_Encounter_IsRandNoRecheckr, T000E7_n208BR_Encounter_IsRandNoRecheckr, T000E7_A209BR_Encounter_IsRandRecheckDate, T000E7_n209BR_Encounter_IsRandRecheckDate, T000E7_A210BR_Encounter_IsRandNoRecheckDate, T000E7_n210BR_Encounter_IsRandNoRecheckDate, T000E7_A202BR_Encounter_IsUpdate, T000E7_n202BR_Encounter_IsUpdate, T000E7_A537BR_Encounter_Datasource,
               T000E7_n537BR_Encounter_Datasource, T000E7_A560EncounterIDEncrypt, T000E7_n560EncounterIDEncrypt, T000E7_A85BR_Information_ID, T000E7_n85BR_Information_ID, T000E7_A360BAS_TenantTenantCode, T000E7_n360BAS_TenantTenantCode
               }
               , new Object[] {
               T000E8_A36BR_Information_PatientNo, T000E8_n36BR_Information_PatientNo
               }
               , new Object[] {
               T000E9_A85BR_Information_ID
               }
               , new Object[] {
               T000E11_A19BR_EncounterID
               }
               , new Object[] {
               T000E12_A19BR_EncounterID
               }
               , new Object[] {
               T000E13_A19BR_EncounterID
               }
               , new Object[] {
               T000E14_A19BR_EncounterID
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               T000E17_A36BR_Information_PatientNo, T000E17_n36BR_Information_PatientNo
               }
               , new Object[] {
               T000E18_A348BR_Encounter_RefuseReasonID
               }
               , new Object[] {
               T000E19_A347BR_Encounter_ID
               }
               , new Object[] {
               T000E20_A327BR_SchemeID
               }
               , new Object[] {
               T000E21_A226BR_PathologyID
               }
               , new Object[] {
               T000E22_A225BR_MedicalImagingID
               }
               , new Object[] {
               T000E23_A150BR_VitalID
               }
               , new Object[] {
               T000E24_A139BR_ProcedureID
               }
               , new Object[] {
               T000E25_A119BR_MedicationID
               }
               , new Object[] {
               T000E26_A101BR_LabID
               }
               , new Object[] {
               T000E27_A64BR_DiagnosisID
               }
               , new Object[] {
               T000E28_A61BR_Demographics_ID
               }
               , new Object[] {
               T000E29_A48BR_DeathID
               }
               , new Object[] {
               T000E30_A37BR_ComorbidityID
               }
               , new Object[] {
               T000E31_A20BR_BehaviorID
               }
               , new Object[] {
               T000E32_A19BR_EncounterID
               }
               , new Object[] {
               T000E33_A167XT_DefineCodeID, T000E33_A168XT_DefineCodeName, T000E33_n168XT_DefineCodeName, T000E33_A165XT_DefindcodeTypeID, T000E33_A432XT_TenantCode, T000E33_n432XT_TenantCode
               }
               , new Object[] {
               T000E34_A167XT_DefineCodeID, T000E34_A168XT_DefineCodeName, T000E34_n168XT_DefineCodeName, T000E34_A165XT_DefindcodeTypeID, T000E34_A432XT_TenantCode, T000E34_n432XT_TenantCode
               }
               , new Object[] {
               T000E35_A167XT_DefineCodeID, T000E35_A168XT_DefineCodeName, T000E35_n168XT_DefineCodeName, T000E35_A165XT_DefindcodeTypeID, T000E35_A432XT_TenantCode, T000E35_n432XT_TenantCode
               }
               , new Object[] {
               T000E36_A167XT_DefineCodeID, T000E36_A168XT_DefineCodeName, T000E36_n168XT_DefineCodeName, T000E36_A165XT_DefindcodeTypeID, T000E36_A432XT_TenantCode, T000E36_n432XT_TenantCode
               }
               , new Object[] {
               T000E37_A36BR_Information_PatientNo, T000E37_n36BR_Information_PatientNo
               }
            }
         );
         AV32Pgmname = "BR_Encounter";
         AV31Pgmdesc = "就诊信息";
      }

      private short Z172BR_Encounter_Status ;
      private short Z537BR_Encounter_Datasource ;
      private short GxWebError ;
      private short gxcookieaux ;
      private short IsConfirmed ;
      private short IsModified ;
      private short AnyError ;
      private short nKeyPressed ;
      private short initialized ;
      private short A172BR_Encounter_Status ;
      private short A537BR_Encounter_Datasource ;
      private short RcdFound15 ;
      private short GX_JID ;
      private short Gx_BScreen ;
      private short gxajaxcallmode ;
      private short wbTemp ;
      private int trnEnded ;
      private int edtBR_Information_ID_Enabled ;
      private int imgprompt_85_Visible ;
      private int edtBR_Information_PatientNo_Enabled ;
      private int edtBR_Encounter_AdmitDate_Enabled ;
      private int edtBR_Encounter_DischargeDate_Enabled ;
      private int bttBtntrn_enter_Visible ;
      private int bttBtntrn_enter_Enabled ;
      private int bttBtntrn_cancel_Visible ;
      private int bttBtntrn_delete_Visible ;
      private int bttBtntrn_delete_Enabled ;
      private int edtBR_EncounterID_Enabled ;
      private int edtBR_EncounterID_Visible ;
      private int edtBR_Encounter_EncID_Enabled ;
      private int edtBR_Encounter_EncID_Visible ;
      private int edtBR_Encounter_CrtDate_Visible ;
      private int edtBR_Encounter_CrtDate_Enabled ;
      private int edtBR_Encounter_UpdDate_Visible ;
      private int edtBR_Encounter_UpdDate_Enabled ;
      private int edtBR_Encounter_CrtUser_Visible ;
      private int edtBR_Encounter_CrtUser_Enabled ;
      private int edtBR_Encounter_UpdUser_Visible ;
      private int edtBR_Encounter_UpdUser_Enabled ;
      private int edtavVreason_Visible ;
      private int edtavVreason_Enabled ;
      private int edtavVenctype_Visible ;
      private int edtavVenctype_Enabled ;
      private int edtavVdepartment_Visible ;
      private int edtavVdepartment_Enabled ;
      private int AV33GXV1 ;
      private int idxLst ;
      private int gxdynajaxindex ;
      private long wcpOAV7BR_EncounterID ;
      private long Z19BR_EncounterID ;
      private long Z35BR_Encounter_EncID ;
      private long Z85BR_Information_ID ;
      private long N85BR_Information_ID ;
      private long A85BR_Information_ID ;
      private long AV7BR_EncounterID ;
      private long A19BR_EncounterID ;
      private long A35BR_Encounter_EncID ;
      private long AV8Insert_BR_Information_ID ;
      private long GXt_int3 ;
      private String sPrefix ;
      private String wcpOGx_mode ;
      private String scmdbuf ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String Gx_mode ;
      private String GXKey ;
      private String PreviousTooltip ;
      private String PreviousCaption ;
      private String GX_FocusControl ;
      private String edtBR_Information_ID_Internalname ;
      private String dynBR_Encounter_Department_Internalname ;
      private String dynBR_Encounter_ENCType_Internalname ;
      private String dynBR_Encounter_AdmitSource_Internalname ;
      private String dynBR_Encounter_DischargeStatus_Internalname ;
      private String cmbBR_Encounter_Status_Internalname ;
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
      private String edtBR_Information_ID_Jsonclick ;
      private String sImgUrl ;
      private String imgprompt_85_Internalname ;
      private String imgprompt_85_Link ;
      private String edtBR_Information_PatientNo_Internalname ;
      private String edtBR_Information_PatientNo_Jsonclick ;
      private String divTablesplittedbr_encounter_department_Internalname ;
      private String lblTextblockbr_encounter_department_Internalname ;
      private String lblTextblockbr_encounter_department_Jsonclick ;
      private String divTablesplittedbr_encounter_enctype_Internalname ;
      private String lblTextblockbr_encounter_enctype_Internalname ;
      private String lblTextblockbr_encounter_enctype_Jsonclick ;
      private String edtBR_Encounter_AdmitDate_Internalname ;
      private String edtBR_Encounter_AdmitDate_Jsonclick ;
      private String divTablesplittedbr_encounter_admitsource_Internalname ;
      private String lblTextblockbr_encounter_admitsource_Internalname ;
      private String lblTextblockbr_encounter_admitsource_Jsonclick ;
      private String edtBR_Encounter_DischargeDate_Internalname ;
      private String edtBR_Encounter_DischargeDate_Jsonclick ;
      private String dynBR_Encounter_DischargeStatus_Jsonclick ;
      private String bttBtntrn_enter_Internalname ;
      private String bttBtntrn_enter_Jsonclick ;
      private String bttBtntrn_cancel_Internalname ;
      private String bttBtntrn_cancel_Jsonclick ;
      private String bttBtntrn_delete_Internalname ;
      private String bttBtntrn_delete_Jsonclick ;
      private String divHtml_bottomauxiliarcontrols_Internalname ;
      private String edtBR_EncounterID_Internalname ;
      private String edtBR_EncounterID_Jsonclick ;
      private String edtBR_Encounter_EncID_Internalname ;
      private String edtBR_Encounter_EncID_Jsonclick ;
      private String cmbBR_Encounter_Status_Jsonclick ;
      private String edtBR_Encounter_CrtDate_Internalname ;
      private String edtBR_Encounter_CrtDate_Jsonclick ;
      private String edtBR_Encounter_UpdDate_Internalname ;
      private String edtBR_Encounter_UpdDate_Jsonclick ;
      private String edtBR_Encounter_CrtUser_Internalname ;
      private String edtBR_Encounter_CrtUser_Jsonclick ;
      private String edtBR_Encounter_UpdUser_Internalname ;
      private String edtBR_Encounter_UpdUser_Jsonclick ;
      private String sStyleString ;
      private String tblTablemergedbr_encounter_admitsource_Internalname ;
      private String dynBR_Encounter_AdmitSource_Jsonclick ;
      private String cellVreason_cell_Internalname ;
      private String cellVreason_cell_Class ;
      private String edtavVreason_Internalname ;
      private String edtavVreason_Jsonclick ;
      private String tblTablemergedbr_encounter_enctype_Internalname ;
      private String dynBR_Encounter_ENCType_Jsonclick ;
      private String cellVenctype_cell_Internalname ;
      private String cellVenctype_cell_Class ;
      private String edtavVenctype_Internalname ;
      private String edtavVenctype_Jsonclick ;
      private String tblTablemergedbr_encounter_department_Internalname ;
      private String dynBR_Encounter_Department_Jsonclick ;
      private String cellVdepartment_cell_Internalname ;
      private String cellVdepartment_cell_Class ;
      private String edtavVdepartment_Internalname ;
      private String edtavVdepartment_Jsonclick ;
      private String AV32Pgmname ;
      private String AV31Pgmdesc ;
      private String Dvpanel_tableattributes_Objectcall ;
      private String Dvpanel_tableattributes_Class ;
      private String Dvpanel_tableattributes_Height ;
      private String forbiddenHiddens ;
      private String hsh ;
      private String sMode15 ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String sDynURL ;
      private String FormProcess ;
      private String bodyStyle ;
      private String gxwrpcisep ;
      private String GXt_char1 ;
      private DateTime Z182BR_Encounter_CrtDate ;
      private DateTime Z187BR_Encounter_UpdDate ;
      private DateTime Z185BR_Encounter_SubmitDate ;
      private DateTime Z189BR_Encounter_RecheckDate ;
      private DateTime Z191BR_Encounter_ApproveDate ;
      private DateTime Z205BR_Encounter_IsRandApproveDate ;
      private DateTime Z206BR_Encounter_IsRandNoApproveDate ;
      private DateTime Z209BR_Encounter_IsRandRecheckDate ;
      private DateTime Z210BR_Encounter_IsRandNoRecheckDate ;
      private DateTime A182BR_Encounter_CrtDate ;
      private DateTime A187BR_Encounter_UpdDate ;
      private DateTime A185BR_Encounter_SubmitDate ;
      private DateTime A189BR_Encounter_RecheckDate ;
      private DateTime A191BR_Encounter_ApproveDate ;
      private DateTime A205BR_Encounter_IsRandApproveDate ;
      private DateTime A206BR_Encounter_IsRandNoApproveDate ;
      private DateTime A209BR_Encounter_IsRandRecheckDate ;
      private DateTime A210BR_Encounter_IsRandNoRecheckDate ;
      private DateTime Z91BR_Encounter_AdmitDate ;
      private DateTime Z93BR_Encounter_DischargeDate ;
      private DateTime A91BR_Encounter_AdmitDate ;
      private DateTime A93BR_Encounter_DischargeDate ;
      private bool Z333BR_Encounter_IsDLT ;
      private bool Z192BR_Encounter_IsRandApprove ;
      private bool Z193BR_Encounter_IsRandRecheck ;
      private bool Z202BR_Encounter_IsUpdate ;
      private bool entryPointCalled ;
      private bool n85BR_Information_ID ;
      private bool n84BR_Encounter_Department ;
      private bool n90BR_Encounter_ENCType ;
      private bool n92BR_Encounter_AdmitSource ;
      private bool n94BR_Encounter_DischargeStatus ;
      private bool n360BAS_TenantTenantCode ;
      private bool toggleJsOutput ;
      private bool wbErr ;
      private bool n172BR_Encounter_Status ;
      private bool Dvpanel_tableattributes_Autowidth ;
      private bool Dvpanel_tableattributes_Autoheight ;
      private bool Dvpanel_tableattributes_Collapsible ;
      private bool Dvpanel_tableattributes_Collapsed ;
      private bool Dvpanel_tableattributes_Showcollapseicon ;
      private bool Dvpanel_tableattributes_Autoscroll ;
      private bool n36BR_Information_PatientNo ;
      private bool n91BR_Encounter_AdmitDate ;
      private bool n93BR_Encounter_DischargeDate ;
      private bool n19BR_EncounterID ;
      private bool n35BR_Encounter_EncID ;
      private bool n182BR_Encounter_CrtDate ;
      private bool n187BR_Encounter_UpdDate ;
      private bool n183BR_Encounter_CrtUser ;
      private bool n186BR_Encounter_UpdUser ;
      private bool n512BR_Encounter_CrtDisplayName ;
      private bool n470BR_Encounter_Department_Code ;
      private bool n471BR_Encounter_ENCType_Code ;
      private bool n472BR_Encounter_AdmitSource_Code ;
      private bool n473BR_Encounter_DischargeStatus_Code ;
      private bool n570BR_Encounter_Departmentadm ;
      private bool n571BR_Encounter_Departmentadm_Code ;
      private bool n572BR_Encounter_Departmentdisch ;
      private bool n573BR_Encounter_Departmentdisch_Code ;
      private bool n574BR_Encounter_Insurance ;
      private bool n575BR_Encounter_Insurance_Code ;
      private bool n333BR_Encounter_IsDLT ;
      private bool A333BR_Encounter_IsDLT ;
      private bool n184BR_Encounter_SubmitUser ;
      private bool n335BR_Encounter_Reason ;
      private bool n185BR_Encounter_SubmitDate ;
      private bool n188BR_Encounter_RecheckUser ;
      private bool n336BR_Encounter_FReason ;
      private bool n189BR_Encounter_RecheckDate ;
      private bool n190BR_Encounter_Approver ;
      private bool n191BR_Encounter_ApproveDate ;
      private bool n192BR_Encounter_IsRandApprove ;
      private bool A192BR_Encounter_IsRandApprove ;
      private bool n203BR_Encounter_IsRandApprover ;
      private bool n204BR_Encounter_IsRandNoApprover ;
      private bool n205BR_Encounter_IsRandApproveDate ;
      private bool n206BR_Encounter_IsRandNoApproveDate ;
      private bool n193BR_Encounter_IsRandRecheck ;
      private bool A193BR_Encounter_IsRandRecheck ;
      private bool n207BR_Encounter_IsRandRecheckr ;
      private bool n208BR_Encounter_IsRandNoRecheckr ;
      private bool n209BR_Encounter_IsRandRecheckDate ;
      private bool n210BR_Encounter_IsRandNoRecheckDate ;
      private bool n202BR_Encounter_IsUpdate ;
      private bool A202BR_Encounter_IsUpdate ;
      private bool n537BR_Encounter_Datasource ;
      private bool n560EncounterIDEncrypt ;
      private bool Dvpanel_tableattributes_Enabled ;
      private bool Dvpanel_tableattributes_Showheader ;
      private bool Dvpanel_tableattributes_Visible ;
      private bool AV16IsAuthorized ;
      private bool GXt_boolean2 ;
      private bool returnInSub ;
      private bool Gx_longc ;
      private bool gxdyncontrolsrefreshing ;
      private String Z183BR_Encounter_CrtUser ;
      private String Z512BR_Encounter_CrtDisplayName ;
      private String Z470BR_Encounter_Department_Code ;
      private String Z471BR_Encounter_ENCType_Code ;
      private String Z472BR_Encounter_AdmitSource_Code ;
      private String Z473BR_Encounter_DischargeStatus_Code ;
      private String Z84BR_Encounter_Department ;
      private String Z570BR_Encounter_Departmentadm ;
      private String Z571BR_Encounter_Departmentadm_Code ;
      private String Z572BR_Encounter_Departmentdisch ;
      private String Z573BR_Encounter_Departmentdisch_Code ;
      private String Z90BR_Encounter_ENCType ;
      private String Z92BR_Encounter_AdmitSource ;
      private String Z94BR_Encounter_DischargeStatus ;
      private String Z574BR_Encounter_Insurance ;
      private String Z575BR_Encounter_Insurance_Code ;
      private String Z186BR_Encounter_UpdUser ;
      private String Z184BR_Encounter_SubmitUser ;
      private String Z335BR_Encounter_Reason ;
      private String Z188BR_Encounter_RecheckUser ;
      private String Z336BR_Encounter_FReason ;
      private String Z190BR_Encounter_Approver ;
      private String Z203BR_Encounter_IsRandApprover ;
      private String Z204BR_Encounter_IsRandNoApprover ;
      private String Z207BR_Encounter_IsRandRecheckr ;
      private String Z208BR_Encounter_IsRandNoRecheckr ;
      private String Z560EncounterIDEncrypt ;
      private String Z360BAS_TenantTenantCode ;
      private String N360BAS_TenantTenantCode ;
      private String AV30tCurrentCode ;
      private String AV29Insert_BAS_TenantTenantCode ;
      private String A84BR_Encounter_Department ;
      private String A90BR_Encounter_ENCType ;
      private String A92BR_Encounter_AdmitSource ;
      private String A94BR_Encounter_DischargeStatus ;
      private String A360BAS_TenantTenantCode ;
      private String A36BR_Information_PatientNo ;
      private String A183BR_Encounter_CrtUser ;
      private String A186BR_Encounter_UpdUser ;
      private String AV27vReason ;
      private String AV26vENCType ;
      private String AV24vDepartment ;
      private String A512BR_Encounter_CrtDisplayName ;
      private String A470BR_Encounter_Department_Code ;
      private String A471BR_Encounter_ENCType_Code ;
      private String A472BR_Encounter_AdmitSource_Code ;
      private String A473BR_Encounter_DischargeStatus_Code ;
      private String A570BR_Encounter_Departmentadm ;
      private String A571BR_Encounter_Departmentadm_Code ;
      private String A572BR_Encounter_Departmentdisch ;
      private String A573BR_Encounter_Departmentdisch_Code ;
      private String A574BR_Encounter_Insurance ;
      private String A575BR_Encounter_Insurance_Code ;
      private String A184BR_Encounter_SubmitUser ;
      private String A335BR_Encounter_Reason ;
      private String A188BR_Encounter_RecheckUser ;
      private String A336BR_Encounter_FReason ;
      private String A190BR_Encounter_Approver ;
      private String A203BR_Encounter_IsRandApprover ;
      private String A204BR_Encounter_IsRandNoApprover ;
      private String A207BR_Encounter_IsRandRecheckr ;
      private String A208BR_Encounter_IsRandNoRecheckr ;
      private String A560EncounterIDEncrypt ;
      private String Z36BR_Information_PatientNo ;
      private IGxSession AV13WebSession ;
      private GeneXus.Utils.GxStringCollection gxdynajaxctrlcodr ;
      private GeneXus.Utils.GxStringCollection gxdynajaxctrldescr ;
      private GxUnknownObjectCollection isValidOutput ;
      private GXUserControl ucDvpanel_tableattributes ;
      private IGxDataStore dsDataStore1 ;
      private IGxDataStore dsDefault ;
      private GXCombobox dynBR_Encounter_Department ;
      private GXCombobox dynBR_Encounter_ENCType ;
      private GXCombobox dynBR_Encounter_AdmitSource ;
      private GXCombobox dynBR_Encounter_DischargeStatus ;
      private GXCombobox cmbBR_Encounter_Status ;
      private IDataStoreProvider pr_default ;
      private String[] T000E4_A36BR_Information_PatientNo ;
      private bool[] T000E4_n36BR_Information_PatientNo ;
      private long[] T000E7_A19BR_EncounterID ;
      private bool[] T000E7_n19BR_EncounterID ;
      private long[] T000E7_A35BR_Encounter_EncID ;
      private bool[] T000E7_n35BR_Encounter_EncID ;
      private short[] T000E7_A172BR_Encounter_Status ;
      private bool[] T000E7_n172BR_Encounter_Status ;
      private String[] T000E7_A183BR_Encounter_CrtUser ;
      private bool[] T000E7_n183BR_Encounter_CrtUser ;
      private String[] T000E7_A512BR_Encounter_CrtDisplayName ;
      private bool[] T000E7_n512BR_Encounter_CrtDisplayName ;
      private DateTime[] T000E7_A182BR_Encounter_CrtDate ;
      private bool[] T000E7_n182BR_Encounter_CrtDate ;
      private String[] T000E7_A470BR_Encounter_Department_Code ;
      private bool[] T000E7_n470BR_Encounter_Department_Code ;
      private String[] T000E7_A471BR_Encounter_ENCType_Code ;
      private bool[] T000E7_n471BR_Encounter_ENCType_Code ;
      private String[] T000E7_A472BR_Encounter_AdmitSource_Code ;
      private bool[] T000E7_n472BR_Encounter_AdmitSource_Code ;
      private String[] T000E7_A473BR_Encounter_DischargeStatus_Code ;
      private bool[] T000E7_n473BR_Encounter_DischargeStatus_Code ;
      private String[] T000E7_A84BR_Encounter_Department ;
      private bool[] T000E7_n84BR_Encounter_Department ;
      private String[] T000E7_A570BR_Encounter_Departmentadm ;
      private bool[] T000E7_n570BR_Encounter_Departmentadm ;
      private String[] T000E7_A571BR_Encounter_Departmentadm_Code ;
      private bool[] T000E7_n571BR_Encounter_Departmentadm_Code ;
      private String[] T000E7_A572BR_Encounter_Departmentdisch ;
      private bool[] T000E7_n572BR_Encounter_Departmentdisch ;
      private String[] T000E7_A573BR_Encounter_Departmentdisch_Code ;
      private bool[] T000E7_n573BR_Encounter_Departmentdisch_Code ;
      private String[] T000E7_A90BR_Encounter_ENCType ;
      private bool[] T000E7_n90BR_Encounter_ENCType ;
      private DateTime[] T000E7_A91BR_Encounter_AdmitDate ;
      private bool[] T000E7_n91BR_Encounter_AdmitDate ;
      private String[] T000E7_A92BR_Encounter_AdmitSource ;
      private bool[] T000E7_n92BR_Encounter_AdmitSource ;
      private DateTime[] T000E7_A93BR_Encounter_DischargeDate ;
      private bool[] T000E7_n93BR_Encounter_DischargeDate ;
      private String[] T000E7_A94BR_Encounter_DischargeStatus ;
      private bool[] T000E7_n94BR_Encounter_DischargeStatus ;
      private String[] T000E7_A574BR_Encounter_Insurance ;
      private bool[] T000E7_n574BR_Encounter_Insurance ;
      private String[] T000E7_A575BR_Encounter_Insurance_Code ;
      private bool[] T000E7_n575BR_Encounter_Insurance_Code ;
      private String[] T000E7_A36BR_Information_PatientNo ;
      private bool[] T000E7_n36BR_Information_PatientNo ;
      private DateTime[] T000E7_A187BR_Encounter_UpdDate ;
      private bool[] T000E7_n187BR_Encounter_UpdDate ;
      private String[] T000E7_A186BR_Encounter_UpdUser ;
      private bool[] T000E7_n186BR_Encounter_UpdUser ;
      private bool[] T000E7_A333BR_Encounter_IsDLT ;
      private bool[] T000E7_n333BR_Encounter_IsDLT ;
      private String[] T000E7_A184BR_Encounter_SubmitUser ;
      private bool[] T000E7_n184BR_Encounter_SubmitUser ;
      private String[] T000E7_A335BR_Encounter_Reason ;
      private bool[] T000E7_n335BR_Encounter_Reason ;
      private DateTime[] T000E7_A185BR_Encounter_SubmitDate ;
      private bool[] T000E7_n185BR_Encounter_SubmitDate ;
      private String[] T000E7_A188BR_Encounter_RecheckUser ;
      private bool[] T000E7_n188BR_Encounter_RecheckUser ;
      private String[] T000E7_A336BR_Encounter_FReason ;
      private bool[] T000E7_n336BR_Encounter_FReason ;
      private DateTime[] T000E7_A189BR_Encounter_RecheckDate ;
      private bool[] T000E7_n189BR_Encounter_RecheckDate ;
      private String[] T000E7_A190BR_Encounter_Approver ;
      private bool[] T000E7_n190BR_Encounter_Approver ;
      private DateTime[] T000E7_A191BR_Encounter_ApproveDate ;
      private bool[] T000E7_n191BR_Encounter_ApproveDate ;
      private bool[] T000E7_A192BR_Encounter_IsRandApprove ;
      private bool[] T000E7_n192BR_Encounter_IsRandApprove ;
      private String[] T000E7_A203BR_Encounter_IsRandApprover ;
      private bool[] T000E7_n203BR_Encounter_IsRandApprover ;
      private String[] T000E7_A204BR_Encounter_IsRandNoApprover ;
      private bool[] T000E7_n204BR_Encounter_IsRandNoApprover ;
      private DateTime[] T000E7_A205BR_Encounter_IsRandApproveDate ;
      private bool[] T000E7_n205BR_Encounter_IsRandApproveDate ;
      private DateTime[] T000E7_A206BR_Encounter_IsRandNoApproveDate ;
      private bool[] T000E7_n206BR_Encounter_IsRandNoApproveDate ;
      private bool[] T000E7_A193BR_Encounter_IsRandRecheck ;
      private bool[] T000E7_n193BR_Encounter_IsRandRecheck ;
      private String[] T000E7_A207BR_Encounter_IsRandRecheckr ;
      private bool[] T000E7_n207BR_Encounter_IsRandRecheckr ;
      private String[] T000E7_A208BR_Encounter_IsRandNoRecheckr ;
      private bool[] T000E7_n208BR_Encounter_IsRandNoRecheckr ;
      private DateTime[] T000E7_A209BR_Encounter_IsRandRecheckDate ;
      private bool[] T000E7_n209BR_Encounter_IsRandRecheckDate ;
      private DateTime[] T000E7_A210BR_Encounter_IsRandNoRecheckDate ;
      private bool[] T000E7_n210BR_Encounter_IsRandNoRecheckDate ;
      private bool[] T000E7_A202BR_Encounter_IsUpdate ;
      private bool[] T000E7_n202BR_Encounter_IsUpdate ;
      private short[] T000E7_A537BR_Encounter_Datasource ;
      private bool[] T000E7_n537BR_Encounter_Datasource ;
      private String[] T000E7_A560EncounterIDEncrypt ;
      private bool[] T000E7_n560EncounterIDEncrypt ;
      private long[] T000E7_A85BR_Information_ID ;
      private bool[] T000E7_n85BR_Information_ID ;
      private String[] T000E7_A360BAS_TenantTenantCode ;
      private bool[] T000E7_n360BAS_TenantTenantCode ;
      private long[] T000E6_A85BR_Information_ID ;
      private bool[] T000E6_n85BR_Information_ID ;
      private IDataStoreProvider pr_datastore1 ;
      private String[] T000E5_A360BAS_TenantTenantCode ;
      private bool[] T000E5_n360BAS_TenantTenantCode ;
      private String[] T000E8_A36BR_Information_PatientNo ;
      private bool[] T000E8_n36BR_Information_PatientNo ;
      private long[] T000E9_A85BR_Information_ID ;
      private bool[] T000E9_n85BR_Information_ID ;
      private String[] T000E10_A360BAS_TenantTenantCode ;
      private bool[] T000E10_n360BAS_TenantTenantCode ;
      private long[] T000E11_A19BR_EncounterID ;
      private bool[] T000E11_n19BR_EncounterID ;
      private long[] T000E3_A19BR_EncounterID ;
      private bool[] T000E3_n19BR_EncounterID ;
      private long[] T000E3_A35BR_Encounter_EncID ;
      private bool[] T000E3_n35BR_Encounter_EncID ;
      private short[] T000E3_A172BR_Encounter_Status ;
      private bool[] T000E3_n172BR_Encounter_Status ;
      private String[] T000E3_A183BR_Encounter_CrtUser ;
      private bool[] T000E3_n183BR_Encounter_CrtUser ;
      private String[] T000E3_A512BR_Encounter_CrtDisplayName ;
      private bool[] T000E3_n512BR_Encounter_CrtDisplayName ;
      private DateTime[] T000E3_A182BR_Encounter_CrtDate ;
      private bool[] T000E3_n182BR_Encounter_CrtDate ;
      private String[] T000E3_A470BR_Encounter_Department_Code ;
      private bool[] T000E3_n470BR_Encounter_Department_Code ;
      private String[] T000E3_A471BR_Encounter_ENCType_Code ;
      private bool[] T000E3_n471BR_Encounter_ENCType_Code ;
      private String[] T000E3_A472BR_Encounter_AdmitSource_Code ;
      private bool[] T000E3_n472BR_Encounter_AdmitSource_Code ;
      private String[] T000E3_A473BR_Encounter_DischargeStatus_Code ;
      private bool[] T000E3_n473BR_Encounter_DischargeStatus_Code ;
      private String[] T000E3_A84BR_Encounter_Department ;
      private bool[] T000E3_n84BR_Encounter_Department ;
      private String[] T000E3_A570BR_Encounter_Departmentadm ;
      private bool[] T000E3_n570BR_Encounter_Departmentadm ;
      private String[] T000E3_A571BR_Encounter_Departmentadm_Code ;
      private bool[] T000E3_n571BR_Encounter_Departmentadm_Code ;
      private String[] T000E3_A572BR_Encounter_Departmentdisch ;
      private bool[] T000E3_n572BR_Encounter_Departmentdisch ;
      private String[] T000E3_A573BR_Encounter_Departmentdisch_Code ;
      private bool[] T000E3_n573BR_Encounter_Departmentdisch_Code ;
      private String[] T000E3_A90BR_Encounter_ENCType ;
      private bool[] T000E3_n90BR_Encounter_ENCType ;
      private DateTime[] T000E3_A91BR_Encounter_AdmitDate ;
      private bool[] T000E3_n91BR_Encounter_AdmitDate ;
      private String[] T000E3_A92BR_Encounter_AdmitSource ;
      private bool[] T000E3_n92BR_Encounter_AdmitSource ;
      private DateTime[] T000E3_A93BR_Encounter_DischargeDate ;
      private bool[] T000E3_n93BR_Encounter_DischargeDate ;
      private String[] T000E3_A94BR_Encounter_DischargeStatus ;
      private bool[] T000E3_n94BR_Encounter_DischargeStatus ;
      private String[] T000E3_A574BR_Encounter_Insurance ;
      private bool[] T000E3_n574BR_Encounter_Insurance ;
      private String[] T000E3_A575BR_Encounter_Insurance_Code ;
      private bool[] T000E3_n575BR_Encounter_Insurance_Code ;
      private DateTime[] T000E3_A187BR_Encounter_UpdDate ;
      private bool[] T000E3_n187BR_Encounter_UpdDate ;
      private String[] T000E3_A186BR_Encounter_UpdUser ;
      private bool[] T000E3_n186BR_Encounter_UpdUser ;
      private bool[] T000E3_A333BR_Encounter_IsDLT ;
      private bool[] T000E3_n333BR_Encounter_IsDLT ;
      private String[] T000E3_A184BR_Encounter_SubmitUser ;
      private bool[] T000E3_n184BR_Encounter_SubmitUser ;
      private String[] T000E3_A335BR_Encounter_Reason ;
      private bool[] T000E3_n335BR_Encounter_Reason ;
      private DateTime[] T000E3_A185BR_Encounter_SubmitDate ;
      private bool[] T000E3_n185BR_Encounter_SubmitDate ;
      private String[] T000E3_A188BR_Encounter_RecheckUser ;
      private bool[] T000E3_n188BR_Encounter_RecheckUser ;
      private String[] T000E3_A336BR_Encounter_FReason ;
      private bool[] T000E3_n336BR_Encounter_FReason ;
      private DateTime[] T000E3_A189BR_Encounter_RecheckDate ;
      private bool[] T000E3_n189BR_Encounter_RecheckDate ;
      private String[] T000E3_A190BR_Encounter_Approver ;
      private bool[] T000E3_n190BR_Encounter_Approver ;
      private DateTime[] T000E3_A191BR_Encounter_ApproveDate ;
      private bool[] T000E3_n191BR_Encounter_ApproveDate ;
      private bool[] T000E3_A192BR_Encounter_IsRandApprove ;
      private bool[] T000E3_n192BR_Encounter_IsRandApprove ;
      private String[] T000E3_A203BR_Encounter_IsRandApprover ;
      private bool[] T000E3_n203BR_Encounter_IsRandApprover ;
      private String[] T000E3_A204BR_Encounter_IsRandNoApprover ;
      private bool[] T000E3_n204BR_Encounter_IsRandNoApprover ;
      private DateTime[] T000E3_A205BR_Encounter_IsRandApproveDate ;
      private bool[] T000E3_n205BR_Encounter_IsRandApproveDate ;
      private DateTime[] T000E3_A206BR_Encounter_IsRandNoApproveDate ;
      private bool[] T000E3_n206BR_Encounter_IsRandNoApproveDate ;
      private bool[] T000E3_A193BR_Encounter_IsRandRecheck ;
      private bool[] T000E3_n193BR_Encounter_IsRandRecheck ;
      private String[] T000E3_A207BR_Encounter_IsRandRecheckr ;
      private bool[] T000E3_n207BR_Encounter_IsRandRecheckr ;
      private String[] T000E3_A208BR_Encounter_IsRandNoRecheckr ;
      private bool[] T000E3_n208BR_Encounter_IsRandNoRecheckr ;
      private DateTime[] T000E3_A209BR_Encounter_IsRandRecheckDate ;
      private bool[] T000E3_n209BR_Encounter_IsRandRecheckDate ;
      private DateTime[] T000E3_A210BR_Encounter_IsRandNoRecheckDate ;
      private bool[] T000E3_n210BR_Encounter_IsRandNoRecheckDate ;
      private bool[] T000E3_A202BR_Encounter_IsUpdate ;
      private bool[] T000E3_n202BR_Encounter_IsUpdate ;
      private short[] T000E3_A537BR_Encounter_Datasource ;
      private bool[] T000E3_n537BR_Encounter_Datasource ;
      private String[] T000E3_A560EncounterIDEncrypt ;
      private bool[] T000E3_n560EncounterIDEncrypt ;
      private long[] T000E3_A85BR_Information_ID ;
      private bool[] T000E3_n85BR_Information_ID ;
      private String[] T000E3_A360BAS_TenantTenantCode ;
      private bool[] T000E3_n360BAS_TenantTenantCode ;
      private long[] T000E12_A19BR_EncounterID ;
      private bool[] T000E12_n19BR_EncounterID ;
      private long[] T000E13_A19BR_EncounterID ;
      private bool[] T000E13_n19BR_EncounterID ;
      private long[] T000E2_A19BR_EncounterID ;
      private bool[] T000E2_n19BR_EncounterID ;
      private long[] T000E2_A35BR_Encounter_EncID ;
      private bool[] T000E2_n35BR_Encounter_EncID ;
      private short[] T000E2_A172BR_Encounter_Status ;
      private bool[] T000E2_n172BR_Encounter_Status ;
      private String[] T000E2_A183BR_Encounter_CrtUser ;
      private bool[] T000E2_n183BR_Encounter_CrtUser ;
      private String[] T000E2_A512BR_Encounter_CrtDisplayName ;
      private bool[] T000E2_n512BR_Encounter_CrtDisplayName ;
      private DateTime[] T000E2_A182BR_Encounter_CrtDate ;
      private bool[] T000E2_n182BR_Encounter_CrtDate ;
      private String[] T000E2_A470BR_Encounter_Department_Code ;
      private bool[] T000E2_n470BR_Encounter_Department_Code ;
      private String[] T000E2_A471BR_Encounter_ENCType_Code ;
      private bool[] T000E2_n471BR_Encounter_ENCType_Code ;
      private String[] T000E2_A472BR_Encounter_AdmitSource_Code ;
      private bool[] T000E2_n472BR_Encounter_AdmitSource_Code ;
      private String[] T000E2_A473BR_Encounter_DischargeStatus_Code ;
      private bool[] T000E2_n473BR_Encounter_DischargeStatus_Code ;
      private String[] T000E2_A84BR_Encounter_Department ;
      private bool[] T000E2_n84BR_Encounter_Department ;
      private String[] T000E2_A570BR_Encounter_Departmentadm ;
      private bool[] T000E2_n570BR_Encounter_Departmentadm ;
      private String[] T000E2_A571BR_Encounter_Departmentadm_Code ;
      private bool[] T000E2_n571BR_Encounter_Departmentadm_Code ;
      private String[] T000E2_A572BR_Encounter_Departmentdisch ;
      private bool[] T000E2_n572BR_Encounter_Departmentdisch ;
      private String[] T000E2_A573BR_Encounter_Departmentdisch_Code ;
      private bool[] T000E2_n573BR_Encounter_Departmentdisch_Code ;
      private String[] T000E2_A90BR_Encounter_ENCType ;
      private bool[] T000E2_n90BR_Encounter_ENCType ;
      private DateTime[] T000E2_A91BR_Encounter_AdmitDate ;
      private bool[] T000E2_n91BR_Encounter_AdmitDate ;
      private String[] T000E2_A92BR_Encounter_AdmitSource ;
      private bool[] T000E2_n92BR_Encounter_AdmitSource ;
      private DateTime[] T000E2_A93BR_Encounter_DischargeDate ;
      private bool[] T000E2_n93BR_Encounter_DischargeDate ;
      private String[] T000E2_A94BR_Encounter_DischargeStatus ;
      private bool[] T000E2_n94BR_Encounter_DischargeStatus ;
      private String[] T000E2_A574BR_Encounter_Insurance ;
      private bool[] T000E2_n574BR_Encounter_Insurance ;
      private String[] T000E2_A575BR_Encounter_Insurance_Code ;
      private bool[] T000E2_n575BR_Encounter_Insurance_Code ;
      private DateTime[] T000E2_A187BR_Encounter_UpdDate ;
      private bool[] T000E2_n187BR_Encounter_UpdDate ;
      private String[] T000E2_A186BR_Encounter_UpdUser ;
      private bool[] T000E2_n186BR_Encounter_UpdUser ;
      private bool[] T000E2_A333BR_Encounter_IsDLT ;
      private bool[] T000E2_n333BR_Encounter_IsDLT ;
      private String[] T000E2_A184BR_Encounter_SubmitUser ;
      private bool[] T000E2_n184BR_Encounter_SubmitUser ;
      private String[] T000E2_A335BR_Encounter_Reason ;
      private bool[] T000E2_n335BR_Encounter_Reason ;
      private DateTime[] T000E2_A185BR_Encounter_SubmitDate ;
      private bool[] T000E2_n185BR_Encounter_SubmitDate ;
      private String[] T000E2_A188BR_Encounter_RecheckUser ;
      private bool[] T000E2_n188BR_Encounter_RecheckUser ;
      private String[] T000E2_A336BR_Encounter_FReason ;
      private bool[] T000E2_n336BR_Encounter_FReason ;
      private DateTime[] T000E2_A189BR_Encounter_RecheckDate ;
      private bool[] T000E2_n189BR_Encounter_RecheckDate ;
      private String[] T000E2_A190BR_Encounter_Approver ;
      private bool[] T000E2_n190BR_Encounter_Approver ;
      private DateTime[] T000E2_A191BR_Encounter_ApproveDate ;
      private bool[] T000E2_n191BR_Encounter_ApproveDate ;
      private bool[] T000E2_A192BR_Encounter_IsRandApprove ;
      private bool[] T000E2_n192BR_Encounter_IsRandApprove ;
      private String[] T000E2_A203BR_Encounter_IsRandApprover ;
      private bool[] T000E2_n203BR_Encounter_IsRandApprover ;
      private String[] T000E2_A204BR_Encounter_IsRandNoApprover ;
      private bool[] T000E2_n204BR_Encounter_IsRandNoApprover ;
      private DateTime[] T000E2_A205BR_Encounter_IsRandApproveDate ;
      private bool[] T000E2_n205BR_Encounter_IsRandApproveDate ;
      private DateTime[] T000E2_A206BR_Encounter_IsRandNoApproveDate ;
      private bool[] T000E2_n206BR_Encounter_IsRandNoApproveDate ;
      private bool[] T000E2_A193BR_Encounter_IsRandRecheck ;
      private bool[] T000E2_n193BR_Encounter_IsRandRecheck ;
      private String[] T000E2_A207BR_Encounter_IsRandRecheckr ;
      private bool[] T000E2_n207BR_Encounter_IsRandRecheckr ;
      private String[] T000E2_A208BR_Encounter_IsRandNoRecheckr ;
      private bool[] T000E2_n208BR_Encounter_IsRandNoRecheckr ;
      private DateTime[] T000E2_A209BR_Encounter_IsRandRecheckDate ;
      private bool[] T000E2_n209BR_Encounter_IsRandRecheckDate ;
      private DateTime[] T000E2_A210BR_Encounter_IsRandNoRecheckDate ;
      private bool[] T000E2_n210BR_Encounter_IsRandNoRecheckDate ;
      private bool[] T000E2_A202BR_Encounter_IsUpdate ;
      private bool[] T000E2_n202BR_Encounter_IsUpdate ;
      private short[] T000E2_A537BR_Encounter_Datasource ;
      private bool[] T000E2_n537BR_Encounter_Datasource ;
      private String[] T000E2_A560EncounterIDEncrypt ;
      private bool[] T000E2_n560EncounterIDEncrypt ;
      private long[] T000E2_A85BR_Information_ID ;
      private bool[] T000E2_n85BR_Information_ID ;
      private String[] T000E2_A360BAS_TenantTenantCode ;
      private bool[] T000E2_n360BAS_TenantTenantCode ;
      private long[] T000E14_A19BR_EncounterID ;
      private bool[] T000E14_n19BR_EncounterID ;
      private String[] T000E17_A36BR_Information_PatientNo ;
      private bool[] T000E17_n36BR_Information_PatientNo ;
      private long[] T000E18_A348BR_Encounter_RefuseReasonID ;
      private long[] T000E19_A347BR_Encounter_ID ;
      private long[] T000E20_A327BR_SchemeID ;
      private long[] T000E21_A226BR_PathologyID ;
      private long[] T000E22_A225BR_MedicalImagingID ;
      private long[] T000E23_A150BR_VitalID ;
      private long[] T000E24_A139BR_ProcedureID ;
      private long[] T000E25_A119BR_MedicationID ;
      private long[] T000E26_A101BR_LabID ;
      private long[] T000E27_A64BR_DiagnosisID ;
      private long[] T000E28_A61BR_Demographics_ID ;
      private long[] T000E29_A48BR_DeathID ;
      private long[] T000E30_A37BR_ComorbidityID ;
      private long[] T000E31_A20BR_BehaviorID ;
      private long[] T000E32_A19BR_EncounterID ;
      private bool[] T000E32_n19BR_EncounterID ;
      private long[] T000E33_A167XT_DefineCodeID ;
      private String[] T000E33_A168XT_DefineCodeName ;
      private bool[] T000E33_n168XT_DefineCodeName ;
      private long[] T000E33_A165XT_DefindcodeTypeID ;
      private String[] T000E33_A432XT_TenantCode ;
      private bool[] T000E33_n432XT_TenantCode ;
      private long[] T000E34_A167XT_DefineCodeID ;
      private String[] T000E34_A168XT_DefineCodeName ;
      private bool[] T000E34_n168XT_DefineCodeName ;
      private long[] T000E34_A165XT_DefindcodeTypeID ;
      private String[] T000E34_A432XT_TenantCode ;
      private bool[] T000E34_n432XT_TenantCode ;
      private long[] T000E35_A167XT_DefineCodeID ;
      private String[] T000E35_A168XT_DefineCodeName ;
      private bool[] T000E35_n168XT_DefineCodeName ;
      private long[] T000E35_A165XT_DefindcodeTypeID ;
      private String[] T000E35_A432XT_TenantCode ;
      private bool[] T000E35_n432XT_TenantCode ;
      private long[] T000E36_A167XT_DefineCodeID ;
      private String[] T000E36_A168XT_DefineCodeName ;
      private bool[] T000E36_n168XT_DefineCodeName ;
      private long[] T000E36_A165XT_DefindcodeTypeID ;
      private String[] T000E36_A432XT_TenantCode ;
      private bool[] T000E36_n432XT_TenantCode ;
      private String[] T000E37_A36BR_Information_PatientNo ;
      private bool[] T000E37_n36BR_Information_PatientNo ;
      private GXWebForm Form ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext AV11TrnContext ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext_Attribute AV12TrnContextAtt ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPContext AV14WWPContext ;
   }

   public class br_encounter__datastore1 : DataStoreHelperBase, IDataStoreHelper
   {
      public ICursor[] getCursors( )
      {
         cursorDefinitions();
         return new Cursor[] {
          new ForEachCursor(def[0])
         ,new ForEachCursor(def[1])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmT000E5 ;
          prmT000E5 = new Object[] {
          new Object[] {"@BAS_TenantTenantCode",SqlDbType.NVarChar,20,0}
          } ;
          Object[] prmT000E10 ;
          prmT000E10 = new Object[] {
          new Object[] {"@BAS_TenantTenantCode",SqlDbType.NVarChar,20,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("T000E5", "SELECT [TenantCode] FROM dbo.[BAS_Tenant] WITH (NOLOCK) WHERE [TenantCode] = @BAS_TenantTenantCode ",true, GxErrorMask.GX_NOMASK, false, this,prmT000E5,1,0,true,false )
             ,new CursorDef("T000E10", "SELECT [TenantCode] FROM dbo.[BAS_Tenant] WITH (NOLOCK) WHERE [TenantCode] = @BAS_TenantTenantCode ",true, GxErrorMask.GX_NOMASK, false, this,prmT000E10,1,0,true,false )
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
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                return;
             case 1 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
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
                   stmt.setNull( 1 , SqlDbType.NVarChar );
                }
                else
                {
                   stmt.SetParameter(1, (String)parms[1]);
                }
                return;
             case 1 :
                if ( (bool)parms[0] )
                {
                   stmt.setNull( 1 , SqlDbType.NVarChar );
                }
                else
                {
                   stmt.SetParameter(1, (String)parms[1]);
                }
                return;
       }
    }

    public String getDataStoreName( )
    {
       return "DATASTORE1";
    }

 }

 public class br_encounter__default : DataStoreHelperBase, IDataStoreHelper
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
       ,new ForEachCursor(def[16])
       ,new ForEachCursor(def[17])
       ,new ForEachCursor(def[18])
       ,new ForEachCursor(def[19])
       ,new ForEachCursor(def[20])
       ,new ForEachCursor(def[21])
       ,new ForEachCursor(def[22])
       ,new ForEachCursor(def[23])
       ,new ForEachCursor(def[24])
       ,new ForEachCursor(def[25])
       ,new ForEachCursor(def[26])
       ,new ForEachCursor(def[27])
       ,new ForEachCursor(def[28])
       ,new ForEachCursor(def[29])
       ,new ForEachCursor(def[30])
       ,new ForEachCursor(def[31])
       ,new ForEachCursor(def[32])
       ,new ForEachCursor(def[33])
     };
  }

  private static CursorDef[] def;
  private void cursorDefinitions( )
  {
     if ( def == null )
     {
        Object[] prmT000E7 ;
        prmT000E7 = new Object[] {
        new Object[] {"@BR_EncounterID",SqlDbType.Decimal,18,0}
        } ;
        String cmdBufferT000E7 ;
        cmdBufferT000E7=" SELECT TM1.[BR_EncounterID], TM1.[BR_Encounter_EncID], TM1.[BR_Encounter_Status], TM1.[BR_Encounter_CrtUser], TM1.[BR_Encounter_CrtDisplayName], TM1.[BR_Encounter_CrtDate], TM1.[BR_Encounter_Department_Code], TM1.[BR_Encounter_ENCType_Code], TM1.[BR_Encounter_AdmitSource_Code], TM1.[BR_Encounter_DischargeStatus_Code], TM1.[BR_Encounter_Department], TM1.[BR_Encounter_Departmentadm], TM1.[BR_Encounter_Departmentadm_Code], TM1.[BR_Encounter_Departmentdisch], TM1.[BR_Encounter_Departmentdisch_Code], TM1.[BR_Encounter_ENCType], TM1.[BR_Encounter_AdmitDate], TM1.[BR_Encounter_AdmitSource], TM1.[BR_Encounter_DischargeDate], TM1.[BR_Encounter_DischargeStatus], TM1.[BR_Encounter_Insurance], TM1.[BR_Encounter_Insurance_Code], T2.[BR_Information_PatientNo], TM1.[BR_Encounter_UpdDate], TM1.[BR_Encounter_UpdUser], TM1.[BR_Encounter_IsDLT], TM1.[BR_Encounter_SubmitUser], TM1.[BR_Encounter_Reason], TM1.[BR_Encounter_SubmitDate], TM1.[BR_Encounter_RecheckUser], TM1.[BR_Encounter_FReason], TM1.[BR_Encounter_RecheckDate], TM1.[BR_Encounter_Approver], TM1.[BR_Encounter_ApproveDate], TM1.[BR_Encounter_IsRandApprove], TM1.[BR_Encounter_IsRandApprover], TM1.[BR_Encounter_IsRandNoApprover], TM1.[BR_Encounter_IsRandApproveDate], TM1.[BR_Encounter_IsRandNoApproveDate], TM1.[BR_Encounter_IsRandRecheck], TM1.[BR_Encounter_IsRandRecheckr], TM1.[BR_Encounter_IsRandNoRecheckr], TM1.[BR_Encounter_IsRandRecheckDate], TM1.[BR_Encounter_IsRandNoRecheckDate], TM1.[BR_Encounter_IsUpdate], TM1.[BR_Encounter_Datasource], TM1.[EncounterIDEncrypt], TM1.[BR_Information_ID], TM1.[BAS_TenantTenantCode] FROM ([BR_Encounter] TM1 WITH (NOLOCK) LEFT JOIN [BR_Information] T2 WITH (NOLOCK) ON T2.[BR_Information_ID] = TM1.[BR_Information_ID]) WHERE TM1.[BR_EncounterID] = @BR_EncounterID ORDER BY TM1.[BR_EncounterID]  OPTION "
        + " (FAST 100)" ;
        Object[] prmT000E4 ;
        prmT000E4 = new Object[] {
        new Object[] {"@BR_Information_ID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000E6 ;
        prmT000E6 = new Object[] {
        new Object[] {"@BR_Information_ID",SqlDbType.Decimal,18,0} ,
        new Object[] {"@BAS_TenantTenantCode",SqlDbType.NVarChar,20,0}
        } ;
        Object[] prmT000E8 ;
        prmT000E8 = new Object[] {
        new Object[] {"@BR_Information_ID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000E9 ;
        prmT000E9 = new Object[] {
        new Object[] {"@BR_Information_ID",SqlDbType.Decimal,18,0} ,
        new Object[] {"@BAS_TenantTenantCode",SqlDbType.NVarChar,20,0}
        } ;
        Object[] prmT000E11 ;
        prmT000E11 = new Object[] {
        new Object[] {"@BR_EncounterID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000E3 ;
        prmT000E3 = new Object[] {
        new Object[] {"@BR_EncounterID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000E12 ;
        prmT000E12 = new Object[] {
        new Object[] {"@BR_EncounterID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000E13 ;
        prmT000E13 = new Object[] {
        new Object[] {"@BR_EncounterID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000E2 ;
        prmT000E2 = new Object[] {
        new Object[] {"@BR_EncounterID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000E14 ;
        prmT000E14 = new Object[] {
        new Object[] {"@BR_Encounter_EncID",SqlDbType.Decimal,10,0} ,
        new Object[] {"@BR_Encounter_Status",SqlDbType.SmallInt,4,0} ,
        new Object[] {"@BR_Encounter_CrtUser",SqlDbType.NVarChar,100,0} ,
        new Object[] {"@BR_Encounter_CrtDisplayName",SqlDbType.NVarChar,100,0} ,
        new Object[] {"@BR_Encounter_CrtDate",SqlDbType.DateTime,10,8} ,
        new Object[] {"@BR_Encounter_Department_Code",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Encounter_ENCType_Code",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Encounter_AdmitSource_Code",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Encounter_DischargeStatus_Code",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Encounter_Department",SqlDbType.NVarChar,100,0} ,
        new Object[] {"@BR_Encounter_Departmentadm",SqlDbType.NVarChar,100,0} ,
        new Object[] {"@BR_Encounter_Departmentadm_Code",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Encounter_Departmentdisch",SqlDbType.NVarChar,100,0} ,
        new Object[] {"@BR_Encounter_Departmentdisch_Code",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Encounter_ENCType",SqlDbType.NVarChar,100,0} ,
        new Object[] {"@BR_Encounter_AdmitDate",SqlDbType.DateTime,8,0} ,
        new Object[] {"@BR_Encounter_AdmitSource",SqlDbType.NVarChar,100,0} ,
        new Object[] {"@BR_Encounter_DischargeDate",SqlDbType.DateTime,8,0} ,
        new Object[] {"@BR_Encounter_DischargeStatus",SqlDbType.NVarChar,100,0} ,
        new Object[] {"@BR_Encounter_Insurance",SqlDbType.NVarChar,100,0} ,
        new Object[] {"@BR_Encounter_Insurance_Code",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Encounter_UpdDate",SqlDbType.DateTime,10,8} ,
        new Object[] {"@BR_Encounter_UpdUser",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Encounter_IsDLT",SqlDbType.Bit,4,0} ,
        new Object[] {"@BR_Encounter_SubmitUser",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Encounter_Reason",SqlDbType.NVarChar,300,0} ,
        new Object[] {"@BR_Encounter_SubmitDate",SqlDbType.DateTime,10,8} ,
        new Object[] {"@BR_Encounter_RecheckUser",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Encounter_FReason",SqlDbType.NVarChar,300,0} ,
        new Object[] {"@BR_Encounter_RecheckDate",SqlDbType.DateTime,10,8} ,
        new Object[] {"@BR_Encounter_Approver",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Encounter_ApproveDate",SqlDbType.DateTime,10,8} ,
        new Object[] {"@BR_Encounter_IsRandApprove",SqlDbType.Bit,4,0} ,
        new Object[] {"@BR_Encounter_IsRandApprover",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Encounter_IsRandNoApprover",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Encounter_IsRandApproveDate",SqlDbType.DateTime,10,8} ,
        new Object[] {"@BR_Encounter_IsRandNoApproveDate",SqlDbType.DateTime,10,8} ,
        new Object[] {"@BR_Encounter_IsRandRecheck",SqlDbType.Bit,4,0} ,
        new Object[] {"@BR_Encounter_IsRandRecheckr",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Encounter_IsRandNoRecheckr",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Encounter_IsRandRecheckDate",SqlDbType.DateTime,10,8} ,
        new Object[] {"@BR_Encounter_IsRandNoRecheckDate",SqlDbType.DateTime,10,8} ,
        new Object[] {"@BR_Encounter_IsUpdate",SqlDbType.Bit,4,0} ,
        new Object[] {"@BR_Encounter_Datasource",SqlDbType.SmallInt,4,0} ,
        new Object[] {"@EncounterIDEncrypt",SqlDbType.NVarChar,500,0} ,
        new Object[] {"@BR_Information_ID",SqlDbType.Decimal,18,0} ,
        new Object[] {"@BAS_TenantTenantCode",SqlDbType.NVarChar,20,0}
        } ;
        String cmdBufferT000E14 ;
        cmdBufferT000E14=" INSERT INTO [BR_Encounter]([BR_Encounter_EncID], [BR_Encounter_Status], [BR_Encounter_CrtUser], [BR_Encounter_CrtDisplayName], [BR_Encounter_CrtDate], [BR_Encounter_Department_Code], [BR_Encounter_ENCType_Code], [BR_Encounter_AdmitSource_Code], [BR_Encounter_DischargeStatus_Code], [BR_Encounter_Department], [BR_Encounter_Departmentadm], [BR_Encounter_Departmentadm_Code], [BR_Encounter_Departmentdisch], [BR_Encounter_Departmentdisch_Code], [BR_Encounter_ENCType], [BR_Encounter_AdmitDate], [BR_Encounter_AdmitSource], [BR_Encounter_DischargeDate], [BR_Encounter_DischargeStatus], [BR_Encounter_Insurance], [BR_Encounter_Insurance_Code], [BR_Encounter_UpdDate], [BR_Encounter_UpdUser], [BR_Encounter_IsDLT], [BR_Encounter_SubmitUser], [BR_Encounter_Reason], [BR_Encounter_SubmitDate], [BR_Encounter_RecheckUser], [BR_Encounter_FReason], [BR_Encounter_RecheckDate], [BR_Encounter_Approver], [BR_Encounter_ApproveDate], [BR_Encounter_IsRandApprove], [BR_Encounter_IsRandApprover], [BR_Encounter_IsRandNoApprover], [BR_Encounter_IsRandApproveDate], [BR_Encounter_IsRandNoApproveDate], [BR_Encounter_IsRandRecheck], [BR_Encounter_IsRandRecheckr], [BR_Encounter_IsRandNoRecheckr], [BR_Encounter_IsRandRecheckDate], [BR_Encounter_IsRandNoRecheckDate], [BR_Encounter_IsUpdate], [BR_Encounter_Datasource], [EncounterIDEncrypt], [BR_Information_ID], [BAS_TenantTenantCode]) VALUES(@BR_Encounter_EncID, @BR_Encounter_Status, @BR_Encounter_CrtUser, @BR_Encounter_CrtDisplayName, @BR_Encounter_CrtDate, @BR_Encounter_Department_Code, @BR_Encounter_ENCType_Code, @BR_Encounter_AdmitSource_Code, @BR_Encounter_DischargeStatus_Code, @BR_Encounter_Department, @BR_Encounter_Departmentadm, @BR_Encounter_Departmentadm_Code, @BR_Encounter_Departmentdisch, @BR_Encounter_Departmentdisch_Code, @BR_Encounter_ENCType, @BR_Encounter_AdmitDate, "
        + " @BR_Encounter_AdmitSource, @BR_Encounter_DischargeDate, @BR_Encounter_DischargeStatus, @BR_Encounter_Insurance, @BR_Encounter_Insurance_Code, @BR_Encounter_UpdDate, @BR_Encounter_UpdUser, @BR_Encounter_IsDLT, @BR_Encounter_SubmitUser, @BR_Encounter_Reason, @BR_Encounter_SubmitDate, @BR_Encounter_RecheckUser, @BR_Encounter_FReason, @BR_Encounter_RecheckDate, @BR_Encounter_Approver, @BR_Encounter_ApproveDate, @BR_Encounter_IsRandApprove, @BR_Encounter_IsRandApprover, @BR_Encounter_IsRandNoApprover, @BR_Encounter_IsRandApproveDate, @BR_Encounter_IsRandNoApproveDate, @BR_Encounter_IsRandRecheck, @BR_Encounter_IsRandRecheckr, @BR_Encounter_IsRandNoRecheckr, @BR_Encounter_IsRandRecheckDate, @BR_Encounter_IsRandNoRecheckDate, @BR_Encounter_IsUpdate, @BR_Encounter_Datasource, @EncounterIDEncrypt, @BR_Information_ID, @BAS_TenantTenantCode); SELECT SCOPE_IDENTITY()" ;
        Object[] prmT000E15 ;
        prmT000E15 = new Object[] {
        new Object[] {"@BR_Encounter_EncID",SqlDbType.Decimal,10,0} ,
        new Object[] {"@BR_Encounter_Status",SqlDbType.SmallInt,4,0} ,
        new Object[] {"@BR_Encounter_CrtUser",SqlDbType.NVarChar,100,0} ,
        new Object[] {"@BR_Encounter_CrtDisplayName",SqlDbType.NVarChar,100,0} ,
        new Object[] {"@BR_Encounter_CrtDate",SqlDbType.DateTime,10,8} ,
        new Object[] {"@BR_Encounter_Department_Code",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Encounter_ENCType_Code",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Encounter_AdmitSource_Code",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Encounter_DischargeStatus_Code",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Encounter_Department",SqlDbType.NVarChar,100,0} ,
        new Object[] {"@BR_Encounter_Departmentadm",SqlDbType.NVarChar,100,0} ,
        new Object[] {"@BR_Encounter_Departmentadm_Code",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Encounter_Departmentdisch",SqlDbType.NVarChar,100,0} ,
        new Object[] {"@BR_Encounter_Departmentdisch_Code",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Encounter_ENCType",SqlDbType.NVarChar,100,0} ,
        new Object[] {"@BR_Encounter_AdmitDate",SqlDbType.DateTime,8,0} ,
        new Object[] {"@BR_Encounter_AdmitSource",SqlDbType.NVarChar,100,0} ,
        new Object[] {"@BR_Encounter_DischargeDate",SqlDbType.DateTime,8,0} ,
        new Object[] {"@BR_Encounter_DischargeStatus",SqlDbType.NVarChar,100,0} ,
        new Object[] {"@BR_Encounter_Insurance",SqlDbType.NVarChar,100,0} ,
        new Object[] {"@BR_Encounter_Insurance_Code",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Encounter_UpdDate",SqlDbType.DateTime,10,8} ,
        new Object[] {"@BR_Encounter_UpdUser",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Encounter_IsDLT",SqlDbType.Bit,4,0} ,
        new Object[] {"@BR_Encounter_SubmitUser",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Encounter_Reason",SqlDbType.NVarChar,300,0} ,
        new Object[] {"@BR_Encounter_SubmitDate",SqlDbType.DateTime,10,8} ,
        new Object[] {"@BR_Encounter_RecheckUser",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Encounter_FReason",SqlDbType.NVarChar,300,0} ,
        new Object[] {"@BR_Encounter_RecheckDate",SqlDbType.DateTime,10,8} ,
        new Object[] {"@BR_Encounter_Approver",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Encounter_ApproveDate",SqlDbType.DateTime,10,8} ,
        new Object[] {"@BR_Encounter_IsRandApprove",SqlDbType.Bit,4,0} ,
        new Object[] {"@BR_Encounter_IsRandApprover",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Encounter_IsRandNoApprover",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Encounter_IsRandApproveDate",SqlDbType.DateTime,10,8} ,
        new Object[] {"@BR_Encounter_IsRandNoApproveDate",SqlDbType.DateTime,10,8} ,
        new Object[] {"@BR_Encounter_IsRandRecheck",SqlDbType.Bit,4,0} ,
        new Object[] {"@BR_Encounter_IsRandRecheckr",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Encounter_IsRandNoRecheckr",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Encounter_IsRandRecheckDate",SqlDbType.DateTime,10,8} ,
        new Object[] {"@BR_Encounter_IsRandNoRecheckDate",SqlDbType.DateTime,10,8} ,
        new Object[] {"@BR_Encounter_IsUpdate",SqlDbType.Bit,4,0} ,
        new Object[] {"@BR_Encounter_Datasource",SqlDbType.SmallInt,4,0} ,
        new Object[] {"@EncounterIDEncrypt",SqlDbType.NVarChar,500,0} ,
        new Object[] {"@BR_Information_ID",SqlDbType.Decimal,18,0} ,
        new Object[] {"@BAS_TenantTenantCode",SqlDbType.NVarChar,20,0} ,
        new Object[] {"@BR_EncounterID",SqlDbType.Decimal,18,0}
        } ;
        String cmdBufferT000E15 ;
        cmdBufferT000E15=" UPDATE [BR_Encounter] SET [BR_Encounter_EncID]=@BR_Encounter_EncID, [BR_Encounter_Status]=@BR_Encounter_Status, [BR_Encounter_CrtUser]=@BR_Encounter_CrtUser, [BR_Encounter_CrtDisplayName]=@BR_Encounter_CrtDisplayName, [BR_Encounter_CrtDate]=@BR_Encounter_CrtDate, [BR_Encounter_Department_Code]=@BR_Encounter_Department_Code, [BR_Encounter_ENCType_Code]=@BR_Encounter_ENCType_Code, [BR_Encounter_AdmitSource_Code]=@BR_Encounter_AdmitSource_Code, [BR_Encounter_DischargeStatus_Code]=@BR_Encounter_DischargeStatus_Code, [BR_Encounter_Department]=@BR_Encounter_Department, [BR_Encounter_Departmentadm]=@BR_Encounter_Departmentadm, [BR_Encounter_Departmentadm_Code]=@BR_Encounter_Departmentadm_Code, [BR_Encounter_Departmentdisch]=@BR_Encounter_Departmentdisch, [BR_Encounter_Departmentdisch_Code]=@BR_Encounter_Departmentdisch_Code, [BR_Encounter_ENCType]=@BR_Encounter_ENCType, [BR_Encounter_AdmitDate]=@BR_Encounter_AdmitDate, [BR_Encounter_AdmitSource]=@BR_Encounter_AdmitSource, [BR_Encounter_DischargeDate]=@BR_Encounter_DischargeDate, [BR_Encounter_DischargeStatus]=@BR_Encounter_DischargeStatus, [BR_Encounter_Insurance]=@BR_Encounter_Insurance, [BR_Encounter_Insurance_Code]=@BR_Encounter_Insurance_Code, [BR_Encounter_UpdDate]=@BR_Encounter_UpdDate, [BR_Encounter_UpdUser]=@BR_Encounter_UpdUser, [BR_Encounter_IsDLT]=@BR_Encounter_IsDLT, [BR_Encounter_SubmitUser]=@BR_Encounter_SubmitUser, [BR_Encounter_Reason]=@BR_Encounter_Reason, [BR_Encounter_SubmitDate]=@BR_Encounter_SubmitDate, [BR_Encounter_RecheckUser]=@BR_Encounter_RecheckUser, [BR_Encounter_FReason]=@BR_Encounter_FReason, [BR_Encounter_RecheckDate]=@BR_Encounter_RecheckDate, [BR_Encounter_Approver]=@BR_Encounter_Approver, [BR_Encounter_ApproveDate]=@BR_Encounter_ApproveDate, [BR_Encounter_IsRandApprove]=@BR_Encounter_IsRandApprove, "
        + " [BR_Encounter_IsRandApprover]=@BR_Encounter_IsRandApprover, [BR_Encounter_IsRandNoApprover]=@BR_Encounter_IsRandNoApprover, [BR_Encounter_IsRandApproveDate]=@BR_Encounter_IsRandApproveDate, [BR_Encounter_IsRandNoApproveDate]=@BR_Encounter_IsRandNoApproveDate, [BR_Encounter_IsRandRecheck]=@BR_Encounter_IsRandRecheck, [BR_Encounter_IsRandRecheckr]=@BR_Encounter_IsRandRecheckr, [BR_Encounter_IsRandNoRecheckr]=@BR_Encounter_IsRandNoRecheckr, [BR_Encounter_IsRandRecheckDate]=@BR_Encounter_IsRandRecheckDate, [BR_Encounter_IsRandNoRecheckDate]=@BR_Encounter_IsRandNoRecheckDate, [BR_Encounter_IsUpdate]=@BR_Encounter_IsUpdate, [BR_Encounter_Datasource]=@BR_Encounter_Datasource, [EncounterIDEncrypt]=@EncounterIDEncrypt, [BR_Information_ID]=@BR_Information_ID, [BAS_TenantTenantCode]=@BAS_TenantTenantCode  WHERE [BR_EncounterID] = @BR_EncounterID" ;
        Object[] prmT000E16 ;
        prmT000E16 = new Object[] {
        new Object[] {"@BR_EncounterID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000E17 ;
        prmT000E17 = new Object[] {
        new Object[] {"@BR_Information_ID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000E18 ;
        prmT000E18 = new Object[] {
        new Object[] {"@BR_EncounterID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000E19 ;
        prmT000E19 = new Object[] {
        new Object[] {"@BR_EncounterID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000E20 ;
        prmT000E20 = new Object[] {
        new Object[] {"@BR_EncounterID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000E21 ;
        prmT000E21 = new Object[] {
        new Object[] {"@BR_EncounterID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000E22 ;
        prmT000E22 = new Object[] {
        new Object[] {"@BR_EncounterID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000E23 ;
        prmT000E23 = new Object[] {
        new Object[] {"@BR_EncounterID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000E24 ;
        prmT000E24 = new Object[] {
        new Object[] {"@BR_EncounterID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000E25 ;
        prmT000E25 = new Object[] {
        new Object[] {"@BR_EncounterID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000E26 ;
        prmT000E26 = new Object[] {
        new Object[] {"@BR_EncounterID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000E27 ;
        prmT000E27 = new Object[] {
        new Object[] {"@BR_EncounterID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000E28 ;
        prmT000E28 = new Object[] {
        new Object[] {"@BR_EncounterID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000E29 ;
        prmT000E29 = new Object[] {
        new Object[] {"@BR_EncounterID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000E30 ;
        prmT000E30 = new Object[] {
        new Object[] {"@BR_EncounterID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000E31 ;
        prmT000E31 = new Object[] {
        new Object[] {"@BR_EncounterID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000E32 ;
        prmT000E32 = new Object[] {
        } ;
        Object[] prmT000E33 ;
        prmT000E33 = new Object[] {
        new Object[] {"@AV30tCurrentCode",SqlDbType.NVarChar,40,0}
        } ;
        Object[] prmT000E34 ;
        prmT000E34 = new Object[] {
        new Object[] {"@AV30tCurrentCode",SqlDbType.NVarChar,40,0}
        } ;
        Object[] prmT000E35 ;
        prmT000E35 = new Object[] {
        new Object[] {"@AV30tCurrentCode",SqlDbType.NVarChar,40,0}
        } ;
        Object[] prmT000E36 ;
        prmT000E36 = new Object[] {
        new Object[] {"@AV30tCurrentCode",SqlDbType.NVarChar,40,0}
        } ;
        Object[] prmT000E37 ;
        prmT000E37 = new Object[] {
        new Object[] {"@BR_Information_ID",SqlDbType.Decimal,18,0}
        } ;
        def= new CursorDef[] {
            new CursorDef("T000E2", "SELECT [BR_EncounterID], [BR_Encounter_EncID], [BR_Encounter_Status], [BR_Encounter_CrtUser], [BR_Encounter_CrtDisplayName], [BR_Encounter_CrtDate], [BR_Encounter_Department_Code], [BR_Encounter_ENCType_Code], [BR_Encounter_AdmitSource_Code], [BR_Encounter_DischargeStatus_Code], [BR_Encounter_Department], [BR_Encounter_Departmentadm], [BR_Encounter_Departmentadm_Code], [BR_Encounter_Departmentdisch], [BR_Encounter_Departmentdisch_Code], [BR_Encounter_ENCType], [BR_Encounter_AdmitDate], [BR_Encounter_AdmitSource], [BR_Encounter_DischargeDate], [BR_Encounter_DischargeStatus], [BR_Encounter_Insurance], [BR_Encounter_Insurance_Code], [BR_Encounter_UpdDate], [BR_Encounter_UpdUser], [BR_Encounter_IsDLT], [BR_Encounter_SubmitUser], [BR_Encounter_Reason], [BR_Encounter_SubmitDate], [BR_Encounter_RecheckUser], [BR_Encounter_FReason], [BR_Encounter_RecheckDate], [BR_Encounter_Approver], [BR_Encounter_ApproveDate], [BR_Encounter_IsRandApprove], [BR_Encounter_IsRandApprover], [BR_Encounter_IsRandNoApprover], [BR_Encounter_IsRandApproveDate], [BR_Encounter_IsRandNoApproveDate], [BR_Encounter_IsRandRecheck], [BR_Encounter_IsRandRecheckr], [BR_Encounter_IsRandNoRecheckr], [BR_Encounter_IsRandRecheckDate], [BR_Encounter_IsRandNoRecheckDate], [BR_Encounter_IsUpdate], [BR_Encounter_Datasource], [EncounterIDEncrypt], [BR_Information_ID], [BAS_TenantTenantCode] FROM [BR_Encounter] WITH (UPDLOCK) WHERE [BR_EncounterID] = @BR_EncounterID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000E2,1,0,true,false )
           ,new CursorDef("T000E3", "SELECT [BR_EncounterID], [BR_Encounter_EncID], [BR_Encounter_Status], [BR_Encounter_CrtUser], [BR_Encounter_CrtDisplayName], [BR_Encounter_CrtDate], [BR_Encounter_Department_Code], [BR_Encounter_ENCType_Code], [BR_Encounter_AdmitSource_Code], [BR_Encounter_DischargeStatus_Code], [BR_Encounter_Department], [BR_Encounter_Departmentadm], [BR_Encounter_Departmentadm_Code], [BR_Encounter_Departmentdisch], [BR_Encounter_Departmentdisch_Code], [BR_Encounter_ENCType], [BR_Encounter_AdmitDate], [BR_Encounter_AdmitSource], [BR_Encounter_DischargeDate], [BR_Encounter_DischargeStatus], [BR_Encounter_Insurance], [BR_Encounter_Insurance_Code], [BR_Encounter_UpdDate], [BR_Encounter_UpdUser], [BR_Encounter_IsDLT], [BR_Encounter_SubmitUser], [BR_Encounter_Reason], [BR_Encounter_SubmitDate], [BR_Encounter_RecheckUser], [BR_Encounter_FReason], [BR_Encounter_RecheckDate], [BR_Encounter_Approver], [BR_Encounter_ApproveDate], [BR_Encounter_IsRandApprove], [BR_Encounter_IsRandApprover], [BR_Encounter_IsRandNoApprover], [BR_Encounter_IsRandApproveDate], [BR_Encounter_IsRandNoApproveDate], [BR_Encounter_IsRandRecheck], [BR_Encounter_IsRandRecheckr], [BR_Encounter_IsRandNoRecheckr], [BR_Encounter_IsRandRecheckDate], [BR_Encounter_IsRandNoRecheckDate], [BR_Encounter_IsUpdate], [BR_Encounter_Datasource], [EncounterIDEncrypt], [BR_Information_ID], [BAS_TenantTenantCode] FROM [BR_Encounter] WITH (NOLOCK) WHERE [BR_EncounterID] = @BR_EncounterID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000E3,1,0,true,false )
           ,new CursorDef("T000E4", "SELECT [BR_Information_PatientNo] FROM [BR_Information] WITH (NOLOCK) WHERE [BR_Information_ID] = @BR_Information_ID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000E4,1,0,true,false )
           ,new CursorDef("T000E6", "SELECT [BR_Information_ID] FROM [BR_PatientReTenant] WITH (NOLOCK) WHERE [BR_Information_ID] = @BR_Information_ID AND [BAS_TenantTenantCode] = @BAS_TenantTenantCode ",true, GxErrorMask.GX_NOMASK, false, this,prmT000E6,1,0,true,false )
           ,new CursorDef("T000E7", cmdBufferT000E7,true, GxErrorMask.GX_NOMASK, false, this,prmT000E7,100,0,true,false )
           ,new CursorDef("T000E8", "SELECT [BR_Information_PatientNo] FROM [BR_Information] WITH (NOLOCK) WHERE [BR_Information_ID] = @BR_Information_ID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000E8,1,0,true,false )
           ,new CursorDef("T000E9", "SELECT [BR_Information_ID] FROM [BR_PatientReTenant] WITH (NOLOCK) WHERE [BR_Information_ID] = @BR_Information_ID AND [BAS_TenantTenantCode] = @BAS_TenantTenantCode ",true, GxErrorMask.GX_NOMASK, false, this,prmT000E9,1,0,true,false )
           ,new CursorDef("T000E11", "SELECT [BR_EncounterID] FROM [BR_Encounter] WITH (NOLOCK) WHERE [BR_EncounterID] = @BR_EncounterID  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000E11,1,0,true,false )
           ,new CursorDef("T000E12", "SELECT TOP 1 [BR_EncounterID] FROM [BR_Encounter] WITH (NOLOCK) WHERE ( [BR_EncounterID] > @BR_EncounterID) ORDER BY [BR_EncounterID]  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000E12,1,0,true,true )
           ,new CursorDef("T000E13", "SELECT TOP 1 [BR_EncounterID] FROM [BR_Encounter] WITH (NOLOCK) WHERE ( [BR_EncounterID] < @BR_EncounterID) ORDER BY [BR_EncounterID] DESC  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000E13,1,0,true,true )
           ,new CursorDef("T000E14", cmdBufferT000E14, GxErrorMask.GX_NOMASK,prmT000E14)
           ,new CursorDef("T000E15", cmdBufferT000E15, GxErrorMask.GX_NOMASK,prmT000E15)
           ,new CursorDef("T000E16", "DELETE FROM [BR_Encounter]  WHERE [BR_EncounterID] = @BR_EncounterID", GxErrorMask.GX_NOMASK,prmT000E16)
           ,new CursorDef("T000E17", "SELECT [BR_Information_PatientNo] FROM [BR_Information] WITH (NOLOCK) WHERE [BR_Information_ID] = @BR_Information_ID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000E17,1,0,true,false )
           ,new CursorDef("T000E18", "SELECT TOP 1 [BR_Encounter_RefuseReasonID] FROM [BR_Encounter_RefuseReason] WITH (NOLOCK) WHERE [BR_EncounterID] = @BR_EncounterID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000E18,1,0,true,true )
           ,new CursorDef("T000E19", "SELECT TOP 1 [BR_Encounter_ID] FROM [BR_EncounterReason] WITH (NOLOCK) WHERE [BR_EncounterID] = @BR_EncounterID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000E19,1,0,true,true )
           ,new CursorDef("T000E20", "SELECT TOP 1 [BR_SchemeID] FROM [BR_Scheme] WITH (NOLOCK) WHERE [BR_EncounterID] = @BR_EncounterID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000E20,1,0,true,true )
           ,new CursorDef("T000E21", "SELECT TOP 1 [BR_PathologyID] FROM [BR_Pathology] WITH (NOLOCK) WHERE [BR_EncounterID] = @BR_EncounterID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000E21,1,0,true,true )
           ,new CursorDef("T000E22", "SELECT TOP 1 [BR_MedicalImagingID] FROM [BR_MedicalImaging] WITH (NOLOCK) WHERE [BR_EncounterID] = @BR_EncounterID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000E22,1,0,true,true )
           ,new CursorDef("T000E23", "SELECT TOP 1 [BR_VitalID] FROM [BR_Vital] WITH (NOLOCK) WHERE [BR_EncounterID] = @BR_EncounterID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000E23,1,0,true,true )
           ,new CursorDef("T000E24", "SELECT TOP 1 [BR_ProcedureID] FROM [BR_Procedure] WITH (NOLOCK) WHERE [BR_EncounterID] = @BR_EncounterID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000E24,1,0,true,true )
           ,new CursorDef("T000E25", "SELECT TOP 1 [BR_MedicationID] FROM [BR_Medication] WITH (NOLOCK) WHERE [BR_EncounterID] = @BR_EncounterID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000E25,1,0,true,true )
           ,new CursorDef("T000E26", "SELECT TOP 1 [BR_LabID] FROM [BR_Lab] WITH (NOLOCK) WHERE [BR_EncounterID] = @BR_EncounterID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000E26,1,0,true,true )
           ,new CursorDef("T000E27", "SELECT TOP 1 [BR_DiagnosisID] FROM [BR_Diagnosis] WITH (NOLOCK) WHERE [BR_EncounterID] = @BR_EncounterID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000E27,1,0,true,true )
           ,new CursorDef("T000E28", "SELECT TOP 1 [BR_Demographics_ID] FROM [BR_Demographics] WITH (NOLOCK) WHERE [BR_EncounterID] = @BR_EncounterID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000E28,1,0,true,true )
           ,new CursorDef("T000E29", "SELECT TOP 1 [BR_DeathID] FROM [BR_Death] WITH (NOLOCK) WHERE [BR_EncounterID] = @BR_EncounterID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000E29,1,0,true,true )
           ,new CursorDef("T000E30", "SELECT TOP 1 [BR_ComorbidityID] FROM [BR_Comorbidity] WITH (NOLOCK) WHERE [BR_EncounterID] = @BR_EncounterID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000E30,1,0,true,true )
           ,new CursorDef("T000E31", "SELECT TOP 1 [BR_BehaviorID] FROM [BR_Behavior] WITH (NOLOCK) WHERE [BR_EncounterID] = @BR_EncounterID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000E31,1,0,true,true )
           ,new CursorDef("T000E32", "SELECT [BR_EncounterID] FROM [BR_Encounter] WITH (NOLOCK) ORDER BY [BR_EncounterID]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT000E32,100,0,true,false )
           ,new CursorDef("T000E33", "SELECT [XT_DefineCodeID], [XT_DefineCodeName], [XT_DefindcodeTypeID], [XT_TenantCode] FROM [XT_DefineCode] WITH (NOLOCK) WHERE ([XT_DefindcodeTypeID] = 3) AND ([XT_TenantCode] = @AV30tCurrentCode) ",true, GxErrorMask.GX_NOMASK, false, this,prmT000E33,0,0,true,false )
           ,new CursorDef("T000E34", "SELECT [XT_DefineCodeID], [XT_DefineCodeName], [XT_DefindcodeTypeID], [XT_TenantCode] FROM [XT_DefineCode] WITH (NOLOCK) WHERE ([XT_DefindcodeTypeID] = 4) AND ([XT_TenantCode] = @AV30tCurrentCode) ",true, GxErrorMask.GX_NOMASK, false, this,prmT000E34,0,0,true,false )
           ,new CursorDef("T000E35", "SELECT [XT_DefineCodeID], [XT_DefineCodeName], [XT_DefindcodeTypeID], [XT_TenantCode] FROM [XT_DefineCode] WITH (NOLOCK) WHERE ([XT_DefindcodeTypeID] = 5) AND ([XT_TenantCode] = @AV30tCurrentCode) ",true, GxErrorMask.GX_NOMASK, false, this,prmT000E35,0,0,true,false )
           ,new CursorDef("T000E36", "SELECT [XT_DefineCodeID], [XT_DefineCodeName], [XT_DefindcodeTypeID], [XT_TenantCode] FROM [XT_DefineCode] WITH (NOLOCK) WHERE ([XT_DefindcodeTypeID] = 6) AND ([XT_TenantCode] = @AV30tCurrentCode) ",true, GxErrorMask.GX_NOMASK, false, this,prmT000E36,0,0,true,false )
           ,new CursorDef("T000E37", "SELECT [BR_Information_PatientNo] FROM [BR_Information] WITH (NOLOCK) WHERE [BR_Information_ID] = @BR_Information_ID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000E37,1,0,true,false )
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
              ((long[]) buf[1])[0] = rslt.getLong(2) ;
              ((bool[]) buf[2])[0] = rslt.wasNull(2);
              ((short[]) buf[3])[0] = rslt.getShort(3) ;
              ((bool[]) buf[4])[0] = rslt.wasNull(3);
              ((String[]) buf[5])[0] = rslt.getVarchar(4) ;
              ((bool[]) buf[6])[0] = rslt.wasNull(4);
              ((String[]) buf[7])[0] = rslt.getVarchar(5) ;
              ((bool[]) buf[8])[0] = rslt.wasNull(5);
              ((DateTime[]) buf[9])[0] = rslt.getGXDateTime(6) ;
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
              ((DateTime[]) buf[31])[0] = rslt.getGXDate(17) ;
              ((bool[]) buf[32])[0] = rslt.wasNull(17);
              ((String[]) buf[33])[0] = rslt.getVarchar(18) ;
              ((bool[]) buf[34])[0] = rslt.wasNull(18);
              ((DateTime[]) buf[35])[0] = rslt.getGXDate(19) ;
              ((bool[]) buf[36])[0] = rslt.wasNull(19);
              ((String[]) buf[37])[0] = rslt.getVarchar(20) ;
              ((bool[]) buf[38])[0] = rslt.wasNull(20);
              ((String[]) buf[39])[0] = rslt.getVarchar(21) ;
              ((bool[]) buf[40])[0] = rslt.wasNull(21);
              ((String[]) buf[41])[0] = rslt.getVarchar(22) ;
              ((bool[]) buf[42])[0] = rslt.wasNull(22);
              ((DateTime[]) buf[43])[0] = rslt.getGXDateTime(23) ;
              ((bool[]) buf[44])[0] = rslt.wasNull(23);
              ((String[]) buf[45])[0] = rslt.getVarchar(24) ;
              ((bool[]) buf[46])[0] = rslt.wasNull(24);
              ((bool[]) buf[47])[0] = rslt.getBool(25) ;
              ((bool[]) buf[48])[0] = rslt.wasNull(25);
              ((String[]) buf[49])[0] = rslt.getVarchar(26) ;
              ((bool[]) buf[50])[0] = rslt.wasNull(26);
              ((String[]) buf[51])[0] = rslt.getVarchar(27) ;
              ((bool[]) buf[52])[0] = rslt.wasNull(27);
              ((DateTime[]) buf[53])[0] = rslt.getGXDateTime(28) ;
              ((bool[]) buf[54])[0] = rslt.wasNull(28);
              ((String[]) buf[55])[0] = rslt.getVarchar(29) ;
              ((bool[]) buf[56])[0] = rslt.wasNull(29);
              ((String[]) buf[57])[0] = rslt.getVarchar(30) ;
              ((bool[]) buf[58])[0] = rslt.wasNull(30);
              ((DateTime[]) buf[59])[0] = rslt.getGXDateTime(31) ;
              ((bool[]) buf[60])[0] = rslt.wasNull(31);
              ((String[]) buf[61])[0] = rslt.getVarchar(32) ;
              ((bool[]) buf[62])[0] = rslt.wasNull(32);
              ((DateTime[]) buf[63])[0] = rslt.getGXDateTime(33) ;
              ((bool[]) buf[64])[0] = rslt.wasNull(33);
              ((bool[]) buf[65])[0] = rslt.getBool(34) ;
              ((bool[]) buf[66])[0] = rslt.wasNull(34);
              ((String[]) buf[67])[0] = rslt.getVarchar(35) ;
              ((bool[]) buf[68])[0] = rslt.wasNull(35);
              ((String[]) buf[69])[0] = rslt.getVarchar(36) ;
              ((bool[]) buf[70])[0] = rslt.wasNull(36);
              ((DateTime[]) buf[71])[0] = rslt.getGXDateTime(37) ;
              ((bool[]) buf[72])[0] = rslt.wasNull(37);
              ((DateTime[]) buf[73])[0] = rslt.getGXDateTime(38) ;
              ((bool[]) buf[74])[0] = rslt.wasNull(38);
              ((bool[]) buf[75])[0] = rslt.getBool(39) ;
              ((bool[]) buf[76])[0] = rslt.wasNull(39);
              ((String[]) buf[77])[0] = rslt.getVarchar(40) ;
              ((bool[]) buf[78])[0] = rslt.wasNull(40);
              ((String[]) buf[79])[0] = rslt.getVarchar(41) ;
              ((bool[]) buf[80])[0] = rslt.wasNull(41);
              ((DateTime[]) buf[81])[0] = rslt.getGXDateTime(42) ;
              ((bool[]) buf[82])[0] = rslt.wasNull(42);
              ((DateTime[]) buf[83])[0] = rslt.getGXDateTime(43) ;
              ((bool[]) buf[84])[0] = rslt.wasNull(43);
              ((bool[]) buf[85])[0] = rslt.getBool(44) ;
              ((bool[]) buf[86])[0] = rslt.wasNull(44);
              ((short[]) buf[87])[0] = rslt.getShort(45) ;
              ((bool[]) buf[88])[0] = rslt.wasNull(45);
              ((String[]) buf[89])[0] = rslt.getVarchar(46) ;
              ((bool[]) buf[90])[0] = rslt.wasNull(46);
              ((long[]) buf[91])[0] = rslt.getLong(47) ;
              ((bool[]) buf[92])[0] = rslt.wasNull(47);
              ((String[]) buf[93])[0] = rslt.getVarchar(48) ;
              ((bool[]) buf[94])[0] = rslt.wasNull(48);
              return;
           case 1 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              ((long[]) buf[1])[0] = rslt.getLong(2) ;
              ((bool[]) buf[2])[0] = rslt.wasNull(2);
              ((short[]) buf[3])[0] = rslt.getShort(3) ;
              ((bool[]) buf[4])[0] = rslt.wasNull(3);
              ((String[]) buf[5])[0] = rslt.getVarchar(4) ;
              ((bool[]) buf[6])[0] = rslt.wasNull(4);
              ((String[]) buf[7])[0] = rslt.getVarchar(5) ;
              ((bool[]) buf[8])[0] = rslt.wasNull(5);
              ((DateTime[]) buf[9])[0] = rslt.getGXDateTime(6) ;
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
              ((DateTime[]) buf[31])[0] = rslt.getGXDate(17) ;
              ((bool[]) buf[32])[0] = rslt.wasNull(17);
              ((String[]) buf[33])[0] = rslt.getVarchar(18) ;
              ((bool[]) buf[34])[0] = rslt.wasNull(18);
              ((DateTime[]) buf[35])[0] = rslt.getGXDate(19) ;
              ((bool[]) buf[36])[0] = rslt.wasNull(19);
              ((String[]) buf[37])[0] = rslt.getVarchar(20) ;
              ((bool[]) buf[38])[0] = rslt.wasNull(20);
              ((String[]) buf[39])[0] = rslt.getVarchar(21) ;
              ((bool[]) buf[40])[0] = rslt.wasNull(21);
              ((String[]) buf[41])[0] = rslt.getVarchar(22) ;
              ((bool[]) buf[42])[0] = rslt.wasNull(22);
              ((DateTime[]) buf[43])[0] = rslt.getGXDateTime(23) ;
              ((bool[]) buf[44])[0] = rslt.wasNull(23);
              ((String[]) buf[45])[0] = rslt.getVarchar(24) ;
              ((bool[]) buf[46])[0] = rslt.wasNull(24);
              ((bool[]) buf[47])[0] = rslt.getBool(25) ;
              ((bool[]) buf[48])[0] = rslt.wasNull(25);
              ((String[]) buf[49])[0] = rslt.getVarchar(26) ;
              ((bool[]) buf[50])[0] = rslt.wasNull(26);
              ((String[]) buf[51])[0] = rslt.getVarchar(27) ;
              ((bool[]) buf[52])[0] = rslt.wasNull(27);
              ((DateTime[]) buf[53])[0] = rslt.getGXDateTime(28) ;
              ((bool[]) buf[54])[0] = rslt.wasNull(28);
              ((String[]) buf[55])[0] = rslt.getVarchar(29) ;
              ((bool[]) buf[56])[0] = rslt.wasNull(29);
              ((String[]) buf[57])[0] = rslt.getVarchar(30) ;
              ((bool[]) buf[58])[0] = rslt.wasNull(30);
              ((DateTime[]) buf[59])[0] = rslt.getGXDateTime(31) ;
              ((bool[]) buf[60])[0] = rslt.wasNull(31);
              ((String[]) buf[61])[0] = rslt.getVarchar(32) ;
              ((bool[]) buf[62])[0] = rslt.wasNull(32);
              ((DateTime[]) buf[63])[0] = rslt.getGXDateTime(33) ;
              ((bool[]) buf[64])[0] = rslt.wasNull(33);
              ((bool[]) buf[65])[0] = rslt.getBool(34) ;
              ((bool[]) buf[66])[0] = rslt.wasNull(34);
              ((String[]) buf[67])[0] = rslt.getVarchar(35) ;
              ((bool[]) buf[68])[0] = rslt.wasNull(35);
              ((String[]) buf[69])[0] = rslt.getVarchar(36) ;
              ((bool[]) buf[70])[0] = rslt.wasNull(36);
              ((DateTime[]) buf[71])[0] = rslt.getGXDateTime(37) ;
              ((bool[]) buf[72])[0] = rslt.wasNull(37);
              ((DateTime[]) buf[73])[0] = rslt.getGXDateTime(38) ;
              ((bool[]) buf[74])[0] = rslt.wasNull(38);
              ((bool[]) buf[75])[0] = rslt.getBool(39) ;
              ((bool[]) buf[76])[0] = rslt.wasNull(39);
              ((String[]) buf[77])[0] = rslt.getVarchar(40) ;
              ((bool[]) buf[78])[0] = rslt.wasNull(40);
              ((String[]) buf[79])[0] = rslt.getVarchar(41) ;
              ((bool[]) buf[80])[0] = rslt.wasNull(41);
              ((DateTime[]) buf[81])[0] = rslt.getGXDateTime(42) ;
              ((bool[]) buf[82])[0] = rslt.wasNull(42);
              ((DateTime[]) buf[83])[0] = rslt.getGXDateTime(43) ;
              ((bool[]) buf[84])[0] = rslt.wasNull(43);
              ((bool[]) buf[85])[0] = rslt.getBool(44) ;
              ((bool[]) buf[86])[0] = rslt.wasNull(44);
              ((short[]) buf[87])[0] = rslt.getShort(45) ;
              ((bool[]) buf[88])[0] = rslt.wasNull(45);
              ((String[]) buf[89])[0] = rslt.getVarchar(46) ;
              ((bool[]) buf[90])[0] = rslt.wasNull(46);
              ((long[]) buf[91])[0] = rslt.getLong(47) ;
              ((bool[]) buf[92])[0] = rslt.wasNull(47);
              ((String[]) buf[93])[0] = rslt.getVarchar(48) ;
              ((bool[]) buf[94])[0] = rslt.wasNull(48);
              return;
           case 2 :
              ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
              ((bool[]) buf[1])[0] = rslt.wasNull(1);
              return;
           case 3 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              return;
           case 4 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              ((long[]) buf[1])[0] = rslt.getLong(2) ;
              ((bool[]) buf[2])[0] = rslt.wasNull(2);
              ((short[]) buf[3])[0] = rslt.getShort(3) ;
              ((bool[]) buf[4])[0] = rslt.wasNull(3);
              ((String[]) buf[5])[0] = rslt.getVarchar(4) ;
              ((bool[]) buf[6])[0] = rslt.wasNull(4);
              ((String[]) buf[7])[0] = rslt.getVarchar(5) ;
              ((bool[]) buf[8])[0] = rslt.wasNull(5);
              ((DateTime[]) buf[9])[0] = rslt.getGXDateTime(6) ;
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
              ((DateTime[]) buf[31])[0] = rslt.getGXDate(17) ;
              ((bool[]) buf[32])[0] = rslt.wasNull(17);
              ((String[]) buf[33])[0] = rslt.getVarchar(18) ;
              ((bool[]) buf[34])[0] = rslt.wasNull(18);
              ((DateTime[]) buf[35])[0] = rslt.getGXDate(19) ;
              ((bool[]) buf[36])[0] = rslt.wasNull(19);
              ((String[]) buf[37])[0] = rslt.getVarchar(20) ;
              ((bool[]) buf[38])[0] = rslt.wasNull(20);
              ((String[]) buf[39])[0] = rslt.getVarchar(21) ;
              ((bool[]) buf[40])[0] = rslt.wasNull(21);
              ((String[]) buf[41])[0] = rslt.getVarchar(22) ;
              ((bool[]) buf[42])[0] = rslt.wasNull(22);
              ((String[]) buf[43])[0] = rslt.getVarchar(23) ;
              ((bool[]) buf[44])[0] = rslt.wasNull(23);
              ((DateTime[]) buf[45])[0] = rslt.getGXDateTime(24) ;
              ((bool[]) buf[46])[0] = rslt.wasNull(24);
              ((String[]) buf[47])[0] = rslt.getVarchar(25) ;
              ((bool[]) buf[48])[0] = rslt.wasNull(25);
              ((bool[]) buf[49])[0] = rslt.getBool(26) ;
              ((bool[]) buf[50])[0] = rslt.wasNull(26);
              ((String[]) buf[51])[0] = rslt.getVarchar(27) ;
              ((bool[]) buf[52])[0] = rslt.wasNull(27);
              ((String[]) buf[53])[0] = rslt.getVarchar(28) ;
              ((bool[]) buf[54])[0] = rslt.wasNull(28);
              ((DateTime[]) buf[55])[0] = rslt.getGXDateTime(29) ;
              ((bool[]) buf[56])[0] = rslt.wasNull(29);
              ((String[]) buf[57])[0] = rslt.getVarchar(30) ;
              ((bool[]) buf[58])[0] = rslt.wasNull(30);
              ((String[]) buf[59])[0] = rslt.getVarchar(31) ;
              ((bool[]) buf[60])[0] = rslt.wasNull(31);
              ((DateTime[]) buf[61])[0] = rslt.getGXDateTime(32) ;
              ((bool[]) buf[62])[0] = rslt.wasNull(32);
              ((String[]) buf[63])[0] = rslt.getVarchar(33) ;
              ((bool[]) buf[64])[0] = rslt.wasNull(33);
              ((DateTime[]) buf[65])[0] = rslt.getGXDateTime(34) ;
              ((bool[]) buf[66])[0] = rslt.wasNull(34);
              ((bool[]) buf[67])[0] = rslt.getBool(35) ;
              ((bool[]) buf[68])[0] = rslt.wasNull(35);
              ((String[]) buf[69])[0] = rslt.getVarchar(36) ;
              ((bool[]) buf[70])[0] = rslt.wasNull(36);
              ((String[]) buf[71])[0] = rslt.getVarchar(37) ;
              ((bool[]) buf[72])[0] = rslt.wasNull(37);
              ((DateTime[]) buf[73])[0] = rslt.getGXDateTime(38) ;
              ((bool[]) buf[74])[0] = rslt.wasNull(38);
              ((DateTime[]) buf[75])[0] = rslt.getGXDateTime(39) ;
              ((bool[]) buf[76])[0] = rslt.wasNull(39);
              ((bool[]) buf[77])[0] = rslt.getBool(40) ;
              ((bool[]) buf[78])[0] = rslt.wasNull(40);
              ((String[]) buf[79])[0] = rslt.getVarchar(41) ;
              ((bool[]) buf[80])[0] = rslt.wasNull(41);
              ((String[]) buf[81])[0] = rslt.getVarchar(42) ;
              ((bool[]) buf[82])[0] = rslt.wasNull(42);
              ((DateTime[]) buf[83])[0] = rslt.getGXDateTime(43) ;
              ((bool[]) buf[84])[0] = rslt.wasNull(43);
              ((DateTime[]) buf[85])[0] = rslt.getGXDateTime(44) ;
              ((bool[]) buf[86])[0] = rslt.wasNull(44);
              ((bool[]) buf[87])[0] = rslt.getBool(45) ;
              ((bool[]) buf[88])[0] = rslt.wasNull(45);
              ((short[]) buf[89])[0] = rslt.getShort(46) ;
              ((bool[]) buf[90])[0] = rslt.wasNull(46);
              ((String[]) buf[91])[0] = rslt.getVarchar(47) ;
              ((bool[]) buf[92])[0] = rslt.wasNull(47);
              ((long[]) buf[93])[0] = rslt.getLong(48) ;
              ((bool[]) buf[94])[0] = rslt.wasNull(48);
              ((String[]) buf[95])[0] = rslt.getVarchar(49) ;
              ((bool[]) buf[96])[0] = rslt.wasNull(49);
              return;
           case 5 :
              ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
              ((bool[]) buf[1])[0] = rslt.wasNull(1);
              return;
           case 6 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
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
              ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
              ((bool[]) buf[1])[0] = rslt.wasNull(1);
              return;
           case 14 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              return;
           case 15 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              return;
           case 16 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              return;
           case 17 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              return;
           case 18 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              return;
           case 19 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              return;
           case 20 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              return;
           case 21 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              return;
           case 22 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              return;
           case 23 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              return;
           case 24 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              return;
           case 25 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              return;
           case 26 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              return;
           case 27 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              return;
           case 28 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              return;
           case 29 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
              ((bool[]) buf[2])[0] = rslt.wasNull(2);
              ((long[]) buf[3])[0] = rslt.getLong(3) ;
              ((String[]) buf[4])[0] = rslt.getVarchar(4) ;
              ((bool[]) buf[5])[0] = rslt.wasNull(4);
              return;
     }
     getresults30( cursor, rslt, buf) ;
  }

  public void getresults30( int cursor ,
                            IFieldGetter rslt ,
                            Object[] buf )
  {
     switch ( cursor )
     {
           case 30 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
              ((bool[]) buf[2])[0] = rslt.wasNull(2);
              ((long[]) buf[3])[0] = rslt.getLong(3) ;
              ((String[]) buf[4])[0] = rslt.getVarchar(4) ;
              ((bool[]) buf[5])[0] = rslt.wasNull(4);
              return;
           case 31 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
              ((bool[]) buf[2])[0] = rslt.wasNull(2);
              ((long[]) buf[3])[0] = rslt.getLong(3) ;
              ((String[]) buf[4])[0] = rslt.getVarchar(4) ;
              ((bool[]) buf[5])[0] = rslt.wasNull(4);
              return;
           case 32 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
              ((bool[]) buf[2])[0] = rslt.wasNull(2);
              ((long[]) buf[3])[0] = rslt.getLong(3) ;
              ((String[]) buf[4])[0] = rslt.getVarchar(4) ;
              ((bool[]) buf[5])[0] = rslt.wasNull(4);
              return;
           case 33 :
              ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
              ((bool[]) buf[1])[0] = rslt.wasNull(1);
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
              if ( (bool)parms[2] )
              {
                 stmt.setNull( 2 , SqlDbType.NVarChar );
              }
              else
              {
                 stmt.SetParameter(2, (String)parms[3]);
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
                 stmt.setNull( 1 , SqlDbType.Decimal );
              }
              else
              {
                 stmt.SetParameter(1, (long)parms[1]);
              }
              if ( (bool)parms[2] )
              {
                 stmt.setNull( 2 , SqlDbType.NVarChar );
              }
              else
              {
                 stmt.SetParameter(2, (String)parms[3]);
              }
              return;
           case 7 :
              if ( (bool)parms[0] )
              {
                 stmt.setNull( 1 , SqlDbType.Decimal );
              }
              else
              {
                 stmt.SetParameter(1, (long)parms[1]);
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
              if ( (bool)parms[2] )
              {
                 stmt.setNull( 2 , SqlDbType.SmallInt );
              }
              else
              {
                 stmt.SetParameter(2, (short)parms[3]);
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
                 stmt.setNull( 5 , SqlDbType.DateTime );
              }
              else
              {
                 stmt.SetParameterDatetime(5, (DateTime)parms[9]);
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
                 stmt.setNull( 16 , SqlDbType.DateTime );
              }
              else
              {
                 stmt.SetParameter(16, (DateTime)parms[31]);
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
                 stmt.setNull( 22 , SqlDbType.DateTime );
              }
              else
              {
                 stmt.SetParameterDatetime(22, (DateTime)parms[43]);
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
                 stmt.setNull( 24 , SqlDbType.Bit );
              }
              else
              {
                 stmt.SetParameter(24, (bool)parms[47]);
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
                 stmt.setNull( 27 , SqlDbType.DateTime );
              }
              else
              {
                 stmt.SetParameterDatetime(27, (DateTime)parms[53]);
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
              if ( (bool)parms[58] )
              {
                 stmt.setNull( 30 , SqlDbType.DateTime );
              }
              else
              {
                 stmt.SetParameterDatetime(30, (DateTime)parms[59]);
              }
              if ( (bool)parms[60] )
              {
                 stmt.setNull( 31 , SqlDbType.NVarChar );
              }
              else
              {
                 stmt.SetParameter(31, (String)parms[61]);
              }
              if ( (bool)parms[62] )
              {
                 stmt.setNull( 32 , SqlDbType.DateTime );
              }
              else
              {
                 stmt.SetParameterDatetime(32, (DateTime)parms[63]);
              }
              if ( (bool)parms[64] )
              {
                 stmt.setNull( 33 , SqlDbType.Bit );
              }
              else
              {
                 stmt.SetParameter(33, (bool)parms[65]);
              }
              if ( (bool)parms[66] )
              {
                 stmt.setNull( 34 , SqlDbType.NVarChar );
              }
              else
              {
                 stmt.SetParameter(34, (String)parms[67]);
              }
              if ( (bool)parms[68] )
              {
                 stmt.setNull( 35 , SqlDbType.NVarChar );
              }
              else
              {
                 stmt.SetParameter(35, (String)parms[69]);
              }
              if ( (bool)parms[70] )
              {
                 stmt.setNull( 36 , SqlDbType.DateTime );
              }
              else
              {
                 stmt.SetParameterDatetime(36, (DateTime)parms[71]);
              }
              if ( (bool)parms[72] )
              {
                 stmt.setNull( 37 , SqlDbType.DateTime );
              }
              else
              {
                 stmt.SetParameterDatetime(37, (DateTime)parms[73]);
              }
              if ( (bool)parms[74] )
              {
                 stmt.setNull( 38 , SqlDbType.Bit );
              }
              else
              {
                 stmt.SetParameter(38, (bool)parms[75]);
              }
              if ( (bool)parms[76] )
              {
                 stmt.setNull( 39 , SqlDbType.NVarChar );
              }
              else
              {
                 stmt.SetParameter(39, (String)parms[77]);
              }
              if ( (bool)parms[78] )
              {
                 stmt.setNull( 40 , SqlDbType.NVarChar );
              }
              else
              {
                 stmt.SetParameter(40, (String)parms[79]);
              }
              if ( (bool)parms[80] )
              {
                 stmt.setNull( 41 , SqlDbType.DateTime );
              }
              else
              {
                 stmt.SetParameterDatetime(41, (DateTime)parms[81]);
              }
              if ( (bool)parms[82] )
              {
                 stmt.setNull( 42 , SqlDbType.DateTime );
              }
              else
              {
                 stmt.SetParameterDatetime(42, (DateTime)parms[83]);
              }
              if ( (bool)parms[84] )
              {
                 stmt.setNull( 43 , SqlDbType.Bit );
              }
              else
              {
                 stmt.SetParameter(43, (bool)parms[85]);
              }
              if ( (bool)parms[86] )
              {
                 stmt.setNull( 44 , SqlDbType.SmallInt );
              }
              else
              {
                 stmt.SetParameter(44, (short)parms[87]);
              }
              if ( (bool)parms[88] )
              {
                 stmt.setNull( 45 , SqlDbType.NVarChar );
              }
              else
              {
                 stmt.SetParameter(45, (String)parms[89]);
              }
              if ( (bool)parms[90] )
              {
                 stmt.setNull( 46 , SqlDbType.Decimal );
              }
              else
              {
                 stmt.SetParameter(46, (long)parms[91]);
              }
              if ( (bool)parms[92] )
              {
                 stmt.setNull( 47 , SqlDbType.NVarChar );
              }
              else
              {
                 stmt.SetParameter(47, (String)parms[93]);
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
              if ( (bool)parms[2] )
              {
                 stmt.setNull( 2 , SqlDbType.SmallInt );
              }
              else
              {
                 stmt.SetParameter(2, (short)parms[3]);
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
                 stmt.setNull( 5 , SqlDbType.DateTime );
              }
              else
              {
                 stmt.SetParameterDatetime(5, (DateTime)parms[9]);
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
                 stmt.setNull( 16 , SqlDbType.DateTime );
              }
              else
              {
                 stmt.SetParameter(16, (DateTime)parms[31]);
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
                 stmt.setNull( 22 , SqlDbType.DateTime );
              }
              else
              {
                 stmt.SetParameterDatetime(22, (DateTime)parms[43]);
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
                 stmt.setNull( 24 , SqlDbType.Bit );
              }
              else
              {
                 stmt.SetParameter(24, (bool)parms[47]);
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
                 stmt.setNull( 27 , SqlDbType.DateTime );
              }
              else
              {
                 stmt.SetParameterDatetime(27, (DateTime)parms[53]);
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
              if ( (bool)parms[58] )
              {
                 stmt.setNull( 30 , SqlDbType.DateTime );
              }
              else
              {
                 stmt.SetParameterDatetime(30, (DateTime)parms[59]);
              }
              if ( (bool)parms[60] )
              {
                 stmt.setNull( 31 , SqlDbType.NVarChar );
              }
              else
              {
                 stmt.SetParameter(31, (String)parms[61]);
              }
              if ( (bool)parms[62] )
              {
                 stmt.setNull( 32 , SqlDbType.DateTime );
              }
              else
              {
                 stmt.SetParameterDatetime(32, (DateTime)parms[63]);
              }
              if ( (bool)parms[64] )
              {
                 stmt.setNull( 33 , SqlDbType.Bit );
              }
              else
              {
                 stmt.SetParameter(33, (bool)parms[65]);
              }
              if ( (bool)parms[66] )
              {
                 stmt.setNull( 34 , SqlDbType.NVarChar );
              }
              else
              {
                 stmt.SetParameter(34, (String)parms[67]);
              }
              if ( (bool)parms[68] )
              {
                 stmt.setNull( 35 , SqlDbType.NVarChar );
              }
              else
              {
                 stmt.SetParameter(35, (String)parms[69]);
              }
              if ( (bool)parms[70] )
              {
                 stmt.setNull( 36 , SqlDbType.DateTime );
              }
              else
              {
                 stmt.SetParameterDatetime(36, (DateTime)parms[71]);
              }
              if ( (bool)parms[72] )
              {
                 stmt.setNull( 37 , SqlDbType.DateTime );
              }
              else
              {
                 stmt.SetParameterDatetime(37, (DateTime)parms[73]);
              }
              if ( (bool)parms[74] )
              {
                 stmt.setNull( 38 , SqlDbType.Bit );
              }
              else
              {
                 stmt.SetParameter(38, (bool)parms[75]);
              }
              if ( (bool)parms[76] )
              {
                 stmt.setNull( 39 , SqlDbType.NVarChar );
              }
              else
              {
                 stmt.SetParameter(39, (String)parms[77]);
              }
              if ( (bool)parms[78] )
              {
                 stmt.setNull( 40 , SqlDbType.NVarChar );
              }
              else
              {
                 stmt.SetParameter(40, (String)parms[79]);
              }
              if ( (bool)parms[80] )
              {
                 stmt.setNull( 41 , SqlDbType.DateTime );
              }
              else
              {
                 stmt.SetParameterDatetime(41, (DateTime)parms[81]);
              }
              if ( (bool)parms[82] )
              {
                 stmt.setNull( 42 , SqlDbType.DateTime );
              }
              else
              {
                 stmt.SetParameterDatetime(42, (DateTime)parms[83]);
              }
              if ( (bool)parms[84] )
              {
                 stmt.setNull( 43 , SqlDbType.Bit );
              }
              else
              {
                 stmt.SetParameter(43, (bool)parms[85]);
              }
              if ( (bool)parms[86] )
              {
                 stmt.setNull( 44 , SqlDbType.SmallInt );
              }
              else
              {
                 stmt.SetParameter(44, (short)parms[87]);
              }
              if ( (bool)parms[88] )
              {
                 stmt.setNull( 45 , SqlDbType.NVarChar );
              }
              else
              {
                 stmt.SetParameter(45, (String)parms[89]);
              }
              if ( (bool)parms[90] )
              {
                 stmt.setNull( 46 , SqlDbType.Decimal );
              }
              else
              {
                 stmt.SetParameter(46, (long)parms[91]);
              }
              if ( (bool)parms[92] )
              {
                 stmt.setNull( 47 , SqlDbType.NVarChar );
              }
              else
              {
                 stmt.SetParameter(47, (String)parms[93]);
              }
              if ( (bool)parms[94] )
              {
                 stmt.setNull( 48 , SqlDbType.Decimal );
              }
              else
              {
                 stmt.SetParameter(48, (long)parms[95]);
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
           case 15 :
              if ( (bool)parms[0] )
              {
                 stmt.setNull( 1 , SqlDbType.Decimal );
              }
              else
              {
                 stmt.SetParameter(1, (long)parms[1]);
              }
              return;
           case 16 :
              if ( (bool)parms[0] )
              {
                 stmt.setNull( 1 , SqlDbType.Decimal );
              }
              else
              {
                 stmt.SetParameter(1, (long)parms[1]);
              }
              return;
           case 17 :
              if ( (bool)parms[0] )
              {
                 stmt.setNull( 1 , SqlDbType.Decimal );
              }
              else
              {
                 stmt.SetParameter(1, (long)parms[1]);
              }
              return;
           case 18 :
              if ( (bool)parms[0] )
              {
                 stmt.setNull( 1 , SqlDbType.Decimal );
              }
              else
              {
                 stmt.SetParameter(1, (long)parms[1]);
              }
              return;
           case 19 :
              if ( (bool)parms[0] )
              {
                 stmt.setNull( 1 , SqlDbType.Decimal );
              }
              else
              {
                 stmt.SetParameter(1, (long)parms[1]);
              }
              return;
           case 20 :
              if ( (bool)parms[0] )
              {
                 stmt.setNull( 1 , SqlDbType.Decimal );
              }
              else
              {
                 stmt.SetParameter(1, (long)parms[1]);
              }
              return;
           case 21 :
              if ( (bool)parms[0] )
              {
                 stmt.setNull( 1 , SqlDbType.Decimal );
              }
              else
              {
                 stmt.SetParameter(1, (long)parms[1]);
              }
              return;
           case 22 :
              if ( (bool)parms[0] )
              {
                 stmt.setNull( 1 , SqlDbType.Decimal );
              }
              else
              {
                 stmt.SetParameter(1, (long)parms[1]);
              }
              return;
           case 23 :
              if ( (bool)parms[0] )
              {
                 stmt.setNull( 1 , SqlDbType.Decimal );
              }
              else
              {
                 stmt.SetParameter(1, (long)parms[1]);
              }
              return;
           case 24 :
              if ( (bool)parms[0] )
              {
                 stmt.setNull( 1 , SqlDbType.Decimal );
              }
              else
              {
                 stmt.SetParameter(1, (long)parms[1]);
              }
              return;
           case 25 :
              if ( (bool)parms[0] )
              {
                 stmt.setNull( 1 , SqlDbType.Decimal );
              }
              else
              {
                 stmt.SetParameter(1, (long)parms[1]);
              }
              return;
           case 26 :
              if ( (bool)parms[0] )
              {
                 stmt.setNull( 1 , SqlDbType.Decimal );
              }
              else
              {
                 stmt.SetParameter(1, (long)parms[1]);
              }
              return;
           case 27 :
              if ( (bool)parms[0] )
              {
                 stmt.setNull( 1 , SqlDbType.Decimal );
              }
              else
              {
                 stmt.SetParameter(1, (long)parms[1]);
              }
              return;
           case 29 :
              stmt.SetParameter(1, (String)parms[0]);
              return;
     }
     setparameters30( cursor, stmt, parms) ;
  }

  public void setparameters30( int cursor ,
                               IFieldSetter stmt ,
                               Object[] parms )
  {
     switch ( cursor )
     {
           case 30 :
              stmt.SetParameter(1, (String)parms[0]);
              return;
           case 31 :
              stmt.SetParameter(1, (String)parms[0]);
              return;
           case 32 :
              stmt.SetParameter(1, (String)parms[0]);
              return;
           case 33 :
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
