/*
               File: XT_Log
        Description: 系统日志
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/27/2020 9:37:22.2
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
   public class xt_log : GXDataArea, System.Web.SessionState.IRequiresSessionState
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
               AV7XT_LogID = (long)(NumberUtil.Val( GetNextPar( ), "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7XT_LogID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV7XT_LogID), 18, 0)));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vXT_LOGID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV7XT_LogID), "ZZZZZZZZZZZZZZZZZZ"), context));
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
            Form.Meta.addItem("description", "系统日志", 0) ;
         }
         context.wjLoc = "";
         context.nUserReturn = 0;
         context.wbHandled = 0;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         GX_FocusControl = edtXT_LogSecUserName_Internalname;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         wbErr = false;
         context.SetDefaultTheme("WorkWithPlusTheme");
         if ( ! context.IsLocalStorageSupported( ) )
         {
            context.PushCurrentUrl();
         }
      }

      public xt_log( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public xt_log( IGxContext context )
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
                           long aP1_XT_LogID )
      {
         this.Gx_mode = aP0_Gx_mode;
         this.AV7XT_LogID = aP1_XT_LogID;
         executePrivate();
      }

      void executePrivate( )
      {
         isStatic = false;
         webExecute();
      }

      protected override void createObjects( )
      {
         cmbXT_LogTargetOperate = new GXCombobox();
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
         if ( cmbXT_LogTargetOperate.ItemCount > 0 )
         {
            A218XT_LogTargetOperate = cmbXT_LogTargetOperate.getValidValue(A218XT_LogTargetOperate);
            n218XT_LogTargetOperate = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A218XT_LogTargetOperate", A218XT_LogTargetOperate);
         }
         if ( context.isAjaxRequest( ) )
         {
            cmbXT_LogTargetOperate.CurrentValue = StringUtil.RTrim( A218XT_LogTargetOperate);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbXT_LogTargetOperate_Internalname, "Values", cmbXT_LogTargetOperate.ToJavascriptSource(), true);
         }
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
            GxWebStd.gx_div_start( context, divTablemain_Internalname, 1, 0, "px", 0, "px", "TableMainTransaction", "left", "top", "", "", "div");
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
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-4 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtXT_LogSecUserName_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtXT_LogSecUserName_Internalname, "操作人", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 22,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtXT_LogSecUserName_Internalname, A174XT_LogSecUserName, StringUtil.RTrim( context.localUtil.Format( A174XT_LogSecUserName, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,22);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtXT_LogSecUserName_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtXT_LogSecUserName_Enabled, 0, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_XT_Log.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-4 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtXT_LogTime_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtXT_LogTime_Internalname, "操作时间", "col-sm-3 AttributeDateTimeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 26,'',false,'',0)\"";
            context.WriteHtmlText( "<div id=\""+edtXT_LogTime_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtXT_LogTime_Internalname, context.localUtil.TToC( A220XT_LogTime, 10, 8, 0, 0, "/", ":", " "), context.localUtil.Format( A220XT_LogTime, "9999/99/99 99:99:99"), TempTags+" onchange=\""+"gx.date.valid_date(this, 10,'YMD',8,24,'chs',false,1);"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,26);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtXT_LogTime_Jsonclick, 0, "AttributeDateTime", "", "", "", "", 1, edtXT_LogTime_Enabled, 0, "text", "", 19, "chr", 1, "row", 19, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_XT_Log.htm");
            GxWebStd.gx_bitmap( context, edtXT_LogTime_Internalname+"_dp_trigger", context.GetImagePath( "61b9b5d3-dff6-4d59-9b00-da61bc2cbe93", "", context.GetTheme( )), "", "", "", "", ((1==0)||(edtXT_LogTime_Enabled==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;", "", "", "", "", "", "", "", "", 1, false, false, "", "HLP_XT_Log.htm");
            context.WriteHtmlTextNl( "</div>") ;
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-4 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtXT_LogProviderName_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtXT_LogProviderName_Internalname, "日志分院名称", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 30,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtXT_LogProviderName_Internalname, A219XT_LogProviderName, StringUtil.RTrim( context.localUtil.Format( A219XT_LogProviderName, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,30);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtXT_LogProviderName_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtXT_LogProviderName_Enabled, 0, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_XT_Log.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-4 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtXT_LogTargetModule_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtXT_LogTargetModule_Internalname, "日志操作模块", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 35,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtXT_LogTargetModule_Internalname, A217XT_LogTargetModule, StringUtil.RTrim( context.localUtil.Format( A217XT_LogTargetModule, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,35);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtXT_LogTargetModule_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtXT_LogTargetModule_Enabled, 0, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_XT_Log.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divUnnamedtablext_logtarget_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-1 MergeLabelCell", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblockxt_logtarget_Internalname, "日志操作对象", "", "", lblTextblockxt_logtarget_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_XT_Log.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-11", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtXT_LogTarget_Internalname, "日志操作对象", "col-sm-3 AttributeLabel", 0, true);
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 44,'',false,'',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtXT_LogTarget_Internalname, A216XT_LogTarget, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,44);\"", 0, 1, edtXT_LogTarget_Enabled, 0, 80, "chr", 10, "row", StyleString, ClassString, "", "", "5000", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_XT_Log.htm");
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
            GxWebStd.gx_div_start( context, divUnnamedtablext_logdescription_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-1 MergeLabelCell", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblockxt_logdescription_Internalname, "日志描述", "", "", lblTextblockxt_logdescription_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_XT_Log.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-11", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtXT_LogDescription_Internalname, "日志描述", "col-sm-3 AttributeLabel", 0, true);
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 53,'',false,'',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtXT_LogDescription_Internalname, A221XT_LogDescription, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,53);\"", 0, 1, edtXT_LogDescription_Enabled, 0, 80, "chr", 10, "row", StyleString, ClassString, "", "", "5000", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_XT_Log.htm");
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
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 58,'',false,'',0)\"";
            ClassString = "ButtonMaterial";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtntrn_enter_Internalname, "", "确认", bttBtntrn_enter_Jsonclick, 5, "确认", "", StyleString, ClassString, bttBtntrn_enter_Visible, bttBtntrn_enter_Enabled, "standard", "'"+""+"'"+",false,"+"'"+"EENTER."+"'", TempTags, "", context.GetButtonType( ), "HLP_XT_Log.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 60,'',false,'',0)\"";
            ClassString = "ButtonMaterialDefault";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtntrn_cancel_Internalname, "", "取消", bttBtntrn_cancel_Jsonclick, 1, "取消", "", StyleString, ClassString, bttBtntrn_cancel_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ECANCEL."+"'", TempTags, "", context.GetButtonType( ), "HLP_XT_Log.htm");
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
            GxWebStd.gx_single_line_edit( context, edtXT_LogID_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A173XT_LogID), 18, 0, ".", "")), ((edtXT_LogID_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A173XT_LogID), "ZZZZZZZZZZZZZZZZZZ")) : context.localUtil.Format( (decimal)(A173XT_LogID), "ZZZZZZZZZZZZZZZZZZ")), "", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtXT_LogID_Jsonclick, 0, "Attribute", "", "", "", "", edtXT_LogID_Visible, edtXT_LogID_Enabled, 0, "number", "1", 18, "chr", 1, "row", 18, 0, 0, 0, 1, -1, 0, true, "ID", "right", false, "HLP_XT_Log.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 65,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtXT_LogUserID_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A214XT_LogUserID), 18, 0, ".", "")), ((edtXT_LogUserID_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A214XT_LogUserID), "ZZZZZZZZZZZZZZZZZZ")) : context.localUtil.Format( (decimal)(A214XT_LogUserID), "ZZZZZZZZZZZZZZZZZZ")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,65);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtXT_LogUserID_Jsonclick, 0, "Attribute", "", "", "", "", edtXT_LogUserID_Visible, edtXT_LogUserID_Enabled, 0, "number", "1", 18, "chr", 1, "row", 18, 0, 0, 0, 1, -1, 0, true, "ID", "right", false, "HLP_XT_Log.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 66,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtXT_LogPage_Internalname, A176XT_LogPage, StringUtil.RTrim( context.localUtil.Format( A176XT_LogPage, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,66);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtXT_LogPage_Jsonclick, 0, "Attribute", "", "", "", "", edtXT_LogPage_Visible, edtXT_LogPage_Enabled, 0, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_XT_Log.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 67,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtXT_LogButtonName_Internalname, A177XT_LogButtonName, StringUtil.RTrim( context.localUtil.Format( A177XT_LogButtonName, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,67);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtXT_LogButtonName_Jsonclick, 0, "Attribute", "", "", "", "", edtXT_LogButtonName_Visible, edtXT_LogButtonName_Enabled, 0, "text", "", 50, "chr", 1, "row", 50, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_XT_Log.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 68,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtXT_LogType_Internalname, A213XT_LogType, StringUtil.RTrim( context.localUtil.Format( A213XT_LogType, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,68);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtXT_LogType_Jsonclick, 0, "Attribute", "", "", "", "", edtXT_LogType_Visible, edtXT_LogType_Enabled, 0, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, -1, true, "DM_LogType", "left", true, "HLP_XT_Log.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 69,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtXT_LogProviderID_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A215XT_LogProviderID), 18, 0, ".", "")), ((edtXT_LogProviderID_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A215XT_LogProviderID), "ZZZZZZZZZZZZZZZZZZ")) : context.localUtil.Format( (decimal)(A215XT_LogProviderID), "ZZZZZZZZZZZZZZZZZZ")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,69);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtXT_LogProviderID_Jsonclick, 0, "Attribute", "", "", "", "", edtXT_LogProviderID_Visible, edtXT_LogProviderID_Enabled, 0, "number", "1", 18, "chr", 1, "row", 18, 0, 0, 0, 1, -1, 0, true, "ID", "right", false, "HLP_XT_Log.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 70,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtXT_LogSonTarget_Internalname, A223XT_LogSonTarget, StringUtil.RTrim( context.localUtil.Format( A223XT_LogSonTarget, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,70);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtXT_LogSonTarget_Jsonclick, 0, "Attribute", "", "", "", "", edtXT_LogSonTarget_Visible, edtXT_LogSonTarget_Enabled, 0, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_XT_Log.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 71,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtXT_LogTargetSonModule_Internalname, A222XT_LogTargetSonModule, StringUtil.RTrim( context.localUtil.Format( A222XT_LogTargetSonModule, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,71);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtXT_LogTargetSonModule_Jsonclick, 0, "Attribute", "", "", "", "", edtXT_LogTargetSonModule_Visible, edtXT_LogTargetSonModule_Enabled, 0, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_XT_Log.htm");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 72,'',false,'',0)\"";
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, cmbXT_LogTargetOperate, cmbXT_LogTargetOperate_Internalname, StringUtil.RTrim( A218XT_LogTargetOperate), 1, cmbXT_LogTargetOperate_Jsonclick, 0, "'"+""+"'"+",false,"+"'"+""+"'", "svchar", "", cmbXT_LogTargetOperate.Visible, cmbXT_LogTargetOperate.Enabled, 0, 0, 0, "em", 0, "", "", "Attribute", "", "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,72);\"", "", true, "HLP_XT_Log.htm");
            cmbXT_LogTargetOperate.CurrentValue = StringUtil.RTrim( A218XT_LogTargetOperate);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbXT_LogTargetOperate_Internalname, "Values", (String)(cmbXT_LogTargetOperate.ToJavascriptSource()), true);
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
         E110O2 ();
         context.wbGlbDoneStart = 1;
         assign_properties_default( ) ;
         if ( AnyError == 0 )
         {
            if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
            {
               /* Read saved SDTs. */
               /* Read variables values. */
               A174XT_LogSecUserName = cgiGet( edtXT_LogSecUserName_Internalname);
               n174XT_LogSecUserName = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A174XT_LogSecUserName", A174XT_LogSecUserName);
               n174XT_LogSecUserName = (String.IsNullOrEmpty(StringUtil.RTrim( A174XT_LogSecUserName)) ? true : false);
               if ( context.localUtil.VCDateTime( cgiGet( edtXT_LogTime_Internalname), 0, 0) == 0 )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_baddatetime", new   object[]  {"操作时间"}), 1, "XT_LOGTIME");
                  AnyError = 1;
                  GX_FocusControl = edtXT_LogTime_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A220XT_LogTime = (DateTime)(DateTime.MinValue);
                  n220XT_LogTime = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A220XT_LogTime", context.localUtil.TToC( A220XT_LogTime, 10, 8, 0, 0, "/", ":", " "));
               }
               else
               {
                  A220XT_LogTime = context.localUtil.CToT( cgiGet( edtXT_LogTime_Internalname));
                  n220XT_LogTime = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A220XT_LogTime", context.localUtil.TToC( A220XT_LogTime, 10, 8, 0, 0, "/", ":", " "));
               }
               n220XT_LogTime = ((DateTime.MinValue==A220XT_LogTime) ? true : false);
               A219XT_LogProviderName = cgiGet( edtXT_LogProviderName_Internalname);
               n219XT_LogProviderName = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A219XT_LogProviderName", A219XT_LogProviderName);
               n219XT_LogProviderName = (String.IsNullOrEmpty(StringUtil.RTrim( A219XT_LogProviderName)) ? true : false);
               A217XT_LogTargetModule = cgiGet( edtXT_LogTargetModule_Internalname);
               n217XT_LogTargetModule = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A217XT_LogTargetModule", A217XT_LogTargetModule);
               n217XT_LogTargetModule = (String.IsNullOrEmpty(StringUtil.RTrim( A217XT_LogTargetModule)) ? true : false);
               A216XT_LogTarget = cgiGet( edtXT_LogTarget_Internalname);
               n216XT_LogTarget = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A216XT_LogTarget", A216XT_LogTarget);
               n216XT_LogTarget = (String.IsNullOrEmpty(StringUtil.RTrim( A216XT_LogTarget)) ? true : false);
               A221XT_LogDescription = cgiGet( edtXT_LogDescription_Internalname);
               n221XT_LogDescription = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A221XT_LogDescription", A221XT_LogDescription);
               n221XT_LogDescription = (String.IsNullOrEmpty(StringUtil.RTrim( A221XT_LogDescription)) ? true : false);
               A173XT_LogID = (long)(context.localUtil.CToN( cgiGet( edtXT_LogID_Internalname), ".", ","));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A173XT_LogID", StringUtil.LTrim( StringUtil.Str( (decimal)(A173XT_LogID), 18, 0)));
               if ( ( ( context.localUtil.CToN( cgiGet( edtXT_LogUserID_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtXT_LogUserID_Internalname), ".", ",") > Convert.ToDecimal( 999999999999999999L )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "XT_LOGUSERID");
                  AnyError = 1;
                  GX_FocusControl = edtXT_LogUserID_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A214XT_LogUserID = 0;
                  n214XT_LogUserID = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A214XT_LogUserID", StringUtil.LTrim( StringUtil.Str( (decimal)(A214XT_LogUserID), 18, 0)));
               }
               else
               {
                  A214XT_LogUserID = (long)(context.localUtil.CToN( cgiGet( edtXT_LogUserID_Internalname), ".", ","));
                  n214XT_LogUserID = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A214XT_LogUserID", StringUtil.LTrim( StringUtil.Str( (decimal)(A214XT_LogUserID), 18, 0)));
               }
               n214XT_LogUserID = ((0==A214XT_LogUserID) ? true : false);
               A176XT_LogPage = cgiGet( edtXT_LogPage_Internalname);
               n176XT_LogPage = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A176XT_LogPage", A176XT_LogPage);
               n176XT_LogPage = (String.IsNullOrEmpty(StringUtil.RTrim( A176XT_LogPage)) ? true : false);
               A177XT_LogButtonName = cgiGet( edtXT_LogButtonName_Internalname);
               n177XT_LogButtonName = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A177XT_LogButtonName", A177XT_LogButtonName);
               n177XT_LogButtonName = (String.IsNullOrEmpty(StringUtil.RTrim( A177XT_LogButtonName)) ? true : false);
               A213XT_LogType = cgiGet( edtXT_LogType_Internalname);
               n213XT_LogType = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A213XT_LogType", A213XT_LogType);
               n213XT_LogType = (String.IsNullOrEmpty(StringUtil.RTrim( A213XT_LogType)) ? true : false);
               if ( ( ( context.localUtil.CToN( cgiGet( edtXT_LogProviderID_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtXT_LogProviderID_Internalname), ".", ",") > Convert.ToDecimal( 999999999999999999L )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "XT_LOGPROVIDERID");
                  AnyError = 1;
                  GX_FocusControl = edtXT_LogProviderID_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A215XT_LogProviderID = 0;
                  n215XT_LogProviderID = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A215XT_LogProviderID", StringUtil.LTrim( StringUtil.Str( (decimal)(A215XT_LogProviderID), 18, 0)));
               }
               else
               {
                  A215XT_LogProviderID = (long)(context.localUtil.CToN( cgiGet( edtXT_LogProviderID_Internalname), ".", ","));
                  n215XT_LogProviderID = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A215XT_LogProviderID", StringUtil.LTrim( StringUtil.Str( (decimal)(A215XT_LogProviderID), 18, 0)));
               }
               n215XT_LogProviderID = ((0==A215XT_LogProviderID) ? true : false);
               A223XT_LogSonTarget = cgiGet( edtXT_LogSonTarget_Internalname);
               n223XT_LogSonTarget = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A223XT_LogSonTarget", A223XT_LogSonTarget);
               n223XT_LogSonTarget = (String.IsNullOrEmpty(StringUtil.RTrim( A223XT_LogSonTarget)) ? true : false);
               A222XT_LogTargetSonModule = cgiGet( edtXT_LogTargetSonModule_Internalname);
               n222XT_LogTargetSonModule = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A222XT_LogTargetSonModule", A222XT_LogTargetSonModule);
               n222XT_LogTargetSonModule = (String.IsNullOrEmpty(StringUtil.RTrim( A222XT_LogTargetSonModule)) ? true : false);
               cmbXT_LogTargetOperate.CurrentValue = cgiGet( cmbXT_LogTargetOperate_Internalname);
               A218XT_LogTargetOperate = cgiGet( cmbXT_LogTargetOperate_Internalname);
               n218XT_LogTargetOperate = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A218XT_LogTargetOperate", A218XT_LogTargetOperate);
               n218XT_LogTargetOperate = (String.IsNullOrEmpty(StringUtil.RTrim( A218XT_LogTargetOperate)) ? true : false);
               /* Read saved values. */
               Z173XT_LogID = (long)(context.localUtil.CToN( cgiGet( "Z173XT_LogID"), ".", ","));
               Z214XT_LogUserID = (long)(context.localUtil.CToN( cgiGet( "Z214XT_LogUserID"), ".", ","));
               n214XT_LogUserID = ((0==A214XT_LogUserID) ? true : false);
               Z174XT_LogSecUserName = cgiGet( "Z174XT_LogSecUserName");
               n174XT_LogSecUserName = (String.IsNullOrEmpty(StringUtil.RTrim( A174XT_LogSecUserName)) ? true : false);
               Z220XT_LogTime = context.localUtil.CToT( cgiGet( "Z220XT_LogTime"), 0);
               n220XT_LogTime = ((DateTime.MinValue==A220XT_LogTime) ? true : false);
               Z176XT_LogPage = cgiGet( "Z176XT_LogPage");
               n176XT_LogPage = (String.IsNullOrEmpty(StringUtil.RTrim( A176XT_LogPage)) ? true : false);
               Z177XT_LogButtonName = cgiGet( "Z177XT_LogButtonName");
               n177XT_LogButtonName = (String.IsNullOrEmpty(StringUtil.RTrim( A177XT_LogButtonName)) ? true : false);
               Z213XT_LogType = cgiGet( "Z213XT_LogType");
               n213XT_LogType = (String.IsNullOrEmpty(StringUtil.RTrim( A213XT_LogType)) ? true : false);
               Z215XT_LogProviderID = (long)(context.localUtil.CToN( cgiGet( "Z215XT_LogProviderID"), ".", ","));
               n215XT_LogProviderID = ((0==A215XT_LogProviderID) ? true : false);
               Z219XT_LogProviderName = cgiGet( "Z219XT_LogProviderName");
               n219XT_LogProviderName = (String.IsNullOrEmpty(StringUtil.RTrim( A219XT_LogProviderName)) ? true : false);
               Z216XT_LogTarget = cgiGet( "Z216XT_LogTarget");
               n216XT_LogTarget = (String.IsNullOrEmpty(StringUtil.RTrim( A216XT_LogTarget)) ? true : false);
               Z223XT_LogSonTarget = cgiGet( "Z223XT_LogSonTarget");
               n223XT_LogSonTarget = (String.IsNullOrEmpty(StringUtil.RTrim( A223XT_LogSonTarget)) ? true : false);
               Z217XT_LogTargetModule = cgiGet( "Z217XT_LogTargetModule");
               n217XT_LogTargetModule = (String.IsNullOrEmpty(StringUtil.RTrim( A217XT_LogTargetModule)) ? true : false);
               Z222XT_LogTargetSonModule = cgiGet( "Z222XT_LogTargetSonModule");
               n222XT_LogTargetSonModule = (String.IsNullOrEmpty(StringUtil.RTrim( A222XT_LogTargetSonModule)) ? true : false);
               Z218XT_LogTargetOperate = cgiGet( "Z218XT_LogTargetOperate");
               n218XT_LogTargetOperate = (String.IsNullOrEmpty(StringUtil.RTrim( A218XT_LogTargetOperate)) ? true : false);
               Z221XT_LogDescription = cgiGet( "Z221XT_LogDescription");
               n221XT_LogDescription = (String.IsNullOrEmpty(StringUtil.RTrim( A221XT_LogDescription)) ? true : false);
               IsConfirmed = (short)(context.localUtil.CToN( cgiGet( "IsConfirmed"), ".", ","));
               IsModified = (short)(context.localUtil.CToN( cgiGet( "IsModified"), ".", ","));
               Gx_mode = cgiGet( "Mode");
               AV7XT_LogID = (long)(context.localUtil.CToN( cgiGet( "vXT_LOGID"), ".", ","));
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
               forbiddenHiddens = "hsh" + "XT_Log";
               A173XT_LogID = (long)(context.localUtil.CToN( cgiGet( edtXT_LogID_Internalname), ".", ","));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A173XT_LogID", StringUtil.LTrim( StringUtil.Str( (decimal)(A173XT_LogID), 18, 0)));
               forbiddenHiddens = forbiddenHiddens + context.localUtil.Format( (decimal)(A173XT_LogID), "ZZZZZZZZZZZZZZZZZZ");
               forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!"));
               hsh = cgiGet( "hsh");
               if ( ( ! ( ( A173XT_LogID != Z173XT_LogID ) ) || ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) ) && ! GXUtil.CheckEncryptedHash( forbiddenHiddens, hsh, GXKey) )
               {
                  GXUtil.WriteLog("xt_log:[SecurityCheckFailed value for]"+"XT_LogID:"+context.localUtil.Format( (decimal)(A173XT_LogID), "ZZZZZZZZZZZZZZZZZZ"));
                  GXUtil.WriteLog("xt_log:[SecurityCheckFailed value for]"+"Gx_mode:"+StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")));
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
                  A173XT_LogID = (long)(NumberUtil.Val( GetNextPar( ), "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A173XT_LogID", StringUtil.LTrim( StringUtil.Str( (decimal)(A173XT_LogID), 18, 0)));
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
                     sMode25 = Gx_mode;
                     Gx_mode = "UPD";
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                     Gx_mode = sMode25;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                  }
                  standaloneModal( ) ;
                  if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
                  {
                     getByPrimaryKey( ) ;
                     if ( RcdFound25 == 1 )
                     {
                        if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
                        {
                           /* Confirm record */
                           CONFIRM_0O0( ) ;
                           if ( AnyError == 0 )
                           {
                              GX_FocusControl = bttBtntrn_enter_Internalname;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                           }
                        }
                     }
                     else
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_noinsert", ""), 1, "XT_LOGID");
                        AnyError = 1;
                        GX_FocusControl = edtXT_LogID_Internalname;
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
                           E110O2 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "AFTER TRN") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           /* Execute user event: After Trn */
                           E120O2 ();
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
            E120O2 ();
            trnEnded = 0;
            standaloneNotModal( ) ;
            standaloneModal( ) ;
            if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  )
            {
               /* Clear variables for new insertion. */
               InitAll0O25( ) ;
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
         if ( ( StringUtil.StrCmp(Gx_mode, "DSP") == 0 ) || ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 ) )
         {
            if ( StringUtil.StrCmp(Gx_mode, "DSP") == 0 )
            {
               bttBtntrn_enter_Visible = 0;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtntrn_enter_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtntrn_enter_Visible), 5, 0)), true);
            }
            DisableAttributes0O25( ) ;
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

      protected void CONFIRM_0O0( )
      {
         BeforeValidate0O25( ) ;
         if ( AnyError == 0 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
            {
               OnDeleteControls0O25( ) ;
            }
            else
            {
               CheckExtendedTable0O25( ) ;
               CloseExtendedTableCursors0O25( ) ;
            }
         }
         if ( AnyError == 0 )
         {
            IsConfirmed = 1;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "IsConfirmed", StringUtil.LTrim( StringUtil.Str( (decimal)(IsConfirmed), 4, 0)));
         }
      }

      protected void ResetCaption0O0( )
      {
      }

      protected void E110O2( )
      {
         /* Start Routine */
         new GeneXus.Programs.wwpbaseobjects.loadwwpcontext(context ).execute( out  AV8WWPContext) ;
         AV9IsAuthorized = true;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9IsAuthorized", AV9IsAuthorized);
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            GXt_boolean1 = AV9IsAuthorized;
            new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "WWXT_Log_Insert", out  GXt_boolean1) ;
            AV9IsAuthorized = GXt_boolean1;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9IsAuthorized", AV9IsAuthorized);
         }
         if ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 )
         {
            GXt_boolean1 = AV9IsAuthorized;
            new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "WWXT_Log_Update", out  GXt_boolean1) ;
            AV9IsAuthorized = GXt_boolean1;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9IsAuthorized", AV9IsAuthorized);
         }
         if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
         {
            GXt_boolean1 = AV9IsAuthorized;
            new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "WWXT_Log_Delete", out  GXt_boolean1) ;
            AV9IsAuthorized = GXt_boolean1;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9IsAuthorized", AV9IsAuthorized);
         }
         if ( ! AV9IsAuthorized )
         {
            CallWebObject(formatLink("wwpbaseobjects.notauthorized.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV13Pgmname)));
            context.wjLocDisableFrm = 1;
         }
         AV11TrnContext.FromXml(AV12WebSession.Get("TrnContext"), null, "WWPTransactionContext", "DataAnalysisPlatform");
         edtXT_LogID_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtXT_LogID_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtXT_LogID_Visible), 5, 0)), true);
         edtXT_LogUserID_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtXT_LogUserID_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtXT_LogUserID_Visible), 5, 0)), true);
         edtXT_LogPage_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtXT_LogPage_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtXT_LogPage_Visible), 5, 0)), true);
         edtXT_LogButtonName_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtXT_LogButtonName_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtXT_LogButtonName_Visible), 5, 0)), true);
         edtXT_LogType_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtXT_LogType_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtXT_LogType_Visible), 5, 0)), true);
         edtXT_LogProviderID_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtXT_LogProviderID_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtXT_LogProviderID_Visible), 5, 0)), true);
         edtXT_LogSonTarget_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtXT_LogSonTarget_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtXT_LogSonTarget_Visible), 5, 0)), true);
         edtXT_LogTargetSonModule_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtXT_LogTargetSonModule_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtXT_LogTargetSonModule_Visible), 5, 0)), true);
         cmbXT_LogTargetOperate.Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbXT_LogTargetOperate_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(cmbXT_LogTargetOperate.Visible), 5, 0)), true);
      }

      protected void E120O2( )
      {
         /* After Trn Routine */
         if ( ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 ) && ! AV11TrnContext.gxTpr_Callerondelete )
         {
            CallWebObject(formatLink("xt_logww.aspx") );
            context.wjLocDisableFrm = 1;
         }
         context.setWebReturnParms(new Object[] {});
         context.setWebReturnParmsMetadata(new Object[] {});
         context.wjLocDisableFrm = 1;
         context.nUserReturn = 1;
         returnInSub = true;
         if (true) return;
      }

      protected void ZM0O25( short GX_JID )
      {
         if ( ( GX_JID == 5 ) || ( GX_JID == 0 ) )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
            {
               Z214XT_LogUserID = T000O3_A214XT_LogUserID[0];
               Z174XT_LogSecUserName = T000O3_A174XT_LogSecUserName[0];
               Z220XT_LogTime = T000O3_A220XT_LogTime[0];
               Z176XT_LogPage = T000O3_A176XT_LogPage[0];
               Z177XT_LogButtonName = T000O3_A177XT_LogButtonName[0];
               Z213XT_LogType = T000O3_A213XT_LogType[0];
               Z215XT_LogProviderID = T000O3_A215XT_LogProviderID[0];
               Z219XT_LogProviderName = T000O3_A219XT_LogProviderName[0];
               Z216XT_LogTarget = T000O3_A216XT_LogTarget[0];
               Z223XT_LogSonTarget = T000O3_A223XT_LogSonTarget[0];
               Z217XT_LogTargetModule = T000O3_A217XT_LogTargetModule[0];
               Z222XT_LogTargetSonModule = T000O3_A222XT_LogTargetSonModule[0];
               Z218XT_LogTargetOperate = T000O3_A218XT_LogTargetOperate[0];
               Z221XT_LogDescription = T000O3_A221XT_LogDescription[0];
            }
            else
            {
               Z214XT_LogUserID = A214XT_LogUserID;
               Z174XT_LogSecUserName = A174XT_LogSecUserName;
               Z220XT_LogTime = A220XT_LogTime;
               Z176XT_LogPage = A176XT_LogPage;
               Z177XT_LogButtonName = A177XT_LogButtonName;
               Z213XT_LogType = A213XT_LogType;
               Z215XT_LogProviderID = A215XT_LogProviderID;
               Z219XT_LogProviderName = A219XT_LogProviderName;
               Z216XT_LogTarget = A216XT_LogTarget;
               Z223XT_LogSonTarget = A223XT_LogSonTarget;
               Z217XT_LogTargetModule = A217XT_LogTargetModule;
               Z222XT_LogTargetSonModule = A222XT_LogTargetSonModule;
               Z218XT_LogTargetOperate = A218XT_LogTargetOperate;
               Z221XT_LogDescription = A221XT_LogDescription;
            }
         }
         if ( GX_JID == -5 )
         {
            Z173XT_LogID = A173XT_LogID;
            Z214XT_LogUserID = A214XT_LogUserID;
            Z174XT_LogSecUserName = A174XT_LogSecUserName;
            Z220XT_LogTime = A220XT_LogTime;
            Z176XT_LogPage = A176XT_LogPage;
            Z177XT_LogButtonName = A177XT_LogButtonName;
            Z213XT_LogType = A213XT_LogType;
            Z215XT_LogProviderID = A215XT_LogProviderID;
            Z219XT_LogProviderName = A219XT_LogProviderName;
            Z216XT_LogTarget = A216XT_LogTarget;
            Z223XT_LogSonTarget = A223XT_LogSonTarget;
            Z217XT_LogTargetModule = A217XT_LogTargetModule;
            Z222XT_LogTargetSonModule = A222XT_LogTargetSonModule;
            Z218XT_LogTargetOperate = A218XT_LogTargetOperate;
            Z221XT_LogDescription = A221XT_LogDescription;
         }
      }

      protected void standaloneNotModal( )
      {
         edtXT_LogID_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtXT_LogID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtXT_LogID_Enabled), 5, 0)), true);
         edtXT_LogID_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtXT_LogID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtXT_LogID_Enabled), 5, 0)), true);
         if ( ! (0==AV7XT_LogID) )
         {
            A173XT_LogID = AV7XT_LogID;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A173XT_LogID", StringUtil.LTrim( StringUtil.Str( (decimal)(A173XT_LogID), 18, 0)));
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

      protected void Load0O25( )
      {
         /* Using cursor T000O4 */
         pr_default.execute(2, new Object[] {A173XT_LogID});
         if ( (pr_default.getStatus(2) != 101) )
         {
            RcdFound25 = 1;
            A214XT_LogUserID = T000O4_A214XT_LogUserID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A214XT_LogUserID", StringUtil.LTrim( StringUtil.Str( (decimal)(A214XT_LogUserID), 18, 0)));
            n214XT_LogUserID = T000O4_n214XT_LogUserID[0];
            A174XT_LogSecUserName = T000O4_A174XT_LogSecUserName[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A174XT_LogSecUserName", A174XT_LogSecUserName);
            n174XT_LogSecUserName = T000O4_n174XT_LogSecUserName[0];
            A220XT_LogTime = T000O4_A220XT_LogTime[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A220XT_LogTime", context.localUtil.TToC( A220XT_LogTime, 10, 8, 0, 0, "/", ":", " "));
            n220XT_LogTime = T000O4_n220XT_LogTime[0];
            A176XT_LogPage = T000O4_A176XT_LogPage[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A176XT_LogPage", A176XT_LogPage);
            n176XT_LogPage = T000O4_n176XT_LogPage[0];
            A177XT_LogButtonName = T000O4_A177XT_LogButtonName[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A177XT_LogButtonName", A177XT_LogButtonName);
            n177XT_LogButtonName = T000O4_n177XT_LogButtonName[0];
            A213XT_LogType = T000O4_A213XT_LogType[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A213XT_LogType", A213XT_LogType);
            n213XT_LogType = T000O4_n213XT_LogType[0];
            A215XT_LogProviderID = T000O4_A215XT_LogProviderID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A215XT_LogProviderID", StringUtil.LTrim( StringUtil.Str( (decimal)(A215XT_LogProviderID), 18, 0)));
            n215XT_LogProviderID = T000O4_n215XT_LogProviderID[0];
            A219XT_LogProviderName = T000O4_A219XT_LogProviderName[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A219XT_LogProviderName", A219XT_LogProviderName);
            n219XT_LogProviderName = T000O4_n219XT_LogProviderName[0];
            A216XT_LogTarget = T000O4_A216XT_LogTarget[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A216XT_LogTarget", A216XT_LogTarget);
            n216XT_LogTarget = T000O4_n216XT_LogTarget[0];
            A223XT_LogSonTarget = T000O4_A223XT_LogSonTarget[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A223XT_LogSonTarget", A223XT_LogSonTarget);
            n223XT_LogSonTarget = T000O4_n223XT_LogSonTarget[0];
            A217XT_LogTargetModule = T000O4_A217XT_LogTargetModule[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A217XT_LogTargetModule", A217XT_LogTargetModule);
            n217XT_LogTargetModule = T000O4_n217XT_LogTargetModule[0];
            A222XT_LogTargetSonModule = T000O4_A222XT_LogTargetSonModule[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A222XT_LogTargetSonModule", A222XT_LogTargetSonModule);
            n222XT_LogTargetSonModule = T000O4_n222XT_LogTargetSonModule[0];
            A218XT_LogTargetOperate = T000O4_A218XT_LogTargetOperate[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A218XT_LogTargetOperate", A218XT_LogTargetOperate);
            n218XT_LogTargetOperate = T000O4_n218XT_LogTargetOperate[0];
            A221XT_LogDescription = T000O4_A221XT_LogDescription[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A221XT_LogDescription", A221XT_LogDescription);
            n221XT_LogDescription = T000O4_n221XT_LogDescription[0];
            ZM0O25( -5) ;
         }
         pr_default.close(2);
         OnLoadActions0O25( ) ;
      }

      protected void OnLoadActions0O25( )
      {
         AV13Pgmname = "XT_Log";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13Pgmname", AV13Pgmname);
      }

      protected void CheckExtendedTable0O25( )
      {
         Gx_BScreen = 1;
         standaloneModal( ) ;
         AV13Pgmname = "XT_Log";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13Pgmname", AV13Pgmname);
         if ( ! ( (DateTime.MinValue==A220XT_LogTime) || ( A220XT_LogTime >= context.localUtil.YMDHMSToT( 1753, 1, 1, 0, 0, 0) ) ) )
         {
            GX_msglist.addItem("域������������超界", "OutOfRange", 1, "XT_LOGTIME");
            AnyError = 1;
            GX_FocusControl = edtXT_LogTime_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( ! ( ( StringUtil.StrCmp(A218XT_LogTargetOperate, "Create") == 0 ) || ( StringUtil.StrCmp(A218XT_LogTargetOperate, "Update") == 0 ) || ( StringUtil.StrCmp(A218XT_LogTargetOperate, "Delete") == 0 ) || ( StringUtil.StrCmp(A218XT_LogTargetOperate, "Create") == 0 ) || ( StringUtil.StrCmp(A218XT_LogTargetOperate, "Submit") == 0 ) || ( StringUtil.StrCmp(A218XT_LogTargetOperate, "Batchcheck") == 0 ) || ( StringUtil.StrCmp(A218XT_LogTargetOperate, "Batchapprove") == 0 ) || ( StringUtil.StrCmp(A218XT_LogTargetOperate, "Randomcheckpass") == 0 ) || ( StringUtil.StrCmp(A218XT_LogTargetOperate, "Randomcheckrefuse") == 0 ) || ( StringUtil.StrCmp(A218XT_LogTargetOperate, "Randomapprovepass") == 0 ) || ( StringUtil.StrCmp(A218XT_LogTargetOperate, "Randomapproverefuse") == 0 ) || ( StringUtil.StrCmp(A218XT_LogTargetOperate, "Check") == 0 ) || ( StringUtil.StrCmp(A218XT_LogTargetOperate, "Approve") == 0 ) || ( StringUtil.StrCmp(A218XT_LogTargetOperate, "Reupdate") == 0 ) || ( StringUtil.StrCmp(A218XT_LogTargetOperate, "Login") == 0 ) || String.IsNullOrEmpty(StringUtil.RTrim( A218XT_LogTargetOperate)) ) )
         {
            GX_msglist.addItem("域������������������������超界", "OutOfRange", 1, "XT_LOGTARGETOPERATE");
            AnyError = 1;
            GX_FocusControl = cmbXT_LogTargetOperate_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
      }

      protected void CloseExtendedTableCursors0O25( )
      {
      }

      protected void enableDisable( )
      {
      }

      protected void GetKey0O25( )
      {
         /* Using cursor T000O5 */
         pr_default.execute(3, new Object[] {A173XT_LogID});
         if ( (pr_default.getStatus(3) != 101) )
         {
            RcdFound25 = 1;
         }
         else
         {
            RcdFound25 = 0;
         }
         pr_default.close(3);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor T000O3 */
         pr_default.execute(1, new Object[] {A173XT_LogID});
         if ( (pr_default.getStatus(1) != 101) )
         {
            ZM0O25( 5) ;
            RcdFound25 = 1;
            A173XT_LogID = T000O3_A173XT_LogID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A173XT_LogID", StringUtil.LTrim( StringUtil.Str( (decimal)(A173XT_LogID), 18, 0)));
            A214XT_LogUserID = T000O3_A214XT_LogUserID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A214XT_LogUserID", StringUtil.LTrim( StringUtil.Str( (decimal)(A214XT_LogUserID), 18, 0)));
            n214XT_LogUserID = T000O3_n214XT_LogUserID[0];
            A174XT_LogSecUserName = T000O3_A174XT_LogSecUserName[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A174XT_LogSecUserName", A174XT_LogSecUserName);
            n174XT_LogSecUserName = T000O3_n174XT_LogSecUserName[0];
            A220XT_LogTime = T000O3_A220XT_LogTime[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A220XT_LogTime", context.localUtil.TToC( A220XT_LogTime, 10, 8, 0, 0, "/", ":", " "));
            n220XT_LogTime = T000O3_n220XT_LogTime[0];
            A176XT_LogPage = T000O3_A176XT_LogPage[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A176XT_LogPage", A176XT_LogPage);
            n176XT_LogPage = T000O3_n176XT_LogPage[0];
            A177XT_LogButtonName = T000O3_A177XT_LogButtonName[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A177XT_LogButtonName", A177XT_LogButtonName);
            n177XT_LogButtonName = T000O3_n177XT_LogButtonName[0];
            A213XT_LogType = T000O3_A213XT_LogType[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A213XT_LogType", A213XT_LogType);
            n213XT_LogType = T000O3_n213XT_LogType[0];
            A215XT_LogProviderID = T000O3_A215XT_LogProviderID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A215XT_LogProviderID", StringUtil.LTrim( StringUtil.Str( (decimal)(A215XT_LogProviderID), 18, 0)));
            n215XT_LogProviderID = T000O3_n215XT_LogProviderID[0];
            A219XT_LogProviderName = T000O3_A219XT_LogProviderName[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A219XT_LogProviderName", A219XT_LogProviderName);
            n219XT_LogProviderName = T000O3_n219XT_LogProviderName[0];
            A216XT_LogTarget = T000O3_A216XT_LogTarget[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A216XT_LogTarget", A216XT_LogTarget);
            n216XT_LogTarget = T000O3_n216XT_LogTarget[0];
            A223XT_LogSonTarget = T000O3_A223XT_LogSonTarget[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A223XT_LogSonTarget", A223XT_LogSonTarget);
            n223XT_LogSonTarget = T000O3_n223XT_LogSonTarget[0];
            A217XT_LogTargetModule = T000O3_A217XT_LogTargetModule[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A217XT_LogTargetModule", A217XT_LogTargetModule);
            n217XT_LogTargetModule = T000O3_n217XT_LogTargetModule[0];
            A222XT_LogTargetSonModule = T000O3_A222XT_LogTargetSonModule[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A222XT_LogTargetSonModule", A222XT_LogTargetSonModule);
            n222XT_LogTargetSonModule = T000O3_n222XT_LogTargetSonModule[0];
            A218XT_LogTargetOperate = T000O3_A218XT_LogTargetOperate[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A218XT_LogTargetOperate", A218XT_LogTargetOperate);
            n218XT_LogTargetOperate = T000O3_n218XT_LogTargetOperate[0];
            A221XT_LogDescription = T000O3_A221XT_LogDescription[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A221XT_LogDescription", A221XT_LogDescription);
            n221XT_LogDescription = T000O3_n221XT_LogDescription[0];
            Z173XT_LogID = A173XT_LogID;
            sMode25 = Gx_mode;
            Gx_mode = "DSP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
            Load0O25( ) ;
            if ( AnyError == 1 )
            {
               RcdFound25 = 0;
               InitializeNonKey0O25( ) ;
            }
            Gx_mode = sMode25;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         }
         else
         {
            RcdFound25 = 0;
            InitializeNonKey0O25( ) ;
            sMode25 = Gx_mode;
            Gx_mode = "DSP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
            standaloneModal( ) ;
            Gx_mode = sMode25;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         }
         pr_default.close(1);
      }

      protected void getEqualNoModal( )
      {
         GetKey0O25( ) ;
         if ( RcdFound25 == 0 )
         {
         }
         else
         {
         }
         getByPrimaryKey( ) ;
      }

      protected void move_next( )
      {
         RcdFound25 = 0;
         /* Using cursor T000O6 */
         pr_default.execute(4, new Object[] {A173XT_LogID});
         if ( (pr_default.getStatus(4) != 101) )
         {
            while ( (pr_default.getStatus(4) != 101) && ( ( T000O6_A173XT_LogID[0] < A173XT_LogID ) ) )
            {
               pr_default.readNext(4);
            }
            if ( (pr_default.getStatus(4) != 101) && ( ( T000O6_A173XT_LogID[0] > A173XT_LogID ) ) )
            {
               A173XT_LogID = T000O6_A173XT_LogID[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A173XT_LogID", StringUtil.LTrim( StringUtil.Str( (decimal)(A173XT_LogID), 18, 0)));
               RcdFound25 = 1;
            }
         }
         pr_default.close(4);
      }

      protected void move_previous( )
      {
         RcdFound25 = 0;
         /* Using cursor T000O7 */
         pr_default.execute(5, new Object[] {A173XT_LogID});
         if ( (pr_default.getStatus(5) != 101) )
         {
            while ( (pr_default.getStatus(5) != 101) && ( ( T000O7_A173XT_LogID[0] > A173XT_LogID ) ) )
            {
               pr_default.readNext(5);
            }
            if ( (pr_default.getStatus(5) != 101) && ( ( T000O7_A173XT_LogID[0] < A173XT_LogID ) ) )
            {
               A173XT_LogID = T000O7_A173XT_LogID[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A173XT_LogID", StringUtil.LTrim( StringUtil.Str( (decimal)(A173XT_LogID), 18, 0)));
               RcdFound25 = 1;
            }
         }
         pr_default.close(5);
      }

      protected void btn_enter( )
      {
         nKeyPressed = 1;
         GetKey0O25( ) ;
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            /* Insert record */
            GX_FocusControl = edtXT_LogSecUserName_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            Insert0O25( ) ;
            if ( AnyError == 1 )
            {
               GX_FocusControl = "";
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
         }
         else
         {
            if ( RcdFound25 == 1 )
            {
               if ( A173XT_LogID != Z173XT_LogID )
               {
                  A173XT_LogID = Z173XT_LogID;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A173XT_LogID", StringUtil.LTrim( StringUtil.Str( (decimal)(A173XT_LogID), 18, 0)));
                  GX_msglist.addItem(context.GetMessage( "GXM_getbeforeupd", ""), "CandidateKeyNotFound", 1, "XT_LOGID");
                  AnyError = 1;
                  GX_FocusControl = edtXT_LogID_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
               else if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
               {
                  delete( ) ;
                  AfterTrn( ) ;
                  GX_FocusControl = edtXT_LogSecUserName_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
               else
               {
                  /* Update record */
                  Update0O25( ) ;
                  GX_FocusControl = edtXT_LogSecUserName_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
            }
            else
            {
               if ( A173XT_LogID != Z173XT_LogID )
               {
                  /* Insert record */
                  GX_FocusControl = edtXT_LogSecUserName_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  Insert0O25( ) ;
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
                     GX_msglist.addItem(context.GetMessage( "GXM_recdeleted", ""), 1, "XT_LOGID");
                     AnyError = 1;
                     GX_FocusControl = edtXT_LogID_Internalname;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  }
                  else
                  {
                     /* Insert record */
                     GX_FocusControl = edtXT_LogSecUserName_Internalname;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                     Insert0O25( ) ;
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
         if ( A173XT_LogID != Z173XT_LogID )
         {
            A173XT_LogID = Z173XT_LogID;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A173XT_LogID", StringUtil.LTrim( StringUtil.Str( (decimal)(A173XT_LogID), 18, 0)));
            GX_msglist.addItem(context.GetMessage( "GXM_getbeforedlt", ""), 1, "XT_LOGID");
            AnyError = 1;
            GX_FocusControl = edtXT_LogID_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         else
         {
            delete( ) ;
            AfterTrn( ) ;
            GX_FocusControl = edtXT_LogSecUserName_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( AnyError != 0 )
         {
         }
      }

      protected void CheckOptimisticConcurrency0O25( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor T000O2 */
            pr_default.execute(0, new Object[] {A173XT_LogID});
            if ( (pr_default.getStatus(0) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"XT_Log"}), "RecordIsLocked", 1, "");
               AnyError = 1;
               return  ;
            }
            Gx_longc = false;
            if ( (pr_default.getStatus(0) == 101) || ( Z214XT_LogUserID != T000O2_A214XT_LogUserID[0] ) || ( StringUtil.StrCmp(Z174XT_LogSecUserName, T000O2_A174XT_LogSecUserName[0]) != 0 ) || ( Z220XT_LogTime != T000O2_A220XT_LogTime[0] ) || ( StringUtil.StrCmp(Z176XT_LogPage, T000O2_A176XT_LogPage[0]) != 0 ) || ( StringUtil.StrCmp(Z177XT_LogButtonName, T000O2_A177XT_LogButtonName[0]) != 0 ) )
            {
               Gx_longc = true;
            }
            if ( Gx_longc || ( StringUtil.StrCmp(Z213XT_LogType, T000O2_A213XT_LogType[0]) != 0 ) || ( Z215XT_LogProviderID != T000O2_A215XT_LogProviderID[0] ) || ( StringUtil.StrCmp(Z219XT_LogProviderName, T000O2_A219XT_LogProviderName[0]) != 0 ) || ( StringUtil.StrCmp(Z216XT_LogTarget, T000O2_A216XT_LogTarget[0]) != 0 ) || ( StringUtil.StrCmp(Z223XT_LogSonTarget, T000O2_A223XT_LogSonTarget[0]) != 0 ) )
            {
               Gx_longc = true;
            }
            if ( Gx_longc || ( StringUtil.StrCmp(Z217XT_LogTargetModule, T000O2_A217XT_LogTargetModule[0]) != 0 ) || ( StringUtil.StrCmp(Z222XT_LogTargetSonModule, T000O2_A222XT_LogTargetSonModule[0]) != 0 ) || ( StringUtil.StrCmp(Z218XT_LogTargetOperate, T000O2_A218XT_LogTargetOperate[0]) != 0 ) || ( StringUtil.StrCmp(Z221XT_LogDescription, T000O2_A221XT_LogDescription[0]) != 0 ) )
            {
               if ( Z214XT_LogUserID != T000O2_A214XT_LogUserID[0] )
               {
                  GXUtil.WriteLog("xt_log:[seudo value changed for attri]"+"XT_LogUserID");
                  GXUtil.WriteLogRaw("Old: ",Z214XT_LogUserID);
                  GXUtil.WriteLogRaw("Current: ",T000O2_A214XT_LogUserID[0]);
               }
               if ( StringUtil.StrCmp(Z174XT_LogSecUserName, T000O2_A174XT_LogSecUserName[0]) != 0 )
               {
                  GXUtil.WriteLog("xt_log:[seudo value changed for attri]"+"XT_LogSecUserName");
                  GXUtil.WriteLogRaw("Old: ",Z174XT_LogSecUserName);
                  GXUtil.WriteLogRaw("Current: ",T000O2_A174XT_LogSecUserName[0]);
               }
               if ( Z220XT_LogTime != T000O2_A220XT_LogTime[0] )
               {
                  GXUtil.WriteLog("xt_log:[seudo value changed for attri]"+"XT_LogTime");
                  GXUtil.WriteLogRaw("Old: ",Z220XT_LogTime);
                  GXUtil.WriteLogRaw("Current: ",T000O2_A220XT_LogTime[0]);
               }
               if ( StringUtil.StrCmp(Z176XT_LogPage, T000O2_A176XT_LogPage[0]) != 0 )
               {
                  GXUtil.WriteLog("xt_log:[seudo value changed for attri]"+"XT_LogPage");
                  GXUtil.WriteLogRaw("Old: ",Z176XT_LogPage);
                  GXUtil.WriteLogRaw("Current: ",T000O2_A176XT_LogPage[0]);
               }
               if ( StringUtil.StrCmp(Z177XT_LogButtonName, T000O2_A177XT_LogButtonName[0]) != 0 )
               {
                  GXUtil.WriteLog("xt_log:[seudo value changed for attri]"+"XT_LogButtonName");
                  GXUtil.WriteLogRaw("Old: ",Z177XT_LogButtonName);
                  GXUtil.WriteLogRaw("Current: ",T000O2_A177XT_LogButtonName[0]);
               }
               if ( StringUtil.StrCmp(Z213XT_LogType, T000O2_A213XT_LogType[0]) != 0 )
               {
                  GXUtil.WriteLog("xt_log:[seudo value changed for attri]"+"XT_LogType");
                  GXUtil.WriteLogRaw("Old: ",Z213XT_LogType);
                  GXUtil.WriteLogRaw("Current: ",T000O2_A213XT_LogType[0]);
               }
               if ( Z215XT_LogProviderID != T000O2_A215XT_LogProviderID[0] )
               {
                  GXUtil.WriteLog("xt_log:[seudo value changed for attri]"+"XT_LogProviderID");
                  GXUtil.WriteLogRaw("Old: ",Z215XT_LogProviderID);
                  GXUtil.WriteLogRaw("Current: ",T000O2_A215XT_LogProviderID[0]);
               }
               if ( StringUtil.StrCmp(Z219XT_LogProviderName, T000O2_A219XT_LogProviderName[0]) != 0 )
               {
                  GXUtil.WriteLog("xt_log:[seudo value changed for attri]"+"XT_LogProviderName");
                  GXUtil.WriteLogRaw("Old: ",Z219XT_LogProviderName);
                  GXUtil.WriteLogRaw("Current: ",T000O2_A219XT_LogProviderName[0]);
               }
               if ( StringUtil.StrCmp(Z216XT_LogTarget, T000O2_A216XT_LogTarget[0]) != 0 )
               {
                  GXUtil.WriteLog("xt_log:[seudo value changed for attri]"+"XT_LogTarget");
                  GXUtil.WriteLogRaw("Old: ",Z216XT_LogTarget);
                  GXUtil.WriteLogRaw("Current: ",T000O2_A216XT_LogTarget[0]);
               }
               if ( StringUtil.StrCmp(Z223XT_LogSonTarget, T000O2_A223XT_LogSonTarget[0]) != 0 )
               {
                  GXUtil.WriteLog("xt_log:[seudo value changed for attri]"+"XT_LogSonTarget");
                  GXUtil.WriteLogRaw("Old: ",Z223XT_LogSonTarget);
                  GXUtil.WriteLogRaw("Current: ",T000O2_A223XT_LogSonTarget[0]);
               }
               if ( StringUtil.StrCmp(Z217XT_LogTargetModule, T000O2_A217XT_LogTargetModule[0]) != 0 )
               {
                  GXUtil.WriteLog("xt_log:[seudo value changed for attri]"+"XT_LogTargetModule");
                  GXUtil.WriteLogRaw("Old: ",Z217XT_LogTargetModule);
                  GXUtil.WriteLogRaw("Current: ",T000O2_A217XT_LogTargetModule[0]);
               }
               if ( StringUtil.StrCmp(Z222XT_LogTargetSonModule, T000O2_A222XT_LogTargetSonModule[0]) != 0 )
               {
                  GXUtil.WriteLog("xt_log:[seudo value changed for attri]"+"XT_LogTargetSonModule");
                  GXUtil.WriteLogRaw("Old: ",Z222XT_LogTargetSonModule);
                  GXUtil.WriteLogRaw("Current: ",T000O2_A222XT_LogTargetSonModule[0]);
               }
               if ( StringUtil.StrCmp(Z218XT_LogTargetOperate, T000O2_A218XT_LogTargetOperate[0]) != 0 )
               {
                  GXUtil.WriteLog("xt_log:[seudo value changed for attri]"+"XT_LogTargetOperate");
                  GXUtil.WriteLogRaw("Old: ",Z218XT_LogTargetOperate);
                  GXUtil.WriteLogRaw("Current: ",T000O2_A218XT_LogTargetOperate[0]);
               }
               if ( StringUtil.StrCmp(Z221XT_LogDescription, T000O2_A221XT_LogDescription[0]) != 0 )
               {
                  GXUtil.WriteLog("xt_log:[seudo value changed for attri]"+"XT_LogDescription");
                  GXUtil.WriteLogRaw("Old: ",Z221XT_LogDescription);
                  GXUtil.WriteLogRaw("Current: ",T000O2_A221XT_LogDescription[0]);
               }
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"XT_Log"}), "RecordWasChanged", 1, "");
               AnyError = 1;
               return  ;
            }
         }
      }

      protected void Insert0O25( )
      {
         BeforeValidate0O25( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0O25( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM0O25( 0) ;
            CheckOptimisticConcurrency0O25( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0O25( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert0O25( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000O8 */
                     pr_default.execute(6, new Object[] {n214XT_LogUserID, A214XT_LogUserID, n174XT_LogSecUserName, A174XT_LogSecUserName, n220XT_LogTime, A220XT_LogTime, n176XT_LogPage, A176XT_LogPage, n177XT_LogButtonName, A177XT_LogButtonName, n213XT_LogType, A213XT_LogType, n215XT_LogProviderID, A215XT_LogProviderID, n219XT_LogProviderName, A219XT_LogProviderName, n216XT_LogTarget, A216XT_LogTarget, n223XT_LogSonTarget, A223XT_LogSonTarget, n217XT_LogTargetModule, A217XT_LogTargetModule, n222XT_LogTargetSonModule, A222XT_LogTargetSonModule, n218XT_LogTargetOperate, A218XT_LogTargetOperate, n221XT_LogDescription, A221XT_LogDescription});
                     A173XT_LogID = T000O8_A173XT_LogID[0];
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A173XT_LogID", StringUtil.LTrim( StringUtil.Str( (decimal)(A173XT_LogID), 18, 0)));
                     pr_default.close(6);
                     dsDefault.SmartCacheProvider.SetUpdated("XT_Log") ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( Insert) rules */
                        /* End of After( Insert) rules */
                        if ( AnyError == 0 )
                        {
                           /* Save values for previous() function. */
                           GX_msglist.addItem(context.GetMessage( "GXM_sucadded", ""), "SuccessfullyAdded", 0, "", true);
                           ResetCaption0O0( ) ;
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
               Load0O25( ) ;
            }
            EndLevel0O25( ) ;
         }
         CloseExtendedTableCursors0O25( ) ;
      }

      protected void Update0O25( )
      {
         BeforeValidate0O25( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0O25( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0O25( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0O25( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate0O25( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000O9 */
                     pr_default.execute(7, new Object[] {n214XT_LogUserID, A214XT_LogUserID, n174XT_LogSecUserName, A174XT_LogSecUserName, n220XT_LogTime, A220XT_LogTime, n176XT_LogPage, A176XT_LogPage, n177XT_LogButtonName, A177XT_LogButtonName, n213XT_LogType, A213XT_LogType, n215XT_LogProviderID, A215XT_LogProviderID, n219XT_LogProviderName, A219XT_LogProviderName, n216XT_LogTarget, A216XT_LogTarget, n223XT_LogSonTarget, A223XT_LogSonTarget, n217XT_LogTargetModule, A217XT_LogTargetModule, n222XT_LogTargetSonModule, A222XT_LogTargetSonModule, n218XT_LogTargetOperate, A218XT_LogTargetOperate, n221XT_LogDescription, A221XT_LogDescription, A173XT_LogID});
                     pr_default.close(7);
                     dsDefault.SmartCacheProvider.SetUpdated("XT_Log") ;
                     if ( (pr_default.getStatus(7) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"XT_Log"}), "RecordIsLocked", 1, "");
                        AnyError = 1;
                     }
                     DeferredUpdate0O25( ) ;
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
            EndLevel0O25( ) ;
         }
         CloseExtendedTableCursors0O25( ) ;
      }

      protected void DeferredUpdate0O25( )
      {
      }

      protected void delete( )
      {
         BeforeValidate0O25( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0O25( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls0O25( ) ;
            AfterConfirm0O25( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete0O25( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor T000O10 */
                  pr_default.execute(8, new Object[] {A173XT_LogID});
                  pr_default.close(8);
                  dsDefault.SmartCacheProvider.SetUpdated("XT_Log") ;
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
         sMode25 = Gx_mode;
         Gx_mode = "DLT";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         EndLevel0O25( ) ;
         Gx_mode = sMode25;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
      }

      protected void OnDeleteControls0O25( )
      {
         standaloneModal( ) ;
         if ( AnyError == 0 )
         {
            /* Delete mode formulas */
            AV13Pgmname = "XT_Log";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13Pgmname", AV13Pgmname);
         }
      }

      protected void EndLevel0O25( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            pr_default.close(0);
         }
         if ( AnyError == 0 )
         {
            BeforeComplete0O25( ) ;
         }
         if ( AnyError == 0 )
         {
            pr_default.close(1);
            context.CommitDataStores("xt_log",pr_default);
            if ( AnyError == 0 )
            {
               ConfirmValues0O0( ) ;
            }
            /* After transaction rules */
            /* Execute 'After Trn' event if defined. */
            trnEnded = 1;
         }
         else
         {
            pr_default.close(1);
            context.RollbackDataStores("xt_log",pr_default);
         }
         IsModified = 0;
         if ( AnyError != 0 )
         {
            context.wjLoc = "";
            context.nUserReturn = 0;
         }
      }

      public void ScanStart0O25( )
      {
         /* Scan By routine */
         /* Using cursor T000O11 */
         pr_default.execute(9);
         RcdFound25 = 0;
         if ( (pr_default.getStatus(9) != 101) )
         {
            RcdFound25 = 1;
            A173XT_LogID = T000O11_A173XT_LogID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A173XT_LogID", StringUtil.LTrim( StringUtil.Str( (decimal)(A173XT_LogID), 18, 0)));
         }
         /* Load Subordinate Levels */
      }

      protected void ScanNext0O25( )
      {
         /* Scan next routine */
         pr_default.readNext(9);
         RcdFound25 = 0;
         if ( (pr_default.getStatus(9) != 101) )
         {
            RcdFound25 = 1;
            A173XT_LogID = T000O11_A173XT_LogID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A173XT_LogID", StringUtil.LTrim( StringUtil.Str( (decimal)(A173XT_LogID), 18, 0)));
         }
      }

      protected void ScanEnd0O25( )
      {
         pr_default.close(9);
      }

      protected void AfterConfirm0O25( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert0O25( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate0O25( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete0O25( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete0O25( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate0O25( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes0O25( )
      {
         edtXT_LogSecUserName_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtXT_LogSecUserName_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtXT_LogSecUserName_Enabled), 5, 0)), true);
         edtXT_LogTime_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtXT_LogTime_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtXT_LogTime_Enabled), 5, 0)), true);
         edtXT_LogProviderName_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtXT_LogProviderName_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtXT_LogProviderName_Enabled), 5, 0)), true);
         edtXT_LogTargetModule_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtXT_LogTargetModule_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtXT_LogTargetModule_Enabled), 5, 0)), true);
         edtXT_LogTarget_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtXT_LogTarget_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtXT_LogTarget_Enabled), 5, 0)), true);
         edtXT_LogDescription_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtXT_LogDescription_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtXT_LogDescription_Enabled), 5, 0)), true);
         edtXT_LogID_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtXT_LogID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtXT_LogID_Enabled), 5, 0)), true);
         edtXT_LogUserID_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtXT_LogUserID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtXT_LogUserID_Enabled), 5, 0)), true);
         edtXT_LogPage_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtXT_LogPage_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtXT_LogPage_Enabled), 5, 0)), true);
         edtXT_LogButtonName_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtXT_LogButtonName_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtXT_LogButtonName_Enabled), 5, 0)), true);
         edtXT_LogType_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtXT_LogType_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtXT_LogType_Enabled), 5, 0)), true);
         edtXT_LogProviderID_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtXT_LogProviderID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtXT_LogProviderID_Enabled), 5, 0)), true);
         edtXT_LogSonTarget_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtXT_LogSonTarget_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtXT_LogSonTarget_Enabled), 5, 0)), true);
         edtXT_LogTargetSonModule_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtXT_LogTargetSonModule_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtXT_LogTargetSonModule_Enabled), 5, 0)), true);
         cmbXT_LogTargetOperate.Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbXT_LogTargetOperate_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(cmbXT_LogTargetOperate.Enabled), 5, 0)), true);
      }

      protected void send_integrity_lvl_hashes0O25( )
      {
      }

      protected void assign_properties_default( )
      {
      }

      protected void ConfirmValues0O0( )
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
         context.AddJavascriptSource("gxcfg.js", "?2020227937255", false);
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
         bodyStyle = bodyStyle + "-moz-opacity:0;opacity:0;";
         if ( ! ( String.IsNullOrEmpty(StringUtil.RTrim( Form.Background)) ) )
         {
            bodyStyle = bodyStyle + " background-image:url(" + context.convertURL( Form.Background) + ")";
         }
         context.WriteHtmlText( " "+"class=\"form-horizontal Form\""+" "+ "style='"+bodyStyle+"'") ;
         context.WriteHtmlText( FormProcess+">") ;
         context.skipLines(1);
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" autocomplete=\"off\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("xt_log.aspx") + "?" + UrlEncode(StringUtil.RTrim(Gx_mode)) + "," + UrlEncode("" +AV7XT_LogID)+"\">") ;
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
         forbiddenHiddens = "hsh" + "XT_Log";
         forbiddenHiddens = forbiddenHiddens + context.localUtil.Format( (decimal)(A173XT_LogID), "ZZZZZZZZZZZZZZZZZZ");
         forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!"));
         GxWebStd.gx_hidden_field( context, "hsh", GetEncryptedHash( forbiddenHiddens, GXKey));
         GXUtil.WriteLog("xt_log:[SendSecurityCheck value for]"+"XT_LogID:"+context.localUtil.Format( (decimal)(A173XT_LogID), "ZZZZZZZZZZZZZZZZZZ"));
         GXUtil.WriteLog("xt_log:[SendSecurityCheck value for]"+"Gx_mode:"+StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")));
      }

      protected void SendCloseFormHiddens( )
      {
         /* Send hidden variables. */
         /* Send saved values. */
         send_integrity_footer_hashes( ) ;
         GxWebStd.gx_hidden_field( context, "Z173XT_LogID", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z173XT_LogID), 18, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "Z214XT_LogUserID", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z214XT_LogUserID), 18, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "Z174XT_LogSecUserName", Z174XT_LogSecUserName);
         GxWebStd.gx_hidden_field( context, "Z220XT_LogTime", context.localUtil.TToC( Z220XT_LogTime, 10, 8, 0, 0, "/", ":", " "));
         GxWebStd.gx_hidden_field( context, "Z176XT_LogPage", Z176XT_LogPage);
         GxWebStd.gx_hidden_field( context, "Z177XT_LogButtonName", Z177XT_LogButtonName);
         GxWebStd.gx_hidden_field( context, "Z213XT_LogType", Z213XT_LogType);
         GxWebStd.gx_hidden_field( context, "Z215XT_LogProviderID", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z215XT_LogProviderID), 18, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "Z219XT_LogProviderName", Z219XT_LogProviderName);
         GxWebStd.gx_hidden_field( context, "Z216XT_LogTarget", Z216XT_LogTarget);
         GxWebStd.gx_hidden_field( context, "Z223XT_LogSonTarget", Z223XT_LogSonTarget);
         GxWebStd.gx_hidden_field( context, "Z217XT_LogTargetModule", Z217XT_LogTargetModule);
         GxWebStd.gx_hidden_field( context, "Z222XT_LogTargetSonModule", Z222XT_LogTargetSonModule);
         GxWebStd.gx_hidden_field( context, "Z218XT_LogTargetOperate", Z218XT_LogTargetOperate);
         GxWebStd.gx_hidden_field( context, "Z221XT_LogDescription", Z221XT_LogDescription);
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
         GxWebStd.gx_hidden_field( context, "vXT_LOGID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV7XT_LogID), 18, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "gxhash_vXT_LOGID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV7XT_LogID), "ZZZZZZZZZZZZZZZZZZ"), context));
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
         return formatLink("xt_log.aspx") + "?" + UrlEncode(StringUtil.RTrim(Gx_mode)) + "," + UrlEncode("" +AV7XT_LogID) ;
      }

      public override String GetPgmname( )
      {
         return "XT_Log" ;
      }

      public override String GetPgmdesc( )
      {
         return "系统日志" ;
      }

      protected void InitializeNonKey0O25( )
      {
         A214XT_LogUserID = 0;
         n214XT_LogUserID = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A214XT_LogUserID", StringUtil.LTrim( StringUtil.Str( (decimal)(A214XT_LogUserID), 18, 0)));
         n214XT_LogUserID = ((0==A214XT_LogUserID) ? true : false);
         A174XT_LogSecUserName = "";
         n174XT_LogSecUserName = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A174XT_LogSecUserName", A174XT_LogSecUserName);
         n174XT_LogSecUserName = (String.IsNullOrEmpty(StringUtil.RTrim( A174XT_LogSecUserName)) ? true : false);
         A220XT_LogTime = (DateTime)(DateTime.MinValue);
         n220XT_LogTime = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A220XT_LogTime", context.localUtil.TToC( A220XT_LogTime, 10, 8, 0, 0, "/", ":", " "));
         n220XT_LogTime = ((DateTime.MinValue==A220XT_LogTime) ? true : false);
         A176XT_LogPage = "";
         n176XT_LogPage = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A176XT_LogPage", A176XT_LogPage);
         n176XT_LogPage = (String.IsNullOrEmpty(StringUtil.RTrim( A176XT_LogPage)) ? true : false);
         A177XT_LogButtonName = "";
         n177XT_LogButtonName = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A177XT_LogButtonName", A177XT_LogButtonName);
         n177XT_LogButtonName = (String.IsNullOrEmpty(StringUtil.RTrim( A177XT_LogButtonName)) ? true : false);
         A213XT_LogType = "";
         n213XT_LogType = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A213XT_LogType", A213XT_LogType);
         n213XT_LogType = (String.IsNullOrEmpty(StringUtil.RTrim( A213XT_LogType)) ? true : false);
         A215XT_LogProviderID = 0;
         n215XT_LogProviderID = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A215XT_LogProviderID", StringUtil.LTrim( StringUtil.Str( (decimal)(A215XT_LogProviderID), 18, 0)));
         n215XT_LogProviderID = ((0==A215XT_LogProviderID) ? true : false);
         A219XT_LogProviderName = "";
         n219XT_LogProviderName = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A219XT_LogProviderName", A219XT_LogProviderName);
         n219XT_LogProviderName = (String.IsNullOrEmpty(StringUtil.RTrim( A219XT_LogProviderName)) ? true : false);
         A216XT_LogTarget = "";
         n216XT_LogTarget = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A216XT_LogTarget", A216XT_LogTarget);
         n216XT_LogTarget = (String.IsNullOrEmpty(StringUtil.RTrim( A216XT_LogTarget)) ? true : false);
         A223XT_LogSonTarget = "";
         n223XT_LogSonTarget = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A223XT_LogSonTarget", A223XT_LogSonTarget);
         n223XT_LogSonTarget = (String.IsNullOrEmpty(StringUtil.RTrim( A223XT_LogSonTarget)) ? true : false);
         A217XT_LogTargetModule = "";
         n217XT_LogTargetModule = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A217XT_LogTargetModule", A217XT_LogTargetModule);
         n217XT_LogTargetModule = (String.IsNullOrEmpty(StringUtil.RTrim( A217XT_LogTargetModule)) ? true : false);
         A222XT_LogTargetSonModule = "";
         n222XT_LogTargetSonModule = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A222XT_LogTargetSonModule", A222XT_LogTargetSonModule);
         n222XT_LogTargetSonModule = (String.IsNullOrEmpty(StringUtil.RTrim( A222XT_LogTargetSonModule)) ? true : false);
         A218XT_LogTargetOperate = "";
         n218XT_LogTargetOperate = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A218XT_LogTargetOperate", A218XT_LogTargetOperate);
         n218XT_LogTargetOperate = (String.IsNullOrEmpty(StringUtil.RTrim( A218XT_LogTargetOperate)) ? true : false);
         A221XT_LogDescription = "";
         n221XT_LogDescription = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A221XT_LogDescription", A221XT_LogDescription);
         n221XT_LogDescription = (String.IsNullOrEmpty(StringUtil.RTrim( A221XT_LogDescription)) ? true : false);
         Z214XT_LogUserID = 0;
         Z174XT_LogSecUserName = "";
         Z220XT_LogTime = (DateTime)(DateTime.MinValue);
         Z176XT_LogPage = "";
         Z177XT_LogButtonName = "";
         Z213XT_LogType = "";
         Z215XT_LogProviderID = 0;
         Z219XT_LogProviderName = "";
         Z216XT_LogTarget = "";
         Z223XT_LogSonTarget = "";
         Z217XT_LogTargetModule = "";
         Z222XT_LogTargetSonModule = "";
         Z218XT_LogTargetOperate = "";
         Z221XT_LogDescription = "";
      }

      protected void InitAll0O25( )
      {
         A173XT_LogID = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A173XT_LogID", StringUtil.LTrim( StringUtil.Str( (decimal)(A173XT_LogID), 18, 0)));
         InitializeNonKey0O25( ) ;
      }

      protected void StandaloneModalInsert( )
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
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?20202279372548", true);
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
         context.AddJavascriptSource("xt_log.js", "?20202279372548", false);
         context.AddJavascriptSource("DVelop/Bootstrap/Shared/DVelopBootstrap.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/Panel/BootstrapPanelRender.js", "", false);
         /* End function include_jscripts */
      }

      protected void init_default_properties( )
      {
         edtXT_LogSecUserName_Internalname = "XT_LOGSECUSERNAME";
         edtXT_LogTime_Internalname = "XT_LOGTIME";
         edtXT_LogProviderName_Internalname = "XT_LOGPROVIDERNAME";
         edtXT_LogTargetModule_Internalname = "XT_LOGTARGETMODULE";
         lblTextblockxt_logtarget_Internalname = "TEXTBLOCKXT_LOGTARGET";
         edtXT_LogTarget_Internalname = "XT_LOGTARGET";
         divUnnamedtablext_logtarget_Internalname = "UNNAMEDTABLEXT_LOGTARGET";
         lblTextblockxt_logdescription_Internalname = "TEXTBLOCKXT_LOGDESCRIPTION";
         edtXT_LogDescription_Internalname = "XT_LOGDESCRIPTION";
         divUnnamedtablext_logdescription_Internalname = "UNNAMEDTABLEXT_LOGDESCRIPTION";
         divTableattributes_Internalname = "TABLEATTRIBUTES";
         divLayout_tableattributes_Internalname = "LAYOUT_TABLEATTRIBUTES";
         Dvpanel_tableattributes_Internalname = "DVPANEL_TABLEATTRIBUTES";
         divHtml_dvpanel_tableattributes_Internalname = "HTML_DVPANEL_TABLEATTRIBUTES";
         divTablecontent_Internalname = "TABLECONTENT";
         bttBtntrn_enter_Internalname = "BTNTRN_ENTER";
         bttBtntrn_cancel_Internalname = "BTNTRN_CANCEL";
         divTablemain_Internalname = "TABLEMAIN";
         edtXT_LogID_Internalname = "XT_LOGID";
         edtXT_LogUserID_Internalname = "XT_LOGUSERID";
         edtXT_LogPage_Internalname = "XT_LOGPAGE";
         edtXT_LogButtonName_Internalname = "XT_LOGBUTTONNAME";
         edtXT_LogType_Internalname = "XT_LOGTYPE";
         edtXT_LogProviderID_Internalname = "XT_LOGPROVIDERID";
         edtXT_LogSonTarget_Internalname = "XT_LOGSONTARGET";
         edtXT_LogTargetSonModule_Internalname = "XT_LOGTARGETSONMODULE";
         cmbXT_LogTargetOperate_Internalname = "XT_LOGTARGETOPERATE";
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
         Form.Caption = "系统日志";
         cmbXT_LogTargetOperate_Jsonclick = "";
         cmbXT_LogTargetOperate.Enabled = 1;
         cmbXT_LogTargetOperate.Visible = 1;
         edtXT_LogTargetSonModule_Jsonclick = "";
         edtXT_LogTargetSonModule_Enabled = 1;
         edtXT_LogTargetSonModule_Visible = 1;
         edtXT_LogSonTarget_Jsonclick = "";
         edtXT_LogSonTarget_Enabled = 1;
         edtXT_LogSonTarget_Visible = 1;
         edtXT_LogProviderID_Jsonclick = "";
         edtXT_LogProviderID_Enabled = 1;
         edtXT_LogProviderID_Visible = 1;
         edtXT_LogType_Jsonclick = "";
         edtXT_LogType_Enabled = 1;
         edtXT_LogType_Visible = 1;
         edtXT_LogButtonName_Jsonclick = "";
         edtXT_LogButtonName_Enabled = 1;
         edtXT_LogButtonName_Visible = 1;
         edtXT_LogPage_Jsonclick = "";
         edtXT_LogPage_Enabled = 1;
         edtXT_LogPage_Visible = 1;
         edtXT_LogUserID_Jsonclick = "";
         edtXT_LogUserID_Enabled = 1;
         edtXT_LogUserID_Visible = 1;
         edtXT_LogID_Jsonclick = "";
         edtXT_LogID_Enabled = 0;
         edtXT_LogID_Visible = 1;
         bttBtntrn_cancel_Visible = 1;
         bttBtntrn_enter_Enabled = 1;
         bttBtntrn_enter_Visible = 1;
         edtXT_LogDescription_Enabled = 1;
         edtXT_LogTarget_Enabled = 1;
         edtXT_LogTargetModule_Jsonclick = "";
         edtXT_LogTargetModule_Enabled = 1;
         edtXT_LogProviderName_Jsonclick = "";
         edtXT_LogProviderName_Enabled = 1;
         edtXT_LogTime_Jsonclick = "";
         edtXT_LogTime_Enabled = 1;
         edtXT_LogSecUserName_Jsonclick = "";
         edtXT_LogSecUserName_Enabled = 1;
         Dvpanel_tableattributes_Autoscroll = Convert.ToBoolean( 0);
         Dvpanel_tableattributes_Iconposition = "left";
         Dvpanel_tableattributes_Showcollapseicon = Convert.ToBoolean( 0);
         Dvpanel_tableattributes_Collapsed = Convert.ToBoolean( 0);
         Dvpanel_tableattributes_Collapsible = Convert.ToBoolean( 0);
         Dvpanel_tableattributes_Title = "日志信息";
         Dvpanel_tableattributes_Cls = "PanelCard_BaseColor";
         Dvpanel_tableattributes_Autoheight = Convert.ToBoolean( -1);
         Dvpanel_tableattributes_Autowidth = Convert.ToBoolean( 0);
         Dvpanel_tableattributes_Width = "100%";
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
         cmbXT_LogTargetOperate.Name = "XT_LOGTARGETOPERATE";
         cmbXT_LogTargetOperate.WebTags = "";
         cmbXT_LogTargetOperate.addItem("Create", "新增", 0);
         cmbXT_LogTargetOperate.addItem("Update", "编辑", 0);
         cmbXT_LogTargetOperate.addItem("Delete", "删除", 0);
         cmbXT_LogTargetOperate.addItem("Create", "保存", 0);
         cmbXT_LogTargetOperate.addItem("Submit", "提交审批", 0);
         cmbXT_LogTargetOperate.addItem("Batchcheck", "批量初审", 0);
         cmbXT_LogTargetOperate.addItem("Batchapprove", "批量复审", 0);
         cmbXT_LogTargetOperate.addItem("Randomcheckpass", "初审抽查通过", 0);
         cmbXT_LogTargetOperate.addItem("Randomcheckrefuse", "初审抽查不通过", 0);
         cmbXT_LogTargetOperate.addItem("Randomapprovepass", "复审抽查通过", 0);
         cmbXT_LogTargetOperate.addItem("Randomapproverefuse", "复审抽查不通过", 0);
         cmbXT_LogTargetOperate.addItem("Check", "初审通过", 0);
         cmbXT_LogTargetOperate.addItem("Approve", "复审通过", 0);
         cmbXT_LogTargetOperate.addItem("Reupdate", "重新修改", 0);
         cmbXT_LogTargetOperate.addItem("Login", "登录", 0);
         if ( cmbXT_LogTargetOperate.ItemCount > 0 )
         {
            A218XT_LogTargetOperate = cmbXT_LogTargetOperate.getValidValue(A218XT_LogTargetOperate);
            n218XT_LogTargetOperate = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A218XT_LogTargetOperate", A218XT_LogTargetOperate);
         }
         /* End function init_web_controls */
      }

      public override bool SupportAjaxEvent( )
      {
         return true ;
      }

      public override void InitializeDynEvents( )
      {
         setEventMetadata("ENTER","{handler:'UserMainFullajax',iparms:[{postForm:true},{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV7XT_LogID',fld:'vXT_LOGID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true}]");
         setEventMetadata("ENTER",",oparms:[]}");
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV7XT_LogID',fld:'vXT_LOGID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true},{av:'A173XT_LogID',fld:'XT_LOGID',pic:'ZZZZZZZZZZZZZZZZZZ'}]");
         setEventMetadata("REFRESH",",oparms:[]}");
         setEventMetadata("AFTER TRN","{handler:'E120O2',iparms:[{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV11TrnContext',fld:'vTRNCONTEXT',pic:''}]");
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
         Z174XT_LogSecUserName = "";
         Z220XT_LogTime = (DateTime)(DateTime.MinValue);
         Z176XT_LogPage = "";
         Z177XT_LogButtonName = "";
         Z213XT_LogType = "";
         Z219XT_LogProviderName = "";
         Z216XT_LogTarget = "";
         Z223XT_LogSonTarget = "";
         Z217XT_LogTargetModule = "";
         Z222XT_LogTargetSonModule = "";
         Z218XT_LogTargetOperate = "";
         Z221XT_LogDescription = "";
         scmdbuf = "";
         gxfirstwebparm = "";
         gxfirstwebparm_bkp = "";
         GXKey = "";
         PreviousTooltip = "";
         PreviousCaption = "";
         Form = new GXWebForm();
         GX_FocusControl = "";
         A218XT_LogTargetOperate = "";
         ucDvpanel_tableattributes = new GXUserControl();
         TempTags = "";
         A174XT_LogSecUserName = "";
         A220XT_LogTime = (DateTime)(DateTime.MinValue);
         A219XT_LogProviderName = "";
         A217XT_LogTargetModule = "";
         lblTextblockxt_logtarget_Jsonclick = "";
         ClassString = "";
         StyleString = "";
         A216XT_LogTarget = "";
         lblTextblockxt_logdescription_Jsonclick = "";
         A221XT_LogDescription = "";
         bttBtntrn_enter_Jsonclick = "";
         bttBtntrn_cancel_Jsonclick = "";
         A176XT_LogPage = "";
         A177XT_LogButtonName = "";
         A213XT_LogType = "";
         A223XT_LogSonTarget = "";
         A222XT_LogTargetSonModule = "";
         AV13Pgmname = "";
         Dvpanel_tableattributes_Objectcall = "";
         Dvpanel_tableattributes_Class = "";
         Dvpanel_tableattributes_Height = "";
         forbiddenHiddens = "";
         hsh = "";
         sMode25 = "";
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         AV8WWPContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPContext(context);
         AV11TrnContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext(context);
         AV12WebSession = context.GetSession();
         T000O4_A173XT_LogID = new long[1] ;
         T000O4_A214XT_LogUserID = new long[1] ;
         T000O4_n214XT_LogUserID = new bool[] {false} ;
         T000O4_A174XT_LogSecUserName = new String[] {""} ;
         T000O4_n174XT_LogSecUserName = new bool[] {false} ;
         T000O4_A220XT_LogTime = new DateTime[] {DateTime.MinValue} ;
         T000O4_n220XT_LogTime = new bool[] {false} ;
         T000O4_A176XT_LogPage = new String[] {""} ;
         T000O4_n176XT_LogPage = new bool[] {false} ;
         T000O4_A177XT_LogButtonName = new String[] {""} ;
         T000O4_n177XT_LogButtonName = new bool[] {false} ;
         T000O4_A213XT_LogType = new String[] {""} ;
         T000O4_n213XT_LogType = new bool[] {false} ;
         T000O4_A215XT_LogProviderID = new long[1] ;
         T000O4_n215XT_LogProviderID = new bool[] {false} ;
         T000O4_A219XT_LogProviderName = new String[] {""} ;
         T000O4_n219XT_LogProviderName = new bool[] {false} ;
         T000O4_A216XT_LogTarget = new String[] {""} ;
         T000O4_n216XT_LogTarget = new bool[] {false} ;
         T000O4_A223XT_LogSonTarget = new String[] {""} ;
         T000O4_n223XT_LogSonTarget = new bool[] {false} ;
         T000O4_A217XT_LogTargetModule = new String[] {""} ;
         T000O4_n217XT_LogTargetModule = new bool[] {false} ;
         T000O4_A222XT_LogTargetSonModule = new String[] {""} ;
         T000O4_n222XT_LogTargetSonModule = new bool[] {false} ;
         T000O4_A218XT_LogTargetOperate = new String[] {""} ;
         T000O4_n218XT_LogTargetOperate = new bool[] {false} ;
         T000O4_A221XT_LogDescription = new String[] {""} ;
         T000O4_n221XT_LogDescription = new bool[] {false} ;
         T000O5_A173XT_LogID = new long[1] ;
         T000O3_A173XT_LogID = new long[1] ;
         T000O3_A214XT_LogUserID = new long[1] ;
         T000O3_n214XT_LogUserID = new bool[] {false} ;
         T000O3_A174XT_LogSecUserName = new String[] {""} ;
         T000O3_n174XT_LogSecUserName = new bool[] {false} ;
         T000O3_A220XT_LogTime = new DateTime[] {DateTime.MinValue} ;
         T000O3_n220XT_LogTime = new bool[] {false} ;
         T000O3_A176XT_LogPage = new String[] {""} ;
         T000O3_n176XT_LogPage = new bool[] {false} ;
         T000O3_A177XT_LogButtonName = new String[] {""} ;
         T000O3_n177XT_LogButtonName = new bool[] {false} ;
         T000O3_A213XT_LogType = new String[] {""} ;
         T000O3_n213XT_LogType = new bool[] {false} ;
         T000O3_A215XT_LogProviderID = new long[1] ;
         T000O3_n215XT_LogProviderID = new bool[] {false} ;
         T000O3_A219XT_LogProviderName = new String[] {""} ;
         T000O3_n219XT_LogProviderName = new bool[] {false} ;
         T000O3_A216XT_LogTarget = new String[] {""} ;
         T000O3_n216XT_LogTarget = new bool[] {false} ;
         T000O3_A223XT_LogSonTarget = new String[] {""} ;
         T000O3_n223XT_LogSonTarget = new bool[] {false} ;
         T000O3_A217XT_LogTargetModule = new String[] {""} ;
         T000O3_n217XT_LogTargetModule = new bool[] {false} ;
         T000O3_A222XT_LogTargetSonModule = new String[] {""} ;
         T000O3_n222XT_LogTargetSonModule = new bool[] {false} ;
         T000O3_A218XT_LogTargetOperate = new String[] {""} ;
         T000O3_n218XT_LogTargetOperate = new bool[] {false} ;
         T000O3_A221XT_LogDescription = new String[] {""} ;
         T000O3_n221XT_LogDescription = new bool[] {false} ;
         T000O6_A173XT_LogID = new long[1] ;
         T000O7_A173XT_LogID = new long[1] ;
         T000O2_A173XT_LogID = new long[1] ;
         T000O2_A214XT_LogUserID = new long[1] ;
         T000O2_n214XT_LogUserID = new bool[] {false} ;
         T000O2_A174XT_LogSecUserName = new String[] {""} ;
         T000O2_n174XT_LogSecUserName = new bool[] {false} ;
         T000O2_A220XT_LogTime = new DateTime[] {DateTime.MinValue} ;
         T000O2_n220XT_LogTime = new bool[] {false} ;
         T000O2_A176XT_LogPage = new String[] {""} ;
         T000O2_n176XT_LogPage = new bool[] {false} ;
         T000O2_A177XT_LogButtonName = new String[] {""} ;
         T000O2_n177XT_LogButtonName = new bool[] {false} ;
         T000O2_A213XT_LogType = new String[] {""} ;
         T000O2_n213XT_LogType = new bool[] {false} ;
         T000O2_A215XT_LogProviderID = new long[1] ;
         T000O2_n215XT_LogProviderID = new bool[] {false} ;
         T000O2_A219XT_LogProviderName = new String[] {""} ;
         T000O2_n219XT_LogProviderName = new bool[] {false} ;
         T000O2_A216XT_LogTarget = new String[] {""} ;
         T000O2_n216XT_LogTarget = new bool[] {false} ;
         T000O2_A223XT_LogSonTarget = new String[] {""} ;
         T000O2_n223XT_LogSonTarget = new bool[] {false} ;
         T000O2_A217XT_LogTargetModule = new String[] {""} ;
         T000O2_n217XT_LogTargetModule = new bool[] {false} ;
         T000O2_A222XT_LogTargetSonModule = new String[] {""} ;
         T000O2_n222XT_LogTargetSonModule = new bool[] {false} ;
         T000O2_A218XT_LogTargetOperate = new String[] {""} ;
         T000O2_n218XT_LogTargetOperate = new bool[] {false} ;
         T000O2_A221XT_LogDescription = new String[] {""} ;
         T000O2_n221XT_LogDescription = new bool[] {false} ;
         T000O8_A173XT_LogID = new long[1] ;
         T000O11_A173XT_LogID = new long[1] ;
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         pr_datastore1 = new DataStoreProvider(context, new GeneXus.Programs.xt_log__datastore1(),
            new Object[][] {
            }
         );
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.xt_log__default(),
            new Object[][] {
                new Object[] {
               T000O2_A173XT_LogID, T000O2_A214XT_LogUserID, T000O2_n214XT_LogUserID, T000O2_A174XT_LogSecUserName, T000O2_n174XT_LogSecUserName, T000O2_A220XT_LogTime, T000O2_n220XT_LogTime, T000O2_A176XT_LogPage, T000O2_n176XT_LogPage, T000O2_A177XT_LogButtonName,
               T000O2_n177XT_LogButtonName, T000O2_A213XT_LogType, T000O2_n213XT_LogType, T000O2_A215XT_LogProviderID, T000O2_n215XT_LogProviderID, T000O2_A219XT_LogProviderName, T000O2_n219XT_LogProviderName, T000O2_A216XT_LogTarget, T000O2_n216XT_LogTarget, T000O2_A223XT_LogSonTarget,
               T000O2_n223XT_LogSonTarget, T000O2_A217XT_LogTargetModule, T000O2_n217XT_LogTargetModule, T000O2_A222XT_LogTargetSonModule, T000O2_n222XT_LogTargetSonModule, T000O2_A218XT_LogTargetOperate, T000O2_n218XT_LogTargetOperate, T000O2_A221XT_LogDescription, T000O2_n221XT_LogDescription
               }
               , new Object[] {
               T000O3_A173XT_LogID, T000O3_A214XT_LogUserID, T000O3_n214XT_LogUserID, T000O3_A174XT_LogSecUserName, T000O3_n174XT_LogSecUserName, T000O3_A220XT_LogTime, T000O3_n220XT_LogTime, T000O3_A176XT_LogPage, T000O3_n176XT_LogPage, T000O3_A177XT_LogButtonName,
               T000O3_n177XT_LogButtonName, T000O3_A213XT_LogType, T000O3_n213XT_LogType, T000O3_A215XT_LogProviderID, T000O3_n215XT_LogProviderID, T000O3_A219XT_LogProviderName, T000O3_n219XT_LogProviderName, T000O3_A216XT_LogTarget, T000O3_n216XT_LogTarget, T000O3_A223XT_LogSonTarget,
               T000O3_n223XT_LogSonTarget, T000O3_A217XT_LogTargetModule, T000O3_n217XT_LogTargetModule, T000O3_A222XT_LogTargetSonModule, T000O3_n222XT_LogTargetSonModule, T000O3_A218XT_LogTargetOperate, T000O3_n218XT_LogTargetOperate, T000O3_A221XT_LogDescription, T000O3_n221XT_LogDescription
               }
               , new Object[] {
               T000O4_A173XT_LogID, T000O4_A214XT_LogUserID, T000O4_n214XT_LogUserID, T000O4_A174XT_LogSecUserName, T000O4_n174XT_LogSecUserName, T000O4_A220XT_LogTime, T000O4_n220XT_LogTime, T000O4_A176XT_LogPage, T000O4_n176XT_LogPage, T000O4_A177XT_LogButtonName,
               T000O4_n177XT_LogButtonName, T000O4_A213XT_LogType, T000O4_n213XT_LogType, T000O4_A215XT_LogProviderID, T000O4_n215XT_LogProviderID, T000O4_A219XT_LogProviderName, T000O4_n219XT_LogProviderName, T000O4_A216XT_LogTarget, T000O4_n216XT_LogTarget, T000O4_A223XT_LogSonTarget,
               T000O4_n223XT_LogSonTarget, T000O4_A217XT_LogTargetModule, T000O4_n217XT_LogTargetModule, T000O4_A222XT_LogTargetSonModule, T000O4_n222XT_LogTargetSonModule, T000O4_A218XT_LogTargetOperate, T000O4_n218XT_LogTargetOperate, T000O4_A221XT_LogDescription, T000O4_n221XT_LogDescription
               }
               , new Object[] {
               T000O5_A173XT_LogID
               }
               , new Object[] {
               T000O6_A173XT_LogID
               }
               , new Object[] {
               T000O7_A173XT_LogID
               }
               , new Object[] {
               T000O8_A173XT_LogID
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               T000O11_A173XT_LogID
               }
            }
         );
         AV13Pgmname = "XT_Log";
      }

      private short GxWebError ;
      private short gxcookieaux ;
      private short IsConfirmed ;
      private short IsModified ;
      private short AnyError ;
      private short nKeyPressed ;
      private short initialized ;
      private short RcdFound25 ;
      private short GX_JID ;
      private short Gx_BScreen ;
      private short gxajaxcallmode ;
      private int trnEnded ;
      private int edtXT_LogSecUserName_Enabled ;
      private int edtXT_LogTime_Enabled ;
      private int edtXT_LogProviderName_Enabled ;
      private int edtXT_LogTargetModule_Enabled ;
      private int edtXT_LogTarget_Enabled ;
      private int edtXT_LogDescription_Enabled ;
      private int bttBtntrn_enter_Visible ;
      private int bttBtntrn_enter_Enabled ;
      private int bttBtntrn_cancel_Visible ;
      private int edtXT_LogID_Enabled ;
      private int edtXT_LogID_Visible ;
      private int edtXT_LogUserID_Enabled ;
      private int edtXT_LogUserID_Visible ;
      private int edtXT_LogPage_Visible ;
      private int edtXT_LogPage_Enabled ;
      private int edtXT_LogButtonName_Visible ;
      private int edtXT_LogButtonName_Enabled ;
      private int edtXT_LogType_Visible ;
      private int edtXT_LogType_Enabled ;
      private int edtXT_LogProviderID_Enabled ;
      private int edtXT_LogProviderID_Visible ;
      private int edtXT_LogSonTarget_Visible ;
      private int edtXT_LogSonTarget_Enabled ;
      private int edtXT_LogTargetSonModule_Visible ;
      private int edtXT_LogTargetSonModule_Enabled ;
      private int idxLst ;
      private long wcpOAV7XT_LogID ;
      private long Z173XT_LogID ;
      private long Z214XT_LogUserID ;
      private long Z215XT_LogProviderID ;
      private long AV7XT_LogID ;
      private long A173XT_LogID ;
      private long A214XT_LogUserID ;
      private long A215XT_LogProviderID ;
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
      private String edtXT_LogSecUserName_Internalname ;
      private String cmbXT_LogTargetOperate_Internalname ;
      private String divLayoutmaintable_Internalname ;
      private String divTablemain_Internalname ;
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
      private String edtXT_LogSecUserName_Jsonclick ;
      private String edtXT_LogTime_Internalname ;
      private String edtXT_LogTime_Jsonclick ;
      private String edtXT_LogProviderName_Internalname ;
      private String edtXT_LogProviderName_Jsonclick ;
      private String edtXT_LogTargetModule_Internalname ;
      private String edtXT_LogTargetModule_Jsonclick ;
      private String divUnnamedtablext_logtarget_Internalname ;
      private String lblTextblockxt_logtarget_Internalname ;
      private String lblTextblockxt_logtarget_Jsonclick ;
      private String edtXT_LogTarget_Internalname ;
      private String ClassString ;
      private String StyleString ;
      private String divUnnamedtablext_logdescription_Internalname ;
      private String lblTextblockxt_logdescription_Internalname ;
      private String lblTextblockxt_logdescription_Jsonclick ;
      private String edtXT_LogDescription_Internalname ;
      private String bttBtntrn_enter_Internalname ;
      private String bttBtntrn_enter_Jsonclick ;
      private String bttBtntrn_cancel_Internalname ;
      private String bttBtntrn_cancel_Jsonclick ;
      private String divHtml_bottomauxiliarcontrols_Internalname ;
      private String edtXT_LogID_Internalname ;
      private String edtXT_LogID_Jsonclick ;
      private String edtXT_LogUserID_Internalname ;
      private String edtXT_LogUserID_Jsonclick ;
      private String edtXT_LogPage_Internalname ;
      private String edtXT_LogPage_Jsonclick ;
      private String edtXT_LogButtonName_Internalname ;
      private String edtXT_LogButtonName_Jsonclick ;
      private String edtXT_LogType_Internalname ;
      private String edtXT_LogType_Jsonclick ;
      private String edtXT_LogProviderID_Internalname ;
      private String edtXT_LogProviderID_Jsonclick ;
      private String edtXT_LogSonTarget_Internalname ;
      private String edtXT_LogSonTarget_Jsonclick ;
      private String edtXT_LogTargetSonModule_Internalname ;
      private String edtXT_LogTargetSonModule_Jsonclick ;
      private String cmbXT_LogTargetOperate_Jsonclick ;
      private String AV13Pgmname ;
      private String Dvpanel_tableattributes_Objectcall ;
      private String Dvpanel_tableattributes_Class ;
      private String Dvpanel_tableattributes_Height ;
      private String forbiddenHiddens ;
      private String hsh ;
      private String sMode25 ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String sDynURL ;
      private String FormProcess ;
      private String bodyStyle ;
      private DateTime Z220XT_LogTime ;
      private DateTime A220XT_LogTime ;
      private bool entryPointCalled ;
      private bool toggleJsOutput ;
      private bool wbErr ;
      private bool n218XT_LogTargetOperate ;
      private bool Dvpanel_tableattributes_Autowidth ;
      private bool Dvpanel_tableattributes_Autoheight ;
      private bool Dvpanel_tableattributes_Collapsible ;
      private bool Dvpanel_tableattributes_Collapsed ;
      private bool Dvpanel_tableattributes_Showcollapseicon ;
      private bool Dvpanel_tableattributes_Autoscroll ;
      private bool n174XT_LogSecUserName ;
      private bool n220XT_LogTime ;
      private bool n219XT_LogProviderName ;
      private bool n217XT_LogTargetModule ;
      private bool n216XT_LogTarget ;
      private bool n221XT_LogDescription ;
      private bool n214XT_LogUserID ;
      private bool n176XT_LogPage ;
      private bool n177XT_LogButtonName ;
      private bool n213XT_LogType ;
      private bool n215XT_LogProviderID ;
      private bool n223XT_LogSonTarget ;
      private bool n222XT_LogTargetSonModule ;
      private bool Dvpanel_tableattributes_Enabled ;
      private bool Dvpanel_tableattributes_Showheader ;
      private bool Dvpanel_tableattributes_Visible ;
      private bool AV9IsAuthorized ;
      private bool GXt_boolean1 ;
      private bool returnInSub ;
      private bool Gx_longc ;
      private String Z174XT_LogSecUserName ;
      private String Z176XT_LogPage ;
      private String Z177XT_LogButtonName ;
      private String Z213XT_LogType ;
      private String Z219XT_LogProviderName ;
      private String Z216XT_LogTarget ;
      private String Z223XT_LogSonTarget ;
      private String Z217XT_LogTargetModule ;
      private String Z222XT_LogTargetSonModule ;
      private String Z218XT_LogTargetOperate ;
      private String Z221XT_LogDescription ;
      private String A218XT_LogTargetOperate ;
      private String A174XT_LogSecUserName ;
      private String A219XT_LogProviderName ;
      private String A217XT_LogTargetModule ;
      private String A216XT_LogTarget ;
      private String A221XT_LogDescription ;
      private String A176XT_LogPage ;
      private String A177XT_LogButtonName ;
      private String A213XT_LogType ;
      private String A223XT_LogSonTarget ;
      private String A222XT_LogTargetSonModule ;
      private IGxSession AV12WebSession ;
      private GXUserControl ucDvpanel_tableattributes ;
      private IGxDataStore dsDataStore1 ;
      private IGxDataStore dsDefault ;
      private GXCombobox cmbXT_LogTargetOperate ;
      private IDataStoreProvider pr_default ;
      private long[] T000O4_A173XT_LogID ;
      private long[] T000O4_A214XT_LogUserID ;
      private bool[] T000O4_n214XT_LogUserID ;
      private String[] T000O4_A174XT_LogSecUserName ;
      private bool[] T000O4_n174XT_LogSecUserName ;
      private DateTime[] T000O4_A220XT_LogTime ;
      private bool[] T000O4_n220XT_LogTime ;
      private String[] T000O4_A176XT_LogPage ;
      private bool[] T000O4_n176XT_LogPage ;
      private String[] T000O4_A177XT_LogButtonName ;
      private bool[] T000O4_n177XT_LogButtonName ;
      private String[] T000O4_A213XT_LogType ;
      private bool[] T000O4_n213XT_LogType ;
      private long[] T000O4_A215XT_LogProviderID ;
      private bool[] T000O4_n215XT_LogProviderID ;
      private String[] T000O4_A219XT_LogProviderName ;
      private bool[] T000O4_n219XT_LogProviderName ;
      private String[] T000O4_A216XT_LogTarget ;
      private bool[] T000O4_n216XT_LogTarget ;
      private String[] T000O4_A223XT_LogSonTarget ;
      private bool[] T000O4_n223XT_LogSonTarget ;
      private String[] T000O4_A217XT_LogTargetModule ;
      private bool[] T000O4_n217XT_LogTargetModule ;
      private String[] T000O4_A222XT_LogTargetSonModule ;
      private bool[] T000O4_n222XT_LogTargetSonModule ;
      private String[] T000O4_A218XT_LogTargetOperate ;
      private bool[] T000O4_n218XT_LogTargetOperate ;
      private String[] T000O4_A221XT_LogDescription ;
      private bool[] T000O4_n221XT_LogDescription ;
      private long[] T000O5_A173XT_LogID ;
      private long[] T000O3_A173XT_LogID ;
      private long[] T000O3_A214XT_LogUserID ;
      private bool[] T000O3_n214XT_LogUserID ;
      private String[] T000O3_A174XT_LogSecUserName ;
      private bool[] T000O3_n174XT_LogSecUserName ;
      private DateTime[] T000O3_A220XT_LogTime ;
      private bool[] T000O3_n220XT_LogTime ;
      private String[] T000O3_A176XT_LogPage ;
      private bool[] T000O3_n176XT_LogPage ;
      private String[] T000O3_A177XT_LogButtonName ;
      private bool[] T000O3_n177XT_LogButtonName ;
      private String[] T000O3_A213XT_LogType ;
      private bool[] T000O3_n213XT_LogType ;
      private long[] T000O3_A215XT_LogProviderID ;
      private bool[] T000O3_n215XT_LogProviderID ;
      private String[] T000O3_A219XT_LogProviderName ;
      private bool[] T000O3_n219XT_LogProviderName ;
      private String[] T000O3_A216XT_LogTarget ;
      private bool[] T000O3_n216XT_LogTarget ;
      private String[] T000O3_A223XT_LogSonTarget ;
      private bool[] T000O3_n223XT_LogSonTarget ;
      private String[] T000O3_A217XT_LogTargetModule ;
      private bool[] T000O3_n217XT_LogTargetModule ;
      private String[] T000O3_A222XT_LogTargetSonModule ;
      private bool[] T000O3_n222XT_LogTargetSonModule ;
      private String[] T000O3_A218XT_LogTargetOperate ;
      private bool[] T000O3_n218XT_LogTargetOperate ;
      private String[] T000O3_A221XT_LogDescription ;
      private bool[] T000O3_n221XT_LogDescription ;
      private long[] T000O6_A173XT_LogID ;
      private long[] T000O7_A173XT_LogID ;
      private long[] T000O2_A173XT_LogID ;
      private long[] T000O2_A214XT_LogUserID ;
      private bool[] T000O2_n214XT_LogUserID ;
      private String[] T000O2_A174XT_LogSecUserName ;
      private bool[] T000O2_n174XT_LogSecUserName ;
      private DateTime[] T000O2_A220XT_LogTime ;
      private bool[] T000O2_n220XT_LogTime ;
      private String[] T000O2_A176XT_LogPage ;
      private bool[] T000O2_n176XT_LogPage ;
      private String[] T000O2_A177XT_LogButtonName ;
      private bool[] T000O2_n177XT_LogButtonName ;
      private String[] T000O2_A213XT_LogType ;
      private bool[] T000O2_n213XT_LogType ;
      private long[] T000O2_A215XT_LogProviderID ;
      private bool[] T000O2_n215XT_LogProviderID ;
      private String[] T000O2_A219XT_LogProviderName ;
      private bool[] T000O2_n219XT_LogProviderName ;
      private String[] T000O2_A216XT_LogTarget ;
      private bool[] T000O2_n216XT_LogTarget ;
      private String[] T000O2_A223XT_LogSonTarget ;
      private bool[] T000O2_n223XT_LogSonTarget ;
      private String[] T000O2_A217XT_LogTargetModule ;
      private bool[] T000O2_n217XT_LogTargetModule ;
      private String[] T000O2_A222XT_LogTargetSonModule ;
      private bool[] T000O2_n222XT_LogTargetSonModule ;
      private String[] T000O2_A218XT_LogTargetOperate ;
      private bool[] T000O2_n218XT_LogTargetOperate ;
      private String[] T000O2_A221XT_LogDescription ;
      private bool[] T000O2_n221XT_LogDescription ;
      private long[] T000O8_A173XT_LogID ;
      private long[] T000O11_A173XT_LogID ;
      private IDataStoreProvider pr_datastore1 ;
      private GXWebForm Form ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPContext AV8WWPContext ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext AV11TrnContext ;
   }

   public class xt_log__datastore1 : DataStoreHelperBase, IDataStoreHelper
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

 public class xt_log__default : DataStoreHelperBase, IDataStoreHelper
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
        Object[] prmT000O4 ;
        prmT000O4 = new Object[] {
        new Object[] {"@XT_LogID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000O5 ;
        prmT000O5 = new Object[] {
        new Object[] {"@XT_LogID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000O3 ;
        prmT000O3 = new Object[] {
        new Object[] {"@XT_LogID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000O6 ;
        prmT000O6 = new Object[] {
        new Object[] {"@XT_LogID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000O7 ;
        prmT000O7 = new Object[] {
        new Object[] {"@XT_LogID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000O2 ;
        prmT000O2 = new Object[] {
        new Object[] {"@XT_LogID",SqlDbType.Decimal,18,0}
        } ;
        /* Definition of XT_LogTarget changed to svchar length 4000 decimals 0 */
        /* Definition of XT_LogDescription changed to svchar length 4000 decimals 0 */
        Object[] prmT000O8 ;
        prmT000O8 = new Object[] {
        new Object[] {"@XT_LogUserID",SqlDbType.Decimal,18,0} ,
        new Object[] {"@XT_LogSecUserName",SqlDbType.NVarChar,100,0} ,
        new Object[] {"@XT_LogTime",SqlDbType.DateTime,10,8} ,
        new Object[] {"@XT_LogPage",SqlDbType.NVarChar,100,0} ,
        new Object[] {"@XT_LogButtonName",SqlDbType.NVarChar,50,0} ,
        new Object[] {"@XT_LogType",SqlDbType.NVarChar,100,0} ,
        new Object[] {"@XT_LogProviderID",SqlDbType.Decimal,18,0} ,
        new Object[] {"@XT_LogProviderName",SqlDbType.NVarChar,100,0} ,
        new Object[] {"@XT_LogTarget",SqlDbType.NVarChar,4000,0} ,
        new Object[] {"@XT_LogSonTarget",SqlDbType.NVarChar,100,0} ,
        new Object[] {"@XT_LogTargetModule",SqlDbType.NVarChar,100,0} ,
        new Object[] {"@XT_LogTargetSonModule",SqlDbType.NVarChar,100,0} ,
        new Object[] {"@XT_LogTargetOperate",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@XT_LogDescription",SqlDbType.NVarChar,4000,0}
        } ;
        /* Definition of XT_LogTarget changed to svchar length 4000 decimals 0 */
        /* Definition of XT_LogDescription changed to svchar length 4000 decimals 0 */
        Object[] prmT000O9 ;
        prmT000O9 = new Object[] {
        new Object[] {"@XT_LogUserID",SqlDbType.Decimal,18,0} ,
        new Object[] {"@XT_LogSecUserName",SqlDbType.NVarChar,100,0} ,
        new Object[] {"@XT_LogTime",SqlDbType.DateTime,10,8} ,
        new Object[] {"@XT_LogPage",SqlDbType.NVarChar,100,0} ,
        new Object[] {"@XT_LogButtonName",SqlDbType.NVarChar,50,0} ,
        new Object[] {"@XT_LogType",SqlDbType.NVarChar,100,0} ,
        new Object[] {"@XT_LogProviderID",SqlDbType.Decimal,18,0} ,
        new Object[] {"@XT_LogProviderName",SqlDbType.NVarChar,100,0} ,
        new Object[] {"@XT_LogTarget",SqlDbType.NVarChar,4000,0} ,
        new Object[] {"@XT_LogSonTarget",SqlDbType.NVarChar,100,0} ,
        new Object[] {"@XT_LogTargetModule",SqlDbType.NVarChar,100,0} ,
        new Object[] {"@XT_LogTargetSonModule",SqlDbType.NVarChar,100,0} ,
        new Object[] {"@XT_LogTargetOperate",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@XT_LogDescription",SqlDbType.NVarChar,4000,0} ,
        new Object[] {"@XT_LogID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000O10 ;
        prmT000O10 = new Object[] {
        new Object[] {"@XT_LogID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000O11 ;
        prmT000O11 = new Object[] {
        } ;
        def= new CursorDef[] {
            new CursorDef("T000O2", "SELECT [XT_LogID], [XT_LogUserID], [XT_LogSecUserName], [XT_LogTime], [XT_LogPage], [XT_LogButtonName], [XT_LogType], [XT_LogProviderID], [XT_LogProviderName], [XT_LogTarget], [XT_LogSonTarget], [XT_LogTargetModule], [XT_LogTargetSonModule], [XT_LogTargetOperate], [XT_LogDescription] FROM [XT_Log] WITH (UPDLOCK) WHERE [XT_LogID] = @XT_LogID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000O2,1,0,true,false )
           ,new CursorDef("T000O3", "SELECT [XT_LogID], [XT_LogUserID], [XT_LogSecUserName], [XT_LogTime], [XT_LogPage], [XT_LogButtonName], [XT_LogType], [XT_LogProviderID], [XT_LogProviderName], [XT_LogTarget], [XT_LogSonTarget], [XT_LogTargetModule], [XT_LogTargetSonModule], [XT_LogTargetOperate], [XT_LogDescription] FROM [XT_Log] WITH (NOLOCK) WHERE [XT_LogID] = @XT_LogID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000O3,1,0,true,false )
           ,new CursorDef("T000O4", "SELECT TM1.[XT_LogID], TM1.[XT_LogUserID], TM1.[XT_LogSecUserName], TM1.[XT_LogTime], TM1.[XT_LogPage], TM1.[XT_LogButtonName], TM1.[XT_LogType], TM1.[XT_LogProviderID], TM1.[XT_LogProviderName], TM1.[XT_LogTarget], TM1.[XT_LogSonTarget], TM1.[XT_LogTargetModule], TM1.[XT_LogTargetSonModule], TM1.[XT_LogTargetOperate], TM1.[XT_LogDescription] FROM [XT_Log] TM1 WITH (NOLOCK) WHERE TM1.[XT_LogID] = @XT_LogID ORDER BY TM1.[XT_LogID]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT000O4,100,0,true,false )
           ,new CursorDef("T000O5", "SELECT [XT_LogID] FROM [XT_Log] WITH (NOLOCK) WHERE [XT_LogID] = @XT_LogID  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000O5,1,0,true,false )
           ,new CursorDef("T000O6", "SELECT TOP 1 [XT_LogID] FROM [XT_Log] WITH (NOLOCK) WHERE ( [XT_LogID] > @XT_LogID) ORDER BY [XT_LogID]  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000O6,1,0,true,true )
           ,new CursorDef("T000O7", "SELECT TOP 1 [XT_LogID] FROM [XT_Log] WITH (NOLOCK) WHERE ( [XT_LogID] < @XT_LogID) ORDER BY [XT_LogID] DESC  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000O7,1,0,true,true )
           ,new CursorDef("T000O8", "INSERT INTO [XT_Log]([XT_LogUserID], [XT_LogSecUserName], [XT_LogTime], [XT_LogPage], [XT_LogButtonName], [XT_LogType], [XT_LogProviderID], [XT_LogProviderName], [XT_LogTarget], [XT_LogSonTarget], [XT_LogTargetModule], [XT_LogTargetSonModule], [XT_LogTargetOperate], [XT_LogDescription]) VALUES(@XT_LogUserID, @XT_LogSecUserName, @XT_LogTime, @XT_LogPage, @XT_LogButtonName, @XT_LogType, @XT_LogProviderID, @XT_LogProviderName, @XT_LogTarget, @XT_LogSonTarget, @XT_LogTargetModule, @XT_LogTargetSonModule, @XT_LogTargetOperate, @XT_LogDescription); SELECT SCOPE_IDENTITY()", GxErrorMask.GX_NOMASK,prmT000O8)
           ,new CursorDef("T000O9", "UPDATE [XT_Log] SET [XT_LogUserID]=@XT_LogUserID, [XT_LogSecUserName]=@XT_LogSecUserName, [XT_LogTime]=@XT_LogTime, [XT_LogPage]=@XT_LogPage, [XT_LogButtonName]=@XT_LogButtonName, [XT_LogType]=@XT_LogType, [XT_LogProviderID]=@XT_LogProviderID, [XT_LogProviderName]=@XT_LogProviderName, [XT_LogTarget]=@XT_LogTarget, [XT_LogSonTarget]=@XT_LogSonTarget, [XT_LogTargetModule]=@XT_LogTargetModule, [XT_LogTargetSonModule]=@XT_LogTargetSonModule, [XT_LogTargetOperate]=@XT_LogTargetOperate, [XT_LogDescription]=@XT_LogDescription  WHERE [XT_LogID] = @XT_LogID", GxErrorMask.GX_NOMASK,prmT000O9)
           ,new CursorDef("T000O10", "DELETE FROM [XT_Log]  WHERE [XT_LogID] = @XT_LogID", GxErrorMask.GX_NOMASK,prmT000O10)
           ,new CursorDef("T000O11", "SELECT [XT_LogID] FROM [XT_Log] WITH (NOLOCK) ORDER BY [XT_LogID]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT000O11,100,0,true,false )
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
              ((long[]) buf[1])[0] = rslt.getLong(2) ;
              ((bool[]) buf[2])[0] = rslt.wasNull(2);
              ((String[]) buf[3])[0] = rslt.getVarchar(3) ;
              ((bool[]) buf[4])[0] = rslt.wasNull(3);
              ((DateTime[]) buf[5])[0] = rslt.getGXDateTime(4) ;
              ((bool[]) buf[6])[0] = rslt.wasNull(4);
              ((String[]) buf[7])[0] = rslt.getVarchar(5) ;
              ((bool[]) buf[8])[0] = rslt.wasNull(5);
              ((String[]) buf[9])[0] = rslt.getVarchar(6) ;
              ((bool[]) buf[10])[0] = rslt.wasNull(6);
              ((String[]) buf[11])[0] = rslt.getVarchar(7) ;
              ((bool[]) buf[12])[0] = rslt.wasNull(7);
              ((long[]) buf[13])[0] = rslt.getLong(8) ;
              ((bool[]) buf[14])[0] = rslt.wasNull(8);
              ((String[]) buf[15])[0] = rslt.getVarchar(9) ;
              ((bool[]) buf[16])[0] = rslt.wasNull(9);
              ((String[]) buf[17])[0] = rslt.getVarchar(10) ;
              ((bool[]) buf[18])[0] = rslt.wasNull(10);
              ((String[]) buf[19])[0] = rslt.getVarchar(11) ;
              ((bool[]) buf[20])[0] = rslt.wasNull(11);
              ((String[]) buf[21])[0] = rslt.getVarchar(12) ;
              ((bool[]) buf[22])[0] = rslt.wasNull(12);
              ((String[]) buf[23])[0] = rslt.getVarchar(13) ;
              ((bool[]) buf[24])[0] = rslt.wasNull(13);
              ((String[]) buf[25])[0] = rslt.getVarchar(14) ;
              ((bool[]) buf[26])[0] = rslt.wasNull(14);
              ((String[]) buf[27])[0] = rslt.getVarchar(15) ;
              ((bool[]) buf[28])[0] = rslt.wasNull(15);
              return;
           case 1 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              ((long[]) buf[1])[0] = rslt.getLong(2) ;
              ((bool[]) buf[2])[0] = rslt.wasNull(2);
              ((String[]) buf[3])[0] = rslt.getVarchar(3) ;
              ((bool[]) buf[4])[0] = rslt.wasNull(3);
              ((DateTime[]) buf[5])[0] = rslt.getGXDateTime(4) ;
              ((bool[]) buf[6])[0] = rslt.wasNull(4);
              ((String[]) buf[7])[0] = rslt.getVarchar(5) ;
              ((bool[]) buf[8])[0] = rslt.wasNull(5);
              ((String[]) buf[9])[0] = rslt.getVarchar(6) ;
              ((bool[]) buf[10])[0] = rslt.wasNull(6);
              ((String[]) buf[11])[0] = rslt.getVarchar(7) ;
              ((bool[]) buf[12])[0] = rslt.wasNull(7);
              ((long[]) buf[13])[0] = rslt.getLong(8) ;
              ((bool[]) buf[14])[0] = rslt.wasNull(8);
              ((String[]) buf[15])[0] = rslt.getVarchar(9) ;
              ((bool[]) buf[16])[0] = rslt.wasNull(9);
              ((String[]) buf[17])[0] = rslt.getVarchar(10) ;
              ((bool[]) buf[18])[0] = rslt.wasNull(10);
              ((String[]) buf[19])[0] = rslt.getVarchar(11) ;
              ((bool[]) buf[20])[0] = rslt.wasNull(11);
              ((String[]) buf[21])[0] = rslt.getVarchar(12) ;
              ((bool[]) buf[22])[0] = rslt.wasNull(12);
              ((String[]) buf[23])[0] = rslt.getVarchar(13) ;
              ((bool[]) buf[24])[0] = rslt.wasNull(13);
              ((String[]) buf[25])[0] = rslt.getVarchar(14) ;
              ((bool[]) buf[26])[0] = rslt.wasNull(14);
              ((String[]) buf[27])[0] = rslt.getVarchar(15) ;
              ((bool[]) buf[28])[0] = rslt.wasNull(15);
              return;
           case 2 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              ((long[]) buf[1])[0] = rslt.getLong(2) ;
              ((bool[]) buf[2])[0] = rslt.wasNull(2);
              ((String[]) buf[3])[0] = rslt.getVarchar(3) ;
              ((bool[]) buf[4])[0] = rslt.wasNull(3);
              ((DateTime[]) buf[5])[0] = rslt.getGXDateTime(4) ;
              ((bool[]) buf[6])[0] = rslt.wasNull(4);
              ((String[]) buf[7])[0] = rslt.getVarchar(5) ;
              ((bool[]) buf[8])[0] = rslt.wasNull(5);
              ((String[]) buf[9])[0] = rslt.getVarchar(6) ;
              ((bool[]) buf[10])[0] = rslt.wasNull(6);
              ((String[]) buf[11])[0] = rslt.getVarchar(7) ;
              ((bool[]) buf[12])[0] = rslt.wasNull(7);
              ((long[]) buf[13])[0] = rslt.getLong(8) ;
              ((bool[]) buf[14])[0] = rslt.wasNull(8);
              ((String[]) buf[15])[0] = rslt.getVarchar(9) ;
              ((bool[]) buf[16])[0] = rslt.wasNull(9);
              ((String[]) buf[17])[0] = rslt.getVarchar(10) ;
              ((bool[]) buf[18])[0] = rslt.wasNull(10);
              ((String[]) buf[19])[0] = rslt.getVarchar(11) ;
              ((bool[]) buf[20])[0] = rslt.wasNull(11);
              ((String[]) buf[21])[0] = rslt.getVarchar(12) ;
              ((bool[]) buf[22])[0] = rslt.wasNull(12);
              ((String[]) buf[23])[0] = rslt.getVarchar(13) ;
              ((bool[]) buf[24])[0] = rslt.wasNull(13);
              ((String[]) buf[25])[0] = rslt.getVarchar(14) ;
              ((bool[]) buf[26])[0] = rslt.wasNull(14);
              ((String[]) buf[27])[0] = rslt.getVarchar(15) ;
              ((bool[]) buf[28])[0] = rslt.wasNull(15);
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
                 stmt.setNull( 1 , SqlDbType.Decimal );
              }
              else
              {
                 stmt.SetParameter(1, (long)parms[1]);
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
                 stmt.setNull( 3 , SqlDbType.DateTime );
              }
              else
              {
                 stmt.SetParameterDatetime(3, (DateTime)parms[5]);
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
              if ( (bool)parms[12] )
              {
                 stmt.setNull( 7 , SqlDbType.Decimal );
              }
              else
              {
                 stmt.SetParameter(7, (long)parms[13]);
              }
              if ( (bool)parms[14] )
              {
                 stmt.setNull( 8 , SqlDbType.NVarChar );
              }
              else
              {
                 stmt.SetParameter(8, (String)parms[15]);
              }
              if ( (bool)parms[16] )
              {
                 stmt.setNull( 9 , SqlDbType.NVarChar );
              }
              else
              {
                 stmt.SetParameter(9, (String)parms[17]);
              }
              if ( (bool)parms[18] )
              {
                 stmt.setNull( 10 , SqlDbType.NVarChar );
              }
              else
              {
                 stmt.SetParameter(10, (String)parms[19]);
              }
              if ( (bool)parms[20] )
              {
                 stmt.setNull( 11 , SqlDbType.NVarChar );
              }
              else
              {
                 stmt.SetParameter(11, (String)parms[21]);
              }
              if ( (bool)parms[22] )
              {
                 stmt.setNull( 12 , SqlDbType.NVarChar );
              }
              else
              {
                 stmt.SetParameter(12, (String)parms[23]);
              }
              if ( (bool)parms[24] )
              {
                 stmt.setNull( 13 , SqlDbType.NVarChar );
              }
              else
              {
                 stmt.SetParameter(13, (String)parms[25]);
              }
              if ( (bool)parms[26] )
              {
                 stmt.setNull( 14 , SqlDbType.NVarChar );
              }
              else
              {
                 stmt.SetParameter(14, (String)parms[27]);
              }
              return;
           case 7 :
              if ( (bool)parms[0] )
              {
                 stmt.setNull( 1 , SqlDbType.Decimal );
              }
              else
              {
                 stmt.SetParameter(1, (long)parms[1]);
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
                 stmt.setNull( 3 , SqlDbType.DateTime );
              }
              else
              {
                 stmt.SetParameterDatetime(3, (DateTime)parms[5]);
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
              if ( (bool)parms[12] )
              {
                 stmt.setNull( 7 , SqlDbType.Decimal );
              }
              else
              {
                 stmt.SetParameter(7, (long)parms[13]);
              }
              if ( (bool)parms[14] )
              {
                 stmt.setNull( 8 , SqlDbType.NVarChar );
              }
              else
              {
                 stmt.SetParameter(8, (String)parms[15]);
              }
              if ( (bool)parms[16] )
              {
                 stmt.setNull( 9 , SqlDbType.NVarChar );
              }
              else
              {
                 stmt.SetParameter(9, (String)parms[17]);
              }
              if ( (bool)parms[18] )
              {
                 stmt.setNull( 10 , SqlDbType.NVarChar );
              }
              else
              {
                 stmt.SetParameter(10, (String)parms[19]);
              }
              if ( (bool)parms[20] )
              {
                 stmt.setNull( 11 , SqlDbType.NVarChar );
              }
              else
              {
                 stmt.SetParameter(11, (String)parms[21]);
              }
              if ( (bool)parms[22] )
              {
                 stmt.setNull( 12 , SqlDbType.NVarChar );
              }
              else
              {
                 stmt.SetParameter(12, (String)parms[23]);
              }
              if ( (bool)parms[24] )
              {
                 stmt.setNull( 13 , SqlDbType.NVarChar );
              }
              else
              {
                 stmt.SetParameter(13, (String)parms[25]);
              }
              if ( (bool)parms[26] )
              {
                 stmt.setNull( 14 , SqlDbType.NVarChar );
              }
              else
              {
                 stmt.SetParameter(14, (String)parms[27]);
              }
              stmt.SetParameter(15, (long)parms[28]);
              return;
           case 8 :
              stmt.SetParameter(1, (long)parms[0]);
              return;
     }
  }

}

}
