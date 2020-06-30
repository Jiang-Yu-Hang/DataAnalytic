/*
               File: BR_EncounterCheckBehavior
        Description: Data Mgmt Portal - RAAP
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/27/2020 11:55:46.14
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
   public class br_encountercheckbehavior : GXWebComponent, System.Web.SessionState.IRequiresSessionState
   {
      public br_encountercheckbehavior( )
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

      public br_encountercheckbehavior( IGxContext context )
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
         dynavBr_behavior_br_behavior_smoking = new GXCombobox();
         dynavBr_behavior_br_behavior_achohol = new GXCombobox();
         cmbavBr_behavior_br_behavior_familycahistory = new GXCombobox();
         cmbavBr_behavior_br_behavior_menopause = new GXCombobox();
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
               else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxCallCrl"+"_"+"BR_BEHAVIOR_BR_BEHAVIOR_SMOKING") == 0 )
               {
                  AV39Tcurrentcode = NumberUtil.Val( GetNextPar( ), ".");
                  setAjaxCallMode();
                  if ( ! IsValidAjaxCall( true) )
                  {
                     GxWebError = 1;
                     return  ;
                  }
                  GXDLVBR_BEHAVIOR_BR_BEHAVIOR_SMOKING3V2( AV39Tcurrentcode) ;
                  return  ;
               }
               else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxCallCrl"+"_"+"BR_BEHAVIOR_BR_BEHAVIOR_ACHOHOL") == 0 )
               {
                  AV39Tcurrentcode = NumberUtil.Val( GetNextPar( ), ".");
                  setAjaxCallMode();
                  if ( ! IsValidAjaxCall( true) )
                  {
                     GxWebError = 1;
                     return  ;
                  }
                  GXDLVBR_BEHAVIOR_BR_BEHAVIOR_ACHOHOL3V2( AV39Tcurrentcode) ;
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
            PA3V2( ) ;
            if ( ( GxWebError == 0 ) && ! isAjaxCallMode( ) )
            {
               /* GeneXus formulas. */
               AV38Pgmname = "BR_EncounterCheckBehavior";
               context.Gx_err = 0;
               dynavBr_behavior_br_behavior_smoking.Enabled = 0;
               context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, dynavBr_behavior_br_behavior_smoking_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(dynavBr_behavior_br_behavior_smoking.Enabled), 5, 0)), true);
               edtavBr_behavior_br_behavior_smokingtime_Enabled = 0;
               context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavBr_behavior_br_behavior_smokingtime_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavBr_behavior_br_behavior_smokingtime_Enabled), 5, 0)), true);
               edtavBr_behavior_br_behavior_smokingamount_Enabled = 0;
               context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavBr_behavior_br_behavior_smokingamount_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavBr_behavior_br_behavior_smokingamount_Enabled), 5, 0)), true);
               edtavBr_behavior_br_behavior_rawsmokingamount_Enabled = 0;
               context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavBr_behavior_br_behavior_rawsmokingamount_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavBr_behavior_br_behavior_rawsmokingamount_Enabled), 5, 0)), true);
               dynavBr_behavior_br_behavior_achohol.Enabled = 0;
               context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, dynavBr_behavior_br_behavior_achohol_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(dynavBr_behavior_br_behavior_achohol.Enabled), 5, 0)), true);
               edtavBr_behavior_br_behavior_achoholtime_Enabled = 0;
               context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavBr_behavior_br_behavior_achoholtime_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavBr_behavior_br_behavior_achoholtime_Enabled), 5, 0)), true);
               edtavBr_behavior_br_behavior_achoholamount_Enabled = 0;
               context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavBr_behavior_br_behavior_achoholamount_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavBr_behavior_br_behavior_achoholamount_Enabled), 5, 0)), true);
               edtavBr_behavior_br_behavior_rawachoholamount_Enabled = 0;
               context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavBr_behavior_br_behavior_rawachoholamount_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavBr_behavior_br_behavior_rawachoholamount_Enabled), 5, 0)), true);
               edtavBr_behavior_br_behavior_childnum_Enabled = 0;
               context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavBr_behavior_br_behavior_childnum_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavBr_behavior_br_behavior_childnum_Enabled), 5, 0)), true);
               cmbavBr_behavior_br_behavior_familycahistory.Enabled = 0;
               context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, cmbavBr_behavior_br_behavior_familycahistory_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(cmbavBr_behavior_br_behavior_familycahistory.Enabled), 5, 0)), true);
               edtavBr_behavior_br_behavior_familycancer_Enabled = 0;
               context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavBr_behavior_br_behavior_familycancer_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavBr_behavior_br_behavior_familycancer_Enabled), 5, 0)), true);
               edtavBr_behavior_br_behavior_rawmenopauseage_Enabled = 0;
               context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavBr_behavior_br_behavior_rawmenopauseage_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavBr_behavior_br_behavior_rawmenopauseage_Enabled), 5, 0)), true);
               cmbavBr_behavior_br_behavior_menopause.Enabled = 0;
               context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, cmbavBr_behavior_br_behavior_menopause_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(cmbavBr_behavior_br_behavior_menopause.Enabled), 5, 0)), true);
               edtavBr_behavior_br_behavior_menopauseage_Enabled = 0;
               context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavBr_behavior_br_behavior_menopauseage_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavBr_behavior_br_behavior_menopauseage_Enabled), 5, 0)), true);
               WS3V2( ) ;
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
         context.AddJavascriptSource("gxcfg.js", "?202022711554644", false);
         if ( context.isSpaRequest( ) )
         {
            enableOutput();
         }
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
               context.WriteHtmlTextNl( "<form id=\"MAINFORM\" autocomplete=\"off\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("br_encountercheckbehavior.aspx") + "?" + UrlEncode("" +A19BR_EncounterID)+"\">") ;
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
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, sPrefix+"Br_behavior", AV13BR_Behavior);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt(sPrefix+"Br_behavior", AV13BR_Behavior);
         }
         GxWebStd.gx_hidden_field( context, sPrefix+"wcpOA19BR_EncounterID", StringUtil.LTrim( StringUtil.NToC( (decimal)(wcpOA19BR_EncounterID), 18, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, sPrefix+"BR_ENCOUNTERID", StringUtil.LTrim( StringUtil.NToC( (decimal)(A19BR_EncounterID), 18, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, sPrefix+"vTCURRENTCODE", StringUtil.LTrim( StringUtil.NToC( AV39Tcurrentcode, 10, 2, ".", "")));
      }

      protected void RenderHtmlCloseForm3V2( )
      {
         SendCloseFormHiddens( ) ;
         if ( ( StringUtil.Len( sPrefix) != 0 ) && ( context.isAjaxRequest( ) || context.isSpaRequest( ) ) )
         {
            context.AddJavascriptSource("br_encountercheckbehavior.js", "?202022711554649", false);
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
         return "BR_EncounterCheckBehavior" ;
      }

      public override String GetPgmdesc( )
      {
         return "Data Mgmt Portal - RAAP" ;
      }

      protected void WB3V0( )
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
               GxWebStd.gx_hidden_field( context, sPrefix+"_CMPPGM", "br_encountercheckbehavior.aspx");
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
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+dynavBr_behavior_br_behavior_smoking_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, dynavBr_behavior_br_behavior_smoking_Internalname, "吸烟情况", "col-sm-3 ReadonlyAttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, dynavBr_behavior_br_behavior_smoking, dynavBr_behavior_br_behavior_smoking_Internalname, StringUtil.RTrim( AV13BR_Behavior.gxTpr_Br_behavior_smoking), 1, dynavBr_behavior_br_behavior_smoking_Jsonclick, 0, "'"+sPrefix+"'"+",false,"+"'"+""+"'", "svchar", "", 1, dynavBr_behavior_br_behavior_smoking.Enabled, 0, 0, 0, "em", 0, "", "", "ReadonlyAttribute", "", "", "", "", true, "HLP_BR_EncounterCheckBehavior.htm");
            dynavBr_behavior_br_behavior_smoking.CurrentValue = StringUtil.RTrim( AV13BR_Behavior.gxTpr_Br_behavior_smoking);
            context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, dynavBr_behavior_br_behavior_smoking_Internalname, "Values", (String)(dynavBr_behavior_br_behavior_smoking.ToJavascriptSource()), true);
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-md-6 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtavBr_behavior_br_behavior_smokingtime_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavBr_behavior_br_behavior_smokingtime_Internalname, "吸烟时长(年)", "col-sm-3 ReadonlyAttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtavBr_behavior_br_behavior_smokingtime_Internalname, AV13BR_Behavior.gxTpr_Br_behavior_smokingtime, StringUtil.RTrim( context.localUtil.Format( AV13BR_Behavior.gxTpr_Br_behavior_smokingtime, "")), "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavBr_behavior_br_behavior_smokingtime_Jsonclick, 0, "ReadonlyAttribute", "", "", "", "", 1, edtavBr_behavior_br_behavior_smokingtime_Enabled, 0, "text", "", 40, "chr", 1, "row", 40, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_BR_EncounterCheckBehavior.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-md-6 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtavBr_behavior_br_behavior_smokingamount_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavBr_behavior_br_behavior_smokingamount_Internalname, "吸烟量(支/日)", "col-sm-3 ReadonlyAttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtavBr_behavior_br_behavior_smokingamount_Internalname, AV13BR_Behavior.gxTpr_Br_behavior_smokingamount, StringUtil.RTrim( context.localUtil.Format( AV13BR_Behavior.gxTpr_Br_behavior_smokingamount, "")), "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavBr_behavior_br_behavior_smokingamount_Jsonclick, 0, "ReadonlyAttribute", "", "", "", "", 1, edtavBr_behavior_br_behavior_smokingamount_Enabled, 0, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_BR_EncounterCheckBehavior.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-md-6 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtavBr_behavior_br_behavior_rawsmokingamount_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavBr_behavior_br_behavior_rawsmokingamount_Internalname, "约吸烟量", "col-sm-3 ReadonlyAttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtavBr_behavior_br_behavior_rawsmokingamount_Internalname, AV13BR_Behavior.gxTpr_Br_behavior_rawsmokingamount, StringUtil.RTrim( context.localUtil.Format( AV13BR_Behavior.gxTpr_Br_behavior_rawsmokingamount, "")), "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavBr_behavior_br_behavior_rawsmokingamount_Jsonclick, 0, "ReadonlyAttribute", "", "", "", "", 1, edtavBr_behavior_br_behavior_rawsmokingamount_Enabled, 0, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_BR_EncounterCheckBehavior.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-md-6 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+dynavBr_behavior_br_behavior_achohol_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, dynavBr_behavior_br_behavior_achohol_Internalname, "饮酒情况", "col-sm-3 ReadonlyAttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, dynavBr_behavior_br_behavior_achohol, dynavBr_behavior_br_behavior_achohol_Internalname, StringUtil.RTrim( AV13BR_Behavior.gxTpr_Br_behavior_achohol), 1, dynavBr_behavior_br_behavior_achohol_Jsonclick, 0, "'"+sPrefix+"'"+",false,"+"'"+""+"'", "svchar", "", 1, dynavBr_behavior_br_behavior_achohol.Enabled, 0, 0, 0, "em", 0, "", "", "ReadonlyAttribute", "", "", "", "", true, "HLP_BR_EncounterCheckBehavior.htm");
            dynavBr_behavior_br_behavior_achohol.CurrentValue = StringUtil.RTrim( AV13BR_Behavior.gxTpr_Br_behavior_achohol);
            context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, dynavBr_behavior_br_behavior_achohol_Internalname, "Values", (String)(dynavBr_behavior_br_behavior_achohol.ToJavascriptSource()), true);
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-md-6 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtavBr_behavior_br_behavior_achoholtime_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavBr_behavior_br_behavior_achoholtime_Internalname, "饮酒时长(年)", "col-sm-3 ReadonlyAttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtavBr_behavior_br_behavior_achoholtime_Internalname, AV13BR_Behavior.gxTpr_Br_behavior_achoholtime, StringUtil.RTrim( context.localUtil.Format( AV13BR_Behavior.gxTpr_Br_behavior_achoholtime, "")), "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavBr_behavior_br_behavior_achoholtime_Jsonclick, 0, "ReadonlyAttribute", "", "", "", "", 1, edtavBr_behavior_br_behavior_achoholtime_Enabled, 0, "text", "", 40, "chr", 1, "row", 40, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_BR_EncounterCheckBehavior.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-md-6 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtavBr_behavior_br_behavior_achoholamount_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavBr_behavior_br_behavior_achoholamount_Internalname, "饮酒量(ml)", "col-sm-3 ReadonlyAttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtavBr_behavior_br_behavior_achoholamount_Internalname, AV13BR_Behavior.gxTpr_Br_behavior_achoholamount, StringUtil.RTrim( context.localUtil.Format( AV13BR_Behavior.gxTpr_Br_behavior_achoholamount, "")), "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavBr_behavior_br_behavior_achoholamount_Jsonclick, 0, "ReadonlyAttribute", "", "", "", "", 1, edtavBr_behavior_br_behavior_achoholamount_Enabled, 0, "text", "", 40, "chr", 1, "row", 40, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_BR_EncounterCheckBehavior.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-md-6 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtavBr_behavior_br_behavior_rawachoholamount_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavBr_behavior_br_behavior_rawachoholamount_Internalname, "约饮酒量", "col-sm-3 ReadonlyAttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtavBr_behavior_br_behavior_rawachoholamount_Internalname, AV13BR_Behavior.gxTpr_Br_behavior_rawachoholamount, StringUtil.RTrim( context.localUtil.Format( AV13BR_Behavior.gxTpr_Br_behavior_rawachoholamount, "")), "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavBr_behavior_br_behavior_rawachoholamount_Jsonclick, 0, "ReadonlyAttribute", "", "", "", "", 1, edtavBr_behavior_br_behavior_rawachoholamount_Enabled, 0, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_BR_EncounterCheckBehavior.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-md-6 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtavBr_behavior_br_behavior_childnum_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavBr_behavior_br_behavior_childnum_Internalname, "子女数量", "col-sm-3 ReadonlyAttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtavBr_behavior_br_behavior_childnum_Internalname, AV13BR_Behavior.gxTpr_Br_behavior_childnum, StringUtil.RTrim( context.localUtil.Format( AV13BR_Behavior.gxTpr_Br_behavior_childnum, "")), "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavBr_behavior_br_behavior_childnum_Jsonclick, 0, "ReadonlyAttribute", "", "", "", "", 1, edtavBr_behavior_br_behavior_childnum_Enabled, 0, "text", "", 40, "chr", 1, "row", 40, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_BR_EncounterCheckBehavior.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-md-6 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+cmbavBr_behavior_br_behavior_familycahistory_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, cmbavBr_behavior_br_behavior_familycahistory_Internalname, "是否有家族肿瘤史", "col-sm-3 ReadonlyAttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, cmbavBr_behavior_br_behavior_familycahistory, cmbavBr_behavior_br_behavior_familycahistory_Internalname, StringUtil.RTrim( AV13BR_Behavior.gxTpr_Br_behavior_familycahistory), 1, cmbavBr_behavior_br_behavior_familycahistory_Jsonclick, 0, "'"+sPrefix+"'"+",false,"+"'"+""+"'", "svchar", "", 1, cmbavBr_behavior_br_behavior_familycahistory.Enabled, 0, 0, 0, "em", 0, "", "", "ReadonlyAttribute", "", "", "", "", true, "HLP_BR_EncounterCheckBehavior.htm");
            cmbavBr_behavior_br_behavior_familycahistory.CurrentValue = StringUtil.RTrim( AV13BR_Behavior.gxTpr_Br_behavior_familycahistory);
            context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, cmbavBr_behavior_br_behavior_familycahistory_Internalname, "Values", (String)(cmbavBr_behavior_br_behavior_familycahistory.ToJavascriptSource()), true);
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divCancer_Internalname, divCancer_Visible, 0, "px", 0, "px", "", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 DataContentCellNoWrap", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divUnnamedtablebr_behavior_br_behavior_familycancer_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 MergeLabelCell CellWidth_12_5", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblockbr_behavior_br_behavior_familycancer_Internalname, "家族性肿瘤", "", "", lblTextblockbr_behavior_br_behavior_familycancer_Jsonclick, "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_BR_EncounterCheckBehavior.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 CellWidth_87_5", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavBr_behavior_br_behavior_familycancer_Internalname, "家族性肿瘤", "col-sm-3 AttributeReadGrayLabel", 0, true);
            /* Multiple line edit */
            ClassString = "AttributeReadGray";
            StyleString = "";
            ClassString = "AttributeReadGray";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavBr_behavior_br_behavior_familycancer_Internalname, AV13BR_Behavior.gxTpr_Br_behavior_familycancer, "", "", 0, 1, edtavBr_behavior_br_behavior_familycancer_Enabled, 0, 80, "chr", 3, "row", StyleString, ClassString, "", "", "200", -1, 0, "", "", -1, true, "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_EncounterCheckBehavior.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divManopsuse_Internalname, divManopsuse_Visible, 0, "px", 0, "px", "", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-md-6 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtavBr_behavior_br_behavior_rawmenopauseage_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavBr_behavior_br_behavior_rawmenopauseage_Internalname, "约绝经时间", "col-sm-3 ReadonlyAttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtavBr_behavior_br_behavior_rawmenopauseage_Internalname, AV13BR_Behavior.gxTpr_Br_behavior_rawmenopauseage, StringUtil.RTrim( context.localUtil.Format( AV13BR_Behavior.gxTpr_Br_behavior_rawmenopauseage, "")), "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavBr_behavior_br_behavior_rawmenopauseage_Jsonclick, 0, "ReadonlyAttribute", "", "", "", "", 1, edtavBr_behavior_br_behavior_rawmenopauseage_Enabled, 0, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_BR_EncounterCheckBehavior.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-md-6 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+cmbavBr_behavior_br_behavior_menopause_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, cmbavBr_behavior_br_behavior_menopause_Internalname, "是否绝经", "col-sm-3 ReadonlyAttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, cmbavBr_behavior_br_behavior_menopause, cmbavBr_behavior_br_behavior_menopause_Internalname, StringUtil.RTrim( AV13BR_Behavior.gxTpr_Br_behavior_menopause), 1, cmbavBr_behavior_br_behavior_menopause_Jsonclick, 0, "'"+sPrefix+"'"+",false,"+"'"+""+"'", "svchar", "", 1, cmbavBr_behavior_br_behavior_menopause.Enabled, 0, 0, 0, "em", 0, "", "", "ReadonlyAttribute", "", "", "", "", true, "HLP_BR_EncounterCheckBehavior.htm");
            cmbavBr_behavior_br_behavior_menopause.CurrentValue = StringUtil.RTrim( AV13BR_Behavior.gxTpr_Br_behavior_menopause);
            context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, cmbavBr_behavior_br_behavior_menopause_Internalname, "Values", (String)(cmbavBr_behavior_br_behavior_menopause.ToJavascriptSource()), true);
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-md-6", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divAge_Internalname, divAge_Visible, 0, "px", 0, "px", "", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtavBr_behavior_br_behavior_menopauseage_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavBr_behavior_br_behavior_menopauseage_Internalname, "绝经年龄", "col-sm-3 ReadonlyAttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtavBr_behavior_br_behavior_menopauseage_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV13BR_Behavior.gxTpr_Br_behavior_menopauseage), 4, 0, ".", "")), ((edtavBr_behavior_br_behavior_menopauseage_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(AV13BR_Behavior.gxTpr_Br_behavior_menopauseage), "ZZZZ")) : context.localUtil.Format( (decimal)(AV13BR_Behavior.gxTpr_Br_behavior_menopauseage), "ZZZZ")), "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavBr_behavior_br_behavior_menopauseage_Jsonclick, 0, "ReadonlyAttribute", "", "", "", "", 1, edtavBr_behavior_br_behavior_menopauseage_Enabled, 0, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_BR_EncounterCheckBehavior.htm");
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
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divHtml_bottomauxiliarcontrols_Internalname, 1, 0, "px", 0, "px", "Section", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 86,'" + sPrefix + "',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavBr_behavior_br_behaviorid_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV13BR_Behavior.gxTpr_Br_behaviorid), 18, 0, ".", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(AV13BR_Behavior.gxTpr_Br_behaviorid), "ZZZZZZZZZZZZZZZZZZ")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,86);\"", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavBr_behavior_br_behaviorid_Jsonclick, 0, "Attribute", "", "", "", "", edtavBr_behavior_br_behaviorid_Visible, 1, 0, "number", "1", 18, "chr", 1, "row", 18, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_BR_EncounterCheckBehavior.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 87,'" + sPrefix + "',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavBr_behavior_br_encounterid_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV13BR_Behavior.gxTpr_Br_encounterid), 18, 0, ".", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(AV13BR_Behavior.gxTpr_Br_encounterid), "ZZZZZZZZZZZZZZZZZZ")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,87);\"", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavBr_behavior_br_encounterid_Jsonclick, 0, "Attribute", "", "", "", "", edtavBr_behavior_br_encounterid_Visible, 1, 0, "number", "1", 18, "chr", 1, "row", 18, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_BR_EncounterCheckBehavior.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 88,'" + sPrefix + "',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavBr_behavior_br_information_patientno_Internalname, AV13BR_Behavior.gxTpr_Br_information_patientno, StringUtil.RTrim( context.localUtil.Format( AV13BR_Behavior.gxTpr_Br_information_patientno, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,88);\"", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavBr_behavior_br_information_patientno_Jsonclick, 0, "Attribute", "", "", "", "", edtavBr_behavior_br_information_patientno_Visible, 1, 0, "text", "", 80, "chr", 1, "row", 2000, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_BR_EncounterCheckBehavior.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
         }
         wbLoad = true;
      }

      protected void START3V2( )
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
               STRUP3V0( ) ;
            }
         }
      }

      protected void WS3V2( )
      {
         START3V2( ) ;
         EVT3V2( ) ;
      }

      protected void EVT3V2( )
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
                                 STRUP3V0( ) ;
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
                                 STRUP3V0( ) ;
                              }
                              if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
                              {
                                 context.wbHandled = 1;
                                 if ( ! wbErr )
                                 {
                                    dynload_actions( ) ;
                                    /* Execute user event: Start */
                                    E113V2 ();
                                 }
                              }
                           }
                           else if ( StringUtil.StrCmp(sEvt, "LOAD") == 0 )
                           {
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP3V0( ) ;
                              }
                              if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
                              {
                                 context.wbHandled = 1;
                                 if ( ! wbErr )
                                 {
                                    dynload_actions( ) ;
                                    /* Execute user event: Load */
                                    E123V2 ();
                                 }
                              }
                           }
                           else if ( StringUtil.StrCmp(sEvt, "ENTER") == 0 )
                           {
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP3V0( ) ;
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
                                 STRUP3V0( ) ;
                              }
                              if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
                              {
                                 context.wbHandled = 1;
                                 if ( ! wbErr )
                                 {
                                    dynload_actions( ) ;
                                    GX_FocusControl = dynavBr_behavior_br_behavior_smoking_Internalname;
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

      protected void WE3V2( )
      {
         if ( ! GxWebStd.gx_redirect( context) )
         {
            Rfr0gs = true;
            Refresh( ) ;
            if ( ! GxWebStd.gx_redirect( context) )
            {
               RenderHtmlCloseForm3V2( ) ;
            }
         }
      }

      protected void PA3V2( )
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
               GX_FocusControl = dynavBr_behavior_br_behavior_smoking_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "GX_FocusControl", GX_FocusControl);
            }
            nDonePA = 1;
         }
      }

      protected void dynload_actions( )
      {
         /* End function dynload_actions */
      }

      protected void GXDLVBR_BEHAVIOR_BR_BEHAVIOR_SMOKING3V2( decimal AV39Tcurrentcode )
      {
         if ( ! context.isAjaxRequest( ) )
         {
            context.GX_webresponse.AppendHeader("Cache-Control", "no-store");
         }
         context.GX_webresponse.AddString("[[");
         GXDLVBR_BEHAVIOR_BR_BEHAVIOR_SMOKING_data3V2( AV39Tcurrentcode) ;
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

      protected void GXVBR_BEHAVIOR_BR_BEHAVIOR_SMOKING_html3V2( decimal AV39Tcurrentcode )
      {
         String gxdynajaxvalue ;
         GXDLVBR_BEHAVIOR_BR_BEHAVIOR_SMOKING_data3V2( AV39Tcurrentcode) ;
         gxdynajaxindex = 1;
         if ( ! ( gxdyncontrolsrefreshing && context.isAjaxRequest( ) ) )
         {
            dynavBr_behavior_br_behavior_smoking.removeAllItems();
         }
         while ( gxdynajaxindex <= gxdynajaxctrlcodr.Count )
         {
            gxdynajaxvalue = ((String)gxdynajaxctrlcodr.Item(gxdynajaxindex));
            dynavBr_behavior_br_behavior_smoking.addItem(gxdynajaxvalue, ((String)gxdynajaxctrldescr.Item(gxdynajaxindex)), 0);
            gxdynajaxindex = (int)(gxdynajaxindex+1);
         }
      }

      protected void GXDLVBR_BEHAVIOR_BR_BEHAVIOR_SMOKING_data3V2( decimal AV39Tcurrentcode )
      {
         gxdynajaxctrlcodr.Clear();
         gxdynajaxctrldescr.Clear();
         gxdynajaxctrlcodr.Add("");
         gxdynajaxctrldescr.Add("(请选择)");
         /* Using cursor H003V2 */
         pr_default.execute(0, new Object[] {AV39Tcurrentcode});
         while ( (pr_default.getStatus(0) != 101) )
         {
            gxdynajaxctrlcodr.Add(H003V2_A168XT_DefineCodeName[0]);
            gxdynajaxctrldescr.Add(H003V2_A168XT_DefineCodeName[0]);
            pr_default.readNext(0);
         }
         pr_default.close(0);
      }

      protected void GXDLVBR_BEHAVIOR_BR_BEHAVIOR_ACHOHOL3V2( decimal AV39Tcurrentcode )
      {
         if ( ! context.isAjaxRequest( ) )
         {
            context.GX_webresponse.AppendHeader("Cache-Control", "no-store");
         }
         context.GX_webresponse.AddString("[[");
         GXDLVBR_BEHAVIOR_BR_BEHAVIOR_ACHOHOL_data3V2( AV39Tcurrentcode) ;
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

      protected void GXVBR_BEHAVIOR_BR_BEHAVIOR_ACHOHOL_html3V2( decimal AV39Tcurrentcode )
      {
         String gxdynajaxvalue ;
         GXDLVBR_BEHAVIOR_BR_BEHAVIOR_ACHOHOL_data3V2( AV39Tcurrentcode) ;
         gxdynajaxindex = 1;
         if ( ! ( gxdyncontrolsrefreshing && context.isAjaxRequest( ) ) )
         {
            dynavBr_behavior_br_behavior_achohol.removeAllItems();
         }
         while ( gxdynajaxindex <= gxdynajaxctrlcodr.Count )
         {
            gxdynajaxvalue = ((String)gxdynajaxctrlcodr.Item(gxdynajaxindex));
            dynavBr_behavior_br_behavior_achohol.addItem(gxdynajaxvalue, ((String)gxdynajaxctrldescr.Item(gxdynajaxindex)), 0);
            gxdynajaxindex = (int)(gxdynajaxindex+1);
         }
      }

      protected void GXDLVBR_BEHAVIOR_BR_BEHAVIOR_ACHOHOL_data3V2( decimal AV39Tcurrentcode )
      {
         gxdynajaxctrlcodr.Clear();
         gxdynajaxctrldescr.Clear();
         gxdynajaxctrlcodr.Add("");
         gxdynajaxctrldescr.Add("(请选择)");
         /* Using cursor H003V3 */
         pr_default.execute(1, new Object[] {AV39Tcurrentcode});
         while ( (pr_default.getStatus(1) != 101) )
         {
            gxdynajaxctrlcodr.Add(H003V3_A168XT_DefineCodeName[0]);
            gxdynajaxctrldescr.Add(H003V3_A168XT_DefineCodeName[0]);
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
         if ( dynavBr_behavior_br_behavior_smoking.ItemCount > 0 )
         {
            AV13BR_Behavior.gxTpr_Br_behavior_smoking = dynavBr_behavior_br_behavior_smoking.getValidValue(AV13BR_Behavior.gxTpr_Br_behavior_smoking);
         }
         if ( context.isAjaxRequest( ) )
         {
            dynavBr_behavior_br_behavior_smoking.CurrentValue = StringUtil.RTrim( AV13BR_Behavior.gxTpr_Br_behavior_smoking);
            context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, dynavBr_behavior_br_behavior_smoking_Internalname, "Values", dynavBr_behavior_br_behavior_smoking.ToJavascriptSource(), true);
         }
         if ( dynavBr_behavior_br_behavior_achohol.ItemCount > 0 )
         {
            AV13BR_Behavior.gxTpr_Br_behavior_achohol = dynavBr_behavior_br_behavior_achohol.getValidValue(AV13BR_Behavior.gxTpr_Br_behavior_achohol);
         }
         if ( context.isAjaxRequest( ) )
         {
            dynavBr_behavior_br_behavior_achohol.CurrentValue = StringUtil.RTrim( AV13BR_Behavior.gxTpr_Br_behavior_achohol);
            context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, dynavBr_behavior_br_behavior_achohol_Internalname, "Values", dynavBr_behavior_br_behavior_achohol.ToJavascriptSource(), true);
         }
         if ( cmbavBr_behavior_br_behavior_familycahistory.ItemCount > 0 )
         {
            AV13BR_Behavior.gxTpr_Br_behavior_familycahistory = cmbavBr_behavior_br_behavior_familycahistory.getValidValue(AV13BR_Behavior.gxTpr_Br_behavior_familycahistory);
         }
         if ( context.isAjaxRequest( ) )
         {
            cmbavBr_behavior_br_behavior_familycahistory.CurrentValue = StringUtil.RTrim( AV13BR_Behavior.gxTpr_Br_behavior_familycahistory);
            context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, cmbavBr_behavior_br_behavior_familycahistory_Internalname, "Values", cmbavBr_behavior_br_behavior_familycahistory.ToJavascriptSource(), true);
         }
         if ( cmbavBr_behavior_br_behavior_menopause.ItemCount > 0 )
         {
            AV13BR_Behavior.gxTpr_Br_behavior_menopause = cmbavBr_behavior_br_behavior_menopause.getValidValue(AV13BR_Behavior.gxTpr_Br_behavior_menopause);
         }
         if ( context.isAjaxRequest( ) )
         {
            cmbavBr_behavior_br_behavior_menopause.CurrentValue = StringUtil.RTrim( AV13BR_Behavior.gxTpr_Br_behavior_menopause);
            context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, cmbavBr_behavior_br_behavior_menopause_Internalname, "Values", cmbavBr_behavior_br_behavior_menopause.ToJavascriptSource(), true);
         }
      }

      public void Refresh( )
      {
         send_integrity_hashes( ) ;
         RF3V2( ) ;
         if ( isFullAjaxMode( ) )
         {
            send_integrity_footer_hashes( ) ;
         }
      }

      protected void initialize_formulas( )
      {
         /* GeneXus formulas. */
         AV38Pgmname = "BR_EncounterCheckBehavior";
         context.Gx_err = 0;
         dynavBr_behavior_br_behavior_smoking.Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, dynavBr_behavior_br_behavior_smoking_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(dynavBr_behavior_br_behavior_smoking.Enabled), 5, 0)), true);
         edtavBr_behavior_br_behavior_smokingtime_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavBr_behavior_br_behavior_smokingtime_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavBr_behavior_br_behavior_smokingtime_Enabled), 5, 0)), true);
         edtavBr_behavior_br_behavior_smokingamount_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavBr_behavior_br_behavior_smokingamount_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavBr_behavior_br_behavior_smokingamount_Enabled), 5, 0)), true);
         edtavBr_behavior_br_behavior_rawsmokingamount_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavBr_behavior_br_behavior_rawsmokingamount_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavBr_behavior_br_behavior_rawsmokingamount_Enabled), 5, 0)), true);
         dynavBr_behavior_br_behavior_achohol.Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, dynavBr_behavior_br_behavior_achohol_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(dynavBr_behavior_br_behavior_achohol.Enabled), 5, 0)), true);
         edtavBr_behavior_br_behavior_achoholtime_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavBr_behavior_br_behavior_achoholtime_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavBr_behavior_br_behavior_achoholtime_Enabled), 5, 0)), true);
         edtavBr_behavior_br_behavior_achoholamount_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavBr_behavior_br_behavior_achoholamount_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavBr_behavior_br_behavior_achoholamount_Enabled), 5, 0)), true);
         edtavBr_behavior_br_behavior_rawachoholamount_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavBr_behavior_br_behavior_rawachoholamount_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavBr_behavior_br_behavior_rawachoholamount_Enabled), 5, 0)), true);
         edtavBr_behavior_br_behavior_childnum_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavBr_behavior_br_behavior_childnum_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavBr_behavior_br_behavior_childnum_Enabled), 5, 0)), true);
         cmbavBr_behavior_br_behavior_familycahistory.Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, cmbavBr_behavior_br_behavior_familycahistory_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(cmbavBr_behavior_br_behavior_familycahistory.Enabled), 5, 0)), true);
         edtavBr_behavior_br_behavior_familycancer_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavBr_behavior_br_behavior_familycancer_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavBr_behavior_br_behavior_familycancer_Enabled), 5, 0)), true);
         edtavBr_behavior_br_behavior_rawmenopauseage_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavBr_behavior_br_behavior_rawmenopauseage_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavBr_behavior_br_behavior_rawmenopauseage_Enabled), 5, 0)), true);
         cmbavBr_behavior_br_behavior_menopause.Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, cmbavBr_behavior_br_behavior_menopause_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(cmbavBr_behavior_br_behavior_menopause.Enabled), 5, 0)), true);
         edtavBr_behavior_br_behavior_menopauseage_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavBr_behavior_br_behavior_menopauseage_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavBr_behavior_br_behavior_menopauseage_Enabled), 5, 0)), true);
      }

      protected void RF3V2( )
      {
         initialize_formulas( ) ;
         clear_multi_value_controls( ) ;
         gxdyncontrolsrefreshing = true;
         fix_multi_value_controls( ) ;
         gxdyncontrolsrefreshing = false;
         if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
         {
            /* Execute user event: Load */
            E123V2 ();
            WB3V0( ) ;
         }
      }

      protected void send_integrity_lvl_hashes3V2( )
      {
      }

      protected void STRUP3V0( )
      {
         /* Before Start, stand alone formulas. */
         AV38Pgmname = "BR_EncounterCheckBehavior";
         context.Gx_err = 0;
         dynavBr_behavior_br_behavior_smoking.Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, dynavBr_behavior_br_behavior_smoking_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(dynavBr_behavior_br_behavior_smoking.Enabled), 5, 0)), true);
         edtavBr_behavior_br_behavior_smokingtime_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavBr_behavior_br_behavior_smokingtime_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavBr_behavior_br_behavior_smokingtime_Enabled), 5, 0)), true);
         edtavBr_behavior_br_behavior_smokingamount_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavBr_behavior_br_behavior_smokingamount_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavBr_behavior_br_behavior_smokingamount_Enabled), 5, 0)), true);
         edtavBr_behavior_br_behavior_rawsmokingamount_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavBr_behavior_br_behavior_rawsmokingamount_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavBr_behavior_br_behavior_rawsmokingamount_Enabled), 5, 0)), true);
         dynavBr_behavior_br_behavior_achohol.Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, dynavBr_behavior_br_behavior_achohol_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(dynavBr_behavior_br_behavior_achohol.Enabled), 5, 0)), true);
         edtavBr_behavior_br_behavior_achoholtime_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavBr_behavior_br_behavior_achoholtime_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavBr_behavior_br_behavior_achoholtime_Enabled), 5, 0)), true);
         edtavBr_behavior_br_behavior_achoholamount_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavBr_behavior_br_behavior_achoholamount_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavBr_behavior_br_behavior_achoholamount_Enabled), 5, 0)), true);
         edtavBr_behavior_br_behavior_rawachoholamount_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavBr_behavior_br_behavior_rawachoholamount_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavBr_behavior_br_behavior_rawachoholamount_Enabled), 5, 0)), true);
         edtavBr_behavior_br_behavior_childnum_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavBr_behavior_br_behavior_childnum_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavBr_behavior_br_behavior_childnum_Enabled), 5, 0)), true);
         cmbavBr_behavior_br_behavior_familycahistory.Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, cmbavBr_behavior_br_behavior_familycahistory_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(cmbavBr_behavior_br_behavior_familycahistory.Enabled), 5, 0)), true);
         edtavBr_behavior_br_behavior_familycancer_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavBr_behavior_br_behavior_familycancer_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavBr_behavior_br_behavior_familycancer_Enabled), 5, 0)), true);
         edtavBr_behavior_br_behavior_rawmenopauseage_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavBr_behavior_br_behavior_rawmenopauseage_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavBr_behavior_br_behavior_rawmenopauseage_Enabled), 5, 0)), true);
         cmbavBr_behavior_br_behavior_menopause.Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, cmbavBr_behavior_br_behavior_menopause_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(cmbavBr_behavior_br_behavior_menopause.Enabled), 5, 0)), true);
         edtavBr_behavior_br_behavior_menopauseage_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavBr_behavior_br_behavior_menopauseage_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavBr_behavior_br_behavior_menopauseage_Enabled), 5, 0)), true);
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0;
         /* Execute user event: Start */
         E113V2 ();
         context.wbGlbDoneStart = 1;
         nDoneStart = 1;
         /* After Start, stand alone formulas. */
         sXEvt = cgiGet( "_EventName");
         if ( ! GetJustCreated( ) && ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 ) )
         {
            /* Read saved SDTs. */
            ajax_req_read_hidden_sdt(cgiGet( sPrefix+"Br_behavior"), AV13BR_Behavior);
            /* Read variables values. */
            dynavBr_behavior_br_behavior_smoking.CurrentValue = cgiGet( dynavBr_behavior_br_behavior_smoking_Internalname);
            AV13BR_Behavior.gxTpr_Br_behavior_smoking = cgiGet( dynavBr_behavior_br_behavior_smoking_Internalname);
            AV13BR_Behavior.gxTpr_Br_behavior_smokingtime = cgiGet( edtavBr_behavior_br_behavior_smokingtime_Internalname);
            AV13BR_Behavior.gxTpr_Br_behavior_smokingamount = cgiGet( edtavBr_behavior_br_behavior_smokingamount_Internalname);
            AV13BR_Behavior.gxTpr_Br_behavior_rawsmokingamount = cgiGet( edtavBr_behavior_br_behavior_rawsmokingamount_Internalname);
            dynavBr_behavior_br_behavior_achohol.CurrentValue = cgiGet( dynavBr_behavior_br_behavior_achohol_Internalname);
            AV13BR_Behavior.gxTpr_Br_behavior_achohol = cgiGet( dynavBr_behavior_br_behavior_achohol_Internalname);
            AV13BR_Behavior.gxTpr_Br_behavior_achoholtime = cgiGet( edtavBr_behavior_br_behavior_achoholtime_Internalname);
            AV13BR_Behavior.gxTpr_Br_behavior_achoholamount = cgiGet( edtavBr_behavior_br_behavior_achoholamount_Internalname);
            AV13BR_Behavior.gxTpr_Br_behavior_rawachoholamount = cgiGet( edtavBr_behavior_br_behavior_rawachoholamount_Internalname);
            AV13BR_Behavior.gxTpr_Br_behavior_childnum = cgiGet( edtavBr_behavior_br_behavior_childnum_Internalname);
            cmbavBr_behavior_br_behavior_familycahistory.CurrentValue = cgiGet( cmbavBr_behavior_br_behavior_familycahistory_Internalname);
            AV13BR_Behavior.gxTpr_Br_behavior_familycahistory = cgiGet( cmbavBr_behavior_br_behavior_familycahistory_Internalname);
            AV13BR_Behavior.gxTpr_Br_behavior_familycancer = cgiGet( edtavBr_behavior_br_behavior_familycancer_Internalname);
            AV13BR_Behavior.gxTpr_Br_behavior_rawmenopauseage = cgiGet( edtavBr_behavior_br_behavior_rawmenopauseage_Internalname);
            cmbavBr_behavior_br_behavior_menopause.CurrentValue = cgiGet( cmbavBr_behavior_br_behavior_menopause_Internalname);
            AV13BR_Behavior.gxTpr_Br_behavior_menopause = cgiGet( cmbavBr_behavior_br_behavior_menopause_Internalname);
            if ( ( ( context.localUtil.CToN( cgiGet( edtavBr_behavior_br_behavior_menopauseage_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavBr_behavior_br_behavior_menopauseage_Internalname), ".", ",") > Convert.ToDecimal( 9999 )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "BR_BEHAVIOR_BR_BEHAVIOR_MENOPAUSEAGE");
               GX_FocusControl = edtavBr_behavior_br_behavior_menopauseage_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV13BR_Behavior.gxTpr_Br_behavior_menopauseage = 0;
            }
            else
            {
               AV13BR_Behavior.gxTpr_Br_behavior_menopauseage = (short)(context.localUtil.CToN( cgiGet( edtavBr_behavior_br_behavior_menopauseage_Internalname), ".", ","));
            }
            if ( ( ( context.localUtil.CToN( cgiGet( edtavBr_behavior_br_behaviorid_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavBr_behavior_br_behaviorid_Internalname), ".", ",") > Convert.ToDecimal( 999999999999999999L )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "BR_BEHAVIOR_BR_BEHAVIORID");
               GX_FocusControl = edtavBr_behavior_br_behaviorid_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV13BR_Behavior.gxTpr_Br_behaviorid = 0;
            }
            else
            {
               AV13BR_Behavior.gxTpr_Br_behaviorid = (long)(context.localUtil.CToN( cgiGet( edtavBr_behavior_br_behaviorid_Internalname), ".", ","));
            }
            if ( ( ( context.localUtil.CToN( cgiGet( edtavBr_behavior_br_encounterid_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavBr_behavior_br_encounterid_Internalname), ".", ",") > Convert.ToDecimal( 999999999999999999L )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "BR_BEHAVIOR_BR_ENCOUNTERID");
               GX_FocusControl = edtavBr_behavior_br_encounterid_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV13BR_Behavior.gxTpr_Br_encounterid = 0;
            }
            else
            {
               AV13BR_Behavior.gxTpr_Br_encounterid = (long)(context.localUtil.CToN( cgiGet( edtavBr_behavior_br_encounterid_Internalname), ".", ","));
            }
            AV13BR_Behavior.gxTpr_Br_information_patientno = cgiGet( edtavBr_behavior_br_information_patientno_Internalname);
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
         E113V2 ();
         if (returnInSub) return;
      }

      protected void E113V2( )
      {
         /* Start Routine */
         new GeneXus.Programs.wwpbaseobjects.loadwwpcontext(context ).execute( out  AV6WWPContext) ;
         /* Execute user subroutine: 'PREPARETRANSACTION' */
         S112 ();
         if (returnInSub) return;
         /* Using cursor H003V4 */
         pr_default.execute(2, new Object[] {A19BR_EncounterID});
         while ( (pr_default.getStatus(2) != 101) )
         {
            A20BR_BehaviorID = H003V4_A20BR_BehaviorID[0];
            AV13BR_Behavior.Load(A20BR_BehaviorID);
            /* Exit For each command. Update data (if necessary), close cursors & exit. */
            if (true) break;
            pr_default.readNext(2);
         }
         pr_default.close(2);
         if ( StringUtil.StrCmp(AV13BR_Behavior.gxTpr_Br_behavior_familycahistory, "是") == 0 )
         {
            divCancer_Visible = 1;
            context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, divCancer_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(divCancer_Visible), 5, 0)), true);
         }
         else
         {
            divCancer_Visible = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, divCancer_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(divCancer_Visible), 5, 0)), true);
         }
         if ( StringUtil.StrCmp(AV13BR_Behavior.gxTpr_Br_behavior_menopause, "是") == 0 )
         {
            divAge_Visible = 1;
            context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, divAge_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(divAge_Visible), 5, 0)), true);
         }
         else
         {
            divAge_Visible = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, divAge_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(divAge_Visible), 5, 0)), true);
         }
         divManopsuse_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, divManopsuse_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(divManopsuse_Visible), 5, 0)), true);
         /* Using cursor H003V5 */
         pr_default.execute(3, new Object[] {A19BR_EncounterID});
         while ( (pr_default.getStatus(3) != 101) )
         {
            A61BR_Demographics_ID = H003V5_A61BR_Demographics_ID[0];
            AV14BCBR_Demographics.Load(A61BR_Demographics_ID);
            if ( StringUtil.StrCmp(AV14BCBR_Demographics.gxTpr_Br_demographics_sex, "女") == 0 )
            {
               divManopsuse_Visible = 1;
               context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, divManopsuse_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(divManopsuse_Visible), 5, 0)), true);
            }
            else
            {
               divManopsuse_Visible = 0;
               context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, divManopsuse_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(divManopsuse_Visible), 5, 0)), true);
            }
            /* Exit For each command. Update data (if necessary), close cursors & exit. */
            if (true) break;
            pr_default.readNext(3);
         }
         pr_default.close(3);
      }

      protected void nextLoad( )
      {
      }

      protected void E123V2( )
      {
         /* Load Routine */
         edtavBr_behavior_br_behaviorid_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavBr_behavior_br_behaviorid_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavBr_behavior_br_behaviorid_Visible), 5, 0)), true);
         edtavBr_behavior_br_encounterid_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavBr_behavior_br_encounterid_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavBr_behavior_br_encounterid_Visible), 5, 0)), true);
         edtavBr_behavior_br_information_patientno_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavBr_behavior_br_information_patientno_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavBr_behavior_br_information_patientno_Visible), 5, 0)), true);
      }

      protected void S112( )
      {
         /* 'PREPARETRANSACTION' Routine */
         AV9TrnContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext(context);
         AV9TrnContext.gxTpr_Callerobject = AV38Pgmname;
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
         PA3V2( ) ;
         WS3V2( ) ;
         WE3V2( ) ;
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
         PA3V2( ) ;
         WCParametersGet( ) ;
      }

      public override void componentprepare( Object[] obj )
      {
         wbLoad = false;
         sCompPrefix = (String)getParm(obj,0);
         sSFPrefix = (String)getParm(obj,1);
         sPrefix = sCompPrefix + sSFPrefix;
         AddComponentObject(sPrefix, "br_encountercheckbehavior", GetJustCreated( ));
         if ( ( nDoneStart == 0 ) && ( nDynComponent == 0 ) )
         {
            INITWEB( ) ;
         }
         else
         {
            init_default_properties( ) ;
            init_web_controls( ) ;
         }
         PA3V2( ) ;
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
         PA3V2( ) ;
         sEvt = sCompEvt;
         WCParametersGet( ) ;
         WS3V2( ) ;
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
         WS3V2( ) ;
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
         WE3V2( ) ;
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
         AddThemeStyleSheetFile("", context.GetTheme( )+".css", "?"+GetCacheInvalidationToken( ));
         bool outputEnabled = isOutputEnabled( ) ;
         if ( context.isSpaRequest( ) )
         {
            enableOutput();
         }
         idxLst = 1;
         while ( idxLst <= Form.Jscriptsrc.Count )
         {
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?202022711554896", true);
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
            context.AddJavascriptSource("br_encountercheckbehavior.js", "?202022711554897", false);
         }
         /* End function include_jscripts */
      }

      protected void init_web_controls( )
      {
         dynavBr_behavior_br_behavior_smoking.Name = "BR_BEHAVIOR_BR_BEHAVIOR_SMOKING";
         dynavBr_behavior_br_behavior_smoking.WebTags = "";
         dynavBr_behavior_br_behavior_achohol.Name = "BR_BEHAVIOR_BR_BEHAVIOR_ACHOHOL";
         dynavBr_behavior_br_behavior_achohol.WebTags = "";
         cmbavBr_behavior_br_behavior_familycahistory.Name = "BR_BEHAVIOR_BR_BEHAVIOR_FAMILYCAHISTORY";
         cmbavBr_behavior_br_behavior_familycahistory.WebTags = "";
         cmbavBr_behavior_br_behavior_familycahistory.addItem("", "(请选择)", 0);
         cmbavBr_behavior_br_behavior_familycahistory.addItem("否", "否", 0);
         cmbavBr_behavior_br_behavior_familycahistory.addItem("是", "是", 0);
         cmbavBr_behavior_br_behavior_familycahistory.addItem("不详", "不详", 0);
         if ( cmbavBr_behavior_br_behavior_familycahistory.ItemCount > 0 )
         {
         }
         cmbavBr_behavior_br_behavior_menopause.Name = "BR_BEHAVIOR_BR_BEHAVIOR_MENOPAUSE";
         cmbavBr_behavior_br_behavior_menopause.WebTags = "";
         cmbavBr_behavior_br_behavior_menopause.addItem("", "(请选择)", 0);
         cmbavBr_behavior_br_behavior_menopause.addItem("否", "否", 0);
         cmbavBr_behavior_br_behavior_menopause.addItem("是", "是", 0);
         cmbavBr_behavior_br_behavior_menopause.addItem("不详", "不详", 0);
         if ( cmbavBr_behavior_br_behavior_menopause.ItemCount > 0 )
         {
         }
         /* End function init_web_controls */
      }

      protected void init_default_properties( )
      {
         dynavBr_behavior_br_behavior_smoking_Internalname = sPrefix+"BR_BEHAVIOR_BR_BEHAVIOR_SMOKING";
         edtavBr_behavior_br_behavior_smokingtime_Internalname = sPrefix+"BR_BEHAVIOR_BR_BEHAVIOR_SMOKINGTIME";
         edtavBr_behavior_br_behavior_smokingamount_Internalname = sPrefix+"BR_BEHAVIOR_BR_BEHAVIOR_SMOKINGAMOUNT";
         edtavBr_behavior_br_behavior_rawsmokingamount_Internalname = sPrefix+"BR_BEHAVIOR_BR_BEHAVIOR_RAWSMOKINGAMOUNT";
         dynavBr_behavior_br_behavior_achohol_Internalname = sPrefix+"BR_BEHAVIOR_BR_BEHAVIOR_ACHOHOL";
         edtavBr_behavior_br_behavior_achoholtime_Internalname = sPrefix+"BR_BEHAVIOR_BR_BEHAVIOR_ACHOHOLTIME";
         edtavBr_behavior_br_behavior_achoholamount_Internalname = sPrefix+"BR_BEHAVIOR_BR_BEHAVIOR_ACHOHOLAMOUNT";
         edtavBr_behavior_br_behavior_rawachoholamount_Internalname = sPrefix+"BR_BEHAVIOR_BR_BEHAVIOR_RAWACHOHOLAMOUNT";
         edtavBr_behavior_br_behavior_childnum_Internalname = sPrefix+"BR_BEHAVIOR_BR_BEHAVIOR_CHILDNUM";
         cmbavBr_behavior_br_behavior_familycahistory_Internalname = sPrefix+"BR_BEHAVIOR_BR_BEHAVIOR_FAMILYCAHISTORY";
         lblTextblockbr_behavior_br_behavior_familycancer_Internalname = sPrefix+"TEXTBLOCKBR_BEHAVIOR_BR_BEHAVIOR_FAMILYCANCER";
         edtavBr_behavior_br_behavior_familycancer_Internalname = sPrefix+"BR_BEHAVIOR_BR_BEHAVIOR_FAMILYCANCER";
         divUnnamedtablebr_behavior_br_behavior_familycancer_Internalname = sPrefix+"UNNAMEDTABLEBR_BEHAVIOR_BR_BEHAVIOR_FAMILYCANCER";
         divCancer_Internalname = sPrefix+"CANCER";
         edtavBr_behavior_br_behavior_rawmenopauseage_Internalname = sPrefix+"BR_BEHAVIOR_BR_BEHAVIOR_RAWMENOPAUSEAGE";
         cmbavBr_behavior_br_behavior_menopause_Internalname = sPrefix+"BR_BEHAVIOR_BR_BEHAVIOR_MENOPAUSE";
         edtavBr_behavior_br_behavior_menopauseage_Internalname = sPrefix+"BR_BEHAVIOR_BR_BEHAVIOR_MENOPAUSEAGE";
         divAge_Internalname = sPrefix+"AGE";
         divManopsuse_Internalname = sPrefix+"MANOPSUSE";
         divUnnamedtable1_Internalname = sPrefix+"UNNAMEDTABLE1";
         edtavBr_behavior_br_behaviorid_Internalname = sPrefix+"BR_BEHAVIOR_BR_BEHAVIORID";
         edtavBr_behavior_br_encounterid_Internalname = sPrefix+"BR_BEHAVIOR_BR_ENCOUNTERID";
         edtavBr_behavior_br_information_patientno_Internalname = sPrefix+"BR_BEHAVIOR_BR_INFORMATION_PATIENTNO";
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
         edtavBr_behavior_br_information_patientno_Jsonclick = "";
         edtavBr_behavior_br_information_patientno_Visible = 1;
         edtavBr_behavior_br_encounterid_Jsonclick = "";
         edtavBr_behavior_br_encounterid_Visible = 1;
         edtavBr_behavior_br_behaviorid_Jsonclick = "";
         edtavBr_behavior_br_behaviorid_Visible = 1;
         edtavBr_behavior_br_behavior_menopauseage_Jsonclick = "";
         edtavBr_behavior_br_behavior_menopauseage_Enabled = 0;
         divAge_Visible = 1;
         cmbavBr_behavior_br_behavior_menopause_Jsonclick = "";
         cmbavBr_behavior_br_behavior_menopause.Enabled = 0;
         edtavBr_behavior_br_behavior_rawmenopauseage_Jsonclick = "";
         edtavBr_behavior_br_behavior_rawmenopauseage_Enabled = 0;
         divManopsuse_Visible = 1;
         edtavBr_behavior_br_behavior_familycancer_Enabled = 0;
         divCancer_Visible = 1;
         cmbavBr_behavior_br_behavior_familycahistory_Jsonclick = "";
         cmbavBr_behavior_br_behavior_familycahistory.Enabled = 0;
         edtavBr_behavior_br_behavior_childnum_Jsonclick = "";
         edtavBr_behavior_br_behavior_childnum_Enabled = 0;
         edtavBr_behavior_br_behavior_rawachoholamount_Jsonclick = "";
         edtavBr_behavior_br_behavior_rawachoholamount_Enabled = 0;
         edtavBr_behavior_br_behavior_achoholamount_Jsonclick = "";
         edtavBr_behavior_br_behavior_achoholamount_Enabled = 0;
         edtavBr_behavior_br_behavior_achoholtime_Jsonclick = "";
         edtavBr_behavior_br_behavior_achoholtime_Enabled = 0;
         dynavBr_behavior_br_behavior_achohol_Jsonclick = "";
         dynavBr_behavior_br_behavior_achohol.Enabled = 0;
         edtavBr_behavior_br_behavior_rawsmokingamount_Jsonclick = "";
         edtavBr_behavior_br_behavior_rawsmokingamount_Enabled = 0;
         edtavBr_behavior_br_behavior_smokingamount_Jsonclick = "";
         edtavBr_behavior_br_behavior_smokingamount_Enabled = 0;
         edtavBr_behavior_br_behavior_smokingtime_Jsonclick = "";
         edtavBr_behavior_br_behavior_smokingtime_Enabled = 0;
         dynavBr_behavior_br_behavior_smoking_Jsonclick = "";
         dynavBr_behavior_br_behavior_smoking.Enabled = 0;
         edtavBr_behavior_br_behavior_menopauseage_Enabled = -1;
         cmbavBr_behavior_br_behavior_menopause.Enabled = -1;
         edtavBr_behavior_br_behavior_rawmenopauseage_Enabled = -1;
         edtavBr_behavior_br_behavior_familycancer_Enabled = -1;
         cmbavBr_behavior_br_behavior_familycahistory.Enabled = -1;
         edtavBr_behavior_br_behavior_childnum_Enabled = -1;
         edtavBr_behavior_br_behavior_rawachoholamount_Enabled = -1;
         edtavBr_behavior_br_behavior_achoholamount_Enabled = -1;
         edtavBr_behavior_br_behavior_achoholtime_Enabled = -1;
         dynavBr_behavior_br_behavior_achohol.Enabled = -1;
         edtavBr_behavior_br_behavior_rawsmokingamount_Enabled = -1;
         edtavBr_behavior_br_behavior_smokingamount_Enabled = -1;
         edtavBr_behavior_br_behavior_smokingtime_Enabled = -1;
         dynavBr_behavior_br_behavior_smoking.Enabled = -1;
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
         AV38Pgmname = "";
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         GXKey = "";
         AV13BR_Behavior = new SdtBR_Behavior(context);
         GX_FocusControl = "";
         lblTextblockbr_behavior_br_behavior_familycancer_Jsonclick = "";
         ClassString = "";
         StyleString = "";
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
         H003V2_A167XT_DefineCodeID = new long[1] ;
         H003V2_A168XT_DefineCodeName = new String[] {""} ;
         H003V2_n168XT_DefineCodeName = new bool[] {false} ;
         H003V2_A165XT_DefindcodeTypeID = new long[1] ;
         H003V2_A432XT_TenantCode = new String[] {""} ;
         H003V2_n432XT_TenantCode = new bool[] {false} ;
         H003V3_A167XT_DefineCodeID = new long[1] ;
         H003V3_A168XT_DefineCodeName = new String[] {""} ;
         H003V3_n168XT_DefineCodeName = new bool[] {false} ;
         H003V3_A165XT_DefindcodeTypeID = new long[1] ;
         H003V3_A432XT_TenantCode = new String[] {""} ;
         H003V3_n432XT_TenantCode = new bool[] {false} ;
         AV6WWPContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPContext(context);
         H003V4_A19BR_EncounterID = new long[1] ;
         H003V4_A20BR_BehaviorID = new long[1] ;
         H003V5_A19BR_EncounterID = new long[1] ;
         H003V5_A61BR_Demographics_ID = new long[1] ;
         AV14BCBR_Demographics = new SdtBR_Demographics(context);
         AV9TrnContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext(context);
         AV12HTTPRequest = new GxHttpRequest( context);
         AV10TrnContextAtt = new GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext_Attribute(context);
         AV11Session = context.GetSession();
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         sCtrlA19BR_EncounterID = "";
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.br_encountercheckbehavior__default(),
            new Object[][] {
                new Object[] {
               H003V2_A167XT_DefineCodeID, H003V2_A168XT_DefineCodeName, H003V2_n168XT_DefineCodeName, H003V2_A165XT_DefindcodeTypeID, H003V2_A432XT_TenantCode, H003V2_n432XT_TenantCode
               }
               , new Object[] {
               H003V3_A167XT_DefineCodeID, H003V3_A168XT_DefineCodeName, H003V3_n168XT_DefineCodeName, H003V3_A165XT_DefindcodeTypeID, H003V3_A432XT_TenantCode, H003V3_n432XT_TenantCode
               }
               , new Object[] {
               H003V4_A19BR_EncounterID, H003V4_A20BR_BehaviorID
               }
               , new Object[] {
               H003V5_A19BR_EncounterID, H003V5_A61BR_Demographics_ID
               }
            }
         );
         AV38Pgmname = "BR_EncounterCheckBehavior";
         /* GeneXus formulas. */
         AV38Pgmname = "BR_EncounterCheckBehavior";
         context.Gx_err = 0;
         dynavBr_behavior_br_behavior_smoking.Enabled = 0;
         edtavBr_behavior_br_behavior_smokingtime_Enabled = 0;
         edtavBr_behavior_br_behavior_smokingamount_Enabled = 0;
         edtavBr_behavior_br_behavior_rawsmokingamount_Enabled = 0;
         dynavBr_behavior_br_behavior_achohol.Enabled = 0;
         edtavBr_behavior_br_behavior_achoholtime_Enabled = 0;
         edtavBr_behavior_br_behavior_achoholamount_Enabled = 0;
         edtavBr_behavior_br_behavior_rawachoholamount_Enabled = 0;
         edtavBr_behavior_br_behavior_childnum_Enabled = 0;
         cmbavBr_behavior_br_behavior_familycahistory.Enabled = 0;
         edtavBr_behavior_br_behavior_familycancer_Enabled = 0;
         edtavBr_behavior_br_behavior_rawmenopauseage_Enabled = 0;
         cmbavBr_behavior_br_behavior_menopause.Enabled = 0;
         edtavBr_behavior_br_behavior_menopauseage_Enabled = 0;
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
      private int edtavBr_behavior_br_behavior_smokingtime_Enabled ;
      private int edtavBr_behavior_br_behavior_smokingamount_Enabled ;
      private int edtavBr_behavior_br_behavior_rawsmokingamount_Enabled ;
      private int edtavBr_behavior_br_behavior_achoholtime_Enabled ;
      private int edtavBr_behavior_br_behavior_achoholamount_Enabled ;
      private int edtavBr_behavior_br_behavior_rawachoholamount_Enabled ;
      private int edtavBr_behavior_br_behavior_childnum_Enabled ;
      private int edtavBr_behavior_br_behavior_familycancer_Enabled ;
      private int edtavBr_behavior_br_behavior_rawmenopauseage_Enabled ;
      private int edtavBr_behavior_br_behavior_menopauseage_Enabled ;
      private int divCancer_Visible ;
      private int divManopsuse_Visible ;
      private int divAge_Visible ;
      private int edtavBr_behavior_br_behaviorid_Visible ;
      private int edtavBr_behavior_br_encounterid_Visible ;
      private int edtavBr_behavior_br_information_patientno_Visible ;
      private int gxdynajaxindex ;
      private int idxLst ;
      private long A19BR_EncounterID ;
      private long wcpOA19BR_EncounterID ;
      private long A20BR_BehaviorID ;
      private long A61BR_Demographics_ID ;
      private long AV8BR_EncounterID ;
      private decimal AV39Tcurrentcode ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String sPrefix ;
      private String sCompPrefix ;
      private String sSFPrefix ;
      private String AV38Pgmname ;
      private String dynavBr_behavior_br_behavior_smoking_Internalname ;
      private String edtavBr_behavior_br_behavior_smokingtime_Internalname ;
      private String edtavBr_behavior_br_behavior_smokingamount_Internalname ;
      private String edtavBr_behavior_br_behavior_rawsmokingamount_Internalname ;
      private String dynavBr_behavior_br_behavior_achohol_Internalname ;
      private String edtavBr_behavior_br_behavior_achoholtime_Internalname ;
      private String edtavBr_behavior_br_behavior_achoholamount_Internalname ;
      private String edtavBr_behavior_br_behavior_rawachoholamount_Internalname ;
      private String edtavBr_behavior_br_behavior_childnum_Internalname ;
      private String cmbavBr_behavior_br_behavior_familycahistory_Internalname ;
      private String edtavBr_behavior_br_behavior_familycancer_Internalname ;
      private String edtavBr_behavior_br_behavior_rawmenopauseage_Internalname ;
      private String cmbavBr_behavior_br_behavior_menopause_Internalname ;
      private String edtavBr_behavior_br_behavior_menopauseage_Internalname ;
      private String sDynURL ;
      private String FormProcess ;
      private String bodyStyle ;
      private String GXKey ;
      private String GX_FocusControl ;
      private String divLayoutmaintable_Internalname ;
      private String divUnnamedtable1_Internalname ;
      private String dynavBr_behavior_br_behavior_smoking_Jsonclick ;
      private String edtavBr_behavior_br_behavior_smokingtime_Jsonclick ;
      private String edtavBr_behavior_br_behavior_smokingamount_Jsonclick ;
      private String edtavBr_behavior_br_behavior_rawsmokingamount_Jsonclick ;
      private String dynavBr_behavior_br_behavior_achohol_Jsonclick ;
      private String edtavBr_behavior_br_behavior_achoholtime_Jsonclick ;
      private String edtavBr_behavior_br_behavior_achoholamount_Jsonclick ;
      private String edtavBr_behavior_br_behavior_rawachoholamount_Jsonclick ;
      private String edtavBr_behavior_br_behavior_childnum_Jsonclick ;
      private String cmbavBr_behavior_br_behavior_familycahistory_Jsonclick ;
      private String divCancer_Internalname ;
      private String divUnnamedtablebr_behavior_br_behavior_familycancer_Internalname ;
      private String lblTextblockbr_behavior_br_behavior_familycancer_Internalname ;
      private String lblTextblockbr_behavior_br_behavior_familycancer_Jsonclick ;
      private String ClassString ;
      private String StyleString ;
      private String divManopsuse_Internalname ;
      private String edtavBr_behavior_br_behavior_rawmenopauseage_Jsonclick ;
      private String cmbavBr_behavior_br_behavior_menopause_Jsonclick ;
      private String divAge_Internalname ;
      private String edtavBr_behavior_br_behavior_menopauseage_Jsonclick ;
      private String divHtml_bottomauxiliarcontrols_Internalname ;
      private String TempTags ;
      private String edtavBr_behavior_br_behaviorid_Internalname ;
      private String edtavBr_behavior_br_behaviorid_Jsonclick ;
      private String edtavBr_behavior_br_encounterid_Internalname ;
      private String edtavBr_behavior_br_encounterid_Jsonclick ;
      private String edtavBr_behavior_br_information_patientno_Internalname ;
      private String edtavBr_behavior_br_information_patientno_Jsonclick ;
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
      private GXCombobox dynavBr_behavior_br_behavior_smoking ;
      private GXCombobox dynavBr_behavior_br_behavior_achohol ;
      private GXCombobox cmbavBr_behavior_br_behavior_familycahistory ;
      private GXCombobox cmbavBr_behavior_br_behavior_menopause ;
      private IDataStoreProvider pr_default ;
      private long[] H003V2_A167XT_DefineCodeID ;
      private String[] H003V2_A168XT_DefineCodeName ;
      private bool[] H003V2_n168XT_DefineCodeName ;
      private long[] H003V2_A165XT_DefindcodeTypeID ;
      private String[] H003V2_A432XT_TenantCode ;
      private bool[] H003V2_n432XT_TenantCode ;
      private long[] H003V3_A167XT_DefineCodeID ;
      private String[] H003V3_A168XT_DefineCodeName ;
      private bool[] H003V3_n168XT_DefineCodeName ;
      private long[] H003V3_A165XT_DefindcodeTypeID ;
      private String[] H003V3_A432XT_TenantCode ;
      private bool[] H003V3_n432XT_TenantCode ;
      private long[] H003V4_A19BR_EncounterID ;
      private long[] H003V4_A20BR_BehaviorID ;
      private long[] H003V5_A19BR_EncounterID ;
      private long[] H003V5_A61BR_Demographics_ID ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private GxHttpRequest AV12HTTPRequest ;
      private IGxSession AV11Session ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPContext AV6WWPContext ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext AV9TrnContext ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext_Attribute AV10TrnContextAtt ;
      private SdtBR_Behavior AV13BR_Behavior ;
      private SdtBR_Demographics AV14BCBR_Demographics ;
   }

   public class br_encountercheckbehavior__default : DataStoreHelperBase, IDataStoreHelper
   {
      public ICursor[] getCursors( )
      {
         cursorDefinitions();
         return new Cursor[] {
          new ForEachCursor(def[0])
         ,new ForEachCursor(def[1])
         ,new ForEachCursor(def[2])
         ,new ForEachCursor(def[3])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmH003V2 ;
          prmH003V2 = new Object[] {
          new Object[] {"@AV39Tcurrentcode",SqlDbType.Decimal,10,2}
          } ;
          Object[] prmH003V3 ;
          prmH003V3 = new Object[] {
          new Object[] {"@AV39Tcurrentcode",SqlDbType.Decimal,10,2}
          } ;
          Object[] prmH003V4 ;
          prmH003V4 = new Object[] {
          new Object[] {"@BR_EncounterID",SqlDbType.Decimal,18,0}
          } ;
          Object[] prmH003V5 ;
          prmH003V5 = new Object[] {
          new Object[] {"@BR_EncounterID",SqlDbType.Decimal,18,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("H003V2", "SELECT [XT_DefineCodeID], [XT_DefineCodeName], [XT_DefindcodeTypeID], [XT_TenantCode] FROM [XT_DefineCode] WITH (NOLOCK) WHERE ([XT_DefindcodeTypeID] = 12) AND ([XT_TenantCode] = @AV39Tcurrentcode) ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH003V2,0,0,true,false )
             ,new CursorDef("H003V3", "SELECT [XT_DefineCodeID], [XT_DefineCodeName], [XT_DefindcodeTypeID], [XT_TenantCode] FROM [XT_DefineCode] WITH (NOLOCK) WHERE ([XT_DefindcodeTypeID] = 14) AND ([XT_TenantCode] = @AV39Tcurrentcode) ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH003V3,0,0,true,false )
             ,new CursorDef("H003V4", "SELECT TOP 1 [BR_EncounterID], [BR_BehaviorID] FROM [BR_Behavior] WITH (NOLOCK) WHERE [BR_EncounterID] = @BR_EncounterID ORDER BY [BR_EncounterID] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH003V4,1,0,true,true )
             ,new CursorDef("H003V5", "SELECT TOP 1 [BR_EncounterID], [BR_Demographics_ID] FROM [BR_Demographics] WITH (NOLOCK) WHERE [BR_EncounterID] = @BR_EncounterID ORDER BY [BR_EncounterID] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH003V5,1,0,true,true )
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
             case 3 :
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
             case 3 :
                stmt.SetParameter(1, (long)parms[0]);
                return;
       }
    }

 }

}
