/*
               File: BR_EncounterInsert
        Description:
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/28/2020 15:17:1.27
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
   public class br_encounterinsert : GXDataArea, System.Web.SessionState.IRequiresSessionState
   {
      public br_encounterinsert( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public br_encounterinsert( IGxContext context )
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
         this.AV8BR_Information_ID = aP0_BR_Information_ID;
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
         dynavVdepartmentadm = new GXCombobox();
         dynavVdepartmentdisch = new GXCombobox();
         dynavVinsurance = new GXCombobox();
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
               AV16tCurrentCode = GetNextPar( );
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1;
                  return  ;
               }
               GXDLVvVDEPARTMENT8V2( AV16tCurrentCode) ;
               return  ;
            }
            else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxCallCrl"+"_"+"vVDEPARTMENTADM") == 0 )
            {
               AV16tCurrentCode = GetNextPar( );
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1;
                  return  ;
               }
               GXDLVvVDEPARTMENTADM8V2( AV16tCurrentCode) ;
               return  ;
            }
            else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxCallCrl"+"_"+"vVDEPARTMENTDISCH") == 0 )
            {
               AV16tCurrentCode = GetNextPar( );
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1;
                  return  ;
               }
               GXDLVvVDEPARTMENTDISCH8V2( AV16tCurrentCode) ;
               return  ;
            }
            else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxCallCrl"+"_"+"vVINSURANCE") == 0 )
            {
               AV16tCurrentCode = GetNextPar( );
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1;
                  return  ;
               }
               GXDLVvVINSURANCE8V2( AV16tCurrentCode) ;
               return  ;
            }
            else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxCallCrl"+"_"+"vVENCTYPE") == 0 )
            {
               AV16tCurrentCode = GetNextPar( );
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1;
                  return  ;
               }
               GXDLVvVENCTYPE8V2( AV16tCurrentCode) ;
               return  ;
            }
            else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxCallCrl"+"_"+"vVADMINSOURCE") == 0 )
            {
               AV16tCurrentCode = GetNextPar( );
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1;
                  return  ;
               }
               GXDLVvVADMINSOURCE8V2( AV16tCurrentCode) ;
               return  ;
            }
            else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxCallCrl"+"_"+"vVDISCHARGESTATUS") == 0 )
            {
               AV16tCurrentCode = GetNextPar( );
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1;
                  return  ;
               }
               GXDLVvVDISCHARGESTATUS8V2( AV16tCurrentCode) ;
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
               AV8BR_Information_ID = (long)(NumberUtil.Val( gxfirstwebparm, "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8BR_Information_ID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV8BR_Information_ID), 18, 0)));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vBR_INFORMATION_ID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV8BR_Information_ID), "ZZZZZZZZZZZZZZZZZZ"), context));
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
         PA8V2( ) ;
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0));
         if ( ( gxajaxcallmode == 0 ) && ( GxWebError == 0 ) )
         {
            START8V2( ) ;
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
         context.AddJavascriptSource("gxcfg.js", "?20202281517152", false);
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" autocomplete=\"off\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("br_encounterinsert.aspx") + "?" + UrlEncode("" +AV8BR_Information_ID)+"\">") ;
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
         GxWebStd.gx_hidden_field( context, "gxhash_vVDEPARTMENT", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( AV18vDepartment, "")), context));
         GXKey = Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
         forbiddenHiddens = "hsh" + "BR_EncounterInsert";
         forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( AV18vDepartment, ""));
         GxWebStd.gx_hidden_field( context, "hsh", GetEncryptedHash( forbiddenHiddens, GXKey));
         GXUtil.WriteLog("br_encounterinsert:[SendSecurityCheck value for]"+"vDepartment:"+StringUtil.RTrim( context.localUtil.Format( AV18vDepartment, "")));
      }

      protected void SendCloseFormHiddens( )
      {
         /* Send hidden variables. */
         /* Send saved values. */
         send_integrity_footer_hashes( ) ;
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "Br_encounter", AV5BR_Encounter);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("Br_encounter", AV5BR_Encounter);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vBR_ENCOUNTER", AV5BR_Encounter);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vBR_ENCOUNTER", AV5BR_Encounter);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vBR_INFORMATION", AV7BR_Information);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vBR_INFORMATION", AV7BR_Information);
         }
         GxWebStd.gx_hidden_field( context, "vBR_INFORMATION_ID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV8BR_Information_ID), 18, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "gxhash_vBR_INFORMATION_ID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV8BR_Information_ID), "ZZZZZZZZZZZZZZZZZZ"), context));
         GxWebStd.gx_hidden_field( context, "vTCURRENTCODE", AV16tCurrentCode);
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
            WE8V2( ) ;
            context.WriteHtmlText( "</div>") ;
         }
      }

      public override void DispatchEvents( )
      {
         EVT8V2( ) ;
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
         return formatLink("br_encounterinsert.aspx") + "?" + UrlEncode("" +AV8BR_Information_ID) ;
      }

      public override String GetPgmname( )
      {
         return "BR_EncounterInsert" ;
      }

      public override String GetPgmdesc( )
      {
         return "" ;
      }

      protected void WB8V0( )
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
            GxWebStd.gx_html_textarea( context, edtavVpatientno_Internalname, AV29vPatientNo, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,25);\"", 0, 1, edtavVpatientno_Enabled, 0, 80, "chr", 10, "row", StyleString, ClassString, "", "", "2000", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_EncounterInsert.htm");
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
            GxWebStd.gx_label_ctrl( context, lblTextblockvdepartment_Internalname, "就诊科室", "", "", lblTextblockvdepartment_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_BR_EncounterInsert.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-9", "left", "top", "", "", "div");
            wb_table1_32_8V2( true) ;
         }
         else
         {
            wb_table1_32_8V2( false) ;
         }
         return  ;
      }

      protected void wb_table1_32_8V2e( bool wbgen )
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
            GxWebStd.gx_div_start( context, divTablesplittedvdepartmentadm_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-3 MergeLabelCell", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblockvdepartmentadm_Internalname, "入院科室", "", "", lblTextblockvdepartmentadm_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_BR_EncounterInsert.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-9", "left", "top", "", "", "div");
            wb_table2_47_8V2( true) ;
         }
         else
         {
            wb_table2_47_8V2( false) ;
         }
         return  ;
      }

      protected void wb_table2_47_8V2e( bool wbgen )
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
            GxWebStd.gx_div_start( context, divTablesplittedvdepartmentdisch_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-3 MergeLabelCell", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblockvdepartmentdisch_Internalname, "出院科室", "", "", lblTextblockvdepartmentdisch_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_BR_EncounterInsert.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-9", "left", "top", "", "", "div");
            wb_table3_61_8V2( true) ;
         }
         else
         {
            wb_table3_61_8V2( false) ;
         }
         return  ;
      }

      protected void wb_table3_61_8V2e( bool wbgen )
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
            GxWebStd.gx_div_start( context, divTablesplittedvinsurance_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-3 MergeLabelCell", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblockvinsurance_Internalname, "保险", "", "", lblTextblockvinsurance_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_BR_EncounterInsert.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-9", "left", "top", "", "", "div");
            wb_table4_76_8V2( true) ;
         }
         else
         {
            wb_table4_76_8V2( false) ;
         }
         return  ;
      }

      protected void wb_table4_76_8V2e( bool wbgen )
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
            GxWebStd.gx_div_start( context, divTablesplittedvenctype_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-3 MergeLabelCell", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblockvenctype_Internalname, "就诊方式", "", "", lblTextblockvenctype_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_BR_EncounterInsert.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-9", "left", "top", "", "", "div");
            wb_table5_90_8V2( true) ;
         }
         else
         {
            wb_table5_90_8V2( false) ;
         }
         return  ;
      }

      protected void wb_table5_90_8V2e( bool wbgen )
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
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtavBr_encounter_br_encounter_admitdate_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavBr_encounter_br_encounter_admitdate_Internalname, "就诊/入院时间", "col-sm-3 AttributeDateLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 102,'',false,'',0)\"";
            context.WriteHtmlText( "<div id=\""+edtavBr_encounter_br_encounter_admitdate_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtavBr_encounter_br_encounter_admitdate_Internalname, context.localUtil.Format(AV5BR_Encounter.gxTpr_Br_encounter_admitdate, "9999/99/99"), context.localUtil.Format( AV5BR_Encounter.gxTpr_Br_encounter_admitdate, "9999/99/99"), TempTags+" onchange=\""+"gx.date.valid_date(this, 10,'YMD',0,24,'chs',false,1);"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,102);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavBr_encounter_br_encounter_admitdate_Jsonclick, 0, "AttributeDate", "", "", "", "", 1, edtavBr_encounter_br_encounter_admitdate_Enabled, 0, "text", "", 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_BR_EncounterInsert.htm");
            GxWebStd.gx_bitmap( context, edtavBr_encounter_br_encounter_admitdate_Internalname+"_dp_trigger", context.GetImagePath( "61b9b5d3-dff6-4d59-9b00-da61bc2cbe93", "", context.GetTheme( )), "", "", "", "", ((1==0)||(edtavBr_encounter_br_encounter_admitdate_Enabled==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;", "", "", "", "", "", "", "", "", 1, false, false, "", "HLP_BR_EncounterInsert.htm");
            context.WriteHtmlTextNl( "</div>") ;
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divTablesplittedvadminsource_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-3 MergeLabelCell", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblockvadminsource_Internalname, "入院原因", "", "", lblTextblockvadminsource_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_BR_EncounterInsert.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-9", "left", "top", "", "", "div");
            wb_table6_109_8V2( true) ;
         }
         else
         {
            wb_table6_109_8V2( false) ;
         }
         return  ;
      }

      protected void wb_table6_109_8V2e( bool wbgen )
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
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtavBr_encounter_br_encounter_dischargedate_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavBr_encounter_br_encounter_dischargedate_Internalname, "出院时间", "col-sm-3 AttributeDateLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 121,'',false,'',0)\"";
            context.WriteHtmlText( "<div id=\""+edtavBr_encounter_br_encounter_dischargedate_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtavBr_encounter_br_encounter_dischargedate_Internalname, context.localUtil.Format(AV5BR_Encounter.gxTpr_Br_encounter_dischargedate, "9999/99/99"), context.localUtil.Format( AV5BR_Encounter.gxTpr_Br_encounter_dischargedate, "9999/99/99"), TempTags+" onchange=\""+"gx.date.valid_date(this, 10,'YMD',0,24,'chs',false,1);"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,121);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavBr_encounter_br_encounter_dischargedate_Jsonclick, 0, "AttributeDate", "", "", "", "", 1, edtavBr_encounter_br_encounter_dischargedate_Enabled, 0, "text", "", 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_BR_EncounterInsert.htm");
            GxWebStd.gx_bitmap( context, edtavBr_encounter_br_encounter_dischargedate_Internalname+"_dp_trigger", context.GetImagePath( "61b9b5d3-dff6-4d59-9b00-da61bc2cbe93", "", context.GetTheme( )), "", "", "", "", ((1==0)||(edtavBr_encounter_br_encounter_dischargedate_Enabled==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;", "", "", "", "", "", "", "", "", 1, false, false, "", "HLP_BR_EncounterInsert.htm");
            context.WriteHtmlTextNl( "</div>") ;
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+dynavVdischargestatus_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, dynavVdischargestatus_Internalname, "出院状态", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 125,'',false,'',0)\"";
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, dynavVdischargestatus, dynavVdischargestatus_Internalname, StringUtil.RTrim( AV19vDischargeStatus), 1, dynavVdischargestatus_Jsonclick, 0, "'"+""+"'"+",false,"+"'"+""+"'", "svchar", "", 1, dynavVdischargestatus.Enabled, 0, 0, 0, "em", 0, "", "", "Attribute", "", "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,125);\"", "", true, "HLP_BR_EncounterInsert.htm");
            dynavVdischargestatus.CurrentValue = StringUtil.RTrim( AV19vDischargeStatus);
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
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 130,'',false,'',0)\"";
            ClassString = "ButtonMaterial";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtnenter_Internalname, "", "保存", bttBtnenter_Jsonclick, 5, "确认", "", StyleString, ClassString, 1, 1, "standard", "'"+""+"'"+",false,"+"'"+"EENTER."+"'", TempTags, "", context.GetButtonType( ), "HLP_BR_EncounterInsert.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 132,'',false,'',0)\"";
            ClassString = "ButtonMaterialDefault";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtncancel_Internalname, "", "取消", bttBtncancel_Jsonclick, 1, "取消", "", StyleString, ClassString, 1, 1, "standard", "'"+""+"'"+",false,"+"'"+"ECANCEL."+"'", TempTags, "", context.GetButtonType( ), "HLP_BR_EncounterInsert.htm");
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
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 136,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavVinformationid_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV30vInformationID), 18, 0, ".", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(AV30vInformationID), "ZZZZZZZZZZZZZZZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,136);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavVinformationid_Jsonclick, 0, "Attribute", "", "", "", "", edtavVinformationid_Visible, 1, 0, "number", "1", 18, "chr", 1, "row", 18, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_BR_EncounterInsert.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 137,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavBr_encounter_br_encounterid_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV5BR_Encounter.gxTpr_Br_encounterid), 18, 0, ".", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(AV5BR_Encounter.gxTpr_Br_encounterid), "ZZZZZZZZZZZZZZZZZZ")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,137);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavBr_encounter_br_encounterid_Jsonclick, 0, "Attribute", "", "", "", "", edtavBr_encounter_br_encounterid_Visible, 1, 0, "number", "1", 18, "chr", 1, "row", 18, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_BR_EncounterInsert.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 138,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavBr_encounter_br_encounter_encid_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV5BR_Encounter.gxTpr_Br_encounter_encid), 10, 0, ".", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(AV5BR_Encounter.gxTpr_Br_encounter_encid), "ZZZZZZZZZZ")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,138);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavBr_encounter_br_encounter_encid_Jsonclick, 0, "Attribute", "", "", "", "", edtavBr_encounter_br_encounter_encid_Visible, 1, 0, "number", "1", 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_BR_EncounterInsert.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
         }
         wbLoad = true;
      }

      protected void START8V2( )
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
         STRUP8V0( ) ;
      }

      protected void WS8V2( )
      {
         START8V2( ) ;
         EVT8V2( ) ;
      }

      protected void EVT8V2( )
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
                              E118V2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "REFRESH") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              /* Execute user event: Refresh */
                              E128V2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "LOAD") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              /* Execute user event: Load */
                              E138V2 ();
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
                                    E148V2 ();
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

      protected void WE8V2( )
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

      protected void PA8V2( )
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

      protected void GXDLVvVDEPARTMENT8V2( String AV16tCurrentCode )
      {
         if ( ! context.isAjaxRequest( ) )
         {
            context.GX_webresponse.AppendHeader("Cache-Control", "no-store");
         }
         context.GX_webresponse.AddString("[[");
         GXDLVvVDEPARTMENT_data8V2( AV16tCurrentCode) ;
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

      protected void GXVvVDEPARTMENT_html8V2( String AV16tCurrentCode )
      {
         String gxdynajaxvalue ;
         GXDLVvVDEPARTMENT_data8V2( AV16tCurrentCode) ;
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

      protected void GXDLVvVDEPARTMENT_data8V2( String AV16tCurrentCode )
      {
         gxdynajaxctrlcodr.Clear();
         gxdynajaxctrldescr.Clear();
         gxdynajaxctrlcodr.Add("");
         gxdynajaxctrldescr.Add("(请选择)");
         /* Using cursor H008V2 */
         pr_default.execute(0, new Object[] {AV16tCurrentCode});
         while ( (pr_default.getStatus(0) != 101) )
         {
            gxdynajaxctrlcodr.Add(H008V2_A168XT_DefineCodeName[0]);
            gxdynajaxctrldescr.Add(H008V2_A168XT_DefineCodeName[0]);
            pr_default.readNext(0);
         }
         pr_default.close(0);
      }

      protected void GXDLVvVDEPARTMENTADM8V2( String AV16tCurrentCode )
      {
         if ( ! context.isAjaxRequest( ) )
         {
            context.GX_webresponse.AppendHeader("Cache-Control", "no-store");
         }
         context.GX_webresponse.AddString("[[");
         GXDLVvVDEPARTMENTADM_data8V2( AV16tCurrentCode) ;
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

      protected void GXVvVDEPARTMENTADM_html8V2( String AV16tCurrentCode )
      {
         String gxdynajaxvalue ;
         GXDLVvVDEPARTMENTADM_data8V2( AV16tCurrentCode) ;
         gxdynajaxindex = 1;
         if ( ! ( gxdyncontrolsrefreshing && context.isAjaxRequest( ) ) )
         {
            dynavVdepartmentadm.removeAllItems();
         }
         while ( gxdynajaxindex <= gxdynajaxctrlcodr.Count )
         {
            gxdynajaxvalue = ((String)gxdynajaxctrlcodr.Item(gxdynajaxindex));
            dynavVdepartmentadm.addItem(gxdynajaxvalue, ((String)gxdynajaxctrldescr.Item(gxdynajaxindex)), 0);
            gxdynajaxindex = (int)(gxdynajaxindex+1);
         }
      }

      protected void GXDLVvVDEPARTMENTADM_data8V2( String AV16tCurrentCode )
      {
         gxdynajaxctrlcodr.Clear();
         gxdynajaxctrldescr.Clear();
         gxdynajaxctrlcodr.Add("");
         gxdynajaxctrldescr.Add("(请选择)");
         /* Using cursor H008V3 */
         pr_default.execute(1, new Object[] {AV16tCurrentCode});
         while ( (pr_default.getStatus(1) != 101) )
         {
            gxdynajaxctrlcodr.Add(H008V3_A168XT_DefineCodeName[0]);
            gxdynajaxctrldescr.Add(H008V3_A168XT_DefineCodeName[0]);
            pr_default.readNext(1);
         }
         pr_default.close(1);
      }

      protected void GXDLVvVDEPARTMENTDISCH8V2( String AV16tCurrentCode )
      {
         if ( ! context.isAjaxRequest( ) )
         {
            context.GX_webresponse.AppendHeader("Cache-Control", "no-store");
         }
         context.GX_webresponse.AddString("[[");
         GXDLVvVDEPARTMENTDISCH_data8V2( AV16tCurrentCode) ;
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

      protected void GXVvVDEPARTMENTDISCH_html8V2( String AV16tCurrentCode )
      {
         String gxdynajaxvalue ;
         GXDLVvVDEPARTMENTDISCH_data8V2( AV16tCurrentCode) ;
         gxdynajaxindex = 1;
         if ( ! ( gxdyncontrolsrefreshing && context.isAjaxRequest( ) ) )
         {
            dynavVdepartmentdisch.removeAllItems();
         }
         while ( gxdynajaxindex <= gxdynajaxctrlcodr.Count )
         {
            gxdynajaxvalue = ((String)gxdynajaxctrlcodr.Item(gxdynajaxindex));
            dynavVdepartmentdisch.addItem(gxdynajaxvalue, ((String)gxdynajaxctrldescr.Item(gxdynajaxindex)), 0);
            gxdynajaxindex = (int)(gxdynajaxindex+1);
         }
      }

      protected void GXDLVvVDEPARTMENTDISCH_data8V2( String AV16tCurrentCode )
      {
         gxdynajaxctrlcodr.Clear();
         gxdynajaxctrldescr.Clear();
         gxdynajaxctrlcodr.Add("");
         gxdynajaxctrldescr.Add("(请选择)");
         /* Using cursor H008V4 */
         pr_default.execute(2, new Object[] {AV16tCurrentCode});
         while ( (pr_default.getStatus(2) != 101) )
         {
            gxdynajaxctrlcodr.Add(H008V4_A168XT_DefineCodeName[0]);
            gxdynajaxctrldescr.Add(H008V4_A168XT_DefineCodeName[0]);
            pr_default.readNext(2);
         }
         pr_default.close(2);
      }

      protected void GXDLVvVINSURANCE8V2( String AV16tCurrentCode )
      {
         if ( ! context.isAjaxRequest( ) )
         {
            context.GX_webresponse.AppendHeader("Cache-Control", "no-store");
         }
         context.GX_webresponse.AddString("[[");
         GXDLVvVINSURANCE_data8V2( AV16tCurrentCode) ;
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

      protected void GXVvVINSURANCE_html8V2( String AV16tCurrentCode )
      {
         String gxdynajaxvalue ;
         GXDLVvVINSURANCE_data8V2( AV16tCurrentCode) ;
         gxdynajaxindex = 1;
         if ( ! ( gxdyncontrolsrefreshing && context.isAjaxRequest( ) ) )
         {
            dynavVinsurance.removeAllItems();
         }
         while ( gxdynajaxindex <= gxdynajaxctrlcodr.Count )
         {
            gxdynajaxvalue = ((String)gxdynajaxctrlcodr.Item(gxdynajaxindex));
            dynavVinsurance.addItem(gxdynajaxvalue, ((String)gxdynajaxctrldescr.Item(gxdynajaxindex)), 0);
            gxdynajaxindex = (int)(gxdynajaxindex+1);
         }
      }

      protected void GXDLVvVINSURANCE_data8V2( String AV16tCurrentCode )
      {
         gxdynajaxctrlcodr.Clear();
         gxdynajaxctrldescr.Clear();
         gxdynajaxctrlcodr.Add("");
         gxdynajaxctrldescr.Add("(请选择)");
         /* Using cursor H008V5 */
         pr_default.execute(3, new Object[] {AV16tCurrentCode});
         while ( (pr_default.getStatus(3) != 101) )
         {
            gxdynajaxctrlcodr.Add(H008V5_A168XT_DefineCodeName[0]);
            gxdynajaxctrldescr.Add(H008V5_A168XT_DefineCodeName[0]);
            pr_default.readNext(3);
         }
         pr_default.close(3);
      }

      protected void GXDLVvVENCTYPE8V2( String AV16tCurrentCode )
      {
         if ( ! context.isAjaxRequest( ) )
         {
            context.GX_webresponse.AppendHeader("Cache-Control", "no-store");
         }
         context.GX_webresponse.AddString("[[");
         GXDLVvVENCTYPE_data8V2( AV16tCurrentCode) ;
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

      protected void GXVvVENCTYPE_html8V2( String AV16tCurrentCode )
      {
         String gxdynajaxvalue ;
         GXDLVvVENCTYPE_data8V2( AV16tCurrentCode) ;
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

      protected void GXDLVvVENCTYPE_data8V2( String AV16tCurrentCode )
      {
         gxdynajaxctrlcodr.Clear();
         gxdynajaxctrldescr.Clear();
         gxdynajaxctrlcodr.Add("");
         gxdynajaxctrldescr.Add("(请选择)");
         /* Using cursor H008V6 */
         pr_default.execute(4, new Object[] {AV16tCurrentCode});
         while ( (pr_default.getStatus(4) != 101) )
         {
            gxdynajaxctrlcodr.Add(H008V6_A168XT_DefineCodeName[0]);
            gxdynajaxctrldescr.Add(H008V6_A168XT_DefineCodeName[0]);
            pr_default.readNext(4);
         }
         pr_default.close(4);
      }

      protected void GXDLVvVADMINSOURCE8V2( String AV16tCurrentCode )
      {
         if ( ! context.isAjaxRequest( ) )
         {
            context.GX_webresponse.AppendHeader("Cache-Control", "no-store");
         }
         context.GX_webresponse.AddString("[[");
         GXDLVvVADMINSOURCE_data8V2( AV16tCurrentCode) ;
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

      protected void GXVvVADMINSOURCE_html8V2( String AV16tCurrentCode )
      {
         String gxdynajaxvalue ;
         GXDLVvVADMINSOURCE_data8V2( AV16tCurrentCode) ;
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

      protected void GXDLVvVADMINSOURCE_data8V2( String AV16tCurrentCode )
      {
         gxdynajaxctrlcodr.Clear();
         gxdynajaxctrldescr.Clear();
         gxdynajaxctrlcodr.Add("");
         gxdynajaxctrldescr.Add("(请选择)");
         /* Using cursor H008V7 */
         pr_default.execute(5, new Object[] {AV16tCurrentCode});
         while ( (pr_default.getStatus(5) != 101) )
         {
            gxdynajaxctrlcodr.Add(H008V7_A168XT_DefineCodeName[0]);
            gxdynajaxctrldescr.Add(H008V7_A168XT_DefineCodeName[0]);
            pr_default.readNext(5);
         }
         pr_default.close(5);
      }

      protected void GXDLVvVDISCHARGESTATUS8V2( String AV16tCurrentCode )
      {
         if ( ! context.isAjaxRequest( ) )
         {
            context.GX_webresponse.AppendHeader("Cache-Control", "no-store");
         }
         context.GX_webresponse.AddString("[[");
         GXDLVvVDISCHARGESTATUS_data8V2( AV16tCurrentCode) ;
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

      protected void GXVvVDISCHARGESTATUS_html8V2( String AV16tCurrentCode )
      {
         String gxdynajaxvalue ;
         GXDLVvVDISCHARGESTATUS_data8V2( AV16tCurrentCode) ;
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

      protected void GXDLVvVDISCHARGESTATUS_data8V2( String AV16tCurrentCode )
      {
         gxdynajaxctrlcodr.Clear();
         gxdynajaxctrldescr.Clear();
         gxdynajaxctrlcodr.Add("");
         gxdynajaxctrldescr.Add("(请选择)");
         /* Using cursor H008V8 */
         pr_default.execute(6, new Object[] {AV16tCurrentCode});
         while ( (pr_default.getStatus(6) != 101) )
         {
            gxdynajaxctrlcodr.Add(H008V8_A168XT_DefineCodeName[0]);
            gxdynajaxctrldescr.Add(H008V8_A168XT_DefineCodeName[0]);
            pr_default.readNext(6);
         }
         pr_default.close(6);
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
            AV18vDepartment = dynavVdepartment.getValidValue(AV18vDepartment);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV18vDepartment", AV18vDepartment);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vVDEPARTMENT", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( AV18vDepartment, "")), context));
         }
         if ( context.isAjaxRequest( ) )
         {
            dynavVdepartment.CurrentValue = StringUtil.RTrim( AV18vDepartment);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynavVdepartment_Internalname, "Values", dynavVdepartment.ToJavascriptSource(), true);
         }
         if ( dynavVdepartmentadm.ItemCount > 0 )
         {
            AV32vDepartmentadm = dynavVdepartmentadm.getValidValue(AV32vDepartmentadm);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV32vDepartmentadm", AV32vDepartmentadm);
         }
         if ( context.isAjaxRequest( ) )
         {
            dynavVdepartmentadm.CurrentValue = StringUtil.RTrim( AV32vDepartmentadm);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynavVdepartmentadm_Internalname, "Values", dynavVdepartmentadm.ToJavascriptSource(), true);
         }
         if ( dynavVdepartmentdisch.ItemCount > 0 )
         {
            AV34vDepartmentdisch = dynavVdepartmentdisch.getValidValue(AV34vDepartmentdisch);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV34vDepartmentdisch", AV34vDepartmentdisch);
         }
         if ( context.isAjaxRequest( ) )
         {
            dynavVdepartmentdisch.CurrentValue = StringUtil.RTrim( AV34vDepartmentdisch);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynavVdepartmentdisch_Internalname, "Values", dynavVdepartmentdisch.ToJavascriptSource(), true);
         }
         if ( dynavVinsurance.ItemCount > 0 )
         {
            AV36vInsurance = dynavVinsurance.getValidValue(AV36vInsurance);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV36vInsurance", AV36vInsurance);
         }
         if ( context.isAjaxRequest( ) )
         {
            dynavVinsurance.CurrentValue = StringUtil.RTrim( AV36vInsurance);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynavVinsurance_Internalname, "Values", dynavVinsurance.ToJavascriptSource(), true);
         }
         if ( dynavVenctype.ItemCount > 0 )
         {
            AV20vENCType = dynavVenctype.getValidValue(AV20vENCType);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV20vENCType", AV20vENCType);
         }
         if ( context.isAjaxRequest( ) )
         {
            dynavVenctype.CurrentValue = StringUtil.RTrim( AV20vENCType);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynavVenctype_Internalname, "Values", dynavVenctype.ToJavascriptSource(), true);
         }
         if ( dynavVadminsource.ItemCount > 0 )
         {
            AV17vAdminSource = dynavVadminsource.getValidValue(AV17vAdminSource);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV17vAdminSource", AV17vAdminSource);
         }
         if ( context.isAjaxRequest( ) )
         {
            dynavVadminsource.CurrentValue = StringUtil.RTrim( AV17vAdminSource);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynavVadminsource_Internalname, "Values", dynavVadminsource.ToJavascriptSource(), true);
         }
         if ( dynavVdischargestatus.ItemCount > 0 )
         {
            AV19vDischargeStatus = dynavVdischargestatus.getValidValue(AV19vDischargeStatus);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV19vDischargeStatus", AV19vDischargeStatus);
         }
         if ( context.isAjaxRequest( ) )
         {
            dynavVdischargestatus.CurrentValue = StringUtil.RTrim( AV19vDischargeStatus);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynavVdischargestatus_Internalname, "Values", dynavVdischargestatus.ToJavascriptSource(), true);
         }
      }

      public void Refresh( )
      {
         send_integrity_hashes( ) ;
         RF8V2( ) ;
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
         dynavVdepartment.Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynavVdepartment_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(dynavVdepartment.Enabled), 5, 0)), true);
         edtavVotherdepartment_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavVotherdepartment_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavVotherdepartment_Enabled), 5, 0)), true);
      }

      protected void RF8V2( )
      {
         initialize_formulas( ) ;
         clear_multi_value_controls( ) ;
         /* Execute user event: Refresh */
         E128V2 ();
         gxdyncontrolsrefreshing = true;
         fix_multi_value_controls( ) ;
         gxdyncontrolsrefreshing = false;
         if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
         {
            /* Execute user event: Load */
            E138V2 ();
            WB8V0( ) ;
         }
      }

      protected void send_integrity_lvl_hashes8V2( )
      {
         GxWebStd.gx_hidden_field( context, "vBR_INFORMATION_ID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV8BR_Information_ID), 18, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "gxhash_vBR_INFORMATION_ID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV8BR_Information_ID), "ZZZZZZZZZZZZZZZZZZ"), context));
         GxWebStd.gx_hidden_field( context, "gxhash_vVDEPARTMENT", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( AV18vDepartment, "")), context));
      }

      protected void STRUP8V0( )
      {
         /* Before Start, stand alone formulas. */
         context.Gx_err = 0;
         edtavVpatientno_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavVpatientno_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavVpatientno_Enabled), 5, 0)), true);
         dynavVdepartment.Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynavVdepartment_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(dynavVdepartment.Enabled), 5, 0)), true);
         edtavVotherdepartment_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavVotherdepartment_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavVotherdepartment_Enabled), 5, 0)), true);
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0;
         /* Execute user event: Start */
         E118V2 ();
         context.wbGlbDoneStart = 1;
         /* After Start, stand alone formulas. */
         GXVvVDEPARTMENT_html8V2( AV16tCurrentCode) ;
         GXVvVDEPARTMENTADM_html8V2( AV16tCurrentCode) ;
         GXVvVDEPARTMENTDISCH_html8V2( AV16tCurrentCode) ;
         GXVvVINSURANCE_html8V2( AV16tCurrentCode) ;
         GXVvVENCTYPE_html8V2( AV16tCurrentCode) ;
         GXVvVADMINSOURCE_html8V2( AV16tCurrentCode) ;
         GXVvVDISCHARGESTATUS_html8V2( AV16tCurrentCode) ;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read saved SDTs. */
            ajax_req_read_hidden_sdt(cgiGet( "Br_encounter"), AV5BR_Encounter);
            /* Read variables values. */
            AV29vPatientNo = cgiGet( edtavVpatientno_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV29vPatientNo", AV29vPatientNo);
            dynavVdepartment.CurrentValue = cgiGet( dynavVdepartment_Internalname);
            AV18vDepartment = cgiGet( dynavVdepartment_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV18vDepartment", AV18vDepartment);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vVDEPARTMENT", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( AV18vDepartment, "")), context));
            AV24vOtherDepartment = cgiGet( edtavVotherdepartment_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV24vOtherDepartment", AV24vOtherDepartment);
            dynavVdepartmentadm.CurrentValue = cgiGet( dynavVdepartmentadm_Internalname);
            AV32vDepartmentadm = cgiGet( dynavVdepartmentadm_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV32vDepartmentadm", AV32vDepartmentadm);
            AV33vOtherDepartmentadm = cgiGet( edtavVotherdepartmentadm_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV33vOtherDepartmentadm", AV33vOtherDepartmentadm);
            dynavVdepartmentdisch.CurrentValue = cgiGet( dynavVdepartmentdisch_Internalname);
            AV34vDepartmentdisch = cgiGet( dynavVdepartmentdisch_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV34vDepartmentdisch", AV34vDepartmentdisch);
            AV35vOtherDepartmentadisch = cgiGet( edtavVotherdepartmentadisch_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV35vOtherDepartmentadisch", AV35vOtherDepartmentadisch);
            dynavVinsurance.CurrentValue = cgiGet( dynavVinsurance_Internalname);
            AV36vInsurance = cgiGet( dynavVinsurance_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV36vInsurance", AV36vInsurance);
            AV37vOtherInsurance = cgiGet( edtavVotherinsurance_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV37vOtherInsurance", AV37vOtherInsurance);
            dynavVenctype.CurrentValue = cgiGet( dynavVenctype_Internalname);
            AV20vENCType = cgiGet( dynavVenctype_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV20vENCType", AV20vENCType);
            AV25vOtherENCType = cgiGet( edtavVotherenctype_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV25vOtherENCType", AV25vOtherENCType);
            if ( context.localUtil.VCDate( cgiGet( edtavBr_encounter_br_encounter_admitdate_Internalname), 0) == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_faildate", new   object[]  {"就诊/入院时间"}), 1, "BR_ENCOUNTER_BR_ENCOUNTER_ADMITDATE");
               GX_FocusControl = edtavBr_encounter_br_encounter_admitdate_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV5BR_Encounter.gxTpr_Br_encounter_admitdate = DateTime.MinValue;
            }
            else
            {
               AV5BR_Encounter.gxTpr_Br_encounter_admitdate = context.localUtil.CToD( cgiGet( edtavBr_encounter_br_encounter_admitdate_Internalname), 0);
            }
            dynavVadminsource.CurrentValue = cgiGet( dynavVadminsource_Internalname);
            AV17vAdminSource = cgiGet( dynavVadminsource_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV17vAdminSource", AV17vAdminSource);
            AV28vOtherReason = cgiGet( edtavVotherreason_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV28vOtherReason", AV28vOtherReason);
            if ( context.localUtil.VCDate( cgiGet( edtavBr_encounter_br_encounter_dischargedate_Internalname), 0) == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_faildate", new   object[]  {"出院时间"}), 1, "BR_ENCOUNTER_BR_ENCOUNTER_DISCHARGEDATE");
               GX_FocusControl = edtavBr_encounter_br_encounter_dischargedate_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV5BR_Encounter.gxTpr_Br_encounter_dischargedate = DateTime.MinValue;
            }
            else
            {
               AV5BR_Encounter.gxTpr_Br_encounter_dischargedate = context.localUtil.CToD( cgiGet( edtavBr_encounter_br_encounter_dischargedate_Internalname), 0);
            }
            dynavVdischargestatus.CurrentValue = cgiGet( dynavVdischargestatus_Internalname);
            AV19vDischargeStatus = cgiGet( dynavVdischargestatus_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV19vDischargeStatus", AV19vDischargeStatus);
            if ( ( ( context.localUtil.CToN( cgiGet( edtavVinformationid_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavVinformationid_Internalname), ".", ",") > Convert.ToDecimal( 999999999999999999L )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vVINFORMATIONID");
               GX_FocusControl = edtavVinformationid_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV30vInformationID = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV30vInformationID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV30vInformationID), 18, 0)));
            }
            else
            {
               AV30vInformationID = (long)(context.localUtil.CToN( cgiGet( edtavVinformationid_Internalname), ".", ","));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV30vInformationID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV30vInformationID), 18, 0)));
            }
            if ( ( ( context.localUtil.CToN( cgiGet( edtavBr_encounter_br_encounterid_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavBr_encounter_br_encounterid_Internalname), ".", ",") > Convert.ToDecimal( 999999999999999999L )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "BR_ENCOUNTER_BR_ENCOUNTERID");
               GX_FocusControl = edtavBr_encounter_br_encounterid_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV5BR_Encounter.gxTpr_Br_encounterid = 0;
            }
            else
            {
               AV5BR_Encounter.gxTpr_Br_encounterid = (long)(context.localUtil.CToN( cgiGet( edtavBr_encounter_br_encounterid_Internalname), ".", ","));
            }
            if ( ( ( context.localUtil.CToN( cgiGet( edtavBr_encounter_br_encounter_encid_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavBr_encounter_br_encounter_encid_Internalname), ".", ",") > Convert.ToDecimal( 9999999999L )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "BR_ENCOUNTER_BR_ENCOUNTER_ENCID");
               GX_FocusControl = edtavBr_encounter_br_encounter_encid_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV5BR_Encounter.gxTpr_Br_encounter_encid = 0;
            }
            else
            {
               AV5BR_Encounter.gxTpr_Br_encounter_encid = (long)(context.localUtil.CToN( cgiGet( edtavBr_encounter_br_encounter_encid_Internalname), ".", ","));
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
            forbiddenHiddens = "hsh" + "BR_EncounterInsert";
            AV18vDepartment = cgiGet( dynavVdepartment_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV18vDepartment", AV18vDepartment);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vVDEPARTMENT", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( AV18vDepartment, "")), context));
            forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( AV18vDepartment, ""));
            hsh = cgiGet( "hsh");
            if ( ! GXUtil.CheckEncryptedHash( forbiddenHiddens, hsh, GXKey) )
            {
               GXUtil.WriteLog("br_encounterinsert:[SecurityCheckFailed value for]"+"vDepartment:"+StringUtil.RTrim( context.localUtil.Format( AV18vDepartment, "")));
               GxWebError = 1;
               context.HttpContext.Response.StatusDescription = 403.ToString();
               context.HttpContext.Response.StatusCode = 403;
               context.WriteHtmlText( "<title>403 Forbidden</title>") ;
               context.WriteHtmlText( "<h1>403 Forbidden</h1>") ;
               context.WriteHtmlText( "<p /><hr />") ;
               GXUtil.WriteLog("send_http_error_code " + 403.ToString());
               return  ;
            }
            GXVvVDEPARTMENT_html8V2( AV16tCurrentCode) ;
            GXVvVDEPARTMENTADM_html8V2( AV16tCurrentCode) ;
            GXVvVDEPARTMENTDISCH_html8V2( AV16tCurrentCode) ;
            GXVvVINSURANCE_html8V2( AV16tCurrentCode) ;
            GXVvVENCTYPE_html8V2( AV16tCurrentCode) ;
            GXVvVADMINSOURCE_html8V2( AV16tCurrentCode) ;
            GXVvVDISCHARGESTATUS_html8V2( AV16tCurrentCode) ;
         }
         else
         {
            dynload_actions( ) ;
         }
      }

      protected void GXStart( )
      {
         /* Execute user event: Start */
         E118V2 ();
         if (returnInSub) return;
      }

      protected void E118V2( )
      {
         /* Start Routine */
         GXt_char1 = AV16tCurrentCode;
         new zbr_getcurrenttcode(context ).execute( out  GXt_char1) ;
         AV16tCurrentCode = GXt_char1;
         edtavVinformationid_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavVinformationid_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavVinformationid_Visible), 5, 0)), true);
         edtavBr_encounter_br_encounterid_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavBr_encounter_br_encounterid_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavBr_encounter_br_encounterid_Visible), 5, 0)), true);
         edtavBr_encounter_br_encounter_encid_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavBr_encounter_br_encounter_encid_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavBr_encounter_br_encounter_encid_Visible), 5, 0)), true);
         AV7BR_Information.Load(AV8BR_Information_ID);
         edtavVotherdepartment_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavVotherdepartment_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavVotherdepartment_Visible), 5, 0)), true);
         edtavVotherenctype_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavVotherenctype_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavVotherenctype_Visible), 5, 0)), true);
         edtavVotherreason_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavVotherreason_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavVotherreason_Visible), 5, 0)), true);
         edtavVotherdepartmentadm_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavVotherdepartmentadm_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavVotherdepartmentadm_Visible), 5, 0)), true);
         edtavVotherdepartmentadisch_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavVotherdepartmentadisch_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavVotherdepartmentadisch_Visible), 5, 0)), true);
         edtavVotherinsurance_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavVotherinsurance_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavVotherinsurance_Visible), 5, 0)), true);
         AV29vPatientNo = AV7BR_Information.gxTpr_Br_information_patientno;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV29vPatientNo", AV29vPatientNo);
         AV30vInformationID = AV8BR_Information_ID;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV30vInformationID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV30vInformationID), 18, 0)));
      }

      protected void S112( )
      {
         /* 'CHECKREQUIREDFIELDS' Routine */
         AV26CheckRequiredFieldsResult = true;
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV33vOtherDepartmentadm)) )
         {
            GX_msglist.addItem("其它入院科室是必填的");
            AV26CheckRequiredFieldsResult = false;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV35vOtherDepartmentadisch)) )
         {
            GX_msglist.addItem("其它出院科室是必填的");
            AV26CheckRequiredFieldsResult = false;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV37vOtherInsurance)) )
         {
            GX_msglist.addItem("其它保险类型是必须填写的。");
            AV26CheckRequiredFieldsResult = false;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV25vOtherENCType)) )
         {
            GX_msglist.addItem("其它就诊方式是必须填写的。");
            AV26CheckRequiredFieldsResult = false;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV28vOtherReason)) )
         {
            GX_msglist.addItem("其他入院原因是必须填写的。");
            AV26CheckRequiredFieldsResult = false;
         }
      }

      protected void S122( )
      {
         /* 'SHOW MESSAGES' Routine */
         AV44GXV5 = 1;
         while ( AV44GXV5 <= AV13Messages.Count )
         {
            AV12Message = ((SdtMessages_Message)AV13Messages.Item(AV44GXV5));
            GX_msglist.addItem(AV12Message.gxTpr_Description);
            AV44GXV5 = (int)(AV44GXV5+1);
         }
      }

      protected void E128V2( )
      {
         /* Refresh Routine */
         new GeneXus.Programs.wwpbaseobjects.loadwwpcontext(context ).execute( out  AV10Context) ;
      }

      protected void nextLoad( )
      {
      }

      protected void E138V2( )
      {
         /* Load Routine */
         AV7BR_Information.Load(AV8BR_Information_ID);
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV5BR_Encounter.gxTpr_Br_encounter_departmentadm)) )
         {
            dynavVdepartmentadm.addItem(AV5BR_Encounter.gxTpr_Br_encounter_departmentadm, AV5BR_Encounter.gxTpr_Br_encounter_departmentadm, 0);
            AV32vDepartmentadm = AV5BR_Encounter.gxTpr_Br_encounter_departmentadm;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV32vDepartmentadm", AV32vDepartmentadm);
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV5BR_Encounter.gxTpr_Br_encounter_departmentdisch)) )
         {
            dynavVdepartmentdisch.addItem(AV5BR_Encounter.gxTpr_Br_encounter_departmentdisch, AV5BR_Encounter.gxTpr_Br_encounter_departmentdisch, 0);
            AV34vDepartmentdisch = AV5BR_Encounter.gxTpr_Br_encounter_departmentdisch;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV34vDepartmentdisch", AV34vDepartmentdisch);
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV5BR_Encounter.gxTpr_Br_encounter_insurance)) )
         {
            dynavVinsurance.addItem(AV5BR_Encounter.gxTpr_Br_encounter_insurance, AV5BR_Encounter.gxTpr_Br_encounter_insurance, 0);
            AV36vInsurance = AV5BR_Encounter.gxTpr_Br_encounter_insurance;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV36vInsurance", AV36vInsurance);
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV5BR_Encounter.gxTpr_Br_encounter_enctype)) )
         {
            dynavVenctype.addItem(AV5BR_Encounter.gxTpr_Br_encounter_enctype, AV5BR_Encounter.gxTpr_Br_encounter_enctype, 0);
            AV20vENCType = AV5BR_Encounter.gxTpr_Br_encounter_enctype;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV20vENCType", AV20vENCType);
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV5BR_Encounter.gxTpr_Br_encounter_admitsource)) )
         {
            dynavVadminsource.addItem(AV5BR_Encounter.gxTpr_Br_encounter_admitsource, AV5BR_Encounter.gxTpr_Br_encounter_admitsource, 0);
            AV17vAdminSource = AV5BR_Encounter.gxTpr_Br_encounter_admitsource;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV17vAdminSource", AV17vAdminSource);
         }
      }

      public void GXEnter( )
      {
         /* Execute user event: Enter */
         E148V2 ();
         if (returnInSub) return;
      }

      protected void E148V2( )
      {
         /* Enter Routine */
         AV23tFlag = true;
         if ( ( StringUtil.StrCmp(AV32vDepartmentadm, "其它") == 0 ) && ( AV23tFlag ) )
         {
            if ( String.IsNullOrEmpty(StringUtil.RTrim( AV32vDepartmentadm)) )
            {
               GX_msglist.addItem("其它入院科室是必须填写的");
               AV23tFlag = false;
            }
            else
            {
               AV5BR_Encounter.gxTpr_Br_encounter_departmentadm = AV33vOtherDepartmentadm;
            }
         }
         else
         {
            AV5BR_Encounter.gxTpr_Br_encounter_departmentadm = AV32vDepartmentadm;
         }
         if ( ( StringUtil.StrCmp(AV34vDepartmentdisch, "其它") == 0 ) && ( AV23tFlag ) )
         {
            if ( String.IsNullOrEmpty(StringUtil.RTrim( AV34vDepartmentdisch)) )
            {
               GX_msglist.addItem("其它出院科室是必须填写的");
               AV23tFlag = false;
            }
            else
            {
               AV5BR_Encounter.gxTpr_Br_encounter_departmentdisch = AV35vOtherDepartmentadisch;
            }
         }
         else
         {
            AV5BR_Encounter.gxTpr_Br_encounter_departmentdisch = AV34vDepartmentdisch;
         }
         if ( ( StringUtil.StrCmp(AV36vInsurance, "其它") == 0 ) && ( AV23tFlag ) )
         {
            if ( String.IsNullOrEmpty(StringUtil.RTrim( AV34vDepartmentdisch)) )
            {
               GX_msglist.addItem("其它保险类型是必须填写的");
               AV23tFlag = false;
            }
            else
            {
               AV5BR_Encounter.gxTpr_Br_encounter_insurance = AV37vOtherInsurance;
            }
         }
         else
         {
            AV5BR_Encounter.gxTpr_Br_encounter_insurance = AV36vInsurance;
         }
         if ( ( StringUtil.StrCmp(AV20vENCType, "其它") == 0 ) && ( AV23tFlag ) )
         {
            if ( String.IsNullOrEmpty(StringUtil.RTrim( AV25vOtherENCType)) )
            {
               GX_msglist.addItem("其它就诊方式是必须填写的");
               AV23tFlag = false;
            }
            else
            {
               AV5BR_Encounter.gxTpr_Br_encounter_enctype = AV25vOtherENCType;
            }
         }
         else
         {
            AV5BR_Encounter.gxTpr_Br_encounter_enctype = AV20vENCType;
         }
         if ( ( StringUtil.StrCmp(AV17vAdminSource, "其它") == 0 ) && ( AV23tFlag ) )
         {
            if ( String.IsNullOrEmpty(StringUtil.RTrim( AV28vOtherReason)) )
            {
               GX_msglist.addItem("其它入院原因是必须填写的");
               AV23tFlag = false;
            }
            else
            {
               AV5BR_Encounter.gxTpr_Br_encounter_admitsource = AV28vOtherReason;
            }
         }
         else
         {
            AV5BR_Encounter.gxTpr_Br_encounter_admitsource = AV17vAdminSource;
         }
         if ( AV23tFlag )
         {
            if ( (DateTime.MinValue==AV5BR_Encounter.gxTpr_Br_encounter_admitdate) )
            {
               AV5BR_Encounter.gxTv_SdtBR_Encounter_Br_encounter_admitdate_SetNull();
            }
            if ( (DateTime.MinValue==AV5BR_Encounter.gxTpr_Br_encounter_dischargedate) )
            {
               AV5BR_Encounter.gxTv_SdtBR_Encounter_Br_encounter_dischargedate_SetNull();
            }
            if ( (DateTime.MinValue==AV5BR_Encounter.gxTpr_Br_encounter_approvedate) )
            {
               AV5BR_Encounter.gxTv_SdtBR_Encounter_Br_encounter_approvedate_SetNull();
            }
            if ( (DateTime.MinValue==AV5BR_Encounter.gxTpr_Br_encounter_recheckdate) )
            {
               AV5BR_Encounter.gxTv_SdtBR_Encounter_Br_encounter_recheckdate_SetNull();
            }
            if ( (DateTime.MinValue==AV5BR_Encounter.gxTpr_Br_encounter_upddate) )
            {
               AV5BR_Encounter.gxTv_SdtBR_Encounter_Br_encounter_upddate_SetNull();
            }
            if ( (DateTime.MinValue==AV5BR_Encounter.gxTpr_Br_encounter_submitdate) )
            {
               AV5BR_Encounter.gxTv_SdtBR_Encounter_Br_encounter_submitdate_SetNull();
            }
            if ( (DateTime.MinValue==AV5BR_Encounter.gxTpr_Br_encounter_israndnoapprovedate) )
            {
               AV5BR_Encounter.gxTv_SdtBR_Encounter_Br_encounter_israndnoapprovedate_SetNull();
            }
            if ( (DateTime.MinValue==AV5BR_Encounter.gxTpr_Br_encounter_israndapprovedate) )
            {
               AV5BR_Encounter.gxTv_SdtBR_Encounter_Br_encounter_israndapprovedate_SetNull();
            }
            if ( (DateTime.MinValue==AV5BR_Encounter.gxTpr_Br_encounter_israndrecheckdate) )
            {
               AV5BR_Encounter.gxTv_SdtBR_Encounter_Br_encounter_israndrecheckdate_SetNull();
            }
            if ( (DateTime.MinValue==AV5BR_Encounter.gxTpr_Br_encounter_israndnorecheckdate) )
            {
               AV5BR_Encounter.gxTv_SdtBR_Encounter_Br_encounter_israndnorecheckdate_SetNull();
            }
            AV29vPatientNo = AV7BR_Information.gxTpr_Br_information_patientno;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV29vPatientNo", AV29vPatientNo);
            AV30vInformationID = AV8BR_Information_ID;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV30vInformationID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV30vInformationID), 18, 0)));
            AV5BR_Encounter.gxTpr_Br_information_id = AV30vInformationID;
            GXt_int2 = 0;
            new zutil_findcountbypatientno(context ).execute(  AV30vInformationID, out  GXt_int2) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV30vInformationID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV30vInformationID), 18, 0)));
            AV5BR_Encounter.gxTpr_Br_encounter_encid = GXt_int2;
            AV5BR_Encounter.gxTpr_Br_encounter_status = 1;
            AV5BR_Encounter.gxTpr_Br_encounter_dischargestatus = AV19vDischargeStatus;
            AV5BR_Encounter.Save();
            if ( AV5BR_Encounter.Success() )
            {
               context.CommitDataStores("br_encounterinsert",pr_default);
               context.setWebReturnParms(new Object[] {});
               context.setWebReturnParmsMetadata(new Object[] {});
               context.wjLocDisableFrm = 1;
               context.nUserReturn = 1;
               returnInSub = true;
               if (true) return;
            }
            else
            {
               AV27ErrorMsg = "";
               AV46GXV7 = 1;
               AV45GXV6 = AV5BR_Encounter.GetMessages();
               while ( AV46GXV7 <= AV45GXV6.Count )
               {
                  AV12Message = ((SdtMessages_Message)AV45GXV6.Item(AV46GXV7));
                  AV27ErrorMsg = AV27ErrorMsg + StringUtil.Trim( AV12Message.gxTpr_Description);
                  AV46GXV7 = (int)(AV46GXV7+1);
               }
               GX_msglist.addItem(StringUtil.Trim( AV27ErrorMsg));
            }
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV5BR_Encounter", AV5BR_Encounter);
      }

      protected void wb_table6_109_8V2( bool wbgen )
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
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 113,'',false,'',0)\"";
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, dynavVadminsource, dynavVadminsource_Internalname, StringUtil.RTrim( AV17vAdminSource), 1, dynavVadminsource_Jsonclick, 0, "'"+""+"'"+",false,"+"'"+""+"'", "svchar", "", 1, dynavVadminsource.Enabled, 0, 0, 0, "em", 0, "", "", "Attribute", "", "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,113);\"", "", true, "HLP_BR_EncounterInsert.htm");
            dynavVadminsource.CurrentValue = StringUtil.RTrim( AV17vAdminSource);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynavVadminsource_Internalname, "Values", (String)(dynavVadminsource.ToJavascriptSource()), true);
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td class='RequiredDataContentCell'>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavVotherreason_Internalname, "v Other Reason", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 116,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavVotherreason_Internalname, AV28vOtherReason, StringUtil.RTrim( context.localUtil.Format( AV28vOtherReason, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,116);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "请填写其他入院原因", edtavVotherreason_Jsonclick, 0, "Attribute", "", "", "", "", edtavVotherreason_Visible, edtavVotherreason_Enabled, 0, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_BR_EncounterInsert.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table6_109_8V2e( true) ;
         }
         else
         {
            wb_table6_109_8V2e( false) ;
         }
      }

      protected void wb_table5_90_8V2( bool wbgen )
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
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 94,'',false,'',0)\"";
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, dynavVenctype, dynavVenctype_Internalname, StringUtil.RTrim( AV20vENCType), 1, dynavVenctype_Jsonclick, 0, "'"+""+"'"+",false,"+"'"+""+"'", "svchar", "", 1, dynavVenctype.Enabled, 0, 0, 0, "em", 0, "", "", "Attribute", "", "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,94);\"", "", true, "HLP_BR_EncounterInsert.htm");
            dynavVenctype.CurrentValue = StringUtil.RTrim( AV20vENCType);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynavVenctype_Internalname, "Values", (String)(dynavVenctype.ToJavascriptSource()), true);
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td class='RequiredDataContentCell'>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavVotherenctype_Internalname, "v Other ENCType", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 97,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavVotherenctype_Internalname, AV25vOtherENCType, StringUtil.RTrim( context.localUtil.Format( AV25vOtherENCType, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,97);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavVotherenctype_Jsonclick, 0, "Attribute", "", "", "", "", edtavVotherenctype_Visible, edtavVotherenctype_Enabled, 0, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_BR_EncounterInsert.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table5_90_8V2e( true) ;
         }
         else
         {
            wb_table5_90_8V2e( false) ;
         }
      }

      protected void wb_table4_76_8V2( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "";
            GxWebStd.gx_table_start( context, tblTablemergedvinsurance_Internalname, tblTablemergedvinsurance_Internalname, "", "TableMerged", 0, "", "", 0, 0, sStyleString, "", "", 0);
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td class='MergeDataCell'>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, dynavVinsurance_Internalname, "v Insurance", "col-sm-3 AttributeLabel", 0, true);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 80,'',false,'',0)\"";
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, dynavVinsurance, dynavVinsurance_Internalname, StringUtil.RTrim( AV36vInsurance), 1, dynavVinsurance_Jsonclick, 0, "'"+""+"'"+",false,"+"'"+""+"'", "svchar", "", 1, dynavVinsurance.Enabled, 0, 0, 0, "em", 0, "", "", "Attribute", "", "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,80);\"", "", true, "HLP_BR_EncounterInsert.htm");
            dynavVinsurance.CurrentValue = StringUtil.RTrim( AV36vInsurance);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynavVinsurance_Internalname, "Values", (String)(dynavVinsurance.ToJavascriptSource()), true);
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td class='RequiredDataContentCell'>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavVotherinsurance_Internalname, "v Other Insurance", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 83,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavVotherinsurance_Internalname, AV37vOtherInsurance, StringUtil.RTrim( context.localUtil.Format( AV37vOtherInsurance, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,83);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "请填写其保险类型", edtavVotherinsurance_Jsonclick, 0, "Attribute", "", "", "", "", edtavVotherinsurance_Visible, edtavVotherinsurance_Enabled, 0, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_BR_EncounterInsert.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table4_76_8V2e( true) ;
         }
         else
         {
            wb_table4_76_8V2e( false) ;
         }
      }

      protected void wb_table3_61_8V2( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "";
            GxWebStd.gx_table_start( context, tblTablemergedvdepartmentdisch_Internalname, tblTablemergedvdepartmentdisch_Internalname, "", "TableMerged", 0, "", "", 0, 0, sStyleString, "", "", 0);
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td class='MergeDataCell'>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, dynavVdepartmentdisch_Internalname, "v Departmentdisch", "col-sm-3 AttributeLabel", 0, true);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 65,'',false,'',0)\"";
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, dynavVdepartmentdisch, dynavVdepartmentdisch_Internalname, StringUtil.RTrim( AV34vDepartmentdisch), 1, dynavVdepartmentdisch_Jsonclick, 0, "'"+""+"'"+",false,"+"'"+""+"'", "svchar", "", 1, dynavVdepartmentdisch.Enabled, 0, 0, 0, "em", 0, "", "", "Attribute", "", "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,65);\"", "", true, "HLP_BR_EncounterInsert.htm");
            dynavVdepartmentdisch.CurrentValue = StringUtil.RTrim( AV34vDepartmentdisch);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynavVdepartmentdisch_Internalname, "Values", (String)(dynavVdepartmentdisch.ToJavascriptSource()), true);
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td class='RequiredDataContentCell'>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavVotherdepartmentadisch_Internalname, "v Other Departmentadisch", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 68,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavVotherdepartmentadisch_Internalname, AV35vOtherDepartmentadisch, StringUtil.RTrim( context.localUtil.Format( AV35vOtherDepartmentadisch, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,68);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "请填写其它出院科室", edtavVotherdepartmentadisch_Jsonclick, 0, "Attribute", "", "", "", "", edtavVotherdepartmentadisch_Visible, edtavVotherdepartmentadisch_Enabled, 0, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_BR_EncounterInsert.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table3_61_8V2e( true) ;
         }
         else
         {
            wb_table3_61_8V2e( false) ;
         }
      }

      protected void wb_table2_47_8V2( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "";
            GxWebStd.gx_table_start( context, tblTablemergedvdepartmentadm_Internalname, tblTablemergedvdepartmentadm_Internalname, "", "TableMerged", 0, "", "", 0, 0, sStyleString, "", "", 0);
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td class='MergeDataCell'>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, dynavVdepartmentadm_Internalname, "v Departmentadm", "col-sm-3 AttributeLabel", 0, true);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 51,'',false,'',0)\"";
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, dynavVdepartmentadm, dynavVdepartmentadm_Internalname, StringUtil.RTrim( AV32vDepartmentadm), 1, dynavVdepartmentadm_Jsonclick, 0, "'"+""+"'"+",false,"+"'"+""+"'", "svchar", "", 1, dynavVdepartmentadm.Enabled, 0, 0, 0, "em", 0, "", "", "Attribute", "", "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,51);\"", "", true, "HLP_BR_EncounterInsert.htm");
            dynavVdepartmentadm.CurrentValue = StringUtil.RTrim( AV32vDepartmentadm);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynavVdepartmentadm_Internalname, "Values", (String)(dynavVdepartmentadm.ToJavascriptSource()), true);
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td class='RequiredDataContentCell'>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavVotherdepartmentadm_Internalname, "v Other Departmentadm", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 54,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavVotherdepartmentadm_Internalname, AV33vOtherDepartmentadm, StringUtil.RTrim( context.localUtil.Format( AV33vOtherDepartmentadm, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,54);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "请填写其它入院科室", edtavVotherdepartmentadm_Jsonclick, 0, "Attribute", "", "", "", "", edtavVotherdepartmentadm_Visible, edtavVotherdepartmentadm_Enabled, 0, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_BR_EncounterInsert.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table2_47_8V2e( true) ;
         }
         else
         {
            wb_table2_47_8V2e( false) ;
         }
      }

      protected void wb_table1_32_8V2( bool wbgen )
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
            GxWebStd.gx_label_element( context, dynavVdepartment_Internalname, "v Department", "col-sm-3 ReadonlyAttributeLabel", 0, true);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 36,'',false,'',0)\"";
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, dynavVdepartment, dynavVdepartment_Internalname, StringUtil.RTrim( AV18vDepartment), 1, dynavVdepartment_Jsonclick, 0, "'"+""+"'"+",false,"+"'"+""+"'", "svchar", "", 1, dynavVdepartment.Enabled, 0, 0, 0, "em", 0, "", "", "ReadonlyAttribute", "", "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,36);\"", "", true, "HLP_BR_EncounterInsert.htm");
            dynavVdepartment.CurrentValue = StringUtil.RTrim( AV18vDepartment);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynavVdepartment_Internalname, "Values", (String)(dynavVdepartment.ToJavascriptSource()), true);
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td class='DataContentCell'>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavVotherdepartment_Internalname, "v Other Department", "col-sm-3 ReadonlyAttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 39,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavVotherdepartment_Internalname, AV24vOtherDepartment, StringUtil.RTrim( context.localUtil.Format( AV24vOtherDepartment, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,39);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "请填写其它就诊科室", edtavVotherdepartment_Jsonclick, 0, "ReadonlyAttribute", "", "", "", "", edtavVotherdepartment_Visible, edtavVotherdepartment_Enabled, 0, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_BR_EncounterInsert.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table1_32_8V2e( true) ;
         }
         else
         {
            wb_table1_32_8V2e( false) ;
         }
      }

      public override void setparameters( Object[] obj )
      {
         createObjects();
         initialize();
         AV8BR_Information_ID = Convert.ToInt64(getParm(obj,0));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8BR_Information_ID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV8BR_Information_ID), 18, 0)));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vBR_INFORMATION_ID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV8BR_Information_ID), "ZZZZZZZZZZZZZZZZZZ"), context));
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
         PA8V2( ) ;
         WS8V2( ) ;
         WE8V2( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?20202281517453", true);
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
         context.AddJavascriptSource("br_encounterinsert.js", "?20202281517453", false);
         context.AddJavascriptSource("DVelop/Bootstrap/Shared/DVelopBootstrap.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/Panel/BootstrapPanelRender.js", "", false);
         /* End function include_jscripts */
      }

      protected void init_web_controls( )
      {
         dynavVdepartment.Name = "vVDEPARTMENT";
         dynavVdepartment.WebTags = "";
         dynavVdepartmentadm.Name = "vVDEPARTMENTADM";
         dynavVdepartmentadm.WebTags = "";
         dynavVdepartmentdisch.Name = "vVDEPARTMENTDISCH";
         dynavVdepartmentdisch.WebTags = "";
         dynavVinsurance.Name = "vVINSURANCE";
         dynavVinsurance.WebTags = "";
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
         lblTextblockvdepartmentadm_Internalname = "TEXTBLOCKVDEPARTMENTADM";
         dynavVdepartmentadm_Internalname = "vVDEPARTMENTADM";
         edtavVotherdepartmentadm_Internalname = "vVOTHERDEPARTMENTADM";
         tblTablemergedvdepartmentadm_Internalname = "TABLEMERGEDVDEPARTMENTADM";
         divTablesplittedvdepartmentadm_Internalname = "TABLESPLITTEDVDEPARTMENTADM";
         lblTextblockvdepartmentdisch_Internalname = "TEXTBLOCKVDEPARTMENTDISCH";
         dynavVdepartmentdisch_Internalname = "vVDEPARTMENTDISCH";
         edtavVotherdepartmentadisch_Internalname = "vVOTHERDEPARTMENTADISCH";
         tblTablemergedvdepartmentdisch_Internalname = "TABLEMERGEDVDEPARTMENTDISCH";
         divTablesplittedvdepartmentdisch_Internalname = "TABLESPLITTEDVDEPARTMENTDISCH";
         lblTextblockvinsurance_Internalname = "TEXTBLOCKVINSURANCE";
         dynavVinsurance_Internalname = "vVINSURANCE";
         edtavVotherinsurance_Internalname = "vVOTHERINSURANCE";
         tblTablemergedvinsurance_Internalname = "TABLEMERGEDVINSURANCE";
         divTablesplittedvinsurance_Internalname = "TABLESPLITTEDVINSURANCE";
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
         edtavVotherdepartmentadm_Jsonclick = "";
         edtavVotherdepartmentadm_Enabled = 1;
         dynavVdepartmentadm_Jsonclick = "";
         dynavVdepartmentadm.Enabled = 1;
         edtavVotherdepartmentadisch_Jsonclick = "";
         edtavVotherdepartmentadisch_Enabled = 1;
         dynavVdepartmentdisch_Jsonclick = "";
         dynavVdepartmentdisch.Enabled = 1;
         edtavVotherinsurance_Jsonclick = "";
         edtavVotherinsurance_Enabled = 1;
         dynavVinsurance_Jsonclick = "";
         dynavVinsurance.Enabled = 1;
         edtavVotherenctype_Jsonclick = "";
         edtavVotherenctype_Enabled = 1;
         dynavVenctype_Jsonclick = "";
         dynavVenctype.Enabled = 1;
         edtavVotherreason_Jsonclick = "";
         edtavVotherreason_Enabled = 1;
         dynavVadminsource_Jsonclick = "";
         dynavVadminsource.Enabled = 1;
         edtavVotherinsurance_Visible = 1;
         edtavVotherdepartmentadisch_Visible = 1;
         edtavVotherdepartmentadm_Visible = 1;
         edtavVotherreason_Visible = 1;
         edtavVotherenctype_Visible = 1;
         edtavVotherdepartment_Visible = 1;
         edtavBr_encounter_br_encounter_encid_Jsonclick = "";
         edtavBr_encounter_br_encounter_encid_Visible = 1;
         edtavBr_encounter_br_encounterid_Jsonclick = "";
         edtavBr_encounter_br_encounterid_Visible = 1;
         edtavVinformationid_Jsonclick = "";
         edtavVinformationid_Visible = 1;
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
         Dvpanel_tableattributes_Title = "就诊基础信息";
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
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[{av:'AV8BR_Information_ID',fld:'vBR_INFORMATION_ID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true},{av:'dynavVdepartment'},{av:'AV18vDepartment',fld:'vVDEPARTMENT',pic:'',hsh:true}]");
         setEventMetadata("REFRESH",",oparms:[]}");
         setEventMetadata("ENTER","{handler:'E148V2',iparms:[{av:'dynavVdepartmentadm'},{av:'AV32vDepartmentadm',fld:'vVDEPARTMENTADM',pic:''},{av:'AV33vOtherDepartmentadm',fld:'vVOTHERDEPARTMENTADM',pic:''},{av:'AV5BR_Encounter',fld:'vBR_ENCOUNTER',pic:''},{av:'dynavVdepartmentdisch'},{av:'AV34vDepartmentdisch',fld:'vVDEPARTMENTDISCH',pic:''},{av:'AV35vOtherDepartmentadisch',fld:'vVOTHERDEPARTMENTADISCH',pic:''},{av:'dynavVinsurance'},{av:'AV36vInsurance',fld:'vVINSURANCE',pic:''},{av:'AV37vOtherInsurance',fld:'vVOTHERINSURANCE',pic:''},{av:'dynavVenctype'},{av:'AV20vENCType',fld:'vVENCTYPE',pic:''},{av:'AV25vOtherENCType',fld:'vVOTHERENCTYPE',pic:''},{av:'dynavVadminsource'},{av:'AV17vAdminSource',fld:'vVADMINSOURCE',pic:''},{av:'AV28vOtherReason',fld:'vVOTHERREASON',pic:''},{av:'AV7BR_Information',fld:'vBR_INFORMATION',pic:''},{av:'AV8BR_Information_ID',fld:'vBR_INFORMATION_ID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true},{av:'dynavVdischargestatus'},{av:'AV19vDischargeStatus',fld:'vVDISCHARGESTATUS',pic:''}]");
         setEventMetadata("ENTER",",oparms:[{av:'AV5BR_Encounter',fld:'vBR_ENCOUNTER',pic:''},{av:'AV29vPatientNo',fld:'vVPATIENTNO',pic:''},{av:'AV30vInformationID',fld:'vVINFORMATIONID',pic:'ZZZZZZZZZZZZZZZZZ9'}]}");
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
         AV16tCurrentCode = "";
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         AV18vDepartment = "";
         GXKey = "";
         forbiddenHiddens = "";
         AV5BR_Encounter = new SdtBR_Encounter(context);
         AV7BR_Information = new SdtBR_Information(context);
         GX_FocusControl = "";
         Form = new GXWebForm();
         sPrefix = "";
         ClassString = "";
         StyleString = "";
         ucDvpanel_tableattributes = new GXUserControl();
         TempTags = "";
         AV29vPatientNo = "";
         lblTextblockvdepartment_Jsonclick = "";
         lblTextblockvdepartmentadm_Jsonclick = "";
         lblTextblockvdepartmentdisch_Jsonclick = "";
         lblTextblockvinsurance_Jsonclick = "";
         lblTextblockvenctype_Jsonclick = "";
         lblTextblockvadminsource_Jsonclick = "";
         AV19vDischargeStatus = "";
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
         H008V2_A167XT_DefineCodeID = new long[1] ;
         H008V2_A168XT_DefineCodeName = new String[] {""} ;
         H008V2_n168XT_DefineCodeName = new bool[] {false} ;
         H008V2_A165XT_DefindcodeTypeID = new long[1] ;
         H008V2_A432XT_TenantCode = new String[] {""} ;
         H008V2_n432XT_TenantCode = new bool[] {false} ;
         AV32vDepartmentadm = "";
         H008V3_A167XT_DefineCodeID = new long[1] ;
         H008V3_A168XT_DefineCodeName = new String[] {""} ;
         H008V3_n168XT_DefineCodeName = new bool[] {false} ;
         H008V3_A165XT_DefindcodeTypeID = new long[1] ;
         H008V3_A432XT_TenantCode = new String[] {""} ;
         H008V3_n432XT_TenantCode = new bool[] {false} ;
         AV34vDepartmentdisch = "";
         H008V4_A167XT_DefineCodeID = new long[1] ;
         H008V4_A168XT_DefineCodeName = new String[] {""} ;
         H008V4_n168XT_DefineCodeName = new bool[] {false} ;
         H008V4_A165XT_DefindcodeTypeID = new long[1] ;
         H008V4_A432XT_TenantCode = new String[] {""} ;
         H008V4_n432XT_TenantCode = new bool[] {false} ;
         AV36vInsurance = "";
         H008V5_A167XT_DefineCodeID = new long[1] ;
         H008V5_A168XT_DefineCodeName = new String[] {""} ;
         H008V5_n168XT_DefineCodeName = new bool[] {false} ;
         H008V5_A165XT_DefindcodeTypeID = new long[1] ;
         H008V5_A432XT_TenantCode = new String[] {""} ;
         H008V5_n432XT_TenantCode = new bool[] {false} ;
         AV20vENCType = "";
         H008V6_A167XT_DefineCodeID = new long[1] ;
         H008V6_A168XT_DefineCodeName = new String[] {""} ;
         H008V6_n168XT_DefineCodeName = new bool[] {false} ;
         H008V6_A165XT_DefindcodeTypeID = new long[1] ;
         H008V6_A432XT_TenantCode = new String[] {""} ;
         H008V6_n432XT_TenantCode = new bool[] {false} ;
         AV17vAdminSource = "";
         H008V7_A167XT_DefineCodeID = new long[1] ;
         H008V7_A168XT_DefineCodeName = new String[] {""} ;
         H008V7_n168XT_DefineCodeName = new bool[] {false} ;
         H008V7_A165XT_DefindcodeTypeID = new long[1] ;
         H008V7_A432XT_TenantCode = new String[] {""} ;
         H008V7_n432XT_TenantCode = new bool[] {false} ;
         H008V8_A167XT_DefineCodeID = new long[1] ;
         H008V8_A168XT_DefineCodeName = new String[] {""} ;
         H008V8_n168XT_DefineCodeName = new bool[] {false} ;
         H008V8_A165XT_DefindcodeTypeID = new long[1] ;
         H008V8_A432XT_TenantCode = new String[] {""} ;
         H008V8_n432XT_TenantCode = new bool[] {false} ;
         AV24vOtherDepartment = "";
         AV33vOtherDepartmentadm = "";
         AV35vOtherDepartmentadisch = "";
         AV37vOtherInsurance = "";
         AV25vOtherENCType = "";
         AV28vOtherReason = "";
         hsh = "";
         GXt_char1 = "";
         AV13Messages = new GXBaseCollection<SdtMessages_Message>( context, "Message", "GeneXus");
         AV12Message = new SdtMessages_Message(context);
         AV10Context = new GeneXus.Programs.wwpbaseobjects.SdtWWPContext(context);
         AV27ErrorMsg = "";
         AV45GXV6 = new GXBaseCollection<SdtMessages_Message>( context, "Message", "GeneXus");
         sStyleString = "";
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         pr_datastore1 = new DataStoreProvider(context, new GeneXus.Programs.br_encounterinsert__datastore1(),
            new Object[][] {
            }
         );
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.br_encounterinsert__default(),
            new Object[][] {
                new Object[] {
               H008V2_A167XT_DefineCodeID, H008V2_A168XT_DefineCodeName, H008V2_n168XT_DefineCodeName, H008V2_A165XT_DefindcodeTypeID, H008V2_A432XT_TenantCode, H008V2_n432XT_TenantCode
               }
               , new Object[] {
               H008V3_A167XT_DefineCodeID, H008V3_A168XT_DefineCodeName, H008V3_n168XT_DefineCodeName, H008V3_A165XT_DefindcodeTypeID, H008V3_A432XT_TenantCode, H008V3_n432XT_TenantCode
               }
               , new Object[] {
               H008V4_A167XT_DefineCodeID, H008V4_A168XT_DefineCodeName, H008V4_n168XT_DefineCodeName, H008V4_A165XT_DefindcodeTypeID, H008V4_A432XT_TenantCode, H008V4_n432XT_TenantCode
               }
               , new Object[] {
               H008V5_A167XT_DefineCodeID, H008V5_A168XT_DefineCodeName, H008V5_n168XT_DefineCodeName, H008V5_A165XT_DefindcodeTypeID, H008V5_A432XT_TenantCode, H008V5_n432XT_TenantCode
               }
               , new Object[] {
               H008V6_A167XT_DefineCodeID, H008V6_A168XT_DefineCodeName, H008V6_n168XT_DefineCodeName, H008V6_A165XT_DefindcodeTypeID, H008V6_A432XT_TenantCode, H008V6_n432XT_TenantCode
               }
               , new Object[] {
               H008V7_A167XT_DefineCodeID, H008V7_A168XT_DefineCodeName, H008V7_n168XT_DefineCodeName, H008V7_A165XT_DefindcodeTypeID, H008V7_A432XT_TenantCode, H008V7_n432XT_TenantCode
               }
               , new Object[] {
               H008V8_A167XT_DefineCodeID, H008V8_A168XT_DefineCodeName, H008V8_n168XT_DefineCodeName, H008V8_A165XT_DefindcodeTypeID, H008V8_A432XT_TenantCode, H008V8_n432XT_TenantCode
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0;
         edtavVpatientno_Enabled = 0;
         dynavVdepartment.Enabled = 0;
         edtavVotherdepartment_Enabled = 0;
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
      private int edtavVinformationid_Visible ;
      private int edtavBr_encounter_br_encounterid_Visible ;
      private int edtavBr_encounter_br_encounter_encid_Visible ;
      private int gxdynajaxindex ;
      private int edtavVotherdepartment_Enabled ;
      private int edtavVotherdepartment_Visible ;
      private int edtavVotherenctype_Visible ;
      private int edtavVotherreason_Visible ;
      private int edtavVotherdepartmentadm_Visible ;
      private int edtavVotherdepartmentadisch_Visible ;
      private int edtavVotherinsurance_Visible ;
      private int AV44GXV5 ;
      private int AV46GXV7 ;
      private int edtavVotherreason_Enabled ;
      private int edtavVotherenctype_Enabled ;
      private int edtavVotherinsurance_Enabled ;
      private int edtavVotherdepartmentadisch_Enabled ;
      private int edtavVotherdepartmentadm_Enabled ;
      private int idxLst ;
      private long AV8BR_Information_ID ;
      private long wcpOAV8BR_Information_ID ;
      private long AV30vInformationID ;
      private long GXt_int2 ;
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
      private String edtavVpatientno_Internalname ;
      private String TempTags ;
      private String divTablesplittedvdepartment_Internalname ;
      private String lblTextblockvdepartment_Internalname ;
      private String lblTextblockvdepartment_Jsonclick ;
      private String divTablesplittedvdepartmentadm_Internalname ;
      private String lblTextblockvdepartmentadm_Internalname ;
      private String lblTextblockvdepartmentadm_Jsonclick ;
      private String divTablesplittedvdepartmentdisch_Internalname ;
      private String lblTextblockvdepartmentdisch_Internalname ;
      private String lblTextblockvdepartmentdisch_Jsonclick ;
      private String divTablesplittedvinsurance_Internalname ;
      private String lblTextblockvinsurance_Internalname ;
      private String lblTextblockvinsurance_Jsonclick ;
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
      private String dynavVdepartmentadm_Internalname ;
      private String dynavVdepartmentdisch_Internalname ;
      private String dynavVinsurance_Internalname ;
      private String dynavVenctype_Internalname ;
      private String dynavVadminsource_Internalname ;
      private String edtavVotherdepartment_Internalname ;
      private String edtavVotherdepartmentadm_Internalname ;
      private String edtavVotherdepartmentadisch_Internalname ;
      private String edtavVotherinsurance_Internalname ;
      private String edtavVotherenctype_Internalname ;
      private String edtavVotherreason_Internalname ;
      private String hsh ;
      private String GXt_char1 ;
      private String sStyleString ;
      private String tblTablemergedvadminsource_Internalname ;
      private String dynavVadminsource_Jsonclick ;
      private String edtavVotherreason_Jsonclick ;
      private String tblTablemergedvenctype_Internalname ;
      private String dynavVenctype_Jsonclick ;
      private String edtavVotherenctype_Jsonclick ;
      private String tblTablemergedvinsurance_Internalname ;
      private String dynavVinsurance_Jsonclick ;
      private String edtavVotherinsurance_Jsonclick ;
      private String tblTablemergedvdepartmentdisch_Internalname ;
      private String dynavVdepartmentdisch_Jsonclick ;
      private String edtavVotherdepartmentadisch_Jsonclick ;
      private String tblTablemergedvdepartmentadm_Internalname ;
      private String dynavVdepartmentadm_Jsonclick ;
      private String edtavVotherdepartmentadm_Jsonclick ;
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
      private bool AV26CheckRequiredFieldsResult ;
      private bool AV23tFlag ;
      private String AV16tCurrentCode ;
      private String AV18vDepartment ;
      private String AV29vPatientNo ;
      private String AV19vDischargeStatus ;
      private String AV32vDepartmentadm ;
      private String AV34vDepartmentdisch ;
      private String AV36vInsurance ;
      private String AV20vENCType ;
      private String AV17vAdminSource ;
      private String AV24vOtherDepartment ;
      private String AV33vOtherDepartmentadm ;
      private String AV35vOtherDepartmentadisch ;
      private String AV37vOtherInsurance ;
      private String AV25vOtherENCType ;
      private String AV28vOtherReason ;
      private String AV27ErrorMsg ;
      private GeneXus.Utils.GxStringCollection gxdynajaxctrlcodr ;
      private GeneXus.Utils.GxStringCollection gxdynajaxctrldescr ;
      private GXUserControl ucDvpanel_tableattributes ;
      private IGxDataStore dsDataStore1 ;
      private IGxDataStore dsDefault ;
      private GXCombobox dynavVdepartment ;
      private GXCombobox dynavVdepartmentadm ;
      private GXCombobox dynavVdepartmentdisch ;
      private GXCombobox dynavVinsurance ;
      private GXCombobox dynavVenctype ;
      private GXCombobox dynavVadminsource ;
      private GXCombobox dynavVdischargestatus ;
      private IDataStoreProvider pr_default ;
      private long[] H008V2_A167XT_DefineCodeID ;
      private String[] H008V2_A168XT_DefineCodeName ;
      private bool[] H008V2_n168XT_DefineCodeName ;
      private long[] H008V2_A165XT_DefindcodeTypeID ;
      private String[] H008V2_A432XT_TenantCode ;
      private bool[] H008V2_n432XT_TenantCode ;
      private long[] H008V3_A167XT_DefineCodeID ;
      private String[] H008V3_A168XT_DefineCodeName ;
      private bool[] H008V3_n168XT_DefineCodeName ;
      private long[] H008V3_A165XT_DefindcodeTypeID ;
      private String[] H008V3_A432XT_TenantCode ;
      private bool[] H008V3_n432XT_TenantCode ;
      private long[] H008V4_A167XT_DefineCodeID ;
      private String[] H008V4_A168XT_DefineCodeName ;
      private bool[] H008V4_n168XT_DefineCodeName ;
      private long[] H008V4_A165XT_DefindcodeTypeID ;
      private String[] H008V4_A432XT_TenantCode ;
      private bool[] H008V4_n432XT_TenantCode ;
      private long[] H008V5_A167XT_DefineCodeID ;
      private String[] H008V5_A168XT_DefineCodeName ;
      private bool[] H008V5_n168XT_DefineCodeName ;
      private long[] H008V5_A165XT_DefindcodeTypeID ;
      private String[] H008V5_A432XT_TenantCode ;
      private bool[] H008V5_n432XT_TenantCode ;
      private long[] H008V6_A167XT_DefineCodeID ;
      private String[] H008V6_A168XT_DefineCodeName ;
      private bool[] H008V6_n168XT_DefineCodeName ;
      private long[] H008V6_A165XT_DefindcodeTypeID ;
      private String[] H008V6_A432XT_TenantCode ;
      private bool[] H008V6_n432XT_TenantCode ;
      private long[] H008V7_A167XT_DefineCodeID ;
      private String[] H008V7_A168XT_DefineCodeName ;
      private bool[] H008V7_n168XT_DefineCodeName ;
      private long[] H008V7_A165XT_DefindcodeTypeID ;
      private String[] H008V7_A432XT_TenantCode ;
      private bool[] H008V7_n432XT_TenantCode ;
      private long[] H008V8_A167XT_DefineCodeID ;
      private String[] H008V8_A168XT_DefineCodeName ;
      private bool[] H008V8_n168XT_DefineCodeName ;
      private long[] H008V8_A165XT_DefindcodeTypeID ;
      private String[] H008V8_A432XT_TenantCode ;
      private bool[] H008V8_n432XT_TenantCode ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private IDataStoreProvider pr_datastore1 ;
      private GXBaseCollection<SdtMessages_Message> AV13Messages ;
      private GXBaseCollection<SdtMessages_Message> AV45GXV6 ;
      private GXWebForm Form ;
      private SdtBR_Encounter AV5BR_Encounter ;
      private SdtMessages_Message AV12Message ;
      private SdtBR_Information AV7BR_Information ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPContext AV10Context ;
   }

   public class br_encounterinsert__datastore1 : DataStoreHelperBase, IDataStoreHelper
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

 public class br_encounterinsert__default : DataStoreHelperBase, IDataStoreHelper
 {
    public ICursor[] getCursors( )
    {
       cursorDefinitions();
       return new Cursor[] {
        new ForEachCursor(def[0])
       ,new ForEachCursor(def[1])
       ,new ForEachCursor(def[2])
       ,new ForEachCursor(def[3])
       ,new ForEachCursor(def[4])
       ,new ForEachCursor(def[5])
       ,new ForEachCursor(def[6])
     };
  }

  private static CursorDef[] def;
  private void cursorDefinitions( )
  {
     if ( def == null )
     {
        Object[] prmH008V2 ;
        prmH008V2 = new Object[] {
        new Object[] {"@AV16tCurrentCode",SqlDbType.NVarChar,40,0}
        } ;
        Object[] prmH008V3 ;
        prmH008V3 = new Object[] {
        new Object[] {"@AV16tCurrentCode",SqlDbType.NVarChar,40,0}
        } ;
        Object[] prmH008V4 ;
        prmH008V4 = new Object[] {
        new Object[] {"@AV16tCurrentCode",SqlDbType.NVarChar,40,0}
        } ;
        Object[] prmH008V5 ;
        prmH008V5 = new Object[] {
        new Object[] {"@AV16tCurrentCode",SqlDbType.NVarChar,40,0}
        } ;
        Object[] prmH008V6 ;
        prmH008V6 = new Object[] {
        new Object[] {"@AV16tCurrentCode",SqlDbType.NVarChar,40,0}
        } ;
        Object[] prmH008V7 ;
        prmH008V7 = new Object[] {
        new Object[] {"@AV16tCurrentCode",SqlDbType.NVarChar,40,0}
        } ;
        Object[] prmH008V8 ;
        prmH008V8 = new Object[] {
        new Object[] {"@AV16tCurrentCode",SqlDbType.NVarChar,40,0}
        } ;
        def= new CursorDef[] {
            new CursorDef("H008V2", "SELECT [XT_DefineCodeID], [XT_DefineCodeName], [XT_DefindcodeTypeID], [XT_TenantCode] FROM [XT_DefineCode] WITH (NOLOCK) WHERE ([XT_DefindcodeTypeID] = 3) AND ([XT_TenantCode] = @AV16tCurrentCode) ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH008V2,0,0,true,false )
           ,new CursorDef("H008V3", "SELECT [XT_DefineCodeID], [XT_DefineCodeName], [XT_DefindcodeTypeID], [XT_TenantCode] FROM [XT_DefineCode] WITH (NOLOCK) WHERE ([XT_DefindcodeTypeID] = 3) AND ([XT_TenantCode] = @AV16tCurrentCode) ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH008V3,0,0,true,false )
           ,new CursorDef("H008V4", "SELECT [XT_DefineCodeID], [XT_DefineCodeName], [XT_DefindcodeTypeID], [XT_TenantCode] FROM [XT_DefineCode] WITH (NOLOCK) WHERE ([XT_DefindcodeTypeID] = 3) AND ([XT_TenantCode] = @AV16tCurrentCode) ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH008V4,0,0,true,false )
           ,new CursorDef("H008V5", "SELECT [XT_DefineCodeID], [XT_DefineCodeName], [XT_DefindcodeTypeID], [XT_TenantCode] FROM [XT_DefineCode] WITH (NOLOCK) WHERE ([XT_DefindcodeTypeID] = 11) AND ([XT_TenantCode] = @AV16tCurrentCode) ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH008V5,0,0,true,false )
           ,new CursorDef("H008V6", "SELECT [XT_DefineCodeID], [XT_DefineCodeName], [XT_DefindcodeTypeID], [XT_TenantCode] FROM [XT_DefineCode] WITH (NOLOCK) WHERE ([XT_DefindcodeTypeID] = 4) AND ([XT_TenantCode] = @AV16tCurrentCode) ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH008V6,0,0,true,false )
           ,new CursorDef("H008V7", "SELECT [XT_DefineCodeID], [XT_DefineCodeName], [XT_DefindcodeTypeID], [XT_TenantCode] FROM [XT_DefineCode] WITH (NOLOCK) WHERE ([XT_DefindcodeTypeID] = 5) AND ([XT_TenantCode] = @AV16tCurrentCode) ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH008V7,0,0,true,false )
           ,new CursorDef("H008V8", "SELECT [XT_DefineCodeID], [XT_DefineCodeName], [XT_DefindcodeTypeID], [XT_TenantCode] FROM [XT_DefineCode] WITH (NOLOCK) WHERE ([XT_DefindcodeTypeID] = 6) AND ([XT_TenantCode] = @AV16tCurrentCode) ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH008V8,0,0,true,false )
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
           case 4 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
              ((bool[]) buf[2])[0] = rslt.wasNull(2);
              ((long[]) buf[3])[0] = rslt.getLong(3) ;
              ((String[]) buf[4])[0] = rslt.getVarchar(4) ;
              ((bool[]) buf[5])[0] = rslt.wasNull(4);
              return;
           case 5 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
              ((bool[]) buf[2])[0] = rslt.wasNull(2);
              ((long[]) buf[3])[0] = rslt.getLong(3) ;
              ((String[]) buf[4])[0] = rslt.getVarchar(4) ;
              ((bool[]) buf[5])[0] = rslt.wasNull(4);
              return;
           case 6 :
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
           case 4 :
              stmt.SetParameter(1, (String)parms[0]);
              return;
           case 5 :
              stmt.SetParameter(1, (String)parms[0]);
              return;
           case 6 :
              stmt.SetParameter(1, (String)parms[0]);
              return;
     }
  }

}

}
