/*
               File: BR_DemographicsGeneral
        Description: BR_Demographics General
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/28/2020 15:6:34.56
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
   public class br_demographicsgeneral : GXWebComponent, System.Web.SessionState.IRequiresSessionState
   {
      public br_demographicsgeneral( )
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

      public br_demographicsgeneral( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( long aP0_BR_Demographics_ID )
      {
         this.A61BR_Demographics_ID = aP0_BR_Demographics_ID;
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
                  A61BR_Demographics_ID = (long)(NumberUtil.Val( GetNextPar( ), "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A61BR_Demographics_ID", StringUtil.LTrim( StringUtil.Str( (decimal)(A61BR_Demographics_ID), 18, 0)));
                  setjustcreated();
                  componentprepare(new Object[] {(String)sCompPrefix,(String)sSFPrefix,(long)A61BR_Demographics_ID});
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
            PA2N2( ) ;
            if ( ( GxWebError == 0 ) && ! isAjaxCallMode( ) )
            {
               /* GeneXus formulas. */
               AV16Pgmname = "BR_DemographicsGeneral";
               context.Gx_err = 0;
               WS2N2( ) ;
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
            context.SendWebValue( "BR_Demographics General") ;
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
         context.AddJavascriptSource("gxcfg.js", "?20202281563461", false);
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
            context.WriteHtmlTextNl( "<form id=\"MAINFORM\" autocomplete=\"off\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("br_demographicsgeneral.aspx") + "?" + UrlEncode("" +A61BR_Demographics_ID)+"\">") ;
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
         GxWebStd.gx_hidden_field( context, sPrefix+"wcpOA61BR_Demographics_ID", StringUtil.LTrim( StringUtil.NToC( (decimal)(wcpOA61BR_Demographics_ID), 18, 0, ".", "")));
      }

      protected void RenderHtmlCloseForm2N2( )
      {
         SendCloseFormHiddens( ) ;
         if ( ( StringUtil.Len( sPrefix) != 0 ) && ( context.isAjaxRequest( ) || context.isSpaRequest( ) ) )
         {
            context.AddJavascriptSource("br_demographicsgeneral.js", "?20202281563464", false);
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
         return "BR_DemographicsGeneral" ;
      }

      public override String GetPgmdesc( )
      {
         return "BR_Demographics General" ;
      }

      protected void WB2N0( )
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
               GxWebStd.gx_hidden_field( context, sPrefix+"_CMPPGM", "br_demographicsgeneral.aspx");
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
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtBR_Demographics_ID_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtBR_Demographics_ID_Internalname, "人口信息学主键", "col-sm-3 ReadonlyAttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtBR_Demographics_ID_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A61BR_Demographics_ID), 18, 0, ".", "")), ((edtBR_Demographics_ID_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A61BR_Demographics_ID), "ZZZZZZZZZZZZZZZZZZ")) : context.localUtil.Format( (decimal)(A61BR_Demographics_ID), "ZZZZZZZZZZZZZZZZZZ")), "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBR_Demographics_ID_Jsonclick, 0, "ReadonlyAttribute", "", "", "", "", 1, edtBR_Demographics_ID_Enabled, 0, "number", "1", 18, "chr", 1, "row", 18, 0, 0, 0, 1, -1, 0, true, "ID", "right", false, "HLP_BR_DemographicsGeneral.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtBR_EncounterID_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtBR_EncounterID_Internalname, "就诊信息主键", "col-sm-3 ReadonlyAttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtBR_EncounterID_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A19BR_EncounterID), 18, 0, ".", "")), ((edtBR_EncounterID_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A19BR_EncounterID), "ZZZZZZZZZZZZZZZZZZ")) : context.localUtil.Format( (decimal)(A19BR_EncounterID), "ZZZZZZZZZZZZZZZZZZ")), "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBR_EncounterID_Jsonclick, 0, "ReadonlyAttribute", "", "", "", "", 1, edtBR_EncounterID_Enabled, 0, "number", "1", 18, "chr", 1, "row", 18, 0, 0, 0, 1, -1, 0, true, "ID", "right", false, "HLP_BR_DemographicsGeneral.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtBR_Information_PatientNo_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtBR_Information_PatientNo_Internalname, "患者编号", "col-sm-3 ReadonlyAttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtBR_Information_PatientNo_Internalname, A36BR_Information_PatientNo, StringUtil.RTrim( context.localUtil.Format( A36BR_Information_PatientNo, "")), "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", edtBR_Information_PatientNo_Link, "", "", "", edtBR_Information_PatientNo_Jsonclick, 0, "ReadonlyAttribute", "", "", "", "", 1, edtBR_Information_PatientNo_Enabled, 0, "text", "", 80, "chr", 1, "row", 2000, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_BR_DemographicsGeneral.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtBR_Demographics_BirthDate_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtBR_Demographics_BirthDate_Internalname, "出生日期", "col-sm-3 ReadonlyAttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            context.WriteHtmlText( "<div id=\""+edtBR_Demographics_BirthDate_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtBR_Demographics_BirthDate_Internalname, context.localUtil.Format(A53BR_Demographics_BirthDate, "9999/99/99"), context.localUtil.Format( A53BR_Demographics_BirthDate, "9999/99/99"), "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBR_Demographics_BirthDate_Jsonclick, 0, "ReadonlyAttribute", "", "", "", "", 1, edtBR_Demographics_BirthDate_Enabled, 0, "text", "", 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, 0, true, "DM_Date", "right", false, "HLP_BR_DemographicsGeneral.htm");
            GxWebStd.gx_bitmap( context, edtBR_Demographics_BirthDate_Internalname+"_dp_trigger", context.GetImagePath( "61b9b5d3-dff6-4d59-9b00-da61bc2cbe93", "", context.GetTheme( )), "", "", "", "", ((1==0)||(edtBR_Demographics_BirthDate_Enabled==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;", "", "", "", "", "", "", "", "", 1, false, false, "", "HLP_BR_DemographicsGeneral.htm");
            context.WriteHtmlTextNl( "</div>") ;
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtBR_Demographics_Sex_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtBR_Demographics_Sex_Internalname, "性别", "col-sm-3 ReadonlyAttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtBR_Demographics_Sex_Internalname, A54BR_Demographics_Sex, StringUtil.RTrim( context.localUtil.Format( A54BR_Demographics_Sex, "")), "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBR_Demographics_Sex_Jsonclick, 0, "ReadonlyAttribute", "", "", "", "", 1, edtBR_Demographics_Sex_Enabled, 0, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_BR_DemographicsGeneral.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtBR_Demographics_MarritalStatus_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtBR_Demographics_MarritalStatus_Internalname, "婚姻状态", "col-sm-3 ReadonlyAttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtBR_Demographics_MarritalStatus_Internalname, A63BR_Demographics_MarritalStatus, StringUtil.RTrim( context.localUtil.Format( A63BR_Demographics_MarritalStatus, "")), "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBR_Demographics_MarritalStatus_Jsonclick, 0, "ReadonlyAttribute", "", "", "", "", 1, edtBR_Demographics_MarritalStatus_Enabled, 0, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_BR_DemographicsGeneral.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtBR_Demographics_Ethnic_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtBR_Demographics_Ethnic_Internalname, "民族", "col-sm-3 ReadonlyAttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtBR_Demographics_Ethnic_Internalname, A55BR_Demographics_Ethnic, StringUtil.RTrim( context.localUtil.Format( A55BR_Demographics_Ethnic, "")), "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBR_Demographics_Ethnic_Jsonclick, 0, "ReadonlyAttribute", "", "", "", "", 1, edtBR_Demographics_Ethnic_Enabled, 0, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_BR_DemographicsGeneral.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtBR_Demographics_Education_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtBR_Demographics_Education_Internalname, "学历", "col-sm-3 ReadonlyAttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtBR_Demographics_Education_Internalname, A56BR_Demographics_Education, StringUtil.RTrim( context.localUtil.Format( A56BR_Demographics_Education, "")), "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBR_Demographics_Education_Jsonclick, 0, "ReadonlyAttribute", "", "", "", "", 1, edtBR_Demographics_Education_Enabled, 0, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_BR_DemographicsGeneral.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtBR_Demographics_Occupation_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtBR_Demographics_Occupation_Internalname, "职业", "col-sm-3 ReadonlyAttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtBR_Demographics_Occupation_Internalname, A57BR_Demographics_Occupation, StringUtil.RTrim( context.localUtil.Format( A57BR_Demographics_Occupation, "")), "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBR_Demographics_Occupation_Jsonclick, 0, "ReadonlyAttribute", "", "", "", "", 1, edtBR_Demographics_Occupation_Enabled, 0, "text", "", 40, "chr", 1, "row", 40, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_BR_DemographicsGeneral.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtBR_Demographics_Insurance_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtBR_Demographics_Insurance_Internalname, "保险类型", "col-sm-3 ReadonlyAttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtBR_Demographics_Insurance_Internalname, A58BR_Demographics_Insurance, StringUtil.RTrim( context.localUtil.Format( A58BR_Demographics_Insurance, "")), "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBR_Demographics_Insurance_Jsonclick, 0, "ReadonlyAttribute", "", "", "", "", 1, edtBR_Demographics_Insurance_Enabled, 0, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_BR_DemographicsGeneral.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtBR_Demographics_Province_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtBR_Demographics_Province_Internalname, "省", "col-sm-3 ReadonlyAttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtBR_Demographics_Province_Internalname, A59BR_Demographics_Province, StringUtil.RTrim( context.localUtil.Format( A59BR_Demographics_Province, "")), "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBR_Demographics_Province_Jsonclick, 0, "ReadonlyAttribute", "", "", "", "", 1, edtBR_Demographics_Province_Enabled, 0, "text", "", 40, "chr", 1, "row", 40, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_BR_DemographicsGeneral.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtBR_Demographics_City_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtBR_Demographics_City_Internalname, "市", "col-sm-3 ReadonlyAttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtBR_Demographics_City_Internalname, A60BR_Demographics_City, StringUtil.RTrim( context.localUtil.Format( A60BR_Demographics_City, "")), "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBR_Demographics_City_Jsonclick, 0, "ReadonlyAttribute", "", "", "", "", 1, edtBR_Demographics_City_Enabled, 0, "text", "", 40, "chr", 1, "row", 40, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_BR_DemographicsGeneral.htm");
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
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 68,'" + sPrefix + "',false,'',0)\"";
            ClassString = "ButtonMaterial";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtnupdate_Internalname, "", "修改", bttBtnupdate_Jsonclick, 7, "修改", "", StyleString, ClassString, bttBtnupdate_Visible, 1, "standard", "'"+sPrefix+"'"+",false,"+"'"+"e112n1_client"+"'", TempTags, "", 2, "HLP_BR_DemographicsGeneral.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 70,'" + sPrefix + "',false,'',0)\"";
            ClassString = "ButtonMaterialDefault";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtndelete_Internalname, "", "删除", bttBtndelete_Jsonclick, 7, "删除", "", StyleString, ClassString, bttBtndelete_Visible, 1, "standard", "'"+sPrefix+"'"+",false,"+"'"+"e122n1_client"+"'", TempTags, "", 2, "HLP_BR_DemographicsGeneral.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
         }
         wbLoad = true;
      }

      protected void START2N2( )
      {
         wbLoad = false;
         wbEnd = 0;
         wbStart = 0;
         if ( StringUtil.Len( sPrefix) == 0 )
         {
            if ( ! context.isSpaRequest( ) )
            {
               Form.Meta.addItem("generator", "GeneXus C# 16_0_0-127771", 0) ;
               Form.Meta.addItem("description", "BR_Demographics General", 0) ;
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
               STRUP2N0( ) ;
            }
         }
      }

      protected void WS2N2( )
      {
         START2N2( ) ;
         EVT2N2( ) ;
      }

      protected void EVT2N2( )
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
                                 STRUP2N0( ) ;
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
                                 STRUP2N0( ) ;
                              }
                              if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
                              {
                                 context.wbHandled = 1;
                                 if ( ! wbErr )
                                 {
                                    dynload_actions( ) ;
                                    /* Execute user event: Start */
                                    E132N2 ();
                                 }
                              }
                           }
                           else if ( StringUtil.StrCmp(sEvt, "LOAD") == 0 )
                           {
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP2N0( ) ;
                              }
                              if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
                              {
                                 context.wbHandled = 1;
                                 if ( ! wbErr )
                                 {
                                    dynload_actions( ) ;
                                    /* Execute user event: Load */
                                    E142N2 ();
                                 }
                              }
                           }
                           else if ( StringUtil.StrCmp(sEvt, "ENTER") == 0 )
                           {
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP2N0( ) ;
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
                                 STRUP2N0( ) ;
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

      protected void WE2N2( )
      {
         if ( ! GxWebStd.gx_redirect( context) )
         {
            Rfr0gs = true;
            Refresh( ) ;
            if ( ! GxWebStd.gx_redirect( context) )
            {
               RenderHtmlCloseForm2N2( ) ;
            }
         }
      }

      protected void PA2N2( )
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
         RF2N2( ) ;
         if ( isFullAjaxMode( ) )
         {
            send_integrity_footer_hashes( ) ;
         }
      }

      protected void initialize_formulas( )
      {
         /* GeneXus formulas. */
         AV16Pgmname = "BR_DemographicsGeneral";
         context.Gx_err = 0;
      }

      protected void RF2N2( )
      {
         initialize_formulas( ) ;
         clear_multi_value_controls( ) ;
         gxdyncontrolsrefreshing = true;
         fix_multi_value_controls( ) ;
         gxdyncontrolsrefreshing = false;
         if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
         {
            /* Using cursor H002N2 */
            pr_default.execute(0, new Object[] {A61BR_Demographics_ID});
            while ( (pr_default.getStatus(0) != 101) )
            {
               A85BR_Information_ID = H002N2_A85BR_Information_ID[0];
               n85BR_Information_ID = H002N2_n85BR_Information_ID[0];
               A60BR_Demographics_City = H002N2_A60BR_Demographics_City[0];
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A60BR_Demographics_City", A60BR_Demographics_City);
               n60BR_Demographics_City = H002N2_n60BR_Demographics_City[0];
               A59BR_Demographics_Province = H002N2_A59BR_Demographics_Province[0];
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A59BR_Demographics_Province", A59BR_Demographics_Province);
               n59BR_Demographics_Province = H002N2_n59BR_Demographics_Province[0];
               A58BR_Demographics_Insurance = H002N2_A58BR_Demographics_Insurance[0];
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A58BR_Demographics_Insurance", A58BR_Demographics_Insurance);
               n58BR_Demographics_Insurance = H002N2_n58BR_Demographics_Insurance[0];
               A57BR_Demographics_Occupation = H002N2_A57BR_Demographics_Occupation[0];
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A57BR_Demographics_Occupation", A57BR_Demographics_Occupation);
               n57BR_Demographics_Occupation = H002N2_n57BR_Demographics_Occupation[0];
               A56BR_Demographics_Education = H002N2_A56BR_Demographics_Education[0];
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A56BR_Demographics_Education", A56BR_Demographics_Education);
               n56BR_Demographics_Education = H002N2_n56BR_Demographics_Education[0];
               A55BR_Demographics_Ethnic = H002N2_A55BR_Demographics_Ethnic[0];
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A55BR_Demographics_Ethnic", A55BR_Demographics_Ethnic);
               n55BR_Demographics_Ethnic = H002N2_n55BR_Demographics_Ethnic[0];
               A63BR_Demographics_MarritalStatus = H002N2_A63BR_Demographics_MarritalStatus[0];
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A63BR_Demographics_MarritalStatus", A63BR_Demographics_MarritalStatus);
               n63BR_Demographics_MarritalStatus = H002N2_n63BR_Demographics_MarritalStatus[0];
               A54BR_Demographics_Sex = H002N2_A54BR_Demographics_Sex[0];
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A54BR_Demographics_Sex", A54BR_Demographics_Sex);
               n54BR_Demographics_Sex = H002N2_n54BR_Demographics_Sex[0];
               A53BR_Demographics_BirthDate = H002N2_A53BR_Demographics_BirthDate[0];
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A53BR_Demographics_BirthDate", context.localUtil.Format(A53BR_Demographics_BirthDate, "9999/99/99"));
               n53BR_Demographics_BirthDate = H002N2_n53BR_Demographics_BirthDate[0];
               A36BR_Information_PatientNo = H002N2_A36BR_Information_PatientNo[0];
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A36BR_Information_PatientNo", A36BR_Information_PatientNo);
               n36BR_Information_PatientNo = H002N2_n36BR_Information_PatientNo[0];
               A19BR_EncounterID = H002N2_A19BR_EncounterID[0];
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A19BR_EncounterID", StringUtil.LTrim( StringUtil.Str( (decimal)(A19BR_EncounterID), 18, 0)));
               A85BR_Information_ID = H002N2_A85BR_Information_ID[0];
               n85BR_Information_ID = H002N2_n85BR_Information_ID[0];
               A36BR_Information_PatientNo = H002N2_A36BR_Information_PatientNo[0];
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A36BR_Information_PatientNo", A36BR_Information_PatientNo);
               n36BR_Information_PatientNo = H002N2_n36BR_Information_PatientNo[0];
               /* Execute user event: Load */
               E142N2 ();
               /* Exiting from a For First loop. */
               if (true) break;
            }
            pr_default.close(0);
            WB2N0( ) ;
         }
      }

      protected void send_integrity_lvl_hashes2N2( )
      {
      }

      protected void STRUP2N0( )
      {
         /* Before Start, stand alone formulas. */
         AV16Pgmname = "BR_DemographicsGeneral";
         context.Gx_err = 0;
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0;
         /* Execute user event: Start */
         E132N2 ();
         context.wbGlbDoneStart = 1;
         nDoneStart = 1;
         /* After Start, stand alone formulas. */
         sXEvt = cgiGet( "_EventName");
         if ( ! GetJustCreated( ) && ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 ) )
         {
            /* Read saved SDTs. */
            /* Read variables values. */
            A19BR_EncounterID = (long)(context.localUtil.CToN( cgiGet( edtBR_EncounterID_Internalname), ".", ","));
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A19BR_EncounterID", StringUtil.LTrim( StringUtil.Str( (decimal)(A19BR_EncounterID), 18, 0)));
            A36BR_Information_PatientNo = cgiGet( edtBR_Information_PatientNo_Internalname);
            n36BR_Information_PatientNo = false;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A36BR_Information_PatientNo", A36BR_Information_PatientNo);
            A53BR_Demographics_BirthDate = context.localUtil.CToD( cgiGet( edtBR_Demographics_BirthDate_Internalname), 0);
            n53BR_Demographics_BirthDate = false;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A53BR_Demographics_BirthDate", context.localUtil.Format(A53BR_Demographics_BirthDate, "9999/99/99"));
            A54BR_Demographics_Sex = cgiGet( edtBR_Demographics_Sex_Internalname);
            n54BR_Demographics_Sex = false;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A54BR_Demographics_Sex", A54BR_Demographics_Sex);
            A63BR_Demographics_MarritalStatus = cgiGet( edtBR_Demographics_MarritalStatus_Internalname);
            n63BR_Demographics_MarritalStatus = false;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A63BR_Demographics_MarritalStatus", A63BR_Demographics_MarritalStatus);
            A55BR_Demographics_Ethnic = cgiGet( edtBR_Demographics_Ethnic_Internalname);
            n55BR_Demographics_Ethnic = false;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A55BR_Demographics_Ethnic", A55BR_Demographics_Ethnic);
            A56BR_Demographics_Education = cgiGet( edtBR_Demographics_Education_Internalname);
            n56BR_Demographics_Education = false;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A56BR_Demographics_Education", A56BR_Demographics_Education);
            A57BR_Demographics_Occupation = cgiGet( edtBR_Demographics_Occupation_Internalname);
            n57BR_Demographics_Occupation = false;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A57BR_Demographics_Occupation", A57BR_Demographics_Occupation);
            A58BR_Demographics_Insurance = cgiGet( edtBR_Demographics_Insurance_Internalname);
            n58BR_Demographics_Insurance = false;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A58BR_Demographics_Insurance", A58BR_Demographics_Insurance);
            A59BR_Demographics_Province = cgiGet( edtBR_Demographics_Province_Internalname);
            n59BR_Demographics_Province = false;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A59BR_Demographics_Province", A59BR_Demographics_Province);
            A60BR_Demographics_City = cgiGet( edtBR_Demographics_City_Internalname);
            n60BR_Demographics_City = false;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A60BR_Demographics_City", A60BR_Demographics_City);
            /* Read saved values. */
            wcpOA61BR_Demographics_ID = (long)(context.localUtil.CToN( cgiGet( sPrefix+"wcpOA61BR_Demographics_ID"), ".", ","));
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
         E132N2 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E132N2( )
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

      protected void E142N2( )
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
         GXt_boolean1 = AV13TempBoolean;
         new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "Manage_Demographics", out  GXt_boolean1) ;
         AV13TempBoolean = GXt_boolean1;
         if ( ! ( AV13TempBoolean ) )
         {
            bttBtnupdate_Visible = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, bttBtnupdate_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtnupdate_Visible), 5, 0)), true);
         }
         GXt_boolean1 = AV13TempBoolean;
         new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "Manage_Demographics", out  GXt_boolean1) ;
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
         AV9TrnContext.gxTpr_Transactionname = "BR_Demographics";
         AV10TrnContextAtt = new GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext_Attribute(context);
         AV10TrnContextAtt.gxTpr_Attributename = "BR_Demographics_ID";
         AV10TrnContextAtt.gxTpr_Attributevalue = StringUtil.Str( (decimal)(AV8BR_Demographics_ID), 18, 0);
         AV9TrnContext.gxTpr_Attributes.Add(AV10TrnContextAtt, 0);
         AV11Session.Set("TrnContext", AV9TrnContext.ToXml(false, true, "WWPTransactionContext", "DataAnalysisPlatform"));
      }

      public override void setparameters( Object[] obj )
      {
         createObjects();
         initialize();
         A61BR_Demographics_ID = Convert.ToInt64(getParm(obj,0));
         context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A61BR_Demographics_ID", StringUtil.LTrim( StringUtil.Str( (decimal)(A61BR_Demographics_ID), 18, 0)));
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
         PA2N2( ) ;
         WS2N2( ) ;
         WE2N2( ) ;
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
         sCtrlA61BR_Demographics_ID = (String)((String)getParm(obj,0));
      }

      public override void componentrestorestate( String sPPrefix ,
                                                  String sPSFPrefix )
      {
         sPrefix = sPPrefix + sPSFPrefix;
         PA2N2( ) ;
         WCParametersGet( ) ;
      }

      public override void componentprepare( Object[] obj )
      {
         wbLoad = false;
         sCompPrefix = (String)getParm(obj,0);
         sSFPrefix = (String)getParm(obj,1);
         sPrefix = sCompPrefix + sSFPrefix;
         AddComponentObject(sPrefix, "br_demographicsgeneral", GetJustCreated( ));
         if ( ( nDoneStart == 0 ) && ( nDynComponent == 0 ) )
         {
            INITWEB( ) ;
         }
         else
         {
            init_default_properties( ) ;
            init_web_controls( ) ;
         }
         PA2N2( ) ;
         if ( ! GetJustCreated( ) && ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 ) && ( context.wbGlbDoneStart == 0 ) )
         {
            WCParametersGet( ) ;
         }
         else
         {
            A61BR_Demographics_ID = Convert.ToInt64(getParm(obj,2));
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A61BR_Demographics_ID", StringUtil.LTrim( StringUtil.Str( (decimal)(A61BR_Demographics_ID), 18, 0)));
         }
         wcpOA61BR_Demographics_ID = (long)(context.localUtil.CToN( cgiGet( sPrefix+"wcpOA61BR_Demographics_ID"), ".", ","));
         if ( ! GetJustCreated( ) && ( ( A61BR_Demographics_ID != wcpOA61BR_Demographics_ID ) ) )
         {
            setjustcreated();
         }
         wcpOA61BR_Demographics_ID = A61BR_Demographics_ID;
      }

      protected void WCParametersGet( )
      {
         /* Read Component Parameters. */
         sCtrlA61BR_Demographics_ID = cgiGet( sPrefix+"A61BR_Demographics_ID_CTRL");
         if ( StringUtil.Len( sCtrlA61BR_Demographics_ID) > 0 )
         {
            A61BR_Demographics_ID = (long)(context.localUtil.CToN( cgiGet( sCtrlA61BR_Demographics_ID), ".", ","));
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A61BR_Demographics_ID", StringUtil.LTrim( StringUtil.Str( (decimal)(A61BR_Demographics_ID), 18, 0)));
         }
         else
         {
            A61BR_Demographics_ID = (long)(context.localUtil.CToN( cgiGet( sPrefix+"A61BR_Demographics_ID_PARM"), ".", ","));
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
         PA2N2( ) ;
         sEvt = sCompEvt;
         WCParametersGet( ) ;
         WS2N2( ) ;
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
         WS2N2( ) ;
         SaveComponentMsgList(sPrefix);
         context.GX_msglist = BackMsgLst;
      }

      protected void WCParametersSet( )
      {
         GxWebStd.gx_hidden_field( context, sPrefix+"A61BR_Demographics_ID_PARM", StringUtil.LTrim( StringUtil.NToC( (decimal)(A61BR_Demographics_ID), 18, 0, ".", "")));
         if ( StringUtil.Len( StringUtil.RTrim( sCtrlA61BR_Demographics_ID)) > 0 )
         {
            GxWebStd.gx_hidden_field( context, sPrefix+"A61BR_Demographics_ID_CTRL", StringUtil.RTrim( sCtrlA61BR_Demographics_ID));
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
         WE2N2( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?20202281563567", true);
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
         context.AddJavascriptSource("br_demographicsgeneral.js", "?20202281563567", false);
         /* End function include_jscripts */
      }

      protected void init_web_controls( )
      {
         /* End function init_web_controls */
      }

      protected void init_default_properties( )
      {
         edtBR_Demographics_ID_Internalname = sPrefix+"BR_DEMOGRAPHICS_ID";
         edtBR_EncounterID_Internalname = sPrefix+"BR_ENCOUNTERID";
         edtBR_Information_PatientNo_Internalname = sPrefix+"BR_INFORMATION_PATIENTNO";
         edtBR_Demographics_BirthDate_Internalname = sPrefix+"BR_DEMOGRAPHICS_BIRTHDATE";
         edtBR_Demographics_Sex_Internalname = sPrefix+"BR_DEMOGRAPHICS_SEX";
         edtBR_Demographics_MarritalStatus_Internalname = sPrefix+"BR_DEMOGRAPHICS_MARRITALSTATUS";
         edtBR_Demographics_Ethnic_Internalname = sPrefix+"BR_DEMOGRAPHICS_ETHNIC";
         edtBR_Demographics_Education_Internalname = sPrefix+"BR_DEMOGRAPHICS_EDUCATION";
         edtBR_Demographics_Occupation_Internalname = sPrefix+"BR_DEMOGRAPHICS_OCCUPATION";
         edtBR_Demographics_Insurance_Internalname = sPrefix+"BR_DEMOGRAPHICS_INSURANCE";
         edtBR_Demographics_Province_Internalname = sPrefix+"BR_DEMOGRAPHICS_PROVINCE";
         edtBR_Demographics_City_Internalname = sPrefix+"BR_DEMOGRAPHICS_CITY";
         divTransactiondetail_tableattributes_Internalname = sPrefix+"TRANSACTIONDETAIL_TABLEATTRIBUTES";
         bttBtnupdate_Internalname = sPrefix+"BTNUPDATE";
         bttBtndelete_Internalname = sPrefix+"BTNDELETE";
         divTable_Internalname = sPrefix+"TABLE";
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
         bttBtndelete_Visible = 1;
         bttBtnupdate_Visible = 1;
         edtBR_Demographics_City_Jsonclick = "";
         edtBR_Demographics_City_Enabled = 0;
         edtBR_Demographics_Province_Jsonclick = "";
         edtBR_Demographics_Province_Enabled = 0;
         edtBR_Demographics_Insurance_Jsonclick = "";
         edtBR_Demographics_Insurance_Enabled = 0;
         edtBR_Demographics_Occupation_Jsonclick = "";
         edtBR_Demographics_Occupation_Enabled = 0;
         edtBR_Demographics_Education_Jsonclick = "";
         edtBR_Demographics_Education_Enabled = 0;
         edtBR_Demographics_Ethnic_Jsonclick = "";
         edtBR_Demographics_Ethnic_Enabled = 0;
         edtBR_Demographics_MarritalStatus_Jsonclick = "";
         edtBR_Demographics_MarritalStatus_Enabled = 0;
         edtBR_Demographics_Sex_Jsonclick = "";
         edtBR_Demographics_Sex_Enabled = 0;
         edtBR_Demographics_BirthDate_Jsonclick = "";
         edtBR_Demographics_BirthDate_Enabled = 0;
         edtBR_Information_PatientNo_Jsonclick = "";
         edtBR_Information_PatientNo_Link = "";
         edtBR_Information_PatientNo_Enabled = 0;
         edtBR_EncounterID_Jsonclick = "";
         edtBR_EncounterID_Enabled = 0;
         edtBR_Demographics_ID_Jsonclick = "";
         edtBR_Demographics_ID_Enabled = 0;
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
         setEventMetadata("'DOUPDATE'","{handler:'E112N1',iparms:[{av:'A61BR_Demographics_ID',fld:'BR_DEMOGRAPHICS_ID',pic:'ZZZZZZZZZZZZZZZZZZ'}]");
         setEventMetadata("'DOUPDATE'",",oparms:[]}");
         setEventMetadata("'DODELETE'","{handler:'E122N1',iparms:[{av:'A61BR_Demographics_ID',fld:'BR_DEMOGRAPHICS_ID',pic:'ZZZZZZZZZZZZZZZZZZ'}]");
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
         A36BR_Information_PatientNo = "";
         A53BR_Demographics_BirthDate = DateTime.MinValue;
         A54BR_Demographics_Sex = "";
         A63BR_Demographics_MarritalStatus = "";
         A55BR_Demographics_Ethnic = "";
         A56BR_Demographics_Education = "";
         A57BR_Demographics_Occupation = "";
         A58BR_Demographics_Insurance = "";
         A59BR_Demographics_Province = "";
         A60BR_Demographics_City = "";
         TempTags = "";
         ClassString = "";
         StyleString = "";
         bttBtnupdate_Jsonclick = "";
         bttBtndelete_Jsonclick = "";
         Form = new GXWebForm();
         sXEvt = "";
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         scmdbuf = "";
         H002N2_A61BR_Demographics_ID = new long[1] ;
         H002N2_A85BR_Information_ID = new long[1] ;
         H002N2_n85BR_Information_ID = new bool[] {false} ;
         H002N2_A60BR_Demographics_City = new String[] {""} ;
         H002N2_n60BR_Demographics_City = new bool[] {false} ;
         H002N2_A59BR_Demographics_Province = new String[] {""} ;
         H002N2_n59BR_Demographics_Province = new bool[] {false} ;
         H002N2_A58BR_Demographics_Insurance = new String[] {""} ;
         H002N2_n58BR_Demographics_Insurance = new bool[] {false} ;
         H002N2_A57BR_Demographics_Occupation = new String[] {""} ;
         H002N2_n57BR_Demographics_Occupation = new bool[] {false} ;
         H002N2_A56BR_Demographics_Education = new String[] {""} ;
         H002N2_n56BR_Demographics_Education = new bool[] {false} ;
         H002N2_A55BR_Demographics_Ethnic = new String[] {""} ;
         H002N2_n55BR_Demographics_Ethnic = new bool[] {false} ;
         H002N2_A63BR_Demographics_MarritalStatus = new String[] {""} ;
         H002N2_n63BR_Demographics_MarritalStatus = new bool[] {false} ;
         H002N2_A54BR_Demographics_Sex = new String[] {""} ;
         H002N2_n54BR_Demographics_Sex = new bool[] {false} ;
         H002N2_A53BR_Demographics_BirthDate = new DateTime[] {DateTime.MinValue} ;
         H002N2_n53BR_Demographics_BirthDate = new bool[] {false} ;
         H002N2_A36BR_Information_PatientNo = new String[] {""} ;
         H002N2_n36BR_Information_PatientNo = new bool[] {false} ;
         H002N2_A19BR_EncounterID = new long[1] ;
         AV6WWPContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPContext(context);
         AV9TrnContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext(context);
         AV12HTTPRequest = new GxHttpRequest( context);
         AV10TrnContextAtt = new GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext_Attribute(context);
         AV11Session = context.GetSession();
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         sCtrlA61BR_Demographics_ID = "";
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.br_demographicsgeneral__default(),
            new Object[][] {
                new Object[] {
               H002N2_A61BR_Demographics_ID, H002N2_A85BR_Information_ID, H002N2_n85BR_Information_ID, H002N2_A60BR_Demographics_City, H002N2_n60BR_Demographics_City, H002N2_A59BR_Demographics_Province, H002N2_n59BR_Demographics_Province, H002N2_A58BR_Demographics_Insurance, H002N2_n58BR_Demographics_Insurance, H002N2_A57BR_Demographics_Occupation,
               H002N2_n57BR_Demographics_Occupation, H002N2_A56BR_Demographics_Education, H002N2_n56BR_Demographics_Education, H002N2_A55BR_Demographics_Ethnic, H002N2_n55BR_Demographics_Ethnic, H002N2_A63BR_Demographics_MarritalStatus, H002N2_n63BR_Demographics_MarritalStatus, H002N2_A54BR_Demographics_Sex, H002N2_n54BR_Demographics_Sex, H002N2_A53BR_Demographics_BirthDate,
               H002N2_n53BR_Demographics_BirthDate, H002N2_A36BR_Information_PatientNo, H002N2_n36BR_Information_PatientNo, H002N2_A19BR_EncounterID
               }
            }
         );
         AV16Pgmname = "BR_DemographicsGeneral";
         /* GeneXus formulas. */
         AV16Pgmname = "BR_DemographicsGeneral";
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
      private int edtBR_Demographics_ID_Enabled ;
      private int edtBR_EncounterID_Enabled ;
      private int edtBR_Information_PatientNo_Enabled ;
      private int edtBR_Demographics_BirthDate_Enabled ;
      private int edtBR_Demographics_Sex_Enabled ;
      private int edtBR_Demographics_MarritalStatus_Enabled ;
      private int edtBR_Demographics_Ethnic_Enabled ;
      private int edtBR_Demographics_Education_Enabled ;
      private int edtBR_Demographics_Occupation_Enabled ;
      private int edtBR_Demographics_Insurance_Enabled ;
      private int edtBR_Demographics_Province_Enabled ;
      private int edtBR_Demographics_City_Enabled ;
      private int bttBtnupdate_Visible ;
      private int bttBtndelete_Visible ;
      private int idxLst ;
      private long A61BR_Demographics_ID ;
      private long wcpOA61BR_Demographics_ID ;
      private long A19BR_EncounterID ;
      private long A85BR_Information_ID ;
      private long AV8BR_Demographics_ID ;
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
      private String edtBR_Demographics_ID_Internalname ;
      private String edtBR_Demographics_ID_Jsonclick ;
      private String edtBR_EncounterID_Internalname ;
      private String edtBR_EncounterID_Jsonclick ;
      private String edtBR_Information_PatientNo_Internalname ;
      private String edtBR_Information_PatientNo_Link ;
      private String edtBR_Information_PatientNo_Jsonclick ;
      private String edtBR_Demographics_BirthDate_Internalname ;
      private String edtBR_Demographics_BirthDate_Jsonclick ;
      private String edtBR_Demographics_Sex_Internalname ;
      private String edtBR_Demographics_Sex_Jsonclick ;
      private String edtBR_Demographics_MarritalStatus_Internalname ;
      private String edtBR_Demographics_MarritalStatus_Jsonclick ;
      private String edtBR_Demographics_Ethnic_Internalname ;
      private String edtBR_Demographics_Ethnic_Jsonclick ;
      private String edtBR_Demographics_Education_Internalname ;
      private String edtBR_Demographics_Education_Jsonclick ;
      private String edtBR_Demographics_Occupation_Internalname ;
      private String edtBR_Demographics_Occupation_Jsonclick ;
      private String edtBR_Demographics_Insurance_Internalname ;
      private String edtBR_Demographics_Insurance_Jsonclick ;
      private String edtBR_Demographics_Province_Internalname ;
      private String edtBR_Demographics_Province_Jsonclick ;
      private String edtBR_Demographics_City_Internalname ;
      private String edtBR_Demographics_City_Jsonclick ;
      private String TempTags ;
      private String ClassString ;
      private String StyleString ;
      private String bttBtnupdate_Internalname ;
      private String bttBtnupdate_Jsonclick ;
      private String bttBtndelete_Internalname ;
      private String bttBtndelete_Jsonclick ;
      private String sXEvt ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String scmdbuf ;
      private String sCtrlA61BR_Demographics_ID ;
      private DateTime A53BR_Demographics_BirthDate ;
      private bool entryPointCalled ;
      private bool toggleJsOutput ;
      private bool wbLoad ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool gxdyncontrolsrefreshing ;
      private bool n85BR_Information_ID ;
      private bool n60BR_Demographics_City ;
      private bool n59BR_Demographics_Province ;
      private bool n58BR_Demographics_Insurance ;
      private bool n57BR_Demographics_Occupation ;
      private bool n56BR_Demographics_Education ;
      private bool n55BR_Demographics_Ethnic ;
      private bool n63BR_Demographics_MarritalStatus ;
      private bool n54BR_Demographics_Sex ;
      private bool n53BR_Demographics_BirthDate ;
      private bool n36BR_Information_PatientNo ;
      private bool returnInSub ;
      private bool AV13TempBoolean ;
      private bool GXt_boolean1 ;
      private String A36BR_Information_PatientNo ;
      private String A54BR_Demographics_Sex ;
      private String A63BR_Demographics_MarritalStatus ;
      private String A55BR_Demographics_Ethnic ;
      private String A56BR_Demographics_Education ;
      private String A57BR_Demographics_Occupation ;
      private String A58BR_Demographics_Insurance ;
      private String A59BR_Demographics_Province ;
      private String A60BR_Demographics_City ;
      private GXWebForm Form ;
      private IGxDataStore dsDataStore1 ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private long[] H002N2_A61BR_Demographics_ID ;
      private long[] H002N2_A85BR_Information_ID ;
      private bool[] H002N2_n85BR_Information_ID ;
      private String[] H002N2_A60BR_Demographics_City ;
      private bool[] H002N2_n60BR_Demographics_City ;
      private String[] H002N2_A59BR_Demographics_Province ;
      private bool[] H002N2_n59BR_Demographics_Province ;
      private String[] H002N2_A58BR_Demographics_Insurance ;
      private bool[] H002N2_n58BR_Demographics_Insurance ;
      private String[] H002N2_A57BR_Demographics_Occupation ;
      private bool[] H002N2_n57BR_Demographics_Occupation ;
      private String[] H002N2_A56BR_Demographics_Education ;
      private bool[] H002N2_n56BR_Demographics_Education ;
      private String[] H002N2_A55BR_Demographics_Ethnic ;
      private bool[] H002N2_n55BR_Demographics_Ethnic ;
      private String[] H002N2_A63BR_Demographics_MarritalStatus ;
      private bool[] H002N2_n63BR_Demographics_MarritalStatus ;
      private String[] H002N2_A54BR_Demographics_Sex ;
      private bool[] H002N2_n54BR_Demographics_Sex ;
      private DateTime[] H002N2_A53BR_Demographics_BirthDate ;
      private bool[] H002N2_n53BR_Demographics_BirthDate ;
      private String[] H002N2_A36BR_Information_PatientNo ;
      private bool[] H002N2_n36BR_Information_PatientNo ;
      private long[] H002N2_A19BR_EncounterID ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private GxHttpRequest AV12HTTPRequest ;
      private IGxSession AV11Session ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPContext AV6WWPContext ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext AV9TrnContext ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext_Attribute AV10TrnContextAtt ;
   }

   public class br_demographicsgeneral__default : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmH002N2 ;
          prmH002N2 = new Object[] {
          new Object[] {"@BR_Demographics_ID",SqlDbType.Decimal,18,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("H002N2", "SELECT T1.[BR_Demographics_ID], T2.[BR_Information_ID], T1.[BR_Demographics_City], T1.[BR_Demographics_Province], T1.[BR_Demographics_Insurance], T1.[BR_Demographics_Occupation], T1.[BR_Demographics_Education], T1.[BR_Demographics_Ethnic], T1.[BR_Demographics_MarritalStatus], T1.[BR_Demographics_Sex], T1.[BR_Demographics_BirthDate], T3.[BR_Information_PatientNo], T1.[BR_EncounterID] FROM (([BR_Demographics] T1 WITH (NOLOCK) INNER JOIN [BR_Encounter] T2 WITH (NOLOCK) ON T2.[BR_EncounterID] = T1.[BR_EncounterID]) LEFT JOIN [BR_Information] T3 WITH (NOLOCK) ON T3.[BR_Information_ID] = T2.[BR_Information_ID]) WHERE T1.[BR_Demographics_ID] = @BR_Demographics_ID ORDER BY T1.[BR_Demographics_ID] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH002N2,1,0,true,true )
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
                ((long[]) buf[1])[0] = rslt.getLong(2) ;
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
                ((String[]) buf[3])[0] = rslt.getVarchar(3) ;
                ((bool[]) buf[4])[0] = rslt.wasNull(3);
                ((String[]) buf[5])[0] = rslt.getVarchar(4) ;
                ((bool[]) buf[6])[0] = rslt.wasNull(4);
                ((String[]) buf[7])[0] = rslt.getVarchar(5) ;
                ((bool[]) buf[8])[0] = rslt.wasNull(5);
                ((String[]) buf[9])[0] = rslt.getVarchar(6) ;
                ((bool[]) buf[10])[0] = rslt.wasNull(6);
                ((String[]) buf[11])[0] = rslt.getVarchar(7) ;
                ((bool[]) buf[12])[0] = rslt.wasNull(7);
                ((String[]) buf[13])[0] = rslt.getVarchar(8) ;
                ((bool[]) buf[14])[0] = rslt.wasNull(8);
                ((String[]) buf[15])[0] = rslt.getVarchar(9) ;
                ((bool[]) buf[16])[0] = rslt.wasNull(9);
                ((String[]) buf[17])[0] = rslt.getVarchar(10) ;
                ((bool[]) buf[18])[0] = rslt.wasNull(10);
                ((DateTime[]) buf[19])[0] = rslt.getGXDate(11) ;
                ((bool[]) buf[20])[0] = rslt.wasNull(11);
                ((String[]) buf[21])[0] = rslt.getVarchar(12) ;
                ((bool[]) buf[22])[0] = rslt.wasNull(12);
                ((long[]) buf[23])[0] = rslt.getLong(13) ;
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
