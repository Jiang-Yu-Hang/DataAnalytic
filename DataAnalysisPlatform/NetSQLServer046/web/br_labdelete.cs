/*
               File: BR_LabDelete
        Description:
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/27/2020 12:6:48.63
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
   public class br_labdelete : GXDataArea, System.Web.SessionState.IRequiresSessionState
   {
      public br_labdelete( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public br_labdelete( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( long aP0_iBR_LabID )
      {
         this.AV17iBR_LabID = aP0_iBR_LabID;
         executePrivate();
      }

      void executePrivate( )
      {
         isStatic = false;
         webExecute();
      }

      protected override void createObjects( )
      {
         dynavVsource = new GXCombobox();
         dynavBr_lab_br_lab_resultqual = new GXCombobox();
         dynavBr_lab_br_lab_abnind = new GXCombobox();
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
            else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxCallCrl"+"_"+"vVSOURCE") == 0 )
            {
               AV18tCurrentCode = GetNextPar( );
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1;
                  return  ;
               }
               GXDLVvVSOURCE8R2( AV18tCurrentCode) ;
               return  ;
            }
            else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxCallCrl"+"_"+"BR_LAB_BR_LAB_RESULTQUAL") == 0 )
            {
               AV18tCurrentCode = GetNextPar( );
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1;
                  return  ;
               }
               GXDLVBR_LAB_BR_LAB_RESULTQUAL8R2( AV18tCurrentCode) ;
               return  ;
            }
            else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxCallCrl"+"_"+"BR_LAB_BR_LAB_ABNIND") == 0 )
            {
               AV18tCurrentCode = GetNextPar( );
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1;
                  return  ;
               }
               GXDLVBR_LAB_BR_LAB_ABNIND8R2( AV18tCurrentCode) ;
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
               AV17iBR_LabID = (long)(NumberUtil.Val( gxfirstwebparm, "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV17iBR_LabID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV17iBR_LabID), 18, 0)));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vIBR_LABID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV17iBR_LabID), "ZZZZZZZZZZZZZZZZZZ"), context));
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
         PA8R2( ) ;
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0));
         if ( ( gxajaxcallmode == 0 ) && ( GxWebError == 0 ) )
         {
            START8R2( ) ;
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
         context.AddJavascriptSource("gxcfg.js", "?20202271264872", false);
         if ( context.isSpaRequest( ) )
         {
            enableOutput();
         }
         context.AddJavascriptSource("calendar.js", "?"+context.GetBuildNumber( 127771), false);
         context.AddJavascriptSource("calendar-setup.js", "?"+context.GetBuildNumber( 127771), false);
         context.AddJavascriptSource("calendar-zh.js", "?"+context.GetBuildNumber( 127771), false);
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" autocomplete=\"off\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("br_labdelete.aspx") + "?" + UrlEncode("" +AV17iBR_LabID)+"\">") ;
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
         GxWebStd.gx_hidden_field( context, "gxhash_vVSOURCE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( AV11vSource, "")), context));
         GXKey = Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
         forbiddenHiddens = "hsh" + "BR_LabDelete";
         forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( AV10BR_Lab.gxTpr_Br_lab_testname, ""));
         forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( AV10BR_Lab.gxTpr_Br_lab_testengname, ""));
         forbiddenHiddens = forbiddenHiddens + context.localUtil.Format( (decimal)(AV10BR_Lab.gxTpr_Br_lab_age), "ZZZ");
         forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( AV10BR_Lab.gxTpr_Br_lab_diag, ""));
         forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( AV11vSource, ""));
         forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( AV10BR_Lab.gxTpr_Br_lab_resultqual, ""));
         forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( AV10BR_Lab.gxTpr_Br_lab_resultunit, ""));
         forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( AV10BR_Lab.gxTpr_Br_lab_abnind, ""));
         forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( AV10BR_Lab.gxTpr_Br_lab_normrangelow, ""));
         forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( AV10BR_Lab.gxTpr_Br_lab_testmethod, ""));
         forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( AV10BR_Lab.gxTpr_Br_lab_instrumentcode, ""));
         forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( AV10BR_Lab.gxTpr_Br_lab_instrumentname, ""));
         forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( AV10BR_Lab.gxTpr_Br_lab_resultnum, ""));
         GxWebStd.gx_hidden_field( context, "hsh", GetEncryptedHash( forbiddenHiddens, GXKey));
         GXUtil.WriteLog("br_labdelete:[SendSecurityCheck value for]"+"GXV1:"+StringUtil.RTrim( context.localUtil.Format( AV10BR_Lab.gxTpr_Br_lab_testname, "")));
         GXUtil.WriteLog("br_labdelete:[SendSecurityCheck value for]"+"GXV2:"+StringUtil.RTrim( context.localUtil.Format( AV10BR_Lab.gxTpr_Br_lab_testengname, "")));
         GXUtil.WriteLog("br_labdelete:[SendSecurityCheck value for]"+"GXV3:"+context.localUtil.Format( (decimal)(AV10BR_Lab.gxTpr_Br_lab_age), "ZZZ"));
         GXUtil.WriteLog("br_labdelete:[SendSecurityCheck value for]"+"GXV4:"+StringUtil.RTrim( context.localUtil.Format( AV10BR_Lab.gxTpr_Br_lab_diag, "")));
         GXUtil.WriteLog("br_labdelete:[SendSecurityCheck value for]"+"vSource:"+StringUtil.RTrim( context.localUtil.Format( AV11vSource, "")));
         GXUtil.WriteLog("br_labdelete:[SendSecurityCheck value for]"+"GXV5:"+StringUtil.RTrim( context.localUtil.Format( AV10BR_Lab.gxTpr_Br_lab_resultqual, "")));
         GXUtil.WriteLog("br_labdelete:[SendSecurityCheck value for]"+"GXV6:"+StringUtil.RTrim( context.localUtil.Format( AV10BR_Lab.gxTpr_Br_lab_resultunit, "")));
         GXUtil.WriteLog("br_labdelete:[SendSecurityCheck value for]"+"GXV7:"+StringUtil.RTrim( context.localUtil.Format( AV10BR_Lab.gxTpr_Br_lab_abnind, "")));
         GXUtil.WriteLog("br_labdelete:[SendSecurityCheck value for]"+"GXV8:"+StringUtil.RTrim( context.localUtil.Format( AV10BR_Lab.gxTpr_Br_lab_normrangelow, "")));
         GXUtil.WriteLog("br_labdelete:[SendSecurityCheck value for]"+"GXV9:"+StringUtil.RTrim( context.localUtil.Format( AV10BR_Lab.gxTpr_Br_lab_testmethod, "")));
         GXUtil.WriteLog("br_labdelete:[SendSecurityCheck value for]"+"GXV10:"+StringUtil.RTrim( context.localUtil.Format( AV10BR_Lab.gxTpr_Br_lab_instrumentcode, "")));
         GXUtil.WriteLog("br_labdelete:[SendSecurityCheck value for]"+"GXV11:"+StringUtil.RTrim( context.localUtil.Format( AV10BR_Lab.gxTpr_Br_lab_instrumentname, "")));
         GXUtil.WriteLog("br_labdelete:[SendSecurityCheck value for]"+"GXV12:"+StringUtil.RTrim( context.localUtil.Format( AV10BR_Lab.gxTpr_Br_lab_resultnum, "")));
      }

      protected void SendCloseFormHiddens( )
      {
         /* Send hidden variables. */
         /* Send saved values. */
         send_integrity_footer_hashes( ) ;
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "Br_lab", AV10BR_Lab);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("Br_lab", AV10BR_Lab);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vBR_LAB", AV10BR_Lab);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vBR_LAB", AV10BR_Lab);
         }
         GxWebStd.gx_hidden_field( context, "vIBR_LABID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV17iBR_LabID), 18, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "gxhash_vIBR_LABID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV17iBR_LabID), "ZZZZZZZZZZZZZZZZZZ"), context));
         GxWebStd.gx_hidden_field( context, "vTCURRENTCODE", AV18tCurrentCode);
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
            WE8R2( ) ;
            context.WriteHtmlText( "</div>") ;
         }
      }

      public override void DispatchEvents( )
      {
         EVT8R2( ) ;
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
         return formatLink("br_labdelete.aspx") + "?" + UrlEncode("" +AV17iBR_LabID) ;
      }

      public override String GetPgmname( )
      {
         return "BR_LabDelete" ;
      }

      public override String GetPgmdesc( )
      {
         return "" ;
      }

      protected void WB8R0( )
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
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtavBr_lab_br_lab_testname_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavBr_lab_br_lab_testname_Internalname, "项目名称", "col-sm-3 ReadonlyAttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtavBr_lab_br_lab_testname_Internalname, AV10BR_Lab.gxTpr_Br_lab_testname, StringUtil.RTrim( context.localUtil.Format( AV10BR_Lab.gxTpr_Br_lab_testname, "")), "", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavBr_lab_br_lab_testname_Jsonclick, 0, "ReadonlyAttribute", "", "", "", "", 1, edtavBr_lab_br_lab_testname_Enabled, 0, "text", "", 40, "chr", 1, "row", 40, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_BR_LabDelete.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtavBr_lab_br_lab_testengname_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavBr_lab_br_lab_testengname_Internalname, "项目英文名称", "col-sm-3 ReadonlyAttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtavBr_lab_br_lab_testengname_Internalname, AV10BR_Lab.gxTpr_Br_lab_testengname, StringUtil.RTrim( context.localUtil.Format( AV10BR_Lab.gxTpr_Br_lab_testengname, "")), "", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavBr_lab_br_lab_testengname_Jsonclick, 0, "ReadonlyAttribute", "", "", "", "", 1, edtavBr_lab_br_lab_testengname_Enabled, 0, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_BR_LabDelete.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtavBr_lab_br_lab_age_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavBr_lab_br_lab_age_Internalname, "年龄", "col-sm-3 ReadonlyAttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtavBr_lab_br_lab_age_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV10BR_Lab.gxTpr_Br_lab_age), 3, 0, ".", "")), ((edtavBr_lab_br_lab_age_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(AV10BR_Lab.gxTpr_Br_lab_age), "ZZZ")) : context.localUtil.Format( (decimal)(AV10BR_Lab.gxTpr_Br_lab_age), "ZZZ")), "", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavBr_lab_br_lab_age_Jsonclick, 0, "ReadonlyAttribute", "", "", "", "", 1, edtavBr_lab_br_lab_age_Enabled, 0, "number", "1", 3, "chr", 1, "row", 3, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_BR_LabDelete.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtavBr_lab_br_lab_diag_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavBr_lab_br_lab_diag_Internalname, "临床诊断", "col-sm-3 ReadonlyAttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtavBr_lab_br_lab_diag_Internalname, AV10BR_Lab.gxTpr_Br_lab_diag, StringUtil.RTrim( context.localUtil.Format( AV10BR_Lab.gxTpr_Br_lab_diag, "")), "", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavBr_lab_br_lab_diag_Jsonclick, 0, "ReadonlyAttribute", "", "", "", "", 1, edtavBr_lab_br_lab_diag_Enabled, 0, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_BR_LabDelete.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divTablesplittedvsource_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-3 MergeLabelCell", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblockvsource_Internalname, "标本种类", "", "", lblTextblockvsource_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_BR_LabDelete.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-9", "left", "top", "", "", "div");
            wb_table1_46_8R2( true) ;
         }
         else
         {
            wb_table1_46_8R2( false) ;
         }
         return  ;
      }

      protected void wb_table1_46_8R2e( bool wbgen )
      {
         if ( wbgen )
         {
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtavVspecimendate_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavVspecimendate_Internalname, "采样时间", "col-sm-3 ReadonlyAttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 57,'',false,'',0)\"";
            context.WriteHtmlText( "<div id=\""+edtavVspecimendate_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtavVspecimendate_Internalname, context.localUtil.TToC( AV13vSpecimenDate, 10, 8, 0, 0, "/", ":", " "), context.localUtil.Format( AV13vSpecimenDate, "9999/99/99 99:99:99"), TempTags+" onchange=\""+"gx.date.valid_date(this, 10,'YMD',8,24,'chs',false,0);"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,57);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavVspecimendate_Jsonclick, 0, "ReadonlyAttribute", "", "", "", "", 1, edtavVspecimendate_Enabled, 0, "text", "", 19, "chr", 1, "row", 19, 0, 0, 0, 1, -1, 0, true, "DM_DataTime", "right", false, "HLP_BR_LabDelete.htm");
            GxWebStd.gx_bitmap( context, edtavVspecimendate_Internalname+"_dp_trigger", context.GetImagePath( "61b9b5d3-dff6-4d59-9b00-da61bc2cbe93", "", context.GetTheme( )), "", "", "", "", ((1==0)||(edtavVspecimendate_Enabled==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;", "", "", "", "", "", "", "", "", 1, false, false, "", "HLP_BR_LabDelete.htm");
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
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtavVreceivingtime_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavVreceivingtime_Internalname, "接收时间", "col-sm-3 ReadonlyAttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 62,'',false,'',0)\"";
            context.WriteHtmlText( "<div id=\""+edtavVreceivingtime_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtavVreceivingtime_Internalname, context.localUtil.TToC( AV14vReceivingTime, 10, 8, 0, 0, "/", ":", " "), context.localUtil.Format( AV14vReceivingTime, "9999/99/99 99:99:99"), TempTags+" onchange=\""+"gx.date.valid_date(this, 10,'YMD',8,24,'chs',false,0);"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,62);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavVreceivingtime_Jsonclick, 0, "ReadonlyAttribute", "", "", "", "", 1, edtavVreceivingtime_Enabled, 0, "text", "", 19, "chr", 1, "row", 19, 0, 0, 0, 1, -1, 0, true, "DM_DataTime", "right", false, "HLP_BR_LabDelete.htm");
            GxWebStd.gx_bitmap( context, edtavVreceivingtime_Internalname+"_dp_trigger", context.GetImagePath( "61b9b5d3-dff6-4d59-9b00-da61bc2cbe93", "", context.GetTheme( )), "", "", "", "", ((1==0)||(edtavVreceivingtime_Enabled==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;", "", "", "", "", "", "", "", "", 1, false, false, "", "HLP_BR_LabDelete.htm");
            context.WriteHtmlTextNl( "</div>") ;
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtavVreporttime_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavVreporttime_Internalname, "报告时间", "col-sm-3 ReadonlyAttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 66,'',false,'',0)\"";
            context.WriteHtmlText( "<div id=\""+edtavVreporttime_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtavVreporttime_Internalname, context.localUtil.TToC( AV15vReportTime, 10, 8, 0, 0, "/", ":", " "), context.localUtil.Format( AV15vReportTime, "9999/99/99 99:99:99"), TempTags+" onchange=\""+"gx.date.valid_date(this, 10,'YMD',8,24,'chs',false,0);"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,66);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavVreporttime_Jsonclick, 0, "ReadonlyAttribute", "", "", "", "", 1, edtavVreporttime_Enabled, 0, "text", "", 19, "chr", 1, "row", 19, 0, 0, 0, 1, -1, 0, true, "DM_DataTime", "right", false, "HLP_BR_LabDelete.htm");
            GxWebStd.gx_bitmap( context, edtavVreporttime_Internalname+"_dp_trigger", context.GetImagePath( "61b9b5d3-dff6-4d59-9b00-da61bc2cbe93", "", context.GetTheme( )), "", "", "", "", ((1==0)||(edtavVreporttime_Enabled==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;", "", "", "", "", "", "", "", "", 1, false, false, "", "HLP_BR_LabDelete.htm");
            context.WriteHtmlTextNl( "</div>") ;
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-md-6 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+dynavBr_lab_br_lab_resultqual_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, dynavBr_lab_br_lab_resultqual_Internalname, "定性结果", "col-sm-3 ReadonlyAttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, dynavBr_lab_br_lab_resultqual, dynavBr_lab_br_lab_resultqual_Internalname, StringUtil.RTrim( AV10BR_Lab.gxTpr_Br_lab_resultqual), 1, dynavBr_lab_br_lab_resultqual_Jsonclick, 0, "'"+""+"'"+",false,"+"'"+""+"'", "svchar", "", 1, dynavBr_lab_br_lab_resultqual.Enabled, 0, 0, 0, "em", 0, "", "", "ReadonlyAttribute", "", "", "", "", true, "HLP_BR_LabDelete.htm");
            dynavBr_lab_br_lab_resultqual.CurrentValue = StringUtil.RTrim( AV10BR_Lab.gxTpr_Br_lab_resultqual);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynavBr_lab_br_lab_resultqual_Internalname, "Values", (String)(dynavBr_lab_br_lab_resultqual.ToJavascriptSource()), true);
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtavBr_lab_br_lab_resultunit_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavBr_lab_br_lab_resultunit_Internalname, "结果单位", "col-sm-3 ReadonlyAttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtavBr_lab_br_lab_resultunit_Internalname, AV10BR_Lab.gxTpr_Br_lab_resultunit, StringUtil.RTrim( context.localUtil.Format( AV10BR_Lab.gxTpr_Br_lab_resultunit, "")), "", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavBr_lab_br_lab_resultunit_Jsonclick, 0, "ReadonlyAttribute", "", "", "", "", 1, edtavBr_lab_br_lab_resultunit_Enabled, 0, "text", "", 40, "chr", 1, "row", 40, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_BR_LabDelete.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+dynavBr_lab_br_lab_abnind_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, dynavBr_lab_br_lab_abnind_Internalname, "结果提示", "col-sm-3 ReadonlyAttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, dynavBr_lab_br_lab_abnind, dynavBr_lab_br_lab_abnind_Internalname, StringUtil.RTrim( AV10BR_Lab.gxTpr_Br_lab_abnind), 1, dynavBr_lab_br_lab_abnind_Jsonclick, 0, "'"+""+"'"+",false,"+"'"+""+"'", "svchar", "", 1, dynavBr_lab_br_lab_abnind.Enabled, 0, 0, 0, "em", 0, "", "", "ReadonlyAttribute", "", "", "", "", true, "HLP_BR_LabDelete.htm");
            dynavBr_lab_br_lab_abnind.CurrentValue = StringUtil.RTrim( AV10BR_Lab.gxTpr_Br_lab_abnind);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynavBr_lab_br_lab_abnind_Internalname, "Values", (String)(dynavBr_lab_br_lab_abnind.ToJavascriptSource()), true);
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtavBr_lab_br_lab_normrangelow_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavBr_lab_br_lab_normrangelow_Internalname, "参考值范围", "col-sm-3 ReadonlyAttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtavBr_lab_br_lab_normrangelow_Internalname, AV10BR_Lab.gxTpr_Br_lab_normrangelow, StringUtil.RTrim( context.localUtil.Format( AV10BR_Lab.gxTpr_Br_lab_normrangelow, "")), "", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavBr_lab_br_lab_normrangelow_Jsonclick, 0, "ReadonlyAttribute", "", "", "", "", 1, edtavBr_lab_br_lab_normrangelow_Enabled, 0, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_BR_LabDelete.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtavBr_lab_br_lab_testmethod_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavBr_lab_br_lab_testmethod_Internalname, "检测方法", "col-sm-3 ReadonlyAttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtavBr_lab_br_lab_testmethod_Internalname, AV10BR_Lab.gxTpr_Br_lab_testmethod, StringUtil.RTrim( context.localUtil.Format( AV10BR_Lab.gxTpr_Br_lab_testmethod, "")), "", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavBr_lab_br_lab_testmethod_Jsonclick, 0, "ReadonlyAttribute", "", "", "", "", 1, edtavBr_lab_br_lab_testmethod_Enabled, 0, "text", "", 40, "chr", 1, "row", 40, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_BR_LabDelete.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtavBr_lab_br_lab_instrumentcode_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavBr_lab_br_lab_instrumentcode_Internalname, "设备编码", "col-sm-3 ReadonlyAttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtavBr_lab_br_lab_instrumentcode_Internalname, AV10BR_Lab.gxTpr_Br_lab_instrumentcode, StringUtil.RTrim( context.localUtil.Format( AV10BR_Lab.gxTpr_Br_lab_instrumentcode, "")), "", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavBr_lab_br_lab_instrumentcode_Jsonclick, 0, "ReadonlyAttribute", "", "", "", "", 1, edtavBr_lab_br_lab_instrumentcode_Enabled, 0, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_BR_LabDelete.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-md-6 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtavBr_lab_br_lab_instrumentname_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavBr_lab_br_lab_instrumentname_Internalname, "设备名称", "col-sm-3 ReadonlyAttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Multiple line edit */
            ClassString = "ReadonlyAttribute";
            StyleString = "";
            ClassString = "ReadonlyAttribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavBr_lab_br_lab_instrumentname_Internalname, AV10BR_Lab.gxTpr_Br_lab_instrumentname, "", "", 0, 1, edtavBr_lab_br_lab_instrumentname_Enabled, 0, 80, "chr", 3, "row", StyleString, ClassString, "", "", "200", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_LabDelete.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-md-6 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtavBr_lab_br_lab_resultnum_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavBr_lab_br_lab_resultnum_Internalname, "定量结果", "col-sm-3 ReadonlyAttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Multiple line edit */
            ClassString = "ReadonlyAttribute";
            StyleString = "";
            ClassString = "ReadonlyAttribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavBr_lab_br_lab_resultnum_Internalname, AV10BR_Lab.gxTpr_Br_lab_resultnum, "", "", 0, 1, edtavBr_lab_br_lab_resultnum_Enabled, 0, 80, "chr", 7, "row", StyleString, ClassString, "", "", "500", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_LabDelete.htm");
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
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 108,'',false,'',0)\"";
            ClassString = "ButtonMaterial";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtnenter_Internalname, "", "确认", bttBtnenter_Jsonclick, 5, "确认", "", StyleString, ClassString, 1, 1, "standard", "'"+""+"'"+",false,"+"'"+"EENTER."+"'", TempTags, "", context.GetButtonType( ), "HLP_BR_LabDelete.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 110,'',false,'',0)\"";
            ClassString = "ButtonMaterialDefault";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtncancel_Internalname, "", "取消", bttBtncancel_Jsonclick, 1, "取消", "", StyleString, ClassString, 1, 1, "standard", "'"+""+"'"+",false,"+"'"+"ECANCEL."+"'", TempTags, "", context.GetButtonType( ), "HLP_BR_LabDelete.htm");
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
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 114,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavBr_lab_br_encounterid_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV10BR_Lab.gxTpr_Br_encounterid), 18, 0, ".", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(AV10BR_Lab.gxTpr_Br_encounterid), "ZZZZZZZZZZZZZZZZZZ")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,114);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavBr_lab_br_encounterid_Jsonclick, 0, "Attribute", "", "", "", "", edtavBr_lab_br_encounterid_Visible, 1, 0, "number", "1", 18, "chr", 1, "row", 18, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_BR_LabDelete.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 115,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavBr_lab_br_information_patientno_Internalname, AV10BR_Lab.gxTpr_Br_information_patientno, StringUtil.RTrim( context.localUtil.Format( AV10BR_Lab.gxTpr_Br_information_patientno, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,115);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavBr_lab_br_information_patientno_Jsonclick, 0, "Attribute", "", "", "", "", edtavBr_lab_br_information_patientno_Visible, 1, 0, "text", "", 80, "chr", 1, "row", 2000, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_BR_LabDelete.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 116,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavBr_lab_br_labid_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV10BR_Lab.gxTpr_Br_labid), 18, 0, ".", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(AV10BR_Lab.gxTpr_Br_labid), "ZZZZZZZZZZZZZZZZZZ")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,116);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavBr_lab_br_labid_Jsonclick, 0, "Attribute", "", "", "", "", edtavBr_lab_br_labid_Visible, 1, 0, "number", "1", 18, "chr", 1, "row", 18, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_BR_LabDelete.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 117,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavBr_lab_br_lab_sampleid_Internalname, AV10BR_Lab.gxTpr_Br_lab_sampleid, StringUtil.RTrim( context.localUtil.Format( AV10BR_Lab.gxTpr_Br_lab_sampleid, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,117);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavBr_lab_br_lab_sampleid_Jsonclick, 0, "Attribute", "", "", "", "", edtavBr_lab_br_lab_sampleid_Visible, 1, 0, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_BR_LabDelete.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 118,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavBr_lab_br_lab_testid_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV10BR_Lab.gxTpr_Br_lab_testid), 10, 0, ".", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(AV10BR_Lab.gxTpr_Br_lab_testid), "ZZZZZZZZZZ")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,118);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavBr_lab_br_lab_testid_Jsonclick, 0, "Attribute", "", "", "", "", edtavBr_lab_br_lab_testid_Visible, 1, 0, "number", "1", 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_BR_LabDelete.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 119,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavBr_lab_br_lab_normrangehigh_Internalname, AV10BR_Lab.gxTpr_Br_lab_normrangehigh, StringUtil.RTrim( context.localUtil.Format( AV10BR_Lab.gxTpr_Br_lab_normrangehigh, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,119);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavBr_lab_br_lab_normrangehigh_Jsonclick, 0, "Attribute", "", "", "", "", edtavBr_lab_br_lab_normrangehigh_Visible, 1, 0, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_BR_LabDelete.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
         }
         wbLoad = true;
      }

      protected void START8R2( )
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
         STRUP8R0( ) ;
      }

      protected void WS8R2( )
      {
         START8R2( ) ;
         EVT8R2( ) ;
      }

      protected void EVT8R2( )
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
                              E118R2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "REFRESH") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              /* Execute user event: Refresh */
                              E128R2 ();
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
                                    E138R2 ();
                                 }
                                 dynload_actions( ) ;
                              }
                           }
                           else if ( StringUtil.StrCmp(sEvt, "LOAD") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              /* Execute user event: Load */
                              E148R2 ();
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

      protected void WE8R2( )
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

      protected void PA8R2( )
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
               GX_FocusControl = edtavBr_lab_br_lab_testname_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
            nDonePA = 1;
         }
      }

      protected void dynload_actions( )
      {
         /* End function dynload_actions */
      }

      protected void GXDLVvVSOURCE8R2( String AV18tCurrentCode )
      {
         if ( ! context.isAjaxRequest( ) )
         {
            context.GX_webresponse.AppendHeader("Cache-Control", "no-store");
         }
         context.GX_webresponse.AddString("[[");
         GXDLVvVSOURCE_data8R2( AV18tCurrentCode) ;
         gxdynajaxindex = 1;
         while ( gxdynajaxindex <= gxdynajaxctrlcodr.Count )
         {
            context.GX_webresponse.AddString(gxwrpcisep+"{\"c\":\""+GXUtil.EncodeJSConstant( ((String)gxdynajaxctrlcodr.Item(gxdynajaxindex)))+"\",\"d\":\""+GXUtil.EncodeJSConstant( ((String)gxdynajaxctrldescr.Item(gxdynajaxindex)))+"\"}");
            gxdynajaxindex = (int)(gxdynajaxindex+1);
            gxwrpcisep = ",";
         }
         context.GX_webresponse.AddString("]");
         if ( gxdynajaxctrlcodr.Count == 0 )
         {
            context.GX_webresponse.AddString(",101");
         }
         context.GX_webresponse.AddString("]");
      }

      protected void GXVvVSOURCE_html8R2( String AV18tCurrentCode )
      {
         String gxdynajaxvalue ;
         GXDLVvVSOURCE_data8R2( AV18tCurrentCode) ;
         gxdynajaxindex = 1;
         if ( ! ( gxdyncontrolsrefreshing && context.isAjaxRequest( ) ) )
         {
            dynavVsource.removeAllItems();
         }
         while ( gxdynajaxindex <= gxdynajaxctrlcodr.Count )
         {
            gxdynajaxvalue = ((String)gxdynajaxctrlcodr.Item(gxdynajaxindex));
            dynavVsource.addItem(gxdynajaxvalue, ((String)gxdynajaxctrldescr.Item(gxdynajaxindex)), 0);
            gxdynajaxindex = (int)(gxdynajaxindex+1);
         }
      }

      protected void GXDLVvVSOURCE_data8R2( String AV18tCurrentCode )
      {
         gxdynajaxctrlcodr.Clear();
         gxdynajaxctrldescr.Clear();
         gxdynajaxctrlcodr.Add("");
         gxdynajaxctrldescr.Add("(请选择)");
         /* Using cursor H008R2 */
         pr_default.execute(0, new Object[] {AV18tCurrentCode});
         while ( (pr_default.getStatus(0) != 101) )
         {
            gxdynajaxctrlcodr.Add(H008R2_A168XT_DefineCodeName[0]);
            gxdynajaxctrldescr.Add(H008R2_A168XT_DefineCodeName[0]);
            pr_default.readNext(0);
         }
         pr_default.close(0);
      }

      protected void GXDLVBR_LAB_BR_LAB_RESULTQUAL8R2( String AV18tCurrentCode )
      {
         if ( ! context.isAjaxRequest( ) )
         {
            context.GX_webresponse.AppendHeader("Cache-Control", "no-store");
         }
         context.GX_webresponse.AddString("[[");
         GXDLVBR_LAB_BR_LAB_RESULTQUAL_data8R2( AV18tCurrentCode) ;
         gxdynajaxindex = 1;
         while ( gxdynajaxindex <= gxdynajaxctrlcodr.Count )
         {
            context.GX_webresponse.AddString(gxwrpcisep+"{\"c\":\""+GXUtil.EncodeJSConstant( ((String)gxdynajaxctrlcodr.Item(gxdynajaxindex)))+"\",\"d\":\""+GXUtil.EncodeJSConstant( ((String)gxdynajaxctrldescr.Item(gxdynajaxindex)))+"\"}");
            gxdynajaxindex = (int)(gxdynajaxindex+1);
            gxwrpcisep = ",";
         }
         context.GX_webresponse.AddString("]");
         if ( gxdynajaxctrlcodr.Count == 0 )
         {
            context.GX_webresponse.AddString(",101");
         }
         context.GX_webresponse.AddString("]");
      }

      protected void GXVBR_LAB_BR_LAB_RESULTQUAL_html8R2( String AV18tCurrentCode )
      {
         String gxdynajaxvalue ;
         GXDLVBR_LAB_BR_LAB_RESULTQUAL_data8R2( AV18tCurrentCode) ;
         gxdynajaxindex = 1;
         if ( ! ( gxdyncontrolsrefreshing && context.isAjaxRequest( ) ) )
         {
            dynavBr_lab_br_lab_resultqual.removeAllItems();
         }
         while ( gxdynajaxindex <= gxdynajaxctrlcodr.Count )
         {
            gxdynajaxvalue = ((String)gxdynajaxctrlcodr.Item(gxdynajaxindex));
            dynavBr_lab_br_lab_resultqual.addItem(gxdynajaxvalue, ((String)gxdynajaxctrldescr.Item(gxdynajaxindex)), 0);
            gxdynajaxindex = (int)(gxdynajaxindex+1);
         }
      }

      protected void GXDLVBR_LAB_BR_LAB_RESULTQUAL_data8R2( String AV18tCurrentCode )
      {
         gxdynajaxctrlcodr.Clear();
         gxdynajaxctrldescr.Clear();
         gxdynajaxctrlcodr.Add("");
         gxdynajaxctrldescr.Add("(请选择)");
         /* Using cursor H008R3 */
         pr_default.execute(1, new Object[] {AV18tCurrentCode});
         while ( (pr_default.getStatus(1) != 101) )
         {
            gxdynajaxctrlcodr.Add(H008R3_A168XT_DefineCodeName[0]);
            gxdynajaxctrldescr.Add(H008R3_A168XT_DefineCodeName[0]);
            pr_default.readNext(1);
         }
         pr_default.close(1);
      }

      protected void GXDLVBR_LAB_BR_LAB_ABNIND8R2( String AV18tCurrentCode )
      {
         if ( ! context.isAjaxRequest( ) )
         {
            context.GX_webresponse.AppendHeader("Cache-Control", "no-store");
         }
         context.GX_webresponse.AddString("[[");
         GXDLVBR_LAB_BR_LAB_ABNIND_data8R2( AV18tCurrentCode) ;
         gxdynajaxindex = 1;
         while ( gxdynajaxindex <= gxdynajaxctrlcodr.Count )
         {
            context.GX_webresponse.AddString(gxwrpcisep+"{\"c\":\""+GXUtil.EncodeJSConstant( ((String)gxdynajaxctrlcodr.Item(gxdynajaxindex)))+"\",\"d\":\""+GXUtil.EncodeJSConstant( ((String)gxdynajaxctrldescr.Item(gxdynajaxindex)))+"\"}");
            gxdynajaxindex = (int)(gxdynajaxindex+1);
            gxwrpcisep = ",";
         }
         context.GX_webresponse.AddString("]");
         if ( gxdynajaxctrlcodr.Count == 0 )
         {
            context.GX_webresponse.AddString(",101");
         }
         context.GX_webresponse.AddString("]");
      }

      protected void GXVBR_LAB_BR_LAB_ABNIND_html8R2( String AV18tCurrentCode )
      {
         String gxdynajaxvalue ;
         GXDLVBR_LAB_BR_LAB_ABNIND_data8R2( AV18tCurrentCode) ;
         gxdynajaxindex = 1;
         if ( ! ( gxdyncontrolsrefreshing && context.isAjaxRequest( ) ) )
         {
            dynavBr_lab_br_lab_abnind.removeAllItems();
         }
         while ( gxdynajaxindex <= gxdynajaxctrlcodr.Count )
         {
            gxdynajaxvalue = ((String)gxdynajaxctrlcodr.Item(gxdynajaxindex));
            dynavBr_lab_br_lab_abnind.addItem(gxdynajaxvalue, ((String)gxdynajaxctrldescr.Item(gxdynajaxindex)), 0);
            gxdynajaxindex = (int)(gxdynajaxindex+1);
         }
      }

      protected void GXDLVBR_LAB_BR_LAB_ABNIND_data8R2( String AV18tCurrentCode )
      {
         gxdynajaxctrlcodr.Clear();
         gxdynajaxctrldescr.Clear();
         gxdynajaxctrlcodr.Add("");
         gxdynajaxctrldescr.Add("(请选择)");
         /* Using cursor H008R4 */
         pr_default.execute(2, new Object[] {AV18tCurrentCode});
         while ( (pr_default.getStatus(2) != 101) )
         {
            gxdynajaxctrlcodr.Add(H008R4_A168XT_DefineCodeName[0]);
            gxdynajaxctrldescr.Add(H008R4_A168XT_DefineCodeName[0]);
            pr_default.readNext(2);
         }
         pr_default.close(2);
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
         if ( dynavVsource.ItemCount > 0 )
         {
            AV11vSource = dynavVsource.getValidValue(AV11vSource);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11vSource", AV11vSource);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vVSOURCE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( AV11vSource, "")), context));
         }
         if ( context.isAjaxRequest( ) )
         {
            dynavVsource.CurrentValue = StringUtil.RTrim( AV11vSource);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynavVsource_Internalname, "Values", dynavVsource.ToJavascriptSource(), true);
         }
         if ( dynavBr_lab_br_lab_resultqual.ItemCount > 0 )
         {
            AV10BR_Lab.gxTpr_Br_lab_resultqual = dynavBr_lab_br_lab_resultqual.getValidValue(AV10BR_Lab.gxTpr_Br_lab_resultqual);
         }
         if ( context.isAjaxRequest( ) )
         {
            dynavBr_lab_br_lab_resultqual.CurrentValue = StringUtil.RTrim( AV10BR_Lab.gxTpr_Br_lab_resultqual);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynavBr_lab_br_lab_resultqual_Internalname, "Values", dynavBr_lab_br_lab_resultqual.ToJavascriptSource(), true);
         }
         if ( dynavBr_lab_br_lab_abnind.ItemCount > 0 )
         {
            AV10BR_Lab.gxTpr_Br_lab_abnind = dynavBr_lab_br_lab_abnind.getValidValue(AV10BR_Lab.gxTpr_Br_lab_abnind);
         }
         if ( context.isAjaxRequest( ) )
         {
            dynavBr_lab_br_lab_abnind.CurrentValue = StringUtil.RTrim( AV10BR_Lab.gxTpr_Br_lab_abnind);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynavBr_lab_br_lab_abnind_Internalname, "Values", dynavBr_lab_br_lab_abnind.ToJavascriptSource(), true);
         }
      }

      public void Refresh( )
      {
         send_integrity_hashes( ) ;
         RF8R2( ) ;
         if ( isFullAjaxMode( ) )
         {
            send_integrity_footer_hashes( ) ;
         }
      }

      protected void initialize_formulas( )
      {
         /* GeneXus formulas. */
         context.Gx_err = 0;
         edtavBr_lab_br_lab_testname_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavBr_lab_br_lab_testname_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavBr_lab_br_lab_testname_Enabled), 5, 0)), true);
         edtavBr_lab_br_lab_testengname_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavBr_lab_br_lab_testengname_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavBr_lab_br_lab_testengname_Enabled), 5, 0)), true);
         edtavBr_lab_br_lab_age_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavBr_lab_br_lab_age_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavBr_lab_br_lab_age_Enabled), 5, 0)), true);
         edtavBr_lab_br_lab_diag_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavBr_lab_br_lab_diag_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavBr_lab_br_lab_diag_Enabled), 5, 0)), true);
         dynavVsource.Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynavVsource_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(dynavVsource.Enabled), 5, 0)), true);
         edtavVothersource_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavVothersource_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavVothersource_Enabled), 5, 0)), true);
         edtavVspecimendate_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavVspecimendate_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavVspecimendate_Enabled), 5, 0)), true);
         edtavVreceivingtime_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavVreceivingtime_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavVreceivingtime_Enabled), 5, 0)), true);
         edtavVreporttime_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavVreporttime_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavVreporttime_Enabled), 5, 0)), true);
         dynavBr_lab_br_lab_resultqual.Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynavBr_lab_br_lab_resultqual_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(dynavBr_lab_br_lab_resultqual.Enabled), 5, 0)), true);
         edtavBr_lab_br_lab_resultunit_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavBr_lab_br_lab_resultunit_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavBr_lab_br_lab_resultunit_Enabled), 5, 0)), true);
         dynavBr_lab_br_lab_abnind.Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynavBr_lab_br_lab_abnind_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(dynavBr_lab_br_lab_abnind.Enabled), 5, 0)), true);
         edtavBr_lab_br_lab_normrangelow_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavBr_lab_br_lab_normrangelow_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavBr_lab_br_lab_normrangelow_Enabled), 5, 0)), true);
         edtavBr_lab_br_lab_testmethod_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavBr_lab_br_lab_testmethod_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavBr_lab_br_lab_testmethod_Enabled), 5, 0)), true);
         edtavBr_lab_br_lab_instrumentcode_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavBr_lab_br_lab_instrumentcode_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavBr_lab_br_lab_instrumentcode_Enabled), 5, 0)), true);
         edtavBr_lab_br_lab_instrumentname_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavBr_lab_br_lab_instrumentname_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavBr_lab_br_lab_instrumentname_Enabled), 5, 0)), true);
         edtavBr_lab_br_lab_resultnum_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavBr_lab_br_lab_resultnum_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavBr_lab_br_lab_resultnum_Enabled), 5, 0)), true);
      }

      protected void RF8R2( )
      {
         initialize_formulas( ) ;
         clear_multi_value_controls( ) ;
         /* Execute user event: Refresh */
         E128R2 ();
         gxdyncontrolsrefreshing = true;
         fix_multi_value_controls( ) ;
         gxdyncontrolsrefreshing = false;
         if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
         {
            /* Execute user event: Load */
            E148R2 ();
            WB8R0( ) ;
         }
      }

      protected void send_integrity_lvl_hashes8R2( )
      {
         GxWebStd.gx_hidden_field( context, "vIBR_LABID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV17iBR_LabID), 18, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "gxhash_vIBR_LABID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV17iBR_LabID), "ZZZZZZZZZZZZZZZZZZ"), context));
         GxWebStd.gx_hidden_field( context, "gxhash_vVSOURCE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( AV11vSource, "")), context));
      }

      protected void STRUP8R0( )
      {
         /* Before Start, stand alone formulas. */
         context.Gx_err = 0;
         edtavBr_lab_br_lab_testname_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavBr_lab_br_lab_testname_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavBr_lab_br_lab_testname_Enabled), 5, 0)), true);
         edtavBr_lab_br_lab_testengname_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavBr_lab_br_lab_testengname_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavBr_lab_br_lab_testengname_Enabled), 5, 0)), true);
         edtavBr_lab_br_lab_age_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavBr_lab_br_lab_age_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavBr_lab_br_lab_age_Enabled), 5, 0)), true);
         edtavBr_lab_br_lab_diag_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavBr_lab_br_lab_diag_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavBr_lab_br_lab_diag_Enabled), 5, 0)), true);
         dynavVsource.Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynavVsource_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(dynavVsource.Enabled), 5, 0)), true);
         edtavVothersource_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavVothersource_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavVothersource_Enabled), 5, 0)), true);
         edtavVspecimendate_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavVspecimendate_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavVspecimendate_Enabled), 5, 0)), true);
         edtavVreceivingtime_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavVreceivingtime_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavVreceivingtime_Enabled), 5, 0)), true);
         edtavVreporttime_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavVreporttime_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavVreporttime_Enabled), 5, 0)), true);
         dynavBr_lab_br_lab_resultqual.Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynavBr_lab_br_lab_resultqual_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(dynavBr_lab_br_lab_resultqual.Enabled), 5, 0)), true);
         edtavBr_lab_br_lab_resultunit_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavBr_lab_br_lab_resultunit_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavBr_lab_br_lab_resultunit_Enabled), 5, 0)), true);
         dynavBr_lab_br_lab_abnind.Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynavBr_lab_br_lab_abnind_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(dynavBr_lab_br_lab_abnind.Enabled), 5, 0)), true);
         edtavBr_lab_br_lab_normrangelow_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavBr_lab_br_lab_normrangelow_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavBr_lab_br_lab_normrangelow_Enabled), 5, 0)), true);
         edtavBr_lab_br_lab_testmethod_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavBr_lab_br_lab_testmethod_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavBr_lab_br_lab_testmethod_Enabled), 5, 0)), true);
         edtavBr_lab_br_lab_instrumentcode_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavBr_lab_br_lab_instrumentcode_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavBr_lab_br_lab_instrumentcode_Enabled), 5, 0)), true);
         edtavBr_lab_br_lab_instrumentname_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavBr_lab_br_lab_instrumentname_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavBr_lab_br_lab_instrumentname_Enabled), 5, 0)), true);
         edtavBr_lab_br_lab_resultnum_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavBr_lab_br_lab_resultnum_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavBr_lab_br_lab_resultnum_Enabled), 5, 0)), true);
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0;
         /* Execute user event: Start */
         E118R2 ();
         context.wbGlbDoneStart = 1;
         /* After Start, stand alone formulas. */
         GXVvVSOURCE_html8R2( AV18tCurrentCode) ;
         GXVBR_LAB_BR_LAB_RESULTQUAL_html8R2( AV18tCurrentCode) ;
         GXVBR_LAB_BR_LAB_ABNIND_html8R2( AV18tCurrentCode) ;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read saved SDTs. */
            ajax_req_read_hidden_sdt(cgiGet( "Br_lab"), AV10BR_Lab);
            /* Read variables values. */
            AV10BR_Lab.gxTpr_Br_lab_testname = cgiGet( edtavBr_lab_br_lab_testname_Internalname);
            AV10BR_Lab.gxTpr_Br_lab_testengname = cgiGet( edtavBr_lab_br_lab_testengname_Internalname);
            if ( ( ( context.localUtil.CToN( cgiGet( edtavBr_lab_br_lab_age_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavBr_lab_br_lab_age_Internalname), ".", ",") > Convert.ToDecimal( 999 )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "BR_LAB_BR_LAB_AGE");
               GX_FocusControl = edtavBr_lab_br_lab_age_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV10BR_Lab.gxTpr_Br_lab_age = 0;
            }
            else
            {
               AV10BR_Lab.gxTpr_Br_lab_age = (short)(context.localUtil.CToN( cgiGet( edtavBr_lab_br_lab_age_Internalname), ".", ","));
            }
            AV10BR_Lab.gxTpr_Br_lab_diag = cgiGet( edtavBr_lab_br_lab_diag_Internalname);
            dynavVsource.CurrentValue = cgiGet( dynavVsource_Internalname);
            AV11vSource = cgiGet( dynavVsource_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11vSource", AV11vSource);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vVSOURCE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( AV11vSource, "")), context));
            AV12vOtherSource = cgiGet( edtavVothersource_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12vOtherSource", AV12vOtherSource);
            if ( context.localUtil.VCDateTime( cgiGet( edtavVspecimendate_Internalname), 0, 0) == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_baddatetime", new   object[]  {"v Specimen Date"}), 1, "vVSPECIMENDATE");
               GX_FocusControl = edtavVspecimendate_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV13vSpecimenDate = (DateTime)(DateTime.MinValue);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13vSpecimenDate", context.localUtil.TToC( AV13vSpecimenDate, 10, 8, 0, 0, "/", ":", " "));
            }
            else
            {
               AV13vSpecimenDate = context.localUtil.CToT( cgiGet( edtavVspecimendate_Internalname));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13vSpecimenDate", context.localUtil.TToC( AV13vSpecimenDate, 10, 8, 0, 0, "/", ":", " "));
            }
            if ( context.localUtil.VCDateTime( cgiGet( edtavVreceivingtime_Internalname), 0, 0) == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_baddatetime", new   object[]  {"v Receiving Time"}), 1, "vVRECEIVINGTIME");
               GX_FocusControl = edtavVreceivingtime_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV14vReceivingTime = (DateTime)(DateTime.MinValue);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14vReceivingTime", context.localUtil.TToC( AV14vReceivingTime, 10, 8, 0, 0, "/", ":", " "));
            }
            else
            {
               AV14vReceivingTime = context.localUtil.CToT( cgiGet( edtavVreceivingtime_Internalname));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14vReceivingTime", context.localUtil.TToC( AV14vReceivingTime, 10, 8, 0, 0, "/", ":", " "));
            }
            if ( context.localUtil.VCDateTime( cgiGet( edtavVreporttime_Internalname), 0, 0) == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_baddatetime", new   object[]  {"v Report Time"}), 1, "vVREPORTTIME");
               GX_FocusControl = edtavVreporttime_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV15vReportTime = (DateTime)(DateTime.MinValue);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV15vReportTime", context.localUtil.TToC( AV15vReportTime, 10, 8, 0, 0, "/", ":", " "));
            }
            else
            {
               AV15vReportTime = context.localUtil.CToT( cgiGet( edtavVreporttime_Internalname));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV15vReportTime", context.localUtil.TToC( AV15vReportTime, 10, 8, 0, 0, "/", ":", " "));
            }
            dynavBr_lab_br_lab_resultqual.CurrentValue = cgiGet( dynavBr_lab_br_lab_resultqual_Internalname);
            AV10BR_Lab.gxTpr_Br_lab_resultqual = cgiGet( dynavBr_lab_br_lab_resultqual_Internalname);
            AV10BR_Lab.gxTpr_Br_lab_resultunit = cgiGet( edtavBr_lab_br_lab_resultunit_Internalname);
            dynavBr_lab_br_lab_abnind.CurrentValue = cgiGet( dynavBr_lab_br_lab_abnind_Internalname);
            AV10BR_Lab.gxTpr_Br_lab_abnind = cgiGet( dynavBr_lab_br_lab_abnind_Internalname);
            AV10BR_Lab.gxTpr_Br_lab_normrangelow = cgiGet( edtavBr_lab_br_lab_normrangelow_Internalname);
            AV10BR_Lab.gxTpr_Br_lab_testmethod = cgiGet( edtavBr_lab_br_lab_testmethod_Internalname);
            AV10BR_Lab.gxTpr_Br_lab_instrumentcode = cgiGet( edtavBr_lab_br_lab_instrumentcode_Internalname);
            AV10BR_Lab.gxTpr_Br_lab_instrumentname = cgiGet( edtavBr_lab_br_lab_instrumentname_Internalname);
            AV10BR_Lab.gxTpr_Br_lab_resultnum = cgiGet( edtavBr_lab_br_lab_resultnum_Internalname);
            if ( ( ( context.localUtil.CToN( cgiGet( edtavBr_lab_br_encounterid_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavBr_lab_br_encounterid_Internalname), ".", ",") > Convert.ToDecimal( 999999999999999999L )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "BR_LAB_BR_ENCOUNTERID");
               GX_FocusControl = edtavBr_lab_br_encounterid_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV10BR_Lab.gxTpr_Br_encounterid = 0;
            }
            else
            {
               AV10BR_Lab.gxTpr_Br_encounterid = (long)(context.localUtil.CToN( cgiGet( edtavBr_lab_br_encounterid_Internalname), ".", ","));
            }
            AV10BR_Lab.gxTpr_Br_information_patientno = cgiGet( edtavBr_lab_br_information_patientno_Internalname);
            if ( ( ( context.localUtil.CToN( cgiGet( edtavBr_lab_br_labid_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavBr_lab_br_labid_Internalname), ".", ",") > Convert.ToDecimal( 999999999999999999L )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "BR_LAB_BR_LABID");
               GX_FocusControl = edtavBr_lab_br_labid_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV10BR_Lab.gxTpr_Br_labid = 0;
            }
            else
            {
               AV10BR_Lab.gxTpr_Br_labid = (long)(context.localUtil.CToN( cgiGet( edtavBr_lab_br_labid_Internalname), ".", ","));
            }
            AV10BR_Lab.gxTpr_Br_lab_sampleid = cgiGet( edtavBr_lab_br_lab_sampleid_Internalname);
            if ( ( ( context.localUtil.CToN( cgiGet( edtavBr_lab_br_lab_testid_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavBr_lab_br_lab_testid_Internalname), ".", ",") > Convert.ToDecimal( 9999999999L )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "BR_LAB_BR_LAB_TESTID");
               GX_FocusControl = edtavBr_lab_br_lab_testid_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV10BR_Lab.gxTpr_Br_lab_testid = 0;
            }
            else
            {
               AV10BR_Lab.gxTpr_Br_lab_testid = (long)(context.localUtil.CToN( cgiGet( edtavBr_lab_br_lab_testid_Internalname), ".", ","));
            }
            AV10BR_Lab.gxTpr_Br_lab_normrangehigh = cgiGet( edtavBr_lab_br_lab_normrangehigh_Internalname);
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
            forbiddenHiddens = "hsh" + "BR_LabDelete";
            AV10BR_Lab.gxTpr_Br_lab_testname = cgiGet( edtavBr_lab_br_lab_testname_Internalname);
            forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( AV10BR_Lab.gxTpr_Br_lab_testname, ""));
            AV10BR_Lab.gxTpr_Br_lab_testengname = cgiGet( edtavBr_lab_br_lab_testengname_Internalname);
            forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( AV10BR_Lab.gxTpr_Br_lab_testengname, ""));
            AV10BR_Lab.gxTpr_Br_lab_age = (short)(context.localUtil.CToN( cgiGet( edtavBr_lab_br_lab_age_Internalname), ".", ","));
            forbiddenHiddens = forbiddenHiddens + context.localUtil.Format( (decimal)(AV10BR_Lab.gxTpr_Br_lab_age), "ZZZ");
            AV10BR_Lab.gxTpr_Br_lab_diag = cgiGet( edtavBr_lab_br_lab_diag_Internalname);
            forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( AV10BR_Lab.gxTpr_Br_lab_diag, ""));
            AV11vSource = cgiGet( dynavVsource_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11vSource", AV11vSource);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vVSOURCE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( AV11vSource, "")), context));
            forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( AV11vSource, ""));
            AV10BR_Lab.gxTpr_Br_lab_resultqual = cgiGet( dynavBr_lab_br_lab_resultqual_Internalname);
            forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( AV10BR_Lab.gxTpr_Br_lab_resultqual, ""));
            AV10BR_Lab.gxTpr_Br_lab_resultunit = cgiGet( edtavBr_lab_br_lab_resultunit_Internalname);
            forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( AV10BR_Lab.gxTpr_Br_lab_resultunit, ""));
            AV10BR_Lab.gxTpr_Br_lab_abnind = cgiGet( dynavBr_lab_br_lab_abnind_Internalname);
            forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( AV10BR_Lab.gxTpr_Br_lab_abnind, ""));
            AV10BR_Lab.gxTpr_Br_lab_normrangelow = cgiGet( edtavBr_lab_br_lab_normrangelow_Internalname);
            forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( AV10BR_Lab.gxTpr_Br_lab_normrangelow, ""));
            AV10BR_Lab.gxTpr_Br_lab_testmethod = cgiGet( edtavBr_lab_br_lab_testmethod_Internalname);
            forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( AV10BR_Lab.gxTpr_Br_lab_testmethod, ""));
            AV10BR_Lab.gxTpr_Br_lab_instrumentcode = cgiGet( edtavBr_lab_br_lab_instrumentcode_Internalname);
            forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( AV10BR_Lab.gxTpr_Br_lab_instrumentcode, ""));
            AV10BR_Lab.gxTpr_Br_lab_instrumentname = cgiGet( edtavBr_lab_br_lab_instrumentname_Internalname);
            forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( AV10BR_Lab.gxTpr_Br_lab_instrumentname, ""));
            AV10BR_Lab.gxTpr_Br_lab_resultnum = cgiGet( edtavBr_lab_br_lab_resultnum_Internalname);
            forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( AV10BR_Lab.gxTpr_Br_lab_resultnum, ""));
            hsh = cgiGet( "hsh");
            if ( ! GXUtil.CheckEncryptedHash( forbiddenHiddens, hsh, GXKey) )
            {
               GXUtil.WriteLog("br_labdelete:[SecurityCheckFailed value for]"+"GXV1:"+StringUtil.RTrim( context.localUtil.Format( AV10BR_Lab.gxTpr_Br_lab_testname, "")));
               GXUtil.WriteLog("br_labdelete:[SecurityCheckFailed value for]"+"GXV2:"+StringUtil.RTrim( context.localUtil.Format( AV10BR_Lab.gxTpr_Br_lab_testengname, "")));
               GXUtil.WriteLog("br_labdelete:[SecurityCheckFailed value for]"+"GXV3:"+context.localUtil.Format( (decimal)(AV10BR_Lab.gxTpr_Br_lab_age), "ZZZ"));
               GXUtil.WriteLog("br_labdelete:[SecurityCheckFailed value for]"+"GXV4:"+StringUtil.RTrim( context.localUtil.Format( AV10BR_Lab.gxTpr_Br_lab_diag, "")));
               GXUtil.WriteLog("br_labdelete:[SecurityCheckFailed value for]"+"vSource:"+StringUtil.RTrim( context.localUtil.Format( AV11vSource, "")));
               GXUtil.WriteLog("br_labdelete:[SecurityCheckFailed value for]"+"GXV5:"+StringUtil.RTrim( context.localUtil.Format( AV10BR_Lab.gxTpr_Br_lab_resultqual, "")));
               GXUtil.WriteLog("br_labdelete:[SecurityCheckFailed value for]"+"GXV6:"+StringUtil.RTrim( context.localUtil.Format( AV10BR_Lab.gxTpr_Br_lab_resultunit, "")));
               GXUtil.WriteLog("br_labdelete:[SecurityCheckFailed value for]"+"GXV7:"+StringUtil.RTrim( context.localUtil.Format( AV10BR_Lab.gxTpr_Br_lab_abnind, "")));
               GXUtil.WriteLog("br_labdelete:[SecurityCheckFailed value for]"+"GXV8:"+StringUtil.RTrim( context.localUtil.Format( AV10BR_Lab.gxTpr_Br_lab_normrangelow, "")));
               GXUtil.WriteLog("br_labdelete:[SecurityCheckFailed value for]"+"GXV9:"+StringUtil.RTrim( context.localUtil.Format( AV10BR_Lab.gxTpr_Br_lab_testmethod, "")));
               GXUtil.WriteLog("br_labdelete:[SecurityCheckFailed value for]"+"GXV10:"+StringUtil.RTrim( context.localUtil.Format( AV10BR_Lab.gxTpr_Br_lab_instrumentcode, "")));
               GXUtil.WriteLog("br_labdelete:[SecurityCheckFailed value for]"+"GXV11:"+StringUtil.RTrim( context.localUtil.Format( AV10BR_Lab.gxTpr_Br_lab_instrumentname, "")));
               GXUtil.WriteLog("br_labdelete:[SecurityCheckFailed value for]"+"GXV12:"+StringUtil.RTrim( context.localUtil.Format( AV10BR_Lab.gxTpr_Br_lab_resultnum, "")));
               GxWebError = 1;
               context.HttpContext.Response.StatusDescription = 403.ToString();
               context.HttpContext.Response.StatusCode = 403;
               context.WriteHtmlText( "<title>403 Forbidden</title>") ;
               context.WriteHtmlText( "<h1>403 Forbidden</h1>") ;
               context.WriteHtmlText( "<p /><hr />") ;
               GXUtil.WriteLog("send_http_error_code " + 403.ToString());
               return  ;
            }
            GXVvVSOURCE_html8R2( AV18tCurrentCode) ;
            GXVBR_LAB_BR_LAB_RESULTQUAL_html8R2( AV18tCurrentCode) ;
            GXVBR_LAB_BR_LAB_ABNIND_html8R2( AV18tCurrentCode) ;
         }
         else
         {
            dynload_actions( ) ;
         }
      }

      protected void GXStart( )
      {
         /* Execute user event: Start */
         E118R2 ();
         if (returnInSub) return;
      }

      protected void E118R2( )
      {
         /* Start Routine */
         GXt_char1 = AV18tCurrentCode;
         new zbr_getcurrenttcode(context ).execute( out  GXt_char1) ;
         AV18tCurrentCode = GXt_char1;
         edtavBr_lab_br_encounterid_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavBr_lab_br_encounterid_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavBr_lab_br_encounterid_Visible), 5, 0)), true);
         edtavBr_lab_br_information_patientno_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavBr_lab_br_information_patientno_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavBr_lab_br_information_patientno_Visible), 5, 0)), true);
         edtavBr_lab_br_labid_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavBr_lab_br_labid_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavBr_lab_br_labid_Visible), 5, 0)), true);
         edtavBr_lab_br_lab_sampleid_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavBr_lab_br_lab_sampleid_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavBr_lab_br_lab_sampleid_Visible), 5, 0)), true);
         edtavBr_lab_br_lab_testid_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavBr_lab_br_lab_testid_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavBr_lab_br_lab_testid_Visible), 5, 0)), true);
         edtavBr_lab_br_lab_normrangehigh_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavBr_lab_br_lab_normrangehigh_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavBr_lab_br_lab_normrangehigh_Visible), 5, 0)), true);
         AV10BR_Lab.Load(AV17iBR_LabID);
         GX_msglist.addItem("确认删除.");
         AV13vSpecimenDate = AV10BR_Lab.gxTpr_Br_lab_specimendate;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13vSpecimenDate", context.localUtil.TToC( AV13vSpecimenDate, 10, 8, 0, 0, "/", ":", " "));
         AV14vReceivingTime = AV10BR_Lab.gxTpr_Br_lab_receivingtime;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14vReceivingTime", context.localUtil.TToC( AV14vReceivingTime, 10, 8, 0, 0, "/", ":", " "));
         AV15vReportTime = AV10BR_Lab.gxTpr_Br_lab_reporttime;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV15vReportTime", context.localUtil.TToC( AV15vReportTime, 10, 8, 0, 0, "/", ":", " "));
      }

      protected void S112( )
      {
         /* 'SHOW MESSAGES' Routine */
         AV40GXV19 = 1;
         while ( AV40GXV19 <= AV8Messages.Count )
         {
            AV7Message = ((SdtMessages_Message)AV8Messages.Item(AV40GXV19));
            GX_msglist.addItem(AV7Message.gxTpr_Description);
            AV40GXV19 = (int)(AV40GXV19+1);
         }
      }

      protected void E128R2( )
      {
         /* Refresh Routine */
         new GeneXus.Programs.wwpbaseobjects.loadwwpcontext(context ).execute( out  AV9Context) ;
      }

      public void GXEnter( )
      {
         /* Execute user event: Enter */
         E138R2 ();
         if (returnInSub) return;
      }

      protected void E138R2( )
      {
         /* Enter Routine */
         new zutil_checksession(context ).execute( out  AV19tCheckFlag) ;
         if ( ! AV19tCheckFlag )
         {
            AV10BR_Lab.Delete();
            context.CommitDataStores("br_labdelete",pr_default);
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

      protected void E148R2( )
      {
         /* Load Routine */
         AV10BR_Lab.Load(AV17iBR_LabID);
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV10BR_Lab.gxTpr_Br_lab_specimensource)) )
         {
            dynavVsource.addItem(AV10BR_Lab.gxTpr_Br_lab_specimensource, AV10BR_Lab.gxTpr_Br_lab_specimensource, 0);
            AV11vSource = AV10BR_Lab.gxTpr_Br_lab_specimensource;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11vSource", AV11vSource);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vVSOURCE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( AV11vSource, "")), context));
         }
      }

      protected void wb_table1_46_8R2( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "";
            GxWebStd.gx_table_start( context, tblTablemergedvsource_Internalname, tblTablemergedvsource_Internalname, "", "TableMerged", 0, "", "", 0, 0, sStyleString, "", "", 0);
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td class='MergeDataCell'>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, dynavVsource_Internalname, "v Source", "col-sm-3 ReadonlyAttributeLabel", 0, true);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 50,'',false,'',0)\"";
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, dynavVsource, dynavVsource_Internalname, StringUtil.RTrim( AV11vSource), 1, dynavVsource_Jsonclick, 0, "'"+""+"'"+",false,"+"'"+""+"'", "svchar", "", 1, dynavVsource.Enabled, 0, 0, 0, "em", 0, "", "", "ReadonlyAttribute", "", "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,50);\"", "", true, "HLP_BR_LabDelete.htm");
            dynavVsource.CurrentValue = StringUtil.RTrim( AV11vSource);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynavVsource_Internalname, "Values", (String)(dynavVsource.ToJavascriptSource()), true);
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td class='DataContentCell'>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavVothersource_Internalname, "v Other Source", "col-sm-3 ReadonlyAttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 53,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavVothersource_Internalname, AV12vOtherSource, StringUtil.RTrim( context.localUtil.Format( AV12vOtherSource, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,53);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "请填写其它标本种类", edtavVothersource_Jsonclick, 0, "ReadonlyAttribute", "", "", "", "", 1, edtavVothersource_Enabled, 0, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_BR_LabDelete.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table1_46_8R2e( true) ;
         }
         else
         {
            wb_table1_46_8R2e( false) ;
         }
      }

      public override void setparameters( Object[] obj )
      {
         createObjects();
         initialize();
         AV17iBR_LabID = Convert.ToInt64(getParm(obj,0));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV17iBR_LabID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV17iBR_LabID), 18, 0)));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vIBR_LABID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV17iBR_LabID), "ZZZZZZZZZZZZZZZZZZ"), context));
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
         PA8R2( ) ;
         WS8R2( ) ;
         WE8R2( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?20202271265164", true);
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
         context.AddJavascriptSource("br_labdelete.js", "?20202271265164", false);
         context.AddJavascriptSource("DVelop/Bootstrap/Shared/DVelopBootstrap.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/Panel/BootstrapPanelRender.js", "", false);
         /* End function include_jscripts */
      }

      protected void init_web_controls( )
      {
         dynavVsource.Name = "vVSOURCE";
         dynavVsource.WebTags = "";
         dynavBr_lab_br_lab_resultqual.Name = "BR_LAB_BR_LAB_RESULTQUAL";
         dynavBr_lab_br_lab_resultqual.WebTags = "";
         dynavBr_lab_br_lab_abnind.Name = "BR_LAB_BR_LAB_ABNIND";
         dynavBr_lab_br_lab_abnind.WebTags = "";
         /* End function init_web_controls */
      }

      protected void init_default_properties( )
      {
         edtavBr_lab_br_lab_testname_Internalname = "BR_LAB_BR_LAB_TESTNAME";
         edtavBr_lab_br_lab_testengname_Internalname = "BR_LAB_BR_LAB_TESTENGNAME";
         edtavBr_lab_br_lab_age_Internalname = "BR_LAB_BR_LAB_AGE";
         edtavBr_lab_br_lab_diag_Internalname = "BR_LAB_BR_LAB_DIAG";
         lblTextblockvsource_Internalname = "TEXTBLOCKVSOURCE";
         dynavVsource_Internalname = "vVSOURCE";
         edtavVothersource_Internalname = "vVOTHERSOURCE";
         tblTablemergedvsource_Internalname = "TABLEMERGEDVSOURCE";
         divTablesplittedvsource_Internalname = "TABLESPLITTEDVSOURCE";
         edtavVspecimendate_Internalname = "vVSPECIMENDATE";
         edtavVreceivingtime_Internalname = "vVRECEIVINGTIME";
         edtavVreporttime_Internalname = "vVREPORTTIME";
         dynavBr_lab_br_lab_resultqual_Internalname = "BR_LAB_BR_LAB_RESULTQUAL";
         edtavBr_lab_br_lab_resultunit_Internalname = "BR_LAB_BR_LAB_RESULTUNIT";
         dynavBr_lab_br_lab_abnind_Internalname = "BR_LAB_BR_LAB_ABNIND";
         edtavBr_lab_br_lab_normrangelow_Internalname = "BR_LAB_BR_LAB_NORMRANGELOW";
         edtavBr_lab_br_lab_testmethod_Internalname = "BR_LAB_BR_LAB_TESTMETHOD";
         edtavBr_lab_br_lab_instrumentcode_Internalname = "BR_LAB_BR_LAB_INSTRUMENTCODE";
         edtavBr_lab_br_lab_instrumentname_Internalname = "BR_LAB_BR_LAB_INSTRUMENTNAME";
         edtavBr_lab_br_lab_resultnum_Internalname = "BR_LAB_BR_LAB_RESULTNUM";
         divTableattributes_Internalname = "TABLEATTRIBUTES";
         divLayout_tableattributes_Internalname = "LAYOUT_TABLEATTRIBUTES";
         Dvpanel_tableattributes_Internalname = "DVPANEL_TABLEATTRIBUTES";
         divHtml_dvpanel_tableattributes_Internalname = "HTML_DVPANEL_TABLEATTRIBUTES";
         divTablecontent_Internalname = "TABLECONTENT";
         bttBtnenter_Internalname = "BTNENTER";
         bttBtncancel_Internalname = "BTNCANCEL";
         divTablemain_Internalname = "TABLEMAIN";
         edtavBr_lab_br_encounterid_Internalname = "BR_LAB_BR_ENCOUNTERID";
         edtavBr_lab_br_information_patientno_Internalname = "BR_LAB_BR_INFORMATION_PATIENTNO";
         edtavBr_lab_br_labid_Internalname = "BR_LAB_BR_LABID";
         edtavBr_lab_br_lab_sampleid_Internalname = "BR_LAB_BR_LAB_SAMPLEID";
         edtavBr_lab_br_lab_testid_Internalname = "BR_LAB_BR_LAB_TESTID";
         edtavBr_lab_br_lab_normrangehigh_Internalname = "BR_LAB_BR_LAB_NORMRANGEHIGH";
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
         edtavVothersource_Jsonclick = "";
         edtavVothersource_Enabled = 1;
         dynavVsource_Jsonclick = "";
         dynavVsource.Enabled = 1;
         edtavBr_lab_br_lab_resultnum_Enabled = -1;
         edtavBr_lab_br_lab_instrumentname_Enabled = -1;
         edtavBr_lab_br_lab_instrumentcode_Enabled = -1;
         edtavBr_lab_br_lab_testmethod_Enabled = -1;
         edtavBr_lab_br_lab_normrangelow_Enabled = -1;
         dynavBr_lab_br_lab_abnind.Enabled = -1;
         edtavBr_lab_br_lab_resultunit_Enabled = -1;
         dynavBr_lab_br_lab_resultqual.Enabled = -1;
         edtavBr_lab_br_lab_diag_Enabled = -1;
         edtavBr_lab_br_lab_age_Enabled = -1;
         edtavBr_lab_br_lab_testengname_Enabled = -1;
         edtavBr_lab_br_lab_testname_Enabled = -1;
         edtavBr_lab_br_lab_normrangehigh_Jsonclick = "";
         edtavBr_lab_br_lab_normrangehigh_Visible = 1;
         edtavBr_lab_br_lab_testid_Jsonclick = "";
         edtavBr_lab_br_lab_testid_Visible = 1;
         edtavBr_lab_br_lab_sampleid_Jsonclick = "";
         edtavBr_lab_br_lab_sampleid_Visible = 1;
         edtavBr_lab_br_labid_Jsonclick = "";
         edtavBr_lab_br_labid_Visible = 1;
         edtavBr_lab_br_information_patientno_Jsonclick = "";
         edtavBr_lab_br_information_patientno_Visible = 1;
         edtavBr_lab_br_encounterid_Jsonclick = "";
         edtavBr_lab_br_encounterid_Visible = 1;
         edtavBr_lab_br_lab_resultnum_Enabled = 0;
         edtavBr_lab_br_lab_instrumentname_Enabled = 0;
         edtavBr_lab_br_lab_instrumentcode_Jsonclick = "";
         edtavBr_lab_br_lab_instrumentcode_Enabled = 0;
         edtavBr_lab_br_lab_testmethod_Jsonclick = "";
         edtavBr_lab_br_lab_testmethod_Enabled = 0;
         edtavBr_lab_br_lab_normrangelow_Jsonclick = "";
         edtavBr_lab_br_lab_normrangelow_Enabled = 0;
         dynavBr_lab_br_lab_abnind_Jsonclick = "";
         dynavBr_lab_br_lab_abnind.Enabled = 0;
         edtavBr_lab_br_lab_resultunit_Jsonclick = "";
         edtavBr_lab_br_lab_resultunit_Enabled = 0;
         dynavBr_lab_br_lab_resultqual_Jsonclick = "";
         dynavBr_lab_br_lab_resultqual.Enabled = 0;
         edtavVreporttime_Jsonclick = "";
         edtavVreporttime_Enabled = 1;
         edtavVreceivingtime_Jsonclick = "";
         edtavVreceivingtime_Enabled = 1;
         edtavVspecimendate_Jsonclick = "";
         edtavVspecimendate_Enabled = 1;
         edtavBr_lab_br_lab_diag_Jsonclick = "";
         edtavBr_lab_br_lab_diag_Enabled = 0;
         edtavBr_lab_br_lab_age_Jsonclick = "";
         edtavBr_lab_br_lab_age_Enabled = 0;
         edtavBr_lab_br_lab_testengname_Jsonclick = "";
         edtavBr_lab_br_lab_testengname_Enabled = 0;
         edtavBr_lab_br_lab_testname_Jsonclick = "";
         edtavBr_lab_br_lab_testname_Enabled = 0;
         Dvpanel_tableattributes_Autoscroll = Convert.ToBoolean( 0);
         Dvpanel_tableattributes_Iconposition = "left";
         Dvpanel_tableattributes_Showcollapseicon = Convert.ToBoolean( 0);
         Dvpanel_tableattributes_Autoheight = Convert.ToBoolean( -1);
         Dvpanel_tableattributes_Autowidth = Convert.ToBoolean( 0);
         Dvpanel_tableattributes_Collapsed = Convert.ToBoolean( 0);
         Dvpanel_tableattributes_Collapsible = Convert.ToBoolean( 0);
         Dvpanel_tableattributes_Title = "实验室检查";
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
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[{av:'AV17iBR_LabID',fld:'vIBR_LABID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true},{av:'dynavVsource'},{av:'AV11vSource',fld:'vVSOURCE',pic:'',hsh:true},{av:'AV10BR_Lab.gxTpr_Br_lab_testname',fld:'BR_LAB_BR_LAB_TESTNAME',pic:''},{av:'AV10BR_Lab.gxTpr_Br_lab_testengname',fld:'BR_LAB_BR_LAB_TESTENGNAME',pic:''},{av:'AV10BR_Lab.gxTpr_Br_lab_age',fld:'BR_LAB_BR_LAB_AGE',pic:'ZZZ'},{av:'AV10BR_Lab.gxTpr_Br_lab_diag',fld:'BR_LAB_BR_LAB_DIAG',pic:''},{av:'dynavBr_lab_br_lab_resultqual'},{av:'AV10BR_Lab.gxTpr_Br_lab_resultqual',fld:'BR_LAB_BR_LAB_RESULTQUAL',pic:''},{av:'AV10BR_Lab.gxTpr_Br_lab_resultunit',fld:'BR_LAB_BR_LAB_RESULTUNIT',pic:''},{av:'dynavBr_lab_br_lab_abnind'},{av:'AV10BR_Lab.gxTpr_Br_lab_abnind',fld:'BR_LAB_BR_LAB_ABNIND',pic:''},{av:'AV10BR_Lab.gxTpr_Br_lab_normrangelow',fld:'BR_LAB_BR_LAB_NORMRANGELOW',pic:''},{av:'AV10BR_Lab.gxTpr_Br_lab_testmethod',fld:'BR_LAB_BR_LAB_TESTMETHOD',pic:''},{av:'AV10BR_Lab.gxTpr_Br_lab_instrumentcode',fld:'BR_LAB_BR_LAB_INSTRUMENTCODE',pic:''},{av:'AV10BR_Lab.gxTpr_Br_lab_instrumentname',fld:'BR_LAB_BR_LAB_INSTRUMENTNAME',pic:''},{av:'AV10BR_Lab.gxTpr_Br_lab_resultnum',fld:'BR_LAB_BR_LAB_RESULTNUM',pic:''}]");
         setEventMetadata("REFRESH",",oparms:[]}");
         setEventMetadata("ENTER","{handler:'E138R2',iparms:[{av:'AV10BR_Lab',fld:'vBR_LAB',pic:''}]");
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
         AV18tCurrentCode = "";
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         AV11vSource = "";
         GXKey = "";
         forbiddenHiddens = "";
         AV10BR_Lab = new SdtBR_Lab(context);
         GX_FocusControl = "";
         Form = new GXWebForm();
         sPrefix = "";
         ClassString = "";
         StyleString = "";
         ucDvpanel_tableattributes = new GXUserControl();
         lblTextblockvsource_Jsonclick = "";
         TempTags = "";
         AV13vSpecimenDate = (DateTime)(DateTime.MinValue);
         AV14vReceivingTime = (DateTime)(DateTime.MinValue);
         AV15vReportTime = (DateTime)(DateTime.MinValue);
         bttBtnenter_Jsonclick = "";
         bttBtncancel_Jsonclick = "";
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         gxdynajaxctrlcodr = new GeneXus.Utils.GxStringCollection();
         gxdynajaxctrldescr = new GeneXus.Utils.GxStringCollection();
         gxwrpcisep = "";
         scmdbuf = "";
         H008R2_A167XT_DefineCodeID = new long[1] ;
         H008R2_A168XT_DefineCodeName = new String[] {""} ;
         H008R2_n168XT_DefineCodeName = new bool[] {false} ;
         H008R2_A165XT_DefindcodeTypeID = new long[1] ;
         H008R2_A432XT_TenantCode = new String[] {""} ;
         H008R2_n432XT_TenantCode = new bool[] {false} ;
         H008R3_A167XT_DefineCodeID = new long[1] ;
         H008R3_A168XT_DefineCodeName = new String[] {""} ;
         H008R3_n168XT_DefineCodeName = new bool[] {false} ;
         H008R3_A165XT_DefindcodeTypeID = new long[1] ;
         H008R3_A432XT_TenantCode = new String[] {""} ;
         H008R3_n432XT_TenantCode = new bool[] {false} ;
         H008R4_A167XT_DefineCodeID = new long[1] ;
         H008R4_A168XT_DefineCodeName = new String[] {""} ;
         H008R4_n168XT_DefineCodeName = new bool[] {false} ;
         H008R4_A165XT_DefindcodeTypeID = new long[1] ;
         H008R4_A432XT_TenantCode = new String[] {""} ;
         H008R4_n432XT_TenantCode = new bool[] {false} ;
         AV12vOtherSource = "";
         hsh = "";
         GXt_char1 = "";
         AV8Messages = new GXBaseCollection<SdtMessages_Message>( context, "Message", "GeneXus");
         AV7Message = new SdtMessages_Message(context);
         AV9Context = new GeneXus.Programs.wwpbaseobjects.SdtWWPContext(context);
         sStyleString = "";
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         pr_datastore1 = new DataStoreProvider(context, new GeneXus.Programs.br_labdelete__datastore1(),
            new Object[][] {
            }
         );
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.br_labdelete__default(),
            new Object[][] {
                new Object[] {
               H008R2_A167XT_DefineCodeID, H008R2_A168XT_DefineCodeName, H008R2_n168XT_DefineCodeName, H008R2_A165XT_DefindcodeTypeID, H008R2_A432XT_TenantCode, H008R2_n432XT_TenantCode
               }
               , new Object[] {
               H008R3_A167XT_DefineCodeID, H008R3_A168XT_DefineCodeName, H008R3_n168XT_DefineCodeName, H008R3_A165XT_DefindcodeTypeID, H008R3_A432XT_TenantCode, H008R3_n432XT_TenantCode
               }
               , new Object[] {
               H008R4_A167XT_DefineCodeID, H008R4_A168XT_DefineCodeName, H008R4_n168XT_DefineCodeName, H008R4_A165XT_DefindcodeTypeID, H008R4_A432XT_TenantCode, H008R4_n432XT_TenantCode
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0;
         edtavBr_lab_br_lab_testname_Enabled = 0;
         edtavBr_lab_br_lab_testengname_Enabled = 0;
         edtavBr_lab_br_lab_age_Enabled = 0;
         edtavBr_lab_br_lab_diag_Enabled = 0;
         dynavVsource.Enabled = 0;
         edtavVothersource_Enabled = 0;
         edtavVspecimendate_Enabled = 0;
         edtavVreceivingtime_Enabled = 0;
         edtavVreporttime_Enabled = 0;
         dynavBr_lab_br_lab_resultqual.Enabled = 0;
         edtavBr_lab_br_lab_resultunit_Enabled = 0;
         dynavBr_lab_br_lab_abnind.Enabled = 0;
         edtavBr_lab_br_lab_normrangelow_Enabled = 0;
         edtavBr_lab_br_lab_testmethod_Enabled = 0;
         edtavBr_lab_br_lab_instrumentcode_Enabled = 0;
         edtavBr_lab_br_lab_instrumentname_Enabled = 0;
         edtavBr_lab_br_lab_resultnum_Enabled = 0;
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
      private int edtavBr_lab_br_lab_testname_Enabled ;
      private int edtavBr_lab_br_lab_testengname_Enabled ;
      private int edtavBr_lab_br_lab_age_Enabled ;
      private int edtavBr_lab_br_lab_diag_Enabled ;
      private int edtavVspecimendate_Enabled ;
      private int edtavVreceivingtime_Enabled ;
      private int edtavVreporttime_Enabled ;
      private int edtavBr_lab_br_lab_resultunit_Enabled ;
      private int edtavBr_lab_br_lab_normrangelow_Enabled ;
      private int edtavBr_lab_br_lab_testmethod_Enabled ;
      private int edtavBr_lab_br_lab_instrumentcode_Enabled ;
      private int edtavBr_lab_br_lab_instrumentname_Enabled ;
      private int edtavBr_lab_br_lab_resultnum_Enabled ;
      private int edtavBr_lab_br_encounterid_Visible ;
      private int edtavBr_lab_br_information_patientno_Visible ;
      private int edtavBr_lab_br_labid_Visible ;
      private int edtavBr_lab_br_lab_sampleid_Visible ;
      private int edtavBr_lab_br_lab_testid_Visible ;
      private int edtavBr_lab_br_lab_normrangehigh_Visible ;
      private int gxdynajaxindex ;
      private int edtavVothersource_Enabled ;
      private int AV40GXV19 ;
      private int idxLst ;
      private long AV17iBR_LabID ;
      private long wcpOAV17iBR_LabID ;
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
      private String edtavBr_lab_br_lab_testname_Internalname ;
      private String edtavBr_lab_br_lab_testname_Jsonclick ;
      private String edtavBr_lab_br_lab_testengname_Internalname ;
      private String edtavBr_lab_br_lab_testengname_Jsonclick ;
      private String edtavBr_lab_br_lab_age_Internalname ;
      private String edtavBr_lab_br_lab_age_Jsonclick ;
      private String edtavBr_lab_br_lab_diag_Internalname ;
      private String edtavBr_lab_br_lab_diag_Jsonclick ;
      private String divTablesplittedvsource_Internalname ;
      private String lblTextblockvsource_Internalname ;
      private String lblTextblockvsource_Jsonclick ;
      private String edtavVspecimendate_Internalname ;
      private String TempTags ;
      private String edtavVspecimendate_Jsonclick ;
      private String edtavVreceivingtime_Internalname ;
      private String edtavVreceivingtime_Jsonclick ;
      private String edtavVreporttime_Internalname ;
      private String edtavVreporttime_Jsonclick ;
      private String dynavBr_lab_br_lab_resultqual_Internalname ;
      private String dynavBr_lab_br_lab_resultqual_Jsonclick ;
      private String edtavBr_lab_br_lab_resultunit_Internalname ;
      private String edtavBr_lab_br_lab_resultunit_Jsonclick ;
      private String dynavBr_lab_br_lab_abnind_Internalname ;
      private String dynavBr_lab_br_lab_abnind_Jsonclick ;
      private String edtavBr_lab_br_lab_normrangelow_Internalname ;
      private String edtavBr_lab_br_lab_normrangelow_Jsonclick ;
      private String edtavBr_lab_br_lab_testmethod_Internalname ;
      private String edtavBr_lab_br_lab_testmethod_Jsonclick ;
      private String edtavBr_lab_br_lab_instrumentcode_Internalname ;
      private String edtavBr_lab_br_lab_instrumentcode_Jsonclick ;
      private String edtavBr_lab_br_lab_instrumentname_Internalname ;
      private String edtavBr_lab_br_lab_resultnum_Internalname ;
      private String bttBtnenter_Internalname ;
      private String bttBtnenter_Jsonclick ;
      private String bttBtncancel_Internalname ;
      private String bttBtncancel_Jsonclick ;
      private String divHtml_bottomauxiliarcontrols_Internalname ;
      private String edtavBr_lab_br_encounterid_Internalname ;
      private String edtavBr_lab_br_encounterid_Jsonclick ;
      private String edtavBr_lab_br_information_patientno_Internalname ;
      private String edtavBr_lab_br_information_patientno_Jsonclick ;
      private String edtavBr_lab_br_labid_Internalname ;
      private String edtavBr_lab_br_labid_Jsonclick ;
      private String edtavBr_lab_br_lab_sampleid_Internalname ;
      private String edtavBr_lab_br_lab_sampleid_Jsonclick ;
      private String edtavBr_lab_br_lab_testid_Internalname ;
      private String edtavBr_lab_br_lab_testid_Jsonclick ;
      private String edtavBr_lab_br_lab_normrangehigh_Internalname ;
      private String edtavBr_lab_br_lab_normrangehigh_Jsonclick ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String gxwrpcisep ;
      private String scmdbuf ;
      private String dynavVsource_Internalname ;
      private String edtavVothersource_Internalname ;
      private String hsh ;
      private String GXt_char1 ;
      private String sStyleString ;
      private String tblTablemergedvsource_Internalname ;
      private String dynavVsource_Jsonclick ;
      private String edtavVothersource_Jsonclick ;
      private DateTime AV13vSpecimenDate ;
      private DateTime AV14vReceivingTime ;
      private DateTime AV15vReportTime ;
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
      private bool AV19tCheckFlag ;
      private String AV18tCurrentCode ;
      private String AV11vSource ;
      private String AV12vOtherSource ;
      private GeneXus.Utils.GxStringCollection gxdynajaxctrlcodr ;
      private GeneXus.Utils.GxStringCollection gxdynajaxctrldescr ;
      private GXUserControl ucDvpanel_tableattributes ;
      private IGxDataStore dsDataStore1 ;
      private IGxDataStore dsDefault ;
      private GXCombobox dynavVsource ;
      private GXCombobox dynavBr_lab_br_lab_resultqual ;
      private GXCombobox dynavBr_lab_br_lab_abnind ;
      private IDataStoreProvider pr_default ;
      private long[] H008R2_A167XT_DefineCodeID ;
      private String[] H008R2_A168XT_DefineCodeName ;
      private bool[] H008R2_n168XT_DefineCodeName ;
      private long[] H008R2_A165XT_DefindcodeTypeID ;
      private String[] H008R2_A432XT_TenantCode ;
      private bool[] H008R2_n432XT_TenantCode ;
      private long[] H008R3_A167XT_DefineCodeID ;
      private String[] H008R3_A168XT_DefineCodeName ;
      private bool[] H008R3_n168XT_DefineCodeName ;
      private long[] H008R3_A165XT_DefindcodeTypeID ;
      private String[] H008R3_A432XT_TenantCode ;
      private bool[] H008R3_n432XT_TenantCode ;
      private long[] H008R4_A167XT_DefineCodeID ;
      private String[] H008R4_A168XT_DefineCodeName ;
      private bool[] H008R4_n168XT_DefineCodeName ;
      private long[] H008R4_A165XT_DefindcodeTypeID ;
      private String[] H008R4_A432XT_TenantCode ;
      private bool[] H008R4_n432XT_TenantCode ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private IDataStoreProvider pr_datastore1 ;
      private GXBaseCollection<SdtMessages_Message> AV8Messages ;
      private GXWebForm Form ;
      private SdtMessages_Message AV7Message ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPContext AV9Context ;
      private SdtBR_Lab AV10BR_Lab ;
   }

   public class br_labdelete__datastore1 : DataStoreHelperBase, IDataStoreHelper
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

 public class br_labdelete__default : DataStoreHelperBase, IDataStoreHelper
 {
    public ICursor[] getCursors( )
    {
       cursorDefinitions();
       return new Cursor[] {
        new ForEachCursor(def[0])
       ,new ForEachCursor(def[1])
       ,new ForEachCursor(def[2])
     };
  }

  private static CursorDef[] def;
  private void cursorDefinitions( )
  {
     if ( def == null )
     {
        Object[] prmH008R2 ;
        prmH008R2 = new Object[] {
        new Object[] {"@AV18tCurrentCode",SqlDbType.NVarChar,40,0}
        } ;
        Object[] prmH008R3 ;
        prmH008R3 = new Object[] {
        new Object[] {"@AV18tCurrentCode",SqlDbType.NVarChar,40,0}
        } ;
        Object[] prmH008R4 ;
        prmH008R4 = new Object[] {
        new Object[] {"@AV18tCurrentCode",SqlDbType.NVarChar,40,0}
        } ;
        def= new CursorDef[] {
            new CursorDef("H008R2", "SELECT [XT_DefineCodeID], [XT_DefineCodeName], [XT_DefindcodeTypeID], [XT_TenantCode] FROM [XT_DefineCode] WITH (NOLOCK) WHERE ([XT_DefindcodeTypeID] = 22) AND ([XT_TenantCode] = @AV18tCurrentCode) ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH008R2,0,0,true,false )
           ,new CursorDef("H008R3", "SELECT [XT_DefineCodeID], [XT_DefineCodeName], [XT_DefindcodeTypeID], [XT_TenantCode] FROM [XT_DefineCode] WITH (NOLOCK) WHERE ([XT_DefindcodeTypeID] = 23) AND ([XT_TenantCode] = @AV18tCurrentCode) ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH008R3,0,0,true,false )
           ,new CursorDef("H008R4", "SELECT [XT_DefineCodeID], [XT_DefineCodeName], [XT_DefindcodeTypeID], [XT_TenantCode] FROM [XT_DefineCode] WITH (NOLOCK) WHERE ([XT_DefindcodeTypeID] = 24) AND ([XT_TenantCode] = @AV18tCurrentCode) ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH008R4,0,0,true,false )
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
              ((String[]) buf[4])[0] = rslt.getVarchar(4) ;
              ((bool[]) buf[5])[0] = rslt.wasNull(4);
              return;
           case 1 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
              ((bool[]) buf[2])[0] = rslt.wasNull(2);
              ((long[]) buf[3])[0] = rslt.getLong(3) ;
              ((String[]) buf[4])[0] = rslt.getVarchar(4) ;
              ((bool[]) buf[5])[0] = rslt.wasNull(4);
              return;
           case 2 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
              ((bool[]) buf[2])[0] = rslt.wasNull(2);
              ((long[]) buf[3])[0] = rslt.getLong(3) ;
              ((String[]) buf[4])[0] = rslt.getVarchar(4) ;
              ((bool[]) buf[5])[0] = rslt.wasNull(4);
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
              stmt.SetParameter(1, (String)parms[0]);
              return;
           case 1 :
              stmt.SetParameter(1, (String)parms[0]);
              return;
           case 2 :
              stmt.SetParameter(1, (String)parms[0]);
              return;
     }
  }

}

}
