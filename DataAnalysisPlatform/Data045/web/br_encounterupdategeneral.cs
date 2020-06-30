/*
               File: BR_EncounterUpdateGeneral
        Description: Data Mgmt Portal - RAAP
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/28/2020 15:6:47.94
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
using GeneXus.Http.Server;
using System.Xml.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.Runtime.Serialization;
namespace GeneXus.Programs {
   public class br_encounterupdategeneral : GXWebComponent, System.Web.SessionState.IRequiresSessionState
   {
      public br_encounterupdategeneral( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         if ( StringUtil.Len( (String)(sPrefix)) == 0 )
         {
            context.SetDefaultTheme("WorkWithPlusTheme");
         }
      }

      public br_encounterupdategeneral( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( long aP0_BR_EncounterID )
      {
         this.A19BR_EncounterID = aP0_BR_EncounterID;
         executePrivate();
      }

      void executePrivate( )
      {
         isStatic = false;
         webExecute();
      }

      public override void SetPrefix( String sPPrefix )
      {
         sPrefix = sPPrefix;
      }

      protected override void createObjects( )
      {
         dynavVdepartmentadm = new GXCombobox();
         dynavVdepartmentdisch = new GXCombobox();
         dynavVenctype = new GXCombobox();
         dynavVinsurance = new GXCombobox();
         dynavVreason = new GXCombobox();
         dynavBr_encounter_br_encounter_dischargestatus = new GXCombobox();
      }

      protected void INITWEB( )
      {
         initialize_properties( ) ;
         if ( StringUtil.Len( (String)(sPrefix)) == 0 )
         {
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
               else if ( StringUtil.StrCmp(gxfirstwebparm, "dyncomponent") == 0 )
               {
                  setAjaxEventMode();
                  if ( ! IsValidAjaxCall( true) )
                  {
                     GxWebError = 1;
                     return  ;
                  }
                  nDynComponent = 1;
                  sCompPrefix = GetNextPar( );
                  sSFPrefix = GetNextPar( );
                  A19BR_EncounterID = (long)(NumberUtil.Val( GetNextPar( ), "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A19BR_EncounterID", StringUtil.LTrim( StringUtil.Str( (decimal)(A19BR_EncounterID), 18, 0)));
                  setjustcreated();
                  componentprepare(new Object[] {(String)sCompPrefix,(String)sSFPrefix,(long)A19BR_EncounterID});
                  componentstart();
                  context.httpAjaxContext.ajax_rspStartCmp(sPrefix);
                  componentdraw();
                  context.httpAjaxContext.ajax_rspEndCmp();
                  return  ;
               }
               else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxCallCrl"+"_"+"vVDEPARTMENTADM") == 0 )
               {
                  AV24tCurrentCode = GetNextPar( );
                  setAjaxCallMode();
                  if ( ! IsValidAjaxCall( true) )
                  {
                     GxWebError = 1;
                     return  ;
                  }
                  GXDLVvVDEPARTMENTADM1Z2( AV24tCurrentCode) ;
                  return  ;
               }
               else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxCallCrl"+"_"+"vVDEPARTMENTDISCH") == 0 )
               {
                  AV24tCurrentCode = GetNextPar( );
                  setAjaxCallMode();
                  if ( ! IsValidAjaxCall( true) )
                  {
                     GxWebError = 1;
                     return  ;
                  }
                  GXDLVvVDEPARTMENTDISCH1Z2( AV24tCurrentCode) ;
                  return  ;
               }
               else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxCallCrl"+"_"+"vVENCTYPE") == 0 )
               {
                  AV24tCurrentCode = GetNextPar( );
                  setAjaxCallMode();
                  if ( ! IsValidAjaxCall( true) )
                  {
                     GxWebError = 1;
                     return  ;
                  }
                  GXDLVvVENCTYPE1Z2( AV24tCurrentCode) ;
                  return  ;
               }
               else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxCallCrl"+"_"+"vVINSURANCE") == 0 )
               {
                  AV24tCurrentCode = GetNextPar( );
                  setAjaxCallMode();
                  if ( ! IsValidAjaxCall( true) )
                  {
                     GxWebError = 1;
                     return  ;
                  }
                  GXDLVvVINSURANCE1Z2( AV24tCurrentCode) ;
                  return  ;
               }
               else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxCallCrl"+"_"+"vVREASON") == 0 )
               {
                  AV24tCurrentCode = GetNextPar( );
                  setAjaxCallMode();
                  if ( ! IsValidAjaxCall( true) )
                  {
                     GxWebError = 1;
                     return  ;
                  }
                  GXDLVvVREASON1Z2( AV24tCurrentCode) ;
                  return  ;
               }
               else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxCallCrl"+"_"+"BR_ENCOUNTER_BR_ENCOUNTER_DISCHARGESTATUS") == 0 )
               {
                  AV24tCurrentCode = GetNextPar( );
                  setAjaxCallMode();
                  if ( ! IsValidAjaxCall( true) )
                  {
                     GxWebError = 1;
                     return  ;
                  }
                  GXDLVBR_ENCOUNTER_BR_ENCOUNTER_DISCHARGESTATUS1Z2( AV24tCurrentCode) ;
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
            }
         }
         if ( StringUtil.Len( sPrefix) == 0 )
         {
            if ( ! context.IsLocalStorageSupported( ) )
            {
               context.PushCurrentUrl();
            }
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
            if ( StringUtil.Len( sPrefix) == 0 )
            {
               ValidateSpaRequest();
            }
            PA1Z2( ) ;
            if ( ( GxWebError == 0 ) && ! isAjaxCallMode( ) )
            {
               /* GeneXus formulas. */
               AV44Pgmname = "BR_EncounterUpdateGeneral";
               context.Gx_err = 0;
               edtavBr_encounter_br_information_patientno_Enabled = 0;
               context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavBr_encounter_br_information_patientno_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavBr_encounter_br_information_patientno_Enabled), 5, 0)), true);
               edtavBr_encounter_br_encounter_encid_Enabled = 0;
               context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavBr_encounter_br_encounter_encid_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavBr_encounter_br_encounter_encid_Enabled), 5, 0)), true);
               WS1Z2( ) ;
               if ( ! isAjaxCallMode( ) )
               {
                  if ( nDynComponent == 0 )
                  {
                     throw new System.Net.WebException("WebComponent is not allowed to run") ;
                  }
               }
            }
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

      protected void RenderHtmlHeaders( )
      {
         GxWebStd.gx_html_headers( context, 0, "", "", Form.Meta, Form.Metaequiv, true);
      }

      protected void RenderHtmlOpenForm( )
      {
         if ( StringUtil.Len( sPrefix) == 0 )
         {
            if ( context.isSpaRequest( ) )
            {
               enableOutput();
            }
            context.WriteHtmlText( "<title>") ;
            context.SendWebValue( "Data Mgmt Portal - RAAP") ;
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
         }
         if ( ( ( context.GetBrowserType( ) == 1 ) || ( context.GetBrowserType( ) == 5 ) ) && ( StringUtil.StrCmp(context.GetBrowserVersion( ), "7.0") == 0 ) )
         {
            context.AddJavascriptSource("json2.js", "?"+context.GetBuildNumber( 127771), false);
         }
         context.AddJavascriptSource("jquery.js", "?"+context.GetBuildNumber( 127771), false);
         context.AddJavascriptSource("gxtimezone.js", "?"+context.GetBuildNumber( 127771), false);
         context.AddJavascriptSource("gxgral.js", "?"+context.GetBuildNumber( 127771), false);
         context.AddJavascriptSource("gxcfg.js", "?20202281564828", false);
         if ( context.isSpaRequest( ) )
         {
            enableOutput();
         }
         context.AddJavascriptSource("calendar.js", "?"+context.GetBuildNumber( 127771), false);
         context.AddJavascriptSource("calendar-setup.js", "?"+context.GetBuildNumber( 127771), false);
         context.AddJavascriptSource("calendar-zh.js", "?"+context.GetBuildNumber( 127771), false);
         context.AddJavascriptSource("DVelop/Bootstrap/Shared/DVelopBootstrap.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/Panel/BootstrapPanelRender.js", "", false);
         if ( StringUtil.Len( sPrefix) == 0 )
         {
            context.CloseHtmlHeader();
            if ( context.isSpaRequest( ) )
            {
               disableOutput();
            }
            FormProcess = " data-HasEnter=\"false\" data-Skiponenter=\"false\"";
            context.WriteHtmlText( "<body ") ;
            bodyStyle = "";
            if ( nGXWrapped == 0 )
            {
               bodyStyle = bodyStyle + "-moz-opacity:0;opacity:0;";
            }
            context.WriteHtmlText( " "+"class=\"form-horizontal Form\""+" "+ "style='"+bodyStyle+"'") ;
            context.WriteHtmlText( FormProcess+">") ;
            context.skipLines(1);
            context.WriteHtmlTextNl( "<form id=\"MAINFORM\" autocomplete=\"off\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("br_encounterupdategeneral.aspx") + "?" + UrlEncode("" +A19BR_EncounterID)+"\">") ;
            GxWebStd.gx_hidden_field( context, "_EventName", "");
            GxWebStd.gx_hidden_field( context, "_EventGridId", "");
            GxWebStd.gx_hidden_field( context, "_EventRowId", "");
            context.WriteHtmlText( "<input type=\"submit\" title=\"submit\" style=\"display:none\" disabled>") ;
            context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, "FORM", "Class", "form-horizontal Form", true);
         }
         else
         {
            bool toggleHtmlOutput = isOutputEnabled( ) ;
            if ( StringUtil.StringSearch( sPrefix, "MP", 1) == 1 )
            {
               if ( context.isSpaRequest( ) )
               {
                  disableOutput();
               }
            }
            context.WriteHtmlText( "<div") ;
            GxWebStd.ClassAttribute( context, "gxwebcomponent-body"+" "+(String.IsNullOrEmpty(StringUtil.RTrim( Form.Class)) ? "form-horizontal Form" : Form.Class)+"-fx");
            context.WriteHtmlText( ">") ;
            if ( toggleHtmlOutput )
            {
               if ( StringUtil.StringSearch( sPrefix, "MP", 1) == 1 )
               {
                  if ( context.isSpaRequest( ) )
                  {
                     enableOutput();
                  }
               }
            }
            toggleJsOutput = isJsOutputEnabled( );
            if ( context.isSpaRequest( ) )
            {
               disableJsOutput();
            }
         }
         if ( StringUtil.StringSearch( sPrefix, "MP", 1) == 1 )
         {
            if ( context.isSpaRequest( ) )
            {
               disableOutput();
            }
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
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, sPrefix+"Br_encounter", AV14BR_Encounter);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt(sPrefix+"Br_encounter", AV14BR_Encounter);
         }
         GxWebStd.gx_hidden_field( context, sPrefix+"wcpOA19BR_EncounterID", StringUtil.LTrim( StringUtil.NToC( (decimal)(wcpOA19BR_EncounterID), 18, 0, ".", "")));
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, sPrefix+"vBR_ENCOUNTER", AV14BR_Encounter);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt(sPrefix+"vBR_ENCOUNTER", AV14BR_Encounter);
         }
         GxWebStd.gx_hidden_field( context, sPrefix+"BR_ENCOUNTERID", StringUtil.LTrim( StringUtil.NToC( (decimal)(A19BR_EncounterID), 18, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, sPrefix+"vTCURRENTCODE", AV24tCurrentCode);
         GxWebStd.gx_hidden_field( context, sPrefix+"DVPANEL_UNNAMEDTABLE1_Width", StringUtil.RTrim( Dvpanel_unnamedtable1_Width));
         GxWebStd.gx_hidden_field( context, sPrefix+"DVPANEL_UNNAMEDTABLE1_Cls", StringUtil.RTrim( Dvpanel_unnamedtable1_Cls));
         GxWebStd.gx_hidden_field( context, sPrefix+"DVPANEL_UNNAMEDTABLE1_Title", StringUtil.RTrim( Dvpanel_unnamedtable1_Title));
         GxWebStd.gx_hidden_field( context, sPrefix+"DVPANEL_UNNAMEDTABLE1_Collapsible", StringUtil.BoolToStr( Dvpanel_unnamedtable1_Collapsible));
         GxWebStd.gx_hidden_field( context, sPrefix+"DVPANEL_UNNAMEDTABLE1_Collapsed", StringUtil.BoolToStr( Dvpanel_unnamedtable1_Collapsed));
         GxWebStd.gx_hidden_field( context, sPrefix+"DVPANEL_UNNAMEDTABLE1_Autowidth", StringUtil.BoolToStr( Dvpanel_unnamedtable1_Autowidth));
         GxWebStd.gx_hidden_field( context, sPrefix+"DVPANEL_UNNAMEDTABLE1_Autoheight", StringUtil.BoolToStr( Dvpanel_unnamedtable1_Autoheight));
         GxWebStd.gx_hidden_field( context, sPrefix+"DVPANEL_UNNAMEDTABLE1_Showcollapseicon", StringUtil.BoolToStr( Dvpanel_unnamedtable1_Showcollapseicon));
         GxWebStd.gx_hidden_field( context, sPrefix+"DVPANEL_UNNAMEDTABLE1_Iconposition", StringUtil.RTrim( Dvpanel_unnamedtable1_Iconposition));
         GxWebStd.gx_hidden_field( context, sPrefix+"DVPANEL_UNNAMEDTABLE1_Autoscroll", StringUtil.BoolToStr( Dvpanel_unnamedtable1_Autoscroll));
      }

      protected void RenderHtmlCloseForm1Z2( )
      {
         SendCloseFormHiddens( ) ;
         if ( ( StringUtil.Len( sPrefix) != 0 ) && ( context.isAjaxRequest( ) || context.isSpaRequest( ) ) )
         {
            context.AddJavascriptSource("br_encounterupdategeneral.js", "?20202281564854", false);
         }
         GxWebStd.gx_hidden_field( context, sPrefix+"GX_FocusControl", GX_FocusControl);
         define_styles( ) ;
         SendSecurityToken(sPrefix);
         if ( StringUtil.Len( sPrefix) == 0 )
         {
            SendAjaxEncryptionKey();
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
            context.WriteHtmlTextNl( "</body>") ;
            context.WriteHtmlTextNl( "</html>") ;
            if ( context.isSpaRequest( ) )
            {
               enableOutput();
            }
         }
         else
         {
            SendWebComponentState();
            context.WriteHtmlText( "</div>") ;
            if ( toggleJsOutput )
            {
               if ( context.isSpaRequest( ) )
               {
                  enableJsOutput();
               }
            }
         }
      }

      public override String GetPgmname( )
      {
         return "BR_EncounterUpdateGeneral" ;
      }

      public override String GetPgmdesc( )
      {
         return "Data Mgmt Portal - RAAP" ;
      }

      protected void WB1Z0( )
      {
         if ( context.isAjaxRequest( ) )
         {
            disableOutput();
         }
         if ( ! wbLoad )
         {
            if ( StringUtil.Len( sPrefix) == 0 )
            {
               RenderHtmlHeaders( ) ;
            }
            RenderHtmlOpenForm( ) ;
            if ( StringUtil.Len( sPrefix) != 0 )
            {
               GxWebStd.gx_hidden_field( context, sPrefix+"_CMPPGM", "br_encounterupdategeneral.aspx");
               context.AddJavascriptSource("DVelop/Bootstrap/Shared/DVelopBootstrap.js", "", false);
               context.AddJavascriptSource("DVelop/Bootstrap/Panel/BootstrapPanelRender.js", "", false);
            }
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "Section", "left", "top", " "+"data-gx-base-lib=\"bootstrapv3\""+" "+"data-abstract-form"+" ", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divLayoutmaintable_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divTable_Internalname, 1, 0, "px", 0, "px", "", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divDvpanel_unnamedtable1_cell_Internalname, 1, 0, "px", 0, "px", divDvpanel_unnamedtable1_cell_Class, "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divHtml_dvpanel_unnamedtable1_Internalname, 1, 0, "px", 0, "px", "Section", "left", "top", "", "", "div");
            /* User Defined Control */
            ucDvpanel_unnamedtable1.SetProperty("Width", Dvpanel_unnamedtable1_Width);
            ucDvpanel_unnamedtable1.SetProperty("AutoWidth", Dvpanel_unnamedtable1_Autowidth);
            ucDvpanel_unnamedtable1.SetProperty("AutoHeight", Dvpanel_unnamedtable1_Autoheight);
            ucDvpanel_unnamedtable1.SetProperty("Cls", Dvpanel_unnamedtable1_Cls);
            ucDvpanel_unnamedtable1.SetProperty("Title", Dvpanel_unnamedtable1_Title);
            ucDvpanel_unnamedtable1.SetProperty("Collapsible", Dvpanel_unnamedtable1_Collapsible);
            ucDvpanel_unnamedtable1.SetProperty("Collapsed", Dvpanel_unnamedtable1_Collapsed);
            ucDvpanel_unnamedtable1.SetProperty("ShowCollapseIcon", Dvpanel_unnamedtable1_Showcollapseicon);
            ucDvpanel_unnamedtable1.SetProperty("IconPosition", Dvpanel_unnamedtable1_Iconposition);
            ucDvpanel_unnamedtable1.SetProperty("AutoScroll", Dvpanel_unnamedtable1_Autoscroll);
            ucDvpanel_unnamedtable1.Render(context, "dvelop.gxbootstrap.panel", Dvpanel_unnamedtable1_Internalname, sPrefix+"DVPANEL_UNNAMEDTABLE1Container");
            context.WriteHtmlText( "<div class=\"gx_usercontrol_child\" id=\""+sPrefix+"DVPANEL_UNNAMEDTABLE1Container"+"Body"+"\" style=\"display:none;\">") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, divLayout_unnamedtable1_Internalname, 1, 0, "px", 0, "px", "Section", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "Section", "left", "top", " "+"data-gx-base-lib=\"bootstrapv3\""+" "+"data-abstract-form"+" ", "", "div");
            wb_table1_14_1Z2( true) ;
         }
         else
         {
            wb_table1_14_1Z2( false) ;
         }
         return  ;
      }

      protected void wb_table1_14_1Z2e( bool wbgen )
      {
         if ( wbgen )
         {
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</div>") ;
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divUnnamedtable2_Internalname, 1, 0, "px", 0, "px", "", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-md-6 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtavBr_encounter_br_information_patientno_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavBr_encounter_br_information_patientno_Internalname, "患者编号", "col-sm-3 ReadonlyAttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtavBr_encounter_br_information_patientno_Internalname, AV14BR_Encounter.gxTpr_Br_information_patientno, StringUtil.RTrim( context.localUtil.Format( AV14BR_Encounter.gxTpr_Br_information_patientno, "")), "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavBr_encounter_br_information_patientno_Jsonclick, 0, "ReadonlyAttribute", "", "", "", "", 1, edtavBr_encounter_br_information_patientno_Enabled, 0, "text", "", 80, "chr", 1, "row", 2000, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_BR_EncounterUpdateGeneral.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-md-6 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtavBr_encounter_br_encounter_encid_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavBr_encounter_br_encounter_encid_Internalname, "就诊次序", "col-sm-3 ReadonlyAttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtavBr_encounter_br_encounter_encid_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV14BR_Encounter.gxTpr_Br_encounter_encid), 10, 0, ".", "")), ((edtavBr_encounter_br_encounter_encid_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(AV14BR_Encounter.gxTpr_Br_encounter_encid), "ZZZZZZZZZZ")) : context.localUtil.Format( (decimal)(AV14BR_Encounter.gxTpr_Br_encounter_encid), "ZZZZZZZZZZ")), "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavBr_encounter_br_encounter_encid_Jsonclick, 0, "ReadonlyAttribute", "", "", "", "", 1, edtavBr_encounter_br_encounter_encid_Enabled, 0, "number", "1", 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_BR_EncounterUpdateGeneral.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-md-6 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divTablesplittedvdepartmentadm_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-3 MergeLabelCell", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblockvdepartmentadm_Internalname, "入院科室", "", "", lblTextblockvdepartmentadm_Jsonclick, "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_BR_EncounterUpdateGeneral.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-9", "left", "top", "", "", "div");
            wb_table2_37_1Z2( true) ;
         }
         else
         {
            wb_table2_37_1Z2( false) ;
         }
         return  ;
      }

      protected void wb_table2_37_1Z2e( bool wbgen )
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
            GxWebStd.gx_div_start( context, divTablesplittedvdepartmentdisch_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-3 MergeLabelCell", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblockvdepartmentdisch_Internalname, "出院科室", "", "", lblTextblockvdepartmentdisch_Jsonclick, "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_BR_EncounterUpdateGeneral.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-9", "left", "top", "", "", "div");
            wb_table3_51_1Z2( true) ;
         }
         else
         {
            wb_table3_51_1Z2( false) ;
         }
         return  ;
      }

      protected void wb_table3_51_1Z2e( bool wbgen )
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
            GxWebStd.gx_div_start( context, divTablesplittedvenctype_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-3 MergeLabelCell", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblockvenctype_Internalname, "就诊方式", "", "", lblTextblockvenctype_Jsonclick, "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_BR_EncounterUpdateGeneral.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-9", "left", "top", "", "", "div");
            wb_table4_66_1Z2( true) ;
         }
         else
         {
            wb_table4_66_1Z2( false) ;
         }
         return  ;
      }

      protected void wb_table4_66_1Z2e( bool wbgen )
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
            GxWebStd.gx_div_start( context, divTablesplittedvinsurance_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-3 MergeLabelCell", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblockvinsurance_Internalname, "保险", "", "", lblTextblockvinsurance_Jsonclick, "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_BR_EncounterUpdateGeneral.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-9", "left", "top", "", "", "div");
            wb_table5_80_1Z2( true) ;
         }
         else
         {
            wb_table5_80_1Z2( false) ;
         }
         return  ;
      }

      protected void wb_table5_80_1Z2e( bool wbgen )
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
            GxWebStd.gx_div_start( context, divTablesplittedvreason_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-3 MergeLabelCell", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblockvreason_Internalname, "入院原因", "", "", lblTextblockvreason_Jsonclick, "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_BR_EncounterUpdateGeneral.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-9", "left", "top", "", "", "div");
            wb_table6_95_1Z2( true) ;
         }
         else
         {
            wb_table6_95_1Z2( false) ;
         }
         return  ;
      }

      protected void wb_table6_95_1Z2e( bool wbgen )
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
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtavBr_encounter_br_encounter_admitdate_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavBr_encounter_br_encounter_admitdate_Internalname, "就诊/入院时间", "col-sm-3 AttributeDateLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 106,'" + sPrefix + "',false,'',0)\"";
            context.WriteHtmlText( "<div id=\""+edtavBr_encounter_br_encounter_admitdate_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtavBr_encounter_br_encounter_admitdate_Internalname, context.localUtil.Format(AV14BR_Encounter.gxTpr_Br_encounter_admitdate, "9999/99/99"), context.localUtil.Format( AV14BR_Encounter.gxTpr_Br_encounter_admitdate, "9999/99/99"), TempTags+" onchange=\""+"gx.date.valid_date(this, 10,'YMD',0,24,'chs',false,1);"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,106);\"", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavBr_encounter_br_encounter_admitdate_Jsonclick, 0, "AttributeDate", "", "", "", "", 1, edtavBr_encounter_br_encounter_admitdate_Enabled, 0, "text", "", 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_BR_EncounterUpdateGeneral.htm");
            GxWebStd.gx_bitmap( context, edtavBr_encounter_br_encounter_admitdate_Internalname+"_dp_trigger", context.GetImagePath( "61b9b5d3-dff6-4d59-9b00-da61bc2cbe93", "", context.GetTheme( )), "", "", "", "", ((1==0)||(edtavBr_encounter_br_encounter_admitdate_Enabled==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;", "", "", "", "", "", "", "", "", 1, false, false, "", "HLP_BR_EncounterUpdateGeneral.htm");
            context.WriteHtmlTextNl( "</div>") ;
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-md-6 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtavBr_encounter_br_encounter_dischargedate_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavBr_encounter_br_encounter_dischargedate_Internalname, "出院时间", "col-sm-3 AttributeDateLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 111,'" + sPrefix + "',false,'',0)\"";
            context.WriteHtmlText( "<div id=\""+edtavBr_encounter_br_encounter_dischargedate_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtavBr_encounter_br_encounter_dischargedate_Internalname, context.localUtil.Format(AV14BR_Encounter.gxTpr_Br_encounter_dischargedate, "9999/99/99"), context.localUtil.Format( AV14BR_Encounter.gxTpr_Br_encounter_dischargedate, "9999/99/99"), TempTags+" onchange=\""+"gx.date.valid_date(this, 10,'YMD',0,24,'chs',false,1);"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,111);\"", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavBr_encounter_br_encounter_dischargedate_Jsonclick, 0, "AttributeDate", "", "", "", "", 1, edtavBr_encounter_br_encounter_dischargedate_Enabled, 0, "text", "", 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_BR_EncounterUpdateGeneral.htm");
            GxWebStd.gx_bitmap( context, edtavBr_encounter_br_encounter_dischargedate_Internalname+"_dp_trigger", context.GetImagePath( "61b9b5d3-dff6-4d59-9b00-da61bc2cbe93", "", context.GetTheme( )), "", "", "", "", ((1==0)||(edtavBr_encounter_br_encounter_dischargedate_Enabled==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;", "", "", "", "", "", "", "", "", 1, false, false, "", "HLP_BR_EncounterUpdateGeneral.htm");
            context.WriteHtmlTextNl( "</div>") ;
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-md-6 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+dynavBr_encounter_br_encounter_dischargestatus_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, dynavBr_encounter_br_encounter_dischargestatus_Internalname, "出院状态", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 115,'" + sPrefix + "',false,'',0)\"";
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, dynavBr_encounter_br_encounter_dischargestatus, dynavBr_encounter_br_encounter_dischargestatus_Internalname, StringUtil.RTrim( AV14BR_Encounter.gxTpr_Br_encounter_dischargestatus), 1, dynavBr_encounter_br_encounter_dischargestatus_Jsonclick, 0, "'"+sPrefix+"'"+",false,"+"'"+""+"'", "svchar", "", 1, dynavBr_encounter_br_encounter_dischargestatus.Enabled, 0, 0, 0, "em", 0, "", "", "Attribute", "", "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,115);\"", "", true, "HLP_BR_EncounterUpdateGeneral.htm");
            dynavBr_encounter_br_encounter_dischargestatus.CurrentValue = StringUtil.RTrim( AV14BR_Encounter.gxTpr_Br_encounter_dischargestatus);
            context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, dynavBr_encounter_br_encounter_dischargestatus_Internalname, "Values", (String)(dynavBr_encounter_br_encounter_dischargestatus.ToJavascriptSource()), true);
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
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-action-group TrnActionGroup", "left", "top", " "+"data-gx-actiongroup-type=\"toolbar\""+" ", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 120,'" + sPrefix + "',false,'',0)\"";
            ClassString = "ButtonMaterial";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtnsave_Internalname, "", "保存", bttBtnsave_Jsonclick, 5, "保存", "", StyleString, ClassString, 1, 1, "standard", "'"+sPrefix+"'"+",false,"+"'"+sPrefix+"E\\'DOSAVE\\'."+"'", TempTags, "", context.GetButtonType( ), "HLP_BR_EncounterUpdateGeneral.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            ClassString = "ErrorViewerOrange";
            StyleString = "";
            GxWebStd.gx_msg_list( context, "", context.GX_msglist.DisplayMode, StyleString, ClassString, sPrefix, "false");
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
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 127,'" + sPrefix + "',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavBr_encounter_br_encounterid_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV14BR_Encounter.gxTpr_Br_encounterid), 18, 0, ".", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(AV14BR_Encounter.gxTpr_Br_encounterid), "ZZZZZZZZZZZZZZZZZZ")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,127);\"", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavBr_encounter_br_encounterid_Jsonclick, 0, "Attribute", "", "", "", "", edtavBr_encounter_br_encounterid_Visible, 1, 0, "number", "1", 18, "chr", 1, "row", 18, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_BR_EncounterUpdateGeneral.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 128,'" + sPrefix + "',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavVdepartment_Internalname, AV16vDepartment, StringUtil.RTrim( context.localUtil.Format( AV16vDepartment, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,128);\"", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavVdepartment_Jsonclick, 0, "Attribute", "", "", "", "", edtavVdepartment_Visible, 1, 0, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_BR_EncounterUpdateGeneral.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 129,'" + sPrefix + "',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavVotherdepartment_Internalname, AV17vOtherDepartment, StringUtil.RTrim( context.localUtil.Format( AV17vOtherDepartment, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,129);\"", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavVotherdepartment_Jsonclick, 0, "Attribute", "", "", "", "", edtavVotherdepartment_Visible, 1, 0, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_BR_EncounterUpdateGeneral.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 130,'" + sPrefix + "',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavBr_encounter_br_information_id_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV14BR_Encounter.gxTpr_Br_information_id), 18, 0, ".", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(AV14BR_Encounter.gxTpr_Br_information_id), "ZZZZZZZZZZZZZZZZZZ")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,130);\"", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavBr_encounter_br_information_id_Jsonclick, 0, "Attribute", "", "", "", "", edtavBr_encounter_br_information_id_Visible, 1, 0, "number", "1", 18, "chr", 1, "row", 18, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_BR_EncounterUpdateGeneral.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
         }
         wbLoad = true;
      }

      protected void START1Z2( )
      {
         wbLoad = false;
         wbEnd = 0;
         wbStart = 0;
         if ( StringUtil.Len( sPrefix) == 0 )
         {
            if ( ! context.isSpaRequest( ) )
            {
               Form.Meta.addItem("generator", "GeneXus C# 16_0_0-127771", 0) ;
               Form.Meta.addItem("description", "Data Mgmt Portal - RAAP", 0) ;
            }
            context.wjLoc = "";
            context.nUserReturn = 0;
            context.wbHandled = 0;
            if ( StringUtil.Len( sPrefix) == 0 )
            {
               sXEvt = cgiGet( "_EventName");
               if ( ! GetJustCreated( ) && ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 ) )
               {
               }
            }
         }
         wbErr = false;
         if ( ( StringUtil.Len( sPrefix) == 0 ) || ( nDraw == 1 ) )
         {
            if ( nDoneStart == 0 )
            {
               STRUP1Z0( ) ;
            }
         }
      }

      protected void WS1Z2( )
      {
         START1Z2( ) ;
         EVT1Z2( ) ;
      }

      protected void EVT1Z2( )
      {
         sXEvt = cgiGet( "_EventName");
         if ( ( ( ( StringUtil.Len( sPrefix) == 0 ) ) || ( StringUtil.StringSearch( sXEvt, sPrefix, 1) > 0 ) ) && ! GetJustCreated( ) && ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 ) )
         {
            if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) && ! wbErr )
            {
               /* Read Web Panel buttons. */
               if ( context.wbHandled == 0 )
               {
                  if ( StringUtil.Len( sPrefix) == 0 )
                  {
                     sEvt = cgiGet( "_EventName");
                     EvtGridId = cgiGet( "_EventGridId");
                     EvtRowId = cgiGet( "_EventRowId");
                  }
                  if ( StringUtil.Len( sEvt) > 0 )
                  {
                     sEvtType = StringUtil.Left( sEvt, 1);
                     sEvt = StringUtil.Right( sEvt, (short)(StringUtil.Len( sEvt)-1));
                     if ( StringUtil.StrCmp(sEvtType, "E") == 0 )
                     {
                        sEvtType = StringUtil.Right( sEvt, 1);
                        if ( StringUtil.StrCmp(sEvtType, ".") == 0 )
                        {
                           sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-1));
                           if ( StringUtil.StrCmp(sEvt, "RFR") == 0 )
                           {
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP1Z0( ) ;
                              }
                              if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
                              {
                                 context.wbHandled = 1;
                                 if ( ! wbErr )
                                 {
                                    dynload_actions( ) ;
                                 }
                              }
                           }
                           else if ( StringUtil.StrCmp(sEvt, "START") == 0 )
                           {
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP1Z0( ) ;
                              }
                              if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
                              {
                                 context.wbHandled = 1;
                                 if ( ! wbErr )
                                 {
                                    dynload_actions( ) ;
                                    /* Execute user event: Start */
                                    E111Z2 ();
                                 }
                              }
                           }
                           else if ( StringUtil.StrCmp(sEvt, "LOAD") == 0 )
                           {
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP1Z0( ) ;
                              }
                              if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
                              {
                                 context.wbHandled = 1;
                                 if ( ! wbErr )
                                 {
                                    dynload_actions( ) ;
                                    /* Execute user event: Load */
                                    E121Z2 ();
                                 }
                              }
                           }
                           else if ( StringUtil.StrCmp(sEvt, "'DOSAVE'") == 0 )
                           {
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP1Z0( ) ;
                              }
                              if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
                              {
                                 context.wbHandled = 1;
                                 if ( ! wbErr )
                                 {
                                    dynload_actions( ) ;
                                    /* Execute user event: 'Dosave' */
                                    E131Z2 ();
                                 }
                              }
                           }
                           else if ( StringUtil.StrCmp(sEvt, "ENTER") == 0 )
                           {
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP1Z0( ) ;
                              }
                              if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
                              {
                                 context.wbHandled = 1;
                                 if ( ! wbErr )
                                 {
                                    if ( ! wbErr )
                                    {
                                       Rfr0gs = false;
                                       if ( ! Rfr0gs )
                                       {
                                       }
                                       dynload_actions( ) ;
                                    }
                                 }
                              }
                              /* No code required for Cancel button. It is implemented as the Reset button. */
                           }
                           else if ( StringUtil.StrCmp(sEvt, "LSCR") == 0 )
                           {
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP1Z0( ) ;
                              }
                              if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
                              {
                                 context.wbHandled = 1;
                                 if ( ! wbErr )
                                 {
                                    dynload_actions( ) ;
                                    GX_FocusControl = edtavBr_encounter_br_information_patientno_Internalname;
                                    context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "GX_FocusControl", GX_FocusControl);
                                 }
                              }
                              dynload_actions( ) ;
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
      }

      protected void WE1Z2( )
      {
         if ( ! GxWebStd.gx_redirect( context) )
         {
            Rfr0gs = true;
            Refresh( ) ;
            if ( ! GxWebStd.gx_redirect( context) )
            {
               RenderHtmlCloseForm1Z2( ) ;
            }
         }
      }

      protected void PA1Z2( )
      {
         if ( nDonePA == 0 )
         {
            if ( StringUtil.Len( sPrefix) != 0 )
            {
               initialize_properties( ) ;
            }
            if ( StringUtil.Len( sPrefix) == 0 )
            {
               if ( String.IsNullOrEmpty(StringUtil.RTrim( context.GetCookie( "GX_SESSION_ID"))) )
               {
                  gxcookieaux = context.SetCookie( "GX_SESSION_ID", Encrypt64( Crypto.GetEncryptionKey( ), Crypto.GetServerKey( )), "", (DateTime)(DateTime.MinValue), "", 0);
               }
            }
            GXKey = Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
            toggleJsOutput = isJsOutputEnabled( );
            if ( StringUtil.Len( sPrefix) == 0 )
            {
               if ( context.isSpaRequest( ) )
               {
                  disableJsOutput();
               }
            }
            init_web_controls( ) ;
            if ( StringUtil.Len( sPrefix) == 0 )
            {
               if ( toggleJsOutput )
               {
                  if ( context.isSpaRequest( ) )
                  {
                     enableJsOutput();
                  }
               }
            }
            if ( ! context.isAjaxRequest( ) )
            {
               GX_FocusControl = edtavBr_encounter_br_information_patientno_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "GX_FocusControl", GX_FocusControl);
            }
            nDonePA = 1;
         }
      }

      protected void dynload_actions( )
      {
         /* End function dynload_actions */
      }

      protected void GXDLVvVDEPARTMENTADM1Z2( String AV24tCurrentCode )
      {
         if ( ! context.isAjaxRequest( ) )
         {
            context.GX_webresponse.AppendHeader("Cache-Control", "no-store");
         }
         context.GX_webresponse.AddString("[[");
         GXDLVvVDEPARTMENTADM_data1Z2( AV24tCurrentCode) ;
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

      protected void GXVvVDEPARTMENTADM_html1Z2( String AV24tCurrentCode )
      {
         String gxdynajaxvalue ;
         GXDLVvVDEPARTMENTADM_data1Z2( AV24tCurrentCode) ;
         gxdynajaxindex = 1;
         if ( ! ( gxdyncontrolsrefreshing && context.isAjaxRequest( ) ) )
         {
            dynavVdepartmentadm.removeAllItems();
         }
         while ( gxdynajaxindex <= gxdynajaxctrlcodr.Count )
         {
            gxdynajaxvalue = ((String)gxdynajaxctrlcodr.Item(gxdynajaxindex));
            dynavVdepartmentadm.addItem(gxdynajaxvalue, ((String)gxdynajaxctrldescr.Item(gxdynajaxindex)), 0);
            gxdynajaxindex = (int)(gxdynajaxindex+1);
         }
      }

      protected void GXDLVvVDEPARTMENTADM_data1Z2( String AV24tCurrentCode )
      {
         gxdynajaxctrlcodr.Clear();
         gxdynajaxctrldescr.Clear();
         gxdynajaxctrlcodr.Add("");
         gxdynajaxctrldescr.Add("(请选择)");
         /* Using cursor H001Z2 */
         pr_default.execute(0, new Object[] {AV24tCurrentCode});
         while ( (pr_default.getStatus(0) != 101) )
         {
            gxdynajaxctrlcodr.Add(H001Z2_A168XT_DefineCodeName[0]);
            gxdynajaxctrldescr.Add(H001Z2_A168XT_DefineCodeName[0]);
            pr_default.readNext(0);
         }
         pr_default.close(0);
      }

      protected void GXDLVvVDEPARTMENTDISCH1Z2( String AV24tCurrentCode )
      {
         if ( ! context.isAjaxRequest( ) )
         {
            context.GX_webresponse.AppendHeader("Cache-Control", "no-store");
         }
         context.GX_webresponse.AddString("[[");
         GXDLVvVDEPARTMENTDISCH_data1Z2( AV24tCurrentCode) ;
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

      protected void GXVvVDEPARTMENTDISCH_html1Z2( String AV24tCurrentCode )
      {
         String gxdynajaxvalue ;
         GXDLVvVDEPARTMENTDISCH_data1Z2( AV24tCurrentCode) ;
         gxdynajaxindex = 1;
         if ( ! ( gxdyncontrolsrefreshing && context.isAjaxRequest( ) ) )
         {
            dynavVdepartmentdisch.removeAllItems();
         }
         while ( gxdynajaxindex <= gxdynajaxctrlcodr.Count )
         {
            gxdynajaxvalue = ((String)gxdynajaxctrlcodr.Item(gxdynajaxindex));
            dynavVdepartmentdisch.addItem(gxdynajaxvalue, ((String)gxdynajaxctrldescr.Item(gxdynajaxindex)), 0);
            gxdynajaxindex = (int)(gxdynajaxindex+1);
         }
      }

      protected void GXDLVvVDEPARTMENTDISCH_data1Z2( String AV24tCurrentCode )
      {
         gxdynajaxctrlcodr.Clear();
         gxdynajaxctrldescr.Clear();
         gxdynajaxctrlcodr.Add("");
         gxdynajaxctrldescr.Add("(请选择)");
         /* Using cursor H001Z3 */
         pr_default.execute(1, new Object[] {AV24tCurrentCode});
         while ( (pr_default.getStatus(1) != 101) )
         {
            gxdynajaxctrlcodr.Add(H001Z3_A168XT_DefineCodeName[0]);
            gxdynajaxctrldescr.Add(H001Z3_A168XT_DefineCodeName[0]);
            pr_default.readNext(1);
         }
         pr_default.close(1);
      }

      protected void GXDLVvVENCTYPE1Z2( String AV24tCurrentCode )
      {
         if ( ! context.isAjaxRequest( ) )
         {
            context.GX_webresponse.AppendHeader("Cache-Control", "no-store");
         }
         context.GX_webresponse.AddString("[[");
         GXDLVvVENCTYPE_data1Z2( AV24tCurrentCode) ;
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

      protected void GXVvVENCTYPE_html1Z2( String AV24tCurrentCode )
      {
         String gxdynajaxvalue ;
         GXDLVvVENCTYPE_data1Z2( AV24tCurrentCode) ;
         gxdynajaxindex = 1;
         if ( ! ( gxdyncontrolsrefreshing && context.isAjaxRequest( ) ) )
         {
            dynavVenctype.removeAllItems();
         }
         while ( gxdynajaxindex <= gxdynajaxctrlcodr.Count )
         {
            gxdynajaxvalue = ((String)gxdynajaxctrlcodr.Item(gxdynajaxindex));
            dynavVenctype.addItem(gxdynajaxvalue, ((String)gxdynajaxctrldescr.Item(gxdynajaxindex)), 0);
            gxdynajaxindex = (int)(gxdynajaxindex+1);
         }
      }

      protected void GXDLVvVENCTYPE_data1Z2( String AV24tCurrentCode )
      {
         gxdynajaxctrlcodr.Clear();
         gxdynajaxctrldescr.Clear();
         gxdynajaxctrlcodr.Add("");
         gxdynajaxctrldescr.Add("(请选择)");
         /* Using cursor H001Z4 */
         pr_default.execute(2, new Object[] {AV24tCurrentCode});
         while ( (pr_default.getStatus(2) != 101) )
         {
            gxdynajaxctrlcodr.Add(H001Z4_A168XT_DefineCodeName[0]);
            gxdynajaxctrldescr.Add(H001Z4_A168XT_DefineCodeName[0]);
            pr_default.readNext(2);
         }
         pr_default.close(2);
      }

      protected void GXDLVvVINSURANCE1Z2( String AV24tCurrentCode )
      {
         if ( ! context.isAjaxRequest( ) )
         {
            context.GX_webresponse.AppendHeader("Cache-Control", "no-store");
         }
         context.GX_webresponse.AddString("[[");
         GXDLVvVINSURANCE_data1Z2( AV24tCurrentCode) ;
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

      protected void GXVvVINSURANCE_html1Z2( String AV24tCurrentCode )
      {
         String gxdynajaxvalue ;
         GXDLVvVINSURANCE_data1Z2( AV24tCurrentCode) ;
         gxdynajaxindex = 1;
         if ( ! ( gxdyncontrolsrefreshing && context.isAjaxRequest( ) ) )
         {
            dynavVinsurance.removeAllItems();
         }
         while ( gxdynajaxindex <= gxdynajaxctrlcodr.Count )
         {
            gxdynajaxvalue = ((String)gxdynajaxctrlcodr.Item(gxdynajaxindex));
            dynavVinsurance.addItem(gxdynajaxvalue, ((String)gxdynajaxctrldescr.Item(gxdynajaxindex)), 0);
            gxdynajaxindex = (int)(gxdynajaxindex+1);
         }
      }

      protected void GXDLVvVINSURANCE_data1Z2( String AV24tCurrentCode )
      {
         gxdynajaxctrlcodr.Clear();
         gxdynajaxctrldescr.Clear();
         gxdynajaxctrlcodr.Add("");
         gxdynajaxctrldescr.Add("(请选择)");
         /* Using cursor H001Z5 */
         pr_default.execute(3, new Object[] {AV24tCurrentCode});
         while ( (pr_default.getStatus(3) != 101) )
         {
            gxdynajaxctrlcodr.Add(H001Z5_A168XT_DefineCodeName[0]);
            gxdynajaxctrldescr.Add(H001Z5_A168XT_DefineCodeName[0]);
            pr_default.readNext(3);
         }
         pr_default.close(3);
      }

      protected void GXDLVvVREASON1Z2( String AV24tCurrentCode )
      {
         if ( ! context.isAjaxRequest( ) )
         {
            context.GX_webresponse.AppendHeader("Cache-Control", "no-store");
         }
         context.GX_webresponse.AddString("[[");
         GXDLVvVREASON_data1Z2( AV24tCurrentCode) ;
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

      protected void GXVvVREASON_html1Z2( String AV24tCurrentCode )
      {
         String gxdynajaxvalue ;
         GXDLVvVREASON_data1Z2( AV24tCurrentCode) ;
         gxdynajaxindex = 1;
         if ( ! ( gxdyncontrolsrefreshing && context.isAjaxRequest( ) ) )
         {
            dynavVreason.removeAllItems();
         }
         while ( gxdynajaxindex <= gxdynajaxctrlcodr.Count )
         {
            gxdynajaxvalue = ((String)gxdynajaxctrlcodr.Item(gxdynajaxindex));
            dynavVreason.addItem(gxdynajaxvalue, ((String)gxdynajaxctrldescr.Item(gxdynajaxindex)), 0);
            gxdynajaxindex = (int)(gxdynajaxindex+1);
         }
      }

      protected void GXDLVvVREASON_data1Z2( String AV24tCurrentCode )
      {
         gxdynajaxctrlcodr.Clear();
         gxdynajaxctrldescr.Clear();
         gxdynajaxctrlcodr.Add("");
         gxdynajaxctrldescr.Add("(请选择)");
         /* Using cursor H001Z6 */
         pr_default.execute(4, new Object[] {AV24tCurrentCode});
         while ( (pr_default.getStatus(4) != 101) )
         {
            gxdynajaxctrlcodr.Add(H001Z6_A168XT_DefineCodeName[0]);
            gxdynajaxctrldescr.Add(H001Z6_A168XT_DefineCodeName[0]);
            pr_default.readNext(4);
         }
         pr_default.close(4);
      }

      protected void GXDLVBR_ENCOUNTER_BR_ENCOUNTER_DISCHARGESTATUS1Z2( String AV24tCurrentCode )
      {
         if ( ! context.isAjaxRequest( ) )
         {
            context.GX_webresponse.AppendHeader("Cache-Control", "no-store");
         }
         context.GX_webresponse.AddString("[[");
         GXDLVBR_ENCOUNTER_BR_ENCOUNTER_DISCHARGESTATUS_data1Z2( AV24tCurrentCode) ;
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

      protected void GXVBR_ENCOUNTER_BR_ENCOUNTER_DISCHARGESTATUS_html1Z2( String AV24tCurrentCode )
      {
         String gxdynajaxvalue ;
         GXDLVBR_ENCOUNTER_BR_ENCOUNTER_DISCHARGESTATUS_data1Z2( AV24tCurrentCode) ;
         gxdynajaxindex = 1;
         if ( ! ( gxdyncontrolsrefreshing && context.isAjaxRequest( ) ) )
         {
            dynavBr_encounter_br_encounter_dischargestatus.removeAllItems();
         }
         while ( gxdynajaxindex <= gxdynajaxctrlcodr.Count )
         {
            gxdynajaxvalue = ((String)gxdynajaxctrlcodr.Item(gxdynajaxindex));
            dynavBr_encounter_br_encounter_dischargestatus.addItem(gxdynajaxvalue, ((String)gxdynajaxctrldescr.Item(gxdynajaxindex)), 0);
            gxdynajaxindex = (int)(gxdynajaxindex+1);
         }
      }

      protected void GXDLVBR_ENCOUNTER_BR_ENCOUNTER_DISCHARGESTATUS_data1Z2( String AV24tCurrentCode )
      {
         gxdynajaxctrlcodr.Clear();
         gxdynajaxctrldescr.Clear();
         gxdynajaxctrlcodr.Add("");
         gxdynajaxctrldescr.Add("(请选择)");
         /* Using cursor H001Z7 */
         pr_default.execute(5, new Object[] {AV24tCurrentCode});
         while ( (pr_default.getStatus(5) != 101) )
         {
            gxdynajaxctrlcodr.Add(H001Z7_A168XT_DefineCodeName[0]);
            gxdynajaxctrldescr.Add(H001Z7_A168XT_DefineCodeName[0]);
            pr_default.readNext(5);
         }
         pr_default.close(5);
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
         if ( dynavVdepartmentadm.ItemCount > 0 )
         {
            AV27vDepartmentadm = dynavVdepartmentadm.getValidValue(AV27vDepartmentadm);
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV27vDepartmentadm", AV27vDepartmentadm);
         }
         if ( context.isAjaxRequest( ) )
         {
            dynavVdepartmentadm.CurrentValue = StringUtil.RTrim( AV27vDepartmentadm);
            context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, dynavVdepartmentadm_Internalname, "Values", dynavVdepartmentadm.ToJavascriptSource(), true);
         }
         if ( dynavVdepartmentdisch.ItemCount > 0 )
         {
            AV30vDepartmentdisch = dynavVdepartmentdisch.getValidValue(AV30vDepartmentdisch);
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV30vDepartmentdisch", AV30vDepartmentdisch);
         }
         if ( context.isAjaxRequest( ) )
         {
            dynavVdepartmentdisch.CurrentValue = StringUtil.RTrim( AV30vDepartmentdisch);
            context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, dynavVdepartmentdisch_Internalname, "Values", dynavVdepartmentdisch.ToJavascriptSource(), true);
         }
         if ( dynavVenctype.ItemCount > 0 )
         {
            AV18vENCType = dynavVenctype.getValidValue(AV18vENCType);
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV18vENCType", AV18vENCType);
         }
         if ( context.isAjaxRequest( ) )
         {
            dynavVenctype.CurrentValue = StringUtil.RTrim( AV18vENCType);
            context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, dynavVenctype_Internalname, "Values", dynavVenctype.ToJavascriptSource(), true);
         }
         if ( dynavVinsurance.ItemCount > 0 )
         {
            AV31vInsurance = dynavVinsurance.getValidValue(AV31vInsurance);
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV31vInsurance", AV31vInsurance);
         }
         if ( context.isAjaxRequest( ) )
         {
            dynavVinsurance.CurrentValue = StringUtil.RTrim( AV31vInsurance);
            context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, dynavVinsurance_Internalname, "Values", dynavVinsurance.ToJavascriptSource(), true);
         }
         if ( dynavVreason.ItemCount > 0 )
         {
            AV22vReason = dynavVreason.getValidValue(AV22vReason);
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV22vReason", AV22vReason);
         }
         if ( context.isAjaxRequest( ) )
         {
            dynavVreason.CurrentValue = StringUtil.RTrim( AV22vReason);
            context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, dynavVreason_Internalname, "Values", dynavVreason.ToJavascriptSource(), true);
         }
         if ( dynavBr_encounter_br_encounter_dischargestatus.ItemCount > 0 )
         {
            AV14BR_Encounter.gxTpr_Br_encounter_dischargestatus = dynavBr_encounter_br_encounter_dischargestatus.getValidValue(AV14BR_Encounter.gxTpr_Br_encounter_dischargestatus);
         }
         if ( context.isAjaxRequest( ) )
         {
            dynavBr_encounter_br_encounter_dischargestatus.CurrentValue = StringUtil.RTrim( AV14BR_Encounter.gxTpr_Br_encounter_dischargestatus);
            context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, dynavBr_encounter_br_encounter_dischargestatus_Internalname, "Values", dynavBr_encounter_br_encounter_dischargestatus.ToJavascriptSource(), true);
         }
      }

      public void Refresh( )
      {
         send_integrity_hashes( ) ;
         RF1Z2( ) ;
         if ( isFullAjaxMode( ) )
         {
            send_integrity_footer_hashes( ) ;
         }
      }

      protected void initialize_formulas( )
      {
         /* GeneXus formulas. */
         AV44Pgmname = "BR_EncounterUpdateGeneral";
         context.Gx_err = 0;
         edtavBr_encounter_br_information_patientno_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavBr_encounter_br_information_patientno_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavBr_encounter_br_information_patientno_Enabled), 5, 0)), true);
         edtavBr_encounter_br_encounter_encid_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavBr_encounter_br_encounter_encid_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavBr_encounter_br_encounter_encid_Enabled), 5, 0)), true);
      }

      protected void RF1Z2( )
      {
         initialize_formulas( ) ;
         clear_multi_value_controls( ) ;
         gxdyncontrolsrefreshing = true;
         fix_multi_value_controls( ) ;
         gxdyncontrolsrefreshing = false;
         if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
         {
            /* Using cursor H001Z8 */
            pr_default.execute(6, new Object[] {A19BR_EncounterID});
            while ( (pr_default.getStatus(6) != 101) )
            {
               GXVvVDEPARTMENTADM_html1Z2( AV24tCurrentCode) ;
               GXVvVDEPARTMENTDISCH_html1Z2( AV24tCurrentCode) ;
               GXVvVENCTYPE_html1Z2( AV24tCurrentCode) ;
               GXVvVINSURANCE_html1Z2( AV24tCurrentCode) ;
               GXVvVREASON_html1Z2( AV24tCurrentCode) ;
               GXVBR_ENCOUNTER_BR_ENCOUNTER_DISCHARGESTATUS_html1Z2( AV24tCurrentCode) ;
               /* Execute user event: Load */
               E121Z2 ();
               /* Exiting from a For First loop. */
               if (true) break;
            }
            pr_default.close(6);
            WB1Z0( ) ;
         }
      }

      protected void send_integrity_lvl_hashes1Z2( )
      {
      }

      protected void STRUP1Z0( )
      {
         /* Before Start, stand alone formulas. */
         AV44Pgmname = "BR_EncounterUpdateGeneral";
         context.Gx_err = 0;
         edtavBr_encounter_br_information_patientno_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavBr_encounter_br_information_patientno_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavBr_encounter_br_information_patientno_Enabled), 5, 0)), true);
         edtavBr_encounter_br_encounter_encid_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavBr_encounter_br_encounter_encid_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavBr_encounter_br_encounter_encid_Enabled), 5, 0)), true);
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0;
         /* Execute user event: Start */
         E111Z2 ();
         context.wbGlbDoneStart = 1;
         nDoneStart = 1;
         /* After Start, stand alone formulas. */
         GXVvVDEPARTMENTADM_html1Z2( AV24tCurrentCode) ;
         GXVvVDEPARTMENTDISCH_html1Z2( AV24tCurrentCode) ;
         GXVvVENCTYPE_html1Z2( AV24tCurrentCode) ;
         GXVvVINSURANCE_html1Z2( AV24tCurrentCode) ;
         GXVvVREASON_html1Z2( AV24tCurrentCode) ;
         GXVBR_ENCOUNTER_BR_ENCOUNTER_DISCHARGESTATUS_html1Z2( AV24tCurrentCode) ;
         sXEvt = cgiGet( "_EventName");
         if ( ! GetJustCreated( ) && ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 ) )
         {
            /* Read saved SDTs. */
            ajax_req_read_hidden_sdt(cgiGet( sPrefix+"Br_encounter"), AV14BR_Encounter);
            /* Read variables values. */
            AV14BR_Encounter.gxTpr_Br_information_patientno = cgiGet( edtavBr_encounter_br_information_patientno_Internalname);
            if ( ( ( context.localUtil.CToN( cgiGet( edtavBr_encounter_br_encounter_encid_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavBr_encounter_br_encounter_encid_Internalname), ".", ",") > Convert.ToDecimal( 9999999999L )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "BR_ENCOUNTER_BR_ENCOUNTER_ENCID");
               GX_FocusControl = edtavBr_encounter_br_encounter_encid_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV14BR_Encounter.gxTpr_Br_encounter_encid = 0;
            }
            else
            {
               AV14BR_Encounter.gxTpr_Br_encounter_encid = (long)(context.localUtil.CToN( cgiGet( edtavBr_encounter_br_encounter_encid_Internalname), ".", ","));
            }
            dynavVdepartmentadm.CurrentValue = cgiGet( dynavVdepartmentadm_Internalname);
            AV27vDepartmentadm = cgiGet( dynavVdepartmentadm_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV27vDepartmentadm", AV27vDepartmentadm);
            AV28vOtherDepartmentadm = cgiGet( edtavVotherdepartmentadm_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV28vOtherDepartmentadm", AV28vOtherDepartmentadm);
            dynavVdepartmentdisch.CurrentValue = cgiGet( dynavVdepartmentdisch_Internalname);
            AV30vDepartmentdisch = cgiGet( dynavVdepartmentdisch_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV30vDepartmentdisch", AV30vDepartmentdisch);
            AV29vOtherDepartmentadisch = cgiGet( edtavVotherdepartmentadisch_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV29vOtherDepartmentadisch", AV29vOtherDepartmentadisch);
            dynavVenctype.CurrentValue = cgiGet( dynavVenctype_Internalname);
            AV18vENCType = cgiGet( dynavVenctype_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV18vENCType", AV18vENCType);
            AV19vOtherENCType = cgiGet( edtavVotherenctype_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV19vOtherENCType", AV19vOtherENCType);
            dynavVinsurance.CurrentValue = cgiGet( dynavVinsurance_Internalname);
            AV31vInsurance = cgiGet( dynavVinsurance_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV31vInsurance", AV31vInsurance);
            AV32vOtherInsurance = cgiGet( edtavVotherinsurance_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV32vOtherInsurance", AV32vOtherInsurance);
            dynavVreason.CurrentValue = cgiGet( dynavVreason_Internalname);
            AV22vReason = cgiGet( dynavVreason_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV22vReason", AV22vReason);
            AV23vOtherReason = cgiGet( edtavVotherreason_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV23vOtherReason", AV23vOtherReason);
            if ( context.localUtil.VCDate( cgiGet( edtavBr_encounter_br_encounter_admitdate_Internalname), 0) == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_faildate", new   object[]  {"就诊/入院时间"}), 1, "BR_ENCOUNTER_BR_ENCOUNTER_ADMITDATE");
               GX_FocusControl = edtavBr_encounter_br_encounter_admitdate_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV14BR_Encounter.gxTpr_Br_encounter_admitdate = DateTime.MinValue;
            }
            else
            {
               AV14BR_Encounter.gxTpr_Br_encounter_admitdate = context.localUtil.CToD( cgiGet( edtavBr_encounter_br_encounter_admitdate_Internalname), 0);
            }
            if ( context.localUtil.VCDate( cgiGet( edtavBr_encounter_br_encounter_dischargedate_Internalname), 0) == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_faildate", new   object[]  {"出院时间"}), 1, "BR_ENCOUNTER_BR_ENCOUNTER_DISCHARGEDATE");
               GX_FocusControl = edtavBr_encounter_br_encounter_dischargedate_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV14BR_Encounter.gxTpr_Br_encounter_dischargedate = DateTime.MinValue;
            }
            else
            {
               AV14BR_Encounter.gxTpr_Br_encounter_dischargedate = context.localUtil.CToD( cgiGet( edtavBr_encounter_br_encounter_dischargedate_Internalname), 0);
            }
            dynavBr_encounter_br_encounter_dischargestatus.CurrentValue = cgiGet( dynavBr_encounter_br_encounter_dischargestatus_Internalname);
            AV14BR_Encounter.gxTpr_Br_encounter_dischargestatus = cgiGet( dynavBr_encounter_br_encounter_dischargestatus_Internalname);
            if ( ( ( context.localUtil.CToN( cgiGet( edtavBr_encounter_br_encounterid_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavBr_encounter_br_encounterid_Internalname), ".", ",") > Convert.ToDecimal( 999999999999999999L )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "BR_ENCOUNTER_BR_ENCOUNTERID");
               GX_FocusControl = edtavBr_encounter_br_encounterid_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV14BR_Encounter.gxTpr_Br_encounterid = 0;
            }
            else
            {
               AV14BR_Encounter.gxTpr_Br_encounterid = (long)(context.localUtil.CToN( cgiGet( edtavBr_encounter_br_encounterid_Internalname), ".", ","));
            }
            AV16vDepartment = cgiGet( edtavVdepartment_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV16vDepartment", AV16vDepartment);
            AV17vOtherDepartment = cgiGet( edtavVotherdepartment_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV17vOtherDepartment", AV17vOtherDepartment);
            if ( ( ( context.localUtil.CToN( cgiGet( edtavBr_encounter_br_information_id_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavBr_encounter_br_information_id_Internalname), ".", ",") > Convert.ToDecimal( 999999999999999999L )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "BR_ENCOUNTER_BR_INFORMATION_ID");
               GX_FocusControl = edtavBr_encounter_br_information_id_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV14BR_Encounter.gxTpr_Br_information_id = 0;
            }
            else
            {
               AV14BR_Encounter.gxTpr_Br_information_id = (long)(context.localUtil.CToN( cgiGet( edtavBr_encounter_br_information_id_Internalname), ".", ","));
            }
            /* Read saved values. */
            wcpOA19BR_EncounterID = (long)(context.localUtil.CToN( cgiGet( sPrefix+"wcpOA19BR_EncounterID"), ".", ","));
            A19BR_EncounterID = (long)(context.localUtil.CToN( cgiGet( sPrefix+"BR_ENCOUNTERID"), ".", ","));
            Dvpanel_unnamedtable1_Width = cgiGet( sPrefix+"DVPANEL_UNNAMEDTABLE1_Width");
            Dvpanel_unnamedtable1_Cls = cgiGet( sPrefix+"DVPANEL_UNNAMEDTABLE1_Cls");
            Dvpanel_unnamedtable1_Title = cgiGet( sPrefix+"DVPANEL_UNNAMEDTABLE1_Title");
            Dvpanel_unnamedtable1_Collapsible = StringUtil.StrToBool( cgiGet( sPrefix+"DVPANEL_UNNAMEDTABLE1_Collapsible"));
            Dvpanel_unnamedtable1_Collapsed = StringUtil.StrToBool( cgiGet( sPrefix+"DVPANEL_UNNAMEDTABLE1_Collapsed"));
            Dvpanel_unnamedtable1_Autowidth = StringUtil.StrToBool( cgiGet( sPrefix+"DVPANEL_UNNAMEDTABLE1_Autowidth"));
            Dvpanel_unnamedtable1_Autoheight = StringUtil.StrToBool( cgiGet( sPrefix+"DVPANEL_UNNAMEDTABLE1_Autoheight"));
            Dvpanel_unnamedtable1_Showcollapseicon = StringUtil.StrToBool( cgiGet( sPrefix+"DVPANEL_UNNAMEDTABLE1_Showcollapseicon"));
            Dvpanel_unnamedtable1_Iconposition = cgiGet( sPrefix+"DVPANEL_UNNAMEDTABLE1_Iconposition");
            Dvpanel_unnamedtable1_Autoscroll = StringUtil.StrToBool( cgiGet( sPrefix+"DVPANEL_UNNAMEDTABLE1_Autoscroll"));
            /* Read subfile selected row values. */
            /* Read hidden variables. */
            GXKey = Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
            GXVvVDEPARTMENTADM_html1Z2( AV24tCurrentCode) ;
            GXVvVDEPARTMENTDISCH_html1Z2( AV24tCurrentCode) ;
            GXVvVENCTYPE_html1Z2( AV24tCurrentCode) ;
            GXVvVINSURANCE_html1Z2( AV24tCurrentCode) ;
            GXVvVREASON_html1Z2( AV24tCurrentCode) ;
            GXVBR_ENCOUNTER_BR_ENCOUNTER_DISCHARGESTATUS_html1Z2( AV24tCurrentCode) ;
         }
         else
         {
            dynload_actions( ) ;
         }
      }

      protected void GXStart( )
      {
         /* Execute user event: Start */
         E111Z2 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E111Z2( )
      {
         /* Start Routine */
         GXt_char1 = AV24tCurrentCode;
         new zbr_getcurrenttcode(context ).execute( out  GXt_char1) ;
         AV24tCurrentCode = GXt_char1;
         AV14BR_Encounter.Load(A19BR_EncounterID);
         new GeneXus.Programs.wwpbaseobjects.loadwwpcontext(context ).execute( out  AV6WWPContext) ;
         /* Execute user subroutine: 'PREPARETRANSACTION' */
         S112 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
         edtavVotherdepartment_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavVotherdepartment_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavVotherdepartment_Visible), 5, 0)), true);
         edtavVotherenctype_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavVotherenctype_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavVotherenctype_Visible), 5, 0)), true);
         edtavVotherreason_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavVotherreason_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavVotherreason_Visible), 5, 0)), true);
         edtavVotherdepartmentadm_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavVotherdepartmentadm_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavVotherdepartmentadm_Visible), 5, 0)), true);
         edtavVotherdepartmentadisch_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavVotherdepartmentadisch_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavVotherdepartmentadisch_Visible), 5, 0)), true);
         edtavVotherinsurance_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavVotherinsurance_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavVotherinsurance_Visible), 5, 0)), true);
      }

      protected void nextLoad( )
      {
      }

      protected void E121Z2( )
      {
         /* Load Routine */
         edtavBr_encounter_br_encounterid_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavBr_encounter_br_encounterid_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavBr_encounter_br_encounterid_Visible), 5, 0)), true);
         edtavVdepartment_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavVdepartment_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavVdepartment_Visible), 5, 0)), true);
         edtavVotherdepartment_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavVotherdepartment_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavVotherdepartment_Visible), 5, 0)), true);
         edtavBr_encounter_br_information_id_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavBr_encounter_br_information_id_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavBr_encounter_br_information_id_Visible), 5, 0)), true);
         if ( ! ( new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context).executeUdp(  "BR_CheckHistory") ) )
         {
            divDvpanel_unnamedtable1_cell_Class = "Invisible";
            context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, divDvpanel_unnamedtable1_cell_Internalname, "Class", divDvpanel_unnamedtable1_cell_Class, true);
         }
         else
         {
            divDvpanel_unnamedtable1_cell_Class = "col-xs-12";
            context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, divDvpanel_unnamedtable1_cell_Internalname, "Class", divDvpanel_unnamedtable1_cell_Class, true);
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV14BR_Encounter.gxTpr_Br_encounter_departmentadm)) )
         {
            dynavVdepartmentadm.addItem(AV14BR_Encounter.gxTpr_Br_encounter_departmentadm, AV14BR_Encounter.gxTpr_Br_encounter_departmentadm, 0);
            AV27vDepartmentadm = AV14BR_Encounter.gxTpr_Br_encounter_departmentadm;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV27vDepartmentadm", AV27vDepartmentadm);
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV14BR_Encounter.gxTpr_Br_encounter_departmentdisch)) )
         {
            dynavVdepartmentdisch.addItem(AV14BR_Encounter.gxTpr_Br_encounter_departmentdisch, AV14BR_Encounter.gxTpr_Br_encounter_departmentdisch, 0);
            AV30vDepartmentdisch = AV14BR_Encounter.gxTpr_Br_encounter_departmentdisch;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV30vDepartmentdisch", AV30vDepartmentdisch);
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV14BR_Encounter.gxTpr_Br_encounter_insurance)) )
         {
            dynavVinsurance.addItem(AV14BR_Encounter.gxTpr_Br_encounter_insurance, AV14BR_Encounter.gxTpr_Br_encounter_insurance, 0);
            AV31vInsurance = AV14BR_Encounter.gxTpr_Br_encounter_insurance;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV31vInsurance", AV31vInsurance);
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV14BR_Encounter.gxTpr_Br_encounter_enctype)) )
         {
            dynavVenctype.addItem(AV14BR_Encounter.gxTpr_Br_encounter_enctype, AV14BR_Encounter.gxTpr_Br_encounter_enctype, 0);
            AV18vENCType = AV14BR_Encounter.gxTpr_Br_encounter_enctype;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV18vENCType", AV18vENCType);
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV14BR_Encounter.gxTpr_Br_encounter_admitsource)) )
         {
            dynavVreason.addItem(AV14BR_Encounter.gxTpr_Br_encounter_admitsource, AV14BR_Encounter.gxTpr_Br_encounter_admitsource, 0);
            AV22vReason = AV14BR_Encounter.gxTpr_Br_encounter_admitsource;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV22vReason", AV22vReason);
         }
      }

      protected void E131Z2( )
      {
         /* 'Dosave' Routine */
         new zutil_checksession(context ).execute( out  AV26tCheckFlag) ;
         if ( ! AV26tCheckFlag )
         {
            AV15tFlag = true;
            if ( ( StringUtil.StrCmp(AV27vDepartmentadm, "其它") == 0 ) && ( AV15tFlag ) )
            {
               if ( String.IsNullOrEmpty(StringUtil.RTrim( AV27vDepartmentadm)) )
               {
                  GX_msglist.addItem("其它入院科室是必须填写的");
                  AV15tFlag = false;
               }
               else
               {
                  AV14BR_Encounter.gxTpr_Br_encounter_departmentadm = AV28vOtherDepartmentadm;
               }
            }
            else
            {
               AV14BR_Encounter.gxTpr_Br_encounter_departmentadm = AV27vDepartmentadm;
            }
            if ( ( StringUtil.StrCmp(AV30vDepartmentdisch, "其它") == 0 ) && ( AV15tFlag ) )
            {
               if ( String.IsNullOrEmpty(StringUtil.RTrim( AV30vDepartmentdisch)) )
               {
                  GX_msglist.addItem("其它出院科室是必须填写的");
                  AV15tFlag = false;
               }
               else
               {
                  AV14BR_Encounter.gxTpr_Br_encounter_departmentdisch = AV29vOtherDepartmentadisch;
               }
            }
            else
            {
               AV14BR_Encounter.gxTpr_Br_encounter_departmentdisch = AV30vDepartmentdisch;
            }
            if ( ( StringUtil.StrCmp(AV31vInsurance, "其它") == 0 ) && ( AV15tFlag ) )
            {
               if ( String.IsNullOrEmpty(StringUtil.RTrim( AV30vDepartmentdisch)) )
               {
                  GX_msglist.addItem("其它保险类型是必须填写的");
                  AV15tFlag = false;
               }
               else
               {
                  AV14BR_Encounter.gxTpr_Br_encounter_insurance = AV32vOtherInsurance;
               }
            }
            else
            {
               AV14BR_Encounter.gxTpr_Br_encounter_insurance = AV31vInsurance;
            }
            if ( ( StringUtil.StrCmp(AV18vENCType, "其它") == 0 ) && ( AV15tFlag ) )
            {
               if ( String.IsNullOrEmpty(StringUtil.RTrim( AV19vOtherENCType)) )
               {
                  GX_msglist.addItem("其它就诊方式是必须填写的");
                  AV15tFlag = false;
               }
               else
               {
                  AV14BR_Encounter.gxTpr_Br_encounter_enctype = AV19vOtherENCType;
               }
            }
            else
            {
               AV14BR_Encounter.gxTpr_Br_encounter_enctype = AV18vENCType;
            }
            if ( ( StringUtil.StrCmp(AV22vReason, "其它") == 0 ) && ( AV15tFlag ) )
            {
               if ( String.IsNullOrEmpty(StringUtil.RTrim( AV23vOtherReason)) )
               {
                  GX_msglist.addItem("其它入院原因是必须填写的");
                  AV15tFlag = false;
               }
               else
               {
                  AV14BR_Encounter.gxTpr_Br_encounter_admitsource = AV23vOtherReason;
               }
            }
            else
            {
               AV14BR_Encounter.gxTpr_Br_encounter_admitsource = AV22vReason;
            }
            if ( AV15tFlag )
            {
               if ( (DateTime.MinValue==AV14BR_Encounter.gxTpr_Br_encounter_admitdate) )
               {
                  AV14BR_Encounter.gxTv_SdtBR_Encounter_Br_encounter_admitdate_SetNull();
               }
               if ( (DateTime.MinValue==AV14BR_Encounter.gxTpr_Br_encounter_dischargedate) )
               {
                  AV14BR_Encounter.gxTv_SdtBR_Encounter_Br_encounter_dischargedate_SetNull();
               }
               AV14BR_Encounter.Save();
               if ( AV14BR_Encounter.Success() )
               {
                  context.CommitDataStores("br_encounterupdategeneral",pr_default);
                  GX_msglist.addItem("保存成功");
                  new zutil_recordlog(context ).execute(  StringUtil.Str( (decimal)(AV14BR_Encounter.gxTpr_Br_encounterid), 18, 0),  "就诊信息",  "Update",  1) ;
                  AV14BR_Encounter.Load(A19BR_EncounterID);
               }
               else
               {
                  AV20ErrorMsg = "";
                  AV43GXV9 = 1;
                  AV42GXV8 = AV14BR_Encounter.GetMessages();
                  while ( AV43GXV9 <= AV42GXV8.Count )
                  {
                     AV21Message = ((SdtMessages_Message)AV42GXV8.Item(AV43GXV9));
                     AV20ErrorMsg = AV20ErrorMsg + StringUtil.Trim( AV21Message.gxTpr_Description);
                     AV43GXV9 = (int)(AV43GXV9+1);
                  }
                  GX_msglist.addItem(StringUtil.Trim( AV20ErrorMsg));
               }
            }
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV14BR_Encounter", AV14BR_Encounter);
      }

      protected void S112( )
      {
         /* 'PREPARETRANSACTION' Routine */
         AV9TrnContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext(context);
         AV9TrnContext.gxTpr_Callerobject = AV44Pgmname;
         AV9TrnContext.gxTpr_Callerondelete = false;
         AV9TrnContext.gxTpr_Callerurl = AV12HTTPRequest.ScriptName+"?"+AV12HTTPRequest.QueryString;
         AV9TrnContext.gxTpr_Transactionname = "BR_Encounter";
         AV10TrnContextAtt = new GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext_Attribute(context);
         AV10TrnContextAtt.gxTpr_Attributename = "BR_EncounterID";
         AV10TrnContextAtt.gxTpr_Attributevalue = StringUtil.Str( (decimal)(AV8BR_EncounterID), 18, 0);
         AV9TrnContext.gxTpr_Attributes.Add(AV10TrnContextAtt, 0);
         AV11Session.Set("TrnContext", AV9TrnContext.ToXml(false, true, "WWPTransactionContext", "DataAnalysisPlatform"));
      }

      protected void wb_table6_95_1Z2( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "";
            GxWebStd.gx_table_start( context, tblTablemergedvreason_Internalname, tblTablemergedvreason_Internalname, "", "TableMerged", 0, "", "", 0, 0, sStyleString, "", "", 0);
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td class='MergeDataCell'>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, dynavVreason_Internalname, "v Reason", "col-sm-3 AttributeLabel", 0, true);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 99,'" + sPrefix + "',false,'',0)\"";
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, dynavVreason, dynavVreason_Internalname, StringUtil.RTrim( AV22vReason), 1, dynavVreason_Jsonclick, 0, "'"+sPrefix+"'"+",false,"+"'"+""+"'", "svchar", "", 1, dynavVreason.Enabled, 0, 0, 0, "em", 0, "", "", "Attribute", "", "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,99);\"", "", true, "HLP_BR_EncounterUpdateGeneral.htm");
            dynavVreason.CurrentValue = StringUtil.RTrim( AV22vReason);
            context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, dynavVreason_Internalname, "Values", (String)(dynavVreason.ToJavascriptSource()), true);
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td class='RequiredDataContentCell'>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavVotherreason_Internalname, "v Other Reason", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 102,'" + sPrefix + "',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavVotherreason_Internalname, AV23vOtherReason, StringUtil.RTrim( context.localUtil.Format( AV23vOtherReason, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,102);\"", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "请填写其他入院原因", edtavVotherreason_Jsonclick, 0, "Attribute", "", "", "", "", edtavVotherreason_Visible, edtavVotherreason_Enabled, 0, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_BR_EncounterUpdateGeneral.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table6_95_1Z2e( true) ;
         }
         else
         {
            wb_table6_95_1Z2e( false) ;
         }
      }

      protected void wb_table5_80_1Z2( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "";
            GxWebStd.gx_table_start( context, tblTablemergedvinsurance_Internalname, tblTablemergedvinsurance_Internalname, "", "TableMerged", 0, "", "", 0, 0, sStyleString, "", "", 0);
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td class='MergeDataCell'>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, dynavVinsurance_Internalname, "v Insurance", "col-sm-3 AttributeLabel", 0, true);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 84,'" + sPrefix + "',false,'',0)\"";
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, dynavVinsurance, dynavVinsurance_Internalname, StringUtil.RTrim( AV31vInsurance), 1, dynavVinsurance_Jsonclick, 0, "'"+sPrefix+"'"+",false,"+"'"+""+"'", "svchar", "", 1, dynavVinsurance.Enabled, 0, 0, 0, "em", 0, "", "", "Attribute", "", "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,84);\"", "", true, "HLP_BR_EncounterUpdateGeneral.htm");
            dynavVinsurance.CurrentValue = StringUtil.RTrim( AV31vInsurance);
            context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, dynavVinsurance_Internalname, "Values", (String)(dynavVinsurance.ToJavascriptSource()), true);
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td class='RequiredDataContentCell'>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavVotherinsurance_Internalname, "v Other Insurance", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 87,'" + sPrefix + "',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavVotherinsurance_Internalname, AV32vOtherInsurance, StringUtil.RTrim( context.localUtil.Format( AV32vOtherInsurance, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,87);\"", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "请填写其保险类型", edtavVotherinsurance_Jsonclick, 0, "Attribute", "", "", "", "", edtavVotherinsurance_Visible, edtavVotherinsurance_Enabled, 0, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_BR_EncounterUpdateGeneral.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table5_80_1Z2e( true) ;
         }
         else
         {
            wb_table5_80_1Z2e( false) ;
         }
      }

      protected void wb_table4_66_1Z2( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "";
            GxWebStd.gx_table_start( context, tblTablemergedvenctype_Internalname, tblTablemergedvenctype_Internalname, "", "TableMerged", 0, "", "", 0, 0, sStyleString, "", "", 0);
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td class='MergeDataCell'>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, dynavVenctype_Internalname, "v ENCType", "col-sm-3 AttributeLabel", 0, true);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 70,'" + sPrefix + "',false,'',0)\"";
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, dynavVenctype, dynavVenctype_Internalname, StringUtil.RTrim( AV18vENCType), 1, dynavVenctype_Jsonclick, 0, "'"+sPrefix+"'"+",false,"+"'"+""+"'", "svchar", "", 1, dynavVenctype.Enabled, 0, 0, 0, "em", 0, "", "", "Attribute", "", "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,70);\"", "", true, "HLP_BR_EncounterUpdateGeneral.htm");
            dynavVenctype.CurrentValue = StringUtil.RTrim( AV18vENCType);
            context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, dynavVenctype_Internalname, "Values", (String)(dynavVenctype.ToJavascriptSource()), true);
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td class='RequiredDataContentCell'>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavVotherenctype_Internalname, "v Other ENCType", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 73,'" + sPrefix + "',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavVotherenctype_Internalname, AV19vOtherENCType, StringUtil.RTrim( context.localUtil.Format( AV19vOtherENCType, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,73);\"", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavVotherenctype_Jsonclick, 0, "Attribute", "", "", "", "", edtavVotherenctype_Visible, edtavVotherenctype_Enabled, 0, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_BR_EncounterUpdateGeneral.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table4_66_1Z2e( true) ;
         }
         else
         {
            wb_table4_66_1Z2e( false) ;
         }
      }

      protected void wb_table3_51_1Z2( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "";
            GxWebStd.gx_table_start( context, tblTablemergedvdepartmentdisch_Internalname, tblTablemergedvdepartmentdisch_Internalname, "", "TableMerged", 0, "", "", 0, 0, sStyleString, "", "", 0);
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td class='MergeDataCell'>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, dynavVdepartmentdisch_Internalname, "v Departmentdisch", "col-sm-3 AttributeLabel", 0, true);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 55,'" + sPrefix + "',false,'',0)\"";
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, dynavVdepartmentdisch, dynavVdepartmentdisch_Internalname, StringUtil.RTrim( AV30vDepartmentdisch), 1, dynavVdepartmentdisch_Jsonclick, 0, "'"+sPrefix+"'"+",false,"+"'"+""+"'", "svchar", "", 1, dynavVdepartmentdisch.Enabled, 0, 0, 0, "em", 0, "", "", "Attribute", "", "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,55);\"", "", true, "HLP_BR_EncounterUpdateGeneral.htm");
            dynavVdepartmentdisch.CurrentValue = StringUtil.RTrim( AV30vDepartmentdisch);
            context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, dynavVdepartmentdisch_Internalname, "Values", (String)(dynavVdepartmentdisch.ToJavascriptSource()), true);
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td class='RequiredDataContentCell'>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavVotherdepartmentadisch_Internalname, "v Other Departmentadisch", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 58,'" + sPrefix + "',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavVotherdepartmentadisch_Internalname, AV29vOtherDepartmentadisch, StringUtil.RTrim( context.localUtil.Format( AV29vOtherDepartmentadisch, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,58);\"", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "请填写其它出院科室", edtavVotherdepartmentadisch_Jsonclick, 0, "Attribute", "", "", "", "", edtavVotherdepartmentadisch_Visible, edtavVotherdepartmentadisch_Enabled, 0, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_BR_EncounterUpdateGeneral.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table3_51_1Z2e( true) ;
         }
         else
         {
            wb_table3_51_1Z2e( false) ;
         }
      }

      protected void wb_table2_37_1Z2( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "";
            GxWebStd.gx_table_start( context, tblTablemergedvdepartmentadm_Internalname, tblTablemergedvdepartmentadm_Internalname, "", "TableMerged", 0, "", "", 0, 0, sStyleString, "", "", 0);
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td class='MergeDataCell'>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, dynavVdepartmentadm_Internalname, "v Departmentadm", "col-sm-3 AttributeLabel", 0, true);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 41,'" + sPrefix + "',false,'',0)\"";
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, dynavVdepartmentadm, dynavVdepartmentadm_Internalname, StringUtil.RTrim( AV27vDepartmentadm), 1, dynavVdepartmentadm_Jsonclick, 0, "'"+sPrefix+"'"+",false,"+"'"+""+"'", "svchar", "", 1, dynavVdepartmentadm.Enabled, 0, 0, 0, "em", 0, "", "", "Attribute", "", "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,41);\"", "", true, "HLP_BR_EncounterUpdateGeneral.htm");
            dynavVdepartmentadm.CurrentValue = StringUtil.RTrim( AV27vDepartmentadm);
            context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, dynavVdepartmentadm_Internalname, "Values", (String)(dynavVdepartmentadm.ToJavascriptSource()), true);
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td class='RequiredDataContentCell'>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavVotherdepartmentadm_Internalname, "v Other Departmentadm", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 44,'" + sPrefix + "',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavVotherdepartmentadm_Internalname, AV28vOtherDepartmentadm, StringUtil.RTrim( context.localUtil.Format( AV28vOtherDepartmentadm, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,44);\"", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "请填写其它入院科室", edtavVotherdepartmentadm_Jsonclick, 0, "Attribute", "", "", "", "", edtavVotherdepartmentadm_Visible, edtavVotherdepartmentadm_Enabled, 0, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_BR_EncounterUpdateGeneral.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table2_37_1Z2e( true) ;
         }
         else
         {
            wb_table2_37_1Z2e( false) ;
         }
      }

      protected void wb_table1_14_1Z2( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "";
            GxWebStd.gx_table_start( context, tblUnnamedtable1_Internalname, tblUnnamedtable1_Internalname, "", "", 0, "", "", 1, 2, sStyleString, "", "", 0);
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 17,'" + sPrefix + "',false,'',0)\"";
            ClassString = "ButtonMaterial";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtncheckhistory_Internalname, "", "查看审批情况", bttBtncheckhistory_Jsonclick, 7, "查看审批情况", "", StyleString, ClassString, 1, 1, "standard", "'"+sPrefix+"'"+",false,"+"'"+"e141z1_client"+"'", TempTags, "", 2, "HLP_BR_EncounterUpdateGeneral.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table1_14_1Z2e( true) ;
         }
         else
         {
            wb_table1_14_1Z2e( false) ;
         }
      }

      public override void setparameters( Object[] obj )
      {
         createObjects();
         initialize();
         A19BR_EncounterID = Convert.ToInt64(getParm(obj,0));
         context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A19BR_EncounterID", StringUtil.LTrim( StringUtil.Str( (decimal)(A19BR_EncounterID), 18, 0)));
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
         PA1Z2( ) ;
         WS1Z2( ) ;
         WE1Z2( ) ;
         this.cleanup();
         context.SetWrapped(false);
         SaveComponentMsgList(sPrefix);
         context.GX_msglist = BackMsgLst;
         return "";
      }

      public void responsestatic( String sGXDynURL )
      {
      }

      public override void componentbind( Object[] obj )
      {
         if ( IsUrlCreated( ) )
         {
            return  ;
         }
         sCtrlA19BR_EncounterID = (String)((String)getParm(obj,0));
      }

      public override void componentrestorestate( String sPPrefix ,
                                                  String sPSFPrefix )
      {
         sPrefix = sPPrefix + sPSFPrefix;
         PA1Z2( ) ;
         WCParametersGet( ) ;
      }

      public override void componentprepare( Object[] obj )
      {
         wbLoad = false;
         sCompPrefix = (String)getParm(obj,0);
         sSFPrefix = (String)getParm(obj,1);
         sPrefix = sCompPrefix + sSFPrefix;
         AddComponentObject(sPrefix, "br_encounterupdategeneral", GetJustCreated( ));
         if ( ( nDoneStart == 0 ) && ( nDynComponent == 0 ) )
         {
            INITWEB( ) ;
         }
         else
         {
            init_default_properties( ) ;
            init_web_controls( ) ;
         }
         PA1Z2( ) ;
         if ( ! GetJustCreated( ) && ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 ) && ( context.wbGlbDoneStart == 0 ) )
         {
            WCParametersGet( ) ;
         }
         else
         {
            A19BR_EncounterID = Convert.ToInt64(getParm(obj,2));
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A19BR_EncounterID", StringUtil.LTrim( StringUtil.Str( (decimal)(A19BR_EncounterID), 18, 0)));
         }
         wcpOA19BR_EncounterID = (long)(context.localUtil.CToN( cgiGet( sPrefix+"wcpOA19BR_EncounterID"), ".", ","));
         if ( ! GetJustCreated( ) && ( ( A19BR_EncounterID != wcpOA19BR_EncounterID ) ) )
         {
            setjustcreated();
         }
         wcpOA19BR_EncounterID = A19BR_EncounterID;
      }

      protected void WCParametersGet( )
      {
         /* Read Component Parameters. */
         sCtrlA19BR_EncounterID = cgiGet( sPrefix+"A19BR_EncounterID_CTRL");
         if ( StringUtil.Len( sCtrlA19BR_EncounterID) > 0 )
         {
            A19BR_EncounterID = (long)(context.localUtil.CToN( cgiGet( sCtrlA19BR_EncounterID), ".", ","));
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A19BR_EncounterID", StringUtil.LTrim( StringUtil.Str( (decimal)(A19BR_EncounterID), 18, 0)));
         }
         else
         {
            A19BR_EncounterID = (long)(context.localUtil.CToN( cgiGet( sPrefix+"A19BR_EncounterID_PARM"), ".", ","));
         }
      }

      public override void componentprocess( String sPPrefix ,
                                             String sPSFPrefix ,
                                             String sCompEvt )
      {
         sCompPrefix = sPPrefix;
         sSFPrefix = sPSFPrefix;
         sPrefix = sCompPrefix + sSFPrefix;
         BackMsgLst = context.GX_msglist;
         context.GX_msglist = LclMsgLst;
         INITWEB( ) ;
         nDraw = 0;
         PA1Z2( ) ;
         sEvt = sCompEvt;
         WCParametersGet( ) ;
         WS1Z2( ) ;
         if ( isFullAjaxMode( ) )
         {
            componentdraw();
         }
         SaveComponentMsgList(sPrefix);
         context.GX_msglist = BackMsgLst;
      }

      public override void componentstart( )
      {
         if ( nDoneStart == 0 )
         {
            WCStart( ) ;
         }
      }

      protected void WCStart( )
      {
         nDraw = 1;
         BackMsgLst = context.GX_msglist;
         context.GX_msglist = LclMsgLst;
         WS1Z2( ) ;
         SaveComponentMsgList(sPrefix);
         context.GX_msglist = BackMsgLst;
      }

      protected void WCParametersSet( )
      {
         GxWebStd.gx_hidden_field( context, sPrefix+"A19BR_EncounterID_PARM", StringUtil.LTrim( StringUtil.NToC( (decimal)(A19BR_EncounterID), 18, 0, ".", "")));
         if ( StringUtil.Len( StringUtil.RTrim( sCtrlA19BR_EncounterID)) > 0 )
         {
            GxWebStd.gx_hidden_field( context, sPrefix+"A19BR_EncounterID_CTRL", StringUtil.RTrim( sCtrlA19BR_EncounterID));
         }
      }

      public override void componentdraw( )
      {
         if ( nDoneStart == 0 )
         {
            WCStart( ) ;
         }
         BackMsgLst = context.GX_msglist;
         context.GX_msglist = LclMsgLst;
         WCParametersSet( ) ;
         WE1Z2( ) ;
         SaveComponentMsgList(sPrefix);
         context.GX_msglist = BackMsgLst;
      }

      public override String getstring( String sGXControl )
      {
         String sCtrlName ;
         if ( StringUtil.StrCmp(StringUtil.Substring( sGXControl, 1, 1), "&") == 0 )
         {
            sCtrlName = StringUtil.Substring( sGXControl, 2, StringUtil.Len( sGXControl)-1);
         }
         else
         {
            sCtrlName = sGXControl;
         }
         return cgiGet( sPrefix+"v"+StringUtil.Upper( sCtrlName)) ;
      }

      public override void componentjscripts( )
      {
         include_jscripts( ) ;
      }

      public override void componentthemes( )
      {
         define_styles( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?20202281565237", true);
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
         context.AddJavascriptSource("br_encounterupdategeneral.js", "?20202281565237", false);
         context.AddJavascriptSource("DVelop/Bootstrap/Shared/DVelopBootstrap.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/Panel/BootstrapPanelRender.js", "", false);
         /* End function include_jscripts */
      }

      protected void init_web_controls( )
      {
         dynavVdepartmentadm.Name = "vVDEPARTMENTADM";
         dynavVdepartmentadm.WebTags = "";
         dynavVdepartmentdisch.Name = "vVDEPARTMENTDISCH";
         dynavVdepartmentdisch.WebTags = "";
         dynavVenctype.Name = "vVENCTYPE";
         dynavVenctype.WebTags = "";
         dynavVinsurance.Name = "vVINSURANCE";
         dynavVinsurance.WebTags = "";
         dynavVreason.Name = "vVREASON";
         dynavVreason.WebTags = "";
         dynavBr_encounter_br_encounter_dischargestatus.Name = "BR_ENCOUNTER_BR_ENCOUNTER_DISCHARGESTATUS";
         dynavBr_encounter_br_encounter_dischargestatus.WebTags = "";
         /* End function init_web_controls */
      }

      protected void init_default_properties( )
      {
         bttBtncheckhistory_Internalname = sPrefix+"BTNCHECKHISTORY";
         tblUnnamedtable1_Internalname = sPrefix+"UNNAMEDTABLE1";
         divLayout_unnamedtable1_Internalname = sPrefix+"LAYOUT_UNNAMEDTABLE1";
         Dvpanel_unnamedtable1_Internalname = sPrefix+"DVPANEL_UNNAMEDTABLE1";
         divHtml_dvpanel_unnamedtable1_Internalname = sPrefix+"HTML_DVPANEL_UNNAMEDTABLE1";
         divDvpanel_unnamedtable1_cell_Internalname = sPrefix+"DVPANEL_UNNAMEDTABLE1_CELL";
         edtavBr_encounter_br_information_patientno_Internalname = sPrefix+"BR_ENCOUNTER_BR_INFORMATION_PATIENTNO";
         edtavBr_encounter_br_encounter_encid_Internalname = sPrefix+"BR_ENCOUNTER_BR_ENCOUNTER_ENCID";
         lblTextblockvdepartmentadm_Internalname = sPrefix+"TEXTBLOCKVDEPARTMENTADM";
         dynavVdepartmentadm_Internalname = sPrefix+"vVDEPARTMENTADM";
         edtavVotherdepartmentadm_Internalname = sPrefix+"vVOTHERDEPARTMENTADM";
         tblTablemergedvdepartmentadm_Internalname = sPrefix+"TABLEMERGEDVDEPARTMENTADM";
         divTablesplittedvdepartmentadm_Internalname = sPrefix+"TABLESPLITTEDVDEPARTMENTADM";
         lblTextblockvdepartmentdisch_Internalname = sPrefix+"TEXTBLOCKVDEPARTMENTDISCH";
         dynavVdepartmentdisch_Internalname = sPrefix+"vVDEPARTMENTDISCH";
         edtavVotherdepartmentadisch_Internalname = sPrefix+"vVOTHERDEPARTMENTADISCH";
         tblTablemergedvdepartmentdisch_Internalname = sPrefix+"TABLEMERGEDVDEPARTMENTDISCH";
         divTablesplittedvdepartmentdisch_Internalname = sPrefix+"TABLESPLITTEDVDEPARTMENTDISCH";
         lblTextblockvenctype_Internalname = sPrefix+"TEXTBLOCKVENCTYPE";
         dynavVenctype_Internalname = sPrefix+"vVENCTYPE";
         edtavVotherenctype_Internalname = sPrefix+"vVOTHERENCTYPE";
         tblTablemergedvenctype_Internalname = sPrefix+"TABLEMERGEDVENCTYPE";
         divTablesplittedvenctype_Internalname = sPrefix+"TABLESPLITTEDVENCTYPE";
         lblTextblockvinsurance_Internalname = sPrefix+"TEXTBLOCKVINSURANCE";
         dynavVinsurance_Internalname = sPrefix+"vVINSURANCE";
         edtavVotherinsurance_Internalname = sPrefix+"vVOTHERINSURANCE";
         tblTablemergedvinsurance_Internalname = sPrefix+"TABLEMERGEDVINSURANCE";
         divTablesplittedvinsurance_Internalname = sPrefix+"TABLESPLITTEDVINSURANCE";
         lblTextblockvreason_Internalname = sPrefix+"TEXTBLOCKVREASON";
         dynavVreason_Internalname = sPrefix+"vVREASON";
         edtavVotherreason_Internalname = sPrefix+"vVOTHERREASON";
         tblTablemergedvreason_Internalname = sPrefix+"TABLEMERGEDVREASON";
         divTablesplittedvreason_Internalname = sPrefix+"TABLESPLITTEDVREASON";
         edtavBr_encounter_br_encounter_admitdate_Internalname = sPrefix+"BR_ENCOUNTER_BR_ENCOUNTER_ADMITDATE";
         edtavBr_encounter_br_encounter_dischargedate_Internalname = sPrefix+"BR_ENCOUNTER_BR_ENCOUNTER_DISCHARGEDATE";
         dynavBr_encounter_br_encounter_dischargestatus_Internalname = sPrefix+"BR_ENCOUNTER_BR_ENCOUNTER_DISCHARGESTATUS";
         divUnnamedtable2_Internalname = sPrefix+"UNNAMEDTABLE2";
         bttBtnsave_Internalname = sPrefix+"BTNSAVE";
         divTable_Internalname = sPrefix+"TABLE";
         edtavBr_encounter_br_encounterid_Internalname = sPrefix+"BR_ENCOUNTER_BR_ENCOUNTERID";
         edtavVdepartment_Internalname = sPrefix+"vVDEPARTMENT";
         edtavVotherdepartment_Internalname = sPrefix+"vVOTHERDEPARTMENT";
         edtavBr_encounter_br_information_id_Internalname = sPrefix+"BR_ENCOUNTER_BR_INFORMATION_ID";
         divHtml_bottomauxiliarcontrols_Internalname = sPrefix+"HTML_BOTTOMAUXILIARCONTROLS";
         divLayoutmaintable_Internalname = sPrefix+"LAYOUTMAINTABLE";
         Form.Internalname = sPrefix+"FORM";
      }

      public override void initialize_properties( )
      {
         if ( StringUtil.Len( sPrefix) == 0 )
         {
            context.SetDefaultTheme("WorkWithPlusTheme");
         }
         if ( StringUtil.Len( sPrefix) == 0 )
         {
            if ( context.isSpaRequest( ) )
            {
               disableJsOutput();
            }
         }
         init_default_properties( ) ;
         edtavVotherdepartmentadm_Jsonclick = "";
         edtavVotherdepartmentadm_Enabled = 1;
         dynavVdepartmentadm_Jsonclick = "";
         dynavVdepartmentadm.Enabled = 1;
         edtavVotherdepartmentadisch_Jsonclick = "";
         edtavVotherdepartmentadisch_Enabled = 1;
         dynavVdepartmentdisch_Jsonclick = "";
         dynavVdepartmentdisch.Enabled = 1;
         edtavVotherenctype_Jsonclick = "";
         edtavVotherenctype_Enabled = 1;
         dynavVenctype_Jsonclick = "";
         dynavVenctype.Enabled = 1;
         edtavVotherinsurance_Jsonclick = "";
         edtavVotherinsurance_Enabled = 1;
         dynavVinsurance_Jsonclick = "";
         dynavVinsurance.Enabled = 1;
         edtavVotherreason_Jsonclick = "";
         edtavVotherreason_Enabled = 1;
         dynavVreason_Jsonclick = "";
         dynavVreason.Enabled = 1;
         edtavVotherinsurance_Visible = 1;
         edtavVotherdepartmentadisch_Visible = 1;
         edtavVotherdepartmentadm_Visible = 1;
         edtavVotherreason_Visible = 1;
         edtavVotherenctype_Visible = 1;
         edtavBr_encounter_br_information_id_Jsonclick = "";
         edtavBr_encounter_br_information_id_Visible = 1;
         edtavVotherdepartment_Jsonclick = "";
         edtavVotherdepartment_Visible = 1;
         edtavVdepartment_Jsonclick = "";
         edtavVdepartment_Visible = 1;
         edtavBr_encounter_br_encounterid_Jsonclick = "";
         edtavBr_encounter_br_encounterid_Visible = 1;
         dynavBr_encounter_br_encounter_dischargestatus_Jsonclick = "";
         dynavBr_encounter_br_encounter_dischargestatus.Enabled = 1;
         edtavBr_encounter_br_encounter_dischargedate_Jsonclick = "";
         edtavBr_encounter_br_encounter_dischargedate_Enabled = 1;
         edtavBr_encounter_br_encounter_admitdate_Jsonclick = "";
         edtavBr_encounter_br_encounter_admitdate_Enabled = 1;
         edtavBr_encounter_br_encounter_encid_Jsonclick = "";
         edtavBr_encounter_br_encounter_encid_Enabled = 0;
         edtavBr_encounter_br_information_patientno_Jsonclick = "";
         edtavBr_encounter_br_information_patientno_Enabled = 0;
         divDvpanel_unnamedtable1_cell_Class = "col-xs-12";
         Dvpanel_unnamedtable1_Autoscroll = Convert.ToBoolean( 0);
         Dvpanel_unnamedtable1_Iconposition = "left";
         Dvpanel_unnamedtable1_Showcollapseicon = Convert.ToBoolean( 0);
         Dvpanel_unnamedtable1_Autoheight = Convert.ToBoolean( -1);
         Dvpanel_unnamedtable1_Autowidth = Convert.ToBoolean( 0);
         Dvpanel_unnamedtable1_Collapsed = Convert.ToBoolean( 0);
         Dvpanel_unnamedtable1_Collapsible = Convert.ToBoolean( -1);
         Dvpanel_unnamedtable1_Title = "";
         Dvpanel_unnamedtable1_Cls = "PanelNoHeader";
         Dvpanel_unnamedtable1_Width = "100%";
         edtavBr_encounter_br_encounter_encid_Enabled = -1;
         edtavBr_encounter_br_information_patientno_Enabled = -1;
         context.GX_msglist.DisplayMode = 1;
         if ( StringUtil.Len( sPrefix) == 0 )
         {
            if ( context.isSpaRequest( ) )
            {
               enableJsOutput();
            }
         }
      }

      public override bool SupportAjaxEvent( )
      {
         return true ;
      }

      public override void InitializeDynEvents( )
      {
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[]");
         setEventMetadata("REFRESH",",oparms:[]}");
         setEventMetadata("'DOSAVE'","{handler:'E131Z2',iparms:[{av:'dynavVdepartmentadm'},{av:'AV27vDepartmentadm',fld:'vVDEPARTMENTADM',pic:''},{av:'AV28vOtherDepartmentadm',fld:'vVOTHERDEPARTMENTADM',pic:''},{av:'AV14BR_Encounter',fld:'vBR_ENCOUNTER',pic:''},{av:'dynavVdepartmentdisch'},{av:'AV30vDepartmentdisch',fld:'vVDEPARTMENTDISCH',pic:''},{av:'AV29vOtherDepartmentadisch',fld:'vVOTHERDEPARTMENTADISCH',pic:''},{av:'dynavVinsurance'},{av:'AV31vInsurance',fld:'vVINSURANCE',pic:''},{av:'AV32vOtherInsurance',fld:'vVOTHERINSURANCE',pic:''},{av:'dynavVenctype'},{av:'AV18vENCType',fld:'vVENCTYPE',pic:''},{av:'AV19vOtherENCType',fld:'vVOTHERENCTYPE',pic:''},{av:'dynavVreason'},{av:'AV22vReason',fld:'vVREASON',pic:''},{av:'AV23vOtherReason',fld:'vVOTHERREASON',pic:''},{av:'A19BR_EncounterID',fld:'BR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ'}]");
         setEventMetadata("'DOSAVE'",",oparms:[{av:'AV14BR_Encounter',fld:'vBR_ENCOUNTER',pic:''}]}");
         setEventMetadata("'DOCHECKHISTORY'","{handler:'E141Z1',iparms:[{av:'A19BR_EncounterID',fld:'BR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ'}]");
         setEventMetadata("'DOCHECKHISTORY'",",oparms:[]}");
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
         gxfirstwebparm = "";
         gxfirstwebparm_bkp = "";
         sPrefix = "";
         AV24tCurrentCode = "";
         AV44Pgmname = "";
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         GXKey = "";
         AV14BR_Encounter = new SdtBR_Encounter(context);
         GX_FocusControl = "";
         ucDvpanel_unnamedtable1 = new GXUserControl();
         lblTextblockvdepartmentadm_Jsonclick = "";
         lblTextblockvdepartmentdisch_Jsonclick = "";
         lblTextblockvenctype_Jsonclick = "";
         lblTextblockvinsurance_Jsonclick = "";
         lblTextblockvreason_Jsonclick = "";
         TempTags = "";
         ClassString = "";
         StyleString = "";
         bttBtnsave_Jsonclick = "";
         AV16vDepartment = "";
         AV17vOtherDepartment = "";
         Form = new GXWebForm();
         sXEvt = "";
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         gxdynajaxctrlcodr = new GeneXus.Utils.GxStringCollection();
         gxdynajaxctrldescr = new GeneXus.Utils.GxStringCollection();
         gxwrpcisep = "";
         AV27vDepartmentadm = "";
         scmdbuf = "";
         H001Z2_A167XT_DefineCodeID = new long[1] ;
         H001Z2_A168XT_DefineCodeName = new String[] {""} ;
         H001Z2_n168XT_DefineCodeName = new bool[] {false} ;
         H001Z2_A165XT_DefindcodeTypeID = new long[1] ;
         H001Z2_A432XT_TenantCode = new String[] {""} ;
         H001Z2_n432XT_TenantCode = new bool[] {false} ;
         AV30vDepartmentdisch = "";
         H001Z3_A167XT_DefineCodeID = new long[1] ;
         H001Z3_A168XT_DefineCodeName = new String[] {""} ;
         H001Z3_n168XT_DefineCodeName = new bool[] {false} ;
         H001Z3_A165XT_DefindcodeTypeID = new long[1] ;
         H001Z3_A432XT_TenantCode = new String[] {""} ;
         H001Z3_n432XT_TenantCode = new bool[] {false} ;
         AV18vENCType = "";
         H001Z4_A167XT_DefineCodeID = new long[1] ;
         H001Z4_A168XT_DefineCodeName = new String[] {""} ;
         H001Z4_n168XT_DefineCodeName = new bool[] {false} ;
         H001Z4_A165XT_DefindcodeTypeID = new long[1] ;
         H001Z4_A432XT_TenantCode = new String[] {""} ;
         H001Z4_n432XT_TenantCode = new bool[] {false} ;
         AV31vInsurance = "";
         H001Z5_A167XT_DefineCodeID = new long[1] ;
         H001Z5_A168XT_DefineCodeName = new String[] {""} ;
         H001Z5_n168XT_DefineCodeName = new bool[] {false} ;
         H001Z5_A165XT_DefindcodeTypeID = new long[1] ;
         H001Z5_A432XT_TenantCode = new String[] {""} ;
         H001Z5_n432XT_TenantCode = new bool[] {false} ;
         AV22vReason = "";
         H001Z6_A167XT_DefineCodeID = new long[1] ;
         H001Z6_A168XT_DefineCodeName = new String[] {""} ;
         H001Z6_n168XT_DefineCodeName = new bool[] {false} ;
         H001Z6_A165XT_DefindcodeTypeID = new long[1] ;
         H001Z6_A432XT_TenantCode = new String[] {""} ;
         H001Z6_n432XT_TenantCode = new bool[] {false} ;
         H001Z7_A167XT_DefineCodeID = new long[1] ;
         H001Z7_A168XT_DefineCodeName = new String[] {""} ;
         H001Z7_n168XT_DefineCodeName = new bool[] {false} ;
         H001Z7_A165XT_DefindcodeTypeID = new long[1] ;
         H001Z7_A432XT_TenantCode = new String[] {""} ;
         H001Z7_n432XT_TenantCode = new bool[] {false} ;
         H001Z8_A19BR_EncounterID = new long[1] ;
         AV28vOtherDepartmentadm = "";
         AV29vOtherDepartmentadisch = "";
         AV19vOtherENCType = "";
         AV32vOtherInsurance = "";
         AV23vOtherReason = "";
         GXt_char1 = "";
         AV6WWPContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPContext(context);
         AV20ErrorMsg = "";
         AV42GXV8 = new GXBaseCollection<SdtMessages_Message>( context, "Message", "GeneXus");
         AV21Message = new SdtMessages_Message(context);
         AV9TrnContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext(context);
         AV12HTTPRequest = new GxHttpRequest( context);
         AV10TrnContextAtt = new GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext_Attribute(context);
         AV11Session = context.GetSession();
         sStyleString = "";
         bttBtncheckhistory_Jsonclick = "";
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         sCtrlA19BR_EncounterID = "";
         pr_datastore1 = new DataStoreProvider(context, new GeneXus.Programs.br_encounterupdategeneral__datastore1(),
            new Object[][] {
            }
         );
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.br_encounterupdategeneral__default(),
            new Object[][] {
                new Object[] {
               H001Z2_A167XT_DefineCodeID, H001Z2_A168XT_DefineCodeName, H001Z2_n168XT_DefineCodeName, H001Z2_A165XT_DefindcodeTypeID, H001Z2_A432XT_TenantCode, H001Z2_n432XT_TenantCode
               }
               , new Object[] {
               H001Z3_A167XT_DefineCodeID, H001Z3_A168XT_DefineCodeName, H001Z3_n168XT_DefineCodeName, H001Z3_A165XT_DefindcodeTypeID, H001Z3_A432XT_TenantCode, H001Z3_n432XT_TenantCode
               }
               , new Object[] {
               H001Z4_A167XT_DefineCodeID, H001Z4_A168XT_DefineCodeName, H001Z4_n168XT_DefineCodeName, H001Z4_A165XT_DefindcodeTypeID, H001Z4_A432XT_TenantCode, H001Z4_n432XT_TenantCode
               }
               , new Object[] {
               H001Z5_A167XT_DefineCodeID, H001Z5_A168XT_DefineCodeName, H001Z5_n168XT_DefineCodeName, H001Z5_A165XT_DefindcodeTypeID, H001Z5_A432XT_TenantCode, H001Z5_n432XT_TenantCode
               }
               , new Object[] {
               H001Z6_A167XT_DefineCodeID, H001Z6_A168XT_DefineCodeName, H001Z6_n168XT_DefineCodeName, H001Z6_A165XT_DefindcodeTypeID, H001Z6_A432XT_TenantCode, H001Z6_n432XT_TenantCode
               }
               , new Object[] {
               H001Z7_A167XT_DefineCodeID, H001Z7_A168XT_DefineCodeName, H001Z7_n168XT_DefineCodeName, H001Z7_A165XT_DefindcodeTypeID, H001Z7_A432XT_TenantCode, H001Z7_n432XT_TenantCode
               }
               , new Object[] {
               H001Z8_A19BR_EncounterID
               }
            }
         );
         AV44Pgmname = "BR_EncounterUpdateGeneral";
         /* GeneXus formulas. */
         AV44Pgmname = "BR_EncounterUpdateGeneral";
         context.Gx_err = 0;
         edtavBr_encounter_br_information_patientno_Enabled = 0;
         edtavBr_encounter_br_encounter_encid_Enabled = 0;
      }

      private short nGotPars ;
      private short GxWebError ;
      private short nDynComponent ;
      private short initialized ;
      private short wbEnd ;
      private short wbStart ;
      private short nDraw ;
      private short nDoneStart ;
      private short nDonePA ;
      private short gxcookieaux ;
      private short nGXWrapped ;
      private int edtavBr_encounter_br_information_patientno_Enabled ;
      private int edtavBr_encounter_br_encounter_encid_Enabled ;
      private int edtavBr_encounter_br_encounter_admitdate_Enabled ;
      private int edtavBr_encounter_br_encounter_dischargedate_Enabled ;
      private int edtavBr_encounter_br_encounterid_Visible ;
      private int edtavVdepartment_Visible ;
      private int edtavVotherdepartment_Visible ;
      private int edtavBr_encounter_br_information_id_Visible ;
      private int gxdynajaxindex ;
      private int edtavVotherenctype_Visible ;
      private int edtavVotherreason_Visible ;
      private int edtavVotherdepartmentadm_Visible ;
      private int edtavVotherdepartmentadisch_Visible ;
      private int edtavVotherinsurance_Visible ;
      private int AV43GXV9 ;
      private int edtavVotherreason_Enabled ;
      private int edtavVotherinsurance_Enabled ;
      private int edtavVotherenctype_Enabled ;
      private int edtavVotherdepartmentadisch_Enabled ;
      private int edtavVotherdepartmentadm_Enabled ;
      private int idxLst ;
      private long A19BR_EncounterID ;
      private long wcpOA19BR_EncounterID ;
      private long AV8BR_EncounterID ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String sPrefix ;
      private String sCompPrefix ;
      private String sSFPrefix ;
      private String AV44Pgmname ;
      private String edtavBr_encounter_br_information_patientno_Internalname ;
      private String edtavBr_encounter_br_encounter_encid_Internalname ;
      private String sDynURL ;
      private String FormProcess ;
      private String bodyStyle ;
      private String GXKey ;
      private String Dvpanel_unnamedtable1_Width ;
      private String Dvpanel_unnamedtable1_Cls ;
      private String Dvpanel_unnamedtable1_Title ;
      private String Dvpanel_unnamedtable1_Iconposition ;
      private String GX_FocusControl ;
      private String divLayoutmaintable_Internalname ;
      private String divTable_Internalname ;
      private String divDvpanel_unnamedtable1_cell_Internalname ;
      private String divDvpanel_unnamedtable1_cell_Class ;
      private String divHtml_dvpanel_unnamedtable1_Internalname ;
      private String Dvpanel_unnamedtable1_Internalname ;
      private String divLayout_unnamedtable1_Internalname ;
      private String divUnnamedtable2_Internalname ;
      private String edtavBr_encounter_br_information_patientno_Jsonclick ;
      private String edtavBr_encounter_br_encounter_encid_Jsonclick ;
      private String divTablesplittedvdepartmentadm_Internalname ;
      private String lblTextblockvdepartmentadm_Internalname ;
      private String lblTextblockvdepartmentadm_Jsonclick ;
      private String divTablesplittedvdepartmentdisch_Internalname ;
      private String lblTextblockvdepartmentdisch_Internalname ;
      private String lblTextblockvdepartmentdisch_Jsonclick ;
      private String divTablesplittedvenctype_Internalname ;
      private String lblTextblockvenctype_Internalname ;
      private String lblTextblockvenctype_Jsonclick ;
      private String divTablesplittedvinsurance_Internalname ;
      private String lblTextblockvinsurance_Internalname ;
      private String lblTextblockvinsurance_Jsonclick ;
      private String divTablesplittedvreason_Internalname ;
      private String lblTextblockvreason_Internalname ;
      private String lblTextblockvreason_Jsonclick ;
      private String edtavBr_encounter_br_encounter_admitdate_Internalname ;
      private String TempTags ;
      private String edtavBr_encounter_br_encounter_admitdate_Jsonclick ;
      private String edtavBr_encounter_br_encounter_dischargedate_Internalname ;
      private String edtavBr_encounter_br_encounter_dischargedate_Jsonclick ;
      private String dynavBr_encounter_br_encounter_dischargestatus_Internalname ;
      private String dynavBr_encounter_br_encounter_dischargestatus_Jsonclick ;
      private String ClassString ;
      private String StyleString ;
      private String bttBtnsave_Internalname ;
      private String bttBtnsave_Jsonclick ;
      private String divHtml_bottomauxiliarcontrols_Internalname ;
      private String edtavBr_encounter_br_encounterid_Internalname ;
      private String edtavBr_encounter_br_encounterid_Jsonclick ;
      private String edtavVdepartment_Internalname ;
      private String edtavVdepartment_Jsonclick ;
      private String edtavVotherdepartment_Internalname ;
      private String edtavVotherdepartment_Jsonclick ;
      private String edtavBr_encounter_br_information_id_Internalname ;
      private String edtavBr_encounter_br_information_id_Jsonclick ;
      private String sXEvt ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String gxwrpcisep ;
      private String scmdbuf ;
      private String dynavVdepartmentadm_Internalname ;
      private String dynavVdepartmentdisch_Internalname ;
      private String dynavVenctype_Internalname ;
      private String dynavVinsurance_Internalname ;
      private String dynavVreason_Internalname ;
      private String edtavVotherdepartmentadm_Internalname ;
      private String edtavVotherdepartmentadisch_Internalname ;
      private String edtavVotherenctype_Internalname ;
      private String edtavVotherinsurance_Internalname ;
      private String edtavVotherreason_Internalname ;
      private String GXt_char1 ;
      private String sStyleString ;
      private String tblTablemergedvreason_Internalname ;
      private String dynavVreason_Jsonclick ;
      private String edtavVotherreason_Jsonclick ;
      private String tblTablemergedvinsurance_Internalname ;
      private String dynavVinsurance_Jsonclick ;
      private String edtavVotherinsurance_Jsonclick ;
      private String tblTablemergedvenctype_Internalname ;
      private String dynavVenctype_Jsonclick ;
      private String edtavVotherenctype_Jsonclick ;
      private String tblTablemergedvdepartmentdisch_Internalname ;
      private String dynavVdepartmentdisch_Jsonclick ;
      private String edtavVotherdepartmentadisch_Jsonclick ;
      private String tblTablemergedvdepartmentadm_Internalname ;
      private String dynavVdepartmentadm_Jsonclick ;
      private String edtavVotherdepartmentadm_Jsonclick ;
      private String tblUnnamedtable1_Internalname ;
      private String bttBtncheckhistory_Internalname ;
      private String bttBtncheckhistory_Jsonclick ;
      private String sCtrlA19BR_EncounterID ;
      private bool entryPointCalled ;
      private bool toggleJsOutput ;
      private bool Dvpanel_unnamedtable1_Collapsible ;
      private bool Dvpanel_unnamedtable1_Collapsed ;
      private bool Dvpanel_unnamedtable1_Autowidth ;
      private bool Dvpanel_unnamedtable1_Autoheight ;
      private bool Dvpanel_unnamedtable1_Showcollapseicon ;
      private bool Dvpanel_unnamedtable1_Autoscroll ;
      private bool wbLoad ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool gxdyncontrolsrefreshing ;
      private bool returnInSub ;
      private bool AV26tCheckFlag ;
      private bool AV15tFlag ;
      private String AV24tCurrentCode ;
      private String AV16vDepartment ;
      private String AV17vOtherDepartment ;
      private String AV27vDepartmentadm ;
      private String AV30vDepartmentdisch ;
      private String AV18vENCType ;
      private String AV31vInsurance ;
      private String AV22vReason ;
      private String AV28vOtherDepartmentadm ;
      private String AV29vOtherDepartmentadisch ;
      private String AV19vOtherENCType ;
      private String AV32vOtherInsurance ;
      private String AV23vOtherReason ;
      private String AV20ErrorMsg ;
      private GeneXus.Utils.GxStringCollection gxdynajaxctrlcodr ;
      private GeneXus.Utils.GxStringCollection gxdynajaxctrldescr ;
      private GXUserControl ucDvpanel_unnamedtable1 ;
      private GXWebForm Form ;
      private IGxDataStore dsDataStore1 ;
      private IGxDataStore dsDefault ;
      private GXCombobox dynavVdepartmentadm ;
      private GXCombobox dynavVdepartmentdisch ;
      private GXCombobox dynavVenctype ;
      private GXCombobox dynavVinsurance ;
      private GXCombobox dynavVreason ;
      private GXCombobox dynavBr_encounter_br_encounter_dischargestatus ;
      private IDataStoreProvider pr_default ;
      private long[] H001Z2_A167XT_DefineCodeID ;
      private String[] H001Z2_A168XT_DefineCodeName ;
      private bool[] H001Z2_n168XT_DefineCodeName ;
      private long[] H001Z2_A165XT_DefindcodeTypeID ;
      private String[] H001Z2_A432XT_TenantCode ;
      private bool[] H001Z2_n432XT_TenantCode ;
      private long[] H001Z3_A167XT_DefineCodeID ;
      private String[] H001Z3_A168XT_DefineCodeName ;
      private bool[] H001Z3_n168XT_DefineCodeName ;
      private long[] H001Z3_A165XT_DefindcodeTypeID ;
      private String[] H001Z3_A432XT_TenantCode ;
      private bool[] H001Z3_n432XT_TenantCode ;
      private long[] H001Z4_A167XT_DefineCodeID ;
      private String[] H001Z4_A168XT_DefineCodeName ;
      private bool[] H001Z4_n168XT_DefineCodeName ;
      private long[] H001Z4_A165XT_DefindcodeTypeID ;
      private String[] H001Z4_A432XT_TenantCode ;
      private bool[] H001Z4_n432XT_TenantCode ;
      private long[] H001Z5_A167XT_DefineCodeID ;
      private String[] H001Z5_A168XT_DefineCodeName ;
      private bool[] H001Z5_n168XT_DefineCodeName ;
      private long[] H001Z5_A165XT_DefindcodeTypeID ;
      private String[] H001Z5_A432XT_TenantCode ;
      private bool[] H001Z5_n432XT_TenantCode ;
      private long[] H001Z6_A167XT_DefineCodeID ;
      private String[] H001Z6_A168XT_DefineCodeName ;
      private bool[] H001Z6_n168XT_DefineCodeName ;
      private long[] H001Z6_A165XT_DefindcodeTypeID ;
      private String[] H001Z6_A432XT_TenantCode ;
      private bool[] H001Z6_n432XT_TenantCode ;
      private long[] H001Z7_A167XT_DefineCodeID ;
      private String[] H001Z7_A168XT_DefineCodeName ;
      private bool[] H001Z7_n168XT_DefineCodeName ;
      private long[] H001Z7_A165XT_DefindcodeTypeID ;
      private String[] H001Z7_A432XT_TenantCode ;
      private bool[] H001Z7_n432XT_TenantCode ;
      private long[] H001Z8_A19BR_EncounterID ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private IDataStoreProvider pr_datastore1 ;
      private GxHttpRequest AV12HTTPRequest ;
      private IGxSession AV11Session ;
      private GXBaseCollection<SdtMessages_Message> AV42GXV8 ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPContext AV6WWPContext ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext AV9TrnContext ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext_Attribute AV10TrnContextAtt ;
      private SdtBR_Encounter AV14BR_Encounter ;
      private SdtMessages_Message AV21Message ;
   }

   public class br_encounterupdategeneral__datastore1 : DataStoreHelperBase, IDataStoreHelper
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

 public class br_encounterupdategeneral__default : DataStoreHelperBase, IDataStoreHelper
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
     };
  }

  private static CursorDef[] def;
  private void cursorDefinitions( )
  {
     if ( def == null )
     {
        Object[] prmH001Z2 ;
        prmH001Z2 = new Object[] {
        new Object[] {"@AV24tCurrentCode",SqlDbType.NVarChar,40,0}
        } ;
        Object[] prmH001Z3 ;
        prmH001Z3 = new Object[] {
        new Object[] {"@AV24tCurrentCode",SqlDbType.NVarChar,40,0}
        } ;
        Object[] prmH001Z4 ;
        prmH001Z4 = new Object[] {
        new Object[] {"@AV24tCurrentCode",SqlDbType.NVarChar,40,0}
        } ;
        Object[] prmH001Z5 ;
        prmH001Z5 = new Object[] {
        new Object[] {"@AV24tCurrentCode",SqlDbType.NVarChar,40,0}
        } ;
        Object[] prmH001Z6 ;
        prmH001Z6 = new Object[] {
        new Object[] {"@AV24tCurrentCode",SqlDbType.NVarChar,40,0}
        } ;
        Object[] prmH001Z7 ;
        prmH001Z7 = new Object[] {
        new Object[] {"@AV24tCurrentCode",SqlDbType.NVarChar,40,0}
        } ;
        Object[] prmH001Z8 ;
        prmH001Z8 = new Object[] {
        new Object[] {"@BR_EncounterID",SqlDbType.Decimal,18,0}
        } ;
        def= new CursorDef[] {
            new CursorDef("H001Z2", "SELECT [XT_DefineCodeID], [XT_DefineCodeName], [XT_DefindcodeTypeID], [XT_TenantCode] FROM [XT_DefineCode] WITH (NOLOCK) WHERE ([XT_DefindcodeTypeID] = 3) AND ([XT_TenantCode] = @AV24tCurrentCode) ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH001Z2,0,0,true,false )
           ,new CursorDef("H001Z3", "SELECT [XT_DefineCodeID], [XT_DefineCodeName], [XT_DefindcodeTypeID], [XT_TenantCode] FROM [XT_DefineCode] WITH (NOLOCK) WHERE ([XT_DefindcodeTypeID] = 3) AND ([XT_TenantCode] = @AV24tCurrentCode) ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH001Z3,0,0,true,false )
           ,new CursorDef("H001Z4", "SELECT [XT_DefineCodeID], [XT_DefineCodeName], [XT_DefindcodeTypeID], [XT_TenantCode] FROM [XT_DefineCode] WITH (NOLOCK) WHERE ([XT_DefindcodeTypeID] = 4) AND ([XT_TenantCode] = @AV24tCurrentCode) ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH001Z4,0,0,true,false )
           ,new CursorDef("H001Z5", "SELECT [XT_DefineCodeID], [XT_DefineCodeName], [XT_DefindcodeTypeID], [XT_TenantCode] FROM [XT_DefineCode] WITH (NOLOCK) WHERE ([XT_DefindcodeTypeID] = 11) AND ([XT_TenantCode] = @AV24tCurrentCode) ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH001Z5,0,0,true,false )
           ,new CursorDef("H001Z6", "SELECT [XT_DefineCodeID], [XT_DefineCodeName], [XT_DefindcodeTypeID], [XT_TenantCode] FROM [XT_DefineCode] WITH (NOLOCK) WHERE ([XT_DefindcodeTypeID] = 5) AND ([XT_TenantCode] = @AV24tCurrentCode) ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH001Z6,0,0,true,false )
           ,new CursorDef("H001Z7", "SELECT [XT_DefineCodeID], [XT_DefineCodeName], [XT_DefindcodeTypeID], [XT_TenantCode] FROM [XT_DefineCode] WITH (NOLOCK) WHERE ([XT_DefindcodeTypeID] = 6) AND ([XT_TenantCode] = @AV24tCurrentCode) ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH001Z7,0,0,true,false )
           ,new CursorDef("H001Z8", "SELECT [BR_EncounterID] FROM [BR_Encounter] WITH (NOLOCK) WHERE [BR_EncounterID] = @BR_EncounterID ORDER BY [BR_EncounterID] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH001Z8,1,0,true,true )
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
              ((long[]) buf[3])[0] = rslt.getLong(3) ;
              ((String[]) buf[4])[0] = rslt.getVarchar(4) ;
              ((bool[]) buf[5])[0] = rslt.wasNull(4);
              return;
           case 1 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
              ((bool[]) buf[2])[0] = rslt.wasNull(2);
              ((long[]) buf[3])[0] = rslt.getLong(3) ;
              ((String[]) buf[4])[0] = rslt.getVarchar(4) ;
              ((bool[]) buf[5])[0] = rslt.wasNull(4);
              return;
           case 2 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
              ((bool[]) buf[2])[0] = rslt.wasNull(2);
              ((long[]) buf[3])[0] = rslt.getLong(3) ;
              ((String[]) buf[4])[0] = rslt.getVarchar(4) ;
              ((bool[]) buf[5])[0] = rslt.wasNull(4);
              return;
           case 3 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
              ((bool[]) buf[2])[0] = rslt.wasNull(2);
              ((long[]) buf[3])[0] = rslt.getLong(3) ;
              ((String[]) buf[4])[0] = rslt.getVarchar(4) ;
              ((bool[]) buf[5])[0] = rslt.wasNull(4);
              return;
           case 4 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
              ((bool[]) buf[2])[0] = rslt.wasNull(2);
              ((long[]) buf[3])[0] = rslt.getLong(3) ;
              ((String[]) buf[4])[0] = rslt.getVarchar(4) ;
              ((bool[]) buf[5])[0] = rslt.wasNull(4);
              return;
           case 5 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
              ((bool[]) buf[2])[0] = rslt.wasNull(2);
              ((long[]) buf[3])[0] = rslt.getLong(3) ;
              ((String[]) buf[4])[0] = rslt.getVarchar(4) ;
              ((bool[]) buf[5])[0] = rslt.wasNull(4);
              return;
           case 6 :
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
              stmt.SetParameter(1, (String)parms[0]);
              return;
           case 1 :
              stmt.SetParameter(1, (String)parms[0]);
              return;
           case 2 :
              stmt.SetParameter(1, (String)parms[0]);
              return;
           case 3 :
              stmt.SetParameter(1, (String)parms[0]);
              return;
           case 4 :
              stmt.SetParameter(1, (String)parms[0]);
              return;
           case 5 :
              stmt.SetParameter(1, (String)parms[0]);
              return;
           case 6 :
              stmt.SetParameter(1, (long)parms[0]);
              return;
     }
  }

}

}
