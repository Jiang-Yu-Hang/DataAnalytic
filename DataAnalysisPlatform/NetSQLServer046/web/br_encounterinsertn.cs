/*
               File: BR_EncounterInsertN
        Description: Data Mgmt Portal - RAAP
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/27/2020 12:7:14.84
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
   public class br_encounterinsertn : GXDataArea, System.Web.SessionState.IRequiresSessionState
   {
      public br_encounterinsertn( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public br_encounterinsertn( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( long aP0_BR_Information_ID )
      {
         this.AV20BR_Information_ID = aP0_BR_Information_ID;
         executePrivate();
      }

      void executePrivate( )
      {
         isStatic = false;
         webExecute();
      }

      protected override void createObjects( )
      {
         dynavVdepartment = new GXCombobox();
         dynavVenctype = new GXCombobox();
         dynavVadminsource = new GXCombobox();
         dynavVdischargestatus = new GXCombobox();
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
            else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxCallCrl"+"_"+"vVDEPARTMENT") == 0 )
            {
               AV18tCurrentCode = GetNextPar( );
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1;
                  return  ;
               }
               GXDLVvVDEPARTMENTA72( AV18tCurrentCode) ;
               return  ;
            }
            else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxCallCrl"+"_"+"vVENCTYPE") == 0 )
            {
               AV18tCurrentCode = GetNextPar( );
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1;
                  return  ;
               }
               GXDLVvVENCTYPEA72( AV18tCurrentCode) ;
               return  ;
            }
            else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxCallCrl"+"_"+"vVADMINSOURCE") == 0 )
            {
               AV18tCurrentCode = GetNextPar( );
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1;
                  return  ;
               }
               GXDLVvVADMINSOURCEA72( AV18tCurrentCode) ;
               return  ;
            }
            else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxCallCrl"+"_"+"vVDISCHARGESTATUS") == 0 )
            {
               AV18tCurrentCode = GetNextPar( );
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1;
                  return  ;
               }
               GXDLVvVDISCHARGESTATUSA72( AV18tCurrentCode) ;
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
               AV20BR_Information_ID = (long)(NumberUtil.Val( gxfirstwebparm, "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV20BR_Information_ID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV20BR_Information_ID), 18, 0)));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vBR_INFORMATION_ID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV20BR_Information_ID), "ZZZZZZZZZZZZZZZZZZ"), context));
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
         PAA72( ) ;
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0));
         if ( ( gxajaxcallmode == 0 ) && ( GxWebError == 0 ) )
         {
            STARTA72( ) ;
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
         context.AddJavascriptSource("gxcfg.js", "?2020227127155", false);
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" autocomplete=\"off\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("br_encounterinsertn.aspx") + "?" + UrlEncode("" +AV20BR_Information_ID)+"\">") ;
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
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "Br_encounter", AV9BR_Encounter);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("Br_encounter", AV9BR_Encounter);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vBR_ENCOUNTER", AV9BR_Encounter);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vBR_ENCOUNTER", AV9BR_Encounter);
         }
         GxWebStd.gx_hidden_field( context, "vBR_INFORMATION_ID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV20BR_Information_ID), 18, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "gxhash_vBR_INFORMATION_ID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV20BR_Information_ID), "ZZZZZZZZZZZZZZZZZZ"), context));
         GxWebStd.gx_hidden_field( context, "vTCURRENTCODE", AV18tCurrentCode);
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
            WEA72( ) ;
            context.WriteHtmlText( "</div>") ;
         }
      }

      public override void DispatchEvents( )
      {
         EVTA72( ) ;
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
         return formatLink("br_encounterinsertn.aspx") + "?" + UrlEncode("" +AV20BR_Information_ID) ;
      }

      public override String GetPgmname( )
      {
         return "BR_EncounterInsertN" ;
      }

      public override String GetPgmdesc( )
      {
         return "Data Mgmt Portal - RAAP" ;
      }

      protected void WBA70( )
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
            GxWebStd.gx_div_start( context, divTablemain_Internalname, 1, 0, "px", 0, "px", "TableMain", "left", "top", "", "", "div");
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
            GxWebStd.gx_div_start( context, divTablecontent_Internalname, 1, 0, "px", 0, "px", "", "left", "top", "", "", "div");
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
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtavVpatientno_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavVpatientno_Internalname, "患者编号", "col-sm-3 ReadonlyAttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 25,'',false,'',0)\"";
            ClassString = "ReadonlyAttribute";
            StyleString = "";
            ClassString = "ReadonlyAttribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavVpatientno_Internalname, AV8vPatientNo, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,25);\"", 0, 1, edtavVpatientno_Enabled, 0, 80, "chr", 10, "row", StyleString, ClassString, "", "", "2000", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_EncounterInsertN.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divTablesplittedvdepartment_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-3 MergeLabelCell", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblockvdepartment_Internalname, "就诊科室", "", "", lblTextblockvdepartment_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_BR_EncounterInsertN.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-9", "left", "top", "", "", "div");
            wb_table1_32_A72( true) ;
         }
         else
         {
            wb_table1_32_A72( false) ;
         }
         return  ;
      }

      protected void wb_table1_32_A72e( bool wbgen )
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
            GxWebStd.gx_div_start( context, divTablesplittedvenctype_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-3 MergeLabelCell", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblockvenctype_Internalname, "就诊方式", "", "", lblTextblockvenctype_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_BR_EncounterInsertN.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-9", "left", "top", "", "", "div");
            wb_table2_47_A72( true) ;
         }
         else
         {
            wb_table2_47_A72( false) ;
         }
         return  ;
      }

      protected void wb_table2_47_A72e( bool wbgen )
      {
         if ( wbgen )
         {
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtavBr_encounter_br_encounter_admitdate_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavBr_encounter_br_encounter_admitdate_Internalname, "就诊/入院时间", "col-sm-3 AttributeDateLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 58,'',false,'',0)\"";
            context.WriteHtmlText( "<div id=\""+edtavBr_encounter_br_encounter_admitdate_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtavBr_encounter_br_encounter_admitdate_Internalname, context.localUtil.Format(AV9BR_Encounter.gxTpr_Br_encounter_admitdate, "9999/99/99"), context.localUtil.Format( AV9BR_Encounter.gxTpr_Br_encounter_admitdate, "9999/99/99"), TempTags+" onchange=\""+"gx.date.valid_date(this, 10,'YMD',0,24,'chs',false,0);"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,58);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavBr_encounter_br_encounter_admitdate_Jsonclick, 0, "AttributeDate", "", "", "", "", 1, edtavBr_encounter_br_encounter_admitdate_Enabled, 0, "text", "", 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_BR_EncounterInsertN.htm");
            GxWebStd.gx_bitmap( context, edtavBr_encounter_br_encounter_admitdate_Internalname+"_dp_trigger", context.GetImagePath( "61b9b5d3-dff6-4d59-9b00-da61bc2cbe93", "", context.GetTheme( )), "", "", "", "", ((1==0)||(edtavBr_encounter_br_encounter_admitdate_Enabled==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;", "", "", "", "", "", "", "", "", 1, false, false, "", "HLP_BR_EncounterInsertN.htm");
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
            GxWebStd.gx_div_start( context, divTablesplittedvadminsource_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-3 MergeLabelCell", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblockvadminsource_Internalname, "入院原因", "", "", lblTextblockvadminsource_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_BR_EncounterInsertN.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-9", "left", "top", "", "", "div");
            wb_table3_66_A72( true) ;
         }
         else
         {
            wb_table3_66_A72( false) ;
         }
         return  ;
      }

      protected void wb_table3_66_A72e( bool wbgen )
      {
         if ( wbgen )
         {
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtavBr_encounter_br_encounter_dischargedate_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavBr_encounter_br_encounter_dischargedate_Internalname, "出院时间", "col-sm-3 AttributeDateLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 77,'',false,'',0)\"";
            context.WriteHtmlText( "<div id=\""+edtavBr_encounter_br_encounter_dischargedate_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtavBr_encounter_br_encounter_dischargedate_Internalname, context.localUtil.Format(AV9BR_Encounter.gxTpr_Br_encounter_dischargedate, "9999/99/99"), context.localUtil.Format( AV9BR_Encounter.gxTpr_Br_encounter_dischargedate, "9999/99/99"), TempTags+" onchange=\""+"gx.date.valid_date(this, 10,'YMD',0,24,'chs',false,0);"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,77);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavBr_encounter_br_encounter_dischargedate_Jsonclick, 0, "AttributeDate", "", "", "", "", 1, edtavBr_encounter_br_encounter_dischargedate_Enabled, 0, "text", "", 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_BR_EncounterInsertN.htm");
            GxWebStd.gx_bitmap( context, edtavBr_encounter_br_encounter_dischargedate_Internalname+"_dp_trigger", context.GetImagePath( "61b9b5d3-dff6-4d59-9b00-da61bc2cbe93", "", context.GetTheme( )), "", "", "", "", ((1==0)||(edtavBr_encounter_br_encounter_dischargedate_Enabled==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;", "", "", "", "", "", "", "", "", 1, false, false, "", "HLP_BR_EncounterInsertN.htm");
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
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+dynavVdischargestatus_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, dynavVdischargestatus_Internalname, "出院状态", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 82,'',false,'',0)\"";
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, dynavVdischargestatus, dynavVdischargestatus_Internalname, StringUtil.RTrim( AV16vDischargeStatus), 1, dynavVdischargestatus_Jsonclick, 0, "'"+""+"'"+",false,"+"'"+""+"'", "svchar", "", 1, dynavVdischargestatus.Enabled, 0, 0, 0, "em", 0, "", "", "Attribute", "", "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,82);\"", "", true, "HLP_BR_EncounterInsertN.htm");
            dynavVdischargestatus.CurrentValue = StringUtil.RTrim( AV16vDischargeStatus);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynavVdischargestatus_Internalname, "Values", (String)(dynavVdischargestatus.ToJavascriptSource()), true);
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
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 87,'',false,'',0)\"";
            ClassString = "ButtonMaterial";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtnminsave_Internalname, "", "保存", bttBtnminsave_Jsonclick, 5, "保存", "", StyleString, ClassString, 1, 1, "standard", "'"+""+"'"+",false,"+"'"+"E\\'DOMINSAVE\\'."+"'", TempTags, "", context.GetButtonType( ), "HLP_BR_EncounterInsertN.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 89,'',false,'',0)\"";
            ClassString = "ButtonMaterial";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtnenter_Internalname, "", "保存", bttBtnenter_Jsonclick, 5, "确认", "", StyleString, ClassString, 1, 1, "standard", "'"+""+"'"+",false,"+"'"+"EENTER."+"'", TempTags, "", context.GetButtonType( ), "HLP_BR_EncounterInsertN.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 91,'',false,'',0)\"";
            ClassString = "ButtonMaterialDefault";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtncancel_Internalname, "", "取消", bttBtncancel_Jsonclick, 1, "取消", "", StyleString, ClassString, 1, 1, "standard", "'"+""+"'"+",false,"+"'"+"ECANCEL."+"'", TempTags, "", context.GetButtonType( ), "HLP_BR_EncounterInsertN.htm");
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
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 95,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavVinformationid_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV7vInformationID), 18, 0, ".", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(AV7vInformationID), "ZZZZZZZZZZZZZZZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,95);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavVinformationid_Jsonclick, 0, "Attribute", "", "", "", "", 1, 1, 0, "number", "1", 18, "chr", 1, "row", 18, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_BR_EncounterInsertN.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 96,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavBr_encounter_br_encounterid_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV9BR_Encounter.gxTpr_Br_encounterid), 18, 0, ".", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(AV9BR_Encounter.gxTpr_Br_encounterid), "ZZZZZZZZZZZZZZZZZZ")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,96);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavBr_encounter_br_encounterid_Jsonclick, 0, "Attribute", "", "", "", "", 1, 1, 0, "number", "1", 18, "chr", 1, "row", 18, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_BR_EncounterInsertN.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 97,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavBr_encounter_br_encounter_encid_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV9BR_Encounter.gxTpr_Br_encounter_encid), 10, 0, ".", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(AV9BR_Encounter.gxTpr_Br_encounter_encid), "ZZZZZZZZZZ")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,97);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavBr_encounter_br_encounter_encid_Jsonclick, 0, "Attribute", "", "", "", "", 1, 1, 0, "number", "1", 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_BR_EncounterInsertN.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
         }
         wbLoad = true;
      }

      protected void STARTA72( )
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
         STRUPA70( ) ;
      }

      protected void WSA72( )
      {
         STARTA72( ) ;
         EVTA72( ) ;
      }

      protected void EVTA72( )
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
                              E11A72 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "'DOMINSAVE'") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              /* Execute user event: 'Dominsave' */
                              E12A72 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "LOAD") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              /* Execute user event: Load */
                              E13A72 ();
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

      protected void WEA72( )
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

      protected void PAA72( )
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
               GX_FocusControl = edtavVpatientno_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
            nDonePA = 1;
         }
      }

      protected void dynload_actions( )
      {
         /* End function dynload_actions */
      }

      protected void GXDLVvVDEPARTMENTA72( String AV18tCurrentCode )
      {
         if ( ! context.isAjaxRequest( ) )
         {
            context.GX_webresponse.AppendHeader("Cache-Control", "no-store");
         }
         context.GX_webresponse.AddString("[[");
         GXDLVvVDEPARTMENT_dataA72( AV18tCurrentCode) ;
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

      protected void GXVvVDEPARTMENT_htmlA72( String AV18tCurrentCode )
      {
         String gxdynajaxvalue ;
         GXDLVvVDEPARTMENT_dataA72( AV18tCurrentCode) ;
         gxdynajaxindex = 1;
         if ( ! ( gxdyncontrolsrefreshing && context.isAjaxRequest( ) ) )
         {
            dynavVdepartment.removeAllItems();
         }
         while ( gxdynajaxindex <= gxdynajaxctrlcodr.Count )
         {
            gxdynajaxvalue = ((String)gxdynajaxctrlcodr.Item(gxdynajaxindex));
            dynavVdepartment.addItem(gxdynajaxvalue, ((String)gxdynajaxctrldescr.Item(gxdynajaxindex)), 0);
            gxdynajaxindex = (int)(gxdynajaxindex+1);
         }
      }

      protected void GXDLVvVDEPARTMENT_dataA72( String AV18tCurrentCode )
      {
         gxdynajaxctrlcodr.Clear();
         gxdynajaxctrldescr.Clear();
         gxdynajaxctrlcodr.Add("");
         gxdynajaxctrldescr.Add("(请选择)");
         /* Using cursor H00A72 */
         pr_default.execute(0, new Object[] {AV18tCurrentCode});
         while ( (pr_default.getStatus(0) != 101) )
         {
            gxdynajaxctrlcodr.Add(H00A72_A168XT_DefineCodeName[0]);
            gxdynajaxctrldescr.Add(H00A72_A168XT_DefineCodeName[0]);
            pr_default.readNext(0);
         }
         pr_default.close(0);
      }

      protected void GXDLVvVENCTYPEA72( String AV18tCurrentCode )
      {
         if ( ! context.isAjaxRequest( ) )
         {
            context.GX_webresponse.AppendHeader("Cache-Control", "no-store");
         }
         context.GX_webresponse.AddString("[[");
         GXDLVvVENCTYPE_dataA72( AV18tCurrentCode) ;
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

      protected void GXVvVENCTYPE_htmlA72( String AV18tCurrentCode )
      {
         String gxdynajaxvalue ;
         GXDLVvVENCTYPE_dataA72( AV18tCurrentCode) ;
         gxdynajaxindex = 1;
         if ( ! ( gxdyncontrolsrefreshing && context.isAjaxRequest( ) ) )
         {
            dynavVenctype.removeAllItems();
         }
         while ( gxdynajaxindex <= gxdynajaxctrlcodr.Count )
         {
            gxdynajaxvalue = ((String)gxdynajaxctrlcodr.Item(gxdynajaxindex));
            dynavVenctype.addItem(gxdynajaxvalue, ((String)gxdynajaxctrldescr.Item(gxdynajaxindex)), 0);
            gxdynajaxindex = (int)(gxdynajaxindex+1);
         }
      }

      protected void GXDLVvVENCTYPE_dataA72( String AV18tCurrentCode )
      {
         gxdynajaxctrlcodr.Clear();
         gxdynajaxctrldescr.Clear();
         gxdynajaxctrlcodr.Add("");
         gxdynajaxctrldescr.Add("(请选择)");
         /* Using cursor H00A73 */
         pr_default.execute(1, new Object[] {AV18tCurrentCode});
         while ( (pr_default.getStatus(1) != 101) )
         {
            gxdynajaxctrlcodr.Add(H00A73_A168XT_DefineCodeName[0]);
            gxdynajaxctrldescr.Add(H00A73_A168XT_DefineCodeName[0]);
            pr_default.readNext(1);
         }
         pr_default.close(1);
      }

      protected void GXDLVvVADMINSOURCEA72( String AV18tCurrentCode )
      {
         if ( ! context.isAjaxRequest( ) )
         {
            context.GX_webresponse.AppendHeader("Cache-Control", "no-store");
         }
         context.GX_webresponse.AddString("[[");
         GXDLVvVADMINSOURCE_dataA72( AV18tCurrentCode) ;
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

      protected void GXVvVADMINSOURCE_htmlA72( String AV18tCurrentCode )
      {
         String gxdynajaxvalue ;
         GXDLVvVADMINSOURCE_dataA72( AV18tCurrentCode) ;
         gxdynajaxindex = 1;
         if ( ! ( gxdyncontrolsrefreshing && context.isAjaxRequest( ) ) )
         {
            dynavVadminsource.removeAllItems();
         }
         while ( gxdynajaxindex <= gxdynajaxctrlcodr.Count )
         {
            gxdynajaxvalue = ((String)gxdynajaxctrlcodr.Item(gxdynajaxindex));
            dynavVadminsource.addItem(gxdynajaxvalue, ((String)gxdynajaxctrldescr.Item(gxdynajaxindex)), 0);
            gxdynajaxindex = (int)(gxdynajaxindex+1);
         }
      }

      protected void GXDLVvVADMINSOURCE_dataA72( String AV18tCurrentCode )
      {
         gxdynajaxctrlcodr.Clear();
         gxdynajaxctrldescr.Clear();
         gxdynajaxctrlcodr.Add("");
         gxdynajaxctrldescr.Add("(请选择)");
         /* Using cursor H00A74 */
         pr_default.execute(2, new Object[] {AV18tCurrentCode});
         while ( (pr_default.getStatus(2) != 101) )
         {
            gxdynajaxctrlcodr.Add(H00A74_A168XT_DefineCodeName[0]);
            gxdynajaxctrldescr.Add(H00A74_A168XT_DefineCodeName[0]);
            pr_default.readNext(2);
         }
         pr_default.close(2);
      }

      protected void GXDLVvVDISCHARGESTATUSA72( String AV18tCurrentCode )
      {
         if ( ! context.isAjaxRequest( ) )
         {
            context.GX_webresponse.AppendHeader("Cache-Control", "no-store");
         }
         context.GX_webresponse.AddString("[[");
         GXDLVvVDISCHARGESTATUS_dataA72( AV18tCurrentCode) ;
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

      protected void GXVvVDISCHARGESTATUS_htmlA72( String AV18tCurrentCode )
      {
         String gxdynajaxvalue ;
         GXDLVvVDISCHARGESTATUS_dataA72( AV18tCurrentCode) ;
         gxdynajaxindex = 1;
         if ( ! ( gxdyncontrolsrefreshing && context.isAjaxRequest( ) ) )
         {
            dynavVdischargestatus.removeAllItems();
         }
         while ( gxdynajaxindex <= gxdynajaxctrlcodr.Count )
         {
            gxdynajaxvalue = ((String)gxdynajaxctrlcodr.Item(gxdynajaxindex));
            dynavVdischargestatus.addItem(gxdynajaxvalue, ((String)gxdynajaxctrldescr.Item(gxdynajaxindex)), 0);
            gxdynajaxindex = (int)(gxdynajaxindex+1);
         }
      }

      protected void GXDLVvVDISCHARGESTATUS_dataA72( String AV18tCurrentCode )
      {
         gxdynajaxctrlcodr.Clear();
         gxdynajaxctrldescr.Clear();
         gxdynajaxctrlcodr.Add("");
         gxdynajaxctrldescr.Add("(请选择)");
         /* Using cursor H00A75 */
         pr_default.execute(3, new Object[] {AV18tCurrentCode});
         while ( (pr_default.getStatus(3) != 101) )
         {
            gxdynajaxctrlcodr.Add(H00A75_A168XT_DefineCodeName[0]);
            gxdynajaxctrldescr.Add(H00A75_A168XT_DefineCodeName[0]);
            pr_default.readNext(3);
         }
         pr_default.close(3);
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
         if ( dynavVdepartment.ItemCount > 0 )
         {
            AV10vDepartment = dynavVdepartment.getValidValue(AV10vDepartment);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10vDepartment", AV10vDepartment);
         }
         if ( context.isAjaxRequest( ) )
         {
            dynavVdepartment.CurrentValue = StringUtil.RTrim( AV10vDepartment);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynavVdepartment_Internalname, "Values", dynavVdepartment.ToJavascriptSource(), true);
         }
         if ( dynavVenctype.ItemCount > 0 )
         {
            AV12vENCType = dynavVenctype.getValidValue(AV12vENCType);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12vENCType", AV12vENCType);
         }
         if ( context.isAjaxRequest( ) )
         {
            dynavVenctype.CurrentValue = StringUtil.RTrim( AV12vENCType);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynavVenctype_Internalname, "Values", dynavVenctype.ToJavascriptSource(), true);
         }
         if ( dynavVadminsource.ItemCount > 0 )
         {
            AV14vAdminSource = dynavVadminsource.getValidValue(AV14vAdminSource);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14vAdminSource", AV14vAdminSource);
         }
         if ( context.isAjaxRequest( ) )
         {
            dynavVadminsource.CurrentValue = StringUtil.RTrim( AV14vAdminSource);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynavVadminsource_Internalname, "Values", dynavVadminsource.ToJavascriptSource(), true);
         }
         if ( dynavVdischargestatus.ItemCount > 0 )
         {
            AV16vDischargeStatus = dynavVdischargestatus.getValidValue(AV16vDischargeStatus);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV16vDischargeStatus", AV16vDischargeStatus);
         }
         if ( context.isAjaxRequest( ) )
         {
            dynavVdischargestatus.CurrentValue = StringUtil.RTrim( AV16vDischargeStatus);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynavVdischargestatus_Internalname, "Values", dynavVdischargestatus.ToJavascriptSource(), true);
         }
      }

      public void Refresh( )
      {
         send_integrity_hashes( ) ;
         RFA72( ) ;
         if ( isFullAjaxMode( ) )
         {
            send_integrity_footer_hashes( ) ;
         }
      }

      protected void initialize_formulas( )
      {
         /* GeneXus formulas. */
         context.Gx_err = 0;
         edtavVpatientno_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavVpatientno_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavVpatientno_Enabled), 5, 0)), true);
      }

      protected void RFA72( )
      {
         initialize_formulas( ) ;
         clear_multi_value_controls( ) ;
         gxdyncontrolsrefreshing = true;
         fix_multi_value_controls( ) ;
         gxdyncontrolsrefreshing = false;
         if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
         {
            /* Execute user event: Load */
            E13A72 ();
            WBA70( ) ;
         }
      }

      protected void send_integrity_lvl_hashesA72( )
      {
         GxWebStd.gx_hidden_field( context, "vBR_INFORMATION_ID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV20BR_Information_ID), 18, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "gxhash_vBR_INFORMATION_ID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV20BR_Information_ID), "ZZZZZZZZZZZZZZZZZZ"), context));
      }

      protected void STRUPA70( )
      {
         /* Before Start, stand alone formulas. */
         context.Gx_err = 0;
         edtavVpatientno_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavVpatientno_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavVpatientno_Enabled), 5, 0)), true);
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0;
         /* Execute user event: Start */
         E11A72 ();
         context.wbGlbDoneStart = 1;
         /* After Start, stand alone formulas. */
         GXVvVDEPARTMENT_htmlA72( AV18tCurrentCode) ;
         GXVvVENCTYPE_htmlA72( AV18tCurrentCode) ;
         GXVvVADMINSOURCE_htmlA72( AV18tCurrentCode) ;
         GXVvVDISCHARGESTATUS_htmlA72( AV18tCurrentCode) ;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read saved SDTs. */
            ajax_req_read_hidden_sdt(cgiGet( "Br_encounter"), AV9BR_Encounter);
            /* Read variables values. */
            AV8vPatientNo = cgiGet( edtavVpatientno_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8vPatientNo", AV8vPatientNo);
            dynavVdepartment.CurrentValue = cgiGet( dynavVdepartment_Internalname);
            AV10vDepartment = cgiGet( dynavVdepartment_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10vDepartment", AV10vDepartment);
            AV11vOtherDepartment = cgiGet( edtavVotherdepartment_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11vOtherDepartment", AV11vOtherDepartment);
            dynavVenctype.CurrentValue = cgiGet( dynavVenctype_Internalname);
            AV12vENCType = cgiGet( dynavVenctype_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12vENCType", AV12vENCType);
            AV13vOtherENCType = cgiGet( edtavVotherenctype_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13vOtherENCType", AV13vOtherENCType);
            if ( context.localUtil.VCDate( cgiGet( edtavBr_encounter_br_encounter_admitdate_Internalname), 0) == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_faildate", new   object[]  {"就诊/入院时间"}), 1, "BR_ENCOUNTER_BR_ENCOUNTER_ADMITDATE");
               GX_FocusControl = edtavBr_encounter_br_encounter_admitdate_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV9BR_Encounter.gxTpr_Br_encounter_admitdate = DateTime.MinValue;
            }
            else
            {
               AV9BR_Encounter.gxTpr_Br_encounter_admitdate = context.localUtil.CToD( cgiGet( edtavBr_encounter_br_encounter_admitdate_Internalname), 0);
            }
            dynavVadminsource.CurrentValue = cgiGet( dynavVadminsource_Internalname);
            AV14vAdminSource = cgiGet( dynavVadminsource_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14vAdminSource", AV14vAdminSource);
            AV15vOtherReason = cgiGet( edtavVotherreason_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV15vOtherReason", AV15vOtherReason);
            if ( context.localUtil.VCDate( cgiGet( edtavBr_encounter_br_encounter_dischargedate_Internalname), 0) == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_faildate", new   object[]  {"出院时间"}), 1, "BR_ENCOUNTER_BR_ENCOUNTER_DISCHARGEDATE");
               GX_FocusControl = edtavBr_encounter_br_encounter_dischargedate_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV9BR_Encounter.gxTpr_Br_encounter_dischargedate = DateTime.MinValue;
            }
            else
            {
               AV9BR_Encounter.gxTpr_Br_encounter_dischargedate = context.localUtil.CToD( cgiGet( edtavBr_encounter_br_encounter_dischargedate_Internalname), 0);
            }
            dynavVdischargestatus.CurrentValue = cgiGet( dynavVdischargestatus_Internalname);
            AV16vDischargeStatus = cgiGet( dynavVdischargestatus_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV16vDischargeStatus", AV16vDischargeStatus);
            if ( ( ( context.localUtil.CToN( cgiGet( edtavVinformationid_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavVinformationid_Internalname), ".", ",") > Convert.ToDecimal( 999999999999999999L )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vVINFORMATIONID");
               GX_FocusControl = edtavVinformationid_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV7vInformationID = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7vInformationID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV7vInformationID), 18, 0)));
            }
            else
            {
               AV7vInformationID = (long)(context.localUtil.CToN( cgiGet( edtavVinformationid_Internalname), ".", ","));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7vInformationID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV7vInformationID), 18, 0)));
            }
            if ( ( ( context.localUtil.CToN( cgiGet( edtavBr_encounter_br_encounterid_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavBr_encounter_br_encounterid_Internalname), ".", ",") > Convert.ToDecimal( 999999999999999999L )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "BR_ENCOUNTER_BR_ENCOUNTERID");
               GX_FocusControl = edtavBr_encounter_br_encounterid_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV9BR_Encounter.gxTpr_Br_encounterid = 0;
            }
            else
            {
               AV9BR_Encounter.gxTpr_Br_encounterid = (long)(context.localUtil.CToN( cgiGet( edtavBr_encounter_br_encounterid_Internalname), ".", ","));
            }
            if ( ( ( context.localUtil.CToN( cgiGet( edtavBr_encounter_br_encounter_encid_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavBr_encounter_br_encounter_encid_Internalname), ".", ",") > Convert.ToDecimal( 9999999999L )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "BR_ENCOUNTER_BR_ENCOUNTER_ENCID");
               GX_FocusControl = edtavBr_encounter_br_encounter_encid_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV9BR_Encounter.gxTpr_Br_encounter_encid = 0;
            }
            else
            {
               AV9BR_Encounter.gxTpr_Br_encounter_encid = (long)(context.localUtil.CToN( cgiGet( edtavBr_encounter_br_encounter_encid_Internalname), ".", ","));
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
            GXVvVDEPARTMENT_htmlA72( AV18tCurrentCode) ;
            GXVvVENCTYPE_htmlA72( AV18tCurrentCode) ;
            GXVvVADMINSOURCE_htmlA72( AV18tCurrentCode) ;
            GXVvVDISCHARGESTATUS_htmlA72( AV18tCurrentCode) ;
         }
         else
         {
            dynload_actions( ) ;
         }
      }

      protected void GXStart( )
      {
         /* Execute user event: Start */
         E11A72 ();
         if (returnInSub) return;
      }

      protected void E11A72( )
      {
         /* Start Routine */
         GXt_char1 = AV18tCurrentCode;
         new zbr_getcurrenttcode(context ).execute( out  GXt_char1) ;
         AV18tCurrentCode = GXt_char1;
         AV19BR_Information.Load(AV20BR_Information_ID);
         edtavVotherdepartment_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavVotherdepartment_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavVotherdepartment_Visible), 5, 0)), true);
         edtavVotherenctype_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavVotherenctype_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavVotherenctype_Visible), 5, 0)), true);
         edtavVotherreason_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavVotherreason_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavVotherreason_Visible), 5, 0)), true);
         AV7vInformationID = AV20BR_Information_ID;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7vInformationID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV7vInformationID), 18, 0)));
      }

      protected void E12A72( )
      {
         /* 'Dominsave' Routine */
         GX_msglist.addItem("66666");
         AV25tFlag = true;
         if ( ( StringUtil.StrCmp(AV10vDepartment, "其它") == 0 ) && ( AV25tFlag ) )
         {
            if ( String.IsNullOrEmpty(StringUtil.RTrim( AV11vOtherDepartment)) )
            {
               GX_msglist.addItem("其它就诊科室是必须填写的");
               AV25tFlag = false;
            }
            else
            {
               AV9BR_Encounter.gxTpr_Br_encounter_department = AV11vOtherDepartment;
            }
         }
         else
         {
            AV9BR_Encounter.gxTpr_Br_encounter_department = AV10vDepartment;
         }
         if ( ( StringUtil.StrCmp(AV12vENCType, "其它") == 0 ) && ( AV25tFlag ) )
         {
            if ( String.IsNullOrEmpty(StringUtil.RTrim( AV13vOtherENCType)) )
            {
               GX_msglist.addItem("其它就诊方式是必须填写的");
               AV25tFlag = false;
            }
            else
            {
               AV9BR_Encounter.gxTpr_Br_encounter_enctype = AV13vOtherENCType;
            }
         }
         else
         {
            AV9BR_Encounter.gxTpr_Br_encounter_enctype = AV12vENCType;
         }
         if ( ( StringUtil.StrCmp(AV14vAdminSource, "其它") == 0 ) && ( AV25tFlag ) )
         {
            if ( String.IsNullOrEmpty(StringUtil.RTrim( AV15vOtherReason)) )
            {
               GX_msglist.addItem("其它入院原因是必须填写的");
               AV25tFlag = false;
            }
            else
            {
               AV9BR_Encounter.gxTpr_Br_encounter_admitsource = AV15vOtherReason;
            }
         }
         else
         {
            AV9BR_Encounter.gxTpr_Br_encounter_admitsource = AV14vAdminSource;
         }
         if ( AV25tFlag )
         {
            if ( (DateTime.MinValue==AV9BR_Encounter.gxTpr_Br_encounter_admitdate) )
            {
               AV9BR_Encounter.gxTv_SdtBR_Encounter_Br_encounter_admitdate_SetNull();
            }
            if ( (DateTime.MinValue==AV9BR_Encounter.gxTpr_Br_encounter_dischargedate) )
            {
               AV9BR_Encounter.gxTv_SdtBR_Encounter_Br_encounter_dischargedate_SetNull();
            }
            if ( (DateTime.MinValue==AV9BR_Encounter.gxTpr_Br_encounter_approvedate) )
            {
               AV9BR_Encounter.gxTv_SdtBR_Encounter_Br_encounter_approvedate_SetNull();
            }
            if ( (DateTime.MinValue==AV9BR_Encounter.gxTpr_Br_encounter_recheckdate) )
            {
               AV9BR_Encounter.gxTv_SdtBR_Encounter_Br_encounter_recheckdate_SetNull();
            }
            if ( (DateTime.MinValue==AV9BR_Encounter.gxTpr_Br_encounter_upddate) )
            {
               AV9BR_Encounter.gxTv_SdtBR_Encounter_Br_encounter_upddate_SetNull();
            }
            if ( (DateTime.MinValue==AV9BR_Encounter.gxTpr_Br_encounter_submitdate) )
            {
               AV9BR_Encounter.gxTv_SdtBR_Encounter_Br_encounter_submitdate_SetNull();
            }
            if ( (DateTime.MinValue==AV9BR_Encounter.gxTpr_Br_encounter_israndnoapprovedate) )
            {
               AV9BR_Encounter.gxTv_SdtBR_Encounter_Br_encounter_israndnoapprovedate_SetNull();
            }
            if ( (DateTime.MinValue==AV9BR_Encounter.gxTpr_Br_encounter_israndapprovedate) )
            {
               AV9BR_Encounter.gxTv_SdtBR_Encounter_Br_encounter_israndapprovedate_SetNull();
            }
            if ( (DateTime.MinValue==AV9BR_Encounter.gxTpr_Br_encounter_israndrecheckdate) )
            {
               AV9BR_Encounter.gxTv_SdtBR_Encounter_Br_encounter_israndrecheckdate_SetNull();
            }
            if ( (DateTime.MinValue==AV9BR_Encounter.gxTpr_Br_encounter_israndnorecheckdate) )
            {
               AV9BR_Encounter.gxTv_SdtBR_Encounter_Br_encounter_israndnorecheckdate_SetNull();
            }
            AV7vInformationID = AV20BR_Information_ID;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7vInformationID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV7vInformationID), 18, 0)));
            AV9BR_Encounter.gxTpr_Br_information_id = AV7vInformationID;
            GXt_int2 = 0;
            new zutil_findcountbypatientno(context ).execute(  AV7vInformationID, out  GXt_int2) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7vInformationID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV7vInformationID), 18, 0)));
            AV9BR_Encounter.gxTpr_Br_encounter_encid = GXt_int2;
            AV9BR_Encounter.gxTpr_Br_encounter_status = 1;
            AV9BR_Encounter.gxTpr_Br_encounter_dischargestatus = AV16vDischargeStatus;
            AV9BR_Encounter.Save();
            if ( AV9BR_Encounter.Success() )
            {
               context.CommitDataStores("br_encounterinsertn",pr_default);
               context.setWebReturnParms(new Object[] {});
               context.setWebReturnParmsMetadata(new Object[] {});
               context.wjLocDisableFrm = 1;
               context.nUserReturn = 1;
               returnInSub = true;
               if (true) return;
            }
            else
            {
               AV22ErrorMsg = "";
               AV35GXV6 = 1;
               AV34GXV5 = AV9BR_Encounter.GetMessages();
               while ( AV35GXV6 <= AV34GXV5.Count )
               {
                  AV23Message = ((SdtMessages_Message)AV34GXV5.Item(AV35GXV6));
                  AV22ErrorMsg = AV22ErrorMsg + StringUtil.Trim( AV23Message.gxTpr_Description);
                  AV35GXV6 = (int)(AV35GXV6+1);
               }
               GX_msglist.addItem(StringUtil.Trim( AV22ErrorMsg));
            }
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV9BR_Encounter", AV9BR_Encounter);
      }

      protected void S112( )
      {
         /* 'CHECKREQUIREDFIELDS' Routine */
      }

      protected void nextLoad( )
      {
      }

      protected void E13A72( )
      {
         /* Load Routine */
         AV19BR_Information.Load(AV20BR_Information_ID);
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV9BR_Encounter.gxTpr_Br_encounter_department)) )
         {
            dynavVdepartment.addItem(AV9BR_Encounter.gxTpr_Br_encounter_department, AV9BR_Encounter.gxTpr_Br_encounter_department, 0);
            AV10vDepartment = AV9BR_Encounter.gxTpr_Br_encounter_department;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10vDepartment", AV10vDepartment);
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV9BR_Encounter.gxTpr_Br_encounter_enctype)) )
         {
            dynavVenctype.addItem(AV9BR_Encounter.gxTpr_Br_encounter_enctype, AV9BR_Encounter.gxTpr_Br_encounter_enctype, 0);
            AV12vENCType = AV9BR_Encounter.gxTpr_Br_encounter_enctype;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12vENCType", AV12vENCType);
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV9BR_Encounter.gxTpr_Br_encounter_admitsource)) )
         {
            dynavVadminsource.addItem(AV9BR_Encounter.gxTpr_Br_encounter_admitsource, AV9BR_Encounter.gxTpr_Br_encounter_admitsource, 0);
            AV14vAdminSource = AV9BR_Encounter.gxTpr_Br_encounter_admitsource;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14vAdminSource", AV14vAdminSource);
         }
      }

      protected void wb_table3_66_A72( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "";
            GxWebStd.gx_table_start( context, tblTablemergedvadminsource_Internalname, tblTablemergedvadminsource_Internalname, "", "TableMerged", 0, "", "", 0, 0, sStyleString, "", "", 0);
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td class='MergeDataCell'>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, dynavVadminsource_Internalname, "v Admin Source", "col-sm-3 AttributeLabel", 0, true);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 70,'',false,'',0)\"";
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, dynavVadminsource, dynavVadminsource_Internalname, StringUtil.RTrim( AV14vAdminSource), 1, dynavVadminsource_Jsonclick, 0, "'"+""+"'"+",false,"+"'"+""+"'", "svchar", "", 1, dynavVadminsource.Enabled, 0, 0, 0, "em", 0, "", "", "Attribute", "", "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,70);\"", "", true, "HLP_BR_EncounterInsertN.htm");
            dynavVadminsource.CurrentValue = StringUtil.RTrim( AV14vAdminSource);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynavVadminsource_Internalname, "Values", (String)(dynavVadminsource.ToJavascriptSource()), true);
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td class='RequiredDataContentCell'>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavVotherreason_Internalname, "v Other Reason", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 73,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavVotherreason_Internalname, AV15vOtherReason, StringUtil.RTrim( context.localUtil.Format( AV15vOtherReason, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,73);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "请填写其他入院原因", edtavVotherreason_Jsonclick, 0, "Attribute", "", "", "", "", edtavVotherreason_Visible, edtavVotherreason_Enabled, 0, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_BR_EncounterInsertN.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table3_66_A72e( true) ;
         }
         else
         {
            wb_table3_66_A72e( false) ;
         }
      }

      protected void wb_table2_47_A72( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "";
            GxWebStd.gx_table_start( context, tblTablemergedvenctype_Internalname, tblTablemergedvenctype_Internalname, "", "TableMerged", 0, "", "", 0, 0, sStyleString, "", "", 0);
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td class='MergeDataCell'>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, dynavVenctype_Internalname, "v ENCType", "col-sm-3 AttributeLabel", 0, true);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 51,'',false,'',0)\"";
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, dynavVenctype, dynavVenctype_Internalname, StringUtil.RTrim( AV12vENCType), 1, dynavVenctype_Jsonclick, 0, "'"+""+"'"+",false,"+"'"+""+"'", "svchar", "", 1, dynavVenctype.Enabled, 0, 0, 0, "em", 0, "", "", "Attribute", "", "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,51);\"", "", true, "HLP_BR_EncounterInsertN.htm");
            dynavVenctype.CurrentValue = StringUtil.RTrim( AV12vENCType);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynavVenctype_Internalname, "Values", (String)(dynavVenctype.ToJavascriptSource()), true);
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td class='RequiredDataContentCell'>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavVotherenctype_Internalname, "v Other ENCType", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 54,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavVotherenctype_Internalname, AV13vOtherENCType, StringUtil.RTrim( context.localUtil.Format( AV13vOtherENCType, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,54);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavVotherenctype_Jsonclick, 0, "Attribute", "", "", "", "", edtavVotherenctype_Visible, edtavVotherenctype_Enabled, 0, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_BR_EncounterInsertN.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table2_47_A72e( true) ;
         }
         else
         {
            wb_table2_47_A72e( false) ;
         }
      }

      protected void wb_table1_32_A72( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "";
            GxWebStd.gx_table_start( context, tblTablemergedvdepartment_Internalname, tblTablemergedvdepartment_Internalname, "", "TableMerged", 0, "", "", 0, 0, sStyleString, "", "", 0);
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td class='MergeDataCell'>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, dynavVdepartment_Internalname, "v Department", "col-sm-3 AttributeLabel", 0, true);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 36,'',false,'',0)\"";
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, dynavVdepartment, dynavVdepartment_Internalname, StringUtil.RTrim( AV10vDepartment), 1, dynavVdepartment_Jsonclick, 0, "'"+""+"'"+",false,"+"'"+""+"'", "svchar", "", 1, dynavVdepartment.Enabled, 0, 0, 0, "em", 0, "", "", "Attribute", "", "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,36);\"", "", true, "HLP_BR_EncounterInsertN.htm");
            dynavVdepartment.CurrentValue = StringUtil.RTrim( AV10vDepartment);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynavVdepartment_Internalname, "Values", (String)(dynavVdepartment.ToJavascriptSource()), true);
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td class='RequiredDataContentCell'>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavVotherdepartment_Internalname, "v Other Department", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 39,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavVotherdepartment_Internalname, AV11vOtherDepartment, StringUtil.RTrim( context.localUtil.Format( AV11vOtherDepartment, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,39);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "请填写其它就诊科室", edtavVotherdepartment_Jsonclick, 0, "Attribute", "", "", "", "", edtavVotherdepartment_Visible, edtavVotherdepartment_Enabled, 0, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_BR_EncounterInsertN.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table1_32_A72e( true) ;
         }
         else
         {
            wb_table1_32_A72e( false) ;
         }
      }

      public override void setparameters( Object[] obj )
      {
         createObjects();
         initialize();
         AV20BR_Information_ID = Convert.ToInt64(getParm(obj,0));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV20BR_Information_ID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV20BR_Information_ID), 18, 0)));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vBR_INFORMATION_ID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV20BR_Information_ID), "ZZZZZZZZZZZZZZZZZZ"), context));
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
         PAA72( ) ;
         WSA72( ) ;
         WEA72( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?20202271271718", true);
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
         context.AddJavascriptSource("br_encounterinsertn.js", "?20202271271718", false);
         context.AddJavascriptSource("DVelop/Bootstrap/Shared/DVelopBootstrap.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/Panel/BootstrapPanelRender.js", "", false);
         /* End function include_jscripts */
      }

      protected void init_web_controls( )
      {
         dynavVdepartment.Name = "vVDEPARTMENT";
         dynavVdepartment.WebTags = "";
         dynavVenctype.Name = "vVENCTYPE";
         dynavVenctype.WebTags = "";
         dynavVadminsource.Name = "vVADMINSOURCE";
         dynavVadminsource.WebTags = "";
         dynavVdischargestatus.Name = "vVDISCHARGESTATUS";
         dynavVdischargestatus.WebTags = "";
         /* End function init_web_controls */
      }

      protected void init_default_properties( )
      {
         edtavVpatientno_Internalname = "vVPATIENTNO";
         lblTextblockvdepartment_Internalname = "TEXTBLOCKVDEPARTMENT";
         dynavVdepartment_Internalname = "vVDEPARTMENT";
         edtavVotherdepartment_Internalname = "vVOTHERDEPARTMENT";
         tblTablemergedvdepartment_Internalname = "TABLEMERGEDVDEPARTMENT";
         divTablesplittedvdepartment_Internalname = "TABLESPLITTEDVDEPARTMENT";
         lblTextblockvenctype_Internalname = "TEXTBLOCKVENCTYPE";
         dynavVenctype_Internalname = "vVENCTYPE";
         edtavVotherenctype_Internalname = "vVOTHERENCTYPE";
         tblTablemergedvenctype_Internalname = "TABLEMERGEDVENCTYPE";
         divTablesplittedvenctype_Internalname = "TABLESPLITTEDVENCTYPE";
         edtavBr_encounter_br_encounter_admitdate_Internalname = "BR_ENCOUNTER_BR_ENCOUNTER_ADMITDATE";
         lblTextblockvadminsource_Internalname = "TEXTBLOCKVADMINSOURCE";
         dynavVadminsource_Internalname = "vVADMINSOURCE";
         edtavVotherreason_Internalname = "vVOTHERREASON";
         tblTablemergedvadminsource_Internalname = "TABLEMERGEDVADMINSOURCE";
         divTablesplittedvadminsource_Internalname = "TABLESPLITTEDVADMINSOURCE";
         edtavBr_encounter_br_encounter_dischargedate_Internalname = "BR_ENCOUNTER_BR_ENCOUNTER_DISCHARGEDATE";
         dynavVdischargestatus_Internalname = "vVDISCHARGESTATUS";
         divTableattributes_Internalname = "TABLEATTRIBUTES";
         divLayout_tableattributes_Internalname = "LAYOUT_TABLEATTRIBUTES";
         Dvpanel_tableattributes_Internalname = "DVPANEL_TABLEATTRIBUTES";
         divHtml_dvpanel_tableattributes_Internalname = "HTML_DVPANEL_TABLEATTRIBUTES";
         divTablecontent_Internalname = "TABLECONTENT";
         bttBtnminsave_Internalname = "BTNMINSAVE";
         bttBtnenter_Internalname = "BTNENTER";
         bttBtncancel_Internalname = "BTNCANCEL";
         divTablemain_Internalname = "TABLEMAIN";
         edtavVinformationid_Internalname = "vVINFORMATIONID";
         edtavBr_encounter_br_encounterid_Internalname = "BR_ENCOUNTER_BR_ENCOUNTERID";
         edtavBr_encounter_br_encounter_encid_Internalname = "BR_ENCOUNTER_BR_ENCOUNTER_ENCID";
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
         edtavVotherdepartment_Jsonclick = "";
         edtavVotherdepartment_Enabled = 1;
         dynavVdepartment_Jsonclick = "";
         dynavVdepartment.Enabled = 1;
         edtavVotherenctype_Jsonclick = "";
         edtavVotherenctype_Enabled = 1;
         dynavVenctype_Jsonclick = "";
         dynavVenctype.Enabled = 1;
         edtavVotherreason_Jsonclick = "";
         edtavVotherreason_Enabled = 1;
         dynavVadminsource_Jsonclick = "";
         dynavVadminsource.Enabled = 1;
         edtavVotherreason_Visible = 1;
         edtavVotherenctype_Visible = 1;
         edtavVotherdepartment_Visible = 1;
         edtavBr_encounter_br_encounter_encid_Jsonclick = "";
         edtavBr_encounter_br_encounterid_Jsonclick = "";
         edtavVinformationid_Jsonclick = "";
         dynavVdischargestatus_Jsonclick = "";
         dynavVdischargestatus.Enabled = 1;
         edtavBr_encounter_br_encounter_dischargedate_Jsonclick = "";
         edtavBr_encounter_br_encounter_dischargedate_Enabled = 1;
         edtavBr_encounter_br_encounter_admitdate_Jsonclick = "";
         edtavBr_encounter_br_encounter_admitdate_Enabled = 1;
         edtavVpatientno_Enabled = 1;
         Dvpanel_tableattributes_Autoscroll = Convert.ToBoolean( 0);
         Dvpanel_tableattributes_Iconposition = "left";
         Dvpanel_tableattributes_Showcollapseicon = Convert.ToBoolean( 0);
         Dvpanel_tableattributes_Autoheight = Convert.ToBoolean( -1);
         Dvpanel_tableattributes_Autowidth = Convert.ToBoolean( 0);
         Dvpanel_tableattributes_Collapsed = Convert.ToBoolean( 0);
         Dvpanel_tableattributes_Collapsible = Convert.ToBoolean( 0);
         Dvpanel_tableattributes_Title = "就诊信息";
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
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[{av:'AV20BR_Information_ID',fld:'vBR_INFORMATION_ID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true}]");
         setEventMetadata("REFRESH",",oparms:[]}");
         setEventMetadata("'DOMINSAVE'","{handler:'E12A72',iparms:[{av:'dynavVdepartment'},{av:'AV10vDepartment',fld:'vVDEPARTMENT',pic:''},{av:'AV11vOtherDepartment',fld:'vVOTHERDEPARTMENT',pic:''},{av:'AV9BR_Encounter',fld:'vBR_ENCOUNTER',pic:''},{av:'dynavVenctype'},{av:'AV12vENCType',fld:'vVENCTYPE',pic:''},{av:'AV13vOtherENCType',fld:'vVOTHERENCTYPE',pic:''},{av:'dynavVadminsource'},{av:'AV14vAdminSource',fld:'vVADMINSOURCE',pic:''},{av:'AV15vOtherReason',fld:'vVOTHERREASON',pic:''},{av:'AV20BR_Information_ID',fld:'vBR_INFORMATION_ID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true},{av:'dynavVdischargestatus'},{av:'AV16vDischargeStatus',fld:'vVDISCHARGESTATUS',pic:''}]");
         setEventMetadata("'DOMINSAVE'",",oparms:[{av:'AV9BR_Encounter',fld:'vBR_ENCOUNTER',pic:''},{av:'AV7vInformationID',fld:'vVINFORMATIONID',pic:'ZZZZZZZZZZZZZZZZZ9'}]}");
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
         AV18tCurrentCode = "";
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         GXKey = "";
         AV9BR_Encounter = new SdtBR_Encounter(context);
         GX_FocusControl = "";
         Form = new GXWebForm();
         sPrefix = "";
         ClassString = "";
         StyleString = "";
         ucDvpanel_tableattributes = new GXUserControl();
         TempTags = "";
         AV8vPatientNo = "";
         lblTextblockvdepartment_Jsonclick = "";
         lblTextblockvenctype_Jsonclick = "";
         lblTextblockvadminsource_Jsonclick = "";
         AV16vDischargeStatus = "";
         bttBtnminsave_Jsonclick = "";
         bttBtnenter_Jsonclick = "";
         bttBtncancel_Jsonclick = "";
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         gxdynajaxctrlcodr = new GeneXus.Utils.GxStringCollection();
         gxdynajaxctrldescr = new GeneXus.Utils.GxStringCollection();
         gxwrpcisep = "";
         AV10vDepartment = "";
         scmdbuf = "";
         H00A72_A167XT_DefineCodeID = new long[1] ;
         H00A72_A168XT_DefineCodeName = new String[] {""} ;
         H00A72_n168XT_DefineCodeName = new bool[] {false} ;
         H00A72_A165XT_DefindcodeTypeID = new long[1] ;
         H00A72_A432XT_TenantCode = new String[] {""} ;
         H00A72_n432XT_TenantCode = new bool[] {false} ;
         AV12vENCType = "";
         H00A73_A167XT_DefineCodeID = new long[1] ;
         H00A73_A168XT_DefineCodeName = new String[] {""} ;
         H00A73_n168XT_DefineCodeName = new bool[] {false} ;
         H00A73_A165XT_DefindcodeTypeID = new long[1] ;
         H00A73_A432XT_TenantCode = new String[] {""} ;
         H00A73_n432XT_TenantCode = new bool[] {false} ;
         AV14vAdminSource = "";
         H00A74_A167XT_DefineCodeID = new long[1] ;
         H00A74_A168XT_DefineCodeName = new String[] {""} ;
         H00A74_n168XT_DefineCodeName = new bool[] {false} ;
         H00A74_A165XT_DefindcodeTypeID = new long[1] ;
         H00A74_A432XT_TenantCode = new String[] {""} ;
         H00A74_n432XT_TenantCode = new bool[] {false} ;
         H00A75_A167XT_DefineCodeID = new long[1] ;
         H00A75_A168XT_DefineCodeName = new String[] {""} ;
         H00A75_n168XT_DefineCodeName = new bool[] {false} ;
         H00A75_A165XT_DefindcodeTypeID = new long[1] ;
         H00A75_A432XT_TenantCode = new String[] {""} ;
         H00A75_n432XT_TenantCode = new bool[] {false} ;
         AV11vOtherDepartment = "";
         AV13vOtherENCType = "";
         AV15vOtherReason = "";
         GXt_char1 = "";
         AV19BR_Information = new SdtBR_Information(context);
         AV22ErrorMsg = "";
         AV34GXV5 = new GXBaseCollection<SdtMessages_Message>( context, "Message", "GeneXus");
         AV23Message = new SdtMessages_Message(context);
         sStyleString = "";
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         pr_datastore1 = new DataStoreProvider(context, new GeneXus.Programs.br_encounterinsertn__datastore1(),
            new Object[][] {
            }
         );
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.br_encounterinsertn__default(),
            new Object[][] {
                new Object[] {
               H00A72_A167XT_DefineCodeID, H00A72_A168XT_DefineCodeName, H00A72_n168XT_DefineCodeName, H00A72_A165XT_DefindcodeTypeID, H00A72_A432XT_TenantCode, H00A72_n432XT_TenantCode
               }
               , new Object[] {
               H00A73_A167XT_DefineCodeID, H00A73_A168XT_DefineCodeName, H00A73_n168XT_DefineCodeName, H00A73_A165XT_DefindcodeTypeID, H00A73_A432XT_TenantCode, H00A73_n432XT_TenantCode
               }
               , new Object[] {
               H00A74_A167XT_DefineCodeID, H00A74_A168XT_DefineCodeName, H00A74_n168XT_DefineCodeName, H00A74_A165XT_DefindcodeTypeID, H00A74_A432XT_TenantCode, H00A74_n432XT_TenantCode
               }
               , new Object[] {
               H00A75_A167XT_DefineCodeID, H00A75_A168XT_DefineCodeName, H00A75_n168XT_DefineCodeName, H00A75_A165XT_DefindcodeTypeID, H00A75_A432XT_TenantCode, H00A75_n432XT_TenantCode
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0;
         edtavVpatientno_Enabled = 0;
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
      private int edtavVpatientno_Enabled ;
      private int edtavBr_encounter_br_encounter_admitdate_Enabled ;
      private int edtavBr_encounter_br_encounter_dischargedate_Enabled ;
      private int gxdynajaxindex ;
      private int edtavVotherdepartment_Visible ;
      private int edtavVotherenctype_Visible ;
      private int edtavVotherreason_Visible ;
      private int AV35GXV6 ;
      private int edtavVotherreason_Enabled ;
      private int edtavVotherenctype_Enabled ;
      private int edtavVotherdepartment_Enabled ;
      private int idxLst ;
      private long AV20BR_Information_ID ;
      private long wcpOAV20BR_Information_ID ;
      private long AV7vInformationID ;
      private long GXt_int2 ;
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
      private String edtavVpatientno_Internalname ;
      private String TempTags ;
      private String divTablesplittedvdepartment_Internalname ;
      private String lblTextblockvdepartment_Internalname ;
      private String lblTextblockvdepartment_Jsonclick ;
      private String divTablesplittedvenctype_Internalname ;
      private String lblTextblockvenctype_Internalname ;
      private String lblTextblockvenctype_Jsonclick ;
      private String edtavBr_encounter_br_encounter_admitdate_Internalname ;
      private String edtavBr_encounter_br_encounter_admitdate_Jsonclick ;
      private String divTablesplittedvadminsource_Internalname ;
      private String lblTextblockvadminsource_Internalname ;
      private String lblTextblockvadminsource_Jsonclick ;
      private String edtavBr_encounter_br_encounter_dischargedate_Internalname ;
      private String edtavBr_encounter_br_encounter_dischargedate_Jsonclick ;
      private String dynavVdischargestatus_Internalname ;
      private String dynavVdischargestatus_Jsonclick ;
      private String bttBtnminsave_Internalname ;
      private String bttBtnminsave_Jsonclick ;
      private String bttBtnenter_Internalname ;
      private String bttBtnenter_Jsonclick ;
      private String bttBtncancel_Internalname ;
      private String bttBtncancel_Jsonclick ;
      private String divHtml_bottomauxiliarcontrols_Internalname ;
      private String edtavVinformationid_Internalname ;
      private String edtavVinformationid_Jsonclick ;
      private String edtavBr_encounter_br_encounterid_Internalname ;
      private String edtavBr_encounter_br_encounterid_Jsonclick ;
      private String edtavBr_encounter_br_encounter_encid_Internalname ;
      private String edtavBr_encounter_br_encounter_encid_Jsonclick ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String gxwrpcisep ;
      private String scmdbuf ;
      private String dynavVdepartment_Internalname ;
      private String dynavVenctype_Internalname ;
      private String dynavVadminsource_Internalname ;
      private String edtavVotherdepartment_Internalname ;
      private String edtavVotherenctype_Internalname ;
      private String edtavVotherreason_Internalname ;
      private String GXt_char1 ;
      private String sStyleString ;
      private String tblTablemergedvadminsource_Internalname ;
      private String dynavVadminsource_Jsonclick ;
      private String edtavVotherreason_Jsonclick ;
      private String tblTablemergedvenctype_Internalname ;
      private String dynavVenctype_Jsonclick ;
      private String edtavVotherenctype_Jsonclick ;
      private String tblTablemergedvdepartment_Internalname ;
      private String dynavVdepartment_Jsonclick ;
      private String edtavVotherdepartment_Jsonclick ;
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
      private bool AV25tFlag ;
      private String AV18tCurrentCode ;
      private String AV8vPatientNo ;
      private String AV16vDischargeStatus ;
      private String AV10vDepartment ;
      private String AV12vENCType ;
      private String AV14vAdminSource ;
      private String AV11vOtherDepartment ;
      private String AV13vOtherENCType ;
      private String AV15vOtherReason ;
      private String AV22ErrorMsg ;
      private GeneXus.Utils.GxStringCollection gxdynajaxctrlcodr ;
      private GeneXus.Utils.GxStringCollection gxdynajaxctrldescr ;
      private GXUserControl ucDvpanel_tableattributes ;
      private IGxDataStore dsDataStore1 ;
      private IGxDataStore dsDefault ;
      private GXCombobox dynavVdepartment ;
      private GXCombobox dynavVenctype ;
      private GXCombobox dynavVadminsource ;
      private GXCombobox dynavVdischargestatus ;
      private IDataStoreProvider pr_default ;
      private long[] H00A72_A167XT_DefineCodeID ;
      private String[] H00A72_A168XT_DefineCodeName ;
      private bool[] H00A72_n168XT_DefineCodeName ;
      private long[] H00A72_A165XT_DefindcodeTypeID ;
      private String[] H00A72_A432XT_TenantCode ;
      private bool[] H00A72_n432XT_TenantCode ;
      private long[] H00A73_A167XT_DefineCodeID ;
      private String[] H00A73_A168XT_DefineCodeName ;
      private bool[] H00A73_n168XT_DefineCodeName ;
      private long[] H00A73_A165XT_DefindcodeTypeID ;
      private String[] H00A73_A432XT_TenantCode ;
      private bool[] H00A73_n432XT_TenantCode ;
      private long[] H00A74_A167XT_DefineCodeID ;
      private String[] H00A74_A168XT_DefineCodeName ;
      private bool[] H00A74_n168XT_DefineCodeName ;
      private long[] H00A74_A165XT_DefindcodeTypeID ;
      private String[] H00A74_A432XT_TenantCode ;
      private bool[] H00A74_n432XT_TenantCode ;
      private long[] H00A75_A167XT_DefineCodeID ;
      private String[] H00A75_A168XT_DefineCodeName ;
      private bool[] H00A75_n168XT_DefineCodeName ;
      private long[] H00A75_A165XT_DefindcodeTypeID ;
      private String[] H00A75_A432XT_TenantCode ;
      private bool[] H00A75_n432XT_TenantCode ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private IDataStoreProvider pr_datastore1 ;
      private GXBaseCollection<SdtMessages_Message> AV34GXV5 ;
      private GXWebForm Form ;
      private SdtBR_Encounter AV9BR_Encounter ;
      private SdtMessages_Message AV23Message ;
      private SdtBR_Information AV19BR_Information ;
   }

   public class br_encounterinsertn__datastore1 : DataStoreHelperBase, IDataStoreHelper
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

 public class br_encounterinsertn__default : DataStoreHelperBase, IDataStoreHelper
 {
    public ICursor[] getCursors( )
    {
       cursorDefinitions();
       return new Cursor[] {
        new ForEachCursor(def[0])
       ,new ForEachCursor(def[1])
       ,new ForEachCursor(def[2])
       ,new ForEachCursor(def[3])
     };
  }

  private static CursorDef[] def;
  private void cursorDefinitions( )
  {
     if ( def == null )
     {
        Object[] prmH00A72 ;
        prmH00A72 = new Object[] {
        new Object[] {"@AV18tCurrentCode",SqlDbType.NVarChar,40,0}
        } ;
        Object[] prmH00A73 ;
        prmH00A73 = new Object[] {
        new Object[] {"@AV18tCurrentCode",SqlDbType.NVarChar,40,0}
        } ;
        Object[] prmH00A74 ;
        prmH00A74 = new Object[] {
        new Object[] {"@AV18tCurrentCode",SqlDbType.NVarChar,40,0}
        } ;
        Object[] prmH00A75 ;
        prmH00A75 = new Object[] {
        new Object[] {"@AV18tCurrentCode",SqlDbType.NVarChar,40,0}
        } ;
        def= new CursorDef[] {
            new CursorDef("H00A72", "SELECT [XT_DefineCodeID], [XT_DefineCodeName], [XT_DefindcodeTypeID], [XT_TenantCode] FROM [XT_DefineCode] WITH (NOLOCK) WHERE ([XT_DefindcodeTypeID] = 3) AND ([XT_TenantCode] = @AV18tCurrentCode) ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH00A72,0,0,true,false )
           ,new CursorDef("H00A73", "SELECT [XT_DefineCodeID], [XT_DefineCodeName], [XT_DefindcodeTypeID], [XT_TenantCode] FROM [XT_DefineCode] WITH (NOLOCK) WHERE ([XT_DefindcodeTypeID] = 4) AND ([XT_TenantCode] = @AV18tCurrentCode) ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH00A73,0,0,true,false )
           ,new CursorDef("H00A74", "SELECT [XT_DefineCodeID], [XT_DefineCodeName], [XT_DefindcodeTypeID], [XT_TenantCode] FROM [XT_DefineCode] WITH (NOLOCK) WHERE ([XT_DefindcodeTypeID] = 5) AND ([XT_TenantCode] = @AV18tCurrentCode) ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH00A74,0,0,true,false )
           ,new CursorDef("H00A75", "SELECT [XT_DefineCodeID], [XT_DefineCodeName], [XT_DefindcodeTypeID], [XT_TenantCode] FROM [XT_DefineCode] WITH (NOLOCK) WHERE ([XT_DefindcodeTypeID] = 6) AND ([XT_TenantCode] = @AV18tCurrentCode) ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH00A75,0,0,true,false )
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
           case 3 :
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
           case 3 :
              stmt.SetParameter(1, (String)parms[0]);
              return;
     }
  }

}

}
