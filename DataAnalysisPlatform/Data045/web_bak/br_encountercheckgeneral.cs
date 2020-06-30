/*
               File: BR_EncounterCheckGeneral
        Description: Data Mgmt Portal - RAAP
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/27/2020 9:35:1.52
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
   public class br_encountercheckgeneral : GXWebComponent, System.Web.SessionState.IRequiresSessionState
   {
      public br_encountercheckgeneral( )
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

      public br_encountercheckgeneral( IGxContext context )
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
         cmbBR_Encounter_Status = new GXCombobox();
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
            PA3T2( ) ;
            if ( ( GxWebError == 0 ) && ! isAjaxCallMode( ) )
            {
               /* GeneXus formulas. */
               AV19Pgmname = "BR_EncounterCheckGeneral";
               context.Gx_err = 0;
               WS3T2( ) ;
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
         context.AddJavascriptSource("gxcfg.js", "?2020227935157", false);
         if ( context.isSpaRequest( ) )
         {
            enableOutput();
         }
         context.AddJavascriptSource("calendar.js", "?"+context.GetBuildNumber( 127771), false);
         context.AddJavascriptSource("calendar-setup.js", "?"+context.GetBuildNumber( 127771), false);
         context.AddJavascriptSource("calendar-zh.js", "?"+context.GetBuildNumber( 127771), false);
         context.AddJavascriptSource("DVelop/Bootstrap/Shared/DVelopBootstrap.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/Panel/BootstrapPanelRender.js", "", false);
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
            context.WriteHtmlTextNl( "<form id=\"MAINFORM\" autocomplete=\"off\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("br_encountercheckgeneral.aspx") + "?" + UrlEncode("" +A19BR_EncounterID)+"\">") ;
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
         GxWebStd.gx_hidden_field( context, sPrefix+"wcpOA19BR_EncounterID", StringUtil.LTrim( StringUtil.NToC( (decimal)(wcpOA19BR_EncounterID), 18, 0, ".", "")));
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
         GxWebStd.gx_hidden_field( context, sPrefix+"DVPANEL_UNNAMEDTABLE2_Width", StringUtil.RTrim( Dvpanel_unnamedtable2_Width));
         GxWebStd.gx_hidden_field( context, sPrefix+"DVPANEL_UNNAMEDTABLE2_Cls", StringUtil.RTrim( Dvpanel_unnamedtable2_Cls));
         GxWebStd.gx_hidden_field( context, sPrefix+"DVPANEL_UNNAMEDTABLE2_Title", StringUtil.RTrim( Dvpanel_unnamedtable2_Title));
         GxWebStd.gx_hidden_field( context, sPrefix+"DVPANEL_UNNAMEDTABLE2_Collapsible", StringUtil.BoolToStr( Dvpanel_unnamedtable2_Collapsible));
         GxWebStd.gx_hidden_field( context, sPrefix+"DVPANEL_UNNAMEDTABLE2_Collapsed", StringUtil.BoolToStr( Dvpanel_unnamedtable2_Collapsed));
         GxWebStd.gx_hidden_field( context, sPrefix+"DVPANEL_UNNAMEDTABLE2_Autowidth", StringUtil.BoolToStr( Dvpanel_unnamedtable2_Autowidth));
         GxWebStd.gx_hidden_field( context, sPrefix+"DVPANEL_UNNAMEDTABLE2_Autoheight", StringUtil.BoolToStr( Dvpanel_unnamedtable2_Autoheight));
         GxWebStd.gx_hidden_field( context, sPrefix+"DVPANEL_UNNAMEDTABLE2_Showcollapseicon", StringUtil.BoolToStr( Dvpanel_unnamedtable2_Showcollapseicon));
         GxWebStd.gx_hidden_field( context, sPrefix+"DVPANEL_UNNAMEDTABLE2_Iconposition", StringUtil.RTrim( Dvpanel_unnamedtable2_Iconposition));
         GxWebStd.gx_hidden_field( context, sPrefix+"DVPANEL_UNNAMEDTABLE2_Autoscroll", StringUtil.BoolToStr( Dvpanel_unnamedtable2_Autoscroll));
      }

      protected void RenderHtmlCloseForm3T2( )
      {
         SendCloseFormHiddens( ) ;
         if ( ( StringUtil.Len( sPrefix) != 0 ) && ( context.isAjaxRequest( ) || context.isSpaRequest( ) ) )
         {
            context.AddJavascriptSource("br_encountercheckgeneral.js", "?202022793524", false);
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
         return "BR_EncounterCheckGeneral" ;
      }

      public override String GetPgmdesc( )
      {
         return "Data Mgmt Portal - RAAP" ;
      }

      protected void WB3T0( )
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
               GxWebStd.gx_hidden_field( context, sPrefix+"_CMPPGM", "br_encountercheckgeneral.aspx");
               context.AddJavascriptSource("DVelop/Bootstrap/Shared/DVelopBootstrap.js", "", false);
               context.AddJavascriptSource("DVelop/Bootstrap/Panel/BootstrapPanelRender.js", "", false);
               context.AddJavascriptSource("DVelop/Bootstrap/Shared/DVelopBootstrap.js", "", false);
               context.AddJavascriptSource("DVelop/Bootstrap/Panel/BootstrapPanelRender.js", "", false);
            }
            GxWebStd.gx_msg_list( context, "", context.GX_msglist.DisplayMode, "", "", sPrefix, "false");
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
            wb_table1_14_3T2( true) ;
         }
         else
         {
            wb_table1_14_3T2( false) ;
         }
         return  ;
      }

      protected void wb_table1_14_3T2e( bool wbgen )
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
            GxWebStd.gx_div_start( context, divDvpanel_unnamedtable2_cell_Internalname, 1, 0, "px", 0, "px", divDvpanel_unnamedtable2_cell_Class, "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divHtml_dvpanel_unnamedtable2_Internalname, 1, 0, "px", 0, "px", "Section", "left", "top", "", "", "div");
            /* User Defined Control */
            ucDvpanel_unnamedtable2.SetProperty("Width", Dvpanel_unnamedtable2_Width);
            ucDvpanel_unnamedtable2.SetProperty("AutoWidth", Dvpanel_unnamedtable2_Autowidth);
            ucDvpanel_unnamedtable2.SetProperty("AutoHeight", Dvpanel_unnamedtable2_Autoheight);
            ucDvpanel_unnamedtable2.SetProperty("Cls", Dvpanel_unnamedtable2_Cls);
            ucDvpanel_unnamedtable2.SetProperty("Title", Dvpanel_unnamedtable2_Title);
            ucDvpanel_unnamedtable2.SetProperty("Collapsible", Dvpanel_unnamedtable2_Collapsible);
            ucDvpanel_unnamedtable2.SetProperty("Collapsed", Dvpanel_unnamedtable2_Collapsed);
            ucDvpanel_unnamedtable2.SetProperty("ShowCollapseIcon", Dvpanel_unnamedtable2_Showcollapseicon);
            ucDvpanel_unnamedtable2.SetProperty("IconPosition", Dvpanel_unnamedtable2_Iconposition);
            ucDvpanel_unnamedtable2.SetProperty("AutoScroll", Dvpanel_unnamedtable2_Autoscroll);
            ucDvpanel_unnamedtable2.Render(context, "dvelop.gxbootstrap.panel", Dvpanel_unnamedtable2_Internalname, sPrefix+"DVPANEL_UNNAMEDTABLE2Container");
            context.WriteHtmlText( "<div class=\"gx_usercontrol_child\" id=\""+sPrefix+"DVPANEL_UNNAMEDTABLE2Container"+"Body"+"\" style=\"display:none;\">") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, divLayout_unnamedtable2_Internalname, 1, 0, "px", 0, "px", "Section", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "Section", "left", "top", " "+"data-gx-base-lib=\"bootstrapv3\""+" "+"data-abstract-form"+" ", "", "div");
            wb_table2_25_3T2( true) ;
         }
         else
         {
            wb_table2_25_3T2( false) ;
         }
         return  ;
      }

      protected void wb_table2_25_3T2e( bool wbgen )
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
            GxWebStd.gx_div_start( context, divTransactiondetail_tableattributes_Internalname, 1, 0, "px", 0, "px", "TableData", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-md-6 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtBR_Information_PatientNo_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtBR_Information_PatientNo_Internalname, "患者编号", "col-sm-3 ReadonlyAttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtBR_Information_PatientNo_Internalname, A36BR_Information_PatientNo, StringUtil.RTrim( context.localUtil.Format( A36BR_Information_PatientNo, "")), "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBR_Information_PatientNo_Jsonclick, 0, "ReadonlyAttribute", "", "", "", "", 1, edtBR_Information_PatientNo_Enabled, 0, "text", "", 80, "chr", 1, "row", 2000, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_BR_EncounterCheckGeneral.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-md-6 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtBR_Encounter_EncID_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtBR_Encounter_EncID_Internalname, "就诊次序", "col-sm-3 ReadonlyAttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtBR_Encounter_EncID_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A35BR_Encounter_EncID), 10, 0, ".", "")), ((edtBR_Encounter_EncID_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A35BR_Encounter_EncID), "ZZZZZZZZZZ")) : context.localUtil.Format( (decimal)(A35BR_Encounter_EncID), "ZZZZZZZZZZ")), "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBR_Encounter_EncID_Jsonclick, 0, "ReadonlyAttribute", "", "", "", "", 1, edtBR_Encounter_EncID_Enabled, 0, "number", "1", 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_BR_EncounterCheckGeneral.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-md-6 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtBR_Encounter_Department_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtBR_Encounter_Department_Internalname, "就诊科室", "col-sm-3 ReadonlyAttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtBR_Encounter_Department_Internalname, A84BR_Encounter_Department, StringUtil.RTrim( context.localUtil.Format( A84BR_Encounter_Department, "")), "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBR_Encounter_Department_Jsonclick, 0, "ReadonlyAttribute", "", "", "", "", 1, edtBR_Encounter_Department_Enabled, 0, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_BR_EncounterCheckGeneral.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-md-6 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtBR_Encounter_ENCType_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtBR_Encounter_ENCType_Internalname, "就诊方式", "col-sm-3 ReadonlyAttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtBR_Encounter_ENCType_Internalname, A90BR_Encounter_ENCType, StringUtil.RTrim( context.localUtil.Format( A90BR_Encounter_ENCType, "")), "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBR_Encounter_ENCType_Jsonclick, 0, "ReadonlyAttribute", "", "", "", "", 1, edtBR_Encounter_ENCType_Enabled, 0, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_BR_EncounterCheckGeneral.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-md-6 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtBR_Encounter_AdmitSource_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtBR_Encounter_AdmitSource_Internalname, "入院原因", "col-sm-3 ReadonlyAttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtBR_Encounter_AdmitSource_Internalname, A92BR_Encounter_AdmitSource, StringUtil.RTrim( context.localUtil.Format( A92BR_Encounter_AdmitSource, "")), "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBR_Encounter_AdmitSource_Jsonclick, 0, "ReadonlyAttribute", "", "", "", "", 1, edtBR_Encounter_AdmitSource_Enabled, 0, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_BR_EncounterCheckGeneral.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-md-6 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtBR_Encounter_AdmitDate_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtBR_Encounter_AdmitDate_Internalname, "就诊/入院时间", "col-sm-3 ReadonlyAttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            context.WriteHtmlText( "<div id=\""+edtBR_Encounter_AdmitDate_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtBR_Encounter_AdmitDate_Internalname, context.localUtil.Format(A91BR_Encounter_AdmitDate, "9999/99/99"), context.localUtil.Format( A91BR_Encounter_AdmitDate, "9999/99/99"), "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBR_Encounter_AdmitDate_Jsonclick, 0, "ReadonlyAttribute", "", "", "", "", 1, edtBR_Encounter_AdmitDate_Enabled, 0, "text", "", 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, 0, true, "DM_Date", "right", false, "HLP_BR_EncounterCheckGeneral.htm");
            GxWebStd.gx_bitmap( context, edtBR_Encounter_AdmitDate_Internalname+"_dp_trigger", context.GetImagePath( "61b9b5d3-dff6-4d59-9b00-da61bc2cbe93", "", context.GetTheme( )), "", "", "", "", ((1==0)||(edtBR_Encounter_AdmitDate_Enabled==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;", "", "", "", "", "", "", "", "", 1, false, false, "", "HLP_BR_EncounterCheckGeneral.htm");
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
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtBR_Encounter_DischargeDate_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtBR_Encounter_DischargeDate_Internalname, "出院时间", "col-sm-3 ReadonlyAttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            context.WriteHtmlText( "<div id=\""+edtBR_Encounter_DischargeDate_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtBR_Encounter_DischargeDate_Internalname, context.localUtil.Format(A93BR_Encounter_DischargeDate, "9999/99/99"), context.localUtil.Format( A93BR_Encounter_DischargeDate, "9999/99/99"), "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBR_Encounter_DischargeDate_Jsonclick, 0, "ReadonlyAttribute", "", "", "", "", 1, edtBR_Encounter_DischargeDate_Enabled, 0, "text", "", 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, 0, true, "DM_Date", "right", false, "HLP_BR_EncounterCheckGeneral.htm");
            GxWebStd.gx_bitmap( context, edtBR_Encounter_DischargeDate_Internalname+"_dp_trigger", context.GetImagePath( "61b9b5d3-dff6-4d59-9b00-da61bc2cbe93", "", context.GetTheme( )), "", "", "", "", ((1==0)||(edtBR_Encounter_DischargeDate_Enabled==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;", "", "", "", "", "", "", "", "", 1, false, false, "", "HLP_BR_EncounterCheckGeneral.htm");
            context.WriteHtmlTextNl( "</div>") ;
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-md-6 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtBR_Encounter_DischargeStatus_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtBR_Encounter_DischargeStatus_Internalname, "出院状态", "col-sm-3 ReadonlyAttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtBR_Encounter_DischargeStatus_Internalname, A94BR_Encounter_DischargeStatus, StringUtil.RTrim( context.localUtil.Format( A94BR_Encounter_DischargeStatus, "")), "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBR_Encounter_DischargeStatus_Jsonclick, 0, "ReadonlyAttribute", "", "", "", "", 1, edtBR_Encounter_DischargeStatus_Enabled, 0, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_BR_EncounterCheckGeneral.htm");
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
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtBR_Information_ID_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A85BR_Information_ID), 18, 0, ".", "")), context.localUtil.Format( (decimal)(A85BR_Information_ID), "ZZZZZZZZZZZZZZZZZZ"), "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBR_Information_ID_Jsonclick, 0, "Attribute", "", "", "", "", edtBR_Information_ID_Visible, 0, 0, "number", "1", 18, "chr", 1, "row", 18, 0, 0, 0, 1, -1, 0, true, "ID", "right", false, "HLP_BR_EncounterCheckGeneral.htm");
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtBR_EncounterID_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A19BR_EncounterID), 18, 0, ".", "")), context.localUtil.Format( (decimal)(A19BR_EncounterID), "ZZZZZZZZZZZZZZZZZZ"), "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBR_EncounterID_Jsonclick, 0, "Attribute", "", "", "", "", edtBR_EncounterID_Visible, 0, 0, "number", "1", 18, "chr", 1, "row", 18, 0, 0, 0, 1, -1, 0, true, "ID", "right", false, "HLP_BR_EncounterCheckGeneral.htm");
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, cmbBR_Encounter_Status, cmbBR_Encounter_Status_Internalname, StringUtil.Trim( StringUtil.Str( (decimal)(A172BR_Encounter_Status), 4, 0)), 1, cmbBR_Encounter_Status_Jsonclick, 0, "'"+sPrefix+"'"+",false,"+"'"+""+"'", "int", "", cmbBR_Encounter_Status.Visible, 0, 0, 0, 0, "em", 0, "", "", "Attribute", "", "", "", "", true, "HLP_BR_EncounterCheckGeneral.htm");
            cmbBR_Encounter_Status.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(A172BR_Encounter_Status), 4, 0));
            context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, cmbBR_Encounter_Status_Internalname, "Values", (String)(cmbBR_Encounter_Status.ToJavascriptSource()), true);
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
         }
         wbLoad = true;
      }

      protected void START3T2( )
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
               STRUP3T0( ) ;
            }
         }
      }

      protected void WS3T2( )
      {
         START3T2( ) ;
         EVT3T2( ) ;
      }

      protected void EVT3T2( )
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
                                 STRUP3T0( ) ;
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
                                 STRUP3T0( ) ;
                              }
                              if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
                              {
                                 context.wbHandled = 1;
                                 if ( ! wbErr )
                                 {
                                    dynload_actions( ) ;
                                    /* Execute user event: Start */
                                    E113T2 ();
                                 }
                              }
                           }
                           else if ( StringUtil.StrCmp(sEvt, "LOAD") == 0 )
                           {
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP3T0( ) ;
                              }
                              if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
                              {
                                 context.wbHandled = 1;
                                 if ( ! wbErr )
                                 {
                                    dynload_actions( ) ;
                                    /* Execute user event: Load */
                                    E123T2 ();
                                 }
                              }
                           }
                           else if ( StringUtil.StrCmp(sEvt, "'DOCHECKENTERING'") == 0 )
                           {
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP3T0( ) ;
                              }
                              if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
                              {
                                 context.wbHandled = 1;
                                 if ( ! wbErr )
                                 {
                                    dynload_actions( ) ;
                                    /* Execute user event: 'DocheckEntering' */
                                    E133T2 ();
                                 }
                              }
                           }
                           else if ( StringUtil.StrCmp(sEvt, "'DOCHECKHISTORY'") == 0 )
                           {
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP3T0( ) ;
                              }
                              if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
                              {
                                 context.wbHandled = 1;
                                 if ( ! wbErr )
                                 {
                                    dynload_actions( ) ;
                                    /* Execute user event: 'DocheckHistory' */
                                    E143T2 ();
                                 }
                              }
                           }
                           else if ( StringUtil.StrCmp(sEvt, "ENTER") == 0 )
                           {
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP3T0( ) ;
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
                                 STRUP3T0( ) ;
                              }
                              if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
                              {
                                 context.wbHandled = 1;
                                 if ( ! wbErr )
                                 {
                                    dynload_actions( ) ;
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

      protected void WE3T2( )
      {
         if ( ! GxWebStd.gx_redirect( context) )
         {
            Rfr0gs = true;
            Refresh( ) ;
            if ( ! GxWebStd.gx_redirect( context) )
            {
               RenderHtmlCloseForm3T2( ) ;
            }
         }
      }

      protected void PA3T2( )
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
         if ( cmbBR_Encounter_Status.ItemCount > 0 )
         {
            A172BR_Encounter_Status = (short)(NumberUtil.Val( cmbBR_Encounter_Status.getValidValue(StringUtil.Trim( StringUtil.Str( (decimal)(A172BR_Encounter_Status), 4, 0))), "."));
            n172BR_Encounter_Status = false;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A172BR_Encounter_Status", StringUtil.LTrim( StringUtil.Str( (decimal)(A172BR_Encounter_Status), 4, 0)));
         }
         if ( context.isAjaxRequest( ) )
         {
            cmbBR_Encounter_Status.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(A172BR_Encounter_Status), 4, 0));
            context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, cmbBR_Encounter_Status_Internalname, "Values", cmbBR_Encounter_Status.ToJavascriptSource(), true);
         }
      }

      public void Refresh( )
      {
         send_integrity_hashes( ) ;
         RF3T2( ) ;
         if ( isFullAjaxMode( ) )
         {
            send_integrity_footer_hashes( ) ;
         }
      }

      protected void initialize_formulas( )
      {
         /* GeneXus formulas. */
         AV19Pgmname = "BR_EncounterCheckGeneral";
         context.Gx_err = 0;
      }

      protected void RF3T2( )
      {
         initialize_formulas( ) ;
         clear_multi_value_controls( ) ;
         gxdyncontrolsrefreshing = true;
         fix_multi_value_controls( ) ;
         gxdyncontrolsrefreshing = false;
         if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
         {
            /* Using cursor H003T2 */
            pr_default.execute(0, new Object[] {A19BR_EncounterID});
            while ( (pr_default.getStatus(0) != 101) )
            {
               A172BR_Encounter_Status = H003T2_A172BR_Encounter_Status[0];
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A172BR_Encounter_Status", StringUtil.LTrim( StringUtil.Str( (decimal)(A172BR_Encounter_Status), 4, 0)));
               n172BR_Encounter_Status = H003T2_n172BR_Encounter_Status[0];
               A85BR_Information_ID = H003T2_A85BR_Information_ID[0];
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A85BR_Information_ID", StringUtil.LTrim( StringUtil.Str( (decimal)(A85BR_Information_ID), 18, 0)));
               n85BR_Information_ID = H003T2_n85BR_Information_ID[0];
               A94BR_Encounter_DischargeStatus = H003T2_A94BR_Encounter_DischargeStatus[0];
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A94BR_Encounter_DischargeStatus", A94BR_Encounter_DischargeStatus);
               n94BR_Encounter_DischargeStatus = H003T2_n94BR_Encounter_DischargeStatus[0];
               A93BR_Encounter_DischargeDate = H003T2_A93BR_Encounter_DischargeDate[0];
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A93BR_Encounter_DischargeDate", context.localUtil.Format(A93BR_Encounter_DischargeDate, "9999/99/99"));
               n93BR_Encounter_DischargeDate = H003T2_n93BR_Encounter_DischargeDate[0];
               A91BR_Encounter_AdmitDate = H003T2_A91BR_Encounter_AdmitDate[0];
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A91BR_Encounter_AdmitDate", context.localUtil.Format(A91BR_Encounter_AdmitDate, "9999/99/99"));
               n91BR_Encounter_AdmitDate = H003T2_n91BR_Encounter_AdmitDate[0];
               A92BR_Encounter_AdmitSource = H003T2_A92BR_Encounter_AdmitSource[0];
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A92BR_Encounter_AdmitSource", A92BR_Encounter_AdmitSource);
               n92BR_Encounter_AdmitSource = H003T2_n92BR_Encounter_AdmitSource[0];
               A90BR_Encounter_ENCType = H003T2_A90BR_Encounter_ENCType[0];
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A90BR_Encounter_ENCType", A90BR_Encounter_ENCType);
               n90BR_Encounter_ENCType = H003T2_n90BR_Encounter_ENCType[0];
               A84BR_Encounter_Department = H003T2_A84BR_Encounter_Department[0];
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A84BR_Encounter_Department", A84BR_Encounter_Department);
               n84BR_Encounter_Department = H003T2_n84BR_Encounter_Department[0];
               A35BR_Encounter_EncID = H003T2_A35BR_Encounter_EncID[0];
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A35BR_Encounter_EncID", StringUtil.LTrim( StringUtil.Str( (decimal)(A35BR_Encounter_EncID), 10, 0)));
               n35BR_Encounter_EncID = H003T2_n35BR_Encounter_EncID[0];
               A36BR_Information_PatientNo = H003T2_A36BR_Information_PatientNo[0];
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A36BR_Information_PatientNo", A36BR_Information_PatientNo);
               n36BR_Information_PatientNo = H003T2_n36BR_Information_PatientNo[0];
               A36BR_Information_PatientNo = H003T2_A36BR_Information_PatientNo[0];
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A36BR_Information_PatientNo", A36BR_Information_PatientNo);
               n36BR_Information_PatientNo = H003T2_n36BR_Information_PatientNo[0];
               /* Execute user event: Load */
               E123T2 ();
               /* Exiting from a For First loop. */
               if (true) break;
            }
            pr_default.close(0);
            WB3T0( ) ;
         }
      }

      protected void send_integrity_lvl_hashes3T2( )
      {
      }

      protected void STRUP3T0( )
      {
         /* Before Start, stand alone formulas. */
         AV19Pgmname = "BR_EncounterCheckGeneral";
         context.Gx_err = 0;
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0;
         /* Execute user event: Start */
         E113T2 ();
         context.wbGlbDoneStart = 1;
         nDoneStart = 1;
         /* After Start, stand alone formulas. */
         sXEvt = cgiGet( "_EventName");
         if ( ! GetJustCreated( ) && ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 ) )
         {
            /* Read saved SDTs. */
            /* Read variables values. */
            A36BR_Information_PatientNo = cgiGet( edtBR_Information_PatientNo_Internalname);
            n36BR_Information_PatientNo = false;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A36BR_Information_PatientNo", A36BR_Information_PatientNo);
            A35BR_Encounter_EncID = (long)(context.localUtil.CToN( cgiGet( edtBR_Encounter_EncID_Internalname), ".", ","));
            n35BR_Encounter_EncID = false;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A35BR_Encounter_EncID", StringUtil.LTrim( StringUtil.Str( (decimal)(A35BR_Encounter_EncID), 10, 0)));
            A84BR_Encounter_Department = cgiGet( edtBR_Encounter_Department_Internalname);
            n84BR_Encounter_Department = false;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A84BR_Encounter_Department", A84BR_Encounter_Department);
            A90BR_Encounter_ENCType = cgiGet( edtBR_Encounter_ENCType_Internalname);
            n90BR_Encounter_ENCType = false;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A90BR_Encounter_ENCType", A90BR_Encounter_ENCType);
            A92BR_Encounter_AdmitSource = cgiGet( edtBR_Encounter_AdmitSource_Internalname);
            n92BR_Encounter_AdmitSource = false;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A92BR_Encounter_AdmitSource", A92BR_Encounter_AdmitSource);
            A91BR_Encounter_AdmitDate = context.localUtil.CToD( cgiGet( edtBR_Encounter_AdmitDate_Internalname), 0);
            n91BR_Encounter_AdmitDate = false;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A91BR_Encounter_AdmitDate", context.localUtil.Format(A91BR_Encounter_AdmitDate, "9999/99/99"));
            A93BR_Encounter_DischargeDate = context.localUtil.CToD( cgiGet( edtBR_Encounter_DischargeDate_Internalname), 0);
            n93BR_Encounter_DischargeDate = false;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A93BR_Encounter_DischargeDate", context.localUtil.Format(A93BR_Encounter_DischargeDate, "9999/99/99"));
            A94BR_Encounter_DischargeStatus = cgiGet( edtBR_Encounter_DischargeStatus_Internalname);
            n94BR_Encounter_DischargeStatus = false;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A94BR_Encounter_DischargeStatus", A94BR_Encounter_DischargeStatus);
            A85BR_Information_ID = (long)(context.localUtil.CToN( cgiGet( edtBR_Information_ID_Internalname), ".", ","));
            n85BR_Information_ID = false;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A85BR_Information_ID", StringUtil.LTrim( StringUtil.Str( (decimal)(A85BR_Information_ID), 18, 0)));
            cmbBR_Encounter_Status.CurrentValue = cgiGet( cmbBR_Encounter_Status_Internalname);
            A172BR_Encounter_Status = (short)(NumberUtil.Val( cgiGet( cmbBR_Encounter_Status_Internalname), "."));
            n172BR_Encounter_Status = false;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A172BR_Encounter_Status", StringUtil.LTrim( StringUtil.Str( (decimal)(A172BR_Encounter_Status), 4, 0)));
            /* Read saved values. */
            wcpOA19BR_EncounterID = (long)(context.localUtil.CToN( cgiGet( sPrefix+"wcpOA19BR_EncounterID"), ".", ","));
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
            Dvpanel_unnamedtable2_Width = cgiGet( sPrefix+"DVPANEL_UNNAMEDTABLE2_Width");
            Dvpanel_unnamedtable2_Cls = cgiGet( sPrefix+"DVPANEL_UNNAMEDTABLE2_Cls");
            Dvpanel_unnamedtable2_Title = cgiGet( sPrefix+"DVPANEL_UNNAMEDTABLE2_Title");
            Dvpanel_unnamedtable2_Collapsible = StringUtil.StrToBool( cgiGet( sPrefix+"DVPANEL_UNNAMEDTABLE2_Collapsible"));
            Dvpanel_unnamedtable2_Collapsed = StringUtil.StrToBool( cgiGet( sPrefix+"DVPANEL_UNNAMEDTABLE2_Collapsed"));
            Dvpanel_unnamedtable2_Autowidth = StringUtil.StrToBool( cgiGet( sPrefix+"DVPANEL_UNNAMEDTABLE2_Autowidth"));
            Dvpanel_unnamedtable2_Autoheight = StringUtil.StrToBool( cgiGet( sPrefix+"DVPANEL_UNNAMEDTABLE2_Autoheight"));
            Dvpanel_unnamedtable2_Showcollapseicon = StringUtil.StrToBool( cgiGet( sPrefix+"DVPANEL_UNNAMEDTABLE2_Showcollapseicon"));
            Dvpanel_unnamedtable2_Iconposition = cgiGet( sPrefix+"DVPANEL_UNNAMEDTABLE2_Iconposition");
            Dvpanel_unnamedtable2_Autoscroll = StringUtil.StrToBool( cgiGet( sPrefix+"DVPANEL_UNNAMEDTABLE2_Autoscroll"));
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
         E113T2 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E113T2( )
      {
         /* Start Routine */
         new GeneXus.Programs.wwpbaseobjects.loadwwpcontext(context ).execute( out  AV6WWPContext) ;
         /* Execute user subroutine: 'PREPARETRANSACTION' */
         S112 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void nextLoad( )
      {
      }

      protected void E123T2( )
      {
         /* Load Routine */
         edtBR_Information_ID_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtBR_Information_ID_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBR_Information_ID_Visible), 5, 0)), true);
         edtBR_EncounterID_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtBR_EncounterID_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBR_EncounterID_Visible), 5, 0)), true);
         cmbBR_Encounter_Status.Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, cmbBR_Encounter_Status_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(cmbBR_Encounter_Status.Visible), 5, 0)), true);
         GXt_boolean1 = AV13TempBoolean;
         new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "Check_RefuteReason", out  GXt_boolean1) ;
         AV13TempBoolean = GXt_boolean1;
         if ( ! ( AV13TempBoolean ) )
         {
            bttBtncheckentering_Visible = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, bttBtncheckentering_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtncheckentering_Visible), 5, 0)), true);
         }
         GXt_boolean1 = AV13TempBoolean;
         new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "Check_FlowStatus_History", out  GXt_boolean1) ;
         AV13TempBoolean = GXt_boolean1;
         if ( ! ( AV13TempBoolean ) )
         {
            bttBtncheckhistory_Visible = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, bttBtncheckhistory_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtncheckhistory_Visible), 5, 0)), true);
         }
         if ( ! ( new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context).executeUdp(  "Check_FlowStatus_History") ) )
         {
            divDvpanel_unnamedtable1_cell_Class = "Invisible";
            context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, divDvpanel_unnamedtable1_cell_Internalname, "Class", divDvpanel_unnamedtable1_cell_Class, true);
         }
         else
         {
            divDvpanel_unnamedtable1_cell_Class = "col-xs-12";
            context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, divDvpanel_unnamedtable1_cell_Internalname, "Class", divDvpanel_unnamedtable1_cell_Class, true);
         }
         if ( ! ( new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context).executeUdp(  "Check_RefuteReason") ) )
         {
            divDvpanel_unnamedtable2_cell_Class = "Invisible";
            context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, divDvpanel_unnamedtable2_cell_Internalname, "Class", divDvpanel_unnamedtable2_cell_Class, true);
         }
         else
         {
            divDvpanel_unnamedtable2_cell_Class = "col-xs-12";
            context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, divDvpanel_unnamedtable2_cell_Internalname, "Class", divDvpanel_unnamedtable2_cell_Class, true);
         }
      }

      protected void E133T2( )
      {
         /* 'DocheckEntering' Routine */
         new zutil_checksession(context ).execute( out  AV16tCheckFlag) ;
         if ( ! AV16tCheckFlag )
         {
            context.PopUp(formatLink("br_enteringsubmitdetail.aspx") + "?" + UrlEncode("" +A19BR_EncounterID), new Object[] {});
         }
      }

      protected void E143T2( )
      {
         /* 'DocheckHistory' Routine */
         new zutil_checksession(context ).execute( out  AV16tCheckFlag) ;
         if ( ! AV16tCheckFlag )
         {
            CallWebObject(formatLink("br_encounterdetail.aspx") + "?" + UrlEncode("" +A19BR_EncounterID));
            context.wjLocDisableFrm = 1;
         }
      }

      protected void S112( )
      {
         /* 'PREPARETRANSACTION' Routine */
         AV9TrnContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext(context);
         AV9TrnContext.gxTpr_Callerobject = AV19Pgmname;
         AV9TrnContext.gxTpr_Callerondelete = false;
         AV9TrnContext.gxTpr_Callerurl = AV12HTTPRequest.ScriptName+"?"+AV12HTTPRequest.QueryString;
         AV9TrnContext.gxTpr_Transactionname = "BR_Encounter";
         AV10TrnContextAtt = new GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext_Attribute(context);
         AV10TrnContextAtt.gxTpr_Attributename = "BR_EncounterID";
         AV10TrnContextAtt.gxTpr_Attributevalue = StringUtil.Str( (decimal)(AV8BR_EncounterID), 18, 0);
         AV9TrnContext.gxTpr_Attributes.Add(AV10TrnContextAtt, 0);
         AV11Session.Set("TrnContext", AV9TrnContext.ToXml(false, true, "WWPTransactionContext", "DataAnalysisPlatform"));
      }

      protected void wb_table2_25_3T2( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "";
            GxWebStd.gx_table_start( context, tblUnnamedtable2_Internalname, tblUnnamedtable2_Internalname, "", "", 0, "", "", 1, 2, sStyleString, "", "", 0);
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 28,'" + sPrefix + "',false,'',0)\"";
            ClassString = "ButtonMaterial";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtncheckentering_Internalname, "", "审批不通过原因", bttBtncheckentering_Jsonclick, 5, "审批不通过原因", "", StyleString, ClassString, bttBtncheckentering_Visible, 1, "standard", "'"+sPrefix+"'"+",false,"+"'"+sPrefix+"E\\'DOCHECKENTERING\\'."+"'", TempTags, "", context.GetButtonType( ), "HLP_BR_EncounterCheckGeneral.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table2_25_3T2e( true) ;
         }
         else
         {
            wb_table2_25_3T2e( false) ;
         }
      }

      protected void wb_table1_14_3T2( bool wbgen )
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
            GxWebStd.gx_button_ctrl( context, bttBtncheckhistory_Internalname, "", "查看审批情况", bttBtncheckhistory_Jsonclick, 5, "查看审批情况", "", StyleString, ClassString, bttBtncheckhistory_Visible, 1, "standard", "'"+sPrefix+"'"+",false,"+"'"+sPrefix+"E\\'DOCHECKHISTORY\\'."+"'", TempTags, "", context.GetButtonType( ), "HLP_BR_EncounterCheckGeneral.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table1_14_3T2e( true) ;
         }
         else
         {
            wb_table1_14_3T2e( false) ;
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
         PA3T2( ) ;
         WS3T2( ) ;
         WE3T2( ) ;
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
         PA3T2( ) ;
         WCParametersGet( ) ;
      }

      public override void componentprepare( Object[] obj )
      {
         wbLoad = false;
         sCompPrefix = (String)getParm(obj,0);
         sSFPrefix = (String)getParm(obj,1);
         sPrefix = sCompPrefix + sSFPrefix;
         AddComponentObject(sPrefix, "br_encountercheckgeneral", GetJustCreated( ));
         if ( ( nDoneStart == 0 ) && ( nDynComponent == 0 ) )
         {
            INITWEB( ) ;
         }
         else
         {
            init_default_properties( ) ;
            init_web_controls( ) ;
         }
         PA3T2( ) ;
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
         PA3T2( ) ;
         sEvt = sCompEvt;
         WCParametersGet( ) ;
         WS3T2( ) ;
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
         WS3T2( ) ;
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
         WE3T2( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?2020227935411", true);
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
         context.AddJavascriptSource("br_encountercheckgeneral.js", "?2020227935411", false);
         context.AddJavascriptSource("DVelop/Bootstrap/Shared/DVelopBootstrap.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/Panel/BootstrapPanelRender.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/Shared/DVelopBootstrap.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/Panel/BootstrapPanelRender.js", "", false);
         /* End function include_jscripts */
      }

      protected void init_web_controls( )
      {
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
         }
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
         bttBtncheckentering_Internalname = sPrefix+"BTNCHECKENTERING";
         tblUnnamedtable2_Internalname = sPrefix+"UNNAMEDTABLE2";
         divLayout_unnamedtable2_Internalname = sPrefix+"LAYOUT_UNNAMEDTABLE2";
         Dvpanel_unnamedtable2_Internalname = sPrefix+"DVPANEL_UNNAMEDTABLE2";
         divHtml_dvpanel_unnamedtable2_Internalname = sPrefix+"HTML_DVPANEL_UNNAMEDTABLE2";
         divDvpanel_unnamedtable2_cell_Internalname = sPrefix+"DVPANEL_UNNAMEDTABLE2_CELL";
         edtBR_Information_PatientNo_Internalname = sPrefix+"BR_INFORMATION_PATIENTNO";
         edtBR_Encounter_EncID_Internalname = sPrefix+"BR_ENCOUNTER_ENCID";
         edtBR_Encounter_Department_Internalname = sPrefix+"BR_ENCOUNTER_DEPARTMENT";
         edtBR_Encounter_ENCType_Internalname = sPrefix+"BR_ENCOUNTER_ENCTYPE";
         edtBR_Encounter_AdmitSource_Internalname = sPrefix+"BR_ENCOUNTER_ADMITSOURCE";
         edtBR_Encounter_AdmitDate_Internalname = sPrefix+"BR_ENCOUNTER_ADMITDATE";
         edtBR_Encounter_DischargeDate_Internalname = sPrefix+"BR_ENCOUNTER_DISCHARGEDATE";
         edtBR_Encounter_DischargeStatus_Internalname = sPrefix+"BR_ENCOUNTER_DISCHARGESTATUS";
         divTransactiondetail_tableattributes_Internalname = sPrefix+"TRANSACTIONDETAIL_TABLEATTRIBUTES";
         divTable_Internalname = sPrefix+"TABLE";
         edtBR_Information_ID_Internalname = sPrefix+"BR_INFORMATION_ID";
         edtBR_EncounterID_Internalname = sPrefix+"BR_ENCOUNTERID";
         cmbBR_Encounter_Status_Internalname = sPrefix+"BR_ENCOUNTER_STATUS";
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
         bttBtncheckhistory_Visible = 1;
         bttBtncheckentering_Visible = 1;
         cmbBR_Encounter_Status_Jsonclick = "";
         cmbBR_Encounter_Status.Visible = 1;
         edtBR_EncounterID_Jsonclick = "";
         edtBR_EncounterID_Visible = 1;
         edtBR_Information_ID_Jsonclick = "";
         edtBR_Information_ID_Visible = 1;
         edtBR_Encounter_DischargeStatus_Jsonclick = "";
         edtBR_Encounter_DischargeStatus_Enabled = 0;
         edtBR_Encounter_DischargeDate_Jsonclick = "";
         edtBR_Encounter_DischargeDate_Enabled = 0;
         edtBR_Encounter_AdmitDate_Jsonclick = "";
         edtBR_Encounter_AdmitDate_Enabled = 0;
         edtBR_Encounter_AdmitSource_Jsonclick = "";
         edtBR_Encounter_AdmitSource_Enabled = 0;
         edtBR_Encounter_ENCType_Jsonclick = "";
         edtBR_Encounter_ENCType_Enabled = 0;
         edtBR_Encounter_Department_Jsonclick = "";
         edtBR_Encounter_Department_Enabled = 0;
         edtBR_Encounter_EncID_Jsonclick = "";
         edtBR_Encounter_EncID_Enabled = 0;
         edtBR_Information_PatientNo_Jsonclick = "";
         edtBR_Information_PatientNo_Enabled = 0;
         divDvpanel_unnamedtable2_cell_Class = "col-xs-12";
         divDvpanel_unnamedtable1_cell_Class = "col-xs-12";
         Dvpanel_unnamedtable2_Autoscroll = Convert.ToBoolean( 0);
         Dvpanel_unnamedtable2_Iconposition = "left";
         Dvpanel_unnamedtable2_Showcollapseicon = Convert.ToBoolean( 0);
         Dvpanel_unnamedtable2_Autoheight = Convert.ToBoolean( -1);
         Dvpanel_unnamedtable2_Autowidth = Convert.ToBoolean( 0);
         Dvpanel_unnamedtable2_Collapsed = Convert.ToBoolean( 0);
         Dvpanel_unnamedtable2_Collapsible = Convert.ToBoolean( -1);
         Dvpanel_unnamedtable2_Title = "";
         Dvpanel_unnamedtable2_Cls = "PanelNoHeader";
         Dvpanel_unnamedtable2_Width = "100%";
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
         setEventMetadata("'DOCHECKENTERING'","{handler:'E133T2',iparms:[{av:'A19BR_EncounterID',fld:'BR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ'}]");
         setEventMetadata("'DOCHECKENTERING'",",oparms:[]}");
         setEventMetadata("'DOCHECKHISTORY'","{handler:'E143T2',iparms:[{av:'A19BR_EncounterID',fld:'BR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ'}]");
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
         AV19Pgmname = "";
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         GXKey = "";
         GX_FocusControl = "";
         ucDvpanel_unnamedtable1 = new GXUserControl();
         ucDvpanel_unnamedtable2 = new GXUserControl();
         A36BR_Information_PatientNo = "";
         A84BR_Encounter_Department = "";
         A90BR_Encounter_ENCType = "";
         A92BR_Encounter_AdmitSource = "";
         A91BR_Encounter_AdmitDate = DateTime.MinValue;
         A93BR_Encounter_DischargeDate = DateTime.MinValue;
         A94BR_Encounter_DischargeStatus = "";
         Form = new GXWebForm();
         sXEvt = "";
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         scmdbuf = "";
         H003T2_A19BR_EncounterID = new long[1] ;
         H003T2_A172BR_Encounter_Status = new short[1] ;
         H003T2_n172BR_Encounter_Status = new bool[] {false} ;
         H003T2_A85BR_Information_ID = new long[1] ;
         H003T2_n85BR_Information_ID = new bool[] {false} ;
         H003T2_A94BR_Encounter_DischargeStatus = new String[] {""} ;
         H003T2_n94BR_Encounter_DischargeStatus = new bool[] {false} ;
         H003T2_A93BR_Encounter_DischargeDate = new DateTime[] {DateTime.MinValue} ;
         H003T2_n93BR_Encounter_DischargeDate = new bool[] {false} ;
         H003T2_A91BR_Encounter_AdmitDate = new DateTime[] {DateTime.MinValue} ;
         H003T2_n91BR_Encounter_AdmitDate = new bool[] {false} ;
         H003T2_A92BR_Encounter_AdmitSource = new String[] {""} ;
         H003T2_n92BR_Encounter_AdmitSource = new bool[] {false} ;
         H003T2_A90BR_Encounter_ENCType = new String[] {""} ;
         H003T2_n90BR_Encounter_ENCType = new bool[] {false} ;
         H003T2_A84BR_Encounter_Department = new String[] {""} ;
         H003T2_n84BR_Encounter_Department = new bool[] {false} ;
         H003T2_A35BR_Encounter_EncID = new long[1] ;
         H003T2_n35BR_Encounter_EncID = new bool[] {false} ;
         H003T2_A36BR_Information_PatientNo = new String[] {""} ;
         H003T2_n36BR_Information_PatientNo = new bool[] {false} ;
         AV6WWPContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPContext(context);
         AV9TrnContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext(context);
         AV12HTTPRequest = new GxHttpRequest( context);
         AV10TrnContextAtt = new GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext_Attribute(context);
         AV11Session = context.GetSession();
         sStyleString = "";
         TempTags = "";
         ClassString = "";
         StyleString = "";
         bttBtncheckentering_Jsonclick = "";
         bttBtncheckhistory_Jsonclick = "";
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         sCtrlA19BR_EncounterID = "";
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.br_encountercheckgeneral__default(),
            new Object[][] {
                new Object[] {
               H003T2_A19BR_EncounterID, H003T2_A172BR_Encounter_Status, H003T2_n172BR_Encounter_Status, H003T2_A85BR_Information_ID, H003T2_n85BR_Information_ID, H003T2_A94BR_Encounter_DischargeStatus, H003T2_n94BR_Encounter_DischargeStatus, H003T2_A93BR_Encounter_DischargeDate, H003T2_n93BR_Encounter_DischargeDate, H003T2_A91BR_Encounter_AdmitDate,
               H003T2_n91BR_Encounter_AdmitDate, H003T2_A92BR_Encounter_AdmitSource, H003T2_n92BR_Encounter_AdmitSource, H003T2_A90BR_Encounter_ENCType, H003T2_n90BR_Encounter_ENCType, H003T2_A84BR_Encounter_Department, H003T2_n84BR_Encounter_Department, H003T2_A35BR_Encounter_EncID, H003T2_n35BR_Encounter_EncID, H003T2_A36BR_Information_PatientNo,
               H003T2_n36BR_Information_PatientNo
               }
            }
         );
         AV19Pgmname = "BR_EncounterCheckGeneral";
         /* GeneXus formulas. */
         AV19Pgmname = "BR_EncounterCheckGeneral";
         context.Gx_err = 0;
      }

      private short nGotPars ;
      private short GxWebError ;
      private short nDynComponent ;
      private short initialized ;
      private short wbEnd ;
      private short wbStart ;
      private short A172BR_Encounter_Status ;
      private short nDraw ;
      private short nDoneStart ;
      private short nDonePA ;
      private short gxcookieaux ;
      private short nGXWrapped ;
      private int edtBR_Information_PatientNo_Enabled ;
      private int edtBR_Encounter_EncID_Enabled ;
      private int edtBR_Encounter_Department_Enabled ;
      private int edtBR_Encounter_ENCType_Enabled ;
      private int edtBR_Encounter_AdmitSource_Enabled ;
      private int edtBR_Encounter_AdmitDate_Enabled ;
      private int edtBR_Encounter_DischargeDate_Enabled ;
      private int edtBR_Encounter_DischargeStatus_Enabled ;
      private int edtBR_Information_ID_Visible ;
      private int edtBR_EncounterID_Visible ;
      private int bttBtncheckentering_Visible ;
      private int bttBtncheckhistory_Visible ;
      private int idxLst ;
      private long A19BR_EncounterID ;
      private long wcpOA19BR_EncounterID ;
      private long A35BR_Encounter_EncID ;
      private long A85BR_Information_ID ;
      private long AV8BR_EncounterID ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String sPrefix ;
      private String sCompPrefix ;
      private String sSFPrefix ;
      private String AV19Pgmname ;
      private String sDynURL ;
      private String FormProcess ;
      private String bodyStyle ;
      private String GXKey ;
      private String Dvpanel_unnamedtable1_Width ;
      private String Dvpanel_unnamedtable1_Cls ;
      private String Dvpanel_unnamedtable1_Title ;
      private String Dvpanel_unnamedtable1_Iconposition ;
      private String Dvpanel_unnamedtable2_Width ;
      private String Dvpanel_unnamedtable2_Cls ;
      private String Dvpanel_unnamedtable2_Title ;
      private String Dvpanel_unnamedtable2_Iconposition ;
      private String GX_FocusControl ;
      private String divLayoutmaintable_Internalname ;
      private String divTable_Internalname ;
      private String divDvpanel_unnamedtable1_cell_Internalname ;
      private String divDvpanel_unnamedtable1_cell_Class ;
      private String divHtml_dvpanel_unnamedtable1_Internalname ;
      private String Dvpanel_unnamedtable1_Internalname ;
      private String divLayout_unnamedtable1_Internalname ;
      private String divDvpanel_unnamedtable2_cell_Internalname ;
      private String divDvpanel_unnamedtable2_cell_Class ;
      private String divHtml_dvpanel_unnamedtable2_Internalname ;
      private String Dvpanel_unnamedtable2_Internalname ;
      private String divLayout_unnamedtable2_Internalname ;
      private String divTransactiondetail_tableattributes_Internalname ;
      private String edtBR_Information_PatientNo_Internalname ;
      private String edtBR_Information_PatientNo_Jsonclick ;
      private String edtBR_Encounter_EncID_Internalname ;
      private String edtBR_Encounter_EncID_Jsonclick ;
      private String edtBR_Encounter_Department_Internalname ;
      private String edtBR_Encounter_Department_Jsonclick ;
      private String edtBR_Encounter_ENCType_Internalname ;
      private String edtBR_Encounter_ENCType_Jsonclick ;
      private String edtBR_Encounter_AdmitSource_Internalname ;
      private String edtBR_Encounter_AdmitSource_Jsonclick ;
      private String edtBR_Encounter_AdmitDate_Internalname ;
      private String edtBR_Encounter_AdmitDate_Jsonclick ;
      private String edtBR_Encounter_DischargeDate_Internalname ;
      private String edtBR_Encounter_DischargeDate_Jsonclick ;
      private String edtBR_Encounter_DischargeStatus_Internalname ;
      private String edtBR_Encounter_DischargeStatus_Jsonclick ;
      private String divHtml_bottomauxiliarcontrols_Internalname ;
      private String edtBR_Information_ID_Internalname ;
      private String edtBR_Information_ID_Jsonclick ;
      private String edtBR_EncounterID_Internalname ;
      private String edtBR_EncounterID_Jsonclick ;
      private String cmbBR_Encounter_Status_Internalname ;
      private String cmbBR_Encounter_Status_Jsonclick ;
      private String sXEvt ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String scmdbuf ;
      private String bttBtncheckentering_Internalname ;
      private String bttBtncheckhistory_Internalname ;
      private String sStyleString ;
      private String tblUnnamedtable2_Internalname ;
      private String TempTags ;
      private String ClassString ;
      private String StyleString ;
      private String bttBtncheckentering_Jsonclick ;
      private String tblUnnamedtable1_Internalname ;
      private String bttBtncheckhistory_Jsonclick ;
      private String sCtrlA19BR_EncounterID ;
      private DateTime A91BR_Encounter_AdmitDate ;
      private DateTime A93BR_Encounter_DischargeDate ;
      private bool entryPointCalled ;
      private bool toggleJsOutput ;
      private bool Dvpanel_unnamedtable1_Collapsible ;
      private bool Dvpanel_unnamedtable1_Collapsed ;
      private bool Dvpanel_unnamedtable1_Autowidth ;
      private bool Dvpanel_unnamedtable1_Autoheight ;
      private bool Dvpanel_unnamedtable1_Showcollapseicon ;
      private bool Dvpanel_unnamedtable1_Autoscroll ;
      private bool Dvpanel_unnamedtable2_Collapsible ;
      private bool Dvpanel_unnamedtable2_Collapsed ;
      private bool Dvpanel_unnamedtable2_Autowidth ;
      private bool Dvpanel_unnamedtable2_Autoheight ;
      private bool Dvpanel_unnamedtable2_Showcollapseicon ;
      private bool Dvpanel_unnamedtable2_Autoscroll ;
      private bool wbLoad ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool n172BR_Encounter_Status ;
      private bool gxdyncontrolsrefreshing ;
      private bool n85BR_Information_ID ;
      private bool n94BR_Encounter_DischargeStatus ;
      private bool n93BR_Encounter_DischargeDate ;
      private bool n91BR_Encounter_AdmitDate ;
      private bool n92BR_Encounter_AdmitSource ;
      private bool n90BR_Encounter_ENCType ;
      private bool n84BR_Encounter_Department ;
      private bool n35BR_Encounter_EncID ;
      private bool n36BR_Information_PatientNo ;
      private bool returnInSub ;
      private bool AV13TempBoolean ;
      private bool GXt_boolean1 ;
      private bool AV16tCheckFlag ;
      private String A36BR_Information_PatientNo ;
      private String A84BR_Encounter_Department ;
      private String A90BR_Encounter_ENCType ;
      private String A92BR_Encounter_AdmitSource ;
      private String A94BR_Encounter_DischargeStatus ;
      private GXUserControl ucDvpanel_unnamedtable1 ;
      private GXUserControl ucDvpanel_unnamedtable2 ;
      private GXWebForm Form ;
      private IGxDataStore dsDataStore1 ;
      private IGxDataStore dsDefault ;
      private GXCombobox cmbBR_Encounter_Status ;
      private IDataStoreProvider pr_default ;
      private long[] H003T2_A19BR_EncounterID ;
      private short[] H003T2_A172BR_Encounter_Status ;
      private bool[] H003T2_n172BR_Encounter_Status ;
      private long[] H003T2_A85BR_Information_ID ;
      private bool[] H003T2_n85BR_Information_ID ;
      private String[] H003T2_A94BR_Encounter_DischargeStatus ;
      private bool[] H003T2_n94BR_Encounter_DischargeStatus ;
      private DateTime[] H003T2_A93BR_Encounter_DischargeDate ;
      private bool[] H003T2_n93BR_Encounter_DischargeDate ;
      private DateTime[] H003T2_A91BR_Encounter_AdmitDate ;
      private bool[] H003T2_n91BR_Encounter_AdmitDate ;
      private String[] H003T2_A92BR_Encounter_AdmitSource ;
      private bool[] H003T2_n92BR_Encounter_AdmitSource ;
      private String[] H003T2_A90BR_Encounter_ENCType ;
      private bool[] H003T2_n90BR_Encounter_ENCType ;
      private String[] H003T2_A84BR_Encounter_Department ;
      private bool[] H003T2_n84BR_Encounter_Department ;
      private long[] H003T2_A35BR_Encounter_EncID ;
      private bool[] H003T2_n35BR_Encounter_EncID ;
      private String[] H003T2_A36BR_Information_PatientNo ;
      private bool[] H003T2_n36BR_Information_PatientNo ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private GxHttpRequest AV12HTTPRequest ;
      private IGxSession AV11Session ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext AV9TrnContext ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext_Attribute AV10TrnContextAtt ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPContext AV6WWPContext ;
   }

   public class br_encountercheckgeneral__default : DataStoreHelperBase, IDataStoreHelper
   {
      public ICursor[] getCursors( )
      {
         cursorDefinitions();
         return new Cursor[] {
          new ForEachCursor(def[0])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmH003T2 ;
          prmH003T2 = new Object[] {
          new Object[] {"@BR_EncounterID",SqlDbType.Decimal,18,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("H003T2", "SELECT T1.[BR_EncounterID], T1.[BR_Encounter_Status], T1.[BR_Information_ID], T1.[BR_Encounter_DischargeStatus], T1.[BR_Encounter_DischargeDate], T1.[BR_Encounter_AdmitDate], T1.[BR_Encounter_AdmitSource], T1.[BR_Encounter_ENCType], T1.[BR_Encounter_Department], T1.[BR_Encounter_EncID], T2.[BR_Information_PatientNo] FROM ([BR_Encounter] T1 WITH (NOLOCK) LEFT JOIN [BR_Information] T2 WITH (NOLOCK) ON T2.[BR_Information_ID] = T1.[BR_Information_ID]) WHERE T1.[BR_EncounterID] = @BR_EncounterID ORDER BY T1.[BR_EncounterID] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH003T2,1,0,true,true )
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
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
                ((long[]) buf[3])[0] = rslt.getLong(3) ;
                ((bool[]) buf[4])[0] = rslt.wasNull(3);
                ((String[]) buf[5])[0] = rslt.getVarchar(4) ;
                ((bool[]) buf[6])[0] = rslt.wasNull(4);
                ((DateTime[]) buf[7])[0] = rslt.getGXDate(5) ;
                ((bool[]) buf[8])[0] = rslt.wasNull(5);
                ((DateTime[]) buf[9])[0] = rslt.getGXDate(6) ;
                ((bool[]) buf[10])[0] = rslt.wasNull(6);
                ((String[]) buf[11])[0] = rslt.getVarchar(7) ;
                ((bool[]) buf[12])[0] = rslt.wasNull(7);
                ((String[]) buf[13])[0] = rslt.getVarchar(8) ;
                ((bool[]) buf[14])[0] = rslt.wasNull(8);
                ((String[]) buf[15])[0] = rslt.getVarchar(9) ;
                ((bool[]) buf[16])[0] = rslt.wasNull(9);
                ((long[]) buf[17])[0] = rslt.getLong(10) ;
                ((bool[]) buf[18])[0] = rslt.wasNull(10);
                ((String[]) buf[19])[0] = rslt.getVarchar(11) ;
                ((bool[]) buf[20])[0] = rslt.wasNull(11);
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
       }
    }

 }

}
