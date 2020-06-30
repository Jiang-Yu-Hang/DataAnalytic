/*
               File: BR_Scheme_MedicationUpdate
        Description: Data Mgmt Portal - RAAP
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/28/2020 15:15:56.48
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
   public class br_scheme_medicationupdate : GXDataArea, System.Web.SessionState.IRequiresSessionState
   {
      public br_scheme_medicationupdate( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public br_scheme_medicationupdate( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( long aP0_iID ,
                           String aP1_iType )
      {
         this.AV16iID = aP0_iID;
         this.AV15iType = aP1_iType;
         executePrivate();
      }

      void executePrivate( )
      {
         isStatic = false;
         webExecute();
      }

      protected override void createObjects( )
      {
         dynavBr_scheme_medication_br_medication_rxname = new GXCombobox();
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
            else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxCallCrl"+"_"+"BR_SCHEME_MEDICATION_BR_MEDICATION_RXNAME") == 0 )
            {
               AV36Tcurrentcode = NumberUtil.Val( GetNextPar( ), ".");
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1;
                  return  ;
               }
               GXDLVBR_SCHEME_MEDICATION_BR_MEDICATION_RXNAME7A2( AV36Tcurrentcode) ;
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
               AV16iID = (long)(NumberUtil.Val( gxfirstwebparm, "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV16iID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV16iID), 18, 0)));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vIID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV16iID), "ZZZZZZZZZZZZZZZZZZ"), context));
               if ( StringUtil.StrCmp(gxfirstwebparm, "viewer") != 0 )
               {
                  AV15iType = GetNextPar( );
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV15iType", AV15iType);
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vITYPE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( AV15iType, "")), context));
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
         PA7A2( ) ;
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0));
         if ( ( gxajaxcallmode == 0 ) && ( GxWebError == 0 ) )
         {
            START7A2( ) ;
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
         context.AddJavascriptSource("gxcfg.js", "?202022815155660", false);
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" autocomplete=\"off\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("br_scheme_medicationupdate.aspx") + "?" + UrlEncode("" +AV16iID) + "," + UrlEncode(StringUtil.RTrim(AV15iType))+"\">") ;
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
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "Br_scheme", AV11BR_Scheme);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("Br_scheme", AV11BR_Scheme);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "Br_scheme_medication", AV10BR_Scheme_Medication);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("Br_scheme_medication", AV10BR_Scheme_Medication);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vBR_SCHEME_MEDICATION", AV10BR_Scheme_Medication);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vBR_SCHEME_MEDICATION", AV10BR_Scheme_Medication);
         }
         GxWebStd.gx_hidden_field( context, "vITYPE", AV15iType);
         GxWebStd.gx_hidden_field( context, "gxhash_vITYPE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( AV15iType, "")), context));
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vBR_SCHEME", AV11BR_Scheme);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vBR_SCHEME", AV11BR_Scheme);
         }
         GxWebStd.gx_hidden_field( context, "vIID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV16iID), 18, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "gxhash_vIID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV16iID), "ZZZZZZZZZZZZZZZZZZ"), context));
         GxWebStd.gx_hidden_field( context, "vTCURRENTCODE", StringUtil.LTrim( StringUtil.NToC( AV36Tcurrentcode, 10, 2, ".", "")));
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
         GxWebStd.gx_hidden_field( context, "vBR_SCHEME_MEDICATION_Br_medicationid", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV10BR_Scheme_Medication.gxTpr_Br_medicationid), 18, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "vBR_SCHEME_MEDICATION_Br_schemeid", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV10BR_Scheme_Medication.gxTpr_Br_schemeid), 18, 0, ".", "")));
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
            WE7A2( ) ;
            context.WriteHtmlText( "</div>") ;
         }
      }

      public override void DispatchEvents( )
      {
         EVT7A2( ) ;
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
         return formatLink("br_scheme_medicationupdate.aspx") + "?" + UrlEncode("" +AV16iID) + "," + UrlEncode(StringUtil.RTrim(AV15iType)) ;
      }

      public override String GetPgmname( )
      {
         return "BR_Scheme_MedicationUpdate" ;
      }

      public override String GetPgmdesc( )
      {
         return "Data Mgmt Portal - RAAP" ;
      }

      protected void WB7A0( )
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
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divUnnamedtablebr_scheme_br_scheme_chem_regimens_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-2 MergeLabelCell", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblockbr_scheme_br_scheme_chem_regimens_Internalname, "化疗方案", "", "", lblTextblockbr_scheme_br_scheme_chem_regimens_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_BR_Scheme_MedicationUpdate.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-10", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavBr_scheme_br_scheme_chem_regimens_Internalname, "化疗方案", "col-sm-3 ReadonlyAttributeLabel", 0, true);
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtavBr_scheme_br_scheme_chem_regimens_Internalname, AV11BR_Scheme.gxTpr_Br_scheme_chem_regimens, StringUtil.RTrim( context.localUtil.Format( AV11BR_Scheme.gxTpr_Br_scheme_chem_regimens, "")), "", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavBr_scheme_br_scheme_chem_regimens_Jsonclick, 0, "ReadonlyAttribute", "", "", "", "", 1, edtavBr_scheme_br_scheme_chem_regimens_Enabled, 0, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_BR_Scheme_MedicationUpdate.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 RequiredDataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divTablesplittedbr_scheme_medication_br_medicationid_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-2 MergeLabelCell", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblockbr_scheme_medication_br_medicationid_Internalname, "药物识别码", "", "", lblTextblockbr_scheme_medication_br_medicationid_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_BR_Scheme_MedicationUpdate.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-10", "left", "top", "", "", "div");
            wb_table1_37_7A2( true) ;
         }
         else
         {
            wb_table1_37_7A2( false) ;
         }
         return  ;
      }

      protected void wb_table1_37_7A2e( bool wbgen )
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
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divUnnamedtablevmedicationname_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-4 MergeLabelCell", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblockvmedicationname_Internalname, "药物名称", "", "", lblTextblockvmedicationname_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_BR_Scheme_MedicationUpdate.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-8", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavVmedicationname_Internalname, "v Medication Name", "col-sm-3 ReadonlyAttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 52,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavVmedicationname_Internalname, AV20vMedicationName, StringUtil.RTrim( context.localUtil.Format( AV20vMedicationName, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,52);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavVmedicationname_Jsonclick, 0, "ReadonlyAttribute", "", "", "", "", 1, edtavVmedicationname_Enabled, 0, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_BR_Scheme_MedicationUpdate.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divUnnamedtablevdose_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-4 MergeLabelCell", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblockvdose_Internalname, "药物剂量", "", "", lblTextblockvdose_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_BR_Scheme_MedicationUpdate.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-8", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavVdose_Internalname, "v Dose", "col-sm-3 ReadonlyAttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 60,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavVdose_Internalname, StringUtil.LTrim( StringUtil.NToC( AV21vDose, 15, 5, ".", "")), ((edtavVdose_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( AV21vDose, "ZZZZZZZZZ.ZZ")) : context.localUtil.Format( AV21vDose, "ZZZZZZZZZ.ZZ")), TempTags+" onchange=\""+"gx.num.valid_decimal( this, ',','.','5');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,60);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavVdose_Jsonclick, 0, "ReadonlyAttribute", "", "", "", "", 1, edtavVdose_Enabled, 0, "text", "", 15, "chr", 1, "row", 15, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_BR_Scheme_MedicationUpdate.htm");
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
            GxWebStd.gx_div_start( context, divUnnamedtablevunit_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-2 MergeLabelCell", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblockvunit_Internalname, "计量单位", "", "", lblTextblockvunit_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_BR_Scheme_MedicationUpdate.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-10", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavVunit_Internalname, "v Unit", "col-sm-3 ReadonlyAttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 69,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavVunit_Internalname, AV22vUnit, StringUtil.RTrim( context.localUtil.Format( AV22vUnit, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,69);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavVunit_Jsonclick, 0, "ReadonlyAttribute", "", "", "", "", 1, edtavVunit_Enabled, 0, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_BR_Scheme_MedicationUpdate.htm");
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
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 74,'',false,'',0)\"";
            ClassString = "ButtonMaterial";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtnenter_Internalname, "", bttBtnenter_Caption, bttBtnenter_Jsonclick, 5, "确认", "", StyleString, ClassString, 1, 1, "standard", "'"+""+"'"+",false,"+"'"+"EENTER."+"'", TempTags, "", context.GetButtonType( ), "HLP_BR_Scheme_MedicationUpdate.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 76,'',false,'',0)\"";
            ClassString = "ButtonMaterialDefault";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtncancel_Internalname, "", "取消", bttBtncancel_Jsonclick, 1, "取消", "", StyleString, ClassString, 1, 1, "standard", "'"+""+"'"+",false,"+"'"+"ECANCEL."+"'", TempTags, "", context.GetButtonType( ), "HLP_BR_Scheme_MedicationUpdate.htm");
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
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 80,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavBr_scheme_medication_br_scheme_medicationid_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV10BR_Scheme_Medication.gxTpr_Br_scheme_medicationid), 18, 0, ".", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(AV10BR_Scheme_Medication.gxTpr_Br_scheme_medicationid), "ZZZZZZZZZZZZZZZZZZ")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,80);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavBr_scheme_medication_br_scheme_medicationid_Jsonclick, 0, "Attribute", "", "", "", "", edtavBr_scheme_medication_br_scheme_medicationid_Visible, 1, 0, "number", "1", 18, "chr", 1, "row", 18, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_BR_Scheme_MedicationUpdate.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 81,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavBr_scheme_br_schemeid_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV11BR_Scheme.gxTpr_Br_schemeid), 18, 0, ".", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(AV11BR_Scheme.gxTpr_Br_schemeid), "ZZZZZZZZZZZZZZZZZZ")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,81);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavBr_scheme_br_schemeid_Jsonclick, 0, "Attribute", "", "", "", "", edtavBr_scheme_br_schemeid_Visible, 1, 0, "number", "1", 18, "chr", 1, "row", 18, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_BR_Scheme_MedicationUpdate.htm");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 82,'',false,'',0)\"";
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, dynavBr_scheme_medication_br_medication_rxname, dynavBr_scheme_medication_br_medication_rxname_Internalname, StringUtil.RTrim( AV10BR_Scheme_Medication.gxTpr_Br_medication_rxname), 1, dynavBr_scheme_medication_br_medication_rxname_Jsonclick, 0, "'"+""+"'"+",false,"+"'"+""+"'", "svchar", "", dynavBr_scheme_medication_br_medication_rxname.Visible, 1, 0, 0, 0, "em", 0, "", "", "Attribute", "", "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,82);\"", "", true, "HLP_BR_Scheme_MedicationUpdate.htm");
            dynavBr_scheme_medication_br_medication_rxname.CurrentValue = StringUtil.RTrim( AV10BR_Scheme_Medication.gxTpr_Br_medication_rxname);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynavBr_scheme_medication_br_medication_rxname_Internalname, "Values", (String)(dynavBr_scheme_medication_br_medication_rxname.ToJavascriptSource()), true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 83,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavBr_scheme_medication_br_medication_rxdose_Internalname, StringUtil.LTrim( StringUtil.NToC( AV10BR_Scheme_Medication.gxTpr_Br_medication_rxdose, 15, 5, ".", "")), StringUtil.LTrim( context.localUtil.Format( AV10BR_Scheme_Medication.gxTpr_Br_medication_rxdose, "ZZZZZZZZZ.ZZ")), TempTags+" onchange=\""+"gx.num.valid_decimal( this, ',','.','5');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,83);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavBr_scheme_medication_br_medication_rxdose_Jsonclick, 0, "Attribute", "", "", "", "", edtavBr_scheme_medication_br_medication_rxdose_Visible, 1, 0, "text", "", 15, "chr", 1, "row", 15, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_BR_Scheme_MedicationUpdate.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 84,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavBr_scheme_medication_br_medication_rxunit_Internalname, AV10BR_Scheme_Medication.gxTpr_Br_medication_rxunit, StringUtil.RTrim( context.localUtil.Format( AV10BR_Scheme_Medication.gxTpr_Br_medication_rxunit, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,84);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavBr_scheme_medication_br_medication_rxunit_Jsonclick, 0, "Attribute", "", "", "", "", edtavBr_scheme_medication_br_medication_rxunit_Visible, 1, 0, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_BR_Scheme_MedicationUpdate.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
         }
         wbLoad = true;
      }

      protected void START7A2( )
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
         STRUP7A0( ) ;
      }

      protected void WS7A2( )
      {
         START7A2( ) ;
         EVT7A2( ) ;
      }

      protected void EVT7A2( )
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
                              E117A2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "REFRESH") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              /* Execute user event: Refresh */
                              E127A2 ();
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
                                    E137A2 ();
                                 }
                                 dynload_actions( ) ;
                              }
                           }
                           else if ( StringUtil.StrCmp(sEvt, "PROMPT.CLICK") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E147A2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "LOAD") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              /* Execute user event: Load */
                              E157A2 ();
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

      protected void WE7A2( )
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

      protected void PA7A2( )
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
               GX_FocusControl = edtavBr_scheme_br_scheme_chem_regimens_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
            nDonePA = 1;
         }
      }

      protected void dynload_actions( )
      {
         /* End function dynload_actions */
      }

      protected void GXDLVBR_SCHEME_MEDICATION_BR_MEDICATION_RXNAME7A2( decimal AV36Tcurrentcode )
      {
         if ( ! context.isAjaxRequest( ) )
         {
            context.GX_webresponse.AppendHeader("Cache-Control", "no-store");
         }
         context.GX_webresponse.AddString("[[");
         GXDLVBR_SCHEME_MEDICATION_BR_MEDICATION_RXNAME_data7A2( AV36Tcurrentcode) ;
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

      protected void GXVBR_SCHEME_MEDICATION_BR_MEDICATION_RXNAME_html7A2( decimal AV36Tcurrentcode )
      {
         String gxdynajaxvalue ;
         GXDLVBR_SCHEME_MEDICATION_BR_MEDICATION_RXNAME_data7A2( AV36Tcurrentcode) ;
         gxdynajaxindex = 1;
         if ( ! ( gxdyncontrolsrefreshing && context.isAjaxRequest( ) ) )
         {
            dynavBr_scheme_medication_br_medication_rxname.removeAllItems();
         }
         while ( gxdynajaxindex <= gxdynajaxctrlcodr.Count )
         {
            gxdynajaxvalue = ((String)gxdynajaxctrlcodr.Item(gxdynajaxindex));
            dynavBr_scheme_medication_br_medication_rxname.addItem(gxdynajaxvalue, ((String)gxdynajaxctrldescr.Item(gxdynajaxindex)), 0);
            gxdynajaxindex = (int)(gxdynajaxindex+1);
         }
      }

      protected void GXDLVBR_SCHEME_MEDICATION_BR_MEDICATION_RXNAME_data7A2( decimal AV36Tcurrentcode )
      {
         gxdynajaxctrlcodr.Clear();
         gxdynajaxctrldescr.Clear();
         /* Using cursor H007A2 */
         pr_default.execute(0, new Object[] {AV36Tcurrentcode});
         while ( (pr_default.getStatus(0) != 101) )
         {
            gxdynajaxctrlcodr.Add(H007A2_A168XT_DefineCodeName[0]);
            gxdynajaxctrldescr.Add(H007A2_A168XT_DefineCodeName[0]);
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
         if ( dynavBr_scheme_medication_br_medication_rxname.ItemCount > 0 )
         {
            AV10BR_Scheme_Medication.gxTpr_Br_medication_rxname = dynavBr_scheme_medication_br_medication_rxname.getValidValue(AV10BR_Scheme_Medication.gxTpr_Br_medication_rxname);
         }
         if ( context.isAjaxRequest( ) )
         {
            dynavBr_scheme_medication_br_medication_rxname.CurrentValue = StringUtil.RTrim( AV10BR_Scheme_Medication.gxTpr_Br_medication_rxname);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynavBr_scheme_medication_br_medication_rxname_Internalname, "Values", dynavBr_scheme_medication_br_medication_rxname.ToJavascriptSource(), true);
         }
      }

      public void Refresh( )
      {
         send_integrity_hashes( ) ;
         RF7A2( ) ;
         if ( isFullAjaxMode( ) )
         {
            send_integrity_footer_hashes( ) ;
         }
      }

      protected void initialize_formulas( )
      {
         /* GeneXus formulas. */
         context.Gx_err = 0;
         edtavBr_scheme_br_scheme_chem_regimens_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavBr_scheme_br_scheme_chem_regimens_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavBr_scheme_br_scheme_chem_regimens_Enabled), 5, 0)), true);
         edtavVmedicationname_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavVmedicationname_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavVmedicationname_Enabled), 5, 0)), true);
         edtavVdose_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavVdose_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavVdose_Enabled), 5, 0)), true);
         edtavVunit_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavVunit_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavVunit_Enabled), 5, 0)), true);
      }

      protected void RF7A2( )
      {
         initialize_formulas( ) ;
         clear_multi_value_controls( ) ;
         /* Execute user event: Refresh */
         E127A2 ();
         gxdyncontrolsrefreshing = true;
         fix_multi_value_controls( ) ;
         gxdyncontrolsrefreshing = false;
         if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
         {
            /* Execute user event: Load */
            E157A2 ();
            WB7A0( ) ;
         }
      }

      protected void send_integrity_lvl_hashes7A2( )
      {
         GxWebStd.gx_hidden_field( context, "vITYPE", AV15iType);
         GxWebStd.gx_hidden_field( context, "gxhash_vITYPE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( AV15iType, "")), context));
      }

      protected void STRUP7A0( )
      {
         /* Before Start, stand alone formulas. */
         context.Gx_err = 0;
         edtavBr_scheme_br_scheme_chem_regimens_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavBr_scheme_br_scheme_chem_regimens_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavBr_scheme_br_scheme_chem_regimens_Enabled), 5, 0)), true);
         edtavVmedicationname_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavVmedicationname_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavVmedicationname_Enabled), 5, 0)), true);
         edtavVdose_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavVdose_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavVdose_Enabled), 5, 0)), true);
         edtavVunit_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavVunit_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavVunit_Enabled), 5, 0)), true);
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0;
         /* Execute user event: Start */
         E117A2 ();
         context.wbGlbDoneStart = 1;
         /* After Start, stand alone formulas. */
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read saved SDTs. */
            ajax_req_read_hidden_sdt(cgiGet( "Br_scheme"), AV11BR_Scheme);
            ajax_req_read_hidden_sdt(cgiGet( "Br_scheme_medication"), AV10BR_Scheme_Medication);
            /* Read variables values. */
            AV11BR_Scheme.gxTpr_Br_scheme_chem_regimens = cgiGet( edtavBr_scheme_br_scheme_chem_regimens_Internalname);
            if ( ( ( context.localUtil.CToN( cgiGet( edtavBr_scheme_medication_br_medicationid_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavBr_scheme_medication_br_medicationid_Internalname), ".", ",") > Convert.ToDecimal( 999999999999999999L )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "BR_SCHEME_MEDICATION_BR_MEDICATIONID");
               GX_FocusControl = edtavBr_scheme_medication_br_medicationid_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV10BR_Scheme_Medication.gxTpr_Br_medicationid = 0;
            }
            else
            {
               AV10BR_Scheme_Medication.gxTpr_Br_medicationid = (long)(context.localUtil.CToN( cgiGet( edtavBr_scheme_medication_br_medicationid_Internalname), ".", ","));
            }
            AV20vMedicationName = cgiGet( edtavVmedicationname_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV20vMedicationName", AV20vMedicationName);
            if ( ( ( context.localUtil.CToN( cgiGet( edtavVdose_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavVdose_Internalname), ".", ",") > 999999999.99999m ) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vVDOSE");
               GX_FocusControl = edtavVdose_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV21vDose = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV21vDose", StringUtil.LTrim( StringUtil.Str( AV21vDose, 15, 5)));
            }
            else
            {
               AV21vDose = context.localUtil.CToN( cgiGet( edtavVdose_Internalname), ".", ",");
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV21vDose", StringUtil.LTrim( StringUtil.Str( AV21vDose, 15, 5)));
            }
            AV22vUnit = cgiGet( edtavVunit_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV22vUnit", AV22vUnit);
            if ( ( ( context.localUtil.CToN( cgiGet( edtavBr_scheme_medication_br_scheme_medicationid_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavBr_scheme_medication_br_scheme_medicationid_Internalname), ".", ",") > Convert.ToDecimal( 999999999999999999L )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "BR_SCHEME_MEDICATION_BR_SCHEME_MEDICATIONID");
               GX_FocusControl = edtavBr_scheme_medication_br_scheme_medicationid_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV10BR_Scheme_Medication.gxTpr_Br_scheme_medicationid = 0;
            }
            else
            {
               AV10BR_Scheme_Medication.gxTpr_Br_scheme_medicationid = (long)(context.localUtil.CToN( cgiGet( edtavBr_scheme_medication_br_scheme_medicationid_Internalname), ".", ","));
            }
            if ( ( ( context.localUtil.CToN( cgiGet( edtavBr_scheme_br_schemeid_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavBr_scheme_br_schemeid_Internalname), ".", ",") > Convert.ToDecimal( 999999999999999999L )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "BR_SCHEME_BR_SCHEMEID");
               GX_FocusControl = edtavBr_scheme_br_schemeid_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV11BR_Scheme.gxTpr_Br_schemeid = 0;
            }
            else
            {
               AV11BR_Scheme.gxTpr_Br_schemeid = (long)(context.localUtil.CToN( cgiGet( edtavBr_scheme_br_schemeid_Internalname), ".", ","));
            }
            dynavBr_scheme_medication_br_medication_rxname.CurrentValue = cgiGet( dynavBr_scheme_medication_br_medication_rxname_Internalname);
            AV10BR_Scheme_Medication.gxTpr_Br_medication_rxname = cgiGet( dynavBr_scheme_medication_br_medication_rxname_Internalname);
            if ( ( ( context.localUtil.CToN( cgiGet( edtavBr_scheme_medication_br_medication_rxdose_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavBr_scheme_medication_br_medication_rxdose_Internalname), ".", ",") > 999999999.99999m ) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "BR_SCHEME_MEDICATION_BR_MEDICATION_RXDOSE");
               GX_FocusControl = edtavBr_scheme_medication_br_medication_rxdose_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV10BR_Scheme_Medication.gxTpr_Br_medication_rxdose = 0;
            }
            else
            {
               AV10BR_Scheme_Medication.gxTpr_Br_medication_rxdose = context.localUtil.CToN( cgiGet( edtavBr_scheme_medication_br_medication_rxdose_Internalname), ".", ",");
            }
            AV10BR_Scheme_Medication.gxTpr_Br_medication_rxunit = cgiGet( edtavBr_scheme_medication_br_medication_rxunit_Internalname);
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
         E117A2 ();
         if (returnInSub) return;
      }

      protected void E117A2( )
      {
         /* Start Routine */
         edtavBr_scheme_medication_br_scheme_medicationid_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavBr_scheme_medication_br_scheme_medicationid_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavBr_scheme_medication_br_scheme_medicationid_Visible), 5, 0)), true);
         edtavBr_scheme_br_schemeid_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavBr_scheme_br_schemeid_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavBr_scheme_br_schemeid_Visible), 5, 0)), true);
         dynavBr_scheme_medication_br_medication_rxname.Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynavBr_scheme_medication_br_medication_rxname_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(dynavBr_scheme_medication_br_medication_rxname.Visible), 5, 0)), true);
         edtavBr_scheme_medication_br_medication_rxdose_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavBr_scheme_medication_br_medication_rxdose_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavBr_scheme_medication_br_medication_rxdose_Visible), 5, 0)), true);
         edtavBr_scheme_medication_br_medication_rxunit_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavBr_scheme_medication_br_medication_rxunit_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavBr_scheme_medication_br_medication_rxunit_Visible), 5, 0)), true);
         if ( StringUtil.StrCmp(AV15iType, "update") == 0 )
         {
            AV10BR_Scheme_Medication.Load(AV16iID);
            AV11BR_Scheme.gxTpr_Br_scheme_chem_regimens = AV10BR_Scheme_Medication.gxTpr_Br_scheme_chem_regimens;
            AV20vMedicationName = AV10BR_Scheme_Medication.gxTpr_Br_medication_rxname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV20vMedicationName", AV20vMedicationName);
            AV21vDose = AV10BR_Scheme_Medication.gxTpr_Br_medication_rxdose;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV21vDose", StringUtil.LTrim( StringUtil.Str( AV21vDose, 15, 5)));
            AV22vUnit = AV10BR_Scheme_Medication.gxTpr_Br_medication_rxunit;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV22vUnit", AV22vUnit);
         }
         else
         {
            AV11BR_Scheme.Load(AV16iID);
         }
         if ( StringUtil.StrCmp(AV15iType, "delete") == 0 )
         {
            AV10BR_Scheme_Medication.Load(AV16iID);
            AV11BR_Scheme.gxTpr_Br_scheme_chem_regimens = AV10BR_Scheme_Medication.gxTpr_Br_scheme_chem_regimens;
            AV20vMedicationName = AV10BR_Scheme_Medication.gxTpr_Br_medication_rxname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV20vMedicationName", AV20vMedicationName);
            AV21vDose = AV10BR_Scheme_Medication.gxTpr_Br_medication_rxdose;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV21vDose", StringUtil.LTrim( StringUtil.Str( AV21vDose, 15, 5)));
            AV22vUnit = AV10BR_Scheme_Medication.gxTpr_Br_medication_rxunit;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV22vUnit", AV22vUnit);
            bttBtnenter_Caption = "确认";
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtnenter_Internalname, "Caption", bttBtnenter_Caption, true);
            imgPrompt_Visible = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgPrompt_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(imgPrompt_Visible), 5, 0)), true);
            GX_msglist.addItem("确认删除.");
         }
         else
         {
            AV11BR_Scheme.Load(AV16iID);
         }
      }

      protected void S112( )
      {
         /* 'CHECKREQUIREDFIELDS' Routine */
         AV17CheckRequiredFieldsResult = true;
         if ( (0==AV10BR_Scheme_Medication.gxTpr_Br_medicationid) )
         {
            GX_msglist.addItem("药物识别码是必须选择的");
            AV17CheckRequiredFieldsResult = false;
         }
      }

      protected void S122( )
      {
         /* 'SHOW MESSAGES' Routine */
         AV33GXV8 = 1;
         while ( AV33GXV8 <= AV8Messages.Count )
         {
            AV7Message = ((SdtMessages_Message)AV8Messages.Item(AV33GXV8));
            GX_msglist.addItem(AV7Message.gxTpr_Description);
            AV33GXV8 = (int)(AV33GXV8+1);
         }
      }

      protected void E127A2( )
      {
         /* Refresh Routine */
         new GeneXus.Programs.wwpbaseobjects.loadwwpcontext(context ).execute( out  AV9Context) ;
      }

      public void GXEnter( )
      {
         /* Execute user event: Enter */
         E137A2 ();
         if (returnInSub) return;
      }

      protected void E137A2( )
      {
         /* Enter Routine */
         new zutil_checksession(context ).execute( out  AV23tCheckFlag) ;
         if ( ! AV23tCheckFlag )
         {
            AV13tFlag = true;
            if ( (0==AV10BR_Scheme_Medication.gxTpr_Br_medicationid) )
            {
               GX_msglist.addItem("请选择药物识别码");
               AV13tFlag = false;
            }
            if ( AV13tFlag )
            {
               AV14BCBR_Medication.Load(AV10BR_Scheme_Medication.gxTpr_Br_medicationid);
               if ( StringUtil.StrCmp(AV15iType, "insert") == 0 )
               {
                  if ( AV11BR_Scheme.gxTpr_Br_encounterid != AV14BCBR_Medication.gxTpr_Br_encounterid )
                  {
                     GX_msglist.addItem("请填写该就诊信息内的药物识别码");
                     AV13tFlag = false;
                  }
               }
               else
               {
                  AV11BR_Scheme.Load(AV10BR_Scheme_Medication.gxTpr_Br_schemeid);
                  if ( AV11BR_Scheme.gxTpr_Br_encounterid != AV14BCBR_Medication.gxTpr_Br_encounterid )
                  {
                     GX_msglist.addItem("请填写该就诊信息内的药物识别码");
                     AV13tFlag = false;
                  }
               }
            }
            if ( StringUtil.StrCmp(AV15iType, "insert") == 0 )
            {
               AV10BR_Scheme_Medication.gxTpr_Br_schemeid = AV11BR_Scheme.gxTpr_Br_schemeid;
            }
            if ( StringUtil.StrCmp(AV15iType, "delete") == 0 )
            {
               AV10BR_Scheme_Medication.Delete();
               context.CommitDataStores("br_scheme_medicationupdate",pr_default);
               context.setWebReturnParms(new Object[] {});
               context.setWebReturnParmsMetadata(new Object[] {});
               context.wjLocDisableFrm = 1;
               context.nUserReturn = 1;
               returnInSub = true;
               if (true) return;
            }
            if ( AV13tFlag )
            {
               AV10BR_Scheme_Medication.Save();
               if ( AV10BR_Scheme_Medication.Success() )
               {
                  context.CommitDataStores("br_scheme_medicationupdate",pr_default);
                  context.setWebReturnParms(new Object[] {});
                  context.setWebReturnParmsMetadata(new Object[] {});
                  context.wjLocDisableFrm = 1;
                  context.nUserReturn = 1;
                  returnInSub = true;
                  if (true) return;
               }
               else
               {
                  AV18Errormsg = "";
                  AV35GXV10 = 1;
                  AV34GXV9 = AV10BR_Scheme_Medication.GetMessages();
                  while ( AV35GXV10 <= AV34GXV9.Count )
                  {
                     AV7Message = ((SdtMessages_Message)AV34GXV9.Item(AV35GXV10));
                     AV18Errormsg = AV18Errormsg + StringUtil.Trim( AV7Message.gxTpr_Description);
                     AV35GXV10 = (int)(AV35GXV10+1);
                  }
                  GX_msglist.addItem(AV18Errormsg);
               }
            }
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV11BR_Scheme", AV11BR_Scheme);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV10BR_Scheme_Medication", AV10BR_Scheme_Medication);
      }

      protected void E147A2( )
      {
         /* Prompt_Click Routine */
         new zutil_checksession(context ).execute( out  AV23tCheckFlag) ;
         if ( ! AV23tCheckFlag )
         {
            context.PopUp(formatLink("br_medicationpromptitl.aspx") + "?" + UrlEncode(StringUtil.RTrim("")) + "," + UrlEncode(StringUtil.RTrim("")) + "," + UrlEncode(StringUtil.RTrim("")) + "," + UrlEncode(StringUtil.RTrim("")) + "," + UrlEncode(StringUtil.RTrim("")) + "," + UrlEncode(StringUtil.RTrim("")) + "," + UrlEncode(StringUtil.RTrim("")), new Object[] {"GXV2","GXV5","GXV6","GXV7","AV20vMedicationName","AV21vDose","AV22vUnit"});
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV10BR_Scheme_Medication", AV10BR_Scheme_Medication);
      }

      protected void nextLoad( )
      {
      }

      protected void E157A2( )
      {
         /* Load Routine */
      }

      protected void wb_table1_37_7A2( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "";
            GxWebStd.gx_table_start( context, tblTablemergedbr_scheme_medication_br_medicationid_Internalname, tblTablemergedbr_scheme_medication_br_medicationid_Internalname, "", "TableMerged", 0, "", "", 0, 0, sStyleString, "", "", 0);
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td class='MergeDataCell'>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavBr_scheme_medication_br_medicationid_Internalname, "药物治疗主键", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 41,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavBr_scheme_medication_br_medicationid_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV10BR_Scheme_Medication.gxTpr_Br_medicationid), 18, 0, ".", "")), ((edtavBr_scheme_medication_br_medicationid_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(AV10BR_Scheme_Medication.gxTpr_Br_medicationid), "ZZZZZZZZZZZZZZZZZZ")) : context.localUtil.Format( (decimal)(AV10BR_Scheme_Medication.gxTpr_Br_medicationid), "ZZZZZZZZZZZZZZZZZZ")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,41);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavBr_scheme_medication_br_medicationid_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtavBr_scheme_medication_br_medicationid_Enabled, 0, "number", "1", 18, "chr", 1, "row", 18, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_BR_Scheme_MedicationUpdate.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 43,'',false,'',0)\"";
            ClassString = "btn-default";
            StyleString = "";
            sImgUrl = (String)(context.GetImagePath( "f5b04895-0024-488b-8e3b-b687ca4598ee", "", context.GetTheme( )));
            GxWebStd.gx_bitmap( context, imgPrompt_Internalname, sImgUrl, "", "", "", context.GetTheme( ), imgPrompt_Visible, 1, "", "", 0, 0, 0, "px", 0, "px", 0, 0, 5, imgPrompt_Jsonclick, "'"+""+"'"+",false,"+"'"+"EPROMPT.CLICK."+"'", StyleString, ClassString, "", "", "", "", " "+"data-gx-image"+" "+TempTags, "", "", 1, false, false, context.GetImageSrcSet( sImgUrl), "HLP_BR_Scheme_MedicationUpdate.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table1_37_7A2e( true) ;
         }
         else
         {
            wb_table1_37_7A2e( false) ;
         }
      }

      public override void setparameters( Object[] obj )
      {
         createObjects();
         initialize();
         AV16iID = Convert.ToInt64(getParm(obj,0));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV16iID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV16iID), 18, 0)));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vIID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV16iID), "ZZZZZZZZZZZZZZZZZZ"), context));
         AV15iType = (String)getParm(obj,1);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV15iType", AV15iType);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vITYPE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( AV15iType, "")), context));
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
         PA7A2( ) ;
         WS7A2( ) ;
         WE7A2( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?202022815155817", true);
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
         context.AddJavascriptSource("br_scheme_medicationupdate.js", "?202022815155818", false);
         context.AddJavascriptSource("DVelop/Bootstrap/Shared/DVelopBootstrap.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/Panel/BootstrapPanelRender.js", "", false);
         /* End function include_jscripts */
      }

      protected void init_web_controls( )
      {
         dynavBr_scheme_medication_br_medication_rxname.Name = "BR_SCHEME_MEDICATION_BR_MEDICATION_RXNAME";
         dynavBr_scheme_medication_br_medication_rxname.WebTags = "";
         /* End function init_web_controls */
      }

      protected void init_default_properties( )
      {
         lblTextblockbr_scheme_br_scheme_chem_regimens_Internalname = "TEXTBLOCKBR_SCHEME_BR_SCHEME_CHEM_REGIMENS";
         edtavBr_scheme_br_scheme_chem_regimens_Internalname = "BR_SCHEME_BR_SCHEME_CHEM_REGIMENS";
         divUnnamedtablebr_scheme_br_scheme_chem_regimens_Internalname = "UNNAMEDTABLEBR_SCHEME_BR_SCHEME_CHEM_REGIMENS";
         lblTextblockbr_scheme_medication_br_medicationid_Internalname = "TEXTBLOCKBR_SCHEME_MEDICATION_BR_MEDICATIONID";
         edtavBr_scheme_medication_br_medicationid_Internalname = "BR_SCHEME_MEDICATION_BR_MEDICATIONID";
         imgPrompt_Internalname = "PROMPT";
         tblTablemergedbr_scheme_medication_br_medicationid_Internalname = "TABLEMERGEDBR_SCHEME_MEDICATION_BR_MEDICATIONID";
         divTablesplittedbr_scheme_medication_br_medicationid_Internalname = "TABLESPLITTEDBR_SCHEME_MEDICATION_BR_MEDICATIONID";
         lblTextblockvmedicationname_Internalname = "TEXTBLOCKVMEDICATIONNAME";
         edtavVmedicationname_Internalname = "vVMEDICATIONNAME";
         divUnnamedtablevmedicationname_Internalname = "UNNAMEDTABLEVMEDICATIONNAME";
         lblTextblockvdose_Internalname = "TEXTBLOCKVDOSE";
         edtavVdose_Internalname = "vVDOSE";
         divUnnamedtablevdose_Internalname = "UNNAMEDTABLEVDOSE";
         lblTextblockvunit_Internalname = "TEXTBLOCKVUNIT";
         edtavVunit_Internalname = "vVUNIT";
         divUnnamedtablevunit_Internalname = "UNNAMEDTABLEVUNIT";
         divTableattributes_Internalname = "TABLEATTRIBUTES";
         divLayout_tableattributes_Internalname = "LAYOUT_TABLEATTRIBUTES";
         Dvpanel_tableattributes_Internalname = "DVPANEL_TABLEATTRIBUTES";
         divHtml_dvpanel_tableattributes_Internalname = "HTML_DVPANEL_TABLEATTRIBUTES";
         divTablecontent_Internalname = "TABLECONTENT";
         bttBtnenter_Internalname = "BTNENTER";
         bttBtncancel_Internalname = "BTNCANCEL";
         divTablemain_Internalname = "TABLEMAIN";
         edtavBr_scheme_medication_br_scheme_medicationid_Internalname = "BR_SCHEME_MEDICATION_BR_SCHEME_MEDICATIONID";
         edtavBr_scheme_br_schemeid_Internalname = "BR_SCHEME_BR_SCHEMEID";
         dynavBr_scheme_medication_br_medication_rxname_Internalname = "BR_SCHEME_MEDICATION_BR_MEDICATION_RXNAME";
         edtavBr_scheme_medication_br_medication_rxdose_Internalname = "BR_SCHEME_MEDICATION_BR_MEDICATION_RXDOSE";
         edtavBr_scheme_medication_br_medication_rxunit_Internalname = "BR_SCHEME_MEDICATION_BR_MEDICATION_RXUNIT";
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
         imgPrompt_Visible = 1;
         edtavBr_scheme_medication_br_medicationid_Jsonclick = "";
         edtavBr_scheme_medication_br_medicationid_Enabled = 1;
         edtavBr_scheme_br_scheme_chem_regimens_Enabled = -1;
         edtavBr_scheme_medication_br_medication_rxunit_Jsonclick = "";
         edtavBr_scheme_medication_br_medication_rxunit_Visible = 1;
         edtavBr_scheme_medication_br_medication_rxdose_Jsonclick = "";
         edtavBr_scheme_medication_br_medication_rxdose_Visible = 1;
         dynavBr_scheme_medication_br_medication_rxname_Jsonclick = "";
         dynavBr_scheme_medication_br_medication_rxname.Visible = 1;
         edtavBr_scheme_br_schemeid_Jsonclick = "";
         edtavBr_scheme_br_schemeid_Visible = 1;
         edtavBr_scheme_medication_br_scheme_medicationid_Jsonclick = "";
         edtavBr_scheme_medication_br_scheme_medicationid_Visible = 1;
         bttBtnenter_Caption = "保存";
         edtavVunit_Jsonclick = "";
         edtavVunit_Enabled = 1;
         edtavVdose_Jsonclick = "";
         edtavVdose_Enabled = 1;
         edtavVmedicationname_Jsonclick = "";
         edtavVmedicationname_Enabled = 1;
         edtavBr_scheme_br_scheme_chem_regimens_Jsonclick = "";
         edtavBr_scheme_br_scheme_chem_regimens_Enabled = 0;
         Dvpanel_tableattributes_Autoscroll = Convert.ToBoolean( 0);
         Dvpanel_tableattributes_Iconposition = "left";
         Dvpanel_tableattributes_Showcollapseicon = Convert.ToBoolean( 0);
         Dvpanel_tableattributes_Autoheight = Convert.ToBoolean( -1);
         Dvpanel_tableattributes_Autowidth = Convert.ToBoolean( 0);
         Dvpanel_tableattributes_Collapsed = Convert.ToBoolean( 0);
         Dvpanel_tableattributes_Collapsible = Convert.ToBoolean( 0);
         Dvpanel_tableattributes_Title = "化疗方案药物详情";
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
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[{av:'AV15iType',fld:'vITYPE',pic:'',hsh:true},{av:'AV16iID',fld:'vIID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true}]");
         setEventMetadata("REFRESH",",oparms:[]}");
         setEventMetadata("ENTER","{handler:'E137A2',iparms:[{av:'AV10BR_Scheme_Medication',fld:'vBR_SCHEME_MEDICATION',pic:''},{av:'AV15iType',fld:'vITYPE',pic:'',hsh:true},{av:'AV11BR_Scheme',fld:'vBR_SCHEME',pic:''}]");
         setEventMetadata("ENTER",",oparms:[{av:'AV11BR_Scheme',fld:'vBR_SCHEME',pic:''},{av:'AV10BR_Scheme_Medication',fld:'vBR_SCHEME_MEDICATION',pic:''}]}");
         setEventMetadata("PROMPT.CLICK","{handler:'E147A2',iparms:[{av:'AV10BR_Scheme_Medication',fld:'vBR_SCHEME_MEDICATION',pic:''}]");
         setEventMetadata("PROMPT.CLICK",",oparms:[{av:'AV22vUnit',fld:'vVUNIT',pic:''},{av:'AV21vDose',fld:'vVDOSE',pic:'ZZZZZZZZZ.ZZ'},{av:'AV20vMedicationName',fld:'vVMEDICATIONNAME',pic:''},{av:'AV10BR_Scheme_Medication',fld:'vBR_SCHEME_MEDICATION',pic:''}]}");
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
         wcpOAV15iType = "";
         AV10BR_Scheme_Medication = new SdtBR_Scheme_Medication(context);
         gxfirstwebparm = "";
         gxfirstwebparm_bkp = "";
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         GXKey = "";
         AV11BR_Scheme = new SdtBR_Scheme(context);
         GX_FocusControl = "";
         Form = new GXWebForm();
         sPrefix = "";
         ClassString = "";
         StyleString = "";
         ucDvpanel_tableattributes = new GXUserControl();
         lblTextblockbr_scheme_br_scheme_chem_regimens_Jsonclick = "";
         lblTextblockbr_scheme_medication_br_medicationid_Jsonclick = "";
         lblTextblockvmedicationname_Jsonclick = "";
         TempTags = "";
         AV20vMedicationName = "";
         lblTextblockvdose_Jsonclick = "";
         lblTextblockvunit_Jsonclick = "";
         AV22vUnit = "";
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
         H007A2_A167XT_DefineCodeID = new long[1] ;
         H007A2_A168XT_DefineCodeName = new String[] {""} ;
         H007A2_n168XT_DefineCodeName = new bool[] {false} ;
         H007A2_A165XT_DefindcodeTypeID = new long[1] ;
         H007A2_A432XT_TenantCode = new String[] {""} ;
         H007A2_n432XT_TenantCode = new bool[] {false} ;
         AV8Messages = new GXBaseCollection<SdtMessages_Message>( context, "Message", "GeneXus");
         AV7Message = new SdtMessages_Message(context);
         AV9Context = new GeneXus.Programs.wwpbaseobjects.SdtWWPContext(context);
         AV14BCBR_Medication = new SdtBR_Medication(context);
         AV18Errormsg = "";
         AV34GXV9 = new GXBaseCollection<SdtMessages_Message>( context, "Message", "GeneXus");
         sStyleString = "";
         sImgUrl = "";
         imgPrompt_Jsonclick = "";
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         pr_datastore1 = new DataStoreProvider(context, new GeneXus.Programs.br_scheme_medicationupdate__datastore1(),
            new Object[][] {
            }
         );
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.br_scheme_medicationupdate__default(),
            new Object[][] {
                new Object[] {
               H007A2_A167XT_DefineCodeID, H007A2_A168XT_DefineCodeName, H007A2_n168XT_DefineCodeName, H007A2_A165XT_DefindcodeTypeID, H007A2_A432XT_TenantCode, H007A2_n432XT_TenantCode
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0;
         edtavBr_scheme_br_scheme_chem_regimens_Enabled = 0;
         edtavVmedicationname_Enabled = 0;
         edtavVdose_Enabled = 0;
         edtavVunit_Enabled = 0;
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
      private int edtavBr_scheme_br_scheme_chem_regimens_Enabled ;
      private int edtavVmedicationname_Enabled ;
      private int edtavVdose_Enabled ;
      private int edtavVunit_Enabled ;
      private int edtavBr_scheme_medication_br_scheme_medicationid_Visible ;
      private int edtavBr_scheme_br_schemeid_Visible ;
      private int edtavBr_scheme_medication_br_medication_rxdose_Visible ;
      private int edtavBr_scheme_medication_br_medication_rxunit_Visible ;
      private int gxdynajaxindex ;
      private int imgPrompt_Visible ;
      private int AV33GXV8 ;
      private int AV35GXV10 ;
      private int edtavBr_scheme_medication_br_medicationid_Enabled ;
      private int idxLst ;
      private long AV16iID ;
      private long wcpOAV16iID ;
      private decimal AV36Tcurrentcode ;
      private decimal AV21vDose ;
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
      private String divUnnamedtablebr_scheme_br_scheme_chem_regimens_Internalname ;
      private String lblTextblockbr_scheme_br_scheme_chem_regimens_Internalname ;
      private String lblTextblockbr_scheme_br_scheme_chem_regimens_Jsonclick ;
      private String edtavBr_scheme_br_scheme_chem_regimens_Internalname ;
      private String edtavBr_scheme_br_scheme_chem_regimens_Jsonclick ;
      private String divTablesplittedbr_scheme_medication_br_medicationid_Internalname ;
      private String lblTextblockbr_scheme_medication_br_medicationid_Internalname ;
      private String lblTextblockbr_scheme_medication_br_medicationid_Jsonclick ;
      private String divUnnamedtablevmedicationname_Internalname ;
      private String lblTextblockvmedicationname_Internalname ;
      private String lblTextblockvmedicationname_Jsonclick ;
      private String edtavVmedicationname_Internalname ;
      private String TempTags ;
      private String edtavVmedicationname_Jsonclick ;
      private String divUnnamedtablevdose_Internalname ;
      private String lblTextblockvdose_Internalname ;
      private String lblTextblockvdose_Jsonclick ;
      private String edtavVdose_Internalname ;
      private String edtavVdose_Jsonclick ;
      private String divUnnamedtablevunit_Internalname ;
      private String lblTextblockvunit_Internalname ;
      private String lblTextblockvunit_Jsonclick ;
      private String edtavVunit_Internalname ;
      private String edtavVunit_Jsonclick ;
      private String bttBtnenter_Internalname ;
      private String bttBtnenter_Caption ;
      private String bttBtnenter_Jsonclick ;
      private String bttBtncancel_Internalname ;
      private String bttBtncancel_Jsonclick ;
      private String divHtml_bottomauxiliarcontrols_Internalname ;
      private String edtavBr_scheme_medication_br_scheme_medicationid_Internalname ;
      private String edtavBr_scheme_medication_br_scheme_medicationid_Jsonclick ;
      private String edtavBr_scheme_br_schemeid_Internalname ;
      private String edtavBr_scheme_br_schemeid_Jsonclick ;
      private String dynavBr_scheme_medication_br_medication_rxname_Internalname ;
      private String dynavBr_scheme_medication_br_medication_rxname_Jsonclick ;
      private String edtavBr_scheme_medication_br_medication_rxdose_Internalname ;
      private String edtavBr_scheme_medication_br_medication_rxdose_Jsonclick ;
      private String edtavBr_scheme_medication_br_medication_rxunit_Internalname ;
      private String edtavBr_scheme_medication_br_medication_rxunit_Jsonclick ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String gxwrpcisep ;
      private String scmdbuf ;
      private String edtavBr_scheme_medication_br_medicationid_Internalname ;
      private String imgPrompt_Internalname ;
      private String sStyleString ;
      private String tblTablemergedbr_scheme_medication_br_medicationid_Internalname ;
      private String edtavBr_scheme_medication_br_medicationid_Jsonclick ;
      private String sImgUrl ;
      private String imgPrompt_Jsonclick ;
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
      private bool AV17CheckRequiredFieldsResult ;
      private bool AV23tCheckFlag ;
      private bool AV13tFlag ;
      private String AV15iType ;
      private String wcpOAV15iType ;
      private String AV20vMedicationName ;
      private String AV22vUnit ;
      private String AV18Errormsg ;
      private GeneXus.Utils.GxStringCollection gxdynajaxctrlcodr ;
      private GeneXus.Utils.GxStringCollection gxdynajaxctrldescr ;
      private GXUserControl ucDvpanel_tableattributes ;
      private IGxDataStore dsDataStore1 ;
      private IGxDataStore dsDefault ;
      private GXCombobox dynavBr_scheme_medication_br_medication_rxname ;
      private IDataStoreProvider pr_default ;
      private long[] H007A2_A167XT_DefineCodeID ;
      private String[] H007A2_A168XT_DefineCodeName ;
      private bool[] H007A2_n168XT_DefineCodeName ;
      private long[] H007A2_A165XT_DefindcodeTypeID ;
      private String[] H007A2_A432XT_TenantCode ;
      private bool[] H007A2_n432XT_TenantCode ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private IDataStoreProvider pr_datastore1 ;
      private GXBaseCollection<SdtMessages_Message> AV8Messages ;
      private GXBaseCollection<SdtMessages_Message> AV34GXV9 ;
      private GXWebForm Form ;
      private SdtMessages_Message AV7Message ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPContext AV9Context ;
      private SdtBR_Scheme_Medication AV10BR_Scheme_Medication ;
      private SdtBR_Scheme AV11BR_Scheme ;
      private SdtBR_Medication AV14BCBR_Medication ;
   }

   public class br_scheme_medicationupdate__datastore1 : DataStoreHelperBase, IDataStoreHelper
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

 public class br_scheme_medicationupdate__default : DataStoreHelperBase, IDataStoreHelper
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
        Object[] prmH007A2 ;
        prmH007A2 = new Object[] {
        new Object[] {"@AV36Tcurrentcode",SqlDbType.Decimal,10,2}
        } ;
        def= new CursorDef[] {
            new CursorDef("H007A2", "SELECT [XT_DefineCodeID], [XT_DefineCodeName], [XT_DefindcodeTypeID], [XT_TenantCode] FROM [XT_DefineCode] WITH (NOLOCK) WHERE ([XT_DefindcodeTypeID] = 33) AND ([XT_TenantCode] = @AV36Tcurrentcode) ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH007A2,0,0,true,false )
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
              stmt.SetParameter(1, (decimal)parms[0]);
              return;
     }
  }

}

}
