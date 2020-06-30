/*
               File: BR_VitalDelete
        Description:
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/27/2020 12:7:10.30
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
   public class br_vitaldelete : GXDataArea, System.Web.SessionState.IRequiresSessionState
   {
      public br_vitaldelete( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public br_vitaldelete( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( long aP0_iBR_VitalID )
      {
         this.AV5iBR_VitalID = aP0_iBR_VitalID;
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
               AV5iBR_VitalID = (long)(NumberUtil.Val( gxfirstwebparm, "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV5iBR_VitalID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV5iBR_VitalID), 18, 0)));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vIBR_VITALID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV5iBR_VitalID), "ZZZZZZZZZZZZZZZZZZ"), context));
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
         PA9D2( ) ;
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0));
         if ( ( gxajaxcallmode == 0 ) && ( GxWebError == 0 ) )
         {
            START9D2( ) ;
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
         context.AddJavascriptSource("gxcfg.js", "?20202271271034", false);
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" autocomplete=\"off\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("br_vitaldelete.aspx") + "?" + UrlEncode("" +AV5iBR_VitalID)+"\">") ;
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
         forbiddenHiddens = "hsh" + "BR_VitalDelete";
         forbiddenHiddens = forbiddenHiddens + context.localUtil.Format(AV6BR_Vital.gxTpr_Br_vital_measuredate, "9999/99/99");
         forbiddenHiddens = forbiddenHiddens + context.localUtil.Format( AV6BR_Vital.gxTpr_Br_vital_temperature, "ZZZZZZZZZ.ZZZZZ");
         forbiddenHiddens = forbiddenHiddens + context.localUtil.Format( AV6BR_Vital.gxTpr_Br_vital_pulse, "ZZZZZZZZZ.ZZZZZ");
         forbiddenHiddens = forbiddenHiddens + context.localUtil.Format( AV6BR_Vital.gxTpr_Br_vital_respiration, "ZZZZZZZZZ.ZZZZZ");
         forbiddenHiddens = forbiddenHiddens + context.localUtil.Format( AV6BR_Vital.gxTpr_Br_vital_systolic, "ZZZZZZZZZ.ZZZZZ");
         forbiddenHiddens = forbiddenHiddens + context.localUtil.Format( AV6BR_Vital.gxTpr_Br_vital_diastolic, "ZZZZZZZZZ.ZZZZZ");
         forbiddenHiddens = forbiddenHiddens + context.localUtil.Format( AV6BR_Vital.gxTpr_Br_vital_height, "ZZZZZZZZZ.ZZZZZ");
         forbiddenHiddens = forbiddenHiddens + context.localUtil.Format( AV6BR_Vital.gxTpr_Br_vital_weight, "ZZZZZZZZZ.ZZZZZ");
         GxWebStd.gx_hidden_field( context, "hsh", GetEncryptedHash( forbiddenHiddens, GXKey));
         GXUtil.WriteLog("br_vitaldelete:[SendSecurityCheck value for]"+"GXV1:"+context.localUtil.Format(AV6BR_Vital.gxTpr_Br_vital_measuredate, "9999/99/99"));
         GXUtil.WriteLog("br_vitaldelete:[SendSecurityCheck value for]"+"GXV2:"+context.localUtil.Format( AV6BR_Vital.gxTpr_Br_vital_temperature, "ZZZZZZZZZ.ZZZZZ"));
         GXUtil.WriteLog("br_vitaldelete:[SendSecurityCheck value for]"+"GXV3:"+context.localUtil.Format( AV6BR_Vital.gxTpr_Br_vital_pulse, "ZZZZZZZZZ.ZZZZZ"));
         GXUtil.WriteLog("br_vitaldelete:[SendSecurityCheck value for]"+"GXV4:"+context.localUtil.Format( AV6BR_Vital.gxTpr_Br_vital_respiration, "ZZZZZZZZZ.ZZZZZ"));
         GXUtil.WriteLog("br_vitaldelete:[SendSecurityCheck value for]"+"GXV5:"+context.localUtil.Format( AV6BR_Vital.gxTpr_Br_vital_systolic, "ZZZZZZZZZ.ZZZZZ"));
         GXUtil.WriteLog("br_vitaldelete:[SendSecurityCheck value for]"+"GXV6:"+context.localUtil.Format( AV6BR_Vital.gxTpr_Br_vital_diastolic, "ZZZZZZZZZ.ZZZZZ"));
         GXUtil.WriteLog("br_vitaldelete:[SendSecurityCheck value for]"+"GXV7:"+context.localUtil.Format( AV6BR_Vital.gxTpr_Br_vital_height, "ZZZZZZZZZ.ZZZZZ"));
         GXUtil.WriteLog("br_vitaldelete:[SendSecurityCheck value for]"+"GXV8:"+context.localUtil.Format( AV6BR_Vital.gxTpr_Br_vital_weight, "ZZZZZZZZZ.ZZZZZ"));
      }

      protected void SendCloseFormHiddens( )
      {
         /* Send hidden variables. */
         /* Send saved values. */
         send_integrity_footer_hashes( ) ;
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "Br_vital", AV6BR_Vital);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("Br_vital", AV6BR_Vital);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vBR_VITAL", AV6BR_Vital);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vBR_VITAL", AV6BR_Vital);
         }
         GxWebStd.gx_hidden_field( context, "vIBR_VITALID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV5iBR_VitalID), 18, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "gxhash_vIBR_VITALID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV5iBR_VitalID), "ZZZZZZZZZZZZZZZZZZ"), context));
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
            WE9D2( ) ;
            context.WriteHtmlText( "</div>") ;
         }
      }

      public override void DispatchEvents( )
      {
         EVT9D2( ) ;
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
         return formatLink("br_vitaldelete.aspx") + "?" + UrlEncode("" +AV5iBR_VitalID) ;
      }

      public override String GetPgmname( )
      {
         return "BR_VitalDelete" ;
      }

      public override String GetPgmdesc( )
      {
         return "" ;
      }

      protected void WB9D0( )
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
            GxWebStd.gx_div_start( context, divUnnamedtablebr_vital_br_vital_measuredate_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-4 MergeLabelCell", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblockbr_vital_br_vital_measuredate_Internalname, "测量日期", "", "", lblTextblockbr_vital_br_vital_measuredate_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_BR_VitalDelete.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-8", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavBr_vital_br_vital_measuredate_Internalname, "测量日期", "col-sm-3 ReadonlyAttributeLabel", 0, true);
            /* Single line edit */
            context.WriteHtmlText( "<div id=\""+edtavBr_vital_br_vital_measuredate_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtavBr_vital_br_vital_measuredate_Internalname, context.localUtil.Format(AV6BR_Vital.gxTpr_Br_vital_measuredate, "9999/99/99"), context.localUtil.Format( AV6BR_Vital.gxTpr_Br_vital_measuredate, "9999/99/99"), "", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavBr_vital_br_vital_measuredate_Jsonclick, 0, "ReadonlyAttribute", "", "", "", "", 1, edtavBr_vital_br_vital_measuredate_Enabled, 0, "text", "", 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_BR_VitalDelete.htm");
            GxWebStd.gx_bitmap( context, edtavBr_vital_br_vital_measuredate_Internalname+"_dp_trigger", context.GetImagePath( "61b9b5d3-dff6-4d59-9b00-da61bc2cbe93", "", context.GetTheme( )), "", "", "", "", ((1==0)||(edtavBr_vital_br_vital_measuredate_Enabled==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;", "", "", "", "", "", "", "", "", 1, false, false, "", "HLP_BR_VitalDelete.htm");
            context.WriteHtmlTextNl( "</div>") ;
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-md-6 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divUnnamedtablebr_vital_br_vital_temperature_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-4 MergeLabelCell", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblockbr_vital_br_vital_temperature_Internalname, "体温(℃)", "", "", lblTextblockbr_vital_br_vital_temperature_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_BR_VitalDelete.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-8", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavBr_vital_br_vital_temperature_Internalname, "体温(℃)", "col-sm-3 ReadonlyAttributeLabel", 0, true);
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtavBr_vital_br_vital_temperature_Internalname, StringUtil.LTrim( StringUtil.NToC( AV6BR_Vital.gxTpr_Br_vital_temperature, 15, 5, ".", "")), ((edtavBr_vital_br_vital_temperature_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( AV6BR_Vital.gxTpr_Br_vital_temperature, "ZZZZZZZZZ.ZZZZZ")) : context.localUtil.Format( AV6BR_Vital.gxTpr_Br_vital_temperature, "ZZZZZZZZZ.ZZZZZ")), "", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavBr_vital_br_vital_temperature_Jsonclick, 0, "ReadonlyAttribute", "", "", "", "", 1, edtavBr_vital_br_vital_temperature_Enabled, 0, "text", "", 15, "chr", 1, "row", 15, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_BR_VitalDelete.htm");
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
            GxWebStd.gx_div_start( context, divUnnamedtablebr_vital_br_vital_pulse_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-4 MergeLabelCell", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblockbr_vital_br_vital_pulse_Internalname, "脉搏(次/分钟)", "", "", lblTextblockbr_vital_br_vital_pulse_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_BR_VitalDelete.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-8", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavBr_vital_br_vital_pulse_Internalname, "脉搏(次/分钟)", "col-sm-3 ReadonlyAttributeLabel", 0, true);
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtavBr_vital_br_vital_pulse_Internalname, StringUtil.LTrim( StringUtil.NToC( AV6BR_Vital.gxTpr_Br_vital_pulse, 15, 5, ".", "")), ((edtavBr_vital_br_vital_pulse_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( AV6BR_Vital.gxTpr_Br_vital_pulse, "ZZZZZZZZZ.ZZZZZ")) : context.localUtil.Format( AV6BR_Vital.gxTpr_Br_vital_pulse, "ZZZZZZZZZ.ZZZZZ")), "", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavBr_vital_br_vital_pulse_Jsonclick, 0, "ReadonlyAttribute", "", "", "", "", 1, edtavBr_vital_br_vital_pulse_Enabled, 0, "text", "", 15, "chr", 1, "row", 15, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_BR_VitalDelete.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-md-6 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divUnnamedtablebr_vital_br_vital_respiration_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-4 MergeLabelCell", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblockbr_vital_br_vital_respiration_Internalname, "呼吸频率(次/分钟)", "", "", lblTextblockbr_vital_br_vital_respiration_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_BR_VitalDelete.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-8", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavBr_vital_br_vital_respiration_Internalname, "呼吸频率(次/分钟)", "col-sm-3 ReadonlyAttributeLabel", 0, true);
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtavBr_vital_br_vital_respiration_Internalname, StringUtil.LTrim( StringUtil.NToC( AV6BR_Vital.gxTpr_Br_vital_respiration, 15, 5, ".", "")), ((edtavBr_vital_br_vital_respiration_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( AV6BR_Vital.gxTpr_Br_vital_respiration, "ZZZZZZZZZ.ZZZZZ")) : context.localUtil.Format( AV6BR_Vital.gxTpr_Br_vital_respiration, "ZZZZZZZZZ.ZZZZZ")), "", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavBr_vital_br_vital_respiration_Jsonclick, 0, "ReadonlyAttribute", "", "", "", "", 1, edtavBr_vital_br_vital_respiration_Enabled, 0, "text", "", 15, "chr", 1, "row", 15, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_BR_VitalDelete.htm");
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
            GxWebStd.gx_div_start( context, divUnnamedtablebr_vital_br_vital_systolic_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-4 MergeLabelCell", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblockbr_vital_br_vital_systolic_Internalname, "收缩压(mmHg)", "", "", lblTextblockbr_vital_br_vital_systolic_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_BR_VitalDelete.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-8", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavBr_vital_br_vital_systolic_Internalname, "收缩压(mmHg)", "col-sm-3 ReadonlyAttributeLabel", 0, true);
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtavBr_vital_br_vital_systolic_Internalname, StringUtil.LTrim( StringUtil.NToC( AV6BR_Vital.gxTpr_Br_vital_systolic, 15, 5, ".", "")), ((edtavBr_vital_br_vital_systolic_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( AV6BR_Vital.gxTpr_Br_vital_systolic, "ZZZZZZZZZ.ZZZZZ")) : context.localUtil.Format( AV6BR_Vital.gxTpr_Br_vital_systolic, "ZZZZZZZZZ.ZZZZZ")), "", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavBr_vital_br_vital_systolic_Jsonclick, 0, "ReadonlyAttribute", "", "", "", "", 1, edtavBr_vital_br_vital_systolic_Enabled, 0, "text", "", 15, "chr", 1, "row", 15, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_BR_VitalDelete.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-md-6 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divUnnamedtablebr_vital_br_vital_diastolic_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-4 MergeLabelCell", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblockbr_vital_br_vital_diastolic_Internalname, "舒张压(mmHg)", "", "", lblTextblockbr_vital_br_vital_diastolic_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_BR_VitalDelete.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-8", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavBr_vital_br_vital_diastolic_Internalname, "舒张压(mmHg)", "col-sm-3 ReadonlyAttributeLabel", 0, true);
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtavBr_vital_br_vital_diastolic_Internalname, StringUtil.LTrim( StringUtil.NToC( AV6BR_Vital.gxTpr_Br_vital_diastolic, 15, 5, ".", "")), ((edtavBr_vital_br_vital_diastolic_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( AV6BR_Vital.gxTpr_Br_vital_diastolic, "ZZZZZZZZZ.ZZZZZ")) : context.localUtil.Format( AV6BR_Vital.gxTpr_Br_vital_diastolic, "ZZZZZZZZZ.ZZZZZ")), "", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavBr_vital_br_vital_diastolic_Jsonclick, 0, "ReadonlyAttribute", "", "", "", "", 1, edtavBr_vital_br_vital_diastolic_Enabled, 0, "text", "", 15, "chr", 1, "row", 15, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_BR_VitalDelete.htm");
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
            GxWebStd.gx_div_start( context, divUnnamedtablebr_vital_br_vital_height_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-4 MergeLabelCell", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblockbr_vital_br_vital_height_Internalname, "身高(cm)", "", "", lblTextblockbr_vital_br_vital_height_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_BR_VitalDelete.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-8", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavBr_vital_br_vital_height_Internalname, "身高(cm)", "col-sm-3 ReadonlyAttributeLabel", 0, true);
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtavBr_vital_br_vital_height_Internalname, StringUtil.LTrim( StringUtil.NToC( AV6BR_Vital.gxTpr_Br_vital_height, 15, 5, ".", "")), ((edtavBr_vital_br_vital_height_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( AV6BR_Vital.gxTpr_Br_vital_height, "ZZZZZZZZZ.ZZZZZ")) : context.localUtil.Format( AV6BR_Vital.gxTpr_Br_vital_height, "ZZZZZZZZZ.ZZZZZ")), "", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavBr_vital_br_vital_height_Jsonclick, 0, "ReadonlyAttribute", "", "", "", "", 1, edtavBr_vital_br_vital_height_Enabled, 0, "text", "", 15, "chr", 1, "row", 15, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_BR_VitalDelete.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-md-6 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divUnnamedtablebr_vital_br_vital_weight_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-4 MergeLabelCell", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblockbr_vital_br_vital_weight_Internalname, "体重(kg)", "", "", lblTextblockbr_vital_br_vital_weight_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_BR_VitalDelete.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-8", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavBr_vital_br_vital_weight_Internalname, "体重(kg)", "col-sm-3 ReadonlyAttributeLabel", 0, true);
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtavBr_vital_br_vital_weight_Internalname, StringUtil.LTrim( StringUtil.NToC( AV6BR_Vital.gxTpr_Br_vital_weight, 15, 5, ".", "")), ((edtavBr_vital_br_vital_weight_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( AV6BR_Vital.gxTpr_Br_vital_weight, "ZZZZZZZZZ.ZZZZZ")) : context.localUtil.Format( AV6BR_Vital.gxTpr_Br_vital_weight, "ZZZZZZZZZ.ZZZZZ")), "", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavBr_vital_br_vital_weight_Jsonclick, 0, "ReadonlyAttribute", "", "", "", "", 1, edtavBr_vital_br_vital_weight_Enabled, 0, "text", "", 15, "chr", 1, "row", 15, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_BR_VitalDelete.htm");
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
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 93,'',false,'',0)\"";
            ClassString = "ButtonMaterial";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtnenter_Internalname, "", "确认", bttBtnenter_Jsonclick, 5, "确认", "", StyleString, ClassString, 1, 1, "standard", "'"+""+"'"+",false,"+"'"+"EENTER."+"'", TempTags, "", context.GetButtonType( ), "HLP_BR_VitalDelete.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 95,'',false,'',0)\"";
            ClassString = "ButtonMaterialDefault";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtncancel_Internalname, "", "取消", bttBtncancel_Jsonclick, 1, "取消", "", StyleString, ClassString, 1, 1, "standard", "'"+""+"'"+",false,"+"'"+"ECANCEL."+"'", TempTags, "", context.GetButtonType( ), "HLP_BR_VitalDelete.htm");
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
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 99,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavBr_vital_br_vitalid_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV6BR_Vital.gxTpr_Br_vitalid), 18, 0, ".", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(AV6BR_Vital.gxTpr_Br_vitalid), "ZZZZZZZZZZZZZZZZZZ")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,99);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavBr_vital_br_vitalid_Jsonclick, 0, "Attribute", "", "", "", "", edtavBr_vital_br_vitalid_Visible, 1, 0, "number", "1", 18, "chr", 1, "row", 18, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_BR_VitalDelete.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 100,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavBr_vital_br_encounterid_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV6BR_Vital.gxTpr_Br_encounterid), 18, 0, ".", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(AV6BR_Vital.gxTpr_Br_encounterid), "ZZZZZZZZZZZZZZZZZZ")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,100);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavBr_vital_br_encounterid_Jsonclick, 0, "Attribute", "", "", "", "", edtavBr_vital_br_encounterid_Visible, 1, 0, "number", "1", 18, "chr", 1, "row", 18, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_BR_VitalDelete.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 101,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavBr_vital_br_information_patientno_Internalname, AV6BR_Vital.gxTpr_Br_information_patientno, StringUtil.RTrim( context.localUtil.Format( AV6BR_Vital.gxTpr_Br_information_patientno, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,101);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavBr_vital_br_information_patientno_Jsonclick, 0, "Attribute", "", "", "", "", edtavBr_vital_br_information_patientno_Visible, 1, 0, "text", "", 80, "chr", 1, "row", 2000, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_BR_VitalDelete.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 102,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavBr_vital_br_vital_vitalid_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV6BR_Vital.gxTpr_Br_vital_vitalid), 10, 0, ".", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(AV6BR_Vital.gxTpr_Br_vital_vitalid), "ZZZZZZZZZZ")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,102);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavBr_vital_br_vital_vitalid_Jsonclick, 0, "Attribute", "", "", "", "", edtavBr_vital_br_vital_vitalid_Visible, 1, 0, "number", "1", 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_BR_VitalDelete.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
         }
         wbLoad = true;
      }

      protected void START9D2( )
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
         STRUP9D0( ) ;
      }

      protected void WS9D2( )
      {
         START9D2( ) ;
         EVT9D2( ) ;
      }

      protected void EVT9D2( )
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
                              E119D2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "REFRESH") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              /* Execute user event: Refresh */
                              E129D2 ();
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
                                    E139D2 ();
                                 }
                                 dynload_actions( ) ;
                              }
                           }
                           else if ( StringUtil.StrCmp(sEvt, "LOAD") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              /* Execute user event: Load */
                              E149D2 ();
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

      protected void WE9D2( )
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

      protected void PA9D2( )
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
               GX_FocusControl = edtavBr_vital_br_vital_measuredate_Internalname;
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
         RF9D2( ) ;
         if ( isFullAjaxMode( ) )
         {
            send_integrity_footer_hashes( ) ;
         }
      }

      protected void initialize_formulas( )
      {
         /* GeneXus formulas. */
         context.Gx_err = 0;
         edtavBr_vital_br_vital_measuredate_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavBr_vital_br_vital_measuredate_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavBr_vital_br_vital_measuredate_Enabled), 5, 0)), true);
         edtavBr_vital_br_vital_temperature_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavBr_vital_br_vital_temperature_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavBr_vital_br_vital_temperature_Enabled), 5, 0)), true);
         edtavBr_vital_br_vital_pulse_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavBr_vital_br_vital_pulse_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavBr_vital_br_vital_pulse_Enabled), 5, 0)), true);
         edtavBr_vital_br_vital_respiration_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavBr_vital_br_vital_respiration_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavBr_vital_br_vital_respiration_Enabled), 5, 0)), true);
         edtavBr_vital_br_vital_systolic_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavBr_vital_br_vital_systolic_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavBr_vital_br_vital_systolic_Enabled), 5, 0)), true);
         edtavBr_vital_br_vital_diastolic_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavBr_vital_br_vital_diastolic_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavBr_vital_br_vital_diastolic_Enabled), 5, 0)), true);
         edtavBr_vital_br_vital_height_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavBr_vital_br_vital_height_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavBr_vital_br_vital_height_Enabled), 5, 0)), true);
         edtavBr_vital_br_vital_weight_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavBr_vital_br_vital_weight_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavBr_vital_br_vital_weight_Enabled), 5, 0)), true);
      }

      protected void RF9D2( )
      {
         initialize_formulas( ) ;
         clear_multi_value_controls( ) ;
         /* Execute user event: Refresh */
         E129D2 ();
         gxdyncontrolsrefreshing = true;
         fix_multi_value_controls( ) ;
         gxdyncontrolsrefreshing = false;
         if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
         {
            /* Execute user event: Load */
            E149D2 ();
            WB9D0( ) ;
         }
      }

      protected void send_integrity_lvl_hashes9D2( )
      {
      }

      protected void STRUP9D0( )
      {
         /* Before Start, stand alone formulas. */
         context.Gx_err = 0;
         edtavBr_vital_br_vital_measuredate_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavBr_vital_br_vital_measuredate_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavBr_vital_br_vital_measuredate_Enabled), 5, 0)), true);
         edtavBr_vital_br_vital_temperature_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavBr_vital_br_vital_temperature_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavBr_vital_br_vital_temperature_Enabled), 5, 0)), true);
         edtavBr_vital_br_vital_pulse_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavBr_vital_br_vital_pulse_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavBr_vital_br_vital_pulse_Enabled), 5, 0)), true);
         edtavBr_vital_br_vital_respiration_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavBr_vital_br_vital_respiration_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavBr_vital_br_vital_respiration_Enabled), 5, 0)), true);
         edtavBr_vital_br_vital_systolic_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavBr_vital_br_vital_systolic_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavBr_vital_br_vital_systolic_Enabled), 5, 0)), true);
         edtavBr_vital_br_vital_diastolic_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavBr_vital_br_vital_diastolic_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavBr_vital_br_vital_diastolic_Enabled), 5, 0)), true);
         edtavBr_vital_br_vital_height_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavBr_vital_br_vital_height_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavBr_vital_br_vital_height_Enabled), 5, 0)), true);
         edtavBr_vital_br_vital_weight_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavBr_vital_br_vital_weight_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavBr_vital_br_vital_weight_Enabled), 5, 0)), true);
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0;
         /* Execute user event: Start */
         E119D2 ();
         context.wbGlbDoneStart = 1;
         /* After Start, stand alone formulas. */
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read saved SDTs. */
            ajax_req_read_hidden_sdt(cgiGet( "Br_vital"), AV6BR_Vital);
            /* Read variables values. */
            if ( context.localUtil.VCDate( cgiGet( edtavBr_vital_br_vital_measuredate_Internalname), 0) == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_faildate", new   object[]  {"测量日期"}), 1, "BR_VITAL_BR_VITAL_MEASUREDATE");
               GX_FocusControl = edtavBr_vital_br_vital_measuredate_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV6BR_Vital.gxTpr_Br_vital_measuredate = DateTime.MinValue;
            }
            else
            {
               AV6BR_Vital.gxTpr_Br_vital_measuredate = context.localUtil.CToD( cgiGet( edtavBr_vital_br_vital_measuredate_Internalname), 0);
            }
            if ( ( ( context.localUtil.CToN( cgiGet( edtavBr_vital_br_vital_temperature_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavBr_vital_br_vital_temperature_Internalname), ".", ",") > 999999999.99999m ) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "BR_VITAL_BR_VITAL_TEMPERATURE");
               GX_FocusControl = edtavBr_vital_br_vital_temperature_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV6BR_Vital.gxTpr_Br_vital_temperature = 0;
            }
            else
            {
               AV6BR_Vital.gxTpr_Br_vital_temperature = context.localUtil.CToN( cgiGet( edtavBr_vital_br_vital_temperature_Internalname), ".", ",");
            }
            if ( ( ( context.localUtil.CToN( cgiGet( edtavBr_vital_br_vital_pulse_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavBr_vital_br_vital_pulse_Internalname), ".", ",") > 999999999.99999m ) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "BR_VITAL_BR_VITAL_PULSE");
               GX_FocusControl = edtavBr_vital_br_vital_pulse_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV6BR_Vital.gxTpr_Br_vital_pulse = 0;
            }
            else
            {
               AV6BR_Vital.gxTpr_Br_vital_pulse = context.localUtil.CToN( cgiGet( edtavBr_vital_br_vital_pulse_Internalname), ".", ",");
            }
            if ( ( ( context.localUtil.CToN( cgiGet( edtavBr_vital_br_vital_respiration_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavBr_vital_br_vital_respiration_Internalname), ".", ",") > 999999999.99999m ) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "BR_VITAL_BR_VITAL_RESPIRATION");
               GX_FocusControl = edtavBr_vital_br_vital_respiration_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV6BR_Vital.gxTpr_Br_vital_respiration = 0;
            }
            else
            {
               AV6BR_Vital.gxTpr_Br_vital_respiration = context.localUtil.CToN( cgiGet( edtavBr_vital_br_vital_respiration_Internalname), ".", ",");
            }
            if ( ( ( context.localUtil.CToN( cgiGet( edtavBr_vital_br_vital_systolic_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavBr_vital_br_vital_systolic_Internalname), ".", ",") > 999999999.99999m ) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "BR_VITAL_BR_VITAL_SYSTOLIC");
               GX_FocusControl = edtavBr_vital_br_vital_systolic_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV6BR_Vital.gxTpr_Br_vital_systolic = 0;
            }
            else
            {
               AV6BR_Vital.gxTpr_Br_vital_systolic = context.localUtil.CToN( cgiGet( edtavBr_vital_br_vital_systolic_Internalname), ".", ",");
            }
            if ( ( ( context.localUtil.CToN( cgiGet( edtavBr_vital_br_vital_diastolic_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavBr_vital_br_vital_diastolic_Internalname), ".", ",") > 999999999.99999m ) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "BR_VITAL_BR_VITAL_DIASTOLIC");
               GX_FocusControl = edtavBr_vital_br_vital_diastolic_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV6BR_Vital.gxTpr_Br_vital_diastolic = 0;
            }
            else
            {
               AV6BR_Vital.gxTpr_Br_vital_diastolic = context.localUtil.CToN( cgiGet( edtavBr_vital_br_vital_diastolic_Internalname), ".", ",");
            }
            if ( ( ( context.localUtil.CToN( cgiGet( edtavBr_vital_br_vital_height_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavBr_vital_br_vital_height_Internalname), ".", ",") > 999999999.99999m ) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "BR_VITAL_BR_VITAL_HEIGHT");
               GX_FocusControl = edtavBr_vital_br_vital_height_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV6BR_Vital.gxTpr_Br_vital_height = 0;
            }
            else
            {
               AV6BR_Vital.gxTpr_Br_vital_height = context.localUtil.CToN( cgiGet( edtavBr_vital_br_vital_height_Internalname), ".", ",");
            }
            if ( ( ( context.localUtil.CToN( cgiGet( edtavBr_vital_br_vital_weight_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavBr_vital_br_vital_weight_Internalname), ".", ",") > 999999999.99999m ) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "BR_VITAL_BR_VITAL_WEIGHT");
               GX_FocusControl = edtavBr_vital_br_vital_weight_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV6BR_Vital.gxTpr_Br_vital_weight = 0;
            }
            else
            {
               AV6BR_Vital.gxTpr_Br_vital_weight = context.localUtil.CToN( cgiGet( edtavBr_vital_br_vital_weight_Internalname), ".", ",");
            }
            if ( ( ( context.localUtil.CToN( cgiGet( edtavBr_vital_br_vitalid_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavBr_vital_br_vitalid_Internalname), ".", ",") > Convert.ToDecimal( 999999999999999999L )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "BR_VITAL_BR_VITALID");
               GX_FocusControl = edtavBr_vital_br_vitalid_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV6BR_Vital.gxTpr_Br_vitalid = 0;
            }
            else
            {
               AV6BR_Vital.gxTpr_Br_vitalid = (long)(context.localUtil.CToN( cgiGet( edtavBr_vital_br_vitalid_Internalname), ".", ","));
            }
            if ( ( ( context.localUtil.CToN( cgiGet( edtavBr_vital_br_encounterid_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavBr_vital_br_encounterid_Internalname), ".", ",") > Convert.ToDecimal( 999999999999999999L )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "BR_VITAL_BR_ENCOUNTERID");
               GX_FocusControl = edtavBr_vital_br_encounterid_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV6BR_Vital.gxTpr_Br_encounterid = 0;
            }
            else
            {
               AV6BR_Vital.gxTpr_Br_encounterid = (long)(context.localUtil.CToN( cgiGet( edtavBr_vital_br_encounterid_Internalname), ".", ","));
            }
            AV6BR_Vital.gxTpr_Br_information_patientno = cgiGet( edtavBr_vital_br_information_patientno_Internalname);
            if ( ( ( context.localUtil.CToN( cgiGet( edtavBr_vital_br_vital_vitalid_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavBr_vital_br_vital_vitalid_Internalname), ".", ",") > Convert.ToDecimal( 9999999999L )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "BR_VITAL_BR_VITAL_VITALID");
               GX_FocusControl = edtavBr_vital_br_vital_vitalid_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV6BR_Vital.gxTpr_Br_vital_vitalid = 0;
            }
            else
            {
               AV6BR_Vital.gxTpr_Br_vital_vitalid = (long)(context.localUtil.CToN( cgiGet( edtavBr_vital_br_vital_vitalid_Internalname), ".", ","));
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
            forbiddenHiddens = "hsh" + "BR_VitalDelete";
            AV6BR_Vital.gxTpr_Br_vital_measuredate = context.localUtil.CToD( cgiGet( edtavBr_vital_br_vital_measuredate_Internalname), 0);
            forbiddenHiddens = forbiddenHiddens + context.localUtil.Format(AV6BR_Vital.gxTpr_Br_vital_measuredate, "9999/99/99");
            AV6BR_Vital.gxTpr_Br_vital_temperature = context.localUtil.CToN( cgiGet( edtavBr_vital_br_vital_temperature_Internalname), ".", ",");
            forbiddenHiddens = forbiddenHiddens + context.localUtil.Format( AV6BR_Vital.gxTpr_Br_vital_temperature, "ZZZZZZZZZ.ZZZZZ");
            AV6BR_Vital.gxTpr_Br_vital_pulse = context.localUtil.CToN( cgiGet( edtavBr_vital_br_vital_pulse_Internalname), ".", ",");
            forbiddenHiddens = forbiddenHiddens + context.localUtil.Format( AV6BR_Vital.gxTpr_Br_vital_pulse, "ZZZZZZZZZ.ZZZZZ");
            AV6BR_Vital.gxTpr_Br_vital_respiration = context.localUtil.CToN( cgiGet( edtavBr_vital_br_vital_respiration_Internalname), ".", ",");
            forbiddenHiddens = forbiddenHiddens + context.localUtil.Format( AV6BR_Vital.gxTpr_Br_vital_respiration, "ZZZZZZZZZ.ZZZZZ");
            AV6BR_Vital.gxTpr_Br_vital_systolic = context.localUtil.CToN( cgiGet( edtavBr_vital_br_vital_systolic_Internalname), ".", ",");
            forbiddenHiddens = forbiddenHiddens + context.localUtil.Format( AV6BR_Vital.gxTpr_Br_vital_systolic, "ZZZZZZZZZ.ZZZZZ");
            AV6BR_Vital.gxTpr_Br_vital_diastolic = context.localUtil.CToN( cgiGet( edtavBr_vital_br_vital_diastolic_Internalname), ".", ",");
            forbiddenHiddens = forbiddenHiddens + context.localUtil.Format( AV6BR_Vital.gxTpr_Br_vital_diastolic, "ZZZZZZZZZ.ZZZZZ");
            AV6BR_Vital.gxTpr_Br_vital_height = context.localUtil.CToN( cgiGet( edtavBr_vital_br_vital_height_Internalname), ".", ",");
            forbiddenHiddens = forbiddenHiddens + context.localUtil.Format( AV6BR_Vital.gxTpr_Br_vital_height, "ZZZZZZZZZ.ZZZZZ");
            AV6BR_Vital.gxTpr_Br_vital_weight = context.localUtil.CToN( cgiGet( edtavBr_vital_br_vital_weight_Internalname), ".", ",");
            forbiddenHiddens = forbiddenHiddens + context.localUtil.Format( AV6BR_Vital.gxTpr_Br_vital_weight, "ZZZZZZZZZ.ZZZZZ");
            hsh = cgiGet( "hsh");
            if ( ! GXUtil.CheckEncryptedHash( forbiddenHiddens, hsh, GXKey) )
            {
               GXUtil.WriteLog("br_vitaldelete:[SecurityCheckFailed value for]"+"GXV1:"+context.localUtil.Format(AV6BR_Vital.gxTpr_Br_vital_measuredate, "9999/99/99"));
               GXUtil.WriteLog("br_vitaldelete:[SecurityCheckFailed value for]"+"GXV2:"+context.localUtil.Format( AV6BR_Vital.gxTpr_Br_vital_temperature, "ZZZZZZZZZ.ZZZZZ"));
               GXUtil.WriteLog("br_vitaldelete:[SecurityCheckFailed value for]"+"GXV3:"+context.localUtil.Format( AV6BR_Vital.gxTpr_Br_vital_pulse, "ZZZZZZZZZ.ZZZZZ"));
               GXUtil.WriteLog("br_vitaldelete:[SecurityCheckFailed value for]"+"GXV4:"+context.localUtil.Format( AV6BR_Vital.gxTpr_Br_vital_respiration, "ZZZZZZZZZ.ZZZZZ"));
               GXUtil.WriteLog("br_vitaldelete:[SecurityCheckFailed value for]"+"GXV5:"+context.localUtil.Format( AV6BR_Vital.gxTpr_Br_vital_systolic, "ZZZZZZZZZ.ZZZZZ"));
               GXUtil.WriteLog("br_vitaldelete:[SecurityCheckFailed value for]"+"GXV6:"+context.localUtil.Format( AV6BR_Vital.gxTpr_Br_vital_diastolic, "ZZZZZZZZZ.ZZZZZ"));
               GXUtil.WriteLog("br_vitaldelete:[SecurityCheckFailed value for]"+"GXV7:"+context.localUtil.Format( AV6BR_Vital.gxTpr_Br_vital_height, "ZZZZZZZZZ.ZZZZZ"));
               GXUtil.WriteLog("br_vitaldelete:[SecurityCheckFailed value for]"+"GXV8:"+context.localUtil.Format( AV6BR_Vital.gxTpr_Br_vital_weight, "ZZZZZZZZZ.ZZZZZ"));
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
         E119D2 ();
         if (returnInSub) return;
      }

      protected void E119D2( )
      {
         /* Start Routine */
         edtavBr_vital_br_vitalid_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavBr_vital_br_vitalid_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavBr_vital_br_vitalid_Visible), 5, 0)), true);
         edtavBr_vital_br_encounterid_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavBr_vital_br_encounterid_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavBr_vital_br_encounterid_Visible), 5, 0)), true);
         edtavBr_vital_br_information_patientno_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavBr_vital_br_information_patientno_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavBr_vital_br_information_patientno_Visible), 5, 0)), true);
         edtavBr_vital_br_vital_vitalid_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavBr_vital_br_vital_vitalid_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavBr_vital_br_vital_vitalid_Visible), 5, 0)), true);
         AV6BR_Vital.Load(AV5iBR_VitalID);
         GX_msglist.addItem("确认删除.");
      }

      protected void S112( )
      {
         /* 'SHOW MESSAGES' Routine */
         AV27GXV13 = 1;
         while ( AV27GXV13 <= AV10Messages.Count )
         {
            AV9Message = ((SdtMessages_Message)AV10Messages.Item(AV27GXV13));
            GX_msglist.addItem(AV9Message.gxTpr_Description);
            AV27GXV13 = (int)(AV27GXV13+1);
         }
      }

      protected void E129D2( )
      {
         /* Refresh Routine */
         new GeneXus.Programs.wwpbaseobjects.loadwwpcontext(context ).execute( out  AV11Context) ;
      }

      public void GXEnter( )
      {
         /* Execute user event: Enter */
         E139D2 ();
         if (returnInSub) return;
      }

      protected void E139D2( )
      {
         /* Enter Routine */
         new zutil_checksession(context ).execute( out  AV12tCheckFlag) ;
         if ( ! AV12tCheckFlag )
         {
            AV6BR_Vital.Delete();
            context.CommitDataStores("br_vitaldelete",pr_default);
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

      protected void E149D2( )
      {
         /* Load Routine */
      }

      public override void setparameters( Object[] obj )
      {
         createObjects();
         initialize();
         AV5iBR_VitalID = Convert.ToInt64(getParm(obj,0));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV5iBR_VitalID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV5iBR_VitalID), 18, 0)));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vIBR_VITALID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV5iBR_VitalID), "ZZZZZZZZZZZZZZZZZZ"), context));
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
         PA9D2( ) ;
         WS9D2( ) ;
         WE9D2( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?20202271271238", true);
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
         context.AddJavascriptSource("br_vitaldelete.js", "?20202271271238", false);
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
         lblTextblockbr_vital_br_vital_measuredate_Internalname = "TEXTBLOCKBR_VITAL_BR_VITAL_MEASUREDATE";
         edtavBr_vital_br_vital_measuredate_Internalname = "BR_VITAL_BR_VITAL_MEASUREDATE";
         divUnnamedtablebr_vital_br_vital_measuredate_Internalname = "UNNAMEDTABLEBR_VITAL_BR_VITAL_MEASUREDATE";
         lblTextblockbr_vital_br_vital_temperature_Internalname = "TEXTBLOCKBR_VITAL_BR_VITAL_TEMPERATURE";
         edtavBr_vital_br_vital_temperature_Internalname = "BR_VITAL_BR_VITAL_TEMPERATURE";
         divUnnamedtablebr_vital_br_vital_temperature_Internalname = "UNNAMEDTABLEBR_VITAL_BR_VITAL_TEMPERATURE";
         lblTextblockbr_vital_br_vital_pulse_Internalname = "TEXTBLOCKBR_VITAL_BR_VITAL_PULSE";
         edtavBr_vital_br_vital_pulse_Internalname = "BR_VITAL_BR_VITAL_PULSE";
         divUnnamedtablebr_vital_br_vital_pulse_Internalname = "UNNAMEDTABLEBR_VITAL_BR_VITAL_PULSE";
         lblTextblockbr_vital_br_vital_respiration_Internalname = "TEXTBLOCKBR_VITAL_BR_VITAL_RESPIRATION";
         edtavBr_vital_br_vital_respiration_Internalname = "BR_VITAL_BR_VITAL_RESPIRATION";
         divUnnamedtablebr_vital_br_vital_respiration_Internalname = "UNNAMEDTABLEBR_VITAL_BR_VITAL_RESPIRATION";
         lblTextblockbr_vital_br_vital_systolic_Internalname = "TEXTBLOCKBR_VITAL_BR_VITAL_SYSTOLIC";
         edtavBr_vital_br_vital_systolic_Internalname = "BR_VITAL_BR_VITAL_SYSTOLIC";
         divUnnamedtablebr_vital_br_vital_systolic_Internalname = "UNNAMEDTABLEBR_VITAL_BR_VITAL_SYSTOLIC";
         lblTextblockbr_vital_br_vital_diastolic_Internalname = "TEXTBLOCKBR_VITAL_BR_VITAL_DIASTOLIC";
         edtavBr_vital_br_vital_diastolic_Internalname = "BR_VITAL_BR_VITAL_DIASTOLIC";
         divUnnamedtablebr_vital_br_vital_diastolic_Internalname = "UNNAMEDTABLEBR_VITAL_BR_VITAL_DIASTOLIC";
         lblTextblockbr_vital_br_vital_height_Internalname = "TEXTBLOCKBR_VITAL_BR_VITAL_HEIGHT";
         edtavBr_vital_br_vital_height_Internalname = "BR_VITAL_BR_VITAL_HEIGHT";
         divUnnamedtablebr_vital_br_vital_height_Internalname = "UNNAMEDTABLEBR_VITAL_BR_VITAL_HEIGHT";
         lblTextblockbr_vital_br_vital_weight_Internalname = "TEXTBLOCKBR_VITAL_BR_VITAL_WEIGHT";
         edtavBr_vital_br_vital_weight_Internalname = "BR_VITAL_BR_VITAL_WEIGHT";
         divUnnamedtablebr_vital_br_vital_weight_Internalname = "UNNAMEDTABLEBR_VITAL_BR_VITAL_WEIGHT";
         divTableattributes_Internalname = "TABLEATTRIBUTES";
         divLayout_tableattributes_Internalname = "LAYOUT_TABLEATTRIBUTES";
         Dvpanel_tableattributes_Internalname = "DVPANEL_TABLEATTRIBUTES";
         divHtml_dvpanel_tableattributes_Internalname = "HTML_DVPANEL_TABLEATTRIBUTES";
         divTablecontent_Internalname = "TABLECONTENT";
         bttBtnenter_Internalname = "BTNENTER";
         bttBtncancel_Internalname = "BTNCANCEL";
         divTablemain_Internalname = "TABLEMAIN";
         edtavBr_vital_br_vitalid_Internalname = "BR_VITAL_BR_VITALID";
         edtavBr_vital_br_encounterid_Internalname = "BR_VITAL_BR_ENCOUNTERID";
         edtavBr_vital_br_information_patientno_Internalname = "BR_VITAL_BR_INFORMATION_PATIENTNO";
         edtavBr_vital_br_vital_vitalid_Internalname = "BR_VITAL_BR_VITAL_VITALID";
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
         edtavBr_vital_br_vital_weight_Enabled = -1;
         edtavBr_vital_br_vital_height_Enabled = -1;
         edtavBr_vital_br_vital_diastolic_Enabled = -1;
         edtavBr_vital_br_vital_systolic_Enabled = -1;
         edtavBr_vital_br_vital_respiration_Enabled = -1;
         edtavBr_vital_br_vital_pulse_Enabled = -1;
         edtavBr_vital_br_vital_temperature_Enabled = -1;
         edtavBr_vital_br_vital_measuredate_Enabled = -1;
         edtavBr_vital_br_vital_vitalid_Jsonclick = "";
         edtavBr_vital_br_vital_vitalid_Visible = 1;
         edtavBr_vital_br_information_patientno_Jsonclick = "";
         edtavBr_vital_br_information_patientno_Visible = 1;
         edtavBr_vital_br_encounterid_Jsonclick = "";
         edtavBr_vital_br_encounterid_Visible = 1;
         edtavBr_vital_br_vitalid_Jsonclick = "";
         edtavBr_vital_br_vitalid_Visible = 1;
         edtavBr_vital_br_vital_weight_Jsonclick = "";
         edtavBr_vital_br_vital_weight_Enabled = 0;
         edtavBr_vital_br_vital_height_Jsonclick = "";
         edtavBr_vital_br_vital_height_Enabled = 0;
         edtavBr_vital_br_vital_diastolic_Jsonclick = "";
         edtavBr_vital_br_vital_diastolic_Enabled = 0;
         edtavBr_vital_br_vital_systolic_Jsonclick = "";
         edtavBr_vital_br_vital_systolic_Enabled = 0;
         edtavBr_vital_br_vital_respiration_Jsonclick = "";
         edtavBr_vital_br_vital_respiration_Enabled = 0;
         edtavBr_vital_br_vital_pulse_Jsonclick = "";
         edtavBr_vital_br_vital_pulse_Enabled = 0;
         edtavBr_vital_br_vital_temperature_Jsonclick = "";
         edtavBr_vital_br_vital_temperature_Enabled = 0;
         edtavBr_vital_br_vital_measuredate_Jsonclick = "";
         edtavBr_vital_br_vital_measuredate_Enabled = 0;
         Dvpanel_tableattributes_Autoscroll = Convert.ToBoolean( 0);
         Dvpanel_tableattributes_Iconposition = "left";
         Dvpanel_tableattributes_Showcollapseicon = Convert.ToBoolean( 0);
         Dvpanel_tableattributes_Autoheight = Convert.ToBoolean( -1);
         Dvpanel_tableattributes_Autowidth = Convert.ToBoolean( 0);
         Dvpanel_tableattributes_Collapsed = Convert.ToBoolean( 0);
         Dvpanel_tableattributes_Collapsible = Convert.ToBoolean( 0);
         Dvpanel_tableattributes_Title = "生命体征";
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
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[{av:'AV5iBR_VitalID',fld:'vIBR_VITALID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true},{av:'AV6BR_Vital.gxTpr_Br_vital_measuredate',fld:'BR_VITAL_BR_VITAL_MEASUREDATE',pic:''},{av:'AV6BR_Vital.gxTpr_Br_vital_temperature',fld:'BR_VITAL_BR_VITAL_TEMPERATURE',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV6BR_Vital.gxTpr_Br_vital_pulse',fld:'BR_VITAL_BR_VITAL_PULSE',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV6BR_Vital.gxTpr_Br_vital_respiration',fld:'BR_VITAL_BR_VITAL_RESPIRATION',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV6BR_Vital.gxTpr_Br_vital_systolic',fld:'BR_VITAL_BR_VITAL_SYSTOLIC',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV6BR_Vital.gxTpr_Br_vital_diastolic',fld:'BR_VITAL_BR_VITAL_DIASTOLIC',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV6BR_Vital.gxTpr_Br_vital_height',fld:'BR_VITAL_BR_VITAL_HEIGHT',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV6BR_Vital.gxTpr_Br_vital_weight',fld:'BR_VITAL_BR_VITAL_WEIGHT',pic:'ZZZZZZZZZ.ZZZZZ'}]");
         setEventMetadata("REFRESH",",oparms:[]}");
         setEventMetadata("ENTER","{handler:'E139D2',iparms:[{av:'AV6BR_Vital',fld:'vBR_VITAL',pic:''}]");
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
         AV6BR_Vital = new SdtBR_Vital(context);
         GX_FocusControl = "";
         Form = new GXWebForm();
         sPrefix = "";
         ClassString = "";
         StyleString = "";
         ucDvpanel_tableattributes = new GXUserControl();
         lblTextblockbr_vital_br_vital_measuredate_Jsonclick = "";
         lblTextblockbr_vital_br_vital_temperature_Jsonclick = "";
         lblTextblockbr_vital_br_vital_pulse_Jsonclick = "";
         lblTextblockbr_vital_br_vital_respiration_Jsonclick = "";
         lblTextblockbr_vital_br_vital_systolic_Jsonclick = "";
         lblTextblockbr_vital_br_vital_diastolic_Jsonclick = "";
         lblTextblockbr_vital_br_vital_height_Jsonclick = "";
         lblTextblockbr_vital_br_vital_weight_Jsonclick = "";
         TempTags = "";
         bttBtnenter_Jsonclick = "";
         bttBtncancel_Jsonclick = "";
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         hsh = "";
         AV10Messages = new GXBaseCollection<SdtMessages_Message>( context, "Message", "GeneXus");
         AV9Message = new SdtMessages_Message(context);
         AV11Context = new GeneXus.Programs.wwpbaseobjects.SdtWWPContext(context);
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         pr_datastore1 = new DataStoreProvider(context, new GeneXus.Programs.br_vitaldelete__datastore1(),
            new Object[][] {
            }
         );
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.br_vitaldelete__default(),
            new Object[][] {
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0;
         edtavBr_vital_br_vital_measuredate_Enabled = 0;
         edtavBr_vital_br_vital_temperature_Enabled = 0;
         edtavBr_vital_br_vital_pulse_Enabled = 0;
         edtavBr_vital_br_vital_respiration_Enabled = 0;
         edtavBr_vital_br_vital_systolic_Enabled = 0;
         edtavBr_vital_br_vital_diastolic_Enabled = 0;
         edtavBr_vital_br_vital_height_Enabled = 0;
         edtavBr_vital_br_vital_weight_Enabled = 0;
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
      private int edtavBr_vital_br_vital_measuredate_Enabled ;
      private int edtavBr_vital_br_vital_temperature_Enabled ;
      private int edtavBr_vital_br_vital_pulse_Enabled ;
      private int edtavBr_vital_br_vital_respiration_Enabled ;
      private int edtavBr_vital_br_vital_systolic_Enabled ;
      private int edtavBr_vital_br_vital_diastolic_Enabled ;
      private int edtavBr_vital_br_vital_height_Enabled ;
      private int edtavBr_vital_br_vital_weight_Enabled ;
      private int edtavBr_vital_br_vitalid_Visible ;
      private int edtavBr_vital_br_encounterid_Visible ;
      private int edtavBr_vital_br_information_patientno_Visible ;
      private int edtavBr_vital_br_vital_vitalid_Visible ;
      private int AV27GXV13 ;
      private int idxLst ;
      private long AV5iBR_VitalID ;
      private long wcpOAV5iBR_VitalID ;
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
      private String divUnnamedtablebr_vital_br_vital_measuredate_Internalname ;
      private String lblTextblockbr_vital_br_vital_measuredate_Internalname ;
      private String lblTextblockbr_vital_br_vital_measuredate_Jsonclick ;
      private String edtavBr_vital_br_vital_measuredate_Internalname ;
      private String edtavBr_vital_br_vital_measuredate_Jsonclick ;
      private String divUnnamedtablebr_vital_br_vital_temperature_Internalname ;
      private String lblTextblockbr_vital_br_vital_temperature_Internalname ;
      private String lblTextblockbr_vital_br_vital_temperature_Jsonclick ;
      private String edtavBr_vital_br_vital_temperature_Internalname ;
      private String edtavBr_vital_br_vital_temperature_Jsonclick ;
      private String divUnnamedtablebr_vital_br_vital_pulse_Internalname ;
      private String lblTextblockbr_vital_br_vital_pulse_Internalname ;
      private String lblTextblockbr_vital_br_vital_pulse_Jsonclick ;
      private String edtavBr_vital_br_vital_pulse_Internalname ;
      private String edtavBr_vital_br_vital_pulse_Jsonclick ;
      private String divUnnamedtablebr_vital_br_vital_respiration_Internalname ;
      private String lblTextblockbr_vital_br_vital_respiration_Internalname ;
      private String lblTextblockbr_vital_br_vital_respiration_Jsonclick ;
      private String edtavBr_vital_br_vital_respiration_Internalname ;
      private String edtavBr_vital_br_vital_respiration_Jsonclick ;
      private String divUnnamedtablebr_vital_br_vital_systolic_Internalname ;
      private String lblTextblockbr_vital_br_vital_systolic_Internalname ;
      private String lblTextblockbr_vital_br_vital_systolic_Jsonclick ;
      private String edtavBr_vital_br_vital_systolic_Internalname ;
      private String edtavBr_vital_br_vital_systolic_Jsonclick ;
      private String divUnnamedtablebr_vital_br_vital_diastolic_Internalname ;
      private String lblTextblockbr_vital_br_vital_diastolic_Internalname ;
      private String lblTextblockbr_vital_br_vital_diastolic_Jsonclick ;
      private String edtavBr_vital_br_vital_diastolic_Internalname ;
      private String edtavBr_vital_br_vital_diastolic_Jsonclick ;
      private String divUnnamedtablebr_vital_br_vital_height_Internalname ;
      private String lblTextblockbr_vital_br_vital_height_Internalname ;
      private String lblTextblockbr_vital_br_vital_height_Jsonclick ;
      private String edtavBr_vital_br_vital_height_Internalname ;
      private String edtavBr_vital_br_vital_height_Jsonclick ;
      private String divUnnamedtablebr_vital_br_vital_weight_Internalname ;
      private String lblTextblockbr_vital_br_vital_weight_Internalname ;
      private String lblTextblockbr_vital_br_vital_weight_Jsonclick ;
      private String edtavBr_vital_br_vital_weight_Internalname ;
      private String edtavBr_vital_br_vital_weight_Jsonclick ;
      private String TempTags ;
      private String bttBtnenter_Internalname ;
      private String bttBtnenter_Jsonclick ;
      private String bttBtncancel_Internalname ;
      private String bttBtncancel_Jsonclick ;
      private String divHtml_bottomauxiliarcontrols_Internalname ;
      private String edtavBr_vital_br_vitalid_Internalname ;
      private String edtavBr_vital_br_vitalid_Jsonclick ;
      private String edtavBr_vital_br_encounterid_Internalname ;
      private String edtavBr_vital_br_encounterid_Jsonclick ;
      private String edtavBr_vital_br_information_patientno_Internalname ;
      private String edtavBr_vital_br_information_patientno_Jsonclick ;
      private String edtavBr_vital_br_vital_vitalid_Internalname ;
      private String edtavBr_vital_br_vital_vitalid_Jsonclick ;
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
      private bool AV12tCheckFlag ;
      private GXUserControl ucDvpanel_tableattributes ;
      private IGxDataStore dsDataStore1 ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private IDataStoreProvider pr_datastore1 ;
      private GXBaseCollection<SdtMessages_Message> AV10Messages ;
      private GXWebForm Form ;
      private SdtBR_Vital AV6BR_Vital ;
      private SdtMessages_Message AV9Message ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPContext AV11Context ;
   }

   public class br_vitaldelete__datastore1 : DataStoreHelperBase, IDataStoreHelper
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

 public class br_vitaldelete__default : DataStoreHelperBase, IDataStoreHelper
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
