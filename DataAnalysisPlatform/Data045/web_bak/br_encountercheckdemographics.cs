/*
               File: BR_EncounterCheckDemographics
        Description: Data Mgmt Portal - RAAP
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/27/2020 9:36:1.98
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
   public class br_encountercheckdemographics : GXWebComponent, System.Web.SessionState.IRequiresSessionState
   {
      public br_encountercheckdemographics( )
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

      public br_encountercheckdemographics( IGxContext context )
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
         dynavBr_demographics_br_demographics_sex = new GXCombobox();
         dynavBr_demographics_br_demographics_ethnic = new GXCombobox();
         dynavBr_demographics_br_demographics_marritalstatus = new GXCombobox();
         dynavBr_demographics_br_demographics_education = new GXCombobox();
         dynavBr_demographics_br_demographics_insurance = new GXCombobox();
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
               else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxCallCrl"+"_"+"BR_DEMOGRAPHICS_BR_DEMOGRAPHICS_SEX") == 0 )
               {
                  AV32Tcurrentcode = NumberUtil.Val( GetNextPar( ), ".");
                  setAjaxCallMode();
                  if ( ! IsValidAjaxCall( true) )
                  {
                     GxWebError = 1;
                     return  ;
                  }
                  GXDLVBR_DEMOGRAPHICS_BR_DEMOGRAPHICS_SEX3U2( AV32Tcurrentcode) ;
                  return  ;
               }
               else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxCallCrl"+"_"+"BR_DEMOGRAPHICS_BR_DEMOGRAPHICS_ETHNIC") == 0 )
               {
                  AV32Tcurrentcode = NumberUtil.Val( GetNextPar( ), ".");
                  setAjaxCallMode();
                  if ( ! IsValidAjaxCall( true) )
                  {
                     GxWebError = 1;
                     return  ;
                  }
                  GXDLVBR_DEMOGRAPHICS_BR_DEMOGRAPHICS_ETHNIC3U2( AV32Tcurrentcode) ;
                  return  ;
               }
               else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxCallCrl"+"_"+"BR_DEMOGRAPHICS_BR_DEMOGRAPHICS_MARRITALSTATUS") == 0 )
               {
                  AV32Tcurrentcode = NumberUtil.Val( GetNextPar( ), ".");
                  setAjaxCallMode();
                  if ( ! IsValidAjaxCall( true) )
                  {
                     GxWebError = 1;
                     return  ;
                  }
                  GXDLVBR_DEMOGRAPHICS_BR_DEMOGRAPHICS_MARRITALSTATUS3U2( AV32Tcurrentcode) ;
                  return  ;
               }
               else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxCallCrl"+"_"+"BR_DEMOGRAPHICS_BR_DEMOGRAPHICS_EDUCATION") == 0 )
               {
                  AV32Tcurrentcode = NumberUtil.Val( GetNextPar( ), ".");
                  setAjaxCallMode();
                  if ( ! IsValidAjaxCall( true) )
                  {
                     GxWebError = 1;
                     return  ;
                  }
                  GXDLVBR_DEMOGRAPHICS_BR_DEMOGRAPHICS_EDUCATION3U2( AV32Tcurrentcode) ;
                  return  ;
               }
               else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxCallCrl"+"_"+"BR_DEMOGRAPHICS_BR_DEMOGRAPHICS_INSURANCE") == 0 )
               {
                  AV32Tcurrentcode = NumberUtil.Val( GetNextPar( ), ".");
                  setAjaxCallMode();
                  if ( ! IsValidAjaxCall( true) )
                  {
                     GxWebError = 1;
                     return  ;
                  }
                  GXDLVBR_DEMOGRAPHICS_BR_DEMOGRAPHICS_INSURANCE3U2( AV32Tcurrentcode) ;
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
            PA3U2( ) ;
            if ( ( GxWebError == 0 ) && ! isAjaxCallMode( ) )
            {
               /* GeneXus formulas. */
               AV31Pgmname = "BR_EncounterCheckDemographics";
               context.Gx_err = 0;
               dynavBr_demographics_br_demographics_sex.Enabled = 0;
               context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, dynavBr_demographics_br_demographics_sex_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(dynavBr_demographics_br_demographics_sex.Enabled), 5, 0)), true);
               edtavBr_demographics_br_demographics_birthdate_Enabled = 0;
               context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavBr_demographics_br_demographics_birthdate_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavBr_demographics_br_demographics_birthdate_Enabled), 5, 0)), true);
               dynavBr_demographics_br_demographics_ethnic.Enabled = 0;
               context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, dynavBr_demographics_br_demographics_ethnic_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(dynavBr_demographics_br_demographics_ethnic.Enabled), 5, 0)), true);
               dynavBr_demographics_br_demographics_marritalstatus.Enabled = 0;
               context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, dynavBr_demographics_br_demographics_marritalstatus_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(dynavBr_demographics_br_demographics_marritalstatus.Enabled), 5, 0)), true);
               dynavBr_demographics_br_demographics_education.Enabled = 0;
               context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, dynavBr_demographics_br_demographics_education_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(dynavBr_demographics_br_demographics_education.Enabled), 5, 0)), true);
               edtavBr_demographics_br_demographics_occupation_Enabled = 0;
               context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavBr_demographics_br_demographics_occupation_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavBr_demographics_br_demographics_occupation_Enabled), 5, 0)), true);
               edtavBr_demographics_br_demographics_province_Enabled = 0;
               context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavBr_demographics_br_demographics_province_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavBr_demographics_br_demographics_province_Enabled), 5, 0)), true);
               edtavBr_demographics_br_demographics_city_Enabled = 0;
               context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavBr_demographics_br_demographics_city_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavBr_demographics_br_demographics_city_Enabled), 5, 0)), true);
               dynavBr_demographics_br_demographics_insurance.Enabled = 0;
               context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, dynavBr_demographics_br_demographics_insurance_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(dynavBr_demographics_br_demographics_insurance.Enabled), 5, 0)), true);
               WS3U2( ) ;
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
         context.AddJavascriptSource("gxcfg.js", "?202022793628", false);
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
               context.WriteHtmlTextNl( "<form id=\"MAINFORM\" autocomplete=\"off\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("br_encountercheckdemographics.aspx") + "?" + UrlEncode("" +A19BR_EncounterID)+"\">") ;
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
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, sPrefix+"Br_demographics", AV13BR_Demographics);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt(sPrefix+"Br_demographics", AV13BR_Demographics);
         }
         GxWebStd.gx_hidden_field( context, sPrefix+"wcpOA19BR_EncounterID", StringUtil.LTrim( StringUtil.NToC( (decimal)(wcpOA19BR_EncounterID), 18, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, sPrefix+"BR_ENCOUNTERID", StringUtil.LTrim( StringUtil.NToC( (decimal)(A19BR_EncounterID), 18, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, sPrefix+"vTCURRENTCODE", StringUtil.LTrim( StringUtil.NToC( AV32Tcurrentcode, 10, 2, ".", "")));
      }

      protected void RenderHtmlCloseForm3U2( )
      {
         SendCloseFormHiddens( ) ;
         if ( ( StringUtil.Len( sPrefix) != 0 ) && ( context.isAjaxRequest( ) || context.isSpaRequest( ) ) )
         {
            context.AddJavascriptSource("br_encountercheckdemographics.js", "?2020227936212", false);
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
         return "BR_EncounterCheckDemographics" ;
      }

      public override String GetPgmdesc( )
      {
         return "Data Mgmt Portal - RAAP" ;
      }

      protected void WB3U0( )
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
               GxWebStd.gx_hidden_field( context, sPrefix+"_CMPPGM", "br_encountercheckdemographics.aspx");
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
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+dynavBr_demographics_br_demographics_sex_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, dynavBr_demographics_br_demographics_sex_Internalname, "性别", "col-sm-3 ReadonlyAttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, dynavBr_demographics_br_demographics_sex, dynavBr_demographics_br_demographics_sex_Internalname, StringUtil.RTrim( AV13BR_Demographics.gxTpr_Br_demographics_sex), 1, dynavBr_demographics_br_demographics_sex_Jsonclick, 0, "'"+sPrefix+"'"+",false,"+"'"+""+"'", "svchar", "", 1, dynavBr_demographics_br_demographics_sex.Enabled, 0, 0, 0, "em", 0, "", "", "ReadonlyAttribute", "", "", "", "", true, "HLP_BR_EncounterCheckDemographics.htm");
            dynavBr_demographics_br_demographics_sex.CurrentValue = StringUtil.RTrim( AV13BR_Demographics.gxTpr_Br_demographics_sex);
            context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, dynavBr_demographics_br_demographics_sex_Internalname, "Values", (String)(dynavBr_demographics_br_demographics_sex.ToJavascriptSource()), true);
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-md-6 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtavBr_demographics_br_demographics_birthdate_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavBr_demographics_br_demographics_birthdate_Internalname, "出生日期", "col-sm-3 ReadonlyAttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            context.WriteHtmlText( "<div id=\""+edtavBr_demographics_br_demographics_birthdate_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtavBr_demographics_br_demographics_birthdate_Internalname, context.localUtil.Format(AV13BR_Demographics.gxTpr_Br_demographics_birthdate, "9999/99/99"), context.localUtil.Format( AV13BR_Demographics.gxTpr_Br_demographics_birthdate, "9999/99/99"), "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavBr_demographics_br_demographics_birthdate_Jsonclick, 0, "ReadonlyAttribute", "", "", "", "", 1, edtavBr_demographics_br_demographics_birthdate_Enabled, 0, "text", "", 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_BR_EncounterCheckDemographics.htm");
            GxWebStd.gx_bitmap( context, edtavBr_demographics_br_demographics_birthdate_Internalname+"_dp_trigger", context.GetImagePath( "61b9b5d3-dff6-4d59-9b00-da61bc2cbe93", "", context.GetTheme( )), "", "", "", "", ((1==0)||(edtavBr_demographics_br_demographics_birthdate_Enabled==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;", "", "", "", "", "", "", "", "", 1, false, false, "", "HLP_BR_EncounterCheckDemographics.htm");
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
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+dynavBr_demographics_br_demographics_ethnic_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, dynavBr_demographics_br_demographics_ethnic_Internalname, "民族", "col-sm-3 ReadonlyAttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, dynavBr_demographics_br_demographics_ethnic, dynavBr_demographics_br_demographics_ethnic_Internalname, StringUtil.RTrim( AV13BR_Demographics.gxTpr_Br_demographics_ethnic), 1, dynavBr_demographics_br_demographics_ethnic_Jsonclick, 0, "'"+sPrefix+"'"+",false,"+"'"+""+"'", "svchar", "", 1, dynavBr_demographics_br_demographics_ethnic.Enabled, 0, 0, 0, "em", 0, "", "", "ReadonlyAttribute", "", "", "", "", true, "HLP_BR_EncounterCheckDemographics.htm");
            dynavBr_demographics_br_demographics_ethnic.CurrentValue = StringUtil.RTrim( AV13BR_Demographics.gxTpr_Br_demographics_ethnic);
            context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, dynavBr_demographics_br_demographics_ethnic_Internalname, "Values", (String)(dynavBr_demographics_br_demographics_ethnic.ToJavascriptSource()), true);
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-md-6 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+dynavBr_demographics_br_demographics_marritalstatus_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, dynavBr_demographics_br_demographics_marritalstatus_Internalname, "婚姻状态", "col-sm-3 ReadonlyAttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, dynavBr_demographics_br_demographics_marritalstatus, dynavBr_demographics_br_demographics_marritalstatus_Internalname, StringUtil.RTrim( AV13BR_Demographics.gxTpr_Br_demographics_marritalstatus), 1, dynavBr_demographics_br_demographics_marritalstatus_Jsonclick, 0, "'"+sPrefix+"'"+",false,"+"'"+""+"'", "svchar", "", 1, dynavBr_demographics_br_demographics_marritalstatus.Enabled, 0, 0, 0, "em", 0, "", "", "ReadonlyAttribute", "", "", "", "", true, "HLP_BR_EncounterCheckDemographics.htm");
            dynavBr_demographics_br_demographics_marritalstatus.CurrentValue = StringUtil.RTrim( AV13BR_Demographics.gxTpr_Br_demographics_marritalstatus);
            context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, dynavBr_demographics_br_demographics_marritalstatus_Internalname, "Values", (String)(dynavBr_demographics_br_demographics_marritalstatus.ToJavascriptSource()), true);
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-md-6 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+dynavBr_demographics_br_demographics_education_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, dynavBr_demographics_br_demographics_education_Internalname, "学历", "col-sm-3 ReadonlyAttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, dynavBr_demographics_br_demographics_education, dynavBr_demographics_br_demographics_education_Internalname, StringUtil.RTrim( AV13BR_Demographics.gxTpr_Br_demographics_education), 1, dynavBr_demographics_br_demographics_education_Jsonclick, 0, "'"+sPrefix+"'"+",false,"+"'"+""+"'", "svchar", "", 1, dynavBr_demographics_br_demographics_education.Enabled, 0, 0, 0, "em", 0, "", "", "ReadonlyAttribute", "", "", "", "", true, "HLP_BR_EncounterCheckDemographics.htm");
            dynavBr_demographics_br_demographics_education.CurrentValue = StringUtil.RTrim( AV13BR_Demographics.gxTpr_Br_demographics_education);
            context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, dynavBr_demographics_br_demographics_education_Internalname, "Values", (String)(dynavBr_demographics_br_demographics_education.ToJavascriptSource()), true);
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-md-6 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtavBr_demographics_br_demographics_occupation_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavBr_demographics_br_demographics_occupation_Internalname, "职业", "col-sm-3 ReadonlyAttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtavBr_demographics_br_demographics_occupation_Internalname, AV13BR_Demographics.gxTpr_Br_demographics_occupation, StringUtil.RTrim( context.localUtil.Format( AV13BR_Demographics.gxTpr_Br_demographics_occupation, "")), "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavBr_demographics_br_demographics_occupation_Jsonclick, 0, "ReadonlyAttribute", "", "", "", "", 1, edtavBr_demographics_br_demographics_occupation_Enabled, 0, "text", "", 40, "chr", 1, "row", 40, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_BR_EncounterCheckDemographics.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-md-6 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtavBr_demographics_br_demographics_province_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavBr_demographics_br_demographics_province_Internalname, "省", "col-sm-3 ReadonlyAttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtavBr_demographics_br_demographics_province_Internalname, AV13BR_Demographics.gxTpr_Br_demographics_province, StringUtil.RTrim( context.localUtil.Format( AV13BR_Demographics.gxTpr_Br_demographics_province, "")), "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavBr_demographics_br_demographics_province_Jsonclick, 0, "ReadonlyAttribute", "", "", "", "", 1, edtavBr_demographics_br_demographics_province_Enabled, 0, "text", "", 40, "chr", 1, "row", 40, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_BR_EncounterCheckDemographics.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-md-6 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtavBr_demographics_br_demographics_city_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavBr_demographics_br_demographics_city_Internalname, "市", "col-sm-3 ReadonlyAttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtavBr_demographics_br_demographics_city_Internalname, AV13BR_Demographics.gxTpr_Br_demographics_city, StringUtil.RTrim( context.localUtil.Format( AV13BR_Demographics.gxTpr_Br_demographics_city, "")), "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavBr_demographics_br_demographics_city_Jsonclick, 0, "ReadonlyAttribute", "", "", "", "", 1, edtavBr_demographics_br_demographics_city_Enabled, 0, "text", "", 40, "chr", 1, "row", 40, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_BR_EncounterCheckDemographics.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-md-6 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+dynavBr_demographics_br_demographics_insurance_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, dynavBr_demographics_br_demographics_insurance_Internalname, "保险类型", "col-sm-3 ReadonlyAttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, dynavBr_demographics_br_demographics_insurance, dynavBr_demographics_br_demographics_insurance_Internalname, StringUtil.RTrim( AV13BR_Demographics.gxTpr_Br_demographics_insurance), 1, dynavBr_demographics_br_demographics_insurance_Jsonclick, 0, "'"+sPrefix+"'"+",false,"+"'"+""+"'", "svchar", "", 1, dynavBr_demographics_br_demographics_insurance.Enabled, 0, 0, 0, "em", 0, "", "", "ReadonlyAttribute", "", "", "", "", true, "HLP_BR_EncounterCheckDemographics.htm");
            dynavBr_demographics_br_demographics_insurance.CurrentValue = StringUtil.RTrim( AV13BR_Demographics.gxTpr_Br_demographics_insurance);
            context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, dynavBr_demographics_br_demographics_insurance_Internalname, "Values", (String)(dynavBr_demographics_br_demographics_insurance.ToJavascriptSource()), true);
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
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 51,'" + sPrefix + "',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavBr_demographics_br_demographics_id_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV13BR_Demographics.gxTpr_Br_demographics_id), 18, 0, ".", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(AV13BR_Demographics.gxTpr_Br_demographics_id), "ZZZZZZZZZZZZZZZZZZ")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,51);\"", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavBr_demographics_br_demographics_id_Jsonclick, 0, "Attribute", "", "", "", "", edtavBr_demographics_br_demographics_id_Visible, 1, 0, "number", "1", 18, "chr", 1, "row", 18, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_BR_EncounterCheckDemographics.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 52,'" + sPrefix + "',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavBr_demographics_br_encounterid_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV13BR_Demographics.gxTpr_Br_encounterid), 18, 0, ".", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(AV13BR_Demographics.gxTpr_Br_encounterid), "ZZZZZZZZZZZZZZZZZZ")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,52);\"", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavBr_demographics_br_encounterid_Jsonclick, 0, "Attribute", "", "", "", "", edtavBr_demographics_br_encounterid_Visible, 1, 0, "number", "1", 18, "chr", 1, "row", 18, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_BR_EncounterCheckDemographics.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 53,'" + sPrefix + "',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavBr_demographics_br_information_patientno_Internalname, AV13BR_Demographics.gxTpr_Br_information_patientno, StringUtil.RTrim( context.localUtil.Format( AV13BR_Demographics.gxTpr_Br_information_patientno, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,53);\"", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavBr_demographics_br_information_patientno_Jsonclick, 0, "Attribute", "", "", "", "", edtavBr_demographics_br_information_patientno_Visible, 1, 0, "text", "", 80, "chr", 1, "row", 2000, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_BR_EncounterCheckDemographics.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
         }
         wbLoad = true;
      }

      protected void START3U2( )
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
               STRUP3U0( ) ;
            }
         }
      }

      protected void WS3U2( )
      {
         START3U2( ) ;
         EVT3U2( ) ;
      }

      protected void EVT3U2( )
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
                                 STRUP3U0( ) ;
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
                                 STRUP3U0( ) ;
                              }
                              if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
                              {
                                 context.wbHandled = 1;
                                 if ( ! wbErr )
                                 {
                                    dynload_actions( ) ;
                                    /* Execute user event: Start */
                                    E113U2 ();
                                 }
                              }
                           }
                           else if ( StringUtil.StrCmp(sEvt, "LOAD") == 0 )
                           {
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP3U0( ) ;
                              }
                              if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
                              {
                                 context.wbHandled = 1;
                                 if ( ! wbErr )
                                 {
                                    dynload_actions( ) ;
                                    /* Execute user event: Load */
                                    E123U2 ();
                                 }
                              }
                           }
                           else if ( StringUtil.StrCmp(sEvt, "ENTER") == 0 )
                           {
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP3U0( ) ;
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
                                 STRUP3U0( ) ;
                              }
                              if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
                              {
                                 context.wbHandled = 1;
                                 if ( ! wbErr )
                                 {
                                    dynload_actions( ) ;
                                    GX_FocusControl = dynavBr_demographics_br_demographics_sex_Internalname;
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

      protected void WE3U2( )
      {
         if ( ! GxWebStd.gx_redirect( context) )
         {
            Rfr0gs = true;
            Refresh( ) ;
            if ( ! GxWebStd.gx_redirect( context) )
            {
               RenderHtmlCloseForm3U2( ) ;
            }
         }
      }

      protected void PA3U2( )
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
               GX_FocusControl = dynavBr_demographics_br_demographics_sex_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "GX_FocusControl", GX_FocusControl);
            }
            nDonePA = 1;
         }
      }

      protected void dynload_actions( )
      {
         /* End function dynload_actions */
      }

      protected void GXDLVBR_DEMOGRAPHICS_BR_DEMOGRAPHICS_SEX3U2( decimal AV32Tcurrentcode )
      {
         if ( ! context.isAjaxRequest( ) )
         {
            context.GX_webresponse.AppendHeader("Cache-Control", "no-store");
         }
         context.GX_webresponse.AddString("[[");
         GXDLVBR_DEMOGRAPHICS_BR_DEMOGRAPHICS_SEX_data3U2( AV32Tcurrentcode) ;
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

      protected void GXVBR_DEMOGRAPHICS_BR_DEMOGRAPHICS_SEX_html3U2( decimal AV32Tcurrentcode )
      {
         String gxdynajaxvalue ;
         GXDLVBR_DEMOGRAPHICS_BR_DEMOGRAPHICS_SEX_data3U2( AV32Tcurrentcode) ;
         gxdynajaxindex = 1;
         if ( ! ( gxdyncontrolsrefreshing && context.isAjaxRequest( ) ) )
         {
            dynavBr_demographics_br_demographics_sex.removeAllItems();
         }
         while ( gxdynajaxindex <= gxdynajaxctrlcodr.Count )
         {
            gxdynajaxvalue = ((String)gxdynajaxctrlcodr.Item(gxdynajaxindex));
            dynavBr_demographics_br_demographics_sex.addItem(gxdynajaxvalue, ((String)gxdynajaxctrldescr.Item(gxdynajaxindex)), 0);
            gxdynajaxindex = (int)(gxdynajaxindex+1);
         }
      }

      protected void GXDLVBR_DEMOGRAPHICS_BR_DEMOGRAPHICS_SEX_data3U2( decimal AV32Tcurrentcode )
      {
         gxdynajaxctrlcodr.Clear();
         gxdynajaxctrldescr.Clear();
         gxdynajaxctrlcodr.Add("");
         gxdynajaxctrldescr.Add("(请选择)");
         /* Using cursor H003U2 */
         pr_default.execute(0, new Object[] {AV32Tcurrentcode});
         while ( (pr_default.getStatus(0) != 101) )
         {
            gxdynajaxctrlcodr.Add(H003U2_A168XT_DefineCodeName[0]);
            gxdynajaxctrldescr.Add(H003U2_A168XT_DefineCodeName[0]);
            pr_default.readNext(0);
         }
         pr_default.close(0);
      }

      protected void GXDLVBR_DEMOGRAPHICS_BR_DEMOGRAPHICS_ETHNIC3U2( decimal AV32Tcurrentcode )
      {
         if ( ! context.isAjaxRequest( ) )
         {
            context.GX_webresponse.AppendHeader("Cache-Control", "no-store");
         }
         context.GX_webresponse.AddString("[[");
         GXDLVBR_DEMOGRAPHICS_BR_DEMOGRAPHICS_ETHNIC_data3U2( AV32Tcurrentcode) ;
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

      protected void GXVBR_DEMOGRAPHICS_BR_DEMOGRAPHICS_ETHNIC_html3U2( decimal AV32Tcurrentcode )
      {
         String gxdynajaxvalue ;
         GXDLVBR_DEMOGRAPHICS_BR_DEMOGRAPHICS_ETHNIC_data3U2( AV32Tcurrentcode) ;
         gxdynajaxindex = 1;
         if ( ! ( gxdyncontrolsrefreshing && context.isAjaxRequest( ) ) )
         {
            dynavBr_demographics_br_demographics_ethnic.removeAllItems();
         }
         while ( gxdynajaxindex <= gxdynajaxctrlcodr.Count )
         {
            gxdynajaxvalue = ((String)gxdynajaxctrlcodr.Item(gxdynajaxindex));
            dynavBr_demographics_br_demographics_ethnic.addItem(gxdynajaxvalue, ((String)gxdynajaxctrldescr.Item(gxdynajaxindex)), 0);
            gxdynajaxindex = (int)(gxdynajaxindex+1);
         }
      }

      protected void GXDLVBR_DEMOGRAPHICS_BR_DEMOGRAPHICS_ETHNIC_data3U2( decimal AV32Tcurrentcode )
      {
         gxdynajaxctrlcodr.Clear();
         gxdynajaxctrldescr.Clear();
         gxdynajaxctrlcodr.Add("");
         gxdynajaxctrldescr.Add("(请选择)");
         /* Using cursor H003U3 */
         pr_default.execute(1, new Object[] {AV32Tcurrentcode});
         while ( (pr_default.getStatus(1) != 101) )
         {
            gxdynajaxctrlcodr.Add(H003U3_A168XT_DefineCodeName[0]);
            gxdynajaxctrldescr.Add(H003U3_A168XT_DefineCodeName[0]);
            pr_default.readNext(1);
         }
         pr_default.close(1);
      }

      protected void GXDLVBR_DEMOGRAPHICS_BR_DEMOGRAPHICS_MARRITALSTATUS3U2( decimal AV32Tcurrentcode )
      {
         if ( ! context.isAjaxRequest( ) )
         {
            context.GX_webresponse.AppendHeader("Cache-Control", "no-store");
         }
         context.GX_webresponse.AddString("[[");
         GXDLVBR_DEMOGRAPHICS_BR_DEMOGRAPHICS_MARRITALSTATUS_data3U2( AV32Tcurrentcode) ;
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

      protected void GXVBR_DEMOGRAPHICS_BR_DEMOGRAPHICS_MARRITALSTATUS_html3U2( decimal AV32Tcurrentcode )
      {
         String gxdynajaxvalue ;
         GXDLVBR_DEMOGRAPHICS_BR_DEMOGRAPHICS_MARRITALSTATUS_data3U2( AV32Tcurrentcode) ;
         gxdynajaxindex = 1;
         if ( ! ( gxdyncontrolsrefreshing && context.isAjaxRequest( ) ) )
         {
            dynavBr_demographics_br_demographics_marritalstatus.removeAllItems();
         }
         while ( gxdynajaxindex <= gxdynajaxctrlcodr.Count )
         {
            gxdynajaxvalue = ((String)gxdynajaxctrlcodr.Item(gxdynajaxindex));
            dynavBr_demographics_br_demographics_marritalstatus.addItem(gxdynajaxvalue, ((String)gxdynajaxctrldescr.Item(gxdynajaxindex)), 0);
            gxdynajaxindex = (int)(gxdynajaxindex+1);
         }
      }

      protected void GXDLVBR_DEMOGRAPHICS_BR_DEMOGRAPHICS_MARRITALSTATUS_data3U2( decimal AV32Tcurrentcode )
      {
         gxdynajaxctrlcodr.Clear();
         gxdynajaxctrldescr.Clear();
         gxdynajaxctrlcodr.Add("");
         gxdynajaxctrldescr.Add("(请选择)");
         /* Using cursor H003U4 */
         pr_default.execute(2, new Object[] {AV32Tcurrentcode});
         while ( (pr_default.getStatus(2) != 101) )
         {
            gxdynajaxctrlcodr.Add(H003U4_A168XT_DefineCodeName[0]);
            gxdynajaxctrldescr.Add(H003U4_A168XT_DefineCodeName[0]);
            pr_default.readNext(2);
         }
         pr_default.close(2);
      }

      protected void GXDLVBR_DEMOGRAPHICS_BR_DEMOGRAPHICS_EDUCATION3U2( decimal AV32Tcurrentcode )
      {
         if ( ! context.isAjaxRequest( ) )
         {
            context.GX_webresponse.AppendHeader("Cache-Control", "no-store");
         }
         context.GX_webresponse.AddString("[[");
         GXDLVBR_DEMOGRAPHICS_BR_DEMOGRAPHICS_EDUCATION_data3U2( AV32Tcurrentcode) ;
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

      protected void GXVBR_DEMOGRAPHICS_BR_DEMOGRAPHICS_EDUCATION_html3U2( decimal AV32Tcurrentcode )
      {
         String gxdynajaxvalue ;
         GXDLVBR_DEMOGRAPHICS_BR_DEMOGRAPHICS_EDUCATION_data3U2( AV32Tcurrentcode) ;
         gxdynajaxindex = 1;
         if ( ! ( gxdyncontrolsrefreshing && context.isAjaxRequest( ) ) )
         {
            dynavBr_demographics_br_demographics_education.removeAllItems();
         }
         while ( gxdynajaxindex <= gxdynajaxctrlcodr.Count )
         {
            gxdynajaxvalue = ((String)gxdynajaxctrlcodr.Item(gxdynajaxindex));
            dynavBr_demographics_br_demographics_education.addItem(gxdynajaxvalue, ((String)gxdynajaxctrldescr.Item(gxdynajaxindex)), 0);
            gxdynajaxindex = (int)(gxdynajaxindex+1);
         }
      }

      protected void GXDLVBR_DEMOGRAPHICS_BR_DEMOGRAPHICS_EDUCATION_data3U2( decimal AV32Tcurrentcode )
      {
         gxdynajaxctrlcodr.Clear();
         gxdynajaxctrldescr.Clear();
         gxdynajaxctrlcodr.Add("");
         gxdynajaxctrldescr.Add("(请选择)");
         /* Using cursor H003U5 */
         pr_default.execute(3, new Object[] {AV32Tcurrentcode});
         while ( (pr_default.getStatus(3) != 101) )
         {
            gxdynajaxctrlcodr.Add(H003U5_A168XT_DefineCodeName[0]);
            gxdynajaxctrldescr.Add(H003U5_A168XT_DefineCodeName[0]);
            pr_default.readNext(3);
         }
         pr_default.close(3);
      }

      protected void GXDLVBR_DEMOGRAPHICS_BR_DEMOGRAPHICS_INSURANCE3U2( decimal AV32Tcurrentcode )
      {
         if ( ! context.isAjaxRequest( ) )
         {
            context.GX_webresponse.AppendHeader("Cache-Control", "no-store");
         }
         context.GX_webresponse.AddString("[[");
         GXDLVBR_DEMOGRAPHICS_BR_DEMOGRAPHICS_INSURANCE_data3U2( AV32Tcurrentcode) ;
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

      protected void GXVBR_DEMOGRAPHICS_BR_DEMOGRAPHICS_INSURANCE_html3U2( decimal AV32Tcurrentcode )
      {
         String gxdynajaxvalue ;
         GXDLVBR_DEMOGRAPHICS_BR_DEMOGRAPHICS_INSURANCE_data3U2( AV32Tcurrentcode) ;
         gxdynajaxindex = 1;
         if ( ! ( gxdyncontrolsrefreshing && context.isAjaxRequest( ) ) )
         {
            dynavBr_demographics_br_demographics_insurance.removeAllItems();
         }
         while ( gxdynajaxindex <= gxdynajaxctrlcodr.Count )
         {
            gxdynajaxvalue = ((String)gxdynajaxctrlcodr.Item(gxdynajaxindex));
            dynavBr_demographics_br_demographics_insurance.addItem(gxdynajaxvalue, ((String)gxdynajaxctrldescr.Item(gxdynajaxindex)), 0);
            gxdynajaxindex = (int)(gxdynajaxindex+1);
         }
      }

      protected void GXDLVBR_DEMOGRAPHICS_BR_DEMOGRAPHICS_INSURANCE_data3U2( decimal AV32Tcurrentcode )
      {
         gxdynajaxctrlcodr.Clear();
         gxdynajaxctrldescr.Clear();
         gxdynajaxctrlcodr.Add("");
         gxdynajaxctrldescr.Add("(请选择)");
         /* Using cursor H003U6 */
         pr_default.execute(4, new Object[] {AV32Tcurrentcode});
         while ( (pr_default.getStatus(4) != 101) )
         {
            gxdynajaxctrlcodr.Add(H003U6_A168XT_DefineCodeName[0]);
            gxdynajaxctrldescr.Add(H003U6_A168XT_DefineCodeName[0]);
            pr_default.readNext(4);
         }
         pr_default.close(4);
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
         if ( dynavBr_demographics_br_demographics_sex.ItemCount > 0 )
         {
            AV13BR_Demographics.gxTpr_Br_demographics_sex = dynavBr_demographics_br_demographics_sex.getValidValue(AV13BR_Demographics.gxTpr_Br_demographics_sex);
         }
         if ( context.isAjaxRequest( ) )
         {
            dynavBr_demographics_br_demographics_sex.CurrentValue = StringUtil.RTrim( AV13BR_Demographics.gxTpr_Br_demographics_sex);
            context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, dynavBr_demographics_br_demographics_sex_Internalname, "Values", dynavBr_demographics_br_demographics_sex.ToJavascriptSource(), true);
         }
         if ( dynavBr_demographics_br_demographics_ethnic.ItemCount > 0 )
         {
            AV13BR_Demographics.gxTpr_Br_demographics_ethnic = dynavBr_demographics_br_demographics_ethnic.getValidValue(AV13BR_Demographics.gxTpr_Br_demographics_ethnic);
         }
         if ( context.isAjaxRequest( ) )
         {
            dynavBr_demographics_br_demographics_ethnic.CurrentValue = StringUtil.RTrim( AV13BR_Demographics.gxTpr_Br_demographics_ethnic);
            context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, dynavBr_demographics_br_demographics_ethnic_Internalname, "Values", dynavBr_demographics_br_demographics_ethnic.ToJavascriptSource(), true);
         }
         if ( dynavBr_demographics_br_demographics_marritalstatus.ItemCount > 0 )
         {
            AV13BR_Demographics.gxTpr_Br_demographics_marritalstatus = dynavBr_demographics_br_demographics_marritalstatus.getValidValue(AV13BR_Demographics.gxTpr_Br_demographics_marritalstatus);
         }
         if ( context.isAjaxRequest( ) )
         {
            dynavBr_demographics_br_demographics_marritalstatus.CurrentValue = StringUtil.RTrim( AV13BR_Demographics.gxTpr_Br_demographics_marritalstatus);
            context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, dynavBr_demographics_br_demographics_marritalstatus_Internalname, "Values", dynavBr_demographics_br_demographics_marritalstatus.ToJavascriptSource(), true);
         }
         if ( dynavBr_demographics_br_demographics_education.ItemCount > 0 )
         {
            AV13BR_Demographics.gxTpr_Br_demographics_education = dynavBr_demographics_br_demographics_education.getValidValue(AV13BR_Demographics.gxTpr_Br_demographics_education);
         }
         if ( context.isAjaxRequest( ) )
         {
            dynavBr_demographics_br_demographics_education.CurrentValue = StringUtil.RTrim( AV13BR_Demographics.gxTpr_Br_demographics_education);
            context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, dynavBr_demographics_br_demographics_education_Internalname, "Values", dynavBr_demographics_br_demographics_education.ToJavascriptSource(), true);
         }
         if ( dynavBr_demographics_br_demographics_insurance.ItemCount > 0 )
         {
            AV13BR_Demographics.gxTpr_Br_demographics_insurance = dynavBr_demographics_br_demographics_insurance.getValidValue(AV13BR_Demographics.gxTpr_Br_demographics_insurance);
         }
         if ( context.isAjaxRequest( ) )
         {
            dynavBr_demographics_br_demographics_insurance.CurrentValue = StringUtil.RTrim( AV13BR_Demographics.gxTpr_Br_demographics_insurance);
            context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, dynavBr_demographics_br_demographics_insurance_Internalname, "Values", dynavBr_demographics_br_demographics_insurance.ToJavascriptSource(), true);
         }
      }

      public void Refresh( )
      {
         send_integrity_hashes( ) ;
         RF3U2( ) ;
         if ( isFullAjaxMode( ) )
         {
            send_integrity_footer_hashes( ) ;
         }
      }

      protected void initialize_formulas( )
      {
         /* GeneXus formulas. */
         AV31Pgmname = "BR_EncounterCheckDemographics";
         context.Gx_err = 0;
         dynavBr_demographics_br_demographics_sex.Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, dynavBr_demographics_br_demographics_sex_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(dynavBr_demographics_br_demographics_sex.Enabled), 5, 0)), true);
         edtavBr_demographics_br_demographics_birthdate_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavBr_demographics_br_demographics_birthdate_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavBr_demographics_br_demographics_birthdate_Enabled), 5, 0)), true);
         dynavBr_demographics_br_demographics_ethnic.Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, dynavBr_demographics_br_demographics_ethnic_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(dynavBr_demographics_br_demographics_ethnic.Enabled), 5, 0)), true);
         dynavBr_demographics_br_demographics_marritalstatus.Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, dynavBr_demographics_br_demographics_marritalstatus_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(dynavBr_demographics_br_demographics_marritalstatus.Enabled), 5, 0)), true);
         dynavBr_demographics_br_demographics_education.Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, dynavBr_demographics_br_demographics_education_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(dynavBr_demographics_br_demographics_education.Enabled), 5, 0)), true);
         edtavBr_demographics_br_demographics_occupation_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavBr_demographics_br_demographics_occupation_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavBr_demographics_br_demographics_occupation_Enabled), 5, 0)), true);
         edtavBr_demographics_br_demographics_province_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavBr_demographics_br_demographics_province_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavBr_demographics_br_demographics_province_Enabled), 5, 0)), true);
         edtavBr_demographics_br_demographics_city_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavBr_demographics_br_demographics_city_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavBr_demographics_br_demographics_city_Enabled), 5, 0)), true);
         dynavBr_demographics_br_demographics_insurance.Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, dynavBr_demographics_br_demographics_insurance_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(dynavBr_demographics_br_demographics_insurance.Enabled), 5, 0)), true);
      }

      protected void RF3U2( )
      {
         initialize_formulas( ) ;
         clear_multi_value_controls( ) ;
         gxdyncontrolsrefreshing = true;
         fix_multi_value_controls( ) ;
         gxdyncontrolsrefreshing = false;
         if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
         {
            /* Execute user event: Load */
            E123U2 ();
            WB3U0( ) ;
         }
      }

      protected void send_integrity_lvl_hashes3U2( )
      {
      }

      protected void STRUP3U0( )
      {
         /* Before Start, stand alone formulas. */
         AV31Pgmname = "BR_EncounterCheckDemographics";
         context.Gx_err = 0;
         dynavBr_demographics_br_demographics_sex.Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, dynavBr_demographics_br_demographics_sex_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(dynavBr_demographics_br_demographics_sex.Enabled), 5, 0)), true);
         edtavBr_demographics_br_demographics_birthdate_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavBr_demographics_br_demographics_birthdate_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavBr_demographics_br_demographics_birthdate_Enabled), 5, 0)), true);
         dynavBr_demographics_br_demographics_ethnic.Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, dynavBr_demographics_br_demographics_ethnic_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(dynavBr_demographics_br_demographics_ethnic.Enabled), 5, 0)), true);
         dynavBr_demographics_br_demographics_marritalstatus.Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, dynavBr_demographics_br_demographics_marritalstatus_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(dynavBr_demographics_br_demographics_marritalstatus.Enabled), 5, 0)), true);
         dynavBr_demographics_br_demographics_education.Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, dynavBr_demographics_br_demographics_education_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(dynavBr_demographics_br_demographics_education.Enabled), 5, 0)), true);
         edtavBr_demographics_br_demographics_occupation_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavBr_demographics_br_demographics_occupation_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavBr_demographics_br_demographics_occupation_Enabled), 5, 0)), true);
         edtavBr_demographics_br_demographics_province_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavBr_demographics_br_demographics_province_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavBr_demographics_br_demographics_province_Enabled), 5, 0)), true);
         edtavBr_demographics_br_demographics_city_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavBr_demographics_br_demographics_city_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavBr_demographics_br_demographics_city_Enabled), 5, 0)), true);
         dynavBr_demographics_br_demographics_insurance.Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, dynavBr_demographics_br_demographics_insurance_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(dynavBr_demographics_br_demographics_insurance.Enabled), 5, 0)), true);
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0;
         /* Execute user event: Start */
         E113U2 ();
         context.wbGlbDoneStart = 1;
         nDoneStart = 1;
         /* After Start, stand alone formulas. */
         sXEvt = cgiGet( "_EventName");
         if ( ! GetJustCreated( ) && ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 ) )
         {
            /* Read saved SDTs. */
            ajax_req_read_hidden_sdt(cgiGet( sPrefix+"Br_demographics"), AV13BR_Demographics);
            /* Read variables values. */
            dynavBr_demographics_br_demographics_sex.CurrentValue = cgiGet( dynavBr_demographics_br_demographics_sex_Internalname);
            AV13BR_Demographics.gxTpr_Br_demographics_sex = cgiGet( dynavBr_demographics_br_demographics_sex_Internalname);
            if ( context.localUtil.VCDate( cgiGet( edtavBr_demographics_br_demographics_birthdate_Internalname), 0) == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_faildate", new   object[]  {"出生日期"}), 1, "BR_DEMOGRAPHICS_BR_DEMOGRAPHICS_BIRTHDATE");
               GX_FocusControl = edtavBr_demographics_br_demographics_birthdate_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV13BR_Demographics.gxTpr_Br_demographics_birthdate = DateTime.MinValue;
            }
            else
            {
               AV13BR_Demographics.gxTpr_Br_demographics_birthdate = context.localUtil.CToD( cgiGet( edtavBr_demographics_br_demographics_birthdate_Internalname), 0);
            }
            dynavBr_demographics_br_demographics_ethnic.CurrentValue = cgiGet( dynavBr_demographics_br_demographics_ethnic_Internalname);
            AV13BR_Demographics.gxTpr_Br_demographics_ethnic = cgiGet( dynavBr_demographics_br_demographics_ethnic_Internalname);
            dynavBr_demographics_br_demographics_marritalstatus.CurrentValue = cgiGet( dynavBr_demographics_br_demographics_marritalstatus_Internalname);
            AV13BR_Demographics.gxTpr_Br_demographics_marritalstatus = cgiGet( dynavBr_demographics_br_demographics_marritalstatus_Internalname);
            dynavBr_demographics_br_demographics_education.CurrentValue = cgiGet( dynavBr_demographics_br_demographics_education_Internalname);
            AV13BR_Demographics.gxTpr_Br_demographics_education = cgiGet( dynavBr_demographics_br_demographics_education_Internalname);
            AV13BR_Demographics.gxTpr_Br_demographics_occupation = cgiGet( edtavBr_demographics_br_demographics_occupation_Internalname);
            AV13BR_Demographics.gxTpr_Br_demographics_province = cgiGet( edtavBr_demographics_br_demographics_province_Internalname);
            AV13BR_Demographics.gxTpr_Br_demographics_city = cgiGet( edtavBr_demographics_br_demographics_city_Internalname);
            dynavBr_demographics_br_demographics_insurance.CurrentValue = cgiGet( dynavBr_demographics_br_demographics_insurance_Internalname);
            AV13BR_Demographics.gxTpr_Br_demographics_insurance = cgiGet( dynavBr_demographics_br_demographics_insurance_Internalname);
            if ( ( ( context.localUtil.CToN( cgiGet( edtavBr_demographics_br_demographics_id_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavBr_demographics_br_demographics_id_Internalname), ".", ",") > Convert.ToDecimal( 999999999999999999L )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "BR_DEMOGRAPHICS_BR_DEMOGRAPHICS_ID");
               GX_FocusControl = edtavBr_demographics_br_demographics_id_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV13BR_Demographics.gxTpr_Br_demographics_id = 0;
            }
            else
            {
               AV13BR_Demographics.gxTpr_Br_demographics_id = (long)(context.localUtil.CToN( cgiGet( edtavBr_demographics_br_demographics_id_Internalname), ".", ","));
            }
            if ( ( ( context.localUtil.CToN( cgiGet( edtavBr_demographics_br_encounterid_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavBr_demographics_br_encounterid_Internalname), ".", ",") > Convert.ToDecimal( 999999999999999999L )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "BR_DEMOGRAPHICS_BR_ENCOUNTERID");
               GX_FocusControl = edtavBr_demographics_br_encounterid_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV13BR_Demographics.gxTpr_Br_encounterid = 0;
            }
            else
            {
               AV13BR_Demographics.gxTpr_Br_encounterid = (long)(context.localUtil.CToN( cgiGet( edtavBr_demographics_br_encounterid_Internalname), ".", ","));
            }
            AV13BR_Demographics.gxTpr_Br_information_patientno = cgiGet( edtavBr_demographics_br_information_patientno_Internalname);
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
         E113U2 ();
         if (returnInSub) return;
      }

      protected void E113U2( )
      {
         /* Start Routine */
         /* Using cursor H003U7 */
         pr_default.execute(5, new Object[] {A19BR_EncounterID});
         while ( (pr_default.getStatus(5) != 101) )
         {
            A61BR_Demographics_ID = H003U7_A61BR_Demographics_ID[0];
            AV13BR_Demographics.Load(A61BR_Demographics_ID);
            /* Exit For each command. Update data (if necessary), close cursors & exit. */
            if (true) break;
            pr_default.readNext(5);
         }
         pr_default.close(5);
         new GeneXus.Programs.wwpbaseobjects.loadwwpcontext(context ).execute( out  AV6WWPContext) ;
         /* Execute user subroutine: 'PREPARETRANSACTION' */
         S112 ();
         if (returnInSub) return;
      }

      protected void nextLoad( )
      {
      }

      protected void E123U2( )
      {
         /* Load Routine */
         edtavBr_demographics_br_demographics_id_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavBr_demographics_br_demographics_id_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavBr_demographics_br_demographics_id_Visible), 5, 0)), true);
         edtavBr_demographics_br_encounterid_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavBr_demographics_br_encounterid_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavBr_demographics_br_encounterid_Visible), 5, 0)), true);
         edtavBr_demographics_br_information_patientno_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavBr_demographics_br_information_patientno_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavBr_demographics_br_information_patientno_Visible), 5, 0)), true);
      }

      protected void S112( )
      {
         /* 'PREPARETRANSACTION' Routine */
         AV9TrnContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext(context);
         AV9TrnContext.gxTpr_Callerobject = AV31Pgmname;
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
         PA3U2( ) ;
         WS3U2( ) ;
         WE3U2( ) ;
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
         PA3U2( ) ;
         WCParametersGet( ) ;
      }

      public override void componentprepare( Object[] obj )
      {
         wbLoad = false;
         sCompPrefix = (String)getParm(obj,0);
         sSFPrefix = (String)getParm(obj,1);
         sPrefix = sCompPrefix + sSFPrefix;
         AddComponentObject(sPrefix, "br_encountercheckdemographics", GetJustCreated( ));
         if ( ( nDoneStart == 0 ) && ( nDynComponent == 0 ) )
         {
            INITWEB( ) ;
         }
         else
         {
            init_default_properties( ) ;
            init_web_controls( ) ;
         }
         PA3U2( ) ;
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
         PA3U2( ) ;
         sEvt = sCompEvt;
         WCParametersGet( ) ;
         WS3U2( ) ;
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
         WS3U2( ) ;
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
         WE3U2( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?2020227936374", true);
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
            context.AddJavascriptSource("br_encountercheckdemographics.js", "?2020227936374", false);
         }
         /* End function include_jscripts */
      }

      protected void init_web_controls( )
      {
         dynavBr_demographics_br_demographics_sex.Name = "BR_DEMOGRAPHICS_BR_DEMOGRAPHICS_SEX";
         dynavBr_demographics_br_demographics_sex.WebTags = "";
         dynavBr_demographics_br_demographics_ethnic.Name = "BR_DEMOGRAPHICS_BR_DEMOGRAPHICS_ETHNIC";
         dynavBr_demographics_br_demographics_ethnic.WebTags = "";
         dynavBr_demographics_br_demographics_marritalstatus.Name = "BR_DEMOGRAPHICS_BR_DEMOGRAPHICS_MARRITALSTATUS";
         dynavBr_demographics_br_demographics_marritalstatus.WebTags = "";
         dynavBr_demographics_br_demographics_education.Name = "BR_DEMOGRAPHICS_BR_DEMOGRAPHICS_EDUCATION";
         dynavBr_demographics_br_demographics_education.WebTags = "";
         dynavBr_demographics_br_demographics_insurance.Name = "BR_DEMOGRAPHICS_BR_DEMOGRAPHICS_INSURANCE";
         dynavBr_demographics_br_demographics_insurance.WebTags = "";
         /* End function init_web_controls */
      }

      protected void init_default_properties( )
      {
         dynavBr_demographics_br_demographics_sex_Internalname = sPrefix+"BR_DEMOGRAPHICS_BR_DEMOGRAPHICS_SEX";
         edtavBr_demographics_br_demographics_birthdate_Internalname = sPrefix+"BR_DEMOGRAPHICS_BR_DEMOGRAPHICS_BIRTHDATE";
         dynavBr_demographics_br_demographics_ethnic_Internalname = sPrefix+"BR_DEMOGRAPHICS_BR_DEMOGRAPHICS_ETHNIC";
         dynavBr_demographics_br_demographics_marritalstatus_Internalname = sPrefix+"BR_DEMOGRAPHICS_BR_DEMOGRAPHICS_MARRITALSTATUS";
         dynavBr_demographics_br_demographics_education_Internalname = sPrefix+"BR_DEMOGRAPHICS_BR_DEMOGRAPHICS_EDUCATION";
         edtavBr_demographics_br_demographics_occupation_Internalname = sPrefix+"BR_DEMOGRAPHICS_BR_DEMOGRAPHICS_OCCUPATION";
         edtavBr_demographics_br_demographics_province_Internalname = sPrefix+"BR_DEMOGRAPHICS_BR_DEMOGRAPHICS_PROVINCE";
         edtavBr_demographics_br_demographics_city_Internalname = sPrefix+"BR_DEMOGRAPHICS_BR_DEMOGRAPHICS_CITY";
         dynavBr_demographics_br_demographics_insurance_Internalname = sPrefix+"BR_DEMOGRAPHICS_BR_DEMOGRAPHICS_INSURANCE";
         divUnnamedtable1_Internalname = sPrefix+"UNNAMEDTABLE1";
         edtavBr_demographics_br_demographics_id_Internalname = sPrefix+"BR_DEMOGRAPHICS_BR_DEMOGRAPHICS_ID";
         edtavBr_demographics_br_encounterid_Internalname = sPrefix+"BR_DEMOGRAPHICS_BR_ENCOUNTERID";
         edtavBr_demographics_br_information_patientno_Internalname = sPrefix+"BR_DEMOGRAPHICS_BR_INFORMATION_PATIENTNO";
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
         edtavBr_demographics_br_information_patientno_Jsonclick = "";
         edtavBr_demographics_br_information_patientno_Visible = 1;
         edtavBr_demographics_br_encounterid_Jsonclick = "";
         edtavBr_demographics_br_encounterid_Visible = 1;
         edtavBr_demographics_br_demographics_id_Jsonclick = "";
         edtavBr_demographics_br_demographics_id_Visible = 1;
         dynavBr_demographics_br_demographics_insurance_Jsonclick = "";
         dynavBr_demographics_br_demographics_insurance.Enabled = 0;
         edtavBr_demographics_br_demographics_city_Jsonclick = "";
         edtavBr_demographics_br_demographics_city_Enabled = 0;
         edtavBr_demographics_br_demographics_province_Jsonclick = "";
         edtavBr_demographics_br_demographics_province_Enabled = 0;
         edtavBr_demographics_br_demographics_occupation_Jsonclick = "";
         edtavBr_demographics_br_demographics_occupation_Enabled = 0;
         dynavBr_demographics_br_demographics_education_Jsonclick = "";
         dynavBr_demographics_br_demographics_education.Enabled = 0;
         dynavBr_demographics_br_demographics_marritalstatus_Jsonclick = "";
         dynavBr_demographics_br_demographics_marritalstatus.Enabled = 0;
         dynavBr_demographics_br_demographics_ethnic_Jsonclick = "";
         dynavBr_demographics_br_demographics_ethnic.Enabled = 0;
         edtavBr_demographics_br_demographics_birthdate_Jsonclick = "";
         edtavBr_demographics_br_demographics_birthdate_Enabled = 0;
         dynavBr_demographics_br_demographics_sex_Jsonclick = "";
         dynavBr_demographics_br_demographics_sex.Enabled = 0;
         dynavBr_demographics_br_demographics_insurance.Enabled = -1;
         edtavBr_demographics_br_demographics_city_Enabled = -1;
         edtavBr_demographics_br_demographics_province_Enabled = -1;
         edtavBr_demographics_br_demographics_occupation_Enabled = -1;
         dynavBr_demographics_br_demographics_education.Enabled = -1;
         dynavBr_demographics_br_demographics_marritalstatus.Enabled = -1;
         dynavBr_demographics_br_demographics_ethnic.Enabled = -1;
         edtavBr_demographics_br_demographics_birthdate_Enabled = -1;
         dynavBr_demographics_br_demographics_sex.Enabled = -1;
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
         AV31Pgmname = "";
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         GXKey = "";
         AV13BR_Demographics = new SdtBR_Demographics(context);
         GX_FocusControl = "";
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
         H003U2_A167XT_DefineCodeID = new long[1] ;
         H003U2_A168XT_DefineCodeName = new String[] {""} ;
         H003U2_n168XT_DefineCodeName = new bool[] {false} ;
         H003U2_A165XT_DefindcodeTypeID = new long[1] ;
         H003U2_A432XT_TenantCode = new String[] {""} ;
         H003U2_n432XT_TenantCode = new bool[] {false} ;
         H003U3_A167XT_DefineCodeID = new long[1] ;
         H003U3_A168XT_DefineCodeName = new String[] {""} ;
         H003U3_n168XT_DefineCodeName = new bool[] {false} ;
         H003U3_A165XT_DefindcodeTypeID = new long[1] ;
         H003U3_A432XT_TenantCode = new String[] {""} ;
         H003U3_n432XT_TenantCode = new bool[] {false} ;
         H003U4_A167XT_DefineCodeID = new long[1] ;
         H003U4_A168XT_DefineCodeName = new String[] {""} ;
         H003U4_n168XT_DefineCodeName = new bool[] {false} ;
         H003U4_A165XT_DefindcodeTypeID = new long[1] ;
         H003U4_A432XT_TenantCode = new String[] {""} ;
         H003U4_n432XT_TenantCode = new bool[] {false} ;
         H003U5_A167XT_DefineCodeID = new long[1] ;
         H003U5_A168XT_DefineCodeName = new String[] {""} ;
         H003U5_n168XT_DefineCodeName = new bool[] {false} ;
         H003U5_A165XT_DefindcodeTypeID = new long[1] ;
         H003U5_A432XT_TenantCode = new String[] {""} ;
         H003U5_n432XT_TenantCode = new bool[] {false} ;
         H003U6_A167XT_DefineCodeID = new long[1] ;
         H003U6_A168XT_DefineCodeName = new String[] {""} ;
         H003U6_n168XT_DefineCodeName = new bool[] {false} ;
         H003U6_A165XT_DefindcodeTypeID = new long[1] ;
         H003U6_A432XT_TenantCode = new String[] {""} ;
         H003U6_n432XT_TenantCode = new bool[] {false} ;
         H003U7_A19BR_EncounterID = new long[1] ;
         H003U7_A61BR_Demographics_ID = new long[1] ;
         AV6WWPContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPContext(context);
         AV9TrnContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext(context);
         AV12HTTPRequest = new GxHttpRequest( context);
         AV10TrnContextAtt = new GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext_Attribute(context);
         AV11Session = context.GetSession();
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         sCtrlA19BR_EncounterID = "";
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.br_encountercheckdemographics__default(),
            new Object[][] {
                new Object[] {
               H003U2_A167XT_DefineCodeID, H003U2_A168XT_DefineCodeName, H003U2_n168XT_DefineCodeName, H003U2_A165XT_DefindcodeTypeID, H003U2_A432XT_TenantCode, H003U2_n432XT_TenantCode
               }
               , new Object[] {
               H003U3_A167XT_DefineCodeID, H003U3_A168XT_DefineCodeName, H003U3_n168XT_DefineCodeName, H003U3_A165XT_DefindcodeTypeID, H003U3_A432XT_TenantCode, H003U3_n432XT_TenantCode
               }
               , new Object[] {
               H003U4_A167XT_DefineCodeID, H003U4_A168XT_DefineCodeName, H003U4_n168XT_DefineCodeName, H003U4_A165XT_DefindcodeTypeID, H003U4_A432XT_TenantCode, H003U4_n432XT_TenantCode
               }
               , new Object[] {
               H003U5_A167XT_DefineCodeID, H003U5_A168XT_DefineCodeName, H003U5_n168XT_DefineCodeName, H003U5_A165XT_DefindcodeTypeID, H003U5_A432XT_TenantCode, H003U5_n432XT_TenantCode
               }
               , new Object[] {
               H003U6_A167XT_DefineCodeID, H003U6_A168XT_DefineCodeName, H003U6_n168XT_DefineCodeName, H003U6_A165XT_DefindcodeTypeID, H003U6_A432XT_TenantCode, H003U6_n432XT_TenantCode
               }
               , new Object[] {
               H003U7_A19BR_EncounterID, H003U7_A61BR_Demographics_ID
               }
            }
         );
         AV31Pgmname = "BR_EncounterCheckDemographics";
         /* GeneXus formulas. */
         AV31Pgmname = "BR_EncounterCheckDemographics";
         context.Gx_err = 0;
         dynavBr_demographics_br_demographics_sex.Enabled = 0;
         edtavBr_demographics_br_demographics_birthdate_Enabled = 0;
         dynavBr_demographics_br_demographics_ethnic.Enabled = 0;
         dynavBr_demographics_br_demographics_marritalstatus.Enabled = 0;
         dynavBr_demographics_br_demographics_education.Enabled = 0;
         edtavBr_demographics_br_demographics_occupation_Enabled = 0;
         edtavBr_demographics_br_demographics_province_Enabled = 0;
         edtavBr_demographics_br_demographics_city_Enabled = 0;
         dynavBr_demographics_br_demographics_insurance.Enabled = 0;
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
      private int edtavBr_demographics_br_demographics_birthdate_Enabled ;
      private int edtavBr_demographics_br_demographics_occupation_Enabled ;
      private int edtavBr_demographics_br_demographics_province_Enabled ;
      private int edtavBr_demographics_br_demographics_city_Enabled ;
      private int edtavBr_demographics_br_demographics_id_Visible ;
      private int edtavBr_demographics_br_encounterid_Visible ;
      private int edtavBr_demographics_br_information_patientno_Visible ;
      private int gxdynajaxindex ;
      private int idxLst ;
      private long A19BR_EncounterID ;
      private long wcpOA19BR_EncounterID ;
      private long A61BR_Demographics_ID ;
      private long AV8BR_EncounterID ;
      private decimal AV32Tcurrentcode ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String sPrefix ;
      private String sCompPrefix ;
      private String sSFPrefix ;
      private String AV31Pgmname ;
      private String dynavBr_demographics_br_demographics_sex_Internalname ;
      private String edtavBr_demographics_br_demographics_birthdate_Internalname ;
      private String dynavBr_demographics_br_demographics_ethnic_Internalname ;
      private String dynavBr_demographics_br_demographics_marritalstatus_Internalname ;
      private String dynavBr_demographics_br_demographics_education_Internalname ;
      private String edtavBr_demographics_br_demographics_occupation_Internalname ;
      private String edtavBr_demographics_br_demographics_province_Internalname ;
      private String edtavBr_demographics_br_demographics_city_Internalname ;
      private String dynavBr_demographics_br_demographics_insurance_Internalname ;
      private String sDynURL ;
      private String FormProcess ;
      private String bodyStyle ;
      private String GXKey ;
      private String GX_FocusControl ;
      private String divLayoutmaintable_Internalname ;
      private String divUnnamedtable1_Internalname ;
      private String dynavBr_demographics_br_demographics_sex_Jsonclick ;
      private String edtavBr_demographics_br_demographics_birthdate_Jsonclick ;
      private String dynavBr_demographics_br_demographics_ethnic_Jsonclick ;
      private String dynavBr_demographics_br_demographics_marritalstatus_Jsonclick ;
      private String dynavBr_demographics_br_demographics_education_Jsonclick ;
      private String edtavBr_demographics_br_demographics_occupation_Jsonclick ;
      private String edtavBr_demographics_br_demographics_province_Jsonclick ;
      private String edtavBr_demographics_br_demographics_city_Jsonclick ;
      private String dynavBr_demographics_br_demographics_insurance_Jsonclick ;
      private String divHtml_bottomauxiliarcontrols_Internalname ;
      private String TempTags ;
      private String edtavBr_demographics_br_demographics_id_Internalname ;
      private String edtavBr_demographics_br_demographics_id_Jsonclick ;
      private String edtavBr_demographics_br_encounterid_Internalname ;
      private String edtavBr_demographics_br_encounterid_Jsonclick ;
      private String edtavBr_demographics_br_information_patientno_Internalname ;
      private String edtavBr_demographics_br_information_patientno_Jsonclick ;
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
      private GXCombobox dynavBr_demographics_br_demographics_sex ;
      private GXCombobox dynavBr_demographics_br_demographics_ethnic ;
      private GXCombobox dynavBr_demographics_br_demographics_marritalstatus ;
      private GXCombobox dynavBr_demographics_br_demographics_education ;
      private GXCombobox dynavBr_demographics_br_demographics_insurance ;
      private IDataStoreProvider pr_default ;
      private long[] H003U2_A167XT_DefineCodeID ;
      private String[] H003U2_A168XT_DefineCodeName ;
      private bool[] H003U2_n168XT_DefineCodeName ;
      private long[] H003U2_A165XT_DefindcodeTypeID ;
      private String[] H003U2_A432XT_TenantCode ;
      private bool[] H003U2_n432XT_TenantCode ;
      private long[] H003U3_A167XT_DefineCodeID ;
      private String[] H003U3_A168XT_DefineCodeName ;
      private bool[] H003U3_n168XT_DefineCodeName ;
      private long[] H003U3_A165XT_DefindcodeTypeID ;
      private String[] H003U3_A432XT_TenantCode ;
      private bool[] H003U3_n432XT_TenantCode ;
      private long[] H003U4_A167XT_DefineCodeID ;
      private String[] H003U4_A168XT_DefineCodeName ;
      private bool[] H003U4_n168XT_DefineCodeName ;
      private long[] H003U4_A165XT_DefindcodeTypeID ;
      private String[] H003U4_A432XT_TenantCode ;
      private bool[] H003U4_n432XT_TenantCode ;
      private long[] H003U5_A167XT_DefineCodeID ;
      private String[] H003U5_A168XT_DefineCodeName ;
      private bool[] H003U5_n168XT_DefineCodeName ;
      private long[] H003U5_A165XT_DefindcodeTypeID ;
      private String[] H003U5_A432XT_TenantCode ;
      private bool[] H003U5_n432XT_TenantCode ;
      private long[] H003U6_A167XT_DefineCodeID ;
      private String[] H003U6_A168XT_DefineCodeName ;
      private bool[] H003U6_n168XT_DefineCodeName ;
      private long[] H003U6_A165XT_DefindcodeTypeID ;
      private String[] H003U6_A432XT_TenantCode ;
      private bool[] H003U6_n432XT_TenantCode ;
      private long[] H003U7_A19BR_EncounterID ;
      private long[] H003U7_A61BR_Demographics_ID ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private GxHttpRequest AV12HTTPRequest ;
      private IGxSession AV11Session ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPContext AV6WWPContext ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext AV9TrnContext ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext_Attribute AV10TrnContextAtt ;
      private SdtBR_Demographics AV13BR_Demographics ;
   }

   public class br_encountercheckdemographics__default : DataStoreHelperBase, IDataStoreHelper
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
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmH003U2 ;
          prmH003U2 = new Object[] {
          new Object[] {"@AV32Tcurrentcode",SqlDbType.Decimal,10,2}
          } ;
          Object[] prmH003U3 ;
          prmH003U3 = new Object[] {
          new Object[] {"@AV32Tcurrentcode",SqlDbType.Decimal,10,2}
          } ;
          Object[] prmH003U4 ;
          prmH003U4 = new Object[] {
          new Object[] {"@AV32Tcurrentcode",SqlDbType.Decimal,10,2}
          } ;
          Object[] prmH003U5 ;
          prmH003U5 = new Object[] {
          new Object[] {"@AV32Tcurrentcode",SqlDbType.Decimal,10,2}
          } ;
          Object[] prmH003U6 ;
          prmH003U6 = new Object[] {
          new Object[] {"@AV32Tcurrentcode",SqlDbType.Decimal,10,2}
          } ;
          Object[] prmH003U7 ;
          prmH003U7 = new Object[] {
          new Object[] {"@BR_EncounterID",SqlDbType.Decimal,18,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("H003U2", "SELECT [XT_DefineCodeID], [XT_DefineCodeName], [XT_DefindcodeTypeID], [XT_TenantCode] FROM [XT_DefineCode] WITH (NOLOCK) WHERE ([XT_DefindcodeTypeID] = 7) AND ([XT_TenantCode] = @AV32Tcurrentcode) ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH003U2,0,0,true,false )
             ,new CursorDef("H003U3", "SELECT [XT_DefineCodeID], [XT_DefineCodeName], [XT_DefindcodeTypeID], [XT_TenantCode] FROM [XT_DefineCode] WITH (NOLOCK) WHERE ([XT_DefindcodeTypeID] = 9) AND ([XT_TenantCode] = @AV32Tcurrentcode) ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH003U3,0,0,true,false )
             ,new CursorDef("H003U4", "SELECT [XT_DefineCodeID], [XT_DefineCodeName], [XT_DefindcodeTypeID], [XT_TenantCode] FROM [XT_DefineCode] WITH (NOLOCK) WHERE ([XT_DefindcodeTypeID] = 8) AND ([XT_TenantCode] = @AV32Tcurrentcode) ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH003U4,0,0,true,false )
             ,new CursorDef("H003U5", "SELECT [XT_DefineCodeID], [XT_DefineCodeName], [XT_DefindcodeTypeID], [XT_TenantCode] FROM [XT_DefineCode] WITH (NOLOCK) WHERE ([XT_DefindcodeTypeID] = 10) AND ([XT_TenantCode] = @AV32Tcurrentcode) ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH003U5,0,0,true,false )
             ,new CursorDef("H003U6", "SELECT [XT_DefineCodeID], [XT_DefineCodeName], [XT_DefindcodeTypeID], [XT_TenantCode] FROM [XT_DefineCode] WITH (NOLOCK) WHERE ([XT_DefindcodeTypeID] = 11) AND ([XT_TenantCode] = @AV32Tcurrentcode) ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH003U6,0,0,true,false )
             ,new CursorDef("H003U7", "SELECT TOP 1 [BR_EncounterID], [BR_Demographics_ID] FROM [BR_Demographics] WITH (NOLOCK) WHERE [BR_EncounterID] = @BR_EncounterID ORDER BY [BR_EncounterID] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH003U7,1,0,true,true )
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
                stmt.SetParameter(1, (decimal)parms[0]);
                return;
             case 3 :
                stmt.SetParameter(1, (decimal)parms[0]);
                return;
             case 4 :
                stmt.SetParameter(1, (decimal)parms[0]);
                return;
             case 5 :
                stmt.SetParameter(1, (long)parms[0]);
                return;
       }
    }

 }

}
