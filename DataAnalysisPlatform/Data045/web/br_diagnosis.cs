/*
               File: BR_Diagnosis
        Description: Data Mgmt Portal - RAAP
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/28/2020 15:6:37.98
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
   public class br_diagnosis : GXDataArea, System.Web.SessionState.IRequiresSessionState
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
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxJX_Action25") == 0 )
         {
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            XC_25_0C13( ) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxJX_Action26") == 0 )
         {
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            XC_26_0C13( ) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxJX_Action27") == 0 )
         {
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            XC_27_0C13( ) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxCallCrl"+"_"+"BR_DIAGNOSIS_DXTSOURCE") == 0 )
         {
            AV15tCurrentCode = GetNextPar( );
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV15tCurrentCode", AV15tCurrentCode);
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            GXDLABR_DIAGNOSIS_DXTSOURCE0C13( AV15tCurrentCode) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxCallCrl"+"_"+"BR_DIAGNOSIS_DXTYPE") == 0 )
         {
            AV15tCurrentCode = GetNextPar( );
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV15tCurrentCode", AV15tCurrentCode);
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            GXDLABR_DIAGNOSIS_DXTYPE0C13( AV15tCurrentCode) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxAggSel11"+"_"+"BR_DIAGNOSIS_DXTYPE_CODE") == 0 )
         {
            A67BR_Diagnosis_DXType = GetNextPar( );
            n67BR_Diagnosis_DXType = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A67BR_Diagnosis_DXType", A67BR_Diagnosis_DXType);
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            GX11ASABR_DIAGNOSIS_DXTYPE_CODE0C13( A67BR_Diagnosis_DXType) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxAggSel12"+"_"+"BR_DIAGNOSIS_DXTYPE_CODE") == 0 )
         {
            A67BR_Diagnosis_DXType = GetNextPar( );
            n67BR_Diagnosis_DXType = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A67BR_Diagnosis_DXType", A67BR_Diagnosis_DXType);
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            GX12ASABR_DIAGNOSIS_DXTYPE_CODE0C13( A67BR_Diagnosis_DXType) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxAggSel13"+"_"+"BR_DIAGNOSIS_DXTSOURCE_CODE") == 0 )
         {
            A68BR_Diagnosis_DXTsource = GetNextPar( );
            n68BR_Diagnosis_DXTsource = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A68BR_Diagnosis_DXTsource", A68BR_Diagnosis_DXTsource);
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            GX13ASABR_DIAGNOSIS_DXTSOURCE_CODE0C13( A68BR_Diagnosis_DXTsource) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxAggSel14"+"_"+"BR_DIAGNOSIS_DXTSOURCE_CODE") == 0 )
         {
            A68BR_Diagnosis_DXTsource = GetNextPar( );
            n68BR_Diagnosis_DXTsource = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A68BR_Diagnosis_DXTsource", A68BR_Diagnosis_DXTsource);
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            GX14ASABR_DIAGNOSIS_DXTSOURCE_CODE0C13( A68BR_Diagnosis_DXTsource) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxAggSel15"+"_"+"BR_DIAGNOSIS_INITIALDX_CODE") == 0 )
         {
            A70BR_Diagnosis_InitialDX = GetNextPar( );
            n70BR_Diagnosis_InitialDX = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A70BR_Diagnosis_InitialDX", A70BR_Diagnosis_InitialDX);
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            GX15ASABR_DIAGNOSIS_INITIALDX_CODE0C13( A70BR_Diagnosis_InitialDX) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxAggSel16"+"_"+"BR_DIAGNOSIS_INITIALDX_CODE") == 0 )
         {
            A70BR_Diagnosis_InitialDX = GetNextPar( );
            n70BR_Diagnosis_InitialDX = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A70BR_Diagnosis_InitialDX", A70BR_Diagnosis_InitialDX);
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            GX16ASABR_DIAGNOSIS_INITIALDX_CODE0C13( A70BR_Diagnosis_InitialDX) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxAggSel17"+"_"+"BR_DIAGNOSIS_METASTASESDX_CODE") == 0 )
         {
            A71BR_Diagnosis_MetastasesDX = GetNextPar( );
            n71BR_Diagnosis_MetastasesDX = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A71BR_Diagnosis_MetastasesDX", A71BR_Diagnosis_MetastasesDX);
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            GX17ASABR_DIAGNOSIS_METASTASESDX_CODE0C13( A71BR_Diagnosis_MetastasesDX) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxAggSel18"+"_"+"BR_DIAGNOSIS_METASTASESDX_CODE") == 0 )
         {
            A71BR_Diagnosis_MetastasesDX = GetNextPar( );
            n71BR_Diagnosis_MetastasesDX = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A71BR_Diagnosis_MetastasesDX", A71BR_Diagnosis_MetastasesDX);
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            GX18ASABR_DIAGNOSIS_METASTASESDX_CODE0C13( A71BR_Diagnosis_MetastasesDX) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxExecAct_"+"gxLoad_29") == 0 )
         {
            A19BR_EncounterID = (long)(NumberUtil.Val( GetNextPar( ), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A19BR_EncounterID", StringUtil.LTrim( StringUtil.Str( (decimal)(A19BR_EncounterID), 18, 0)));
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            gxLoad_29( A19BR_EncounterID) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxExecAct_"+"gxLoad_30") == 0 )
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
            gxLoad_30( A85BR_Information_ID) ;
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
               AV12BR_DiagnosisID = (long)(NumberUtil.Val( GetNextPar( ), "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12BR_DiagnosisID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV12BR_DiagnosisID), 18, 0)));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vBR_DIAGNOSISID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV12BR_DiagnosisID), "ZZZZZZZZZZZZZZZZZZ"), context));
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
            Form.Meta.addItem("description", "Data Mgmt Portal - RAAP", 0) ;
         }
         context.wjLoc = "";
         context.nUserReturn = 0;
         context.wbHandled = 0;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         GX_FocusControl = edtBR_Diagnosis_No_Internalname;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         wbErr = false;
         context.SetDefaultTheme("WorkWithPlusTheme");
         if ( ! context.IsLocalStorageSupported( ) )
         {
            context.PushCurrentUrl();
         }
      }

      public br_diagnosis( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public br_diagnosis( IGxContext context )
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
                           long aP1_BR_DiagnosisID )
      {
         this.Gx_mode = aP0_Gx_mode;
         this.AV12BR_DiagnosisID = aP1_BR_DiagnosisID;
         executePrivate();
      }

      void executePrivate( )
      {
         isStatic = false;
         webExecute();
      }

      protected override void createObjects( )
      {
         dynBR_Diagnosis_DXTsource = new GXCombobox();
         dynBR_Diagnosis_DXType = new GXCombobox();
         cmbBR_Diagnosis_InitialDX = new GXCombobox();
         cmbBR_Diagnosis_MetastasesDX = new GXCombobox();
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
         if ( dynBR_Diagnosis_DXTsource.ItemCount > 0 )
         {
            A68BR_Diagnosis_DXTsource = dynBR_Diagnosis_DXTsource.getValidValue(A68BR_Diagnosis_DXTsource);
            n68BR_Diagnosis_DXTsource = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A68BR_Diagnosis_DXTsource", A68BR_Diagnosis_DXTsource);
         }
         if ( context.isAjaxRequest( ) )
         {
            dynBR_Diagnosis_DXTsource.CurrentValue = StringUtil.RTrim( A68BR_Diagnosis_DXTsource);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynBR_Diagnosis_DXTsource_Internalname, "Values", dynBR_Diagnosis_DXTsource.ToJavascriptSource(), true);
         }
         if ( dynBR_Diagnosis_DXType.ItemCount > 0 )
         {
            A67BR_Diagnosis_DXType = dynBR_Diagnosis_DXType.getValidValue(A67BR_Diagnosis_DXType);
            n67BR_Diagnosis_DXType = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A67BR_Diagnosis_DXType", A67BR_Diagnosis_DXType);
         }
         if ( context.isAjaxRequest( ) )
         {
            dynBR_Diagnosis_DXType.CurrentValue = StringUtil.RTrim( A67BR_Diagnosis_DXType);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynBR_Diagnosis_DXType_Internalname, "Values", dynBR_Diagnosis_DXType.ToJavascriptSource(), true);
         }
         if ( cmbBR_Diagnosis_InitialDX.ItemCount > 0 )
         {
            A70BR_Diagnosis_InitialDX = cmbBR_Diagnosis_InitialDX.getValidValue(A70BR_Diagnosis_InitialDX);
            n70BR_Diagnosis_InitialDX = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A70BR_Diagnosis_InitialDX", A70BR_Diagnosis_InitialDX);
         }
         if ( context.isAjaxRequest( ) )
         {
            cmbBR_Diagnosis_InitialDX.CurrentValue = StringUtil.RTrim( A70BR_Diagnosis_InitialDX);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbBR_Diagnosis_InitialDX_Internalname, "Values", cmbBR_Diagnosis_InitialDX.ToJavascriptSource(), true);
         }
         if ( cmbBR_Diagnosis_MetastasesDX.ItemCount > 0 )
         {
            A71BR_Diagnosis_MetastasesDX = cmbBR_Diagnosis_MetastasesDX.getValidValue(A71BR_Diagnosis_MetastasesDX);
            n71BR_Diagnosis_MetastasesDX = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A71BR_Diagnosis_MetastasesDX", A71BR_Diagnosis_MetastasesDX);
         }
         if ( context.isAjaxRequest( ) )
         {
            cmbBR_Diagnosis_MetastasesDX.CurrentValue = StringUtil.RTrim( A71BR_Diagnosis_MetastasesDX);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbBR_Diagnosis_MetastasesDX_Internalname, "Values", cmbBR_Diagnosis_MetastasesDX.ToJavascriptSource(), true);
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
            GxWebStd.gx_div_start( context, divUnnamedtablebr_diagnosis_no_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-4 MergeLabelCell", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblockbr_diagnosis_no_Internalname, "诊断次序", "", "", lblTextblockbr_diagnosis_no_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_BR_Diagnosis.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-8", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtBR_Diagnosis_No_Internalname, "诊断次序", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 29,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtBR_Diagnosis_No_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A513BR_Diagnosis_No), 10, 0, ".", "")), ((edtBR_Diagnosis_No_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A513BR_Diagnosis_No), "ZZZZZZZZZZ")) : context.localUtil.Format( (decimal)(A513BR_Diagnosis_No), "ZZZZZZZZZZ")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,29);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBR_Diagnosis_No_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtBR_Diagnosis_No_Enabled, 0, "number", "1", 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_BR_Diagnosis.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-md-6 RequiredDataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divUnnamedtablebr_diagnosis_dxdescription_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-4 MergeLabelCell", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblockbr_diagnosis_dxdescription_Internalname, "诊断名称", "", "", lblTextblockbr_diagnosis_dxdescription_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_BR_Diagnosis.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-8", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtBR_Diagnosis_DXDescription_Internalname, "诊断名称", "col-sm-3 Attribute_DelGrayLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 37,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtBR_Diagnosis_DXDescription_Internalname, A69BR_Diagnosis_DXDescription, StringUtil.RTrim( context.localUtil.Format( A69BR_Diagnosis_DXDescription, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,37);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBR_Diagnosis_DXDescription_Jsonclick, 0, "Attribute_DelGray", "", "", "", "", 1, edtBR_Diagnosis_DXDescription_Enabled, 0, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_BR_Diagnosis.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-md-6 RequiredDataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divUnnamedtablebr_diagnosis_dxtsource_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-4 MergeLabelCell", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblockbr_diagnosis_dxtsource_Internalname, "诊断来源", "", "", lblTextblockbr_diagnosis_dxtsource_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_BR_Diagnosis.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-8", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, dynBR_Diagnosis_DXTsource_Internalname, "诊断来源", "col-sm-3 AttributeLabel", 0, true);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 46,'',false,'',0)\"";
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, dynBR_Diagnosis_DXTsource, dynBR_Diagnosis_DXTsource_Internalname, StringUtil.RTrim( A68BR_Diagnosis_DXTsource), 1, dynBR_Diagnosis_DXTsource_Jsonclick, 0, "'"+""+"'"+",false,"+"'"+""+"'", "svchar", "", 1, dynBR_Diagnosis_DXTsource.Enabled, 0, 0, 0, "em", 0, "", "", "Attribute", "", "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,46);\"", "", true, "HLP_BR_Diagnosis.htm");
            dynBR_Diagnosis_DXTsource.CurrentValue = StringUtil.RTrim( A68BR_Diagnosis_DXTsource);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynBR_Diagnosis_DXTsource_Internalname, "Values", (String)(dynBR_Diagnosis_DXTsource.ToJavascriptSource()), true);
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-md-6 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divUnnamedtablebr_diagnosis_dxid_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-4 MergeLabelCell", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblockbr_diagnosis_dxid_Internalname, "疾病序号", "", "", lblTextblockbr_diagnosis_dxid_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_BR_Diagnosis.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-8", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtBR_Diagnosis_DXID_Internalname, "疾病序号", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 54,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtBR_Diagnosis_DXID_Internalname, A65BR_Diagnosis_DXID, StringUtil.RTrim( context.localUtil.Format( A65BR_Diagnosis_DXID, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,54);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBR_Diagnosis_DXID_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtBR_Diagnosis_DXID_Enabled, 0, "text", "", 40, "chr", 1, "row", 40, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_BR_Diagnosis.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
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
            GxWebStd.gx_div_start( context, divUnnamedtablebr_diagnosis_dxcode_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-4 MergeLabelCell", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblockbr_diagnosis_dxcode_Internalname, "疾病代码", "", "", lblTextblockbr_diagnosis_dxcode_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_BR_Diagnosis.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-8", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtBR_Diagnosis_DXCode_Internalname, "疾病代码", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 63,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtBR_Diagnosis_DXCode_Internalname, A66BR_Diagnosis_DXCode, StringUtil.RTrim( context.localUtil.Format( A66BR_Diagnosis_DXCode, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,63);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBR_Diagnosis_DXCode_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtBR_Diagnosis_DXCode_Enabled, 0, "text", "", 40, "chr", 1, "row", 40, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_BR_Diagnosis.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-md-6 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divUnnamedtablebr_diagnosis_dxtype_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-4 MergeLabelCell", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblockbr_diagnosis_dxtype_Internalname, "疾病类型", "", "", lblTextblockbr_diagnosis_dxtype_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_BR_Diagnosis.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-8", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, dynBR_Diagnosis_DXType_Internalname, "疾病类型", "col-sm-3 AttributeLabel", 0, true);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 71,'',false,'',0)\"";
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, dynBR_Diagnosis_DXType, dynBR_Diagnosis_DXType_Internalname, StringUtil.RTrim( A67BR_Diagnosis_DXType), 1, dynBR_Diagnosis_DXType_Jsonclick, 0, "'"+""+"'"+",false,"+"'"+""+"'", "svchar", "", 1, dynBR_Diagnosis_DXType.Enabled, 0, 0, 0, "em", 0, "", "", "Attribute", "", "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,71);\"", "", true, "HLP_BR_Diagnosis.htm");
            dynBR_Diagnosis_DXType.CurrentValue = StringUtil.RTrim( A67BR_Diagnosis_DXType);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynBR_Diagnosis_DXType_Internalname, "Values", (String)(dynBR_Diagnosis_DXType.ToJavascriptSource()), true);
            GxWebStd.gx_div_end( context, "left", "top", "div");
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
            GxWebStd.gx_div_start( context, divUnnamedtablebr_diagnosis_initialdx_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-4 MergeLabelCell", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblockbr_diagnosis_initialdx_Internalname, "是否为原发肿瘤", "", "", lblTextblockbr_diagnosis_initialdx_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_BR_Diagnosis.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-8", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, cmbBR_Diagnosis_InitialDX_Internalname, "是否为原发肿瘤", "col-sm-3 AttributeLabel", 0, true);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 80,'',false,'',0)\"";
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, cmbBR_Diagnosis_InitialDX, cmbBR_Diagnosis_InitialDX_Internalname, StringUtil.RTrim( A70BR_Diagnosis_InitialDX), 1, cmbBR_Diagnosis_InitialDX_Jsonclick, 0, "'"+""+"'"+",false,"+"'"+""+"'", "svchar", "", 1, cmbBR_Diagnosis_InitialDX.Enabled, 0, 0, 0, "em", 0, "", "", "Attribute", "", "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,80);\"", "", true, "HLP_BR_Diagnosis.htm");
            cmbBR_Diagnosis_InitialDX.CurrentValue = StringUtil.RTrim( A70BR_Diagnosis_InitialDX);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbBR_Diagnosis_InitialDX_Internalname, "Values", (String)(cmbBR_Diagnosis_InitialDX.ToJavascriptSource()), true);
            GxWebStd.gx_div_end( context, "left", "top", "div");
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
            GxWebStd.gx_div_start( context, divUnnamedtablebr_diagnosis_metastasesdx_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-4 MergeLabelCell", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblockbr_diagnosis_metastasesdx_Internalname, "是否为转移肿瘤", "", "", lblTextblockbr_diagnosis_metastasesdx_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_BR_Diagnosis.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-8", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, cmbBR_Diagnosis_MetastasesDX_Internalname, "是否为转移肿瘤", "col-sm-3 AttributeLabel", 0, true);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 89,'',false,'',0)\"";
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, cmbBR_Diagnosis_MetastasesDX, cmbBR_Diagnosis_MetastasesDX_Internalname, StringUtil.RTrim( A71BR_Diagnosis_MetastasesDX), 1, cmbBR_Diagnosis_MetastasesDX_Jsonclick, 0, "'"+""+"'"+",false,"+"'"+""+"'", "svchar", "", 1, cmbBR_Diagnosis_MetastasesDX.Enabled, 0, 0, 0, "em", 0, "", "", "Attribute", "", "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,89);\"", "", true, "HLP_BR_Diagnosis.htm");
            cmbBR_Diagnosis_MetastasesDX.CurrentValue = StringUtil.RTrim( A71BR_Diagnosis_MetastasesDX);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbBR_Diagnosis_MetastasesDX_Internalname, "Values", (String)(cmbBR_Diagnosis_MetastasesDX.ToJavascriptSource()), true);
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divBr_diagnosis_dxsource_cell_Internalname, 1, 0, "px", 0, "px", divBr_diagnosis_dxsource_cell_Class, "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divUnnamedtablebr_diagnosis_dxsource_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-4 MergeLabelCell", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblockbr_diagnosis_dxsource_Internalname, "转移肿瘤来源", "", "", lblTextblockbr_diagnosis_dxsource_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_BR_Diagnosis.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-8", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtBR_Diagnosis_DXSource_Internalname, "转移肿瘤来源", "col-sm-3 Attribute_DelGrayLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 97,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtBR_Diagnosis_DXSource_Internalname, A260BR_Diagnosis_DXSource, StringUtil.RTrim( context.localUtil.Format( A260BR_Diagnosis_DXSource, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,97);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBR_Diagnosis_DXSource_Jsonclick, 0, "Attribute_DelGray", "", "", "", "", edtBR_Diagnosis_DXSource_Visible, edtBR_Diagnosis_DXSource_Enabled, 0, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_BR_Diagnosis.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtBR_Diagnosis_TumorStageClinical_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtBR_Diagnosis_TumorStageClinical_Internalname, "肿瘤临床分期", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 102,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtBR_Diagnosis_TumorStageClinical_Internalname, A569BR_Diagnosis_TumorStageClinical, StringUtil.RTrim( context.localUtil.Format( A569BR_Diagnosis_TumorStageClinical, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,102);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBR_Diagnosis_TumorStageClinical_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtBR_Diagnosis_TumorStageClinical_Enabled, 0, "text", "", 40, "chr", 1, "row", 40, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_BR_Diagnosis.htm");
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
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 107,'',false,'',0)\"";
            ClassString = "ButtonMaterial";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtntrn_enter_Internalname, "", "保存", bttBtntrn_enter_Jsonclick, 5, "确认", "", StyleString, ClassString, bttBtntrn_enter_Visible, bttBtntrn_enter_Enabled, "standard", "'"+""+"'"+",false,"+"'"+"EENTER."+"'", TempTags, "", context.GetButtonType( ), "HLP_BR_Diagnosis.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 109,'',false,'',0)\"";
            ClassString = "ButtonMaterialDefault";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtntrn_cancel_Internalname, "", "取消", bttBtntrn_cancel_Jsonclick, 1, "取消", "", StyleString, ClassString, bttBtntrn_cancel_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ECANCEL."+"'", TempTags, "", context.GetButtonType( ), "HLP_BR_Diagnosis.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 111,'',false,'',0)\"";
            ClassString = "ButtonMaterialDefault";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtntrn_delete_Internalname, "", "删除", bttBtntrn_delete_Jsonclick, 5, "删除", "", StyleString, ClassString, bttBtntrn_delete_Visible, bttBtntrn_delete_Enabled, "standard", "'"+""+"'"+",false,"+"'"+"EDELETE."+"'", TempTags, "", context.GetButtonType( ), "HLP_BR_Diagnosis.htm");
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
            GxWebStd.gx_single_line_edit( context, edtBR_DiagnosisID_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A64BR_DiagnosisID), 18, 0, ".", "")), ((edtBR_DiagnosisID_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A64BR_DiagnosisID), "ZZZZZZZZZZZZZZZZZZ")) : context.localUtil.Format( (decimal)(A64BR_DiagnosisID), "ZZZZZZZZZZZZZZZZZZ")), "", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBR_DiagnosisID_Jsonclick, 0, "Attribute", "", "", "", "", edtBR_DiagnosisID_Visible, edtBR_DiagnosisID_Enabled, 0, "number", "1", 18, "chr", 1, "row", 18, 0, 0, 0, 1, -1, 0, true, "ID", "right", false, "HLP_BR_Diagnosis.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 116,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtBR_EncounterID_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A19BR_EncounterID), 18, 0, ".", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(A19BR_EncounterID), "ZZZZZZZZZZZZZZZZZZ")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,116);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBR_EncounterID_Jsonclick, 0, "Attribute", "", "", "", "", edtBR_EncounterID_Visible, edtBR_EncounterID_Enabled, 1, "number", "1", 18, "chr", 1, "row", 18, 0, 0, 0, 1, -1, 0, true, "ID", "right", false, "HLP_BR_Diagnosis.htm");
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtBR_Information_PatientNo_Internalname, A36BR_Information_PatientNo, StringUtil.RTrim( context.localUtil.Format( A36BR_Information_PatientNo, "")), "", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBR_Information_PatientNo_Jsonclick, 0, "Attribute", "", "", "", "", edtBR_Information_PatientNo_Visible, edtBR_Information_PatientNo_Enabled, 0, "text", "", 80, "chr", 1, "row", 2000, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_BR_Diagnosis.htm");
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
         E110C2 ();
         context.wbGlbDoneStart = 1;
         assign_properties_default( ) ;
         if ( AnyError == 0 )
         {
            if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
            {
               /* Read saved SDTs. */
               /* Read variables values. */
               if ( ( ( context.localUtil.CToN( cgiGet( edtBR_Diagnosis_No_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtBR_Diagnosis_No_Internalname), ".", ",") > Convert.ToDecimal( 9999999999L )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "BR_DIAGNOSIS_NO");
                  AnyError = 1;
                  GX_FocusControl = edtBR_Diagnosis_No_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A513BR_Diagnosis_No = 0;
                  n513BR_Diagnosis_No = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A513BR_Diagnosis_No", StringUtil.LTrim( StringUtil.Str( (decimal)(A513BR_Diagnosis_No), 10, 0)));
               }
               else
               {
                  A513BR_Diagnosis_No = (long)(context.localUtil.CToN( cgiGet( edtBR_Diagnosis_No_Internalname), ".", ","));
                  n513BR_Diagnosis_No = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A513BR_Diagnosis_No", StringUtil.LTrim( StringUtil.Str( (decimal)(A513BR_Diagnosis_No), 10, 0)));
               }
               n513BR_Diagnosis_No = ((0==A513BR_Diagnosis_No) ? true : false);
               A69BR_Diagnosis_DXDescription = cgiGet( edtBR_Diagnosis_DXDescription_Internalname);
               n69BR_Diagnosis_DXDescription = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A69BR_Diagnosis_DXDescription", A69BR_Diagnosis_DXDescription);
               n69BR_Diagnosis_DXDescription = (String.IsNullOrEmpty(StringUtil.RTrim( A69BR_Diagnosis_DXDescription)) ? true : false);
               dynBR_Diagnosis_DXTsource.CurrentValue = cgiGet( dynBR_Diagnosis_DXTsource_Internalname);
               A68BR_Diagnosis_DXTsource = cgiGet( dynBR_Diagnosis_DXTsource_Internalname);
               n68BR_Diagnosis_DXTsource = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A68BR_Diagnosis_DXTsource", A68BR_Diagnosis_DXTsource);
               n68BR_Diagnosis_DXTsource = (String.IsNullOrEmpty(StringUtil.RTrim( A68BR_Diagnosis_DXTsource)) ? true : false);
               A65BR_Diagnosis_DXID = cgiGet( edtBR_Diagnosis_DXID_Internalname);
               n65BR_Diagnosis_DXID = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A65BR_Diagnosis_DXID", A65BR_Diagnosis_DXID);
               n65BR_Diagnosis_DXID = (String.IsNullOrEmpty(StringUtil.RTrim( A65BR_Diagnosis_DXID)) ? true : false);
               A66BR_Diagnosis_DXCode = cgiGet( edtBR_Diagnosis_DXCode_Internalname);
               n66BR_Diagnosis_DXCode = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A66BR_Diagnosis_DXCode", A66BR_Diagnosis_DXCode);
               n66BR_Diagnosis_DXCode = (String.IsNullOrEmpty(StringUtil.RTrim( A66BR_Diagnosis_DXCode)) ? true : false);
               dynBR_Diagnosis_DXType.CurrentValue = cgiGet( dynBR_Diagnosis_DXType_Internalname);
               A67BR_Diagnosis_DXType = cgiGet( dynBR_Diagnosis_DXType_Internalname);
               n67BR_Diagnosis_DXType = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A67BR_Diagnosis_DXType", A67BR_Diagnosis_DXType);
               n67BR_Diagnosis_DXType = (String.IsNullOrEmpty(StringUtil.RTrim( A67BR_Diagnosis_DXType)) ? true : false);
               cmbBR_Diagnosis_InitialDX.CurrentValue = cgiGet( cmbBR_Diagnosis_InitialDX_Internalname);
               A70BR_Diagnosis_InitialDX = cgiGet( cmbBR_Diagnosis_InitialDX_Internalname);
               n70BR_Diagnosis_InitialDX = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A70BR_Diagnosis_InitialDX", A70BR_Diagnosis_InitialDX);
               n70BR_Diagnosis_InitialDX = (String.IsNullOrEmpty(StringUtil.RTrim( A70BR_Diagnosis_InitialDX)) ? true : false);
               cmbBR_Diagnosis_MetastasesDX.CurrentValue = cgiGet( cmbBR_Diagnosis_MetastasesDX_Internalname);
               A71BR_Diagnosis_MetastasesDX = cgiGet( cmbBR_Diagnosis_MetastasesDX_Internalname);
               n71BR_Diagnosis_MetastasesDX = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A71BR_Diagnosis_MetastasesDX", A71BR_Diagnosis_MetastasesDX);
               n71BR_Diagnosis_MetastasesDX = (String.IsNullOrEmpty(StringUtil.RTrim( A71BR_Diagnosis_MetastasesDX)) ? true : false);
               A260BR_Diagnosis_DXSource = cgiGet( edtBR_Diagnosis_DXSource_Internalname);
               n260BR_Diagnosis_DXSource = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A260BR_Diagnosis_DXSource", A260BR_Diagnosis_DXSource);
               n260BR_Diagnosis_DXSource = (String.IsNullOrEmpty(StringUtil.RTrim( A260BR_Diagnosis_DXSource)) ? true : false);
               A569BR_Diagnosis_TumorStageClinical = cgiGet( edtBR_Diagnosis_TumorStageClinical_Internalname);
               n569BR_Diagnosis_TumorStageClinical = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A569BR_Diagnosis_TumorStageClinical", A569BR_Diagnosis_TumorStageClinical);
               n569BR_Diagnosis_TumorStageClinical = (String.IsNullOrEmpty(StringUtil.RTrim( A569BR_Diagnosis_TumorStageClinical)) ? true : false);
               A64BR_DiagnosisID = (long)(context.localUtil.CToN( cgiGet( edtBR_DiagnosisID_Internalname), ".", ","));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A64BR_DiagnosisID", StringUtil.LTrim( StringUtil.Str( (decimal)(A64BR_DiagnosisID), 18, 0)));
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
               A36BR_Information_PatientNo = cgiGet( edtBR_Information_PatientNo_Internalname);
               n36BR_Information_PatientNo = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A36BR_Information_PatientNo", A36BR_Information_PatientNo);
               /* Read saved values. */
               Z64BR_DiagnosisID = (long)(context.localUtil.CToN( cgiGet( "Z64BR_DiagnosisID"), ".", ","));
               Z466BR_Diagnosis_DXType_Code = cgiGet( "Z466BR_Diagnosis_DXType_Code");
               n466BR_Diagnosis_DXType_Code = (String.IsNullOrEmpty(StringUtil.RTrim( A466BR_Diagnosis_DXType_Code)) ? true : false);
               Z467BR_Diagnosis_DXTsource_Code = cgiGet( "Z467BR_Diagnosis_DXTsource_Code");
               n467BR_Diagnosis_DXTsource_Code = (String.IsNullOrEmpty(StringUtil.RTrim( A467BR_Diagnosis_DXTsource_Code)) ? true : false);
               Z503BR_Diagnosis_InitialDX_Code = cgiGet( "Z503BR_Diagnosis_InitialDX_Code");
               n503BR_Diagnosis_InitialDX_Code = (String.IsNullOrEmpty(StringUtil.RTrim( A503BR_Diagnosis_InitialDX_Code)) ? true : false);
               Z504BR_Diagnosis_MetastasesDX_Code = cgiGet( "Z504BR_Diagnosis_MetastasesDX_Code");
               n504BR_Diagnosis_MetastasesDX_Code = (String.IsNullOrEmpty(StringUtil.RTrim( A504BR_Diagnosis_MetastasesDX_Code)) ? true : false);
               Z513BR_Diagnosis_No = (long)(context.localUtil.CToN( cgiGet( "Z513BR_Diagnosis_No"), ".", ","));
               n513BR_Diagnosis_No = ((0==A513BR_Diagnosis_No) ? true : false);
               Z65BR_Diagnosis_DXID = cgiGet( "Z65BR_Diagnosis_DXID");
               n65BR_Diagnosis_DXID = (String.IsNullOrEmpty(StringUtil.RTrim( A65BR_Diagnosis_DXID)) ? true : false);
               Z66BR_Diagnosis_DXCode = cgiGet( "Z66BR_Diagnosis_DXCode");
               n66BR_Diagnosis_DXCode = (String.IsNullOrEmpty(StringUtil.RTrim( A66BR_Diagnosis_DXCode)) ? true : false);
               Z67BR_Diagnosis_DXType = cgiGet( "Z67BR_Diagnosis_DXType");
               n67BR_Diagnosis_DXType = (String.IsNullOrEmpty(StringUtil.RTrim( A67BR_Diagnosis_DXType)) ? true : false);
               Z68BR_Diagnosis_DXTsource = cgiGet( "Z68BR_Diagnosis_DXTsource");
               n68BR_Diagnosis_DXTsource = (String.IsNullOrEmpty(StringUtil.RTrim( A68BR_Diagnosis_DXTsource)) ? true : false);
               Z69BR_Diagnosis_DXDescription = cgiGet( "Z69BR_Diagnosis_DXDescription");
               n69BR_Diagnosis_DXDescription = (String.IsNullOrEmpty(StringUtil.RTrim( A69BR_Diagnosis_DXDescription)) ? true : false);
               Z70BR_Diagnosis_InitialDX = cgiGet( "Z70BR_Diagnosis_InitialDX");
               n70BR_Diagnosis_InitialDX = (String.IsNullOrEmpty(StringUtil.RTrim( A70BR_Diagnosis_InitialDX)) ? true : false);
               Z71BR_Diagnosis_MetastasesDX = cgiGet( "Z71BR_Diagnosis_MetastasesDX");
               n71BR_Diagnosis_MetastasesDX = (String.IsNullOrEmpty(StringUtil.RTrim( A71BR_Diagnosis_MetastasesDX)) ? true : false);
               Z260BR_Diagnosis_DXSource = cgiGet( "Z260BR_Diagnosis_DXSource");
               n260BR_Diagnosis_DXSource = (String.IsNullOrEmpty(StringUtil.RTrim( A260BR_Diagnosis_DXSource)) ? true : false);
               Z569BR_Diagnosis_TumorStageClinical = cgiGet( "Z569BR_Diagnosis_TumorStageClinical");
               n569BR_Diagnosis_TumorStageClinical = (String.IsNullOrEmpty(StringUtil.RTrim( A569BR_Diagnosis_TumorStageClinical)) ? true : false);
               Z19BR_EncounterID = (long)(context.localUtil.CToN( cgiGet( "Z19BR_EncounterID"), ".", ","));
               A466BR_Diagnosis_DXType_Code = cgiGet( "Z466BR_Diagnosis_DXType_Code");
               n466BR_Diagnosis_DXType_Code = false;
               n466BR_Diagnosis_DXType_Code = (String.IsNullOrEmpty(StringUtil.RTrim( A466BR_Diagnosis_DXType_Code)) ? true : false);
               A467BR_Diagnosis_DXTsource_Code = cgiGet( "Z467BR_Diagnosis_DXTsource_Code");
               n467BR_Diagnosis_DXTsource_Code = false;
               n467BR_Diagnosis_DXTsource_Code = (String.IsNullOrEmpty(StringUtil.RTrim( A467BR_Diagnosis_DXTsource_Code)) ? true : false);
               A503BR_Diagnosis_InitialDX_Code = cgiGet( "Z503BR_Diagnosis_InitialDX_Code");
               n503BR_Diagnosis_InitialDX_Code = false;
               n503BR_Diagnosis_InitialDX_Code = (String.IsNullOrEmpty(StringUtil.RTrim( A503BR_Diagnosis_InitialDX_Code)) ? true : false);
               A504BR_Diagnosis_MetastasesDX_Code = cgiGet( "Z504BR_Diagnosis_MetastasesDX_Code");
               n504BR_Diagnosis_MetastasesDX_Code = false;
               n504BR_Diagnosis_MetastasesDX_Code = (String.IsNullOrEmpty(StringUtil.RTrim( A504BR_Diagnosis_MetastasesDX_Code)) ? true : false);
               IsConfirmed = (short)(context.localUtil.CToN( cgiGet( "IsConfirmed"), ".", ","));
               IsModified = (short)(context.localUtil.CToN( cgiGet( "IsModified"), ".", ","));
               Gx_mode = cgiGet( "Mode");
               N19BR_EncounterID = (long)(context.localUtil.CToN( cgiGet( "N19BR_EncounterID"), ".", ","));
               AV12BR_DiagnosisID = (long)(context.localUtil.CToN( cgiGet( "vBR_DIAGNOSISID"), ".", ","));
               AV10Insert_BR_EncounterID = (long)(context.localUtil.CToN( cgiGet( "vINSERT_BR_ENCOUNTERID"), ".", ","));
               A466BR_Diagnosis_DXType_Code = cgiGet( "BR_DIAGNOSIS_DXTYPE_CODE");
               n466BR_Diagnosis_DXType_Code = (String.IsNullOrEmpty(StringUtil.RTrim( A466BR_Diagnosis_DXType_Code)) ? true : false);
               A467BR_Diagnosis_DXTsource_Code = cgiGet( "BR_DIAGNOSIS_DXTSOURCE_CODE");
               n467BR_Diagnosis_DXTsource_Code = (String.IsNullOrEmpty(StringUtil.RTrim( A467BR_Diagnosis_DXTsource_Code)) ? true : false);
               A503BR_Diagnosis_InitialDX_Code = cgiGet( "BR_DIAGNOSIS_INITIALDX_CODE");
               n503BR_Diagnosis_InitialDX_Code = (String.IsNullOrEmpty(StringUtil.RTrim( A503BR_Diagnosis_InitialDX_Code)) ? true : false);
               A504BR_Diagnosis_MetastasesDX_Code = cgiGet( "BR_DIAGNOSIS_METASTASESDX_CODE");
               n504BR_Diagnosis_MetastasesDX_Code = (String.IsNullOrEmpty(StringUtil.RTrim( A504BR_Diagnosis_MetastasesDX_Code)) ? true : false);
               AV15tCurrentCode = cgiGet( "vTCURRENTCODE");
               A85BR_Information_ID = (long)(context.localUtil.CToN( cgiGet( "BR_INFORMATION_ID"), ".", ","));
               AV16Pgmname = cgiGet( "vPGMNAME");
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
               forbiddenHiddens = "hsh" + "BR_Diagnosis";
               A64BR_DiagnosisID = (long)(context.localUtil.CToN( cgiGet( edtBR_DiagnosisID_Internalname), ".", ","));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A64BR_DiagnosisID", StringUtil.LTrim( StringUtil.Str( (decimal)(A64BR_DiagnosisID), 18, 0)));
               forbiddenHiddens = forbiddenHiddens + context.localUtil.Format( (decimal)(A64BR_DiagnosisID), "ZZZZZZZZZZZZZZZZZZ");
               forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( AV15tCurrentCode, ""));
               forbiddenHiddens = forbiddenHiddens + context.localUtil.Format( (decimal)(AV10Insert_BR_EncounterID), "ZZZZZZZZZZZZZZZZZZ");
               forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!"));
               hsh = cgiGet( "hsh");
               if ( ( ! ( ( A64BR_DiagnosisID != Z64BR_DiagnosisID ) ) || ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) ) && ! GXUtil.CheckEncryptedHash( forbiddenHiddens, hsh, GXKey) )
               {
                  GXUtil.WriteLog("br_diagnosis:[SecurityCheckFailed value for]"+"BR_DiagnosisID:"+context.localUtil.Format( (decimal)(A64BR_DiagnosisID), "ZZZZZZZZZZZZZZZZZZ"));
                  GXUtil.WriteLog("br_diagnosis:[SecurityCheckFailed value for]"+"tCurrentCode:"+StringUtil.RTrim( context.localUtil.Format( AV15tCurrentCode, "")));
                  GXUtil.WriteLog("br_diagnosis:[SecurityCheckFailed value for]"+"Insert_BR_EncounterID:"+context.localUtil.Format( (decimal)(AV10Insert_BR_EncounterID), "ZZZZZZZZZZZZZZZZZZ"));
                  GXUtil.WriteLog("br_diagnosis:[SecurityCheckFailed value for]"+"Gx_mode:"+StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")));
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
                  A64BR_DiagnosisID = (long)(NumberUtil.Val( GetNextPar( ), "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A64BR_DiagnosisID", StringUtil.LTrim( StringUtil.Str( (decimal)(A64BR_DiagnosisID), 18, 0)));
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
                     sMode13 = Gx_mode;
                     Gx_mode = "UPD";
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                     Gx_mode = sMode13;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                  }
                  standaloneModal( ) ;
                  if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
                  {
                     getByPrimaryKey( ) ;
                     if ( RcdFound13 == 1 )
                     {
                        if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
                        {
                           /* Confirm record */
                           CONFIRM_0C0( ) ;
                           if ( AnyError == 0 )
                           {
                              GX_FocusControl = bttBtntrn_enter_Internalname;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                           }
                        }
                     }
                     else
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_noinsert", ""), 1, "BR_DIAGNOSISID");
                        AnyError = 1;
                        GX_FocusControl = edtBR_DiagnosisID_Internalname;
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
                           E110C2 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "AFTER TRN") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           /* Execute user event: After Trn */
                           E120C2 ();
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
            E120C2 ();
            trnEnded = 0;
            standaloneNotModal( ) ;
            standaloneModal( ) ;
            if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  )
            {
               /* Clear variables for new insertion. */
               InitAll0C13( ) ;
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
            DisableAttributes0C13( ) ;
         }
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
               CloseExtendedTableCursors0C13( ) ;
            }
         }
         if ( AnyError == 0 )
         {
            IsConfirmed = 1;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "IsConfirmed", StringUtil.LTrim( StringUtil.Str( (decimal)(IsConfirmed), 4, 0)));
         }
      }

      protected void ResetCaption0C0( )
      {
      }

      protected void E110C2( )
      {
         /* Start Routine */
         GXt_char1 = AV15tCurrentCode;
         new zbr_getcurrenttcode(context ).execute( out  GXt_char1) ;
         AV15tCurrentCode = GXt_char1;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV15tCurrentCode", AV15tCurrentCode);
         new GeneXus.Programs.wwpbaseobjects.loadwwpcontext(context ).execute( out  AV7WWPContext) ;
         AV13IsAuthorized = true;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13IsAuthorized", AV13IsAuthorized);
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            GXt_boolean2 = AV13IsAuthorized;
            new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "Manage_Diagnosis", out  GXt_boolean2) ;
            AV13IsAuthorized = GXt_boolean2;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13IsAuthorized", AV13IsAuthorized);
         }
         if ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 )
         {
            GXt_boolean2 = AV13IsAuthorized;
            new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "Manage_Diagnosis", out  GXt_boolean2) ;
            AV13IsAuthorized = GXt_boolean2;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13IsAuthorized", AV13IsAuthorized);
         }
         if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
         {
            GXt_boolean2 = AV13IsAuthorized;
            new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "Manage_Diagnosis", out  GXt_boolean2) ;
            AV13IsAuthorized = GXt_boolean2;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13IsAuthorized", AV13IsAuthorized);
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
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV17GXV1", StringUtil.LTrim( StringUtil.Str( (decimal)(AV17GXV1), 8, 0)));
            while ( AV17GXV1 <= AV8TrnContext.gxTpr_Attributes.Count )
            {
               AV11TrnContextAtt = ((GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext_Attribute)AV8TrnContext.gxTpr_Attributes.Item(AV17GXV1));
               if ( StringUtil.StrCmp(AV11TrnContextAtt.gxTpr_Attributename, "BR_EncounterID") == 0 )
               {
                  AV10Insert_BR_EncounterID = (long)(NumberUtil.Val( AV11TrnContextAtt.gxTpr_Attributevalue, "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10Insert_BR_EncounterID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10Insert_BR_EncounterID), 18, 0)));
               }
               AV17GXV1 = (int)(AV17GXV1+1);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV17GXV1", StringUtil.LTrim( StringUtil.Str( (decimal)(AV17GXV1), 8, 0)));
            }
         }
         edtBR_DiagnosisID_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_DiagnosisID_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBR_DiagnosisID_Visible), 5, 0)), true);
         edtBR_EncounterID_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_EncounterID_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBR_EncounterID_Visible), 5, 0)), true);
         edtBR_Information_PatientNo_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Information_PatientNo_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBR_Information_PatientNo_Visible), 5, 0)), true);
      }

      protected void E120C2( )
      {
         /* After Trn Routine */
         if ( ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 ) && ! AV8TrnContext.gxTpr_Callerondelete )
         {
            CallWebObject(formatLink("br_diagnosisww.aspx") );
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
         edtBR_Diagnosis_DXSource_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Diagnosis_DXSource_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBR_Diagnosis_DXSource_Visible), 5, 0)), true);
         divBr_diagnosis_dxsource_cell_Class = "Invisible";
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, divBr_diagnosis_dxsource_cell_Internalname, "Class", divBr_diagnosis_dxsource_cell_Class, true);
      }

      protected void ZM0C13( short GX_JID )
      {
         if ( ( GX_JID == 28 ) || ( GX_JID == 0 ) )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
            {
               Z466BR_Diagnosis_DXType_Code = T000C3_A466BR_Diagnosis_DXType_Code[0];
               Z467BR_Diagnosis_DXTsource_Code = T000C3_A467BR_Diagnosis_DXTsource_Code[0];
               Z503BR_Diagnosis_InitialDX_Code = T000C3_A503BR_Diagnosis_InitialDX_Code[0];
               Z504BR_Diagnosis_MetastasesDX_Code = T000C3_A504BR_Diagnosis_MetastasesDX_Code[0];
               Z513BR_Diagnosis_No = T000C3_A513BR_Diagnosis_No[0];
               Z65BR_Diagnosis_DXID = T000C3_A65BR_Diagnosis_DXID[0];
               Z66BR_Diagnosis_DXCode = T000C3_A66BR_Diagnosis_DXCode[0];
               Z67BR_Diagnosis_DXType = T000C3_A67BR_Diagnosis_DXType[0];
               Z68BR_Diagnosis_DXTsource = T000C3_A68BR_Diagnosis_DXTsource[0];
               Z69BR_Diagnosis_DXDescription = T000C3_A69BR_Diagnosis_DXDescription[0];
               Z70BR_Diagnosis_InitialDX = T000C3_A70BR_Diagnosis_InitialDX[0];
               Z71BR_Diagnosis_MetastasesDX = T000C3_A71BR_Diagnosis_MetastasesDX[0];
               Z260BR_Diagnosis_DXSource = T000C3_A260BR_Diagnosis_DXSource[0];
               Z569BR_Diagnosis_TumorStageClinical = T000C3_A569BR_Diagnosis_TumorStageClinical[0];
               Z19BR_EncounterID = T000C3_A19BR_EncounterID[0];
            }
            else
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
         }
         if ( GX_JID == -28 )
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
         edtBR_DiagnosisID_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_DiagnosisID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBR_DiagnosisID_Enabled), 5, 0)), true);
         edtBR_DiagnosisID_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_DiagnosisID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBR_DiagnosisID_Enabled), 5, 0)), true);
         bttBtntrn_delete_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtntrn_delete_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtntrn_delete_Enabled), 5, 0)), true);
         if ( ! (0==AV12BR_DiagnosisID) )
         {
            A64BR_DiagnosisID = AV12BR_DiagnosisID;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A64BR_DiagnosisID", StringUtil.LTrim( StringUtil.Str( (decimal)(A64BR_DiagnosisID), 18, 0)));
         }
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) && ! (0==AV10Insert_BR_EncounterID) )
         {
            edtBR_EncounterID_Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_EncounterID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBR_EncounterID_Enabled), 5, 0)), true);
         }
         else
         {
            edtBR_EncounterID_Enabled = 1;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_EncounterID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBR_EncounterID_Enabled), 5, 0)), true);
         }
         GXABR_DIAGNOSIS_DXTSOURCE_html0C13( AV15tCurrentCode) ;
         GXABR_DIAGNOSIS_DXTYPE_html0C13( AV15tCurrentCode) ;
      }

      protected void standaloneModal( )
      {
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) && ! (0==AV10Insert_BR_EncounterID) )
         {
            A19BR_EncounterID = AV10Insert_BR_EncounterID;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A19BR_EncounterID", StringUtil.LTrim( StringUtil.Str( (decimal)(A19BR_EncounterID), 18, 0)));
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
            AV16Pgmname = "BR_Diagnosis";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV16Pgmname", AV16Pgmname);
            /* Using cursor T000C4 */
            pr_default.execute(2, new Object[] {A19BR_EncounterID});
            A85BR_Information_ID = T000C4_A85BR_Information_ID[0];
            n85BR_Information_ID = T000C4_n85BR_Information_ID[0];
            pr_default.close(2);
            /* Using cursor T000C5 */
            pr_default.execute(3, new Object[] {n85BR_Information_ID, A85BR_Information_ID});
            A36BR_Information_PatientNo = T000C5_A36BR_Information_PatientNo[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A36BR_Information_PatientNo", A36BR_Information_PatientNo);
            n36BR_Information_PatientNo = T000C5_n36BR_Information_PatientNo[0];
            pr_default.close(3);
         }
      }

      protected void Load0C13( )
      {
         /* Using cursor T000C6 */
         pr_default.execute(4, new Object[] {A64BR_DiagnosisID});
         if ( (pr_default.getStatus(4) != 101) )
         {
            RcdFound13 = 1;
            A85BR_Information_ID = T000C6_A85BR_Information_ID[0];
            n85BR_Information_ID = T000C6_n85BR_Information_ID[0];
            A466BR_Diagnosis_DXType_Code = T000C6_A466BR_Diagnosis_DXType_Code[0];
            n466BR_Diagnosis_DXType_Code = T000C6_n466BR_Diagnosis_DXType_Code[0];
            A467BR_Diagnosis_DXTsource_Code = T000C6_A467BR_Diagnosis_DXTsource_Code[0];
            n467BR_Diagnosis_DXTsource_Code = T000C6_n467BR_Diagnosis_DXTsource_Code[0];
            A503BR_Diagnosis_InitialDX_Code = T000C6_A503BR_Diagnosis_InitialDX_Code[0];
            n503BR_Diagnosis_InitialDX_Code = T000C6_n503BR_Diagnosis_InitialDX_Code[0];
            A504BR_Diagnosis_MetastasesDX_Code = T000C6_A504BR_Diagnosis_MetastasesDX_Code[0];
            n504BR_Diagnosis_MetastasesDX_Code = T000C6_n504BR_Diagnosis_MetastasesDX_Code[0];
            A36BR_Information_PatientNo = T000C6_A36BR_Information_PatientNo[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A36BR_Information_PatientNo", A36BR_Information_PatientNo);
            n36BR_Information_PatientNo = T000C6_n36BR_Information_PatientNo[0];
            A513BR_Diagnosis_No = T000C6_A513BR_Diagnosis_No[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A513BR_Diagnosis_No", StringUtil.LTrim( StringUtil.Str( (decimal)(A513BR_Diagnosis_No), 10, 0)));
            n513BR_Diagnosis_No = T000C6_n513BR_Diagnosis_No[0];
            A65BR_Diagnosis_DXID = T000C6_A65BR_Diagnosis_DXID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A65BR_Diagnosis_DXID", A65BR_Diagnosis_DXID);
            n65BR_Diagnosis_DXID = T000C6_n65BR_Diagnosis_DXID[0];
            A66BR_Diagnosis_DXCode = T000C6_A66BR_Diagnosis_DXCode[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A66BR_Diagnosis_DXCode", A66BR_Diagnosis_DXCode);
            n66BR_Diagnosis_DXCode = T000C6_n66BR_Diagnosis_DXCode[0];
            A67BR_Diagnosis_DXType = T000C6_A67BR_Diagnosis_DXType[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A67BR_Diagnosis_DXType", A67BR_Diagnosis_DXType);
            n67BR_Diagnosis_DXType = T000C6_n67BR_Diagnosis_DXType[0];
            A68BR_Diagnosis_DXTsource = T000C6_A68BR_Diagnosis_DXTsource[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A68BR_Diagnosis_DXTsource", A68BR_Diagnosis_DXTsource);
            n68BR_Diagnosis_DXTsource = T000C6_n68BR_Diagnosis_DXTsource[0];
            A69BR_Diagnosis_DXDescription = T000C6_A69BR_Diagnosis_DXDescription[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A69BR_Diagnosis_DXDescription", A69BR_Diagnosis_DXDescription);
            n69BR_Diagnosis_DXDescription = T000C6_n69BR_Diagnosis_DXDescription[0];
            A70BR_Diagnosis_InitialDX = T000C6_A70BR_Diagnosis_InitialDX[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A70BR_Diagnosis_InitialDX", A70BR_Diagnosis_InitialDX);
            n70BR_Diagnosis_InitialDX = T000C6_n70BR_Diagnosis_InitialDX[0];
            A71BR_Diagnosis_MetastasesDX = T000C6_A71BR_Diagnosis_MetastasesDX[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A71BR_Diagnosis_MetastasesDX", A71BR_Diagnosis_MetastasesDX);
            n71BR_Diagnosis_MetastasesDX = T000C6_n71BR_Diagnosis_MetastasesDX[0];
            A260BR_Diagnosis_DXSource = T000C6_A260BR_Diagnosis_DXSource[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A260BR_Diagnosis_DXSource", A260BR_Diagnosis_DXSource);
            n260BR_Diagnosis_DXSource = T000C6_n260BR_Diagnosis_DXSource[0];
            A569BR_Diagnosis_TumorStageClinical = T000C6_A569BR_Diagnosis_TumorStageClinical[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A569BR_Diagnosis_TumorStageClinical", A569BR_Diagnosis_TumorStageClinical);
            n569BR_Diagnosis_TumorStageClinical = T000C6_n569BR_Diagnosis_TumorStageClinical[0];
            A19BR_EncounterID = T000C6_A19BR_EncounterID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A19BR_EncounterID", StringUtil.LTrim( StringUtil.Str( (decimal)(A19BR_EncounterID), 18, 0)));
            ZM0C13( -28) ;
         }
         pr_default.close(4);
         OnLoadActions0C13( ) ;
      }

      protected void OnLoadActions0C13( )
      {
         AV16Pgmname = "BR_Diagnosis";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV16Pgmname", AV16Pgmname);
         edtBR_Diagnosis_DXSource_Visible = ((StringUtil.StrCmp(A71BR_Diagnosis_MetastasesDX, "是")==0) ? 1 : 0);
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Diagnosis_DXSource_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBR_Diagnosis_DXSource_Visible), 5, 0)), true);
         if ( ! ( ( StringUtil.StrCmp(A71BR_Diagnosis_MetastasesDX, "是") == 0 ) ) )
         {
            divBr_diagnosis_dxsource_cell_Class = "Invisible";
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, divBr_diagnosis_dxsource_cell_Internalname, "Class", divBr_diagnosis_dxsource_cell_Class, true);
         }
         else
         {
            if ( StringUtil.StrCmp(A71BR_Diagnosis_MetastasesDX, "是") == 0 )
            {
               divBr_diagnosis_dxsource_cell_Class = "col-xs-12 col-md-6";
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, divBr_diagnosis_dxsource_cell_Internalname, "Class", divBr_diagnosis_dxsource_cell_Class, true);
            }
         }
      }

      protected void CheckExtendedTable0C13( )
      {
         Gx_BScreen = 1;
         standaloneModal( ) ;
         AV16Pgmname = "BR_Diagnosis";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV16Pgmname", AV16Pgmname);
         /* Using cursor T000C4 */
         pr_default.execute(2, new Object[] {A19BR_EncounterID});
         if ( (pr_default.getStatus(2) == 101) )
         {
            GX_msglist.addItem("不匹配' T15'", "ForeignKeyNotFound", 1, "BR_ENCOUNTERID");
            AnyError = 1;
            GX_FocusControl = edtBR_EncounterID_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         A85BR_Information_ID = T000C4_A85BR_Information_ID[0];
         n85BR_Information_ID = T000C4_n85BR_Information_ID[0];
         pr_default.close(2);
         /* Using cursor T000C5 */
         pr_default.execute(3, new Object[] {n85BR_Information_ID, A85BR_Information_ID});
         if ( (pr_default.getStatus(3) == 101) )
         {
            if ( ! ( (0==A85BR_Information_ID) ) )
            {
               GX_msglist.addItem("不匹配' T16'", "ForeignKeyNotFound", 1, "");
               AnyError = 1;
            }
         }
         A36BR_Information_PatientNo = T000C5_A36BR_Information_PatientNo[0];
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A36BR_Information_PatientNo", A36BR_Information_PatientNo);
         n36BR_Information_PatientNo = T000C5_n36BR_Information_PatientNo[0];
         pr_default.close(3);
         if ( (0==A513BR_Diagnosis_No) )
         {
            GX_msglist.addItem("诊断次序是必须填写的。", 1, "BR_DIAGNOSIS_NO");
            AnyError = 1;
            GX_FocusControl = edtBR_Diagnosis_No_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( A68BR_Diagnosis_DXTsource)) )
         {
            GX_msglist.addItem("诊断来源是必须填写的。", 1, "BR_DIAGNOSIS_DXTSOURCE");
            AnyError = 1;
            GX_FocusControl = dynBR_Diagnosis_DXTsource_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( A69BR_Diagnosis_DXDescription)) )
         {
            GX_msglist.addItem("诊断名称是必须填写的。", 1, "BR_DIAGNOSIS_DXDESCRIPTION");
            AnyError = 1;
            GX_FocusControl = edtBR_Diagnosis_DXDescription_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( ! ( ( StringUtil.StrCmp(A70BR_Diagnosis_InitialDX, "否") == 0 ) || ( StringUtil.StrCmp(A70BR_Diagnosis_InitialDX, "是") == 0 ) || ( StringUtil.StrCmp(A70BR_Diagnosis_InitialDX, "不详") == 0 ) || String.IsNullOrEmpty(StringUtil.RTrim( A70BR_Diagnosis_InitialDX)) ) )
         {
            GX_msglist.addItem("域是否为原发肿瘤超界", "OutOfRange", 1, "BR_DIAGNOSIS_INITIALDX");
            AnyError = 1;
            GX_FocusControl = cmbBR_Diagnosis_InitialDX_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( ! ( ( StringUtil.StrCmp(A71BR_Diagnosis_MetastasesDX, "否") == 0 ) || ( StringUtil.StrCmp(A71BR_Diagnosis_MetastasesDX, "是") == 0 ) || ( StringUtil.StrCmp(A71BR_Diagnosis_MetastasesDX, "不详") == 0 ) || String.IsNullOrEmpty(StringUtil.RTrim( A71BR_Diagnosis_MetastasesDX)) ) )
         {
            GX_msglist.addItem("域是否为转移肿瘤超界", "OutOfRange", 1, "BR_DIAGNOSIS_METASTASESDX");
            AnyError = 1;
            GX_FocusControl = cmbBR_Diagnosis_MetastasesDX_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         edtBR_Diagnosis_DXSource_Visible = ((StringUtil.StrCmp(A71BR_Diagnosis_MetastasesDX, "是")==0) ? 1 : 0);
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Diagnosis_DXSource_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBR_Diagnosis_DXSource_Visible), 5, 0)), true);
         if ( ! ( ( StringUtil.StrCmp(A71BR_Diagnosis_MetastasesDX, "是") == 0 ) ) )
         {
            divBr_diagnosis_dxsource_cell_Class = "Invisible";
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, divBr_diagnosis_dxsource_cell_Internalname, "Class", divBr_diagnosis_dxsource_cell_Class, true);
         }
         else
         {
            if ( StringUtil.StrCmp(A71BR_Diagnosis_MetastasesDX, "是") == 0 )
            {
               divBr_diagnosis_dxsource_cell_Class = "col-xs-12 col-md-6";
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, divBr_diagnosis_dxsource_cell_Internalname, "Class", divBr_diagnosis_dxsource_cell_Class, true);
            }
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

      protected void gxLoad_29( long A19BR_EncounterID )
      {
         /* Using cursor T000C7 */
         pr_default.execute(5, new Object[] {A19BR_EncounterID});
         if ( (pr_default.getStatus(5) == 101) )
         {
            GX_msglist.addItem("不匹配' T15'", "ForeignKeyNotFound", 1, "BR_ENCOUNTERID");
            AnyError = 1;
            GX_FocusControl = edtBR_EncounterID_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         A85BR_Information_ID = T000C7_A85BR_Information_ID[0];
         n85BR_Information_ID = T000C7_n85BR_Information_ID[0];
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

      protected void gxLoad_30( long A85BR_Information_ID )
      {
         /* Using cursor T000C8 */
         pr_default.execute(6, new Object[] {n85BR_Information_ID, A85BR_Information_ID});
         if ( (pr_default.getStatus(6) == 101) )
         {
            if ( ! ( (0==A85BR_Information_ID) ) )
            {
               GX_msglist.addItem("不匹配' T16'", "ForeignKeyNotFound", 1, "");
               AnyError = 1;
            }
         }
         A36BR_Information_PatientNo = T000C8_A36BR_Information_PatientNo[0];
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A36BR_Information_PatientNo", A36BR_Information_PatientNo);
         n36BR_Information_PatientNo = T000C8_n36BR_Information_PatientNo[0];
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

      protected void GetKey0C13( )
      {
         /* Using cursor T000C9 */
         pr_default.execute(7, new Object[] {A64BR_DiagnosisID});
         if ( (pr_default.getStatus(7) != 101) )
         {
            RcdFound13 = 1;
         }
         else
         {
            RcdFound13 = 0;
         }
         pr_default.close(7);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor T000C3 */
         pr_default.execute(1, new Object[] {A64BR_DiagnosisID});
         if ( (pr_default.getStatus(1) != 101) )
         {
            ZM0C13( 28) ;
            RcdFound13 = 1;
            A64BR_DiagnosisID = T000C3_A64BR_DiagnosisID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A64BR_DiagnosisID", StringUtil.LTrim( StringUtil.Str( (decimal)(A64BR_DiagnosisID), 18, 0)));
            A466BR_Diagnosis_DXType_Code = T000C3_A466BR_Diagnosis_DXType_Code[0];
            n466BR_Diagnosis_DXType_Code = T000C3_n466BR_Diagnosis_DXType_Code[0];
            A467BR_Diagnosis_DXTsource_Code = T000C3_A467BR_Diagnosis_DXTsource_Code[0];
            n467BR_Diagnosis_DXTsource_Code = T000C3_n467BR_Diagnosis_DXTsource_Code[0];
            A503BR_Diagnosis_InitialDX_Code = T000C3_A503BR_Diagnosis_InitialDX_Code[0];
            n503BR_Diagnosis_InitialDX_Code = T000C3_n503BR_Diagnosis_InitialDX_Code[0];
            A504BR_Diagnosis_MetastasesDX_Code = T000C3_A504BR_Diagnosis_MetastasesDX_Code[0];
            n504BR_Diagnosis_MetastasesDX_Code = T000C3_n504BR_Diagnosis_MetastasesDX_Code[0];
            A513BR_Diagnosis_No = T000C3_A513BR_Diagnosis_No[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A513BR_Diagnosis_No", StringUtil.LTrim( StringUtil.Str( (decimal)(A513BR_Diagnosis_No), 10, 0)));
            n513BR_Diagnosis_No = T000C3_n513BR_Diagnosis_No[0];
            A65BR_Diagnosis_DXID = T000C3_A65BR_Diagnosis_DXID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A65BR_Diagnosis_DXID", A65BR_Diagnosis_DXID);
            n65BR_Diagnosis_DXID = T000C3_n65BR_Diagnosis_DXID[0];
            A66BR_Diagnosis_DXCode = T000C3_A66BR_Diagnosis_DXCode[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A66BR_Diagnosis_DXCode", A66BR_Diagnosis_DXCode);
            n66BR_Diagnosis_DXCode = T000C3_n66BR_Diagnosis_DXCode[0];
            A67BR_Diagnosis_DXType = T000C3_A67BR_Diagnosis_DXType[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A67BR_Diagnosis_DXType", A67BR_Diagnosis_DXType);
            n67BR_Diagnosis_DXType = T000C3_n67BR_Diagnosis_DXType[0];
            A68BR_Diagnosis_DXTsource = T000C3_A68BR_Diagnosis_DXTsource[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A68BR_Diagnosis_DXTsource", A68BR_Diagnosis_DXTsource);
            n68BR_Diagnosis_DXTsource = T000C3_n68BR_Diagnosis_DXTsource[0];
            A69BR_Diagnosis_DXDescription = T000C3_A69BR_Diagnosis_DXDescription[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A69BR_Diagnosis_DXDescription", A69BR_Diagnosis_DXDescription);
            n69BR_Diagnosis_DXDescription = T000C3_n69BR_Diagnosis_DXDescription[0];
            A70BR_Diagnosis_InitialDX = T000C3_A70BR_Diagnosis_InitialDX[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A70BR_Diagnosis_InitialDX", A70BR_Diagnosis_InitialDX);
            n70BR_Diagnosis_InitialDX = T000C3_n70BR_Diagnosis_InitialDX[0];
            A71BR_Diagnosis_MetastasesDX = T000C3_A71BR_Diagnosis_MetastasesDX[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A71BR_Diagnosis_MetastasesDX", A71BR_Diagnosis_MetastasesDX);
            n71BR_Diagnosis_MetastasesDX = T000C3_n71BR_Diagnosis_MetastasesDX[0];
            A260BR_Diagnosis_DXSource = T000C3_A260BR_Diagnosis_DXSource[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A260BR_Diagnosis_DXSource", A260BR_Diagnosis_DXSource);
            n260BR_Diagnosis_DXSource = T000C3_n260BR_Diagnosis_DXSource[0];
            A569BR_Diagnosis_TumorStageClinical = T000C3_A569BR_Diagnosis_TumorStageClinical[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A569BR_Diagnosis_TumorStageClinical", A569BR_Diagnosis_TumorStageClinical);
            n569BR_Diagnosis_TumorStageClinical = T000C3_n569BR_Diagnosis_TumorStageClinical[0];
            A19BR_EncounterID = T000C3_A19BR_EncounterID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A19BR_EncounterID", StringUtil.LTrim( StringUtil.Str( (decimal)(A19BR_EncounterID), 18, 0)));
            Z64BR_DiagnosisID = A64BR_DiagnosisID;
            sMode13 = Gx_mode;
            Gx_mode = "DSP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
            Load0C13( ) ;
            if ( AnyError == 1 )
            {
               RcdFound13 = 0;
               InitializeNonKey0C13( ) ;
            }
            Gx_mode = sMode13;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         }
         else
         {
            RcdFound13 = 0;
            InitializeNonKey0C13( ) ;
            sMode13 = Gx_mode;
            Gx_mode = "DSP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
            standaloneModal( ) ;
            Gx_mode = sMode13;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         }
         pr_default.close(1);
      }

      protected void getEqualNoModal( )
      {
         GetKey0C13( ) ;
         if ( RcdFound13 == 0 )
         {
         }
         else
         {
         }
         getByPrimaryKey( ) ;
      }

      protected void move_next( )
      {
         RcdFound13 = 0;
         /* Using cursor T000C10 */
         pr_default.execute(8, new Object[] {A64BR_DiagnosisID});
         if ( (pr_default.getStatus(8) != 101) )
         {
            while ( (pr_default.getStatus(8) != 101) && ( ( T000C10_A64BR_DiagnosisID[0] < A64BR_DiagnosisID ) ) )
            {
               pr_default.readNext(8);
            }
            if ( (pr_default.getStatus(8) != 101) && ( ( T000C10_A64BR_DiagnosisID[0] > A64BR_DiagnosisID ) ) )
            {
               A64BR_DiagnosisID = T000C10_A64BR_DiagnosisID[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A64BR_DiagnosisID", StringUtil.LTrim( StringUtil.Str( (decimal)(A64BR_DiagnosisID), 18, 0)));
               RcdFound13 = 1;
            }
         }
         pr_default.close(8);
      }

      protected void move_previous( )
      {
         RcdFound13 = 0;
         /* Using cursor T000C11 */
         pr_default.execute(9, new Object[] {A64BR_DiagnosisID});
         if ( (pr_default.getStatus(9) != 101) )
         {
            while ( (pr_default.getStatus(9) != 101) && ( ( T000C11_A64BR_DiagnosisID[0] > A64BR_DiagnosisID ) ) )
            {
               pr_default.readNext(9);
            }
            if ( (pr_default.getStatus(9) != 101) && ( ( T000C11_A64BR_DiagnosisID[0] < A64BR_DiagnosisID ) ) )
            {
               A64BR_DiagnosisID = T000C11_A64BR_DiagnosisID[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A64BR_DiagnosisID", StringUtil.LTrim( StringUtil.Str( (decimal)(A64BR_DiagnosisID), 18, 0)));
               RcdFound13 = 1;
            }
         }
         pr_default.close(9);
      }

      protected void btn_enter( )
      {
         nKeyPressed = 1;
         GetKey0C13( ) ;
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            /* Insert record */
            GX_FocusControl = edtBR_Diagnosis_No_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            Insert0C13( ) ;
            if ( AnyError == 1 )
            {
               GX_FocusControl = "";
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
         }
         else
         {
            if ( RcdFound13 == 1 )
            {
               if ( A64BR_DiagnosisID != Z64BR_DiagnosisID )
               {
                  A64BR_DiagnosisID = Z64BR_DiagnosisID;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A64BR_DiagnosisID", StringUtil.LTrim( StringUtil.Str( (decimal)(A64BR_DiagnosisID), 18, 0)));
                  GX_msglist.addItem(context.GetMessage( "GXM_getbeforeupd", ""), "CandidateKeyNotFound", 1, "BR_DIAGNOSISID");
                  AnyError = 1;
                  GX_FocusControl = edtBR_DiagnosisID_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
               else if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
               {
                  delete( ) ;
                  AfterTrn( ) ;
                  GX_FocusControl = edtBR_Diagnosis_No_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
               else
               {
                  /* Update record */
                  Update0C13( ) ;
                  GX_FocusControl = edtBR_Diagnosis_No_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
            }
            else
            {
               if ( A64BR_DiagnosisID != Z64BR_DiagnosisID )
               {
                  /* Insert record */
                  GX_FocusControl = edtBR_Diagnosis_No_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  Insert0C13( ) ;
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
                     GX_msglist.addItem(context.GetMessage( "GXM_recdeleted", ""), 1, "BR_DIAGNOSISID");
                     AnyError = 1;
                     GX_FocusControl = edtBR_DiagnosisID_Internalname;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  }
                  else
                  {
                     /* Insert record */
                     GX_FocusControl = edtBR_Diagnosis_No_Internalname;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                     Insert0C13( ) ;
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
         if ( A64BR_DiagnosisID != Z64BR_DiagnosisID )
         {
            A64BR_DiagnosisID = Z64BR_DiagnosisID;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A64BR_DiagnosisID", StringUtil.LTrim( StringUtil.Str( (decimal)(A64BR_DiagnosisID), 18, 0)));
            GX_msglist.addItem(context.GetMessage( "GXM_getbeforedlt", ""), 1, "BR_DIAGNOSISID");
            AnyError = 1;
            GX_FocusControl = edtBR_DiagnosisID_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         else
         {
            delete( ) ;
            AfterTrn( ) ;
            GX_FocusControl = edtBR_Diagnosis_No_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( AnyError != 0 )
         {
         }
      }

      protected void CheckOptimisticConcurrency0C13( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor T000C2 */
            pr_default.execute(0, new Object[] {A64BR_DiagnosisID});
            if ( (pr_default.getStatus(0) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"BR_Diagnosis"}), "RecordIsLocked", 1, "");
               AnyError = 1;
               return  ;
            }
            Gx_longc = false;
            if ( (pr_default.getStatus(0) == 101) || ( StringUtil.StrCmp(Z466BR_Diagnosis_DXType_Code, T000C2_A466BR_Diagnosis_DXType_Code[0]) != 0 ) || ( StringUtil.StrCmp(Z467BR_Diagnosis_DXTsource_Code, T000C2_A467BR_Diagnosis_DXTsource_Code[0]) != 0 ) || ( StringUtil.StrCmp(Z503BR_Diagnosis_InitialDX_Code, T000C2_A503BR_Diagnosis_InitialDX_Code[0]) != 0 ) || ( StringUtil.StrCmp(Z504BR_Diagnosis_MetastasesDX_Code, T000C2_A504BR_Diagnosis_MetastasesDX_Code[0]) != 0 ) || ( Z513BR_Diagnosis_No != T000C2_A513BR_Diagnosis_No[0] ) )
            {
               Gx_longc = true;
            }
            if ( Gx_longc || ( StringUtil.StrCmp(Z65BR_Diagnosis_DXID, T000C2_A65BR_Diagnosis_DXID[0]) != 0 ) || ( StringUtil.StrCmp(Z66BR_Diagnosis_DXCode, T000C2_A66BR_Diagnosis_DXCode[0]) != 0 ) || ( StringUtil.StrCmp(Z67BR_Diagnosis_DXType, T000C2_A67BR_Diagnosis_DXType[0]) != 0 ) || ( StringUtil.StrCmp(Z68BR_Diagnosis_DXTsource, T000C2_A68BR_Diagnosis_DXTsource[0]) != 0 ) || ( StringUtil.StrCmp(Z69BR_Diagnosis_DXDescription, T000C2_A69BR_Diagnosis_DXDescription[0]) != 0 ) )
            {
               Gx_longc = true;
            }
            if ( Gx_longc || ( StringUtil.StrCmp(Z70BR_Diagnosis_InitialDX, T000C2_A70BR_Diagnosis_InitialDX[0]) != 0 ) || ( StringUtil.StrCmp(Z71BR_Diagnosis_MetastasesDX, T000C2_A71BR_Diagnosis_MetastasesDX[0]) != 0 ) || ( StringUtil.StrCmp(Z260BR_Diagnosis_DXSource, T000C2_A260BR_Diagnosis_DXSource[0]) != 0 ) || ( StringUtil.StrCmp(Z569BR_Diagnosis_TumorStageClinical, T000C2_A569BR_Diagnosis_TumorStageClinical[0]) != 0 ) || ( Z19BR_EncounterID != T000C2_A19BR_EncounterID[0] ) )
            {
               if ( StringUtil.StrCmp(Z466BR_Diagnosis_DXType_Code, T000C2_A466BR_Diagnosis_DXType_Code[0]) != 0 )
               {
                  GXUtil.WriteLog("br_diagnosis:[seudo value changed for attri]"+"BR_Diagnosis_DXType_Code");
                  GXUtil.WriteLogRaw("Old: ",Z466BR_Diagnosis_DXType_Code);
                  GXUtil.WriteLogRaw("Current: ",T000C2_A466BR_Diagnosis_DXType_Code[0]);
               }
               if ( StringUtil.StrCmp(Z467BR_Diagnosis_DXTsource_Code, T000C2_A467BR_Diagnosis_DXTsource_Code[0]) != 0 )
               {
                  GXUtil.WriteLog("br_diagnosis:[seudo value changed for attri]"+"BR_Diagnosis_DXTsource_Code");
                  GXUtil.WriteLogRaw("Old: ",Z467BR_Diagnosis_DXTsource_Code);
                  GXUtil.WriteLogRaw("Current: ",T000C2_A467BR_Diagnosis_DXTsource_Code[0]);
               }
               if ( StringUtil.StrCmp(Z503BR_Diagnosis_InitialDX_Code, T000C2_A503BR_Diagnosis_InitialDX_Code[0]) != 0 )
               {
                  GXUtil.WriteLog("br_diagnosis:[seudo value changed for attri]"+"BR_Diagnosis_InitialDX_Code");
                  GXUtil.WriteLogRaw("Old: ",Z503BR_Diagnosis_InitialDX_Code);
                  GXUtil.WriteLogRaw("Current: ",T000C2_A503BR_Diagnosis_InitialDX_Code[0]);
               }
               if ( StringUtil.StrCmp(Z504BR_Diagnosis_MetastasesDX_Code, T000C2_A504BR_Diagnosis_MetastasesDX_Code[0]) != 0 )
               {
                  GXUtil.WriteLog("br_diagnosis:[seudo value changed for attri]"+"BR_Diagnosis_MetastasesDX_Code");
                  GXUtil.WriteLogRaw("Old: ",Z504BR_Diagnosis_MetastasesDX_Code);
                  GXUtil.WriteLogRaw("Current: ",T000C2_A504BR_Diagnosis_MetastasesDX_Code[0]);
               }
               if ( Z513BR_Diagnosis_No != T000C2_A513BR_Diagnosis_No[0] )
               {
                  GXUtil.WriteLog("br_diagnosis:[seudo value changed for attri]"+"BR_Diagnosis_No");
                  GXUtil.WriteLogRaw("Old: ",Z513BR_Diagnosis_No);
                  GXUtil.WriteLogRaw("Current: ",T000C2_A513BR_Diagnosis_No[0]);
               }
               if ( StringUtil.StrCmp(Z65BR_Diagnosis_DXID, T000C2_A65BR_Diagnosis_DXID[0]) != 0 )
               {
                  GXUtil.WriteLog("br_diagnosis:[seudo value changed for attri]"+"BR_Diagnosis_DXID");
                  GXUtil.WriteLogRaw("Old: ",Z65BR_Diagnosis_DXID);
                  GXUtil.WriteLogRaw("Current: ",T000C2_A65BR_Diagnosis_DXID[0]);
               }
               if ( StringUtil.StrCmp(Z66BR_Diagnosis_DXCode, T000C2_A66BR_Diagnosis_DXCode[0]) != 0 )
               {
                  GXUtil.WriteLog("br_diagnosis:[seudo value changed for attri]"+"BR_Diagnosis_DXCode");
                  GXUtil.WriteLogRaw("Old: ",Z66BR_Diagnosis_DXCode);
                  GXUtil.WriteLogRaw("Current: ",T000C2_A66BR_Diagnosis_DXCode[0]);
               }
               if ( StringUtil.StrCmp(Z67BR_Diagnosis_DXType, T000C2_A67BR_Diagnosis_DXType[0]) != 0 )
               {
                  GXUtil.WriteLog("br_diagnosis:[seudo value changed for attri]"+"BR_Diagnosis_DXType");
                  GXUtil.WriteLogRaw("Old: ",Z67BR_Diagnosis_DXType);
                  GXUtil.WriteLogRaw("Current: ",T000C2_A67BR_Diagnosis_DXType[0]);
               }
               if ( StringUtil.StrCmp(Z68BR_Diagnosis_DXTsource, T000C2_A68BR_Diagnosis_DXTsource[0]) != 0 )
               {
                  GXUtil.WriteLog("br_diagnosis:[seudo value changed for attri]"+"BR_Diagnosis_DXTsource");
                  GXUtil.WriteLogRaw("Old: ",Z68BR_Diagnosis_DXTsource);
                  GXUtil.WriteLogRaw("Current: ",T000C2_A68BR_Diagnosis_DXTsource[0]);
               }
               if ( StringUtil.StrCmp(Z69BR_Diagnosis_DXDescription, T000C2_A69BR_Diagnosis_DXDescription[0]) != 0 )
               {
                  GXUtil.WriteLog("br_diagnosis:[seudo value changed for attri]"+"BR_Diagnosis_DXDescription");
                  GXUtil.WriteLogRaw("Old: ",Z69BR_Diagnosis_DXDescription);
                  GXUtil.WriteLogRaw("Current: ",T000C2_A69BR_Diagnosis_DXDescription[0]);
               }
               if ( StringUtil.StrCmp(Z70BR_Diagnosis_InitialDX, T000C2_A70BR_Diagnosis_InitialDX[0]) != 0 )
               {
                  GXUtil.WriteLog("br_diagnosis:[seudo value changed for attri]"+"BR_Diagnosis_InitialDX");
                  GXUtil.WriteLogRaw("Old: ",Z70BR_Diagnosis_InitialDX);
                  GXUtil.WriteLogRaw("Current: ",T000C2_A70BR_Diagnosis_InitialDX[0]);
               }
               if ( StringUtil.StrCmp(Z71BR_Diagnosis_MetastasesDX, T000C2_A71BR_Diagnosis_MetastasesDX[0]) != 0 )
               {
                  GXUtil.WriteLog("br_diagnosis:[seudo value changed for attri]"+"BR_Diagnosis_MetastasesDX");
                  GXUtil.WriteLogRaw("Old: ",Z71BR_Diagnosis_MetastasesDX);
                  GXUtil.WriteLogRaw("Current: ",T000C2_A71BR_Diagnosis_MetastasesDX[0]);
               }
               if ( StringUtil.StrCmp(Z260BR_Diagnosis_DXSource, T000C2_A260BR_Diagnosis_DXSource[0]) != 0 )
               {
                  GXUtil.WriteLog("br_diagnosis:[seudo value changed for attri]"+"BR_Diagnosis_DXSource");
                  GXUtil.WriteLogRaw("Old: ",Z260BR_Diagnosis_DXSource);
                  GXUtil.WriteLogRaw("Current: ",T000C2_A260BR_Diagnosis_DXSource[0]);
               }
               if ( StringUtil.StrCmp(Z569BR_Diagnosis_TumorStageClinical, T000C2_A569BR_Diagnosis_TumorStageClinical[0]) != 0 )
               {
                  GXUtil.WriteLog("br_diagnosis:[seudo value changed for attri]"+"BR_Diagnosis_TumorStageClinical");
                  GXUtil.WriteLogRaw("Old: ",Z569BR_Diagnosis_TumorStageClinical);
                  GXUtil.WriteLogRaw("Current: ",T000C2_A569BR_Diagnosis_TumorStageClinical[0]);
               }
               if ( Z19BR_EncounterID != T000C2_A19BR_EncounterID[0] )
               {
                  GXUtil.WriteLog("br_diagnosis:[seudo value changed for attri]"+"BR_EncounterID");
                  GXUtil.WriteLogRaw("Old: ",Z19BR_EncounterID);
                  GXUtil.WriteLogRaw("Current: ",T000C2_A19BR_EncounterID[0]);
               }
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
                     /* Using cursor T000C12 */
                     pr_default.execute(10, new Object[] {n466BR_Diagnosis_DXType_Code, A466BR_Diagnosis_DXType_Code, n467BR_Diagnosis_DXTsource_Code, A467BR_Diagnosis_DXTsource_Code, n503BR_Diagnosis_InitialDX_Code, A503BR_Diagnosis_InitialDX_Code, n504BR_Diagnosis_MetastasesDX_Code, A504BR_Diagnosis_MetastasesDX_Code, n513BR_Diagnosis_No, A513BR_Diagnosis_No, n65BR_Diagnosis_DXID, A65BR_Diagnosis_DXID, n66BR_Diagnosis_DXCode, A66BR_Diagnosis_DXCode, n67BR_Diagnosis_DXType, A67BR_Diagnosis_DXType, n68BR_Diagnosis_DXTsource, A68BR_Diagnosis_DXTsource, n69BR_Diagnosis_DXDescription, A69BR_Diagnosis_DXDescription, n70BR_Diagnosis_InitialDX, A70BR_Diagnosis_InitialDX, n71BR_Diagnosis_MetastasesDX, A71BR_Diagnosis_MetastasesDX, n260BR_Diagnosis_DXSource, A260BR_Diagnosis_DXSource, n569BR_Diagnosis_TumorStageClinical, A569BR_Diagnosis_TumorStageClinical, A19BR_EncounterID});
                     A64BR_DiagnosisID = T000C12_A64BR_DiagnosisID[0];
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A64BR_DiagnosisID", StringUtil.LTrim( StringUtil.Str( (decimal)(A64BR_DiagnosisID), 18, 0)));
                     pr_default.close(10);
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
                           ResetCaption0C0( ) ;
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
                     /* Using cursor T000C13 */
                     pr_default.execute(11, new Object[] {n466BR_Diagnosis_DXType_Code, A466BR_Diagnosis_DXType_Code, n467BR_Diagnosis_DXTsource_Code, A467BR_Diagnosis_DXTsource_Code, n503BR_Diagnosis_InitialDX_Code, A503BR_Diagnosis_InitialDX_Code, n504BR_Diagnosis_MetastasesDX_Code, A504BR_Diagnosis_MetastasesDX_Code, n513BR_Diagnosis_No, A513BR_Diagnosis_No, n65BR_Diagnosis_DXID, A65BR_Diagnosis_DXID, n66BR_Diagnosis_DXCode, A66BR_Diagnosis_DXCode, n67BR_Diagnosis_DXType, A67BR_Diagnosis_DXType, n68BR_Diagnosis_DXTsource, A68BR_Diagnosis_DXTsource, n69BR_Diagnosis_DXDescription, A69BR_Diagnosis_DXDescription, n70BR_Diagnosis_InitialDX, A70BR_Diagnosis_InitialDX, n71BR_Diagnosis_MetastasesDX, A71BR_Diagnosis_MetastasesDX, n260BR_Diagnosis_DXSource, A260BR_Diagnosis_DXSource, n569BR_Diagnosis_TumorStageClinical, A569BR_Diagnosis_TumorStageClinical, A19BR_EncounterID, A64BR_DiagnosisID});
                     pr_default.close(11);
                     dsDefault.SmartCacheProvider.SetUpdated("BR_Diagnosis") ;
                     if ( (pr_default.getStatus(11) == 103) )
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
            EndLevel0C13( ) ;
         }
         CloseExtendedTableCursors0C13( ) ;
      }

      protected void DeferredUpdate0C13( )
      {
      }

      protected void delete( )
      {
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
                  /* Using cursor T000C14 */
                  pr_default.execute(12, new Object[] {A64BR_DiagnosisID});
                  pr_default.close(12);
                  dsDefault.SmartCacheProvider.SetUpdated("BR_Diagnosis") ;
                  if ( AnyError == 0 )
                  {
                     /* Start of After( delete) rules */
                     new zutil_recordsonlog(context ).execute(  StringUtil.Trim( StringUtil.Str( (decimal)(A19BR_EncounterID), 18, 0)),  "就诊信息",  StringUtil.Trim( StringUtil.Str( (decimal)(A64BR_DiagnosisID), 18, 0)),  "诊断",  "Delete",  1) ;
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
         sMode13 = Gx_mode;
         Gx_mode = "DLT";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         EndLevel0C13( ) ;
         Gx_mode = sMode13;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
      }

      protected void OnDeleteControls0C13( )
      {
         standaloneModal( ) ;
         if ( AnyError == 0 )
         {
            /* Delete mode formulas */
            AV16Pgmname = "BR_Diagnosis";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV16Pgmname", AV16Pgmname);
            /* Using cursor T000C15 */
            pr_default.execute(13, new Object[] {A19BR_EncounterID});
            A85BR_Information_ID = T000C15_A85BR_Information_ID[0];
            n85BR_Information_ID = T000C15_n85BR_Information_ID[0];
            pr_default.close(13);
            /* Using cursor T000C16 */
            pr_default.execute(14, new Object[] {n85BR_Information_ID, A85BR_Information_ID});
            A36BR_Information_PatientNo = T000C16_A36BR_Information_PatientNo[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A36BR_Information_PatientNo", A36BR_Information_PatientNo);
            n36BR_Information_PatientNo = T000C16_n36BR_Information_PatientNo[0];
            pr_default.close(14);
            edtBR_Diagnosis_DXSource_Visible = ((StringUtil.StrCmp(A71BR_Diagnosis_MetastasesDX, "是")==0) ? 1 : 0);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Diagnosis_DXSource_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBR_Diagnosis_DXSource_Visible), 5, 0)), true);
            if ( ! ( ( StringUtil.StrCmp(A71BR_Diagnosis_MetastasesDX, "是") == 0 ) ) )
            {
               divBr_diagnosis_dxsource_cell_Class = "Invisible";
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, divBr_diagnosis_dxsource_cell_Internalname, "Class", divBr_diagnosis_dxsource_cell_Class, true);
            }
            else
            {
               if ( StringUtil.StrCmp(A71BR_Diagnosis_MetastasesDX, "是") == 0 )
               {
                  divBr_diagnosis_dxsource_cell_Class = "col-xs-12 col-md-6";
                  context.httpAjaxContext.ajax_rsp_assign_prop("", false, divBr_diagnosis_dxsource_cell_Internalname, "Class", divBr_diagnosis_dxsource_cell_Class, true);
               }
            }
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
            pr_default.close(1);
            pr_default.close(13);
            pr_default.close(14);
            context.CommitDataStores("br_diagnosis",pr_default);
            if ( AnyError == 0 )
            {
               ConfirmValues0C0( ) ;
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
            context.RollbackDataStores("br_diagnosis",pr_default);
         }
         IsModified = 0;
         if ( AnyError != 0 )
         {
            context.wjLoc = "";
            context.nUserReturn = 0;
         }
      }

      public void ScanStart0C13( )
      {
         /* Scan By routine */
         /* Using cursor T000C17 */
         pr_default.execute(15);
         RcdFound13 = 0;
         if ( (pr_default.getStatus(15) != 101) )
         {
            RcdFound13 = 1;
            A64BR_DiagnosisID = T000C17_A64BR_DiagnosisID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A64BR_DiagnosisID", StringUtil.LTrim( StringUtil.Str( (decimal)(A64BR_DiagnosisID), 18, 0)));
         }
         /* Load Subordinate Levels */
      }

      protected void ScanNext0C13( )
      {
         /* Scan next routine */
         pr_default.readNext(15);
         RcdFound13 = 0;
         if ( (pr_default.getStatus(15) != 101) )
         {
            RcdFound13 = 1;
            A64BR_DiagnosisID = T000C17_A64BR_DiagnosisID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A64BR_DiagnosisID", StringUtil.LTrim( StringUtil.Str( (decimal)(A64BR_DiagnosisID), 18, 0)));
         }
      }

      protected void ScanEnd0C13( )
      {
         pr_default.close(15);
      }

      protected void AfterConfirm0C13( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert0C13( )
      {
         /* Before Insert Rules */
         GXt_char1 = A466BR_Diagnosis_DXType_Code;
         new zutil_findtargetcode(context ).execute(  20,  A67BR_Diagnosis_DXType, out  GXt_char1) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A67BR_Diagnosis_DXType", A67BR_Diagnosis_DXType);
         A466BR_Diagnosis_DXType_Code = GXt_char1;
         n466BR_Diagnosis_DXType_Code = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A466BR_Diagnosis_DXType_Code", A466BR_Diagnosis_DXType_Code);
         GXt_char1 = A467BR_Diagnosis_DXTsource_Code;
         new zutil_findtargetcode(context ).execute(  21,  A68BR_Diagnosis_DXTsource, out  GXt_char1) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A68BR_Diagnosis_DXTsource", A68BR_Diagnosis_DXTsource);
         A467BR_Diagnosis_DXTsource_Code = GXt_char1;
         n467BR_Diagnosis_DXTsource_Code = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A467BR_Diagnosis_DXTsource_Code", A467BR_Diagnosis_DXTsource_Code);
         GXt_char1 = A503BR_Diagnosis_InitialDX_Code;
         new zutil_findtargetcode(context ).execute(  37,  A70BR_Diagnosis_InitialDX, out  GXt_char1) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A70BR_Diagnosis_InitialDX", A70BR_Diagnosis_InitialDX);
         A503BR_Diagnosis_InitialDX_Code = GXt_char1;
         n503BR_Diagnosis_InitialDX_Code = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A503BR_Diagnosis_InitialDX_Code", A503BR_Diagnosis_InitialDX_Code);
         GXt_char1 = A504BR_Diagnosis_MetastasesDX_Code;
         new zutil_findtargetcode(context ).execute(  37,  A71BR_Diagnosis_MetastasesDX, out  GXt_char1) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A71BR_Diagnosis_MetastasesDX", A71BR_Diagnosis_MetastasesDX);
         A504BR_Diagnosis_MetastasesDX_Code = GXt_char1;
         n504BR_Diagnosis_MetastasesDX_Code = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A504BR_Diagnosis_MetastasesDX_Code", A504BR_Diagnosis_MetastasesDX_Code);
      }

      protected void BeforeUpdate0C13( )
      {
         /* Before Update Rules */
         GXt_char1 = A466BR_Diagnosis_DXType_Code;
         new zutil_findtargetcode(context ).execute(  20,  A67BR_Diagnosis_DXType, out  GXt_char1) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A67BR_Diagnosis_DXType", A67BR_Diagnosis_DXType);
         A466BR_Diagnosis_DXType_Code = GXt_char1;
         n466BR_Diagnosis_DXType_Code = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A466BR_Diagnosis_DXType_Code", A466BR_Diagnosis_DXType_Code);
         GXt_char1 = A467BR_Diagnosis_DXTsource_Code;
         new zutil_findtargetcode(context ).execute(  21,  A68BR_Diagnosis_DXTsource, out  GXt_char1) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A68BR_Diagnosis_DXTsource", A68BR_Diagnosis_DXTsource);
         A467BR_Diagnosis_DXTsource_Code = GXt_char1;
         n467BR_Diagnosis_DXTsource_Code = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A467BR_Diagnosis_DXTsource_Code", A467BR_Diagnosis_DXTsource_Code);
         GXt_char1 = A503BR_Diagnosis_InitialDX_Code;
         new zutil_findtargetcode(context ).execute(  37,  A70BR_Diagnosis_InitialDX, out  GXt_char1) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A70BR_Diagnosis_InitialDX", A70BR_Diagnosis_InitialDX);
         A503BR_Diagnosis_InitialDX_Code = GXt_char1;
         n503BR_Diagnosis_InitialDX_Code = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A503BR_Diagnosis_InitialDX_Code", A503BR_Diagnosis_InitialDX_Code);
         GXt_char1 = A504BR_Diagnosis_MetastasesDX_Code;
         new zutil_findtargetcode(context ).execute(  37,  A71BR_Diagnosis_MetastasesDX, out  GXt_char1) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A71BR_Diagnosis_MetastasesDX", A71BR_Diagnosis_MetastasesDX);
         A504BR_Diagnosis_MetastasesDX_Code = GXt_char1;
         n504BR_Diagnosis_MetastasesDX_Code = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A504BR_Diagnosis_MetastasesDX_Code", A504BR_Diagnosis_MetastasesDX_Code);
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
         edtBR_Diagnosis_No_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Diagnosis_No_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBR_Diagnosis_No_Enabled), 5, 0)), true);
         edtBR_Diagnosis_DXDescription_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Diagnosis_DXDescription_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBR_Diagnosis_DXDescription_Enabled), 5, 0)), true);
         dynBR_Diagnosis_DXTsource.Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynBR_Diagnosis_DXTsource_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(dynBR_Diagnosis_DXTsource.Enabled), 5, 0)), true);
         edtBR_Diagnosis_DXID_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Diagnosis_DXID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBR_Diagnosis_DXID_Enabled), 5, 0)), true);
         edtBR_Diagnosis_DXCode_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Diagnosis_DXCode_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBR_Diagnosis_DXCode_Enabled), 5, 0)), true);
         dynBR_Diagnosis_DXType.Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynBR_Diagnosis_DXType_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(dynBR_Diagnosis_DXType.Enabled), 5, 0)), true);
         cmbBR_Diagnosis_InitialDX.Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbBR_Diagnosis_InitialDX_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(cmbBR_Diagnosis_InitialDX.Enabled), 5, 0)), true);
         cmbBR_Diagnosis_MetastasesDX.Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbBR_Diagnosis_MetastasesDX_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(cmbBR_Diagnosis_MetastasesDX.Enabled), 5, 0)), true);
         edtBR_Diagnosis_DXSource_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Diagnosis_DXSource_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBR_Diagnosis_DXSource_Enabled), 5, 0)), true);
         edtBR_Diagnosis_TumorStageClinical_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Diagnosis_TumorStageClinical_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBR_Diagnosis_TumorStageClinical_Enabled), 5, 0)), true);
         edtBR_DiagnosisID_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_DiagnosisID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBR_DiagnosisID_Enabled), 5, 0)), true);
         edtBR_EncounterID_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_EncounterID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBR_EncounterID_Enabled), 5, 0)), true);
         edtBR_Information_PatientNo_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Information_PatientNo_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBR_Information_PatientNo_Enabled), 5, 0)), true);
      }

      protected void send_integrity_lvl_hashes0C13( )
      {
      }

      protected void assign_properties_default( )
      {
      }

      protected void ConfirmValues0C0( )
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
         context.AddJavascriptSource("gxcfg.js", "?20202281564232", false);
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" autocomplete=\"off\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("br_diagnosis.aspx") + "?" + UrlEncode(StringUtil.RTrim(Gx_mode)) + "," + UrlEncode("" +AV12BR_DiagnosisID)+"\">") ;
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
         forbiddenHiddens = "hsh" + "BR_Diagnosis";
         forbiddenHiddens = forbiddenHiddens + context.localUtil.Format( (decimal)(A64BR_DiagnosisID), "ZZZZZZZZZZZZZZZZZZ");
         forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( AV15tCurrentCode, ""));
         forbiddenHiddens = forbiddenHiddens + context.localUtil.Format( (decimal)(AV10Insert_BR_EncounterID), "ZZZZZZZZZZZZZZZZZZ");
         forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!"));
         GxWebStd.gx_hidden_field( context, "hsh", GetEncryptedHash( forbiddenHiddens, GXKey));
         GXUtil.WriteLog("br_diagnosis:[SendSecurityCheck value for]"+"BR_DiagnosisID:"+context.localUtil.Format( (decimal)(A64BR_DiagnosisID), "ZZZZZZZZZZZZZZZZZZ"));
         GXUtil.WriteLog("br_diagnosis:[SendSecurityCheck value for]"+"tCurrentCode:"+StringUtil.RTrim( context.localUtil.Format( AV15tCurrentCode, "")));
         GXUtil.WriteLog("br_diagnosis:[SendSecurityCheck value for]"+"Insert_BR_EncounterID:"+context.localUtil.Format( (decimal)(AV10Insert_BR_EncounterID), "ZZZZZZZZZZZZZZZZZZ"));
         GXUtil.WriteLog("br_diagnosis:[SendSecurityCheck value for]"+"Gx_mode:"+StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")));
      }

      protected void SendCloseFormHiddens( )
      {
         /* Send hidden variables. */
         /* Send saved values. */
         send_integrity_footer_hashes( ) ;
         GxWebStd.gx_hidden_field( context, "Z64BR_DiagnosisID", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z64BR_DiagnosisID), 18, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "Z466BR_Diagnosis_DXType_Code", Z466BR_Diagnosis_DXType_Code);
         GxWebStd.gx_hidden_field( context, "Z467BR_Diagnosis_DXTsource_Code", Z467BR_Diagnosis_DXTsource_Code);
         GxWebStd.gx_hidden_field( context, "Z503BR_Diagnosis_InitialDX_Code", Z503BR_Diagnosis_InitialDX_Code);
         GxWebStd.gx_hidden_field( context, "Z504BR_Diagnosis_MetastasesDX_Code", Z504BR_Diagnosis_MetastasesDX_Code);
         GxWebStd.gx_hidden_field( context, "Z513BR_Diagnosis_No", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z513BR_Diagnosis_No), 10, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "Z65BR_Diagnosis_DXID", Z65BR_Diagnosis_DXID);
         GxWebStd.gx_hidden_field( context, "Z66BR_Diagnosis_DXCode", Z66BR_Diagnosis_DXCode);
         GxWebStd.gx_hidden_field( context, "Z67BR_Diagnosis_DXType", Z67BR_Diagnosis_DXType);
         GxWebStd.gx_hidden_field( context, "Z68BR_Diagnosis_DXTsource", Z68BR_Diagnosis_DXTsource);
         GxWebStd.gx_hidden_field( context, "Z69BR_Diagnosis_DXDescription", Z69BR_Diagnosis_DXDescription);
         GxWebStd.gx_hidden_field( context, "Z70BR_Diagnosis_InitialDX", Z70BR_Diagnosis_InitialDX);
         GxWebStd.gx_hidden_field( context, "Z71BR_Diagnosis_MetastasesDX", Z71BR_Diagnosis_MetastasesDX);
         GxWebStd.gx_hidden_field( context, "Z260BR_Diagnosis_DXSource", Z260BR_Diagnosis_DXSource);
         GxWebStd.gx_hidden_field( context, "Z569BR_Diagnosis_TumorStageClinical", Z569BR_Diagnosis_TumorStageClinical);
         GxWebStd.gx_hidden_field( context, "Z19BR_EncounterID", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z19BR_EncounterID), 18, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "IsConfirmed", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsConfirmed), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "IsModified", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsModified), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "Mode", StringUtil.RTrim( Gx_mode));
         GxWebStd.gx_hidden_field( context, "gxhash_Mode", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         GxWebStd.gx_hidden_field( context, "N19BR_EncounterID", StringUtil.LTrim( StringUtil.NToC( (decimal)(A19BR_EncounterID), 18, 0, ".", "")));
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vTRNCONTEXT", AV8TrnContext);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vTRNCONTEXT", AV8TrnContext);
         }
         GxWebStd.gx_hidden_field( context, "vBR_DIAGNOSISID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV12BR_DiagnosisID), 18, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "gxhash_vBR_DIAGNOSISID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV12BR_DiagnosisID), "ZZZZZZZZZZZZZZZZZZ"), context));
         GxWebStd.gx_hidden_field( context, "vINSERT_BR_ENCOUNTERID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV10Insert_BR_EncounterID), 18, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "BR_DIAGNOSIS_DXTYPE_CODE", A466BR_Diagnosis_DXType_Code);
         GxWebStd.gx_hidden_field( context, "BR_DIAGNOSIS_DXTSOURCE_CODE", A467BR_Diagnosis_DXTsource_Code);
         GxWebStd.gx_hidden_field( context, "BR_DIAGNOSIS_INITIALDX_CODE", A503BR_Diagnosis_InitialDX_Code);
         GxWebStd.gx_hidden_field( context, "BR_DIAGNOSIS_METASTASESDX_CODE", A504BR_Diagnosis_MetastasesDX_Code);
         GxWebStd.gx_hidden_field( context, "vTCURRENTCODE", AV15tCurrentCode);
         GxWebStd.gx_hidden_field( context, "BR_INFORMATION_ID", StringUtil.LTrim( StringUtil.NToC( (decimal)(A85BR_Information_ID), 18, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "vPGMNAME", StringUtil.RTrim( AV16Pgmname));
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
         return formatLink("br_diagnosis.aspx") + "?" + UrlEncode(StringUtil.RTrim(Gx_mode)) + "," + UrlEncode("" +AV12BR_DiagnosisID) ;
      }

      public override String GetPgmname( )
      {
         return "BR_Diagnosis" ;
      }

      public override String GetPgmdesc( )
      {
         return "Data Mgmt Portal - RAAP" ;
      }

      protected void InitializeNonKey0C13( )
      {
         A85BR_Information_ID = 0;
         n85BR_Information_ID = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A85BR_Information_ID", StringUtil.LTrim( StringUtil.Str( (decimal)(A85BR_Information_ID), 18, 0)));
         A19BR_EncounterID = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A19BR_EncounterID", StringUtil.LTrim( StringUtil.Str( (decimal)(A19BR_EncounterID), 18, 0)));
         A466BR_Diagnosis_DXType_Code = "";
         n466BR_Diagnosis_DXType_Code = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A466BR_Diagnosis_DXType_Code", A466BR_Diagnosis_DXType_Code);
         A467BR_Diagnosis_DXTsource_Code = "";
         n467BR_Diagnosis_DXTsource_Code = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A467BR_Diagnosis_DXTsource_Code", A467BR_Diagnosis_DXTsource_Code);
         A503BR_Diagnosis_InitialDX_Code = "";
         n503BR_Diagnosis_InitialDX_Code = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A503BR_Diagnosis_InitialDX_Code", A503BR_Diagnosis_InitialDX_Code);
         A504BR_Diagnosis_MetastasesDX_Code = "";
         n504BR_Diagnosis_MetastasesDX_Code = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A504BR_Diagnosis_MetastasesDX_Code", A504BR_Diagnosis_MetastasesDX_Code);
         A36BR_Information_PatientNo = "";
         n36BR_Information_PatientNo = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A36BR_Information_PatientNo", A36BR_Information_PatientNo);
         A513BR_Diagnosis_No = 0;
         n513BR_Diagnosis_No = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A513BR_Diagnosis_No", StringUtil.LTrim( StringUtil.Str( (decimal)(A513BR_Diagnosis_No), 10, 0)));
         n513BR_Diagnosis_No = ((0==A513BR_Diagnosis_No) ? true : false);
         A65BR_Diagnosis_DXID = "";
         n65BR_Diagnosis_DXID = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A65BR_Diagnosis_DXID", A65BR_Diagnosis_DXID);
         n65BR_Diagnosis_DXID = (String.IsNullOrEmpty(StringUtil.RTrim( A65BR_Diagnosis_DXID)) ? true : false);
         A66BR_Diagnosis_DXCode = "";
         n66BR_Diagnosis_DXCode = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A66BR_Diagnosis_DXCode", A66BR_Diagnosis_DXCode);
         n66BR_Diagnosis_DXCode = (String.IsNullOrEmpty(StringUtil.RTrim( A66BR_Diagnosis_DXCode)) ? true : false);
         A67BR_Diagnosis_DXType = "";
         n67BR_Diagnosis_DXType = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A67BR_Diagnosis_DXType", A67BR_Diagnosis_DXType);
         n67BR_Diagnosis_DXType = (String.IsNullOrEmpty(StringUtil.RTrim( A67BR_Diagnosis_DXType)) ? true : false);
         A68BR_Diagnosis_DXTsource = "";
         n68BR_Diagnosis_DXTsource = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A68BR_Diagnosis_DXTsource", A68BR_Diagnosis_DXTsource);
         n68BR_Diagnosis_DXTsource = (String.IsNullOrEmpty(StringUtil.RTrim( A68BR_Diagnosis_DXTsource)) ? true : false);
         A69BR_Diagnosis_DXDescription = "";
         n69BR_Diagnosis_DXDescription = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A69BR_Diagnosis_DXDescription", A69BR_Diagnosis_DXDescription);
         n69BR_Diagnosis_DXDescription = (String.IsNullOrEmpty(StringUtil.RTrim( A69BR_Diagnosis_DXDescription)) ? true : false);
         A70BR_Diagnosis_InitialDX = "";
         n70BR_Diagnosis_InitialDX = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A70BR_Diagnosis_InitialDX", A70BR_Diagnosis_InitialDX);
         n70BR_Diagnosis_InitialDX = (String.IsNullOrEmpty(StringUtil.RTrim( A70BR_Diagnosis_InitialDX)) ? true : false);
         A71BR_Diagnosis_MetastasesDX = "";
         n71BR_Diagnosis_MetastasesDX = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A71BR_Diagnosis_MetastasesDX", A71BR_Diagnosis_MetastasesDX);
         n71BR_Diagnosis_MetastasesDX = (String.IsNullOrEmpty(StringUtil.RTrim( A71BR_Diagnosis_MetastasesDX)) ? true : false);
         A260BR_Diagnosis_DXSource = "";
         n260BR_Diagnosis_DXSource = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A260BR_Diagnosis_DXSource", A260BR_Diagnosis_DXSource);
         n260BR_Diagnosis_DXSource = (String.IsNullOrEmpty(StringUtil.RTrim( A260BR_Diagnosis_DXSource)) ? true : false);
         A569BR_Diagnosis_TumorStageClinical = "";
         n569BR_Diagnosis_TumorStageClinical = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A569BR_Diagnosis_TumorStageClinical", A569BR_Diagnosis_TumorStageClinical);
         n569BR_Diagnosis_TumorStageClinical = (String.IsNullOrEmpty(StringUtil.RTrim( A569BR_Diagnosis_TumorStageClinical)) ? true : false);
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
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A64BR_DiagnosisID", StringUtil.LTrim( StringUtil.Str( (decimal)(A64BR_DiagnosisID), 18, 0)));
         InitializeNonKey0C13( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?20202281564278", true);
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
         context.AddJavascriptSource("br_diagnosis.js", "?20202281564279", false);
         context.AddJavascriptSource("DVelop/Bootstrap/Shared/DVelopBootstrap.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/Panel/BootstrapPanelRender.js", "", false);
         /* End function include_jscripts */
      }

      protected void init_default_properties( )
      {
         lblTextblockbr_diagnosis_no_Internalname = "TEXTBLOCKBR_DIAGNOSIS_NO";
         edtBR_Diagnosis_No_Internalname = "BR_DIAGNOSIS_NO";
         divUnnamedtablebr_diagnosis_no_Internalname = "UNNAMEDTABLEBR_DIAGNOSIS_NO";
         lblTextblockbr_diagnosis_dxdescription_Internalname = "TEXTBLOCKBR_DIAGNOSIS_DXDESCRIPTION";
         edtBR_Diagnosis_DXDescription_Internalname = "BR_DIAGNOSIS_DXDESCRIPTION";
         divUnnamedtablebr_diagnosis_dxdescription_Internalname = "UNNAMEDTABLEBR_DIAGNOSIS_DXDESCRIPTION";
         lblTextblockbr_diagnosis_dxtsource_Internalname = "TEXTBLOCKBR_DIAGNOSIS_DXTSOURCE";
         dynBR_Diagnosis_DXTsource_Internalname = "BR_DIAGNOSIS_DXTSOURCE";
         divUnnamedtablebr_diagnosis_dxtsource_Internalname = "UNNAMEDTABLEBR_DIAGNOSIS_DXTSOURCE";
         lblTextblockbr_diagnosis_dxid_Internalname = "TEXTBLOCKBR_DIAGNOSIS_DXID";
         edtBR_Diagnosis_DXID_Internalname = "BR_DIAGNOSIS_DXID";
         divUnnamedtablebr_diagnosis_dxid_Internalname = "UNNAMEDTABLEBR_DIAGNOSIS_DXID";
         lblTextblockbr_diagnosis_dxcode_Internalname = "TEXTBLOCKBR_DIAGNOSIS_DXCODE";
         edtBR_Diagnosis_DXCode_Internalname = "BR_DIAGNOSIS_DXCODE";
         divUnnamedtablebr_diagnosis_dxcode_Internalname = "UNNAMEDTABLEBR_DIAGNOSIS_DXCODE";
         lblTextblockbr_diagnosis_dxtype_Internalname = "TEXTBLOCKBR_DIAGNOSIS_DXTYPE";
         dynBR_Diagnosis_DXType_Internalname = "BR_DIAGNOSIS_DXTYPE";
         divUnnamedtablebr_diagnosis_dxtype_Internalname = "UNNAMEDTABLEBR_DIAGNOSIS_DXTYPE";
         lblTextblockbr_diagnosis_initialdx_Internalname = "TEXTBLOCKBR_DIAGNOSIS_INITIALDX";
         cmbBR_Diagnosis_InitialDX_Internalname = "BR_DIAGNOSIS_INITIALDX";
         divUnnamedtablebr_diagnosis_initialdx_Internalname = "UNNAMEDTABLEBR_DIAGNOSIS_INITIALDX";
         lblTextblockbr_diagnosis_metastasesdx_Internalname = "TEXTBLOCKBR_DIAGNOSIS_METASTASESDX";
         cmbBR_Diagnosis_MetastasesDX_Internalname = "BR_DIAGNOSIS_METASTASESDX";
         divUnnamedtablebr_diagnosis_metastasesdx_Internalname = "UNNAMEDTABLEBR_DIAGNOSIS_METASTASESDX";
         lblTextblockbr_diagnosis_dxsource_Internalname = "TEXTBLOCKBR_DIAGNOSIS_DXSOURCE";
         edtBR_Diagnosis_DXSource_Internalname = "BR_DIAGNOSIS_DXSOURCE";
         divUnnamedtablebr_diagnosis_dxsource_Internalname = "UNNAMEDTABLEBR_DIAGNOSIS_DXSOURCE";
         divBr_diagnosis_dxsource_cell_Internalname = "BR_DIAGNOSIS_DXSOURCE_CELL";
         edtBR_Diagnosis_TumorStageClinical_Internalname = "BR_DIAGNOSIS_TUMORSTAGECLINICAL";
         divTableattributes_Internalname = "TABLEATTRIBUTES";
         divLayout_tableattributes_Internalname = "LAYOUT_TABLEATTRIBUTES";
         Dvpanel_tableattributes_Internalname = "DVPANEL_TABLEATTRIBUTES";
         divHtml_dvpanel_tableattributes_Internalname = "HTML_DVPANEL_TABLEATTRIBUTES";
         divTablecontent_Internalname = "TABLECONTENT";
         bttBtntrn_enter_Internalname = "BTNTRN_ENTER";
         bttBtntrn_cancel_Internalname = "BTNTRN_CANCEL";
         bttBtntrn_delete_Internalname = "BTNTRN_DELETE";
         divTablemain_Internalname = "TABLEMAIN";
         edtBR_DiagnosisID_Internalname = "BR_DIAGNOSISID";
         edtBR_EncounterID_Internalname = "BR_ENCOUNTERID";
         edtBR_Information_PatientNo_Internalname = "BR_INFORMATION_PATIENTNO";
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
         Form.Caption = "Data Mgmt Portal - RAAP";
         edtBR_Information_PatientNo_Jsonclick = "";
         edtBR_Information_PatientNo_Enabled = 0;
         edtBR_Information_PatientNo_Visible = 1;
         edtBR_EncounterID_Jsonclick = "";
         edtBR_EncounterID_Enabled = 1;
         edtBR_EncounterID_Visible = 1;
         edtBR_DiagnosisID_Jsonclick = "";
         edtBR_DiagnosisID_Enabled = 0;
         edtBR_DiagnosisID_Visible = 1;
         bttBtntrn_delete_Enabled = 0;
         bttBtntrn_delete_Visible = 1;
         bttBtntrn_cancel_Visible = 1;
         bttBtntrn_enter_Enabled = 1;
         bttBtntrn_enter_Visible = 1;
         edtBR_Diagnosis_TumorStageClinical_Jsonclick = "";
         edtBR_Diagnosis_TumorStageClinical_Enabled = 1;
         edtBR_Diagnosis_DXSource_Jsonclick = "";
         edtBR_Diagnosis_DXSource_Enabled = 1;
         edtBR_Diagnosis_DXSource_Visible = 1;
         divBr_diagnosis_dxsource_cell_Class = "col-xs-12 col-md-6";
         cmbBR_Diagnosis_MetastasesDX_Jsonclick = "";
         cmbBR_Diagnosis_MetastasesDX.Enabled = 1;
         cmbBR_Diagnosis_InitialDX_Jsonclick = "";
         cmbBR_Diagnosis_InitialDX.Enabled = 1;
         dynBR_Diagnosis_DXType_Jsonclick = "";
         dynBR_Diagnosis_DXType.Enabled = 1;
         edtBR_Diagnosis_DXCode_Jsonclick = "";
         edtBR_Diagnosis_DXCode_Enabled = 1;
         edtBR_Diagnosis_DXID_Jsonclick = "";
         edtBR_Diagnosis_DXID_Enabled = 1;
         dynBR_Diagnosis_DXTsource_Jsonclick = "";
         dynBR_Diagnosis_DXTsource.Enabled = 1;
         edtBR_Diagnosis_DXDescription_Jsonclick = "";
         edtBR_Diagnosis_DXDescription_Enabled = 1;
         edtBR_Diagnosis_No_Jsonclick = "";
         edtBR_Diagnosis_No_Enabled = 1;
         Dvpanel_tableattributes_Autoscroll = Convert.ToBoolean( 0);
         Dvpanel_tableattributes_Iconposition = "left";
         Dvpanel_tableattributes_Showcollapseicon = Convert.ToBoolean( 0);
         Dvpanel_tableattributes_Collapsed = Convert.ToBoolean( 0);
         Dvpanel_tableattributes_Collapsible = Convert.ToBoolean( 0);
         Dvpanel_tableattributes_Title = "诊断";
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

      protected void GXDLABR_DIAGNOSIS_DXTSOURCE0C13( String AV15tCurrentCode )
      {
         if ( ! context.isAjaxRequest( ) )
         {
            context.GX_webresponse.AppendHeader("Cache-Control", "no-store");
         }
         context.GX_webresponse.AddString("[[");
         GXDLABR_DIAGNOSIS_DXTSOURCE_data0C13( AV15tCurrentCode) ;
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

      protected void GXABR_DIAGNOSIS_DXTSOURCE_html0C13( String AV15tCurrentCode )
      {
         String gxdynajaxvalue ;
         GXDLABR_DIAGNOSIS_DXTSOURCE_data0C13( AV15tCurrentCode) ;
         gxdynajaxindex = 1;
         if ( ! ( gxdyncontrolsrefreshing && context.isAjaxRequest( ) ) )
         {
            dynBR_Diagnosis_DXTsource.removeAllItems();
         }
         while ( gxdynajaxindex <= gxdynajaxctrlcodr.Count )
         {
            gxdynajaxvalue = ((String)gxdynajaxctrlcodr.Item(gxdynajaxindex));
            dynBR_Diagnosis_DXTsource.addItem(gxdynajaxvalue, ((String)gxdynajaxctrldescr.Item(gxdynajaxindex)), 0);
            gxdynajaxindex = (int)(gxdynajaxindex+1);
         }
      }

      protected void GXDLABR_DIAGNOSIS_DXTSOURCE_data0C13( String AV15tCurrentCode )
      {
         gxdynajaxctrlcodr.Clear();
         gxdynajaxctrldescr.Clear();
         /* Using cursor T000C18 */
         pr_default.execute(16, new Object[] {AV15tCurrentCode});
         while ( (pr_default.getStatus(16) != 101) )
         {
            gxdynajaxctrlcodr.Add(T000C18_A168XT_DefineCodeName[0]);
            gxdynajaxctrldescr.Add(T000C18_A168XT_DefineCodeName[0]);
            pr_default.readNext(16);
         }
         pr_default.close(16);
      }

      protected void GXDLABR_DIAGNOSIS_DXTYPE0C13( String AV15tCurrentCode )
      {
         if ( ! context.isAjaxRequest( ) )
         {
            context.GX_webresponse.AppendHeader("Cache-Control", "no-store");
         }
         context.GX_webresponse.AddString("[[");
         GXDLABR_DIAGNOSIS_DXTYPE_data0C13( AV15tCurrentCode) ;
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

      protected void GXABR_DIAGNOSIS_DXTYPE_html0C13( String AV15tCurrentCode )
      {
         String gxdynajaxvalue ;
         GXDLABR_DIAGNOSIS_DXTYPE_data0C13( AV15tCurrentCode) ;
         gxdynajaxindex = 1;
         if ( ! ( gxdyncontrolsrefreshing && context.isAjaxRequest( ) ) )
         {
            dynBR_Diagnosis_DXType.removeAllItems();
         }
         while ( gxdynajaxindex <= gxdynajaxctrlcodr.Count )
         {
            gxdynajaxvalue = ((String)gxdynajaxctrlcodr.Item(gxdynajaxindex));
            dynBR_Diagnosis_DXType.addItem(gxdynajaxvalue, ((String)gxdynajaxctrldescr.Item(gxdynajaxindex)), 0);
            gxdynajaxindex = (int)(gxdynajaxindex+1);
         }
      }

      protected void GXDLABR_DIAGNOSIS_DXTYPE_data0C13( String AV15tCurrentCode )
      {
         gxdynajaxctrlcodr.Clear();
         gxdynajaxctrldescr.Clear();
         gxdynajaxctrlcodr.Add("");
         gxdynajaxctrldescr.Add("(请选择)");
         /* Using cursor T000C19 */
         pr_default.execute(17, new Object[] {AV15tCurrentCode});
         while ( (pr_default.getStatus(17) != 101) )
         {
            gxdynajaxctrlcodr.Add(T000C19_A168XT_DefineCodeName[0]);
            gxdynajaxctrldescr.Add(T000C19_A168XT_DefineCodeName[0]);
            pr_default.readNext(17);
         }
         pr_default.close(17);
      }

      protected void GX11ASABR_DIAGNOSIS_DXTYPE_CODE0C13( String A67BR_Diagnosis_DXType )
      {
         GXt_char1 = A466BR_Diagnosis_DXType_Code;
         new zutil_findtargetcode(context ).execute(  20,  A67BR_Diagnosis_DXType, out  GXt_char1) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A67BR_Diagnosis_DXType", A67BR_Diagnosis_DXType);
         A466BR_Diagnosis_DXType_Code = GXt_char1;
         n466BR_Diagnosis_DXType_Code = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A466BR_Diagnosis_DXType_Code", A466BR_Diagnosis_DXType_Code);
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("[[");
         context.GX_webresponse.AddString("\""+GXUtil.EncodeJSConstant( A466BR_Diagnosis_DXType_Code)+"\"");
         context.GX_webresponse.AddString("]");
         if ( true )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString("]");
      }

      protected void GX12ASABR_DIAGNOSIS_DXTYPE_CODE0C13( String A67BR_Diagnosis_DXType )
      {
         GXt_char1 = A466BR_Diagnosis_DXType_Code;
         new zutil_findtargetcode(context ).execute(  20,  A67BR_Diagnosis_DXType, out  GXt_char1) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A67BR_Diagnosis_DXType", A67BR_Diagnosis_DXType);
         A466BR_Diagnosis_DXType_Code = GXt_char1;
         n466BR_Diagnosis_DXType_Code = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A466BR_Diagnosis_DXType_Code", A466BR_Diagnosis_DXType_Code);
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("[[");
         context.GX_webresponse.AddString("\""+GXUtil.EncodeJSConstant( A466BR_Diagnosis_DXType_Code)+"\"");
         context.GX_webresponse.AddString("]");
         if ( true )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString("]");
      }

      protected void GX13ASABR_DIAGNOSIS_DXTSOURCE_CODE0C13( String A68BR_Diagnosis_DXTsource )
      {
         GXt_char1 = A467BR_Diagnosis_DXTsource_Code;
         new zutil_findtargetcode(context ).execute(  21,  A68BR_Diagnosis_DXTsource, out  GXt_char1) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A68BR_Diagnosis_DXTsource", A68BR_Diagnosis_DXTsource);
         A467BR_Diagnosis_DXTsource_Code = GXt_char1;
         n467BR_Diagnosis_DXTsource_Code = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A467BR_Diagnosis_DXTsource_Code", A467BR_Diagnosis_DXTsource_Code);
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("[[");
         context.GX_webresponse.AddString("\""+GXUtil.EncodeJSConstant( A467BR_Diagnosis_DXTsource_Code)+"\"");
         context.GX_webresponse.AddString("]");
         if ( true )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString("]");
      }

      protected void GX14ASABR_DIAGNOSIS_DXTSOURCE_CODE0C13( String A68BR_Diagnosis_DXTsource )
      {
         GXt_char1 = A467BR_Diagnosis_DXTsource_Code;
         new zutil_findtargetcode(context ).execute(  21,  A68BR_Diagnosis_DXTsource, out  GXt_char1) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A68BR_Diagnosis_DXTsource", A68BR_Diagnosis_DXTsource);
         A467BR_Diagnosis_DXTsource_Code = GXt_char1;
         n467BR_Diagnosis_DXTsource_Code = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A467BR_Diagnosis_DXTsource_Code", A467BR_Diagnosis_DXTsource_Code);
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("[[");
         context.GX_webresponse.AddString("\""+GXUtil.EncodeJSConstant( A467BR_Diagnosis_DXTsource_Code)+"\"");
         context.GX_webresponse.AddString("]");
         if ( true )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString("]");
      }

      protected void GX15ASABR_DIAGNOSIS_INITIALDX_CODE0C13( String A70BR_Diagnosis_InitialDX )
      {
         GXt_char1 = A503BR_Diagnosis_InitialDX_Code;
         new zutil_findtargetcode(context ).execute(  37,  A70BR_Diagnosis_InitialDX, out  GXt_char1) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A70BR_Diagnosis_InitialDX", A70BR_Diagnosis_InitialDX);
         A503BR_Diagnosis_InitialDX_Code = GXt_char1;
         n503BR_Diagnosis_InitialDX_Code = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A503BR_Diagnosis_InitialDX_Code", A503BR_Diagnosis_InitialDX_Code);
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("[[");
         context.GX_webresponse.AddString("\""+GXUtil.EncodeJSConstant( A503BR_Diagnosis_InitialDX_Code)+"\"");
         context.GX_webresponse.AddString("]");
         if ( true )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString("]");
      }

      protected void GX16ASABR_DIAGNOSIS_INITIALDX_CODE0C13( String A70BR_Diagnosis_InitialDX )
      {
         GXt_char1 = A503BR_Diagnosis_InitialDX_Code;
         new zutil_findtargetcode(context ).execute(  37,  A70BR_Diagnosis_InitialDX, out  GXt_char1) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A70BR_Diagnosis_InitialDX", A70BR_Diagnosis_InitialDX);
         A503BR_Diagnosis_InitialDX_Code = GXt_char1;
         n503BR_Diagnosis_InitialDX_Code = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A503BR_Diagnosis_InitialDX_Code", A503BR_Diagnosis_InitialDX_Code);
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("[[");
         context.GX_webresponse.AddString("\""+GXUtil.EncodeJSConstant( A503BR_Diagnosis_InitialDX_Code)+"\"");
         context.GX_webresponse.AddString("]");
         if ( true )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString("]");
      }

      protected void GX17ASABR_DIAGNOSIS_METASTASESDX_CODE0C13( String A71BR_Diagnosis_MetastasesDX )
      {
         GXt_char1 = A504BR_Diagnosis_MetastasesDX_Code;
         new zutil_findtargetcode(context ).execute(  37,  A71BR_Diagnosis_MetastasesDX, out  GXt_char1) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A71BR_Diagnosis_MetastasesDX", A71BR_Diagnosis_MetastasesDX);
         A504BR_Diagnosis_MetastasesDX_Code = GXt_char1;
         n504BR_Diagnosis_MetastasesDX_Code = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A504BR_Diagnosis_MetastasesDX_Code", A504BR_Diagnosis_MetastasesDX_Code);
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("[[");
         context.GX_webresponse.AddString("\""+GXUtil.EncodeJSConstant( A504BR_Diagnosis_MetastasesDX_Code)+"\"");
         context.GX_webresponse.AddString("]");
         if ( true )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString("]");
      }

      protected void GX18ASABR_DIAGNOSIS_METASTASESDX_CODE0C13( String A71BR_Diagnosis_MetastasesDX )
      {
         GXt_char1 = A504BR_Diagnosis_MetastasesDX_Code;
         new zutil_findtargetcode(context ).execute(  37,  A71BR_Diagnosis_MetastasesDX, out  GXt_char1) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A71BR_Diagnosis_MetastasesDX", A71BR_Diagnosis_MetastasesDX);
         A504BR_Diagnosis_MetastasesDX_Code = GXt_char1;
         n504BR_Diagnosis_MetastasesDX_Code = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A504BR_Diagnosis_MetastasesDX_Code", A504BR_Diagnosis_MetastasesDX_Code);
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("[[");
         context.GX_webresponse.AddString("\""+GXUtil.EncodeJSConstant( A504BR_Diagnosis_MetastasesDX_Code)+"\"");
         context.GX_webresponse.AddString("]");
         if ( true )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString("]");
      }

      protected void XC_25_0C13( )
      {
         new zutil_recordsonlog(context ).execute(  StringUtil.Trim( StringUtil.Str( (decimal)(A19BR_EncounterID), 18, 0)),  "就诊信息",  StringUtil.Trim( StringUtil.Str( (decimal)(A64BR_DiagnosisID), 18, 0)),  "诊断",  "Create",  1) ;
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

      protected void XC_26_0C13( )
      {
         new zutil_recordsonlog(context ).execute(  StringUtil.Trim( StringUtil.Str( (decimal)(A19BR_EncounterID), 18, 0)),  "就诊信息",  StringUtil.Trim( StringUtil.Str( (decimal)(A64BR_DiagnosisID), 18, 0)),  "诊断",  "Update",  1) ;
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

      protected void XC_27_0C13( )
      {
         new zutil_recordsonlog(context ).execute(  StringUtil.Trim( StringUtil.Str( (decimal)(A19BR_EncounterID), 18, 0)),  "就诊信息",  StringUtil.Trim( StringUtil.Str( (decimal)(A64BR_DiagnosisID), 18, 0)),  "诊断",  "Delete",  1) ;
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
         dynBR_Diagnosis_DXTsource.Name = "BR_DIAGNOSIS_DXTSOURCE";
         dynBR_Diagnosis_DXTsource.WebTags = "";
         dynBR_Diagnosis_DXType.Name = "BR_DIAGNOSIS_DXTYPE";
         dynBR_Diagnosis_DXType.WebTags = "";
         cmbBR_Diagnosis_InitialDX.Name = "BR_DIAGNOSIS_INITIALDX";
         cmbBR_Diagnosis_InitialDX.WebTags = "";
         cmbBR_Diagnosis_InitialDX.addItem("", "(请选择)", 0);
         cmbBR_Diagnosis_InitialDX.addItem("否", "否", 0);
         cmbBR_Diagnosis_InitialDX.addItem("是", "是", 0);
         cmbBR_Diagnosis_InitialDX.addItem("不详", "不详", 0);
         if ( cmbBR_Diagnosis_InitialDX.ItemCount > 0 )
         {
            A70BR_Diagnosis_InitialDX = cmbBR_Diagnosis_InitialDX.getValidValue(A70BR_Diagnosis_InitialDX);
            n70BR_Diagnosis_InitialDX = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A70BR_Diagnosis_InitialDX", A70BR_Diagnosis_InitialDX);
         }
         cmbBR_Diagnosis_MetastasesDX.Name = "BR_DIAGNOSIS_METASTASESDX";
         cmbBR_Diagnosis_MetastasesDX.WebTags = "";
         cmbBR_Diagnosis_MetastasesDX.addItem("", "(请选择)", 0);
         cmbBR_Diagnosis_MetastasesDX.addItem("否", "否", 0);
         cmbBR_Diagnosis_MetastasesDX.addItem("是", "是", 0);
         cmbBR_Diagnosis_MetastasesDX.addItem("不详", "不详", 0);
         if ( cmbBR_Diagnosis_MetastasesDX.ItemCount > 0 )
         {
            A71BR_Diagnosis_MetastasesDX = cmbBR_Diagnosis_MetastasesDX.getValidValue(A71BR_Diagnosis_MetastasesDX);
            n71BR_Diagnosis_MetastasesDX = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A71BR_Diagnosis_MetastasesDX", A71BR_Diagnosis_MetastasesDX);
         }
         /* End function init_web_controls */
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
         /* Using cursor T000C20 */
         pr_default.execute(18, new Object[] {A19BR_EncounterID});
         if ( (pr_default.getStatus(18) == 101) )
         {
            GX_msglist.addItem("不匹配' T15'", "ForeignKeyNotFound", 1, "BR_ENCOUNTERID");
            AnyError = 1;
            GX_FocusControl = edtBR_EncounterID_Internalname;
         }
         A85BR_Information_ID = T000C20_A85BR_Information_ID[0];
         n85BR_Information_ID = T000C20_n85BR_Information_ID[0];
         pr_default.close(18);
         /* Using cursor T000C21 */
         pr_default.execute(19, new Object[] {n85BR_Information_ID, A85BR_Information_ID});
         if ( (pr_default.getStatus(19) == 101) )
         {
            if ( ! ( (0==A85BR_Information_ID) ) )
            {
               GX_msglist.addItem("不匹配' T16'", "ForeignKeyNotFound", 1, "");
               AnyError = 1;
            }
         }
         A36BR_Information_PatientNo = T000C21_A36BR_Information_PatientNo[0];
         n36BR_Information_PatientNo = T000C21_n36BR_Information_PatientNo[0];
         pr_default.close(19);
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
         setEventMetadata("ENTER","{handler:'UserMainFullajax',iparms:[{postForm:true},{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV12BR_DiagnosisID',fld:'vBR_DIAGNOSISID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true}]");
         setEventMetadata("ENTER",",oparms:[]}");
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV12BR_DiagnosisID',fld:'vBR_DIAGNOSISID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true},{av:'A64BR_DiagnosisID',fld:'BR_DIAGNOSISID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV15tCurrentCode',fld:'vTCURRENTCODE',pic:''},{av:'AV10Insert_BR_EncounterID',fld:'vINSERT_BR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ'}]");
         setEventMetadata("REFRESH",",oparms:[]}");
         setEventMetadata("AFTER TRN","{handler:'E120C2',iparms:[{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV8TrnContext',fld:'vTRNCONTEXT',pic:''}]");
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
         pr_default.close(18);
         pr_default.close(13);
         pr_default.close(19);
         pr_default.close(14);
      }

      public override void initialize( )
      {
         sPrefix = "";
         wcpOGx_mode = "";
         Z466BR_Diagnosis_DXType_Code = "";
         Z467BR_Diagnosis_DXTsource_Code = "";
         Z503BR_Diagnosis_InitialDX_Code = "";
         Z504BR_Diagnosis_MetastasesDX_Code = "";
         Z65BR_Diagnosis_DXID = "";
         Z66BR_Diagnosis_DXCode = "";
         Z67BR_Diagnosis_DXType = "";
         Z68BR_Diagnosis_DXTsource = "";
         Z69BR_Diagnosis_DXDescription = "";
         Z70BR_Diagnosis_InitialDX = "";
         Z71BR_Diagnosis_MetastasesDX = "";
         Z260BR_Diagnosis_DXSource = "";
         Z569BR_Diagnosis_TumorStageClinical = "";
         scmdbuf = "";
         gxfirstwebparm = "";
         gxfirstwebparm_bkp = "";
         AV15tCurrentCode = "";
         A67BR_Diagnosis_DXType = "";
         A68BR_Diagnosis_DXTsource = "";
         A70BR_Diagnosis_InitialDX = "";
         A71BR_Diagnosis_MetastasesDX = "";
         GXKey = "";
         PreviousTooltip = "";
         PreviousCaption = "";
         Form = new GXWebForm();
         GX_FocusControl = "";
         ClassString = "";
         StyleString = "";
         ucDvpanel_tableattributes = new GXUserControl();
         lblTextblockbr_diagnosis_no_Jsonclick = "";
         TempTags = "";
         lblTextblockbr_diagnosis_dxdescription_Jsonclick = "";
         A69BR_Diagnosis_DXDescription = "";
         lblTextblockbr_diagnosis_dxtsource_Jsonclick = "";
         lblTextblockbr_diagnosis_dxid_Jsonclick = "";
         A65BR_Diagnosis_DXID = "";
         lblTextblockbr_diagnosis_dxcode_Jsonclick = "";
         A66BR_Diagnosis_DXCode = "";
         lblTextblockbr_diagnosis_dxtype_Jsonclick = "";
         lblTextblockbr_diagnosis_initialdx_Jsonclick = "";
         lblTextblockbr_diagnosis_metastasesdx_Jsonclick = "";
         lblTextblockbr_diagnosis_dxsource_Jsonclick = "";
         A260BR_Diagnosis_DXSource = "";
         A569BR_Diagnosis_TumorStageClinical = "";
         bttBtntrn_enter_Jsonclick = "";
         bttBtntrn_cancel_Jsonclick = "";
         bttBtntrn_delete_Jsonclick = "";
         A36BR_Information_PatientNo = "";
         A466BR_Diagnosis_DXType_Code = "";
         A467BR_Diagnosis_DXTsource_Code = "";
         A503BR_Diagnosis_InitialDX_Code = "";
         A504BR_Diagnosis_MetastasesDX_Code = "";
         AV16Pgmname = "";
         Dvpanel_tableattributes_Objectcall = "";
         Dvpanel_tableattributes_Class = "";
         Dvpanel_tableattributes_Height = "";
         forbiddenHiddens = "";
         hsh = "";
         sMode13 = "";
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         AV7WWPContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPContext(context);
         AV8TrnContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext(context);
         AV9WebSession = context.GetSession();
         AV11TrnContextAtt = new GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext_Attribute(context);
         Z36BR_Information_PatientNo = "";
         T000C4_A85BR_Information_ID = new long[1] ;
         T000C4_n85BR_Information_ID = new bool[] {false} ;
         T000C5_A36BR_Information_PatientNo = new String[] {""} ;
         T000C5_n36BR_Information_PatientNo = new bool[] {false} ;
         T000C6_A85BR_Information_ID = new long[1] ;
         T000C6_n85BR_Information_ID = new bool[] {false} ;
         T000C6_A64BR_DiagnosisID = new long[1] ;
         T000C6_A466BR_Diagnosis_DXType_Code = new String[] {""} ;
         T000C6_n466BR_Diagnosis_DXType_Code = new bool[] {false} ;
         T000C6_A467BR_Diagnosis_DXTsource_Code = new String[] {""} ;
         T000C6_n467BR_Diagnosis_DXTsource_Code = new bool[] {false} ;
         T000C6_A503BR_Diagnosis_InitialDX_Code = new String[] {""} ;
         T000C6_n503BR_Diagnosis_InitialDX_Code = new bool[] {false} ;
         T000C6_A504BR_Diagnosis_MetastasesDX_Code = new String[] {""} ;
         T000C6_n504BR_Diagnosis_MetastasesDX_Code = new bool[] {false} ;
         T000C6_A36BR_Information_PatientNo = new String[] {""} ;
         T000C6_n36BR_Information_PatientNo = new bool[] {false} ;
         T000C6_A513BR_Diagnosis_No = new long[1] ;
         T000C6_n513BR_Diagnosis_No = new bool[] {false} ;
         T000C6_A65BR_Diagnosis_DXID = new String[] {""} ;
         T000C6_n65BR_Diagnosis_DXID = new bool[] {false} ;
         T000C6_A66BR_Diagnosis_DXCode = new String[] {""} ;
         T000C6_n66BR_Diagnosis_DXCode = new bool[] {false} ;
         T000C6_A67BR_Diagnosis_DXType = new String[] {""} ;
         T000C6_n67BR_Diagnosis_DXType = new bool[] {false} ;
         T000C6_A68BR_Diagnosis_DXTsource = new String[] {""} ;
         T000C6_n68BR_Diagnosis_DXTsource = new bool[] {false} ;
         T000C6_A69BR_Diagnosis_DXDescription = new String[] {""} ;
         T000C6_n69BR_Diagnosis_DXDescription = new bool[] {false} ;
         T000C6_A70BR_Diagnosis_InitialDX = new String[] {""} ;
         T000C6_n70BR_Diagnosis_InitialDX = new bool[] {false} ;
         T000C6_A71BR_Diagnosis_MetastasesDX = new String[] {""} ;
         T000C6_n71BR_Diagnosis_MetastasesDX = new bool[] {false} ;
         T000C6_A260BR_Diagnosis_DXSource = new String[] {""} ;
         T000C6_n260BR_Diagnosis_DXSource = new bool[] {false} ;
         T000C6_A569BR_Diagnosis_TumorStageClinical = new String[] {""} ;
         T000C6_n569BR_Diagnosis_TumorStageClinical = new bool[] {false} ;
         T000C6_A19BR_EncounterID = new long[1] ;
         T000C7_A85BR_Information_ID = new long[1] ;
         T000C7_n85BR_Information_ID = new bool[] {false} ;
         T000C8_A36BR_Information_PatientNo = new String[] {""} ;
         T000C8_n36BR_Information_PatientNo = new bool[] {false} ;
         T000C9_A64BR_DiagnosisID = new long[1] ;
         T000C3_A64BR_DiagnosisID = new long[1] ;
         T000C3_A466BR_Diagnosis_DXType_Code = new String[] {""} ;
         T000C3_n466BR_Diagnosis_DXType_Code = new bool[] {false} ;
         T000C3_A467BR_Diagnosis_DXTsource_Code = new String[] {""} ;
         T000C3_n467BR_Diagnosis_DXTsource_Code = new bool[] {false} ;
         T000C3_A503BR_Diagnosis_InitialDX_Code = new String[] {""} ;
         T000C3_n503BR_Diagnosis_InitialDX_Code = new bool[] {false} ;
         T000C3_A504BR_Diagnosis_MetastasesDX_Code = new String[] {""} ;
         T000C3_n504BR_Diagnosis_MetastasesDX_Code = new bool[] {false} ;
         T000C3_A513BR_Diagnosis_No = new long[1] ;
         T000C3_n513BR_Diagnosis_No = new bool[] {false} ;
         T000C3_A65BR_Diagnosis_DXID = new String[] {""} ;
         T000C3_n65BR_Diagnosis_DXID = new bool[] {false} ;
         T000C3_A66BR_Diagnosis_DXCode = new String[] {""} ;
         T000C3_n66BR_Diagnosis_DXCode = new bool[] {false} ;
         T000C3_A67BR_Diagnosis_DXType = new String[] {""} ;
         T000C3_n67BR_Diagnosis_DXType = new bool[] {false} ;
         T000C3_A68BR_Diagnosis_DXTsource = new String[] {""} ;
         T000C3_n68BR_Diagnosis_DXTsource = new bool[] {false} ;
         T000C3_A69BR_Diagnosis_DXDescription = new String[] {""} ;
         T000C3_n69BR_Diagnosis_DXDescription = new bool[] {false} ;
         T000C3_A70BR_Diagnosis_InitialDX = new String[] {""} ;
         T000C3_n70BR_Diagnosis_InitialDX = new bool[] {false} ;
         T000C3_A71BR_Diagnosis_MetastasesDX = new String[] {""} ;
         T000C3_n71BR_Diagnosis_MetastasesDX = new bool[] {false} ;
         T000C3_A260BR_Diagnosis_DXSource = new String[] {""} ;
         T000C3_n260BR_Diagnosis_DXSource = new bool[] {false} ;
         T000C3_A569BR_Diagnosis_TumorStageClinical = new String[] {""} ;
         T000C3_n569BR_Diagnosis_TumorStageClinical = new bool[] {false} ;
         T000C3_A19BR_EncounterID = new long[1] ;
         T000C10_A64BR_DiagnosisID = new long[1] ;
         T000C11_A64BR_DiagnosisID = new long[1] ;
         T000C2_A64BR_DiagnosisID = new long[1] ;
         T000C2_A466BR_Diagnosis_DXType_Code = new String[] {""} ;
         T000C2_n466BR_Diagnosis_DXType_Code = new bool[] {false} ;
         T000C2_A467BR_Diagnosis_DXTsource_Code = new String[] {""} ;
         T000C2_n467BR_Diagnosis_DXTsource_Code = new bool[] {false} ;
         T000C2_A503BR_Diagnosis_InitialDX_Code = new String[] {""} ;
         T000C2_n503BR_Diagnosis_InitialDX_Code = new bool[] {false} ;
         T000C2_A504BR_Diagnosis_MetastasesDX_Code = new String[] {""} ;
         T000C2_n504BR_Diagnosis_MetastasesDX_Code = new bool[] {false} ;
         T000C2_A513BR_Diagnosis_No = new long[1] ;
         T000C2_n513BR_Diagnosis_No = new bool[] {false} ;
         T000C2_A65BR_Diagnosis_DXID = new String[] {""} ;
         T000C2_n65BR_Diagnosis_DXID = new bool[] {false} ;
         T000C2_A66BR_Diagnosis_DXCode = new String[] {""} ;
         T000C2_n66BR_Diagnosis_DXCode = new bool[] {false} ;
         T000C2_A67BR_Diagnosis_DXType = new String[] {""} ;
         T000C2_n67BR_Diagnosis_DXType = new bool[] {false} ;
         T000C2_A68BR_Diagnosis_DXTsource = new String[] {""} ;
         T000C2_n68BR_Diagnosis_DXTsource = new bool[] {false} ;
         T000C2_A69BR_Diagnosis_DXDescription = new String[] {""} ;
         T000C2_n69BR_Diagnosis_DXDescription = new bool[] {false} ;
         T000C2_A70BR_Diagnosis_InitialDX = new String[] {""} ;
         T000C2_n70BR_Diagnosis_InitialDX = new bool[] {false} ;
         T000C2_A71BR_Diagnosis_MetastasesDX = new String[] {""} ;
         T000C2_n71BR_Diagnosis_MetastasesDX = new bool[] {false} ;
         T000C2_A260BR_Diagnosis_DXSource = new String[] {""} ;
         T000C2_n260BR_Diagnosis_DXSource = new bool[] {false} ;
         T000C2_A569BR_Diagnosis_TumorStageClinical = new String[] {""} ;
         T000C2_n569BR_Diagnosis_TumorStageClinical = new bool[] {false} ;
         T000C2_A19BR_EncounterID = new long[1] ;
         T000C12_A64BR_DiagnosisID = new long[1] ;
         T000C15_A85BR_Information_ID = new long[1] ;
         T000C15_n85BR_Information_ID = new bool[] {false} ;
         T000C16_A36BR_Information_PatientNo = new String[] {""} ;
         T000C16_n36BR_Information_PatientNo = new bool[] {false} ;
         T000C17_A64BR_DiagnosisID = new long[1] ;
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         gxdynajaxctrlcodr = new GeneXus.Utils.GxStringCollection();
         gxdynajaxctrldescr = new GeneXus.Utils.GxStringCollection();
         gxwrpcisep = "";
         T000C18_A167XT_DefineCodeID = new long[1] ;
         T000C18_A168XT_DefineCodeName = new String[] {""} ;
         T000C18_n168XT_DefineCodeName = new bool[] {false} ;
         T000C18_A165XT_DefindcodeTypeID = new long[1] ;
         T000C18_A432XT_TenantCode = new String[] {""} ;
         T000C18_n432XT_TenantCode = new bool[] {false} ;
         T000C19_A167XT_DefineCodeID = new long[1] ;
         T000C19_A168XT_DefineCodeName = new String[] {""} ;
         T000C19_n168XT_DefineCodeName = new bool[] {false} ;
         T000C19_A165XT_DefindcodeTypeID = new long[1] ;
         T000C19_A432XT_TenantCode = new String[] {""} ;
         T000C19_n432XT_TenantCode = new bool[] {false} ;
         GXt_char1 = "";
         T000C20_A85BR_Information_ID = new long[1] ;
         T000C20_n85BR_Information_ID = new bool[] {false} ;
         T000C21_A36BR_Information_PatientNo = new String[] {""} ;
         T000C21_n36BR_Information_PatientNo = new bool[] {false} ;
         isValidOutput = new GxUnknownObjectCollection();
         pr_datastore1 = new DataStoreProvider(context, new GeneXus.Programs.br_diagnosis__datastore1(),
            new Object[][] {
            }
         );
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.br_diagnosis__default(),
            new Object[][] {
                new Object[] {
               T000C2_A64BR_DiagnosisID, T000C2_A466BR_Diagnosis_DXType_Code, T000C2_n466BR_Diagnosis_DXType_Code, T000C2_A467BR_Diagnosis_DXTsource_Code, T000C2_n467BR_Diagnosis_DXTsource_Code, T000C2_A503BR_Diagnosis_InitialDX_Code, T000C2_n503BR_Diagnosis_InitialDX_Code, T000C2_A504BR_Diagnosis_MetastasesDX_Code, T000C2_n504BR_Diagnosis_MetastasesDX_Code, T000C2_A513BR_Diagnosis_No,
               T000C2_n513BR_Diagnosis_No, T000C2_A65BR_Diagnosis_DXID, T000C2_n65BR_Diagnosis_DXID, T000C2_A66BR_Diagnosis_DXCode, T000C2_n66BR_Diagnosis_DXCode, T000C2_A67BR_Diagnosis_DXType, T000C2_n67BR_Diagnosis_DXType, T000C2_A68BR_Diagnosis_DXTsource, T000C2_n68BR_Diagnosis_DXTsource, T000C2_A69BR_Diagnosis_DXDescription,
               T000C2_n69BR_Diagnosis_DXDescription, T000C2_A70BR_Diagnosis_InitialDX, T000C2_n70BR_Diagnosis_InitialDX, T000C2_A71BR_Diagnosis_MetastasesDX, T000C2_n71BR_Diagnosis_MetastasesDX, T000C2_A260BR_Diagnosis_DXSource, T000C2_n260BR_Diagnosis_DXSource, T000C2_A569BR_Diagnosis_TumorStageClinical, T000C2_n569BR_Diagnosis_TumorStageClinical, T000C2_A19BR_EncounterID
               }
               , new Object[] {
               T000C3_A64BR_DiagnosisID, T000C3_A466BR_Diagnosis_DXType_Code, T000C3_n466BR_Diagnosis_DXType_Code, T000C3_A467BR_Diagnosis_DXTsource_Code, T000C3_n467BR_Diagnosis_DXTsource_Code, T000C3_A503BR_Diagnosis_InitialDX_Code, T000C3_n503BR_Diagnosis_InitialDX_Code, T000C3_A504BR_Diagnosis_MetastasesDX_Code, T000C3_n504BR_Diagnosis_MetastasesDX_Code, T000C3_A513BR_Diagnosis_No,
               T000C3_n513BR_Diagnosis_No, T000C3_A65BR_Diagnosis_DXID, T000C3_n65BR_Diagnosis_DXID, T000C3_A66BR_Diagnosis_DXCode, T000C3_n66BR_Diagnosis_DXCode, T000C3_A67BR_Diagnosis_DXType, T000C3_n67BR_Diagnosis_DXType, T000C3_A68BR_Diagnosis_DXTsource, T000C3_n68BR_Diagnosis_DXTsource, T000C3_A69BR_Diagnosis_DXDescription,
               T000C3_n69BR_Diagnosis_DXDescription, T000C3_A70BR_Diagnosis_InitialDX, T000C3_n70BR_Diagnosis_InitialDX, T000C3_A71BR_Diagnosis_MetastasesDX, T000C3_n71BR_Diagnosis_MetastasesDX, T000C3_A260BR_Diagnosis_DXSource, T000C3_n260BR_Diagnosis_DXSource, T000C3_A569BR_Diagnosis_TumorStageClinical, T000C3_n569BR_Diagnosis_TumorStageClinical, T000C3_A19BR_EncounterID
               }
               , new Object[] {
               T000C4_A85BR_Information_ID, T000C4_n85BR_Information_ID
               }
               , new Object[] {
               T000C5_A36BR_Information_PatientNo, T000C5_n36BR_Information_PatientNo
               }
               , new Object[] {
               T000C6_A85BR_Information_ID, T000C6_n85BR_Information_ID, T000C6_A64BR_DiagnosisID, T000C6_A466BR_Diagnosis_DXType_Code, T000C6_n466BR_Diagnosis_DXType_Code, T000C6_A467BR_Diagnosis_DXTsource_Code, T000C6_n467BR_Diagnosis_DXTsource_Code, T000C6_A503BR_Diagnosis_InitialDX_Code, T000C6_n503BR_Diagnosis_InitialDX_Code, T000C6_A504BR_Diagnosis_MetastasesDX_Code,
               T000C6_n504BR_Diagnosis_MetastasesDX_Code, T000C6_A36BR_Information_PatientNo, T000C6_n36BR_Information_PatientNo, T000C6_A513BR_Diagnosis_No, T000C6_n513BR_Diagnosis_No, T000C6_A65BR_Diagnosis_DXID, T000C6_n65BR_Diagnosis_DXID, T000C6_A66BR_Diagnosis_DXCode, T000C6_n66BR_Diagnosis_DXCode, T000C6_A67BR_Diagnosis_DXType,
               T000C6_n67BR_Diagnosis_DXType, T000C6_A68BR_Diagnosis_DXTsource, T000C6_n68BR_Diagnosis_DXTsource, T000C6_A69BR_Diagnosis_DXDescription, T000C6_n69BR_Diagnosis_DXDescription, T000C6_A70BR_Diagnosis_InitialDX, T000C6_n70BR_Diagnosis_InitialDX, T000C6_A71BR_Diagnosis_MetastasesDX, T000C6_n71BR_Diagnosis_MetastasesDX, T000C6_A260BR_Diagnosis_DXSource,
               T000C6_n260BR_Diagnosis_DXSource, T000C6_A569BR_Diagnosis_TumorStageClinical, T000C6_n569BR_Diagnosis_TumorStageClinical, T000C6_A19BR_EncounterID
               }
               , new Object[] {
               T000C7_A85BR_Information_ID, T000C7_n85BR_Information_ID
               }
               , new Object[] {
               T000C8_A36BR_Information_PatientNo, T000C8_n36BR_Information_PatientNo
               }
               , new Object[] {
               T000C9_A64BR_DiagnosisID
               }
               , new Object[] {
               T000C10_A64BR_DiagnosisID
               }
               , new Object[] {
               T000C11_A64BR_DiagnosisID
               }
               , new Object[] {
               T000C12_A64BR_DiagnosisID
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               T000C15_A85BR_Information_ID, T000C15_n85BR_Information_ID
               }
               , new Object[] {
               T000C16_A36BR_Information_PatientNo, T000C16_n36BR_Information_PatientNo
               }
               , new Object[] {
               T000C17_A64BR_DiagnosisID
               }
               , new Object[] {
               T000C18_A167XT_DefineCodeID, T000C18_A168XT_DefineCodeName, T000C18_n168XT_DefineCodeName, T000C18_A165XT_DefindcodeTypeID, T000C18_A432XT_TenantCode, T000C18_n432XT_TenantCode
               }
               , new Object[] {
               T000C19_A167XT_DefineCodeID, T000C19_A168XT_DefineCodeName, T000C19_n168XT_DefineCodeName, T000C19_A165XT_DefindcodeTypeID, T000C19_A432XT_TenantCode, T000C19_n432XT_TenantCode
               }
               , new Object[] {
               T000C20_A85BR_Information_ID, T000C20_n85BR_Information_ID
               }
               , new Object[] {
               T000C21_A36BR_Information_PatientNo, T000C21_n36BR_Information_PatientNo
               }
            }
         );
         AV16Pgmname = "BR_Diagnosis";
      }

      private short GxWebError ;
      private short gxcookieaux ;
      private short IsConfirmed ;
      private short IsModified ;
      private short AnyError ;
      private short nKeyPressed ;
      private short initialized ;
      private short RcdFound13 ;
      private short GX_JID ;
      private short Gx_BScreen ;
      private short gxajaxcallmode ;
      private short wbTemp ;
      private int trnEnded ;
      private int edtBR_Diagnosis_No_Enabled ;
      private int edtBR_Diagnosis_DXDescription_Enabled ;
      private int edtBR_Diagnosis_DXID_Enabled ;
      private int edtBR_Diagnosis_DXCode_Enabled ;
      private int edtBR_Diagnosis_DXSource_Visible ;
      private int edtBR_Diagnosis_DXSource_Enabled ;
      private int edtBR_Diagnosis_TumorStageClinical_Enabled ;
      private int bttBtntrn_enter_Visible ;
      private int bttBtntrn_enter_Enabled ;
      private int bttBtntrn_cancel_Visible ;
      private int bttBtntrn_delete_Visible ;
      private int bttBtntrn_delete_Enabled ;
      private int edtBR_DiagnosisID_Enabled ;
      private int edtBR_DiagnosisID_Visible ;
      private int edtBR_EncounterID_Visible ;
      private int edtBR_EncounterID_Enabled ;
      private int edtBR_Information_PatientNo_Visible ;
      private int edtBR_Information_PatientNo_Enabled ;
      private int AV17GXV1 ;
      private int idxLst ;
      private int gxdynajaxindex ;
      private long wcpOAV12BR_DiagnosisID ;
      private long Z64BR_DiagnosisID ;
      private long Z513BR_Diagnosis_No ;
      private long Z19BR_EncounterID ;
      private long N19BR_EncounterID ;
      private long A19BR_EncounterID ;
      private long A85BR_Information_ID ;
      private long AV12BR_DiagnosisID ;
      private long A513BR_Diagnosis_No ;
      private long A64BR_DiagnosisID ;
      private long AV10Insert_BR_EncounterID ;
      private long Z85BR_Information_ID ;
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
      private String edtBR_Diagnosis_No_Internalname ;
      private String dynBR_Diagnosis_DXTsource_Internalname ;
      private String dynBR_Diagnosis_DXType_Internalname ;
      private String cmbBR_Diagnosis_InitialDX_Internalname ;
      private String cmbBR_Diagnosis_MetastasesDX_Internalname ;
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
      private String divUnnamedtablebr_diagnosis_no_Internalname ;
      private String lblTextblockbr_diagnosis_no_Internalname ;
      private String lblTextblockbr_diagnosis_no_Jsonclick ;
      private String TempTags ;
      private String edtBR_Diagnosis_No_Jsonclick ;
      private String divUnnamedtablebr_diagnosis_dxdescription_Internalname ;
      private String lblTextblockbr_diagnosis_dxdescription_Internalname ;
      private String lblTextblockbr_diagnosis_dxdescription_Jsonclick ;
      private String edtBR_Diagnosis_DXDescription_Internalname ;
      private String edtBR_Diagnosis_DXDescription_Jsonclick ;
      private String divUnnamedtablebr_diagnosis_dxtsource_Internalname ;
      private String lblTextblockbr_diagnosis_dxtsource_Internalname ;
      private String lblTextblockbr_diagnosis_dxtsource_Jsonclick ;
      private String dynBR_Diagnosis_DXTsource_Jsonclick ;
      private String divUnnamedtablebr_diagnosis_dxid_Internalname ;
      private String lblTextblockbr_diagnosis_dxid_Internalname ;
      private String lblTextblockbr_diagnosis_dxid_Jsonclick ;
      private String edtBR_Diagnosis_DXID_Internalname ;
      private String edtBR_Diagnosis_DXID_Jsonclick ;
      private String divUnnamedtablebr_diagnosis_dxcode_Internalname ;
      private String lblTextblockbr_diagnosis_dxcode_Internalname ;
      private String lblTextblockbr_diagnosis_dxcode_Jsonclick ;
      private String edtBR_Diagnosis_DXCode_Internalname ;
      private String edtBR_Diagnosis_DXCode_Jsonclick ;
      private String divUnnamedtablebr_diagnosis_dxtype_Internalname ;
      private String lblTextblockbr_diagnosis_dxtype_Internalname ;
      private String lblTextblockbr_diagnosis_dxtype_Jsonclick ;
      private String dynBR_Diagnosis_DXType_Jsonclick ;
      private String divUnnamedtablebr_diagnosis_initialdx_Internalname ;
      private String lblTextblockbr_diagnosis_initialdx_Internalname ;
      private String lblTextblockbr_diagnosis_initialdx_Jsonclick ;
      private String cmbBR_Diagnosis_InitialDX_Jsonclick ;
      private String divUnnamedtablebr_diagnosis_metastasesdx_Internalname ;
      private String lblTextblockbr_diagnosis_metastasesdx_Internalname ;
      private String lblTextblockbr_diagnosis_metastasesdx_Jsonclick ;
      private String cmbBR_Diagnosis_MetastasesDX_Jsonclick ;
      private String divBr_diagnosis_dxsource_cell_Internalname ;
      private String divBr_diagnosis_dxsource_cell_Class ;
      private String divUnnamedtablebr_diagnosis_dxsource_Internalname ;
      private String lblTextblockbr_diagnosis_dxsource_Internalname ;
      private String lblTextblockbr_diagnosis_dxsource_Jsonclick ;
      private String edtBR_Diagnosis_DXSource_Internalname ;
      private String edtBR_Diagnosis_DXSource_Jsonclick ;
      private String edtBR_Diagnosis_TumorStageClinical_Internalname ;
      private String edtBR_Diagnosis_TumorStageClinical_Jsonclick ;
      private String bttBtntrn_enter_Internalname ;
      private String bttBtntrn_enter_Jsonclick ;
      private String bttBtntrn_cancel_Internalname ;
      private String bttBtntrn_cancel_Jsonclick ;
      private String bttBtntrn_delete_Internalname ;
      private String bttBtntrn_delete_Jsonclick ;
      private String divHtml_bottomauxiliarcontrols_Internalname ;
      private String edtBR_DiagnosisID_Internalname ;
      private String edtBR_DiagnosisID_Jsonclick ;
      private String edtBR_EncounterID_Internalname ;
      private String edtBR_EncounterID_Jsonclick ;
      private String edtBR_Information_PatientNo_Internalname ;
      private String edtBR_Information_PatientNo_Jsonclick ;
      private String AV16Pgmname ;
      private String Dvpanel_tableattributes_Objectcall ;
      private String Dvpanel_tableattributes_Class ;
      private String Dvpanel_tableattributes_Height ;
      private String forbiddenHiddens ;
      private String hsh ;
      private String sMode13 ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String sDynURL ;
      private String FormProcess ;
      private String bodyStyle ;
      private String gxwrpcisep ;
      private String GXt_char1 ;
      private bool entryPointCalled ;
      private bool n67BR_Diagnosis_DXType ;
      private bool n68BR_Diagnosis_DXTsource ;
      private bool n70BR_Diagnosis_InitialDX ;
      private bool n71BR_Diagnosis_MetastasesDX ;
      private bool n85BR_Information_ID ;
      private bool toggleJsOutput ;
      private bool wbErr ;
      private bool Dvpanel_tableattributes_Autowidth ;
      private bool Dvpanel_tableattributes_Autoheight ;
      private bool Dvpanel_tableattributes_Collapsible ;
      private bool Dvpanel_tableattributes_Collapsed ;
      private bool Dvpanel_tableattributes_Showcollapseicon ;
      private bool Dvpanel_tableattributes_Autoscroll ;
      private bool n513BR_Diagnosis_No ;
      private bool n69BR_Diagnosis_DXDescription ;
      private bool n65BR_Diagnosis_DXID ;
      private bool n66BR_Diagnosis_DXCode ;
      private bool n260BR_Diagnosis_DXSource ;
      private bool n569BR_Diagnosis_TumorStageClinical ;
      private bool n36BR_Information_PatientNo ;
      private bool n466BR_Diagnosis_DXType_Code ;
      private bool n467BR_Diagnosis_DXTsource_Code ;
      private bool n503BR_Diagnosis_InitialDX_Code ;
      private bool n504BR_Diagnosis_MetastasesDX_Code ;
      private bool Dvpanel_tableattributes_Enabled ;
      private bool Dvpanel_tableattributes_Showheader ;
      private bool Dvpanel_tableattributes_Visible ;
      private bool AV13IsAuthorized ;
      private bool GXt_boolean2 ;
      private bool returnInSub ;
      private bool Gx_longc ;
      private bool gxdyncontrolsrefreshing ;
      private String Z466BR_Diagnosis_DXType_Code ;
      private String Z467BR_Diagnosis_DXTsource_Code ;
      private String Z503BR_Diagnosis_InitialDX_Code ;
      private String Z504BR_Diagnosis_MetastasesDX_Code ;
      private String Z65BR_Diagnosis_DXID ;
      private String Z66BR_Diagnosis_DXCode ;
      private String Z67BR_Diagnosis_DXType ;
      private String Z68BR_Diagnosis_DXTsource ;
      private String Z69BR_Diagnosis_DXDescription ;
      private String Z70BR_Diagnosis_InitialDX ;
      private String Z71BR_Diagnosis_MetastasesDX ;
      private String Z260BR_Diagnosis_DXSource ;
      private String Z569BR_Diagnosis_TumorStageClinical ;
      private String AV15tCurrentCode ;
      private String A67BR_Diagnosis_DXType ;
      private String A68BR_Diagnosis_DXTsource ;
      private String A70BR_Diagnosis_InitialDX ;
      private String A71BR_Diagnosis_MetastasesDX ;
      private String A69BR_Diagnosis_DXDescription ;
      private String A65BR_Diagnosis_DXID ;
      private String A66BR_Diagnosis_DXCode ;
      private String A260BR_Diagnosis_DXSource ;
      private String A569BR_Diagnosis_TumorStageClinical ;
      private String A36BR_Information_PatientNo ;
      private String A466BR_Diagnosis_DXType_Code ;
      private String A467BR_Diagnosis_DXTsource_Code ;
      private String A503BR_Diagnosis_InitialDX_Code ;
      private String A504BR_Diagnosis_MetastasesDX_Code ;
      private String Z36BR_Information_PatientNo ;
      private IGxSession AV9WebSession ;
      private GeneXus.Utils.GxStringCollection gxdynajaxctrlcodr ;
      private GeneXus.Utils.GxStringCollection gxdynajaxctrldescr ;
      private GxUnknownObjectCollection isValidOutput ;
      private GXUserControl ucDvpanel_tableattributes ;
      private IGxDataStore dsDataStore1 ;
      private IGxDataStore dsDefault ;
      private GXCombobox dynBR_Diagnosis_DXTsource ;
      private GXCombobox dynBR_Diagnosis_DXType ;
      private GXCombobox cmbBR_Diagnosis_InitialDX ;
      private GXCombobox cmbBR_Diagnosis_MetastasesDX ;
      private IDataStoreProvider pr_default ;
      private long[] T000C4_A85BR_Information_ID ;
      private bool[] T000C4_n85BR_Information_ID ;
      private String[] T000C5_A36BR_Information_PatientNo ;
      private bool[] T000C5_n36BR_Information_PatientNo ;
      private long[] T000C6_A85BR_Information_ID ;
      private bool[] T000C6_n85BR_Information_ID ;
      private long[] T000C6_A64BR_DiagnosisID ;
      private String[] T000C6_A466BR_Diagnosis_DXType_Code ;
      private bool[] T000C6_n466BR_Diagnosis_DXType_Code ;
      private String[] T000C6_A467BR_Diagnosis_DXTsource_Code ;
      private bool[] T000C6_n467BR_Diagnosis_DXTsource_Code ;
      private String[] T000C6_A503BR_Diagnosis_InitialDX_Code ;
      private bool[] T000C6_n503BR_Diagnosis_InitialDX_Code ;
      private String[] T000C6_A504BR_Diagnosis_MetastasesDX_Code ;
      private bool[] T000C6_n504BR_Diagnosis_MetastasesDX_Code ;
      private String[] T000C6_A36BR_Information_PatientNo ;
      private bool[] T000C6_n36BR_Information_PatientNo ;
      private long[] T000C6_A513BR_Diagnosis_No ;
      private bool[] T000C6_n513BR_Diagnosis_No ;
      private String[] T000C6_A65BR_Diagnosis_DXID ;
      private bool[] T000C6_n65BR_Diagnosis_DXID ;
      private String[] T000C6_A66BR_Diagnosis_DXCode ;
      private bool[] T000C6_n66BR_Diagnosis_DXCode ;
      private String[] T000C6_A67BR_Diagnosis_DXType ;
      private bool[] T000C6_n67BR_Diagnosis_DXType ;
      private String[] T000C6_A68BR_Diagnosis_DXTsource ;
      private bool[] T000C6_n68BR_Diagnosis_DXTsource ;
      private String[] T000C6_A69BR_Diagnosis_DXDescription ;
      private bool[] T000C6_n69BR_Diagnosis_DXDescription ;
      private String[] T000C6_A70BR_Diagnosis_InitialDX ;
      private bool[] T000C6_n70BR_Diagnosis_InitialDX ;
      private String[] T000C6_A71BR_Diagnosis_MetastasesDX ;
      private bool[] T000C6_n71BR_Diagnosis_MetastasesDX ;
      private String[] T000C6_A260BR_Diagnosis_DXSource ;
      private bool[] T000C6_n260BR_Diagnosis_DXSource ;
      private String[] T000C6_A569BR_Diagnosis_TumorStageClinical ;
      private bool[] T000C6_n569BR_Diagnosis_TumorStageClinical ;
      private long[] T000C6_A19BR_EncounterID ;
      private long[] T000C7_A85BR_Information_ID ;
      private bool[] T000C7_n85BR_Information_ID ;
      private String[] T000C8_A36BR_Information_PatientNo ;
      private bool[] T000C8_n36BR_Information_PatientNo ;
      private long[] T000C9_A64BR_DiagnosisID ;
      private long[] T000C3_A64BR_DiagnosisID ;
      private String[] T000C3_A466BR_Diagnosis_DXType_Code ;
      private bool[] T000C3_n466BR_Diagnosis_DXType_Code ;
      private String[] T000C3_A467BR_Diagnosis_DXTsource_Code ;
      private bool[] T000C3_n467BR_Diagnosis_DXTsource_Code ;
      private String[] T000C3_A503BR_Diagnosis_InitialDX_Code ;
      private bool[] T000C3_n503BR_Diagnosis_InitialDX_Code ;
      private String[] T000C3_A504BR_Diagnosis_MetastasesDX_Code ;
      private bool[] T000C3_n504BR_Diagnosis_MetastasesDX_Code ;
      private long[] T000C3_A513BR_Diagnosis_No ;
      private bool[] T000C3_n513BR_Diagnosis_No ;
      private String[] T000C3_A65BR_Diagnosis_DXID ;
      private bool[] T000C3_n65BR_Diagnosis_DXID ;
      private String[] T000C3_A66BR_Diagnosis_DXCode ;
      private bool[] T000C3_n66BR_Diagnosis_DXCode ;
      private String[] T000C3_A67BR_Diagnosis_DXType ;
      private bool[] T000C3_n67BR_Diagnosis_DXType ;
      private String[] T000C3_A68BR_Diagnosis_DXTsource ;
      private bool[] T000C3_n68BR_Diagnosis_DXTsource ;
      private String[] T000C3_A69BR_Diagnosis_DXDescription ;
      private bool[] T000C3_n69BR_Diagnosis_DXDescription ;
      private String[] T000C3_A70BR_Diagnosis_InitialDX ;
      private bool[] T000C3_n70BR_Diagnosis_InitialDX ;
      private String[] T000C3_A71BR_Diagnosis_MetastasesDX ;
      private bool[] T000C3_n71BR_Diagnosis_MetastasesDX ;
      private String[] T000C3_A260BR_Diagnosis_DXSource ;
      private bool[] T000C3_n260BR_Diagnosis_DXSource ;
      private String[] T000C3_A569BR_Diagnosis_TumorStageClinical ;
      private bool[] T000C3_n569BR_Diagnosis_TumorStageClinical ;
      private long[] T000C3_A19BR_EncounterID ;
      private long[] T000C10_A64BR_DiagnosisID ;
      private long[] T000C11_A64BR_DiagnosisID ;
      private long[] T000C2_A64BR_DiagnosisID ;
      private String[] T000C2_A466BR_Diagnosis_DXType_Code ;
      private bool[] T000C2_n466BR_Diagnosis_DXType_Code ;
      private String[] T000C2_A467BR_Diagnosis_DXTsource_Code ;
      private bool[] T000C2_n467BR_Diagnosis_DXTsource_Code ;
      private String[] T000C2_A503BR_Diagnosis_InitialDX_Code ;
      private bool[] T000C2_n503BR_Diagnosis_InitialDX_Code ;
      private String[] T000C2_A504BR_Diagnosis_MetastasesDX_Code ;
      private bool[] T000C2_n504BR_Diagnosis_MetastasesDX_Code ;
      private long[] T000C2_A513BR_Diagnosis_No ;
      private bool[] T000C2_n513BR_Diagnosis_No ;
      private String[] T000C2_A65BR_Diagnosis_DXID ;
      private bool[] T000C2_n65BR_Diagnosis_DXID ;
      private String[] T000C2_A66BR_Diagnosis_DXCode ;
      private bool[] T000C2_n66BR_Diagnosis_DXCode ;
      private String[] T000C2_A67BR_Diagnosis_DXType ;
      private bool[] T000C2_n67BR_Diagnosis_DXType ;
      private String[] T000C2_A68BR_Diagnosis_DXTsource ;
      private bool[] T000C2_n68BR_Diagnosis_DXTsource ;
      private String[] T000C2_A69BR_Diagnosis_DXDescription ;
      private bool[] T000C2_n69BR_Diagnosis_DXDescription ;
      private String[] T000C2_A70BR_Diagnosis_InitialDX ;
      private bool[] T000C2_n70BR_Diagnosis_InitialDX ;
      private String[] T000C2_A71BR_Diagnosis_MetastasesDX ;
      private bool[] T000C2_n71BR_Diagnosis_MetastasesDX ;
      private String[] T000C2_A260BR_Diagnosis_DXSource ;
      private bool[] T000C2_n260BR_Diagnosis_DXSource ;
      private String[] T000C2_A569BR_Diagnosis_TumorStageClinical ;
      private bool[] T000C2_n569BR_Diagnosis_TumorStageClinical ;
      private long[] T000C2_A19BR_EncounterID ;
      private long[] T000C12_A64BR_DiagnosisID ;
      private long[] T000C15_A85BR_Information_ID ;
      private bool[] T000C15_n85BR_Information_ID ;
      private String[] T000C16_A36BR_Information_PatientNo ;
      private bool[] T000C16_n36BR_Information_PatientNo ;
      private long[] T000C17_A64BR_DiagnosisID ;
      private long[] T000C18_A167XT_DefineCodeID ;
      private String[] T000C18_A168XT_DefineCodeName ;
      private bool[] T000C18_n168XT_DefineCodeName ;
      private long[] T000C18_A165XT_DefindcodeTypeID ;
      private String[] T000C18_A432XT_TenantCode ;
      private bool[] T000C18_n432XT_TenantCode ;
      private long[] T000C19_A167XT_DefineCodeID ;
      private String[] T000C19_A168XT_DefineCodeName ;
      private bool[] T000C19_n168XT_DefineCodeName ;
      private long[] T000C19_A165XT_DefindcodeTypeID ;
      private String[] T000C19_A432XT_TenantCode ;
      private bool[] T000C19_n432XT_TenantCode ;
      private long[] T000C20_A85BR_Information_ID ;
      private bool[] T000C20_n85BR_Information_ID ;
      private String[] T000C21_A36BR_Information_PatientNo ;
      private bool[] T000C21_n36BR_Information_PatientNo ;
      private IDataStoreProvider pr_datastore1 ;
      private GXWebForm Form ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPContext AV7WWPContext ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext AV8TrnContext ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext_Attribute AV11TrnContextAtt ;
   }

   public class br_diagnosis__datastore1 : DataStoreHelperBase, IDataStoreHelper
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

 public class br_diagnosis__default : DataStoreHelperBase, IDataStoreHelper
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
     };
  }

  private static CursorDef[] def;
  private void cursorDefinitions( )
  {
     if ( def == null )
     {
        Object[] prmT000C6 ;
        prmT000C6 = new Object[] {
        new Object[] {"@BR_DiagnosisID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000C4 ;
        prmT000C4 = new Object[] {
        new Object[] {"@BR_EncounterID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000C5 ;
        prmT000C5 = new Object[] {
        new Object[] {"@BR_Information_ID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000C7 ;
        prmT000C7 = new Object[] {
        new Object[] {"@BR_EncounterID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000C8 ;
        prmT000C8 = new Object[] {
        new Object[] {"@BR_Information_ID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000C9 ;
        prmT000C9 = new Object[] {
        new Object[] {"@BR_DiagnosisID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000C3 ;
        prmT000C3 = new Object[] {
        new Object[] {"@BR_DiagnosisID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000C10 ;
        prmT000C10 = new Object[] {
        new Object[] {"@BR_DiagnosisID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000C11 ;
        prmT000C11 = new Object[] {
        new Object[] {"@BR_DiagnosisID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000C2 ;
        prmT000C2 = new Object[] {
        new Object[] {"@BR_DiagnosisID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000C12 ;
        prmT000C12 = new Object[] {
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
        Object[] prmT000C13 ;
        prmT000C13 = new Object[] {
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
        Object[] prmT000C14 ;
        prmT000C14 = new Object[] {
        new Object[] {"@BR_DiagnosisID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000C15 ;
        prmT000C15 = new Object[] {
        new Object[] {"@BR_EncounterID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000C16 ;
        prmT000C16 = new Object[] {
        new Object[] {"@BR_Information_ID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000C17 ;
        prmT000C17 = new Object[] {
        } ;
        Object[] prmT000C18 ;
        prmT000C18 = new Object[] {
        new Object[] {"@AV15tCurrentCode",SqlDbType.NVarChar,40,0}
        } ;
        Object[] prmT000C19 ;
        prmT000C19 = new Object[] {
        new Object[] {"@AV15tCurrentCode",SqlDbType.NVarChar,40,0}
        } ;
        Object[] prmT000C20 ;
        prmT000C20 = new Object[] {
        new Object[] {"@BR_EncounterID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000C21 ;
        prmT000C21 = new Object[] {
        new Object[] {"@BR_Information_ID",SqlDbType.Decimal,18,0}
        } ;
        def= new CursorDef[] {
            new CursorDef("T000C2", "SELECT [BR_DiagnosisID], [BR_Diagnosis_DXType_Code], [BR_Diagnosis_DXTsource_Code], [BR_Diagnosis_InitialDX_Code], [BR_Diagnosis_MetastasesDX_Code], [BR_Diagnosis_No], [BR_Diagnosis_DXID], [BR_Diagnosis_DXCode], [BR_Diagnosis_DXType], [BR_Diagnosis_DXTsource], [BR_Diagnosis_DXDescription], [BR_Diagnosis_InitialDX], [BR_Diagnosis_MetastasesDX], [BR_Diagnosis_DXSource], [BR_Diagnosis_TumorStageClinical], [BR_EncounterID] FROM [BR_Diagnosis] WITH (UPDLOCK) WHERE [BR_DiagnosisID] = @BR_DiagnosisID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000C2,1,0,true,false )
           ,new CursorDef("T000C3", "SELECT [BR_DiagnosisID], [BR_Diagnosis_DXType_Code], [BR_Diagnosis_DXTsource_Code], [BR_Diagnosis_InitialDX_Code], [BR_Diagnosis_MetastasesDX_Code], [BR_Diagnosis_No], [BR_Diagnosis_DXID], [BR_Diagnosis_DXCode], [BR_Diagnosis_DXType], [BR_Diagnosis_DXTsource], [BR_Diagnosis_DXDescription], [BR_Diagnosis_InitialDX], [BR_Diagnosis_MetastasesDX], [BR_Diagnosis_DXSource], [BR_Diagnosis_TumorStageClinical], [BR_EncounterID] FROM [BR_Diagnosis] WITH (NOLOCK) WHERE [BR_DiagnosisID] = @BR_DiagnosisID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000C3,1,0,true,false )
           ,new CursorDef("T000C4", "SELECT [BR_Information_ID] FROM [BR_Encounter] WITH (NOLOCK) WHERE [BR_EncounterID] = @BR_EncounterID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000C4,1,0,true,false )
           ,new CursorDef("T000C5", "SELECT [BR_Information_PatientNo] FROM [BR_Information] WITH (NOLOCK) WHERE [BR_Information_ID] = @BR_Information_ID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000C5,1,0,true,false )
           ,new CursorDef("T000C6", "SELECT T2.[BR_Information_ID], TM1.[BR_DiagnosisID], TM1.[BR_Diagnosis_DXType_Code], TM1.[BR_Diagnosis_DXTsource_Code], TM1.[BR_Diagnosis_InitialDX_Code], TM1.[BR_Diagnosis_MetastasesDX_Code], T3.[BR_Information_PatientNo], TM1.[BR_Diagnosis_No], TM1.[BR_Diagnosis_DXID], TM1.[BR_Diagnosis_DXCode], TM1.[BR_Diagnosis_DXType], TM1.[BR_Diagnosis_DXTsource], TM1.[BR_Diagnosis_DXDescription], TM1.[BR_Diagnosis_InitialDX], TM1.[BR_Diagnosis_MetastasesDX], TM1.[BR_Diagnosis_DXSource], TM1.[BR_Diagnosis_TumorStageClinical], TM1.[BR_EncounterID] FROM (([BR_Diagnosis] TM1 WITH (NOLOCK) INNER JOIN [BR_Encounter] T2 WITH (NOLOCK) ON T2.[BR_EncounterID] = TM1.[BR_EncounterID]) LEFT JOIN [BR_Information] T3 WITH (NOLOCK) ON T3.[BR_Information_ID] = T2.[BR_Information_ID]) WHERE TM1.[BR_DiagnosisID] = @BR_DiagnosisID ORDER BY TM1.[BR_DiagnosisID]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT000C6,100,0,true,false )
           ,new CursorDef("T000C7", "SELECT [BR_Information_ID] FROM [BR_Encounter] WITH (NOLOCK) WHERE [BR_EncounterID] = @BR_EncounterID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000C7,1,0,true,false )
           ,new CursorDef("T000C8", "SELECT [BR_Information_PatientNo] FROM [BR_Information] WITH (NOLOCK) WHERE [BR_Information_ID] = @BR_Information_ID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000C8,1,0,true,false )
           ,new CursorDef("T000C9", "SELECT [BR_DiagnosisID] FROM [BR_Diagnosis] WITH (NOLOCK) WHERE [BR_DiagnosisID] = @BR_DiagnosisID  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000C9,1,0,true,false )
           ,new CursorDef("T000C10", "SELECT TOP 1 [BR_DiagnosisID] FROM [BR_Diagnosis] WITH (NOLOCK) WHERE ( [BR_DiagnosisID] > @BR_DiagnosisID) ORDER BY [BR_DiagnosisID]  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000C10,1,0,true,true )
           ,new CursorDef("T000C11", "SELECT TOP 1 [BR_DiagnosisID] FROM [BR_Diagnosis] WITH (NOLOCK) WHERE ( [BR_DiagnosisID] < @BR_DiagnosisID) ORDER BY [BR_DiagnosisID] DESC  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000C11,1,0,true,true )
           ,new CursorDef("T000C12", "INSERT INTO [BR_Diagnosis]([BR_Diagnosis_DXType_Code], [BR_Diagnosis_DXTsource_Code], [BR_Diagnosis_InitialDX_Code], [BR_Diagnosis_MetastasesDX_Code], [BR_Diagnosis_No], [BR_Diagnosis_DXID], [BR_Diagnosis_DXCode], [BR_Diagnosis_DXType], [BR_Diagnosis_DXTsource], [BR_Diagnosis_DXDescription], [BR_Diagnosis_InitialDX], [BR_Diagnosis_MetastasesDX], [BR_Diagnosis_DXSource], [BR_Diagnosis_TumorStageClinical], [BR_EncounterID]) VALUES(@BR_Diagnosis_DXType_Code, @BR_Diagnosis_DXTsource_Code, @BR_Diagnosis_InitialDX_Code, @BR_Diagnosis_MetastasesDX_Code, @BR_Diagnosis_No, @BR_Diagnosis_DXID, @BR_Diagnosis_DXCode, @BR_Diagnosis_DXType, @BR_Diagnosis_DXTsource, @BR_Diagnosis_DXDescription, @BR_Diagnosis_InitialDX, @BR_Diagnosis_MetastasesDX, @BR_Diagnosis_DXSource, @BR_Diagnosis_TumorStageClinical, @BR_EncounterID); SELECT SCOPE_IDENTITY()", GxErrorMask.GX_NOMASK,prmT000C12)
           ,new CursorDef("T000C13", "UPDATE [BR_Diagnosis] SET [BR_Diagnosis_DXType_Code]=@BR_Diagnosis_DXType_Code, [BR_Diagnosis_DXTsource_Code]=@BR_Diagnosis_DXTsource_Code, [BR_Diagnosis_InitialDX_Code]=@BR_Diagnosis_InitialDX_Code, [BR_Diagnosis_MetastasesDX_Code]=@BR_Diagnosis_MetastasesDX_Code, [BR_Diagnosis_No]=@BR_Diagnosis_No, [BR_Diagnosis_DXID]=@BR_Diagnosis_DXID, [BR_Diagnosis_DXCode]=@BR_Diagnosis_DXCode, [BR_Diagnosis_DXType]=@BR_Diagnosis_DXType, [BR_Diagnosis_DXTsource]=@BR_Diagnosis_DXTsource, [BR_Diagnosis_DXDescription]=@BR_Diagnosis_DXDescription, [BR_Diagnosis_InitialDX]=@BR_Diagnosis_InitialDX, [BR_Diagnosis_MetastasesDX]=@BR_Diagnosis_MetastasesDX, [BR_Diagnosis_DXSource]=@BR_Diagnosis_DXSource, [BR_Diagnosis_TumorStageClinical]=@BR_Diagnosis_TumorStageClinical, [BR_EncounterID]=@BR_EncounterID  WHERE [BR_DiagnosisID] = @BR_DiagnosisID", GxErrorMask.GX_NOMASK,prmT000C13)
           ,new CursorDef("T000C14", "DELETE FROM [BR_Diagnosis]  WHERE [BR_DiagnosisID] = @BR_DiagnosisID", GxErrorMask.GX_NOMASK,prmT000C14)
           ,new CursorDef("T000C15", "SELECT [BR_Information_ID] FROM [BR_Encounter] WITH (NOLOCK) WHERE [BR_EncounterID] = @BR_EncounterID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000C15,1,0,true,false )
           ,new CursorDef("T000C16", "SELECT [BR_Information_PatientNo] FROM [BR_Information] WITH (NOLOCK) WHERE [BR_Information_ID] = @BR_Information_ID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000C16,1,0,true,false )
           ,new CursorDef("T000C17", "SELECT [BR_DiagnosisID] FROM [BR_Diagnosis] WITH (NOLOCK) ORDER BY [BR_DiagnosisID]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT000C17,100,0,true,false )
           ,new CursorDef("T000C18", "SELECT [XT_DefineCodeID], [XT_DefineCodeName], [XT_DefindcodeTypeID], [XT_TenantCode] FROM [XT_DefineCode] WITH (NOLOCK) WHERE ([XT_DefindcodeTypeID] = 21) AND ([XT_TenantCode] = @AV15tCurrentCode) ",true, GxErrorMask.GX_NOMASK, false, this,prmT000C18,0,0,true,false )
           ,new CursorDef("T000C19", "SELECT [XT_DefineCodeID], [XT_DefineCodeName], [XT_DefindcodeTypeID], [XT_TenantCode] FROM [XT_DefineCode] WITH (NOLOCK) WHERE ([XT_DefindcodeTypeID] = 20) AND ([XT_TenantCode] = @AV15tCurrentCode) ",true, GxErrorMask.GX_NOMASK, false, this,prmT000C19,0,0,true,false )
           ,new CursorDef("T000C20", "SELECT [BR_Information_ID] FROM [BR_Encounter] WITH (NOLOCK) WHERE [BR_EncounterID] = @BR_EncounterID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000C20,1,0,true,false )
           ,new CursorDef("T000C21", "SELECT [BR_Information_PatientNo] FROM [BR_Information] WITH (NOLOCK) WHERE [BR_Information_ID] = @BR_Information_ID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000C21,1,0,true,false )
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
           case 16 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
              ((bool[]) buf[2])[0] = rslt.wasNull(2);
              ((long[]) buf[3])[0] = rslt.getLong(3) ;
              ((String[]) buf[4])[0] = rslt.getVarchar(4) ;
              ((bool[]) buf[5])[0] = rslt.wasNull(4);
              return;
           case 17 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
              ((bool[]) buf[2])[0] = rslt.wasNull(2);
              ((long[]) buf[3])[0] = rslt.getLong(3) ;
              ((String[]) buf[4])[0] = rslt.getVarchar(4) ;
              ((bool[]) buf[5])[0] = rslt.wasNull(4);
              return;
           case 18 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              ((bool[]) buf[1])[0] = rslt.wasNull(1);
              return;
           case 19 :
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
           case 16 :
              stmt.SetParameter(1, (String)parms[0]);
              return;
           case 17 :
              stmt.SetParameter(1, (String)parms[0]);
              return;
           case 18 :
              stmt.SetParameter(1, (long)parms[0]);
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
     }
  }

}

}
