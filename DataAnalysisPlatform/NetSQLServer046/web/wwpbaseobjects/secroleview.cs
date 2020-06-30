/*
               File: WWPBaseObjects.SecRoleView
        Description: Sec Role View
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/27/2020 11:58:29.44
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
namespace GeneXus.Programs.wwpbaseobjects {
   public class secroleview : GXDataArea, System.Web.SessionState.IRequiresSessionState
   {
      public secroleview( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public secroleview( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( short aP0_SecRoleId ,
                           String aP1_TabCode )
      {
         this.AV10SecRoleId = aP0_SecRoleId;
         this.AV8TabCode = aP1_TabCode;
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
               AV10SecRoleId = (short)(NumberUtil.Val( gxfirstwebparm, "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10SecRoleId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10SecRoleId), 4, 0)));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vSECROLEID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV10SecRoleId), "ZZZ9"), context));
               if ( StringUtil.StrCmp(gxfirstwebparm, "viewer") != 0 )
               {
                  AV8TabCode = GetNextPar( );
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8TabCode", AV8TabCode);
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vTABCODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( AV8TabCode, "")), context));
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
         PA0U2( ) ;
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0));
         if ( ( gxajaxcallmode == 0 ) && ( GxWebError == 0 ) )
         {
            START0U2( ) ;
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
         context.AddJavascriptSource("gxcfg.js", "?202022711582949", false);
         if ( context.isSpaRequest( ) )
         {
            enableOutput();
         }
         context.AddJavascriptSource("Shared/HistoryManager/HistoryManager.js", "", false);
         context.AddJavascriptSource("Shared/HistoryManager/rsh/json2005.js", "", false);
         context.AddJavascriptSource("Shared/HistoryManager/rsh/rsh.js", "", false);
         context.AddJavascriptSource("Shared/HistoryManager/HistoryManagerCreate.js", "", false);
         context.AddJavascriptSource("Tab/TabRender.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/Shared/DVelopBootstrap.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/ConfirmPanel/BootstrapConfirmPanelRender.js", "", false);
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" autocomplete=\"off\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("wwpbaseobjects.secroleview.aspx") + "?" + UrlEncode("" +AV10SecRoleId) + "," + UrlEncode(StringUtil.RTrim(AV8TabCode))+"\">") ;
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
         GxWebStd.gx_hidden_field( context, "SECROLEID", StringUtil.LTrim( StringUtil.NToC( (decimal)(A4SecRoleId), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "gxhash_SECROLEID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(A4SecRoleId), "ZZZ9"), context));
         GxWebStd.gx_boolean_hidden_field( context, "vLOADALLTABS", AV14LoadAllTabs);
         GxWebStd.gx_hidden_field( context, "vSELECTEDTABCODE", StringUtil.RTrim( AV15SelectedTabCode));
         GxWebStd.gx_hidden_field( context, "vSECROLEID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV10SecRoleId), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "gxhash_vSECROLEID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV10SecRoleId), "ZZZ9"), context));
         GxWebStd.gx_hidden_field( context, "vTABCODE", StringUtil.RTrim( AV8TabCode));
         GxWebStd.gx_hidden_field( context, "gxhash_vTABCODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( AV8TabCode, "")), context));
         GxWebStd.gx_hidden_field( context, "TABS_Class", StringUtil.RTrim( Tabs_Class));
         GxWebStd.gx_hidden_field( context, "TABS_Activepagecontrolname", StringUtil.RTrim( Tabs_Activepagecontrolname));
         GxWebStd.gx_hidden_field( context, "TABS_Pagecount", StringUtil.LTrim( StringUtil.NToC( (decimal)(Tabs_Pagecount), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "TABS_Historymanagement", StringUtil.BoolToStr( Tabs_Historymanagement));
         GxWebStd.gx_hidden_field( context, "DVELOP_CONFIRMPANEL_DELETEROLE_Title", StringUtil.RTrim( Dvelop_confirmpanel_deleterole_Title));
         GxWebStd.gx_hidden_field( context, "DVELOP_CONFIRMPANEL_DELETEROLE_Confirmationtext", StringUtil.RTrim( Dvelop_confirmpanel_deleterole_Confirmationtext));
         GxWebStd.gx_hidden_field( context, "DVELOP_CONFIRMPANEL_DELETEROLE_Yesbuttoncaption", StringUtil.RTrim( Dvelop_confirmpanel_deleterole_Yesbuttoncaption));
         GxWebStd.gx_hidden_field( context, "DVELOP_CONFIRMPANEL_DELETEROLE_Nobuttoncaption", StringUtil.RTrim( Dvelop_confirmpanel_deleterole_Nobuttoncaption));
         GxWebStd.gx_hidden_field( context, "DVELOP_CONFIRMPANEL_DELETEROLE_Cancelbuttoncaption", StringUtil.RTrim( Dvelop_confirmpanel_deleterole_Cancelbuttoncaption));
         GxWebStd.gx_hidden_field( context, "DVELOP_CONFIRMPANEL_DELETEROLE_Yesbuttonposition", StringUtil.RTrim( Dvelop_confirmpanel_deleterole_Yesbuttonposition));
         GxWebStd.gx_hidden_field( context, "DVELOP_CONFIRMPANEL_DELETEROLE_Confirmtype", StringUtil.RTrim( Dvelop_confirmpanel_deleterole_Confirmtype));
         GxWebStd.gx_hidden_field( context, "DVELOP_CONFIRMPANEL_DELETEROLE_Result", StringUtil.RTrim( Dvelop_confirmpanel_deleterole_Result));
         GxWebStd.gx_hidden_field( context, "TABS_Activepagecontrolname", StringUtil.RTrim( Tabs_Activepagecontrolname));
         GxWebStd.gx_hidden_field( context, "DVELOP_CONFIRMPANEL_DELETEROLE_Result", StringUtil.RTrim( Dvelop_confirmpanel_deleterole_Result));
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
         if ( ! ( WebComp_Generalwc == null ) )
         {
            WebComp_Generalwc.componentjscripts();
         }
         if ( ! ( WebComp_Secfunctionalityrolewc == null ) )
         {
            WebComp_Secfunctionalityrolewc.componentjscripts();
         }
         if ( ! ( WebComp_Secuserrolewc == null ) )
         {
            WebComp_Secuserrolewc.componentjscripts();
         }
      }

      public override void RenderHtmlContent( )
      {
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0));
         if ( ( gxajaxcallmode == 0 ) && ( GxWebError == 0 ) )
         {
            context.WriteHtmlText( "<div") ;
            GxWebStd.ClassAttribute( context, "gx-ct-body"+" "+(String.IsNullOrEmpty(StringUtil.RTrim( Form.Class)) ? "form-horizontal Form" : Form.Class)+"-fx");
            context.WriteHtmlText( ">") ;
            WE0U2( ) ;
            context.WriteHtmlText( "</div>") ;
         }
      }

      public override void DispatchEvents( )
      {
         EVT0U2( ) ;
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
         return formatLink("wwpbaseobjects.secroleview.aspx") + "?" + UrlEncode("" +AV10SecRoleId) + "," + UrlEncode(StringUtil.RTrim(AV8TabCode)) ;
      }

      public override String GetPgmname( )
      {
         return "WWPBaseObjects.SecRoleView" ;
      }

      public override String GetPgmdesc( )
      {
         return "Sec Role View" ;
      }

      protected void WB0U0( )
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
            GxWebStd.gx_div_start( context, divTablemain_Internalname, 1, 0, "px", 0, "px", "TableMainViewWithShadow", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "Right", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-action-group ActionGroup", "left", "top", " "+"data-gx-actiongroup-type=\"toolbar\""+" ", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 11,'',false,'',0)\"";
            ClassString = "ButtonMaterial";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtndeleterole_Internalname, "", "删除该角色", bttBtndeleterole_Jsonclick, 7, "删除该角色", "", StyleString, ClassString, 1, 1, "standard", "'"+""+"'"+",false,"+"'"+"e110u1_client"+"'", TempTags, "", 2, "HLP_WWPBaseObjects\\SecRoleView.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 13,'',false,'',0)\"";
            ClassString = "ButtonMaterial";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtnreturn_Internalname, "", "返回", bttBtnreturn_Jsonclick, 7, "返回", "", StyleString, ClassString, 1, 1, "standard", "'"+""+"'"+",false,"+"'"+"e120u1_client"+"'", TempTags, "", 2, "HLP_WWPBaseObjects\\SecRoleView.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "Right", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 CellViewTabsPosition CellPaddingTop10", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divUnnamedtableviewcontainer_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 hidden-sm hidden-md hidden-lg CellTextBlockTitleWWP", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTxttabtitle_Internalname, lblTxttabtitle_Caption, "", "", lblTxttabtitle_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "TextBlockTitleWWPTab", 0, "", 1, 1, 0, "HLP_WWPBaseObjects\\SecRoleView.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 CellViewTab", "left", "top", "", "", "div");
            /* User Defined Control */
            ucTabs.SetProperty("PageCount", Tabs_Pagecount);
            ucTabs.SetProperty("Class", Tabs_Class);
            ucTabs.SetProperty("HistoryManagement", Tabs_Historymanagement);
            ucTabs.Render(context, "tab", Tabs_Internalname, "TABSContainer");
            context.WriteHtmlText( "<div class=\"gx_usercontrol_child\" id=\""+"TABSContainer"+"title1"+"\" style=\"display:none;\">") ;
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblGeneral_title_Internalname, "角色信息", "", "", lblGeneral_title_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "TextBlock", 0, "", 1, 1, 0, "HLP_WWPBaseObjects\\SecRoleView.htm");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "Section", "left", "top", "", "display:none;", "div");
            context.WriteHtmlText( "General") ;
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "<div class=\"gx_usercontrol_child\" id=\""+"TABSContainer"+"panel1"+"\" style=\"display:none;\">") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, divUnnamedtablegeneral_Internalname, 1, 0, "px", 0, "px", "TableViewTab", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            if ( ! isFullAjaxMode( ) )
            {
               /* WebComponent */
               GxWebStd.gx_hidden_field( context, "W0030"+"", StringUtil.RTrim( WebComp_Generalwc_Component));
               context.WriteHtmlText( "<div") ;
               GxWebStd.ClassAttribute( context, "gxwebcomponent");
               context.WriteHtmlText( " id=\""+"gxHTMLWrpW0030"+""+"\""+"") ;
               context.WriteHtmlText( ">") ;
               if ( StringUtil.Len( WebComp_Generalwc_Component) != 0 )
               {
                  if ( StringUtil.StrCmp(StringUtil.Lower( OldGeneralwc), StringUtil.Lower( WebComp_Generalwc_Component)) != 0 )
                  {
                     context.httpAjaxContext.ajax_rspStartCmp("gxHTMLWrpW0030"+"");
                  }
                  WebComp_Generalwc.componentdraw();
                  if ( StringUtil.StrCmp(StringUtil.Lower( OldGeneralwc), StringUtil.Lower( WebComp_Generalwc_Component)) != 0 )
                  {
                     context.httpAjaxContext.ajax_rspEndCmp();
                  }
               }
               context.WriteHtmlText( "</div>") ;
            }
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "<div class=\"gx_usercontrol_child\" id=\""+"TABSContainer"+"title2"+"\" style=\"display:none;\">") ;
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblSecfunctionalityrole_title_Internalname, "权限", "", "", lblSecfunctionalityrole_title_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "TextBlock", 0, "", 1, 1, 0, "HLP_WWPBaseObjects\\SecRoleView.htm");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "Section", "left", "top", "", "display:none;", "div");
            context.WriteHtmlText( "SecFunctionalityRole") ;
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "<div class=\"gx_usercontrol_child\" id=\""+"TABSContainer"+"panel2"+"\" style=\"display:none;\">") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, divUnnamedtablesecfunctionalityrole_Internalname, 1, 0, "px", 0, "px", "TableViewTab", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            if ( ! isFullAjaxMode( ) )
            {
               /* WebComponent */
               GxWebStd.gx_hidden_field( context, "W0038"+"", StringUtil.RTrim( WebComp_Secfunctionalityrolewc_Component));
               context.WriteHtmlText( "<div") ;
               GxWebStd.ClassAttribute( context, "gxwebcomponent");
               context.WriteHtmlText( " id=\""+"gxHTMLWrpW0038"+""+"\""+"") ;
               context.WriteHtmlText( ">") ;
               if ( StringUtil.Len( WebComp_Secfunctionalityrolewc_Component) != 0 )
               {
                  if ( StringUtil.StrCmp(StringUtil.Lower( OldSecfunctionalityrolewc), StringUtil.Lower( WebComp_Secfunctionalityrolewc_Component)) != 0 )
                  {
                     context.httpAjaxContext.ajax_rspStartCmp("gxHTMLWrpW0038"+"");
                  }
                  WebComp_Secfunctionalityrolewc.componentdraw();
                  if ( StringUtil.StrCmp(StringUtil.Lower( OldSecfunctionalityrolewc), StringUtil.Lower( WebComp_Secfunctionalityrolewc_Component)) != 0 )
                  {
                     context.httpAjaxContext.ajax_rspEndCmp();
                  }
               }
               context.WriteHtmlText( "</div>") ;
            }
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "<div class=\"gx_usercontrol_child\" id=\""+"TABSContainer"+"title3"+"\" style=\"display:none;\">") ;
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblSecuserrole_title_Internalname, "用户", "", "", lblSecuserrole_title_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "TextBlock", 0, "", 1, 1, 0, "HLP_WWPBaseObjects\\SecRoleView.htm");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "Section", "left", "top", "", "display:none;", "div");
            context.WriteHtmlText( "SecUserRole") ;
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "<div class=\"gx_usercontrol_child\" id=\""+"TABSContainer"+"panel3"+"\" style=\"display:none;\">") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, divUnnamedtablesecuserrole_Internalname, 1, 0, "px", 0, "px", "TableViewTab", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            if ( ! isFullAjaxMode( ) )
            {
               /* WebComponent */
               GxWebStd.gx_hidden_field( context, "W0046"+"", StringUtil.RTrim( WebComp_Secuserrolewc_Component));
               context.WriteHtmlText( "<div") ;
               GxWebStd.ClassAttribute( context, "gxwebcomponent");
               context.WriteHtmlText( " id=\""+"gxHTMLWrpW0046"+""+"\""+"") ;
               context.WriteHtmlText( ">") ;
               if ( StringUtil.Len( WebComp_Secuserrolewc_Component) != 0 )
               {
                  if ( StringUtil.StrCmp(StringUtil.Lower( OldSecuserrolewc), StringUtil.Lower( WebComp_Secuserrolewc_Component)) != 0 )
                  {
                     context.httpAjaxContext.ajax_rspStartCmp("gxHTMLWrpW0046"+"");
                  }
                  WebComp_Secuserrolewc.componentdraw();
                  if ( StringUtil.StrCmp(StringUtil.Lower( OldSecuserrolewc), StringUtil.Lower( WebComp_Secuserrolewc_Component)) != 0 )
                  {
                     context.httpAjaxContext.ajax_rspEndCmp();
                  }
               }
               context.WriteHtmlText( "</div>") ;
            }
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</div>") ;
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 hidden-sm hidden-md hidden-lg CellPaddingBottom", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divUnnamedtabletabscontainer_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divCell_general_Internalname, divCell_general_Visible, 0, "px", 0, "px", "col-xs-12 CellMarginTop", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 52,'',false,'',0)\"";
            ClassString = "btn_Master btn-large btn-block Button";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtngeneral_Internalname, "", "角色信息", bttBtngeneral_Jsonclick, 7, "角色信息", "", StyleString, ClassString, 1, 1, "standard", "'"+""+"'"+",false,"+"'"+"e130u1_client"+"'", TempTags, "", 2, "HLP_WWPBaseObjects\\SecRoleView.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divCell_secfunctionalityrole_Internalname, divCell_secfunctionalityrole_Visible, 0, "px", 0, "px", "col-xs-12 CellMarginTop", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 55,'',false,'',0)\"";
            ClassString = "btn_Master btn-large btn-block Button";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtnsecfunctionalityrole_Internalname, "", "权限", bttBtnsecfunctionalityrole_Jsonclick, 7, "权限", "", StyleString, ClassString, 1, 1, "standard", "'"+""+"'"+",false,"+"'"+"e140u1_client"+"'", TempTags, "", 2, "HLP_WWPBaseObjects\\SecRoleView.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divCell_secuserrole_Internalname, divCell_secuserrole_Visible, 0, "px", 0, "px", "col-xs-12 CellMarginTop", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 58,'',false,'',0)\"";
            ClassString = "btn_Master btn-large btn-block Button";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtnsecuserrole_Internalname, "", "用户", bttBtnsecuserrole_Jsonclick, 7, "用户", "", StyleString, ClassString, 1, 1, "standard", "'"+""+"'"+",false,"+"'"+"e150u1_client"+"'", TempTags, "", 2, "HLP_WWPBaseObjects\\SecRoleView.htm");
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
            wb_table1_62_0U2( true) ;
         }
         else
         {
            wb_table1_62_0U2( false) ;
         }
         return  ;
      }

      protected void wb_table1_62_0U2e( bool wbgen )
      {
         if ( wbgen )
         {
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
         }
         wbLoad = true;
      }

      protected void START0U2( )
      {
         wbLoad = false;
         wbEnd = 0;
         wbStart = 0;
         if ( ! context.isSpaRequest( ) )
         {
            Form.Meta.addItem("generator", "GeneXus C# 16_0_0-127771", 0) ;
            Form.Meta.addItem("description", "Sec Role View", 0) ;
         }
         context.wjLoc = "";
         context.nUserReturn = 0;
         context.wbHandled = 0;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         wbErr = false;
         STRUP0U0( ) ;
      }

      protected void WS0U2( )
      {
         START0U2( ) ;
         EVT0U2( ) ;
      }

      protected void EVT0U2( )
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
                           else if ( StringUtil.StrCmp(sEvt, "DVELOP_CONFIRMPANEL_DELETEROLE.CLOSE") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E160U2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "START") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              /* Execute user event: Start */
                              E170U2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "LOAD") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              /* Execute user event: Load */
                              E180U2 ();
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
                     else if ( StringUtil.StrCmp(sEvtType, "W") == 0 )
                     {
                        sEvtType = StringUtil.Left( sEvt, 4);
                        sEvt = StringUtil.Right( sEvt, (short)(StringUtil.Len( sEvt)-4));
                        nCmpId = (short)(NumberUtil.Val( sEvtType, "."));
                        if ( nCmpId == 30 )
                        {
                           OldGeneralwc = cgiGet( "W0030");
                           if ( ( StringUtil.Len( OldGeneralwc) == 0 ) || ( StringUtil.StrCmp(OldGeneralwc, WebComp_Generalwc_Component) != 0 ) )
                           {
                              WebComp_Generalwc = getWebComponent(GetType(), "GeneXus.Programs", OldGeneralwc, new Object[] {context} );
                              WebComp_Generalwc.ComponentInit();
                              WebComp_Generalwc.Name = "OldGeneralwc";
                              WebComp_Generalwc_Component = OldGeneralwc;
                           }
                           if ( StringUtil.Len( WebComp_Generalwc_Component) != 0 )
                           {
                              WebComp_Generalwc.componentprocess("W0030", "", sEvt);
                           }
                           WebComp_Generalwc_Component = OldGeneralwc;
                        }
                        else if ( nCmpId == 38 )
                        {
                           OldSecfunctionalityrolewc = cgiGet( "W0038");
                           if ( ( StringUtil.Len( OldSecfunctionalityrolewc) == 0 ) || ( StringUtil.StrCmp(OldSecfunctionalityrolewc, WebComp_Secfunctionalityrolewc_Component) != 0 ) )
                           {
                              WebComp_Secfunctionalityrolewc = getWebComponent(GetType(), "GeneXus.Programs", OldSecfunctionalityrolewc, new Object[] {context} );
                              WebComp_Secfunctionalityrolewc.ComponentInit();
                              WebComp_Secfunctionalityrolewc.Name = "OldSecfunctionalityrolewc";
                              WebComp_Secfunctionalityrolewc_Component = OldSecfunctionalityrolewc;
                           }
                           if ( StringUtil.Len( WebComp_Secfunctionalityrolewc_Component) != 0 )
                           {
                              WebComp_Secfunctionalityrolewc.componentprocess("W0038", "", sEvt);
                           }
                           WebComp_Secfunctionalityrolewc_Component = OldSecfunctionalityrolewc;
                        }
                        else if ( nCmpId == 46 )
                        {
                           OldSecuserrolewc = cgiGet( "W0046");
                           if ( ( StringUtil.Len( OldSecuserrolewc) == 0 ) || ( StringUtil.StrCmp(OldSecuserrolewc, WebComp_Secuserrolewc_Component) != 0 ) )
                           {
                              WebComp_Secuserrolewc = getWebComponent(GetType(), "GeneXus.Programs", OldSecuserrolewc, new Object[] {context} );
                              WebComp_Secuserrolewc.ComponentInit();
                              WebComp_Secuserrolewc.Name = "OldSecuserrolewc";
                              WebComp_Secuserrolewc_Component = OldSecuserrolewc;
                           }
                           if ( StringUtil.Len( WebComp_Secuserrolewc_Component) != 0 )
                           {
                              WebComp_Secuserrolewc.componentprocess("W0046", "", sEvt);
                           }
                           WebComp_Secuserrolewc_Component = OldSecuserrolewc;
                        }
                     }
                     context.wbHandled = 1;
                  }
               }
            }
         }
      }

      protected void WE0U2( )
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

      protected void PA0U2( )
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
         RF0U2( ) ;
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

      protected void RF0U2( )
      {
         initialize_formulas( ) ;
         clear_multi_value_controls( ) ;
         if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
         {
            if ( 1 != 0 )
            {
               if ( StringUtil.Len( WebComp_Generalwc_Component) != 0 )
               {
                  WebComp_Generalwc.componentstart();
               }
            }
         }
         if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
         {
            if ( 1 != 0 )
            {
               if ( StringUtil.Len( WebComp_Secfunctionalityrolewc_Component) != 0 )
               {
                  WebComp_Secfunctionalityrolewc.componentstart();
               }
            }
         }
         if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
         {
            if ( 1 != 0 )
            {
               if ( StringUtil.Len( WebComp_Secuserrolewc_Component) != 0 )
               {
                  WebComp_Secuserrolewc.componentstart();
               }
            }
         }
         gxdyncontrolsrefreshing = true;
         fix_multi_value_controls( ) ;
         gxdyncontrolsrefreshing = false;
         if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
         {
            /* Using cursor H000U2 */
            pr_default.execute(0, new Object[] {AV10SecRoleId});
            while ( (pr_default.getStatus(0) != 101) )
            {
               A4SecRoleId = H000U2_A4SecRoleId[0];
               /* Execute user event: Load */
               E180U2 ();
               /* Exiting from a For First loop. */
               if (true) break;
            }
            pr_default.close(0);
            WB0U0( ) ;
         }
      }

      protected void send_integrity_lvl_hashes0U2( )
      {
         GxWebStd.gx_hidden_field( context, "SECROLEID", StringUtil.LTrim( StringUtil.NToC( (decimal)(A4SecRoleId), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "gxhash_SECROLEID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(A4SecRoleId), "ZZZ9"), context));
         GxWebStd.gx_hidden_field( context, "vSECROLEID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV10SecRoleId), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "gxhash_vSECROLEID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV10SecRoleId), "ZZZ9"), context));
      }

      protected void STRUP0U0( )
      {
         /* Before Start, stand alone formulas. */
         context.Gx_err = 0;
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0;
         /* Execute user event: Start */
         E170U2 ();
         context.wbGlbDoneStart = 1;
         /* After Start, stand alone formulas. */
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read saved SDTs. */
            /* Read variables values. */
            /* Read saved values. */
            AV10SecRoleId = (short)(context.localUtil.CToN( cgiGet( "vSECROLEID"), ".", ","));
            AV14LoadAllTabs = StringUtil.StrToBool( cgiGet( "vLOADALLTABS"));
            AV15SelectedTabCode = cgiGet( "vSELECTEDTABCODE");
            Tabs_Class = cgiGet( "TABS_Class");
            Tabs_Activepagecontrolname = cgiGet( "TABS_Activepagecontrolname");
            Tabs_Pagecount = (int)(context.localUtil.CToN( cgiGet( "TABS_Pagecount"), ".", ","));
            Tabs_Historymanagement = StringUtil.StrToBool( cgiGet( "TABS_Historymanagement"));
            Dvelop_confirmpanel_deleterole_Title = cgiGet( "DVELOP_CONFIRMPANEL_DELETEROLE_Title");
            Dvelop_confirmpanel_deleterole_Confirmationtext = cgiGet( "DVELOP_CONFIRMPANEL_DELETEROLE_Confirmationtext");
            Dvelop_confirmpanel_deleterole_Yesbuttoncaption = cgiGet( "DVELOP_CONFIRMPANEL_DELETEROLE_Yesbuttoncaption");
            Dvelop_confirmpanel_deleterole_Nobuttoncaption = cgiGet( "DVELOP_CONFIRMPANEL_DELETEROLE_Nobuttoncaption");
            Dvelop_confirmpanel_deleterole_Cancelbuttoncaption = cgiGet( "DVELOP_CONFIRMPANEL_DELETEROLE_Cancelbuttoncaption");
            Dvelop_confirmpanel_deleterole_Yesbuttonposition = cgiGet( "DVELOP_CONFIRMPANEL_DELETEROLE_Yesbuttonposition");
            Dvelop_confirmpanel_deleterole_Confirmtype = cgiGet( "DVELOP_CONFIRMPANEL_DELETEROLE_Confirmtype");
            Dvelop_confirmpanel_deleterole_Result = cgiGet( "DVELOP_CONFIRMPANEL_DELETEROLE_Result");
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
         E170U2 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E170U2( )
      {
         /* Start Routine */
         new GeneXus.Programs.wwpbaseobjects.loadwwpcontext(context ).execute( out  AV16WWPContext) ;
         AV19GXLvl9 = 0;
         /* Using cursor H000U3 */
         pr_default.execute(1, new Object[] {AV10SecRoleId});
         while ( (pr_default.getStatus(1) != 101) )
         {
            A4SecRoleId = H000U3_A4SecRoleId[0];
            A13SecRoleName = H000U3_A13SecRoleName[0];
            AV19GXLvl9 = 1;
            Form.Caption = A13SecRoleName;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, "FORM", "Caption", Form.Caption, true);
            AV9Exists = true;
            /* Exiting from a For First loop. */
            if (true) break;
         }
         pr_default.close(1);
         if ( AV19GXLvl9 == 0 )
         {
            Form.Caption = "记录未找到";
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, "FORM", "Caption", Form.Caption, true);
            AV9Exists = false;
         }
         if ( AV9Exists )
         {
            AV15SelectedTabCode = AV8TabCode;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV15SelectedTabCode", AV15SelectedTabCode);
            Tabs_Activepagecontrolname = AV15SelectedTabCode;
            ucTabs.SendProperty(context, "", false, Tabs_Internalname, "ActivePageControlName", Tabs_Activepagecontrolname);
            /* Execute user subroutine: 'LOADTABS' */
            S112 ();
            if ( returnInSub )
            {
               returnInSub = true;
               if (true) return;
            }
         }
      }

      protected void nextLoad( )
      {
      }

      protected void E180U2( )
      {
         /* Load Routine */
      }

      protected void E160U2( )
      {
         /* Dvelop_confirmpanel_deleterole_Close Routine */
         if ( StringUtil.StrCmp(Dvelop_confirmpanel_deleterole_Result, "Yes") == 0 )
         {
            /* Execute user subroutine: 'DO ACTION DELETEROLE' */
            S122 ();
            if ( returnInSub )
            {
               returnInSub = true;
               if (true) return;
            }
         }
      }

      protected void S122( )
      {
         /* 'DO ACTION DELETEROLE' Routine */
         new zsr_deleteroleallinfo(context ).execute(  A4SecRoleId) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A4SecRoleId", StringUtil.LTrim( StringUtil.Str( (decimal)(A4SecRoleId), 4, 0)));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_SECROLEID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(A4SecRoleId), "ZZZ9"), context));
         CallWebObject(formatLink("wwpbaseobjects.secroleww.aspx") );
         context.wjLocDisableFrm = 1;
      }

      protected void S112( )
      {
         /* 'LOADTABS' Routine */
         divCell_general_Visible = 1;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, divCell_general_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(divCell_general_Visible), 5, 0)), true);
         if ( AV14LoadAllTabs || ( StringUtil.StrCmp(AV15SelectedTabCode, "") == 0 ) || ( StringUtil.StrCmp(AV15SelectedTabCode, "General") == 0 ) )
         {
            /* Object Property */
            if ( StringUtil.StrCmp(StringUtil.Lower( WebComp_Generalwc_Component), StringUtil.Lower( "WWPBaseObjects.SecRoleGeneral")) != 0 )
            {
               WebComp_Generalwc = getWebComponent(GetType(), "GeneXus.Programs", "wwpbaseobjects.secrolegeneral", new Object[] {context} );
               WebComp_Generalwc.ComponentInit();
               WebComp_Generalwc.Name = "WWPBaseObjects.SecRoleGeneral";
               WebComp_Generalwc_Component = "WWPBaseObjects.SecRoleGeneral";
            }
            if ( StringUtil.Len( WebComp_Generalwc_Component) != 0 )
            {
               WebComp_Generalwc.setjustcreated();
               WebComp_Generalwc.componentprepare(new Object[] {(String)"W0030",(String)"",(short)AV10SecRoleId});
               WebComp_Generalwc.componentbind(new Object[] {(String)""});
            }
            if ( isFullAjaxMode( ) )
            {
               context.httpAjaxContext.ajax_rspStartCmp("gxHTMLWrpW0030"+"");
               WebComp_Generalwc.componentdraw();
               context.httpAjaxContext.ajax_rspEndCmp();
            }
            lblTxttabtitle_Caption = "角色信息";
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, lblTxttabtitle_Internalname, "Caption", lblTxttabtitle_Caption, true);
            if ( ( StringUtil.StrCmp(AV15SelectedTabCode, "") == 0 ) || ( StringUtil.StrCmp(AV15SelectedTabCode, "General") == 0 ) )
            {
               divCell_general_Visible = 0;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, divCell_general_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(divCell_general_Visible), 5, 0)), true);
            }
         }
         divCell_secfunctionalityrole_Visible = 1;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, divCell_secfunctionalityrole_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(divCell_secfunctionalityrole_Visible), 5, 0)), true);
         if ( AV14LoadAllTabs || ( StringUtil.StrCmp(AV15SelectedTabCode, "SecFunctionalityRole") == 0 ) )
         {
            /* Object Property */
            if ( StringUtil.StrCmp(StringUtil.Lower( WebComp_Secfunctionalityrolewc_Component), StringUtil.Lower( "WWPBaseObjects.SecRoleSecFunctionalityRoleWC")) != 0 )
            {
               WebComp_Secfunctionalityrolewc = getWebComponent(GetType(), "GeneXus.Programs", "wwpbaseobjects.secrolesecfunctionalityrolewc", new Object[] {context} );
               WebComp_Secfunctionalityrolewc.ComponentInit();
               WebComp_Secfunctionalityrolewc.Name = "WWPBaseObjects.SecRoleSecFunctionalityRoleWC";
               WebComp_Secfunctionalityrolewc_Component = "WWPBaseObjects.SecRoleSecFunctionalityRoleWC";
            }
            if ( StringUtil.Len( WebComp_Secfunctionalityrolewc_Component) != 0 )
            {
               WebComp_Secfunctionalityrolewc.setjustcreated();
               WebComp_Secfunctionalityrolewc.componentprepare(new Object[] {(String)"W0038",(String)"",(short)AV10SecRoleId});
               WebComp_Secfunctionalityrolewc.componentbind(new Object[] {(String)""});
            }
            if ( isFullAjaxMode( ) )
            {
               context.httpAjaxContext.ajax_rspStartCmp("gxHTMLWrpW0038"+"");
               WebComp_Secfunctionalityrolewc.componentdraw();
               context.httpAjaxContext.ajax_rspEndCmp();
            }
            lblTxttabtitle_Caption = "权限";
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, lblTxttabtitle_Internalname, "Caption", lblTxttabtitle_Caption, true);
            if ( StringUtil.StrCmp(AV15SelectedTabCode, "SecFunctionalityRole") == 0 )
            {
               divCell_secfunctionalityrole_Visible = 0;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, divCell_secfunctionalityrole_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(divCell_secfunctionalityrole_Visible), 5, 0)), true);
            }
         }
         divCell_secuserrole_Visible = 1;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, divCell_secuserrole_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(divCell_secuserrole_Visible), 5, 0)), true);
         if ( AV14LoadAllTabs || ( StringUtil.StrCmp(AV15SelectedTabCode, "SecUserRole") == 0 ) )
         {
            /* Object Property */
            if ( StringUtil.StrCmp(StringUtil.Lower( WebComp_Secuserrolewc_Component), StringUtil.Lower( "WWPBaseObjects.SecRoleSecUserRoleWC")) != 0 )
            {
               WebComp_Secuserrolewc = getWebComponent(GetType(), "GeneXus.Programs", "wwpbaseobjects.secrolesecuserrolewc", new Object[] {context} );
               WebComp_Secuserrolewc.ComponentInit();
               WebComp_Secuserrolewc.Name = "WWPBaseObjects.SecRoleSecUserRoleWC";
               WebComp_Secuserrolewc_Component = "WWPBaseObjects.SecRoleSecUserRoleWC";
            }
            if ( StringUtil.Len( WebComp_Secuserrolewc_Component) != 0 )
            {
               WebComp_Secuserrolewc.setjustcreated();
               WebComp_Secuserrolewc.componentprepare(new Object[] {(String)"W0046",(String)"",(short)AV10SecRoleId});
               WebComp_Secuserrolewc.componentbind(new Object[] {(String)""});
            }
            if ( isFullAjaxMode( ) )
            {
               context.httpAjaxContext.ajax_rspStartCmp("gxHTMLWrpW0046"+"");
               WebComp_Secuserrolewc.componentdraw();
               context.httpAjaxContext.ajax_rspEndCmp();
            }
            lblTxttabtitle_Caption = "用户";
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, lblTxttabtitle_Internalname, "Caption", lblTxttabtitle_Caption, true);
            if ( StringUtil.StrCmp(AV15SelectedTabCode, "SecUserRole") == 0 )
            {
               divCell_secuserrole_Visible = 0;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, divCell_secuserrole_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(divCell_secuserrole_Visible), 5, 0)), true);
            }
         }
      }

      protected void wb_table1_62_0U2( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "";
            GxWebStd.gx_table_start( context, tblTabledvelop_confirmpanel_deleterole_Internalname, tblTabledvelop_confirmpanel_deleterole_Internalname, "", "Table", 0, "", "", 1, 2, sStyleString, "", "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td data-align=\"center\"  style=\""+CSSHelper.Prettify( "text-align:-khtml-center;text-align:-moz-center;text-align:-webkit-center")+"\">") ;
            /* User Defined Control */
            ucDvelop_confirmpanel_deleterole.SetProperty("Title", Dvelop_confirmpanel_deleterole_Title);
            ucDvelop_confirmpanel_deleterole.SetProperty("ConfirmationText", Dvelop_confirmpanel_deleterole_Confirmationtext);
            ucDvelop_confirmpanel_deleterole.SetProperty("YesButtonCaption", Dvelop_confirmpanel_deleterole_Yesbuttoncaption);
            ucDvelop_confirmpanel_deleterole.SetProperty("NoButtonCaption", Dvelop_confirmpanel_deleterole_Nobuttoncaption);
            ucDvelop_confirmpanel_deleterole.SetProperty("CancelButtonCaption", Dvelop_confirmpanel_deleterole_Cancelbuttoncaption);
            ucDvelop_confirmpanel_deleterole.SetProperty("YesButtonPosition", Dvelop_confirmpanel_deleterole_Yesbuttonposition);
            ucDvelop_confirmpanel_deleterole.SetProperty("ConfirmType", Dvelop_confirmpanel_deleterole_Confirmtype);
            ucDvelop_confirmpanel_deleterole.Render(context, "dvelop.gxbootstrap.confirmpanel", Dvelop_confirmpanel_deleterole_Internalname, "DVELOP_CONFIRMPANEL_DELETEROLEContainer");
            context.WriteHtmlText( "<div class=\"gx_usercontrol_child\" id=\""+"DVELOP_CONFIRMPANEL_DELETEROLEContainer"+"Body"+"\" style=\"display:none;\">") ;
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table1_62_0U2e( true) ;
         }
         else
         {
            wb_table1_62_0U2e( false) ;
         }
      }

      public override void setparameters( Object[] obj )
      {
         createObjects();
         initialize();
         AV10SecRoleId = Convert.ToInt16(getParm(obj,0));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10SecRoleId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10SecRoleId), 4, 0)));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vSECROLEID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV10SecRoleId), "ZZZ9"), context));
         AV8TabCode = (String)getParm(obj,1);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8TabCode", AV8TabCode);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vTABCODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( AV8TabCode, "")), context));
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
         PA0U2( ) ;
         WS0U2( ) ;
         WE0U2( ) ;
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
         if ( ! ( WebComp_Generalwc == null ) )
         {
            if ( StringUtil.Len( WebComp_Generalwc_Component) != 0 )
            {
               WebComp_Generalwc.componentthemes();
            }
         }
         if ( ! ( WebComp_Secfunctionalityrolewc == null ) )
         {
            if ( StringUtil.Len( WebComp_Secfunctionalityrolewc_Component) != 0 )
            {
               WebComp_Secfunctionalityrolewc.componentthemes();
            }
         }
         if ( ! ( WebComp_Secuserrolewc == null ) )
         {
            if ( StringUtil.Len( WebComp_Secuserrolewc_Component) != 0 )
            {
               WebComp_Secuserrolewc.componentthemes();
            }
         }
         bool outputEnabled = isOutputEnabled( ) ;
         if ( context.isSpaRequest( ) )
         {
            enableOutput();
         }
         idxLst = 1;
         while ( idxLst <= Form.Jscriptsrc.Count )
         {
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?202022711583060", true);
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
         context.AddJavascriptSource("wwpbaseobjects/secroleview.js", "?202022711583060", false);
         context.AddJavascriptSource("Shared/HistoryManager/HistoryManager.js", "", false);
         context.AddJavascriptSource("Shared/HistoryManager/rsh/json2005.js", "", false);
         context.AddJavascriptSource("Shared/HistoryManager/rsh/rsh.js", "", false);
         context.AddJavascriptSource("Shared/HistoryManager/HistoryManagerCreate.js", "", false);
         context.AddJavascriptSource("Tab/TabRender.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/Shared/DVelopBootstrap.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/ConfirmPanel/BootstrapConfirmPanelRender.js", "", false);
         /* End function include_jscripts */
      }

      protected void init_web_controls( )
      {
         /* End function init_web_controls */
      }

      protected void init_default_properties( )
      {
         bttBtndeleterole_Internalname = "BTNDELETEROLE";
         bttBtnreturn_Internalname = "BTNRETURN";
         lblTxttabtitle_Internalname = "TXTTABTITLE";
         lblGeneral_title_Internalname = "GENERAL_TITLE";
         divUnnamedtablegeneral_Internalname = "UNNAMEDTABLEGENERAL";
         lblSecfunctionalityrole_title_Internalname = "SECFUNCTIONALITYROLE_TITLE";
         divUnnamedtablesecfunctionalityrole_Internalname = "UNNAMEDTABLESECFUNCTIONALITYROLE";
         lblSecuserrole_title_Internalname = "SECUSERROLE_TITLE";
         divUnnamedtablesecuserrole_Internalname = "UNNAMEDTABLESECUSERROLE";
         Tabs_Internalname = "TABS";
         bttBtngeneral_Internalname = "BTNGENERAL";
         divCell_general_Internalname = "CELL_GENERAL";
         bttBtnsecfunctionalityrole_Internalname = "BTNSECFUNCTIONALITYROLE";
         divCell_secfunctionalityrole_Internalname = "CELL_SECFUNCTIONALITYROLE";
         bttBtnsecuserrole_Internalname = "BTNSECUSERROLE";
         divCell_secuserrole_Internalname = "CELL_SECUSERROLE";
         divUnnamedtabletabscontainer_Internalname = "UNNAMEDTABLETABSCONTAINER";
         divUnnamedtableviewcontainer_Internalname = "UNNAMEDTABLEVIEWCONTAINER";
         divTablemain_Internalname = "TABLEMAIN";
         Dvelop_confirmpanel_deleterole_Internalname = "DVELOP_CONFIRMPANEL_DELETEROLE";
         tblTabledvelop_confirmpanel_deleterole_Internalname = "TABLEDVELOP_CONFIRMPANEL_DELETEROLE";
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
         divCell_secuserrole_Visible = 1;
         divCell_secfunctionalityrole_Visible = 1;
         divCell_general_Visible = 1;
         lblTxttabtitle_Caption = "Title";
         Dvelop_confirmpanel_deleterole_Confirmtype = "1";
         Dvelop_confirmpanel_deleterole_Yesbuttonposition = "left";
         Dvelop_confirmpanel_deleterole_Cancelbuttoncaption = "WWP_ConfirmTextCancel";
         Dvelop_confirmpanel_deleterole_Nobuttoncaption = "WWP_ConfirmTextNo";
         Dvelop_confirmpanel_deleterole_Yesbuttoncaption = "WWP_ConfirmTextYes";
         Dvelop_confirmpanel_deleterole_Confirmationtext = "确认删除？";
         Dvelop_confirmpanel_deleterole_Title = "";
         Tabs_Historymanagement = Convert.ToBoolean( -1);
         Tabs_Pagecount = 3;
         Tabs_Class = "ViewTab Tab";
         Form.Headerrawhtml = "";
         Form.Background = "";
         Form.Textcolor = 0;
         Form.Backcolor = (int)(0xFFFFFF);
         Form.Caption = "Sec Role View";
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
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[{av:'AV10SecRoleId',fld:'vSECROLEID',pic:'ZZZ9',hsh:true},{av:'AV8TabCode',fld:'vTABCODE',pic:'',hsh:true},{av:'A4SecRoleId',fld:'SECROLEID',pic:'ZZZ9',hsh:true}]");
         setEventMetadata("REFRESH",",oparms:[]}");
         setEventMetadata("'DODELETEROLE'","{handler:'E110U1',iparms:[]");
         setEventMetadata("'DODELETEROLE'",",oparms:[]}");
         setEventMetadata("DVELOP_CONFIRMPANEL_DELETEROLE.CLOSE","{handler:'E160U2',iparms:[{av:'Dvelop_confirmpanel_deleterole_Result',ctrl:'DVELOP_CONFIRMPANEL_DELETEROLE',prop:'Result'},{av:'A4SecRoleId',fld:'SECROLEID',pic:'ZZZ9',hsh:true}]");
         setEventMetadata("DVELOP_CONFIRMPANEL_DELETEROLE.CLOSE",",oparms:[]}");
         setEventMetadata("'DORETURN'","{handler:'E120U1',iparms:[]");
         setEventMetadata("'DORETURN'",",oparms:[]}");
         setEventMetadata("'GENERAL'","{handler:'E130U1',iparms:[{av:'AV14LoadAllTabs',fld:'vLOADALLTABS',pic:''},{av:'AV15SelectedTabCode',fld:'vSELECTEDTABCODE',pic:''},{av:'AV10SecRoleId',fld:'vSECROLEID',pic:'ZZZ9',hsh:true}]");
         setEventMetadata("'GENERAL'",",oparms:[{av:'AV15SelectedTabCode',fld:'vSELECTEDTABCODE',pic:''},{av:'AV14LoadAllTabs',fld:'vLOADALLTABS',pic:''},{av:'divCell_general_Visible',ctrl:'CELL_GENERAL',prop:'Visible'},{ctrl:'GENERALWC'},{av:'lblTxttabtitle_Caption',ctrl:'TXTTABTITLE',prop:'Caption'},{av:'divCell_secfunctionalityrole_Visible',ctrl:'CELL_SECFUNCTIONALITYROLE',prop:'Visible'},{ctrl:'SECFUNCTIONALITYROLEWC'},{av:'divCell_secuserrole_Visible',ctrl:'CELL_SECUSERROLE',prop:'Visible'},{ctrl:'SECUSERROLEWC'}]}");
         setEventMetadata("'SECFUNCTIONALITYROLE'","{handler:'E140U1',iparms:[{av:'AV14LoadAllTabs',fld:'vLOADALLTABS',pic:''},{av:'AV15SelectedTabCode',fld:'vSELECTEDTABCODE',pic:''},{av:'AV10SecRoleId',fld:'vSECROLEID',pic:'ZZZ9',hsh:true}]");
         setEventMetadata("'SECFUNCTIONALITYROLE'",",oparms:[{av:'AV15SelectedTabCode',fld:'vSELECTEDTABCODE',pic:''},{av:'AV14LoadAllTabs',fld:'vLOADALLTABS',pic:''},{av:'divCell_general_Visible',ctrl:'CELL_GENERAL',prop:'Visible'},{ctrl:'GENERALWC'},{av:'lblTxttabtitle_Caption',ctrl:'TXTTABTITLE',prop:'Caption'},{av:'divCell_secfunctionalityrole_Visible',ctrl:'CELL_SECFUNCTIONALITYROLE',prop:'Visible'},{ctrl:'SECFUNCTIONALITYROLEWC'},{av:'divCell_secuserrole_Visible',ctrl:'CELL_SECUSERROLE',prop:'Visible'},{ctrl:'SECUSERROLEWC'}]}");
         setEventMetadata("'SECUSERROLE'","{handler:'E150U1',iparms:[{av:'AV14LoadAllTabs',fld:'vLOADALLTABS',pic:''},{av:'AV15SelectedTabCode',fld:'vSELECTEDTABCODE',pic:''},{av:'AV10SecRoleId',fld:'vSECROLEID',pic:'ZZZ9',hsh:true}]");
         setEventMetadata("'SECUSERROLE'",",oparms:[{av:'AV15SelectedTabCode',fld:'vSELECTEDTABCODE',pic:''},{av:'AV14LoadAllTabs',fld:'vLOADALLTABS',pic:''},{av:'divCell_general_Visible',ctrl:'CELL_GENERAL',prop:'Visible'},{ctrl:'GENERALWC'},{av:'lblTxttabtitle_Caption',ctrl:'TXTTABTITLE',prop:'Caption'},{av:'divCell_secfunctionalityrole_Visible',ctrl:'CELL_SECFUNCTIONALITYROLE',prop:'Visible'},{ctrl:'SECFUNCTIONALITYROLEWC'},{av:'divCell_secuserrole_Visible',ctrl:'CELL_SECUSERROLE',prop:'Visible'},{ctrl:'SECUSERROLEWC'}]}");
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
         wcpOAV8TabCode = "";
         Dvelop_confirmpanel_deleterole_Result = "";
         Tabs_Activepagecontrolname = "";
         gxfirstwebparm = "";
         gxfirstwebparm_bkp = "";
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         GXKey = "";
         AV15SelectedTabCode = "";
         GX_FocusControl = "";
         Form = new GXWebForm();
         sPrefix = "";
         TempTags = "";
         ClassString = "";
         StyleString = "";
         bttBtndeleterole_Jsonclick = "";
         bttBtnreturn_Jsonclick = "";
         lblTxttabtitle_Jsonclick = "";
         ucTabs = new GXUserControl();
         lblGeneral_title_Jsonclick = "";
         WebComp_Generalwc_Component = "";
         OldGeneralwc = "";
         lblSecfunctionalityrole_title_Jsonclick = "";
         WebComp_Secfunctionalityrolewc_Component = "";
         OldSecfunctionalityrolewc = "";
         lblSecuserrole_title_Jsonclick = "";
         WebComp_Secuserrolewc_Component = "";
         OldSecuserrolewc = "";
         bttBtngeneral_Jsonclick = "";
         bttBtnsecfunctionalityrole_Jsonclick = "";
         bttBtnsecuserrole_Jsonclick = "";
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         scmdbuf = "";
         H000U2_A4SecRoleId = new short[1] ;
         AV16WWPContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPContext(context);
         H000U3_A4SecRoleId = new short[1] ;
         H000U3_A13SecRoleName = new String[] {""} ;
         A13SecRoleName = "";
         sStyleString = "";
         ucDvelop_confirmpanel_deleterole = new GXUserControl();
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.wwpbaseobjects.secroleview__default(),
            new Object[][] {
                new Object[] {
               H000U2_A4SecRoleId
               }
               , new Object[] {
               H000U3_A4SecRoleId, H000U3_A13SecRoleName
               }
            }
         );
         WebComp_Generalwc = new GeneXus.Http.GXNullWebComponent();
         WebComp_Secfunctionalityrolewc = new GeneXus.Http.GXNullWebComponent();
         WebComp_Secuserrolewc = new GeneXus.Http.GXNullWebComponent();
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private short AV10SecRoleId ;
      private short wcpOAV10SecRoleId ;
      private short nGotPars ;
      private short GxWebError ;
      private short initialized ;
      private short gxajaxcallmode ;
      private short A4SecRoleId ;
      private short wbEnd ;
      private short wbStart ;
      private short nCmpId ;
      private short nDonePA ;
      private short gxcookieaux ;
      private short AV19GXLvl9 ;
      private short nGXWrapped ;
      private int Tabs_Pagecount ;
      private int divCell_general_Visible ;
      private int divCell_secfunctionalityrole_Visible ;
      private int divCell_secuserrole_Visible ;
      private int idxLst ;
      private String AV8TabCode ;
      private String wcpOAV8TabCode ;
      private String Dvelop_confirmpanel_deleterole_Result ;
      private String Tabs_Activepagecontrolname ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String sDynURL ;
      private String FormProcess ;
      private String bodyStyle ;
      private String GXKey ;
      private String AV15SelectedTabCode ;
      private String Tabs_Class ;
      private String Dvelop_confirmpanel_deleterole_Title ;
      private String Dvelop_confirmpanel_deleterole_Confirmationtext ;
      private String Dvelop_confirmpanel_deleterole_Yesbuttoncaption ;
      private String Dvelop_confirmpanel_deleterole_Nobuttoncaption ;
      private String Dvelop_confirmpanel_deleterole_Cancelbuttoncaption ;
      private String Dvelop_confirmpanel_deleterole_Yesbuttonposition ;
      private String Dvelop_confirmpanel_deleterole_Confirmtype ;
      private String GX_FocusControl ;
      private String sPrefix ;
      private String divLayoutmaintable_Internalname ;
      private String divTablemain_Internalname ;
      private String TempTags ;
      private String ClassString ;
      private String StyleString ;
      private String bttBtndeleterole_Internalname ;
      private String bttBtndeleterole_Jsonclick ;
      private String bttBtnreturn_Internalname ;
      private String bttBtnreturn_Jsonclick ;
      private String divUnnamedtableviewcontainer_Internalname ;
      private String lblTxttabtitle_Internalname ;
      private String lblTxttabtitle_Caption ;
      private String lblTxttabtitle_Jsonclick ;
      private String Tabs_Internalname ;
      private String lblGeneral_title_Internalname ;
      private String lblGeneral_title_Jsonclick ;
      private String divUnnamedtablegeneral_Internalname ;
      private String WebComp_Generalwc_Component ;
      private String OldGeneralwc ;
      private String lblSecfunctionalityrole_title_Internalname ;
      private String lblSecfunctionalityrole_title_Jsonclick ;
      private String divUnnamedtablesecfunctionalityrole_Internalname ;
      private String WebComp_Secfunctionalityrolewc_Component ;
      private String OldSecfunctionalityrolewc ;
      private String lblSecuserrole_title_Internalname ;
      private String lblSecuserrole_title_Jsonclick ;
      private String divUnnamedtablesecuserrole_Internalname ;
      private String WebComp_Secuserrolewc_Component ;
      private String OldSecuserrolewc ;
      private String divUnnamedtabletabscontainer_Internalname ;
      private String divCell_general_Internalname ;
      private String bttBtngeneral_Internalname ;
      private String bttBtngeneral_Jsonclick ;
      private String divCell_secfunctionalityrole_Internalname ;
      private String bttBtnsecfunctionalityrole_Internalname ;
      private String bttBtnsecfunctionalityrole_Jsonclick ;
      private String divCell_secuserrole_Internalname ;
      private String bttBtnsecuserrole_Internalname ;
      private String bttBtnsecuserrole_Jsonclick ;
      private String divHtml_bottomauxiliarcontrols_Internalname ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String scmdbuf ;
      private String sStyleString ;
      private String tblTabledvelop_confirmpanel_deleterole_Internalname ;
      private String Dvelop_confirmpanel_deleterole_Internalname ;
      private bool entryPointCalled ;
      private bool toggleJsOutput ;
      private bool AV14LoadAllTabs ;
      private bool Tabs_Historymanagement ;
      private bool wbLoad ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool gxdyncontrolsrefreshing ;
      private bool returnInSub ;
      private bool AV9Exists ;
      private String A13SecRoleName ;
      private GXWebComponent WebComp_Generalwc ;
      private GXWebComponent WebComp_Secfunctionalityrolewc ;
      private GXWebComponent WebComp_Secuserrolewc ;
      private GXUserControl ucTabs ;
      private GXUserControl ucDvelop_confirmpanel_deleterole ;
      private IGxDataStore dsDataStore1 ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private short[] H000U2_A4SecRoleId ;
      private short[] H000U3_A4SecRoleId ;
      private String[] H000U3_A13SecRoleName ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private GXWebForm Form ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPContext AV16WWPContext ;
   }

   public class secroleview__default : DataStoreHelperBase, IDataStoreHelper
   {
      public ICursor[] getCursors( )
      {
         cursorDefinitions();
         return new Cursor[] {
          new ForEachCursor(def[0])
         ,new ForEachCursor(def[1])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmH000U2 ;
          prmH000U2 = new Object[] {
          new Object[] {"@AV10SecRoleId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmH000U3 ;
          prmH000U3 = new Object[] {
          new Object[] {"@AV10SecRoleId",SqlDbType.SmallInt,4,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("H000U2", "SELECT [SecRoleId] FROM [SecRole] WITH (NOLOCK) WHERE [SecRoleId] = @AV10SecRoleId ORDER BY [SecRoleId] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH000U2,1,0,true,true )
             ,new CursorDef("H000U3", "SELECT [SecRoleId], [SecRoleName] FROM [SecRole] WITH (NOLOCK) WHERE [SecRoleId] = @AV10SecRoleId ORDER BY [SecRoleId] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH000U3,1,0,false,true )
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
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                return;
             case 1 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
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
                stmt.SetParameter(1, (short)parms[0]);
                return;
             case 1 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
       }
    }

 }

}
