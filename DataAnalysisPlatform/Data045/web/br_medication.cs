/*
               File: BR_Medication
        Description: Data Mgmt Portal - RAAP
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/28/2020 15:7:14.57
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
   public class br_medication : GXDataArea, System.Web.SessionState.IRequiresSessionState
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
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxJX_Action35") == 0 )
         {
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            XC_35_0H18( ) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxCallCrl"+"_"+"BR_MEDICATION_RXNAME") == 0 )
         {
            AV21tCurrentCode = GetNextPar( );
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV21tCurrentCode", AV21tCurrentCode);
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            GXDLABR_MEDICATION_RXNAME0H18( AV21tCurrentCode) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxCallCrl"+"_"+"BR_MEDICATION_RXFREQUENCY") == 0 )
         {
            AV21tCurrentCode = GetNextPar( );
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV21tCurrentCode", AV21tCurrentCode);
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            GXDLABR_MEDICATION_RXFREQUENCY0H18( AV21tCurrentCode) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxCallCrl"+"_"+"BR_MEDICATION_RXROUTE") == 0 )
         {
            AV21tCurrentCode = GetNextPar( );
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV21tCurrentCode", AV21tCurrentCode);
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            GXDLABR_MEDICATION_RXROUTE0H18( AV21tCurrentCode) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxAggSel17"+"_"+"BR_MEDICATION_RXFREQUENCY_CODE") == 0 )
         {
            A126BR_Medication_RXFrequency = GetNextPar( );
            n126BR_Medication_RXFrequency = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A126BR_Medication_RXFrequency", A126BR_Medication_RXFrequency);
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            GX17ASABR_MEDICATION_RXFREQUENCY_CODE0H18( A126BR_Medication_RXFrequency) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxAggSel18"+"_"+"BR_MEDICATION_RXFREQUENCY_CODE") == 0 )
         {
            A126BR_Medication_RXFrequency = GetNextPar( );
            n126BR_Medication_RXFrequency = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A126BR_Medication_RXFrequency", A126BR_Medication_RXFrequency);
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            GX18ASABR_MEDICATION_RXFREQUENCY_CODE0H18( A126BR_Medication_RXFrequency) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxAggSel19"+"_"+"BR_MEDICATION_RXROUTE_CODE") == 0 )
         {
            A129BR_Medication_RXRoute = GetNextPar( );
            n129BR_Medication_RXRoute = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A129BR_Medication_RXRoute", A129BR_Medication_RXRoute);
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            GX19ASABR_MEDICATION_RXROUTE_CODE0H18( A129BR_Medication_RXRoute) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxAggSel20"+"_"+"BR_MEDICATION_RXROUTE_CODE") == 0 )
         {
            A129BR_Medication_RXRoute = GetNextPar( );
            n129BR_Medication_RXRoute = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A129BR_Medication_RXRoute", A129BR_Medication_RXRoute);
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            GX20ASABR_MEDICATION_RXROUTE_CODE0H18( A129BR_Medication_RXRoute) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxAggSel21"+"_"+"BR_MEDICATION_INPATIENTCHEMO_CODE") == 0 )
         {
            A131BR_Medication_InpatientChemo = GetNextPar( );
            n131BR_Medication_InpatientChemo = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A131BR_Medication_InpatientChemo", A131BR_Medication_InpatientChemo);
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            GX21ASABR_MEDICATION_INPATIENTCHEMO_CODE0H18( A131BR_Medication_InpatientChemo) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxAggSel22"+"_"+"BR_MEDICATION_INPATIENTCHEMO_CODE") == 0 )
         {
            A131BR_Medication_InpatientChemo = GetNextPar( );
            n131BR_Medication_InpatientChemo = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A131BR_Medication_InpatientChemo", A131BR_Medication_InpatientChemo);
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            GX22ASABR_MEDICATION_INPATIENTCHEMO_CODE0H18( A131BR_Medication_InpatientChemo) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxExecAct_"+"gxLoad_37") == 0 )
         {
            A19BR_EncounterID = (long)(NumberUtil.Val( GetNextPar( ), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A19BR_EncounterID", StringUtil.LTrim( StringUtil.Str( (decimal)(A19BR_EncounterID), 18, 0)));
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            gxLoad_37( A19BR_EncounterID) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxExecAct_"+"gxLoad_38") == 0 )
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
            gxLoad_38( A85BR_Information_ID) ;
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
               AV12BR_MedicationID = (long)(NumberUtil.Val( GetNextPar( ), "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12BR_MedicationID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV12BR_MedicationID), 18, 0)));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vBR_MEDICATIONID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV12BR_MedicationID), "ZZZZZZZZZZZZZZZZZZ"), context));
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
         GX_FocusControl = dynBR_Medication_RXName_Internalname;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         wbErr = false;
         context.SetDefaultTheme("WorkWithPlusTheme");
         if ( ! context.IsLocalStorageSupported( ) )
         {
            context.PushCurrentUrl();
         }
      }

      public br_medication( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public br_medication( IGxContext context )
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
                           long aP1_BR_MedicationID )
      {
         this.Gx_mode = aP0_Gx_mode;
         this.AV12BR_MedicationID = aP1_BR_MedicationID;
         executePrivate();
      }

      void executePrivate( )
      {
         isStatic = false;
         webExecute();
      }

      protected override void createObjects( )
      {
         dynBR_Medication_RXName = new GXCombobox();
         dynBR_Medication_RXFrequency = new GXCombobox();
         dynBR_Medication_RXRoute = new GXCombobox();
         cmbBR_Medication_InpatientChemo = new GXCombobox();
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
         if ( dynBR_Medication_RXName.ItemCount > 0 )
         {
            A121BR_Medication_RXName = dynBR_Medication_RXName.getValidValue(A121BR_Medication_RXName);
            n121BR_Medication_RXName = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A121BR_Medication_RXName", A121BR_Medication_RXName);
         }
         if ( context.isAjaxRequest( ) )
         {
            dynBR_Medication_RXName.CurrentValue = StringUtil.RTrim( A121BR_Medication_RXName);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynBR_Medication_RXName_Internalname, "Values", dynBR_Medication_RXName.ToJavascriptSource(), true);
         }
         if ( dynBR_Medication_RXFrequency.ItemCount > 0 )
         {
            A126BR_Medication_RXFrequency = dynBR_Medication_RXFrequency.getValidValue(A126BR_Medication_RXFrequency);
            n126BR_Medication_RXFrequency = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A126BR_Medication_RXFrequency", A126BR_Medication_RXFrequency);
         }
         if ( context.isAjaxRequest( ) )
         {
            dynBR_Medication_RXFrequency.CurrentValue = StringUtil.RTrim( A126BR_Medication_RXFrequency);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynBR_Medication_RXFrequency_Internalname, "Values", dynBR_Medication_RXFrequency.ToJavascriptSource(), true);
         }
         if ( dynBR_Medication_RXRoute.ItemCount > 0 )
         {
            A129BR_Medication_RXRoute = dynBR_Medication_RXRoute.getValidValue(A129BR_Medication_RXRoute);
            n129BR_Medication_RXRoute = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A129BR_Medication_RXRoute", A129BR_Medication_RXRoute);
         }
         if ( context.isAjaxRequest( ) )
         {
            dynBR_Medication_RXRoute.CurrentValue = StringUtil.RTrim( A129BR_Medication_RXRoute);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynBR_Medication_RXRoute_Internalname, "Values", dynBR_Medication_RXRoute.ToJavascriptSource(), true);
         }
         if ( cmbBR_Medication_InpatientChemo.ItemCount > 0 )
         {
            A131BR_Medication_InpatientChemo = cmbBR_Medication_InpatientChemo.getValidValue(A131BR_Medication_InpatientChemo);
            n131BR_Medication_InpatientChemo = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A131BR_Medication_InpatientChemo", A131BR_Medication_InpatientChemo);
         }
         if ( context.isAjaxRequest( ) )
         {
            cmbBR_Medication_InpatientChemo.CurrentValue = StringUtil.RTrim( A131BR_Medication_InpatientChemo);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbBR_Medication_InpatientChemo_Internalname, "Values", cmbBR_Medication_InpatientChemo.ToJavascriptSource(), true);
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
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 RequiredDataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divTablesplittedbr_medication_rxname_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-3 MergeLabelCell", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblockbr_medication_rxname_Internalname, "药物名称", "", "", lblTextblockbr_medication_rxname_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_BR_Medication.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-9", "left", "top", "", "", "div");
            wb_table1_28_0H18( true) ;
         }
         return  ;
      }

      protected void wb_table1_28_0H18e( bool wbgen )
      {
         if ( wbgen )
         {
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtBR_Medication_RXCode_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtBR_Medication_RXCode_Internalname, "药物代码", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 39,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtBR_Medication_RXCode_Internalname, A122BR_Medication_RXCode, StringUtil.RTrim( context.localUtil.Format( A122BR_Medication_RXCode, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,39);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBR_Medication_RXCode_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtBR_Medication_RXCode_Enabled, 0, "text", "", 40, "chr", 1, "row", 40, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_BR_Medication.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtBR_Medication_RXType_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtBR_Medication_RXType_Internalname, "药物类别", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 44,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtBR_Medication_RXType_Internalname, A123BR_Medication_RXType, StringUtil.RTrim( context.localUtil.Format( A123BR_Medication_RXType, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,44);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBR_Medication_RXType_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtBR_Medication_RXType_Enabled, 0, "text", "", 40, "chr", 1, "row", 40, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_BR_Medication.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtBR_Medication_RXDose_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtBR_Medication_RXDose_Internalname, "药物剂量", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 48,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtBR_Medication_RXDose_Internalname, StringUtil.LTrim( StringUtil.NToC( A124BR_Medication_RXDose, 15, 5, ".", "")), ((edtBR_Medication_RXDose_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( A124BR_Medication_RXDose, "ZZZZZZZZZ.ZZ")) : context.localUtil.Format( A124BR_Medication_RXDose, "ZZZZZZZZZ.ZZ")), TempTags+" onchange=\""+"gx.num.valid_decimal( this, ',','.','5');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,48);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBR_Medication_RXDose_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtBR_Medication_RXDose_Enabled, 0, "text", "", 15, "chr", 1, "row", 15, 0, 0, 0, 1, -1, 0, true, "DM_Numeric", "right", false, "HLP_BR_Medication.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtBR_Medication_RXUnit_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtBR_Medication_RXUnit_Internalname, "计量单位", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 53,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtBR_Medication_RXUnit_Internalname, A125BR_Medication_RXUnit, StringUtil.RTrim( context.localUtil.Format( A125BR_Medication_RXUnit, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,53);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBR_Medication_RXUnit_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtBR_Medication_RXUnit_Enabled, 0, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_BR_Medication.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divTablesplittedbr_medication_rxfrequency_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-3 MergeLabelCell", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblockbr_medication_rxfrequency_Internalname, "服药频率", "", "", lblTextblockbr_medication_rxfrequency_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_BR_Medication.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-9", "left", "top", "", "", "div");
            wb_table2_60_0H18( true) ;
         }
         return  ;
      }

      protected void wb_table2_60_0H18e( bool wbgen )
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
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtBR_Medication_RXQuantity_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtBR_Medication_RXQuantity_Internalname, "用药量", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 72,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtBR_Medication_RXQuantity_Internalname, A127BR_Medication_RXQuantity, StringUtil.RTrim( context.localUtil.Format( A127BR_Medication_RXQuantity, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,72);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBR_Medication_RXQuantity_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtBR_Medication_RXQuantity_Enabled, 0, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_BR_Medication.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtBR_Medication_RXDaysSupply_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtBR_Medication_RXDaysSupply_Internalname, "服药天数", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 76,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtBR_Medication_RXDaysSupply_Internalname, StringUtil.LTrim( StringUtil.NToC( A128BR_Medication_RXDaysSupply, 15, 5, ".", "")), ((edtBR_Medication_RXDaysSupply_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( A128BR_Medication_RXDaysSupply, "ZZZZZZZZZ.ZZZZZ")) : context.localUtil.Format( A128BR_Medication_RXDaysSupply, "ZZZZZZZZZ.ZZZZZ")), TempTags+" onchange=\""+"gx.num.valid_decimal( this, ',','.','5');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,76);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBR_Medication_RXDaysSupply_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtBR_Medication_RXDaysSupply_Enabled, 0, "text", "", 15, "chr", 1, "row", 15, 0, 0, 0, 1, -1, 0, true, "DM_Numeric", "right", false, "HLP_BR_Medication.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divTablesplittedbr_medication_rxroute_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-3 MergeLabelCell", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblockbr_medication_rxroute_Internalname, "给药途径", "", "", lblTextblockbr_medication_rxroute_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_BR_Medication.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-9", "left", "top", "", "", "div");
            wb_table3_84_0H18( true) ;
         }
         return  ;
      }

      protected void wb_table3_84_0H18e( bool wbgen )
      {
         if ( wbgen )
         {
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtBR_Medication_PrescriptionDate_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtBR_Medication_PrescriptionDate_Internalname, "处方日期", "col-sm-3 AttributeDateLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 95,'',false,'',0)\"";
            context.WriteHtmlText( "<div id=\""+edtBR_Medication_PrescriptionDate_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtBR_Medication_PrescriptionDate_Internalname, context.localUtil.Format(A130BR_Medication_PrescriptionDate, "9999/99/99"), context.localUtil.Format( A130BR_Medication_PrescriptionDate, "9999/99/99"), TempTags+" onchange=\""+"gx.date.valid_date(this, 10,'YMD',0,24,'chs',false,1);"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,95);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBR_Medication_PrescriptionDate_Jsonclick, 0, "AttributeDate", "", "", "", "", 1, edtBR_Medication_PrescriptionDate_Enabled, 0, "text", "", 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, 0, true, "DM_Date", "right", false, "HLP_BR_Medication.htm");
            GxWebStd.gx_bitmap( context, edtBR_Medication_PrescriptionDate_Internalname+"_dp_trigger", context.GetImagePath( "61b9b5d3-dff6-4d59-9b00-da61bc2cbe93", "", context.GetTheme( )), "", "", "", "", ((1==0)||(edtBR_Medication_PrescriptionDate_Enabled==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;", "", "", "", "", "", "", "", "", 1, false, false, "", "HLP_BR_Medication.htm");
            context.WriteHtmlTextNl( "</div>") ;
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 RequiredDataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtBR_Medication_AdmitStartDate_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtBR_Medication_AdmitStartDate_Internalname, "服药日期", "col-sm-3 AttributeDateLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 100,'',false,'',0)\"";
            context.WriteHtmlText( "<div id=\""+edtBR_Medication_AdmitStartDate_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtBR_Medication_AdmitStartDate_Internalname, context.localUtil.Format(A132BR_Medication_AdmitStartDate, "9999/99/99"), context.localUtil.Format( A132BR_Medication_AdmitStartDate, "9999/99/99"), TempTags+" onchange=\""+"gx.date.valid_date(this, 10,'YMD',0,24,'chs',false,1);"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,100);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBR_Medication_AdmitStartDate_Jsonclick, 0, "AttributeDate", "", "", "", "", 1, edtBR_Medication_AdmitStartDate_Enabled, 0, "text", "", 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, 0, true, "DM_Date", "right", false, "HLP_BR_Medication.htm");
            GxWebStd.gx_bitmap( context, edtBR_Medication_AdmitStartDate_Internalname+"_dp_trigger", context.GetImagePath( "61b9b5d3-dff6-4d59-9b00-da61bc2cbe93", "", context.GetTheme( )), "", "", "", "", ((1==0)||(edtBR_Medication_AdmitStartDate_Enabled==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;", "", "", "", "", "", "", "", "", 1, false, false, "", "HLP_BR_Medication.htm");
            context.WriteHtmlTextNl( "</div>") ;
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtBR_Medication_AdmitEndDate_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtBR_Medication_AdmitEndDate_Internalname, "停药日期", "col-sm-3 AttributeDateLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 104,'',false,'',0)\"";
            context.WriteHtmlText( "<div id=\""+edtBR_Medication_AdmitEndDate_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtBR_Medication_AdmitEndDate_Internalname, context.localUtil.Format(A133BR_Medication_AdmitEndDate, "9999/99/99"), context.localUtil.Format( A133BR_Medication_AdmitEndDate, "9999/99/99"), TempTags+" onchange=\""+"gx.date.valid_date(this, 10,'YMD',0,24,'chs',false,1);"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,104);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBR_Medication_AdmitEndDate_Jsonclick, 0, "AttributeDate", "", "", "", "", 1, edtBR_Medication_AdmitEndDate_Enabled, 0, "text", "", 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, 0, true, "DM_Date", "right", false, "HLP_BR_Medication.htm");
            GxWebStd.gx_bitmap( context, edtBR_Medication_AdmitEndDate_Internalname+"_dp_trigger", context.GetImagePath( "61b9b5d3-dff6-4d59-9b00-da61bc2cbe93", "", context.GetTheme( )), "", "", "", "", ((1==0)||(edtBR_Medication_AdmitEndDate_Enabled==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;", "", "", "", "", "", "", "", "", 1, false, false, "", "HLP_BR_Medication.htm");
            context.WriteHtmlTextNl( "</div>") ;
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+cmbBR_Medication_InpatientChemo_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, cmbBR_Medication_InpatientChemo_Internalname, "是否接受住院化疗", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 109,'',false,'',0)\"";
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, cmbBR_Medication_InpatientChemo, cmbBR_Medication_InpatientChemo_Internalname, StringUtil.RTrim( A131BR_Medication_InpatientChemo), 1, cmbBR_Medication_InpatientChemo_Jsonclick, 0, "'"+""+"'"+",false,"+"'"+""+"'", "svchar", "", 1, cmbBR_Medication_InpatientChemo.Enabled, 0, 0, 0, "em", 0, "", "", "Attribute", "", "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,109);\"", "", true, "HLP_BR_Medication.htm");
            cmbBR_Medication_InpatientChemo.CurrentValue = StringUtil.RTrim( A131BR_Medication_InpatientChemo);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbBR_Medication_InpatientChemo_Internalname, "Values", (String)(cmbBR_Medication_InpatientChemo.ToJavascriptSource()), true);
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
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 114,'',false,'',0)\"";
            ClassString = "ButtonMaterial";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtntrn_enter_Internalname, "", "保存", bttBtntrn_enter_Jsonclick, 5, "确认", "", StyleString, ClassString, bttBtntrn_enter_Visible, bttBtntrn_enter_Enabled, "standard", "'"+""+"'"+",false,"+"'"+"EENTER."+"'", TempTags, "", context.GetButtonType( ), "HLP_BR_Medication.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 116,'',false,'',0)\"";
            ClassString = "ButtonMaterialDefault";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtntrn_cancel_Internalname, "", "取消", bttBtntrn_cancel_Jsonclick, 1, "取消", "", StyleString, ClassString, bttBtntrn_cancel_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ECANCEL."+"'", TempTags, "", context.GetButtonType( ), "HLP_BR_Medication.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 118,'',false,'',0)\"";
            ClassString = "ButtonMaterialDefault";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtntrn_delete_Internalname, "", "删除", bttBtntrn_delete_Jsonclick, 5, "删除", "", StyleString, ClassString, bttBtntrn_delete_Visible, bttBtntrn_delete_Enabled, "standard", "'"+""+"'"+",false,"+"'"+"EDELETE."+"'", TempTags, "", context.GetButtonType( ), "HLP_BR_Medication.htm");
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
            GxWebStd.gx_single_line_edit( context, edtBR_MedicationID_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A119BR_MedicationID), 18, 0, ".", "")), ((edtBR_MedicationID_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A119BR_MedicationID), "ZZZZZZZZZZZZZZZZZZ")) : context.localUtil.Format( (decimal)(A119BR_MedicationID), "ZZZZZZZZZZZZZZZZZZ")), "", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBR_MedicationID_Jsonclick, 0, "Attribute", "", "", "", "", edtBR_MedicationID_Visible, edtBR_MedicationID_Enabled, 0, "number", "1", 18, "chr", 1, "row", 18, 0, 0, 0, 1, -1, 0, true, "ID", "right", false, "HLP_BR_Medication.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 123,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtBR_EncounterID_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A19BR_EncounterID), 18, 0, ".", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(A19BR_EncounterID), "ZZZZZZZZZZZZZZZZZZ")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,123);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBR_EncounterID_Jsonclick, 0, "Attribute", "", "", "", "", edtBR_EncounterID_Visible, edtBR_EncounterID_Enabled, 1, "number", "1", 18, "chr", 1, "row", 18, 0, 0, 0, 1, -1, 0, true, "ID", "right", false, "HLP_BR_Medication.htm");
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtBR_Information_PatientNo_Internalname, A36BR_Information_PatientNo, StringUtil.RTrim( context.localUtil.Format( A36BR_Information_PatientNo, "")), "", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBR_Information_PatientNo_Jsonclick, 0, "Attribute", "", "", "", "", edtBR_Information_PatientNo_Visible, edtBR_Information_PatientNo_Enabled, 0, "text", "", 80, "chr", 1, "row", 2000, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_BR_Medication.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            fix_multi_value_controls( ) ;
         }
         /* Execute Exit event if defined. */
      }

      protected void wb_table3_84_0H18( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "";
            GxWebStd.gx_table_start( context, tblTablemergedbr_medication_rxroute_Internalname, tblTablemergedbr_medication_rxroute_Internalname, "", "TableMerged", 0, "", "", 0, 0, sStyleString, "", "", 0);
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td class='MergeDataCell'>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, dynBR_Medication_RXRoute_Internalname, "给药途径", "col-sm-3 AttributeLabel", 0, true);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 88,'',false,'',0)\"";
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, dynBR_Medication_RXRoute, dynBR_Medication_RXRoute_Internalname, StringUtil.RTrim( A129BR_Medication_RXRoute), 1, dynBR_Medication_RXRoute_Jsonclick, 0, "'"+""+"'"+",false,"+"'"+""+"'", "svchar", "", 1, dynBR_Medication_RXRoute.Enabled, 0, 0, 0, "em", 0, "", "", "Attribute", "", "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,88);\"", "", true, "HLP_BR_Medication.htm");
            dynBR_Medication_RXRoute.CurrentValue = StringUtil.RTrim( A129BR_Medication_RXRoute);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynBR_Medication_RXRoute_Internalname, "Values", (String)(dynBR_Medication_RXRoute.ToJavascriptSource()), true);
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td id=\""+cellVrxroute_cell_Internalname+"\"  class='"+cellVrxroute_cell_Class+"'>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavVrxroute_Internalname, "v RXRoute", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 91,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavVrxroute_Internalname, AV15vRXRoute, StringUtil.RTrim( context.localUtil.Format( AV15vRXRoute, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,91);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "请填写其它给药途径", edtavVrxroute_Jsonclick, 0, "Attribute", "", "", "", "", edtavVrxroute_Visible, edtavVrxroute_Enabled, 0, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_BR_Medication.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table3_84_0H18e( true) ;
         }
         else
         {
            wb_table3_84_0H18e( false) ;
         }
      }

      protected void wb_table2_60_0H18( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "";
            GxWebStd.gx_table_start( context, tblTablemergedbr_medication_rxfrequency_Internalname, tblTablemergedbr_medication_rxfrequency_Internalname, "", "TableMerged", 0, "", "", 0, 0, sStyleString, "", "", 0);
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td class='MergeDataCell'>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, dynBR_Medication_RXFrequency_Internalname, "服药频率", "col-sm-3 AttributeLabel", 0, true);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 64,'',false,'',0)\"";
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, dynBR_Medication_RXFrequency, dynBR_Medication_RXFrequency_Internalname, StringUtil.RTrim( A126BR_Medication_RXFrequency), 1, dynBR_Medication_RXFrequency_Jsonclick, 0, "'"+""+"'"+",false,"+"'"+""+"'", "svchar", "", 1, dynBR_Medication_RXFrequency.Enabled, 0, 0, 0, "em", 0, "", "", "Attribute", "", "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,64);\"", "", true, "HLP_BR_Medication.htm");
            dynBR_Medication_RXFrequency.CurrentValue = StringUtil.RTrim( A126BR_Medication_RXFrequency);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynBR_Medication_RXFrequency_Internalname, "Values", (String)(dynBR_Medication_RXFrequency.ToJavascriptSource()), true);
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td id=\""+cellVfrequency_cell_Internalname+"\"  class='"+cellVfrequency_cell_Class+"'>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavVfrequency_Internalname, "v Frequency", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 67,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavVfrequency_Internalname, AV19vFrequency, StringUtil.RTrim( context.localUtil.Format( AV19vFrequency, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,67);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "请填写其它服药频率", edtavVfrequency_Jsonclick, 0, "Attribute", "", "", "", "", edtavVfrequency_Visible, edtavVfrequency_Enabled, 0, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_BR_Medication.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table2_60_0H18e( true) ;
         }
         else
         {
            wb_table2_60_0H18e( false) ;
         }
      }

      protected void wb_table1_28_0H18( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "";
            GxWebStd.gx_table_start( context, tblTablemergedbr_medication_rxname_Internalname, tblTablemergedbr_medication_rxname_Internalname, "", "TableMerged", 0, "", "", 0, 0, sStyleString, "", "", 0);
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td class='MergeDataCell'>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, dynBR_Medication_RXName_Internalname, "药物名称", "col-sm-3 AttributeLabel", 0, true);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 32,'',false,'',0)\"";
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, dynBR_Medication_RXName, dynBR_Medication_RXName_Internalname, StringUtil.RTrim( A121BR_Medication_RXName), 1, dynBR_Medication_RXName_Jsonclick, 0, "'"+""+"'"+",false,"+"'"+""+"'", "svchar", "", 1, dynBR_Medication_RXName.Enabled, 0, 0, 0, "em", 0, "", "", "Attribute", "", "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,32);\"", "", true, "HLP_BR_Medication.htm");
            dynBR_Medication_RXName.CurrentValue = StringUtil.RTrim( A121BR_Medication_RXName);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynBR_Medication_RXName_Internalname, "Values", (String)(dynBR_Medication_RXName.ToJavascriptSource()), true);
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td id=\""+cellVmedicationname_cell_Internalname+"\"  class='"+cellVmedicationname_cell_Class+"'>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavVmedicationname_Internalname, "v Medication Name", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 35,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavVmedicationname_Internalname, AV20vMedicationName, StringUtil.RTrim( context.localUtil.Format( AV20vMedicationName, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,35);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "请填写其它药物名称", edtavVmedicationname_Jsonclick, 0, "Attribute", "", "", "", "", edtavVmedicationname_Visible, edtavVmedicationname_Enabled, 0, "text", "", 80, "chr", 1, "row", 99, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_BR_Medication.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table1_28_0H18e( true) ;
         }
         else
         {
            wb_table1_28_0H18e( false) ;
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
         E110H2 ();
         context.wbGlbDoneStart = 1;
         assign_properties_default( ) ;
         if ( AnyError == 0 )
         {
            if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
            {
               /* Read saved SDTs. */
               /* Read variables values. */
               dynBR_Medication_RXName.CurrentValue = cgiGet( dynBR_Medication_RXName_Internalname);
               A121BR_Medication_RXName = cgiGet( dynBR_Medication_RXName_Internalname);
               n121BR_Medication_RXName = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A121BR_Medication_RXName", A121BR_Medication_RXName);
               n121BR_Medication_RXName = (String.IsNullOrEmpty(StringUtil.RTrim( A121BR_Medication_RXName)) ? true : false);
               AV20vMedicationName = cgiGet( edtavVmedicationname_Internalname);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV20vMedicationName", AV20vMedicationName);
               A122BR_Medication_RXCode = cgiGet( edtBR_Medication_RXCode_Internalname);
               n122BR_Medication_RXCode = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A122BR_Medication_RXCode", A122BR_Medication_RXCode);
               n122BR_Medication_RXCode = (String.IsNullOrEmpty(StringUtil.RTrim( A122BR_Medication_RXCode)) ? true : false);
               A123BR_Medication_RXType = cgiGet( edtBR_Medication_RXType_Internalname);
               n123BR_Medication_RXType = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A123BR_Medication_RXType", A123BR_Medication_RXType);
               n123BR_Medication_RXType = (String.IsNullOrEmpty(StringUtil.RTrim( A123BR_Medication_RXType)) ? true : false);
               if ( ( ( context.localUtil.CToN( cgiGet( edtBR_Medication_RXDose_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtBR_Medication_RXDose_Internalname), ".", ",") > 999999999.99999m ) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "BR_MEDICATION_RXDOSE");
                  AnyError = 1;
                  GX_FocusControl = edtBR_Medication_RXDose_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A124BR_Medication_RXDose = 0;
                  n124BR_Medication_RXDose = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A124BR_Medication_RXDose", StringUtil.LTrim( StringUtil.Str( A124BR_Medication_RXDose, 15, 5)));
               }
               else
               {
                  A124BR_Medication_RXDose = context.localUtil.CToN( cgiGet( edtBR_Medication_RXDose_Internalname), ".", ",");
                  n124BR_Medication_RXDose = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A124BR_Medication_RXDose", StringUtil.LTrim( StringUtil.Str( A124BR_Medication_RXDose, 15, 5)));
               }
               n124BR_Medication_RXDose = ((Convert.ToDecimal(0)==A124BR_Medication_RXDose) ? true : false);
               A125BR_Medication_RXUnit = cgiGet( edtBR_Medication_RXUnit_Internalname);
               n125BR_Medication_RXUnit = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A125BR_Medication_RXUnit", A125BR_Medication_RXUnit);
               n125BR_Medication_RXUnit = (String.IsNullOrEmpty(StringUtil.RTrim( A125BR_Medication_RXUnit)) ? true : false);
               dynBR_Medication_RXFrequency.CurrentValue = cgiGet( dynBR_Medication_RXFrequency_Internalname);
               A126BR_Medication_RXFrequency = cgiGet( dynBR_Medication_RXFrequency_Internalname);
               n126BR_Medication_RXFrequency = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A126BR_Medication_RXFrequency", A126BR_Medication_RXFrequency);
               n126BR_Medication_RXFrequency = (String.IsNullOrEmpty(StringUtil.RTrim( A126BR_Medication_RXFrequency)) ? true : false);
               AV19vFrequency = cgiGet( edtavVfrequency_Internalname);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV19vFrequency", AV19vFrequency);
               A127BR_Medication_RXQuantity = cgiGet( edtBR_Medication_RXQuantity_Internalname);
               n127BR_Medication_RXQuantity = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A127BR_Medication_RXQuantity", A127BR_Medication_RXQuantity);
               n127BR_Medication_RXQuantity = (String.IsNullOrEmpty(StringUtil.RTrim( A127BR_Medication_RXQuantity)) ? true : false);
               if ( ( ( context.localUtil.CToN( cgiGet( edtBR_Medication_RXDaysSupply_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtBR_Medication_RXDaysSupply_Internalname), ".", ",") > 999999999.99999m ) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "BR_MEDICATION_RXDAYSSUPPLY");
                  AnyError = 1;
                  GX_FocusControl = edtBR_Medication_RXDaysSupply_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A128BR_Medication_RXDaysSupply = 0;
                  n128BR_Medication_RXDaysSupply = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A128BR_Medication_RXDaysSupply", StringUtil.LTrim( StringUtil.Str( A128BR_Medication_RXDaysSupply, 15, 5)));
               }
               else
               {
                  A128BR_Medication_RXDaysSupply = context.localUtil.CToN( cgiGet( edtBR_Medication_RXDaysSupply_Internalname), ".", ",");
                  n128BR_Medication_RXDaysSupply = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A128BR_Medication_RXDaysSupply", StringUtil.LTrim( StringUtil.Str( A128BR_Medication_RXDaysSupply, 15, 5)));
               }
               n128BR_Medication_RXDaysSupply = ((Convert.ToDecimal(0)==A128BR_Medication_RXDaysSupply) ? true : false);
               dynBR_Medication_RXRoute.CurrentValue = cgiGet( dynBR_Medication_RXRoute_Internalname);
               A129BR_Medication_RXRoute = cgiGet( dynBR_Medication_RXRoute_Internalname);
               n129BR_Medication_RXRoute = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A129BR_Medication_RXRoute", A129BR_Medication_RXRoute);
               n129BR_Medication_RXRoute = (String.IsNullOrEmpty(StringUtil.RTrim( A129BR_Medication_RXRoute)) ? true : false);
               AV15vRXRoute = cgiGet( edtavVrxroute_Internalname);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV15vRXRoute", AV15vRXRoute);
               if ( context.localUtil.VCDate( cgiGet( edtBR_Medication_PrescriptionDate_Internalname), 0) == 0 )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_faildate", new   object[]  {"处方日期"}), 1, "BR_MEDICATION_PRESCRIPTIONDATE");
                  AnyError = 1;
                  GX_FocusControl = edtBR_Medication_PrescriptionDate_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A130BR_Medication_PrescriptionDate = DateTime.MinValue;
                  n130BR_Medication_PrescriptionDate = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A130BR_Medication_PrescriptionDate", context.localUtil.Format(A130BR_Medication_PrescriptionDate, "9999/99/99"));
               }
               else
               {
                  A130BR_Medication_PrescriptionDate = context.localUtil.CToD( cgiGet( edtBR_Medication_PrescriptionDate_Internalname), 0);
                  n130BR_Medication_PrescriptionDate = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A130BR_Medication_PrescriptionDate", context.localUtil.Format(A130BR_Medication_PrescriptionDate, "9999/99/99"));
               }
               n130BR_Medication_PrescriptionDate = ((DateTime.MinValue==A130BR_Medication_PrescriptionDate) ? true : false);
               if ( context.localUtil.VCDate( cgiGet( edtBR_Medication_AdmitStartDate_Internalname), 0) == 0 )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_faildate", new   object[]  {"服药日期"}), 1, "BR_MEDICATION_ADMITSTARTDATE");
                  AnyError = 1;
                  GX_FocusControl = edtBR_Medication_AdmitStartDate_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A132BR_Medication_AdmitStartDate = DateTime.MinValue;
                  n132BR_Medication_AdmitStartDate = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A132BR_Medication_AdmitStartDate", context.localUtil.Format(A132BR_Medication_AdmitStartDate, "9999/99/99"));
               }
               else
               {
                  A132BR_Medication_AdmitStartDate = context.localUtil.CToD( cgiGet( edtBR_Medication_AdmitStartDate_Internalname), 0);
                  n132BR_Medication_AdmitStartDate = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A132BR_Medication_AdmitStartDate", context.localUtil.Format(A132BR_Medication_AdmitStartDate, "9999/99/99"));
               }
               n132BR_Medication_AdmitStartDate = ((DateTime.MinValue==A132BR_Medication_AdmitStartDate) ? true : false);
               if ( context.localUtil.VCDate( cgiGet( edtBR_Medication_AdmitEndDate_Internalname), 0) == 0 )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_faildate", new   object[]  {"停药日期"}), 1, "BR_MEDICATION_ADMITENDDATE");
                  AnyError = 1;
                  GX_FocusControl = edtBR_Medication_AdmitEndDate_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A133BR_Medication_AdmitEndDate = DateTime.MinValue;
                  n133BR_Medication_AdmitEndDate = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A133BR_Medication_AdmitEndDate", context.localUtil.Format(A133BR_Medication_AdmitEndDate, "9999/99/99"));
               }
               else
               {
                  A133BR_Medication_AdmitEndDate = context.localUtil.CToD( cgiGet( edtBR_Medication_AdmitEndDate_Internalname), 0);
                  n133BR_Medication_AdmitEndDate = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A133BR_Medication_AdmitEndDate", context.localUtil.Format(A133BR_Medication_AdmitEndDate, "9999/99/99"));
               }
               n133BR_Medication_AdmitEndDate = ((DateTime.MinValue==A133BR_Medication_AdmitEndDate) ? true : false);
               cmbBR_Medication_InpatientChemo.CurrentValue = cgiGet( cmbBR_Medication_InpatientChemo_Internalname);
               A131BR_Medication_InpatientChemo = cgiGet( cmbBR_Medication_InpatientChemo_Internalname);
               n131BR_Medication_InpatientChemo = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A131BR_Medication_InpatientChemo", A131BR_Medication_InpatientChemo);
               n131BR_Medication_InpatientChemo = (String.IsNullOrEmpty(StringUtil.RTrim( A131BR_Medication_InpatientChemo)) ? true : false);
               A119BR_MedicationID = (long)(context.localUtil.CToN( cgiGet( edtBR_MedicationID_Internalname), ".", ","));
               n119BR_MedicationID = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A119BR_MedicationID", StringUtil.LTrim( StringUtil.Str( (decimal)(A119BR_MedicationID), 18, 0)));
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
               Z119BR_MedicationID = (long)(context.localUtil.CToN( cgiGet( "Z119BR_MedicationID"), ".", ","));
               Z478BR_Medication_RXFrequency_Code = cgiGet( "Z478BR_Medication_RXFrequency_Code");
               n478BR_Medication_RXFrequency_Code = (String.IsNullOrEmpty(StringUtil.RTrim( A478BR_Medication_RXFrequency_Code)) ? true : false);
               Z477BR_Medication_RXRoute_Code = cgiGet( "Z477BR_Medication_RXRoute_Code");
               n477BR_Medication_RXRoute_Code = (String.IsNullOrEmpty(StringUtil.RTrim( A477BR_Medication_RXRoute_Code)) ? true : false);
               Z507BR_Medication_InpatientChemo_Code = cgiGet( "Z507BR_Medication_InpatientChemo_Code");
               n507BR_Medication_InpatientChemo_Code = (String.IsNullOrEmpty(StringUtil.RTrim( A507BR_Medication_InpatientChemo_Code)) ? true : false);
               Z120BR_Medication_RXID = (short)(context.localUtil.CToN( cgiGet( "Z120BR_Medication_RXID"), ".", ","));
               n120BR_Medication_RXID = ((0==A120BR_Medication_RXID) ? true : false);
               Z121BR_Medication_RXName = cgiGet( "Z121BR_Medication_RXName");
               n121BR_Medication_RXName = (String.IsNullOrEmpty(StringUtil.RTrim( A121BR_Medication_RXName)) ? true : false);
               Z499BR_Medication_RXName_Code = cgiGet( "Z499BR_Medication_RXName_Code");
               n499BR_Medication_RXName_Code = (String.IsNullOrEmpty(StringUtil.RTrim( A499BR_Medication_RXName_Code)) ? true : false);
               Z122BR_Medication_RXCode = cgiGet( "Z122BR_Medication_RXCode");
               n122BR_Medication_RXCode = (String.IsNullOrEmpty(StringUtil.RTrim( A122BR_Medication_RXCode)) ? true : false);
               Z123BR_Medication_RXType = cgiGet( "Z123BR_Medication_RXType");
               n123BR_Medication_RXType = (String.IsNullOrEmpty(StringUtil.RTrim( A123BR_Medication_RXType)) ? true : false);
               Z124BR_Medication_RXDose = context.localUtil.CToN( cgiGet( "Z124BR_Medication_RXDose"), ".", ",");
               n124BR_Medication_RXDose = ((Convert.ToDecimal(0)==A124BR_Medication_RXDose) ? true : false);
               Z125BR_Medication_RXUnit = cgiGet( "Z125BR_Medication_RXUnit");
               n125BR_Medication_RXUnit = (String.IsNullOrEmpty(StringUtil.RTrim( A125BR_Medication_RXUnit)) ? true : false);
               Z126BR_Medication_RXFrequency = cgiGet( "Z126BR_Medication_RXFrequency");
               n126BR_Medication_RXFrequency = (String.IsNullOrEmpty(StringUtil.RTrim( A126BR_Medication_RXFrequency)) ? true : false);
               Z127BR_Medication_RXQuantity = cgiGet( "Z127BR_Medication_RXQuantity");
               n127BR_Medication_RXQuantity = (String.IsNullOrEmpty(StringUtil.RTrim( A127BR_Medication_RXQuantity)) ? true : false);
               Z128BR_Medication_RXDaysSupply = context.localUtil.CToN( cgiGet( "Z128BR_Medication_RXDaysSupply"), ".", ",");
               n128BR_Medication_RXDaysSupply = ((Convert.ToDecimal(0)==A128BR_Medication_RXDaysSupply) ? true : false);
               Z129BR_Medication_RXRoute = cgiGet( "Z129BR_Medication_RXRoute");
               n129BR_Medication_RXRoute = (String.IsNullOrEmpty(StringUtil.RTrim( A129BR_Medication_RXRoute)) ? true : false);
               Z130BR_Medication_PrescriptionDate = context.localUtil.CToD( cgiGet( "Z130BR_Medication_PrescriptionDate"), 0);
               n130BR_Medication_PrescriptionDate = ((DateTime.MinValue==A130BR_Medication_PrescriptionDate) ? true : false);
               Z132BR_Medication_AdmitStartDate = context.localUtil.CToD( cgiGet( "Z132BR_Medication_AdmitStartDate"), 0);
               n132BR_Medication_AdmitStartDate = ((DateTime.MinValue==A132BR_Medication_AdmitStartDate) ? true : false);
               Z133BR_Medication_AdmitEndDate = context.localUtil.CToD( cgiGet( "Z133BR_Medication_AdmitEndDate"), 0);
               n133BR_Medication_AdmitEndDate = ((DateTime.MinValue==A133BR_Medication_AdmitEndDate) ? true : false);
               Z131BR_Medication_InpatientChemo = cgiGet( "Z131BR_Medication_InpatientChemo");
               n131BR_Medication_InpatientChemo = (String.IsNullOrEmpty(StringUtil.RTrim( A131BR_Medication_InpatientChemo)) ? true : false);
               Z19BR_EncounterID = (long)(context.localUtil.CToN( cgiGet( "Z19BR_EncounterID"), ".", ","));
               A478BR_Medication_RXFrequency_Code = cgiGet( "Z478BR_Medication_RXFrequency_Code");
               n478BR_Medication_RXFrequency_Code = false;
               n478BR_Medication_RXFrequency_Code = (String.IsNullOrEmpty(StringUtil.RTrim( A478BR_Medication_RXFrequency_Code)) ? true : false);
               A477BR_Medication_RXRoute_Code = cgiGet( "Z477BR_Medication_RXRoute_Code");
               n477BR_Medication_RXRoute_Code = false;
               n477BR_Medication_RXRoute_Code = (String.IsNullOrEmpty(StringUtil.RTrim( A477BR_Medication_RXRoute_Code)) ? true : false);
               A507BR_Medication_InpatientChemo_Code = cgiGet( "Z507BR_Medication_InpatientChemo_Code");
               n507BR_Medication_InpatientChemo_Code = false;
               n507BR_Medication_InpatientChemo_Code = (String.IsNullOrEmpty(StringUtil.RTrim( A507BR_Medication_InpatientChemo_Code)) ? true : false);
               A120BR_Medication_RXID = (short)(context.localUtil.CToN( cgiGet( "Z120BR_Medication_RXID"), ".", ","));
               n120BR_Medication_RXID = false;
               n120BR_Medication_RXID = ((0==A120BR_Medication_RXID) ? true : false);
               A499BR_Medication_RXName_Code = cgiGet( "Z499BR_Medication_RXName_Code");
               n499BR_Medication_RXName_Code = false;
               n499BR_Medication_RXName_Code = (String.IsNullOrEmpty(StringUtil.RTrim( A499BR_Medication_RXName_Code)) ? true : false);
               IsConfirmed = (short)(context.localUtil.CToN( cgiGet( "IsConfirmed"), ".", ","));
               IsModified = (short)(context.localUtil.CToN( cgiGet( "IsModified"), ".", ","));
               Gx_mode = cgiGet( "Mode");
               N19BR_EncounterID = (long)(context.localUtil.CToN( cgiGet( "N19BR_EncounterID"), ".", ","));
               AV12BR_MedicationID = (long)(context.localUtil.CToN( cgiGet( "vBR_MEDICATIONID"), ".", ","));
               AV10Insert_BR_EncounterID = (long)(context.localUtil.CToN( cgiGet( "vINSERT_BR_ENCOUNTERID"), ".", ","));
               A478BR_Medication_RXFrequency_Code = cgiGet( "BR_MEDICATION_RXFREQUENCY_CODE");
               n478BR_Medication_RXFrequency_Code = (String.IsNullOrEmpty(StringUtil.RTrim( A478BR_Medication_RXFrequency_Code)) ? true : false);
               A477BR_Medication_RXRoute_Code = cgiGet( "BR_MEDICATION_RXROUTE_CODE");
               n477BR_Medication_RXRoute_Code = (String.IsNullOrEmpty(StringUtil.RTrim( A477BR_Medication_RXRoute_Code)) ? true : false);
               A507BR_Medication_InpatientChemo_Code = cgiGet( "BR_MEDICATION_INPATIENTCHEMO_CODE");
               n507BR_Medication_InpatientChemo_Code = (String.IsNullOrEmpty(StringUtil.RTrim( A507BR_Medication_InpatientChemo_Code)) ? true : false);
               AV21tCurrentCode = cgiGet( "vTCURRENTCODE");
               A120BR_Medication_RXID = (short)(context.localUtil.CToN( cgiGet( "BR_MEDICATION_RXID"), ".", ","));
               n120BR_Medication_RXID = ((0==A120BR_Medication_RXID) ? true : false);
               A499BR_Medication_RXName_Code = cgiGet( "BR_MEDICATION_RXNAME_CODE");
               n499BR_Medication_RXName_Code = (String.IsNullOrEmpty(StringUtil.RTrim( A499BR_Medication_RXName_Code)) ? true : false);
               A85BR_Information_ID = (long)(context.localUtil.CToN( cgiGet( "BR_INFORMATION_ID"), ".", ","));
               AV22Pgmname = cgiGet( "vPGMNAME");
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
               forbiddenHiddens = "hsh" + "BR_Medication";
               A119BR_MedicationID = (long)(context.localUtil.CToN( cgiGet( edtBR_MedicationID_Internalname), ".", ","));
               n119BR_MedicationID = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A119BR_MedicationID", StringUtil.LTrim( StringUtil.Str( (decimal)(A119BR_MedicationID), 18, 0)));
               forbiddenHiddens = forbiddenHiddens + context.localUtil.Format( (decimal)(A119BR_MedicationID), "ZZZZZZZZZZZZZZZZZZ");
               forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( AV21tCurrentCode, ""));
               forbiddenHiddens = forbiddenHiddens + context.localUtil.Format( (decimal)(AV10Insert_BR_EncounterID), "ZZZZZZZZZZZZZZZZZZ");
               forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!"));
               forbiddenHiddens = forbiddenHiddens + context.localUtil.Format( (decimal)(A120BR_Medication_RXID), "ZZZZ");
               forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( A499BR_Medication_RXName_Code, ""));
               hsh = cgiGet( "hsh");
               if ( ( ! ( ( A119BR_MedicationID != Z119BR_MedicationID ) ) || ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) ) && ! GXUtil.CheckEncryptedHash( forbiddenHiddens, hsh, GXKey) )
               {
                  GXUtil.WriteLog("br_medication:[SecurityCheckFailed value for]"+"BR_MedicationID:"+context.localUtil.Format( (decimal)(A119BR_MedicationID), "ZZZZZZZZZZZZZZZZZZ"));
                  GXUtil.WriteLog("br_medication:[SecurityCheckFailed value for]"+"tCurrentCode:"+StringUtil.RTrim( context.localUtil.Format( AV21tCurrentCode, "")));
                  GXUtil.WriteLog("br_medication:[SecurityCheckFailed value for]"+"Insert_BR_EncounterID:"+context.localUtil.Format( (decimal)(AV10Insert_BR_EncounterID), "ZZZZZZZZZZZZZZZZZZ"));
                  GXUtil.WriteLog("br_medication:[SecurityCheckFailed value for]"+"Gx_mode:"+StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")));
                  GXUtil.WriteLog("br_medication:[SecurityCheckFailed value for]"+"BR_Medication_RXID:"+context.localUtil.Format( (decimal)(A120BR_Medication_RXID), "ZZZZ"));
                  GXUtil.WriteLog("br_medication:[SecurityCheckFailed value for]"+"BR_Medication_RXName_Code:"+StringUtil.RTrim( context.localUtil.Format( A499BR_Medication_RXName_Code, "")));
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
                  A119BR_MedicationID = (long)(NumberUtil.Val( GetNextPar( ), "."));
                  n119BR_MedicationID = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A119BR_MedicationID", StringUtil.LTrim( StringUtil.Str( (decimal)(A119BR_MedicationID), 18, 0)));
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
                     sMode18 = Gx_mode;
                     Gx_mode = "UPD";
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                     Gx_mode = sMode18;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                  }
                  standaloneModal( ) ;
                  if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
                  {
                     getByPrimaryKey( ) ;
                     if ( RcdFound18 == 1 )
                     {
                        if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
                        {
                           /* Confirm record */
                           CONFIRM_0H0( ) ;
                           if ( AnyError == 0 )
                           {
                              GX_FocusControl = bttBtntrn_enter_Internalname;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                           }
                        }
                     }
                     else
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_noinsert", ""), 1, "BR_MEDICATIONID");
                        AnyError = 1;
                        GX_FocusControl = edtBR_MedicationID_Internalname;
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
                           E110H2 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "AFTER TRN") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           /* Execute user event: After Trn */
                           E120H2 ();
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
            E120H2 ();
            trnEnded = 0;
            standaloneNotModal( ) ;
            standaloneModal( ) ;
            if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  )
            {
               /* Clear variables for new insertion. */
               InitAll0H18( ) ;
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
            DisableAttributes0H18( ) ;
         }
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavVmedicationname_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavVmedicationname_Enabled), 5, 0)), true);
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavVfrequency_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavVfrequency_Enabled), 5, 0)), true);
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavVrxroute_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavVrxroute_Enabled), 5, 0)), true);
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
               CloseExtendedTableCursors0H18( ) ;
            }
         }
         if ( AnyError == 0 )
         {
            IsConfirmed = 1;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "IsConfirmed", StringUtil.LTrim( StringUtil.Str( (decimal)(IsConfirmed), 4, 0)));
         }
      }

      protected void ResetCaption0H0( )
      {
      }

      protected void E110H2( )
      {
         /* Start Routine */
         GXt_char1 = AV21tCurrentCode;
         new zbr_getcurrenttcode(context ).execute( out  GXt_char1) ;
         AV21tCurrentCode = GXt_char1;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV21tCurrentCode", AV21tCurrentCode);
         new GeneXus.Programs.wwpbaseobjects.loadwwpcontext(context ).execute( out  AV7WWPContext) ;
         AV13IsAuthorized = true;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13IsAuthorized", AV13IsAuthorized);
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            GXt_boolean2 = AV13IsAuthorized;
            new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "Manage_Medication", out  GXt_boolean2) ;
            AV13IsAuthorized = GXt_boolean2;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13IsAuthorized", AV13IsAuthorized);
         }
         if ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 )
         {
            GXt_boolean2 = AV13IsAuthorized;
            new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "Manage_Medication", out  GXt_boolean2) ;
            AV13IsAuthorized = GXt_boolean2;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13IsAuthorized", AV13IsAuthorized);
         }
         if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
         {
            GXt_boolean2 = AV13IsAuthorized;
            new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "Manage_Medication", out  GXt_boolean2) ;
            AV13IsAuthorized = GXt_boolean2;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13IsAuthorized", AV13IsAuthorized);
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
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV23GXV1", StringUtil.LTrim( StringUtil.Str( (decimal)(AV23GXV1), 8, 0)));
            while ( AV23GXV1 <= AV8TrnContext.gxTpr_Attributes.Count )
            {
               AV11TrnContextAtt = ((GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext_Attribute)AV8TrnContext.gxTpr_Attributes.Item(AV23GXV1));
               if ( StringUtil.StrCmp(AV11TrnContextAtt.gxTpr_Attributename, "BR_EncounterID") == 0 )
               {
                  AV10Insert_BR_EncounterID = (long)(NumberUtil.Val( AV11TrnContextAtt.gxTpr_Attributevalue, "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10Insert_BR_EncounterID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10Insert_BR_EncounterID), 18, 0)));
               }
               AV23GXV1 = (int)(AV23GXV1+1);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV23GXV1", StringUtil.LTrim( StringUtil.Str( (decimal)(AV23GXV1), 8, 0)));
            }
         }
         edtBR_MedicationID_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_MedicationID_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBR_MedicationID_Visible), 5, 0)), true);
         edtBR_EncounterID_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_EncounterID_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBR_EncounterID_Visible), 5, 0)), true);
         edtBR_Information_PatientNo_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Information_PatientNo_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBR_Information_PatientNo_Visible), 5, 0)), true);
      }

      protected void E120H2( )
      {
         /* After Trn Routine */
         if ( ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 ) && ! AV8TrnContext.gxTpr_Callerondelete )
         {
            CallWebObject(formatLink("br_medicationww.aspx") );
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
         edtavVmedicationname_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavVmedicationname_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavVmedicationname_Visible), 5, 0)), true);
         cellVmedicationname_cell_Class = "Invisible";
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cellVmedicationname_cell_Internalname, "Class", cellVmedicationname_cell_Class, true);
         edtavVfrequency_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavVfrequency_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavVfrequency_Visible), 5, 0)), true);
         cellVfrequency_cell_Class = "Invisible";
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cellVfrequency_cell_Internalname, "Class", cellVfrequency_cell_Class, true);
         edtavVrxroute_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavVrxroute_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavVrxroute_Visible), 5, 0)), true);
         cellVrxroute_cell_Class = "Invisible";
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cellVrxroute_cell_Internalname, "Class", cellVrxroute_cell_Class, true);
      }

      protected void ZM0H18( short GX_JID )
      {
         if ( ( GX_JID == 36 ) || ( GX_JID == 0 ) )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
            {
               Z478BR_Medication_RXFrequency_Code = T000H3_A478BR_Medication_RXFrequency_Code[0];
               Z477BR_Medication_RXRoute_Code = T000H3_A477BR_Medication_RXRoute_Code[0];
               Z507BR_Medication_InpatientChemo_Code = T000H3_A507BR_Medication_InpatientChemo_Code[0];
               Z120BR_Medication_RXID = T000H3_A120BR_Medication_RXID[0];
               Z121BR_Medication_RXName = T000H3_A121BR_Medication_RXName[0];
               Z499BR_Medication_RXName_Code = T000H3_A499BR_Medication_RXName_Code[0];
               Z122BR_Medication_RXCode = T000H3_A122BR_Medication_RXCode[0];
               Z123BR_Medication_RXType = T000H3_A123BR_Medication_RXType[0];
               Z124BR_Medication_RXDose = T000H3_A124BR_Medication_RXDose[0];
               Z125BR_Medication_RXUnit = T000H3_A125BR_Medication_RXUnit[0];
               Z126BR_Medication_RXFrequency = T000H3_A126BR_Medication_RXFrequency[0];
               Z127BR_Medication_RXQuantity = T000H3_A127BR_Medication_RXQuantity[0];
               Z128BR_Medication_RXDaysSupply = T000H3_A128BR_Medication_RXDaysSupply[0];
               Z129BR_Medication_RXRoute = T000H3_A129BR_Medication_RXRoute[0];
               Z130BR_Medication_PrescriptionDate = T000H3_A130BR_Medication_PrescriptionDate[0];
               Z132BR_Medication_AdmitStartDate = T000H3_A132BR_Medication_AdmitStartDate[0];
               Z133BR_Medication_AdmitEndDate = T000H3_A133BR_Medication_AdmitEndDate[0];
               Z131BR_Medication_InpatientChemo = T000H3_A131BR_Medication_InpatientChemo[0];
               Z19BR_EncounterID = T000H3_A19BR_EncounterID[0];
            }
            else
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
         }
         if ( GX_JID == -36 )
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
         edtBR_MedicationID_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_MedicationID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBR_MedicationID_Enabled), 5, 0)), true);
         edtBR_MedicationID_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_MedicationID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBR_MedicationID_Enabled), 5, 0)), true);
         bttBtntrn_delete_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtntrn_delete_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtntrn_delete_Enabled), 5, 0)), true);
         if ( ! (0==AV12BR_MedicationID) )
         {
            A119BR_MedicationID = AV12BR_MedicationID;
            n119BR_MedicationID = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A119BR_MedicationID", StringUtil.LTrim( StringUtil.Str( (decimal)(A119BR_MedicationID), 18, 0)));
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
         GXABR_MEDICATION_RXNAME_html0H18( AV21tCurrentCode) ;
         GXABR_MEDICATION_RXFREQUENCY_html0H18( AV21tCurrentCode) ;
         GXABR_MEDICATION_RXROUTE_html0H18( AV21tCurrentCode) ;
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
            AV22Pgmname = "BR_Medication";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV22Pgmname", AV22Pgmname);
            edtavVmedicationname_Visible = ((StringUtil.StrCmp(A121BR_Medication_RXName, "其它")==0) ? 1 : 0);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavVmedicationname_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavVmedicationname_Visible), 5, 0)), true);
            if ( ! ( ( StringUtil.StrCmp(A121BR_Medication_RXName, "其它") == 0 ) ) )
            {
               cellVmedicationname_cell_Class = "Invisible";
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, cellVmedicationname_cell_Internalname, "Class", cellVmedicationname_cell_Class, true);
            }
            else
            {
               if ( StringUtil.StrCmp(A121BR_Medication_RXName, "其它") == 0 )
               {
                  cellVmedicationname_cell_Class = "RequiredDataContentCell";
                  context.httpAjaxContext.ajax_rsp_assign_prop("", false, cellVmedicationname_cell_Internalname, "Class", cellVmedicationname_cell_Class, true);
               }
            }
            edtavVfrequency_Visible = ((StringUtil.StrCmp(A126BR_Medication_RXFrequency, "其它")==0) ? 1 : 0);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavVfrequency_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavVfrequency_Visible), 5, 0)), true);
            if ( ! ( ( StringUtil.StrCmp(A126BR_Medication_RXFrequency, "其它") == 0 ) ) )
            {
               cellVfrequency_cell_Class = "Invisible";
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, cellVfrequency_cell_Internalname, "Class", cellVfrequency_cell_Class, true);
            }
            else
            {
               if ( StringUtil.StrCmp(A126BR_Medication_RXFrequency, "其它") == 0 )
               {
                  cellVfrequency_cell_Class = "RequiredDataContentCell";
                  context.httpAjaxContext.ajax_rsp_assign_prop("", false, cellVfrequency_cell_Internalname, "Class", cellVfrequency_cell_Class, true);
               }
            }
            edtavVrxroute_Visible = ((StringUtil.StrCmp(A129BR_Medication_RXRoute, "其它")==0) ? 1 : 0);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavVrxroute_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavVrxroute_Visible), 5, 0)), true);
            if ( ! ( ( StringUtil.StrCmp(A129BR_Medication_RXRoute, "其它") == 0 ) ) )
            {
               cellVrxroute_cell_Class = "Invisible";
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, cellVrxroute_cell_Internalname, "Class", cellVrxroute_cell_Class, true);
            }
            else
            {
               if ( StringUtil.StrCmp(A129BR_Medication_RXRoute, "其它") == 0 )
               {
                  cellVrxroute_cell_Class = "RequiredDataContentCell";
                  context.httpAjaxContext.ajax_rsp_assign_prop("", false, cellVrxroute_cell_Internalname, "Class", cellVrxroute_cell_Class, true);
               }
            }
            /* Using cursor T000H4 */
            pr_default.execute(2, new Object[] {A19BR_EncounterID});
            A85BR_Information_ID = T000H4_A85BR_Information_ID[0];
            n85BR_Information_ID = T000H4_n85BR_Information_ID[0];
            pr_default.close(2);
            /* Using cursor T000H5 */
            pr_default.execute(3, new Object[] {n85BR_Information_ID, A85BR_Information_ID});
            A36BR_Information_PatientNo = T000H5_A36BR_Information_PatientNo[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A36BR_Information_PatientNo", A36BR_Information_PatientNo);
            n36BR_Information_PatientNo = T000H5_n36BR_Information_PatientNo[0];
            pr_default.close(3);
         }
      }

      protected void Load0H18( )
      {
         /* Using cursor T000H6 */
         pr_default.execute(4, new Object[] {n119BR_MedicationID, A119BR_MedicationID});
         if ( (pr_default.getStatus(4) != 101) )
         {
            RcdFound18 = 1;
            A85BR_Information_ID = T000H6_A85BR_Information_ID[0];
            n85BR_Information_ID = T000H6_n85BR_Information_ID[0];
            A478BR_Medication_RXFrequency_Code = T000H6_A478BR_Medication_RXFrequency_Code[0];
            n478BR_Medication_RXFrequency_Code = T000H6_n478BR_Medication_RXFrequency_Code[0];
            A477BR_Medication_RXRoute_Code = T000H6_A477BR_Medication_RXRoute_Code[0];
            n477BR_Medication_RXRoute_Code = T000H6_n477BR_Medication_RXRoute_Code[0];
            A507BR_Medication_InpatientChemo_Code = T000H6_A507BR_Medication_InpatientChemo_Code[0];
            n507BR_Medication_InpatientChemo_Code = T000H6_n507BR_Medication_InpatientChemo_Code[0];
            A36BR_Information_PatientNo = T000H6_A36BR_Information_PatientNo[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A36BR_Information_PatientNo", A36BR_Information_PatientNo);
            n36BR_Information_PatientNo = T000H6_n36BR_Information_PatientNo[0];
            A120BR_Medication_RXID = T000H6_A120BR_Medication_RXID[0];
            n120BR_Medication_RXID = T000H6_n120BR_Medication_RXID[0];
            A121BR_Medication_RXName = T000H6_A121BR_Medication_RXName[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A121BR_Medication_RXName", A121BR_Medication_RXName);
            n121BR_Medication_RXName = T000H6_n121BR_Medication_RXName[0];
            A499BR_Medication_RXName_Code = T000H6_A499BR_Medication_RXName_Code[0];
            n499BR_Medication_RXName_Code = T000H6_n499BR_Medication_RXName_Code[0];
            A122BR_Medication_RXCode = T000H6_A122BR_Medication_RXCode[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A122BR_Medication_RXCode", A122BR_Medication_RXCode);
            n122BR_Medication_RXCode = T000H6_n122BR_Medication_RXCode[0];
            A123BR_Medication_RXType = T000H6_A123BR_Medication_RXType[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A123BR_Medication_RXType", A123BR_Medication_RXType);
            n123BR_Medication_RXType = T000H6_n123BR_Medication_RXType[0];
            A124BR_Medication_RXDose = T000H6_A124BR_Medication_RXDose[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A124BR_Medication_RXDose", StringUtil.LTrim( StringUtil.Str( A124BR_Medication_RXDose, 15, 5)));
            n124BR_Medication_RXDose = T000H6_n124BR_Medication_RXDose[0];
            A125BR_Medication_RXUnit = T000H6_A125BR_Medication_RXUnit[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A125BR_Medication_RXUnit", A125BR_Medication_RXUnit);
            n125BR_Medication_RXUnit = T000H6_n125BR_Medication_RXUnit[0];
            A126BR_Medication_RXFrequency = T000H6_A126BR_Medication_RXFrequency[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A126BR_Medication_RXFrequency", A126BR_Medication_RXFrequency);
            n126BR_Medication_RXFrequency = T000H6_n126BR_Medication_RXFrequency[0];
            A127BR_Medication_RXQuantity = T000H6_A127BR_Medication_RXQuantity[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A127BR_Medication_RXQuantity", A127BR_Medication_RXQuantity);
            n127BR_Medication_RXQuantity = T000H6_n127BR_Medication_RXQuantity[0];
            A128BR_Medication_RXDaysSupply = T000H6_A128BR_Medication_RXDaysSupply[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A128BR_Medication_RXDaysSupply", StringUtil.LTrim( StringUtil.Str( A128BR_Medication_RXDaysSupply, 15, 5)));
            n128BR_Medication_RXDaysSupply = T000H6_n128BR_Medication_RXDaysSupply[0];
            A129BR_Medication_RXRoute = T000H6_A129BR_Medication_RXRoute[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A129BR_Medication_RXRoute", A129BR_Medication_RXRoute);
            n129BR_Medication_RXRoute = T000H6_n129BR_Medication_RXRoute[0];
            A130BR_Medication_PrescriptionDate = T000H6_A130BR_Medication_PrescriptionDate[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A130BR_Medication_PrescriptionDate", context.localUtil.Format(A130BR_Medication_PrescriptionDate, "9999/99/99"));
            n130BR_Medication_PrescriptionDate = T000H6_n130BR_Medication_PrescriptionDate[0];
            A132BR_Medication_AdmitStartDate = T000H6_A132BR_Medication_AdmitStartDate[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A132BR_Medication_AdmitStartDate", context.localUtil.Format(A132BR_Medication_AdmitStartDate, "9999/99/99"));
            n132BR_Medication_AdmitStartDate = T000H6_n132BR_Medication_AdmitStartDate[0];
            A133BR_Medication_AdmitEndDate = T000H6_A133BR_Medication_AdmitEndDate[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A133BR_Medication_AdmitEndDate", context.localUtil.Format(A133BR_Medication_AdmitEndDate, "9999/99/99"));
            n133BR_Medication_AdmitEndDate = T000H6_n133BR_Medication_AdmitEndDate[0];
            A131BR_Medication_InpatientChemo = T000H6_A131BR_Medication_InpatientChemo[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A131BR_Medication_InpatientChemo", A131BR_Medication_InpatientChemo);
            n131BR_Medication_InpatientChemo = T000H6_n131BR_Medication_InpatientChemo[0];
            A19BR_EncounterID = T000H6_A19BR_EncounterID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A19BR_EncounterID", StringUtil.LTrim( StringUtil.Str( (decimal)(A19BR_EncounterID), 18, 0)));
            ZM0H18( -36) ;
         }
         pr_default.close(4);
         OnLoadActions0H18( ) ;
      }

      protected void OnLoadActions0H18( )
      {
         AV22Pgmname = "BR_Medication";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV22Pgmname", AV22Pgmname);
         edtavVmedicationname_Visible = ((StringUtil.StrCmp(A121BR_Medication_RXName, "其它")==0) ? 1 : 0);
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavVmedicationname_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavVmedicationname_Visible), 5, 0)), true);
         if ( ! ( ( StringUtil.StrCmp(A121BR_Medication_RXName, "其它") == 0 ) ) )
         {
            cellVmedicationname_cell_Class = "Invisible";
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cellVmedicationname_cell_Internalname, "Class", cellVmedicationname_cell_Class, true);
         }
         else
         {
            if ( StringUtil.StrCmp(A121BR_Medication_RXName, "其它") == 0 )
            {
               cellVmedicationname_cell_Class = "RequiredDataContentCell";
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, cellVmedicationname_cell_Internalname, "Class", cellVmedicationname_cell_Class, true);
            }
         }
         edtavVfrequency_Visible = ((StringUtil.StrCmp(A126BR_Medication_RXFrequency, "其它")==0) ? 1 : 0);
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavVfrequency_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavVfrequency_Visible), 5, 0)), true);
         if ( ! ( ( StringUtil.StrCmp(A126BR_Medication_RXFrequency, "其它") == 0 ) ) )
         {
            cellVfrequency_cell_Class = "Invisible";
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cellVfrequency_cell_Internalname, "Class", cellVfrequency_cell_Class, true);
         }
         else
         {
            if ( StringUtil.StrCmp(A126BR_Medication_RXFrequency, "其它") == 0 )
            {
               cellVfrequency_cell_Class = "RequiredDataContentCell";
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, cellVfrequency_cell_Internalname, "Class", cellVfrequency_cell_Class, true);
            }
         }
         edtavVrxroute_Visible = ((StringUtil.StrCmp(A129BR_Medication_RXRoute, "其它")==0) ? 1 : 0);
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavVrxroute_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavVrxroute_Visible), 5, 0)), true);
         if ( ! ( ( StringUtil.StrCmp(A129BR_Medication_RXRoute, "其它") == 0 ) ) )
         {
            cellVrxroute_cell_Class = "Invisible";
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cellVrxroute_cell_Internalname, "Class", cellVrxroute_cell_Class, true);
         }
         else
         {
            if ( StringUtil.StrCmp(A129BR_Medication_RXRoute, "其它") == 0 )
            {
               cellVrxroute_cell_Class = "RequiredDataContentCell";
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, cellVrxroute_cell_Internalname, "Class", cellVrxroute_cell_Class, true);
            }
         }
      }

      protected void CheckExtendedTable0H18( )
      {
         Gx_BScreen = 1;
         standaloneModal( ) ;
         AV22Pgmname = "BR_Medication";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV22Pgmname", AV22Pgmname);
         /* Using cursor T000H4 */
         pr_default.execute(2, new Object[] {A19BR_EncounterID});
         if ( (pr_default.getStatus(2) == 101) )
         {
            GX_msglist.addItem("不匹配' T15'", "ForeignKeyNotFound", 1, "BR_ENCOUNTERID");
            AnyError = 1;
            GX_FocusControl = edtBR_EncounterID_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         A85BR_Information_ID = T000H4_A85BR_Information_ID[0];
         n85BR_Information_ID = T000H4_n85BR_Information_ID[0];
         pr_default.close(2);
         /* Using cursor T000H5 */
         pr_default.execute(3, new Object[] {n85BR_Information_ID, A85BR_Information_ID});
         if ( (pr_default.getStatus(3) == 101) )
         {
            if ( ! ( (0==A85BR_Information_ID) ) )
            {
               GX_msglist.addItem("不匹配' T16'", "ForeignKeyNotFound", 1, "");
               AnyError = 1;
            }
         }
         A36BR_Information_PatientNo = T000H5_A36BR_Information_PatientNo[0];
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A36BR_Information_PatientNo", A36BR_Information_PatientNo);
         n36BR_Information_PatientNo = T000H5_n36BR_Information_PatientNo[0];
         pr_default.close(3);
         edtavVmedicationname_Visible = ((StringUtil.StrCmp(A121BR_Medication_RXName, "其它")==0) ? 1 : 0);
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavVmedicationname_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavVmedicationname_Visible), 5, 0)), true);
         if ( ! ( ( StringUtil.StrCmp(A121BR_Medication_RXName, "其它") == 0 ) ) )
         {
            cellVmedicationname_cell_Class = "Invisible";
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cellVmedicationname_cell_Internalname, "Class", cellVmedicationname_cell_Class, true);
         }
         else
         {
            if ( StringUtil.StrCmp(A121BR_Medication_RXName, "其它") == 0 )
            {
               cellVmedicationname_cell_Class = "RequiredDataContentCell";
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, cellVmedicationname_cell_Internalname, "Class", cellVmedicationname_cell_Class, true);
            }
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( A121BR_Medication_RXName)) )
         {
            GX_msglist.addItem("药物名称是必须填写的。", 1, "BR_MEDICATION_RXNAME");
            AnyError = 1;
            GX_FocusControl = dynBR_Medication_RXName_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         edtavVfrequency_Visible = ((StringUtil.StrCmp(A126BR_Medication_RXFrequency, "其它")==0) ? 1 : 0);
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavVfrequency_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavVfrequency_Visible), 5, 0)), true);
         if ( ! ( ( StringUtil.StrCmp(A126BR_Medication_RXFrequency, "其它") == 0 ) ) )
         {
            cellVfrequency_cell_Class = "Invisible";
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cellVfrequency_cell_Internalname, "Class", cellVfrequency_cell_Class, true);
         }
         else
         {
            if ( StringUtil.StrCmp(A126BR_Medication_RXFrequency, "其它") == 0 )
            {
               cellVfrequency_cell_Class = "RequiredDataContentCell";
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, cellVfrequency_cell_Internalname, "Class", cellVfrequency_cell_Class, true);
            }
         }
         edtavVrxroute_Visible = ((StringUtil.StrCmp(A129BR_Medication_RXRoute, "其它")==0) ? 1 : 0);
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavVrxroute_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavVrxroute_Visible), 5, 0)), true);
         if ( ! ( ( StringUtil.StrCmp(A129BR_Medication_RXRoute, "其它") == 0 ) ) )
         {
            cellVrxroute_cell_Class = "Invisible";
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cellVrxroute_cell_Internalname, "Class", cellVrxroute_cell_Class, true);
         }
         else
         {
            if ( StringUtil.StrCmp(A129BR_Medication_RXRoute, "其它") == 0 )
            {
               cellVrxroute_cell_Class = "RequiredDataContentCell";
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, cellVrxroute_cell_Internalname, "Class", cellVrxroute_cell_Class, true);
            }
         }
         if ( ! ( (DateTime.MinValue==A130BR_Medication_PrescriptionDate) || ( A130BR_Medication_PrescriptionDate >= context.localUtil.YMDToD( 1753, 1, 1) ) ) )
         {
            GX_msglist.addItem("域处方日期超界", "OutOfRange", 1, "BR_MEDICATION_PRESCRIPTIONDATE");
            AnyError = 1;
            GX_FocusControl = edtBR_Medication_PrescriptionDate_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( ! ( (DateTime.MinValue==A132BR_Medication_AdmitStartDate) || ( A132BR_Medication_AdmitStartDate >= context.localUtil.YMDToD( 1753, 1, 1) ) ) )
         {
            GX_msglist.addItem("域服药日期超界", "OutOfRange", 1, "BR_MEDICATION_ADMITSTARTDATE");
            AnyError = 1;
            GX_FocusControl = edtBR_Medication_AdmitStartDate_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( (DateTime.MinValue==A132BR_Medication_AdmitStartDate) )
         {
            GX_msglist.addItem("服药日期是必须填写的。", 1, "BR_MEDICATION_ADMITSTARTDATE");
            AnyError = 1;
            GX_FocusControl = edtBR_Medication_AdmitStartDate_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( ! ( (DateTime.MinValue==A133BR_Medication_AdmitEndDate) || ( A133BR_Medication_AdmitEndDate >= context.localUtil.YMDToD( 1753, 1, 1) ) ) )
         {
            GX_msglist.addItem("域停药日期超界", "OutOfRange", 1, "BR_MEDICATION_ADMITENDDATE");
            AnyError = 1;
            GX_FocusControl = edtBR_Medication_AdmitEndDate_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( ! ( ( StringUtil.StrCmp(A131BR_Medication_InpatientChemo, "否") == 0 ) || ( StringUtil.StrCmp(A131BR_Medication_InpatientChemo, "是") == 0 ) || ( StringUtil.StrCmp(A131BR_Medication_InpatientChemo, "不详") == 0 ) || String.IsNullOrEmpty(StringUtil.RTrim( A131BR_Medication_InpatientChemo)) ) )
         {
            GX_msglist.addItem("域是否接受住院化疗超界", "OutOfRange", 1, "BR_MEDICATION_INPATIENTCHEMO");
            AnyError = 1;
            GX_FocusControl = cmbBR_Medication_InpatientChemo_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( ( ( StringUtil.StrCmp(A121BR_Medication_RXName, "其它") == 0 ) ) && String.IsNullOrEmpty(StringUtil.RTrim( AV20vMedicationName)) )
         {
            GX_msglist.addItem("其它药物名称是必填的", 1, "BR_MEDICATION_RXNAME");
            AnyError = 1;
            GX_FocusControl = dynBR_Medication_RXName_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( ( ( StringUtil.StrCmp(A126BR_Medication_RXFrequency, "其它") == 0 ) ) && String.IsNullOrEmpty(StringUtil.RTrim( AV19vFrequency)) )
         {
            GX_msglist.addItem("其它服药频率是必填的", 1, "BR_MEDICATION_RXFREQUENCY");
            AnyError = 1;
            GX_FocusControl = dynBR_Medication_RXFrequency_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( ( ( StringUtil.StrCmp(A129BR_Medication_RXRoute, "其它") == 0 ) ) && String.IsNullOrEmpty(StringUtil.RTrim( AV15vRXRoute)) )
         {
            GX_msglist.addItem("其它给药途径是必填的", 1, "BR_MEDICATION_RXROUTE");
            AnyError = 1;
            GX_FocusControl = dynBR_Medication_RXRoute_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
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

      protected void gxLoad_37( long A19BR_EncounterID )
      {
         /* Using cursor T000H7 */
         pr_default.execute(5, new Object[] {A19BR_EncounterID});
         if ( (pr_default.getStatus(5) == 101) )
         {
            GX_msglist.addItem("不匹配' T15'", "ForeignKeyNotFound", 1, "BR_ENCOUNTERID");
            AnyError = 1;
            GX_FocusControl = edtBR_EncounterID_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         A85BR_Information_ID = T000H7_A85BR_Information_ID[0];
         n85BR_Information_ID = T000H7_n85BR_Information_ID[0];
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

      protected void gxLoad_38( long A85BR_Information_ID )
      {
         /* Using cursor T000H8 */
         pr_default.execute(6, new Object[] {n85BR_Information_ID, A85BR_Information_ID});
         if ( (pr_default.getStatus(6) == 101) )
         {
            if ( ! ( (0==A85BR_Information_ID) ) )
            {
               GX_msglist.addItem("不匹配' T16'", "ForeignKeyNotFound", 1, "");
               AnyError = 1;
            }
         }
         A36BR_Information_PatientNo = T000H8_A36BR_Information_PatientNo[0];
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A36BR_Information_PatientNo", A36BR_Information_PatientNo);
         n36BR_Information_PatientNo = T000H8_n36BR_Information_PatientNo[0];
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

      protected void GetKey0H18( )
      {
         /* Using cursor T000H9 */
         pr_default.execute(7, new Object[] {n119BR_MedicationID, A119BR_MedicationID});
         if ( (pr_default.getStatus(7) != 101) )
         {
            RcdFound18 = 1;
         }
         else
         {
            RcdFound18 = 0;
         }
         pr_default.close(7);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor T000H3 */
         pr_default.execute(1, new Object[] {n119BR_MedicationID, A119BR_MedicationID});
         if ( (pr_default.getStatus(1) != 101) )
         {
            ZM0H18( 36) ;
            RcdFound18 = 1;
            A119BR_MedicationID = T000H3_A119BR_MedicationID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A119BR_MedicationID", StringUtil.LTrim( StringUtil.Str( (decimal)(A119BR_MedicationID), 18, 0)));
            n119BR_MedicationID = T000H3_n119BR_MedicationID[0];
            A478BR_Medication_RXFrequency_Code = T000H3_A478BR_Medication_RXFrequency_Code[0];
            n478BR_Medication_RXFrequency_Code = T000H3_n478BR_Medication_RXFrequency_Code[0];
            A477BR_Medication_RXRoute_Code = T000H3_A477BR_Medication_RXRoute_Code[0];
            n477BR_Medication_RXRoute_Code = T000H3_n477BR_Medication_RXRoute_Code[0];
            A507BR_Medication_InpatientChemo_Code = T000H3_A507BR_Medication_InpatientChemo_Code[0];
            n507BR_Medication_InpatientChemo_Code = T000H3_n507BR_Medication_InpatientChemo_Code[0];
            A120BR_Medication_RXID = T000H3_A120BR_Medication_RXID[0];
            n120BR_Medication_RXID = T000H3_n120BR_Medication_RXID[0];
            A121BR_Medication_RXName = T000H3_A121BR_Medication_RXName[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A121BR_Medication_RXName", A121BR_Medication_RXName);
            n121BR_Medication_RXName = T000H3_n121BR_Medication_RXName[0];
            A499BR_Medication_RXName_Code = T000H3_A499BR_Medication_RXName_Code[0];
            n499BR_Medication_RXName_Code = T000H3_n499BR_Medication_RXName_Code[0];
            A122BR_Medication_RXCode = T000H3_A122BR_Medication_RXCode[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A122BR_Medication_RXCode", A122BR_Medication_RXCode);
            n122BR_Medication_RXCode = T000H3_n122BR_Medication_RXCode[0];
            A123BR_Medication_RXType = T000H3_A123BR_Medication_RXType[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A123BR_Medication_RXType", A123BR_Medication_RXType);
            n123BR_Medication_RXType = T000H3_n123BR_Medication_RXType[0];
            A124BR_Medication_RXDose = T000H3_A124BR_Medication_RXDose[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A124BR_Medication_RXDose", StringUtil.LTrim( StringUtil.Str( A124BR_Medication_RXDose, 15, 5)));
            n124BR_Medication_RXDose = T000H3_n124BR_Medication_RXDose[0];
            A125BR_Medication_RXUnit = T000H3_A125BR_Medication_RXUnit[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A125BR_Medication_RXUnit", A125BR_Medication_RXUnit);
            n125BR_Medication_RXUnit = T000H3_n125BR_Medication_RXUnit[0];
            A126BR_Medication_RXFrequency = T000H3_A126BR_Medication_RXFrequency[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A126BR_Medication_RXFrequency", A126BR_Medication_RXFrequency);
            n126BR_Medication_RXFrequency = T000H3_n126BR_Medication_RXFrequency[0];
            A127BR_Medication_RXQuantity = T000H3_A127BR_Medication_RXQuantity[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A127BR_Medication_RXQuantity", A127BR_Medication_RXQuantity);
            n127BR_Medication_RXQuantity = T000H3_n127BR_Medication_RXQuantity[0];
            A128BR_Medication_RXDaysSupply = T000H3_A128BR_Medication_RXDaysSupply[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A128BR_Medication_RXDaysSupply", StringUtil.LTrim( StringUtil.Str( A128BR_Medication_RXDaysSupply, 15, 5)));
            n128BR_Medication_RXDaysSupply = T000H3_n128BR_Medication_RXDaysSupply[0];
            A129BR_Medication_RXRoute = T000H3_A129BR_Medication_RXRoute[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A129BR_Medication_RXRoute", A129BR_Medication_RXRoute);
            n129BR_Medication_RXRoute = T000H3_n129BR_Medication_RXRoute[0];
            A130BR_Medication_PrescriptionDate = T000H3_A130BR_Medication_PrescriptionDate[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A130BR_Medication_PrescriptionDate", context.localUtil.Format(A130BR_Medication_PrescriptionDate, "9999/99/99"));
            n130BR_Medication_PrescriptionDate = T000H3_n130BR_Medication_PrescriptionDate[0];
            A132BR_Medication_AdmitStartDate = T000H3_A132BR_Medication_AdmitStartDate[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A132BR_Medication_AdmitStartDate", context.localUtil.Format(A132BR_Medication_AdmitStartDate, "9999/99/99"));
            n132BR_Medication_AdmitStartDate = T000H3_n132BR_Medication_AdmitStartDate[0];
            A133BR_Medication_AdmitEndDate = T000H3_A133BR_Medication_AdmitEndDate[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A133BR_Medication_AdmitEndDate", context.localUtil.Format(A133BR_Medication_AdmitEndDate, "9999/99/99"));
            n133BR_Medication_AdmitEndDate = T000H3_n133BR_Medication_AdmitEndDate[0];
            A131BR_Medication_InpatientChemo = T000H3_A131BR_Medication_InpatientChemo[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A131BR_Medication_InpatientChemo", A131BR_Medication_InpatientChemo);
            n131BR_Medication_InpatientChemo = T000H3_n131BR_Medication_InpatientChemo[0];
            A19BR_EncounterID = T000H3_A19BR_EncounterID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A19BR_EncounterID", StringUtil.LTrim( StringUtil.Str( (decimal)(A19BR_EncounterID), 18, 0)));
            Z119BR_MedicationID = A119BR_MedicationID;
            sMode18 = Gx_mode;
            Gx_mode = "DSP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
            Load0H18( ) ;
            if ( AnyError == 1 )
            {
               RcdFound18 = 0;
               InitializeNonKey0H18( ) ;
            }
            Gx_mode = sMode18;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         }
         else
         {
            RcdFound18 = 0;
            InitializeNonKey0H18( ) ;
            sMode18 = Gx_mode;
            Gx_mode = "DSP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
            standaloneModal( ) ;
            Gx_mode = sMode18;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         }
         pr_default.close(1);
      }

      protected void getEqualNoModal( )
      {
         GetKey0H18( ) ;
         if ( RcdFound18 == 0 )
         {
         }
         else
         {
         }
         getByPrimaryKey( ) ;
      }

      protected void move_next( )
      {
         RcdFound18 = 0;
         /* Using cursor T000H10 */
         pr_default.execute(8, new Object[] {n119BR_MedicationID, A119BR_MedicationID});
         if ( (pr_default.getStatus(8) != 101) )
         {
            while ( (pr_default.getStatus(8) != 101) && ( ( T000H10_A119BR_MedicationID[0] < A119BR_MedicationID ) ) )
            {
               pr_default.readNext(8);
            }
            if ( (pr_default.getStatus(8) != 101) && ( ( T000H10_A119BR_MedicationID[0] > A119BR_MedicationID ) ) )
            {
               A119BR_MedicationID = T000H10_A119BR_MedicationID[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A119BR_MedicationID", StringUtil.LTrim( StringUtil.Str( (decimal)(A119BR_MedicationID), 18, 0)));
               n119BR_MedicationID = T000H10_n119BR_MedicationID[0];
               RcdFound18 = 1;
            }
         }
         pr_default.close(8);
      }

      protected void move_previous( )
      {
         RcdFound18 = 0;
         /* Using cursor T000H11 */
         pr_default.execute(9, new Object[] {n119BR_MedicationID, A119BR_MedicationID});
         if ( (pr_default.getStatus(9) != 101) )
         {
            while ( (pr_default.getStatus(9) != 101) && ( ( T000H11_A119BR_MedicationID[0] > A119BR_MedicationID ) ) )
            {
               pr_default.readNext(9);
            }
            if ( (pr_default.getStatus(9) != 101) && ( ( T000H11_A119BR_MedicationID[0] < A119BR_MedicationID ) ) )
            {
               A119BR_MedicationID = T000H11_A119BR_MedicationID[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A119BR_MedicationID", StringUtil.LTrim( StringUtil.Str( (decimal)(A119BR_MedicationID), 18, 0)));
               n119BR_MedicationID = T000H11_n119BR_MedicationID[0];
               RcdFound18 = 1;
            }
         }
         pr_default.close(9);
      }

      protected void btn_enter( )
      {
         nKeyPressed = 1;
         GetKey0H18( ) ;
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            /* Insert record */
            GX_FocusControl = dynBR_Medication_RXName_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            Insert0H18( ) ;
            if ( AnyError == 1 )
            {
               GX_FocusControl = "";
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
         }
         else
         {
            if ( RcdFound18 == 1 )
            {
               if ( A119BR_MedicationID != Z119BR_MedicationID )
               {
                  A119BR_MedicationID = Z119BR_MedicationID;
                  n119BR_MedicationID = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A119BR_MedicationID", StringUtil.LTrim( StringUtil.Str( (decimal)(A119BR_MedicationID), 18, 0)));
                  GX_msglist.addItem(context.GetMessage( "GXM_getbeforeupd", ""), "CandidateKeyNotFound", 1, "BR_MEDICATIONID");
                  AnyError = 1;
                  GX_FocusControl = edtBR_MedicationID_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
               else if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
               {
                  delete( ) ;
                  AfterTrn( ) ;
                  GX_FocusControl = dynBR_Medication_RXName_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
               else
               {
                  /* Update record */
                  Update0H18( ) ;
                  GX_FocusControl = dynBR_Medication_RXName_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
            }
            else
            {
               if ( A119BR_MedicationID != Z119BR_MedicationID )
               {
                  /* Insert record */
                  GX_FocusControl = dynBR_Medication_RXName_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  Insert0H18( ) ;
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
                     GX_msglist.addItem(context.GetMessage( "GXM_recdeleted", ""), 1, "BR_MEDICATIONID");
                     AnyError = 1;
                     GX_FocusControl = edtBR_MedicationID_Internalname;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  }
                  else
                  {
                     /* Insert record */
                     GX_FocusControl = dynBR_Medication_RXName_Internalname;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                     Insert0H18( ) ;
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
         if ( A119BR_MedicationID != Z119BR_MedicationID )
         {
            A119BR_MedicationID = Z119BR_MedicationID;
            n119BR_MedicationID = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A119BR_MedicationID", StringUtil.LTrim( StringUtil.Str( (decimal)(A119BR_MedicationID), 18, 0)));
            GX_msglist.addItem(context.GetMessage( "GXM_getbeforedlt", ""), 1, "BR_MEDICATIONID");
            AnyError = 1;
            GX_FocusControl = edtBR_MedicationID_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         else
         {
            delete( ) ;
            AfterTrn( ) ;
            GX_FocusControl = dynBR_Medication_RXName_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( AnyError != 0 )
         {
         }
      }

      protected void CheckOptimisticConcurrency0H18( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor T000H2 */
            pr_default.execute(0, new Object[] {n119BR_MedicationID, A119BR_MedicationID});
            if ( (pr_default.getStatus(0) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"BR_Medication"}), "RecordIsLocked", 1, "");
               AnyError = 1;
               return  ;
            }
            Gx_longc = false;
            if ( (pr_default.getStatus(0) == 101) || ( StringUtil.StrCmp(Z478BR_Medication_RXFrequency_Code, T000H2_A478BR_Medication_RXFrequency_Code[0]) != 0 ) || ( StringUtil.StrCmp(Z477BR_Medication_RXRoute_Code, T000H2_A477BR_Medication_RXRoute_Code[0]) != 0 ) || ( StringUtil.StrCmp(Z507BR_Medication_InpatientChemo_Code, T000H2_A507BR_Medication_InpatientChemo_Code[0]) != 0 ) || ( Z120BR_Medication_RXID != T000H2_A120BR_Medication_RXID[0] ) || ( StringUtil.StrCmp(Z121BR_Medication_RXName, T000H2_A121BR_Medication_RXName[0]) != 0 ) )
            {
               Gx_longc = true;
            }
            if ( Gx_longc || ( StringUtil.StrCmp(Z499BR_Medication_RXName_Code, T000H2_A499BR_Medication_RXName_Code[0]) != 0 ) || ( StringUtil.StrCmp(Z122BR_Medication_RXCode, T000H2_A122BR_Medication_RXCode[0]) != 0 ) || ( StringUtil.StrCmp(Z123BR_Medication_RXType, T000H2_A123BR_Medication_RXType[0]) != 0 ) || ( Z124BR_Medication_RXDose != T000H2_A124BR_Medication_RXDose[0] ) || ( StringUtil.StrCmp(Z125BR_Medication_RXUnit, T000H2_A125BR_Medication_RXUnit[0]) != 0 ) )
            {
               Gx_longc = true;
            }
            if ( Gx_longc || ( StringUtil.StrCmp(Z126BR_Medication_RXFrequency, T000H2_A126BR_Medication_RXFrequency[0]) != 0 ) || ( StringUtil.StrCmp(Z127BR_Medication_RXQuantity, T000H2_A127BR_Medication_RXQuantity[0]) != 0 ) || ( Z128BR_Medication_RXDaysSupply != T000H2_A128BR_Medication_RXDaysSupply[0] ) || ( StringUtil.StrCmp(Z129BR_Medication_RXRoute, T000H2_A129BR_Medication_RXRoute[0]) != 0 ) || ( Z130BR_Medication_PrescriptionDate != T000H2_A130BR_Medication_PrescriptionDate[0] ) )
            {
               Gx_longc = true;
            }
            if ( Gx_longc || ( Z132BR_Medication_AdmitStartDate != T000H2_A132BR_Medication_AdmitStartDate[0] ) || ( Z133BR_Medication_AdmitEndDate != T000H2_A133BR_Medication_AdmitEndDate[0] ) || ( StringUtil.StrCmp(Z131BR_Medication_InpatientChemo, T000H2_A131BR_Medication_InpatientChemo[0]) != 0 ) || ( Z19BR_EncounterID != T000H2_A19BR_EncounterID[0] ) )
            {
               if ( StringUtil.StrCmp(Z478BR_Medication_RXFrequency_Code, T000H2_A478BR_Medication_RXFrequency_Code[0]) != 0 )
               {
                  GXUtil.WriteLog("br_medication:[seudo value changed for attri]"+"BR_Medication_RXFrequency_Code");
                  GXUtil.WriteLogRaw("Old: ",Z478BR_Medication_RXFrequency_Code);
                  GXUtil.WriteLogRaw("Current: ",T000H2_A478BR_Medication_RXFrequency_Code[0]);
               }
               if ( StringUtil.StrCmp(Z477BR_Medication_RXRoute_Code, T000H2_A477BR_Medication_RXRoute_Code[0]) != 0 )
               {
                  GXUtil.WriteLog("br_medication:[seudo value changed for attri]"+"BR_Medication_RXRoute_Code");
                  GXUtil.WriteLogRaw("Old: ",Z477BR_Medication_RXRoute_Code);
                  GXUtil.WriteLogRaw("Current: ",T000H2_A477BR_Medication_RXRoute_Code[0]);
               }
               if ( StringUtil.StrCmp(Z507BR_Medication_InpatientChemo_Code, T000H2_A507BR_Medication_InpatientChemo_Code[0]) != 0 )
               {
                  GXUtil.WriteLog("br_medication:[seudo value changed for attri]"+"BR_Medication_InpatientChemo_Code");
                  GXUtil.WriteLogRaw("Old: ",Z507BR_Medication_InpatientChemo_Code);
                  GXUtil.WriteLogRaw("Current: ",T000H2_A507BR_Medication_InpatientChemo_Code[0]);
               }
               if ( Z120BR_Medication_RXID != T000H2_A120BR_Medication_RXID[0] )
               {
                  GXUtil.WriteLog("br_medication:[seudo value changed for attri]"+"BR_Medication_RXID");
                  GXUtil.WriteLogRaw("Old: ",Z120BR_Medication_RXID);
                  GXUtil.WriteLogRaw("Current: ",T000H2_A120BR_Medication_RXID[0]);
               }
               if ( StringUtil.StrCmp(Z121BR_Medication_RXName, T000H2_A121BR_Medication_RXName[0]) != 0 )
               {
                  GXUtil.WriteLog("br_medication:[seudo value changed for attri]"+"BR_Medication_RXName");
                  GXUtil.WriteLogRaw("Old: ",Z121BR_Medication_RXName);
                  GXUtil.WriteLogRaw("Current: ",T000H2_A121BR_Medication_RXName[0]);
               }
               if ( StringUtil.StrCmp(Z499BR_Medication_RXName_Code, T000H2_A499BR_Medication_RXName_Code[0]) != 0 )
               {
                  GXUtil.WriteLog("br_medication:[seudo value changed for attri]"+"BR_Medication_RXName_Code");
                  GXUtil.WriteLogRaw("Old: ",Z499BR_Medication_RXName_Code);
                  GXUtil.WriteLogRaw("Current: ",T000H2_A499BR_Medication_RXName_Code[0]);
               }
               if ( StringUtil.StrCmp(Z122BR_Medication_RXCode, T000H2_A122BR_Medication_RXCode[0]) != 0 )
               {
                  GXUtil.WriteLog("br_medication:[seudo value changed for attri]"+"BR_Medication_RXCode");
                  GXUtil.WriteLogRaw("Old: ",Z122BR_Medication_RXCode);
                  GXUtil.WriteLogRaw("Current: ",T000H2_A122BR_Medication_RXCode[0]);
               }
               if ( StringUtil.StrCmp(Z123BR_Medication_RXType, T000H2_A123BR_Medication_RXType[0]) != 0 )
               {
                  GXUtil.WriteLog("br_medication:[seudo value changed for attri]"+"BR_Medication_RXType");
                  GXUtil.WriteLogRaw("Old: ",Z123BR_Medication_RXType);
                  GXUtil.WriteLogRaw("Current: ",T000H2_A123BR_Medication_RXType[0]);
               }
               if ( Z124BR_Medication_RXDose != T000H2_A124BR_Medication_RXDose[0] )
               {
                  GXUtil.WriteLog("br_medication:[seudo value changed for attri]"+"BR_Medication_RXDose");
                  GXUtil.WriteLogRaw("Old: ",Z124BR_Medication_RXDose);
                  GXUtil.WriteLogRaw("Current: ",T000H2_A124BR_Medication_RXDose[0]);
               }
               if ( StringUtil.StrCmp(Z125BR_Medication_RXUnit, T000H2_A125BR_Medication_RXUnit[0]) != 0 )
               {
                  GXUtil.WriteLog("br_medication:[seudo value changed for attri]"+"BR_Medication_RXUnit");
                  GXUtil.WriteLogRaw("Old: ",Z125BR_Medication_RXUnit);
                  GXUtil.WriteLogRaw("Current: ",T000H2_A125BR_Medication_RXUnit[0]);
               }
               if ( StringUtil.StrCmp(Z126BR_Medication_RXFrequency, T000H2_A126BR_Medication_RXFrequency[0]) != 0 )
               {
                  GXUtil.WriteLog("br_medication:[seudo value changed for attri]"+"BR_Medication_RXFrequency");
                  GXUtil.WriteLogRaw("Old: ",Z126BR_Medication_RXFrequency);
                  GXUtil.WriteLogRaw("Current: ",T000H2_A126BR_Medication_RXFrequency[0]);
               }
               if ( StringUtil.StrCmp(Z127BR_Medication_RXQuantity, T000H2_A127BR_Medication_RXQuantity[0]) != 0 )
               {
                  GXUtil.WriteLog("br_medication:[seudo value changed for attri]"+"BR_Medication_RXQuantity");
                  GXUtil.WriteLogRaw("Old: ",Z127BR_Medication_RXQuantity);
                  GXUtil.WriteLogRaw("Current: ",T000H2_A127BR_Medication_RXQuantity[0]);
               }
               if ( Z128BR_Medication_RXDaysSupply != T000H2_A128BR_Medication_RXDaysSupply[0] )
               {
                  GXUtil.WriteLog("br_medication:[seudo value changed for attri]"+"BR_Medication_RXDaysSupply");
                  GXUtil.WriteLogRaw("Old: ",Z128BR_Medication_RXDaysSupply);
                  GXUtil.WriteLogRaw("Current: ",T000H2_A128BR_Medication_RXDaysSupply[0]);
               }
               if ( StringUtil.StrCmp(Z129BR_Medication_RXRoute, T000H2_A129BR_Medication_RXRoute[0]) != 0 )
               {
                  GXUtil.WriteLog("br_medication:[seudo value changed for attri]"+"BR_Medication_RXRoute");
                  GXUtil.WriteLogRaw("Old: ",Z129BR_Medication_RXRoute);
                  GXUtil.WriteLogRaw("Current: ",T000H2_A129BR_Medication_RXRoute[0]);
               }
               if ( Z130BR_Medication_PrescriptionDate != T000H2_A130BR_Medication_PrescriptionDate[0] )
               {
                  GXUtil.WriteLog("br_medication:[seudo value changed for attri]"+"BR_Medication_PrescriptionDate");
                  GXUtil.WriteLogRaw("Old: ",Z130BR_Medication_PrescriptionDate);
                  GXUtil.WriteLogRaw("Current: ",T000H2_A130BR_Medication_PrescriptionDate[0]);
               }
               if ( Z132BR_Medication_AdmitStartDate != T000H2_A132BR_Medication_AdmitStartDate[0] )
               {
                  GXUtil.WriteLog("br_medication:[seudo value changed for attri]"+"BR_Medication_AdmitStartDate");
                  GXUtil.WriteLogRaw("Old: ",Z132BR_Medication_AdmitStartDate);
                  GXUtil.WriteLogRaw("Current: ",T000H2_A132BR_Medication_AdmitStartDate[0]);
               }
               if ( Z133BR_Medication_AdmitEndDate != T000H2_A133BR_Medication_AdmitEndDate[0] )
               {
                  GXUtil.WriteLog("br_medication:[seudo value changed for attri]"+"BR_Medication_AdmitEndDate");
                  GXUtil.WriteLogRaw("Old: ",Z133BR_Medication_AdmitEndDate);
                  GXUtil.WriteLogRaw("Current: ",T000H2_A133BR_Medication_AdmitEndDate[0]);
               }
               if ( StringUtil.StrCmp(Z131BR_Medication_InpatientChemo, T000H2_A131BR_Medication_InpatientChemo[0]) != 0 )
               {
                  GXUtil.WriteLog("br_medication:[seudo value changed for attri]"+"BR_Medication_InpatientChemo");
                  GXUtil.WriteLogRaw("Old: ",Z131BR_Medication_InpatientChemo);
                  GXUtil.WriteLogRaw("Current: ",T000H2_A131BR_Medication_InpatientChemo[0]);
               }
               if ( Z19BR_EncounterID != T000H2_A19BR_EncounterID[0] )
               {
                  GXUtil.WriteLog("br_medication:[seudo value changed for attri]"+"BR_EncounterID");
                  GXUtil.WriteLogRaw("Old: ",Z19BR_EncounterID);
                  GXUtil.WriteLogRaw("Current: ",T000H2_A19BR_EncounterID[0]);
               }
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
                     /* Using cursor T000H12 */
                     pr_default.execute(10, new Object[] {n478BR_Medication_RXFrequency_Code, A478BR_Medication_RXFrequency_Code, n477BR_Medication_RXRoute_Code, A477BR_Medication_RXRoute_Code, n507BR_Medication_InpatientChemo_Code, A507BR_Medication_InpatientChemo_Code, n120BR_Medication_RXID, A120BR_Medication_RXID, n121BR_Medication_RXName, A121BR_Medication_RXName, n499BR_Medication_RXName_Code, A499BR_Medication_RXName_Code, n122BR_Medication_RXCode, A122BR_Medication_RXCode, n123BR_Medication_RXType, A123BR_Medication_RXType, n124BR_Medication_RXDose, A124BR_Medication_RXDose, n125BR_Medication_RXUnit, A125BR_Medication_RXUnit, n126BR_Medication_RXFrequency, A126BR_Medication_RXFrequency, n127BR_Medication_RXQuantity, A127BR_Medication_RXQuantity, n128BR_Medication_RXDaysSupply, A128BR_Medication_RXDaysSupply, n129BR_Medication_RXRoute, A129BR_Medication_RXRoute, n130BR_Medication_PrescriptionDate, A130BR_Medication_PrescriptionDate, n132BR_Medication_AdmitStartDate, A132BR_Medication_AdmitStartDate, n133BR_Medication_AdmitEndDate, A133BR_Medication_AdmitEndDate, n131BR_Medication_InpatientChemo, A131BR_Medication_InpatientChemo, A19BR_EncounterID});
                     A119BR_MedicationID = T000H12_A119BR_MedicationID[0];
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A119BR_MedicationID", StringUtil.LTrim( StringUtil.Str( (decimal)(A119BR_MedicationID), 18, 0)));
                     n119BR_MedicationID = T000H12_n119BR_MedicationID[0];
                     pr_default.close(10);
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
                           ResetCaption0H0( ) ;
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
                     /* Using cursor T000H13 */
                     pr_default.execute(11, new Object[] {n478BR_Medication_RXFrequency_Code, A478BR_Medication_RXFrequency_Code, n477BR_Medication_RXRoute_Code, A477BR_Medication_RXRoute_Code, n507BR_Medication_InpatientChemo_Code, A507BR_Medication_InpatientChemo_Code, n120BR_Medication_RXID, A120BR_Medication_RXID, n121BR_Medication_RXName, A121BR_Medication_RXName, n499BR_Medication_RXName_Code, A499BR_Medication_RXName_Code, n122BR_Medication_RXCode, A122BR_Medication_RXCode, n123BR_Medication_RXType, A123BR_Medication_RXType, n124BR_Medication_RXDose, A124BR_Medication_RXDose, n125BR_Medication_RXUnit, A125BR_Medication_RXUnit, n126BR_Medication_RXFrequency, A126BR_Medication_RXFrequency, n127BR_Medication_RXQuantity, A127BR_Medication_RXQuantity, n128BR_Medication_RXDaysSupply, A128BR_Medication_RXDaysSupply, n129BR_Medication_RXRoute, A129BR_Medication_RXRoute, n130BR_Medication_PrescriptionDate, A130BR_Medication_PrescriptionDate, n132BR_Medication_AdmitStartDate, A132BR_Medication_AdmitStartDate, n133BR_Medication_AdmitEndDate, A133BR_Medication_AdmitEndDate, n131BR_Medication_InpatientChemo, A131BR_Medication_InpatientChemo, A19BR_EncounterID, n119BR_MedicationID, A119BR_MedicationID});
                     pr_default.close(11);
                     dsDefault.SmartCacheProvider.SetUpdated("BR_Medication") ;
                     if ( (pr_default.getStatus(11) == 103) )
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
            EndLevel0H18( ) ;
         }
         CloseExtendedTableCursors0H18( ) ;
      }

      protected void DeferredUpdate0H18( )
      {
      }

      protected void delete( )
      {
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
                  /* Using cursor T000H14 */
                  pr_default.execute(12, new Object[] {n119BR_MedicationID, A119BR_MedicationID});
                  pr_default.close(12);
                  dsDefault.SmartCacheProvider.SetUpdated("BR_Medication") ;
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
         sMode18 = Gx_mode;
         Gx_mode = "DLT";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         EndLevel0H18( ) ;
         Gx_mode = sMode18;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
      }

      protected void OnDeleteControls0H18( )
      {
         standaloneModal( ) ;
         if ( AnyError == 0 )
         {
            /* Delete mode formulas */
            AV22Pgmname = "BR_Medication";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV22Pgmname", AV22Pgmname);
            /* Using cursor T000H15 */
            pr_default.execute(13, new Object[] {A19BR_EncounterID});
            A85BR_Information_ID = T000H15_A85BR_Information_ID[0];
            n85BR_Information_ID = T000H15_n85BR_Information_ID[0];
            pr_default.close(13);
            /* Using cursor T000H16 */
            pr_default.execute(14, new Object[] {n85BR_Information_ID, A85BR_Information_ID});
            A36BR_Information_PatientNo = T000H16_A36BR_Information_PatientNo[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A36BR_Information_PatientNo", A36BR_Information_PatientNo);
            n36BR_Information_PatientNo = T000H16_n36BR_Information_PatientNo[0];
            pr_default.close(14);
            edtavVmedicationname_Visible = ((StringUtil.StrCmp(A121BR_Medication_RXName, "其它")==0) ? 1 : 0);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavVmedicationname_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavVmedicationname_Visible), 5, 0)), true);
            if ( ! ( ( StringUtil.StrCmp(A121BR_Medication_RXName, "其它") == 0 ) ) )
            {
               cellVmedicationname_cell_Class = "Invisible";
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, cellVmedicationname_cell_Internalname, "Class", cellVmedicationname_cell_Class, true);
            }
            else
            {
               if ( StringUtil.StrCmp(A121BR_Medication_RXName, "其它") == 0 )
               {
                  cellVmedicationname_cell_Class = "RequiredDataContentCell";
                  context.httpAjaxContext.ajax_rsp_assign_prop("", false, cellVmedicationname_cell_Internalname, "Class", cellVmedicationname_cell_Class, true);
               }
            }
            edtavVfrequency_Visible = ((StringUtil.StrCmp(A126BR_Medication_RXFrequency, "其它")==0) ? 1 : 0);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavVfrequency_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavVfrequency_Visible), 5, 0)), true);
            if ( ! ( ( StringUtil.StrCmp(A126BR_Medication_RXFrequency, "其它") == 0 ) ) )
            {
               cellVfrequency_cell_Class = "Invisible";
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, cellVfrequency_cell_Internalname, "Class", cellVfrequency_cell_Class, true);
            }
            else
            {
               if ( StringUtil.StrCmp(A126BR_Medication_RXFrequency, "其它") == 0 )
               {
                  cellVfrequency_cell_Class = "RequiredDataContentCell";
                  context.httpAjaxContext.ajax_rsp_assign_prop("", false, cellVfrequency_cell_Internalname, "Class", cellVfrequency_cell_Class, true);
               }
            }
            edtavVrxroute_Visible = ((StringUtil.StrCmp(A129BR_Medication_RXRoute, "其它")==0) ? 1 : 0);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavVrxroute_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavVrxroute_Visible), 5, 0)), true);
            if ( ! ( ( StringUtil.StrCmp(A129BR_Medication_RXRoute, "其它") == 0 ) ) )
            {
               cellVrxroute_cell_Class = "Invisible";
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, cellVrxroute_cell_Internalname, "Class", cellVrxroute_cell_Class, true);
            }
            else
            {
               if ( StringUtil.StrCmp(A129BR_Medication_RXRoute, "其它") == 0 )
               {
                  cellVrxroute_cell_Class = "RequiredDataContentCell";
                  context.httpAjaxContext.ajax_rsp_assign_prop("", false, cellVrxroute_cell_Internalname, "Class", cellVrxroute_cell_Class, true);
               }
            }
         }
         if ( AnyError == 0 )
         {
            /* Using cursor T000H17 */
            pr_default.execute(15, new Object[] {n119BR_MedicationID, A119BR_MedicationID});
            if ( (pr_default.getStatus(15) != 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_del", new   object[]  {" T40"}), "CannotDeleteReferencedRecord", 1, "");
               AnyError = 1;
            }
            pr_default.close(15);
            /* Using cursor T000H18 */
            pr_default.execute(16, new Object[] {n119BR_MedicationID, A119BR_MedicationID});
            if ( (pr_default.getStatus(16) != 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_del", new   object[]  {" T32"}), "CannotDeleteReferencedRecord", 1, "");
               AnyError = 1;
            }
            pr_default.close(16);
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
            pr_default.close(1);
            pr_default.close(13);
            pr_default.close(14);
            context.CommitDataStores("br_medication",pr_default);
            if ( AnyError == 0 )
            {
               ConfirmValues0H0( ) ;
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
            context.RollbackDataStores("br_medication",pr_default);
         }
         IsModified = 0;
         if ( AnyError != 0 )
         {
            context.wjLoc = "";
            context.nUserReturn = 0;
         }
      }

      public void ScanStart0H18( )
      {
         /* Scan By routine */
         /* Using cursor T000H19 */
         pr_default.execute(17);
         RcdFound18 = 0;
         if ( (pr_default.getStatus(17) != 101) )
         {
            RcdFound18 = 1;
            A119BR_MedicationID = T000H19_A119BR_MedicationID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A119BR_MedicationID", StringUtil.LTrim( StringUtil.Str( (decimal)(A119BR_MedicationID), 18, 0)));
            n119BR_MedicationID = T000H19_n119BR_MedicationID[0];
         }
         /* Load Subordinate Levels */
      }

      protected void ScanNext0H18( )
      {
         /* Scan next routine */
         pr_default.readNext(17);
         RcdFound18 = 0;
         if ( (pr_default.getStatus(17) != 101) )
         {
            RcdFound18 = 1;
            A119BR_MedicationID = T000H19_A119BR_MedicationID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A119BR_MedicationID", StringUtil.LTrim( StringUtil.Str( (decimal)(A119BR_MedicationID), 18, 0)));
            n119BR_MedicationID = T000H19_n119BR_MedicationID[0];
         }
      }

      protected void ScanEnd0H18( )
      {
         pr_default.close(17);
      }

      protected void AfterConfirm0H18( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert0H18( )
      {
         /* Before Insert Rules */
         GXt_char1 = A507BR_Medication_InpatientChemo_Code;
         new zutil_findtargetcode(context ).execute(  37,  A131BR_Medication_InpatientChemo, out  GXt_char1) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A131BR_Medication_InpatientChemo", A131BR_Medication_InpatientChemo);
         A507BR_Medication_InpatientChemo_Code = GXt_char1;
         n507BR_Medication_InpatientChemo_Code = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A507BR_Medication_InpatientChemo_Code", A507BR_Medication_InpatientChemo_Code);
         if ( ( StringUtil.StrCmp(A126BR_Medication_RXFrequency, "其它") == 0 ) && ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) )
         {
            A126BR_Medication_RXFrequency = AV19vFrequency;
            n126BR_Medication_RXFrequency = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A126BR_Medication_RXFrequency", A126BR_Medication_RXFrequency);
         }
         GXt_char1 = A478BR_Medication_RXFrequency_Code;
         new zutil_findtargetcode(context ).execute(  25,  A126BR_Medication_RXFrequency, out  GXt_char1) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A126BR_Medication_RXFrequency", A126BR_Medication_RXFrequency);
         A478BR_Medication_RXFrequency_Code = GXt_char1;
         n478BR_Medication_RXFrequency_Code = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A478BR_Medication_RXFrequency_Code", A478BR_Medication_RXFrequency_Code);
         if ( ( StringUtil.StrCmp(A129BR_Medication_RXRoute, "其它") == 0 ) && ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) )
         {
            A129BR_Medication_RXRoute = AV15vRXRoute;
            n129BR_Medication_RXRoute = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A129BR_Medication_RXRoute", A129BR_Medication_RXRoute);
         }
         GXt_char1 = A477BR_Medication_RXRoute_Code;
         new zutil_findtargetcode(context ).execute(  26,  A129BR_Medication_RXRoute, out  GXt_char1) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A129BR_Medication_RXRoute", A129BR_Medication_RXRoute);
         A477BR_Medication_RXRoute_Code = GXt_char1;
         n477BR_Medication_RXRoute_Code = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A477BR_Medication_RXRoute_Code", A477BR_Medication_RXRoute_Code);
         if ( ( StringUtil.StrCmp(A121BR_Medication_RXName, "其它") == 0 ) && ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) )
         {
            A121BR_Medication_RXName = AV20vMedicationName;
            n121BR_Medication_RXName = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A121BR_Medication_RXName", A121BR_Medication_RXName);
         }
      }

      protected void BeforeUpdate0H18( )
      {
         /* Before Update Rules */
         GXt_char1 = A478BR_Medication_RXFrequency_Code;
         new zutil_findtargetcode(context ).execute(  25,  A126BR_Medication_RXFrequency, out  GXt_char1) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A126BR_Medication_RXFrequency", A126BR_Medication_RXFrequency);
         A478BR_Medication_RXFrequency_Code = GXt_char1;
         n478BR_Medication_RXFrequency_Code = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A478BR_Medication_RXFrequency_Code", A478BR_Medication_RXFrequency_Code);
         GXt_char1 = A477BR_Medication_RXRoute_Code;
         new zutil_findtargetcode(context ).execute(  26,  A129BR_Medication_RXRoute, out  GXt_char1) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A129BR_Medication_RXRoute", A129BR_Medication_RXRoute);
         A477BR_Medication_RXRoute_Code = GXt_char1;
         n477BR_Medication_RXRoute_Code = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A477BR_Medication_RXRoute_Code", A477BR_Medication_RXRoute_Code);
         GXt_char1 = A507BR_Medication_InpatientChemo_Code;
         new zutil_findtargetcode(context ).execute(  37,  A131BR_Medication_InpatientChemo, out  GXt_char1) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A131BR_Medication_InpatientChemo", A131BR_Medication_InpatientChemo);
         A507BR_Medication_InpatientChemo_Code = GXt_char1;
         n507BR_Medication_InpatientChemo_Code = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A507BR_Medication_InpatientChemo_Code", A507BR_Medication_InpatientChemo_Code);
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
         dynBR_Medication_RXName.Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynBR_Medication_RXName_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(dynBR_Medication_RXName.Enabled), 5, 0)), true);
         edtavVmedicationname_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavVmedicationname_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavVmedicationname_Enabled), 5, 0)), true);
         edtBR_Medication_RXCode_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Medication_RXCode_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBR_Medication_RXCode_Enabled), 5, 0)), true);
         edtBR_Medication_RXType_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Medication_RXType_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBR_Medication_RXType_Enabled), 5, 0)), true);
         edtBR_Medication_RXDose_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Medication_RXDose_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBR_Medication_RXDose_Enabled), 5, 0)), true);
         edtBR_Medication_RXUnit_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Medication_RXUnit_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBR_Medication_RXUnit_Enabled), 5, 0)), true);
         dynBR_Medication_RXFrequency.Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynBR_Medication_RXFrequency_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(dynBR_Medication_RXFrequency.Enabled), 5, 0)), true);
         edtavVfrequency_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavVfrequency_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavVfrequency_Enabled), 5, 0)), true);
         edtBR_Medication_RXQuantity_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Medication_RXQuantity_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBR_Medication_RXQuantity_Enabled), 5, 0)), true);
         edtBR_Medication_RXDaysSupply_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Medication_RXDaysSupply_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBR_Medication_RXDaysSupply_Enabled), 5, 0)), true);
         dynBR_Medication_RXRoute.Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynBR_Medication_RXRoute_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(dynBR_Medication_RXRoute.Enabled), 5, 0)), true);
         edtavVrxroute_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavVrxroute_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavVrxroute_Enabled), 5, 0)), true);
         edtBR_Medication_PrescriptionDate_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Medication_PrescriptionDate_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBR_Medication_PrescriptionDate_Enabled), 5, 0)), true);
         edtBR_Medication_AdmitStartDate_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Medication_AdmitStartDate_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBR_Medication_AdmitStartDate_Enabled), 5, 0)), true);
         edtBR_Medication_AdmitEndDate_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Medication_AdmitEndDate_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBR_Medication_AdmitEndDate_Enabled), 5, 0)), true);
         cmbBR_Medication_InpatientChemo.Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbBR_Medication_InpatientChemo_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(cmbBR_Medication_InpatientChemo.Enabled), 5, 0)), true);
         edtBR_MedicationID_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_MedicationID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBR_MedicationID_Enabled), 5, 0)), true);
         edtBR_EncounterID_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_EncounterID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBR_EncounterID_Enabled), 5, 0)), true);
         edtBR_Information_PatientNo_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Information_PatientNo_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBR_Information_PatientNo_Enabled), 5, 0)), true);
      }

      protected void send_integrity_lvl_hashes0H18( )
      {
      }

      protected void assign_properties_default( )
      {
      }

      protected void ConfirmValues0H0( )
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
         context.AddJavascriptSource("gxcfg.js", "?2020228157201", false);
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" autocomplete=\"off\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("br_medication.aspx") + "?" + UrlEncode(StringUtil.RTrim(Gx_mode)) + "," + UrlEncode("" +AV12BR_MedicationID)+"\">") ;
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
         forbiddenHiddens = "hsh" + "BR_Medication";
         forbiddenHiddens = forbiddenHiddens + context.localUtil.Format( (decimal)(A119BR_MedicationID), "ZZZZZZZZZZZZZZZZZZ");
         forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( AV21tCurrentCode, ""));
         forbiddenHiddens = forbiddenHiddens + context.localUtil.Format( (decimal)(AV10Insert_BR_EncounterID), "ZZZZZZZZZZZZZZZZZZ");
         forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!"));
         forbiddenHiddens = forbiddenHiddens + context.localUtil.Format( (decimal)(A120BR_Medication_RXID), "ZZZZ");
         forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( A499BR_Medication_RXName_Code, ""));
         GxWebStd.gx_hidden_field( context, "hsh", GetEncryptedHash( forbiddenHiddens, GXKey));
         GXUtil.WriteLog("br_medication:[SendSecurityCheck value for]"+"BR_MedicationID:"+context.localUtil.Format( (decimal)(A119BR_MedicationID), "ZZZZZZZZZZZZZZZZZZ"));
         GXUtil.WriteLog("br_medication:[SendSecurityCheck value for]"+"tCurrentCode:"+StringUtil.RTrim( context.localUtil.Format( AV21tCurrentCode, "")));
         GXUtil.WriteLog("br_medication:[SendSecurityCheck value for]"+"Insert_BR_EncounterID:"+context.localUtil.Format( (decimal)(AV10Insert_BR_EncounterID), "ZZZZZZZZZZZZZZZZZZ"));
         GXUtil.WriteLog("br_medication:[SendSecurityCheck value for]"+"Gx_mode:"+StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")));
         GXUtil.WriteLog("br_medication:[SendSecurityCheck value for]"+"BR_Medication_RXID:"+context.localUtil.Format( (decimal)(A120BR_Medication_RXID), "ZZZZ"));
         GXUtil.WriteLog("br_medication:[SendSecurityCheck value for]"+"BR_Medication_RXName_Code:"+StringUtil.RTrim( context.localUtil.Format( A499BR_Medication_RXName_Code, "")));
      }

      protected void SendCloseFormHiddens( )
      {
         /* Send hidden variables. */
         /* Send saved values. */
         send_integrity_footer_hashes( ) ;
         GxWebStd.gx_hidden_field( context, "Z119BR_MedicationID", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z119BR_MedicationID), 18, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "Z478BR_Medication_RXFrequency_Code", Z478BR_Medication_RXFrequency_Code);
         GxWebStd.gx_hidden_field( context, "Z477BR_Medication_RXRoute_Code", Z477BR_Medication_RXRoute_Code);
         GxWebStd.gx_hidden_field( context, "Z507BR_Medication_InpatientChemo_Code", Z507BR_Medication_InpatientChemo_Code);
         GxWebStd.gx_hidden_field( context, "Z120BR_Medication_RXID", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z120BR_Medication_RXID), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "Z121BR_Medication_RXName", Z121BR_Medication_RXName);
         GxWebStd.gx_hidden_field( context, "Z499BR_Medication_RXName_Code", Z499BR_Medication_RXName_Code);
         GxWebStd.gx_hidden_field( context, "Z122BR_Medication_RXCode", Z122BR_Medication_RXCode);
         GxWebStd.gx_hidden_field( context, "Z123BR_Medication_RXType", Z123BR_Medication_RXType);
         GxWebStd.gx_hidden_field( context, "Z124BR_Medication_RXDose", StringUtil.LTrim( StringUtil.NToC( Z124BR_Medication_RXDose, 15, 5, ".", "")));
         GxWebStd.gx_hidden_field( context, "Z125BR_Medication_RXUnit", Z125BR_Medication_RXUnit);
         GxWebStd.gx_hidden_field( context, "Z126BR_Medication_RXFrequency", Z126BR_Medication_RXFrequency);
         GxWebStd.gx_hidden_field( context, "Z127BR_Medication_RXQuantity", Z127BR_Medication_RXQuantity);
         GxWebStd.gx_hidden_field( context, "Z128BR_Medication_RXDaysSupply", StringUtil.LTrim( StringUtil.NToC( Z128BR_Medication_RXDaysSupply, 15, 5, ".", "")));
         GxWebStd.gx_hidden_field( context, "Z129BR_Medication_RXRoute", Z129BR_Medication_RXRoute);
         GxWebStd.gx_hidden_field( context, "Z130BR_Medication_PrescriptionDate", context.localUtil.DToC( Z130BR_Medication_PrescriptionDate, 0, "/"));
         GxWebStd.gx_hidden_field( context, "Z132BR_Medication_AdmitStartDate", context.localUtil.DToC( Z132BR_Medication_AdmitStartDate, 0, "/"));
         GxWebStd.gx_hidden_field( context, "Z133BR_Medication_AdmitEndDate", context.localUtil.DToC( Z133BR_Medication_AdmitEndDate, 0, "/"));
         GxWebStd.gx_hidden_field( context, "Z131BR_Medication_InpatientChemo", Z131BR_Medication_InpatientChemo);
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
         GxWebStd.gx_hidden_field( context, "vBR_MEDICATIONID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV12BR_MedicationID), 18, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "gxhash_vBR_MEDICATIONID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV12BR_MedicationID), "ZZZZZZZZZZZZZZZZZZ"), context));
         GxWebStd.gx_hidden_field( context, "vINSERT_BR_ENCOUNTERID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV10Insert_BR_EncounterID), 18, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "BR_MEDICATION_RXFREQUENCY_CODE", A478BR_Medication_RXFrequency_Code);
         GxWebStd.gx_hidden_field( context, "BR_MEDICATION_RXROUTE_CODE", A477BR_Medication_RXRoute_Code);
         GxWebStd.gx_hidden_field( context, "BR_MEDICATION_INPATIENTCHEMO_CODE", A507BR_Medication_InpatientChemo_Code);
         GxWebStd.gx_hidden_field( context, "vTCURRENTCODE", AV21tCurrentCode);
         GxWebStd.gx_hidden_field( context, "BR_MEDICATION_RXID", StringUtil.LTrim( StringUtil.NToC( (decimal)(A120BR_Medication_RXID), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "BR_MEDICATION_RXNAME_CODE", A499BR_Medication_RXName_Code);
         GxWebStd.gx_hidden_field( context, "BR_INFORMATION_ID", StringUtil.LTrim( StringUtil.NToC( (decimal)(A85BR_Information_ID), 18, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "vPGMNAME", StringUtil.RTrim( AV22Pgmname));
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
         return formatLink("br_medication.aspx") + "?" + UrlEncode(StringUtil.RTrim(Gx_mode)) + "," + UrlEncode("" +AV12BR_MedicationID) ;
      }

      public override String GetPgmname( )
      {
         return "BR_Medication" ;
      }

      public override String GetPgmdesc( )
      {
         return "Data Mgmt Portal - RAAP" ;
      }

      protected void InitializeNonKey0H18( )
      {
         A85BR_Information_ID = 0;
         n85BR_Information_ID = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A85BR_Information_ID", StringUtil.LTrim( StringUtil.Str( (decimal)(A85BR_Information_ID), 18, 0)));
         A19BR_EncounterID = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A19BR_EncounterID", StringUtil.LTrim( StringUtil.Str( (decimal)(A19BR_EncounterID), 18, 0)));
         AV20vMedicationName = "";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV20vMedicationName", AV20vMedicationName);
         AV19vFrequency = "";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV19vFrequency", AV19vFrequency);
         AV15vRXRoute = "";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV15vRXRoute", AV15vRXRoute);
         A478BR_Medication_RXFrequency_Code = "";
         n478BR_Medication_RXFrequency_Code = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A478BR_Medication_RXFrequency_Code", A478BR_Medication_RXFrequency_Code);
         A477BR_Medication_RXRoute_Code = "";
         n477BR_Medication_RXRoute_Code = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A477BR_Medication_RXRoute_Code", A477BR_Medication_RXRoute_Code);
         A507BR_Medication_InpatientChemo_Code = "";
         n507BR_Medication_InpatientChemo_Code = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A507BR_Medication_InpatientChemo_Code", A507BR_Medication_InpatientChemo_Code);
         A36BR_Information_PatientNo = "";
         n36BR_Information_PatientNo = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A36BR_Information_PatientNo", A36BR_Information_PatientNo);
         A120BR_Medication_RXID = 0;
         n120BR_Medication_RXID = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A120BR_Medication_RXID", StringUtil.LTrim( StringUtil.Str( (decimal)(A120BR_Medication_RXID), 4, 0)));
         A121BR_Medication_RXName = "";
         n121BR_Medication_RXName = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A121BR_Medication_RXName", A121BR_Medication_RXName);
         n121BR_Medication_RXName = (String.IsNullOrEmpty(StringUtil.RTrim( A121BR_Medication_RXName)) ? true : false);
         A499BR_Medication_RXName_Code = "";
         n499BR_Medication_RXName_Code = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A499BR_Medication_RXName_Code", A499BR_Medication_RXName_Code);
         A122BR_Medication_RXCode = "";
         n122BR_Medication_RXCode = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A122BR_Medication_RXCode", A122BR_Medication_RXCode);
         n122BR_Medication_RXCode = (String.IsNullOrEmpty(StringUtil.RTrim( A122BR_Medication_RXCode)) ? true : false);
         A123BR_Medication_RXType = "";
         n123BR_Medication_RXType = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A123BR_Medication_RXType", A123BR_Medication_RXType);
         n123BR_Medication_RXType = (String.IsNullOrEmpty(StringUtil.RTrim( A123BR_Medication_RXType)) ? true : false);
         A124BR_Medication_RXDose = 0;
         n124BR_Medication_RXDose = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A124BR_Medication_RXDose", StringUtil.LTrim( StringUtil.Str( A124BR_Medication_RXDose, 15, 5)));
         n124BR_Medication_RXDose = ((Convert.ToDecimal(0)==A124BR_Medication_RXDose) ? true : false);
         A125BR_Medication_RXUnit = "";
         n125BR_Medication_RXUnit = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A125BR_Medication_RXUnit", A125BR_Medication_RXUnit);
         n125BR_Medication_RXUnit = (String.IsNullOrEmpty(StringUtil.RTrim( A125BR_Medication_RXUnit)) ? true : false);
         A126BR_Medication_RXFrequency = "";
         n126BR_Medication_RXFrequency = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A126BR_Medication_RXFrequency", A126BR_Medication_RXFrequency);
         n126BR_Medication_RXFrequency = (String.IsNullOrEmpty(StringUtil.RTrim( A126BR_Medication_RXFrequency)) ? true : false);
         A127BR_Medication_RXQuantity = "";
         n127BR_Medication_RXQuantity = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A127BR_Medication_RXQuantity", A127BR_Medication_RXQuantity);
         n127BR_Medication_RXQuantity = (String.IsNullOrEmpty(StringUtil.RTrim( A127BR_Medication_RXQuantity)) ? true : false);
         A128BR_Medication_RXDaysSupply = 0;
         n128BR_Medication_RXDaysSupply = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A128BR_Medication_RXDaysSupply", StringUtil.LTrim( StringUtil.Str( A128BR_Medication_RXDaysSupply, 15, 5)));
         n128BR_Medication_RXDaysSupply = ((Convert.ToDecimal(0)==A128BR_Medication_RXDaysSupply) ? true : false);
         A129BR_Medication_RXRoute = "";
         n129BR_Medication_RXRoute = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A129BR_Medication_RXRoute", A129BR_Medication_RXRoute);
         n129BR_Medication_RXRoute = (String.IsNullOrEmpty(StringUtil.RTrim( A129BR_Medication_RXRoute)) ? true : false);
         A130BR_Medication_PrescriptionDate = DateTime.MinValue;
         n130BR_Medication_PrescriptionDate = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A130BR_Medication_PrescriptionDate", context.localUtil.Format(A130BR_Medication_PrescriptionDate, "9999/99/99"));
         n130BR_Medication_PrescriptionDate = ((DateTime.MinValue==A130BR_Medication_PrescriptionDate) ? true : false);
         A132BR_Medication_AdmitStartDate = DateTime.MinValue;
         n132BR_Medication_AdmitStartDate = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A132BR_Medication_AdmitStartDate", context.localUtil.Format(A132BR_Medication_AdmitStartDate, "9999/99/99"));
         n132BR_Medication_AdmitStartDate = ((DateTime.MinValue==A132BR_Medication_AdmitStartDate) ? true : false);
         A133BR_Medication_AdmitEndDate = DateTime.MinValue;
         n133BR_Medication_AdmitEndDate = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A133BR_Medication_AdmitEndDate", context.localUtil.Format(A133BR_Medication_AdmitEndDate, "9999/99/99"));
         n133BR_Medication_AdmitEndDate = ((DateTime.MinValue==A133BR_Medication_AdmitEndDate) ? true : false);
         A131BR_Medication_InpatientChemo = "";
         n131BR_Medication_InpatientChemo = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A131BR_Medication_InpatientChemo", A131BR_Medication_InpatientChemo);
         n131BR_Medication_InpatientChemo = (String.IsNullOrEmpty(StringUtil.RTrim( A131BR_Medication_InpatientChemo)) ? true : false);
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
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A119BR_MedicationID", StringUtil.LTrim( StringUtil.Str( (decimal)(A119BR_MedicationID), 18, 0)));
         InitializeNonKey0H18( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?20202281572052", true);
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
         context.AddJavascriptSource("br_medication.js", "?20202281572053", false);
         context.AddJavascriptSource("DVelop/Bootstrap/Shared/DVelopBootstrap.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/Panel/BootstrapPanelRender.js", "", false);
         /* End function include_jscripts */
      }

      protected void init_default_properties( )
      {
         lblTextblockbr_medication_rxname_Internalname = "TEXTBLOCKBR_MEDICATION_RXNAME";
         dynBR_Medication_RXName_Internalname = "BR_MEDICATION_RXNAME";
         edtavVmedicationname_Internalname = "vVMEDICATIONNAME";
         cellVmedicationname_cell_Internalname = "VMEDICATIONNAME_CELL";
         tblTablemergedbr_medication_rxname_Internalname = "TABLEMERGEDBR_MEDICATION_RXNAME";
         divTablesplittedbr_medication_rxname_Internalname = "TABLESPLITTEDBR_MEDICATION_RXNAME";
         edtBR_Medication_RXCode_Internalname = "BR_MEDICATION_RXCODE";
         edtBR_Medication_RXType_Internalname = "BR_MEDICATION_RXTYPE";
         edtBR_Medication_RXDose_Internalname = "BR_MEDICATION_RXDOSE";
         edtBR_Medication_RXUnit_Internalname = "BR_MEDICATION_RXUNIT";
         lblTextblockbr_medication_rxfrequency_Internalname = "TEXTBLOCKBR_MEDICATION_RXFREQUENCY";
         dynBR_Medication_RXFrequency_Internalname = "BR_MEDICATION_RXFREQUENCY";
         edtavVfrequency_Internalname = "vVFREQUENCY";
         cellVfrequency_cell_Internalname = "VFREQUENCY_CELL";
         tblTablemergedbr_medication_rxfrequency_Internalname = "TABLEMERGEDBR_MEDICATION_RXFREQUENCY";
         divTablesplittedbr_medication_rxfrequency_Internalname = "TABLESPLITTEDBR_MEDICATION_RXFREQUENCY";
         edtBR_Medication_RXQuantity_Internalname = "BR_MEDICATION_RXQUANTITY";
         edtBR_Medication_RXDaysSupply_Internalname = "BR_MEDICATION_RXDAYSSUPPLY";
         lblTextblockbr_medication_rxroute_Internalname = "TEXTBLOCKBR_MEDICATION_RXROUTE";
         dynBR_Medication_RXRoute_Internalname = "BR_MEDICATION_RXROUTE";
         edtavVrxroute_Internalname = "vVRXROUTE";
         cellVrxroute_cell_Internalname = "VRXROUTE_CELL";
         tblTablemergedbr_medication_rxroute_Internalname = "TABLEMERGEDBR_MEDICATION_RXROUTE";
         divTablesplittedbr_medication_rxroute_Internalname = "TABLESPLITTEDBR_MEDICATION_RXROUTE";
         edtBR_Medication_PrescriptionDate_Internalname = "BR_MEDICATION_PRESCRIPTIONDATE";
         edtBR_Medication_AdmitStartDate_Internalname = "BR_MEDICATION_ADMITSTARTDATE";
         edtBR_Medication_AdmitEndDate_Internalname = "BR_MEDICATION_ADMITENDDATE";
         cmbBR_Medication_InpatientChemo_Internalname = "BR_MEDICATION_INPATIENTCHEMO";
         divTableattributes_Internalname = "TABLEATTRIBUTES";
         divLayout_tableattributes_Internalname = "LAYOUT_TABLEATTRIBUTES";
         Dvpanel_tableattributes_Internalname = "DVPANEL_TABLEATTRIBUTES";
         divHtml_dvpanel_tableattributes_Internalname = "HTML_DVPANEL_TABLEATTRIBUTES";
         divTablecontent_Internalname = "TABLECONTENT";
         bttBtntrn_enter_Internalname = "BTNTRN_ENTER";
         bttBtntrn_cancel_Internalname = "BTNTRN_CANCEL";
         bttBtntrn_delete_Internalname = "BTNTRN_DELETE";
         divTablemain_Internalname = "TABLEMAIN";
         edtBR_MedicationID_Internalname = "BR_MEDICATIONID";
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
         edtavVmedicationname_Jsonclick = "";
         edtavVmedicationname_Enabled = 1;
         edtavVmedicationname_Visible = 1;
         cellVmedicationname_cell_Class = "";
         dynBR_Medication_RXName_Jsonclick = "";
         dynBR_Medication_RXName.Enabled = 1;
         edtavVfrequency_Jsonclick = "";
         edtavVfrequency_Enabled = 1;
         edtavVfrequency_Visible = 1;
         cellVfrequency_cell_Class = "";
         dynBR_Medication_RXFrequency_Jsonclick = "";
         dynBR_Medication_RXFrequency.Enabled = 1;
         edtavVrxroute_Jsonclick = "";
         edtavVrxroute_Enabled = 1;
         edtavVrxroute_Visible = 1;
         cellVrxroute_cell_Class = "";
         dynBR_Medication_RXRoute_Jsonclick = "";
         dynBR_Medication_RXRoute.Enabled = 1;
         edtBR_Information_PatientNo_Jsonclick = "";
         edtBR_Information_PatientNo_Enabled = 0;
         edtBR_Information_PatientNo_Visible = 1;
         edtBR_EncounterID_Jsonclick = "";
         edtBR_EncounterID_Enabled = 1;
         edtBR_EncounterID_Visible = 1;
         edtBR_MedicationID_Jsonclick = "";
         edtBR_MedicationID_Enabled = 0;
         edtBR_MedicationID_Visible = 1;
         bttBtntrn_delete_Enabled = 0;
         bttBtntrn_delete_Visible = 1;
         bttBtntrn_cancel_Visible = 1;
         bttBtntrn_enter_Enabled = 1;
         bttBtntrn_enter_Visible = 1;
         cmbBR_Medication_InpatientChemo_Jsonclick = "";
         cmbBR_Medication_InpatientChemo.Enabled = 1;
         edtBR_Medication_AdmitEndDate_Jsonclick = "";
         edtBR_Medication_AdmitEndDate_Enabled = 1;
         edtBR_Medication_AdmitStartDate_Jsonclick = "";
         edtBR_Medication_AdmitStartDate_Enabled = 1;
         edtBR_Medication_PrescriptionDate_Jsonclick = "";
         edtBR_Medication_PrescriptionDate_Enabled = 1;
         edtBR_Medication_RXDaysSupply_Jsonclick = "";
         edtBR_Medication_RXDaysSupply_Enabled = 1;
         edtBR_Medication_RXQuantity_Jsonclick = "";
         edtBR_Medication_RXQuantity_Enabled = 1;
         edtBR_Medication_RXUnit_Jsonclick = "";
         edtBR_Medication_RXUnit_Enabled = 1;
         edtBR_Medication_RXDose_Jsonclick = "";
         edtBR_Medication_RXDose_Enabled = 1;
         edtBR_Medication_RXType_Jsonclick = "";
         edtBR_Medication_RXType_Enabled = 1;
         edtBR_Medication_RXCode_Jsonclick = "";
         edtBR_Medication_RXCode_Enabled = 1;
         Dvpanel_tableattributes_Autoscroll = Convert.ToBoolean( 0);
         Dvpanel_tableattributes_Iconposition = "left";
         Dvpanel_tableattributes_Showcollapseicon = Convert.ToBoolean( 0);
         Dvpanel_tableattributes_Collapsed = Convert.ToBoolean( 0);
         Dvpanel_tableattributes_Collapsible = Convert.ToBoolean( 0);
         Dvpanel_tableattributes_Title = "药物治疗";
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

      protected void GXDLABR_MEDICATION_RXNAME0H18( String AV21tCurrentCode )
      {
         if ( ! context.isAjaxRequest( ) )
         {
            context.GX_webresponse.AppendHeader("Cache-Control", "no-store");
         }
         context.GX_webresponse.AddString("[[");
         GXDLABR_MEDICATION_RXNAME_data0H18( AV21tCurrentCode) ;
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

      protected void GXABR_MEDICATION_RXNAME_html0H18( String AV21tCurrentCode )
      {
         String gxdynajaxvalue ;
         GXDLABR_MEDICATION_RXNAME_data0H18( AV21tCurrentCode) ;
         gxdynajaxindex = 1;
         if ( ! ( gxdyncontrolsrefreshing && context.isAjaxRequest( ) ) )
         {
            dynBR_Medication_RXName.removeAllItems();
         }
         while ( gxdynajaxindex <= gxdynajaxctrlcodr.Count )
         {
            gxdynajaxvalue = ((String)gxdynajaxctrlcodr.Item(gxdynajaxindex));
            dynBR_Medication_RXName.addItem(gxdynajaxvalue, ((String)gxdynajaxctrldescr.Item(gxdynajaxindex)), 0);
            gxdynajaxindex = (int)(gxdynajaxindex+1);
         }
      }

      protected void GXDLABR_MEDICATION_RXNAME_data0H18( String AV21tCurrentCode )
      {
         gxdynajaxctrlcodr.Clear();
         gxdynajaxctrldescr.Clear();
         /* Using cursor T000H20 */
         pr_default.execute(18, new Object[] {AV21tCurrentCode});
         while ( (pr_default.getStatus(18) != 101) )
         {
            gxdynajaxctrlcodr.Add(T000H20_A168XT_DefineCodeName[0]);
            gxdynajaxctrldescr.Add(T000H20_A168XT_DefineCodeName[0]);
            pr_default.readNext(18);
         }
         pr_default.close(18);
      }

      protected void GXDLABR_MEDICATION_RXFREQUENCY0H18( String AV21tCurrentCode )
      {
         if ( ! context.isAjaxRequest( ) )
         {
            context.GX_webresponse.AppendHeader("Cache-Control", "no-store");
         }
         context.GX_webresponse.AddString("[[");
         GXDLABR_MEDICATION_RXFREQUENCY_data0H18( AV21tCurrentCode) ;
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

      protected void GXABR_MEDICATION_RXFREQUENCY_html0H18( String AV21tCurrentCode )
      {
         String gxdynajaxvalue ;
         GXDLABR_MEDICATION_RXFREQUENCY_data0H18( AV21tCurrentCode) ;
         gxdynajaxindex = 1;
         if ( ! ( gxdyncontrolsrefreshing && context.isAjaxRequest( ) ) )
         {
            dynBR_Medication_RXFrequency.removeAllItems();
         }
         while ( gxdynajaxindex <= gxdynajaxctrlcodr.Count )
         {
            gxdynajaxvalue = ((String)gxdynajaxctrlcodr.Item(gxdynajaxindex));
            dynBR_Medication_RXFrequency.addItem(gxdynajaxvalue, ((String)gxdynajaxctrldescr.Item(gxdynajaxindex)), 0);
            gxdynajaxindex = (int)(gxdynajaxindex+1);
         }
      }

      protected void GXDLABR_MEDICATION_RXFREQUENCY_data0H18( String AV21tCurrentCode )
      {
         gxdynajaxctrlcodr.Clear();
         gxdynajaxctrldescr.Clear();
         gxdynajaxctrlcodr.Add("");
         gxdynajaxctrldescr.Add("(请选择)");
         /* Using cursor T000H21 */
         pr_default.execute(19, new Object[] {AV21tCurrentCode});
         while ( (pr_default.getStatus(19) != 101) )
         {
            gxdynajaxctrlcodr.Add(T000H21_A168XT_DefineCodeName[0]);
            gxdynajaxctrldescr.Add(T000H21_A168XT_DefineCodeName[0]);
            pr_default.readNext(19);
         }
         pr_default.close(19);
      }

      protected void GXDLABR_MEDICATION_RXROUTE0H18( String AV21tCurrentCode )
      {
         if ( ! context.isAjaxRequest( ) )
         {
            context.GX_webresponse.AppendHeader("Cache-Control", "no-store");
         }
         context.GX_webresponse.AddString("[[");
         GXDLABR_MEDICATION_RXROUTE_data0H18( AV21tCurrentCode) ;
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

      protected void GXABR_MEDICATION_RXROUTE_html0H18( String AV21tCurrentCode )
      {
         String gxdynajaxvalue ;
         GXDLABR_MEDICATION_RXROUTE_data0H18( AV21tCurrentCode) ;
         gxdynajaxindex = 1;
         if ( ! ( gxdyncontrolsrefreshing && context.isAjaxRequest( ) ) )
         {
            dynBR_Medication_RXRoute.removeAllItems();
         }
         while ( gxdynajaxindex <= gxdynajaxctrlcodr.Count )
         {
            gxdynajaxvalue = ((String)gxdynajaxctrlcodr.Item(gxdynajaxindex));
            dynBR_Medication_RXRoute.addItem(gxdynajaxvalue, ((String)gxdynajaxctrldescr.Item(gxdynajaxindex)), 0);
            gxdynajaxindex = (int)(gxdynajaxindex+1);
         }
      }

      protected void GXDLABR_MEDICATION_RXROUTE_data0H18( String AV21tCurrentCode )
      {
         gxdynajaxctrlcodr.Clear();
         gxdynajaxctrldescr.Clear();
         gxdynajaxctrlcodr.Add("");
         gxdynajaxctrldescr.Add("(请选择)");
         /* Using cursor T000H22 */
         pr_default.execute(20, new Object[] {AV21tCurrentCode});
         while ( (pr_default.getStatus(20) != 101) )
         {
            gxdynajaxctrlcodr.Add(T000H22_A168XT_DefineCodeName[0]);
            gxdynajaxctrldescr.Add(T000H22_A168XT_DefineCodeName[0]);
            pr_default.readNext(20);
         }
         pr_default.close(20);
      }

      protected void GX17ASABR_MEDICATION_RXFREQUENCY_CODE0H18( String A126BR_Medication_RXFrequency )
      {
         GXt_char1 = A478BR_Medication_RXFrequency_Code;
         new zutil_findtargetcode(context ).execute(  25,  A126BR_Medication_RXFrequency, out  GXt_char1) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A126BR_Medication_RXFrequency", A126BR_Medication_RXFrequency);
         A478BR_Medication_RXFrequency_Code = GXt_char1;
         n478BR_Medication_RXFrequency_Code = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A478BR_Medication_RXFrequency_Code", A478BR_Medication_RXFrequency_Code);
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("[[");
         context.GX_webresponse.AddString("\""+GXUtil.EncodeJSConstant( A478BR_Medication_RXFrequency_Code)+"\"");
         context.GX_webresponse.AddString("]");
         if ( true )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString("]");
      }

      protected void GX18ASABR_MEDICATION_RXFREQUENCY_CODE0H18( String A126BR_Medication_RXFrequency )
      {
         GXt_char1 = A478BR_Medication_RXFrequency_Code;
         new zutil_findtargetcode(context ).execute(  25,  A126BR_Medication_RXFrequency, out  GXt_char1) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A126BR_Medication_RXFrequency", A126BR_Medication_RXFrequency);
         A478BR_Medication_RXFrequency_Code = GXt_char1;
         n478BR_Medication_RXFrequency_Code = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A478BR_Medication_RXFrequency_Code", A478BR_Medication_RXFrequency_Code);
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("[[");
         context.GX_webresponse.AddString("\""+GXUtil.EncodeJSConstant( A478BR_Medication_RXFrequency_Code)+"\"");
         context.GX_webresponse.AddString("]");
         if ( true )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString("]");
      }

      protected void GX19ASABR_MEDICATION_RXROUTE_CODE0H18( String A129BR_Medication_RXRoute )
      {
         GXt_char1 = A477BR_Medication_RXRoute_Code;
         new zutil_findtargetcode(context ).execute(  26,  A129BR_Medication_RXRoute, out  GXt_char1) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A129BR_Medication_RXRoute", A129BR_Medication_RXRoute);
         A477BR_Medication_RXRoute_Code = GXt_char1;
         n477BR_Medication_RXRoute_Code = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A477BR_Medication_RXRoute_Code", A477BR_Medication_RXRoute_Code);
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("[[");
         context.GX_webresponse.AddString("\""+GXUtil.EncodeJSConstant( A477BR_Medication_RXRoute_Code)+"\"");
         context.GX_webresponse.AddString("]");
         if ( true )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString("]");
      }

      protected void GX20ASABR_MEDICATION_RXROUTE_CODE0H18( String A129BR_Medication_RXRoute )
      {
         GXt_char1 = A477BR_Medication_RXRoute_Code;
         new zutil_findtargetcode(context ).execute(  26,  A129BR_Medication_RXRoute, out  GXt_char1) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A129BR_Medication_RXRoute", A129BR_Medication_RXRoute);
         A477BR_Medication_RXRoute_Code = GXt_char1;
         n477BR_Medication_RXRoute_Code = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A477BR_Medication_RXRoute_Code", A477BR_Medication_RXRoute_Code);
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("[[");
         context.GX_webresponse.AddString("\""+GXUtil.EncodeJSConstant( A477BR_Medication_RXRoute_Code)+"\"");
         context.GX_webresponse.AddString("]");
         if ( true )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString("]");
      }

      protected void GX21ASABR_MEDICATION_INPATIENTCHEMO_CODE0H18( String A131BR_Medication_InpatientChemo )
      {
         GXt_char1 = A507BR_Medication_InpatientChemo_Code;
         new zutil_findtargetcode(context ).execute(  37,  A131BR_Medication_InpatientChemo, out  GXt_char1) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A131BR_Medication_InpatientChemo", A131BR_Medication_InpatientChemo);
         A507BR_Medication_InpatientChemo_Code = GXt_char1;
         n507BR_Medication_InpatientChemo_Code = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A507BR_Medication_InpatientChemo_Code", A507BR_Medication_InpatientChemo_Code);
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("[[");
         context.GX_webresponse.AddString("\""+GXUtil.EncodeJSConstant( A507BR_Medication_InpatientChemo_Code)+"\"");
         context.GX_webresponse.AddString("]");
         if ( true )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString("]");
      }

      protected void GX22ASABR_MEDICATION_INPATIENTCHEMO_CODE0H18( String A131BR_Medication_InpatientChemo )
      {
         GXt_char1 = A507BR_Medication_InpatientChemo_Code;
         new zutil_findtargetcode(context ).execute(  37,  A131BR_Medication_InpatientChemo, out  GXt_char1) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A131BR_Medication_InpatientChemo", A131BR_Medication_InpatientChemo);
         A507BR_Medication_InpatientChemo_Code = GXt_char1;
         n507BR_Medication_InpatientChemo_Code = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A507BR_Medication_InpatientChemo_Code", A507BR_Medication_InpatientChemo_Code);
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("[[");
         context.GX_webresponse.AddString("\""+GXUtil.EncodeJSConstant( A507BR_Medication_InpatientChemo_Code)+"\"");
         context.GX_webresponse.AddString("]");
         if ( true )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString("]");
      }

      protected void XC_35_0H18( )
      {
         new zutil_recordsonlog(context ).execute(  StringUtil.Trim( StringUtil.Str( (decimal)(A19BR_EncounterID), 18, 0)),  "就诊信息",  StringUtil.Trim( StringUtil.Str( (decimal)(A119BR_MedicationID), 18, 0)),  "药物治疗",  "Create",  1) ;
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
         dynBR_Medication_RXName.Name = "BR_MEDICATION_RXNAME";
         dynBR_Medication_RXName.WebTags = "";
         dynBR_Medication_RXFrequency.Name = "BR_MEDICATION_RXFREQUENCY";
         dynBR_Medication_RXFrequency.WebTags = "";
         dynBR_Medication_RXRoute.Name = "BR_MEDICATION_RXROUTE";
         dynBR_Medication_RXRoute.WebTags = "";
         cmbBR_Medication_InpatientChemo.Name = "BR_MEDICATION_INPATIENTCHEMO";
         cmbBR_Medication_InpatientChemo.WebTags = "";
         cmbBR_Medication_InpatientChemo.addItem("", "(请选择)", 0);
         cmbBR_Medication_InpatientChemo.addItem("否", "否", 0);
         cmbBR_Medication_InpatientChemo.addItem("是", "是", 0);
         cmbBR_Medication_InpatientChemo.addItem("不详", "不详", 0);
         if ( cmbBR_Medication_InpatientChemo.ItemCount > 0 )
         {
            A131BR_Medication_InpatientChemo = cmbBR_Medication_InpatientChemo.getValidValue(A131BR_Medication_InpatientChemo);
            n131BR_Medication_InpatientChemo = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A131BR_Medication_InpatientChemo", A131BR_Medication_InpatientChemo);
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
         /* Using cursor T000H23 */
         pr_default.execute(21, new Object[] {A19BR_EncounterID});
         if ( (pr_default.getStatus(21) == 101) )
         {
            GX_msglist.addItem("不匹配' T15'", "ForeignKeyNotFound", 1, "BR_ENCOUNTERID");
            AnyError = 1;
            GX_FocusControl = edtBR_EncounterID_Internalname;
         }
         A85BR_Information_ID = T000H23_A85BR_Information_ID[0];
         n85BR_Information_ID = T000H23_n85BR_Information_ID[0];
         pr_default.close(21);
         /* Using cursor T000H24 */
         pr_default.execute(22, new Object[] {n85BR_Information_ID, A85BR_Information_ID});
         if ( (pr_default.getStatus(22) == 101) )
         {
            if ( ! ( (0==A85BR_Information_ID) ) )
            {
               GX_msglist.addItem("不匹配' T16'", "ForeignKeyNotFound", 1, "");
               AnyError = 1;
            }
         }
         A36BR_Information_PatientNo = T000H24_A36BR_Information_PatientNo[0];
         n36BR_Information_PatientNo = T000H24_n36BR_Information_PatientNo[0];
         pr_default.close(22);
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
         setEventMetadata("ENTER","{handler:'UserMainFullajax',iparms:[{postForm:true},{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV12BR_MedicationID',fld:'vBR_MEDICATIONID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true}]");
         setEventMetadata("ENTER",",oparms:[]}");
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV12BR_MedicationID',fld:'vBR_MEDICATIONID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true},{av:'A119BR_MedicationID',fld:'BR_MEDICATIONID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV21tCurrentCode',fld:'vTCURRENTCODE',pic:''},{av:'AV10Insert_BR_EncounterID',fld:'vINSERT_BR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'A120BR_Medication_RXID',fld:'BR_MEDICATION_RXID',pic:'ZZZZ'},{av:'A499BR_Medication_RXName_Code',fld:'BR_MEDICATION_RXNAME_CODE',pic:''}]");
         setEventMetadata("REFRESH",",oparms:[]}");
         setEventMetadata("AFTER TRN","{handler:'E120H2',iparms:[{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV8TrnContext',fld:'vTRNCONTEXT',pic:''}]");
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
         pr_default.close(21);
         pr_default.close(13);
         pr_default.close(22);
         pr_default.close(14);
      }

      public override void initialize( )
      {
         sPrefix = "";
         wcpOGx_mode = "";
         Z478BR_Medication_RXFrequency_Code = "";
         Z477BR_Medication_RXRoute_Code = "";
         Z507BR_Medication_InpatientChemo_Code = "";
         Z121BR_Medication_RXName = "";
         Z499BR_Medication_RXName_Code = "";
         Z122BR_Medication_RXCode = "";
         Z123BR_Medication_RXType = "";
         Z125BR_Medication_RXUnit = "";
         Z126BR_Medication_RXFrequency = "";
         Z127BR_Medication_RXQuantity = "";
         Z129BR_Medication_RXRoute = "";
         Z130BR_Medication_PrescriptionDate = DateTime.MinValue;
         Z132BR_Medication_AdmitStartDate = DateTime.MinValue;
         Z133BR_Medication_AdmitEndDate = DateTime.MinValue;
         Z131BR_Medication_InpatientChemo = "";
         scmdbuf = "";
         gxfirstwebparm = "";
         gxfirstwebparm_bkp = "";
         AV21tCurrentCode = "";
         A126BR_Medication_RXFrequency = "";
         A129BR_Medication_RXRoute = "";
         A131BR_Medication_InpatientChemo = "";
         GXKey = "";
         PreviousTooltip = "";
         PreviousCaption = "";
         Form = new GXWebForm();
         GX_FocusControl = "";
         A121BR_Medication_RXName = "";
         ClassString = "";
         StyleString = "";
         ucDvpanel_tableattributes = new GXUserControl();
         lblTextblockbr_medication_rxname_Jsonclick = "";
         TempTags = "";
         A122BR_Medication_RXCode = "";
         A123BR_Medication_RXType = "";
         A125BR_Medication_RXUnit = "";
         lblTextblockbr_medication_rxfrequency_Jsonclick = "";
         A127BR_Medication_RXQuantity = "";
         lblTextblockbr_medication_rxroute_Jsonclick = "";
         A130BR_Medication_PrescriptionDate = DateTime.MinValue;
         A132BR_Medication_AdmitStartDate = DateTime.MinValue;
         A133BR_Medication_AdmitEndDate = DateTime.MinValue;
         bttBtntrn_enter_Jsonclick = "";
         bttBtntrn_cancel_Jsonclick = "";
         bttBtntrn_delete_Jsonclick = "";
         A36BR_Information_PatientNo = "";
         sStyleString = "";
         AV15vRXRoute = "";
         AV19vFrequency = "";
         AV20vMedicationName = "";
         A478BR_Medication_RXFrequency_Code = "";
         A477BR_Medication_RXRoute_Code = "";
         A507BR_Medication_InpatientChemo_Code = "";
         A499BR_Medication_RXName_Code = "";
         AV22Pgmname = "";
         Dvpanel_tableattributes_Objectcall = "";
         Dvpanel_tableattributes_Class = "";
         Dvpanel_tableattributes_Height = "";
         forbiddenHiddens = "";
         hsh = "";
         sMode18 = "";
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         AV7WWPContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPContext(context);
         AV8TrnContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext(context);
         AV9WebSession = context.GetSession();
         AV11TrnContextAtt = new GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext_Attribute(context);
         Z36BR_Information_PatientNo = "";
         T000H4_A85BR_Information_ID = new long[1] ;
         T000H4_n85BR_Information_ID = new bool[] {false} ;
         T000H5_A36BR_Information_PatientNo = new String[] {""} ;
         T000H5_n36BR_Information_PatientNo = new bool[] {false} ;
         T000H6_A85BR_Information_ID = new long[1] ;
         T000H6_n85BR_Information_ID = new bool[] {false} ;
         T000H6_A119BR_MedicationID = new long[1] ;
         T000H6_n119BR_MedicationID = new bool[] {false} ;
         T000H6_A478BR_Medication_RXFrequency_Code = new String[] {""} ;
         T000H6_n478BR_Medication_RXFrequency_Code = new bool[] {false} ;
         T000H6_A477BR_Medication_RXRoute_Code = new String[] {""} ;
         T000H6_n477BR_Medication_RXRoute_Code = new bool[] {false} ;
         T000H6_A507BR_Medication_InpatientChemo_Code = new String[] {""} ;
         T000H6_n507BR_Medication_InpatientChemo_Code = new bool[] {false} ;
         T000H6_A36BR_Information_PatientNo = new String[] {""} ;
         T000H6_n36BR_Information_PatientNo = new bool[] {false} ;
         T000H6_A120BR_Medication_RXID = new short[1] ;
         T000H6_n120BR_Medication_RXID = new bool[] {false} ;
         T000H6_A121BR_Medication_RXName = new String[] {""} ;
         T000H6_n121BR_Medication_RXName = new bool[] {false} ;
         T000H6_A499BR_Medication_RXName_Code = new String[] {""} ;
         T000H6_n499BR_Medication_RXName_Code = new bool[] {false} ;
         T000H6_A122BR_Medication_RXCode = new String[] {""} ;
         T000H6_n122BR_Medication_RXCode = new bool[] {false} ;
         T000H6_A123BR_Medication_RXType = new String[] {""} ;
         T000H6_n123BR_Medication_RXType = new bool[] {false} ;
         T000H6_A124BR_Medication_RXDose = new decimal[1] ;
         T000H6_n124BR_Medication_RXDose = new bool[] {false} ;
         T000H6_A125BR_Medication_RXUnit = new String[] {""} ;
         T000H6_n125BR_Medication_RXUnit = new bool[] {false} ;
         T000H6_A126BR_Medication_RXFrequency = new String[] {""} ;
         T000H6_n126BR_Medication_RXFrequency = new bool[] {false} ;
         T000H6_A127BR_Medication_RXQuantity = new String[] {""} ;
         T000H6_n127BR_Medication_RXQuantity = new bool[] {false} ;
         T000H6_A128BR_Medication_RXDaysSupply = new decimal[1] ;
         T000H6_n128BR_Medication_RXDaysSupply = new bool[] {false} ;
         T000H6_A129BR_Medication_RXRoute = new String[] {""} ;
         T000H6_n129BR_Medication_RXRoute = new bool[] {false} ;
         T000H6_A130BR_Medication_PrescriptionDate = new DateTime[] {DateTime.MinValue} ;
         T000H6_n130BR_Medication_PrescriptionDate = new bool[] {false} ;
         T000H6_A132BR_Medication_AdmitStartDate = new DateTime[] {DateTime.MinValue} ;
         T000H6_n132BR_Medication_AdmitStartDate = new bool[] {false} ;
         T000H6_A133BR_Medication_AdmitEndDate = new DateTime[] {DateTime.MinValue} ;
         T000H6_n133BR_Medication_AdmitEndDate = new bool[] {false} ;
         T000H6_A131BR_Medication_InpatientChemo = new String[] {""} ;
         T000H6_n131BR_Medication_InpatientChemo = new bool[] {false} ;
         T000H6_A19BR_EncounterID = new long[1] ;
         T000H7_A85BR_Information_ID = new long[1] ;
         T000H7_n85BR_Information_ID = new bool[] {false} ;
         T000H8_A36BR_Information_PatientNo = new String[] {""} ;
         T000H8_n36BR_Information_PatientNo = new bool[] {false} ;
         T000H9_A119BR_MedicationID = new long[1] ;
         T000H9_n119BR_MedicationID = new bool[] {false} ;
         T000H3_A119BR_MedicationID = new long[1] ;
         T000H3_n119BR_MedicationID = new bool[] {false} ;
         T000H3_A478BR_Medication_RXFrequency_Code = new String[] {""} ;
         T000H3_n478BR_Medication_RXFrequency_Code = new bool[] {false} ;
         T000H3_A477BR_Medication_RXRoute_Code = new String[] {""} ;
         T000H3_n477BR_Medication_RXRoute_Code = new bool[] {false} ;
         T000H3_A507BR_Medication_InpatientChemo_Code = new String[] {""} ;
         T000H3_n507BR_Medication_InpatientChemo_Code = new bool[] {false} ;
         T000H3_A120BR_Medication_RXID = new short[1] ;
         T000H3_n120BR_Medication_RXID = new bool[] {false} ;
         T000H3_A121BR_Medication_RXName = new String[] {""} ;
         T000H3_n121BR_Medication_RXName = new bool[] {false} ;
         T000H3_A499BR_Medication_RXName_Code = new String[] {""} ;
         T000H3_n499BR_Medication_RXName_Code = new bool[] {false} ;
         T000H3_A122BR_Medication_RXCode = new String[] {""} ;
         T000H3_n122BR_Medication_RXCode = new bool[] {false} ;
         T000H3_A123BR_Medication_RXType = new String[] {""} ;
         T000H3_n123BR_Medication_RXType = new bool[] {false} ;
         T000H3_A124BR_Medication_RXDose = new decimal[1] ;
         T000H3_n124BR_Medication_RXDose = new bool[] {false} ;
         T000H3_A125BR_Medication_RXUnit = new String[] {""} ;
         T000H3_n125BR_Medication_RXUnit = new bool[] {false} ;
         T000H3_A126BR_Medication_RXFrequency = new String[] {""} ;
         T000H3_n126BR_Medication_RXFrequency = new bool[] {false} ;
         T000H3_A127BR_Medication_RXQuantity = new String[] {""} ;
         T000H3_n127BR_Medication_RXQuantity = new bool[] {false} ;
         T000H3_A128BR_Medication_RXDaysSupply = new decimal[1] ;
         T000H3_n128BR_Medication_RXDaysSupply = new bool[] {false} ;
         T000H3_A129BR_Medication_RXRoute = new String[] {""} ;
         T000H3_n129BR_Medication_RXRoute = new bool[] {false} ;
         T000H3_A130BR_Medication_PrescriptionDate = new DateTime[] {DateTime.MinValue} ;
         T000H3_n130BR_Medication_PrescriptionDate = new bool[] {false} ;
         T000H3_A132BR_Medication_AdmitStartDate = new DateTime[] {DateTime.MinValue} ;
         T000H3_n132BR_Medication_AdmitStartDate = new bool[] {false} ;
         T000H3_A133BR_Medication_AdmitEndDate = new DateTime[] {DateTime.MinValue} ;
         T000H3_n133BR_Medication_AdmitEndDate = new bool[] {false} ;
         T000H3_A131BR_Medication_InpatientChemo = new String[] {""} ;
         T000H3_n131BR_Medication_InpatientChemo = new bool[] {false} ;
         T000H3_A19BR_EncounterID = new long[1] ;
         T000H10_A119BR_MedicationID = new long[1] ;
         T000H10_n119BR_MedicationID = new bool[] {false} ;
         T000H11_A119BR_MedicationID = new long[1] ;
         T000H11_n119BR_MedicationID = new bool[] {false} ;
         T000H2_A119BR_MedicationID = new long[1] ;
         T000H2_n119BR_MedicationID = new bool[] {false} ;
         T000H2_A478BR_Medication_RXFrequency_Code = new String[] {""} ;
         T000H2_n478BR_Medication_RXFrequency_Code = new bool[] {false} ;
         T000H2_A477BR_Medication_RXRoute_Code = new String[] {""} ;
         T000H2_n477BR_Medication_RXRoute_Code = new bool[] {false} ;
         T000H2_A507BR_Medication_InpatientChemo_Code = new String[] {""} ;
         T000H2_n507BR_Medication_InpatientChemo_Code = new bool[] {false} ;
         T000H2_A120BR_Medication_RXID = new short[1] ;
         T000H2_n120BR_Medication_RXID = new bool[] {false} ;
         T000H2_A121BR_Medication_RXName = new String[] {""} ;
         T000H2_n121BR_Medication_RXName = new bool[] {false} ;
         T000H2_A499BR_Medication_RXName_Code = new String[] {""} ;
         T000H2_n499BR_Medication_RXName_Code = new bool[] {false} ;
         T000H2_A122BR_Medication_RXCode = new String[] {""} ;
         T000H2_n122BR_Medication_RXCode = new bool[] {false} ;
         T000H2_A123BR_Medication_RXType = new String[] {""} ;
         T000H2_n123BR_Medication_RXType = new bool[] {false} ;
         T000H2_A124BR_Medication_RXDose = new decimal[1] ;
         T000H2_n124BR_Medication_RXDose = new bool[] {false} ;
         T000H2_A125BR_Medication_RXUnit = new String[] {""} ;
         T000H2_n125BR_Medication_RXUnit = new bool[] {false} ;
         T000H2_A126BR_Medication_RXFrequency = new String[] {""} ;
         T000H2_n126BR_Medication_RXFrequency = new bool[] {false} ;
         T000H2_A127BR_Medication_RXQuantity = new String[] {""} ;
         T000H2_n127BR_Medication_RXQuantity = new bool[] {false} ;
         T000H2_A128BR_Medication_RXDaysSupply = new decimal[1] ;
         T000H2_n128BR_Medication_RXDaysSupply = new bool[] {false} ;
         T000H2_A129BR_Medication_RXRoute = new String[] {""} ;
         T000H2_n129BR_Medication_RXRoute = new bool[] {false} ;
         T000H2_A130BR_Medication_PrescriptionDate = new DateTime[] {DateTime.MinValue} ;
         T000H2_n130BR_Medication_PrescriptionDate = new bool[] {false} ;
         T000H2_A132BR_Medication_AdmitStartDate = new DateTime[] {DateTime.MinValue} ;
         T000H2_n132BR_Medication_AdmitStartDate = new bool[] {false} ;
         T000H2_A133BR_Medication_AdmitEndDate = new DateTime[] {DateTime.MinValue} ;
         T000H2_n133BR_Medication_AdmitEndDate = new bool[] {false} ;
         T000H2_A131BR_Medication_InpatientChemo = new String[] {""} ;
         T000H2_n131BR_Medication_InpatientChemo = new bool[] {false} ;
         T000H2_A19BR_EncounterID = new long[1] ;
         T000H12_A119BR_MedicationID = new long[1] ;
         T000H12_n119BR_MedicationID = new bool[] {false} ;
         T000H15_A85BR_Information_ID = new long[1] ;
         T000H15_n85BR_Information_ID = new bool[] {false} ;
         T000H16_A36BR_Information_PatientNo = new String[] {""} ;
         T000H16_n36BR_Information_PatientNo = new bool[] {false} ;
         T000H17_A332BR_Scheme_MedicationID = new long[1] ;
         T000H18_A296BR_Medication_SchemeID = new long[1] ;
         T000H19_A119BR_MedicationID = new long[1] ;
         T000H19_n119BR_MedicationID = new bool[] {false} ;
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         gxdynajaxctrlcodr = new GeneXus.Utils.GxStringCollection();
         gxdynajaxctrldescr = new GeneXus.Utils.GxStringCollection();
         gxwrpcisep = "";
         T000H20_A167XT_DefineCodeID = new long[1] ;
         T000H20_A168XT_DefineCodeName = new String[] {""} ;
         T000H20_n168XT_DefineCodeName = new bool[] {false} ;
         T000H20_A165XT_DefindcodeTypeID = new long[1] ;
         T000H20_A432XT_TenantCode = new String[] {""} ;
         T000H20_n432XT_TenantCode = new bool[] {false} ;
         T000H21_A167XT_DefineCodeID = new long[1] ;
         T000H21_A168XT_DefineCodeName = new String[] {""} ;
         T000H21_n168XT_DefineCodeName = new bool[] {false} ;
         T000H21_A165XT_DefindcodeTypeID = new long[1] ;
         T000H21_A432XT_TenantCode = new String[] {""} ;
         T000H21_n432XT_TenantCode = new bool[] {false} ;
         T000H22_A167XT_DefineCodeID = new long[1] ;
         T000H22_A168XT_DefineCodeName = new String[] {""} ;
         T000H22_n168XT_DefineCodeName = new bool[] {false} ;
         T000H22_A165XT_DefindcodeTypeID = new long[1] ;
         T000H22_A432XT_TenantCode = new String[] {""} ;
         T000H22_n432XT_TenantCode = new bool[] {false} ;
         GXt_char1 = "";
         T000H23_A85BR_Information_ID = new long[1] ;
         T000H23_n85BR_Information_ID = new bool[] {false} ;
         T000H24_A36BR_Information_PatientNo = new String[] {""} ;
         T000H24_n36BR_Information_PatientNo = new bool[] {false} ;
         isValidOutput = new GxUnknownObjectCollection();
         pr_datastore1 = new DataStoreProvider(context, new GeneXus.Programs.br_medication__datastore1(),
            new Object[][] {
            }
         );
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.br_medication__default(),
            new Object[][] {
                new Object[] {
               T000H2_A119BR_MedicationID, T000H2_A478BR_Medication_RXFrequency_Code, T000H2_n478BR_Medication_RXFrequency_Code, T000H2_A477BR_Medication_RXRoute_Code, T000H2_n477BR_Medication_RXRoute_Code, T000H2_A507BR_Medication_InpatientChemo_Code, T000H2_n507BR_Medication_InpatientChemo_Code, T000H2_A120BR_Medication_RXID, T000H2_n120BR_Medication_RXID, T000H2_A121BR_Medication_RXName,
               T000H2_n121BR_Medication_RXName, T000H2_A499BR_Medication_RXName_Code, T000H2_n499BR_Medication_RXName_Code, T000H2_A122BR_Medication_RXCode, T000H2_n122BR_Medication_RXCode, T000H2_A123BR_Medication_RXType, T000H2_n123BR_Medication_RXType, T000H2_A124BR_Medication_RXDose, T000H2_n124BR_Medication_RXDose, T000H2_A125BR_Medication_RXUnit,
               T000H2_n125BR_Medication_RXUnit, T000H2_A126BR_Medication_RXFrequency, T000H2_n126BR_Medication_RXFrequency, T000H2_A127BR_Medication_RXQuantity, T000H2_n127BR_Medication_RXQuantity, T000H2_A128BR_Medication_RXDaysSupply, T000H2_n128BR_Medication_RXDaysSupply, T000H2_A129BR_Medication_RXRoute, T000H2_n129BR_Medication_RXRoute, T000H2_A130BR_Medication_PrescriptionDate,
               T000H2_n130BR_Medication_PrescriptionDate, T000H2_A132BR_Medication_AdmitStartDate, T000H2_n132BR_Medication_AdmitStartDate, T000H2_A133BR_Medication_AdmitEndDate, T000H2_n133BR_Medication_AdmitEndDate, T000H2_A131BR_Medication_InpatientChemo, T000H2_n131BR_Medication_InpatientChemo, T000H2_A19BR_EncounterID
               }
               , new Object[] {
               T000H3_A119BR_MedicationID, T000H3_A478BR_Medication_RXFrequency_Code, T000H3_n478BR_Medication_RXFrequency_Code, T000H3_A477BR_Medication_RXRoute_Code, T000H3_n477BR_Medication_RXRoute_Code, T000H3_A507BR_Medication_InpatientChemo_Code, T000H3_n507BR_Medication_InpatientChemo_Code, T000H3_A120BR_Medication_RXID, T000H3_n120BR_Medication_RXID, T000H3_A121BR_Medication_RXName,
               T000H3_n121BR_Medication_RXName, T000H3_A499BR_Medication_RXName_Code, T000H3_n499BR_Medication_RXName_Code, T000H3_A122BR_Medication_RXCode, T000H3_n122BR_Medication_RXCode, T000H3_A123BR_Medication_RXType, T000H3_n123BR_Medication_RXType, T000H3_A124BR_Medication_RXDose, T000H3_n124BR_Medication_RXDose, T000H3_A125BR_Medication_RXUnit,
               T000H3_n125BR_Medication_RXUnit, T000H3_A126BR_Medication_RXFrequency, T000H3_n126BR_Medication_RXFrequency, T000H3_A127BR_Medication_RXQuantity, T000H3_n127BR_Medication_RXQuantity, T000H3_A128BR_Medication_RXDaysSupply, T000H3_n128BR_Medication_RXDaysSupply, T000H3_A129BR_Medication_RXRoute, T000H3_n129BR_Medication_RXRoute, T000H3_A130BR_Medication_PrescriptionDate,
               T000H3_n130BR_Medication_PrescriptionDate, T000H3_A132BR_Medication_AdmitStartDate, T000H3_n132BR_Medication_AdmitStartDate, T000H3_A133BR_Medication_AdmitEndDate, T000H3_n133BR_Medication_AdmitEndDate, T000H3_A131BR_Medication_InpatientChemo, T000H3_n131BR_Medication_InpatientChemo, T000H3_A19BR_EncounterID
               }
               , new Object[] {
               T000H4_A85BR_Information_ID, T000H4_n85BR_Information_ID
               }
               , new Object[] {
               T000H5_A36BR_Information_PatientNo, T000H5_n36BR_Information_PatientNo
               }
               , new Object[] {
               T000H6_A85BR_Information_ID, T000H6_n85BR_Information_ID, T000H6_A119BR_MedicationID, T000H6_A478BR_Medication_RXFrequency_Code, T000H6_n478BR_Medication_RXFrequency_Code, T000H6_A477BR_Medication_RXRoute_Code, T000H6_n477BR_Medication_RXRoute_Code, T000H6_A507BR_Medication_InpatientChemo_Code, T000H6_n507BR_Medication_InpatientChemo_Code, T000H6_A36BR_Information_PatientNo,
               T000H6_n36BR_Information_PatientNo, T000H6_A120BR_Medication_RXID, T000H6_n120BR_Medication_RXID, T000H6_A121BR_Medication_RXName, T000H6_n121BR_Medication_RXName, T000H6_A499BR_Medication_RXName_Code, T000H6_n499BR_Medication_RXName_Code, T000H6_A122BR_Medication_RXCode, T000H6_n122BR_Medication_RXCode, T000H6_A123BR_Medication_RXType,
               T000H6_n123BR_Medication_RXType, T000H6_A124BR_Medication_RXDose, T000H6_n124BR_Medication_RXDose, T000H6_A125BR_Medication_RXUnit, T000H6_n125BR_Medication_RXUnit, T000H6_A126BR_Medication_RXFrequency, T000H6_n126BR_Medication_RXFrequency, T000H6_A127BR_Medication_RXQuantity, T000H6_n127BR_Medication_RXQuantity, T000H6_A128BR_Medication_RXDaysSupply,
               T000H6_n128BR_Medication_RXDaysSupply, T000H6_A129BR_Medication_RXRoute, T000H6_n129BR_Medication_RXRoute, T000H6_A130BR_Medication_PrescriptionDate, T000H6_n130BR_Medication_PrescriptionDate, T000H6_A132BR_Medication_AdmitStartDate, T000H6_n132BR_Medication_AdmitStartDate, T000H6_A133BR_Medication_AdmitEndDate, T000H6_n133BR_Medication_AdmitEndDate, T000H6_A131BR_Medication_InpatientChemo,
               T000H6_n131BR_Medication_InpatientChemo, T000H6_A19BR_EncounterID
               }
               , new Object[] {
               T000H7_A85BR_Information_ID, T000H7_n85BR_Information_ID
               }
               , new Object[] {
               T000H8_A36BR_Information_PatientNo, T000H8_n36BR_Information_PatientNo
               }
               , new Object[] {
               T000H9_A119BR_MedicationID
               }
               , new Object[] {
               T000H10_A119BR_MedicationID
               }
               , new Object[] {
               T000H11_A119BR_MedicationID
               }
               , new Object[] {
               T000H12_A119BR_MedicationID
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               T000H15_A85BR_Information_ID, T000H15_n85BR_Information_ID
               }
               , new Object[] {
               T000H16_A36BR_Information_PatientNo, T000H16_n36BR_Information_PatientNo
               }
               , new Object[] {
               T000H17_A332BR_Scheme_MedicationID
               }
               , new Object[] {
               T000H18_A296BR_Medication_SchemeID
               }
               , new Object[] {
               T000H19_A119BR_MedicationID
               }
               , new Object[] {
               T000H20_A167XT_DefineCodeID, T000H20_A168XT_DefineCodeName, T000H20_n168XT_DefineCodeName, T000H20_A165XT_DefindcodeTypeID, T000H20_A432XT_TenantCode, T000H20_n432XT_TenantCode
               }
               , new Object[] {
               T000H21_A167XT_DefineCodeID, T000H21_A168XT_DefineCodeName, T000H21_n168XT_DefineCodeName, T000H21_A165XT_DefindcodeTypeID, T000H21_A432XT_TenantCode, T000H21_n432XT_TenantCode
               }
               , new Object[] {
               T000H22_A167XT_DefineCodeID, T000H22_A168XT_DefineCodeName, T000H22_n168XT_DefineCodeName, T000H22_A165XT_DefindcodeTypeID, T000H22_A432XT_TenantCode, T000H22_n432XT_TenantCode
               }
               , new Object[] {
               T000H23_A85BR_Information_ID, T000H23_n85BR_Information_ID
               }
               , new Object[] {
               T000H24_A36BR_Information_PatientNo, T000H24_n36BR_Information_PatientNo
               }
            }
         );
         AV22Pgmname = "BR_Medication";
      }

      private short Z120BR_Medication_RXID ;
      private short GxWebError ;
      private short gxcookieaux ;
      private short IsConfirmed ;
      private short IsModified ;
      private short AnyError ;
      private short nKeyPressed ;
      private short initialized ;
      private short A120BR_Medication_RXID ;
      private short RcdFound18 ;
      private short GX_JID ;
      private short Gx_BScreen ;
      private short gxajaxcallmode ;
      private short wbTemp ;
      private int trnEnded ;
      private int edtBR_Medication_RXCode_Enabled ;
      private int edtBR_Medication_RXType_Enabled ;
      private int edtBR_Medication_RXDose_Enabled ;
      private int edtBR_Medication_RXUnit_Enabled ;
      private int edtBR_Medication_RXQuantity_Enabled ;
      private int edtBR_Medication_RXDaysSupply_Enabled ;
      private int edtBR_Medication_PrescriptionDate_Enabled ;
      private int edtBR_Medication_AdmitStartDate_Enabled ;
      private int edtBR_Medication_AdmitEndDate_Enabled ;
      private int bttBtntrn_enter_Visible ;
      private int bttBtntrn_enter_Enabled ;
      private int bttBtntrn_cancel_Visible ;
      private int bttBtntrn_delete_Visible ;
      private int bttBtntrn_delete_Enabled ;
      private int edtBR_MedicationID_Enabled ;
      private int edtBR_MedicationID_Visible ;
      private int edtBR_EncounterID_Visible ;
      private int edtBR_EncounterID_Enabled ;
      private int edtBR_Information_PatientNo_Visible ;
      private int edtBR_Information_PatientNo_Enabled ;
      private int edtavVrxroute_Visible ;
      private int edtavVrxroute_Enabled ;
      private int edtavVfrequency_Visible ;
      private int edtavVfrequency_Enabled ;
      private int edtavVmedicationname_Visible ;
      private int edtavVmedicationname_Enabled ;
      private int AV23GXV1 ;
      private int idxLst ;
      private int gxdynajaxindex ;
      private long wcpOAV12BR_MedicationID ;
      private long Z119BR_MedicationID ;
      private long Z19BR_EncounterID ;
      private long N19BR_EncounterID ;
      private long A19BR_EncounterID ;
      private long A85BR_Information_ID ;
      private long AV12BR_MedicationID ;
      private long A119BR_MedicationID ;
      private long AV10Insert_BR_EncounterID ;
      private long Z85BR_Information_ID ;
      private decimal Z124BR_Medication_RXDose ;
      private decimal Z128BR_Medication_RXDaysSupply ;
      private decimal A124BR_Medication_RXDose ;
      private decimal A128BR_Medication_RXDaysSupply ;
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
      private String dynBR_Medication_RXName_Internalname ;
      private String dynBR_Medication_RXFrequency_Internalname ;
      private String dynBR_Medication_RXRoute_Internalname ;
      private String cmbBR_Medication_InpatientChemo_Internalname ;
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
      private String divTablesplittedbr_medication_rxname_Internalname ;
      private String lblTextblockbr_medication_rxname_Internalname ;
      private String lblTextblockbr_medication_rxname_Jsonclick ;
      private String edtBR_Medication_RXCode_Internalname ;
      private String TempTags ;
      private String edtBR_Medication_RXCode_Jsonclick ;
      private String edtBR_Medication_RXType_Internalname ;
      private String edtBR_Medication_RXType_Jsonclick ;
      private String edtBR_Medication_RXDose_Internalname ;
      private String edtBR_Medication_RXDose_Jsonclick ;
      private String edtBR_Medication_RXUnit_Internalname ;
      private String edtBR_Medication_RXUnit_Jsonclick ;
      private String divTablesplittedbr_medication_rxfrequency_Internalname ;
      private String lblTextblockbr_medication_rxfrequency_Internalname ;
      private String lblTextblockbr_medication_rxfrequency_Jsonclick ;
      private String edtBR_Medication_RXQuantity_Internalname ;
      private String edtBR_Medication_RXQuantity_Jsonclick ;
      private String edtBR_Medication_RXDaysSupply_Internalname ;
      private String edtBR_Medication_RXDaysSupply_Jsonclick ;
      private String divTablesplittedbr_medication_rxroute_Internalname ;
      private String lblTextblockbr_medication_rxroute_Internalname ;
      private String lblTextblockbr_medication_rxroute_Jsonclick ;
      private String edtBR_Medication_PrescriptionDate_Internalname ;
      private String edtBR_Medication_PrescriptionDate_Jsonclick ;
      private String edtBR_Medication_AdmitStartDate_Internalname ;
      private String edtBR_Medication_AdmitStartDate_Jsonclick ;
      private String edtBR_Medication_AdmitEndDate_Internalname ;
      private String edtBR_Medication_AdmitEndDate_Jsonclick ;
      private String cmbBR_Medication_InpatientChemo_Jsonclick ;
      private String bttBtntrn_enter_Internalname ;
      private String bttBtntrn_enter_Jsonclick ;
      private String bttBtntrn_cancel_Internalname ;
      private String bttBtntrn_cancel_Jsonclick ;
      private String bttBtntrn_delete_Internalname ;
      private String bttBtntrn_delete_Jsonclick ;
      private String divHtml_bottomauxiliarcontrols_Internalname ;
      private String edtBR_MedicationID_Internalname ;
      private String edtBR_MedicationID_Jsonclick ;
      private String edtBR_EncounterID_Internalname ;
      private String edtBR_EncounterID_Jsonclick ;
      private String edtBR_Information_PatientNo_Internalname ;
      private String edtBR_Information_PatientNo_Jsonclick ;
      private String sStyleString ;
      private String tblTablemergedbr_medication_rxroute_Internalname ;
      private String dynBR_Medication_RXRoute_Jsonclick ;
      private String cellVrxroute_cell_Internalname ;
      private String cellVrxroute_cell_Class ;
      private String edtavVrxroute_Internalname ;
      private String edtavVrxroute_Jsonclick ;
      private String tblTablemergedbr_medication_rxfrequency_Internalname ;
      private String dynBR_Medication_RXFrequency_Jsonclick ;
      private String cellVfrequency_cell_Internalname ;
      private String cellVfrequency_cell_Class ;
      private String edtavVfrequency_Internalname ;
      private String edtavVfrequency_Jsonclick ;
      private String tblTablemergedbr_medication_rxname_Internalname ;
      private String dynBR_Medication_RXName_Jsonclick ;
      private String cellVmedicationname_cell_Internalname ;
      private String cellVmedicationname_cell_Class ;
      private String edtavVmedicationname_Internalname ;
      private String edtavVmedicationname_Jsonclick ;
      private String AV22Pgmname ;
      private String Dvpanel_tableattributes_Objectcall ;
      private String Dvpanel_tableattributes_Class ;
      private String Dvpanel_tableattributes_Height ;
      private String forbiddenHiddens ;
      private String hsh ;
      private String sMode18 ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String sDynURL ;
      private String FormProcess ;
      private String bodyStyle ;
      private String gxwrpcisep ;
      private String GXt_char1 ;
      private DateTime Z130BR_Medication_PrescriptionDate ;
      private DateTime Z132BR_Medication_AdmitStartDate ;
      private DateTime Z133BR_Medication_AdmitEndDate ;
      private DateTime A130BR_Medication_PrescriptionDate ;
      private DateTime A132BR_Medication_AdmitStartDate ;
      private DateTime A133BR_Medication_AdmitEndDate ;
      private bool entryPointCalled ;
      private bool n126BR_Medication_RXFrequency ;
      private bool n129BR_Medication_RXRoute ;
      private bool n131BR_Medication_InpatientChemo ;
      private bool n85BR_Information_ID ;
      private bool toggleJsOutput ;
      private bool wbErr ;
      private bool n121BR_Medication_RXName ;
      private bool Dvpanel_tableattributes_Autowidth ;
      private bool Dvpanel_tableattributes_Autoheight ;
      private bool Dvpanel_tableattributes_Collapsible ;
      private bool Dvpanel_tableattributes_Collapsed ;
      private bool Dvpanel_tableattributes_Showcollapseicon ;
      private bool Dvpanel_tableattributes_Autoscroll ;
      private bool n122BR_Medication_RXCode ;
      private bool n123BR_Medication_RXType ;
      private bool n124BR_Medication_RXDose ;
      private bool n125BR_Medication_RXUnit ;
      private bool n127BR_Medication_RXQuantity ;
      private bool n128BR_Medication_RXDaysSupply ;
      private bool n130BR_Medication_PrescriptionDate ;
      private bool n132BR_Medication_AdmitStartDate ;
      private bool n133BR_Medication_AdmitEndDate ;
      private bool n119BR_MedicationID ;
      private bool n36BR_Information_PatientNo ;
      private bool n478BR_Medication_RXFrequency_Code ;
      private bool n477BR_Medication_RXRoute_Code ;
      private bool n507BR_Medication_InpatientChemo_Code ;
      private bool n120BR_Medication_RXID ;
      private bool n499BR_Medication_RXName_Code ;
      private bool Dvpanel_tableattributes_Enabled ;
      private bool Dvpanel_tableattributes_Showheader ;
      private bool Dvpanel_tableattributes_Visible ;
      private bool AV13IsAuthorized ;
      private bool GXt_boolean2 ;
      private bool returnInSub ;
      private bool Gx_longc ;
      private bool gxdyncontrolsrefreshing ;
      private String Z478BR_Medication_RXFrequency_Code ;
      private String Z477BR_Medication_RXRoute_Code ;
      private String Z507BR_Medication_InpatientChemo_Code ;
      private String Z121BR_Medication_RXName ;
      private String Z499BR_Medication_RXName_Code ;
      private String Z122BR_Medication_RXCode ;
      private String Z123BR_Medication_RXType ;
      private String Z125BR_Medication_RXUnit ;
      private String Z126BR_Medication_RXFrequency ;
      private String Z127BR_Medication_RXQuantity ;
      private String Z129BR_Medication_RXRoute ;
      private String Z131BR_Medication_InpatientChemo ;
      private String AV21tCurrentCode ;
      private String A126BR_Medication_RXFrequency ;
      private String A129BR_Medication_RXRoute ;
      private String A131BR_Medication_InpatientChemo ;
      private String A121BR_Medication_RXName ;
      private String A122BR_Medication_RXCode ;
      private String A123BR_Medication_RXType ;
      private String A125BR_Medication_RXUnit ;
      private String A127BR_Medication_RXQuantity ;
      private String A36BR_Information_PatientNo ;
      private String AV15vRXRoute ;
      private String AV19vFrequency ;
      private String AV20vMedicationName ;
      private String A478BR_Medication_RXFrequency_Code ;
      private String A477BR_Medication_RXRoute_Code ;
      private String A507BR_Medication_InpatientChemo_Code ;
      private String A499BR_Medication_RXName_Code ;
      private String Z36BR_Information_PatientNo ;
      private IGxSession AV9WebSession ;
      private GeneXus.Utils.GxStringCollection gxdynajaxctrlcodr ;
      private GeneXus.Utils.GxStringCollection gxdynajaxctrldescr ;
      private GxUnknownObjectCollection isValidOutput ;
      private GXUserControl ucDvpanel_tableattributes ;
      private IGxDataStore dsDataStore1 ;
      private IGxDataStore dsDefault ;
      private GXCombobox dynBR_Medication_RXName ;
      private GXCombobox dynBR_Medication_RXFrequency ;
      private GXCombobox dynBR_Medication_RXRoute ;
      private GXCombobox cmbBR_Medication_InpatientChemo ;
      private IDataStoreProvider pr_default ;
      private long[] T000H4_A85BR_Information_ID ;
      private bool[] T000H4_n85BR_Information_ID ;
      private String[] T000H5_A36BR_Information_PatientNo ;
      private bool[] T000H5_n36BR_Information_PatientNo ;
      private long[] T000H6_A85BR_Information_ID ;
      private bool[] T000H6_n85BR_Information_ID ;
      private long[] T000H6_A119BR_MedicationID ;
      private bool[] T000H6_n119BR_MedicationID ;
      private String[] T000H6_A478BR_Medication_RXFrequency_Code ;
      private bool[] T000H6_n478BR_Medication_RXFrequency_Code ;
      private String[] T000H6_A477BR_Medication_RXRoute_Code ;
      private bool[] T000H6_n477BR_Medication_RXRoute_Code ;
      private String[] T000H6_A507BR_Medication_InpatientChemo_Code ;
      private bool[] T000H6_n507BR_Medication_InpatientChemo_Code ;
      private String[] T000H6_A36BR_Information_PatientNo ;
      private bool[] T000H6_n36BR_Information_PatientNo ;
      private short[] T000H6_A120BR_Medication_RXID ;
      private bool[] T000H6_n120BR_Medication_RXID ;
      private String[] T000H6_A121BR_Medication_RXName ;
      private bool[] T000H6_n121BR_Medication_RXName ;
      private String[] T000H6_A499BR_Medication_RXName_Code ;
      private bool[] T000H6_n499BR_Medication_RXName_Code ;
      private String[] T000H6_A122BR_Medication_RXCode ;
      private bool[] T000H6_n122BR_Medication_RXCode ;
      private String[] T000H6_A123BR_Medication_RXType ;
      private bool[] T000H6_n123BR_Medication_RXType ;
      private decimal[] T000H6_A124BR_Medication_RXDose ;
      private bool[] T000H6_n124BR_Medication_RXDose ;
      private String[] T000H6_A125BR_Medication_RXUnit ;
      private bool[] T000H6_n125BR_Medication_RXUnit ;
      private String[] T000H6_A126BR_Medication_RXFrequency ;
      private bool[] T000H6_n126BR_Medication_RXFrequency ;
      private String[] T000H6_A127BR_Medication_RXQuantity ;
      private bool[] T000H6_n127BR_Medication_RXQuantity ;
      private decimal[] T000H6_A128BR_Medication_RXDaysSupply ;
      private bool[] T000H6_n128BR_Medication_RXDaysSupply ;
      private String[] T000H6_A129BR_Medication_RXRoute ;
      private bool[] T000H6_n129BR_Medication_RXRoute ;
      private DateTime[] T000H6_A130BR_Medication_PrescriptionDate ;
      private bool[] T000H6_n130BR_Medication_PrescriptionDate ;
      private DateTime[] T000H6_A132BR_Medication_AdmitStartDate ;
      private bool[] T000H6_n132BR_Medication_AdmitStartDate ;
      private DateTime[] T000H6_A133BR_Medication_AdmitEndDate ;
      private bool[] T000H6_n133BR_Medication_AdmitEndDate ;
      private String[] T000H6_A131BR_Medication_InpatientChemo ;
      private bool[] T000H6_n131BR_Medication_InpatientChemo ;
      private long[] T000H6_A19BR_EncounterID ;
      private long[] T000H7_A85BR_Information_ID ;
      private bool[] T000H7_n85BR_Information_ID ;
      private String[] T000H8_A36BR_Information_PatientNo ;
      private bool[] T000H8_n36BR_Information_PatientNo ;
      private long[] T000H9_A119BR_MedicationID ;
      private bool[] T000H9_n119BR_MedicationID ;
      private long[] T000H3_A119BR_MedicationID ;
      private bool[] T000H3_n119BR_MedicationID ;
      private String[] T000H3_A478BR_Medication_RXFrequency_Code ;
      private bool[] T000H3_n478BR_Medication_RXFrequency_Code ;
      private String[] T000H3_A477BR_Medication_RXRoute_Code ;
      private bool[] T000H3_n477BR_Medication_RXRoute_Code ;
      private String[] T000H3_A507BR_Medication_InpatientChemo_Code ;
      private bool[] T000H3_n507BR_Medication_InpatientChemo_Code ;
      private short[] T000H3_A120BR_Medication_RXID ;
      private bool[] T000H3_n120BR_Medication_RXID ;
      private String[] T000H3_A121BR_Medication_RXName ;
      private bool[] T000H3_n121BR_Medication_RXName ;
      private String[] T000H3_A499BR_Medication_RXName_Code ;
      private bool[] T000H3_n499BR_Medication_RXName_Code ;
      private String[] T000H3_A122BR_Medication_RXCode ;
      private bool[] T000H3_n122BR_Medication_RXCode ;
      private String[] T000H3_A123BR_Medication_RXType ;
      private bool[] T000H3_n123BR_Medication_RXType ;
      private decimal[] T000H3_A124BR_Medication_RXDose ;
      private bool[] T000H3_n124BR_Medication_RXDose ;
      private String[] T000H3_A125BR_Medication_RXUnit ;
      private bool[] T000H3_n125BR_Medication_RXUnit ;
      private String[] T000H3_A126BR_Medication_RXFrequency ;
      private bool[] T000H3_n126BR_Medication_RXFrequency ;
      private String[] T000H3_A127BR_Medication_RXQuantity ;
      private bool[] T000H3_n127BR_Medication_RXQuantity ;
      private decimal[] T000H3_A128BR_Medication_RXDaysSupply ;
      private bool[] T000H3_n128BR_Medication_RXDaysSupply ;
      private String[] T000H3_A129BR_Medication_RXRoute ;
      private bool[] T000H3_n129BR_Medication_RXRoute ;
      private DateTime[] T000H3_A130BR_Medication_PrescriptionDate ;
      private bool[] T000H3_n130BR_Medication_PrescriptionDate ;
      private DateTime[] T000H3_A132BR_Medication_AdmitStartDate ;
      private bool[] T000H3_n132BR_Medication_AdmitStartDate ;
      private DateTime[] T000H3_A133BR_Medication_AdmitEndDate ;
      private bool[] T000H3_n133BR_Medication_AdmitEndDate ;
      private String[] T000H3_A131BR_Medication_InpatientChemo ;
      private bool[] T000H3_n131BR_Medication_InpatientChemo ;
      private long[] T000H3_A19BR_EncounterID ;
      private long[] T000H10_A119BR_MedicationID ;
      private bool[] T000H10_n119BR_MedicationID ;
      private long[] T000H11_A119BR_MedicationID ;
      private bool[] T000H11_n119BR_MedicationID ;
      private long[] T000H2_A119BR_MedicationID ;
      private bool[] T000H2_n119BR_MedicationID ;
      private String[] T000H2_A478BR_Medication_RXFrequency_Code ;
      private bool[] T000H2_n478BR_Medication_RXFrequency_Code ;
      private String[] T000H2_A477BR_Medication_RXRoute_Code ;
      private bool[] T000H2_n477BR_Medication_RXRoute_Code ;
      private String[] T000H2_A507BR_Medication_InpatientChemo_Code ;
      private bool[] T000H2_n507BR_Medication_InpatientChemo_Code ;
      private short[] T000H2_A120BR_Medication_RXID ;
      private bool[] T000H2_n120BR_Medication_RXID ;
      private String[] T000H2_A121BR_Medication_RXName ;
      private bool[] T000H2_n121BR_Medication_RXName ;
      private String[] T000H2_A499BR_Medication_RXName_Code ;
      private bool[] T000H2_n499BR_Medication_RXName_Code ;
      private String[] T000H2_A122BR_Medication_RXCode ;
      private bool[] T000H2_n122BR_Medication_RXCode ;
      private String[] T000H2_A123BR_Medication_RXType ;
      private bool[] T000H2_n123BR_Medication_RXType ;
      private decimal[] T000H2_A124BR_Medication_RXDose ;
      private bool[] T000H2_n124BR_Medication_RXDose ;
      private String[] T000H2_A125BR_Medication_RXUnit ;
      private bool[] T000H2_n125BR_Medication_RXUnit ;
      private String[] T000H2_A126BR_Medication_RXFrequency ;
      private bool[] T000H2_n126BR_Medication_RXFrequency ;
      private String[] T000H2_A127BR_Medication_RXQuantity ;
      private bool[] T000H2_n127BR_Medication_RXQuantity ;
      private decimal[] T000H2_A128BR_Medication_RXDaysSupply ;
      private bool[] T000H2_n128BR_Medication_RXDaysSupply ;
      private String[] T000H2_A129BR_Medication_RXRoute ;
      private bool[] T000H2_n129BR_Medication_RXRoute ;
      private DateTime[] T000H2_A130BR_Medication_PrescriptionDate ;
      private bool[] T000H2_n130BR_Medication_PrescriptionDate ;
      private DateTime[] T000H2_A132BR_Medication_AdmitStartDate ;
      private bool[] T000H2_n132BR_Medication_AdmitStartDate ;
      private DateTime[] T000H2_A133BR_Medication_AdmitEndDate ;
      private bool[] T000H2_n133BR_Medication_AdmitEndDate ;
      private String[] T000H2_A131BR_Medication_InpatientChemo ;
      private bool[] T000H2_n131BR_Medication_InpatientChemo ;
      private long[] T000H2_A19BR_EncounterID ;
      private long[] T000H12_A119BR_MedicationID ;
      private bool[] T000H12_n119BR_MedicationID ;
      private long[] T000H15_A85BR_Information_ID ;
      private bool[] T000H15_n85BR_Information_ID ;
      private String[] T000H16_A36BR_Information_PatientNo ;
      private bool[] T000H16_n36BR_Information_PatientNo ;
      private long[] T000H17_A332BR_Scheme_MedicationID ;
      private long[] T000H18_A296BR_Medication_SchemeID ;
      private long[] T000H19_A119BR_MedicationID ;
      private bool[] T000H19_n119BR_MedicationID ;
      private long[] T000H20_A167XT_DefineCodeID ;
      private String[] T000H20_A168XT_DefineCodeName ;
      private bool[] T000H20_n168XT_DefineCodeName ;
      private long[] T000H20_A165XT_DefindcodeTypeID ;
      private String[] T000H20_A432XT_TenantCode ;
      private bool[] T000H20_n432XT_TenantCode ;
      private long[] T000H21_A167XT_DefineCodeID ;
      private String[] T000H21_A168XT_DefineCodeName ;
      private bool[] T000H21_n168XT_DefineCodeName ;
      private long[] T000H21_A165XT_DefindcodeTypeID ;
      private String[] T000H21_A432XT_TenantCode ;
      private bool[] T000H21_n432XT_TenantCode ;
      private long[] T000H22_A167XT_DefineCodeID ;
      private String[] T000H22_A168XT_DefineCodeName ;
      private bool[] T000H22_n168XT_DefineCodeName ;
      private long[] T000H22_A165XT_DefindcodeTypeID ;
      private String[] T000H22_A432XT_TenantCode ;
      private bool[] T000H22_n432XT_TenantCode ;
      private long[] T000H23_A85BR_Information_ID ;
      private bool[] T000H23_n85BR_Information_ID ;
      private String[] T000H24_A36BR_Information_PatientNo ;
      private bool[] T000H24_n36BR_Information_PatientNo ;
      private IDataStoreProvider pr_datastore1 ;
      private GXWebForm Form ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPContext AV7WWPContext ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext AV8TrnContext ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext_Attribute AV11TrnContextAtt ;
   }

   public class br_medication__datastore1 : DataStoreHelperBase, IDataStoreHelper
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

 public class br_medication__default : DataStoreHelperBase, IDataStoreHelper
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
     };
  }

  private static CursorDef[] def;
  private void cursorDefinitions( )
  {
     if ( def == null )
     {
        Object[] prmT000H6 ;
        prmT000H6 = new Object[] {
        new Object[] {"@BR_MedicationID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000H4 ;
        prmT000H4 = new Object[] {
        new Object[] {"@BR_EncounterID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000H5 ;
        prmT000H5 = new Object[] {
        new Object[] {"@BR_Information_ID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000H7 ;
        prmT000H7 = new Object[] {
        new Object[] {"@BR_EncounterID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000H8 ;
        prmT000H8 = new Object[] {
        new Object[] {"@BR_Information_ID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000H9 ;
        prmT000H9 = new Object[] {
        new Object[] {"@BR_MedicationID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000H3 ;
        prmT000H3 = new Object[] {
        new Object[] {"@BR_MedicationID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000H10 ;
        prmT000H10 = new Object[] {
        new Object[] {"@BR_MedicationID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000H11 ;
        prmT000H11 = new Object[] {
        new Object[] {"@BR_MedicationID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000H2 ;
        prmT000H2 = new Object[] {
        new Object[] {"@BR_MedicationID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000H12 ;
        prmT000H12 = new Object[] {
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
        Object[] prmT000H13 ;
        prmT000H13 = new Object[] {
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
        Object[] prmT000H14 ;
        prmT000H14 = new Object[] {
        new Object[] {"@BR_MedicationID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000H15 ;
        prmT000H15 = new Object[] {
        new Object[] {"@BR_EncounterID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000H16 ;
        prmT000H16 = new Object[] {
        new Object[] {"@BR_Information_ID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000H17 ;
        prmT000H17 = new Object[] {
        new Object[] {"@BR_MedicationID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000H18 ;
        prmT000H18 = new Object[] {
        new Object[] {"@BR_MedicationID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000H19 ;
        prmT000H19 = new Object[] {
        } ;
        Object[] prmT000H20 ;
        prmT000H20 = new Object[] {
        new Object[] {"@AV21tCurrentCode",SqlDbType.NVarChar,40,0}
        } ;
        Object[] prmT000H21 ;
        prmT000H21 = new Object[] {
        new Object[] {"@AV21tCurrentCode",SqlDbType.NVarChar,40,0}
        } ;
        Object[] prmT000H22 ;
        prmT000H22 = new Object[] {
        new Object[] {"@AV21tCurrentCode",SqlDbType.NVarChar,40,0}
        } ;
        Object[] prmT000H23 ;
        prmT000H23 = new Object[] {
        new Object[] {"@BR_EncounterID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000H24 ;
        prmT000H24 = new Object[] {
        new Object[] {"@BR_Information_ID",SqlDbType.Decimal,18,0}
        } ;
        def= new CursorDef[] {
            new CursorDef("T000H2", "SELECT [BR_MedicationID], [BR_Medication_RXFrequency_Code], [BR_Medication_RXRoute_Code], [BR_Medication_InpatientChemo_Code], [BR_Medication_RXID], [BR_Medication_RXName], [BR_Medication_RXName_Code], [BR_Medication_RXCode], [BR_Medication_RXType], [BR_Medication_RXDose], [BR_Medication_RXUnit], [BR_Medication_RXFrequency], [BR_Medication_RXQuantity], [BR_Medication_RXDaysSupply], [BR_Medication_RXRoute], [BR_Medication_PrescriptionDate], [BR_Medication_AdmitStartDate], [BR_Medication_AdmitEndDate], [BR_Medication_InpatientChemo], [BR_EncounterID] FROM [BR_Medication] WITH (UPDLOCK) WHERE [BR_MedicationID] = @BR_MedicationID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000H2,1,0,true,false )
           ,new CursorDef("T000H3", "SELECT [BR_MedicationID], [BR_Medication_RXFrequency_Code], [BR_Medication_RXRoute_Code], [BR_Medication_InpatientChemo_Code], [BR_Medication_RXID], [BR_Medication_RXName], [BR_Medication_RXName_Code], [BR_Medication_RXCode], [BR_Medication_RXType], [BR_Medication_RXDose], [BR_Medication_RXUnit], [BR_Medication_RXFrequency], [BR_Medication_RXQuantity], [BR_Medication_RXDaysSupply], [BR_Medication_RXRoute], [BR_Medication_PrescriptionDate], [BR_Medication_AdmitStartDate], [BR_Medication_AdmitEndDate], [BR_Medication_InpatientChemo], [BR_EncounterID] FROM [BR_Medication] WITH (NOLOCK) WHERE [BR_MedicationID] = @BR_MedicationID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000H3,1,0,true,false )
           ,new CursorDef("T000H4", "SELECT [BR_Information_ID] FROM [BR_Encounter] WITH (NOLOCK) WHERE [BR_EncounterID] = @BR_EncounterID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000H4,1,0,true,false )
           ,new CursorDef("T000H5", "SELECT [BR_Information_PatientNo] FROM [BR_Information] WITH (NOLOCK) WHERE [BR_Information_ID] = @BR_Information_ID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000H5,1,0,true,false )
           ,new CursorDef("T000H6", "SELECT T2.[BR_Information_ID], TM1.[BR_MedicationID], TM1.[BR_Medication_RXFrequency_Code], TM1.[BR_Medication_RXRoute_Code], TM1.[BR_Medication_InpatientChemo_Code], T3.[BR_Information_PatientNo], TM1.[BR_Medication_RXID], TM1.[BR_Medication_RXName], TM1.[BR_Medication_RXName_Code], TM1.[BR_Medication_RXCode], TM1.[BR_Medication_RXType], TM1.[BR_Medication_RXDose], TM1.[BR_Medication_RXUnit], TM1.[BR_Medication_RXFrequency], TM1.[BR_Medication_RXQuantity], TM1.[BR_Medication_RXDaysSupply], TM1.[BR_Medication_RXRoute], TM1.[BR_Medication_PrescriptionDate], TM1.[BR_Medication_AdmitStartDate], TM1.[BR_Medication_AdmitEndDate], TM1.[BR_Medication_InpatientChemo], TM1.[BR_EncounterID] FROM (([BR_Medication] TM1 WITH (NOLOCK) INNER JOIN [BR_Encounter] T2 WITH (NOLOCK) ON T2.[BR_EncounterID] = TM1.[BR_EncounterID]) LEFT JOIN [BR_Information] T3 WITH (NOLOCK) ON T3.[BR_Information_ID] = T2.[BR_Information_ID]) WHERE TM1.[BR_MedicationID] = @BR_MedicationID ORDER BY TM1.[BR_MedicationID]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT000H6,100,0,true,false )
           ,new CursorDef("T000H7", "SELECT [BR_Information_ID] FROM [BR_Encounter] WITH (NOLOCK) WHERE [BR_EncounterID] = @BR_EncounterID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000H7,1,0,true,false )
           ,new CursorDef("T000H8", "SELECT [BR_Information_PatientNo] FROM [BR_Information] WITH (NOLOCK) WHERE [BR_Information_ID] = @BR_Information_ID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000H8,1,0,true,false )
           ,new CursorDef("T000H9", "SELECT [BR_MedicationID] FROM [BR_Medication] WITH (NOLOCK) WHERE [BR_MedicationID] = @BR_MedicationID  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000H9,1,0,true,false )
           ,new CursorDef("T000H10", "SELECT TOP 1 [BR_MedicationID] FROM [BR_Medication] WITH (NOLOCK) WHERE ( [BR_MedicationID] > @BR_MedicationID) ORDER BY [BR_MedicationID]  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000H10,1,0,true,true )
           ,new CursorDef("T000H11", "SELECT TOP 1 [BR_MedicationID] FROM [BR_Medication] WITH (NOLOCK) WHERE ( [BR_MedicationID] < @BR_MedicationID) ORDER BY [BR_MedicationID] DESC  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000H11,1,0,true,true )
           ,new CursorDef("T000H12", "INSERT INTO [BR_Medication]([BR_Medication_RXFrequency_Code], [BR_Medication_RXRoute_Code], [BR_Medication_InpatientChemo_Code], [BR_Medication_RXID], [BR_Medication_RXName], [BR_Medication_RXName_Code], [BR_Medication_RXCode], [BR_Medication_RXType], [BR_Medication_RXDose], [BR_Medication_RXUnit], [BR_Medication_RXFrequency], [BR_Medication_RXQuantity], [BR_Medication_RXDaysSupply], [BR_Medication_RXRoute], [BR_Medication_PrescriptionDate], [BR_Medication_AdmitStartDate], [BR_Medication_AdmitEndDate], [BR_Medication_InpatientChemo], [BR_EncounterID]) VALUES(@BR_Medication_RXFrequency_Code, @BR_Medication_RXRoute_Code, @BR_Medication_InpatientChemo_Code, @BR_Medication_RXID, @BR_Medication_RXName, @BR_Medication_RXName_Code, @BR_Medication_RXCode, @BR_Medication_RXType, @BR_Medication_RXDose, @BR_Medication_RXUnit, @BR_Medication_RXFrequency, @BR_Medication_RXQuantity, @BR_Medication_RXDaysSupply, @BR_Medication_RXRoute, @BR_Medication_PrescriptionDate, @BR_Medication_AdmitStartDate, @BR_Medication_AdmitEndDate, @BR_Medication_InpatientChemo, @BR_EncounterID); SELECT SCOPE_IDENTITY()", GxErrorMask.GX_NOMASK,prmT000H12)
           ,new CursorDef("T000H13", "UPDATE [BR_Medication] SET [BR_Medication_RXFrequency_Code]=@BR_Medication_RXFrequency_Code, [BR_Medication_RXRoute_Code]=@BR_Medication_RXRoute_Code, [BR_Medication_InpatientChemo_Code]=@BR_Medication_InpatientChemo_Code, [BR_Medication_RXID]=@BR_Medication_RXID, [BR_Medication_RXName]=@BR_Medication_RXName, [BR_Medication_RXName_Code]=@BR_Medication_RXName_Code, [BR_Medication_RXCode]=@BR_Medication_RXCode, [BR_Medication_RXType]=@BR_Medication_RXType, [BR_Medication_RXDose]=@BR_Medication_RXDose, [BR_Medication_RXUnit]=@BR_Medication_RXUnit, [BR_Medication_RXFrequency]=@BR_Medication_RXFrequency, [BR_Medication_RXQuantity]=@BR_Medication_RXQuantity, [BR_Medication_RXDaysSupply]=@BR_Medication_RXDaysSupply, [BR_Medication_RXRoute]=@BR_Medication_RXRoute, [BR_Medication_PrescriptionDate]=@BR_Medication_PrescriptionDate, [BR_Medication_AdmitStartDate]=@BR_Medication_AdmitStartDate, [BR_Medication_AdmitEndDate]=@BR_Medication_AdmitEndDate, [BR_Medication_InpatientChemo]=@BR_Medication_InpatientChemo, [BR_EncounterID]=@BR_EncounterID  WHERE [BR_MedicationID] = @BR_MedicationID", GxErrorMask.GX_NOMASK,prmT000H13)
           ,new CursorDef("T000H14", "DELETE FROM [BR_Medication]  WHERE [BR_MedicationID] = @BR_MedicationID", GxErrorMask.GX_NOMASK,prmT000H14)
           ,new CursorDef("T000H15", "SELECT [BR_Information_ID] FROM [BR_Encounter] WITH (NOLOCK) WHERE [BR_EncounterID] = @BR_EncounterID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000H15,1,0,true,false )
           ,new CursorDef("T000H16", "SELECT [BR_Information_PatientNo] FROM [BR_Information] WITH (NOLOCK) WHERE [BR_Information_ID] = @BR_Information_ID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000H16,1,0,true,false )
           ,new CursorDef("T000H17", "SELECT TOP 1 [BR_Scheme_MedicationID] FROM [BR_Scheme_Medication] WITH (NOLOCK) WHERE [BR_MedicationID] = @BR_MedicationID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000H17,1,0,true,true )
           ,new CursorDef("T000H18", "SELECT TOP 1 [BR_Medication_SchemeID] FROM [BR_Medication_Scheme] WITH (NOLOCK) WHERE [BR_MedicationID] = @BR_MedicationID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000H18,1,0,true,true )
           ,new CursorDef("T000H19", "SELECT [BR_MedicationID] FROM [BR_Medication] WITH (NOLOCK) ORDER BY [BR_MedicationID]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT000H19,100,0,true,false )
           ,new CursorDef("T000H20", "SELECT [XT_DefineCodeID], [XT_DefineCodeName], [XT_DefindcodeTypeID], [XT_TenantCode] FROM [XT_DefineCode] WITH (NOLOCK) WHERE ([XT_DefindcodeTypeID] = 33) AND ([XT_TenantCode] = @AV21tCurrentCode) ",true, GxErrorMask.GX_NOMASK, false, this,prmT000H20,0,0,true,false )
           ,new CursorDef("T000H21", "SELECT [XT_DefineCodeID], [XT_DefineCodeName], [XT_DefindcodeTypeID], [XT_TenantCode] FROM [XT_DefineCode] WITH (NOLOCK) WHERE ([XT_DefindcodeTypeID] = 25) AND ([XT_TenantCode] = @AV21tCurrentCode) ",true, GxErrorMask.GX_NOMASK, false, this,prmT000H21,0,0,true,false )
           ,new CursorDef("T000H22", "SELECT [XT_DefineCodeID], [XT_DefineCodeName], [XT_DefindcodeTypeID], [XT_TenantCode] FROM [XT_DefineCode] WITH (NOLOCK) WHERE ([XT_DefindcodeTypeID] = 26) AND ([XT_TenantCode] = @AV21tCurrentCode) ",true, GxErrorMask.GX_NOMASK, false, this,prmT000H22,0,0,true,false )
           ,new CursorDef("T000H23", "SELECT [BR_Information_ID] FROM [BR_Encounter] WITH (NOLOCK) WHERE [BR_EncounterID] = @BR_EncounterID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000H23,1,0,true,false )
           ,new CursorDef("T000H24", "SELECT [BR_Information_PatientNo] FROM [BR_Information] WITH (NOLOCK) WHERE [BR_Information_ID] = @BR_Information_ID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000H24,1,0,true,false )
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
              return;
           case 17 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              return;
           case 18 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
              ((bool[]) buf[2])[0] = rslt.wasNull(2);
              ((long[]) buf[3])[0] = rslt.getLong(3) ;
              ((String[]) buf[4])[0] = rslt.getVarchar(4) ;
              ((bool[]) buf[5])[0] = rslt.wasNull(4);
              return;
           case 19 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
              ((bool[]) buf[2])[0] = rslt.wasNull(2);
              ((long[]) buf[3])[0] = rslt.getLong(3) ;
              ((String[]) buf[4])[0] = rslt.getVarchar(4) ;
              ((bool[]) buf[5])[0] = rslt.wasNull(4);
              return;
           case 20 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
              ((bool[]) buf[2])[0] = rslt.wasNull(2);
              ((long[]) buf[3])[0] = rslt.getLong(3) ;
              ((String[]) buf[4])[0] = rslt.getVarchar(4) ;
              ((bool[]) buf[5])[0] = rslt.wasNull(4);
              return;
           case 21 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              ((bool[]) buf[1])[0] = rslt.wasNull(1);
              return;
           case 22 :
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
           case 18 :
              stmt.SetParameter(1, (String)parms[0]);
              return;
           case 19 :
              stmt.SetParameter(1, (String)parms[0]);
              return;
           case 20 :
              stmt.SetParameter(1, (String)parms[0]);
              return;
           case 21 :
              stmt.SetParameter(1, (long)parms[0]);
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
     }
  }

}

}
