/*
               File: BR_LabGeneral
        Description: BR_Lab General
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/27/2020 11:54:43.87
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
   public class br_labgeneral : GXWebComponent, System.Web.SessionState.IRequiresSessionState
   {
      public br_labgeneral( )
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

      public br_labgeneral( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( long aP0_BR_LabID )
      {
         this.A101BR_LabID = aP0_BR_LabID;
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
                  A101BR_LabID = (long)(NumberUtil.Val( GetNextPar( ), "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A101BR_LabID", StringUtil.LTrim( StringUtil.Str( (decimal)(A101BR_LabID), 18, 0)));
                  setjustcreated();
                  componentprepare(new Object[] {(String)sCompPrefix,(String)sSFPrefix,(long)A101BR_LabID});
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
            PA3I2( ) ;
            if ( ( GxWebError == 0 ) && ! isAjaxCallMode( ) )
            {
               /* GeneXus formulas. */
               AV16Pgmname = "BR_LabGeneral";
               context.Gx_err = 0;
               WS3I2( ) ;
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
            context.SendWebValue( "BR_Lab General") ;
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
         context.AddJavascriptSource("gxcfg.js", "?202022711544394", false);
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
               context.WriteHtmlTextNl( "<form id=\"MAINFORM\" autocomplete=\"off\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("br_labgeneral.aspx") + "?" + UrlEncode("" +A101BR_LabID)+"\">") ;
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
         GxWebStd.gx_hidden_field( context, sPrefix+"wcpOA101BR_LabID", StringUtil.LTrim( StringUtil.NToC( (decimal)(wcpOA101BR_LabID), 18, 0, ".", "")));
      }

      protected void RenderHtmlCloseForm3I2( )
      {
         SendCloseFormHiddens( ) ;
         if ( ( StringUtil.Len( sPrefix) != 0 ) && ( context.isAjaxRequest( ) || context.isSpaRequest( ) ) )
         {
            context.AddJavascriptSource("br_labgeneral.js", "?20202271154440", false);
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
         return "BR_LabGeneral" ;
      }

      public override String GetPgmdesc( )
      {
         return "BR_Lab General" ;
      }

      protected void WB3I0( )
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
               GxWebStd.gx_hidden_field( context, sPrefix+"_CMPPGM", "br_labgeneral.aspx");
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
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 DataContentCellNoWrap", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divUnnamedtablebr_lab_testname_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-4 MergeLabelCell", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblockbr_lab_testname_Internalname, "项目名称", "", "", lblTextblockbr_lab_testname_Jsonclick, "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_BR_LabGeneral.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-8", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtBR_Lab_TestName_Internalname, "项目名称", "col-sm-3 AttributeReadGrayLabel", 0, true);
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtBR_Lab_TestName_Internalname, A104BR_Lab_TestName, StringUtil.RTrim( context.localUtil.Format( A104BR_Lab_TestName, "")), "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBR_Lab_TestName_Jsonclick, 0, "AttributeReadGray", "", "", "", "", 1, edtBR_Lab_TestName_Enabled, 0, "text", "", 40, "chr", 1, "row", 40, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_BR_LabGeneral.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 DataContentCellNoWrap", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divUnnamedtablebr_lab_testengname_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-4 MergeLabelCell", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblockbr_lab_testengname_Internalname, "项目英文名称", "", "", lblTextblockbr_lab_testengname_Jsonclick, "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_BR_LabGeneral.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-8", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtBR_Lab_TestEngName_Internalname, "项目英文名称", "col-sm-3 AttributeReadGrayLabel", 0, true);
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtBR_Lab_TestEngName_Internalname, A261BR_Lab_TestEngName, StringUtil.RTrim( context.localUtil.Format( A261BR_Lab_TestEngName, "")), "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBR_Lab_TestEngName_Jsonclick, 0, "AttributeReadGray", "", "", "", "", 1, edtBR_Lab_TestEngName_Enabled, 0, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_BR_LabGeneral.htm");
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
            GxWebStd.gx_div_start( context, divUnnamedtablebr_lab_age_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-4 MergeLabelCell", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblockbr_lab_age_Internalname, "年龄", "", "", lblTextblockbr_lab_age_Jsonclick, "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_BR_LabGeneral.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-8", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtBR_Lab_Age_Internalname, "年龄", "col-sm-3 ReadonlyAttributeLabel", 0, true);
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtBR_Lab_Age_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A262BR_Lab_Age), 3, 0, ".", "")), ((edtBR_Lab_Age_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A262BR_Lab_Age), "ZZZ")) : context.localUtil.Format( (decimal)(A262BR_Lab_Age), "ZZZ")), "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBR_Lab_Age_Jsonclick, 0, "ReadonlyAttribute", "", "", "", "", 1, edtBR_Lab_Age_Enabled, 0, "number", "1", 3, "chr", 1, "row", 3, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_BR_LabGeneral.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 DataContentCellNoWrap", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divUnnamedtablebr_lab_diag_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-4 MergeLabelCell", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblockbr_lab_diag_Internalname, "临床诊断", "", "", lblTextblockbr_lab_diag_Jsonclick, "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_BR_LabGeneral.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-8", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtBR_Lab_Diag_Internalname, "临床诊断", "col-sm-3 AttributeReadGrayLabel", 0, true);
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtBR_Lab_Diag_Internalname, A263BR_Lab_Diag, StringUtil.RTrim( context.localUtil.Format( A263BR_Lab_Diag, "")), "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBR_Lab_Diag_Jsonclick, 0, "AttributeReadGray", "", "", "", "", 1, edtBR_Lab_Diag_Enabled, 0, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_BR_LabGeneral.htm");
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
            GxWebStd.gx_div_start( context, divUnnamedtablebr_lab_specimensource_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-4 MergeLabelCell", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblockbr_lab_specimensource_Internalname, "标本种类", "", "", lblTextblockbr_lab_specimensource_Jsonclick, "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_BR_LabGeneral.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-8", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtBR_Lab_SpecimenSource_Internalname, "标本种类", "col-sm-3 ReadonlyAttributeLabel", 0, true);
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtBR_Lab_SpecimenSource_Internalname, A106BR_Lab_SpecimenSource, StringUtil.RTrim( context.localUtil.Format( A106BR_Lab_SpecimenSource, "")), "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBR_Lab_SpecimenSource_Jsonclick, 0, "ReadonlyAttribute", "", "", "", "", 1, edtBR_Lab_SpecimenSource_Enabled, 0, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_BR_LabGeneral.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divUnnamedtablebr_lab_specimendate_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-4 MergeLabelCell", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblockbr_lab_specimendate_Internalname, "采样时间", "", "", lblTextblockbr_lab_specimendate_Jsonclick, "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_BR_LabGeneral.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-8", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtBR_Lab_SpecimenDate_Internalname, "采样时间", "col-sm-3 ReadonlyAttributeLabel", 0, true);
            /* Single line edit */
            context.WriteHtmlText( "<div id=\""+edtBR_Lab_SpecimenDate_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtBR_Lab_SpecimenDate_Internalname, context.localUtil.TToC( A105BR_Lab_SpecimenDate, 10, 8, 0, 0, "/", ":", " "), context.localUtil.Format( A105BR_Lab_SpecimenDate, "9999/99/99 99:99:99"), "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBR_Lab_SpecimenDate_Jsonclick, 0, "ReadonlyAttribute", "", "", "", "", 1, edtBR_Lab_SpecimenDate_Enabled, 0, "text", "", 19, "chr", 1, "row", 19, 0, 0, 0, 1, -1, 0, true, "DM_DataTime", "right", false, "HLP_BR_LabGeneral.htm");
            GxWebStd.gx_bitmap( context, edtBR_Lab_SpecimenDate_Internalname+"_dp_trigger", context.GetImagePath( "61b9b5d3-dff6-4d59-9b00-da61bc2cbe93", "", context.GetTheme( )), "", "", "", "", ((1==0)||(edtBR_Lab_SpecimenDate_Enabled==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;", "", "", "", "", "", "", "", "", 1, false, false, "", "HLP_BR_LabGeneral.htm");
            context.WriteHtmlTextNl( "</div>") ;
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
            GxWebStd.gx_div_start( context, divUnnamedtablebr_lab_receivingtime_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-4 MergeLabelCell", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblockbr_lab_receivingtime_Internalname, "接收时间", "", "", lblTextblockbr_lab_receivingtime_Jsonclick, "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_BR_LabGeneral.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-8", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtBR_Lab_ReceivingTime_Internalname, "接收时间", "col-sm-3 ReadonlyAttributeLabel", 0, true);
            /* Single line edit */
            context.WriteHtmlText( "<div id=\""+edtBR_Lab_ReceivingTime_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtBR_Lab_ReceivingTime_Internalname, context.localUtil.TToC( A264BR_Lab_ReceivingTime, 10, 8, 0, 0, "/", ":", " "), context.localUtil.Format( A264BR_Lab_ReceivingTime, "9999/99/99 99:99:99"), "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBR_Lab_ReceivingTime_Jsonclick, 0, "ReadonlyAttribute", "", "", "", "", 1, edtBR_Lab_ReceivingTime_Enabled, 0, "text", "", 19, "chr", 1, "row", 19, 0, 0, 0, 1, -1, 0, true, "DM_DataTime", "right", false, "HLP_BR_LabGeneral.htm");
            GxWebStd.gx_bitmap( context, edtBR_Lab_ReceivingTime_Internalname+"_dp_trigger", context.GetImagePath( "61b9b5d3-dff6-4d59-9b00-da61bc2cbe93", "", context.GetTheme( )), "", "", "", "", ((1==0)||(edtBR_Lab_ReceivingTime_Enabled==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;", "", "", "", "", "", "", "", "", 1, false, false, "", "HLP_BR_LabGeneral.htm");
            context.WriteHtmlTextNl( "</div>") ;
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divUnnamedtablebr_lab_reporttime_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-4 MergeLabelCell", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblockbr_lab_reporttime_Internalname, "报告时间", "", "", lblTextblockbr_lab_reporttime_Jsonclick, "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_BR_LabGeneral.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-8", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtBR_Lab_ReportTime_Internalname, "报告时间", "col-sm-3 ReadonlyAttributeLabel", 0, true);
            /* Single line edit */
            context.WriteHtmlText( "<div id=\""+edtBR_Lab_ReportTime_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtBR_Lab_ReportTime_Internalname, context.localUtil.TToC( A265BR_Lab_ReportTime, 10, 8, 0, 0, "/", ":", " "), context.localUtil.Format( A265BR_Lab_ReportTime, "9999/99/99 99:99:99"), "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBR_Lab_ReportTime_Jsonclick, 0, "ReadonlyAttribute", "", "", "", "", 1, edtBR_Lab_ReportTime_Enabled, 0, "text", "", 19, "chr", 1, "row", 19, 0, 0, 0, 1, -1, 0, true, "DM_DataTime", "right", false, "HLP_BR_LabGeneral.htm");
            GxWebStd.gx_bitmap( context, edtBR_Lab_ReportTime_Internalname+"_dp_trigger", context.GetImagePath( "61b9b5d3-dff6-4d59-9b00-da61bc2cbe93", "", context.GetTheme( )), "", "", "", "", ((1==0)||(edtBR_Lab_ReportTime_Enabled==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;", "", "", "", "", "", "", "", "", 1, false, false, "", "HLP_BR_LabGeneral.htm");
            context.WriteHtmlTextNl( "</div>") ;
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
            GxWebStd.gx_div_start( context, divUnnamedtablebr_lab_resultqual_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-4 MergeLabelCell", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblockbr_lab_resultqual_Internalname, "定性结果", "", "", lblTextblockbr_lab_resultqual_Jsonclick, "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_BR_LabGeneral.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-8", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtBR_Lab_ResultQual_Internalname, "定性结果", "col-sm-3 ReadonlyAttributeLabel", 0, true);
            /* Multiple line edit */
            ClassString = "ReadonlyAttribute";
            StyleString = "";
            ClassString = "ReadonlyAttribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtBR_Lab_ResultQual_Internalname, A109BR_Lab_ResultQual, "", "", 0, 1, edtBR_Lab_ResultQual_Enabled, 0, 80, "chr", 7, "row", StyleString, ClassString, "", "", "500", -1, 0, "", "", -1, true, "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_LabGeneral.htm");
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
            GxWebStd.gx_div_start( context, divUnnamedtablebr_lab_resultunit_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-4 MergeLabelCell", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblockbr_lab_resultunit_Internalname, "结果单位", "", "", lblTextblockbr_lab_resultunit_Jsonclick, "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_BR_LabGeneral.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-8", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtBR_Lab_ResultUnit_Internalname, "结果单位", "col-sm-3 ReadonlyAttributeLabel", 0, true);
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtBR_Lab_ResultUnit_Internalname, A111BR_Lab_ResultUnit, StringUtil.RTrim( context.localUtil.Format( A111BR_Lab_ResultUnit, "")), "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBR_Lab_ResultUnit_Jsonclick, 0, "ReadonlyAttribute", "", "", "", "", 1, edtBR_Lab_ResultUnit_Enabled, 0, "text", "", 40, "chr", 1, "row", 40, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_BR_LabGeneral.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divUnnamedtablebr_lab_abnind_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-4 MergeLabelCell", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblockbr_lab_abnind_Internalname, "结果提示", "", "", lblTextblockbr_lab_abnind_Jsonclick, "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_BR_LabGeneral.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-8", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtBR_Lab_AbnInd_Internalname, "结果提示", "col-sm-3 ReadonlyAttributeLabel", 0, true);
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtBR_Lab_AbnInd_Internalname, A112BR_Lab_AbnInd, StringUtil.RTrim( context.localUtil.Format( A112BR_Lab_AbnInd, "")), "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBR_Lab_AbnInd_Jsonclick, 0, "ReadonlyAttribute", "", "", "", "", 1, edtBR_Lab_AbnInd_Enabled, 0, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_BR_LabGeneral.htm");
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
            GxWebStd.gx_div_start( context, divUnnamedtablebr_lab_normrangelow_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-4 MergeLabelCell", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblockbr_lab_normrangelow_Internalname, "参考值范围", "", "", lblTextblockbr_lab_normrangelow_Jsonclick, "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_BR_LabGeneral.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-8", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtBR_Lab_NormRangeLow_Internalname, "参考值下限", "col-sm-3 ReadonlyAttributeLabel", 0, true);
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtBR_Lab_NormRangeLow_Internalname, A113BR_Lab_NormRangeLow, StringUtil.RTrim( context.localUtil.Format( A113BR_Lab_NormRangeLow, "")), "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBR_Lab_NormRangeLow_Jsonclick, 0, "ReadonlyAttribute", "", "", "", "", 1, edtBR_Lab_NormRangeLow_Enabled, 0, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_BR_LabGeneral.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 DataContentCellNoWrap", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divUnnamedtablebr_lab_testmethod_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-4 MergeLabelCell", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblockbr_lab_testmethod_Internalname, "检测方法", "", "", lblTextblockbr_lab_testmethod_Jsonclick, "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_BR_LabGeneral.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-8", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtBR_Lab_TestMethod_Internalname, "检测方法", "col-sm-3 AttributeReadGrayLabel", 0, true);
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtBR_Lab_TestMethod_Internalname, A115BR_Lab_TestMethod, StringUtil.RTrim( context.localUtil.Format( A115BR_Lab_TestMethod, "")), "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBR_Lab_TestMethod_Jsonclick, 0, "AttributeReadGray", "", "", "", "", 1, edtBR_Lab_TestMethod_Enabled, 0, "text", "", 40, "chr", 1, "row", 40, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_BR_LabGeneral.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 DataContentCellNoWrap", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divUnnamedtablebr_lab_instrumentcode_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-4 MergeLabelCell", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblockbr_lab_instrumentcode_Internalname, "设备编码", "", "", lblTextblockbr_lab_instrumentcode_Jsonclick, "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_BR_LabGeneral.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-8", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtBR_Lab_InstrumentCode_Internalname, "设备编码", "col-sm-3 AttributeReadGrayLabel", 0, true);
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtBR_Lab_InstrumentCode_Internalname, A118BR_Lab_InstrumentCode, StringUtil.RTrim( context.localUtil.Format( A118BR_Lab_InstrumentCode, "")), "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBR_Lab_InstrumentCode_Jsonclick, 0, "AttributeReadGray", "", "", "", "", 1, edtBR_Lab_InstrumentCode_Enabled, 0, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_BR_LabGeneral.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 DataContentCellNoWrap", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divUnnamedtablebr_lab_instrumentname_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-4 MergeLabelCell", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblockbr_lab_instrumentname_Internalname, "设备名称", "", "", lblTextblockbr_lab_instrumentname_Jsonclick, "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_BR_LabGeneral.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-8", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtBR_Lab_InstrumentName_Internalname, "设备名称", "col-sm-3 AttributeReadGrayLabel", 0, true);
            /* Multiple line edit */
            ClassString = "AttributeReadGray";
            StyleString = "";
            ClassString = "AttributeReadGray";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtBR_Lab_InstrumentName_Internalname, A117BR_Lab_InstrumentName, "", "", 0, 1, edtBR_Lab_InstrumentName_Enabled, 0, 80, "chr", 3, "row", StyleString, ClassString, "", "", "200", -1, 0, "", "", -1, true, "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_LabGeneral.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 DataContentCellNoWrap", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divUnnamedtablebr_lab_resultnum_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-4 MergeLabelCell", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblockbr_lab_resultnum_Internalname, "定量结果", "", "", lblTextblockbr_lab_resultnum_Jsonclick, "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_BR_LabGeneral.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-8", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtBR_Lab_ResultNum_Internalname, "定量结果", "col-sm-3 AttributeReadGrayLabel", 0, true);
            /* Multiple line edit */
            ClassString = "AttributeReadGray";
            StyleString = "";
            ClassString = "AttributeReadGray";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtBR_Lab_ResultNum_Internalname, A110BR_Lab_ResultNum, "", "", 0, 1, edtBR_Lab_ResultNum_Enabled, 0, 80, "chr", 7, "row", StyleString, ClassString, "", "", "500", -1, 0, "", "", -1, true, "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_LabGeneral.htm");
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
            GxWebStd.gx_single_line_edit( context, edtBR_LabID_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A101BR_LabID), 18, 0, ".", "")), context.localUtil.Format( (decimal)(A101BR_LabID), "ZZZZZZZZZZZZZZZZZZ"), "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBR_LabID_Jsonclick, 0, "Attribute", "", "", "", "", edtBR_LabID_Visible, 0, 0, "number", "1", 18, "chr", 1, "row", 18, 0, 0, 0, 1, -1, 0, true, "ID", "right", false, "HLP_BR_LabGeneral.htm");
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtBR_Lab_TestID_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A102BR_Lab_TestID), 10, 0, ".", "")), context.localUtil.Format( (decimal)(A102BR_Lab_TestID), "ZZZZZZZZZZ"), "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBR_Lab_TestID_Jsonclick, 0, "Attribute", "", "", "", "", edtBR_Lab_TestID_Visible, 0, 0, "number", "1", 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_BR_LabGeneral.htm");
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtBR_Lab_SampleID_Internalname, A224BR_Lab_SampleID, StringUtil.RTrim( context.localUtil.Format( A224BR_Lab_SampleID, "")), "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBR_Lab_SampleID_Jsonclick, 0, "Attribute", "", "", "", "", edtBR_Lab_SampleID_Visible, 0, 0, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_BR_LabGeneral.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
         }
         wbLoad = true;
      }

      protected void START3I2( )
      {
         wbLoad = false;
         wbEnd = 0;
         wbStart = 0;
         if ( StringUtil.Len( sPrefix) == 0 )
         {
            if ( ! context.isSpaRequest( ) )
            {
               Form.Meta.addItem("generator", "GeneXus C# 16_0_0-127771", 0) ;
               Form.Meta.addItem("description", "BR_Lab General", 0) ;
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
               STRUP3I0( ) ;
            }
         }
      }

      protected void WS3I2( )
      {
         START3I2( ) ;
         EVT3I2( ) ;
      }

      protected void EVT3I2( )
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
                                 STRUP3I0( ) ;
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
                                 STRUP3I0( ) ;
                              }
                              if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
                              {
                                 context.wbHandled = 1;
                                 if ( ! wbErr )
                                 {
                                    dynload_actions( ) ;
                                    /* Execute user event: Start */
                                    E113I2 ();
                                 }
                              }
                           }
                           else if ( StringUtil.StrCmp(sEvt, "LOAD") == 0 )
                           {
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP3I0( ) ;
                              }
                              if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
                              {
                                 context.wbHandled = 1;
                                 if ( ! wbErr )
                                 {
                                    dynload_actions( ) ;
                                    /* Execute user event: Load */
                                    E123I2 ();
                                 }
                              }
                           }
                           else if ( StringUtil.StrCmp(sEvt, "ENTER") == 0 )
                           {
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP3I0( ) ;
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
                                 STRUP3I0( ) ;
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

      protected void WE3I2( )
      {
         if ( ! GxWebStd.gx_redirect( context) )
         {
            Rfr0gs = true;
            Refresh( ) ;
            if ( ! GxWebStd.gx_redirect( context) )
            {
               RenderHtmlCloseForm3I2( ) ;
            }
         }
      }

      protected void PA3I2( )
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
         RF3I2( ) ;
         if ( isFullAjaxMode( ) )
         {
            send_integrity_footer_hashes( ) ;
         }
      }

      protected void initialize_formulas( )
      {
         /* GeneXus formulas. */
         AV16Pgmname = "BR_LabGeneral";
         context.Gx_err = 0;
      }

      protected void RF3I2( )
      {
         initialize_formulas( ) ;
         clear_multi_value_controls( ) ;
         gxdyncontrolsrefreshing = true;
         fix_multi_value_controls( ) ;
         gxdyncontrolsrefreshing = false;
         if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
         {
            /* Using cursor H003I2 */
            pr_default.execute(0, new Object[] {A101BR_LabID});
            while ( (pr_default.getStatus(0) != 101) )
            {
               A224BR_Lab_SampleID = H003I2_A224BR_Lab_SampleID[0];
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A224BR_Lab_SampleID", A224BR_Lab_SampleID);
               n224BR_Lab_SampleID = H003I2_n224BR_Lab_SampleID[0];
               A102BR_Lab_TestID = H003I2_A102BR_Lab_TestID[0];
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A102BR_Lab_TestID", StringUtil.LTrim( StringUtil.Str( (decimal)(A102BR_Lab_TestID), 10, 0)));
               n102BR_Lab_TestID = H003I2_n102BR_Lab_TestID[0];
               A110BR_Lab_ResultNum = H003I2_A110BR_Lab_ResultNum[0];
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A110BR_Lab_ResultNum", A110BR_Lab_ResultNum);
               n110BR_Lab_ResultNum = H003I2_n110BR_Lab_ResultNum[0];
               A117BR_Lab_InstrumentName = H003I2_A117BR_Lab_InstrumentName[0];
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A117BR_Lab_InstrumentName", A117BR_Lab_InstrumentName);
               n117BR_Lab_InstrumentName = H003I2_n117BR_Lab_InstrumentName[0];
               A118BR_Lab_InstrumentCode = H003I2_A118BR_Lab_InstrumentCode[0];
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A118BR_Lab_InstrumentCode", A118BR_Lab_InstrumentCode);
               n118BR_Lab_InstrumentCode = H003I2_n118BR_Lab_InstrumentCode[0];
               A115BR_Lab_TestMethod = H003I2_A115BR_Lab_TestMethod[0];
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A115BR_Lab_TestMethod", A115BR_Lab_TestMethod);
               n115BR_Lab_TestMethod = H003I2_n115BR_Lab_TestMethod[0];
               A113BR_Lab_NormRangeLow = H003I2_A113BR_Lab_NormRangeLow[0];
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A113BR_Lab_NormRangeLow", A113BR_Lab_NormRangeLow);
               n113BR_Lab_NormRangeLow = H003I2_n113BR_Lab_NormRangeLow[0];
               A112BR_Lab_AbnInd = H003I2_A112BR_Lab_AbnInd[0];
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A112BR_Lab_AbnInd", A112BR_Lab_AbnInd);
               n112BR_Lab_AbnInd = H003I2_n112BR_Lab_AbnInd[0];
               A111BR_Lab_ResultUnit = H003I2_A111BR_Lab_ResultUnit[0];
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A111BR_Lab_ResultUnit", A111BR_Lab_ResultUnit);
               n111BR_Lab_ResultUnit = H003I2_n111BR_Lab_ResultUnit[0];
               A109BR_Lab_ResultQual = H003I2_A109BR_Lab_ResultQual[0];
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A109BR_Lab_ResultQual", A109BR_Lab_ResultQual);
               n109BR_Lab_ResultQual = H003I2_n109BR_Lab_ResultQual[0];
               A265BR_Lab_ReportTime = H003I2_A265BR_Lab_ReportTime[0];
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A265BR_Lab_ReportTime", context.localUtil.TToC( A265BR_Lab_ReportTime, 10, 8, 0, 0, "/", ":", " "));
               n265BR_Lab_ReportTime = H003I2_n265BR_Lab_ReportTime[0];
               A264BR_Lab_ReceivingTime = H003I2_A264BR_Lab_ReceivingTime[0];
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A264BR_Lab_ReceivingTime", context.localUtil.TToC( A264BR_Lab_ReceivingTime, 10, 8, 0, 0, "/", ":", " "));
               n264BR_Lab_ReceivingTime = H003I2_n264BR_Lab_ReceivingTime[0];
               A105BR_Lab_SpecimenDate = H003I2_A105BR_Lab_SpecimenDate[0];
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A105BR_Lab_SpecimenDate", context.localUtil.TToC( A105BR_Lab_SpecimenDate, 10, 8, 0, 0, "/", ":", " "));
               n105BR_Lab_SpecimenDate = H003I2_n105BR_Lab_SpecimenDate[0];
               A106BR_Lab_SpecimenSource = H003I2_A106BR_Lab_SpecimenSource[0];
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A106BR_Lab_SpecimenSource", A106BR_Lab_SpecimenSource);
               n106BR_Lab_SpecimenSource = H003I2_n106BR_Lab_SpecimenSource[0];
               A263BR_Lab_Diag = H003I2_A263BR_Lab_Diag[0];
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A263BR_Lab_Diag", A263BR_Lab_Diag);
               n263BR_Lab_Diag = H003I2_n263BR_Lab_Diag[0];
               A262BR_Lab_Age = H003I2_A262BR_Lab_Age[0];
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A262BR_Lab_Age", StringUtil.LTrim( StringUtil.Str( (decimal)(A262BR_Lab_Age), 3, 0)));
               n262BR_Lab_Age = H003I2_n262BR_Lab_Age[0];
               A261BR_Lab_TestEngName = H003I2_A261BR_Lab_TestEngName[0];
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A261BR_Lab_TestEngName", A261BR_Lab_TestEngName);
               n261BR_Lab_TestEngName = H003I2_n261BR_Lab_TestEngName[0];
               A104BR_Lab_TestName = H003I2_A104BR_Lab_TestName[0];
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A104BR_Lab_TestName", A104BR_Lab_TestName);
               n104BR_Lab_TestName = H003I2_n104BR_Lab_TestName[0];
               /* Execute user event: Load */
               E123I2 ();
               /* Exiting from a For First loop. */
               if (true) break;
            }
            pr_default.close(0);
            WB3I0( ) ;
         }
      }

      protected void send_integrity_lvl_hashes3I2( )
      {
      }

      protected void STRUP3I0( )
      {
         /* Before Start, stand alone formulas. */
         AV16Pgmname = "BR_LabGeneral";
         context.Gx_err = 0;
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0;
         /* Execute user event: Start */
         E113I2 ();
         context.wbGlbDoneStart = 1;
         nDoneStart = 1;
         /* After Start, stand alone formulas. */
         sXEvt = cgiGet( "_EventName");
         if ( ! GetJustCreated( ) && ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 ) )
         {
            /* Read saved SDTs. */
            /* Read variables values. */
            A104BR_Lab_TestName = cgiGet( edtBR_Lab_TestName_Internalname);
            n104BR_Lab_TestName = false;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A104BR_Lab_TestName", A104BR_Lab_TestName);
            A261BR_Lab_TestEngName = cgiGet( edtBR_Lab_TestEngName_Internalname);
            n261BR_Lab_TestEngName = false;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A261BR_Lab_TestEngName", A261BR_Lab_TestEngName);
            A262BR_Lab_Age = (short)(context.localUtil.CToN( cgiGet( edtBR_Lab_Age_Internalname), ".", ","));
            n262BR_Lab_Age = false;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A262BR_Lab_Age", StringUtil.LTrim( StringUtil.Str( (decimal)(A262BR_Lab_Age), 3, 0)));
            A263BR_Lab_Diag = cgiGet( edtBR_Lab_Diag_Internalname);
            n263BR_Lab_Diag = false;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A263BR_Lab_Diag", A263BR_Lab_Diag);
            A106BR_Lab_SpecimenSource = cgiGet( edtBR_Lab_SpecimenSource_Internalname);
            n106BR_Lab_SpecimenSource = false;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A106BR_Lab_SpecimenSource", A106BR_Lab_SpecimenSource);
            A105BR_Lab_SpecimenDate = context.localUtil.CToT( cgiGet( edtBR_Lab_SpecimenDate_Internalname));
            n105BR_Lab_SpecimenDate = false;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A105BR_Lab_SpecimenDate", context.localUtil.TToC( A105BR_Lab_SpecimenDate, 10, 8, 0, 0, "/", ":", " "));
            A264BR_Lab_ReceivingTime = context.localUtil.CToT( cgiGet( edtBR_Lab_ReceivingTime_Internalname));
            n264BR_Lab_ReceivingTime = false;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A264BR_Lab_ReceivingTime", context.localUtil.TToC( A264BR_Lab_ReceivingTime, 10, 8, 0, 0, "/", ":", " "));
            A265BR_Lab_ReportTime = context.localUtil.CToT( cgiGet( edtBR_Lab_ReportTime_Internalname));
            n265BR_Lab_ReportTime = false;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A265BR_Lab_ReportTime", context.localUtil.TToC( A265BR_Lab_ReportTime, 10, 8, 0, 0, "/", ":", " "));
            A109BR_Lab_ResultQual = cgiGet( edtBR_Lab_ResultQual_Internalname);
            n109BR_Lab_ResultQual = false;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A109BR_Lab_ResultQual", A109BR_Lab_ResultQual);
            A111BR_Lab_ResultUnit = cgiGet( edtBR_Lab_ResultUnit_Internalname);
            n111BR_Lab_ResultUnit = false;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A111BR_Lab_ResultUnit", A111BR_Lab_ResultUnit);
            A112BR_Lab_AbnInd = cgiGet( edtBR_Lab_AbnInd_Internalname);
            n112BR_Lab_AbnInd = false;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A112BR_Lab_AbnInd", A112BR_Lab_AbnInd);
            A113BR_Lab_NormRangeLow = cgiGet( edtBR_Lab_NormRangeLow_Internalname);
            n113BR_Lab_NormRangeLow = false;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A113BR_Lab_NormRangeLow", A113BR_Lab_NormRangeLow);
            A115BR_Lab_TestMethod = cgiGet( edtBR_Lab_TestMethod_Internalname);
            n115BR_Lab_TestMethod = false;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A115BR_Lab_TestMethod", A115BR_Lab_TestMethod);
            A118BR_Lab_InstrumentCode = cgiGet( edtBR_Lab_InstrumentCode_Internalname);
            n118BR_Lab_InstrumentCode = false;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A118BR_Lab_InstrumentCode", A118BR_Lab_InstrumentCode);
            A117BR_Lab_InstrumentName = cgiGet( edtBR_Lab_InstrumentName_Internalname);
            n117BR_Lab_InstrumentName = false;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A117BR_Lab_InstrumentName", A117BR_Lab_InstrumentName);
            A110BR_Lab_ResultNum = cgiGet( edtBR_Lab_ResultNum_Internalname);
            n110BR_Lab_ResultNum = false;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A110BR_Lab_ResultNum", A110BR_Lab_ResultNum);
            A102BR_Lab_TestID = (long)(context.localUtil.CToN( cgiGet( edtBR_Lab_TestID_Internalname), ".", ","));
            n102BR_Lab_TestID = false;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A102BR_Lab_TestID", StringUtil.LTrim( StringUtil.Str( (decimal)(A102BR_Lab_TestID), 10, 0)));
            A224BR_Lab_SampleID = cgiGet( edtBR_Lab_SampleID_Internalname);
            n224BR_Lab_SampleID = false;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A224BR_Lab_SampleID", A224BR_Lab_SampleID);
            /* Read saved values. */
            wcpOA101BR_LabID = (long)(context.localUtil.CToN( cgiGet( sPrefix+"wcpOA101BR_LabID"), ".", ","));
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
         E113I2 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E113I2( )
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

      protected void E123I2( )
      {
         /* Load Routine */
         edtBR_LabID_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtBR_LabID_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBR_LabID_Visible), 5, 0)), true);
         edtBR_Lab_TestID_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtBR_Lab_TestID_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBR_Lab_TestID_Visible), 5, 0)), true);
         edtBR_Lab_SampleID_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtBR_Lab_SampleID_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBR_Lab_SampleID_Visible), 5, 0)), true);
      }

      protected void S112( )
      {
         /* 'PREPARETRANSACTION' Routine */
         AV9TrnContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext(context);
         AV9TrnContext.gxTpr_Callerobject = AV16Pgmname;
         AV9TrnContext.gxTpr_Callerondelete = false;
         AV9TrnContext.gxTpr_Callerurl = AV12HTTPRequest.ScriptName+"?"+AV12HTTPRequest.QueryString;
         AV9TrnContext.gxTpr_Transactionname = "BR_Lab";
         AV10TrnContextAtt = new GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext_Attribute(context);
         AV10TrnContextAtt.gxTpr_Attributename = "BR_LabID";
         AV10TrnContextAtt.gxTpr_Attributevalue = StringUtil.Str( (decimal)(AV8BR_LabID), 18, 0);
         AV9TrnContext.gxTpr_Attributes.Add(AV10TrnContextAtt, 0);
         AV11Session.Set("TrnContext", AV9TrnContext.ToXml(false, true, "WWPTransactionContext", "DataAnalysisPlatform"));
      }

      public override void setparameters( Object[] obj )
      {
         createObjects();
         initialize();
         A101BR_LabID = Convert.ToInt64(getParm(obj,0));
         context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A101BR_LabID", StringUtil.LTrim( StringUtil.Str( (decimal)(A101BR_LabID), 18, 0)));
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
         PA3I2( ) ;
         WS3I2( ) ;
         WE3I2( ) ;
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
         sCtrlA101BR_LabID = (String)((String)getParm(obj,0));
      }

      public override void componentrestorestate( String sPPrefix ,
                                                  String sPSFPrefix )
      {
         sPrefix = sPPrefix + sPSFPrefix;
         PA3I2( ) ;
         WCParametersGet( ) ;
      }

      public override void componentprepare( Object[] obj )
      {
         wbLoad = false;
         sCompPrefix = (String)getParm(obj,0);
         sSFPrefix = (String)getParm(obj,1);
         sPrefix = sCompPrefix + sSFPrefix;
         AddComponentObject(sPrefix, "br_labgeneral", GetJustCreated( ));
         if ( ( nDoneStart == 0 ) && ( nDynComponent == 0 ) )
         {
            INITWEB( ) ;
         }
         else
         {
            init_default_properties( ) ;
            init_web_controls( ) ;
         }
         PA3I2( ) ;
         if ( ! GetJustCreated( ) && ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 ) && ( context.wbGlbDoneStart == 0 ) )
         {
            WCParametersGet( ) ;
         }
         else
         {
            A101BR_LabID = Convert.ToInt64(getParm(obj,2));
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A101BR_LabID", StringUtil.LTrim( StringUtil.Str( (decimal)(A101BR_LabID), 18, 0)));
         }
         wcpOA101BR_LabID = (long)(context.localUtil.CToN( cgiGet( sPrefix+"wcpOA101BR_LabID"), ".", ","));
         if ( ! GetJustCreated( ) && ( ( A101BR_LabID != wcpOA101BR_LabID ) ) )
         {
            setjustcreated();
         }
         wcpOA101BR_LabID = A101BR_LabID;
      }

      protected void WCParametersGet( )
      {
         /* Read Component Parameters. */
         sCtrlA101BR_LabID = cgiGet( sPrefix+"A101BR_LabID_CTRL");
         if ( StringUtil.Len( sCtrlA101BR_LabID) > 0 )
         {
            A101BR_LabID = (long)(context.localUtil.CToN( cgiGet( sCtrlA101BR_LabID), ".", ","));
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A101BR_LabID", StringUtil.LTrim( StringUtil.Str( (decimal)(A101BR_LabID), 18, 0)));
         }
         else
         {
            A101BR_LabID = (long)(context.localUtil.CToN( cgiGet( sPrefix+"A101BR_LabID_PARM"), ".", ","));
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
         PA3I2( ) ;
         sEvt = sCompEvt;
         WCParametersGet( ) ;
         WS3I2( ) ;
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
         WS3I2( ) ;
         SaveComponentMsgList(sPrefix);
         context.GX_msglist = BackMsgLst;
      }

      protected void WCParametersSet( )
      {
         GxWebStd.gx_hidden_field( context, sPrefix+"A101BR_LabID_PARM", StringUtil.LTrim( StringUtil.NToC( (decimal)(A101BR_LabID), 18, 0, ".", "")));
         if ( StringUtil.Len( StringUtil.RTrim( sCtrlA101BR_LabID)) > 0 )
         {
            GxWebStd.gx_hidden_field( context, sPrefix+"A101BR_LabID_CTRL", StringUtil.RTrim( sCtrlA101BR_LabID));
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
         WE3I2( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?202022711544754", true);
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
            context.AddJavascriptSource("br_labgeneral.js", "?202022711544755", false);
         }
         /* End function include_jscripts */
      }

      protected void init_web_controls( )
      {
         /* End function init_web_controls */
      }

      protected void init_default_properties( )
      {
         lblTextblockbr_lab_testname_Internalname = sPrefix+"TEXTBLOCKBR_LAB_TESTNAME";
         edtBR_Lab_TestName_Internalname = sPrefix+"BR_LAB_TESTNAME";
         divUnnamedtablebr_lab_testname_Internalname = sPrefix+"UNNAMEDTABLEBR_LAB_TESTNAME";
         lblTextblockbr_lab_testengname_Internalname = sPrefix+"TEXTBLOCKBR_LAB_TESTENGNAME";
         edtBR_Lab_TestEngName_Internalname = sPrefix+"BR_LAB_TESTENGNAME";
         divUnnamedtablebr_lab_testengname_Internalname = sPrefix+"UNNAMEDTABLEBR_LAB_TESTENGNAME";
         lblTextblockbr_lab_age_Internalname = sPrefix+"TEXTBLOCKBR_LAB_AGE";
         edtBR_Lab_Age_Internalname = sPrefix+"BR_LAB_AGE";
         divUnnamedtablebr_lab_age_Internalname = sPrefix+"UNNAMEDTABLEBR_LAB_AGE";
         lblTextblockbr_lab_diag_Internalname = sPrefix+"TEXTBLOCKBR_LAB_DIAG";
         edtBR_Lab_Diag_Internalname = sPrefix+"BR_LAB_DIAG";
         divUnnamedtablebr_lab_diag_Internalname = sPrefix+"UNNAMEDTABLEBR_LAB_DIAG";
         lblTextblockbr_lab_specimensource_Internalname = sPrefix+"TEXTBLOCKBR_LAB_SPECIMENSOURCE";
         edtBR_Lab_SpecimenSource_Internalname = sPrefix+"BR_LAB_SPECIMENSOURCE";
         divUnnamedtablebr_lab_specimensource_Internalname = sPrefix+"UNNAMEDTABLEBR_LAB_SPECIMENSOURCE";
         lblTextblockbr_lab_specimendate_Internalname = sPrefix+"TEXTBLOCKBR_LAB_SPECIMENDATE";
         edtBR_Lab_SpecimenDate_Internalname = sPrefix+"BR_LAB_SPECIMENDATE";
         divUnnamedtablebr_lab_specimendate_Internalname = sPrefix+"UNNAMEDTABLEBR_LAB_SPECIMENDATE";
         lblTextblockbr_lab_receivingtime_Internalname = sPrefix+"TEXTBLOCKBR_LAB_RECEIVINGTIME";
         edtBR_Lab_ReceivingTime_Internalname = sPrefix+"BR_LAB_RECEIVINGTIME";
         divUnnamedtablebr_lab_receivingtime_Internalname = sPrefix+"UNNAMEDTABLEBR_LAB_RECEIVINGTIME";
         lblTextblockbr_lab_reporttime_Internalname = sPrefix+"TEXTBLOCKBR_LAB_REPORTTIME";
         edtBR_Lab_ReportTime_Internalname = sPrefix+"BR_LAB_REPORTTIME";
         divUnnamedtablebr_lab_reporttime_Internalname = sPrefix+"UNNAMEDTABLEBR_LAB_REPORTTIME";
         lblTextblockbr_lab_resultqual_Internalname = sPrefix+"TEXTBLOCKBR_LAB_RESULTQUAL";
         edtBR_Lab_ResultQual_Internalname = sPrefix+"BR_LAB_RESULTQUAL";
         divUnnamedtablebr_lab_resultqual_Internalname = sPrefix+"UNNAMEDTABLEBR_LAB_RESULTQUAL";
         lblTextblockbr_lab_resultunit_Internalname = sPrefix+"TEXTBLOCKBR_LAB_RESULTUNIT";
         edtBR_Lab_ResultUnit_Internalname = sPrefix+"BR_LAB_RESULTUNIT";
         divUnnamedtablebr_lab_resultunit_Internalname = sPrefix+"UNNAMEDTABLEBR_LAB_RESULTUNIT";
         lblTextblockbr_lab_abnind_Internalname = sPrefix+"TEXTBLOCKBR_LAB_ABNIND";
         edtBR_Lab_AbnInd_Internalname = sPrefix+"BR_LAB_ABNIND";
         divUnnamedtablebr_lab_abnind_Internalname = sPrefix+"UNNAMEDTABLEBR_LAB_ABNIND";
         lblTextblockbr_lab_normrangelow_Internalname = sPrefix+"TEXTBLOCKBR_LAB_NORMRANGELOW";
         edtBR_Lab_NormRangeLow_Internalname = sPrefix+"BR_LAB_NORMRANGELOW";
         divUnnamedtablebr_lab_normrangelow_Internalname = sPrefix+"UNNAMEDTABLEBR_LAB_NORMRANGELOW";
         lblTextblockbr_lab_testmethod_Internalname = sPrefix+"TEXTBLOCKBR_LAB_TESTMETHOD";
         edtBR_Lab_TestMethod_Internalname = sPrefix+"BR_LAB_TESTMETHOD";
         divUnnamedtablebr_lab_testmethod_Internalname = sPrefix+"UNNAMEDTABLEBR_LAB_TESTMETHOD";
         lblTextblockbr_lab_instrumentcode_Internalname = sPrefix+"TEXTBLOCKBR_LAB_INSTRUMENTCODE";
         edtBR_Lab_InstrumentCode_Internalname = sPrefix+"BR_LAB_INSTRUMENTCODE";
         divUnnamedtablebr_lab_instrumentcode_Internalname = sPrefix+"UNNAMEDTABLEBR_LAB_INSTRUMENTCODE";
         lblTextblockbr_lab_instrumentname_Internalname = sPrefix+"TEXTBLOCKBR_LAB_INSTRUMENTNAME";
         edtBR_Lab_InstrumentName_Internalname = sPrefix+"BR_LAB_INSTRUMENTNAME";
         divUnnamedtablebr_lab_instrumentname_Internalname = sPrefix+"UNNAMEDTABLEBR_LAB_INSTRUMENTNAME";
         lblTextblockbr_lab_resultnum_Internalname = sPrefix+"TEXTBLOCKBR_LAB_RESULTNUM";
         edtBR_Lab_ResultNum_Internalname = sPrefix+"BR_LAB_RESULTNUM";
         divUnnamedtablebr_lab_resultnum_Internalname = sPrefix+"UNNAMEDTABLEBR_LAB_RESULTNUM";
         divTransactiondetail_tableattributes_Internalname = sPrefix+"TRANSACTIONDETAIL_TABLEATTRIBUTES";
         divTable_Internalname = sPrefix+"TABLE";
         edtBR_LabID_Internalname = sPrefix+"BR_LABID";
         edtBR_Lab_TestID_Internalname = sPrefix+"BR_LAB_TESTID";
         edtBR_Lab_SampleID_Internalname = sPrefix+"BR_LAB_SAMPLEID";
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
         edtBR_Lab_SampleID_Jsonclick = "";
         edtBR_Lab_SampleID_Visible = 1;
         edtBR_Lab_TestID_Jsonclick = "";
         edtBR_Lab_TestID_Visible = 1;
         edtBR_LabID_Jsonclick = "";
         edtBR_LabID_Visible = 1;
         edtBR_Lab_ResultNum_Enabled = 0;
         edtBR_Lab_InstrumentName_Enabled = 0;
         edtBR_Lab_InstrumentCode_Jsonclick = "";
         edtBR_Lab_InstrumentCode_Enabled = 0;
         edtBR_Lab_TestMethod_Jsonclick = "";
         edtBR_Lab_TestMethod_Enabled = 0;
         edtBR_Lab_NormRangeLow_Jsonclick = "";
         edtBR_Lab_NormRangeLow_Enabled = 0;
         edtBR_Lab_AbnInd_Jsonclick = "";
         edtBR_Lab_AbnInd_Enabled = 0;
         edtBR_Lab_ResultUnit_Jsonclick = "";
         edtBR_Lab_ResultUnit_Enabled = 0;
         edtBR_Lab_ResultQual_Enabled = 0;
         edtBR_Lab_ReportTime_Jsonclick = "";
         edtBR_Lab_ReportTime_Enabled = 0;
         edtBR_Lab_ReceivingTime_Jsonclick = "";
         edtBR_Lab_ReceivingTime_Enabled = 0;
         edtBR_Lab_SpecimenDate_Jsonclick = "";
         edtBR_Lab_SpecimenDate_Enabled = 0;
         edtBR_Lab_SpecimenSource_Jsonclick = "";
         edtBR_Lab_SpecimenSource_Enabled = 0;
         edtBR_Lab_Diag_Jsonclick = "";
         edtBR_Lab_Diag_Enabled = 0;
         edtBR_Lab_Age_Jsonclick = "";
         edtBR_Lab_Age_Enabled = 0;
         edtBR_Lab_TestEngName_Jsonclick = "";
         edtBR_Lab_TestEngName_Enabled = 0;
         edtBR_Lab_TestName_Jsonclick = "";
         edtBR_Lab_TestName_Enabled = 0;
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
         AV16Pgmname = "";
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         GXKey = "";
         GX_FocusControl = "";
         lblTextblockbr_lab_testname_Jsonclick = "";
         A104BR_Lab_TestName = "";
         lblTextblockbr_lab_testengname_Jsonclick = "";
         A261BR_Lab_TestEngName = "";
         lblTextblockbr_lab_age_Jsonclick = "";
         lblTextblockbr_lab_diag_Jsonclick = "";
         A263BR_Lab_Diag = "";
         lblTextblockbr_lab_specimensource_Jsonclick = "";
         A106BR_Lab_SpecimenSource = "";
         lblTextblockbr_lab_specimendate_Jsonclick = "";
         A105BR_Lab_SpecimenDate = (DateTime)(DateTime.MinValue);
         lblTextblockbr_lab_receivingtime_Jsonclick = "";
         A264BR_Lab_ReceivingTime = (DateTime)(DateTime.MinValue);
         lblTextblockbr_lab_reporttime_Jsonclick = "";
         A265BR_Lab_ReportTime = (DateTime)(DateTime.MinValue);
         lblTextblockbr_lab_resultqual_Jsonclick = "";
         ClassString = "";
         StyleString = "";
         A109BR_Lab_ResultQual = "";
         lblTextblockbr_lab_resultunit_Jsonclick = "";
         A111BR_Lab_ResultUnit = "";
         lblTextblockbr_lab_abnind_Jsonclick = "";
         A112BR_Lab_AbnInd = "";
         lblTextblockbr_lab_normrangelow_Jsonclick = "";
         A113BR_Lab_NormRangeLow = "";
         lblTextblockbr_lab_testmethod_Jsonclick = "";
         A115BR_Lab_TestMethod = "";
         lblTextblockbr_lab_instrumentcode_Jsonclick = "";
         A118BR_Lab_InstrumentCode = "";
         lblTextblockbr_lab_instrumentname_Jsonclick = "";
         A117BR_Lab_InstrumentName = "";
         lblTextblockbr_lab_resultnum_Jsonclick = "";
         A110BR_Lab_ResultNum = "";
         A224BR_Lab_SampleID = "";
         Form = new GXWebForm();
         sXEvt = "";
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         scmdbuf = "";
         H003I2_A101BR_LabID = new long[1] ;
         H003I2_A224BR_Lab_SampleID = new String[] {""} ;
         H003I2_n224BR_Lab_SampleID = new bool[] {false} ;
         H003I2_A102BR_Lab_TestID = new long[1] ;
         H003I2_n102BR_Lab_TestID = new bool[] {false} ;
         H003I2_A110BR_Lab_ResultNum = new String[] {""} ;
         H003I2_n110BR_Lab_ResultNum = new bool[] {false} ;
         H003I2_A117BR_Lab_InstrumentName = new String[] {""} ;
         H003I2_n117BR_Lab_InstrumentName = new bool[] {false} ;
         H003I2_A118BR_Lab_InstrumentCode = new String[] {""} ;
         H003I2_n118BR_Lab_InstrumentCode = new bool[] {false} ;
         H003I2_A115BR_Lab_TestMethod = new String[] {""} ;
         H003I2_n115BR_Lab_TestMethod = new bool[] {false} ;
         H003I2_A113BR_Lab_NormRangeLow = new String[] {""} ;
         H003I2_n113BR_Lab_NormRangeLow = new bool[] {false} ;
         H003I2_A112BR_Lab_AbnInd = new String[] {""} ;
         H003I2_n112BR_Lab_AbnInd = new bool[] {false} ;
         H003I2_A111BR_Lab_ResultUnit = new String[] {""} ;
         H003I2_n111BR_Lab_ResultUnit = new bool[] {false} ;
         H003I2_A109BR_Lab_ResultQual = new String[] {""} ;
         H003I2_n109BR_Lab_ResultQual = new bool[] {false} ;
         H003I2_A265BR_Lab_ReportTime = new DateTime[] {DateTime.MinValue} ;
         H003I2_n265BR_Lab_ReportTime = new bool[] {false} ;
         H003I2_A264BR_Lab_ReceivingTime = new DateTime[] {DateTime.MinValue} ;
         H003I2_n264BR_Lab_ReceivingTime = new bool[] {false} ;
         H003I2_A105BR_Lab_SpecimenDate = new DateTime[] {DateTime.MinValue} ;
         H003I2_n105BR_Lab_SpecimenDate = new bool[] {false} ;
         H003I2_A106BR_Lab_SpecimenSource = new String[] {""} ;
         H003I2_n106BR_Lab_SpecimenSource = new bool[] {false} ;
         H003I2_A263BR_Lab_Diag = new String[] {""} ;
         H003I2_n263BR_Lab_Diag = new bool[] {false} ;
         H003I2_A262BR_Lab_Age = new short[1] ;
         H003I2_n262BR_Lab_Age = new bool[] {false} ;
         H003I2_A261BR_Lab_TestEngName = new String[] {""} ;
         H003I2_n261BR_Lab_TestEngName = new bool[] {false} ;
         H003I2_A104BR_Lab_TestName = new String[] {""} ;
         H003I2_n104BR_Lab_TestName = new bool[] {false} ;
         AV6WWPContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPContext(context);
         AV9TrnContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext(context);
         AV12HTTPRequest = new GxHttpRequest( context);
         AV10TrnContextAtt = new GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext_Attribute(context);
         AV11Session = context.GetSession();
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         sCtrlA101BR_LabID = "";
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.br_labgeneral__default(),
            new Object[][] {
                new Object[] {
               H003I2_A101BR_LabID, H003I2_A224BR_Lab_SampleID, H003I2_n224BR_Lab_SampleID, H003I2_A102BR_Lab_TestID, H003I2_n102BR_Lab_TestID, H003I2_A110BR_Lab_ResultNum, H003I2_n110BR_Lab_ResultNum, H003I2_A117BR_Lab_InstrumentName, H003I2_n117BR_Lab_InstrumentName, H003I2_A118BR_Lab_InstrumentCode,
               H003I2_n118BR_Lab_InstrumentCode, H003I2_A115BR_Lab_TestMethod, H003I2_n115BR_Lab_TestMethod, H003I2_A113BR_Lab_NormRangeLow, H003I2_n113BR_Lab_NormRangeLow, H003I2_A112BR_Lab_AbnInd, H003I2_n112BR_Lab_AbnInd, H003I2_A111BR_Lab_ResultUnit, H003I2_n111BR_Lab_ResultUnit, H003I2_A109BR_Lab_ResultQual,
               H003I2_n109BR_Lab_ResultQual, H003I2_A265BR_Lab_ReportTime, H003I2_n265BR_Lab_ReportTime, H003I2_A264BR_Lab_ReceivingTime, H003I2_n264BR_Lab_ReceivingTime, H003I2_A105BR_Lab_SpecimenDate, H003I2_n105BR_Lab_SpecimenDate, H003I2_A106BR_Lab_SpecimenSource, H003I2_n106BR_Lab_SpecimenSource, H003I2_A263BR_Lab_Diag,
               H003I2_n263BR_Lab_Diag, H003I2_A262BR_Lab_Age, H003I2_n262BR_Lab_Age, H003I2_A261BR_Lab_TestEngName, H003I2_n261BR_Lab_TestEngName, H003I2_A104BR_Lab_TestName, H003I2_n104BR_Lab_TestName
               }
            }
         );
         AV16Pgmname = "BR_LabGeneral";
         /* GeneXus formulas. */
         AV16Pgmname = "BR_LabGeneral";
         context.Gx_err = 0;
      }

      private short nGotPars ;
      private short GxWebError ;
      private short nDynComponent ;
      private short initialized ;
      private short nGXWrapped ;
      private short wbEnd ;
      private short wbStart ;
      private short A262BR_Lab_Age ;
      private short nDraw ;
      private short nDoneStart ;
      private short nDonePA ;
      private short gxcookieaux ;
      private int edtBR_Lab_TestName_Enabled ;
      private int edtBR_Lab_TestEngName_Enabled ;
      private int edtBR_Lab_Age_Enabled ;
      private int edtBR_Lab_Diag_Enabled ;
      private int edtBR_Lab_SpecimenSource_Enabled ;
      private int edtBR_Lab_SpecimenDate_Enabled ;
      private int edtBR_Lab_ReceivingTime_Enabled ;
      private int edtBR_Lab_ReportTime_Enabled ;
      private int edtBR_Lab_ResultQual_Enabled ;
      private int edtBR_Lab_ResultUnit_Enabled ;
      private int edtBR_Lab_AbnInd_Enabled ;
      private int edtBR_Lab_NormRangeLow_Enabled ;
      private int edtBR_Lab_TestMethod_Enabled ;
      private int edtBR_Lab_InstrumentCode_Enabled ;
      private int edtBR_Lab_InstrumentName_Enabled ;
      private int edtBR_Lab_ResultNum_Enabled ;
      private int edtBR_LabID_Visible ;
      private int edtBR_Lab_TestID_Visible ;
      private int edtBR_Lab_SampleID_Visible ;
      private int idxLst ;
      private long A101BR_LabID ;
      private long wcpOA101BR_LabID ;
      private long A102BR_Lab_TestID ;
      private long AV8BR_LabID ;
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
      private String divUnnamedtablebr_lab_testname_Internalname ;
      private String lblTextblockbr_lab_testname_Internalname ;
      private String lblTextblockbr_lab_testname_Jsonclick ;
      private String edtBR_Lab_TestName_Internalname ;
      private String edtBR_Lab_TestName_Jsonclick ;
      private String divUnnamedtablebr_lab_testengname_Internalname ;
      private String lblTextblockbr_lab_testengname_Internalname ;
      private String lblTextblockbr_lab_testengname_Jsonclick ;
      private String edtBR_Lab_TestEngName_Internalname ;
      private String edtBR_Lab_TestEngName_Jsonclick ;
      private String divUnnamedtablebr_lab_age_Internalname ;
      private String lblTextblockbr_lab_age_Internalname ;
      private String lblTextblockbr_lab_age_Jsonclick ;
      private String edtBR_Lab_Age_Internalname ;
      private String edtBR_Lab_Age_Jsonclick ;
      private String divUnnamedtablebr_lab_diag_Internalname ;
      private String lblTextblockbr_lab_diag_Internalname ;
      private String lblTextblockbr_lab_diag_Jsonclick ;
      private String edtBR_Lab_Diag_Internalname ;
      private String edtBR_Lab_Diag_Jsonclick ;
      private String divUnnamedtablebr_lab_specimensource_Internalname ;
      private String lblTextblockbr_lab_specimensource_Internalname ;
      private String lblTextblockbr_lab_specimensource_Jsonclick ;
      private String edtBR_Lab_SpecimenSource_Internalname ;
      private String edtBR_Lab_SpecimenSource_Jsonclick ;
      private String divUnnamedtablebr_lab_specimendate_Internalname ;
      private String lblTextblockbr_lab_specimendate_Internalname ;
      private String lblTextblockbr_lab_specimendate_Jsonclick ;
      private String edtBR_Lab_SpecimenDate_Internalname ;
      private String edtBR_Lab_SpecimenDate_Jsonclick ;
      private String divUnnamedtablebr_lab_receivingtime_Internalname ;
      private String lblTextblockbr_lab_receivingtime_Internalname ;
      private String lblTextblockbr_lab_receivingtime_Jsonclick ;
      private String edtBR_Lab_ReceivingTime_Internalname ;
      private String edtBR_Lab_ReceivingTime_Jsonclick ;
      private String divUnnamedtablebr_lab_reporttime_Internalname ;
      private String lblTextblockbr_lab_reporttime_Internalname ;
      private String lblTextblockbr_lab_reporttime_Jsonclick ;
      private String edtBR_Lab_ReportTime_Internalname ;
      private String edtBR_Lab_ReportTime_Jsonclick ;
      private String divUnnamedtablebr_lab_resultqual_Internalname ;
      private String lblTextblockbr_lab_resultqual_Internalname ;
      private String lblTextblockbr_lab_resultqual_Jsonclick ;
      private String edtBR_Lab_ResultQual_Internalname ;
      private String ClassString ;
      private String StyleString ;
      private String divUnnamedtablebr_lab_resultunit_Internalname ;
      private String lblTextblockbr_lab_resultunit_Internalname ;
      private String lblTextblockbr_lab_resultunit_Jsonclick ;
      private String edtBR_Lab_ResultUnit_Internalname ;
      private String edtBR_Lab_ResultUnit_Jsonclick ;
      private String divUnnamedtablebr_lab_abnind_Internalname ;
      private String lblTextblockbr_lab_abnind_Internalname ;
      private String lblTextblockbr_lab_abnind_Jsonclick ;
      private String edtBR_Lab_AbnInd_Internalname ;
      private String edtBR_Lab_AbnInd_Jsonclick ;
      private String divUnnamedtablebr_lab_normrangelow_Internalname ;
      private String lblTextblockbr_lab_normrangelow_Internalname ;
      private String lblTextblockbr_lab_normrangelow_Jsonclick ;
      private String edtBR_Lab_NormRangeLow_Internalname ;
      private String edtBR_Lab_NormRangeLow_Jsonclick ;
      private String divUnnamedtablebr_lab_testmethod_Internalname ;
      private String lblTextblockbr_lab_testmethod_Internalname ;
      private String lblTextblockbr_lab_testmethod_Jsonclick ;
      private String edtBR_Lab_TestMethod_Internalname ;
      private String edtBR_Lab_TestMethod_Jsonclick ;
      private String divUnnamedtablebr_lab_instrumentcode_Internalname ;
      private String lblTextblockbr_lab_instrumentcode_Internalname ;
      private String lblTextblockbr_lab_instrumentcode_Jsonclick ;
      private String edtBR_Lab_InstrumentCode_Internalname ;
      private String edtBR_Lab_InstrumentCode_Jsonclick ;
      private String divUnnamedtablebr_lab_instrumentname_Internalname ;
      private String lblTextblockbr_lab_instrumentname_Internalname ;
      private String lblTextblockbr_lab_instrumentname_Jsonclick ;
      private String edtBR_Lab_InstrumentName_Internalname ;
      private String divUnnamedtablebr_lab_resultnum_Internalname ;
      private String lblTextblockbr_lab_resultnum_Internalname ;
      private String lblTextblockbr_lab_resultnum_Jsonclick ;
      private String edtBR_Lab_ResultNum_Internalname ;
      private String divHtml_bottomauxiliarcontrols_Internalname ;
      private String edtBR_LabID_Internalname ;
      private String edtBR_LabID_Jsonclick ;
      private String edtBR_Lab_TestID_Internalname ;
      private String edtBR_Lab_TestID_Jsonclick ;
      private String edtBR_Lab_SampleID_Internalname ;
      private String edtBR_Lab_SampleID_Jsonclick ;
      private String sXEvt ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String scmdbuf ;
      private String sCtrlA101BR_LabID ;
      private DateTime A105BR_Lab_SpecimenDate ;
      private DateTime A264BR_Lab_ReceivingTime ;
      private DateTime A265BR_Lab_ReportTime ;
      private bool entryPointCalled ;
      private bool toggleJsOutput ;
      private bool wbLoad ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool gxdyncontrolsrefreshing ;
      private bool n224BR_Lab_SampleID ;
      private bool n102BR_Lab_TestID ;
      private bool n110BR_Lab_ResultNum ;
      private bool n117BR_Lab_InstrumentName ;
      private bool n118BR_Lab_InstrumentCode ;
      private bool n115BR_Lab_TestMethod ;
      private bool n113BR_Lab_NormRangeLow ;
      private bool n112BR_Lab_AbnInd ;
      private bool n111BR_Lab_ResultUnit ;
      private bool n109BR_Lab_ResultQual ;
      private bool n265BR_Lab_ReportTime ;
      private bool n264BR_Lab_ReceivingTime ;
      private bool n105BR_Lab_SpecimenDate ;
      private bool n106BR_Lab_SpecimenSource ;
      private bool n263BR_Lab_Diag ;
      private bool n262BR_Lab_Age ;
      private bool n261BR_Lab_TestEngName ;
      private bool n104BR_Lab_TestName ;
      private bool returnInSub ;
      private String A104BR_Lab_TestName ;
      private String A261BR_Lab_TestEngName ;
      private String A263BR_Lab_Diag ;
      private String A106BR_Lab_SpecimenSource ;
      private String A109BR_Lab_ResultQual ;
      private String A111BR_Lab_ResultUnit ;
      private String A112BR_Lab_AbnInd ;
      private String A113BR_Lab_NormRangeLow ;
      private String A115BR_Lab_TestMethod ;
      private String A118BR_Lab_InstrumentCode ;
      private String A117BR_Lab_InstrumentName ;
      private String A110BR_Lab_ResultNum ;
      private String A224BR_Lab_SampleID ;
      private GXWebForm Form ;
      private IGxDataStore dsDataStore1 ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private long[] H003I2_A101BR_LabID ;
      private String[] H003I2_A224BR_Lab_SampleID ;
      private bool[] H003I2_n224BR_Lab_SampleID ;
      private long[] H003I2_A102BR_Lab_TestID ;
      private bool[] H003I2_n102BR_Lab_TestID ;
      private String[] H003I2_A110BR_Lab_ResultNum ;
      private bool[] H003I2_n110BR_Lab_ResultNum ;
      private String[] H003I2_A117BR_Lab_InstrumentName ;
      private bool[] H003I2_n117BR_Lab_InstrumentName ;
      private String[] H003I2_A118BR_Lab_InstrumentCode ;
      private bool[] H003I2_n118BR_Lab_InstrumentCode ;
      private String[] H003I2_A115BR_Lab_TestMethod ;
      private bool[] H003I2_n115BR_Lab_TestMethod ;
      private String[] H003I2_A113BR_Lab_NormRangeLow ;
      private bool[] H003I2_n113BR_Lab_NormRangeLow ;
      private String[] H003I2_A112BR_Lab_AbnInd ;
      private bool[] H003I2_n112BR_Lab_AbnInd ;
      private String[] H003I2_A111BR_Lab_ResultUnit ;
      private bool[] H003I2_n111BR_Lab_ResultUnit ;
      private String[] H003I2_A109BR_Lab_ResultQual ;
      private bool[] H003I2_n109BR_Lab_ResultQual ;
      private DateTime[] H003I2_A265BR_Lab_ReportTime ;
      private bool[] H003I2_n265BR_Lab_ReportTime ;
      private DateTime[] H003I2_A264BR_Lab_ReceivingTime ;
      private bool[] H003I2_n264BR_Lab_ReceivingTime ;
      private DateTime[] H003I2_A105BR_Lab_SpecimenDate ;
      private bool[] H003I2_n105BR_Lab_SpecimenDate ;
      private String[] H003I2_A106BR_Lab_SpecimenSource ;
      private bool[] H003I2_n106BR_Lab_SpecimenSource ;
      private String[] H003I2_A263BR_Lab_Diag ;
      private bool[] H003I2_n263BR_Lab_Diag ;
      private short[] H003I2_A262BR_Lab_Age ;
      private bool[] H003I2_n262BR_Lab_Age ;
      private String[] H003I2_A261BR_Lab_TestEngName ;
      private bool[] H003I2_n261BR_Lab_TestEngName ;
      private String[] H003I2_A104BR_Lab_TestName ;
      private bool[] H003I2_n104BR_Lab_TestName ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private GxHttpRequest AV12HTTPRequest ;
      private IGxSession AV11Session ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPContext AV6WWPContext ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext AV9TrnContext ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext_Attribute AV10TrnContextAtt ;
   }

   public class br_labgeneral__default : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmH003I2 ;
          prmH003I2 = new Object[] {
          new Object[] {"@BR_LabID",SqlDbType.Decimal,18,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("H003I2", "SELECT [BR_LabID], [BR_Lab_SampleID], [BR_Lab_TestID], [BR_Lab_ResultNum], [BR_Lab_InstrumentName], [BR_Lab_InstrumentCode], [BR_Lab_TestMethod], [BR_Lab_NormRangeLow], [BR_Lab_AbnInd], [BR_Lab_ResultUnit], [BR_Lab_ResultQual], [BR_Lab_ReportTime], [BR_Lab_ReceivingTime], [BR_Lab_SpecimenDate], [BR_Lab_SpecimenSource], [BR_Lab_Diag], [BR_Lab_Age], [BR_Lab_TestEngName], [BR_Lab_TestName] FROM [BR_Lab] WITH (NOLOCK) WHERE [BR_LabID] = @BR_LabID ORDER BY [BR_LabID] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH003I2,1,0,true,true )
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
                ((String[]) buf[19])[0] = rslt.getVarchar(11) ;
                ((bool[]) buf[20])[0] = rslt.wasNull(11);
                ((DateTime[]) buf[21])[0] = rslt.getGXDateTime(12) ;
                ((bool[]) buf[22])[0] = rslt.wasNull(12);
                ((DateTime[]) buf[23])[0] = rslt.getGXDateTime(13) ;
                ((bool[]) buf[24])[0] = rslt.wasNull(13);
                ((DateTime[]) buf[25])[0] = rslt.getGXDateTime(14) ;
                ((bool[]) buf[26])[0] = rslt.wasNull(14);
                ((String[]) buf[27])[0] = rslt.getVarchar(15) ;
                ((bool[]) buf[28])[0] = rslt.wasNull(15);
                ((String[]) buf[29])[0] = rslt.getVarchar(16) ;
                ((bool[]) buf[30])[0] = rslt.wasNull(16);
                ((short[]) buf[31])[0] = rslt.getShort(17) ;
                ((bool[]) buf[32])[0] = rslt.wasNull(17);
                ((String[]) buf[33])[0] = rslt.getVarchar(18) ;
                ((bool[]) buf[34])[0] = rslt.wasNull(18);
                ((String[]) buf[35])[0] = rslt.getVarchar(19) ;
                ((bool[]) buf[36])[0] = rslt.wasNull(19);
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
