/*
               File: BR_PathologyInsert
        Description:
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/27/2020 12:7:7.0
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
   public class br_pathologyinsert : GXDataArea, System.Web.SessionState.IRequiresSessionState
   {
      public br_pathologyinsert( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public br_pathologyinsert( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( long aP0_BR_EncounterID )
      {
         this.AV13BR_EncounterID = aP0_BR_EncounterID;
         executePrivate();
      }

      void executePrivate( )
      {
         isStatic = false;
         webExecute();
      }

      protected override void createObjects( )
      {
         dynavBr_pathology_br_pathologyid_pahosp = new GXCombobox();
         cmbavBr_pathology_br_pathology_n = new GXCombobox();
         cmbavVpathologym = new GXCombobox();
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
            else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxCallCrl"+"_"+"BR_PATHOLOGY_BR_PATHOLOGYID_PAHOSP") == 0 )
            {
               AV12tCurrentCode = GetNextPar( );
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1;
                  return  ;
               }
               GXDLVBR_PATHOLOGY_BR_PATHOLOGYID_PAHOSP992( AV12tCurrentCode) ;
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
               AV13BR_EncounterID = (long)(NumberUtil.Val( gxfirstwebparm, "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13BR_EncounterID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13BR_EncounterID), 18, 0)));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vBR_ENCOUNTERID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV13BR_EncounterID), "ZZZZZZZZZZZZZZZZZZ"), context));
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
         PA992( ) ;
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0));
         if ( ( gxajaxcallmode == 0 ) && ( GxWebError == 0 ) )
         {
            START992( ) ;
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
         context.AddJavascriptSource("gxcfg.js", "?202022712778", false);
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" autocomplete=\"off\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("br_pathologyinsert.aspx") + "?" + UrlEncode("" +AV13BR_EncounterID)+"\">") ;
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
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "Br_pathology", AV10BR_Pathology);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("Br_pathology", AV10BR_Pathology);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vBR_PATHOLOGY", AV10BR_Pathology);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vBR_PATHOLOGY", AV10BR_Pathology);
         }
         GxWebStd.gx_hidden_field( context, "vBR_ENCOUNTERID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV13BR_EncounterID), 18, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "gxhash_vBR_ENCOUNTERID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV13BR_EncounterID), "ZZZZZZZZZZZZZZZZZZ"), context));
         GxWebStd.gx_hidden_field( context, "vTCURRENTCODE", AV12tCurrentCode);
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
            WE992( ) ;
            context.WriteHtmlText( "</div>") ;
         }
      }

      public override void DispatchEvents( )
      {
         EVT992( ) ;
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
         return formatLink("br_pathologyinsert.aspx") + "?" + UrlEncode("" +AV13BR_EncounterID) ;
      }

      public override String GetPgmname( )
      {
         return "BR_PathologyInsert" ;
      }

      public override String GetPgmdesc( )
      {
         return "" ;
      }

      protected void WB990( )
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
            GxWebStd.gx_div_start( context, divUnnamedtablebr_pathology_br_pathologyid_padate_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-4 MergeLabelCell", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblockbr_pathology_br_pathologyid_padate_Internalname, "病理检查日期", "", "", lblTextblockbr_pathology_br_pathologyid_padate_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_BR_PathologyInsert.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-8", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavBr_pathology_br_pathologyid_padate_Internalname, "病理检查日期", "col-sm-3 AttributeDateLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 29,'',false,'',0)\"";
            context.WriteHtmlText( "<div id=\""+edtavBr_pathology_br_pathologyid_padate_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtavBr_pathology_br_pathologyid_padate_Internalname, context.localUtil.Format(AV10BR_Pathology.gxTpr_Br_pathologyid_padate, "9999/99/99"), context.localUtil.Format( AV10BR_Pathology.gxTpr_Br_pathologyid_padate, "9999/99/99"), TempTags+" onchange=\""+"gx.date.valid_date(this, 10,'YMD',0,24,'chs',false,0);"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,29);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavBr_pathology_br_pathologyid_padate_Jsonclick, 0, "AttributeDate", "", "", "", "", 1, edtavBr_pathology_br_pathologyid_padate_Enabled, 0, "text", "", 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_BR_PathologyInsert.htm");
            GxWebStd.gx_bitmap( context, edtavBr_pathology_br_pathologyid_padate_Internalname+"_dp_trigger", context.GetImagePath( "61b9b5d3-dff6-4d59-9b00-da61bc2cbe93", "", context.GetTheme( )), "", "", "", "", ((1==0)||(edtavBr_pathology_br_pathologyid_padate_Enabled==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;", "", "", "", "", "", "", "", "", 1, false, false, "", "HLP_BR_PathologyInsert.htm");
            context.WriteHtmlTextNl( "</div>") ;
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 RequiredDataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divUnnamedtablebr_pathology_br_pathologyid_paage_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-4 MergeLabelCell", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblockbr_pathology_br_pathologyid_paage_Internalname, "年龄", "", "", lblTextblockbr_pathology_br_pathologyid_paage_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_BR_PathologyInsert.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-8", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavBr_pathology_br_pathologyid_paage_Internalname, "年龄", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 37,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavBr_pathology_br_pathologyid_paage_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV10BR_Pathology.gxTpr_Br_pathologyid_paage), 3, 0, ".", "")), ((edtavBr_pathology_br_pathologyid_paage_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(AV10BR_Pathology.gxTpr_Br_pathologyid_paage), "ZZZ")) : context.localUtil.Format( (decimal)(AV10BR_Pathology.gxTpr_Br_pathologyid_paage), "ZZZ")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,37);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavBr_pathology_br_pathologyid_paage_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtavBr_pathology_br_pathologyid_paage_Enabled, 0, "number", "1", 3, "chr", 1, "row", 3, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_BR_PathologyInsert.htm");
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
            GxWebStd.gx_div_start( context, divUnnamedtablebr_pathology_br_pathologyid_pahosp_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-4 MergeLabelCell", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblockbr_pathology_br_pathologyid_pahosp_Internalname, "检查医院", "", "", lblTextblockbr_pathology_br_pathologyid_pahosp_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_BR_PathologyInsert.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-8", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, dynavBr_pathology_br_pathologyid_pahosp_Internalname, "检查医院", "col-sm-3 AttributeLabel", 0, true);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 46,'',false,'',0)\"";
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, dynavBr_pathology_br_pathologyid_pahosp, dynavBr_pathology_br_pathologyid_pahosp_Internalname, StringUtil.RTrim( AV10BR_Pathology.gxTpr_Br_pathologyid_pahosp), 1, dynavBr_pathology_br_pathologyid_pahosp_Jsonclick, 0, "'"+""+"'"+",false,"+"'"+""+"'", "svchar", "", 1, dynavBr_pathology_br_pathologyid_pahosp.Enabled, 0, 0, 0, "em", 0, "", "", "Attribute", "", "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,46);\"", "", true, "HLP_BR_PathologyInsert.htm");
            dynavBr_pathology_br_pathologyid_pahosp.CurrentValue = StringUtil.RTrim( AV10BR_Pathology.gxTpr_Br_pathologyid_pahosp);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynavBr_pathology_br_pathologyid_pahosp_Internalname, "Values", (String)(dynavBr_pathology_br_pathologyid_pahosp.ToJavascriptSource()), true);
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 RequiredDataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divUnnamedtablebr_pathology_br_pathology_dia_name_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-2 MergeLabelCell", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblockbr_pathology_br_pathology_dia_name_Internalname, "病理诊断名称", "", "", lblTextblockbr_pathology_br_pathology_dia_name_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_BR_PathologyInsert.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-10", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavBr_pathology_br_pathology_dia_name_Internalname, "病理诊断名称", "col-sm-3 AttributeLabel", 0, true);
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 54,'',false,'',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavBr_pathology_br_pathology_dia_name_Internalname, AV10BR_Pathology.gxTpr_Br_pathology_dia_name, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,54);\"", 0, 1, edtavBr_pathology_br_pathology_dia_name_Enabled, 0, 80, "chr", 10, "row", StyleString, ClassString, "", "", "3000", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_PathologyInsert.htm");
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
            GxWebStd.gx_div_start( context, divUnnamedtablebr_pathology_br_pathologyid_paresult_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-2 MergeLabelCell", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblockbr_pathology_br_pathologyid_paresult_Internalname, "病理描述", "", "", lblTextblockbr_pathology_br_pathologyid_paresult_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_BR_PathologyInsert.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-10", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavBr_pathology_br_pathologyid_paresult_Internalname, "病理描述", "col-sm-3 AttributeLabel", 0, true);
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 63,'',false,'',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavBr_pathology_br_pathologyid_paresult_Internalname, AV10BR_Pathology.gxTpr_Br_pathologyid_paresult, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,63);\"", 0, 1, edtavBr_pathology_br_pathologyid_paresult_Enabled, 0, 80, "chr", 10, "row", StyleString, ClassString, "", "", "9999", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_PathologyInsert.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divUnnamedtablebr_pathology_br_pathologyid_prepadia_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-2 MergeLabelCell", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblockbr_pathology_br_pathologyid_prepadia_Internalname, "病理前诊断", "", "", lblTextblockbr_pathology_br_pathologyid_prepadia_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_BR_PathologyInsert.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-10", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavBr_pathology_br_pathologyid_prepadia_Internalname, "病理前诊断", "col-sm-3 AttributeLabel", 0, true);
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 71,'',false,'',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavBr_pathology_br_pathologyid_prepadia_Internalname, AV10BR_Pathology.gxTpr_Br_pathologyid_prepadia, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,71);\"", 0, 1, edtavBr_pathology_br_pathologyid_prepadia_Enabled, 0, 80, "chr", 10, "row", StyleString, ClassString, "", "", "4000", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_PathologyInsert.htm");
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
            GxWebStd.gx_div_start( context, divUnnamedtablebr_pathology_br_pathology_t_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-4 MergeLabelCell", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblockbr_pathology_br_pathology_t_Internalname, "原发肿瘤分级", "", "", lblTextblockbr_pathology_br_pathology_t_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_BR_PathologyInsert.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-8", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavBr_pathology_br_pathology_t_Internalname, "原发肿瘤分级", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 80,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavBr_pathology_br_pathology_t_Internalname, StringUtil.LTrim( StringUtil.NToC( AV10BR_Pathology.gxTpr_Br_pathology_t, 15, 5, ".", "")), ((edtavBr_pathology_br_pathology_t_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( AV10BR_Pathology.gxTpr_Br_pathology_t, "ZZZZZZZZZ.ZZZZZ")) : context.localUtil.Format( AV10BR_Pathology.gxTpr_Br_pathology_t, "ZZZZZZZZZ.ZZZZZ")), TempTags+" onchange=\""+"gx.num.valid_decimal( this, ',','.','5');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,80);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavBr_pathology_br_pathology_t_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtavBr_pathology_br_pathology_t_Enabled, 0, "text", "", 15, "chr", 1, "row", 15, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_BR_PathologyInsert.htm");
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
            GxWebStd.gx_div_start( context, divUnnamedtablebr_pathology_br_pathology_n_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-4 MergeLabelCell", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblockbr_pathology_br_pathology_n_Internalname, "是否淋巴结转移", "", "", lblTextblockbr_pathology_br_pathology_n_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_BR_PathologyInsert.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-8", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, cmbavBr_pathology_br_pathology_n_Internalname, "是否淋巴结转移", "col-sm-3 AttributeLabel", 0, true);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 89,'',false,'',0)\"";
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, cmbavBr_pathology_br_pathology_n, cmbavBr_pathology_br_pathology_n_Internalname, StringUtil.RTrim( AV10BR_Pathology.gxTpr_Br_pathology_n), 1, cmbavBr_pathology_br_pathology_n_Jsonclick, 0, "'"+""+"'"+",false,"+"'"+""+"'", "svchar", "", 1, cmbavBr_pathology_br_pathology_n.Enabled, 0, 0, 0, "em", 0, "", "", "Attribute", "", "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,89);\"", "", true, "HLP_BR_PathologyInsert.htm");
            cmbavBr_pathology_br_pathology_n.CurrentValue = StringUtil.RTrim( AV10BR_Pathology.gxTpr_Br_pathology_n);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavBr_pathology_br_pathology_n_Internalname, "Values", (String)(cmbavBr_pathology_br_pathology_n.ToJavascriptSource()), true);
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtavBr_pathology_br_pathology_lymphnum_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavBr_pathology_br_pathology_lymphnum_Internalname, "淋巴结数目", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 93,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavBr_pathology_br_pathology_lymphnum_Internalname, StringUtil.LTrim( StringUtil.NToC( AV10BR_Pathology.gxTpr_Br_pathology_lymphnum, 15, 5, ".", "")), ((edtavBr_pathology_br_pathology_lymphnum_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( AV10BR_Pathology.gxTpr_Br_pathology_lymphnum, "ZZZZZZZZZ.ZZZZZ")) : context.localUtil.Format( AV10BR_Pathology.gxTpr_Br_pathology_lymphnum, "ZZZZZZZZZ.ZZZZZ")), TempTags+" onchange=\""+"gx.num.valid_decimal( this, ',','.','5');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,93);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavBr_pathology_br_pathology_lymphnum_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtavBr_pathology_br_pathology_lymphnum_Enabled, 0, "text", "", 15, "chr", 1, "row", 15, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_BR_PathologyInsert.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-md-6 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divUnnamedtablebr_pathology_br_pathology_lymphrate_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-4 MergeLabelCell", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblockbr_pathology_br_pathology_lymphrate_Internalname, "淋巴结转移比例", "", "", lblTextblockbr_pathology_br_pathology_lymphrate_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_BR_PathologyInsert.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-8", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavBr_pathology_br_pathology_lymphrate_Internalname, "淋巴结转移比例", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 102,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavBr_pathology_br_pathology_lymphrate_Internalname, AV10BR_Pathology.gxTpr_Br_pathology_lymphrate, StringUtil.RTrim( context.localUtil.Format( AV10BR_Pathology.gxTpr_Br_pathology_lymphrate, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,102);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavBr_pathology_br_pathology_lymphrate_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtavBr_pathology_br_pathology_lymphrate_Enabled, 0, "text", "", 40, "chr", 1, "row", 40, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_BR_PathologyInsert.htm");
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
            GxWebStd.gx_div_start( context, divUnnamedtablevpathologym_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-4 MergeLabelCell", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblockvpathologym_Internalname, "是否远端转移", "", "", lblTextblockvpathologym_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_BR_PathologyInsert.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-8", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, cmbavVpathologym_Internalname, "v Pathology M", "col-sm-3 AttributeLabel", 0, true);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 111,'',false,'',0)\"";
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, cmbavVpathologym, cmbavVpathologym_Internalname, StringUtil.RTrim( AV16vPathologyM), 1, cmbavVpathologym_Jsonclick, 0, "'"+""+"'"+",false,"+"'"+""+"'", "svchar", "", 1, cmbavVpathologym.Enabled, 0, 0, 0, "em", 0, "", "", "Attribute", "", "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,111);\"", "", true, "HLP_BR_PathologyInsert.htm");
            cmbavVpathologym.CurrentValue = StringUtil.RTrim( AV16vPathologyM);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavVpathologym_Internalname, "Values", (String)(cmbavVpathologym.ToJavascriptSource()), true);
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-md-6 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", edtavVmetaloc_Visible, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtavVmetaloc_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavVmetaloc_Internalname, "远端转移部位", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 115,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavVmetaloc_Internalname, AV17vMetaLoc, StringUtil.RTrim( context.localUtil.Format( AV17vMetaLoc, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,115);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavVmetaloc_Jsonclick, 0, "Attribute", "", "", "", "", edtavVmetaloc_Visible, edtavVmetaloc_Enabled, 0, "text", "", 40, "chr", 1, "row", 40, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_BR_PathologyInsert.htm");
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
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 120,'',false,'',0)\"";
            ClassString = "ButtonMaterial";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtnenter_Internalname, "", "保存", bttBtnenter_Jsonclick, 5, "确认", "", StyleString, ClassString, 1, 1, "standard", "'"+""+"'"+",false,"+"'"+"EENTER."+"'", TempTags, "", context.GetButtonType( ), "HLP_BR_PathologyInsert.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 122,'',false,'',0)\"";
            ClassString = "ButtonMaterialDefault";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtncancel_Internalname, "", "取消", bttBtncancel_Jsonclick, 1, "取消", "", StyleString, ClassString, 1, 1, "standard", "'"+""+"'"+",false,"+"'"+"ECANCEL."+"'", TempTags, "", context.GetButtonType( ), "HLP_BR_PathologyInsert.htm");
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
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 126,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavBr_pathology_br_pathologyid_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV10BR_Pathology.gxTpr_Br_pathologyid), 18, 0, ".", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(AV10BR_Pathology.gxTpr_Br_pathologyid), "ZZZZZZZZZZZZZZZZZZ")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,126);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavBr_pathology_br_pathologyid_Jsonclick, 0, "Attribute", "", "", "", "", edtavBr_pathology_br_pathologyid_Visible, 1, 0, "number", "1", 18, "chr", 1, "row", 18, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_BR_PathologyInsert.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 127,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavBr_pathology_br_encounterid_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV10BR_Pathology.gxTpr_Br_encounterid), 18, 0, ".", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(AV10BR_Pathology.gxTpr_Br_encounterid), "ZZZZZZZZZZZZZZZZZZ")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,127);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavBr_pathology_br_encounterid_Jsonclick, 0, "Attribute", "", "", "", "", edtavBr_pathology_br_encounterid_Visible, 1, 0, "number", "1", 18, "chr", 1, "row", 18, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_BR_PathologyInsert.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 128,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavBr_pathology_br_information_patientno_Internalname, AV10BR_Pathology.gxTpr_Br_information_patientno, StringUtil.RTrim( context.localUtil.Format( AV10BR_Pathology.gxTpr_Br_information_patientno, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,128);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavBr_pathology_br_information_patientno_Jsonclick, 0, "Attribute", "", "", "", "", edtavBr_pathology_br_information_patientno_Visible, 1, 0, "text", "", 80, "chr", 1, "row", 2000, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_BR_PathologyInsert.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
         }
         wbLoad = true;
      }

      protected void START992( )
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
         STRUP990( ) ;
      }

      protected void WS992( )
      {
         START992( ) ;
         EVT992( ) ;
      }

      protected void EVT992( )
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
                              E11992 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "REFRESH") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              /* Execute user event: Refresh */
                              E12992 ();
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
                                    E13992 ();
                                 }
                                 dynload_actions( ) ;
                              }
                           }
                           else if ( StringUtil.StrCmp(sEvt, "LOAD") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              /* Execute user event: Load */
                              E14992 ();
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

      protected void WE992( )
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

      protected void PA992( )
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
               GX_FocusControl = edtavBr_pathology_br_pathologyid_padate_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
            nDonePA = 1;
         }
      }

      protected void dynload_actions( )
      {
         /* End function dynload_actions */
      }

      protected void GXDLVBR_PATHOLOGY_BR_PATHOLOGYID_PAHOSP992( String AV12tCurrentCode )
      {
         if ( ! context.isAjaxRequest( ) )
         {
            context.GX_webresponse.AppendHeader("Cache-Control", "no-store");
         }
         context.GX_webresponse.AddString("[[");
         GXDLVBR_PATHOLOGY_BR_PATHOLOGYID_PAHOSP_data992( AV12tCurrentCode) ;
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

      protected void GXVBR_PATHOLOGY_BR_PATHOLOGYID_PAHOSP_html992( String AV12tCurrentCode )
      {
         String gxdynajaxvalue ;
         GXDLVBR_PATHOLOGY_BR_PATHOLOGYID_PAHOSP_data992( AV12tCurrentCode) ;
         gxdynajaxindex = 1;
         if ( ! ( gxdyncontrolsrefreshing && context.isAjaxRequest( ) ) )
         {
            dynavBr_pathology_br_pathologyid_pahosp.removeAllItems();
         }
         while ( gxdynajaxindex <= gxdynajaxctrlcodr.Count )
         {
            gxdynajaxvalue = ((String)gxdynajaxctrlcodr.Item(gxdynajaxindex));
            dynavBr_pathology_br_pathologyid_pahosp.addItem(gxdynajaxvalue, ((String)gxdynajaxctrldescr.Item(gxdynajaxindex)), 0);
            gxdynajaxindex = (int)(gxdynajaxindex+1);
         }
      }

      protected void GXDLVBR_PATHOLOGY_BR_PATHOLOGYID_PAHOSP_data992( String AV12tCurrentCode )
      {
         gxdynajaxctrlcodr.Clear();
         gxdynajaxctrldescr.Clear();
         gxdynajaxctrlcodr.Add("");
         gxdynajaxctrldescr.Add("(请选择)");
         /* Using cursor H00992 */
         pr_default.execute(0, new Object[] {AV12tCurrentCode});
         while ( (pr_default.getStatus(0) != 101) )
         {
            gxdynajaxctrlcodr.Add(H00992_A168XT_DefineCodeName[0]);
            gxdynajaxctrldescr.Add(H00992_A168XT_DefineCodeName[0]);
            pr_default.readNext(0);
         }
         pr_default.close(0);
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
         if ( dynavBr_pathology_br_pathologyid_pahosp.ItemCount > 0 )
         {
            AV10BR_Pathology.gxTpr_Br_pathologyid_pahosp = dynavBr_pathology_br_pathologyid_pahosp.getValidValue(AV10BR_Pathology.gxTpr_Br_pathologyid_pahosp);
         }
         if ( context.isAjaxRequest( ) )
         {
            dynavBr_pathology_br_pathologyid_pahosp.CurrentValue = StringUtil.RTrim( AV10BR_Pathology.gxTpr_Br_pathologyid_pahosp);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynavBr_pathology_br_pathologyid_pahosp_Internalname, "Values", dynavBr_pathology_br_pathologyid_pahosp.ToJavascriptSource(), true);
         }
         if ( cmbavBr_pathology_br_pathology_n.ItemCount > 0 )
         {
            AV10BR_Pathology.gxTpr_Br_pathology_n = cmbavBr_pathology_br_pathology_n.getValidValue(AV10BR_Pathology.gxTpr_Br_pathology_n);
         }
         if ( context.isAjaxRequest( ) )
         {
            cmbavBr_pathology_br_pathology_n.CurrentValue = StringUtil.RTrim( AV10BR_Pathology.gxTpr_Br_pathology_n);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavBr_pathology_br_pathology_n_Internalname, "Values", cmbavBr_pathology_br_pathology_n.ToJavascriptSource(), true);
         }
         if ( cmbavVpathologym.ItemCount > 0 )
         {
            AV16vPathologyM = cmbavVpathologym.getValidValue(AV16vPathologyM);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV16vPathologyM", AV16vPathologyM);
         }
         if ( context.isAjaxRequest( ) )
         {
            cmbavVpathologym.CurrentValue = StringUtil.RTrim( AV16vPathologyM);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavVpathologym_Internalname, "Values", cmbavVpathologym.ToJavascriptSource(), true);
         }
      }

      public void Refresh( )
      {
         send_integrity_hashes( ) ;
         RF992( ) ;
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

      protected void RF992( )
      {
         initialize_formulas( ) ;
         clear_multi_value_controls( ) ;
         /* Execute user event: Refresh */
         E12992 ();
         gxdyncontrolsrefreshing = true;
         fix_multi_value_controls( ) ;
         gxdyncontrolsrefreshing = false;
         if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
         {
            /* Execute user event: Load */
            E14992 ();
            WB990( ) ;
         }
      }

      protected void send_integrity_lvl_hashes992( )
      {
         GxWebStd.gx_hidden_field( context, "vBR_ENCOUNTERID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV13BR_EncounterID), 18, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "gxhash_vBR_ENCOUNTERID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV13BR_EncounterID), "ZZZZZZZZZZZZZZZZZZ"), context));
      }

      protected void STRUP990( )
      {
         /* Before Start, stand alone formulas. */
         context.Gx_err = 0;
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0;
         /* Execute user event: Start */
         E11992 ();
         context.wbGlbDoneStart = 1;
         /* After Start, stand alone formulas. */
         GXVBR_PATHOLOGY_BR_PATHOLOGYID_PAHOSP_html992( AV12tCurrentCode) ;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read saved SDTs. */
            ajax_req_read_hidden_sdt(cgiGet( "Br_pathology"), AV10BR_Pathology);
            /* Read variables values. */
            if ( context.localUtil.VCDate( cgiGet( edtavBr_pathology_br_pathologyid_padate_Internalname), 0) == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_faildate", new   object[]  {"病理检查日期"}), 1, "BR_PATHOLOGY_BR_PATHOLOGYID_PADATE");
               GX_FocusControl = edtavBr_pathology_br_pathologyid_padate_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV10BR_Pathology.gxTpr_Br_pathologyid_padate = DateTime.MinValue;
            }
            else
            {
               AV10BR_Pathology.gxTpr_Br_pathologyid_padate = context.localUtil.CToD( cgiGet( edtavBr_pathology_br_pathologyid_padate_Internalname), 0);
            }
            if ( ( ( context.localUtil.CToN( cgiGet( edtavBr_pathology_br_pathologyid_paage_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavBr_pathology_br_pathologyid_paage_Internalname), ".", ",") > Convert.ToDecimal( 999 )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "BR_PATHOLOGY_BR_PATHOLOGYID_PAAGE");
               GX_FocusControl = edtavBr_pathology_br_pathologyid_paage_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV10BR_Pathology.gxTpr_Br_pathologyid_paage = 0;
            }
            else
            {
               AV10BR_Pathology.gxTpr_Br_pathologyid_paage = (short)(context.localUtil.CToN( cgiGet( edtavBr_pathology_br_pathologyid_paage_Internalname), ".", ","));
            }
            dynavBr_pathology_br_pathologyid_pahosp.CurrentValue = cgiGet( dynavBr_pathology_br_pathologyid_pahosp_Internalname);
            AV10BR_Pathology.gxTpr_Br_pathologyid_pahosp = cgiGet( dynavBr_pathology_br_pathologyid_pahosp_Internalname);
            AV10BR_Pathology.gxTpr_Br_pathology_dia_name = cgiGet( edtavBr_pathology_br_pathology_dia_name_Internalname);
            AV10BR_Pathology.gxTpr_Br_pathologyid_paresult = cgiGet( edtavBr_pathology_br_pathologyid_paresult_Internalname);
            AV10BR_Pathology.gxTpr_Br_pathologyid_prepadia = cgiGet( edtavBr_pathology_br_pathologyid_prepadia_Internalname);
            if ( ( ( context.localUtil.CToN( cgiGet( edtavBr_pathology_br_pathology_t_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavBr_pathology_br_pathology_t_Internalname), ".", ",") > 999999999.99999m ) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "BR_PATHOLOGY_BR_PATHOLOGY_T");
               GX_FocusControl = edtavBr_pathology_br_pathology_t_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV10BR_Pathology.gxTpr_Br_pathology_t = 0;
            }
            else
            {
               AV10BR_Pathology.gxTpr_Br_pathology_t = context.localUtil.CToN( cgiGet( edtavBr_pathology_br_pathology_t_Internalname), ".", ",");
            }
            cmbavBr_pathology_br_pathology_n.CurrentValue = cgiGet( cmbavBr_pathology_br_pathology_n_Internalname);
            AV10BR_Pathology.gxTpr_Br_pathology_n = cgiGet( cmbavBr_pathology_br_pathology_n_Internalname);
            if ( ( ( context.localUtil.CToN( cgiGet( edtavBr_pathology_br_pathology_lymphnum_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavBr_pathology_br_pathology_lymphnum_Internalname), ".", ",") > 999999999.99999m ) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "BR_PATHOLOGY_BR_PATHOLOGY_LYMPHNUM");
               GX_FocusControl = edtavBr_pathology_br_pathology_lymphnum_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV10BR_Pathology.gxTpr_Br_pathology_lymphnum = 0;
            }
            else
            {
               AV10BR_Pathology.gxTpr_Br_pathology_lymphnum = context.localUtil.CToN( cgiGet( edtavBr_pathology_br_pathology_lymphnum_Internalname), ".", ",");
            }
            AV10BR_Pathology.gxTpr_Br_pathology_lymphrate = cgiGet( edtavBr_pathology_br_pathology_lymphrate_Internalname);
            cmbavVpathologym.CurrentValue = cgiGet( cmbavVpathologym_Internalname);
            AV16vPathologyM = cgiGet( cmbavVpathologym_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV16vPathologyM", AV16vPathologyM);
            AV17vMetaLoc = cgiGet( edtavVmetaloc_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV17vMetaLoc", AV17vMetaLoc);
            if ( ( ( context.localUtil.CToN( cgiGet( edtavBr_pathology_br_pathologyid_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavBr_pathology_br_pathologyid_Internalname), ".", ",") > Convert.ToDecimal( 999999999999999999L )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "BR_PATHOLOGY_BR_PATHOLOGYID");
               GX_FocusControl = edtavBr_pathology_br_pathologyid_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV10BR_Pathology.gxTpr_Br_pathologyid = 0;
            }
            else
            {
               AV10BR_Pathology.gxTpr_Br_pathologyid = (long)(context.localUtil.CToN( cgiGet( edtavBr_pathology_br_pathologyid_Internalname), ".", ","));
            }
            if ( ( ( context.localUtil.CToN( cgiGet( edtavBr_pathology_br_encounterid_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavBr_pathology_br_encounterid_Internalname), ".", ",") > Convert.ToDecimal( 999999999999999999L )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "BR_PATHOLOGY_BR_ENCOUNTERID");
               GX_FocusControl = edtavBr_pathology_br_encounterid_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV10BR_Pathology.gxTpr_Br_encounterid = 0;
            }
            else
            {
               AV10BR_Pathology.gxTpr_Br_encounterid = (long)(context.localUtil.CToN( cgiGet( edtavBr_pathology_br_encounterid_Internalname), ".", ","));
            }
            AV10BR_Pathology.gxTpr_Br_information_patientno = cgiGet( edtavBr_pathology_br_information_patientno_Internalname);
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
            GXVBR_PATHOLOGY_BR_PATHOLOGYID_PAHOSP_html992( AV12tCurrentCode) ;
         }
         else
         {
            dynload_actions( ) ;
         }
      }

      protected void GXStart( )
      {
         /* Execute user event: Start */
         E11992 ();
         if (returnInSub) return;
      }

      protected void E11992( )
      {
         /* Start Routine */
         GXt_char1 = AV12tCurrentCode;
         new zbr_getcurrenttcode(context ).execute( out  GXt_char1) ;
         AV12tCurrentCode = GXt_char1;
         edtavBr_pathology_br_pathologyid_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavBr_pathology_br_pathologyid_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavBr_pathology_br_pathologyid_Visible), 5, 0)), true);
         edtavBr_pathology_br_encounterid_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavBr_pathology_br_encounterid_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavBr_pathology_br_encounterid_Visible), 5, 0)), true);
         edtavBr_pathology_br_information_patientno_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavBr_pathology_br_information_patientno_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavBr_pathology_br_information_patientno_Visible), 5, 0)), true);
         edtavVmetaloc_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavVmetaloc_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavVmetaloc_Visible), 5, 0)), true);
      }

      protected void S112( )
      {
         /* 'CHECKREQUIREDFIELDS' Routine */
         AV11CheckRequiredFieldsResult = true;
         if ( (DateTime.MinValue==AV10BR_Pathology.gxTpr_Br_pathologyid_padate) )
         {
            GX_msglist.addItem("");
            AV11CheckRequiredFieldsResult = false;
         }
         if ( (0==AV10BR_Pathology.gxTpr_Br_pathologyid_paage) )
         {
            GX_msglist.addItem("");
            AV11CheckRequiredFieldsResult = false;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV10BR_Pathology.gxTpr_Br_pathology_dia_name)) )
         {
            GX_msglist.addItem("");
            AV11CheckRequiredFieldsResult = false;
         }
      }

      protected void S122( )
      {
         /* 'SHOW MESSAGES' Routine */
         AV35GXV14 = 1;
         while ( AV35GXV14 <= AV8Messages.Count )
         {
            AV7Message = ((SdtMessages_Message)AV8Messages.Item(AV35GXV14));
            GX_msglist.addItem(AV7Message.gxTpr_Description);
            AV35GXV14 = (int)(AV35GXV14+1);
         }
      }

      protected void E12992( )
      {
         /* Refresh Routine */
         new GeneXus.Programs.wwpbaseobjects.loadwwpcontext(context ).execute( out  AV9Context) ;
      }

      public void GXEnter( )
      {
         /* Execute user event: Enter */
         E13992 ();
         if (returnInSub) return;
      }

      protected void E13992( )
      {
         /* Enter Routine */
         new zutil_checksession(context ).execute( out  AV19tCheckFlag) ;
         if ( ! AV19tCheckFlag )
         {
            AV14tFlag = true;
            if ( ( AV14tFlag ) && String.IsNullOrEmpty(StringUtil.RTrim( AV10BR_Pathology.gxTpr_Br_pathology_dia_name)) )
            {
               GX_msglist.addItem("病理诊断名称是必填的");
               AV14tFlag = false;
            }
            if ( ( AV14tFlag ) && (0==AV10BR_Pathology.gxTpr_Br_pathologyid_paage) )
            {
               GX_msglist.addItem("年龄是必填的");
               AV14tFlag = false;
            }
            if ( ( AV14tFlag ) && (DateTime.MinValue==AV10BR_Pathology.gxTpr_Br_pathologyid_padate) )
            {
               GX_msglist.addItem("病理检查日期是必填的");
               AV14tFlag = false;
            }
            AV10BR_Pathology.gxTpr_Br_encounterid = AV13BR_EncounterID;
            AV10BR_Pathology.gxTpr_Br_pathology_m = AV16vPathologyM;
            AV10BR_Pathology.gxTpr_Br_pathology_metaloc = AV17vMetaLoc;
            if ( (DateTime.MinValue==AV10BR_Pathology.gxTpr_Br_pathologyid_padate) )
            {
               AV10BR_Pathology.gxTv_SdtBR_Pathology_Br_pathologyid_padate_SetNull();
            }
            if ( StringUtil.StrCmp(AV10BR_Pathology.gxTpr_Br_pathology_m, "否") == 0 )
            {
               AV10BR_Pathology.gxTv_SdtBR_Pathology_Br_pathology_metaloc_SetNull();
            }
            if ( StringUtil.StrCmp(AV10BR_Pathology.gxTpr_Br_pathology_m, "不详") == 0 )
            {
               AV10BR_Pathology.gxTv_SdtBR_Pathology_Br_pathology_metaloc_SetNull();
            }
            AV10BR_Pathology.Save();
            if ( AV10BR_Pathology.Success() )
            {
               GXt_char1 = "";
               new zutil_findtargetcode(context ).execute(  37,  AV10BR_Pathology.gxTpr_Br_pathology_n, out  GXt_char1) ;
               AV10BR_Pathology.gxTpr_Br_pathology_n_code = GXt_char1;
               GXt_char1 = "";
               new zutil_findtargetcode(context ).execute(  37,  AV10BR_Pathology.gxTpr_Br_pathology_m, out  GXt_char1) ;
               AV10BR_Pathology.gxTpr_Br_pathology_m_code = GXt_char1;
               GXt_char1 = "";
               new zutil_findtargetcode(context ).execute(  32,  AV10BR_Pathology.gxTpr_Br_pathologyid_pahosp, out  GXt_char1) ;
               AV10BR_Pathology.gxTpr_Br_pathologyid_pahosp_code = GXt_char1;
               context.CommitDataStores("br_pathologyinsert",pr_default);
               CallWebObject(formatLink("br_pathologyview.aspx") + "?" + UrlEncode("" +AV10BR_Pathology.gxTpr_Br_pathologyid) + "," + UrlEncode(StringUtil.RTrim("General")));
               context.wjLocDisableFrm = 1;
            }
            else
            {
               AV15ErrorMsg = "";
               AV37GXV16 = 1;
               AV36GXV15 = AV10BR_Pathology.GetMessages();
               while ( AV37GXV16 <= AV36GXV15.Count )
               {
                  AV7Message = ((SdtMessages_Message)AV36GXV15.Item(AV37GXV16));
                  AV15ErrorMsg = AV15ErrorMsg + StringUtil.Trim( AV7Message.gxTpr_Description);
                  AV37GXV16 = (int)(AV37GXV16+1);
               }
            }
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV10BR_Pathology", AV10BR_Pathology);
      }

      protected void nextLoad( )
      {
      }

      protected void E14992( )
      {
         /* Load Routine */
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV10BR_Pathology.gxTpr_Br_pathology_m)) )
         {
            cmbavVpathologym.addItem(AV10BR_Pathology.gxTpr_Br_pathology_m, AV10BR_Pathology.gxTpr_Br_pathology_m, 0);
            AV16vPathologyM = AV10BR_Pathology.gxTpr_Br_pathology_m;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV16vPathologyM", AV16vPathologyM);
         }
      }

      public override void setparameters( Object[] obj )
      {
         createObjects();
         initialize();
         AV13BR_EncounterID = Convert.ToInt64(getParm(obj,0));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13BR_EncounterID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13BR_EncounterID), 18, 0)));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vBR_ENCOUNTERID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV13BR_EncounterID), "ZZZZZZZZZZZZZZZZZZ"), context));
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
         PA992( ) ;
         WS992( ) ;
         WE992( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?2020227127983", true);
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
         context.AddJavascriptSource("br_pathologyinsert.js", "?2020227127983", false);
         context.AddJavascriptSource("DVelop/Bootstrap/Shared/DVelopBootstrap.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/Panel/BootstrapPanelRender.js", "", false);
         /* End function include_jscripts */
      }

      protected void init_web_controls( )
      {
         dynavBr_pathology_br_pathologyid_pahosp.Name = "BR_PATHOLOGY_BR_PATHOLOGYID_PAHOSP";
         dynavBr_pathology_br_pathologyid_pahosp.WebTags = "";
         cmbavBr_pathology_br_pathology_n.Name = "BR_PATHOLOGY_BR_PATHOLOGY_N";
         cmbavBr_pathology_br_pathology_n.WebTags = "";
         cmbavBr_pathology_br_pathology_n.addItem("", "(请选择)", 0);
         cmbavBr_pathology_br_pathology_n.addItem("否", "否", 0);
         cmbavBr_pathology_br_pathology_n.addItem("是", "是", 0);
         cmbavBr_pathology_br_pathology_n.addItem("不详", "不详", 0);
         if ( cmbavBr_pathology_br_pathology_n.ItemCount > 0 )
         {
            AV10BR_Pathology.gxTpr_Br_pathology_n = cmbavBr_pathology_br_pathology_n.getValidValue(AV10BR_Pathology.gxTpr_Br_pathology_n);
         }
         cmbavVpathologym.Name = "vVPATHOLOGYM";
         cmbavVpathologym.WebTags = "";
         cmbavVpathologym.addItem("", "(请选择)", 0);
         cmbavVpathologym.addItem("否", "否", 0);
         cmbavVpathologym.addItem("是", "是", 0);
         cmbavVpathologym.addItem("不详", "不详", 0);
         if ( cmbavVpathologym.ItemCount > 0 )
         {
            AV16vPathologyM = cmbavVpathologym.getValidValue(AV16vPathologyM);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV16vPathologyM", AV16vPathologyM);
         }
         /* End function init_web_controls */
      }

      protected void init_default_properties( )
      {
         lblTextblockbr_pathology_br_pathologyid_padate_Internalname = "TEXTBLOCKBR_PATHOLOGY_BR_PATHOLOGYID_PADATE";
         edtavBr_pathology_br_pathologyid_padate_Internalname = "BR_PATHOLOGY_BR_PATHOLOGYID_PADATE";
         divUnnamedtablebr_pathology_br_pathologyid_padate_Internalname = "UNNAMEDTABLEBR_PATHOLOGY_BR_PATHOLOGYID_PADATE";
         lblTextblockbr_pathology_br_pathologyid_paage_Internalname = "TEXTBLOCKBR_PATHOLOGY_BR_PATHOLOGYID_PAAGE";
         edtavBr_pathology_br_pathologyid_paage_Internalname = "BR_PATHOLOGY_BR_PATHOLOGYID_PAAGE";
         divUnnamedtablebr_pathology_br_pathologyid_paage_Internalname = "UNNAMEDTABLEBR_PATHOLOGY_BR_PATHOLOGYID_PAAGE";
         lblTextblockbr_pathology_br_pathologyid_pahosp_Internalname = "TEXTBLOCKBR_PATHOLOGY_BR_PATHOLOGYID_PAHOSP";
         dynavBr_pathology_br_pathologyid_pahosp_Internalname = "BR_PATHOLOGY_BR_PATHOLOGYID_PAHOSP";
         divUnnamedtablebr_pathology_br_pathologyid_pahosp_Internalname = "UNNAMEDTABLEBR_PATHOLOGY_BR_PATHOLOGYID_PAHOSP";
         lblTextblockbr_pathology_br_pathology_dia_name_Internalname = "TEXTBLOCKBR_PATHOLOGY_BR_PATHOLOGY_DIA_NAME";
         edtavBr_pathology_br_pathology_dia_name_Internalname = "BR_PATHOLOGY_BR_PATHOLOGY_DIA_NAME";
         divUnnamedtablebr_pathology_br_pathology_dia_name_Internalname = "UNNAMEDTABLEBR_PATHOLOGY_BR_PATHOLOGY_DIA_NAME";
         lblTextblockbr_pathology_br_pathologyid_paresult_Internalname = "TEXTBLOCKBR_PATHOLOGY_BR_PATHOLOGYID_PARESULT";
         edtavBr_pathology_br_pathologyid_paresult_Internalname = "BR_PATHOLOGY_BR_PATHOLOGYID_PARESULT";
         divUnnamedtablebr_pathology_br_pathologyid_paresult_Internalname = "UNNAMEDTABLEBR_PATHOLOGY_BR_PATHOLOGYID_PARESULT";
         lblTextblockbr_pathology_br_pathologyid_prepadia_Internalname = "TEXTBLOCKBR_PATHOLOGY_BR_PATHOLOGYID_PREPADIA";
         edtavBr_pathology_br_pathologyid_prepadia_Internalname = "BR_PATHOLOGY_BR_PATHOLOGYID_PREPADIA";
         divUnnamedtablebr_pathology_br_pathologyid_prepadia_Internalname = "UNNAMEDTABLEBR_PATHOLOGY_BR_PATHOLOGYID_PREPADIA";
         lblTextblockbr_pathology_br_pathology_t_Internalname = "TEXTBLOCKBR_PATHOLOGY_BR_PATHOLOGY_T";
         edtavBr_pathology_br_pathology_t_Internalname = "BR_PATHOLOGY_BR_PATHOLOGY_T";
         divUnnamedtablebr_pathology_br_pathology_t_Internalname = "UNNAMEDTABLEBR_PATHOLOGY_BR_PATHOLOGY_T";
         lblTextblockbr_pathology_br_pathology_n_Internalname = "TEXTBLOCKBR_PATHOLOGY_BR_PATHOLOGY_N";
         cmbavBr_pathology_br_pathology_n_Internalname = "BR_PATHOLOGY_BR_PATHOLOGY_N";
         divUnnamedtablebr_pathology_br_pathology_n_Internalname = "UNNAMEDTABLEBR_PATHOLOGY_BR_PATHOLOGY_N";
         edtavBr_pathology_br_pathology_lymphnum_Internalname = "BR_PATHOLOGY_BR_PATHOLOGY_LYMPHNUM";
         lblTextblockbr_pathology_br_pathology_lymphrate_Internalname = "TEXTBLOCKBR_PATHOLOGY_BR_PATHOLOGY_LYMPHRATE";
         edtavBr_pathology_br_pathology_lymphrate_Internalname = "BR_PATHOLOGY_BR_PATHOLOGY_LYMPHRATE";
         divUnnamedtablebr_pathology_br_pathology_lymphrate_Internalname = "UNNAMEDTABLEBR_PATHOLOGY_BR_PATHOLOGY_LYMPHRATE";
         lblTextblockvpathologym_Internalname = "TEXTBLOCKVPATHOLOGYM";
         cmbavVpathologym_Internalname = "vVPATHOLOGYM";
         divUnnamedtablevpathologym_Internalname = "UNNAMEDTABLEVPATHOLOGYM";
         edtavVmetaloc_Internalname = "vVMETALOC";
         divTableattributes_Internalname = "TABLEATTRIBUTES";
         divLayout_tableattributes_Internalname = "LAYOUT_TABLEATTRIBUTES";
         Dvpanel_tableattributes_Internalname = "DVPANEL_TABLEATTRIBUTES";
         divHtml_dvpanel_tableattributes_Internalname = "HTML_DVPANEL_TABLEATTRIBUTES";
         divTablecontent_Internalname = "TABLECONTENT";
         bttBtnenter_Internalname = "BTNENTER";
         bttBtncancel_Internalname = "BTNCANCEL";
         divTablemain_Internalname = "TABLEMAIN";
         edtavBr_pathology_br_pathologyid_Internalname = "BR_PATHOLOGY_BR_PATHOLOGYID";
         edtavBr_pathology_br_encounterid_Internalname = "BR_PATHOLOGY_BR_ENCOUNTERID";
         edtavBr_pathology_br_information_patientno_Internalname = "BR_PATHOLOGY_BR_INFORMATION_PATIENTNO";
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
         edtavBr_pathology_br_information_patientno_Jsonclick = "";
         edtavBr_pathology_br_information_patientno_Visible = 1;
         edtavBr_pathology_br_encounterid_Jsonclick = "";
         edtavBr_pathology_br_encounterid_Visible = 1;
         edtavBr_pathology_br_pathologyid_Jsonclick = "";
         edtavBr_pathology_br_pathologyid_Visible = 1;
         edtavVmetaloc_Jsonclick = "";
         edtavVmetaloc_Enabled = 1;
         edtavVmetaloc_Visible = 1;
         cmbavVpathologym_Jsonclick = "";
         cmbavVpathologym.Enabled = 1;
         edtavBr_pathology_br_pathology_lymphrate_Jsonclick = "";
         edtavBr_pathology_br_pathology_lymphrate_Enabled = 1;
         edtavBr_pathology_br_pathology_lymphnum_Jsonclick = "";
         edtavBr_pathology_br_pathology_lymphnum_Enabled = 1;
         cmbavBr_pathology_br_pathology_n_Jsonclick = "";
         cmbavBr_pathology_br_pathology_n.Enabled = 1;
         edtavBr_pathology_br_pathology_t_Jsonclick = "";
         edtavBr_pathology_br_pathology_t_Enabled = 1;
         edtavBr_pathology_br_pathologyid_prepadia_Enabled = 1;
         edtavBr_pathology_br_pathologyid_paresult_Enabled = 1;
         edtavBr_pathology_br_pathology_dia_name_Enabled = 1;
         dynavBr_pathology_br_pathologyid_pahosp_Jsonclick = "";
         dynavBr_pathology_br_pathologyid_pahosp.Enabled = 1;
         edtavBr_pathology_br_pathologyid_paage_Jsonclick = "";
         edtavBr_pathology_br_pathologyid_paage_Enabled = 1;
         edtavBr_pathology_br_pathologyid_padate_Jsonclick = "";
         edtavBr_pathology_br_pathologyid_padate_Enabled = 1;
         Dvpanel_tableattributes_Autoscroll = Convert.ToBoolean( 0);
         Dvpanel_tableattributes_Iconposition = "left";
         Dvpanel_tableattributes_Showcollapseicon = Convert.ToBoolean( 0);
         Dvpanel_tableattributes_Autoheight = Convert.ToBoolean( -1);
         Dvpanel_tableattributes_Autowidth = Convert.ToBoolean( 0);
         Dvpanel_tableattributes_Collapsed = Convert.ToBoolean( 0);
         Dvpanel_tableattributes_Collapsible = Convert.ToBoolean( 0);
         Dvpanel_tableattributes_Title = "病理学信息";
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
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[{av:'AV13BR_EncounterID',fld:'vBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true}]");
         setEventMetadata("REFRESH",",oparms:[]}");
         setEventMetadata("ENTER","{handler:'E13992',iparms:[{av:'AV10BR_Pathology',fld:'vBR_PATHOLOGY',pic:''},{av:'AV13BR_EncounterID',fld:'vBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true},{av:'cmbavVpathologym'},{av:'AV16vPathologyM',fld:'vVPATHOLOGYM',pic:''},{av:'AV17vMetaLoc',fld:'vVMETALOC',pic:''}]");
         setEventMetadata("ENTER",",oparms:[{av:'AV10BR_Pathology',fld:'vBR_PATHOLOGY',pic:''}]}");
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
         AV12tCurrentCode = "";
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         GXKey = "";
         AV10BR_Pathology = new SdtBR_Pathology(context);
         GX_FocusControl = "";
         Form = new GXWebForm();
         sPrefix = "";
         ClassString = "";
         StyleString = "";
         ucDvpanel_tableattributes = new GXUserControl();
         lblTextblockbr_pathology_br_pathologyid_padate_Jsonclick = "";
         TempTags = "";
         lblTextblockbr_pathology_br_pathologyid_paage_Jsonclick = "";
         lblTextblockbr_pathology_br_pathologyid_pahosp_Jsonclick = "";
         lblTextblockbr_pathology_br_pathology_dia_name_Jsonclick = "";
         lblTextblockbr_pathology_br_pathologyid_paresult_Jsonclick = "";
         lblTextblockbr_pathology_br_pathologyid_prepadia_Jsonclick = "";
         lblTextblockbr_pathology_br_pathology_t_Jsonclick = "";
         lblTextblockbr_pathology_br_pathology_n_Jsonclick = "";
         lblTextblockbr_pathology_br_pathology_lymphrate_Jsonclick = "";
         lblTextblockvpathologym_Jsonclick = "";
         AV16vPathologyM = "";
         AV17vMetaLoc = "";
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
         H00992_A167XT_DefineCodeID = new long[1] ;
         H00992_A168XT_DefineCodeName = new String[] {""} ;
         H00992_n168XT_DefineCodeName = new bool[] {false} ;
         H00992_A165XT_DefindcodeTypeID = new long[1] ;
         H00992_A432XT_TenantCode = new String[] {""} ;
         H00992_n432XT_TenantCode = new bool[] {false} ;
         AV8Messages = new GXBaseCollection<SdtMessages_Message>( context, "Message", "GeneXus");
         AV7Message = new SdtMessages_Message(context);
         AV9Context = new GeneXus.Programs.wwpbaseobjects.SdtWWPContext(context);
         GXt_char1 = "";
         AV15ErrorMsg = "";
         AV36GXV15 = new GXBaseCollection<SdtMessages_Message>( context, "Message", "GeneXus");
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         pr_datastore1 = new DataStoreProvider(context, new GeneXus.Programs.br_pathologyinsert__datastore1(),
            new Object[][] {
            }
         );
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.br_pathologyinsert__default(),
            new Object[][] {
                new Object[] {
               H00992_A167XT_DefineCodeID, H00992_A168XT_DefineCodeName, H00992_n168XT_DefineCodeName, H00992_A165XT_DefindcodeTypeID, H00992_A432XT_TenantCode, H00992_n432XT_TenantCode
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
      private int edtavBr_pathology_br_pathologyid_padate_Enabled ;
      private int edtavBr_pathology_br_pathologyid_paage_Enabled ;
      private int edtavBr_pathology_br_pathology_dia_name_Enabled ;
      private int edtavBr_pathology_br_pathologyid_paresult_Enabled ;
      private int edtavBr_pathology_br_pathologyid_prepadia_Enabled ;
      private int edtavBr_pathology_br_pathology_t_Enabled ;
      private int edtavBr_pathology_br_pathology_lymphnum_Enabled ;
      private int edtavBr_pathology_br_pathology_lymphrate_Enabled ;
      private int edtavVmetaloc_Visible ;
      private int edtavVmetaloc_Enabled ;
      private int edtavBr_pathology_br_pathologyid_Visible ;
      private int edtavBr_pathology_br_encounterid_Visible ;
      private int edtavBr_pathology_br_information_patientno_Visible ;
      private int gxdynajaxindex ;
      private int AV35GXV14 ;
      private int AV37GXV16 ;
      private int idxLst ;
      private long AV13BR_EncounterID ;
      private long wcpOAV13BR_EncounterID ;
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
      private String divUnnamedtablebr_pathology_br_pathologyid_padate_Internalname ;
      private String lblTextblockbr_pathology_br_pathologyid_padate_Internalname ;
      private String lblTextblockbr_pathology_br_pathologyid_padate_Jsonclick ;
      private String edtavBr_pathology_br_pathologyid_padate_Internalname ;
      private String TempTags ;
      private String edtavBr_pathology_br_pathologyid_padate_Jsonclick ;
      private String divUnnamedtablebr_pathology_br_pathologyid_paage_Internalname ;
      private String lblTextblockbr_pathology_br_pathologyid_paage_Internalname ;
      private String lblTextblockbr_pathology_br_pathologyid_paage_Jsonclick ;
      private String edtavBr_pathology_br_pathologyid_paage_Internalname ;
      private String edtavBr_pathology_br_pathologyid_paage_Jsonclick ;
      private String divUnnamedtablebr_pathology_br_pathologyid_pahosp_Internalname ;
      private String lblTextblockbr_pathology_br_pathologyid_pahosp_Internalname ;
      private String lblTextblockbr_pathology_br_pathologyid_pahosp_Jsonclick ;
      private String dynavBr_pathology_br_pathologyid_pahosp_Internalname ;
      private String dynavBr_pathology_br_pathologyid_pahosp_Jsonclick ;
      private String divUnnamedtablebr_pathology_br_pathology_dia_name_Internalname ;
      private String lblTextblockbr_pathology_br_pathology_dia_name_Internalname ;
      private String lblTextblockbr_pathology_br_pathology_dia_name_Jsonclick ;
      private String edtavBr_pathology_br_pathology_dia_name_Internalname ;
      private String divUnnamedtablebr_pathology_br_pathologyid_paresult_Internalname ;
      private String lblTextblockbr_pathology_br_pathologyid_paresult_Internalname ;
      private String lblTextblockbr_pathology_br_pathologyid_paresult_Jsonclick ;
      private String edtavBr_pathology_br_pathologyid_paresult_Internalname ;
      private String divUnnamedtablebr_pathology_br_pathologyid_prepadia_Internalname ;
      private String lblTextblockbr_pathology_br_pathologyid_prepadia_Internalname ;
      private String lblTextblockbr_pathology_br_pathologyid_prepadia_Jsonclick ;
      private String edtavBr_pathology_br_pathologyid_prepadia_Internalname ;
      private String divUnnamedtablebr_pathology_br_pathology_t_Internalname ;
      private String lblTextblockbr_pathology_br_pathology_t_Internalname ;
      private String lblTextblockbr_pathology_br_pathology_t_Jsonclick ;
      private String edtavBr_pathology_br_pathology_t_Internalname ;
      private String edtavBr_pathology_br_pathology_t_Jsonclick ;
      private String divUnnamedtablebr_pathology_br_pathology_n_Internalname ;
      private String lblTextblockbr_pathology_br_pathology_n_Internalname ;
      private String lblTextblockbr_pathology_br_pathology_n_Jsonclick ;
      private String cmbavBr_pathology_br_pathology_n_Internalname ;
      private String cmbavBr_pathology_br_pathology_n_Jsonclick ;
      private String edtavBr_pathology_br_pathology_lymphnum_Internalname ;
      private String edtavBr_pathology_br_pathology_lymphnum_Jsonclick ;
      private String divUnnamedtablebr_pathology_br_pathology_lymphrate_Internalname ;
      private String lblTextblockbr_pathology_br_pathology_lymphrate_Internalname ;
      private String lblTextblockbr_pathology_br_pathology_lymphrate_Jsonclick ;
      private String edtavBr_pathology_br_pathology_lymphrate_Internalname ;
      private String edtavBr_pathology_br_pathology_lymphrate_Jsonclick ;
      private String divUnnamedtablevpathologym_Internalname ;
      private String lblTextblockvpathologym_Internalname ;
      private String lblTextblockvpathologym_Jsonclick ;
      private String cmbavVpathologym_Internalname ;
      private String cmbavVpathologym_Jsonclick ;
      private String edtavVmetaloc_Internalname ;
      private String edtavVmetaloc_Jsonclick ;
      private String bttBtnenter_Internalname ;
      private String bttBtnenter_Jsonclick ;
      private String bttBtncancel_Internalname ;
      private String bttBtncancel_Jsonclick ;
      private String divHtml_bottomauxiliarcontrols_Internalname ;
      private String edtavBr_pathology_br_pathologyid_Internalname ;
      private String edtavBr_pathology_br_pathologyid_Jsonclick ;
      private String edtavBr_pathology_br_encounterid_Internalname ;
      private String edtavBr_pathology_br_encounterid_Jsonclick ;
      private String edtavBr_pathology_br_information_patientno_Internalname ;
      private String edtavBr_pathology_br_information_patientno_Jsonclick ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String gxwrpcisep ;
      private String scmdbuf ;
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
      private bool AV11CheckRequiredFieldsResult ;
      private bool AV19tCheckFlag ;
      private bool AV14tFlag ;
      private String AV12tCurrentCode ;
      private String AV16vPathologyM ;
      private String AV17vMetaLoc ;
      private String AV15ErrorMsg ;
      private GeneXus.Utils.GxStringCollection gxdynajaxctrlcodr ;
      private GeneXus.Utils.GxStringCollection gxdynajaxctrldescr ;
      private GXUserControl ucDvpanel_tableattributes ;
      private IGxDataStore dsDataStore1 ;
      private IGxDataStore dsDefault ;
      private GXCombobox dynavBr_pathology_br_pathologyid_pahosp ;
      private GXCombobox cmbavBr_pathology_br_pathology_n ;
      private GXCombobox cmbavVpathologym ;
      private IDataStoreProvider pr_default ;
      private long[] H00992_A167XT_DefineCodeID ;
      private String[] H00992_A168XT_DefineCodeName ;
      private bool[] H00992_n168XT_DefineCodeName ;
      private long[] H00992_A165XT_DefindcodeTypeID ;
      private String[] H00992_A432XT_TenantCode ;
      private bool[] H00992_n432XT_TenantCode ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private IDataStoreProvider pr_datastore1 ;
      private GXBaseCollection<SdtMessages_Message> AV8Messages ;
      private GXBaseCollection<SdtMessages_Message> AV36GXV15 ;
      private GXWebForm Form ;
      private SdtMessages_Message AV7Message ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPContext AV9Context ;
      private SdtBR_Pathology AV10BR_Pathology ;
   }

   public class br_pathologyinsert__datastore1 : DataStoreHelperBase, IDataStoreHelper
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

 public class br_pathologyinsert__default : DataStoreHelperBase, IDataStoreHelper
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
        Object[] prmH00992 ;
        prmH00992 = new Object[] {
        new Object[] {"@AV12tCurrentCode",SqlDbType.NVarChar,40,0}
        } ;
        def= new CursorDef[] {
            new CursorDef("H00992", "SELECT [XT_DefineCodeID], [XT_DefineCodeName], [XT_DefindcodeTypeID], [XT_TenantCode] FROM [XT_DefineCode] WITH (NOLOCK) WHERE ([XT_DefindcodeTypeID] = 32) AND ([XT_TenantCode] = @AV12tCurrentCode) ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH00992,0,0,true,false )
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
     }
  }

}

}
