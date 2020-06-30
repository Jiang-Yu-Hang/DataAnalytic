/*
               File: SYS_TenantUserAccess
        Description: SYS_Tenant User Access
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/27/2020 11:58:7.6
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
   public class sys_tenantuseraccess : GXDataArea, System.Web.SessionState.IRequiresSessionState
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
            Form.Meta.addItem("description", "SYS_Tenant User Access", 0) ;
         }
         context.wjLoc = "";
         context.nUserReturn = 0;
         context.wbHandled = 0;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         GX_FocusControl = edtSYS_TenantUserAccessUserAccessID_Internalname;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         wbErr = false;
         context.SetDefaultTheme("WorkWithPlusTheme");
         if ( ! context.IsLocalStorageSupported( ) )
         {
            context.PushCurrentUrl();
         }
      }

      public sys_tenantuseraccess( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public sys_tenantuseraccess( IGxContext context )
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
            GxWebStd.gx_label_ctrl( context, lblTitle_Internalname, "SYS_Tenant User Access", "", "", lblTitle_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Title", 0, "", 1, 1, 0, "HLP_SYS_TenantUserAccess.htm");
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
            GxWebStd.gx_button_ctrl( context, bttBtn_first_Internalname, "", "|<", bttBtn_first_Jsonclick, 5, "|<", "", StyleString, ClassString, bttBtn_first_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"EFIRST."+"'", TempTags, "", context.GetButtonType( ), "HLP_SYS_TenantUserAccess.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 14,'',false,'',0)\"";
            ClassString = "BtnPrevious";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_previous_Internalname, "", "<", bttBtn_previous_Jsonclick, 5, "<", "", StyleString, ClassString, bttBtn_previous_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"EPREVIOUS."+"'", TempTags, "", context.GetButtonType( ), "HLP_SYS_TenantUserAccess.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 16,'',false,'',0)\"";
            ClassString = "BtnNext";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_next_Internalname, "", ">", bttBtn_next_Jsonclick, 5, ">", "", StyleString, ClassString, bttBtn_next_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ENEXT."+"'", TempTags, "", context.GetButtonType( ), "HLP_SYS_TenantUserAccess.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 18,'',false,'',0)\"";
            ClassString = "BtnLast";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_last_Internalname, "", ">|", bttBtn_last_Jsonclick, 5, ">|", "", StyleString, ClassString, bttBtn_last_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ELAST."+"'", TempTags, "", context.GetButtonType( ), "HLP_SYS_TenantUserAccess.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 20,'',false,'',0)\"";
            ClassString = "BtnSelect";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_select_Internalname, "", "选择", bttBtn_select_Jsonclick, 5, "选择", "", StyleString, ClassString, bttBtn_select_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ESELECT."+"'", TempTags, "", 2, "HLP_SYS_TenantUserAccess.htm");
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
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtSYS_TenantUserAccessUserAccessID_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtSYS_TenantUserAccessUserAccessID_Internalname, "User Access ID", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 28,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtSYS_TenantUserAccessUserAccessID_Internalname, A437SYS_TenantUserAccessUserAccessID.ToString(), A437SYS_TenantUserAccessUserAccessID.ToString(), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,28);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtSYS_TenantUserAccessUserAccessID_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtSYS_TenantUserAccessUserAccessID_Enabled, 0, "text", "", 36, "chr", 1, "row", 36, 0, 0, 0, 1, 0, 0, true, "", "", false, "HLP_SYS_TenantUserAccess.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtSYS_TenantUserAccessUserID_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtSYS_TenantUserAccessUserID_Internalname, "User ID", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 33,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtSYS_TenantUserAccessUserID_Internalname, A439SYS_TenantUserAccessUserID.ToString(), A439SYS_TenantUserAccessUserID.ToString(), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,33);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtSYS_TenantUserAccessUserID_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtSYS_TenantUserAccessUserID_Enabled, 0, "text", "", 36, "chr", 1, "row", 36, 0, 0, 0, 1, 0, 0, true, "", "", false, "HLP_SYS_TenantUserAccess.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtSYS_TenantUserAccessTenantCode_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtSYS_TenantUserAccessTenantCode_Internalname, "Tenant Code", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 38,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtSYS_TenantUserAccessTenantCode_Internalname, A438SYS_TenantUserAccessTenantCode, StringUtil.RTrim( context.localUtil.Format( A438SYS_TenantUserAccessTenantCode, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,38);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtSYS_TenantUserAccessTenantCode_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtSYS_TenantUserAccessTenantCode_Enabled, 0, "text", "", 20, "chr", 1, "row", 20, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_SYS_TenantUserAccess.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtSYS_TenantUserAccessDataPackage_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtSYS_TenantUserAccessDataPackage_Internalname, "Data Package", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 43,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtSYS_TenantUserAccessDataPackage_Internalname, A440SYS_TenantUserAccessDataPackage, StringUtil.RTrim( context.localUtil.Format( A440SYS_TenantUserAccessDataPackage, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,43);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtSYS_TenantUserAccessDataPackage_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtSYS_TenantUserAccessDataPackage_Enabled, 0, "text", "", 50, "chr", 1, "row", 50, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_SYS_TenantUserAccess.htm");
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
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 48,'',false,'',0)\"";
            ClassString = "BtnEnter";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_enter_Internalname, "", "确认", bttBtn_enter_Jsonclick, 5, "确认", "", StyleString, ClassString, bttBtn_enter_Visible, bttBtn_enter_Enabled, "standard", "'"+""+"'"+",false,"+"'"+"EENTER."+"'", TempTags, "", context.GetButtonType( ), "HLP_SYS_TenantUserAccess.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 50,'',false,'',0)\"";
            ClassString = "BtnCancel";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_cancel_Internalname, "", "取消", bttBtn_cancel_Jsonclick, 1, "取消", "", StyleString, ClassString, bttBtn_cancel_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ECANCEL."+"'", TempTags, "", context.GetButtonType( ), "HLP_SYS_TenantUserAccess.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 52,'',false,'',0)\"";
            ClassString = "BtnDelete";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_delete_Internalname, "", "删除", bttBtn_delete_Jsonclick, 5, "删除", "", StyleString, ClassString, bttBtn_delete_Visible, bttBtn_delete_Enabled, "standard", "'"+""+"'"+",false,"+"'"+"EDELETE."+"'", TempTags, "", context.GetButtonType( ), "HLP_SYS_TenantUserAccess.htm");
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
               if ( StringUtil.StrCmp(cgiGet( edtSYS_TenantUserAccessUserAccessID_Internalname), "") == 0 )
               {
                  A437SYS_TenantUserAccessUserAccessID = (Guid)(Guid.Empty);
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A437SYS_TenantUserAccessUserAccessID", A437SYS_TenantUserAccessUserAccessID.ToString());
               }
               else
               {
                  try
                  {
                     A437SYS_TenantUserAccessUserAccessID = (Guid)(StringUtil.StrToGuid( cgiGet( edtSYS_TenantUserAccessUserAccessID_Internalname)));
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A437SYS_TenantUserAccessUserAccessID", A437SYS_TenantUserAccessUserAccessID.ToString());
                  }
                  catch ( Exception e )
                  {
                     GX_msglist.addItem(context.GetMessage( "GXM_invalidguid", ""), 1, "SYS_TENANTUSERACCESSUSERACCESSID");
                     AnyError = 1;
                     GX_FocusControl = edtSYS_TenantUserAccessUserAccessID_Internalname;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                     wbErr = true;
                  }
               }
               if ( StringUtil.StrCmp(cgiGet( edtSYS_TenantUserAccessUserID_Internalname), "") == 0 )
               {
                  A439SYS_TenantUserAccessUserID = (Guid)(Guid.Empty);
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A439SYS_TenantUserAccessUserID", A439SYS_TenantUserAccessUserID.ToString());
               }
               else
               {
                  try
                  {
                     A439SYS_TenantUserAccessUserID = (Guid)(StringUtil.StrToGuid( cgiGet( edtSYS_TenantUserAccessUserID_Internalname)));
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A439SYS_TenantUserAccessUserID", A439SYS_TenantUserAccessUserID.ToString());
                  }
                  catch ( Exception e )
                  {
                     GX_msglist.addItem(context.GetMessage( "GXM_invalidguid", ""), 1, "SYS_TENANTUSERACCESSUSERID");
                     AnyError = 1;
                     GX_FocusControl = edtSYS_TenantUserAccessUserID_Internalname;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                     wbErr = true;
                  }
               }
               A438SYS_TenantUserAccessTenantCode = cgiGet( edtSYS_TenantUserAccessTenantCode_Internalname);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A438SYS_TenantUserAccessTenantCode", A438SYS_TenantUserAccessTenantCode);
               A440SYS_TenantUserAccessDataPackage = cgiGet( edtSYS_TenantUserAccessDataPackage_Internalname);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A440SYS_TenantUserAccessDataPackage", A440SYS_TenantUserAccessDataPackage);
               /* Read saved values. */
               Z437SYS_TenantUserAccessUserAccessID = (Guid)(StringUtil.StrToGuid( cgiGet( "Z437SYS_TenantUserAccessUserAccessID")));
               Z439SYS_TenantUserAccessUserID = (Guid)(StringUtil.StrToGuid( cgiGet( "Z439SYS_TenantUserAccessUserID")));
               Z438SYS_TenantUserAccessTenantCode = cgiGet( "Z438SYS_TenantUserAccessTenantCode");
               Z440SYS_TenantUserAccessDataPackage = cgiGet( "Z440SYS_TenantUserAccessDataPackage");
               IsConfirmed = (short)(context.localUtil.CToN( cgiGet( "IsConfirmed"), ".", ","));
               IsModified = (short)(context.localUtil.CToN( cgiGet( "IsModified"), ".", ","));
               Gx_mode = cgiGet( "Mode");
               Gx_BScreen = (short)(context.localUtil.CToN( cgiGet( "vGXBSCREEN"), ".", ","));
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
                  A437SYS_TenantUserAccessUserAccessID = (Guid)(StringUtil.StrToGuid( GetNextPar( )));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A437SYS_TenantUserAccessUserAccessID", A437SYS_TenantUserAccessUserAccessID.ToString());
                  getEqualNoModal( ) ;
                  if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  && (Guid.Empty==A437SYS_TenantUserAccessUserAccessID) && ( Gx_BScreen == 0 ) )
                  {
                     A437SYS_TenantUserAccessUserAccessID = (Guid)(Guid.NewGuid( ));
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A437SYS_TenantUserAccessUserAccessID", A437SYS_TenantUserAccessUserAccessID.ToString());
                  }
                  Gx_mode = "DSP";
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                  disable_std_buttons_dsp( ) ;
                  standaloneModal( ) ;
               }
               else
               {
                  getEqualNoModal( ) ;
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
               InitAll1A62( ) ;
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
         DisableAttributes1A62( ) ;
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

      protected void ResetCaption1A0( )
      {
      }

      protected void ZM1A62( short GX_JID )
      {
         if ( ( GX_JID == 5 ) || ( GX_JID == 0 ) )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
            {
               Z439SYS_TenantUserAccessUserID = (Guid)(T001A3_A439SYS_TenantUserAccessUserID[0]);
               Z438SYS_TenantUserAccessTenantCode = T001A3_A438SYS_TenantUserAccessTenantCode[0];
               Z440SYS_TenantUserAccessDataPackage = T001A3_A440SYS_TenantUserAccessDataPackage[0];
            }
            else
            {
               Z439SYS_TenantUserAccessUserID = (Guid)(A439SYS_TenantUserAccessUserID);
               Z438SYS_TenantUserAccessTenantCode = A438SYS_TenantUserAccessTenantCode;
               Z440SYS_TenantUserAccessDataPackage = A440SYS_TenantUserAccessDataPackage;
            }
         }
         if ( GX_JID == -5 )
         {
            Z437SYS_TenantUserAccessUserAccessID = (Guid)(A437SYS_TenantUserAccessUserAccessID);
            Z439SYS_TenantUserAccessUserID = (Guid)(A439SYS_TenantUserAccessUserID);
            Z438SYS_TenantUserAccessTenantCode = A438SYS_TenantUserAccessTenantCode;
            Z440SYS_TenantUserAccessDataPackage = A440SYS_TenantUserAccessDataPackage;
         }
      }

      protected void standaloneNotModal( )
      {
         Gx_BScreen = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_BScreen", StringUtil.Str( (decimal)(Gx_BScreen), 1, 0));
      }

      protected void standaloneModal( )
      {
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  && (Guid.Empty==A439SYS_TenantUserAccessUserID) && ( Gx_BScreen == 0 ) )
         {
            A439SYS_TenantUserAccessUserID = (Guid)(Guid.NewGuid( ));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A439SYS_TenantUserAccessUserID", A439SYS_TenantUserAccessUserID.ToString());
         }
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  && (Guid.Empty==A437SYS_TenantUserAccessUserAccessID) && ( Gx_BScreen == 0 ) )
         {
            A437SYS_TenantUserAccessUserAccessID = (Guid)(Guid.NewGuid( ));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A437SYS_TenantUserAccessUserAccessID", A437SYS_TenantUserAccessUserAccessID.ToString());
         }
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
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) && ( Gx_BScreen == 0 ) )
         {
         }
      }

      protected void Load1A62( )
      {
         /* Using cursor T001A4 */
         pr_datastore1.execute(2, new Object[] {A437SYS_TenantUserAccessUserAccessID});
         if ( (pr_datastore1.getStatus(2) != 101) )
         {
            RcdFound62 = 1;
            A439SYS_TenantUserAccessUserID = (Guid)((Guid)(T001A4_A439SYS_TenantUserAccessUserID[0]));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A439SYS_TenantUserAccessUserID", A439SYS_TenantUserAccessUserID.ToString());
            A438SYS_TenantUserAccessTenantCode = T001A4_A438SYS_TenantUserAccessTenantCode[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A438SYS_TenantUserAccessTenantCode", A438SYS_TenantUserAccessTenantCode);
            A440SYS_TenantUserAccessDataPackage = T001A4_A440SYS_TenantUserAccessDataPackage[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A440SYS_TenantUserAccessDataPackage", A440SYS_TenantUserAccessDataPackage);
            ZM1A62( -5) ;
         }
         pr_datastore1.close(2);
         OnLoadActions1A62( ) ;
      }

      protected void OnLoadActions1A62( )
      {
      }

      protected void CheckExtendedTable1A62( )
      {
         Gx_BScreen = 1;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_BScreen", StringUtil.Str( (decimal)(Gx_BScreen), 1, 0));
         standaloneModal( ) ;
      }

      protected void CloseExtendedTableCursors1A62( )
      {
      }

      protected void enableDisable( )
      {
      }

      protected void GetKey1A62( )
      {
         /* Using cursor T001A5 */
         pr_datastore1.execute(3, new Object[] {A437SYS_TenantUserAccessUserAccessID});
         if ( (pr_datastore1.getStatus(3) != 101) )
         {
            RcdFound62 = 1;
         }
         else
         {
            RcdFound62 = 0;
         }
         pr_datastore1.close(3);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor T001A3 */
         pr_datastore1.execute(1, new Object[] {A437SYS_TenantUserAccessUserAccessID});
         if ( (pr_datastore1.getStatus(1) != 101) )
         {
            ZM1A62( 5) ;
            RcdFound62 = 1;
            A437SYS_TenantUserAccessUserAccessID = (Guid)((Guid)(T001A3_A437SYS_TenantUserAccessUserAccessID[0]));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A437SYS_TenantUserAccessUserAccessID", A437SYS_TenantUserAccessUserAccessID.ToString());
            A439SYS_TenantUserAccessUserID = (Guid)((Guid)(T001A3_A439SYS_TenantUserAccessUserID[0]));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A439SYS_TenantUserAccessUserID", A439SYS_TenantUserAccessUserID.ToString());
            A438SYS_TenantUserAccessTenantCode = T001A3_A438SYS_TenantUserAccessTenantCode[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A438SYS_TenantUserAccessTenantCode", A438SYS_TenantUserAccessTenantCode);
            A440SYS_TenantUserAccessDataPackage = T001A3_A440SYS_TenantUserAccessDataPackage[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A440SYS_TenantUserAccessDataPackage", A440SYS_TenantUserAccessDataPackage);
            Z437SYS_TenantUserAccessUserAccessID = (Guid)(A437SYS_TenantUserAccessUserAccessID);
            sMode62 = Gx_mode;
            Gx_mode = "DSP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            standaloneModal( ) ;
            Load1A62( ) ;
            if ( AnyError == 1 )
            {
               RcdFound62 = 0;
               InitializeNonKey1A62( ) ;
            }
            Gx_mode = sMode62;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         else
         {
            RcdFound62 = 0;
            InitializeNonKey1A62( ) ;
            sMode62 = Gx_mode;
            Gx_mode = "DSP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            standaloneModal( ) ;
            Gx_mode = sMode62;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         pr_datastore1.close(1);
      }

      protected void getEqualNoModal( )
      {
         GetKey1A62( ) ;
         if ( RcdFound62 == 0 )
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
         RcdFound62 = 0;
         /* Using cursor T001A6 */
         pr_datastore1.execute(4, new Object[] {A437SYS_TenantUserAccessUserAccessID});
         if ( (pr_datastore1.getStatus(4) != 101) )
         {
            while ( (pr_datastore1.getStatus(4) != 101) && ( ( GuidUtil.Compare(T001A6_A437SYS_TenantUserAccessUserAccessID[0], A437SYS_TenantUserAccessUserAccessID, 1) < 0 ) ) )
            {
               pr_datastore1.readNext(4);
            }
            if ( (pr_datastore1.getStatus(4) != 101) && ( ( GuidUtil.Compare(T001A6_A437SYS_TenantUserAccessUserAccessID[0], A437SYS_TenantUserAccessUserAccessID, 1) > 0 ) ) )
            {
               A437SYS_TenantUserAccessUserAccessID = (Guid)((Guid)(T001A6_A437SYS_TenantUserAccessUserAccessID[0]));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A437SYS_TenantUserAccessUserAccessID", A437SYS_TenantUserAccessUserAccessID.ToString());
               RcdFound62 = 1;
            }
         }
         pr_datastore1.close(4);
      }

      protected void move_previous( )
      {
         RcdFound62 = 0;
         /* Using cursor T001A7 */
         pr_datastore1.execute(5, new Object[] {A437SYS_TenantUserAccessUserAccessID});
         if ( (pr_datastore1.getStatus(5) != 101) )
         {
            while ( (pr_datastore1.getStatus(5) != 101) && ( ( GuidUtil.Compare(T001A7_A437SYS_TenantUserAccessUserAccessID[0], A437SYS_TenantUserAccessUserAccessID, 1) > 0 ) ) )
            {
               pr_datastore1.readNext(5);
            }
            if ( (pr_datastore1.getStatus(5) != 101) && ( ( GuidUtil.Compare(T001A7_A437SYS_TenantUserAccessUserAccessID[0], A437SYS_TenantUserAccessUserAccessID, 1) < 0 ) ) )
            {
               A437SYS_TenantUserAccessUserAccessID = (Guid)((Guid)(T001A7_A437SYS_TenantUserAccessUserAccessID[0]));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A437SYS_TenantUserAccessUserAccessID", A437SYS_TenantUserAccessUserAccessID.ToString());
               RcdFound62 = 1;
            }
         }
         pr_datastore1.close(5);
      }

      protected void btn_enter( )
      {
         nKeyPressed = 1;
         GetKey1A62( ) ;
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            /* Insert record */
            GX_FocusControl = edtSYS_TenantUserAccessUserAccessID_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            Insert1A62( ) ;
            if ( AnyError == 1 )
            {
               GX_FocusControl = "";
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
         }
         else
         {
            if ( RcdFound62 == 1 )
            {
               if ( A437SYS_TenantUserAccessUserAccessID != Z437SYS_TenantUserAccessUserAccessID )
               {
                  A437SYS_TenantUserAccessUserAccessID = (Guid)(Z437SYS_TenantUserAccessUserAccessID);
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A437SYS_TenantUserAccessUserAccessID", A437SYS_TenantUserAccessUserAccessID.ToString());
                  GX_msglist.addItem(context.GetMessage( "GXM_getbeforeupd", ""), "CandidateKeyNotFound", 1, "SYS_TENANTUSERACCESSUSERACCESSID");
                  AnyError = 1;
                  GX_FocusControl = edtSYS_TenantUserAccessUserAccessID_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
               else if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
               {
                  delete( ) ;
                  AfterTrn( ) ;
                  GX_FocusControl = edtSYS_TenantUserAccessUserAccessID_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
               else
               {
                  Gx_mode = "UPD";
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                  /* Update record */
                  Update1A62( ) ;
                  GX_FocusControl = edtSYS_TenantUserAccessUserAccessID_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
            }
            else
            {
               if ( A437SYS_TenantUserAccessUserAccessID != Z437SYS_TenantUserAccessUserAccessID )
               {
                  Gx_mode = "INS";
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                  /* Insert record */
                  GX_FocusControl = edtSYS_TenantUserAccessUserAccessID_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  Insert1A62( ) ;
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
                     GX_msglist.addItem(context.GetMessage( "GXM_recdeleted", ""), 1, "SYS_TENANTUSERACCESSUSERACCESSID");
                     AnyError = 1;
                     GX_FocusControl = edtSYS_TenantUserAccessUserAccessID_Internalname;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  }
                  else
                  {
                     Gx_mode = "INS";
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                     /* Insert record */
                     GX_FocusControl = edtSYS_TenantUserAccessUserAccessID_Internalname;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                     Insert1A62( ) ;
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
         if ( A437SYS_TenantUserAccessUserAccessID != Z437SYS_TenantUserAccessUserAccessID )
         {
            A437SYS_TenantUserAccessUserAccessID = (Guid)(Z437SYS_TenantUserAccessUserAccessID);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A437SYS_TenantUserAccessUserAccessID", A437SYS_TenantUserAccessUserAccessID.ToString());
            GX_msglist.addItem(context.GetMessage( "GXM_getbeforedlt", ""), 1, "SYS_TENANTUSERACCESSUSERACCESSID");
            AnyError = 1;
            GX_FocusControl = edtSYS_TenantUserAccessUserAccessID_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         else
         {
            delete( ) ;
            AfterTrn( ) ;
            GX_FocusControl = edtSYS_TenantUserAccessUserAccessID_Internalname;
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
         if ( RcdFound62 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_keynfound", ""), "PrimaryKeyNotFound", 1, "SYS_TENANTUSERACCESSUSERACCESSID");
            AnyError = 1;
            GX_FocusControl = edtSYS_TenantUserAccessUserAccessID_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         GX_FocusControl = edtSYS_TenantUserAccessUserID_Internalname;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_first( )
      {
         nKeyPressed = 2;
         IsConfirmed = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "IsConfirmed", StringUtil.LTrim( StringUtil.Str( (decimal)(IsConfirmed), 4, 0)));
         ScanStart1A62( ) ;
         if ( RcdFound62 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "", true);
         }
         else
         {
            Gx_mode = "UPD";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtSYS_TenantUserAccessUserID_Internalname;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         ScanEnd1A62( ) ;
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
         if ( RcdFound62 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "", true);
         }
         else
         {
            Gx_mode = "UPD";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtSYS_TenantUserAccessUserID_Internalname;
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
         if ( RcdFound62 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "", true);
         }
         else
         {
            Gx_mode = "UPD";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtSYS_TenantUserAccessUserID_Internalname;
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
         ScanStart1A62( ) ;
         if ( RcdFound62 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "", true);
         }
         else
         {
            while ( RcdFound62 != 0 )
            {
               ScanNext1A62( ) ;
            }
            Gx_mode = "UPD";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtSYS_TenantUserAccessUserID_Internalname;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         ScanEnd1A62( ) ;
         getByPrimaryKey( ) ;
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_select( )
      {
         getEqualNoModal( ) ;
      }

      protected void CheckOptimisticConcurrency1A62( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor T001A2 */
            pr_datastore1.execute(0, new Object[] {A437SYS_TenantUserAccessUserAccessID});
            if ( (pr_datastore1.getStatus(0) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"SYS_TENANTUSERACCESS"}), "RecordIsLocked", 1, "");
               AnyError = 1;
               return  ;
            }
            if ( (pr_datastore1.getStatus(0) == 101) || ( Z439SYS_TenantUserAccessUserID != T001A2_A439SYS_TenantUserAccessUserID[0] ) || ( StringUtil.StrCmp(Z438SYS_TenantUserAccessTenantCode, T001A2_A438SYS_TenantUserAccessTenantCode[0]) != 0 ) || ( StringUtil.StrCmp(Z440SYS_TenantUserAccessDataPackage, T001A2_A440SYS_TenantUserAccessDataPackage[0]) != 0 ) )
            {
               if ( Z439SYS_TenantUserAccessUserID != T001A2_A439SYS_TenantUserAccessUserID[0] )
               {
                  GXUtil.WriteLog("sys_tenantuseraccess:[seudo value changed for attri]"+"SYS_TenantUserAccessUserID");
                  GXUtil.WriteLogRaw("Old: ",Z439SYS_TenantUserAccessUserID);
                  GXUtil.WriteLogRaw("Current: ",T001A2_A439SYS_TenantUserAccessUserID[0]);
               }
               if ( StringUtil.StrCmp(Z438SYS_TenantUserAccessTenantCode, T001A2_A438SYS_TenantUserAccessTenantCode[0]) != 0 )
               {
                  GXUtil.WriteLog("sys_tenantuseraccess:[seudo value changed for attri]"+"SYS_TenantUserAccessTenantCode");
                  GXUtil.WriteLogRaw("Old: ",Z438SYS_TenantUserAccessTenantCode);
                  GXUtil.WriteLogRaw("Current: ",T001A2_A438SYS_TenantUserAccessTenantCode[0]);
               }
               if ( StringUtil.StrCmp(Z440SYS_TenantUserAccessDataPackage, T001A2_A440SYS_TenantUserAccessDataPackage[0]) != 0 )
               {
                  GXUtil.WriteLog("sys_tenantuseraccess:[seudo value changed for attri]"+"SYS_TenantUserAccessDataPackage");
                  GXUtil.WriteLogRaw("Old: ",Z440SYS_TenantUserAccessDataPackage);
                  GXUtil.WriteLogRaw("Current: ",T001A2_A440SYS_TenantUserAccessDataPackage[0]);
               }
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"SYS_TENANTUSERACCESS"}), "RecordWasChanged", 1, "");
               AnyError = 1;
               return  ;
            }
         }
      }

      protected void Insert1A62( )
      {
         BeforeValidate1A62( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable1A62( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM1A62( 0) ;
            CheckOptimisticConcurrency1A62( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm1A62( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert1A62( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T001A8 */
                     pr_datastore1.execute(6, new Object[] {A438SYS_TenantUserAccessTenantCode, A440SYS_TenantUserAccessDataPackage, A437SYS_TenantUserAccessUserAccessID, A439SYS_TenantUserAccessUserID});
                     pr_datastore1.close(6);
                     dsDataStore1.SmartCacheProvider.SetUpdated("SYS_TENANTUSERACCESS") ;
                     if ( (pr_datastore1.getStatus(6) == 1) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_noupdate", ""), "DuplicatePrimaryKey", 1, "");
                        AnyError = 1;
                     }
                     if ( AnyError == 0 )
                     {
                        /* Start of After( Insert) rules */
                        /* End of After( Insert) rules */
                        if ( AnyError == 0 )
                        {
                           /* Save values for previous() function. */
                           GX_msglist.addItem(context.GetMessage( "GXM_sucadded", ""), "SuccessfullyAdded", 0, "", true);
                           ResetCaption1A0( ) ;
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
               Load1A62( ) ;
            }
            EndLevel1A62( ) ;
         }
         CloseExtendedTableCursors1A62( ) ;
      }

      protected void Update1A62( )
      {
         BeforeValidate1A62( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable1A62( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency1A62( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm1A62( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate1A62( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T001A9 */
                     pr_datastore1.execute(7, new Object[] {A439SYS_TenantUserAccessUserID, A438SYS_TenantUserAccessTenantCode, A440SYS_TenantUserAccessDataPackage, A437SYS_TenantUserAccessUserAccessID});
                     pr_datastore1.close(7);
                     dsDataStore1.SmartCacheProvider.SetUpdated("SYS_TENANTUSERACCESS") ;
                     if ( (pr_datastore1.getStatus(7) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"SYS_TENANTUSERACCESS"}), "RecordIsLocked", 1, "");
                        AnyError = 1;
                     }
                     DeferredUpdate1A62( ) ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( update) rules */
                        /* End of After( update) rules */
                        if ( AnyError == 0 )
                        {
                           getByPrimaryKey( ) ;
                           GX_msglist.addItem(context.GetMessage( "GXM_sucupdated", ""), "SuccessfullyUpdated", 0, "", true);
                           ResetCaption1A0( ) ;
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
            EndLevel1A62( ) ;
         }
         CloseExtendedTableCursors1A62( ) ;
      }

      protected void DeferredUpdate1A62( )
      {
      }

      protected void delete( )
      {
         Gx_mode = "DLT";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         BeforeValidate1A62( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency1A62( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls1A62( ) ;
            AfterConfirm1A62( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete1A62( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor T001A10 */
                  pr_datastore1.execute(8, new Object[] {A437SYS_TenantUserAccessUserAccessID});
                  pr_datastore1.close(8);
                  dsDataStore1.SmartCacheProvider.SetUpdated("SYS_TENANTUSERACCESS") ;
                  if ( AnyError == 0 )
                  {
                     /* Start of After( delete) rules */
                     /* End of After( delete) rules */
                     if ( AnyError == 0 )
                     {
                        move_next( ) ;
                        if ( RcdFound62 == 0 )
                        {
                           InitAll1A62( ) ;
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
                        ResetCaption1A0( ) ;
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
         sMode62 = Gx_mode;
         Gx_mode = "DLT";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         EndLevel1A62( ) ;
         Gx_mode = sMode62;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
      }

      protected void OnDeleteControls1A62( )
      {
         standaloneModal( ) ;
         /* No delete mode formulas found. */
      }

      protected void EndLevel1A62( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            pr_datastore1.close(0);
         }
         if ( AnyError == 0 )
         {
            BeforeComplete1A62( ) ;
         }
         if ( AnyError == 0 )
         {
            pr_datastore1.close(1);
            context.CommitDataStores("sys_tenantuseraccess",pr_default);
            if ( AnyError == 0 )
            {
               ConfirmValues1A0( ) ;
            }
            /* After transaction rules */
            /* Execute 'After Trn' event if defined. */
            trnEnded = 1;
         }
         else
         {
            pr_datastore1.close(1);
            context.RollbackDataStores("sys_tenantuseraccess",pr_default);
         }
         IsModified = 0;
         if ( AnyError != 0 )
         {
            context.wjLoc = "";
            context.nUserReturn = 0;
         }
      }

      public void ScanStart1A62( )
      {
         /* Using cursor T001A11 */
         pr_datastore1.execute(9);
         RcdFound62 = 0;
         if ( (pr_datastore1.getStatus(9) != 101) )
         {
            RcdFound62 = 1;
            A437SYS_TenantUserAccessUserAccessID = (Guid)((Guid)(T001A11_A437SYS_TenantUserAccessUserAccessID[0]));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A437SYS_TenantUserAccessUserAccessID", A437SYS_TenantUserAccessUserAccessID.ToString());
         }
         /* Load Subordinate Levels */
      }

      protected void ScanNext1A62( )
      {
         /* Scan next routine */
         pr_datastore1.readNext(9);
         RcdFound62 = 0;
         if ( (pr_datastore1.getStatus(9) != 101) )
         {
            RcdFound62 = 1;
            A437SYS_TenantUserAccessUserAccessID = (Guid)((Guid)(T001A11_A437SYS_TenantUserAccessUserAccessID[0]));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A437SYS_TenantUserAccessUserAccessID", A437SYS_TenantUserAccessUserAccessID.ToString());
         }
      }

      protected void ScanEnd1A62( )
      {
         pr_datastore1.close(9);
      }

      protected void AfterConfirm1A62( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert1A62( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate1A62( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete1A62( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete1A62( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate1A62( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes1A62( )
      {
         edtSYS_TenantUserAccessUserAccessID_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtSYS_TenantUserAccessUserAccessID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtSYS_TenantUserAccessUserAccessID_Enabled), 5, 0)), true);
         edtSYS_TenantUserAccessUserID_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtSYS_TenantUserAccessUserID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtSYS_TenantUserAccessUserID_Enabled), 5, 0)), true);
         edtSYS_TenantUserAccessTenantCode_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtSYS_TenantUserAccessTenantCode_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtSYS_TenantUserAccessTenantCode_Enabled), 5, 0)), true);
         edtSYS_TenantUserAccessDataPackage_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtSYS_TenantUserAccessDataPackage_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtSYS_TenantUserAccessDataPackage_Enabled), 5, 0)), true);
      }

      protected void send_integrity_lvl_hashes1A62( )
      {
      }

      protected void assign_properties_default( )
      {
      }

      protected void ConfirmValues1A0( )
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
         context.AddJavascriptSource("gxcfg.js", "?20202271158778", false);
         if ( context.isSpaRequest( ) )
         {
            enableOutput();
         }
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" autocomplete=\"off\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("sys_tenantuseraccess.aspx") +"\">") ;
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
         GxWebStd.gx_hidden_field( context, "Z437SYS_TenantUserAccessUserAccessID", Z437SYS_TenantUserAccessUserAccessID.ToString());
         GxWebStd.gx_hidden_field( context, "Z439SYS_TenantUserAccessUserID", Z439SYS_TenantUserAccessUserID.ToString());
         GxWebStd.gx_hidden_field( context, "Z438SYS_TenantUserAccessTenantCode", Z438SYS_TenantUserAccessTenantCode);
         GxWebStd.gx_hidden_field( context, "Z440SYS_TenantUserAccessDataPackage", Z440SYS_TenantUserAccessDataPackage);
         GxWebStd.gx_hidden_field( context, "IsConfirmed", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsConfirmed), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "IsModified", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsModified), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "Mode", StringUtil.RTrim( Gx_mode));
         GxWebStd.gx_hidden_field( context, "vGXBSCREEN", StringUtil.LTrim( StringUtil.NToC( (decimal)(Gx_BScreen), 1, 0, ".", "")));
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
         return formatLink("sys_tenantuseraccess.aspx")  ;
      }

      public override String GetPgmname( )
      {
         return "SYS_TenantUserAccess" ;
      }

      public override String GetPgmdesc( )
      {
         return "SYS_Tenant User Access" ;
      }

      protected void InitializeNonKey1A62( )
      {
         A438SYS_TenantUserAccessTenantCode = "";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A438SYS_TenantUserAccessTenantCode", A438SYS_TenantUserAccessTenantCode);
         A440SYS_TenantUserAccessDataPackage = "";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A440SYS_TenantUserAccessDataPackage", A440SYS_TenantUserAccessDataPackage);
         A439SYS_TenantUserAccessUserID = (Guid)(Guid.NewGuid( ));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A439SYS_TenantUserAccessUserID", A439SYS_TenantUserAccessUserID.ToString());
         Z439SYS_TenantUserAccessUserID = (Guid)(Guid.Empty);
         Z438SYS_TenantUserAccessTenantCode = "";
         Z440SYS_TenantUserAccessDataPackage = "";
      }

      protected void InitAll1A62( )
      {
         A437SYS_TenantUserAccessUserAccessID = (Guid)(Guid.NewGuid( ));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A437SYS_TenantUserAccessUserAccessID", A437SYS_TenantUserAccessUserAccessID.ToString());
         InitializeNonKey1A62( ) ;
      }

      protected void StandaloneModalInsert( )
      {
         A439SYS_TenantUserAccessUserID = (Guid)(i439SYS_TenantUserAccessUserID);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A439SYS_TenantUserAccessUserID", A439SYS_TenantUserAccessUserID.ToString());
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
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?20202271158782", true);
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
         context.AddJavascriptSource("sys_tenantuseraccess.js", "?20202271158783", false);
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
         edtSYS_TenantUserAccessUserAccessID_Internalname = "SYS_TENANTUSERACCESSUSERACCESSID";
         edtSYS_TenantUserAccessUserID_Internalname = "SYS_TENANTUSERACCESSUSERID";
         edtSYS_TenantUserAccessTenantCode_Internalname = "SYS_TENANTUSERACCESSTENANTCODE";
         edtSYS_TenantUserAccessDataPackage_Internalname = "SYS_TENANTUSERACCESSDATAPACKAGE";
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
         Form.Caption = "SYS_Tenant User Access";
         bttBtn_delete_Enabled = 1;
         bttBtn_delete_Visible = 1;
         bttBtn_cancel_Visible = 1;
         bttBtn_enter_Enabled = 1;
         bttBtn_enter_Visible = 1;
         edtSYS_TenantUserAccessDataPackage_Jsonclick = "";
         edtSYS_TenantUserAccessDataPackage_Enabled = 1;
         edtSYS_TenantUserAccessTenantCode_Jsonclick = "";
         edtSYS_TenantUserAccessTenantCode_Enabled = 1;
         edtSYS_TenantUserAccessUserID_Jsonclick = "";
         edtSYS_TenantUserAccessUserID_Enabled = 1;
         edtSYS_TenantUserAccessUserAccessID_Jsonclick = "";
         edtSYS_TenantUserAccessUserAccessID_Enabled = 1;
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
         GX_FocusControl = edtSYS_TenantUserAccessUserID_Internalname;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         standaloneNotModal( ) ;
         standaloneModal( ) ;
         /* End function AfterKeyLoadScreen */
      }

      public void Valid_Sys_tenantuseraccessuseraccessid( Guid GX_Parm1 ,
                                                          Guid GX_Parm2 ,
                                                          String GX_Parm3 ,
                                                          String GX_Parm4 )
      {
         A437SYS_TenantUserAccessUserAccessID = (Guid)(GX_Parm1);
         A439SYS_TenantUserAccessUserID = (Guid)(GX_Parm2);
         A438SYS_TenantUserAccessTenantCode = GX_Parm3;
         A440SYS_TenantUserAccessDataPackage = GX_Parm4;
         context.wbHandled = 1;
         AfterKeyLoadScreen( ) ;
         Draw( ) ;
         send_integrity_footer_hashes( ) ;
         dynload_actions( ) ;
         if ( AnyError == 1 )
         {
         }
         isValidOutput.Add(A439SYS_TenantUserAccessUserID.ToString());
         isValidOutput.Add(A438SYS_TenantUserAccessTenantCode);
         isValidOutput.Add(A440SYS_TenantUserAccessDataPackage);
         isValidOutput.Add(StringUtil.RTrim( Gx_mode));
         isValidOutput.Add(Z437SYS_TenantUserAccessUserAccessID.ToString());
         isValidOutput.Add(Z439SYS_TenantUserAccessUserID.ToString());
         isValidOutput.Add(Z438SYS_TenantUserAccessTenantCode);
         isValidOutput.Add(Z440SYS_TenantUserAccessDataPackage);
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
         Z437SYS_TenantUserAccessUserAccessID = (Guid)(Guid.Empty);
         Z439SYS_TenantUserAccessUserID = (Guid)(Guid.Empty);
         Z438SYS_TenantUserAccessTenantCode = "";
         Z440SYS_TenantUserAccessDataPackage = "";
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
         A437SYS_TenantUserAccessUserAccessID = (Guid)(Guid.Empty);
         A439SYS_TenantUserAccessUserID = (Guid)(Guid.Empty);
         A438SYS_TenantUserAccessTenantCode = "";
         A440SYS_TenantUserAccessDataPackage = "";
         bttBtn_enter_Jsonclick = "";
         bttBtn_cancel_Jsonclick = "";
         bttBtn_delete_Jsonclick = "";
         Gx_mode = "";
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         T001A4_A437SYS_TenantUserAccessUserAccessID = new Guid[] {Guid.Empty} ;
         T001A4_A439SYS_TenantUserAccessUserID = new Guid[] {Guid.Empty} ;
         T001A4_A438SYS_TenantUserAccessTenantCode = new String[] {""} ;
         T001A4_A440SYS_TenantUserAccessDataPackage = new String[] {""} ;
         T001A5_A437SYS_TenantUserAccessUserAccessID = new Guid[] {Guid.Empty} ;
         T001A3_A437SYS_TenantUserAccessUserAccessID = new Guid[] {Guid.Empty} ;
         T001A3_A439SYS_TenantUserAccessUserID = new Guid[] {Guid.Empty} ;
         T001A3_A438SYS_TenantUserAccessTenantCode = new String[] {""} ;
         T001A3_A440SYS_TenantUserAccessDataPackage = new String[] {""} ;
         sMode62 = "";
         T001A6_A437SYS_TenantUserAccessUserAccessID = new Guid[] {Guid.Empty} ;
         T001A7_A437SYS_TenantUserAccessUserAccessID = new Guid[] {Guid.Empty} ;
         T001A2_A437SYS_TenantUserAccessUserAccessID = new Guid[] {Guid.Empty} ;
         T001A2_A439SYS_TenantUserAccessUserID = new Guid[] {Guid.Empty} ;
         T001A2_A438SYS_TenantUserAccessTenantCode = new String[] {""} ;
         T001A2_A440SYS_TenantUserAccessDataPackage = new String[] {""} ;
         T001A11_A437SYS_TenantUserAccessUserAccessID = new Guid[] {Guid.Empty} ;
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         i439SYS_TenantUserAccessUserID = (Guid)(Guid.Empty);
         isValidOutput = new GxUnknownObjectCollection();
         pr_datastore1 = new DataStoreProvider(context, new GeneXus.Programs.sys_tenantuseraccess__datastore1(),
            new Object[][] {
                new Object[] {
               T001A2_A437SYS_TenantUserAccessUserAccessID, T001A2_A439SYS_TenantUserAccessUserID, T001A2_A438SYS_TenantUserAccessTenantCode, T001A2_A440SYS_TenantUserAccessDataPackage
               }
               , new Object[] {
               T001A3_A437SYS_TenantUserAccessUserAccessID, T001A3_A439SYS_TenantUserAccessUserID, T001A3_A438SYS_TenantUserAccessTenantCode, T001A3_A440SYS_TenantUserAccessDataPackage
               }
               , new Object[] {
               T001A4_A437SYS_TenantUserAccessUserAccessID, T001A4_A439SYS_TenantUserAccessUserID, T001A4_A438SYS_TenantUserAccessTenantCode, T001A4_A440SYS_TenantUserAccessDataPackage
               }
               , new Object[] {
               T001A5_A437SYS_TenantUserAccessUserAccessID
               }
               , new Object[] {
               T001A6_A437SYS_TenantUserAccessUserAccessID
               }
               , new Object[] {
               T001A7_A437SYS_TenantUserAccessUserAccessID
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               T001A11_A437SYS_TenantUserAccessUserAccessID
               }
            }
         );
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.sys_tenantuseraccess__default(),
            new Object[][] {
            }
         );
         Z439SYS_TenantUserAccessUserID = (Guid)(Guid.NewGuid( ));
         A439SYS_TenantUserAccessUserID = (Guid)(Guid.NewGuid( ));
         i439SYS_TenantUserAccessUserID = (Guid)(Guid.NewGuid( ));
         Z437SYS_TenantUserAccessUserAccessID = (Guid)(Guid.NewGuid( ));
         A437SYS_TenantUserAccessUserAccessID = (Guid)(Guid.NewGuid( ));
      }

      private short GxWebError ;
      private short gxcookieaux ;
      private short IsConfirmed ;
      private short IsModified ;
      private short AnyError ;
      private short nKeyPressed ;
      private short initialized ;
      private short Gx_BScreen ;
      private short GX_JID ;
      private short RcdFound62 ;
      private short gxajaxcallmode ;
      private short wbTemp ;
      private int trnEnded ;
      private int bttBtn_first_Visible ;
      private int bttBtn_previous_Visible ;
      private int bttBtn_next_Visible ;
      private int bttBtn_last_Visible ;
      private int bttBtn_select_Visible ;
      private int edtSYS_TenantUserAccessUserAccessID_Enabled ;
      private int edtSYS_TenantUserAccessUserID_Enabled ;
      private int edtSYS_TenantUserAccessTenantCode_Enabled ;
      private int edtSYS_TenantUserAccessDataPackage_Enabled ;
      private int bttBtn_enter_Visible ;
      private int bttBtn_enter_Enabled ;
      private int bttBtn_cancel_Visible ;
      private int bttBtn_delete_Visible ;
      private int bttBtn_delete_Enabled ;
      private int idxLst ;
      private String sPrefix ;
      private String scmdbuf ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String GXKey ;
      private String PreviousTooltip ;
      private String PreviousCaption ;
      private String GX_FocusControl ;
      private String edtSYS_TenantUserAccessUserAccessID_Internalname ;
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
      private String edtSYS_TenantUserAccessUserAccessID_Jsonclick ;
      private String edtSYS_TenantUserAccessUserID_Internalname ;
      private String edtSYS_TenantUserAccessUserID_Jsonclick ;
      private String edtSYS_TenantUserAccessTenantCode_Internalname ;
      private String edtSYS_TenantUserAccessTenantCode_Jsonclick ;
      private String edtSYS_TenantUserAccessDataPackage_Internalname ;
      private String edtSYS_TenantUserAccessDataPackage_Jsonclick ;
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
      private String sMode62 ;
      private String sDynURL ;
      private String FormProcess ;
      private String bodyStyle ;
      private bool entryPointCalled ;
      private bool toggleJsOutput ;
      private bool wbErr ;
      private String Z438SYS_TenantUserAccessTenantCode ;
      private String Z440SYS_TenantUserAccessDataPackage ;
      private String A438SYS_TenantUserAccessTenantCode ;
      private String A440SYS_TenantUserAccessDataPackage ;
      private Guid Z437SYS_TenantUserAccessUserAccessID ;
      private Guid Z439SYS_TenantUserAccessUserID ;
      private Guid A437SYS_TenantUserAccessUserAccessID ;
      private Guid A439SYS_TenantUserAccessUserID ;
      private Guid i439SYS_TenantUserAccessUserID ;
      private GxUnknownObjectCollection isValidOutput ;
      private IGxDataStore dsDataStore1 ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_datastore1 ;
      private Guid[] T001A4_A437SYS_TenantUserAccessUserAccessID ;
      private Guid[] T001A4_A439SYS_TenantUserAccessUserID ;
      private String[] T001A4_A438SYS_TenantUserAccessTenantCode ;
      private String[] T001A4_A440SYS_TenantUserAccessDataPackage ;
      private Guid[] T001A5_A437SYS_TenantUserAccessUserAccessID ;
      private Guid[] T001A3_A437SYS_TenantUserAccessUserAccessID ;
      private Guid[] T001A3_A439SYS_TenantUserAccessUserID ;
      private String[] T001A3_A438SYS_TenantUserAccessTenantCode ;
      private String[] T001A3_A440SYS_TenantUserAccessDataPackage ;
      private Guid[] T001A6_A437SYS_TenantUserAccessUserAccessID ;
      private Guid[] T001A7_A437SYS_TenantUserAccessUserAccessID ;
      private Guid[] T001A2_A437SYS_TenantUserAccessUserAccessID ;
      private Guid[] T001A2_A439SYS_TenantUserAccessUserID ;
      private String[] T001A2_A438SYS_TenantUserAccessTenantCode ;
      private String[] T001A2_A440SYS_TenantUserAccessDataPackage ;
      private IDataStoreProvider pr_default ;
      private Guid[] T001A11_A437SYS_TenantUserAccessUserAccessID ;
      private GXWebForm Form ;
   }

   public class sys_tenantuseraccess__datastore1 : DataStoreHelperBase, IDataStoreHelper
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
         ,new UpdateCursor(def[6])
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
          Object[] prmT001A4 ;
          prmT001A4 = new Object[] {
          new Object[] {"@SYS_TenantUserAccessUserAccessID",SqlDbType.UniqueIdentifier,16,0}
          } ;
          Object[] prmT001A5 ;
          prmT001A5 = new Object[] {
          new Object[] {"@SYS_TenantUserAccessUserAccessID",SqlDbType.UniqueIdentifier,16,0}
          } ;
          Object[] prmT001A3 ;
          prmT001A3 = new Object[] {
          new Object[] {"@SYS_TenantUserAccessUserAccessID",SqlDbType.UniqueIdentifier,16,0}
          } ;
          Object[] prmT001A6 ;
          prmT001A6 = new Object[] {
          new Object[] {"@SYS_TenantUserAccessUserAccessID",SqlDbType.UniqueIdentifier,16,0}
          } ;
          Object[] prmT001A7 ;
          prmT001A7 = new Object[] {
          new Object[] {"@SYS_TenantUserAccessUserAccessID",SqlDbType.UniqueIdentifier,16,0}
          } ;
          Object[] prmT001A2 ;
          prmT001A2 = new Object[] {
          new Object[] {"@SYS_TenantUserAccessUserAccessID",SqlDbType.UniqueIdentifier,16,0}
          } ;
          Object[] prmT001A8 ;
          prmT001A8 = new Object[] {
          new Object[] {"@SYS_TenantUserAccessTenantCode",SqlDbType.NVarChar,20,0} ,
          new Object[] {"@SYS_TenantUserAccessDataPackage",SqlDbType.NVarChar,50,0} ,
          new Object[] {"@SYS_TenantUserAccessUserAccessID",SqlDbType.UniqueIdentifier,16,0} ,
          new Object[] {"@SYS_TenantUserAccessUserID",SqlDbType.UniqueIdentifier,16,0}
          } ;
          Object[] prmT001A9 ;
          prmT001A9 = new Object[] {
          new Object[] {"@SYS_TenantUserAccessUserID",SqlDbType.UniqueIdentifier,16,0} ,
          new Object[] {"@SYS_TenantUserAccessTenantCode",SqlDbType.NVarChar,20,0} ,
          new Object[] {"@SYS_TenantUserAccessDataPackage",SqlDbType.NVarChar,50,0} ,
          new Object[] {"@SYS_TenantUserAccessUserAccessID",SqlDbType.UniqueIdentifier,16,0}
          } ;
          Object[] prmT001A10 ;
          prmT001A10 = new Object[] {
          new Object[] {"@SYS_TenantUserAccessUserAccessID",SqlDbType.UniqueIdentifier,16,0}
          } ;
          Object[] prmT001A11 ;
          prmT001A11 = new Object[] {
          } ;
          def= new CursorDef[] {
              new CursorDef("T001A2", "SELECT [UserAccessID], [UserID], [TenantCode], [DataPackage] FROM [SYS_TenantUserAccess] WITH (UPDLOCK) WHERE [UserAccessID] = @SYS_TenantUserAccessUserAccessID ",true, GxErrorMask.GX_NOMASK, false, this,prmT001A2,1,0,true,false )
             ,new CursorDef("T001A3", "SELECT [UserAccessID], [UserID], [TenantCode], [DataPackage] FROM [SYS_TenantUserAccess] WITH (NOLOCK) WHERE [UserAccessID] = @SYS_TenantUserAccessUserAccessID ",true, GxErrorMask.GX_NOMASK, false, this,prmT001A3,1,0,true,false )
             ,new CursorDef("T001A4", "SELECT TM1.[UserAccessID], TM1.[UserID], TM1.[TenantCode], TM1.[DataPackage] FROM [SYS_TenantUserAccess] TM1 WITH (NOLOCK) WHERE TM1.[UserAccessID] = @SYS_TenantUserAccessUserAccessID ORDER BY TM1.[UserAccessID]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT001A4,100,0,true,false )
             ,new CursorDef("T001A5", "SELECT [UserAccessID] FROM [SYS_TenantUserAccess] WITH (NOLOCK) WHERE [UserAccessID] = @SYS_TenantUserAccessUserAccessID  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT001A5,1,0,true,false )
             ,new CursorDef("T001A6", "SELECT TOP 1 [UserAccessID] FROM [SYS_TenantUserAccess] WITH (NOLOCK) WHERE ( [UserAccessID] > @SYS_TenantUserAccessUserAccessID) ORDER BY [UserAccessID]  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT001A6,1,0,true,true )
             ,new CursorDef("T001A7", "SELECT TOP 1 [UserAccessID] FROM [SYS_TenantUserAccess] WITH (NOLOCK) WHERE ( [UserAccessID] < @SYS_TenantUserAccessUserAccessID) ORDER BY [UserAccessID] DESC  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT001A7,1,0,true,true )
             ,new CursorDef("T001A8", "INSERT INTO [SYS_TenantUserAccess]([TenantCode], [DataPackage], [UserAccessID], [UserID]) VALUES(@SYS_TenantUserAccessTenantCode, @SYS_TenantUserAccessDataPackage, @SYS_TenantUserAccessUserAccessID, @SYS_TenantUserAccessUserID)", GxErrorMask.GX_NOMASK,prmT001A8)
             ,new CursorDef("T001A9", "UPDATE [SYS_TenantUserAccess] SET [UserID]=@SYS_TenantUserAccessUserID, [TenantCode]=@SYS_TenantUserAccessTenantCode, [DataPackage]=@SYS_TenantUserAccessDataPackage  WHERE [UserAccessID] = @SYS_TenantUserAccessUserAccessID", GxErrorMask.GX_NOMASK,prmT001A9)
             ,new CursorDef("T001A10", "DELETE FROM [SYS_TenantUserAccess]  WHERE [UserAccessID] = @SYS_TenantUserAccessUserAccessID", GxErrorMask.GX_NOMASK,prmT001A10)
             ,new CursorDef("T001A11", "SELECT [UserAccessID] FROM [SYS_TenantUserAccess] WITH (NOLOCK) ORDER BY [UserAccessID]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT001A11,100,0,true,false )
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
                ((Guid[]) buf[0])[0] = rslt.getGuid(1) ;
                ((Guid[]) buf[1])[0] = rslt.getGuid(2) ;
                ((String[]) buf[2])[0] = rslt.getVarchar(3) ;
                ((String[]) buf[3])[0] = rslt.getVarchar(4) ;
                return;
             case 1 :
                ((Guid[]) buf[0])[0] = rslt.getGuid(1) ;
                ((Guid[]) buf[1])[0] = rslt.getGuid(2) ;
                ((String[]) buf[2])[0] = rslt.getVarchar(3) ;
                ((String[]) buf[3])[0] = rslt.getVarchar(4) ;
                return;
             case 2 :
                ((Guid[]) buf[0])[0] = rslt.getGuid(1) ;
                ((Guid[]) buf[1])[0] = rslt.getGuid(2) ;
                ((String[]) buf[2])[0] = rslt.getVarchar(3) ;
                ((String[]) buf[3])[0] = rslt.getVarchar(4) ;
                return;
             case 3 :
                ((Guid[]) buf[0])[0] = rslt.getGuid(1) ;
                return;
             case 4 :
                ((Guid[]) buf[0])[0] = rslt.getGuid(1) ;
                return;
             case 5 :
                ((Guid[]) buf[0])[0] = rslt.getGuid(1) ;
                return;
             case 9 :
                ((Guid[]) buf[0])[0] = rslt.getGuid(1) ;
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
                stmt.SetParameter(1, (Guid)parms[0]);
                return;
             case 1 :
                stmt.SetParameter(1, (Guid)parms[0]);
                return;
             case 2 :
                stmt.SetParameter(1, (Guid)parms[0]);
                return;
             case 3 :
                stmt.SetParameter(1, (Guid)parms[0]);
                return;
             case 4 :
                stmt.SetParameter(1, (Guid)parms[0]);
                return;
             case 5 :
                stmt.SetParameter(1, (Guid)parms[0]);
                return;
             case 6 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                stmt.SetParameter(3, (Guid)parms[2]);
                stmt.SetParameter(4, (Guid)parms[3]);
                return;
             case 7 :
                stmt.SetParameter(1, (Guid)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                stmt.SetParameter(3, (String)parms[2]);
                stmt.SetParameter(4, (Guid)parms[3]);
                return;
             case 8 :
                stmt.SetParameter(1, (Guid)parms[0]);
                return;
       }
    }

    public String getDataStoreName( )
    {
       return "DATASTORE1";
    }

 }

 public class sys_tenantuseraccess__default : DataStoreHelperBase, IDataStoreHelper
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
