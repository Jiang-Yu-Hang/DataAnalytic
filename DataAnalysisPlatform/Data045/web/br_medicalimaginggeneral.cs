/*
               File: BR_MedicalImagingGeneral
        Description: BR_Medical Imaging General
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/28/2020 15:5:11.46
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
   public class br_medicalimaginggeneral : GXWebComponent, System.Web.SessionState.IRequiresSessionState
   {
      public br_medicalimaginggeneral( )
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

      public br_medicalimaginggeneral( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( long aP0_BR_MedicalImagingID )
      {
         this.A225BR_MedicalImagingID = aP0_BR_MedicalImagingID;
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
         cmbBR_MedicalImaging_MetastasesDX = new GXCombobox();
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
                  A225BR_MedicalImagingID = (long)(NumberUtil.Val( GetNextPar( ), "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A225BR_MedicalImagingID", StringUtil.LTrim( StringUtil.Str( (decimal)(A225BR_MedicalImagingID), 18, 0)));
                  setjustcreated();
                  componentprepare(new Object[] {(String)sCompPrefix,(String)sSFPrefix,(long)A225BR_MedicalImagingID});
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
            PA4T2( ) ;
            if ( ( GxWebError == 0 ) && ! isAjaxCallMode( ) )
            {
               /* GeneXus formulas. */
               AV16Pgmname = "BR_MedicalImagingGeneral";
               context.Gx_err = 0;
               WS4T2( ) ;
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
            context.SendWebValue( "BR_Medical Imaging General") ;
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
         context.AddJavascriptSource("gxcfg.js", "?20202281551152", false);
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
               context.WriteHtmlTextNl( "<form id=\"MAINFORM\" autocomplete=\"off\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("br_medicalimaginggeneral.aspx") + "?" + UrlEncode("" +A225BR_MedicalImagingID)+"\">") ;
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
         forbiddenHiddens = sPrefix + "hsh" + "BR_MedicalImagingGeneral";
         forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( A514BR_MedicalImaging_MetastasesDX, ""));
         GxWebStd.gx_hidden_field( context, sPrefix+"hsh", GetEncryptedHash( forbiddenHiddens, GXKey));
         GXUtil.WriteLog("br_medicalimaginggeneral:[SendSecurityCheck value for]"+"BR_MedicalImaging_MetastasesDX:"+StringUtil.RTrim( context.localUtil.Format( A514BR_MedicalImaging_MetastasesDX, "")));
      }

      protected void SendCloseFormHiddens( )
      {
         /* Send hidden variables. */
         /* Send saved values. */
         send_integrity_footer_hashes( ) ;
         GxWebStd.gx_hidden_field( context, sPrefix+"wcpOA225BR_MedicalImagingID", StringUtil.LTrim( StringUtil.NToC( (decimal)(wcpOA225BR_MedicalImagingID), 18, 0, ".", "")));
      }

      protected void RenderHtmlCloseForm4T2( )
      {
         SendCloseFormHiddens( ) ;
         if ( ( StringUtil.Len( sPrefix) != 0 ) && ( context.isAjaxRequest( ) || context.isSpaRequest( ) ) )
         {
            context.AddJavascriptSource("br_medicalimaginggeneral.js", "?20202281551156", false);
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
         return "BR_MedicalImagingGeneral" ;
      }

      public override String GetPgmdesc( )
      {
         return "BR_Medical Imaging General" ;
      }

      protected void WB4T0( )
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
               GxWebStd.gx_hidden_field( context, sPrefix+"_CMPPGM", "br_medicalimaginggeneral.aspx");
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
            GxWebStd.gx_div_start( context, divUnnamedtablebr_medicalimaging_no_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-4 MergeLabelCell", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblockbr_medicalimaging_no_Internalname, "编号", "", "", lblTextblockbr_medicalimaging_no_Jsonclick, "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_BR_MedicalImagingGeneral.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-8", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtBR_MedicalImaging_No_Internalname, "编号", "col-sm-3 ReadonlyAttributeLabel", 0, true);
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtBR_MedicalImaging_No_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A518BR_MedicalImaging_No), 18, 0, ".", "")), ((edtBR_MedicalImaging_No_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A518BR_MedicalImaging_No), "ZZZZZZZZZZZZZZZZZZ")) : context.localUtil.Format( (decimal)(A518BR_MedicalImaging_No), "ZZZZZZZZZZZZZZZZZZ")), "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBR_MedicalImaging_No_Jsonclick, 0, "ReadonlyAttribute", "", "", "", "", 1, edtBR_MedicalImaging_No_Enabled, 0, "number", "1", 18, "chr", 1, "row", 18, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_BR_MedicalImagingGeneral.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divUnnamedtablebr_medicalimaging_imagename_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-4 MergeLabelCell", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblockbr_medicalimaging_imagename_Internalname, "影像名称", "", "", lblTextblockbr_medicalimaging_imagename_Jsonclick, "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_BR_MedicalImagingGeneral.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-8", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtBR_MedicalImaging_ImageName_Internalname, "影像名称", "col-sm-3 ReadonlyAttributeLabel", 0, true);
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtBR_MedicalImaging_ImageName_Internalname, A228BR_MedicalImaging_ImageName, StringUtil.RTrim( context.localUtil.Format( A228BR_MedicalImaging_ImageName, "")), "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBR_MedicalImaging_ImageName_Jsonclick, 0, "ReadonlyAttribute", "", "", "", "", 1, edtBR_MedicalImaging_ImageName_Enabled, 0, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_BR_MedicalImagingGeneral.htm");
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
            GxWebStd.gx_div_start( context, divUnnamedtablebr_medicalimaging_imagedate_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-4 MergeLabelCell", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblockbr_medicalimaging_imagedate_Internalname, "检查日期", "", "", lblTextblockbr_medicalimaging_imagedate_Jsonclick, "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_BR_MedicalImagingGeneral.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-8", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtBR_MedicalImaging_ImageDate_Internalname, "检查日期", "col-sm-3 ReadonlyAttributeLabel", 0, true);
            /* Single line edit */
            context.WriteHtmlText( "<div id=\""+edtBR_MedicalImaging_ImageDate_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtBR_MedicalImaging_ImageDate_Internalname, context.localUtil.Format(A229BR_MedicalImaging_ImageDate, "9999/99/99"), context.localUtil.Format( A229BR_MedicalImaging_ImageDate, "9999/99/99"), "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBR_MedicalImaging_ImageDate_Jsonclick, 0, "ReadonlyAttribute", "", "", "", "", 1, edtBR_MedicalImaging_ImageDate_Enabled, 0, "text", "", 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, 0, true, "DM_Date", "right", false, "HLP_BR_MedicalImagingGeneral.htm");
            GxWebStd.gx_bitmap( context, edtBR_MedicalImaging_ImageDate_Internalname+"_dp_trigger", context.GetImagePath( "61b9b5d3-dff6-4d59-9b00-da61bc2cbe93", "", context.GetTheme( )), "", "", "", "", ((1==0)||(edtBR_MedicalImaging_ImageDate_Enabled==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;", "", "", "", "", "", "", "", "", 1, false, false, "", "HLP_BR_MedicalImagingGeneral.htm");
            context.WriteHtmlTextNl( "</div>") ;
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divUnnamedtablebr_medicalimaging_imagehosp_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-4 MergeLabelCell", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblockbr_medicalimaging_imagehosp_Internalname, "行检医院", "", "", lblTextblockbr_medicalimaging_imagehosp_Jsonclick, "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_BR_MedicalImagingGeneral.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-8", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtBR_MedicalImaging_ImageHosp_Internalname, "行检医院", "col-sm-3 ReadonlyAttributeLabel", 0, true);
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtBR_MedicalImaging_ImageHosp_Internalname, A230BR_MedicalImaging_ImageHosp, StringUtil.RTrim( context.localUtil.Format( A230BR_MedicalImaging_ImageHosp, "")), "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBR_MedicalImaging_ImageHosp_Jsonclick, 0, "ReadonlyAttribute", "", "", "", "", 1, edtBR_MedicalImaging_ImageHosp_Enabled, 0, "text", "", 40, "chr", 1, "row", 40, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_BR_MedicalImagingGeneral.htm");
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
            GxWebStd.gx_div_start( context, divUnnamedtablebr_medicalimaging_imageage_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-4 MergeLabelCell", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblockbr_medicalimaging_imageage_Internalname, "年龄", "", "", lblTextblockbr_medicalimaging_imageage_Jsonclick, "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_BR_MedicalImagingGeneral.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-8", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtBR_MedicalImaging_ImageAge_Internalname, "年龄", "col-sm-3 ReadonlyAttributeLabel", 0, true);
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtBR_MedicalImaging_ImageAge_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A231BR_MedicalImaging_ImageAge), 3, 0, ".", "")), ((edtBR_MedicalImaging_ImageAge_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A231BR_MedicalImaging_ImageAge), "ZZZ")) : context.localUtil.Format( (decimal)(A231BR_MedicalImaging_ImageAge), "ZZZ")), "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBR_MedicalImaging_ImageAge_Jsonclick, 0, "ReadonlyAttribute", "", "", "", "", 1, edtBR_MedicalImaging_ImageAge_Enabled, 0, "number", "1", 3, "chr", 1, "row", 3, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_BR_MedicalImagingGeneral.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divUnnamedtablebr_medicalimaging_tumorsize_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-4 MergeLabelCell", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblockbr_medicalimaging_tumorsize_Internalname, "肿瘤大小", "", "", lblTextblockbr_medicalimaging_tumorsize_Jsonclick, "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_BR_MedicalImagingGeneral.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-8", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtBR_MedicalImaging_TumorSize_Internalname, "肿瘤大小", "col-sm-3 ReadonlyAttributeLabel", 0, true);
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtBR_MedicalImaging_TumorSize_Internalname, A236BR_MedicalImaging_TumorSize, StringUtil.RTrim( context.localUtil.Format( A236BR_MedicalImaging_TumorSize, "")), "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBR_MedicalImaging_TumorSize_Jsonclick, 0, "ReadonlyAttribute", "", "", "", "", 1, edtBR_MedicalImaging_TumorSize_Enabled, 0, "text", "", 40, "chr", 1, "row", 40, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_BR_MedicalImagingGeneral.htm");
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
            GxWebStd.gx_div_start( context, divUnnamedtablebr_medicalimaging_metastasesdx_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-4 MergeLabelCell", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblockbr_medicalimaging_metastasesdx_Internalname, "是否有肿瘤转移", "", "", lblTextblockbr_medicalimaging_metastasesdx_Jsonclick, "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_BR_MedicalImagingGeneral.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-8", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, cmbBR_MedicalImaging_MetastasesDX_Internalname, "是否有肿瘤转移", "col-sm-3 ReadonlyAttributeLabel", 0, true);
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, cmbBR_MedicalImaging_MetastasesDX, cmbBR_MedicalImaging_MetastasesDX_Internalname, StringUtil.RTrim( A514BR_MedicalImaging_MetastasesDX), 1, cmbBR_MedicalImaging_MetastasesDX_Jsonclick, 0, "'"+sPrefix+"'"+",false,"+"'"+""+"'", "svchar", "", 1, cmbBR_MedicalImaging_MetastasesDX.Enabled, 0, 0, 0, "em", 0, "", "", "ReadonlyAttribute", "", "", "", "", true, "HLP_BR_MedicalImagingGeneral.htm");
            cmbBR_MedicalImaging_MetastasesDX.CurrentValue = StringUtil.RTrim( A514BR_MedicalImaging_MetastasesDX);
            context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, cmbBR_MedicalImaging_MetastasesDX_Internalname, "Values", (String)(cmbBR_MedicalImaging_MetastasesDX.ToJavascriptSource()), true);
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divBr_medicalimaging_metaloc_cell_Internalname, 1, 0, "px", 0, "px", divBr_medicalimaging_metaloc_cell_Class, "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divUnnamedtablebr_medicalimaging_metaloc_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-4 MergeLabelCell", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblockbr_medicalimaging_metaloc_Internalname, "肿瘤转移部位", "", "", lblTextblockbr_medicalimaging_metaloc_Jsonclick, "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_BR_MedicalImagingGeneral.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-8", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtBR_MedicalImaging_MetaLoc_Internalname, "肿瘤转移部位", "col-sm-3 ReadonlyAttributeLabel", 0, true);
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtBR_MedicalImaging_MetaLoc_Internalname, A515BR_MedicalImaging_MetaLoc, StringUtil.RTrim( context.localUtil.Format( A515BR_MedicalImaging_MetaLoc, "")), "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBR_MedicalImaging_MetaLoc_Jsonclick, 0, "ReadonlyAttribute", "", "", "", "", edtBR_MedicalImaging_MetaLoc_Visible, edtBR_MedicalImaging_MetaLoc_Enabled, 0, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_BR_MedicalImagingGeneral.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divBr_medicalimaging_metadate_cell_Internalname, 1, 0, "px", 0, "px", divBr_medicalimaging_metadate_cell_Class, "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divUnnamedtablebr_medicalimaging_metadate_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-4 MergeLabelCell", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblockbr_medicalimaging_metadate_Internalname, "肿瘤转移时间", "", "", lblTextblockbr_medicalimaging_metadate_Jsonclick, "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_BR_MedicalImagingGeneral.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-8", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtBR_MedicalImaging_MetaDate_Internalname, "肿瘤转移时间", "col-sm-3 ReadonlyAttributeLabel", 0, true);
            /* Single line edit */
            context.WriteHtmlText( "<div id=\""+edtBR_MedicalImaging_MetaDate_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtBR_MedicalImaging_MetaDate_Internalname, context.localUtil.Format(A516BR_MedicalImaging_MetaDate, "9999/99/99"), context.localUtil.Format( A516BR_MedicalImaging_MetaDate, "9999/99/99"), "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBR_MedicalImaging_MetaDate_Jsonclick, 0, "ReadonlyAttribute", "", "", "", "", edtBR_MedicalImaging_MetaDate_Visible, edtBR_MedicalImaging_MetaDate_Enabled, 0, "text", "", 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, 0, true, "DM_Date", "right", false, "HLP_BR_MedicalImagingGeneral.htm");
            GxWebStd.gx_bitmap( context, edtBR_MedicalImaging_MetaDate_Internalname+"_dp_trigger", context.GetImagePath( "61b9b5d3-dff6-4d59-9b00-da61bc2cbe93", "", context.GetTheme( )), "", "", "", "", ((edtBR_MedicalImaging_MetaDate_Visible==0)||(edtBR_MedicalImaging_MetaDate_Enabled==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;", "", "", "", "", "", "", "", "", 1, false, false, "", "HLP_BR_MedicalImagingGeneral.htm");
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
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divUnnamedtablebr_medicalimaging_preimagediag_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-2 MergeLabelCell", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblockbr_medicalimaging_preimagediag_Internalname, "影像前诊断", "", "", lblTextblockbr_medicalimaging_preimagediag_Jsonclick, "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_BR_MedicalImagingGeneral.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-10", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtBR_MedicalImaging_PreImageDiag_Internalname, "影像前诊断", "col-sm-3 ReadonlyAttributeLabel", 0, true);
            /* Multiple line edit */
            ClassString = "ReadonlyAttribute";
            StyleString = "";
            ClassString = "ReadonlyAttribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtBR_MedicalImaging_PreImageDiag_Internalname, A234BR_MedicalImaging_PreImageDiag, "", "", 0, 1, edtBR_MedicalImaging_PreImageDiag_Enabled, 0, 80, "chr", 10, "row", StyleString, ClassString, "", "", "4000", -1, 0, "", "", -1, true, "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_MedicalImagingGeneral.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divUnnamedtablebr_medicalimaging_imageloc_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-2 MergeLabelCell", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblockbr_medicalimaging_imageloc_Internalname, "检查部位(位置)", "", "", lblTextblockbr_medicalimaging_imageloc_Jsonclick, "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_BR_MedicalImagingGeneral.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-10", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtBR_MedicalImaging_ImageLoc_Internalname, "检查部位(位置)", "col-sm-3 ReadonlyAttributeLabel", 0, true);
            /* Multiple line edit */
            ClassString = "ReadonlyAttribute";
            StyleString = "";
            ClassString = "ReadonlyAttribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtBR_MedicalImaging_ImageLoc_Internalname, A232BR_MedicalImaging_ImageLoc, "", "", 0, 1, edtBR_MedicalImaging_ImageLoc_Enabled, 0, 80, "chr", 10, "row", StyleString, ClassString, "", "", "5000", -1, 0, "", "", -1, true, "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_MedicalImagingGeneral.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 DataContentCellNoWrap", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divUnnamedtablebr_medicalimaging_imageorgan_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-2 MergeLabelCell", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblockbr_medicalimaging_imageorgan_Internalname, "检查部位(器官)", "", "", lblTextblockbr_medicalimaging_imageorgan_Jsonclick, "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_BR_MedicalImagingGeneral.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-10", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtBR_MedicalImaging_ImageOrgan_Internalname, "检查部位(器官)", "col-sm-3 AttributeReadGrayLabel", 0, true);
            /* Multiple line edit */
            ClassString = "AttributeReadGray";
            StyleString = "";
            ClassString = "AttributeReadGray";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtBR_MedicalImaging_ImageOrgan_Internalname, A233BR_MedicalImaging_ImageOrgan, "", "", 0, 1, edtBR_MedicalImaging_ImageOrgan_Enabled, 0, 80, "chr", 10, "row", StyleString, ClassString, "", "", "5000", -1, 0, "", "", -1, true, "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_MedicalImagingGeneral.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 DataContentCellNoWrap", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divUnnamedtablebr_medicalimaging_imagedes_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-2 MergeLabelCell", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblockbr_medicalimaging_imagedes_Internalname, "图像描述", "", "", lblTextblockbr_medicalimaging_imagedes_Jsonclick, "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_BR_MedicalImagingGeneral.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-10", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtBR_MedicalImaging_ImageDes_Internalname, "图像描述", "col-sm-3 AttributeReadGrayLabel", 0, true);
            /* Multiple line edit */
            ClassString = "AttributeReadGray";
            StyleString = "";
            ClassString = "AttributeReadGray";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtBR_MedicalImaging_ImageDes_Internalname, A235BR_MedicalImaging_ImageDes, "", "", 0, 1, edtBR_MedicalImaging_ImageDes_Enabled, 0, 80, "chr", 10, "row", StyleString, ClassString, "", "", "9999", -1, 0, "", "", -1, true, "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_MedicalImagingGeneral.htm");
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
            GxWebStd.gx_single_line_edit( context, edtBR_MedicalImagingID_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A225BR_MedicalImagingID), 18, 0, ".", "")), context.localUtil.Format( (decimal)(A225BR_MedicalImagingID), "ZZZZZZZZZZZZZZZZZZ"), "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBR_MedicalImagingID_Jsonclick, 0, "Attribute", "", "", "", "", edtBR_MedicalImagingID_Visible, 0, 0, "number", "1", 18, "chr", 1, "row", 18, 0, 0, 0, 1, -1, 0, true, "ID", "right", false, "HLP_BR_MedicalImagingGeneral.htm");
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtBR_EncounterID_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A19BR_EncounterID), 18, 0, ".", "")), context.localUtil.Format( (decimal)(A19BR_EncounterID), "ZZZZZZZZZZZZZZZZZZ"), "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBR_EncounterID_Jsonclick, 0, "Attribute", "", "", "", "", edtBR_EncounterID_Visible, 0, 0, "number", "1", 18, "chr", 1, "row", 18, 0, 0, 0, 1, -1, 0, true, "ID", "right", false, "HLP_BR_MedicalImagingGeneral.htm");
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtBR_Information_PatientNo_Internalname, A36BR_Information_PatientNo, StringUtil.RTrim( context.localUtil.Format( A36BR_Information_PatientNo, "")), "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBR_Information_PatientNo_Jsonclick, 0, "Attribute", "", "", "", "", edtBR_Information_PatientNo_Visible, 0, 0, "text", "", 80, "chr", 1, "row", 2000, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_BR_MedicalImagingGeneral.htm");
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtBR_MedicalImaging_ID_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A227BR_MedicalImaging_ID), 10, 0, ".", "")), context.localUtil.Format( (decimal)(A227BR_MedicalImaging_ID), "ZZZZZZZZZZ"), "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBR_MedicalImaging_ID_Jsonclick, 0, "Attribute", "", "", "", "", edtBR_MedicalImaging_ID_Visible, 0, 0, "number", "1", 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_BR_MedicalImagingGeneral.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
         }
         wbLoad = true;
      }

      protected void START4T2( )
      {
         wbLoad = false;
         wbEnd = 0;
         wbStart = 0;
         if ( StringUtil.Len( sPrefix) == 0 )
         {
            if ( ! context.isSpaRequest( ) )
            {
               Form.Meta.addItem("generator", "GeneXus C# 16_0_0-127771", 0) ;
               Form.Meta.addItem("description", "BR_Medical Imaging General", 0) ;
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
               STRUP4T0( ) ;
            }
         }
      }

      protected void WS4T2( )
      {
         START4T2( ) ;
         EVT4T2( ) ;
      }

      protected void EVT4T2( )
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
                                 STRUP4T0( ) ;
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
                                 STRUP4T0( ) ;
                              }
                              if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
                              {
                                 context.wbHandled = 1;
                                 if ( ! wbErr )
                                 {
                                    dynload_actions( ) ;
                                    /* Execute user event: Start */
                                    E114T2 ();
                                 }
                              }
                           }
                           else if ( StringUtil.StrCmp(sEvt, "LOAD") == 0 )
                           {
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP4T0( ) ;
                              }
                              if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
                              {
                                 context.wbHandled = 1;
                                 if ( ! wbErr )
                                 {
                                    dynload_actions( ) ;
                                    /* Execute user event: Load */
                                    E124T2 ();
                                 }
                              }
                           }
                           else if ( StringUtil.StrCmp(sEvt, "ENTER") == 0 )
                           {
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP4T0( ) ;
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
                                 STRUP4T0( ) ;
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

      protected void WE4T2( )
      {
         if ( ! GxWebStd.gx_redirect( context) )
         {
            Rfr0gs = true;
            Refresh( ) ;
            if ( ! GxWebStd.gx_redirect( context) )
            {
               RenderHtmlCloseForm4T2( ) ;
            }
         }
      }

      protected void PA4T2( )
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
         if ( cmbBR_MedicalImaging_MetastasesDX.ItemCount > 0 )
         {
            A514BR_MedicalImaging_MetastasesDX = cmbBR_MedicalImaging_MetastasesDX.getValidValue(A514BR_MedicalImaging_MetastasesDX);
            n514BR_MedicalImaging_MetastasesDX = false;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A514BR_MedicalImaging_MetastasesDX", A514BR_MedicalImaging_MetastasesDX);
         }
         if ( context.isAjaxRequest( ) )
         {
            cmbBR_MedicalImaging_MetastasesDX.CurrentValue = StringUtil.RTrim( A514BR_MedicalImaging_MetastasesDX);
            context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, cmbBR_MedicalImaging_MetastasesDX_Internalname, "Values", cmbBR_MedicalImaging_MetastasesDX.ToJavascriptSource(), true);
         }
      }

      public void Refresh( )
      {
         send_integrity_hashes( ) ;
         RF4T2( ) ;
         if ( isFullAjaxMode( ) )
         {
            send_integrity_footer_hashes( ) ;
         }
      }

      protected void initialize_formulas( )
      {
         /* GeneXus formulas. */
         AV16Pgmname = "BR_MedicalImagingGeneral";
         context.Gx_err = 0;
      }

      protected void RF4T2( )
      {
         initialize_formulas( ) ;
         clear_multi_value_controls( ) ;
         gxdyncontrolsrefreshing = true;
         fix_multi_value_controls( ) ;
         gxdyncontrolsrefreshing = false;
         if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
         {
            /* Using cursor H004T2 */
            pr_default.execute(0, new Object[] {A225BR_MedicalImagingID});
            while ( (pr_default.getStatus(0) != 101) )
            {
               A85BR_Information_ID = H004T2_A85BR_Information_ID[0];
               n85BR_Information_ID = H004T2_n85BR_Information_ID[0];
               A227BR_MedicalImaging_ID = H004T2_A227BR_MedicalImaging_ID[0];
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A227BR_MedicalImaging_ID", StringUtil.LTrim( StringUtil.Str( (decimal)(A227BR_MedicalImaging_ID), 10, 0)));
               n227BR_MedicalImaging_ID = H004T2_n227BR_MedicalImaging_ID[0];
               A36BR_Information_PatientNo = H004T2_A36BR_Information_PatientNo[0];
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A36BR_Information_PatientNo", A36BR_Information_PatientNo);
               n36BR_Information_PatientNo = H004T2_n36BR_Information_PatientNo[0];
               A19BR_EncounterID = H004T2_A19BR_EncounterID[0];
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A19BR_EncounterID", StringUtil.LTrim( StringUtil.Str( (decimal)(A19BR_EncounterID), 18, 0)));
               n19BR_EncounterID = H004T2_n19BR_EncounterID[0];
               A235BR_MedicalImaging_ImageDes = H004T2_A235BR_MedicalImaging_ImageDes[0];
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A235BR_MedicalImaging_ImageDes", A235BR_MedicalImaging_ImageDes);
               n235BR_MedicalImaging_ImageDes = H004T2_n235BR_MedicalImaging_ImageDes[0];
               A233BR_MedicalImaging_ImageOrgan = H004T2_A233BR_MedicalImaging_ImageOrgan[0];
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A233BR_MedicalImaging_ImageOrgan", A233BR_MedicalImaging_ImageOrgan);
               n233BR_MedicalImaging_ImageOrgan = H004T2_n233BR_MedicalImaging_ImageOrgan[0];
               A232BR_MedicalImaging_ImageLoc = H004T2_A232BR_MedicalImaging_ImageLoc[0];
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A232BR_MedicalImaging_ImageLoc", A232BR_MedicalImaging_ImageLoc);
               n232BR_MedicalImaging_ImageLoc = H004T2_n232BR_MedicalImaging_ImageLoc[0];
               A234BR_MedicalImaging_PreImageDiag = H004T2_A234BR_MedicalImaging_PreImageDiag[0];
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A234BR_MedicalImaging_PreImageDiag", A234BR_MedicalImaging_PreImageDiag);
               n234BR_MedicalImaging_PreImageDiag = H004T2_n234BR_MedicalImaging_PreImageDiag[0];
               A516BR_MedicalImaging_MetaDate = H004T2_A516BR_MedicalImaging_MetaDate[0];
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A516BR_MedicalImaging_MetaDate", context.localUtil.Format(A516BR_MedicalImaging_MetaDate, "9999/99/99"));
               n516BR_MedicalImaging_MetaDate = H004T2_n516BR_MedicalImaging_MetaDate[0];
               A515BR_MedicalImaging_MetaLoc = H004T2_A515BR_MedicalImaging_MetaLoc[0];
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A515BR_MedicalImaging_MetaLoc", A515BR_MedicalImaging_MetaLoc);
               n515BR_MedicalImaging_MetaLoc = H004T2_n515BR_MedicalImaging_MetaLoc[0];
               A514BR_MedicalImaging_MetastasesDX = H004T2_A514BR_MedicalImaging_MetastasesDX[0];
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A514BR_MedicalImaging_MetastasesDX", A514BR_MedicalImaging_MetastasesDX);
               n514BR_MedicalImaging_MetastasesDX = H004T2_n514BR_MedicalImaging_MetastasesDX[0];
               A236BR_MedicalImaging_TumorSize = H004T2_A236BR_MedicalImaging_TumorSize[0];
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A236BR_MedicalImaging_TumorSize", A236BR_MedicalImaging_TumorSize);
               n236BR_MedicalImaging_TumorSize = H004T2_n236BR_MedicalImaging_TumorSize[0];
               A231BR_MedicalImaging_ImageAge = H004T2_A231BR_MedicalImaging_ImageAge[0];
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A231BR_MedicalImaging_ImageAge", StringUtil.LTrim( StringUtil.Str( (decimal)(A231BR_MedicalImaging_ImageAge), 3, 0)));
               n231BR_MedicalImaging_ImageAge = H004T2_n231BR_MedicalImaging_ImageAge[0];
               A230BR_MedicalImaging_ImageHosp = H004T2_A230BR_MedicalImaging_ImageHosp[0];
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A230BR_MedicalImaging_ImageHosp", A230BR_MedicalImaging_ImageHosp);
               n230BR_MedicalImaging_ImageHosp = H004T2_n230BR_MedicalImaging_ImageHosp[0];
               A229BR_MedicalImaging_ImageDate = H004T2_A229BR_MedicalImaging_ImageDate[0];
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A229BR_MedicalImaging_ImageDate", context.localUtil.Format(A229BR_MedicalImaging_ImageDate, "9999/99/99"));
               n229BR_MedicalImaging_ImageDate = H004T2_n229BR_MedicalImaging_ImageDate[0];
               A228BR_MedicalImaging_ImageName = H004T2_A228BR_MedicalImaging_ImageName[0];
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A228BR_MedicalImaging_ImageName", A228BR_MedicalImaging_ImageName);
               n228BR_MedicalImaging_ImageName = H004T2_n228BR_MedicalImaging_ImageName[0];
               A518BR_MedicalImaging_No = H004T2_A518BR_MedicalImaging_No[0];
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A518BR_MedicalImaging_No", StringUtil.LTrim( StringUtil.Str( (decimal)(A518BR_MedicalImaging_No), 18, 0)));
               n518BR_MedicalImaging_No = H004T2_n518BR_MedicalImaging_No[0];
               A85BR_Information_ID = H004T2_A85BR_Information_ID[0];
               n85BR_Information_ID = H004T2_n85BR_Information_ID[0];
               A36BR_Information_PatientNo = H004T2_A36BR_Information_PatientNo[0];
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A36BR_Information_PatientNo", A36BR_Information_PatientNo);
               n36BR_Information_PatientNo = H004T2_n36BR_Information_PatientNo[0];
               /* Execute user event: Load */
               E124T2 ();
               /* Exiting from a For First loop. */
               if (true) break;
            }
            pr_default.close(0);
            WB4T0( ) ;
         }
      }

      protected void send_integrity_lvl_hashes4T2( )
      {
      }

      protected void STRUP4T0( )
      {
         /* Before Start, stand alone formulas. */
         AV16Pgmname = "BR_MedicalImagingGeneral";
         context.Gx_err = 0;
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0;
         /* Execute user event: Start */
         E114T2 ();
         context.wbGlbDoneStart = 1;
         nDoneStart = 1;
         /* After Start, stand alone formulas. */
         sXEvt = cgiGet( "_EventName");
         if ( ! GetJustCreated( ) && ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 ) )
         {
            /* Read saved SDTs. */
            /* Read variables values. */
            A518BR_MedicalImaging_No = (long)(context.localUtil.CToN( cgiGet( edtBR_MedicalImaging_No_Internalname), ".", ","));
            n518BR_MedicalImaging_No = false;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A518BR_MedicalImaging_No", StringUtil.LTrim( StringUtil.Str( (decimal)(A518BR_MedicalImaging_No), 18, 0)));
            A228BR_MedicalImaging_ImageName = cgiGet( edtBR_MedicalImaging_ImageName_Internalname);
            n228BR_MedicalImaging_ImageName = false;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A228BR_MedicalImaging_ImageName", A228BR_MedicalImaging_ImageName);
            A229BR_MedicalImaging_ImageDate = context.localUtil.CToD( cgiGet( edtBR_MedicalImaging_ImageDate_Internalname), 0);
            n229BR_MedicalImaging_ImageDate = false;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A229BR_MedicalImaging_ImageDate", context.localUtil.Format(A229BR_MedicalImaging_ImageDate, "9999/99/99"));
            A230BR_MedicalImaging_ImageHosp = cgiGet( edtBR_MedicalImaging_ImageHosp_Internalname);
            n230BR_MedicalImaging_ImageHosp = false;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A230BR_MedicalImaging_ImageHosp", A230BR_MedicalImaging_ImageHosp);
            A231BR_MedicalImaging_ImageAge = (short)(context.localUtil.CToN( cgiGet( edtBR_MedicalImaging_ImageAge_Internalname), ".", ","));
            n231BR_MedicalImaging_ImageAge = false;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A231BR_MedicalImaging_ImageAge", StringUtil.LTrim( StringUtil.Str( (decimal)(A231BR_MedicalImaging_ImageAge), 3, 0)));
            A236BR_MedicalImaging_TumorSize = cgiGet( edtBR_MedicalImaging_TumorSize_Internalname);
            n236BR_MedicalImaging_TumorSize = false;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A236BR_MedicalImaging_TumorSize", A236BR_MedicalImaging_TumorSize);
            cmbBR_MedicalImaging_MetastasesDX.CurrentValue = cgiGet( cmbBR_MedicalImaging_MetastasesDX_Internalname);
            A514BR_MedicalImaging_MetastasesDX = cgiGet( cmbBR_MedicalImaging_MetastasesDX_Internalname);
            n514BR_MedicalImaging_MetastasesDX = false;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A514BR_MedicalImaging_MetastasesDX", A514BR_MedicalImaging_MetastasesDX);
            A515BR_MedicalImaging_MetaLoc = cgiGet( edtBR_MedicalImaging_MetaLoc_Internalname);
            n515BR_MedicalImaging_MetaLoc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A515BR_MedicalImaging_MetaLoc", A515BR_MedicalImaging_MetaLoc);
            A516BR_MedicalImaging_MetaDate = context.localUtil.CToD( cgiGet( edtBR_MedicalImaging_MetaDate_Internalname), 0);
            n516BR_MedicalImaging_MetaDate = false;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A516BR_MedicalImaging_MetaDate", context.localUtil.Format(A516BR_MedicalImaging_MetaDate, "9999/99/99"));
            A234BR_MedicalImaging_PreImageDiag = cgiGet( edtBR_MedicalImaging_PreImageDiag_Internalname);
            n234BR_MedicalImaging_PreImageDiag = false;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A234BR_MedicalImaging_PreImageDiag", A234BR_MedicalImaging_PreImageDiag);
            A232BR_MedicalImaging_ImageLoc = cgiGet( edtBR_MedicalImaging_ImageLoc_Internalname);
            n232BR_MedicalImaging_ImageLoc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A232BR_MedicalImaging_ImageLoc", A232BR_MedicalImaging_ImageLoc);
            A233BR_MedicalImaging_ImageOrgan = cgiGet( edtBR_MedicalImaging_ImageOrgan_Internalname);
            n233BR_MedicalImaging_ImageOrgan = false;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A233BR_MedicalImaging_ImageOrgan", A233BR_MedicalImaging_ImageOrgan);
            A235BR_MedicalImaging_ImageDes = cgiGet( edtBR_MedicalImaging_ImageDes_Internalname);
            n235BR_MedicalImaging_ImageDes = false;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A235BR_MedicalImaging_ImageDes", A235BR_MedicalImaging_ImageDes);
            A19BR_EncounterID = (long)(context.localUtil.CToN( cgiGet( edtBR_EncounterID_Internalname), ".", ","));
            n19BR_EncounterID = false;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A19BR_EncounterID", StringUtil.LTrim( StringUtil.Str( (decimal)(A19BR_EncounterID), 18, 0)));
            A36BR_Information_PatientNo = cgiGet( edtBR_Information_PatientNo_Internalname);
            n36BR_Information_PatientNo = false;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A36BR_Information_PatientNo", A36BR_Information_PatientNo);
            A227BR_MedicalImaging_ID = (long)(context.localUtil.CToN( cgiGet( edtBR_MedicalImaging_ID_Internalname), ".", ","));
            n227BR_MedicalImaging_ID = false;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A227BR_MedicalImaging_ID", StringUtil.LTrim( StringUtil.Str( (decimal)(A227BR_MedicalImaging_ID), 10, 0)));
            /* Read saved values. */
            wcpOA225BR_MedicalImagingID = (long)(context.localUtil.CToN( cgiGet( sPrefix+"wcpOA225BR_MedicalImagingID"), ".", ","));
            /* Read subfile selected row values. */
            /* Read hidden variables. */
            GXKey = Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
            forbiddenHiddens = sPrefix + "hsh" + "BR_MedicalImagingGeneral";
            A514BR_MedicalImaging_MetastasesDX = cgiGet( cmbBR_MedicalImaging_MetastasesDX_Internalname);
            n514BR_MedicalImaging_MetastasesDX = false;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A514BR_MedicalImaging_MetastasesDX", A514BR_MedicalImaging_MetastasesDX);
            forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( A514BR_MedicalImaging_MetastasesDX, ""));
            hsh = cgiGet( sPrefix+"hsh");
            if ( ! GXUtil.CheckEncryptedHash( forbiddenHiddens, hsh, GXKey) )
            {
               GXUtil.WriteLog("br_medicalimaginggeneral:[SecurityCheckFailed value for]"+"BR_MedicalImaging_MetastasesDX:"+StringUtil.RTrim( context.localUtil.Format( A514BR_MedicalImaging_MetastasesDX, "")));
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
         E114T2 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E114T2( )
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

      protected void E124T2( )
      {
         /* Load Routine */
         edtBR_MedicalImagingID_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtBR_MedicalImagingID_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBR_MedicalImagingID_Visible), 5, 0)), true);
         edtBR_EncounterID_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtBR_EncounterID_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBR_EncounterID_Visible), 5, 0)), true);
         edtBR_Information_PatientNo_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtBR_Information_PatientNo_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBR_Information_PatientNo_Visible), 5, 0)), true);
         edtBR_MedicalImaging_ID_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtBR_MedicalImaging_ID_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBR_MedicalImaging_ID_Visible), 5, 0)), true);
         if ( ! ( ( StringUtil.StrCmp(A514BR_MedicalImaging_MetastasesDX, "是") == 0 ) ) )
         {
            edtBR_MedicalImaging_MetaLoc_Visible = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtBR_MedicalImaging_MetaLoc_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBR_MedicalImaging_MetaLoc_Visible), 5, 0)), true);
            divBr_medicalimaging_metaloc_cell_Class = "Invisible";
            context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, divBr_medicalimaging_metaloc_cell_Internalname, "Class", divBr_medicalimaging_metaloc_cell_Class, true);
         }
         else
         {
            edtBR_MedicalImaging_MetaLoc_Visible = 1;
            context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtBR_MedicalImaging_MetaLoc_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBR_MedicalImaging_MetaLoc_Visible), 5, 0)), true);
            divBr_medicalimaging_metaloc_cell_Class = "col-xs-12 col-sm-6 DataContentCell";
            context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, divBr_medicalimaging_metaloc_cell_Internalname, "Class", divBr_medicalimaging_metaloc_cell_Class, true);
         }
         if ( ! ( ( StringUtil.StrCmp(A514BR_MedicalImaging_MetastasesDX, "是") == 0 ) ) )
         {
            edtBR_MedicalImaging_MetaDate_Visible = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtBR_MedicalImaging_MetaDate_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBR_MedicalImaging_MetaDate_Visible), 5, 0)), true);
            divBr_medicalimaging_metadate_cell_Class = "Invisible";
            context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, divBr_medicalimaging_metadate_cell_Internalname, "Class", divBr_medicalimaging_metadate_cell_Class, true);
         }
         else
         {
            edtBR_MedicalImaging_MetaDate_Visible = 1;
            context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtBR_MedicalImaging_MetaDate_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBR_MedicalImaging_MetaDate_Visible), 5, 0)), true);
            divBr_medicalimaging_metadate_cell_Class = "col-xs-12 col-sm-6 DataContentCell";
            context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, divBr_medicalimaging_metadate_cell_Internalname, "Class", divBr_medicalimaging_metadate_cell_Class, true);
         }
      }

      protected void S112( )
      {
         /* 'PREPARETRANSACTION' Routine */
         AV9TrnContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext(context);
         AV9TrnContext.gxTpr_Callerobject = AV16Pgmname;
         AV9TrnContext.gxTpr_Callerondelete = false;
         AV9TrnContext.gxTpr_Callerurl = AV12HTTPRequest.ScriptName+"?"+AV12HTTPRequest.QueryString;
         AV9TrnContext.gxTpr_Transactionname = "BR_MedicalImaging";
         AV10TrnContextAtt = new GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext_Attribute(context);
         AV10TrnContextAtt.gxTpr_Attributename = "BR_MedicalImagingID";
         AV10TrnContextAtt.gxTpr_Attributevalue = StringUtil.Str( (decimal)(AV8BR_MedicalImagingID), 18, 0);
         AV9TrnContext.gxTpr_Attributes.Add(AV10TrnContextAtt, 0);
         AV11Session.Set("TrnContext", AV9TrnContext.ToXml(false, true, "WWPTransactionContext", "DataAnalysisPlatform"));
      }

      public override void setparameters( Object[] obj )
      {
         createObjects();
         initialize();
         A225BR_MedicalImagingID = Convert.ToInt64(getParm(obj,0));
         context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A225BR_MedicalImagingID", StringUtil.LTrim( StringUtil.Str( (decimal)(A225BR_MedicalImagingID), 18, 0)));
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
         PA4T2( ) ;
         WS4T2( ) ;
         WE4T2( ) ;
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
         sCtrlA225BR_MedicalImagingID = (String)((String)getParm(obj,0));
      }

      public override void componentrestorestate( String sPPrefix ,
                                                  String sPSFPrefix )
      {
         sPrefix = sPPrefix + sPSFPrefix;
         PA4T2( ) ;
         WCParametersGet( ) ;
      }

      public override void componentprepare( Object[] obj )
      {
         wbLoad = false;
         sCompPrefix = (String)getParm(obj,0);
         sSFPrefix = (String)getParm(obj,1);
         sPrefix = sCompPrefix + sSFPrefix;
         AddComponentObject(sPrefix, "br_medicalimaginggeneral", GetJustCreated( ));
         if ( ( nDoneStart == 0 ) && ( nDynComponent == 0 ) )
         {
            INITWEB( ) ;
         }
         else
         {
            init_default_properties( ) ;
            init_web_controls( ) ;
         }
         PA4T2( ) ;
         if ( ! GetJustCreated( ) && ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 ) && ( context.wbGlbDoneStart == 0 ) )
         {
            WCParametersGet( ) ;
         }
         else
         {
            A225BR_MedicalImagingID = Convert.ToInt64(getParm(obj,2));
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A225BR_MedicalImagingID", StringUtil.LTrim( StringUtil.Str( (decimal)(A225BR_MedicalImagingID), 18, 0)));
         }
         wcpOA225BR_MedicalImagingID = (long)(context.localUtil.CToN( cgiGet( sPrefix+"wcpOA225BR_MedicalImagingID"), ".", ","));
         if ( ! GetJustCreated( ) && ( ( A225BR_MedicalImagingID != wcpOA225BR_MedicalImagingID ) ) )
         {
            setjustcreated();
         }
         wcpOA225BR_MedicalImagingID = A225BR_MedicalImagingID;
      }

      protected void WCParametersGet( )
      {
         /* Read Component Parameters. */
         sCtrlA225BR_MedicalImagingID = cgiGet( sPrefix+"A225BR_MedicalImagingID_CTRL");
         if ( StringUtil.Len( sCtrlA225BR_MedicalImagingID) > 0 )
         {
            A225BR_MedicalImagingID = (long)(context.localUtil.CToN( cgiGet( sCtrlA225BR_MedicalImagingID), ".", ","));
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A225BR_MedicalImagingID", StringUtil.LTrim( StringUtil.Str( (decimal)(A225BR_MedicalImagingID), 18, 0)));
         }
         else
         {
            A225BR_MedicalImagingID = (long)(context.localUtil.CToN( cgiGet( sPrefix+"A225BR_MedicalImagingID_PARM"), ".", ","));
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
         PA4T2( ) ;
         sEvt = sCompEvt;
         WCParametersGet( ) ;
         WS4T2( ) ;
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
         WS4T2( ) ;
         SaveComponentMsgList(sPrefix);
         context.GX_msglist = BackMsgLst;
      }

      protected void WCParametersSet( )
      {
         GxWebStd.gx_hidden_field( context, sPrefix+"A225BR_MedicalImagingID_PARM", StringUtil.LTrim( StringUtil.NToC( (decimal)(A225BR_MedicalImagingID), 18, 0, ".", "")));
         if ( StringUtil.Len( StringUtil.RTrim( sCtrlA225BR_MedicalImagingID)) > 0 )
         {
            GxWebStd.gx_hidden_field( context, sPrefix+"A225BR_MedicalImagingID_CTRL", StringUtil.RTrim( sCtrlA225BR_MedicalImagingID));
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
         WE4T2( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?2020228155148", true);
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
            context.AddJavascriptSource("br_medicalimaginggeneral.js", "?2020228155149", false);
         }
         /* End function include_jscripts */
      }

      protected void init_web_controls( )
      {
         cmbBR_MedicalImaging_MetastasesDX.Name = "BR_MEDICALIMAGING_METASTASESDX";
         cmbBR_MedicalImaging_MetastasesDX.WebTags = "";
         cmbBR_MedicalImaging_MetastasesDX.addItem("", "(请选择)", 0);
         cmbBR_MedicalImaging_MetastasesDX.addItem("否", "否", 0);
         cmbBR_MedicalImaging_MetastasesDX.addItem("是", "是", 0);
         cmbBR_MedicalImaging_MetastasesDX.addItem("不详", "不详", 0);
         if ( cmbBR_MedicalImaging_MetastasesDX.ItemCount > 0 )
         {
         }
         /* End function init_web_controls */
      }

      protected void init_default_properties( )
      {
         lblTextblockbr_medicalimaging_no_Internalname = sPrefix+"TEXTBLOCKBR_MEDICALIMAGING_NO";
         edtBR_MedicalImaging_No_Internalname = sPrefix+"BR_MEDICALIMAGING_NO";
         divUnnamedtablebr_medicalimaging_no_Internalname = sPrefix+"UNNAMEDTABLEBR_MEDICALIMAGING_NO";
         lblTextblockbr_medicalimaging_imagename_Internalname = sPrefix+"TEXTBLOCKBR_MEDICALIMAGING_IMAGENAME";
         edtBR_MedicalImaging_ImageName_Internalname = sPrefix+"BR_MEDICALIMAGING_IMAGENAME";
         divUnnamedtablebr_medicalimaging_imagename_Internalname = sPrefix+"UNNAMEDTABLEBR_MEDICALIMAGING_IMAGENAME";
         lblTextblockbr_medicalimaging_imagedate_Internalname = sPrefix+"TEXTBLOCKBR_MEDICALIMAGING_IMAGEDATE";
         edtBR_MedicalImaging_ImageDate_Internalname = sPrefix+"BR_MEDICALIMAGING_IMAGEDATE";
         divUnnamedtablebr_medicalimaging_imagedate_Internalname = sPrefix+"UNNAMEDTABLEBR_MEDICALIMAGING_IMAGEDATE";
         lblTextblockbr_medicalimaging_imagehosp_Internalname = sPrefix+"TEXTBLOCKBR_MEDICALIMAGING_IMAGEHOSP";
         edtBR_MedicalImaging_ImageHosp_Internalname = sPrefix+"BR_MEDICALIMAGING_IMAGEHOSP";
         divUnnamedtablebr_medicalimaging_imagehosp_Internalname = sPrefix+"UNNAMEDTABLEBR_MEDICALIMAGING_IMAGEHOSP";
         lblTextblockbr_medicalimaging_imageage_Internalname = sPrefix+"TEXTBLOCKBR_MEDICALIMAGING_IMAGEAGE";
         edtBR_MedicalImaging_ImageAge_Internalname = sPrefix+"BR_MEDICALIMAGING_IMAGEAGE";
         divUnnamedtablebr_medicalimaging_imageage_Internalname = sPrefix+"UNNAMEDTABLEBR_MEDICALIMAGING_IMAGEAGE";
         lblTextblockbr_medicalimaging_tumorsize_Internalname = sPrefix+"TEXTBLOCKBR_MEDICALIMAGING_TUMORSIZE";
         edtBR_MedicalImaging_TumorSize_Internalname = sPrefix+"BR_MEDICALIMAGING_TUMORSIZE";
         divUnnamedtablebr_medicalimaging_tumorsize_Internalname = sPrefix+"UNNAMEDTABLEBR_MEDICALIMAGING_TUMORSIZE";
         lblTextblockbr_medicalimaging_metastasesdx_Internalname = sPrefix+"TEXTBLOCKBR_MEDICALIMAGING_METASTASESDX";
         cmbBR_MedicalImaging_MetastasesDX_Internalname = sPrefix+"BR_MEDICALIMAGING_METASTASESDX";
         divUnnamedtablebr_medicalimaging_metastasesdx_Internalname = sPrefix+"UNNAMEDTABLEBR_MEDICALIMAGING_METASTASESDX";
         lblTextblockbr_medicalimaging_metaloc_Internalname = sPrefix+"TEXTBLOCKBR_MEDICALIMAGING_METALOC";
         edtBR_MedicalImaging_MetaLoc_Internalname = sPrefix+"BR_MEDICALIMAGING_METALOC";
         divUnnamedtablebr_medicalimaging_metaloc_Internalname = sPrefix+"UNNAMEDTABLEBR_MEDICALIMAGING_METALOC";
         divBr_medicalimaging_metaloc_cell_Internalname = sPrefix+"BR_MEDICALIMAGING_METALOC_CELL";
         lblTextblockbr_medicalimaging_metadate_Internalname = sPrefix+"TEXTBLOCKBR_MEDICALIMAGING_METADATE";
         edtBR_MedicalImaging_MetaDate_Internalname = sPrefix+"BR_MEDICALIMAGING_METADATE";
         divUnnamedtablebr_medicalimaging_metadate_Internalname = sPrefix+"UNNAMEDTABLEBR_MEDICALIMAGING_METADATE";
         divBr_medicalimaging_metadate_cell_Internalname = sPrefix+"BR_MEDICALIMAGING_METADATE_CELL";
         lblTextblockbr_medicalimaging_preimagediag_Internalname = sPrefix+"TEXTBLOCKBR_MEDICALIMAGING_PREIMAGEDIAG";
         edtBR_MedicalImaging_PreImageDiag_Internalname = sPrefix+"BR_MEDICALIMAGING_PREIMAGEDIAG";
         divUnnamedtablebr_medicalimaging_preimagediag_Internalname = sPrefix+"UNNAMEDTABLEBR_MEDICALIMAGING_PREIMAGEDIAG";
         lblTextblockbr_medicalimaging_imageloc_Internalname = sPrefix+"TEXTBLOCKBR_MEDICALIMAGING_IMAGELOC";
         edtBR_MedicalImaging_ImageLoc_Internalname = sPrefix+"BR_MEDICALIMAGING_IMAGELOC";
         divUnnamedtablebr_medicalimaging_imageloc_Internalname = sPrefix+"UNNAMEDTABLEBR_MEDICALIMAGING_IMAGELOC";
         lblTextblockbr_medicalimaging_imageorgan_Internalname = sPrefix+"TEXTBLOCKBR_MEDICALIMAGING_IMAGEORGAN";
         edtBR_MedicalImaging_ImageOrgan_Internalname = sPrefix+"BR_MEDICALIMAGING_IMAGEORGAN";
         divUnnamedtablebr_medicalimaging_imageorgan_Internalname = sPrefix+"UNNAMEDTABLEBR_MEDICALIMAGING_IMAGEORGAN";
         lblTextblockbr_medicalimaging_imagedes_Internalname = sPrefix+"TEXTBLOCKBR_MEDICALIMAGING_IMAGEDES";
         edtBR_MedicalImaging_ImageDes_Internalname = sPrefix+"BR_MEDICALIMAGING_IMAGEDES";
         divUnnamedtablebr_medicalimaging_imagedes_Internalname = sPrefix+"UNNAMEDTABLEBR_MEDICALIMAGING_IMAGEDES";
         divTransactiondetail_tableattributes_Internalname = sPrefix+"TRANSACTIONDETAIL_TABLEATTRIBUTES";
         divTable_Internalname = sPrefix+"TABLE";
         edtBR_MedicalImagingID_Internalname = sPrefix+"BR_MEDICALIMAGINGID";
         edtBR_EncounterID_Internalname = sPrefix+"BR_ENCOUNTERID";
         edtBR_Information_PatientNo_Internalname = sPrefix+"BR_INFORMATION_PATIENTNO";
         edtBR_MedicalImaging_ID_Internalname = sPrefix+"BR_MEDICALIMAGING_ID";
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
         edtBR_MedicalImaging_ID_Jsonclick = "";
         edtBR_MedicalImaging_ID_Visible = 1;
         edtBR_Information_PatientNo_Jsonclick = "";
         edtBR_Information_PatientNo_Visible = 1;
         edtBR_EncounterID_Jsonclick = "";
         edtBR_EncounterID_Visible = 1;
         edtBR_MedicalImagingID_Jsonclick = "";
         edtBR_MedicalImagingID_Visible = 1;
         edtBR_MedicalImaging_ImageDes_Enabled = 0;
         edtBR_MedicalImaging_ImageOrgan_Enabled = 0;
         edtBR_MedicalImaging_ImageLoc_Enabled = 0;
         edtBR_MedicalImaging_PreImageDiag_Enabled = 0;
         edtBR_MedicalImaging_MetaDate_Jsonclick = "";
         edtBR_MedicalImaging_MetaDate_Enabled = 0;
         edtBR_MedicalImaging_MetaDate_Visible = 1;
         divBr_medicalimaging_metadate_cell_Class = "col-xs-12 col-sm-6";
         edtBR_MedicalImaging_MetaLoc_Jsonclick = "";
         edtBR_MedicalImaging_MetaLoc_Enabled = 0;
         edtBR_MedicalImaging_MetaLoc_Visible = 1;
         divBr_medicalimaging_metaloc_cell_Class = "col-xs-12 col-sm-6";
         cmbBR_MedicalImaging_MetastasesDX_Jsonclick = "";
         cmbBR_MedicalImaging_MetastasesDX.Enabled = 0;
         edtBR_MedicalImaging_TumorSize_Jsonclick = "";
         edtBR_MedicalImaging_TumorSize_Enabled = 0;
         edtBR_MedicalImaging_ImageAge_Jsonclick = "";
         edtBR_MedicalImaging_ImageAge_Enabled = 0;
         edtBR_MedicalImaging_ImageHosp_Jsonclick = "";
         edtBR_MedicalImaging_ImageHosp_Enabled = 0;
         edtBR_MedicalImaging_ImageDate_Jsonclick = "";
         edtBR_MedicalImaging_ImageDate_Enabled = 0;
         edtBR_MedicalImaging_ImageName_Jsonclick = "";
         edtBR_MedicalImaging_ImageName_Enabled = 0;
         edtBR_MedicalImaging_No_Jsonclick = "";
         edtBR_MedicalImaging_No_Enabled = 0;
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
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[{av:'cmbBR_MedicalImaging_MetastasesDX'},{av:'A514BR_MedicalImaging_MetastasesDX',fld:'BR_MEDICALIMAGING_METASTASESDX',pic:''}]");
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
         A514BR_MedicalImaging_MetastasesDX = "";
         GX_FocusControl = "";
         lblTextblockbr_medicalimaging_no_Jsonclick = "";
         lblTextblockbr_medicalimaging_imagename_Jsonclick = "";
         A228BR_MedicalImaging_ImageName = "";
         lblTextblockbr_medicalimaging_imagedate_Jsonclick = "";
         A229BR_MedicalImaging_ImageDate = DateTime.MinValue;
         lblTextblockbr_medicalimaging_imagehosp_Jsonclick = "";
         A230BR_MedicalImaging_ImageHosp = "";
         lblTextblockbr_medicalimaging_imageage_Jsonclick = "";
         lblTextblockbr_medicalimaging_tumorsize_Jsonclick = "";
         A236BR_MedicalImaging_TumorSize = "";
         lblTextblockbr_medicalimaging_metastasesdx_Jsonclick = "";
         lblTextblockbr_medicalimaging_metaloc_Jsonclick = "";
         A515BR_MedicalImaging_MetaLoc = "";
         lblTextblockbr_medicalimaging_metadate_Jsonclick = "";
         A516BR_MedicalImaging_MetaDate = DateTime.MinValue;
         lblTextblockbr_medicalimaging_preimagediag_Jsonclick = "";
         ClassString = "";
         StyleString = "";
         A234BR_MedicalImaging_PreImageDiag = "";
         lblTextblockbr_medicalimaging_imageloc_Jsonclick = "";
         A232BR_MedicalImaging_ImageLoc = "";
         lblTextblockbr_medicalimaging_imageorgan_Jsonclick = "";
         A233BR_MedicalImaging_ImageOrgan = "";
         lblTextblockbr_medicalimaging_imagedes_Jsonclick = "";
         A235BR_MedicalImaging_ImageDes = "";
         A36BR_Information_PatientNo = "";
         Form = new GXWebForm();
         sXEvt = "";
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         scmdbuf = "";
         H004T2_A85BR_Information_ID = new long[1] ;
         H004T2_n85BR_Information_ID = new bool[] {false} ;
         H004T2_A225BR_MedicalImagingID = new long[1] ;
         H004T2_A227BR_MedicalImaging_ID = new long[1] ;
         H004T2_n227BR_MedicalImaging_ID = new bool[] {false} ;
         H004T2_A36BR_Information_PatientNo = new String[] {""} ;
         H004T2_n36BR_Information_PatientNo = new bool[] {false} ;
         H004T2_A19BR_EncounterID = new long[1] ;
         H004T2_n19BR_EncounterID = new bool[] {false} ;
         H004T2_A235BR_MedicalImaging_ImageDes = new String[] {""} ;
         H004T2_n235BR_MedicalImaging_ImageDes = new bool[] {false} ;
         H004T2_A233BR_MedicalImaging_ImageOrgan = new String[] {""} ;
         H004T2_n233BR_MedicalImaging_ImageOrgan = new bool[] {false} ;
         H004T2_A232BR_MedicalImaging_ImageLoc = new String[] {""} ;
         H004T2_n232BR_MedicalImaging_ImageLoc = new bool[] {false} ;
         H004T2_A234BR_MedicalImaging_PreImageDiag = new String[] {""} ;
         H004T2_n234BR_MedicalImaging_PreImageDiag = new bool[] {false} ;
         H004T2_A516BR_MedicalImaging_MetaDate = new DateTime[] {DateTime.MinValue} ;
         H004T2_n516BR_MedicalImaging_MetaDate = new bool[] {false} ;
         H004T2_A515BR_MedicalImaging_MetaLoc = new String[] {""} ;
         H004T2_n515BR_MedicalImaging_MetaLoc = new bool[] {false} ;
         H004T2_A514BR_MedicalImaging_MetastasesDX = new String[] {""} ;
         H004T2_n514BR_MedicalImaging_MetastasesDX = new bool[] {false} ;
         H004T2_A236BR_MedicalImaging_TumorSize = new String[] {""} ;
         H004T2_n236BR_MedicalImaging_TumorSize = new bool[] {false} ;
         H004T2_A231BR_MedicalImaging_ImageAge = new short[1] ;
         H004T2_n231BR_MedicalImaging_ImageAge = new bool[] {false} ;
         H004T2_A230BR_MedicalImaging_ImageHosp = new String[] {""} ;
         H004T2_n230BR_MedicalImaging_ImageHosp = new bool[] {false} ;
         H004T2_A229BR_MedicalImaging_ImageDate = new DateTime[] {DateTime.MinValue} ;
         H004T2_n229BR_MedicalImaging_ImageDate = new bool[] {false} ;
         H004T2_A228BR_MedicalImaging_ImageName = new String[] {""} ;
         H004T2_n228BR_MedicalImaging_ImageName = new bool[] {false} ;
         H004T2_A518BR_MedicalImaging_No = new long[1] ;
         H004T2_n518BR_MedicalImaging_No = new bool[] {false} ;
         hsh = "";
         AV6WWPContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPContext(context);
         AV9TrnContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext(context);
         AV12HTTPRequest = new GxHttpRequest( context);
         AV10TrnContextAtt = new GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext_Attribute(context);
         AV11Session = context.GetSession();
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         sCtrlA225BR_MedicalImagingID = "";
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.br_medicalimaginggeneral__default(),
            new Object[][] {
                new Object[] {
               H004T2_A85BR_Information_ID, H004T2_n85BR_Information_ID, H004T2_A225BR_MedicalImagingID, H004T2_A227BR_MedicalImaging_ID, H004T2_n227BR_MedicalImaging_ID, H004T2_A36BR_Information_PatientNo, H004T2_n36BR_Information_PatientNo, H004T2_A19BR_EncounterID, H004T2_n19BR_EncounterID, H004T2_A235BR_MedicalImaging_ImageDes,
               H004T2_n235BR_MedicalImaging_ImageDes, H004T2_A233BR_MedicalImaging_ImageOrgan, H004T2_n233BR_MedicalImaging_ImageOrgan, H004T2_A232BR_MedicalImaging_ImageLoc, H004T2_n232BR_MedicalImaging_ImageLoc, H004T2_A234BR_MedicalImaging_PreImageDiag, H004T2_n234BR_MedicalImaging_PreImageDiag, H004T2_A516BR_MedicalImaging_MetaDate, H004T2_n516BR_MedicalImaging_MetaDate, H004T2_A515BR_MedicalImaging_MetaLoc,
               H004T2_n515BR_MedicalImaging_MetaLoc, H004T2_A514BR_MedicalImaging_MetastasesDX, H004T2_n514BR_MedicalImaging_MetastasesDX, H004T2_A236BR_MedicalImaging_TumorSize, H004T2_n236BR_MedicalImaging_TumorSize, H004T2_A231BR_MedicalImaging_ImageAge, H004T2_n231BR_MedicalImaging_ImageAge, H004T2_A230BR_MedicalImaging_ImageHosp, H004T2_n230BR_MedicalImaging_ImageHosp, H004T2_A229BR_MedicalImaging_ImageDate,
               H004T2_n229BR_MedicalImaging_ImageDate, H004T2_A228BR_MedicalImaging_ImageName, H004T2_n228BR_MedicalImaging_ImageName, H004T2_A518BR_MedicalImaging_No, H004T2_n518BR_MedicalImaging_No
               }
            }
         );
         AV16Pgmname = "BR_MedicalImagingGeneral";
         /* GeneXus formulas. */
         AV16Pgmname = "BR_MedicalImagingGeneral";
         context.Gx_err = 0;
      }

      private short nGotPars ;
      private short GxWebError ;
      private short nDynComponent ;
      private short initialized ;
      private short nGXWrapped ;
      private short wbEnd ;
      private short wbStart ;
      private short A231BR_MedicalImaging_ImageAge ;
      private short nDraw ;
      private short nDoneStart ;
      private short nDonePA ;
      private short gxcookieaux ;
      private int edtBR_MedicalImaging_No_Enabled ;
      private int edtBR_MedicalImaging_ImageName_Enabled ;
      private int edtBR_MedicalImaging_ImageDate_Enabled ;
      private int edtBR_MedicalImaging_ImageHosp_Enabled ;
      private int edtBR_MedicalImaging_ImageAge_Enabled ;
      private int edtBR_MedicalImaging_TumorSize_Enabled ;
      private int edtBR_MedicalImaging_MetaLoc_Visible ;
      private int edtBR_MedicalImaging_MetaLoc_Enabled ;
      private int edtBR_MedicalImaging_MetaDate_Visible ;
      private int edtBR_MedicalImaging_MetaDate_Enabled ;
      private int edtBR_MedicalImaging_PreImageDiag_Enabled ;
      private int edtBR_MedicalImaging_ImageLoc_Enabled ;
      private int edtBR_MedicalImaging_ImageOrgan_Enabled ;
      private int edtBR_MedicalImaging_ImageDes_Enabled ;
      private int edtBR_MedicalImagingID_Visible ;
      private int edtBR_EncounterID_Visible ;
      private int edtBR_Information_PatientNo_Visible ;
      private int edtBR_MedicalImaging_ID_Visible ;
      private int idxLst ;
      private long A225BR_MedicalImagingID ;
      private long wcpOA225BR_MedicalImagingID ;
      private long A518BR_MedicalImaging_No ;
      private long A19BR_EncounterID ;
      private long A227BR_MedicalImaging_ID ;
      private long A85BR_Information_ID ;
      private long AV8BR_MedicalImagingID ;
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
      private String divUnnamedtablebr_medicalimaging_no_Internalname ;
      private String lblTextblockbr_medicalimaging_no_Internalname ;
      private String lblTextblockbr_medicalimaging_no_Jsonclick ;
      private String edtBR_MedicalImaging_No_Internalname ;
      private String edtBR_MedicalImaging_No_Jsonclick ;
      private String divUnnamedtablebr_medicalimaging_imagename_Internalname ;
      private String lblTextblockbr_medicalimaging_imagename_Internalname ;
      private String lblTextblockbr_medicalimaging_imagename_Jsonclick ;
      private String edtBR_MedicalImaging_ImageName_Internalname ;
      private String edtBR_MedicalImaging_ImageName_Jsonclick ;
      private String divUnnamedtablebr_medicalimaging_imagedate_Internalname ;
      private String lblTextblockbr_medicalimaging_imagedate_Internalname ;
      private String lblTextblockbr_medicalimaging_imagedate_Jsonclick ;
      private String edtBR_MedicalImaging_ImageDate_Internalname ;
      private String edtBR_MedicalImaging_ImageDate_Jsonclick ;
      private String divUnnamedtablebr_medicalimaging_imagehosp_Internalname ;
      private String lblTextblockbr_medicalimaging_imagehosp_Internalname ;
      private String lblTextblockbr_medicalimaging_imagehosp_Jsonclick ;
      private String edtBR_MedicalImaging_ImageHosp_Internalname ;
      private String edtBR_MedicalImaging_ImageHosp_Jsonclick ;
      private String divUnnamedtablebr_medicalimaging_imageage_Internalname ;
      private String lblTextblockbr_medicalimaging_imageage_Internalname ;
      private String lblTextblockbr_medicalimaging_imageage_Jsonclick ;
      private String edtBR_MedicalImaging_ImageAge_Internalname ;
      private String edtBR_MedicalImaging_ImageAge_Jsonclick ;
      private String divUnnamedtablebr_medicalimaging_tumorsize_Internalname ;
      private String lblTextblockbr_medicalimaging_tumorsize_Internalname ;
      private String lblTextblockbr_medicalimaging_tumorsize_Jsonclick ;
      private String edtBR_MedicalImaging_TumorSize_Internalname ;
      private String edtBR_MedicalImaging_TumorSize_Jsonclick ;
      private String divUnnamedtablebr_medicalimaging_metastasesdx_Internalname ;
      private String lblTextblockbr_medicalimaging_metastasesdx_Internalname ;
      private String lblTextblockbr_medicalimaging_metastasesdx_Jsonclick ;
      private String cmbBR_MedicalImaging_MetastasesDX_Internalname ;
      private String cmbBR_MedicalImaging_MetastasesDX_Jsonclick ;
      private String divBr_medicalimaging_metaloc_cell_Internalname ;
      private String divBr_medicalimaging_metaloc_cell_Class ;
      private String divUnnamedtablebr_medicalimaging_metaloc_Internalname ;
      private String lblTextblockbr_medicalimaging_metaloc_Internalname ;
      private String lblTextblockbr_medicalimaging_metaloc_Jsonclick ;
      private String edtBR_MedicalImaging_MetaLoc_Internalname ;
      private String edtBR_MedicalImaging_MetaLoc_Jsonclick ;
      private String divBr_medicalimaging_metadate_cell_Internalname ;
      private String divBr_medicalimaging_metadate_cell_Class ;
      private String divUnnamedtablebr_medicalimaging_metadate_Internalname ;
      private String lblTextblockbr_medicalimaging_metadate_Internalname ;
      private String lblTextblockbr_medicalimaging_metadate_Jsonclick ;
      private String edtBR_MedicalImaging_MetaDate_Internalname ;
      private String edtBR_MedicalImaging_MetaDate_Jsonclick ;
      private String divUnnamedtablebr_medicalimaging_preimagediag_Internalname ;
      private String lblTextblockbr_medicalimaging_preimagediag_Internalname ;
      private String lblTextblockbr_medicalimaging_preimagediag_Jsonclick ;
      private String edtBR_MedicalImaging_PreImageDiag_Internalname ;
      private String ClassString ;
      private String StyleString ;
      private String divUnnamedtablebr_medicalimaging_imageloc_Internalname ;
      private String lblTextblockbr_medicalimaging_imageloc_Internalname ;
      private String lblTextblockbr_medicalimaging_imageloc_Jsonclick ;
      private String edtBR_MedicalImaging_ImageLoc_Internalname ;
      private String divUnnamedtablebr_medicalimaging_imageorgan_Internalname ;
      private String lblTextblockbr_medicalimaging_imageorgan_Internalname ;
      private String lblTextblockbr_medicalimaging_imageorgan_Jsonclick ;
      private String edtBR_MedicalImaging_ImageOrgan_Internalname ;
      private String divUnnamedtablebr_medicalimaging_imagedes_Internalname ;
      private String lblTextblockbr_medicalimaging_imagedes_Internalname ;
      private String lblTextblockbr_medicalimaging_imagedes_Jsonclick ;
      private String edtBR_MedicalImaging_ImageDes_Internalname ;
      private String divHtml_bottomauxiliarcontrols_Internalname ;
      private String edtBR_MedicalImagingID_Internalname ;
      private String edtBR_MedicalImagingID_Jsonclick ;
      private String edtBR_EncounterID_Internalname ;
      private String edtBR_EncounterID_Jsonclick ;
      private String edtBR_Information_PatientNo_Internalname ;
      private String edtBR_Information_PatientNo_Jsonclick ;
      private String edtBR_MedicalImaging_ID_Internalname ;
      private String edtBR_MedicalImaging_ID_Jsonclick ;
      private String sXEvt ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String scmdbuf ;
      private String hsh ;
      private String sCtrlA225BR_MedicalImagingID ;
      private DateTime A229BR_MedicalImaging_ImageDate ;
      private DateTime A516BR_MedicalImaging_MetaDate ;
      private bool entryPointCalled ;
      private bool toggleJsOutput ;
      private bool wbLoad ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool n514BR_MedicalImaging_MetastasesDX ;
      private bool gxdyncontrolsrefreshing ;
      private bool n85BR_Information_ID ;
      private bool n227BR_MedicalImaging_ID ;
      private bool n36BR_Information_PatientNo ;
      private bool n19BR_EncounterID ;
      private bool n235BR_MedicalImaging_ImageDes ;
      private bool n233BR_MedicalImaging_ImageOrgan ;
      private bool n232BR_MedicalImaging_ImageLoc ;
      private bool n234BR_MedicalImaging_PreImageDiag ;
      private bool n516BR_MedicalImaging_MetaDate ;
      private bool n515BR_MedicalImaging_MetaLoc ;
      private bool n236BR_MedicalImaging_TumorSize ;
      private bool n231BR_MedicalImaging_ImageAge ;
      private bool n230BR_MedicalImaging_ImageHosp ;
      private bool n229BR_MedicalImaging_ImageDate ;
      private bool n228BR_MedicalImaging_ImageName ;
      private bool n518BR_MedicalImaging_No ;
      private bool returnInSub ;
      private String A514BR_MedicalImaging_MetastasesDX ;
      private String A228BR_MedicalImaging_ImageName ;
      private String A230BR_MedicalImaging_ImageHosp ;
      private String A236BR_MedicalImaging_TumorSize ;
      private String A515BR_MedicalImaging_MetaLoc ;
      private String A234BR_MedicalImaging_PreImageDiag ;
      private String A232BR_MedicalImaging_ImageLoc ;
      private String A233BR_MedicalImaging_ImageOrgan ;
      private String A235BR_MedicalImaging_ImageDes ;
      private String A36BR_Information_PatientNo ;
      private GXWebForm Form ;
      private IGxDataStore dsDataStore1 ;
      private IGxDataStore dsDefault ;
      private GXCombobox cmbBR_MedicalImaging_MetastasesDX ;
      private IDataStoreProvider pr_default ;
      private long[] H004T2_A85BR_Information_ID ;
      private bool[] H004T2_n85BR_Information_ID ;
      private long[] H004T2_A225BR_MedicalImagingID ;
      private long[] H004T2_A227BR_MedicalImaging_ID ;
      private bool[] H004T2_n227BR_MedicalImaging_ID ;
      private String[] H004T2_A36BR_Information_PatientNo ;
      private bool[] H004T2_n36BR_Information_PatientNo ;
      private long[] H004T2_A19BR_EncounterID ;
      private bool[] H004T2_n19BR_EncounterID ;
      private String[] H004T2_A235BR_MedicalImaging_ImageDes ;
      private bool[] H004T2_n235BR_MedicalImaging_ImageDes ;
      private String[] H004T2_A233BR_MedicalImaging_ImageOrgan ;
      private bool[] H004T2_n233BR_MedicalImaging_ImageOrgan ;
      private String[] H004T2_A232BR_MedicalImaging_ImageLoc ;
      private bool[] H004T2_n232BR_MedicalImaging_ImageLoc ;
      private String[] H004T2_A234BR_MedicalImaging_PreImageDiag ;
      private bool[] H004T2_n234BR_MedicalImaging_PreImageDiag ;
      private DateTime[] H004T2_A516BR_MedicalImaging_MetaDate ;
      private bool[] H004T2_n516BR_MedicalImaging_MetaDate ;
      private String[] H004T2_A515BR_MedicalImaging_MetaLoc ;
      private bool[] H004T2_n515BR_MedicalImaging_MetaLoc ;
      private String[] H004T2_A514BR_MedicalImaging_MetastasesDX ;
      private bool[] H004T2_n514BR_MedicalImaging_MetastasesDX ;
      private String[] H004T2_A236BR_MedicalImaging_TumorSize ;
      private bool[] H004T2_n236BR_MedicalImaging_TumorSize ;
      private short[] H004T2_A231BR_MedicalImaging_ImageAge ;
      private bool[] H004T2_n231BR_MedicalImaging_ImageAge ;
      private String[] H004T2_A230BR_MedicalImaging_ImageHosp ;
      private bool[] H004T2_n230BR_MedicalImaging_ImageHosp ;
      private DateTime[] H004T2_A229BR_MedicalImaging_ImageDate ;
      private bool[] H004T2_n229BR_MedicalImaging_ImageDate ;
      private String[] H004T2_A228BR_MedicalImaging_ImageName ;
      private bool[] H004T2_n228BR_MedicalImaging_ImageName ;
      private long[] H004T2_A518BR_MedicalImaging_No ;
      private bool[] H004T2_n518BR_MedicalImaging_No ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private GxHttpRequest AV12HTTPRequest ;
      private IGxSession AV11Session ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPContext AV6WWPContext ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext AV9TrnContext ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext_Attribute AV10TrnContextAtt ;
   }

   public class br_medicalimaginggeneral__default : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmH004T2 ;
          prmH004T2 = new Object[] {
          new Object[] {"@BR_MedicalImagingID",SqlDbType.Decimal,18,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("H004T2", "SELECT T2.[BR_Information_ID], T1.[BR_MedicalImagingID], T1.[BR_MedicalImaging_ID], T3.[BR_Information_PatientNo], T1.[BR_EncounterID], T1.[BR_MedicalImaging_ImageDes], T1.[BR_MedicalImaging_ImageOrgan], T1.[BR_MedicalImaging_ImageLoc], T1.[BR_MedicalImaging_PreImageDiag], T1.[BR_MedicalImaging_MetaDate], T1.[BR_MedicalImaging_MetaLoc], T1.[BR_MedicalImaging_MetastasesDX], T1.[BR_MedicalImaging_TumorSize], T1.[BR_MedicalImaging_ImageAge], T1.[BR_MedicalImaging_ImageHosp], T1.[BR_MedicalImaging_ImageDate], T1.[BR_MedicalImaging_ImageName], T1.[BR_MedicalImaging_No] FROM (([BR_MedicalImaging] T1 WITH (NOLOCK) LEFT JOIN [BR_Encounter] T2 WITH (NOLOCK) ON T2.[BR_EncounterID] = T1.[BR_EncounterID]) LEFT JOIN [BR_Information] T3 WITH (NOLOCK) ON T3.[BR_Information_ID] = T2.[BR_Information_ID]) WHERE T1.[BR_MedicalImagingID] = @BR_MedicalImagingID ORDER BY T1.[BR_MedicalImagingID] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH004T2,1,0,true,true )
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
                ((long[]) buf[3])[0] = rslt.getLong(3) ;
                ((bool[]) buf[4])[0] = rslt.wasNull(3);
                ((String[]) buf[5])[0] = rslt.getVarchar(4) ;
                ((bool[]) buf[6])[0] = rslt.wasNull(4);
                ((long[]) buf[7])[0] = rslt.getLong(5) ;
                ((bool[]) buf[8])[0] = rslt.wasNull(5);
                ((String[]) buf[9])[0] = rslt.getVarchar(6) ;
                ((bool[]) buf[10])[0] = rslt.wasNull(6);
                ((String[]) buf[11])[0] = rslt.getVarchar(7) ;
                ((bool[]) buf[12])[0] = rslt.wasNull(7);
                ((String[]) buf[13])[0] = rslt.getVarchar(8) ;
                ((bool[]) buf[14])[0] = rslt.wasNull(8);
                ((String[]) buf[15])[0] = rslt.getVarchar(9) ;
                ((bool[]) buf[16])[0] = rslt.wasNull(9);
                ((DateTime[]) buf[17])[0] = rslt.getGXDate(10) ;
                ((bool[]) buf[18])[0] = rslt.wasNull(10);
                ((String[]) buf[19])[0] = rslt.getVarchar(11) ;
                ((bool[]) buf[20])[0] = rslt.wasNull(11);
                ((String[]) buf[21])[0] = rslt.getVarchar(12) ;
                ((bool[]) buf[22])[0] = rslt.wasNull(12);
                ((String[]) buf[23])[0] = rslt.getVarchar(13) ;
                ((bool[]) buf[24])[0] = rslt.wasNull(13);
                ((short[]) buf[25])[0] = rslt.getShort(14) ;
                ((bool[]) buf[26])[0] = rslt.wasNull(14);
                ((String[]) buf[27])[0] = rslt.getVarchar(15) ;
                ((bool[]) buf[28])[0] = rslt.wasNull(15);
                ((DateTime[]) buf[29])[0] = rslt.getGXDate(16) ;
                ((bool[]) buf[30])[0] = rslt.wasNull(16);
                ((String[]) buf[31])[0] = rslt.getVarchar(17) ;
                ((bool[]) buf[32])[0] = rslt.wasNull(17);
                ((long[]) buf[33])[0] = rslt.getLong(18) ;
                ((bool[]) buf[34])[0] = rslt.wasNull(18);
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
