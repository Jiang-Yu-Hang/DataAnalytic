/*
               File: SYS_RolePermission
        Description: SYS_Role Permission
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/27/2020 9:38:58.66
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
   public class sys_rolepermission : GXDataArea, System.Web.SessionState.IRequiresSessionState
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
               AV7SYS_RolePermissionRoleID = (Guid)(StringUtil.StrToGuid( GetNextPar( )));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7SYS_RolePermissionRoleID", AV7SYS_RolePermissionRoleID.ToString());
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vSYS_ROLEPERMISSIONROLEID", GetSecureSignedToken( "", AV7SYS_RolePermissionRoleID, context));
               AV8SYS_RolePermissionPermissionCode = GetNextPar( );
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8SYS_RolePermissionPermissionCode", AV8SYS_RolePermissionPermissionCode);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vSYS_ROLEPERMISSIONPERMISSIONCODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( AV8SYS_RolePermissionPermissionCode, "")), context));
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
            Form.Meta.addItem("description", "SYS_Role Permission", 0) ;
         }
         context.wjLoc = "";
         context.nUserReturn = 0;
         context.wbHandled = 0;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         GX_FocusControl = edtSYS_RolePermissionRoleID_Internalname;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         wbErr = false;
         context.SetDefaultTheme("WorkWithPlusTheme");
         if ( ! context.IsLocalStorageSupported( ) )
         {
            context.PushCurrentUrl();
         }
      }

      public sys_rolepermission( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public sys_rolepermission( IGxContext context )
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
                           Guid aP1_SYS_RolePermissionRoleID ,
                           String aP2_SYS_RolePermissionPermissionCode )
      {
         this.Gx_mode = aP0_Gx_mode;
         this.AV7SYS_RolePermissionRoleID = aP1_SYS_RolePermissionRoleID;
         this.AV8SYS_RolePermissionPermissionCode = aP2_SYS_RolePermissionPermissionCode;
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
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-9 col-lg-6", "left", "top", "", "", "div");
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
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtSYS_RolePermissionRoleID_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtSYS_RolePermissionRoleID_Internalname, "Role ID", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 25,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtSYS_RolePermissionRoleID_Internalname, A444SYS_RolePermissionRoleID.ToString(), A444SYS_RolePermissionRoleID.ToString(), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,25);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtSYS_RolePermissionRoleID_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtSYS_RolePermissionRoleID_Enabled, 1, "text", "", 36, "chr", 1, "row", 36, 0, 0, 0, 1, 0, 0, true, "", "", false, "HLP_SYS_RolePermission.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtSYS_RolePermissionPermissionCode_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtSYS_RolePermissionPermissionCode_Internalname, "Permission Code", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 30,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtSYS_RolePermissionPermissionCode_Internalname, A445SYS_RolePermissionPermissionCode, StringUtil.RTrim( context.localUtil.Format( A445SYS_RolePermissionPermissionCode, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,30);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtSYS_RolePermissionPermissionCode_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtSYS_RolePermissionPermissionCode_Enabled, 1, "text", "", 64, "chr", 1, "row", 64, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_SYS_RolePermission.htm");
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
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 35,'',false,'',0)\"";
            ClassString = "ButtonMaterial";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtntrn_enter_Internalname, "", "确认", bttBtntrn_enter_Jsonclick, 5, "确认", "", StyleString, ClassString, bttBtntrn_enter_Visible, bttBtntrn_enter_Enabled, "standard", "'"+""+"'"+",false,"+"'"+"EENTER."+"'", TempTags, "", context.GetButtonType( ), "HLP_SYS_RolePermission.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 37,'',false,'',0)\"";
            ClassString = "ButtonMaterialDefault";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtntrn_cancel_Internalname, "", "取消", bttBtntrn_cancel_Jsonclick, 1, "取消", "", StyleString, ClassString, bttBtntrn_cancel_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ECANCEL."+"'", TempTags, "", context.GetButtonType( ), "HLP_SYS_RolePermission.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 39,'',false,'',0)\"";
            ClassString = "ButtonMaterialDefault";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtntrn_delete_Internalname, "", "删除", bttBtntrn_delete_Jsonclick, 5, "删除", "", StyleString, ClassString, bttBtntrn_delete_Visible, bttBtntrn_delete_Enabled, "standard", "'"+""+"'"+",false,"+"'"+"EDELETE."+"'", TempTags, "", context.GetButtonType( ), "HLP_SYS_RolePermission.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
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
         /* Execute user event: Start */
         E111G2 ();
         context.wbGlbDoneStart = 1;
         assign_properties_default( ) ;
         if ( AnyError == 0 )
         {
            if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
            {
               /* Read saved SDTs. */
               /* Read variables values. */
               if ( StringUtil.StrCmp(cgiGet( edtSYS_RolePermissionRoleID_Internalname), "") == 0 )
               {
                  A444SYS_RolePermissionRoleID = (Guid)(Guid.Empty);
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A444SYS_RolePermissionRoleID", A444SYS_RolePermissionRoleID.ToString());
               }
               else
               {
                  try
                  {
                     A444SYS_RolePermissionRoleID = (Guid)(StringUtil.StrToGuid( cgiGet( edtSYS_RolePermissionRoleID_Internalname)));
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A444SYS_RolePermissionRoleID", A444SYS_RolePermissionRoleID.ToString());
                  }
                  catch ( Exception e )
                  {
                     GX_msglist.addItem(context.GetMessage( "GXM_invalidguid", ""), 1, "SYS_ROLEPERMISSIONROLEID");
                     AnyError = 1;
                     GX_FocusControl = edtSYS_RolePermissionRoleID_Internalname;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                     wbErr = true;
                  }
               }
               A445SYS_RolePermissionPermissionCode = cgiGet( edtSYS_RolePermissionPermissionCode_Internalname);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A445SYS_RolePermissionPermissionCode", A445SYS_RolePermissionPermissionCode);
               /* Read saved values. */
               Z444SYS_RolePermissionRoleID = (Guid)(StringUtil.StrToGuid( cgiGet( "Z444SYS_RolePermissionRoleID")));
               Z445SYS_RolePermissionPermissionCode = cgiGet( "Z445SYS_RolePermissionPermissionCode");
               IsConfirmed = (short)(context.localUtil.CToN( cgiGet( "IsConfirmed"), ".", ","));
               IsModified = (short)(context.localUtil.CToN( cgiGet( "IsModified"), ".", ","));
               Gx_mode = cgiGet( "Mode");
               AV7SYS_RolePermissionRoleID = (Guid)(StringUtil.StrToGuid( cgiGet( "vSYS_ROLEPERMISSIONROLEID")));
               Gx_BScreen = (short)(context.localUtil.CToN( cgiGet( "vGXBSCREEN"), ".", ","));
               AV8SYS_RolePermissionPermissionCode = cgiGet( "vSYS_ROLEPERMISSIONPERMISSIONCODE");
               AV14Pgmname = cgiGet( "vPGMNAME");
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
               forbiddenHiddens = "hsh" + "SYS_RolePermission";
               forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!"));
               hsh = cgiGet( "hsh");
               if ( ( ! ( ( A444SYS_RolePermissionRoleID != Z444SYS_RolePermissionRoleID ) || ( StringUtil.StrCmp(A445SYS_RolePermissionPermissionCode, Z445SYS_RolePermissionPermissionCode) != 0 ) ) || ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) ) && ! GXUtil.CheckEncryptedHash( forbiddenHiddens, hsh, GXKey) )
               {
                  GXUtil.WriteLog("sys_rolepermission:[SecurityCheckFailed value for]"+"Gx_mode:"+StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")));
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
                  A444SYS_RolePermissionRoleID = (Guid)(StringUtil.StrToGuid( GetNextPar( )));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A444SYS_RolePermissionRoleID", A444SYS_RolePermissionRoleID.ToString());
                  A445SYS_RolePermissionPermissionCode = GetNextPar( );
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A445SYS_RolePermissionPermissionCode", A445SYS_RolePermissionPermissionCode);
                  getEqualNoModal( ) ;
                  if ( ! (Guid.Empty==AV7SYS_RolePermissionRoleID) )
                  {
                     A444SYS_RolePermissionRoleID = (Guid)(AV7SYS_RolePermissionRoleID);
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A444SYS_RolePermissionRoleID", A444SYS_RolePermissionRoleID.ToString());
                  }
                  else
                  {
                     if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  && (Guid.Empty==A444SYS_RolePermissionRoleID) && ( Gx_BScreen == 0 ) )
                     {
                        A444SYS_RolePermissionRoleID = (Guid)(Guid.NewGuid( ));
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A444SYS_RolePermissionRoleID", A444SYS_RolePermissionRoleID.ToString());
                     }
                  }
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
                     sMode61 = Gx_mode;
                     Gx_mode = "UPD";
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                     if ( ! (Guid.Empty==AV7SYS_RolePermissionRoleID) )
                     {
                        A444SYS_RolePermissionRoleID = (Guid)(AV7SYS_RolePermissionRoleID);
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A444SYS_RolePermissionRoleID", A444SYS_RolePermissionRoleID.ToString());
                     }
                     else
                     {
                        if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  && (Guid.Empty==A444SYS_RolePermissionRoleID) && ( Gx_BScreen == 0 ) )
                        {
                           A444SYS_RolePermissionRoleID = (Guid)(Guid.NewGuid( ));
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A444SYS_RolePermissionRoleID", A444SYS_RolePermissionRoleID.ToString());
                        }
                     }
                     Gx_mode = sMode61;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                  }
                  standaloneModal( ) ;
                  if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
                  {
                     getByPrimaryKey( ) ;
                     if ( RcdFound61 == 1 )
                     {
                        if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
                        {
                           /* Confirm record */
                           CONFIRM_1G0( ) ;
                           if ( AnyError == 0 )
                           {
                              GX_FocusControl = bttBtntrn_enter_Internalname;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                           }
                        }
                     }
                     else
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_noinsert", ""), 1, "SYS_ROLEPERMISSIONROLEID");
                        AnyError = 1;
                        GX_FocusControl = edtSYS_RolePermissionRoleID_Internalname;
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
                           E111G2 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "AFTER TRN") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           /* Execute user event: After Trn */
                           E121G2 ();
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
            E121G2 ();
            trnEnded = 0;
            standaloneNotModal( ) ;
            standaloneModal( ) ;
            if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  )
            {
               /* Clear variables for new insertion. */
               InitAll1G61( ) ;
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
            DisableAttributes1G61( ) ;
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

      protected void CONFIRM_1G0( )
      {
         BeforeValidate1G61( ) ;
         if ( AnyError == 0 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
            {
               OnDeleteControls1G61( ) ;
            }
            else
            {
               CheckExtendedTable1G61( ) ;
               CloseExtendedTableCursors1G61( ) ;
            }
         }
         if ( AnyError == 0 )
         {
            IsConfirmed = 1;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "IsConfirmed", StringUtil.LTrim( StringUtil.Str( (decimal)(IsConfirmed), 4, 0)));
         }
      }

      protected void ResetCaption1G0( )
      {
      }

      protected void E111G2( )
      {
         /* Start Routine */
         new GeneXus.Programs.wwpbaseobjects.loadwwpcontext(context ).execute( out  AV9WWPContext) ;
         AV10IsAuthorized = true;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10IsAuthorized", AV10IsAuthorized);
         if ( StringUtil.StrCmp(Gx_mode, "DSP") == 0 )
         {
            GXt_boolean1 = AV10IsAuthorized;
            new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "Role_Manager", out  GXt_boolean1) ;
            AV10IsAuthorized = GXt_boolean1;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10IsAuthorized", AV10IsAuthorized);
         }
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            GXt_boolean1 = AV10IsAuthorized;
            new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "Role_Manager", out  GXt_boolean1) ;
            AV10IsAuthorized = GXt_boolean1;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10IsAuthorized", AV10IsAuthorized);
         }
         if ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 )
         {
            GXt_boolean1 = AV10IsAuthorized;
            new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "Role_Manager", out  GXt_boolean1) ;
            AV10IsAuthorized = GXt_boolean1;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10IsAuthorized", AV10IsAuthorized);
         }
         if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
         {
            GXt_boolean1 = AV10IsAuthorized;
            new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "Role_Manager", out  GXt_boolean1) ;
            AV10IsAuthorized = GXt_boolean1;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10IsAuthorized", AV10IsAuthorized);
         }
         if ( ! AV10IsAuthorized )
         {
            CallWebObject(formatLink("wwpbaseobjects.notauthorized.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV14Pgmname)));
            context.wjLocDisableFrm = 1;
         }
         AV12TrnContext.FromXml(AV13WebSession.Get("TrnContext"), null, "WWPTransactionContext", "DataAnalysisPlatform");
      }

      protected void E121G2( )
      {
         /* After Trn Routine */
         if ( ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 ) && ! AV12TrnContext.gxTpr_Callerondelete )
         {
            CallWebObject(formatLink("sys_rolepermissionww.aspx") );
            context.wjLocDisableFrm = 1;
         }
         context.setWebReturnParms(new Object[] {});
         context.setWebReturnParmsMetadata(new Object[] {});
         context.wjLocDisableFrm = 1;
         context.nUserReturn = 1;
         returnInSub = true;
         if (true) return;
      }

      protected void ZM1G61( short GX_JID )
      {
         if ( ( GX_JID == 8 ) || ( GX_JID == 0 ) )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
            {
            }
            else
            {
            }
         }
         if ( GX_JID == -8 )
         {
            Z444SYS_RolePermissionRoleID = (Guid)(A444SYS_RolePermissionRoleID);
            Z445SYS_RolePermissionPermissionCode = A445SYS_RolePermissionPermissionCode;
         }
      }

      protected void standaloneNotModal( )
      {
         Gx_BScreen = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_BScreen", StringUtil.Str( (decimal)(Gx_BScreen), 1, 0));
         bttBtntrn_delete_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtntrn_delete_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtntrn_delete_Enabled), 5, 0)), true);
         if ( ! (Guid.Empty==AV7SYS_RolePermissionRoleID) )
         {
            edtSYS_RolePermissionRoleID_Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtSYS_RolePermissionRoleID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtSYS_RolePermissionRoleID_Enabled), 5, 0)), true);
         }
         else
         {
            edtSYS_RolePermissionRoleID_Enabled = 1;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtSYS_RolePermissionRoleID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtSYS_RolePermissionRoleID_Enabled), 5, 0)), true);
         }
         if ( ! (Guid.Empty==AV7SYS_RolePermissionRoleID) )
         {
            edtSYS_RolePermissionRoleID_Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtSYS_RolePermissionRoleID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtSYS_RolePermissionRoleID_Enabled), 5, 0)), true);
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV8SYS_RolePermissionPermissionCode)) )
         {
            A445SYS_RolePermissionPermissionCode = AV8SYS_RolePermissionPermissionCode;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A445SYS_RolePermissionPermissionCode", A445SYS_RolePermissionPermissionCode);
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV8SYS_RolePermissionPermissionCode)) )
         {
            edtSYS_RolePermissionPermissionCode_Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtSYS_RolePermissionPermissionCode_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtSYS_RolePermissionPermissionCode_Enabled), 5, 0)), true);
         }
         else
         {
            edtSYS_RolePermissionPermissionCode_Enabled = 1;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtSYS_RolePermissionPermissionCode_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtSYS_RolePermissionPermissionCode_Enabled), 5, 0)), true);
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV8SYS_RolePermissionPermissionCode)) )
         {
            edtSYS_RolePermissionPermissionCode_Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtSYS_RolePermissionPermissionCode_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtSYS_RolePermissionPermissionCode_Enabled), 5, 0)), true);
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
         if ( ! (Guid.Empty==AV7SYS_RolePermissionRoleID) )
         {
            A444SYS_RolePermissionRoleID = (Guid)(AV7SYS_RolePermissionRoleID);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A444SYS_RolePermissionRoleID", A444SYS_RolePermissionRoleID.ToString());
         }
         else
         {
            if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  && (Guid.Empty==A444SYS_RolePermissionRoleID) && ( Gx_BScreen == 0 ) )
            {
               A444SYS_RolePermissionRoleID = (Guid)(Guid.NewGuid( ));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A444SYS_RolePermissionRoleID", A444SYS_RolePermissionRoleID.ToString());
            }
         }
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) && ( Gx_BScreen == 0 ) )
         {
            AV14Pgmname = "SYS_RolePermission";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14Pgmname", AV14Pgmname);
         }
      }

      protected void Load1G61( )
      {
         /* Using cursor T001G4 */
         pr_datastore1.execute(2, new Object[] {A444SYS_RolePermissionRoleID, A445SYS_RolePermissionPermissionCode});
         if ( (pr_datastore1.getStatus(2) != 101) )
         {
            RcdFound61 = 1;
            ZM1G61( -8) ;
         }
         pr_datastore1.close(2);
         OnLoadActions1G61( ) ;
      }

      protected void OnLoadActions1G61( )
      {
         AV14Pgmname = "SYS_RolePermission";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14Pgmname", AV14Pgmname);
      }

      protected void CheckExtendedTable1G61( )
      {
         Gx_BScreen = 1;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_BScreen", StringUtil.Str( (decimal)(Gx_BScreen), 1, 0));
         standaloneModal( ) ;
         AV14Pgmname = "SYS_RolePermission";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14Pgmname", AV14Pgmname);
      }

      protected void CloseExtendedTableCursors1G61( )
      {
      }

      protected void enableDisable( )
      {
      }

      protected void GetKey1G61( )
      {
         /* Using cursor T001G5 */
         pr_datastore1.execute(3, new Object[] {A444SYS_RolePermissionRoleID, A445SYS_RolePermissionPermissionCode});
         if ( (pr_datastore1.getStatus(3) != 101) )
         {
            RcdFound61 = 1;
         }
         else
         {
            RcdFound61 = 0;
         }
         pr_datastore1.close(3);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor T001G3 */
         pr_datastore1.execute(1, new Object[] {A444SYS_RolePermissionRoleID, A445SYS_RolePermissionPermissionCode});
         if ( (pr_datastore1.getStatus(1) != 101) )
         {
            ZM1G61( 8) ;
            RcdFound61 = 1;
            A444SYS_RolePermissionRoleID = (Guid)((Guid)(T001G3_A444SYS_RolePermissionRoleID[0]));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A444SYS_RolePermissionRoleID", A444SYS_RolePermissionRoleID.ToString());
            A445SYS_RolePermissionPermissionCode = T001G3_A445SYS_RolePermissionPermissionCode[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A445SYS_RolePermissionPermissionCode", A445SYS_RolePermissionPermissionCode);
            Z444SYS_RolePermissionRoleID = (Guid)(A444SYS_RolePermissionRoleID);
            Z445SYS_RolePermissionPermissionCode = A445SYS_RolePermissionPermissionCode;
            sMode61 = Gx_mode;
            Gx_mode = "DSP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
            Load1G61( ) ;
            if ( AnyError == 1 )
            {
               RcdFound61 = 0;
               InitializeNonKey1G61( ) ;
            }
            Gx_mode = sMode61;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         }
         else
         {
            RcdFound61 = 0;
            InitializeNonKey1G61( ) ;
            sMode61 = Gx_mode;
            Gx_mode = "DSP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
            standaloneModal( ) ;
            Gx_mode = sMode61;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         }
         pr_datastore1.close(1);
      }

      protected void getEqualNoModal( )
      {
         GetKey1G61( ) ;
         if ( RcdFound61 == 0 )
         {
         }
         else
         {
         }
         getByPrimaryKey( ) ;
      }

      protected void move_next( )
      {
         RcdFound61 = 0;
         /* Using cursor T001G6 */
         pr_datastore1.execute(4, new Object[] {A444SYS_RolePermissionRoleID, A445SYS_RolePermissionPermissionCode});
         if ( (pr_datastore1.getStatus(4) != 101) )
         {
            while ( (pr_datastore1.getStatus(4) != 101) && ( ( GuidUtil.Compare(T001G6_A444SYS_RolePermissionRoleID[0], A444SYS_RolePermissionRoleID, 1) < 0 ) || ( T001G6_A444SYS_RolePermissionRoleID[0] == A444SYS_RolePermissionRoleID ) && ( StringUtil.StrCmp(T001G6_A445SYS_RolePermissionPermissionCode[0], A445SYS_RolePermissionPermissionCode) < 0 ) ) )
            {
               pr_datastore1.readNext(4);
            }
            if ( (pr_datastore1.getStatus(4) != 101) && ( ( GuidUtil.Compare(T001G6_A444SYS_RolePermissionRoleID[0], A444SYS_RolePermissionRoleID, 1) > 0 ) || ( T001G6_A444SYS_RolePermissionRoleID[0] == A444SYS_RolePermissionRoleID ) && ( StringUtil.StrCmp(T001G6_A445SYS_RolePermissionPermissionCode[0], A445SYS_RolePermissionPermissionCode) > 0 ) ) )
            {
               A444SYS_RolePermissionRoleID = (Guid)((Guid)(T001G6_A444SYS_RolePermissionRoleID[0]));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A444SYS_RolePermissionRoleID", A444SYS_RolePermissionRoleID.ToString());
               A445SYS_RolePermissionPermissionCode = T001G6_A445SYS_RolePermissionPermissionCode[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A445SYS_RolePermissionPermissionCode", A445SYS_RolePermissionPermissionCode);
               RcdFound61 = 1;
            }
         }
         pr_datastore1.close(4);
      }

      protected void move_previous( )
      {
         RcdFound61 = 0;
         /* Using cursor T001G7 */
         pr_datastore1.execute(5, new Object[] {A444SYS_RolePermissionRoleID, A445SYS_RolePermissionPermissionCode});
         if ( (pr_datastore1.getStatus(5) != 101) )
         {
            while ( (pr_datastore1.getStatus(5) != 101) && ( ( GuidUtil.Compare(T001G7_A444SYS_RolePermissionRoleID[0], A444SYS_RolePermissionRoleID, 1) > 0 ) || ( T001G7_A444SYS_RolePermissionRoleID[0] == A444SYS_RolePermissionRoleID ) && ( StringUtil.StrCmp(T001G7_A445SYS_RolePermissionPermissionCode[0], A445SYS_RolePermissionPermissionCode) > 0 ) ) )
            {
               pr_datastore1.readNext(5);
            }
            if ( (pr_datastore1.getStatus(5) != 101) && ( ( GuidUtil.Compare(T001G7_A444SYS_RolePermissionRoleID[0], A444SYS_RolePermissionRoleID, 1) < 0 ) || ( T001G7_A444SYS_RolePermissionRoleID[0] == A444SYS_RolePermissionRoleID ) && ( StringUtil.StrCmp(T001G7_A445SYS_RolePermissionPermissionCode[0], A445SYS_RolePermissionPermissionCode) < 0 ) ) )
            {
               A444SYS_RolePermissionRoleID = (Guid)((Guid)(T001G7_A444SYS_RolePermissionRoleID[0]));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A444SYS_RolePermissionRoleID", A444SYS_RolePermissionRoleID.ToString());
               A445SYS_RolePermissionPermissionCode = T001G7_A445SYS_RolePermissionPermissionCode[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A445SYS_RolePermissionPermissionCode", A445SYS_RolePermissionPermissionCode);
               RcdFound61 = 1;
            }
         }
         pr_datastore1.close(5);
      }

      protected void btn_enter( )
      {
         nKeyPressed = 1;
         GetKey1G61( ) ;
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            /* Insert record */
            GX_FocusControl = edtSYS_RolePermissionRoleID_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            Insert1G61( ) ;
            if ( AnyError == 1 )
            {
               GX_FocusControl = "";
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
         }
         else
         {
            if ( RcdFound61 == 1 )
            {
               if ( ( A444SYS_RolePermissionRoleID != Z444SYS_RolePermissionRoleID ) || ( StringUtil.StrCmp(A445SYS_RolePermissionPermissionCode, Z445SYS_RolePermissionPermissionCode) != 0 ) )
               {
                  A444SYS_RolePermissionRoleID = (Guid)(Z444SYS_RolePermissionRoleID);
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A444SYS_RolePermissionRoleID", A444SYS_RolePermissionRoleID.ToString());
                  A445SYS_RolePermissionPermissionCode = Z445SYS_RolePermissionPermissionCode;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A445SYS_RolePermissionPermissionCode", A445SYS_RolePermissionPermissionCode);
                  GX_msglist.addItem(context.GetMessage( "GXM_getbeforeupd", ""), "CandidateKeyNotFound", 1, "SYS_ROLEPERMISSIONROLEID");
                  AnyError = 1;
                  GX_FocusControl = edtSYS_RolePermissionRoleID_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
               else if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
               {
                  delete( ) ;
                  AfterTrn( ) ;
                  GX_FocusControl = edtSYS_RolePermissionRoleID_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
               else
               {
                  /* Update record */
                  Update1G61( ) ;
                  GX_FocusControl = edtSYS_RolePermissionRoleID_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
            }
            else
            {
               if ( ( A444SYS_RolePermissionRoleID != Z444SYS_RolePermissionRoleID ) || ( StringUtil.StrCmp(A445SYS_RolePermissionPermissionCode, Z445SYS_RolePermissionPermissionCode) != 0 ) )
               {
                  /* Insert record */
                  GX_FocusControl = edtSYS_RolePermissionRoleID_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  Insert1G61( ) ;
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
                     GX_msglist.addItem(context.GetMessage( "GXM_recdeleted", ""), 1, "SYS_ROLEPERMISSIONROLEID");
                     AnyError = 1;
                     GX_FocusControl = edtSYS_RolePermissionRoleID_Internalname;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  }
                  else
                  {
                     /* Insert record */
                     GX_FocusControl = edtSYS_RolePermissionRoleID_Internalname;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                     Insert1G61( ) ;
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
         if ( ( A444SYS_RolePermissionRoleID != Z444SYS_RolePermissionRoleID ) || ( StringUtil.StrCmp(A445SYS_RolePermissionPermissionCode, Z445SYS_RolePermissionPermissionCode) != 0 ) )
         {
            A444SYS_RolePermissionRoleID = (Guid)(Z444SYS_RolePermissionRoleID);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A444SYS_RolePermissionRoleID", A444SYS_RolePermissionRoleID.ToString());
            A445SYS_RolePermissionPermissionCode = Z445SYS_RolePermissionPermissionCode;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A445SYS_RolePermissionPermissionCode", A445SYS_RolePermissionPermissionCode);
            GX_msglist.addItem(context.GetMessage( "GXM_getbeforedlt", ""), 1, "SYS_ROLEPERMISSIONROLEID");
            AnyError = 1;
            GX_FocusControl = edtSYS_RolePermissionRoleID_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         else
         {
            delete( ) ;
            AfterTrn( ) ;
            GX_FocusControl = edtSYS_RolePermissionRoleID_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( AnyError != 0 )
         {
         }
      }

      protected void CheckOptimisticConcurrency1G61( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor T001G2 */
            pr_datastore1.execute(0, new Object[] {A444SYS_RolePermissionRoleID, A445SYS_RolePermissionPermissionCode});
            if ( (pr_datastore1.getStatus(0) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"SYS_ROLEPERMISSION"}), "RecordIsLocked", 1, "");
               AnyError = 1;
               return  ;
            }
            if ( (pr_datastore1.getStatus(0) == 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"SYS_ROLEPERMISSION"}), "RecordWasChanged", 1, "");
               AnyError = 1;
               return  ;
            }
         }
      }

      protected void Insert1G61( )
      {
         BeforeValidate1G61( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable1G61( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM1G61( 0) ;
            CheckOptimisticConcurrency1G61( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm1G61( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert1G61( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T001G8 */
                     pr_datastore1.execute(6, new Object[] {A445SYS_RolePermissionPermissionCode, A444SYS_RolePermissionRoleID});
                     pr_datastore1.close(6);
                     dsDataStore1.SmartCacheProvider.SetUpdated("SYS_ROLEPERMISSION") ;
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
                           ResetCaption1G0( ) ;
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
               Load1G61( ) ;
            }
            EndLevel1G61( ) ;
         }
         CloseExtendedTableCursors1G61( ) ;
      }

      protected void Update1G61( )
      {
         BeforeValidate1G61( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable1G61( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency1G61( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm1G61( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate1G61( ) ;
                  if ( AnyError == 0 )
                  {
                     /* No attributes to update on table [SYS_RolePermission] */
                     DeferredUpdate1G61( ) ;
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
            EndLevel1G61( ) ;
         }
         CloseExtendedTableCursors1G61( ) ;
      }

      protected void DeferredUpdate1G61( )
      {
      }

      protected void delete( )
      {
         BeforeValidate1G61( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency1G61( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls1G61( ) ;
            AfterConfirm1G61( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete1G61( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor T001G9 */
                  pr_datastore1.execute(7, new Object[] {A444SYS_RolePermissionRoleID, A445SYS_RolePermissionPermissionCode});
                  pr_datastore1.close(7);
                  dsDataStore1.SmartCacheProvider.SetUpdated("SYS_ROLEPERMISSION") ;
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
         sMode61 = Gx_mode;
         Gx_mode = "DLT";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         EndLevel1G61( ) ;
         Gx_mode = sMode61;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
      }

      protected void OnDeleteControls1G61( )
      {
         standaloneModal( ) ;
         if ( AnyError == 0 )
         {
            /* Delete mode formulas */
            AV14Pgmname = "SYS_RolePermission";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14Pgmname", AV14Pgmname);
         }
      }

      protected void EndLevel1G61( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            pr_datastore1.close(0);
         }
         if ( AnyError == 0 )
         {
            BeforeComplete1G61( ) ;
         }
         if ( AnyError == 0 )
         {
            pr_datastore1.close(1);
            context.CommitDataStores("sys_rolepermission",pr_default);
            if ( AnyError == 0 )
            {
               ConfirmValues1G0( ) ;
            }
            /* After transaction rules */
            /* Execute 'After Trn' event if defined. */
            trnEnded = 1;
         }
         else
         {
            pr_datastore1.close(1);
            context.RollbackDataStores("sys_rolepermission",pr_default);
         }
         IsModified = 0;
         if ( AnyError != 0 )
         {
            context.wjLoc = "";
            context.nUserReturn = 0;
         }
      }

      public void ScanStart1G61( )
      {
         /* Scan By routine */
         /* Using cursor T001G10 */
         pr_datastore1.execute(8);
         RcdFound61 = 0;
         if ( (pr_datastore1.getStatus(8) != 101) )
         {
            RcdFound61 = 1;
            A444SYS_RolePermissionRoleID = (Guid)((Guid)(T001G10_A444SYS_RolePermissionRoleID[0]));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A444SYS_RolePermissionRoleID", A444SYS_RolePermissionRoleID.ToString());
            A445SYS_RolePermissionPermissionCode = T001G10_A445SYS_RolePermissionPermissionCode[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A445SYS_RolePermissionPermissionCode", A445SYS_RolePermissionPermissionCode);
         }
         /* Load Subordinate Levels */
      }

      protected void ScanNext1G61( )
      {
         /* Scan next routine */
         pr_datastore1.readNext(8);
         RcdFound61 = 0;
         if ( (pr_datastore1.getStatus(8) != 101) )
         {
            RcdFound61 = 1;
            A444SYS_RolePermissionRoleID = (Guid)((Guid)(T001G10_A444SYS_RolePermissionRoleID[0]));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A444SYS_RolePermissionRoleID", A444SYS_RolePermissionRoleID.ToString());
            A445SYS_RolePermissionPermissionCode = T001G10_A445SYS_RolePermissionPermissionCode[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A445SYS_RolePermissionPermissionCode", A445SYS_RolePermissionPermissionCode);
         }
      }

      protected void ScanEnd1G61( )
      {
         pr_datastore1.close(8);
      }

      protected void AfterConfirm1G61( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert1G61( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate1G61( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete1G61( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete1G61( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate1G61( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes1G61( )
      {
         edtSYS_RolePermissionRoleID_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtSYS_RolePermissionRoleID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtSYS_RolePermissionRoleID_Enabled), 5, 0)), true);
         edtSYS_RolePermissionPermissionCode_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtSYS_RolePermissionPermissionCode_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtSYS_RolePermissionPermissionCode_Enabled), 5, 0)), true);
      }

      protected void send_integrity_lvl_hashes1G61( )
      {
      }

      protected void assign_properties_default( )
      {
      }

      protected void ConfirmValues1G0( )
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
         context.AddJavascriptSource("gxcfg.js", "?20202279385977", false);
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" autocomplete=\"off\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("sys_rolepermission.aspx") + "?" + UrlEncode(StringUtil.RTrim(Gx_mode)) + "," + UrlEncode(AV7SYS_RolePermissionRoleID.ToString()) + "," + UrlEncode(StringUtil.RTrim(AV8SYS_RolePermissionPermissionCode))+"\">") ;
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
         forbiddenHiddens = "hsh" + "SYS_RolePermission";
         forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!"));
         GxWebStd.gx_hidden_field( context, "hsh", GetEncryptedHash( forbiddenHiddens, GXKey));
         GXUtil.WriteLog("sys_rolepermission:[SendSecurityCheck value for]"+"Gx_mode:"+StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")));
      }

      protected void SendCloseFormHiddens( )
      {
         /* Send hidden variables. */
         /* Send saved values. */
         send_integrity_footer_hashes( ) ;
         GxWebStd.gx_hidden_field( context, "Z444SYS_RolePermissionRoleID", Z444SYS_RolePermissionRoleID.ToString());
         GxWebStd.gx_hidden_field( context, "Z445SYS_RolePermissionPermissionCode", Z445SYS_RolePermissionPermissionCode);
         GxWebStd.gx_hidden_field( context, "IsConfirmed", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsConfirmed), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "IsModified", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsModified), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "Mode", StringUtil.RTrim( Gx_mode));
         GxWebStd.gx_hidden_field( context, "gxhash_Mode", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vTRNCONTEXT", AV12TrnContext);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vTRNCONTEXT", AV12TrnContext);
         }
         GxWebStd.gx_hidden_field( context, "vSYS_ROLEPERMISSIONROLEID", AV7SYS_RolePermissionRoleID.ToString());
         GxWebStd.gx_hidden_field( context, "gxhash_vSYS_ROLEPERMISSIONROLEID", GetSecureSignedToken( "", AV7SYS_RolePermissionRoleID, context));
         GxWebStd.gx_hidden_field( context, "vGXBSCREEN", StringUtil.LTrim( StringUtil.NToC( (decimal)(Gx_BScreen), 1, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "vSYS_ROLEPERMISSIONPERMISSIONCODE", AV8SYS_RolePermissionPermissionCode);
         GxWebStd.gx_hidden_field( context, "gxhash_vSYS_ROLEPERMISSIONPERMISSIONCODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( AV8SYS_RolePermissionPermissionCode, "")), context));
         GxWebStd.gx_hidden_field( context, "vPGMNAME", StringUtil.RTrim( AV14Pgmname));
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
         return formatLink("sys_rolepermission.aspx") + "?" + UrlEncode(StringUtil.RTrim(Gx_mode)) + "," + UrlEncode(AV7SYS_RolePermissionRoleID.ToString()) + "," + UrlEncode(StringUtil.RTrim(AV8SYS_RolePermissionPermissionCode)) ;
      }

      public override String GetPgmname( )
      {
         return "SYS_RolePermission" ;
      }

      public override String GetPgmdesc( )
      {
         return "SYS_Role Permission" ;
      }

      protected void InitializeNonKey1G61( )
      {
      }

      protected void InitAll1G61( )
      {
         A444SYS_RolePermissionRoleID = (Guid)(Guid.NewGuid( ));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A444SYS_RolePermissionRoleID", A444SYS_RolePermissionRoleID.ToString());
         A445SYS_RolePermissionPermissionCode = "";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A445SYS_RolePermissionPermissionCode", A445SYS_RolePermissionPermissionCode);
         InitializeNonKey1G61( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?20202279385999", true);
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
         context.AddJavascriptSource("sys_rolepermission.js", "?20202279385999", false);
         context.AddJavascriptSource("DVelop/Bootstrap/Shared/DVelopBootstrap.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/Panel/BootstrapPanelRender.js", "", false);
         /* End function include_jscripts */
      }

      protected void init_default_properties( )
      {
         edtSYS_RolePermissionRoleID_Internalname = "SYS_ROLEPERMISSIONROLEID";
         edtSYS_RolePermissionPermissionCode_Internalname = "SYS_ROLEPERMISSIONPERMISSIONCODE";
         divTableattributes_Internalname = "TABLEATTRIBUTES";
         divLayout_tableattributes_Internalname = "LAYOUT_TABLEATTRIBUTES";
         Dvpanel_tableattributes_Internalname = "DVPANEL_TABLEATTRIBUTES";
         divHtml_dvpanel_tableattributes_Internalname = "HTML_DVPANEL_TABLEATTRIBUTES";
         divTablecontent_Internalname = "TABLECONTENT";
         bttBtntrn_enter_Internalname = "BTNTRN_ENTER";
         bttBtntrn_cancel_Internalname = "BTNTRN_CANCEL";
         bttBtntrn_delete_Internalname = "BTNTRN_DELETE";
         divTablemain_Internalname = "TABLEMAIN";
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
         Form.Caption = "SYS_Role Permission";
         bttBtntrn_delete_Enabled = 0;
         bttBtntrn_delete_Visible = 1;
         bttBtntrn_cancel_Visible = 1;
         bttBtntrn_enter_Enabled = 1;
         bttBtntrn_enter_Visible = 1;
         edtSYS_RolePermissionPermissionCode_Jsonclick = "";
         edtSYS_RolePermissionPermissionCode_Enabled = 1;
         edtSYS_RolePermissionRoleID_Jsonclick = "";
         edtSYS_RolePermissionRoleID_Enabled = 1;
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
         setEventMetadata("ENTER","{handler:'UserMainFullajax',iparms:[{postForm:true},{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV7SYS_RolePermissionRoleID',fld:'vSYS_ROLEPERMISSIONROLEID',pic:'',hsh:true},{av:'AV8SYS_RolePermissionPermissionCode',fld:'vSYS_ROLEPERMISSIONPERMISSIONCODE',pic:'',hsh:true}]");
         setEventMetadata("ENTER",",oparms:[]}");
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV7SYS_RolePermissionRoleID',fld:'vSYS_ROLEPERMISSIONROLEID',pic:'',hsh:true},{av:'AV8SYS_RolePermissionPermissionCode',fld:'vSYS_ROLEPERMISSIONPERMISSIONCODE',pic:'',hsh:true}]");
         setEventMetadata("REFRESH",",oparms:[]}");
         setEventMetadata("AFTER TRN","{handler:'E121G2',iparms:[{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV12TrnContext',fld:'vTRNCONTEXT',pic:''}]");
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
         pr_datastore1.close(1);
      }

      public override void initialize( )
      {
         sPrefix = "";
         wcpOGx_mode = "";
         wcpOAV7SYS_RolePermissionRoleID = (Guid)(Guid.Empty);
         wcpOAV8SYS_RolePermissionPermissionCode = "";
         Z444SYS_RolePermissionRoleID = (Guid)(Guid.Empty);
         Z445SYS_RolePermissionPermissionCode = "";
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
         A444SYS_RolePermissionRoleID = (Guid)(Guid.Empty);
         A445SYS_RolePermissionPermissionCode = "";
         bttBtntrn_enter_Jsonclick = "";
         bttBtntrn_cancel_Jsonclick = "";
         bttBtntrn_delete_Jsonclick = "";
         AV14Pgmname = "";
         Dvpanel_tableattributes_Objectcall = "";
         Dvpanel_tableattributes_Class = "";
         Dvpanel_tableattributes_Height = "";
         forbiddenHiddens = "";
         hsh = "";
         sMode61 = "";
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         AV9WWPContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPContext(context);
         AV12TrnContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext(context);
         AV13WebSession = context.GetSession();
         T001G4_A444SYS_RolePermissionRoleID = new Guid[] {Guid.Empty} ;
         T001G4_A445SYS_RolePermissionPermissionCode = new String[] {""} ;
         T001G5_A444SYS_RolePermissionRoleID = new Guid[] {Guid.Empty} ;
         T001G5_A445SYS_RolePermissionPermissionCode = new String[] {""} ;
         T001G3_A444SYS_RolePermissionRoleID = new Guid[] {Guid.Empty} ;
         T001G3_A445SYS_RolePermissionPermissionCode = new String[] {""} ;
         T001G6_A444SYS_RolePermissionRoleID = new Guid[] {Guid.Empty} ;
         T001G6_A445SYS_RolePermissionPermissionCode = new String[] {""} ;
         T001G7_A444SYS_RolePermissionRoleID = new Guid[] {Guid.Empty} ;
         T001G7_A445SYS_RolePermissionPermissionCode = new String[] {""} ;
         T001G2_A444SYS_RolePermissionRoleID = new Guid[] {Guid.Empty} ;
         T001G2_A445SYS_RolePermissionPermissionCode = new String[] {""} ;
         T001G10_A444SYS_RolePermissionRoleID = new Guid[] {Guid.Empty} ;
         T001G10_A445SYS_RolePermissionPermissionCode = new String[] {""} ;
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         pr_datastore1 = new DataStoreProvider(context, new GeneXus.Programs.sys_rolepermission__datastore1(),
            new Object[][] {
                new Object[] {
               T001G2_A444SYS_RolePermissionRoleID, T001G2_A445SYS_RolePermissionPermissionCode
               }
               , new Object[] {
               T001G3_A444SYS_RolePermissionRoleID, T001G3_A445SYS_RolePermissionPermissionCode
               }
               , new Object[] {
               T001G4_A444SYS_RolePermissionRoleID, T001G4_A445SYS_RolePermissionPermissionCode
               }
               , new Object[] {
               T001G5_A444SYS_RolePermissionRoleID, T001G5_A445SYS_RolePermissionPermissionCode
               }
               , new Object[] {
               T001G6_A444SYS_RolePermissionRoleID, T001G6_A445SYS_RolePermissionPermissionCode
               }
               , new Object[] {
               T001G7_A444SYS_RolePermissionRoleID, T001G7_A445SYS_RolePermissionPermissionCode
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               T001G10_A444SYS_RolePermissionRoleID, T001G10_A445SYS_RolePermissionPermissionCode
               }
            }
         );
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.sys_rolepermission__default(),
            new Object[][] {
            }
         );
         Z444SYS_RolePermissionRoleID = (Guid)(Guid.NewGuid( ));
         A444SYS_RolePermissionRoleID = (Guid)(Guid.NewGuid( ));
         AV14Pgmname = "SYS_RolePermission";
      }

      private short GxWebError ;
      private short gxcookieaux ;
      private short IsConfirmed ;
      private short IsModified ;
      private short AnyError ;
      private short nKeyPressed ;
      private short initialized ;
      private short Gx_BScreen ;
      private short RcdFound61 ;
      private short GX_JID ;
      private short gxajaxcallmode ;
      private int trnEnded ;
      private int edtSYS_RolePermissionRoleID_Enabled ;
      private int edtSYS_RolePermissionPermissionCode_Enabled ;
      private int bttBtntrn_enter_Visible ;
      private int bttBtntrn_enter_Enabled ;
      private int bttBtntrn_cancel_Visible ;
      private int bttBtntrn_delete_Visible ;
      private int bttBtntrn_delete_Enabled ;
      private int idxLst ;
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
      private String edtSYS_RolePermissionRoleID_Internalname ;
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
      private String edtSYS_RolePermissionRoleID_Jsonclick ;
      private String edtSYS_RolePermissionPermissionCode_Internalname ;
      private String edtSYS_RolePermissionPermissionCode_Jsonclick ;
      private String bttBtntrn_enter_Internalname ;
      private String bttBtntrn_enter_Jsonclick ;
      private String bttBtntrn_cancel_Internalname ;
      private String bttBtntrn_cancel_Jsonclick ;
      private String bttBtntrn_delete_Internalname ;
      private String bttBtntrn_delete_Jsonclick ;
      private String AV14Pgmname ;
      private String Dvpanel_tableattributes_Objectcall ;
      private String Dvpanel_tableattributes_Class ;
      private String Dvpanel_tableattributes_Height ;
      private String forbiddenHiddens ;
      private String hsh ;
      private String sMode61 ;
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
      private bool Dvpanel_tableattributes_Enabled ;
      private bool Dvpanel_tableattributes_Showheader ;
      private bool Dvpanel_tableattributes_Visible ;
      private bool AV10IsAuthorized ;
      private bool GXt_boolean1 ;
      private bool returnInSub ;
      private String wcpOAV8SYS_RolePermissionPermissionCode ;
      private String Z445SYS_RolePermissionPermissionCode ;
      private String AV8SYS_RolePermissionPermissionCode ;
      private String A445SYS_RolePermissionPermissionCode ;
      private Guid wcpOAV7SYS_RolePermissionRoleID ;
      private Guid Z444SYS_RolePermissionRoleID ;
      private Guid AV7SYS_RolePermissionRoleID ;
      private Guid A444SYS_RolePermissionRoleID ;
      private IGxSession AV13WebSession ;
      private GXUserControl ucDvpanel_tableattributes ;
      private IGxDataStore dsDataStore1 ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_datastore1 ;
      private Guid[] T001G4_A444SYS_RolePermissionRoleID ;
      private String[] T001G4_A445SYS_RolePermissionPermissionCode ;
      private Guid[] T001G5_A444SYS_RolePermissionRoleID ;
      private String[] T001G5_A445SYS_RolePermissionPermissionCode ;
      private Guid[] T001G3_A444SYS_RolePermissionRoleID ;
      private String[] T001G3_A445SYS_RolePermissionPermissionCode ;
      private Guid[] T001G6_A444SYS_RolePermissionRoleID ;
      private String[] T001G6_A445SYS_RolePermissionPermissionCode ;
      private Guid[] T001G7_A444SYS_RolePermissionRoleID ;
      private String[] T001G7_A445SYS_RolePermissionPermissionCode ;
      private Guid[] T001G2_A444SYS_RolePermissionRoleID ;
      private String[] T001G2_A445SYS_RolePermissionPermissionCode ;
      private IDataStoreProvider pr_default ;
      private Guid[] T001G10_A444SYS_RolePermissionRoleID ;
      private String[] T001G10_A445SYS_RolePermissionPermissionCode ;
      private GXWebForm Form ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPContext AV9WWPContext ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext AV12TrnContext ;
   }

   public class sys_rolepermission__datastore1 : DataStoreHelperBase, IDataStoreHelper
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
         ,new ForEachCursor(def[8])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmT001G4 ;
          prmT001G4 = new Object[] {
          new Object[] {"@SYS_RolePermissionRoleID",SqlDbType.UniqueIdentifier,16,0} ,
          new Object[] {"@SYS_RolePermissionPermissionCode",SqlDbType.NVarChar,64,0}
          } ;
          Object[] prmT001G5 ;
          prmT001G5 = new Object[] {
          new Object[] {"@SYS_RolePermissionRoleID",SqlDbType.UniqueIdentifier,16,0} ,
          new Object[] {"@SYS_RolePermissionPermissionCode",SqlDbType.NVarChar,64,0}
          } ;
          Object[] prmT001G3 ;
          prmT001G3 = new Object[] {
          new Object[] {"@SYS_RolePermissionRoleID",SqlDbType.UniqueIdentifier,16,0} ,
          new Object[] {"@SYS_RolePermissionPermissionCode",SqlDbType.NVarChar,64,0}
          } ;
          Object[] prmT001G6 ;
          prmT001G6 = new Object[] {
          new Object[] {"@SYS_RolePermissionRoleID",SqlDbType.UniqueIdentifier,16,0} ,
          new Object[] {"@SYS_RolePermissionPermissionCode",SqlDbType.NVarChar,64,0}
          } ;
          Object[] prmT001G7 ;
          prmT001G7 = new Object[] {
          new Object[] {"@SYS_RolePermissionRoleID",SqlDbType.UniqueIdentifier,16,0} ,
          new Object[] {"@SYS_RolePermissionPermissionCode",SqlDbType.NVarChar,64,0}
          } ;
          Object[] prmT001G2 ;
          prmT001G2 = new Object[] {
          new Object[] {"@SYS_RolePermissionRoleID",SqlDbType.UniqueIdentifier,16,0} ,
          new Object[] {"@SYS_RolePermissionPermissionCode",SqlDbType.NVarChar,64,0}
          } ;
          Object[] prmT001G8 ;
          prmT001G8 = new Object[] {
          new Object[] {"@SYS_RolePermissionPermissionCode",SqlDbType.NVarChar,64,0} ,
          new Object[] {"@SYS_RolePermissionRoleID",SqlDbType.UniqueIdentifier,16,0}
          } ;
          Object[] prmT001G9 ;
          prmT001G9 = new Object[] {
          new Object[] {"@SYS_RolePermissionRoleID",SqlDbType.UniqueIdentifier,16,0} ,
          new Object[] {"@SYS_RolePermissionPermissionCode",SqlDbType.NVarChar,64,0}
          } ;
          Object[] prmT001G10 ;
          prmT001G10 = new Object[] {
          } ;
          def= new CursorDef[] {
              new CursorDef("T001G2", "SELECT [RoleID], [PermissionCode] FROM [SYS_RolePermission] WITH (UPDLOCK) WHERE [RoleID] = @SYS_RolePermissionRoleID AND [PermissionCode] = @SYS_RolePermissionPermissionCode ",true, GxErrorMask.GX_NOMASK, false, this,prmT001G2,1,0,true,false )
             ,new CursorDef("T001G3", "SELECT [RoleID], [PermissionCode] FROM [SYS_RolePermission] WITH (NOLOCK) WHERE [RoleID] = @SYS_RolePermissionRoleID AND [PermissionCode] = @SYS_RolePermissionPermissionCode ",true, GxErrorMask.GX_NOMASK, false, this,prmT001G3,1,0,true,false )
             ,new CursorDef("T001G4", "SELECT TM1.[RoleID], TM1.[PermissionCode] FROM [SYS_RolePermission] TM1 WITH (NOLOCK) WHERE TM1.[RoleID] = @SYS_RolePermissionRoleID and TM1.[PermissionCode] = @SYS_RolePermissionPermissionCode ORDER BY TM1.[RoleID], TM1.[PermissionCode]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT001G4,100,0,true,false )
             ,new CursorDef("T001G5", "SELECT [RoleID], [PermissionCode] FROM [SYS_RolePermission] WITH (NOLOCK) WHERE [RoleID] = @SYS_RolePermissionRoleID AND [PermissionCode] = @SYS_RolePermissionPermissionCode  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT001G5,1,0,true,false )
             ,new CursorDef("T001G6", "SELECT TOP 1 [RoleID], [PermissionCode] FROM [SYS_RolePermission] WITH (NOLOCK) WHERE ( [RoleID] > @SYS_RolePermissionRoleID or [RoleID] = @SYS_RolePermissionRoleID and [PermissionCode] > @SYS_RolePermissionPermissionCode) ORDER BY [RoleID], [PermissionCode]  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT001G6,1,0,true,true )
             ,new CursorDef("T001G7", "SELECT TOP 1 [RoleID], [PermissionCode] FROM [SYS_RolePermission] WITH (NOLOCK) WHERE ( [RoleID] < @SYS_RolePermissionRoleID or [RoleID] = @SYS_RolePermissionRoleID and [PermissionCode] < @SYS_RolePermissionPermissionCode) ORDER BY [RoleID] DESC, [PermissionCode] DESC  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT001G7,1,0,true,true )
             ,new CursorDef("T001G8", "INSERT INTO [SYS_RolePermission]([PermissionCode], [RoleID]) VALUES(@SYS_RolePermissionPermissionCode, @SYS_RolePermissionRoleID)", GxErrorMask.GX_NOMASK,prmT001G8)
             ,new CursorDef("T001G9", "DELETE FROM [SYS_RolePermission]  WHERE [RoleID] = @SYS_RolePermissionRoleID AND [PermissionCode] = @SYS_RolePermissionPermissionCode", GxErrorMask.GX_NOMASK,prmT001G9)
             ,new CursorDef("T001G10", "SELECT [RoleID], [PermissionCode] FROM [SYS_RolePermission] WITH (NOLOCK) ORDER BY [RoleID], [PermissionCode]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT001G10,100,0,true,false )
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
                return;
             case 1 :
                ((Guid[]) buf[0])[0] = rslt.getGuid(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                return;
             case 2 :
                ((Guid[]) buf[0])[0] = rslt.getGuid(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                return;
             case 3 :
                ((Guid[]) buf[0])[0] = rslt.getGuid(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                return;
             case 4 :
                ((Guid[]) buf[0])[0] = rslt.getGuid(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                return;
             case 5 :
                ((Guid[]) buf[0])[0] = rslt.getGuid(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                return;
             case 8 :
                ((Guid[]) buf[0])[0] = rslt.getGuid(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
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
                stmt.SetParameter(2, (String)parms[1]);
                return;
             case 1 :
                stmt.SetParameter(1, (Guid)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                return;
             case 2 :
                stmt.SetParameter(1, (Guid)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                return;
             case 3 :
                stmt.SetParameter(1, (Guid)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                return;
             case 4 :
                stmt.SetParameter(1, (Guid)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                return;
             case 5 :
                stmt.SetParameter(1, (Guid)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                return;
             case 6 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (Guid)parms[1]);
                return;
             case 7 :
                stmt.SetParameter(1, (Guid)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                return;
       }
    }

    public String getDataStoreName( )
    {
       return "DATASTORE1";
    }

 }

 public class sys_rolepermission__default : DataStoreHelperBase, IDataStoreHelper
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
