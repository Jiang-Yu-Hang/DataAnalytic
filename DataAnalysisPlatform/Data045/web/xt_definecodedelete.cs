/*
               File: XT_DefineCodeDelete
        Description:
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/28/2020 15:16:51.37
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
using System.Xml.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.Runtime.Serialization;
namespace GeneXus.Programs {
   public class xt_definecodedelete : GXDataArea, System.Web.SessionState.IRequiresSessionState
   {
      public xt_definecodedelete( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public xt_definecodedelete( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( long aP0_XT_DefineCodeID )
      {
         this.AV12XT_DefineCodeID = aP0_XT_DefineCodeID;
         executePrivate();
      }

      void executePrivate( )
      {
         isStatic = false;
         webExecute();
      }

      protected override void createObjects( )
      {
         cmbavXt_definecode_xt_definecodeintialtype = new GXCombobox();
      }

      protected void INITWEB( )
      {
         initialize_properties( ) ;
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
            if ( ! entryPointCalled && ! ( isAjaxCallMode( ) || isFullAjaxMode( ) ) )
            {
               AV12XT_DefineCodeID = (long)(NumberUtil.Val( gxfirstwebparm, "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12XT_DefineCodeID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV12XT_DefineCodeID), 18, 0)));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vXT_DEFINECODEID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV12XT_DefineCodeID), "ZZZZZZZZZZZZZZZZZZ"), context));
            }
            if ( context.isSpaRequest( ) )
            {
               enableJsOutput();
            }
         }
         if ( ! context.IsLocalStorageSupported( ) )
         {
            context.PushCurrentUrl();
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
            MasterPageObj = (GXMasterPage) ClassLoader.GetInstance("wwpbaseobjects.workwithplusmasterpage", "GeneXus.Programs.wwpbaseobjects.workwithplusmasterpage", new Object[] {new GxContext( context.handle, context.DataStores, context.HttpContext)});
            MasterPageObj.setDataArea(this,false);
            ValidateSpaRequest();
            MasterPageObj.webExecute();
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

      public override short ExecuteStartEvent( )
      {
         PA8U2( ) ;
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0));
         if ( ( gxajaxcallmode == 0 ) && ( GxWebError == 0 ) )
         {
            START8U2( ) ;
         }
         return gxajaxcallmode ;
      }

      public override void RenderHtmlHeaders( )
      {
         GxWebStd.gx_html_headers( context, 0, "", "", Form.Meta, Form.Metaequiv, true);
      }

      public override void RenderHtmlOpenForm( )
      {
         if ( context.isSpaRequest( ) )
         {
            enableOutput();
         }
         context.WriteHtmlText( "<title>") ;
         context.SendWebValue( Form.Caption) ;
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
         if ( nGXWrapped != 1 )
         {
            MasterPageObj.master_styles();
         }
         if ( ( ( context.GetBrowserType( ) == 1 ) || ( context.GetBrowserType( ) == 5 ) ) && ( StringUtil.StrCmp(context.GetBrowserVersion( ), "7.0") == 0 ) )
         {
            context.AddJavascriptSource("json2.js", "?"+context.GetBuildNumber( 127771), false);
         }
         context.AddJavascriptSource("jquery.js", "?"+context.GetBuildNumber( 127771), false);
         context.AddJavascriptSource("gxtimezone.js", "?"+context.GetBuildNumber( 127771), false);
         context.AddJavascriptSource("gxgral.js", "?"+context.GetBuildNumber( 127771), false);
         context.AddJavascriptSource("gxcfg.js", "?202022815165139", false);
         if ( context.isSpaRequest( ) )
         {
            enableOutput();
         }
         context.AddJavascriptSource("DVelop/Bootstrap/Shared/DVelopBootstrap.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/Panel/BootstrapPanelRender.js", "", false);
         context.WriteHtmlText( Form.Headerrawhtml) ;
         context.CloseHtmlHeader();
         if ( context.isSpaRequest( ) )
         {
            disableOutput();
         }
         FormProcess = " data-HasEnter=\"true\" data-Skiponenter=\"false\"";
         context.WriteHtmlText( "<body ") ;
         bodyStyle = "" + "background-color:" + context.BuildHTMLColor( Form.Backcolor) + ";color:" + context.BuildHTMLColor( Form.Textcolor) + ";";
         if ( nGXWrapped == 0 )
         {
            bodyStyle = bodyStyle + "-moz-opacity:0;opacity:0;";
         }
         if ( ! ( String.IsNullOrEmpty(StringUtil.RTrim( Form.Background)) ) )
         {
            bodyStyle = bodyStyle + " background-image:url(" + context.convertURL( Form.Background) + ")";
         }
         context.WriteHtmlText( " "+"class=\"form-horizontal Form\""+" "+ "style='"+bodyStyle+"'") ;
         context.WriteHtmlText( FormProcess+">") ;
         context.skipLines(1);
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" autocomplete=\"off\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("xt_definecodedelete.aspx") + "?" + UrlEncode("" +AV12XT_DefineCodeID)+"\">") ;
         GxWebStd.gx_hidden_field( context, "_EventName", "");
         GxWebStd.gx_hidden_field( context, "_EventGridId", "");
         GxWebStd.gx_hidden_field( context, "_EventRowId", "");
         context.WriteHtmlText( "<input type=\"submit\" title=\"submit\" style=\"display:none\" disabled>") ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, "FORM", "Class", "form-horizontal Form", true);
         toggleJsOutput = isJsOutputEnabled( );
         if ( context.isSpaRequest( ) )
         {
            disableJsOutput();
         }
      }

      protected void send_integrity_footer_hashes( )
      {
         GXKey = Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
         forbiddenHiddens = "hsh" + "XT_DefineCodeDelete";
         forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( AV10XT_DefineCode.gxTpr_Xt_definecodename, ""));
         forbiddenHiddens = forbiddenHiddens + context.localUtil.Format( (decimal)(AV10XT_DefineCode.gxTpr_Xt_defindcodetypeid), "ZZZZZZZZZZZZZZZZZZ");
         forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( AV10XT_DefineCode.gxTpr_Xt_defindcodetypename, ""));
         GxWebStd.gx_hidden_field( context, "hsh", GetEncryptedHash( forbiddenHiddens, GXKey));
         GXUtil.WriteLog("xt_definecodedelete:[SendSecurityCheck value for]"+"GXV1:"+StringUtil.RTrim( context.localUtil.Format( AV10XT_DefineCode.gxTpr_Xt_definecodename, "")));
         GXUtil.WriteLog("xt_definecodedelete:[SendSecurityCheck value for]"+"GXV2:"+context.localUtil.Format( (decimal)(AV10XT_DefineCode.gxTpr_Xt_defindcodetypeid), "ZZZZZZZZZZZZZZZZZZ"));
         GXUtil.WriteLog("xt_definecodedelete:[SendSecurityCheck value for]"+"GXV3:"+StringUtil.RTrim( context.localUtil.Format( AV10XT_DefineCode.gxTpr_Xt_defindcodetypename, "")));
      }

      protected void SendCloseFormHiddens( )
      {
         /* Send hidden variables. */
         /* Send saved values. */
         send_integrity_footer_hashes( ) ;
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "Xt_definecode", AV10XT_DefineCode);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("Xt_definecode", AV10XT_DefineCode);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vXT_DEFINECODE", AV10XT_DefineCode);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vXT_DEFINECODE", AV10XT_DefineCode);
         }
         GxWebStd.gx_hidden_field( context, "vXT_DEFINECODEID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV12XT_DefineCodeID), 18, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "gxhash_vXT_DEFINECODEID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV12XT_DefineCodeID), "ZZZZZZZZZZZZZZZZZZ"), context));
         GxWebStd.gx_hidden_field( context, "DVPANEL_TABLEATTRIBUTES_Width", StringUtil.RTrim( Dvpanel_tableattributes_Width));
         GxWebStd.gx_hidden_field( context, "DVPANEL_TABLEATTRIBUTES_Cls", StringUtil.RTrim( Dvpanel_tableattributes_Cls));
         GxWebStd.gx_hidden_field( context, "DVPANEL_TABLEATTRIBUTES_Title", StringUtil.RTrim( Dvpanel_tableattributes_Title));
         GxWebStd.gx_hidden_field( context, "DVPANEL_TABLEATTRIBUTES_Collapsible", StringUtil.BoolToStr( Dvpanel_tableattributes_Collapsible));
         GxWebStd.gx_hidden_field( context, "DVPANEL_TABLEATTRIBUTES_Collapsed", StringUtil.BoolToStr( Dvpanel_tableattributes_Collapsed));
         GxWebStd.gx_hidden_field( context, "DVPANEL_TABLEATTRIBUTES_Autowidth", StringUtil.BoolToStr( Dvpanel_tableattributes_Autowidth));
         GxWebStd.gx_hidden_field( context, "DVPANEL_TABLEATTRIBUTES_Autoheight", StringUtil.BoolToStr( Dvpanel_tableattributes_Autoheight));
         GxWebStd.gx_hidden_field( context, "DVPANEL_TABLEATTRIBUTES_Showcollapseicon", StringUtil.BoolToStr( Dvpanel_tableattributes_Showcollapseicon));
         GxWebStd.gx_hidden_field( context, "DVPANEL_TABLEATTRIBUTES_Iconposition", StringUtil.RTrim( Dvpanel_tableattributes_Iconposition));
         GxWebStd.gx_hidden_field( context, "DVPANEL_TABLEATTRIBUTES_Autoscroll", StringUtil.BoolToStr( Dvpanel_tableattributes_Autoscroll));
      }

      public override void RenderHtmlCloseForm( )
      {
         SendCloseFormHiddens( ) ;
         GxWebStd.gx_hidden_field( context, "GX_FocusControl", GX_FocusControl);
         SendAjaxEncryptionKey();
         SendSecurityToken((String)(sPrefix));
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
      }

      public override void RenderHtmlContent( )
      {
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0));
         if ( ( gxajaxcallmode == 0 ) && ( GxWebError == 0 ) )
         {
            context.WriteHtmlText( "<div") ;
            GxWebStd.ClassAttribute( context, "gx-ct-body"+" "+(String.IsNullOrEmpty(StringUtil.RTrim( Form.Class)) ? "form-horizontal Form" : Form.Class)+"-fx");
            context.WriteHtmlText( ">") ;
            WE8U2( ) ;
            context.WriteHtmlText( "</div>") ;
         }
      }

      public override void DispatchEvents( )
      {
         EVT8U2( ) ;
      }

      public override bool HasEnterEvent( )
      {
         return true ;
      }

      public override GXWebForm GetForm( )
      {
         return Form ;
      }

      public override String GetSelfLink( )
      {
         return formatLink("xt_definecodedelete.aspx") + "?" + UrlEncode("" +AV12XT_DefineCodeID) ;
      }

      public override String GetPgmname( )
      {
         return "XT_DefineCodeDelete" ;
      }

      public override String GetPgmdesc( )
      {
         return "" ;
      }

      protected void WB8U0( )
      {
         if ( context.isAjaxRequest( ) )
         {
            disableOutput();
         }
         if ( ! wbLoad )
         {
            if ( nGXWrapped == 1 )
            {
               RenderHtmlHeaders( ) ;
               RenderHtmlOpenForm( ) ;
            }
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "Section", "left", "top", " "+"data-gx-base-lib=\"bootstrapv3\""+" "+"data-abstract-form"+" ", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divLayoutmaintable_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divTablemain_Internalname, 1, 0, "px", 0, "px", "TableMainTransaction", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            ClassString = "ErrorViewer";
            StyleString = "";
            GxWebStd.gx_msg_list( context, "", context.GX_msglist.DisplayMode, StyleString, ClassString, "", "false");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divTablecontent_Internalname, 1, 0, "px", 0, "px", "TableContent", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divHtml_dvpanel_tableattributes_Internalname, 1, 0, "px", 0, "px", "Section", "left", "top", "", "", "div");
            /* User Defined Control */
            ucDvpanel_tableattributes.SetProperty("Width", Dvpanel_tableattributes_Width);
            ucDvpanel_tableattributes.SetProperty("AutoWidth", Dvpanel_tableattributes_Autowidth);
            ucDvpanel_tableattributes.SetProperty("AutoHeight", Dvpanel_tableattributes_Autoheight);
            ucDvpanel_tableattributes.SetProperty("Cls", Dvpanel_tableattributes_Cls);
            ucDvpanel_tableattributes.SetProperty("Title", Dvpanel_tableattributes_Title);
            ucDvpanel_tableattributes.SetProperty("Collapsible", Dvpanel_tableattributes_Collapsible);
            ucDvpanel_tableattributes.SetProperty("Collapsed", Dvpanel_tableattributes_Collapsed);
            ucDvpanel_tableattributes.SetProperty("ShowCollapseIcon", Dvpanel_tableattributes_Showcollapseicon);
            ucDvpanel_tableattributes.SetProperty("IconPosition", Dvpanel_tableattributes_Iconposition);
            ucDvpanel_tableattributes.SetProperty("AutoScroll", Dvpanel_tableattributes_Autoscroll);
            ucDvpanel_tableattributes.Render(context, "dvelop.gxbootstrap.panel", Dvpanel_tableattributes_Internalname, "DVPANEL_TABLEATTRIBUTESContainer");
            context.WriteHtmlText( "<div class=\"gx_usercontrol_child\" id=\""+"DVPANEL_TABLEATTRIBUTESContainer"+"Body"+"\" style=\"display:none;\">") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, divLayout_tableattributes_Internalname, 1, 0, "px", 0, "px", "Section", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "Section", "left", "top", " "+"data-gx-base-lib=\"bootstrapv3\""+" "+"data-abstract-form"+" ", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divTableattributes_Internalname, 1, 0, "px", 0, "px", "TableData", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtavXt_definecode_xt_definecodename_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavXt_definecode_xt_definecodename_Internalname, "数据字典名称", "col-sm-3 ReadonlyAttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtavXt_definecode_xt_definecodename_Internalname, AV10XT_DefineCode.gxTpr_Xt_definecodename, StringUtil.RTrim( context.localUtil.Format( AV10XT_DefineCode.gxTpr_Xt_definecodename, "")), "", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavXt_definecode_xt_definecodename_Jsonclick, 0, "ReadonlyAttribute", "", "", "", "", 1, edtavXt_definecode_xt_definecodename_Enabled, 0, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_XT_DefineCodeDelete.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtavXt_definecode_xt_defindcodetypeid_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavXt_definecode_xt_defindcodetypeid_Internalname, "数据字典类型编号", "col-sm-3 ReadonlyAttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtavXt_definecode_xt_defindcodetypeid_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV10XT_DefineCode.gxTpr_Xt_defindcodetypeid), 18, 0, ".", "")), ((edtavXt_definecode_xt_defindcodetypeid_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(AV10XT_DefineCode.gxTpr_Xt_defindcodetypeid), "ZZZZZZZZZZZZZZZZZZ")) : context.localUtil.Format( (decimal)(AV10XT_DefineCode.gxTpr_Xt_defindcodetypeid), "ZZZZZZZZZZZZZZZZZZ")), "", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavXt_definecode_xt_defindcodetypeid_Jsonclick, 0, "ReadonlyAttribute", "", "", "", "", 1, edtavXt_definecode_xt_defindcodetypeid_Enabled, 0, "number", "1", 18, "chr", 1, "row", 18, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_XT_DefineCodeDelete.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtavXt_definecode_xt_defindcodetypename_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavXt_definecode_xt_defindcodetypename_Internalname, "数据字典类型名称", "col-sm-3 ReadonlyAttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtavXt_definecode_xt_defindcodetypename_Internalname, AV10XT_DefineCode.gxTpr_Xt_defindcodetypename, StringUtil.RTrim( context.localUtil.Format( AV10XT_DefineCode.gxTpr_Xt_defindcodetypename, "")), "", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavXt_definecode_xt_defindcodetypename_Jsonclick, 0, "ReadonlyAttribute", "", "", "", "", 1, edtavXt_definecode_xt_defindcodetypename_Enabled, 0, "text", "", 40, "chr", 1, "row", 40, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_XT_DefineCodeDelete.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</div>") ;
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
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 40,'',false,'',0)\"";
            ClassString = "ButtonMaterial";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtnenter_Internalname, "", "确认", bttBtnenter_Jsonclick, 5, "确认", "", StyleString, ClassString, 1, 1, "standard", "'"+""+"'"+",false,"+"'"+"EENTER."+"'", TempTags, "", context.GetButtonType( ), "HLP_XT_DefineCodeDelete.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 42,'',false,'',0)\"";
            ClassString = "ButtonMaterialDefault";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtncancel_Internalname, "", "取消", bttBtncancel_Jsonclick, 1, "取消", "", StyleString, ClassString, 1, 1, "standard", "'"+""+"'"+",false,"+"'"+"ECANCEL."+"'", TempTags, "", context.GetButtonType( ), "HLP_XT_DefineCodeDelete.htm");
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
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 46,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavXt_definecode_xt_definecodeid_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV10XT_DefineCode.gxTpr_Xt_definecodeid), 18, 0, ".", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(AV10XT_DefineCode.gxTpr_Xt_definecodeid), "ZZZZZZZZZZZZZZZZZZ")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,46);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavXt_definecode_xt_definecodeid_Jsonclick, 0, "Attribute", "", "", "", "", edtavXt_definecode_xt_definecodeid_Visible, 1, 0, "number", "1", 18, "chr", 1, "row", 18, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_XT_DefineCodeDelete.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 47,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavXt_definecode_xt_definecodeorder_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV10XT_DefineCode.gxTpr_Xt_definecodeorder), 4, 0, ".", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(AV10XT_DefineCode.gxTpr_Xt_definecodeorder), "ZZZZ")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,47);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavXt_definecode_xt_definecodeorder_Jsonclick, 0, "Attribute", "", "", "", "", edtavXt_definecode_xt_definecodeorder_Visible, 1, 0, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_XT_DefineCodeDelete.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 48,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavXt_definecode_xt_typecode_Internalname, AV10XT_DefineCode.gxTpr_Xt_typecode, StringUtil.RTrim( context.localUtil.Format( AV10XT_DefineCode.gxTpr_Xt_typecode, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,48);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavXt_definecode_xt_typecode_Jsonclick, 0, "Attribute", "", "", "", "", edtavXt_definecode_xt_typecode_Visible, 1, 0, "text", "", 40, "chr", 1, "row", 40, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_XT_DefineCodeDelete.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 49,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavXt_definecode_xt_tenantcode_Internalname, AV10XT_DefineCode.gxTpr_Xt_tenantcode, StringUtil.RTrim( context.localUtil.Format( AV10XT_DefineCode.gxTpr_Xt_tenantcode, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,49);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavXt_definecode_xt_tenantcode_Jsonclick, 0, "Attribute", "", "", "", "", edtavXt_definecode_xt_tenantcode_Visible, 1, 0, "text", "", 40, "chr", 1, "row", 40, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_XT_DefineCodeDelete.htm");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 50,'',false,'',0)\"";
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, cmbavXt_definecode_xt_definecodeintialtype, cmbavXt_definecode_xt_definecodeintialtype_Internalname, StringUtil.Trim( StringUtil.Str( (decimal)(AV10XT_DefineCode.gxTpr_Xt_definecodeintialtype), 4, 0)), 1, cmbavXt_definecode_xt_definecodeintialtype_Jsonclick, 0, "'"+""+"'"+",false,"+"'"+""+"'", "int", "", cmbavXt_definecode_xt_definecodeintialtype.Visible, 1, 0, 0, 0, "em", 0, "", "", "Attribute", "", "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,50);\"", "", true, "HLP_XT_DefineCodeDelete.htm");
            cmbavXt_definecode_xt_definecodeintialtype.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(AV10XT_DefineCode.gxTpr_Xt_definecodeintialtype), 4, 0));
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavXt_definecode_xt_definecodeintialtype_Internalname, "Values", (String)(cmbavXt_definecode_xt_definecodeintialtype.ToJavascriptSource()), true);
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
         }
         wbLoad = true;
      }

      protected void START8U2( )
      {
         wbLoad = false;
         wbEnd = 0;
         wbStart = 0;
         if ( ! context.isSpaRequest( ) )
         {
            Form.Meta.addItem("generator", "GeneXus C# 16_0_0-127771", 0) ;
            Form.Meta.addItem("description", "", 0) ;
         }
         context.wjLoc = "";
         context.nUserReturn = 0;
         context.wbHandled = 0;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         wbErr = false;
         STRUP8U0( ) ;
      }

      protected void WS8U2( )
      {
         START8U2( ) ;
         EVT8U2( ) ;
      }

      protected void EVT8U2( )
      {
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) && ! wbErr )
            {
               /* Read Web Panel buttons. */
               sEvt = cgiGet( "_EventName");
               EvtGridId = cgiGet( "_EventGridId");
               EvtRowId = cgiGet( "_EventRowId");
               if ( StringUtil.Len( sEvt) > 0 )
               {
                  sEvtType = StringUtil.Left( sEvt, 1);
                  sEvt = StringUtil.Right( sEvt, (short)(StringUtil.Len( sEvt)-1));
                  if ( StringUtil.StrCmp(sEvtType, "M") != 0 )
                  {
                     if ( StringUtil.StrCmp(sEvtType, "E") == 0 )
                     {
                        sEvtType = StringUtil.Right( sEvt, 1);
                        if ( StringUtil.StrCmp(sEvtType, ".") == 0 )
                        {
                           sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-1));
                           if ( StringUtil.StrCmp(sEvt, "RFR") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                           }
                           else if ( StringUtil.StrCmp(sEvt, "START") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              /* Execute user event: Start */
                              E118U2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "REFRESH") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              /* Execute user event: Refresh */
                              E128U2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "ENTER") == 0 )
                           {
                              context.wbHandled = 1;
                              if ( ! wbErr )
                              {
                                 Rfr0gs = false;
                                 if ( ! Rfr0gs )
                                 {
                                    /* Execute user event: Enter */
                                    E138U2 ();
                                 }
                                 dynload_actions( ) ;
                              }
                           }
                           else if ( StringUtil.StrCmp(sEvt, "LOAD") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              /* Execute user event: Load */
                              E148U2 ();
                              /* No code required for Cancel button. It is implemented as the Reset button. */
                           }
                           else if ( StringUtil.StrCmp(sEvt, "LSCR") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
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

      protected void WE8U2( )
      {
         if ( ! GxWebStd.gx_redirect( context) )
         {
            Rfr0gs = true;
            Refresh( ) ;
            if ( ! GxWebStd.gx_redirect( context) )
            {
               if ( nGXWrapped == 1 )
               {
                  RenderHtmlCloseForm( ) ;
               }
            }
         }
      }

      protected void PA8U2( )
      {
         if ( nDonePA == 0 )
         {
            if ( String.IsNullOrEmpty(StringUtil.RTrim( context.GetCookie( "GX_SESSION_ID"))) )
            {
               gxcookieaux = context.SetCookie( "GX_SESSION_ID", Encrypt64( Crypto.GetEncryptionKey( ), Crypto.GetServerKey( )), "", (DateTime)(DateTime.MinValue), "", 0);
            }
            GXKey = Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
            toggleJsOutput = isJsOutputEnabled( );
            if ( context.isSpaRequest( ) )
            {
               disableJsOutput();
            }
            init_web_controls( ) ;
            if ( toggleJsOutput )
            {
               if ( context.isSpaRequest( ) )
               {
                  enableJsOutput();
               }
            }
            if ( ! context.isAjaxRequest( ) )
            {
               GX_FocusControl = edtavXt_definecode_xt_definecodename_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
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
         if ( cmbavXt_definecode_xt_definecodeintialtype.ItemCount > 0 )
         {
            AV10XT_DefineCode.gxTpr_Xt_definecodeintialtype = (short)(NumberUtil.Val( cmbavXt_definecode_xt_definecodeintialtype.getValidValue(StringUtil.Trim( StringUtil.Str( (decimal)(AV10XT_DefineCode.gxTpr_Xt_definecodeintialtype), 4, 0))), "."));
         }
         if ( context.isAjaxRequest( ) )
         {
            cmbavXt_definecode_xt_definecodeintialtype.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(AV10XT_DefineCode.gxTpr_Xt_definecodeintialtype), 4, 0));
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavXt_definecode_xt_definecodeintialtype_Internalname, "Values", cmbavXt_definecode_xt_definecodeintialtype.ToJavascriptSource(), true);
         }
      }

      public void Refresh( )
      {
         send_integrity_hashes( ) ;
         RF8U2( ) ;
         if ( isFullAjaxMode( ) )
         {
            send_integrity_footer_hashes( ) ;
         }
      }

      protected void initialize_formulas( )
      {
         /* GeneXus formulas. */
         context.Gx_err = 0;
         edtavXt_definecode_xt_definecodename_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavXt_definecode_xt_definecodename_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavXt_definecode_xt_definecodename_Enabled), 5, 0)), true);
         edtavXt_definecode_xt_defindcodetypeid_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavXt_definecode_xt_defindcodetypeid_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavXt_definecode_xt_defindcodetypeid_Enabled), 5, 0)), true);
         edtavXt_definecode_xt_defindcodetypename_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavXt_definecode_xt_defindcodetypename_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavXt_definecode_xt_defindcodetypename_Enabled), 5, 0)), true);
      }

      protected void RF8U2( )
      {
         initialize_formulas( ) ;
         clear_multi_value_controls( ) ;
         /* Execute user event: Refresh */
         E128U2 ();
         gxdyncontrolsrefreshing = true;
         fix_multi_value_controls( ) ;
         gxdyncontrolsrefreshing = false;
         if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
         {
            /* Execute user event: Load */
            E148U2 ();
            WB8U0( ) ;
         }
      }

      protected void send_integrity_lvl_hashes8U2( )
      {
      }

      protected void STRUP8U0( )
      {
         /* Before Start, stand alone formulas. */
         context.Gx_err = 0;
         edtavXt_definecode_xt_definecodename_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavXt_definecode_xt_definecodename_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavXt_definecode_xt_definecodename_Enabled), 5, 0)), true);
         edtavXt_definecode_xt_defindcodetypeid_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavXt_definecode_xt_defindcodetypeid_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavXt_definecode_xt_defindcodetypeid_Enabled), 5, 0)), true);
         edtavXt_definecode_xt_defindcodetypename_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavXt_definecode_xt_defindcodetypename_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavXt_definecode_xt_defindcodetypename_Enabled), 5, 0)), true);
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0;
         /* Execute user event: Start */
         E118U2 ();
         context.wbGlbDoneStart = 1;
         /* After Start, stand alone formulas. */
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read saved SDTs. */
            ajax_req_read_hidden_sdt(cgiGet( "Xt_definecode"), AV10XT_DefineCode);
            /* Read variables values. */
            AV10XT_DefineCode.gxTpr_Xt_definecodename = cgiGet( edtavXt_definecode_xt_definecodename_Internalname);
            if ( ( ( context.localUtil.CToN( cgiGet( edtavXt_definecode_xt_defindcodetypeid_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavXt_definecode_xt_defindcodetypeid_Internalname), ".", ",") > Convert.ToDecimal( 999999999999999999L )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "XT_DEFINECODE_XT_DEFINDCODETYPEID");
               GX_FocusControl = edtavXt_definecode_xt_defindcodetypeid_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV10XT_DefineCode.gxTpr_Xt_defindcodetypeid = 0;
            }
            else
            {
               AV10XT_DefineCode.gxTpr_Xt_defindcodetypeid = (long)(context.localUtil.CToN( cgiGet( edtavXt_definecode_xt_defindcodetypeid_Internalname), ".", ","));
            }
            AV10XT_DefineCode.gxTpr_Xt_defindcodetypename = cgiGet( edtavXt_definecode_xt_defindcodetypename_Internalname);
            if ( ( ( context.localUtil.CToN( cgiGet( edtavXt_definecode_xt_definecodeid_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavXt_definecode_xt_definecodeid_Internalname), ".", ",") > Convert.ToDecimal( 999999999999999999L )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "XT_DEFINECODE_XT_DEFINECODEID");
               GX_FocusControl = edtavXt_definecode_xt_definecodeid_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV10XT_DefineCode.gxTpr_Xt_definecodeid = 0;
            }
            else
            {
               AV10XT_DefineCode.gxTpr_Xt_definecodeid = (long)(context.localUtil.CToN( cgiGet( edtavXt_definecode_xt_definecodeid_Internalname), ".", ","));
            }
            if ( ( ( context.localUtil.CToN( cgiGet( edtavXt_definecode_xt_definecodeorder_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavXt_definecode_xt_definecodeorder_Internalname), ".", ",") > Convert.ToDecimal( 9999 )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "XT_DEFINECODE_XT_DEFINECODEORDER");
               GX_FocusControl = edtavXt_definecode_xt_definecodeorder_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV10XT_DefineCode.gxTpr_Xt_definecodeorder = 0;
            }
            else
            {
               AV10XT_DefineCode.gxTpr_Xt_definecodeorder = (short)(context.localUtil.CToN( cgiGet( edtavXt_definecode_xt_definecodeorder_Internalname), ".", ","));
            }
            AV10XT_DefineCode.gxTpr_Xt_typecode = cgiGet( edtavXt_definecode_xt_typecode_Internalname);
            AV10XT_DefineCode.gxTpr_Xt_tenantcode = cgiGet( edtavXt_definecode_xt_tenantcode_Internalname);
            cmbavXt_definecode_xt_definecodeintialtype.CurrentValue = cgiGet( cmbavXt_definecode_xt_definecodeintialtype_Internalname);
            AV10XT_DefineCode.gxTpr_Xt_definecodeintialtype = (short)(NumberUtil.Val( cgiGet( cmbavXt_definecode_xt_definecodeintialtype_Internalname), "."));
            /* Read saved values. */
            Dvpanel_tableattributes_Width = cgiGet( "DVPANEL_TABLEATTRIBUTES_Width");
            Dvpanel_tableattributes_Cls = cgiGet( "DVPANEL_TABLEATTRIBUTES_Cls");
            Dvpanel_tableattributes_Title = cgiGet( "DVPANEL_TABLEATTRIBUTES_Title");
            Dvpanel_tableattributes_Collapsible = StringUtil.StrToBool( cgiGet( "DVPANEL_TABLEATTRIBUTES_Collapsible"));
            Dvpanel_tableattributes_Collapsed = StringUtil.StrToBool( cgiGet( "DVPANEL_TABLEATTRIBUTES_Collapsed"));
            Dvpanel_tableattributes_Autowidth = StringUtil.StrToBool( cgiGet( "DVPANEL_TABLEATTRIBUTES_Autowidth"));
            Dvpanel_tableattributes_Autoheight = StringUtil.StrToBool( cgiGet( "DVPANEL_TABLEATTRIBUTES_Autoheight"));
            Dvpanel_tableattributes_Showcollapseicon = StringUtil.StrToBool( cgiGet( "DVPANEL_TABLEATTRIBUTES_Showcollapseicon"));
            Dvpanel_tableattributes_Iconposition = cgiGet( "DVPANEL_TABLEATTRIBUTES_Iconposition");
            Dvpanel_tableattributes_Autoscroll = StringUtil.StrToBool( cgiGet( "DVPANEL_TABLEATTRIBUTES_Autoscroll"));
            /* Read subfile selected row values. */
            /* Read hidden variables. */
            GXKey = Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
            forbiddenHiddens = "hsh" + "XT_DefineCodeDelete";
            AV10XT_DefineCode.gxTpr_Xt_definecodename = cgiGet( edtavXt_definecode_xt_definecodename_Internalname);
            forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( AV10XT_DefineCode.gxTpr_Xt_definecodename, ""));
            AV10XT_DefineCode.gxTpr_Xt_defindcodetypeid = (long)(context.localUtil.CToN( cgiGet( edtavXt_definecode_xt_defindcodetypeid_Internalname), ".", ","));
            forbiddenHiddens = forbiddenHiddens + context.localUtil.Format( (decimal)(AV10XT_DefineCode.gxTpr_Xt_defindcodetypeid), "ZZZZZZZZZZZZZZZZZZ");
            AV10XT_DefineCode.gxTpr_Xt_defindcodetypename = cgiGet( edtavXt_definecode_xt_defindcodetypename_Internalname);
            forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( AV10XT_DefineCode.gxTpr_Xt_defindcodetypename, ""));
            hsh = cgiGet( "hsh");
            if ( ! GXUtil.CheckEncryptedHash( forbiddenHiddens, hsh, GXKey) )
            {
               GXUtil.WriteLog("xt_definecodedelete:[SecurityCheckFailed value for]"+"GXV1:"+StringUtil.RTrim( context.localUtil.Format( AV10XT_DefineCode.gxTpr_Xt_definecodename, "")));
               GXUtil.WriteLog("xt_definecodedelete:[SecurityCheckFailed value for]"+"GXV2:"+context.localUtil.Format( (decimal)(AV10XT_DefineCode.gxTpr_Xt_defindcodetypeid), "ZZZZZZZZZZZZZZZZZZ"));
               GXUtil.WriteLog("xt_definecodedelete:[SecurityCheckFailed value for]"+"GXV3:"+StringUtil.RTrim( context.localUtil.Format( AV10XT_DefineCode.gxTpr_Xt_defindcodetypename, "")));
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
         E118U2 ();
         if (returnInSub) return;
      }

      protected void E118U2( )
      {
         /* Start Routine */
         GXt_char1 = AV11tCurrentCode;
         new zbr_getcurrenttcode(context ).execute( out  GXt_char1) ;
         AV11tCurrentCode = GXt_char1;
         edtavXt_definecode_xt_definecodeid_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavXt_definecode_xt_definecodeid_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavXt_definecode_xt_definecodeid_Visible), 5, 0)), true);
         edtavXt_definecode_xt_definecodeorder_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavXt_definecode_xt_definecodeorder_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavXt_definecode_xt_definecodeorder_Visible), 5, 0)), true);
         edtavXt_definecode_xt_typecode_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavXt_definecode_xt_typecode_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavXt_definecode_xt_typecode_Visible), 5, 0)), true);
         edtavXt_definecode_xt_tenantcode_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavXt_definecode_xt_tenantcode_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavXt_definecode_xt_tenantcode_Visible), 5, 0)), true);
         cmbavXt_definecode_xt_definecodeintialtype.Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavXt_definecode_xt_definecodeintialtype_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(cmbavXt_definecode_xt_definecodeintialtype.Visible), 5, 0)), true);
         AV10XT_DefineCode.Load(AV12XT_DefineCodeID);
         GX_msglist.addItem("确认删除");
      }

      protected void S112( )
      {
         /* 'SHOW MESSAGES' Routine */
         AV24GXV9 = 1;
         while ( AV24GXV9 <= AV8Messages.Count )
         {
            AV7Message = ((SdtMessages_Message)AV8Messages.Item(AV24GXV9));
            GX_msglist.addItem(AV7Message.gxTpr_Description);
            AV24GXV9 = (int)(AV24GXV9+1);
         }
      }

      protected void E128U2( )
      {
         /* Refresh Routine */
         new GeneXus.Programs.wwpbaseobjects.loadwwpcontext(context ).execute( out  AV9Context) ;
      }

      public void GXEnter( )
      {
         /* Execute user event: Enter */
         E138U2 ();
         if (returnInSub) return;
      }

      protected void E138U2( )
      {
         /* Enter Routine */
         new zutil_checksession(context ).execute( out  AV13tCheckFlag) ;
         if ( ! AV13tCheckFlag )
         {
            AV10XT_DefineCode.Delete();
            context.CommitDataStores("xt_definecodedelete",pr_default);
            context.setWebReturnParms(new Object[] {});
            context.setWebReturnParmsMetadata(new Object[] {});
            context.wjLocDisableFrm = 1;
            context.nUserReturn = 1;
            returnInSub = true;
            if (true) return;
         }
      }

      protected void nextLoad( )
      {
      }

      protected void E148U2( )
      {
         /* Load Routine */
      }

      public override void setparameters( Object[] obj )
      {
         createObjects();
         initialize();
         AV12XT_DefineCodeID = Convert.ToInt64(getParm(obj,0));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12XT_DefineCodeID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV12XT_DefineCodeID), 18, 0)));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vXT_DEFINECODEID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV12XT_DefineCodeID), "ZZZZZZZZZZZZZZZZZZ"), context));
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
         PA8U2( ) ;
         WS8U2( ) ;
         WE8U2( ) ;
         this.cleanup();
         context.SetWrapped(false);
         context.GX_msglist = BackMsgLst;
         return "";
      }

      public void responsestatic( String sGXDynURL )
      {
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
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?202022815165233", true);
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
         context.AddJavascriptSource("messages.chs.js", "?"+GetCacheInvalidationToken( ), false);
         context.AddJavascriptSource("gxdec.js", "?"+context.GetBuildNumber( 127771), false);
         context.AddJavascriptSource("xt_definecodedelete.js", "?202022815165233", false);
         context.AddJavascriptSource("DVelop/Bootstrap/Shared/DVelopBootstrap.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/Panel/BootstrapPanelRender.js", "", false);
         /* End function include_jscripts */
      }

      protected void init_web_controls( )
      {
         cmbavXt_definecode_xt_definecodeintialtype.Name = "XT_DEFINECODE_XT_DEFINECODEINTIALTYPE";
         cmbavXt_definecode_xt_definecodeintialtype.WebTags = "";
         cmbavXt_definecode_xt_definecodeintialtype.addItem("1", "yes", 0);
         cmbavXt_definecode_xt_definecodeintialtype.addItem("2", "no", 0);
         if ( cmbavXt_definecode_xt_definecodeintialtype.ItemCount > 0 )
         {
            AV10XT_DefineCode.gxTpr_Xt_definecodeintialtype = (short)(NumberUtil.Val( cmbavXt_definecode_xt_definecodeintialtype.getValidValue(StringUtil.Trim( StringUtil.Str( (decimal)(AV10XT_DefineCode.gxTpr_Xt_definecodeintialtype), 4, 0))), "."));
         }
         /* End function init_web_controls */
      }

      protected void init_default_properties( )
      {
         edtavXt_definecode_xt_definecodename_Internalname = "XT_DEFINECODE_XT_DEFINECODENAME";
         edtavXt_definecode_xt_defindcodetypeid_Internalname = "XT_DEFINECODE_XT_DEFINDCODETYPEID";
         edtavXt_definecode_xt_defindcodetypename_Internalname = "XT_DEFINECODE_XT_DEFINDCODETYPENAME";
         divTableattributes_Internalname = "TABLEATTRIBUTES";
         divLayout_tableattributes_Internalname = "LAYOUT_TABLEATTRIBUTES";
         Dvpanel_tableattributes_Internalname = "DVPANEL_TABLEATTRIBUTES";
         divHtml_dvpanel_tableattributes_Internalname = "HTML_DVPANEL_TABLEATTRIBUTES";
         divTablecontent_Internalname = "TABLECONTENT";
         bttBtnenter_Internalname = "BTNENTER";
         bttBtncancel_Internalname = "BTNCANCEL";
         divTablemain_Internalname = "TABLEMAIN";
         edtavXt_definecode_xt_definecodeid_Internalname = "XT_DEFINECODE_XT_DEFINECODEID";
         edtavXt_definecode_xt_definecodeorder_Internalname = "XT_DEFINECODE_XT_DEFINECODEORDER";
         edtavXt_definecode_xt_typecode_Internalname = "XT_DEFINECODE_XT_TYPECODE";
         edtavXt_definecode_xt_tenantcode_Internalname = "XT_DEFINECODE_XT_TENANTCODE";
         cmbavXt_definecode_xt_definecodeintialtype_Internalname = "XT_DEFINECODE_XT_DEFINECODEINTIALTYPE";
         divHtml_bottomauxiliarcontrols_Internalname = "HTML_BOTTOMAUXILIARCONTROLS";
         divLayoutmaintable_Internalname = "LAYOUTMAINTABLE";
         Form.Internalname = "FORM";
      }

      public override void initialize_properties( )
      {
         context.SetDefaultTheme("WorkWithPlusTheme");
         if ( context.isSpaRequest( ) )
         {
            disableJsOutput();
         }
         init_default_properties( ) ;
         edtavXt_definecode_xt_defindcodetypename_Enabled = -1;
         edtavXt_definecode_xt_defindcodetypeid_Enabled = -1;
         edtavXt_definecode_xt_definecodename_Enabled = -1;
         cmbavXt_definecode_xt_definecodeintialtype_Jsonclick = "";
         cmbavXt_definecode_xt_definecodeintialtype.Visible = 1;
         edtavXt_definecode_xt_tenantcode_Jsonclick = "";
         edtavXt_definecode_xt_tenantcode_Visible = 1;
         edtavXt_definecode_xt_typecode_Jsonclick = "";
         edtavXt_definecode_xt_typecode_Visible = 1;
         edtavXt_definecode_xt_definecodeorder_Jsonclick = "";
         edtavXt_definecode_xt_definecodeorder_Visible = 1;
         edtavXt_definecode_xt_definecodeid_Jsonclick = "";
         edtavXt_definecode_xt_definecodeid_Visible = 1;
         edtavXt_definecode_xt_defindcodetypename_Jsonclick = "";
         edtavXt_definecode_xt_defindcodetypename_Enabled = 0;
         edtavXt_definecode_xt_defindcodetypeid_Jsonclick = "";
         edtavXt_definecode_xt_defindcodetypeid_Enabled = 0;
         edtavXt_definecode_xt_definecodename_Jsonclick = "";
         edtavXt_definecode_xt_definecodename_Enabled = 0;
         Dvpanel_tableattributes_Autoscroll = Convert.ToBoolean( 0);
         Dvpanel_tableattributes_Iconposition = "left";
         Dvpanel_tableattributes_Showcollapseicon = Convert.ToBoolean( 0);
         Dvpanel_tableattributes_Autoheight = Convert.ToBoolean( -1);
         Dvpanel_tableattributes_Autowidth = Convert.ToBoolean( 0);
         Dvpanel_tableattributes_Collapsed = Convert.ToBoolean( 0);
         Dvpanel_tableattributes_Collapsible = Convert.ToBoolean( 0);
         Dvpanel_tableattributes_Title = "数据字典信息";
         Dvpanel_tableattributes_Cls = "PanelCard_BaseColor";
         Dvpanel_tableattributes_Width = "100%";
         Form.Headerrawhtml = "";
         Form.Background = "";
         Form.Textcolor = 0;
         Form.Backcolor = (int)(0xFFFFFF);
         Form.Caption = "";
         context.GX_msglist.DisplayMode = 1;
         if ( context.isSpaRequest( ) )
         {
            enableJsOutput();
         }
      }

      public override bool SupportAjaxEvent( )
      {
         return true ;
      }

      public override void InitializeDynEvents( )
      {
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[{av:'AV12XT_DefineCodeID',fld:'vXT_DEFINECODEID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true},{av:'AV10XT_DefineCode.gxTpr_Xt_definecodename',fld:'XT_DEFINECODE_XT_DEFINECODENAME',pic:''},{av:'AV10XT_DefineCode.gxTpr_Xt_defindcodetypeid',fld:'XT_DEFINECODE_XT_DEFINDCODETYPEID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV10XT_DefineCode.gxTpr_Xt_defindcodetypename',fld:'XT_DEFINECODE_XT_DEFINDCODETYPENAME',pic:''}]");
         setEventMetadata("REFRESH",",oparms:[]}");
         setEventMetadata("ENTER","{handler:'E138U2',iparms:[{av:'AV10XT_DefineCode',fld:'vXT_DEFINECODE',pic:''}]");
         setEventMetadata("ENTER",",oparms:[]}");
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
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         GXKey = "";
         forbiddenHiddens = "";
         AV10XT_DefineCode = new SdtXT_DefineCode(context);
         GX_FocusControl = "";
         Form = new GXWebForm();
         sPrefix = "";
         ClassString = "";
         StyleString = "";
         ucDvpanel_tableattributes = new GXUserControl();
         TempTags = "";
         bttBtnenter_Jsonclick = "";
         bttBtncancel_Jsonclick = "";
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         hsh = "";
         AV11tCurrentCode = "";
         GXt_char1 = "";
         AV8Messages = new GXBaseCollection<SdtMessages_Message>( context, "Message", "GeneXus");
         AV7Message = new SdtMessages_Message(context);
         AV9Context = new GeneXus.Programs.wwpbaseobjects.SdtWWPContext(context);
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         pr_datastore1 = new DataStoreProvider(context, new GeneXus.Programs.xt_definecodedelete__datastore1(),
            new Object[][] {
            }
         );
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.xt_definecodedelete__default(),
            new Object[][] {
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0;
         edtavXt_definecode_xt_definecodename_Enabled = 0;
         edtavXt_definecode_xt_defindcodetypeid_Enabled = 0;
         edtavXt_definecode_xt_defindcodetypename_Enabled = 0;
      }

      private short nGotPars ;
      private short GxWebError ;
      private short initialized ;
      private short gxajaxcallmode ;
      private short wbEnd ;
      private short wbStart ;
      private short nDonePA ;
      private short gxcookieaux ;
      private short nGXWrapped ;
      private int edtavXt_definecode_xt_definecodename_Enabled ;
      private int edtavXt_definecode_xt_defindcodetypeid_Enabled ;
      private int edtavXt_definecode_xt_defindcodetypename_Enabled ;
      private int edtavXt_definecode_xt_definecodeid_Visible ;
      private int edtavXt_definecode_xt_definecodeorder_Visible ;
      private int edtavXt_definecode_xt_typecode_Visible ;
      private int edtavXt_definecode_xt_tenantcode_Visible ;
      private int AV24GXV9 ;
      private int idxLst ;
      private long AV12XT_DefineCodeID ;
      private long wcpOAV12XT_DefineCodeID ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String sDynURL ;
      private String FormProcess ;
      private String bodyStyle ;
      private String GXKey ;
      private String forbiddenHiddens ;
      private String Dvpanel_tableattributes_Width ;
      private String Dvpanel_tableattributes_Cls ;
      private String Dvpanel_tableattributes_Title ;
      private String Dvpanel_tableattributes_Iconposition ;
      private String GX_FocusControl ;
      private String sPrefix ;
      private String divLayoutmaintable_Internalname ;
      private String divTablemain_Internalname ;
      private String ClassString ;
      private String StyleString ;
      private String divTablecontent_Internalname ;
      private String divHtml_dvpanel_tableattributes_Internalname ;
      private String Dvpanel_tableattributes_Internalname ;
      private String divLayout_tableattributes_Internalname ;
      private String divTableattributes_Internalname ;
      private String edtavXt_definecode_xt_definecodename_Internalname ;
      private String edtavXt_definecode_xt_definecodename_Jsonclick ;
      private String edtavXt_definecode_xt_defindcodetypeid_Internalname ;
      private String edtavXt_definecode_xt_defindcodetypeid_Jsonclick ;
      private String edtavXt_definecode_xt_defindcodetypename_Internalname ;
      private String edtavXt_definecode_xt_defindcodetypename_Jsonclick ;
      private String TempTags ;
      private String bttBtnenter_Internalname ;
      private String bttBtnenter_Jsonclick ;
      private String bttBtncancel_Internalname ;
      private String bttBtncancel_Jsonclick ;
      private String divHtml_bottomauxiliarcontrols_Internalname ;
      private String edtavXt_definecode_xt_definecodeid_Internalname ;
      private String edtavXt_definecode_xt_definecodeid_Jsonclick ;
      private String edtavXt_definecode_xt_definecodeorder_Internalname ;
      private String edtavXt_definecode_xt_definecodeorder_Jsonclick ;
      private String edtavXt_definecode_xt_typecode_Internalname ;
      private String edtavXt_definecode_xt_typecode_Jsonclick ;
      private String edtavXt_definecode_xt_tenantcode_Internalname ;
      private String edtavXt_definecode_xt_tenantcode_Jsonclick ;
      private String cmbavXt_definecode_xt_definecodeintialtype_Internalname ;
      private String cmbavXt_definecode_xt_definecodeintialtype_Jsonclick ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String hsh ;
      private String GXt_char1 ;
      private bool entryPointCalled ;
      private bool toggleJsOutput ;
      private bool Dvpanel_tableattributes_Collapsible ;
      private bool Dvpanel_tableattributes_Collapsed ;
      private bool Dvpanel_tableattributes_Autowidth ;
      private bool Dvpanel_tableattributes_Autoheight ;
      private bool Dvpanel_tableattributes_Showcollapseicon ;
      private bool Dvpanel_tableattributes_Autoscroll ;
      private bool wbLoad ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool gxdyncontrolsrefreshing ;
      private bool returnInSub ;
      private bool AV13tCheckFlag ;
      private String AV11tCurrentCode ;
      private GXUserControl ucDvpanel_tableattributes ;
      private IGxDataStore dsDataStore1 ;
      private IGxDataStore dsDefault ;
      private GXCombobox cmbavXt_definecode_xt_definecodeintialtype ;
      private IDataStoreProvider pr_default ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private IDataStoreProvider pr_datastore1 ;
      private GXBaseCollection<SdtMessages_Message> AV8Messages ;
      private GXWebForm Form ;
      private SdtMessages_Message AV7Message ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPContext AV9Context ;
      private SdtXT_DefineCode AV10XT_DefineCode ;
   }

   public class xt_definecodedelete__datastore1 : DataStoreHelperBase, IDataStoreHelper
   {
      public ICursor[] getCursors( )
      {
         cursorDefinitions();
         return new Cursor[] {
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          def= new CursorDef[] {
          };
       }
    }

    public void getResults( int cursor ,
                            IFieldGetter rslt ,
                            Object[] buf )
    {
       switch ( cursor )
       {
       }
    }

    public void setParameters( int cursor ,
                               IFieldSetter stmt ,
                               Object[] parms )
    {
       switch ( cursor )
       {
       }
    }

    public String getDataStoreName( )
    {
       return "DATASTORE1";
    }

 }

 public class xt_definecodedelete__default : DataStoreHelperBase, IDataStoreHelper
 {
    public ICursor[] getCursors( )
    {
       cursorDefinitions();
       return new Cursor[] {
     };
  }

  private static CursorDef[] def;
  private void cursorDefinitions( )
  {
     if ( def == null )
     {
        def= new CursorDef[] {
        };
     }
  }

  public void getResults( int cursor ,
                          IFieldGetter rslt ,
                          Object[] buf )
  {
     switch ( cursor )
     {
     }
  }

  public void setParameters( int cursor ,
                             IFieldSetter stmt ,
                             Object[] parms )
  {
     switch ( cursor )
     {
     }
  }

}

}
