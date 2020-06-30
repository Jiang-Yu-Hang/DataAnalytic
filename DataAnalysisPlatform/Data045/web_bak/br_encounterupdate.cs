/*
               File: BR_EncounterUpdate
        Description: Data Mgmt Portal - RAAP
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/27/2020 9:39:39.8
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
   public class br_encounterupdate : GXDataArea, System.Web.SessionState.IRequiresSessionState
   {
      public br_encounterupdate( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public br_encounterupdate( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( long aP0_BR_EncounterID ,
                           String aP1_TabCode )
      {
         this.AV10BR_EncounterID = aP0_BR_EncounterID;
         this.AV8TabCode = aP1_TabCode;
         executePrivate();
      }

      void executePrivate( )
      {
         isStatic = false;
         webExecute();
      }

      protected override void createObjects( )
      {
      }

      protected void INITWEB( )
      {
         initialize_properties( ) ;
         if ( nGotPars == 0 )
         {
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
               AV10BR_EncounterID = (long)(NumberUtil.Val( gxfirstwebparm, "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10BR_EncounterID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10BR_EncounterID), 18, 0)));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vBR_ENCOUNTERID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV10BR_EncounterID), "ZZZZZZZZZZZZZZZZZZ"), context));
               if ( StringUtil.StrCmp(gxfirstwebparm, "viewer") != 0 )
               {
                  AV8TabCode = GetNextPar( );
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8TabCode", AV8TabCode);
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vTABCODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( AV8TabCode, "")), context));
               }
            }
            if ( context.isSpaRequest( ) )
            {
               enableJsOutput();
            }
         }
         if ( ! context.IsLocalStorageSupported( ) )
         {
            context.PushCurrentUrl();
         }
      }

      public override void webExecute( )
      {
         if ( initialized == 0 )
         {
            createObjects();
            initialize();
         }
         INITWEB( ) ;
         if ( ! isAjaxCallMode( ) )
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

      public override short ExecuteStartEvent( )
      {
         PA1X2( ) ;
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0));
         if ( ( gxajaxcallmode == 0 ) && ( GxWebError == 0 ) )
         {
            START1X2( ) ;
         }
         return gxajaxcallmode ;
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
         if ( nGXWrapped != 1 )
         {
            MasterPageObj.master_styles();
         }
         if ( ( ( context.GetBrowserType( ) == 1 ) || ( context.GetBrowserType( ) == 5 ) ) && ( StringUtil.StrCmp(context.GetBrowserVersion( ), "7.0") == 0 ) )
         {
            context.AddJavascriptSource("json2.js", "?"+context.GetBuildNumber( 127771), false);
         }
         context.AddJavascriptSource("jquery.js", "?"+context.GetBuildNumber( 127771), false);
         context.AddJavascriptSource("gxtimezone.js", "?"+context.GetBuildNumber( 127771), false);
         context.AddJavascriptSource("gxgral.js", "?"+context.GetBuildNumber( 127771), false);
         context.AddJavascriptSource("gxcfg.js", "?20202279393942", false);
         if ( context.isSpaRequest( ) )
         {
            enableOutput();
         }
         context.AddJavascriptSource("Shared/HistoryManager/HistoryManager.js", "", false);
         context.AddJavascriptSource("Shared/HistoryManager/rsh/json2005.js", "", false);
         context.AddJavascriptSource("Shared/HistoryManager/rsh/rsh.js", "", false);
         context.AddJavascriptSource("Shared/HistoryManager/HistoryManagerCreate.js", "", false);
         context.AddJavascriptSource("Tab/TabRender.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/Shared/DVelopBootstrap.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/ConfirmPanel/BootstrapConfirmPanelRender.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/Shared/DVelopBootstrap.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/ConfirmPanel/BootstrapConfirmPanelRender.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/Shared/DVelopBootstrap.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/ConfirmPanel/BootstrapConfirmPanelRender.js", "", false);
         context.WriteHtmlText( Form.Headerrawhtml) ;
         context.CloseHtmlHeader();
         if ( context.isSpaRequest( ) )
         {
            disableOutput();
         }
         FormProcess = " data-HasEnter=\"false\" data-Skiponenter=\"false\"";
         context.WriteHtmlText( "<body ") ;
         bodyStyle = "" + "background-color:" + context.BuildHTMLColor( Form.Backcolor) + ";color:" + context.BuildHTMLColor( Form.Textcolor) + ";";
         if ( nGXWrapped == 0 )
         {
            bodyStyle = bodyStyle + "-moz-opacity:0;opacity:0;";
         }
         if ( ! ( String.IsNullOrEmpty(StringUtil.RTrim( Form.Background)) ) )
         {
            bodyStyle = bodyStyle + " background-image:url(" + context.convertURL( Form.Background) + ")";
         }
         context.WriteHtmlText( " "+"class=\"form-horizontal Form\""+" "+ "style='"+bodyStyle+"'") ;
         context.WriteHtmlText( FormProcess+">") ;
         context.skipLines(1);
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" autocomplete=\"off\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("br_encounterupdate.aspx") + "?" + UrlEncode("" +AV10BR_EncounterID) + "," + UrlEncode(StringUtil.RTrim(AV8TabCode))+"\">") ;
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
      }

      protected void SendCloseFormHiddens( )
      {
         /* Send hidden variables. */
         /* Send saved values. */
         send_integrity_footer_hashes( ) ;
         GxWebStd.gx_hidden_field( context, "vBR_ENCOUNTERID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV10BR_EncounterID), 18, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "gxhash_vBR_ENCOUNTERID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV10BR_EncounterID), "ZZZZZZZZZZZZZZZZZZ"), context));
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vWWPCONTEXT", AV6WWPContext);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vWWPCONTEXT", AV6WWPContext);
         }
         GxWebStd.gx_hidden_field( context, "vTPAGERETURN", AV18tPageReturn);
         GxWebStd.gx_hidden_field( context, "gxhash_vTPAGERETURN", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( AV18tPageReturn, "")), context));
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vBCBR_ENCOUNTER", AV16BCBR_Encounter);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vBCBR_ENCOUNTER", AV16BCBR_Encounter);
         }
         GxWebStd.gx_hidden_field( context, "BR_ENCOUNTERID", StringUtil.LTrim( StringUtil.NToC( (decimal)(A19BR_EncounterID), 18, 0, ".", "")));
         GxWebStd.gx_boolean_hidden_field( context, "vLOADALLTABS", AV11LoadAllTabs);
         GxWebStd.gx_hidden_field( context, "vSELECTEDTABCODE", StringUtil.RTrim( AV12SelectedTabCode));
         GxWebStd.gx_hidden_field( context, "vTABCODE", StringUtil.RTrim( AV8TabCode));
         GxWebStd.gx_hidden_field( context, "gxhash_vTABCODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( AV8TabCode, "")), context));
         GxWebStd.gx_hidden_field( context, "TABS_Class", StringUtil.RTrim( Tabs_Class));
         GxWebStd.gx_hidden_field( context, "TABS_Activepagecontrolname", StringUtil.RTrim( Tabs_Activepagecontrolname));
         GxWebStd.gx_hidden_field( context, "TABS_Pagecount", StringUtil.LTrim( StringUtil.NToC( (decimal)(Tabs_Pagecount), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "TABS_Historymanagement", StringUtil.BoolToStr( Tabs_Historymanagement));
         GxWebStd.gx_hidden_field( context, "DVELOP_CONFIRMPANEL_CHECK_Title", StringUtil.RTrim( Dvelop_confirmpanel_check_Title));
         GxWebStd.gx_hidden_field( context, "DVELOP_CONFIRMPANEL_CHECK_Confirmationtext", StringUtil.RTrim( Dvelop_confirmpanel_check_Confirmationtext));
         GxWebStd.gx_hidden_field( context, "DVELOP_CONFIRMPANEL_CHECK_Yesbuttoncaption", StringUtil.RTrim( Dvelop_confirmpanel_check_Yesbuttoncaption));
         GxWebStd.gx_hidden_field( context, "DVELOP_CONFIRMPANEL_CHECK_Nobuttoncaption", StringUtil.RTrim( Dvelop_confirmpanel_check_Nobuttoncaption));
         GxWebStd.gx_hidden_field( context, "DVELOP_CONFIRMPANEL_CHECK_Cancelbuttoncaption", StringUtil.RTrim( Dvelop_confirmpanel_check_Cancelbuttoncaption));
         GxWebStd.gx_hidden_field( context, "DVELOP_CONFIRMPANEL_CHECK_Yesbuttonposition", StringUtil.RTrim( Dvelop_confirmpanel_check_Yesbuttonposition));
         GxWebStd.gx_hidden_field( context, "DVELOP_CONFIRMPANEL_CHECK_Confirmtype", StringUtil.RTrim( Dvelop_confirmpanel_check_Confirmtype));
         GxWebStd.gx_hidden_field( context, "DVELOP_CONFIRMPANEL_RECHECK_Title", StringUtil.RTrim( Dvelop_confirmpanel_recheck_Title));
         GxWebStd.gx_hidden_field( context, "DVELOP_CONFIRMPANEL_RECHECK_Confirmationtext", StringUtil.RTrim( Dvelop_confirmpanel_recheck_Confirmationtext));
         GxWebStd.gx_hidden_field( context, "DVELOP_CONFIRMPANEL_RECHECK_Yesbuttoncaption", StringUtil.RTrim( Dvelop_confirmpanel_recheck_Yesbuttoncaption));
         GxWebStd.gx_hidden_field( context, "DVELOP_CONFIRMPANEL_RECHECK_Nobuttoncaption", StringUtil.RTrim( Dvelop_confirmpanel_recheck_Nobuttoncaption));
         GxWebStd.gx_hidden_field( context, "DVELOP_CONFIRMPANEL_RECHECK_Cancelbuttoncaption", StringUtil.RTrim( Dvelop_confirmpanel_recheck_Cancelbuttoncaption));
         GxWebStd.gx_hidden_field( context, "DVELOP_CONFIRMPANEL_RECHECK_Yesbuttonposition", StringUtil.RTrim( Dvelop_confirmpanel_recheck_Yesbuttonposition));
         GxWebStd.gx_hidden_field( context, "DVELOP_CONFIRMPANEL_RECHECK_Confirmtype", StringUtil.RTrim( Dvelop_confirmpanel_recheck_Confirmtype));
         GxWebStd.gx_hidden_field( context, "DVELOP_CONFIRMPANEL_SUBMIT_Title", StringUtil.RTrim( Dvelop_confirmpanel_submit_Title));
         GxWebStd.gx_hidden_field( context, "DVELOP_CONFIRMPANEL_SUBMIT_Confirmationtext", StringUtil.RTrim( Dvelop_confirmpanel_submit_Confirmationtext));
         GxWebStd.gx_hidden_field( context, "DVELOP_CONFIRMPANEL_SUBMIT_Yesbuttoncaption", StringUtil.RTrim( Dvelop_confirmpanel_submit_Yesbuttoncaption));
         GxWebStd.gx_hidden_field( context, "DVELOP_CONFIRMPANEL_SUBMIT_Nobuttoncaption", StringUtil.RTrim( Dvelop_confirmpanel_submit_Nobuttoncaption));
         GxWebStd.gx_hidden_field( context, "DVELOP_CONFIRMPANEL_SUBMIT_Cancelbuttoncaption", StringUtil.RTrim( Dvelop_confirmpanel_submit_Cancelbuttoncaption));
         GxWebStd.gx_hidden_field( context, "DVELOP_CONFIRMPANEL_SUBMIT_Yesbuttonposition", StringUtil.RTrim( Dvelop_confirmpanel_submit_Yesbuttonposition));
         GxWebStd.gx_hidden_field( context, "DVELOP_CONFIRMPANEL_SUBMIT_Confirmtype", StringUtil.RTrim( Dvelop_confirmpanel_submit_Confirmtype));
         GxWebStd.gx_hidden_field( context, "DVELOP_CONFIRMPANEL_CHECK_Result", StringUtil.RTrim( Dvelop_confirmpanel_check_Result));
         GxWebStd.gx_hidden_field( context, "DVELOP_CONFIRMPANEL_RECHECK_Result", StringUtil.RTrim( Dvelop_confirmpanel_recheck_Result));
         GxWebStd.gx_hidden_field( context, "DVELOP_CONFIRMPANEL_SUBMIT_Result", StringUtil.RTrim( Dvelop_confirmpanel_submit_Result));
         GxWebStd.gx_hidden_field( context, "TABS_Activepagecontrolname", StringUtil.RTrim( Tabs_Activepagecontrolname));
         GxWebStd.gx_hidden_field( context, "DVELOP_CONFIRMPANEL_CHECK_Result", StringUtil.RTrim( Dvelop_confirmpanel_check_Result));
         GxWebStd.gx_hidden_field( context, "DVELOP_CONFIRMPANEL_RECHECK_Result", StringUtil.RTrim( Dvelop_confirmpanel_recheck_Result));
         GxWebStd.gx_hidden_field( context, "DVELOP_CONFIRMPANEL_SUBMIT_Result", StringUtil.RTrim( Dvelop_confirmpanel_submit_Result));
         GxWebStd.gx_hidden_field( context, "TABS_Activepagecontrolname", StringUtil.RTrim( Tabs_Activepagecontrolname));
      }

      public override void RenderHtmlCloseForm( )
      {
         SendCloseFormHiddens( ) ;
         GxWebStd.gx_hidden_field( context, "GX_FocusControl", GX_FocusControl);
         SendAjaxEncryptionKey();
         SendSecurityToken((String)(sPrefix));
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
         if ( ! ( WebComp_Br_encounterwc == null ) )
         {
            WebComp_Br_encounterwc.componentjscripts();
         }
         if ( ! ( WebComp_Br_demographicswc == null ) )
         {
            WebComp_Br_demographicswc.componentjscripts();
         }
         if ( ! ( WebComp_Br_behaviorwc == null ) )
         {
            WebComp_Br_behaviorwc.componentjscripts();
         }
         if ( ! ( WebComp_Br_comorbiditywc == null ) )
         {
            WebComp_Br_comorbiditywc.componentjscripts();
         }
         if ( ! ( WebComp_Br_deathwc == null ) )
         {
            WebComp_Br_deathwc.componentjscripts();
         }
         if ( ! ( WebComp_Br_vitalwc == null ) )
         {
            WebComp_Br_vitalwc.componentjscripts();
         }
         if ( ! ( WebComp_Br_diagnosiswc == null ) )
         {
            WebComp_Br_diagnosiswc.componentjscripts();
         }
         if ( ! ( WebComp_Br_labwc == null ) )
         {
            WebComp_Br_labwc.componentjscripts();
         }
         if ( ! ( WebComp_Br_medicationwc == null ) )
         {
            WebComp_Br_medicationwc.componentjscripts();
         }
         if ( ! ( WebComp_Br_schemewc == null ) )
         {
            WebComp_Br_schemewc.componentjscripts();
         }
         if ( ! ( WebComp_Br_procedurewc == null ) )
         {
            WebComp_Br_procedurewc.componentjscripts();
         }
         if ( ! ( WebComp_Br_medicalimagingwc == null ) )
         {
            WebComp_Br_medicalimagingwc.componentjscripts();
         }
         if ( ! ( WebComp_Br_pathologywc == null ) )
         {
            WebComp_Br_pathologywc.componentjscripts();
         }
      }

      public override void RenderHtmlContent( )
      {
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0));
         if ( ( gxajaxcallmode == 0 ) && ( GxWebError == 0 ) )
         {
            context.WriteHtmlText( "<div") ;
            GxWebStd.ClassAttribute( context, "gx-ct-body"+" "+(String.IsNullOrEmpty(StringUtil.RTrim( Form.Class)) ? "form-horizontal Form" : Form.Class)+"-fx");
            context.WriteHtmlText( ">") ;
            WE1X2( ) ;
            context.WriteHtmlText( "</div>") ;
         }
      }

      public override void DispatchEvents( )
      {
         EVT1X2( ) ;
      }

      public override bool HasEnterEvent( )
      {
         return false ;
      }

      public override GXWebForm GetForm( )
      {
         return Form ;
      }

      public override String GetSelfLink( )
      {
         return formatLink("br_encounterupdate.aspx") + "?" + UrlEncode("" +AV10BR_EncounterID) + "," + UrlEncode(StringUtil.RTrim(AV8TabCode)) ;
      }

      public override String GetPgmname( )
      {
         return "BR_EncounterUpdate" ;
      }

      public override String GetPgmdesc( )
      {
         return "Data Mgmt Portal - RAAP" ;
      }

      protected void WB1X0( )
      {
         if ( context.isAjaxRequest( ) )
         {
            disableOutput();
         }
         if ( ! wbLoad )
         {
            if ( nGXWrapped == 1 )
            {
               RenderHtmlHeaders( ) ;
               RenderHtmlOpenForm( ) ;
            }
            GxWebStd.gx_msg_list( context, "", context.GX_msglist.DisplayMode, "", "", "", "false");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "Section", "left", "top", " "+"data-gx-base-lib=\"bootstrapv3\""+" "+"data-abstract-form"+" ", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divLayoutmaintable_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divTablemain_Internalname, 1, 0, "px", 0, "px", "TableMainViewWithShadow", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "Right", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-action-group ActionGroup", "left", "top", " "+"data-gx-actiongroup-type=\"toolbar\""+" ", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 11,'',false,'',0)\"";
            ClassString = "ButtonMaterial";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtncheck_Internalname, "", "初审通过", bttBtncheck_Jsonclick, 7, "初审通过", "", StyleString, ClassString, bttBtncheck_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"e111x1_client"+"'", TempTags, "", 2, "HLP_BR_EncounterUpdate.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 13,'',false,'',0)\"";
            ClassString = "ButtonMaterial";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtnrecheck_Internalname, "", "复审通过", bttBtnrecheck_Jsonclick, 7, "复审通过", "", StyleString, ClassString, bttBtnrecheck_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"e121x1_client"+"'", TempTags, "", 2, "HLP_BR_EncounterUpdate.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 15,'',false,'',0)\"";
            ClassString = "ButtonMaterial";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtnsubmit_Internalname, "", "提交审核", bttBtnsubmit_Jsonclick, 7, "提交审核", "", StyleString, ClassString, bttBtnsubmit_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"e131x1_client"+"'", TempTags, "", 2, "HLP_BR_EncounterUpdate.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 17,'',false,'',0)\"";
            ClassString = "ButtonMaterial";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtnreturn_Internalname, "", "返回", bttBtnreturn_Jsonclick, 5, "返回", "", StyleString, ClassString, 1, 1, "standard", "'"+""+"'"+",false,"+"'"+"E\\'DORETURN\\'."+"'", TempTags, "", context.GetButtonType( ), "HLP_BR_EncounterUpdate.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "Right", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 CellViewTabsPosition CellPaddingTop10", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divUnnamedtableviewcontainer_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 hidden-sm hidden-md hidden-lg CellTextBlockTitleWWP", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTxttabtitle_Internalname, lblTxttabtitle_Caption, "", "", lblTxttabtitle_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "TextBlockTitleWWPTab", 0, "", 1, 1, 0, "HLP_BR_EncounterUpdate.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 CellViewTab", "left", "top", "", "", "div");
            /* User Defined Control */
            ucTabs.SetProperty("PageCount", Tabs_Pagecount);
            ucTabs.SetProperty("Class", Tabs_Class);
            ucTabs.SetProperty("HistoryManagement", Tabs_Historymanagement);
            ucTabs.Render(context, "tab", Tabs_Internalname, "TABSContainer");
            context.WriteHtmlText( "<div class=\"gx_usercontrol_child\" id=\""+"TABSContainer"+"title1"+"\" style=\"display:none;\">") ;
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblBr_encounter_title_Internalname, "就诊信息", "", "", lblBr_encounter_title_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "TextBlock", 0, "", 1, 1, 0, "HLP_BR_EncounterUpdate.htm");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "Section", "left", "top", "", "display:none;", "div");
            context.WriteHtmlText( "BR_Encounter") ;
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "<div class=\"gx_usercontrol_child\" id=\""+"TABSContainer"+"panel1"+"\" style=\"display:none;\">") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, divUnnamedtablebr_encounter_Internalname, 1, 0, "px", 0, "px", "TableViewTab", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            if ( ! isFullAjaxMode( ) )
            {
               /* WebComponent */
               GxWebStd.gx_hidden_field( context, "W0034"+"", StringUtil.RTrim( WebComp_Br_encounterwc_Component));
               context.WriteHtmlText( "<div") ;
               GxWebStd.ClassAttribute( context, "gxwebcomponent");
               context.WriteHtmlText( " id=\""+"gxHTMLWrpW0034"+""+"\""+"") ;
               context.WriteHtmlText( ">") ;
               if ( StringUtil.Len( WebComp_Br_encounterwc_Component) != 0 )
               {
                  if ( StringUtil.StrCmp(StringUtil.Lower( OldBr_encounterwc), StringUtil.Lower( WebComp_Br_encounterwc_Component)) != 0 )
                  {
                     context.httpAjaxContext.ajax_rspStartCmp("gxHTMLWrpW0034"+"");
                  }
                  WebComp_Br_encounterwc.componentdraw();
                  if ( StringUtil.StrCmp(StringUtil.Lower( OldBr_encounterwc), StringUtil.Lower( WebComp_Br_encounterwc_Component)) != 0 )
                  {
                     context.httpAjaxContext.ajax_rspEndCmp();
                  }
               }
               context.WriteHtmlText( "</div>") ;
            }
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "<div class=\"gx_usercontrol_child\" id=\""+"TABSContainer"+"title2"+"\" style=\"display:none;\">") ;
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblBr_demographics_title_Internalname, "人口信息学", "", "", lblBr_demographics_title_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "TextBlock", 0, "", 1, 1, 0, "HLP_BR_EncounterUpdate.htm");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "Section", "left", "top", "", "display:none;", "div");
            context.WriteHtmlText( "BR_Demographics") ;
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "<div class=\"gx_usercontrol_child\" id=\""+"TABSContainer"+"panel2"+"\" style=\"display:none;\">") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, divUnnamedtablebr_demographics_Internalname, 1, 0, "px", 0, "px", "TableViewTab", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            if ( ! isFullAjaxMode( ) )
            {
               /* WebComponent */
               GxWebStd.gx_hidden_field( context, "W0042"+"", StringUtil.RTrim( WebComp_Br_demographicswc_Component));
               context.WriteHtmlText( "<div") ;
               GxWebStd.ClassAttribute( context, "gxwebcomponent");
               context.WriteHtmlText( " id=\""+"gxHTMLWrpW0042"+""+"\""+"") ;
               context.WriteHtmlText( ">") ;
               if ( StringUtil.Len( WebComp_Br_demographicswc_Component) != 0 )
               {
                  if ( StringUtil.StrCmp(StringUtil.Lower( OldBr_demographicswc), StringUtil.Lower( WebComp_Br_demographicswc_Component)) != 0 )
                  {
                     context.httpAjaxContext.ajax_rspStartCmp("gxHTMLWrpW0042"+"");
                  }
                  WebComp_Br_demographicswc.componentdraw();
                  if ( StringUtil.StrCmp(StringUtil.Lower( OldBr_demographicswc), StringUtil.Lower( WebComp_Br_demographicswc_Component)) != 0 )
                  {
                     context.httpAjaxContext.ajax_rspEndCmp();
                  }
               }
               context.WriteHtmlText( "</div>") ;
            }
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "<div class=\"gx_usercontrol_child\" id=\""+"TABSContainer"+"title3"+"\" style=\"display:none;\">") ;
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblBr_behavior_title_Internalname, "个人史", "", "", lblBr_behavior_title_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "TextBlock", 0, "", 1, 1, 0, "HLP_BR_EncounterUpdate.htm");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "Section", "left", "top", "", "display:none;", "div");
            context.WriteHtmlText( "BR_Behavior") ;
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "<div class=\"gx_usercontrol_child\" id=\""+"TABSContainer"+"panel3"+"\" style=\"display:none;\">") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, divUnnamedtablebr_behavior_Internalname, 1, 0, "px", 0, "px", "TableViewTab", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            if ( ! isFullAjaxMode( ) )
            {
               /* WebComponent */
               GxWebStd.gx_hidden_field( context, "W0050"+"", StringUtil.RTrim( WebComp_Br_behaviorwc_Component));
               context.WriteHtmlText( "<div") ;
               GxWebStd.ClassAttribute( context, "gxwebcomponent");
               context.WriteHtmlText( " id=\""+"gxHTMLWrpW0050"+""+"\""+"") ;
               context.WriteHtmlText( ">") ;
               if ( StringUtil.Len( WebComp_Br_behaviorwc_Component) != 0 )
               {
                  if ( StringUtil.StrCmp(StringUtil.Lower( OldBr_behaviorwc), StringUtil.Lower( WebComp_Br_behaviorwc_Component)) != 0 )
                  {
                     context.httpAjaxContext.ajax_rspStartCmp("gxHTMLWrpW0050"+"");
                  }
                  WebComp_Br_behaviorwc.componentdraw();
                  if ( StringUtil.StrCmp(StringUtil.Lower( OldBr_behaviorwc), StringUtil.Lower( WebComp_Br_behaviorwc_Component)) != 0 )
                  {
                     context.httpAjaxContext.ajax_rspEndCmp();
                  }
               }
               context.WriteHtmlText( "</div>") ;
            }
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "<div class=\"gx_usercontrol_child\" id=\""+"TABSContainer"+"title4"+"\" style=\"display:none;\">") ;
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblBr_comorbidity_title_Internalname, "既往病史", "", "", lblBr_comorbidity_title_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "TextBlock", 0, "", 1, 1, 0, "HLP_BR_EncounterUpdate.htm");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "Section", "left", "top", "", "display:none;", "div");
            context.WriteHtmlText( "BR_Comorbidity") ;
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "<div class=\"gx_usercontrol_child\" id=\""+"TABSContainer"+"panel4"+"\" style=\"display:none;\">") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, divUnnamedtablebr_comorbidity_Internalname, 1, 0, "px", 0, "px", "TableViewTab", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            if ( ! isFullAjaxMode( ) )
            {
               /* WebComponent */
               GxWebStd.gx_hidden_field( context, "W0058"+"", StringUtil.RTrim( WebComp_Br_comorbiditywc_Component));
               context.WriteHtmlText( "<div") ;
               GxWebStd.ClassAttribute( context, "gxwebcomponent");
               context.WriteHtmlText( " id=\""+"gxHTMLWrpW0058"+""+"\""+"") ;
               context.WriteHtmlText( ">") ;
               if ( StringUtil.Len( WebComp_Br_comorbiditywc_Component) != 0 )
               {
                  if ( StringUtil.StrCmp(StringUtil.Lower( OldBr_comorbiditywc), StringUtil.Lower( WebComp_Br_comorbiditywc_Component)) != 0 )
                  {
                     context.httpAjaxContext.ajax_rspStartCmp("gxHTMLWrpW0058"+"");
                  }
                  WebComp_Br_comorbiditywc.componentdraw();
                  if ( StringUtil.StrCmp(StringUtil.Lower( OldBr_comorbiditywc), StringUtil.Lower( WebComp_Br_comorbiditywc_Component)) != 0 )
                  {
                     context.httpAjaxContext.ajax_rspEndCmp();
                  }
               }
               context.WriteHtmlText( "</div>") ;
            }
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "<div class=\"gx_usercontrol_child\" id=\""+"TABSContainer"+"title5"+"\" style=\"display:none;\">") ;
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblBr_death_title_Internalname, "死亡情况", "", "", lblBr_death_title_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "TextBlock", 0, "", 1, 1, 0, "HLP_BR_EncounterUpdate.htm");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "Section", "left", "top", "", "display:none;", "div");
            context.WriteHtmlText( "BR_Death") ;
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "<div class=\"gx_usercontrol_child\" id=\""+"TABSContainer"+"panel5"+"\" style=\"display:none;\">") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, divUnnamedtablebr_death_Internalname, 1, 0, "px", 0, "px", "TableViewTab", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            if ( ! isFullAjaxMode( ) )
            {
               /* WebComponent */
               GxWebStd.gx_hidden_field( context, "W0066"+"", StringUtil.RTrim( WebComp_Br_deathwc_Component));
               context.WriteHtmlText( "<div") ;
               GxWebStd.ClassAttribute( context, "gxwebcomponent");
               context.WriteHtmlText( " id=\""+"gxHTMLWrpW0066"+""+"\""+"") ;
               context.WriteHtmlText( ">") ;
               if ( StringUtil.Len( WebComp_Br_deathwc_Component) != 0 )
               {
                  if ( StringUtil.StrCmp(StringUtil.Lower( OldBr_deathwc), StringUtil.Lower( WebComp_Br_deathwc_Component)) != 0 )
                  {
                     context.httpAjaxContext.ajax_rspStartCmp("gxHTMLWrpW0066"+"");
                  }
                  WebComp_Br_deathwc.componentdraw();
                  if ( StringUtil.StrCmp(StringUtil.Lower( OldBr_deathwc), StringUtil.Lower( WebComp_Br_deathwc_Component)) != 0 )
                  {
                     context.httpAjaxContext.ajax_rspEndCmp();
                  }
               }
               context.WriteHtmlText( "</div>") ;
            }
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "<div class=\"gx_usercontrol_child\" id=\""+"TABSContainer"+"title6"+"\" style=\"display:none;\">") ;
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblBr_vital_title_Internalname, "生命体征", "", "", lblBr_vital_title_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "TextBlock", 0, "", 1, 1, 0, "HLP_BR_EncounterUpdate.htm");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "Section", "left", "top", "", "display:none;", "div");
            context.WriteHtmlText( "BR_Vital") ;
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "<div class=\"gx_usercontrol_child\" id=\""+"TABSContainer"+"panel6"+"\" style=\"display:none;\">") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, divUnnamedtablebr_vital_Internalname, 1, 0, "px", 0, "px", "TableViewTab", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            if ( ! isFullAjaxMode( ) )
            {
               /* WebComponent */
               GxWebStd.gx_hidden_field( context, "W0074"+"", StringUtil.RTrim( WebComp_Br_vitalwc_Component));
               context.WriteHtmlText( "<div") ;
               GxWebStd.ClassAttribute( context, "gxwebcomponent");
               context.WriteHtmlText( " id=\""+"gxHTMLWrpW0074"+""+"\""+"") ;
               context.WriteHtmlText( ">") ;
               if ( StringUtil.Len( WebComp_Br_vitalwc_Component) != 0 )
               {
                  if ( StringUtil.StrCmp(StringUtil.Lower( OldBr_vitalwc), StringUtil.Lower( WebComp_Br_vitalwc_Component)) != 0 )
                  {
                     context.httpAjaxContext.ajax_rspStartCmp("gxHTMLWrpW0074"+"");
                  }
                  WebComp_Br_vitalwc.componentdraw();
                  if ( StringUtil.StrCmp(StringUtil.Lower( OldBr_vitalwc), StringUtil.Lower( WebComp_Br_vitalwc_Component)) != 0 )
                  {
                     context.httpAjaxContext.ajax_rspEndCmp();
                  }
               }
               context.WriteHtmlText( "</div>") ;
            }
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "<div class=\"gx_usercontrol_child\" id=\""+"TABSContainer"+"title7"+"\" style=\"display:none;\">") ;
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblBr_diagnosis_title_Internalname, "诊断", "", "", lblBr_diagnosis_title_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "TextBlock", 0, "", 1, 1, 0, "HLP_BR_EncounterUpdate.htm");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "Section", "left", "top", "", "display:none;", "div");
            context.WriteHtmlText( "BR_Diagnosis") ;
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "<div class=\"gx_usercontrol_child\" id=\""+"TABSContainer"+"panel7"+"\" style=\"display:none;\">") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, divUnnamedtablebr_diagnosis_Internalname, 1, 0, "px", 0, "px", "TableViewTab", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            if ( ! isFullAjaxMode( ) )
            {
               /* WebComponent */
               GxWebStd.gx_hidden_field( context, "W0082"+"", StringUtil.RTrim( WebComp_Br_diagnosiswc_Component));
               context.WriteHtmlText( "<div") ;
               GxWebStd.ClassAttribute( context, "gxwebcomponent");
               context.WriteHtmlText( " id=\""+"gxHTMLWrpW0082"+""+"\""+"") ;
               context.WriteHtmlText( ">") ;
               if ( StringUtil.Len( WebComp_Br_diagnosiswc_Component) != 0 )
               {
                  if ( StringUtil.StrCmp(StringUtil.Lower( OldBr_diagnosiswc), StringUtil.Lower( WebComp_Br_diagnosiswc_Component)) != 0 )
                  {
                     context.httpAjaxContext.ajax_rspStartCmp("gxHTMLWrpW0082"+"");
                  }
                  WebComp_Br_diagnosiswc.componentdraw();
                  if ( StringUtil.StrCmp(StringUtil.Lower( OldBr_diagnosiswc), StringUtil.Lower( WebComp_Br_diagnosiswc_Component)) != 0 )
                  {
                     context.httpAjaxContext.ajax_rspEndCmp();
                  }
               }
               context.WriteHtmlText( "</div>") ;
            }
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "<div class=\"gx_usercontrol_child\" id=\""+"TABSContainer"+"title8"+"\" style=\"display:none;\">") ;
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblBr_lab_title_Internalname, "实验室检查", "", "", lblBr_lab_title_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "TextBlock", 0, "", 1, 1, 0, "HLP_BR_EncounterUpdate.htm");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "Section", "left", "top", "", "display:none;", "div");
            context.WriteHtmlText( "BR_Lab") ;
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "<div class=\"gx_usercontrol_child\" id=\""+"TABSContainer"+"panel8"+"\" style=\"display:none;\">") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, divUnnamedtablebr_lab_Internalname, 1, 0, "px", 0, "px", "TableViewTab", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            if ( ! isFullAjaxMode( ) )
            {
               /* WebComponent */
               GxWebStd.gx_hidden_field( context, "W0090"+"", StringUtil.RTrim( WebComp_Br_labwc_Component));
               context.WriteHtmlText( "<div") ;
               GxWebStd.ClassAttribute( context, "gxwebcomponent");
               context.WriteHtmlText( " id=\""+"gxHTMLWrpW0090"+""+"\""+"") ;
               context.WriteHtmlText( ">") ;
               if ( StringUtil.Len( WebComp_Br_labwc_Component) != 0 )
               {
                  if ( StringUtil.StrCmp(StringUtil.Lower( OldBr_labwc), StringUtil.Lower( WebComp_Br_labwc_Component)) != 0 )
                  {
                     context.httpAjaxContext.ajax_rspStartCmp("gxHTMLWrpW0090"+"");
                  }
                  WebComp_Br_labwc.componentdraw();
                  if ( StringUtil.StrCmp(StringUtil.Lower( OldBr_labwc), StringUtil.Lower( WebComp_Br_labwc_Component)) != 0 )
                  {
                     context.httpAjaxContext.ajax_rspEndCmp();
                  }
               }
               context.WriteHtmlText( "</div>") ;
            }
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "<div class=\"gx_usercontrol_child\" id=\""+"TABSContainer"+"title9"+"\" style=\"display:none;\">") ;
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblBr_medication_title_Internalname, "药物治疗", "", "", lblBr_medication_title_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "TextBlock", 0, "", 1, 1, 0, "HLP_BR_EncounterUpdate.htm");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "Section", "left", "top", "", "display:none;", "div");
            context.WriteHtmlText( "BR_Medication") ;
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "<div class=\"gx_usercontrol_child\" id=\""+"TABSContainer"+"panel9"+"\" style=\"display:none;\">") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, divUnnamedtablebr_medication_Internalname, 1, 0, "px", 0, "px", "TableViewTab", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            if ( ! isFullAjaxMode( ) )
            {
               /* WebComponent */
               GxWebStd.gx_hidden_field( context, "W0098"+"", StringUtil.RTrim( WebComp_Br_medicationwc_Component));
               context.WriteHtmlText( "<div") ;
               GxWebStd.ClassAttribute( context, "gxwebcomponent");
               context.WriteHtmlText( " id=\""+"gxHTMLWrpW0098"+""+"\""+"") ;
               context.WriteHtmlText( ">") ;
               if ( StringUtil.Len( WebComp_Br_medicationwc_Component) != 0 )
               {
                  if ( StringUtil.StrCmp(StringUtil.Lower( OldBr_medicationwc), StringUtil.Lower( WebComp_Br_medicationwc_Component)) != 0 )
                  {
                     context.httpAjaxContext.ajax_rspStartCmp("gxHTMLWrpW0098"+"");
                  }
                  WebComp_Br_medicationwc.componentdraw();
                  if ( StringUtil.StrCmp(StringUtil.Lower( OldBr_medicationwc), StringUtil.Lower( WebComp_Br_medicationwc_Component)) != 0 )
                  {
                     context.httpAjaxContext.ajax_rspEndCmp();
                  }
               }
               context.WriteHtmlText( "</div>") ;
            }
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "<div class=\"gx_usercontrol_child\" id=\""+"TABSContainer"+"title10"+"\" style=\"display:none;\">") ;
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblBr_scheme_title_Internalname, "化疗方案", "", "", lblBr_scheme_title_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "TextBlock", 0, "", 1, 1, 0, "HLP_BR_EncounterUpdate.htm");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "Section", "left", "top", "", "display:none;", "div");
            context.WriteHtmlText( "BR_Scheme") ;
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "<div class=\"gx_usercontrol_child\" id=\""+"TABSContainer"+"panel10"+"\" style=\"display:none;\">") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, divUnnamedtablebr_scheme_Internalname, 1, 0, "px", 0, "px", "TableViewTab", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            if ( ! isFullAjaxMode( ) )
            {
               /* WebComponent */
               GxWebStd.gx_hidden_field( context, "W0106"+"", StringUtil.RTrim( WebComp_Br_schemewc_Component));
               context.WriteHtmlText( "<div") ;
               GxWebStd.ClassAttribute( context, "gxwebcomponent");
               context.WriteHtmlText( " id=\""+"gxHTMLWrpW0106"+""+"\""+"") ;
               context.WriteHtmlText( ">") ;
               if ( StringUtil.Len( WebComp_Br_schemewc_Component) != 0 )
               {
                  if ( StringUtil.StrCmp(StringUtil.Lower( OldBr_schemewc), StringUtil.Lower( WebComp_Br_schemewc_Component)) != 0 )
                  {
                     context.httpAjaxContext.ajax_rspStartCmp("gxHTMLWrpW0106"+"");
                  }
                  WebComp_Br_schemewc.componentdraw();
                  if ( StringUtil.StrCmp(StringUtil.Lower( OldBr_schemewc), StringUtil.Lower( WebComp_Br_schemewc_Component)) != 0 )
                  {
                     context.httpAjaxContext.ajax_rspEndCmp();
                  }
               }
               context.WriteHtmlText( "</div>") ;
            }
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "<div class=\"gx_usercontrol_child\" id=\""+"TABSContainer"+"title11"+"\" style=\"display:none;\">") ;
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblBr_procedure_title_Internalname, "诊疗处理", "", "", lblBr_procedure_title_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "TextBlock", 0, "", 1, 1, 0, "HLP_BR_EncounterUpdate.htm");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "Section", "left", "top", "", "display:none;", "div");
            context.WriteHtmlText( "BR_Procedure") ;
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "<div class=\"gx_usercontrol_child\" id=\""+"TABSContainer"+"panel11"+"\" style=\"display:none;\">") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, divUnnamedtablebr_procedure_Internalname, 1, 0, "px", 0, "px", "TableViewTab", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            if ( ! isFullAjaxMode( ) )
            {
               /* WebComponent */
               GxWebStd.gx_hidden_field( context, "W0114"+"", StringUtil.RTrim( WebComp_Br_procedurewc_Component));
               context.WriteHtmlText( "<div") ;
               GxWebStd.ClassAttribute( context, "gxwebcomponent");
               context.WriteHtmlText( " id=\""+"gxHTMLWrpW0114"+""+"\""+"") ;
               context.WriteHtmlText( ">") ;
               if ( StringUtil.Len( WebComp_Br_procedurewc_Component) != 0 )
               {
                  if ( StringUtil.StrCmp(StringUtil.Lower( OldBr_procedurewc), StringUtil.Lower( WebComp_Br_procedurewc_Component)) != 0 )
                  {
                     context.httpAjaxContext.ajax_rspStartCmp("gxHTMLWrpW0114"+"");
                  }
                  WebComp_Br_procedurewc.componentdraw();
                  if ( StringUtil.StrCmp(StringUtil.Lower( OldBr_procedurewc), StringUtil.Lower( WebComp_Br_procedurewc_Component)) != 0 )
                  {
                     context.httpAjaxContext.ajax_rspEndCmp();
                  }
               }
               context.WriteHtmlText( "</div>") ;
            }
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "<div class=\"gx_usercontrol_child\" id=\""+"TABSContainer"+"title12"+"\" style=\"display:none;\">") ;
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblBr_medicalimaging_title_Internalname, "影像学", "", "", lblBr_medicalimaging_title_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "TextBlock", 0, "", 1, 1, 0, "HLP_BR_EncounterUpdate.htm");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "Section", "left", "top", "", "display:none;", "div");
            context.WriteHtmlText( "BR_MedicalImaging") ;
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "<div class=\"gx_usercontrol_child\" id=\""+"TABSContainer"+"panel12"+"\" style=\"display:none;\">") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, divUnnamedtablebr_medicalimaging_Internalname, 1, 0, "px", 0, "px", "TableViewTab", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            if ( ! isFullAjaxMode( ) )
            {
               /* WebComponent */
               GxWebStd.gx_hidden_field( context, "W0122"+"", StringUtil.RTrim( WebComp_Br_medicalimagingwc_Component));
               context.WriteHtmlText( "<div") ;
               GxWebStd.ClassAttribute( context, "gxwebcomponent");
               context.WriteHtmlText( " id=\""+"gxHTMLWrpW0122"+""+"\""+"") ;
               context.WriteHtmlText( ">") ;
               if ( StringUtil.Len( WebComp_Br_medicalimagingwc_Component) != 0 )
               {
                  if ( StringUtil.StrCmp(StringUtil.Lower( OldBr_medicalimagingwc), StringUtil.Lower( WebComp_Br_medicalimagingwc_Component)) != 0 )
                  {
                     context.httpAjaxContext.ajax_rspStartCmp("gxHTMLWrpW0122"+"");
                  }
                  WebComp_Br_medicalimagingwc.componentdraw();
                  if ( StringUtil.StrCmp(StringUtil.Lower( OldBr_medicalimagingwc), StringUtil.Lower( WebComp_Br_medicalimagingwc_Component)) != 0 )
                  {
                     context.httpAjaxContext.ajax_rspEndCmp();
                  }
               }
               context.WriteHtmlText( "</div>") ;
            }
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "<div class=\"gx_usercontrol_child\" id=\""+"TABSContainer"+"title13"+"\" style=\"display:none;\">") ;
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblBr_pathology_title_Internalname, "病理学", "", "", lblBr_pathology_title_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "TextBlock", 0, "", 1, 1, 0, "HLP_BR_EncounterUpdate.htm");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "Section", "left", "top", "", "display:none;", "div");
            context.WriteHtmlText( "BR_Pathology") ;
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "<div class=\"gx_usercontrol_child\" id=\""+"TABSContainer"+"panel13"+"\" style=\"display:none;\">") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, divUnnamedtablebr_pathology_Internalname, 1, 0, "px", 0, "px", "TableViewTab", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            if ( ! isFullAjaxMode( ) )
            {
               /* WebComponent */
               GxWebStd.gx_hidden_field( context, "W0130"+"", StringUtil.RTrim( WebComp_Br_pathologywc_Component));
               context.WriteHtmlText( "<div") ;
               GxWebStd.ClassAttribute( context, "gxwebcomponent");
               context.WriteHtmlText( " id=\""+"gxHTMLWrpW0130"+""+"\""+"") ;
               context.WriteHtmlText( ">") ;
               if ( StringUtil.Len( WebComp_Br_pathologywc_Component) != 0 )
               {
                  if ( StringUtil.StrCmp(StringUtil.Lower( OldBr_pathologywc), StringUtil.Lower( WebComp_Br_pathologywc_Component)) != 0 )
                  {
                     context.httpAjaxContext.ajax_rspStartCmp("gxHTMLWrpW0130"+"");
                  }
                  WebComp_Br_pathologywc.componentdraw();
                  if ( StringUtil.StrCmp(StringUtil.Lower( OldBr_pathologywc), StringUtil.Lower( WebComp_Br_pathologywc_Component)) != 0 )
                  {
                     context.httpAjaxContext.ajax_rspEndCmp();
                  }
               }
               context.WriteHtmlText( "</div>") ;
            }
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</div>") ;
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 hidden-sm hidden-md hidden-lg CellPaddingBottom", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divUnnamedtabletabscontainer_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divCell_br_encounter_Internalname, divCell_br_encounter_Visible, 0, "px", 0, "px", "col-xs-12 CellMarginTop", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 136,'',false,'',0)\"";
            ClassString = "btn_Master btn-large btn-block Button";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtnbr_encounter_Internalname, "", "就诊信息", bttBtnbr_encounter_Jsonclick, 5, "就诊信息", "", StyleString, ClassString, 1, 1, "standard", "'"+""+"'"+",false,"+"'"+"E\\'BR_ENCOUNTER\\'."+"'", TempTags, "", context.GetButtonType( ), "HLP_BR_EncounterUpdate.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divCell_br_demographics_Internalname, divCell_br_demographics_Visible, 0, "px", 0, "px", "col-xs-12 CellMarginTop", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 139,'',false,'',0)\"";
            ClassString = "btn_Master btn-large btn-block Button";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtnbr_demographics_Internalname, "", "人口信息学", bttBtnbr_demographics_Jsonclick, 5, "人口信息学", "", StyleString, ClassString, 1, 1, "standard", "'"+""+"'"+",false,"+"'"+"E\\'BR_DEMOGRAPHICS\\'."+"'", TempTags, "", context.GetButtonType( ), "HLP_BR_EncounterUpdate.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divCell_br_behavior_Internalname, divCell_br_behavior_Visible, 0, "px", 0, "px", "col-xs-12 CellMarginTop", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 142,'',false,'',0)\"";
            ClassString = "btn_Master btn-large btn-block Button";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtnbr_behavior_Internalname, "", "个人史", bttBtnbr_behavior_Jsonclick, 5, "个人史", "", StyleString, ClassString, 1, 1, "standard", "'"+""+"'"+",false,"+"'"+"E\\'BR_BEHAVIOR\\'."+"'", TempTags, "", context.GetButtonType( ), "HLP_BR_EncounterUpdate.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divCell_br_comorbidity_Internalname, divCell_br_comorbidity_Visible, 0, "px", 0, "px", "col-xs-12 CellMarginTop", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 145,'',false,'',0)\"";
            ClassString = "btn_Master btn-large btn-block Button";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtnbr_comorbidity_Internalname, "", "既往病史", bttBtnbr_comorbidity_Jsonclick, 5, "既往病史", "", StyleString, ClassString, 1, 1, "standard", "'"+""+"'"+",false,"+"'"+"E\\'BR_COMORBIDITY\\'."+"'", TempTags, "", context.GetButtonType( ), "HLP_BR_EncounterUpdate.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divCell_br_death_Internalname, divCell_br_death_Visible, 0, "px", 0, "px", "col-xs-12 CellMarginTop", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 148,'',false,'',0)\"";
            ClassString = "btn_Master btn-large btn-block Button";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtnbr_death_Internalname, "", "死亡情况", bttBtnbr_death_Jsonclick, 5, "死亡情况", "", StyleString, ClassString, 1, 1, "standard", "'"+""+"'"+",false,"+"'"+"E\\'BR_DEATH\\'."+"'", TempTags, "", context.GetButtonType( ), "HLP_BR_EncounterUpdate.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divCell_br_vital_Internalname, divCell_br_vital_Visible, 0, "px", 0, "px", "col-xs-12 CellMarginTop", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 151,'',false,'',0)\"";
            ClassString = "btn_Master btn-large btn-block Button";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtnbr_vital_Internalname, "", "生命体征", bttBtnbr_vital_Jsonclick, 5, "生命体征", "", StyleString, ClassString, 1, 1, "standard", "'"+""+"'"+",false,"+"'"+"E\\'BR_VITAL\\'."+"'", TempTags, "", context.GetButtonType( ), "HLP_BR_EncounterUpdate.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divCell_br_diagnosis_Internalname, divCell_br_diagnosis_Visible, 0, "px", 0, "px", "col-xs-12 CellMarginTop", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 154,'',false,'',0)\"";
            ClassString = "btn_Master btn-large btn-block Button";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtnbr_diagnosis_Internalname, "", "诊断", bttBtnbr_diagnosis_Jsonclick, 5, "诊断", "", StyleString, ClassString, 1, 1, "standard", "'"+""+"'"+",false,"+"'"+"E\\'BR_DIAGNOSIS\\'."+"'", TempTags, "", context.GetButtonType( ), "HLP_BR_EncounterUpdate.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divCell_br_lab_Internalname, divCell_br_lab_Visible, 0, "px", 0, "px", "col-xs-12 CellMarginTop", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 157,'',false,'',0)\"";
            ClassString = "btn_Master btn-large btn-block Button";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtnbr_lab_Internalname, "", "实验室检查", bttBtnbr_lab_Jsonclick, 5, "实验室检查", "", StyleString, ClassString, 1, 1, "standard", "'"+""+"'"+",false,"+"'"+"E\\'BR_LAB\\'."+"'", TempTags, "", context.GetButtonType( ), "HLP_BR_EncounterUpdate.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divCell_br_medication_Internalname, divCell_br_medication_Visible, 0, "px", 0, "px", "col-xs-12 CellMarginTop", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 160,'',false,'',0)\"";
            ClassString = "btn_Master btn-large btn-block Button";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtnbr_medication_Internalname, "", "药物治疗", bttBtnbr_medication_Jsonclick, 5, "药物治疗", "", StyleString, ClassString, 1, 1, "standard", "'"+""+"'"+",false,"+"'"+"E\\'BR_MEDICATION\\'."+"'", TempTags, "", context.GetButtonType( ), "HLP_BR_EncounterUpdate.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divCell_br_scheme_Internalname, divCell_br_scheme_Visible, 0, "px", 0, "px", "col-xs-12 CellMarginTop", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 163,'',false,'',0)\"";
            ClassString = "btn_Master btn-large btn-block Button";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtnbr_scheme_Internalname, "", "化疗方案", bttBtnbr_scheme_Jsonclick, 5, "化疗方案", "", StyleString, ClassString, 1, 1, "standard", "'"+""+"'"+",false,"+"'"+"E\\'BR_SCHEME\\'."+"'", TempTags, "", context.GetButtonType( ), "HLP_BR_EncounterUpdate.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divCell_br_procedure_Internalname, divCell_br_procedure_Visible, 0, "px", 0, "px", "col-xs-12 CellMarginTop", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 166,'',false,'',0)\"";
            ClassString = "btn_Master btn-large btn-block Button";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtnbr_procedure_Internalname, "", "诊疗处理", bttBtnbr_procedure_Jsonclick, 5, "诊疗处理", "", StyleString, ClassString, 1, 1, "standard", "'"+""+"'"+",false,"+"'"+"E\\'BR_PROCEDURE\\'."+"'", TempTags, "", context.GetButtonType( ), "HLP_BR_EncounterUpdate.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divCell_br_medicalimaging_Internalname, divCell_br_medicalimaging_Visible, 0, "px", 0, "px", "col-xs-12 CellMarginTop", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 169,'',false,'',0)\"";
            ClassString = "btn_Master btn-large btn-block Button";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtnbr_medicalimaging_Internalname, "", "影像学", bttBtnbr_medicalimaging_Jsonclick, 5, "影像学", "", StyleString, ClassString, 1, 1, "standard", "'"+""+"'"+",false,"+"'"+"E\\'BR_MEDICALIMAGING\\'."+"'", TempTags, "", context.GetButtonType( ), "HLP_BR_EncounterUpdate.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divCell_br_pathology_Internalname, divCell_br_pathology_Visible, 0, "px", 0, "px", "col-xs-12 CellMarginTop", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 172,'',false,'',0)\"";
            ClassString = "btn_Master btn-large btn-block Button";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtnbr_pathology_Internalname, "", "病理学", bttBtnbr_pathology_Jsonclick, 5, "病理学", "", StyleString, ClassString, 1, 1, "standard", "'"+""+"'"+",false,"+"'"+"E\\'BR_PATHOLOGY\\'."+"'", TempTags, "", context.GetButtonType( ), "HLP_BR_EncounterUpdate.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
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
            wb_table1_176_1X2( true) ;
         }
         else
         {
            wb_table1_176_1X2( false) ;
         }
         return  ;
      }

      protected void wb_table1_176_1X2e( bool wbgen )
      {
         if ( wbgen )
         {
            wb_table2_181_1X2( true) ;
         }
         else
         {
            wb_table2_181_1X2( false) ;
         }
         return  ;
      }

      protected void wb_table2_181_1X2e( bool wbgen )
      {
         if ( wbgen )
         {
            wb_table3_186_1X2( true) ;
         }
         else
         {
            wb_table3_186_1X2( false) ;
         }
         return  ;
      }

      protected void wb_table3_186_1X2e( bool wbgen )
      {
         if ( wbgen )
         {
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
         }
         wbLoad = true;
      }

      protected void START1X2( )
      {
         wbLoad = false;
         wbEnd = 0;
         wbStart = 0;
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
         wbErr = false;
         STRUP1X0( ) ;
      }

      protected void WS1X2( )
      {
         START1X2( ) ;
         EVT1X2( ) ;
      }

      protected void EVT1X2( )
      {
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) && ! wbErr )
            {
               /* Read Web Panel buttons. */
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
                           if ( StringUtil.StrCmp(sEvt, "RFR") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                           }
                           else if ( StringUtil.StrCmp(sEvt, "TABS.TABCHANGED") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E141X2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "DVELOP_CONFIRMPANEL_CHECK.CLOSE") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E151X2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "DVELOP_CONFIRMPANEL_RECHECK.CLOSE") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E161X2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "DVELOP_CONFIRMPANEL_SUBMIT.CLOSE") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E171X2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "START") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              /* Execute user event: Start */
                              E181X2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "REFRESH") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              /* Execute user event: Refresh */
                              E191X2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "LOAD") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              /* Execute user event: Load */
                              E201X2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "'DORETURN'") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              /* Execute user event: 'Doreturn' */
                              E211X2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "'BR_ENCOUNTER'") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              /* Execute user event: 'BR_Encounter' */
                              E221X2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "'BR_DEMOGRAPHICS'") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              /* Execute user event: 'BR_Demographics' */
                              E231X2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "'BR_BEHAVIOR'") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              /* Execute user event: 'BR_Behavior' */
                              E241X2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "'BR_COMORBIDITY'") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              /* Execute user event: 'BR_Comorbidity' */
                              E251X2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "'BR_DEATH'") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              /* Execute user event: 'BR_Death' */
                              E261X2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "'BR_VITAL'") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              /* Execute user event: 'BR_Vital' */
                              E271X2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "'BR_DIAGNOSIS'") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              /* Execute user event: 'BR_Diagnosis' */
                              E281X2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "'BR_LAB'") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              /* Execute user event: 'BR_Lab' */
                              E291X2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "'BR_MEDICATION'") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              /* Execute user event: 'BR_Medication' */
                              E301X2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "'BR_SCHEME'") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              /* Execute user event: 'BR_Scheme' */
                              E311X2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "'BR_PROCEDURE'") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              /* Execute user event: 'BR_Procedure' */
                              E321X2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "'BR_MEDICALIMAGING'") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              /* Execute user event: 'BR_MedicalImaging' */
                              E331X2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "'BR_PATHOLOGY'") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              /* Execute user event: 'BR_Pathology' */
                              E341X2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "ENTER") == 0 )
                           {
                              context.wbHandled = 1;
                              if ( ! wbErr )
                              {
                                 Rfr0gs = false;
                                 if ( ! Rfr0gs )
                                 {
                                 }
                                 dynload_actions( ) ;
                              }
                              /* No code required for Cancel button. It is implemented as the Reset button. */
                           }
                           else if ( StringUtil.StrCmp(sEvt, "LSCR") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              dynload_actions( ) ;
                           }
                        }
                        else
                        {
                        }
                     }
                     else if ( StringUtil.StrCmp(sEvtType, "W") == 0 )
                     {
                        sEvtType = StringUtil.Left( sEvt, 4);
                        sEvt = StringUtil.Right( sEvt, (short)(StringUtil.Len( sEvt)-4));
                        nCmpId = (short)(NumberUtil.Val( sEvtType, "."));
                        if ( nCmpId == 34 )
                        {
                           OldBr_encounterwc = cgiGet( "W0034");
                           if ( ( StringUtil.Len( OldBr_encounterwc) == 0 ) || ( StringUtil.StrCmp(OldBr_encounterwc, WebComp_Br_encounterwc_Component) != 0 ) )
                           {
                              WebComp_Br_encounterwc = getWebComponent(GetType(), "GeneXus.Programs", OldBr_encounterwc, new Object[] {context} );
                              WebComp_Br_encounterwc.ComponentInit();
                              WebComp_Br_encounterwc.Name = "OldBr_encounterwc";
                              WebComp_Br_encounterwc_Component = OldBr_encounterwc;
                           }
                           if ( StringUtil.Len( WebComp_Br_encounterwc_Component) != 0 )
                           {
                              WebComp_Br_encounterwc.componentprocess("W0034", "", sEvt);
                           }
                           WebComp_Br_encounterwc_Component = OldBr_encounterwc;
                        }
                        else if ( nCmpId == 42 )
                        {
                           OldBr_demographicswc = cgiGet( "W0042");
                           if ( ( StringUtil.Len( OldBr_demographicswc) == 0 ) || ( StringUtil.StrCmp(OldBr_demographicswc, WebComp_Br_demographicswc_Component) != 0 ) )
                           {
                              WebComp_Br_demographicswc = getWebComponent(GetType(), "GeneXus.Programs", OldBr_demographicswc, new Object[] {context} );
                              WebComp_Br_demographicswc.ComponentInit();
                              WebComp_Br_demographicswc.Name = "OldBr_demographicswc";
                              WebComp_Br_demographicswc_Component = OldBr_demographicswc;
                           }
                           if ( StringUtil.Len( WebComp_Br_demographicswc_Component) != 0 )
                           {
                              WebComp_Br_demographicswc.componentprocess("W0042", "", sEvt);
                           }
                           WebComp_Br_demographicswc_Component = OldBr_demographicswc;
                        }
                        else if ( nCmpId == 50 )
                        {
                           OldBr_behaviorwc = cgiGet( "W0050");
                           if ( ( StringUtil.Len( OldBr_behaviorwc) == 0 ) || ( StringUtil.StrCmp(OldBr_behaviorwc, WebComp_Br_behaviorwc_Component) != 0 ) )
                           {
                              WebComp_Br_behaviorwc = getWebComponent(GetType(), "GeneXus.Programs", OldBr_behaviorwc, new Object[] {context} );
                              WebComp_Br_behaviorwc.ComponentInit();
                              WebComp_Br_behaviorwc.Name = "OldBr_behaviorwc";
                              WebComp_Br_behaviorwc_Component = OldBr_behaviorwc;
                           }
                           if ( StringUtil.Len( WebComp_Br_behaviorwc_Component) != 0 )
                           {
                              WebComp_Br_behaviorwc.componentprocess("W0050", "", sEvt);
                           }
                           WebComp_Br_behaviorwc_Component = OldBr_behaviorwc;
                        }
                        else if ( nCmpId == 58 )
                        {
                           OldBr_comorbiditywc = cgiGet( "W0058");
                           if ( ( StringUtil.Len( OldBr_comorbiditywc) == 0 ) || ( StringUtil.StrCmp(OldBr_comorbiditywc, WebComp_Br_comorbiditywc_Component) != 0 ) )
                           {
                              WebComp_Br_comorbiditywc = getWebComponent(GetType(), "GeneXus.Programs", OldBr_comorbiditywc, new Object[] {context} );
                              WebComp_Br_comorbiditywc.ComponentInit();
                              WebComp_Br_comorbiditywc.Name = "OldBr_comorbiditywc";
                              WebComp_Br_comorbiditywc_Component = OldBr_comorbiditywc;
                           }
                           if ( StringUtil.Len( WebComp_Br_comorbiditywc_Component) != 0 )
                           {
                              WebComp_Br_comorbiditywc.componentprocess("W0058", "", sEvt);
                           }
                           WebComp_Br_comorbiditywc_Component = OldBr_comorbiditywc;
                        }
                        else if ( nCmpId == 66 )
                        {
                           OldBr_deathwc = cgiGet( "W0066");
                           if ( ( StringUtil.Len( OldBr_deathwc) == 0 ) || ( StringUtil.StrCmp(OldBr_deathwc, WebComp_Br_deathwc_Component) != 0 ) )
                           {
                              WebComp_Br_deathwc = getWebComponent(GetType(), "GeneXus.Programs", OldBr_deathwc, new Object[] {context} );
                              WebComp_Br_deathwc.ComponentInit();
                              WebComp_Br_deathwc.Name = "OldBr_deathwc";
                              WebComp_Br_deathwc_Component = OldBr_deathwc;
                           }
                           if ( StringUtil.Len( WebComp_Br_deathwc_Component) != 0 )
                           {
                              WebComp_Br_deathwc.componentprocess("W0066", "", sEvt);
                           }
                           WebComp_Br_deathwc_Component = OldBr_deathwc;
                        }
                        else if ( nCmpId == 74 )
                        {
                           OldBr_vitalwc = cgiGet( "W0074");
                           if ( ( StringUtil.Len( OldBr_vitalwc) == 0 ) || ( StringUtil.StrCmp(OldBr_vitalwc, WebComp_Br_vitalwc_Component) != 0 ) )
                           {
                              WebComp_Br_vitalwc = getWebComponent(GetType(), "GeneXus.Programs", OldBr_vitalwc, new Object[] {context} );
                              WebComp_Br_vitalwc.ComponentInit();
                              WebComp_Br_vitalwc.Name = "OldBr_vitalwc";
                              WebComp_Br_vitalwc_Component = OldBr_vitalwc;
                           }
                           if ( StringUtil.Len( WebComp_Br_vitalwc_Component) != 0 )
                           {
                              WebComp_Br_vitalwc.componentprocess("W0074", "", sEvt);
                           }
                           WebComp_Br_vitalwc_Component = OldBr_vitalwc;
                        }
                        else if ( nCmpId == 82 )
                        {
                           OldBr_diagnosiswc = cgiGet( "W0082");
                           if ( ( StringUtil.Len( OldBr_diagnosiswc) == 0 ) || ( StringUtil.StrCmp(OldBr_diagnosiswc, WebComp_Br_diagnosiswc_Component) != 0 ) )
                           {
                              WebComp_Br_diagnosiswc = getWebComponent(GetType(), "GeneXus.Programs", OldBr_diagnosiswc, new Object[] {context} );
                              WebComp_Br_diagnosiswc.ComponentInit();
                              WebComp_Br_diagnosiswc.Name = "OldBr_diagnosiswc";
                              WebComp_Br_diagnosiswc_Component = OldBr_diagnosiswc;
                           }
                           if ( StringUtil.Len( WebComp_Br_diagnosiswc_Component) != 0 )
                           {
                              WebComp_Br_diagnosiswc.componentprocess("W0082", "", sEvt);
                           }
                           WebComp_Br_diagnosiswc_Component = OldBr_diagnosiswc;
                        }
                        else if ( nCmpId == 90 )
                        {
                           OldBr_labwc = cgiGet( "W0090");
                           if ( ( StringUtil.Len( OldBr_labwc) == 0 ) || ( StringUtil.StrCmp(OldBr_labwc, WebComp_Br_labwc_Component) != 0 ) )
                           {
                              WebComp_Br_labwc = getWebComponent(GetType(), "GeneXus.Programs", OldBr_labwc, new Object[] {context} );
                              WebComp_Br_labwc.ComponentInit();
                              WebComp_Br_labwc.Name = "OldBr_labwc";
                              WebComp_Br_labwc_Component = OldBr_labwc;
                           }
                           if ( StringUtil.Len( WebComp_Br_labwc_Component) != 0 )
                           {
                              WebComp_Br_labwc.componentprocess("W0090", "", sEvt);
                           }
                           WebComp_Br_labwc_Component = OldBr_labwc;
                        }
                        else if ( nCmpId == 98 )
                        {
                           OldBr_medicationwc = cgiGet( "W0098");
                           if ( ( StringUtil.Len( OldBr_medicationwc) == 0 ) || ( StringUtil.StrCmp(OldBr_medicationwc, WebComp_Br_medicationwc_Component) != 0 ) )
                           {
                              WebComp_Br_medicationwc = getWebComponent(GetType(), "GeneXus.Programs", OldBr_medicationwc, new Object[] {context} );
                              WebComp_Br_medicationwc.ComponentInit();
                              WebComp_Br_medicationwc.Name = "OldBr_medicationwc";
                              WebComp_Br_medicationwc_Component = OldBr_medicationwc;
                           }
                           if ( StringUtil.Len( WebComp_Br_medicationwc_Component) != 0 )
                           {
                              WebComp_Br_medicationwc.componentprocess("W0098", "", sEvt);
                           }
                           WebComp_Br_medicationwc_Component = OldBr_medicationwc;
                        }
                        else if ( nCmpId == 106 )
                        {
                           OldBr_schemewc = cgiGet( "W0106");
                           if ( ( StringUtil.Len( OldBr_schemewc) == 0 ) || ( StringUtil.StrCmp(OldBr_schemewc, WebComp_Br_schemewc_Component) != 0 ) )
                           {
                              WebComp_Br_schemewc = getWebComponent(GetType(), "GeneXus.Programs", OldBr_schemewc, new Object[] {context} );
                              WebComp_Br_schemewc.ComponentInit();
                              WebComp_Br_schemewc.Name = "OldBr_schemewc";
                              WebComp_Br_schemewc_Component = OldBr_schemewc;
                           }
                           if ( StringUtil.Len( WebComp_Br_schemewc_Component) != 0 )
                           {
                              WebComp_Br_schemewc.componentprocess("W0106", "", sEvt);
                           }
                           WebComp_Br_schemewc_Component = OldBr_schemewc;
                        }
                        else if ( nCmpId == 114 )
                        {
                           OldBr_procedurewc = cgiGet( "W0114");
                           if ( ( StringUtil.Len( OldBr_procedurewc) == 0 ) || ( StringUtil.StrCmp(OldBr_procedurewc, WebComp_Br_procedurewc_Component) != 0 ) )
                           {
                              WebComp_Br_procedurewc = getWebComponent(GetType(), "GeneXus.Programs", OldBr_procedurewc, new Object[] {context} );
                              WebComp_Br_procedurewc.ComponentInit();
                              WebComp_Br_procedurewc.Name = "OldBr_procedurewc";
                              WebComp_Br_procedurewc_Component = OldBr_procedurewc;
                           }
                           if ( StringUtil.Len( WebComp_Br_procedurewc_Component) != 0 )
                           {
                              WebComp_Br_procedurewc.componentprocess("W0114", "", sEvt);
                           }
                           WebComp_Br_procedurewc_Component = OldBr_procedurewc;
                        }
                        else if ( nCmpId == 122 )
                        {
                           OldBr_medicalimagingwc = cgiGet( "W0122");
                           if ( ( StringUtil.Len( OldBr_medicalimagingwc) == 0 ) || ( StringUtil.StrCmp(OldBr_medicalimagingwc, WebComp_Br_medicalimagingwc_Component) != 0 ) )
                           {
                              WebComp_Br_medicalimagingwc = getWebComponent(GetType(), "GeneXus.Programs", OldBr_medicalimagingwc, new Object[] {context} );
                              WebComp_Br_medicalimagingwc.ComponentInit();
                              WebComp_Br_medicalimagingwc.Name = "OldBr_medicalimagingwc";
                              WebComp_Br_medicalimagingwc_Component = OldBr_medicalimagingwc;
                           }
                           if ( StringUtil.Len( WebComp_Br_medicalimagingwc_Component) != 0 )
                           {
                              WebComp_Br_medicalimagingwc.componentprocess("W0122", "", sEvt);
                           }
                           WebComp_Br_medicalimagingwc_Component = OldBr_medicalimagingwc;
                        }
                        else if ( nCmpId == 130 )
                        {
                           OldBr_pathologywc = cgiGet( "W0130");
                           if ( ( StringUtil.Len( OldBr_pathologywc) == 0 ) || ( StringUtil.StrCmp(OldBr_pathologywc, WebComp_Br_pathologywc_Component) != 0 ) )
                           {
                              WebComp_Br_pathologywc = getWebComponent(GetType(), "GeneXus.Programs", OldBr_pathologywc, new Object[] {context} );
                              WebComp_Br_pathologywc.ComponentInit();
                              WebComp_Br_pathologywc.Name = "OldBr_pathologywc";
                              WebComp_Br_pathologywc_Component = OldBr_pathologywc;
                           }
                           if ( StringUtil.Len( WebComp_Br_pathologywc_Component) != 0 )
                           {
                              WebComp_Br_pathologywc.componentprocess("W0130", "", sEvt);
                           }
                           WebComp_Br_pathologywc_Component = OldBr_pathologywc;
                        }
                     }
                     context.wbHandled = 1;
                  }
               }
            }
         }
      }

      protected void WE1X2( )
      {
         if ( ! GxWebStd.gx_redirect( context) )
         {
            Rfr0gs = true;
            Refresh( ) ;
            if ( ! GxWebStd.gx_redirect( context) )
            {
               if ( nGXWrapped == 1 )
               {
                  RenderHtmlCloseForm( ) ;
               }
            }
         }
      }

      protected void PA1X2( )
      {
         if ( nDonePA == 0 )
         {
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
            if ( ! context.isAjaxRequest( ) )
            {
            }
            nDonePA = 1;
         }
      }

      protected void dynload_actions( )
      {
         /* End function dynload_actions */
      }

      protected void send_integrity_hashes( )
      {
      }

      protected void clear_multi_value_controls( )
      {
         if ( context.isAjaxRequest( ) )
         {
            dynload_actions( ) ;
         }
      }

      protected void fix_multi_value_controls( )
      {
      }

      public void Refresh( )
      {
         send_integrity_hashes( ) ;
         RF1X2( ) ;
         if ( isFullAjaxMode( ) )
         {
            send_integrity_footer_hashes( ) ;
         }
      }

      protected void initialize_formulas( )
      {
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      protected void RF1X2( )
      {
         initialize_formulas( ) ;
         clear_multi_value_controls( ) ;
         /* Execute user event: Refresh */
         E191X2 ();
         if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
         {
            if ( 1 != 0 )
            {
               if ( StringUtil.Len( WebComp_Br_encounterwc_Component) != 0 )
               {
                  WebComp_Br_encounterwc.componentstart();
               }
            }
         }
         if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
         {
            if ( 1 != 0 )
            {
               if ( StringUtil.Len( WebComp_Br_demographicswc_Component) != 0 )
               {
                  WebComp_Br_demographicswc.componentstart();
               }
            }
         }
         if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
         {
            if ( 1 != 0 )
            {
               if ( StringUtil.Len( WebComp_Br_behaviorwc_Component) != 0 )
               {
                  WebComp_Br_behaviorwc.componentstart();
               }
            }
         }
         if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
         {
            if ( 1 != 0 )
            {
               if ( StringUtil.Len( WebComp_Br_comorbiditywc_Component) != 0 )
               {
                  WebComp_Br_comorbiditywc.componentstart();
               }
            }
         }
         if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
         {
            if ( 1 != 0 )
            {
               if ( StringUtil.Len( WebComp_Br_deathwc_Component) != 0 )
               {
                  WebComp_Br_deathwc.componentstart();
               }
            }
         }
         if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
         {
            if ( 1 != 0 )
            {
               if ( StringUtil.Len( WebComp_Br_vitalwc_Component) != 0 )
               {
                  WebComp_Br_vitalwc.componentstart();
               }
            }
         }
         if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
         {
            if ( 1 != 0 )
            {
               if ( StringUtil.Len( WebComp_Br_diagnosiswc_Component) != 0 )
               {
                  WebComp_Br_diagnosiswc.componentstart();
               }
            }
         }
         if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
         {
            if ( 1 != 0 )
            {
               if ( StringUtil.Len( WebComp_Br_labwc_Component) != 0 )
               {
                  WebComp_Br_labwc.componentstart();
               }
            }
         }
         if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
         {
            if ( 1 != 0 )
            {
               if ( StringUtil.Len( WebComp_Br_medicationwc_Component) != 0 )
               {
                  WebComp_Br_medicationwc.componentstart();
               }
            }
         }
         if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
         {
            if ( 1 != 0 )
            {
               if ( StringUtil.Len( WebComp_Br_schemewc_Component) != 0 )
               {
                  WebComp_Br_schemewc.componentstart();
               }
            }
         }
         if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
         {
            if ( 1 != 0 )
            {
               if ( StringUtil.Len( WebComp_Br_procedurewc_Component) != 0 )
               {
                  WebComp_Br_procedurewc.componentstart();
               }
            }
         }
         if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
         {
            if ( 1 != 0 )
            {
               if ( StringUtil.Len( WebComp_Br_medicalimagingwc_Component) != 0 )
               {
                  WebComp_Br_medicalimagingwc.componentstart();
               }
            }
         }
         if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
         {
            if ( 1 != 0 )
            {
               if ( StringUtil.Len( WebComp_Br_pathologywc_Component) != 0 )
               {
                  WebComp_Br_pathologywc.componentstart();
               }
            }
         }
         gxdyncontrolsrefreshing = true;
         fix_multi_value_controls( ) ;
         gxdyncontrolsrefreshing = false;
         if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
         {
            /* Execute user event: Load */
            E201X2 ();
            WB1X0( ) ;
         }
      }

      protected void send_integrity_lvl_hashes1X2( )
      {
         GxWebStd.gx_hidden_field( context, "vBR_ENCOUNTERID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV10BR_EncounterID), 18, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "gxhash_vBR_ENCOUNTERID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV10BR_EncounterID), "ZZZZZZZZZZZZZZZZZZ"), context));
         GxWebStd.gx_hidden_field( context, "vTPAGERETURN", AV18tPageReturn);
         GxWebStd.gx_hidden_field( context, "gxhash_vTPAGERETURN", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( AV18tPageReturn, "")), context));
      }

      protected void STRUP1X0( )
      {
         /* Before Start, stand alone formulas. */
         context.Gx_err = 0;
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0;
         /* Execute user event: Start */
         E181X2 ();
         context.wbGlbDoneStart = 1;
         /* After Start, stand alone formulas. */
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read saved SDTs. */
            /* Read variables values. */
            /* Read saved values. */
            Tabs_Class = cgiGet( "TABS_Class");
            Tabs_Activepagecontrolname = cgiGet( "TABS_Activepagecontrolname");
            Tabs_Pagecount = (int)(context.localUtil.CToN( cgiGet( "TABS_Pagecount"), ".", ","));
            Tabs_Historymanagement = StringUtil.StrToBool( cgiGet( "TABS_Historymanagement"));
            Dvelop_confirmpanel_check_Title = cgiGet( "DVELOP_CONFIRMPANEL_CHECK_Title");
            Dvelop_confirmpanel_check_Confirmationtext = cgiGet( "DVELOP_CONFIRMPANEL_CHECK_Confirmationtext");
            Dvelop_confirmpanel_check_Yesbuttoncaption = cgiGet( "DVELOP_CONFIRMPANEL_CHECK_Yesbuttoncaption");
            Dvelop_confirmpanel_check_Nobuttoncaption = cgiGet( "DVELOP_CONFIRMPANEL_CHECK_Nobuttoncaption");
            Dvelop_confirmpanel_check_Cancelbuttoncaption = cgiGet( "DVELOP_CONFIRMPANEL_CHECK_Cancelbuttoncaption");
            Dvelop_confirmpanel_check_Yesbuttonposition = cgiGet( "DVELOP_CONFIRMPANEL_CHECK_Yesbuttonposition");
            Dvelop_confirmpanel_check_Confirmtype = cgiGet( "DVELOP_CONFIRMPANEL_CHECK_Confirmtype");
            Dvelop_confirmpanel_recheck_Title = cgiGet( "DVELOP_CONFIRMPANEL_RECHECK_Title");
            Dvelop_confirmpanel_recheck_Confirmationtext = cgiGet( "DVELOP_CONFIRMPANEL_RECHECK_Confirmationtext");
            Dvelop_confirmpanel_recheck_Yesbuttoncaption = cgiGet( "DVELOP_CONFIRMPANEL_RECHECK_Yesbuttoncaption");
            Dvelop_confirmpanel_recheck_Nobuttoncaption = cgiGet( "DVELOP_CONFIRMPANEL_RECHECK_Nobuttoncaption");
            Dvelop_confirmpanel_recheck_Cancelbuttoncaption = cgiGet( "DVELOP_CONFIRMPANEL_RECHECK_Cancelbuttoncaption");
            Dvelop_confirmpanel_recheck_Yesbuttonposition = cgiGet( "DVELOP_CONFIRMPANEL_RECHECK_Yesbuttonposition");
            Dvelop_confirmpanel_recheck_Confirmtype = cgiGet( "DVELOP_CONFIRMPANEL_RECHECK_Confirmtype");
            Dvelop_confirmpanel_submit_Title = cgiGet( "DVELOP_CONFIRMPANEL_SUBMIT_Title");
            Dvelop_confirmpanel_submit_Confirmationtext = cgiGet( "DVELOP_CONFIRMPANEL_SUBMIT_Confirmationtext");
            Dvelop_confirmpanel_submit_Yesbuttoncaption = cgiGet( "DVELOP_CONFIRMPANEL_SUBMIT_Yesbuttoncaption");
            Dvelop_confirmpanel_submit_Nobuttoncaption = cgiGet( "DVELOP_CONFIRMPANEL_SUBMIT_Nobuttoncaption");
            Dvelop_confirmpanel_submit_Cancelbuttoncaption = cgiGet( "DVELOP_CONFIRMPANEL_SUBMIT_Cancelbuttoncaption");
            Dvelop_confirmpanel_submit_Yesbuttonposition = cgiGet( "DVELOP_CONFIRMPANEL_SUBMIT_Yesbuttonposition");
            Dvelop_confirmpanel_submit_Confirmtype = cgiGet( "DVELOP_CONFIRMPANEL_SUBMIT_Confirmtype");
            Dvelop_confirmpanel_check_Result = cgiGet( "DVELOP_CONFIRMPANEL_CHECK_Result");
            Dvelop_confirmpanel_recheck_Result = cgiGet( "DVELOP_CONFIRMPANEL_RECHECK_Result");
            Dvelop_confirmpanel_submit_Result = cgiGet( "DVELOP_CONFIRMPANEL_SUBMIT_Result");
            Tabs_Activepagecontrolname = cgiGet( "TABS_Activepagecontrolname");
            /* Read subfile selected row values. */
            /* Read hidden variables. */
            GXKey = Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
         }
         else
         {
            dynload_actions( ) ;
         }
      }

      protected void GXStart( )
      {
         /* Execute user event: Start */
         E181X2 ();
         if (returnInSub) return;
      }

      protected void E181X2( )
      {
         /* Start Routine */
         new GeneXus.Programs.wwpbaseobjects.loadwwpcontext(context ).execute( out  AV6WWPContext) ;
         AV29GXLvl9 = 0;
         /* Using cursor H001X2 */
         pr_default.execute(0, new Object[] {AV10BR_EncounterID});
         while ( (pr_default.getStatus(0) != 101) )
         {
            A19BR_EncounterID = H001X2_A19BR_EncounterID[0];
            AV29GXLvl9 = 1;
            Form.Caption = "Data Mgmt Portal - RAAP";
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, "FORM", "Caption", Form.Caption, true);
            AV9Exists = true;
            /* Exiting from a For First loop. */
            if (true) break;
         }
         pr_default.close(0);
         if ( AV29GXLvl9 == 0 )
         {
            Form.Caption = "记录未找到";
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, "FORM", "Caption", Form.Caption, true);
            AV9Exists = false;
         }
         if ( AV9Exists )
         {
            AV12SelectedTabCode = AV8TabCode;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12SelectedTabCode", AV12SelectedTabCode);
            Tabs_Activepagecontrolname = AV12SelectedTabCode;
            ucTabs.SendProperty(context, "", false, Tabs_Internalname, "ActivePageControlName", Tabs_Activepagecontrolname);
            /* Execute user subroutine: 'LOADTABS' */
            S112 ();
            if (returnInSub) return;
         }
         AV16BCBR_Encounter.Load(AV10BR_EncounterID);
         AV17WebSession.Set("Br_EncounterType", "update");
         AV17WebSession.Set("Medication_Br_EncounterID", StringUtil.Trim( StringUtil.Str( (decimal)(AV10BR_EncounterID), 18, 0)));
         AV18tPageReturn = StringUtil.Trim( AV17WebSession.Get("Br_EncounterReturnPage"));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV18tPageReturn", AV18tPageReturn);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vTPAGERETURN", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( AV18tPageReturn, "")), context));
         AV19tButtonFrom = StringUtil.Trim( AV17WebSession.Get("Permisstion_Update"));
         if ( StringUtil.StrCmp(AV19tButtonFrom, "yes") == 0 )
         {
            bttBtnsubmit_Visible = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtnsubmit_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtnsubmit_Visible), 5, 0)), true);
            if ( AV16BCBR_Encounter.gxTpr_Br_encounter_status == 3 )
            {
               bttBtncheck_Visible = 1;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtncheck_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtncheck_Visible), 5, 0)), true);
            }
            else
            {
               bttBtncheck_Visible = 0;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtncheck_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtncheck_Visible), 5, 0)), true);
            }
            if ( AV16BCBR_Encounter.gxTpr_Br_encounter_status == 5 )
            {
               bttBtnrecheck_Visible = 1;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtnrecheck_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtnrecheck_Visible), 5, 0)), true);
            }
            else
            {
               bttBtnrecheck_Visible = 0;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtnrecheck_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtnrecheck_Visible), 5, 0)), true);
            }
         }
         else
         {
            bttBtncheck_Visible = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtncheck_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtncheck_Visible), 5, 0)), true);
            bttBtnrecheck_Visible = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtnrecheck_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtnrecheck_Visible), 5, 0)), true);
            bttBtnsubmit_Visible = 1;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtnsubmit_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtnsubmit_Visible), 5, 0)), true);
         }
         GXt_boolean1 = AV26IsInsert;
         new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "Role_CRC", out  GXt_boolean1) ;
         AV26IsInsert = GXt_boolean1;
         if ( AV16BCBR_Encounter.gxTpr_Br_encounter_status == 1 )
         {
            if ( ! AV26IsInsert )
            {
               CallWebObject(formatLink("wwpbaseobjects.notauthorized.aspx") );
               context.wjLocDisableFrm = 1;
            }
         }
         else
         {
            if ( AV16BCBR_Encounter.gxTpr_Br_encounter_status == 2 )
            {
               GXt_boolean1 = AV5IsAuthorized;
               new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "Manage_FlowStatus_WaitCheck", out  GXt_boolean1) ;
               AV5IsAuthorized = GXt_boolean1;
               if ( ! ( AV5IsAuthorized ) )
               {
                  CallWebObject(formatLink("wwpbaseobjects.notauthorized.aspx") );
                  context.wjLocDisableFrm = 1;
               }
            }
            else if ( AV16BCBR_Encounter.gxTpr_Br_encounter_status == 3 )
            {
               GXt_boolean1 = AV5IsAuthorized;
               new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "Manage_FlowStatus_DenyCheck", out  GXt_boolean1) ;
               AV5IsAuthorized = GXt_boolean1;
               if ( ! ( AV5IsAuthorized ) )
               {
                  CallWebObject(formatLink("wwpbaseobjects.notauthorized.aspx") );
                  context.wjLocDisableFrm = 1;
               }
            }
            else if ( AV16BCBR_Encounter.gxTpr_Br_encounter_status == 4 )
            {
               GXt_boolean1 = AV5IsAuthorized;
               new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "Manage_FlowStatus_WaitApprove", out  GXt_boolean1) ;
               AV5IsAuthorized = GXt_boolean1;
               if ( ! ( AV5IsAuthorized ) )
               {
                  CallWebObject(formatLink("wwpbaseobjects.notauthorized.aspx") );
                  context.wjLocDisableFrm = 1;
               }
            }
            else if ( AV16BCBR_Encounter.gxTpr_Br_encounter_status == 5 )
            {
               GXt_boolean1 = AV5IsAuthorized;
               new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "Manage_FlowStatus_DenyApprove", out  GXt_boolean1) ;
               AV5IsAuthorized = GXt_boolean1;
               if ( ! ( AV5IsAuthorized ) )
               {
                  CallWebObject(formatLink("wwpbaseobjects.notauthorized.aspx") );
                  context.wjLocDisableFrm = 1;
               }
            }
            else if ( AV16BCBR_Encounter.gxTpr_Br_encounter_status == 6 )
            {
               GXt_boolean1 = AV5IsAuthorized;
               new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "Manage_FlowStatus_Complete", out  GXt_boolean1) ;
               AV5IsAuthorized = GXt_boolean1;
               if ( ! ( AV5IsAuthorized ) )
               {
                  CallWebObject(formatLink("wwpbaseobjects.notauthorized.aspx") );
                  context.wjLocDisableFrm = 1;
               }
            }
         }
      }

      protected void E191X2( )
      {
         /* Refresh Routine */
         if ( 1 == 0 )
         {
            GXt_boolean1 = AV13TempBoolean;
            new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "Role_Checker", out  GXt_boolean1) ;
            AV13TempBoolean = GXt_boolean1;
            if ( ! ( AV13TempBoolean ) )
            {
               bttBtncheck_Visible = 0;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtncheck_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtncheck_Visible), 5, 0)), true);
            }
            GXt_boolean1 = AV13TempBoolean;
            new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "WWBR_Encounter_Insert", out  GXt_boolean1) ;
            AV13TempBoolean = GXt_boolean1;
            if ( ! ( AV13TempBoolean ) )
            {
               bttBtnsubmit_Visible = 0;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtnsubmit_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtnsubmit_Visible), 5, 0)), true);
            }
         }
         GXt_boolean1 = AV13TempBoolean;
         new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "Manage_Diagnosis", out  GXt_boolean1) ;
         AV13TempBoolean = GXt_boolean1;
         if ( ! ( AV13TempBoolean ) )
         {
            bttBtnsubmit_Visible = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtnsubmit_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtnsubmit_Visible), 5, 0)), true);
         }
         /*  Sending Event outputs  */
      }

      protected void nextLoad( )
      {
      }

      protected void E201X2( )
      {
         /* Load Routine */
      }

      protected void E151X2( )
      {
         /* Dvelop_confirmpanel_check_Close Routine */
         if ( StringUtil.StrCmp(Dvelop_confirmpanel_check_Result, "Yes") == 0 )
         {
            /* Execute user subroutine: 'DO ACTION CHECK' */
            S122 ();
            if (returnInSub) return;
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV16BCBR_Encounter", AV16BCBR_Encounter);
      }

      protected void E161X2( )
      {
         /* Dvelop_confirmpanel_recheck_Close Routine */
         if ( StringUtil.StrCmp(Dvelop_confirmpanel_recheck_Result, "Yes") == 0 )
         {
            /* Execute user subroutine: 'DO ACTION RECHECK' */
            S132 ();
            if (returnInSub) return;
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV16BCBR_Encounter", AV16BCBR_Encounter);
      }

      protected void E171X2( )
      {
         /* Dvelop_confirmpanel_submit_Close Routine */
         if ( StringUtil.StrCmp(Dvelop_confirmpanel_submit_Result, "Yes") == 0 )
         {
            /* Execute user subroutine: 'DO ACTION SUBMIT' */
            S142 ();
            if (returnInSub) return;
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV16BCBR_Encounter", AV16BCBR_Encounter);
      }

      protected void E211X2( )
      {
         /* 'Doreturn' Routine */
         new zutil_checksession(context ).execute( out  AV25tCheckFlag) ;
         if ( ! AV25tCheckFlag )
         {
            AV17WebSession.Remove("Br_EncounterReturnPage");
            if ( StringUtil.StrCmp(AV18tPageReturn, "br_encounter") == 0 )
            {
               CallWebObject(formatLink("br_encounterlist.aspx") );
               context.wjLocDisableFrm = 1;
            }
            else
            {
               CallWebObject(formatLink("br_informationview.aspx") + "?" + UrlEncode("" +AV16BCBR_Encounter.gxTpr_Br_information_id) + "," + UrlEncode(StringUtil.RTrim("br_encounter")));
               context.wjLocDisableFrm = 1;
            }
         }
      }

      protected void E141X2( )
      {
         /* Tabs_Tabchanged Routine */
         AV12SelectedTabCode = Tabs_Activepagecontrolname;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12SelectedTabCode", AV12SelectedTabCode);
         AV11LoadAllTabs = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11LoadAllTabs", AV11LoadAllTabs);
         /* Execute user subroutine: 'LOADTABS' */
         S112 ();
         if (returnInSub) return;
         /*  Sending Event outputs  */
      }

      protected void E221X2( )
      {
         /* 'BR_Encounter' Routine */
         this.executeUsercontrolMethod("", false, "TABSContainer", "SelectTab", "", new Object[] {(short)1});
         AV12SelectedTabCode = "BR_Encounter";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12SelectedTabCode", AV12SelectedTabCode);
         AV11LoadAllTabs = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11LoadAllTabs", AV11LoadAllTabs);
         /* Execute user subroutine: 'LOADTABS' */
         S112 ();
         if (returnInSub) return;
         /*  Sending Event outputs  */
      }

      protected void E231X2( )
      {
         /* 'BR_Demographics' Routine */
         this.executeUsercontrolMethod("", false, "TABSContainer", "SelectTab", "", new Object[] {(short)2});
         AV12SelectedTabCode = "BR_Demographics";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12SelectedTabCode", AV12SelectedTabCode);
         AV11LoadAllTabs = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11LoadAllTabs", AV11LoadAllTabs);
         /* Execute user subroutine: 'LOADTABS' */
         S112 ();
         if (returnInSub) return;
         /*  Sending Event outputs  */
      }

      protected void E241X2( )
      {
         /* 'BR_Behavior' Routine */
         this.executeUsercontrolMethod("", false, "TABSContainer", "SelectTab", "", new Object[] {(short)3});
         AV12SelectedTabCode = "BR_Behavior";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12SelectedTabCode", AV12SelectedTabCode);
         AV11LoadAllTabs = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11LoadAllTabs", AV11LoadAllTabs);
         /* Execute user subroutine: 'LOADTABS' */
         S112 ();
         if (returnInSub) return;
         /*  Sending Event outputs  */
      }

      protected void E251X2( )
      {
         /* 'BR_Comorbidity' Routine */
         this.executeUsercontrolMethod("", false, "TABSContainer", "SelectTab", "", new Object[] {(short)4});
         AV12SelectedTabCode = "BR_Comorbidity";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12SelectedTabCode", AV12SelectedTabCode);
         AV11LoadAllTabs = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11LoadAllTabs", AV11LoadAllTabs);
         /* Execute user subroutine: 'LOADTABS' */
         S112 ();
         if (returnInSub) return;
         /*  Sending Event outputs  */
      }

      protected void E261X2( )
      {
         /* 'BR_Death' Routine */
         this.executeUsercontrolMethod("", false, "TABSContainer", "SelectTab", "", new Object[] {(short)5});
         AV12SelectedTabCode = "BR_Death";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12SelectedTabCode", AV12SelectedTabCode);
         AV11LoadAllTabs = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11LoadAllTabs", AV11LoadAllTabs);
         /* Execute user subroutine: 'LOADTABS' */
         S112 ();
         if (returnInSub) return;
         /*  Sending Event outputs  */
      }

      protected void E271X2( )
      {
         /* 'BR_Vital' Routine */
         this.executeUsercontrolMethod("", false, "TABSContainer", "SelectTab", "", new Object[] {(short)6});
         AV12SelectedTabCode = "BR_Vital";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12SelectedTabCode", AV12SelectedTabCode);
         AV11LoadAllTabs = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11LoadAllTabs", AV11LoadAllTabs);
         /* Execute user subroutine: 'LOADTABS' */
         S112 ();
         if (returnInSub) return;
         /*  Sending Event outputs  */
      }

      protected void E281X2( )
      {
         /* 'BR_Diagnosis' Routine */
         this.executeUsercontrolMethod("", false, "TABSContainer", "SelectTab", "", new Object[] {(short)7});
         AV12SelectedTabCode = "BR_Diagnosis";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12SelectedTabCode", AV12SelectedTabCode);
         AV11LoadAllTabs = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11LoadAllTabs", AV11LoadAllTabs);
         /* Execute user subroutine: 'LOADTABS' */
         S112 ();
         if (returnInSub) return;
         /*  Sending Event outputs  */
      }

      protected void E291X2( )
      {
         /* 'BR_Lab' Routine */
         this.executeUsercontrolMethod("", false, "TABSContainer", "SelectTab", "", new Object[] {(short)8});
         AV12SelectedTabCode = "BR_Lab";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12SelectedTabCode", AV12SelectedTabCode);
         AV11LoadAllTabs = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11LoadAllTabs", AV11LoadAllTabs);
         /* Execute user subroutine: 'LOADTABS' */
         S112 ();
         if (returnInSub) return;
         /*  Sending Event outputs  */
      }

      protected void E301X2( )
      {
         /* 'BR_Medication' Routine */
         this.executeUsercontrolMethod("", false, "TABSContainer", "SelectTab", "", new Object[] {(short)9});
         AV12SelectedTabCode = "BR_Medication";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12SelectedTabCode", AV12SelectedTabCode);
         AV11LoadAllTabs = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11LoadAllTabs", AV11LoadAllTabs);
         /* Execute user subroutine: 'LOADTABS' */
         S112 ();
         if (returnInSub) return;
         /*  Sending Event outputs  */
      }

      protected void E311X2( )
      {
         /* 'BR_Scheme' Routine */
         this.executeUsercontrolMethod("", false, "TABSContainer", "SelectTab", "", new Object[] {(short)10});
         AV12SelectedTabCode = "BR_Scheme";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12SelectedTabCode", AV12SelectedTabCode);
         AV11LoadAllTabs = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11LoadAllTabs", AV11LoadAllTabs);
         /* Execute user subroutine: 'LOADTABS' */
         S112 ();
         if (returnInSub) return;
         /*  Sending Event outputs  */
      }

      protected void E321X2( )
      {
         /* 'BR_Procedure' Routine */
         this.executeUsercontrolMethod("", false, "TABSContainer", "SelectTab", "", new Object[] {(short)11});
         AV12SelectedTabCode = "BR_Procedure";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12SelectedTabCode", AV12SelectedTabCode);
         AV11LoadAllTabs = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11LoadAllTabs", AV11LoadAllTabs);
         /* Execute user subroutine: 'LOADTABS' */
         S112 ();
         if (returnInSub) return;
         /*  Sending Event outputs  */
      }

      protected void E331X2( )
      {
         /* 'BR_MedicalImaging' Routine */
         this.executeUsercontrolMethod("", false, "TABSContainer", "SelectTab", "", new Object[] {(short)12});
         AV12SelectedTabCode = "BR_MedicalImaging";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12SelectedTabCode", AV12SelectedTabCode);
         AV11LoadAllTabs = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11LoadAllTabs", AV11LoadAllTabs);
         /* Execute user subroutine: 'LOADTABS' */
         S112 ();
         if (returnInSub) return;
         /*  Sending Event outputs  */
      }

      protected void E341X2( )
      {
         /* 'BR_Pathology' Routine */
         this.executeUsercontrolMethod("", false, "TABSContainer", "SelectTab", "", new Object[] {(short)13});
         AV12SelectedTabCode = "BR_Pathology";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12SelectedTabCode", AV12SelectedTabCode);
         AV11LoadAllTabs = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11LoadAllTabs", AV11LoadAllTabs);
         /* Execute user subroutine: 'LOADTABS' */
         S112 ();
         if (returnInSub) return;
         /*  Sending Event outputs  */
      }

      protected void S122( )
      {
         /* 'DO ACTION CHECK' Routine */
         new zutil_checksession(context ).execute( out  AV25tCheckFlag) ;
         if ( ! AV25tCheckFlag )
         {
            AV16BCBR_Encounter.Load(AV10BR_EncounterID);
            AV16BCBR_Encounter.gxTpr_Br_encounter_status = 4;
            AV16BCBR_Encounter.gxTpr_Br_encounter_israndapprover = AV6WWPContext.gxTpr_Userdisplayname;
            AV16BCBR_Encounter.gxTpr_Br_encounter_israndapprovedate = DateTimeUtil.ServerNow( context, pr_default);
            AV16BCBR_Encounter.Save();
            if ( AV16BCBR_Encounter.Success() )
            {
               new zutil_recordlog(context ).execute(  StringUtil.Trim( StringUtil.Str( (decimal)(AV16BCBR_Encounter.gxTpr_Br_encounterid), 18, 0)),  "就诊信息",  "Check",  1) ;
               context.CommitDataStores("br_encounterupdate",pr_default);
               AV17WebSession.Remove("Br_EncounterReturnPage");
               if ( StringUtil.StrCmp(AV18tPageReturn, "br_encounter") == 0 )
               {
                  CallWebObject(formatLink("br_encounterlist.aspx") );
                  context.wjLocDisableFrm = 1;
               }
               else
               {
                  CallWebObject(formatLink("br_informationview.aspx") + "?" + UrlEncode("" +AV16BCBR_Encounter.gxTpr_Br_information_id) + "," + UrlEncode(StringUtil.RTrim("br_encounter")));
                  context.wjLocDisableFrm = 1;
               }
            }
            else
            {
               AV22ErrorMsg = "";
               AV31GXV2 = 1;
               AV30GXV1 = AV16BCBR_Encounter.GetMessages();
               while ( AV31GXV2 <= AV30GXV1.Count )
               {
                  AV21message = ((SdtMessages_Message)AV30GXV1.Item(AV31GXV2));
                  AV22ErrorMsg = AV22ErrorMsg + StringUtil.Trim( AV21message.gxTpr_Description);
                  AV31GXV2 = (int)(AV31GXV2+1);
               }
               GX_msglist.addItem("保存失败");
            }
         }
      }

      protected void S132( )
      {
         /* 'DO ACTION RECHECK' Routine */
         new zutil_checksession(context ).execute( out  AV25tCheckFlag) ;
         if ( ! AV25tCheckFlag )
         {
            AV16BCBR_Encounter.Load(AV10BR_EncounterID);
            AV16BCBR_Encounter.gxTpr_Br_encounter_status = 6;
            AV16BCBR_Encounter.gxTpr_Br_encounter_israndrecheckr = AV6WWPContext.gxTpr_Userdisplayname;
            AV16BCBR_Encounter.gxTpr_Br_encounter_israndrecheckdate = DateTimeUtil.ServerNow( context, pr_default);
            AV16BCBR_Encounter.Save();
            if ( AV16BCBR_Encounter.Success() )
            {
               new zutil_recordlog(context ).execute(  StringUtil.Trim( StringUtil.Str( (decimal)(AV16BCBR_Encounter.gxTpr_Br_encounterid), 18, 0)),  "就诊信息",  "Approve",  1) ;
               context.CommitDataStores("br_encounterupdate",pr_default);
               AV17WebSession.Remove("Br_EncounterReturnPage");
               if ( StringUtil.StrCmp(AV18tPageReturn, "br_encounter") == 0 )
               {
                  CallWebObject(formatLink("br_encounterlist.aspx") );
                  context.wjLocDisableFrm = 1;
               }
               else
               {
                  CallWebObject(formatLink("br_informationview.aspx") + "?" + UrlEncode("" +AV16BCBR_Encounter.gxTpr_Br_information_id) + "," + UrlEncode(StringUtil.RTrim("br_encounter")));
                  context.wjLocDisableFrm = 1;
               }
            }
            else
            {
               GX_msglist.addItem("保存失败");
            }
         }
      }

      protected void S142( )
      {
         /* 'DO ACTION SUBMIT' Routine */
         new zutil_checksession(context ).execute( out  AV25tCheckFlag) ;
         if ( ! AV25tCheckFlag )
         {
            AV16BCBR_Encounter.Load(AV10BR_EncounterID);
            AV16BCBR_Encounter.gxTpr_Br_encounter_status = 2;
            AV16BCBR_Encounter.gxTpr_Br_encounter_submituser = AV6WWPContext.gxTpr_Userdisplayname;
            AV16BCBR_Encounter.gxTpr_Br_encounter_submitdate = DateTimeUtil.ServerNow( context, pr_default);
            AV16BCBR_Encounter.Save();
            if ( AV16BCBR_Encounter.Success() )
            {
               new zutil_recordlog(context ).execute(  StringUtil.Trim( StringUtil.Str( (decimal)(AV16BCBR_Encounter.gxTpr_Br_encounterid), 18, 0)),  "就诊信息",  "Submit",  1) ;
               context.CommitDataStores("br_encounterupdate",pr_default);
               AV17WebSession.Remove("Br_EncounterReturnPage");
               if ( StringUtil.StrCmp(AV18tPageReturn, "br_encounter") == 0 )
               {
                  CallWebObject(formatLink("br_encounterlist.aspx") );
                  context.wjLocDisableFrm = 1;
               }
               else
               {
                  CallWebObject(formatLink("br_informationview.aspx") + "?" + UrlEncode("" +AV16BCBR_Encounter.gxTpr_Br_information_id) + "," + UrlEncode(StringUtil.RTrim("br_encounter")));
                  context.wjLocDisableFrm = 1;
               }
            }
            else
            {
               AV22ErrorMsg = "";
               AV33GXV4 = 1;
               AV32GXV3 = AV16BCBR_Encounter.GetMessages();
               while ( AV33GXV4 <= AV32GXV3.Count )
               {
                  AV21message = ((SdtMessages_Message)AV32GXV3.Item(AV33GXV4));
                  AV22ErrorMsg = AV22ErrorMsg + StringUtil.Trim( AV21message.gxTpr_Description);
                  AV33GXV4 = (int)(AV33GXV4+1);
               }
               GX_msglist.addItem(StringUtil.Trim( AV22ErrorMsg));
            }
         }
      }

      protected void S112( )
      {
         /* 'LOADTABS' Routine */
         new zutil_checksession(context ).execute( out  AV25tCheckFlag) ;
         /* Using cursor H001X3 */
         pr_default.execute(1, new Object[] {AV10BR_EncounterID});
         while ( (pr_default.getStatus(1) != 101) )
         {
            A19BR_EncounterID = H001X3_A19BR_EncounterID[0];
            divCell_br_encounter_Visible = 1;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, divCell_br_encounter_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(divCell_br_encounter_Visible), 5, 0)), true);
            GXt_boolean1 = AV13TempBoolean;
            new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "Check_Encounter", out  GXt_boolean1) ;
            AV13TempBoolean = GXt_boolean1;
            if ( AV13TempBoolean )
            {
               if ( AV11LoadAllTabs || ( StringUtil.StrCmp(AV12SelectedTabCode, "") == 0 ) || ( StringUtil.StrCmp(AV12SelectedTabCode, "BR_Encounter") == 0 ) )
               {
                  /* Object Property */
                  if ( StringUtil.StrCmp(StringUtil.Lower( WebComp_Br_encounterwc_Component), StringUtil.Lower( "BR_EncounterUpdateGeneral")) != 0 )
                  {
                     WebComp_Br_encounterwc = getWebComponent(GetType(), "GeneXus.Programs", "br_encounterupdategeneral", new Object[] {context} );
                     WebComp_Br_encounterwc.ComponentInit();
                     WebComp_Br_encounterwc.Name = "BR_EncounterUpdateGeneral";
                     WebComp_Br_encounterwc_Component = "BR_EncounterUpdateGeneral";
                  }
                  if ( StringUtil.Len( WebComp_Br_encounterwc_Component) != 0 )
                  {
                     WebComp_Br_encounterwc.setjustcreated();
                     WebComp_Br_encounterwc.componentprepare(new Object[] {(String)"W0034",(String)"",(long)AV10BR_EncounterID});
                     WebComp_Br_encounterwc.componentbind(new Object[] {(String)""});
                  }
                  if ( isFullAjaxMode( ) )
                  {
                     context.httpAjaxContext.ajax_rspStartCmp("gxHTMLWrpW0034"+"");
                     WebComp_Br_encounterwc.componentdraw();
                     context.httpAjaxContext.ajax_rspEndCmp();
                  }
                  lblTxttabtitle_Caption = "就诊信息";
                  context.httpAjaxContext.ajax_rsp_assign_prop("", false, lblTxttabtitle_Internalname, "Caption", lblTxttabtitle_Caption, true);
                  if ( ( StringUtil.StrCmp(AV12SelectedTabCode, "") == 0 ) || ( StringUtil.StrCmp(AV12SelectedTabCode, "BR_Encounter") == 0 ) )
                  {
                     divCell_br_encounter_Visible = 0;
                     context.httpAjaxContext.ajax_rsp_assign_prop("", false, divCell_br_encounter_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(divCell_br_encounter_Visible), 5, 0)), true);
                  }
               }
            }
            else
            {
               divCell_br_encounter_Visible = 0;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, divCell_br_encounter_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(divCell_br_encounter_Visible), 5, 0)), true);
               this.executeUsercontrolMethod("", false, "TABSContainer", "HideTab", "", new Object[] {(short)1});
            }
            divCell_br_demographics_Visible = 1;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, divCell_br_demographics_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(divCell_br_demographics_Visible), 5, 0)), true);
            GXt_boolean1 = AV13TempBoolean;
            new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "Check_Encounter", out  GXt_boolean1) ;
            AV13TempBoolean = GXt_boolean1;
            if ( AV13TempBoolean )
            {
               if ( AV11LoadAllTabs || ( StringUtil.StrCmp(AV12SelectedTabCode, "BR_Demographics") == 0 ) )
               {
                  /* Object Property */
                  if ( StringUtil.StrCmp(StringUtil.Lower( WebComp_Br_demographicswc_Component), StringUtil.Lower( "BR_EncounterUpdateDemographics")) != 0 )
                  {
                     WebComp_Br_demographicswc = getWebComponent(GetType(), "GeneXus.Programs", "br_encounterupdatedemographics", new Object[] {context} );
                     WebComp_Br_demographicswc.ComponentInit();
                     WebComp_Br_demographicswc.Name = "BR_EncounterUpdateDemographics";
                     WebComp_Br_demographicswc_Component = "BR_EncounterUpdateDemographics";
                  }
                  if ( StringUtil.Len( WebComp_Br_demographicswc_Component) != 0 )
                  {
                     WebComp_Br_demographicswc.setjustcreated();
                     WebComp_Br_demographicswc.componentprepare(new Object[] {(String)"W0042",(String)"",(long)AV10BR_EncounterID});
                     WebComp_Br_demographicswc.componentbind(new Object[] {(String)""});
                  }
                  if ( isFullAjaxMode( ) )
                  {
                     context.httpAjaxContext.ajax_rspStartCmp("gxHTMLWrpW0042"+"");
                     WebComp_Br_demographicswc.componentdraw();
                     context.httpAjaxContext.ajax_rspEndCmp();
                  }
                  lblTxttabtitle_Caption = "人口信息学";
                  context.httpAjaxContext.ajax_rsp_assign_prop("", false, lblTxttabtitle_Internalname, "Caption", lblTxttabtitle_Caption, true);
                  if ( StringUtil.StrCmp(AV12SelectedTabCode, "BR_Demographics") == 0 )
                  {
                     divCell_br_demographics_Visible = 0;
                     context.httpAjaxContext.ajax_rsp_assign_prop("", false, divCell_br_demographics_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(divCell_br_demographics_Visible), 5, 0)), true);
                  }
               }
            }
            else
            {
               divCell_br_demographics_Visible = 0;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, divCell_br_demographics_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(divCell_br_demographics_Visible), 5, 0)), true);
               this.executeUsercontrolMethod("", false, "TABSContainer", "HideTab", "", new Object[] {(short)2});
            }
            divCell_br_behavior_Visible = 1;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, divCell_br_behavior_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(divCell_br_behavior_Visible), 5, 0)), true);
            GXt_boolean1 = AV13TempBoolean;
            new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "Check_Encounter", out  GXt_boolean1) ;
            AV13TempBoolean = GXt_boolean1;
            if ( AV13TempBoolean )
            {
               if ( AV11LoadAllTabs || ( StringUtil.StrCmp(AV12SelectedTabCode, "BR_Behavior") == 0 ) )
               {
                  /* Object Property */
                  if ( StringUtil.StrCmp(StringUtil.Lower( WebComp_Br_behaviorwc_Component), StringUtil.Lower( "BR_EncounterUpdateBehavior")) != 0 )
                  {
                     WebComp_Br_behaviorwc = getWebComponent(GetType(), "GeneXus.Programs", "br_encounterupdatebehavior", new Object[] {context} );
                     WebComp_Br_behaviorwc.ComponentInit();
                     WebComp_Br_behaviorwc.Name = "BR_EncounterUpdateBehavior";
                     WebComp_Br_behaviorwc_Component = "BR_EncounterUpdateBehavior";
                  }
                  if ( StringUtil.Len( WebComp_Br_behaviorwc_Component) != 0 )
                  {
                     WebComp_Br_behaviorwc.setjustcreated();
                     WebComp_Br_behaviorwc.componentprepare(new Object[] {(String)"W0050",(String)"",(long)AV10BR_EncounterID});
                     WebComp_Br_behaviorwc.componentbind(new Object[] {(String)""});
                  }
                  if ( isFullAjaxMode( ) )
                  {
                     context.httpAjaxContext.ajax_rspStartCmp("gxHTMLWrpW0050"+"");
                     WebComp_Br_behaviorwc.componentdraw();
                     context.httpAjaxContext.ajax_rspEndCmp();
                  }
                  lblTxttabtitle_Caption = "个人史";
                  context.httpAjaxContext.ajax_rsp_assign_prop("", false, lblTxttabtitle_Internalname, "Caption", lblTxttabtitle_Caption, true);
                  if ( StringUtil.StrCmp(AV12SelectedTabCode, "BR_Behavior") == 0 )
                  {
                     divCell_br_behavior_Visible = 0;
                     context.httpAjaxContext.ajax_rsp_assign_prop("", false, divCell_br_behavior_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(divCell_br_behavior_Visible), 5, 0)), true);
                  }
               }
            }
            else
            {
               divCell_br_behavior_Visible = 0;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, divCell_br_behavior_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(divCell_br_behavior_Visible), 5, 0)), true);
               this.executeUsercontrolMethod("", false, "TABSContainer", "HideTab", "", new Object[] {(short)3});
            }
            divCell_br_comorbidity_Visible = 1;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, divCell_br_comorbidity_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(divCell_br_comorbidity_Visible), 5, 0)), true);
            GXt_boolean1 = AV13TempBoolean;
            new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "Check_Encounter", out  GXt_boolean1) ;
            AV13TempBoolean = GXt_boolean1;
            if ( AV13TempBoolean )
            {
               if ( AV11LoadAllTabs || ( StringUtil.StrCmp(AV12SelectedTabCode, "BR_Comorbidity") == 0 ) )
               {
                  /* Object Property */
                  if ( StringUtil.StrCmp(StringUtil.Lower( WebComp_Br_comorbiditywc_Component), StringUtil.Lower( "BR_EncounterUpdateComorbidity")) != 0 )
                  {
                     WebComp_Br_comorbiditywc = getWebComponent(GetType(), "GeneXus.Programs", "br_encounterupdatecomorbidity", new Object[] {context} );
                     WebComp_Br_comorbiditywc.ComponentInit();
                     WebComp_Br_comorbiditywc.Name = "BR_EncounterUpdateComorbidity";
                     WebComp_Br_comorbiditywc_Component = "BR_EncounterUpdateComorbidity";
                  }
                  if ( StringUtil.Len( WebComp_Br_comorbiditywc_Component) != 0 )
                  {
                     WebComp_Br_comorbiditywc.setjustcreated();
                     WebComp_Br_comorbiditywc.componentprepare(new Object[] {(String)"W0058",(String)"",(long)AV10BR_EncounterID});
                     WebComp_Br_comorbiditywc.componentbind(new Object[] {(String)""});
                  }
                  if ( isFullAjaxMode( ) )
                  {
                     context.httpAjaxContext.ajax_rspStartCmp("gxHTMLWrpW0058"+"");
                     WebComp_Br_comorbiditywc.componentdraw();
                     context.httpAjaxContext.ajax_rspEndCmp();
                  }
                  lblTxttabtitle_Caption = "既往病史";
                  context.httpAjaxContext.ajax_rsp_assign_prop("", false, lblTxttabtitle_Internalname, "Caption", lblTxttabtitle_Caption, true);
                  if ( StringUtil.StrCmp(AV12SelectedTabCode, "BR_Comorbidity") == 0 )
                  {
                     divCell_br_comorbidity_Visible = 0;
                     context.httpAjaxContext.ajax_rsp_assign_prop("", false, divCell_br_comorbidity_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(divCell_br_comorbidity_Visible), 5, 0)), true);
                  }
               }
            }
            else
            {
               divCell_br_comorbidity_Visible = 0;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, divCell_br_comorbidity_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(divCell_br_comorbidity_Visible), 5, 0)), true);
               this.executeUsercontrolMethod("", false, "TABSContainer", "HideTab", "", new Object[] {(short)4});
            }
            divCell_br_death_Visible = 1;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, divCell_br_death_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(divCell_br_death_Visible), 5, 0)), true);
            GXt_boolean1 = AV13TempBoolean;
            new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "Check_Encounter", out  GXt_boolean1) ;
            AV13TempBoolean = GXt_boolean1;
            if ( AV13TempBoolean )
            {
               if ( AV11LoadAllTabs || ( StringUtil.StrCmp(AV12SelectedTabCode, "BR_Death") == 0 ) )
               {
                  /* Object Property */
                  if ( StringUtil.StrCmp(StringUtil.Lower( WebComp_Br_deathwc_Component), StringUtil.Lower( "BR_EncounterUpdateDeath")) != 0 )
                  {
                     WebComp_Br_deathwc = getWebComponent(GetType(), "GeneXus.Programs", "br_encounterupdatedeath", new Object[] {context} );
                     WebComp_Br_deathwc.ComponentInit();
                     WebComp_Br_deathwc.Name = "BR_EncounterUpdateDeath";
                     WebComp_Br_deathwc_Component = "BR_EncounterUpdateDeath";
                  }
                  if ( StringUtil.Len( WebComp_Br_deathwc_Component) != 0 )
                  {
                     WebComp_Br_deathwc.setjustcreated();
                     WebComp_Br_deathwc.componentprepare(new Object[] {(String)"W0066",(String)"",(long)AV10BR_EncounterID});
                     WebComp_Br_deathwc.componentbind(new Object[] {(String)""});
                  }
                  if ( isFullAjaxMode( ) )
                  {
                     context.httpAjaxContext.ajax_rspStartCmp("gxHTMLWrpW0066"+"");
                     WebComp_Br_deathwc.componentdraw();
                     context.httpAjaxContext.ajax_rspEndCmp();
                  }
                  lblTxttabtitle_Caption = "死亡情况";
                  context.httpAjaxContext.ajax_rsp_assign_prop("", false, lblTxttabtitle_Internalname, "Caption", lblTxttabtitle_Caption, true);
                  if ( StringUtil.StrCmp(AV12SelectedTabCode, "BR_Death") == 0 )
                  {
                     divCell_br_death_Visible = 0;
                     context.httpAjaxContext.ajax_rsp_assign_prop("", false, divCell_br_death_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(divCell_br_death_Visible), 5, 0)), true);
                  }
               }
            }
            else
            {
               divCell_br_death_Visible = 0;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, divCell_br_death_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(divCell_br_death_Visible), 5, 0)), true);
               this.executeUsercontrolMethod("", false, "TABSContainer", "HideTab", "", new Object[] {(short)5});
            }
            divCell_br_vital_Visible = 1;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, divCell_br_vital_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(divCell_br_vital_Visible), 5, 0)), true);
            GXt_boolean1 = AV13TempBoolean;
            new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "Check_Encounter", out  GXt_boolean1) ;
            AV13TempBoolean = GXt_boolean1;
            if ( AV13TempBoolean )
            {
               if ( AV11LoadAllTabs || ( StringUtil.StrCmp(AV12SelectedTabCode, "BR_Vital") == 0 ) )
               {
                  /* Object Property */
                  if ( StringUtil.StrCmp(StringUtil.Lower( WebComp_Br_vitalwc_Component), StringUtil.Lower( "BR_EncounterUpdateBR_VitalWC")) != 0 )
                  {
                     WebComp_Br_vitalwc = getWebComponent(GetType(), "GeneXus.Programs", "br_encounterupdatebr_vitalwc", new Object[] {context} );
                     WebComp_Br_vitalwc.ComponentInit();
                     WebComp_Br_vitalwc.Name = "BR_EncounterUpdateBR_VitalWC";
                     WebComp_Br_vitalwc_Component = "BR_EncounterUpdateBR_VitalWC";
                  }
                  if ( StringUtil.Len( WebComp_Br_vitalwc_Component) != 0 )
                  {
                     WebComp_Br_vitalwc.setjustcreated();
                     WebComp_Br_vitalwc.componentprepare(new Object[] {(String)"W0074",(String)"",(long)AV10BR_EncounterID});
                     WebComp_Br_vitalwc.componentbind(new Object[] {(String)""});
                  }
                  if ( isFullAjaxMode( ) )
                  {
                     context.httpAjaxContext.ajax_rspStartCmp("gxHTMLWrpW0074"+"");
                     WebComp_Br_vitalwc.componentdraw();
                     context.httpAjaxContext.ajax_rspEndCmp();
                  }
                  lblTxttabtitle_Caption = "生命体征";
                  context.httpAjaxContext.ajax_rsp_assign_prop("", false, lblTxttabtitle_Internalname, "Caption", lblTxttabtitle_Caption, true);
                  if ( StringUtil.StrCmp(AV12SelectedTabCode, "BR_Vital") == 0 )
                  {
                     divCell_br_vital_Visible = 0;
                     context.httpAjaxContext.ajax_rsp_assign_prop("", false, divCell_br_vital_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(divCell_br_vital_Visible), 5, 0)), true);
                  }
               }
            }
            else
            {
               divCell_br_vital_Visible = 0;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, divCell_br_vital_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(divCell_br_vital_Visible), 5, 0)), true);
               this.executeUsercontrolMethod("", false, "TABSContainer", "HideTab", "", new Object[] {(short)6});
            }
            divCell_br_diagnosis_Visible = 1;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, divCell_br_diagnosis_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(divCell_br_diagnosis_Visible), 5, 0)), true);
            GXt_boolean1 = AV13TempBoolean;
            new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "Check_Encounter", out  GXt_boolean1) ;
            AV13TempBoolean = GXt_boolean1;
            if ( AV13TempBoolean )
            {
               if ( AV11LoadAllTabs || ( StringUtil.StrCmp(AV12SelectedTabCode, "BR_Diagnosis") == 0 ) )
               {
                  /* Object Property */
                  if ( StringUtil.StrCmp(StringUtil.Lower( WebComp_Br_diagnosiswc_Component), StringUtil.Lower( "BR_EncounterUpdateBR_DiagnosisWC")) != 0 )
                  {
                     WebComp_Br_diagnosiswc = getWebComponent(GetType(), "GeneXus.Programs", "br_encounterupdatebr_diagnosiswc", new Object[] {context} );
                     WebComp_Br_diagnosiswc.ComponentInit();
                     WebComp_Br_diagnosiswc.Name = "BR_EncounterUpdateBR_DiagnosisWC";
                     WebComp_Br_diagnosiswc_Component = "BR_EncounterUpdateBR_DiagnosisWC";
                  }
                  if ( StringUtil.Len( WebComp_Br_diagnosiswc_Component) != 0 )
                  {
                     WebComp_Br_diagnosiswc.setjustcreated();
                     WebComp_Br_diagnosiswc.componentprepare(new Object[] {(String)"W0082",(String)"",(long)AV10BR_EncounterID});
                     WebComp_Br_diagnosiswc.componentbind(new Object[] {(String)""});
                  }
                  if ( isFullAjaxMode( ) )
                  {
                     context.httpAjaxContext.ajax_rspStartCmp("gxHTMLWrpW0082"+"");
                     WebComp_Br_diagnosiswc.componentdraw();
                     context.httpAjaxContext.ajax_rspEndCmp();
                  }
                  lblTxttabtitle_Caption = "诊断";
                  context.httpAjaxContext.ajax_rsp_assign_prop("", false, lblTxttabtitle_Internalname, "Caption", lblTxttabtitle_Caption, true);
                  if ( StringUtil.StrCmp(AV12SelectedTabCode, "BR_Diagnosis") == 0 )
                  {
                     divCell_br_diagnosis_Visible = 0;
                     context.httpAjaxContext.ajax_rsp_assign_prop("", false, divCell_br_diagnosis_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(divCell_br_diagnosis_Visible), 5, 0)), true);
                  }
               }
            }
            else
            {
               divCell_br_diagnosis_Visible = 0;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, divCell_br_diagnosis_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(divCell_br_diagnosis_Visible), 5, 0)), true);
               this.executeUsercontrolMethod("", false, "TABSContainer", "HideTab", "", new Object[] {(short)7});
            }
            divCell_br_lab_Visible = 1;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, divCell_br_lab_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(divCell_br_lab_Visible), 5, 0)), true);
            GXt_boolean1 = AV13TempBoolean;
            new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "Check_Encounter", out  GXt_boolean1) ;
            AV13TempBoolean = GXt_boolean1;
            if ( AV13TempBoolean )
            {
               if ( AV11LoadAllTabs || ( StringUtil.StrCmp(AV12SelectedTabCode, "BR_Lab") == 0 ) )
               {
                  /* Object Property */
                  if ( StringUtil.StrCmp(StringUtil.Lower( WebComp_Br_labwc_Component), StringUtil.Lower( "BR_EncounterUpdateBR_LabWC")) != 0 )
                  {
                     WebComp_Br_labwc = getWebComponent(GetType(), "GeneXus.Programs", "br_encounterupdatebr_labwc", new Object[] {context} );
                     WebComp_Br_labwc.ComponentInit();
                     WebComp_Br_labwc.Name = "BR_EncounterUpdateBR_LabWC";
                     WebComp_Br_labwc_Component = "BR_EncounterUpdateBR_LabWC";
                  }
                  if ( StringUtil.Len( WebComp_Br_labwc_Component) != 0 )
                  {
                     WebComp_Br_labwc.setjustcreated();
                     WebComp_Br_labwc.componentprepare(new Object[] {(String)"W0090",(String)"",(long)AV10BR_EncounterID});
                     WebComp_Br_labwc.componentbind(new Object[] {(String)""});
                  }
                  if ( isFullAjaxMode( ) )
                  {
                     context.httpAjaxContext.ajax_rspStartCmp("gxHTMLWrpW0090"+"");
                     WebComp_Br_labwc.componentdraw();
                     context.httpAjaxContext.ajax_rspEndCmp();
                  }
                  lblTxttabtitle_Caption = "实验室检查";
                  context.httpAjaxContext.ajax_rsp_assign_prop("", false, lblTxttabtitle_Internalname, "Caption", lblTxttabtitle_Caption, true);
                  if ( StringUtil.StrCmp(AV12SelectedTabCode, "BR_Lab") == 0 )
                  {
                     divCell_br_lab_Visible = 0;
                     context.httpAjaxContext.ajax_rsp_assign_prop("", false, divCell_br_lab_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(divCell_br_lab_Visible), 5, 0)), true);
                  }
               }
            }
            else
            {
               divCell_br_lab_Visible = 0;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, divCell_br_lab_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(divCell_br_lab_Visible), 5, 0)), true);
               this.executeUsercontrolMethod("", false, "TABSContainer", "HideTab", "", new Object[] {(short)8});
            }
            divCell_br_medication_Visible = 1;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, divCell_br_medication_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(divCell_br_medication_Visible), 5, 0)), true);
            GXt_boolean1 = AV13TempBoolean;
            new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "Check_Encounter", out  GXt_boolean1) ;
            AV13TempBoolean = GXt_boolean1;
            if ( AV13TempBoolean )
            {
               if ( AV11LoadAllTabs || ( StringUtil.StrCmp(AV12SelectedTabCode, "BR_Medication") == 0 ) )
               {
                  /* Object Property */
                  if ( StringUtil.StrCmp(StringUtil.Lower( WebComp_Br_medicationwc_Component), StringUtil.Lower( "BR_EncounterUpdateBR_MedicationWC")) != 0 )
                  {
                     WebComp_Br_medicationwc = getWebComponent(GetType(), "GeneXus.Programs", "br_encounterupdatebr_medicationwc", new Object[] {context} );
                     WebComp_Br_medicationwc.ComponentInit();
                     WebComp_Br_medicationwc.Name = "BR_EncounterUpdateBR_MedicationWC";
                     WebComp_Br_medicationwc_Component = "BR_EncounterUpdateBR_MedicationWC";
                  }
                  if ( StringUtil.Len( WebComp_Br_medicationwc_Component) != 0 )
                  {
                     WebComp_Br_medicationwc.setjustcreated();
                     WebComp_Br_medicationwc.componentprepare(new Object[] {(String)"W0098",(String)"",(long)AV10BR_EncounterID});
                     WebComp_Br_medicationwc.componentbind(new Object[] {(String)""});
                  }
                  if ( isFullAjaxMode( ) )
                  {
                     context.httpAjaxContext.ajax_rspStartCmp("gxHTMLWrpW0098"+"");
                     WebComp_Br_medicationwc.componentdraw();
                     context.httpAjaxContext.ajax_rspEndCmp();
                  }
                  lblTxttabtitle_Caption = "药物治疗";
                  context.httpAjaxContext.ajax_rsp_assign_prop("", false, lblTxttabtitle_Internalname, "Caption", lblTxttabtitle_Caption, true);
                  if ( StringUtil.StrCmp(AV12SelectedTabCode, "BR_Medication") == 0 )
                  {
                     divCell_br_medication_Visible = 0;
                     context.httpAjaxContext.ajax_rsp_assign_prop("", false, divCell_br_medication_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(divCell_br_medication_Visible), 5, 0)), true);
                  }
               }
            }
            else
            {
               divCell_br_medication_Visible = 0;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, divCell_br_medication_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(divCell_br_medication_Visible), 5, 0)), true);
               this.executeUsercontrolMethod("", false, "TABSContainer", "HideTab", "", new Object[] {(short)9});
            }
            divCell_br_scheme_Visible = 1;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, divCell_br_scheme_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(divCell_br_scheme_Visible), 5, 0)), true);
            GXt_boolean1 = AV13TempBoolean;
            new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "Check_Encounter", out  GXt_boolean1) ;
            AV13TempBoolean = GXt_boolean1;
            if ( AV13TempBoolean )
            {
               if ( AV11LoadAllTabs || ( StringUtil.StrCmp(AV12SelectedTabCode, "BR_Scheme") == 0 ) )
               {
                  /* Object Property */
                  if ( StringUtil.StrCmp(StringUtil.Lower( WebComp_Br_schemewc_Component), StringUtil.Lower( "BR_EncounterUpdateBR_SchemeWC")) != 0 )
                  {
                     WebComp_Br_schemewc = getWebComponent(GetType(), "GeneXus.Programs", "br_encounterupdatebr_schemewc", new Object[] {context} );
                     WebComp_Br_schemewc.ComponentInit();
                     WebComp_Br_schemewc.Name = "BR_EncounterUpdateBR_SchemeWC";
                     WebComp_Br_schemewc_Component = "BR_EncounterUpdateBR_SchemeWC";
                  }
                  if ( StringUtil.Len( WebComp_Br_schemewc_Component) != 0 )
                  {
                     WebComp_Br_schemewc.setjustcreated();
                     WebComp_Br_schemewc.componentprepare(new Object[] {(String)"W0106",(String)"",(long)AV10BR_EncounterID});
                     WebComp_Br_schemewc.componentbind(new Object[] {(String)""});
                  }
                  if ( isFullAjaxMode( ) )
                  {
                     context.httpAjaxContext.ajax_rspStartCmp("gxHTMLWrpW0106"+"");
                     WebComp_Br_schemewc.componentdraw();
                     context.httpAjaxContext.ajax_rspEndCmp();
                  }
                  lblTxttabtitle_Caption = "化疗方案";
                  context.httpAjaxContext.ajax_rsp_assign_prop("", false, lblTxttabtitle_Internalname, "Caption", lblTxttabtitle_Caption, true);
                  if ( StringUtil.StrCmp(AV12SelectedTabCode, "BR_Scheme") == 0 )
                  {
                     divCell_br_scheme_Visible = 0;
                     context.httpAjaxContext.ajax_rsp_assign_prop("", false, divCell_br_scheme_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(divCell_br_scheme_Visible), 5, 0)), true);
                  }
               }
            }
            else
            {
               divCell_br_scheme_Visible = 0;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, divCell_br_scheme_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(divCell_br_scheme_Visible), 5, 0)), true);
               this.executeUsercontrolMethod("", false, "TABSContainer", "HideTab", "", new Object[] {(short)10});
            }
            divCell_br_procedure_Visible = 1;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, divCell_br_procedure_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(divCell_br_procedure_Visible), 5, 0)), true);
            GXt_boolean1 = AV13TempBoolean;
            new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "Check_Encounter", out  GXt_boolean1) ;
            AV13TempBoolean = GXt_boolean1;
            if ( AV13TempBoolean )
            {
               if ( AV11LoadAllTabs || ( StringUtil.StrCmp(AV12SelectedTabCode, "BR_Procedure") == 0 ) )
               {
                  /* Object Property */
                  if ( StringUtil.StrCmp(StringUtil.Lower( WebComp_Br_procedurewc_Component), StringUtil.Lower( "BR_EncounterUpdateBR_ProcedureWC")) != 0 )
                  {
                     WebComp_Br_procedurewc = getWebComponent(GetType(), "GeneXus.Programs", "br_encounterupdatebr_procedurewc", new Object[] {context} );
                     WebComp_Br_procedurewc.ComponentInit();
                     WebComp_Br_procedurewc.Name = "BR_EncounterUpdateBR_ProcedureWC";
                     WebComp_Br_procedurewc_Component = "BR_EncounterUpdateBR_ProcedureWC";
                  }
                  if ( StringUtil.Len( WebComp_Br_procedurewc_Component) != 0 )
                  {
                     WebComp_Br_procedurewc.setjustcreated();
                     WebComp_Br_procedurewc.componentprepare(new Object[] {(String)"W0114",(String)"",(long)AV10BR_EncounterID});
                     WebComp_Br_procedurewc.componentbind(new Object[] {(String)""});
                  }
                  if ( isFullAjaxMode( ) )
                  {
                     context.httpAjaxContext.ajax_rspStartCmp("gxHTMLWrpW0114"+"");
                     WebComp_Br_procedurewc.componentdraw();
                     context.httpAjaxContext.ajax_rspEndCmp();
                  }
                  lblTxttabtitle_Caption = "诊疗处理";
                  context.httpAjaxContext.ajax_rsp_assign_prop("", false, lblTxttabtitle_Internalname, "Caption", lblTxttabtitle_Caption, true);
                  if ( StringUtil.StrCmp(AV12SelectedTabCode, "BR_Procedure") == 0 )
                  {
                     divCell_br_procedure_Visible = 0;
                     context.httpAjaxContext.ajax_rsp_assign_prop("", false, divCell_br_procedure_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(divCell_br_procedure_Visible), 5, 0)), true);
                  }
               }
            }
            else
            {
               divCell_br_procedure_Visible = 0;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, divCell_br_procedure_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(divCell_br_procedure_Visible), 5, 0)), true);
               this.executeUsercontrolMethod("", false, "TABSContainer", "HideTab", "", new Object[] {(short)11});
            }
            divCell_br_medicalimaging_Visible = 1;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, divCell_br_medicalimaging_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(divCell_br_medicalimaging_Visible), 5, 0)), true);
            GXt_boolean1 = AV13TempBoolean;
            new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "Check_Encounter", out  GXt_boolean1) ;
            AV13TempBoolean = GXt_boolean1;
            if ( AV13TempBoolean )
            {
               if ( AV11LoadAllTabs || ( StringUtil.StrCmp(AV12SelectedTabCode, "BR_MedicalImaging") == 0 ) )
               {
                  /* Object Property */
                  if ( StringUtil.StrCmp(StringUtil.Lower( WebComp_Br_medicalimagingwc_Component), StringUtil.Lower( "BR_EncounterUpdateBR_MedicalImagingWC")) != 0 )
                  {
                     WebComp_Br_medicalimagingwc = getWebComponent(GetType(), "GeneXus.Programs", "br_encounterupdatebr_medicalimagingwc", new Object[] {context} );
                     WebComp_Br_medicalimagingwc.ComponentInit();
                     WebComp_Br_medicalimagingwc.Name = "BR_EncounterUpdateBR_MedicalImagingWC";
                     WebComp_Br_medicalimagingwc_Component = "BR_EncounterUpdateBR_MedicalImagingWC";
                  }
                  if ( StringUtil.Len( WebComp_Br_medicalimagingwc_Component) != 0 )
                  {
                     WebComp_Br_medicalimagingwc.setjustcreated();
                     WebComp_Br_medicalimagingwc.componentprepare(new Object[] {(String)"W0122",(String)"",(long)AV10BR_EncounterID});
                     WebComp_Br_medicalimagingwc.componentbind(new Object[] {(String)""});
                  }
                  if ( isFullAjaxMode( ) )
                  {
                     context.httpAjaxContext.ajax_rspStartCmp("gxHTMLWrpW0122"+"");
                     WebComp_Br_medicalimagingwc.componentdraw();
                     context.httpAjaxContext.ajax_rspEndCmp();
                  }
                  lblTxttabtitle_Caption = "影像学";
                  context.httpAjaxContext.ajax_rsp_assign_prop("", false, lblTxttabtitle_Internalname, "Caption", lblTxttabtitle_Caption, true);
                  if ( StringUtil.StrCmp(AV12SelectedTabCode, "BR_MedicalImaging") == 0 )
                  {
                     divCell_br_medicalimaging_Visible = 0;
                     context.httpAjaxContext.ajax_rsp_assign_prop("", false, divCell_br_medicalimaging_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(divCell_br_medicalimaging_Visible), 5, 0)), true);
                  }
               }
            }
            else
            {
               divCell_br_medicalimaging_Visible = 0;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, divCell_br_medicalimaging_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(divCell_br_medicalimaging_Visible), 5, 0)), true);
               this.executeUsercontrolMethod("", false, "TABSContainer", "HideTab", "", new Object[] {(short)12});
            }
            divCell_br_pathology_Visible = 1;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, divCell_br_pathology_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(divCell_br_pathology_Visible), 5, 0)), true);
            GXt_boolean1 = AV13TempBoolean;
            new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "Check_Encounter", out  GXt_boolean1) ;
            AV13TempBoolean = GXt_boolean1;
            if ( AV13TempBoolean )
            {
               if ( AV11LoadAllTabs || ( StringUtil.StrCmp(AV12SelectedTabCode, "BR_Pathology") == 0 ) )
               {
                  /* Object Property */
                  if ( StringUtil.StrCmp(StringUtil.Lower( WebComp_Br_pathologywc_Component), StringUtil.Lower( "BR_EncounterUpdateBR_PathologyWC")) != 0 )
                  {
                     WebComp_Br_pathologywc = getWebComponent(GetType(), "GeneXus.Programs", "br_encounterupdatebr_pathologywc", new Object[] {context} );
                     WebComp_Br_pathologywc.ComponentInit();
                     WebComp_Br_pathologywc.Name = "BR_EncounterUpdateBR_PathologyWC";
                     WebComp_Br_pathologywc_Component = "BR_EncounterUpdateBR_PathologyWC";
                  }
                  if ( StringUtil.Len( WebComp_Br_pathologywc_Component) != 0 )
                  {
                     WebComp_Br_pathologywc.setjustcreated();
                     WebComp_Br_pathologywc.componentprepare(new Object[] {(String)"W0130",(String)"",(long)AV10BR_EncounterID});
                     WebComp_Br_pathologywc.componentbind(new Object[] {(String)""});
                  }
                  if ( isFullAjaxMode( ) )
                  {
                     context.httpAjaxContext.ajax_rspStartCmp("gxHTMLWrpW0130"+"");
                     WebComp_Br_pathologywc.componentdraw();
                     context.httpAjaxContext.ajax_rspEndCmp();
                  }
                  lblTxttabtitle_Caption = "病理学";
                  context.httpAjaxContext.ajax_rsp_assign_prop("", false, lblTxttabtitle_Internalname, "Caption", lblTxttabtitle_Caption, true);
                  if ( StringUtil.StrCmp(AV12SelectedTabCode, "BR_Pathology") == 0 )
                  {
                     divCell_br_pathology_Visible = 0;
                     context.httpAjaxContext.ajax_rsp_assign_prop("", false, divCell_br_pathology_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(divCell_br_pathology_Visible), 5, 0)), true);
                  }
               }
            }
            else
            {
               divCell_br_pathology_Visible = 0;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, divCell_br_pathology_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(divCell_br_pathology_Visible), 5, 0)), true);
               this.executeUsercontrolMethod("", false, "TABSContainer", "HideTab", "", new Object[] {(short)13});
            }
            /* Exiting from a For First loop. */
            if (true) break;
         }
         pr_default.close(1);
      }

      protected void wb_table3_186_1X2( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "";
            GxWebStd.gx_table_start( context, tblTabledvelop_confirmpanel_submit_Internalname, tblTabledvelop_confirmpanel_submit_Internalname, "", "Table", 0, "", "", 1, 2, sStyleString, "", "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td data-align=\"center\"  style=\""+CSSHelper.Prettify( "text-align:-khtml-center;text-align:-moz-center;text-align:-webkit-center")+"\">") ;
            /* User Defined Control */
            ucDvelop_confirmpanel_submit.SetProperty("Title", Dvelop_confirmpanel_submit_Title);
            ucDvelop_confirmpanel_submit.SetProperty("ConfirmationText", Dvelop_confirmpanel_submit_Confirmationtext);
            ucDvelop_confirmpanel_submit.SetProperty("YesButtonCaption", Dvelop_confirmpanel_submit_Yesbuttoncaption);
            ucDvelop_confirmpanel_submit.SetProperty("NoButtonCaption", Dvelop_confirmpanel_submit_Nobuttoncaption);
            ucDvelop_confirmpanel_submit.SetProperty("CancelButtonCaption", Dvelop_confirmpanel_submit_Cancelbuttoncaption);
            ucDvelop_confirmpanel_submit.SetProperty("YesButtonPosition", Dvelop_confirmpanel_submit_Yesbuttonposition);
            ucDvelop_confirmpanel_submit.SetProperty("ConfirmType", Dvelop_confirmpanel_submit_Confirmtype);
            ucDvelop_confirmpanel_submit.Render(context, "dvelop.gxbootstrap.confirmpanel", Dvelop_confirmpanel_submit_Internalname, "DVELOP_CONFIRMPANEL_SUBMITContainer");
            context.WriteHtmlText( "<div class=\"gx_usercontrol_child\" id=\""+"DVELOP_CONFIRMPANEL_SUBMITContainer"+"Body"+"\" style=\"display:none;\">") ;
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table3_186_1X2e( true) ;
         }
         else
         {
            wb_table3_186_1X2e( false) ;
         }
      }

      protected void wb_table2_181_1X2( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "";
            GxWebStd.gx_table_start( context, tblTabledvelop_confirmpanel_recheck_Internalname, tblTabledvelop_confirmpanel_recheck_Internalname, "", "Table", 0, "", "", 1, 2, sStyleString, "", "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td data-align=\"center\"  style=\""+CSSHelper.Prettify( "text-align:-khtml-center;text-align:-moz-center;text-align:-webkit-center")+"\">") ;
            /* User Defined Control */
            ucDvelop_confirmpanel_recheck.SetProperty("Title", Dvelop_confirmpanel_recheck_Title);
            ucDvelop_confirmpanel_recheck.SetProperty("ConfirmationText", Dvelop_confirmpanel_recheck_Confirmationtext);
            ucDvelop_confirmpanel_recheck.SetProperty("YesButtonCaption", Dvelop_confirmpanel_recheck_Yesbuttoncaption);
            ucDvelop_confirmpanel_recheck.SetProperty("NoButtonCaption", Dvelop_confirmpanel_recheck_Nobuttoncaption);
            ucDvelop_confirmpanel_recheck.SetProperty("CancelButtonCaption", Dvelop_confirmpanel_recheck_Cancelbuttoncaption);
            ucDvelop_confirmpanel_recheck.SetProperty("YesButtonPosition", Dvelop_confirmpanel_recheck_Yesbuttonposition);
            ucDvelop_confirmpanel_recheck.SetProperty("ConfirmType", Dvelop_confirmpanel_recheck_Confirmtype);
            ucDvelop_confirmpanel_recheck.Render(context, "dvelop.gxbootstrap.confirmpanel", Dvelop_confirmpanel_recheck_Internalname, "DVELOP_CONFIRMPANEL_RECHECKContainer");
            context.WriteHtmlText( "<div class=\"gx_usercontrol_child\" id=\""+"DVELOP_CONFIRMPANEL_RECHECKContainer"+"Body"+"\" style=\"display:none;\">") ;
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table2_181_1X2e( true) ;
         }
         else
         {
            wb_table2_181_1X2e( false) ;
         }
      }

      protected void wb_table1_176_1X2( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "";
            GxWebStd.gx_table_start( context, tblTabledvelop_confirmpanel_check_Internalname, tblTabledvelop_confirmpanel_check_Internalname, "", "Table", 0, "", "", 1, 2, sStyleString, "", "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td data-align=\"center\"  style=\""+CSSHelper.Prettify( "text-align:-khtml-center;text-align:-moz-center;text-align:-webkit-center")+"\">") ;
            /* User Defined Control */
            ucDvelop_confirmpanel_check.SetProperty("Title", Dvelop_confirmpanel_check_Title);
            ucDvelop_confirmpanel_check.SetProperty("ConfirmationText", Dvelop_confirmpanel_check_Confirmationtext);
            ucDvelop_confirmpanel_check.SetProperty("YesButtonCaption", Dvelop_confirmpanel_check_Yesbuttoncaption);
            ucDvelop_confirmpanel_check.SetProperty("NoButtonCaption", Dvelop_confirmpanel_check_Nobuttoncaption);
            ucDvelop_confirmpanel_check.SetProperty("CancelButtonCaption", Dvelop_confirmpanel_check_Cancelbuttoncaption);
            ucDvelop_confirmpanel_check.SetProperty("YesButtonPosition", Dvelop_confirmpanel_check_Yesbuttonposition);
            ucDvelop_confirmpanel_check.SetProperty("ConfirmType", Dvelop_confirmpanel_check_Confirmtype);
            ucDvelop_confirmpanel_check.Render(context, "dvelop.gxbootstrap.confirmpanel", Dvelop_confirmpanel_check_Internalname, "DVELOP_CONFIRMPANEL_CHECKContainer");
            context.WriteHtmlText( "<div class=\"gx_usercontrol_child\" id=\""+"DVELOP_CONFIRMPANEL_CHECKContainer"+"Body"+"\" style=\"display:none;\">") ;
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table1_176_1X2e( true) ;
         }
         else
         {
            wb_table1_176_1X2e( false) ;
         }
      }

      public override void setparameters( Object[] obj )
      {
         createObjects();
         initialize();
         AV10BR_EncounterID = Convert.ToInt64(getParm(obj,0));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10BR_EncounterID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10BR_EncounterID), 18, 0)));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vBR_ENCOUNTERID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV10BR_EncounterID), "ZZZZZZZZZZZZZZZZZZ"), context));
         AV8TabCode = (String)getParm(obj,1);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8TabCode", AV8TabCode);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vTABCODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( AV8TabCode, "")), context));
      }

      public override String getresponse( String sGXDynURL )
      {
         initialize_properties( ) ;
         BackMsgLst = context.GX_msglist;
         context.GX_msglist = LclMsgLst;
         sDynURL = sGXDynURL;
         nGotPars = (short)(1);
         nGXWrapped = (short)(1);
         context.SetWrapped(true);
         PA1X2( ) ;
         WS1X2( ) ;
         WE1X2( ) ;
         this.cleanup();
         context.SetWrapped(false);
         context.GX_msglist = BackMsgLst;
         return "";
      }

      public void responsestatic( String sGXDynURL )
      {
      }

      protected void define_styles( )
      {
         AddThemeStyleSheetFile("", context.GetTheme( )+".css", "?"+GetCacheInvalidationToken( ));
         if ( ! ( WebComp_Br_encounterwc == null ) )
         {
            if ( StringUtil.Len( WebComp_Br_encounterwc_Component) != 0 )
            {
               WebComp_Br_encounterwc.componentthemes();
            }
         }
         if ( ! ( WebComp_Br_demographicswc == null ) )
         {
            if ( StringUtil.Len( WebComp_Br_demographicswc_Component) != 0 )
            {
               WebComp_Br_demographicswc.componentthemes();
            }
         }
         if ( ! ( WebComp_Br_behaviorwc == null ) )
         {
            if ( StringUtil.Len( WebComp_Br_behaviorwc_Component) != 0 )
            {
               WebComp_Br_behaviorwc.componentthemes();
            }
         }
         if ( ! ( WebComp_Br_comorbiditywc == null ) )
         {
            if ( StringUtil.Len( WebComp_Br_comorbiditywc_Component) != 0 )
            {
               WebComp_Br_comorbiditywc.componentthemes();
            }
         }
         if ( ! ( WebComp_Br_deathwc == null ) )
         {
            if ( StringUtil.Len( WebComp_Br_deathwc_Component) != 0 )
            {
               WebComp_Br_deathwc.componentthemes();
            }
         }
         if ( ! ( WebComp_Br_vitalwc == null ) )
         {
            if ( StringUtil.Len( WebComp_Br_vitalwc_Component) != 0 )
            {
               WebComp_Br_vitalwc.componentthemes();
            }
         }
         if ( ! ( WebComp_Br_diagnosiswc == null ) )
         {
            if ( StringUtil.Len( WebComp_Br_diagnosiswc_Component) != 0 )
            {
               WebComp_Br_diagnosiswc.componentthemes();
            }
         }
         if ( ! ( WebComp_Br_labwc == null ) )
         {
            if ( StringUtil.Len( WebComp_Br_labwc_Component) != 0 )
            {
               WebComp_Br_labwc.componentthemes();
            }
         }
         if ( ! ( WebComp_Br_medicationwc == null ) )
         {
            if ( StringUtil.Len( WebComp_Br_medicationwc_Component) != 0 )
            {
               WebComp_Br_medicationwc.componentthemes();
            }
         }
         if ( ! ( WebComp_Br_schemewc == null ) )
         {
            if ( StringUtil.Len( WebComp_Br_schemewc_Component) != 0 )
            {
               WebComp_Br_schemewc.componentthemes();
            }
         }
         if ( ! ( WebComp_Br_procedurewc == null ) )
         {
            if ( StringUtil.Len( WebComp_Br_procedurewc_Component) != 0 )
            {
               WebComp_Br_procedurewc.componentthemes();
            }
         }
         if ( ! ( WebComp_Br_medicalimagingwc == null ) )
         {
            if ( StringUtil.Len( WebComp_Br_medicalimagingwc_Component) != 0 )
            {
               WebComp_Br_medicalimagingwc.componentthemes();
            }
         }
         if ( ! ( WebComp_Br_pathologywc == null ) )
         {
            if ( StringUtil.Len( WebComp_Br_pathologywc_Component) != 0 )
            {
               WebComp_Br_pathologywc.componentthemes();
            }
         }
         bool outputEnabled = isOutputEnabled( ) ;
         if ( context.isSpaRequest( ) )
         {
            enableOutput();
         }
         idxLst = 1;
         while ( idxLst <= Form.Jscriptsrc.Count )
         {
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?20202279394555", true);
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
         context.AddJavascriptSource("br_encounterupdate.js", "?20202279394555", false);
         context.AddJavascriptSource("Shared/HistoryManager/HistoryManager.js", "", false);
         context.AddJavascriptSource("Shared/HistoryManager/rsh/json2005.js", "", false);
         context.AddJavascriptSource("Shared/HistoryManager/rsh/rsh.js", "", false);
         context.AddJavascriptSource("Shared/HistoryManager/HistoryManagerCreate.js", "", false);
         context.AddJavascriptSource("Tab/TabRender.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/Shared/DVelopBootstrap.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/ConfirmPanel/BootstrapConfirmPanelRender.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/Shared/DVelopBootstrap.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/ConfirmPanel/BootstrapConfirmPanelRender.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/Shared/DVelopBootstrap.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/ConfirmPanel/BootstrapConfirmPanelRender.js", "", false);
         /* End function include_jscripts */
      }

      protected void init_web_controls( )
      {
         /* End function init_web_controls */
      }

      protected void init_default_properties( )
      {
         bttBtncheck_Internalname = "BTNCHECK";
         bttBtnrecheck_Internalname = "BTNRECHECK";
         bttBtnsubmit_Internalname = "BTNSUBMIT";
         bttBtnreturn_Internalname = "BTNRETURN";
         lblTxttabtitle_Internalname = "TXTTABTITLE";
         lblBr_encounter_title_Internalname = "BR_ENCOUNTER_TITLE";
         divUnnamedtablebr_encounter_Internalname = "UNNAMEDTABLEBR_ENCOUNTER";
         lblBr_demographics_title_Internalname = "BR_DEMOGRAPHICS_TITLE";
         divUnnamedtablebr_demographics_Internalname = "UNNAMEDTABLEBR_DEMOGRAPHICS";
         lblBr_behavior_title_Internalname = "BR_BEHAVIOR_TITLE";
         divUnnamedtablebr_behavior_Internalname = "UNNAMEDTABLEBR_BEHAVIOR";
         lblBr_comorbidity_title_Internalname = "BR_COMORBIDITY_TITLE";
         divUnnamedtablebr_comorbidity_Internalname = "UNNAMEDTABLEBR_COMORBIDITY";
         lblBr_death_title_Internalname = "BR_DEATH_TITLE";
         divUnnamedtablebr_death_Internalname = "UNNAMEDTABLEBR_DEATH";
         lblBr_vital_title_Internalname = "BR_VITAL_TITLE";
         divUnnamedtablebr_vital_Internalname = "UNNAMEDTABLEBR_VITAL";
         lblBr_diagnosis_title_Internalname = "BR_DIAGNOSIS_TITLE";
         divUnnamedtablebr_diagnosis_Internalname = "UNNAMEDTABLEBR_DIAGNOSIS";
         lblBr_lab_title_Internalname = "BR_LAB_TITLE";
         divUnnamedtablebr_lab_Internalname = "UNNAMEDTABLEBR_LAB";
         lblBr_medication_title_Internalname = "BR_MEDICATION_TITLE";
         divUnnamedtablebr_medication_Internalname = "UNNAMEDTABLEBR_MEDICATION";
         lblBr_scheme_title_Internalname = "BR_SCHEME_TITLE";
         divUnnamedtablebr_scheme_Internalname = "UNNAMEDTABLEBR_SCHEME";
         lblBr_procedure_title_Internalname = "BR_PROCEDURE_TITLE";
         divUnnamedtablebr_procedure_Internalname = "UNNAMEDTABLEBR_PROCEDURE";
         lblBr_medicalimaging_title_Internalname = "BR_MEDICALIMAGING_TITLE";
         divUnnamedtablebr_medicalimaging_Internalname = "UNNAMEDTABLEBR_MEDICALIMAGING";
         lblBr_pathology_title_Internalname = "BR_PATHOLOGY_TITLE";
         divUnnamedtablebr_pathology_Internalname = "UNNAMEDTABLEBR_PATHOLOGY";
         Tabs_Internalname = "TABS";
         bttBtnbr_encounter_Internalname = "BTNBR_ENCOUNTER";
         divCell_br_encounter_Internalname = "CELL_BR_ENCOUNTER";
         bttBtnbr_demographics_Internalname = "BTNBR_DEMOGRAPHICS";
         divCell_br_demographics_Internalname = "CELL_BR_DEMOGRAPHICS";
         bttBtnbr_behavior_Internalname = "BTNBR_BEHAVIOR";
         divCell_br_behavior_Internalname = "CELL_BR_BEHAVIOR";
         bttBtnbr_comorbidity_Internalname = "BTNBR_COMORBIDITY";
         divCell_br_comorbidity_Internalname = "CELL_BR_COMORBIDITY";
         bttBtnbr_death_Internalname = "BTNBR_DEATH";
         divCell_br_death_Internalname = "CELL_BR_DEATH";
         bttBtnbr_vital_Internalname = "BTNBR_VITAL";
         divCell_br_vital_Internalname = "CELL_BR_VITAL";
         bttBtnbr_diagnosis_Internalname = "BTNBR_DIAGNOSIS";
         divCell_br_diagnosis_Internalname = "CELL_BR_DIAGNOSIS";
         bttBtnbr_lab_Internalname = "BTNBR_LAB";
         divCell_br_lab_Internalname = "CELL_BR_LAB";
         bttBtnbr_medication_Internalname = "BTNBR_MEDICATION";
         divCell_br_medication_Internalname = "CELL_BR_MEDICATION";
         bttBtnbr_scheme_Internalname = "BTNBR_SCHEME";
         divCell_br_scheme_Internalname = "CELL_BR_SCHEME";
         bttBtnbr_procedure_Internalname = "BTNBR_PROCEDURE";
         divCell_br_procedure_Internalname = "CELL_BR_PROCEDURE";
         bttBtnbr_medicalimaging_Internalname = "BTNBR_MEDICALIMAGING";
         divCell_br_medicalimaging_Internalname = "CELL_BR_MEDICALIMAGING";
         bttBtnbr_pathology_Internalname = "BTNBR_PATHOLOGY";
         divCell_br_pathology_Internalname = "CELL_BR_PATHOLOGY";
         divUnnamedtabletabscontainer_Internalname = "UNNAMEDTABLETABSCONTAINER";
         divUnnamedtableviewcontainer_Internalname = "UNNAMEDTABLEVIEWCONTAINER";
         divTablemain_Internalname = "TABLEMAIN";
         Dvelop_confirmpanel_check_Internalname = "DVELOP_CONFIRMPANEL_CHECK";
         tblTabledvelop_confirmpanel_check_Internalname = "TABLEDVELOP_CONFIRMPANEL_CHECK";
         Dvelop_confirmpanel_recheck_Internalname = "DVELOP_CONFIRMPANEL_RECHECK";
         tblTabledvelop_confirmpanel_recheck_Internalname = "TABLEDVELOP_CONFIRMPANEL_RECHECK";
         Dvelop_confirmpanel_submit_Internalname = "DVELOP_CONFIRMPANEL_SUBMIT";
         tblTabledvelop_confirmpanel_submit_Internalname = "TABLEDVELOP_CONFIRMPANEL_SUBMIT";
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
         divCell_br_pathology_Visible = 1;
         divCell_br_medicalimaging_Visible = 1;
         divCell_br_procedure_Visible = 1;
         divCell_br_scheme_Visible = 1;
         divCell_br_medication_Visible = 1;
         divCell_br_lab_Visible = 1;
         divCell_br_diagnosis_Visible = 1;
         divCell_br_vital_Visible = 1;
         divCell_br_death_Visible = 1;
         divCell_br_comorbidity_Visible = 1;
         divCell_br_behavior_Visible = 1;
         divCell_br_demographics_Visible = 1;
         divCell_br_encounter_Visible = 1;
         lblTxttabtitle_Caption = "Title";
         bttBtnsubmit_Visible = 1;
         bttBtnrecheck_Visible = 1;
         bttBtncheck_Visible = 1;
         Dvelop_confirmpanel_submit_Confirmtype = "1";
         Dvelop_confirmpanel_submit_Yesbuttonposition = "left";
         Dvelop_confirmpanel_submit_Cancelbuttoncaption = "WWP_ConfirmTextCancel";
         Dvelop_confirmpanel_submit_Nobuttoncaption = "WWP_ConfirmTextNo";
         Dvelop_confirmpanel_submit_Yesbuttoncaption = "WWP_ConfirmTextYes";
         Dvelop_confirmpanel_submit_Confirmationtext = "确认提交？";
         Dvelop_confirmpanel_submit_Title = "";
         Dvelop_confirmpanel_recheck_Confirmtype = "1";
         Dvelop_confirmpanel_recheck_Yesbuttonposition = "left";
         Dvelop_confirmpanel_recheck_Cancelbuttoncaption = "WWP_ConfirmTextCancel";
         Dvelop_confirmpanel_recheck_Nobuttoncaption = "WWP_ConfirmTextNo";
         Dvelop_confirmpanel_recheck_Yesbuttoncaption = "WWP_ConfirmTextYes";
         Dvelop_confirmpanel_recheck_Confirmationtext = "确认提交？";
         Dvelop_confirmpanel_recheck_Title = "";
         Dvelop_confirmpanel_check_Confirmtype = "1";
         Dvelop_confirmpanel_check_Yesbuttonposition = "left";
         Dvelop_confirmpanel_check_Cancelbuttoncaption = "WWP_ConfirmTextCancel";
         Dvelop_confirmpanel_check_Nobuttoncaption = "WWP_ConfirmTextNo";
         Dvelop_confirmpanel_check_Yesbuttoncaption = "WWP_ConfirmTextYes";
         Dvelop_confirmpanel_check_Confirmationtext = "确认提交？";
         Dvelop_confirmpanel_check_Title = "";
         Tabs_Historymanagement = Convert.ToBoolean( -1);
         Tabs_Pagecount = 13;
         Tabs_Class = "ViewTab Tab";
         Form.Headerrawhtml = "";
         Form.Background = "";
         Form.Textcolor = 0;
         Form.Backcolor = (int)(0xFFFFFF);
         Form.Caption = "Data Mgmt Portal - RAAP";
         if ( context.isSpaRequest( ) )
         {
            enableJsOutput();
         }
      }

      public override bool SupportAjaxEvent( )
      {
         return true ;
      }

      public override void InitializeDynEvents( )
      {
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[{av:'AV10BR_EncounterID',fld:'vBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true},{av:'AV8TabCode',fld:'vTABCODE',pic:'',hsh:true},{av:'AV18tPageReturn',fld:'vTPAGERETURN',pic:'',hsh:true}]");
         setEventMetadata("REFRESH",",oparms:[{ctrl:'BTNCHECK',prop:'Visible'},{ctrl:'BTNSUBMIT',prop:'Visible'}]}");
         setEventMetadata("'DOCHECK'","{handler:'E111X1',iparms:[]");
         setEventMetadata("'DOCHECK'",",oparms:[]}");
         setEventMetadata("DVELOP_CONFIRMPANEL_CHECK.CLOSE","{handler:'E151X2',iparms:[{av:'Dvelop_confirmpanel_check_Result',ctrl:'DVELOP_CONFIRMPANEL_CHECK',prop:'Result'},{av:'AV10BR_EncounterID',fld:'vBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true},{av:'AV6WWPContext',fld:'vWWPCONTEXT',pic:''},{av:'AV18tPageReturn',fld:'vTPAGERETURN',pic:'',hsh:true}]");
         setEventMetadata("DVELOP_CONFIRMPANEL_CHECK.CLOSE",",oparms:[{av:'AV16BCBR_Encounter',fld:'vBCBR_ENCOUNTER',pic:''}]}");
         setEventMetadata("'DORECHECK'","{handler:'E121X1',iparms:[]");
         setEventMetadata("'DORECHECK'",",oparms:[]}");
         setEventMetadata("DVELOP_CONFIRMPANEL_RECHECK.CLOSE","{handler:'E161X2',iparms:[{av:'Dvelop_confirmpanel_recheck_Result',ctrl:'DVELOP_CONFIRMPANEL_RECHECK',prop:'Result'},{av:'AV10BR_EncounterID',fld:'vBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true},{av:'AV6WWPContext',fld:'vWWPCONTEXT',pic:''},{av:'AV18tPageReturn',fld:'vTPAGERETURN',pic:'',hsh:true}]");
         setEventMetadata("DVELOP_CONFIRMPANEL_RECHECK.CLOSE",",oparms:[{av:'AV16BCBR_Encounter',fld:'vBCBR_ENCOUNTER',pic:''}]}");
         setEventMetadata("'DOSUBMIT'","{handler:'E131X1',iparms:[]");
         setEventMetadata("'DOSUBMIT'",",oparms:[]}");
         setEventMetadata("DVELOP_CONFIRMPANEL_SUBMIT.CLOSE","{handler:'E171X2',iparms:[{av:'Dvelop_confirmpanel_submit_Result',ctrl:'DVELOP_CONFIRMPANEL_SUBMIT',prop:'Result'},{av:'AV10BR_EncounterID',fld:'vBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true},{av:'AV6WWPContext',fld:'vWWPCONTEXT',pic:''},{av:'AV18tPageReturn',fld:'vTPAGERETURN',pic:'',hsh:true}]");
         setEventMetadata("DVELOP_CONFIRMPANEL_SUBMIT.CLOSE",",oparms:[{av:'AV16BCBR_Encounter',fld:'vBCBR_ENCOUNTER',pic:''}]}");
         setEventMetadata("'DORETURN'","{handler:'E211X2',iparms:[{av:'AV18tPageReturn',fld:'vTPAGERETURN',pic:'',hsh:true},{av:'AV16BCBR_Encounter',fld:'vBCBR_ENCOUNTER',pic:''}]");
         setEventMetadata("'DORETURN'",",oparms:[]}");
         setEventMetadata("TABS.TABCHANGED","{handler:'E141X2',iparms:[{av:'Tabs_Activepagecontrolname',ctrl:'TABS',prop:'ActivePageControlName'},{av:'A19BR_EncounterID',fld:'BR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV10BR_EncounterID',fld:'vBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true},{av:'AV11LoadAllTabs',fld:'vLOADALLTABS',pic:''},{av:'AV12SelectedTabCode',fld:'vSELECTEDTABCODE',pic:''}]");
         setEventMetadata("TABS.TABCHANGED",",oparms:[{av:'AV12SelectedTabCode',fld:'vSELECTEDTABCODE',pic:''},{av:'AV11LoadAllTabs',fld:'vLOADALLTABS',pic:''},{av:'divCell_br_encounter_Visible',ctrl:'CELL_BR_ENCOUNTER',prop:'Visible'},{ctrl:'BR_ENCOUNTERWC'},{av:'lblTxttabtitle_Caption',ctrl:'TXTTABTITLE',prop:'Caption'},{av:'divCell_br_demographics_Visible',ctrl:'CELL_BR_DEMOGRAPHICS',prop:'Visible'},{ctrl:'BR_DEMOGRAPHICSWC'},{av:'divCell_br_behavior_Visible',ctrl:'CELL_BR_BEHAVIOR',prop:'Visible'},{ctrl:'BR_BEHAVIORWC'},{av:'divCell_br_comorbidity_Visible',ctrl:'CELL_BR_COMORBIDITY',prop:'Visible'},{ctrl:'BR_COMORBIDITYWC'},{av:'divCell_br_death_Visible',ctrl:'CELL_BR_DEATH',prop:'Visible'},{ctrl:'BR_DEATHWC'},{av:'divCell_br_vital_Visible',ctrl:'CELL_BR_VITAL',prop:'Visible'},{ctrl:'BR_VITALWC'},{av:'divCell_br_diagnosis_Visible',ctrl:'CELL_BR_DIAGNOSIS',prop:'Visible'},{ctrl:'BR_DIAGNOSISWC'},{av:'divCell_br_lab_Visible',ctrl:'CELL_BR_LAB',prop:'Visible'},{ctrl:'BR_LABWC'},{av:'divCell_br_medication_Visible',ctrl:'CELL_BR_MEDICATION',prop:'Visible'},{ctrl:'BR_MEDICATIONWC'},{av:'divCell_br_scheme_Visible',ctrl:'CELL_BR_SCHEME',prop:'Visible'},{ctrl:'BR_SCHEMEWC'},{av:'divCell_br_procedure_Visible',ctrl:'CELL_BR_PROCEDURE',prop:'Visible'},{ctrl:'BR_PROCEDUREWC'},{av:'divCell_br_medicalimaging_Visible',ctrl:'CELL_BR_MEDICALIMAGING',prop:'Visible'},{ctrl:'BR_MEDICALIMAGINGWC'},{av:'divCell_br_pathology_Visible',ctrl:'CELL_BR_PATHOLOGY',prop:'Visible'},{ctrl:'BR_PATHOLOGYWC'}]}");
         setEventMetadata("'BR_ENCOUNTER'","{handler:'E221X2',iparms:[{av:'A19BR_EncounterID',fld:'BR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV10BR_EncounterID',fld:'vBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true},{av:'AV11LoadAllTabs',fld:'vLOADALLTABS',pic:''},{av:'AV12SelectedTabCode',fld:'vSELECTEDTABCODE',pic:''}]");
         setEventMetadata("'BR_ENCOUNTER'",",oparms:[{av:'AV12SelectedTabCode',fld:'vSELECTEDTABCODE',pic:''},{av:'AV11LoadAllTabs',fld:'vLOADALLTABS',pic:''},{av:'divCell_br_encounter_Visible',ctrl:'CELL_BR_ENCOUNTER',prop:'Visible'},{ctrl:'BR_ENCOUNTERWC'},{av:'lblTxttabtitle_Caption',ctrl:'TXTTABTITLE',prop:'Caption'},{av:'divCell_br_demographics_Visible',ctrl:'CELL_BR_DEMOGRAPHICS',prop:'Visible'},{ctrl:'BR_DEMOGRAPHICSWC'},{av:'divCell_br_behavior_Visible',ctrl:'CELL_BR_BEHAVIOR',prop:'Visible'},{ctrl:'BR_BEHAVIORWC'},{av:'divCell_br_comorbidity_Visible',ctrl:'CELL_BR_COMORBIDITY',prop:'Visible'},{ctrl:'BR_COMORBIDITYWC'},{av:'divCell_br_death_Visible',ctrl:'CELL_BR_DEATH',prop:'Visible'},{ctrl:'BR_DEATHWC'},{av:'divCell_br_vital_Visible',ctrl:'CELL_BR_VITAL',prop:'Visible'},{ctrl:'BR_VITALWC'},{av:'divCell_br_diagnosis_Visible',ctrl:'CELL_BR_DIAGNOSIS',prop:'Visible'},{ctrl:'BR_DIAGNOSISWC'},{av:'divCell_br_lab_Visible',ctrl:'CELL_BR_LAB',prop:'Visible'},{ctrl:'BR_LABWC'},{av:'divCell_br_medication_Visible',ctrl:'CELL_BR_MEDICATION',prop:'Visible'},{ctrl:'BR_MEDICATIONWC'},{av:'divCell_br_scheme_Visible',ctrl:'CELL_BR_SCHEME',prop:'Visible'},{ctrl:'BR_SCHEMEWC'},{av:'divCell_br_procedure_Visible',ctrl:'CELL_BR_PROCEDURE',prop:'Visible'},{ctrl:'BR_PROCEDUREWC'},{av:'divCell_br_medicalimaging_Visible',ctrl:'CELL_BR_MEDICALIMAGING',prop:'Visible'},{ctrl:'BR_MEDICALIMAGINGWC'},{av:'divCell_br_pathology_Visible',ctrl:'CELL_BR_PATHOLOGY',prop:'Visible'},{ctrl:'BR_PATHOLOGYWC'}]}");
         setEventMetadata("'BR_DEMOGRAPHICS'","{handler:'E231X2',iparms:[{av:'A19BR_EncounterID',fld:'BR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV10BR_EncounterID',fld:'vBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true},{av:'AV11LoadAllTabs',fld:'vLOADALLTABS',pic:''},{av:'AV12SelectedTabCode',fld:'vSELECTEDTABCODE',pic:''}]");
         setEventMetadata("'BR_DEMOGRAPHICS'",",oparms:[{av:'AV12SelectedTabCode',fld:'vSELECTEDTABCODE',pic:''},{av:'AV11LoadAllTabs',fld:'vLOADALLTABS',pic:''},{av:'divCell_br_encounter_Visible',ctrl:'CELL_BR_ENCOUNTER',prop:'Visible'},{ctrl:'BR_ENCOUNTERWC'},{av:'lblTxttabtitle_Caption',ctrl:'TXTTABTITLE',prop:'Caption'},{av:'divCell_br_demographics_Visible',ctrl:'CELL_BR_DEMOGRAPHICS',prop:'Visible'},{ctrl:'BR_DEMOGRAPHICSWC'},{av:'divCell_br_behavior_Visible',ctrl:'CELL_BR_BEHAVIOR',prop:'Visible'},{ctrl:'BR_BEHAVIORWC'},{av:'divCell_br_comorbidity_Visible',ctrl:'CELL_BR_COMORBIDITY',prop:'Visible'},{ctrl:'BR_COMORBIDITYWC'},{av:'divCell_br_death_Visible',ctrl:'CELL_BR_DEATH',prop:'Visible'},{ctrl:'BR_DEATHWC'},{av:'divCell_br_vital_Visible',ctrl:'CELL_BR_VITAL',prop:'Visible'},{ctrl:'BR_VITALWC'},{av:'divCell_br_diagnosis_Visible',ctrl:'CELL_BR_DIAGNOSIS',prop:'Visible'},{ctrl:'BR_DIAGNOSISWC'},{av:'divCell_br_lab_Visible',ctrl:'CELL_BR_LAB',prop:'Visible'},{ctrl:'BR_LABWC'},{av:'divCell_br_medication_Visible',ctrl:'CELL_BR_MEDICATION',prop:'Visible'},{ctrl:'BR_MEDICATIONWC'},{av:'divCell_br_scheme_Visible',ctrl:'CELL_BR_SCHEME',prop:'Visible'},{ctrl:'BR_SCHEMEWC'},{av:'divCell_br_procedure_Visible',ctrl:'CELL_BR_PROCEDURE',prop:'Visible'},{ctrl:'BR_PROCEDUREWC'},{av:'divCell_br_medicalimaging_Visible',ctrl:'CELL_BR_MEDICALIMAGING',prop:'Visible'},{ctrl:'BR_MEDICALIMAGINGWC'},{av:'divCell_br_pathology_Visible',ctrl:'CELL_BR_PATHOLOGY',prop:'Visible'},{ctrl:'BR_PATHOLOGYWC'}]}");
         setEventMetadata("'BR_BEHAVIOR'","{handler:'E241X2',iparms:[{av:'A19BR_EncounterID',fld:'BR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV10BR_EncounterID',fld:'vBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true},{av:'AV11LoadAllTabs',fld:'vLOADALLTABS',pic:''},{av:'AV12SelectedTabCode',fld:'vSELECTEDTABCODE',pic:''}]");
         setEventMetadata("'BR_BEHAVIOR'",",oparms:[{av:'AV12SelectedTabCode',fld:'vSELECTEDTABCODE',pic:''},{av:'AV11LoadAllTabs',fld:'vLOADALLTABS',pic:''},{av:'divCell_br_encounter_Visible',ctrl:'CELL_BR_ENCOUNTER',prop:'Visible'},{ctrl:'BR_ENCOUNTERWC'},{av:'lblTxttabtitle_Caption',ctrl:'TXTTABTITLE',prop:'Caption'},{av:'divCell_br_demographics_Visible',ctrl:'CELL_BR_DEMOGRAPHICS',prop:'Visible'},{ctrl:'BR_DEMOGRAPHICSWC'},{av:'divCell_br_behavior_Visible',ctrl:'CELL_BR_BEHAVIOR',prop:'Visible'},{ctrl:'BR_BEHAVIORWC'},{av:'divCell_br_comorbidity_Visible',ctrl:'CELL_BR_COMORBIDITY',prop:'Visible'},{ctrl:'BR_COMORBIDITYWC'},{av:'divCell_br_death_Visible',ctrl:'CELL_BR_DEATH',prop:'Visible'},{ctrl:'BR_DEATHWC'},{av:'divCell_br_vital_Visible',ctrl:'CELL_BR_VITAL',prop:'Visible'},{ctrl:'BR_VITALWC'},{av:'divCell_br_diagnosis_Visible',ctrl:'CELL_BR_DIAGNOSIS',prop:'Visible'},{ctrl:'BR_DIAGNOSISWC'},{av:'divCell_br_lab_Visible',ctrl:'CELL_BR_LAB',prop:'Visible'},{ctrl:'BR_LABWC'},{av:'divCell_br_medication_Visible',ctrl:'CELL_BR_MEDICATION',prop:'Visible'},{ctrl:'BR_MEDICATIONWC'},{av:'divCell_br_scheme_Visible',ctrl:'CELL_BR_SCHEME',prop:'Visible'},{ctrl:'BR_SCHEMEWC'},{av:'divCell_br_procedure_Visible',ctrl:'CELL_BR_PROCEDURE',prop:'Visible'},{ctrl:'BR_PROCEDUREWC'},{av:'divCell_br_medicalimaging_Visible',ctrl:'CELL_BR_MEDICALIMAGING',prop:'Visible'},{ctrl:'BR_MEDICALIMAGINGWC'},{av:'divCell_br_pathology_Visible',ctrl:'CELL_BR_PATHOLOGY',prop:'Visible'},{ctrl:'BR_PATHOLOGYWC'}]}");
         setEventMetadata("'BR_COMORBIDITY'","{handler:'E251X2',iparms:[{av:'A19BR_EncounterID',fld:'BR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV10BR_EncounterID',fld:'vBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true},{av:'AV11LoadAllTabs',fld:'vLOADALLTABS',pic:''},{av:'AV12SelectedTabCode',fld:'vSELECTEDTABCODE',pic:''}]");
         setEventMetadata("'BR_COMORBIDITY'",",oparms:[{av:'AV12SelectedTabCode',fld:'vSELECTEDTABCODE',pic:''},{av:'AV11LoadAllTabs',fld:'vLOADALLTABS',pic:''},{av:'divCell_br_encounter_Visible',ctrl:'CELL_BR_ENCOUNTER',prop:'Visible'},{ctrl:'BR_ENCOUNTERWC'},{av:'lblTxttabtitle_Caption',ctrl:'TXTTABTITLE',prop:'Caption'},{av:'divCell_br_demographics_Visible',ctrl:'CELL_BR_DEMOGRAPHICS',prop:'Visible'},{ctrl:'BR_DEMOGRAPHICSWC'},{av:'divCell_br_behavior_Visible',ctrl:'CELL_BR_BEHAVIOR',prop:'Visible'},{ctrl:'BR_BEHAVIORWC'},{av:'divCell_br_comorbidity_Visible',ctrl:'CELL_BR_COMORBIDITY',prop:'Visible'},{ctrl:'BR_COMORBIDITYWC'},{av:'divCell_br_death_Visible',ctrl:'CELL_BR_DEATH',prop:'Visible'},{ctrl:'BR_DEATHWC'},{av:'divCell_br_vital_Visible',ctrl:'CELL_BR_VITAL',prop:'Visible'},{ctrl:'BR_VITALWC'},{av:'divCell_br_diagnosis_Visible',ctrl:'CELL_BR_DIAGNOSIS',prop:'Visible'},{ctrl:'BR_DIAGNOSISWC'},{av:'divCell_br_lab_Visible',ctrl:'CELL_BR_LAB',prop:'Visible'},{ctrl:'BR_LABWC'},{av:'divCell_br_medication_Visible',ctrl:'CELL_BR_MEDICATION',prop:'Visible'},{ctrl:'BR_MEDICATIONWC'},{av:'divCell_br_scheme_Visible',ctrl:'CELL_BR_SCHEME',prop:'Visible'},{ctrl:'BR_SCHEMEWC'},{av:'divCell_br_procedure_Visible',ctrl:'CELL_BR_PROCEDURE',prop:'Visible'},{ctrl:'BR_PROCEDUREWC'},{av:'divCell_br_medicalimaging_Visible',ctrl:'CELL_BR_MEDICALIMAGING',prop:'Visible'},{ctrl:'BR_MEDICALIMAGINGWC'},{av:'divCell_br_pathology_Visible',ctrl:'CELL_BR_PATHOLOGY',prop:'Visible'},{ctrl:'BR_PATHOLOGYWC'}]}");
         setEventMetadata("'BR_DEATH'","{handler:'E261X2',iparms:[{av:'A19BR_EncounterID',fld:'BR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV10BR_EncounterID',fld:'vBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true},{av:'AV11LoadAllTabs',fld:'vLOADALLTABS',pic:''},{av:'AV12SelectedTabCode',fld:'vSELECTEDTABCODE',pic:''}]");
         setEventMetadata("'BR_DEATH'",",oparms:[{av:'AV12SelectedTabCode',fld:'vSELECTEDTABCODE',pic:''},{av:'AV11LoadAllTabs',fld:'vLOADALLTABS',pic:''},{av:'divCell_br_encounter_Visible',ctrl:'CELL_BR_ENCOUNTER',prop:'Visible'},{ctrl:'BR_ENCOUNTERWC'},{av:'lblTxttabtitle_Caption',ctrl:'TXTTABTITLE',prop:'Caption'},{av:'divCell_br_demographics_Visible',ctrl:'CELL_BR_DEMOGRAPHICS',prop:'Visible'},{ctrl:'BR_DEMOGRAPHICSWC'},{av:'divCell_br_behavior_Visible',ctrl:'CELL_BR_BEHAVIOR',prop:'Visible'},{ctrl:'BR_BEHAVIORWC'},{av:'divCell_br_comorbidity_Visible',ctrl:'CELL_BR_COMORBIDITY',prop:'Visible'},{ctrl:'BR_COMORBIDITYWC'},{av:'divCell_br_death_Visible',ctrl:'CELL_BR_DEATH',prop:'Visible'},{ctrl:'BR_DEATHWC'},{av:'divCell_br_vital_Visible',ctrl:'CELL_BR_VITAL',prop:'Visible'},{ctrl:'BR_VITALWC'},{av:'divCell_br_diagnosis_Visible',ctrl:'CELL_BR_DIAGNOSIS',prop:'Visible'},{ctrl:'BR_DIAGNOSISWC'},{av:'divCell_br_lab_Visible',ctrl:'CELL_BR_LAB',prop:'Visible'},{ctrl:'BR_LABWC'},{av:'divCell_br_medication_Visible',ctrl:'CELL_BR_MEDICATION',prop:'Visible'},{ctrl:'BR_MEDICATIONWC'},{av:'divCell_br_scheme_Visible',ctrl:'CELL_BR_SCHEME',prop:'Visible'},{ctrl:'BR_SCHEMEWC'},{av:'divCell_br_procedure_Visible',ctrl:'CELL_BR_PROCEDURE',prop:'Visible'},{ctrl:'BR_PROCEDUREWC'},{av:'divCell_br_medicalimaging_Visible',ctrl:'CELL_BR_MEDICALIMAGING',prop:'Visible'},{ctrl:'BR_MEDICALIMAGINGWC'},{av:'divCell_br_pathology_Visible',ctrl:'CELL_BR_PATHOLOGY',prop:'Visible'},{ctrl:'BR_PATHOLOGYWC'}]}");
         setEventMetadata("'BR_VITAL'","{handler:'E271X2',iparms:[{av:'A19BR_EncounterID',fld:'BR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV10BR_EncounterID',fld:'vBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true},{av:'AV11LoadAllTabs',fld:'vLOADALLTABS',pic:''},{av:'AV12SelectedTabCode',fld:'vSELECTEDTABCODE',pic:''}]");
         setEventMetadata("'BR_VITAL'",",oparms:[{av:'AV12SelectedTabCode',fld:'vSELECTEDTABCODE',pic:''},{av:'AV11LoadAllTabs',fld:'vLOADALLTABS',pic:''},{av:'divCell_br_encounter_Visible',ctrl:'CELL_BR_ENCOUNTER',prop:'Visible'},{ctrl:'BR_ENCOUNTERWC'},{av:'lblTxttabtitle_Caption',ctrl:'TXTTABTITLE',prop:'Caption'},{av:'divCell_br_demographics_Visible',ctrl:'CELL_BR_DEMOGRAPHICS',prop:'Visible'},{ctrl:'BR_DEMOGRAPHICSWC'},{av:'divCell_br_behavior_Visible',ctrl:'CELL_BR_BEHAVIOR',prop:'Visible'},{ctrl:'BR_BEHAVIORWC'},{av:'divCell_br_comorbidity_Visible',ctrl:'CELL_BR_COMORBIDITY',prop:'Visible'},{ctrl:'BR_COMORBIDITYWC'},{av:'divCell_br_death_Visible',ctrl:'CELL_BR_DEATH',prop:'Visible'},{ctrl:'BR_DEATHWC'},{av:'divCell_br_vital_Visible',ctrl:'CELL_BR_VITAL',prop:'Visible'},{ctrl:'BR_VITALWC'},{av:'divCell_br_diagnosis_Visible',ctrl:'CELL_BR_DIAGNOSIS',prop:'Visible'},{ctrl:'BR_DIAGNOSISWC'},{av:'divCell_br_lab_Visible',ctrl:'CELL_BR_LAB',prop:'Visible'},{ctrl:'BR_LABWC'},{av:'divCell_br_medication_Visible',ctrl:'CELL_BR_MEDICATION',prop:'Visible'},{ctrl:'BR_MEDICATIONWC'},{av:'divCell_br_scheme_Visible',ctrl:'CELL_BR_SCHEME',prop:'Visible'},{ctrl:'BR_SCHEMEWC'},{av:'divCell_br_procedure_Visible',ctrl:'CELL_BR_PROCEDURE',prop:'Visible'},{ctrl:'BR_PROCEDUREWC'},{av:'divCell_br_medicalimaging_Visible',ctrl:'CELL_BR_MEDICALIMAGING',prop:'Visible'},{ctrl:'BR_MEDICALIMAGINGWC'},{av:'divCell_br_pathology_Visible',ctrl:'CELL_BR_PATHOLOGY',prop:'Visible'},{ctrl:'BR_PATHOLOGYWC'}]}");
         setEventMetadata("'BR_DIAGNOSIS'","{handler:'E281X2',iparms:[{av:'A19BR_EncounterID',fld:'BR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV10BR_EncounterID',fld:'vBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true},{av:'AV11LoadAllTabs',fld:'vLOADALLTABS',pic:''},{av:'AV12SelectedTabCode',fld:'vSELECTEDTABCODE',pic:''}]");
         setEventMetadata("'BR_DIAGNOSIS'",",oparms:[{av:'AV12SelectedTabCode',fld:'vSELECTEDTABCODE',pic:''},{av:'AV11LoadAllTabs',fld:'vLOADALLTABS',pic:''},{av:'divCell_br_encounter_Visible',ctrl:'CELL_BR_ENCOUNTER',prop:'Visible'},{ctrl:'BR_ENCOUNTERWC'},{av:'lblTxttabtitle_Caption',ctrl:'TXTTABTITLE',prop:'Caption'},{av:'divCell_br_demographics_Visible',ctrl:'CELL_BR_DEMOGRAPHICS',prop:'Visible'},{ctrl:'BR_DEMOGRAPHICSWC'},{av:'divCell_br_behavior_Visible',ctrl:'CELL_BR_BEHAVIOR',prop:'Visible'},{ctrl:'BR_BEHAVIORWC'},{av:'divCell_br_comorbidity_Visible',ctrl:'CELL_BR_COMORBIDITY',prop:'Visible'},{ctrl:'BR_COMORBIDITYWC'},{av:'divCell_br_death_Visible',ctrl:'CELL_BR_DEATH',prop:'Visible'},{ctrl:'BR_DEATHWC'},{av:'divCell_br_vital_Visible',ctrl:'CELL_BR_VITAL',prop:'Visible'},{ctrl:'BR_VITALWC'},{av:'divCell_br_diagnosis_Visible',ctrl:'CELL_BR_DIAGNOSIS',prop:'Visible'},{ctrl:'BR_DIAGNOSISWC'},{av:'divCell_br_lab_Visible',ctrl:'CELL_BR_LAB',prop:'Visible'},{ctrl:'BR_LABWC'},{av:'divCell_br_medication_Visible',ctrl:'CELL_BR_MEDICATION',prop:'Visible'},{ctrl:'BR_MEDICATIONWC'},{av:'divCell_br_scheme_Visible',ctrl:'CELL_BR_SCHEME',prop:'Visible'},{ctrl:'BR_SCHEMEWC'},{av:'divCell_br_procedure_Visible',ctrl:'CELL_BR_PROCEDURE',prop:'Visible'},{ctrl:'BR_PROCEDUREWC'},{av:'divCell_br_medicalimaging_Visible',ctrl:'CELL_BR_MEDICALIMAGING',prop:'Visible'},{ctrl:'BR_MEDICALIMAGINGWC'},{av:'divCell_br_pathology_Visible',ctrl:'CELL_BR_PATHOLOGY',prop:'Visible'},{ctrl:'BR_PATHOLOGYWC'}]}");
         setEventMetadata("'BR_LAB'","{handler:'E291X2',iparms:[{av:'A19BR_EncounterID',fld:'BR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV10BR_EncounterID',fld:'vBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true},{av:'AV11LoadAllTabs',fld:'vLOADALLTABS',pic:''},{av:'AV12SelectedTabCode',fld:'vSELECTEDTABCODE',pic:''}]");
         setEventMetadata("'BR_LAB'",",oparms:[{av:'AV12SelectedTabCode',fld:'vSELECTEDTABCODE',pic:''},{av:'AV11LoadAllTabs',fld:'vLOADALLTABS',pic:''},{av:'divCell_br_encounter_Visible',ctrl:'CELL_BR_ENCOUNTER',prop:'Visible'},{ctrl:'BR_ENCOUNTERWC'},{av:'lblTxttabtitle_Caption',ctrl:'TXTTABTITLE',prop:'Caption'},{av:'divCell_br_demographics_Visible',ctrl:'CELL_BR_DEMOGRAPHICS',prop:'Visible'},{ctrl:'BR_DEMOGRAPHICSWC'},{av:'divCell_br_behavior_Visible',ctrl:'CELL_BR_BEHAVIOR',prop:'Visible'},{ctrl:'BR_BEHAVIORWC'},{av:'divCell_br_comorbidity_Visible',ctrl:'CELL_BR_COMORBIDITY',prop:'Visible'},{ctrl:'BR_COMORBIDITYWC'},{av:'divCell_br_death_Visible',ctrl:'CELL_BR_DEATH',prop:'Visible'},{ctrl:'BR_DEATHWC'},{av:'divCell_br_vital_Visible',ctrl:'CELL_BR_VITAL',prop:'Visible'},{ctrl:'BR_VITALWC'},{av:'divCell_br_diagnosis_Visible',ctrl:'CELL_BR_DIAGNOSIS',prop:'Visible'},{ctrl:'BR_DIAGNOSISWC'},{av:'divCell_br_lab_Visible',ctrl:'CELL_BR_LAB',prop:'Visible'},{ctrl:'BR_LABWC'},{av:'divCell_br_medication_Visible',ctrl:'CELL_BR_MEDICATION',prop:'Visible'},{ctrl:'BR_MEDICATIONWC'},{av:'divCell_br_scheme_Visible',ctrl:'CELL_BR_SCHEME',prop:'Visible'},{ctrl:'BR_SCHEMEWC'},{av:'divCell_br_procedure_Visible',ctrl:'CELL_BR_PROCEDURE',prop:'Visible'},{ctrl:'BR_PROCEDUREWC'},{av:'divCell_br_medicalimaging_Visible',ctrl:'CELL_BR_MEDICALIMAGING',prop:'Visible'},{ctrl:'BR_MEDICALIMAGINGWC'},{av:'divCell_br_pathology_Visible',ctrl:'CELL_BR_PATHOLOGY',prop:'Visible'},{ctrl:'BR_PATHOLOGYWC'}]}");
         setEventMetadata("'BR_MEDICATION'","{handler:'E301X2',iparms:[{av:'A19BR_EncounterID',fld:'BR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV10BR_EncounterID',fld:'vBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true},{av:'AV11LoadAllTabs',fld:'vLOADALLTABS',pic:''},{av:'AV12SelectedTabCode',fld:'vSELECTEDTABCODE',pic:''}]");
         setEventMetadata("'BR_MEDICATION'",",oparms:[{av:'AV12SelectedTabCode',fld:'vSELECTEDTABCODE',pic:''},{av:'AV11LoadAllTabs',fld:'vLOADALLTABS',pic:''},{av:'divCell_br_encounter_Visible',ctrl:'CELL_BR_ENCOUNTER',prop:'Visible'},{ctrl:'BR_ENCOUNTERWC'},{av:'lblTxttabtitle_Caption',ctrl:'TXTTABTITLE',prop:'Caption'},{av:'divCell_br_demographics_Visible',ctrl:'CELL_BR_DEMOGRAPHICS',prop:'Visible'},{ctrl:'BR_DEMOGRAPHICSWC'},{av:'divCell_br_behavior_Visible',ctrl:'CELL_BR_BEHAVIOR',prop:'Visible'},{ctrl:'BR_BEHAVIORWC'},{av:'divCell_br_comorbidity_Visible',ctrl:'CELL_BR_COMORBIDITY',prop:'Visible'},{ctrl:'BR_COMORBIDITYWC'},{av:'divCell_br_death_Visible',ctrl:'CELL_BR_DEATH',prop:'Visible'},{ctrl:'BR_DEATHWC'},{av:'divCell_br_vital_Visible',ctrl:'CELL_BR_VITAL',prop:'Visible'},{ctrl:'BR_VITALWC'},{av:'divCell_br_diagnosis_Visible',ctrl:'CELL_BR_DIAGNOSIS',prop:'Visible'},{ctrl:'BR_DIAGNOSISWC'},{av:'divCell_br_lab_Visible',ctrl:'CELL_BR_LAB',prop:'Visible'},{ctrl:'BR_LABWC'},{av:'divCell_br_medication_Visible',ctrl:'CELL_BR_MEDICATION',prop:'Visible'},{ctrl:'BR_MEDICATIONWC'},{av:'divCell_br_scheme_Visible',ctrl:'CELL_BR_SCHEME',prop:'Visible'},{ctrl:'BR_SCHEMEWC'},{av:'divCell_br_procedure_Visible',ctrl:'CELL_BR_PROCEDURE',prop:'Visible'},{ctrl:'BR_PROCEDUREWC'},{av:'divCell_br_medicalimaging_Visible',ctrl:'CELL_BR_MEDICALIMAGING',prop:'Visible'},{ctrl:'BR_MEDICALIMAGINGWC'},{av:'divCell_br_pathology_Visible',ctrl:'CELL_BR_PATHOLOGY',prop:'Visible'},{ctrl:'BR_PATHOLOGYWC'}]}");
         setEventMetadata("'BR_SCHEME'","{handler:'E311X2',iparms:[{av:'A19BR_EncounterID',fld:'BR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV10BR_EncounterID',fld:'vBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true},{av:'AV11LoadAllTabs',fld:'vLOADALLTABS',pic:''},{av:'AV12SelectedTabCode',fld:'vSELECTEDTABCODE',pic:''}]");
         setEventMetadata("'BR_SCHEME'",",oparms:[{av:'AV12SelectedTabCode',fld:'vSELECTEDTABCODE',pic:''},{av:'AV11LoadAllTabs',fld:'vLOADALLTABS',pic:''},{av:'divCell_br_encounter_Visible',ctrl:'CELL_BR_ENCOUNTER',prop:'Visible'},{ctrl:'BR_ENCOUNTERWC'},{av:'lblTxttabtitle_Caption',ctrl:'TXTTABTITLE',prop:'Caption'},{av:'divCell_br_demographics_Visible',ctrl:'CELL_BR_DEMOGRAPHICS',prop:'Visible'},{ctrl:'BR_DEMOGRAPHICSWC'},{av:'divCell_br_behavior_Visible',ctrl:'CELL_BR_BEHAVIOR',prop:'Visible'},{ctrl:'BR_BEHAVIORWC'},{av:'divCell_br_comorbidity_Visible',ctrl:'CELL_BR_COMORBIDITY',prop:'Visible'},{ctrl:'BR_COMORBIDITYWC'},{av:'divCell_br_death_Visible',ctrl:'CELL_BR_DEATH',prop:'Visible'},{ctrl:'BR_DEATHWC'},{av:'divCell_br_vital_Visible',ctrl:'CELL_BR_VITAL',prop:'Visible'},{ctrl:'BR_VITALWC'},{av:'divCell_br_diagnosis_Visible',ctrl:'CELL_BR_DIAGNOSIS',prop:'Visible'},{ctrl:'BR_DIAGNOSISWC'},{av:'divCell_br_lab_Visible',ctrl:'CELL_BR_LAB',prop:'Visible'},{ctrl:'BR_LABWC'},{av:'divCell_br_medication_Visible',ctrl:'CELL_BR_MEDICATION',prop:'Visible'},{ctrl:'BR_MEDICATIONWC'},{av:'divCell_br_scheme_Visible',ctrl:'CELL_BR_SCHEME',prop:'Visible'},{ctrl:'BR_SCHEMEWC'},{av:'divCell_br_procedure_Visible',ctrl:'CELL_BR_PROCEDURE',prop:'Visible'},{ctrl:'BR_PROCEDUREWC'},{av:'divCell_br_medicalimaging_Visible',ctrl:'CELL_BR_MEDICALIMAGING',prop:'Visible'},{ctrl:'BR_MEDICALIMAGINGWC'},{av:'divCell_br_pathology_Visible',ctrl:'CELL_BR_PATHOLOGY',prop:'Visible'},{ctrl:'BR_PATHOLOGYWC'}]}");
         setEventMetadata("'BR_PROCEDURE'","{handler:'E321X2',iparms:[{av:'A19BR_EncounterID',fld:'BR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV10BR_EncounterID',fld:'vBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true},{av:'AV11LoadAllTabs',fld:'vLOADALLTABS',pic:''},{av:'AV12SelectedTabCode',fld:'vSELECTEDTABCODE',pic:''}]");
         setEventMetadata("'BR_PROCEDURE'",",oparms:[{av:'AV12SelectedTabCode',fld:'vSELECTEDTABCODE',pic:''},{av:'AV11LoadAllTabs',fld:'vLOADALLTABS',pic:''},{av:'divCell_br_encounter_Visible',ctrl:'CELL_BR_ENCOUNTER',prop:'Visible'},{ctrl:'BR_ENCOUNTERWC'},{av:'lblTxttabtitle_Caption',ctrl:'TXTTABTITLE',prop:'Caption'},{av:'divCell_br_demographics_Visible',ctrl:'CELL_BR_DEMOGRAPHICS',prop:'Visible'},{ctrl:'BR_DEMOGRAPHICSWC'},{av:'divCell_br_behavior_Visible',ctrl:'CELL_BR_BEHAVIOR',prop:'Visible'},{ctrl:'BR_BEHAVIORWC'},{av:'divCell_br_comorbidity_Visible',ctrl:'CELL_BR_COMORBIDITY',prop:'Visible'},{ctrl:'BR_COMORBIDITYWC'},{av:'divCell_br_death_Visible',ctrl:'CELL_BR_DEATH',prop:'Visible'},{ctrl:'BR_DEATHWC'},{av:'divCell_br_vital_Visible',ctrl:'CELL_BR_VITAL',prop:'Visible'},{ctrl:'BR_VITALWC'},{av:'divCell_br_diagnosis_Visible',ctrl:'CELL_BR_DIAGNOSIS',prop:'Visible'},{ctrl:'BR_DIAGNOSISWC'},{av:'divCell_br_lab_Visible',ctrl:'CELL_BR_LAB',prop:'Visible'},{ctrl:'BR_LABWC'},{av:'divCell_br_medication_Visible',ctrl:'CELL_BR_MEDICATION',prop:'Visible'},{ctrl:'BR_MEDICATIONWC'},{av:'divCell_br_scheme_Visible',ctrl:'CELL_BR_SCHEME',prop:'Visible'},{ctrl:'BR_SCHEMEWC'},{av:'divCell_br_procedure_Visible',ctrl:'CELL_BR_PROCEDURE',prop:'Visible'},{ctrl:'BR_PROCEDUREWC'},{av:'divCell_br_medicalimaging_Visible',ctrl:'CELL_BR_MEDICALIMAGING',prop:'Visible'},{ctrl:'BR_MEDICALIMAGINGWC'},{av:'divCell_br_pathology_Visible',ctrl:'CELL_BR_PATHOLOGY',prop:'Visible'},{ctrl:'BR_PATHOLOGYWC'}]}");
         setEventMetadata("'BR_MEDICALIMAGING'","{handler:'E331X2',iparms:[{av:'A19BR_EncounterID',fld:'BR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV10BR_EncounterID',fld:'vBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true},{av:'AV11LoadAllTabs',fld:'vLOADALLTABS',pic:''},{av:'AV12SelectedTabCode',fld:'vSELECTEDTABCODE',pic:''}]");
         setEventMetadata("'BR_MEDICALIMAGING'",",oparms:[{av:'AV12SelectedTabCode',fld:'vSELECTEDTABCODE',pic:''},{av:'AV11LoadAllTabs',fld:'vLOADALLTABS',pic:''},{av:'divCell_br_encounter_Visible',ctrl:'CELL_BR_ENCOUNTER',prop:'Visible'},{ctrl:'BR_ENCOUNTERWC'},{av:'lblTxttabtitle_Caption',ctrl:'TXTTABTITLE',prop:'Caption'},{av:'divCell_br_demographics_Visible',ctrl:'CELL_BR_DEMOGRAPHICS',prop:'Visible'},{ctrl:'BR_DEMOGRAPHICSWC'},{av:'divCell_br_behavior_Visible',ctrl:'CELL_BR_BEHAVIOR',prop:'Visible'},{ctrl:'BR_BEHAVIORWC'},{av:'divCell_br_comorbidity_Visible',ctrl:'CELL_BR_COMORBIDITY',prop:'Visible'},{ctrl:'BR_COMORBIDITYWC'},{av:'divCell_br_death_Visible',ctrl:'CELL_BR_DEATH',prop:'Visible'},{ctrl:'BR_DEATHWC'},{av:'divCell_br_vital_Visible',ctrl:'CELL_BR_VITAL',prop:'Visible'},{ctrl:'BR_VITALWC'},{av:'divCell_br_diagnosis_Visible',ctrl:'CELL_BR_DIAGNOSIS',prop:'Visible'},{ctrl:'BR_DIAGNOSISWC'},{av:'divCell_br_lab_Visible',ctrl:'CELL_BR_LAB',prop:'Visible'},{ctrl:'BR_LABWC'},{av:'divCell_br_medication_Visible',ctrl:'CELL_BR_MEDICATION',prop:'Visible'},{ctrl:'BR_MEDICATIONWC'},{av:'divCell_br_scheme_Visible',ctrl:'CELL_BR_SCHEME',prop:'Visible'},{ctrl:'BR_SCHEMEWC'},{av:'divCell_br_procedure_Visible',ctrl:'CELL_BR_PROCEDURE',prop:'Visible'},{ctrl:'BR_PROCEDUREWC'},{av:'divCell_br_medicalimaging_Visible',ctrl:'CELL_BR_MEDICALIMAGING',prop:'Visible'},{ctrl:'BR_MEDICALIMAGINGWC'},{av:'divCell_br_pathology_Visible',ctrl:'CELL_BR_PATHOLOGY',prop:'Visible'},{ctrl:'BR_PATHOLOGYWC'}]}");
         setEventMetadata("'BR_PATHOLOGY'","{handler:'E341X2',iparms:[{av:'A19BR_EncounterID',fld:'BR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV10BR_EncounterID',fld:'vBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true},{av:'AV11LoadAllTabs',fld:'vLOADALLTABS',pic:''},{av:'AV12SelectedTabCode',fld:'vSELECTEDTABCODE',pic:''}]");
         setEventMetadata("'BR_PATHOLOGY'",",oparms:[{av:'AV12SelectedTabCode',fld:'vSELECTEDTABCODE',pic:''},{av:'AV11LoadAllTabs',fld:'vLOADALLTABS',pic:''},{av:'divCell_br_encounter_Visible',ctrl:'CELL_BR_ENCOUNTER',prop:'Visible'},{ctrl:'BR_ENCOUNTERWC'},{av:'lblTxttabtitle_Caption',ctrl:'TXTTABTITLE',prop:'Caption'},{av:'divCell_br_demographics_Visible',ctrl:'CELL_BR_DEMOGRAPHICS',prop:'Visible'},{ctrl:'BR_DEMOGRAPHICSWC'},{av:'divCell_br_behavior_Visible',ctrl:'CELL_BR_BEHAVIOR',prop:'Visible'},{ctrl:'BR_BEHAVIORWC'},{av:'divCell_br_comorbidity_Visible',ctrl:'CELL_BR_COMORBIDITY',prop:'Visible'},{ctrl:'BR_COMORBIDITYWC'},{av:'divCell_br_death_Visible',ctrl:'CELL_BR_DEATH',prop:'Visible'},{ctrl:'BR_DEATHWC'},{av:'divCell_br_vital_Visible',ctrl:'CELL_BR_VITAL',prop:'Visible'},{ctrl:'BR_VITALWC'},{av:'divCell_br_diagnosis_Visible',ctrl:'CELL_BR_DIAGNOSIS',prop:'Visible'},{ctrl:'BR_DIAGNOSISWC'},{av:'divCell_br_lab_Visible',ctrl:'CELL_BR_LAB',prop:'Visible'},{ctrl:'BR_LABWC'},{av:'divCell_br_medication_Visible',ctrl:'CELL_BR_MEDICATION',prop:'Visible'},{ctrl:'BR_MEDICATIONWC'},{av:'divCell_br_scheme_Visible',ctrl:'CELL_BR_SCHEME',prop:'Visible'},{ctrl:'BR_SCHEMEWC'},{av:'divCell_br_procedure_Visible',ctrl:'CELL_BR_PROCEDURE',prop:'Visible'},{ctrl:'BR_PROCEDUREWC'},{av:'divCell_br_medicalimaging_Visible',ctrl:'CELL_BR_MEDICALIMAGING',prop:'Visible'},{ctrl:'BR_MEDICALIMAGINGWC'},{av:'divCell_br_pathology_Visible',ctrl:'CELL_BR_PATHOLOGY',prop:'Visible'},{ctrl:'BR_PATHOLOGYWC'}]}");
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
      }

      public override void initialize( )
      {
         wcpOAV8TabCode = "";
         Dvelop_confirmpanel_check_Result = "";
         Dvelop_confirmpanel_recheck_Result = "";
         Dvelop_confirmpanel_submit_Result = "";
         Tabs_Activepagecontrolname = "";
         gxfirstwebparm = "";
         gxfirstwebparm_bkp = "";
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         GXKey = "";
         AV6WWPContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPContext(context);
         AV18tPageReturn = "";
         AV16BCBR_Encounter = new SdtBR_Encounter(context);
         AV12SelectedTabCode = "";
         GX_FocusControl = "";
         Form = new GXWebForm();
         sPrefix = "";
         TempTags = "";
         ClassString = "";
         StyleString = "";
         bttBtncheck_Jsonclick = "";
         bttBtnrecheck_Jsonclick = "";
         bttBtnsubmit_Jsonclick = "";
         bttBtnreturn_Jsonclick = "";
         lblTxttabtitle_Jsonclick = "";
         ucTabs = new GXUserControl();
         lblBr_encounter_title_Jsonclick = "";
         WebComp_Br_encounterwc_Component = "";
         OldBr_encounterwc = "";
         lblBr_demographics_title_Jsonclick = "";
         WebComp_Br_demographicswc_Component = "";
         OldBr_demographicswc = "";
         lblBr_behavior_title_Jsonclick = "";
         WebComp_Br_behaviorwc_Component = "";
         OldBr_behaviorwc = "";
         lblBr_comorbidity_title_Jsonclick = "";
         WebComp_Br_comorbiditywc_Component = "";
         OldBr_comorbiditywc = "";
         lblBr_death_title_Jsonclick = "";
         WebComp_Br_deathwc_Component = "";
         OldBr_deathwc = "";
         lblBr_vital_title_Jsonclick = "";
         WebComp_Br_vitalwc_Component = "";
         OldBr_vitalwc = "";
         lblBr_diagnosis_title_Jsonclick = "";
         WebComp_Br_diagnosiswc_Component = "";
         OldBr_diagnosiswc = "";
         lblBr_lab_title_Jsonclick = "";
         WebComp_Br_labwc_Component = "";
         OldBr_labwc = "";
         lblBr_medication_title_Jsonclick = "";
         WebComp_Br_medicationwc_Component = "";
         OldBr_medicationwc = "";
         lblBr_scheme_title_Jsonclick = "";
         WebComp_Br_schemewc_Component = "";
         OldBr_schemewc = "";
         lblBr_procedure_title_Jsonclick = "";
         WebComp_Br_procedurewc_Component = "";
         OldBr_procedurewc = "";
         lblBr_medicalimaging_title_Jsonclick = "";
         WebComp_Br_medicalimagingwc_Component = "";
         OldBr_medicalimagingwc = "";
         lblBr_pathology_title_Jsonclick = "";
         WebComp_Br_pathologywc_Component = "";
         OldBr_pathologywc = "";
         bttBtnbr_encounter_Jsonclick = "";
         bttBtnbr_demographics_Jsonclick = "";
         bttBtnbr_behavior_Jsonclick = "";
         bttBtnbr_comorbidity_Jsonclick = "";
         bttBtnbr_death_Jsonclick = "";
         bttBtnbr_vital_Jsonclick = "";
         bttBtnbr_diagnosis_Jsonclick = "";
         bttBtnbr_lab_Jsonclick = "";
         bttBtnbr_medication_Jsonclick = "";
         bttBtnbr_scheme_Jsonclick = "";
         bttBtnbr_procedure_Jsonclick = "";
         bttBtnbr_medicalimaging_Jsonclick = "";
         bttBtnbr_pathology_Jsonclick = "";
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         scmdbuf = "";
         H001X2_A19BR_EncounterID = new long[1] ;
         AV17WebSession = context.GetSession();
         AV19tButtonFrom = "";
         AV22ErrorMsg = "";
         AV30GXV1 = new GXBaseCollection<SdtMessages_Message>( context, "Message", "GeneXus");
         AV21message = new SdtMessages_Message(context);
         AV32GXV3 = new GXBaseCollection<SdtMessages_Message>( context, "Message", "GeneXus");
         H001X3_A19BR_EncounterID = new long[1] ;
         sStyleString = "";
         ucDvelop_confirmpanel_submit = new GXUserControl();
         ucDvelop_confirmpanel_recheck = new GXUserControl();
         ucDvelop_confirmpanel_check = new GXUserControl();
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         pr_datastore1 = new DataStoreProvider(context, new GeneXus.Programs.br_encounterupdate__datastore1(),
            new Object[][] {
            }
         );
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.br_encounterupdate__default(),
            new Object[][] {
                new Object[] {
               H001X2_A19BR_EncounterID
               }
               , new Object[] {
               H001X3_A19BR_EncounterID
               }
            }
         );
         WebComp_Br_encounterwc = new GeneXus.Http.GXNullWebComponent();
         WebComp_Br_demographicswc = new GeneXus.Http.GXNullWebComponent();
         WebComp_Br_behaviorwc = new GeneXus.Http.GXNullWebComponent();
         WebComp_Br_comorbiditywc = new GeneXus.Http.GXNullWebComponent();
         WebComp_Br_deathwc = new GeneXus.Http.GXNullWebComponent();
         WebComp_Br_vitalwc = new GeneXus.Http.GXNullWebComponent();
         WebComp_Br_diagnosiswc = new GeneXus.Http.GXNullWebComponent();
         WebComp_Br_labwc = new GeneXus.Http.GXNullWebComponent();
         WebComp_Br_medicationwc = new GeneXus.Http.GXNullWebComponent();
         WebComp_Br_schemewc = new GeneXus.Http.GXNullWebComponent();
         WebComp_Br_procedurewc = new GeneXus.Http.GXNullWebComponent();
         WebComp_Br_medicalimagingwc = new GeneXus.Http.GXNullWebComponent();
         WebComp_Br_pathologywc = new GeneXus.Http.GXNullWebComponent();
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private short nGotPars ;
      private short GxWebError ;
      private short initialized ;
      private short gxajaxcallmode ;
      private short wbEnd ;
      private short wbStart ;
      private short nCmpId ;
      private short nDonePA ;
      private short gxcookieaux ;
      private short AV29GXLvl9 ;
      private short nGXWrapped ;
      private int Tabs_Pagecount ;
      private int bttBtncheck_Visible ;
      private int bttBtnrecheck_Visible ;
      private int bttBtnsubmit_Visible ;
      private int divCell_br_encounter_Visible ;
      private int divCell_br_demographics_Visible ;
      private int divCell_br_behavior_Visible ;
      private int divCell_br_comorbidity_Visible ;
      private int divCell_br_death_Visible ;
      private int divCell_br_vital_Visible ;
      private int divCell_br_diagnosis_Visible ;
      private int divCell_br_lab_Visible ;
      private int divCell_br_medication_Visible ;
      private int divCell_br_scheme_Visible ;
      private int divCell_br_procedure_Visible ;
      private int divCell_br_medicalimaging_Visible ;
      private int divCell_br_pathology_Visible ;
      private int AV31GXV2 ;
      private int AV33GXV4 ;
      private int idxLst ;
      private long AV10BR_EncounterID ;
      private long wcpOAV10BR_EncounterID ;
      private long A19BR_EncounterID ;
      private String AV8TabCode ;
      private String wcpOAV8TabCode ;
      private String Dvelop_confirmpanel_check_Result ;
      private String Dvelop_confirmpanel_recheck_Result ;
      private String Dvelop_confirmpanel_submit_Result ;
      private String Tabs_Activepagecontrolname ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String sDynURL ;
      private String FormProcess ;
      private String bodyStyle ;
      private String GXKey ;
      private String AV12SelectedTabCode ;
      private String Tabs_Class ;
      private String Dvelop_confirmpanel_check_Title ;
      private String Dvelop_confirmpanel_check_Confirmationtext ;
      private String Dvelop_confirmpanel_check_Yesbuttoncaption ;
      private String Dvelop_confirmpanel_check_Nobuttoncaption ;
      private String Dvelop_confirmpanel_check_Cancelbuttoncaption ;
      private String Dvelop_confirmpanel_check_Yesbuttonposition ;
      private String Dvelop_confirmpanel_check_Confirmtype ;
      private String Dvelop_confirmpanel_recheck_Title ;
      private String Dvelop_confirmpanel_recheck_Confirmationtext ;
      private String Dvelop_confirmpanel_recheck_Yesbuttoncaption ;
      private String Dvelop_confirmpanel_recheck_Nobuttoncaption ;
      private String Dvelop_confirmpanel_recheck_Cancelbuttoncaption ;
      private String Dvelop_confirmpanel_recheck_Yesbuttonposition ;
      private String Dvelop_confirmpanel_recheck_Confirmtype ;
      private String Dvelop_confirmpanel_submit_Title ;
      private String Dvelop_confirmpanel_submit_Confirmationtext ;
      private String Dvelop_confirmpanel_submit_Yesbuttoncaption ;
      private String Dvelop_confirmpanel_submit_Nobuttoncaption ;
      private String Dvelop_confirmpanel_submit_Cancelbuttoncaption ;
      private String Dvelop_confirmpanel_submit_Yesbuttonposition ;
      private String Dvelop_confirmpanel_submit_Confirmtype ;
      private String GX_FocusControl ;
      private String sPrefix ;
      private String divLayoutmaintable_Internalname ;
      private String divTablemain_Internalname ;
      private String TempTags ;
      private String ClassString ;
      private String StyleString ;
      private String bttBtncheck_Internalname ;
      private String bttBtncheck_Jsonclick ;
      private String bttBtnrecheck_Internalname ;
      private String bttBtnrecheck_Jsonclick ;
      private String bttBtnsubmit_Internalname ;
      private String bttBtnsubmit_Jsonclick ;
      private String bttBtnreturn_Internalname ;
      private String bttBtnreturn_Jsonclick ;
      private String divUnnamedtableviewcontainer_Internalname ;
      private String lblTxttabtitle_Internalname ;
      private String lblTxttabtitle_Caption ;
      private String lblTxttabtitle_Jsonclick ;
      private String Tabs_Internalname ;
      private String lblBr_encounter_title_Internalname ;
      private String lblBr_encounter_title_Jsonclick ;
      private String divUnnamedtablebr_encounter_Internalname ;
      private String WebComp_Br_encounterwc_Component ;
      private String OldBr_encounterwc ;
      private String lblBr_demographics_title_Internalname ;
      private String lblBr_demographics_title_Jsonclick ;
      private String divUnnamedtablebr_demographics_Internalname ;
      private String WebComp_Br_demographicswc_Component ;
      private String OldBr_demographicswc ;
      private String lblBr_behavior_title_Internalname ;
      private String lblBr_behavior_title_Jsonclick ;
      private String divUnnamedtablebr_behavior_Internalname ;
      private String WebComp_Br_behaviorwc_Component ;
      private String OldBr_behaviorwc ;
      private String lblBr_comorbidity_title_Internalname ;
      private String lblBr_comorbidity_title_Jsonclick ;
      private String divUnnamedtablebr_comorbidity_Internalname ;
      private String WebComp_Br_comorbiditywc_Component ;
      private String OldBr_comorbiditywc ;
      private String lblBr_death_title_Internalname ;
      private String lblBr_death_title_Jsonclick ;
      private String divUnnamedtablebr_death_Internalname ;
      private String WebComp_Br_deathwc_Component ;
      private String OldBr_deathwc ;
      private String lblBr_vital_title_Internalname ;
      private String lblBr_vital_title_Jsonclick ;
      private String divUnnamedtablebr_vital_Internalname ;
      private String WebComp_Br_vitalwc_Component ;
      private String OldBr_vitalwc ;
      private String lblBr_diagnosis_title_Internalname ;
      private String lblBr_diagnosis_title_Jsonclick ;
      private String divUnnamedtablebr_diagnosis_Internalname ;
      private String WebComp_Br_diagnosiswc_Component ;
      private String OldBr_diagnosiswc ;
      private String lblBr_lab_title_Internalname ;
      private String lblBr_lab_title_Jsonclick ;
      private String divUnnamedtablebr_lab_Internalname ;
      private String WebComp_Br_labwc_Component ;
      private String OldBr_labwc ;
      private String lblBr_medication_title_Internalname ;
      private String lblBr_medication_title_Jsonclick ;
      private String divUnnamedtablebr_medication_Internalname ;
      private String WebComp_Br_medicationwc_Component ;
      private String OldBr_medicationwc ;
      private String lblBr_scheme_title_Internalname ;
      private String lblBr_scheme_title_Jsonclick ;
      private String divUnnamedtablebr_scheme_Internalname ;
      private String WebComp_Br_schemewc_Component ;
      private String OldBr_schemewc ;
      private String lblBr_procedure_title_Internalname ;
      private String lblBr_procedure_title_Jsonclick ;
      private String divUnnamedtablebr_procedure_Internalname ;
      private String WebComp_Br_procedurewc_Component ;
      private String OldBr_procedurewc ;
      private String lblBr_medicalimaging_title_Internalname ;
      private String lblBr_medicalimaging_title_Jsonclick ;
      private String divUnnamedtablebr_medicalimaging_Internalname ;
      private String WebComp_Br_medicalimagingwc_Component ;
      private String OldBr_medicalimagingwc ;
      private String lblBr_pathology_title_Internalname ;
      private String lblBr_pathology_title_Jsonclick ;
      private String divUnnamedtablebr_pathology_Internalname ;
      private String WebComp_Br_pathologywc_Component ;
      private String OldBr_pathologywc ;
      private String divUnnamedtabletabscontainer_Internalname ;
      private String divCell_br_encounter_Internalname ;
      private String bttBtnbr_encounter_Internalname ;
      private String bttBtnbr_encounter_Jsonclick ;
      private String divCell_br_demographics_Internalname ;
      private String bttBtnbr_demographics_Internalname ;
      private String bttBtnbr_demographics_Jsonclick ;
      private String divCell_br_behavior_Internalname ;
      private String bttBtnbr_behavior_Internalname ;
      private String bttBtnbr_behavior_Jsonclick ;
      private String divCell_br_comorbidity_Internalname ;
      private String bttBtnbr_comorbidity_Internalname ;
      private String bttBtnbr_comorbidity_Jsonclick ;
      private String divCell_br_death_Internalname ;
      private String bttBtnbr_death_Internalname ;
      private String bttBtnbr_death_Jsonclick ;
      private String divCell_br_vital_Internalname ;
      private String bttBtnbr_vital_Internalname ;
      private String bttBtnbr_vital_Jsonclick ;
      private String divCell_br_diagnosis_Internalname ;
      private String bttBtnbr_diagnosis_Internalname ;
      private String bttBtnbr_diagnosis_Jsonclick ;
      private String divCell_br_lab_Internalname ;
      private String bttBtnbr_lab_Internalname ;
      private String bttBtnbr_lab_Jsonclick ;
      private String divCell_br_medication_Internalname ;
      private String bttBtnbr_medication_Internalname ;
      private String bttBtnbr_medication_Jsonclick ;
      private String divCell_br_scheme_Internalname ;
      private String bttBtnbr_scheme_Internalname ;
      private String bttBtnbr_scheme_Jsonclick ;
      private String divCell_br_procedure_Internalname ;
      private String bttBtnbr_procedure_Internalname ;
      private String bttBtnbr_procedure_Jsonclick ;
      private String divCell_br_medicalimaging_Internalname ;
      private String bttBtnbr_medicalimaging_Internalname ;
      private String bttBtnbr_medicalimaging_Jsonclick ;
      private String divCell_br_pathology_Internalname ;
      private String bttBtnbr_pathology_Internalname ;
      private String bttBtnbr_pathology_Jsonclick ;
      private String divHtml_bottomauxiliarcontrols_Internalname ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String scmdbuf ;
      private String sStyleString ;
      private String tblTabledvelop_confirmpanel_submit_Internalname ;
      private String Dvelop_confirmpanel_submit_Internalname ;
      private String tblTabledvelop_confirmpanel_recheck_Internalname ;
      private String Dvelop_confirmpanel_recheck_Internalname ;
      private String tblTabledvelop_confirmpanel_check_Internalname ;
      private String Dvelop_confirmpanel_check_Internalname ;
      private bool entryPointCalled ;
      private bool toggleJsOutput ;
      private bool AV11LoadAllTabs ;
      private bool Tabs_Historymanagement ;
      private bool wbLoad ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool gxdyncontrolsrefreshing ;
      private bool returnInSub ;
      private bool AV9Exists ;
      private bool AV26IsInsert ;
      private bool AV5IsAuthorized ;
      private bool AV13TempBoolean ;
      private bool AV25tCheckFlag ;
      private bool GXt_boolean1 ;
      private String AV18tPageReturn ;
      private String AV19tButtonFrom ;
      private String AV22ErrorMsg ;
      private GXWebComponent WebComp_Br_encounterwc ;
      private GXWebComponent WebComp_Br_demographicswc ;
      private GXWebComponent WebComp_Br_behaviorwc ;
      private GXWebComponent WebComp_Br_comorbiditywc ;
      private GXWebComponent WebComp_Br_deathwc ;
      private GXWebComponent WebComp_Br_vitalwc ;
      private GXWebComponent WebComp_Br_diagnosiswc ;
      private GXWebComponent WebComp_Br_labwc ;
      private GXWebComponent WebComp_Br_medicationwc ;
      private GXWebComponent WebComp_Br_schemewc ;
      private GXWebComponent WebComp_Br_procedurewc ;
      private GXWebComponent WebComp_Br_medicalimagingwc ;
      private GXWebComponent WebComp_Br_pathologywc ;
      private GXUserControl ucTabs ;
      private GXUserControl ucDvelop_confirmpanel_submit ;
      private GXUserControl ucDvelop_confirmpanel_recheck ;
      private GXUserControl ucDvelop_confirmpanel_check ;
      private IGxDataStore dsDataStore1 ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private long[] H001X2_A19BR_EncounterID ;
      private long[] H001X3_A19BR_EncounterID ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private IDataStoreProvider pr_datastore1 ;
      private IGxSession AV17WebSession ;
      private GXBaseCollection<SdtMessages_Message> AV30GXV1 ;
      private GXBaseCollection<SdtMessages_Message> AV32GXV3 ;
      private GXWebForm Form ;
      private SdtBR_Encounter AV16BCBR_Encounter ;
      private SdtMessages_Message AV21message ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPContext AV6WWPContext ;
   }

   public class br_encounterupdate__datastore1 : DataStoreHelperBase, IDataStoreHelper
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

 public class br_encounterupdate__default : DataStoreHelperBase, IDataStoreHelper
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
        Object[] prmH001X2 ;
        prmH001X2 = new Object[] {
        new Object[] {"@AV10BR_EncounterID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmH001X3 ;
        prmH001X3 = new Object[] {
        new Object[] {"@AV10BR_EncounterID",SqlDbType.Decimal,18,0}
        } ;
        def= new CursorDef[] {
            new CursorDef("H001X2", "SELECT [BR_EncounterID] FROM [BR_Encounter] WITH (NOLOCK) WHERE [BR_EncounterID] = @AV10BR_EncounterID ORDER BY [BR_EncounterID] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH001X2,1,0,false,true )
           ,new CursorDef("H001X3", "SELECT [BR_EncounterID] FROM [BR_Encounter] WITH (NOLOCK) WHERE [BR_EncounterID] = @AV10BR_EncounterID ORDER BY [BR_EncounterID] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH001X3,1,0,true,true )
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
              return;
           case 1 :
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
     }
  }

}

}
