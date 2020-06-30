/*
               File: BR_VitalGeneral
        Description: BR_Vital General
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/27/2020 11:53:58.49
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
   public class br_vitalgeneral : GXWebComponent, System.Web.SessionState.IRequiresSessionState
   {
      public br_vitalgeneral( )
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

      public br_vitalgeneral( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( long aP0_BR_VitalID )
      {
         this.A150BR_VitalID = aP0_BR_VitalID;
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
                  A150BR_VitalID = (long)(NumberUtil.Val( GetNextPar( ), "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A150BR_VitalID", StringUtil.LTrim( StringUtil.Str( (decimal)(A150BR_VitalID), 18, 0)));
                  setjustcreated();
                  componentprepare(new Object[] {(String)sCompPrefix,(String)sSFPrefix,(long)A150BR_VitalID});
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
            PA5Z2( ) ;
            if ( ( GxWebError == 0 ) && ! isAjaxCallMode( ) )
            {
               /* GeneXus formulas. */
               AV15Pgmname = "BR_VitalGeneral";
               context.Gx_err = 0;
               WS5Z2( ) ;
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
            context.SendWebValue( "BR_Vital General") ;
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
         context.AddJavascriptSource("gxcfg.js", "?202022711535853", false);
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
            FormProcess = ((nGXWrapped==0) ? " data-HasEnter=\"false\" data-Skiponenter=\"false\"" : "");
            context.WriteHtmlText( "<body ") ;
            bodyStyle = "";
            if ( nGXWrapped == 0 )
            {
               bodyStyle = bodyStyle + "-moz-opacity:0;opacity:0;";
            }
            context.WriteHtmlText( " "+"class=\"form-horizontal Form\""+" "+ "style='"+bodyStyle+"'") ;
            context.WriteHtmlText( FormProcess+">") ;
            context.skipLines(1);
            if ( nGXWrapped != 1 )
            {
               context.WriteHtmlTextNl( "<form id=\"MAINFORM\" autocomplete=\"off\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("br_vitalgeneral.aspx") + "?" + UrlEncode("" +A150BR_VitalID)+"\">") ;
               GxWebStd.gx_hidden_field( context, "_EventName", "");
               GxWebStd.gx_hidden_field( context, "_EventGridId", "");
               GxWebStd.gx_hidden_field( context, "_EventRowId", "");
               context.WriteHtmlText( "<input type=\"submit\" title=\"submit\" style=\"display:none\" disabled>") ;
               context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, "FORM", "Class", "form-horizontal Form", true);
            }
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
         GxWebStd.gx_hidden_field( context, sPrefix+"wcpOA150BR_VitalID", StringUtil.LTrim( StringUtil.NToC( (decimal)(wcpOA150BR_VitalID), 18, 0, ".", "")));
      }

      protected void RenderHtmlCloseForm5Z2( )
      {
         SendCloseFormHiddens( ) ;
         if ( ( StringUtil.Len( sPrefix) != 0 ) && ( context.isAjaxRequest( ) || context.isSpaRequest( ) ) )
         {
            context.AddJavascriptSource("br_vitalgeneral.js", "?202022711535856", false);
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
            if ( nGXWrapped != 1 )
            {
               context.WriteHtmlTextNl( "</form>") ;
            }
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
         return "BR_VitalGeneral" ;
      }

      public override String GetPgmdesc( )
      {
         return "BR_Vital General" ;
      }

      protected void WB5Z0( )
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
               GxWebStd.gx_hidden_field( context, sPrefix+"_CMPPGM", "br_vitalgeneral.aspx");
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
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divUnnamedtablebr_vital_measuredate_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-4 MergeLabelCell", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblockbr_vital_measuredate_Internalname, "测量日期", "", "", lblTextblockbr_vital_measuredate_Jsonclick, "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_BR_VitalGeneral.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-8", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtBR_Vital_MeasureDate_Internalname, "测量日期", "col-sm-3 ReadonlyAttributeLabel", 0, true);
            /* Single line edit */
            context.WriteHtmlText( "<div id=\""+edtBR_Vital_MeasureDate_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtBR_Vital_MeasureDate_Internalname, context.localUtil.Format(A152BR_Vital_MeasureDate, "9999/99/99"), context.localUtil.Format( A152BR_Vital_MeasureDate, "9999/99/99"), "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBR_Vital_MeasureDate_Jsonclick, 0, "ReadonlyAttribute", "", "", "", "", 1, edtBR_Vital_MeasureDate_Enabled, 0, "text", "", 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, 0, true, "DM_Date", "right", false, "HLP_BR_VitalGeneral.htm");
            GxWebStd.gx_bitmap( context, edtBR_Vital_MeasureDate_Internalname+"_dp_trigger", context.GetImagePath( "61b9b5d3-dff6-4d59-9b00-da61bc2cbe93", "", context.GetTheme( )), "", "", "", "", ((1==0)||(edtBR_Vital_MeasureDate_Enabled==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;", "", "", "", "", "", "", "", "", 1, false, false, "", "HLP_BR_VitalGeneral.htm");
            context.WriteHtmlTextNl( "</div>") ;
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divUnnamedtablebr_vital_temperature_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-4 MergeLabelCell", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblockbr_vital_temperature_Internalname, "体温(℃)", "", "", lblTextblockbr_vital_temperature_Jsonclick, "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_BR_VitalGeneral.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-8", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtBR_Vital_Temperature_Internalname, "体温(℃)", "col-sm-3 ReadonlyAttributeLabel", 0, true);
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtBR_Vital_Temperature_Internalname, StringUtil.LTrim( StringUtil.NToC( A153BR_Vital_Temperature, 15, 5, ".", "")), ((edtBR_Vital_Temperature_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( A153BR_Vital_Temperature, "ZZZZZZZZZ.ZZZZZ")) : context.localUtil.Format( A153BR_Vital_Temperature, "ZZZZZZZZZ.ZZZZZ")), "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBR_Vital_Temperature_Jsonclick, 0, "ReadonlyAttribute", "", "", "", "", 1, edtBR_Vital_Temperature_Enabled, 0, "text", "", 15, "chr", 1, "row", 15, 0, 0, 0, 1, -1, 0, true, "DM_Numeric", "right", false, "HLP_BR_VitalGeneral.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
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
            GxWebStd.gx_div_start( context, divUnnamedtablebr_vital_pulse_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-4 MergeLabelCell", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblockbr_vital_pulse_Internalname, "脉搏(次/分钟)", "", "", lblTextblockbr_vital_pulse_Jsonclick, "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_BR_VitalGeneral.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-8", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtBR_Vital_Pulse_Internalname, "脉搏(次/分钟)", "col-sm-3 ReadonlyAttributeLabel", 0, true);
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtBR_Vital_Pulse_Internalname, StringUtil.LTrim( StringUtil.NToC( A154BR_Vital_Pulse, 15, 5, ".", "")), ((edtBR_Vital_Pulse_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( A154BR_Vital_Pulse, "ZZZZZZZZZ.ZZZZZ")) : context.localUtil.Format( A154BR_Vital_Pulse, "ZZZZZZZZZ.ZZZZZ")), "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBR_Vital_Pulse_Jsonclick, 0, "ReadonlyAttribute", "", "", "", "", 1, edtBR_Vital_Pulse_Enabled, 0, "text", "", 15, "chr", 1, "row", 15, 0, 0, 0, 1, -1, 0, true, "DM_Numeric", "right", false, "HLP_BR_VitalGeneral.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divUnnamedtablebr_vital_respiration_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-4 MergeLabelCell", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblockbr_vital_respiration_Internalname, "呼吸频率(次/分钟)", "", "", lblTextblockbr_vital_respiration_Jsonclick, "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_BR_VitalGeneral.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-8", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtBR_Vital_Respiration_Internalname, "呼吸频率(次/分钟)", "col-sm-3 ReadonlyAttributeLabel", 0, true);
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtBR_Vital_Respiration_Internalname, StringUtil.LTrim( StringUtil.NToC( A155BR_Vital_Respiration, 15, 5, ".", "")), ((edtBR_Vital_Respiration_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( A155BR_Vital_Respiration, "ZZZZZZZZZ.ZZZZZ")) : context.localUtil.Format( A155BR_Vital_Respiration, "ZZZZZZZZZ.ZZZZZ")), "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBR_Vital_Respiration_Jsonclick, 0, "ReadonlyAttribute", "", "", "", "", 1, edtBR_Vital_Respiration_Enabled, 0, "text", "", 15, "chr", 1, "row", 15, 0, 0, 0, 1, -1, 0, true, "DM_Numeric", "right", false, "HLP_BR_VitalGeneral.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
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
            GxWebStd.gx_div_start( context, divUnnamedtablebr_vital_systolic_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-4 MergeLabelCell", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblockbr_vital_systolic_Internalname, "收缩压(mmHg)", "", "", lblTextblockbr_vital_systolic_Jsonclick, "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_BR_VitalGeneral.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-8", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtBR_Vital_Systolic_Internalname, "收缩压(mmHg)", "col-sm-3 ReadonlyAttributeLabel", 0, true);
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtBR_Vital_Systolic_Internalname, StringUtil.LTrim( StringUtil.NToC( A156BR_Vital_Systolic, 15, 5, ".", "")), ((edtBR_Vital_Systolic_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( A156BR_Vital_Systolic, "ZZZZZZZZZ.ZZZZZ")) : context.localUtil.Format( A156BR_Vital_Systolic, "ZZZZZZZZZ.ZZZZZ")), "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBR_Vital_Systolic_Jsonclick, 0, "ReadonlyAttribute", "", "", "", "", 1, edtBR_Vital_Systolic_Enabled, 0, "text", "", 15, "chr", 1, "row", 15, 0, 0, 0, 1, -1, 0, true, "DM_Numeric", "right", false, "HLP_BR_VitalGeneral.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divUnnamedtablebr_vital_diastolic_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-4 MergeLabelCell", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblockbr_vital_diastolic_Internalname, "舒张压(mmHg)", "", "", lblTextblockbr_vital_diastolic_Jsonclick, "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_BR_VitalGeneral.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-8", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtBR_Vital_Diastolic_Internalname, "舒张压(mmHg)", "col-sm-3 ReadonlyAttributeLabel", 0, true);
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtBR_Vital_Diastolic_Internalname, StringUtil.LTrim( StringUtil.NToC( A157BR_Vital_Diastolic, 15, 5, ".", "")), ((edtBR_Vital_Diastolic_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( A157BR_Vital_Diastolic, "ZZZZZZZZZ.ZZZZZ")) : context.localUtil.Format( A157BR_Vital_Diastolic, "ZZZZZZZZZ.ZZZZZ")), "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBR_Vital_Diastolic_Jsonclick, 0, "ReadonlyAttribute", "", "", "", "", 1, edtBR_Vital_Diastolic_Enabled, 0, "text", "", 15, "chr", 1, "row", 15, 0, 0, 0, 1, -1, 0, true, "DM_Numeric", "right", false, "HLP_BR_VitalGeneral.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
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
            GxWebStd.gx_div_start( context, divUnnamedtablebr_vital_height_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-4 MergeLabelCell", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblockbr_vital_height_Internalname, "身高(cm)", "", "", lblTextblockbr_vital_height_Jsonclick, "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_BR_VitalGeneral.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-8", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtBR_Vital_Height_Internalname, "身高(cm)", "col-sm-3 ReadonlyAttributeLabel", 0, true);
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtBR_Vital_Height_Internalname, StringUtil.LTrim( StringUtil.NToC( A158BR_Vital_Height, 15, 5, ".", "")), ((edtBR_Vital_Height_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( A158BR_Vital_Height, "ZZZZZZZZZ.ZZZZZ")) : context.localUtil.Format( A158BR_Vital_Height, "ZZZZZZZZZ.ZZZZZ")), "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBR_Vital_Height_Jsonclick, 0, "ReadonlyAttribute", "", "", "", "", 1, edtBR_Vital_Height_Enabled, 0, "text", "", 15, "chr", 1, "row", 15, 0, 0, 0, 1, -1, 0, true, "DM_Numeric", "right", false, "HLP_BR_VitalGeneral.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divUnnamedtablebr_vital_weight_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-4 MergeLabelCell", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblockbr_vital_weight_Internalname, "体重(kg)", "", "", lblTextblockbr_vital_weight_Jsonclick, "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_BR_VitalGeneral.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-8", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtBR_Vital_Weight_Internalname, "体重(kg)", "col-sm-3 ReadonlyAttributeLabel", 0, true);
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtBR_Vital_Weight_Internalname, StringUtil.LTrim( StringUtil.NToC( A159BR_Vital_Weight, 15, 5, ".", "")), ((edtBR_Vital_Weight_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( A159BR_Vital_Weight, "ZZZZZZZZZ.ZZZZZ")) : context.localUtil.Format( A159BR_Vital_Weight, "ZZZZZZZZZ.ZZZZZ")), "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBR_Vital_Weight_Jsonclick, 0, "ReadonlyAttribute", "", "", "", "", 1, edtBR_Vital_Weight_Enabled, 0, "text", "", 15, "chr", 1, "row", 15, 0, 0, 0, 1, -1, 0, true, "DM_Numeric", "right", false, "HLP_BR_VitalGeneral.htm");
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
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divHtml_bottomauxiliarcontrols_Internalname, 1, 0, "px", 0, "px", "Section", "left", "top", "", "", "div");
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtBR_VitalID_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A150BR_VitalID), 18, 0, ".", "")), context.localUtil.Format( (decimal)(A150BR_VitalID), "ZZZZZZZZZZZZZZZZZZ"), "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBR_VitalID_Jsonclick, 0, "Attribute", "", "", "", "", edtBR_VitalID_Visible, 0, 0, "number", "1", 18, "chr", 1, "row", 18, 0, 0, 0, 1, -1, 0, true, "ID", "right", false, "HLP_BR_VitalGeneral.htm");
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtBR_EncounterID_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A19BR_EncounterID), 18, 0, ".", "")), context.localUtil.Format( (decimal)(A19BR_EncounterID), "ZZZZZZZZZZZZZZZZZZ"), "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBR_EncounterID_Jsonclick, 0, "Attribute", "", "", "", "", edtBR_EncounterID_Visible, 0, 0, "number", "1", 18, "chr", 1, "row", 18, 0, 0, 0, 1, -1, 0, true, "ID", "right", false, "HLP_BR_VitalGeneral.htm");
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtBR_Information_PatientNo_Internalname, A36BR_Information_PatientNo, StringUtil.RTrim( context.localUtil.Format( A36BR_Information_PatientNo, "")), "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBR_Information_PatientNo_Jsonclick, 0, "Attribute", "", "", "", "", edtBR_Information_PatientNo_Visible, 0, 0, "text", "", 80, "chr", 1, "row", 2000, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_BR_VitalGeneral.htm");
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtBR_Vital_VitalID_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A151BR_Vital_VitalID), 10, 0, ".", "")), context.localUtil.Format( (decimal)(A151BR_Vital_VitalID), "ZZZZZZZZZZ"), "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBR_Vital_VitalID_Jsonclick, 0, "Attribute", "", "", "", "", edtBR_Vital_VitalID_Visible, 0, 0, "number", "1", 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_BR_VitalGeneral.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
         }
         wbLoad = true;
      }

      protected void START5Z2( )
      {
         wbLoad = false;
         wbEnd = 0;
         wbStart = 0;
         if ( StringUtil.Len( sPrefix) == 0 )
         {
            if ( ! context.isSpaRequest( ) )
            {
               Form.Meta.addItem("generator", "GeneXus C# 16_0_0-127771", 0) ;
               Form.Meta.addItem("description", "BR_Vital General", 0) ;
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
               STRUP5Z0( ) ;
            }
         }
      }

      protected void WS5Z2( )
      {
         START5Z2( ) ;
         EVT5Z2( ) ;
      }

      protected void EVT5Z2( )
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
                                 STRUP5Z0( ) ;
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
                                 STRUP5Z0( ) ;
                              }
                              if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
                              {
                                 context.wbHandled = 1;
                                 if ( ! wbErr )
                                 {
                                    dynload_actions( ) ;
                                    /* Execute user event: Start */
                                    E115Z2 ();
                                 }
                              }
                           }
                           else if ( StringUtil.StrCmp(sEvt, "LOAD") == 0 )
                           {
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP5Z0( ) ;
                              }
                              if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
                              {
                                 context.wbHandled = 1;
                                 if ( ! wbErr )
                                 {
                                    dynload_actions( ) ;
                                    /* Execute user event: Load */
                                    E125Z2 ();
                                 }
                              }
                           }
                           else if ( StringUtil.StrCmp(sEvt, "ENTER") == 0 )
                           {
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP5Z0( ) ;
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
                                 STRUP5Z0( ) ;
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

      protected void WE5Z2( )
      {
         if ( ! GxWebStd.gx_redirect( context) )
         {
            Rfr0gs = true;
            Refresh( ) ;
            if ( ! GxWebStd.gx_redirect( context) )
            {
               RenderHtmlCloseForm5Z2( ) ;
            }
         }
      }

      protected void PA5Z2( )
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
      }

      public void Refresh( )
      {
         send_integrity_hashes( ) ;
         RF5Z2( ) ;
         if ( isFullAjaxMode( ) )
         {
            send_integrity_footer_hashes( ) ;
         }
      }

      protected void initialize_formulas( )
      {
         /* GeneXus formulas. */
         AV15Pgmname = "BR_VitalGeneral";
         context.Gx_err = 0;
      }

      protected void RF5Z2( )
      {
         initialize_formulas( ) ;
         clear_multi_value_controls( ) ;
         gxdyncontrolsrefreshing = true;
         fix_multi_value_controls( ) ;
         gxdyncontrolsrefreshing = false;
         if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
         {
            /* Using cursor H005Z2 */
            pr_default.execute(0, new Object[] {A150BR_VitalID});
            while ( (pr_default.getStatus(0) != 101) )
            {
               A85BR_Information_ID = H005Z2_A85BR_Information_ID[0];
               n85BR_Information_ID = H005Z2_n85BR_Information_ID[0];
               A151BR_Vital_VitalID = H005Z2_A151BR_Vital_VitalID[0];
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A151BR_Vital_VitalID", StringUtil.LTrim( StringUtil.Str( (decimal)(A151BR_Vital_VitalID), 10, 0)));
               n151BR_Vital_VitalID = H005Z2_n151BR_Vital_VitalID[0];
               A36BR_Information_PatientNo = H005Z2_A36BR_Information_PatientNo[0];
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A36BR_Information_PatientNo", A36BR_Information_PatientNo);
               n36BR_Information_PatientNo = H005Z2_n36BR_Information_PatientNo[0];
               A19BR_EncounterID = H005Z2_A19BR_EncounterID[0];
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A19BR_EncounterID", StringUtil.LTrim( StringUtil.Str( (decimal)(A19BR_EncounterID), 18, 0)));
               A159BR_Vital_Weight = H005Z2_A159BR_Vital_Weight[0];
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A159BR_Vital_Weight", StringUtil.LTrim( StringUtil.Str( A159BR_Vital_Weight, 15, 5)));
               n159BR_Vital_Weight = H005Z2_n159BR_Vital_Weight[0];
               A158BR_Vital_Height = H005Z2_A158BR_Vital_Height[0];
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A158BR_Vital_Height", StringUtil.LTrim( StringUtil.Str( A158BR_Vital_Height, 15, 5)));
               n158BR_Vital_Height = H005Z2_n158BR_Vital_Height[0];
               A157BR_Vital_Diastolic = H005Z2_A157BR_Vital_Diastolic[0];
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A157BR_Vital_Diastolic", StringUtil.LTrim( StringUtil.Str( A157BR_Vital_Diastolic, 15, 5)));
               n157BR_Vital_Diastolic = H005Z2_n157BR_Vital_Diastolic[0];
               A156BR_Vital_Systolic = H005Z2_A156BR_Vital_Systolic[0];
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A156BR_Vital_Systolic", StringUtil.LTrim( StringUtil.Str( A156BR_Vital_Systolic, 15, 5)));
               n156BR_Vital_Systolic = H005Z2_n156BR_Vital_Systolic[0];
               A155BR_Vital_Respiration = H005Z2_A155BR_Vital_Respiration[0];
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A155BR_Vital_Respiration", StringUtil.LTrim( StringUtil.Str( A155BR_Vital_Respiration, 15, 5)));
               n155BR_Vital_Respiration = H005Z2_n155BR_Vital_Respiration[0];
               A154BR_Vital_Pulse = H005Z2_A154BR_Vital_Pulse[0];
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A154BR_Vital_Pulse", StringUtil.LTrim( StringUtil.Str( A154BR_Vital_Pulse, 15, 5)));
               n154BR_Vital_Pulse = H005Z2_n154BR_Vital_Pulse[0];
               A153BR_Vital_Temperature = H005Z2_A153BR_Vital_Temperature[0];
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A153BR_Vital_Temperature", StringUtil.LTrim( StringUtil.Str( A153BR_Vital_Temperature, 15, 5)));
               n153BR_Vital_Temperature = H005Z2_n153BR_Vital_Temperature[0];
               A152BR_Vital_MeasureDate = H005Z2_A152BR_Vital_MeasureDate[0];
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A152BR_Vital_MeasureDate", context.localUtil.Format(A152BR_Vital_MeasureDate, "9999/99/99"));
               n152BR_Vital_MeasureDate = H005Z2_n152BR_Vital_MeasureDate[0];
               A85BR_Information_ID = H005Z2_A85BR_Information_ID[0];
               n85BR_Information_ID = H005Z2_n85BR_Information_ID[0];
               A36BR_Information_PatientNo = H005Z2_A36BR_Information_PatientNo[0];
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A36BR_Information_PatientNo", A36BR_Information_PatientNo);
               n36BR_Information_PatientNo = H005Z2_n36BR_Information_PatientNo[0];
               /* Execute user event: Load */
               E125Z2 ();
               /* Exiting from a For First loop. */
               if (true) break;
            }
            pr_default.close(0);
            WB5Z0( ) ;
         }
      }

      protected void send_integrity_lvl_hashes5Z2( )
      {
      }

      protected void STRUP5Z0( )
      {
         /* Before Start, stand alone formulas. */
         AV15Pgmname = "BR_VitalGeneral";
         context.Gx_err = 0;
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0;
         /* Execute user event: Start */
         E115Z2 ();
         context.wbGlbDoneStart = 1;
         nDoneStart = 1;
         /* After Start, stand alone formulas. */
         sXEvt = cgiGet( "_EventName");
         if ( ! GetJustCreated( ) && ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 ) )
         {
            /* Read saved SDTs. */
            /* Read variables values. */
            A152BR_Vital_MeasureDate = context.localUtil.CToD( cgiGet( edtBR_Vital_MeasureDate_Internalname), 0);
            n152BR_Vital_MeasureDate = false;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A152BR_Vital_MeasureDate", context.localUtil.Format(A152BR_Vital_MeasureDate, "9999/99/99"));
            A153BR_Vital_Temperature = context.localUtil.CToN( cgiGet( edtBR_Vital_Temperature_Internalname), ".", ",");
            n153BR_Vital_Temperature = false;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A153BR_Vital_Temperature", StringUtil.LTrim( StringUtil.Str( A153BR_Vital_Temperature, 15, 5)));
            A154BR_Vital_Pulse = context.localUtil.CToN( cgiGet( edtBR_Vital_Pulse_Internalname), ".", ",");
            n154BR_Vital_Pulse = false;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A154BR_Vital_Pulse", StringUtil.LTrim( StringUtil.Str( A154BR_Vital_Pulse, 15, 5)));
            A155BR_Vital_Respiration = context.localUtil.CToN( cgiGet( edtBR_Vital_Respiration_Internalname), ".", ",");
            n155BR_Vital_Respiration = false;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A155BR_Vital_Respiration", StringUtil.LTrim( StringUtil.Str( A155BR_Vital_Respiration, 15, 5)));
            A156BR_Vital_Systolic = context.localUtil.CToN( cgiGet( edtBR_Vital_Systolic_Internalname), ".", ",");
            n156BR_Vital_Systolic = false;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A156BR_Vital_Systolic", StringUtil.LTrim( StringUtil.Str( A156BR_Vital_Systolic, 15, 5)));
            A157BR_Vital_Diastolic = context.localUtil.CToN( cgiGet( edtBR_Vital_Diastolic_Internalname), ".", ",");
            n157BR_Vital_Diastolic = false;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A157BR_Vital_Diastolic", StringUtil.LTrim( StringUtil.Str( A157BR_Vital_Diastolic, 15, 5)));
            A158BR_Vital_Height = context.localUtil.CToN( cgiGet( edtBR_Vital_Height_Internalname), ".", ",");
            n158BR_Vital_Height = false;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A158BR_Vital_Height", StringUtil.LTrim( StringUtil.Str( A158BR_Vital_Height, 15, 5)));
            A159BR_Vital_Weight = context.localUtil.CToN( cgiGet( edtBR_Vital_Weight_Internalname), ".", ",");
            n159BR_Vital_Weight = false;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A159BR_Vital_Weight", StringUtil.LTrim( StringUtil.Str( A159BR_Vital_Weight, 15, 5)));
            A19BR_EncounterID = (long)(context.localUtil.CToN( cgiGet( edtBR_EncounterID_Internalname), ".", ","));
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A19BR_EncounterID", StringUtil.LTrim( StringUtil.Str( (decimal)(A19BR_EncounterID), 18, 0)));
            A36BR_Information_PatientNo = cgiGet( edtBR_Information_PatientNo_Internalname);
            n36BR_Information_PatientNo = false;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A36BR_Information_PatientNo", A36BR_Information_PatientNo);
            A151BR_Vital_VitalID = (long)(context.localUtil.CToN( cgiGet( edtBR_Vital_VitalID_Internalname), ".", ","));
            n151BR_Vital_VitalID = false;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A151BR_Vital_VitalID", StringUtil.LTrim( StringUtil.Str( (decimal)(A151BR_Vital_VitalID), 10, 0)));
            /* Read saved values. */
            wcpOA150BR_VitalID = (long)(context.localUtil.CToN( cgiGet( sPrefix+"wcpOA150BR_VitalID"), ".", ","));
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
         E115Z2 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E115Z2( )
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

      protected void E125Z2( )
      {
         /* Load Routine */
         edtBR_VitalID_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtBR_VitalID_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBR_VitalID_Visible), 5, 0)), true);
         edtBR_EncounterID_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtBR_EncounterID_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBR_EncounterID_Visible), 5, 0)), true);
         edtBR_Information_PatientNo_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtBR_Information_PatientNo_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBR_Information_PatientNo_Visible), 5, 0)), true);
         edtBR_Vital_VitalID_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtBR_Vital_VitalID_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBR_Vital_VitalID_Visible), 5, 0)), true);
      }

      protected void S112( )
      {
         /* 'PREPARETRANSACTION' Routine */
         AV9TrnContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext(context);
         AV9TrnContext.gxTpr_Callerobject = AV15Pgmname;
         AV9TrnContext.gxTpr_Callerondelete = false;
         AV9TrnContext.gxTpr_Callerurl = AV12HTTPRequest.ScriptName+"?"+AV12HTTPRequest.QueryString;
         AV9TrnContext.gxTpr_Transactionname = "BR_Vital";
         AV10TrnContextAtt = new GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext_Attribute(context);
         AV10TrnContextAtt.gxTpr_Attributename = "BR_VitalID";
         AV10TrnContextAtt.gxTpr_Attributevalue = StringUtil.Str( (decimal)(AV8BR_VitalID), 18, 0);
         AV9TrnContext.gxTpr_Attributes.Add(AV10TrnContextAtt, 0);
         AV11Session.Set("TrnContext", AV9TrnContext.ToXml(false, true, "WWPTransactionContext", "DataAnalysisPlatform"));
      }

      public override void setparameters( Object[] obj )
      {
         createObjects();
         initialize();
         A150BR_VitalID = Convert.ToInt64(getParm(obj,0));
         context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A150BR_VitalID", StringUtil.LTrim( StringUtil.Str( (decimal)(A150BR_VitalID), 18, 0)));
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
         PA5Z2( ) ;
         WS5Z2( ) ;
         WE5Z2( ) ;
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
         sCtrlA150BR_VitalID = (String)((String)getParm(obj,0));
      }

      public override void componentrestorestate( String sPPrefix ,
                                                  String sPSFPrefix )
      {
         sPrefix = sPPrefix + sPSFPrefix;
         PA5Z2( ) ;
         WCParametersGet( ) ;
      }

      public override void componentprepare( Object[] obj )
      {
         wbLoad = false;
         sCompPrefix = (String)getParm(obj,0);
         sSFPrefix = (String)getParm(obj,1);
         sPrefix = sCompPrefix + sSFPrefix;
         AddComponentObject(sPrefix, "br_vitalgeneral", GetJustCreated( ));
         if ( ( nDoneStart == 0 ) && ( nDynComponent == 0 ) )
         {
            INITWEB( ) ;
         }
         else
         {
            init_default_properties( ) ;
            init_web_controls( ) ;
         }
         PA5Z2( ) ;
         if ( ! GetJustCreated( ) && ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 ) && ( context.wbGlbDoneStart == 0 ) )
         {
            WCParametersGet( ) ;
         }
         else
         {
            A150BR_VitalID = Convert.ToInt64(getParm(obj,2));
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A150BR_VitalID", StringUtil.LTrim( StringUtil.Str( (decimal)(A150BR_VitalID), 18, 0)));
         }
         wcpOA150BR_VitalID = (long)(context.localUtil.CToN( cgiGet( sPrefix+"wcpOA150BR_VitalID"), ".", ","));
         if ( ! GetJustCreated( ) && ( ( A150BR_VitalID != wcpOA150BR_VitalID ) ) )
         {
            setjustcreated();
         }
         wcpOA150BR_VitalID = A150BR_VitalID;
      }

      protected void WCParametersGet( )
      {
         /* Read Component Parameters. */
         sCtrlA150BR_VitalID = cgiGet( sPrefix+"A150BR_VitalID_CTRL");
         if ( StringUtil.Len( sCtrlA150BR_VitalID) > 0 )
         {
            A150BR_VitalID = (long)(context.localUtil.CToN( cgiGet( sCtrlA150BR_VitalID), ".", ","));
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A150BR_VitalID", StringUtil.LTrim( StringUtil.Str( (decimal)(A150BR_VitalID), 18, 0)));
         }
         else
         {
            A150BR_VitalID = (long)(context.localUtil.CToN( cgiGet( sPrefix+"A150BR_VitalID_PARM"), ".", ","));
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
         PA5Z2( ) ;
         sEvt = sCompEvt;
         WCParametersGet( ) ;
         WS5Z2( ) ;
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
         WS5Z2( ) ;
         SaveComponentMsgList(sPrefix);
         context.GX_msglist = BackMsgLst;
      }

      protected void WCParametersSet( )
      {
         GxWebStd.gx_hidden_field( context, sPrefix+"A150BR_VitalID_PARM", StringUtil.LTrim( StringUtil.NToC( (decimal)(A150BR_VitalID), 18, 0, ".", "")));
         if ( StringUtil.Len( StringUtil.RTrim( sCtrlA150BR_VitalID)) > 0 )
         {
            GxWebStd.gx_hidden_field( context, sPrefix+"A150BR_VitalID_CTRL", StringUtil.RTrim( sCtrlA150BR_VitalID));
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
         WE5Z2( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?202022711535980", true);
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
            context.AddJavascriptSource("br_vitalgeneral.js", "?202022711535980", false);
         }
         /* End function include_jscripts */
      }

      protected void init_web_controls( )
      {
         /* End function init_web_controls */
      }

      protected void init_default_properties( )
      {
         lblTextblockbr_vital_measuredate_Internalname = sPrefix+"TEXTBLOCKBR_VITAL_MEASUREDATE";
         edtBR_Vital_MeasureDate_Internalname = sPrefix+"BR_VITAL_MEASUREDATE";
         divUnnamedtablebr_vital_measuredate_Internalname = sPrefix+"UNNAMEDTABLEBR_VITAL_MEASUREDATE";
         lblTextblockbr_vital_temperature_Internalname = sPrefix+"TEXTBLOCKBR_VITAL_TEMPERATURE";
         edtBR_Vital_Temperature_Internalname = sPrefix+"BR_VITAL_TEMPERATURE";
         divUnnamedtablebr_vital_temperature_Internalname = sPrefix+"UNNAMEDTABLEBR_VITAL_TEMPERATURE";
         lblTextblockbr_vital_pulse_Internalname = sPrefix+"TEXTBLOCKBR_VITAL_PULSE";
         edtBR_Vital_Pulse_Internalname = sPrefix+"BR_VITAL_PULSE";
         divUnnamedtablebr_vital_pulse_Internalname = sPrefix+"UNNAMEDTABLEBR_VITAL_PULSE";
         lblTextblockbr_vital_respiration_Internalname = sPrefix+"TEXTBLOCKBR_VITAL_RESPIRATION";
         edtBR_Vital_Respiration_Internalname = sPrefix+"BR_VITAL_RESPIRATION";
         divUnnamedtablebr_vital_respiration_Internalname = sPrefix+"UNNAMEDTABLEBR_VITAL_RESPIRATION";
         lblTextblockbr_vital_systolic_Internalname = sPrefix+"TEXTBLOCKBR_VITAL_SYSTOLIC";
         edtBR_Vital_Systolic_Internalname = sPrefix+"BR_VITAL_SYSTOLIC";
         divUnnamedtablebr_vital_systolic_Internalname = sPrefix+"UNNAMEDTABLEBR_VITAL_SYSTOLIC";
         lblTextblockbr_vital_diastolic_Internalname = sPrefix+"TEXTBLOCKBR_VITAL_DIASTOLIC";
         edtBR_Vital_Diastolic_Internalname = sPrefix+"BR_VITAL_DIASTOLIC";
         divUnnamedtablebr_vital_diastolic_Internalname = sPrefix+"UNNAMEDTABLEBR_VITAL_DIASTOLIC";
         lblTextblockbr_vital_height_Internalname = sPrefix+"TEXTBLOCKBR_VITAL_HEIGHT";
         edtBR_Vital_Height_Internalname = sPrefix+"BR_VITAL_HEIGHT";
         divUnnamedtablebr_vital_height_Internalname = sPrefix+"UNNAMEDTABLEBR_VITAL_HEIGHT";
         lblTextblockbr_vital_weight_Internalname = sPrefix+"TEXTBLOCKBR_VITAL_WEIGHT";
         edtBR_Vital_Weight_Internalname = sPrefix+"BR_VITAL_WEIGHT";
         divUnnamedtablebr_vital_weight_Internalname = sPrefix+"UNNAMEDTABLEBR_VITAL_WEIGHT";
         divTransactiondetail_tableattributes_Internalname = sPrefix+"TRANSACTIONDETAIL_TABLEATTRIBUTES";
         divTable_Internalname = sPrefix+"TABLE";
         edtBR_VitalID_Internalname = sPrefix+"BR_VITALID";
         edtBR_EncounterID_Internalname = sPrefix+"BR_ENCOUNTERID";
         edtBR_Information_PatientNo_Internalname = sPrefix+"BR_INFORMATION_PATIENTNO";
         edtBR_Vital_VitalID_Internalname = sPrefix+"BR_VITAL_VITALID";
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
         edtBR_Vital_VitalID_Jsonclick = "";
         edtBR_Vital_VitalID_Visible = 1;
         edtBR_Information_PatientNo_Jsonclick = "";
         edtBR_Information_PatientNo_Visible = 1;
         edtBR_EncounterID_Jsonclick = "";
         edtBR_EncounterID_Visible = 1;
         edtBR_VitalID_Jsonclick = "";
         edtBR_VitalID_Visible = 1;
         edtBR_Vital_Weight_Jsonclick = "";
         edtBR_Vital_Weight_Enabled = 0;
         edtBR_Vital_Height_Jsonclick = "";
         edtBR_Vital_Height_Enabled = 0;
         edtBR_Vital_Diastolic_Jsonclick = "";
         edtBR_Vital_Diastolic_Enabled = 0;
         edtBR_Vital_Systolic_Jsonclick = "";
         edtBR_Vital_Systolic_Enabled = 0;
         edtBR_Vital_Respiration_Jsonclick = "";
         edtBR_Vital_Respiration_Enabled = 0;
         edtBR_Vital_Pulse_Jsonclick = "";
         edtBR_Vital_Pulse_Enabled = 0;
         edtBR_Vital_Temperature_Jsonclick = "";
         edtBR_Vital_Temperature_Enabled = 0;
         edtBR_Vital_MeasureDate_Jsonclick = "";
         edtBR_Vital_MeasureDate_Enabled = 0;
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
         AV15Pgmname = "";
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         GXKey = "";
         GX_FocusControl = "";
         lblTextblockbr_vital_measuredate_Jsonclick = "";
         A152BR_Vital_MeasureDate = DateTime.MinValue;
         lblTextblockbr_vital_temperature_Jsonclick = "";
         lblTextblockbr_vital_pulse_Jsonclick = "";
         lblTextblockbr_vital_respiration_Jsonclick = "";
         lblTextblockbr_vital_systolic_Jsonclick = "";
         lblTextblockbr_vital_diastolic_Jsonclick = "";
         lblTextblockbr_vital_height_Jsonclick = "";
         lblTextblockbr_vital_weight_Jsonclick = "";
         A36BR_Information_PatientNo = "";
         Form = new GXWebForm();
         sXEvt = "";
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         scmdbuf = "";
         H005Z2_A85BR_Information_ID = new long[1] ;
         H005Z2_n85BR_Information_ID = new bool[] {false} ;
         H005Z2_A150BR_VitalID = new long[1] ;
         H005Z2_A151BR_Vital_VitalID = new long[1] ;
         H005Z2_n151BR_Vital_VitalID = new bool[] {false} ;
         H005Z2_A36BR_Information_PatientNo = new String[] {""} ;
         H005Z2_n36BR_Information_PatientNo = new bool[] {false} ;
         H005Z2_A19BR_EncounterID = new long[1] ;
         H005Z2_A159BR_Vital_Weight = new decimal[1] ;
         H005Z2_n159BR_Vital_Weight = new bool[] {false} ;
         H005Z2_A158BR_Vital_Height = new decimal[1] ;
         H005Z2_n158BR_Vital_Height = new bool[] {false} ;
         H005Z2_A157BR_Vital_Diastolic = new decimal[1] ;
         H005Z2_n157BR_Vital_Diastolic = new bool[] {false} ;
         H005Z2_A156BR_Vital_Systolic = new decimal[1] ;
         H005Z2_n156BR_Vital_Systolic = new bool[] {false} ;
         H005Z2_A155BR_Vital_Respiration = new decimal[1] ;
         H005Z2_n155BR_Vital_Respiration = new bool[] {false} ;
         H005Z2_A154BR_Vital_Pulse = new decimal[1] ;
         H005Z2_n154BR_Vital_Pulse = new bool[] {false} ;
         H005Z2_A153BR_Vital_Temperature = new decimal[1] ;
         H005Z2_n153BR_Vital_Temperature = new bool[] {false} ;
         H005Z2_A152BR_Vital_MeasureDate = new DateTime[] {DateTime.MinValue} ;
         H005Z2_n152BR_Vital_MeasureDate = new bool[] {false} ;
         AV6WWPContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPContext(context);
         AV9TrnContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext(context);
         AV12HTTPRequest = new GxHttpRequest( context);
         AV10TrnContextAtt = new GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext_Attribute(context);
         AV11Session = context.GetSession();
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         sCtrlA150BR_VitalID = "";
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.br_vitalgeneral__default(),
            new Object[][] {
                new Object[] {
               H005Z2_A85BR_Information_ID, H005Z2_n85BR_Information_ID, H005Z2_A150BR_VitalID, H005Z2_A151BR_Vital_VitalID, H005Z2_n151BR_Vital_VitalID, H005Z2_A36BR_Information_PatientNo, H005Z2_n36BR_Information_PatientNo, H005Z2_A19BR_EncounterID, H005Z2_A159BR_Vital_Weight, H005Z2_n159BR_Vital_Weight,
               H005Z2_A158BR_Vital_Height, H005Z2_n158BR_Vital_Height, H005Z2_A157BR_Vital_Diastolic, H005Z2_n157BR_Vital_Diastolic, H005Z2_A156BR_Vital_Systolic, H005Z2_n156BR_Vital_Systolic, H005Z2_A155BR_Vital_Respiration, H005Z2_n155BR_Vital_Respiration, H005Z2_A154BR_Vital_Pulse, H005Z2_n154BR_Vital_Pulse,
               H005Z2_A153BR_Vital_Temperature, H005Z2_n153BR_Vital_Temperature, H005Z2_A152BR_Vital_MeasureDate, H005Z2_n152BR_Vital_MeasureDate
               }
            }
         );
         AV15Pgmname = "BR_VitalGeneral";
         /* GeneXus formulas. */
         AV15Pgmname = "BR_VitalGeneral";
         context.Gx_err = 0;
      }

      private short nGotPars ;
      private short GxWebError ;
      private short nDynComponent ;
      private short initialized ;
      private short nGXWrapped ;
      private short wbEnd ;
      private short wbStart ;
      private short nDraw ;
      private short nDoneStart ;
      private short nDonePA ;
      private short gxcookieaux ;
      private int edtBR_Vital_MeasureDate_Enabled ;
      private int edtBR_Vital_Temperature_Enabled ;
      private int edtBR_Vital_Pulse_Enabled ;
      private int edtBR_Vital_Respiration_Enabled ;
      private int edtBR_Vital_Systolic_Enabled ;
      private int edtBR_Vital_Diastolic_Enabled ;
      private int edtBR_Vital_Height_Enabled ;
      private int edtBR_Vital_Weight_Enabled ;
      private int edtBR_VitalID_Visible ;
      private int edtBR_EncounterID_Visible ;
      private int edtBR_Information_PatientNo_Visible ;
      private int edtBR_Vital_VitalID_Visible ;
      private int idxLst ;
      private long A150BR_VitalID ;
      private long wcpOA150BR_VitalID ;
      private long A19BR_EncounterID ;
      private long A151BR_Vital_VitalID ;
      private long A85BR_Information_ID ;
      private long AV8BR_VitalID ;
      private decimal A153BR_Vital_Temperature ;
      private decimal A154BR_Vital_Pulse ;
      private decimal A155BR_Vital_Respiration ;
      private decimal A156BR_Vital_Systolic ;
      private decimal A157BR_Vital_Diastolic ;
      private decimal A158BR_Vital_Height ;
      private decimal A159BR_Vital_Weight ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String sPrefix ;
      private String sCompPrefix ;
      private String sSFPrefix ;
      private String AV15Pgmname ;
      private String sDynURL ;
      private String FormProcess ;
      private String bodyStyle ;
      private String GXKey ;
      private String GX_FocusControl ;
      private String divLayoutmaintable_Internalname ;
      private String divTable_Internalname ;
      private String divTransactiondetail_tableattributes_Internalname ;
      private String divUnnamedtablebr_vital_measuredate_Internalname ;
      private String lblTextblockbr_vital_measuredate_Internalname ;
      private String lblTextblockbr_vital_measuredate_Jsonclick ;
      private String edtBR_Vital_MeasureDate_Internalname ;
      private String edtBR_Vital_MeasureDate_Jsonclick ;
      private String divUnnamedtablebr_vital_temperature_Internalname ;
      private String lblTextblockbr_vital_temperature_Internalname ;
      private String lblTextblockbr_vital_temperature_Jsonclick ;
      private String edtBR_Vital_Temperature_Internalname ;
      private String edtBR_Vital_Temperature_Jsonclick ;
      private String divUnnamedtablebr_vital_pulse_Internalname ;
      private String lblTextblockbr_vital_pulse_Internalname ;
      private String lblTextblockbr_vital_pulse_Jsonclick ;
      private String edtBR_Vital_Pulse_Internalname ;
      private String edtBR_Vital_Pulse_Jsonclick ;
      private String divUnnamedtablebr_vital_respiration_Internalname ;
      private String lblTextblockbr_vital_respiration_Internalname ;
      private String lblTextblockbr_vital_respiration_Jsonclick ;
      private String edtBR_Vital_Respiration_Internalname ;
      private String edtBR_Vital_Respiration_Jsonclick ;
      private String divUnnamedtablebr_vital_systolic_Internalname ;
      private String lblTextblockbr_vital_systolic_Internalname ;
      private String lblTextblockbr_vital_systolic_Jsonclick ;
      private String edtBR_Vital_Systolic_Internalname ;
      private String edtBR_Vital_Systolic_Jsonclick ;
      private String divUnnamedtablebr_vital_diastolic_Internalname ;
      private String lblTextblockbr_vital_diastolic_Internalname ;
      private String lblTextblockbr_vital_diastolic_Jsonclick ;
      private String edtBR_Vital_Diastolic_Internalname ;
      private String edtBR_Vital_Diastolic_Jsonclick ;
      private String divUnnamedtablebr_vital_height_Internalname ;
      private String lblTextblockbr_vital_height_Internalname ;
      private String lblTextblockbr_vital_height_Jsonclick ;
      private String edtBR_Vital_Height_Internalname ;
      private String edtBR_Vital_Height_Jsonclick ;
      private String divUnnamedtablebr_vital_weight_Internalname ;
      private String lblTextblockbr_vital_weight_Internalname ;
      private String lblTextblockbr_vital_weight_Jsonclick ;
      private String edtBR_Vital_Weight_Internalname ;
      private String edtBR_Vital_Weight_Jsonclick ;
      private String divHtml_bottomauxiliarcontrols_Internalname ;
      private String edtBR_VitalID_Internalname ;
      private String edtBR_VitalID_Jsonclick ;
      private String edtBR_EncounterID_Internalname ;
      private String edtBR_EncounterID_Jsonclick ;
      private String edtBR_Information_PatientNo_Internalname ;
      private String edtBR_Information_PatientNo_Jsonclick ;
      private String edtBR_Vital_VitalID_Internalname ;
      private String edtBR_Vital_VitalID_Jsonclick ;
      private String sXEvt ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String scmdbuf ;
      private String sCtrlA150BR_VitalID ;
      private DateTime A152BR_Vital_MeasureDate ;
      private bool entryPointCalled ;
      private bool toggleJsOutput ;
      private bool wbLoad ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool gxdyncontrolsrefreshing ;
      private bool n85BR_Information_ID ;
      private bool n151BR_Vital_VitalID ;
      private bool n36BR_Information_PatientNo ;
      private bool n159BR_Vital_Weight ;
      private bool n158BR_Vital_Height ;
      private bool n157BR_Vital_Diastolic ;
      private bool n156BR_Vital_Systolic ;
      private bool n155BR_Vital_Respiration ;
      private bool n154BR_Vital_Pulse ;
      private bool n153BR_Vital_Temperature ;
      private bool n152BR_Vital_MeasureDate ;
      private bool returnInSub ;
      private String A36BR_Information_PatientNo ;
      private GXWebForm Form ;
      private IGxDataStore dsDataStore1 ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private long[] H005Z2_A85BR_Information_ID ;
      private bool[] H005Z2_n85BR_Information_ID ;
      private long[] H005Z2_A150BR_VitalID ;
      private long[] H005Z2_A151BR_Vital_VitalID ;
      private bool[] H005Z2_n151BR_Vital_VitalID ;
      private String[] H005Z2_A36BR_Information_PatientNo ;
      private bool[] H005Z2_n36BR_Information_PatientNo ;
      private long[] H005Z2_A19BR_EncounterID ;
      private decimal[] H005Z2_A159BR_Vital_Weight ;
      private bool[] H005Z2_n159BR_Vital_Weight ;
      private decimal[] H005Z2_A158BR_Vital_Height ;
      private bool[] H005Z2_n158BR_Vital_Height ;
      private decimal[] H005Z2_A157BR_Vital_Diastolic ;
      private bool[] H005Z2_n157BR_Vital_Diastolic ;
      private decimal[] H005Z2_A156BR_Vital_Systolic ;
      private bool[] H005Z2_n156BR_Vital_Systolic ;
      private decimal[] H005Z2_A155BR_Vital_Respiration ;
      private bool[] H005Z2_n155BR_Vital_Respiration ;
      private decimal[] H005Z2_A154BR_Vital_Pulse ;
      private bool[] H005Z2_n154BR_Vital_Pulse ;
      private decimal[] H005Z2_A153BR_Vital_Temperature ;
      private bool[] H005Z2_n153BR_Vital_Temperature ;
      private DateTime[] H005Z2_A152BR_Vital_MeasureDate ;
      private bool[] H005Z2_n152BR_Vital_MeasureDate ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private GxHttpRequest AV12HTTPRequest ;
      private IGxSession AV11Session ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPContext AV6WWPContext ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext AV9TrnContext ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext_Attribute AV10TrnContextAtt ;
   }

   public class br_vitalgeneral__default : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmH005Z2 ;
          prmH005Z2 = new Object[] {
          new Object[] {"@BR_VitalID",SqlDbType.Decimal,18,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("H005Z2", "SELECT T2.[BR_Information_ID], T1.[BR_VitalID], T1.[BR_Vital_VitalID], T3.[BR_Information_PatientNo], T1.[BR_EncounterID], T1.[BR_Vital_Weight], T1.[BR_Vital_Height], T1.[BR_Vital_Diastolic], T1.[BR_Vital_Systolic], T1.[BR_Vital_Respiration], T1.[BR_Vital_Pulse], T1.[BR_Vital_Temperature], T1.[BR_Vital_MeasureDate] FROM (([BR_Vital] T1 WITH (NOLOCK) INNER JOIN [BR_Encounter] T2 WITH (NOLOCK) ON T2.[BR_EncounterID] = T1.[BR_EncounterID]) LEFT JOIN [BR_Information] T3 WITH (NOLOCK) ON T3.[BR_Information_ID] = T2.[BR_Information_ID]) WHERE T1.[BR_VitalID] = @BR_VitalID ORDER BY T1.[BR_VitalID] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH005Z2,1,0,true,true )
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
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                ((long[]) buf[2])[0] = rslt.getLong(2) ;
                ((long[]) buf[3])[0] = rslt.getLong(3) ;
                ((bool[]) buf[4])[0] = rslt.wasNull(3);
                ((String[]) buf[5])[0] = rslt.getVarchar(4) ;
                ((bool[]) buf[6])[0] = rslt.wasNull(4);
                ((long[]) buf[7])[0] = rslt.getLong(5) ;
                ((decimal[]) buf[8])[0] = rslt.getDecimal(6) ;
                ((bool[]) buf[9])[0] = rslt.wasNull(6);
                ((decimal[]) buf[10])[0] = rslt.getDecimal(7) ;
                ((bool[]) buf[11])[0] = rslt.wasNull(7);
                ((decimal[]) buf[12])[0] = rslt.getDecimal(8) ;
                ((bool[]) buf[13])[0] = rslt.wasNull(8);
                ((decimal[]) buf[14])[0] = rslt.getDecimal(9) ;
                ((bool[]) buf[15])[0] = rslt.wasNull(9);
                ((decimal[]) buf[16])[0] = rslt.getDecimal(10) ;
                ((bool[]) buf[17])[0] = rslt.wasNull(10);
                ((decimal[]) buf[18])[0] = rslt.getDecimal(11) ;
                ((bool[]) buf[19])[0] = rslt.wasNull(11);
                ((decimal[]) buf[20])[0] = rslt.getDecimal(12) ;
                ((bool[]) buf[21])[0] = rslt.wasNull(12);
                ((DateTime[]) buf[22])[0] = rslt.getGXDate(13) ;
                ((bool[]) buf[23])[0] = rslt.wasNull(13);
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
