/*
               File: BR_Pathology_DiagGeneral
        Description: BR_Pathology_Diag General
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/28/2020 15:5:8.14
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
   public class br_pathology_diaggeneral : GXWebComponent, System.Web.SessionState.IRequiresSessionState
   {
      public br_pathology_diaggeneral( )
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

      public br_pathology_diaggeneral( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( long aP0_BR_Pathology_DiagID )
      {
         this.A276BR_Pathology_DiagID = aP0_BR_Pathology_DiagID;
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
                  A276BR_Pathology_DiagID = (long)(NumberUtil.Val( GetNextPar( ), "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A276BR_Pathology_DiagID", StringUtil.LTrim( StringUtil.Str( (decimal)(A276BR_Pathology_DiagID), 18, 0)));
                  setjustcreated();
                  componentprepare(new Object[] {(String)sCompPrefix,(String)sSFPrefix,(long)A276BR_Pathology_DiagID});
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
            PA592( ) ;
            if ( ( GxWebError == 0 ) && ! isAjaxCallMode( ) )
            {
               /* GeneXus formulas. */
               AV16Pgmname = "BR_Pathology_DiagGeneral";
               context.Gx_err = 0;
               WS592( ) ;
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
            context.SendWebValue( "BR_Pathology_Diag General") ;
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
         context.AddJavascriptSource("gxcfg.js", "?2020228155818", false);
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
               context.WriteHtmlTextNl( "<form id=\"MAINFORM\" autocomplete=\"off\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("br_pathology_diaggeneral.aspx") + "?" + UrlEncode("" +A276BR_Pathology_DiagID)+"\">") ;
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
         GxWebStd.gx_hidden_field( context, sPrefix+"wcpOA276BR_Pathology_DiagID", StringUtil.LTrim( StringUtil.NToC( (decimal)(wcpOA276BR_Pathology_DiagID), 18, 0, ".", "")));
      }

      protected void RenderHtmlCloseForm592( )
      {
         SendCloseFormHiddens( ) ;
         if ( ( StringUtil.Len( sPrefix) != 0 ) && ( context.isAjaxRequest( ) || context.isSpaRequest( ) ) )
         {
            context.AddJavascriptSource("br_pathology_diaggeneral.js", "?2020228155821", false);
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
         return "BR_Pathology_DiagGeneral" ;
      }

      public override String GetPgmdesc( )
      {
         return "BR_Pathology_Diag General" ;
      }

      protected void WB590( )
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
               GxWebStd.gx_hidden_field( context, sPrefix+"_CMPPGM", "br_pathology_diaggeneral.aspx");
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
            GxWebStd.gx_div_start( context, divUnnamedtablebr_pathology_diag_loc_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-4 MergeLabelCell", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblockbr_pathology_diag_loc_Internalname, "病理诊断(部位)", "", "", lblTextblockbr_pathology_diag_loc_Jsonclick, "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_BR_Pathology_DiagGeneral.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-8", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtBR_Pathology_Diag_Loc_Internalname, "病理诊断(部位)", "col-sm-3 ReadonlyAttributeLabel", 0, true);
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtBR_Pathology_Diag_Loc_Internalname, A277BR_Pathology_Diag_Loc, StringUtil.RTrim( context.localUtil.Format( A277BR_Pathology_Diag_Loc, "")), "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBR_Pathology_Diag_Loc_Jsonclick, 0, "ReadonlyAttribute", "", "", "", "", 1, edtBR_Pathology_Diag_Loc_Enabled, 0, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_BR_Pathology_DiagGeneral.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divUnnamedtablebr_pathology_diag_organ_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-4 MergeLabelCell", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblockbr_pathology_diag_organ_Internalname, "病理诊断(器官)", "", "", lblTextblockbr_pathology_diag_organ_Jsonclick, "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_BR_Pathology_DiagGeneral.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-8", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtBR_Pathology_Diag_Organ_Internalname, "病理诊断(器官)", "col-sm-3 ReadonlyAttributeLabel", 0, true);
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtBR_Pathology_Diag_Organ_Internalname, A278BR_Pathology_Diag_Organ, StringUtil.RTrim( context.localUtil.Format( A278BR_Pathology_Diag_Organ, "")), "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBR_Pathology_Diag_Organ_Jsonclick, 0, "ReadonlyAttribute", "", "", "", "", 1, edtBR_Pathology_Diag_Organ_Enabled, 0, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_BR_Pathology_DiagGeneral.htm");
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
            GxWebStd.gx_div_start( context, divUnnamedtablebr_pathology_diag_tumortype_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-4 MergeLabelCell", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblockbr_pathology_diag_tumortype_Internalname, "肿瘤类型", "", "", lblTextblockbr_pathology_diag_tumortype_Jsonclick, "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_BR_Pathology_DiagGeneral.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-8", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtBR_Pathology_Diag_TumorType_Internalname, "肿瘤类型", "col-sm-3 ReadonlyAttributeLabel", 0, true);
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtBR_Pathology_Diag_TumorType_Internalname, A279BR_Pathology_Diag_TumorType, StringUtil.RTrim( context.localUtil.Format( A279BR_Pathology_Diag_TumorType, "")), "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBR_Pathology_Diag_TumorType_Jsonclick, 0, "ReadonlyAttribute", "", "", "", "", 1, edtBR_Pathology_Diag_TumorType_Enabled, 0, "text", "", 40, "chr", 1, "row", 40, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_BR_Pathology_DiagGeneral.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divUnnamedtablebr_pathology_diag_tumorstage_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-4 MergeLabelCell", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblockbr_pathology_diag_tumorstage_Internalname, "肿瘤分期", "", "", lblTextblockbr_pathology_diag_tumorstage_Jsonclick, "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_BR_Pathology_DiagGeneral.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-8", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtBR_Pathology_Diag_TumorStage_Internalname, "肿瘤分期", "col-sm-3 ReadonlyAttributeLabel", 0, true);
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtBR_Pathology_Diag_TumorStage_Internalname, A280BR_Pathology_Diag_TumorStage, StringUtil.RTrim( context.localUtil.Format( A280BR_Pathology_Diag_TumorStage, "")), "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBR_Pathology_Diag_TumorStage_Jsonclick, 0, "ReadonlyAttribute", "", "", "", "", 1, edtBR_Pathology_Diag_TumorStage_Enabled, 0, "text", "", 40, "chr", 1, "row", 40, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_BR_Pathology_DiagGeneral.htm");
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
            GxWebStd.gx_div_start( context, divUnnamedtablebr_pathology_diag_tumorgrade_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-4 MergeLabelCell", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblockbr_pathology_diag_tumorgrade_Internalname, "肿瘤分级", "", "", lblTextblockbr_pathology_diag_tumorgrade_Jsonclick, "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_BR_Pathology_DiagGeneral.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-8", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtBR_Pathology_Diag_TumorGrade_Internalname, "肿瘤分级", "col-sm-3 ReadonlyAttributeLabel", 0, true);
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtBR_Pathology_Diag_TumorGrade_Internalname, A281BR_Pathology_Diag_TumorGrade, StringUtil.RTrim( context.localUtil.Format( A281BR_Pathology_Diag_TumorGrade, "")), "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBR_Pathology_Diag_TumorGrade_Jsonclick, 0, "ReadonlyAttribute", "", "", "", "", 1, edtBR_Pathology_Diag_TumorGrade_Enabled, 0, "text", "", 40, "chr", 1, "row", 40, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_BR_Pathology_DiagGeneral.htm");
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
            GxWebStd.gx_single_line_edit( context, edtBR_Pathology_DiagID_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A276BR_Pathology_DiagID), 18, 0, ".", "")), context.localUtil.Format( (decimal)(A276BR_Pathology_DiagID), "ZZZZZZZZZZZZZZZZZZ"), "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBR_Pathology_DiagID_Jsonclick, 0, "Attribute", "", "", "", "", edtBR_Pathology_DiagID_Visible, 0, 0, "number", "1", 18, "chr", 1, "row", 18, 0, 0, 0, 1, -1, 0, true, "ID", "right", false, "HLP_BR_Pathology_DiagGeneral.htm");
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtBR_PathologyID_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A226BR_PathologyID), 18, 0, ".", "")), context.localUtil.Format( (decimal)(A226BR_PathologyID), "ZZZZZZZZZZZZZZZZZZ"), "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBR_PathologyID_Jsonclick, 0, "Attribute", "", "", "", "", edtBR_PathologyID_Visible, 0, 0, "number", "1", 18, "chr", 1, "row", 18, 0, 0, 0, 1, -1, 0, true, "ID", "right", false, "HLP_BR_Pathology_DiagGeneral.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
         }
         wbLoad = true;
      }

      protected void START592( )
      {
         wbLoad = false;
         wbEnd = 0;
         wbStart = 0;
         if ( StringUtil.Len( sPrefix) == 0 )
         {
            if ( ! context.isSpaRequest( ) )
            {
               Form.Meta.addItem("generator", "GeneXus C# 16_0_0-127771", 0) ;
               Form.Meta.addItem("description", "BR_Pathology_Diag General", 0) ;
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
               STRUP590( ) ;
            }
         }
      }

      protected void WS592( )
      {
         START592( ) ;
         EVT592( ) ;
      }

      protected void EVT592( )
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
                                 STRUP590( ) ;
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
                                 STRUP590( ) ;
                              }
                              if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
                              {
                                 context.wbHandled = 1;
                                 if ( ! wbErr )
                                 {
                                    dynload_actions( ) ;
                                    /* Execute user event: Start */
                                    E11592 ();
                                 }
                              }
                           }
                           else if ( StringUtil.StrCmp(sEvt, "LOAD") == 0 )
                           {
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP590( ) ;
                              }
                              if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
                              {
                                 context.wbHandled = 1;
                                 if ( ! wbErr )
                                 {
                                    dynload_actions( ) ;
                                    /* Execute user event: Load */
                                    E12592 ();
                                 }
                              }
                           }
                           else if ( StringUtil.StrCmp(sEvt, "ENTER") == 0 )
                           {
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP590( ) ;
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
                                 STRUP590( ) ;
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

      protected void WE592( )
      {
         if ( ! GxWebStd.gx_redirect( context) )
         {
            Rfr0gs = true;
            Refresh( ) ;
            if ( ! GxWebStd.gx_redirect( context) )
            {
               RenderHtmlCloseForm592( ) ;
            }
         }
      }

      protected void PA592( )
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
         RF592( ) ;
         if ( isFullAjaxMode( ) )
         {
            send_integrity_footer_hashes( ) ;
         }
      }

      protected void initialize_formulas( )
      {
         /* GeneXus formulas. */
         AV16Pgmname = "BR_Pathology_DiagGeneral";
         context.Gx_err = 0;
      }

      protected void RF592( )
      {
         initialize_formulas( ) ;
         clear_multi_value_controls( ) ;
         gxdyncontrolsrefreshing = true;
         fix_multi_value_controls( ) ;
         gxdyncontrolsrefreshing = false;
         if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
         {
            /* Using cursor H00592 */
            pr_default.execute(0, new Object[] {A276BR_Pathology_DiagID});
            while ( (pr_default.getStatus(0) != 101) )
            {
               A226BR_PathologyID = H00592_A226BR_PathologyID[0];
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A226BR_PathologyID", StringUtil.LTrim( StringUtil.Str( (decimal)(A226BR_PathologyID), 18, 0)));
               n226BR_PathologyID = H00592_n226BR_PathologyID[0];
               A281BR_Pathology_Diag_TumorGrade = H00592_A281BR_Pathology_Diag_TumorGrade[0];
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A281BR_Pathology_Diag_TumorGrade", A281BR_Pathology_Diag_TumorGrade);
               n281BR_Pathology_Diag_TumorGrade = H00592_n281BR_Pathology_Diag_TumorGrade[0];
               A280BR_Pathology_Diag_TumorStage = H00592_A280BR_Pathology_Diag_TumorStage[0];
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A280BR_Pathology_Diag_TumorStage", A280BR_Pathology_Diag_TumorStage);
               n280BR_Pathology_Diag_TumorStage = H00592_n280BR_Pathology_Diag_TumorStage[0];
               A279BR_Pathology_Diag_TumorType = H00592_A279BR_Pathology_Diag_TumorType[0];
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A279BR_Pathology_Diag_TumorType", A279BR_Pathology_Diag_TumorType);
               n279BR_Pathology_Diag_TumorType = H00592_n279BR_Pathology_Diag_TumorType[0];
               A278BR_Pathology_Diag_Organ = H00592_A278BR_Pathology_Diag_Organ[0];
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A278BR_Pathology_Diag_Organ", A278BR_Pathology_Diag_Organ);
               n278BR_Pathology_Diag_Organ = H00592_n278BR_Pathology_Diag_Organ[0];
               A277BR_Pathology_Diag_Loc = H00592_A277BR_Pathology_Diag_Loc[0];
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A277BR_Pathology_Diag_Loc", A277BR_Pathology_Diag_Loc);
               n277BR_Pathology_Diag_Loc = H00592_n277BR_Pathology_Diag_Loc[0];
               /* Execute user event: Load */
               E12592 ();
               /* Exiting from a For First loop. */
               if (true) break;
            }
            pr_default.close(0);
            WB590( ) ;
         }
      }

      protected void send_integrity_lvl_hashes592( )
      {
      }

      protected void STRUP590( )
      {
         /* Before Start, stand alone formulas. */
         AV16Pgmname = "BR_Pathology_DiagGeneral";
         context.Gx_err = 0;
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0;
         /* Execute user event: Start */
         E11592 ();
         context.wbGlbDoneStart = 1;
         nDoneStart = 1;
         /* After Start, stand alone formulas. */
         sXEvt = cgiGet( "_EventName");
         if ( ! GetJustCreated( ) && ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 ) )
         {
            /* Read saved SDTs. */
            /* Read variables values. */
            A277BR_Pathology_Diag_Loc = cgiGet( edtBR_Pathology_Diag_Loc_Internalname);
            n277BR_Pathology_Diag_Loc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A277BR_Pathology_Diag_Loc", A277BR_Pathology_Diag_Loc);
            A278BR_Pathology_Diag_Organ = cgiGet( edtBR_Pathology_Diag_Organ_Internalname);
            n278BR_Pathology_Diag_Organ = false;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A278BR_Pathology_Diag_Organ", A278BR_Pathology_Diag_Organ);
            A279BR_Pathology_Diag_TumorType = cgiGet( edtBR_Pathology_Diag_TumorType_Internalname);
            n279BR_Pathology_Diag_TumorType = false;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A279BR_Pathology_Diag_TumorType", A279BR_Pathology_Diag_TumorType);
            A280BR_Pathology_Diag_TumorStage = cgiGet( edtBR_Pathology_Diag_TumorStage_Internalname);
            n280BR_Pathology_Diag_TumorStage = false;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A280BR_Pathology_Diag_TumorStage", A280BR_Pathology_Diag_TumorStage);
            A281BR_Pathology_Diag_TumorGrade = cgiGet( edtBR_Pathology_Diag_TumorGrade_Internalname);
            n281BR_Pathology_Diag_TumorGrade = false;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A281BR_Pathology_Diag_TumorGrade", A281BR_Pathology_Diag_TumorGrade);
            A226BR_PathologyID = (long)(context.localUtil.CToN( cgiGet( edtBR_PathologyID_Internalname), ".", ","));
            n226BR_PathologyID = false;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A226BR_PathologyID", StringUtil.LTrim( StringUtil.Str( (decimal)(A226BR_PathologyID), 18, 0)));
            /* Read saved values. */
            wcpOA276BR_Pathology_DiagID = (long)(context.localUtil.CToN( cgiGet( sPrefix+"wcpOA276BR_Pathology_DiagID"), ".", ","));
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
         E11592 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E11592( )
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

      protected void E12592( )
      {
         /* Load Routine */
         edtBR_Pathology_DiagID_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtBR_Pathology_DiagID_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBR_Pathology_DiagID_Visible), 5, 0)), true);
         edtBR_PathologyID_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtBR_PathologyID_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBR_PathologyID_Visible), 5, 0)), true);
      }

      protected void S112( )
      {
         /* 'PREPARETRANSACTION' Routine */
         AV9TrnContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext(context);
         AV9TrnContext.gxTpr_Callerobject = AV16Pgmname;
         AV9TrnContext.gxTpr_Callerondelete = false;
         AV9TrnContext.gxTpr_Callerurl = AV12HTTPRequest.ScriptName+"?"+AV12HTTPRequest.QueryString;
         AV9TrnContext.gxTpr_Transactionname = "BR_Pathology_Diag";
         AV10TrnContextAtt = new GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext_Attribute(context);
         AV10TrnContextAtt.gxTpr_Attributename = "BR_Pathology_DiagID";
         AV10TrnContextAtt.gxTpr_Attributevalue = StringUtil.Str( (decimal)(AV8BR_Pathology_DiagID), 18, 0);
         AV9TrnContext.gxTpr_Attributes.Add(AV10TrnContextAtt, 0);
         AV11Session.Set("TrnContext", AV9TrnContext.ToXml(false, true, "WWPTransactionContext", "DataAnalysisPlatform"));
      }

      public override void setparameters( Object[] obj )
      {
         createObjects();
         initialize();
         A276BR_Pathology_DiagID = Convert.ToInt64(getParm(obj,0));
         context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A276BR_Pathology_DiagID", StringUtil.LTrim( StringUtil.Str( (decimal)(A276BR_Pathology_DiagID), 18, 0)));
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
         PA592( ) ;
         WS592( ) ;
         WE592( ) ;
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
         sCtrlA276BR_Pathology_DiagID = (String)((String)getParm(obj,0));
      }

      public override void componentrestorestate( String sPPrefix ,
                                                  String sPSFPrefix )
      {
         sPrefix = sPPrefix + sPSFPrefix;
         PA592( ) ;
         WCParametersGet( ) ;
      }

      public override void componentprepare( Object[] obj )
      {
         wbLoad = false;
         sCompPrefix = (String)getParm(obj,0);
         sSFPrefix = (String)getParm(obj,1);
         sPrefix = sCompPrefix + sSFPrefix;
         AddComponentObject(sPrefix, "br_pathology_diaggeneral", GetJustCreated( ));
         if ( ( nDoneStart == 0 ) && ( nDynComponent == 0 ) )
         {
            INITWEB( ) ;
         }
         else
         {
            init_default_properties( ) ;
            init_web_controls( ) ;
         }
         PA592( ) ;
         if ( ! GetJustCreated( ) && ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 ) && ( context.wbGlbDoneStart == 0 ) )
         {
            WCParametersGet( ) ;
         }
         else
         {
            A276BR_Pathology_DiagID = Convert.ToInt64(getParm(obj,2));
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A276BR_Pathology_DiagID", StringUtil.LTrim( StringUtil.Str( (decimal)(A276BR_Pathology_DiagID), 18, 0)));
         }
         wcpOA276BR_Pathology_DiagID = (long)(context.localUtil.CToN( cgiGet( sPrefix+"wcpOA276BR_Pathology_DiagID"), ".", ","));
         if ( ! GetJustCreated( ) && ( ( A276BR_Pathology_DiagID != wcpOA276BR_Pathology_DiagID ) ) )
         {
            setjustcreated();
         }
         wcpOA276BR_Pathology_DiagID = A276BR_Pathology_DiagID;
      }

      protected void WCParametersGet( )
      {
         /* Read Component Parameters. */
         sCtrlA276BR_Pathology_DiagID = cgiGet( sPrefix+"A276BR_Pathology_DiagID_CTRL");
         if ( StringUtil.Len( sCtrlA276BR_Pathology_DiagID) > 0 )
         {
            A276BR_Pathology_DiagID = (long)(context.localUtil.CToN( cgiGet( sCtrlA276BR_Pathology_DiagID), ".", ","));
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A276BR_Pathology_DiagID", StringUtil.LTrim( StringUtil.Str( (decimal)(A276BR_Pathology_DiagID), 18, 0)));
         }
         else
         {
            A276BR_Pathology_DiagID = (long)(context.localUtil.CToN( cgiGet( sPrefix+"A276BR_Pathology_DiagID_PARM"), ".", ","));
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
         PA592( ) ;
         sEvt = sCompEvt;
         WCParametersGet( ) ;
         WS592( ) ;
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
         WS592( ) ;
         SaveComponentMsgList(sPrefix);
         context.GX_msglist = BackMsgLst;
      }

      protected void WCParametersSet( )
      {
         GxWebStd.gx_hidden_field( context, sPrefix+"A276BR_Pathology_DiagID_PARM", StringUtil.LTrim( StringUtil.NToC( (decimal)(A276BR_Pathology_DiagID), 18, 0, ".", "")));
         if ( StringUtil.Len( StringUtil.RTrim( sCtrlA276BR_Pathology_DiagID)) > 0 )
         {
            GxWebStd.gx_hidden_field( context, sPrefix+"A276BR_Pathology_DiagID_CTRL", StringUtil.RTrim( sCtrlA276BR_Pathology_DiagID));
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
         WE592( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?2020228155897", true);
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
            context.AddJavascriptSource("br_pathology_diaggeneral.js", "?2020228155897", false);
         }
         /* End function include_jscripts */
      }

      protected void init_web_controls( )
      {
         /* End function init_web_controls */
      }

      protected void init_default_properties( )
      {
         lblTextblockbr_pathology_diag_loc_Internalname = sPrefix+"TEXTBLOCKBR_PATHOLOGY_DIAG_LOC";
         edtBR_Pathology_Diag_Loc_Internalname = sPrefix+"BR_PATHOLOGY_DIAG_LOC";
         divUnnamedtablebr_pathology_diag_loc_Internalname = sPrefix+"UNNAMEDTABLEBR_PATHOLOGY_DIAG_LOC";
         lblTextblockbr_pathology_diag_organ_Internalname = sPrefix+"TEXTBLOCKBR_PATHOLOGY_DIAG_ORGAN";
         edtBR_Pathology_Diag_Organ_Internalname = sPrefix+"BR_PATHOLOGY_DIAG_ORGAN";
         divUnnamedtablebr_pathology_diag_organ_Internalname = sPrefix+"UNNAMEDTABLEBR_PATHOLOGY_DIAG_ORGAN";
         lblTextblockbr_pathology_diag_tumortype_Internalname = sPrefix+"TEXTBLOCKBR_PATHOLOGY_DIAG_TUMORTYPE";
         edtBR_Pathology_Diag_TumorType_Internalname = sPrefix+"BR_PATHOLOGY_DIAG_TUMORTYPE";
         divUnnamedtablebr_pathology_diag_tumortype_Internalname = sPrefix+"UNNAMEDTABLEBR_PATHOLOGY_DIAG_TUMORTYPE";
         lblTextblockbr_pathology_diag_tumorstage_Internalname = sPrefix+"TEXTBLOCKBR_PATHOLOGY_DIAG_TUMORSTAGE";
         edtBR_Pathology_Diag_TumorStage_Internalname = sPrefix+"BR_PATHOLOGY_DIAG_TUMORSTAGE";
         divUnnamedtablebr_pathology_diag_tumorstage_Internalname = sPrefix+"UNNAMEDTABLEBR_PATHOLOGY_DIAG_TUMORSTAGE";
         lblTextblockbr_pathology_diag_tumorgrade_Internalname = sPrefix+"TEXTBLOCKBR_PATHOLOGY_DIAG_TUMORGRADE";
         edtBR_Pathology_Diag_TumorGrade_Internalname = sPrefix+"BR_PATHOLOGY_DIAG_TUMORGRADE";
         divUnnamedtablebr_pathology_diag_tumorgrade_Internalname = sPrefix+"UNNAMEDTABLEBR_PATHOLOGY_DIAG_TUMORGRADE";
         divTransactiondetail_tableattributes_Internalname = sPrefix+"TRANSACTIONDETAIL_TABLEATTRIBUTES";
         divTable_Internalname = sPrefix+"TABLE";
         edtBR_Pathology_DiagID_Internalname = sPrefix+"BR_PATHOLOGY_DIAGID";
         edtBR_PathologyID_Internalname = sPrefix+"BR_PATHOLOGYID";
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
         edtBR_PathologyID_Jsonclick = "";
         edtBR_PathologyID_Visible = 1;
         edtBR_Pathology_DiagID_Jsonclick = "";
         edtBR_Pathology_DiagID_Visible = 1;
         edtBR_Pathology_Diag_TumorGrade_Jsonclick = "";
         edtBR_Pathology_Diag_TumorGrade_Enabled = 0;
         edtBR_Pathology_Diag_TumorStage_Jsonclick = "";
         edtBR_Pathology_Diag_TumorStage_Enabled = 0;
         edtBR_Pathology_Diag_TumorType_Jsonclick = "";
         edtBR_Pathology_Diag_TumorType_Enabled = 0;
         edtBR_Pathology_Diag_Organ_Jsonclick = "";
         edtBR_Pathology_Diag_Organ_Enabled = 0;
         edtBR_Pathology_Diag_Loc_Jsonclick = "";
         edtBR_Pathology_Diag_Loc_Enabled = 0;
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
         lblTextblockbr_pathology_diag_loc_Jsonclick = "";
         A277BR_Pathology_Diag_Loc = "";
         lblTextblockbr_pathology_diag_organ_Jsonclick = "";
         A278BR_Pathology_Diag_Organ = "";
         lblTextblockbr_pathology_diag_tumortype_Jsonclick = "";
         A279BR_Pathology_Diag_TumorType = "";
         lblTextblockbr_pathology_diag_tumorstage_Jsonclick = "";
         A280BR_Pathology_Diag_TumorStage = "";
         lblTextblockbr_pathology_diag_tumorgrade_Jsonclick = "";
         A281BR_Pathology_Diag_TumorGrade = "";
         Form = new GXWebForm();
         sXEvt = "";
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         scmdbuf = "";
         H00592_A276BR_Pathology_DiagID = new long[1] ;
         H00592_A226BR_PathologyID = new long[1] ;
         H00592_n226BR_PathologyID = new bool[] {false} ;
         H00592_A281BR_Pathology_Diag_TumorGrade = new String[] {""} ;
         H00592_n281BR_Pathology_Diag_TumorGrade = new bool[] {false} ;
         H00592_A280BR_Pathology_Diag_TumorStage = new String[] {""} ;
         H00592_n280BR_Pathology_Diag_TumorStage = new bool[] {false} ;
         H00592_A279BR_Pathology_Diag_TumorType = new String[] {""} ;
         H00592_n279BR_Pathology_Diag_TumorType = new bool[] {false} ;
         H00592_A278BR_Pathology_Diag_Organ = new String[] {""} ;
         H00592_n278BR_Pathology_Diag_Organ = new bool[] {false} ;
         H00592_A277BR_Pathology_Diag_Loc = new String[] {""} ;
         H00592_n277BR_Pathology_Diag_Loc = new bool[] {false} ;
         AV6WWPContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPContext(context);
         AV9TrnContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext(context);
         AV12HTTPRequest = new GxHttpRequest( context);
         AV10TrnContextAtt = new GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext_Attribute(context);
         AV11Session = context.GetSession();
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         sCtrlA276BR_Pathology_DiagID = "";
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.br_pathology_diaggeneral__default(),
            new Object[][] {
                new Object[] {
               H00592_A276BR_Pathology_DiagID, H00592_A226BR_PathologyID, H00592_n226BR_PathologyID, H00592_A281BR_Pathology_Diag_TumorGrade, H00592_n281BR_Pathology_Diag_TumorGrade, H00592_A280BR_Pathology_Diag_TumorStage, H00592_n280BR_Pathology_Diag_TumorStage, H00592_A279BR_Pathology_Diag_TumorType, H00592_n279BR_Pathology_Diag_TumorType, H00592_A278BR_Pathology_Diag_Organ,
               H00592_n278BR_Pathology_Diag_Organ, H00592_A277BR_Pathology_Diag_Loc, H00592_n277BR_Pathology_Diag_Loc
               }
            }
         );
         AV16Pgmname = "BR_Pathology_DiagGeneral";
         /* GeneXus formulas. */
         AV16Pgmname = "BR_Pathology_DiagGeneral";
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
      private int edtBR_Pathology_Diag_Loc_Enabled ;
      private int edtBR_Pathology_Diag_Organ_Enabled ;
      private int edtBR_Pathology_Diag_TumorType_Enabled ;
      private int edtBR_Pathology_Diag_TumorStage_Enabled ;
      private int edtBR_Pathology_Diag_TumorGrade_Enabled ;
      private int edtBR_Pathology_DiagID_Visible ;
      private int edtBR_PathologyID_Visible ;
      private int idxLst ;
      private long A276BR_Pathology_DiagID ;
      private long wcpOA276BR_Pathology_DiagID ;
      private long A226BR_PathologyID ;
      private long AV8BR_Pathology_DiagID ;
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
      private String divUnnamedtablebr_pathology_diag_loc_Internalname ;
      private String lblTextblockbr_pathology_diag_loc_Internalname ;
      private String lblTextblockbr_pathology_diag_loc_Jsonclick ;
      private String edtBR_Pathology_Diag_Loc_Internalname ;
      private String edtBR_Pathology_Diag_Loc_Jsonclick ;
      private String divUnnamedtablebr_pathology_diag_organ_Internalname ;
      private String lblTextblockbr_pathology_diag_organ_Internalname ;
      private String lblTextblockbr_pathology_diag_organ_Jsonclick ;
      private String edtBR_Pathology_Diag_Organ_Internalname ;
      private String edtBR_Pathology_Diag_Organ_Jsonclick ;
      private String divUnnamedtablebr_pathology_diag_tumortype_Internalname ;
      private String lblTextblockbr_pathology_diag_tumortype_Internalname ;
      private String lblTextblockbr_pathology_diag_tumortype_Jsonclick ;
      private String edtBR_Pathology_Diag_TumorType_Internalname ;
      private String edtBR_Pathology_Diag_TumorType_Jsonclick ;
      private String divUnnamedtablebr_pathology_diag_tumorstage_Internalname ;
      private String lblTextblockbr_pathology_diag_tumorstage_Internalname ;
      private String lblTextblockbr_pathology_diag_tumorstage_Jsonclick ;
      private String edtBR_Pathology_Diag_TumorStage_Internalname ;
      private String edtBR_Pathology_Diag_TumorStage_Jsonclick ;
      private String divUnnamedtablebr_pathology_diag_tumorgrade_Internalname ;
      private String lblTextblockbr_pathology_diag_tumorgrade_Internalname ;
      private String lblTextblockbr_pathology_diag_tumorgrade_Jsonclick ;
      private String edtBR_Pathology_Diag_TumorGrade_Internalname ;
      private String edtBR_Pathology_Diag_TumorGrade_Jsonclick ;
      private String divHtml_bottomauxiliarcontrols_Internalname ;
      private String edtBR_Pathology_DiagID_Internalname ;
      private String edtBR_Pathology_DiagID_Jsonclick ;
      private String edtBR_PathologyID_Internalname ;
      private String edtBR_PathologyID_Jsonclick ;
      private String sXEvt ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String scmdbuf ;
      private String sCtrlA276BR_Pathology_DiagID ;
      private bool entryPointCalled ;
      private bool toggleJsOutput ;
      private bool wbLoad ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool gxdyncontrolsrefreshing ;
      private bool n226BR_PathologyID ;
      private bool n281BR_Pathology_Diag_TumorGrade ;
      private bool n280BR_Pathology_Diag_TumorStage ;
      private bool n279BR_Pathology_Diag_TumorType ;
      private bool n278BR_Pathology_Diag_Organ ;
      private bool n277BR_Pathology_Diag_Loc ;
      private bool returnInSub ;
      private String A277BR_Pathology_Diag_Loc ;
      private String A278BR_Pathology_Diag_Organ ;
      private String A279BR_Pathology_Diag_TumorType ;
      private String A280BR_Pathology_Diag_TumorStage ;
      private String A281BR_Pathology_Diag_TumorGrade ;
      private GXWebForm Form ;
      private IGxDataStore dsDataStore1 ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private long[] H00592_A276BR_Pathology_DiagID ;
      private long[] H00592_A226BR_PathologyID ;
      private bool[] H00592_n226BR_PathologyID ;
      private String[] H00592_A281BR_Pathology_Diag_TumorGrade ;
      private bool[] H00592_n281BR_Pathology_Diag_TumorGrade ;
      private String[] H00592_A280BR_Pathology_Diag_TumorStage ;
      private bool[] H00592_n280BR_Pathology_Diag_TumorStage ;
      private String[] H00592_A279BR_Pathology_Diag_TumorType ;
      private bool[] H00592_n279BR_Pathology_Diag_TumorType ;
      private String[] H00592_A278BR_Pathology_Diag_Organ ;
      private bool[] H00592_n278BR_Pathology_Diag_Organ ;
      private String[] H00592_A277BR_Pathology_Diag_Loc ;
      private bool[] H00592_n277BR_Pathology_Diag_Loc ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private GxHttpRequest AV12HTTPRequest ;
      private IGxSession AV11Session ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPContext AV6WWPContext ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext AV9TrnContext ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext_Attribute AV10TrnContextAtt ;
   }

   public class br_pathology_diaggeneral__default : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmH00592 ;
          prmH00592 = new Object[] {
          new Object[] {"@BR_Pathology_DiagID",SqlDbType.Decimal,18,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("H00592", "SELECT [BR_Pathology_DiagID], [BR_PathologyID], [BR_Pathology_Diag_TumorGrade], [BR_Pathology_Diag_TumorStage], [BR_Pathology_Diag_TumorType], [BR_Pathology_Diag_Organ], [BR_Pathology_Diag_Loc] FROM [BR_Pathology_Diag] WITH (NOLOCK) WHERE [BR_Pathology_DiagID] = @BR_Pathology_DiagID ORDER BY [BR_Pathology_DiagID] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH00592,1,0,true,true )
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
