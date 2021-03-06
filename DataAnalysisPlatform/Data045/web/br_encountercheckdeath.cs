/*
               File: BR_EncounterCheckDeath
        Description: Data Mgmt Portal - RAAP
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/28/2020 15:6:33.28
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
   public class br_encountercheckdeath : GXWebComponent, System.Web.SessionState.IRequiresSessionState
   {
      public br_encountercheckdeath( )
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

      public br_encountercheckdeath( IGxContext context )
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
         dynavBr_death_br_death_causecode = new GXCombobox();
         dynavBr_death_br_death_sourse = new GXCombobox();
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
               else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxCallCrl"+"_"+"BR_DEATH_BR_DEATH_CAUSECODE") == 0 )
               {
                  AV27Tcurrentcode = NumberUtil.Val( GetNextPar( ), ".");
                  setAjaxCallMode();
                  if ( ! IsValidAjaxCall( true) )
                  {
                     GxWebError = 1;
                     return  ;
                  }
                  GXDLVBR_DEATH_BR_DEATH_CAUSECODE3Z2( AV27Tcurrentcode) ;
                  return  ;
               }
               else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxCallCrl"+"_"+"BR_DEATH_BR_DEATH_SOURSE") == 0 )
               {
                  AV27Tcurrentcode = NumberUtil.Val( GetNextPar( ), ".");
                  setAjaxCallMode();
                  if ( ! IsValidAjaxCall( true) )
                  {
                     GxWebError = 1;
                     return  ;
                  }
                  GXDLVBR_DEATH_BR_DEATH_SOURSE3Z2( AV27Tcurrentcode) ;
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
            PA3Z2( ) ;
            if ( ( GxWebError == 0 ) && ! isAjaxCallMode( ) )
            {
               /* GeneXus formulas. */
               AV26Pgmname = "BR_EncounterCheckDeath";
               context.Gx_err = 0;
               edtavBr_death_br_death_date_Enabled = 0;
               context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavBr_death_br_death_date_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavBr_death_br_death_date_Enabled), 5, 0)), true);
               edtavBr_death_br_death_cause_Enabled = 0;
               context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavBr_death_br_death_cause_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavBr_death_br_death_cause_Enabled), 5, 0)), true);
               dynavBr_death_br_death_causecode.Enabled = 0;
               context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, dynavBr_death_br_death_causecode_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(dynavBr_death_br_death_causecode.Enabled), 5, 0)), true);
               dynavBr_death_br_death_sourse.Enabled = 0;
               context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, dynavBr_death_br_death_sourse_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(dynavBr_death_br_death_sourse.Enabled), 5, 0)), true);
               WS3Z2( ) ;
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
         context.AddJavascriptSource("gxcfg.js", "?20202281563334", false);
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
               context.WriteHtmlTextNl( "<form id=\"MAINFORM\" autocomplete=\"off\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("br_encountercheckdeath.aspx") + "?" + UrlEncode("" +A19BR_EncounterID)+"\">") ;
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
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, sPrefix+"Br_death", AV13BR_Death);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt(sPrefix+"Br_death", AV13BR_Death);
         }
         GxWebStd.gx_hidden_field( context, sPrefix+"wcpOA19BR_EncounterID", StringUtil.LTrim( StringUtil.NToC( (decimal)(wcpOA19BR_EncounterID), 18, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, sPrefix+"BR_ENCOUNTERID", StringUtil.LTrim( StringUtil.NToC( (decimal)(A19BR_EncounterID), 18, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, sPrefix+"vTCURRENTCODE", StringUtil.LTrim( StringUtil.NToC( AV27Tcurrentcode, 10, 2, ".", "")));
      }

      protected void RenderHtmlCloseForm3Z2( )
      {
         SendCloseFormHiddens( ) ;
         if ( ( StringUtil.Len( sPrefix) != 0 ) && ( context.isAjaxRequest( ) || context.isSpaRequest( ) ) )
         {
            context.AddJavascriptSource("br_encountercheckdeath.js", "?20202281563337", false);
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
         return "BR_EncounterCheckDeath" ;
      }

      public override String GetPgmdesc( )
      {
         return "Data Mgmt Portal - RAAP" ;
      }

      protected void WB3Z0( )
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
               GxWebStd.gx_hidden_field( context, sPrefix+"_CMPPGM", "br_encountercheckdeath.aspx");
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
            GxWebStd.gx_div_start( context, divUnnamedtable1_Internalname, 1, 0, "px", 0, "px", "", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-md-6 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divUnnamedtablebr_death_br_death_date_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-4 MergeLabelCell", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblockbr_death_br_death_date_Internalname, "死亡日期", "", "", lblTextblockbr_death_br_death_date_Jsonclick, "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_BR_EncounterCheckDeath.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-8", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavBr_death_br_death_date_Internalname, "死亡日期", "col-sm-3 ReadonlyAttributeLabel", 0, true);
            /* Single line edit */
            context.WriteHtmlText( "<div id=\""+edtavBr_death_br_death_date_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtavBr_death_br_death_date_Internalname, context.localUtil.Format(AV13BR_Death.gxTpr_Br_death_date, "9999/99/99"), context.localUtil.Format( AV13BR_Death.gxTpr_Br_death_date, "9999/99/99"), "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavBr_death_br_death_date_Jsonclick, 0, "ReadonlyAttribute", "", "", "", "", 1, edtavBr_death_br_death_date_Enabled, 0, "text", "", 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_BR_EncounterCheckDeath.htm");
            GxWebStd.gx_bitmap( context, edtavBr_death_br_death_date_Internalname+"_dp_trigger", context.GetImagePath( "61b9b5d3-dff6-4d59-9b00-da61bc2cbe93", "", context.GetTheme( )), "", "", "", "", ((1==0)||(edtavBr_death_br_death_date_Enabled==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;", "", "", "", "", "", "", "", "", 1, false, false, "", "HLP_BR_EncounterCheckDeath.htm");
            context.WriteHtmlTextNl( "</div>") ;
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-md-6 DataContentCellNoWrap", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divUnnamedtablebr_death_br_death_cause_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-4 MergeLabelCell", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblockbr_death_br_death_cause_Internalname, "死亡原因", "", "", lblTextblockbr_death_br_death_cause_Jsonclick, "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_BR_EncounterCheckDeath.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-8", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavBr_death_br_death_cause_Internalname, "死亡原因", "col-sm-3 AttributeReadGrayLabel", 0, true);
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtavBr_death_br_death_cause_Internalname, AV13BR_Death.gxTpr_Br_death_cause, StringUtil.RTrim( context.localUtil.Format( AV13BR_Death.gxTpr_Br_death_cause, "")), "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavBr_death_br_death_cause_Jsonclick, 0, "AttributeReadGray", "", "", "", "", 1, edtavBr_death_br_death_cause_Enabled, 0, "text", "", 40, "chr", 1, "row", 40, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_BR_EncounterCheckDeath.htm");
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
            GxWebStd.gx_div_start( context, divUnnamedtablebr_death_br_death_causecode_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-4 MergeLabelCell", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblockbr_death_br_death_causecode_Internalname, "死亡原因类型", "", "", lblTextblockbr_death_br_death_causecode_Jsonclick, "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_BR_EncounterCheckDeath.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-8", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, dynavBr_death_br_death_causecode_Internalname, "死亡原因类型", "col-sm-3 ReadonlyAttributeLabel", 0, true);
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, dynavBr_death_br_death_causecode, dynavBr_death_br_death_causecode_Internalname, StringUtil.RTrim( AV13BR_Death.gxTpr_Br_death_causecode), 1, dynavBr_death_br_death_causecode_Jsonclick, 0, "'"+sPrefix+"'"+",false,"+"'"+""+"'", "svchar", "", 1, dynavBr_death_br_death_causecode.Enabled, 0, 0, 0, "em", 0, "", "", "ReadonlyAttribute", "", "", "", "", true, "HLP_BR_EncounterCheckDeath.htm");
            dynavBr_death_br_death_causecode.CurrentValue = StringUtil.RTrim( AV13BR_Death.gxTpr_Br_death_causecode);
            context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, dynavBr_death_br_death_causecode_Internalname, "Values", (String)(dynavBr_death_br_death_causecode.ToJavascriptSource()), true);
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-md-6 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divUnnamedtablebr_death_br_death_sourse_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-4 MergeLabelCell", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblockbr_death_br_death_sourse_Internalname, "死亡信息来源", "", "", lblTextblockbr_death_br_death_sourse_Jsonclick, "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_BR_EncounterCheckDeath.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-8", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, dynavBr_death_br_death_sourse_Internalname, "死亡信息来源", "col-sm-3 ReadonlyAttributeLabel", 0, true);
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, dynavBr_death_br_death_sourse, dynavBr_death_br_death_sourse_Internalname, StringUtil.RTrim( AV13BR_Death.gxTpr_Br_death_sourse), 1, dynavBr_death_br_death_sourse_Jsonclick, 0, "'"+sPrefix+"'"+",false,"+"'"+""+"'", "svchar", "", 1, dynavBr_death_br_death_sourse.Enabled, 0, 0, 0, "em", 0, "", "", "ReadonlyAttribute", "", "", "", "", true, "HLP_BR_EncounterCheckDeath.htm");
            dynavBr_death_br_death_sourse.CurrentValue = StringUtil.RTrim( AV13BR_Death.gxTpr_Br_death_sourse);
            context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, dynavBr_death_br_death_sourse_Internalname, "Values", (String)(dynavBr_death_br_death_sourse.ToJavascriptSource()), true);
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
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 44,'" + sPrefix + "',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavBr_death_br_deathid_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV13BR_Death.gxTpr_Br_deathid), 18, 0, ".", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(AV13BR_Death.gxTpr_Br_deathid), "ZZZZZZZZZZZZZZZZZZ")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,44);\"", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavBr_death_br_deathid_Jsonclick, 0, "Attribute", "", "", "", "", edtavBr_death_br_deathid_Visible, 1, 0, "number", "1", 18, "chr", 1, "row", 18, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_BR_EncounterCheckDeath.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 45,'" + sPrefix + "',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavBr_death_br_encounterid_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV13BR_Death.gxTpr_Br_encounterid), 18, 0, ".", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(AV13BR_Death.gxTpr_Br_encounterid), "ZZZZZZZZZZZZZZZZZZ")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,45);\"", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavBr_death_br_encounterid_Jsonclick, 0, "Attribute", "", "", "", "", edtavBr_death_br_encounterid_Visible, 1, 0, "number", "1", 18, "chr", 1, "row", 18, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_BR_EncounterCheckDeath.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 46,'" + sPrefix + "',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavBr_death_br_information_patientno_Internalname, AV13BR_Death.gxTpr_Br_information_patientno, StringUtil.RTrim( context.localUtil.Format( AV13BR_Death.gxTpr_Br_information_patientno, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,46);\"", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavBr_death_br_information_patientno_Jsonclick, 0, "Attribute", "", "", "", "", edtavBr_death_br_information_patientno_Visible, 1, 0, "text", "", 80, "chr", 1, "row", 2000, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_BR_EncounterCheckDeath.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
         }
         wbLoad = true;
      }

      protected void START3Z2( )
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
               STRUP3Z0( ) ;
            }
         }
      }

      protected void WS3Z2( )
      {
         START3Z2( ) ;
         EVT3Z2( ) ;
      }

      protected void EVT3Z2( )
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
                                 STRUP3Z0( ) ;
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
                                 STRUP3Z0( ) ;
                              }
                              if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
                              {
                                 context.wbHandled = 1;
                                 if ( ! wbErr )
                                 {
                                    dynload_actions( ) ;
                                    /* Execute user event: Start */
                                    E113Z2 ();
                                 }
                              }
                           }
                           else if ( StringUtil.StrCmp(sEvt, "LOAD") == 0 )
                           {
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP3Z0( ) ;
                              }
                              if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
                              {
                                 context.wbHandled = 1;
                                 if ( ! wbErr )
                                 {
                                    dynload_actions( ) ;
                                    /* Execute user event: Load */
                                    E123Z2 ();
                                 }
                              }
                           }
                           else if ( StringUtil.StrCmp(sEvt, "ENTER") == 0 )
                           {
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP3Z0( ) ;
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
                                 STRUP3Z0( ) ;
                              }
                              if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
                              {
                                 context.wbHandled = 1;
                                 if ( ! wbErr )
                                 {
                                    dynload_actions( ) ;
                                    GX_FocusControl = edtavBr_death_br_death_date_Internalname;
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

      protected void WE3Z2( )
      {
         if ( ! GxWebStd.gx_redirect( context) )
         {
            Rfr0gs = true;
            Refresh( ) ;
            if ( ! GxWebStd.gx_redirect( context) )
            {
               RenderHtmlCloseForm3Z2( ) ;
            }
         }
      }

      protected void PA3Z2( )
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
               GX_FocusControl = edtavBr_death_br_death_date_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "GX_FocusControl", GX_FocusControl);
            }
            nDonePA = 1;
         }
      }

      protected void dynload_actions( )
      {
         /* End function dynload_actions */
      }

      protected void GXDLVBR_DEATH_BR_DEATH_CAUSECODE3Z2( decimal AV27Tcurrentcode )
      {
         if ( ! context.isAjaxRequest( ) )
         {
            context.GX_webresponse.AppendHeader("Cache-Control", "no-store");
         }
         context.GX_webresponse.AddString("[[");
         GXDLVBR_DEATH_BR_DEATH_CAUSECODE_data3Z2( AV27Tcurrentcode) ;
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

      protected void GXVBR_DEATH_BR_DEATH_CAUSECODE_html3Z2( decimal AV27Tcurrentcode )
      {
         String gxdynajaxvalue ;
         GXDLVBR_DEATH_BR_DEATH_CAUSECODE_data3Z2( AV27Tcurrentcode) ;
         gxdynajaxindex = 1;
         if ( ! ( gxdyncontrolsrefreshing && context.isAjaxRequest( ) ) )
         {
            dynavBr_death_br_death_causecode.removeAllItems();
         }
         while ( gxdynajaxindex <= gxdynajaxctrlcodr.Count )
         {
            gxdynajaxvalue = ((String)gxdynajaxctrlcodr.Item(gxdynajaxindex));
            dynavBr_death_br_death_causecode.addItem(gxdynajaxvalue, ((String)gxdynajaxctrldescr.Item(gxdynajaxindex)), 0);
            gxdynajaxindex = (int)(gxdynajaxindex+1);
         }
      }

      protected void GXDLVBR_DEATH_BR_DEATH_CAUSECODE_data3Z2( decimal AV27Tcurrentcode )
      {
         gxdynajaxctrlcodr.Clear();
         gxdynajaxctrldescr.Clear();
         gxdynajaxctrlcodr.Add("");
         gxdynajaxctrldescr.Add("(请选择)");
         /* Using cursor H003Z2 */
         pr_default.execute(0, new Object[] {AV27Tcurrentcode});
         while ( (pr_default.getStatus(0) != 101) )
         {
            gxdynajaxctrlcodr.Add(H003Z2_A168XT_DefineCodeName[0]);
            gxdynajaxctrldescr.Add(H003Z2_A168XT_DefineCodeName[0]);
            pr_default.readNext(0);
         }
         pr_default.close(0);
      }

      protected void GXDLVBR_DEATH_BR_DEATH_SOURSE3Z2( decimal AV27Tcurrentcode )
      {
         if ( ! context.isAjaxRequest( ) )
         {
            context.GX_webresponse.AppendHeader("Cache-Control", "no-store");
         }
         context.GX_webresponse.AddString("[[");
         GXDLVBR_DEATH_BR_DEATH_SOURSE_data3Z2( AV27Tcurrentcode) ;
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

      protected void GXVBR_DEATH_BR_DEATH_SOURSE_html3Z2( decimal AV27Tcurrentcode )
      {
         String gxdynajaxvalue ;
         GXDLVBR_DEATH_BR_DEATH_SOURSE_data3Z2( AV27Tcurrentcode) ;
         gxdynajaxindex = 1;
         if ( ! ( gxdyncontrolsrefreshing && context.isAjaxRequest( ) ) )
         {
            dynavBr_death_br_death_sourse.removeAllItems();
         }
         while ( gxdynajaxindex <= gxdynajaxctrlcodr.Count )
         {
            gxdynajaxvalue = ((String)gxdynajaxctrlcodr.Item(gxdynajaxindex));
            dynavBr_death_br_death_sourse.addItem(gxdynajaxvalue, ((String)gxdynajaxctrldescr.Item(gxdynajaxindex)), 0);
            gxdynajaxindex = (int)(gxdynajaxindex+1);
         }
      }

      protected void GXDLVBR_DEATH_BR_DEATH_SOURSE_data3Z2( decimal AV27Tcurrentcode )
      {
         gxdynajaxctrlcodr.Clear();
         gxdynajaxctrldescr.Clear();
         gxdynajaxctrlcodr.Add("");
         gxdynajaxctrldescr.Add("(请选择)");
         /* Using cursor H003Z3 */
         pr_default.execute(1, new Object[] {AV27Tcurrentcode});
         while ( (pr_default.getStatus(1) != 101) )
         {
            gxdynajaxctrlcodr.Add(H003Z3_A168XT_DefineCodeName[0]);
            gxdynajaxctrldescr.Add(H003Z3_A168XT_DefineCodeName[0]);
            pr_default.readNext(1);
         }
         pr_default.close(1);
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
         if ( dynavBr_death_br_death_causecode.ItemCount > 0 )
         {
            AV13BR_Death.gxTpr_Br_death_causecode = dynavBr_death_br_death_causecode.getValidValue(AV13BR_Death.gxTpr_Br_death_causecode);
         }
         if ( context.isAjaxRequest( ) )
         {
            dynavBr_death_br_death_causecode.CurrentValue = StringUtil.RTrim( AV13BR_Death.gxTpr_Br_death_causecode);
            context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, dynavBr_death_br_death_causecode_Internalname, "Values", dynavBr_death_br_death_causecode.ToJavascriptSource(), true);
         }
         if ( dynavBr_death_br_death_sourse.ItemCount > 0 )
         {
            AV13BR_Death.gxTpr_Br_death_sourse = dynavBr_death_br_death_sourse.getValidValue(AV13BR_Death.gxTpr_Br_death_sourse);
         }
         if ( context.isAjaxRequest( ) )
         {
            dynavBr_death_br_death_sourse.CurrentValue = StringUtil.RTrim( AV13BR_Death.gxTpr_Br_death_sourse);
            context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, dynavBr_death_br_death_sourse_Internalname, "Values", dynavBr_death_br_death_sourse.ToJavascriptSource(), true);
         }
      }

      public void Refresh( )
      {
         send_integrity_hashes( ) ;
         RF3Z2( ) ;
         if ( isFullAjaxMode( ) )
         {
            send_integrity_footer_hashes( ) ;
         }
      }

      protected void initialize_formulas( )
      {
         /* GeneXus formulas. */
         AV26Pgmname = "BR_EncounterCheckDeath";
         context.Gx_err = 0;
         edtavBr_death_br_death_date_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavBr_death_br_death_date_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavBr_death_br_death_date_Enabled), 5, 0)), true);
         edtavBr_death_br_death_cause_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavBr_death_br_death_cause_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavBr_death_br_death_cause_Enabled), 5, 0)), true);
         dynavBr_death_br_death_causecode.Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, dynavBr_death_br_death_causecode_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(dynavBr_death_br_death_causecode.Enabled), 5, 0)), true);
         dynavBr_death_br_death_sourse.Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, dynavBr_death_br_death_sourse_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(dynavBr_death_br_death_sourse.Enabled), 5, 0)), true);
      }

      protected void RF3Z2( )
      {
         initialize_formulas( ) ;
         clear_multi_value_controls( ) ;
         gxdyncontrolsrefreshing = true;
         fix_multi_value_controls( ) ;
         gxdyncontrolsrefreshing = false;
         if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
         {
            /* Execute user event: Load */
            E123Z2 ();
            WB3Z0( ) ;
         }
      }

      protected void send_integrity_lvl_hashes3Z2( )
      {
      }

      protected void STRUP3Z0( )
      {
         /* Before Start, stand alone formulas. */
         AV26Pgmname = "BR_EncounterCheckDeath";
         context.Gx_err = 0;
         edtavBr_death_br_death_date_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavBr_death_br_death_date_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavBr_death_br_death_date_Enabled), 5, 0)), true);
         edtavBr_death_br_death_cause_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavBr_death_br_death_cause_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavBr_death_br_death_cause_Enabled), 5, 0)), true);
         dynavBr_death_br_death_causecode.Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, dynavBr_death_br_death_causecode_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(dynavBr_death_br_death_causecode.Enabled), 5, 0)), true);
         dynavBr_death_br_death_sourse.Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, dynavBr_death_br_death_sourse_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(dynavBr_death_br_death_sourse.Enabled), 5, 0)), true);
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0;
         /* Execute user event: Start */
         E113Z2 ();
         context.wbGlbDoneStart = 1;
         nDoneStart = 1;
         /* After Start, stand alone formulas. */
         sXEvt = cgiGet( "_EventName");
         if ( ! GetJustCreated( ) && ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 ) )
         {
            /* Read saved SDTs. */
            ajax_req_read_hidden_sdt(cgiGet( sPrefix+"Br_death"), AV13BR_Death);
            /* Read variables values. */
            if ( context.localUtil.VCDate( cgiGet( edtavBr_death_br_death_date_Internalname), 0) == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_faildate", new   object[]  {"死亡日期"}), 1, "BR_DEATH_BR_DEATH_DATE");
               GX_FocusControl = edtavBr_death_br_death_date_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV13BR_Death.gxTpr_Br_death_date = DateTime.MinValue;
            }
            else
            {
               AV13BR_Death.gxTpr_Br_death_date = context.localUtil.CToD( cgiGet( edtavBr_death_br_death_date_Internalname), 0);
            }
            AV13BR_Death.gxTpr_Br_death_cause = cgiGet( edtavBr_death_br_death_cause_Internalname);
            dynavBr_death_br_death_causecode.CurrentValue = cgiGet( dynavBr_death_br_death_causecode_Internalname);
            AV13BR_Death.gxTpr_Br_death_causecode = cgiGet( dynavBr_death_br_death_causecode_Internalname);
            dynavBr_death_br_death_sourse.CurrentValue = cgiGet( dynavBr_death_br_death_sourse_Internalname);
            AV13BR_Death.gxTpr_Br_death_sourse = cgiGet( dynavBr_death_br_death_sourse_Internalname);
            if ( ( ( context.localUtil.CToN( cgiGet( edtavBr_death_br_deathid_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavBr_death_br_deathid_Internalname), ".", ",") > Convert.ToDecimal( 999999999999999999L )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "BR_DEATH_BR_DEATHID");
               GX_FocusControl = edtavBr_death_br_deathid_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV13BR_Death.gxTpr_Br_deathid = 0;
            }
            else
            {
               AV13BR_Death.gxTpr_Br_deathid = (long)(context.localUtil.CToN( cgiGet( edtavBr_death_br_deathid_Internalname), ".", ","));
            }
            if ( ( ( context.localUtil.CToN( cgiGet( edtavBr_death_br_encounterid_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavBr_death_br_encounterid_Internalname), ".", ",") > Convert.ToDecimal( 999999999999999999L )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "BR_DEATH_BR_ENCOUNTERID");
               GX_FocusControl = edtavBr_death_br_encounterid_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV13BR_Death.gxTpr_Br_encounterid = 0;
            }
            else
            {
               AV13BR_Death.gxTpr_Br_encounterid = (long)(context.localUtil.CToN( cgiGet( edtavBr_death_br_encounterid_Internalname), ".", ","));
            }
            AV13BR_Death.gxTpr_Br_information_patientno = cgiGet( edtavBr_death_br_information_patientno_Internalname);
            /* Read saved values. */
            wcpOA19BR_EncounterID = (long)(context.localUtil.CToN( cgiGet( sPrefix+"wcpOA19BR_EncounterID"), ".", ","));
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
         E113Z2 ();
         if (returnInSub) return;
      }

      protected void E113Z2( )
      {
         /* Start Routine */
         new GeneXus.Programs.wwpbaseobjects.loadwwpcontext(context ).execute( out  AV6WWPContext) ;
         /* Execute user subroutine: 'PREPARETRANSACTION' */
         S112 ();
         if (returnInSub) return;
         /* Using cursor H003Z4 */
         pr_default.execute(2, new Object[] {A19BR_EncounterID});
         while ( (pr_default.getStatus(2) != 101) )
         {
            A48BR_DeathID = H003Z4_A48BR_DeathID[0];
            AV13BR_Death.Load(A48BR_DeathID);
            /* Exit For each command. Update data (if necessary), close cursors & exit. */
            if (true) break;
            pr_default.readNext(2);
         }
         pr_default.close(2);
      }

      protected void nextLoad( )
      {
      }

      protected void E123Z2( )
      {
         /* Load Routine */
         edtavBr_death_br_deathid_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavBr_death_br_deathid_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavBr_death_br_deathid_Visible), 5, 0)), true);
         edtavBr_death_br_encounterid_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavBr_death_br_encounterid_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavBr_death_br_encounterid_Visible), 5, 0)), true);
         edtavBr_death_br_information_patientno_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavBr_death_br_information_patientno_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavBr_death_br_information_patientno_Visible), 5, 0)), true);
      }

      protected void S112( )
      {
         /* 'PREPARETRANSACTION' Routine */
         AV9TrnContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext(context);
         AV9TrnContext.gxTpr_Callerobject = AV26Pgmname;
         AV9TrnContext.gxTpr_Callerondelete = false;
         AV9TrnContext.gxTpr_Callerurl = AV12HTTPRequest.ScriptName+"?"+AV12HTTPRequest.QueryString;
         AV9TrnContext.gxTpr_Transactionname = "BR_Encounter";
         AV10TrnContextAtt = new GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext_Attribute(context);
         AV10TrnContextAtt.gxTpr_Attributename = "BR_EncounterID";
         AV10TrnContextAtt.gxTpr_Attributevalue = StringUtil.Str( (decimal)(AV8BR_EncounterID), 18, 0);
         AV9TrnContext.gxTpr_Attributes.Add(AV10TrnContextAtt, 0);
         AV11Session.Set("TrnContext", AV9TrnContext.ToXml(false, true, "WWPTransactionContext", "DataAnalysisPlatform"));
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
         PA3Z2( ) ;
         WS3Z2( ) ;
         WE3Z2( ) ;
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
         PA3Z2( ) ;
         WCParametersGet( ) ;
      }

      public override void componentprepare( Object[] obj )
      {
         wbLoad = false;
         sCompPrefix = (String)getParm(obj,0);
         sSFPrefix = (String)getParm(obj,1);
         sPrefix = sCompPrefix + sSFPrefix;
         AddComponentObject(sPrefix, "br_encountercheckdeath", GetJustCreated( ));
         if ( ( nDoneStart == 0 ) && ( nDynComponent == 0 ) )
         {
            INITWEB( ) ;
         }
         else
         {
            init_default_properties( ) ;
            init_web_controls( ) ;
         }
         PA3Z2( ) ;
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
         PA3Z2( ) ;
         sEvt = sCompEvt;
         WCParametersGet( ) ;
         WS3Z2( ) ;
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
         WS3Z2( ) ;
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
         WE3Z2( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?20202281563423", true);
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
            context.AddJavascriptSource("br_encountercheckdeath.js", "?20202281563424", false);
         }
         /* End function include_jscripts */
      }

      protected void init_web_controls( )
      {
         dynavBr_death_br_death_causecode.Name = "BR_DEATH_BR_DEATH_CAUSECODE";
         dynavBr_death_br_death_causecode.WebTags = "";
         dynavBr_death_br_death_sourse.Name = "BR_DEATH_BR_DEATH_SOURSE";
         dynavBr_death_br_death_sourse.WebTags = "";
         /* End function init_web_controls */
      }

      protected void init_default_properties( )
      {
         lblTextblockbr_death_br_death_date_Internalname = sPrefix+"TEXTBLOCKBR_DEATH_BR_DEATH_DATE";
         edtavBr_death_br_death_date_Internalname = sPrefix+"BR_DEATH_BR_DEATH_DATE";
         divUnnamedtablebr_death_br_death_date_Internalname = sPrefix+"UNNAMEDTABLEBR_DEATH_BR_DEATH_DATE";
         lblTextblockbr_death_br_death_cause_Internalname = sPrefix+"TEXTBLOCKBR_DEATH_BR_DEATH_CAUSE";
         edtavBr_death_br_death_cause_Internalname = sPrefix+"BR_DEATH_BR_DEATH_CAUSE";
         divUnnamedtablebr_death_br_death_cause_Internalname = sPrefix+"UNNAMEDTABLEBR_DEATH_BR_DEATH_CAUSE";
         lblTextblockbr_death_br_death_causecode_Internalname = sPrefix+"TEXTBLOCKBR_DEATH_BR_DEATH_CAUSECODE";
         dynavBr_death_br_death_causecode_Internalname = sPrefix+"BR_DEATH_BR_DEATH_CAUSECODE";
         divUnnamedtablebr_death_br_death_causecode_Internalname = sPrefix+"UNNAMEDTABLEBR_DEATH_BR_DEATH_CAUSECODE";
         lblTextblockbr_death_br_death_sourse_Internalname = sPrefix+"TEXTBLOCKBR_DEATH_BR_DEATH_SOURSE";
         dynavBr_death_br_death_sourse_Internalname = sPrefix+"BR_DEATH_BR_DEATH_SOURSE";
         divUnnamedtablebr_death_br_death_sourse_Internalname = sPrefix+"UNNAMEDTABLEBR_DEATH_BR_DEATH_SOURSE";
         divUnnamedtable1_Internalname = sPrefix+"UNNAMEDTABLE1";
         edtavBr_death_br_deathid_Internalname = sPrefix+"BR_DEATH_BR_DEATHID";
         edtavBr_death_br_encounterid_Internalname = sPrefix+"BR_DEATH_BR_ENCOUNTERID";
         edtavBr_death_br_information_patientno_Internalname = sPrefix+"BR_DEATH_BR_INFORMATION_PATIENTNO";
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
         edtavBr_death_br_information_patientno_Jsonclick = "";
         edtavBr_death_br_information_patientno_Visible = 1;
         edtavBr_death_br_encounterid_Jsonclick = "";
         edtavBr_death_br_encounterid_Visible = 1;
         edtavBr_death_br_deathid_Jsonclick = "";
         edtavBr_death_br_deathid_Visible = 1;
         dynavBr_death_br_death_sourse_Jsonclick = "";
         dynavBr_death_br_death_sourse.Enabled = 0;
         dynavBr_death_br_death_causecode_Jsonclick = "";
         dynavBr_death_br_death_causecode.Enabled = 0;
         edtavBr_death_br_death_cause_Jsonclick = "";
         edtavBr_death_br_death_cause_Enabled = 0;
         edtavBr_death_br_death_date_Jsonclick = "";
         edtavBr_death_br_death_date_Enabled = 0;
         dynavBr_death_br_death_sourse.Enabled = -1;
         dynavBr_death_br_death_causecode.Enabled = -1;
         edtavBr_death_br_death_cause_Enabled = -1;
         edtavBr_death_br_death_date_Enabled = -1;
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
         AV26Pgmname = "";
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         GXKey = "";
         AV13BR_Death = new SdtBR_Death(context);
         GX_FocusControl = "";
         lblTextblockbr_death_br_death_date_Jsonclick = "";
         lblTextblockbr_death_br_death_cause_Jsonclick = "";
         lblTextblockbr_death_br_death_causecode_Jsonclick = "";
         lblTextblockbr_death_br_death_sourse_Jsonclick = "";
         TempTags = "";
         Form = new GXWebForm();
         sXEvt = "";
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         gxdynajaxctrlcodr = new GeneXus.Utils.GxStringCollection();
         gxdynajaxctrldescr = new GeneXus.Utils.GxStringCollection();
         gxwrpcisep = "";
         scmdbuf = "";
         H003Z2_A167XT_DefineCodeID = new long[1] ;
         H003Z2_A168XT_DefineCodeName = new String[] {""} ;
         H003Z2_n168XT_DefineCodeName = new bool[] {false} ;
         H003Z2_A165XT_DefindcodeTypeID = new long[1] ;
         H003Z2_A432XT_TenantCode = new String[] {""} ;
         H003Z2_n432XT_TenantCode = new bool[] {false} ;
         H003Z3_A167XT_DefineCodeID = new long[1] ;
         H003Z3_A168XT_DefineCodeName = new String[] {""} ;
         H003Z3_n168XT_DefineCodeName = new bool[] {false} ;
         H003Z3_A165XT_DefindcodeTypeID = new long[1] ;
         H003Z3_A432XT_TenantCode = new String[] {""} ;
         H003Z3_n432XT_TenantCode = new bool[] {false} ;
         AV6WWPContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPContext(context);
         H003Z4_A19BR_EncounterID = new long[1] ;
         H003Z4_A48BR_DeathID = new long[1] ;
         AV9TrnContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext(context);
         AV12HTTPRequest = new GxHttpRequest( context);
         AV10TrnContextAtt = new GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext_Attribute(context);
         AV11Session = context.GetSession();
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         sCtrlA19BR_EncounterID = "";
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.br_encountercheckdeath__default(),
            new Object[][] {
                new Object[] {
               H003Z2_A167XT_DefineCodeID, H003Z2_A168XT_DefineCodeName, H003Z2_n168XT_DefineCodeName, H003Z2_A165XT_DefindcodeTypeID, H003Z2_A432XT_TenantCode, H003Z2_n432XT_TenantCode
               }
               , new Object[] {
               H003Z3_A167XT_DefineCodeID, H003Z3_A168XT_DefineCodeName, H003Z3_n168XT_DefineCodeName, H003Z3_A165XT_DefindcodeTypeID, H003Z3_A432XT_TenantCode, H003Z3_n432XT_TenantCode
               }
               , new Object[] {
               H003Z4_A19BR_EncounterID, H003Z4_A48BR_DeathID
               }
            }
         );
         AV26Pgmname = "BR_EncounterCheckDeath";
         /* GeneXus formulas. */
         AV26Pgmname = "BR_EncounterCheckDeath";
         context.Gx_err = 0;
         edtavBr_death_br_death_date_Enabled = 0;
         edtavBr_death_br_death_cause_Enabled = 0;
         dynavBr_death_br_death_causecode.Enabled = 0;
         dynavBr_death_br_death_sourse.Enabled = 0;
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
      private int edtavBr_death_br_death_date_Enabled ;
      private int edtavBr_death_br_death_cause_Enabled ;
      private int edtavBr_death_br_deathid_Visible ;
      private int edtavBr_death_br_encounterid_Visible ;
      private int edtavBr_death_br_information_patientno_Visible ;
      private int gxdynajaxindex ;
      private int idxLst ;
      private long A19BR_EncounterID ;
      private long wcpOA19BR_EncounterID ;
      private long A48BR_DeathID ;
      private long AV8BR_EncounterID ;
      private decimal AV27Tcurrentcode ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String sPrefix ;
      private String sCompPrefix ;
      private String sSFPrefix ;
      private String AV26Pgmname ;
      private String edtavBr_death_br_death_date_Internalname ;
      private String edtavBr_death_br_death_cause_Internalname ;
      private String dynavBr_death_br_death_causecode_Internalname ;
      private String dynavBr_death_br_death_sourse_Internalname ;
      private String sDynURL ;
      private String FormProcess ;
      private String bodyStyle ;
      private String GXKey ;
      private String GX_FocusControl ;
      private String divLayoutmaintable_Internalname ;
      private String divUnnamedtable1_Internalname ;
      private String divUnnamedtablebr_death_br_death_date_Internalname ;
      private String lblTextblockbr_death_br_death_date_Internalname ;
      private String lblTextblockbr_death_br_death_date_Jsonclick ;
      private String edtavBr_death_br_death_date_Jsonclick ;
      private String divUnnamedtablebr_death_br_death_cause_Internalname ;
      private String lblTextblockbr_death_br_death_cause_Internalname ;
      private String lblTextblockbr_death_br_death_cause_Jsonclick ;
      private String edtavBr_death_br_death_cause_Jsonclick ;
      private String divUnnamedtablebr_death_br_death_causecode_Internalname ;
      private String lblTextblockbr_death_br_death_causecode_Internalname ;
      private String lblTextblockbr_death_br_death_causecode_Jsonclick ;
      private String dynavBr_death_br_death_causecode_Jsonclick ;
      private String divUnnamedtablebr_death_br_death_sourse_Internalname ;
      private String lblTextblockbr_death_br_death_sourse_Internalname ;
      private String lblTextblockbr_death_br_death_sourse_Jsonclick ;
      private String dynavBr_death_br_death_sourse_Jsonclick ;
      private String divHtml_bottomauxiliarcontrols_Internalname ;
      private String TempTags ;
      private String edtavBr_death_br_deathid_Internalname ;
      private String edtavBr_death_br_deathid_Jsonclick ;
      private String edtavBr_death_br_encounterid_Internalname ;
      private String edtavBr_death_br_encounterid_Jsonclick ;
      private String edtavBr_death_br_information_patientno_Internalname ;
      private String edtavBr_death_br_information_patientno_Jsonclick ;
      private String sXEvt ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String gxwrpcisep ;
      private String scmdbuf ;
      private String sCtrlA19BR_EncounterID ;
      private bool entryPointCalled ;
      private bool toggleJsOutput ;
      private bool wbLoad ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool gxdyncontrolsrefreshing ;
      private bool returnInSub ;
      private GeneXus.Utils.GxStringCollection gxdynajaxctrlcodr ;
      private GeneXus.Utils.GxStringCollection gxdynajaxctrldescr ;
      private GXWebForm Form ;
      private IGxDataStore dsDataStore1 ;
      private IGxDataStore dsDefault ;
      private GXCombobox dynavBr_death_br_death_causecode ;
      private GXCombobox dynavBr_death_br_death_sourse ;
      private IDataStoreProvider pr_default ;
      private long[] H003Z2_A167XT_DefineCodeID ;
      private String[] H003Z2_A168XT_DefineCodeName ;
      private bool[] H003Z2_n168XT_DefineCodeName ;
      private long[] H003Z2_A165XT_DefindcodeTypeID ;
      private String[] H003Z2_A432XT_TenantCode ;
      private bool[] H003Z2_n432XT_TenantCode ;
      private long[] H003Z3_A167XT_DefineCodeID ;
      private String[] H003Z3_A168XT_DefineCodeName ;
      private bool[] H003Z3_n168XT_DefineCodeName ;
      private long[] H003Z3_A165XT_DefindcodeTypeID ;
      private String[] H003Z3_A432XT_TenantCode ;
      private bool[] H003Z3_n432XT_TenantCode ;
      private long[] H003Z4_A19BR_EncounterID ;
      private long[] H003Z4_A48BR_DeathID ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private GxHttpRequest AV12HTTPRequest ;
      private IGxSession AV11Session ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPContext AV6WWPContext ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext AV9TrnContext ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext_Attribute AV10TrnContextAtt ;
      private SdtBR_Death AV13BR_Death ;
   }

   public class br_encountercheckdeath__default : DataStoreHelperBase, IDataStoreHelper
   {
      public ICursor[] getCursors( )
      {
         cursorDefinitions();
         return new Cursor[] {
          new ForEachCursor(def[0])
         ,new ForEachCursor(def[1])
         ,new ForEachCursor(def[2])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmH003Z2 ;
          prmH003Z2 = new Object[] {
          new Object[] {"@AV27Tcurrentcode",SqlDbType.Decimal,10,2}
          } ;
          Object[] prmH003Z3 ;
          prmH003Z3 = new Object[] {
          new Object[] {"@AV27Tcurrentcode",SqlDbType.Decimal,10,2}
          } ;
          Object[] prmH003Z4 ;
          prmH003Z4 = new Object[] {
          new Object[] {"@BR_EncounterID",SqlDbType.Decimal,18,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("H003Z2", "SELECT [XT_DefineCodeID], [XT_DefineCodeName], [XT_DefindcodeTypeID], [XT_TenantCode] FROM [XT_DefineCode] WITH (NOLOCK) WHERE ([XT_DefindcodeTypeID] = 18) AND ([XT_TenantCode] = @AV27Tcurrentcode) ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH003Z2,0,0,true,false )
             ,new CursorDef("H003Z3", "SELECT [XT_DefineCodeID], [XT_DefineCodeName], [XT_DefindcodeTypeID], [XT_TenantCode] FROM [XT_DefineCode] WITH (NOLOCK) WHERE ([XT_DefindcodeTypeID] = 19) AND ([XT_TenantCode] = @AV27Tcurrentcode) ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH003Z3,0,0,true,false )
             ,new CursorDef("H003Z4", "SELECT TOP 1 [BR_EncounterID], [BR_DeathID] FROM [BR_Death] WITH (NOLOCK) WHERE [BR_EncounterID] = @BR_EncounterID ORDER BY [BR_EncounterID] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH003Z4,1,0,true,true )
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
                ((long[]) buf[1])[0] = rslt.getLong(2) ;
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
                stmt.SetParameter(1, (decimal)parms[0]);
                return;
             case 1 :
                stmt.SetParameter(1, (decimal)parms[0]);
                return;
             case 2 :
                stmt.SetParameter(1, (long)parms[0]);
                return;
       }
    }

 }

}
