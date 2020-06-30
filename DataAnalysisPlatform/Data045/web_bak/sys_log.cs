/*
               File: SYS_Log
        Description: SYS_Log
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/27/2020 9:39:3.25
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
   public class sys_log : GXDataArea, System.Web.SessionState.IRequiresSessionState
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
            Form.Meta.addItem("description", "SYS_Log", 0) ;
         }
         context.wjLoc = "";
         context.nUserReturn = 0;
         context.wbHandled = 0;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         GX_FocusControl = edtSYS_LogLogID_Internalname;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         wbErr = false;
         context.SetDefaultTheme("WorkWithPlusTheme");
         if ( ! context.IsLocalStorageSupported( ) )
         {
            context.PushCurrentUrl();
         }
      }

      public sys_log( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public sys_log( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( )
      {
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
            GxWebStd.gx_div_start( context, divTablemain_Internalname, 1, 0, "px", 0, "px", "Container FormContainer", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTitle_Internalname, "SYS_Log", "", "", lblTitle_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Title", 0, "", 1, 1, 0, "HLP_SYS_Log.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-9 col-sm-offset-3", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-action-group ActionGroup", "left", "top", " "+"data-gx-actiongroup-type=\"toolbar\""+" ", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "btn-group", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 12,'',false,'',0)\"";
            ClassString = "BtnFirst";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_first_Internalname, "", "|<", bttBtn_first_Jsonclick, 5, "|<", "", StyleString, ClassString, bttBtn_first_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"EFIRST."+"'", TempTags, "", context.GetButtonType( ), "HLP_SYS_Log.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 14,'',false,'',0)\"";
            ClassString = "BtnPrevious";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_previous_Internalname, "", "<", bttBtn_previous_Jsonclick, 5, "<", "", StyleString, ClassString, bttBtn_previous_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"EPREVIOUS."+"'", TempTags, "", context.GetButtonType( ), "HLP_SYS_Log.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 16,'',false,'',0)\"";
            ClassString = "BtnNext";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_next_Internalname, "", ">", bttBtn_next_Jsonclick, 5, ">", "", StyleString, ClassString, bttBtn_next_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ENEXT."+"'", TempTags, "", context.GetButtonType( ), "HLP_SYS_Log.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 18,'',false,'',0)\"";
            ClassString = "BtnLast";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_last_Internalname, "", ">|", bttBtn_last_Jsonclick, 5, ">|", "", StyleString, ClassString, bttBtn_last_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ELAST."+"'", TempTags, "", context.GetButtonType( ), "HLP_SYS_Log.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 20,'',false,'',0)\"";
            ClassString = "BtnSelect";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_select_Internalname, "", "选择", bttBtn_select_Jsonclick, 5, "选择", "", StyleString, ClassString, bttBtn_select_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ESELECT."+"'", TempTags, "", 2, "HLP_SYS_Log.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-9 col-sm-offset-3", "left", "top", "", "", "div");
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
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtSYS_LogLogID_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtSYS_LogLogID_Internalname, "Log ID", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 28,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtSYS_LogLogID_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A442SYS_LogLogID), 18, 0, ".", "")), ((edtSYS_LogLogID_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A442SYS_LogLogID), "ZZZZZZZZZZZZZZZZZ9")) : context.localUtil.Format( (decimal)(A442SYS_LogLogID), "ZZZZZZZZZZZZZZZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,28);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtSYS_LogLogID_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtSYS_LogLogID_Enabled, 0, "number", "1", 18, "chr", 1, "row", 18, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_SYS_Log.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtSYS_LogTenantCode_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtSYS_LogTenantCode_Internalname, "Tenant Code", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 33,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtSYS_LogTenantCode_Internalname, A372SYS_LogTenantCode, StringUtil.RTrim( context.localUtil.Format( A372SYS_LogTenantCode, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,33);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtSYS_LogTenantCode_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtSYS_LogTenantCode_Enabled, 0, "text", "", 20, "chr", 1, "row", 20, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_SYS_Log.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtSYS_LogTitle_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtSYS_LogTitle_Internalname, "Title", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 38,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtSYS_LogTitle_Internalname, A451SYS_LogTitle, StringUtil.RTrim( context.localUtil.Format( A451SYS_LogTitle, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,38);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtSYS_LogTitle_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtSYS_LogTitle_Enabled, 0, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_SYS_Log.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtSYS_LogContent_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtSYS_LogContent_Internalname, "Content", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 43,'',false,'',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtSYS_LogContent_Internalname, A450SYS_LogContent, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,43);\"", 0, 1, edtSYS_LogContent_Enabled, 0, 80, "chr", 10, "row", StyleString, ClassString, "", "", "2048", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_SYS_Log.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtSYS_LogClientIP_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtSYS_LogClientIP_Internalname, "Client IP", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 48,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtSYS_LogClientIP_Internalname, A449SYS_LogClientIP, StringUtil.RTrim( context.localUtil.Format( A449SYS_LogClientIP, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,48);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtSYS_LogClientIP_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtSYS_LogClientIP_Enabled, 0, "text", "", 15, "chr", 1, "row", 15, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_SYS_Log.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtSYS_LogModuleCode_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtSYS_LogModuleCode_Internalname, "Module Code", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 53,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtSYS_LogModuleCode_Internalname, A376SYS_LogModuleCode, StringUtil.RTrim( context.localUtil.Format( A376SYS_LogModuleCode, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,53);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtSYS_LogModuleCode_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtSYS_LogModuleCode_Enabled, 0, "text", "", 30, "chr", 1, "row", 30, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_SYS_Log.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtSYS_LogLogType_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtSYS_LogLogType_Internalname, "Log Type", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 58,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtSYS_LogLogType_Internalname, A448SYS_LogLogType, StringUtil.RTrim( context.localUtil.Format( A448SYS_LogLogType, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,58);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtSYS_LogLogType_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtSYS_LogLogType_Enabled, 0, "text", "", 30, "chr", 1, "row", 30, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_SYS_Log.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtSYS_LogCreator_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtSYS_LogCreator_Internalname, "Creator", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 63,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtSYS_LogCreator_Internalname, A378SYS_LogCreator, StringUtil.RTrim( context.localUtil.Format( A378SYS_LogCreator, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,63);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtSYS_LogCreator_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtSYS_LogCreator_Enabled, 0, "text", "", 50, "chr", 1, "row", 50, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_SYS_Log.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtSYS_LogCreateTime_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtSYS_LogCreateTime_Internalname, "Create Time", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 68,'',false,'',0)\"";
            context.WriteHtmlText( "<div id=\""+edtSYS_LogCreateTime_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtSYS_LogCreateTime_Internalname, context.localUtil.TToC( A379SYS_LogCreateTime, 10, 8, 0, 0, "/", ":", " "), context.localUtil.Format( A379SYS_LogCreateTime, "9999/99/99 99:99:99"), TempTags+" onchange=\""+"gx.date.valid_date(this, 10,'YMD',8,24,'chs',false,1);"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,68);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtSYS_LogCreateTime_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtSYS_LogCreateTime_Enabled, 0, "text", "", 19, "chr", 1, "row", 19, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_SYS_Log.htm");
            GxWebStd.gx_bitmap( context, edtSYS_LogCreateTime_Internalname+"_dp_trigger", context.GetImagePath( "61b9b5d3-dff6-4d59-9b00-da61bc2cbe93", "", context.GetTheme( )), "", "", "", "", ((1==0)||(edtSYS_LogCreateTime_Enabled==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;", "", "", "", "", "", "", "", "", 1, false, false, "", "HLP_SYS_Log.htm");
            context.WriteHtmlTextNl( "</div>") ;
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-9 col-sm-offset-3", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-action-group Confirm", "left", "top", " "+"data-gx-actiongroup-type=\"toolbar\""+" ", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 73,'',false,'',0)\"";
            ClassString = "BtnEnter";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_enter_Internalname, "", "确认", bttBtn_enter_Jsonclick, 5, "确认", "", StyleString, ClassString, bttBtn_enter_Visible, bttBtn_enter_Enabled, "standard", "'"+""+"'"+",false,"+"'"+"EENTER."+"'", TempTags, "", context.GetButtonType( ), "HLP_SYS_Log.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 75,'',false,'',0)\"";
            ClassString = "BtnCancel";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_cancel_Internalname, "", "取消", bttBtn_cancel_Jsonclick, 1, "取消", "", StyleString, ClassString, bttBtn_cancel_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ECANCEL."+"'", TempTags, "", context.GetButtonType( ), "HLP_SYS_Log.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 77,'',false,'',0)\"";
            ClassString = "BtnDelete";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_delete_Internalname, "", "删除", bttBtn_delete_Jsonclick, 5, "删除", "", StyleString, ClassString, bttBtn_delete_Visible, bttBtn_delete_Enabled, "standard", "'"+""+"'"+",false,"+"'"+"EDELETE."+"'", TempTags, "", context.GetButtonType( ), "HLP_SYS_Log.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
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
         context.wbGlbDoneStart = 1;
         assign_properties_default( ) ;
         if ( AnyError == 0 )
         {
            if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
            {
               /* Read saved SDTs. */
               /* Read variables values. */
               if ( ( ( context.localUtil.CToN( cgiGet( edtSYS_LogLogID_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtSYS_LogLogID_Internalname), ".", ",") > Convert.ToDecimal( 999999999999999999L )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "SYS_LOGLOGID");
                  AnyError = 1;
                  GX_FocusControl = edtSYS_LogLogID_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A442SYS_LogLogID = 0;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A442SYS_LogLogID", StringUtil.LTrim( StringUtil.Str( (decimal)(A442SYS_LogLogID), 18, 0)));
               }
               else
               {
                  A442SYS_LogLogID = (long)(context.localUtil.CToN( cgiGet( edtSYS_LogLogID_Internalname), ".", ","));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A442SYS_LogLogID", StringUtil.LTrim( StringUtil.Str( (decimal)(A442SYS_LogLogID), 18, 0)));
               }
               A372SYS_LogTenantCode = cgiGet( edtSYS_LogTenantCode_Internalname);
               n372SYS_LogTenantCode = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A372SYS_LogTenantCode", A372SYS_LogTenantCode);
               n372SYS_LogTenantCode = (String.IsNullOrEmpty(StringUtil.RTrim( A372SYS_LogTenantCode)) ? true : false);
               A451SYS_LogTitle = cgiGet( edtSYS_LogTitle_Internalname);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A451SYS_LogTitle", A451SYS_LogTitle);
               A450SYS_LogContent = cgiGet( edtSYS_LogContent_Internalname);
               n450SYS_LogContent = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A450SYS_LogContent", A450SYS_LogContent);
               n450SYS_LogContent = (String.IsNullOrEmpty(StringUtil.RTrim( A450SYS_LogContent)) ? true : false);
               A449SYS_LogClientIP = cgiGet( edtSYS_LogClientIP_Internalname);
               n449SYS_LogClientIP = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A449SYS_LogClientIP", A449SYS_LogClientIP);
               n449SYS_LogClientIP = (String.IsNullOrEmpty(StringUtil.RTrim( A449SYS_LogClientIP)) ? true : false);
               A376SYS_LogModuleCode = cgiGet( edtSYS_LogModuleCode_Internalname);
               n376SYS_LogModuleCode = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A376SYS_LogModuleCode", A376SYS_LogModuleCode);
               n376SYS_LogModuleCode = (String.IsNullOrEmpty(StringUtil.RTrim( A376SYS_LogModuleCode)) ? true : false);
               A448SYS_LogLogType = cgiGet( edtSYS_LogLogType_Internalname);
               n448SYS_LogLogType = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A448SYS_LogLogType", A448SYS_LogLogType);
               n448SYS_LogLogType = (String.IsNullOrEmpty(StringUtil.RTrim( A448SYS_LogLogType)) ? true : false);
               A378SYS_LogCreator = cgiGet( edtSYS_LogCreator_Internalname);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A378SYS_LogCreator", A378SYS_LogCreator);
               if ( context.localUtil.VCDateTime( cgiGet( edtSYS_LogCreateTime_Internalname), 0, 0) == 0 )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_baddatetime", new   object[]  {"SYS_Log Create Time"}), 1, "SYS_LOGCREATETIME");
                  AnyError = 1;
                  GX_FocusControl = edtSYS_LogCreateTime_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A379SYS_LogCreateTime = (DateTime)(DateTime.MinValue);
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A379SYS_LogCreateTime", context.localUtil.TToC( A379SYS_LogCreateTime, 10, 8, 0, 0, "/", ":", " "));
               }
               else
               {
                  A379SYS_LogCreateTime = context.localUtil.CToT( cgiGet( edtSYS_LogCreateTime_Internalname));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A379SYS_LogCreateTime", context.localUtil.TToC( A379SYS_LogCreateTime, 10, 8, 0, 0, "/", ":", " "));
               }
               /* Read saved values. */
               Z442SYS_LogLogID = (long)(context.localUtil.CToN( cgiGet( "Z442SYS_LogLogID"), ".", ","));
               Z372SYS_LogTenantCode = cgiGet( "Z372SYS_LogTenantCode");
               n372SYS_LogTenantCode = (String.IsNullOrEmpty(StringUtil.RTrim( A372SYS_LogTenantCode)) ? true : false);
               Z451SYS_LogTitle = cgiGet( "Z451SYS_LogTitle");
               Z449SYS_LogClientIP = cgiGet( "Z449SYS_LogClientIP");
               n449SYS_LogClientIP = (String.IsNullOrEmpty(StringUtil.RTrim( A449SYS_LogClientIP)) ? true : false);
               Z376SYS_LogModuleCode = cgiGet( "Z376SYS_LogModuleCode");
               n376SYS_LogModuleCode = (String.IsNullOrEmpty(StringUtil.RTrim( A376SYS_LogModuleCode)) ? true : false);
               Z448SYS_LogLogType = cgiGet( "Z448SYS_LogLogType");
               n448SYS_LogLogType = (String.IsNullOrEmpty(StringUtil.RTrim( A448SYS_LogLogType)) ? true : false);
               Z378SYS_LogCreator = cgiGet( "Z378SYS_LogCreator");
               Z379SYS_LogCreateTime = context.localUtil.CToT( cgiGet( "Z379SYS_LogCreateTime"), 0);
               IsConfirmed = (short)(context.localUtil.CToN( cgiGet( "IsConfirmed"), ".", ","));
               IsModified = (short)(context.localUtil.CToN( cgiGet( "IsModified"), ".", ","));
               Gx_mode = cgiGet( "Mode");
               Gx_mode = cgiGet( "vMODE");
               /* Read subfile selected row values. */
               /* Read hidden variables. */
               GXKey = Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
               standaloneNotModal( ) ;
            }
            else
            {
               standaloneNotModal( ) ;
               if ( StringUtil.StrCmp(gxfirstwebparm, "viewer") == 0 )
               {
                  Gx_mode = "DSP";
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                  A442SYS_LogLogID = (long)(NumberUtil.Val( GetNextPar( ), "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A442SYS_LogLogID", StringUtil.LTrim( StringUtil.Str( (decimal)(A442SYS_LogLogID), 18, 0)));
                  getEqualNoModal( ) ;
                  Gx_mode = "DSP";
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                  disable_std_buttons_dsp( ) ;
                  standaloneModal( ) ;
               }
               else
               {
                  Gx_mode = "INS";
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                  standaloneModal( ) ;
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
                        if ( StringUtil.StrCmp(sEvt, "ENTER") == 0 )
                        {
                           context.wbHandled = 1;
                           btn_enter( ) ;
                           /* No code required for Cancel button. It is implemented as the Reset button. */
                        }
                        else if ( StringUtil.StrCmp(sEvt, "FIRST") == 0 )
                        {
                           context.wbHandled = 1;
                           btn_first( ) ;
                        }
                        else if ( StringUtil.StrCmp(sEvt, "PREVIOUS") == 0 )
                        {
                           context.wbHandled = 1;
                           btn_previous( ) ;
                        }
                        else if ( StringUtil.StrCmp(sEvt, "NEXT") == 0 )
                        {
                           context.wbHandled = 1;
                           btn_next( ) ;
                        }
                        else if ( StringUtil.StrCmp(sEvt, "LAST") == 0 )
                        {
                           context.wbHandled = 1;
                           btn_last( ) ;
                        }
                        else if ( StringUtil.StrCmp(sEvt, "SELECT") == 0 )
                        {
                           context.wbHandled = 1;
                           btn_select( ) ;
                        }
                        else if ( StringUtil.StrCmp(sEvt, "DELETE") == 0 )
                        {
                           context.wbHandled = 1;
                           btn_delete( ) ;
                        }
                        else if ( StringUtil.StrCmp(sEvt, "LSCR") == 0 )
                        {
                           context.wbHandled = 1;
                           AfterKeyLoadScreen( ) ;
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
            trnEnded = 0;
            standaloneNotModal( ) ;
            standaloneModal( ) ;
            if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  )
            {
               /* Clear variables for new insertion. */
               InitAll1L60( ) ;
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
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            bttBtn_delete_Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtn_delete_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtn_delete_Enabled), 5, 0)), true);
         }
      }

      protected void disable_std_buttons_dsp( )
      {
         bttBtn_delete_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtn_delete_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtn_delete_Visible), 5, 0)), true);
         bttBtn_first_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtn_first_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtn_first_Visible), 5, 0)), true);
         bttBtn_previous_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtn_previous_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtn_previous_Visible), 5, 0)), true);
         bttBtn_next_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtn_next_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtn_next_Visible), 5, 0)), true);
         bttBtn_last_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtn_last_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtn_last_Visible), 5, 0)), true);
         bttBtn_select_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtn_select_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtn_select_Visible), 5, 0)), true);
         bttBtn_delete_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtn_delete_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtn_delete_Visible), 5, 0)), true);
         if ( StringUtil.StrCmp(Gx_mode, "DSP") == 0 )
         {
            bttBtn_enter_Visible = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtn_enter_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtn_enter_Visible), 5, 0)), true);
         }
         DisableAttributes1L60( ) ;
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

      protected void ResetCaption1L0( )
      {
      }

      protected void ZM1L60( short GX_JID )
      {
         if ( ( GX_JID == 2 ) || ( GX_JID == 0 ) )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
            {
               Z372SYS_LogTenantCode = T001L3_A372SYS_LogTenantCode[0];
               Z451SYS_LogTitle = T001L3_A451SYS_LogTitle[0];
               Z449SYS_LogClientIP = T001L3_A449SYS_LogClientIP[0];
               Z376SYS_LogModuleCode = T001L3_A376SYS_LogModuleCode[0];
               Z448SYS_LogLogType = T001L3_A448SYS_LogLogType[0];
               Z378SYS_LogCreator = T001L3_A378SYS_LogCreator[0];
               Z379SYS_LogCreateTime = T001L3_A379SYS_LogCreateTime[0];
            }
            else
            {
               Z372SYS_LogTenantCode = A372SYS_LogTenantCode;
               Z451SYS_LogTitle = A451SYS_LogTitle;
               Z449SYS_LogClientIP = A449SYS_LogClientIP;
               Z376SYS_LogModuleCode = A376SYS_LogModuleCode;
               Z448SYS_LogLogType = A448SYS_LogLogType;
               Z378SYS_LogCreator = A378SYS_LogCreator;
               Z379SYS_LogCreateTime = A379SYS_LogCreateTime;
            }
         }
         if ( GX_JID == -2 )
         {
            Z442SYS_LogLogID = A442SYS_LogLogID;
            Z372SYS_LogTenantCode = A372SYS_LogTenantCode;
            Z451SYS_LogTitle = A451SYS_LogTitle;
            Z450SYS_LogContent = A450SYS_LogContent;
            Z449SYS_LogClientIP = A449SYS_LogClientIP;
            Z376SYS_LogModuleCode = A376SYS_LogModuleCode;
            Z448SYS_LogLogType = A448SYS_LogLogType;
            Z378SYS_LogCreator = A378SYS_LogCreator;
            Z379SYS_LogCreateTime = A379SYS_LogCreateTime;
         }
      }

      protected void standaloneNotModal( )
      {
      }

      protected void standaloneModal( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            bttBtn_delete_Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtn_delete_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtn_delete_Enabled), 5, 0)), true);
         }
         else
         {
            bttBtn_delete_Enabled = 1;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtn_delete_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtn_delete_Enabled), 5, 0)), true);
         }
         if ( StringUtil.StrCmp(Gx_mode, "DSP") == 0 )
         {
            bttBtn_enter_Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtn_enter_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtn_enter_Enabled), 5, 0)), true);
         }
         else
         {
            bttBtn_enter_Enabled = 1;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtn_enter_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtn_enter_Enabled), 5, 0)), true);
         }
      }

      protected void Load1L60( )
      {
         /* Using cursor T001L4 */
         pr_datastore1.execute(2, new Object[] {A442SYS_LogLogID});
         if ( (pr_datastore1.getStatus(2) != 101) )
         {
            RcdFound60 = 1;
            A372SYS_LogTenantCode = T001L4_A372SYS_LogTenantCode[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A372SYS_LogTenantCode", A372SYS_LogTenantCode);
            n372SYS_LogTenantCode = T001L4_n372SYS_LogTenantCode[0];
            A451SYS_LogTitle = T001L4_A451SYS_LogTitle[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A451SYS_LogTitle", A451SYS_LogTitle);
            A450SYS_LogContent = T001L4_A450SYS_LogContent[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A450SYS_LogContent", A450SYS_LogContent);
            n450SYS_LogContent = T001L4_n450SYS_LogContent[0];
            A449SYS_LogClientIP = T001L4_A449SYS_LogClientIP[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A449SYS_LogClientIP", A449SYS_LogClientIP);
            n449SYS_LogClientIP = T001L4_n449SYS_LogClientIP[0];
            A376SYS_LogModuleCode = T001L4_A376SYS_LogModuleCode[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A376SYS_LogModuleCode", A376SYS_LogModuleCode);
            n376SYS_LogModuleCode = T001L4_n376SYS_LogModuleCode[0];
            A448SYS_LogLogType = T001L4_A448SYS_LogLogType[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A448SYS_LogLogType", A448SYS_LogLogType);
            n448SYS_LogLogType = T001L4_n448SYS_LogLogType[0];
            A378SYS_LogCreator = T001L4_A378SYS_LogCreator[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A378SYS_LogCreator", A378SYS_LogCreator);
            A379SYS_LogCreateTime = T001L4_A379SYS_LogCreateTime[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A379SYS_LogCreateTime", context.localUtil.TToC( A379SYS_LogCreateTime, 10, 8, 0, 0, "/", ":", " "));
            ZM1L60( -2) ;
         }
         pr_datastore1.close(2);
         OnLoadActions1L60( ) ;
      }

      protected void OnLoadActions1L60( )
      {
      }

      protected void CheckExtendedTable1L60( )
      {
         Gx_BScreen = 1;
         standaloneModal( ) ;
         if ( ! ( (DateTime.MinValue==A379SYS_LogCreateTime) || ( A379SYS_LogCreateTime >= context.localUtil.YMDHMSToT( 1753, 1, 1, 0, 0, 0) ) ) )
         {
            GX_msglist.addItem("域SYS_Log Create Time超界", "OutOfRange", 1, "SYS_LOGCREATETIME");
            AnyError = 1;
            GX_FocusControl = edtSYS_LogCreateTime_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
      }

      protected void CloseExtendedTableCursors1L60( )
      {
      }

      protected void enableDisable( )
      {
      }

      protected void GetKey1L60( )
      {
         /* Using cursor T001L5 */
         pr_datastore1.execute(3, new Object[] {A442SYS_LogLogID});
         if ( (pr_datastore1.getStatus(3) != 101) )
         {
            RcdFound60 = 1;
         }
         else
         {
            RcdFound60 = 0;
         }
         pr_datastore1.close(3);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor T001L3 */
         pr_datastore1.execute(1, new Object[] {A442SYS_LogLogID});
         if ( (pr_datastore1.getStatus(1) != 101) )
         {
            ZM1L60( 2) ;
            RcdFound60 = 1;
            A442SYS_LogLogID = T001L3_A442SYS_LogLogID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A442SYS_LogLogID", StringUtil.LTrim( StringUtil.Str( (decimal)(A442SYS_LogLogID), 18, 0)));
            A372SYS_LogTenantCode = T001L3_A372SYS_LogTenantCode[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A372SYS_LogTenantCode", A372SYS_LogTenantCode);
            n372SYS_LogTenantCode = T001L3_n372SYS_LogTenantCode[0];
            A451SYS_LogTitle = T001L3_A451SYS_LogTitle[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A451SYS_LogTitle", A451SYS_LogTitle);
            A450SYS_LogContent = T001L3_A450SYS_LogContent[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A450SYS_LogContent", A450SYS_LogContent);
            n450SYS_LogContent = T001L3_n450SYS_LogContent[0];
            A449SYS_LogClientIP = T001L3_A449SYS_LogClientIP[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A449SYS_LogClientIP", A449SYS_LogClientIP);
            n449SYS_LogClientIP = T001L3_n449SYS_LogClientIP[0];
            A376SYS_LogModuleCode = T001L3_A376SYS_LogModuleCode[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A376SYS_LogModuleCode", A376SYS_LogModuleCode);
            n376SYS_LogModuleCode = T001L3_n376SYS_LogModuleCode[0];
            A448SYS_LogLogType = T001L3_A448SYS_LogLogType[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A448SYS_LogLogType", A448SYS_LogLogType);
            n448SYS_LogLogType = T001L3_n448SYS_LogLogType[0];
            A378SYS_LogCreator = T001L3_A378SYS_LogCreator[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A378SYS_LogCreator", A378SYS_LogCreator);
            A379SYS_LogCreateTime = T001L3_A379SYS_LogCreateTime[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A379SYS_LogCreateTime", context.localUtil.TToC( A379SYS_LogCreateTime, 10, 8, 0, 0, "/", ":", " "));
            Z442SYS_LogLogID = A442SYS_LogLogID;
            sMode60 = Gx_mode;
            Gx_mode = "DSP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            standaloneModal( ) ;
            Load1L60( ) ;
            if ( AnyError == 1 )
            {
               RcdFound60 = 0;
               InitializeNonKey1L60( ) ;
            }
            Gx_mode = sMode60;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         else
         {
            RcdFound60 = 0;
            InitializeNonKey1L60( ) ;
            sMode60 = Gx_mode;
            Gx_mode = "DSP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            standaloneModal( ) ;
            Gx_mode = sMode60;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         pr_datastore1.close(1);
      }

      protected void getEqualNoModal( )
      {
         GetKey1L60( ) ;
         if ( RcdFound60 == 0 )
         {
            Gx_mode = "INS";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         else
         {
            Gx_mode = "UPD";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         getByPrimaryKey( ) ;
      }

      protected void move_next( )
      {
         RcdFound60 = 0;
         /* Using cursor T001L6 */
         pr_datastore1.execute(4, new Object[] {A442SYS_LogLogID});
         if ( (pr_datastore1.getStatus(4) != 101) )
         {
            while ( (pr_datastore1.getStatus(4) != 101) && ( ( T001L6_A442SYS_LogLogID[0] < A442SYS_LogLogID ) ) )
            {
               pr_datastore1.readNext(4);
            }
            if ( (pr_datastore1.getStatus(4) != 101) && ( ( T001L6_A442SYS_LogLogID[0] > A442SYS_LogLogID ) ) )
            {
               A442SYS_LogLogID = T001L6_A442SYS_LogLogID[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A442SYS_LogLogID", StringUtil.LTrim( StringUtil.Str( (decimal)(A442SYS_LogLogID), 18, 0)));
               RcdFound60 = 1;
            }
         }
         pr_datastore1.close(4);
      }

      protected void move_previous( )
      {
         RcdFound60 = 0;
         /* Using cursor T001L7 */
         pr_datastore1.execute(5, new Object[] {A442SYS_LogLogID});
         if ( (pr_datastore1.getStatus(5) != 101) )
         {
            while ( (pr_datastore1.getStatus(5) != 101) && ( ( T001L7_A442SYS_LogLogID[0] > A442SYS_LogLogID ) ) )
            {
               pr_datastore1.readNext(5);
            }
            if ( (pr_datastore1.getStatus(5) != 101) && ( ( T001L7_A442SYS_LogLogID[0] < A442SYS_LogLogID ) ) )
            {
               A442SYS_LogLogID = T001L7_A442SYS_LogLogID[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A442SYS_LogLogID", StringUtil.LTrim( StringUtil.Str( (decimal)(A442SYS_LogLogID), 18, 0)));
               RcdFound60 = 1;
            }
         }
         pr_datastore1.close(5);
      }

      protected void btn_enter( )
      {
         nKeyPressed = 1;
         GetKey1L60( ) ;
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            /* Insert record */
            GX_FocusControl = edtSYS_LogLogID_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            Insert1L60( ) ;
            if ( AnyError == 1 )
            {
               GX_FocusControl = "";
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
         }
         else
         {
            if ( RcdFound60 == 1 )
            {
               if ( A442SYS_LogLogID != Z442SYS_LogLogID )
               {
                  A442SYS_LogLogID = Z442SYS_LogLogID;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A442SYS_LogLogID", StringUtil.LTrim( StringUtil.Str( (decimal)(A442SYS_LogLogID), 18, 0)));
                  GX_msglist.addItem(context.GetMessage( "GXM_getbeforeupd", ""), "CandidateKeyNotFound", 1, "SYS_LOGLOGID");
                  AnyError = 1;
                  GX_FocusControl = edtSYS_LogLogID_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
               else if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
               {
                  delete( ) ;
                  AfterTrn( ) ;
                  GX_FocusControl = edtSYS_LogLogID_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
               else
               {
                  Gx_mode = "UPD";
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                  /* Update record */
                  Update1L60( ) ;
                  GX_FocusControl = edtSYS_LogLogID_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
            }
            else
            {
               if ( A442SYS_LogLogID != Z442SYS_LogLogID )
               {
                  Gx_mode = "INS";
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                  /* Insert record */
                  GX_FocusControl = edtSYS_LogLogID_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  Insert1L60( ) ;
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
                     GX_msglist.addItem(context.GetMessage( "GXM_recdeleted", ""), 1, "SYS_LOGLOGID");
                     AnyError = 1;
                     GX_FocusControl = edtSYS_LogLogID_Internalname;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  }
                  else
                  {
                     Gx_mode = "INS";
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                     /* Insert record */
                     GX_FocusControl = edtSYS_LogLogID_Internalname;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                     Insert1L60( ) ;
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
      }

      protected void btn_delete( )
      {
         if ( A442SYS_LogLogID != Z442SYS_LogLogID )
         {
            A442SYS_LogLogID = Z442SYS_LogLogID;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A442SYS_LogLogID", StringUtil.LTrim( StringUtil.Str( (decimal)(A442SYS_LogLogID), 18, 0)));
            GX_msglist.addItem(context.GetMessage( "GXM_getbeforedlt", ""), 1, "SYS_LOGLOGID");
            AnyError = 1;
            GX_FocusControl = edtSYS_LogLogID_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         else
         {
            delete( ) ;
            AfterTrn( ) ;
            GX_FocusControl = edtSYS_LogLogID_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( AnyError != 0 )
         {
            Gx_mode = "UPD";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         else
         {
            getByPrimaryKey( ) ;
         }
         CloseOpenCursors();
      }

      protected void btn_get( )
      {
         nKeyPressed = 2;
         IsConfirmed = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "IsConfirmed", StringUtil.LTrim( StringUtil.Str( (decimal)(IsConfirmed), 4, 0)));
         getEqualNoModal( ) ;
         if ( RcdFound60 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_keynfound", ""), "PrimaryKeyNotFound", 1, "SYS_LOGLOGID");
            AnyError = 1;
            GX_FocusControl = edtSYS_LogLogID_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         GX_FocusControl = edtSYS_LogTenantCode_Internalname;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_first( )
      {
         nKeyPressed = 2;
         IsConfirmed = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "IsConfirmed", StringUtil.LTrim( StringUtil.Str( (decimal)(IsConfirmed), 4, 0)));
         ScanStart1L60( ) ;
         if ( RcdFound60 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "", true);
         }
         else
         {
            Gx_mode = "UPD";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtSYS_LogTenantCode_Internalname;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         ScanEnd1L60( ) ;
         getByPrimaryKey( ) ;
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_previous( )
      {
         nKeyPressed = 2;
         IsConfirmed = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "IsConfirmed", StringUtil.LTrim( StringUtil.Str( (decimal)(IsConfirmed), 4, 0)));
         move_previous( ) ;
         if ( RcdFound60 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "", true);
         }
         else
         {
            Gx_mode = "UPD";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtSYS_LogTenantCode_Internalname;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         getByPrimaryKey( ) ;
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_next( )
      {
         nKeyPressed = 2;
         IsConfirmed = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "IsConfirmed", StringUtil.LTrim( StringUtil.Str( (decimal)(IsConfirmed), 4, 0)));
         move_next( ) ;
         if ( RcdFound60 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "", true);
         }
         else
         {
            Gx_mode = "UPD";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtSYS_LogTenantCode_Internalname;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         getByPrimaryKey( ) ;
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_last( )
      {
         nKeyPressed = 2;
         IsConfirmed = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "IsConfirmed", StringUtil.LTrim( StringUtil.Str( (decimal)(IsConfirmed), 4, 0)));
         ScanStart1L60( ) ;
         if ( RcdFound60 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "", true);
         }
         else
         {
            while ( RcdFound60 != 0 )
            {
               ScanNext1L60( ) ;
            }
            Gx_mode = "UPD";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtSYS_LogTenantCode_Internalname;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         ScanEnd1L60( ) ;
         getByPrimaryKey( ) ;
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_select( )
      {
         getEqualNoModal( ) ;
      }

      protected void CheckOptimisticConcurrency1L60( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor T001L2 */
            pr_datastore1.execute(0, new Object[] {A442SYS_LogLogID});
            if ( (pr_datastore1.getStatus(0) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"SYS_LOG"}), "RecordIsLocked", 1, "");
               AnyError = 1;
               return  ;
            }
            Gx_longc = false;
            if ( (pr_datastore1.getStatus(0) == 101) || ( StringUtil.StrCmp(Z372SYS_LogTenantCode, T001L2_A372SYS_LogTenantCode[0]) != 0 ) || ( StringUtil.StrCmp(Z451SYS_LogTitle, T001L2_A451SYS_LogTitle[0]) != 0 ) || ( StringUtil.StrCmp(Z449SYS_LogClientIP, T001L2_A449SYS_LogClientIP[0]) != 0 ) || ( StringUtil.StrCmp(Z376SYS_LogModuleCode, T001L2_A376SYS_LogModuleCode[0]) != 0 ) || ( StringUtil.StrCmp(Z448SYS_LogLogType, T001L2_A448SYS_LogLogType[0]) != 0 ) )
            {
               Gx_longc = true;
            }
            if ( Gx_longc || ( StringUtil.StrCmp(Z378SYS_LogCreator, T001L2_A378SYS_LogCreator[0]) != 0 ) || ( Z379SYS_LogCreateTime != T001L2_A379SYS_LogCreateTime[0] ) )
            {
               if ( StringUtil.StrCmp(Z372SYS_LogTenantCode, T001L2_A372SYS_LogTenantCode[0]) != 0 )
               {
                  GXUtil.WriteLog("sys_log:[seudo value changed for attri]"+"SYS_LogTenantCode");
                  GXUtil.WriteLogRaw("Old: ",Z372SYS_LogTenantCode);
                  GXUtil.WriteLogRaw("Current: ",T001L2_A372SYS_LogTenantCode[0]);
               }
               if ( StringUtil.StrCmp(Z451SYS_LogTitle, T001L2_A451SYS_LogTitle[0]) != 0 )
               {
                  GXUtil.WriteLog("sys_log:[seudo value changed for attri]"+"SYS_LogTitle");
                  GXUtil.WriteLogRaw("Old: ",Z451SYS_LogTitle);
                  GXUtil.WriteLogRaw("Current: ",T001L2_A451SYS_LogTitle[0]);
               }
               if ( StringUtil.StrCmp(Z449SYS_LogClientIP, T001L2_A449SYS_LogClientIP[0]) != 0 )
               {
                  GXUtil.WriteLog("sys_log:[seudo value changed for attri]"+"SYS_LogClientIP");
                  GXUtil.WriteLogRaw("Old: ",Z449SYS_LogClientIP);
                  GXUtil.WriteLogRaw("Current: ",T001L2_A449SYS_LogClientIP[0]);
               }
               if ( StringUtil.StrCmp(Z376SYS_LogModuleCode, T001L2_A376SYS_LogModuleCode[0]) != 0 )
               {
                  GXUtil.WriteLog("sys_log:[seudo value changed for attri]"+"SYS_LogModuleCode");
                  GXUtil.WriteLogRaw("Old: ",Z376SYS_LogModuleCode);
                  GXUtil.WriteLogRaw("Current: ",T001L2_A376SYS_LogModuleCode[0]);
               }
               if ( StringUtil.StrCmp(Z448SYS_LogLogType, T001L2_A448SYS_LogLogType[0]) != 0 )
               {
                  GXUtil.WriteLog("sys_log:[seudo value changed for attri]"+"SYS_LogLogType");
                  GXUtil.WriteLogRaw("Old: ",Z448SYS_LogLogType);
                  GXUtil.WriteLogRaw("Current: ",T001L2_A448SYS_LogLogType[0]);
               }
               if ( StringUtil.StrCmp(Z378SYS_LogCreator, T001L2_A378SYS_LogCreator[0]) != 0 )
               {
                  GXUtil.WriteLog("sys_log:[seudo value changed for attri]"+"SYS_LogCreator");
                  GXUtil.WriteLogRaw("Old: ",Z378SYS_LogCreator);
                  GXUtil.WriteLogRaw("Current: ",T001L2_A378SYS_LogCreator[0]);
               }
               if ( Z379SYS_LogCreateTime != T001L2_A379SYS_LogCreateTime[0] )
               {
                  GXUtil.WriteLog("sys_log:[seudo value changed for attri]"+"SYS_LogCreateTime");
                  GXUtil.WriteLogRaw("Old: ",Z379SYS_LogCreateTime);
                  GXUtil.WriteLogRaw("Current: ",T001L2_A379SYS_LogCreateTime[0]);
               }
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"SYS_LOG"}), "RecordWasChanged", 1, "");
               AnyError = 1;
               return  ;
            }
         }
      }

      protected void Insert1L60( )
      {
         BeforeValidate1L60( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable1L60( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM1L60( 0) ;
            CheckOptimisticConcurrency1L60( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm1L60( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert1L60( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T001L8 */
                     pr_datastore1.execute(6, new Object[] {n372SYS_LogTenantCode, A372SYS_LogTenantCode, A451SYS_LogTitle, n450SYS_LogContent, A450SYS_LogContent, n449SYS_LogClientIP, A449SYS_LogClientIP, n376SYS_LogModuleCode, A376SYS_LogModuleCode, n448SYS_LogLogType, A448SYS_LogLogType, A378SYS_LogCreator, A379SYS_LogCreateTime});
                     A442SYS_LogLogID = T001L8_A442SYS_LogLogID[0];
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A442SYS_LogLogID", StringUtil.LTrim( StringUtil.Str( (decimal)(A442SYS_LogLogID), 18, 0)));
                     pr_datastore1.close(6);
                     dsDataStore1.SmartCacheProvider.SetUpdated("SYS_LOG") ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( Insert) rules */
                        /* End of After( Insert) rules */
                        if ( AnyError == 0 )
                        {
                           /* Save values for previous() function. */
                           GX_msglist.addItem(context.GetMessage( "GXM_sucadded", ""), "SuccessfullyAdded", 0, "", true);
                           ResetCaption1L0( ) ;
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
               Load1L60( ) ;
            }
            EndLevel1L60( ) ;
         }
         CloseExtendedTableCursors1L60( ) ;
      }

      protected void Update1L60( )
      {
         BeforeValidate1L60( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable1L60( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency1L60( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm1L60( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate1L60( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T001L9 */
                     pr_datastore1.execute(7, new Object[] {n372SYS_LogTenantCode, A372SYS_LogTenantCode, A451SYS_LogTitle, n450SYS_LogContent, A450SYS_LogContent, n449SYS_LogClientIP, A449SYS_LogClientIP, n376SYS_LogModuleCode, A376SYS_LogModuleCode, n448SYS_LogLogType, A448SYS_LogLogType, A378SYS_LogCreator, A379SYS_LogCreateTime, A442SYS_LogLogID});
                     pr_datastore1.close(7);
                     dsDataStore1.SmartCacheProvider.SetUpdated("SYS_LOG") ;
                     if ( (pr_datastore1.getStatus(7) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"SYS_LOG"}), "RecordIsLocked", 1, "");
                        AnyError = 1;
                     }
                     DeferredUpdate1L60( ) ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( update) rules */
                        /* End of After( update) rules */
                        if ( AnyError == 0 )
                        {
                           getByPrimaryKey( ) ;
                           GX_msglist.addItem(context.GetMessage( "GXM_sucupdated", ""), "SuccessfullyUpdated", 0, "", true);
                           ResetCaption1L0( ) ;
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
            EndLevel1L60( ) ;
         }
         CloseExtendedTableCursors1L60( ) ;
      }

      protected void DeferredUpdate1L60( )
      {
      }

      protected void delete( )
      {
         Gx_mode = "DLT";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         BeforeValidate1L60( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency1L60( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls1L60( ) ;
            AfterConfirm1L60( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete1L60( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor T001L10 */
                  pr_datastore1.execute(8, new Object[] {A442SYS_LogLogID});
                  pr_datastore1.close(8);
                  dsDataStore1.SmartCacheProvider.SetUpdated("SYS_LOG") ;
                  if ( AnyError == 0 )
                  {
                     /* Start of After( delete) rules */
                     /* End of After( delete) rules */
                     if ( AnyError == 0 )
                     {
                        move_next( ) ;
                        if ( RcdFound60 == 0 )
                        {
                           InitAll1L60( ) ;
                           Gx_mode = "INS";
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                        }
                        else
                        {
                           getByPrimaryKey( ) ;
                           Gx_mode = "UPD";
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                        }
                        GX_msglist.addItem(context.GetMessage( "GXM_sucdeleted", ""), "SuccessfullyDeleted", 0, "", true);
                        ResetCaption1L0( ) ;
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
         sMode60 = Gx_mode;
         Gx_mode = "DLT";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         EndLevel1L60( ) ;
         Gx_mode = sMode60;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
      }

      protected void OnDeleteControls1L60( )
      {
         standaloneModal( ) ;
         /* No delete mode formulas found. */
      }

      protected void EndLevel1L60( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            pr_datastore1.close(0);
         }
         if ( AnyError == 0 )
         {
            BeforeComplete1L60( ) ;
         }
         if ( AnyError == 0 )
         {
            pr_datastore1.close(1);
            context.CommitDataStores("sys_log",pr_default);
            if ( AnyError == 0 )
            {
               ConfirmValues1L0( ) ;
            }
            /* After transaction rules */
            /* Execute 'After Trn' event if defined. */
            trnEnded = 1;
         }
         else
         {
            pr_datastore1.close(1);
            context.RollbackDataStores("sys_log",pr_default);
         }
         IsModified = 0;
         if ( AnyError != 0 )
         {
            context.wjLoc = "";
            context.nUserReturn = 0;
         }
      }

      public void ScanStart1L60( )
      {
         /* Using cursor T001L11 */
         pr_datastore1.execute(9);
         RcdFound60 = 0;
         if ( (pr_datastore1.getStatus(9) != 101) )
         {
            RcdFound60 = 1;
            A442SYS_LogLogID = T001L11_A442SYS_LogLogID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A442SYS_LogLogID", StringUtil.LTrim( StringUtil.Str( (decimal)(A442SYS_LogLogID), 18, 0)));
         }
         /* Load Subordinate Levels */
      }

      protected void ScanNext1L60( )
      {
         /* Scan next routine */
         pr_datastore1.readNext(9);
         RcdFound60 = 0;
         if ( (pr_datastore1.getStatus(9) != 101) )
         {
            RcdFound60 = 1;
            A442SYS_LogLogID = T001L11_A442SYS_LogLogID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A442SYS_LogLogID", StringUtil.LTrim( StringUtil.Str( (decimal)(A442SYS_LogLogID), 18, 0)));
         }
      }

      protected void ScanEnd1L60( )
      {
         pr_datastore1.close(9);
      }

      protected void AfterConfirm1L60( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert1L60( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate1L60( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete1L60( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete1L60( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate1L60( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes1L60( )
      {
         edtSYS_LogLogID_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtSYS_LogLogID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtSYS_LogLogID_Enabled), 5, 0)), true);
         edtSYS_LogTenantCode_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtSYS_LogTenantCode_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtSYS_LogTenantCode_Enabled), 5, 0)), true);
         edtSYS_LogTitle_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtSYS_LogTitle_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtSYS_LogTitle_Enabled), 5, 0)), true);
         edtSYS_LogContent_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtSYS_LogContent_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtSYS_LogContent_Enabled), 5, 0)), true);
         edtSYS_LogClientIP_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtSYS_LogClientIP_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtSYS_LogClientIP_Enabled), 5, 0)), true);
         edtSYS_LogModuleCode_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtSYS_LogModuleCode_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtSYS_LogModuleCode_Enabled), 5, 0)), true);
         edtSYS_LogLogType_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtSYS_LogLogType_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtSYS_LogLogType_Enabled), 5, 0)), true);
         edtSYS_LogCreator_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtSYS_LogCreator_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtSYS_LogCreator_Enabled), 5, 0)), true);
         edtSYS_LogCreateTime_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtSYS_LogCreateTime_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtSYS_LogCreateTime_Enabled), 5, 0)), true);
      }

      protected void send_integrity_lvl_hashes1L60( )
      {
      }

      protected void assign_properties_default( )
      {
      }

      protected void ConfirmValues1L0( )
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
         context.AddJavascriptSource("gxcfg.js", "?2020227939445", false);
         if ( context.isSpaRequest( ) )
         {
            enableOutput();
         }
         context.AddJavascriptSource("calendar.js", "?"+context.GetBuildNumber( 127771), false);
         context.AddJavascriptSource("calendar-setup.js", "?"+context.GetBuildNumber( 127771), false);
         context.AddJavascriptSource("calendar-zh.js", "?"+context.GetBuildNumber( 127771), false);
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" autocomplete=\"off\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("sys_log.aspx") +"\">") ;
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
         GxWebStd.gx_hidden_field( context, "Z442SYS_LogLogID", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z442SYS_LogLogID), 18, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "Z372SYS_LogTenantCode", Z372SYS_LogTenantCode);
         GxWebStd.gx_hidden_field( context, "Z451SYS_LogTitle", Z451SYS_LogTitle);
         GxWebStd.gx_hidden_field( context, "Z449SYS_LogClientIP", Z449SYS_LogClientIP);
         GxWebStd.gx_hidden_field( context, "Z376SYS_LogModuleCode", Z376SYS_LogModuleCode);
         GxWebStd.gx_hidden_field( context, "Z448SYS_LogLogType", Z448SYS_LogLogType);
         GxWebStd.gx_hidden_field( context, "Z378SYS_LogCreator", Z378SYS_LogCreator);
         GxWebStd.gx_hidden_field( context, "Z379SYS_LogCreateTime", context.localUtil.TToC( Z379SYS_LogCreateTime, 10, 8, 0, 0, "/", ":", " "));
         GxWebStd.gx_hidden_field( context, "IsConfirmed", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsConfirmed), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "IsModified", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsModified), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "Mode", StringUtil.RTrim( Gx_mode));
         GxWebStd.gx_hidden_field( context, "vMODE", StringUtil.RTrim( Gx_mode));
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
         return formatLink("sys_log.aspx")  ;
      }

      public override String GetPgmname( )
      {
         return "SYS_Log" ;
      }

      public override String GetPgmdesc( )
      {
         return "SYS_Log" ;
      }

      protected void InitializeNonKey1L60( )
      {
         A372SYS_LogTenantCode = "";
         n372SYS_LogTenantCode = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A372SYS_LogTenantCode", A372SYS_LogTenantCode);
         n372SYS_LogTenantCode = (String.IsNullOrEmpty(StringUtil.RTrim( A372SYS_LogTenantCode)) ? true : false);
         A451SYS_LogTitle = "";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A451SYS_LogTitle", A451SYS_LogTitle);
         A450SYS_LogContent = "";
         n450SYS_LogContent = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A450SYS_LogContent", A450SYS_LogContent);
         n450SYS_LogContent = (String.IsNullOrEmpty(StringUtil.RTrim( A450SYS_LogContent)) ? true : false);
         A449SYS_LogClientIP = "";
         n449SYS_LogClientIP = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A449SYS_LogClientIP", A449SYS_LogClientIP);
         n449SYS_LogClientIP = (String.IsNullOrEmpty(StringUtil.RTrim( A449SYS_LogClientIP)) ? true : false);
         A376SYS_LogModuleCode = "";
         n376SYS_LogModuleCode = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A376SYS_LogModuleCode", A376SYS_LogModuleCode);
         n376SYS_LogModuleCode = (String.IsNullOrEmpty(StringUtil.RTrim( A376SYS_LogModuleCode)) ? true : false);
         A448SYS_LogLogType = "";
         n448SYS_LogLogType = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A448SYS_LogLogType", A448SYS_LogLogType);
         n448SYS_LogLogType = (String.IsNullOrEmpty(StringUtil.RTrim( A448SYS_LogLogType)) ? true : false);
         A378SYS_LogCreator = "";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A378SYS_LogCreator", A378SYS_LogCreator);
         A379SYS_LogCreateTime = (DateTime)(DateTime.MinValue);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A379SYS_LogCreateTime", context.localUtil.TToC( A379SYS_LogCreateTime, 10, 8, 0, 0, "/", ":", " "));
         Z372SYS_LogTenantCode = "";
         Z451SYS_LogTitle = "";
         Z449SYS_LogClientIP = "";
         Z376SYS_LogModuleCode = "";
         Z448SYS_LogLogType = "";
         Z378SYS_LogCreator = "";
         Z379SYS_LogCreateTime = (DateTime)(DateTime.MinValue);
      }

      protected void InitAll1L60( )
      {
         A442SYS_LogLogID = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A442SYS_LogLogID", StringUtil.LTrim( StringUtil.Str( (decimal)(A442SYS_LogLogID), 18, 0)));
         InitializeNonKey1L60( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?2020227939451", true);
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
         context.AddJavascriptSource("sys_log.js", "?2020227939452", false);
         /* End function include_jscripts */
      }

      protected void init_default_properties( )
      {
         lblTitle_Internalname = "TITLE";
         bttBtn_first_Internalname = "BTN_FIRST";
         bttBtn_previous_Internalname = "BTN_PREVIOUS";
         bttBtn_next_Internalname = "BTN_NEXT";
         bttBtn_last_Internalname = "BTN_LAST";
         bttBtn_select_Internalname = "BTN_SELECT";
         edtSYS_LogLogID_Internalname = "SYS_LOGLOGID";
         edtSYS_LogTenantCode_Internalname = "SYS_LOGTENANTCODE";
         edtSYS_LogTitle_Internalname = "SYS_LOGTITLE";
         edtSYS_LogContent_Internalname = "SYS_LOGCONTENT";
         edtSYS_LogClientIP_Internalname = "SYS_LOGCLIENTIP";
         edtSYS_LogModuleCode_Internalname = "SYS_LOGMODULECODE";
         edtSYS_LogLogType_Internalname = "SYS_LOGLOGTYPE";
         edtSYS_LogCreator_Internalname = "SYS_LOGCREATOR";
         edtSYS_LogCreateTime_Internalname = "SYS_LOGCREATETIME";
         bttBtn_enter_Internalname = "BTN_ENTER";
         bttBtn_cancel_Internalname = "BTN_CANCEL";
         bttBtn_delete_Internalname = "BTN_DELETE";
         divTablemain_Internalname = "TABLEMAIN";
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
         Form.Caption = "SYS_Log";
         bttBtn_delete_Enabled = 1;
         bttBtn_delete_Visible = 1;
         bttBtn_cancel_Visible = 1;
         bttBtn_enter_Enabled = 1;
         bttBtn_enter_Visible = 1;
         edtSYS_LogCreateTime_Jsonclick = "";
         edtSYS_LogCreateTime_Enabled = 1;
         edtSYS_LogCreator_Jsonclick = "";
         edtSYS_LogCreator_Enabled = 1;
         edtSYS_LogLogType_Jsonclick = "";
         edtSYS_LogLogType_Enabled = 1;
         edtSYS_LogModuleCode_Jsonclick = "";
         edtSYS_LogModuleCode_Enabled = 1;
         edtSYS_LogClientIP_Jsonclick = "";
         edtSYS_LogClientIP_Enabled = 1;
         edtSYS_LogContent_Enabled = 1;
         edtSYS_LogTitle_Jsonclick = "";
         edtSYS_LogTitle_Enabled = 1;
         edtSYS_LogTenantCode_Jsonclick = "";
         edtSYS_LogTenantCode_Enabled = 1;
         edtSYS_LogLogID_Jsonclick = "";
         edtSYS_LogLogID_Enabled = 1;
         bttBtn_select_Visible = 1;
         bttBtn_last_Visible = 1;
         bttBtn_next_Visible = 1;
         bttBtn_previous_Visible = 1;
         bttBtn_first_Visible = 1;
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

      protected void AfterKeyLoadScreen( )
      {
         IsConfirmed = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "IsConfirmed", StringUtil.LTrim( StringUtil.Str( (decimal)(IsConfirmed), 4, 0)));
         getEqualNoModal( ) ;
         GX_FocusControl = edtSYS_LogTenantCode_Internalname;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         standaloneNotModal( ) ;
         standaloneModal( ) ;
         /* End function AfterKeyLoadScreen */
      }

      public void Valid_Sys_loglogid( long GX_Parm1 ,
                                      String GX_Parm2 ,
                                      String GX_Parm3 ,
                                      String GX_Parm4 ,
                                      String GX_Parm5 ,
                                      String GX_Parm6 ,
                                      String GX_Parm7 ,
                                      String GX_Parm8 ,
                                      DateTime GX_Parm9 )
      {
         A442SYS_LogLogID = GX_Parm1;
         A372SYS_LogTenantCode = GX_Parm2;
         n372SYS_LogTenantCode = false;
         A451SYS_LogTitle = GX_Parm3;
         A450SYS_LogContent = GX_Parm4;
         n450SYS_LogContent = false;
         A449SYS_LogClientIP = GX_Parm5;
         n449SYS_LogClientIP = false;
         A376SYS_LogModuleCode = GX_Parm6;
         n376SYS_LogModuleCode = false;
         A448SYS_LogLogType = GX_Parm7;
         n448SYS_LogLogType = false;
         A378SYS_LogCreator = GX_Parm8;
         A379SYS_LogCreateTime = GX_Parm9;
         context.wbHandled = 1;
         AfterKeyLoadScreen( ) ;
         Draw( ) ;
         send_integrity_footer_hashes( ) ;
         dynload_actions( ) ;
         if ( AnyError == 1 )
         {
         }
         isValidOutput.Add(A372SYS_LogTenantCode);
         isValidOutput.Add(A451SYS_LogTitle);
         isValidOutput.Add(A450SYS_LogContent);
         isValidOutput.Add(A449SYS_LogClientIP);
         isValidOutput.Add(A376SYS_LogModuleCode);
         isValidOutput.Add(A448SYS_LogLogType);
         isValidOutput.Add(A378SYS_LogCreator);
         isValidOutput.Add(context.localUtil.TToC( A379SYS_LogCreateTime, 10, 8, 0, 0, "/", ":", " "));
         isValidOutput.Add(StringUtil.RTrim( Gx_mode));
         isValidOutput.Add(StringUtil.LTrim( StringUtil.NToC( (decimal)(Z442SYS_LogLogID), 18, 0, ".", "")));
         isValidOutput.Add(Z372SYS_LogTenantCode);
         isValidOutput.Add(Z451SYS_LogTitle);
         isValidOutput.Add(Z450SYS_LogContent);
         isValidOutput.Add(Z449SYS_LogClientIP);
         isValidOutput.Add(Z376SYS_LogModuleCode);
         isValidOutput.Add(Z448SYS_LogLogType);
         isValidOutput.Add(Z378SYS_LogCreator);
         isValidOutput.Add(context.localUtil.TToC( Z379SYS_LogCreateTime, 10, 8, 0, 0, "/", ":", " "));
         isValidOutput.Add(bttBtn_delete_Enabled);
         isValidOutput.Add(bttBtn_enter_Enabled);
         isValidOutput.Add(context.GX_msglist.ToJavascriptSource());
         isValidOutput.Add(context.httpAjaxContext.ajax_rsp_get_hiddens( ));
         context.GX_webresponse.AddString(isValidOutput.ToJSonString());
         wbTemp = context.ResponseContentType( "application/json");
      }

      public override bool SupportAjaxEvent( )
      {
         return true ;
      }

      public override void InitializeDynEvents( )
      {
         setEventMetadata("ENTER","{handler:'UserMainFullajax',iparms:[{postForm:true}]");
         setEventMetadata("ENTER",",oparms:[]}");
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[]");
         setEventMetadata("REFRESH",",oparms:[]}");
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
         pr_datastore1.close(1);
      }

      public override void initialize( )
      {
         sPrefix = "";
         Z372SYS_LogTenantCode = "";
         Z451SYS_LogTitle = "";
         Z449SYS_LogClientIP = "";
         Z376SYS_LogModuleCode = "";
         Z448SYS_LogLogType = "";
         Z378SYS_LogCreator = "";
         Z379SYS_LogCreateTime = (DateTime)(DateTime.MinValue);
         scmdbuf = "";
         gxfirstwebparm = "";
         gxfirstwebparm_bkp = "";
         GXKey = "";
         PreviousTooltip = "";
         PreviousCaption = "";
         Form = new GXWebForm();
         GX_FocusControl = "";
         lblTitle_Jsonclick = "";
         TempTags = "";
         ClassString = "";
         StyleString = "";
         bttBtn_first_Jsonclick = "";
         bttBtn_previous_Jsonclick = "";
         bttBtn_next_Jsonclick = "";
         bttBtn_last_Jsonclick = "";
         bttBtn_select_Jsonclick = "";
         A372SYS_LogTenantCode = "";
         A451SYS_LogTitle = "";
         A450SYS_LogContent = "";
         A449SYS_LogClientIP = "";
         A376SYS_LogModuleCode = "";
         A448SYS_LogLogType = "";
         A378SYS_LogCreator = "";
         A379SYS_LogCreateTime = (DateTime)(DateTime.MinValue);
         bttBtn_enter_Jsonclick = "";
         bttBtn_cancel_Jsonclick = "";
         bttBtn_delete_Jsonclick = "";
         Gx_mode = "";
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         Z450SYS_LogContent = "";
         T001L4_A442SYS_LogLogID = new long[1] ;
         T001L4_A372SYS_LogTenantCode = new String[] {""} ;
         T001L4_n372SYS_LogTenantCode = new bool[] {false} ;
         T001L4_A451SYS_LogTitle = new String[] {""} ;
         T001L4_A450SYS_LogContent = new String[] {""} ;
         T001L4_n450SYS_LogContent = new bool[] {false} ;
         T001L4_A449SYS_LogClientIP = new String[] {""} ;
         T001L4_n449SYS_LogClientIP = new bool[] {false} ;
         T001L4_A376SYS_LogModuleCode = new String[] {""} ;
         T001L4_n376SYS_LogModuleCode = new bool[] {false} ;
         T001L4_A448SYS_LogLogType = new String[] {""} ;
         T001L4_n448SYS_LogLogType = new bool[] {false} ;
         T001L4_A378SYS_LogCreator = new String[] {""} ;
         T001L4_A379SYS_LogCreateTime = new DateTime[] {DateTime.MinValue} ;
         T001L5_A442SYS_LogLogID = new long[1] ;
         T001L3_A442SYS_LogLogID = new long[1] ;
         T001L3_A372SYS_LogTenantCode = new String[] {""} ;
         T001L3_n372SYS_LogTenantCode = new bool[] {false} ;
         T001L3_A451SYS_LogTitle = new String[] {""} ;
         T001L3_A450SYS_LogContent = new String[] {""} ;
         T001L3_n450SYS_LogContent = new bool[] {false} ;
         T001L3_A449SYS_LogClientIP = new String[] {""} ;
         T001L3_n449SYS_LogClientIP = new bool[] {false} ;
         T001L3_A376SYS_LogModuleCode = new String[] {""} ;
         T001L3_n376SYS_LogModuleCode = new bool[] {false} ;
         T001L3_A448SYS_LogLogType = new String[] {""} ;
         T001L3_n448SYS_LogLogType = new bool[] {false} ;
         T001L3_A378SYS_LogCreator = new String[] {""} ;
         T001L3_A379SYS_LogCreateTime = new DateTime[] {DateTime.MinValue} ;
         sMode60 = "";
         T001L6_A442SYS_LogLogID = new long[1] ;
         T001L7_A442SYS_LogLogID = new long[1] ;
         T001L2_A442SYS_LogLogID = new long[1] ;
         T001L2_A372SYS_LogTenantCode = new String[] {""} ;
         T001L2_n372SYS_LogTenantCode = new bool[] {false} ;
         T001L2_A451SYS_LogTitle = new String[] {""} ;
         T001L2_A450SYS_LogContent = new String[] {""} ;
         T001L2_n450SYS_LogContent = new bool[] {false} ;
         T001L2_A449SYS_LogClientIP = new String[] {""} ;
         T001L2_n449SYS_LogClientIP = new bool[] {false} ;
         T001L2_A376SYS_LogModuleCode = new String[] {""} ;
         T001L2_n376SYS_LogModuleCode = new bool[] {false} ;
         T001L2_A448SYS_LogLogType = new String[] {""} ;
         T001L2_n448SYS_LogLogType = new bool[] {false} ;
         T001L2_A378SYS_LogCreator = new String[] {""} ;
         T001L2_A379SYS_LogCreateTime = new DateTime[] {DateTime.MinValue} ;
         T001L8_A442SYS_LogLogID = new long[1] ;
         T001L11_A442SYS_LogLogID = new long[1] ;
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         isValidOutput = new GxUnknownObjectCollection();
         pr_datastore1 = new DataStoreProvider(context, new GeneXus.Programs.sys_log__datastore1(),
            new Object[][] {
                new Object[] {
               T001L2_A442SYS_LogLogID, T001L2_A372SYS_LogTenantCode, T001L2_n372SYS_LogTenantCode, T001L2_A451SYS_LogTitle, T001L2_A450SYS_LogContent, T001L2_n450SYS_LogContent, T001L2_A449SYS_LogClientIP, T001L2_n449SYS_LogClientIP, T001L2_A376SYS_LogModuleCode, T001L2_n376SYS_LogModuleCode,
               T001L2_A448SYS_LogLogType, T001L2_n448SYS_LogLogType, T001L2_A378SYS_LogCreator, T001L2_A379SYS_LogCreateTime
               }
               , new Object[] {
               T001L3_A442SYS_LogLogID, T001L3_A372SYS_LogTenantCode, T001L3_n372SYS_LogTenantCode, T001L3_A451SYS_LogTitle, T001L3_A450SYS_LogContent, T001L3_n450SYS_LogContent, T001L3_A449SYS_LogClientIP, T001L3_n449SYS_LogClientIP, T001L3_A376SYS_LogModuleCode, T001L3_n376SYS_LogModuleCode,
               T001L3_A448SYS_LogLogType, T001L3_n448SYS_LogLogType, T001L3_A378SYS_LogCreator, T001L3_A379SYS_LogCreateTime
               }
               , new Object[] {
               T001L4_A442SYS_LogLogID, T001L4_A372SYS_LogTenantCode, T001L4_n372SYS_LogTenantCode, T001L4_A451SYS_LogTitle, T001L4_A450SYS_LogContent, T001L4_n450SYS_LogContent, T001L4_A449SYS_LogClientIP, T001L4_n449SYS_LogClientIP, T001L4_A376SYS_LogModuleCode, T001L4_n376SYS_LogModuleCode,
               T001L4_A448SYS_LogLogType, T001L4_n448SYS_LogLogType, T001L4_A378SYS_LogCreator, T001L4_A379SYS_LogCreateTime
               }
               , new Object[] {
               T001L5_A442SYS_LogLogID
               }
               , new Object[] {
               T001L6_A442SYS_LogLogID
               }
               , new Object[] {
               T001L7_A442SYS_LogLogID
               }
               , new Object[] {
               T001L8_A442SYS_LogLogID
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               T001L11_A442SYS_LogLogID
               }
            }
         );
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.sys_log__default(),
            new Object[][] {
            }
         );
      }

      private short GxWebError ;
      private short gxcookieaux ;
      private short IsConfirmed ;
      private short IsModified ;
      private short AnyError ;
      private short nKeyPressed ;
      private short initialized ;
      private short GX_JID ;
      private short RcdFound60 ;
      private short Gx_BScreen ;
      private short gxajaxcallmode ;
      private short wbTemp ;
      private int trnEnded ;
      private int bttBtn_first_Visible ;
      private int bttBtn_previous_Visible ;
      private int bttBtn_next_Visible ;
      private int bttBtn_last_Visible ;
      private int bttBtn_select_Visible ;
      private int edtSYS_LogLogID_Enabled ;
      private int edtSYS_LogTenantCode_Enabled ;
      private int edtSYS_LogTitle_Enabled ;
      private int edtSYS_LogContent_Enabled ;
      private int edtSYS_LogClientIP_Enabled ;
      private int edtSYS_LogModuleCode_Enabled ;
      private int edtSYS_LogLogType_Enabled ;
      private int edtSYS_LogCreator_Enabled ;
      private int edtSYS_LogCreateTime_Enabled ;
      private int bttBtn_enter_Visible ;
      private int bttBtn_enter_Enabled ;
      private int bttBtn_cancel_Visible ;
      private int bttBtn_delete_Visible ;
      private int bttBtn_delete_Enabled ;
      private int idxLst ;
      private long Z442SYS_LogLogID ;
      private long A442SYS_LogLogID ;
      private String sPrefix ;
      private String scmdbuf ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String GXKey ;
      private String PreviousTooltip ;
      private String PreviousCaption ;
      private String GX_FocusControl ;
      private String edtSYS_LogLogID_Internalname ;
      private String divTablemain_Internalname ;
      private String lblTitle_Internalname ;
      private String lblTitle_Jsonclick ;
      private String TempTags ;
      private String ClassString ;
      private String StyleString ;
      private String bttBtn_first_Internalname ;
      private String bttBtn_first_Jsonclick ;
      private String bttBtn_previous_Internalname ;
      private String bttBtn_previous_Jsonclick ;
      private String bttBtn_next_Internalname ;
      private String bttBtn_next_Jsonclick ;
      private String bttBtn_last_Internalname ;
      private String bttBtn_last_Jsonclick ;
      private String bttBtn_select_Internalname ;
      private String bttBtn_select_Jsonclick ;
      private String edtSYS_LogLogID_Jsonclick ;
      private String edtSYS_LogTenantCode_Internalname ;
      private String edtSYS_LogTenantCode_Jsonclick ;
      private String edtSYS_LogTitle_Internalname ;
      private String edtSYS_LogTitle_Jsonclick ;
      private String edtSYS_LogContent_Internalname ;
      private String edtSYS_LogClientIP_Internalname ;
      private String edtSYS_LogClientIP_Jsonclick ;
      private String edtSYS_LogModuleCode_Internalname ;
      private String edtSYS_LogModuleCode_Jsonclick ;
      private String edtSYS_LogLogType_Internalname ;
      private String edtSYS_LogLogType_Jsonclick ;
      private String edtSYS_LogCreator_Internalname ;
      private String edtSYS_LogCreator_Jsonclick ;
      private String edtSYS_LogCreateTime_Internalname ;
      private String edtSYS_LogCreateTime_Jsonclick ;
      private String bttBtn_enter_Internalname ;
      private String bttBtn_enter_Jsonclick ;
      private String bttBtn_cancel_Internalname ;
      private String bttBtn_cancel_Jsonclick ;
      private String bttBtn_delete_Internalname ;
      private String bttBtn_delete_Jsonclick ;
      private String Gx_mode ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String sMode60 ;
      private String sDynURL ;
      private String FormProcess ;
      private String bodyStyle ;
      private DateTime Z379SYS_LogCreateTime ;
      private DateTime A379SYS_LogCreateTime ;
      private bool entryPointCalled ;
      private bool toggleJsOutput ;
      private bool wbErr ;
      private bool n372SYS_LogTenantCode ;
      private bool n450SYS_LogContent ;
      private bool n449SYS_LogClientIP ;
      private bool n376SYS_LogModuleCode ;
      private bool n448SYS_LogLogType ;
      private bool Gx_longc ;
      private String A450SYS_LogContent ;
      private String Z450SYS_LogContent ;
      private String Z372SYS_LogTenantCode ;
      private String Z451SYS_LogTitle ;
      private String Z449SYS_LogClientIP ;
      private String Z376SYS_LogModuleCode ;
      private String Z448SYS_LogLogType ;
      private String Z378SYS_LogCreator ;
      private String A372SYS_LogTenantCode ;
      private String A451SYS_LogTitle ;
      private String A449SYS_LogClientIP ;
      private String A376SYS_LogModuleCode ;
      private String A448SYS_LogLogType ;
      private String A378SYS_LogCreator ;
      private GxUnknownObjectCollection isValidOutput ;
      private IGxDataStore dsDataStore1 ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_datastore1 ;
      private long[] T001L4_A442SYS_LogLogID ;
      private String[] T001L4_A372SYS_LogTenantCode ;
      private bool[] T001L4_n372SYS_LogTenantCode ;
      private String[] T001L4_A451SYS_LogTitle ;
      private String[] T001L4_A450SYS_LogContent ;
      private bool[] T001L4_n450SYS_LogContent ;
      private String[] T001L4_A449SYS_LogClientIP ;
      private bool[] T001L4_n449SYS_LogClientIP ;
      private String[] T001L4_A376SYS_LogModuleCode ;
      private bool[] T001L4_n376SYS_LogModuleCode ;
      private String[] T001L4_A448SYS_LogLogType ;
      private bool[] T001L4_n448SYS_LogLogType ;
      private String[] T001L4_A378SYS_LogCreator ;
      private DateTime[] T001L4_A379SYS_LogCreateTime ;
      private long[] T001L5_A442SYS_LogLogID ;
      private long[] T001L3_A442SYS_LogLogID ;
      private String[] T001L3_A372SYS_LogTenantCode ;
      private bool[] T001L3_n372SYS_LogTenantCode ;
      private String[] T001L3_A451SYS_LogTitle ;
      private String[] T001L3_A450SYS_LogContent ;
      private bool[] T001L3_n450SYS_LogContent ;
      private String[] T001L3_A449SYS_LogClientIP ;
      private bool[] T001L3_n449SYS_LogClientIP ;
      private String[] T001L3_A376SYS_LogModuleCode ;
      private bool[] T001L3_n376SYS_LogModuleCode ;
      private String[] T001L3_A448SYS_LogLogType ;
      private bool[] T001L3_n448SYS_LogLogType ;
      private String[] T001L3_A378SYS_LogCreator ;
      private DateTime[] T001L3_A379SYS_LogCreateTime ;
      private long[] T001L6_A442SYS_LogLogID ;
      private long[] T001L7_A442SYS_LogLogID ;
      private long[] T001L2_A442SYS_LogLogID ;
      private String[] T001L2_A372SYS_LogTenantCode ;
      private bool[] T001L2_n372SYS_LogTenantCode ;
      private String[] T001L2_A451SYS_LogTitle ;
      private String[] T001L2_A450SYS_LogContent ;
      private bool[] T001L2_n450SYS_LogContent ;
      private String[] T001L2_A449SYS_LogClientIP ;
      private bool[] T001L2_n449SYS_LogClientIP ;
      private String[] T001L2_A376SYS_LogModuleCode ;
      private bool[] T001L2_n376SYS_LogModuleCode ;
      private String[] T001L2_A448SYS_LogLogType ;
      private bool[] T001L2_n448SYS_LogLogType ;
      private String[] T001L2_A378SYS_LogCreator ;
      private DateTime[] T001L2_A379SYS_LogCreateTime ;
      private long[] T001L8_A442SYS_LogLogID ;
      private IDataStoreProvider pr_default ;
      private long[] T001L11_A442SYS_LogLogID ;
      private GXWebForm Form ;
   }

   public class sys_log__datastore1 : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmT001L4 ;
          prmT001L4 = new Object[] {
          new Object[] {"@SYS_LogLogID",SqlDbType.Decimal,18,0}
          } ;
          Object[] prmT001L5 ;
          prmT001L5 = new Object[] {
          new Object[] {"@SYS_LogLogID",SqlDbType.Decimal,18,0}
          } ;
          Object[] prmT001L3 ;
          prmT001L3 = new Object[] {
          new Object[] {"@SYS_LogLogID",SqlDbType.Decimal,18,0}
          } ;
          Object[] prmT001L6 ;
          prmT001L6 = new Object[] {
          new Object[] {"@SYS_LogLogID",SqlDbType.Decimal,18,0}
          } ;
          Object[] prmT001L7 ;
          prmT001L7 = new Object[] {
          new Object[] {"@SYS_LogLogID",SqlDbType.Decimal,18,0}
          } ;
          Object[] prmT001L2 ;
          prmT001L2 = new Object[] {
          new Object[] {"@SYS_LogLogID",SqlDbType.Decimal,18,0}
          } ;
          Object[] prmT001L8 ;
          prmT001L8 = new Object[] {
          new Object[] {"@SYS_LogTenantCode",SqlDbType.NVarChar,20,0} ,
          new Object[] {"@SYS_LogTitle",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@SYS_LogContent",SqlDbType.NVarChar,2048,0} ,
          new Object[] {"@SYS_LogClientIP",SqlDbType.NVarChar,15,0} ,
          new Object[] {"@SYS_LogModuleCode",SqlDbType.NVarChar,30,0} ,
          new Object[] {"@SYS_LogLogType",SqlDbType.NVarChar,30,0} ,
          new Object[] {"@SYS_LogCreator",SqlDbType.NVarChar,50,0} ,
          new Object[] {"@SYS_LogCreateTime",SqlDbType.DateTime,10,8}
          } ;
          Object[] prmT001L9 ;
          prmT001L9 = new Object[] {
          new Object[] {"@SYS_LogTenantCode",SqlDbType.NVarChar,20,0} ,
          new Object[] {"@SYS_LogTitle",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@SYS_LogContent",SqlDbType.NVarChar,2048,0} ,
          new Object[] {"@SYS_LogClientIP",SqlDbType.NVarChar,15,0} ,
          new Object[] {"@SYS_LogModuleCode",SqlDbType.NVarChar,30,0} ,
          new Object[] {"@SYS_LogLogType",SqlDbType.NVarChar,30,0} ,
          new Object[] {"@SYS_LogCreator",SqlDbType.NVarChar,50,0} ,
          new Object[] {"@SYS_LogCreateTime",SqlDbType.DateTime,10,8} ,
          new Object[] {"@SYS_LogLogID",SqlDbType.Decimal,18,0}
          } ;
          Object[] prmT001L10 ;
          prmT001L10 = new Object[] {
          new Object[] {"@SYS_LogLogID",SqlDbType.Decimal,18,0}
          } ;
          Object[] prmT001L11 ;
          prmT001L11 = new Object[] {
          } ;
          def= new CursorDef[] {
              new CursorDef("T001L2", "SELECT [LogID], [TenantCode], [Title], [Content], [ClientIP], [ModuleCode], [LogType], [Creator], [CreateTime] FROM dbo.[SYS_Log] WITH (UPDLOCK) WHERE [LogID] = @SYS_LogLogID ",true, GxErrorMask.GX_NOMASK, false, this,prmT001L2,1,0,true,false )
             ,new CursorDef("T001L3", "SELECT [LogID], [TenantCode], [Title], [Content], [ClientIP], [ModuleCode], [LogType], [Creator], [CreateTime] FROM dbo.[SYS_Log] WITH (NOLOCK) WHERE [LogID] = @SYS_LogLogID ",true, GxErrorMask.GX_NOMASK, false, this,prmT001L3,1,0,true,false )
             ,new CursorDef("T001L4", "SELECT TM1.[LogID], TM1.[TenantCode], TM1.[Title], TM1.[Content], TM1.[ClientIP], TM1.[ModuleCode], TM1.[LogType], TM1.[Creator], TM1.[CreateTime] FROM dbo.[SYS_Log] TM1 WITH (NOLOCK) WHERE TM1.[LogID] = @SYS_LogLogID ORDER BY TM1.[LogID]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT001L4,100,0,true,false )
             ,new CursorDef("T001L5", "SELECT [LogID] FROM dbo.[SYS_Log] WITH (NOLOCK) WHERE [LogID] = @SYS_LogLogID  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT001L5,1,0,true,false )
             ,new CursorDef("T001L6", "SELECT TOP 1 [LogID] FROM dbo.[SYS_Log] WITH (NOLOCK) WHERE ( [LogID] > @SYS_LogLogID) ORDER BY [LogID]  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT001L6,1,0,true,true )
             ,new CursorDef("T001L7", "SELECT TOP 1 [LogID] FROM dbo.[SYS_Log] WITH (NOLOCK) WHERE ( [LogID] < @SYS_LogLogID) ORDER BY [LogID] DESC  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT001L7,1,0,true,true )
             ,new CursorDef("T001L8", "INSERT INTO dbo.[SYS_Log]([TenantCode], [Title], [Content], [ClientIP], [ModuleCode], [LogType], [Creator], [CreateTime]) VALUES(@SYS_LogTenantCode, @SYS_LogTitle, @SYS_LogContent, @SYS_LogClientIP, @SYS_LogModuleCode, @SYS_LogLogType, @SYS_LogCreator, @SYS_LogCreateTime); SELECT SCOPE_IDENTITY()", GxErrorMask.GX_NOMASK,prmT001L8)
             ,new CursorDef("T001L9", "UPDATE dbo.[SYS_Log] SET [TenantCode]=@SYS_LogTenantCode, [Title]=@SYS_LogTitle, [Content]=@SYS_LogContent, [ClientIP]=@SYS_LogClientIP, [ModuleCode]=@SYS_LogModuleCode, [LogType]=@SYS_LogLogType, [Creator]=@SYS_LogCreator, [CreateTime]=@SYS_LogCreateTime  WHERE [LogID] = @SYS_LogLogID", GxErrorMask.GX_NOMASK,prmT001L9)
             ,new CursorDef("T001L10", "DELETE FROM dbo.[SYS_Log]  WHERE [LogID] = @SYS_LogLogID", GxErrorMask.GX_NOMASK,prmT001L10)
             ,new CursorDef("T001L11", "SELECT [LogID] FROM dbo.[SYS_Log] WITH (NOLOCK) ORDER BY [LogID]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT001L11,100,0,true,false )
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
                ((String[]) buf[4])[0] = rslt.getLongVarchar(4) ;
                ((bool[]) buf[5])[0] = rslt.wasNull(4);
                ((String[]) buf[6])[0] = rslt.getVarchar(5) ;
                ((bool[]) buf[7])[0] = rslt.wasNull(5);
                ((String[]) buf[8])[0] = rslt.getVarchar(6) ;
                ((bool[]) buf[9])[0] = rslt.wasNull(6);
                ((String[]) buf[10])[0] = rslt.getVarchar(7) ;
                ((bool[]) buf[11])[0] = rslt.wasNull(7);
                ((String[]) buf[12])[0] = rslt.getVarchar(8) ;
                ((DateTime[]) buf[13])[0] = rslt.getGXDateTime(9) ;
                return;
             case 1 :
                ((long[]) buf[0])[0] = rslt.getLong(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
                ((String[]) buf[3])[0] = rslt.getVarchar(3) ;
                ((String[]) buf[4])[0] = rslt.getLongVarchar(4) ;
                ((bool[]) buf[5])[0] = rslt.wasNull(4);
                ((String[]) buf[6])[0] = rslt.getVarchar(5) ;
                ((bool[]) buf[7])[0] = rslt.wasNull(5);
                ((String[]) buf[8])[0] = rslt.getVarchar(6) ;
                ((bool[]) buf[9])[0] = rslt.wasNull(6);
                ((String[]) buf[10])[0] = rslt.getVarchar(7) ;
                ((bool[]) buf[11])[0] = rslt.wasNull(7);
                ((String[]) buf[12])[0] = rslt.getVarchar(8) ;
                ((DateTime[]) buf[13])[0] = rslt.getGXDateTime(9) ;
                return;
             case 2 :
                ((long[]) buf[0])[0] = rslt.getLong(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
                ((String[]) buf[3])[0] = rslt.getVarchar(3) ;
                ((String[]) buf[4])[0] = rslt.getLongVarchar(4) ;
                ((bool[]) buf[5])[0] = rslt.wasNull(4);
                ((String[]) buf[6])[0] = rslt.getVarchar(5) ;
                ((bool[]) buf[7])[0] = rslt.wasNull(5);
                ((String[]) buf[8])[0] = rslt.getVarchar(6) ;
                ((bool[]) buf[9])[0] = rslt.wasNull(6);
                ((String[]) buf[10])[0] = rslt.getVarchar(7) ;
                ((bool[]) buf[11])[0] = rslt.wasNull(7);
                ((String[]) buf[12])[0] = rslt.getVarchar(8) ;
                ((DateTime[]) buf[13])[0] = rslt.getGXDateTime(9) ;
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
                stmt.SetParameter(2, (String)parms[2]);
                if ( (bool)parms[3] )
                {
                   stmt.setNull( 3 , SqlDbType.NVarChar );
                }
                else
                {
                   stmt.SetParameter(3, (String)parms[4]);
                }
                if ( (bool)parms[5] )
                {
                   stmt.setNull( 4 , SqlDbType.NVarChar );
                }
                else
                {
                   stmt.SetParameter(4, (String)parms[6]);
                }
                if ( (bool)parms[7] )
                {
                   stmt.setNull( 5 , SqlDbType.NVarChar );
                }
                else
                {
                   stmt.SetParameter(5, (String)parms[8]);
                }
                if ( (bool)parms[9] )
                {
                   stmt.setNull( 6 , SqlDbType.NVarChar );
                }
                else
                {
                   stmt.SetParameter(6, (String)parms[10]);
                }
                stmt.SetParameter(7, (String)parms[11]);
                stmt.SetParameterDatetime(8, (DateTime)parms[12]);
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
                stmt.SetParameter(2, (String)parms[2]);
                if ( (bool)parms[3] )
                {
                   stmt.setNull( 3 , SqlDbType.NVarChar );
                }
                else
                {
                   stmt.SetParameter(3, (String)parms[4]);
                }
                if ( (bool)parms[5] )
                {
                   stmt.setNull( 4 , SqlDbType.NVarChar );
                }
                else
                {
                   stmt.SetParameter(4, (String)parms[6]);
                }
                if ( (bool)parms[7] )
                {
                   stmt.setNull( 5 , SqlDbType.NVarChar );
                }
                else
                {
                   stmt.SetParameter(5, (String)parms[8]);
                }
                if ( (bool)parms[9] )
                {
                   stmt.setNull( 6 , SqlDbType.NVarChar );
                }
                else
                {
                   stmt.SetParameter(6, (String)parms[10]);
                }
                stmt.SetParameter(7, (String)parms[11]);
                stmt.SetParameterDatetime(8, (DateTime)parms[12]);
                stmt.SetParameter(9, (long)parms[13]);
                return;
             case 8 :
                stmt.SetParameter(1, (long)parms[0]);
                return;
       }
    }

    public String getDataStoreName( )
    {
       return "DATASTORE1";
    }

 }

 public class sys_log__default : DataStoreHelperBase, IDataStoreHelper
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
