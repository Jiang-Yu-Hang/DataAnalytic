/*
               File: XT_Config
        Description: 系统配置表
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/27/2020 9:37:22.78
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
   public class xt_config : GXDataArea, System.Web.SessionState.IRequiresSessionState
   {
      protected void INITENV( )
      {
         if ( GxWebError != 0 )
         {
            return  ;
         }
      }

      protected void INITTRN( )
      {
         initialize_properties( ) ;
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
            Gx_mode = gxfirstwebparm;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
            if ( StringUtil.StrCmp(gxfirstwebparm, "viewer") != 0 )
            {
               AV7XT_ConfigID = (long)(NumberUtil.Val( GetNextPar( ), "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7XT_ConfigID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV7XT_ConfigID), 18, 0)));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vXT_CONFIGID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV7XT_ConfigID), "ZZZZZZZZZZZZZZZZZZ"), context));
            }
         }
         if ( context.isSpaRequest( ) )
         {
            enableJsOutput();
         }
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
         if ( ! context.isSpaRequest( ) )
         {
            Form.Meta.addItem("generator", "GeneXus C# 16_0_0-127771", 0) ;
            Form.Meta.addItem("description", "系统配置表", 0) ;
         }
         context.wjLoc = "";
         context.nUserReturn = 0;
         context.wbHandled = 0;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         GX_FocusControl = edtXT_ConfigKey_Internalname;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         wbErr = false;
         context.SetDefaultTheme("WorkWithPlusTheme");
         if ( ! context.IsLocalStorageSupported( ) )
         {
            context.PushCurrentUrl();
         }
      }

      public xt_config( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public xt_config( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( String aP0_Gx_mode ,
                           long aP1_XT_ConfigID )
      {
         this.Gx_mode = aP0_Gx_mode;
         this.AV7XT_ConfigID = aP1_XT_ConfigID;
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

      public override void webExecute( )
      {
         if ( initialized == 0 )
         {
            createObjects();
            initialize();
         }
         INITENV( ) ;
         INITTRN( ) ;
         if ( ( GxWebError == 0 ) && ! isAjaxCallMode( ) )
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

      protected void fix_multi_value_controls( )
      {
      }

      protected void Draw( )
      {
         if ( context.isAjaxRequest( ) )
         {
            disableOutput();
         }
         if ( ! GxWebStd.gx_redirect( context) )
         {
            disable_std_buttons( ) ;
            enableDisable( ) ;
            set_caption( ) ;
            /* Form start */
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
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtXT_ConfigKey_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtXT_ConfigKey_Internalname, "配置名称", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 25,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtXT_ConfigKey_Internalname, A196XT_ConfigKey, StringUtil.RTrim( context.localUtil.Format( A196XT_ConfigKey, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,25);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtXT_ConfigKey_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtXT_ConfigKey_Enabled, 0, "text", "", 40, "chr", 1, "row", 40, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_XT_Config.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtXT_ConfigValue1_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtXT_ConfigValue1_Internalname, "配置值1", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 29,'',false,'',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtXT_ConfigValue1_Internalname, A197XT_ConfigValue1, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,29);\"", 0, 1, edtXT_ConfigValue1_Enabled, 0, 80, "chr", 3, "row", StyleString, ClassString, "", "", "200", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_XT_Config.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtXT_ConfigValue2_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtXT_ConfigValue2_Internalname, "配置值2", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 34,'',false,'',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtXT_ConfigValue2_Internalname, A198XT_ConfigValue2, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,34);\"", 0, 1, edtXT_ConfigValue2_Enabled, 0, 80, "chr", 3, "row", StyleString, ClassString, "", "", "200", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_XT_Config.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtXT_ConfigValue3_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtXT_ConfigValue3_Internalname, "配置值3", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 38,'',false,'',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtXT_ConfigValue3_Internalname, A199XT_ConfigValue3, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,38);\"", 0, 1, edtXT_ConfigValue3_Enabled, 0, 80, "chr", 3, "row", StyleString, ClassString, "", "", "200", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_XT_Config.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtXT_ConfigValue4_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtXT_ConfigValue4_Internalname, "配置值4", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 43,'',false,'',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtXT_ConfigValue4_Internalname, A200XT_ConfigValue4, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,43);\"", 0, 1, edtXT_ConfigValue4_Enabled, 0, 80, "chr", 3, "row", StyleString, ClassString, "", "", "200", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_XT_Config.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtXT_ConfigValue5_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtXT_ConfigValue5_Internalname, "配置值5", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 47,'',false,'',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtXT_ConfigValue5_Internalname, A201XT_ConfigValue5, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,47);\"", 0, 1, edtXT_ConfigValue5_Enabled, 0, 80, "chr", 3, "row", StyleString, ClassString, "", "", "200", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_XT_Config.htm");
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
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 52,'',false,'',0)\"";
            ClassString = "ButtonMaterial";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtntrn_enter_Internalname, "", "确认", bttBtntrn_enter_Jsonclick, 5, "确认", "", StyleString, ClassString, bttBtntrn_enter_Visible, bttBtntrn_enter_Enabled, "standard", "'"+""+"'"+",false,"+"'"+"EENTER."+"'", TempTags, "", context.GetButtonType( ), "HLP_XT_Config.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 54,'',false,'',0)\"";
            ClassString = "ButtonMaterialDefault";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtntrn_cancel_Internalname, "", "取消", bttBtntrn_cancel_Jsonclick, 1, "取消", "", StyleString, ClassString, bttBtntrn_cancel_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ECANCEL."+"'", TempTags, "", context.GetButtonType( ), "HLP_XT_Config.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 56,'',false,'',0)\"";
            ClassString = "ButtonMaterialDefault";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtntrn_delete_Internalname, "", "删除", bttBtntrn_delete_Jsonclick, 5, "删除", "", StyleString, ClassString, bttBtntrn_delete_Visible, bttBtntrn_delete_Enabled, "standard", "'"+""+"'"+",false,"+"'"+"EDELETE."+"'", TempTags, "", context.GetButtonType( ), "HLP_XT_Config.htm");
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
            GxWebStd.gx_single_line_edit( context, edtXT_ConfigID_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A195XT_ConfigID), 18, 0, ".", "")), ((edtXT_ConfigID_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A195XT_ConfigID), "ZZZZZZZZZZZZZZZZZZ")) : context.localUtil.Format( (decimal)(A195XT_ConfigID), "ZZZZZZZZZZZZZZZZZZ")), "", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtXT_ConfigID_Jsonclick, 0, "Attribute", "", "", "", "", edtXT_ConfigID_Visible, edtXT_ConfigID_Enabled, 0, "number", "1", 18, "chr", 1, "row", 18, 0, 0, 0, 1, -1, 0, true, "ID", "right", false, "HLP_XT_Config.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            fix_multi_value_controls( ) ;
         }
         /* Execute Exit event if defined. */
      }

      protected void UserMain( )
      {
         standaloneStartup( ) ;
      }

      protected void UserMainFullajax( )
      {
         INITENV( ) ;
         INITTRN( ) ;
         UserMain( ) ;
         Draw( ) ;
         SendCloseFormHiddens( ) ;
      }

      protected void standaloneStartup( )
      {
         standaloneStartupServer( ) ;
         disable_std_buttons( ) ;
         enableDisable( ) ;
         Process( ) ;
      }

      protected void standaloneStartupServer( )
      {
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0;
         /* Execute user event: Start */
         E110Q2 ();
         context.wbGlbDoneStart = 1;
         assign_properties_default( ) ;
         if ( AnyError == 0 )
         {
            if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
            {
               /* Read saved SDTs. */
               /* Read variables values. */
               A196XT_ConfigKey = cgiGet( edtXT_ConfigKey_Internalname);
               n196XT_ConfigKey = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A196XT_ConfigKey", A196XT_ConfigKey);
               n196XT_ConfigKey = (String.IsNullOrEmpty(StringUtil.RTrim( A196XT_ConfigKey)) ? true : false);
               A197XT_ConfigValue1 = cgiGet( edtXT_ConfigValue1_Internalname);
               n197XT_ConfigValue1 = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A197XT_ConfigValue1", A197XT_ConfigValue1);
               n197XT_ConfigValue1 = (String.IsNullOrEmpty(StringUtil.RTrim( A197XT_ConfigValue1)) ? true : false);
               A198XT_ConfigValue2 = cgiGet( edtXT_ConfigValue2_Internalname);
               n198XT_ConfigValue2 = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A198XT_ConfigValue2", A198XT_ConfigValue2);
               n198XT_ConfigValue2 = (String.IsNullOrEmpty(StringUtil.RTrim( A198XT_ConfigValue2)) ? true : false);
               A199XT_ConfigValue3 = cgiGet( edtXT_ConfigValue3_Internalname);
               n199XT_ConfigValue3 = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A199XT_ConfigValue3", A199XT_ConfigValue3);
               n199XT_ConfigValue3 = (String.IsNullOrEmpty(StringUtil.RTrim( A199XT_ConfigValue3)) ? true : false);
               A200XT_ConfigValue4 = cgiGet( edtXT_ConfigValue4_Internalname);
               n200XT_ConfigValue4 = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A200XT_ConfigValue4", A200XT_ConfigValue4);
               n200XT_ConfigValue4 = (String.IsNullOrEmpty(StringUtil.RTrim( A200XT_ConfigValue4)) ? true : false);
               A201XT_ConfigValue5 = cgiGet( edtXT_ConfigValue5_Internalname);
               n201XT_ConfigValue5 = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A201XT_ConfigValue5", A201XT_ConfigValue5);
               n201XT_ConfigValue5 = (String.IsNullOrEmpty(StringUtil.RTrim( A201XT_ConfigValue5)) ? true : false);
               A195XT_ConfigID = (long)(context.localUtil.CToN( cgiGet( edtXT_ConfigID_Internalname), ".", ","));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A195XT_ConfigID", StringUtil.LTrim( StringUtil.Str( (decimal)(A195XT_ConfigID), 18, 0)));
               /* Read saved values. */
               Z195XT_ConfigID = (long)(context.localUtil.CToN( cgiGet( "Z195XT_ConfigID"), ".", ","));
               Z196XT_ConfigKey = cgiGet( "Z196XT_ConfigKey");
               n196XT_ConfigKey = (String.IsNullOrEmpty(StringUtil.RTrim( A196XT_ConfigKey)) ? true : false);
               Z197XT_ConfigValue1 = cgiGet( "Z197XT_ConfigValue1");
               n197XT_ConfigValue1 = (String.IsNullOrEmpty(StringUtil.RTrim( A197XT_ConfigValue1)) ? true : false);
               Z198XT_ConfigValue2 = cgiGet( "Z198XT_ConfigValue2");
               n198XT_ConfigValue2 = (String.IsNullOrEmpty(StringUtil.RTrim( A198XT_ConfigValue2)) ? true : false);
               Z199XT_ConfigValue3 = cgiGet( "Z199XT_ConfigValue3");
               n199XT_ConfigValue3 = (String.IsNullOrEmpty(StringUtil.RTrim( A199XT_ConfigValue3)) ? true : false);
               Z200XT_ConfigValue4 = cgiGet( "Z200XT_ConfigValue4");
               n200XT_ConfigValue4 = (String.IsNullOrEmpty(StringUtil.RTrim( A200XT_ConfigValue4)) ? true : false);
               Z201XT_ConfigValue5 = cgiGet( "Z201XT_ConfigValue5");
               n201XT_ConfigValue5 = (String.IsNullOrEmpty(StringUtil.RTrim( A201XT_ConfigValue5)) ? true : false);
               IsConfirmed = (short)(context.localUtil.CToN( cgiGet( "IsConfirmed"), ".", ","));
               IsModified = (short)(context.localUtil.CToN( cgiGet( "IsModified"), ".", ","));
               Gx_mode = cgiGet( "Mode");
               AV7XT_ConfigID = (long)(context.localUtil.CToN( cgiGet( "vXT_CONFIGID"), ".", ","));
               AV13Pgmname = cgiGet( "vPGMNAME");
               Gx_mode = cgiGet( "vMODE");
               Dvpanel_tableattributes_Objectcall = cgiGet( "DVPANEL_TABLEATTRIBUTES_Objectcall");
               Dvpanel_tableattributes_Class = cgiGet( "DVPANEL_TABLEATTRIBUTES_Class");
               Dvpanel_tableattributes_Enabled = StringUtil.StrToBool( cgiGet( "DVPANEL_TABLEATTRIBUTES_Enabled"));
               Dvpanel_tableattributes_Width = cgiGet( "DVPANEL_TABLEATTRIBUTES_Width");
               Dvpanel_tableattributes_Height = cgiGet( "DVPANEL_TABLEATTRIBUTES_Height");
               Dvpanel_tableattributes_Cls = cgiGet( "DVPANEL_TABLEATTRIBUTES_Cls");
               Dvpanel_tableattributes_Title = cgiGet( "DVPANEL_TABLEATTRIBUTES_Title");
               Dvpanel_tableattributes_Collapsible = StringUtil.StrToBool( cgiGet( "DVPANEL_TABLEATTRIBUTES_Collapsible"));
               Dvpanel_tableattributes_Collapsed = StringUtil.StrToBool( cgiGet( "DVPANEL_TABLEATTRIBUTES_Collapsed"));
               Dvpanel_tableattributes_Autowidth = StringUtil.StrToBool( cgiGet( "DVPANEL_TABLEATTRIBUTES_Autowidth"));
               Dvpanel_tableattributes_Autoheight = StringUtil.StrToBool( cgiGet( "DVPANEL_TABLEATTRIBUTES_Autoheight"));
               Dvpanel_tableattributes_Showheader = StringUtil.StrToBool( cgiGet( "DVPANEL_TABLEATTRIBUTES_Showheader"));
               Dvpanel_tableattributes_Showcollapseicon = StringUtil.StrToBool( cgiGet( "DVPANEL_TABLEATTRIBUTES_Showcollapseicon"));
               Dvpanel_tableattributes_Iconposition = cgiGet( "DVPANEL_TABLEATTRIBUTES_Iconposition");
               Dvpanel_tableattributes_Autoscroll = StringUtil.StrToBool( cgiGet( "DVPANEL_TABLEATTRIBUTES_Autoscroll"));
               Dvpanel_tableattributes_Visible = StringUtil.StrToBool( cgiGet( "DVPANEL_TABLEATTRIBUTES_Visible"));
               /* Read subfile selected row values. */
               /* Read hidden variables. */
               GXKey = Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
               forbiddenHiddens = "hsh" + "XT_Config";
               A195XT_ConfigID = (long)(context.localUtil.CToN( cgiGet( edtXT_ConfigID_Internalname), ".", ","));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A195XT_ConfigID", StringUtil.LTrim( StringUtil.Str( (decimal)(A195XT_ConfigID), 18, 0)));
               forbiddenHiddens = forbiddenHiddens + context.localUtil.Format( (decimal)(A195XT_ConfigID), "ZZZZZZZZZZZZZZZZZZ");
               forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!"));
               hsh = cgiGet( "hsh");
               if ( ( ! ( ( A195XT_ConfigID != Z195XT_ConfigID ) ) || ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) ) && ! GXUtil.CheckEncryptedHash( forbiddenHiddens, hsh, GXKey) )
               {
                  GXUtil.WriteLog("xt_config:[SecurityCheckFailed value for]"+"XT_ConfigID:"+context.localUtil.Format( (decimal)(A195XT_ConfigID), "ZZZZZZZZZZZZZZZZZZ"));
                  GXUtil.WriteLog("xt_config:[SecurityCheckFailed value for]"+"Gx_mode:"+StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")));
                  GxWebError = 1;
                  context.HttpContext.Response.StatusDescription = 403.ToString();
                  context.HttpContext.Response.StatusCode = 403;
                  context.WriteHtmlText( "<title>403 Forbidden</title>") ;
                  context.WriteHtmlText( "<h1>403 Forbidden</h1>") ;
                  context.WriteHtmlText( "<p /><hr />") ;
                  GXUtil.WriteLog("send_http_error_code " + 403.ToString());
                  AnyError = 1;
                  return  ;
               }
               standaloneNotModal( ) ;
            }
            else
            {
               standaloneNotModal( ) ;
               if ( StringUtil.StrCmp(gxfirstwebparm, "viewer") == 0 )
               {
                  Gx_mode = "DSP";
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                  A195XT_ConfigID = (long)(NumberUtil.Val( GetNextPar( ), "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A195XT_ConfigID", StringUtil.LTrim( StringUtil.Str( (decimal)(A195XT_ConfigID), 18, 0)));
                  getEqualNoModal( ) ;
                  Gx_mode = "DSP";
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                  disable_std_buttons( ) ;
                  standaloneModal( ) ;
               }
               else
               {
                  if ( StringUtil.StrCmp(Gx_mode, "DSP") == 0 )
                  {
                     sMode27 = Gx_mode;
                     Gx_mode = "UPD";
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                     Gx_mode = sMode27;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                  }
                  standaloneModal( ) ;
                  if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
                  {
                     getByPrimaryKey( ) ;
                     if ( RcdFound27 == 1 )
                     {
                        if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
                        {
                           /* Confirm record */
                           CONFIRM_0Q0( ) ;
                           if ( AnyError == 0 )
                           {
                              GX_FocusControl = bttBtntrn_enter_Internalname;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                           }
                        }
                     }
                     else
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_noinsert", ""), 1, "XT_CONFIGID");
                        AnyError = 1;
                        GX_FocusControl = edtXT_ConfigID_Internalname;
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                     }
                  }
               }
            }
         }
      }

      protected void Process( )
      {
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read Transaction buttons. */
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
                        if ( StringUtil.StrCmp(sEvt, "START") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           /* Execute user event: Start */
                           E110Q2 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "AFTER TRN") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           /* Execute user event: After Trn */
                           E120Q2 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "ENTER") == 0 )
                        {
                           context.wbHandled = 1;
                           if ( StringUtil.StrCmp(Gx_mode, "DSP") != 0 )
                           {
                              btn_enter( ) ;
                           }
                           /* No code required for Cancel button. It is implemented as the Reset button. */
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

      protected void AfterTrn( )
      {
         if ( trnEnded == 1 )
         {
            /* Execute user event: After Trn */
            E120Q2 ();
            trnEnded = 0;
            standaloneNotModal( ) ;
            standaloneModal( ) ;
            if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  )
            {
               /* Clear variables for new insertion. */
               InitAll0Q27( ) ;
               standaloneNotModal( ) ;
               standaloneModal( ) ;
            }
         }
      }

      public override String ToString( )
      {
         return "" ;
      }

      public GxContentInfo GetContentInfo( )
      {
         return (GxContentInfo)(null) ;
      }

      protected void disable_std_buttons( )
      {
         bttBtntrn_delete_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtntrn_delete_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtntrn_delete_Visible), 5, 0)), true);
         if ( ( StringUtil.StrCmp(Gx_mode, "DSP") == 0 ) || ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 ) )
         {
            bttBtntrn_delete_Visible = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtntrn_delete_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtntrn_delete_Visible), 5, 0)), true);
            if ( StringUtil.StrCmp(Gx_mode, "DSP") == 0 )
            {
               bttBtntrn_enter_Visible = 0;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtntrn_enter_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtntrn_enter_Visible), 5, 0)), true);
            }
            DisableAttributes0Q27( ) ;
         }
      }

      protected void set_caption( )
      {
         if ( ( IsConfirmed == 1 ) && ( AnyError == 0 ) )
         {
            if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_confdelete", ""), 0, "", true);
            }
            else
            {
               GX_msglist.addItem(context.GetMessage( "GXM_mustconfirm", ""), 0, "", true);
            }
         }
      }

      protected void CONFIRM_0Q0( )
      {
         BeforeValidate0Q27( ) ;
         if ( AnyError == 0 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
            {
               OnDeleteControls0Q27( ) ;
            }
            else
            {
               CheckExtendedTable0Q27( ) ;
               CloseExtendedTableCursors0Q27( ) ;
            }
         }
         if ( AnyError == 0 )
         {
            IsConfirmed = 1;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "IsConfirmed", StringUtil.LTrim( StringUtil.Str( (decimal)(IsConfirmed), 4, 0)));
         }
      }

      protected void ResetCaption0Q0( )
      {
      }

      protected void E110Q2( )
      {
         /* Start Routine */
         new GeneXus.Programs.wwpbaseobjects.loadwwpcontext(context ).execute( out  AV8WWPContext) ;
         AV9IsAuthorized = true;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9IsAuthorized", AV9IsAuthorized);
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            GXt_boolean1 = AV9IsAuthorized;
            new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "WWXT_Config_Insert", out  GXt_boolean1) ;
            AV9IsAuthorized = GXt_boolean1;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9IsAuthorized", AV9IsAuthorized);
         }
         if ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 )
         {
            GXt_boolean1 = AV9IsAuthorized;
            new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "WWXT_Config_Update", out  GXt_boolean1) ;
            AV9IsAuthorized = GXt_boolean1;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9IsAuthorized", AV9IsAuthorized);
         }
         if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
         {
            GXt_boolean1 = AV9IsAuthorized;
            new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "WWXT_Config_Delete", out  GXt_boolean1) ;
            AV9IsAuthorized = GXt_boolean1;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9IsAuthorized", AV9IsAuthorized);
         }
         if ( ! AV9IsAuthorized )
         {
            CallWebObject(formatLink("wwpbaseobjects.notauthorized.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV13Pgmname)));
            context.wjLocDisableFrm = 1;
         }
         AV11TrnContext.FromXml(AV12WebSession.Get("TrnContext"), null, "WWPTransactionContext", "DataAnalysisPlatform");
         edtXT_ConfigID_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtXT_ConfigID_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtXT_ConfigID_Visible), 5, 0)), true);
      }

      protected void E120Q2( )
      {
         /* After Trn Routine */
         if ( ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 ) && ! AV11TrnContext.gxTpr_Callerondelete )
         {
            CallWebObject(formatLink("xt_configww.aspx") );
            context.wjLocDisableFrm = 1;
         }
         context.setWebReturnParms(new Object[] {});
         context.setWebReturnParmsMetadata(new Object[] {});
         context.wjLocDisableFrm = 1;
         context.nUserReturn = 1;
         returnInSub = true;
         if (true) return;
      }

      protected void ZM0Q27( short GX_JID )
      {
         if ( ( GX_JID == 3 ) || ( GX_JID == 0 ) )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
            {
               Z196XT_ConfigKey = T000Q3_A196XT_ConfigKey[0];
               Z197XT_ConfigValue1 = T000Q3_A197XT_ConfigValue1[0];
               Z198XT_ConfigValue2 = T000Q3_A198XT_ConfigValue2[0];
               Z199XT_ConfigValue3 = T000Q3_A199XT_ConfigValue3[0];
               Z200XT_ConfigValue4 = T000Q3_A200XT_ConfigValue4[0];
               Z201XT_ConfigValue5 = T000Q3_A201XT_ConfigValue5[0];
            }
            else
            {
               Z196XT_ConfigKey = A196XT_ConfigKey;
               Z197XT_ConfigValue1 = A197XT_ConfigValue1;
               Z198XT_ConfigValue2 = A198XT_ConfigValue2;
               Z199XT_ConfigValue3 = A199XT_ConfigValue3;
               Z200XT_ConfigValue4 = A200XT_ConfigValue4;
               Z201XT_ConfigValue5 = A201XT_ConfigValue5;
            }
         }
         if ( GX_JID == -3 )
         {
            Z195XT_ConfigID = A195XT_ConfigID;
            Z196XT_ConfigKey = A196XT_ConfigKey;
            Z197XT_ConfigValue1 = A197XT_ConfigValue1;
            Z198XT_ConfigValue2 = A198XT_ConfigValue2;
            Z199XT_ConfigValue3 = A199XT_ConfigValue3;
            Z200XT_ConfigValue4 = A200XT_ConfigValue4;
            Z201XT_ConfigValue5 = A201XT_ConfigValue5;
         }
      }

      protected void standaloneNotModal( )
      {
         edtXT_ConfigID_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtXT_ConfigID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtXT_ConfigID_Enabled), 5, 0)), true);
         edtXT_ConfigID_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtXT_ConfigID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtXT_ConfigID_Enabled), 5, 0)), true);
         bttBtntrn_delete_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtntrn_delete_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtntrn_delete_Enabled), 5, 0)), true);
         if ( ! (0==AV7XT_ConfigID) )
         {
            A195XT_ConfigID = AV7XT_ConfigID;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A195XT_ConfigID", StringUtil.LTrim( StringUtil.Str( (decimal)(A195XT_ConfigID), 18, 0)));
         }
      }

      protected void standaloneModal( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "DSP") == 0 )
         {
            bttBtntrn_enter_Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtntrn_enter_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtntrn_enter_Enabled), 5, 0)), true);
         }
         else
         {
            bttBtntrn_enter_Enabled = 1;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtntrn_enter_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtntrn_enter_Enabled), 5, 0)), true);
         }
      }

      protected void Load0Q27( )
      {
         /* Using cursor T000Q4 */
         pr_default.execute(2, new Object[] {A195XT_ConfigID});
         if ( (pr_default.getStatus(2) != 101) )
         {
            RcdFound27 = 1;
            A196XT_ConfigKey = T000Q4_A196XT_ConfigKey[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A196XT_ConfigKey", A196XT_ConfigKey);
            n196XT_ConfigKey = T000Q4_n196XT_ConfigKey[0];
            A197XT_ConfigValue1 = T000Q4_A197XT_ConfigValue1[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A197XT_ConfigValue1", A197XT_ConfigValue1);
            n197XT_ConfigValue1 = T000Q4_n197XT_ConfigValue1[0];
            A198XT_ConfigValue2 = T000Q4_A198XT_ConfigValue2[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A198XT_ConfigValue2", A198XT_ConfigValue2);
            n198XT_ConfigValue2 = T000Q4_n198XT_ConfigValue2[0];
            A199XT_ConfigValue3 = T000Q4_A199XT_ConfigValue3[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A199XT_ConfigValue3", A199XT_ConfigValue3);
            n199XT_ConfigValue3 = T000Q4_n199XT_ConfigValue3[0];
            A200XT_ConfigValue4 = T000Q4_A200XT_ConfigValue4[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A200XT_ConfigValue4", A200XT_ConfigValue4);
            n200XT_ConfigValue4 = T000Q4_n200XT_ConfigValue4[0];
            A201XT_ConfigValue5 = T000Q4_A201XT_ConfigValue5[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A201XT_ConfigValue5", A201XT_ConfigValue5);
            n201XT_ConfigValue5 = T000Q4_n201XT_ConfigValue5[0];
            ZM0Q27( -3) ;
         }
         pr_default.close(2);
         OnLoadActions0Q27( ) ;
      }

      protected void OnLoadActions0Q27( )
      {
         AV13Pgmname = "XT_Config";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13Pgmname", AV13Pgmname);
      }

      protected void CheckExtendedTable0Q27( )
      {
         Gx_BScreen = 1;
         standaloneModal( ) ;
         AV13Pgmname = "XT_Config";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13Pgmname", AV13Pgmname);
      }

      protected void CloseExtendedTableCursors0Q27( )
      {
      }

      protected void enableDisable( )
      {
      }

      protected void GetKey0Q27( )
      {
         /* Using cursor T000Q5 */
         pr_default.execute(3, new Object[] {A195XT_ConfigID});
         if ( (pr_default.getStatus(3) != 101) )
         {
            RcdFound27 = 1;
         }
         else
         {
            RcdFound27 = 0;
         }
         pr_default.close(3);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor T000Q3 */
         pr_default.execute(1, new Object[] {A195XT_ConfigID});
         if ( (pr_default.getStatus(1) != 101) )
         {
            ZM0Q27( 3) ;
            RcdFound27 = 1;
            A195XT_ConfigID = T000Q3_A195XT_ConfigID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A195XT_ConfigID", StringUtil.LTrim( StringUtil.Str( (decimal)(A195XT_ConfigID), 18, 0)));
            A196XT_ConfigKey = T000Q3_A196XT_ConfigKey[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A196XT_ConfigKey", A196XT_ConfigKey);
            n196XT_ConfigKey = T000Q3_n196XT_ConfigKey[0];
            A197XT_ConfigValue1 = T000Q3_A197XT_ConfigValue1[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A197XT_ConfigValue1", A197XT_ConfigValue1);
            n197XT_ConfigValue1 = T000Q3_n197XT_ConfigValue1[0];
            A198XT_ConfigValue2 = T000Q3_A198XT_ConfigValue2[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A198XT_ConfigValue2", A198XT_ConfigValue2);
            n198XT_ConfigValue2 = T000Q3_n198XT_ConfigValue2[0];
            A199XT_ConfigValue3 = T000Q3_A199XT_ConfigValue3[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A199XT_ConfigValue3", A199XT_ConfigValue3);
            n199XT_ConfigValue3 = T000Q3_n199XT_ConfigValue3[0];
            A200XT_ConfigValue4 = T000Q3_A200XT_ConfigValue4[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A200XT_ConfigValue4", A200XT_ConfigValue4);
            n200XT_ConfigValue4 = T000Q3_n200XT_ConfigValue4[0];
            A201XT_ConfigValue5 = T000Q3_A201XT_ConfigValue5[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A201XT_ConfigValue5", A201XT_ConfigValue5);
            n201XT_ConfigValue5 = T000Q3_n201XT_ConfigValue5[0];
            Z195XT_ConfigID = A195XT_ConfigID;
            sMode27 = Gx_mode;
            Gx_mode = "DSP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
            Load0Q27( ) ;
            if ( AnyError == 1 )
            {
               RcdFound27 = 0;
               InitializeNonKey0Q27( ) ;
            }
            Gx_mode = sMode27;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         }
         else
         {
            RcdFound27 = 0;
            InitializeNonKey0Q27( ) ;
            sMode27 = Gx_mode;
            Gx_mode = "DSP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
            standaloneModal( ) ;
            Gx_mode = sMode27;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         }
         pr_default.close(1);
      }

      protected void getEqualNoModal( )
      {
         GetKey0Q27( ) ;
         if ( RcdFound27 == 0 )
         {
         }
         else
         {
         }
         getByPrimaryKey( ) ;
      }

      protected void move_next( )
      {
         RcdFound27 = 0;
         /* Using cursor T000Q6 */
         pr_default.execute(4, new Object[] {A195XT_ConfigID});
         if ( (pr_default.getStatus(4) != 101) )
         {
            while ( (pr_default.getStatus(4) != 101) && ( ( T000Q6_A195XT_ConfigID[0] < A195XT_ConfigID ) ) )
            {
               pr_default.readNext(4);
            }
            if ( (pr_default.getStatus(4) != 101) && ( ( T000Q6_A195XT_ConfigID[0] > A195XT_ConfigID ) ) )
            {
               A195XT_ConfigID = T000Q6_A195XT_ConfigID[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A195XT_ConfigID", StringUtil.LTrim( StringUtil.Str( (decimal)(A195XT_ConfigID), 18, 0)));
               RcdFound27 = 1;
            }
         }
         pr_default.close(4);
      }

      protected void move_previous( )
      {
         RcdFound27 = 0;
         /* Using cursor T000Q7 */
         pr_default.execute(5, new Object[] {A195XT_ConfigID});
         if ( (pr_default.getStatus(5) != 101) )
         {
            while ( (pr_default.getStatus(5) != 101) && ( ( T000Q7_A195XT_ConfigID[0] > A195XT_ConfigID ) ) )
            {
               pr_default.readNext(5);
            }
            if ( (pr_default.getStatus(5) != 101) && ( ( T000Q7_A195XT_ConfigID[0] < A195XT_ConfigID ) ) )
            {
               A195XT_ConfigID = T000Q7_A195XT_ConfigID[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A195XT_ConfigID", StringUtil.LTrim( StringUtil.Str( (decimal)(A195XT_ConfigID), 18, 0)));
               RcdFound27 = 1;
            }
         }
         pr_default.close(5);
      }

      protected void btn_enter( )
      {
         nKeyPressed = 1;
         GetKey0Q27( ) ;
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            /* Insert record */
            GX_FocusControl = edtXT_ConfigKey_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            Insert0Q27( ) ;
            if ( AnyError == 1 )
            {
               GX_FocusControl = "";
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
         }
         else
         {
            if ( RcdFound27 == 1 )
            {
               if ( A195XT_ConfigID != Z195XT_ConfigID )
               {
                  A195XT_ConfigID = Z195XT_ConfigID;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A195XT_ConfigID", StringUtil.LTrim( StringUtil.Str( (decimal)(A195XT_ConfigID), 18, 0)));
                  GX_msglist.addItem(context.GetMessage( "GXM_getbeforeupd", ""), "CandidateKeyNotFound", 1, "XT_CONFIGID");
                  AnyError = 1;
                  GX_FocusControl = edtXT_ConfigID_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
               else if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
               {
                  delete( ) ;
                  AfterTrn( ) ;
                  GX_FocusControl = edtXT_ConfigKey_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
               else
               {
                  /* Update record */
                  Update0Q27( ) ;
                  GX_FocusControl = edtXT_ConfigKey_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
            }
            else
            {
               if ( A195XT_ConfigID != Z195XT_ConfigID )
               {
                  /* Insert record */
                  GX_FocusControl = edtXT_ConfigKey_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  Insert0Q27( ) ;
                  if ( AnyError == 1 )
                  {
                     GX_FocusControl = "";
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  }
               }
               else
               {
                  if ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 )
                  {
                     GX_msglist.addItem(context.GetMessage( "GXM_recdeleted", ""), 1, "XT_CONFIGID");
                     AnyError = 1;
                     GX_FocusControl = edtXT_ConfigID_Internalname;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  }
                  else
                  {
                     /* Insert record */
                     GX_FocusControl = edtXT_ConfigKey_Internalname;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                     Insert0Q27( ) ;
                     if ( AnyError == 1 )
                     {
                        GX_FocusControl = "";
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                     }
                  }
               }
            }
         }
         AfterTrn( ) ;
         if ( ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 ) || ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 ) )
         {
            if ( AnyError == 0 )
            {
               context.nUserReturn = 1;
            }
         }
      }

      protected void btn_delete( )
      {
         if ( A195XT_ConfigID != Z195XT_ConfigID )
         {
            A195XT_ConfigID = Z195XT_ConfigID;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A195XT_ConfigID", StringUtil.LTrim( StringUtil.Str( (decimal)(A195XT_ConfigID), 18, 0)));
            GX_msglist.addItem(context.GetMessage( "GXM_getbeforedlt", ""), 1, "XT_CONFIGID");
            AnyError = 1;
            GX_FocusControl = edtXT_ConfigID_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         else
         {
            delete( ) ;
            AfterTrn( ) ;
            GX_FocusControl = edtXT_ConfigKey_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( AnyError != 0 )
         {
         }
      }

      protected void CheckOptimisticConcurrency0Q27( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor T000Q2 */
            pr_default.execute(0, new Object[] {A195XT_ConfigID});
            if ( (pr_default.getStatus(0) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"XT_Config"}), "RecordIsLocked", 1, "");
               AnyError = 1;
               return  ;
            }
            Gx_longc = false;
            if ( (pr_default.getStatus(0) == 101) || ( StringUtil.StrCmp(Z196XT_ConfigKey, T000Q2_A196XT_ConfigKey[0]) != 0 ) || ( StringUtil.StrCmp(Z197XT_ConfigValue1, T000Q2_A197XT_ConfigValue1[0]) != 0 ) || ( StringUtil.StrCmp(Z198XT_ConfigValue2, T000Q2_A198XT_ConfigValue2[0]) != 0 ) || ( StringUtil.StrCmp(Z199XT_ConfigValue3, T000Q2_A199XT_ConfigValue3[0]) != 0 ) || ( StringUtil.StrCmp(Z200XT_ConfigValue4, T000Q2_A200XT_ConfigValue4[0]) != 0 ) )
            {
               Gx_longc = true;
            }
            if ( Gx_longc || ( StringUtil.StrCmp(Z201XT_ConfigValue5, T000Q2_A201XT_ConfigValue5[0]) != 0 ) )
            {
               if ( StringUtil.StrCmp(Z196XT_ConfigKey, T000Q2_A196XT_ConfigKey[0]) != 0 )
               {
                  GXUtil.WriteLog("xt_config:[seudo value changed for attri]"+"XT_ConfigKey");
                  GXUtil.WriteLogRaw("Old: ",Z196XT_ConfigKey);
                  GXUtil.WriteLogRaw("Current: ",T000Q2_A196XT_ConfigKey[0]);
               }
               if ( StringUtil.StrCmp(Z197XT_ConfigValue1, T000Q2_A197XT_ConfigValue1[0]) != 0 )
               {
                  GXUtil.WriteLog("xt_config:[seudo value changed for attri]"+"XT_ConfigValue1");
                  GXUtil.WriteLogRaw("Old: ",Z197XT_ConfigValue1);
                  GXUtil.WriteLogRaw("Current: ",T000Q2_A197XT_ConfigValue1[0]);
               }
               if ( StringUtil.StrCmp(Z198XT_ConfigValue2, T000Q2_A198XT_ConfigValue2[0]) != 0 )
               {
                  GXUtil.WriteLog("xt_config:[seudo value changed for attri]"+"XT_ConfigValue2");
                  GXUtil.WriteLogRaw("Old: ",Z198XT_ConfigValue2);
                  GXUtil.WriteLogRaw("Current: ",T000Q2_A198XT_ConfigValue2[0]);
               }
               if ( StringUtil.StrCmp(Z199XT_ConfigValue3, T000Q2_A199XT_ConfigValue3[0]) != 0 )
               {
                  GXUtil.WriteLog("xt_config:[seudo value changed for attri]"+"XT_ConfigValue3");
                  GXUtil.WriteLogRaw("Old: ",Z199XT_ConfigValue3);
                  GXUtil.WriteLogRaw("Current: ",T000Q2_A199XT_ConfigValue3[0]);
               }
               if ( StringUtil.StrCmp(Z200XT_ConfigValue4, T000Q2_A200XT_ConfigValue4[0]) != 0 )
               {
                  GXUtil.WriteLog("xt_config:[seudo value changed for attri]"+"XT_ConfigValue4");
                  GXUtil.WriteLogRaw("Old: ",Z200XT_ConfigValue4);
                  GXUtil.WriteLogRaw("Current: ",T000Q2_A200XT_ConfigValue4[0]);
               }
               if ( StringUtil.StrCmp(Z201XT_ConfigValue5, T000Q2_A201XT_ConfigValue5[0]) != 0 )
               {
                  GXUtil.WriteLog("xt_config:[seudo value changed for attri]"+"XT_ConfigValue5");
                  GXUtil.WriteLogRaw("Old: ",Z201XT_ConfigValue5);
                  GXUtil.WriteLogRaw("Current: ",T000Q2_A201XT_ConfigValue5[0]);
               }
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"XT_Config"}), "RecordWasChanged", 1, "");
               AnyError = 1;
               return  ;
            }
         }
      }

      protected void Insert0Q27( )
      {
         BeforeValidate0Q27( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0Q27( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM0Q27( 0) ;
            CheckOptimisticConcurrency0Q27( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0Q27( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert0Q27( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000Q8 */
                     pr_default.execute(6, new Object[] {n196XT_ConfigKey, A196XT_ConfigKey, n197XT_ConfigValue1, A197XT_ConfigValue1, n198XT_ConfigValue2, A198XT_ConfigValue2, n199XT_ConfigValue3, A199XT_ConfigValue3, n200XT_ConfigValue4, A200XT_ConfigValue4, n201XT_ConfigValue5, A201XT_ConfigValue5});
                     A195XT_ConfigID = T000Q8_A195XT_ConfigID[0];
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A195XT_ConfigID", StringUtil.LTrim( StringUtil.Str( (decimal)(A195XT_ConfigID), 18, 0)));
                     pr_default.close(6);
                     dsDefault.SmartCacheProvider.SetUpdated("XT_Config") ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( Insert) rules */
                        /* End of After( Insert) rules */
                        if ( AnyError == 0 )
                        {
                           /* Save values for previous() function. */
                           GX_msglist.addItem(context.GetMessage( "GXM_sucadded", ""), "SuccessfullyAdded", 0, "", true);
                           ResetCaption0Q0( ) ;
                        }
                     }
                  }
                  else
                  {
                     GX_msglist.addItem(context.GetMessage( "GXM_unexp", ""), 1, "");
                     AnyError = 1;
                  }
               }
            }
            else
            {
               Load0Q27( ) ;
            }
            EndLevel0Q27( ) ;
         }
         CloseExtendedTableCursors0Q27( ) ;
      }

      protected void Update0Q27( )
      {
         BeforeValidate0Q27( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0Q27( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0Q27( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0Q27( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate0Q27( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000Q9 */
                     pr_default.execute(7, new Object[] {n196XT_ConfigKey, A196XT_ConfigKey, n197XT_ConfigValue1, A197XT_ConfigValue1, n198XT_ConfigValue2, A198XT_ConfigValue2, n199XT_ConfigValue3, A199XT_ConfigValue3, n200XT_ConfigValue4, A200XT_ConfigValue4, n201XT_ConfigValue5, A201XT_ConfigValue5, A195XT_ConfigID});
                     pr_default.close(7);
                     dsDefault.SmartCacheProvider.SetUpdated("XT_Config") ;
                     if ( (pr_default.getStatus(7) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"XT_Config"}), "RecordIsLocked", 1, "");
                        AnyError = 1;
                     }
                     DeferredUpdate0Q27( ) ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( update) rules */
                        /* End of After( update) rules */
                        if ( AnyError == 0 )
                        {
                           if ( ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 ) || ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 ) )
                           {
                              if ( AnyError == 0 )
                              {
                                 context.nUserReturn = 1;
                              }
                           }
                        }
                     }
                     else
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_unexp", ""), 1, "");
                        AnyError = 1;
                     }
                  }
               }
            }
            EndLevel0Q27( ) ;
         }
         CloseExtendedTableCursors0Q27( ) ;
      }

      protected void DeferredUpdate0Q27( )
      {
      }

      protected void delete( )
      {
         BeforeValidate0Q27( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0Q27( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls0Q27( ) ;
            AfterConfirm0Q27( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete0Q27( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor T000Q10 */
                  pr_default.execute(8, new Object[] {A195XT_ConfigID});
                  pr_default.close(8);
                  dsDefault.SmartCacheProvider.SetUpdated("XT_Config") ;
                  if ( AnyError == 0 )
                  {
                     /* Start of After( delete) rules */
                     /* End of After( delete) rules */
                     if ( AnyError == 0 )
                     {
                        if ( ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 ) || ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 ) )
                        {
                           if ( AnyError == 0 )
                           {
                              context.nUserReturn = 1;
                           }
                        }
                     }
                  }
                  else
                  {
                     GX_msglist.addItem(context.GetMessage( "GXM_unexp", ""), 1, "");
                     AnyError = 1;
                  }
               }
            }
         }
         sMode27 = Gx_mode;
         Gx_mode = "DLT";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         EndLevel0Q27( ) ;
         Gx_mode = sMode27;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
      }

      protected void OnDeleteControls0Q27( )
      {
         standaloneModal( ) ;
         if ( AnyError == 0 )
         {
            /* Delete mode formulas */
            AV13Pgmname = "XT_Config";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13Pgmname", AV13Pgmname);
         }
      }

      protected void EndLevel0Q27( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            pr_default.close(0);
         }
         if ( AnyError == 0 )
         {
            BeforeComplete0Q27( ) ;
         }
         if ( AnyError == 0 )
         {
            pr_default.close(1);
            context.CommitDataStores("xt_config",pr_default);
            if ( AnyError == 0 )
            {
               ConfirmValues0Q0( ) ;
            }
            /* After transaction rules */
            /* Execute 'After Trn' event if defined. */
            trnEnded = 1;
         }
         else
         {
            pr_default.close(1);
            context.RollbackDataStores("xt_config",pr_default);
         }
         IsModified = 0;
         if ( AnyError != 0 )
         {
            context.wjLoc = "";
            context.nUserReturn = 0;
         }
      }

      public void ScanStart0Q27( )
      {
         /* Scan By routine */
         /* Using cursor T000Q11 */
         pr_default.execute(9);
         RcdFound27 = 0;
         if ( (pr_default.getStatus(9) != 101) )
         {
            RcdFound27 = 1;
            A195XT_ConfigID = T000Q11_A195XT_ConfigID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A195XT_ConfigID", StringUtil.LTrim( StringUtil.Str( (decimal)(A195XT_ConfigID), 18, 0)));
         }
         /* Load Subordinate Levels */
      }

      protected void ScanNext0Q27( )
      {
         /* Scan next routine */
         pr_default.readNext(9);
         RcdFound27 = 0;
         if ( (pr_default.getStatus(9) != 101) )
         {
            RcdFound27 = 1;
            A195XT_ConfigID = T000Q11_A195XT_ConfigID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A195XT_ConfigID", StringUtil.LTrim( StringUtil.Str( (decimal)(A195XT_ConfigID), 18, 0)));
         }
      }

      protected void ScanEnd0Q27( )
      {
         pr_default.close(9);
      }

      protected void AfterConfirm0Q27( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert0Q27( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate0Q27( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete0Q27( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete0Q27( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate0Q27( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes0Q27( )
      {
         edtXT_ConfigKey_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtXT_ConfigKey_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtXT_ConfigKey_Enabled), 5, 0)), true);
         edtXT_ConfigValue1_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtXT_ConfigValue1_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtXT_ConfigValue1_Enabled), 5, 0)), true);
         edtXT_ConfigValue2_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtXT_ConfigValue2_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtXT_ConfigValue2_Enabled), 5, 0)), true);
         edtXT_ConfigValue3_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtXT_ConfigValue3_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtXT_ConfigValue3_Enabled), 5, 0)), true);
         edtXT_ConfigValue4_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtXT_ConfigValue4_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtXT_ConfigValue4_Enabled), 5, 0)), true);
         edtXT_ConfigValue5_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtXT_ConfigValue5_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtXT_ConfigValue5_Enabled), 5, 0)), true);
         edtXT_ConfigID_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtXT_ConfigID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtXT_ConfigID_Enabled), 5, 0)), true);
      }

      protected void send_integrity_lvl_hashes0Q27( )
      {
      }

      protected void assign_properties_default( )
      {
      }

      protected void ConfirmValues0Q0( )
      {
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
         MasterPageObj.master_styles();
         if ( ( ( context.GetBrowserType( ) == 1 ) || ( context.GetBrowserType( ) == 5 ) ) && ( StringUtil.StrCmp(context.GetBrowserVersion( ), "7.0") == 0 ) )
         {
            context.AddJavascriptSource("json2.js", "?"+context.GetBuildNumber( 127771), false);
         }
         context.AddJavascriptSource("jquery.js", "?"+context.GetBuildNumber( 127771), false);
         context.AddJavascriptSource("gxtimezone.js", "?"+context.GetBuildNumber( 127771), false);
         context.AddJavascriptSource("gxgral.js", "?"+context.GetBuildNumber( 127771), false);
         context.AddJavascriptSource("gxcfg.js", "?2020227937251", false);
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
         bodyStyle = bodyStyle + "-moz-opacity:0;opacity:0;";
         if ( ! ( String.IsNullOrEmpty(StringUtil.RTrim( Form.Background)) ) )
         {
            bodyStyle = bodyStyle + " background-image:url(" + context.convertURL( Form.Background) + ")";
         }
         context.WriteHtmlText( " "+"class=\"form-horizontal Form\""+" "+ "style='"+bodyStyle+"'") ;
         context.WriteHtmlText( FormProcess+">") ;
         context.skipLines(1);
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" autocomplete=\"off\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("xt_config.aspx") + "?" + UrlEncode(StringUtil.RTrim(Gx_mode)) + "," + UrlEncode("" +AV7XT_ConfigID)+"\">") ;
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
         forbiddenHiddens = "hsh" + "XT_Config";
         forbiddenHiddens = forbiddenHiddens + context.localUtil.Format( (decimal)(A195XT_ConfigID), "ZZZZZZZZZZZZZZZZZZ");
         forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!"));
         GxWebStd.gx_hidden_field( context, "hsh", GetEncryptedHash( forbiddenHiddens, GXKey));
         GXUtil.WriteLog("xt_config:[SendSecurityCheck value for]"+"XT_ConfigID:"+context.localUtil.Format( (decimal)(A195XT_ConfigID), "ZZZZZZZZZZZZZZZZZZ"));
         GXUtil.WriteLog("xt_config:[SendSecurityCheck value for]"+"Gx_mode:"+StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")));
      }

      protected void SendCloseFormHiddens( )
      {
         /* Send hidden variables. */
         /* Send saved values. */
         send_integrity_footer_hashes( ) ;
         GxWebStd.gx_hidden_field( context, "Z195XT_ConfigID", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z195XT_ConfigID), 18, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "Z196XT_ConfigKey", Z196XT_ConfigKey);
         GxWebStd.gx_hidden_field( context, "Z197XT_ConfigValue1", Z197XT_ConfigValue1);
         GxWebStd.gx_hidden_field( context, "Z198XT_ConfigValue2", Z198XT_ConfigValue2);
         GxWebStd.gx_hidden_field( context, "Z199XT_ConfigValue3", Z199XT_ConfigValue3);
         GxWebStd.gx_hidden_field( context, "Z200XT_ConfigValue4", Z200XT_ConfigValue4);
         GxWebStd.gx_hidden_field( context, "Z201XT_ConfigValue5", Z201XT_ConfigValue5);
         GxWebStd.gx_hidden_field( context, "IsConfirmed", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsConfirmed), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "IsModified", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsModified), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "Mode", StringUtil.RTrim( Gx_mode));
         GxWebStd.gx_hidden_field( context, "gxhash_Mode", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vTRNCONTEXT", AV11TrnContext);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vTRNCONTEXT", AV11TrnContext);
         }
         GxWebStd.gx_hidden_field( context, "vXT_CONFIGID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV7XT_ConfigID), 18, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "gxhash_vXT_CONFIGID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV7XT_ConfigID), "ZZZZZZZZZZZZZZZZZZ"), context));
         GxWebStd.gx_hidden_field( context, "vPGMNAME", StringUtil.RTrim( AV13Pgmname));
         GxWebStd.gx_hidden_field( context, "vMODE", StringUtil.RTrim( Gx_mode));
         GxWebStd.gx_hidden_field( context, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         GxWebStd.gx_hidden_field( context, "DVPANEL_TABLEATTRIBUTES_Objectcall", StringUtil.RTrim( Dvpanel_tableattributes_Objectcall));
         GxWebStd.gx_hidden_field( context, "DVPANEL_TABLEATTRIBUTES_Enabled", StringUtil.BoolToStr( Dvpanel_tableattributes_Enabled));
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
         SendSecurityToken(sPrefix);
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

      public override short ExecuteStartEvent( )
      {
         standaloneStartup( ) ;
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0));
         return gxajaxcallmode ;
      }

      public override void RenderHtmlContent( )
      {
         context.WriteHtmlText( "<div") ;
         GxWebStd.ClassAttribute( context, "gx-ct-body"+" "+(String.IsNullOrEmpty(StringUtil.RTrim( Form.Class)) ? "form-horizontal Form" : Form.Class)+"-fx");
         context.WriteHtmlText( ">") ;
         Draw( ) ;
         context.WriteHtmlText( "</div>") ;
      }

      public override void DispatchEvents( )
      {
         Process( ) ;
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
         return formatLink("xt_config.aspx") + "?" + UrlEncode(StringUtil.RTrim(Gx_mode)) + "," + UrlEncode("" +AV7XT_ConfigID) ;
      }

      public override String GetPgmname( )
      {
         return "XT_Config" ;
      }

      public override String GetPgmdesc( )
      {
         return "系统配置表" ;
      }

      protected void InitializeNonKey0Q27( )
      {
         A196XT_ConfigKey = "";
         n196XT_ConfigKey = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A196XT_ConfigKey", A196XT_ConfigKey);
         n196XT_ConfigKey = (String.IsNullOrEmpty(StringUtil.RTrim( A196XT_ConfigKey)) ? true : false);
         A197XT_ConfigValue1 = "";
         n197XT_ConfigValue1 = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A197XT_ConfigValue1", A197XT_ConfigValue1);
         n197XT_ConfigValue1 = (String.IsNullOrEmpty(StringUtil.RTrim( A197XT_ConfigValue1)) ? true : false);
         A198XT_ConfigValue2 = "";
         n198XT_ConfigValue2 = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A198XT_ConfigValue2", A198XT_ConfigValue2);
         n198XT_ConfigValue2 = (String.IsNullOrEmpty(StringUtil.RTrim( A198XT_ConfigValue2)) ? true : false);
         A199XT_ConfigValue3 = "";
         n199XT_ConfigValue3 = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A199XT_ConfigValue3", A199XT_ConfigValue3);
         n199XT_ConfigValue3 = (String.IsNullOrEmpty(StringUtil.RTrim( A199XT_ConfigValue3)) ? true : false);
         A200XT_ConfigValue4 = "";
         n200XT_ConfigValue4 = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A200XT_ConfigValue4", A200XT_ConfigValue4);
         n200XT_ConfigValue4 = (String.IsNullOrEmpty(StringUtil.RTrim( A200XT_ConfigValue4)) ? true : false);
         A201XT_ConfigValue5 = "";
         n201XT_ConfigValue5 = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A201XT_ConfigValue5", A201XT_ConfigValue5);
         n201XT_ConfigValue5 = (String.IsNullOrEmpty(StringUtil.RTrim( A201XT_ConfigValue5)) ? true : false);
         Z196XT_ConfigKey = "";
         Z197XT_ConfigValue1 = "";
         Z198XT_ConfigValue2 = "";
         Z199XT_ConfigValue3 = "";
         Z200XT_ConfigValue4 = "";
         Z201XT_ConfigValue5 = "";
      }

      protected void InitAll0Q27( )
      {
         A195XT_ConfigID = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A195XT_ConfigID", StringUtil.LTrim( StringUtil.Str( (decimal)(A195XT_ConfigID), 18, 0)));
         InitializeNonKey0Q27( ) ;
      }

      protected void StandaloneModalInsert( )
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
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?20202279372537", true);
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
         context.AddJavascriptSource("xt_config.js", "?20202279372538", false);
         context.AddJavascriptSource("DVelop/Bootstrap/Shared/DVelopBootstrap.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/Panel/BootstrapPanelRender.js", "", false);
         /* End function include_jscripts */
      }

      protected void init_default_properties( )
      {
         edtXT_ConfigKey_Internalname = "XT_CONFIGKEY";
         edtXT_ConfigValue1_Internalname = "XT_CONFIGVALUE1";
         edtXT_ConfigValue2_Internalname = "XT_CONFIGVALUE2";
         edtXT_ConfigValue3_Internalname = "XT_CONFIGVALUE3";
         edtXT_ConfigValue4_Internalname = "XT_CONFIGVALUE4";
         edtXT_ConfigValue5_Internalname = "XT_CONFIGVALUE5";
         divTableattributes_Internalname = "TABLEATTRIBUTES";
         divLayout_tableattributes_Internalname = "LAYOUT_TABLEATTRIBUTES";
         Dvpanel_tableattributes_Internalname = "DVPANEL_TABLEATTRIBUTES";
         divHtml_dvpanel_tableattributes_Internalname = "HTML_DVPANEL_TABLEATTRIBUTES";
         divTablecontent_Internalname = "TABLECONTENT";
         bttBtntrn_enter_Internalname = "BTNTRN_ENTER";
         bttBtntrn_cancel_Internalname = "BTNTRN_CANCEL";
         bttBtntrn_delete_Internalname = "BTNTRN_DELETE";
         divTablemain_Internalname = "TABLEMAIN";
         edtXT_ConfigID_Internalname = "XT_CONFIGID";
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
         Form.Headerrawhtml = "";
         Form.Background = "";
         Form.Textcolor = 0;
         Form.Backcolor = (int)(0xFFFFFF);
         Form.Caption = "系统配置表";
         edtXT_ConfigID_Jsonclick = "";
         edtXT_ConfigID_Enabled = 0;
         edtXT_ConfigID_Visible = 1;
         bttBtntrn_delete_Enabled = 0;
         bttBtntrn_delete_Visible = 1;
         bttBtntrn_cancel_Visible = 1;
         bttBtntrn_enter_Enabled = 1;
         bttBtntrn_enter_Visible = 1;
         edtXT_ConfigValue5_Enabled = 1;
         edtXT_ConfigValue4_Enabled = 1;
         edtXT_ConfigValue3_Enabled = 1;
         edtXT_ConfigValue2_Enabled = 1;
         edtXT_ConfigValue1_Enabled = 1;
         edtXT_ConfigKey_Jsonclick = "";
         edtXT_ConfigKey_Enabled = 1;
         Dvpanel_tableattributes_Autoscroll = Convert.ToBoolean( 0);
         Dvpanel_tableattributes_Iconposition = "left";
         Dvpanel_tableattributes_Showcollapseicon = Convert.ToBoolean( 0);
         Dvpanel_tableattributes_Collapsed = Convert.ToBoolean( 0);
         Dvpanel_tableattributes_Collapsible = Convert.ToBoolean( 0);
         Dvpanel_tableattributes_Title = "基础信息";
         Dvpanel_tableattributes_Cls = "PanelCard_BaseColor";
         Dvpanel_tableattributes_Autoheight = Convert.ToBoolean( -1);
         Dvpanel_tableattributes_Autowidth = Convert.ToBoolean( 0);
         Dvpanel_tableattributes_Width = "100%";
         context.GX_msglist.DisplayMode = 1;
         if ( context.isSpaRequest( ) )
         {
            enableJsOutput();
         }
      }

      protected void dynload_actions( )
      {
         /* End function dynload_actions */
      }

      protected void init_web_controls( )
      {
         /* End function init_web_controls */
      }

      public override bool SupportAjaxEvent( )
      {
         return true ;
      }

      public override void InitializeDynEvents( )
      {
         setEventMetadata("ENTER","{handler:'UserMainFullajax',iparms:[{postForm:true},{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV7XT_ConfigID',fld:'vXT_CONFIGID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true}]");
         setEventMetadata("ENTER",",oparms:[]}");
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV7XT_ConfigID',fld:'vXT_CONFIGID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true},{av:'A195XT_ConfigID',fld:'XT_CONFIGID',pic:'ZZZZZZZZZZZZZZZZZZ'}]");
         setEventMetadata("REFRESH",",oparms:[]}");
         setEventMetadata("AFTER TRN","{handler:'E120Q2',iparms:[{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV11TrnContext',fld:'vTRNCONTEXT',pic:''}]");
         setEventMetadata("AFTER TRN",",oparms:[]}");
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
         pr_default.close(1);
      }

      public override void initialize( )
      {
         sPrefix = "";
         wcpOGx_mode = "";
         Z196XT_ConfigKey = "";
         Z197XT_ConfigValue1 = "";
         Z198XT_ConfigValue2 = "";
         Z199XT_ConfigValue3 = "";
         Z200XT_ConfigValue4 = "";
         Z201XT_ConfigValue5 = "";
         scmdbuf = "";
         gxfirstwebparm = "";
         gxfirstwebparm_bkp = "";
         GXKey = "";
         PreviousTooltip = "";
         PreviousCaption = "";
         Form = new GXWebForm();
         GX_FocusControl = "";
         ClassString = "";
         StyleString = "";
         ucDvpanel_tableattributes = new GXUserControl();
         TempTags = "";
         A196XT_ConfigKey = "";
         A197XT_ConfigValue1 = "";
         A198XT_ConfigValue2 = "";
         A199XT_ConfigValue3 = "";
         A200XT_ConfigValue4 = "";
         A201XT_ConfigValue5 = "";
         bttBtntrn_enter_Jsonclick = "";
         bttBtntrn_cancel_Jsonclick = "";
         bttBtntrn_delete_Jsonclick = "";
         AV13Pgmname = "";
         Dvpanel_tableattributes_Objectcall = "";
         Dvpanel_tableattributes_Class = "";
         Dvpanel_tableattributes_Height = "";
         forbiddenHiddens = "";
         hsh = "";
         sMode27 = "";
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         AV8WWPContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPContext(context);
         AV11TrnContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext(context);
         AV12WebSession = context.GetSession();
         T000Q4_A195XT_ConfigID = new long[1] ;
         T000Q4_A196XT_ConfigKey = new String[] {""} ;
         T000Q4_n196XT_ConfigKey = new bool[] {false} ;
         T000Q4_A197XT_ConfigValue1 = new String[] {""} ;
         T000Q4_n197XT_ConfigValue1 = new bool[] {false} ;
         T000Q4_A198XT_ConfigValue2 = new String[] {""} ;
         T000Q4_n198XT_ConfigValue2 = new bool[] {false} ;
         T000Q4_A199XT_ConfigValue3 = new String[] {""} ;
         T000Q4_n199XT_ConfigValue3 = new bool[] {false} ;
         T000Q4_A200XT_ConfigValue4 = new String[] {""} ;
         T000Q4_n200XT_ConfigValue4 = new bool[] {false} ;
         T000Q4_A201XT_ConfigValue5 = new String[] {""} ;
         T000Q4_n201XT_ConfigValue5 = new bool[] {false} ;
         T000Q5_A195XT_ConfigID = new long[1] ;
         T000Q3_A195XT_ConfigID = new long[1] ;
         T000Q3_A196XT_ConfigKey = new String[] {""} ;
         T000Q3_n196XT_ConfigKey = new bool[] {false} ;
         T000Q3_A197XT_ConfigValue1 = new String[] {""} ;
         T000Q3_n197XT_ConfigValue1 = new bool[] {false} ;
         T000Q3_A198XT_ConfigValue2 = new String[] {""} ;
         T000Q3_n198XT_ConfigValue2 = new bool[] {false} ;
         T000Q3_A199XT_ConfigValue3 = new String[] {""} ;
         T000Q3_n199XT_ConfigValue3 = new bool[] {false} ;
         T000Q3_A200XT_ConfigValue4 = new String[] {""} ;
         T000Q3_n200XT_ConfigValue4 = new bool[] {false} ;
         T000Q3_A201XT_ConfigValue5 = new String[] {""} ;
         T000Q3_n201XT_ConfigValue5 = new bool[] {false} ;
         T000Q6_A195XT_ConfigID = new long[1] ;
         T000Q7_A195XT_ConfigID = new long[1] ;
         T000Q2_A195XT_ConfigID = new long[1] ;
         T000Q2_A196XT_ConfigKey = new String[] {""} ;
         T000Q2_n196XT_ConfigKey = new bool[] {false} ;
         T000Q2_A197XT_ConfigValue1 = new String[] {""} ;
         T000Q2_n197XT_ConfigValue1 = new bool[] {false} ;
         T000Q2_A198XT_ConfigValue2 = new String[] {""} ;
         T000Q2_n198XT_ConfigValue2 = new bool[] {false} ;
         T000Q2_A199XT_ConfigValue3 = new String[] {""} ;
         T000Q2_n199XT_ConfigValue3 = new bool[] {false} ;
         T000Q2_A200XT_ConfigValue4 = new String[] {""} ;
         T000Q2_n200XT_ConfigValue4 = new bool[] {false} ;
         T000Q2_A201XT_ConfigValue5 = new String[] {""} ;
         T000Q2_n201XT_ConfigValue5 = new bool[] {false} ;
         T000Q8_A195XT_ConfigID = new long[1] ;
         T000Q11_A195XT_ConfigID = new long[1] ;
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         pr_datastore1 = new DataStoreProvider(context, new GeneXus.Programs.xt_config__datastore1(),
            new Object[][] {
            }
         );
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.xt_config__default(),
            new Object[][] {
                new Object[] {
               T000Q2_A195XT_ConfigID, T000Q2_A196XT_ConfigKey, T000Q2_n196XT_ConfigKey, T000Q2_A197XT_ConfigValue1, T000Q2_n197XT_ConfigValue1, T000Q2_A198XT_ConfigValue2, T000Q2_n198XT_ConfigValue2, T000Q2_A199XT_ConfigValue3, T000Q2_n199XT_ConfigValue3, T000Q2_A200XT_ConfigValue4,
               T000Q2_n200XT_ConfigValue4, T000Q2_A201XT_ConfigValue5, T000Q2_n201XT_ConfigValue5
               }
               , new Object[] {
               T000Q3_A195XT_ConfigID, T000Q3_A196XT_ConfigKey, T000Q3_n196XT_ConfigKey, T000Q3_A197XT_ConfigValue1, T000Q3_n197XT_ConfigValue1, T000Q3_A198XT_ConfigValue2, T000Q3_n198XT_ConfigValue2, T000Q3_A199XT_ConfigValue3, T000Q3_n199XT_ConfigValue3, T000Q3_A200XT_ConfigValue4,
               T000Q3_n200XT_ConfigValue4, T000Q3_A201XT_ConfigValue5, T000Q3_n201XT_ConfigValue5
               }
               , new Object[] {
               T000Q4_A195XT_ConfigID, T000Q4_A196XT_ConfigKey, T000Q4_n196XT_ConfigKey, T000Q4_A197XT_ConfigValue1, T000Q4_n197XT_ConfigValue1, T000Q4_A198XT_ConfigValue2, T000Q4_n198XT_ConfigValue2, T000Q4_A199XT_ConfigValue3, T000Q4_n199XT_ConfigValue3, T000Q4_A200XT_ConfigValue4,
               T000Q4_n200XT_ConfigValue4, T000Q4_A201XT_ConfigValue5, T000Q4_n201XT_ConfigValue5
               }
               , new Object[] {
               T000Q5_A195XT_ConfigID
               }
               , new Object[] {
               T000Q6_A195XT_ConfigID
               }
               , new Object[] {
               T000Q7_A195XT_ConfigID
               }
               , new Object[] {
               T000Q8_A195XT_ConfigID
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               T000Q11_A195XT_ConfigID
               }
            }
         );
         AV13Pgmname = "XT_Config";
      }

      private short GxWebError ;
      private short gxcookieaux ;
      private short IsConfirmed ;
      private short IsModified ;
      private short AnyError ;
      private short nKeyPressed ;
      private short initialized ;
      private short RcdFound27 ;
      private short GX_JID ;
      private short Gx_BScreen ;
      private short gxajaxcallmode ;
      private int trnEnded ;
      private int edtXT_ConfigKey_Enabled ;
      private int edtXT_ConfigValue1_Enabled ;
      private int edtXT_ConfigValue2_Enabled ;
      private int edtXT_ConfigValue3_Enabled ;
      private int edtXT_ConfigValue4_Enabled ;
      private int edtXT_ConfigValue5_Enabled ;
      private int bttBtntrn_enter_Visible ;
      private int bttBtntrn_enter_Enabled ;
      private int bttBtntrn_cancel_Visible ;
      private int bttBtntrn_delete_Visible ;
      private int bttBtntrn_delete_Enabled ;
      private int edtXT_ConfigID_Enabled ;
      private int edtXT_ConfigID_Visible ;
      private int idxLst ;
      private long wcpOAV7XT_ConfigID ;
      private long Z195XT_ConfigID ;
      private long AV7XT_ConfigID ;
      private long A195XT_ConfigID ;
      private String sPrefix ;
      private String wcpOGx_mode ;
      private String scmdbuf ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String Gx_mode ;
      private String GXKey ;
      private String PreviousTooltip ;
      private String PreviousCaption ;
      private String GX_FocusControl ;
      private String edtXT_ConfigKey_Internalname ;
      private String divLayoutmaintable_Internalname ;
      private String divTablemain_Internalname ;
      private String ClassString ;
      private String StyleString ;
      private String divTablecontent_Internalname ;
      private String divHtml_dvpanel_tableattributes_Internalname ;
      private String Dvpanel_tableattributes_Width ;
      private String Dvpanel_tableattributes_Cls ;
      private String Dvpanel_tableattributes_Title ;
      private String Dvpanel_tableattributes_Iconposition ;
      private String Dvpanel_tableattributes_Internalname ;
      private String divLayout_tableattributes_Internalname ;
      private String divTableattributes_Internalname ;
      private String TempTags ;
      private String edtXT_ConfigKey_Jsonclick ;
      private String edtXT_ConfigValue1_Internalname ;
      private String edtXT_ConfigValue2_Internalname ;
      private String edtXT_ConfigValue3_Internalname ;
      private String edtXT_ConfigValue4_Internalname ;
      private String edtXT_ConfigValue5_Internalname ;
      private String bttBtntrn_enter_Internalname ;
      private String bttBtntrn_enter_Jsonclick ;
      private String bttBtntrn_cancel_Internalname ;
      private String bttBtntrn_cancel_Jsonclick ;
      private String bttBtntrn_delete_Internalname ;
      private String bttBtntrn_delete_Jsonclick ;
      private String divHtml_bottomauxiliarcontrols_Internalname ;
      private String edtXT_ConfigID_Internalname ;
      private String edtXT_ConfigID_Jsonclick ;
      private String AV13Pgmname ;
      private String Dvpanel_tableattributes_Objectcall ;
      private String Dvpanel_tableattributes_Class ;
      private String Dvpanel_tableattributes_Height ;
      private String forbiddenHiddens ;
      private String hsh ;
      private String sMode27 ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String sDynURL ;
      private String FormProcess ;
      private String bodyStyle ;
      private bool entryPointCalled ;
      private bool toggleJsOutput ;
      private bool wbErr ;
      private bool Dvpanel_tableattributes_Autowidth ;
      private bool Dvpanel_tableattributes_Autoheight ;
      private bool Dvpanel_tableattributes_Collapsible ;
      private bool Dvpanel_tableattributes_Collapsed ;
      private bool Dvpanel_tableattributes_Showcollapseicon ;
      private bool Dvpanel_tableattributes_Autoscroll ;
      private bool n196XT_ConfigKey ;
      private bool n197XT_ConfigValue1 ;
      private bool n198XT_ConfigValue2 ;
      private bool n199XT_ConfigValue3 ;
      private bool n200XT_ConfigValue4 ;
      private bool n201XT_ConfigValue5 ;
      private bool Dvpanel_tableattributes_Enabled ;
      private bool Dvpanel_tableattributes_Showheader ;
      private bool Dvpanel_tableattributes_Visible ;
      private bool AV9IsAuthorized ;
      private bool GXt_boolean1 ;
      private bool returnInSub ;
      private bool Gx_longc ;
      private String Z196XT_ConfigKey ;
      private String Z197XT_ConfigValue1 ;
      private String Z198XT_ConfigValue2 ;
      private String Z199XT_ConfigValue3 ;
      private String Z200XT_ConfigValue4 ;
      private String Z201XT_ConfigValue5 ;
      private String A196XT_ConfigKey ;
      private String A197XT_ConfigValue1 ;
      private String A198XT_ConfigValue2 ;
      private String A199XT_ConfigValue3 ;
      private String A200XT_ConfigValue4 ;
      private String A201XT_ConfigValue5 ;
      private IGxSession AV12WebSession ;
      private GXUserControl ucDvpanel_tableattributes ;
      private IGxDataStore dsDataStore1 ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private long[] T000Q4_A195XT_ConfigID ;
      private String[] T000Q4_A196XT_ConfigKey ;
      private bool[] T000Q4_n196XT_ConfigKey ;
      private String[] T000Q4_A197XT_ConfigValue1 ;
      private bool[] T000Q4_n197XT_ConfigValue1 ;
      private String[] T000Q4_A198XT_ConfigValue2 ;
      private bool[] T000Q4_n198XT_ConfigValue2 ;
      private String[] T000Q4_A199XT_ConfigValue3 ;
      private bool[] T000Q4_n199XT_ConfigValue3 ;
      private String[] T000Q4_A200XT_ConfigValue4 ;
      private bool[] T000Q4_n200XT_ConfigValue4 ;
      private String[] T000Q4_A201XT_ConfigValue5 ;
      private bool[] T000Q4_n201XT_ConfigValue5 ;
      private long[] T000Q5_A195XT_ConfigID ;
      private long[] T000Q3_A195XT_ConfigID ;
      private String[] T000Q3_A196XT_ConfigKey ;
      private bool[] T000Q3_n196XT_ConfigKey ;
      private String[] T000Q3_A197XT_ConfigValue1 ;
      private bool[] T000Q3_n197XT_ConfigValue1 ;
      private String[] T000Q3_A198XT_ConfigValue2 ;
      private bool[] T000Q3_n198XT_ConfigValue2 ;
      private String[] T000Q3_A199XT_ConfigValue3 ;
      private bool[] T000Q3_n199XT_ConfigValue3 ;
      private String[] T000Q3_A200XT_ConfigValue4 ;
      private bool[] T000Q3_n200XT_ConfigValue4 ;
      private String[] T000Q3_A201XT_ConfigValue5 ;
      private bool[] T000Q3_n201XT_ConfigValue5 ;
      private long[] T000Q6_A195XT_ConfigID ;
      private long[] T000Q7_A195XT_ConfigID ;
      private long[] T000Q2_A195XT_ConfigID ;
      private String[] T000Q2_A196XT_ConfigKey ;
      private bool[] T000Q2_n196XT_ConfigKey ;
      private String[] T000Q2_A197XT_ConfigValue1 ;
      private bool[] T000Q2_n197XT_ConfigValue1 ;
      private String[] T000Q2_A198XT_ConfigValue2 ;
      private bool[] T000Q2_n198XT_ConfigValue2 ;
      private String[] T000Q2_A199XT_ConfigValue3 ;
      private bool[] T000Q2_n199XT_ConfigValue3 ;
      private String[] T000Q2_A200XT_ConfigValue4 ;
      private bool[] T000Q2_n200XT_ConfigValue4 ;
      private String[] T000Q2_A201XT_ConfigValue5 ;
      private bool[] T000Q2_n201XT_ConfigValue5 ;
      private long[] T000Q8_A195XT_ConfigID ;
      private long[] T000Q11_A195XT_ConfigID ;
      private IDataStoreProvider pr_datastore1 ;
      private GXWebForm Form ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPContext AV8WWPContext ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext AV11TrnContext ;
   }

   public class xt_config__datastore1 : DataStoreHelperBase, IDataStoreHelper
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

 public class xt_config__default : DataStoreHelperBase, IDataStoreHelper
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
       ,new UpdateCursor(def[7])
       ,new UpdateCursor(def[8])
       ,new ForEachCursor(def[9])
     };
  }

  private static CursorDef[] def;
  private void cursorDefinitions( )
  {
     if ( def == null )
     {
        Object[] prmT000Q4 ;
        prmT000Q4 = new Object[] {
        new Object[] {"@XT_ConfigID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000Q5 ;
        prmT000Q5 = new Object[] {
        new Object[] {"@XT_ConfigID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000Q3 ;
        prmT000Q3 = new Object[] {
        new Object[] {"@XT_ConfigID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000Q6 ;
        prmT000Q6 = new Object[] {
        new Object[] {"@XT_ConfigID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000Q7 ;
        prmT000Q7 = new Object[] {
        new Object[] {"@XT_ConfigID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000Q2 ;
        prmT000Q2 = new Object[] {
        new Object[] {"@XT_ConfigID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000Q8 ;
        prmT000Q8 = new Object[] {
        new Object[] {"@XT_ConfigKey",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@XT_ConfigValue1",SqlDbType.NVarChar,200,0} ,
        new Object[] {"@XT_ConfigValue2",SqlDbType.NVarChar,200,0} ,
        new Object[] {"@XT_ConfigValue3",SqlDbType.NVarChar,200,0} ,
        new Object[] {"@XT_ConfigValue4",SqlDbType.NVarChar,200,0} ,
        new Object[] {"@XT_ConfigValue5",SqlDbType.NVarChar,200,0}
        } ;
        Object[] prmT000Q9 ;
        prmT000Q9 = new Object[] {
        new Object[] {"@XT_ConfigKey",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@XT_ConfigValue1",SqlDbType.NVarChar,200,0} ,
        new Object[] {"@XT_ConfigValue2",SqlDbType.NVarChar,200,0} ,
        new Object[] {"@XT_ConfigValue3",SqlDbType.NVarChar,200,0} ,
        new Object[] {"@XT_ConfigValue4",SqlDbType.NVarChar,200,0} ,
        new Object[] {"@XT_ConfigValue5",SqlDbType.NVarChar,200,0} ,
        new Object[] {"@XT_ConfigID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000Q10 ;
        prmT000Q10 = new Object[] {
        new Object[] {"@XT_ConfigID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000Q11 ;
        prmT000Q11 = new Object[] {
        } ;
        def= new CursorDef[] {
            new CursorDef("T000Q2", "SELECT [XT_ConfigID], [XT_ConfigKey], [XT_ConfigValue1], [XT_ConfigValue2], [XT_ConfigValue3], [XT_ConfigValue4], [XT_ConfigValue5] FROM [XT_Config] WITH (UPDLOCK) WHERE [XT_ConfigID] = @XT_ConfigID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000Q2,1,0,true,false )
           ,new CursorDef("T000Q3", "SELECT [XT_ConfigID], [XT_ConfigKey], [XT_ConfigValue1], [XT_ConfigValue2], [XT_ConfigValue3], [XT_ConfigValue4], [XT_ConfigValue5] FROM [XT_Config] WITH (NOLOCK) WHERE [XT_ConfigID] = @XT_ConfigID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000Q3,1,0,true,false )
           ,new CursorDef("T000Q4", "SELECT TM1.[XT_ConfigID], TM1.[XT_ConfigKey], TM1.[XT_ConfigValue1], TM1.[XT_ConfigValue2], TM1.[XT_ConfigValue3], TM1.[XT_ConfigValue4], TM1.[XT_ConfigValue5] FROM [XT_Config] TM1 WITH (NOLOCK) WHERE TM1.[XT_ConfigID] = @XT_ConfigID ORDER BY TM1.[XT_ConfigID]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT000Q4,100,0,true,false )
           ,new CursorDef("T000Q5", "SELECT [XT_ConfigID] FROM [XT_Config] WITH (NOLOCK) WHERE [XT_ConfigID] = @XT_ConfigID  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000Q5,1,0,true,false )
           ,new CursorDef("T000Q6", "SELECT TOP 1 [XT_ConfigID] FROM [XT_Config] WITH (NOLOCK) WHERE ( [XT_ConfigID] > @XT_ConfigID) ORDER BY [XT_ConfigID]  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000Q6,1,0,true,true )
           ,new CursorDef("T000Q7", "SELECT TOP 1 [XT_ConfigID] FROM [XT_Config] WITH (NOLOCK) WHERE ( [XT_ConfigID] < @XT_ConfigID) ORDER BY [XT_ConfigID] DESC  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000Q7,1,0,true,true )
           ,new CursorDef("T000Q8", "INSERT INTO [XT_Config]([XT_ConfigKey], [XT_ConfigValue1], [XT_ConfigValue2], [XT_ConfigValue3], [XT_ConfigValue4], [XT_ConfigValue5]) VALUES(@XT_ConfigKey, @XT_ConfigValue1, @XT_ConfigValue2, @XT_ConfigValue3, @XT_ConfigValue4, @XT_ConfigValue5); SELECT SCOPE_IDENTITY()", GxErrorMask.GX_NOMASK,prmT000Q8)
           ,new CursorDef("T000Q9", "UPDATE [XT_Config] SET [XT_ConfigKey]=@XT_ConfigKey, [XT_ConfigValue1]=@XT_ConfigValue1, [XT_ConfigValue2]=@XT_ConfigValue2, [XT_ConfigValue3]=@XT_ConfigValue3, [XT_ConfigValue4]=@XT_ConfigValue4, [XT_ConfigValue5]=@XT_ConfigValue5  WHERE [XT_ConfigID] = @XT_ConfigID", GxErrorMask.GX_NOMASK,prmT000Q9)
           ,new CursorDef("T000Q10", "DELETE FROM [XT_Config]  WHERE [XT_ConfigID] = @XT_ConfigID", GxErrorMask.GX_NOMASK,prmT000Q10)
           ,new CursorDef("T000Q11", "SELECT [XT_ConfigID] FROM [XT_Config] WITH (NOLOCK) ORDER BY [XT_ConfigID]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT000Q11,100,0,true,false )
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
              ((String[]) buf[3])[0] = rslt.getVarchar(3) ;
              ((bool[]) buf[4])[0] = rslt.wasNull(3);
              ((String[]) buf[5])[0] = rslt.getVarchar(4) ;
              ((bool[]) buf[6])[0] = rslt.wasNull(4);
              ((String[]) buf[7])[0] = rslt.getVarchar(5) ;
              ((bool[]) buf[8])[0] = rslt.wasNull(5);
              ((String[]) buf[9])[0] = rslt.getVarchar(6) ;
              ((bool[]) buf[10])[0] = rslt.wasNull(6);
              ((String[]) buf[11])[0] = rslt.getVarchar(7) ;
              ((bool[]) buf[12])[0] = rslt.wasNull(7);
              return;
           case 1 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
              ((bool[]) buf[2])[0] = rslt.wasNull(2);
              ((String[]) buf[3])[0] = rslt.getVarchar(3) ;
              ((bool[]) buf[4])[0] = rslt.wasNull(3);
              ((String[]) buf[5])[0] = rslt.getVarchar(4) ;
              ((bool[]) buf[6])[0] = rslt.wasNull(4);
              ((String[]) buf[7])[0] = rslt.getVarchar(5) ;
              ((bool[]) buf[8])[0] = rslt.wasNull(5);
              ((String[]) buf[9])[0] = rslt.getVarchar(6) ;
              ((bool[]) buf[10])[0] = rslt.wasNull(6);
              ((String[]) buf[11])[0] = rslt.getVarchar(7) ;
              ((bool[]) buf[12])[0] = rslt.wasNull(7);
              return;
           case 2 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
              ((bool[]) buf[2])[0] = rslt.wasNull(2);
              ((String[]) buf[3])[0] = rslt.getVarchar(3) ;
              ((bool[]) buf[4])[0] = rslt.wasNull(3);
              ((String[]) buf[5])[0] = rslt.getVarchar(4) ;
              ((bool[]) buf[6])[0] = rslt.wasNull(4);
              ((String[]) buf[7])[0] = rslt.getVarchar(5) ;
              ((bool[]) buf[8])[0] = rslt.wasNull(5);
              ((String[]) buf[9])[0] = rslt.getVarchar(6) ;
              ((bool[]) buf[10])[0] = rslt.wasNull(6);
              ((String[]) buf[11])[0] = rslt.getVarchar(7) ;
              ((bool[]) buf[12])[0] = rslt.wasNull(7);
              return;
           case 3 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              return;
           case 4 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              return;
           case 5 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              return;
           case 6 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              return;
           case 9 :
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
           case 2 :
              stmt.SetParameter(1, (long)parms[0]);
              return;
           case 3 :
              stmt.SetParameter(1, (long)parms[0]);
              return;
           case 4 :
              stmt.SetParameter(1, (long)parms[0]);
              return;
           case 5 :
              stmt.SetParameter(1, (long)parms[0]);
              return;
           case 6 :
              if ( (bool)parms[0] )
              {
                 stmt.setNull( 1 , SqlDbType.NVarChar );
              }
              else
              {
                 stmt.SetParameter(1, (String)parms[1]);
              }
              if ( (bool)parms[2] )
              {
                 stmt.setNull( 2 , SqlDbType.NVarChar );
              }
              else
              {
                 stmt.SetParameter(2, (String)parms[3]);
              }
              if ( (bool)parms[4] )
              {
                 stmt.setNull( 3 , SqlDbType.NVarChar );
              }
              else
              {
                 stmt.SetParameter(3, (String)parms[5]);
              }
              if ( (bool)parms[6] )
              {
                 stmt.setNull( 4 , SqlDbType.NVarChar );
              }
              else
              {
                 stmt.SetParameter(4, (String)parms[7]);
              }
              if ( (bool)parms[8] )
              {
                 stmt.setNull( 5 , SqlDbType.NVarChar );
              }
              else
              {
                 stmt.SetParameter(5, (String)parms[9]);
              }
              if ( (bool)parms[10] )
              {
                 stmt.setNull( 6 , SqlDbType.NVarChar );
              }
              else
              {
                 stmt.SetParameter(6, (String)parms[11]);
              }
              return;
           case 7 :
              if ( (bool)parms[0] )
              {
                 stmt.setNull( 1 , SqlDbType.NVarChar );
              }
              else
              {
                 stmt.SetParameter(1, (String)parms[1]);
              }
              if ( (bool)parms[2] )
              {
                 stmt.setNull( 2 , SqlDbType.NVarChar );
              }
              else
              {
                 stmt.SetParameter(2, (String)parms[3]);
              }
              if ( (bool)parms[4] )
              {
                 stmt.setNull( 3 , SqlDbType.NVarChar );
              }
              else
              {
                 stmt.SetParameter(3, (String)parms[5]);
              }
              if ( (bool)parms[6] )
              {
                 stmt.setNull( 4 , SqlDbType.NVarChar );
              }
              else
              {
                 stmt.SetParameter(4, (String)parms[7]);
              }
              if ( (bool)parms[8] )
              {
                 stmt.setNull( 5 , SqlDbType.NVarChar );
              }
              else
              {
                 stmt.SetParameter(5, (String)parms[9]);
              }
              if ( (bool)parms[10] )
              {
                 stmt.setNull( 6 , SqlDbType.NVarChar );
              }
              else
              {
                 stmt.SetParameter(6, (String)parms[11]);
              }
              stmt.SetParameter(7, (long)parms[12]);
              return;
           case 8 :
              stmt.SetParameter(1, (long)parms[0]);
              return;
     }
  }

}

}
