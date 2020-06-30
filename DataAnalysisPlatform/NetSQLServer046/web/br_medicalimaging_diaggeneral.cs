/*
               File: BR_MedicalImaging_DiagGeneral
        Description: BR_Medical Imaging_Diag General
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/27/2020 11:54:22.77
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
   public class br_medicalimaging_diaggeneral : GXWebComponent, System.Web.SessionState.IRequiresSessionState
   {
      public br_medicalimaging_diaggeneral( )
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

      public br_medicalimaging_diaggeneral( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( long aP0_BR_MedicalImaging_DiagID )
      {
         this.A270BR_MedicalImaging_DiagID = aP0_BR_MedicalImaging_DiagID;
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
                  A270BR_MedicalImaging_DiagID = (long)(NumberUtil.Val( GetNextPar( ), "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A270BR_MedicalImaging_DiagID", StringUtil.LTrim( StringUtil.Str( (decimal)(A270BR_MedicalImaging_DiagID), 18, 0)));
                  setjustcreated();
                  componentprepare(new Object[] {(String)sCompPrefix,(String)sSFPrefix,(long)A270BR_MedicalImaging_DiagID});
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
            PA4Q2( ) ;
            if ( ( GxWebError == 0 ) && ! isAjaxCallMode( ) )
            {
               /* GeneXus formulas. */
               AV16Pgmname = "BR_MedicalImaging_DiagGeneral";
               context.Gx_err = 0;
               WS4Q2( ) ;
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
            context.SendWebValue( "BR_Medical Imaging_Diag General") ;
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
         context.AddJavascriptSource("gxcfg.js", "?202022711542282", false);
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
               context.WriteHtmlTextNl( "<form id=\"MAINFORM\" autocomplete=\"off\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("br_medicalimaging_diaggeneral.aspx") + "?" + UrlEncode("" +A270BR_MedicalImaging_DiagID)+"\">") ;
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
         GxWebStd.gx_hidden_field( context, sPrefix+"wcpOA270BR_MedicalImaging_DiagID", StringUtil.LTrim( StringUtil.NToC( (decimal)(wcpOA270BR_MedicalImaging_DiagID), 18, 0, ".", "")));
      }

      protected void RenderHtmlCloseForm4Q2( )
      {
         SendCloseFormHiddens( ) ;
         if ( ( StringUtil.Len( sPrefix) != 0 ) && ( context.isAjaxRequest( ) || context.isSpaRequest( ) ) )
         {
            context.AddJavascriptSource("br_medicalimaging_diaggeneral.js", "?202022711542284", false);
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
         return "BR_MedicalImaging_DiagGeneral" ;
      }

      public override String GetPgmdesc( )
      {
         return "BR_Medical Imaging_Diag General" ;
      }

      protected void WB4Q0( )
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
               GxWebStd.gx_hidden_field( context, sPrefix+"_CMPPGM", "br_medicalimaging_diaggeneral.aspx");
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
            GxWebStd.gx_div_start( context, divUnnamedtablebr_medicalimaging_diag_no_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-4 MergeLabelCell", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblockbr_medicalimaging_diag_no_Internalname, "序号", "", "", lblTextblockbr_medicalimaging_diag_no_Jsonclick, "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_BR_MedicalImaging_DiagGeneral.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-8", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtBR_MedicalImaging_Diag_No_Internalname, "序号", "col-sm-3 ReadonlyAttributeLabel", 0, true);
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtBR_MedicalImaging_Diag_No_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A517BR_MedicalImaging_Diag_No), 18, 0, ".", "")), ((edtBR_MedicalImaging_Diag_No_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A517BR_MedicalImaging_Diag_No), "ZZZZZZZZZZZZZZZZZZ")) : context.localUtil.Format( (decimal)(A517BR_MedicalImaging_Diag_No), "ZZZZZZZZZZZZZZZZZZ")), "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBR_MedicalImaging_Diag_No_Jsonclick, 0, "ReadonlyAttribute", "", "", "", "", 1, edtBR_MedicalImaging_Diag_No_Enabled, 0, "number", "1", 18, "chr", 1, "row", 18, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_BR_MedicalImaging_DiagGeneral.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-md-6 DataContentCellNoWrap", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divUnnamedtablebr_medicalimaging_diag_loc_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-4 MergeLabelCell", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblockbr_medicalimaging_diag_loc_Internalname, "诊断意见(部位)", "", "", lblTextblockbr_medicalimaging_diag_loc_Jsonclick, "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_BR_MedicalImaging_DiagGeneral.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-8", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtBR_MedicalImaging_Diag_Loc_Internalname, "诊断意见(部位)", "col-sm-3 AttributeReadGrayLabel", 0, true);
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtBR_MedicalImaging_Diag_Loc_Internalname, A271BR_MedicalImaging_Diag_Loc, StringUtil.RTrim( context.localUtil.Format( A271BR_MedicalImaging_Diag_Loc, "")), "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBR_MedicalImaging_Diag_Loc_Jsonclick, 0, "AttributeReadGray", "", "", "", "", 1, edtBR_MedicalImaging_Diag_Loc_Enabled, 0, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_BR_MedicalImaging_DiagGeneral.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-md-6 DataContentCellNoWrap", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divUnnamedtablebr_medicalimaging_diag_organ_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-4 MergeLabelCell", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblockbr_medicalimaging_diag_organ_Internalname, "诊断意见(器官)", "", "", lblTextblockbr_medicalimaging_diag_organ_Jsonclick, "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_BR_MedicalImaging_DiagGeneral.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-8", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtBR_MedicalImaging_Diag_Organ_Internalname, "诊断意见(器官)", "col-sm-3 AttributeReadGrayLabel", 0, true);
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtBR_MedicalImaging_Diag_Organ_Internalname, A272BR_MedicalImaging_Diag_Organ, StringUtil.RTrim( context.localUtil.Format( A272BR_MedicalImaging_Diag_Organ, "")), "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBR_MedicalImaging_Diag_Organ_Jsonclick, 0, "AttributeReadGray", "", "", "", "", 1, edtBR_MedicalImaging_Diag_Organ_Enabled, 0, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_BR_MedicalImaging_DiagGeneral.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-md-6 DataContentCellNoWrap", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divUnnamedtablebr_medicalimaging_diag_dis_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-4 MergeLabelCell", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblockbr_medicalimaging_diag_dis_Internalname, "诊断意见(疾病)", "", "", lblTextblockbr_medicalimaging_diag_dis_Jsonclick, "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_BR_MedicalImaging_DiagGeneral.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-8", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtBR_MedicalImaging_Diag_Dis_Internalname, "诊断意见(疾病)", "col-sm-3 AttributeReadGrayLabel", 0, true);
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtBR_MedicalImaging_Diag_Dis_Internalname, A273BR_MedicalImaging_Diag_Dis, StringUtil.RTrim( context.localUtil.Format( A273BR_MedicalImaging_Diag_Dis, "")), "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBR_MedicalImaging_Diag_Dis_Jsonclick, 0, "AttributeReadGray", "", "", "", "", 1, edtBR_MedicalImaging_Diag_Dis_Enabled, 0, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_BR_MedicalImaging_DiagGeneral.htm");
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
            GxWebStd.gx_single_line_edit( context, edtBR_MedicalImaging_DiagID_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A270BR_MedicalImaging_DiagID), 18, 0, ".", "")), context.localUtil.Format( (decimal)(A270BR_MedicalImaging_DiagID), "ZZZZZZZZZZZZZZZZZZ"), "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBR_MedicalImaging_DiagID_Jsonclick, 0, "Attribute", "", "", "", "", edtBR_MedicalImaging_DiagID_Visible, 0, 0, "number", "1", 18, "chr", 1, "row", 18, 0, 0, 0, 1, -1, 0, true, "ID", "right", false, "HLP_BR_MedicalImaging_DiagGeneral.htm");
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtBR_MedicalImagingID_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A225BR_MedicalImagingID), 18, 0, ".", "")), context.localUtil.Format( (decimal)(A225BR_MedicalImagingID), "ZZZZZZZZZZZZZZZZZZ"), "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBR_MedicalImagingID_Jsonclick, 0, "Attribute", "", "", "", "", edtBR_MedicalImagingID_Visible, 0, 0, "number", "1", 18, "chr", 1, "row", 18, 0, 0, 0, 1, -1, 0, true, "ID", "right", false, "HLP_BR_MedicalImaging_DiagGeneral.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
         }
         wbLoad = true;
      }

      protected void START4Q2( )
      {
         wbLoad = false;
         wbEnd = 0;
         wbStart = 0;
         if ( StringUtil.Len( sPrefix) == 0 )
         {
            if ( ! context.isSpaRequest( ) )
            {
               Form.Meta.addItem("generator", "GeneXus C# 16_0_0-127771", 0) ;
               Form.Meta.addItem("description", "BR_Medical Imaging_Diag General", 0) ;
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
               STRUP4Q0( ) ;
            }
         }
      }

      protected void WS4Q2( )
      {
         START4Q2( ) ;
         EVT4Q2( ) ;
      }

      protected void EVT4Q2( )
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
                                 STRUP4Q0( ) ;
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
                                 STRUP4Q0( ) ;
                              }
                              if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
                              {
                                 context.wbHandled = 1;
                                 if ( ! wbErr )
                                 {
                                    dynload_actions( ) ;
                                    /* Execute user event: Start */
                                    E114Q2 ();
                                 }
                              }
                           }
                           else if ( StringUtil.StrCmp(sEvt, "LOAD") == 0 )
                           {
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP4Q0( ) ;
                              }
                              if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
                              {
                                 context.wbHandled = 1;
                                 if ( ! wbErr )
                                 {
                                    dynload_actions( ) ;
                                    /* Execute user event: Load */
                                    E124Q2 ();
                                 }
                              }
                           }
                           else if ( StringUtil.StrCmp(sEvt, "ENTER") == 0 )
                           {
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP4Q0( ) ;
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
                                 STRUP4Q0( ) ;
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

      protected void WE4Q2( )
      {
         if ( ! GxWebStd.gx_redirect( context) )
         {
            Rfr0gs = true;
            Refresh( ) ;
            if ( ! GxWebStd.gx_redirect( context) )
            {
               RenderHtmlCloseForm4Q2( ) ;
            }
         }
      }

      protected void PA4Q2( )
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
         RF4Q2( ) ;
         if ( isFullAjaxMode( ) )
         {
            send_integrity_footer_hashes( ) ;
         }
      }

      protected void initialize_formulas( )
      {
         /* GeneXus formulas. */
         AV16Pgmname = "BR_MedicalImaging_DiagGeneral";
         context.Gx_err = 0;
      }

      protected void RF4Q2( )
      {
         initialize_formulas( ) ;
         clear_multi_value_controls( ) ;
         gxdyncontrolsrefreshing = true;
         fix_multi_value_controls( ) ;
         gxdyncontrolsrefreshing = false;
         if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
         {
            /* Using cursor H004Q2 */
            pr_default.execute(0, new Object[] {A270BR_MedicalImaging_DiagID});
            while ( (pr_default.getStatus(0) != 101) )
            {
               A225BR_MedicalImagingID = H004Q2_A225BR_MedicalImagingID[0];
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A225BR_MedicalImagingID", StringUtil.LTrim( StringUtil.Str( (decimal)(A225BR_MedicalImagingID), 18, 0)));
               n225BR_MedicalImagingID = H004Q2_n225BR_MedicalImagingID[0];
               A273BR_MedicalImaging_Diag_Dis = H004Q2_A273BR_MedicalImaging_Diag_Dis[0];
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A273BR_MedicalImaging_Diag_Dis", A273BR_MedicalImaging_Diag_Dis);
               n273BR_MedicalImaging_Diag_Dis = H004Q2_n273BR_MedicalImaging_Diag_Dis[0];
               A272BR_MedicalImaging_Diag_Organ = H004Q2_A272BR_MedicalImaging_Diag_Organ[0];
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A272BR_MedicalImaging_Diag_Organ", A272BR_MedicalImaging_Diag_Organ);
               n272BR_MedicalImaging_Diag_Organ = H004Q2_n272BR_MedicalImaging_Diag_Organ[0];
               A271BR_MedicalImaging_Diag_Loc = H004Q2_A271BR_MedicalImaging_Diag_Loc[0];
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A271BR_MedicalImaging_Diag_Loc", A271BR_MedicalImaging_Diag_Loc);
               n271BR_MedicalImaging_Diag_Loc = H004Q2_n271BR_MedicalImaging_Diag_Loc[0];
               A517BR_MedicalImaging_Diag_No = H004Q2_A517BR_MedicalImaging_Diag_No[0];
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A517BR_MedicalImaging_Diag_No", StringUtil.LTrim( StringUtil.Str( (decimal)(A517BR_MedicalImaging_Diag_No), 18, 0)));
               n517BR_MedicalImaging_Diag_No = H004Q2_n517BR_MedicalImaging_Diag_No[0];
               /* Execute user event: Load */
               E124Q2 ();
               /* Exiting from a For First loop. */
               if (true) break;
            }
            pr_default.close(0);
            WB4Q0( ) ;
         }
      }

      protected void send_integrity_lvl_hashes4Q2( )
      {
      }

      protected void STRUP4Q0( )
      {
         /* Before Start, stand alone formulas. */
         AV16Pgmname = "BR_MedicalImaging_DiagGeneral";
         context.Gx_err = 0;
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0;
         /* Execute user event: Start */
         E114Q2 ();
         context.wbGlbDoneStart = 1;
         nDoneStart = 1;
         /* After Start, stand alone formulas. */
         sXEvt = cgiGet( "_EventName");
         if ( ! GetJustCreated( ) && ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 ) )
         {
            /* Read saved SDTs. */
            /* Read variables values. */
            A517BR_MedicalImaging_Diag_No = (long)(context.localUtil.CToN( cgiGet( edtBR_MedicalImaging_Diag_No_Internalname), ".", ","));
            n517BR_MedicalImaging_Diag_No = false;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A517BR_MedicalImaging_Diag_No", StringUtil.LTrim( StringUtil.Str( (decimal)(A517BR_MedicalImaging_Diag_No), 18, 0)));
            A271BR_MedicalImaging_Diag_Loc = cgiGet( edtBR_MedicalImaging_Diag_Loc_Internalname);
            n271BR_MedicalImaging_Diag_Loc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A271BR_MedicalImaging_Diag_Loc", A271BR_MedicalImaging_Diag_Loc);
            A272BR_MedicalImaging_Diag_Organ = cgiGet( edtBR_MedicalImaging_Diag_Organ_Internalname);
            n272BR_MedicalImaging_Diag_Organ = false;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A272BR_MedicalImaging_Diag_Organ", A272BR_MedicalImaging_Diag_Organ);
            A273BR_MedicalImaging_Diag_Dis = cgiGet( edtBR_MedicalImaging_Diag_Dis_Internalname);
            n273BR_MedicalImaging_Diag_Dis = false;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A273BR_MedicalImaging_Diag_Dis", A273BR_MedicalImaging_Diag_Dis);
            A225BR_MedicalImagingID = (long)(context.localUtil.CToN( cgiGet( edtBR_MedicalImagingID_Internalname), ".", ","));
            n225BR_MedicalImagingID = false;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A225BR_MedicalImagingID", StringUtil.LTrim( StringUtil.Str( (decimal)(A225BR_MedicalImagingID), 18, 0)));
            /* Read saved values. */
            wcpOA270BR_MedicalImaging_DiagID = (long)(context.localUtil.CToN( cgiGet( sPrefix+"wcpOA270BR_MedicalImaging_DiagID"), ".", ","));
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
         E114Q2 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E114Q2( )
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

      protected void E124Q2( )
      {
         /* Load Routine */
         edtBR_MedicalImaging_DiagID_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtBR_MedicalImaging_DiagID_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBR_MedicalImaging_DiagID_Visible), 5, 0)), true);
         edtBR_MedicalImagingID_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtBR_MedicalImagingID_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBR_MedicalImagingID_Visible), 5, 0)), true);
      }

      protected void S112( )
      {
         /* 'PREPARETRANSACTION' Routine */
         AV9TrnContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext(context);
         AV9TrnContext.gxTpr_Callerobject = AV16Pgmname;
         AV9TrnContext.gxTpr_Callerondelete = false;
         AV9TrnContext.gxTpr_Callerurl = AV12HTTPRequest.ScriptName+"?"+AV12HTTPRequest.QueryString;
         AV9TrnContext.gxTpr_Transactionname = "BR_MedicalImaging_Diag";
         AV10TrnContextAtt = new GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext_Attribute(context);
         AV10TrnContextAtt.gxTpr_Attributename = "BR_MedicalImaging_DiagID";
         AV10TrnContextAtt.gxTpr_Attributevalue = StringUtil.Str( (decimal)(AV8BR_MedicalImaging_DiagID), 18, 0);
         AV9TrnContext.gxTpr_Attributes.Add(AV10TrnContextAtt, 0);
         AV11Session.Set("TrnContext", AV9TrnContext.ToXml(false, true, "WWPTransactionContext", "DataAnalysisPlatform"));
      }

      public override void setparameters( Object[] obj )
      {
         createObjects();
         initialize();
         A270BR_MedicalImaging_DiagID = Convert.ToInt64(getParm(obj,0));
         context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A270BR_MedicalImaging_DiagID", StringUtil.LTrim( StringUtil.Str( (decimal)(A270BR_MedicalImaging_DiagID), 18, 0)));
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
         PA4Q2( ) ;
         WS4Q2( ) ;
         WE4Q2( ) ;
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
         sCtrlA270BR_MedicalImaging_DiagID = (String)((String)getParm(obj,0));
      }

      public override void componentrestorestate( String sPPrefix ,
                                                  String sPSFPrefix )
      {
         sPrefix = sPPrefix + sPSFPrefix;
         PA4Q2( ) ;
         WCParametersGet( ) ;
      }

      public override void componentprepare( Object[] obj )
      {
         wbLoad = false;
         sCompPrefix = (String)getParm(obj,0);
         sSFPrefix = (String)getParm(obj,1);
         sPrefix = sCompPrefix + sSFPrefix;
         AddComponentObject(sPrefix, "br_medicalimaging_diaggeneral", GetJustCreated( ));
         if ( ( nDoneStart == 0 ) && ( nDynComponent == 0 ) )
         {
            INITWEB( ) ;
         }
         else
         {
            init_default_properties( ) ;
            init_web_controls( ) ;
         }
         PA4Q2( ) ;
         if ( ! GetJustCreated( ) && ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 ) && ( context.wbGlbDoneStart == 0 ) )
         {
            WCParametersGet( ) ;
         }
         else
         {
            A270BR_MedicalImaging_DiagID = Convert.ToInt64(getParm(obj,2));
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A270BR_MedicalImaging_DiagID", StringUtil.LTrim( StringUtil.Str( (decimal)(A270BR_MedicalImaging_DiagID), 18, 0)));
         }
         wcpOA270BR_MedicalImaging_DiagID = (long)(context.localUtil.CToN( cgiGet( sPrefix+"wcpOA270BR_MedicalImaging_DiagID"), ".", ","));
         if ( ! GetJustCreated( ) && ( ( A270BR_MedicalImaging_DiagID != wcpOA270BR_MedicalImaging_DiagID ) ) )
         {
            setjustcreated();
         }
         wcpOA270BR_MedicalImaging_DiagID = A270BR_MedicalImaging_DiagID;
      }

      protected void WCParametersGet( )
      {
         /* Read Component Parameters. */
         sCtrlA270BR_MedicalImaging_DiagID = cgiGet( sPrefix+"A270BR_MedicalImaging_DiagID_CTRL");
         if ( StringUtil.Len( sCtrlA270BR_MedicalImaging_DiagID) > 0 )
         {
            A270BR_MedicalImaging_DiagID = (long)(context.localUtil.CToN( cgiGet( sCtrlA270BR_MedicalImaging_DiagID), ".", ","));
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A270BR_MedicalImaging_DiagID", StringUtil.LTrim( StringUtil.Str( (decimal)(A270BR_MedicalImaging_DiagID), 18, 0)));
         }
         else
         {
            A270BR_MedicalImaging_DiagID = (long)(context.localUtil.CToN( cgiGet( sPrefix+"A270BR_MedicalImaging_DiagID_PARM"), ".", ","));
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
         PA4Q2( ) ;
         sEvt = sCompEvt;
         WCParametersGet( ) ;
         WS4Q2( ) ;
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
         WS4Q2( ) ;
         SaveComponentMsgList(sPrefix);
         context.GX_msglist = BackMsgLst;
      }

      protected void WCParametersSet( )
      {
         GxWebStd.gx_hidden_field( context, sPrefix+"A270BR_MedicalImaging_DiagID_PARM", StringUtil.LTrim( StringUtil.NToC( (decimal)(A270BR_MedicalImaging_DiagID), 18, 0, ".", "")));
         if ( StringUtil.Len( StringUtil.RTrim( sCtrlA270BR_MedicalImaging_DiagID)) > 0 )
         {
            GxWebStd.gx_hidden_field( context, sPrefix+"A270BR_MedicalImaging_DiagID_CTRL", StringUtil.RTrim( sCtrlA270BR_MedicalImaging_DiagID));
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
         WE4Q2( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?202022711542360", true);
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
            context.AddJavascriptSource("br_medicalimaging_diaggeneral.js", "?202022711542360", false);
         }
         /* End function include_jscripts */
      }

      protected void init_web_controls( )
      {
         /* End function init_web_controls */
      }

      protected void init_default_properties( )
      {
         lblTextblockbr_medicalimaging_diag_no_Internalname = sPrefix+"TEXTBLOCKBR_MEDICALIMAGING_DIAG_NO";
         edtBR_MedicalImaging_Diag_No_Internalname = sPrefix+"BR_MEDICALIMAGING_DIAG_NO";
         divUnnamedtablebr_medicalimaging_diag_no_Internalname = sPrefix+"UNNAMEDTABLEBR_MEDICALIMAGING_DIAG_NO";
         lblTextblockbr_medicalimaging_diag_loc_Internalname = sPrefix+"TEXTBLOCKBR_MEDICALIMAGING_DIAG_LOC";
         edtBR_MedicalImaging_Diag_Loc_Internalname = sPrefix+"BR_MEDICALIMAGING_DIAG_LOC";
         divUnnamedtablebr_medicalimaging_diag_loc_Internalname = sPrefix+"UNNAMEDTABLEBR_MEDICALIMAGING_DIAG_LOC";
         lblTextblockbr_medicalimaging_diag_organ_Internalname = sPrefix+"TEXTBLOCKBR_MEDICALIMAGING_DIAG_ORGAN";
         edtBR_MedicalImaging_Diag_Organ_Internalname = sPrefix+"BR_MEDICALIMAGING_DIAG_ORGAN";
         divUnnamedtablebr_medicalimaging_diag_organ_Internalname = sPrefix+"UNNAMEDTABLEBR_MEDICALIMAGING_DIAG_ORGAN";
         lblTextblockbr_medicalimaging_diag_dis_Internalname = sPrefix+"TEXTBLOCKBR_MEDICALIMAGING_DIAG_DIS";
         edtBR_MedicalImaging_Diag_Dis_Internalname = sPrefix+"BR_MEDICALIMAGING_DIAG_DIS";
         divUnnamedtablebr_medicalimaging_diag_dis_Internalname = sPrefix+"UNNAMEDTABLEBR_MEDICALIMAGING_DIAG_DIS";
         divTransactiondetail_tableattributes_Internalname = sPrefix+"TRANSACTIONDETAIL_TABLEATTRIBUTES";
         divTable_Internalname = sPrefix+"TABLE";
         edtBR_MedicalImaging_DiagID_Internalname = sPrefix+"BR_MEDICALIMAGING_DIAGID";
         edtBR_MedicalImagingID_Internalname = sPrefix+"BR_MEDICALIMAGINGID";
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
         edtBR_MedicalImagingID_Jsonclick = "";
         edtBR_MedicalImagingID_Visible = 1;
         edtBR_MedicalImaging_DiagID_Jsonclick = "";
         edtBR_MedicalImaging_DiagID_Visible = 1;
         edtBR_MedicalImaging_Diag_Dis_Jsonclick = "";
         edtBR_MedicalImaging_Diag_Dis_Enabled = 0;
         edtBR_MedicalImaging_Diag_Organ_Jsonclick = "";
         edtBR_MedicalImaging_Diag_Organ_Enabled = 0;
         edtBR_MedicalImaging_Diag_Loc_Jsonclick = "";
         edtBR_MedicalImaging_Diag_Loc_Enabled = 0;
         edtBR_MedicalImaging_Diag_No_Jsonclick = "";
         edtBR_MedicalImaging_Diag_No_Enabled = 0;
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
         lblTextblockbr_medicalimaging_diag_no_Jsonclick = "";
         lblTextblockbr_medicalimaging_diag_loc_Jsonclick = "";
         A271BR_MedicalImaging_Diag_Loc = "";
         lblTextblockbr_medicalimaging_diag_organ_Jsonclick = "";
         A272BR_MedicalImaging_Diag_Organ = "";
         lblTextblockbr_medicalimaging_diag_dis_Jsonclick = "";
         A273BR_MedicalImaging_Diag_Dis = "";
         Form = new GXWebForm();
         sXEvt = "";
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         scmdbuf = "";
         H004Q2_A270BR_MedicalImaging_DiagID = new long[1] ;
         H004Q2_A225BR_MedicalImagingID = new long[1] ;
         H004Q2_n225BR_MedicalImagingID = new bool[] {false} ;
         H004Q2_A273BR_MedicalImaging_Diag_Dis = new String[] {""} ;
         H004Q2_n273BR_MedicalImaging_Diag_Dis = new bool[] {false} ;
         H004Q2_A272BR_MedicalImaging_Diag_Organ = new String[] {""} ;
         H004Q2_n272BR_MedicalImaging_Diag_Organ = new bool[] {false} ;
         H004Q2_A271BR_MedicalImaging_Diag_Loc = new String[] {""} ;
         H004Q2_n271BR_MedicalImaging_Diag_Loc = new bool[] {false} ;
         H004Q2_A517BR_MedicalImaging_Diag_No = new long[1] ;
         H004Q2_n517BR_MedicalImaging_Diag_No = new bool[] {false} ;
         AV6WWPContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPContext(context);
         AV9TrnContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext(context);
         AV12HTTPRequest = new GxHttpRequest( context);
         AV10TrnContextAtt = new GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext_Attribute(context);
         AV11Session = context.GetSession();
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         sCtrlA270BR_MedicalImaging_DiagID = "";
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.br_medicalimaging_diaggeneral__default(),
            new Object[][] {
                new Object[] {
               H004Q2_A270BR_MedicalImaging_DiagID, H004Q2_A225BR_MedicalImagingID, H004Q2_n225BR_MedicalImagingID, H004Q2_A273BR_MedicalImaging_Diag_Dis, H004Q2_n273BR_MedicalImaging_Diag_Dis, H004Q2_A272BR_MedicalImaging_Diag_Organ, H004Q2_n272BR_MedicalImaging_Diag_Organ, H004Q2_A271BR_MedicalImaging_Diag_Loc, H004Q2_n271BR_MedicalImaging_Diag_Loc, H004Q2_A517BR_MedicalImaging_Diag_No,
               H004Q2_n517BR_MedicalImaging_Diag_No
               }
            }
         );
         AV16Pgmname = "BR_MedicalImaging_DiagGeneral";
         /* GeneXus formulas. */
         AV16Pgmname = "BR_MedicalImaging_DiagGeneral";
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
      private int edtBR_MedicalImaging_Diag_No_Enabled ;
      private int edtBR_MedicalImaging_Diag_Loc_Enabled ;
      private int edtBR_MedicalImaging_Diag_Organ_Enabled ;
      private int edtBR_MedicalImaging_Diag_Dis_Enabled ;
      private int edtBR_MedicalImaging_DiagID_Visible ;
      private int edtBR_MedicalImagingID_Visible ;
      private int idxLst ;
      private long A270BR_MedicalImaging_DiagID ;
      private long wcpOA270BR_MedicalImaging_DiagID ;
      private long A517BR_MedicalImaging_Diag_No ;
      private long A225BR_MedicalImagingID ;
      private long AV8BR_MedicalImaging_DiagID ;
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
      private String divUnnamedtablebr_medicalimaging_diag_no_Internalname ;
      private String lblTextblockbr_medicalimaging_diag_no_Internalname ;
      private String lblTextblockbr_medicalimaging_diag_no_Jsonclick ;
      private String edtBR_MedicalImaging_Diag_No_Internalname ;
      private String edtBR_MedicalImaging_Diag_No_Jsonclick ;
      private String divUnnamedtablebr_medicalimaging_diag_loc_Internalname ;
      private String lblTextblockbr_medicalimaging_diag_loc_Internalname ;
      private String lblTextblockbr_medicalimaging_diag_loc_Jsonclick ;
      private String edtBR_MedicalImaging_Diag_Loc_Internalname ;
      private String edtBR_MedicalImaging_Diag_Loc_Jsonclick ;
      private String divUnnamedtablebr_medicalimaging_diag_organ_Internalname ;
      private String lblTextblockbr_medicalimaging_diag_organ_Internalname ;
      private String lblTextblockbr_medicalimaging_diag_organ_Jsonclick ;
      private String edtBR_MedicalImaging_Diag_Organ_Internalname ;
      private String edtBR_MedicalImaging_Diag_Organ_Jsonclick ;
      private String divUnnamedtablebr_medicalimaging_diag_dis_Internalname ;
      private String lblTextblockbr_medicalimaging_diag_dis_Internalname ;
      private String lblTextblockbr_medicalimaging_diag_dis_Jsonclick ;
      private String edtBR_MedicalImaging_Diag_Dis_Internalname ;
      private String edtBR_MedicalImaging_Diag_Dis_Jsonclick ;
      private String divHtml_bottomauxiliarcontrols_Internalname ;
      private String edtBR_MedicalImaging_DiagID_Internalname ;
      private String edtBR_MedicalImaging_DiagID_Jsonclick ;
      private String edtBR_MedicalImagingID_Internalname ;
      private String edtBR_MedicalImagingID_Jsonclick ;
      private String sXEvt ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String scmdbuf ;
      private String sCtrlA270BR_MedicalImaging_DiagID ;
      private bool entryPointCalled ;
      private bool toggleJsOutput ;
      private bool wbLoad ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool gxdyncontrolsrefreshing ;
      private bool n225BR_MedicalImagingID ;
      private bool n273BR_MedicalImaging_Diag_Dis ;
      private bool n272BR_MedicalImaging_Diag_Organ ;
      private bool n271BR_MedicalImaging_Diag_Loc ;
      private bool n517BR_MedicalImaging_Diag_No ;
      private bool returnInSub ;
      private String A271BR_MedicalImaging_Diag_Loc ;
      private String A272BR_MedicalImaging_Diag_Organ ;
      private String A273BR_MedicalImaging_Diag_Dis ;
      private GXWebForm Form ;
      private IGxDataStore dsDataStore1 ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private long[] H004Q2_A270BR_MedicalImaging_DiagID ;
      private long[] H004Q2_A225BR_MedicalImagingID ;
      private bool[] H004Q2_n225BR_MedicalImagingID ;
      private String[] H004Q2_A273BR_MedicalImaging_Diag_Dis ;
      private bool[] H004Q2_n273BR_MedicalImaging_Diag_Dis ;
      private String[] H004Q2_A272BR_MedicalImaging_Diag_Organ ;
      private bool[] H004Q2_n272BR_MedicalImaging_Diag_Organ ;
      private String[] H004Q2_A271BR_MedicalImaging_Diag_Loc ;
      private bool[] H004Q2_n271BR_MedicalImaging_Diag_Loc ;
      private long[] H004Q2_A517BR_MedicalImaging_Diag_No ;
      private bool[] H004Q2_n517BR_MedicalImaging_Diag_No ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private GxHttpRequest AV12HTTPRequest ;
      private IGxSession AV11Session ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPContext AV6WWPContext ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext AV9TrnContext ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext_Attribute AV10TrnContextAtt ;
   }

   public class br_medicalimaging_diaggeneral__default : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmH004Q2 ;
          prmH004Q2 = new Object[] {
          new Object[] {"@BR_MedicalImaging_DiagID",SqlDbType.Decimal,18,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("H004Q2", "SELECT [BR_MedicalImaging_DiagID], [BR_MedicalImagingID], [BR_MedicalImaging_Diag_Dis], [BR_MedicalImaging_Diag_Organ], [BR_MedicalImaging_Diag_Loc], [BR_MedicalImaging_Diag_No] FROM [BR_MedicalImaging_Diag] WITH (NOLOCK) WHERE [BR_MedicalImaging_DiagID] = @BR_MedicalImaging_DiagID ORDER BY [BR_MedicalImaging_DiagID] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH004Q2,1,0,true,true )
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
                ((long[]) buf[9])[0] = rslt.getLong(6) ;
                ((bool[]) buf[10])[0] = rslt.wasNull(6);
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
