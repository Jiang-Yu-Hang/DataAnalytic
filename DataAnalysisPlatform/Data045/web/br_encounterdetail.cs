/*
               File: BR_EncounterDetail
        Description: Data Mgmt Portal - RAAP
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/28/2020 15:11:45.16
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
   public class br_encounterdetail : GXDataArea, System.Web.SessionState.IRequiresSessionState
   {
      public br_encounterdetail( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public br_encounterdetail( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( long aP0_iBR_EncounterID )
      {
         this.AV11iBR_EncounterID = aP0_iBR_EncounterID;
         executePrivate();
      }

      void executePrivate( )
      {
         isStatic = false;
         webExecute();
      }

      protected override void createObjects( )
      {
         chkavBr_encounter_br_encounter_israndapprove = new GXCheckbox();
         chkavBr_encounter_br_encounter_israndrecheck = new GXCheckbox();
         chkavBr_encounter_br_encounter_isupdate = new GXCheckbox();
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
               AV11iBR_EncounterID = (long)(NumberUtil.Val( gxfirstwebparm, "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11iBR_EncounterID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11iBR_EncounterID), 18, 0)));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vIBR_ENCOUNTERID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV11iBR_EncounterID), "ZZZZZZZZZZZZZZZZZZ"), context));
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
         PA4E2( ) ;
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0));
         if ( ( gxajaxcallmode == 0 ) && ( GxWebError == 0 ) )
         {
            START4E2( ) ;
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
         context.AddJavascriptSource("gxcfg.js", "?202022815114522", false);
         if ( context.isSpaRequest( ) )
         {
            enableOutput();
         }
         context.AddJavascriptSource("calendar.js", "?"+context.GetBuildNumber( 127771), false);
         context.AddJavascriptSource("calendar-setup.js", "?"+context.GetBuildNumber( 127771), false);
         context.AddJavascriptSource("calendar-zh.js", "?"+context.GetBuildNumber( 127771), false);
         context.AddJavascriptSource("DVelop/Bootstrap/Shared/DVelopBootstrap.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/Panel/BootstrapPanelRender.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/Shared/DVelopBootstrap.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/Panel/BootstrapPanelRender.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/Shared/DVelopBootstrap.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/Panel/BootstrapPanelRender.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/Shared/DVelopBootstrap.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/Panel/BootstrapPanelRender.js", "", false);
         context.WriteHtmlText( Form.Headerrawhtml) ;
         context.CloseHtmlHeader();
         if ( context.isSpaRequest( ) )
         {
            disableOutput();
         }
         FormProcess = " data-HasEnter=\"false\" data-Skiponenter=\"false\"";
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" autocomplete=\"off\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("br_encounterdetail.aspx") + "?" + UrlEncode("" +AV11iBR_EncounterID)+"\">") ;
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
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "Br_encounter", AV10BR_Encounter);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("Br_encounter", AV10BR_Encounter);
         }
         GxWebStd.gx_hidden_field( context, "vIBR_ENCOUNTERID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV11iBR_EncounterID), 18, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "gxhash_vIBR_ENCOUNTERID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV11iBR_EncounterID), "ZZZZZZZZZZZZZZZZZZ"), context));
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
         GxWebStd.gx_hidden_field( context, "DVPANEL_UNNAMEDTABLE1_Width", StringUtil.RTrim( Dvpanel_unnamedtable1_Width));
         GxWebStd.gx_hidden_field( context, "DVPANEL_UNNAMEDTABLE1_Cls", StringUtil.RTrim( Dvpanel_unnamedtable1_Cls));
         GxWebStd.gx_hidden_field( context, "DVPANEL_UNNAMEDTABLE1_Title", StringUtil.RTrim( Dvpanel_unnamedtable1_Title));
         GxWebStd.gx_hidden_field( context, "DVPANEL_UNNAMEDTABLE1_Collapsible", StringUtil.BoolToStr( Dvpanel_unnamedtable1_Collapsible));
         GxWebStd.gx_hidden_field( context, "DVPANEL_UNNAMEDTABLE1_Collapsed", StringUtil.BoolToStr( Dvpanel_unnamedtable1_Collapsed));
         GxWebStd.gx_hidden_field( context, "DVPANEL_UNNAMEDTABLE1_Autowidth", StringUtil.BoolToStr( Dvpanel_unnamedtable1_Autowidth));
         GxWebStd.gx_hidden_field( context, "DVPANEL_UNNAMEDTABLE1_Autoheight", StringUtil.BoolToStr( Dvpanel_unnamedtable1_Autoheight));
         GxWebStd.gx_hidden_field( context, "DVPANEL_UNNAMEDTABLE1_Showcollapseicon", StringUtil.BoolToStr( Dvpanel_unnamedtable1_Showcollapseicon));
         GxWebStd.gx_hidden_field( context, "DVPANEL_UNNAMEDTABLE1_Iconposition", StringUtil.RTrim( Dvpanel_unnamedtable1_Iconposition));
         GxWebStd.gx_hidden_field( context, "DVPANEL_UNNAMEDTABLE1_Autoscroll", StringUtil.BoolToStr( Dvpanel_unnamedtable1_Autoscroll));
         GxWebStd.gx_hidden_field( context, "DVPANEL_UNNAMEDTABLE2_Width", StringUtil.RTrim( Dvpanel_unnamedtable2_Width));
         GxWebStd.gx_hidden_field( context, "DVPANEL_UNNAMEDTABLE2_Cls", StringUtil.RTrim( Dvpanel_unnamedtable2_Cls));
         GxWebStd.gx_hidden_field( context, "DVPANEL_UNNAMEDTABLE2_Title", StringUtil.RTrim( Dvpanel_unnamedtable2_Title));
         GxWebStd.gx_hidden_field( context, "DVPANEL_UNNAMEDTABLE2_Collapsible", StringUtil.BoolToStr( Dvpanel_unnamedtable2_Collapsible));
         GxWebStd.gx_hidden_field( context, "DVPANEL_UNNAMEDTABLE2_Collapsed", StringUtil.BoolToStr( Dvpanel_unnamedtable2_Collapsed));
         GxWebStd.gx_hidden_field( context, "DVPANEL_UNNAMEDTABLE2_Autowidth", StringUtil.BoolToStr( Dvpanel_unnamedtable2_Autowidth));
         GxWebStd.gx_hidden_field( context, "DVPANEL_UNNAMEDTABLE2_Autoheight", StringUtil.BoolToStr( Dvpanel_unnamedtable2_Autoheight));
         GxWebStd.gx_hidden_field( context, "DVPANEL_UNNAMEDTABLE2_Showcollapseicon", StringUtil.BoolToStr( Dvpanel_unnamedtable2_Showcollapseicon));
         GxWebStd.gx_hidden_field( context, "DVPANEL_UNNAMEDTABLE2_Iconposition", StringUtil.RTrim( Dvpanel_unnamedtable2_Iconposition));
         GxWebStd.gx_hidden_field( context, "DVPANEL_UNNAMEDTABLE2_Autoscroll", StringUtil.BoolToStr( Dvpanel_unnamedtable2_Autoscroll));
         GxWebStd.gx_hidden_field( context, "DVPANEL_UNNAMEDTABLE3_Width", StringUtil.RTrim( Dvpanel_unnamedtable3_Width));
         GxWebStd.gx_hidden_field( context, "DVPANEL_UNNAMEDTABLE3_Cls", StringUtil.RTrim( Dvpanel_unnamedtable3_Cls));
         GxWebStd.gx_hidden_field( context, "DVPANEL_UNNAMEDTABLE3_Title", StringUtil.RTrim( Dvpanel_unnamedtable3_Title));
         GxWebStd.gx_hidden_field( context, "DVPANEL_UNNAMEDTABLE3_Collapsible", StringUtil.BoolToStr( Dvpanel_unnamedtable3_Collapsible));
         GxWebStd.gx_hidden_field( context, "DVPANEL_UNNAMEDTABLE3_Collapsed", StringUtil.BoolToStr( Dvpanel_unnamedtable3_Collapsed));
         GxWebStd.gx_hidden_field( context, "DVPANEL_UNNAMEDTABLE3_Autowidth", StringUtil.BoolToStr( Dvpanel_unnamedtable3_Autowidth));
         GxWebStd.gx_hidden_field( context, "DVPANEL_UNNAMEDTABLE3_Autoheight", StringUtil.BoolToStr( Dvpanel_unnamedtable3_Autoheight));
         GxWebStd.gx_hidden_field( context, "DVPANEL_UNNAMEDTABLE3_Showcollapseicon", StringUtil.BoolToStr( Dvpanel_unnamedtable3_Showcollapseicon));
         GxWebStd.gx_hidden_field( context, "DVPANEL_UNNAMEDTABLE3_Iconposition", StringUtil.RTrim( Dvpanel_unnamedtable3_Iconposition));
         GxWebStd.gx_hidden_field( context, "DVPANEL_UNNAMEDTABLE3_Autoscroll", StringUtil.BoolToStr( Dvpanel_unnamedtable3_Autoscroll));
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
            WE4E2( ) ;
            context.WriteHtmlText( "</div>") ;
         }
      }

      public override void DispatchEvents( )
      {
         EVT4E2( ) ;
      }

      public override bool HasEnterEvent( )
      {
         return false ;
      }

      public override GXWebForm GetForm( )
      {
         return Form ;
      }

      public override String GetSelfLink( )
      {
         return formatLink("br_encounterdetail.aspx") + "?" + UrlEncode("" +AV11iBR_EncounterID) ;
      }

      public override String GetPgmname( )
      {
         return "BR_EncounterDetail" ;
      }

      public override String GetPgmdesc( )
      {
         return "Data Mgmt Portal - RAAP" ;
      }

      protected void WB4E0( )
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
            GxWebStd.gx_msg_list( context, "", context.GX_msglist.DisplayMode, "", "", "", "false");
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
            /* Div Control */
            GxWebStd.gx_div_start( context, divTablecontent_Internalname, 1, 0, "px", 0, "px", "TableContent", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "Right", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 12,'',false,'',0)\"";
            ClassString = "ButtonMaterial";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_cancel_Internalname, "", "返回", bttBtn_cancel_Jsonclick, 1, "取消", "", StyleString, ClassString, 1, 1, "standard", "'"+""+"'"+",false,"+"'"+"ECANCEL."+"'", TempTags, "", context.GetButtonType( ), "HLP_BR_EncounterDetail.htm");
            GxWebStd.gx_div_end( context, "Right", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
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
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divUnnamedtable6_Internalname, 1, 0, "px", 0, "px", "", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divUnnamedtable7_Internalname, 1, 0, "px", 0, "px", "", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divUnnamedtablebr_encounter_br_encounter_crtdisplayname_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 MergeLabelCell", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblockbr_encounter_br_encounter_crtdisplayname_Internalname, "创建人", "", "", lblTextblockbr_encounter_br_encounter_crtdisplayname_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_BR_EncounterDetail.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavBr_encounter_br_encounter_crtdisplayname_Internalname, "创建人", "col-sm-3 ReadonlyAttributeLabel", 0, true);
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtavBr_encounter_br_encounter_crtdisplayname_Internalname, AV10BR_Encounter.gxTpr_Br_encounter_crtdisplayname, StringUtil.RTrim( context.localUtil.Format( AV10BR_Encounter.gxTpr_Br_encounter_crtdisplayname, "")), "", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavBr_encounter_br_encounter_crtdisplayname_Jsonclick, 0, "ReadonlyAttribute", "", "", "", "", 1, edtavBr_encounter_br_encounter_crtdisplayname_Enabled, 0, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, -1, false, "", "left", true, "HLP_BR_EncounterDetail.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divUnnamedtablebr_encounter_br_encounter_crtdate_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 MergeLabelCell", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblockbr_encounter_br_encounter_crtdate_Internalname, "创建时间", "", "", lblTextblockbr_encounter_br_encounter_crtdate_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_BR_EncounterDetail.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavBr_encounter_br_encounter_crtdate_Internalname, "创建时间", "col-sm-3 ReadonlyAttributeLabel", 0, true);
            /* Single line edit */
            context.WriteHtmlText( "<div id=\""+edtavBr_encounter_br_encounter_crtdate_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtavBr_encounter_br_encounter_crtdate_Internalname, context.localUtil.TToC( AV10BR_Encounter.gxTpr_Br_encounter_crtdate, 10, 8, 0, 0, "/", ":", " "), context.localUtil.Format( AV10BR_Encounter.gxTpr_Br_encounter_crtdate, "9999/99/99 99:99:99"), "", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavBr_encounter_br_encounter_crtdate_Jsonclick, 0, "ReadonlyAttribute", "", "", "", "", 1, edtavBr_encounter_br_encounter_crtdate_Enabled, 0, "text", "", 19, "chr", 1, "row", 19, 0, 0, 0, 1, -1, 0, false, "", "right", false, "HLP_BR_EncounterDetail.htm");
            GxWebStd.gx_bitmap( context, edtavBr_encounter_br_encounter_crtdate_Internalname+"_dp_trigger", context.GetImagePath( "61b9b5d3-dff6-4d59-9b00-da61bc2cbe93", "", context.GetTheme( )), "", "", "", "", ((1==0)||(edtavBr_encounter_br_encounter_crtdate_Enabled==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;", "", "", "", "", "", "", "", "", 1, false, false, "", "HLP_BR_EncounterDetail.htm");
            context.WriteHtmlTextNl( "</div>") ;
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
            GxWebStd.gx_div_start( context, divUnnamedtable8_Internalname, 1, 0, "px", 0, "px", "", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divUnnamedtablebr_encounter_br_encounter_submituser_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 MergeLabelCell", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblockbr_encounter_br_encounter_submituser_Internalname, "提交初审人", "", "", lblTextblockbr_encounter_br_encounter_submituser_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_BR_EncounterDetail.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavBr_encounter_br_encounter_submituser_Internalname, "提交初审人", "col-sm-3 ReadonlyAttributeLabel", 0, true);
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtavBr_encounter_br_encounter_submituser_Internalname, AV10BR_Encounter.gxTpr_Br_encounter_submituser, StringUtil.RTrim( context.localUtil.Format( AV10BR_Encounter.gxTpr_Br_encounter_submituser, "")), "", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavBr_encounter_br_encounter_submituser_Jsonclick, 0, "ReadonlyAttribute", "", "", "", "", 1, edtavBr_encounter_br_encounter_submituser_Enabled, 0, "text", "", 40, "chr", 1, "row", 40, 0, 0, 0, 1, -1, -1, false, "", "left", true, "HLP_BR_EncounterDetail.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divUnnamedtablebr_encounter_br_encounter_submitdate_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 MergeLabelCell", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblockbr_encounter_br_encounter_submitdate_Internalname, "提交初审时间", "", "", lblTextblockbr_encounter_br_encounter_submitdate_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_BR_EncounterDetail.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavBr_encounter_br_encounter_submitdate_Internalname, "提交初审时间", "col-sm-3 ReadonlyAttributeLabel", 0, true);
            /* Single line edit */
            context.WriteHtmlText( "<div id=\""+edtavBr_encounter_br_encounter_submitdate_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtavBr_encounter_br_encounter_submitdate_Internalname, context.localUtil.TToC( AV10BR_Encounter.gxTpr_Br_encounter_submitdate, 10, 8, 0, 0, "/", ":", " "), context.localUtil.Format( AV10BR_Encounter.gxTpr_Br_encounter_submitdate, "9999/99/99 99:99:99"), "", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavBr_encounter_br_encounter_submitdate_Jsonclick, 0, "ReadonlyAttribute", "", "", "", "", 1, edtavBr_encounter_br_encounter_submitdate_Enabled, 0, "text", "", 19, "chr", 1, "row", 19, 0, 0, 0, 1, -1, 0, false, "", "right", false, "HLP_BR_EncounterDetail.htm");
            GxWebStd.gx_bitmap( context, edtavBr_encounter_br_encounter_submitdate_Internalname+"_dp_trigger", context.GetImagePath( "61b9b5d3-dff6-4d59-9b00-da61bc2cbe93", "", context.GetTheme( )), "", "", "", "", ((1==0)||(edtavBr_encounter_br_encounter_submitdate_Enabled==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;", "", "", "", "", "", "", "", "", 1, false, false, "", "HLP_BR_EncounterDetail.htm");
            context.WriteHtmlTextNl( "</div>") ;
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
            GxWebStd.gx_div_start( context, divUnnamedtable9_Internalname, 1, 0, "px", 0, "px", "", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divUnnamedtablebr_encounter_br_encounter_approver_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 MergeLabelCell", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblockbr_encounter_br_encounter_approver_Internalname, "提交复审人", "", "", lblTextblockbr_encounter_br_encounter_approver_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_BR_EncounterDetail.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavBr_encounter_br_encounter_approver_Internalname, "初审通过操作/提交复审人", "col-sm-3 ReadonlyAttributeLabel", 0, true);
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtavBr_encounter_br_encounter_approver_Internalname, AV10BR_Encounter.gxTpr_Br_encounter_approver, StringUtil.RTrim( context.localUtil.Format( AV10BR_Encounter.gxTpr_Br_encounter_approver, "")), "", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavBr_encounter_br_encounter_approver_Jsonclick, 0, "ReadonlyAttribute", "", "", "", "", 1, edtavBr_encounter_br_encounter_approver_Enabled, 0, "text", "", 40, "chr", 1, "row", 40, 0, 0, 0, 1, -1, -1, false, "", "left", true, "HLP_BR_EncounterDetail.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divUnnamedtablebr_encounter_br_encounter_approvedate_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 MergeLabelCell", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblockbr_encounter_br_encounter_approvedate_Internalname, "初审通过操作", "", "", lblTextblockbr_encounter_br_encounter_approvedate_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_BR_EncounterDetail.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavBr_encounter_br_encounter_approvedate_Internalname, "初审通过操作/提交复审时间", "col-sm-3 ReadonlyAttributeLabel", 0, true);
            /* Single line edit */
            context.WriteHtmlText( "<div id=\""+edtavBr_encounter_br_encounter_approvedate_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtavBr_encounter_br_encounter_approvedate_Internalname, context.localUtil.TToC( AV10BR_Encounter.gxTpr_Br_encounter_approvedate, 10, 8, 0, 0, "/", ":", " "), context.localUtil.Format( AV10BR_Encounter.gxTpr_Br_encounter_approvedate, "9999/99/99 99:99:99"), "", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavBr_encounter_br_encounter_approvedate_Jsonclick, 0, "ReadonlyAttribute", "", "", "", "", 1, edtavBr_encounter_br_encounter_approvedate_Enabled, 0, "text", "", 19, "chr", 1, "row", 19, 0, 0, 0, 1, -1, 0, false, "", "right", false, "HLP_BR_EncounterDetail.htm");
            GxWebStd.gx_bitmap( context, edtavBr_encounter_br_encounter_approvedate_Internalname+"_dp_trigger", context.GetImagePath( "61b9b5d3-dff6-4d59-9b00-da61bc2cbe93", "", context.GetTheme( )), "", "", "", "", ((1==0)||(edtavBr_encounter_br_encounter_approvedate_Enabled==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;", "", "", "", "", "", "", "", "", 1, false, false, "", "HLP_BR_EncounterDetail.htm");
            context.WriteHtmlTextNl( "</div>") ;
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
            GxWebStd.gx_div_start( context, divUnnamedtable10_Internalname, 1, 0, "px", 0, "px", "", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divUnnamedtablebr_encounter_br_encounter_recheckuser_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 MergeLabelCell", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblockbr_encounter_br_encounter_recheckuser_Internalname, "复审通过操作人", "", "", lblTextblockbr_encounter_br_encounter_recheckuser_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_BR_EncounterDetail.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavBr_encounter_br_encounter_recheckuser_Internalname, "复审通过操作人", "col-sm-3 ReadonlyAttributeLabel", 0, true);
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtavBr_encounter_br_encounter_recheckuser_Internalname, AV10BR_Encounter.gxTpr_Br_encounter_recheckuser, StringUtil.RTrim( context.localUtil.Format( AV10BR_Encounter.gxTpr_Br_encounter_recheckuser, "")), "", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavBr_encounter_br_encounter_recheckuser_Jsonclick, 0, "ReadonlyAttribute", "", "", "", "", 1, edtavBr_encounter_br_encounter_recheckuser_Enabled, 0, "text", "", 40, "chr", 1, "row", 40, 0, 0, 0, 1, -1, -1, false, "", "left", true, "HLP_BR_EncounterDetail.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divUnnamedtablebr_encounter_br_encounter_recheckdate_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 MergeLabelCell", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblockbr_encounter_br_encounter_recheckdate_Internalname, "复审通过时间", "", "", lblTextblockbr_encounter_br_encounter_recheckdate_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_BR_EncounterDetail.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavBr_encounter_br_encounter_recheckdate_Internalname, "复审通过时间", "col-sm-3 ReadonlyAttributeLabel", 0, true);
            /* Single line edit */
            context.WriteHtmlText( "<div id=\""+edtavBr_encounter_br_encounter_recheckdate_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtavBr_encounter_br_encounter_recheckdate_Internalname, context.localUtil.TToC( AV10BR_Encounter.gxTpr_Br_encounter_recheckdate, 10, 8, 0, 0, "/", ":", " "), context.localUtil.Format( AV10BR_Encounter.gxTpr_Br_encounter_recheckdate, "9999/99/99 99:99:99"), "", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavBr_encounter_br_encounter_recheckdate_Jsonclick, 0, "ReadonlyAttribute", "", "", "", "", 1, edtavBr_encounter_br_encounter_recheckdate_Enabled, 0, "text", "", 19, "chr", 1, "row", 19, 0, 0, 0, 1, -1, 0, false, "", "right", false, "HLP_BR_EncounterDetail.htm");
            GxWebStd.gx_bitmap( context, edtavBr_encounter_br_encounter_recheckdate_Internalname+"_dp_trigger", context.GetImagePath( "61b9b5d3-dff6-4d59-9b00-da61bc2cbe93", "", context.GetTheme( )), "", "", "", "", ((1==0)||(edtavBr_encounter_br_encounter_recheckdate_Enabled==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;", "", "", "", "", "", "", "", "", 1, false, false, "", "HLP_BR_EncounterDetail.htm");
            context.WriteHtmlTextNl( "</div>") ;
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
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</div>") ;
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divHtml_dvpanel_unnamedtable1_Internalname, 1, 0, "px", 0, "px", "Section", "left", "top", "", "", "div");
            /* User Defined Control */
            ucDvpanel_unnamedtable1.SetProperty("Width", Dvpanel_unnamedtable1_Width);
            ucDvpanel_unnamedtable1.SetProperty("AutoWidth", Dvpanel_unnamedtable1_Autowidth);
            ucDvpanel_unnamedtable1.SetProperty("AutoHeight", Dvpanel_unnamedtable1_Autoheight);
            ucDvpanel_unnamedtable1.SetProperty("Cls", Dvpanel_unnamedtable1_Cls);
            ucDvpanel_unnamedtable1.SetProperty("Title", Dvpanel_unnamedtable1_Title);
            ucDvpanel_unnamedtable1.SetProperty("Collapsible", Dvpanel_unnamedtable1_Collapsible);
            ucDvpanel_unnamedtable1.SetProperty("Collapsed", Dvpanel_unnamedtable1_Collapsed);
            ucDvpanel_unnamedtable1.SetProperty("ShowCollapseIcon", Dvpanel_unnamedtable1_Showcollapseicon);
            ucDvpanel_unnamedtable1.SetProperty("IconPosition", Dvpanel_unnamedtable1_Iconposition);
            ucDvpanel_unnamedtable1.SetProperty("AutoScroll", Dvpanel_unnamedtable1_Autoscroll);
            ucDvpanel_unnamedtable1.Render(context, "dvelop.gxbootstrap.panel", Dvpanel_unnamedtable1_Internalname, "DVPANEL_UNNAMEDTABLE1Container");
            context.WriteHtmlText( "<div class=\"gx_usercontrol_child\" id=\""+"DVPANEL_UNNAMEDTABLE1Container"+"Body"+"\" style=\"display:none;\">") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, divLayout_unnamedtable1_Internalname, 1, 0, "px", 0, "px", "Section", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "Section", "left", "top", " "+"data-gx-base-lib=\"bootstrapv3\""+" "+"data-abstract-form"+" ", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divUnnamedtable1_Internalname, 1, 0, "px", 0, "px", "", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divUnnamedtable4_Internalname, 1, 0, "px", 0, "px", "", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divUnnamedtablebr_encounter_br_encounter_israndapprove_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 MergeLabelCell", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblockbr_encounter_br_encounter_israndapprove_Internalname, "是否初审抽查", "", "", lblTextblockbr_encounter_br_encounter_israndapprove_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_BR_EncounterDetail.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, chkavBr_encounter_br_encounter_israndapprove_Internalname, "是否初审抽查", "col-sm-3 ReadonlyAttributeLabel", 0, true);
            /* Check box */
            ClassString = "ReadonlyAttribute";
            StyleString = "";
            GxWebStd.gx_checkbox_ctrl( context, chkavBr_encounter_br_encounter_israndapprove_Internalname, StringUtil.BoolToStr( AV10BR_Encounter.gxTpr_Br_encounter_israndapprove), "", "是否初审抽查", 1, chkavBr_encounter_br_encounter_israndapprove.Enabled, "true", "", StyleString, ClassString, "", "", "");
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
            GxWebStd.gx_div_start( context, divUnnamedtable5_Internalname, 1, 0, "px", 0, "px", "", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divUnnamedtablebr_encounter_br_encounter_israndapprover_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 MergeLabelCell", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblockbr_encounter_br_encounter_israndapprover_Internalname, "初审抽查通过操作人", "", "", lblTextblockbr_encounter_br_encounter_israndapprover_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_BR_EncounterDetail.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavBr_encounter_br_encounter_israndapprover_Internalname, "初审抽查通过操作人", "col-sm-3 ReadonlyAttributeLabel", 0, true);
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtavBr_encounter_br_encounter_israndapprover_Internalname, AV10BR_Encounter.gxTpr_Br_encounter_israndapprover, StringUtil.RTrim( context.localUtil.Format( AV10BR_Encounter.gxTpr_Br_encounter_israndapprover, "")), "", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavBr_encounter_br_encounter_israndapprover_Jsonclick, 0, "ReadonlyAttribute", "", "", "", "", 1, edtavBr_encounter_br_encounter_israndapprover_Enabled, 0, "text", "", 40, "chr", 1, "row", 40, 0, 0, 0, 1, -1, -1, false, "", "left", true, "HLP_BR_EncounterDetail.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divUnnamedtablebr_encounter_br_encounter_israndapprovedate_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 MergeLabelCell", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblockbr_encounter_br_encounter_israndapprovedate_Internalname, "初审抽查通过时间", "", "", lblTextblockbr_encounter_br_encounter_israndapprovedate_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_BR_EncounterDetail.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavBr_encounter_br_encounter_israndapprovedate_Internalname, "初审抽查通过时间", "col-sm-3 ReadonlyAttributeLabel", 0, true);
            /* Single line edit */
            context.WriteHtmlText( "<div id=\""+edtavBr_encounter_br_encounter_israndapprovedate_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtavBr_encounter_br_encounter_israndapprovedate_Internalname, context.localUtil.TToC( AV10BR_Encounter.gxTpr_Br_encounter_israndapprovedate, 10, 8, 0, 0, "/", ":", " "), context.localUtil.Format( AV10BR_Encounter.gxTpr_Br_encounter_israndapprovedate, "9999/99/99 99:99:99"), "", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavBr_encounter_br_encounter_israndapprovedate_Jsonclick, 0, "ReadonlyAttribute", "", "", "", "", 1, edtavBr_encounter_br_encounter_israndapprovedate_Enabled, 0, "text", "", 19, "chr", 1, "row", 19, 0, 0, 0, 1, -1, 0, false, "", "right", false, "HLP_BR_EncounterDetail.htm");
            GxWebStd.gx_bitmap( context, edtavBr_encounter_br_encounter_israndapprovedate_Internalname+"_dp_trigger", context.GetImagePath( "61b9b5d3-dff6-4d59-9b00-da61bc2cbe93", "", context.GetTheme( )), "", "", "", "", ((1==0)||(edtavBr_encounter_br_encounter_israndapprovedate_Enabled==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;", "", "", "", "", "", "", "", "", 1, false, false, "", "HLP_BR_EncounterDetail.htm");
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
            GxWebStd.gx_div_start( context, divUnnamedtablebr_encounter_br_encounter_israndnoapprover_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 MergeLabelCell", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblockbr_encounter_br_encounter_israndnoapprover_Internalname, "初审抽查不通过操作人", "", "", lblTextblockbr_encounter_br_encounter_israndnoapprover_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_BR_EncounterDetail.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavBr_encounter_br_encounter_israndnoapprover_Internalname, "初审抽查不通过操作人", "col-sm-3 ReadonlyAttributeLabel", 0, true);
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtavBr_encounter_br_encounter_israndnoapprover_Internalname, AV10BR_Encounter.gxTpr_Br_encounter_israndnoapprover, StringUtil.RTrim( context.localUtil.Format( AV10BR_Encounter.gxTpr_Br_encounter_israndnoapprover, "")), "", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavBr_encounter_br_encounter_israndnoapprover_Jsonclick, 0, "ReadonlyAttribute", "", "", "", "", 1, edtavBr_encounter_br_encounter_israndnoapprover_Enabled, 0, "text", "", 40, "chr", 1, "row", 40, 0, 0, 0, 1, -1, -1, false, "", "left", true, "HLP_BR_EncounterDetail.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divUnnamedtablebr_encounter_br_encounter_israndnoapprovedate_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 MergeLabelCell", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblockbr_encounter_br_encounter_israndnoapprovedate_Internalname, "初审抽查不通过时间", "", "", lblTextblockbr_encounter_br_encounter_israndnoapprovedate_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_BR_EncounterDetail.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavBr_encounter_br_encounter_israndnoapprovedate_Internalname, "初审抽查不通过时间", "col-sm-3 ReadonlyAttributeLabel", 0, true);
            /* Single line edit */
            context.WriteHtmlText( "<div id=\""+edtavBr_encounter_br_encounter_israndnoapprovedate_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtavBr_encounter_br_encounter_israndnoapprovedate_Internalname, context.localUtil.TToC( AV10BR_Encounter.gxTpr_Br_encounter_israndnoapprovedate, 10, 8, 0, 0, "/", ":", " "), context.localUtil.Format( AV10BR_Encounter.gxTpr_Br_encounter_israndnoapprovedate, "9999/99/99 99:99:99"), "", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavBr_encounter_br_encounter_israndnoapprovedate_Jsonclick, 0, "ReadonlyAttribute", "", "", "", "", 1, edtavBr_encounter_br_encounter_israndnoapprovedate_Enabled, 0, "text", "", 19, "chr", 1, "row", 19, 0, 0, 0, 1, -1, 0, false, "", "right", false, "HLP_BR_EncounterDetail.htm");
            GxWebStd.gx_bitmap( context, edtavBr_encounter_br_encounter_israndnoapprovedate_Internalname+"_dp_trigger", context.GetImagePath( "61b9b5d3-dff6-4d59-9b00-da61bc2cbe93", "", context.GetTheme( )), "", "", "", "", ((1==0)||(edtavBr_encounter_br_encounter_israndnoapprovedate_Enabled==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;", "", "", "", "", "", "", "", "", 1, false, false, "", "HLP_BR_EncounterDetail.htm");
            context.WriteHtmlTextNl( "</div>") ;
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
            context.WriteHtmlText( "</div>") ;
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divHtml_dvpanel_unnamedtable2_Internalname, 1, 0, "px", 0, "px", "Section", "left", "top", "", "", "div");
            /* User Defined Control */
            ucDvpanel_unnamedtable2.SetProperty("Width", Dvpanel_unnamedtable2_Width);
            ucDvpanel_unnamedtable2.SetProperty("AutoWidth", Dvpanel_unnamedtable2_Autowidth);
            ucDvpanel_unnamedtable2.SetProperty("AutoHeight", Dvpanel_unnamedtable2_Autoheight);
            ucDvpanel_unnamedtable2.SetProperty("Cls", Dvpanel_unnamedtable2_Cls);
            ucDvpanel_unnamedtable2.SetProperty("Title", Dvpanel_unnamedtable2_Title);
            ucDvpanel_unnamedtable2.SetProperty("Collapsible", Dvpanel_unnamedtable2_Collapsible);
            ucDvpanel_unnamedtable2.SetProperty("Collapsed", Dvpanel_unnamedtable2_Collapsed);
            ucDvpanel_unnamedtable2.SetProperty("ShowCollapseIcon", Dvpanel_unnamedtable2_Showcollapseicon);
            ucDvpanel_unnamedtable2.SetProperty("IconPosition", Dvpanel_unnamedtable2_Iconposition);
            ucDvpanel_unnamedtable2.SetProperty("AutoScroll", Dvpanel_unnamedtable2_Autoscroll);
            ucDvpanel_unnamedtable2.Render(context, "dvelop.gxbootstrap.panel", Dvpanel_unnamedtable2_Internalname, "DVPANEL_UNNAMEDTABLE2Container");
            context.WriteHtmlText( "<div class=\"gx_usercontrol_child\" id=\""+"DVPANEL_UNNAMEDTABLE2Container"+"Body"+"\" style=\"display:none;\">") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, divLayout_unnamedtable2_Internalname, 1, 0, "px", 0, "px", "Section", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "Section", "left", "top", " "+"data-gx-base-lib=\"bootstrapv3\""+" "+"data-abstract-form"+" ", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divUnnamedtable2_Internalname, 1, 0, "px", 0, "px", "", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divUnnamedtablebr_encounter_br_encounter_israndrecheck_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 MergeLabelCell", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblockbr_encounter_br_encounter_israndrecheck_Internalname, "是否复审抽查", "", "", lblTextblockbr_encounter_br_encounter_israndrecheck_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_BR_EncounterDetail.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, chkavBr_encounter_br_encounter_israndrecheck_Internalname, "是否复审抽查", "col-sm-3 ReadonlyAttributeLabel", 0, true);
            /* Check box */
            ClassString = "ReadonlyAttribute";
            StyleString = "";
            GxWebStd.gx_checkbox_ctrl( context, chkavBr_encounter_br_encounter_israndrecheck_Internalname, StringUtil.BoolToStr( AV10BR_Encounter.gxTpr_Br_encounter_israndrecheck), "", "是否复审抽查", 1, chkavBr_encounter_br_encounter_israndrecheck.Enabled, "true", "", StyleString, ClassString, "", "", "");
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
            GxWebStd.gx_div_start( context, divUnnamedtablebr_encounter_br_encounter_israndrecheckr_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 MergeLabelCell", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblockbr_encounter_br_encounter_israndrecheckr_Internalname, "复审抽查通过操作人", "", "", lblTextblockbr_encounter_br_encounter_israndrecheckr_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_BR_EncounterDetail.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavBr_encounter_br_encounter_israndrecheckr_Internalname, "复审抽查通过操作人", "col-sm-3 ReadonlyAttributeLabel", 0, true);
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtavBr_encounter_br_encounter_israndrecheckr_Internalname, AV10BR_Encounter.gxTpr_Br_encounter_israndrecheckr, StringUtil.RTrim( context.localUtil.Format( AV10BR_Encounter.gxTpr_Br_encounter_israndrecheckr, "")), "", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavBr_encounter_br_encounter_israndrecheckr_Jsonclick, 0, "ReadonlyAttribute", "", "", "", "", 1, edtavBr_encounter_br_encounter_israndrecheckr_Enabled, 0, "text", "", 40, "chr", 1, "row", 40, 0, 0, 0, 1, -1, -1, false, "", "left", true, "HLP_BR_EncounterDetail.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divUnnamedtablebr_encounter_br_encounter_israndrecheckdate_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 MergeLabelCell", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblockbr_encounter_br_encounter_israndrecheckdate_Internalname, "复审抽查通过时间", "", "", lblTextblockbr_encounter_br_encounter_israndrecheckdate_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_BR_EncounterDetail.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavBr_encounter_br_encounter_israndrecheckdate_Internalname, "复审抽查通过时间", "col-sm-3 ReadonlyAttributeLabel", 0, true);
            /* Single line edit */
            context.WriteHtmlText( "<div id=\""+edtavBr_encounter_br_encounter_israndrecheckdate_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtavBr_encounter_br_encounter_israndrecheckdate_Internalname, context.localUtil.TToC( AV10BR_Encounter.gxTpr_Br_encounter_israndrecheckdate, 10, 8, 0, 0, "/", ":", " "), context.localUtil.Format( AV10BR_Encounter.gxTpr_Br_encounter_israndrecheckdate, "9999/99/99 99:99:99"), "", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavBr_encounter_br_encounter_israndrecheckdate_Jsonclick, 0, "ReadonlyAttribute", "", "", "", "", 1, edtavBr_encounter_br_encounter_israndrecheckdate_Enabled, 0, "text", "", 19, "chr", 1, "row", 19, 0, 0, 0, 1, -1, 0, false, "", "right", false, "HLP_BR_EncounterDetail.htm");
            GxWebStd.gx_bitmap( context, edtavBr_encounter_br_encounter_israndrecheckdate_Internalname+"_dp_trigger", context.GetImagePath( "61b9b5d3-dff6-4d59-9b00-da61bc2cbe93", "", context.GetTheme( )), "", "", "", "", ((1==0)||(edtavBr_encounter_br_encounter_israndrecheckdate_Enabled==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;", "", "", "", "", "", "", "", "", 1, false, false, "", "HLP_BR_EncounterDetail.htm");
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
            GxWebStd.gx_div_start( context, divUnnamedtablebr_encounter_br_encounter_israndnorecheckr_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 MergeLabelCell", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblockbr_encounter_br_encounter_israndnorecheckr_Internalname, "复审抽查不通过操作人", "", "", lblTextblockbr_encounter_br_encounter_israndnorecheckr_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_BR_EncounterDetail.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavBr_encounter_br_encounter_israndnorecheckr_Internalname, "复审抽查不通过操作人", "col-sm-3 ReadonlyAttributeLabel", 0, true);
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtavBr_encounter_br_encounter_israndnorecheckr_Internalname, AV10BR_Encounter.gxTpr_Br_encounter_israndnorecheckr, StringUtil.RTrim( context.localUtil.Format( AV10BR_Encounter.gxTpr_Br_encounter_israndnorecheckr, "")), "", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavBr_encounter_br_encounter_israndnorecheckr_Jsonclick, 0, "ReadonlyAttribute", "", "", "", "", 1, edtavBr_encounter_br_encounter_israndnorecheckr_Enabled, 0, "text", "", 40, "chr", 1, "row", 40, 0, 0, 0, 1, -1, -1, false, "", "left", true, "HLP_BR_EncounterDetail.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divUnnamedtablebr_encounter_br_encounter_israndnorecheckdate_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 MergeLabelCell", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblockbr_encounter_br_encounter_israndnorecheckdate_Internalname, "复审抽查不通过时间", "", "", lblTextblockbr_encounter_br_encounter_israndnorecheckdate_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_BR_EncounterDetail.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavBr_encounter_br_encounter_israndnorecheckdate_Internalname, "复审抽查不通过时间", "col-sm-3 ReadonlyAttributeLabel", 0, true);
            /* Single line edit */
            context.WriteHtmlText( "<div id=\""+edtavBr_encounter_br_encounter_israndnorecheckdate_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtavBr_encounter_br_encounter_israndnorecheckdate_Internalname, context.localUtil.TToC( AV10BR_Encounter.gxTpr_Br_encounter_israndnorecheckdate, 10, 8, 0, 0, "/", ":", " "), context.localUtil.Format( AV10BR_Encounter.gxTpr_Br_encounter_israndnorecheckdate, "9999/99/99 99:99:99"), "", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavBr_encounter_br_encounter_israndnorecheckdate_Jsonclick, 0, "ReadonlyAttribute", "", "", "", "", 1, edtavBr_encounter_br_encounter_israndnorecheckdate_Enabled, 0, "text", "", 19, "chr", 1, "row", 19, 0, 0, 0, 1, -1, 0, false, "", "right", false, "HLP_BR_EncounterDetail.htm");
            GxWebStd.gx_bitmap( context, edtavBr_encounter_br_encounter_israndnorecheckdate_Internalname+"_dp_trigger", context.GetImagePath( "61b9b5d3-dff6-4d59-9b00-da61bc2cbe93", "", context.GetTheme( )), "", "", "", "", ((1==0)||(edtavBr_encounter_br_encounter_israndnorecheckdate_Enabled==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;", "", "", "", "", "", "", "", "", 1, false, false, "", "HLP_BR_EncounterDetail.htm");
            context.WriteHtmlTextNl( "</div>") ;
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
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divHtml_dvpanel_unnamedtable3_Internalname, 1, 0, "px", 0, "px", "Section", "left", "top", "", "", "div");
            /* User Defined Control */
            ucDvpanel_unnamedtable3.SetProperty("Width", Dvpanel_unnamedtable3_Width);
            ucDvpanel_unnamedtable3.SetProperty("AutoWidth", Dvpanel_unnamedtable3_Autowidth);
            ucDvpanel_unnamedtable3.SetProperty("AutoHeight", Dvpanel_unnamedtable3_Autoheight);
            ucDvpanel_unnamedtable3.SetProperty("Cls", Dvpanel_unnamedtable3_Cls);
            ucDvpanel_unnamedtable3.SetProperty("Title", Dvpanel_unnamedtable3_Title);
            ucDvpanel_unnamedtable3.SetProperty("Collapsible", Dvpanel_unnamedtable3_Collapsible);
            ucDvpanel_unnamedtable3.SetProperty("Collapsed", Dvpanel_unnamedtable3_Collapsed);
            ucDvpanel_unnamedtable3.SetProperty("ShowCollapseIcon", Dvpanel_unnamedtable3_Showcollapseicon);
            ucDvpanel_unnamedtable3.SetProperty("IconPosition", Dvpanel_unnamedtable3_Iconposition);
            ucDvpanel_unnamedtable3.SetProperty("AutoScroll", Dvpanel_unnamedtable3_Autoscroll);
            ucDvpanel_unnamedtable3.Render(context, "dvelop.gxbootstrap.panel", Dvpanel_unnamedtable3_Internalname, "DVPANEL_UNNAMEDTABLE3Container");
            context.WriteHtmlText( "<div class=\"gx_usercontrol_child\" id=\""+"DVPANEL_UNNAMEDTABLE3Container"+"Body"+"\" style=\"display:none;\">") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, divLayout_unnamedtable3_Internalname, 1, 0, "px", 0, "px", "Section", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "Section", "left", "top", " "+"data-gx-base-lib=\"bootstrapv3\""+" "+"data-abstract-form"+" ", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divUnnamedtable3_Internalname, 1, 0, "px", 0, "px", "", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divUnnamedtablebr_encounter_br_encounter_isupdate_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 MergeLabelCell", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblockbr_encounter_br_encounter_isupdate_Internalname, "是否修改", "", "", lblTextblockbr_encounter_br_encounter_isupdate_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_BR_EncounterDetail.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, chkavBr_encounter_br_encounter_isupdate_Internalname, "是否修改", "col-sm-3 ReadonlyAttributeLabel", 0, true);
            /* Check box */
            ClassString = "ReadonlyAttribute";
            StyleString = "";
            GxWebStd.gx_checkbox_ctrl( context, chkavBr_encounter_br_encounter_isupdate_Internalname, StringUtil.BoolToStr( AV10BR_Encounter.gxTpr_Br_encounter_isupdate), "", "是否修改", 1, chkavBr_encounter_br_encounter_isupdate.Enabled, "true", "", StyleString, ClassString, "", "", "");
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
            GxWebStd.gx_div_start( context, divUnnamedtablebr_encounter_br_encounter_upddate_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 MergeLabelCell", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblockbr_encounter_br_encounter_upddate_Internalname, "修改时间", "", "", lblTextblockbr_encounter_br_encounter_upddate_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_BR_EncounterDetail.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavBr_encounter_br_encounter_upddate_Internalname, "修改时间", "col-sm-3 ReadonlyAttributeLabel", 0, true);
            /* Single line edit */
            context.WriteHtmlText( "<div id=\""+edtavBr_encounter_br_encounter_upddate_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtavBr_encounter_br_encounter_upddate_Internalname, context.localUtil.TToC( AV10BR_Encounter.gxTpr_Br_encounter_upddate, 10, 8, 0, 0, "/", ":", " "), context.localUtil.Format( AV10BR_Encounter.gxTpr_Br_encounter_upddate, "9999/99/99 99:99:99"), "", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavBr_encounter_br_encounter_upddate_Jsonclick, 0, "ReadonlyAttribute", "", "", "", "", 1, edtavBr_encounter_br_encounter_upddate_Enabled, 0, "text", "", 19, "chr", 1, "row", 19, 0, 0, 0, 1, -1, 0, false, "", "right", false, "HLP_BR_EncounterDetail.htm");
            GxWebStd.gx_bitmap( context, edtavBr_encounter_br_encounter_upddate_Internalname+"_dp_trigger", context.GetImagePath( "61b9b5d3-dff6-4d59-9b00-da61bc2cbe93", "", context.GetTheme( )), "", "", "", "", ((1==0)||(edtavBr_encounter_br_encounter_upddate_Enabled==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;", "", "", "", "", "", "", "", "", 1, false, false, "", "HLP_BR_EncounterDetail.htm");
            context.WriteHtmlTextNl( "</div>") ;
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divUnnamedtablebr_encounter_br_encounter_upduser_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 MergeLabelCell", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblockbr_encounter_br_encounter_upduser_Internalname, "修改者", "", "", lblTextblockbr_encounter_br_encounter_upduser_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_BR_EncounterDetail.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavBr_encounter_br_encounter_upduser_Internalname, "修改者", "col-sm-3 ReadonlyAttributeLabel", 0, true);
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtavBr_encounter_br_encounter_upduser_Internalname, AV10BR_Encounter.gxTpr_Br_encounter_upduser, StringUtil.RTrim( context.localUtil.Format( AV10BR_Encounter.gxTpr_Br_encounter_upduser, "")), "", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavBr_encounter_br_encounter_upduser_Jsonclick, 0, "ReadonlyAttribute", "", "", "", "", 1, edtavBr_encounter_br_encounter_upduser_Enabled, 0, "text", "", 40, "chr", 1, "row", 40, 0, 0, 0, 1, -1, -1, false, "", "left", true, "HLP_BR_EncounterDetail.htm");
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
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
         }
         wbLoad = true;
      }

      protected void START4E2( )
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
         STRUP4E0( ) ;
      }

      protected void WS4E2( )
      {
         START4E2( ) ;
         EVT4E2( ) ;
      }

      protected void EVT4E2( )
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
                              E114E2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "REFRESH") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              /* Execute user event: Refresh */
                              E124E2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "LOAD") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              /* Execute user event: Load */
                              E134E2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "ENTER") == 0 )
                           {
                              context.wbHandled = 1;
                              if ( ! wbErr )
                              {
                                 Rfr0gs = false;
                                 if ( ! Rfr0gs )
                                 {
                                 }
                                 dynload_actions( ) ;
                              }
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

      protected void WE4E2( )
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

      protected void PA4E2( )
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
               GX_FocusControl = edtavBr_encounter_br_encounter_crtdisplayname_Internalname;
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
         RF4E2( ) ;
         if ( isFullAjaxMode( ) )
         {
            send_integrity_footer_hashes( ) ;
         }
      }

      protected void initialize_formulas( )
      {
         /* GeneXus formulas. */
         context.Gx_err = 0;
         edtavBr_encounter_br_encounter_crtdisplayname_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavBr_encounter_br_encounter_crtdisplayname_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavBr_encounter_br_encounter_crtdisplayname_Enabled), 5, 0)), true);
         edtavBr_encounter_br_encounter_crtdate_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavBr_encounter_br_encounter_crtdate_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavBr_encounter_br_encounter_crtdate_Enabled), 5, 0)), true);
         edtavBr_encounter_br_encounter_submituser_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavBr_encounter_br_encounter_submituser_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavBr_encounter_br_encounter_submituser_Enabled), 5, 0)), true);
         edtavBr_encounter_br_encounter_submitdate_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavBr_encounter_br_encounter_submitdate_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavBr_encounter_br_encounter_submitdate_Enabled), 5, 0)), true);
         edtavBr_encounter_br_encounter_approver_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavBr_encounter_br_encounter_approver_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavBr_encounter_br_encounter_approver_Enabled), 5, 0)), true);
         edtavBr_encounter_br_encounter_approvedate_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavBr_encounter_br_encounter_approvedate_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavBr_encounter_br_encounter_approvedate_Enabled), 5, 0)), true);
         edtavBr_encounter_br_encounter_recheckuser_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavBr_encounter_br_encounter_recheckuser_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavBr_encounter_br_encounter_recheckuser_Enabled), 5, 0)), true);
         edtavBr_encounter_br_encounter_recheckdate_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavBr_encounter_br_encounter_recheckdate_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavBr_encounter_br_encounter_recheckdate_Enabled), 5, 0)), true);
         chkavBr_encounter_br_encounter_israndapprove.Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, chkavBr_encounter_br_encounter_israndapprove_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(chkavBr_encounter_br_encounter_israndapprove.Enabled), 5, 0)), true);
         edtavBr_encounter_br_encounter_israndapprover_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavBr_encounter_br_encounter_israndapprover_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavBr_encounter_br_encounter_israndapprover_Enabled), 5, 0)), true);
         edtavBr_encounter_br_encounter_israndapprovedate_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavBr_encounter_br_encounter_israndapprovedate_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavBr_encounter_br_encounter_israndapprovedate_Enabled), 5, 0)), true);
         edtavBr_encounter_br_encounter_israndnoapprover_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavBr_encounter_br_encounter_israndnoapprover_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavBr_encounter_br_encounter_israndnoapprover_Enabled), 5, 0)), true);
         edtavBr_encounter_br_encounter_israndnoapprovedate_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavBr_encounter_br_encounter_israndnoapprovedate_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavBr_encounter_br_encounter_israndnoapprovedate_Enabled), 5, 0)), true);
         chkavBr_encounter_br_encounter_israndrecheck.Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, chkavBr_encounter_br_encounter_israndrecheck_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(chkavBr_encounter_br_encounter_israndrecheck.Enabled), 5, 0)), true);
         edtavBr_encounter_br_encounter_israndrecheckr_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavBr_encounter_br_encounter_israndrecheckr_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavBr_encounter_br_encounter_israndrecheckr_Enabled), 5, 0)), true);
         edtavBr_encounter_br_encounter_israndrecheckdate_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavBr_encounter_br_encounter_israndrecheckdate_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavBr_encounter_br_encounter_israndrecheckdate_Enabled), 5, 0)), true);
         edtavBr_encounter_br_encounter_israndnorecheckr_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavBr_encounter_br_encounter_israndnorecheckr_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavBr_encounter_br_encounter_israndnorecheckr_Enabled), 5, 0)), true);
         edtavBr_encounter_br_encounter_israndnorecheckdate_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavBr_encounter_br_encounter_israndnorecheckdate_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavBr_encounter_br_encounter_israndnorecheckdate_Enabled), 5, 0)), true);
         chkavBr_encounter_br_encounter_isupdate.Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, chkavBr_encounter_br_encounter_isupdate_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(chkavBr_encounter_br_encounter_isupdate.Enabled), 5, 0)), true);
         edtavBr_encounter_br_encounter_upddate_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavBr_encounter_br_encounter_upddate_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavBr_encounter_br_encounter_upddate_Enabled), 5, 0)), true);
         edtavBr_encounter_br_encounter_upduser_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavBr_encounter_br_encounter_upduser_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavBr_encounter_br_encounter_upduser_Enabled), 5, 0)), true);
      }

      protected void RF4E2( )
      {
         initialize_formulas( ) ;
         clear_multi_value_controls( ) ;
         /* Execute user event: Refresh */
         E124E2 ();
         gxdyncontrolsrefreshing = true;
         fix_multi_value_controls( ) ;
         gxdyncontrolsrefreshing = false;
         if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
         {
            /* Execute user event: Load */
            E134E2 ();
            WB4E0( ) ;
         }
      }

      protected void send_integrity_lvl_hashes4E2( )
      {
      }

      protected void STRUP4E0( )
      {
         /* Before Start, stand alone formulas. */
         context.Gx_err = 0;
         edtavBr_encounter_br_encounter_crtdisplayname_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavBr_encounter_br_encounter_crtdisplayname_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavBr_encounter_br_encounter_crtdisplayname_Enabled), 5, 0)), true);
         edtavBr_encounter_br_encounter_crtdate_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavBr_encounter_br_encounter_crtdate_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavBr_encounter_br_encounter_crtdate_Enabled), 5, 0)), true);
         edtavBr_encounter_br_encounter_submituser_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavBr_encounter_br_encounter_submituser_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavBr_encounter_br_encounter_submituser_Enabled), 5, 0)), true);
         edtavBr_encounter_br_encounter_submitdate_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavBr_encounter_br_encounter_submitdate_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavBr_encounter_br_encounter_submitdate_Enabled), 5, 0)), true);
         edtavBr_encounter_br_encounter_approver_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavBr_encounter_br_encounter_approver_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavBr_encounter_br_encounter_approver_Enabled), 5, 0)), true);
         edtavBr_encounter_br_encounter_approvedate_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavBr_encounter_br_encounter_approvedate_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavBr_encounter_br_encounter_approvedate_Enabled), 5, 0)), true);
         edtavBr_encounter_br_encounter_recheckuser_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavBr_encounter_br_encounter_recheckuser_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavBr_encounter_br_encounter_recheckuser_Enabled), 5, 0)), true);
         edtavBr_encounter_br_encounter_recheckdate_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavBr_encounter_br_encounter_recheckdate_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavBr_encounter_br_encounter_recheckdate_Enabled), 5, 0)), true);
         chkavBr_encounter_br_encounter_israndapprove.Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, chkavBr_encounter_br_encounter_israndapprove_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(chkavBr_encounter_br_encounter_israndapprove.Enabled), 5, 0)), true);
         edtavBr_encounter_br_encounter_israndapprover_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavBr_encounter_br_encounter_israndapprover_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavBr_encounter_br_encounter_israndapprover_Enabled), 5, 0)), true);
         edtavBr_encounter_br_encounter_israndapprovedate_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavBr_encounter_br_encounter_israndapprovedate_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavBr_encounter_br_encounter_israndapprovedate_Enabled), 5, 0)), true);
         edtavBr_encounter_br_encounter_israndnoapprover_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavBr_encounter_br_encounter_israndnoapprover_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavBr_encounter_br_encounter_israndnoapprover_Enabled), 5, 0)), true);
         edtavBr_encounter_br_encounter_israndnoapprovedate_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavBr_encounter_br_encounter_israndnoapprovedate_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavBr_encounter_br_encounter_israndnoapprovedate_Enabled), 5, 0)), true);
         chkavBr_encounter_br_encounter_israndrecheck.Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, chkavBr_encounter_br_encounter_israndrecheck_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(chkavBr_encounter_br_encounter_israndrecheck.Enabled), 5, 0)), true);
         edtavBr_encounter_br_encounter_israndrecheckr_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavBr_encounter_br_encounter_israndrecheckr_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavBr_encounter_br_encounter_israndrecheckr_Enabled), 5, 0)), true);
         edtavBr_encounter_br_encounter_israndrecheckdate_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavBr_encounter_br_encounter_israndrecheckdate_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavBr_encounter_br_encounter_israndrecheckdate_Enabled), 5, 0)), true);
         edtavBr_encounter_br_encounter_israndnorecheckr_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavBr_encounter_br_encounter_israndnorecheckr_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavBr_encounter_br_encounter_israndnorecheckr_Enabled), 5, 0)), true);
         edtavBr_encounter_br_encounter_israndnorecheckdate_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavBr_encounter_br_encounter_israndnorecheckdate_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavBr_encounter_br_encounter_israndnorecheckdate_Enabled), 5, 0)), true);
         chkavBr_encounter_br_encounter_isupdate.Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, chkavBr_encounter_br_encounter_isupdate_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(chkavBr_encounter_br_encounter_isupdate.Enabled), 5, 0)), true);
         edtavBr_encounter_br_encounter_upddate_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavBr_encounter_br_encounter_upddate_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavBr_encounter_br_encounter_upddate_Enabled), 5, 0)), true);
         edtavBr_encounter_br_encounter_upduser_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavBr_encounter_br_encounter_upduser_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavBr_encounter_br_encounter_upduser_Enabled), 5, 0)), true);
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0;
         /* Execute user event: Start */
         E114E2 ();
         context.wbGlbDoneStart = 1;
         /* After Start, stand alone formulas. */
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read saved SDTs. */
            ajax_req_read_hidden_sdt(cgiGet( "Br_encounter"), AV10BR_Encounter);
            /* Read variables values. */
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
            Dvpanel_unnamedtable1_Width = cgiGet( "DVPANEL_UNNAMEDTABLE1_Width");
            Dvpanel_unnamedtable1_Cls = cgiGet( "DVPANEL_UNNAMEDTABLE1_Cls");
            Dvpanel_unnamedtable1_Title = cgiGet( "DVPANEL_UNNAMEDTABLE1_Title");
            Dvpanel_unnamedtable1_Collapsible = StringUtil.StrToBool( cgiGet( "DVPANEL_UNNAMEDTABLE1_Collapsible"));
            Dvpanel_unnamedtable1_Collapsed = StringUtil.StrToBool( cgiGet( "DVPANEL_UNNAMEDTABLE1_Collapsed"));
            Dvpanel_unnamedtable1_Autowidth = StringUtil.StrToBool( cgiGet( "DVPANEL_UNNAMEDTABLE1_Autowidth"));
            Dvpanel_unnamedtable1_Autoheight = StringUtil.StrToBool( cgiGet( "DVPANEL_UNNAMEDTABLE1_Autoheight"));
            Dvpanel_unnamedtable1_Showcollapseicon = StringUtil.StrToBool( cgiGet( "DVPANEL_UNNAMEDTABLE1_Showcollapseicon"));
            Dvpanel_unnamedtable1_Iconposition = cgiGet( "DVPANEL_UNNAMEDTABLE1_Iconposition");
            Dvpanel_unnamedtable1_Autoscroll = StringUtil.StrToBool( cgiGet( "DVPANEL_UNNAMEDTABLE1_Autoscroll"));
            Dvpanel_unnamedtable2_Width = cgiGet( "DVPANEL_UNNAMEDTABLE2_Width");
            Dvpanel_unnamedtable2_Cls = cgiGet( "DVPANEL_UNNAMEDTABLE2_Cls");
            Dvpanel_unnamedtable2_Title = cgiGet( "DVPANEL_UNNAMEDTABLE2_Title");
            Dvpanel_unnamedtable2_Collapsible = StringUtil.StrToBool( cgiGet( "DVPANEL_UNNAMEDTABLE2_Collapsible"));
            Dvpanel_unnamedtable2_Collapsed = StringUtil.StrToBool( cgiGet( "DVPANEL_UNNAMEDTABLE2_Collapsed"));
            Dvpanel_unnamedtable2_Autowidth = StringUtil.StrToBool( cgiGet( "DVPANEL_UNNAMEDTABLE2_Autowidth"));
            Dvpanel_unnamedtable2_Autoheight = StringUtil.StrToBool( cgiGet( "DVPANEL_UNNAMEDTABLE2_Autoheight"));
            Dvpanel_unnamedtable2_Showcollapseicon = StringUtil.StrToBool( cgiGet( "DVPANEL_UNNAMEDTABLE2_Showcollapseicon"));
            Dvpanel_unnamedtable2_Iconposition = cgiGet( "DVPANEL_UNNAMEDTABLE2_Iconposition");
            Dvpanel_unnamedtable2_Autoscroll = StringUtil.StrToBool( cgiGet( "DVPANEL_UNNAMEDTABLE2_Autoscroll"));
            Dvpanel_unnamedtable3_Width = cgiGet( "DVPANEL_UNNAMEDTABLE3_Width");
            Dvpanel_unnamedtable3_Cls = cgiGet( "DVPANEL_UNNAMEDTABLE3_Cls");
            Dvpanel_unnamedtable3_Title = cgiGet( "DVPANEL_UNNAMEDTABLE3_Title");
            Dvpanel_unnamedtable3_Collapsible = StringUtil.StrToBool( cgiGet( "DVPANEL_UNNAMEDTABLE3_Collapsible"));
            Dvpanel_unnamedtable3_Collapsed = StringUtil.StrToBool( cgiGet( "DVPANEL_UNNAMEDTABLE3_Collapsed"));
            Dvpanel_unnamedtable3_Autowidth = StringUtil.StrToBool( cgiGet( "DVPANEL_UNNAMEDTABLE3_Autowidth"));
            Dvpanel_unnamedtable3_Autoheight = StringUtil.StrToBool( cgiGet( "DVPANEL_UNNAMEDTABLE3_Autoheight"));
            Dvpanel_unnamedtable3_Showcollapseicon = StringUtil.StrToBool( cgiGet( "DVPANEL_UNNAMEDTABLE3_Showcollapseicon"));
            Dvpanel_unnamedtable3_Iconposition = cgiGet( "DVPANEL_UNNAMEDTABLE3_Iconposition");
            Dvpanel_unnamedtable3_Autoscroll = StringUtil.StrToBool( cgiGet( "DVPANEL_UNNAMEDTABLE3_Autoscroll"));
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
         E114E2 ();
         if (returnInSub) return;
      }

      protected void E114E2( )
      {
         /* Start Routine */
         AV10BR_Encounter.Load(AV11iBR_EncounterID);
      }

      protected void S112( )
      {
         /* 'SHOW MESSAGES' Routine */
         AV35GXV22 = 1;
         while ( AV35GXV22 <= AV8Messages.Count )
         {
            AV7Message = ((SdtMessages_Message)AV8Messages.Item(AV35GXV22));
            GX_msglist.addItem(AV7Message.gxTpr_Description);
            AV35GXV22 = (int)(AV35GXV22+1);
         }
      }

      protected void E124E2( )
      {
         /* Refresh Routine */
         new GeneXus.Programs.wwpbaseobjects.loadwwpcontext(context ).execute( out  AV9Context) ;
      }

      protected void nextLoad( )
      {
      }

      protected void E134E2( )
      {
         /* Load Routine */
      }

      public override void setparameters( Object[] obj )
      {
         createObjects();
         initialize();
         AV11iBR_EncounterID = Convert.ToInt64(getParm(obj,0));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11iBR_EncounterID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11iBR_EncounterID), 18, 0)));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vIBR_ENCOUNTERID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV11iBR_EncounterID), "ZZZZZZZZZZZZZZZZZZ"), context));
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
         PA4E2( ) ;
         WS4E2( ) ;
         WE4E2( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?20202281511545", true);
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
         context.AddJavascriptSource("br_encounterdetail.js", "?20202281511545", false);
         context.AddJavascriptSource("DVelop/Bootstrap/Shared/DVelopBootstrap.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/Panel/BootstrapPanelRender.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/Shared/DVelopBootstrap.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/Panel/BootstrapPanelRender.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/Shared/DVelopBootstrap.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/Panel/BootstrapPanelRender.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/Shared/DVelopBootstrap.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/Panel/BootstrapPanelRender.js", "", false);
         /* End function include_jscripts */
      }

      protected void init_web_controls( )
      {
         chkavBr_encounter_br_encounter_israndapprove.Name = "BR_ENCOUNTER_BR_ENCOUNTER_ISRANDAPPROVE";
         chkavBr_encounter_br_encounter_israndapprove.WebTags = "";
         chkavBr_encounter_br_encounter_israndapprove.Caption = "";
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, chkavBr_encounter_br_encounter_israndapprove_Internalname, "TitleCaption", chkavBr_encounter_br_encounter_israndapprove.Caption, true);
         chkavBr_encounter_br_encounter_israndapprove.CheckedValue = "false";
         chkavBr_encounter_br_encounter_israndrecheck.Name = "BR_ENCOUNTER_BR_ENCOUNTER_ISRANDRECHECK";
         chkavBr_encounter_br_encounter_israndrecheck.WebTags = "";
         chkavBr_encounter_br_encounter_israndrecheck.Caption = "";
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, chkavBr_encounter_br_encounter_israndrecheck_Internalname, "TitleCaption", chkavBr_encounter_br_encounter_israndrecheck.Caption, true);
         chkavBr_encounter_br_encounter_israndrecheck.CheckedValue = "false";
         chkavBr_encounter_br_encounter_isupdate.Name = "BR_ENCOUNTER_BR_ENCOUNTER_ISUPDATE";
         chkavBr_encounter_br_encounter_isupdate.WebTags = "";
         chkavBr_encounter_br_encounter_isupdate.Caption = "";
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, chkavBr_encounter_br_encounter_isupdate_Internalname, "TitleCaption", chkavBr_encounter_br_encounter_isupdate.Caption, true);
         chkavBr_encounter_br_encounter_isupdate.CheckedValue = "false";
         /* End function init_web_controls */
      }

      protected void init_default_properties( )
      {
         bttBtn_cancel_Internalname = "BTN_CANCEL";
         lblTextblockbr_encounter_br_encounter_crtdisplayname_Internalname = "TEXTBLOCKBR_ENCOUNTER_BR_ENCOUNTER_CRTDISPLAYNAME";
         edtavBr_encounter_br_encounter_crtdisplayname_Internalname = "BR_ENCOUNTER_BR_ENCOUNTER_CRTDISPLAYNAME";
         divUnnamedtablebr_encounter_br_encounter_crtdisplayname_Internalname = "UNNAMEDTABLEBR_ENCOUNTER_BR_ENCOUNTER_CRTDISPLAYNAME";
         lblTextblockbr_encounter_br_encounter_crtdate_Internalname = "TEXTBLOCKBR_ENCOUNTER_BR_ENCOUNTER_CRTDATE";
         edtavBr_encounter_br_encounter_crtdate_Internalname = "BR_ENCOUNTER_BR_ENCOUNTER_CRTDATE";
         divUnnamedtablebr_encounter_br_encounter_crtdate_Internalname = "UNNAMEDTABLEBR_ENCOUNTER_BR_ENCOUNTER_CRTDATE";
         divUnnamedtable7_Internalname = "UNNAMEDTABLE7";
         lblTextblockbr_encounter_br_encounter_submituser_Internalname = "TEXTBLOCKBR_ENCOUNTER_BR_ENCOUNTER_SUBMITUSER";
         edtavBr_encounter_br_encounter_submituser_Internalname = "BR_ENCOUNTER_BR_ENCOUNTER_SUBMITUSER";
         divUnnamedtablebr_encounter_br_encounter_submituser_Internalname = "UNNAMEDTABLEBR_ENCOUNTER_BR_ENCOUNTER_SUBMITUSER";
         lblTextblockbr_encounter_br_encounter_submitdate_Internalname = "TEXTBLOCKBR_ENCOUNTER_BR_ENCOUNTER_SUBMITDATE";
         edtavBr_encounter_br_encounter_submitdate_Internalname = "BR_ENCOUNTER_BR_ENCOUNTER_SUBMITDATE";
         divUnnamedtablebr_encounter_br_encounter_submitdate_Internalname = "UNNAMEDTABLEBR_ENCOUNTER_BR_ENCOUNTER_SUBMITDATE";
         divUnnamedtable8_Internalname = "UNNAMEDTABLE8";
         lblTextblockbr_encounter_br_encounter_approver_Internalname = "TEXTBLOCKBR_ENCOUNTER_BR_ENCOUNTER_APPROVER";
         edtavBr_encounter_br_encounter_approver_Internalname = "BR_ENCOUNTER_BR_ENCOUNTER_APPROVER";
         divUnnamedtablebr_encounter_br_encounter_approver_Internalname = "UNNAMEDTABLEBR_ENCOUNTER_BR_ENCOUNTER_APPROVER";
         lblTextblockbr_encounter_br_encounter_approvedate_Internalname = "TEXTBLOCKBR_ENCOUNTER_BR_ENCOUNTER_APPROVEDATE";
         edtavBr_encounter_br_encounter_approvedate_Internalname = "BR_ENCOUNTER_BR_ENCOUNTER_APPROVEDATE";
         divUnnamedtablebr_encounter_br_encounter_approvedate_Internalname = "UNNAMEDTABLEBR_ENCOUNTER_BR_ENCOUNTER_APPROVEDATE";
         divUnnamedtable9_Internalname = "UNNAMEDTABLE9";
         lblTextblockbr_encounter_br_encounter_recheckuser_Internalname = "TEXTBLOCKBR_ENCOUNTER_BR_ENCOUNTER_RECHECKUSER";
         edtavBr_encounter_br_encounter_recheckuser_Internalname = "BR_ENCOUNTER_BR_ENCOUNTER_RECHECKUSER";
         divUnnamedtablebr_encounter_br_encounter_recheckuser_Internalname = "UNNAMEDTABLEBR_ENCOUNTER_BR_ENCOUNTER_RECHECKUSER";
         lblTextblockbr_encounter_br_encounter_recheckdate_Internalname = "TEXTBLOCKBR_ENCOUNTER_BR_ENCOUNTER_RECHECKDATE";
         edtavBr_encounter_br_encounter_recheckdate_Internalname = "BR_ENCOUNTER_BR_ENCOUNTER_RECHECKDATE";
         divUnnamedtablebr_encounter_br_encounter_recheckdate_Internalname = "UNNAMEDTABLEBR_ENCOUNTER_BR_ENCOUNTER_RECHECKDATE";
         divUnnamedtable10_Internalname = "UNNAMEDTABLE10";
         divUnnamedtable6_Internalname = "UNNAMEDTABLE6";
         divTableattributes_Internalname = "TABLEATTRIBUTES";
         divLayout_tableattributes_Internalname = "LAYOUT_TABLEATTRIBUTES";
         Dvpanel_tableattributes_Internalname = "DVPANEL_TABLEATTRIBUTES";
         divHtml_dvpanel_tableattributes_Internalname = "HTML_DVPANEL_TABLEATTRIBUTES";
         lblTextblockbr_encounter_br_encounter_israndapprove_Internalname = "TEXTBLOCKBR_ENCOUNTER_BR_ENCOUNTER_ISRANDAPPROVE";
         chkavBr_encounter_br_encounter_israndapprove_Internalname = "BR_ENCOUNTER_BR_ENCOUNTER_ISRANDAPPROVE";
         divUnnamedtablebr_encounter_br_encounter_israndapprove_Internalname = "UNNAMEDTABLEBR_ENCOUNTER_BR_ENCOUNTER_ISRANDAPPROVE";
         divUnnamedtable4_Internalname = "UNNAMEDTABLE4";
         lblTextblockbr_encounter_br_encounter_israndapprover_Internalname = "TEXTBLOCKBR_ENCOUNTER_BR_ENCOUNTER_ISRANDAPPROVER";
         edtavBr_encounter_br_encounter_israndapprover_Internalname = "BR_ENCOUNTER_BR_ENCOUNTER_ISRANDAPPROVER";
         divUnnamedtablebr_encounter_br_encounter_israndapprover_Internalname = "UNNAMEDTABLEBR_ENCOUNTER_BR_ENCOUNTER_ISRANDAPPROVER";
         lblTextblockbr_encounter_br_encounter_israndapprovedate_Internalname = "TEXTBLOCKBR_ENCOUNTER_BR_ENCOUNTER_ISRANDAPPROVEDATE";
         edtavBr_encounter_br_encounter_israndapprovedate_Internalname = "BR_ENCOUNTER_BR_ENCOUNTER_ISRANDAPPROVEDATE";
         divUnnamedtablebr_encounter_br_encounter_israndapprovedate_Internalname = "UNNAMEDTABLEBR_ENCOUNTER_BR_ENCOUNTER_ISRANDAPPROVEDATE";
         lblTextblockbr_encounter_br_encounter_israndnoapprover_Internalname = "TEXTBLOCKBR_ENCOUNTER_BR_ENCOUNTER_ISRANDNOAPPROVER";
         edtavBr_encounter_br_encounter_israndnoapprover_Internalname = "BR_ENCOUNTER_BR_ENCOUNTER_ISRANDNOAPPROVER";
         divUnnamedtablebr_encounter_br_encounter_israndnoapprover_Internalname = "UNNAMEDTABLEBR_ENCOUNTER_BR_ENCOUNTER_ISRANDNOAPPROVER";
         lblTextblockbr_encounter_br_encounter_israndnoapprovedate_Internalname = "TEXTBLOCKBR_ENCOUNTER_BR_ENCOUNTER_ISRANDNOAPPROVEDATE";
         edtavBr_encounter_br_encounter_israndnoapprovedate_Internalname = "BR_ENCOUNTER_BR_ENCOUNTER_ISRANDNOAPPROVEDATE";
         divUnnamedtablebr_encounter_br_encounter_israndnoapprovedate_Internalname = "UNNAMEDTABLEBR_ENCOUNTER_BR_ENCOUNTER_ISRANDNOAPPROVEDATE";
         divUnnamedtable5_Internalname = "UNNAMEDTABLE5";
         divUnnamedtable1_Internalname = "UNNAMEDTABLE1";
         divLayout_unnamedtable1_Internalname = "LAYOUT_UNNAMEDTABLE1";
         Dvpanel_unnamedtable1_Internalname = "DVPANEL_UNNAMEDTABLE1";
         divHtml_dvpanel_unnamedtable1_Internalname = "HTML_DVPANEL_UNNAMEDTABLE1";
         lblTextblockbr_encounter_br_encounter_israndrecheck_Internalname = "TEXTBLOCKBR_ENCOUNTER_BR_ENCOUNTER_ISRANDRECHECK";
         chkavBr_encounter_br_encounter_israndrecheck_Internalname = "BR_ENCOUNTER_BR_ENCOUNTER_ISRANDRECHECK";
         divUnnamedtablebr_encounter_br_encounter_israndrecheck_Internalname = "UNNAMEDTABLEBR_ENCOUNTER_BR_ENCOUNTER_ISRANDRECHECK";
         lblTextblockbr_encounter_br_encounter_israndrecheckr_Internalname = "TEXTBLOCKBR_ENCOUNTER_BR_ENCOUNTER_ISRANDRECHECKR";
         edtavBr_encounter_br_encounter_israndrecheckr_Internalname = "BR_ENCOUNTER_BR_ENCOUNTER_ISRANDRECHECKR";
         divUnnamedtablebr_encounter_br_encounter_israndrecheckr_Internalname = "UNNAMEDTABLEBR_ENCOUNTER_BR_ENCOUNTER_ISRANDRECHECKR";
         lblTextblockbr_encounter_br_encounter_israndrecheckdate_Internalname = "TEXTBLOCKBR_ENCOUNTER_BR_ENCOUNTER_ISRANDRECHECKDATE";
         edtavBr_encounter_br_encounter_israndrecheckdate_Internalname = "BR_ENCOUNTER_BR_ENCOUNTER_ISRANDRECHECKDATE";
         divUnnamedtablebr_encounter_br_encounter_israndrecheckdate_Internalname = "UNNAMEDTABLEBR_ENCOUNTER_BR_ENCOUNTER_ISRANDRECHECKDATE";
         lblTextblockbr_encounter_br_encounter_israndnorecheckr_Internalname = "TEXTBLOCKBR_ENCOUNTER_BR_ENCOUNTER_ISRANDNORECHECKR";
         edtavBr_encounter_br_encounter_israndnorecheckr_Internalname = "BR_ENCOUNTER_BR_ENCOUNTER_ISRANDNORECHECKR";
         divUnnamedtablebr_encounter_br_encounter_israndnorecheckr_Internalname = "UNNAMEDTABLEBR_ENCOUNTER_BR_ENCOUNTER_ISRANDNORECHECKR";
         lblTextblockbr_encounter_br_encounter_israndnorecheckdate_Internalname = "TEXTBLOCKBR_ENCOUNTER_BR_ENCOUNTER_ISRANDNORECHECKDATE";
         edtavBr_encounter_br_encounter_israndnorecheckdate_Internalname = "BR_ENCOUNTER_BR_ENCOUNTER_ISRANDNORECHECKDATE";
         divUnnamedtablebr_encounter_br_encounter_israndnorecheckdate_Internalname = "UNNAMEDTABLEBR_ENCOUNTER_BR_ENCOUNTER_ISRANDNORECHECKDATE";
         divUnnamedtable2_Internalname = "UNNAMEDTABLE2";
         divLayout_unnamedtable2_Internalname = "LAYOUT_UNNAMEDTABLE2";
         Dvpanel_unnamedtable2_Internalname = "DVPANEL_UNNAMEDTABLE2";
         divHtml_dvpanel_unnamedtable2_Internalname = "HTML_DVPANEL_UNNAMEDTABLE2";
         lblTextblockbr_encounter_br_encounter_isupdate_Internalname = "TEXTBLOCKBR_ENCOUNTER_BR_ENCOUNTER_ISUPDATE";
         chkavBr_encounter_br_encounter_isupdate_Internalname = "BR_ENCOUNTER_BR_ENCOUNTER_ISUPDATE";
         divUnnamedtablebr_encounter_br_encounter_isupdate_Internalname = "UNNAMEDTABLEBR_ENCOUNTER_BR_ENCOUNTER_ISUPDATE";
         lblTextblockbr_encounter_br_encounter_upddate_Internalname = "TEXTBLOCKBR_ENCOUNTER_BR_ENCOUNTER_UPDDATE";
         edtavBr_encounter_br_encounter_upddate_Internalname = "BR_ENCOUNTER_BR_ENCOUNTER_UPDDATE";
         divUnnamedtablebr_encounter_br_encounter_upddate_Internalname = "UNNAMEDTABLEBR_ENCOUNTER_BR_ENCOUNTER_UPDDATE";
         lblTextblockbr_encounter_br_encounter_upduser_Internalname = "TEXTBLOCKBR_ENCOUNTER_BR_ENCOUNTER_UPDUSER";
         edtavBr_encounter_br_encounter_upduser_Internalname = "BR_ENCOUNTER_BR_ENCOUNTER_UPDUSER";
         divUnnamedtablebr_encounter_br_encounter_upduser_Internalname = "UNNAMEDTABLEBR_ENCOUNTER_BR_ENCOUNTER_UPDUSER";
         divUnnamedtable3_Internalname = "UNNAMEDTABLE3";
         divLayout_unnamedtable3_Internalname = "LAYOUT_UNNAMEDTABLE3";
         Dvpanel_unnamedtable3_Internalname = "DVPANEL_UNNAMEDTABLE3";
         divHtml_dvpanel_unnamedtable3_Internalname = "HTML_DVPANEL_UNNAMEDTABLE3";
         divTablecontent_Internalname = "TABLECONTENT";
         divTablemain_Internalname = "TABLEMAIN";
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
         chkavBr_encounter_br_encounter_isupdate.Caption = "是否修改";
         chkavBr_encounter_br_encounter_israndrecheck.Caption = "是否复审抽查";
         chkavBr_encounter_br_encounter_israndapprove.Caption = "是否初审抽查";
         edtavBr_encounter_br_encounter_upduser_Enabled = -1;
         edtavBr_encounter_br_encounter_upddate_Enabled = -1;
         chkavBr_encounter_br_encounter_isupdate.Enabled = -1;
         edtavBr_encounter_br_encounter_israndnorecheckdate_Enabled = -1;
         edtavBr_encounter_br_encounter_israndnorecheckr_Enabled = -1;
         edtavBr_encounter_br_encounter_israndrecheckdate_Enabled = -1;
         edtavBr_encounter_br_encounter_israndrecheckr_Enabled = -1;
         chkavBr_encounter_br_encounter_israndrecheck.Enabled = -1;
         edtavBr_encounter_br_encounter_israndnoapprovedate_Enabled = -1;
         edtavBr_encounter_br_encounter_israndnoapprover_Enabled = -1;
         edtavBr_encounter_br_encounter_israndapprovedate_Enabled = -1;
         edtavBr_encounter_br_encounter_israndapprover_Enabled = -1;
         chkavBr_encounter_br_encounter_israndapprove.Enabled = -1;
         edtavBr_encounter_br_encounter_recheckdate_Enabled = -1;
         edtavBr_encounter_br_encounter_recheckuser_Enabled = -1;
         edtavBr_encounter_br_encounter_approvedate_Enabled = -1;
         edtavBr_encounter_br_encounter_approver_Enabled = -1;
         edtavBr_encounter_br_encounter_submitdate_Enabled = -1;
         edtavBr_encounter_br_encounter_submituser_Enabled = -1;
         edtavBr_encounter_br_encounter_crtdate_Enabled = -1;
         edtavBr_encounter_br_encounter_crtdisplayname_Enabled = -1;
         edtavBr_encounter_br_encounter_upduser_Jsonclick = "";
         edtavBr_encounter_br_encounter_upduser_Enabled = 0;
         edtavBr_encounter_br_encounter_upddate_Jsonclick = "";
         edtavBr_encounter_br_encounter_upddate_Enabled = 0;
         chkavBr_encounter_br_encounter_isupdate.Enabled = 0;
         edtavBr_encounter_br_encounter_israndnorecheckdate_Jsonclick = "";
         edtavBr_encounter_br_encounter_israndnorecheckdate_Enabled = 0;
         edtavBr_encounter_br_encounter_israndnorecheckr_Jsonclick = "";
         edtavBr_encounter_br_encounter_israndnorecheckr_Enabled = 0;
         edtavBr_encounter_br_encounter_israndrecheckdate_Jsonclick = "";
         edtavBr_encounter_br_encounter_israndrecheckdate_Enabled = 0;
         edtavBr_encounter_br_encounter_israndrecheckr_Jsonclick = "";
         edtavBr_encounter_br_encounter_israndrecheckr_Enabled = 0;
         chkavBr_encounter_br_encounter_israndrecheck.Enabled = 0;
         edtavBr_encounter_br_encounter_israndnoapprovedate_Jsonclick = "";
         edtavBr_encounter_br_encounter_israndnoapprovedate_Enabled = 0;
         edtavBr_encounter_br_encounter_israndnoapprover_Jsonclick = "";
         edtavBr_encounter_br_encounter_israndnoapprover_Enabled = 0;
         edtavBr_encounter_br_encounter_israndapprovedate_Jsonclick = "";
         edtavBr_encounter_br_encounter_israndapprovedate_Enabled = 0;
         edtavBr_encounter_br_encounter_israndapprover_Jsonclick = "";
         edtavBr_encounter_br_encounter_israndapprover_Enabled = 0;
         chkavBr_encounter_br_encounter_israndapprove.Enabled = 0;
         edtavBr_encounter_br_encounter_recheckdate_Jsonclick = "";
         edtavBr_encounter_br_encounter_recheckdate_Enabled = 0;
         edtavBr_encounter_br_encounter_recheckuser_Jsonclick = "";
         edtavBr_encounter_br_encounter_recheckuser_Enabled = 0;
         edtavBr_encounter_br_encounter_approvedate_Jsonclick = "";
         edtavBr_encounter_br_encounter_approvedate_Enabled = 0;
         edtavBr_encounter_br_encounter_approver_Jsonclick = "";
         edtavBr_encounter_br_encounter_approver_Enabled = 0;
         edtavBr_encounter_br_encounter_submitdate_Jsonclick = "";
         edtavBr_encounter_br_encounter_submitdate_Enabled = 0;
         edtavBr_encounter_br_encounter_submituser_Jsonclick = "";
         edtavBr_encounter_br_encounter_submituser_Enabled = 0;
         edtavBr_encounter_br_encounter_crtdate_Jsonclick = "";
         edtavBr_encounter_br_encounter_crtdate_Enabled = 0;
         edtavBr_encounter_br_encounter_crtdisplayname_Jsonclick = "";
         edtavBr_encounter_br_encounter_crtdisplayname_Enabled = 0;
         Dvpanel_unnamedtable3_Autoscroll = Convert.ToBoolean( 0);
         Dvpanel_unnamedtable3_Iconposition = "left";
         Dvpanel_unnamedtable3_Showcollapseicon = Convert.ToBoolean( 0);
         Dvpanel_unnamedtable3_Autoheight = Convert.ToBoolean( -1);
         Dvpanel_unnamedtable3_Autowidth = Convert.ToBoolean( 0);
         Dvpanel_unnamedtable3_Collapsed = Convert.ToBoolean( 0);
         Dvpanel_unnamedtable3_Collapsible = Convert.ToBoolean( -1);
         Dvpanel_unnamedtable3_Title = "修改情况";
         Dvpanel_unnamedtable3_Cls = "PanelCard_BaseColor";
         Dvpanel_unnamedtable3_Width = "100%";
         Dvpanel_unnamedtable2_Autoscroll = Convert.ToBoolean( 0);
         Dvpanel_unnamedtable2_Iconposition = "left";
         Dvpanel_unnamedtable2_Showcollapseicon = Convert.ToBoolean( 0);
         Dvpanel_unnamedtable2_Autoheight = Convert.ToBoolean( -1);
         Dvpanel_unnamedtable2_Autowidth = Convert.ToBoolean( 0);
         Dvpanel_unnamedtable2_Collapsed = Convert.ToBoolean( 0);
         Dvpanel_unnamedtable2_Collapsible = Convert.ToBoolean( -1);
         Dvpanel_unnamedtable2_Title = "复审抽查";
         Dvpanel_unnamedtable2_Cls = "PanelCard_BaseColor";
         Dvpanel_unnamedtable2_Width = "100%";
         Dvpanel_unnamedtable1_Autoscroll = Convert.ToBoolean( 0);
         Dvpanel_unnamedtable1_Iconposition = "left";
         Dvpanel_unnamedtable1_Showcollapseicon = Convert.ToBoolean( 0);
         Dvpanel_unnamedtable1_Autoheight = Convert.ToBoolean( -1);
         Dvpanel_unnamedtable1_Autowidth = Convert.ToBoolean( 0);
         Dvpanel_unnamedtable1_Collapsed = Convert.ToBoolean( 0);
         Dvpanel_unnamedtable1_Collapsible = Convert.ToBoolean( -1);
         Dvpanel_unnamedtable1_Title = "初审抽查";
         Dvpanel_unnamedtable1_Cls = "PanelCard_BaseColor";
         Dvpanel_unnamedtable1_Width = "100%";
         Dvpanel_tableattributes_Autoscroll = Convert.ToBoolean( 0);
         Dvpanel_tableattributes_Iconposition = "left";
         Dvpanel_tableattributes_Showcollapseicon = Convert.ToBoolean( 0);
         Dvpanel_tableattributes_Autoheight = Convert.ToBoolean( -1);
         Dvpanel_tableattributes_Autowidth = Convert.ToBoolean( 0);
         Dvpanel_tableattributes_Collapsed = Convert.ToBoolean( 0);
         Dvpanel_tableattributes_Collapsible = Convert.ToBoolean( -1);
         Dvpanel_tableattributes_Title = "审批情况";
         Dvpanel_tableattributes_Cls = "PanelCard_BaseColor";
         Dvpanel_tableattributes_Width = "100%";
         Form.Headerrawhtml = "";
         Form.Background = "";
         Form.Textcolor = 0;
         Form.Backcolor = (int)(0xFFFFFF);
         Form.Caption = "Data Mgmt Portal - RAAP";
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
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[{av:'AV11iBR_EncounterID',fld:'vIBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true}]");
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
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         GXKey = "";
         AV10BR_Encounter = new SdtBR_Encounter(context);
         GX_FocusControl = "";
         Form = new GXWebForm();
         sPrefix = "";
         TempTags = "";
         ClassString = "";
         StyleString = "";
         bttBtn_cancel_Jsonclick = "";
         ucDvpanel_tableattributes = new GXUserControl();
         lblTextblockbr_encounter_br_encounter_crtdisplayname_Jsonclick = "";
         lblTextblockbr_encounter_br_encounter_crtdate_Jsonclick = "";
         lblTextblockbr_encounter_br_encounter_submituser_Jsonclick = "";
         lblTextblockbr_encounter_br_encounter_submitdate_Jsonclick = "";
         lblTextblockbr_encounter_br_encounter_approver_Jsonclick = "";
         lblTextblockbr_encounter_br_encounter_approvedate_Jsonclick = "";
         lblTextblockbr_encounter_br_encounter_recheckuser_Jsonclick = "";
         lblTextblockbr_encounter_br_encounter_recheckdate_Jsonclick = "";
         ucDvpanel_unnamedtable1 = new GXUserControl();
         lblTextblockbr_encounter_br_encounter_israndapprove_Jsonclick = "";
         lblTextblockbr_encounter_br_encounter_israndapprover_Jsonclick = "";
         lblTextblockbr_encounter_br_encounter_israndapprovedate_Jsonclick = "";
         lblTextblockbr_encounter_br_encounter_israndnoapprover_Jsonclick = "";
         lblTextblockbr_encounter_br_encounter_israndnoapprovedate_Jsonclick = "";
         ucDvpanel_unnamedtable2 = new GXUserControl();
         lblTextblockbr_encounter_br_encounter_israndrecheck_Jsonclick = "";
         lblTextblockbr_encounter_br_encounter_israndrecheckr_Jsonclick = "";
         lblTextblockbr_encounter_br_encounter_israndrecheckdate_Jsonclick = "";
         lblTextblockbr_encounter_br_encounter_israndnorecheckr_Jsonclick = "";
         lblTextblockbr_encounter_br_encounter_israndnorecheckdate_Jsonclick = "";
         ucDvpanel_unnamedtable3 = new GXUserControl();
         lblTextblockbr_encounter_br_encounter_isupdate_Jsonclick = "";
         lblTextblockbr_encounter_br_encounter_upddate_Jsonclick = "";
         lblTextblockbr_encounter_br_encounter_upduser_Jsonclick = "";
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         AV8Messages = new GXBaseCollection<SdtMessages_Message>( context, "Message", "GeneXus");
         AV7Message = new SdtMessages_Message(context);
         AV9Context = new GeneXus.Programs.wwpbaseobjects.SdtWWPContext(context);
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         /* GeneXus formulas. */
         context.Gx_err = 0;
         edtavBr_encounter_br_encounter_crtdisplayname_Enabled = 0;
         edtavBr_encounter_br_encounter_crtdate_Enabled = 0;
         edtavBr_encounter_br_encounter_submituser_Enabled = 0;
         edtavBr_encounter_br_encounter_submitdate_Enabled = 0;
         edtavBr_encounter_br_encounter_approver_Enabled = 0;
         edtavBr_encounter_br_encounter_approvedate_Enabled = 0;
         edtavBr_encounter_br_encounter_recheckuser_Enabled = 0;
         edtavBr_encounter_br_encounter_recheckdate_Enabled = 0;
         chkavBr_encounter_br_encounter_israndapprove.Enabled = 0;
         edtavBr_encounter_br_encounter_israndapprover_Enabled = 0;
         edtavBr_encounter_br_encounter_israndapprovedate_Enabled = 0;
         edtavBr_encounter_br_encounter_israndnoapprover_Enabled = 0;
         edtavBr_encounter_br_encounter_israndnoapprovedate_Enabled = 0;
         chkavBr_encounter_br_encounter_israndrecheck.Enabled = 0;
         edtavBr_encounter_br_encounter_israndrecheckr_Enabled = 0;
         edtavBr_encounter_br_encounter_israndrecheckdate_Enabled = 0;
         edtavBr_encounter_br_encounter_israndnorecheckr_Enabled = 0;
         edtavBr_encounter_br_encounter_israndnorecheckdate_Enabled = 0;
         chkavBr_encounter_br_encounter_isupdate.Enabled = 0;
         edtavBr_encounter_br_encounter_upddate_Enabled = 0;
         edtavBr_encounter_br_encounter_upduser_Enabled = 0;
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
      private int edtavBr_encounter_br_encounter_crtdisplayname_Enabled ;
      private int edtavBr_encounter_br_encounter_crtdate_Enabled ;
      private int edtavBr_encounter_br_encounter_submituser_Enabled ;
      private int edtavBr_encounter_br_encounter_submitdate_Enabled ;
      private int edtavBr_encounter_br_encounter_approver_Enabled ;
      private int edtavBr_encounter_br_encounter_approvedate_Enabled ;
      private int edtavBr_encounter_br_encounter_recheckuser_Enabled ;
      private int edtavBr_encounter_br_encounter_recheckdate_Enabled ;
      private int edtavBr_encounter_br_encounter_israndapprover_Enabled ;
      private int edtavBr_encounter_br_encounter_israndapprovedate_Enabled ;
      private int edtavBr_encounter_br_encounter_israndnoapprover_Enabled ;
      private int edtavBr_encounter_br_encounter_israndnoapprovedate_Enabled ;
      private int edtavBr_encounter_br_encounter_israndrecheckr_Enabled ;
      private int edtavBr_encounter_br_encounter_israndrecheckdate_Enabled ;
      private int edtavBr_encounter_br_encounter_israndnorecheckr_Enabled ;
      private int edtavBr_encounter_br_encounter_israndnorecheckdate_Enabled ;
      private int edtavBr_encounter_br_encounter_upddate_Enabled ;
      private int edtavBr_encounter_br_encounter_upduser_Enabled ;
      private int AV35GXV22 ;
      private int idxLst ;
      private long AV11iBR_EncounterID ;
      private long wcpOAV11iBR_EncounterID ;
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
      private String Dvpanel_unnamedtable1_Width ;
      private String Dvpanel_unnamedtable1_Cls ;
      private String Dvpanel_unnamedtable1_Title ;
      private String Dvpanel_unnamedtable1_Iconposition ;
      private String Dvpanel_unnamedtable2_Width ;
      private String Dvpanel_unnamedtable2_Cls ;
      private String Dvpanel_unnamedtable2_Title ;
      private String Dvpanel_unnamedtable2_Iconposition ;
      private String Dvpanel_unnamedtable3_Width ;
      private String Dvpanel_unnamedtable3_Cls ;
      private String Dvpanel_unnamedtable3_Title ;
      private String Dvpanel_unnamedtable3_Iconposition ;
      private String GX_FocusControl ;
      private String sPrefix ;
      private String divLayoutmaintable_Internalname ;
      private String divTablemain_Internalname ;
      private String divTablecontent_Internalname ;
      private String TempTags ;
      private String ClassString ;
      private String StyleString ;
      private String bttBtn_cancel_Internalname ;
      private String bttBtn_cancel_Jsonclick ;
      private String divHtml_dvpanel_tableattributes_Internalname ;
      private String Dvpanel_tableattributes_Internalname ;
      private String divLayout_tableattributes_Internalname ;
      private String divTableattributes_Internalname ;
      private String divUnnamedtable6_Internalname ;
      private String divUnnamedtable7_Internalname ;
      private String divUnnamedtablebr_encounter_br_encounter_crtdisplayname_Internalname ;
      private String lblTextblockbr_encounter_br_encounter_crtdisplayname_Internalname ;
      private String lblTextblockbr_encounter_br_encounter_crtdisplayname_Jsonclick ;
      private String edtavBr_encounter_br_encounter_crtdisplayname_Internalname ;
      private String edtavBr_encounter_br_encounter_crtdisplayname_Jsonclick ;
      private String divUnnamedtablebr_encounter_br_encounter_crtdate_Internalname ;
      private String lblTextblockbr_encounter_br_encounter_crtdate_Internalname ;
      private String lblTextblockbr_encounter_br_encounter_crtdate_Jsonclick ;
      private String edtavBr_encounter_br_encounter_crtdate_Internalname ;
      private String edtavBr_encounter_br_encounter_crtdate_Jsonclick ;
      private String divUnnamedtable8_Internalname ;
      private String divUnnamedtablebr_encounter_br_encounter_submituser_Internalname ;
      private String lblTextblockbr_encounter_br_encounter_submituser_Internalname ;
      private String lblTextblockbr_encounter_br_encounter_submituser_Jsonclick ;
      private String edtavBr_encounter_br_encounter_submituser_Internalname ;
      private String edtavBr_encounter_br_encounter_submituser_Jsonclick ;
      private String divUnnamedtablebr_encounter_br_encounter_submitdate_Internalname ;
      private String lblTextblockbr_encounter_br_encounter_submitdate_Internalname ;
      private String lblTextblockbr_encounter_br_encounter_submitdate_Jsonclick ;
      private String edtavBr_encounter_br_encounter_submitdate_Internalname ;
      private String edtavBr_encounter_br_encounter_submitdate_Jsonclick ;
      private String divUnnamedtable9_Internalname ;
      private String divUnnamedtablebr_encounter_br_encounter_approver_Internalname ;
      private String lblTextblockbr_encounter_br_encounter_approver_Internalname ;
      private String lblTextblockbr_encounter_br_encounter_approver_Jsonclick ;
      private String edtavBr_encounter_br_encounter_approver_Internalname ;
      private String edtavBr_encounter_br_encounter_approver_Jsonclick ;
      private String divUnnamedtablebr_encounter_br_encounter_approvedate_Internalname ;
      private String lblTextblockbr_encounter_br_encounter_approvedate_Internalname ;
      private String lblTextblockbr_encounter_br_encounter_approvedate_Jsonclick ;
      private String edtavBr_encounter_br_encounter_approvedate_Internalname ;
      private String edtavBr_encounter_br_encounter_approvedate_Jsonclick ;
      private String divUnnamedtable10_Internalname ;
      private String divUnnamedtablebr_encounter_br_encounter_recheckuser_Internalname ;
      private String lblTextblockbr_encounter_br_encounter_recheckuser_Internalname ;
      private String lblTextblockbr_encounter_br_encounter_recheckuser_Jsonclick ;
      private String edtavBr_encounter_br_encounter_recheckuser_Internalname ;
      private String edtavBr_encounter_br_encounter_recheckuser_Jsonclick ;
      private String divUnnamedtablebr_encounter_br_encounter_recheckdate_Internalname ;
      private String lblTextblockbr_encounter_br_encounter_recheckdate_Internalname ;
      private String lblTextblockbr_encounter_br_encounter_recheckdate_Jsonclick ;
      private String edtavBr_encounter_br_encounter_recheckdate_Internalname ;
      private String edtavBr_encounter_br_encounter_recheckdate_Jsonclick ;
      private String divHtml_dvpanel_unnamedtable1_Internalname ;
      private String Dvpanel_unnamedtable1_Internalname ;
      private String divLayout_unnamedtable1_Internalname ;
      private String divUnnamedtable1_Internalname ;
      private String divUnnamedtable4_Internalname ;
      private String divUnnamedtablebr_encounter_br_encounter_israndapprove_Internalname ;
      private String lblTextblockbr_encounter_br_encounter_israndapprove_Internalname ;
      private String lblTextblockbr_encounter_br_encounter_israndapprove_Jsonclick ;
      private String chkavBr_encounter_br_encounter_israndapprove_Internalname ;
      private String divUnnamedtable5_Internalname ;
      private String divUnnamedtablebr_encounter_br_encounter_israndapprover_Internalname ;
      private String lblTextblockbr_encounter_br_encounter_israndapprover_Internalname ;
      private String lblTextblockbr_encounter_br_encounter_israndapprover_Jsonclick ;
      private String edtavBr_encounter_br_encounter_israndapprover_Internalname ;
      private String edtavBr_encounter_br_encounter_israndapprover_Jsonclick ;
      private String divUnnamedtablebr_encounter_br_encounter_israndapprovedate_Internalname ;
      private String lblTextblockbr_encounter_br_encounter_israndapprovedate_Internalname ;
      private String lblTextblockbr_encounter_br_encounter_israndapprovedate_Jsonclick ;
      private String edtavBr_encounter_br_encounter_israndapprovedate_Internalname ;
      private String edtavBr_encounter_br_encounter_israndapprovedate_Jsonclick ;
      private String divUnnamedtablebr_encounter_br_encounter_israndnoapprover_Internalname ;
      private String lblTextblockbr_encounter_br_encounter_israndnoapprover_Internalname ;
      private String lblTextblockbr_encounter_br_encounter_israndnoapprover_Jsonclick ;
      private String edtavBr_encounter_br_encounter_israndnoapprover_Internalname ;
      private String edtavBr_encounter_br_encounter_israndnoapprover_Jsonclick ;
      private String divUnnamedtablebr_encounter_br_encounter_israndnoapprovedate_Internalname ;
      private String lblTextblockbr_encounter_br_encounter_israndnoapprovedate_Internalname ;
      private String lblTextblockbr_encounter_br_encounter_israndnoapprovedate_Jsonclick ;
      private String edtavBr_encounter_br_encounter_israndnoapprovedate_Internalname ;
      private String edtavBr_encounter_br_encounter_israndnoapprovedate_Jsonclick ;
      private String divHtml_dvpanel_unnamedtable2_Internalname ;
      private String Dvpanel_unnamedtable2_Internalname ;
      private String divLayout_unnamedtable2_Internalname ;
      private String divUnnamedtable2_Internalname ;
      private String divUnnamedtablebr_encounter_br_encounter_israndrecheck_Internalname ;
      private String lblTextblockbr_encounter_br_encounter_israndrecheck_Internalname ;
      private String lblTextblockbr_encounter_br_encounter_israndrecheck_Jsonclick ;
      private String chkavBr_encounter_br_encounter_israndrecheck_Internalname ;
      private String divUnnamedtablebr_encounter_br_encounter_israndrecheckr_Internalname ;
      private String lblTextblockbr_encounter_br_encounter_israndrecheckr_Internalname ;
      private String lblTextblockbr_encounter_br_encounter_israndrecheckr_Jsonclick ;
      private String edtavBr_encounter_br_encounter_israndrecheckr_Internalname ;
      private String edtavBr_encounter_br_encounter_israndrecheckr_Jsonclick ;
      private String divUnnamedtablebr_encounter_br_encounter_israndrecheckdate_Internalname ;
      private String lblTextblockbr_encounter_br_encounter_israndrecheckdate_Internalname ;
      private String lblTextblockbr_encounter_br_encounter_israndrecheckdate_Jsonclick ;
      private String edtavBr_encounter_br_encounter_israndrecheckdate_Internalname ;
      private String edtavBr_encounter_br_encounter_israndrecheckdate_Jsonclick ;
      private String divUnnamedtablebr_encounter_br_encounter_israndnorecheckr_Internalname ;
      private String lblTextblockbr_encounter_br_encounter_israndnorecheckr_Internalname ;
      private String lblTextblockbr_encounter_br_encounter_israndnorecheckr_Jsonclick ;
      private String edtavBr_encounter_br_encounter_israndnorecheckr_Internalname ;
      private String edtavBr_encounter_br_encounter_israndnorecheckr_Jsonclick ;
      private String divUnnamedtablebr_encounter_br_encounter_israndnorecheckdate_Internalname ;
      private String lblTextblockbr_encounter_br_encounter_israndnorecheckdate_Internalname ;
      private String lblTextblockbr_encounter_br_encounter_israndnorecheckdate_Jsonclick ;
      private String edtavBr_encounter_br_encounter_israndnorecheckdate_Internalname ;
      private String edtavBr_encounter_br_encounter_israndnorecheckdate_Jsonclick ;
      private String divHtml_dvpanel_unnamedtable3_Internalname ;
      private String Dvpanel_unnamedtable3_Internalname ;
      private String divLayout_unnamedtable3_Internalname ;
      private String divUnnamedtable3_Internalname ;
      private String divUnnamedtablebr_encounter_br_encounter_isupdate_Internalname ;
      private String lblTextblockbr_encounter_br_encounter_isupdate_Internalname ;
      private String lblTextblockbr_encounter_br_encounter_isupdate_Jsonclick ;
      private String chkavBr_encounter_br_encounter_isupdate_Internalname ;
      private String divUnnamedtablebr_encounter_br_encounter_upddate_Internalname ;
      private String lblTextblockbr_encounter_br_encounter_upddate_Internalname ;
      private String lblTextblockbr_encounter_br_encounter_upddate_Jsonclick ;
      private String edtavBr_encounter_br_encounter_upddate_Internalname ;
      private String edtavBr_encounter_br_encounter_upddate_Jsonclick ;
      private String divUnnamedtablebr_encounter_br_encounter_upduser_Internalname ;
      private String lblTextblockbr_encounter_br_encounter_upduser_Internalname ;
      private String lblTextblockbr_encounter_br_encounter_upduser_Jsonclick ;
      private String edtavBr_encounter_br_encounter_upduser_Internalname ;
      private String edtavBr_encounter_br_encounter_upduser_Jsonclick ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private bool entryPointCalled ;
      private bool toggleJsOutput ;
      private bool Dvpanel_tableattributes_Collapsible ;
      private bool Dvpanel_tableattributes_Collapsed ;
      private bool Dvpanel_tableattributes_Autowidth ;
      private bool Dvpanel_tableattributes_Autoheight ;
      private bool Dvpanel_tableattributes_Showcollapseicon ;
      private bool Dvpanel_tableattributes_Autoscroll ;
      private bool Dvpanel_unnamedtable1_Collapsible ;
      private bool Dvpanel_unnamedtable1_Collapsed ;
      private bool Dvpanel_unnamedtable1_Autowidth ;
      private bool Dvpanel_unnamedtable1_Autoheight ;
      private bool Dvpanel_unnamedtable1_Showcollapseicon ;
      private bool Dvpanel_unnamedtable1_Autoscroll ;
      private bool Dvpanel_unnamedtable2_Collapsible ;
      private bool Dvpanel_unnamedtable2_Collapsed ;
      private bool Dvpanel_unnamedtable2_Autowidth ;
      private bool Dvpanel_unnamedtable2_Autoheight ;
      private bool Dvpanel_unnamedtable2_Showcollapseicon ;
      private bool Dvpanel_unnamedtable2_Autoscroll ;
      private bool Dvpanel_unnamedtable3_Collapsible ;
      private bool Dvpanel_unnamedtable3_Collapsed ;
      private bool Dvpanel_unnamedtable3_Autowidth ;
      private bool Dvpanel_unnamedtable3_Autoheight ;
      private bool Dvpanel_unnamedtable3_Showcollapseicon ;
      private bool Dvpanel_unnamedtable3_Autoscroll ;
      private bool wbLoad ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool gxdyncontrolsrefreshing ;
      private bool returnInSub ;
      private GXUserControl ucDvpanel_tableattributes ;
      private GXUserControl ucDvpanel_unnamedtable1 ;
      private GXUserControl ucDvpanel_unnamedtable2 ;
      private GXUserControl ucDvpanel_unnamedtable3 ;
      private IGxDataStore dsDataStore1 ;
      private IGxDataStore dsDefault ;
      private GXCheckbox chkavBr_encounter_br_encounter_israndapprove ;
      private GXCheckbox chkavBr_encounter_br_encounter_israndrecheck ;
      private GXCheckbox chkavBr_encounter_br_encounter_isupdate ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private GXBaseCollection<SdtMessages_Message> AV8Messages ;
      private GXWebForm Form ;
      private SdtMessages_Message AV7Message ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPContext AV9Context ;
      private SdtBR_Encounter AV10BR_Encounter ;
   }

}
