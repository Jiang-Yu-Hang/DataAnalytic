/*
               File: XT_DefineCodeOperate
        Description: Data Mgmt Portal - RAAP
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/27/2020 9:47:6.58
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
   public class xt_definecodeoperate : GXDataArea, System.Web.SessionState.IRequiresSessionState
   {
      public xt_definecodeoperate( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public xt_definecodeoperate( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( short aP0_iType ,
                           long aP1_XT_DefineCodeID ,
                           long aP2_iXT_DefindcodeTypeID )
      {
         this.AV21iType = aP0_iType;
         this.AV7XT_DefineCodeID = aP1_XT_DefineCodeID;
         this.AV11iXT_DefindcodeTypeID = aP2_iXT_DefindcodeTypeID;
         executePrivate();
      }

      void executePrivate( )
      {
         isStatic = false;
         webExecute();
      }

      protected override void createObjects( )
      {
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
               AV21iType = (short)(NumberUtil.Val( gxfirstwebparm, "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV21iType", StringUtil.LTrim( StringUtil.Str( (decimal)(AV21iType), 4, 0)));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vITYPE", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV21iType), "ZZZ9"), context));
               if ( StringUtil.StrCmp(gxfirstwebparm, "viewer") != 0 )
               {
                  AV7XT_DefineCodeID = (long)(NumberUtil.Val( GetNextPar( ), "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7XT_DefineCodeID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV7XT_DefineCodeID), 18, 0)));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vXT_DEFINECODEID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV7XT_DefineCodeID), "ZZZZZZZZZZZZZZZZZZ"), context));
                  AV11iXT_DefindcodeTypeID = (long)(NumberUtil.Val( GetNextPar( ), "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11iXT_DefindcodeTypeID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11iXT_DefindcodeTypeID), 18, 0)));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vIXT_DEFINDCODETYPEID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV11iXT_DefindcodeTypeID), "ZZZZZZZZZZZZZZZZZZ"), context));
               }
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
         PA7R2( ) ;
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0));
         if ( ( gxajaxcallmode == 0 ) && ( GxWebError == 0 ) )
         {
            START7R2( ) ;
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
         context.AddJavascriptSource("gxcfg.js", "?2020227947662", false);
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" autocomplete=\"off\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("xt_definecodeoperate.aspx") + "?" + UrlEncode("" +AV21iType) + "," + UrlEncode("" +AV7XT_DefineCodeID) + "," + UrlEncode("" +AV11iXT_DefindcodeTypeID)+"\">") ;
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
      }

      protected void SendCloseFormHiddens( )
      {
         /* Send hidden variables. */
         /* Send saved values. */
         send_integrity_footer_hashes( ) ;
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "Xt_definecode", AV19XT_DefineCode);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("Xt_definecode", AV19XT_DefineCode);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vXT_DEFINECODE", AV19XT_DefineCode);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vXT_DEFINECODE", AV19XT_DefineCode);
         }
         GxWebStd.gx_hidden_field( context, "vITYPE", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV21iType), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "gxhash_vITYPE", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV21iType), "ZZZ9"), context));
         GxWebStd.gx_hidden_field( context, "vTOLDXT_DEFINECODENAME", AV5tOldXT_DefineCodeName);
         GxWebStd.gx_hidden_field( context, "gxhash_vTOLDXT_DEFINECODENAME", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( AV5tOldXT_DefineCodeName, "")), context));
         GxWebStd.gx_hidden_field( context, "vIXT_DEFINDCODETYPEID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV11iXT_DefindcodeTypeID), 18, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "gxhash_vIXT_DEFINDCODETYPEID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV11iXT_DefindcodeTypeID), "ZZZZZZZZZZZZZZZZZZ"), context));
         GxWebStd.gx_hidden_field( context, "vXT_DEFINECODEID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV7XT_DefineCodeID), 18, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "gxhash_vXT_DEFINECODEID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV7XT_DefineCodeID), "ZZZZZZZZZZZZZZZZZZ"), context));
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
            WE7R2( ) ;
            context.WriteHtmlText( "</div>") ;
         }
      }

      public override void DispatchEvents( )
      {
         EVT7R2( ) ;
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
         return formatLink("xt_definecodeoperate.aspx") + "?" + UrlEncode("" +AV21iType) + "," + UrlEncode("" +AV7XT_DefineCodeID) + "," + UrlEncode("" +AV11iXT_DefindcodeTypeID) ;
      }

      public override String GetPgmname( )
      {
         return "XT_DefineCodeOperate" ;
      }

      public override String GetPgmdesc( )
      {
         return "Data Mgmt Portal - RAAP" ;
      }

      protected void WB7R0( )
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
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 RequiredDataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtavXt_definecode_xt_definecodename_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavXt_definecode_xt_definecodename_Internalname, "数据字典名称", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 25,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavXt_definecode_xt_definecodename_Internalname, AV19XT_DefineCode.gxTpr_Xt_definecodename, StringUtil.RTrim( context.localUtil.Format( AV19XT_DefineCode.gxTpr_Xt_definecodename, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,25);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavXt_definecode_xt_definecodename_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtavXt_definecode_xt_definecodename_Enabled, 0, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_XT_DefineCodeOperate.htm");
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
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 30,'',false,'',0)\"";
            ClassString = "ButtonMaterial";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtnenter_Internalname, "", "确认", bttBtnenter_Jsonclick, 5, "确认", "", StyleString, ClassString, 1, 1, "standard", "'"+""+"'"+",false,"+"'"+"EENTER."+"'", TempTags, "", context.GetButtonType( ), "HLP_XT_DefineCodeOperate.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 32,'',false,'',0)\"";
            ClassString = "ButtonMaterialDefault";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtncancel_Internalname, "", "取消", bttBtncancel_Jsonclick, 1, "取消", "", StyleString, ClassString, 1, 1, "standard", "'"+""+"'"+",false,"+"'"+"ECANCEL."+"'", TempTags, "", context.GetButtonType( ), "HLP_XT_DefineCodeOperate.htm");
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
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 36,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavXt_definecode_xt_definecodeid_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV19XT_DefineCode.gxTpr_Xt_definecodeid), 18, 0, ".", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(AV19XT_DefineCode.gxTpr_Xt_definecodeid), "ZZZZZZZZZZZZZZZZZZ")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,36);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavXt_definecode_xt_definecodeid_Jsonclick, 0, "Attribute", "", "", "", "", edtavXt_definecode_xt_definecodeid_Visible, 1, 0, "number", "1", 18, "chr", 1, "row", 18, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_XT_DefineCodeOperate.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 37,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavXt_definecode_xt_definecodeorder_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV19XT_DefineCode.gxTpr_Xt_definecodeorder), 4, 0, ".", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(AV19XT_DefineCode.gxTpr_Xt_definecodeorder), "ZZZZ")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,37);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavXt_definecode_xt_definecodeorder_Jsonclick, 0, "Attribute", "", "", "", "", edtavXt_definecode_xt_definecodeorder_Visible, 1, 0, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_XT_DefineCodeOperate.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 38,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavXt_definecode_xt_typecode_Internalname, AV19XT_DefineCode.gxTpr_Xt_typecode, StringUtil.RTrim( context.localUtil.Format( AV19XT_DefineCode.gxTpr_Xt_typecode, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,38);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavXt_definecode_xt_typecode_Jsonclick, 0, "Attribute", "", "", "", "", edtavXt_definecode_xt_typecode_Visible, 1, 0, "text", "", 40, "chr", 1, "row", 40, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_XT_DefineCodeOperate.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 39,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavXt_definecode_xt_tenantcode_Internalname, AV19XT_DefineCode.gxTpr_Xt_tenantcode, StringUtil.RTrim( context.localUtil.Format( AV19XT_DefineCode.gxTpr_Xt_tenantcode, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,39);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavXt_definecode_xt_tenantcode_Jsonclick, 0, "Attribute", "", "", "", "", edtavXt_definecode_xt_tenantcode_Visible, 1, 0, "text", "", 40, "chr", 1, "row", 40, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_XT_DefineCodeOperate.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
         }
         wbLoad = true;
      }

      protected void START7R2( )
      {
         wbLoad = false;
         wbEnd = 0;
         wbStart = 0;
         if ( ! context.isSpaRequest( ) )
         {
            Form.Meta.addItem("generator", "GeneXus C# 16_0_0-127771", 0) ;
            Form.Meta.addItem("description", "Data Mgmt Portal - RAAP", 0) ;
         }
         context.wjLoc = "";
         context.nUserReturn = 0;
         context.wbHandled = 0;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         wbErr = false;
         STRUP7R0( ) ;
      }

      protected void WS7R2( )
      {
         START7R2( ) ;
         EVT7R2( ) ;
      }

      protected void EVT7R2( )
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
                              E117R2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "REFRESH") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              /* Execute user event: Refresh */
                              E127R2 ();
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
                                    E137R2 ();
                                 }
                                 dynload_actions( ) ;
                              }
                           }
                           else if ( StringUtil.StrCmp(sEvt, "LOAD") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              /* Execute user event: Load */
                              E147R2 ();
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

      protected void WE7R2( )
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

      protected void PA7R2( )
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
      }

      public void Refresh( )
      {
         send_integrity_hashes( ) ;
         RF7R2( ) ;
         if ( isFullAjaxMode( ) )
         {
            send_integrity_footer_hashes( ) ;
         }
      }

      protected void initialize_formulas( )
      {
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      protected void RF7R2( )
      {
         initialize_formulas( ) ;
         clear_multi_value_controls( ) ;
         /* Execute user event: Refresh */
         E127R2 ();
         gxdyncontrolsrefreshing = true;
         fix_multi_value_controls( ) ;
         gxdyncontrolsrefreshing = false;
         if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
         {
            /* Execute user event: Load */
            E147R2 ();
            WB7R0( ) ;
         }
      }

      protected void send_integrity_lvl_hashes7R2( )
      {
         GxWebStd.gx_hidden_field( context, "vITYPE", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV21iType), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "gxhash_vITYPE", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV21iType), "ZZZ9"), context));
         GxWebStd.gx_hidden_field( context, "vTOLDXT_DEFINECODENAME", AV5tOldXT_DefineCodeName);
         GxWebStd.gx_hidden_field( context, "gxhash_vTOLDXT_DEFINECODENAME", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( AV5tOldXT_DefineCodeName, "")), context));
         GxWebStd.gx_hidden_field( context, "vIXT_DEFINDCODETYPEID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV11iXT_DefindcodeTypeID), 18, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "gxhash_vIXT_DEFINDCODETYPEID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV11iXT_DefindcodeTypeID), "ZZZZZZZZZZZZZZZZZZ"), context));
      }

      protected void STRUP7R0( )
      {
         /* Before Start, stand alone formulas. */
         context.Gx_err = 0;
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0;
         /* Execute user event: Start */
         E117R2 ();
         context.wbGlbDoneStart = 1;
         /* After Start, stand alone formulas. */
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read saved SDTs. */
            ajax_req_read_hidden_sdt(cgiGet( "Xt_definecode"), AV19XT_DefineCode);
            /* Read variables values. */
            AV19XT_DefineCode.gxTpr_Xt_definecodename = cgiGet( edtavXt_definecode_xt_definecodename_Internalname);
            if ( ( ( context.localUtil.CToN( cgiGet( edtavXt_definecode_xt_definecodeid_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavXt_definecode_xt_definecodeid_Internalname), ".", ",") > Convert.ToDecimal( 999999999999999999L )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "XT_DEFINECODE_XT_DEFINECODEID");
               GX_FocusControl = edtavXt_definecode_xt_definecodeid_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV19XT_DefineCode.gxTpr_Xt_definecodeid = 0;
            }
            else
            {
               AV19XT_DefineCode.gxTpr_Xt_definecodeid = (long)(context.localUtil.CToN( cgiGet( edtavXt_definecode_xt_definecodeid_Internalname), ".", ","));
            }
            if ( ( ( context.localUtil.CToN( cgiGet( edtavXt_definecode_xt_definecodeorder_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavXt_definecode_xt_definecodeorder_Internalname), ".", ",") > Convert.ToDecimal( 9999 )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "XT_DEFINECODE_XT_DEFINECODEORDER");
               GX_FocusControl = edtavXt_definecode_xt_definecodeorder_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV19XT_DefineCode.gxTpr_Xt_definecodeorder = 0;
            }
            else
            {
               AV19XT_DefineCode.gxTpr_Xt_definecodeorder = (short)(context.localUtil.CToN( cgiGet( edtavXt_definecode_xt_definecodeorder_Internalname), ".", ","));
            }
            AV19XT_DefineCode.gxTpr_Xt_typecode = cgiGet( edtavXt_definecode_xt_typecode_Internalname);
            AV19XT_DefineCode.gxTpr_Xt_tenantcode = cgiGet( edtavXt_definecode_xt_tenantcode_Internalname);
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
         }
         else
         {
            dynload_actions( ) ;
         }
      }

      protected void GXStart( )
      {
         /* Execute user event: Start */
         E117R2 ();
         if (returnInSub) return;
      }

      protected void E117R2( )
      {
         /* Start Routine */
         edtavXt_definecode_xt_definecodeid_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavXt_definecode_xt_definecodeid_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavXt_definecode_xt_definecodeid_Visible), 5, 0)), true);
         edtavXt_definecode_xt_definecodeorder_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavXt_definecode_xt_definecodeorder_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavXt_definecode_xt_definecodeorder_Visible), 5, 0)), true);
         edtavXt_definecode_xt_typecode_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavXt_definecode_xt_typecode_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavXt_definecode_xt_typecode_Visible), 5, 0)), true);
         edtavXt_definecode_xt_tenantcode_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavXt_definecode_xt_tenantcode_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavXt_definecode_xt_tenantcode_Visible), 5, 0)), true);
         if ( AV21iType == 1 )
         {
            AV19XT_DefineCode.gxTpr_Xt_defindcodetypeid = AV11iXT_DefindcodeTypeID;
         }
         if ( AV21iType == 2 )
         {
            AV19XT_DefineCode.Load(AV7XT_DefineCodeID);
            AV5tOldXT_DefineCodeName = AV19XT_DefineCode.gxTpr_Xt_definecodename;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV5tOldXT_DefineCodeName", AV5tOldXT_DefineCodeName);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vTOLDXT_DEFINECODENAME", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( AV5tOldXT_DefineCodeName, "")), context));
         }
      }

      protected void S112( )
      {
         /* 'CHECKREQUIREDFIELDS' Routine */
         AV8CheckRequiredFieldsResult = true;
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV19XT_DefineCode.gxTpr_Xt_definecodename)) )
         {
            GX_msglist.addItem("数据字典名称是必须填写的。");
            AV8CheckRequiredFieldsResult = false;
         }
      }

      protected void S122( )
      {
         /* 'SHOW MESSAGES' Routine */
         AV30GXV6 = 1;
         while ( AV30GXV6 <= AV13Messages.Count )
         {
            AV12Message = ((SdtMessages_Message)AV13Messages.Item(AV30GXV6));
            GX_msglist.addItem(AV12Message.gxTpr_Description);
            AV30GXV6 = (int)(AV30GXV6+1);
         }
      }

      protected void E127R2( )
      {
         /* Refresh Routine */
         new GeneXus.Programs.wwpbaseobjects.loadwwpcontext(context ).execute( out  AV9Context) ;
      }

      public void GXEnter( )
      {
         /* Execute user event: Enter */
         E137R2 ();
         if (returnInSub) return;
      }

      protected void E137R2( )
      {
         /* Enter Routine */
         new zutil_checksession(context ).execute( out  AV22tCheckFlag) ;
         if ( ! AV22tCheckFlag )
         {
            AV17tFlag = true;
            if ( String.IsNullOrEmpty(StringUtil.RTrim( AV19XT_DefineCode.gxTpr_Xt_definecodename)) )
            {
               GX_msglist.addItem("请输入数据字典名称");
               AV17tFlag = false;
            }
            if ( ( AV17tFlag ) && ( StringUtil.StrCmp(AV19XT_DefineCode.gxTpr_Xt_definecodename, "其它") == 0 ) )
            {
               GX_msglist.addItem("不可输入\"其它\"，请重新输入");
               AV17tFlag = false;
            }
            if ( AV17tFlag )
            {
               new zbr_checkdefinecodenameifhas(context ).execute(  AV21iType,  AV19XT_DefineCode.gxTpr_Xt_definecodename,  AV5tOldXT_DefineCodeName,  AV11iXT_DefindcodeTypeID, out  AV17tFlag) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV21iType", StringUtil.LTrim( StringUtil.Str( (decimal)(AV21iType), 4, 0)));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vITYPE", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV21iType), "ZZZ9"), context));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV5tOldXT_DefineCodeName", AV5tOldXT_DefineCodeName);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vTOLDXT_DEFINECODENAME", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( AV5tOldXT_DefineCodeName, "")), context));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11iXT_DefindcodeTypeID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11iXT_DefindcodeTypeID), 18, 0)));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vIXT_DEFINDCODETYPEID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV11iXT_DefindcodeTypeID), "ZZZZZZZZZZZZZZZZZZ"), context));
               if ( ! AV17tFlag )
               {
                  GX_msglist.addItem("数据字典名称已经存在，请重新输入");
               }
            }
            if ( AV17tFlag )
            {
               GXt_char1 = "";
               new zbr_getcurrenttcode(context ).execute( out  GXt_char1) ;
               AV19XT_DefineCode.gxTpr_Xt_tenantcode = GXt_char1;
               AV19XT_DefineCode.gxTpr_Xt_definecodeintialtype = 2;
               AV19XT_DefineCode.gxTpr_Xt_defindcodetypeid = AV11iXT_DefindcodeTypeID;
               AV19XT_DefineCode.Save();
               if ( AV19XT_DefineCode.Success() )
               {
                  context.CommitDataStores("xt_definecodeoperate",pr_default);
                  context.setWebReturnParms(new Object[] {});
                  context.setWebReturnParmsMetadata(new Object[] {});
                  context.wjLocDisableFrm = 1;
                  context.nUserReturn = 1;
                  returnInSub = true;
                  if (true) return;
               }
               else
               {
                  AV20Errormsg = "";
                  AV32GXV8 = 1;
                  AV31GXV7 = AV19XT_DefineCode.GetMessages();
                  while ( AV32GXV8 <= AV31GXV7.Count )
                  {
                     AV12Message = ((SdtMessages_Message)AV31GXV7.Item(AV32GXV8));
                     AV20Errormsg = AV20Errormsg + StringUtil.Trim( AV12Message.gxTpr_Description);
                     AV32GXV8 = (int)(AV32GXV8+1);
                  }
                  GX_msglist.addItem(AV20Errormsg);
               }
            }
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV19XT_DefineCode", AV19XT_DefineCode);
      }

      protected void nextLoad( )
      {
      }

      protected void E147R2( )
      {
         /* Load Routine */
      }

      public override void setparameters( Object[] obj )
      {
         createObjects();
         initialize();
         AV21iType = Convert.ToInt16(getParm(obj,0));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV21iType", StringUtil.LTrim( StringUtil.Str( (decimal)(AV21iType), 4, 0)));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vITYPE", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV21iType), "ZZZ9"), context));
         AV7XT_DefineCodeID = Convert.ToInt64(getParm(obj,1));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7XT_DefineCodeID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV7XT_DefineCodeID), 18, 0)));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vXT_DEFINECODEID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV7XT_DefineCodeID), "ZZZZZZZZZZZZZZZZZZ"), context));
         AV11iXT_DefindcodeTypeID = Convert.ToInt64(getParm(obj,2));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11iXT_DefindcodeTypeID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11iXT_DefindcodeTypeID), 18, 0)));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vIXT_DEFINDCODETYPEID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV11iXT_DefindcodeTypeID), "ZZZZZZZZZZZZZZZZZZ"), context));
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
         PA7R2( ) ;
         WS7R2( ) ;
         WE7R2( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?2020227947753", true);
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
         context.AddJavascriptSource("xt_definecodeoperate.js", "?2020227947753", false);
         context.AddJavascriptSource("DVelop/Bootstrap/Shared/DVelopBootstrap.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/Panel/BootstrapPanelRender.js", "", false);
         /* End function include_jscripts */
      }

      protected void init_web_controls( )
      {
         /* End function init_web_controls */
      }

      protected void init_default_properties( )
      {
         edtavXt_definecode_xt_definecodename_Internalname = "XT_DEFINECODE_XT_DEFINECODENAME";
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
         edtavXt_definecode_xt_tenantcode_Jsonclick = "";
         edtavXt_definecode_xt_tenantcode_Visible = 1;
         edtavXt_definecode_xt_typecode_Jsonclick = "";
         edtavXt_definecode_xt_typecode_Visible = 1;
         edtavXt_definecode_xt_definecodeorder_Jsonclick = "";
         edtavXt_definecode_xt_definecodeorder_Visible = 1;
         edtavXt_definecode_xt_definecodeid_Jsonclick = "";
         edtavXt_definecode_xt_definecodeid_Visible = 1;
         edtavXt_definecode_xt_definecodename_Jsonclick = "";
         edtavXt_definecode_xt_definecodename_Enabled = 1;
         Dvpanel_tableattributes_Autoscroll = Convert.ToBoolean( 0);
         Dvpanel_tableattributes_Iconposition = "left";
         Dvpanel_tableattributes_Showcollapseicon = Convert.ToBoolean( 0);
         Dvpanel_tableattributes_Autoheight = Convert.ToBoolean( -1);
         Dvpanel_tableattributes_Autowidth = Convert.ToBoolean( 0);
         Dvpanel_tableattributes_Collapsed = Convert.ToBoolean( 0);
         Dvpanel_tableattributes_Collapsible = Convert.ToBoolean( 0);
         Dvpanel_tableattributes_Title = "数据字典";
         Dvpanel_tableattributes_Cls = "PanelCard_BaseColor";
         Dvpanel_tableattributes_Width = "100%";
         Form.Headerrawhtml = "";
         Form.Background = "";
         Form.Textcolor = 0;
         Form.Backcolor = (int)(0xFFFFFF);
         Form.Caption = "Data Mgmt Portal - RAAP";
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
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[{av:'AV21iType',fld:'vITYPE',pic:'ZZZ9',hsh:true},{av:'AV11iXT_DefindcodeTypeID',fld:'vIXT_DEFINDCODETYPEID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true},{av:'AV7XT_DefineCodeID',fld:'vXT_DEFINECODEID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true},{av:'AV5tOldXT_DefineCodeName',fld:'vTOLDXT_DEFINECODENAME',pic:'',hsh:true}]");
         setEventMetadata("REFRESH",",oparms:[]}");
         setEventMetadata("ENTER","{handler:'E137R2',iparms:[{av:'AV19XT_DefineCode',fld:'vXT_DEFINECODE',pic:''},{av:'AV21iType',fld:'vITYPE',pic:'ZZZ9',hsh:true},{av:'AV5tOldXT_DefineCodeName',fld:'vTOLDXT_DEFINECODENAME',pic:'',hsh:true},{av:'AV11iXT_DefindcodeTypeID',fld:'vIXT_DEFINDCODETYPEID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true}]");
         setEventMetadata("ENTER",",oparms:[{av:'AV19XT_DefineCode',fld:'vXT_DEFINECODE',pic:''}]}");
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
         AV19XT_DefineCode = new SdtXT_DefineCode(context);
         AV5tOldXT_DefineCodeName = "";
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
         AV13Messages = new GXBaseCollection<SdtMessages_Message>( context, "Message", "GeneXus");
         AV12Message = new SdtMessages_Message(context);
         AV9Context = new GeneXus.Programs.wwpbaseobjects.SdtWWPContext(context);
         GXt_char1 = "";
         AV20Errormsg = "";
         AV31GXV7 = new GXBaseCollection<SdtMessages_Message>( context, "Message", "GeneXus");
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         pr_datastore1 = new DataStoreProvider(context, new GeneXus.Programs.xt_definecodeoperate__datastore1(),
            new Object[][] {
            }
         );
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.xt_definecodeoperate__default(),
            new Object[][] {
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private short AV21iType ;
      private short wcpOAV21iType ;
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
      private int edtavXt_definecode_xt_definecodeid_Visible ;
      private int edtavXt_definecode_xt_definecodeorder_Visible ;
      private int edtavXt_definecode_xt_typecode_Visible ;
      private int edtavXt_definecode_xt_tenantcode_Visible ;
      private int AV30GXV6 ;
      private int AV32GXV8 ;
      private int idxLst ;
      private long AV7XT_DefineCodeID ;
      private long AV11iXT_DefindcodeTypeID ;
      private long wcpOAV7XT_DefineCodeID ;
      private long wcpOAV11iXT_DefindcodeTypeID ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String sDynURL ;
      private String FormProcess ;
      private String bodyStyle ;
      private String GXKey ;
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
      private String TempTags ;
      private String edtavXt_definecode_xt_definecodename_Jsonclick ;
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
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
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
      private bool AV8CheckRequiredFieldsResult ;
      private bool AV22tCheckFlag ;
      private bool AV17tFlag ;
      private String AV5tOldXT_DefineCodeName ;
      private String AV20Errormsg ;
      private GXUserControl ucDvpanel_tableattributes ;
      private IGxDataStore dsDataStore1 ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private IDataStoreProvider pr_datastore1 ;
      private GXBaseCollection<SdtMessages_Message> AV13Messages ;
      private GXBaseCollection<SdtMessages_Message> AV31GXV7 ;
      private GXWebForm Form ;
      private SdtMessages_Message AV12Message ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPContext AV9Context ;
      private SdtXT_DefineCode AV19XT_DefineCode ;
   }

   public class xt_definecodeoperate__datastore1 : DataStoreHelperBase, IDataStoreHelper
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

 public class xt_definecodeoperate__default : DataStoreHelperBase, IDataStoreHelper
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
