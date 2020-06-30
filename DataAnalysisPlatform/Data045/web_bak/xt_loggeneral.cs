/*
               File: XT_LogGeneral
        Description: XT_Log General
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/27/2020 9:37:19.6
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
   public class xt_loggeneral : GXWebComponent, System.Web.SessionState.IRequiresSessionState
   {
      public xt_loggeneral( )
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

      public xt_loggeneral( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( long aP0_XT_LogID )
      {
         this.A173XT_LogID = aP0_XT_LogID;
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
         cmbXT_LogTargetOperate = new GXCombobox();
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
                  A173XT_LogID = (long)(NumberUtil.Val( GetNextPar( ), "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A173XT_LogID", StringUtil.LTrim( StringUtil.Str( (decimal)(A173XT_LogID), 18, 0)));
                  setjustcreated();
                  componentprepare(new Object[] {(String)sCompPrefix,(String)sSFPrefix,(long)A173XT_LogID});
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
            PA4I2( ) ;
            if ( ( GxWebError == 0 ) && ! isAjaxCallMode( ) )
            {
               /* GeneXus formulas. */
               AV16Pgmname = "XT_LogGeneral";
               context.Gx_err = 0;
               WS4I2( ) ;
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
            context.SendWebValue( "XT_Log General") ;
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
         context.AddJavascriptSource("gxcfg.js", "?20202279371912", false);
         if ( context.isSpaRequest( ) )
         {
            enableOutput();
         }
         context.AddJavascriptSource("calendar.js", "?"+context.GetBuildNumber( 127771), false);
         context.AddJavascriptSource("calendar-setup.js", "?"+context.GetBuildNumber( 127771), false);
         context.AddJavascriptSource("calendar-zh.js", "?"+context.GetBuildNumber( 127771), false);
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
            context.WriteHtmlTextNl( "<form id=\"MAINFORM\" autocomplete=\"off\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("xt_loggeneral.aspx") + "?" + UrlEncode("" +A173XT_LogID)+"\">") ;
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
         GxWebStd.gx_hidden_field( context, sPrefix+"wcpOA173XT_LogID", StringUtil.LTrim( StringUtil.NToC( (decimal)(wcpOA173XT_LogID), 18, 0, ".", "")));
      }

      protected void RenderHtmlCloseForm4I2( )
      {
         SendCloseFormHiddens( ) ;
         if ( ( StringUtil.Len( sPrefix) != 0 ) && ( context.isAjaxRequest( ) || context.isSpaRequest( ) ) )
         {
            context.AddJavascriptSource("xt_loggeneral.js", "?20202279371915", false);
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
         return "XT_LogGeneral" ;
      }

      public override String GetPgmdesc( )
      {
         return "XT_Log General" ;
      }

      protected void WB4I0( )
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
               GxWebStd.gx_hidden_field( context, sPrefix+"_CMPPGM", "xt_loggeneral.aspx");
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
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divTransactiondetail_tableattributes_Internalname, 1, 0, "px", 0, "px", "TableData", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-4 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtXT_LogSecUserName_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtXT_LogSecUserName_Internalname, "操作人", "col-sm-3 ReadonlyAttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtXT_LogSecUserName_Internalname, A174XT_LogSecUserName, StringUtil.RTrim( context.localUtil.Format( A174XT_LogSecUserName, "")), "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtXT_LogSecUserName_Jsonclick, 0, "ReadonlyAttribute", "", "", "", "", 1, edtXT_LogSecUserName_Enabled, 0, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_XT_LogGeneral.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-4 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtXT_LogTime_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtXT_LogTime_Internalname, "操作时间", "col-sm-3 ReadonlyAttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            context.WriteHtmlText( "<div id=\""+edtXT_LogTime_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtXT_LogTime_Internalname, context.localUtil.TToC( A220XT_LogTime, 10, 8, 0, 0, "/", ":", " "), context.localUtil.Format( A220XT_LogTime, "9999/99/99 99:99:99"), "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtXT_LogTime_Jsonclick, 0, "ReadonlyAttribute", "", "", "", "", 1, edtXT_LogTime_Enabled, 0, "text", "", 19, "chr", 1, "row", 19, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_XT_LogGeneral.htm");
            GxWebStd.gx_bitmap( context, edtXT_LogTime_Internalname+"_dp_trigger", context.GetImagePath( "61b9b5d3-dff6-4d59-9b00-da61bc2cbe93", "", context.GetTheme( )), "", "", "", "", ((1==0)||(edtXT_LogTime_Enabled==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;", "", "", "", "", "", "", "", "", 1, false, false, "", "HLP_XT_LogGeneral.htm");
            context.WriteHtmlTextNl( "</div>") ;
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-4 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtXT_LogProviderName_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtXT_LogProviderName_Internalname, "日志分院名称", "col-sm-3 ReadonlyAttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtXT_LogProviderName_Internalname, A219XT_LogProviderName, StringUtil.RTrim( context.localUtil.Format( A219XT_LogProviderName, "")), "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtXT_LogProviderName_Jsonclick, 0, "ReadonlyAttribute", "", "", "", "", 1, edtXT_LogProviderName_Enabled, 0, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_XT_LogGeneral.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-4 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtXT_LogTargetModule_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtXT_LogTargetModule_Internalname, "日志操作模块", "col-sm-3 ReadonlyAttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtXT_LogTargetModule_Internalname, A217XT_LogTargetModule, StringUtil.RTrim( context.localUtil.Format( A217XT_LogTargetModule, "")), "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtXT_LogTargetModule_Jsonclick, 0, "ReadonlyAttribute", "", "", "", "", 1, edtXT_LogTargetModule_Enabled, 0, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_XT_LogGeneral.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divUnnamedtablext_logtarget_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-1 MergeLabelCell", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblockxt_logtarget_Internalname, "日志操作对象", "", "", lblTextblockxt_logtarget_Jsonclick, "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_XT_LogGeneral.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-11", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtXT_LogTarget_Internalname, "日志操作对象", "col-sm-3 ReadonlyAttributeLabel", 0, true);
            /* Multiple line edit */
            ClassString = "ReadonlyAttribute";
            StyleString = "";
            ClassString = "ReadonlyAttribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtXT_LogTarget_Internalname, A216XT_LogTarget, "", "", 0, 1, edtXT_LogTarget_Enabled, 0, 80, "chr", 10, "row", StyleString, ClassString, "", "", "5000", -1, 0, "", "", -1, true, "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", 0, "HLP_XT_LogGeneral.htm");
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
            GxWebStd.gx_div_start( context, divUnnamedtablext_logdescription_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-1 MergeLabelCell", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblockxt_logdescription_Internalname, "日志描述", "", "", lblTextblockxt_logdescription_Jsonclick, "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_XT_LogGeneral.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-11", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtXT_LogDescription_Internalname, "日志描述", "col-sm-3 ReadonlyAttributeLabel", 0, true);
            /* Multiple line edit */
            ClassString = "ReadonlyAttribute";
            StyleString = "";
            ClassString = "ReadonlyAttribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtXT_LogDescription_Internalname, A221XT_LogDescription, "", "", 0, 1, edtXT_LogDescription_Enabled, 0, 80, "chr", 10, "row", StyleString, ClassString, "", "", "5000", -1, 0, "", "", -1, true, "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", 0, "HLP_XT_LogGeneral.htm");
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
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-action-group TrnActionGroup", "left", "top", " "+"data-gx-actiongroup-type=\"toolbar\""+" ", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 50,'" + sPrefix + "',false,'',0)\"";
            ClassString = "ButtonMaterial";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtnupdate_Internalname, "", "修改", bttBtnupdate_Jsonclick, 7, "修改", "", StyleString, ClassString, bttBtnupdate_Visible, 1, "standard", "'"+sPrefix+"'"+",false,"+"'"+"e114i1_client"+"'", TempTags, "", 2, "HLP_XT_LogGeneral.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 52,'" + sPrefix + "',false,'',0)\"";
            ClassString = "ButtonMaterialDefault";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtndelete_Internalname, "", "删除", bttBtndelete_Jsonclick, 7, "删除", "", StyleString, ClassString, bttBtndelete_Visible, 1, "standard", "'"+sPrefix+"'"+",false,"+"'"+"e124i1_client"+"'", TempTags, "", 2, "HLP_XT_LogGeneral.htm");
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
            GxWebStd.gx_single_line_edit( context, edtXT_LogID_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A173XT_LogID), 18, 0, ".", "")), context.localUtil.Format( (decimal)(A173XT_LogID), "ZZZZZZZZZZZZZZZZZZ"), "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtXT_LogID_Jsonclick, 0, "Attribute", "", "", "", "", edtXT_LogID_Visible, 0, 0, "number", "1", 18, "chr", 1, "row", 18, 0, 0, 0, 1, -1, 0, true, "ID", "right", false, "HLP_XT_LogGeneral.htm");
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtXT_LogUserID_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A214XT_LogUserID), 18, 0, ".", "")), context.localUtil.Format( (decimal)(A214XT_LogUserID), "ZZZZZZZZZZZZZZZZZZ"), "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtXT_LogUserID_Jsonclick, 0, "Attribute", "", "", "", "", edtXT_LogUserID_Visible, 0, 0, "number", "1", 18, "chr", 1, "row", 18, 0, 0, 0, 1, -1, 0, true, "ID", "right", false, "HLP_XT_LogGeneral.htm");
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtXT_LogPage_Internalname, A176XT_LogPage, StringUtil.RTrim( context.localUtil.Format( A176XT_LogPage, "")), "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtXT_LogPage_Jsonclick, 0, "Attribute", "", "", "", "", edtXT_LogPage_Visible, 0, 0, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_XT_LogGeneral.htm");
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtXT_LogButtonName_Internalname, A177XT_LogButtonName, StringUtil.RTrim( context.localUtil.Format( A177XT_LogButtonName, "")), "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtXT_LogButtonName_Jsonclick, 0, "Attribute", "", "", "", "", edtXT_LogButtonName_Visible, 0, 0, "text", "", 50, "chr", 1, "row", 50, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_XT_LogGeneral.htm");
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtXT_LogType_Internalname, A213XT_LogType, StringUtil.RTrim( context.localUtil.Format( A213XT_LogType, "")), "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtXT_LogType_Jsonclick, 0, "Attribute", "", "", "", "", edtXT_LogType_Visible, 0, 0, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, -1, true, "DM_LogType", "left", true, "HLP_XT_LogGeneral.htm");
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtXT_LogProviderID_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A215XT_LogProviderID), 18, 0, ".", "")), context.localUtil.Format( (decimal)(A215XT_LogProviderID), "ZZZZZZZZZZZZZZZZZZ"), "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtXT_LogProviderID_Jsonclick, 0, "Attribute", "", "", "", "", edtXT_LogProviderID_Visible, 0, 0, "number", "1", 18, "chr", 1, "row", 18, 0, 0, 0, 1, -1, 0, true, "ID", "right", false, "HLP_XT_LogGeneral.htm");
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtXT_LogSonTarget_Internalname, A223XT_LogSonTarget, StringUtil.RTrim( context.localUtil.Format( A223XT_LogSonTarget, "")), "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtXT_LogSonTarget_Jsonclick, 0, "Attribute", "", "", "", "", edtXT_LogSonTarget_Visible, 0, 0, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_XT_LogGeneral.htm");
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtXT_LogTargetSonModule_Internalname, A222XT_LogTargetSonModule, StringUtil.RTrim( context.localUtil.Format( A222XT_LogTargetSonModule, "")), "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtXT_LogTargetSonModule_Jsonclick, 0, "Attribute", "", "", "", "", edtXT_LogTargetSonModule_Visible, 0, 0, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_XT_LogGeneral.htm");
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, cmbXT_LogTargetOperate, cmbXT_LogTargetOperate_Internalname, StringUtil.RTrim( A218XT_LogTargetOperate), 1, cmbXT_LogTargetOperate_Jsonclick, 0, "'"+sPrefix+"'"+",false,"+"'"+""+"'", "svchar", "", cmbXT_LogTargetOperate.Visible, 0, 0, 0, 0, "em", 0, "", "", "Attribute", "", "", "", "", true, "HLP_XT_LogGeneral.htm");
            cmbXT_LogTargetOperate.CurrentValue = StringUtil.RTrim( A218XT_LogTargetOperate);
            context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, cmbXT_LogTargetOperate_Internalname, "Values", (String)(cmbXT_LogTargetOperate.ToJavascriptSource()), true);
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
         }
         wbLoad = true;
      }

      protected void START4I2( )
      {
         wbLoad = false;
         wbEnd = 0;
         wbStart = 0;
         if ( StringUtil.Len( sPrefix) == 0 )
         {
            if ( ! context.isSpaRequest( ) )
            {
               Form.Meta.addItem("generator", "GeneXus C# 16_0_0-127771", 0) ;
               Form.Meta.addItem("description", "XT_Log General", 0) ;
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
               STRUP4I0( ) ;
            }
         }
      }

      protected void WS4I2( )
      {
         START4I2( ) ;
         EVT4I2( ) ;
      }

      protected void EVT4I2( )
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
                                 STRUP4I0( ) ;
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
                                 STRUP4I0( ) ;
                              }
                              if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
                              {
                                 context.wbHandled = 1;
                                 if ( ! wbErr )
                                 {
                                    dynload_actions( ) ;
                                    /* Execute user event: Start */
                                    E134I2 ();
                                 }
                              }
                           }
                           else if ( StringUtil.StrCmp(sEvt, "LOAD") == 0 )
                           {
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP4I0( ) ;
                              }
                              if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
                              {
                                 context.wbHandled = 1;
                                 if ( ! wbErr )
                                 {
                                    dynload_actions( ) ;
                                    /* Execute user event: Load */
                                    E144I2 ();
                                 }
                              }
                           }
                           else if ( StringUtil.StrCmp(sEvt, "ENTER") == 0 )
                           {
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP4I0( ) ;
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
                                 STRUP4I0( ) ;
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

      protected void WE4I2( )
      {
         if ( ! GxWebStd.gx_redirect( context) )
         {
            Rfr0gs = true;
            Refresh( ) ;
            if ( ! GxWebStd.gx_redirect( context) )
            {
               RenderHtmlCloseForm4I2( ) ;
            }
         }
      }

      protected void PA4I2( )
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
         if ( cmbXT_LogTargetOperate.ItemCount > 0 )
         {
            A218XT_LogTargetOperate = cmbXT_LogTargetOperate.getValidValue(A218XT_LogTargetOperate);
            n218XT_LogTargetOperate = false;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A218XT_LogTargetOperate", A218XT_LogTargetOperate);
         }
         if ( context.isAjaxRequest( ) )
         {
            cmbXT_LogTargetOperate.CurrentValue = StringUtil.RTrim( A218XT_LogTargetOperate);
            context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, cmbXT_LogTargetOperate_Internalname, "Values", cmbXT_LogTargetOperate.ToJavascriptSource(), true);
         }
      }

      public void Refresh( )
      {
         send_integrity_hashes( ) ;
         RF4I2( ) ;
         if ( isFullAjaxMode( ) )
         {
            send_integrity_footer_hashes( ) ;
         }
      }

      protected void initialize_formulas( )
      {
         /* GeneXus formulas. */
         AV16Pgmname = "XT_LogGeneral";
         context.Gx_err = 0;
      }

      protected void RF4I2( )
      {
         initialize_formulas( ) ;
         clear_multi_value_controls( ) ;
         gxdyncontrolsrefreshing = true;
         fix_multi_value_controls( ) ;
         gxdyncontrolsrefreshing = false;
         if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
         {
            /* Using cursor H004I2 */
            pr_default.execute(0, new Object[] {A173XT_LogID});
            while ( (pr_default.getStatus(0) != 101) )
            {
               A218XT_LogTargetOperate = H004I2_A218XT_LogTargetOperate[0];
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A218XT_LogTargetOperate", A218XT_LogTargetOperate);
               n218XT_LogTargetOperate = H004I2_n218XT_LogTargetOperate[0];
               A222XT_LogTargetSonModule = H004I2_A222XT_LogTargetSonModule[0];
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A222XT_LogTargetSonModule", A222XT_LogTargetSonModule);
               n222XT_LogTargetSonModule = H004I2_n222XT_LogTargetSonModule[0];
               A223XT_LogSonTarget = H004I2_A223XT_LogSonTarget[0];
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A223XT_LogSonTarget", A223XT_LogSonTarget);
               n223XT_LogSonTarget = H004I2_n223XT_LogSonTarget[0];
               A215XT_LogProviderID = H004I2_A215XT_LogProviderID[0];
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A215XT_LogProviderID", StringUtil.LTrim( StringUtil.Str( (decimal)(A215XT_LogProviderID), 18, 0)));
               n215XT_LogProviderID = H004I2_n215XT_LogProviderID[0];
               A213XT_LogType = H004I2_A213XT_LogType[0];
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A213XT_LogType", A213XT_LogType);
               n213XT_LogType = H004I2_n213XT_LogType[0];
               A177XT_LogButtonName = H004I2_A177XT_LogButtonName[0];
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A177XT_LogButtonName", A177XT_LogButtonName);
               n177XT_LogButtonName = H004I2_n177XT_LogButtonName[0];
               A176XT_LogPage = H004I2_A176XT_LogPage[0];
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A176XT_LogPage", A176XT_LogPage);
               n176XT_LogPage = H004I2_n176XT_LogPage[0];
               A214XT_LogUserID = H004I2_A214XT_LogUserID[0];
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A214XT_LogUserID", StringUtil.LTrim( StringUtil.Str( (decimal)(A214XT_LogUserID), 18, 0)));
               n214XT_LogUserID = H004I2_n214XT_LogUserID[0];
               A221XT_LogDescription = H004I2_A221XT_LogDescription[0];
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A221XT_LogDescription", A221XT_LogDescription);
               n221XT_LogDescription = H004I2_n221XT_LogDescription[0];
               A216XT_LogTarget = H004I2_A216XT_LogTarget[0];
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A216XT_LogTarget", A216XT_LogTarget);
               n216XT_LogTarget = H004I2_n216XT_LogTarget[0];
               A217XT_LogTargetModule = H004I2_A217XT_LogTargetModule[0];
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A217XT_LogTargetModule", A217XT_LogTargetModule);
               n217XT_LogTargetModule = H004I2_n217XT_LogTargetModule[0];
               A219XT_LogProviderName = H004I2_A219XT_LogProviderName[0];
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A219XT_LogProviderName", A219XT_LogProviderName);
               n219XT_LogProviderName = H004I2_n219XT_LogProviderName[0];
               A220XT_LogTime = H004I2_A220XT_LogTime[0];
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A220XT_LogTime", context.localUtil.TToC( A220XT_LogTime, 10, 8, 0, 0, "/", ":", " "));
               n220XT_LogTime = H004I2_n220XT_LogTime[0];
               A174XT_LogSecUserName = H004I2_A174XT_LogSecUserName[0];
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A174XT_LogSecUserName", A174XT_LogSecUserName);
               n174XT_LogSecUserName = H004I2_n174XT_LogSecUserName[0];
               /* Execute user event: Load */
               E144I2 ();
               /* Exiting from a For First loop. */
               if (true) break;
            }
            pr_default.close(0);
            WB4I0( ) ;
         }
      }

      protected void send_integrity_lvl_hashes4I2( )
      {
      }

      protected void STRUP4I0( )
      {
         /* Before Start, stand alone formulas. */
         AV16Pgmname = "XT_LogGeneral";
         context.Gx_err = 0;
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0;
         /* Execute user event: Start */
         E134I2 ();
         context.wbGlbDoneStart = 1;
         nDoneStart = 1;
         /* After Start, stand alone formulas. */
         sXEvt = cgiGet( "_EventName");
         if ( ! GetJustCreated( ) && ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 ) )
         {
            /* Read saved SDTs. */
            /* Read variables values. */
            A174XT_LogSecUserName = cgiGet( edtXT_LogSecUserName_Internalname);
            n174XT_LogSecUserName = false;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A174XT_LogSecUserName", A174XT_LogSecUserName);
            A220XT_LogTime = context.localUtil.CToT( cgiGet( edtXT_LogTime_Internalname));
            n220XT_LogTime = false;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A220XT_LogTime", context.localUtil.TToC( A220XT_LogTime, 10, 8, 0, 0, "/", ":", " "));
            A219XT_LogProviderName = cgiGet( edtXT_LogProviderName_Internalname);
            n219XT_LogProviderName = false;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A219XT_LogProviderName", A219XT_LogProviderName);
            A217XT_LogTargetModule = cgiGet( edtXT_LogTargetModule_Internalname);
            n217XT_LogTargetModule = false;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A217XT_LogTargetModule", A217XT_LogTargetModule);
            A216XT_LogTarget = cgiGet( edtXT_LogTarget_Internalname);
            n216XT_LogTarget = false;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A216XT_LogTarget", A216XT_LogTarget);
            A221XT_LogDescription = cgiGet( edtXT_LogDescription_Internalname);
            n221XT_LogDescription = false;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A221XT_LogDescription", A221XT_LogDescription);
            A214XT_LogUserID = (long)(context.localUtil.CToN( cgiGet( edtXT_LogUserID_Internalname), ".", ","));
            n214XT_LogUserID = false;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A214XT_LogUserID", StringUtil.LTrim( StringUtil.Str( (decimal)(A214XT_LogUserID), 18, 0)));
            A176XT_LogPage = cgiGet( edtXT_LogPage_Internalname);
            n176XT_LogPage = false;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A176XT_LogPage", A176XT_LogPage);
            A177XT_LogButtonName = cgiGet( edtXT_LogButtonName_Internalname);
            n177XT_LogButtonName = false;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A177XT_LogButtonName", A177XT_LogButtonName);
            A213XT_LogType = cgiGet( edtXT_LogType_Internalname);
            n213XT_LogType = false;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A213XT_LogType", A213XT_LogType);
            A215XT_LogProviderID = (long)(context.localUtil.CToN( cgiGet( edtXT_LogProviderID_Internalname), ".", ","));
            n215XT_LogProviderID = false;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A215XT_LogProviderID", StringUtil.LTrim( StringUtil.Str( (decimal)(A215XT_LogProviderID), 18, 0)));
            A223XT_LogSonTarget = cgiGet( edtXT_LogSonTarget_Internalname);
            n223XT_LogSonTarget = false;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A223XT_LogSonTarget", A223XT_LogSonTarget);
            A222XT_LogTargetSonModule = cgiGet( edtXT_LogTargetSonModule_Internalname);
            n222XT_LogTargetSonModule = false;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A222XT_LogTargetSonModule", A222XT_LogTargetSonModule);
            cmbXT_LogTargetOperate.CurrentValue = cgiGet( cmbXT_LogTargetOperate_Internalname);
            A218XT_LogTargetOperate = cgiGet( cmbXT_LogTargetOperate_Internalname);
            n218XT_LogTargetOperate = false;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A218XT_LogTargetOperate", A218XT_LogTargetOperate);
            /* Read saved values. */
            wcpOA173XT_LogID = (long)(context.localUtil.CToN( cgiGet( sPrefix+"wcpOA173XT_LogID"), ".", ","));
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
         E134I2 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E134I2( )
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

      protected void E144I2( )
      {
         /* Load Routine */
         edtXT_LogID_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtXT_LogID_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtXT_LogID_Visible), 5, 0)), true);
         edtXT_LogUserID_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtXT_LogUserID_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtXT_LogUserID_Visible), 5, 0)), true);
         edtXT_LogPage_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtXT_LogPage_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtXT_LogPage_Visible), 5, 0)), true);
         edtXT_LogButtonName_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtXT_LogButtonName_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtXT_LogButtonName_Visible), 5, 0)), true);
         edtXT_LogType_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtXT_LogType_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtXT_LogType_Visible), 5, 0)), true);
         edtXT_LogProviderID_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtXT_LogProviderID_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtXT_LogProviderID_Visible), 5, 0)), true);
         edtXT_LogSonTarget_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtXT_LogSonTarget_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtXT_LogSonTarget_Visible), 5, 0)), true);
         edtXT_LogTargetSonModule_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtXT_LogTargetSonModule_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtXT_LogTargetSonModule_Visible), 5, 0)), true);
         cmbXT_LogTargetOperate.Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, cmbXT_LogTargetOperate_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(cmbXT_LogTargetOperate.Visible), 5, 0)), true);
         GXt_boolean1 = AV13TempBoolean;
         new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "WWXT_Log_Update", out  GXt_boolean1) ;
         AV13TempBoolean = GXt_boolean1;
         if ( ! ( AV13TempBoolean ) )
         {
            bttBtnupdate_Visible = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, bttBtnupdate_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtnupdate_Visible), 5, 0)), true);
         }
         GXt_boolean1 = AV13TempBoolean;
         new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "WWXT_Log_Delete", out  GXt_boolean1) ;
         AV13TempBoolean = GXt_boolean1;
         if ( ! ( AV13TempBoolean ) )
         {
            bttBtndelete_Visible = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, bttBtndelete_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtndelete_Visible), 5, 0)), true);
         }
      }

      protected void S112( )
      {
         /* 'PREPARETRANSACTION' Routine */
         AV9TrnContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext(context);
         AV9TrnContext.gxTpr_Callerobject = AV16Pgmname;
         AV9TrnContext.gxTpr_Callerondelete = false;
         AV9TrnContext.gxTpr_Callerurl = AV12HTTPRequest.ScriptName+"?"+AV12HTTPRequest.QueryString;
         AV9TrnContext.gxTpr_Transactionname = "XT_Log";
         AV10TrnContextAtt = new GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext_Attribute(context);
         AV10TrnContextAtt.gxTpr_Attributename = "XT_LogID";
         AV10TrnContextAtt.gxTpr_Attributevalue = StringUtil.Str( (decimal)(AV8XT_LogID), 18, 0);
         AV9TrnContext.gxTpr_Attributes.Add(AV10TrnContextAtt, 0);
         AV11Session.Set("TrnContext", AV9TrnContext.ToXml(false, true, "WWPTransactionContext", "DataAnalysisPlatform"));
      }

      public override void setparameters( Object[] obj )
      {
         createObjects();
         initialize();
         A173XT_LogID = Convert.ToInt64(getParm(obj,0));
         context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A173XT_LogID", StringUtil.LTrim( StringUtil.Str( (decimal)(A173XT_LogID), 18, 0)));
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
         PA4I2( ) ;
         WS4I2( ) ;
         WE4I2( ) ;
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
         sCtrlA173XT_LogID = (String)((String)getParm(obj,0));
      }

      public override void componentrestorestate( String sPPrefix ,
                                                  String sPSFPrefix )
      {
         sPrefix = sPPrefix + sPSFPrefix;
         PA4I2( ) ;
         WCParametersGet( ) ;
      }

      public override void componentprepare( Object[] obj )
      {
         wbLoad = false;
         sCompPrefix = (String)getParm(obj,0);
         sSFPrefix = (String)getParm(obj,1);
         sPrefix = sCompPrefix + sSFPrefix;
         AddComponentObject(sPrefix, "xt_loggeneral", GetJustCreated( ));
         if ( ( nDoneStart == 0 ) && ( nDynComponent == 0 ) )
         {
            INITWEB( ) ;
         }
         else
         {
            init_default_properties( ) ;
            init_web_controls( ) ;
         }
         PA4I2( ) ;
         if ( ! GetJustCreated( ) && ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 ) && ( context.wbGlbDoneStart == 0 ) )
         {
            WCParametersGet( ) ;
         }
         else
         {
            A173XT_LogID = Convert.ToInt64(getParm(obj,2));
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A173XT_LogID", StringUtil.LTrim( StringUtil.Str( (decimal)(A173XT_LogID), 18, 0)));
         }
         wcpOA173XT_LogID = (long)(context.localUtil.CToN( cgiGet( sPrefix+"wcpOA173XT_LogID"), ".", ","));
         if ( ! GetJustCreated( ) && ( ( A173XT_LogID != wcpOA173XT_LogID ) ) )
         {
            setjustcreated();
         }
         wcpOA173XT_LogID = A173XT_LogID;
      }

      protected void WCParametersGet( )
      {
         /* Read Component Parameters. */
         sCtrlA173XT_LogID = cgiGet( sPrefix+"A173XT_LogID_CTRL");
         if ( StringUtil.Len( sCtrlA173XT_LogID) > 0 )
         {
            A173XT_LogID = (long)(context.localUtil.CToN( cgiGet( sCtrlA173XT_LogID), ".", ","));
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A173XT_LogID", StringUtil.LTrim( StringUtil.Str( (decimal)(A173XT_LogID), 18, 0)));
         }
         else
         {
            A173XT_LogID = (long)(context.localUtil.CToN( cgiGet( sPrefix+"A173XT_LogID_PARM"), ".", ","));
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
         PA4I2( ) ;
         sEvt = sCompEvt;
         WCParametersGet( ) ;
         WS4I2( ) ;
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
         WS4I2( ) ;
         SaveComponentMsgList(sPrefix);
         context.GX_msglist = BackMsgLst;
      }

      protected void WCParametersSet( )
      {
         GxWebStd.gx_hidden_field( context, sPrefix+"A173XT_LogID_PARM", StringUtil.LTrim( StringUtil.NToC( (decimal)(A173XT_LogID), 18, 0, ".", "")));
         if ( StringUtil.Len( StringUtil.RTrim( sCtrlA173XT_LogID)) > 0 )
         {
            GxWebStd.gx_hidden_field( context, sPrefix+"A173XT_LogID_CTRL", StringUtil.RTrim( sCtrlA173XT_LogID));
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
         WE4I2( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?20202279372040", true);
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
         context.AddJavascriptSource("xt_loggeneral.js", "?20202279372041", false);
         /* End function include_jscripts */
      }

      protected void init_web_controls( )
      {
         cmbXT_LogTargetOperate.Name = "XT_LOGTARGETOPERATE";
         cmbXT_LogTargetOperate.WebTags = "";
         cmbXT_LogTargetOperate.addItem("Create", "新增", 0);
         cmbXT_LogTargetOperate.addItem("Update", "编辑", 0);
         cmbXT_LogTargetOperate.addItem("Delete", "删除", 0);
         cmbXT_LogTargetOperate.addItem("Create", "保存", 0);
         cmbXT_LogTargetOperate.addItem("Submit", "提交审批", 0);
         cmbXT_LogTargetOperate.addItem("Batchcheck", "批量初审", 0);
         cmbXT_LogTargetOperate.addItem("Batchapprove", "批量复审", 0);
         cmbXT_LogTargetOperate.addItem("Randomcheckpass", "初审抽查通过", 0);
         cmbXT_LogTargetOperate.addItem("Randomcheckrefuse", "初审抽查不通过", 0);
         cmbXT_LogTargetOperate.addItem("Randomapprovepass", "复审抽查通过", 0);
         cmbXT_LogTargetOperate.addItem("Randomapproverefuse", "复审抽查不通过", 0);
         cmbXT_LogTargetOperate.addItem("Check", "初审通过", 0);
         cmbXT_LogTargetOperate.addItem("Approve", "复审通过", 0);
         cmbXT_LogTargetOperate.addItem("Reupdate", "重新修改", 0);
         cmbXT_LogTargetOperate.addItem("Login", "登录", 0);
         if ( cmbXT_LogTargetOperate.ItemCount > 0 )
         {
         }
         /* End function init_web_controls */
      }

      protected void init_default_properties( )
      {
         edtXT_LogSecUserName_Internalname = sPrefix+"XT_LOGSECUSERNAME";
         edtXT_LogTime_Internalname = sPrefix+"XT_LOGTIME";
         edtXT_LogProviderName_Internalname = sPrefix+"XT_LOGPROVIDERNAME";
         edtXT_LogTargetModule_Internalname = sPrefix+"XT_LOGTARGETMODULE";
         lblTextblockxt_logtarget_Internalname = sPrefix+"TEXTBLOCKXT_LOGTARGET";
         edtXT_LogTarget_Internalname = sPrefix+"XT_LOGTARGET";
         divUnnamedtablext_logtarget_Internalname = sPrefix+"UNNAMEDTABLEXT_LOGTARGET";
         lblTextblockxt_logdescription_Internalname = sPrefix+"TEXTBLOCKXT_LOGDESCRIPTION";
         edtXT_LogDescription_Internalname = sPrefix+"XT_LOGDESCRIPTION";
         divUnnamedtablext_logdescription_Internalname = sPrefix+"UNNAMEDTABLEXT_LOGDESCRIPTION";
         divTransactiondetail_tableattributes_Internalname = sPrefix+"TRANSACTIONDETAIL_TABLEATTRIBUTES";
         bttBtnupdate_Internalname = sPrefix+"BTNUPDATE";
         bttBtndelete_Internalname = sPrefix+"BTNDELETE";
         divTable_Internalname = sPrefix+"TABLE";
         edtXT_LogID_Internalname = sPrefix+"XT_LOGID";
         edtXT_LogUserID_Internalname = sPrefix+"XT_LOGUSERID";
         edtXT_LogPage_Internalname = sPrefix+"XT_LOGPAGE";
         edtXT_LogButtonName_Internalname = sPrefix+"XT_LOGBUTTONNAME";
         edtXT_LogType_Internalname = sPrefix+"XT_LOGTYPE";
         edtXT_LogProviderID_Internalname = sPrefix+"XT_LOGPROVIDERID";
         edtXT_LogSonTarget_Internalname = sPrefix+"XT_LOGSONTARGET";
         edtXT_LogTargetSonModule_Internalname = sPrefix+"XT_LOGTARGETSONMODULE";
         cmbXT_LogTargetOperate_Internalname = sPrefix+"XT_LOGTARGETOPERATE";
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
         cmbXT_LogTargetOperate_Jsonclick = "";
         cmbXT_LogTargetOperate.Visible = 1;
         edtXT_LogTargetSonModule_Jsonclick = "";
         edtXT_LogTargetSonModule_Visible = 1;
         edtXT_LogSonTarget_Jsonclick = "";
         edtXT_LogSonTarget_Visible = 1;
         edtXT_LogProviderID_Jsonclick = "";
         edtXT_LogProviderID_Visible = 1;
         edtXT_LogType_Jsonclick = "";
         edtXT_LogType_Visible = 1;
         edtXT_LogButtonName_Jsonclick = "";
         edtXT_LogButtonName_Visible = 1;
         edtXT_LogPage_Jsonclick = "";
         edtXT_LogPage_Visible = 1;
         edtXT_LogUserID_Jsonclick = "";
         edtXT_LogUserID_Visible = 1;
         edtXT_LogID_Jsonclick = "";
         edtXT_LogID_Visible = 1;
         bttBtndelete_Visible = 1;
         bttBtnupdate_Visible = 1;
         edtXT_LogDescription_Enabled = 0;
         edtXT_LogTarget_Enabled = 0;
         edtXT_LogTargetModule_Jsonclick = "";
         edtXT_LogTargetModule_Enabled = 0;
         edtXT_LogProviderName_Jsonclick = "";
         edtXT_LogProviderName_Enabled = 0;
         edtXT_LogTime_Jsonclick = "";
         edtXT_LogTime_Enabled = 0;
         edtXT_LogSecUserName_Jsonclick = "";
         edtXT_LogSecUserName_Enabled = 0;
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
         setEventMetadata("'DOUPDATE'","{handler:'E114I1',iparms:[{av:'A173XT_LogID',fld:'XT_LOGID',pic:'ZZZZZZZZZZZZZZZZZZ'}]");
         setEventMetadata("'DOUPDATE'",",oparms:[]}");
         setEventMetadata("'DODELETE'","{handler:'E124I1',iparms:[{av:'A173XT_LogID',fld:'XT_LOGID',pic:'ZZZZZZZZZZZZZZZZZZ'}]");
         setEventMetadata("'DODELETE'",",oparms:[]}");
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
         AV16Pgmname = "";
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         GXKey = "";
         GX_FocusControl = "";
         A174XT_LogSecUserName = "";
         A220XT_LogTime = (DateTime)(DateTime.MinValue);
         A219XT_LogProviderName = "";
         A217XT_LogTargetModule = "";
         lblTextblockxt_logtarget_Jsonclick = "";
         ClassString = "";
         StyleString = "";
         A216XT_LogTarget = "";
         lblTextblockxt_logdescription_Jsonclick = "";
         A221XT_LogDescription = "";
         TempTags = "";
         bttBtnupdate_Jsonclick = "";
         bttBtndelete_Jsonclick = "";
         A176XT_LogPage = "";
         A177XT_LogButtonName = "";
         A213XT_LogType = "";
         A223XT_LogSonTarget = "";
         A222XT_LogTargetSonModule = "";
         A218XT_LogTargetOperate = "";
         Form = new GXWebForm();
         sXEvt = "";
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         scmdbuf = "";
         H004I2_A173XT_LogID = new long[1] ;
         H004I2_A218XT_LogTargetOperate = new String[] {""} ;
         H004I2_n218XT_LogTargetOperate = new bool[] {false} ;
         H004I2_A222XT_LogTargetSonModule = new String[] {""} ;
         H004I2_n222XT_LogTargetSonModule = new bool[] {false} ;
         H004I2_A223XT_LogSonTarget = new String[] {""} ;
         H004I2_n223XT_LogSonTarget = new bool[] {false} ;
         H004I2_A215XT_LogProviderID = new long[1] ;
         H004I2_n215XT_LogProviderID = new bool[] {false} ;
         H004I2_A213XT_LogType = new String[] {""} ;
         H004I2_n213XT_LogType = new bool[] {false} ;
         H004I2_A177XT_LogButtonName = new String[] {""} ;
         H004I2_n177XT_LogButtonName = new bool[] {false} ;
         H004I2_A176XT_LogPage = new String[] {""} ;
         H004I2_n176XT_LogPage = new bool[] {false} ;
         H004I2_A214XT_LogUserID = new long[1] ;
         H004I2_n214XT_LogUserID = new bool[] {false} ;
         H004I2_A221XT_LogDescription = new String[] {""} ;
         H004I2_n221XT_LogDescription = new bool[] {false} ;
         H004I2_A216XT_LogTarget = new String[] {""} ;
         H004I2_n216XT_LogTarget = new bool[] {false} ;
         H004I2_A217XT_LogTargetModule = new String[] {""} ;
         H004I2_n217XT_LogTargetModule = new bool[] {false} ;
         H004I2_A219XT_LogProviderName = new String[] {""} ;
         H004I2_n219XT_LogProviderName = new bool[] {false} ;
         H004I2_A220XT_LogTime = new DateTime[] {DateTime.MinValue} ;
         H004I2_n220XT_LogTime = new bool[] {false} ;
         H004I2_A174XT_LogSecUserName = new String[] {""} ;
         H004I2_n174XT_LogSecUserName = new bool[] {false} ;
         AV6WWPContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPContext(context);
         AV9TrnContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext(context);
         AV12HTTPRequest = new GxHttpRequest( context);
         AV10TrnContextAtt = new GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext_Attribute(context);
         AV11Session = context.GetSession();
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         sCtrlA173XT_LogID = "";
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.xt_loggeneral__default(),
            new Object[][] {
                new Object[] {
               H004I2_A173XT_LogID, H004I2_A218XT_LogTargetOperate, H004I2_n218XT_LogTargetOperate, H004I2_A222XT_LogTargetSonModule, H004I2_n222XT_LogTargetSonModule, H004I2_A223XT_LogSonTarget, H004I2_n223XT_LogSonTarget, H004I2_A215XT_LogProviderID, H004I2_n215XT_LogProviderID, H004I2_A213XT_LogType,
               H004I2_n213XT_LogType, H004I2_A177XT_LogButtonName, H004I2_n177XT_LogButtonName, H004I2_A176XT_LogPage, H004I2_n176XT_LogPage, H004I2_A214XT_LogUserID, H004I2_n214XT_LogUserID, H004I2_A221XT_LogDescription, H004I2_n221XT_LogDescription, H004I2_A216XT_LogTarget,
               H004I2_n216XT_LogTarget, H004I2_A217XT_LogTargetModule, H004I2_n217XT_LogTargetModule, H004I2_A219XT_LogProviderName, H004I2_n219XT_LogProviderName, H004I2_A220XT_LogTime, H004I2_n220XT_LogTime, H004I2_A174XT_LogSecUserName, H004I2_n174XT_LogSecUserName
               }
            }
         );
         AV16Pgmname = "XT_LogGeneral";
         /* GeneXus formulas. */
         AV16Pgmname = "XT_LogGeneral";
         context.Gx_err = 0;
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
      private int edtXT_LogSecUserName_Enabled ;
      private int edtXT_LogTime_Enabled ;
      private int edtXT_LogProviderName_Enabled ;
      private int edtXT_LogTargetModule_Enabled ;
      private int edtXT_LogTarget_Enabled ;
      private int edtXT_LogDescription_Enabled ;
      private int bttBtnupdate_Visible ;
      private int bttBtndelete_Visible ;
      private int edtXT_LogID_Visible ;
      private int edtXT_LogUserID_Visible ;
      private int edtXT_LogPage_Visible ;
      private int edtXT_LogButtonName_Visible ;
      private int edtXT_LogType_Visible ;
      private int edtXT_LogProviderID_Visible ;
      private int edtXT_LogSonTarget_Visible ;
      private int edtXT_LogTargetSonModule_Visible ;
      private int idxLst ;
      private long A173XT_LogID ;
      private long wcpOA173XT_LogID ;
      private long A214XT_LogUserID ;
      private long A215XT_LogProviderID ;
      private long AV8XT_LogID ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String sPrefix ;
      private String sCompPrefix ;
      private String sSFPrefix ;
      private String AV16Pgmname ;
      private String sDynURL ;
      private String FormProcess ;
      private String bodyStyle ;
      private String GXKey ;
      private String GX_FocusControl ;
      private String divLayoutmaintable_Internalname ;
      private String divTable_Internalname ;
      private String divTransactiondetail_tableattributes_Internalname ;
      private String edtXT_LogSecUserName_Internalname ;
      private String edtXT_LogSecUserName_Jsonclick ;
      private String edtXT_LogTime_Internalname ;
      private String edtXT_LogTime_Jsonclick ;
      private String edtXT_LogProviderName_Internalname ;
      private String edtXT_LogProviderName_Jsonclick ;
      private String edtXT_LogTargetModule_Internalname ;
      private String edtXT_LogTargetModule_Jsonclick ;
      private String divUnnamedtablext_logtarget_Internalname ;
      private String lblTextblockxt_logtarget_Internalname ;
      private String lblTextblockxt_logtarget_Jsonclick ;
      private String edtXT_LogTarget_Internalname ;
      private String ClassString ;
      private String StyleString ;
      private String divUnnamedtablext_logdescription_Internalname ;
      private String lblTextblockxt_logdescription_Internalname ;
      private String lblTextblockxt_logdescription_Jsonclick ;
      private String edtXT_LogDescription_Internalname ;
      private String TempTags ;
      private String bttBtnupdate_Internalname ;
      private String bttBtnupdate_Jsonclick ;
      private String bttBtndelete_Internalname ;
      private String bttBtndelete_Jsonclick ;
      private String divHtml_bottomauxiliarcontrols_Internalname ;
      private String edtXT_LogID_Internalname ;
      private String edtXT_LogID_Jsonclick ;
      private String edtXT_LogUserID_Internalname ;
      private String edtXT_LogUserID_Jsonclick ;
      private String edtXT_LogPage_Internalname ;
      private String edtXT_LogPage_Jsonclick ;
      private String edtXT_LogButtonName_Internalname ;
      private String edtXT_LogButtonName_Jsonclick ;
      private String edtXT_LogType_Internalname ;
      private String edtXT_LogType_Jsonclick ;
      private String edtXT_LogProviderID_Internalname ;
      private String edtXT_LogProviderID_Jsonclick ;
      private String edtXT_LogSonTarget_Internalname ;
      private String edtXT_LogSonTarget_Jsonclick ;
      private String edtXT_LogTargetSonModule_Internalname ;
      private String edtXT_LogTargetSonModule_Jsonclick ;
      private String cmbXT_LogTargetOperate_Internalname ;
      private String cmbXT_LogTargetOperate_Jsonclick ;
      private String sXEvt ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String scmdbuf ;
      private String sCtrlA173XT_LogID ;
      private DateTime A220XT_LogTime ;
      private bool entryPointCalled ;
      private bool toggleJsOutput ;
      private bool wbLoad ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool n218XT_LogTargetOperate ;
      private bool gxdyncontrolsrefreshing ;
      private bool n222XT_LogTargetSonModule ;
      private bool n223XT_LogSonTarget ;
      private bool n215XT_LogProviderID ;
      private bool n213XT_LogType ;
      private bool n177XT_LogButtonName ;
      private bool n176XT_LogPage ;
      private bool n214XT_LogUserID ;
      private bool n221XT_LogDescription ;
      private bool n216XT_LogTarget ;
      private bool n217XT_LogTargetModule ;
      private bool n219XT_LogProviderName ;
      private bool n220XT_LogTime ;
      private bool n174XT_LogSecUserName ;
      private bool returnInSub ;
      private bool AV13TempBoolean ;
      private bool GXt_boolean1 ;
      private String A174XT_LogSecUserName ;
      private String A219XT_LogProviderName ;
      private String A217XT_LogTargetModule ;
      private String A216XT_LogTarget ;
      private String A221XT_LogDescription ;
      private String A176XT_LogPage ;
      private String A177XT_LogButtonName ;
      private String A213XT_LogType ;
      private String A223XT_LogSonTarget ;
      private String A222XT_LogTargetSonModule ;
      private String A218XT_LogTargetOperate ;
      private GXWebForm Form ;
      private IGxDataStore dsDataStore1 ;
      private IGxDataStore dsDefault ;
      private GXCombobox cmbXT_LogTargetOperate ;
      private IDataStoreProvider pr_default ;
      private long[] H004I2_A173XT_LogID ;
      private String[] H004I2_A218XT_LogTargetOperate ;
      private bool[] H004I2_n218XT_LogTargetOperate ;
      private String[] H004I2_A222XT_LogTargetSonModule ;
      private bool[] H004I2_n222XT_LogTargetSonModule ;
      private String[] H004I2_A223XT_LogSonTarget ;
      private bool[] H004I2_n223XT_LogSonTarget ;
      private long[] H004I2_A215XT_LogProviderID ;
      private bool[] H004I2_n215XT_LogProviderID ;
      private String[] H004I2_A213XT_LogType ;
      private bool[] H004I2_n213XT_LogType ;
      private String[] H004I2_A177XT_LogButtonName ;
      private bool[] H004I2_n177XT_LogButtonName ;
      private String[] H004I2_A176XT_LogPage ;
      private bool[] H004I2_n176XT_LogPage ;
      private long[] H004I2_A214XT_LogUserID ;
      private bool[] H004I2_n214XT_LogUserID ;
      private String[] H004I2_A221XT_LogDescription ;
      private bool[] H004I2_n221XT_LogDescription ;
      private String[] H004I2_A216XT_LogTarget ;
      private bool[] H004I2_n216XT_LogTarget ;
      private String[] H004I2_A217XT_LogTargetModule ;
      private bool[] H004I2_n217XT_LogTargetModule ;
      private String[] H004I2_A219XT_LogProviderName ;
      private bool[] H004I2_n219XT_LogProviderName ;
      private DateTime[] H004I2_A220XT_LogTime ;
      private bool[] H004I2_n220XT_LogTime ;
      private String[] H004I2_A174XT_LogSecUserName ;
      private bool[] H004I2_n174XT_LogSecUserName ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private GxHttpRequest AV12HTTPRequest ;
      private IGxSession AV11Session ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPContext AV6WWPContext ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext AV9TrnContext ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext_Attribute AV10TrnContextAtt ;
   }

   public class xt_loggeneral__default : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmH004I2 ;
          prmH004I2 = new Object[] {
          new Object[] {"@XT_LogID",SqlDbType.Decimal,18,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("H004I2", "SELECT [XT_LogID], [XT_LogTargetOperate], [XT_LogTargetSonModule], [XT_LogSonTarget], [XT_LogProviderID], [XT_LogType], [XT_LogButtonName], [XT_LogPage], [XT_LogUserID], [XT_LogDescription], [XT_LogTarget], [XT_LogTargetModule], [XT_LogProviderName], [XT_LogTime], [XT_LogSecUserName] FROM [XT_Log] WITH (NOLOCK) WHERE [XT_LogID] = @XT_LogID ORDER BY [XT_LogID] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH004I2,1,0,true,true )
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
                ((String[]) buf[9])[0] = rslt.getVarchar(6) ;
                ((bool[]) buf[10])[0] = rslt.wasNull(6);
                ((String[]) buf[11])[0] = rslt.getVarchar(7) ;
                ((bool[]) buf[12])[0] = rslt.wasNull(7);
                ((String[]) buf[13])[0] = rslt.getVarchar(8) ;
                ((bool[]) buf[14])[0] = rslt.wasNull(8);
                ((long[]) buf[15])[0] = rslt.getLong(9) ;
                ((bool[]) buf[16])[0] = rslt.wasNull(9);
                ((String[]) buf[17])[0] = rslt.getVarchar(10) ;
                ((bool[]) buf[18])[0] = rslt.wasNull(10);
                ((String[]) buf[19])[0] = rslt.getVarchar(11) ;
                ((bool[]) buf[20])[0] = rslt.wasNull(11);
                ((String[]) buf[21])[0] = rslt.getVarchar(12) ;
                ((bool[]) buf[22])[0] = rslt.wasNull(12);
                ((String[]) buf[23])[0] = rslt.getVarchar(13) ;
                ((bool[]) buf[24])[0] = rslt.wasNull(13);
                ((DateTime[]) buf[25])[0] = rslt.getGXDateTime(14) ;
                ((bool[]) buf[26])[0] = rslt.wasNull(14);
                ((String[]) buf[27])[0] = rslt.getVarchar(15) ;
                ((bool[]) buf[28])[0] = rslt.wasNull(15);
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
