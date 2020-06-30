/*
               File: DashBoard
        Description: Data Mgmt Portal - RAAP
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/28/2020 15:9:7.1
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
   public class dashboard : GXDataArea, System.Web.SessionState.IRequiresSessionState
   {
      public dashboard( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public dashboard( IGxContext context )
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
         PA092( ) ;
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0));
         if ( ( gxajaxcallmode == 0 ) && ( GxWebError == 0 ) )
         {
            START092( ) ;
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
         context.AddJavascriptSource("gxcfg.js", "?202022815976", false);
         if ( context.isSpaRequest( ) )
         {
            enableOutput();
         }
         context.AddJavascriptSource("DVelop/Bootstrap/Shared/DVelopBootstrap.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/Panel/BootstrapPanelRender.js", "", false);
         context.AddJavascriptSource("sgHighChartsBasic/highcharts.js", "", false);
         context.AddJavascriptSource("sgHighChartsBasic/sgHighChartsBasicRender.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/Shared/DVelopBootstrap.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/Panel/BootstrapPanelRender.js", "", false);
         context.AddJavascriptSource("sgHighChartsBasic/highcharts.js", "", false);
         context.AddJavascriptSource("sgHighChartsBasic/sgHighChartsBasicRender.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/Shared/DVelopBootstrap.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/Panel/BootstrapPanelRender.js", "", false);
         context.AddJavascriptSource("sgHighChartsBasic/highcharts.js", "", false);
         context.AddJavascriptSource("sgHighChartsBasic/sgHighChartsBasicRender.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/Shared/DVelopBootstrap.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/Panel/BootstrapPanelRender.js", "", false);
         context.AddJavascriptSource("sgHighChartsBasic/highcharts.js", "", false);
         context.AddJavascriptSource("sgHighChartsBasic/sgHighChartsBasicRender.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/Shared/DVelopBootstrap.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/Panel/BootstrapPanelRender.js", "", false);
         context.AddJavascriptSource("sgHighChartsBasic/highcharts.js", "", false);
         context.AddJavascriptSource("sgHighChartsBasic/sgHighChartsBasicRender.js", "", false);
         context.WriteHtmlText( Form.Headerrawhtml) ;
         context.CloseHtmlHeader();
         if ( context.isSpaRequest( ) )
         {
            disableOutput();
         }
         FormProcess = ((nGXWrapped==0) ? " data-HasEnter=\"false\" data-Skiponenter=\"false\"" : "");
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
         if ( nGXWrapped != 1 )
         {
            context.WriteHtmlTextNl( "<form id=\"MAINFORM\" autocomplete=\"off\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("dashboard.aspx") +"\">") ;
            GxWebStd.gx_hidden_field( context, "_EventName", "");
            GxWebStd.gx_hidden_field( context, "_EventGridId", "");
            GxWebStd.gx_hidden_field( context, "_EventRowId", "");
            context.WriteHtmlText( "<input type=\"submit\" title=\"submit\" style=\"display:none\" disabled>") ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, "FORM", "Class", "form-horizontal Form", true);
         }
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
         GxWebStd.gx_hidden_field( context, "vTSITUATION", AV36tSituation);
         GxWebStd.gx_hidden_field( context, "vTENTITYSITUATION", AV56tEntitySituation);
         GxWebStd.gx_hidden_field( context, "vTRANDOMSITUATION", AV69tRandomSituation);
         GxWebStd.gx_hidden_field( context, "vTTENANTSITUATION", AV68tTenantSituation);
         GxWebStd.gx_hidden_field( context, "vTENTRYAMOUNT", AV55tEntryAmount);
         GxWebStd.gx_hidden_field( context, "VSITUATIONIMAGE_Width", StringUtil.RTrim( Vsituationimage_Width));
         GxWebStd.gx_hidden_field( context, "VSITUATIONIMAGE_Height", StringUtil.RTrim( Vsituationimage_Height));
         GxWebStd.gx_hidden_field( context, "DVPANEL_UNNAMEDTABLE2_Width", StringUtil.RTrim( Dvpanel_unnamedtable2_Width));
         GxWebStd.gx_hidden_field( context, "DVPANEL_UNNAMEDTABLE2_Cls", StringUtil.RTrim( Dvpanel_unnamedtable2_Cls));
         GxWebStd.gx_hidden_field( context, "DVPANEL_UNNAMEDTABLE2_Title", StringUtil.RTrim( Dvpanel_unnamedtable2_Title));
         GxWebStd.gx_hidden_field( context, "DVPANEL_UNNAMEDTABLE2_Collapsible", StringUtil.BoolToStr( Dvpanel_unnamedtable2_Collapsible));
         GxWebStd.gx_hidden_field( context, "DVPANEL_UNNAMEDTABLE2_Collapsed", StringUtil.BoolToStr( Dvpanel_unnamedtable2_Collapsed));
         GxWebStd.gx_hidden_field( context, "DVPANEL_UNNAMEDTABLE2_Autowidth", StringUtil.BoolToStr( Dvpanel_unnamedtable2_Autowidth));
         GxWebStd.gx_hidden_field( context, "DVPANEL_UNNAMEDTABLE2_Autoheight", StringUtil.BoolToStr( Dvpanel_unnamedtable2_Autoheight));
         GxWebStd.gx_hidden_field( context, "DVPANEL_UNNAMEDTABLE2_Showcollapseicon", StringUtil.BoolToStr( Dvpanel_unnamedtable2_Showcollapseicon));
         GxWebStd.gx_hidden_field( context, "DVPANEL_UNNAMEDTABLE2_Iconposition", StringUtil.RTrim( Dvpanel_unnamedtable2_Iconposition));
         GxWebStd.gx_hidden_field( context, "DVPANEL_UNNAMEDTABLE2_Autoscroll", StringUtil.BoolToStr( Dvpanel_unnamedtable2_Autoscroll));
         GxWebStd.gx_hidden_field( context, "VSITUATIONIMAGE2_Width", StringUtil.RTrim( Vsituationimage2_Width));
         GxWebStd.gx_hidden_field( context, "VSITUATIONIMAGE2_Height", StringUtil.RTrim( Vsituationimage2_Height));
         GxWebStd.gx_hidden_field( context, "DVPANEL_UNNAMEDTABLE3_Width", StringUtil.RTrim( Dvpanel_unnamedtable3_Width));
         GxWebStd.gx_hidden_field( context, "DVPANEL_UNNAMEDTABLE3_Cls", StringUtil.RTrim( Dvpanel_unnamedtable3_Cls));
         GxWebStd.gx_hidden_field( context, "DVPANEL_UNNAMEDTABLE3_Title", StringUtil.RTrim( Dvpanel_unnamedtable3_Title));
         GxWebStd.gx_hidden_field( context, "DVPANEL_UNNAMEDTABLE3_Collapsible", StringUtil.BoolToStr( Dvpanel_unnamedtable3_Collapsible));
         GxWebStd.gx_hidden_field( context, "DVPANEL_UNNAMEDTABLE3_Collapsed", StringUtil.BoolToStr( Dvpanel_unnamedtable3_Collapsed));
         GxWebStd.gx_hidden_field( context, "DVPANEL_UNNAMEDTABLE3_Autowidth", StringUtil.BoolToStr( Dvpanel_unnamedtable3_Autowidth));
         GxWebStd.gx_hidden_field( context, "DVPANEL_UNNAMEDTABLE3_Autoheight", StringUtil.BoolToStr( Dvpanel_unnamedtable3_Autoheight));
         GxWebStd.gx_hidden_field( context, "DVPANEL_UNNAMEDTABLE3_Showcollapseicon", StringUtil.BoolToStr( Dvpanel_unnamedtable3_Showcollapseicon));
         GxWebStd.gx_hidden_field( context, "DVPANEL_UNNAMEDTABLE3_Iconposition", StringUtil.RTrim( Dvpanel_unnamedtable3_Iconposition));
         GxWebStd.gx_hidden_field( context, "DVPANEL_UNNAMEDTABLE3_Autoscroll", StringUtil.BoolToStr( Dvpanel_unnamedtable3_Autoscroll));
         GxWebStd.gx_hidden_field( context, "VSITUATIONIMAGE4_Width", StringUtil.RTrim( Vsituationimage4_Width));
         GxWebStd.gx_hidden_field( context, "VSITUATIONIMAGE4_Height", StringUtil.RTrim( Vsituationimage4_Height));
         GxWebStd.gx_hidden_field( context, "DVPANEL_UNNAMEDTABLE4_Width", StringUtil.RTrim( Dvpanel_unnamedtable4_Width));
         GxWebStd.gx_hidden_field( context, "DVPANEL_UNNAMEDTABLE4_Cls", StringUtil.RTrim( Dvpanel_unnamedtable4_Cls));
         GxWebStd.gx_hidden_field( context, "DVPANEL_UNNAMEDTABLE4_Title", StringUtil.RTrim( Dvpanel_unnamedtable4_Title));
         GxWebStd.gx_hidden_field( context, "DVPANEL_UNNAMEDTABLE4_Collapsible", StringUtil.BoolToStr( Dvpanel_unnamedtable4_Collapsible));
         GxWebStd.gx_hidden_field( context, "DVPANEL_UNNAMEDTABLE4_Collapsed", StringUtil.BoolToStr( Dvpanel_unnamedtable4_Collapsed));
         GxWebStd.gx_hidden_field( context, "DVPANEL_UNNAMEDTABLE4_Autowidth", StringUtil.BoolToStr( Dvpanel_unnamedtable4_Autowidth));
         GxWebStd.gx_hidden_field( context, "DVPANEL_UNNAMEDTABLE4_Autoheight", StringUtil.BoolToStr( Dvpanel_unnamedtable4_Autoheight));
         GxWebStd.gx_hidden_field( context, "DVPANEL_UNNAMEDTABLE4_Showcollapseicon", StringUtil.BoolToStr( Dvpanel_unnamedtable4_Showcollapseicon));
         GxWebStd.gx_hidden_field( context, "DVPANEL_UNNAMEDTABLE4_Iconposition", StringUtil.RTrim( Dvpanel_unnamedtable4_Iconposition));
         GxWebStd.gx_hidden_field( context, "DVPANEL_UNNAMEDTABLE4_Autoscroll", StringUtil.BoolToStr( Dvpanel_unnamedtable4_Autoscroll));
         GxWebStd.gx_hidden_field( context, "VSITUATIONIMAGE3_Width", StringUtil.RTrim( Vsituationimage3_Width));
         GxWebStd.gx_hidden_field( context, "VSITUATIONIMAGE3_Height", StringUtil.RTrim( Vsituationimage3_Height));
         GxWebStd.gx_hidden_field( context, "DVPANEL_UNNAMEDTABLE5_Width", StringUtil.RTrim( Dvpanel_unnamedtable5_Width));
         GxWebStd.gx_hidden_field( context, "DVPANEL_UNNAMEDTABLE5_Cls", StringUtil.RTrim( Dvpanel_unnamedtable5_Cls));
         GxWebStd.gx_hidden_field( context, "DVPANEL_UNNAMEDTABLE5_Title", StringUtil.RTrim( Dvpanel_unnamedtable5_Title));
         GxWebStd.gx_hidden_field( context, "DVPANEL_UNNAMEDTABLE5_Collapsible", StringUtil.BoolToStr( Dvpanel_unnamedtable5_Collapsible));
         GxWebStd.gx_hidden_field( context, "DVPANEL_UNNAMEDTABLE5_Collapsed", StringUtil.BoolToStr( Dvpanel_unnamedtable5_Collapsed));
         GxWebStd.gx_hidden_field( context, "DVPANEL_UNNAMEDTABLE5_Autowidth", StringUtil.BoolToStr( Dvpanel_unnamedtable5_Autowidth));
         GxWebStd.gx_hidden_field( context, "DVPANEL_UNNAMEDTABLE5_Autoheight", StringUtil.BoolToStr( Dvpanel_unnamedtable5_Autoheight));
         GxWebStd.gx_hidden_field( context, "DVPANEL_UNNAMEDTABLE5_Showcollapseicon", StringUtil.BoolToStr( Dvpanel_unnamedtable5_Showcollapseicon));
         GxWebStd.gx_hidden_field( context, "DVPANEL_UNNAMEDTABLE5_Iconposition", StringUtil.RTrim( Dvpanel_unnamedtable5_Iconposition));
         GxWebStd.gx_hidden_field( context, "DVPANEL_UNNAMEDTABLE5_Autoscroll", StringUtil.BoolToStr( Dvpanel_unnamedtable5_Autoscroll));
         GxWebStd.gx_hidden_field( context, "VSITUATIONIMAGE1_Width", StringUtil.RTrim( Vsituationimage1_Width));
         GxWebStd.gx_hidden_field( context, "VSITUATIONIMAGE1_Height", StringUtil.RTrim( Vsituationimage1_Height));
         GxWebStd.gx_hidden_field( context, "DVPANEL_UNNAMEDTABLE6_Width", StringUtil.RTrim( Dvpanel_unnamedtable6_Width));
         GxWebStd.gx_hidden_field( context, "DVPANEL_UNNAMEDTABLE6_Cls", StringUtil.RTrim( Dvpanel_unnamedtable6_Cls));
         GxWebStd.gx_hidden_field( context, "DVPANEL_UNNAMEDTABLE6_Title", StringUtil.RTrim( Dvpanel_unnamedtable6_Title));
         GxWebStd.gx_hidden_field( context, "DVPANEL_UNNAMEDTABLE6_Collapsible", StringUtil.BoolToStr( Dvpanel_unnamedtable6_Collapsible));
         GxWebStd.gx_hidden_field( context, "DVPANEL_UNNAMEDTABLE6_Collapsed", StringUtil.BoolToStr( Dvpanel_unnamedtable6_Collapsed));
         GxWebStd.gx_hidden_field( context, "DVPANEL_UNNAMEDTABLE6_Autowidth", StringUtil.BoolToStr( Dvpanel_unnamedtable6_Autowidth));
         GxWebStd.gx_hidden_field( context, "DVPANEL_UNNAMEDTABLE6_Autoheight", StringUtil.BoolToStr( Dvpanel_unnamedtable6_Autoheight));
         GxWebStd.gx_hidden_field( context, "DVPANEL_UNNAMEDTABLE6_Showcollapseicon", StringUtil.BoolToStr( Dvpanel_unnamedtable6_Showcollapseicon));
         GxWebStd.gx_hidden_field( context, "DVPANEL_UNNAMEDTABLE6_Iconposition", StringUtil.RTrim( Dvpanel_unnamedtable6_Iconposition));
         GxWebStd.gx_hidden_field( context, "DVPANEL_UNNAMEDTABLE6_Autoscroll", StringUtil.BoolToStr( Dvpanel_unnamedtable6_Autoscroll));
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
         if ( nGXWrapped != 1 )
         {
            context.WriteHtmlTextNl( "</form>") ;
         }
         if ( context.isSpaRequest( ) )
         {
            enableOutput();
         }
         include_jscripts( ) ;
      }

      public override void RenderHtmlContent( )
      {
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0));
         if ( ( gxajaxcallmode == 0 ) && ( GxWebError == 0 ) )
         {
            context.WriteHtmlText( "<div") ;
            GxWebStd.ClassAttribute( context, "gx-ct-body"+" "+(String.IsNullOrEmpty(StringUtil.RTrim( Form.Class)) ? "form-horizontal Form" : Form.Class)+"-fx");
            context.WriteHtmlText( ">") ;
            WE092( ) ;
            context.WriteHtmlText( "</div>") ;
         }
      }

      public override void DispatchEvents( )
      {
         EVT092( ) ;
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
         return formatLink("dashboard.aspx")  ;
      }

      public override String GetPgmname( )
      {
         return "DashBoard" ;
      }

      public override String GetPgmdesc( )
      {
         return "Data Mgmt Portal - RAAP" ;
      }

      protected void WB090( )
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
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "Section", "left", "top", " "+"data-gx-base-lib=\"bootstrapv3\""+" "+"data-abstract-form"+" ", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divLayoutmaintable_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divTablemain_Internalname, 1, 0, "px", 0, "px", "", "left", "top", "", "", "div");
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
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "Center", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divUnnamedtable1_Internalname, 1, 0, "px", 0, "px", "", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divDvpanel_unnamedtable2_cell_Internalname, 1, 0, "px", 0, "px", divDvpanel_unnamedtable2_cell_Class, "Center", "top", "", "", "div");
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
            ucDvpanel_unnamedtable2.Render(context, "dvelop.gxbootstrap.panel", Dvpanel_unnamedtable2_Internalname, "DVPANEL_UNNAMEDTABLE2Container");
            context.WriteHtmlText( "<div class=\"gx_usercontrol_child\" id=\""+"DVPANEL_UNNAMEDTABLE2Container"+"Body"+"\" style=\"display:none;\">") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, divLayout_unnamedtable2_Internalname, 1, 0, "px", 0, "px", "Section", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "Section", "left", "top", " "+"data-gx-base-lib=\"bootstrapv3\""+" "+"data-abstract-form"+" ", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divUnnamedtable2_Internalname, 1, 0, "px", 0, "px", "", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* User Defined Control */
            ucVsituationimage.SetProperty("Width", Vsituationimage_Width);
            ucVsituationimage.SetProperty("Height", Vsituationimage_Height);
            ucVsituationimage.SetProperty("OptionJson", AV36tSituation);
            ucVsituationimage.Render(context, "sghighchartsbasic", Vsituationimage_Internalname, "VSITUATIONIMAGEContainer");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</div>") ;
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "Center", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divDvpanel_unnamedtable3_cell_Internalname, 1, 0, "px", 0, "px", divDvpanel_unnamedtable3_cell_Class, "Center", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divHtml_dvpanel_unnamedtable3_Internalname, 1, 0, "px", 0, "px", "Section", "left", "top", "", "", "div");
            /* User Defined Control */
            ucDvpanel_unnamedtable3.SetProperty("Width", Dvpanel_unnamedtable3_Width);
            ucDvpanel_unnamedtable3.SetProperty("AutoWidth", Dvpanel_unnamedtable3_Autowidth);
            ucDvpanel_unnamedtable3.SetProperty("AutoHeight", Dvpanel_unnamedtable3_Autoheight);
            ucDvpanel_unnamedtable3.SetProperty("Cls", Dvpanel_unnamedtable3_Cls);
            ucDvpanel_unnamedtable3.SetProperty("Title", Dvpanel_unnamedtable3_Title);
            ucDvpanel_unnamedtable3.SetProperty("Collapsible", Dvpanel_unnamedtable3_Collapsible);
            ucDvpanel_unnamedtable3.SetProperty("Collapsed", Dvpanel_unnamedtable3_Collapsed);
            ucDvpanel_unnamedtable3.SetProperty("ShowCollapseIcon", Dvpanel_unnamedtable3_Showcollapseicon);
            ucDvpanel_unnamedtable3.SetProperty("IconPosition", Dvpanel_unnamedtable3_Iconposition);
            ucDvpanel_unnamedtable3.SetProperty("AutoScroll", Dvpanel_unnamedtable3_Autoscroll);
            ucDvpanel_unnamedtable3.Render(context, "dvelop.gxbootstrap.panel", Dvpanel_unnamedtable3_Internalname, "DVPANEL_UNNAMEDTABLE3Container");
            context.WriteHtmlText( "<div class=\"gx_usercontrol_child\" id=\""+"DVPANEL_UNNAMEDTABLE3Container"+"Body"+"\" style=\"display:none;\">") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, divLayout_unnamedtable3_Internalname, 1, 0, "px", 0, "px", "Section", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "Section", "left", "top", " "+"data-gx-base-lib=\"bootstrapv3\""+" "+"data-abstract-form"+" ", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divUnnamedtable3_Internalname, 1, 0, "px", 0, "px", "", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* User Defined Control */
            ucVsituationimage2.SetProperty("Width", Vsituationimage2_Width);
            ucVsituationimage2.SetProperty("Height", Vsituationimage2_Height);
            ucVsituationimage2.SetProperty("OptionJson", AV56tEntitySituation);
            ucVsituationimage2.Render(context, "sghighchartsbasic", Vsituationimage2_Internalname, "VSITUATIONIMAGE2Container");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</div>") ;
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "Center", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divDvpanel_unnamedtable4_cell_Internalname, 1, 0, "px", 0, "px", divDvpanel_unnamedtable4_cell_Class, "Center", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divHtml_dvpanel_unnamedtable4_Internalname, 1, 0, "px", 0, "px", "Section", "left", "top", "", "", "div");
            /* User Defined Control */
            ucDvpanel_unnamedtable4.SetProperty("Width", Dvpanel_unnamedtable4_Width);
            ucDvpanel_unnamedtable4.SetProperty("AutoWidth", Dvpanel_unnamedtable4_Autowidth);
            ucDvpanel_unnamedtable4.SetProperty("AutoHeight", Dvpanel_unnamedtable4_Autoheight);
            ucDvpanel_unnamedtable4.SetProperty("Cls", Dvpanel_unnamedtable4_Cls);
            ucDvpanel_unnamedtable4.SetProperty("Title", Dvpanel_unnamedtable4_Title);
            ucDvpanel_unnamedtable4.SetProperty("Collapsible", Dvpanel_unnamedtable4_Collapsible);
            ucDvpanel_unnamedtable4.SetProperty("Collapsed", Dvpanel_unnamedtable4_Collapsed);
            ucDvpanel_unnamedtable4.SetProperty("ShowCollapseIcon", Dvpanel_unnamedtable4_Showcollapseicon);
            ucDvpanel_unnamedtable4.SetProperty("IconPosition", Dvpanel_unnamedtable4_Iconposition);
            ucDvpanel_unnamedtable4.SetProperty("AutoScroll", Dvpanel_unnamedtable4_Autoscroll);
            ucDvpanel_unnamedtable4.Render(context, "dvelop.gxbootstrap.panel", Dvpanel_unnamedtable4_Internalname, "DVPANEL_UNNAMEDTABLE4Container");
            context.WriteHtmlText( "<div class=\"gx_usercontrol_child\" id=\""+"DVPANEL_UNNAMEDTABLE4Container"+"Body"+"\" style=\"display:none;\">") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, divLayout_unnamedtable4_Internalname, 1, 0, "px", 0, "px", "Section", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "Section", "left", "top", " "+"data-gx-base-lib=\"bootstrapv3\""+" "+"data-abstract-form"+" ", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divUnnamedtable4_Internalname, 1, 0, "px", 0, "px", "", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* User Defined Control */
            ucVsituationimage4.SetProperty("Width", Vsituationimage4_Width);
            ucVsituationimage4.SetProperty("Height", Vsituationimage4_Height);
            ucVsituationimage4.SetProperty("OptionJson", AV69tRandomSituation);
            ucVsituationimage4.Render(context, "sghighchartsbasic", Vsituationimage4_Internalname, "VSITUATIONIMAGE4Container");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</div>") ;
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "Center", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divDvpanel_unnamedtable5_cell_Internalname, 1, 0, "px", 0, "px", divDvpanel_unnamedtable5_cell_Class, "Center", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divHtml_dvpanel_unnamedtable5_Internalname, 1, 0, "px", 0, "px", "Section", "left", "top", "", "", "div");
            /* User Defined Control */
            ucDvpanel_unnamedtable5.SetProperty("Width", Dvpanel_unnamedtable5_Width);
            ucDvpanel_unnamedtable5.SetProperty("AutoWidth", Dvpanel_unnamedtable5_Autowidth);
            ucDvpanel_unnamedtable5.SetProperty("AutoHeight", Dvpanel_unnamedtable5_Autoheight);
            ucDvpanel_unnamedtable5.SetProperty("Cls", Dvpanel_unnamedtable5_Cls);
            ucDvpanel_unnamedtable5.SetProperty("Title", Dvpanel_unnamedtable5_Title);
            ucDvpanel_unnamedtable5.SetProperty("Collapsible", Dvpanel_unnamedtable5_Collapsible);
            ucDvpanel_unnamedtable5.SetProperty("Collapsed", Dvpanel_unnamedtable5_Collapsed);
            ucDvpanel_unnamedtable5.SetProperty("ShowCollapseIcon", Dvpanel_unnamedtable5_Showcollapseicon);
            ucDvpanel_unnamedtable5.SetProperty("IconPosition", Dvpanel_unnamedtable5_Iconposition);
            ucDvpanel_unnamedtable5.SetProperty("AutoScroll", Dvpanel_unnamedtable5_Autoscroll);
            ucDvpanel_unnamedtable5.Render(context, "dvelop.gxbootstrap.panel", Dvpanel_unnamedtable5_Internalname, "DVPANEL_UNNAMEDTABLE5Container");
            context.WriteHtmlText( "<div class=\"gx_usercontrol_child\" id=\""+"DVPANEL_UNNAMEDTABLE5Container"+"Body"+"\" style=\"display:none;\">") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, divLayout_unnamedtable5_Internalname, 1, 0, "px", 0, "px", "Section", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "Section", "left", "top", " "+"data-gx-base-lib=\"bootstrapv3\""+" "+"data-abstract-form"+" ", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divUnnamedtable5_Internalname, 1, 0, "px", 0, "px", "", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* User Defined Control */
            ucVsituationimage3.SetProperty("Width", Vsituationimage3_Width);
            ucVsituationimage3.SetProperty("Height", Vsituationimage3_Height);
            ucVsituationimage3.SetProperty("OptionJson", AV68tTenantSituation);
            ucVsituationimage3.Render(context, "sghighchartsbasic", Vsituationimage3_Internalname, "VSITUATIONIMAGE3Container");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</div>") ;
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "Center", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divDvpanel_unnamedtable6_cell_Internalname, 1, 0, "px", 0, "px", divDvpanel_unnamedtable6_cell_Class, "Center", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divHtml_dvpanel_unnamedtable6_Internalname, 1, 0, "px", 0, "px", "Section", "left", "top", "", "", "div");
            /* User Defined Control */
            ucDvpanel_unnamedtable6.SetProperty("Width", Dvpanel_unnamedtable6_Width);
            ucDvpanel_unnamedtable6.SetProperty("AutoWidth", Dvpanel_unnamedtable6_Autowidth);
            ucDvpanel_unnamedtable6.SetProperty("AutoHeight", Dvpanel_unnamedtable6_Autoheight);
            ucDvpanel_unnamedtable6.SetProperty("Cls", Dvpanel_unnamedtable6_Cls);
            ucDvpanel_unnamedtable6.SetProperty("Title", Dvpanel_unnamedtable6_Title);
            ucDvpanel_unnamedtable6.SetProperty("Collapsible", Dvpanel_unnamedtable6_Collapsible);
            ucDvpanel_unnamedtable6.SetProperty("Collapsed", Dvpanel_unnamedtable6_Collapsed);
            ucDvpanel_unnamedtable6.SetProperty("ShowCollapseIcon", Dvpanel_unnamedtable6_Showcollapseicon);
            ucDvpanel_unnamedtable6.SetProperty("IconPosition", Dvpanel_unnamedtable6_Iconposition);
            ucDvpanel_unnamedtable6.SetProperty("AutoScroll", Dvpanel_unnamedtable6_Autoscroll);
            ucDvpanel_unnamedtable6.Render(context, "dvelop.gxbootstrap.panel", Dvpanel_unnamedtable6_Internalname, "DVPANEL_UNNAMEDTABLE6Container");
            context.WriteHtmlText( "<div class=\"gx_usercontrol_child\" id=\""+"DVPANEL_UNNAMEDTABLE6Container"+"Body"+"\" style=\"display:none;\">") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, divLayout_unnamedtable6_Internalname, 1, 0, "px", 0, "px", "Section", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "Section", "left", "top", " "+"data-gx-base-lib=\"bootstrapv3\""+" "+"data-abstract-form"+" ", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divUnnamedtable6_Internalname, 1, 0, "px", 0, "px", "", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* User Defined Control */
            ucVsituationimage1.SetProperty("Width", Vsituationimage1_Width);
            ucVsituationimage1.SetProperty("Height", Vsituationimage1_Height);
            ucVsituationimage1.SetProperty("OptionJson", AV55tEntryAmount);
            ucVsituationimage1.Render(context, "sghighchartsbasic", Vsituationimage1_Internalname, "VSITUATIONIMAGE1Container");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</div>") ;
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "Center", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "Center", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
         }
         wbLoad = true;
      }

      protected void START092( )
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
         STRUP090( ) ;
      }

      protected void WS092( )
      {
         START092( ) ;
         EVT092( ) ;
      }

      protected void EVT092( )
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
                           else if ( StringUtil.StrCmp(sEvt, "START") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              /* Execute user event: Start */
                              E11092 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "LOAD") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              /* Execute user event: Load */
                              E12092 ();
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
                     context.wbHandled = 1;
                  }
               }
            }
         }
      }

      protected void WE092( )
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

      protected void PA092( )
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
         RF092( ) ;
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

      protected void RF092( )
      {
         initialize_formulas( ) ;
         clear_multi_value_controls( ) ;
         gxdyncontrolsrefreshing = true;
         fix_multi_value_controls( ) ;
         gxdyncontrolsrefreshing = false;
         if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
         {
            /* Execute user event: Load */
            E12092 ();
            WB090( ) ;
         }
      }

      protected void send_integrity_lvl_hashes092( )
      {
      }

      protected void STRUP090( )
      {
         /* Before Start, stand alone formulas. */
         context.Gx_err = 0;
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0;
         /* Execute user event: Start */
         E11092 ();
         context.wbGlbDoneStart = 1;
         /* After Start, stand alone formulas. */
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read saved SDTs. */
            /* Read variables values. */
            /* Read saved values. */
            AV36tSituation = cgiGet( "vTSITUATION");
            AV56tEntitySituation = cgiGet( "vTENTITYSITUATION");
            AV69tRandomSituation = cgiGet( "vTRANDOMSITUATION");
            AV68tTenantSituation = cgiGet( "vTTENANTSITUATION");
            AV55tEntryAmount = cgiGet( "vTENTRYAMOUNT");
            Vsituationimage_Width = cgiGet( "VSITUATIONIMAGE_Width");
            Vsituationimage_Height = cgiGet( "VSITUATIONIMAGE_Height");
            Dvpanel_unnamedtable2_Width = cgiGet( "DVPANEL_UNNAMEDTABLE2_Width");
            Dvpanel_unnamedtable2_Cls = cgiGet( "DVPANEL_UNNAMEDTABLE2_Cls");
            Dvpanel_unnamedtable2_Title = cgiGet( "DVPANEL_UNNAMEDTABLE2_Title");
            Dvpanel_unnamedtable2_Collapsible = StringUtil.StrToBool( cgiGet( "DVPANEL_UNNAMEDTABLE2_Collapsible"));
            Dvpanel_unnamedtable2_Collapsed = StringUtil.StrToBool( cgiGet( "DVPANEL_UNNAMEDTABLE2_Collapsed"));
            Dvpanel_unnamedtable2_Autowidth = StringUtil.StrToBool( cgiGet( "DVPANEL_UNNAMEDTABLE2_Autowidth"));
            Dvpanel_unnamedtable2_Autoheight = StringUtil.StrToBool( cgiGet( "DVPANEL_UNNAMEDTABLE2_Autoheight"));
            Dvpanel_unnamedtable2_Showcollapseicon = StringUtil.StrToBool( cgiGet( "DVPANEL_UNNAMEDTABLE2_Showcollapseicon"));
            Dvpanel_unnamedtable2_Iconposition = cgiGet( "DVPANEL_UNNAMEDTABLE2_Iconposition");
            Dvpanel_unnamedtable2_Autoscroll = StringUtil.StrToBool( cgiGet( "DVPANEL_UNNAMEDTABLE2_Autoscroll"));
            Vsituationimage2_Width = cgiGet( "VSITUATIONIMAGE2_Width");
            Vsituationimage2_Height = cgiGet( "VSITUATIONIMAGE2_Height");
            Dvpanel_unnamedtable3_Width = cgiGet( "DVPANEL_UNNAMEDTABLE3_Width");
            Dvpanel_unnamedtable3_Cls = cgiGet( "DVPANEL_UNNAMEDTABLE3_Cls");
            Dvpanel_unnamedtable3_Title = cgiGet( "DVPANEL_UNNAMEDTABLE3_Title");
            Dvpanel_unnamedtable3_Collapsible = StringUtil.StrToBool( cgiGet( "DVPANEL_UNNAMEDTABLE3_Collapsible"));
            Dvpanel_unnamedtable3_Collapsed = StringUtil.StrToBool( cgiGet( "DVPANEL_UNNAMEDTABLE3_Collapsed"));
            Dvpanel_unnamedtable3_Autowidth = StringUtil.StrToBool( cgiGet( "DVPANEL_UNNAMEDTABLE3_Autowidth"));
            Dvpanel_unnamedtable3_Autoheight = StringUtil.StrToBool( cgiGet( "DVPANEL_UNNAMEDTABLE3_Autoheight"));
            Dvpanel_unnamedtable3_Showcollapseicon = StringUtil.StrToBool( cgiGet( "DVPANEL_UNNAMEDTABLE3_Showcollapseicon"));
            Dvpanel_unnamedtable3_Iconposition = cgiGet( "DVPANEL_UNNAMEDTABLE3_Iconposition");
            Dvpanel_unnamedtable3_Autoscroll = StringUtil.StrToBool( cgiGet( "DVPANEL_UNNAMEDTABLE3_Autoscroll"));
            Vsituationimage4_Width = cgiGet( "VSITUATIONIMAGE4_Width");
            Vsituationimage4_Height = cgiGet( "VSITUATIONIMAGE4_Height");
            Dvpanel_unnamedtable4_Width = cgiGet( "DVPANEL_UNNAMEDTABLE4_Width");
            Dvpanel_unnamedtable4_Cls = cgiGet( "DVPANEL_UNNAMEDTABLE4_Cls");
            Dvpanel_unnamedtable4_Title = cgiGet( "DVPANEL_UNNAMEDTABLE4_Title");
            Dvpanel_unnamedtable4_Collapsible = StringUtil.StrToBool( cgiGet( "DVPANEL_UNNAMEDTABLE4_Collapsible"));
            Dvpanel_unnamedtable4_Collapsed = StringUtil.StrToBool( cgiGet( "DVPANEL_UNNAMEDTABLE4_Collapsed"));
            Dvpanel_unnamedtable4_Autowidth = StringUtil.StrToBool( cgiGet( "DVPANEL_UNNAMEDTABLE4_Autowidth"));
            Dvpanel_unnamedtable4_Autoheight = StringUtil.StrToBool( cgiGet( "DVPANEL_UNNAMEDTABLE4_Autoheight"));
            Dvpanel_unnamedtable4_Showcollapseicon = StringUtil.StrToBool( cgiGet( "DVPANEL_UNNAMEDTABLE4_Showcollapseicon"));
            Dvpanel_unnamedtable4_Iconposition = cgiGet( "DVPANEL_UNNAMEDTABLE4_Iconposition");
            Dvpanel_unnamedtable4_Autoscroll = StringUtil.StrToBool( cgiGet( "DVPANEL_UNNAMEDTABLE4_Autoscroll"));
            Vsituationimage3_Width = cgiGet( "VSITUATIONIMAGE3_Width");
            Vsituationimage3_Height = cgiGet( "VSITUATIONIMAGE3_Height");
            Dvpanel_unnamedtable5_Width = cgiGet( "DVPANEL_UNNAMEDTABLE5_Width");
            Dvpanel_unnamedtable5_Cls = cgiGet( "DVPANEL_UNNAMEDTABLE5_Cls");
            Dvpanel_unnamedtable5_Title = cgiGet( "DVPANEL_UNNAMEDTABLE5_Title");
            Dvpanel_unnamedtable5_Collapsible = StringUtil.StrToBool( cgiGet( "DVPANEL_UNNAMEDTABLE5_Collapsible"));
            Dvpanel_unnamedtable5_Collapsed = StringUtil.StrToBool( cgiGet( "DVPANEL_UNNAMEDTABLE5_Collapsed"));
            Dvpanel_unnamedtable5_Autowidth = StringUtil.StrToBool( cgiGet( "DVPANEL_UNNAMEDTABLE5_Autowidth"));
            Dvpanel_unnamedtable5_Autoheight = StringUtil.StrToBool( cgiGet( "DVPANEL_UNNAMEDTABLE5_Autoheight"));
            Dvpanel_unnamedtable5_Showcollapseicon = StringUtil.StrToBool( cgiGet( "DVPANEL_UNNAMEDTABLE5_Showcollapseicon"));
            Dvpanel_unnamedtable5_Iconposition = cgiGet( "DVPANEL_UNNAMEDTABLE5_Iconposition");
            Dvpanel_unnamedtable5_Autoscroll = StringUtil.StrToBool( cgiGet( "DVPANEL_UNNAMEDTABLE5_Autoscroll"));
            Vsituationimage1_Width = cgiGet( "VSITUATIONIMAGE1_Width");
            Vsituationimage1_Height = cgiGet( "VSITUATIONIMAGE1_Height");
            Dvpanel_unnamedtable6_Width = cgiGet( "DVPANEL_UNNAMEDTABLE6_Width");
            Dvpanel_unnamedtable6_Cls = cgiGet( "DVPANEL_UNNAMEDTABLE6_Cls");
            Dvpanel_unnamedtable6_Title = cgiGet( "DVPANEL_UNNAMEDTABLE6_Title");
            Dvpanel_unnamedtable6_Collapsible = StringUtil.StrToBool( cgiGet( "DVPANEL_UNNAMEDTABLE6_Collapsible"));
            Dvpanel_unnamedtable6_Collapsed = StringUtil.StrToBool( cgiGet( "DVPANEL_UNNAMEDTABLE6_Collapsed"));
            Dvpanel_unnamedtable6_Autowidth = StringUtil.StrToBool( cgiGet( "DVPANEL_UNNAMEDTABLE6_Autowidth"));
            Dvpanel_unnamedtable6_Autoheight = StringUtil.StrToBool( cgiGet( "DVPANEL_UNNAMEDTABLE6_Autoheight"));
            Dvpanel_unnamedtable6_Showcollapseicon = StringUtil.StrToBool( cgiGet( "DVPANEL_UNNAMEDTABLE6_Showcollapseicon"));
            Dvpanel_unnamedtable6_Iconposition = cgiGet( "DVPANEL_UNNAMEDTABLE6_Iconposition");
            Dvpanel_unnamedtable6_Autoscroll = StringUtil.StrToBool( cgiGet( "DVPANEL_UNNAMEDTABLE6_Autoscroll"));
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
         E11092 ();
         if (returnInSub) return;
      }

      protected void E11092( )
      {
         /* Start Routine */
         Form.Headerrawhtml = "<title>Data Mgmt Portal - RAAP</title>";
         /* Execute user subroutine: 'ATTRIBUTESSECURITYCODE' */
         S112 ();
         if (returnInSub) return;
         new zutil_getflowsituation(context ).execute( out  AV26oCount1, out  AV27oCount2, out  AV28oCount3, out  AV29oCount4, out  AV30oCount5, out  AV31oCount6) ;
         AV36tSituation = "{\"title\": {\"text\": \"审批情况统计\"},\"legend\": {  \"enabled\":false}, \"credits\": { \"enabled\": false } ,\"tooltip\": {\"shared\": true,\"useHTML\": true},\"plotOptions\": {\"column\": {\"borderWidth\": 0}},\"series\": [{ \"type\": \"pie\",\"name\": \"录入量\", \"data\": [[\"录入中\"," + StringUtil.Trim( StringUtil.Str( (decimal)(AV26oCount1), 10, 0)) + "],[\"待初审\"," + StringUtil.Trim( StringUtil.Str( (decimal)(AV27oCount2), 10, 0)) + "],[\"初审不通过\"," + StringUtil.Trim( StringUtil.Str( (decimal)(AV28oCount3), 10, 0)) + "],[\"待复审\"," + StringUtil.Trim( StringUtil.Str( (decimal)(AV29oCount4), 10, 0)) + "],[\"复审不通过\"," + StringUtil.Trim( StringUtil.Str( (decimal)(AV30oCount5), 10, 0)) + "],[\"完成\"," + StringUtil.Trim( StringUtil.Str( (decimal)(AV31oCount6), 10, 0)) + "]] }]}";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV36tSituation", AV36tSituation);
         AV35tSDT_EncounterCount.Clear();
         new zbr_getencountercount(context ).execute( out  AV25oContent) ;
         AV35tSDT_EncounterCount.FromJSonString(AV25oContent, null);
         AV34tNum = 1;
         while ( AV34tNum <= AV35tSDT_EncounterCount.Count )
         {
            AV33tMonthName = AV33tMonthName + "\"" + StringUtil.Trim( ((SdtSDT_EncounterCount_SDT_EncounterCountItem)AV35tSDT_EncounterCount.Item(AV34tNum)).gxTpr_Month) + "\",";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV33tMonthName", AV33tMonthName);
            AV32tCountName = AV32tCountName + StringUtil.Trim( ((SdtSDT_EncounterCount_SDT_EncounterCountItem)AV35tSDT_EncounterCount.Item(AV34tNum)).gxTpr_Value) + ",";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV32tCountName", AV32tCountName);
            AV34tNum = (short)(AV34tNum+1);
         }
         AV33tMonthName = StringUtil.Substring( AV33tMonthName, 1, StringUtil.Len( AV33tMonthName)-1);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV33tMonthName", AV33tMonthName);
         AV32tCountName = StringUtil.Substring( AV32tCountName, 1, StringUtil.Len( AV32tCountName)-1);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV32tCountName", AV32tCountName);
         AV55tEntryAmount = "{ \"title\": { \"text\": \"录入量统计\" },\"legend\": {  \"enabled\":false}, \"credits\": { \"enabled\": false } , \"xAxis\": { \"categories\": [" + AV33tMonthName + "] }, \"yAxis\": { \"title\": { \"text\": \"录入量\" } }, \"series\": [{ \"name\": \"个数\", \"data\": [" + StringUtil.Trim( AV32tCountName) + "] }]}";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV55tEntryAmount", AV55tEntryAmount);
         new zutil_calculateentity(context ).execute( out  AV57oSDT_EntityCountContent) ;
         AV59oSDT_EntityCount.FromJSonString(AV57oSDT_EntityCountContent, null);
         AV62tENum = 1;
         while ( AV62tENum <= AV59oSDT_EntityCount.Count )
         {
            AV60tEntityName = AV60tEntityName + "\"" + StringUtil.Trim( ((SdtSDT_EntityCount)AV59oSDT_EntityCount.Item(AV62tENum)).gxTpr_Entityname) + "\",";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV60tEntityName", AV60tEntityName);
            AV61tEntityNum = AV61tEntityNum + StringUtil.Trim( StringUtil.Str( (decimal)(((SdtSDT_EntityCount)AV59oSDT_EntityCount.Item(AV62tENum)).gxTpr_Value), 15, 0)) + ",";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV61tEntityNum", AV61tEntityNum);
            AV62tENum = (short)(AV62tENum+1);
         }
         AV60tEntityName = StringUtil.Substring( AV60tEntityName, 1, StringUtil.Len( AV60tEntityName)-1);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV60tEntityName", AV60tEntityName);
         AV61tEntityNum = StringUtil.Substring( AV61tEntityNum, 1, StringUtil.Len( AV61tEntityNum)-1);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV61tEntityNum", AV61tEntityNum);
         AV56tEntitySituation = "{ \"title\": { \"text\": \"病种人数统计图\" },\"chart\": { \"type\": \"bar\" },\"legend\": {  \"enabled\":false}, \"credits\": { \"enabled\": false } , \"xAxis\": { \"categories\": [" + AV60tEntityName + "] }, \"yAxis\": { \"title\": { \"text\": \"患者人数\", \"align\": \"high\" } },  \"series\": [{ \"name\": \"数量\", \"data\": [" + StringUtil.Trim( AV61tEntityNum) + "] }]}";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV56tEntitySituation", AV56tEntitySituation);
         new zutil_calculatetenant(context ).execute( out  AV63oSDT_TenantCountContent) ;
         AV64oSDT_TenantCount.FromJSonString(AV63oSDT_TenantCountContent, null);
         AV65tTNum = 1;
         while ( AV65tTNum <= AV64oSDT_TenantCount.Count )
         {
            AV67tTenantName = AV67tTenantName + "\"" + StringUtil.Trim( ((SdtSDT_EntityCount)AV64oSDT_TenantCount.Item(AV65tTNum)).gxTpr_Entityname) + "\",";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV67tTenantName", AV67tTenantName);
            AV66tTenantNum = AV66tTenantNum + StringUtil.Trim( StringUtil.Str( (decimal)(((SdtSDT_EntityCount)AV64oSDT_TenantCount.Item(AV65tTNum)).gxTpr_Value), 15, 0)) + ",";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV66tTenantNum", AV66tTenantNum);
            AV65tTNum = (short)(AV65tTNum+1);
         }
         AV67tTenantName = StringUtil.Substring( AV67tTenantName, 1, StringUtil.Len( AV67tTenantName)-1);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV67tTenantName", AV67tTenantName);
         AV66tTenantNum = StringUtil.Substring( AV66tTenantNum, 1, StringUtil.Len( AV66tTenantNum)-1);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV66tTenantNum", AV66tTenantNum);
         AV68tTenantSituation = "{ \"title\": { \"text\": \"租户就诊数量统计图\" },\"chart\": { \"type\": \"column\" },\"legend\": {  \"enabled\":false}, \"credits\": { \"enabled\": false } , \"xAxis\": { \"categories\": [" + AV67tTenantName + "] }, \"yAxis\": { \"title\": { \"text\": \"就诊数量\", \"align\": \"high\" } },  \"series\": [{ \"name\": \"数量\", \"data\": [" + StringUtil.Trim( AV66tTenantNum) + "] }]}";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV68tTenantSituation", AV68tTenantSituation);
         new zutil_getrandomsituation(context ).execute( out  AV70tApproveRandomNum, out  AV71tApproveNum, out  AV72tRecheckRandomNum, out  AV73tRecheckNum) ;
         AV69tRandomSituation = "{ \"chart\": { \"type\": \"column\" }, \"title\": { \"text\": \"抽查情况统计图\" },\"legend\": {  \"enabled\":false}, \"credits\": { \"enabled\": false } , \"xAxis\": { \"categories\": [\"初审\", \"复审\"] }, \"yAxis\": { \"title\": { \"text\": \"抽查个数\" } }, \"series\": [{ \"name\": \"未抽查\", \"data\": [" + StringUtil.Trim( StringUtil.Str( (decimal)(AV71tApproveNum), 10, 0)) + ", " + StringUtil.Trim( StringUtil.Str( (decimal)(AV73tRecheckNum), 10, 0)) + "] },{ \"name\": \"已抽查\", \"data\": [" + StringUtil.Trim( StringUtil.Str( (decimal)(AV70tApproveRandomNum), 10, 0)) + ", " + StringUtil.Trim( StringUtil.Str( (decimal)(AV72tRecheckRandomNum), 10, 0)) + "] }] }";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV69tRandomSituation", AV69tRandomSituation);
      }

      protected void S112( )
      {
         /* 'ATTRIBUTESSECURITYCODE' Routine */
         if ( ! ( new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context).executeUdp(  "Check_StatusSituation") ) )
         {
            divDvpanel_unnamedtable2_cell_Class = "Invisible";
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, divDvpanel_unnamedtable2_cell_Internalname, "Class", divDvpanel_unnamedtable2_cell_Class, true);
         }
         else
         {
            divDvpanel_unnamedtable2_cell_Class = "col-xs-12";
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, divDvpanel_unnamedtable2_cell_Internalname, "Class", divDvpanel_unnamedtable2_cell_Class, true);
         }
         if ( ! ( new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context).executeUdp(  "Check_EntitySituation") ) )
         {
            divDvpanel_unnamedtable3_cell_Class = "Invisible";
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, divDvpanel_unnamedtable3_cell_Internalname, "Class", divDvpanel_unnamedtable3_cell_Class, true);
         }
         else
         {
            divDvpanel_unnamedtable3_cell_Class = "col-xs-12";
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, divDvpanel_unnamedtable3_cell_Internalname, "Class", divDvpanel_unnamedtable3_cell_Class, true);
         }
         if ( ! ( new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context).executeUdp(  "Check_RandomSituation") ) )
         {
            divDvpanel_unnamedtable4_cell_Class = "Invisible";
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, divDvpanel_unnamedtable4_cell_Internalname, "Class", divDvpanel_unnamedtable4_cell_Class, true);
         }
         else
         {
            divDvpanel_unnamedtable4_cell_Class = "col-xs-12";
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, divDvpanel_unnamedtable4_cell_Internalname, "Class", divDvpanel_unnamedtable4_cell_Class, true);
         }
         if ( ! ( new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context).executeUdp(  "Check_EncounterSituation") ) )
         {
            divDvpanel_unnamedtable5_cell_Class = "Invisible";
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, divDvpanel_unnamedtable5_cell_Internalname, "Class", divDvpanel_unnamedtable5_cell_Class, true);
         }
         else
         {
            divDvpanel_unnamedtable5_cell_Class = "col-xs-12";
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, divDvpanel_unnamedtable5_cell_Internalname, "Class", divDvpanel_unnamedtable5_cell_Class, true);
         }
         if ( ! ( new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context).executeUdp(  "Check_AmountSituation") ) )
         {
            divDvpanel_unnamedtable6_cell_Class = "Invisible";
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, divDvpanel_unnamedtable6_cell_Internalname, "Class", divDvpanel_unnamedtable6_cell_Class, true);
         }
         else
         {
            divDvpanel_unnamedtable6_cell_Class = "col-xs-12";
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, divDvpanel_unnamedtable6_cell_Internalname, "Class", divDvpanel_unnamedtable6_cell_Class, true);
         }
      }

      protected void nextLoad( )
      {
      }

      protected void E12092( )
      {
         /* Load Routine */
      }

      public override void setparameters( Object[] obj )
      {
         createObjects();
         initialize();
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
         PA092( ) ;
         WS092( ) ;
         WE092( ) ;
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
         bool outputEnabled = isOutputEnabled( ) ;
         if ( context.isSpaRequest( ) )
         {
            enableOutput();
         }
         idxLst = 1;
         while ( idxLst <= Form.Jscriptsrc.Count )
         {
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?20202281591149", true);
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
         if ( nGXWrapped != 1 )
         {
            context.AddJavascriptSource("messages.chs.js", "?"+GetCacheInvalidationToken( ), false);
            context.AddJavascriptSource("dashboard.js", "?20202281591149", false);
            context.AddJavascriptSource("DVelop/Bootstrap/Shared/DVelopBootstrap.js", "", false);
            context.AddJavascriptSource("DVelop/Bootstrap/Panel/BootstrapPanelRender.js", "", false);
            context.AddJavascriptSource("sgHighChartsBasic/highcharts.js", "", false);
            context.AddJavascriptSource("sgHighChartsBasic/sgHighChartsBasicRender.js", "", false);
            context.AddJavascriptSource("DVelop/Bootstrap/Shared/DVelopBootstrap.js", "", false);
            context.AddJavascriptSource("DVelop/Bootstrap/Panel/BootstrapPanelRender.js", "", false);
            context.AddJavascriptSource("sgHighChartsBasic/highcharts.js", "", false);
            context.AddJavascriptSource("sgHighChartsBasic/sgHighChartsBasicRender.js", "", false);
            context.AddJavascriptSource("DVelop/Bootstrap/Shared/DVelopBootstrap.js", "", false);
            context.AddJavascriptSource("DVelop/Bootstrap/Panel/BootstrapPanelRender.js", "", false);
            context.AddJavascriptSource("sgHighChartsBasic/highcharts.js", "", false);
            context.AddJavascriptSource("sgHighChartsBasic/sgHighChartsBasicRender.js", "", false);
            context.AddJavascriptSource("DVelop/Bootstrap/Shared/DVelopBootstrap.js", "", false);
            context.AddJavascriptSource("DVelop/Bootstrap/Panel/BootstrapPanelRender.js", "", false);
            context.AddJavascriptSource("sgHighChartsBasic/highcharts.js", "", false);
            context.AddJavascriptSource("sgHighChartsBasic/sgHighChartsBasicRender.js", "", false);
            context.AddJavascriptSource("DVelop/Bootstrap/Shared/DVelopBootstrap.js", "", false);
            context.AddJavascriptSource("DVelop/Bootstrap/Panel/BootstrapPanelRender.js", "", false);
            context.AddJavascriptSource("sgHighChartsBasic/highcharts.js", "", false);
            context.AddJavascriptSource("sgHighChartsBasic/sgHighChartsBasicRender.js", "", false);
         }
         /* End function include_jscripts */
      }

      protected void init_web_controls( )
      {
         /* End function init_web_controls */
      }

      protected void init_default_properties( )
      {
         Vsituationimage_Internalname = "VSITUATIONIMAGE";
         divUnnamedtable2_Internalname = "UNNAMEDTABLE2";
         divLayout_unnamedtable2_Internalname = "LAYOUT_UNNAMEDTABLE2";
         Dvpanel_unnamedtable2_Internalname = "DVPANEL_UNNAMEDTABLE2";
         divHtml_dvpanel_unnamedtable2_Internalname = "HTML_DVPANEL_UNNAMEDTABLE2";
         divDvpanel_unnamedtable2_cell_Internalname = "DVPANEL_UNNAMEDTABLE2_CELL";
         Vsituationimage2_Internalname = "VSITUATIONIMAGE2";
         divUnnamedtable3_Internalname = "UNNAMEDTABLE3";
         divLayout_unnamedtable3_Internalname = "LAYOUT_UNNAMEDTABLE3";
         Dvpanel_unnamedtable3_Internalname = "DVPANEL_UNNAMEDTABLE3";
         divHtml_dvpanel_unnamedtable3_Internalname = "HTML_DVPANEL_UNNAMEDTABLE3";
         divDvpanel_unnamedtable3_cell_Internalname = "DVPANEL_UNNAMEDTABLE3_CELL";
         Vsituationimage4_Internalname = "VSITUATIONIMAGE4";
         divUnnamedtable4_Internalname = "UNNAMEDTABLE4";
         divLayout_unnamedtable4_Internalname = "LAYOUT_UNNAMEDTABLE4";
         Dvpanel_unnamedtable4_Internalname = "DVPANEL_UNNAMEDTABLE4";
         divHtml_dvpanel_unnamedtable4_Internalname = "HTML_DVPANEL_UNNAMEDTABLE4";
         divDvpanel_unnamedtable4_cell_Internalname = "DVPANEL_UNNAMEDTABLE4_CELL";
         Vsituationimage3_Internalname = "VSITUATIONIMAGE3";
         divUnnamedtable5_Internalname = "UNNAMEDTABLE5";
         divLayout_unnamedtable5_Internalname = "LAYOUT_UNNAMEDTABLE5";
         Dvpanel_unnamedtable5_Internalname = "DVPANEL_UNNAMEDTABLE5";
         divHtml_dvpanel_unnamedtable5_Internalname = "HTML_DVPANEL_UNNAMEDTABLE5";
         divDvpanel_unnamedtable5_cell_Internalname = "DVPANEL_UNNAMEDTABLE5_CELL";
         Vsituationimage1_Internalname = "VSITUATIONIMAGE1";
         divUnnamedtable6_Internalname = "UNNAMEDTABLE6";
         divLayout_unnamedtable6_Internalname = "LAYOUT_UNNAMEDTABLE6";
         Dvpanel_unnamedtable6_Internalname = "DVPANEL_UNNAMEDTABLE6";
         divHtml_dvpanel_unnamedtable6_Internalname = "HTML_DVPANEL_UNNAMEDTABLE6";
         divDvpanel_unnamedtable6_cell_Internalname = "DVPANEL_UNNAMEDTABLE6_CELL";
         divUnnamedtable1_Internalname = "UNNAMEDTABLE1";
         divTablemain_Internalname = "TABLEMAIN";
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
         divDvpanel_unnamedtable6_cell_Class = "col-xs-12";
         divDvpanel_unnamedtable5_cell_Class = "col-xs-12";
         divDvpanel_unnamedtable4_cell_Class = "col-xs-12";
         divDvpanel_unnamedtable3_cell_Class = "col-xs-12";
         divDvpanel_unnamedtable2_cell_Class = "col-xs-12";
         Dvpanel_unnamedtable6_Autoscroll = Convert.ToBoolean( 0);
         Dvpanel_unnamedtable6_Iconposition = "left";
         Dvpanel_unnamedtable6_Showcollapseicon = Convert.ToBoolean( 0);
         Dvpanel_unnamedtable6_Autoheight = Convert.ToBoolean( -1);
         Dvpanel_unnamedtable6_Autowidth = Convert.ToBoolean( 0);
         Dvpanel_unnamedtable6_Collapsed = Convert.ToBoolean( 0);
         Dvpanel_unnamedtable6_Collapsible = Convert.ToBoolean( -1);
         Dvpanel_unnamedtable6_Title = "录入量";
         Dvpanel_unnamedtable6_Cls = "HomePanelCard";
         Dvpanel_unnamedtable6_Width = "100%";
         Vsituationimage1_Height = "450";
         Vsituationimage1_Width = "600";
         Dvpanel_unnamedtable5_Autoscroll = Convert.ToBoolean( 0);
         Dvpanel_unnamedtable5_Iconposition = "left";
         Dvpanel_unnamedtable5_Showcollapseicon = Convert.ToBoolean( 0);
         Dvpanel_unnamedtable5_Autoheight = Convert.ToBoolean( -1);
         Dvpanel_unnamedtable5_Autowidth = Convert.ToBoolean( 0);
         Dvpanel_unnamedtable5_Collapsed = Convert.ToBoolean( 0);
         Dvpanel_unnamedtable5_Collapsible = Convert.ToBoolean( -1);
         Dvpanel_unnamedtable5_Title = "就诊信息统计";
         Dvpanel_unnamedtable5_Cls = "HomePanelCard";
         Dvpanel_unnamedtable5_Width = "100%";
         Vsituationimage3_Height = "450";
         Vsituationimage3_Width = "600";
         Dvpanel_unnamedtable4_Autoscroll = Convert.ToBoolean( 0);
         Dvpanel_unnamedtable4_Iconposition = "left";
         Dvpanel_unnamedtable4_Showcollapseicon = Convert.ToBoolean( 0);
         Dvpanel_unnamedtable4_Autoheight = Convert.ToBoolean( -1);
         Dvpanel_unnamedtable4_Autowidth = Convert.ToBoolean( 0);
         Dvpanel_unnamedtable4_Collapsed = Convert.ToBoolean( 0);
         Dvpanel_unnamedtable4_Collapsible = Convert.ToBoolean( -1);
         Dvpanel_unnamedtable4_Title = "抽查情况统计";
         Dvpanel_unnamedtable4_Cls = "HomePanelCard";
         Dvpanel_unnamedtable4_Width = "100%";
         Vsituationimage4_Height = "450";
         Vsituationimage4_Width = "600";
         Dvpanel_unnamedtable3_Autoscroll = Convert.ToBoolean( 0);
         Dvpanel_unnamedtable3_Iconposition = "left";
         Dvpanel_unnamedtable3_Showcollapseicon = Convert.ToBoolean( 0);
         Dvpanel_unnamedtable3_Autoheight = Convert.ToBoolean( -1);
         Dvpanel_unnamedtable3_Autowidth = Convert.ToBoolean( 0);
         Dvpanel_unnamedtable3_Collapsed = Convert.ToBoolean( 0);
         Dvpanel_unnamedtable3_Collapsible = Convert.ToBoolean( -1);
         Dvpanel_unnamedtable3_Title = "病种研究统计";
         Dvpanel_unnamedtable3_Cls = "HomePanelCard";
         Dvpanel_unnamedtable3_Width = "100%";
         Vsituationimage2_Height = "450";
         Vsituationimage2_Width = "600";
         Dvpanel_unnamedtable2_Autoscroll = Convert.ToBoolean( 0);
         Dvpanel_unnamedtable2_Iconposition = "left";
         Dvpanel_unnamedtable2_Showcollapseicon = Convert.ToBoolean( 0);
         Dvpanel_unnamedtable2_Autoheight = Convert.ToBoolean( -1);
         Dvpanel_unnamedtable2_Autowidth = Convert.ToBoolean( 0);
         Dvpanel_unnamedtable2_Collapsed = Convert.ToBoolean( 0);
         Dvpanel_unnamedtable2_Collapsible = Convert.ToBoolean( -1);
         Dvpanel_unnamedtable2_Title = "审批情况统计";
         Dvpanel_unnamedtable2_Cls = "HomePanelCard";
         Dvpanel_unnamedtable2_Width = "100%";
         Vsituationimage_Height = "450";
         Vsituationimage_Width = "600";
         Form.Headerrawhtml = "";
         Form.Background = "";
         Form.Textcolor = 0;
         Form.Backcolor = (int)(0xFFFFFF);
         Form.Caption = "Data Mgmt Portal - RAAP";
         context.GX_msglist.DisplayMode = 1;
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
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[]");
         setEventMetadata("REFRESH",",oparms:[]}");
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
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         GXKey = "";
         AV36tSituation = "";
         AV56tEntitySituation = "";
         AV69tRandomSituation = "";
         AV68tTenantSituation = "";
         AV55tEntryAmount = "";
         GX_FocusControl = "";
         Form = new GXWebForm();
         sPrefix = "";
         ClassString = "";
         StyleString = "";
         ucDvpanel_unnamedtable2 = new GXUserControl();
         ucVsituationimage = new GXUserControl();
         ucDvpanel_unnamedtable3 = new GXUserControl();
         ucVsituationimage2 = new GXUserControl();
         ucDvpanel_unnamedtable4 = new GXUserControl();
         ucVsituationimage4 = new GXUserControl();
         ucDvpanel_unnamedtable5 = new GXUserControl();
         ucVsituationimage3 = new GXUserControl();
         ucDvpanel_unnamedtable6 = new GXUserControl();
         ucVsituationimage1 = new GXUserControl();
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         AV35tSDT_EncounterCount = new GXBaseCollection<SdtSDT_EncounterCount_SDT_EncounterCountItem>( context, "SDT_EncounterCountItem", "DataAnalysisPlatform");
         AV25oContent = "";
         AV33tMonthName = "";
         AV32tCountName = "";
         AV57oSDT_EntityCountContent = "";
         AV59oSDT_EntityCount = new GXBaseCollection<SdtSDT_EntityCount>( context, "SDT_EntityCount", "DataAnalysisPlatform");
         AV60tEntityName = "";
         AV61tEntityNum = "";
         AV63oSDT_TenantCountContent = "";
         AV64oSDT_TenantCount = new GXBaseCollection<SdtSDT_EntityCount>( context, "SDT_EntityCount", "DataAnalysisPlatform");
         AV67tTenantName = "";
         AV66tTenantNum = "";
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private short nGotPars ;
      private short GxWebError ;
      private short initialized ;
      private short gxajaxcallmode ;
      private short nGXWrapped ;
      private short wbEnd ;
      private short wbStart ;
      private short nDonePA ;
      private short gxcookieaux ;
      private short AV34tNum ;
      private short AV62tENum ;
      private short AV65tTNum ;
      private int idxLst ;
      private long AV26oCount1 ;
      private long AV27oCount2 ;
      private long AV28oCount3 ;
      private long AV29oCount4 ;
      private long AV30oCount5 ;
      private long AV31oCount6 ;
      private long AV70tApproveRandomNum ;
      private long AV71tApproveNum ;
      private long AV72tRecheckRandomNum ;
      private long AV73tRecheckNum ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String sDynURL ;
      private String FormProcess ;
      private String bodyStyle ;
      private String GXKey ;
      private String Vsituationimage_Width ;
      private String Vsituationimage_Height ;
      private String Dvpanel_unnamedtable2_Width ;
      private String Dvpanel_unnamedtable2_Cls ;
      private String Dvpanel_unnamedtable2_Title ;
      private String Dvpanel_unnamedtable2_Iconposition ;
      private String Vsituationimage2_Width ;
      private String Vsituationimage2_Height ;
      private String Dvpanel_unnamedtable3_Width ;
      private String Dvpanel_unnamedtable3_Cls ;
      private String Dvpanel_unnamedtable3_Title ;
      private String Dvpanel_unnamedtable3_Iconposition ;
      private String Vsituationimage4_Width ;
      private String Vsituationimage4_Height ;
      private String Dvpanel_unnamedtable4_Width ;
      private String Dvpanel_unnamedtable4_Cls ;
      private String Dvpanel_unnamedtable4_Title ;
      private String Dvpanel_unnamedtable4_Iconposition ;
      private String Vsituationimage3_Width ;
      private String Vsituationimage3_Height ;
      private String Dvpanel_unnamedtable5_Width ;
      private String Dvpanel_unnamedtable5_Cls ;
      private String Dvpanel_unnamedtable5_Title ;
      private String Dvpanel_unnamedtable5_Iconposition ;
      private String Vsituationimage1_Width ;
      private String Vsituationimage1_Height ;
      private String Dvpanel_unnamedtable6_Width ;
      private String Dvpanel_unnamedtable6_Cls ;
      private String Dvpanel_unnamedtable6_Title ;
      private String Dvpanel_unnamedtable6_Iconposition ;
      private String GX_FocusControl ;
      private String sPrefix ;
      private String divLayoutmaintable_Internalname ;
      private String divTablemain_Internalname ;
      private String ClassString ;
      private String StyleString ;
      private String divUnnamedtable1_Internalname ;
      private String divDvpanel_unnamedtable2_cell_Internalname ;
      private String divDvpanel_unnamedtable2_cell_Class ;
      private String divHtml_dvpanel_unnamedtable2_Internalname ;
      private String Dvpanel_unnamedtable2_Internalname ;
      private String divLayout_unnamedtable2_Internalname ;
      private String divUnnamedtable2_Internalname ;
      private String Vsituationimage_Internalname ;
      private String divDvpanel_unnamedtable3_cell_Internalname ;
      private String divDvpanel_unnamedtable3_cell_Class ;
      private String divHtml_dvpanel_unnamedtable3_Internalname ;
      private String Dvpanel_unnamedtable3_Internalname ;
      private String divLayout_unnamedtable3_Internalname ;
      private String divUnnamedtable3_Internalname ;
      private String Vsituationimage2_Internalname ;
      private String divDvpanel_unnamedtable4_cell_Internalname ;
      private String divDvpanel_unnamedtable4_cell_Class ;
      private String divHtml_dvpanel_unnamedtable4_Internalname ;
      private String Dvpanel_unnamedtable4_Internalname ;
      private String divLayout_unnamedtable4_Internalname ;
      private String divUnnamedtable4_Internalname ;
      private String Vsituationimage4_Internalname ;
      private String divDvpanel_unnamedtable5_cell_Internalname ;
      private String divDvpanel_unnamedtable5_cell_Class ;
      private String divHtml_dvpanel_unnamedtable5_Internalname ;
      private String Dvpanel_unnamedtable5_Internalname ;
      private String divLayout_unnamedtable5_Internalname ;
      private String divUnnamedtable5_Internalname ;
      private String Vsituationimage3_Internalname ;
      private String divDvpanel_unnamedtable6_cell_Internalname ;
      private String divDvpanel_unnamedtable6_cell_Class ;
      private String divHtml_dvpanel_unnamedtable6_Internalname ;
      private String Dvpanel_unnamedtable6_Internalname ;
      private String divLayout_unnamedtable6_Internalname ;
      private String divUnnamedtable6_Internalname ;
      private String Vsituationimage1_Internalname ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private bool entryPointCalled ;
      private bool toggleJsOutput ;
      private bool Dvpanel_unnamedtable2_Collapsible ;
      private bool Dvpanel_unnamedtable2_Collapsed ;
      private bool Dvpanel_unnamedtable2_Autowidth ;
      private bool Dvpanel_unnamedtable2_Autoheight ;
      private bool Dvpanel_unnamedtable2_Showcollapseicon ;
      private bool Dvpanel_unnamedtable2_Autoscroll ;
      private bool Dvpanel_unnamedtable3_Collapsible ;
      private bool Dvpanel_unnamedtable3_Collapsed ;
      private bool Dvpanel_unnamedtable3_Autowidth ;
      private bool Dvpanel_unnamedtable3_Autoheight ;
      private bool Dvpanel_unnamedtable3_Showcollapseicon ;
      private bool Dvpanel_unnamedtable3_Autoscroll ;
      private bool Dvpanel_unnamedtable4_Collapsible ;
      private bool Dvpanel_unnamedtable4_Collapsed ;
      private bool Dvpanel_unnamedtable4_Autowidth ;
      private bool Dvpanel_unnamedtable4_Autoheight ;
      private bool Dvpanel_unnamedtable4_Showcollapseicon ;
      private bool Dvpanel_unnamedtable4_Autoscroll ;
      private bool Dvpanel_unnamedtable5_Collapsible ;
      private bool Dvpanel_unnamedtable5_Collapsed ;
      private bool Dvpanel_unnamedtable5_Autowidth ;
      private bool Dvpanel_unnamedtable5_Autoheight ;
      private bool Dvpanel_unnamedtable5_Showcollapseicon ;
      private bool Dvpanel_unnamedtable5_Autoscroll ;
      private bool Dvpanel_unnamedtable6_Collapsible ;
      private bool Dvpanel_unnamedtable6_Collapsed ;
      private bool Dvpanel_unnamedtable6_Autowidth ;
      private bool Dvpanel_unnamedtable6_Autoheight ;
      private bool Dvpanel_unnamedtable6_Showcollapseicon ;
      private bool Dvpanel_unnamedtable6_Autoscroll ;
      private bool wbLoad ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool gxdyncontrolsrefreshing ;
      private bool returnInSub ;
      private String AV57oSDT_EntityCountContent ;
      private String AV63oSDT_TenantCountContent ;
      private String AV36tSituation ;
      private String AV56tEntitySituation ;
      private String AV69tRandomSituation ;
      private String AV68tTenantSituation ;
      private String AV55tEntryAmount ;
      private String AV25oContent ;
      private String AV33tMonthName ;
      private String AV32tCountName ;
      private String AV60tEntityName ;
      private String AV61tEntityNum ;
      private String AV67tTenantName ;
      private String AV66tTenantNum ;
      private GXUserControl ucDvpanel_unnamedtable2 ;
      private GXUserControl ucVsituationimage ;
      private GXUserControl ucDvpanel_unnamedtable3 ;
      private GXUserControl ucVsituationimage2 ;
      private GXUserControl ucDvpanel_unnamedtable4 ;
      private GXUserControl ucVsituationimage4 ;
      private GXUserControl ucDvpanel_unnamedtable5 ;
      private GXUserControl ucVsituationimage3 ;
      private GXUserControl ucDvpanel_unnamedtable6 ;
      private GXUserControl ucVsituationimage1 ;
      private IGxDataStore dsDataStore1 ;
      private IGxDataStore dsDefault ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private GXBaseCollection<SdtSDT_EncounterCount_SDT_EncounterCountItem> AV35tSDT_EncounterCount ;
      private GXBaseCollection<SdtSDT_EntityCount> AV59oSDT_EntityCount ;
      private GXBaseCollection<SdtSDT_EntityCount> AV64oSDT_TenantCount ;
      private GXWebForm Form ;
   }

}
