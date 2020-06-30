/*
               File: SYS_TenantUserRole
        Description: SYS_Tenant User Role
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/27/2020 11:58:11.13
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
   public class sys_tenantuserrole : GXDataArea, System.Web.SessionState.IRequiresSessionState
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
            Form.Meta.addItem("description", "SYS_Tenant User Role", 0) ;
         }
         context.wjLoc = "";
         context.nUserReturn = 0;
         context.wbHandled = 0;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         GX_FocusControl = edtSYS_TenantUserRoleUserRoleID_Internalname;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         wbErr = false;
         context.SetDefaultTheme("WorkWithPlusTheme");
         if ( ! context.IsLocalStorageSupported( ) )
         {
            context.PushCurrentUrl();
         }
      }

      public sys_tenantuserrole( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public sys_tenantuserrole( IGxContext context )
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
            GxWebStd.gx_label_ctrl( context, lblTitle_Internalname, "SYS_Tenant User Role", "", "", lblTitle_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Title", 0, "", 1, 1, 0, "HLP_SYS_TenantUserRole.htm");
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
            GxWebStd.gx_button_ctrl( context, bttBtn_first_Internalname, "", "|<", bttBtn_first_Jsonclick, 5, "|<", "", StyleString, ClassString, bttBtn_first_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"EFIRST."+"'", TempTags, "", context.GetButtonType( ), "HLP_SYS_TenantUserRole.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 14,'',false,'',0)\"";
            ClassString = "BtnPrevious";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_previous_Internalname, "", "<", bttBtn_previous_Jsonclick, 5, "<", "", StyleString, ClassString, bttBtn_previous_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"EPREVIOUS."+"'", TempTags, "", context.GetButtonType( ), "HLP_SYS_TenantUserRole.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 16,'',false,'',0)\"";
            ClassString = "BtnNext";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_next_Internalname, "", ">", bttBtn_next_Jsonclick, 5, ">", "", StyleString, ClassString, bttBtn_next_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ENEXT."+"'", TempTags, "", context.GetButtonType( ), "HLP_SYS_TenantUserRole.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 18,'',false,'',0)\"";
            ClassString = "BtnLast";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_last_Internalname, "", ">|", bttBtn_last_Jsonclick, 5, ">|", "", StyleString, ClassString, bttBtn_last_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ELAST."+"'", TempTags, "", context.GetButtonType( ), "HLP_SYS_TenantUserRole.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 20,'',false,'',0)\"";
            ClassString = "BtnSelect";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_select_Internalname, "", "选择", bttBtn_select_Jsonclick, 5, "选择", "", StyleString, ClassString, bttBtn_select_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ESELECT."+"'", TempTags, "", 2, "HLP_SYS_TenantUserRole.htm");
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
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtSYS_TenantUserRoleUserRoleID_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtSYS_TenantUserRoleUserRoleID_Internalname, "User Role ID", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 28,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtSYS_TenantUserRoleUserRoleID_Internalname, A370SYS_TenantUserRoleUserRoleID.ToString(), A370SYS_TenantUserRoleUserRoleID.ToString(), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,28);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtSYS_TenantUserRoleUserRoleID_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtSYS_TenantUserRoleUserRoleID_Enabled, 0, "text", "", 36, "chr", 1, "row", 36, 0, 0, 0, 1, 0, 0, true, "", "", false, "HLP_SYS_TenantUserRole.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtSYS_TenantUserRoleUserID_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtSYS_TenantUserRoleUserID_Internalname, "User ID", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 33,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtSYS_TenantUserRoleUserID_Internalname, A433SYS_TenantUserRoleUserID.ToString(), A433SYS_TenantUserRoleUserID.ToString(), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,33);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtSYS_TenantUserRoleUserID_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtSYS_TenantUserRoleUserID_Enabled, 0, "text", "", 36, "chr", 1, "row", 36, 0, 0, 0, 1, 0, 0, true, "", "", false, "HLP_SYS_TenantUserRole.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtSYS_TenantUserRoleTenantCode_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtSYS_TenantUserRoleTenantCode_Internalname, "Tenant Code", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 38,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtSYS_TenantUserRoleTenantCode_Internalname, A441SYS_TenantUserRoleTenantCode, StringUtil.RTrim( context.localUtil.Format( A441SYS_TenantUserRoleTenantCode, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,38);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtSYS_TenantUserRoleTenantCode_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtSYS_TenantUserRoleTenantCode_Enabled, 0, "text", "", 20, "chr", 1, "row", 20, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_SYS_TenantUserRole.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtSYS_TenantUserRoleRoleID_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtSYS_TenantUserRoleRoleID_Internalname, "Role ID", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 43,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtSYS_TenantUserRoleRoleID_Internalname, A434SYS_TenantUserRoleRoleID.ToString(), A434SYS_TenantUserRoleRoleID.ToString(), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,43);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtSYS_TenantUserRoleRoleID_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtSYS_TenantUserRoleRoleID_Enabled, 0, "text", "", 36, "chr", 1, "row", 36, 0, 0, 0, 1, 0, 0, true, "", "", false, "HLP_SYS_TenantUserRole.htm");
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
            GxWebStd.gx_button_ctrl( context, bttBtn_enter_Internalname, "", "确认", bttBtn_enter_Jsonclick, 5, "确认", "", StyleString, ClassString, bttBtn_enter_Visible, bttBtn_enter_Enabled, "standard", "'"+""+"'"+",false,"+"'"+"EENTER."+"'", TempTags, "", context.GetButtonType( ), "HLP_SYS_TenantUserRole.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 50,'',false,'',0)\"";
            ClassString = "BtnCancel";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_cancel_Internalname, "", "取消", bttBtn_cancel_Jsonclick, 1, "取消", "", StyleString, ClassString, bttBtn_cancel_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ECANCEL."+"'", TempTags, "", context.GetButtonType( ), "HLP_SYS_TenantUserRole.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 52,'',false,'',0)\"";
            ClassString = "BtnDelete";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_delete_Internalname, "", "删除", bttBtn_delete_Jsonclick, 5, "删除", "", StyleString, ClassString, bttBtn_delete_Visible, bttBtn_delete_Enabled, "standard", "'"+""+"'"+",false,"+"'"+"EDELETE."+"'", TempTags, "", context.GetButtonType( ), "HLP_SYS_TenantUserRole.htm");
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
               if ( StringUtil.StrCmp(cgiGet( edtSYS_TenantUserRoleUserRoleID_Internalname), "") == 0 )
               {
                  A370SYS_TenantUserRoleUserRoleID = (Guid)(Guid.Empty);
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A370SYS_TenantUserRoleUserRoleID", A370SYS_TenantUserRoleUserRoleID.ToString());
               }
               else
               {
                  try
                  {
                     A370SYS_TenantUserRoleUserRoleID = (Guid)(StringUtil.StrToGuid( cgiGet( edtSYS_TenantUserRoleUserRoleID_Internalname)));
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A370SYS_TenantUserRoleUserRoleID", A370SYS_TenantUserRoleUserRoleID.ToString());
                  }
                  catch ( Exception e )
                  {
                     GX_msglist.addItem(context.GetMessage( "GXM_invalidguid", ""), 1, "SYS_TENANTUSERROLEUSERROLEID");
                     AnyError = 1;
                     GX_FocusControl = edtSYS_TenantUserRoleUserRoleID_Internalname;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                     wbErr = true;
                  }
               }
               if ( StringUtil.StrCmp(cgiGet( edtSYS_TenantUserRoleUserID_Internalname), "") == 0 )
               {
                  A433SYS_TenantUserRoleUserID = (Guid)(Guid.Empty);
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A433SYS_TenantUserRoleUserID", A433SYS_TenantUserRoleUserID.ToString());
               }
               else
               {
                  try
                  {
                     A433SYS_TenantUserRoleUserID = (Guid)(StringUtil.StrToGuid( cgiGet( edtSYS_TenantUserRoleUserID_Internalname)));
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A433SYS_TenantUserRoleUserID", A433SYS_TenantUserRoleUserID.ToString());
                  }
                  catch ( Exception e )
                  {
                     GX_msglist.addItem(context.GetMessage( "GXM_invalidguid", ""), 1, "SYS_TENANTUSERROLEUSERID");
                     AnyError = 1;
                     GX_FocusControl = edtSYS_TenantUserRoleUserID_Internalname;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                     wbErr = true;
                  }
               }
               A441SYS_TenantUserRoleTenantCode = cgiGet( edtSYS_TenantUserRoleTenantCode_Internalname);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A441SYS_TenantUserRoleTenantCode", A441SYS_TenantUserRoleTenantCode);
               if ( StringUtil.StrCmp(cgiGet( edtSYS_TenantUserRoleRoleID_Internalname), "") == 0 )
               {
                  A434SYS_TenantUserRoleRoleID = (Guid)(Guid.Empty);
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A434SYS_TenantUserRoleRoleID", A434SYS_TenantUserRoleRoleID.ToString());
               }
               else
               {
                  try
                  {
                     A434SYS_TenantUserRoleRoleID = (Guid)(StringUtil.StrToGuid( cgiGet( edtSYS_TenantUserRoleRoleID_Internalname)));
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A434SYS_TenantUserRoleRoleID", A434SYS_TenantUserRoleRoleID.ToString());
                  }
                  catch ( Exception e )
                  {
                     GX_msglist.addItem(context.GetMessage( "GXM_invalidguid", ""), 1, "SYS_TENANTUSERROLEROLEID");
                     AnyError = 1;
                     GX_FocusControl = edtSYS_TenantUserRoleRoleID_Internalname;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                     wbErr = true;
                  }
               }
               /* Read saved values. */
               Z370SYS_TenantUserRoleUserRoleID = (Guid)(StringUtil.StrToGuid( cgiGet( "Z370SYS_TenantUserRoleUserRoleID")));
               Z433SYS_TenantUserRoleUserID = (Guid)(StringUtil.StrToGuid( cgiGet( "Z433SYS_TenantUserRoleUserID")));
               Z441SYS_TenantUserRoleTenantCode = cgiGet( "Z441SYS_TenantUserRoleTenantCode");
               Z434SYS_TenantUserRoleRoleID = (Guid)(StringUtil.StrToGuid( cgiGet( "Z434SYS_TenantUserRoleRoleID")));
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
                  A370SYS_TenantUserRoleUserRoleID = (Guid)(StringUtil.StrToGuid( GetNextPar( )));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A370SYS_TenantUserRoleUserRoleID", A370SYS_TenantUserRoleUserRoleID.ToString());
                  getEqualNoModal( ) ;
                  if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  && (Guid.Empty==A370SYS_TenantUserRoleUserRoleID) && ( Gx_BScreen == 0 ) )
                  {
                     A370SYS_TenantUserRoleUserRoleID = (Guid)(Guid.NewGuid( ));
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A370SYS_TenantUserRoleUserRoleID", A370SYS_TenantUserRoleUserRoleID.ToString());
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
               InitAll1J56( ) ;
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
         DisableAttributes1J56( ) ;
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

      protected void ResetCaption1J0( )
      {
      }

      protected void ZM1J56( short GX_JID )
      {
         if ( ( GX_JID == 7 ) || ( GX_JID == 0 ) )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
            {
               Z433SYS_TenantUserRoleUserID = (Guid)(T001J3_A433SYS_TenantUserRoleUserID[0]);
               Z441SYS_TenantUserRoleTenantCode = T001J3_A441SYS_TenantUserRoleTenantCode[0];
               Z434SYS_TenantUserRoleRoleID = (Guid)(T001J3_A434SYS_TenantUserRoleRoleID[0]);
            }
            else
            {
               Z433SYS_TenantUserRoleUserID = (Guid)(A433SYS_TenantUserRoleUserID);
               Z441SYS_TenantUserRoleTenantCode = A441SYS_TenantUserRoleTenantCode;
               Z434SYS_TenantUserRoleRoleID = (Guid)(A434SYS_TenantUserRoleRoleID);
            }
         }
         if ( GX_JID == -7 )
         {
            Z370SYS_TenantUserRoleUserRoleID = (Guid)(A370SYS_TenantUserRoleUserRoleID);
            Z433SYS_TenantUserRoleUserID = (Guid)(A433SYS_TenantUserRoleUserID);
            Z441SYS_TenantUserRoleTenantCode = A441SYS_TenantUserRoleTenantCode;
            Z434SYS_TenantUserRoleRoleID = (Guid)(A434SYS_TenantUserRoleRoleID);
         }
      }

      protected void standaloneNotModal( )
      {
         Gx_BScreen = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_BScreen", StringUtil.Str( (decimal)(Gx_BScreen), 1, 0));
      }

      protected void standaloneModal( )
      {
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  && (Guid.Empty==A434SYS_TenantUserRoleRoleID) && ( Gx_BScreen == 0 ) )
         {
            A434SYS_TenantUserRoleRoleID = (Guid)(Guid.NewGuid( ));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A434SYS_TenantUserRoleRoleID", A434SYS_TenantUserRoleRoleID.ToString());
         }
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  && (Guid.Empty==A433SYS_TenantUserRoleUserID) && ( Gx_BScreen == 0 ) )
         {
            A433SYS_TenantUserRoleUserID = (Guid)(Guid.NewGuid( ));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A433SYS_TenantUserRoleUserID", A433SYS_TenantUserRoleUserID.ToString());
         }
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  && (Guid.Empty==A370SYS_TenantUserRoleUserRoleID) && ( Gx_BScreen == 0 ) )
         {
            A370SYS_TenantUserRoleUserRoleID = (Guid)(Guid.NewGuid( ));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A370SYS_TenantUserRoleUserRoleID", A370SYS_TenantUserRoleUserRoleID.ToString());
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

      protected void Load1J56( )
      {
         /* Using cursor T001J4 */
         pr_datastore1.execute(2, new Object[] {A370SYS_TenantUserRoleUserRoleID});
         if ( (pr_datastore1.getStatus(2) != 101) )
         {
            RcdFound56 = 1;
            A433SYS_TenantUserRoleUserID = (Guid)((Guid)(T001J4_A433SYS_TenantUserRoleUserID[0]));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A433SYS_TenantUserRoleUserID", A433SYS_TenantUserRoleUserID.ToString());
            A441SYS_TenantUserRoleTenantCode = T001J4_A441SYS_TenantUserRoleTenantCode[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A441SYS_TenantUserRoleTenantCode", A441SYS_TenantUserRoleTenantCode);
            A434SYS_TenantUserRoleRoleID = (Guid)((Guid)(T001J4_A434SYS_TenantUserRoleRoleID[0]));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A434SYS_TenantUserRoleRoleID", A434SYS_TenantUserRoleRoleID.ToString());
            ZM1J56( -7) ;
         }
         pr_datastore1.close(2);
         OnLoadActions1J56( ) ;
      }

      protected void OnLoadActions1J56( )
      {
      }

      protected void CheckExtendedTable1J56( )
      {
         Gx_BScreen = 1;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_BScreen", StringUtil.Str( (decimal)(Gx_BScreen), 1, 0));
         standaloneModal( ) ;
      }

      protected void CloseExtendedTableCursors1J56( )
      {
      }

      protected void enableDisable( )
      {
      }

      protected void GetKey1J56( )
      {
         /* Using cursor T001J5 */
         pr_datastore1.execute(3, new Object[] {A370SYS_TenantUserRoleUserRoleID});
         if ( (pr_datastore1.getStatus(3) != 101) )
         {
            RcdFound56 = 1;
         }
         else
         {
            RcdFound56 = 0;
         }
         pr_datastore1.close(3);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor T001J3 */
         pr_datastore1.execute(1, new Object[] {A370SYS_TenantUserRoleUserRoleID});
         if ( (pr_datastore1.getStatus(1) != 101) )
         {
            ZM1J56( 7) ;
            RcdFound56 = 1;
            A370SYS_TenantUserRoleUserRoleID = (Guid)((Guid)(T001J3_A370SYS_TenantUserRoleUserRoleID[0]));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A370SYS_TenantUserRoleUserRoleID", A370SYS_TenantUserRoleUserRoleID.ToString());
            A433SYS_TenantUserRoleUserID = (Guid)((Guid)(T001J3_A433SYS_TenantUserRoleUserID[0]));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A433SYS_TenantUserRoleUserID", A433SYS_TenantUserRoleUserID.ToString());
            A441SYS_TenantUserRoleTenantCode = T001J3_A441SYS_TenantUserRoleTenantCode[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A441SYS_TenantUserRoleTenantCode", A441SYS_TenantUserRoleTenantCode);
            A434SYS_TenantUserRoleRoleID = (Guid)((Guid)(T001J3_A434SYS_TenantUserRoleRoleID[0]));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A434SYS_TenantUserRoleRoleID", A434SYS_TenantUserRoleRoleID.ToString());
            Z370SYS_TenantUserRoleUserRoleID = (Guid)(A370SYS_TenantUserRoleUserRoleID);
            sMode56 = Gx_mode;
            Gx_mode = "DSP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            standaloneModal( ) ;
            Load1J56( ) ;
            if ( AnyError == 1 )
            {
               RcdFound56 = 0;
               InitializeNonKey1J56( ) ;
            }
            Gx_mode = sMode56;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         else
         {
            RcdFound56 = 0;
            InitializeNonKey1J56( ) ;
            sMode56 = Gx_mode;
            Gx_mode = "DSP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            standaloneModal( ) ;
            Gx_mode = sMode56;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         pr_datastore1.close(1);
      }

      protected void getEqualNoModal( )
      {
         GetKey1J56( ) ;
         if ( RcdFound56 == 0 )
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
         RcdFound56 = 0;
         /* Using cursor T001J6 */
         pr_datastore1.execute(4, new Object[] {A370SYS_TenantUserRoleUserRoleID});
         if ( (pr_datastore1.getStatus(4) != 101) )
         {
            while ( (pr_datastore1.getStatus(4) != 101) && ( ( GuidUtil.Compare(T001J6_A370SYS_TenantUserRoleUserRoleID[0], A370SYS_TenantUserRoleUserRoleID, 1) < 0 ) ) )
            {
               pr_datastore1.readNext(4);
            }
            if ( (pr_datastore1.getStatus(4) != 101) && ( ( GuidUtil.Compare(T001J6_A370SYS_TenantUserRoleUserRoleID[0], A370SYS_TenantUserRoleUserRoleID, 1) > 0 ) ) )
            {
               A370SYS_TenantUserRoleUserRoleID = (Guid)((Guid)(T001J6_A370SYS_TenantUserRoleUserRoleID[0]));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A370SYS_TenantUserRoleUserRoleID", A370SYS_TenantUserRoleUserRoleID.ToString());
               RcdFound56 = 1;
            }
         }
         pr_datastore1.close(4);
      }

      protected void move_previous( )
      {
         RcdFound56 = 0;
         /* Using cursor T001J7 */
         pr_datastore1.execute(5, new Object[] {A370SYS_TenantUserRoleUserRoleID});
         if ( (pr_datastore1.getStatus(5) != 101) )
         {
            while ( (pr_datastore1.getStatus(5) != 101) && ( ( GuidUtil.Compare(T001J7_A370SYS_TenantUserRoleUserRoleID[0], A370SYS_TenantUserRoleUserRoleID, 1) > 0 ) ) )
            {
               pr_datastore1.readNext(5);
            }
            if ( (pr_datastore1.getStatus(5) != 101) && ( ( GuidUtil.Compare(T001J7_A370SYS_TenantUserRoleUserRoleID[0], A370SYS_TenantUserRoleUserRoleID, 1) < 0 ) ) )
            {
               A370SYS_TenantUserRoleUserRoleID = (Guid)((Guid)(T001J7_A370SYS_TenantUserRoleUserRoleID[0]));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A370SYS_TenantUserRoleUserRoleID", A370SYS_TenantUserRoleUserRoleID.ToString());
               RcdFound56 = 1;
            }
         }
         pr_datastore1.close(5);
      }

      protected void btn_enter( )
      {
         nKeyPressed = 1;
         GetKey1J56( ) ;
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            /* Insert record */
            GX_FocusControl = edtSYS_TenantUserRoleUserRoleID_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            Insert1J56( ) ;
            if ( AnyError == 1 )
            {
               GX_FocusControl = "";
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
         }
         else
         {
            if ( RcdFound56 == 1 )
            {
               if ( A370SYS_TenantUserRoleUserRoleID != Z370SYS_TenantUserRoleUserRoleID )
               {
                  A370SYS_TenantUserRoleUserRoleID = (Guid)(Z370SYS_TenantUserRoleUserRoleID);
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A370SYS_TenantUserRoleUserRoleID", A370SYS_TenantUserRoleUserRoleID.ToString());
                  GX_msglist.addItem(context.GetMessage( "GXM_getbeforeupd", ""), "CandidateKeyNotFound", 1, "SYS_TENANTUSERROLEUSERROLEID");
                  AnyError = 1;
                  GX_FocusControl = edtSYS_TenantUserRoleUserRoleID_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
               else if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
               {
                  delete( ) ;
                  AfterTrn( ) ;
                  GX_FocusControl = edtSYS_TenantUserRoleUserRoleID_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
               else
               {
                  Gx_mode = "UPD";
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                  /* Update record */
                  Update1J56( ) ;
                  GX_FocusControl = edtSYS_TenantUserRoleUserRoleID_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
            }
            else
            {
               if ( A370SYS_TenantUserRoleUserRoleID != Z370SYS_TenantUserRoleUserRoleID )
               {
                  Gx_mode = "INS";
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                  /* Insert record */
                  GX_FocusControl = edtSYS_TenantUserRoleUserRoleID_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  Insert1J56( ) ;
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
                     GX_msglist.addItem(context.GetMessage( "GXM_recdeleted", ""), 1, "SYS_TENANTUSERROLEUSERROLEID");
                     AnyError = 1;
                     GX_FocusControl = edtSYS_TenantUserRoleUserRoleID_Internalname;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  }
                  else
                  {
                     Gx_mode = "INS";
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                     /* Insert record */
                     GX_FocusControl = edtSYS_TenantUserRoleUserRoleID_Internalname;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                     Insert1J56( ) ;
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
         if ( A370SYS_TenantUserRoleUserRoleID != Z370SYS_TenantUserRoleUserRoleID )
         {
            A370SYS_TenantUserRoleUserRoleID = (Guid)(Z370SYS_TenantUserRoleUserRoleID);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A370SYS_TenantUserRoleUserRoleID", A370SYS_TenantUserRoleUserRoleID.ToString());
            GX_msglist.addItem(context.GetMessage( "GXM_getbeforedlt", ""), 1, "SYS_TENANTUSERROLEUSERROLEID");
            AnyError = 1;
            GX_FocusControl = edtSYS_TenantUserRoleUserRoleID_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         else
         {
            delete( ) ;
            AfterTrn( ) ;
            GX_FocusControl = edtSYS_TenantUserRoleUserRoleID_Internalname;
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
         if ( RcdFound56 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_keynfound", ""), "PrimaryKeyNotFound", 1, "SYS_TENANTUSERROLEUSERROLEID");
            AnyError = 1;
            GX_FocusControl = edtSYS_TenantUserRoleUserRoleID_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         GX_FocusControl = edtSYS_TenantUserRoleUserID_Internalname;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_first( )
      {
         nKeyPressed = 2;
         IsConfirmed = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "IsConfirmed", StringUtil.LTrim( StringUtil.Str( (decimal)(IsConfirmed), 4, 0)));
         ScanStart1J56( ) ;
         if ( RcdFound56 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "", true);
         }
         else
         {
            Gx_mode = "UPD";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtSYS_TenantUserRoleUserID_Internalname;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         ScanEnd1J56( ) ;
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
         if ( RcdFound56 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "", true);
         }
         else
         {
            Gx_mode = "UPD";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtSYS_TenantUserRoleUserID_Internalname;
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
         if ( RcdFound56 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "", true);
         }
         else
         {
            Gx_mode = "UPD";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtSYS_TenantUserRoleUserID_Internalname;
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
         ScanStart1J56( ) ;
         if ( RcdFound56 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "", true);
         }
         else
         {
            while ( RcdFound56 != 0 )
            {
               ScanNext1J56( ) ;
            }
            Gx_mode = "UPD";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtSYS_TenantUserRoleUserID_Internalname;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         ScanEnd1J56( ) ;
         getByPrimaryKey( ) ;
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_select( )
      {
         getEqualNoModal( ) ;
      }

      protected void CheckOptimisticConcurrency1J56( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor T001J2 */
            pr_datastore1.execute(0, new Object[] {A370SYS_TenantUserRoleUserRoleID});
            if ( (pr_datastore1.getStatus(0) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"SYS_TENANTUSERROLE"}), "RecordIsLocked", 1, "");
               AnyError = 1;
               return  ;
            }
            if ( (pr_datastore1.getStatus(0) == 101) || ( Z433SYS_TenantUserRoleUserID != T001J2_A433SYS_TenantUserRoleUserID[0] ) || ( StringUtil.StrCmp(Z441SYS_TenantUserRoleTenantCode, T001J2_A441SYS_TenantUserRoleTenantCode[0]) != 0 ) || ( Z434SYS_TenantUserRoleRoleID != T001J2_A434SYS_TenantUserRoleRoleID[0] ) )
            {
               if ( Z433SYS_TenantUserRoleUserID != T001J2_A433SYS_TenantUserRoleUserID[0] )
               {
                  GXUtil.WriteLog("sys_tenantuserrole:[seudo value changed for attri]"+"SYS_TenantUserRoleUserID");
                  GXUtil.WriteLogRaw("Old: ",Z433SYS_TenantUserRoleUserID);
                  GXUtil.WriteLogRaw("Current: ",T001J2_A433SYS_TenantUserRoleUserID[0]);
               }
               if ( StringUtil.StrCmp(Z441SYS_TenantUserRoleTenantCode, T001J2_A441SYS_TenantUserRoleTenantCode[0]) != 0 )
               {
                  GXUtil.WriteLog("sys_tenantuserrole:[seudo value changed for attri]"+"SYS_TenantUserRoleTenantCode");
                  GXUtil.WriteLogRaw("Old: ",Z441SYS_TenantUserRoleTenantCode);
                  GXUtil.WriteLogRaw("Current: ",T001J2_A441SYS_TenantUserRoleTenantCode[0]);
               }
               if ( Z434SYS_TenantUserRoleRoleID != T001J2_A434SYS_TenantUserRoleRoleID[0] )
               {
                  GXUtil.WriteLog("sys_tenantuserrole:[seudo value changed for attri]"+"SYS_TenantUserRoleRoleID");
                  GXUtil.WriteLogRaw("Old: ",Z434SYS_TenantUserRoleRoleID);
                  GXUtil.WriteLogRaw("Current: ",T001J2_A434SYS_TenantUserRoleRoleID[0]);
               }
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"SYS_TENANTUSERROLE"}), "RecordWasChanged", 1, "");
               AnyError = 1;
               return  ;
            }
         }
      }

      protected void Insert1J56( )
      {
         BeforeValidate1J56( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable1J56( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM1J56( 0) ;
            CheckOptimisticConcurrency1J56( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm1J56( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert1J56( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T001J8 */
                     pr_datastore1.execute(6, new Object[] {A441SYS_TenantUserRoleTenantCode, A370SYS_TenantUserRoleUserRoleID, A433SYS_TenantUserRoleUserID, A434SYS_TenantUserRoleRoleID});
                     pr_datastore1.close(6);
                     dsDataStore1.SmartCacheProvider.SetUpdated("SYS_TENANTUSERROLE") ;
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
                           ResetCaption1J0( ) ;
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
               Load1J56( ) ;
            }
            EndLevel1J56( ) ;
         }
         CloseExtendedTableCursors1J56( ) ;
      }

      protected void Update1J56( )
      {
         BeforeValidate1J56( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable1J56( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency1J56( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm1J56( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate1J56( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T001J9 */
                     pr_datastore1.execute(7, new Object[] {A433SYS_TenantUserRoleUserID, A441SYS_TenantUserRoleTenantCode, A434SYS_TenantUserRoleRoleID, A370SYS_TenantUserRoleUserRoleID});
                     pr_datastore1.close(7);
                     dsDataStore1.SmartCacheProvider.SetUpdated("SYS_TENANTUSERROLE") ;
                     if ( (pr_datastore1.getStatus(7) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"SYS_TENANTUSERROLE"}), "RecordIsLocked", 1, "");
                        AnyError = 1;
                     }
                     DeferredUpdate1J56( ) ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( update) rules */
                        /* End of After( update) rules */
                        if ( AnyError == 0 )
                        {
                           getByPrimaryKey( ) ;
                           GX_msglist.addItem(context.GetMessage( "GXM_sucupdated", ""), "SuccessfullyUpdated", 0, "", true);
                           ResetCaption1J0( ) ;
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
            EndLevel1J56( ) ;
         }
         CloseExtendedTableCursors1J56( ) ;
      }

      protected void DeferredUpdate1J56( )
      {
      }

      protected void delete( )
      {
         Gx_mode = "DLT";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         BeforeValidate1J56( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency1J56( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls1J56( ) ;
            AfterConfirm1J56( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete1J56( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor T001J10 */
                  pr_datastore1.execute(8, new Object[] {A370SYS_TenantUserRoleUserRoleID});
                  pr_datastore1.close(8);
                  dsDataStore1.SmartCacheProvider.SetUpdated("SYS_TENANTUSERROLE") ;
                  if ( AnyError == 0 )
                  {
                     /* Start of After( delete) rules */
                     /* End of After( delete) rules */
                     if ( AnyError == 0 )
                     {
                        move_next( ) ;
                        if ( RcdFound56 == 0 )
                        {
                           InitAll1J56( ) ;
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
                        ResetCaption1J0( ) ;
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
         sMode56 = Gx_mode;
         Gx_mode = "DLT";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         EndLevel1J56( ) ;
         Gx_mode = sMode56;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
      }

      protected void OnDeleteControls1J56( )
      {
         standaloneModal( ) ;
         /* No delete mode formulas found. */
      }

      protected void EndLevel1J56( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            pr_datastore1.close(0);
         }
         if ( AnyError == 0 )
         {
            BeforeComplete1J56( ) ;
         }
         if ( AnyError == 0 )
         {
            pr_datastore1.close(1);
            context.CommitDataStores("sys_tenantuserrole",pr_default);
            if ( AnyError == 0 )
            {
               ConfirmValues1J0( ) ;
            }
            /* After transaction rules */
            /* Execute 'After Trn' event if defined. */
            trnEnded = 1;
         }
         else
         {
            pr_datastore1.close(1);
            context.RollbackDataStores("sys_tenantuserrole",pr_default);
         }
         IsModified = 0;
         if ( AnyError != 0 )
         {
            context.wjLoc = "";
            context.nUserReturn = 0;
         }
      }

      public void ScanStart1J56( )
      {
         /* Using cursor T001J11 */
         pr_datastore1.execute(9);
         RcdFound56 = 0;
         if ( (pr_datastore1.getStatus(9) != 101) )
         {
            RcdFound56 = 1;
            A370SYS_TenantUserRoleUserRoleID = (Guid)((Guid)(T001J11_A370SYS_TenantUserRoleUserRoleID[0]));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A370SYS_TenantUserRoleUserRoleID", A370SYS_TenantUserRoleUserRoleID.ToString());
         }
         /* Load Subordinate Levels */
      }

      protected void ScanNext1J56( )
      {
         /* Scan next routine */
         pr_datastore1.readNext(9);
         RcdFound56 = 0;
         if ( (pr_datastore1.getStatus(9) != 101) )
         {
            RcdFound56 = 1;
            A370SYS_TenantUserRoleUserRoleID = (Guid)((Guid)(T001J11_A370SYS_TenantUserRoleUserRoleID[0]));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A370SYS_TenantUserRoleUserRoleID", A370SYS_TenantUserRoleUserRoleID.ToString());
         }
      }

      protected void ScanEnd1J56( )
      {
         pr_datastore1.close(9);
      }

      protected void AfterConfirm1J56( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert1J56( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate1J56( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete1J56( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete1J56( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate1J56( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes1J56( )
      {
         edtSYS_TenantUserRoleUserRoleID_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtSYS_TenantUserRoleUserRoleID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtSYS_TenantUserRoleUserRoleID_Enabled), 5, 0)), true);
         edtSYS_TenantUserRoleUserID_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtSYS_TenantUserRoleUserID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtSYS_TenantUserRoleUserID_Enabled), 5, 0)), true);
         edtSYS_TenantUserRoleTenantCode_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtSYS_TenantUserRoleTenantCode_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtSYS_TenantUserRoleTenantCode_Enabled), 5, 0)), true);
         edtSYS_TenantUserRoleRoleID_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtSYS_TenantUserRoleRoleID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtSYS_TenantUserRoleRoleID_Enabled), 5, 0)), true);
      }

      protected void send_integrity_lvl_hashes1J56( )
      {
      }

      protected void assign_properties_default( )
      {
      }

      protected void ConfirmValues1J0( )
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
         context.AddJavascriptSource("gxcfg.js", "?202022711581183", false);
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" autocomplete=\"off\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("sys_tenantuserrole.aspx") +"\">") ;
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
         GxWebStd.gx_hidden_field( context, "Z370SYS_TenantUserRoleUserRoleID", Z370SYS_TenantUserRoleUserRoleID.ToString());
         GxWebStd.gx_hidden_field( context, "Z433SYS_TenantUserRoleUserID", Z433SYS_TenantUserRoleUserID.ToString());
         GxWebStd.gx_hidden_field( context, "Z441SYS_TenantUserRoleTenantCode", Z441SYS_TenantUserRoleTenantCode);
         GxWebStd.gx_hidden_field( context, "Z434SYS_TenantUserRoleRoleID", Z434SYS_TenantUserRoleRoleID.ToString());
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
         return formatLink("sys_tenantuserrole.aspx")  ;
      }

      public override String GetPgmname( )
      {
         return "SYS_TenantUserRole" ;
      }

      public override String GetPgmdesc( )
      {
         return "SYS_Tenant User Role" ;
      }

      protected void InitializeNonKey1J56( )
      {
         A441SYS_TenantUserRoleTenantCode = "";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A441SYS_TenantUserRoleTenantCode", A441SYS_TenantUserRoleTenantCode);
         A433SYS_TenantUserRoleUserID = (Guid)(Guid.NewGuid( ));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A433SYS_TenantUserRoleUserID", A433SYS_TenantUserRoleUserID.ToString());
         A434SYS_TenantUserRoleRoleID = (Guid)(Guid.NewGuid( ));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A434SYS_TenantUserRoleRoleID", A434SYS_TenantUserRoleRoleID.ToString());
         Z433SYS_TenantUserRoleUserID = (Guid)(Guid.Empty);
         Z441SYS_TenantUserRoleTenantCode = "";
         Z434SYS_TenantUserRoleRoleID = (Guid)(Guid.Empty);
      }

      protected void InitAll1J56( )
      {
         A370SYS_TenantUserRoleUserRoleID = (Guid)(Guid.NewGuid( ));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A370SYS_TenantUserRoleUserRoleID", A370SYS_TenantUserRoleUserRoleID.ToString());
         InitializeNonKey1J56( ) ;
      }

      protected void StandaloneModalInsert( )
      {
         A434SYS_TenantUserRoleRoleID = (Guid)(i434SYS_TenantUserRoleRoleID);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A434SYS_TenantUserRoleRoleID", A434SYS_TenantUserRoleRoleID.ToString());
         A433SYS_TenantUserRoleUserID = (Guid)(i433SYS_TenantUserRoleUserID);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A433SYS_TenantUserRoleUserID", A433SYS_TenantUserRoleUserID.ToString());
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
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?202022711581188", true);
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
         context.AddJavascriptSource("sys_tenantuserrole.js", "?202022711581188", false);
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
         edtSYS_TenantUserRoleUserRoleID_Internalname = "SYS_TENANTUSERROLEUSERROLEID";
         edtSYS_TenantUserRoleUserID_Internalname = "SYS_TENANTUSERROLEUSERID";
         edtSYS_TenantUserRoleTenantCode_Internalname = "SYS_TENANTUSERROLETENANTCODE";
         edtSYS_TenantUserRoleRoleID_Internalname = "SYS_TENANTUSERROLEROLEID";
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
         Form.Caption = "SYS_Tenant User Role";
         bttBtn_delete_Enabled = 1;
         bttBtn_delete_Visible = 1;
         bttBtn_cancel_Visible = 1;
         bttBtn_enter_Enabled = 1;
         bttBtn_enter_Visible = 1;
         edtSYS_TenantUserRoleRoleID_Jsonclick = "";
         edtSYS_TenantUserRoleRoleID_Enabled = 1;
         edtSYS_TenantUserRoleTenantCode_Jsonclick = "";
         edtSYS_TenantUserRoleTenantCode_Enabled = 1;
         edtSYS_TenantUserRoleUserID_Jsonclick = "";
         edtSYS_TenantUserRoleUserID_Enabled = 1;
         edtSYS_TenantUserRoleUserRoleID_Jsonclick = "";
         edtSYS_TenantUserRoleUserRoleID_Enabled = 1;
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
         GX_FocusControl = edtSYS_TenantUserRoleUserID_Internalname;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         standaloneNotModal( ) ;
         standaloneModal( ) ;
         /* End function AfterKeyLoadScreen */
      }

      public void Valid_Sys_tenantuserroleuserroleid( Guid GX_Parm1 ,
                                                      Guid GX_Parm2 ,
                                                      String GX_Parm3 ,
                                                      Guid GX_Parm4 )
      {
         A370SYS_TenantUserRoleUserRoleID = (Guid)(GX_Parm1);
         A433SYS_TenantUserRoleUserID = (Guid)(GX_Parm2);
         A441SYS_TenantUserRoleTenantCode = GX_Parm3;
         A434SYS_TenantUserRoleRoleID = (Guid)(GX_Parm4);
         context.wbHandled = 1;
         AfterKeyLoadScreen( ) ;
         Draw( ) ;
         send_integrity_footer_hashes( ) ;
         dynload_actions( ) ;
         if ( AnyError == 1 )
         {
         }
         isValidOutput.Add(A433SYS_TenantUserRoleUserID.ToString());
         isValidOutput.Add(A441SYS_TenantUserRoleTenantCode);
         isValidOutput.Add(A434SYS_TenantUserRoleRoleID.ToString());
         isValidOutput.Add(StringUtil.RTrim( Gx_mode));
         isValidOutput.Add(Z370SYS_TenantUserRoleUserRoleID.ToString());
         isValidOutput.Add(Z433SYS_TenantUserRoleUserID.ToString());
         isValidOutput.Add(Z441SYS_TenantUserRoleTenantCode);
         isValidOutput.Add(Z434SYS_TenantUserRoleRoleID.ToString());
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
         Z370SYS_TenantUserRoleUserRoleID = (Guid)(Guid.Empty);
         Z433SYS_TenantUserRoleUserID = (Guid)(Guid.Empty);
         Z441SYS_TenantUserRoleTenantCode = "";
         Z434SYS_TenantUserRoleRoleID = (Guid)(Guid.Empty);
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
         A370SYS_TenantUserRoleUserRoleID = (Guid)(Guid.Empty);
         A433SYS_TenantUserRoleUserID = (Guid)(Guid.Empty);
         A441SYS_TenantUserRoleTenantCode = "";
         A434SYS_TenantUserRoleRoleID = (Guid)(Guid.Empty);
         bttBtn_enter_Jsonclick = "";
         bttBtn_cancel_Jsonclick = "";
         bttBtn_delete_Jsonclick = "";
         Gx_mode = "";
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         T001J4_A370SYS_TenantUserRoleUserRoleID = new Guid[] {Guid.Empty} ;
         T001J4_A433SYS_TenantUserRoleUserID = new Guid[] {Guid.Empty} ;
         T001J4_A441SYS_TenantUserRoleTenantCode = new String[] {""} ;
         T001J4_A434SYS_TenantUserRoleRoleID = new Guid[] {Guid.Empty} ;
         T001J5_A370SYS_TenantUserRoleUserRoleID = new Guid[] {Guid.Empty} ;
         T001J3_A370SYS_TenantUserRoleUserRoleID = new Guid[] {Guid.Empty} ;
         T001J3_A433SYS_TenantUserRoleUserID = new Guid[] {Guid.Empty} ;
         T001J3_A441SYS_TenantUserRoleTenantCode = new String[] {""} ;
         T001J3_A434SYS_TenantUserRoleRoleID = new Guid[] {Guid.Empty} ;
         sMode56 = "";
         T001J6_A370SYS_TenantUserRoleUserRoleID = new Guid[] {Guid.Empty} ;
         T001J7_A370SYS_TenantUserRoleUserRoleID = new Guid[] {Guid.Empty} ;
         T001J2_A370SYS_TenantUserRoleUserRoleID = new Guid[] {Guid.Empty} ;
         T001J2_A433SYS_TenantUserRoleUserID = new Guid[] {Guid.Empty} ;
         T001J2_A441SYS_TenantUserRoleTenantCode = new String[] {""} ;
         T001J2_A434SYS_TenantUserRoleRoleID = new Guid[] {Guid.Empty} ;
         T001J11_A370SYS_TenantUserRoleUserRoleID = new Guid[] {Guid.Empty} ;
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         i434SYS_TenantUserRoleRoleID = (Guid)(Guid.Empty);
         i433SYS_TenantUserRoleUserID = (Guid)(Guid.Empty);
         isValidOutput = new GxUnknownObjectCollection();
         pr_datastore1 = new DataStoreProvider(context, new GeneXus.Programs.sys_tenantuserrole__datastore1(),
            new Object[][] {
                new Object[] {
               T001J2_A370SYS_TenantUserRoleUserRoleID, T001J2_A433SYS_TenantUserRoleUserID, T001J2_A441SYS_TenantUserRoleTenantCode, T001J2_A434SYS_TenantUserRoleRoleID
               }
               , new Object[] {
               T001J3_A370SYS_TenantUserRoleUserRoleID, T001J3_A433SYS_TenantUserRoleUserID, T001J3_A441SYS_TenantUserRoleTenantCode, T001J3_A434SYS_TenantUserRoleRoleID
               }
               , new Object[] {
               T001J4_A370SYS_TenantUserRoleUserRoleID, T001J4_A433SYS_TenantUserRoleUserID, T001J4_A441SYS_TenantUserRoleTenantCode, T001J4_A434SYS_TenantUserRoleRoleID
               }
               , new Object[] {
               T001J5_A370SYS_TenantUserRoleUserRoleID
               }
               , new Object[] {
               T001J6_A370SYS_TenantUserRoleUserRoleID
               }
               , new Object[] {
               T001J7_A370SYS_TenantUserRoleUserRoleID
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               T001J11_A370SYS_TenantUserRoleUserRoleID
               }
            }
         );
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.sys_tenantuserrole__default(),
            new Object[][] {
            }
         );
         Z434SYS_TenantUserRoleRoleID = (Guid)(Guid.NewGuid( ));
         A434SYS_TenantUserRoleRoleID = (Guid)(Guid.NewGuid( ));
         i434SYS_TenantUserRoleRoleID = (Guid)(Guid.NewGuid( ));
         Z433SYS_TenantUserRoleUserID = (Guid)(Guid.NewGuid( ));
         A433SYS_TenantUserRoleUserID = (Guid)(Guid.NewGuid( ));
         i433SYS_TenantUserRoleUserID = (Guid)(Guid.NewGuid( ));
         Z370SYS_TenantUserRoleUserRoleID = (Guid)(Guid.NewGuid( ));
         A370SYS_TenantUserRoleUserRoleID = (Guid)(Guid.NewGuid( ));
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
      private short RcdFound56 ;
      private short gxajaxcallmode ;
      private short wbTemp ;
      private int trnEnded ;
      private int bttBtn_first_Visible ;
      private int bttBtn_previous_Visible ;
      private int bttBtn_next_Visible ;
      private int bttBtn_last_Visible ;
      private int bttBtn_select_Visible ;
      private int edtSYS_TenantUserRoleUserRoleID_Enabled ;
      private int edtSYS_TenantUserRoleUserID_Enabled ;
      private int edtSYS_TenantUserRoleTenantCode_Enabled ;
      private int edtSYS_TenantUserRoleRoleID_Enabled ;
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
      private String edtSYS_TenantUserRoleUserRoleID_Internalname ;
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
      private String edtSYS_TenantUserRoleUserRoleID_Jsonclick ;
      private String edtSYS_TenantUserRoleUserID_Internalname ;
      private String edtSYS_TenantUserRoleUserID_Jsonclick ;
      private String edtSYS_TenantUserRoleTenantCode_Internalname ;
      private String edtSYS_TenantUserRoleTenantCode_Jsonclick ;
      private String edtSYS_TenantUserRoleRoleID_Internalname ;
      private String edtSYS_TenantUserRoleRoleID_Jsonclick ;
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
      private String sMode56 ;
      private String sDynURL ;
      private String FormProcess ;
      private String bodyStyle ;
      private bool entryPointCalled ;
      private bool toggleJsOutput ;
      private bool wbErr ;
      private String Z441SYS_TenantUserRoleTenantCode ;
      private String A441SYS_TenantUserRoleTenantCode ;
      private Guid Z370SYS_TenantUserRoleUserRoleID ;
      private Guid Z433SYS_TenantUserRoleUserID ;
      private Guid Z434SYS_TenantUserRoleRoleID ;
      private Guid A370SYS_TenantUserRoleUserRoleID ;
      private Guid A433SYS_TenantUserRoleUserID ;
      private Guid A434SYS_TenantUserRoleRoleID ;
      private Guid i434SYS_TenantUserRoleRoleID ;
      private Guid i433SYS_TenantUserRoleUserID ;
      private GxUnknownObjectCollection isValidOutput ;
      private IGxDataStore dsDataStore1 ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_datastore1 ;
      private Guid[] T001J4_A370SYS_TenantUserRoleUserRoleID ;
      private Guid[] T001J4_A433SYS_TenantUserRoleUserID ;
      private String[] T001J4_A441SYS_TenantUserRoleTenantCode ;
      private Guid[] T001J4_A434SYS_TenantUserRoleRoleID ;
      private Guid[] T001J5_A370SYS_TenantUserRoleUserRoleID ;
      private Guid[] T001J3_A370SYS_TenantUserRoleUserRoleID ;
      private Guid[] T001J3_A433SYS_TenantUserRoleUserID ;
      private String[] T001J3_A441SYS_TenantUserRoleTenantCode ;
      private Guid[] T001J3_A434SYS_TenantUserRoleRoleID ;
      private Guid[] T001J6_A370SYS_TenantUserRoleUserRoleID ;
      private Guid[] T001J7_A370SYS_TenantUserRoleUserRoleID ;
      private Guid[] T001J2_A370SYS_TenantUserRoleUserRoleID ;
      private Guid[] T001J2_A433SYS_TenantUserRoleUserID ;
      private String[] T001J2_A441SYS_TenantUserRoleTenantCode ;
      private Guid[] T001J2_A434SYS_TenantUserRoleRoleID ;
      private IDataStoreProvider pr_default ;
      private Guid[] T001J11_A370SYS_TenantUserRoleUserRoleID ;
      private GXWebForm Form ;
   }

   public class sys_tenantuserrole__datastore1 : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmT001J4 ;
          prmT001J4 = new Object[] {
          new Object[] {"@SYS_TenantUserRoleUserRoleID",SqlDbType.UniqueIdentifier,16,0}
          } ;
          Object[] prmT001J5 ;
          prmT001J5 = new Object[] {
          new Object[] {"@SYS_TenantUserRoleUserRoleID",SqlDbType.UniqueIdentifier,16,0}
          } ;
          Object[] prmT001J3 ;
          prmT001J3 = new Object[] {
          new Object[] {"@SYS_TenantUserRoleUserRoleID",SqlDbType.UniqueIdentifier,16,0}
          } ;
          Object[] prmT001J6 ;
          prmT001J6 = new Object[] {
          new Object[] {"@SYS_TenantUserRoleUserRoleID",SqlDbType.UniqueIdentifier,16,0}
          } ;
          Object[] prmT001J7 ;
          prmT001J7 = new Object[] {
          new Object[] {"@SYS_TenantUserRoleUserRoleID",SqlDbType.UniqueIdentifier,16,0}
          } ;
          Object[] prmT001J2 ;
          prmT001J2 = new Object[] {
          new Object[] {"@SYS_TenantUserRoleUserRoleID",SqlDbType.UniqueIdentifier,16,0}
          } ;
          Object[] prmT001J8 ;
          prmT001J8 = new Object[] {
          new Object[] {"@SYS_TenantUserRoleTenantCode",SqlDbType.NVarChar,20,0} ,
          new Object[] {"@SYS_TenantUserRoleUserRoleID",SqlDbType.UniqueIdentifier,16,0} ,
          new Object[] {"@SYS_TenantUserRoleUserID",SqlDbType.UniqueIdentifier,16,0} ,
          new Object[] {"@SYS_TenantUserRoleRoleID",SqlDbType.UniqueIdentifier,16,0}
          } ;
          Object[] prmT001J9 ;
          prmT001J9 = new Object[] {
          new Object[] {"@SYS_TenantUserRoleUserID",SqlDbType.UniqueIdentifier,16,0} ,
          new Object[] {"@SYS_TenantUserRoleTenantCode",SqlDbType.NVarChar,20,0} ,
          new Object[] {"@SYS_TenantUserRoleRoleID",SqlDbType.UniqueIdentifier,16,0} ,
          new Object[] {"@SYS_TenantUserRoleUserRoleID",SqlDbType.UniqueIdentifier,16,0}
          } ;
          Object[] prmT001J10 ;
          prmT001J10 = new Object[] {
          new Object[] {"@SYS_TenantUserRoleUserRoleID",SqlDbType.UniqueIdentifier,16,0}
          } ;
          Object[] prmT001J11 ;
          prmT001J11 = new Object[] {
          } ;
          def= new CursorDef[] {
              new CursorDef("T001J2", "SELECT [UserRoleID], [UserID], [TenantCode], [RoleID] FROM [SYS_TenantUserRole] WITH (UPDLOCK) WHERE [UserRoleID] = @SYS_TenantUserRoleUserRoleID ",true, GxErrorMask.GX_NOMASK, false, this,prmT001J2,1,0,true,false )
             ,new CursorDef("T001J3", "SELECT [UserRoleID], [UserID], [TenantCode], [RoleID] FROM [SYS_TenantUserRole] WITH (NOLOCK) WHERE [UserRoleID] = @SYS_TenantUserRoleUserRoleID ",true, GxErrorMask.GX_NOMASK, false, this,prmT001J3,1,0,true,false )
             ,new CursorDef("T001J4", "SELECT TM1.[UserRoleID], TM1.[UserID], TM1.[TenantCode], TM1.[RoleID] FROM [SYS_TenantUserRole] TM1 WITH (NOLOCK) WHERE TM1.[UserRoleID] = @SYS_TenantUserRoleUserRoleID ORDER BY TM1.[UserRoleID]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT001J4,100,0,true,false )
             ,new CursorDef("T001J5", "SELECT [UserRoleID] FROM [SYS_TenantUserRole] WITH (NOLOCK) WHERE [UserRoleID] = @SYS_TenantUserRoleUserRoleID  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT001J5,1,0,true,false )
             ,new CursorDef("T001J6", "SELECT TOP 1 [UserRoleID] FROM [SYS_TenantUserRole] WITH (NOLOCK) WHERE ( [UserRoleID] > @SYS_TenantUserRoleUserRoleID) ORDER BY [UserRoleID]  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT001J6,1,0,true,true )
             ,new CursorDef("T001J7", "SELECT TOP 1 [UserRoleID] FROM [SYS_TenantUserRole] WITH (NOLOCK) WHERE ( [UserRoleID] < @SYS_TenantUserRoleUserRoleID) ORDER BY [UserRoleID] DESC  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT001J7,1,0,true,true )
             ,new CursorDef("T001J8", "INSERT INTO [SYS_TenantUserRole]([TenantCode], [UserRoleID], [UserID], [RoleID]) VALUES(@SYS_TenantUserRoleTenantCode, @SYS_TenantUserRoleUserRoleID, @SYS_TenantUserRoleUserID, @SYS_TenantUserRoleRoleID)", GxErrorMask.GX_NOMASK,prmT001J8)
             ,new CursorDef("T001J9", "UPDATE [SYS_TenantUserRole] SET [UserID]=@SYS_TenantUserRoleUserID, [TenantCode]=@SYS_TenantUserRoleTenantCode, [RoleID]=@SYS_TenantUserRoleRoleID  WHERE [UserRoleID] = @SYS_TenantUserRoleUserRoleID", GxErrorMask.GX_NOMASK,prmT001J9)
             ,new CursorDef("T001J10", "DELETE FROM [SYS_TenantUserRole]  WHERE [UserRoleID] = @SYS_TenantUserRoleUserRoleID", GxErrorMask.GX_NOMASK,prmT001J10)
             ,new CursorDef("T001J11", "SELECT [UserRoleID] FROM [SYS_TenantUserRole] WITH (NOLOCK) ORDER BY [UserRoleID]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT001J11,100,0,true,false )
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
                ((Guid[]) buf[3])[0] = rslt.getGuid(4) ;
                return;
             case 1 :
                ((Guid[]) buf[0])[0] = rslt.getGuid(1) ;
                ((Guid[]) buf[1])[0] = rslt.getGuid(2) ;
                ((String[]) buf[2])[0] = rslt.getVarchar(3) ;
                ((Guid[]) buf[3])[0] = rslt.getGuid(4) ;
                return;
             case 2 :
                ((Guid[]) buf[0])[0] = rslt.getGuid(1) ;
                ((Guid[]) buf[1])[0] = rslt.getGuid(2) ;
                ((String[]) buf[2])[0] = rslt.getVarchar(3) ;
                ((Guid[]) buf[3])[0] = rslt.getGuid(4) ;
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
                stmt.SetParameter(2, (Guid)parms[1]);
                stmt.SetParameter(3, (Guid)parms[2]);
                stmt.SetParameter(4, (Guid)parms[3]);
                return;
             case 7 :
                stmt.SetParameter(1, (Guid)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                stmt.SetParameter(3, (Guid)parms[2]);
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

 public class sys_tenantuserrole__default : DataStoreHelperBase, IDataStoreHelper
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
