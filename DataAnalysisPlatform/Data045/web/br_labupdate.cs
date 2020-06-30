/*
               File: BR_LabUpdate
        Description:
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/28/2020 15:14:35.66
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
   public class br_labupdate : GXDataArea, System.Web.SessionState.IRequiresSessionState
   {
      public br_labupdate( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public br_labupdate( IGxContext context )
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
         this.AV14iBR_LabID = aP0_iBR_LabID;
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
               AV20tCurrentCode = GetNextPar( );
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1;
                  return  ;
               }
               GXDLVvVSOURCE5U2( AV20tCurrentCode) ;
               return  ;
            }
            else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxCallCrl"+"_"+"BR_LAB_BR_LAB_RESULTQUAL") == 0 )
            {
               AV20tCurrentCode = GetNextPar( );
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1;
                  return  ;
               }
               GXDLVBR_LAB_BR_LAB_RESULTQUAL5U2( AV20tCurrentCode) ;
               return  ;
            }
            else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxCallCrl"+"_"+"BR_LAB_BR_LAB_ABNIND") == 0 )
            {
               AV20tCurrentCode = GetNextPar( );
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1;
                  return  ;
               }
               GXDLVBR_LAB_BR_LAB_ABNIND5U2( AV20tCurrentCode) ;
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
               AV14iBR_LabID = (long)(NumberUtil.Val( gxfirstwebparm, "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14iBR_LabID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV14iBR_LabID), 18, 0)));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vIBR_LABID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV14iBR_LabID), "ZZZZZZZZZZZZZZZZZZ"), context));
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
         PA5U2( ) ;
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0));
         if ( ( gxajaxcallmode == 0 ) && ( GxWebError == 0 ) )
         {
            START5U2( ) ;
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
         context.AddJavascriptSource("gxcfg.js", "?202022815143575", false);
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" autocomplete=\"off\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("br_labupdate.aspx") + "?" + UrlEncode("" +AV14iBR_LabID)+"\">") ;
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
         GxWebStd.gx_hidden_field( context, "vIBR_LABID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV14iBR_LabID), 18, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "gxhash_vIBR_LABID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV14iBR_LabID), "ZZZZZZZZZZZZZZZZZZ"), context));
         GxWebStd.gx_hidden_field( context, "vTCURRENTCODE", AV20tCurrentCode);
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
            WE5U2( ) ;
            context.WriteHtmlText( "</div>") ;
         }
      }

      public override void DispatchEvents( )
      {
         EVT5U2( ) ;
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
         return formatLink("br_labupdate.aspx") + "?" + UrlEncode("" +AV14iBR_LabID) ;
      }

      public override String GetPgmname( )
      {
         return "BR_LabUpdate" ;
      }

      public override String GetPgmdesc( )
      {
         return "" ;
      }

      protected void WB5U0( )
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
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 RequiredDataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtavBr_lab_br_lab_testname_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavBr_lab_br_lab_testname_Internalname, "项目名称", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 25,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavBr_lab_br_lab_testname_Internalname, AV10BR_Lab.gxTpr_Br_lab_testname, StringUtil.RTrim( context.localUtil.Format( AV10BR_Lab.gxTpr_Br_lab_testname, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,25);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavBr_lab_br_lab_testname_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtavBr_lab_br_lab_testname_Enabled, 0, "text", "", 40, "chr", 1, "row", 40, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_BR_LabUpdate.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtavBr_lab_br_lab_testengname_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavBr_lab_br_lab_testengname_Internalname, "项目英文名称", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 29,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavBr_lab_br_lab_testengname_Internalname, AV10BR_Lab.gxTpr_Br_lab_testengname, StringUtil.RTrim( context.localUtil.Format( AV10BR_Lab.gxTpr_Br_lab_testengname, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,29);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavBr_lab_br_lab_testengname_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtavBr_lab_br_lab_testengname_Enabled, 0, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_BR_LabUpdate.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtavBr_lab_br_lab_testcode_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavBr_lab_br_lab_testcode_Internalname, "检查项目编码", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 34,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavBr_lab_br_lab_testcode_Internalname, AV10BR_Lab.gxTpr_Br_lab_testcode, StringUtil.RTrim( context.localUtil.Format( AV10BR_Lab.gxTpr_Br_lab_testcode, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,34);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavBr_lab_br_lab_testcode_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtavBr_lab_br_lab_testcode_Enabled, 0, "text", "", 40, "chr", 1, "row", 40, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_BR_LabUpdate.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtavBr_lab_br_lab_age_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavBr_lab_br_lab_age_Internalname, "年龄", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 38,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavBr_lab_br_lab_age_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV10BR_Lab.gxTpr_Br_lab_age), 3, 0, ".", "")), ((edtavBr_lab_br_lab_age_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(AV10BR_Lab.gxTpr_Br_lab_age), "ZZZ")) : context.localUtil.Format( (decimal)(AV10BR_Lab.gxTpr_Br_lab_age), "ZZZ")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,38);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavBr_lab_br_lab_age_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtavBr_lab_br_lab_age_Enabled, 0, "number", "1", 3, "chr", 1, "row", 3, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_BR_LabUpdate.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtavBr_lab_br_lab_diag_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavBr_lab_br_lab_diag_Internalname, "临床诊断", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 43,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavBr_lab_br_lab_diag_Internalname, AV10BR_Lab.gxTpr_Br_lab_diag, StringUtil.RTrim( context.localUtil.Format( AV10BR_Lab.gxTpr_Br_lab_diag, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,43);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavBr_lab_br_lab_diag_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtavBr_lab_br_lab_diag_Enabled, 0, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_BR_LabUpdate.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divTablesplittedvsource_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-3 MergeLabelCell", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblockvsource_Internalname, "标本种类", "", "", lblTextblockvsource_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_BR_LabUpdate.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-9", "left", "top", "", "", "div");
            wb_table1_50_5U2( true) ;
         }
         else
         {
            wb_table1_50_5U2( false) ;
         }
         return  ;
      }

      protected void wb_table1_50_5U2e( bool wbgen )
      {
         if ( wbgen )
         {
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 RequiredDataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtavVspecimendate_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavVspecimendate_Internalname, "采样时间", "col-sm-3 AttributeDateTimeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 62,'',false,'',0)\"";
            context.WriteHtmlText( "<div id=\""+edtavVspecimendate_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtavVspecimendate_Internalname, context.localUtil.TToC( AV17vSpecimenDate, 10, 8, 0, 0, "/", ":", " "), context.localUtil.Format( AV17vSpecimenDate, "9999/99/99 99:99:99"), TempTags+" onchange=\""+"gx.date.valid_date(this, 10,'YMD',8,24,'chs',false,1);"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,62);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavVspecimendate_Jsonclick, 0, "AttributeDateTime", "", "", "", "", 1, edtavVspecimendate_Enabled, 0, "text", "", 19, "chr", 1, "row", 19, 0, 0, 0, 1, -1, 0, true, "DM_DataTime", "right", false, "HLP_BR_LabUpdate.htm");
            GxWebStd.gx_bitmap( context, edtavVspecimendate_Internalname+"_dp_trigger", context.GetImagePath( "61b9b5d3-dff6-4d59-9b00-da61bc2cbe93", "", context.GetTheme( )), "", "", "", "", ((1==0)||(edtavVspecimendate_Enabled==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;", "", "", "", "", "", "", "", "", 1, false, false, "", "HLP_BR_LabUpdate.htm");
            context.WriteHtmlTextNl( "</div>") ;
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtavVreceivingtime_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavVreceivingtime_Internalname, "接收时间", "col-sm-3 AttributeDateTimeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 66,'',false,'',0)\"";
            context.WriteHtmlText( "<div id=\""+edtavVreceivingtime_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtavVreceivingtime_Internalname, context.localUtil.TToC( AV18vReceivingTime, 10, 8, 0, 0, "/", ":", " "), context.localUtil.Format( AV18vReceivingTime, "9999/99/99 99:99:99"), TempTags+" onchange=\""+"gx.date.valid_date(this, 10,'YMD',8,24,'chs',false,1);"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,66);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavVreceivingtime_Jsonclick, 0, "AttributeDateTime", "", "", "", "", 1, edtavVreceivingtime_Enabled, 0, "text", "", 19, "chr", 1, "row", 19, 0, 0, 0, 1, -1, 0, true, "DM_DataTime", "right", false, "HLP_BR_LabUpdate.htm");
            GxWebStd.gx_bitmap( context, edtavVreceivingtime_Internalname+"_dp_trigger", context.GetImagePath( "61b9b5d3-dff6-4d59-9b00-da61bc2cbe93", "", context.GetTheme( )), "", "", "", "", ((1==0)||(edtavVreceivingtime_Enabled==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;", "", "", "", "", "", "", "", "", 1, false, false, "", "HLP_BR_LabUpdate.htm");
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
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtavVreporttime_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavVreporttime_Internalname, "报告时间", "col-sm-3 AttributeDateTimeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 71,'',false,'',0)\"";
            context.WriteHtmlText( "<div id=\""+edtavVreporttime_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtavVreporttime_Internalname, context.localUtil.TToC( AV19vReportTime, 10, 8, 0, 0, "/", ":", " "), context.localUtil.Format( AV19vReportTime, "9999/99/99 99:99:99"), TempTags+" onchange=\""+"gx.date.valid_date(this, 10,'YMD',8,24,'chs',false,1);"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,71);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavVreporttime_Jsonclick, 0, "AttributeDateTime", "", "", "", "", 1, edtavVreporttime_Enabled, 0, "text", "", 19, "chr", 1, "row", 19, 0, 0, 0, 1, -1, 0, true, "DM_DataTime", "right", false, "HLP_BR_LabUpdate.htm");
            GxWebStd.gx_bitmap( context, edtavVreporttime_Internalname+"_dp_trigger", context.GetImagePath( "61b9b5d3-dff6-4d59-9b00-da61bc2cbe93", "", context.GetTheme( )), "", "", "", "", ((1==0)||(edtavVreporttime_Enabled==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;", "", "", "", "", "", "", "", "", 1, false, false, "", "HLP_BR_LabUpdate.htm");
            context.WriteHtmlTextNl( "</div>") ;
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+dynavBr_lab_br_lab_resultqual_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, dynavBr_lab_br_lab_resultqual_Internalname, "定性结果", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 75,'',false,'',0)\"";
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, dynavBr_lab_br_lab_resultqual, dynavBr_lab_br_lab_resultqual_Internalname, StringUtil.RTrim( AV10BR_Lab.gxTpr_Br_lab_resultqual), 1, dynavBr_lab_br_lab_resultqual_Jsonclick, 0, "'"+""+"'"+",false,"+"'"+""+"'", "svchar", "", 1, dynavBr_lab_br_lab_resultqual.Enabled, 0, 0, 0, "em", 0, "", "", "Attribute", "", "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,75);\"", "", true, "HLP_BR_LabUpdate.htm");
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
            GxWebStd.gx_label_element( context, edtavBr_lab_br_lab_resultunit_Internalname, "结果单位", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 80,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavBr_lab_br_lab_resultunit_Internalname, AV10BR_Lab.gxTpr_Br_lab_resultunit, StringUtil.RTrim( context.localUtil.Format( AV10BR_Lab.gxTpr_Br_lab_resultunit, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,80);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavBr_lab_br_lab_resultunit_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtavBr_lab_br_lab_resultunit_Enabled, 0, "text", "", 40, "chr", 1, "row", 40, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_BR_LabUpdate.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+dynavBr_lab_br_lab_abnind_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, dynavBr_lab_br_lab_abnind_Internalname, "结果提示", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 84,'',false,'',0)\"";
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, dynavBr_lab_br_lab_abnind, dynavBr_lab_br_lab_abnind_Internalname, StringUtil.RTrim( AV10BR_Lab.gxTpr_Br_lab_abnind), 1, dynavBr_lab_br_lab_abnind_Jsonclick, 0, "'"+""+"'"+",false,"+"'"+""+"'", "svchar", "", 1, dynavBr_lab_br_lab_abnind.Enabled, 0, 0, 0, "em", 0, "", "", "Attribute", "", "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,84);\"", "", true, "HLP_BR_LabUpdate.htm");
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
            GxWebStd.gx_label_element( context, edtavBr_lab_br_lab_normrangelow_Internalname, "参考值范围", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 89,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavBr_lab_br_lab_normrangelow_Internalname, AV10BR_Lab.gxTpr_Br_lab_normrangelow, StringUtil.RTrim( context.localUtil.Format( AV10BR_Lab.gxTpr_Br_lab_normrangelow, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,89);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavBr_lab_br_lab_normrangelow_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtavBr_lab_br_lab_normrangelow_Enabled, 0, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_BR_LabUpdate.htm");
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
            GxWebStd.gx_label_element( context, edtavBr_lab_br_lab_testmethod_Internalname, "检测方法", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 94,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavBr_lab_br_lab_testmethod_Internalname, AV10BR_Lab.gxTpr_Br_lab_testmethod, StringUtil.RTrim( context.localUtil.Format( AV10BR_Lab.gxTpr_Br_lab_testmethod, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,94);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavBr_lab_br_lab_testmethod_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtavBr_lab_br_lab_testmethod_Enabled, 0, "text", "", 40, "chr", 1, "row", 40, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_BR_LabUpdate.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtavBr_lab_br_lab_instrumentcode_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavBr_lab_br_lab_instrumentcode_Internalname, "设备编码", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 98,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavBr_lab_br_lab_instrumentcode_Internalname, AV10BR_Lab.gxTpr_Br_lab_instrumentcode, StringUtil.RTrim( context.localUtil.Format( AV10BR_Lab.gxTpr_Br_lab_instrumentcode, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,98);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavBr_lab_br_lab_instrumentcode_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtavBr_lab_br_lab_instrumentcode_Enabled, 0, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_BR_LabUpdate.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtavBr_lab_br_lab_instrumentname_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavBr_lab_br_lab_instrumentname_Internalname, "设备名称", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 103,'',false,'',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavBr_lab_br_lab_instrumentname_Internalname, AV10BR_Lab.gxTpr_Br_lab_instrumentname, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,103);\"", 0, 1, edtavBr_lab_br_lab_instrumentname_Enabled, 0, 80, "chr", 3, "row", StyleString, ClassString, "", "", "200", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_LabUpdate.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtavBr_lab_br_lab_resultnum_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavBr_lab_br_lab_resultnum_Internalname, "定量结果", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 107,'',false,'',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavBr_lab_br_lab_resultnum_Internalname, AV10BR_Lab.gxTpr_Br_lab_resultnum, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,107);\"", 0, 1, edtavBr_lab_br_lab_resultnum_Enabled, 0, 80, "chr", 7, "row", StyleString, ClassString, "", "", "500", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_LabUpdate.htm");
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
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 112,'',false,'',0)\"";
            ClassString = "ButtonMaterial";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtnenter_Internalname, "", "保存", bttBtnenter_Jsonclick, 5, "确认", "", StyleString, ClassString, 1, 1, "standard", "'"+""+"'"+",false,"+"'"+"EENTER."+"'", TempTags, "", context.GetButtonType( ), "HLP_BR_LabUpdate.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 114,'',false,'',0)\"";
            ClassString = "ButtonMaterialDefault";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtncancel_Internalname, "", "取消", bttBtncancel_Jsonclick, 1, "取消", "", StyleString, ClassString, 1, 1, "standard", "'"+""+"'"+",false,"+"'"+"ECANCEL."+"'", TempTags, "", context.GetButtonType( ), "HLP_BR_LabUpdate.htm");
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
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 118,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavBr_lab_br_labid_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV10BR_Lab.gxTpr_Br_labid), 18, 0, ".", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(AV10BR_Lab.gxTpr_Br_labid), "ZZZZZZZZZZZZZZZZZZ")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,118);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavBr_lab_br_labid_Jsonclick, 0, "Attribute", "", "", "", "", edtavBr_lab_br_labid_Visible, 1, 0, "number", "1", 18, "chr", 1, "row", 18, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_BR_LabUpdate.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 119,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavBr_lab_br_encounterid_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV10BR_Lab.gxTpr_Br_encounterid), 18, 0, ".", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(AV10BR_Lab.gxTpr_Br_encounterid), "ZZZZZZZZZZZZZZZZZZ")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,119);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavBr_lab_br_encounterid_Jsonclick, 0, "Attribute", "", "", "", "", edtavBr_lab_br_encounterid_Visible, 1, 0, "number", "1", 18, "chr", 1, "row", 18, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_BR_LabUpdate.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 120,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavBr_lab_br_information_patientno_Internalname, AV10BR_Lab.gxTpr_Br_information_patientno, StringUtil.RTrim( context.localUtil.Format( AV10BR_Lab.gxTpr_Br_information_patientno, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,120);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavBr_lab_br_information_patientno_Jsonclick, 0, "Attribute", "", "", "", "", edtavBr_lab_br_information_patientno_Visible, 1, 0, "text", "", 80, "chr", 1, "row", 2000, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_BR_LabUpdate.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 121,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavBr_lab_br_lab_sampleid_Internalname, AV10BR_Lab.gxTpr_Br_lab_sampleid, StringUtil.RTrim( context.localUtil.Format( AV10BR_Lab.gxTpr_Br_lab_sampleid, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,121);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavBr_lab_br_lab_sampleid_Jsonclick, 0, "Attribute", "", "", "", "", edtavBr_lab_br_lab_sampleid_Visible, 1, 0, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_BR_LabUpdate.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 122,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavBr_lab_br_lab_testid_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV10BR_Lab.gxTpr_Br_lab_testid), 10, 0, ".", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(AV10BR_Lab.gxTpr_Br_lab_testid), "ZZZZZZZZZZ")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,122);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavBr_lab_br_lab_testid_Jsonclick, 0, "Attribute", "", "", "", "", edtavBr_lab_br_lab_testid_Visible, 1, 0, "number", "1", 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_BR_LabUpdate.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 123,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavBr_lab_br_lab_normrangehigh_Internalname, AV10BR_Lab.gxTpr_Br_lab_normrangehigh, StringUtil.RTrim( context.localUtil.Format( AV10BR_Lab.gxTpr_Br_lab_normrangehigh, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,123);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavBr_lab_br_lab_normrangehigh_Jsonclick, 0, "Attribute", "", "", "", "", edtavBr_lab_br_lab_normrangehigh_Visible, 1, 0, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_BR_LabUpdate.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
         }
         wbLoad = true;
      }

      protected void START5U2( )
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
         STRUP5U0( ) ;
      }

      protected void WS5U2( )
      {
         START5U2( ) ;
         EVT5U2( ) ;
      }

      protected void EVT5U2( )
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
                              E115U2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "REFRESH") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              /* Execute user event: Refresh */
                              E125U2 ();
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
                                    E135U2 ();
                                 }
                                 dynload_actions( ) ;
                              }
                           }
                           else if ( StringUtil.StrCmp(sEvt, "LOAD") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              /* Execute user event: Load */
                              E145U2 ();
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

      protected void WE5U2( )
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

      protected void PA5U2( )
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

      protected void GXDLVvVSOURCE5U2( String AV20tCurrentCode )
      {
         if ( ! context.isAjaxRequest( ) )
         {
            context.GX_webresponse.AppendHeader("Cache-Control", "no-store");
         }
         context.GX_webresponse.AddString("[[");
         GXDLVvVSOURCE_data5U2( AV20tCurrentCode) ;
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

      protected void GXVvVSOURCE_html5U2( String AV20tCurrentCode )
      {
         String gxdynajaxvalue ;
         GXDLVvVSOURCE_data5U2( AV20tCurrentCode) ;
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

      protected void GXDLVvVSOURCE_data5U2( String AV20tCurrentCode )
      {
         gxdynajaxctrlcodr.Clear();
         gxdynajaxctrldescr.Clear();
         gxdynajaxctrlcodr.Add("");
         gxdynajaxctrldescr.Add("(请选择)");
         /* Using cursor H005U2 */
         pr_default.execute(0, new Object[] {AV20tCurrentCode});
         while ( (pr_default.getStatus(0) != 101) )
         {
            gxdynajaxctrlcodr.Add(H005U2_A168XT_DefineCodeName[0]);
            gxdynajaxctrldescr.Add(H005U2_A168XT_DefineCodeName[0]);
            pr_default.readNext(0);
         }
         pr_default.close(0);
      }

      protected void GXDLVBR_LAB_BR_LAB_RESULTQUAL5U2( String AV20tCurrentCode )
      {
         if ( ! context.isAjaxRequest( ) )
         {
            context.GX_webresponse.AppendHeader("Cache-Control", "no-store");
         }
         context.GX_webresponse.AddString("[[");
         GXDLVBR_LAB_BR_LAB_RESULTQUAL_data5U2( AV20tCurrentCode) ;
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

      protected void GXVBR_LAB_BR_LAB_RESULTQUAL_html5U2( String AV20tCurrentCode )
      {
         String gxdynajaxvalue ;
         GXDLVBR_LAB_BR_LAB_RESULTQUAL_data5U2( AV20tCurrentCode) ;
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

      protected void GXDLVBR_LAB_BR_LAB_RESULTQUAL_data5U2( String AV20tCurrentCode )
      {
         gxdynajaxctrlcodr.Clear();
         gxdynajaxctrldescr.Clear();
         gxdynajaxctrlcodr.Add("");
         gxdynajaxctrldescr.Add("(请选择)");
         /* Using cursor H005U3 */
         pr_default.execute(1, new Object[] {AV20tCurrentCode});
         while ( (pr_default.getStatus(1) != 101) )
         {
            gxdynajaxctrlcodr.Add(H005U3_A168XT_DefineCodeName[0]);
            gxdynajaxctrldescr.Add(H005U3_A168XT_DefineCodeName[0]);
            pr_default.readNext(1);
         }
         pr_default.close(1);
      }

      protected void GXDLVBR_LAB_BR_LAB_ABNIND5U2( String AV20tCurrentCode )
      {
         if ( ! context.isAjaxRequest( ) )
         {
            context.GX_webresponse.AppendHeader("Cache-Control", "no-store");
         }
         context.GX_webresponse.AddString("[[");
         GXDLVBR_LAB_BR_LAB_ABNIND_data5U2( AV20tCurrentCode) ;
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

      protected void GXVBR_LAB_BR_LAB_ABNIND_html5U2( String AV20tCurrentCode )
      {
         String gxdynajaxvalue ;
         GXDLVBR_LAB_BR_LAB_ABNIND_data5U2( AV20tCurrentCode) ;
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

      protected void GXDLVBR_LAB_BR_LAB_ABNIND_data5U2( String AV20tCurrentCode )
      {
         gxdynajaxctrlcodr.Clear();
         gxdynajaxctrldescr.Clear();
         gxdynajaxctrlcodr.Add("");
         gxdynajaxctrldescr.Add("(请选择)");
         /* Using cursor H005U4 */
         pr_default.execute(2, new Object[] {AV20tCurrentCode});
         while ( (pr_default.getStatus(2) != 101) )
         {
            gxdynajaxctrlcodr.Add(H005U4_A168XT_DefineCodeName[0]);
            gxdynajaxctrldescr.Add(H005U4_A168XT_DefineCodeName[0]);
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
         RF5U2( ) ;
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

      protected void RF5U2( )
      {
         initialize_formulas( ) ;
         clear_multi_value_controls( ) ;
         /* Execute user event: Refresh */
         E125U2 ();
         gxdyncontrolsrefreshing = true;
         fix_multi_value_controls( ) ;
         gxdyncontrolsrefreshing = false;
         if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
         {
            /* Execute user event: Load */
            E145U2 ();
            WB5U0( ) ;
         }
      }

      protected void send_integrity_lvl_hashes5U2( )
      {
      }

      protected void STRUP5U0( )
      {
         /* Before Start, stand alone formulas. */
         context.Gx_err = 0;
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0;
         /* Execute user event: Start */
         E115U2 ();
         context.wbGlbDoneStart = 1;
         /* After Start, stand alone formulas. */
         GXVvVSOURCE_html5U2( AV20tCurrentCode) ;
         GXVBR_LAB_BR_LAB_RESULTQUAL_html5U2( AV20tCurrentCode) ;
         GXVBR_LAB_BR_LAB_ABNIND_html5U2( AV20tCurrentCode) ;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read saved SDTs. */
            ajax_req_read_hidden_sdt(cgiGet( "Br_lab"), AV10BR_Lab);
            /* Read variables values. */
            AV10BR_Lab.gxTpr_Br_lab_testname = cgiGet( edtavBr_lab_br_lab_testname_Internalname);
            AV10BR_Lab.gxTpr_Br_lab_testengname = cgiGet( edtavBr_lab_br_lab_testengname_Internalname);
            AV10BR_Lab.gxTpr_Br_lab_testcode = cgiGet( edtavBr_lab_br_lab_testcode_Internalname);
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
            AV12vOtherSource = cgiGet( edtavVothersource_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12vOtherSource", AV12vOtherSource);
            if ( context.localUtil.VCDateTime( cgiGet( edtavVspecimendate_Internalname), 0, 0) == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_baddatetime", new   object[]  {"v Specimen Date"}), 1, "vVSPECIMENDATE");
               GX_FocusControl = edtavVspecimendate_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV17vSpecimenDate = (DateTime)(DateTime.MinValue);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV17vSpecimenDate", context.localUtil.TToC( AV17vSpecimenDate, 10, 8, 0, 0, "/", ":", " "));
            }
            else
            {
               AV17vSpecimenDate = context.localUtil.CToT( cgiGet( edtavVspecimendate_Internalname));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV17vSpecimenDate", context.localUtil.TToC( AV17vSpecimenDate, 10, 8, 0, 0, "/", ":", " "));
            }
            if ( context.localUtil.VCDateTime( cgiGet( edtavVreceivingtime_Internalname), 0, 0) == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_baddatetime", new   object[]  {"v Receiving Time"}), 1, "vVRECEIVINGTIME");
               GX_FocusControl = edtavVreceivingtime_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV18vReceivingTime = (DateTime)(DateTime.MinValue);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV18vReceivingTime", context.localUtil.TToC( AV18vReceivingTime, 10, 8, 0, 0, "/", ":", " "));
            }
            else
            {
               AV18vReceivingTime = context.localUtil.CToT( cgiGet( edtavVreceivingtime_Internalname));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV18vReceivingTime", context.localUtil.TToC( AV18vReceivingTime, 10, 8, 0, 0, "/", ":", " "));
            }
            if ( context.localUtil.VCDateTime( cgiGet( edtavVreporttime_Internalname), 0, 0) == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_baddatetime", new   object[]  {"v Report Time"}), 1, "vVREPORTTIME");
               GX_FocusControl = edtavVreporttime_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV19vReportTime = (DateTime)(DateTime.MinValue);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV19vReportTime", context.localUtil.TToC( AV19vReportTime, 10, 8, 0, 0, "/", ":", " "));
            }
            else
            {
               AV19vReportTime = context.localUtil.CToT( cgiGet( edtavVreporttime_Internalname));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV19vReportTime", context.localUtil.TToC( AV19vReportTime, 10, 8, 0, 0, "/", ":", " "));
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
            GXVvVSOURCE_html5U2( AV20tCurrentCode) ;
            GXVBR_LAB_BR_LAB_RESULTQUAL_html5U2( AV20tCurrentCode) ;
            GXVBR_LAB_BR_LAB_ABNIND_html5U2( AV20tCurrentCode) ;
         }
         else
         {
            dynload_actions( ) ;
         }
      }

      protected void GXStart( )
      {
         /* Execute user event: Start */
         E115U2 ();
         if (returnInSub) return;
      }

      protected void E115U2( )
      {
         /* Start Routine */
         GXt_char1 = AV20tCurrentCode;
         new zbr_getcurrenttcode(context ).execute( out  GXt_char1) ;
         AV20tCurrentCode = GXt_char1;
         /* Execute user subroutine: 'ATTRIBUTESSECURITYCODE' */
         S112 ();
         if (returnInSub) return;
         edtavBr_lab_br_labid_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavBr_lab_br_labid_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavBr_lab_br_labid_Visible), 5, 0)), true);
         edtavBr_lab_br_encounterid_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavBr_lab_br_encounterid_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavBr_lab_br_encounterid_Visible), 5, 0)), true);
         edtavBr_lab_br_information_patientno_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavBr_lab_br_information_patientno_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavBr_lab_br_information_patientno_Visible), 5, 0)), true);
         edtavBr_lab_br_lab_sampleid_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavBr_lab_br_lab_sampleid_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavBr_lab_br_lab_sampleid_Visible), 5, 0)), true);
         edtavBr_lab_br_lab_testid_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavBr_lab_br_lab_testid_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavBr_lab_br_lab_testid_Visible), 5, 0)), true);
         edtavBr_lab_br_lab_normrangehigh_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavBr_lab_br_lab_normrangehigh_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavBr_lab_br_lab_normrangehigh_Visible), 5, 0)), true);
         AV10BR_Lab.Load(AV14iBR_LabID);
         edtavVothersource_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavVothersource_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavVothersource_Visible), 5, 0)), true);
         AV17vSpecimenDate = AV10BR_Lab.gxTpr_Br_lab_specimendate;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV17vSpecimenDate", context.localUtil.TToC( AV17vSpecimenDate, 10, 8, 0, 0, "/", ":", " "));
         AV18vReceivingTime = AV10BR_Lab.gxTpr_Br_lab_receivingtime;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV18vReceivingTime", context.localUtil.TToC( AV18vReceivingTime, 10, 8, 0, 0, "/", ":", " "));
         AV19vReportTime = AV10BR_Lab.gxTpr_Br_lab_reporttime;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV19vReportTime", context.localUtil.TToC( AV19vReportTime, 10, 8, 0, 0, "/", ":", " "));
      }

      protected void S122( )
      {
         /* 'CHECKREQUIREDFIELDS' Routine */
         AV13CheckRequiredFieldsResult = true;
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV10BR_Lab.gxTpr_Br_lab_testname)) )
         {
            GX_msglist.addItem("项目名称是必须填写的。");
            AV13CheckRequiredFieldsResult = false;
         }
         if ( ( ( StringUtil.StrCmp(AV11vSource, "其它") == 0 ) ) && String.IsNullOrEmpty(StringUtil.RTrim( AV12vOtherSource)) )
         {
            GX_msglist.addItem("其它标本种类是必填的");
            AV13CheckRequiredFieldsResult = false;
         }
         if ( (DateTime.MinValue==AV17vSpecimenDate) )
         {
            GX_msglist.addItem("采样时间是必须填写的。");
            AV13CheckRequiredFieldsResult = false;
         }
      }

      protected void S112( )
      {
         /* 'ATTRIBUTESSECURITYCODE' Routine */
         if ( StringUtil.StrCmp(AV11vSource, "其它") == 0 )
         {
            cellVothersource_cell_Class = "RequiredDataContentCell";
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cellVothersource_cell_Internalname, "Class", cellVothersource_cell_Class, true);
         }
         else
         {
            cellVothersource_cell_Class = "DataContentCell";
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cellVothersource_cell_Internalname, "Class", cellVothersource_cell_Class, true);
         }
      }

      protected void S132( )
      {
         /* 'SHOW MESSAGES' Routine */
         AV43GXV20 = 1;
         while ( AV43GXV20 <= AV8Messages.Count )
         {
            AV7Message = ((SdtMessages_Message)AV8Messages.Item(AV43GXV20));
            GX_msglist.addItem(AV7Message.gxTpr_Description);
            AV43GXV20 = (int)(AV43GXV20+1);
         }
      }

      protected void E125U2( )
      {
         /* Refresh Routine */
         new GeneXus.Programs.wwpbaseobjects.loadwwpcontext(context ).execute( out  AV9Context) ;
      }

      public void GXEnter( )
      {
         /* Execute user event: Enter */
         E135U2 ();
         if (returnInSub) return;
      }

      protected void E135U2( )
      {
         /* Enter Routine */
         new zutil_checksession(context ).execute( out  AV21tCheckFlag) ;
         if ( ! AV21tCheckFlag )
         {
            AV15tFlag = true;
            if ( ( AV15tFlag ) && String.IsNullOrEmpty(StringUtil.RTrim( AV10BR_Lab.gxTpr_Br_lab_testname)) )
            {
               GX_msglist.addItem("项目名称是必填的");
               AV15tFlag = false;
            }
            if ( ( AV15tFlag ) && (DateTime.MinValue==AV17vSpecimenDate) )
            {
               GX_msglist.addItem("采样时间是必填的");
               AV15tFlag = false;
            }
            if ( AV15tFlag )
            {
               if ( StringUtil.StrCmp(AV11vSource, "其它") == 0 )
               {
                  if ( String.IsNullOrEmpty(StringUtil.RTrim( AV12vOtherSource)) )
                  {
                     GX_msglist.addItem("其它标本种类是必填的");
                     AV15tFlag = false;
                  }
                  else
                  {
                     AV10BR_Lab.gxTpr_Br_lab_specimensource = AV12vOtherSource;
                  }
               }
               else
               {
                  AV10BR_Lab.gxTpr_Br_lab_specimensource = AV11vSource;
               }
            }
            if ( AV15tFlag )
            {
               AV10BR_Lab.gxTpr_Br_lab_specimendate = AV17vSpecimenDate;
               AV10BR_Lab.gxTpr_Br_lab_receivingtime = AV18vReceivingTime;
               AV10BR_Lab.gxTpr_Br_lab_reporttime = AV19vReportTime;
               if ( (DateTime.MinValue==AV10BR_Lab.gxTpr_Br_lab_receivingtime) )
               {
                  AV10BR_Lab.gxTv_SdtBR_Lab_Br_lab_receivingtime_SetNull();
               }
               if ( (DateTime.MinValue==AV10BR_Lab.gxTpr_Br_lab_reporttime) )
               {
                  AV10BR_Lab.gxTv_SdtBR_Lab_Br_lab_reporttime_SetNull();
               }
               if ( (DateTime.MinValue==AV10BR_Lab.gxTpr_Br_lab_specimendate) )
               {
                  AV10BR_Lab.gxTv_SdtBR_Lab_Br_lab_specimendate_SetNull();
               }
               AV10BR_Lab.Save();
               if ( AV10BR_Lab.Success() )
               {
                  new zutil_recordsonlog(context ).execute(  StringUtil.Trim( StringUtil.Str( (decimal)(AV10BR_Lab.gxTpr_Br_encounterid), 18, 0)),  "就诊信息",  StringUtil.Trim( StringUtil.Str( (decimal)(AV10BR_Lab.gxTpr_Br_labid), 18, 0)),  "实验室检查",  "Update",  1) ;
                  context.CommitDataStores("br_labupdate",pr_default);
                  context.setWebReturnParms(new Object[] {});
                  context.setWebReturnParmsMetadata(new Object[] {});
                  context.wjLocDisableFrm = 1;
                  context.nUserReturn = 1;
                  returnInSub = true;
                  if (true) return;
               }
               else
               {
                  AV16ErrorMsg = "";
                  AV45GXV22 = 1;
                  AV44GXV21 = AV10BR_Lab.GetMessages();
                  while ( AV45GXV22 <= AV44GXV21.Count )
                  {
                     AV7Message = ((SdtMessages_Message)AV44GXV21.Item(AV45GXV22));
                     AV16ErrorMsg = AV16ErrorMsg + StringUtil.Trim( AV7Message.gxTpr_Description);
                     AV45GXV22 = (int)(AV45GXV22+1);
                  }
                  GX_msglist.addItem(StringUtil.Trim( AV16ErrorMsg));
               }
            }
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV10BR_Lab", AV10BR_Lab);
      }

      protected void nextLoad( )
      {
      }

      protected void E145U2( )
      {
         /* Load Routine */
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV10BR_Lab.gxTpr_Br_lab_specimensource)) )
         {
            dynavVsource.addItem(AV10BR_Lab.gxTpr_Br_lab_specimensource, AV10BR_Lab.gxTpr_Br_lab_specimensource, 0);
            AV11vSource = AV10BR_Lab.gxTpr_Br_lab_specimensource;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11vSource", AV11vSource);
         }
      }

      protected void wb_table1_50_5U2( bool wbgen )
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
            GxWebStd.gx_label_element( context, dynavVsource_Internalname, "v Source", "col-sm-3 AttributeLabel", 0, true);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 54,'',false,'',0)\"";
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, dynavVsource, dynavVsource_Internalname, StringUtil.RTrim( AV11vSource), 1, dynavVsource_Jsonclick, 0, "'"+""+"'"+",false,"+"'"+""+"'", "svchar", "", 1, dynavVsource.Enabled, 0, 0, 0, "em", 0, "", "", "Attribute", "", "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,54);\"", "", true, "HLP_BR_LabUpdate.htm");
            dynavVsource.CurrentValue = StringUtil.RTrim( AV11vSource);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynavVsource_Internalname, "Values", (String)(dynavVsource.ToJavascriptSource()), true);
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td id=\""+cellVothersource_cell_Internalname+"\"  class='"+cellVothersource_cell_Class+"'>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavVothersource_Internalname, "v Other Source", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 57,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavVothersource_Internalname, AV12vOtherSource, StringUtil.RTrim( context.localUtil.Format( AV12vOtherSource, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,57);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "请填写其它标本种类", edtavVothersource_Jsonclick, 0, "Attribute", "", "", "", "", edtavVothersource_Visible, edtavVothersource_Enabled, 0, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_BR_LabUpdate.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table1_50_5U2e( true) ;
         }
         else
         {
            wb_table1_50_5U2e( false) ;
         }
      }

      public override void setparameters( Object[] obj )
      {
         createObjects();
         initialize();
         AV14iBR_LabID = Convert.ToInt64(getParm(obj,0));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14iBR_LabID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV14iBR_LabID), 18, 0)));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vIBR_LABID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV14iBR_LabID), "ZZZZZZZZZZZZZZZZZZ"), context));
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
         PA5U2( ) ;
         WS5U2( ) ;
         WE5U2( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?202022815143829", true);
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
         context.AddJavascriptSource("br_labupdate.js", "?202022815143829", false);
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
         edtavBr_lab_br_lab_testcode_Internalname = "BR_LAB_BR_LAB_TESTCODE";
         edtavBr_lab_br_lab_age_Internalname = "BR_LAB_BR_LAB_AGE";
         edtavBr_lab_br_lab_diag_Internalname = "BR_LAB_BR_LAB_DIAG";
         lblTextblockvsource_Internalname = "TEXTBLOCKVSOURCE";
         dynavVsource_Internalname = "vVSOURCE";
         edtavVothersource_Internalname = "vVOTHERSOURCE";
         cellVothersource_cell_Internalname = "VOTHERSOURCE_CELL";
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
         edtavBr_lab_br_labid_Internalname = "BR_LAB_BR_LABID";
         edtavBr_lab_br_encounterid_Internalname = "BR_LAB_BR_ENCOUNTERID";
         edtavBr_lab_br_information_patientno_Internalname = "BR_LAB_BR_INFORMATION_PATIENTNO";
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
         cellVothersource_cell_Class = "";
         dynavVsource_Jsonclick = "";
         dynavVsource.Enabled = 1;
         edtavVothersource_Visible = 1;
         edtavBr_lab_br_lab_normrangehigh_Jsonclick = "";
         edtavBr_lab_br_lab_normrangehigh_Visible = 1;
         edtavBr_lab_br_lab_testid_Jsonclick = "";
         edtavBr_lab_br_lab_testid_Visible = 1;
         edtavBr_lab_br_lab_sampleid_Jsonclick = "";
         edtavBr_lab_br_lab_sampleid_Visible = 1;
         edtavBr_lab_br_information_patientno_Jsonclick = "";
         edtavBr_lab_br_information_patientno_Visible = 1;
         edtavBr_lab_br_encounterid_Jsonclick = "";
         edtavBr_lab_br_encounterid_Visible = 1;
         edtavBr_lab_br_labid_Jsonclick = "";
         edtavBr_lab_br_labid_Visible = 1;
         edtavBr_lab_br_lab_resultnum_Enabled = 1;
         edtavBr_lab_br_lab_instrumentname_Enabled = 1;
         edtavBr_lab_br_lab_instrumentcode_Jsonclick = "";
         edtavBr_lab_br_lab_instrumentcode_Enabled = 1;
         edtavBr_lab_br_lab_testmethod_Jsonclick = "";
         edtavBr_lab_br_lab_testmethod_Enabled = 1;
         edtavBr_lab_br_lab_normrangelow_Jsonclick = "";
         edtavBr_lab_br_lab_normrangelow_Enabled = 1;
         dynavBr_lab_br_lab_abnind_Jsonclick = "";
         dynavBr_lab_br_lab_abnind.Enabled = 1;
         edtavBr_lab_br_lab_resultunit_Jsonclick = "";
         edtavBr_lab_br_lab_resultunit_Enabled = 1;
         dynavBr_lab_br_lab_resultqual_Jsonclick = "";
         dynavBr_lab_br_lab_resultqual.Enabled = 1;
         edtavVreporttime_Jsonclick = "";
         edtavVreporttime_Enabled = 1;
         edtavVreceivingtime_Jsonclick = "";
         edtavVreceivingtime_Enabled = 1;
         edtavVspecimendate_Jsonclick = "";
         edtavVspecimendate_Enabled = 1;
         edtavBr_lab_br_lab_diag_Jsonclick = "";
         edtavBr_lab_br_lab_diag_Enabled = 1;
         edtavBr_lab_br_lab_age_Jsonclick = "";
         edtavBr_lab_br_lab_age_Enabled = 1;
         edtavBr_lab_br_lab_testcode_Jsonclick = "";
         edtavBr_lab_br_lab_testcode_Enabled = 1;
         edtavBr_lab_br_lab_testengname_Jsonclick = "";
         edtavBr_lab_br_lab_testengname_Enabled = 1;
         edtavBr_lab_br_lab_testname_Jsonclick = "";
         edtavBr_lab_br_lab_testname_Enabled = 1;
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
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[{av:'AV14iBR_LabID',fld:'vIBR_LABID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true}]");
         setEventMetadata("REFRESH",",oparms:[]}");
         setEventMetadata("ENTER","{handler:'E135U2',iparms:[{av:'AV10BR_Lab',fld:'vBR_LAB',pic:''},{av:'AV17vSpecimenDate',fld:'vVSPECIMENDATE',pic:'9999/99/99 99:99:99'},{av:'dynavVsource'},{av:'AV11vSource',fld:'vVSOURCE',pic:''},{av:'AV12vOtherSource',fld:'vVOTHERSOURCE',pic:''},{av:'AV18vReceivingTime',fld:'vVRECEIVINGTIME',pic:'9999/99/99 99:99:99'},{av:'AV19vReportTime',fld:'vVREPORTTIME',pic:'9999/99/99 99:99:99'}]");
         setEventMetadata("ENTER",",oparms:[{av:'AV10BR_Lab',fld:'vBR_LAB',pic:''}]}");
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
         AV20tCurrentCode = "";
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         GXKey = "";
         AV10BR_Lab = new SdtBR_Lab(context);
         GX_FocusControl = "";
         Form = new GXWebForm();
         sPrefix = "";
         ClassString = "";
         StyleString = "";
         ucDvpanel_tableattributes = new GXUserControl();
         TempTags = "";
         lblTextblockvsource_Jsonclick = "";
         AV17vSpecimenDate = (DateTime)(DateTime.MinValue);
         AV18vReceivingTime = (DateTime)(DateTime.MinValue);
         AV19vReportTime = (DateTime)(DateTime.MinValue);
         bttBtnenter_Jsonclick = "";
         bttBtncancel_Jsonclick = "";
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         gxdynajaxctrlcodr = new GeneXus.Utils.GxStringCollection();
         gxdynajaxctrldescr = new GeneXus.Utils.GxStringCollection();
         gxwrpcisep = "";
         AV11vSource = "";
         scmdbuf = "";
         H005U2_A167XT_DefineCodeID = new long[1] ;
         H005U2_A168XT_DefineCodeName = new String[] {""} ;
         H005U2_n168XT_DefineCodeName = new bool[] {false} ;
         H005U2_A165XT_DefindcodeTypeID = new long[1] ;
         H005U2_A432XT_TenantCode = new String[] {""} ;
         H005U2_n432XT_TenantCode = new bool[] {false} ;
         H005U3_A167XT_DefineCodeID = new long[1] ;
         H005U3_A168XT_DefineCodeName = new String[] {""} ;
         H005U3_n168XT_DefineCodeName = new bool[] {false} ;
         H005U3_A165XT_DefindcodeTypeID = new long[1] ;
         H005U3_A432XT_TenantCode = new String[] {""} ;
         H005U3_n432XT_TenantCode = new bool[] {false} ;
         H005U4_A167XT_DefineCodeID = new long[1] ;
         H005U4_A168XT_DefineCodeName = new String[] {""} ;
         H005U4_n168XT_DefineCodeName = new bool[] {false} ;
         H005U4_A165XT_DefindcodeTypeID = new long[1] ;
         H005U4_A432XT_TenantCode = new String[] {""} ;
         H005U4_n432XT_TenantCode = new bool[] {false} ;
         AV12vOtherSource = "";
         GXt_char1 = "";
         AV8Messages = new GXBaseCollection<SdtMessages_Message>( context, "Message", "GeneXus");
         AV7Message = new SdtMessages_Message(context);
         AV9Context = new GeneXus.Programs.wwpbaseobjects.SdtWWPContext(context);
         AV16ErrorMsg = "";
         AV44GXV21 = new GXBaseCollection<SdtMessages_Message>( context, "Message", "GeneXus");
         sStyleString = "";
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         pr_datastore1 = new DataStoreProvider(context, new GeneXus.Programs.br_labupdate__datastore1(),
            new Object[][] {
            }
         );
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.br_labupdate__default(),
            new Object[][] {
                new Object[] {
               H005U2_A167XT_DefineCodeID, H005U2_A168XT_DefineCodeName, H005U2_n168XT_DefineCodeName, H005U2_A165XT_DefindcodeTypeID, H005U2_A432XT_TenantCode, H005U2_n432XT_TenantCode
               }
               , new Object[] {
               H005U3_A167XT_DefineCodeID, H005U3_A168XT_DefineCodeName, H005U3_n168XT_DefineCodeName, H005U3_A165XT_DefindcodeTypeID, H005U3_A432XT_TenantCode, H005U3_n432XT_TenantCode
               }
               , new Object[] {
               H005U4_A167XT_DefineCodeID, H005U4_A168XT_DefineCodeName, H005U4_n168XT_DefineCodeName, H005U4_A165XT_DefindcodeTypeID, H005U4_A432XT_TenantCode, H005U4_n432XT_TenantCode
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0;
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
      private int edtavBr_lab_br_lab_testcode_Enabled ;
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
      private int edtavBr_lab_br_labid_Visible ;
      private int edtavBr_lab_br_encounterid_Visible ;
      private int edtavBr_lab_br_information_patientno_Visible ;
      private int edtavBr_lab_br_lab_sampleid_Visible ;
      private int edtavBr_lab_br_lab_testid_Visible ;
      private int edtavBr_lab_br_lab_normrangehigh_Visible ;
      private int gxdynajaxindex ;
      private int edtavVothersource_Visible ;
      private int AV43GXV20 ;
      private int AV45GXV22 ;
      private int edtavVothersource_Enabled ;
      private int idxLst ;
      private long AV14iBR_LabID ;
      private long wcpOAV14iBR_LabID ;
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
      private String edtavBr_lab_br_lab_testname_Internalname ;
      private String TempTags ;
      private String edtavBr_lab_br_lab_testname_Jsonclick ;
      private String edtavBr_lab_br_lab_testengname_Internalname ;
      private String edtavBr_lab_br_lab_testengname_Jsonclick ;
      private String edtavBr_lab_br_lab_testcode_Internalname ;
      private String edtavBr_lab_br_lab_testcode_Jsonclick ;
      private String edtavBr_lab_br_lab_age_Internalname ;
      private String edtavBr_lab_br_lab_age_Jsonclick ;
      private String edtavBr_lab_br_lab_diag_Internalname ;
      private String edtavBr_lab_br_lab_diag_Jsonclick ;
      private String divTablesplittedvsource_Internalname ;
      private String lblTextblockvsource_Internalname ;
      private String lblTextblockvsource_Jsonclick ;
      private String edtavVspecimendate_Internalname ;
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
      private String edtavBr_lab_br_labid_Internalname ;
      private String edtavBr_lab_br_labid_Jsonclick ;
      private String edtavBr_lab_br_encounterid_Internalname ;
      private String edtavBr_lab_br_encounterid_Jsonclick ;
      private String edtavBr_lab_br_information_patientno_Internalname ;
      private String edtavBr_lab_br_information_patientno_Jsonclick ;
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
      private String GXt_char1 ;
      private String cellVothersource_cell_Class ;
      private String cellVothersource_cell_Internalname ;
      private String sStyleString ;
      private String tblTablemergedvsource_Internalname ;
      private String dynavVsource_Jsonclick ;
      private String edtavVothersource_Jsonclick ;
      private DateTime AV17vSpecimenDate ;
      private DateTime AV18vReceivingTime ;
      private DateTime AV19vReportTime ;
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
      private bool AV13CheckRequiredFieldsResult ;
      private bool AV21tCheckFlag ;
      private bool AV15tFlag ;
      private String AV20tCurrentCode ;
      private String AV11vSource ;
      private String AV12vOtherSource ;
      private String AV16ErrorMsg ;
      private GeneXus.Utils.GxStringCollection gxdynajaxctrlcodr ;
      private GeneXus.Utils.GxStringCollection gxdynajaxctrldescr ;
      private GXUserControl ucDvpanel_tableattributes ;
      private IGxDataStore dsDataStore1 ;
      private IGxDataStore dsDefault ;
      private GXCombobox dynavVsource ;
      private GXCombobox dynavBr_lab_br_lab_resultqual ;
      private GXCombobox dynavBr_lab_br_lab_abnind ;
      private IDataStoreProvider pr_default ;
      private long[] H005U2_A167XT_DefineCodeID ;
      private String[] H005U2_A168XT_DefineCodeName ;
      private bool[] H005U2_n168XT_DefineCodeName ;
      private long[] H005U2_A165XT_DefindcodeTypeID ;
      private String[] H005U2_A432XT_TenantCode ;
      private bool[] H005U2_n432XT_TenantCode ;
      private long[] H005U3_A167XT_DefineCodeID ;
      private String[] H005U3_A168XT_DefineCodeName ;
      private bool[] H005U3_n168XT_DefineCodeName ;
      private long[] H005U3_A165XT_DefindcodeTypeID ;
      private String[] H005U3_A432XT_TenantCode ;
      private bool[] H005U3_n432XT_TenantCode ;
      private long[] H005U4_A167XT_DefineCodeID ;
      private String[] H005U4_A168XT_DefineCodeName ;
      private bool[] H005U4_n168XT_DefineCodeName ;
      private long[] H005U4_A165XT_DefindcodeTypeID ;
      private String[] H005U4_A432XT_TenantCode ;
      private bool[] H005U4_n432XT_TenantCode ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private IDataStoreProvider pr_datastore1 ;
      private GXBaseCollection<SdtMessages_Message> AV8Messages ;
      private GXBaseCollection<SdtMessages_Message> AV44GXV21 ;
      private GXWebForm Form ;
      private SdtMessages_Message AV7Message ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPContext AV9Context ;
      private SdtBR_Lab AV10BR_Lab ;
   }

   public class br_labupdate__datastore1 : DataStoreHelperBase, IDataStoreHelper
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

 public class br_labupdate__default : DataStoreHelperBase, IDataStoreHelper
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
        Object[] prmH005U2 ;
        prmH005U2 = new Object[] {
        new Object[] {"@AV20tCurrentCode",SqlDbType.NVarChar,40,0}
        } ;
        Object[] prmH005U3 ;
        prmH005U3 = new Object[] {
        new Object[] {"@AV20tCurrentCode",SqlDbType.NVarChar,40,0}
        } ;
        Object[] prmH005U4 ;
        prmH005U4 = new Object[] {
        new Object[] {"@AV20tCurrentCode",SqlDbType.NVarChar,40,0}
        } ;
        def= new CursorDef[] {
            new CursorDef("H005U2", "SELECT [XT_DefineCodeID], [XT_DefineCodeName], [XT_DefindcodeTypeID], [XT_TenantCode] FROM [XT_DefineCode] WITH (NOLOCK) WHERE ([XT_DefindcodeTypeID] = 22) AND ([XT_TenantCode] = @AV20tCurrentCode) ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH005U2,0,0,true,false )
           ,new CursorDef("H005U3", "SELECT [XT_DefineCodeID], [XT_DefineCodeName], [XT_DefindcodeTypeID], [XT_TenantCode] FROM [XT_DefineCode] WITH (NOLOCK) WHERE ([XT_DefindcodeTypeID] = 23) AND ([XT_TenantCode] = @AV20tCurrentCode) ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH005U3,0,0,true,false )
           ,new CursorDef("H005U4", "SELECT [XT_DefineCodeID], [XT_DefineCodeName], [XT_DefindcodeTypeID], [XT_TenantCode] FROM [XT_DefineCode] WITH (NOLOCK) WHERE ([XT_DefindcodeTypeID] = 24) AND ([XT_TenantCode] = @AV20tCurrentCode) ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH005U4,0,0,true,false )
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
