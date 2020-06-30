/*
               File: BR_InformationView
        Description: Data Mgmt Portal - RAAP
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/27/2020 9:39:32.54
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
   public class br_informationview : GXDataArea, System.Web.SessionState.IRequiresSessionState
   {
      public br_informationview( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public br_informationview( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( long aP0_BR_Information_ID ,
                           String aP1_TabCode )
      {
         this.AV10BR_Information_ID = aP0_BR_Information_ID;
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
               AV10BR_Information_ID = (long)(NumberUtil.Val( gxfirstwebparm, "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10BR_Information_ID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10BR_Information_ID), 18, 0)));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vBR_INFORMATION_ID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV10BR_Information_ID), "ZZZZZZZZZZZZZZZZZZ"), context));
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
         PA1K2( ) ;
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0));
         if ( ( gxajaxcallmode == 0 ) && ( GxWebError == 0 ) )
         {
            START1K2( ) ;
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
         context.AddJavascriptSource("gxcfg.js", "?20202279393259", false);
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" autocomplete=\"off\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("br_informationview.aspx") + "?" + UrlEncode("" +AV10BR_Information_ID) + "," + UrlEncode(StringUtil.RTrim(AV8TabCode))+"\">") ;
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
         GxWebStd.gx_hidden_field( context, "vBR_INFORMATION_ID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV10BR_Information_ID), 18, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "gxhash_vBR_INFORMATION_ID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV10BR_Information_ID), "ZZZZZZZZZZZZZZZZZZ"), context));
         GxWebStd.gx_hidden_field( context, "BR_INFORMATION_ID", StringUtil.LTrim( StringUtil.NToC( (decimal)(A85BR_Information_ID), 18, 0, ".", "")));
         GxWebStd.gx_boolean_hidden_field( context, "vLOADALLTABS", AV11LoadAllTabs);
         GxWebStd.gx_hidden_field( context, "vSELECTEDTABCODE", StringUtil.RTrim( AV12SelectedTabCode));
         GxWebStd.gx_hidden_field( context, "vTABCODE", StringUtil.RTrim( AV8TabCode));
         GxWebStd.gx_hidden_field( context, "gxhash_vTABCODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( AV8TabCode, "")), context));
         GxWebStd.gx_hidden_field( context, "TABS_Class", StringUtil.RTrim( Tabs_Class));
         GxWebStd.gx_hidden_field( context, "TABS_Activepagecontrolname", StringUtil.RTrim( Tabs_Activepagecontrolname));
         GxWebStd.gx_hidden_field( context, "TABS_Pagecount", StringUtil.LTrim( StringUtil.NToC( (decimal)(Tabs_Pagecount), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "TABS_Historymanagement", StringUtil.BoolToStr( Tabs_Historymanagement));
         GxWebStd.gx_hidden_field( context, "DVELOP_CONFIRMPANEL_DELETEALLINFO_Title", StringUtil.RTrim( Dvelop_confirmpanel_deleteallinfo_Title));
         GxWebStd.gx_hidden_field( context, "DVELOP_CONFIRMPANEL_DELETEALLINFO_Confirmationtext", StringUtil.RTrim( Dvelop_confirmpanel_deleteallinfo_Confirmationtext));
         GxWebStd.gx_hidden_field( context, "DVELOP_CONFIRMPANEL_DELETEALLINFO_Yesbuttoncaption", StringUtil.RTrim( Dvelop_confirmpanel_deleteallinfo_Yesbuttoncaption));
         GxWebStd.gx_hidden_field( context, "DVELOP_CONFIRMPANEL_DELETEALLINFO_Nobuttoncaption", StringUtil.RTrim( Dvelop_confirmpanel_deleteallinfo_Nobuttoncaption));
         GxWebStd.gx_hidden_field( context, "DVELOP_CONFIRMPANEL_DELETEALLINFO_Cancelbuttoncaption", StringUtil.RTrim( Dvelop_confirmpanel_deleteallinfo_Cancelbuttoncaption));
         GxWebStd.gx_hidden_field( context, "DVELOP_CONFIRMPANEL_DELETEALLINFO_Yesbuttonposition", StringUtil.RTrim( Dvelop_confirmpanel_deleteallinfo_Yesbuttonposition));
         GxWebStd.gx_hidden_field( context, "DVELOP_CONFIRMPANEL_DELETEALLINFO_Confirmtype", StringUtil.RTrim( Dvelop_confirmpanel_deleteallinfo_Confirmtype));
         GxWebStd.gx_hidden_field( context, "DVELOP_CONFIRMPANEL_DELETEALLINFO_Result", StringUtil.RTrim( Dvelop_confirmpanel_deleteallinfo_Result));
         GxWebStd.gx_hidden_field( context, "TABS_Activepagecontrolname", StringUtil.RTrim( Tabs_Activepagecontrolname));
         GxWebStd.gx_hidden_field( context, "DVELOP_CONFIRMPANEL_DELETEALLINFO_Result", StringUtil.RTrim( Dvelop_confirmpanel_deleteallinfo_Result));
         GxWebStd.gx_hidden_field( context, "TABS_Activepagecontrolname", StringUtil.RTrim( Tabs_Activepagecontrolname));
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
         if ( ! ( WebComp_Br_encounterwc == null ) )
         {
            WebComp_Br_encounterwc.componentjscripts();
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
            WE1K2( ) ;
            context.WriteHtmlText( "</div>") ;
         }
      }

      public override void DispatchEvents( )
      {
         EVT1K2( ) ;
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
         return formatLink("br_informationview.aspx") + "?" + UrlEncode("" +AV10BR_Information_ID) + "," + UrlEncode(StringUtil.RTrim(AV8TabCode)) ;
      }

      public override String GetPgmname( )
      {
         return "BR_InformationView" ;
      }

      public override String GetPgmdesc( )
      {
         return "Data Mgmt Portal - RAAP" ;
      }

      protected void WB1K0( )
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
            ClassString = "ButtonMaterial hidden-xs hidden-sm hidden-md hidden-lg";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtndeleteallinfo_Internalname, "", "删除该患者以及所有信息", bttBtndeleteallinfo_Jsonclick, 7, "删除该患者以及所有信息", "", StyleString, ClassString, bttBtndeleteallinfo_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"e111k1_client"+"'", TempTags, "", 2, "HLP_BR_InformationView.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 13,'',false,'',0)\"";
            ClassString = "ButtonMaterial";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtnreturn_Internalname, "", "返回", bttBtnreturn_Jsonclick, 5, "返回", "", StyleString, ClassString, 1, 1, "standard", "'"+""+"'"+",false,"+"'"+"E\\'DORETURN\\'."+"'", TempTags, "", context.GetButtonType( ), "HLP_BR_InformationView.htm");
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
            GxWebStd.gx_label_ctrl( context, lblTxttabtitle_Internalname, lblTxttabtitle_Caption, "", "", lblTxttabtitle_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "TextBlockTitleWWPTab", 0, "", 1, 1, 0, "HLP_BR_InformationView.htm");
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
            GxWebStd.gx_label_ctrl( context, lblGeneral_title_Internalname, "患者信息", "", "", lblGeneral_title_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "TextBlock", 0, "", 1, 1, 0, "HLP_BR_InformationView.htm");
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
            GxWebStd.gx_label_ctrl( context, lblBr_encounter_title_Internalname, "就诊信息", "", "", lblBr_encounter_title_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "TextBlock", 0, "", 1, 1, 0, "HLP_BR_InformationView.htm");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "Section", "left", "top", "", "display:none;", "div");
            context.WriteHtmlText( "br_encounter") ;
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "<div class=\"gx_usercontrol_child\" id=\""+"TABSContainer"+"panel2"+"\" style=\"display:none;\">") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, divUnnamedtablebr_encounter_Internalname, 1, 0, "px", 0, "px", "TableViewTab", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            if ( ! isFullAjaxMode( ) )
            {
               /* WebComponent */
               GxWebStd.gx_hidden_field( context, "W0038"+"", StringUtil.RTrim( WebComp_Br_encounterwc_Component));
               context.WriteHtmlText( "<div") ;
               GxWebStd.ClassAttribute( context, "gxwebcomponent");
               context.WriteHtmlText( " id=\""+"gxHTMLWrpW0038"+""+"\""+"") ;
               context.WriteHtmlText( ">") ;
               if ( StringUtil.Len( WebComp_Br_encounterwc_Component) != 0 )
               {
                  if ( StringUtil.StrCmp(StringUtil.Lower( OldBr_encounterwc), StringUtil.Lower( WebComp_Br_encounterwc_Component)) != 0 )
                  {
                     context.httpAjaxContext.ajax_rspStartCmp("gxHTMLWrpW0038"+"");
                  }
                  WebComp_Br_encounterwc.componentdraw();
                  if ( StringUtil.StrCmp(StringUtil.Lower( OldBr_encounterwc), StringUtil.Lower( WebComp_Br_encounterwc_Component)) != 0 )
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
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 44,'',false,'',0)\"";
            ClassString = "btn_Master btn-large btn-block Button";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtngeneral_Internalname, "", "患者信息", bttBtngeneral_Jsonclick, 5, "患者信息", "", StyleString, ClassString, 1, 1, "standard", "'"+""+"'"+",false,"+"'"+"E\\'GENERAL\\'."+"'", TempTags, "", context.GetButtonType( ), "HLP_BR_InformationView.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divCell_br_encounter_Internalname, divCell_br_encounter_Visible, 0, "px", 0, "px", "col-xs-12 CellMarginTop", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 47,'',false,'',0)\"";
            ClassString = "btn_Master btn-large btn-block Button";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtnbr_encounter_Internalname, "", "就诊信息", bttBtnbr_encounter_Jsonclick, 5, "就诊信息", "", StyleString, ClassString, 1, 1, "standard", "'"+""+"'"+",false,"+"'"+"E\\'BR_ENCOUNTER\\'."+"'", TempTags, "", context.GetButtonType( ), "HLP_BR_InformationView.htm");
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
            wb_table1_51_1K2( true) ;
         }
         else
         {
            wb_table1_51_1K2( false) ;
         }
         return  ;
      }

      protected void wb_table1_51_1K2e( bool wbgen )
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

      protected void START1K2( )
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
         STRUP1K0( ) ;
      }

      protected void WS1K2( )
      {
         START1K2( ) ;
         EVT1K2( ) ;
      }

      protected void EVT1K2( )
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
                           else if ( StringUtil.StrCmp(sEvt, "TABS.TABCHANGED") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E121K2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "DVELOP_CONFIRMPANEL_DELETEALLINFO.CLOSE") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E131K2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "START") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              /* Execute user event: Start */
                              E141K2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "REFRESH") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              /* Execute user event: Refresh */
                              E151K2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "LOAD") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              /* Execute user event: Load */
                              E161K2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "'DORETURN'") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              /* Execute user event: 'Doreturn' */
                              E171K2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "'GENERAL'") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              /* Execute user event: 'General' */
                              E181K2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "'BR_ENCOUNTER'") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              /* Execute user event: 'br_encounter' */
                              E191K2 ();
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
                           OldBr_encounterwc = cgiGet( "W0038");
                           if ( ( StringUtil.Len( OldBr_encounterwc) == 0 ) || ( StringUtil.StrCmp(OldBr_encounterwc, WebComp_Br_encounterwc_Component) != 0 ) )
                           {
                              WebComp_Br_encounterwc = getWebComponent(GetType(), "GeneXus.Programs", OldBr_encounterwc, new Object[] {context} );
                              WebComp_Br_encounterwc.ComponentInit();
                              WebComp_Br_encounterwc.Name = "OldBr_encounterwc";
                              WebComp_Br_encounterwc_Component = OldBr_encounterwc;
                           }
                           if ( StringUtil.Len( WebComp_Br_encounterwc_Component) != 0 )
                           {
                              WebComp_Br_encounterwc.componentprocess("W0038", "", sEvt);
                           }
                           WebComp_Br_encounterwc_Component = OldBr_encounterwc;
                        }
                     }
                     context.wbHandled = 1;
                  }
               }
            }
         }
      }

      protected void WE1K2( )
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

      protected void PA1K2( )
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
         RF1K2( ) ;
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

      protected void RF1K2( )
      {
         initialize_formulas( ) ;
         clear_multi_value_controls( ) ;
         /* Execute user event: Refresh */
         E151K2 ();
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
               if ( StringUtil.Len( WebComp_Br_encounterwc_Component) != 0 )
               {
                  WebComp_Br_encounterwc.componentstart();
               }
            }
         }
         gxdyncontrolsrefreshing = true;
         fix_multi_value_controls( ) ;
         gxdyncontrolsrefreshing = false;
         if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
         {
            /* Execute user event: Load */
            E161K2 ();
            WB1K0( ) ;
         }
      }

      protected void send_integrity_lvl_hashes1K2( )
      {
         GxWebStd.gx_hidden_field( context, "vBR_INFORMATION_ID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV10BR_Information_ID), 18, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "gxhash_vBR_INFORMATION_ID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV10BR_Information_ID), "ZZZZZZZZZZZZZZZZZZ"), context));
      }

      protected void STRUP1K0( )
      {
         /* Before Start, stand alone formulas. */
         context.Gx_err = 0;
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0;
         /* Execute user event: Start */
         E141K2 ();
         context.wbGlbDoneStart = 1;
         /* After Start, stand alone formulas. */
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read saved SDTs. */
            /* Read variables values. */
            /* Read saved values. */
            Tabs_Class = cgiGet( "TABS_Class");
            Tabs_Activepagecontrolname = cgiGet( "TABS_Activepagecontrolname");
            Tabs_Pagecount = (int)(context.localUtil.CToN( cgiGet( "TABS_Pagecount"), ".", ","));
            Tabs_Historymanagement = StringUtil.StrToBool( cgiGet( "TABS_Historymanagement"));
            Dvelop_confirmpanel_deleteallinfo_Title = cgiGet( "DVELOP_CONFIRMPANEL_DELETEALLINFO_Title");
            Dvelop_confirmpanel_deleteallinfo_Confirmationtext = cgiGet( "DVELOP_CONFIRMPANEL_DELETEALLINFO_Confirmationtext");
            Dvelop_confirmpanel_deleteallinfo_Yesbuttoncaption = cgiGet( "DVELOP_CONFIRMPANEL_DELETEALLINFO_Yesbuttoncaption");
            Dvelop_confirmpanel_deleteallinfo_Nobuttoncaption = cgiGet( "DVELOP_CONFIRMPANEL_DELETEALLINFO_Nobuttoncaption");
            Dvelop_confirmpanel_deleteallinfo_Cancelbuttoncaption = cgiGet( "DVELOP_CONFIRMPANEL_DELETEALLINFO_Cancelbuttoncaption");
            Dvelop_confirmpanel_deleteallinfo_Yesbuttonposition = cgiGet( "DVELOP_CONFIRMPANEL_DELETEALLINFO_Yesbuttonposition");
            Dvelop_confirmpanel_deleteallinfo_Confirmtype = cgiGet( "DVELOP_CONFIRMPANEL_DELETEALLINFO_Confirmtype");
            Dvelop_confirmpanel_deleteallinfo_Result = cgiGet( "DVELOP_CONFIRMPANEL_DELETEALLINFO_Result");
            Tabs_Activepagecontrolname = cgiGet( "TABS_Activepagecontrolname");
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
         E141K2 ();
         if (returnInSub) return;
      }

      protected void E141K2( )
      {
         /* Start Routine */
         new GeneXus.Programs.wwpbaseobjects.loadwwpcontext(context ).execute( out  AV6WWPContext) ;
         AV22GXLvl9 = 0;
         /* Using cursor H001K2 */
         pr_default.execute(0, new Object[] {AV10BR_Information_ID});
         while ( (pr_default.getStatus(0) != 101) )
         {
            A85BR_Information_ID = H001K2_A85BR_Information_ID[0];
            AV22GXLvl9 = 1;
            Form.Caption = "Data Mgmt Portal - RAAP";
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, "FORM", "Caption", Form.Caption, true);
            AV9Exists = true;
            /* Exiting from a For First loop. */
            if (true) break;
         }
         pr_default.close(0);
         if ( AV22GXLvl9 == 0 )
         {
            Form.Caption = "记录未找到";
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, "FORM", "Caption", Form.Caption, true);
            AV9Exists = false;
         }
         if ( AV9Exists )
         {
            AV12SelectedTabCode = AV8TabCode;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12SelectedTabCode", AV12SelectedTabCode);
            Tabs_Activepagecontrolname = AV12SelectedTabCode;
            ucTabs.SendProperty(context, "", false, Tabs_Internalname, "ActivePageControlName", Tabs_Activepagecontrolname);
            /* Execute user subroutine: 'LOADTABS' */
            S112 ();
            if (returnInSub) return;
         }
      }

      protected void E151K2( )
      {
         /* Refresh Routine */
         GXt_boolean1 = AV15TempBoolean;
         new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "Role_Manager", out  GXt_boolean1) ;
         AV15TempBoolean = GXt_boolean1;
         if ( ! ( AV15TempBoolean ) )
         {
            bttBtndeleteallinfo_Visible = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtndeleteallinfo_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtndeleteallinfo_Visible), 5, 0)), true);
         }
         /*  Sending Event outputs  */
      }

      protected void nextLoad( )
      {
      }

      protected void E161K2( )
      {
         /* Load Routine */
      }

      protected void E131K2( )
      {
         /* Dvelop_confirmpanel_deleteallinfo_Close Routine */
         if ( StringUtil.StrCmp(Dvelop_confirmpanel_deleteallinfo_Result, "Yes") == 0 )
         {
            /* Execute user subroutine: 'DO ACTION DELETEALLINFO' */
            S122 ();
            if (returnInSub) return;
         }
      }

      protected void E171K2( )
      {
         /* 'Doreturn' Routine */
         AV17tReturnPage = AV19Websession.Get("BR_InformationView_Return");
         if ( StringUtil.StrCmp(AV17tReturnPage, "BR_EncounterWW") == 0 )
         {
            CallWebObject(formatLink("br_encounterlist.aspx") );
            context.wjLocDisableFrm = 1;
         }
         else
         {
            CallWebObject(formatLink("br_informationlist.aspx") );
            context.wjLocDisableFrm = 1;
         }
      }

      protected void E121K2( )
      {
         /* Tabs_Tabchanged Routine */
         AV12SelectedTabCode = Tabs_Activepagecontrolname;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12SelectedTabCode", AV12SelectedTabCode);
         AV11LoadAllTabs = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11LoadAllTabs", AV11LoadAllTabs);
         /* Execute user subroutine: 'LOADTABS' */
         S112 ();
         if (returnInSub) return;
         /*  Sending Event outputs  */
      }

      protected void E181K2( )
      {
         /* 'General' Routine */
         this.executeUsercontrolMethod("", false, "TABSContainer", "SelectTab", "", new Object[] {(short)1});
         AV12SelectedTabCode = "General";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12SelectedTabCode", AV12SelectedTabCode);
         AV11LoadAllTabs = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11LoadAllTabs", AV11LoadAllTabs);
         /* Execute user subroutine: 'LOADTABS' */
         S112 ();
         if (returnInSub) return;
         /*  Sending Event outputs  */
      }

      protected void E191K2( )
      {
         /* 'br_encounter' Routine */
         this.executeUsercontrolMethod("", false, "TABSContainer", "SelectTab", "", new Object[] {(short)2});
         AV12SelectedTabCode = "br_encounter";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12SelectedTabCode", AV12SelectedTabCode);
         AV11LoadAllTabs = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11LoadAllTabs", AV11LoadAllTabs);
         /* Execute user subroutine: 'LOADTABS' */
         S112 ();
         if (returnInSub) return;
         /*  Sending Event outputs  */
      }

      protected void S122( )
      {
         /* 'DO ACTION DELETEALLINFO' Routine */
         new zbr_deleteallinfo(context ).execute(  AV10BR_Information_ID) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10BR_Information_ID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10BR_Information_ID), 18, 0)));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vBR_INFORMATION_ID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV10BR_Information_ID), "ZZZZZZZZZZZZZZZZZZ"), context));
         CallWebObject(formatLink("br_informationww.aspx") );
         context.wjLocDisableFrm = 1;
      }

      protected void S112( )
      {
         /* 'LOADTABS' Routine */
         new zutil_checksession(context ).execute( out  AV16tCheckFlag) ;
         if ( ! AV16tCheckFlag )
         {
            /* Using cursor H001K3 */
            pr_default.execute(1, new Object[] {AV10BR_Information_ID});
            while ( (pr_default.getStatus(1) != 101) )
            {
               A85BR_Information_ID = H001K3_A85BR_Information_ID[0];
               divCell_general_Visible = 1;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, divCell_general_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(divCell_general_Visible), 5, 0)), true);
               if ( AV11LoadAllTabs || ( StringUtil.StrCmp(AV12SelectedTabCode, "") == 0 ) || ( StringUtil.StrCmp(AV12SelectedTabCode, "General") == 0 ) )
               {
                  /* Object Property */
                  if ( StringUtil.StrCmp(StringUtil.Lower( WebComp_Generalwc_Component), StringUtil.Lower( "BR_InformationGeneral")) != 0 )
                  {
                     WebComp_Generalwc = getWebComponent(GetType(), "GeneXus.Programs", "br_informationgeneral", new Object[] {context} );
                     WebComp_Generalwc.ComponentInit();
                     WebComp_Generalwc.Name = "BR_InformationGeneral";
                     WebComp_Generalwc_Component = "BR_InformationGeneral";
                  }
                  if ( StringUtil.Len( WebComp_Generalwc_Component) != 0 )
                  {
                     WebComp_Generalwc.setjustcreated();
                     WebComp_Generalwc.componentprepare(new Object[] {(String)"W0030",(String)"",(long)AV10BR_Information_ID});
                     WebComp_Generalwc.componentbind(new Object[] {(String)""});
                  }
                  if ( isFullAjaxMode( ) )
                  {
                     context.httpAjaxContext.ajax_rspStartCmp("gxHTMLWrpW0030"+"");
                     WebComp_Generalwc.componentdraw();
                     context.httpAjaxContext.ajax_rspEndCmp();
                  }
                  lblTxttabtitle_Caption = "患者信息";
                  context.httpAjaxContext.ajax_rsp_assign_prop("", false, lblTxttabtitle_Internalname, "Caption", lblTxttabtitle_Caption, true);
                  if ( ( StringUtil.StrCmp(AV12SelectedTabCode, "") == 0 ) || ( StringUtil.StrCmp(AV12SelectedTabCode, "General") == 0 ) )
                  {
                     divCell_general_Visible = 0;
                     context.httpAjaxContext.ajax_rsp_assign_prop("", false, divCell_general_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(divCell_general_Visible), 5, 0)), true);
                  }
               }
               divCell_br_encounter_Visible = 1;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, divCell_br_encounter_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(divCell_br_encounter_Visible), 5, 0)), true);
               GXt_boolean1 = AV15TempBoolean;
               new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "Check_Encounter", out  GXt_boolean1) ;
               AV15TempBoolean = GXt_boolean1;
               if ( AV15TempBoolean )
               {
                  if ( AV11LoadAllTabs || ( StringUtil.StrCmp(AV12SelectedTabCode, "br_encounter") == 0 ) )
                  {
                     /* Object Property */
                     if ( StringUtil.StrCmp(StringUtil.Lower( WebComp_Br_encounterwc_Component), StringUtil.Lower( "BR_EncounterTab")) != 0 )
                     {
                        WebComp_Br_encounterwc = getWebComponent(GetType(), "GeneXus.Programs", "br_encountertab", new Object[] {context} );
                        WebComp_Br_encounterwc.ComponentInit();
                        WebComp_Br_encounterwc.Name = "BR_EncounterTab";
                        WebComp_Br_encounterwc_Component = "BR_EncounterTab";
                     }
                     if ( StringUtil.Len( WebComp_Br_encounterwc_Component) != 0 )
                     {
                        WebComp_Br_encounterwc.setjustcreated();
                        WebComp_Br_encounterwc.componentprepare(new Object[] {(String)"W0038",(String)"",(long)AV10BR_Information_ID});
                        WebComp_Br_encounterwc.componentbind(new Object[] {(String)""});
                     }
                     if ( isFullAjaxMode( ) )
                     {
                        context.httpAjaxContext.ajax_rspStartCmp("gxHTMLWrpW0038"+"");
                        WebComp_Br_encounterwc.componentdraw();
                        context.httpAjaxContext.ajax_rspEndCmp();
                     }
                     lblTxttabtitle_Caption = "就诊信息";
                     context.httpAjaxContext.ajax_rsp_assign_prop("", false, lblTxttabtitle_Internalname, "Caption", lblTxttabtitle_Caption, true);
                     if ( StringUtil.StrCmp(AV12SelectedTabCode, "br_encounter") == 0 )
                     {
                        divCell_br_encounter_Visible = 0;
                        context.httpAjaxContext.ajax_rsp_assign_prop("", false, divCell_br_encounter_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(divCell_br_encounter_Visible), 5, 0)), true);
                     }
                  }
               }
               else
               {
                  divCell_br_encounter_Visible = 0;
                  context.httpAjaxContext.ajax_rsp_assign_prop("", false, divCell_br_encounter_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(divCell_br_encounter_Visible), 5, 0)), true);
                  this.executeUsercontrolMethod("", false, "TABSContainer", "HideTab", "", new Object[] {(short)2});
               }
               /* Exiting from a For First loop. */
               if (true) break;
            }
            pr_default.close(1);
         }
      }

      protected void wb_table1_51_1K2( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "";
            GxWebStd.gx_table_start( context, tblTabledvelop_confirmpanel_deleteallinfo_Internalname, tblTabledvelop_confirmpanel_deleteallinfo_Internalname, "", "Table", 0, "", "", 1, 2, sStyleString, "", "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td data-align=\"center\"  style=\""+CSSHelper.Prettify( "text-align:-khtml-center;text-align:-moz-center;text-align:-webkit-center")+"\">") ;
            /* User Defined Control */
            ucDvelop_confirmpanel_deleteallinfo.SetProperty("Title", Dvelop_confirmpanel_deleteallinfo_Title);
            ucDvelop_confirmpanel_deleteallinfo.SetProperty("ConfirmationText", Dvelop_confirmpanel_deleteallinfo_Confirmationtext);
            ucDvelop_confirmpanel_deleteallinfo.SetProperty("YesButtonCaption", Dvelop_confirmpanel_deleteallinfo_Yesbuttoncaption);
            ucDvelop_confirmpanel_deleteallinfo.SetProperty("NoButtonCaption", Dvelop_confirmpanel_deleteallinfo_Nobuttoncaption);
            ucDvelop_confirmpanel_deleteallinfo.SetProperty("CancelButtonCaption", Dvelop_confirmpanel_deleteallinfo_Cancelbuttoncaption);
            ucDvelop_confirmpanel_deleteallinfo.SetProperty("YesButtonPosition", Dvelop_confirmpanel_deleteallinfo_Yesbuttonposition);
            ucDvelop_confirmpanel_deleteallinfo.SetProperty("ConfirmType", Dvelop_confirmpanel_deleteallinfo_Confirmtype);
            ucDvelop_confirmpanel_deleteallinfo.Render(context, "dvelop.gxbootstrap.confirmpanel", Dvelop_confirmpanel_deleteallinfo_Internalname, "DVELOP_CONFIRMPANEL_DELETEALLINFOContainer");
            context.WriteHtmlText( "<div class=\"gx_usercontrol_child\" id=\""+"DVELOP_CONFIRMPANEL_DELETEALLINFOContainer"+"Body"+"\" style=\"display:none;\">") ;
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table1_51_1K2e( true) ;
         }
         else
         {
            wb_table1_51_1K2e( false) ;
         }
      }

      public override void setparameters( Object[] obj )
      {
         createObjects();
         initialize();
         AV10BR_Information_ID = Convert.ToInt64(getParm(obj,0));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10BR_Information_ID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10BR_Information_ID), 18, 0)));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vBR_INFORMATION_ID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV10BR_Information_ID), "ZZZZZZZZZZZZZZZZZZ"), context));
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
         PA1K2( ) ;
         WS1K2( ) ;
         WE1K2( ) ;
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
         if ( ! ( WebComp_Br_encounterwc == null ) )
         {
            if ( StringUtil.Len( WebComp_Br_encounterwc_Component) != 0 )
            {
               WebComp_Br_encounterwc.componentthemes();
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
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?20202279393360", true);
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
         context.AddJavascriptSource("br_informationview.js", "?20202279393360", false);
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
         bttBtndeleteallinfo_Internalname = "BTNDELETEALLINFO";
         bttBtnreturn_Internalname = "BTNRETURN";
         lblTxttabtitle_Internalname = "TXTTABTITLE";
         lblGeneral_title_Internalname = "GENERAL_TITLE";
         divUnnamedtablegeneral_Internalname = "UNNAMEDTABLEGENERAL";
         lblBr_encounter_title_Internalname = "BR_ENCOUNTER_TITLE";
         divUnnamedtablebr_encounter_Internalname = "UNNAMEDTABLEBR_ENCOUNTER";
         Tabs_Internalname = "TABS";
         bttBtngeneral_Internalname = "BTNGENERAL";
         divCell_general_Internalname = "CELL_GENERAL";
         bttBtnbr_encounter_Internalname = "BTNBR_ENCOUNTER";
         divCell_br_encounter_Internalname = "CELL_BR_ENCOUNTER";
         divUnnamedtabletabscontainer_Internalname = "UNNAMEDTABLETABSCONTAINER";
         divUnnamedtableviewcontainer_Internalname = "UNNAMEDTABLEVIEWCONTAINER";
         divTablemain_Internalname = "TABLEMAIN";
         Dvelop_confirmpanel_deleteallinfo_Internalname = "DVELOP_CONFIRMPANEL_DELETEALLINFO";
         tblTabledvelop_confirmpanel_deleteallinfo_Internalname = "TABLEDVELOP_CONFIRMPANEL_DELETEALLINFO";
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
         divCell_br_encounter_Visible = 1;
         divCell_general_Visible = 1;
         lblTxttabtitle_Caption = "Title";
         bttBtndeleteallinfo_Visible = 1;
         Dvelop_confirmpanel_deleteallinfo_Confirmtype = "1";
         Dvelop_confirmpanel_deleteallinfo_Yesbuttonposition = "left";
         Dvelop_confirmpanel_deleteallinfo_Cancelbuttoncaption = "WWP_ConfirmTextCancel";
         Dvelop_confirmpanel_deleteallinfo_Nobuttoncaption = "WWP_ConfirmTextNo";
         Dvelop_confirmpanel_deleteallinfo_Yesbuttoncaption = "WWP_ConfirmTextYes";
         Dvelop_confirmpanel_deleteallinfo_Confirmationtext = "确认删除？(一旦删除，该患者以及其所有的就诊的信息均被删除)";
         Dvelop_confirmpanel_deleteallinfo_Title = "";
         Tabs_Historymanagement = Convert.ToBoolean( -1);
         Tabs_Pagecount = 2;
         Tabs_Class = "ViewTab Tab";
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
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[{av:'AV10BR_Information_ID',fld:'vBR_INFORMATION_ID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true},{av:'AV8TabCode',fld:'vTABCODE',pic:'',hsh:true}]");
         setEventMetadata("REFRESH",",oparms:[{ctrl:'BTNDELETEALLINFO',prop:'Visible'}]}");
         setEventMetadata("'DODELETEALLINFO'","{handler:'E111K1',iparms:[]");
         setEventMetadata("'DODELETEALLINFO'",",oparms:[]}");
         setEventMetadata("DVELOP_CONFIRMPANEL_DELETEALLINFO.CLOSE","{handler:'E131K2',iparms:[{av:'Dvelop_confirmpanel_deleteallinfo_Result',ctrl:'DVELOP_CONFIRMPANEL_DELETEALLINFO',prop:'Result'},{av:'AV10BR_Information_ID',fld:'vBR_INFORMATION_ID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true}]");
         setEventMetadata("DVELOP_CONFIRMPANEL_DELETEALLINFO.CLOSE",",oparms:[]}");
         setEventMetadata("'DORETURN'","{handler:'E171K2',iparms:[]");
         setEventMetadata("'DORETURN'",",oparms:[]}");
         setEventMetadata("TABS.TABCHANGED","{handler:'E121K2',iparms:[{av:'Tabs_Activepagecontrolname',ctrl:'TABS',prop:'ActivePageControlName'},{av:'A85BR_Information_ID',fld:'BR_INFORMATION_ID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV10BR_Information_ID',fld:'vBR_INFORMATION_ID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true},{av:'AV11LoadAllTabs',fld:'vLOADALLTABS',pic:''},{av:'AV12SelectedTabCode',fld:'vSELECTEDTABCODE',pic:''}]");
         setEventMetadata("TABS.TABCHANGED",",oparms:[{av:'AV12SelectedTabCode',fld:'vSELECTEDTABCODE',pic:''},{av:'AV11LoadAllTabs',fld:'vLOADALLTABS',pic:''},{av:'divCell_general_Visible',ctrl:'CELL_GENERAL',prop:'Visible'},{ctrl:'GENERALWC'},{av:'lblTxttabtitle_Caption',ctrl:'TXTTABTITLE',prop:'Caption'},{av:'divCell_br_encounter_Visible',ctrl:'CELL_BR_ENCOUNTER',prop:'Visible'},{ctrl:'BR_ENCOUNTERWC'}]}");
         setEventMetadata("'GENERAL'","{handler:'E181K2',iparms:[{av:'A85BR_Information_ID',fld:'BR_INFORMATION_ID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV10BR_Information_ID',fld:'vBR_INFORMATION_ID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true},{av:'AV11LoadAllTabs',fld:'vLOADALLTABS',pic:''},{av:'AV12SelectedTabCode',fld:'vSELECTEDTABCODE',pic:''}]");
         setEventMetadata("'GENERAL'",",oparms:[{av:'AV12SelectedTabCode',fld:'vSELECTEDTABCODE',pic:''},{av:'AV11LoadAllTabs',fld:'vLOADALLTABS',pic:''},{av:'divCell_general_Visible',ctrl:'CELL_GENERAL',prop:'Visible'},{ctrl:'GENERALWC'},{av:'lblTxttabtitle_Caption',ctrl:'TXTTABTITLE',prop:'Caption'},{av:'divCell_br_encounter_Visible',ctrl:'CELL_BR_ENCOUNTER',prop:'Visible'},{ctrl:'BR_ENCOUNTERWC'}]}");
         setEventMetadata("'BR_ENCOUNTER'","{handler:'E191K2',iparms:[{av:'A85BR_Information_ID',fld:'BR_INFORMATION_ID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV10BR_Information_ID',fld:'vBR_INFORMATION_ID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true},{av:'AV11LoadAllTabs',fld:'vLOADALLTABS',pic:''},{av:'AV12SelectedTabCode',fld:'vSELECTEDTABCODE',pic:''}]");
         setEventMetadata("'BR_ENCOUNTER'",",oparms:[{av:'AV12SelectedTabCode',fld:'vSELECTEDTABCODE',pic:''},{av:'AV11LoadAllTabs',fld:'vLOADALLTABS',pic:''},{av:'divCell_general_Visible',ctrl:'CELL_GENERAL',prop:'Visible'},{ctrl:'GENERALWC'},{av:'lblTxttabtitle_Caption',ctrl:'TXTTABTITLE',prop:'Caption'},{av:'divCell_br_encounter_Visible',ctrl:'CELL_BR_ENCOUNTER',prop:'Visible'},{ctrl:'BR_ENCOUNTERWC'}]}");
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
         Dvelop_confirmpanel_deleteallinfo_Result = "";
         Tabs_Activepagecontrolname = "";
         gxfirstwebparm = "";
         gxfirstwebparm_bkp = "";
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         GXKey = "";
         AV12SelectedTabCode = "";
         GX_FocusControl = "";
         Form = new GXWebForm();
         sPrefix = "";
         TempTags = "";
         ClassString = "";
         StyleString = "";
         bttBtndeleteallinfo_Jsonclick = "";
         bttBtnreturn_Jsonclick = "";
         lblTxttabtitle_Jsonclick = "";
         ucTabs = new GXUserControl();
         lblGeneral_title_Jsonclick = "";
         WebComp_Generalwc_Component = "";
         OldGeneralwc = "";
         lblBr_encounter_title_Jsonclick = "";
         WebComp_Br_encounterwc_Component = "";
         OldBr_encounterwc = "";
         bttBtngeneral_Jsonclick = "";
         bttBtnbr_encounter_Jsonclick = "";
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         AV6WWPContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPContext(context);
         scmdbuf = "";
         H001K2_A85BR_Information_ID = new long[1] ;
         AV17tReturnPage = "";
         AV19Websession = context.GetSession();
         H001K3_A85BR_Information_ID = new long[1] ;
         sStyleString = "";
         ucDvelop_confirmpanel_deleteallinfo = new GXUserControl();
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.br_informationview__default(),
            new Object[][] {
                new Object[] {
               H001K2_A85BR_Information_ID
               }
               , new Object[] {
               H001K3_A85BR_Information_ID
               }
            }
         );
         WebComp_Generalwc = new GeneXus.Http.GXNullWebComponent();
         WebComp_Br_encounterwc = new GeneXus.Http.GXNullWebComponent();
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private short nGotPars ;
      private short GxWebError ;
      private short initialized ;
      private short gxajaxcallmode ;
      private short wbEnd ;
      private short wbStart ;
      private short nCmpId ;
      private short nDonePA ;
      private short gxcookieaux ;
      private short AV22GXLvl9 ;
      private short nGXWrapped ;
      private int Tabs_Pagecount ;
      private int bttBtndeleteallinfo_Visible ;
      private int divCell_general_Visible ;
      private int divCell_br_encounter_Visible ;
      private int idxLst ;
      private long AV10BR_Information_ID ;
      private long wcpOAV10BR_Information_ID ;
      private long A85BR_Information_ID ;
      private String AV8TabCode ;
      private String wcpOAV8TabCode ;
      private String Dvelop_confirmpanel_deleteallinfo_Result ;
      private String Tabs_Activepagecontrolname ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String sDynURL ;
      private String FormProcess ;
      private String bodyStyle ;
      private String GXKey ;
      private String AV12SelectedTabCode ;
      private String Tabs_Class ;
      private String Dvelop_confirmpanel_deleteallinfo_Title ;
      private String Dvelop_confirmpanel_deleteallinfo_Confirmationtext ;
      private String Dvelop_confirmpanel_deleteallinfo_Yesbuttoncaption ;
      private String Dvelop_confirmpanel_deleteallinfo_Nobuttoncaption ;
      private String Dvelop_confirmpanel_deleteallinfo_Cancelbuttoncaption ;
      private String Dvelop_confirmpanel_deleteallinfo_Yesbuttonposition ;
      private String Dvelop_confirmpanel_deleteallinfo_Confirmtype ;
      private String GX_FocusControl ;
      private String sPrefix ;
      private String divLayoutmaintable_Internalname ;
      private String divTablemain_Internalname ;
      private String TempTags ;
      private String ClassString ;
      private String StyleString ;
      private String bttBtndeleteallinfo_Internalname ;
      private String bttBtndeleteallinfo_Jsonclick ;
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
      private String lblBr_encounter_title_Internalname ;
      private String lblBr_encounter_title_Jsonclick ;
      private String divUnnamedtablebr_encounter_Internalname ;
      private String WebComp_Br_encounterwc_Component ;
      private String OldBr_encounterwc ;
      private String divUnnamedtabletabscontainer_Internalname ;
      private String divCell_general_Internalname ;
      private String bttBtngeneral_Internalname ;
      private String bttBtngeneral_Jsonclick ;
      private String divCell_br_encounter_Internalname ;
      private String bttBtnbr_encounter_Internalname ;
      private String bttBtnbr_encounter_Jsonclick ;
      private String divHtml_bottomauxiliarcontrols_Internalname ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String scmdbuf ;
      private String sStyleString ;
      private String tblTabledvelop_confirmpanel_deleteallinfo_Internalname ;
      private String Dvelop_confirmpanel_deleteallinfo_Internalname ;
      private bool entryPointCalled ;
      private bool toggleJsOutput ;
      private bool AV11LoadAllTabs ;
      private bool Tabs_Historymanagement ;
      private bool wbLoad ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool gxdyncontrolsrefreshing ;
      private bool returnInSub ;
      private bool AV9Exists ;
      private bool AV15TempBoolean ;
      private bool AV16tCheckFlag ;
      private bool GXt_boolean1 ;
      private String AV17tReturnPage ;
      private IGxSession AV19Websession ;
      private GXWebComponent WebComp_Generalwc ;
      private GXWebComponent WebComp_Br_encounterwc ;
      private GXUserControl ucTabs ;
      private GXUserControl ucDvelop_confirmpanel_deleteallinfo ;
      private IGxDataStore dsDataStore1 ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private long[] H001K2_A85BR_Information_ID ;
      private long[] H001K3_A85BR_Information_ID ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private GXWebForm Form ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPContext AV6WWPContext ;
   }

   public class br_informationview__default : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmH001K2 ;
          prmH001K2 = new Object[] {
          new Object[] {"@AV10BR_Information_ID",SqlDbType.Decimal,18,0}
          } ;
          Object[] prmH001K3 ;
          prmH001K3 = new Object[] {
          new Object[] {"@AV10BR_Information_ID",SqlDbType.Decimal,18,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("H001K2", "SELECT [BR_Information_ID] FROM [BR_Information] WITH (NOLOCK) WHERE [BR_Information_ID] = @AV10BR_Information_ID ORDER BY [BR_Information_ID] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH001K2,1,0,false,true )
             ,new CursorDef("H001K3", "SELECT [BR_Information_ID] FROM [BR_Information] WITH (NOLOCK) WHERE [BR_Information_ID] = @AV10BR_Information_ID ORDER BY [BR_Information_ID] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH001K3,1,0,true,true )
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
                return;
             case 1 :
                ((long[]) buf[0])[0] = rslt.getLong(1) ;
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
             case 1 :
                stmt.SetParameter(1, (long)parms[0]);
                return;
       }
    }

 }

}
