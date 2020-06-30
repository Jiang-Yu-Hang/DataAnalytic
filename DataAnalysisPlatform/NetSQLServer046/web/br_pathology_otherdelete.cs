/*
               File: BR_Pathology_OtherDelete
        Description:
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/27/2020 12:5:30.3
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
   public class br_pathology_otherdelete : GXDataArea, System.Web.SessionState.IRequiresSessionState
   {
      public br_pathology_otherdelete( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public br_pathology_otherdelete( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( long aP0_iBR_Pathology_OtherID )
      {
         this.AV11iBR_Pathology_OtherID = aP0_iBR_Pathology_OtherID;
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
               AV11iBR_Pathology_OtherID = (long)(NumberUtil.Val( gxfirstwebparm, "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11iBR_Pathology_OtherID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11iBR_Pathology_OtherID), 18, 0)));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vIBR_PATHOLOGY_OTHERID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV11iBR_Pathology_OtherID), "ZZZZZZZZZZZZZZZZZZ"), context));
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
         PA742( ) ;
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0));
         if ( ( gxajaxcallmode == 0 ) && ( GxWebError == 0 ) )
         {
            START742( ) ;
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
         context.AddJavascriptSource("gxcfg.js", "?2020227125307", false);
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" autocomplete=\"off\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("br_pathology_otherdelete.aspx") + "?" + UrlEncode("" +AV11iBR_Pathology_OtherID)+"\">") ;
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
         forbiddenHiddens = "hsh" + "BR_Pathology_OtherDelete";
         forbiddenHiddens = forbiddenHiddens + context.localUtil.Format( AV10BR_Pathology_Other.gxTpr_Br_pathology_other_bionum, "ZZZZZZZZZ.ZZZZZ");
         forbiddenHiddens = forbiddenHiddens + context.localUtil.Format( AV10BR_Pathology_Other.gxTpr_Br_pathology_other_low, "ZZZZZZZZZ.ZZZZZ");
         forbiddenHiddens = forbiddenHiddens + context.localUtil.Format( AV10BR_Pathology_Other.gxTpr_Br_pathology_other_high, "ZZZZZZZZZ.ZZZZZ");
         forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( AV10BR_Pathology_Other.gxTpr_Br_pathology_other_abnind, ""));
         GxWebStd.gx_hidden_field( context, "hsh", GetEncryptedHash( forbiddenHiddens, GXKey));
         GXUtil.WriteLog("br_pathology_otherdelete:[SendSecurityCheck value for]"+"GXV1:"+context.localUtil.Format( AV10BR_Pathology_Other.gxTpr_Br_pathology_other_bionum, "ZZZZZZZZZ.ZZZZZ"));
         GXUtil.WriteLog("br_pathology_otherdelete:[SendSecurityCheck value for]"+"GXV2:"+context.localUtil.Format( AV10BR_Pathology_Other.gxTpr_Br_pathology_other_low, "ZZZZZZZZZ.ZZZZZ"));
         GXUtil.WriteLog("br_pathology_otherdelete:[SendSecurityCheck value for]"+"GXV3:"+context.localUtil.Format( AV10BR_Pathology_Other.gxTpr_Br_pathology_other_high, "ZZZZZZZZZ.ZZZZZ"));
         GXUtil.WriteLog("br_pathology_otherdelete:[SendSecurityCheck value for]"+"GXV4:"+StringUtil.RTrim( context.localUtil.Format( AV10BR_Pathology_Other.gxTpr_Br_pathology_other_abnind, "")));
      }

      protected void SendCloseFormHiddens( )
      {
         /* Send hidden variables. */
         /* Send saved values. */
         send_integrity_footer_hashes( ) ;
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "Br_pathology_other", AV10BR_Pathology_Other);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("Br_pathology_other", AV10BR_Pathology_Other);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vBR_PATHOLOGY_OTHER", AV10BR_Pathology_Other);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vBR_PATHOLOGY_OTHER", AV10BR_Pathology_Other);
         }
         GxWebStd.gx_hidden_field( context, "vIBR_PATHOLOGY_OTHERID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV11iBR_Pathology_OtherID), 18, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "gxhash_vIBR_PATHOLOGY_OTHERID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV11iBR_Pathology_OtherID), "ZZZZZZZZZZZZZZZZZZ"), context));
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
            WE742( ) ;
            context.WriteHtmlText( "</div>") ;
         }
      }

      public override void DispatchEvents( )
      {
         EVT742( ) ;
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
         return formatLink("br_pathology_otherdelete.aspx") + "?" + UrlEncode("" +AV11iBR_Pathology_OtherID) ;
      }

      public override String GetPgmname( )
      {
         return "BR_Pathology_OtherDelete" ;
      }

      public override String GetPgmdesc( )
      {
         return "" ;
      }

      protected void WB740( )
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
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-md-6 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divUnnamedtablevtumorname_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-4 MergeLabelCell", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblockvtumorname_Internalname, "肿瘤标志物", "", "", lblTextblockvtumorname_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_BR_Pathology_OtherDelete.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-8", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavVtumorname_Internalname, "v Tumor Name", "col-sm-3 ReadonlyAttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 29,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavVtumorname_Internalname, AV12vTumorName, StringUtil.RTrim( context.localUtil.Format( AV12vTumorName, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,29);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavVtumorname_Jsonclick, 0, "ReadonlyAttribute", "", "", "", "", 1, edtavVtumorname_Enabled, 0, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_BR_Pathology_OtherDelete.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-md-6 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divUnnamedtablebr_pathology_other_br_pathology_other_bionum_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-4 MergeLabelCell", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblockbr_pathology_other_br_pathology_other_bionum_Internalname, "定量结果", "", "", lblTextblockbr_pathology_other_br_pathology_other_bionum_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_BR_Pathology_OtherDelete.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-8", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavBr_pathology_other_br_pathology_other_bionum_Internalname, "定量结果", "col-sm-3 ReadonlyAttributeLabel", 0, true);
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtavBr_pathology_other_br_pathology_other_bionum_Internalname, StringUtil.LTrim( StringUtil.NToC( AV10BR_Pathology_Other.gxTpr_Br_pathology_other_bionum, 15, 5, ".", "")), ((edtavBr_pathology_other_br_pathology_other_bionum_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( AV10BR_Pathology_Other.gxTpr_Br_pathology_other_bionum, "ZZZZZZZZZ.ZZZZZ")) : context.localUtil.Format( AV10BR_Pathology_Other.gxTpr_Br_pathology_other_bionum, "ZZZZZZZZZ.ZZZZZ")), "", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavBr_pathology_other_br_pathology_other_bionum_Jsonclick, 0, "ReadonlyAttribute", "", "", "", "", 1, edtavBr_pathology_other_br_pathology_other_bionum_Enabled, 0, "text", "", 15, "chr", 1, "row", 15, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_BR_Pathology_OtherDelete.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-md-6 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divUnnamedtablevbr_pathology_other_bionumunit_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-4 MergeLabelCell", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblockvbr_pathology_other_bionumunit_Internalname, "定量结果单位", "", "", lblTextblockvbr_pathology_other_bionumunit_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_BR_Pathology_OtherDelete.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-8", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavVbr_pathology_other_bionumunit_Internalname, "定量结果单位", "col-sm-3 ReadonlyAttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 46,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavVbr_pathology_other_bionumunit_Internalname, AV14vBR_Pathology_Other_BioNumUnit, StringUtil.RTrim( context.localUtil.Format( AV14vBR_Pathology_Other_BioNumUnit, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,46);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavVbr_pathology_other_bionumunit_Jsonclick, 0, "ReadonlyAttribute", "", "", "", "", 1, edtavVbr_pathology_other_bionumunit_Enabled, 0, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_BR_Pathology_OtherDelete.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-md-6 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divUnnamedtablebr_pathology_other_br_pathology_other_low_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-4 MergeLabelCell", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblockbr_pathology_other_br_pathology_other_low_Internalname, "参考上限", "", "", lblTextblockbr_pathology_other_br_pathology_other_low_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_BR_Pathology_OtherDelete.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-8", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavBr_pathology_other_br_pathology_other_low_Internalname, "参考上限", "col-sm-3 ReadonlyAttributeLabel", 0, true);
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtavBr_pathology_other_br_pathology_other_low_Internalname, StringUtil.LTrim( StringUtil.NToC( AV10BR_Pathology_Other.gxTpr_Br_pathology_other_low, 15, 5, ".", "")), ((edtavBr_pathology_other_br_pathology_other_low_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( AV10BR_Pathology_Other.gxTpr_Br_pathology_other_low, "ZZZZZZZZZ.ZZZZZ")) : context.localUtil.Format( AV10BR_Pathology_Other.gxTpr_Br_pathology_other_low, "ZZZZZZZZZ.ZZZZZ")), "", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavBr_pathology_other_br_pathology_other_low_Jsonclick, 0, "ReadonlyAttribute", "", "", "", "", 1, edtavBr_pathology_other_br_pathology_other_low_Enabled, 0, "text", "", 15, "chr", 1, "row", 15, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_BR_Pathology_OtherDelete.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-md-6 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divUnnamedtablebr_pathology_other_br_pathology_other_high_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-4 MergeLabelCell", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblockbr_pathology_other_br_pathology_other_high_Internalname, "参考下限", "", "", lblTextblockbr_pathology_other_br_pathology_other_high_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_BR_Pathology_OtherDelete.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-8", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavBr_pathology_other_br_pathology_other_high_Internalname, "参考下限", "col-sm-3 ReadonlyAttributeLabel", 0, true);
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtavBr_pathology_other_br_pathology_other_high_Internalname, StringUtil.LTrim( StringUtil.NToC( AV10BR_Pathology_Other.gxTpr_Br_pathology_other_high, 15, 5, ".", "")), ((edtavBr_pathology_other_br_pathology_other_high_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( AV10BR_Pathology_Other.gxTpr_Br_pathology_other_high, "ZZZZZZZZZ.ZZZZZ")) : context.localUtil.Format( AV10BR_Pathology_Other.gxTpr_Br_pathology_other_high, "ZZZZZZZZZ.ZZZZZ")), "", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavBr_pathology_other_br_pathology_other_high_Jsonclick, 0, "ReadonlyAttribute", "", "", "", "", 1, edtavBr_pathology_other_br_pathology_other_high_Enabled, 0, "text", "", 15, "chr", 1, "row", 15, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_BR_Pathology_OtherDelete.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-md-6 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divUnnamedtablebr_pathology_other_br_pathology_other_abnind_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-4 MergeLabelCell", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblockbr_pathology_other_br_pathology_other_abnind_Internalname, "结果提示", "", "", lblTextblockbr_pathology_other_br_pathology_other_abnind_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_BR_Pathology_OtherDelete.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-8", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavBr_pathology_other_br_pathology_other_abnind_Internalname, "结果提示", "col-sm-3 ReadonlyAttributeLabel", 0, true);
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtavBr_pathology_other_br_pathology_other_abnind_Internalname, AV10BR_Pathology_Other.gxTpr_Br_pathology_other_abnind, StringUtil.RTrim( context.localUtil.Format( AV10BR_Pathology_Other.gxTpr_Br_pathology_other_abnind, "")), "", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavBr_pathology_other_br_pathology_other_abnind_Jsonclick, 0, "ReadonlyAttribute", "", "", "", "", 1, edtavBr_pathology_other_br_pathology_other_abnind_Enabled, 0, "text", "", 40, "chr", 1, "row", 40, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_BR_Pathology_OtherDelete.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-md-6 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divUnnamedtablevbr_pathology_other_bioqual_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-4 MergeLabelCell", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblockvbr_pathology_other_bioqual_Internalname, "定性结果", "", "", lblTextblockvbr_pathology_other_bioqual_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_BR_Pathology_OtherDelete.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-8", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavVbr_pathology_other_bioqual_Internalname, "v BR_Pathology_Other_Bio Qual", "col-sm-3 ReadonlyAttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 80,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavVbr_pathology_other_bioqual_Internalname, AV13vBR_Pathology_Other_BioQual, StringUtil.RTrim( context.localUtil.Format( AV13vBR_Pathology_Other_BioQual, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,80);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavVbr_pathology_other_bioqual_Jsonclick, 0, "ReadonlyAttribute", "", "", "", "", 1, edtavVbr_pathology_other_bioqual_Enabled, 0, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_BR_Pathology_OtherDelete.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
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
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 85,'',false,'',0)\"";
            ClassString = "ButtonMaterial";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtnenter_Internalname, "", "确认", bttBtnenter_Jsonclick, 5, "确认", "", StyleString, ClassString, 1, 1, "standard", "'"+""+"'"+",false,"+"'"+"EENTER."+"'", TempTags, "", context.GetButtonType( ), "HLP_BR_Pathology_OtherDelete.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 87,'',false,'',0)\"";
            ClassString = "ButtonMaterialDefault";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtncancel_Internalname, "", "取消", bttBtncancel_Jsonclick, 1, "取消", "", StyleString, ClassString, 1, 1, "standard", "'"+""+"'"+",false,"+"'"+"ECANCEL."+"'", TempTags, "", context.GetButtonType( ), "HLP_BR_Pathology_OtherDelete.htm");
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
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 91,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavBr_pathology_other_br_pathology_otherid_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV10BR_Pathology_Other.gxTpr_Br_pathology_otherid), 18, 0, ".", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(AV10BR_Pathology_Other.gxTpr_Br_pathology_otherid), "ZZZZZZZZZZZZZZZZZZ")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,91);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavBr_pathology_other_br_pathology_otherid_Jsonclick, 0, "Attribute", "", "", "", "", edtavBr_pathology_other_br_pathology_otherid_Visible, 1, 0, "number", "1", 18, "chr", 1, "row", 18, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_BR_Pathology_OtherDelete.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 92,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavBr_pathology_other_br_pathologyid_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV10BR_Pathology_Other.gxTpr_Br_pathologyid), 18, 0, ".", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(AV10BR_Pathology_Other.gxTpr_Br_pathologyid), "ZZZZZZZZZZZZZZZZZZ")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,92);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavBr_pathology_other_br_pathologyid_Jsonclick, 0, "Attribute", "", "", "", "", edtavBr_pathology_other_br_pathologyid_Visible, 1, 0, "number", "1", 18, "chr", 1, "row", 18, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_BR_Pathology_OtherDelete.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
         }
         wbLoad = true;
      }

      protected void START742( )
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
         STRUP740( ) ;
      }

      protected void WS742( )
      {
         START742( ) ;
         EVT742( ) ;
      }

      protected void EVT742( )
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
                              E11742 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "REFRESH") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              /* Execute user event: Refresh */
                              E12742 ();
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
                                    E13742 ();
                                 }
                                 dynload_actions( ) ;
                              }
                           }
                           else if ( StringUtil.StrCmp(sEvt, "LOAD") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              /* Execute user event: Load */
                              E14742 ();
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

      protected void WE742( )
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

      protected void PA742( )
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
               GX_FocusControl = edtavVtumorname_Internalname;
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
         RF742( ) ;
         if ( isFullAjaxMode( ) )
         {
            send_integrity_footer_hashes( ) ;
         }
      }

      protected void initialize_formulas( )
      {
         /* GeneXus formulas. */
         context.Gx_err = 0;
         edtavVtumorname_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavVtumorname_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavVtumorname_Enabled), 5, 0)), true);
         edtavBr_pathology_other_br_pathology_other_bionum_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavBr_pathology_other_br_pathology_other_bionum_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavBr_pathology_other_br_pathology_other_bionum_Enabled), 5, 0)), true);
         edtavVbr_pathology_other_bionumunit_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavVbr_pathology_other_bionumunit_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavVbr_pathology_other_bionumunit_Enabled), 5, 0)), true);
         edtavBr_pathology_other_br_pathology_other_low_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavBr_pathology_other_br_pathology_other_low_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavBr_pathology_other_br_pathology_other_low_Enabled), 5, 0)), true);
         edtavBr_pathology_other_br_pathology_other_high_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavBr_pathology_other_br_pathology_other_high_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavBr_pathology_other_br_pathology_other_high_Enabled), 5, 0)), true);
         edtavBr_pathology_other_br_pathology_other_abnind_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavBr_pathology_other_br_pathology_other_abnind_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavBr_pathology_other_br_pathology_other_abnind_Enabled), 5, 0)), true);
         edtavVbr_pathology_other_bioqual_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavVbr_pathology_other_bioqual_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavVbr_pathology_other_bioqual_Enabled), 5, 0)), true);
      }

      protected void RF742( )
      {
         initialize_formulas( ) ;
         clear_multi_value_controls( ) ;
         /* Execute user event: Refresh */
         E12742 ();
         gxdyncontrolsrefreshing = true;
         fix_multi_value_controls( ) ;
         gxdyncontrolsrefreshing = false;
         if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
         {
            /* Execute user event: Load */
            E14742 ();
            WB740( ) ;
         }
      }

      protected void send_integrity_lvl_hashes742( )
      {
      }

      protected void STRUP740( )
      {
         /* Before Start, stand alone formulas. */
         context.Gx_err = 0;
         edtavVtumorname_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavVtumorname_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavVtumorname_Enabled), 5, 0)), true);
         edtavBr_pathology_other_br_pathology_other_bionum_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavBr_pathology_other_br_pathology_other_bionum_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavBr_pathology_other_br_pathology_other_bionum_Enabled), 5, 0)), true);
         edtavVbr_pathology_other_bionumunit_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavVbr_pathology_other_bionumunit_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavVbr_pathology_other_bionumunit_Enabled), 5, 0)), true);
         edtavBr_pathology_other_br_pathology_other_low_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavBr_pathology_other_br_pathology_other_low_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavBr_pathology_other_br_pathology_other_low_Enabled), 5, 0)), true);
         edtavBr_pathology_other_br_pathology_other_high_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavBr_pathology_other_br_pathology_other_high_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavBr_pathology_other_br_pathology_other_high_Enabled), 5, 0)), true);
         edtavBr_pathology_other_br_pathology_other_abnind_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavBr_pathology_other_br_pathology_other_abnind_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavBr_pathology_other_br_pathology_other_abnind_Enabled), 5, 0)), true);
         edtavVbr_pathology_other_bioqual_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavVbr_pathology_other_bioqual_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavVbr_pathology_other_bioqual_Enabled), 5, 0)), true);
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0;
         /* Execute user event: Start */
         E11742 ();
         context.wbGlbDoneStart = 1;
         /* After Start, stand alone formulas. */
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read saved SDTs. */
            ajax_req_read_hidden_sdt(cgiGet( "Br_pathology_other"), AV10BR_Pathology_Other);
            /* Read variables values. */
            AV12vTumorName = cgiGet( edtavVtumorname_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12vTumorName", AV12vTumorName);
            if ( ( ( context.localUtil.CToN( cgiGet( edtavBr_pathology_other_br_pathology_other_bionum_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavBr_pathology_other_br_pathology_other_bionum_Internalname), ".", ",") > 999999999.99999m ) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "BR_PATHOLOGY_OTHER_BR_PATHOLOGY_OTHER_BIONUM");
               GX_FocusControl = edtavBr_pathology_other_br_pathology_other_bionum_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV10BR_Pathology_Other.gxTpr_Br_pathology_other_bionum = 0;
            }
            else
            {
               AV10BR_Pathology_Other.gxTpr_Br_pathology_other_bionum = context.localUtil.CToN( cgiGet( edtavBr_pathology_other_br_pathology_other_bionum_Internalname), ".", ",");
            }
            AV14vBR_Pathology_Other_BioNumUnit = cgiGet( edtavVbr_pathology_other_bionumunit_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14vBR_Pathology_Other_BioNumUnit", AV14vBR_Pathology_Other_BioNumUnit);
            if ( ( ( context.localUtil.CToN( cgiGet( edtavBr_pathology_other_br_pathology_other_low_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavBr_pathology_other_br_pathology_other_low_Internalname), ".", ",") > 999999999.99999m ) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "BR_PATHOLOGY_OTHER_BR_PATHOLOGY_OTHER_LOW");
               GX_FocusControl = edtavBr_pathology_other_br_pathology_other_low_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV10BR_Pathology_Other.gxTpr_Br_pathology_other_low = 0;
            }
            else
            {
               AV10BR_Pathology_Other.gxTpr_Br_pathology_other_low = context.localUtil.CToN( cgiGet( edtavBr_pathology_other_br_pathology_other_low_Internalname), ".", ",");
            }
            if ( ( ( context.localUtil.CToN( cgiGet( edtavBr_pathology_other_br_pathology_other_high_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavBr_pathology_other_br_pathology_other_high_Internalname), ".", ",") > 999999999.99999m ) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "BR_PATHOLOGY_OTHER_BR_PATHOLOGY_OTHER_HIGH");
               GX_FocusControl = edtavBr_pathology_other_br_pathology_other_high_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV10BR_Pathology_Other.gxTpr_Br_pathology_other_high = 0;
            }
            else
            {
               AV10BR_Pathology_Other.gxTpr_Br_pathology_other_high = context.localUtil.CToN( cgiGet( edtavBr_pathology_other_br_pathology_other_high_Internalname), ".", ",");
            }
            AV10BR_Pathology_Other.gxTpr_Br_pathology_other_abnind = cgiGet( edtavBr_pathology_other_br_pathology_other_abnind_Internalname);
            AV13vBR_Pathology_Other_BioQual = cgiGet( edtavVbr_pathology_other_bioqual_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13vBR_Pathology_Other_BioQual", AV13vBR_Pathology_Other_BioQual);
            if ( ( ( context.localUtil.CToN( cgiGet( edtavBr_pathology_other_br_pathology_otherid_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavBr_pathology_other_br_pathology_otherid_Internalname), ".", ",") > Convert.ToDecimal( 999999999999999999L )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "BR_PATHOLOGY_OTHER_BR_PATHOLOGY_OTHERID");
               GX_FocusControl = edtavBr_pathology_other_br_pathology_otherid_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV10BR_Pathology_Other.gxTpr_Br_pathology_otherid = 0;
            }
            else
            {
               AV10BR_Pathology_Other.gxTpr_Br_pathology_otherid = (long)(context.localUtil.CToN( cgiGet( edtavBr_pathology_other_br_pathology_otherid_Internalname), ".", ","));
            }
            if ( ( ( context.localUtil.CToN( cgiGet( edtavBr_pathology_other_br_pathologyid_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavBr_pathology_other_br_pathologyid_Internalname), ".", ",") > Convert.ToDecimal( 999999999999999999L )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "BR_PATHOLOGY_OTHER_BR_PATHOLOGYID");
               GX_FocusControl = edtavBr_pathology_other_br_pathologyid_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV10BR_Pathology_Other.gxTpr_Br_pathologyid = 0;
            }
            else
            {
               AV10BR_Pathology_Other.gxTpr_Br_pathologyid = (long)(context.localUtil.CToN( cgiGet( edtavBr_pathology_other_br_pathologyid_Internalname), ".", ","));
            }
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
            forbiddenHiddens = "hsh" + "BR_Pathology_OtherDelete";
            AV10BR_Pathology_Other.gxTpr_Br_pathology_other_bionum = context.localUtil.CToN( cgiGet( edtavBr_pathology_other_br_pathology_other_bionum_Internalname), ".", ",");
            forbiddenHiddens = forbiddenHiddens + context.localUtil.Format( AV10BR_Pathology_Other.gxTpr_Br_pathology_other_bionum, "ZZZZZZZZZ.ZZZZZ");
            AV10BR_Pathology_Other.gxTpr_Br_pathology_other_low = context.localUtil.CToN( cgiGet( edtavBr_pathology_other_br_pathology_other_low_Internalname), ".", ",");
            forbiddenHiddens = forbiddenHiddens + context.localUtil.Format( AV10BR_Pathology_Other.gxTpr_Br_pathology_other_low, "ZZZZZZZZZ.ZZZZZ");
            AV10BR_Pathology_Other.gxTpr_Br_pathology_other_high = context.localUtil.CToN( cgiGet( edtavBr_pathology_other_br_pathology_other_high_Internalname), ".", ",");
            forbiddenHiddens = forbiddenHiddens + context.localUtil.Format( AV10BR_Pathology_Other.gxTpr_Br_pathology_other_high, "ZZZZZZZZZ.ZZZZZ");
            AV10BR_Pathology_Other.gxTpr_Br_pathology_other_abnind = cgiGet( edtavBr_pathology_other_br_pathology_other_abnind_Internalname);
            forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( AV10BR_Pathology_Other.gxTpr_Br_pathology_other_abnind, ""));
            hsh = cgiGet( "hsh");
            if ( ! GXUtil.CheckEncryptedHash( forbiddenHiddens, hsh, GXKey) )
            {
               GXUtil.WriteLog("br_pathology_otherdelete:[SecurityCheckFailed value for]"+"GXV1:"+context.localUtil.Format( AV10BR_Pathology_Other.gxTpr_Br_pathology_other_bionum, "ZZZZZZZZZ.ZZZZZ"));
               GXUtil.WriteLog("br_pathology_otherdelete:[SecurityCheckFailed value for]"+"GXV2:"+context.localUtil.Format( AV10BR_Pathology_Other.gxTpr_Br_pathology_other_low, "ZZZZZZZZZ.ZZZZZ"));
               GXUtil.WriteLog("br_pathology_otherdelete:[SecurityCheckFailed value for]"+"GXV3:"+context.localUtil.Format( AV10BR_Pathology_Other.gxTpr_Br_pathology_other_high, "ZZZZZZZZZ.ZZZZZ"));
               GXUtil.WriteLog("br_pathology_otherdelete:[SecurityCheckFailed value for]"+"GXV4:"+StringUtil.RTrim( context.localUtil.Format( AV10BR_Pathology_Other.gxTpr_Br_pathology_other_abnind, "")));
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
         E11742 ();
         if (returnInSub) return;
      }

      protected void E11742( )
      {
         /* Start Routine */
         edtavBr_pathology_other_br_pathology_otherid_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavBr_pathology_other_br_pathology_otherid_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavBr_pathology_other_br_pathology_otherid_Visible), 5, 0)), true);
         edtavBr_pathology_other_br_pathologyid_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavBr_pathology_other_br_pathologyid_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavBr_pathology_other_br_pathologyid_Visible), 5, 0)), true);
         AV10BR_Pathology_Other.Load(AV11iBR_Pathology_OtherID);
         AV12vTumorName = AV10BR_Pathology_Other.gxTpr_Br_pathology_other_bio;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12vTumorName", AV12vTumorName);
         AV13vBR_Pathology_Other_BioQual = AV10BR_Pathology_Other.gxTpr_Br_pathology_other_bioqual;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13vBR_Pathology_Other_BioQual", AV13vBR_Pathology_Other_BioQual);
         AV14vBR_Pathology_Other_BioNumUnit = AV10BR_Pathology_Other.gxTpr_Br_pathology_other_bionumunit;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14vBR_Pathology_Other_BioNumUnit", AV14vBR_Pathology_Other_BioNumUnit);
         GX_msglist.addItem("确认删除.");
      }

      protected void S112( )
      {
         /* 'SHOW MESSAGES' Routine */
         AV24GXV7 = 1;
         while ( AV24GXV7 <= AV8Messages.Count )
         {
            AV7Message = ((SdtMessages_Message)AV8Messages.Item(AV24GXV7));
            GX_msglist.addItem(AV7Message.gxTpr_Description);
            AV24GXV7 = (int)(AV24GXV7+1);
         }
      }

      protected void E12742( )
      {
         /* Refresh Routine */
         new GeneXus.Programs.wwpbaseobjects.loadwwpcontext(context ).execute( out  AV9Context) ;
      }

      public void GXEnter( )
      {
         /* Execute user event: Enter */
         E13742 ();
         if (returnInSub) return;
      }

      protected void E13742( )
      {
         /* Enter Routine */
         new zutil_checksession(context ).execute( out  AV15tCheckFlag) ;
         if ( ! AV15tCheckFlag )
         {
            AV10BR_Pathology_Other.Delete();
            context.CommitDataStores("br_pathology_otherdelete",pr_default);
            CallWebObject(formatLink("br_pathologyview.aspx") + "?" + UrlEncode("" +AV10BR_Pathology_Other.gxTpr_Br_pathologyid) + "," + UrlEncode(StringUtil.RTrim("BR_Pathology_Other")));
            context.wjLocDisableFrm = 1;
         }
      }

      protected void nextLoad( )
      {
      }

      protected void E14742( )
      {
         /* Load Routine */
      }

      public override void setparameters( Object[] obj )
      {
         createObjects();
         initialize();
         AV11iBR_Pathology_OtherID = Convert.ToInt64(getParm(obj,0));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11iBR_Pathology_OtherID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11iBR_Pathology_OtherID), 18, 0)));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vIBR_PATHOLOGY_OTHERID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV11iBR_Pathology_OtherID), "ZZZZZZZZZZZZZZZZZZ"), context));
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
         PA742( ) ;
         WS742( ) ;
         WE742( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?20202271253180", true);
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
         context.AddJavascriptSource("br_pathology_otherdelete.js", "?20202271253180", false);
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
         lblTextblockvtumorname_Internalname = "TEXTBLOCKVTUMORNAME";
         edtavVtumorname_Internalname = "vVTUMORNAME";
         divUnnamedtablevtumorname_Internalname = "UNNAMEDTABLEVTUMORNAME";
         lblTextblockbr_pathology_other_br_pathology_other_bionum_Internalname = "TEXTBLOCKBR_PATHOLOGY_OTHER_BR_PATHOLOGY_OTHER_BIONUM";
         edtavBr_pathology_other_br_pathology_other_bionum_Internalname = "BR_PATHOLOGY_OTHER_BR_PATHOLOGY_OTHER_BIONUM";
         divUnnamedtablebr_pathology_other_br_pathology_other_bionum_Internalname = "UNNAMEDTABLEBR_PATHOLOGY_OTHER_BR_PATHOLOGY_OTHER_BIONUM";
         lblTextblockvbr_pathology_other_bionumunit_Internalname = "TEXTBLOCKVBR_PATHOLOGY_OTHER_BIONUMUNIT";
         edtavVbr_pathology_other_bionumunit_Internalname = "vVBR_PATHOLOGY_OTHER_BIONUMUNIT";
         divUnnamedtablevbr_pathology_other_bionumunit_Internalname = "UNNAMEDTABLEVBR_PATHOLOGY_OTHER_BIONUMUNIT";
         lblTextblockbr_pathology_other_br_pathology_other_low_Internalname = "TEXTBLOCKBR_PATHOLOGY_OTHER_BR_PATHOLOGY_OTHER_LOW";
         edtavBr_pathology_other_br_pathology_other_low_Internalname = "BR_PATHOLOGY_OTHER_BR_PATHOLOGY_OTHER_LOW";
         divUnnamedtablebr_pathology_other_br_pathology_other_low_Internalname = "UNNAMEDTABLEBR_PATHOLOGY_OTHER_BR_PATHOLOGY_OTHER_LOW";
         lblTextblockbr_pathology_other_br_pathology_other_high_Internalname = "TEXTBLOCKBR_PATHOLOGY_OTHER_BR_PATHOLOGY_OTHER_HIGH";
         edtavBr_pathology_other_br_pathology_other_high_Internalname = "BR_PATHOLOGY_OTHER_BR_PATHOLOGY_OTHER_HIGH";
         divUnnamedtablebr_pathology_other_br_pathology_other_high_Internalname = "UNNAMEDTABLEBR_PATHOLOGY_OTHER_BR_PATHOLOGY_OTHER_HIGH";
         lblTextblockbr_pathology_other_br_pathology_other_abnind_Internalname = "TEXTBLOCKBR_PATHOLOGY_OTHER_BR_PATHOLOGY_OTHER_ABNIND";
         edtavBr_pathology_other_br_pathology_other_abnind_Internalname = "BR_PATHOLOGY_OTHER_BR_PATHOLOGY_OTHER_ABNIND";
         divUnnamedtablebr_pathology_other_br_pathology_other_abnind_Internalname = "UNNAMEDTABLEBR_PATHOLOGY_OTHER_BR_PATHOLOGY_OTHER_ABNIND";
         lblTextblockvbr_pathology_other_bioqual_Internalname = "TEXTBLOCKVBR_PATHOLOGY_OTHER_BIOQUAL";
         edtavVbr_pathology_other_bioqual_Internalname = "vVBR_PATHOLOGY_OTHER_BIOQUAL";
         divUnnamedtablevbr_pathology_other_bioqual_Internalname = "UNNAMEDTABLEVBR_PATHOLOGY_OTHER_BIOQUAL";
         divTableattributes_Internalname = "TABLEATTRIBUTES";
         divLayout_tableattributes_Internalname = "LAYOUT_TABLEATTRIBUTES";
         Dvpanel_tableattributes_Internalname = "DVPANEL_TABLEATTRIBUTES";
         divHtml_dvpanel_tableattributes_Internalname = "HTML_DVPANEL_TABLEATTRIBUTES";
         divTablecontent_Internalname = "TABLECONTENT";
         bttBtnenter_Internalname = "BTNENTER";
         bttBtncancel_Internalname = "BTNCANCEL";
         divTablemain_Internalname = "TABLEMAIN";
         edtavBr_pathology_other_br_pathology_otherid_Internalname = "BR_PATHOLOGY_OTHER_BR_PATHOLOGY_OTHERID";
         edtavBr_pathology_other_br_pathologyid_Internalname = "BR_PATHOLOGY_OTHER_BR_PATHOLOGYID";
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
         edtavBr_pathology_other_br_pathology_other_abnind_Enabled = -1;
         edtavBr_pathology_other_br_pathology_other_high_Enabled = -1;
         edtavBr_pathology_other_br_pathology_other_low_Enabled = -1;
         edtavBr_pathology_other_br_pathology_other_bionum_Enabled = -1;
         edtavBr_pathology_other_br_pathologyid_Jsonclick = "";
         edtavBr_pathology_other_br_pathologyid_Visible = 1;
         edtavBr_pathology_other_br_pathology_otherid_Jsonclick = "";
         edtavBr_pathology_other_br_pathology_otherid_Visible = 1;
         edtavVbr_pathology_other_bioqual_Jsonclick = "";
         edtavVbr_pathology_other_bioqual_Enabled = 1;
         edtavBr_pathology_other_br_pathology_other_abnind_Jsonclick = "";
         edtavBr_pathology_other_br_pathology_other_abnind_Enabled = 0;
         edtavBr_pathology_other_br_pathology_other_high_Jsonclick = "";
         edtavBr_pathology_other_br_pathology_other_high_Enabled = 0;
         edtavBr_pathology_other_br_pathology_other_low_Jsonclick = "";
         edtavBr_pathology_other_br_pathology_other_low_Enabled = 0;
         edtavVbr_pathology_other_bionumunit_Jsonclick = "";
         edtavVbr_pathology_other_bionumunit_Enabled = 1;
         edtavBr_pathology_other_br_pathology_other_bionum_Jsonclick = "";
         edtavBr_pathology_other_br_pathology_other_bionum_Enabled = 0;
         edtavVtumorname_Jsonclick = "";
         edtavVtumorname_Enabled = 1;
         Dvpanel_tableattributes_Autoscroll = Convert.ToBoolean( 0);
         Dvpanel_tableattributes_Iconposition = "left";
         Dvpanel_tableattributes_Showcollapseicon = Convert.ToBoolean( 0);
         Dvpanel_tableattributes_Autoheight = Convert.ToBoolean( -1);
         Dvpanel_tableattributes_Autowidth = Convert.ToBoolean( 0);
         Dvpanel_tableattributes_Collapsed = Convert.ToBoolean( 0);
         Dvpanel_tableattributes_Collapsible = Convert.ToBoolean( 0);
         Dvpanel_tableattributes_Title = "病理学其它信息";
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
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[{av:'AV11iBR_Pathology_OtherID',fld:'vIBR_PATHOLOGY_OTHERID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true},{av:'AV10BR_Pathology_Other.gxTpr_Br_pathology_other_bionum',fld:'BR_PATHOLOGY_OTHER_BR_PATHOLOGY_OTHER_BIONUM',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV10BR_Pathology_Other.gxTpr_Br_pathology_other_low',fld:'BR_PATHOLOGY_OTHER_BR_PATHOLOGY_OTHER_LOW',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV10BR_Pathology_Other.gxTpr_Br_pathology_other_high',fld:'BR_PATHOLOGY_OTHER_BR_PATHOLOGY_OTHER_HIGH',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV10BR_Pathology_Other.gxTpr_Br_pathology_other_abnind',fld:'BR_PATHOLOGY_OTHER_BR_PATHOLOGY_OTHER_ABNIND',pic:''}]");
         setEventMetadata("REFRESH",",oparms:[]}");
         setEventMetadata("ENTER","{handler:'E13742',iparms:[{av:'AV10BR_Pathology_Other',fld:'vBR_PATHOLOGY_OTHER',pic:''}]");
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
         AV10BR_Pathology_Other = new SdtBR_Pathology_Other(context);
         GX_FocusControl = "";
         Form = new GXWebForm();
         sPrefix = "";
         ClassString = "";
         StyleString = "";
         ucDvpanel_tableattributes = new GXUserControl();
         lblTextblockvtumorname_Jsonclick = "";
         TempTags = "";
         AV12vTumorName = "";
         lblTextblockbr_pathology_other_br_pathology_other_bionum_Jsonclick = "";
         lblTextblockvbr_pathology_other_bionumunit_Jsonclick = "";
         AV14vBR_Pathology_Other_BioNumUnit = "";
         lblTextblockbr_pathology_other_br_pathology_other_low_Jsonclick = "";
         lblTextblockbr_pathology_other_br_pathology_other_high_Jsonclick = "";
         lblTextblockbr_pathology_other_br_pathology_other_abnind_Jsonclick = "";
         lblTextblockvbr_pathology_other_bioqual_Jsonclick = "";
         AV13vBR_Pathology_Other_BioQual = "";
         bttBtnenter_Jsonclick = "";
         bttBtncancel_Jsonclick = "";
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         hsh = "";
         AV8Messages = new GXBaseCollection<SdtMessages_Message>( context, "Message", "GeneXus");
         AV7Message = new SdtMessages_Message(context);
         AV9Context = new GeneXus.Programs.wwpbaseobjects.SdtWWPContext(context);
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         pr_datastore1 = new DataStoreProvider(context, new GeneXus.Programs.br_pathology_otherdelete__datastore1(),
            new Object[][] {
            }
         );
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.br_pathology_otherdelete__default(),
            new Object[][] {
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0;
         edtavVtumorname_Enabled = 0;
         edtavBr_pathology_other_br_pathology_other_bionum_Enabled = 0;
         edtavVbr_pathology_other_bionumunit_Enabled = 0;
         edtavBr_pathology_other_br_pathology_other_low_Enabled = 0;
         edtavBr_pathology_other_br_pathology_other_high_Enabled = 0;
         edtavBr_pathology_other_br_pathology_other_abnind_Enabled = 0;
         edtavVbr_pathology_other_bioqual_Enabled = 0;
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
      private int edtavVtumorname_Enabled ;
      private int edtavBr_pathology_other_br_pathology_other_bionum_Enabled ;
      private int edtavVbr_pathology_other_bionumunit_Enabled ;
      private int edtavBr_pathology_other_br_pathology_other_low_Enabled ;
      private int edtavBr_pathology_other_br_pathology_other_high_Enabled ;
      private int edtavBr_pathology_other_br_pathology_other_abnind_Enabled ;
      private int edtavVbr_pathology_other_bioqual_Enabled ;
      private int edtavBr_pathology_other_br_pathology_otherid_Visible ;
      private int edtavBr_pathology_other_br_pathologyid_Visible ;
      private int AV24GXV7 ;
      private int idxLst ;
      private long AV11iBR_Pathology_OtherID ;
      private long wcpOAV11iBR_Pathology_OtherID ;
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
      private String divUnnamedtablevtumorname_Internalname ;
      private String lblTextblockvtumorname_Internalname ;
      private String lblTextblockvtumorname_Jsonclick ;
      private String edtavVtumorname_Internalname ;
      private String TempTags ;
      private String edtavVtumorname_Jsonclick ;
      private String divUnnamedtablebr_pathology_other_br_pathology_other_bionum_Internalname ;
      private String lblTextblockbr_pathology_other_br_pathology_other_bionum_Internalname ;
      private String lblTextblockbr_pathology_other_br_pathology_other_bionum_Jsonclick ;
      private String edtavBr_pathology_other_br_pathology_other_bionum_Internalname ;
      private String edtavBr_pathology_other_br_pathology_other_bionum_Jsonclick ;
      private String divUnnamedtablevbr_pathology_other_bionumunit_Internalname ;
      private String lblTextblockvbr_pathology_other_bionumunit_Internalname ;
      private String lblTextblockvbr_pathology_other_bionumunit_Jsonclick ;
      private String edtavVbr_pathology_other_bionumunit_Internalname ;
      private String edtavVbr_pathology_other_bionumunit_Jsonclick ;
      private String divUnnamedtablebr_pathology_other_br_pathology_other_low_Internalname ;
      private String lblTextblockbr_pathology_other_br_pathology_other_low_Internalname ;
      private String lblTextblockbr_pathology_other_br_pathology_other_low_Jsonclick ;
      private String edtavBr_pathology_other_br_pathology_other_low_Internalname ;
      private String edtavBr_pathology_other_br_pathology_other_low_Jsonclick ;
      private String divUnnamedtablebr_pathology_other_br_pathology_other_high_Internalname ;
      private String lblTextblockbr_pathology_other_br_pathology_other_high_Internalname ;
      private String lblTextblockbr_pathology_other_br_pathology_other_high_Jsonclick ;
      private String edtavBr_pathology_other_br_pathology_other_high_Internalname ;
      private String edtavBr_pathology_other_br_pathology_other_high_Jsonclick ;
      private String divUnnamedtablebr_pathology_other_br_pathology_other_abnind_Internalname ;
      private String lblTextblockbr_pathology_other_br_pathology_other_abnind_Internalname ;
      private String lblTextblockbr_pathology_other_br_pathology_other_abnind_Jsonclick ;
      private String edtavBr_pathology_other_br_pathology_other_abnind_Internalname ;
      private String edtavBr_pathology_other_br_pathology_other_abnind_Jsonclick ;
      private String divUnnamedtablevbr_pathology_other_bioqual_Internalname ;
      private String lblTextblockvbr_pathology_other_bioqual_Internalname ;
      private String lblTextblockvbr_pathology_other_bioqual_Jsonclick ;
      private String edtavVbr_pathology_other_bioqual_Internalname ;
      private String edtavVbr_pathology_other_bioqual_Jsonclick ;
      private String bttBtnenter_Internalname ;
      private String bttBtnenter_Jsonclick ;
      private String bttBtncancel_Internalname ;
      private String bttBtncancel_Jsonclick ;
      private String divHtml_bottomauxiliarcontrols_Internalname ;
      private String edtavBr_pathology_other_br_pathology_otherid_Internalname ;
      private String edtavBr_pathology_other_br_pathology_otherid_Jsonclick ;
      private String edtavBr_pathology_other_br_pathologyid_Internalname ;
      private String edtavBr_pathology_other_br_pathologyid_Jsonclick ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String hsh ;
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
      private bool AV15tCheckFlag ;
      private String AV12vTumorName ;
      private String AV14vBR_Pathology_Other_BioNumUnit ;
      private String AV13vBR_Pathology_Other_BioQual ;
      private GXUserControl ucDvpanel_tableattributes ;
      private IGxDataStore dsDataStore1 ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private IDataStoreProvider pr_datastore1 ;
      private GXBaseCollection<SdtMessages_Message> AV8Messages ;
      private GXWebForm Form ;
      private SdtMessages_Message AV7Message ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPContext AV9Context ;
      private SdtBR_Pathology_Other AV10BR_Pathology_Other ;
   }

   public class br_pathology_otherdelete__datastore1 : DataStoreHelperBase, IDataStoreHelper
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

 public class br_pathology_otherdelete__default : DataStoreHelperBase, IDataStoreHelper
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
