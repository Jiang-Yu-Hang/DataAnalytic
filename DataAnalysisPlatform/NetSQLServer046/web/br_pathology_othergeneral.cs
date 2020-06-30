/*
               File: BR_Pathology_OtherGeneral
        Description: BR_Pathology_Other General
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/27/2020 11:54:16.73
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
   public class br_pathology_othergeneral : GXWebComponent, System.Web.SessionState.IRequiresSessionState
   {
      public br_pathology_othergeneral( )
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

      public br_pathology_othergeneral( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( long aP0_BR_Pathology_OtherID )
      {
         this.A288BR_Pathology_OtherID = aP0_BR_Pathology_OtherID;
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
                  A288BR_Pathology_OtherID = (long)(NumberUtil.Val( GetNextPar( ), "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A288BR_Pathology_OtherID", StringUtil.LTrim( StringUtil.Str( (decimal)(A288BR_Pathology_OtherID), 18, 0)));
                  setjustcreated();
                  componentprepare(new Object[] {(String)sCompPrefix,(String)sSFPrefix,(long)A288BR_Pathology_OtherID});
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
            PA5A2( ) ;
            if ( ( GxWebError == 0 ) && ! isAjaxCallMode( ) )
            {
               /* GeneXus formulas. */
               AV16Pgmname = "BR_Pathology_OtherGeneral";
               context.Gx_err = 0;
               WS5A2( ) ;
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
            context.SendWebValue( "BR_Pathology_Other General") ;
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
         context.AddJavascriptSource("gxcfg.js", "?202022711541678", false);
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
            context.WriteHtmlTextNl( "<form id=\"MAINFORM\" autocomplete=\"off\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("br_pathology_othergeneral.aspx") + "?" + UrlEncode("" +A288BR_Pathology_OtherID)+"\">") ;
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
         GxWebStd.gx_hidden_field( context, sPrefix+"wcpOA288BR_Pathology_OtherID", StringUtil.LTrim( StringUtil.NToC( (decimal)(wcpOA288BR_Pathology_OtherID), 18, 0, ".", "")));
      }

      protected void RenderHtmlCloseForm5A2( )
      {
         SendCloseFormHiddens( ) ;
         if ( ( StringUtil.Len( sPrefix) != 0 ) && ( context.isAjaxRequest( ) || context.isSpaRequest( ) ) )
         {
            context.AddJavascriptSource("br_pathology_othergeneral.js", "?202022711541681", false);
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
         return "BR_Pathology_OtherGeneral" ;
      }

      public override String GetPgmdesc( )
      {
         return "BR_Pathology_Other General" ;
      }

      protected void WB5A0( )
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
               GxWebStd.gx_hidden_field( context, sPrefix+"_CMPPGM", "br_pathology_othergeneral.aspx");
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
            GxWebStd.gx_div_start( context, divUnnamedtablebr_pathology_other_bio_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-4 MergeLabelCell", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblockbr_pathology_other_bio_Internalname, "肿瘤标志物", "", "", lblTextblockbr_pathology_other_bio_Jsonclick, "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_BR_Pathology_OtherGeneral.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-8", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtBR_Pathology_Other_Bio_Internalname, "肿瘤标志物", "col-sm-3 ReadonlyAttributeLabel", 0, true);
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtBR_Pathology_Other_Bio_Internalname, A289BR_Pathology_Other_Bio, StringUtil.RTrim( context.localUtil.Format( A289BR_Pathology_Other_Bio, "")), "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBR_Pathology_Other_Bio_Jsonclick, 0, "ReadonlyAttribute", "", "", "", "", 1, edtBR_Pathology_Other_Bio_Enabled, 0, "text", "", 40, "chr", 1, "row", 40, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_BR_Pathology_OtherGeneral.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divUnnamedtablebr_pathology_other_bionum_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-4 MergeLabelCell", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblockbr_pathology_other_bionum_Internalname, "定量结果", "", "", lblTextblockbr_pathology_other_bionum_Jsonclick, "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_BR_Pathology_OtherGeneral.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-8", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtBR_Pathology_Other_BioNum_Internalname, "定量结果", "col-sm-3 ReadonlyAttributeLabel", 0, true);
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtBR_Pathology_Other_BioNum_Internalname, StringUtil.LTrim( StringUtil.NToC( A290BR_Pathology_Other_BioNum, 15, 5, ".", "")), ((edtBR_Pathology_Other_BioNum_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( A290BR_Pathology_Other_BioNum, "ZZZZZZZZZ.ZZZZZ")) : context.localUtil.Format( A290BR_Pathology_Other_BioNum, "ZZZZZZZZZ.ZZZZZ")), "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBR_Pathology_Other_BioNum_Jsonclick, 0, "ReadonlyAttribute", "", "", "", "", 1, edtBR_Pathology_Other_BioNum_Enabled, 0, "text", "", 15, "chr", 1, "row", 15, 0, 0, 0, 1, -1, 0, true, "DM_Numeric", "right", false, "HLP_BR_Pathology_OtherGeneral.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divUnnamedtablebr_pathology_other_bionumunit_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-2 MergeLabelCell", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblockbr_pathology_other_bionumunit_Internalname, "定量结果单位", "", "", lblTextblockbr_pathology_other_bionumunit_Jsonclick, "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_BR_Pathology_OtherGeneral.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-10", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtBR_Pathology_Other_BioNumUnit_Internalname, "定量结果单位", "col-sm-3 ReadonlyAttributeLabel", 0, true);
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtBR_Pathology_Other_BioNumUnit_Internalname, A291BR_Pathology_Other_BioNumUnit, StringUtil.RTrim( context.localUtil.Format( A291BR_Pathology_Other_BioNumUnit, "")), "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBR_Pathology_Other_BioNumUnit_Jsonclick, 0, "ReadonlyAttribute", "", "", "", "", 1, edtBR_Pathology_Other_BioNumUnit_Enabled, 0, "text", "", 40, "chr", 1, "row", 40, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_BR_Pathology_OtherGeneral.htm");
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
            GxWebStd.gx_div_start( context, divUnnamedtablebr_pathology_other_low_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-4 MergeLabelCell", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblockbr_pathology_other_low_Internalname, "参考上限", "", "", lblTextblockbr_pathology_other_low_Jsonclick, "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_BR_Pathology_OtherGeneral.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-8", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtBR_Pathology_Other_Low_Internalname, "参考上限", "col-sm-3 ReadonlyAttributeLabel", 0, true);
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtBR_Pathology_Other_Low_Internalname, StringUtil.LTrim( StringUtil.NToC( A293BR_Pathology_Other_Low, 15, 5, ".", "")), ((edtBR_Pathology_Other_Low_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( A293BR_Pathology_Other_Low, "ZZZZZZZZZ.ZZZZZ")) : context.localUtil.Format( A293BR_Pathology_Other_Low, "ZZZZZZZZZ.ZZZZZ")), "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBR_Pathology_Other_Low_Jsonclick, 0, "ReadonlyAttribute", "", "", "", "", 1, edtBR_Pathology_Other_Low_Enabled, 0, "text", "", 15, "chr", 1, "row", 15, 0, 0, 0, 1, -1, 0, true, "DM_Numeric", "right", false, "HLP_BR_Pathology_OtherGeneral.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divUnnamedtablebr_pathology_other_high_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-4 MergeLabelCell", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblockbr_pathology_other_high_Internalname, "参考下限", "", "", lblTextblockbr_pathology_other_high_Jsonclick, "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_BR_Pathology_OtherGeneral.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-8", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtBR_Pathology_Other_High_Internalname, "参考下限", "col-sm-3 ReadonlyAttributeLabel", 0, true);
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtBR_Pathology_Other_High_Internalname, StringUtil.LTrim( StringUtil.NToC( A294BR_Pathology_Other_High, 15, 5, ".", "")), ((edtBR_Pathology_Other_High_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( A294BR_Pathology_Other_High, "ZZZZZZZZZ.ZZZZZ")) : context.localUtil.Format( A294BR_Pathology_Other_High, "ZZZZZZZZZ.ZZZZZ")), "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBR_Pathology_Other_High_Jsonclick, 0, "ReadonlyAttribute", "", "", "", "", 1, edtBR_Pathology_Other_High_Enabled, 0, "text", "", 15, "chr", 1, "row", 15, 0, 0, 0, 1, -1, 0, true, "DM_Numeric", "right", false, "HLP_BR_Pathology_OtherGeneral.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divUnnamedtablebr_pathology_other_abnind_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-2 MergeLabelCell", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblockbr_pathology_other_abnind_Internalname, "结果提示", "", "", lblTextblockbr_pathology_other_abnind_Jsonclick, "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_BR_Pathology_OtherGeneral.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-10", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtBR_Pathology_Other_AbnInd_Internalname, "结果提示", "col-sm-3 ReadonlyAttributeLabel", 0, true);
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtBR_Pathology_Other_AbnInd_Internalname, A295BR_Pathology_Other_AbnInd, StringUtil.RTrim( context.localUtil.Format( A295BR_Pathology_Other_AbnInd, "")), "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBR_Pathology_Other_AbnInd_Jsonclick, 0, "ReadonlyAttribute", "", "", "", "", 1, edtBR_Pathology_Other_AbnInd_Enabled, 0, "text", "", 40, "chr", 1, "row", 40, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_BR_Pathology_OtherGeneral.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divTablesplittedbr_pathology_other_bioqual_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-2 MergeLabelCell", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblockbr_pathology_other_bioqual_Internalname, "定性结果", "", "", lblTextblockbr_pathology_other_bioqual_Jsonclick, "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_BR_Pathology_OtherGeneral.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-10", "left", "top", "", "", "div");
            wb_table1_69_5A2( true) ;
         }
         else
         {
            wb_table1_69_5A2( false) ;
         }
         return  ;
      }

      protected void wb_table1_69_5A2e( bool wbgen )
      {
         if ( wbgen )
         {
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
            GxWebStd.gx_single_line_edit( context, edtBR_Pathology_OtherID_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A288BR_Pathology_OtherID), 18, 0, ".", "")), context.localUtil.Format( (decimal)(A288BR_Pathology_OtherID), "ZZZZZZZZZZZZZZZZZZ"), "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBR_Pathology_OtherID_Jsonclick, 0, "Attribute", "", "", "", "", edtBR_Pathology_OtherID_Visible, 0, 0, "number", "1", 18, "chr", 1, "row", 18, 0, 0, 0, 1, -1, 0, true, "ID", "right", false, "HLP_BR_Pathology_OtherGeneral.htm");
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtBR_PathologyID_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A226BR_PathologyID), 18, 0, ".", "")), context.localUtil.Format( (decimal)(A226BR_PathologyID), "ZZZZZZZZZZZZZZZZZZ"), "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBR_PathologyID_Jsonclick, 0, "Attribute", "", "", "", "", edtBR_PathologyID_Visible, 0, 0, "number", "1", 18, "chr", 1, "row", 18, 0, 0, 0, 1, -1, 0, true, "ID", "right", false, "HLP_BR_Pathology_OtherGeneral.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
         }
         wbLoad = true;
      }

      protected void START5A2( )
      {
         wbLoad = false;
         wbEnd = 0;
         wbStart = 0;
         if ( StringUtil.Len( sPrefix) == 0 )
         {
            if ( ! context.isSpaRequest( ) )
            {
               Form.Meta.addItem("generator", "GeneXus C# 16_0_0-127771", 0) ;
               Form.Meta.addItem("description", "BR_Pathology_Other General", 0) ;
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
               STRUP5A0( ) ;
            }
         }
      }

      protected void WS5A2( )
      {
         START5A2( ) ;
         EVT5A2( ) ;
      }

      protected void EVT5A2( )
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
                                 STRUP5A0( ) ;
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
                                 STRUP5A0( ) ;
                              }
                              if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
                              {
                                 context.wbHandled = 1;
                                 if ( ! wbErr )
                                 {
                                    dynload_actions( ) ;
                                    /* Execute user event: Start */
                                    E115A2 ();
                                 }
                              }
                           }
                           else if ( StringUtil.StrCmp(sEvt, "LOAD") == 0 )
                           {
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP5A0( ) ;
                              }
                              if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
                              {
                                 context.wbHandled = 1;
                                 if ( ! wbErr )
                                 {
                                    dynload_actions( ) ;
                                    /* Execute user event: Load */
                                    E125A2 ();
                                 }
                              }
                           }
                           else if ( StringUtil.StrCmp(sEvt, "ENTER") == 0 )
                           {
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP5A0( ) ;
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
                                 STRUP5A0( ) ;
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

      protected void WE5A2( )
      {
         if ( ! GxWebStd.gx_redirect( context) )
         {
            Rfr0gs = true;
            Refresh( ) ;
            if ( ! GxWebStd.gx_redirect( context) )
            {
               RenderHtmlCloseForm5A2( ) ;
            }
         }
      }

      protected void PA5A2( )
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
         RF5A2( ) ;
         if ( isFullAjaxMode( ) )
         {
            send_integrity_footer_hashes( ) ;
         }
      }

      protected void initialize_formulas( )
      {
         /* GeneXus formulas. */
         AV16Pgmname = "BR_Pathology_OtherGeneral";
         context.Gx_err = 0;
      }

      protected void RF5A2( )
      {
         initialize_formulas( ) ;
         clear_multi_value_controls( ) ;
         gxdyncontrolsrefreshing = true;
         fix_multi_value_controls( ) ;
         gxdyncontrolsrefreshing = false;
         if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
         {
            /* Using cursor H005A2 */
            pr_default.execute(0, new Object[] {A288BR_Pathology_OtherID});
            while ( (pr_default.getStatus(0) != 101) )
            {
               A226BR_PathologyID = H005A2_A226BR_PathologyID[0];
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A226BR_PathologyID", StringUtil.LTrim( StringUtil.Str( (decimal)(A226BR_PathologyID), 18, 0)));
               n226BR_PathologyID = H005A2_n226BR_PathologyID[0];
               A292BR_Pathology_Other_BioQual = H005A2_A292BR_Pathology_Other_BioQual[0];
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A292BR_Pathology_Other_BioQual", A292BR_Pathology_Other_BioQual);
               n292BR_Pathology_Other_BioQual = H005A2_n292BR_Pathology_Other_BioQual[0];
               A295BR_Pathology_Other_AbnInd = H005A2_A295BR_Pathology_Other_AbnInd[0];
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A295BR_Pathology_Other_AbnInd", A295BR_Pathology_Other_AbnInd);
               n295BR_Pathology_Other_AbnInd = H005A2_n295BR_Pathology_Other_AbnInd[0];
               A294BR_Pathology_Other_High = H005A2_A294BR_Pathology_Other_High[0];
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A294BR_Pathology_Other_High", StringUtil.LTrim( StringUtil.Str( A294BR_Pathology_Other_High, 15, 5)));
               n294BR_Pathology_Other_High = H005A2_n294BR_Pathology_Other_High[0];
               A293BR_Pathology_Other_Low = H005A2_A293BR_Pathology_Other_Low[0];
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A293BR_Pathology_Other_Low", StringUtil.LTrim( StringUtil.Str( A293BR_Pathology_Other_Low, 15, 5)));
               n293BR_Pathology_Other_Low = H005A2_n293BR_Pathology_Other_Low[0];
               A291BR_Pathology_Other_BioNumUnit = H005A2_A291BR_Pathology_Other_BioNumUnit[0];
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A291BR_Pathology_Other_BioNumUnit", A291BR_Pathology_Other_BioNumUnit);
               n291BR_Pathology_Other_BioNumUnit = H005A2_n291BR_Pathology_Other_BioNumUnit[0];
               A290BR_Pathology_Other_BioNum = H005A2_A290BR_Pathology_Other_BioNum[0];
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A290BR_Pathology_Other_BioNum", StringUtil.LTrim( StringUtil.Str( A290BR_Pathology_Other_BioNum, 15, 5)));
               n290BR_Pathology_Other_BioNum = H005A2_n290BR_Pathology_Other_BioNum[0];
               A289BR_Pathology_Other_Bio = H005A2_A289BR_Pathology_Other_Bio[0];
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A289BR_Pathology_Other_Bio", A289BR_Pathology_Other_Bio);
               n289BR_Pathology_Other_Bio = H005A2_n289BR_Pathology_Other_Bio[0];
               /* Execute user event: Load */
               E125A2 ();
               /* Exiting from a For First loop. */
               if (true) break;
            }
            pr_default.close(0);
            WB5A0( ) ;
         }
      }

      protected void send_integrity_lvl_hashes5A2( )
      {
      }

      protected void STRUP5A0( )
      {
         /* Before Start, stand alone formulas. */
         AV16Pgmname = "BR_Pathology_OtherGeneral";
         context.Gx_err = 0;
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0;
         /* Execute user event: Start */
         E115A2 ();
         context.wbGlbDoneStart = 1;
         nDoneStart = 1;
         /* After Start, stand alone formulas. */
         sXEvt = cgiGet( "_EventName");
         if ( ! GetJustCreated( ) && ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 ) )
         {
            /* Read saved SDTs. */
            /* Read variables values. */
            A289BR_Pathology_Other_Bio = cgiGet( edtBR_Pathology_Other_Bio_Internalname);
            n289BR_Pathology_Other_Bio = false;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A289BR_Pathology_Other_Bio", A289BR_Pathology_Other_Bio);
            A290BR_Pathology_Other_BioNum = context.localUtil.CToN( cgiGet( edtBR_Pathology_Other_BioNum_Internalname), ".", ",");
            n290BR_Pathology_Other_BioNum = false;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A290BR_Pathology_Other_BioNum", StringUtil.LTrim( StringUtil.Str( A290BR_Pathology_Other_BioNum, 15, 5)));
            A291BR_Pathology_Other_BioNumUnit = cgiGet( edtBR_Pathology_Other_BioNumUnit_Internalname);
            n291BR_Pathology_Other_BioNumUnit = false;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A291BR_Pathology_Other_BioNumUnit", A291BR_Pathology_Other_BioNumUnit);
            A293BR_Pathology_Other_Low = context.localUtil.CToN( cgiGet( edtBR_Pathology_Other_Low_Internalname), ".", ",");
            n293BR_Pathology_Other_Low = false;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A293BR_Pathology_Other_Low", StringUtil.LTrim( StringUtil.Str( A293BR_Pathology_Other_Low, 15, 5)));
            A294BR_Pathology_Other_High = context.localUtil.CToN( cgiGet( edtBR_Pathology_Other_High_Internalname), ".", ",");
            n294BR_Pathology_Other_High = false;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A294BR_Pathology_Other_High", StringUtil.LTrim( StringUtil.Str( A294BR_Pathology_Other_High, 15, 5)));
            A295BR_Pathology_Other_AbnInd = cgiGet( edtBR_Pathology_Other_AbnInd_Internalname);
            n295BR_Pathology_Other_AbnInd = false;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A295BR_Pathology_Other_AbnInd", A295BR_Pathology_Other_AbnInd);
            A292BR_Pathology_Other_BioQual = cgiGet( edtBR_Pathology_Other_BioQual_Internalname);
            n292BR_Pathology_Other_BioQual = false;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A292BR_Pathology_Other_BioQual", A292BR_Pathology_Other_BioQual);
            A226BR_PathologyID = (long)(context.localUtil.CToN( cgiGet( edtBR_PathologyID_Internalname), ".", ","));
            n226BR_PathologyID = false;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A226BR_PathologyID", StringUtil.LTrim( StringUtil.Str( (decimal)(A226BR_PathologyID), 18, 0)));
            /* Read saved values. */
            wcpOA288BR_Pathology_OtherID = (long)(context.localUtil.CToN( cgiGet( sPrefix+"wcpOA288BR_Pathology_OtherID"), ".", ","));
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
         E115A2 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E115A2( )
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

      protected void E125A2( )
      {
         /* Load Routine */
         edtBR_Pathology_OtherID_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtBR_Pathology_OtherID_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBR_Pathology_OtherID_Visible), 5, 0)), true);
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
         AV9TrnContext.gxTpr_Transactionname = "BR_Pathology_Other";
         AV10TrnContextAtt = new GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext_Attribute(context);
         AV10TrnContextAtt.gxTpr_Attributename = "BR_Pathology_OtherID";
         AV10TrnContextAtt.gxTpr_Attributevalue = StringUtil.Str( (decimal)(AV8BR_Pathology_OtherID), 18, 0);
         AV9TrnContext.gxTpr_Attributes.Add(AV10TrnContextAtt, 0);
         AV11Session.Set("TrnContext", AV9TrnContext.ToXml(false, true, "WWPTransactionContext", "DataAnalysisPlatform"));
      }

      protected void wb_table1_69_5A2( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "";
            GxWebStd.gx_table_start( context, tblTablemergedbr_pathology_other_bioqual_Internalname, tblTablemergedbr_pathology_other_bioqual_Internalname, "", "TableMerged", 0, "", "", 0, 0, sStyleString, "", "", 0);
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td class='MergeDataCell'>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtBR_Pathology_Other_BioQual_Internalname, "定性结果", "col-sm-3 ReadonlyAttributeLabel", 0, true);
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtBR_Pathology_Other_BioQual_Internalname, A292BR_Pathology_Other_BioQual, StringUtil.RTrim( context.localUtil.Format( A292BR_Pathology_Other_BioQual, "")), "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBR_Pathology_Other_BioQual_Jsonclick, 0, "ReadonlyAttribute", "", "", "", "", 1, edtBR_Pathology_Other_BioQual_Enabled, 0, "text", "", 40, "chr", 1, "row", 40, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_BR_Pathology_OtherGeneral.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 75,'" + sPrefix + "',false,'',0)\"";
            ClassString = "bangzhu";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtnbeizhu_Internalname, "", "帮助", bttBtnbeizhu_Jsonclick, 7, "帮助", "", StyleString, ClassString, 1, 1, "standard", "'"+sPrefix+"'"+",false,"+"'"+"e135a1_client"+"'", TempTags, "", 2, "HLP_BR_Pathology_OtherGeneral.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table1_69_5A2e( true) ;
         }
         else
         {
            wb_table1_69_5A2e( false) ;
         }
      }

      public override void setparameters( Object[] obj )
      {
         createObjects();
         initialize();
         A288BR_Pathology_OtherID = Convert.ToInt64(getParm(obj,0));
         context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A288BR_Pathology_OtherID", StringUtil.LTrim( StringUtil.Str( (decimal)(A288BR_Pathology_OtherID), 18, 0)));
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
         PA5A2( ) ;
         WS5A2( ) ;
         WE5A2( ) ;
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
         sCtrlA288BR_Pathology_OtherID = (String)((String)getParm(obj,0));
      }

      public override void componentrestorestate( String sPPrefix ,
                                                  String sPSFPrefix )
      {
         sPrefix = sPPrefix + sPSFPrefix;
         PA5A2( ) ;
         WCParametersGet( ) ;
      }

      public override void componentprepare( Object[] obj )
      {
         wbLoad = false;
         sCompPrefix = (String)getParm(obj,0);
         sSFPrefix = (String)getParm(obj,1);
         sPrefix = sCompPrefix + sSFPrefix;
         AddComponentObject(sPrefix, "br_pathology_othergeneral", GetJustCreated( ));
         if ( ( nDoneStart == 0 ) && ( nDynComponent == 0 ) )
         {
            INITWEB( ) ;
         }
         else
         {
            init_default_properties( ) ;
            init_web_controls( ) ;
         }
         PA5A2( ) ;
         if ( ! GetJustCreated( ) && ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 ) && ( context.wbGlbDoneStart == 0 ) )
         {
            WCParametersGet( ) ;
         }
         else
         {
            A288BR_Pathology_OtherID = Convert.ToInt64(getParm(obj,2));
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A288BR_Pathology_OtherID", StringUtil.LTrim( StringUtil.Str( (decimal)(A288BR_Pathology_OtherID), 18, 0)));
         }
         wcpOA288BR_Pathology_OtherID = (long)(context.localUtil.CToN( cgiGet( sPrefix+"wcpOA288BR_Pathology_OtherID"), ".", ","));
         if ( ! GetJustCreated( ) && ( ( A288BR_Pathology_OtherID != wcpOA288BR_Pathology_OtherID ) ) )
         {
            setjustcreated();
         }
         wcpOA288BR_Pathology_OtherID = A288BR_Pathology_OtherID;
      }

      protected void WCParametersGet( )
      {
         /* Read Component Parameters. */
         sCtrlA288BR_Pathology_OtherID = cgiGet( sPrefix+"A288BR_Pathology_OtherID_CTRL");
         if ( StringUtil.Len( sCtrlA288BR_Pathology_OtherID) > 0 )
         {
            A288BR_Pathology_OtherID = (long)(context.localUtil.CToN( cgiGet( sCtrlA288BR_Pathology_OtherID), ".", ","));
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A288BR_Pathology_OtherID", StringUtil.LTrim( StringUtil.Str( (decimal)(A288BR_Pathology_OtherID), 18, 0)));
         }
         else
         {
            A288BR_Pathology_OtherID = (long)(context.localUtil.CToN( cgiGet( sPrefix+"A288BR_Pathology_OtherID_PARM"), ".", ","));
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
         PA5A2( ) ;
         sEvt = sCompEvt;
         WCParametersGet( ) ;
         WS5A2( ) ;
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
         WS5A2( ) ;
         SaveComponentMsgList(sPrefix);
         context.GX_msglist = BackMsgLst;
      }

      protected void WCParametersSet( )
      {
         GxWebStd.gx_hidden_field( context, sPrefix+"A288BR_Pathology_OtherID_PARM", StringUtil.LTrim( StringUtil.NToC( (decimal)(A288BR_Pathology_OtherID), 18, 0, ".", "")));
         if ( StringUtil.Len( StringUtil.RTrim( sCtrlA288BR_Pathology_OtherID)) > 0 )
         {
            GxWebStd.gx_hidden_field( context, sPrefix+"A288BR_Pathology_OtherID_CTRL", StringUtil.RTrim( sCtrlA288BR_Pathology_OtherID));
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
         WE5A2( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?202022711541818", true);
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
         context.AddJavascriptSource("br_pathology_othergeneral.js", "?202022711541819", false);
         /* End function include_jscripts */
      }

      protected void init_web_controls( )
      {
         /* End function init_web_controls */
      }

      protected void init_default_properties( )
      {
         lblTextblockbr_pathology_other_bio_Internalname = sPrefix+"TEXTBLOCKBR_PATHOLOGY_OTHER_BIO";
         edtBR_Pathology_Other_Bio_Internalname = sPrefix+"BR_PATHOLOGY_OTHER_BIO";
         divUnnamedtablebr_pathology_other_bio_Internalname = sPrefix+"UNNAMEDTABLEBR_PATHOLOGY_OTHER_BIO";
         lblTextblockbr_pathology_other_bionum_Internalname = sPrefix+"TEXTBLOCKBR_PATHOLOGY_OTHER_BIONUM";
         edtBR_Pathology_Other_BioNum_Internalname = sPrefix+"BR_PATHOLOGY_OTHER_BIONUM";
         divUnnamedtablebr_pathology_other_bionum_Internalname = sPrefix+"UNNAMEDTABLEBR_PATHOLOGY_OTHER_BIONUM";
         lblTextblockbr_pathology_other_bionumunit_Internalname = sPrefix+"TEXTBLOCKBR_PATHOLOGY_OTHER_BIONUMUNIT";
         edtBR_Pathology_Other_BioNumUnit_Internalname = sPrefix+"BR_PATHOLOGY_OTHER_BIONUMUNIT";
         divUnnamedtablebr_pathology_other_bionumunit_Internalname = sPrefix+"UNNAMEDTABLEBR_PATHOLOGY_OTHER_BIONUMUNIT";
         lblTextblockbr_pathology_other_low_Internalname = sPrefix+"TEXTBLOCKBR_PATHOLOGY_OTHER_LOW";
         edtBR_Pathology_Other_Low_Internalname = sPrefix+"BR_PATHOLOGY_OTHER_LOW";
         divUnnamedtablebr_pathology_other_low_Internalname = sPrefix+"UNNAMEDTABLEBR_PATHOLOGY_OTHER_LOW";
         lblTextblockbr_pathology_other_high_Internalname = sPrefix+"TEXTBLOCKBR_PATHOLOGY_OTHER_HIGH";
         edtBR_Pathology_Other_High_Internalname = sPrefix+"BR_PATHOLOGY_OTHER_HIGH";
         divUnnamedtablebr_pathology_other_high_Internalname = sPrefix+"UNNAMEDTABLEBR_PATHOLOGY_OTHER_HIGH";
         lblTextblockbr_pathology_other_abnind_Internalname = sPrefix+"TEXTBLOCKBR_PATHOLOGY_OTHER_ABNIND";
         edtBR_Pathology_Other_AbnInd_Internalname = sPrefix+"BR_PATHOLOGY_OTHER_ABNIND";
         divUnnamedtablebr_pathology_other_abnind_Internalname = sPrefix+"UNNAMEDTABLEBR_PATHOLOGY_OTHER_ABNIND";
         lblTextblockbr_pathology_other_bioqual_Internalname = sPrefix+"TEXTBLOCKBR_PATHOLOGY_OTHER_BIOQUAL";
         edtBR_Pathology_Other_BioQual_Internalname = sPrefix+"BR_PATHOLOGY_OTHER_BIOQUAL";
         bttBtnbeizhu_Internalname = sPrefix+"BTNBEIZHU";
         tblTablemergedbr_pathology_other_bioqual_Internalname = sPrefix+"TABLEMERGEDBR_PATHOLOGY_OTHER_BIOQUAL";
         divTablesplittedbr_pathology_other_bioqual_Internalname = sPrefix+"TABLESPLITTEDBR_PATHOLOGY_OTHER_BIOQUAL";
         divTransactiondetail_tableattributes_Internalname = sPrefix+"TRANSACTIONDETAIL_TABLEATTRIBUTES";
         divTable_Internalname = sPrefix+"TABLE";
         edtBR_Pathology_OtherID_Internalname = sPrefix+"BR_PATHOLOGY_OTHERID";
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
         edtBR_Pathology_Other_BioQual_Jsonclick = "";
         edtBR_Pathology_Other_BioQual_Enabled = 0;
         edtBR_PathologyID_Jsonclick = "";
         edtBR_PathologyID_Visible = 1;
         edtBR_Pathology_OtherID_Jsonclick = "";
         edtBR_Pathology_OtherID_Visible = 1;
         edtBR_Pathology_Other_AbnInd_Jsonclick = "";
         edtBR_Pathology_Other_AbnInd_Enabled = 0;
         edtBR_Pathology_Other_High_Jsonclick = "";
         edtBR_Pathology_Other_High_Enabled = 0;
         edtBR_Pathology_Other_Low_Jsonclick = "";
         edtBR_Pathology_Other_Low_Enabled = 0;
         edtBR_Pathology_Other_BioNumUnit_Jsonclick = "";
         edtBR_Pathology_Other_BioNumUnit_Enabled = 0;
         edtBR_Pathology_Other_BioNum_Jsonclick = "";
         edtBR_Pathology_Other_BioNum_Enabled = 0;
         edtBR_Pathology_Other_Bio_Jsonclick = "";
         edtBR_Pathology_Other_Bio_Enabled = 0;
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
         setEventMetadata("'DOBEIZHU'","{handler:'E135A1',iparms:[]");
         setEventMetadata("'DOBEIZHU'",",oparms:[]}");
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
         lblTextblockbr_pathology_other_bio_Jsonclick = "";
         A289BR_Pathology_Other_Bio = "";
         lblTextblockbr_pathology_other_bionum_Jsonclick = "";
         lblTextblockbr_pathology_other_bionumunit_Jsonclick = "";
         A291BR_Pathology_Other_BioNumUnit = "";
         lblTextblockbr_pathology_other_low_Jsonclick = "";
         lblTextblockbr_pathology_other_high_Jsonclick = "";
         lblTextblockbr_pathology_other_abnind_Jsonclick = "";
         A295BR_Pathology_Other_AbnInd = "";
         lblTextblockbr_pathology_other_bioqual_Jsonclick = "";
         Form = new GXWebForm();
         sXEvt = "";
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         scmdbuf = "";
         H005A2_A288BR_Pathology_OtherID = new long[1] ;
         H005A2_A226BR_PathologyID = new long[1] ;
         H005A2_n226BR_PathologyID = new bool[] {false} ;
         H005A2_A292BR_Pathology_Other_BioQual = new String[] {""} ;
         H005A2_n292BR_Pathology_Other_BioQual = new bool[] {false} ;
         H005A2_A295BR_Pathology_Other_AbnInd = new String[] {""} ;
         H005A2_n295BR_Pathology_Other_AbnInd = new bool[] {false} ;
         H005A2_A294BR_Pathology_Other_High = new decimal[1] ;
         H005A2_n294BR_Pathology_Other_High = new bool[] {false} ;
         H005A2_A293BR_Pathology_Other_Low = new decimal[1] ;
         H005A2_n293BR_Pathology_Other_Low = new bool[] {false} ;
         H005A2_A291BR_Pathology_Other_BioNumUnit = new String[] {""} ;
         H005A2_n291BR_Pathology_Other_BioNumUnit = new bool[] {false} ;
         H005A2_A290BR_Pathology_Other_BioNum = new decimal[1] ;
         H005A2_n290BR_Pathology_Other_BioNum = new bool[] {false} ;
         H005A2_A289BR_Pathology_Other_Bio = new String[] {""} ;
         H005A2_n289BR_Pathology_Other_Bio = new bool[] {false} ;
         A292BR_Pathology_Other_BioQual = "";
         AV6WWPContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPContext(context);
         AV9TrnContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext(context);
         AV12HTTPRequest = new GxHttpRequest( context);
         AV10TrnContextAtt = new GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext_Attribute(context);
         AV11Session = context.GetSession();
         sStyleString = "";
         TempTags = "";
         ClassString = "";
         StyleString = "";
         bttBtnbeizhu_Jsonclick = "";
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         sCtrlA288BR_Pathology_OtherID = "";
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.br_pathology_othergeneral__default(),
            new Object[][] {
                new Object[] {
               H005A2_A288BR_Pathology_OtherID, H005A2_A226BR_PathologyID, H005A2_n226BR_PathologyID, H005A2_A292BR_Pathology_Other_BioQual, H005A2_n292BR_Pathology_Other_BioQual, H005A2_A295BR_Pathology_Other_AbnInd, H005A2_n295BR_Pathology_Other_AbnInd, H005A2_A294BR_Pathology_Other_High, H005A2_n294BR_Pathology_Other_High, H005A2_A293BR_Pathology_Other_Low,
               H005A2_n293BR_Pathology_Other_Low, H005A2_A291BR_Pathology_Other_BioNumUnit, H005A2_n291BR_Pathology_Other_BioNumUnit, H005A2_A290BR_Pathology_Other_BioNum, H005A2_n290BR_Pathology_Other_BioNum, H005A2_A289BR_Pathology_Other_Bio, H005A2_n289BR_Pathology_Other_Bio
               }
            }
         );
         AV16Pgmname = "BR_Pathology_OtherGeneral";
         /* GeneXus formulas. */
         AV16Pgmname = "BR_Pathology_OtherGeneral";
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
      private int edtBR_Pathology_Other_Bio_Enabled ;
      private int edtBR_Pathology_Other_BioNum_Enabled ;
      private int edtBR_Pathology_Other_BioNumUnit_Enabled ;
      private int edtBR_Pathology_Other_Low_Enabled ;
      private int edtBR_Pathology_Other_High_Enabled ;
      private int edtBR_Pathology_Other_AbnInd_Enabled ;
      private int edtBR_Pathology_OtherID_Visible ;
      private int edtBR_PathologyID_Visible ;
      private int edtBR_Pathology_Other_BioQual_Enabled ;
      private int idxLst ;
      private long A288BR_Pathology_OtherID ;
      private long wcpOA288BR_Pathology_OtherID ;
      private long A226BR_PathologyID ;
      private long AV8BR_Pathology_OtherID ;
      private decimal A290BR_Pathology_Other_BioNum ;
      private decimal A293BR_Pathology_Other_Low ;
      private decimal A294BR_Pathology_Other_High ;
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
      private String divUnnamedtablebr_pathology_other_bio_Internalname ;
      private String lblTextblockbr_pathology_other_bio_Internalname ;
      private String lblTextblockbr_pathology_other_bio_Jsonclick ;
      private String edtBR_Pathology_Other_Bio_Internalname ;
      private String edtBR_Pathology_Other_Bio_Jsonclick ;
      private String divUnnamedtablebr_pathology_other_bionum_Internalname ;
      private String lblTextblockbr_pathology_other_bionum_Internalname ;
      private String lblTextblockbr_pathology_other_bionum_Jsonclick ;
      private String edtBR_Pathology_Other_BioNum_Internalname ;
      private String edtBR_Pathology_Other_BioNum_Jsonclick ;
      private String divUnnamedtablebr_pathology_other_bionumunit_Internalname ;
      private String lblTextblockbr_pathology_other_bionumunit_Internalname ;
      private String lblTextblockbr_pathology_other_bionumunit_Jsonclick ;
      private String edtBR_Pathology_Other_BioNumUnit_Internalname ;
      private String edtBR_Pathology_Other_BioNumUnit_Jsonclick ;
      private String divUnnamedtablebr_pathology_other_low_Internalname ;
      private String lblTextblockbr_pathology_other_low_Internalname ;
      private String lblTextblockbr_pathology_other_low_Jsonclick ;
      private String edtBR_Pathology_Other_Low_Internalname ;
      private String edtBR_Pathology_Other_Low_Jsonclick ;
      private String divUnnamedtablebr_pathology_other_high_Internalname ;
      private String lblTextblockbr_pathology_other_high_Internalname ;
      private String lblTextblockbr_pathology_other_high_Jsonclick ;
      private String edtBR_Pathology_Other_High_Internalname ;
      private String edtBR_Pathology_Other_High_Jsonclick ;
      private String divUnnamedtablebr_pathology_other_abnind_Internalname ;
      private String lblTextblockbr_pathology_other_abnind_Internalname ;
      private String lblTextblockbr_pathology_other_abnind_Jsonclick ;
      private String edtBR_Pathology_Other_AbnInd_Internalname ;
      private String edtBR_Pathology_Other_AbnInd_Jsonclick ;
      private String divTablesplittedbr_pathology_other_bioqual_Internalname ;
      private String lblTextblockbr_pathology_other_bioqual_Internalname ;
      private String lblTextblockbr_pathology_other_bioqual_Jsonclick ;
      private String divHtml_bottomauxiliarcontrols_Internalname ;
      private String edtBR_Pathology_OtherID_Internalname ;
      private String edtBR_Pathology_OtherID_Jsonclick ;
      private String edtBR_PathologyID_Internalname ;
      private String edtBR_PathologyID_Jsonclick ;
      private String sXEvt ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String scmdbuf ;
      private String edtBR_Pathology_Other_BioQual_Internalname ;
      private String sStyleString ;
      private String tblTablemergedbr_pathology_other_bioqual_Internalname ;
      private String edtBR_Pathology_Other_BioQual_Jsonclick ;
      private String TempTags ;
      private String ClassString ;
      private String StyleString ;
      private String bttBtnbeizhu_Internalname ;
      private String bttBtnbeizhu_Jsonclick ;
      private String sCtrlA288BR_Pathology_OtherID ;
      private bool entryPointCalled ;
      private bool toggleJsOutput ;
      private bool wbLoad ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool gxdyncontrolsrefreshing ;
      private bool n226BR_PathologyID ;
      private bool n292BR_Pathology_Other_BioQual ;
      private bool n295BR_Pathology_Other_AbnInd ;
      private bool n294BR_Pathology_Other_High ;
      private bool n293BR_Pathology_Other_Low ;
      private bool n291BR_Pathology_Other_BioNumUnit ;
      private bool n290BR_Pathology_Other_BioNum ;
      private bool n289BR_Pathology_Other_Bio ;
      private bool returnInSub ;
      private String A289BR_Pathology_Other_Bio ;
      private String A291BR_Pathology_Other_BioNumUnit ;
      private String A295BR_Pathology_Other_AbnInd ;
      private String A292BR_Pathology_Other_BioQual ;
      private GXWebForm Form ;
      private IGxDataStore dsDataStore1 ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private long[] H005A2_A288BR_Pathology_OtherID ;
      private long[] H005A2_A226BR_PathologyID ;
      private bool[] H005A2_n226BR_PathologyID ;
      private String[] H005A2_A292BR_Pathology_Other_BioQual ;
      private bool[] H005A2_n292BR_Pathology_Other_BioQual ;
      private String[] H005A2_A295BR_Pathology_Other_AbnInd ;
      private bool[] H005A2_n295BR_Pathology_Other_AbnInd ;
      private decimal[] H005A2_A294BR_Pathology_Other_High ;
      private bool[] H005A2_n294BR_Pathology_Other_High ;
      private decimal[] H005A2_A293BR_Pathology_Other_Low ;
      private bool[] H005A2_n293BR_Pathology_Other_Low ;
      private String[] H005A2_A291BR_Pathology_Other_BioNumUnit ;
      private bool[] H005A2_n291BR_Pathology_Other_BioNumUnit ;
      private decimal[] H005A2_A290BR_Pathology_Other_BioNum ;
      private bool[] H005A2_n290BR_Pathology_Other_BioNum ;
      private String[] H005A2_A289BR_Pathology_Other_Bio ;
      private bool[] H005A2_n289BR_Pathology_Other_Bio ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private GxHttpRequest AV12HTTPRequest ;
      private IGxSession AV11Session ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPContext AV6WWPContext ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext AV9TrnContext ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext_Attribute AV10TrnContextAtt ;
   }

   public class br_pathology_othergeneral__default : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmH005A2 ;
          prmH005A2 = new Object[] {
          new Object[] {"@BR_Pathology_OtherID",SqlDbType.Decimal,18,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("H005A2", "SELECT [BR_Pathology_OtherID], [BR_PathologyID], [BR_Pathology_Other_BioQual], [BR_Pathology_Other_AbnInd], [BR_Pathology_Other_High], [BR_Pathology_Other_Low], [BR_Pathology_Other_BioNumUnit], [BR_Pathology_Other_BioNum], [BR_Pathology_Other_Bio] FROM [BR_Pathology_Other] WITH (NOLOCK) WHERE [BR_Pathology_OtherID] = @BR_Pathology_OtherID ORDER BY [BR_Pathology_OtherID] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH005A2,1,0,true,true )
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
                ((decimal[]) buf[7])[0] = rslt.getDecimal(5) ;
                ((bool[]) buf[8])[0] = rslt.wasNull(5);
                ((decimal[]) buf[9])[0] = rslt.getDecimal(6) ;
                ((bool[]) buf[10])[0] = rslt.wasNull(6);
                ((String[]) buf[11])[0] = rslt.getVarchar(7) ;
                ((bool[]) buf[12])[0] = rslt.wasNull(7);
                ((decimal[]) buf[13])[0] = rslt.getDecimal(8) ;
                ((bool[]) buf[14])[0] = rslt.wasNull(8);
                ((String[]) buf[15])[0] = rslt.getVarchar(9) ;
                ((bool[]) buf[16])[0] = rslt.wasNull(9);
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
