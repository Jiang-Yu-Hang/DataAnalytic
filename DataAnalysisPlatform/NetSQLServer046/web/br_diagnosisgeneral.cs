/*
               File: BR_DiagnosisGeneral
        Description: BR_Diagnosis General
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/27/2020 11:54:41.78
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
   public class br_diagnosisgeneral : GXWebComponent, System.Web.SessionState.IRequiresSessionState
   {
      public br_diagnosisgeneral( )
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

      public br_diagnosisgeneral( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( long aP0_BR_DiagnosisID )
      {
         this.A64BR_DiagnosisID = aP0_BR_DiagnosisID;
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
         cmbBR_Diagnosis_InitialDX = new GXCombobox();
         cmbBR_Diagnosis_MetastasesDX = new GXCombobox();
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
                  A64BR_DiagnosisID = (long)(NumberUtil.Val( GetNextPar( ), "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A64BR_DiagnosisID", StringUtil.LTrim( StringUtil.Str( (decimal)(A64BR_DiagnosisID), 18, 0)));
                  setjustcreated();
                  componentprepare(new Object[] {(String)sCompPrefix,(String)sSFPrefix,(long)A64BR_DiagnosisID});
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
            PA3E2( ) ;
            if ( ( GxWebError == 0 ) && ! isAjaxCallMode( ) )
            {
               /* GeneXus formulas. */
               AV16Pgmname = "BR_DiagnosisGeneral";
               context.Gx_err = 0;
               WS3E2( ) ;
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
            context.SendWebValue( "BR_Diagnosis General") ;
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
         context.AddJavascriptSource("gxcfg.js", "?202022711544184", false);
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
               context.WriteHtmlTextNl( "<form id=\"MAINFORM\" autocomplete=\"off\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("br_diagnosisgeneral.aspx") + "?" + UrlEncode("" +A64BR_DiagnosisID)+"\">") ;
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
         forbiddenHiddens = sPrefix + "hsh" + "BR_DiagnosisGeneral";
         forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( A71BR_Diagnosis_MetastasesDX, ""));
         GxWebStd.gx_hidden_field( context, sPrefix+"hsh", GetEncryptedHash( forbiddenHiddens, GXKey));
         GXUtil.WriteLog("br_diagnosisgeneral:[SendSecurityCheck value for]"+"BR_Diagnosis_MetastasesDX:"+StringUtil.RTrim( context.localUtil.Format( A71BR_Diagnosis_MetastasesDX, "")));
      }

      protected void SendCloseFormHiddens( )
      {
         /* Send hidden variables. */
         /* Send saved values. */
         send_integrity_footer_hashes( ) ;
         GxWebStd.gx_hidden_field( context, sPrefix+"wcpOA64BR_DiagnosisID", StringUtil.LTrim( StringUtil.NToC( (decimal)(wcpOA64BR_DiagnosisID), 18, 0, ".", "")));
      }

      protected void RenderHtmlCloseForm3E2( )
      {
         SendCloseFormHiddens( ) ;
         if ( ( StringUtil.Len( sPrefix) != 0 ) && ( context.isAjaxRequest( ) || context.isSpaRequest( ) ) )
         {
            context.AddJavascriptSource("br_diagnosisgeneral.js", "?202022711544187", false);
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
         return "BR_DiagnosisGeneral" ;
      }

      public override String GetPgmdesc( )
      {
         return "BR_Diagnosis General" ;
      }

      protected void WB3E0( )
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
               GxWebStd.gx_hidden_field( context, sPrefix+"_CMPPGM", "br_diagnosisgeneral.aspx");
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
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtBR_Diagnosis_No_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtBR_Diagnosis_No_Internalname, "诊断次序", "col-sm-3 ReadonlyAttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtBR_Diagnosis_No_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A513BR_Diagnosis_No), 10, 0, ".", "")), ((edtBR_Diagnosis_No_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A513BR_Diagnosis_No), "ZZZZZZZZZZ")) : context.localUtil.Format( (decimal)(A513BR_Diagnosis_No), "ZZZZZZZZZZ")), "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBR_Diagnosis_No_Jsonclick, 0, "ReadonlyAttribute", "", "", "", "", 1, edtBR_Diagnosis_No_Enabled, 0, "number", "1", 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_BR_DiagnosisGeneral.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-md-6 DataContentCellNoWrap", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtBR_Diagnosis_DXDescription_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtBR_Diagnosis_DXDescription_Internalname, "诊断名称", "col-sm-3 AttributeReadGrayLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtBR_Diagnosis_DXDescription_Internalname, A69BR_Diagnosis_DXDescription, StringUtil.RTrim( context.localUtil.Format( A69BR_Diagnosis_DXDescription, "")), "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBR_Diagnosis_DXDescription_Jsonclick, 0, "AttributeReadGray", "", "", "", "", 1, edtBR_Diagnosis_DXDescription_Enabled, 0, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_BR_DiagnosisGeneral.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-md-6 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtBR_Diagnosis_DXTsource_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtBR_Diagnosis_DXTsource_Internalname, "诊断来源", "col-sm-3 ReadonlyAttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtBR_Diagnosis_DXTsource_Internalname, A68BR_Diagnosis_DXTsource, StringUtil.RTrim( context.localUtil.Format( A68BR_Diagnosis_DXTsource, "")), "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBR_Diagnosis_DXTsource_Jsonclick, 0, "ReadonlyAttribute", "", "", "", "", 1, edtBR_Diagnosis_DXTsource_Enabled, 0, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_BR_DiagnosisGeneral.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-md-6 DataContentCellNoWrap", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtBR_Diagnosis_DXID_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtBR_Diagnosis_DXID_Internalname, "疾病序号", "col-sm-3 AttributeReadGrayLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtBR_Diagnosis_DXID_Internalname, A65BR_Diagnosis_DXID, StringUtil.RTrim( context.localUtil.Format( A65BR_Diagnosis_DXID, "")), "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBR_Diagnosis_DXID_Jsonclick, 0, "AttributeReadGray", "", "", "", "", 1, edtBR_Diagnosis_DXID_Enabled, 0, "text", "", 40, "chr", 1, "row", 40, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_BR_DiagnosisGeneral.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-md-6 DataContentCellNoWrap", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtBR_Diagnosis_DXCode_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtBR_Diagnosis_DXCode_Internalname, "疾病代码", "col-sm-3 AttributeReadGrayLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtBR_Diagnosis_DXCode_Internalname, A66BR_Diagnosis_DXCode, StringUtil.RTrim( context.localUtil.Format( A66BR_Diagnosis_DXCode, "")), "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBR_Diagnosis_DXCode_Jsonclick, 0, "AttributeReadGray", "", "", "", "", 1, edtBR_Diagnosis_DXCode_Enabled, 0, "text", "", 40, "chr", 1, "row", 40, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_BR_DiagnosisGeneral.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-md-6 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtBR_Diagnosis_DXType_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtBR_Diagnosis_DXType_Internalname, "疾病类型", "col-sm-3 ReadonlyAttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtBR_Diagnosis_DXType_Internalname, A67BR_Diagnosis_DXType, StringUtil.RTrim( context.localUtil.Format( A67BR_Diagnosis_DXType, "")), "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBR_Diagnosis_DXType_Jsonclick, 0, "ReadonlyAttribute", "", "", "", "", 1, edtBR_Diagnosis_DXType_Enabled, 0, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_BR_DiagnosisGeneral.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-md-6 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+cmbBR_Diagnosis_InitialDX_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, cmbBR_Diagnosis_InitialDX_Internalname, "是否为原发肿瘤", "col-sm-3 ReadonlyAttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, cmbBR_Diagnosis_InitialDX, cmbBR_Diagnosis_InitialDX_Internalname, StringUtil.RTrim( A70BR_Diagnosis_InitialDX), 1, cmbBR_Diagnosis_InitialDX_Jsonclick, 0, "'"+sPrefix+"'"+",false,"+"'"+""+"'", "svchar", "", 1, cmbBR_Diagnosis_InitialDX.Enabled, 0, 0, 0, "em", 0, "", "", "ReadonlyAttribute", "", "", "", "", true, "HLP_BR_DiagnosisGeneral.htm");
            cmbBR_Diagnosis_InitialDX.CurrentValue = StringUtil.RTrim( A70BR_Diagnosis_InitialDX);
            context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, cmbBR_Diagnosis_InitialDX_Internalname, "Values", (String)(cmbBR_Diagnosis_InitialDX.ToJavascriptSource()), true);
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-md-6 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+cmbBR_Diagnosis_MetastasesDX_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, cmbBR_Diagnosis_MetastasesDX_Internalname, "是否为转移肿瘤", "col-sm-3 ReadonlyAttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, cmbBR_Diagnosis_MetastasesDX, cmbBR_Diagnosis_MetastasesDX_Internalname, StringUtil.RTrim( A71BR_Diagnosis_MetastasesDX), 1, cmbBR_Diagnosis_MetastasesDX_Jsonclick, 0, "'"+sPrefix+"'"+",false,"+"'"+""+"'", "svchar", "", 1, cmbBR_Diagnosis_MetastasesDX.Enabled, 0, 0, 0, "em", 0, "", "", "ReadonlyAttribute", "", "", "", "", true, "HLP_BR_DiagnosisGeneral.htm");
            cmbBR_Diagnosis_MetastasesDX.CurrentValue = StringUtil.RTrim( A71BR_Diagnosis_MetastasesDX);
            context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, cmbBR_Diagnosis_MetastasesDX_Internalname, "Values", (String)(cmbBR_Diagnosis_MetastasesDX.ToJavascriptSource()), true);
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divBr_diagnosis_dxsource_cell_Internalname, 1, 0, "px", 0, "px", divBr_diagnosis_dxsource_cell_Class, "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", edtBR_Diagnosis_DXSource_Visible, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtBR_Diagnosis_DXSource_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtBR_Diagnosis_DXSource_Internalname, "转移肿瘤来源", "col-sm-3 AttributeReadGrayLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtBR_Diagnosis_DXSource_Internalname, A260BR_Diagnosis_DXSource, StringUtil.RTrim( context.localUtil.Format( A260BR_Diagnosis_DXSource, "")), "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBR_Diagnosis_DXSource_Jsonclick, 0, "AttributeReadGray", "", "", "", "", edtBR_Diagnosis_DXSource_Visible, edtBR_Diagnosis_DXSource_Enabled, 0, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_BR_DiagnosisGeneral.htm");
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
            GxWebStd.gx_single_line_edit( context, edtBR_DiagnosisID_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A64BR_DiagnosisID), 18, 0, ".", "")), context.localUtil.Format( (decimal)(A64BR_DiagnosisID), "ZZZZZZZZZZZZZZZZZZ"), "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBR_DiagnosisID_Jsonclick, 0, "Attribute", "", "", "", "", edtBR_DiagnosisID_Visible, 0, 0, "number", "1", 18, "chr", 1, "row", 18, 0, 0, 0, 1, -1, 0, true, "ID", "right", false, "HLP_BR_DiagnosisGeneral.htm");
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtBR_EncounterID_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A19BR_EncounterID), 18, 0, ".", "")), context.localUtil.Format( (decimal)(A19BR_EncounterID), "ZZZZZZZZZZZZZZZZZZ"), "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBR_EncounterID_Jsonclick, 0, "Attribute", "", "", "", "", edtBR_EncounterID_Visible, 0, 0, "number", "1", 18, "chr", 1, "row", 18, 0, 0, 0, 1, -1, 0, true, "ID", "right", false, "HLP_BR_DiagnosisGeneral.htm");
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtBR_Information_PatientNo_Internalname, A36BR_Information_PatientNo, StringUtil.RTrim( context.localUtil.Format( A36BR_Information_PatientNo, "")), "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBR_Information_PatientNo_Jsonclick, 0, "Attribute", "", "", "", "", edtBR_Information_PatientNo_Visible, 0, 0, "text", "", 80, "chr", 1, "row", 2000, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_BR_DiagnosisGeneral.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
         }
         wbLoad = true;
      }

      protected void START3E2( )
      {
         wbLoad = false;
         wbEnd = 0;
         wbStart = 0;
         if ( StringUtil.Len( sPrefix) == 0 )
         {
            if ( ! context.isSpaRequest( ) )
            {
               Form.Meta.addItem("generator", "GeneXus C# 16_0_0-127771", 0) ;
               Form.Meta.addItem("description", "BR_Diagnosis General", 0) ;
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
               STRUP3E0( ) ;
            }
         }
      }

      protected void WS3E2( )
      {
         START3E2( ) ;
         EVT3E2( ) ;
      }

      protected void EVT3E2( )
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
                                 STRUP3E0( ) ;
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
                                 STRUP3E0( ) ;
                              }
                              if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
                              {
                                 context.wbHandled = 1;
                                 if ( ! wbErr )
                                 {
                                    dynload_actions( ) ;
                                    /* Execute user event: Start */
                                    E113E2 ();
                                 }
                              }
                           }
                           else if ( StringUtil.StrCmp(sEvt, "LOAD") == 0 )
                           {
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP3E0( ) ;
                              }
                              if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
                              {
                                 context.wbHandled = 1;
                                 if ( ! wbErr )
                                 {
                                    dynload_actions( ) ;
                                    /* Execute user event: Load */
                                    E123E2 ();
                                 }
                              }
                           }
                           else if ( StringUtil.StrCmp(sEvt, "ENTER") == 0 )
                           {
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP3E0( ) ;
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
                                 STRUP3E0( ) ;
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

      protected void WE3E2( )
      {
         if ( ! GxWebStd.gx_redirect( context) )
         {
            Rfr0gs = true;
            Refresh( ) ;
            if ( ! GxWebStd.gx_redirect( context) )
            {
               RenderHtmlCloseForm3E2( ) ;
            }
         }
      }

      protected void PA3E2( )
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
         if ( cmbBR_Diagnosis_InitialDX.ItemCount > 0 )
         {
            A70BR_Diagnosis_InitialDX = cmbBR_Diagnosis_InitialDX.getValidValue(A70BR_Diagnosis_InitialDX);
            n70BR_Diagnosis_InitialDX = false;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A70BR_Diagnosis_InitialDX", A70BR_Diagnosis_InitialDX);
         }
         if ( context.isAjaxRequest( ) )
         {
            cmbBR_Diagnosis_InitialDX.CurrentValue = StringUtil.RTrim( A70BR_Diagnosis_InitialDX);
            context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, cmbBR_Diagnosis_InitialDX_Internalname, "Values", cmbBR_Diagnosis_InitialDX.ToJavascriptSource(), true);
         }
         if ( cmbBR_Diagnosis_MetastasesDX.ItemCount > 0 )
         {
            A71BR_Diagnosis_MetastasesDX = cmbBR_Diagnosis_MetastasesDX.getValidValue(A71BR_Diagnosis_MetastasesDX);
            n71BR_Diagnosis_MetastasesDX = false;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A71BR_Diagnosis_MetastasesDX", A71BR_Diagnosis_MetastasesDX);
         }
         if ( context.isAjaxRequest( ) )
         {
            cmbBR_Diagnosis_MetastasesDX.CurrentValue = StringUtil.RTrim( A71BR_Diagnosis_MetastasesDX);
            context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, cmbBR_Diagnosis_MetastasesDX_Internalname, "Values", cmbBR_Diagnosis_MetastasesDX.ToJavascriptSource(), true);
         }
      }

      public void Refresh( )
      {
         send_integrity_hashes( ) ;
         RF3E2( ) ;
         if ( isFullAjaxMode( ) )
         {
            send_integrity_footer_hashes( ) ;
         }
      }

      protected void initialize_formulas( )
      {
         /* GeneXus formulas. */
         AV16Pgmname = "BR_DiagnosisGeneral";
         context.Gx_err = 0;
      }

      protected void RF3E2( )
      {
         initialize_formulas( ) ;
         clear_multi_value_controls( ) ;
         gxdyncontrolsrefreshing = true;
         fix_multi_value_controls( ) ;
         gxdyncontrolsrefreshing = false;
         if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
         {
            /* Using cursor H003E2 */
            pr_default.execute(0, new Object[] {A64BR_DiagnosisID});
            while ( (pr_default.getStatus(0) != 101) )
            {
               A85BR_Information_ID = H003E2_A85BR_Information_ID[0];
               n85BR_Information_ID = H003E2_n85BR_Information_ID[0];
               A36BR_Information_PatientNo = H003E2_A36BR_Information_PatientNo[0];
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A36BR_Information_PatientNo", A36BR_Information_PatientNo);
               n36BR_Information_PatientNo = H003E2_n36BR_Information_PatientNo[0];
               A19BR_EncounterID = H003E2_A19BR_EncounterID[0];
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A19BR_EncounterID", StringUtil.LTrim( StringUtil.Str( (decimal)(A19BR_EncounterID), 18, 0)));
               A260BR_Diagnosis_DXSource = H003E2_A260BR_Diagnosis_DXSource[0];
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A260BR_Diagnosis_DXSource", A260BR_Diagnosis_DXSource);
               n260BR_Diagnosis_DXSource = H003E2_n260BR_Diagnosis_DXSource[0];
               A71BR_Diagnosis_MetastasesDX = H003E2_A71BR_Diagnosis_MetastasesDX[0];
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A71BR_Diagnosis_MetastasesDX", A71BR_Diagnosis_MetastasesDX);
               n71BR_Diagnosis_MetastasesDX = H003E2_n71BR_Diagnosis_MetastasesDX[0];
               A70BR_Diagnosis_InitialDX = H003E2_A70BR_Diagnosis_InitialDX[0];
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A70BR_Diagnosis_InitialDX", A70BR_Diagnosis_InitialDX);
               n70BR_Diagnosis_InitialDX = H003E2_n70BR_Diagnosis_InitialDX[0];
               A67BR_Diagnosis_DXType = H003E2_A67BR_Diagnosis_DXType[0];
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A67BR_Diagnosis_DXType", A67BR_Diagnosis_DXType);
               n67BR_Diagnosis_DXType = H003E2_n67BR_Diagnosis_DXType[0];
               A66BR_Diagnosis_DXCode = H003E2_A66BR_Diagnosis_DXCode[0];
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A66BR_Diagnosis_DXCode", A66BR_Diagnosis_DXCode);
               n66BR_Diagnosis_DXCode = H003E2_n66BR_Diagnosis_DXCode[0];
               A65BR_Diagnosis_DXID = H003E2_A65BR_Diagnosis_DXID[0];
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A65BR_Diagnosis_DXID", A65BR_Diagnosis_DXID);
               n65BR_Diagnosis_DXID = H003E2_n65BR_Diagnosis_DXID[0];
               A68BR_Diagnosis_DXTsource = H003E2_A68BR_Diagnosis_DXTsource[0];
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A68BR_Diagnosis_DXTsource", A68BR_Diagnosis_DXTsource);
               n68BR_Diagnosis_DXTsource = H003E2_n68BR_Diagnosis_DXTsource[0];
               A69BR_Diagnosis_DXDescription = H003E2_A69BR_Diagnosis_DXDescription[0];
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A69BR_Diagnosis_DXDescription", A69BR_Diagnosis_DXDescription);
               n69BR_Diagnosis_DXDescription = H003E2_n69BR_Diagnosis_DXDescription[0];
               A513BR_Diagnosis_No = H003E2_A513BR_Diagnosis_No[0];
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A513BR_Diagnosis_No", StringUtil.LTrim( StringUtil.Str( (decimal)(A513BR_Diagnosis_No), 10, 0)));
               n513BR_Diagnosis_No = H003E2_n513BR_Diagnosis_No[0];
               A85BR_Information_ID = H003E2_A85BR_Information_ID[0];
               n85BR_Information_ID = H003E2_n85BR_Information_ID[0];
               A36BR_Information_PatientNo = H003E2_A36BR_Information_PatientNo[0];
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A36BR_Information_PatientNo", A36BR_Information_PatientNo);
               n36BR_Information_PatientNo = H003E2_n36BR_Information_PatientNo[0];
               /* Execute user event: Load */
               E123E2 ();
               /* Exiting from a For First loop. */
               if (true) break;
            }
            pr_default.close(0);
            WB3E0( ) ;
         }
      }

      protected void send_integrity_lvl_hashes3E2( )
      {
      }

      protected void STRUP3E0( )
      {
         /* Before Start, stand alone formulas. */
         AV16Pgmname = "BR_DiagnosisGeneral";
         context.Gx_err = 0;
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0;
         /* Execute user event: Start */
         E113E2 ();
         context.wbGlbDoneStart = 1;
         nDoneStart = 1;
         /* After Start, stand alone formulas. */
         sXEvt = cgiGet( "_EventName");
         if ( ! GetJustCreated( ) && ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 ) )
         {
            /* Read saved SDTs. */
            /* Read variables values. */
            A513BR_Diagnosis_No = (long)(context.localUtil.CToN( cgiGet( edtBR_Diagnosis_No_Internalname), ".", ","));
            n513BR_Diagnosis_No = false;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A513BR_Diagnosis_No", StringUtil.LTrim( StringUtil.Str( (decimal)(A513BR_Diagnosis_No), 10, 0)));
            A69BR_Diagnosis_DXDescription = cgiGet( edtBR_Diagnosis_DXDescription_Internalname);
            n69BR_Diagnosis_DXDescription = false;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A69BR_Diagnosis_DXDescription", A69BR_Diagnosis_DXDescription);
            A68BR_Diagnosis_DXTsource = cgiGet( edtBR_Diagnosis_DXTsource_Internalname);
            n68BR_Diagnosis_DXTsource = false;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A68BR_Diagnosis_DXTsource", A68BR_Diagnosis_DXTsource);
            A65BR_Diagnosis_DXID = cgiGet( edtBR_Diagnosis_DXID_Internalname);
            n65BR_Diagnosis_DXID = false;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A65BR_Diagnosis_DXID", A65BR_Diagnosis_DXID);
            A66BR_Diagnosis_DXCode = cgiGet( edtBR_Diagnosis_DXCode_Internalname);
            n66BR_Diagnosis_DXCode = false;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A66BR_Diagnosis_DXCode", A66BR_Diagnosis_DXCode);
            A67BR_Diagnosis_DXType = cgiGet( edtBR_Diagnosis_DXType_Internalname);
            n67BR_Diagnosis_DXType = false;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A67BR_Diagnosis_DXType", A67BR_Diagnosis_DXType);
            cmbBR_Diagnosis_InitialDX.CurrentValue = cgiGet( cmbBR_Diagnosis_InitialDX_Internalname);
            A70BR_Diagnosis_InitialDX = cgiGet( cmbBR_Diagnosis_InitialDX_Internalname);
            n70BR_Diagnosis_InitialDX = false;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A70BR_Diagnosis_InitialDX", A70BR_Diagnosis_InitialDX);
            cmbBR_Diagnosis_MetastasesDX.CurrentValue = cgiGet( cmbBR_Diagnosis_MetastasesDX_Internalname);
            A71BR_Diagnosis_MetastasesDX = cgiGet( cmbBR_Diagnosis_MetastasesDX_Internalname);
            n71BR_Diagnosis_MetastasesDX = false;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A71BR_Diagnosis_MetastasesDX", A71BR_Diagnosis_MetastasesDX);
            A260BR_Diagnosis_DXSource = cgiGet( edtBR_Diagnosis_DXSource_Internalname);
            n260BR_Diagnosis_DXSource = false;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A260BR_Diagnosis_DXSource", A260BR_Diagnosis_DXSource);
            A19BR_EncounterID = (long)(context.localUtil.CToN( cgiGet( edtBR_EncounterID_Internalname), ".", ","));
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A19BR_EncounterID", StringUtil.LTrim( StringUtil.Str( (decimal)(A19BR_EncounterID), 18, 0)));
            A36BR_Information_PatientNo = cgiGet( edtBR_Information_PatientNo_Internalname);
            n36BR_Information_PatientNo = false;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A36BR_Information_PatientNo", A36BR_Information_PatientNo);
            /* Read saved values. */
            wcpOA64BR_DiagnosisID = (long)(context.localUtil.CToN( cgiGet( sPrefix+"wcpOA64BR_DiagnosisID"), ".", ","));
            /* Read subfile selected row values. */
            /* Read hidden variables. */
            GXKey = Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
            forbiddenHiddens = sPrefix + "hsh" + "BR_DiagnosisGeneral";
            A71BR_Diagnosis_MetastasesDX = cgiGet( cmbBR_Diagnosis_MetastasesDX_Internalname);
            n71BR_Diagnosis_MetastasesDX = false;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A71BR_Diagnosis_MetastasesDX", A71BR_Diagnosis_MetastasesDX);
            forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( A71BR_Diagnosis_MetastasesDX, ""));
            hsh = cgiGet( sPrefix+"hsh");
            if ( ! GXUtil.CheckEncryptedHash( forbiddenHiddens, hsh, GXKey) )
            {
               GXUtil.WriteLog("br_diagnosisgeneral:[SecurityCheckFailed value for]"+"BR_Diagnosis_MetastasesDX:"+StringUtil.RTrim( context.localUtil.Format( A71BR_Diagnosis_MetastasesDX, "")));
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
         E113E2 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E113E2( )
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

      protected void E123E2( )
      {
         /* Load Routine */
         edtBR_DiagnosisID_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtBR_DiagnosisID_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBR_DiagnosisID_Visible), 5, 0)), true);
         edtBR_EncounterID_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtBR_EncounterID_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBR_EncounterID_Visible), 5, 0)), true);
         edtBR_Information_PatientNo_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtBR_Information_PatientNo_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBR_Information_PatientNo_Visible), 5, 0)), true);
         if ( ! ( ( StringUtil.StrCmp(A71BR_Diagnosis_MetastasesDX, "是") == 0 ) ) )
         {
            edtBR_Diagnosis_DXSource_Visible = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtBR_Diagnosis_DXSource_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBR_Diagnosis_DXSource_Visible), 5, 0)), true);
            divBr_diagnosis_dxsource_cell_Class = "Invisible";
            context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, divBr_diagnosis_dxsource_cell_Internalname, "Class", divBr_diagnosis_dxsource_cell_Class, true);
         }
         else
         {
            edtBR_Diagnosis_DXSource_Visible = 1;
            context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtBR_Diagnosis_DXSource_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBR_Diagnosis_DXSource_Visible), 5, 0)), true);
            divBr_diagnosis_dxsource_cell_Class = "col-xs-12 col-md-6 DataContentCellNoWrap";
            context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, divBr_diagnosis_dxsource_cell_Internalname, "Class", divBr_diagnosis_dxsource_cell_Class, true);
         }
      }

      protected void S112( )
      {
         /* 'PREPARETRANSACTION' Routine */
         AV9TrnContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext(context);
         AV9TrnContext.gxTpr_Callerobject = AV16Pgmname;
         AV9TrnContext.gxTpr_Callerondelete = false;
         AV9TrnContext.gxTpr_Callerurl = AV12HTTPRequest.ScriptName+"?"+AV12HTTPRequest.QueryString;
         AV9TrnContext.gxTpr_Transactionname = "BR_Diagnosis";
         AV10TrnContextAtt = new GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext_Attribute(context);
         AV10TrnContextAtt.gxTpr_Attributename = "BR_DiagnosisID";
         AV10TrnContextAtt.gxTpr_Attributevalue = StringUtil.Str( (decimal)(AV8BR_DiagnosisID), 18, 0);
         AV9TrnContext.gxTpr_Attributes.Add(AV10TrnContextAtt, 0);
         AV11Session.Set("TrnContext", AV9TrnContext.ToXml(false, true, "WWPTransactionContext", "DataAnalysisPlatform"));
      }

      public override void setparameters( Object[] obj )
      {
         createObjects();
         initialize();
         A64BR_DiagnosisID = Convert.ToInt64(getParm(obj,0));
         context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A64BR_DiagnosisID", StringUtil.LTrim( StringUtil.Str( (decimal)(A64BR_DiagnosisID), 18, 0)));
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
         PA3E2( ) ;
         WS3E2( ) ;
         WE3E2( ) ;
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
         sCtrlA64BR_DiagnosisID = (String)((String)getParm(obj,0));
      }

      public override void componentrestorestate( String sPPrefix ,
                                                  String sPSFPrefix )
      {
         sPrefix = sPPrefix + sPSFPrefix;
         PA3E2( ) ;
         WCParametersGet( ) ;
      }

      public override void componentprepare( Object[] obj )
      {
         wbLoad = false;
         sCompPrefix = (String)getParm(obj,0);
         sSFPrefix = (String)getParm(obj,1);
         sPrefix = sCompPrefix + sSFPrefix;
         AddComponentObject(sPrefix, "br_diagnosisgeneral", GetJustCreated( ));
         if ( ( nDoneStart == 0 ) && ( nDynComponent == 0 ) )
         {
            INITWEB( ) ;
         }
         else
         {
            init_default_properties( ) ;
            init_web_controls( ) ;
         }
         PA3E2( ) ;
         if ( ! GetJustCreated( ) && ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 ) && ( context.wbGlbDoneStart == 0 ) )
         {
            WCParametersGet( ) ;
         }
         else
         {
            A64BR_DiagnosisID = Convert.ToInt64(getParm(obj,2));
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A64BR_DiagnosisID", StringUtil.LTrim( StringUtil.Str( (decimal)(A64BR_DiagnosisID), 18, 0)));
         }
         wcpOA64BR_DiagnosisID = (long)(context.localUtil.CToN( cgiGet( sPrefix+"wcpOA64BR_DiagnosisID"), ".", ","));
         if ( ! GetJustCreated( ) && ( ( A64BR_DiagnosisID != wcpOA64BR_DiagnosisID ) ) )
         {
            setjustcreated();
         }
         wcpOA64BR_DiagnosisID = A64BR_DiagnosisID;
      }

      protected void WCParametersGet( )
      {
         /* Read Component Parameters. */
         sCtrlA64BR_DiagnosisID = cgiGet( sPrefix+"A64BR_DiagnosisID_CTRL");
         if ( StringUtil.Len( sCtrlA64BR_DiagnosisID) > 0 )
         {
            A64BR_DiagnosisID = (long)(context.localUtil.CToN( cgiGet( sCtrlA64BR_DiagnosisID), ".", ","));
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A64BR_DiagnosisID", StringUtil.LTrim( StringUtil.Str( (decimal)(A64BR_DiagnosisID), 18, 0)));
         }
         else
         {
            A64BR_DiagnosisID = (long)(context.localUtil.CToN( cgiGet( sPrefix+"A64BR_DiagnosisID_PARM"), ".", ","));
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
         PA3E2( ) ;
         sEvt = sCompEvt;
         WCParametersGet( ) ;
         WS3E2( ) ;
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
         WS3E2( ) ;
         SaveComponentMsgList(sPrefix);
         context.GX_msglist = BackMsgLst;
      }

      protected void WCParametersSet( )
      {
         GxWebStd.gx_hidden_field( context, sPrefix+"A64BR_DiagnosisID_PARM", StringUtil.LTrim( StringUtil.NToC( (decimal)(A64BR_DiagnosisID), 18, 0, ".", "")));
         if ( StringUtil.Len( StringUtil.RTrim( sCtrlA64BR_DiagnosisID)) > 0 )
         {
            GxWebStd.gx_hidden_field( context, sPrefix+"A64BR_DiagnosisID_CTRL", StringUtil.RTrim( sCtrlA64BR_DiagnosisID));
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
         WE3E2( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?202022711544285", true);
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
            context.AddJavascriptSource("br_diagnosisgeneral.js", "?202022711544286", false);
         }
         /* End function include_jscripts */
      }

      protected void init_web_controls( )
      {
         cmbBR_Diagnosis_InitialDX.Name = "BR_DIAGNOSIS_INITIALDX";
         cmbBR_Diagnosis_InitialDX.WebTags = "";
         cmbBR_Diagnosis_InitialDX.addItem("", "(请选择)", 0);
         cmbBR_Diagnosis_InitialDX.addItem("否", "否", 0);
         cmbBR_Diagnosis_InitialDX.addItem("是", "是", 0);
         cmbBR_Diagnosis_InitialDX.addItem("不详", "不详", 0);
         if ( cmbBR_Diagnosis_InitialDX.ItemCount > 0 )
         {
         }
         cmbBR_Diagnosis_MetastasesDX.Name = "BR_DIAGNOSIS_METASTASESDX";
         cmbBR_Diagnosis_MetastasesDX.WebTags = "";
         cmbBR_Diagnosis_MetastasesDX.addItem("", "(请选择)", 0);
         cmbBR_Diagnosis_MetastasesDX.addItem("否", "否", 0);
         cmbBR_Diagnosis_MetastasesDX.addItem("是", "是", 0);
         cmbBR_Diagnosis_MetastasesDX.addItem("不详", "不详", 0);
         if ( cmbBR_Diagnosis_MetastasesDX.ItemCount > 0 )
         {
         }
         /* End function init_web_controls */
      }

      protected void init_default_properties( )
      {
         edtBR_Diagnosis_No_Internalname = sPrefix+"BR_DIAGNOSIS_NO";
         edtBR_Diagnosis_DXDescription_Internalname = sPrefix+"BR_DIAGNOSIS_DXDESCRIPTION";
         edtBR_Diagnosis_DXTsource_Internalname = sPrefix+"BR_DIAGNOSIS_DXTSOURCE";
         edtBR_Diagnosis_DXID_Internalname = sPrefix+"BR_DIAGNOSIS_DXID";
         edtBR_Diagnosis_DXCode_Internalname = sPrefix+"BR_DIAGNOSIS_DXCODE";
         edtBR_Diagnosis_DXType_Internalname = sPrefix+"BR_DIAGNOSIS_DXTYPE";
         cmbBR_Diagnosis_InitialDX_Internalname = sPrefix+"BR_DIAGNOSIS_INITIALDX";
         cmbBR_Diagnosis_MetastasesDX_Internalname = sPrefix+"BR_DIAGNOSIS_METASTASESDX";
         edtBR_Diagnosis_DXSource_Internalname = sPrefix+"BR_DIAGNOSIS_DXSOURCE";
         divBr_diagnosis_dxsource_cell_Internalname = sPrefix+"BR_DIAGNOSIS_DXSOURCE_CELL";
         divTransactiondetail_tableattributes_Internalname = sPrefix+"TRANSACTIONDETAIL_TABLEATTRIBUTES";
         divTable_Internalname = sPrefix+"TABLE";
         edtBR_DiagnosisID_Internalname = sPrefix+"BR_DIAGNOSISID";
         edtBR_EncounterID_Internalname = sPrefix+"BR_ENCOUNTERID";
         edtBR_Information_PatientNo_Internalname = sPrefix+"BR_INFORMATION_PATIENTNO";
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
         edtBR_Information_PatientNo_Jsonclick = "";
         edtBR_Information_PatientNo_Visible = 1;
         edtBR_EncounterID_Jsonclick = "";
         edtBR_EncounterID_Visible = 1;
         edtBR_DiagnosisID_Jsonclick = "";
         edtBR_DiagnosisID_Visible = 1;
         edtBR_Diagnosis_DXSource_Jsonclick = "";
         edtBR_Diagnosis_DXSource_Enabled = 0;
         edtBR_Diagnosis_DXSource_Visible = 1;
         divBr_diagnosis_dxsource_cell_Class = "col-xs-12 col-md-6";
         cmbBR_Diagnosis_MetastasesDX_Jsonclick = "";
         cmbBR_Diagnosis_MetastasesDX.Enabled = 0;
         cmbBR_Diagnosis_InitialDX_Jsonclick = "";
         cmbBR_Diagnosis_InitialDX.Enabled = 0;
         edtBR_Diagnosis_DXType_Jsonclick = "";
         edtBR_Diagnosis_DXType_Enabled = 0;
         edtBR_Diagnosis_DXCode_Jsonclick = "";
         edtBR_Diagnosis_DXCode_Enabled = 0;
         edtBR_Diagnosis_DXID_Jsonclick = "";
         edtBR_Diagnosis_DXID_Enabled = 0;
         edtBR_Diagnosis_DXTsource_Jsonclick = "";
         edtBR_Diagnosis_DXTsource_Enabled = 0;
         edtBR_Diagnosis_DXDescription_Jsonclick = "";
         edtBR_Diagnosis_DXDescription_Enabled = 0;
         edtBR_Diagnosis_No_Jsonclick = "";
         edtBR_Diagnosis_No_Enabled = 0;
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
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[{av:'cmbBR_Diagnosis_MetastasesDX'},{av:'A71BR_Diagnosis_MetastasesDX',fld:'BR_DIAGNOSIS_METASTASESDX',pic:''}]");
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
         AV16Pgmname = "";
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         GXKey = "";
         forbiddenHiddens = "";
         A71BR_Diagnosis_MetastasesDX = "";
         GX_FocusControl = "";
         A69BR_Diagnosis_DXDescription = "";
         A68BR_Diagnosis_DXTsource = "";
         A65BR_Diagnosis_DXID = "";
         A66BR_Diagnosis_DXCode = "";
         A67BR_Diagnosis_DXType = "";
         A70BR_Diagnosis_InitialDX = "";
         A260BR_Diagnosis_DXSource = "";
         A36BR_Information_PatientNo = "";
         Form = new GXWebForm();
         sXEvt = "";
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         scmdbuf = "";
         H003E2_A85BR_Information_ID = new long[1] ;
         H003E2_n85BR_Information_ID = new bool[] {false} ;
         H003E2_A64BR_DiagnosisID = new long[1] ;
         H003E2_A36BR_Information_PatientNo = new String[] {""} ;
         H003E2_n36BR_Information_PatientNo = new bool[] {false} ;
         H003E2_A19BR_EncounterID = new long[1] ;
         H003E2_A260BR_Diagnosis_DXSource = new String[] {""} ;
         H003E2_n260BR_Diagnosis_DXSource = new bool[] {false} ;
         H003E2_A71BR_Diagnosis_MetastasesDX = new String[] {""} ;
         H003E2_n71BR_Diagnosis_MetastasesDX = new bool[] {false} ;
         H003E2_A70BR_Diagnosis_InitialDX = new String[] {""} ;
         H003E2_n70BR_Diagnosis_InitialDX = new bool[] {false} ;
         H003E2_A67BR_Diagnosis_DXType = new String[] {""} ;
         H003E2_n67BR_Diagnosis_DXType = new bool[] {false} ;
         H003E2_A66BR_Diagnosis_DXCode = new String[] {""} ;
         H003E2_n66BR_Diagnosis_DXCode = new bool[] {false} ;
         H003E2_A65BR_Diagnosis_DXID = new String[] {""} ;
         H003E2_n65BR_Diagnosis_DXID = new bool[] {false} ;
         H003E2_A68BR_Diagnosis_DXTsource = new String[] {""} ;
         H003E2_n68BR_Diagnosis_DXTsource = new bool[] {false} ;
         H003E2_A69BR_Diagnosis_DXDescription = new String[] {""} ;
         H003E2_n69BR_Diagnosis_DXDescription = new bool[] {false} ;
         H003E2_A513BR_Diagnosis_No = new long[1] ;
         H003E2_n513BR_Diagnosis_No = new bool[] {false} ;
         hsh = "";
         AV6WWPContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPContext(context);
         AV9TrnContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext(context);
         AV12HTTPRequest = new GxHttpRequest( context);
         AV10TrnContextAtt = new GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext_Attribute(context);
         AV11Session = context.GetSession();
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         sCtrlA64BR_DiagnosisID = "";
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.br_diagnosisgeneral__default(),
            new Object[][] {
                new Object[] {
               H003E2_A85BR_Information_ID, H003E2_n85BR_Information_ID, H003E2_A64BR_DiagnosisID, H003E2_A36BR_Information_PatientNo, H003E2_n36BR_Information_PatientNo, H003E2_A19BR_EncounterID, H003E2_A260BR_Diagnosis_DXSource, H003E2_n260BR_Diagnosis_DXSource, H003E2_A71BR_Diagnosis_MetastasesDX, H003E2_n71BR_Diagnosis_MetastasesDX,
               H003E2_A70BR_Diagnosis_InitialDX, H003E2_n70BR_Diagnosis_InitialDX, H003E2_A67BR_Diagnosis_DXType, H003E2_n67BR_Diagnosis_DXType, H003E2_A66BR_Diagnosis_DXCode, H003E2_n66BR_Diagnosis_DXCode, H003E2_A65BR_Diagnosis_DXID, H003E2_n65BR_Diagnosis_DXID, H003E2_A68BR_Diagnosis_DXTsource, H003E2_n68BR_Diagnosis_DXTsource,
               H003E2_A69BR_Diagnosis_DXDescription, H003E2_n69BR_Diagnosis_DXDescription, H003E2_A513BR_Diagnosis_No, H003E2_n513BR_Diagnosis_No
               }
            }
         );
         AV16Pgmname = "BR_DiagnosisGeneral";
         /* GeneXus formulas. */
         AV16Pgmname = "BR_DiagnosisGeneral";
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
      private int edtBR_Diagnosis_No_Enabled ;
      private int edtBR_Diagnosis_DXDescription_Enabled ;
      private int edtBR_Diagnosis_DXTsource_Enabled ;
      private int edtBR_Diagnosis_DXID_Enabled ;
      private int edtBR_Diagnosis_DXCode_Enabled ;
      private int edtBR_Diagnosis_DXType_Enabled ;
      private int edtBR_Diagnosis_DXSource_Visible ;
      private int edtBR_Diagnosis_DXSource_Enabled ;
      private int edtBR_DiagnosisID_Visible ;
      private int edtBR_EncounterID_Visible ;
      private int edtBR_Information_PatientNo_Visible ;
      private int idxLst ;
      private long A64BR_DiagnosisID ;
      private long wcpOA64BR_DiagnosisID ;
      private long A513BR_Diagnosis_No ;
      private long A19BR_EncounterID ;
      private long A85BR_Information_ID ;
      private long AV8BR_DiagnosisID ;
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
      private String forbiddenHiddens ;
      private String GX_FocusControl ;
      private String divLayoutmaintable_Internalname ;
      private String divTable_Internalname ;
      private String divTransactiondetail_tableattributes_Internalname ;
      private String edtBR_Diagnosis_No_Internalname ;
      private String edtBR_Diagnosis_No_Jsonclick ;
      private String edtBR_Diagnosis_DXDescription_Internalname ;
      private String edtBR_Diagnosis_DXDescription_Jsonclick ;
      private String edtBR_Diagnosis_DXTsource_Internalname ;
      private String edtBR_Diagnosis_DXTsource_Jsonclick ;
      private String edtBR_Diagnosis_DXID_Internalname ;
      private String edtBR_Diagnosis_DXID_Jsonclick ;
      private String edtBR_Diagnosis_DXCode_Internalname ;
      private String edtBR_Diagnosis_DXCode_Jsonclick ;
      private String edtBR_Diagnosis_DXType_Internalname ;
      private String edtBR_Diagnosis_DXType_Jsonclick ;
      private String cmbBR_Diagnosis_InitialDX_Internalname ;
      private String cmbBR_Diagnosis_InitialDX_Jsonclick ;
      private String cmbBR_Diagnosis_MetastasesDX_Internalname ;
      private String cmbBR_Diagnosis_MetastasesDX_Jsonclick ;
      private String divBr_diagnosis_dxsource_cell_Internalname ;
      private String divBr_diagnosis_dxsource_cell_Class ;
      private String edtBR_Diagnosis_DXSource_Internalname ;
      private String edtBR_Diagnosis_DXSource_Jsonclick ;
      private String divHtml_bottomauxiliarcontrols_Internalname ;
      private String edtBR_DiagnosisID_Internalname ;
      private String edtBR_DiagnosisID_Jsonclick ;
      private String edtBR_EncounterID_Internalname ;
      private String edtBR_EncounterID_Jsonclick ;
      private String edtBR_Information_PatientNo_Internalname ;
      private String edtBR_Information_PatientNo_Jsonclick ;
      private String sXEvt ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String scmdbuf ;
      private String hsh ;
      private String sCtrlA64BR_DiagnosisID ;
      private bool entryPointCalled ;
      private bool toggleJsOutput ;
      private bool wbLoad ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool n70BR_Diagnosis_InitialDX ;
      private bool n71BR_Diagnosis_MetastasesDX ;
      private bool gxdyncontrolsrefreshing ;
      private bool n85BR_Information_ID ;
      private bool n36BR_Information_PatientNo ;
      private bool n260BR_Diagnosis_DXSource ;
      private bool n67BR_Diagnosis_DXType ;
      private bool n66BR_Diagnosis_DXCode ;
      private bool n65BR_Diagnosis_DXID ;
      private bool n68BR_Diagnosis_DXTsource ;
      private bool n69BR_Diagnosis_DXDescription ;
      private bool n513BR_Diagnosis_No ;
      private bool returnInSub ;
      private String A71BR_Diagnosis_MetastasesDX ;
      private String A69BR_Diagnosis_DXDescription ;
      private String A68BR_Diagnosis_DXTsource ;
      private String A65BR_Diagnosis_DXID ;
      private String A66BR_Diagnosis_DXCode ;
      private String A67BR_Diagnosis_DXType ;
      private String A70BR_Diagnosis_InitialDX ;
      private String A260BR_Diagnosis_DXSource ;
      private String A36BR_Information_PatientNo ;
      private GXWebForm Form ;
      private IGxDataStore dsDataStore1 ;
      private IGxDataStore dsDefault ;
      private GXCombobox cmbBR_Diagnosis_InitialDX ;
      private GXCombobox cmbBR_Diagnosis_MetastasesDX ;
      private IDataStoreProvider pr_default ;
      private long[] H003E2_A85BR_Information_ID ;
      private bool[] H003E2_n85BR_Information_ID ;
      private long[] H003E2_A64BR_DiagnosisID ;
      private String[] H003E2_A36BR_Information_PatientNo ;
      private bool[] H003E2_n36BR_Information_PatientNo ;
      private long[] H003E2_A19BR_EncounterID ;
      private String[] H003E2_A260BR_Diagnosis_DXSource ;
      private bool[] H003E2_n260BR_Diagnosis_DXSource ;
      private String[] H003E2_A71BR_Diagnosis_MetastasesDX ;
      private bool[] H003E2_n71BR_Diagnosis_MetastasesDX ;
      private String[] H003E2_A70BR_Diagnosis_InitialDX ;
      private bool[] H003E2_n70BR_Diagnosis_InitialDX ;
      private String[] H003E2_A67BR_Diagnosis_DXType ;
      private bool[] H003E2_n67BR_Diagnosis_DXType ;
      private String[] H003E2_A66BR_Diagnosis_DXCode ;
      private bool[] H003E2_n66BR_Diagnosis_DXCode ;
      private String[] H003E2_A65BR_Diagnosis_DXID ;
      private bool[] H003E2_n65BR_Diagnosis_DXID ;
      private String[] H003E2_A68BR_Diagnosis_DXTsource ;
      private bool[] H003E2_n68BR_Diagnosis_DXTsource ;
      private String[] H003E2_A69BR_Diagnosis_DXDescription ;
      private bool[] H003E2_n69BR_Diagnosis_DXDescription ;
      private long[] H003E2_A513BR_Diagnosis_No ;
      private bool[] H003E2_n513BR_Diagnosis_No ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private GxHttpRequest AV12HTTPRequest ;
      private IGxSession AV11Session ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPContext AV6WWPContext ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext AV9TrnContext ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext_Attribute AV10TrnContextAtt ;
   }

   public class br_diagnosisgeneral__default : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmH003E2 ;
          prmH003E2 = new Object[] {
          new Object[] {"@BR_DiagnosisID",SqlDbType.Decimal,18,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("H003E2", "SELECT T2.[BR_Information_ID], T1.[BR_DiagnosisID], T3.[BR_Information_PatientNo], T1.[BR_EncounterID], T1.[BR_Diagnosis_DXSource], T1.[BR_Diagnosis_MetastasesDX], T1.[BR_Diagnosis_InitialDX], T1.[BR_Diagnosis_DXType], T1.[BR_Diagnosis_DXCode], T1.[BR_Diagnosis_DXID], T1.[BR_Diagnosis_DXTsource], T1.[BR_Diagnosis_DXDescription], T1.[BR_Diagnosis_No] FROM (([BR_Diagnosis] T1 WITH (NOLOCK) INNER JOIN [BR_Encounter] T2 WITH (NOLOCK) ON T2.[BR_EncounterID] = T1.[BR_EncounterID]) LEFT JOIN [BR_Information] T3 WITH (NOLOCK) ON T3.[BR_Information_ID] = T2.[BR_Information_ID]) WHERE T1.[BR_DiagnosisID] = @BR_DiagnosisID ORDER BY T1.[BR_DiagnosisID] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH003E2,1,0,true,true )
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
                ((String[]) buf[3])[0] = rslt.getVarchar(3) ;
                ((bool[]) buf[4])[0] = rslt.wasNull(3);
                ((long[]) buf[5])[0] = rslt.getLong(4) ;
                ((String[]) buf[6])[0] = rslt.getVarchar(5) ;
                ((bool[]) buf[7])[0] = rslt.wasNull(5);
                ((String[]) buf[8])[0] = rslt.getVarchar(6) ;
                ((bool[]) buf[9])[0] = rslt.wasNull(6);
                ((String[]) buf[10])[0] = rslt.getVarchar(7) ;
                ((bool[]) buf[11])[0] = rslt.wasNull(7);
                ((String[]) buf[12])[0] = rslt.getVarchar(8) ;
                ((bool[]) buf[13])[0] = rslt.wasNull(8);
                ((String[]) buf[14])[0] = rslt.getVarchar(9) ;
                ((bool[]) buf[15])[0] = rslt.wasNull(9);
                ((String[]) buf[16])[0] = rslt.getVarchar(10) ;
                ((bool[]) buf[17])[0] = rslt.wasNull(10);
                ((String[]) buf[18])[0] = rslt.getVarchar(11) ;
                ((bool[]) buf[19])[0] = rslt.wasNull(11);
                ((String[]) buf[20])[0] = rslt.getVarchar(12) ;
                ((bool[]) buf[21])[0] = rslt.wasNull(12);
                ((long[]) buf[22])[0] = rslt.getLong(13) ;
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
