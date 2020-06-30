/*
               File: BR_EncounterGeneral
        Description: Data Mgmt Portal - RAAP
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/27/2020 9:36:22.1
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
   public class br_encountergeneral : GXWebComponent, System.Web.SessionState.IRequiresSessionState
   {
      public br_encountergeneral( )
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

      public br_encountergeneral( IGxContext context )
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
            PA162( ) ;
            if ( ( GxWebError == 0 ) && ! isAjaxCallMode( ) )
            {
               /* GeneXus formulas. */
               AV20Pgmname = "BR_EncounterGeneral";
               context.Gx_err = 0;
               edtavVdepartment_Enabled = 0;
               context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavVdepartment_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavVdepartment_Enabled), 5, 0)), true);
               edtavVenctype_Enabled = 0;
               context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavVenctype_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavVenctype_Enabled), 5, 0)), true);
               edtavVreason_Enabled = 0;
               context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavVreason_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavVreason_Enabled), 5, 0)), true);
               WS162( ) ;
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
         context.AddJavascriptSource("gxcfg.js", "?2020227936227", false);
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
            context.WriteHtmlTextNl( "<form id=\"MAINFORM\" autocomplete=\"off\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("br_encountergeneral.aspx") + "?" + UrlEncode("" +A19BR_EncounterID)+"\">") ;
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
         forbiddenHiddens = sPrefix + "hsh" + "BR_EncounterGeneral";
         forbiddenHiddens = forbiddenHiddens + context.localUtil.Format( (decimal)(A85BR_Information_ID), "ZZZZZZZZZZZZZZZZZZ");
         forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( A84BR_Encounter_Department, ""));
         forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( A90BR_Encounter_ENCType, ""));
         forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( A92BR_Encounter_AdmitSource, ""));
         GxWebStd.gx_hidden_field( context, sPrefix+"hsh", GetEncryptedHash( forbiddenHiddens, GXKey));
         GXUtil.WriteLog("br_encountergeneral:[SendSecurityCheck value for]"+"BR_Information_ID:"+context.localUtil.Format( (decimal)(A85BR_Information_ID), "ZZZZZZZZZZZZZZZZZZ"));
         GXUtil.WriteLog("br_encountergeneral:[SendSecurityCheck value for]"+"BR_Encounter_Department:"+StringUtil.RTrim( context.localUtil.Format( A84BR_Encounter_Department, "")));
         GXUtil.WriteLog("br_encountergeneral:[SendSecurityCheck value for]"+"BR_Encounter_ENCType:"+StringUtil.RTrim( context.localUtil.Format( A90BR_Encounter_ENCType, "")));
         GXUtil.WriteLog("br_encountergeneral:[SendSecurityCheck value for]"+"BR_Encounter_AdmitSource:"+StringUtil.RTrim( context.localUtil.Format( A92BR_Encounter_AdmitSource, "")));
      }

      protected void SendCloseFormHiddens( )
      {
         /* Send hidden variables. */
         /* Send saved values. */
         send_integrity_footer_hashes( ) ;
         GxWebStd.gx_hidden_field( context, sPrefix+"wcpOA19BR_EncounterID", StringUtil.LTrim( StringUtil.NToC( (decimal)(wcpOA19BR_EncounterID), 18, 0, ".", "")));
      }

      protected void RenderHtmlCloseForm162( )
      {
         SendCloseFormHiddens( ) ;
         if ( ( StringUtil.Len( sPrefix) != 0 ) && ( context.isAjaxRequest( ) || context.isSpaRequest( ) ) )
         {
            context.AddJavascriptSource("br_encountergeneral.js", "?20202279362210", false);
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
         return "BR_EncounterGeneral" ;
      }

      public override String GetPgmdesc( )
      {
         return "Data Mgmt Portal - RAAP" ;
      }

      protected void WB160( )
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
               GxWebStd.gx_hidden_field( context, sPrefix+"_CMPPGM", "br_encountergeneral.aspx");
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
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-md-6 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtBR_Information_ID_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtBR_Information_ID_Internalname, "就诊序号", "col-sm-3 ReadonlyAttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtBR_Information_ID_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A85BR_Information_ID), 18, 0, ".", "")), ((edtBR_Information_ID_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A85BR_Information_ID), "ZZZZZZZZZZZZZZZZZZ")) : context.localUtil.Format( (decimal)(A85BR_Information_ID), "ZZZZZZZZZZZZZZZZZZ")), "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBR_Information_ID_Jsonclick, 0, "ReadonlyAttribute", "", "", "", "", 1, edtBR_Information_ID_Enabled, 0, "number", "1", 18, "chr", 1, "row", 18, 0, 0, 0, 1, -1, 0, true, "ID", "right", false, "HLP_BR_EncounterGeneral.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-md-6 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtBR_Information_PatientNo_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtBR_Information_PatientNo_Internalname, "患者编号", "col-sm-3 ReadonlyAttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtBR_Information_PatientNo_Internalname, A36BR_Information_PatientNo, StringUtil.RTrim( context.localUtil.Format( A36BR_Information_PatientNo, "")), "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", edtBR_Information_PatientNo_Link, "", "", "", edtBR_Information_PatientNo_Jsonclick, 0, "ReadonlyAttribute", "", "", "", "", 1, edtBR_Information_PatientNo_Enabled, 0, "text", "", 80, "chr", 1, "row", 2000, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_BR_EncounterGeneral.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-md-6 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divTablesplittedbr_encounter_department_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-3 MergeLabelCell", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblockbr_encounter_department_Internalname, "就诊科室", "", "", lblTextblockbr_encounter_department_Jsonclick, "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_BR_EncounterGeneral.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-9", "left", "top", "", "", "div");
            wb_table1_26_162( true) ;
         }
         else
         {
            wb_table1_26_162( false) ;
         }
         return  ;
      }

      protected void wb_table1_26_162e( bool wbgen )
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
            GxWebStd.gx_div_start( context, divTablesplittedbr_encounter_enctype_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-3 MergeLabelCell", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblockbr_encounter_enctype_Internalname, "就诊方式", "", "", lblTextblockbr_encounter_enctype_Jsonclick, "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_BR_EncounterGeneral.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-9", "left", "top", "", "", "div");
            wb_table2_40_162( true) ;
         }
         else
         {
            wb_table2_40_162( false) ;
         }
         return  ;
      }

      protected void wb_table2_40_162e( bool wbgen )
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
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtBR_Encounter_AdmitDate_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtBR_Encounter_AdmitDate_Internalname, "就诊/入院时间", "col-sm-3 ReadonlyAttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            context.WriteHtmlText( "<div id=\""+edtBR_Encounter_AdmitDate_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtBR_Encounter_AdmitDate_Internalname, context.localUtil.Format(A91BR_Encounter_AdmitDate, "9999/99/99"), context.localUtil.Format( A91BR_Encounter_AdmitDate, "9999/99/99"), "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBR_Encounter_AdmitDate_Jsonclick, 0, "ReadonlyAttribute", "", "", "", "", 1, edtBR_Encounter_AdmitDate_Enabled, 0, "text", "", 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, 0, true, "DM_Date", "right", false, "HLP_BR_EncounterGeneral.htm");
            GxWebStd.gx_bitmap( context, edtBR_Encounter_AdmitDate_Internalname+"_dp_trigger", context.GetImagePath( "61b9b5d3-dff6-4d59-9b00-da61bc2cbe93", "", context.GetTheme( )), "", "", "", "", ((1==0)||(edtBR_Encounter_AdmitDate_Enabled==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;", "", "", "", "", "", "", "", "", 1, false, false, "", "HLP_BR_EncounterGeneral.htm");
            context.WriteHtmlTextNl( "</div>") ;
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-md-6 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divTablesplittedbr_encounter_admitsource_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-3 MergeLabelCell", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblockbr_encounter_admitsource_Internalname, "入院原因", "", "", lblTextblockbr_encounter_admitsource_Jsonclick, "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_BR_EncounterGeneral.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-9", "left", "top", "", "", "div");
            wb_table3_59_162( true) ;
         }
         else
         {
            wb_table3_59_162( false) ;
         }
         return  ;
      }

      protected void wb_table3_59_162e( bool wbgen )
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
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtBR_Encounter_DischargeDate_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtBR_Encounter_DischargeDate_Internalname, "出院时间", "col-sm-3 ReadonlyAttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            context.WriteHtmlText( "<div id=\""+edtBR_Encounter_DischargeDate_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtBR_Encounter_DischargeDate_Internalname, context.localUtil.Format(A93BR_Encounter_DischargeDate, "9999/99/99"), context.localUtil.Format( A93BR_Encounter_DischargeDate, "9999/99/99"), "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBR_Encounter_DischargeDate_Jsonclick, 0, "ReadonlyAttribute", "", "", "", "", 1, edtBR_Encounter_DischargeDate_Enabled, 0, "text", "", 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, 0, true, "DM_Date", "right", false, "HLP_BR_EncounterGeneral.htm");
            GxWebStd.gx_bitmap( context, edtBR_Encounter_DischargeDate_Internalname+"_dp_trigger", context.GetImagePath( "61b9b5d3-dff6-4d59-9b00-da61bc2cbe93", "", context.GetTheme( )), "", "", "", "", ((1==0)||(edtBR_Encounter_DischargeDate_Enabled==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;", "", "", "", "", "", "", "", "", 1, false, false, "", "HLP_BR_EncounterGeneral.htm");
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
            GxWebStd.gx_single_line_edit( context, edtBR_Encounter_DischargeStatus_Internalname, A94BR_Encounter_DischargeStatus, StringUtil.RTrim( context.localUtil.Format( A94BR_Encounter_DischargeStatus, "")), "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBR_Encounter_DischargeStatus_Jsonclick, 0, "ReadonlyAttribute", "", "", "", "", 1, edtBR_Encounter_DischargeStatus_Enabled, 0, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_BR_EncounterGeneral.htm");
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
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 80,'" + sPrefix + "',false,'',0)\"";
            ClassString = "ButtonMaterial";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtnupdate_Internalname, "", "修改", bttBtnupdate_Jsonclick, 7, "修改", "", StyleString, ClassString, 1, 1, "standard", "'"+sPrefix+"'"+",false,"+"'"+"e11161_client"+"'", TempTags, "", 2, "HLP_BR_EncounterGeneral.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 82,'" + sPrefix + "',false,'',0)\"";
            ClassString = "ButtonMaterialDefault";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtndelete_Internalname, "", "删除", bttBtndelete_Jsonclick, 7, "删除", "", StyleString, ClassString, 1, 1, "standard", "'"+sPrefix+"'"+",false,"+"'"+"e12161_client"+"'", TempTags, "", 2, "HLP_BR_EncounterGeneral.htm");
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
            GxWebStd.gx_single_line_edit( context, edtBR_EncounterID_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A19BR_EncounterID), 18, 0, ".", "")), context.localUtil.Format( (decimal)(A19BR_EncounterID), "ZZZZZZZZZZZZZZZZZZ"), "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBR_EncounterID_Jsonclick, 0, "Attribute", "", "", "", "", edtBR_EncounterID_Visible, 0, 0, "number", "1", 18, "chr", 1, "row", 18, 0, 0, 0, 1, -1, 0, true, "ID", "right", false, "HLP_BR_EncounterGeneral.htm");
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtBR_Encounter_EncID_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A35BR_Encounter_EncID), 10, 0, ".", "")), context.localUtil.Format( (decimal)(A35BR_Encounter_EncID), "ZZZZZZZZZZ"), "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBR_Encounter_EncID_Jsonclick, 0, "Attribute", "", "", "", "", edtBR_Encounter_EncID_Visible, 0, 0, "number", "1", 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_BR_EncounterGeneral.htm");
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, cmbBR_Encounter_Status, cmbBR_Encounter_Status_Internalname, StringUtil.Trim( StringUtil.Str( (decimal)(A172BR_Encounter_Status), 4, 0)), 1, cmbBR_Encounter_Status_Jsonclick, 0, "'"+sPrefix+"'"+",false,"+"'"+""+"'", "int", "", cmbBR_Encounter_Status.Visible, 0, 0, 0, 0, "em", 0, "", "", "Attribute", "", "", "", "", true, "HLP_BR_EncounterGeneral.htm");
            cmbBR_Encounter_Status.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(A172BR_Encounter_Status), 4, 0));
            context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, cmbBR_Encounter_Status_Internalname, "Values", (String)(cmbBR_Encounter_Status.ToJavascriptSource()), true);
            /* Single line edit */
            context.WriteHtmlText( "<div id=\""+edtBR_Encounter_CrtDate_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtBR_Encounter_CrtDate_Internalname, context.localUtil.TToC( A182BR_Encounter_CrtDate, 10, 8, 0, 0, "/", ":", " "), context.localUtil.Format( A182BR_Encounter_CrtDate, "9999/99/99 99:99:99"), "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBR_Encounter_CrtDate_Jsonclick, 0, "Attribute", "", "", "", "", edtBR_Encounter_CrtDate_Visible, 0, 0, "text", "", 19, "chr", 1, "row", 19, 0, 0, 0, 1, -1, 0, true, "UpdDate", "right", false, "HLP_BR_EncounterGeneral.htm");
            GxWebStd.gx_bitmap( context, edtBR_Encounter_CrtDate_Internalname+"_dp_trigger", context.GetImagePath( "61b9b5d3-dff6-4d59-9b00-da61bc2cbe93", "", context.GetTheme( )), "", "", "", "", ((edtBR_Encounter_CrtDate_Visible==0)||(0==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;", "", "", "", "", "", "", "", "", 1, false, false, "", "HLP_BR_EncounterGeneral.htm");
            context.WriteHtmlTextNl( "</div>") ;
            /* Single line edit */
            context.WriteHtmlText( "<div id=\""+edtBR_Encounter_UpdDate_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtBR_Encounter_UpdDate_Internalname, context.localUtil.TToC( A187BR_Encounter_UpdDate, 10, 8, 0, 0, "/", ":", " "), context.localUtil.Format( A187BR_Encounter_UpdDate, "9999/99/99 99:99:99"), "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBR_Encounter_UpdDate_Jsonclick, 0, "Attribute", "", "", "", "", edtBR_Encounter_UpdDate_Visible, 0, 0, "text", "", 19, "chr", 1, "row", 19, 0, 0, 0, 1, -1, 0, true, "UpdDate", "right", false, "HLP_BR_EncounterGeneral.htm");
            GxWebStd.gx_bitmap( context, edtBR_Encounter_UpdDate_Internalname+"_dp_trigger", context.GetImagePath( "61b9b5d3-dff6-4d59-9b00-da61bc2cbe93", "", context.GetTheme( )), "", "", "", "", ((edtBR_Encounter_UpdDate_Visible==0)||(0==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;", "", "", "", "", "", "", "", "", 1, false, false, "", "HLP_BR_EncounterGeneral.htm");
            context.WriteHtmlTextNl( "</div>") ;
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtBR_Encounter_CrtUser_Internalname, A183BR_Encounter_CrtUser, StringUtil.RTrim( context.localUtil.Format( A183BR_Encounter_CrtUser, "")), "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBR_Encounter_CrtUser_Jsonclick, 0, "Attribute", "", "", "", "", edtBR_Encounter_CrtUser_Visible, 0, 0, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, -1, true, "CrtUser", "left", true, "HLP_BR_EncounterGeneral.htm");
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtBR_Encounter_UpdUser_Internalname, A186BR_Encounter_UpdUser, StringUtil.RTrim( context.localUtil.Format( A186BR_Encounter_UpdUser, "")), "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBR_Encounter_UpdUser_Jsonclick, 0, "Attribute", "", "", "", "", edtBR_Encounter_UpdUser_Visible, 0, 0, "text", "", 40, "chr", 1, "row", 40, 0, 0, 0, 1, -1, -1, true, "UpdUser", "left", true, "HLP_BR_EncounterGeneral.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
         }
         wbLoad = true;
      }

      protected void START162( )
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
               STRUP160( ) ;
            }
         }
      }

      protected void WS162( )
      {
         START162( ) ;
         EVT162( ) ;
      }

      protected void EVT162( )
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
                                 STRUP160( ) ;
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
                                 STRUP160( ) ;
                              }
                              if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
                              {
                                 context.wbHandled = 1;
                                 if ( ! wbErr )
                                 {
                                    dynload_actions( ) ;
                                    /* Execute user event: Start */
                                    E13162 ();
                                 }
                              }
                           }
                           else if ( StringUtil.StrCmp(sEvt, "LOAD") == 0 )
                           {
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP160( ) ;
                              }
                              if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
                              {
                                 context.wbHandled = 1;
                                 if ( ! wbErr )
                                 {
                                    dynload_actions( ) ;
                                    /* Execute user event: Load */
                                    E14162 ();
                                 }
                              }
                           }
                           else if ( StringUtil.StrCmp(sEvt, "ENTER") == 0 )
                           {
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP160( ) ;
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
                                 STRUP160( ) ;
                              }
                              if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
                              {
                                 context.wbHandled = 1;
                                 if ( ! wbErr )
                                 {
                                    dynload_actions( ) ;
                                    GX_FocusControl = edtavVdepartment_Internalname;
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

      protected void WE162( )
      {
         if ( ! GxWebStd.gx_redirect( context) )
         {
            Rfr0gs = true;
            Refresh( ) ;
            if ( ! GxWebStd.gx_redirect( context) )
            {
               RenderHtmlCloseForm162( ) ;
            }
         }
      }

      protected void PA162( )
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
               GX_FocusControl = edtavVdepartment_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "GX_FocusControl", GX_FocusControl);
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
         RF162( ) ;
         if ( isFullAjaxMode( ) )
         {
            send_integrity_footer_hashes( ) ;
         }
      }

      protected void initialize_formulas( )
      {
         /* GeneXus formulas. */
         AV20Pgmname = "BR_EncounterGeneral";
         context.Gx_err = 0;
         edtavVdepartment_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavVdepartment_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavVdepartment_Enabled), 5, 0)), true);
         edtavVenctype_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavVenctype_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavVenctype_Enabled), 5, 0)), true);
         edtavVreason_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavVreason_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavVreason_Enabled), 5, 0)), true);
      }

      protected void RF162( )
      {
         initialize_formulas( ) ;
         clear_multi_value_controls( ) ;
         gxdyncontrolsrefreshing = true;
         fix_multi_value_controls( ) ;
         gxdyncontrolsrefreshing = false;
         if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
         {
            /* Using cursor H00162 */
            pr_default.execute(0, new Object[] {A19BR_EncounterID});
            while ( (pr_default.getStatus(0) != 101) )
            {
               A186BR_Encounter_UpdUser = H00162_A186BR_Encounter_UpdUser[0];
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A186BR_Encounter_UpdUser", A186BR_Encounter_UpdUser);
               n186BR_Encounter_UpdUser = H00162_n186BR_Encounter_UpdUser[0];
               A183BR_Encounter_CrtUser = H00162_A183BR_Encounter_CrtUser[0];
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A183BR_Encounter_CrtUser", A183BR_Encounter_CrtUser);
               n183BR_Encounter_CrtUser = H00162_n183BR_Encounter_CrtUser[0];
               A187BR_Encounter_UpdDate = H00162_A187BR_Encounter_UpdDate[0];
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A187BR_Encounter_UpdDate", context.localUtil.TToC( A187BR_Encounter_UpdDate, 10, 8, 0, 0, "/", ":", " "));
               n187BR_Encounter_UpdDate = H00162_n187BR_Encounter_UpdDate[0];
               A182BR_Encounter_CrtDate = H00162_A182BR_Encounter_CrtDate[0];
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A182BR_Encounter_CrtDate", context.localUtil.TToC( A182BR_Encounter_CrtDate, 10, 8, 0, 0, "/", ":", " "));
               n182BR_Encounter_CrtDate = H00162_n182BR_Encounter_CrtDate[0];
               A172BR_Encounter_Status = H00162_A172BR_Encounter_Status[0];
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A172BR_Encounter_Status", StringUtil.LTrim( StringUtil.Str( (decimal)(A172BR_Encounter_Status), 4, 0)));
               n172BR_Encounter_Status = H00162_n172BR_Encounter_Status[0];
               A35BR_Encounter_EncID = H00162_A35BR_Encounter_EncID[0];
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A35BR_Encounter_EncID", StringUtil.LTrim( StringUtil.Str( (decimal)(A35BR_Encounter_EncID), 10, 0)));
               n35BR_Encounter_EncID = H00162_n35BR_Encounter_EncID[0];
               A94BR_Encounter_DischargeStatus = H00162_A94BR_Encounter_DischargeStatus[0];
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A94BR_Encounter_DischargeStatus", A94BR_Encounter_DischargeStatus);
               n94BR_Encounter_DischargeStatus = H00162_n94BR_Encounter_DischargeStatus[0];
               A93BR_Encounter_DischargeDate = H00162_A93BR_Encounter_DischargeDate[0];
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A93BR_Encounter_DischargeDate", context.localUtil.Format(A93BR_Encounter_DischargeDate, "9999/99/99"));
               n93BR_Encounter_DischargeDate = H00162_n93BR_Encounter_DischargeDate[0];
               A92BR_Encounter_AdmitSource = H00162_A92BR_Encounter_AdmitSource[0];
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A92BR_Encounter_AdmitSource", A92BR_Encounter_AdmitSource);
               n92BR_Encounter_AdmitSource = H00162_n92BR_Encounter_AdmitSource[0];
               A91BR_Encounter_AdmitDate = H00162_A91BR_Encounter_AdmitDate[0];
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A91BR_Encounter_AdmitDate", context.localUtil.Format(A91BR_Encounter_AdmitDate, "9999/99/99"));
               n91BR_Encounter_AdmitDate = H00162_n91BR_Encounter_AdmitDate[0];
               A90BR_Encounter_ENCType = H00162_A90BR_Encounter_ENCType[0];
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A90BR_Encounter_ENCType", A90BR_Encounter_ENCType);
               n90BR_Encounter_ENCType = H00162_n90BR_Encounter_ENCType[0];
               A84BR_Encounter_Department = H00162_A84BR_Encounter_Department[0];
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A84BR_Encounter_Department", A84BR_Encounter_Department);
               n84BR_Encounter_Department = H00162_n84BR_Encounter_Department[0];
               A36BR_Information_PatientNo = H00162_A36BR_Information_PatientNo[0];
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A36BR_Information_PatientNo", A36BR_Information_PatientNo);
               n36BR_Information_PatientNo = H00162_n36BR_Information_PatientNo[0];
               A85BR_Information_ID = H00162_A85BR_Information_ID[0];
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A85BR_Information_ID", StringUtil.LTrim( StringUtil.Str( (decimal)(A85BR_Information_ID), 18, 0)));
               n85BR_Information_ID = H00162_n85BR_Information_ID[0];
               A36BR_Information_PatientNo = H00162_A36BR_Information_PatientNo[0];
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A36BR_Information_PatientNo", A36BR_Information_PatientNo);
               n36BR_Information_PatientNo = H00162_n36BR_Information_PatientNo[0];
               /* Execute user event: Load */
               E14162 ();
               /* Exiting from a For First loop. */
               if (true) break;
            }
            pr_default.close(0);
            WB160( ) ;
         }
      }

      protected void send_integrity_lvl_hashes162( )
      {
      }

      protected void STRUP160( )
      {
         /* Before Start, stand alone formulas. */
         AV20Pgmname = "BR_EncounterGeneral";
         context.Gx_err = 0;
         edtavVdepartment_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavVdepartment_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavVdepartment_Enabled), 5, 0)), true);
         edtavVenctype_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavVenctype_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavVenctype_Enabled), 5, 0)), true);
         edtavVreason_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavVreason_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavVreason_Enabled), 5, 0)), true);
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0;
         /* Execute user event: Start */
         E13162 ();
         context.wbGlbDoneStart = 1;
         nDoneStart = 1;
         /* After Start, stand alone formulas. */
         sXEvt = cgiGet( "_EventName");
         if ( ! GetJustCreated( ) && ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 ) )
         {
            /* Read saved SDTs. */
            /* Read variables values. */
            A85BR_Information_ID = (long)(context.localUtil.CToN( cgiGet( edtBR_Information_ID_Internalname), ".", ","));
            n85BR_Information_ID = false;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A85BR_Information_ID", StringUtil.LTrim( StringUtil.Str( (decimal)(A85BR_Information_ID), 18, 0)));
            A36BR_Information_PatientNo = cgiGet( edtBR_Information_PatientNo_Internalname);
            n36BR_Information_PatientNo = false;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A36BR_Information_PatientNo", A36BR_Information_PatientNo);
            A84BR_Encounter_Department = cgiGet( edtBR_Encounter_Department_Internalname);
            n84BR_Encounter_Department = false;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A84BR_Encounter_Department", A84BR_Encounter_Department);
            AV14vDepartment = cgiGet( edtavVdepartment_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV14vDepartment", AV14vDepartment);
            A90BR_Encounter_ENCType = cgiGet( edtBR_Encounter_ENCType_Internalname);
            n90BR_Encounter_ENCType = false;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A90BR_Encounter_ENCType", A90BR_Encounter_ENCType);
            AV16vENCType = cgiGet( edtavVenctype_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV16vENCType", AV16vENCType);
            A91BR_Encounter_AdmitDate = context.localUtil.CToD( cgiGet( edtBR_Encounter_AdmitDate_Internalname), 0);
            n91BR_Encounter_AdmitDate = false;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A91BR_Encounter_AdmitDate", context.localUtil.Format(A91BR_Encounter_AdmitDate, "9999/99/99"));
            A92BR_Encounter_AdmitSource = cgiGet( edtBR_Encounter_AdmitSource_Internalname);
            n92BR_Encounter_AdmitSource = false;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A92BR_Encounter_AdmitSource", A92BR_Encounter_AdmitSource);
            AV17vReason = cgiGet( edtavVreason_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV17vReason", AV17vReason);
            A93BR_Encounter_DischargeDate = context.localUtil.CToD( cgiGet( edtBR_Encounter_DischargeDate_Internalname), 0);
            n93BR_Encounter_DischargeDate = false;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A93BR_Encounter_DischargeDate", context.localUtil.Format(A93BR_Encounter_DischargeDate, "9999/99/99"));
            A94BR_Encounter_DischargeStatus = cgiGet( edtBR_Encounter_DischargeStatus_Internalname);
            n94BR_Encounter_DischargeStatus = false;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A94BR_Encounter_DischargeStatus", A94BR_Encounter_DischargeStatus);
            A35BR_Encounter_EncID = (long)(context.localUtil.CToN( cgiGet( edtBR_Encounter_EncID_Internalname), ".", ","));
            n35BR_Encounter_EncID = false;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A35BR_Encounter_EncID", StringUtil.LTrim( StringUtil.Str( (decimal)(A35BR_Encounter_EncID), 10, 0)));
            cmbBR_Encounter_Status.CurrentValue = cgiGet( cmbBR_Encounter_Status_Internalname);
            A172BR_Encounter_Status = (short)(NumberUtil.Val( cgiGet( cmbBR_Encounter_Status_Internalname), "."));
            n172BR_Encounter_Status = false;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A172BR_Encounter_Status", StringUtil.LTrim( StringUtil.Str( (decimal)(A172BR_Encounter_Status), 4, 0)));
            A182BR_Encounter_CrtDate = context.localUtil.CToT( cgiGet( edtBR_Encounter_CrtDate_Internalname));
            n182BR_Encounter_CrtDate = false;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A182BR_Encounter_CrtDate", context.localUtil.TToC( A182BR_Encounter_CrtDate, 10, 8, 0, 0, "/", ":", " "));
            A187BR_Encounter_UpdDate = context.localUtil.CToT( cgiGet( edtBR_Encounter_UpdDate_Internalname));
            n187BR_Encounter_UpdDate = false;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A187BR_Encounter_UpdDate", context.localUtil.TToC( A187BR_Encounter_UpdDate, 10, 8, 0, 0, "/", ":", " "));
            A183BR_Encounter_CrtUser = cgiGet( edtBR_Encounter_CrtUser_Internalname);
            n183BR_Encounter_CrtUser = false;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A183BR_Encounter_CrtUser", A183BR_Encounter_CrtUser);
            A186BR_Encounter_UpdUser = cgiGet( edtBR_Encounter_UpdUser_Internalname);
            n186BR_Encounter_UpdUser = false;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A186BR_Encounter_UpdUser", A186BR_Encounter_UpdUser);
            /* Read saved values. */
            wcpOA19BR_EncounterID = (long)(context.localUtil.CToN( cgiGet( sPrefix+"wcpOA19BR_EncounterID"), ".", ","));
            /* Read subfile selected row values. */
            /* Read hidden variables. */
            GXKey = Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
            forbiddenHiddens = sPrefix + "hsh" + "BR_EncounterGeneral";
            A85BR_Information_ID = (long)(context.localUtil.CToN( cgiGet( edtBR_Information_ID_Internalname), ".", ","));
            n85BR_Information_ID = false;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A85BR_Information_ID", StringUtil.LTrim( StringUtil.Str( (decimal)(A85BR_Information_ID), 18, 0)));
            forbiddenHiddens = forbiddenHiddens + context.localUtil.Format( (decimal)(A85BR_Information_ID), "ZZZZZZZZZZZZZZZZZZ");
            A84BR_Encounter_Department = cgiGet( edtBR_Encounter_Department_Internalname);
            n84BR_Encounter_Department = false;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A84BR_Encounter_Department", A84BR_Encounter_Department);
            forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( A84BR_Encounter_Department, ""));
            A90BR_Encounter_ENCType = cgiGet( edtBR_Encounter_ENCType_Internalname);
            n90BR_Encounter_ENCType = false;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A90BR_Encounter_ENCType", A90BR_Encounter_ENCType);
            forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( A90BR_Encounter_ENCType, ""));
            A92BR_Encounter_AdmitSource = cgiGet( edtBR_Encounter_AdmitSource_Internalname);
            n92BR_Encounter_AdmitSource = false;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A92BR_Encounter_AdmitSource", A92BR_Encounter_AdmitSource);
            forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( A92BR_Encounter_AdmitSource, ""));
            hsh = cgiGet( sPrefix+"hsh");
            if ( ! GXUtil.CheckEncryptedHash( forbiddenHiddens, hsh, GXKey) )
            {
               GXUtil.WriteLog("br_encountergeneral:[SecurityCheckFailed value for]"+"BR_Information_ID:"+context.localUtil.Format( (decimal)(A85BR_Information_ID), "ZZZZZZZZZZZZZZZZZZ"));
               GXUtil.WriteLog("br_encountergeneral:[SecurityCheckFailed value for]"+"BR_Encounter_Department:"+StringUtil.RTrim( context.localUtil.Format( A84BR_Encounter_Department, "")));
               GXUtil.WriteLog("br_encountergeneral:[SecurityCheckFailed value for]"+"BR_Encounter_ENCType:"+StringUtil.RTrim( context.localUtil.Format( A90BR_Encounter_ENCType, "")));
               GXUtil.WriteLog("br_encountergeneral:[SecurityCheckFailed value for]"+"BR_Encounter_AdmitSource:"+StringUtil.RTrim( context.localUtil.Format( A92BR_Encounter_AdmitSource, "")));
               GxWebError = 1;
               context.HttpContext.Response.StatusDescription = 403.ToString();
               context.HttpContext.Response.StatusCode = 403;
               context.WriteHtmlText( "<title>403 Forbidden</title>") ;
               context.WriteHtmlText( "<h1>403 Forbidden</h1>") ;
               context.WriteHtmlText( "<p /><hr />") ;
               GXUtil.WriteLog("send_http_error_code " + 403.ToString());
               return  ;
            }
         }
         else
         {
            dynload_actions( ) ;
         }
      }

      protected void GXStart( )
      {
         /* Execute user event: Start */
         E13162 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E13162( )
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

      protected void E14162( )
      {
         /* Load Routine */
         GXt_boolean1 = AV13TempBoolean;
         new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "Check_Information", out  GXt_boolean1) ;
         AV13TempBoolean = GXt_boolean1;
         if ( AV13TempBoolean )
         {
            edtBR_Information_PatientNo_Link = formatLink("br_informationview.aspx") + "?" + UrlEncode("" +A85BR_Information_ID) + "," + UrlEncode(StringUtil.RTrim(""));
            context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtBR_Information_PatientNo_Internalname, "Link", edtBR_Information_PatientNo_Link, true);
         }
         edtBR_EncounterID_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtBR_EncounterID_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBR_EncounterID_Visible), 5, 0)), true);
         edtBR_Encounter_EncID_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtBR_Encounter_EncID_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBR_Encounter_EncID_Visible), 5, 0)), true);
         cmbBR_Encounter_Status.Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, cmbBR_Encounter_Status_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(cmbBR_Encounter_Status.Visible), 5, 0)), true);
         edtBR_Encounter_CrtDate_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtBR_Encounter_CrtDate_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBR_Encounter_CrtDate_Visible), 5, 0)), true);
         edtBR_Encounter_UpdDate_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtBR_Encounter_UpdDate_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBR_Encounter_UpdDate_Visible), 5, 0)), true);
         edtBR_Encounter_CrtUser_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtBR_Encounter_CrtUser_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBR_Encounter_CrtUser_Visible), 5, 0)), true);
         edtBR_Encounter_UpdUser_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtBR_Encounter_UpdUser_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBR_Encounter_UpdUser_Visible), 5, 0)), true);
         if ( ! ( ( StringUtil.StrCmp(A84BR_Encounter_Department, "其它") == 0 ) ) )
         {
            edtavVdepartment_Visible = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavVdepartment_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavVdepartment_Visible), 5, 0)), true);
            cellVdepartment_cell_Class = "Invisible";
            context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, cellVdepartment_cell_Internalname, "Class", cellVdepartment_cell_Class, true);
         }
         else
         {
            edtavVdepartment_Visible = 1;
            context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavVdepartment_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavVdepartment_Visible), 5, 0)), true);
            cellVdepartment_cell_Class = "DataContentCell";
            context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, cellVdepartment_cell_Internalname, "Class", cellVdepartment_cell_Class, true);
         }
         if ( ! ( ( StringUtil.StrCmp(A90BR_Encounter_ENCType, "其它") == 0 ) ) )
         {
            edtavVenctype_Visible = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavVenctype_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavVenctype_Visible), 5, 0)), true);
            cellVenctype_cell_Class = "Invisible";
            context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, cellVenctype_cell_Internalname, "Class", cellVenctype_cell_Class, true);
         }
         else
         {
            edtavVenctype_Visible = 1;
            context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavVenctype_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavVenctype_Visible), 5, 0)), true);
            cellVenctype_cell_Class = "DataContentCell";
            context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, cellVenctype_cell_Internalname, "Class", cellVenctype_cell_Class, true);
         }
         if ( ! ( ( StringUtil.StrCmp(A92BR_Encounter_AdmitSource, "其它") == 0 ) ) )
         {
            edtavVreason_Visible = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavVreason_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavVreason_Visible), 5, 0)), true);
            cellVreason_cell_Class = "Invisible";
            context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, cellVreason_cell_Internalname, "Class", cellVreason_cell_Class, true);
         }
         else
         {
            edtavVreason_Visible = 1;
            context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavVreason_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavVreason_Visible), 5, 0)), true);
            cellVreason_cell_Class = "DataContentCell";
            context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, cellVreason_cell_Internalname, "Class", cellVreason_cell_Class, true);
         }
      }

      protected void S112( )
      {
         /* 'PREPARETRANSACTION' Routine */
         AV9TrnContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext(context);
         AV9TrnContext.gxTpr_Callerobject = AV20Pgmname;
         AV9TrnContext.gxTpr_Callerondelete = false;
         AV9TrnContext.gxTpr_Callerurl = AV12HTTPRequest.ScriptName+"?"+AV12HTTPRequest.QueryString;
         AV9TrnContext.gxTpr_Transactionname = "BR_Encounter";
         AV10TrnContextAtt = new GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext_Attribute(context);
         AV10TrnContextAtt.gxTpr_Attributename = "BR_EncounterID";
         AV10TrnContextAtt.gxTpr_Attributevalue = StringUtil.Str( (decimal)(AV8BR_EncounterID), 18, 0);
         AV9TrnContext.gxTpr_Attributes.Add(AV10TrnContextAtt, 0);
         AV11Session.Set("TrnContext", AV9TrnContext.ToXml(false, true, "WWPTransactionContext", "DataAnalysisPlatform"));
      }

      protected void wb_table3_59_162( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "";
            GxWebStd.gx_table_start( context, tblTablemergedbr_encounter_admitsource_Internalname, tblTablemergedbr_encounter_admitsource_Internalname, "", "TableMerged", 0, "", "", 0, 0, sStyleString, "", "", 0);
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td class='MergeDataCell'>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtBR_Encounter_AdmitSource_Internalname, "入院原因", "col-sm-3 ReadonlyAttributeLabel", 0, true);
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtBR_Encounter_AdmitSource_Internalname, A92BR_Encounter_AdmitSource, StringUtil.RTrim( context.localUtil.Format( A92BR_Encounter_AdmitSource, "")), "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBR_Encounter_AdmitSource_Jsonclick, 0, "ReadonlyAttribute", "", "", "", "", 1, edtBR_Encounter_AdmitSource_Enabled, 0, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_BR_EncounterGeneral.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td id=\""+cellVreason_cell_Internalname+"\"  class='"+cellVreason_cell_Class+"'>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavVreason_Internalname, "v Reason", "col-sm-3 ReadonlyAttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 66,'" + sPrefix + "',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavVreason_Internalname, AV17vReason, StringUtil.RTrim( context.localUtil.Format( AV17vReason, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,66);\"", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "请填写其他入院原因", edtavVreason_Jsonclick, 0, "ReadonlyAttribute", "", "", "", "", edtavVreason_Visible, edtavVreason_Enabled, 0, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_BR_EncounterGeneral.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table3_59_162e( true) ;
         }
         else
         {
            wb_table3_59_162e( false) ;
         }
      }

      protected void wb_table2_40_162( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "";
            GxWebStd.gx_table_start( context, tblTablemergedbr_encounter_enctype_Internalname, tblTablemergedbr_encounter_enctype_Internalname, "", "TableMerged", 0, "", "", 0, 0, sStyleString, "", "", 0);
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td class='MergeDataCell'>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtBR_Encounter_ENCType_Internalname, "就诊方式", "col-sm-3 ReadonlyAttributeLabel", 0, true);
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtBR_Encounter_ENCType_Internalname, A90BR_Encounter_ENCType, StringUtil.RTrim( context.localUtil.Format( A90BR_Encounter_ENCType, "")), "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBR_Encounter_ENCType_Jsonclick, 0, "ReadonlyAttribute", "", "", "", "", 1, edtBR_Encounter_ENCType_Enabled, 0, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_BR_EncounterGeneral.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td id=\""+cellVenctype_cell_Internalname+"\"  class='"+cellVenctype_cell_Class+"'>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavVenctype_Internalname, "v ENCType", "col-sm-3 ReadonlyAttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 47,'" + sPrefix + "',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavVenctype_Internalname, AV16vENCType, StringUtil.RTrim( context.localUtil.Format( AV16vENCType, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,47);\"", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "请填写其它就诊方式", edtavVenctype_Jsonclick, 0, "ReadonlyAttribute", "", "", "", "", edtavVenctype_Visible, edtavVenctype_Enabled, 0, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_BR_EncounterGeneral.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table2_40_162e( true) ;
         }
         else
         {
            wb_table2_40_162e( false) ;
         }
      }

      protected void wb_table1_26_162( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "";
            GxWebStd.gx_table_start( context, tblTablemergedbr_encounter_department_Internalname, tblTablemergedbr_encounter_department_Internalname, "", "TableMerged", 0, "", "", 0, 0, sStyleString, "", "", 0);
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td class='MergeDataCell'>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtBR_Encounter_Department_Internalname, "就诊科室", "col-sm-3 ReadonlyAttributeLabel", 0, true);
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtBR_Encounter_Department_Internalname, A84BR_Encounter_Department, StringUtil.RTrim( context.localUtil.Format( A84BR_Encounter_Department, "")), "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBR_Encounter_Department_Jsonclick, 0, "ReadonlyAttribute", "", "", "", "", 1, edtBR_Encounter_Department_Enabled, 0, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_BR_EncounterGeneral.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td id=\""+cellVdepartment_cell_Internalname+"\"  class='"+cellVdepartment_cell_Class+"'>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavVdepartment_Internalname, "v Department", "col-sm-3 ReadonlyAttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 33,'" + sPrefix + "',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavVdepartment_Internalname, AV14vDepartment, StringUtil.RTrim( context.localUtil.Format( AV14vDepartment, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,33);\"", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "请填写其他就诊科室", edtavVdepartment_Jsonclick, 0, "ReadonlyAttribute", "", "", "", "", edtavVdepartment_Visible, edtavVdepartment_Enabled, 0, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_BR_EncounterGeneral.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table1_26_162e( true) ;
         }
         else
         {
            wb_table1_26_162e( false) ;
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
         PA162( ) ;
         WS162( ) ;
         WE162( ) ;
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
         PA162( ) ;
         WCParametersGet( ) ;
      }

      public override void componentprepare( Object[] obj )
      {
         wbLoad = false;
         sCompPrefix = (String)getParm(obj,0);
         sSFPrefix = (String)getParm(obj,1);
         sPrefix = sCompPrefix + sSFPrefix;
         AddComponentObject(sPrefix, "br_encountergeneral", GetJustCreated( ));
         if ( ( nDoneStart == 0 ) && ( nDynComponent == 0 ) )
         {
            INITWEB( ) ;
         }
         else
         {
            init_default_properties( ) ;
            init_web_controls( ) ;
         }
         PA162( ) ;
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
         PA162( ) ;
         sEvt = sCompEvt;
         WCParametersGet( ) ;
         WS162( ) ;
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
         WS162( ) ;
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
         WE162( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?20202279362328", true);
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
         context.AddJavascriptSource("br_encountergeneral.js", "?20202279362328", false);
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
         edtBR_Information_ID_Internalname = sPrefix+"BR_INFORMATION_ID";
         edtBR_Information_PatientNo_Internalname = sPrefix+"BR_INFORMATION_PATIENTNO";
         lblTextblockbr_encounter_department_Internalname = sPrefix+"TEXTBLOCKBR_ENCOUNTER_DEPARTMENT";
         edtBR_Encounter_Department_Internalname = sPrefix+"BR_ENCOUNTER_DEPARTMENT";
         edtavVdepartment_Internalname = sPrefix+"vVDEPARTMENT";
         cellVdepartment_cell_Internalname = sPrefix+"VDEPARTMENT_CELL";
         tblTablemergedbr_encounter_department_Internalname = sPrefix+"TABLEMERGEDBR_ENCOUNTER_DEPARTMENT";
         divTablesplittedbr_encounter_department_Internalname = sPrefix+"TABLESPLITTEDBR_ENCOUNTER_DEPARTMENT";
         lblTextblockbr_encounter_enctype_Internalname = sPrefix+"TEXTBLOCKBR_ENCOUNTER_ENCTYPE";
         edtBR_Encounter_ENCType_Internalname = sPrefix+"BR_ENCOUNTER_ENCTYPE";
         edtavVenctype_Internalname = sPrefix+"vVENCTYPE";
         cellVenctype_cell_Internalname = sPrefix+"VENCTYPE_CELL";
         tblTablemergedbr_encounter_enctype_Internalname = sPrefix+"TABLEMERGEDBR_ENCOUNTER_ENCTYPE";
         divTablesplittedbr_encounter_enctype_Internalname = sPrefix+"TABLESPLITTEDBR_ENCOUNTER_ENCTYPE";
         edtBR_Encounter_AdmitDate_Internalname = sPrefix+"BR_ENCOUNTER_ADMITDATE";
         lblTextblockbr_encounter_admitsource_Internalname = sPrefix+"TEXTBLOCKBR_ENCOUNTER_ADMITSOURCE";
         edtBR_Encounter_AdmitSource_Internalname = sPrefix+"BR_ENCOUNTER_ADMITSOURCE";
         edtavVreason_Internalname = sPrefix+"vVREASON";
         cellVreason_cell_Internalname = sPrefix+"VREASON_CELL";
         tblTablemergedbr_encounter_admitsource_Internalname = sPrefix+"TABLEMERGEDBR_ENCOUNTER_ADMITSOURCE";
         divTablesplittedbr_encounter_admitsource_Internalname = sPrefix+"TABLESPLITTEDBR_ENCOUNTER_ADMITSOURCE";
         edtBR_Encounter_DischargeDate_Internalname = sPrefix+"BR_ENCOUNTER_DISCHARGEDATE";
         edtBR_Encounter_DischargeStatus_Internalname = sPrefix+"BR_ENCOUNTER_DISCHARGESTATUS";
         divTransactiondetail_tableattributes_Internalname = sPrefix+"TRANSACTIONDETAIL_TABLEATTRIBUTES";
         bttBtnupdate_Internalname = sPrefix+"BTNUPDATE";
         bttBtndelete_Internalname = sPrefix+"BTNDELETE";
         divTable_Internalname = sPrefix+"TABLE";
         edtBR_EncounterID_Internalname = sPrefix+"BR_ENCOUNTERID";
         edtBR_Encounter_EncID_Internalname = sPrefix+"BR_ENCOUNTER_ENCID";
         cmbBR_Encounter_Status_Internalname = sPrefix+"BR_ENCOUNTER_STATUS";
         edtBR_Encounter_CrtDate_Internalname = sPrefix+"BR_ENCOUNTER_CRTDATE";
         edtBR_Encounter_UpdDate_Internalname = sPrefix+"BR_ENCOUNTER_UPDDATE";
         edtBR_Encounter_CrtUser_Internalname = sPrefix+"BR_ENCOUNTER_CRTUSER";
         edtBR_Encounter_UpdUser_Internalname = sPrefix+"BR_ENCOUNTER_UPDUSER";
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
         edtavVdepartment_Jsonclick = "";
         edtavVdepartment_Enabled = 1;
         cellVdepartment_cell_Class = "";
         edtBR_Encounter_Department_Jsonclick = "";
         edtBR_Encounter_Department_Enabled = 0;
         edtavVenctype_Jsonclick = "";
         edtavVenctype_Enabled = 1;
         cellVenctype_cell_Class = "";
         edtBR_Encounter_ENCType_Jsonclick = "";
         edtBR_Encounter_ENCType_Enabled = 0;
         edtavVreason_Jsonclick = "";
         edtavVreason_Enabled = 1;
         cellVreason_cell_Class = "";
         edtBR_Encounter_AdmitSource_Jsonclick = "";
         edtBR_Encounter_AdmitSource_Enabled = 0;
         edtavVreason_Visible = 1;
         edtavVenctype_Visible = 1;
         edtavVdepartment_Visible = 1;
         edtBR_Encounter_UpdUser_Jsonclick = "";
         edtBR_Encounter_UpdUser_Visible = 1;
         edtBR_Encounter_CrtUser_Jsonclick = "";
         edtBR_Encounter_CrtUser_Visible = 1;
         edtBR_Encounter_UpdDate_Jsonclick = "";
         edtBR_Encounter_UpdDate_Visible = 1;
         edtBR_Encounter_CrtDate_Jsonclick = "";
         edtBR_Encounter_CrtDate_Visible = 1;
         cmbBR_Encounter_Status_Jsonclick = "";
         cmbBR_Encounter_Status.Visible = 1;
         edtBR_Encounter_EncID_Jsonclick = "";
         edtBR_Encounter_EncID_Visible = 1;
         edtBR_EncounterID_Jsonclick = "";
         edtBR_EncounterID_Visible = 1;
         edtBR_Encounter_DischargeStatus_Jsonclick = "";
         edtBR_Encounter_DischargeStatus_Enabled = 0;
         edtBR_Encounter_DischargeDate_Jsonclick = "";
         edtBR_Encounter_DischargeDate_Enabled = 0;
         edtBR_Encounter_AdmitDate_Jsonclick = "";
         edtBR_Encounter_AdmitDate_Enabled = 0;
         edtBR_Information_PatientNo_Jsonclick = "";
         edtBR_Information_PatientNo_Link = "";
         edtBR_Information_PatientNo_Enabled = 0;
         edtBR_Information_ID_Jsonclick = "";
         edtBR_Information_ID_Enabled = 0;
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
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[{av:'A85BR_Information_ID',fld:'BR_INFORMATION_ID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'A84BR_Encounter_Department',fld:'BR_ENCOUNTER_DEPARTMENT',pic:''},{av:'A90BR_Encounter_ENCType',fld:'BR_ENCOUNTER_ENCTYPE',pic:''},{av:'A92BR_Encounter_AdmitSource',fld:'BR_ENCOUNTER_ADMITSOURCE',pic:''}]");
         setEventMetadata("REFRESH",",oparms:[]}");
         setEventMetadata("'DOUPDATE'","{handler:'E11161',iparms:[{av:'A19BR_EncounterID',fld:'BR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ'}]");
         setEventMetadata("'DOUPDATE'",",oparms:[]}");
         setEventMetadata("'DODELETE'","{handler:'E12161',iparms:[{av:'A19BR_EncounterID',fld:'BR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ'}]");
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
         AV20Pgmname = "";
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         GXKey = "";
         forbiddenHiddens = "";
         A84BR_Encounter_Department = "";
         A90BR_Encounter_ENCType = "";
         A92BR_Encounter_AdmitSource = "";
         GX_FocusControl = "";
         A36BR_Information_PatientNo = "";
         lblTextblockbr_encounter_department_Jsonclick = "";
         lblTextblockbr_encounter_enctype_Jsonclick = "";
         A91BR_Encounter_AdmitDate = DateTime.MinValue;
         lblTextblockbr_encounter_admitsource_Jsonclick = "";
         A93BR_Encounter_DischargeDate = DateTime.MinValue;
         A94BR_Encounter_DischargeStatus = "";
         TempTags = "";
         ClassString = "";
         StyleString = "";
         bttBtnupdate_Jsonclick = "";
         bttBtndelete_Jsonclick = "";
         A182BR_Encounter_CrtDate = (DateTime)(DateTime.MinValue);
         A187BR_Encounter_UpdDate = (DateTime)(DateTime.MinValue);
         A183BR_Encounter_CrtUser = "";
         A186BR_Encounter_UpdUser = "";
         Form = new GXWebForm();
         sXEvt = "";
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         scmdbuf = "";
         H00162_A19BR_EncounterID = new long[1] ;
         H00162_A186BR_Encounter_UpdUser = new String[] {""} ;
         H00162_n186BR_Encounter_UpdUser = new bool[] {false} ;
         H00162_A183BR_Encounter_CrtUser = new String[] {""} ;
         H00162_n183BR_Encounter_CrtUser = new bool[] {false} ;
         H00162_A187BR_Encounter_UpdDate = new DateTime[] {DateTime.MinValue} ;
         H00162_n187BR_Encounter_UpdDate = new bool[] {false} ;
         H00162_A182BR_Encounter_CrtDate = new DateTime[] {DateTime.MinValue} ;
         H00162_n182BR_Encounter_CrtDate = new bool[] {false} ;
         H00162_A172BR_Encounter_Status = new short[1] ;
         H00162_n172BR_Encounter_Status = new bool[] {false} ;
         H00162_A35BR_Encounter_EncID = new long[1] ;
         H00162_n35BR_Encounter_EncID = new bool[] {false} ;
         H00162_A94BR_Encounter_DischargeStatus = new String[] {""} ;
         H00162_n94BR_Encounter_DischargeStatus = new bool[] {false} ;
         H00162_A93BR_Encounter_DischargeDate = new DateTime[] {DateTime.MinValue} ;
         H00162_n93BR_Encounter_DischargeDate = new bool[] {false} ;
         H00162_A92BR_Encounter_AdmitSource = new String[] {""} ;
         H00162_n92BR_Encounter_AdmitSource = new bool[] {false} ;
         H00162_A91BR_Encounter_AdmitDate = new DateTime[] {DateTime.MinValue} ;
         H00162_n91BR_Encounter_AdmitDate = new bool[] {false} ;
         H00162_A90BR_Encounter_ENCType = new String[] {""} ;
         H00162_n90BR_Encounter_ENCType = new bool[] {false} ;
         H00162_A84BR_Encounter_Department = new String[] {""} ;
         H00162_n84BR_Encounter_Department = new bool[] {false} ;
         H00162_A36BR_Information_PatientNo = new String[] {""} ;
         H00162_n36BR_Information_PatientNo = new bool[] {false} ;
         H00162_A85BR_Information_ID = new long[1] ;
         H00162_n85BR_Information_ID = new bool[] {false} ;
         AV14vDepartment = "";
         AV16vENCType = "";
         AV17vReason = "";
         hsh = "";
         AV6WWPContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPContext(context);
         AV9TrnContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext(context);
         AV12HTTPRequest = new GxHttpRequest( context);
         AV10TrnContextAtt = new GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext_Attribute(context);
         AV11Session = context.GetSession();
         sStyleString = "";
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         sCtrlA19BR_EncounterID = "";
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.br_encountergeneral__default(),
            new Object[][] {
                new Object[] {
               H00162_A19BR_EncounterID, H00162_A186BR_Encounter_UpdUser, H00162_n186BR_Encounter_UpdUser, H00162_A183BR_Encounter_CrtUser, H00162_n183BR_Encounter_CrtUser, H00162_A187BR_Encounter_UpdDate, H00162_n187BR_Encounter_UpdDate, H00162_A182BR_Encounter_CrtDate, H00162_n182BR_Encounter_CrtDate, H00162_A172BR_Encounter_Status,
               H00162_n172BR_Encounter_Status, H00162_A35BR_Encounter_EncID, H00162_n35BR_Encounter_EncID, H00162_A94BR_Encounter_DischargeStatus, H00162_n94BR_Encounter_DischargeStatus, H00162_A93BR_Encounter_DischargeDate, H00162_n93BR_Encounter_DischargeDate, H00162_A92BR_Encounter_AdmitSource, H00162_n92BR_Encounter_AdmitSource, H00162_A91BR_Encounter_AdmitDate,
               H00162_n91BR_Encounter_AdmitDate, H00162_A90BR_Encounter_ENCType, H00162_n90BR_Encounter_ENCType, H00162_A84BR_Encounter_Department, H00162_n84BR_Encounter_Department, H00162_A36BR_Information_PatientNo, H00162_n36BR_Information_PatientNo, H00162_A85BR_Information_ID, H00162_n85BR_Information_ID
               }
            }
         );
         AV20Pgmname = "BR_EncounterGeneral";
         /* GeneXus formulas. */
         AV20Pgmname = "BR_EncounterGeneral";
         context.Gx_err = 0;
         edtavVdepartment_Enabled = 0;
         edtavVenctype_Enabled = 0;
         edtavVreason_Enabled = 0;
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
      private int edtavVdepartment_Enabled ;
      private int edtavVenctype_Enabled ;
      private int edtavVreason_Enabled ;
      private int edtBR_Information_ID_Enabled ;
      private int edtBR_Information_PatientNo_Enabled ;
      private int edtBR_Encounter_AdmitDate_Enabled ;
      private int edtBR_Encounter_DischargeDate_Enabled ;
      private int edtBR_Encounter_DischargeStatus_Enabled ;
      private int edtBR_EncounterID_Visible ;
      private int edtBR_Encounter_EncID_Visible ;
      private int edtBR_Encounter_CrtDate_Visible ;
      private int edtBR_Encounter_UpdDate_Visible ;
      private int edtBR_Encounter_CrtUser_Visible ;
      private int edtBR_Encounter_UpdUser_Visible ;
      private int edtavVdepartment_Visible ;
      private int edtavVenctype_Visible ;
      private int edtavVreason_Visible ;
      private int edtBR_Encounter_AdmitSource_Enabled ;
      private int edtBR_Encounter_ENCType_Enabled ;
      private int edtBR_Encounter_Department_Enabled ;
      private int idxLst ;
      private long A19BR_EncounterID ;
      private long wcpOA19BR_EncounterID ;
      private long A85BR_Information_ID ;
      private long A35BR_Encounter_EncID ;
      private long AV8BR_EncounterID ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String sPrefix ;
      private String sCompPrefix ;
      private String sSFPrefix ;
      private String AV20Pgmname ;
      private String edtavVdepartment_Internalname ;
      private String edtavVenctype_Internalname ;
      private String edtavVreason_Internalname ;
      private String sDynURL ;
      private String FormProcess ;
      private String bodyStyle ;
      private String GXKey ;
      private String forbiddenHiddens ;
      private String GX_FocusControl ;
      private String divLayoutmaintable_Internalname ;
      private String divTable_Internalname ;
      private String divTransactiondetail_tableattributes_Internalname ;
      private String edtBR_Information_ID_Internalname ;
      private String edtBR_Information_ID_Jsonclick ;
      private String edtBR_Information_PatientNo_Internalname ;
      private String edtBR_Information_PatientNo_Link ;
      private String edtBR_Information_PatientNo_Jsonclick ;
      private String divTablesplittedbr_encounter_department_Internalname ;
      private String lblTextblockbr_encounter_department_Internalname ;
      private String lblTextblockbr_encounter_department_Jsonclick ;
      private String divTablesplittedbr_encounter_enctype_Internalname ;
      private String lblTextblockbr_encounter_enctype_Internalname ;
      private String lblTextblockbr_encounter_enctype_Jsonclick ;
      private String edtBR_Encounter_AdmitDate_Internalname ;
      private String edtBR_Encounter_AdmitDate_Jsonclick ;
      private String divTablesplittedbr_encounter_admitsource_Internalname ;
      private String lblTextblockbr_encounter_admitsource_Internalname ;
      private String lblTextblockbr_encounter_admitsource_Jsonclick ;
      private String edtBR_Encounter_DischargeDate_Internalname ;
      private String edtBR_Encounter_DischargeDate_Jsonclick ;
      private String edtBR_Encounter_DischargeStatus_Internalname ;
      private String edtBR_Encounter_DischargeStatus_Jsonclick ;
      private String TempTags ;
      private String ClassString ;
      private String StyleString ;
      private String bttBtnupdate_Internalname ;
      private String bttBtnupdate_Jsonclick ;
      private String bttBtndelete_Internalname ;
      private String bttBtndelete_Jsonclick ;
      private String divHtml_bottomauxiliarcontrols_Internalname ;
      private String edtBR_EncounterID_Internalname ;
      private String edtBR_EncounterID_Jsonclick ;
      private String edtBR_Encounter_EncID_Internalname ;
      private String edtBR_Encounter_EncID_Jsonclick ;
      private String cmbBR_Encounter_Status_Internalname ;
      private String cmbBR_Encounter_Status_Jsonclick ;
      private String edtBR_Encounter_CrtDate_Internalname ;
      private String edtBR_Encounter_CrtDate_Jsonclick ;
      private String edtBR_Encounter_UpdDate_Internalname ;
      private String edtBR_Encounter_UpdDate_Jsonclick ;
      private String edtBR_Encounter_CrtUser_Internalname ;
      private String edtBR_Encounter_CrtUser_Jsonclick ;
      private String edtBR_Encounter_UpdUser_Internalname ;
      private String edtBR_Encounter_UpdUser_Jsonclick ;
      private String sXEvt ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String scmdbuf ;
      private String edtBR_Encounter_Department_Internalname ;
      private String edtBR_Encounter_ENCType_Internalname ;
      private String edtBR_Encounter_AdmitSource_Internalname ;
      private String hsh ;
      private String cellVdepartment_cell_Class ;
      private String cellVdepartment_cell_Internalname ;
      private String cellVenctype_cell_Class ;
      private String cellVenctype_cell_Internalname ;
      private String cellVreason_cell_Class ;
      private String cellVreason_cell_Internalname ;
      private String sStyleString ;
      private String tblTablemergedbr_encounter_admitsource_Internalname ;
      private String edtBR_Encounter_AdmitSource_Jsonclick ;
      private String edtavVreason_Jsonclick ;
      private String tblTablemergedbr_encounter_enctype_Internalname ;
      private String edtBR_Encounter_ENCType_Jsonclick ;
      private String edtavVenctype_Jsonclick ;
      private String tblTablemergedbr_encounter_department_Internalname ;
      private String edtBR_Encounter_Department_Jsonclick ;
      private String edtavVdepartment_Jsonclick ;
      private String sCtrlA19BR_EncounterID ;
      private DateTime A182BR_Encounter_CrtDate ;
      private DateTime A187BR_Encounter_UpdDate ;
      private DateTime A91BR_Encounter_AdmitDate ;
      private DateTime A93BR_Encounter_DischargeDate ;
      private bool entryPointCalled ;
      private bool toggleJsOutput ;
      private bool wbLoad ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool n172BR_Encounter_Status ;
      private bool gxdyncontrolsrefreshing ;
      private bool n186BR_Encounter_UpdUser ;
      private bool n183BR_Encounter_CrtUser ;
      private bool n187BR_Encounter_UpdDate ;
      private bool n182BR_Encounter_CrtDate ;
      private bool n35BR_Encounter_EncID ;
      private bool n94BR_Encounter_DischargeStatus ;
      private bool n93BR_Encounter_DischargeDate ;
      private bool n92BR_Encounter_AdmitSource ;
      private bool n91BR_Encounter_AdmitDate ;
      private bool n90BR_Encounter_ENCType ;
      private bool n84BR_Encounter_Department ;
      private bool n36BR_Information_PatientNo ;
      private bool n85BR_Information_ID ;
      private bool returnInSub ;
      private bool AV13TempBoolean ;
      private bool GXt_boolean1 ;
      private String A84BR_Encounter_Department ;
      private String A90BR_Encounter_ENCType ;
      private String A92BR_Encounter_AdmitSource ;
      private String A36BR_Information_PatientNo ;
      private String A94BR_Encounter_DischargeStatus ;
      private String A183BR_Encounter_CrtUser ;
      private String A186BR_Encounter_UpdUser ;
      private String AV14vDepartment ;
      private String AV16vENCType ;
      private String AV17vReason ;
      private GXWebForm Form ;
      private IGxDataStore dsDataStore1 ;
      private IGxDataStore dsDefault ;
      private GXCombobox cmbBR_Encounter_Status ;
      private IDataStoreProvider pr_default ;
      private long[] H00162_A19BR_EncounterID ;
      private String[] H00162_A186BR_Encounter_UpdUser ;
      private bool[] H00162_n186BR_Encounter_UpdUser ;
      private String[] H00162_A183BR_Encounter_CrtUser ;
      private bool[] H00162_n183BR_Encounter_CrtUser ;
      private DateTime[] H00162_A187BR_Encounter_UpdDate ;
      private bool[] H00162_n187BR_Encounter_UpdDate ;
      private DateTime[] H00162_A182BR_Encounter_CrtDate ;
      private bool[] H00162_n182BR_Encounter_CrtDate ;
      private short[] H00162_A172BR_Encounter_Status ;
      private bool[] H00162_n172BR_Encounter_Status ;
      private long[] H00162_A35BR_Encounter_EncID ;
      private bool[] H00162_n35BR_Encounter_EncID ;
      private String[] H00162_A94BR_Encounter_DischargeStatus ;
      private bool[] H00162_n94BR_Encounter_DischargeStatus ;
      private DateTime[] H00162_A93BR_Encounter_DischargeDate ;
      private bool[] H00162_n93BR_Encounter_DischargeDate ;
      private String[] H00162_A92BR_Encounter_AdmitSource ;
      private bool[] H00162_n92BR_Encounter_AdmitSource ;
      private DateTime[] H00162_A91BR_Encounter_AdmitDate ;
      private bool[] H00162_n91BR_Encounter_AdmitDate ;
      private String[] H00162_A90BR_Encounter_ENCType ;
      private bool[] H00162_n90BR_Encounter_ENCType ;
      private String[] H00162_A84BR_Encounter_Department ;
      private bool[] H00162_n84BR_Encounter_Department ;
      private String[] H00162_A36BR_Information_PatientNo ;
      private bool[] H00162_n36BR_Information_PatientNo ;
      private long[] H00162_A85BR_Information_ID ;
      private bool[] H00162_n85BR_Information_ID ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private GxHttpRequest AV12HTTPRequest ;
      private IGxSession AV11Session ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPContext AV6WWPContext ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext AV9TrnContext ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext_Attribute AV10TrnContextAtt ;
   }

   public class br_encountergeneral__default : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmH00162 ;
          prmH00162 = new Object[] {
          new Object[] {"@BR_EncounterID",SqlDbType.Decimal,18,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("H00162", "SELECT T1.[BR_EncounterID], T1.[BR_Encounter_UpdUser], T1.[BR_Encounter_CrtUser], T1.[BR_Encounter_UpdDate], T1.[BR_Encounter_CrtDate], T1.[BR_Encounter_Status], T1.[BR_Encounter_EncID], T1.[BR_Encounter_DischargeStatus], T1.[BR_Encounter_DischargeDate], T1.[BR_Encounter_AdmitSource], T1.[BR_Encounter_AdmitDate], T1.[BR_Encounter_ENCType], T1.[BR_Encounter_Department], T2.[BR_Information_PatientNo], T1.[BR_Information_ID] FROM ([BR_Encounter] T1 WITH (NOLOCK) LEFT JOIN [BR_Information] T2 WITH (NOLOCK) ON T2.[BR_Information_ID] = T1.[BR_Information_ID]) WHERE T1.[BR_EncounterID] = @BR_EncounterID ORDER BY T1.[BR_EncounterID] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH00162,1,0,true,true )
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
                ((DateTime[]) buf[5])[0] = rslt.getGXDateTime(4) ;
                ((bool[]) buf[6])[0] = rslt.wasNull(4);
                ((DateTime[]) buf[7])[0] = rslt.getGXDateTime(5) ;
                ((bool[]) buf[8])[0] = rslt.wasNull(5);
                ((short[]) buf[9])[0] = rslt.getShort(6) ;
                ((bool[]) buf[10])[0] = rslt.wasNull(6);
                ((long[]) buf[11])[0] = rslt.getLong(7) ;
                ((bool[]) buf[12])[0] = rslt.wasNull(7);
                ((String[]) buf[13])[0] = rslt.getVarchar(8) ;
                ((bool[]) buf[14])[0] = rslt.wasNull(8);
                ((DateTime[]) buf[15])[0] = rslt.getGXDate(9) ;
                ((bool[]) buf[16])[0] = rslt.wasNull(9);
                ((String[]) buf[17])[0] = rslt.getVarchar(10) ;
                ((bool[]) buf[18])[0] = rslt.wasNull(10);
                ((DateTime[]) buf[19])[0] = rslt.getGXDate(11) ;
                ((bool[]) buf[20])[0] = rslt.wasNull(11);
                ((String[]) buf[21])[0] = rslt.getVarchar(12) ;
                ((bool[]) buf[22])[0] = rslt.wasNull(12);
                ((String[]) buf[23])[0] = rslt.getVarchar(13) ;
                ((bool[]) buf[24])[0] = rslt.wasNull(13);
                ((String[]) buf[25])[0] = rslt.getVarchar(14) ;
                ((bool[]) buf[26])[0] = rslt.wasNull(14);
                ((long[]) buf[27])[0] = rslt.getLong(15) ;
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
