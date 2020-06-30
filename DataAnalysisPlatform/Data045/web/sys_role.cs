/*
               File: SYS_Role
        Description: SYS_Role
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/28/2020 15:8:58.59
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
   public class sys_role : GXDataArea, System.Web.SessionState.IRequiresSessionState
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
            Form.Meta.addItem("description", "SYS_Role", 0) ;
         }
         context.wjLoc = "";
         context.nUserReturn = 0;
         context.wbHandled = 0;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         GX_FocusControl = edtRoleID_Internalname;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         wbErr = false;
         context.SetDefaultTheme("WorkWithPlusTheme");
         if ( ! context.IsLocalStorageSupported( ) )
         {
            context.PushCurrentUrl();
         }
      }

      public sys_role( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public sys_role( IGxContext context )
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
            GxWebStd.gx_label_ctrl( context, lblTitle_Internalname, "SYS_Role", "", "", lblTitle_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Title", 0, "", 1, 1, 0, "HLP_SYS_Role.htm");
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
            GxWebStd.gx_button_ctrl( context, bttBtn_first_Internalname, "", "|<", bttBtn_first_Jsonclick, 5, "|<", "", StyleString, ClassString, bttBtn_first_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"EFIRST."+"'", TempTags, "", context.GetButtonType( ), "HLP_SYS_Role.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 14,'',false,'',0)\"";
            ClassString = "BtnPrevious";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_previous_Internalname, "", "<", bttBtn_previous_Jsonclick, 5, "<", "", StyleString, ClassString, bttBtn_previous_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"EPREVIOUS."+"'", TempTags, "", context.GetButtonType( ), "HLP_SYS_Role.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 16,'',false,'',0)\"";
            ClassString = "BtnNext";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_next_Internalname, "", ">", bttBtn_next_Jsonclick, 5, ">", "", StyleString, ClassString, bttBtn_next_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ENEXT."+"'", TempTags, "", context.GetButtonType( ), "HLP_SYS_Role.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 18,'',false,'',0)\"";
            ClassString = "BtnLast";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_last_Internalname, "", ">|", bttBtn_last_Jsonclick, 5, ">|", "", StyleString, ClassString, bttBtn_last_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ELAST."+"'", TempTags, "", context.GetButtonType( ), "HLP_SYS_Role.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 20,'',false,'',0)\"";
            ClassString = "BtnSelect";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_select_Internalname, "", "选择", bttBtn_select_Jsonclick, 5, "选择", "", StyleString, ClassString, bttBtn_select_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ESELECT."+"'", TempTags, "", 2, "HLP_SYS_Role.htm");
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
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtRoleID_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtRoleID_Internalname, "Role ID", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 28,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtRoleID_Internalname, A361RoleID.ToString(), A361RoleID.ToString(), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,28);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtRoleID_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtRoleID_Enabled, 0, "text", "", 36, "chr", 1, "row", 36, 0, 0, 0, 1, 0, 0, true, "", "", false, "HLP_SYS_Role.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtSYS_RoleTenantCode_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtSYS_RoleTenantCode_Internalname, "Tenant Code", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 33,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtSYS_RoleTenantCode_Internalname, A367SYS_RoleTenantCode, StringUtil.RTrim( context.localUtil.Format( A367SYS_RoleTenantCode, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,33);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtSYS_RoleTenantCode_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtSYS_RoleTenantCode_Enabled, 0, "text", "", 20, "chr", 1, "row", 20, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_SYS_Role.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtRoleName_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtRoleName_Internalname, "Role Name", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 38,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtRoleName_Internalname, A368RoleName, StringUtil.RTrim( context.localUtil.Format( A368RoleName, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,38);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtRoleName_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtRoleName_Enabled, 0, "text", "", 50, "chr", 1, "row", 50, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_SYS_Role.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtRoleType_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtRoleType_Internalname, "全局/协会/租户", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 43,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtRoleType_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A408RoleType), 9, 0, ".", "")), ((edtRoleType_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A408RoleType), "ZZZZZZZZ9")) : context.localUtil.Format( (decimal)(A408RoleType), "ZZZZZZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,43);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtRoleType_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtRoleType_Enabled, 0, "number", "1", 9, "chr", 1, "row", 9, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_SYS_Role.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtSYS_RoleDescription_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtSYS_RoleDescription_Internalname, "Description", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 48,'',false,'',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtSYS_RoleDescription_Internalname, A409SYS_RoleDescription, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,48);\"", 0, 1, edtSYS_RoleDescription_Enabled, 0, 80, "chr", 10, "row", StyleString, ClassString, "", "", "2048", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_SYS_Role.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtSYS_RoleCreator_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtSYS_RoleCreator_Internalname, "Creator", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 53,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtSYS_RoleCreator_Internalname, A410SYS_RoleCreator, StringUtil.RTrim( context.localUtil.Format( A410SYS_RoleCreator, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,53);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtSYS_RoleCreator_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtSYS_RoleCreator_Enabled, 0, "text", "", 50, "chr", 1, "row", 50, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_SYS_Role.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtSYS_RoleCreateTime_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtSYS_RoleCreateTime_Internalname, "Create Time", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 58,'',false,'',0)\"";
            context.WriteHtmlText( "<div id=\""+edtSYS_RoleCreateTime_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtSYS_RoleCreateTime_Internalname, context.localUtil.TToC( A411SYS_RoleCreateTime, 10, 8, 0, 0, "/", ":", " "), context.localUtil.Format( A411SYS_RoleCreateTime, "9999/99/99 99:99:99"), TempTags+" onchange=\""+"gx.date.valid_date(this, 10,'YMD',8,24,'chs',false,1);"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,58);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtSYS_RoleCreateTime_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtSYS_RoleCreateTime_Enabled, 0, "text", "", 19, "chr", 1, "row", 19, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_SYS_Role.htm");
            GxWebStd.gx_bitmap( context, edtSYS_RoleCreateTime_Internalname+"_dp_trigger", context.GetImagePath( "61b9b5d3-dff6-4d59-9b00-da61bc2cbe93", "", context.GetTheme( )), "", "", "", "", ((1==0)||(edtSYS_RoleCreateTime_Enabled==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;", "", "", "", "", "", "", "", "", 1, false, false, "", "HLP_SYS_Role.htm");
            context.WriteHtmlTextNl( "</div>") ;
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtSYS_RoleModifier_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtSYS_RoleModifier_Internalname, "Modifier", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 63,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtSYS_RoleModifier_Internalname, A412SYS_RoleModifier, StringUtil.RTrim( context.localUtil.Format( A412SYS_RoleModifier, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,63);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtSYS_RoleModifier_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtSYS_RoleModifier_Enabled, 0, "text", "", 50, "chr", 1, "row", 50, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_SYS_Role.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtSYS_RoleModifyTime_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtSYS_RoleModifyTime_Internalname, "Modify Time", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 68,'',false,'',0)\"";
            context.WriteHtmlText( "<div id=\""+edtSYS_RoleModifyTime_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtSYS_RoleModifyTime_Internalname, context.localUtil.TToC( A413SYS_RoleModifyTime, 10, 8, 0, 0, "/", ":", " "), context.localUtil.Format( A413SYS_RoleModifyTime, "9999/99/99 99:99:99"), TempTags+" onchange=\""+"gx.date.valid_date(this, 10,'YMD',8,24,'chs',false,1);"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,68);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtSYS_RoleModifyTime_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtSYS_RoleModifyTime_Enabled, 0, "text", "", 19, "chr", 1, "row", 19, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_SYS_Role.htm");
            GxWebStd.gx_bitmap( context, edtSYS_RoleModifyTime_Internalname+"_dp_trigger", context.GetImagePath( "61b9b5d3-dff6-4d59-9b00-da61bc2cbe93", "", context.GetTheme( )), "", "", "", "", ((1==0)||(edtSYS_RoleModifyTime_Enabled==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;", "", "", "", "", "", "", "", "", 1, false, false, "", "HLP_SYS_Role.htm");
            context.WriteHtmlTextNl( "</div>") ;
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtSYS_RoleIsDeleted_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtSYS_RoleIsDeleted_Internalname, "Is Deleted", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 73,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtSYS_RoleIsDeleted_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A414SYS_RoleIsDeleted), 1, 0, ".", "")), ((edtSYS_RoleIsDeleted_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A414SYS_RoleIsDeleted), "9")) : context.localUtil.Format( (decimal)(A414SYS_RoleIsDeleted), "9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,73);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtSYS_RoleIsDeleted_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtSYS_RoleIsDeleted_Enabled, 0, "number", "1", 1, "chr", 1, "row", 1, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_SYS_Role.htm");
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
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 78,'',false,'',0)\"";
            ClassString = "BtnEnter";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_enter_Internalname, "", "确认", bttBtn_enter_Jsonclick, 5, "确认", "", StyleString, ClassString, bttBtn_enter_Visible, bttBtn_enter_Enabled, "standard", "'"+""+"'"+",false,"+"'"+"EENTER."+"'", TempTags, "", context.GetButtonType( ), "HLP_SYS_Role.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 80,'',false,'',0)\"";
            ClassString = "BtnCancel";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_cancel_Internalname, "", "取消", bttBtn_cancel_Jsonclick, 1, "取消", "", StyleString, ClassString, bttBtn_cancel_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ECANCEL."+"'", TempTags, "", context.GetButtonType( ), "HLP_SYS_Role.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 82,'',false,'',0)\"";
            ClassString = "BtnDelete";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_delete_Internalname, "", "删除", bttBtn_delete_Jsonclick, 5, "删除", "", StyleString, ClassString, bttBtn_delete_Visible, bttBtn_delete_Enabled, "standard", "'"+""+"'"+",false,"+"'"+"EDELETE."+"'", TempTags, "", context.GetButtonType( ), "HLP_SYS_Role.htm");
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
               if ( StringUtil.StrCmp(cgiGet( edtRoleID_Internalname), "") == 0 )
               {
                  A361RoleID = (Guid)(Guid.Empty);
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A361RoleID", A361RoleID.ToString());
               }
               else
               {
                  try
                  {
                     A361RoleID = (Guid)(StringUtil.StrToGuid( cgiGet( edtRoleID_Internalname)));
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A361RoleID", A361RoleID.ToString());
                  }
                  catch ( Exception e )
                  {
                     GX_msglist.addItem(context.GetMessage( "GXM_invalidguid", ""), 1, "ROLEID");
                     AnyError = 1;
                     GX_FocusControl = edtRoleID_Internalname;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                     wbErr = true;
                  }
               }
               A367SYS_RoleTenantCode = cgiGet( edtSYS_RoleTenantCode_Internalname);
               n367SYS_RoleTenantCode = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A367SYS_RoleTenantCode", A367SYS_RoleTenantCode);
               n367SYS_RoleTenantCode = (String.IsNullOrEmpty(StringUtil.RTrim( A367SYS_RoleTenantCode)) ? true : false);
               A368RoleName = cgiGet( edtRoleName_Internalname);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A368RoleName", A368RoleName);
               if ( ( ( context.localUtil.CToN( cgiGet( edtRoleType_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtRoleType_Internalname), ".", ",") > Convert.ToDecimal( 999999999 )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "ROLETYPE");
                  AnyError = 1;
                  GX_FocusControl = edtRoleType_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A408RoleType = 0;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A408RoleType", StringUtil.LTrim( StringUtil.Str( (decimal)(A408RoleType), 9, 0)));
               }
               else
               {
                  A408RoleType = (int)(context.localUtil.CToN( cgiGet( edtRoleType_Internalname), ".", ","));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A408RoleType", StringUtil.LTrim( StringUtil.Str( (decimal)(A408RoleType), 9, 0)));
               }
               A409SYS_RoleDescription = cgiGet( edtSYS_RoleDescription_Internalname);
               n409SYS_RoleDescription = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A409SYS_RoleDescription", A409SYS_RoleDescription);
               n409SYS_RoleDescription = (String.IsNullOrEmpty(StringUtil.RTrim( A409SYS_RoleDescription)) ? true : false);
               A410SYS_RoleCreator = cgiGet( edtSYS_RoleCreator_Internalname);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A410SYS_RoleCreator", A410SYS_RoleCreator);
               if ( context.localUtil.VCDateTime( cgiGet( edtSYS_RoleCreateTime_Internalname), 0, 0) == 0 )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_baddatetime", new   object[]  {"SYS_Role Create Time"}), 1, "SYS_ROLECREATETIME");
                  AnyError = 1;
                  GX_FocusControl = edtSYS_RoleCreateTime_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A411SYS_RoleCreateTime = (DateTime)(DateTime.MinValue);
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A411SYS_RoleCreateTime", context.localUtil.TToC( A411SYS_RoleCreateTime, 10, 8, 0, 0, "/", ":", " "));
               }
               else
               {
                  A411SYS_RoleCreateTime = context.localUtil.CToT( cgiGet( edtSYS_RoleCreateTime_Internalname));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A411SYS_RoleCreateTime", context.localUtil.TToC( A411SYS_RoleCreateTime, 10, 8, 0, 0, "/", ":", " "));
               }
               A412SYS_RoleModifier = cgiGet( edtSYS_RoleModifier_Internalname);
               n412SYS_RoleModifier = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A412SYS_RoleModifier", A412SYS_RoleModifier);
               n412SYS_RoleModifier = (String.IsNullOrEmpty(StringUtil.RTrim( A412SYS_RoleModifier)) ? true : false);
               if ( context.localUtil.VCDateTime( cgiGet( edtSYS_RoleModifyTime_Internalname), 0, 0) == 0 )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_baddatetime", new   object[]  {"SYS_Role Modify Time"}), 1, "SYS_ROLEMODIFYTIME");
                  AnyError = 1;
                  GX_FocusControl = edtSYS_RoleModifyTime_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A413SYS_RoleModifyTime = (DateTime)(DateTime.MinValue);
                  n413SYS_RoleModifyTime = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A413SYS_RoleModifyTime", context.localUtil.TToC( A413SYS_RoleModifyTime, 10, 8, 0, 0, "/", ":", " "));
               }
               else
               {
                  A413SYS_RoleModifyTime = context.localUtil.CToT( cgiGet( edtSYS_RoleModifyTime_Internalname));
                  n413SYS_RoleModifyTime = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A413SYS_RoleModifyTime", context.localUtil.TToC( A413SYS_RoleModifyTime, 10, 8, 0, 0, "/", ":", " "));
               }
               n413SYS_RoleModifyTime = ((DateTime.MinValue==A413SYS_RoleModifyTime) ? true : false);
               if ( ( ( context.localUtil.CToN( cgiGet( edtSYS_RoleIsDeleted_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtSYS_RoleIsDeleted_Internalname), ".", ",") > Convert.ToDecimal( 9 )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "SYS_ROLEISDELETED");
                  AnyError = 1;
                  GX_FocusControl = edtSYS_RoleIsDeleted_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A414SYS_RoleIsDeleted = 0;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A414SYS_RoleIsDeleted", StringUtil.Str( (decimal)(A414SYS_RoleIsDeleted), 1, 0));
               }
               else
               {
                  A414SYS_RoleIsDeleted = (short)(context.localUtil.CToN( cgiGet( edtSYS_RoleIsDeleted_Internalname), ".", ","));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A414SYS_RoleIsDeleted", StringUtil.Str( (decimal)(A414SYS_RoleIsDeleted), 1, 0));
               }
               /* Read saved values. */
               Z361RoleID = (Guid)(StringUtil.StrToGuid( cgiGet( "Z361RoleID")));
               Z367SYS_RoleTenantCode = cgiGet( "Z367SYS_RoleTenantCode");
               n367SYS_RoleTenantCode = (String.IsNullOrEmpty(StringUtil.RTrim( A367SYS_RoleTenantCode)) ? true : false);
               Z368RoleName = cgiGet( "Z368RoleName");
               Z408RoleType = (int)(context.localUtil.CToN( cgiGet( "Z408RoleType"), ".", ","));
               Z410SYS_RoleCreator = cgiGet( "Z410SYS_RoleCreator");
               Z411SYS_RoleCreateTime = context.localUtil.CToT( cgiGet( "Z411SYS_RoleCreateTime"), 0);
               Z412SYS_RoleModifier = cgiGet( "Z412SYS_RoleModifier");
               n412SYS_RoleModifier = (String.IsNullOrEmpty(StringUtil.RTrim( A412SYS_RoleModifier)) ? true : false);
               Z413SYS_RoleModifyTime = context.localUtil.CToT( cgiGet( "Z413SYS_RoleModifyTime"), 0);
               n413SYS_RoleModifyTime = ((DateTime.MinValue==A413SYS_RoleModifyTime) ? true : false);
               Z414SYS_RoleIsDeleted = (short)(context.localUtil.CToN( cgiGet( "Z414SYS_RoleIsDeleted"), ".", ","));
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
                  A361RoleID = (Guid)(StringUtil.StrToGuid( GetNextPar( )));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A361RoleID", A361RoleID.ToString());
                  getEqualNoModal( ) ;
                  if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  && (Guid.Empty==A361RoleID) && ( Gx_BScreen == 0 ) )
                  {
                     A361RoleID = (Guid)(Guid.NewGuid( ));
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A361RoleID", A361RoleID.ToString());
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
               InitAll1H54( ) ;
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
         DisableAttributes1H54( ) ;
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

      protected void ResetCaption1H0( )
      {
      }

      protected void ZM1H54( short GX_JID )
      {
         if ( ( GX_JID == 5 ) || ( GX_JID == 0 ) )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
            {
               Z367SYS_RoleTenantCode = T001H3_A367SYS_RoleTenantCode[0];
               Z368RoleName = T001H3_A368RoleName[0];
               Z408RoleType = T001H3_A408RoleType[0];
               Z410SYS_RoleCreator = T001H3_A410SYS_RoleCreator[0];
               Z411SYS_RoleCreateTime = T001H3_A411SYS_RoleCreateTime[0];
               Z412SYS_RoleModifier = T001H3_A412SYS_RoleModifier[0];
               Z413SYS_RoleModifyTime = T001H3_A413SYS_RoleModifyTime[0];
               Z414SYS_RoleIsDeleted = T001H3_A414SYS_RoleIsDeleted[0];
            }
            else
            {
               Z367SYS_RoleTenantCode = A367SYS_RoleTenantCode;
               Z368RoleName = A368RoleName;
               Z408RoleType = A408RoleType;
               Z410SYS_RoleCreator = A410SYS_RoleCreator;
               Z411SYS_RoleCreateTime = A411SYS_RoleCreateTime;
               Z412SYS_RoleModifier = A412SYS_RoleModifier;
               Z413SYS_RoleModifyTime = A413SYS_RoleModifyTime;
               Z414SYS_RoleIsDeleted = A414SYS_RoleIsDeleted;
            }
         }
         if ( GX_JID == -5 )
         {
            Z361RoleID = (Guid)(A361RoleID);
            Z367SYS_RoleTenantCode = A367SYS_RoleTenantCode;
            Z368RoleName = A368RoleName;
            Z408RoleType = A408RoleType;
            Z409SYS_RoleDescription = A409SYS_RoleDescription;
            Z410SYS_RoleCreator = A410SYS_RoleCreator;
            Z411SYS_RoleCreateTime = A411SYS_RoleCreateTime;
            Z412SYS_RoleModifier = A412SYS_RoleModifier;
            Z413SYS_RoleModifyTime = A413SYS_RoleModifyTime;
            Z414SYS_RoleIsDeleted = A414SYS_RoleIsDeleted;
         }
      }

      protected void standaloneNotModal( )
      {
         Gx_BScreen = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_BScreen", StringUtil.Str( (decimal)(Gx_BScreen), 1, 0));
      }

      protected void standaloneModal( )
      {
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  && (Guid.Empty==A361RoleID) && ( Gx_BScreen == 0 ) )
         {
            A361RoleID = (Guid)(Guid.NewGuid( ));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A361RoleID", A361RoleID.ToString());
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

      protected void Load1H54( )
      {
         /* Using cursor T001H4 */
         pr_datastore1.execute(2, new Object[] {A361RoleID});
         if ( (pr_datastore1.getStatus(2) != 101) )
         {
            RcdFound54 = 1;
            A367SYS_RoleTenantCode = T001H4_A367SYS_RoleTenantCode[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A367SYS_RoleTenantCode", A367SYS_RoleTenantCode);
            n367SYS_RoleTenantCode = T001H4_n367SYS_RoleTenantCode[0];
            A368RoleName = T001H4_A368RoleName[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A368RoleName", A368RoleName);
            A408RoleType = T001H4_A408RoleType[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A408RoleType", StringUtil.LTrim( StringUtil.Str( (decimal)(A408RoleType), 9, 0)));
            A409SYS_RoleDescription = T001H4_A409SYS_RoleDescription[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A409SYS_RoleDescription", A409SYS_RoleDescription);
            n409SYS_RoleDescription = T001H4_n409SYS_RoleDescription[0];
            A410SYS_RoleCreator = T001H4_A410SYS_RoleCreator[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A410SYS_RoleCreator", A410SYS_RoleCreator);
            A411SYS_RoleCreateTime = T001H4_A411SYS_RoleCreateTime[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A411SYS_RoleCreateTime", context.localUtil.TToC( A411SYS_RoleCreateTime, 10, 8, 0, 0, "/", ":", " "));
            A412SYS_RoleModifier = T001H4_A412SYS_RoleModifier[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A412SYS_RoleModifier", A412SYS_RoleModifier);
            n412SYS_RoleModifier = T001H4_n412SYS_RoleModifier[0];
            A413SYS_RoleModifyTime = T001H4_A413SYS_RoleModifyTime[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A413SYS_RoleModifyTime", context.localUtil.TToC( A413SYS_RoleModifyTime, 10, 8, 0, 0, "/", ":", " "));
            n413SYS_RoleModifyTime = T001H4_n413SYS_RoleModifyTime[0];
            A414SYS_RoleIsDeleted = T001H4_A414SYS_RoleIsDeleted[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A414SYS_RoleIsDeleted", StringUtil.Str( (decimal)(A414SYS_RoleIsDeleted), 1, 0));
            ZM1H54( -5) ;
         }
         pr_datastore1.close(2);
         OnLoadActions1H54( ) ;
      }

      protected void OnLoadActions1H54( )
      {
      }

      protected void CheckExtendedTable1H54( )
      {
         Gx_BScreen = 1;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_BScreen", StringUtil.Str( (decimal)(Gx_BScreen), 1, 0));
         standaloneModal( ) ;
         /* Using cursor T001H5 */
         pr_datastore1.execute(3, new Object[] {n367SYS_RoleTenantCode, A367SYS_RoleTenantCode, A368RoleName, A361RoleID});
         if ( (pr_datastore1.getStatus(3) != 101) )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_1004", new   object[]  {"SYS_Role Tenant Code"+","+"Role Name"}), 1, "SYS_ROLETENANTCODE");
            AnyError = 1;
            GX_FocusControl = edtSYS_RoleTenantCode_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         pr_datastore1.close(3);
         if ( ! ( (DateTime.MinValue==A411SYS_RoleCreateTime) || ( A411SYS_RoleCreateTime >= context.localUtil.YMDHMSToT( 1753, 1, 1, 0, 0, 0) ) ) )
         {
            GX_msglist.addItem("域SYS_Role Create Time超界", "OutOfRange", 1, "SYS_ROLECREATETIME");
            AnyError = 1;
            GX_FocusControl = edtSYS_RoleCreateTime_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( ! ( (DateTime.MinValue==A413SYS_RoleModifyTime) || ( A413SYS_RoleModifyTime >= context.localUtil.YMDHMSToT( 1753, 1, 1, 0, 0, 0) ) ) )
         {
            GX_msglist.addItem("域SYS_Role Modify Time超界", "OutOfRange", 1, "SYS_ROLEMODIFYTIME");
            AnyError = 1;
            GX_FocusControl = edtSYS_RoleModifyTime_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
      }

      protected void CloseExtendedTableCursors1H54( )
      {
      }

      protected void enableDisable( )
      {
      }

      protected void GetKey1H54( )
      {
         /* Using cursor T001H6 */
         pr_datastore1.execute(4, new Object[] {A361RoleID});
         if ( (pr_datastore1.getStatus(4) != 101) )
         {
            RcdFound54 = 1;
         }
         else
         {
            RcdFound54 = 0;
         }
         pr_datastore1.close(4);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor T001H3 */
         pr_datastore1.execute(1, new Object[] {A361RoleID});
         if ( (pr_datastore1.getStatus(1) != 101) )
         {
            ZM1H54( 5) ;
            RcdFound54 = 1;
            A361RoleID = (Guid)((Guid)(T001H3_A361RoleID[0]));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A361RoleID", A361RoleID.ToString());
            A367SYS_RoleTenantCode = T001H3_A367SYS_RoleTenantCode[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A367SYS_RoleTenantCode", A367SYS_RoleTenantCode);
            n367SYS_RoleTenantCode = T001H3_n367SYS_RoleTenantCode[0];
            A368RoleName = T001H3_A368RoleName[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A368RoleName", A368RoleName);
            A408RoleType = T001H3_A408RoleType[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A408RoleType", StringUtil.LTrim( StringUtil.Str( (decimal)(A408RoleType), 9, 0)));
            A409SYS_RoleDescription = T001H3_A409SYS_RoleDescription[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A409SYS_RoleDescription", A409SYS_RoleDescription);
            n409SYS_RoleDescription = T001H3_n409SYS_RoleDescription[0];
            A410SYS_RoleCreator = T001H3_A410SYS_RoleCreator[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A410SYS_RoleCreator", A410SYS_RoleCreator);
            A411SYS_RoleCreateTime = T001H3_A411SYS_RoleCreateTime[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A411SYS_RoleCreateTime", context.localUtil.TToC( A411SYS_RoleCreateTime, 10, 8, 0, 0, "/", ":", " "));
            A412SYS_RoleModifier = T001H3_A412SYS_RoleModifier[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A412SYS_RoleModifier", A412SYS_RoleModifier);
            n412SYS_RoleModifier = T001H3_n412SYS_RoleModifier[0];
            A413SYS_RoleModifyTime = T001H3_A413SYS_RoleModifyTime[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A413SYS_RoleModifyTime", context.localUtil.TToC( A413SYS_RoleModifyTime, 10, 8, 0, 0, "/", ":", " "));
            n413SYS_RoleModifyTime = T001H3_n413SYS_RoleModifyTime[0];
            A414SYS_RoleIsDeleted = T001H3_A414SYS_RoleIsDeleted[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A414SYS_RoleIsDeleted", StringUtil.Str( (decimal)(A414SYS_RoleIsDeleted), 1, 0));
            Z361RoleID = (Guid)(A361RoleID);
            sMode54 = Gx_mode;
            Gx_mode = "DSP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            standaloneModal( ) ;
            Load1H54( ) ;
            if ( AnyError == 1 )
            {
               RcdFound54 = 0;
               InitializeNonKey1H54( ) ;
            }
            Gx_mode = sMode54;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         else
         {
            RcdFound54 = 0;
            InitializeNonKey1H54( ) ;
            sMode54 = Gx_mode;
            Gx_mode = "DSP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            standaloneModal( ) ;
            Gx_mode = sMode54;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         pr_datastore1.close(1);
      }

      protected void getEqualNoModal( )
      {
         GetKey1H54( ) ;
         if ( RcdFound54 == 0 )
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
         RcdFound54 = 0;
         /* Using cursor T001H7 */
         pr_datastore1.execute(5, new Object[] {A361RoleID});
         if ( (pr_datastore1.getStatus(5) != 101) )
         {
            while ( (pr_datastore1.getStatus(5) != 101) && ( ( GuidUtil.Compare(T001H7_A361RoleID[0], A361RoleID, 1) < 0 ) ) )
            {
               pr_datastore1.readNext(5);
            }
            if ( (pr_datastore1.getStatus(5) != 101) && ( ( GuidUtil.Compare(T001H7_A361RoleID[0], A361RoleID, 1) > 0 ) ) )
            {
               A361RoleID = (Guid)((Guid)(T001H7_A361RoleID[0]));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A361RoleID", A361RoleID.ToString());
               RcdFound54 = 1;
            }
         }
         pr_datastore1.close(5);
      }

      protected void move_previous( )
      {
         RcdFound54 = 0;
         /* Using cursor T001H8 */
         pr_datastore1.execute(6, new Object[] {A361RoleID});
         if ( (pr_datastore1.getStatus(6) != 101) )
         {
            while ( (pr_datastore1.getStatus(6) != 101) && ( ( GuidUtil.Compare(T001H8_A361RoleID[0], A361RoleID, 1) > 0 ) ) )
            {
               pr_datastore1.readNext(6);
            }
            if ( (pr_datastore1.getStatus(6) != 101) && ( ( GuidUtil.Compare(T001H8_A361RoleID[0], A361RoleID, 1) < 0 ) ) )
            {
               A361RoleID = (Guid)((Guid)(T001H8_A361RoleID[0]));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A361RoleID", A361RoleID.ToString());
               RcdFound54 = 1;
            }
         }
         pr_datastore1.close(6);
      }

      protected void btn_enter( )
      {
         nKeyPressed = 1;
         GetKey1H54( ) ;
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            /* Insert record */
            GX_FocusControl = edtRoleID_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            Insert1H54( ) ;
            if ( AnyError == 1 )
            {
               GX_FocusControl = "";
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
         }
         else
         {
            if ( RcdFound54 == 1 )
            {
               if ( A361RoleID != Z361RoleID )
               {
                  A361RoleID = (Guid)(Z361RoleID);
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A361RoleID", A361RoleID.ToString());
                  GX_msglist.addItem(context.GetMessage( "GXM_getbeforeupd", ""), "CandidateKeyNotFound", 1, "ROLEID");
                  AnyError = 1;
                  GX_FocusControl = edtRoleID_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
               else if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
               {
                  delete( ) ;
                  AfterTrn( ) ;
                  GX_FocusControl = edtRoleID_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
               else
               {
                  Gx_mode = "UPD";
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                  /* Update record */
                  Update1H54( ) ;
                  GX_FocusControl = edtRoleID_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
            }
            else
            {
               if ( A361RoleID != Z361RoleID )
               {
                  Gx_mode = "INS";
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                  /* Insert record */
                  GX_FocusControl = edtRoleID_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  Insert1H54( ) ;
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
                     GX_msglist.addItem(context.GetMessage( "GXM_recdeleted", ""), 1, "ROLEID");
                     AnyError = 1;
                     GX_FocusControl = edtRoleID_Internalname;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  }
                  else
                  {
                     Gx_mode = "INS";
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                     /* Insert record */
                     GX_FocusControl = edtRoleID_Internalname;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                     Insert1H54( ) ;
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
         if ( A361RoleID != Z361RoleID )
         {
            A361RoleID = (Guid)(Z361RoleID);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A361RoleID", A361RoleID.ToString());
            GX_msglist.addItem(context.GetMessage( "GXM_getbeforedlt", ""), 1, "ROLEID");
            AnyError = 1;
            GX_FocusControl = edtRoleID_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         else
         {
            delete( ) ;
            AfterTrn( ) ;
            GX_FocusControl = edtRoleID_Internalname;
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
         if ( RcdFound54 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_keynfound", ""), "PrimaryKeyNotFound", 1, "ROLEID");
            AnyError = 1;
            GX_FocusControl = edtRoleID_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         GX_FocusControl = edtSYS_RoleTenantCode_Internalname;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_first( )
      {
         nKeyPressed = 2;
         IsConfirmed = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "IsConfirmed", StringUtil.LTrim( StringUtil.Str( (decimal)(IsConfirmed), 4, 0)));
         ScanStart1H54( ) ;
         if ( RcdFound54 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "", true);
         }
         else
         {
            Gx_mode = "UPD";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtSYS_RoleTenantCode_Internalname;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         ScanEnd1H54( ) ;
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
         if ( RcdFound54 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "", true);
         }
         else
         {
            Gx_mode = "UPD";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtSYS_RoleTenantCode_Internalname;
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
         if ( RcdFound54 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "", true);
         }
         else
         {
            Gx_mode = "UPD";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtSYS_RoleTenantCode_Internalname;
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
         ScanStart1H54( ) ;
         if ( RcdFound54 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "", true);
         }
         else
         {
            while ( RcdFound54 != 0 )
            {
               ScanNext1H54( ) ;
            }
            Gx_mode = "UPD";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtSYS_RoleTenantCode_Internalname;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         ScanEnd1H54( ) ;
         getByPrimaryKey( ) ;
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_select( )
      {
         getEqualNoModal( ) ;
      }

      protected void CheckOptimisticConcurrency1H54( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor T001H2 */
            pr_datastore1.execute(0, new Object[] {A361RoleID});
            if ( (pr_datastore1.getStatus(0) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"SYS_ROLE"}), "RecordIsLocked", 1, "");
               AnyError = 1;
               return  ;
            }
            Gx_longc = false;
            if ( (pr_datastore1.getStatus(0) == 101) || ( StringUtil.StrCmp(Z367SYS_RoleTenantCode, T001H2_A367SYS_RoleTenantCode[0]) != 0 ) || ( StringUtil.StrCmp(Z368RoleName, T001H2_A368RoleName[0]) != 0 ) || ( Z408RoleType != T001H2_A408RoleType[0] ) || ( StringUtil.StrCmp(Z410SYS_RoleCreator, T001H2_A410SYS_RoleCreator[0]) != 0 ) || ( Z411SYS_RoleCreateTime != T001H2_A411SYS_RoleCreateTime[0] ) )
            {
               Gx_longc = true;
            }
            if ( Gx_longc || ( StringUtil.StrCmp(Z412SYS_RoleModifier, T001H2_A412SYS_RoleModifier[0]) != 0 ) || ( Z413SYS_RoleModifyTime != T001H2_A413SYS_RoleModifyTime[0] ) || ( Z414SYS_RoleIsDeleted != T001H2_A414SYS_RoleIsDeleted[0] ) )
            {
               if ( StringUtil.StrCmp(Z367SYS_RoleTenantCode, T001H2_A367SYS_RoleTenantCode[0]) != 0 )
               {
                  GXUtil.WriteLog("sys_role:[seudo value changed for attri]"+"SYS_RoleTenantCode");
                  GXUtil.WriteLogRaw("Old: ",Z367SYS_RoleTenantCode);
                  GXUtil.WriteLogRaw("Current: ",T001H2_A367SYS_RoleTenantCode[0]);
               }
               if ( StringUtil.StrCmp(Z368RoleName, T001H2_A368RoleName[0]) != 0 )
               {
                  GXUtil.WriteLog("sys_role:[seudo value changed for attri]"+"RoleName");
                  GXUtil.WriteLogRaw("Old: ",Z368RoleName);
                  GXUtil.WriteLogRaw("Current: ",T001H2_A368RoleName[0]);
               }
               if ( Z408RoleType != T001H2_A408RoleType[0] )
               {
                  GXUtil.WriteLog("sys_role:[seudo value changed for attri]"+"RoleType");
                  GXUtil.WriteLogRaw("Old: ",Z408RoleType);
                  GXUtil.WriteLogRaw("Current: ",T001H2_A408RoleType[0]);
               }
               if ( StringUtil.StrCmp(Z410SYS_RoleCreator, T001H2_A410SYS_RoleCreator[0]) != 0 )
               {
                  GXUtil.WriteLog("sys_role:[seudo value changed for attri]"+"SYS_RoleCreator");
                  GXUtil.WriteLogRaw("Old: ",Z410SYS_RoleCreator);
                  GXUtil.WriteLogRaw("Current: ",T001H2_A410SYS_RoleCreator[0]);
               }
               if ( Z411SYS_RoleCreateTime != T001H2_A411SYS_RoleCreateTime[0] )
               {
                  GXUtil.WriteLog("sys_role:[seudo value changed for attri]"+"SYS_RoleCreateTime");
                  GXUtil.WriteLogRaw("Old: ",Z411SYS_RoleCreateTime);
                  GXUtil.WriteLogRaw("Current: ",T001H2_A411SYS_RoleCreateTime[0]);
               }
               if ( StringUtil.StrCmp(Z412SYS_RoleModifier, T001H2_A412SYS_RoleModifier[0]) != 0 )
               {
                  GXUtil.WriteLog("sys_role:[seudo value changed for attri]"+"SYS_RoleModifier");
                  GXUtil.WriteLogRaw("Old: ",Z412SYS_RoleModifier);
                  GXUtil.WriteLogRaw("Current: ",T001H2_A412SYS_RoleModifier[0]);
               }
               if ( Z413SYS_RoleModifyTime != T001H2_A413SYS_RoleModifyTime[0] )
               {
                  GXUtil.WriteLog("sys_role:[seudo value changed for attri]"+"SYS_RoleModifyTime");
                  GXUtil.WriteLogRaw("Old: ",Z413SYS_RoleModifyTime);
                  GXUtil.WriteLogRaw("Current: ",T001H2_A413SYS_RoleModifyTime[0]);
               }
               if ( Z414SYS_RoleIsDeleted != T001H2_A414SYS_RoleIsDeleted[0] )
               {
                  GXUtil.WriteLog("sys_role:[seudo value changed for attri]"+"SYS_RoleIsDeleted");
                  GXUtil.WriteLogRaw("Old: ",Z414SYS_RoleIsDeleted);
                  GXUtil.WriteLogRaw("Current: ",T001H2_A414SYS_RoleIsDeleted[0]);
               }
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"SYS_ROLE"}), "RecordWasChanged", 1, "");
               AnyError = 1;
               return  ;
            }
         }
      }

      protected void Insert1H54( )
      {
         BeforeValidate1H54( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable1H54( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM1H54( 0) ;
            CheckOptimisticConcurrency1H54( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm1H54( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert1H54( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T001H9 */
                     pr_datastore1.execute(7, new Object[] {n367SYS_RoleTenantCode, A367SYS_RoleTenantCode, A368RoleName, A408RoleType, n409SYS_RoleDescription, A409SYS_RoleDescription, A410SYS_RoleCreator, A411SYS_RoleCreateTime, n412SYS_RoleModifier, A412SYS_RoleModifier, n413SYS_RoleModifyTime, A413SYS_RoleModifyTime, A414SYS_RoleIsDeleted, A361RoleID});
                     pr_datastore1.close(7);
                     dsDataStore1.SmartCacheProvider.SetUpdated("SYS_ROLE") ;
                     if ( (pr_datastore1.getStatus(7) == 1) )
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
                           ResetCaption1H0( ) ;
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
               Load1H54( ) ;
            }
            EndLevel1H54( ) ;
         }
         CloseExtendedTableCursors1H54( ) ;
      }

      protected void Update1H54( )
      {
         BeforeValidate1H54( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable1H54( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency1H54( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm1H54( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate1H54( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T001H10 */
                     pr_datastore1.execute(8, new Object[] {n367SYS_RoleTenantCode, A367SYS_RoleTenantCode, A368RoleName, A408RoleType, n409SYS_RoleDescription, A409SYS_RoleDescription, A410SYS_RoleCreator, A411SYS_RoleCreateTime, n412SYS_RoleModifier, A412SYS_RoleModifier, n413SYS_RoleModifyTime, A413SYS_RoleModifyTime, A414SYS_RoleIsDeleted, A361RoleID});
                     pr_datastore1.close(8);
                     dsDataStore1.SmartCacheProvider.SetUpdated("SYS_ROLE") ;
                     if ( (pr_datastore1.getStatus(8) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"SYS_ROLE"}), "RecordIsLocked", 1, "");
                        AnyError = 1;
                     }
                     DeferredUpdate1H54( ) ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( update) rules */
                        /* End of After( update) rules */
                        if ( AnyError == 0 )
                        {
                           getByPrimaryKey( ) ;
                           GX_msglist.addItem(context.GetMessage( "GXM_sucupdated", ""), "SuccessfullyUpdated", 0, "", true);
                           ResetCaption1H0( ) ;
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
            EndLevel1H54( ) ;
         }
         CloseExtendedTableCursors1H54( ) ;
      }

      protected void DeferredUpdate1H54( )
      {
      }

      protected void delete( )
      {
         Gx_mode = "DLT";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         BeforeValidate1H54( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency1H54( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls1H54( ) ;
            AfterConfirm1H54( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete1H54( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor T001H11 */
                  pr_datastore1.execute(9, new Object[] {A361RoleID});
                  pr_datastore1.close(9);
                  dsDataStore1.SmartCacheProvider.SetUpdated("SYS_ROLE") ;
                  if ( AnyError == 0 )
                  {
                     /* Start of After( delete) rules */
                     /* End of After( delete) rules */
                     if ( AnyError == 0 )
                     {
                        move_next( ) ;
                        if ( RcdFound54 == 0 )
                        {
                           InitAll1H54( ) ;
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
                        ResetCaption1H0( ) ;
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
         sMode54 = Gx_mode;
         Gx_mode = "DLT";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         EndLevel1H54( ) ;
         Gx_mode = sMode54;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
      }

      protected void OnDeleteControls1H54( )
      {
         standaloneModal( ) ;
         /* No delete mode formulas found. */
         if ( AnyError == 0 )
         {
            /* Using cursor T001H12 */
            pr_datastore1.execute(10, new Object[] {A361RoleID});
            if ( (pr_datastore1.getStatus(10) != 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_del", new   object[]  {"SYS_User Role"}), "CannotDeleteReferencedRecord", 1, "");
               AnyError = 1;
            }
            pr_datastore1.close(10);
         }
      }

      protected void EndLevel1H54( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            pr_datastore1.close(0);
         }
         if ( AnyError == 0 )
         {
            BeforeComplete1H54( ) ;
         }
         if ( AnyError == 0 )
         {
            pr_datastore1.close(1);
            context.CommitDataStores("sys_role",pr_default);
            if ( AnyError == 0 )
            {
               ConfirmValues1H0( ) ;
            }
            /* After transaction rules */
            /* Execute 'After Trn' event if defined. */
            trnEnded = 1;
         }
         else
         {
            pr_datastore1.close(1);
            context.RollbackDataStores("sys_role",pr_default);
         }
         IsModified = 0;
         if ( AnyError != 0 )
         {
            context.wjLoc = "";
            context.nUserReturn = 0;
         }
      }

      public void ScanStart1H54( )
      {
         /* Using cursor T001H13 */
         pr_datastore1.execute(11);
         RcdFound54 = 0;
         if ( (pr_datastore1.getStatus(11) != 101) )
         {
            RcdFound54 = 1;
            A361RoleID = (Guid)((Guid)(T001H13_A361RoleID[0]));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A361RoleID", A361RoleID.ToString());
         }
         /* Load Subordinate Levels */
      }

      protected void ScanNext1H54( )
      {
         /* Scan next routine */
         pr_datastore1.readNext(11);
         RcdFound54 = 0;
         if ( (pr_datastore1.getStatus(11) != 101) )
         {
            RcdFound54 = 1;
            A361RoleID = (Guid)((Guid)(T001H13_A361RoleID[0]));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A361RoleID", A361RoleID.ToString());
         }
      }

      protected void ScanEnd1H54( )
      {
         pr_datastore1.close(11);
      }

      protected void AfterConfirm1H54( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert1H54( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate1H54( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete1H54( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete1H54( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate1H54( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes1H54( )
      {
         edtRoleID_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtRoleID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtRoleID_Enabled), 5, 0)), true);
         edtSYS_RoleTenantCode_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtSYS_RoleTenantCode_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtSYS_RoleTenantCode_Enabled), 5, 0)), true);
         edtRoleName_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtRoleName_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtRoleName_Enabled), 5, 0)), true);
         edtRoleType_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtRoleType_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtRoleType_Enabled), 5, 0)), true);
         edtSYS_RoleDescription_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtSYS_RoleDescription_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtSYS_RoleDescription_Enabled), 5, 0)), true);
         edtSYS_RoleCreator_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtSYS_RoleCreator_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtSYS_RoleCreator_Enabled), 5, 0)), true);
         edtSYS_RoleCreateTime_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtSYS_RoleCreateTime_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtSYS_RoleCreateTime_Enabled), 5, 0)), true);
         edtSYS_RoleModifier_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtSYS_RoleModifier_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtSYS_RoleModifier_Enabled), 5, 0)), true);
         edtSYS_RoleModifyTime_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtSYS_RoleModifyTime_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtSYS_RoleModifyTime_Enabled), 5, 0)), true);
         edtSYS_RoleIsDeleted_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtSYS_RoleIsDeleted_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtSYS_RoleIsDeleted_Enabled), 5, 0)), true);
      }

      protected void send_integrity_lvl_hashes1H54( )
      {
      }

      protected void assign_properties_default( )
      {
      }

      protected void ConfirmValues1H0( )
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
         context.AddJavascriptSource("gxcfg.js", "?202022815906", false);
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" autocomplete=\"off\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("sys_role.aspx") +"\">") ;
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
         GxWebStd.gx_hidden_field( context, "Z361RoleID", Z361RoleID.ToString());
         GxWebStd.gx_hidden_field( context, "Z367SYS_RoleTenantCode", Z367SYS_RoleTenantCode);
         GxWebStd.gx_hidden_field( context, "Z368RoleName", Z368RoleName);
         GxWebStd.gx_hidden_field( context, "Z408RoleType", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z408RoleType), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "Z410SYS_RoleCreator", Z410SYS_RoleCreator);
         GxWebStd.gx_hidden_field( context, "Z411SYS_RoleCreateTime", context.localUtil.TToC( Z411SYS_RoleCreateTime, 10, 8, 0, 0, "/", ":", " "));
         GxWebStd.gx_hidden_field( context, "Z412SYS_RoleModifier", Z412SYS_RoleModifier);
         GxWebStd.gx_hidden_field( context, "Z413SYS_RoleModifyTime", context.localUtil.TToC( Z413SYS_RoleModifyTime, 10, 8, 0, 0, "/", ":", " "));
         GxWebStd.gx_hidden_field( context, "Z414SYS_RoleIsDeleted", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z414SYS_RoleIsDeleted), 1, 0, ".", "")));
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
         return formatLink("sys_role.aspx")  ;
      }

      public override String GetPgmname( )
      {
         return "SYS_Role" ;
      }

      public override String GetPgmdesc( )
      {
         return "SYS_Role" ;
      }

      protected void InitializeNonKey1H54( )
      {
         A367SYS_RoleTenantCode = "";
         n367SYS_RoleTenantCode = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A367SYS_RoleTenantCode", A367SYS_RoleTenantCode);
         n367SYS_RoleTenantCode = (String.IsNullOrEmpty(StringUtil.RTrim( A367SYS_RoleTenantCode)) ? true : false);
         A368RoleName = "";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A368RoleName", A368RoleName);
         A408RoleType = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A408RoleType", StringUtil.LTrim( StringUtil.Str( (decimal)(A408RoleType), 9, 0)));
         A409SYS_RoleDescription = "";
         n409SYS_RoleDescription = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A409SYS_RoleDescription", A409SYS_RoleDescription);
         n409SYS_RoleDescription = (String.IsNullOrEmpty(StringUtil.RTrim( A409SYS_RoleDescription)) ? true : false);
         A410SYS_RoleCreator = "";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A410SYS_RoleCreator", A410SYS_RoleCreator);
         A411SYS_RoleCreateTime = (DateTime)(DateTime.MinValue);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A411SYS_RoleCreateTime", context.localUtil.TToC( A411SYS_RoleCreateTime, 10, 8, 0, 0, "/", ":", " "));
         A412SYS_RoleModifier = "";
         n412SYS_RoleModifier = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A412SYS_RoleModifier", A412SYS_RoleModifier);
         n412SYS_RoleModifier = (String.IsNullOrEmpty(StringUtil.RTrim( A412SYS_RoleModifier)) ? true : false);
         A413SYS_RoleModifyTime = (DateTime)(DateTime.MinValue);
         n413SYS_RoleModifyTime = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A413SYS_RoleModifyTime", context.localUtil.TToC( A413SYS_RoleModifyTime, 10, 8, 0, 0, "/", ":", " "));
         n413SYS_RoleModifyTime = ((DateTime.MinValue==A413SYS_RoleModifyTime) ? true : false);
         A414SYS_RoleIsDeleted = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A414SYS_RoleIsDeleted", StringUtil.Str( (decimal)(A414SYS_RoleIsDeleted), 1, 0));
         Z367SYS_RoleTenantCode = "";
         Z368RoleName = "";
         Z408RoleType = 0;
         Z410SYS_RoleCreator = "";
         Z411SYS_RoleCreateTime = (DateTime)(DateTime.MinValue);
         Z412SYS_RoleModifier = "";
         Z413SYS_RoleModifyTime = (DateTime)(DateTime.MinValue);
         Z414SYS_RoleIsDeleted = 0;
      }

      protected void InitAll1H54( )
      {
         A361RoleID = (Guid)(Guid.NewGuid( ));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A361RoleID", A361RoleID.ToString());
         InitializeNonKey1H54( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?2020228159012", true);
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
         context.AddJavascriptSource("sys_role.js", "?2020228159013", false);
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
         edtRoleID_Internalname = "ROLEID";
         edtSYS_RoleTenantCode_Internalname = "SYS_ROLETENANTCODE";
         edtRoleName_Internalname = "ROLENAME";
         edtRoleType_Internalname = "ROLETYPE";
         edtSYS_RoleDescription_Internalname = "SYS_ROLEDESCRIPTION";
         edtSYS_RoleCreator_Internalname = "SYS_ROLECREATOR";
         edtSYS_RoleCreateTime_Internalname = "SYS_ROLECREATETIME";
         edtSYS_RoleModifier_Internalname = "SYS_ROLEMODIFIER";
         edtSYS_RoleModifyTime_Internalname = "SYS_ROLEMODIFYTIME";
         edtSYS_RoleIsDeleted_Internalname = "SYS_ROLEISDELETED";
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
         Form.Caption = "SYS_Role";
         bttBtn_delete_Enabled = 1;
         bttBtn_delete_Visible = 1;
         bttBtn_cancel_Visible = 1;
         bttBtn_enter_Enabled = 1;
         bttBtn_enter_Visible = 1;
         edtSYS_RoleIsDeleted_Jsonclick = "";
         edtSYS_RoleIsDeleted_Enabled = 1;
         edtSYS_RoleModifyTime_Jsonclick = "";
         edtSYS_RoleModifyTime_Enabled = 1;
         edtSYS_RoleModifier_Jsonclick = "";
         edtSYS_RoleModifier_Enabled = 1;
         edtSYS_RoleCreateTime_Jsonclick = "";
         edtSYS_RoleCreateTime_Enabled = 1;
         edtSYS_RoleCreator_Jsonclick = "";
         edtSYS_RoleCreator_Enabled = 1;
         edtSYS_RoleDescription_Enabled = 1;
         edtRoleType_Jsonclick = "";
         edtRoleType_Enabled = 1;
         edtRoleName_Jsonclick = "";
         edtRoleName_Enabled = 1;
         edtSYS_RoleTenantCode_Jsonclick = "";
         edtSYS_RoleTenantCode_Enabled = 1;
         edtRoleID_Jsonclick = "";
         edtRoleID_Enabled = 1;
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
         GX_FocusControl = edtSYS_RoleTenantCode_Internalname;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         standaloneNotModal( ) ;
         standaloneModal( ) ;
         /* End function AfterKeyLoadScreen */
      }

      public void Valid_Roleid( Guid GX_Parm1 ,
                                String GX_Parm2 ,
                                String GX_Parm3 ,
                                int GX_Parm4 ,
                                String GX_Parm5 ,
                                String GX_Parm6 ,
                                DateTime GX_Parm7 ,
                                String GX_Parm8 ,
                                DateTime GX_Parm9 ,
                                short GX_Parm10 )
      {
         A361RoleID = (Guid)(GX_Parm1);
         A367SYS_RoleTenantCode = GX_Parm2;
         n367SYS_RoleTenantCode = false;
         A368RoleName = GX_Parm3;
         A408RoleType = GX_Parm4;
         A409SYS_RoleDescription = GX_Parm5;
         n409SYS_RoleDescription = false;
         A410SYS_RoleCreator = GX_Parm6;
         A411SYS_RoleCreateTime = GX_Parm7;
         A412SYS_RoleModifier = GX_Parm8;
         n412SYS_RoleModifier = false;
         A413SYS_RoleModifyTime = GX_Parm9;
         n413SYS_RoleModifyTime = false;
         A414SYS_RoleIsDeleted = GX_Parm10;
         context.wbHandled = 1;
         AfterKeyLoadScreen( ) ;
         Draw( ) ;
         send_integrity_footer_hashes( ) ;
         dynload_actions( ) ;
         if ( AnyError == 1 )
         {
         }
         isValidOutput.Add(A367SYS_RoleTenantCode);
         isValidOutput.Add(A368RoleName);
         isValidOutput.Add(StringUtil.LTrim( StringUtil.NToC( (decimal)(A408RoleType), 9, 0, ".", "")));
         isValidOutput.Add(A409SYS_RoleDescription);
         isValidOutput.Add(A410SYS_RoleCreator);
         isValidOutput.Add(context.localUtil.TToC( A411SYS_RoleCreateTime, 10, 8, 0, 0, "/", ":", " "));
         isValidOutput.Add(A412SYS_RoleModifier);
         isValidOutput.Add(context.localUtil.TToC( A413SYS_RoleModifyTime, 10, 8, 0, 0, "/", ":", " "));
         isValidOutput.Add(StringUtil.LTrim( StringUtil.NToC( (decimal)(A414SYS_RoleIsDeleted), 1, 0, ".", "")));
         isValidOutput.Add(StringUtil.RTrim( Gx_mode));
         isValidOutput.Add(Z361RoleID.ToString());
         isValidOutput.Add(Z367SYS_RoleTenantCode);
         isValidOutput.Add(Z368RoleName);
         isValidOutput.Add(StringUtil.LTrim( StringUtil.NToC( (decimal)(Z408RoleType), 9, 0, ".", "")));
         isValidOutput.Add(Z409SYS_RoleDescription);
         isValidOutput.Add(Z410SYS_RoleCreator);
         isValidOutput.Add(context.localUtil.TToC( Z411SYS_RoleCreateTime, 10, 8, 0, 0, "/", ":", " "));
         isValidOutput.Add(Z412SYS_RoleModifier);
         isValidOutput.Add(context.localUtil.TToC( Z413SYS_RoleModifyTime, 10, 8, 0, 0, "/", ":", " "));
         isValidOutput.Add(StringUtil.LTrim( StringUtil.NToC( (decimal)(Z414SYS_RoleIsDeleted), 1, 0, ".", "")));
         isValidOutput.Add(bttBtn_delete_Enabled);
         isValidOutput.Add(bttBtn_enter_Enabled);
         isValidOutput.Add(context.GX_msglist.ToJavascriptSource());
         isValidOutput.Add(context.httpAjaxContext.ajax_rsp_get_hiddens( ));
         context.GX_webresponse.AddString(isValidOutput.ToJSonString());
         wbTemp = context.ResponseContentType( "application/json");
      }

      public void Valid_Rolename( String GX_Parm1 ,
                                  String GX_Parm2 ,
                                  Guid GX_Parm3 )
      {
         A367SYS_RoleTenantCode = GX_Parm1;
         n367SYS_RoleTenantCode = false;
         A368RoleName = GX_Parm2;
         A361RoleID = (Guid)(GX_Parm3);
         /* Using cursor T001H14 */
         pr_datastore1.execute(12, new Object[] {n367SYS_RoleTenantCode, A367SYS_RoleTenantCode, A368RoleName, A361RoleID});
         if ( (pr_datastore1.getStatus(12) != 101) )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_1004", new   object[]  {"SYS_Role Tenant Code"+","+"Role Name"}), 1, "SYS_ROLETENANTCODE");
            AnyError = 1;
            GX_FocusControl = edtSYS_RoleTenantCode_Internalname;
         }
         pr_datastore1.close(12);
         dynload_actions( ) ;
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
         Z361RoleID = (Guid)(Guid.Empty);
         Z367SYS_RoleTenantCode = "";
         Z368RoleName = "";
         Z410SYS_RoleCreator = "";
         Z411SYS_RoleCreateTime = (DateTime)(DateTime.MinValue);
         Z412SYS_RoleModifier = "";
         Z413SYS_RoleModifyTime = (DateTime)(DateTime.MinValue);
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
         A361RoleID = (Guid)(Guid.Empty);
         A367SYS_RoleTenantCode = "";
         A368RoleName = "";
         A409SYS_RoleDescription = "";
         A410SYS_RoleCreator = "";
         A411SYS_RoleCreateTime = (DateTime)(DateTime.MinValue);
         A412SYS_RoleModifier = "";
         A413SYS_RoleModifyTime = (DateTime)(DateTime.MinValue);
         bttBtn_enter_Jsonclick = "";
         bttBtn_cancel_Jsonclick = "";
         bttBtn_delete_Jsonclick = "";
         Gx_mode = "";
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         Z409SYS_RoleDescription = "";
         T001H4_A361RoleID = new Guid[] {Guid.Empty} ;
         T001H4_A367SYS_RoleTenantCode = new String[] {""} ;
         T001H4_n367SYS_RoleTenantCode = new bool[] {false} ;
         T001H4_A368RoleName = new String[] {""} ;
         T001H4_A408RoleType = new int[1] ;
         T001H4_A409SYS_RoleDescription = new String[] {""} ;
         T001H4_n409SYS_RoleDescription = new bool[] {false} ;
         T001H4_A410SYS_RoleCreator = new String[] {""} ;
         T001H4_A411SYS_RoleCreateTime = new DateTime[] {DateTime.MinValue} ;
         T001H4_A412SYS_RoleModifier = new String[] {""} ;
         T001H4_n412SYS_RoleModifier = new bool[] {false} ;
         T001H4_A413SYS_RoleModifyTime = new DateTime[] {DateTime.MinValue} ;
         T001H4_n413SYS_RoleModifyTime = new bool[] {false} ;
         T001H4_A414SYS_RoleIsDeleted = new short[1] ;
         T001H5_A367SYS_RoleTenantCode = new String[] {""} ;
         T001H5_n367SYS_RoleTenantCode = new bool[] {false} ;
         T001H6_A361RoleID = new Guid[] {Guid.Empty} ;
         T001H3_A361RoleID = new Guid[] {Guid.Empty} ;
         T001H3_A367SYS_RoleTenantCode = new String[] {""} ;
         T001H3_n367SYS_RoleTenantCode = new bool[] {false} ;
         T001H3_A368RoleName = new String[] {""} ;
         T001H3_A408RoleType = new int[1] ;
         T001H3_A409SYS_RoleDescription = new String[] {""} ;
         T001H3_n409SYS_RoleDescription = new bool[] {false} ;
         T001H3_A410SYS_RoleCreator = new String[] {""} ;
         T001H3_A411SYS_RoleCreateTime = new DateTime[] {DateTime.MinValue} ;
         T001H3_A412SYS_RoleModifier = new String[] {""} ;
         T001H3_n412SYS_RoleModifier = new bool[] {false} ;
         T001H3_A413SYS_RoleModifyTime = new DateTime[] {DateTime.MinValue} ;
         T001H3_n413SYS_RoleModifyTime = new bool[] {false} ;
         T001H3_A414SYS_RoleIsDeleted = new short[1] ;
         sMode54 = "";
         T001H7_A361RoleID = new Guid[] {Guid.Empty} ;
         T001H8_A361RoleID = new Guid[] {Guid.Empty} ;
         T001H2_A361RoleID = new Guid[] {Guid.Empty} ;
         T001H2_A367SYS_RoleTenantCode = new String[] {""} ;
         T001H2_n367SYS_RoleTenantCode = new bool[] {false} ;
         T001H2_A368RoleName = new String[] {""} ;
         T001H2_A408RoleType = new int[1] ;
         T001H2_A409SYS_RoleDescription = new String[] {""} ;
         T001H2_n409SYS_RoleDescription = new bool[] {false} ;
         T001H2_A410SYS_RoleCreator = new String[] {""} ;
         T001H2_A411SYS_RoleCreateTime = new DateTime[] {DateTime.MinValue} ;
         T001H2_A412SYS_RoleModifier = new String[] {""} ;
         T001H2_n412SYS_RoleModifier = new bool[] {false} ;
         T001H2_A413SYS_RoleModifyTime = new DateTime[] {DateTime.MinValue} ;
         T001H2_n413SYS_RoleModifyTime = new bool[] {false} ;
         T001H2_A414SYS_RoleIsDeleted = new short[1] ;
         T001H12_A359UserID = new Guid[] {Guid.Empty} ;
         T001H12_A361RoleID = new Guid[] {Guid.Empty} ;
         T001H13_A361RoleID = new Guid[] {Guid.Empty} ;
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         isValidOutput = new GxUnknownObjectCollection();
         T001H14_A367SYS_RoleTenantCode = new String[] {""} ;
         T001H14_n367SYS_RoleTenantCode = new bool[] {false} ;
         pr_datastore1 = new DataStoreProvider(context, new GeneXus.Programs.sys_role__datastore1(),
            new Object[][] {
                new Object[] {
               T001H2_A361RoleID, T001H2_A367SYS_RoleTenantCode, T001H2_n367SYS_RoleTenantCode, T001H2_A368RoleName, T001H2_A408RoleType, T001H2_A409SYS_RoleDescription, T001H2_n409SYS_RoleDescription, T001H2_A410SYS_RoleCreator, T001H2_A411SYS_RoleCreateTime, T001H2_A412SYS_RoleModifier,
               T001H2_n412SYS_RoleModifier, T001H2_A413SYS_RoleModifyTime, T001H2_n413SYS_RoleModifyTime, T001H2_A414SYS_RoleIsDeleted
               }
               , new Object[] {
               T001H3_A361RoleID, T001H3_A367SYS_RoleTenantCode, T001H3_n367SYS_RoleTenantCode, T001H3_A368RoleName, T001H3_A408RoleType, T001H3_A409SYS_RoleDescription, T001H3_n409SYS_RoleDescription, T001H3_A410SYS_RoleCreator, T001H3_A411SYS_RoleCreateTime, T001H3_A412SYS_RoleModifier,
               T001H3_n412SYS_RoleModifier, T001H3_A413SYS_RoleModifyTime, T001H3_n413SYS_RoleModifyTime, T001H3_A414SYS_RoleIsDeleted
               }
               , new Object[] {
               T001H4_A361RoleID, T001H4_A367SYS_RoleTenantCode, T001H4_n367SYS_RoleTenantCode, T001H4_A368RoleName, T001H4_A408RoleType, T001H4_A409SYS_RoleDescription, T001H4_n409SYS_RoleDescription, T001H4_A410SYS_RoleCreator, T001H4_A411SYS_RoleCreateTime, T001H4_A412SYS_RoleModifier,
               T001H4_n412SYS_RoleModifier, T001H4_A413SYS_RoleModifyTime, T001H4_n413SYS_RoleModifyTime, T001H4_A414SYS_RoleIsDeleted
               }
               , new Object[] {
               T001H5_A367SYS_RoleTenantCode, T001H5_n367SYS_RoleTenantCode
               }
               , new Object[] {
               T001H6_A361RoleID
               }
               , new Object[] {
               T001H7_A361RoleID
               }
               , new Object[] {
               T001H8_A361RoleID
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               T001H12_A359UserID, T001H12_A361RoleID
               }
               , new Object[] {
               T001H13_A361RoleID
               }
               , new Object[] {
               T001H14_A367SYS_RoleTenantCode, T001H14_n367SYS_RoleTenantCode
               }
            }
         );
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.sys_role__default(),
            new Object[][] {
            }
         );
         Z361RoleID = (Guid)(Guid.NewGuid( ));
         A361RoleID = (Guid)(Guid.NewGuid( ));
      }

      private short Z414SYS_RoleIsDeleted ;
      private short GxWebError ;
      private short gxcookieaux ;
      private short IsConfirmed ;
      private short IsModified ;
      private short AnyError ;
      private short nKeyPressed ;
      private short initialized ;
      private short A414SYS_RoleIsDeleted ;
      private short Gx_BScreen ;
      private short GX_JID ;
      private short RcdFound54 ;
      private short gxajaxcallmode ;
      private short wbTemp ;
      private int Z408RoleType ;
      private int trnEnded ;
      private int bttBtn_first_Visible ;
      private int bttBtn_previous_Visible ;
      private int bttBtn_next_Visible ;
      private int bttBtn_last_Visible ;
      private int bttBtn_select_Visible ;
      private int edtRoleID_Enabled ;
      private int edtSYS_RoleTenantCode_Enabled ;
      private int edtRoleName_Enabled ;
      private int A408RoleType ;
      private int edtRoleType_Enabled ;
      private int edtSYS_RoleDescription_Enabled ;
      private int edtSYS_RoleCreator_Enabled ;
      private int edtSYS_RoleCreateTime_Enabled ;
      private int edtSYS_RoleModifier_Enabled ;
      private int edtSYS_RoleModifyTime_Enabled ;
      private int edtSYS_RoleIsDeleted_Enabled ;
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
      private String edtRoleID_Internalname ;
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
      private String edtRoleID_Jsonclick ;
      private String edtSYS_RoleTenantCode_Internalname ;
      private String edtSYS_RoleTenantCode_Jsonclick ;
      private String edtRoleName_Internalname ;
      private String edtRoleName_Jsonclick ;
      private String edtRoleType_Internalname ;
      private String edtRoleType_Jsonclick ;
      private String edtSYS_RoleDescription_Internalname ;
      private String edtSYS_RoleCreator_Internalname ;
      private String edtSYS_RoleCreator_Jsonclick ;
      private String edtSYS_RoleCreateTime_Internalname ;
      private String edtSYS_RoleCreateTime_Jsonclick ;
      private String edtSYS_RoleModifier_Internalname ;
      private String edtSYS_RoleModifier_Jsonclick ;
      private String edtSYS_RoleModifyTime_Internalname ;
      private String edtSYS_RoleModifyTime_Jsonclick ;
      private String edtSYS_RoleIsDeleted_Internalname ;
      private String edtSYS_RoleIsDeleted_Jsonclick ;
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
      private String sMode54 ;
      private String sDynURL ;
      private String FormProcess ;
      private String bodyStyle ;
      private DateTime Z411SYS_RoleCreateTime ;
      private DateTime Z413SYS_RoleModifyTime ;
      private DateTime A411SYS_RoleCreateTime ;
      private DateTime A413SYS_RoleModifyTime ;
      private bool entryPointCalled ;
      private bool toggleJsOutput ;
      private bool wbErr ;
      private bool n367SYS_RoleTenantCode ;
      private bool n409SYS_RoleDescription ;
      private bool n412SYS_RoleModifier ;
      private bool n413SYS_RoleModifyTime ;
      private bool Gx_longc ;
      private String A409SYS_RoleDescription ;
      private String Z409SYS_RoleDescription ;
      private String Z367SYS_RoleTenantCode ;
      private String Z368RoleName ;
      private String Z410SYS_RoleCreator ;
      private String Z412SYS_RoleModifier ;
      private String A367SYS_RoleTenantCode ;
      private String A368RoleName ;
      private String A410SYS_RoleCreator ;
      private String A412SYS_RoleModifier ;
      private Guid Z361RoleID ;
      private Guid A361RoleID ;
      private GxUnknownObjectCollection isValidOutput ;
      private IGxDataStore dsDataStore1 ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_datastore1 ;
      private Guid[] T001H4_A361RoleID ;
      private String[] T001H4_A367SYS_RoleTenantCode ;
      private bool[] T001H4_n367SYS_RoleTenantCode ;
      private String[] T001H4_A368RoleName ;
      private int[] T001H4_A408RoleType ;
      private String[] T001H4_A409SYS_RoleDescription ;
      private bool[] T001H4_n409SYS_RoleDescription ;
      private String[] T001H4_A410SYS_RoleCreator ;
      private DateTime[] T001H4_A411SYS_RoleCreateTime ;
      private String[] T001H4_A412SYS_RoleModifier ;
      private bool[] T001H4_n412SYS_RoleModifier ;
      private DateTime[] T001H4_A413SYS_RoleModifyTime ;
      private bool[] T001H4_n413SYS_RoleModifyTime ;
      private short[] T001H4_A414SYS_RoleIsDeleted ;
      private String[] T001H5_A367SYS_RoleTenantCode ;
      private bool[] T001H5_n367SYS_RoleTenantCode ;
      private Guid[] T001H6_A361RoleID ;
      private Guid[] T001H3_A361RoleID ;
      private String[] T001H3_A367SYS_RoleTenantCode ;
      private bool[] T001H3_n367SYS_RoleTenantCode ;
      private String[] T001H3_A368RoleName ;
      private int[] T001H3_A408RoleType ;
      private String[] T001H3_A409SYS_RoleDescription ;
      private bool[] T001H3_n409SYS_RoleDescription ;
      private String[] T001H3_A410SYS_RoleCreator ;
      private DateTime[] T001H3_A411SYS_RoleCreateTime ;
      private String[] T001H3_A412SYS_RoleModifier ;
      private bool[] T001H3_n412SYS_RoleModifier ;
      private DateTime[] T001H3_A413SYS_RoleModifyTime ;
      private bool[] T001H3_n413SYS_RoleModifyTime ;
      private short[] T001H3_A414SYS_RoleIsDeleted ;
      private Guid[] T001H7_A361RoleID ;
      private Guid[] T001H8_A361RoleID ;
      private Guid[] T001H2_A361RoleID ;
      private String[] T001H2_A367SYS_RoleTenantCode ;
      private bool[] T001H2_n367SYS_RoleTenantCode ;
      private String[] T001H2_A368RoleName ;
      private int[] T001H2_A408RoleType ;
      private String[] T001H2_A409SYS_RoleDescription ;
      private bool[] T001H2_n409SYS_RoleDescription ;
      private String[] T001H2_A410SYS_RoleCreator ;
      private DateTime[] T001H2_A411SYS_RoleCreateTime ;
      private String[] T001H2_A412SYS_RoleModifier ;
      private bool[] T001H2_n412SYS_RoleModifier ;
      private DateTime[] T001H2_A413SYS_RoleModifyTime ;
      private bool[] T001H2_n413SYS_RoleModifyTime ;
      private short[] T001H2_A414SYS_RoleIsDeleted ;
      private Guid[] T001H12_A359UserID ;
      private Guid[] T001H12_A361RoleID ;
      private IDataStoreProvider pr_default ;
      private Guid[] T001H13_A361RoleID ;
      private String[] T001H14_A367SYS_RoleTenantCode ;
      private bool[] T001H14_n367SYS_RoleTenantCode ;
      private GXWebForm Form ;
   }

   public class sys_role__datastore1 : DataStoreHelperBase, IDataStoreHelper
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
         ,new UpdateCursor(def[9])
         ,new ForEachCursor(def[10])
         ,new ForEachCursor(def[11])
         ,new ForEachCursor(def[12])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmT001H4 ;
          prmT001H4 = new Object[] {
          new Object[] {"@RoleID",SqlDbType.UniqueIdentifier,16,0}
          } ;
          Object[] prmT001H5 ;
          prmT001H5 = new Object[] {
          new Object[] {"@SYS_RoleTenantCode",SqlDbType.NVarChar,20,0} ,
          new Object[] {"@RoleName",SqlDbType.NVarChar,50,0} ,
          new Object[] {"@RoleID",SqlDbType.UniqueIdentifier,16,0}
          } ;
          Object[] prmT001H6 ;
          prmT001H6 = new Object[] {
          new Object[] {"@RoleID",SqlDbType.UniqueIdentifier,16,0}
          } ;
          Object[] prmT001H3 ;
          prmT001H3 = new Object[] {
          new Object[] {"@RoleID",SqlDbType.UniqueIdentifier,16,0}
          } ;
          Object[] prmT001H7 ;
          prmT001H7 = new Object[] {
          new Object[] {"@RoleID",SqlDbType.UniqueIdentifier,16,0}
          } ;
          Object[] prmT001H8 ;
          prmT001H8 = new Object[] {
          new Object[] {"@RoleID",SqlDbType.UniqueIdentifier,16,0}
          } ;
          Object[] prmT001H2 ;
          prmT001H2 = new Object[] {
          new Object[] {"@RoleID",SqlDbType.UniqueIdentifier,16,0}
          } ;
          Object[] prmT001H9 ;
          prmT001H9 = new Object[] {
          new Object[] {"@SYS_RoleTenantCode",SqlDbType.NVarChar,20,0} ,
          new Object[] {"@RoleName",SqlDbType.NVarChar,50,0} ,
          new Object[] {"@RoleType",SqlDbType.Int,9,0} ,
          new Object[] {"@SYS_RoleDescription",SqlDbType.NVarChar,2048,0} ,
          new Object[] {"@SYS_RoleCreator",SqlDbType.NVarChar,50,0} ,
          new Object[] {"@SYS_RoleCreateTime",SqlDbType.DateTime,10,8} ,
          new Object[] {"@SYS_RoleModifier",SqlDbType.NVarChar,50,0} ,
          new Object[] {"@SYS_RoleModifyTime",SqlDbType.DateTime,10,8} ,
          new Object[] {"@SYS_RoleIsDeleted",SqlDbType.SmallInt,1,0} ,
          new Object[] {"@RoleID",SqlDbType.UniqueIdentifier,16,0}
          } ;
          Object[] prmT001H10 ;
          prmT001H10 = new Object[] {
          new Object[] {"@SYS_RoleTenantCode",SqlDbType.NVarChar,20,0} ,
          new Object[] {"@RoleName",SqlDbType.NVarChar,50,0} ,
          new Object[] {"@RoleType",SqlDbType.Int,9,0} ,
          new Object[] {"@SYS_RoleDescription",SqlDbType.NVarChar,2048,0} ,
          new Object[] {"@SYS_RoleCreator",SqlDbType.NVarChar,50,0} ,
          new Object[] {"@SYS_RoleCreateTime",SqlDbType.DateTime,10,8} ,
          new Object[] {"@SYS_RoleModifier",SqlDbType.NVarChar,50,0} ,
          new Object[] {"@SYS_RoleModifyTime",SqlDbType.DateTime,10,8} ,
          new Object[] {"@SYS_RoleIsDeleted",SqlDbType.SmallInt,1,0} ,
          new Object[] {"@RoleID",SqlDbType.UniqueIdentifier,16,0}
          } ;
          Object[] prmT001H11 ;
          prmT001H11 = new Object[] {
          new Object[] {"@RoleID",SqlDbType.UniqueIdentifier,16,0}
          } ;
          Object[] prmT001H12 ;
          prmT001H12 = new Object[] {
          new Object[] {"@RoleID",SqlDbType.UniqueIdentifier,16,0}
          } ;
          Object[] prmT001H13 ;
          prmT001H13 = new Object[] {
          } ;
          Object[] prmT001H14 ;
          prmT001H14 = new Object[] {
          new Object[] {"@SYS_RoleTenantCode",SqlDbType.NVarChar,20,0} ,
          new Object[] {"@RoleName",SqlDbType.NVarChar,50,0} ,
          new Object[] {"@RoleID",SqlDbType.UniqueIdentifier,16,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("T001H2", "SELECT [RoleID], [SYS_RoleTenantCode], [RoleName], [RoleType], [SYS_RoleDescription], [SYS_RoleCreator], [SYS_RoleCreateTime], [SYS_RoleModifier], [SYS_RoleModifyTime], [SYS_RoleIsDeleted] FROM dbo.[SYS_Role] WITH (UPDLOCK) WHERE [RoleID] = @RoleID ",true, GxErrorMask.GX_NOMASK, false, this,prmT001H2,1,0,true,false )
             ,new CursorDef("T001H3", "SELECT [RoleID], [SYS_RoleTenantCode], [RoleName], [RoleType], [SYS_RoleDescription], [SYS_RoleCreator], [SYS_RoleCreateTime], [SYS_RoleModifier], [SYS_RoleModifyTime], [SYS_RoleIsDeleted] FROM dbo.[SYS_Role] WITH (NOLOCK) WHERE [RoleID] = @RoleID ",true, GxErrorMask.GX_NOMASK, false, this,prmT001H3,1,0,true,false )
             ,new CursorDef("T001H4", "SELECT TM1.[RoleID], TM1.[SYS_RoleTenantCode], TM1.[RoleName], TM1.[RoleType], TM1.[SYS_RoleDescription], TM1.[SYS_RoleCreator], TM1.[SYS_RoleCreateTime], TM1.[SYS_RoleModifier], TM1.[SYS_RoleModifyTime], TM1.[SYS_RoleIsDeleted] FROM dbo.[SYS_Role] TM1 WITH (NOLOCK) WHERE TM1.[RoleID] = @RoleID ORDER BY TM1.[RoleID]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT001H4,100,0,true,false )
             ,new CursorDef("T001H5", "SELECT [SYS_RoleTenantCode] FROM dbo.[SYS_Role] WITH (NOLOCK) WHERE ([SYS_RoleTenantCode] = @SYS_RoleTenantCode AND [RoleName] = @RoleName) AND (Not ( [RoleID] = @RoleID)) ",true, GxErrorMask.GX_NOMASK, false, this,prmT001H5,1,0,true,false )
             ,new CursorDef("T001H6", "SELECT [RoleID] FROM dbo.[SYS_Role] WITH (NOLOCK) WHERE [RoleID] = @RoleID  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT001H6,1,0,true,false )
             ,new CursorDef("T001H7", "SELECT TOP 1 [RoleID] FROM dbo.[SYS_Role] WITH (NOLOCK) WHERE ( [RoleID] > @RoleID) ORDER BY [RoleID]  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT001H7,1,0,true,true )
             ,new CursorDef("T001H8", "SELECT TOP 1 [RoleID] FROM dbo.[SYS_Role] WITH (NOLOCK) WHERE ( [RoleID] < @RoleID) ORDER BY [RoleID] DESC  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT001H8,1,0,true,true )
             ,new CursorDef("T001H9", "INSERT INTO dbo.[SYS_Role]([SYS_RoleTenantCode], [RoleName], [RoleType], [SYS_RoleDescription], [SYS_RoleCreator], [SYS_RoleCreateTime], [SYS_RoleModifier], [SYS_RoleModifyTime], [SYS_RoleIsDeleted], [RoleID]) VALUES(@SYS_RoleTenantCode, @RoleName, @RoleType, @SYS_RoleDescription, @SYS_RoleCreator, @SYS_RoleCreateTime, @SYS_RoleModifier, @SYS_RoleModifyTime, @SYS_RoleIsDeleted, @RoleID)", GxErrorMask.GX_NOMASK,prmT001H9)
             ,new CursorDef("T001H10", "UPDATE dbo.[SYS_Role] SET [SYS_RoleTenantCode]=@SYS_RoleTenantCode, [RoleName]=@RoleName, [RoleType]=@RoleType, [SYS_RoleDescription]=@SYS_RoleDescription, [SYS_RoleCreator]=@SYS_RoleCreator, [SYS_RoleCreateTime]=@SYS_RoleCreateTime, [SYS_RoleModifier]=@SYS_RoleModifier, [SYS_RoleModifyTime]=@SYS_RoleModifyTime, [SYS_RoleIsDeleted]=@SYS_RoleIsDeleted  WHERE [RoleID] = @RoleID", GxErrorMask.GX_NOMASK,prmT001H10)
             ,new CursorDef("T001H11", "DELETE FROM dbo.[SYS_Role]  WHERE [RoleID] = @RoleID", GxErrorMask.GX_NOMASK,prmT001H11)
             ,new CursorDef("T001H12", "SELECT TOP 1 [UserID], [RoleID] FROM dbo.[SYS_UserRole] WITH (NOLOCK) WHERE [RoleID] = @RoleID ",true, GxErrorMask.GX_NOMASK, false, this,prmT001H12,1,0,true,true )
             ,new CursorDef("T001H13", "SELECT [RoleID] FROM dbo.[SYS_Role] WITH (NOLOCK) ORDER BY [RoleID]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT001H13,100,0,true,false )
             ,new CursorDef("T001H14", "SELECT [SYS_RoleTenantCode] FROM dbo.[SYS_Role] WITH (NOLOCK) WHERE ([SYS_RoleTenantCode] = @SYS_RoleTenantCode AND [RoleName] = @RoleName) AND (Not ( [RoleID] = @RoleID)) ",true, GxErrorMask.GX_NOMASK, false, this,prmT001H14,1,0,true,false )
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
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
                ((String[]) buf[3])[0] = rslt.getVarchar(3) ;
                ((int[]) buf[4])[0] = rslt.getInt(4) ;
                ((String[]) buf[5])[0] = rslt.getLongVarchar(5) ;
                ((bool[]) buf[6])[0] = rslt.wasNull(5);
                ((String[]) buf[7])[0] = rslt.getVarchar(6) ;
                ((DateTime[]) buf[8])[0] = rslt.getGXDateTime(7) ;
                ((String[]) buf[9])[0] = rslt.getVarchar(8) ;
                ((bool[]) buf[10])[0] = rslt.wasNull(8);
                ((DateTime[]) buf[11])[0] = rslt.getGXDateTime(9) ;
                ((bool[]) buf[12])[0] = rslt.wasNull(9);
                ((short[]) buf[13])[0] = rslt.getShort(10) ;
                return;
             case 1 :
                ((Guid[]) buf[0])[0] = rslt.getGuid(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
                ((String[]) buf[3])[0] = rslt.getVarchar(3) ;
                ((int[]) buf[4])[0] = rslt.getInt(4) ;
                ((String[]) buf[5])[0] = rslt.getLongVarchar(5) ;
                ((bool[]) buf[6])[0] = rslt.wasNull(5);
                ((String[]) buf[7])[0] = rslt.getVarchar(6) ;
                ((DateTime[]) buf[8])[0] = rslt.getGXDateTime(7) ;
                ((String[]) buf[9])[0] = rslt.getVarchar(8) ;
                ((bool[]) buf[10])[0] = rslt.wasNull(8);
                ((DateTime[]) buf[11])[0] = rslt.getGXDateTime(9) ;
                ((bool[]) buf[12])[0] = rslt.wasNull(9);
                ((short[]) buf[13])[0] = rslt.getShort(10) ;
                return;
             case 2 :
                ((Guid[]) buf[0])[0] = rslt.getGuid(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
                ((String[]) buf[3])[0] = rslt.getVarchar(3) ;
                ((int[]) buf[4])[0] = rslt.getInt(4) ;
                ((String[]) buf[5])[0] = rslt.getLongVarchar(5) ;
                ((bool[]) buf[6])[0] = rslt.wasNull(5);
                ((String[]) buf[7])[0] = rslt.getVarchar(6) ;
                ((DateTime[]) buf[8])[0] = rslt.getGXDateTime(7) ;
                ((String[]) buf[9])[0] = rslt.getVarchar(8) ;
                ((bool[]) buf[10])[0] = rslt.wasNull(8);
                ((DateTime[]) buf[11])[0] = rslt.getGXDateTime(9) ;
                ((bool[]) buf[12])[0] = rslt.wasNull(9);
                ((short[]) buf[13])[0] = rslt.getShort(10) ;
                return;
             case 3 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                return;
             case 4 :
                ((Guid[]) buf[0])[0] = rslt.getGuid(1) ;
                return;
             case 5 :
                ((Guid[]) buf[0])[0] = rslt.getGuid(1) ;
                return;
             case 6 :
                ((Guid[]) buf[0])[0] = rslt.getGuid(1) ;
                return;
             case 10 :
                ((Guid[]) buf[0])[0] = rslt.getGuid(1) ;
                ((Guid[]) buf[1])[0] = rslt.getGuid(2) ;
                return;
             case 11 :
                ((Guid[]) buf[0])[0] = rslt.getGuid(1) ;
                return;
             case 12 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
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
                if ( (bool)parms[0] )
                {
                   stmt.setNull( 1 , SqlDbType.NVarChar );
                }
                else
                {
                   stmt.SetParameter(1, (String)parms[1]);
                }
                stmt.SetParameter(2, (String)parms[2]);
                stmt.SetParameter(3, (Guid)parms[3]);
                return;
             case 4 :
                stmt.SetParameter(1, (Guid)parms[0]);
                return;
             case 5 :
                stmt.SetParameter(1, (Guid)parms[0]);
                return;
             case 6 :
                stmt.SetParameter(1, (Guid)parms[0]);
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
                stmt.SetParameter(3, (int)parms[3]);
                if ( (bool)parms[4] )
                {
                   stmt.setNull( 4 , SqlDbType.NVarChar );
                }
                else
                {
                   stmt.SetParameter(4, (String)parms[5]);
                }
                stmt.SetParameter(5, (String)parms[6]);
                stmt.SetParameterDatetime(6, (DateTime)parms[7]);
                if ( (bool)parms[8] )
                {
                   stmt.setNull( 7 , SqlDbType.NVarChar );
                }
                else
                {
                   stmt.SetParameter(7, (String)parms[9]);
                }
                if ( (bool)parms[10] )
                {
                   stmt.setNull( 8 , SqlDbType.DateTime );
                }
                else
                {
                   stmt.SetParameterDatetime(8, (DateTime)parms[11]);
                }
                stmt.SetParameter(9, (short)parms[12]);
                stmt.SetParameter(10, (Guid)parms[13]);
                return;
             case 8 :
                if ( (bool)parms[0] )
                {
                   stmt.setNull( 1 , SqlDbType.NVarChar );
                }
                else
                {
                   stmt.SetParameter(1, (String)parms[1]);
                }
                stmt.SetParameter(2, (String)parms[2]);
                stmt.SetParameter(3, (int)parms[3]);
                if ( (bool)parms[4] )
                {
                   stmt.setNull( 4 , SqlDbType.NVarChar );
                }
                else
                {
                   stmt.SetParameter(4, (String)parms[5]);
                }
                stmt.SetParameter(5, (String)parms[6]);
                stmt.SetParameterDatetime(6, (DateTime)parms[7]);
                if ( (bool)parms[8] )
                {
                   stmt.setNull( 7 , SqlDbType.NVarChar );
                }
                else
                {
                   stmt.SetParameter(7, (String)parms[9]);
                }
                if ( (bool)parms[10] )
                {
                   stmt.setNull( 8 , SqlDbType.DateTime );
                }
                else
                {
                   stmt.SetParameterDatetime(8, (DateTime)parms[11]);
                }
                stmt.SetParameter(9, (short)parms[12]);
                stmt.SetParameter(10, (Guid)parms[13]);
                return;
             case 9 :
                stmt.SetParameter(1, (Guid)parms[0]);
                return;
             case 10 :
                stmt.SetParameter(1, (Guid)parms[0]);
                return;
             case 12 :
                if ( (bool)parms[0] )
                {
                   stmt.setNull( 1 , SqlDbType.NVarChar );
                }
                else
                {
                   stmt.SetParameter(1, (String)parms[1]);
                }
                stmt.SetParameter(2, (String)parms[2]);
                stmt.SetParameter(3, (Guid)parms[3]);
                return;
       }
    }

    public String getDataStoreName( )
    {
       return "DATASTORE1";
    }

 }

 public class sys_role__default : DataStoreHelperBase, IDataStoreHelper
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
