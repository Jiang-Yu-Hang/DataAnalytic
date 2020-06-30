/*
               File: BR_PathologyView
        Description: BR_Pathology View
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/27/2020 9:42:54.7
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
   public class br_pathologyview : GXDataArea, System.Web.SessionState.IRequiresSessionState
   {
      public br_pathologyview( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public br_pathologyview( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( long aP0_BR_PathologyID ,
                           String aP1_TabCode )
      {
         this.AV10BR_PathologyID = aP0_BR_PathologyID;
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
               AV10BR_PathologyID = (long)(NumberUtil.Val( gxfirstwebparm, "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10BR_PathologyID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10BR_PathologyID), 18, 0)));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vBR_PATHOLOGYID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV10BR_PathologyID), "ZZZZZZZZZZZZZZZZZZ"), context));
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
         PA5B2( ) ;
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0));
         if ( ( gxajaxcallmode == 0 ) && ( GxWebError == 0 ) )
         {
            START5B2( ) ;
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
         context.AddJavascriptSource("gxcfg.js", "?20202279425415", false);
         if ( context.isSpaRequest( ) )
         {
            enableOutput();
         }
         context.AddJavascriptSource("Shared/HistoryManager/HistoryManager.js", "", false);
         context.AddJavascriptSource("Shared/HistoryManager/rsh/json2005.js", "", false);
         context.AddJavascriptSource("Shared/HistoryManager/rsh/rsh.js", "", false);
         context.AddJavascriptSource("Shared/HistoryManager/HistoryManagerCreate.js", "", false);
         context.AddJavascriptSource("Tab/TabRender.js", "", false);
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" autocomplete=\"off\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("br_pathologyview.aspx") + "?" + UrlEncode("" +AV10BR_PathologyID) + "," + UrlEncode(StringUtil.RTrim(AV8TabCode))+"\">") ;
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
         GxWebStd.gx_hidden_field( context, "vBR_PATHOLOGYID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV10BR_PathologyID), 18, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "gxhash_vBR_PATHOLOGYID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV10BR_PathologyID), "ZZZZZZZZZZZZZZZZZZ"), context));
         GxWebStd.gx_hidden_field( context, "BR_PATHOLOGYID", StringUtil.LTrim( StringUtil.NToC( (decimal)(A226BR_PathologyID), 18, 0, ".", "")));
         GxWebStd.gx_boolean_hidden_field( context, "vLOADALLTABS", AV11LoadAllTabs);
         GxWebStd.gx_hidden_field( context, "vSELECTEDTABCODE", StringUtil.RTrim( AV12SelectedTabCode));
         GxWebStd.gx_hidden_field( context, "vTABCODE", StringUtil.RTrim( AV8TabCode));
         GxWebStd.gx_hidden_field( context, "gxhash_vTABCODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( AV8TabCode, "")), context));
         GxWebStd.gx_hidden_field( context, "TABS_Class", StringUtil.RTrim( Tabs_Class));
         GxWebStd.gx_hidden_field( context, "TABS_Activepagecontrolname", StringUtil.RTrim( Tabs_Activepagecontrolname));
         GxWebStd.gx_hidden_field( context, "TABS_Pagecount", StringUtil.LTrim( StringUtil.NToC( (decimal)(Tabs_Pagecount), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "TABS_Historymanagement", StringUtil.BoolToStr( Tabs_Historymanagement));
         GxWebStd.gx_hidden_field( context, "TABS_Activepagecontrolname", StringUtil.RTrim( Tabs_Activepagecontrolname));
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
         if ( ! ( WebComp_Br_pathology_specimenwc == null ) )
         {
            WebComp_Br_pathology_specimenwc.componentjscripts();
         }
         if ( ! ( WebComp_Br_pathology_diagwc == null ) )
         {
            WebComp_Br_pathology_diagwc.componentjscripts();
         }
         if ( ! ( WebComp_Br_pathology_otherwc == null ) )
         {
            WebComp_Br_pathology_otherwc.componentjscripts();
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
            WE5B2( ) ;
            context.WriteHtmlText( "</div>") ;
         }
      }

      public override void DispatchEvents( )
      {
         EVT5B2( ) ;
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
         return formatLink("br_pathologyview.aspx") + "?" + UrlEncode("" +AV10BR_PathologyID) + "," + UrlEncode(StringUtil.RTrim(AV8TabCode)) ;
      }

      public override String GetPgmname( )
      {
         return "BR_PathologyView" ;
      }

      public override String GetPgmdesc( )
      {
         return "BR_Pathology View" ;
      }

      protected void WB5B0( )
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
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 9,'',false,'',0)\"";
            ClassString = "ButtonMaterial";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtnback_Internalname, "", "返回", bttBtnback_Jsonclick, 5, "返回", "", StyleString, ClassString, 1, 1, "standard", "'"+""+"'"+",false,"+"'"+"E\\'DOBACK\\'."+"'", TempTags, "", context.GetButtonType( ), "HLP_BR_PathologyView.htm");
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
            GxWebStd.gx_label_ctrl( context, lblTxttabtitle_Internalname, lblTxttabtitle_Caption, "", "", lblTxttabtitle_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "TextBlockTitleWWPTab", 0, "", 1, 1, 0, "HLP_BR_PathologyView.htm");
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
            GxWebStd.gx_label_ctrl( context, lblGeneral_title_Internalname, "病理学信息", "", "", lblGeneral_title_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "TextBlock", 0, "", 1, 1, 0, "HLP_BR_PathologyView.htm");
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
               GxWebStd.gx_hidden_field( context, "W0026"+"", StringUtil.RTrim( WebComp_Generalwc_Component));
               context.WriteHtmlText( "<div") ;
               GxWebStd.ClassAttribute( context, "gxwebcomponent");
               context.WriteHtmlText( " id=\""+"gxHTMLWrpW0026"+""+"\""+"") ;
               context.WriteHtmlText( ">") ;
               if ( StringUtil.Len( WebComp_Generalwc_Component) != 0 )
               {
                  if ( StringUtil.StrCmp(StringUtil.Lower( OldGeneralwc), StringUtil.Lower( WebComp_Generalwc_Component)) != 0 )
                  {
                     context.httpAjaxContext.ajax_rspStartCmp("gxHTMLWrpW0026"+"");
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
            GxWebStd.gx_label_ctrl( context, lblBr_pathology_specimen_title_Internalname, "病理学送检组织", "", "", lblBr_pathology_specimen_title_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "TextBlock", 0, "", 1, 1, 0, "HLP_BR_PathologyView.htm");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "Section", "left", "top", "", "display:none;", "div");
            context.WriteHtmlText( "BR_Pathology_Specimen") ;
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "<div class=\"gx_usercontrol_child\" id=\""+"TABSContainer"+"panel2"+"\" style=\"display:none;\">") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, divUnnamedtablebr_pathology_specimen_Internalname, 1, 0, "px", 0, "px", "TableViewTab", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            if ( ! isFullAjaxMode( ) )
            {
               /* WebComponent */
               GxWebStd.gx_hidden_field( context, "W0034"+"", StringUtil.RTrim( WebComp_Br_pathology_specimenwc_Component));
               context.WriteHtmlText( "<div") ;
               GxWebStd.ClassAttribute( context, "gxwebcomponent");
               context.WriteHtmlText( " id=\""+"gxHTMLWrpW0034"+""+"\""+"") ;
               context.WriteHtmlText( ">") ;
               if ( StringUtil.Len( WebComp_Br_pathology_specimenwc_Component) != 0 )
               {
                  if ( StringUtil.StrCmp(StringUtil.Lower( OldBr_pathology_specimenwc), StringUtil.Lower( WebComp_Br_pathology_specimenwc_Component)) != 0 )
                  {
                     context.httpAjaxContext.ajax_rspStartCmp("gxHTMLWrpW0034"+"");
                  }
                  WebComp_Br_pathology_specimenwc.componentdraw();
                  if ( StringUtil.StrCmp(StringUtil.Lower( OldBr_pathology_specimenwc), StringUtil.Lower( WebComp_Br_pathology_specimenwc_Component)) != 0 )
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
            GxWebStd.gx_label_ctrl( context, lblBr_pathology_diag_title_Internalname, "病理学诊断", "", "", lblBr_pathology_diag_title_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "TextBlock", 0, "", 1, 1, 0, "HLP_BR_PathologyView.htm");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "Section", "left", "top", "", "display:none;", "div");
            context.WriteHtmlText( "BR_Pathology_Diag") ;
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "<div class=\"gx_usercontrol_child\" id=\""+"TABSContainer"+"panel3"+"\" style=\"display:none;\">") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, divUnnamedtablebr_pathology_diag_Internalname, 1, 0, "px", 0, "px", "TableViewTab", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            if ( ! isFullAjaxMode( ) )
            {
               /* WebComponent */
               GxWebStd.gx_hidden_field( context, "W0042"+"", StringUtil.RTrim( WebComp_Br_pathology_diagwc_Component));
               context.WriteHtmlText( "<div") ;
               GxWebStd.ClassAttribute( context, "gxwebcomponent");
               context.WriteHtmlText( " id=\""+"gxHTMLWrpW0042"+""+"\""+"") ;
               context.WriteHtmlText( ">") ;
               if ( StringUtil.Len( WebComp_Br_pathology_diagwc_Component) != 0 )
               {
                  if ( StringUtil.StrCmp(StringUtil.Lower( OldBr_pathology_diagwc), StringUtil.Lower( WebComp_Br_pathology_diagwc_Component)) != 0 )
                  {
                     context.httpAjaxContext.ajax_rspStartCmp("gxHTMLWrpW0042"+"");
                  }
                  WebComp_Br_pathology_diagwc.componentdraw();
                  if ( StringUtil.StrCmp(StringUtil.Lower( OldBr_pathology_diagwc), StringUtil.Lower( WebComp_Br_pathology_diagwc_Component)) != 0 )
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
            context.WriteHtmlText( "<div class=\"gx_usercontrol_child\" id=\""+"TABSContainer"+"title4"+"\" style=\"display:none;\">") ;
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblBr_pathology_other_title_Internalname, "病理学其它信息", "", "", lblBr_pathology_other_title_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "TextBlock", 0, "", 1, 1, 0, "HLP_BR_PathologyView.htm");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "Section", "left", "top", "", "display:none;", "div");
            context.WriteHtmlText( "BR_Pathology_Other") ;
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "<div class=\"gx_usercontrol_child\" id=\""+"TABSContainer"+"panel4"+"\" style=\"display:none;\">") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, divUnnamedtablebr_pathology_other_Internalname, 1, 0, "px", 0, "px", "TableViewTab", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            if ( ! isFullAjaxMode( ) )
            {
               /* WebComponent */
               GxWebStd.gx_hidden_field( context, "W0050"+"", StringUtil.RTrim( WebComp_Br_pathology_otherwc_Component));
               context.WriteHtmlText( "<div") ;
               GxWebStd.ClassAttribute( context, "gxwebcomponent");
               context.WriteHtmlText( " id=\""+"gxHTMLWrpW0050"+""+"\""+"") ;
               context.WriteHtmlText( ">") ;
               if ( StringUtil.Len( WebComp_Br_pathology_otherwc_Component) != 0 )
               {
                  if ( StringUtil.StrCmp(StringUtil.Lower( OldBr_pathology_otherwc), StringUtil.Lower( WebComp_Br_pathology_otherwc_Component)) != 0 )
                  {
                     context.httpAjaxContext.ajax_rspStartCmp("gxHTMLWrpW0050"+"");
                  }
                  WebComp_Br_pathology_otherwc.componentdraw();
                  if ( StringUtil.StrCmp(StringUtil.Lower( OldBr_pathology_otherwc), StringUtil.Lower( WebComp_Br_pathology_otherwc_Component)) != 0 )
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
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 56,'',false,'',0)\"";
            ClassString = "btn_Master btn-large btn-block Button";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtngeneral_Internalname, "", "病理学信息", bttBtngeneral_Jsonclick, 5, "病理学信息", "", StyleString, ClassString, 1, 1, "standard", "'"+""+"'"+",false,"+"'"+"E\\'GENERAL\\'."+"'", TempTags, "", context.GetButtonType( ), "HLP_BR_PathologyView.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divCell_br_pathology_specimen_Internalname, divCell_br_pathology_specimen_Visible, 0, "px", 0, "px", "col-xs-12 CellMarginTop", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 59,'',false,'',0)\"";
            ClassString = "btn_Master btn-large btn-block Button";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtnbr_pathology_specimen_Internalname, "", "病理学送检组织", bttBtnbr_pathology_specimen_Jsonclick, 5, "病理学送检组织", "", StyleString, ClassString, 1, 1, "standard", "'"+""+"'"+",false,"+"'"+"E\\'BR_PATHOLOGY_SPECIMEN\\'."+"'", TempTags, "", context.GetButtonType( ), "HLP_BR_PathologyView.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divCell_br_pathology_diag_Internalname, divCell_br_pathology_diag_Visible, 0, "px", 0, "px", "col-xs-12 CellMarginTop", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 62,'',false,'',0)\"";
            ClassString = "btn_Master btn-large btn-block Button";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtnbr_pathology_diag_Internalname, "", "病理学诊断", bttBtnbr_pathology_diag_Jsonclick, 5, "病理学诊断", "", StyleString, ClassString, 1, 1, "standard", "'"+""+"'"+",false,"+"'"+"E\\'BR_PATHOLOGY_DIAG\\'."+"'", TempTags, "", context.GetButtonType( ), "HLP_BR_PathologyView.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divCell_br_pathology_other_Internalname, divCell_br_pathology_other_Visible, 0, "px", 0, "px", "col-xs-12 CellMarginTop", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 65,'',false,'',0)\"";
            ClassString = "btn_Master btn-large btn-block Button";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtnbr_pathology_other_Internalname, "", "病理学其它信息", bttBtnbr_pathology_other_Jsonclick, 5, "病理学其它信息", "", StyleString, ClassString, 1, 1, "standard", "'"+""+"'"+",false,"+"'"+"E\\'BR_PATHOLOGY_OTHER\\'."+"'", TempTags, "", context.GetButtonType( ), "HLP_BR_PathologyView.htm");
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
         }
         wbLoad = true;
      }

      protected void START5B2( )
      {
         wbLoad = false;
         wbEnd = 0;
         wbStart = 0;
         if ( ! context.isSpaRequest( ) )
         {
            Form.Meta.addItem("generator", "GeneXus C# 16_0_0-127771", 0) ;
            Form.Meta.addItem("description", "BR_Pathology View", 0) ;
         }
         context.wjLoc = "";
         context.nUserReturn = 0;
         context.wbHandled = 0;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         wbErr = false;
         STRUP5B0( ) ;
      }

      protected void WS5B2( )
      {
         START5B2( ) ;
         EVT5B2( ) ;
      }

      protected void EVT5B2( )
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
                              E115B2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "START") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              /* Execute user event: Start */
                              E125B2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "LOAD") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              /* Execute user event: Load */
                              E135B2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "'DOBACK'") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              /* Execute user event: 'Doback' */
                              E145B2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "'GENERAL'") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              /* Execute user event: 'General' */
                              E155B2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "'BR_PATHOLOGY_SPECIMEN'") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              /* Execute user event: 'BR_Pathology_Specimen' */
                              E165B2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "'BR_PATHOLOGY_DIAG'") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              /* Execute user event: 'BR_Pathology_Diag' */
                              E175B2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "'BR_PATHOLOGY_OTHER'") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              /* Execute user event: 'BR_Pathology_Other' */
                              E185B2 ();
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
                        if ( nCmpId == 26 )
                        {
                           OldGeneralwc = cgiGet( "W0026");
                           if ( ( StringUtil.Len( OldGeneralwc) == 0 ) || ( StringUtil.StrCmp(OldGeneralwc, WebComp_Generalwc_Component) != 0 ) )
                           {
                              WebComp_Generalwc = getWebComponent(GetType(), "GeneXus.Programs", OldGeneralwc, new Object[] {context} );
                              WebComp_Generalwc.ComponentInit();
                              WebComp_Generalwc.Name = "OldGeneralwc";
                              WebComp_Generalwc_Component = OldGeneralwc;
                           }
                           if ( StringUtil.Len( WebComp_Generalwc_Component) != 0 )
                           {
                              WebComp_Generalwc.componentprocess("W0026", "", sEvt);
                           }
                           WebComp_Generalwc_Component = OldGeneralwc;
                        }
                        else if ( nCmpId == 34 )
                        {
                           OldBr_pathology_specimenwc = cgiGet( "W0034");
                           if ( ( StringUtil.Len( OldBr_pathology_specimenwc) == 0 ) || ( StringUtil.StrCmp(OldBr_pathology_specimenwc, WebComp_Br_pathology_specimenwc_Component) != 0 ) )
                           {
                              WebComp_Br_pathology_specimenwc = getWebComponent(GetType(), "GeneXus.Programs", OldBr_pathology_specimenwc, new Object[] {context} );
                              WebComp_Br_pathology_specimenwc.ComponentInit();
                              WebComp_Br_pathology_specimenwc.Name = "OldBr_pathology_specimenwc";
                              WebComp_Br_pathology_specimenwc_Component = OldBr_pathology_specimenwc;
                           }
                           if ( StringUtil.Len( WebComp_Br_pathology_specimenwc_Component) != 0 )
                           {
                              WebComp_Br_pathology_specimenwc.componentprocess("W0034", "", sEvt);
                           }
                           WebComp_Br_pathology_specimenwc_Component = OldBr_pathology_specimenwc;
                        }
                        else if ( nCmpId == 42 )
                        {
                           OldBr_pathology_diagwc = cgiGet( "W0042");
                           if ( ( StringUtil.Len( OldBr_pathology_diagwc) == 0 ) || ( StringUtil.StrCmp(OldBr_pathology_diagwc, WebComp_Br_pathology_diagwc_Component) != 0 ) )
                           {
                              WebComp_Br_pathology_diagwc = getWebComponent(GetType(), "GeneXus.Programs", OldBr_pathology_diagwc, new Object[] {context} );
                              WebComp_Br_pathology_diagwc.ComponentInit();
                              WebComp_Br_pathology_diagwc.Name = "OldBr_pathology_diagwc";
                              WebComp_Br_pathology_diagwc_Component = OldBr_pathology_diagwc;
                           }
                           if ( StringUtil.Len( WebComp_Br_pathology_diagwc_Component) != 0 )
                           {
                              WebComp_Br_pathology_diagwc.componentprocess("W0042", "", sEvt);
                           }
                           WebComp_Br_pathology_diagwc_Component = OldBr_pathology_diagwc;
                        }
                        else if ( nCmpId == 50 )
                        {
                           OldBr_pathology_otherwc = cgiGet( "W0050");
                           if ( ( StringUtil.Len( OldBr_pathology_otherwc) == 0 ) || ( StringUtil.StrCmp(OldBr_pathology_otherwc, WebComp_Br_pathology_otherwc_Component) != 0 ) )
                           {
                              WebComp_Br_pathology_otherwc = getWebComponent(GetType(), "GeneXus.Programs", OldBr_pathology_otherwc, new Object[] {context} );
                              WebComp_Br_pathology_otherwc.ComponentInit();
                              WebComp_Br_pathology_otherwc.Name = "OldBr_pathology_otherwc";
                              WebComp_Br_pathology_otherwc_Component = OldBr_pathology_otherwc;
                           }
                           if ( StringUtil.Len( WebComp_Br_pathology_otherwc_Component) != 0 )
                           {
                              WebComp_Br_pathology_otherwc.componentprocess("W0050", "", sEvt);
                           }
                           WebComp_Br_pathology_otherwc_Component = OldBr_pathology_otherwc;
                        }
                     }
                     context.wbHandled = 1;
                  }
               }
            }
         }
      }

      protected void WE5B2( )
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

      protected void PA5B2( )
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
         RF5B2( ) ;
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

      protected void RF5B2( )
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
               if ( StringUtil.Len( WebComp_Br_pathology_specimenwc_Component) != 0 )
               {
                  WebComp_Br_pathology_specimenwc.componentstart();
               }
            }
         }
         if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
         {
            if ( 1 != 0 )
            {
               if ( StringUtil.Len( WebComp_Br_pathology_diagwc_Component) != 0 )
               {
                  WebComp_Br_pathology_diagwc.componentstart();
               }
            }
         }
         if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
         {
            if ( 1 != 0 )
            {
               if ( StringUtil.Len( WebComp_Br_pathology_otherwc_Component) != 0 )
               {
                  WebComp_Br_pathology_otherwc.componentstart();
               }
            }
         }
         gxdyncontrolsrefreshing = true;
         fix_multi_value_controls( ) ;
         gxdyncontrolsrefreshing = false;
         if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
         {
            /* Execute user event: Load */
            E135B2 ();
            WB5B0( ) ;
         }
      }

      protected void send_integrity_lvl_hashes5B2( )
      {
         GxWebStd.gx_hidden_field( context, "vBR_PATHOLOGYID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV10BR_PathologyID), 18, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "gxhash_vBR_PATHOLOGYID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV10BR_PathologyID), "ZZZZZZZZZZZZZZZZZZ"), context));
      }

      protected void STRUP5B0( )
      {
         /* Before Start, stand alone formulas. */
         context.Gx_err = 0;
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0;
         /* Execute user event: Start */
         E125B2 ();
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
         E125B2 ();
         if (returnInSub) return;
      }

      protected void E125B2( )
      {
         /* Start Routine */
         new GeneXus.Programs.wwpbaseobjects.loadwwpcontext(context ).execute( out  AV6WWPContext) ;
         AV22GXLvl9 = 0;
         /* Using cursor H005B2 */
         pr_default.execute(0, new Object[] {AV10BR_PathologyID});
         while ( (pr_default.getStatus(0) != 101) )
         {
            A226BR_PathologyID = H005B2_A226BR_PathologyID[0];
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

      protected void nextLoad( )
      {
      }

      protected void E135B2( )
      {
         /* Load Routine */
      }

      protected void E145B2( )
      {
         /* 'Doback' Routine */
         AV16tEncounterType = StringUtil.Trim( AV17WebSession.Get("Br_EncounterType"));
         AV18BCBR_Pathology.Load(AV10BR_PathologyID);
         if ( StringUtil.StrCmp(AV16tEncounterType, "update") == 0 )
         {
            CallWebObject(formatLink("br_encounterupdate.aspx") + "?" + UrlEncode("" +AV18BCBR_Pathology.gxTpr_Br_encounterid) + "," + UrlEncode(StringUtil.RTrim("BR_Pathology")));
            context.wjLocDisableFrm = 1;
         }
         else
         {
            CallWebObject(formatLink("br_encountercheck.aspx") + "?" + UrlEncode("" +AV18BCBR_Pathology.gxTpr_Br_encounterid) + "," + UrlEncode(StringUtil.RTrim("BR_Pathology")));
            context.wjLocDisableFrm = 1;
         }
      }

      protected void E115B2( )
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

      protected void E155B2( )
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

      protected void E165B2( )
      {
         /* 'BR_Pathology_Specimen' Routine */
         this.executeUsercontrolMethod("", false, "TABSContainer", "SelectTab", "", new Object[] {(short)2});
         AV12SelectedTabCode = "BR_Pathology_Specimen";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12SelectedTabCode", AV12SelectedTabCode);
         AV11LoadAllTabs = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11LoadAllTabs", AV11LoadAllTabs);
         /* Execute user subroutine: 'LOADTABS' */
         S112 ();
         if (returnInSub) return;
         /*  Sending Event outputs  */
      }

      protected void E175B2( )
      {
         /* 'BR_Pathology_Diag' Routine */
         this.executeUsercontrolMethod("", false, "TABSContainer", "SelectTab", "", new Object[] {(short)3});
         AV12SelectedTabCode = "BR_Pathology_Diag";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12SelectedTabCode", AV12SelectedTabCode);
         AV11LoadAllTabs = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11LoadAllTabs", AV11LoadAllTabs);
         /* Execute user subroutine: 'LOADTABS' */
         S112 ();
         if (returnInSub) return;
         /*  Sending Event outputs  */
      }

      protected void E185B2( )
      {
         /* 'BR_Pathology_Other' Routine */
         this.executeUsercontrolMethod("", false, "TABSContainer", "SelectTab", "", new Object[] {(short)4});
         AV12SelectedTabCode = "BR_Pathology_Other";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12SelectedTabCode", AV12SelectedTabCode);
         AV11LoadAllTabs = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11LoadAllTabs", AV11LoadAllTabs);
         /* Execute user subroutine: 'LOADTABS' */
         S112 ();
         if (returnInSub) return;
         /*  Sending Event outputs  */
      }

      protected void S112( )
      {
         /* 'LOADTABS' Routine */
         new zutil_checksession(context ).execute( out  AV19tCheckFlag) ;
         if ( ! AV19tCheckFlag )
         {
            /* Using cursor H005B3 */
            pr_default.execute(1, new Object[] {AV10BR_PathologyID});
            while ( (pr_default.getStatus(1) != 101) )
            {
               A226BR_PathologyID = H005B3_A226BR_PathologyID[0];
               divCell_general_Visible = 1;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, divCell_general_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(divCell_general_Visible), 5, 0)), true);
               if ( AV11LoadAllTabs || ( StringUtil.StrCmp(AV12SelectedTabCode, "") == 0 ) || ( StringUtil.StrCmp(AV12SelectedTabCode, "General") == 0 ) )
               {
                  /* Object Property */
                  if ( StringUtil.StrCmp(StringUtil.Lower( WebComp_Generalwc_Component), StringUtil.Lower( "BR_PathologyGeneral")) != 0 )
                  {
                     WebComp_Generalwc = getWebComponent(GetType(), "GeneXus.Programs", "br_pathologygeneral", new Object[] {context} );
                     WebComp_Generalwc.ComponentInit();
                     WebComp_Generalwc.Name = "BR_PathologyGeneral";
                     WebComp_Generalwc_Component = "BR_PathologyGeneral";
                  }
                  if ( StringUtil.Len( WebComp_Generalwc_Component) != 0 )
                  {
                     WebComp_Generalwc.setjustcreated();
                     WebComp_Generalwc.componentprepare(new Object[] {(String)"W0026",(String)"",(long)AV10BR_PathologyID});
                     WebComp_Generalwc.componentbind(new Object[] {(String)""});
                  }
                  if ( isFullAjaxMode( ) )
                  {
                     context.httpAjaxContext.ajax_rspStartCmp("gxHTMLWrpW0026"+"");
                     WebComp_Generalwc.componentdraw();
                     context.httpAjaxContext.ajax_rspEndCmp();
                  }
                  lblTxttabtitle_Caption = "病理学信息";
                  context.httpAjaxContext.ajax_rsp_assign_prop("", false, lblTxttabtitle_Internalname, "Caption", lblTxttabtitle_Caption, true);
                  if ( ( StringUtil.StrCmp(AV12SelectedTabCode, "") == 0 ) || ( StringUtil.StrCmp(AV12SelectedTabCode, "General") == 0 ) )
                  {
                     divCell_general_Visible = 0;
                     context.httpAjaxContext.ajax_rsp_assign_prop("", false, divCell_general_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(divCell_general_Visible), 5, 0)), true);
                  }
               }
               divCell_br_pathology_specimen_Visible = 1;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, divCell_br_pathology_specimen_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(divCell_br_pathology_specimen_Visible), 5, 0)), true);
               GXt_boolean1 = AV13TempBoolean;
               new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "Check_Pathology_Specimen", out  GXt_boolean1) ;
               AV13TempBoolean = GXt_boolean1;
               if ( AV13TempBoolean )
               {
                  if ( AV11LoadAllTabs || ( StringUtil.StrCmp(AV12SelectedTabCode, "BR_Pathology_Specimen") == 0 ) )
                  {
                     /* Object Property */
                     if ( StringUtil.StrCmp(StringUtil.Lower( WebComp_Br_pathology_specimenwc_Component), StringUtil.Lower( "BR_PathologyBR_Pathology_SpecimenWC")) != 0 )
                     {
                        WebComp_Br_pathology_specimenwc = getWebComponent(GetType(), "GeneXus.Programs", "br_pathologybr_pathology_specimenwc", new Object[] {context} );
                        WebComp_Br_pathology_specimenwc.ComponentInit();
                        WebComp_Br_pathology_specimenwc.Name = "BR_PathologyBR_Pathology_SpecimenWC";
                        WebComp_Br_pathology_specimenwc_Component = "BR_PathologyBR_Pathology_SpecimenWC";
                     }
                     if ( StringUtil.Len( WebComp_Br_pathology_specimenwc_Component) != 0 )
                     {
                        WebComp_Br_pathology_specimenwc.setjustcreated();
                        WebComp_Br_pathology_specimenwc.componentprepare(new Object[] {(String)"W0034",(String)"",(long)AV10BR_PathologyID});
                        WebComp_Br_pathology_specimenwc.componentbind(new Object[] {(String)""});
                     }
                     if ( isFullAjaxMode( ) )
                     {
                        context.httpAjaxContext.ajax_rspStartCmp("gxHTMLWrpW0034"+"");
                        WebComp_Br_pathology_specimenwc.componentdraw();
                        context.httpAjaxContext.ajax_rspEndCmp();
                     }
                     lblTxttabtitle_Caption = "病理学送检组织";
                     context.httpAjaxContext.ajax_rsp_assign_prop("", false, lblTxttabtitle_Internalname, "Caption", lblTxttabtitle_Caption, true);
                     if ( StringUtil.StrCmp(AV12SelectedTabCode, "BR_Pathology_Specimen") == 0 )
                     {
                        divCell_br_pathology_specimen_Visible = 0;
                        context.httpAjaxContext.ajax_rsp_assign_prop("", false, divCell_br_pathology_specimen_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(divCell_br_pathology_specimen_Visible), 5, 0)), true);
                     }
                  }
               }
               else
               {
                  divCell_br_pathology_specimen_Visible = 0;
                  context.httpAjaxContext.ajax_rsp_assign_prop("", false, divCell_br_pathology_specimen_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(divCell_br_pathology_specimen_Visible), 5, 0)), true);
                  this.executeUsercontrolMethod("", false, "TABSContainer", "HideTab", "", new Object[] {(short)2});
               }
               divCell_br_pathology_diag_Visible = 1;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, divCell_br_pathology_diag_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(divCell_br_pathology_diag_Visible), 5, 0)), true);
               GXt_boolean1 = AV13TempBoolean;
               new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "Check_Pathology_Diag", out  GXt_boolean1) ;
               AV13TempBoolean = GXt_boolean1;
               if ( AV13TempBoolean )
               {
                  if ( AV11LoadAllTabs || ( StringUtil.StrCmp(AV12SelectedTabCode, "BR_Pathology_Diag") == 0 ) )
                  {
                     /* Object Property */
                     if ( StringUtil.StrCmp(StringUtil.Lower( WebComp_Br_pathology_diagwc_Component), StringUtil.Lower( "BR_PathologyBR_Pathology_DiagWC")) != 0 )
                     {
                        WebComp_Br_pathology_diagwc = getWebComponent(GetType(), "GeneXus.Programs", "br_pathologybr_pathology_diagwc", new Object[] {context} );
                        WebComp_Br_pathology_diagwc.ComponentInit();
                        WebComp_Br_pathology_diagwc.Name = "BR_PathologyBR_Pathology_DiagWC";
                        WebComp_Br_pathology_diagwc_Component = "BR_PathologyBR_Pathology_DiagWC";
                     }
                     if ( StringUtil.Len( WebComp_Br_pathology_diagwc_Component) != 0 )
                     {
                        WebComp_Br_pathology_diagwc.setjustcreated();
                        WebComp_Br_pathology_diagwc.componentprepare(new Object[] {(String)"W0042",(String)"",(long)AV10BR_PathologyID});
                        WebComp_Br_pathology_diagwc.componentbind(new Object[] {(String)""});
                     }
                     if ( isFullAjaxMode( ) )
                     {
                        context.httpAjaxContext.ajax_rspStartCmp("gxHTMLWrpW0042"+"");
                        WebComp_Br_pathology_diagwc.componentdraw();
                        context.httpAjaxContext.ajax_rspEndCmp();
                     }
                     lblTxttabtitle_Caption = "病理学诊断";
                     context.httpAjaxContext.ajax_rsp_assign_prop("", false, lblTxttabtitle_Internalname, "Caption", lblTxttabtitle_Caption, true);
                     if ( StringUtil.StrCmp(AV12SelectedTabCode, "BR_Pathology_Diag") == 0 )
                     {
                        divCell_br_pathology_diag_Visible = 0;
                        context.httpAjaxContext.ajax_rsp_assign_prop("", false, divCell_br_pathology_diag_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(divCell_br_pathology_diag_Visible), 5, 0)), true);
                     }
                  }
               }
               else
               {
                  divCell_br_pathology_diag_Visible = 0;
                  context.httpAjaxContext.ajax_rsp_assign_prop("", false, divCell_br_pathology_diag_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(divCell_br_pathology_diag_Visible), 5, 0)), true);
                  this.executeUsercontrolMethod("", false, "TABSContainer", "HideTab", "", new Object[] {(short)3});
               }
               divCell_br_pathology_other_Visible = 1;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, divCell_br_pathology_other_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(divCell_br_pathology_other_Visible), 5, 0)), true);
               GXt_boolean1 = AV13TempBoolean;
               new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "Check_Pathology_Other", out  GXt_boolean1) ;
               AV13TempBoolean = GXt_boolean1;
               if ( AV13TempBoolean )
               {
                  if ( AV11LoadAllTabs || ( StringUtil.StrCmp(AV12SelectedTabCode, "BR_Pathology_Other") == 0 ) )
                  {
                     /* Object Property */
                     if ( StringUtil.StrCmp(StringUtil.Lower( WebComp_Br_pathology_otherwc_Component), StringUtil.Lower( "BR_PathologyBR_Pathology_OtherWC")) != 0 )
                     {
                        WebComp_Br_pathology_otherwc = getWebComponent(GetType(), "GeneXus.Programs", "br_pathologybr_pathology_otherwc", new Object[] {context} );
                        WebComp_Br_pathology_otherwc.ComponentInit();
                        WebComp_Br_pathology_otherwc.Name = "BR_PathologyBR_Pathology_OtherWC";
                        WebComp_Br_pathology_otherwc_Component = "BR_PathologyBR_Pathology_OtherWC";
                     }
                     if ( StringUtil.Len( WebComp_Br_pathology_otherwc_Component) != 0 )
                     {
                        WebComp_Br_pathology_otherwc.setjustcreated();
                        WebComp_Br_pathology_otherwc.componentprepare(new Object[] {(String)"W0050",(String)"",(long)AV10BR_PathologyID});
                        WebComp_Br_pathology_otherwc.componentbind(new Object[] {(String)""});
                     }
                     if ( isFullAjaxMode( ) )
                     {
                        context.httpAjaxContext.ajax_rspStartCmp("gxHTMLWrpW0050"+"");
                        WebComp_Br_pathology_otherwc.componentdraw();
                        context.httpAjaxContext.ajax_rspEndCmp();
                     }
                     lblTxttabtitle_Caption = "病理学其它信息";
                     context.httpAjaxContext.ajax_rsp_assign_prop("", false, lblTxttabtitle_Internalname, "Caption", lblTxttabtitle_Caption, true);
                     if ( StringUtil.StrCmp(AV12SelectedTabCode, "BR_Pathology_Other") == 0 )
                     {
                        divCell_br_pathology_other_Visible = 0;
                        context.httpAjaxContext.ajax_rsp_assign_prop("", false, divCell_br_pathology_other_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(divCell_br_pathology_other_Visible), 5, 0)), true);
                     }
                  }
               }
               else
               {
                  divCell_br_pathology_other_Visible = 0;
                  context.httpAjaxContext.ajax_rsp_assign_prop("", false, divCell_br_pathology_other_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(divCell_br_pathology_other_Visible), 5, 0)), true);
                  this.executeUsercontrolMethod("", false, "TABSContainer", "HideTab", "", new Object[] {(short)4});
               }
               /* Exiting from a For First loop. */
               if (true) break;
            }
            pr_default.close(1);
         }
      }

      public override void setparameters( Object[] obj )
      {
         createObjects();
         initialize();
         AV10BR_PathologyID = Convert.ToInt64(getParm(obj,0));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10BR_PathologyID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10BR_PathologyID), 18, 0)));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vBR_PATHOLOGYID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV10BR_PathologyID), "ZZZZZZZZZZZZZZZZZZ"), context));
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
         PA5B2( ) ;
         WS5B2( ) ;
         WE5B2( ) ;
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
         if ( ! ( WebComp_Br_pathology_specimenwc == null ) )
         {
            if ( StringUtil.Len( WebComp_Br_pathology_specimenwc_Component) != 0 )
            {
               WebComp_Br_pathology_specimenwc.componentthemes();
            }
         }
         if ( ! ( WebComp_Br_pathology_diagwc == null ) )
         {
            if ( StringUtil.Len( WebComp_Br_pathology_diagwc_Component) != 0 )
            {
               WebComp_Br_pathology_diagwc.componentthemes();
            }
         }
         if ( ! ( WebComp_Br_pathology_otherwc == null ) )
         {
            if ( StringUtil.Len( WebComp_Br_pathology_otherwc_Component) != 0 )
            {
               WebComp_Br_pathology_otherwc.componentthemes();
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
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?20202279425497", true);
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
         context.AddJavascriptSource("br_pathologyview.js", "?20202279425497", false);
         context.AddJavascriptSource("Shared/HistoryManager/HistoryManager.js", "", false);
         context.AddJavascriptSource("Shared/HistoryManager/rsh/json2005.js", "", false);
         context.AddJavascriptSource("Shared/HistoryManager/rsh/rsh.js", "", false);
         context.AddJavascriptSource("Shared/HistoryManager/HistoryManagerCreate.js", "", false);
         context.AddJavascriptSource("Tab/TabRender.js", "", false);
         /* End function include_jscripts */
      }

      protected void init_web_controls( )
      {
         /* End function init_web_controls */
      }

      protected void init_default_properties( )
      {
         bttBtnback_Internalname = "BTNBACK";
         lblTxttabtitle_Internalname = "TXTTABTITLE";
         lblGeneral_title_Internalname = "GENERAL_TITLE";
         divUnnamedtablegeneral_Internalname = "UNNAMEDTABLEGENERAL";
         lblBr_pathology_specimen_title_Internalname = "BR_PATHOLOGY_SPECIMEN_TITLE";
         divUnnamedtablebr_pathology_specimen_Internalname = "UNNAMEDTABLEBR_PATHOLOGY_SPECIMEN";
         lblBr_pathology_diag_title_Internalname = "BR_PATHOLOGY_DIAG_TITLE";
         divUnnamedtablebr_pathology_diag_Internalname = "UNNAMEDTABLEBR_PATHOLOGY_DIAG";
         lblBr_pathology_other_title_Internalname = "BR_PATHOLOGY_OTHER_TITLE";
         divUnnamedtablebr_pathology_other_Internalname = "UNNAMEDTABLEBR_PATHOLOGY_OTHER";
         Tabs_Internalname = "TABS";
         bttBtngeneral_Internalname = "BTNGENERAL";
         divCell_general_Internalname = "CELL_GENERAL";
         bttBtnbr_pathology_specimen_Internalname = "BTNBR_PATHOLOGY_SPECIMEN";
         divCell_br_pathology_specimen_Internalname = "CELL_BR_PATHOLOGY_SPECIMEN";
         bttBtnbr_pathology_diag_Internalname = "BTNBR_PATHOLOGY_DIAG";
         divCell_br_pathology_diag_Internalname = "CELL_BR_PATHOLOGY_DIAG";
         bttBtnbr_pathology_other_Internalname = "BTNBR_PATHOLOGY_OTHER";
         divCell_br_pathology_other_Internalname = "CELL_BR_PATHOLOGY_OTHER";
         divUnnamedtabletabscontainer_Internalname = "UNNAMEDTABLETABSCONTAINER";
         divUnnamedtableviewcontainer_Internalname = "UNNAMEDTABLEVIEWCONTAINER";
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
         divCell_br_pathology_other_Visible = 1;
         divCell_br_pathology_diag_Visible = 1;
         divCell_br_pathology_specimen_Visible = 1;
         divCell_general_Visible = 1;
         lblTxttabtitle_Caption = "Title";
         Tabs_Historymanagement = Convert.ToBoolean( -1);
         Tabs_Pagecount = 4;
         Tabs_Class = "ViewTab Tab";
         Form.Headerrawhtml = "";
         Form.Background = "";
         Form.Textcolor = 0;
         Form.Backcolor = (int)(0xFFFFFF);
         Form.Caption = "BR_Pathology View";
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
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[{av:'AV10BR_PathologyID',fld:'vBR_PATHOLOGYID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true},{av:'AV8TabCode',fld:'vTABCODE',pic:'',hsh:true}]");
         setEventMetadata("REFRESH",",oparms:[]}");
         setEventMetadata("'DOBACK'","{handler:'E145B2',iparms:[{av:'AV10BR_PathologyID',fld:'vBR_PATHOLOGYID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true}]");
         setEventMetadata("'DOBACK'",",oparms:[]}");
         setEventMetadata("TABS.TABCHANGED","{handler:'E115B2',iparms:[{av:'Tabs_Activepagecontrolname',ctrl:'TABS',prop:'ActivePageControlName'},{av:'A226BR_PathologyID',fld:'BR_PATHOLOGYID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV10BR_PathologyID',fld:'vBR_PATHOLOGYID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true},{av:'AV11LoadAllTabs',fld:'vLOADALLTABS',pic:''},{av:'AV12SelectedTabCode',fld:'vSELECTEDTABCODE',pic:''}]");
         setEventMetadata("TABS.TABCHANGED",",oparms:[{av:'AV12SelectedTabCode',fld:'vSELECTEDTABCODE',pic:''},{av:'AV11LoadAllTabs',fld:'vLOADALLTABS',pic:''},{av:'divCell_general_Visible',ctrl:'CELL_GENERAL',prop:'Visible'},{ctrl:'GENERALWC'},{av:'lblTxttabtitle_Caption',ctrl:'TXTTABTITLE',prop:'Caption'},{av:'divCell_br_pathology_specimen_Visible',ctrl:'CELL_BR_PATHOLOGY_SPECIMEN',prop:'Visible'},{ctrl:'BR_PATHOLOGY_SPECIMENWC'},{av:'divCell_br_pathology_diag_Visible',ctrl:'CELL_BR_PATHOLOGY_DIAG',prop:'Visible'},{ctrl:'BR_PATHOLOGY_DIAGWC'},{av:'divCell_br_pathology_other_Visible',ctrl:'CELL_BR_PATHOLOGY_OTHER',prop:'Visible'},{ctrl:'BR_PATHOLOGY_OTHERWC'}]}");
         setEventMetadata("'GENERAL'","{handler:'E155B2',iparms:[{av:'A226BR_PathologyID',fld:'BR_PATHOLOGYID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV10BR_PathologyID',fld:'vBR_PATHOLOGYID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true},{av:'AV11LoadAllTabs',fld:'vLOADALLTABS',pic:''},{av:'AV12SelectedTabCode',fld:'vSELECTEDTABCODE',pic:''}]");
         setEventMetadata("'GENERAL'",",oparms:[{av:'AV12SelectedTabCode',fld:'vSELECTEDTABCODE',pic:''},{av:'AV11LoadAllTabs',fld:'vLOADALLTABS',pic:''},{av:'divCell_general_Visible',ctrl:'CELL_GENERAL',prop:'Visible'},{ctrl:'GENERALWC'},{av:'lblTxttabtitle_Caption',ctrl:'TXTTABTITLE',prop:'Caption'},{av:'divCell_br_pathology_specimen_Visible',ctrl:'CELL_BR_PATHOLOGY_SPECIMEN',prop:'Visible'},{ctrl:'BR_PATHOLOGY_SPECIMENWC'},{av:'divCell_br_pathology_diag_Visible',ctrl:'CELL_BR_PATHOLOGY_DIAG',prop:'Visible'},{ctrl:'BR_PATHOLOGY_DIAGWC'},{av:'divCell_br_pathology_other_Visible',ctrl:'CELL_BR_PATHOLOGY_OTHER',prop:'Visible'},{ctrl:'BR_PATHOLOGY_OTHERWC'}]}");
         setEventMetadata("'BR_PATHOLOGY_SPECIMEN'","{handler:'E165B2',iparms:[{av:'A226BR_PathologyID',fld:'BR_PATHOLOGYID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV10BR_PathologyID',fld:'vBR_PATHOLOGYID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true},{av:'AV11LoadAllTabs',fld:'vLOADALLTABS',pic:''},{av:'AV12SelectedTabCode',fld:'vSELECTEDTABCODE',pic:''}]");
         setEventMetadata("'BR_PATHOLOGY_SPECIMEN'",",oparms:[{av:'AV12SelectedTabCode',fld:'vSELECTEDTABCODE',pic:''},{av:'AV11LoadAllTabs',fld:'vLOADALLTABS',pic:''},{av:'divCell_general_Visible',ctrl:'CELL_GENERAL',prop:'Visible'},{ctrl:'GENERALWC'},{av:'lblTxttabtitle_Caption',ctrl:'TXTTABTITLE',prop:'Caption'},{av:'divCell_br_pathology_specimen_Visible',ctrl:'CELL_BR_PATHOLOGY_SPECIMEN',prop:'Visible'},{ctrl:'BR_PATHOLOGY_SPECIMENWC'},{av:'divCell_br_pathology_diag_Visible',ctrl:'CELL_BR_PATHOLOGY_DIAG',prop:'Visible'},{ctrl:'BR_PATHOLOGY_DIAGWC'},{av:'divCell_br_pathology_other_Visible',ctrl:'CELL_BR_PATHOLOGY_OTHER',prop:'Visible'},{ctrl:'BR_PATHOLOGY_OTHERWC'}]}");
         setEventMetadata("'BR_PATHOLOGY_DIAG'","{handler:'E175B2',iparms:[{av:'A226BR_PathologyID',fld:'BR_PATHOLOGYID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV10BR_PathologyID',fld:'vBR_PATHOLOGYID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true},{av:'AV11LoadAllTabs',fld:'vLOADALLTABS',pic:''},{av:'AV12SelectedTabCode',fld:'vSELECTEDTABCODE',pic:''}]");
         setEventMetadata("'BR_PATHOLOGY_DIAG'",",oparms:[{av:'AV12SelectedTabCode',fld:'vSELECTEDTABCODE',pic:''},{av:'AV11LoadAllTabs',fld:'vLOADALLTABS',pic:''},{av:'divCell_general_Visible',ctrl:'CELL_GENERAL',prop:'Visible'},{ctrl:'GENERALWC'},{av:'lblTxttabtitle_Caption',ctrl:'TXTTABTITLE',prop:'Caption'},{av:'divCell_br_pathology_specimen_Visible',ctrl:'CELL_BR_PATHOLOGY_SPECIMEN',prop:'Visible'},{ctrl:'BR_PATHOLOGY_SPECIMENWC'},{av:'divCell_br_pathology_diag_Visible',ctrl:'CELL_BR_PATHOLOGY_DIAG',prop:'Visible'},{ctrl:'BR_PATHOLOGY_DIAGWC'},{av:'divCell_br_pathology_other_Visible',ctrl:'CELL_BR_PATHOLOGY_OTHER',prop:'Visible'},{ctrl:'BR_PATHOLOGY_OTHERWC'}]}");
         setEventMetadata("'BR_PATHOLOGY_OTHER'","{handler:'E185B2',iparms:[{av:'A226BR_PathologyID',fld:'BR_PATHOLOGYID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV10BR_PathologyID',fld:'vBR_PATHOLOGYID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true},{av:'AV11LoadAllTabs',fld:'vLOADALLTABS',pic:''},{av:'AV12SelectedTabCode',fld:'vSELECTEDTABCODE',pic:''}]");
         setEventMetadata("'BR_PATHOLOGY_OTHER'",",oparms:[{av:'AV12SelectedTabCode',fld:'vSELECTEDTABCODE',pic:''},{av:'AV11LoadAllTabs',fld:'vLOADALLTABS',pic:''},{av:'divCell_general_Visible',ctrl:'CELL_GENERAL',prop:'Visible'},{ctrl:'GENERALWC'},{av:'lblTxttabtitle_Caption',ctrl:'TXTTABTITLE',prop:'Caption'},{av:'divCell_br_pathology_specimen_Visible',ctrl:'CELL_BR_PATHOLOGY_SPECIMEN',prop:'Visible'},{ctrl:'BR_PATHOLOGY_SPECIMENWC'},{av:'divCell_br_pathology_diag_Visible',ctrl:'CELL_BR_PATHOLOGY_DIAG',prop:'Visible'},{ctrl:'BR_PATHOLOGY_DIAGWC'},{av:'divCell_br_pathology_other_Visible',ctrl:'CELL_BR_PATHOLOGY_OTHER',prop:'Visible'},{ctrl:'BR_PATHOLOGY_OTHERWC'}]}");
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
         bttBtnback_Jsonclick = "";
         lblTxttabtitle_Jsonclick = "";
         ucTabs = new GXUserControl();
         lblGeneral_title_Jsonclick = "";
         WebComp_Generalwc_Component = "";
         OldGeneralwc = "";
         lblBr_pathology_specimen_title_Jsonclick = "";
         WebComp_Br_pathology_specimenwc_Component = "";
         OldBr_pathology_specimenwc = "";
         lblBr_pathology_diag_title_Jsonclick = "";
         WebComp_Br_pathology_diagwc_Component = "";
         OldBr_pathology_diagwc = "";
         lblBr_pathology_other_title_Jsonclick = "";
         WebComp_Br_pathology_otherwc_Component = "";
         OldBr_pathology_otherwc = "";
         bttBtngeneral_Jsonclick = "";
         bttBtnbr_pathology_specimen_Jsonclick = "";
         bttBtnbr_pathology_diag_Jsonclick = "";
         bttBtnbr_pathology_other_Jsonclick = "";
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         AV6WWPContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPContext(context);
         scmdbuf = "";
         H005B2_A226BR_PathologyID = new long[1] ;
         AV16tEncounterType = "";
         AV17WebSession = context.GetSession();
         AV18BCBR_Pathology = new SdtBR_Pathology(context);
         H005B3_A226BR_PathologyID = new long[1] ;
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.br_pathologyview__default(),
            new Object[][] {
                new Object[] {
               H005B2_A226BR_PathologyID
               }
               , new Object[] {
               H005B3_A226BR_PathologyID
               }
            }
         );
         WebComp_Generalwc = new GeneXus.Http.GXNullWebComponent();
         WebComp_Br_pathology_specimenwc = new GeneXus.Http.GXNullWebComponent();
         WebComp_Br_pathology_diagwc = new GeneXus.Http.GXNullWebComponent();
         WebComp_Br_pathology_otherwc = new GeneXus.Http.GXNullWebComponent();
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
      private int divCell_general_Visible ;
      private int divCell_br_pathology_specimen_Visible ;
      private int divCell_br_pathology_diag_Visible ;
      private int divCell_br_pathology_other_Visible ;
      private int idxLst ;
      private long AV10BR_PathologyID ;
      private long wcpOAV10BR_PathologyID ;
      private long A226BR_PathologyID ;
      private String AV8TabCode ;
      private String wcpOAV8TabCode ;
      private String Tabs_Activepagecontrolname ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String sDynURL ;
      private String FormProcess ;
      private String bodyStyle ;
      private String GXKey ;
      private String AV12SelectedTabCode ;
      private String Tabs_Class ;
      private String GX_FocusControl ;
      private String sPrefix ;
      private String divLayoutmaintable_Internalname ;
      private String divTablemain_Internalname ;
      private String TempTags ;
      private String ClassString ;
      private String StyleString ;
      private String bttBtnback_Internalname ;
      private String bttBtnback_Jsonclick ;
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
      private String lblBr_pathology_specimen_title_Internalname ;
      private String lblBr_pathology_specimen_title_Jsonclick ;
      private String divUnnamedtablebr_pathology_specimen_Internalname ;
      private String WebComp_Br_pathology_specimenwc_Component ;
      private String OldBr_pathology_specimenwc ;
      private String lblBr_pathology_diag_title_Internalname ;
      private String lblBr_pathology_diag_title_Jsonclick ;
      private String divUnnamedtablebr_pathology_diag_Internalname ;
      private String WebComp_Br_pathology_diagwc_Component ;
      private String OldBr_pathology_diagwc ;
      private String lblBr_pathology_other_title_Internalname ;
      private String lblBr_pathology_other_title_Jsonclick ;
      private String divUnnamedtablebr_pathology_other_Internalname ;
      private String WebComp_Br_pathology_otherwc_Component ;
      private String OldBr_pathology_otherwc ;
      private String divUnnamedtabletabscontainer_Internalname ;
      private String divCell_general_Internalname ;
      private String bttBtngeneral_Internalname ;
      private String bttBtngeneral_Jsonclick ;
      private String divCell_br_pathology_specimen_Internalname ;
      private String bttBtnbr_pathology_specimen_Internalname ;
      private String bttBtnbr_pathology_specimen_Jsonclick ;
      private String divCell_br_pathology_diag_Internalname ;
      private String bttBtnbr_pathology_diag_Internalname ;
      private String bttBtnbr_pathology_diag_Jsonclick ;
      private String divCell_br_pathology_other_Internalname ;
      private String bttBtnbr_pathology_other_Internalname ;
      private String bttBtnbr_pathology_other_Jsonclick ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String scmdbuf ;
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
      private bool AV19tCheckFlag ;
      private bool AV13TempBoolean ;
      private bool GXt_boolean1 ;
      private String AV16tEncounterType ;
      private IGxSession AV17WebSession ;
      private GXWebComponent WebComp_Generalwc ;
      private GXWebComponent WebComp_Br_pathology_specimenwc ;
      private GXWebComponent WebComp_Br_pathology_diagwc ;
      private GXWebComponent WebComp_Br_pathology_otherwc ;
      private GXUserControl ucTabs ;
      private IGxDataStore dsDataStore1 ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private long[] H005B2_A226BR_PathologyID ;
      private long[] H005B3_A226BR_PathologyID ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private GXWebForm Form ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPContext AV6WWPContext ;
      private SdtBR_Pathology AV18BCBR_Pathology ;
   }

   public class br_pathologyview__default : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmH005B2 ;
          prmH005B2 = new Object[] {
          new Object[] {"@AV10BR_PathologyID",SqlDbType.Decimal,18,0}
          } ;
          Object[] prmH005B3 ;
          prmH005B3 = new Object[] {
          new Object[] {"@AV10BR_PathologyID",SqlDbType.Decimal,18,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("H005B2", "SELECT [BR_PathologyID] FROM [BR_Pathology] WITH (NOLOCK) WHERE [BR_PathologyID] = @AV10BR_PathologyID ORDER BY [BR_PathologyID] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH005B2,1,0,false,true )
             ,new CursorDef("H005B3", "SELECT [BR_PathologyID] FROM [BR_Pathology] WITH (NOLOCK) WHERE [BR_PathologyID] = @AV10BR_PathologyID ORDER BY [BR_PathologyID] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH005B3,1,0,true,true )
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
