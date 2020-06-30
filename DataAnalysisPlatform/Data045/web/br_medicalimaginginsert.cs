/*
               File: BR_MedicalImagingInsert
        Description:
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/28/2020 15:17:5.50
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
   public class br_medicalimaginginsert : GXDataArea, System.Web.SessionState.IRequiresSessionState
   {
      public br_medicalimaginginsert( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public br_medicalimaginginsert( IGxContext context )
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
         this.AV18BR_EncounterID = aP0_BR_EncounterID;
         executePrivate();
      }

      void executePrivate( )
      {
         isStatic = false;
         webExecute();
      }

      protected override void createObjects( )
      {
         dynavVname = new GXCombobox();
         dynavBr_medicalimaging_br_medicalimaging_imagehosp = new GXCombobox();
         cmbavVmetastasesdx = new GXCombobox();
         dynavWzname = new GXCombobox();
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
            else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxCallCrl"+"_"+"vVNAME") == 0 )
            {
               AV17tCurrentCode = GetNextPar( );
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1;
                  return  ;
               }
               GXDLVvVNAME972( AV17tCurrentCode) ;
               return  ;
            }
            else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxCallCrl"+"_"+"BR_MEDICALIMAGING_BR_MEDICALIMAGING_IMAGEHOSP") == 0 )
            {
               AV17tCurrentCode = GetNextPar( );
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1;
                  return  ;
               }
               GXDLVBR_MEDICALIMAGING_BR_MEDICALIMAGING_IMAGEHOSP972( AV17tCurrentCode) ;
               return  ;
            }
            else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxCallCrl"+"_"+"vWZNAME") == 0 )
            {
               AV17tCurrentCode = GetNextPar( );
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1;
                  return  ;
               }
               GXDLVvWZNAME972( AV17tCurrentCode) ;
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
               AV18BR_EncounterID = (long)(NumberUtil.Val( gxfirstwebparm, "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV18BR_EncounterID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV18BR_EncounterID), 18, 0)));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vBR_ENCOUNTERID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV18BR_EncounterID), "ZZZZZZZZZZZZZZZZZZ"), context));
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
         PA972( ) ;
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0));
         if ( ( gxajaxcallmode == 0 ) && ( GxWebError == 0 ) )
         {
            START972( ) ;
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
         context.AddJavascriptSource("gxcfg.js", "?20202281517561", false);
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" autocomplete=\"off\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("br_medicalimaginginsert.aspx") + "?" + UrlEncode("" +AV18BR_EncounterID)+"\">") ;
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
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "Br_medicalimaging", AV10BR_MedicalImaging);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("Br_medicalimaging", AV10BR_MedicalImaging);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vBR_MEDICALIMAGING", AV10BR_MedicalImaging);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vBR_MEDICALIMAGING", AV10BR_MedicalImaging);
         }
         GxWebStd.gx_hidden_field( context, "vBR_ENCOUNTERID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV18BR_EncounterID), 18, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "gxhash_vBR_ENCOUNTERID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV18BR_EncounterID), "ZZZZZZZZZZZZZZZZZZ"), context));
         GxWebStd.gx_hidden_field( context, "vTCURRENTCODE", AV17tCurrentCode);
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
            WE972( ) ;
            context.WriteHtmlText( "</div>") ;
         }
      }

      public override void DispatchEvents( )
      {
         EVT972( ) ;
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
         return formatLink("br_medicalimaginginsert.aspx") + "?" + UrlEncode("" +AV18BR_EncounterID) ;
      }

      public override String GetPgmname( )
      {
         return "BR_MedicalImagingInsert" ;
      }

      public override String GetPgmdesc( )
      {
         return "" ;
      }

      protected void WB970( )
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
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
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
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 RequiredDataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtavBr_medicalimaging_br_medicalimaging_no_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavBr_medicalimaging_br_medicalimaging_no_Internalname, "编号", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 25,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavBr_medicalimaging_br_medicalimaging_no_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV10BR_MedicalImaging.gxTpr_Br_medicalimaging_no), 18, 0, ".", "")), ((edtavBr_medicalimaging_br_medicalimaging_no_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(AV10BR_MedicalImaging.gxTpr_Br_medicalimaging_no), "ZZZZZZZZZZZZZZZZZZ")) : context.localUtil.Format( (decimal)(AV10BR_MedicalImaging.gxTpr_Br_medicalimaging_no), "ZZZZZZZZZZZZZZZZZZ")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,25);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavBr_medicalimaging_br_medicalimaging_no_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtavBr_medicalimaging_br_medicalimaging_no_Enabled, 0, "number", "1", 18, "chr", 1, "row", 18, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_BR_MedicalImagingInsert.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 RequiredDataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divTablesplittedvname_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-3 MergeLabelCell", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblockvname_Internalname, "影像名称", "", "", lblTextblockvname_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_BR_MedicalImagingInsert.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-9", "left", "top", "", "", "div");
            wb_table1_32_972( true) ;
         }
         else
         {
            wb_table1_32_972( false) ;
         }
         return  ;
      }

      protected void wb_table1_32_972e( bool wbgen )
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
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtavBr_medicalimaging_br_medicalimaging_imagedate_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavBr_medicalimaging_br_medicalimaging_imagedate_Internalname, "检查日期", "col-sm-3 AttributeDateLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 44,'',false,'',0)\"";
            context.WriteHtmlText( "<div id=\""+edtavBr_medicalimaging_br_medicalimaging_imagedate_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtavBr_medicalimaging_br_medicalimaging_imagedate_Internalname, context.localUtil.Format(AV10BR_MedicalImaging.gxTpr_Br_medicalimaging_imagedate, "9999/99/99"), context.localUtil.Format( AV10BR_MedicalImaging.gxTpr_Br_medicalimaging_imagedate, "9999/99/99"), TempTags+" onchange=\""+"gx.date.valid_date(this, 10,'YMD',0,24,'chs',false,1);"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,44);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavBr_medicalimaging_br_medicalimaging_imagedate_Jsonclick, 0, "AttributeDate", "", "", "", "", 1, edtavBr_medicalimaging_br_medicalimaging_imagedate_Enabled, 0, "text", "", 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_BR_MedicalImagingInsert.htm");
            GxWebStd.gx_bitmap( context, edtavBr_medicalimaging_br_medicalimaging_imagedate_Internalname+"_dp_trigger", context.GetImagePath( "61b9b5d3-dff6-4d59-9b00-da61bc2cbe93", "", context.GetTheme( )), "", "", "", "", ((1==0)||(edtavBr_medicalimaging_br_medicalimaging_imagedate_Enabled==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;", "", "", "", "", "", "", "", "", 1, false, false, "", "HLP_BR_MedicalImagingInsert.htm");
            context.WriteHtmlTextNl( "</div>") ;
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+dynavBr_medicalimaging_br_medicalimaging_imagehosp_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, dynavBr_medicalimaging_br_medicalimaging_imagehosp_Internalname, "行检医院", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 48,'',false,'',0)\"";
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, dynavBr_medicalimaging_br_medicalimaging_imagehosp, dynavBr_medicalimaging_br_medicalimaging_imagehosp_Internalname, StringUtil.RTrim( AV10BR_MedicalImaging.gxTpr_Br_medicalimaging_imagehosp), 1, dynavBr_medicalimaging_br_medicalimaging_imagehosp_Jsonclick, 0, "'"+""+"'"+",false,"+"'"+""+"'", "svchar", "", 1, dynavBr_medicalimaging_br_medicalimaging_imagehosp.Enabled, 0, 0, 0, "em", 0, "", "", "Attribute", "", "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,48);\"", "", true, "HLP_BR_MedicalImagingInsert.htm");
            dynavBr_medicalimaging_br_medicalimaging_imagehosp.CurrentValue = StringUtil.RTrim( AV10BR_MedicalImaging.gxTpr_Br_medicalimaging_imagehosp);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynavBr_medicalimaging_br_medicalimaging_imagehosp_Internalname, "Values", (String)(dynavBr_medicalimaging_br_medicalimaging_imagehosp.ToJavascriptSource()), true);
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 RequiredDataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtavBr_medicalimaging_br_medicalimaging_imageage_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavBr_medicalimaging_br_medicalimaging_imageage_Internalname, "年龄", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 53,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavBr_medicalimaging_br_medicalimaging_imageage_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV10BR_MedicalImaging.gxTpr_Br_medicalimaging_imageage), 3, 0, ".", "")), ((edtavBr_medicalimaging_br_medicalimaging_imageage_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(AV10BR_MedicalImaging.gxTpr_Br_medicalimaging_imageage), "ZZZ")) : context.localUtil.Format( (decimal)(AV10BR_MedicalImaging.gxTpr_Br_medicalimaging_imageage), "ZZZ")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,53);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavBr_medicalimaging_br_medicalimaging_imageage_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtavBr_medicalimaging_br_medicalimaging_imageage_Enabled, 0, "number", "1", 3, "chr", 1, "row", 3, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_BR_MedicalImagingInsert.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtavBr_medicalimaging_br_medicalimaging_tumorsize_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavBr_medicalimaging_br_medicalimaging_tumorsize_Internalname, "肿瘤大小", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 57,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavBr_medicalimaging_br_medicalimaging_tumorsize_Internalname, AV10BR_MedicalImaging.gxTpr_Br_medicalimaging_tumorsize, StringUtil.RTrim( context.localUtil.Format( AV10BR_MedicalImaging.gxTpr_Br_medicalimaging_tumorsize, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,57);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavBr_medicalimaging_br_medicalimaging_tumorsize_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtavBr_medicalimaging_br_medicalimaging_tumorsize_Enabled, 0, "text", "", 40, "chr", 1, "row", 40, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_BR_MedicalImagingInsert.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+cmbavVmetastasesdx_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, cmbavVmetastasesdx_Internalname, "是否有肿瘤转移", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 62,'',false,'',0)\"";
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, cmbavVmetastasesdx, cmbavVmetastasesdx_Internalname, StringUtil.RTrim( AV23vMetastasesDX), 1, cmbavVmetastasesdx_Jsonclick, 0, "'"+""+"'"+",false,"+"'"+""+"'", "svchar", "", 1, cmbavVmetastasesdx.Enabled, 0, 0, 0, "em", 0, "", "", "Attribute", "", "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,62);\"", "", true, "HLP_BR_MedicalImagingInsert.htm");
            cmbavVmetastasesdx.CurrentValue = StringUtil.RTrim( AV23vMetastasesDX);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavVmetastasesdx_Internalname, "Values", (String)(cmbavVmetastasesdx.ToJavascriptSource()), true);
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", edtavVmetaloc_Visible, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtavVmetaloc_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavVmetaloc_Internalname, "肿瘤转移部位", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 67,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavVmetaloc_Internalname, AV24vMetaLoc, StringUtil.RTrim( context.localUtil.Format( AV24vMetaLoc, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,67);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavVmetaloc_Jsonclick, 0, "Attribute", "", "", "", "", edtavVmetaloc_Visible, edtavVmetaloc_Enabled, 0, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_BR_MedicalImagingInsert.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", edtavVmetadate_Visible, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtavVmetadate_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavVmetadate_Internalname, "肿瘤转移时间", "col-sm-3 AttributeDateLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 71,'',false,'',0)\"";
            context.WriteHtmlText( "<div id=\""+edtavVmetadate_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtavVmetadate_Internalname, context.localUtil.Format(AV25vMetaDate, "9999/99/99"), context.localUtil.Format( AV25vMetaDate, "9999/99/99"), TempTags+" onchange=\""+"gx.date.valid_date(this, 10,'YMD',0,24,'chs',false,1);"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,71);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavVmetadate_Jsonclick, 0, "AttributeDate", "", "", "", "", edtavVmetadate_Visible, edtavVmetadate_Enabled, 0, "text", "", 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_BR_MedicalImagingInsert.htm");
            GxWebStd.gx_bitmap( context, edtavVmetadate_Internalname+"_dp_trigger", context.GetImagePath( "61b9b5d3-dff6-4d59-9b00-da61bc2cbe93", "", context.GetTheme( )), "", "", "", "", ((edtavVmetadate_Visible==0)||(edtavVmetadate_Enabled==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;", "", "", "", "", "", "", "", "", 1, false, false, "", "HLP_BR_MedicalImagingInsert.htm");
            context.WriteHtmlTextNl( "</div>") ;
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divUnnamedtablebr_medicalimaging_br_medicalimaging_preimagediag_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 MergeLabelCell CellWidth_12_5", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblockbr_medicalimaging_br_medicalimaging_preimagediag_Internalname, "影像前诊断", "", "", lblTextblockbr_medicalimaging_br_medicalimaging_preimagediag_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_BR_MedicalImagingInsert.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 CellWidth_87_5", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavBr_medicalimaging_br_medicalimaging_preimagediag_Internalname, "影像前诊断", "col-sm-3 AttributeLabel", 0, true);
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 80,'',false,'',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavBr_medicalimaging_br_medicalimaging_preimagediag_Internalname, AV10BR_MedicalImaging.gxTpr_Br_medicalimaging_preimagediag, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,80);\"", 0, 1, edtavBr_medicalimaging_br_medicalimaging_preimagediag_Enabled, 0, 80, "chr", 10, "row", StyleString, ClassString, "", "", "4000", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_MedicalImagingInsert.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divTablesplittedwzname_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 MergeLabelCell CellWidth_12_5", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblockwzname_Internalname, "检查部位(位置)", "", "", lblTextblockwzname_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_BR_MedicalImagingInsert.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 CellWidth_87_5", "left", "top", "", "", "div");
            wb_table2_87_972( true) ;
         }
         else
         {
            wb_table2_87_972( false) ;
         }
         return  ;
      }

      protected void wb_table2_87_972e( bool wbgen )
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
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divUnnamedtablebr_medicalimaging_br_medicalimaging_imageorgan_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 MergeLabelCell CellWidth_12_5", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblockbr_medicalimaging_br_medicalimaging_imageorgan_Internalname, "检查部位(器官)", "", "", lblTextblockbr_medicalimaging_br_medicalimaging_imageorgan_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_BR_MedicalImagingInsert.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 CellWidth_87_5", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavBr_medicalimaging_br_medicalimaging_imageorgan_Internalname, "检查部位(器官)", "col-sm-3 AttributeLabel", 0, true);
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 103,'',false,'',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavBr_medicalimaging_br_medicalimaging_imageorgan_Internalname, AV10BR_MedicalImaging.gxTpr_Br_medicalimaging_imageorgan, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,103);\"", 0, 1, edtavBr_medicalimaging_br_medicalimaging_imageorgan_Enabled, 0, 80, "chr", 10, "row", StyleString, ClassString, "", "", "5000", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_MedicalImagingInsert.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divUnnamedtablebr_medicalimaging_br_medicalimaging_imagedes_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 MergeLabelCell CellWidth_12_5", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblockbr_medicalimaging_br_medicalimaging_imagedes_Internalname, "图像描述", "", "", lblTextblockbr_medicalimaging_br_medicalimaging_imagedes_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_BR_MedicalImagingInsert.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 CellWidth_87_5", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavBr_medicalimaging_br_medicalimaging_imagedes_Internalname, "图像描述", "col-sm-3 AttributeLabel", 0, true);
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 111,'',false,'',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavBr_medicalimaging_br_medicalimaging_imagedes_Internalname, AV10BR_MedicalImaging.gxTpr_Br_medicalimaging_imagedes, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,111);\"", 0, 1, edtavBr_medicalimaging_br_medicalimaging_imagedes_Enabled, 0, 80, "chr", 10, "row", StyleString, ClassString, "", "", "9999", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_MedicalImagingInsert.htm");
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
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-action-group TrnActionGroup", "left", "top", " "+"data-gx-actiongroup-type=\"toolbar\""+" ", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 116,'',false,'',0)\"";
            ClassString = "ButtonMaterial";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtnenter_Internalname, "", "保存", bttBtnenter_Jsonclick, 5, "确认", "", StyleString, ClassString, 1, 1, "standard", "'"+""+"'"+",false,"+"'"+"EENTER."+"'", TempTags, "", context.GetButtonType( ), "HLP_BR_MedicalImagingInsert.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 118,'',false,'',0)\"";
            ClassString = "ButtonMaterialDefault";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtncancel_Internalname, "", "取消", bttBtncancel_Jsonclick, 1, "取消", "", StyleString, ClassString, 1, 1, "standard", "'"+""+"'"+",false,"+"'"+"ECANCEL."+"'", TempTags, "", context.GetButtonType( ), "HLP_BR_MedicalImagingInsert.htm");
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
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 122,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavBr_medicalimaging_br_medicalimagingid_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV10BR_MedicalImaging.gxTpr_Br_medicalimagingid), 18, 0, ".", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(AV10BR_MedicalImaging.gxTpr_Br_medicalimagingid), "ZZZZZZZZZZZZZZZZZZ")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,122);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavBr_medicalimaging_br_medicalimagingid_Jsonclick, 0, "Attribute", "", "", "", "", edtavBr_medicalimaging_br_medicalimagingid_Visible, 1, 0, "number", "1", 18, "chr", 1, "row", 18, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_BR_MedicalImagingInsert.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 123,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavBr_medicalimaging_br_encounterid_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV10BR_MedicalImaging.gxTpr_Br_encounterid), 18, 0, ".", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(AV10BR_MedicalImaging.gxTpr_Br_encounterid), "ZZZZZZZZZZZZZZZZZZ")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,123);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavBr_medicalimaging_br_encounterid_Jsonclick, 0, "Attribute", "", "", "", "", edtavBr_medicalimaging_br_encounterid_Visible, 1, 0, "number", "1", 18, "chr", 1, "row", 18, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_BR_MedicalImagingInsert.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 124,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavBr_medicalimaging_br_information_patientno_Internalname, AV10BR_MedicalImaging.gxTpr_Br_information_patientno, StringUtil.RTrim( context.localUtil.Format( AV10BR_MedicalImaging.gxTpr_Br_information_patientno, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,124);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavBr_medicalimaging_br_information_patientno_Jsonclick, 0, "Attribute", "", "", "", "", edtavBr_medicalimaging_br_information_patientno_Visible, 1, 0, "text", "", 80, "chr", 1, "row", 2000, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_BR_MedicalImagingInsert.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 125,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavBr_medicalimaging_br_medicalimaging_id_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV10BR_MedicalImaging.gxTpr_Br_medicalimaging_id), 10, 0, ".", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(AV10BR_MedicalImaging.gxTpr_Br_medicalimaging_id), "ZZZZZZZZZZ")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,125);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavBr_medicalimaging_br_medicalimaging_id_Jsonclick, 0, "Attribute", "", "", "", "", edtavBr_medicalimaging_br_medicalimaging_id_Visible, 1, 0, "number", "1", 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_BR_MedicalImagingInsert.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
         }
         wbLoad = true;
      }

      protected void START972( )
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
         STRUP970( ) ;
      }

      protected void WS972( )
      {
         START972( ) ;
         EVT972( ) ;
      }

      protected void EVT972( )
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
                              E11972 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "REFRESH") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              /* Execute user event: Refresh */
                              E12972 ();
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
                                    E13972 ();
                                 }
                                 dynload_actions( ) ;
                              }
                           }
                           else if ( StringUtil.StrCmp(sEvt, "LOAD") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              /* Execute user event: Load */
                              E14972 ();
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

      protected void WE972( )
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

      protected void PA972( )
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
               GX_FocusControl = edtavBr_medicalimaging_br_medicalimaging_no_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
            nDonePA = 1;
         }
      }

      protected void dynload_actions( )
      {
         /* End function dynload_actions */
      }

      protected void GXDLVvVNAME972( String AV17tCurrentCode )
      {
         if ( ! context.isAjaxRequest( ) )
         {
            context.GX_webresponse.AppendHeader("Cache-Control", "no-store");
         }
         context.GX_webresponse.AddString("[[");
         GXDLVvVNAME_data972( AV17tCurrentCode) ;
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

      protected void GXVvVNAME_html972( String AV17tCurrentCode )
      {
         String gxdynajaxvalue ;
         GXDLVvVNAME_data972( AV17tCurrentCode) ;
         gxdynajaxindex = 1;
         if ( ! ( gxdyncontrolsrefreshing && context.isAjaxRequest( ) ) )
         {
            dynavVname.removeAllItems();
         }
         while ( gxdynajaxindex <= gxdynajaxctrlcodr.Count )
         {
            gxdynajaxvalue = ((String)gxdynajaxctrlcodr.Item(gxdynajaxindex));
            dynavVname.addItem(gxdynajaxvalue, ((String)gxdynajaxctrldescr.Item(gxdynajaxindex)), 0);
            gxdynajaxindex = (int)(gxdynajaxindex+1);
         }
      }

      protected void GXDLVvVNAME_data972( String AV17tCurrentCode )
      {
         gxdynajaxctrlcodr.Clear();
         gxdynajaxctrldescr.Clear();
         /* Using cursor H00972 */
         pr_default.execute(0, new Object[] {AV17tCurrentCode});
         while ( (pr_default.getStatus(0) != 101) )
         {
            gxdynajaxctrlcodr.Add(H00972_A168XT_DefineCodeName[0]);
            gxdynajaxctrldescr.Add(H00972_A168XT_DefineCodeName[0]);
            pr_default.readNext(0);
         }
         pr_default.close(0);
      }

      protected void GXDLVBR_MEDICALIMAGING_BR_MEDICALIMAGING_IMAGEHOSP972( String AV17tCurrentCode )
      {
         if ( ! context.isAjaxRequest( ) )
         {
            context.GX_webresponse.AppendHeader("Cache-Control", "no-store");
         }
         context.GX_webresponse.AddString("[[");
         GXDLVBR_MEDICALIMAGING_BR_MEDICALIMAGING_IMAGEHOSP_data972( AV17tCurrentCode) ;
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

      protected void GXVBR_MEDICALIMAGING_BR_MEDICALIMAGING_IMAGEHOSP_html972( String AV17tCurrentCode )
      {
         String gxdynajaxvalue ;
         GXDLVBR_MEDICALIMAGING_BR_MEDICALIMAGING_IMAGEHOSP_data972( AV17tCurrentCode) ;
         gxdynajaxindex = 1;
         if ( ! ( gxdyncontrolsrefreshing && context.isAjaxRequest( ) ) )
         {
            dynavBr_medicalimaging_br_medicalimaging_imagehosp.removeAllItems();
         }
         while ( gxdynajaxindex <= gxdynajaxctrlcodr.Count )
         {
            gxdynajaxvalue = ((String)gxdynajaxctrlcodr.Item(gxdynajaxindex));
            dynavBr_medicalimaging_br_medicalimaging_imagehosp.addItem(gxdynajaxvalue, ((String)gxdynajaxctrldescr.Item(gxdynajaxindex)), 0);
            gxdynajaxindex = (int)(gxdynajaxindex+1);
         }
      }

      protected void GXDLVBR_MEDICALIMAGING_BR_MEDICALIMAGING_IMAGEHOSP_data972( String AV17tCurrentCode )
      {
         gxdynajaxctrlcodr.Clear();
         gxdynajaxctrldescr.Clear();
         gxdynajaxctrlcodr.Add("");
         gxdynajaxctrldescr.Add("(请选择)");
         /* Using cursor H00973 */
         pr_default.execute(1, new Object[] {AV17tCurrentCode});
         while ( (pr_default.getStatus(1) != 101) )
         {
            gxdynajaxctrlcodr.Add(H00973_A168XT_DefineCodeName[0]);
            gxdynajaxctrldescr.Add(H00973_A168XT_DefineCodeName[0]);
            pr_default.readNext(1);
         }
         pr_default.close(1);
      }

      protected void GXDLVvWZNAME972( String AV17tCurrentCode )
      {
         if ( ! context.isAjaxRequest( ) )
         {
            context.GX_webresponse.AppendHeader("Cache-Control", "no-store");
         }
         context.GX_webresponse.AddString("[[");
         GXDLVvWZNAME_data972( AV17tCurrentCode) ;
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

      protected void GXVvWZNAME_html972( String AV17tCurrentCode )
      {
         String gxdynajaxvalue ;
         GXDLVvWZNAME_data972( AV17tCurrentCode) ;
         gxdynajaxindex = 1;
         if ( ! ( gxdyncontrolsrefreshing && context.isAjaxRequest( ) ) )
         {
            dynavWzname.removeAllItems();
         }
         while ( gxdynajaxindex <= gxdynajaxctrlcodr.Count )
         {
            gxdynajaxvalue = ((String)gxdynajaxctrlcodr.Item(gxdynajaxindex));
            dynavWzname.addItem(gxdynajaxvalue, ((String)gxdynajaxctrldescr.Item(gxdynajaxindex)), 0);
            gxdynajaxindex = (int)(gxdynajaxindex+1);
         }
      }

      protected void GXDLVvWZNAME_data972( String AV17tCurrentCode )
      {
         gxdynajaxctrlcodr.Clear();
         gxdynajaxctrldescr.Clear();
         gxdynajaxctrlcodr.Add("");
         gxdynajaxctrldescr.Add("(请选择)");
         /* Using cursor H00974 */
         pr_default.execute(2, new Object[] {AV17tCurrentCode});
         while ( (pr_default.getStatus(2) != 101) )
         {
            gxdynajaxctrlcodr.Add(H00974_A168XT_DefineCodeName[0]);
            gxdynajaxctrldescr.Add(H00974_A168XT_DefineCodeName[0]);
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
         if ( dynavVname.ItemCount > 0 )
         {
            AV11vName = dynavVname.getValidValue(AV11vName);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11vName", AV11vName);
         }
         if ( context.isAjaxRequest( ) )
         {
            dynavVname.CurrentValue = StringUtil.RTrim( AV11vName);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynavVname_Internalname, "Values", dynavVname.ToJavascriptSource(), true);
         }
         if ( dynavBr_medicalimaging_br_medicalimaging_imagehosp.ItemCount > 0 )
         {
            AV10BR_MedicalImaging.gxTpr_Br_medicalimaging_imagehosp = dynavBr_medicalimaging_br_medicalimaging_imagehosp.getValidValue(AV10BR_MedicalImaging.gxTpr_Br_medicalimaging_imagehosp);
         }
         if ( context.isAjaxRequest( ) )
         {
            dynavBr_medicalimaging_br_medicalimaging_imagehosp.CurrentValue = StringUtil.RTrim( AV10BR_MedicalImaging.gxTpr_Br_medicalimaging_imagehosp);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynavBr_medicalimaging_br_medicalimaging_imagehosp_Internalname, "Values", dynavBr_medicalimaging_br_medicalimaging_imagehosp.ToJavascriptSource(), true);
         }
         if ( cmbavVmetastasesdx.ItemCount > 0 )
         {
            AV23vMetastasesDX = cmbavVmetastasesdx.getValidValue(AV23vMetastasesDX);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV23vMetastasesDX", AV23vMetastasesDX);
         }
         if ( context.isAjaxRequest( ) )
         {
            cmbavVmetastasesdx.CurrentValue = StringUtil.RTrim( AV23vMetastasesDX);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavVmetastasesdx_Internalname, "Values", cmbavVmetastasesdx.ToJavascriptSource(), true);
         }
         if ( dynavWzname.ItemCount > 0 )
         {
            AV14wzName = dynavWzname.getValidValue(AV14wzName);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14wzName", AV14wzName);
         }
         if ( context.isAjaxRequest( ) )
         {
            dynavWzname.CurrentValue = StringUtil.RTrim( AV14wzName);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynavWzname_Internalname, "Values", dynavWzname.ToJavascriptSource(), true);
         }
      }

      public void Refresh( )
      {
         send_integrity_hashes( ) ;
         RF972( ) ;
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

      protected void RF972( )
      {
         initialize_formulas( ) ;
         clear_multi_value_controls( ) ;
         /* Execute user event: Refresh */
         E12972 ();
         gxdyncontrolsrefreshing = true;
         fix_multi_value_controls( ) ;
         gxdyncontrolsrefreshing = false;
         if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
         {
            /* Execute user event: Load */
            E14972 ();
            WB970( ) ;
         }
      }

      protected void send_integrity_lvl_hashes972( )
      {
         GxWebStd.gx_hidden_field( context, "vBR_ENCOUNTERID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV18BR_EncounterID), 18, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "gxhash_vBR_ENCOUNTERID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV18BR_EncounterID), "ZZZZZZZZZZZZZZZZZZ"), context));
      }

      protected void STRUP970( )
      {
         /* Before Start, stand alone formulas. */
         context.Gx_err = 0;
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0;
         /* Execute user event: Start */
         E11972 ();
         context.wbGlbDoneStart = 1;
         /* After Start, stand alone formulas. */
         GXVvVNAME_html972( AV17tCurrentCode) ;
         GXVBR_MEDICALIMAGING_BR_MEDICALIMAGING_IMAGEHOSP_html972( AV17tCurrentCode) ;
         GXVvWZNAME_html972( AV17tCurrentCode) ;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read saved SDTs. */
            ajax_req_read_hidden_sdt(cgiGet( "Br_medicalimaging"), AV10BR_MedicalImaging);
            /* Read variables values. */
            if ( ( ( context.localUtil.CToN( cgiGet( edtavBr_medicalimaging_br_medicalimaging_no_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavBr_medicalimaging_br_medicalimaging_no_Internalname), ".", ",") > Convert.ToDecimal( 999999999999999999L )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "BR_MEDICALIMAGING_BR_MEDICALIMAGING_NO");
               GX_FocusControl = edtavBr_medicalimaging_br_medicalimaging_no_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV10BR_MedicalImaging.gxTpr_Br_medicalimaging_no = 0;
            }
            else
            {
               AV10BR_MedicalImaging.gxTpr_Br_medicalimaging_no = (long)(context.localUtil.CToN( cgiGet( edtavBr_medicalimaging_br_medicalimaging_no_Internalname), ".", ","));
            }
            dynavVname.CurrentValue = cgiGet( dynavVname_Internalname);
            AV11vName = cgiGet( dynavVname_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11vName", AV11vName);
            AV12vOtherName = cgiGet( edtavVothername_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12vOtherName", AV12vOtherName);
            if ( context.localUtil.VCDate( cgiGet( edtavBr_medicalimaging_br_medicalimaging_imagedate_Internalname), 0) == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_faildate", new   object[]  {"检查日期"}), 1, "BR_MEDICALIMAGING_BR_MEDICALIMAGING_IMAGEDATE");
               GX_FocusControl = edtavBr_medicalimaging_br_medicalimaging_imagedate_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV10BR_MedicalImaging.gxTpr_Br_medicalimaging_imagedate = DateTime.MinValue;
            }
            else
            {
               AV10BR_MedicalImaging.gxTpr_Br_medicalimaging_imagedate = context.localUtil.CToD( cgiGet( edtavBr_medicalimaging_br_medicalimaging_imagedate_Internalname), 0);
            }
            dynavBr_medicalimaging_br_medicalimaging_imagehosp.CurrentValue = cgiGet( dynavBr_medicalimaging_br_medicalimaging_imagehosp_Internalname);
            AV10BR_MedicalImaging.gxTpr_Br_medicalimaging_imagehosp = cgiGet( dynavBr_medicalimaging_br_medicalimaging_imagehosp_Internalname);
            if ( ( ( context.localUtil.CToN( cgiGet( edtavBr_medicalimaging_br_medicalimaging_imageage_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavBr_medicalimaging_br_medicalimaging_imageage_Internalname), ".", ",") > Convert.ToDecimal( 999 )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "BR_MEDICALIMAGING_BR_MEDICALIMAGING_IMAGEAGE");
               GX_FocusControl = edtavBr_medicalimaging_br_medicalimaging_imageage_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV10BR_MedicalImaging.gxTpr_Br_medicalimaging_imageage = 0;
            }
            else
            {
               AV10BR_MedicalImaging.gxTpr_Br_medicalimaging_imageage = (short)(context.localUtil.CToN( cgiGet( edtavBr_medicalimaging_br_medicalimaging_imageage_Internalname), ".", ","));
            }
            AV10BR_MedicalImaging.gxTpr_Br_medicalimaging_tumorsize = cgiGet( edtavBr_medicalimaging_br_medicalimaging_tumorsize_Internalname);
            cmbavVmetastasesdx.CurrentValue = cgiGet( cmbavVmetastasesdx_Internalname);
            AV23vMetastasesDX = cgiGet( cmbavVmetastasesdx_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV23vMetastasesDX", AV23vMetastasesDX);
            AV24vMetaLoc = cgiGet( edtavVmetaloc_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV24vMetaLoc", AV24vMetaLoc);
            if ( context.localUtil.VCDate( cgiGet( edtavVmetadate_Internalname), 0) == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_faildate", new   object[]  {"v Meta Date"}), 1, "vVMETADATE");
               GX_FocusControl = edtavVmetadate_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV25vMetaDate = DateTime.MinValue;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV25vMetaDate", context.localUtil.Format(AV25vMetaDate, "9999/99/99"));
            }
            else
            {
               AV25vMetaDate = context.localUtil.CToD( cgiGet( edtavVmetadate_Internalname), 0);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV25vMetaDate", context.localUtil.Format(AV25vMetaDate, "9999/99/99"));
            }
            AV10BR_MedicalImaging.gxTpr_Br_medicalimaging_preimagediag = cgiGet( edtavBr_medicalimaging_br_medicalimaging_preimagediag_Internalname);
            dynavWzname.CurrentValue = cgiGet( dynavWzname_Internalname);
            AV14wzName = cgiGet( dynavWzname_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14wzName", AV14wzName);
            AV15wxName = cgiGet( edtavWxname_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV15wxName", AV15wxName);
            AV10BR_MedicalImaging.gxTpr_Br_medicalimaging_imageorgan = cgiGet( edtavBr_medicalimaging_br_medicalimaging_imageorgan_Internalname);
            AV10BR_MedicalImaging.gxTpr_Br_medicalimaging_imagedes = cgiGet( edtavBr_medicalimaging_br_medicalimaging_imagedes_Internalname);
            if ( ( ( context.localUtil.CToN( cgiGet( edtavBr_medicalimaging_br_medicalimagingid_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavBr_medicalimaging_br_medicalimagingid_Internalname), ".", ",") > Convert.ToDecimal( 999999999999999999L )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "BR_MEDICALIMAGING_BR_MEDICALIMAGINGID");
               GX_FocusControl = edtavBr_medicalimaging_br_medicalimagingid_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV10BR_MedicalImaging.gxTpr_Br_medicalimagingid = 0;
            }
            else
            {
               AV10BR_MedicalImaging.gxTpr_Br_medicalimagingid = (long)(context.localUtil.CToN( cgiGet( edtavBr_medicalimaging_br_medicalimagingid_Internalname), ".", ","));
            }
            if ( ( ( context.localUtil.CToN( cgiGet( edtavBr_medicalimaging_br_encounterid_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavBr_medicalimaging_br_encounterid_Internalname), ".", ",") > Convert.ToDecimal( 999999999999999999L )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "BR_MEDICALIMAGING_BR_ENCOUNTERID");
               GX_FocusControl = edtavBr_medicalimaging_br_encounterid_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV10BR_MedicalImaging.gxTpr_Br_encounterid = 0;
            }
            else
            {
               AV10BR_MedicalImaging.gxTpr_Br_encounterid = (long)(context.localUtil.CToN( cgiGet( edtavBr_medicalimaging_br_encounterid_Internalname), ".", ","));
            }
            AV10BR_MedicalImaging.gxTpr_Br_information_patientno = cgiGet( edtavBr_medicalimaging_br_information_patientno_Internalname);
            if ( ( ( context.localUtil.CToN( cgiGet( edtavBr_medicalimaging_br_medicalimaging_id_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavBr_medicalimaging_br_medicalimaging_id_Internalname), ".", ",") > Convert.ToDecimal( 9999999999L )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "BR_MEDICALIMAGING_BR_MEDICALIMAGING_ID");
               GX_FocusControl = edtavBr_medicalimaging_br_medicalimaging_id_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV10BR_MedicalImaging.gxTpr_Br_medicalimaging_id = 0;
            }
            else
            {
               AV10BR_MedicalImaging.gxTpr_Br_medicalimaging_id = (long)(context.localUtil.CToN( cgiGet( edtavBr_medicalimaging_br_medicalimaging_id_Internalname), ".", ","));
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
            GXVvVNAME_html972( AV17tCurrentCode) ;
            GXVBR_MEDICALIMAGING_BR_MEDICALIMAGING_IMAGEHOSP_html972( AV17tCurrentCode) ;
            GXVvWZNAME_html972( AV17tCurrentCode) ;
         }
         else
         {
            dynload_actions( ) ;
         }
      }

      protected void GXStart( )
      {
         /* Execute user event: Start */
         E11972 ();
         if (returnInSub) return;
      }

      protected void E11972( )
      {
         /* Start Routine */
         GXt_char1 = AV17tCurrentCode;
         new zbr_getcurrenttcode(context ).execute( out  GXt_char1) ;
         AV17tCurrentCode = GXt_char1;
         /* Execute user subroutine: 'ATTRIBUTESSECURITYCODE' */
         S112 ();
         if (returnInSub) return;
         edtavBr_medicalimaging_br_medicalimagingid_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavBr_medicalimaging_br_medicalimagingid_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavBr_medicalimaging_br_medicalimagingid_Visible), 5, 0)), true);
         edtavBr_medicalimaging_br_encounterid_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavBr_medicalimaging_br_encounterid_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavBr_medicalimaging_br_encounterid_Visible), 5, 0)), true);
         edtavBr_medicalimaging_br_information_patientno_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavBr_medicalimaging_br_information_patientno_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavBr_medicalimaging_br_information_patientno_Visible), 5, 0)), true);
         edtavBr_medicalimaging_br_medicalimaging_id_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavBr_medicalimaging_br_medicalimaging_id_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavBr_medicalimaging_br_medicalimaging_id_Visible), 5, 0)), true);
         edtavVothername_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavVothername_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavVothername_Visible), 5, 0)), true);
         edtavWxname_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavWxname_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavWxname_Visible), 5, 0)), true);
         AV24vMetaLoc = AV10BR_MedicalImaging.gxTpr_Br_medicalimaging_metaloc;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV24vMetaLoc", AV24vMetaLoc);
         AV25vMetaDate = AV10BR_MedicalImaging.gxTpr_Br_medicalimaging_metadate;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV25vMetaDate", context.localUtil.Format(AV25vMetaDate, "9999/99/99"));
         AV26vtest = AV10BR_MedicalImaging.gxTpr_Br_medicalimaging_metaloc;
      }

      protected void S122( )
      {
         /* 'CHECKREQUIREDFIELDS' Routine */
         AV16CheckRequiredFieldsResult = true;
         if ( (0==AV10BR_MedicalImaging.gxTpr_Br_medicalimaging_no) )
         {
            GX_msglist.addItem("");
            AV16CheckRequiredFieldsResult = false;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV11vName)) )
         {
            GX_msglist.addItem("影像名称是必须填写的。");
            AV16CheckRequiredFieldsResult = false;
         }
         if ( ( ( StringUtil.StrCmp(AV11vName, "其它") == 0 ) ) && String.IsNullOrEmpty(StringUtil.RTrim( AV12vOtherName)) )
         {
            GX_msglist.addItem("其它影像名称是必填的");
            AV16CheckRequiredFieldsResult = false;
         }
         if ( (0==AV10BR_MedicalImaging.gxTpr_Br_medicalimaging_imageage) )
         {
            GX_msglist.addItem("年龄是必须填写的。");
            AV16CheckRequiredFieldsResult = false;
         }
         if ( ( ( StringUtil.StrCmp(AV14wzName, "其它") == 0 ) ) && String.IsNullOrEmpty(StringUtil.RTrim( AV15wxName)) )
         {
            GX_msglist.addItem("其它检测部位是必填的");
            AV16CheckRequiredFieldsResult = false;
         }
      }

      protected void S112( )
      {
         /* 'ATTRIBUTESSECURITYCODE' Routine */
         if ( StringUtil.StrCmp(AV11vName, "其它") == 0 )
         {
            cellVothername_cell_Class = "RequiredDataContentCell";
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cellVothername_cell_Internalname, "Class", cellVothername_cell_Class, true);
         }
         else
         {
            cellVothername_cell_Class = "DataContentCell";
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cellVothername_cell_Internalname, "Class", cellVothername_cell_Class, true);
         }
         if ( StringUtil.StrCmp(AV14wzName, "其它") == 0 )
         {
            cellWxname_cell_Class = "RequiredDataContentCell";
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cellWxname_cell_Internalname, "Class", cellWxname_cell_Class, true);
         }
         else
         {
            cellWxname_cell_Class = "DataContentCell";
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cellWxname_cell_Internalname, "Class", cellWxname_cell_Class, true);
         }
      }

      protected void S132( )
      {
         /* 'SHOW MESSAGES' Routine */
         AV41GXV13 = 1;
         while ( AV41GXV13 <= AV8Messages.Count )
         {
            AV7Message = ((SdtMessages_Message)AV8Messages.Item(AV41GXV13));
            GX_msglist.addItem(AV7Message.gxTpr_Description);
            AV41GXV13 = (int)(AV41GXV13+1);
         }
      }

      protected void E12972( )
      {
         /* Refresh Routine */
         new GeneXus.Programs.wwpbaseobjects.loadwwpcontext(context ).execute( out  AV9Context) ;
      }

      public void GXEnter( )
      {
         /* Execute user event: Enter */
         E13972 ();
         if (returnInSub) return;
      }

      protected void E13972( )
      {
         /* Enter Routine */
         new zutil_checksession(context ).execute( out  AV22tCheckFlag) ;
         if ( ! AV22tCheckFlag )
         {
            AV19tFlag = true;
            if ( ( AV19tFlag ) && (0==AV10BR_MedicalImaging.gxTpr_Br_medicalimaging_no) )
            {
               GX_msglist.addItem("编号是必填的");
               AV19tFlag = false;
            }
            if ( StringUtil.StrCmp(AV11vName, "其它") == 0 )
            {
               if ( String.IsNullOrEmpty(StringUtil.RTrim( AV12vOtherName)) )
               {
                  GX_msglist.addItem("其它影像名称是必填的");
                  AV19tFlag = false;
               }
               else
               {
                  AV10BR_MedicalImaging.gxTpr_Br_medicalimaging_imagename = AV12vOtherName;
               }
            }
            else
            {
               AV10BR_MedicalImaging.gxTpr_Br_medicalimaging_imagename = AV11vName;
            }
            if ( StringUtil.StrCmp(AV14wzName, "其它") == 0 )
            {
               if ( String.IsNullOrEmpty(StringUtil.RTrim( AV15wxName)) )
               {
                  GX_msglist.addItem("其它检查部位是必填的");
                  AV19tFlag = false;
               }
               else
               {
                  AV10BR_MedicalImaging.gxTpr_Br_medicalimaging_imageloc = AV15wxName;
               }
            }
            else
            {
               AV10BR_MedicalImaging.gxTpr_Br_medicalimaging_imageloc = AV14wzName;
            }
            if ( ( AV19tFlag ) && (0==AV10BR_MedicalImaging.gxTpr_Br_medicalimaging_imageage) )
            {
               GX_msglist.addItem("年龄是必填的");
               AV19tFlag = false;
            }
            if ( AV19tFlag )
            {
               AV10BR_MedicalImaging.gxTpr_Br_encounterid = AV18BR_EncounterID;
               AV10BR_MedicalImaging.gxTpr_Br_medicalimaging_metaloc = AV24vMetaLoc;
               AV10BR_MedicalImaging.gxTpr_Br_medicalimaging_metadate = AV25vMetaDate;
               AV10BR_MedicalImaging.gxTpr_Br_medicalimaging_metastasesdx = AV23vMetastasesDX;
               GXt_char1 = "";
               new zutil_findtargetcode(context ).execute(  30,  AV10BR_MedicalImaging.gxTpr_Br_medicalimaging_imagename, out  GXt_char1) ;
               AV10BR_MedicalImaging.gxTpr_Br_medicalimaging_imagename_code = GXt_char1;
               GXt_char1 = "";
               new zutil_findtargetcode(context ).execute(  31,  AV10BR_MedicalImaging.gxTpr_Br_medicalimaging_imagehosp, out  GXt_char1) ;
               AV10BR_MedicalImaging.gxTpr_Br_medicalimaging_imagehosp_code = GXt_char1;
               if ( (DateTime.MinValue==AV10BR_MedicalImaging.gxTpr_Br_medicalimaging_imagedate) )
               {
                  AV10BR_MedicalImaging.gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imagedate_SetNull();
               }
               if ( StringUtil.StrCmp(AV10BR_MedicalImaging.gxTpr_Br_medicalimaging_metastasesdx, "否") == 0 )
               {
                  AV10BR_MedicalImaging.gxTv_SdtBR_MedicalImaging_Br_medicalimaging_metaloc_SetNull();
                  AV10BR_MedicalImaging.gxTv_SdtBR_MedicalImaging_Br_medicalimaging_metadate_SetNull();
               }
               if ( StringUtil.StrCmp(AV10BR_MedicalImaging.gxTpr_Br_medicalimaging_metastasesdx, "不详") == 0 )
               {
                  AV10BR_MedicalImaging.gxTv_SdtBR_MedicalImaging_Br_medicalimaging_metaloc_SetNull();
                  AV10BR_MedicalImaging.gxTv_SdtBR_MedicalImaging_Br_medicalimaging_metadate_SetNull();
               }
               AV10BR_MedicalImaging.Save();
               if ( AV10BR_MedicalImaging.Success() )
               {
                  context.CommitDataStores("br_medicalimaginginsert",pr_default);
                  CallWebObject(formatLink("br_medicalimagingview.aspx") + "?" + UrlEncode("" +AV10BR_MedicalImaging.gxTpr_Br_medicalimagingid) + "," + UrlEncode(StringUtil.RTrim("General")));
                  context.wjLocDisableFrm = 1;
               }
               else
               {
                  AV21ErrorMsg = "";
                  AV43GXV15 = 1;
                  AV42GXV14 = AV10BR_MedicalImaging.GetMessages();
                  while ( AV43GXV15 <= AV42GXV14.Count )
                  {
                     AV7Message = ((SdtMessages_Message)AV42GXV14.Item(AV43GXV15));
                     AV21ErrorMsg = AV21ErrorMsg + StringUtil.Trim( AV7Message.gxTpr_Description);
                     AV43GXV15 = (int)(AV43GXV15+1);
                  }
               }
            }
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV10BR_MedicalImaging", AV10BR_MedicalImaging);
      }

      protected void nextLoad( )
      {
      }

      protected void E14972( )
      {
         /* Load Routine */
         AV10BR_MedicalImaging.Load(AV20BR_MedicalImagingID);
         if ( StringUtil.StrCmp(AV10BR_MedicalImaging.gxTpr_Br_medicalimaging_metastasesdx, "是") == 0 )
         {
            edtavVmetadate_Visible = 1;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavVmetadate_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavVmetadate_Visible), 5, 0)), true);
            edtavVmetaloc_Visible = 1;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavVmetaloc_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavVmetaloc_Visible), 5, 0)), true);
         }
         else
         {
            edtavVmetadate_Visible = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavVmetadate_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavVmetadate_Visible), 5, 0)), true);
            edtavVmetaloc_Visible = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavVmetaloc_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavVmetaloc_Visible), 5, 0)), true);
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV10BR_MedicalImaging.gxTpr_Br_medicalimaging_imagename)) )
         {
            dynavVname.addItem(AV10BR_MedicalImaging.gxTpr_Br_medicalimaging_imagename, AV10BR_MedicalImaging.gxTpr_Br_medicalimaging_imagename, 0);
            AV11vName = AV10BR_MedicalImaging.gxTpr_Br_medicalimaging_imagename;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11vName", AV11vName);
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV10BR_MedicalImaging.gxTpr_Br_medicalimaging_imageloc)) )
         {
            dynavWzname.addItem(AV10BR_MedicalImaging.gxTpr_Br_medicalimaging_imageloc, AV10BR_MedicalImaging.gxTpr_Br_medicalimaging_imageloc, 0);
            AV14wzName = AV10BR_MedicalImaging.gxTpr_Br_medicalimaging_imageloc;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14wzName", AV14wzName);
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV10BR_MedicalImaging.gxTpr_Br_medicalimaging_metastasesdx)) )
         {
            cmbavVmetastasesdx.addItem(AV10BR_MedicalImaging.gxTpr_Br_medicalimaging_metastasesdx, AV10BR_MedicalImaging.gxTpr_Br_medicalimaging_metastasesdx, 0);
            AV23vMetastasesDX = AV10BR_MedicalImaging.gxTpr_Br_medicalimaging_metastasesdx;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV23vMetastasesDX", AV23vMetastasesDX);
         }
      }

      protected void wb_table2_87_972( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "";
            GxWebStd.gx_table_start( context, tblTablemergedwzname_Internalname, tblTablemergedwzname_Internalname, "", "TableMerged", 0, "", "", 0, 0, sStyleString, "", "", 0);
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td class='MergeDataCell'>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, dynavWzname_Internalname, "wz Name", "col-sm-3 AttributeLabel", 0, true);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 91,'',false,'',0)\"";
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, dynavWzname, dynavWzname_Internalname, StringUtil.RTrim( AV14wzName), 1, dynavWzname_Jsonclick, 0, "'"+""+"'"+",false,"+"'"+""+"'", "svchar", "", 1, dynavWzname.Enabled, 0, 0, 0, "em", 0, "", "", "Attribute", "", "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,91);\"", "", true, "HLP_BR_MedicalImagingInsert.htm");
            dynavWzname.CurrentValue = StringUtil.RTrim( AV14wzName);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynavWzname_Internalname, "Values", (String)(dynavWzname.ToJavascriptSource()), true);
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td id=\""+cellWxname_cell_Internalname+"\"  class='"+cellWxname_cell_Class+"'>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavWxname_Internalname, "wx Name", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 94,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavWxname_Internalname, AV15wxName, StringUtil.RTrim( context.localUtil.Format( AV15wxName, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,94);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "请填写其它检测部位", edtavWxname_Jsonclick, 0, "Attribute", "", "", "", "", edtavWxname_Visible, edtavWxname_Enabled, 0, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_BR_MedicalImagingInsert.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table2_87_972e( true) ;
         }
         else
         {
            wb_table2_87_972e( false) ;
         }
      }

      protected void wb_table1_32_972( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "";
            GxWebStd.gx_table_start( context, tblTablemergedvname_Internalname, tblTablemergedvname_Internalname, "", "TableMerged", 0, "", "", 0, 0, sStyleString, "", "", 0);
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td class='MergeDataCell'>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, dynavVname_Internalname, "v Name", "col-sm-3 AttributeLabel", 0, true);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 36,'',false,'',0)\"";
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, dynavVname, dynavVname_Internalname, StringUtil.RTrim( AV11vName), 1, dynavVname_Jsonclick, 0, "'"+""+"'"+",false,"+"'"+""+"'", "svchar", "", 1, dynavVname.Enabled, 0, 0, 0, "em", 0, "", "", "Attribute", "", "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,36);\"", "", true, "HLP_BR_MedicalImagingInsert.htm");
            dynavVname.CurrentValue = StringUtil.RTrim( AV11vName);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynavVname_Internalname, "Values", (String)(dynavVname.ToJavascriptSource()), true);
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td id=\""+cellVothername_cell_Internalname+"\"  class='"+cellVothername_cell_Class+"'>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavVothername_Internalname, "v Other Name", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 39,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavVothername_Internalname, AV12vOtherName, StringUtil.RTrim( context.localUtil.Format( AV12vOtherName, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,39);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "请填写其它影像名称", edtavVothername_Jsonclick, 0, "Attribute", "", "", "", "", edtavVothername_Visible, edtavVothername_Enabled, 0, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_BR_MedicalImagingInsert.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table1_32_972e( true) ;
         }
         else
         {
            wb_table1_32_972e( false) ;
         }
      }

      public override void setparameters( Object[] obj )
      {
         createObjects();
         initialize();
         AV18BR_EncounterID = Convert.ToInt64(getParm(obj,0));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV18BR_EncounterID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV18BR_EncounterID), 18, 0)));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vBR_ENCOUNTERID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV18BR_EncounterID), "ZZZZZZZZZZZZZZZZZZ"), context));
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
         PA972( ) ;
         WS972( ) ;
         WE972( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?20202281517816", true);
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
         context.AddJavascriptSource("br_medicalimaginginsert.js", "?20202281517816", false);
         context.AddJavascriptSource("DVelop/Bootstrap/Shared/DVelopBootstrap.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/Panel/BootstrapPanelRender.js", "", false);
         /* End function include_jscripts */
      }

      protected void init_web_controls( )
      {
         dynavVname.Name = "vVNAME";
         dynavVname.WebTags = "";
         dynavBr_medicalimaging_br_medicalimaging_imagehosp.Name = "BR_MEDICALIMAGING_BR_MEDICALIMAGING_IMAGEHOSP";
         dynavBr_medicalimaging_br_medicalimaging_imagehosp.WebTags = "";
         cmbavVmetastasesdx.Name = "vVMETASTASESDX";
         cmbavVmetastasesdx.WebTags = "";
         cmbavVmetastasesdx.addItem("", "(请选择)", 0);
         cmbavVmetastasesdx.addItem("否", "否", 0);
         cmbavVmetastasesdx.addItem("是", "是", 0);
         cmbavVmetastasesdx.addItem("不详", "不详", 0);
         if ( cmbavVmetastasesdx.ItemCount > 0 )
         {
            AV23vMetastasesDX = cmbavVmetastasesdx.getValidValue(AV23vMetastasesDX);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV23vMetastasesDX", AV23vMetastasesDX);
         }
         dynavWzname.Name = "vWZNAME";
         dynavWzname.WebTags = "";
         /* End function init_web_controls */
      }

      protected void init_default_properties( )
      {
         divTablecontent_Internalname = "TABLECONTENT";
         edtavBr_medicalimaging_br_medicalimaging_no_Internalname = "BR_MEDICALIMAGING_BR_MEDICALIMAGING_NO";
         lblTextblockvname_Internalname = "TEXTBLOCKVNAME";
         dynavVname_Internalname = "vVNAME";
         edtavVothername_Internalname = "vVOTHERNAME";
         cellVothername_cell_Internalname = "VOTHERNAME_CELL";
         tblTablemergedvname_Internalname = "TABLEMERGEDVNAME";
         divTablesplittedvname_Internalname = "TABLESPLITTEDVNAME";
         edtavBr_medicalimaging_br_medicalimaging_imagedate_Internalname = "BR_MEDICALIMAGING_BR_MEDICALIMAGING_IMAGEDATE";
         dynavBr_medicalimaging_br_medicalimaging_imagehosp_Internalname = "BR_MEDICALIMAGING_BR_MEDICALIMAGING_IMAGEHOSP";
         edtavBr_medicalimaging_br_medicalimaging_imageage_Internalname = "BR_MEDICALIMAGING_BR_MEDICALIMAGING_IMAGEAGE";
         edtavBr_medicalimaging_br_medicalimaging_tumorsize_Internalname = "BR_MEDICALIMAGING_BR_MEDICALIMAGING_TUMORSIZE";
         cmbavVmetastasesdx_Internalname = "vVMETASTASESDX";
         edtavVmetaloc_Internalname = "vVMETALOC";
         edtavVmetadate_Internalname = "vVMETADATE";
         lblTextblockbr_medicalimaging_br_medicalimaging_preimagediag_Internalname = "TEXTBLOCKBR_MEDICALIMAGING_BR_MEDICALIMAGING_PREIMAGEDIAG";
         edtavBr_medicalimaging_br_medicalimaging_preimagediag_Internalname = "BR_MEDICALIMAGING_BR_MEDICALIMAGING_PREIMAGEDIAG";
         divUnnamedtablebr_medicalimaging_br_medicalimaging_preimagediag_Internalname = "UNNAMEDTABLEBR_MEDICALIMAGING_BR_MEDICALIMAGING_PREIMAGEDIAG";
         lblTextblockwzname_Internalname = "TEXTBLOCKWZNAME";
         dynavWzname_Internalname = "vWZNAME";
         edtavWxname_Internalname = "vWXNAME";
         cellWxname_cell_Internalname = "WXNAME_CELL";
         tblTablemergedwzname_Internalname = "TABLEMERGEDWZNAME";
         divTablesplittedwzname_Internalname = "TABLESPLITTEDWZNAME";
         lblTextblockbr_medicalimaging_br_medicalimaging_imageorgan_Internalname = "TEXTBLOCKBR_MEDICALIMAGING_BR_MEDICALIMAGING_IMAGEORGAN";
         edtavBr_medicalimaging_br_medicalimaging_imageorgan_Internalname = "BR_MEDICALIMAGING_BR_MEDICALIMAGING_IMAGEORGAN";
         divUnnamedtablebr_medicalimaging_br_medicalimaging_imageorgan_Internalname = "UNNAMEDTABLEBR_MEDICALIMAGING_BR_MEDICALIMAGING_IMAGEORGAN";
         lblTextblockbr_medicalimaging_br_medicalimaging_imagedes_Internalname = "TEXTBLOCKBR_MEDICALIMAGING_BR_MEDICALIMAGING_IMAGEDES";
         edtavBr_medicalimaging_br_medicalimaging_imagedes_Internalname = "BR_MEDICALIMAGING_BR_MEDICALIMAGING_IMAGEDES";
         divUnnamedtablebr_medicalimaging_br_medicalimaging_imagedes_Internalname = "UNNAMEDTABLEBR_MEDICALIMAGING_BR_MEDICALIMAGING_IMAGEDES";
         divTableattributes_Internalname = "TABLEATTRIBUTES";
         divLayout_tableattributes_Internalname = "LAYOUT_TABLEATTRIBUTES";
         Dvpanel_tableattributes_Internalname = "DVPANEL_TABLEATTRIBUTES";
         divHtml_dvpanel_tableattributes_Internalname = "HTML_DVPANEL_TABLEATTRIBUTES";
         bttBtnenter_Internalname = "BTNENTER";
         bttBtncancel_Internalname = "BTNCANCEL";
         divTablemain_Internalname = "TABLEMAIN";
         edtavBr_medicalimaging_br_medicalimagingid_Internalname = "BR_MEDICALIMAGING_BR_MEDICALIMAGINGID";
         edtavBr_medicalimaging_br_encounterid_Internalname = "BR_MEDICALIMAGING_BR_ENCOUNTERID";
         edtavBr_medicalimaging_br_information_patientno_Internalname = "BR_MEDICALIMAGING_BR_INFORMATION_PATIENTNO";
         edtavBr_medicalimaging_br_medicalimaging_id_Internalname = "BR_MEDICALIMAGING_BR_MEDICALIMAGING_ID";
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
         edtavVothername_Jsonclick = "";
         edtavVothername_Enabled = 1;
         cellVothername_cell_Class = "";
         dynavVname_Jsonclick = "";
         dynavVname.Enabled = 1;
         edtavWxname_Jsonclick = "";
         edtavWxname_Enabled = 1;
         cellWxname_cell_Class = "";
         dynavWzname_Jsonclick = "";
         dynavWzname.Enabled = 1;
         edtavWxname_Visible = 1;
         edtavVothername_Visible = 1;
         edtavBr_medicalimaging_br_medicalimaging_id_Jsonclick = "";
         edtavBr_medicalimaging_br_medicalimaging_id_Visible = 1;
         edtavBr_medicalimaging_br_information_patientno_Jsonclick = "";
         edtavBr_medicalimaging_br_information_patientno_Visible = 1;
         edtavBr_medicalimaging_br_encounterid_Jsonclick = "";
         edtavBr_medicalimaging_br_encounterid_Visible = 1;
         edtavBr_medicalimaging_br_medicalimagingid_Jsonclick = "";
         edtavBr_medicalimaging_br_medicalimagingid_Visible = 1;
         edtavBr_medicalimaging_br_medicalimaging_imagedes_Enabled = 1;
         edtavBr_medicalimaging_br_medicalimaging_imageorgan_Enabled = 1;
         edtavBr_medicalimaging_br_medicalimaging_preimagediag_Enabled = 1;
         edtavVmetadate_Jsonclick = "";
         edtavVmetadate_Enabled = 1;
         edtavVmetadate_Visible = 1;
         edtavVmetaloc_Jsonclick = "";
         edtavVmetaloc_Enabled = 1;
         edtavVmetaloc_Visible = 1;
         cmbavVmetastasesdx_Jsonclick = "";
         cmbavVmetastasesdx.Enabled = 1;
         edtavBr_medicalimaging_br_medicalimaging_tumorsize_Jsonclick = "";
         edtavBr_medicalimaging_br_medicalimaging_tumorsize_Enabled = 1;
         edtavBr_medicalimaging_br_medicalimaging_imageage_Jsonclick = "";
         edtavBr_medicalimaging_br_medicalimaging_imageage_Enabled = 1;
         dynavBr_medicalimaging_br_medicalimaging_imagehosp_Jsonclick = "";
         dynavBr_medicalimaging_br_medicalimaging_imagehosp.Enabled = 1;
         edtavBr_medicalimaging_br_medicalimaging_imagedate_Jsonclick = "";
         edtavBr_medicalimaging_br_medicalimaging_imagedate_Enabled = 1;
         edtavBr_medicalimaging_br_medicalimaging_no_Jsonclick = "";
         edtavBr_medicalimaging_br_medicalimaging_no_Enabled = 1;
         Dvpanel_tableattributes_Autoscroll = Convert.ToBoolean( 0);
         Dvpanel_tableattributes_Iconposition = "left";
         Dvpanel_tableattributes_Showcollapseicon = Convert.ToBoolean( 0);
         Dvpanel_tableattributes_Autoheight = Convert.ToBoolean( -1);
         Dvpanel_tableattributes_Autowidth = Convert.ToBoolean( 0);
         Dvpanel_tableattributes_Collapsed = Convert.ToBoolean( 0);
         Dvpanel_tableattributes_Collapsible = Convert.ToBoolean( 0);
         Dvpanel_tableattributes_Title = "影像学";
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
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[{av:'AV18BR_EncounterID',fld:'vBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true}]");
         setEventMetadata("REFRESH",",oparms:[]}");
         setEventMetadata("ENTER","{handler:'E13972',iparms:[{av:'AV10BR_MedicalImaging',fld:'vBR_MEDICALIMAGING',pic:''},{av:'dynavVname'},{av:'AV11vName',fld:'vVNAME',pic:''},{av:'AV12vOtherName',fld:'vVOTHERNAME',pic:''},{av:'dynavWzname'},{av:'AV14wzName',fld:'vWZNAME',pic:''},{av:'AV15wxName',fld:'vWXNAME',pic:''},{av:'AV18BR_EncounterID',fld:'vBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true},{av:'AV24vMetaLoc',fld:'vVMETALOC',pic:''},{av:'AV25vMetaDate',fld:'vVMETADATE',pic:''},{av:'cmbavVmetastasesdx'},{av:'AV23vMetastasesDX',fld:'vVMETASTASESDX',pic:''}]");
         setEventMetadata("ENTER",",oparms:[{av:'AV10BR_MedicalImaging',fld:'vBR_MEDICALIMAGING',pic:''}]}");
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
         AV17tCurrentCode = "";
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         GXKey = "";
         AV10BR_MedicalImaging = new SdtBR_MedicalImaging(context);
         GX_FocusControl = "";
         Form = new GXWebForm();
         sPrefix = "";
         ClassString = "";
         StyleString = "";
         ucDvpanel_tableattributes = new GXUserControl();
         TempTags = "";
         lblTextblockvname_Jsonclick = "";
         AV23vMetastasesDX = "";
         AV24vMetaLoc = "";
         AV25vMetaDate = DateTime.MinValue;
         lblTextblockbr_medicalimaging_br_medicalimaging_preimagediag_Jsonclick = "";
         lblTextblockwzname_Jsonclick = "";
         lblTextblockbr_medicalimaging_br_medicalimaging_imageorgan_Jsonclick = "";
         lblTextblockbr_medicalimaging_br_medicalimaging_imagedes_Jsonclick = "";
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
         H00972_A167XT_DefineCodeID = new long[1] ;
         H00972_A168XT_DefineCodeName = new String[] {""} ;
         H00972_n168XT_DefineCodeName = new bool[] {false} ;
         H00972_A165XT_DefindcodeTypeID = new long[1] ;
         H00972_A432XT_TenantCode = new String[] {""} ;
         H00972_n432XT_TenantCode = new bool[] {false} ;
         H00973_A167XT_DefineCodeID = new long[1] ;
         H00973_A168XT_DefineCodeName = new String[] {""} ;
         H00973_n168XT_DefineCodeName = new bool[] {false} ;
         H00973_A165XT_DefindcodeTypeID = new long[1] ;
         H00973_A432XT_TenantCode = new String[] {""} ;
         H00973_n432XT_TenantCode = new bool[] {false} ;
         AV14wzName = "";
         H00974_A167XT_DefineCodeID = new long[1] ;
         H00974_A168XT_DefineCodeName = new String[] {""} ;
         H00974_n168XT_DefineCodeName = new bool[] {false} ;
         H00974_A165XT_DefindcodeTypeID = new long[1] ;
         H00974_A432XT_TenantCode = new String[] {""} ;
         H00974_n432XT_TenantCode = new bool[] {false} ;
         AV11vName = "";
         AV12vOtherName = "";
         AV15wxName = "";
         AV26vtest = "";
         AV8Messages = new GXBaseCollection<SdtMessages_Message>( context, "Message", "GeneXus");
         AV7Message = new SdtMessages_Message(context);
         AV9Context = new GeneXus.Programs.wwpbaseobjects.SdtWWPContext(context);
         GXt_char1 = "";
         AV21ErrorMsg = "";
         AV42GXV14 = new GXBaseCollection<SdtMessages_Message>( context, "Message", "GeneXus");
         sStyleString = "";
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         pr_datastore1 = new DataStoreProvider(context, new GeneXus.Programs.br_medicalimaginginsert__datastore1(),
            new Object[][] {
            }
         );
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.br_medicalimaginginsert__default(),
            new Object[][] {
                new Object[] {
               H00972_A167XT_DefineCodeID, H00972_A168XT_DefineCodeName, H00972_n168XT_DefineCodeName, H00972_A165XT_DefindcodeTypeID, H00972_A432XT_TenantCode, H00972_n432XT_TenantCode
               }
               , new Object[] {
               H00973_A167XT_DefineCodeID, H00973_A168XT_DefineCodeName, H00973_n168XT_DefineCodeName, H00973_A165XT_DefindcodeTypeID, H00973_A432XT_TenantCode, H00973_n432XT_TenantCode
               }
               , new Object[] {
               H00974_A167XT_DefineCodeID, H00974_A168XT_DefineCodeName, H00974_n168XT_DefineCodeName, H00974_A165XT_DefindcodeTypeID, H00974_A432XT_TenantCode, H00974_n432XT_TenantCode
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
      private int edtavBr_medicalimaging_br_medicalimaging_no_Enabled ;
      private int edtavBr_medicalimaging_br_medicalimaging_imagedate_Enabled ;
      private int edtavBr_medicalimaging_br_medicalimaging_imageage_Enabled ;
      private int edtavBr_medicalimaging_br_medicalimaging_tumorsize_Enabled ;
      private int edtavVmetaloc_Visible ;
      private int edtavVmetaloc_Enabled ;
      private int edtavVmetadate_Visible ;
      private int edtavVmetadate_Enabled ;
      private int edtavBr_medicalimaging_br_medicalimaging_preimagediag_Enabled ;
      private int edtavBr_medicalimaging_br_medicalimaging_imageorgan_Enabled ;
      private int edtavBr_medicalimaging_br_medicalimaging_imagedes_Enabled ;
      private int edtavBr_medicalimaging_br_medicalimagingid_Visible ;
      private int edtavBr_medicalimaging_br_encounterid_Visible ;
      private int edtavBr_medicalimaging_br_information_patientno_Visible ;
      private int edtavBr_medicalimaging_br_medicalimaging_id_Visible ;
      private int gxdynajaxindex ;
      private int edtavVothername_Visible ;
      private int edtavWxname_Visible ;
      private int AV41GXV13 ;
      private int AV43GXV15 ;
      private int edtavWxname_Enabled ;
      private int edtavVothername_Enabled ;
      private int idxLst ;
      private long AV18BR_EncounterID ;
      private long wcpOAV18BR_EncounterID ;
      private long AV20BR_MedicalImagingID ;
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
      private String edtavBr_medicalimaging_br_medicalimaging_no_Internalname ;
      private String TempTags ;
      private String edtavBr_medicalimaging_br_medicalimaging_no_Jsonclick ;
      private String divTablesplittedvname_Internalname ;
      private String lblTextblockvname_Internalname ;
      private String lblTextblockvname_Jsonclick ;
      private String edtavBr_medicalimaging_br_medicalimaging_imagedate_Internalname ;
      private String edtavBr_medicalimaging_br_medicalimaging_imagedate_Jsonclick ;
      private String dynavBr_medicalimaging_br_medicalimaging_imagehosp_Internalname ;
      private String dynavBr_medicalimaging_br_medicalimaging_imagehosp_Jsonclick ;
      private String edtavBr_medicalimaging_br_medicalimaging_imageage_Internalname ;
      private String edtavBr_medicalimaging_br_medicalimaging_imageage_Jsonclick ;
      private String edtavBr_medicalimaging_br_medicalimaging_tumorsize_Internalname ;
      private String edtavBr_medicalimaging_br_medicalimaging_tumorsize_Jsonclick ;
      private String cmbavVmetastasesdx_Internalname ;
      private String cmbavVmetastasesdx_Jsonclick ;
      private String edtavVmetaloc_Internalname ;
      private String edtavVmetaloc_Jsonclick ;
      private String edtavVmetadate_Internalname ;
      private String edtavVmetadate_Jsonclick ;
      private String divUnnamedtablebr_medicalimaging_br_medicalimaging_preimagediag_Internalname ;
      private String lblTextblockbr_medicalimaging_br_medicalimaging_preimagediag_Internalname ;
      private String lblTextblockbr_medicalimaging_br_medicalimaging_preimagediag_Jsonclick ;
      private String edtavBr_medicalimaging_br_medicalimaging_preimagediag_Internalname ;
      private String divTablesplittedwzname_Internalname ;
      private String lblTextblockwzname_Internalname ;
      private String lblTextblockwzname_Jsonclick ;
      private String divUnnamedtablebr_medicalimaging_br_medicalimaging_imageorgan_Internalname ;
      private String lblTextblockbr_medicalimaging_br_medicalimaging_imageorgan_Internalname ;
      private String lblTextblockbr_medicalimaging_br_medicalimaging_imageorgan_Jsonclick ;
      private String edtavBr_medicalimaging_br_medicalimaging_imageorgan_Internalname ;
      private String divUnnamedtablebr_medicalimaging_br_medicalimaging_imagedes_Internalname ;
      private String lblTextblockbr_medicalimaging_br_medicalimaging_imagedes_Internalname ;
      private String lblTextblockbr_medicalimaging_br_medicalimaging_imagedes_Jsonclick ;
      private String edtavBr_medicalimaging_br_medicalimaging_imagedes_Internalname ;
      private String bttBtnenter_Internalname ;
      private String bttBtnenter_Jsonclick ;
      private String bttBtncancel_Internalname ;
      private String bttBtncancel_Jsonclick ;
      private String divHtml_bottomauxiliarcontrols_Internalname ;
      private String edtavBr_medicalimaging_br_medicalimagingid_Internalname ;
      private String edtavBr_medicalimaging_br_medicalimagingid_Jsonclick ;
      private String edtavBr_medicalimaging_br_encounterid_Internalname ;
      private String edtavBr_medicalimaging_br_encounterid_Jsonclick ;
      private String edtavBr_medicalimaging_br_information_patientno_Internalname ;
      private String edtavBr_medicalimaging_br_information_patientno_Jsonclick ;
      private String edtavBr_medicalimaging_br_medicalimaging_id_Internalname ;
      private String edtavBr_medicalimaging_br_medicalimaging_id_Jsonclick ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String gxwrpcisep ;
      private String scmdbuf ;
      private String dynavVname_Internalname ;
      private String dynavWzname_Internalname ;
      private String edtavVothername_Internalname ;
      private String edtavWxname_Internalname ;
      private String cellVothername_cell_Class ;
      private String cellVothername_cell_Internalname ;
      private String cellWxname_cell_Class ;
      private String cellWxname_cell_Internalname ;
      private String GXt_char1 ;
      private String sStyleString ;
      private String tblTablemergedwzname_Internalname ;
      private String dynavWzname_Jsonclick ;
      private String edtavWxname_Jsonclick ;
      private String tblTablemergedvname_Internalname ;
      private String dynavVname_Jsonclick ;
      private String edtavVothername_Jsonclick ;
      private DateTime AV25vMetaDate ;
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
      private bool AV16CheckRequiredFieldsResult ;
      private bool AV22tCheckFlag ;
      private bool AV19tFlag ;
      private String AV17tCurrentCode ;
      private String AV23vMetastasesDX ;
      private String AV24vMetaLoc ;
      private String AV14wzName ;
      private String AV11vName ;
      private String AV12vOtherName ;
      private String AV15wxName ;
      private String AV26vtest ;
      private String AV21ErrorMsg ;
      private GeneXus.Utils.GxStringCollection gxdynajaxctrlcodr ;
      private GeneXus.Utils.GxStringCollection gxdynajaxctrldescr ;
      private GXUserControl ucDvpanel_tableattributes ;
      private IGxDataStore dsDataStore1 ;
      private IGxDataStore dsDefault ;
      private GXCombobox dynavVname ;
      private GXCombobox dynavBr_medicalimaging_br_medicalimaging_imagehosp ;
      private GXCombobox cmbavVmetastasesdx ;
      private GXCombobox dynavWzname ;
      private IDataStoreProvider pr_default ;
      private long[] H00972_A167XT_DefineCodeID ;
      private String[] H00972_A168XT_DefineCodeName ;
      private bool[] H00972_n168XT_DefineCodeName ;
      private long[] H00972_A165XT_DefindcodeTypeID ;
      private String[] H00972_A432XT_TenantCode ;
      private bool[] H00972_n432XT_TenantCode ;
      private long[] H00973_A167XT_DefineCodeID ;
      private String[] H00973_A168XT_DefineCodeName ;
      private bool[] H00973_n168XT_DefineCodeName ;
      private long[] H00973_A165XT_DefindcodeTypeID ;
      private String[] H00973_A432XT_TenantCode ;
      private bool[] H00973_n432XT_TenantCode ;
      private long[] H00974_A167XT_DefineCodeID ;
      private String[] H00974_A168XT_DefineCodeName ;
      private bool[] H00974_n168XT_DefineCodeName ;
      private long[] H00974_A165XT_DefindcodeTypeID ;
      private String[] H00974_A432XT_TenantCode ;
      private bool[] H00974_n432XT_TenantCode ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private IDataStoreProvider pr_datastore1 ;
      private GXBaseCollection<SdtMessages_Message> AV8Messages ;
      private GXBaseCollection<SdtMessages_Message> AV42GXV14 ;
      private GXWebForm Form ;
      private SdtMessages_Message AV7Message ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPContext AV9Context ;
      private SdtBR_MedicalImaging AV10BR_MedicalImaging ;
   }

   public class br_medicalimaginginsert__datastore1 : DataStoreHelperBase, IDataStoreHelper
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

 public class br_medicalimaginginsert__default : DataStoreHelperBase, IDataStoreHelper
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
        Object[] prmH00972 ;
        prmH00972 = new Object[] {
        new Object[] {"@AV17tCurrentCode",SqlDbType.NVarChar,40,0}
        } ;
        Object[] prmH00973 ;
        prmH00973 = new Object[] {
        new Object[] {"@AV17tCurrentCode",SqlDbType.NVarChar,40,0}
        } ;
        Object[] prmH00974 ;
        prmH00974 = new Object[] {
        new Object[] {"@AV17tCurrentCode",SqlDbType.NVarChar,40,0}
        } ;
        def= new CursorDef[] {
            new CursorDef("H00972", "SELECT [XT_DefineCodeID], [XT_DefineCodeName], [XT_DefindcodeTypeID], [XT_TenantCode] FROM [XT_DefineCode] WITH (NOLOCK) WHERE ([XT_DefindcodeTypeID] = 30) AND ([XT_TenantCode] = @AV17tCurrentCode) ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH00972,0,0,true,false )
           ,new CursorDef("H00973", "SELECT [XT_DefineCodeID], [XT_DefineCodeName], [XT_DefindcodeTypeID], [XT_TenantCode] FROM [XT_DefineCode] WITH (NOLOCK) WHERE ([XT_DefindcodeTypeID] = 31) AND ([XT_TenantCode] = @AV17tCurrentCode) ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH00973,0,0,true,false )
           ,new CursorDef("H00974", "SELECT [XT_DefineCodeID], [XT_DefineCodeName], [XT_DefindcodeTypeID], [XT_TenantCode] FROM [XT_DefineCode] WITH (NOLOCK) WHERE ([XT_DefindcodeTypeID] = 34) AND ([XT_TenantCode] = @AV17tCurrentCode) ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH00974,0,0,true,false )
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
