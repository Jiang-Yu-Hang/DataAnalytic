/*
               File: SYS_UserRole
        Description: SYS_User Role
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/27/2020 9:38:50.3
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
   public class sys_userrole : GXDataArea, System.Web.SessionState.IRequiresSessionState
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
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxExecAct_"+"gxLoad_4") == 0 )
         {
            A359UserID = (Guid)(StringUtil.StrToGuid( GetNextPar( )));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A359UserID", A359UserID.ToString());
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            gxLoad_4( A359UserID) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxExecAct_"+"gxLoad_5") == 0 )
         {
            A361RoleID = (Guid)(StringUtil.StrToGuid( GetNextPar( )));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A361RoleID", A361RoleID.ToString());
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            gxLoad_5( A361RoleID) ;
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
            Form.Meta.addItem("description", "SYS_User Role", 0) ;
         }
         context.wjLoc = "";
         context.nUserReturn = 0;
         context.wbHandled = 0;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         GX_FocusControl = edtUserID_Internalname;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         wbErr = false;
         context.SetDefaultTheme("WorkWithPlusTheme");
         if ( ! context.IsLocalStorageSupported( ) )
         {
            context.PushCurrentUrl();
         }
      }

      public sys_userrole( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public sys_userrole( IGxContext context )
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
            GxWebStd.gx_label_ctrl( context, lblTitle_Internalname, "SYS_User Role", "", "", lblTitle_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Title", 0, "", 1, 1, 0, "HLP_SYS_UserRole.htm");
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
            GxWebStd.gx_button_ctrl( context, bttBtn_first_Internalname, "", "|<", bttBtn_first_Jsonclick, 5, "|<", "", StyleString, ClassString, bttBtn_first_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"EFIRST."+"'", TempTags, "", context.GetButtonType( ), "HLP_SYS_UserRole.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 14,'',false,'',0)\"";
            ClassString = "BtnPrevious";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_previous_Internalname, "", "<", bttBtn_previous_Jsonclick, 5, "<", "", StyleString, ClassString, bttBtn_previous_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"EPREVIOUS."+"'", TempTags, "", context.GetButtonType( ), "HLP_SYS_UserRole.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 16,'',false,'',0)\"";
            ClassString = "BtnNext";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_next_Internalname, "", ">", bttBtn_next_Jsonclick, 5, ">", "", StyleString, ClassString, bttBtn_next_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ENEXT."+"'", TempTags, "", context.GetButtonType( ), "HLP_SYS_UserRole.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 18,'',false,'',0)\"";
            ClassString = "BtnLast";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_last_Internalname, "", ">|", bttBtn_last_Jsonclick, 5, ">|", "", StyleString, ClassString, bttBtn_last_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ELAST."+"'", TempTags, "", context.GetButtonType( ), "HLP_SYS_UserRole.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 20,'',false,'',0)\"";
            ClassString = "BtnSelect";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_select_Internalname, "", "选择", bttBtn_select_Jsonclick, 5, "选择", "", StyleString, ClassString, bttBtn_select_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ESELECT."+"'", TempTags, "", 2, "HLP_SYS_UserRole.htm");
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
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtUserID_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtUserID_Internalname, "User ID", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 28,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtUserID_Internalname, A359UserID.ToString(), A359UserID.ToString(), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,28);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtUserID_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtUserID_Enabled, 0, "text", "", 36, "chr", 1, "row", 36, 0, 0, 0, 1, 0, 0, true, "", "", false, "HLP_SYS_UserRole.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
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
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 33,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtRoleID_Internalname, A361RoleID.ToString(), A361RoleID.ToString(), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,33);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtRoleID_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtRoleID_Enabled, 0, "text", "", 36, "chr", 1, "row", 36, 0, 0, 0, 1, 0, 0, true, "", "", false, "HLP_SYS_UserRole.htm");
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
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 38,'',false,'',0)\"";
            ClassString = "BtnEnter";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_enter_Internalname, "", "确认", bttBtn_enter_Jsonclick, 5, "确认", "", StyleString, ClassString, bttBtn_enter_Visible, bttBtn_enter_Enabled, "standard", "'"+""+"'"+",false,"+"'"+"EENTER."+"'", TempTags, "", context.GetButtonType( ), "HLP_SYS_UserRole.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 40,'',false,'',0)\"";
            ClassString = "BtnCancel";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_cancel_Internalname, "", "取消", bttBtn_cancel_Jsonclick, 1, "取消", "", StyleString, ClassString, bttBtn_cancel_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ECANCEL."+"'", TempTags, "", context.GetButtonType( ), "HLP_SYS_UserRole.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 42,'',false,'',0)\"";
            ClassString = "BtnDelete";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_delete_Internalname, "", "删除", bttBtn_delete_Jsonclick, 5, "删除", "", StyleString, ClassString, bttBtn_delete_Visible, bttBtn_delete_Enabled, "standard", "'"+""+"'"+",false,"+"'"+"EDELETE."+"'", TempTags, "", context.GetButtonType( ), "HLP_SYS_UserRole.htm");
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
               if ( StringUtil.StrCmp(cgiGet( edtUserID_Internalname), "") == 0 )
               {
                  A359UserID = (Guid)(Guid.Empty);
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A359UserID", A359UserID.ToString());
               }
               else
               {
                  try
                  {
                     A359UserID = (Guid)(StringUtil.StrToGuid( cgiGet( edtUserID_Internalname)));
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A359UserID", A359UserID.ToString());
                  }
                  catch ( Exception e )
                  {
                     GX_msglist.addItem(context.GetMessage( "GXM_invalidguid", ""), 1, "USERID");
                     AnyError = 1;
                     GX_FocusControl = edtUserID_Internalname;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                     wbErr = true;
                  }
               }
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
               /* Read saved values. */
               Z359UserID = (Guid)(StringUtil.StrToGuid( cgiGet( "Z359UserID")));
               Z361RoleID = (Guid)(StringUtil.StrToGuid( cgiGet( "Z361RoleID")));
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
                  A359UserID = (Guid)(StringUtil.StrToGuid( GetNextPar( )));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A359UserID", A359UserID.ToString());
                  A361RoleID = (Guid)(StringUtil.StrToGuid( GetNextPar( )));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A361RoleID", A361RoleID.ToString());
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
               InitAll1643( ) ;
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
         DisableAttributes1643( ) ;
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

      protected void ResetCaption160( )
      {
      }

      protected void ZM1643( short GX_JID )
      {
         if ( ( GX_JID == 3 ) || ( GX_JID == 0 ) )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
            {
            }
            else
            {
            }
         }
         if ( GX_JID == -3 )
         {
            Z359UserID = (Guid)(A359UserID);
            Z361RoleID = (Guid)(A361RoleID);
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

      protected void Load1643( )
      {
         /* Using cursor T00166 */
         pr_datastore1.execute(4, new Object[] {A359UserID, A361RoleID});
         if ( (pr_datastore1.getStatus(4) != 101) )
         {
            RcdFound43 = 1;
            ZM1643( -3) ;
         }
         pr_datastore1.close(4);
         OnLoadActions1643( ) ;
      }

      protected void OnLoadActions1643( )
      {
      }

      protected void CheckExtendedTable1643( )
      {
         Gx_BScreen = 1;
         standaloneModal( ) ;
         /* Using cursor T00164 */
         pr_datastore1.execute(2, new Object[] {A359UserID});
         if ( (pr_datastore1.getStatus(2) == 101) )
         {
            GX_msglist.addItem("不匹配'SYS_User'", "ForeignKeyNotFound", 1, "USERID");
            AnyError = 1;
            GX_FocusControl = edtUserID_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         pr_datastore1.close(2);
         /* Using cursor T00165 */
         pr_datastore1.execute(3, new Object[] {A361RoleID});
         if ( (pr_datastore1.getStatus(3) == 101) )
         {
            GX_msglist.addItem("不匹配'SYS_Role'", "ForeignKeyNotFound", 1, "ROLEID");
            AnyError = 1;
            GX_FocusControl = edtRoleID_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         pr_datastore1.close(3);
      }

      protected void CloseExtendedTableCursors1643( )
      {
         pr_datastore1.close(2);
         pr_datastore1.close(3);
      }

      protected void enableDisable( )
      {
      }

      protected void gxLoad_4( Guid A359UserID )
      {
         /* Using cursor T00167 */
         pr_datastore1.execute(5, new Object[] {A359UserID});
         if ( (pr_datastore1.getStatus(5) == 101) )
         {
            GX_msglist.addItem("不匹配'SYS_User'", "ForeignKeyNotFound", 1, "USERID");
            AnyError = 1;
            GX_FocusControl = edtUserID_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("[[");
         context.GX_webresponse.AddString("");
         context.GX_webresponse.AddString("]");
         if ( (pr_datastore1.getStatus(5) == 101) )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString("]");
         pr_datastore1.close(5);
      }

      protected void gxLoad_5( Guid A361RoleID )
      {
         /* Using cursor T00168 */
         pr_datastore1.execute(6, new Object[] {A361RoleID});
         if ( (pr_datastore1.getStatus(6) == 101) )
         {
            GX_msglist.addItem("不匹配'SYS_Role'", "ForeignKeyNotFound", 1, "ROLEID");
            AnyError = 1;
            GX_FocusControl = edtRoleID_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("[[");
         context.GX_webresponse.AddString("");
         context.GX_webresponse.AddString("]");
         if ( (pr_datastore1.getStatus(6) == 101) )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString("]");
         pr_datastore1.close(6);
      }

      protected void GetKey1643( )
      {
         /* Using cursor T00169 */
         pr_datastore1.execute(7, new Object[] {A359UserID, A361RoleID});
         if ( (pr_datastore1.getStatus(7) != 101) )
         {
            RcdFound43 = 1;
         }
         else
         {
            RcdFound43 = 0;
         }
         pr_datastore1.close(7);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor T00163 */
         pr_datastore1.execute(1, new Object[] {A359UserID, A361RoleID});
         if ( (pr_datastore1.getStatus(1) != 101) )
         {
            ZM1643( 3) ;
            RcdFound43 = 1;
            A359UserID = (Guid)((Guid)(T00163_A359UserID[0]));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A359UserID", A359UserID.ToString());
            A361RoleID = (Guid)((Guid)(T00163_A361RoleID[0]));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A361RoleID", A361RoleID.ToString());
            Z359UserID = (Guid)(A359UserID);
            Z361RoleID = (Guid)(A361RoleID);
            sMode43 = Gx_mode;
            Gx_mode = "DSP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            standaloneModal( ) ;
            Load1643( ) ;
            if ( AnyError == 1 )
            {
               RcdFound43 = 0;
               InitializeNonKey1643( ) ;
            }
            Gx_mode = sMode43;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         else
         {
            RcdFound43 = 0;
            InitializeNonKey1643( ) ;
            sMode43 = Gx_mode;
            Gx_mode = "DSP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            standaloneModal( ) ;
            Gx_mode = sMode43;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         pr_datastore1.close(1);
      }

      protected void getEqualNoModal( )
      {
         GetKey1643( ) ;
         if ( RcdFound43 == 0 )
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
         RcdFound43 = 0;
         /* Using cursor T001610 */
         pr_datastore1.execute(8, new Object[] {A359UserID, A361RoleID});
         if ( (pr_datastore1.getStatus(8) != 101) )
         {
            while ( (pr_datastore1.getStatus(8) != 101) && ( ( GuidUtil.Compare(T001610_A359UserID[0], A359UserID, 1) < 0 ) || ( T001610_A359UserID[0] == A359UserID ) && ( GuidUtil.Compare(T001610_A361RoleID[0], A361RoleID, 1) < 0 ) ) )
            {
               pr_datastore1.readNext(8);
            }
            if ( (pr_datastore1.getStatus(8) != 101) && ( ( GuidUtil.Compare(T001610_A359UserID[0], A359UserID, 1) > 0 ) || ( T001610_A359UserID[0] == A359UserID ) && ( GuidUtil.Compare(T001610_A361RoleID[0], A361RoleID, 1) > 0 ) ) )
            {
               A359UserID = (Guid)((Guid)(T001610_A359UserID[0]));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A359UserID", A359UserID.ToString());
               A361RoleID = (Guid)((Guid)(T001610_A361RoleID[0]));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A361RoleID", A361RoleID.ToString());
               RcdFound43 = 1;
            }
         }
         pr_datastore1.close(8);
      }

      protected void move_previous( )
      {
         RcdFound43 = 0;
         /* Using cursor T001611 */
         pr_datastore1.execute(9, new Object[] {A359UserID, A361RoleID});
         if ( (pr_datastore1.getStatus(9) != 101) )
         {
            while ( (pr_datastore1.getStatus(9) != 101) && ( ( GuidUtil.Compare(T001611_A359UserID[0], A359UserID, 1) > 0 ) || ( T001611_A359UserID[0] == A359UserID ) && ( GuidUtil.Compare(T001611_A361RoleID[0], A361RoleID, 1) > 0 ) ) )
            {
               pr_datastore1.readNext(9);
            }
            if ( (pr_datastore1.getStatus(9) != 101) && ( ( GuidUtil.Compare(T001611_A359UserID[0], A359UserID, 1) < 0 ) || ( T001611_A359UserID[0] == A359UserID ) && ( GuidUtil.Compare(T001611_A361RoleID[0], A361RoleID, 1) < 0 ) ) )
            {
               A359UserID = (Guid)((Guid)(T001611_A359UserID[0]));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A359UserID", A359UserID.ToString());
               A361RoleID = (Guid)((Guid)(T001611_A361RoleID[0]));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A361RoleID", A361RoleID.ToString());
               RcdFound43 = 1;
            }
         }
         pr_datastore1.close(9);
      }

      protected void btn_enter( )
      {
         nKeyPressed = 1;
         GetKey1643( ) ;
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            /* Insert record */
            GX_FocusControl = edtUserID_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            Insert1643( ) ;
            if ( AnyError == 1 )
            {
               GX_FocusControl = "";
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
         }
         else
         {
            if ( RcdFound43 == 1 )
            {
               if ( ( A359UserID != Z359UserID ) || ( A361RoleID != Z361RoleID ) )
               {
                  A359UserID = (Guid)(Z359UserID);
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A359UserID", A359UserID.ToString());
                  A361RoleID = (Guid)(Z361RoleID);
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A361RoleID", A361RoleID.ToString());
                  GX_msglist.addItem(context.GetMessage( "GXM_getbeforeupd", ""), "CandidateKeyNotFound", 1, "USERID");
                  AnyError = 1;
                  GX_FocusControl = edtUserID_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
               else if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
               {
                  delete( ) ;
                  AfterTrn( ) ;
                  GX_FocusControl = edtUserID_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
               else
               {
                  Gx_mode = "UPD";
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                  /* Update record */
                  Update1643( ) ;
                  GX_FocusControl = edtUserID_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
            }
            else
            {
               if ( ( A359UserID != Z359UserID ) || ( A361RoleID != Z361RoleID ) )
               {
                  Gx_mode = "INS";
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                  /* Insert record */
                  GX_FocusControl = edtUserID_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  Insert1643( ) ;
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
                     GX_msglist.addItem(context.GetMessage( "GXM_recdeleted", ""), 1, "USERID");
                     AnyError = 1;
                     GX_FocusControl = edtUserID_Internalname;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  }
                  else
                  {
                     Gx_mode = "INS";
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                     /* Insert record */
                     GX_FocusControl = edtUserID_Internalname;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                     Insert1643( ) ;
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
         if ( ( A359UserID != Z359UserID ) || ( A361RoleID != Z361RoleID ) )
         {
            A359UserID = (Guid)(Z359UserID);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A359UserID", A359UserID.ToString());
            A361RoleID = (Guid)(Z361RoleID);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A361RoleID", A361RoleID.ToString());
            GX_msglist.addItem(context.GetMessage( "GXM_getbeforedlt", ""), 1, "USERID");
            AnyError = 1;
            GX_FocusControl = edtUserID_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         else
         {
            delete( ) ;
            AfterTrn( ) ;
            GX_FocusControl = edtUserID_Internalname;
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
         if ( RcdFound43 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_keynfound", ""), "PrimaryKeyNotFound", 1, "USERID");
            AnyError = 1;
            GX_FocusControl = edtUserID_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_first( )
      {
         nKeyPressed = 2;
         IsConfirmed = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "IsConfirmed", StringUtil.LTrim( StringUtil.Str( (decimal)(IsConfirmed), 4, 0)));
         ScanStart1643( ) ;
         if ( RcdFound43 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "", true);
         }
         else
         {
            Gx_mode = "UPD";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         ScanEnd1643( ) ;
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
         if ( RcdFound43 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "", true);
         }
         else
         {
            Gx_mode = "UPD";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
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
         if ( RcdFound43 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "", true);
         }
         else
         {
            Gx_mode = "UPD";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         getByPrimaryKey( ) ;
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_last( )
      {
         nKeyPressed = 2;
         IsConfirmed = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "IsConfirmed", StringUtil.LTrim( StringUtil.Str( (decimal)(IsConfirmed), 4, 0)));
         ScanStart1643( ) ;
         if ( RcdFound43 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "", true);
         }
         else
         {
            while ( RcdFound43 != 0 )
            {
               ScanNext1643( ) ;
            }
            Gx_mode = "UPD";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         ScanEnd1643( ) ;
         getByPrimaryKey( ) ;
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_select( )
      {
         getEqualNoModal( ) ;
      }

      protected void CheckOptimisticConcurrency1643( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor T00162 */
            pr_datastore1.execute(0, new Object[] {A359UserID, A361RoleID});
            if ( (pr_datastore1.getStatus(0) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"SYS_USERROLE"}), "RecordIsLocked", 1, "");
               AnyError = 1;
               return  ;
            }
            if ( (pr_datastore1.getStatus(0) == 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"SYS_USERROLE"}), "RecordWasChanged", 1, "");
               AnyError = 1;
               return  ;
            }
         }
      }

      protected void Insert1643( )
      {
         BeforeValidate1643( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable1643( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM1643( 0) ;
            CheckOptimisticConcurrency1643( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm1643( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert1643( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T001612 */
                     pr_datastore1.execute(10, new Object[] {A359UserID, A361RoleID});
                     pr_datastore1.close(10);
                     dsDataStore1.SmartCacheProvider.SetUpdated("SYS_USERROLE") ;
                     if ( (pr_datastore1.getStatus(10) == 1) )
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
                           ResetCaption160( ) ;
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
               Load1643( ) ;
            }
            EndLevel1643( ) ;
         }
         CloseExtendedTableCursors1643( ) ;
      }

      protected void Update1643( )
      {
         BeforeValidate1643( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable1643( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency1643( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm1643( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate1643( ) ;
                  if ( AnyError == 0 )
                  {
                     /* No attributes to update on table dbo.[SYS_UserRole] */
                     DeferredUpdate1643( ) ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( update) rules */
                        /* End of After( update) rules */
                        if ( AnyError == 0 )
                        {
                           getByPrimaryKey( ) ;
                           GX_msglist.addItem(context.GetMessage( "GXM_sucupdated", ""), "SuccessfullyUpdated", 0, "", true);
                           ResetCaption160( ) ;
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
            EndLevel1643( ) ;
         }
         CloseExtendedTableCursors1643( ) ;
      }

      protected void DeferredUpdate1643( )
      {
      }

      protected void delete( )
      {
         Gx_mode = "DLT";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         BeforeValidate1643( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency1643( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls1643( ) ;
            AfterConfirm1643( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete1643( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor T001613 */
                  pr_datastore1.execute(11, new Object[] {A359UserID, A361RoleID});
                  pr_datastore1.close(11);
                  dsDataStore1.SmartCacheProvider.SetUpdated("SYS_USERROLE") ;
                  if ( AnyError == 0 )
                  {
                     /* Start of After( delete) rules */
                     /* End of After( delete) rules */
                     if ( AnyError == 0 )
                     {
                        move_next( ) ;
                        if ( RcdFound43 == 0 )
                        {
                           InitAll1643( ) ;
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
                        ResetCaption160( ) ;
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
         sMode43 = Gx_mode;
         Gx_mode = "DLT";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         EndLevel1643( ) ;
         Gx_mode = sMode43;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
      }

      protected void OnDeleteControls1643( )
      {
         standaloneModal( ) ;
         /* No delete mode formulas found. */
      }

      protected void EndLevel1643( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            pr_datastore1.close(0);
         }
         if ( AnyError == 0 )
         {
            BeforeComplete1643( ) ;
         }
         if ( AnyError == 0 )
         {
            pr_datastore1.close(1);
            context.CommitDataStores("sys_userrole",pr_default);
            if ( AnyError == 0 )
            {
               ConfirmValues160( ) ;
            }
            /* After transaction rules */
            /* Execute 'After Trn' event if defined. */
            trnEnded = 1;
         }
         else
         {
            pr_datastore1.close(1);
            context.RollbackDataStores("sys_userrole",pr_default);
         }
         IsModified = 0;
         if ( AnyError != 0 )
         {
            context.wjLoc = "";
            context.nUserReturn = 0;
         }
      }

      public void ScanStart1643( )
      {
         /* Using cursor T001614 */
         pr_datastore1.execute(12);
         RcdFound43 = 0;
         if ( (pr_datastore1.getStatus(12) != 101) )
         {
            RcdFound43 = 1;
            A359UserID = (Guid)((Guid)(T001614_A359UserID[0]));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A359UserID", A359UserID.ToString());
            A361RoleID = (Guid)((Guid)(T001614_A361RoleID[0]));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A361RoleID", A361RoleID.ToString());
         }
         /* Load Subordinate Levels */
      }

      protected void ScanNext1643( )
      {
         /* Scan next routine */
         pr_datastore1.readNext(12);
         RcdFound43 = 0;
         if ( (pr_datastore1.getStatus(12) != 101) )
         {
            RcdFound43 = 1;
            A359UserID = (Guid)((Guid)(T001614_A359UserID[0]));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A359UserID", A359UserID.ToString());
            A361RoleID = (Guid)((Guid)(T001614_A361RoleID[0]));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A361RoleID", A361RoleID.ToString());
         }
      }

      protected void ScanEnd1643( )
      {
         pr_datastore1.close(12);
      }

      protected void AfterConfirm1643( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert1643( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate1643( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete1643( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete1643( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate1643( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes1643( )
      {
         edtUserID_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtUserID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtUserID_Enabled), 5, 0)), true);
         edtRoleID_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtRoleID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtRoleID_Enabled), 5, 0)), true);
      }

      protected void send_integrity_lvl_hashes1643( )
      {
      }

      protected void assign_properties_default( )
      {
      }

      protected void ConfirmValues160( )
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
         context.AddJavascriptSource("gxcfg.js", "?20202279385067", false);
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" autocomplete=\"off\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("sys_userrole.aspx") +"\">") ;
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
         GxWebStd.gx_hidden_field( context, "Z359UserID", Z359UserID.ToString());
         GxWebStd.gx_hidden_field( context, "Z361RoleID", Z361RoleID.ToString());
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
         return formatLink("sys_userrole.aspx")  ;
      }

      public override String GetPgmname( )
      {
         return "SYS_UserRole" ;
      }

      public override String GetPgmdesc( )
      {
         return "SYS_User Role" ;
      }

      protected void InitializeNonKey1643( )
      {
      }

      protected void InitAll1643( )
      {
         A359UserID = (Guid)(Guid.Empty);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A359UserID", A359UserID.ToString());
         A361RoleID = (Guid)(Guid.Empty);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A361RoleID", A361RoleID.ToString());
         InitializeNonKey1643( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?20202279385071", true);
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
         context.AddJavascriptSource("sys_userrole.js", "?20202279385072", false);
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
         edtUserID_Internalname = "USERID";
         edtRoleID_Internalname = "ROLEID";
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
         Form.Caption = "SYS_User Role";
         bttBtn_delete_Enabled = 1;
         bttBtn_delete_Visible = 1;
         bttBtn_cancel_Visible = 1;
         bttBtn_enter_Enabled = 1;
         bttBtn_enter_Visible = 1;
         edtRoleID_Jsonclick = "";
         edtRoleID_Enabled = 1;
         edtUserID_Jsonclick = "";
         edtUserID_Enabled = 1;
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
         /* Using cursor T001615 */
         pr_datastore1.execute(13, new Object[] {A359UserID});
         if ( (pr_datastore1.getStatus(13) == 101) )
         {
            GX_msglist.addItem("不匹配'SYS_User'", "ForeignKeyNotFound", 1, "USERID");
            AnyError = 1;
            GX_FocusControl = edtUserID_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         pr_datastore1.close(13);
         /* Using cursor T001616 */
         pr_datastore1.execute(14, new Object[] {A361RoleID});
         if ( (pr_datastore1.getStatus(14) == 101) )
         {
            GX_msglist.addItem("不匹配'SYS_Role'", "ForeignKeyNotFound", 1, "ROLEID");
            AnyError = 1;
            GX_FocusControl = edtRoleID_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         pr_datastore1.close(14);
         if ( AnyError == 0 )
         {
            GX_FocusControl = "";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         standaloneNotModal( ) ;
         standaloneModal( ) ;
         /* End function AfterKeyLoadScreen */
      }

      public void Valid_Userid( Guid GX_Parm1 )
      {
         A359UserID = (Guid)(GX_Parm1);
         /* Using cursor T001615 */
         pr_datastore1.execute(13, new Object[] {A359UserID});
         if ( (pr_datastore1.getStatus(13) == 101) )
         {
            GX_msglist.addItem("不匹配'SYS_User'", "ForeignKeyNotFound", 1, "USERID");
            AnyError = 1;
            GX_FocusControl = edtUserID_Internalname;
         }
         pr_datastore1.close(13);
         dynload_actions( ) ;
         isValidOutput.Add(context.GX_msglist.ToJavascriptSource());
         isValidOutput.Add(context.httpAjaxContext.ajax_rsp_get_hiddens( ));
         context.GX_webresponse.AddString(isValidOutput.ToJSonString());
         wbTemp = context.ResponseContentType( "application/json");
      }

      public void Valid_Roleid( Guid GX_Parm1 ,
                                Guid GX_Parm2 )
      {
         A359UserID = (Guid)(GX_Parm1);
         A361RoleID = (Guid)(GX_Parm2);
         context.wbHandled = 1;
         AfterKeyLoadScreen( ) ;
         Draw( ) ;
         send_integrity_footer_hashes( ) ;
         /* Using cursor T001616 */
         pr_datastore1.execute(14, new Object[] {A361RoleID});
         if ( (pr_datastore1.getStatus(14) == 101) )
         {
            GX_msglist.addItem("不匹配'SYS_Role'", "ForeignKeyNotFound", 1, "ROLEID");
            AnyError = 1;
            GX_FocusControl = edtRoleID_Internalname;
         }
         pr_datastore1.close(14);
         dynload_actions( ) ;
         if ( AnyError == 1 )
         {
         }
         isValidOutput.Add(StringUtil.RTrim( Gx_mode));
         isValidOutput.Add(Z359UserID.ToString());
         isValidOutput.Add(Z361RoleID.ToString());
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
         pr_datastore1.close(13);
         pr_datastore1.close(14);
      }

      public override void initialize( )
      {
         sPrefix = "";
         Z359UserID = (Guid)(Guid.Empty);
         Z361RoleID = (Guid)(Guid.Empty);
         scmdbuf = "";
         gxfirstwebparm = "";
         gxfirstwebparm_bkp = "";
         A359UserID = (Guid)(Guid.Empty);
         A361RoleID = (Guid)(Guid.Empty);
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
         bttBtn_enter_Jsonclick = "";
         bttBtn_cancel_Jsonclick = "";
         bttBtn_delete_Jsonclick = "";
         Gx_mode = "";
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         T00166_A359UserID = new Guid[] {Guid.Empty} ;
         T00166_A361RoleID = new Guid[] {Guid.Empty} ;
         T00164_A359UserID = new Guid[] {Guid.Empty} ;
         T00165_A361RoleID = new Guid[] {Guid.Empty} ;
         T00167_A359UserID = new Guid[] {Guid.Empty} ;
         T00168_A361RoleID = new Guid[] {Guid.Empty} ;
         T00169_A359UserID = new Guid[] {Guid.Empty} ;
         T00169_A361RoleID = new Guid[] {Guid.Empty} ;
         T00163_A359UserID = new Guid[] {Guid.Empty} ;
         T00163_A361RoleID = new Guid[] {Guid.Empty} ;
         sMode43 = "";
         T001610_A359UserID = new Guid[] {Guid.Empty} ;
         T001610_A361RoleID = new Guid[] {Guid.Empty} ;
         T001611_A359UserID = new Guid[] {Guid.Empty} ;
         T001611_A361RoleID = new Guid[] {Guid.Empty} ;
         T00162_A359UserID = new Guid[] {Guid.Empty} ;
         T00162_A361RoleID = new Guid[] {Guid.Empty} ;
         T001614_A359UserID = new Guid[] {Guid.Empty} ;
         T001614_A361RoleID = new Guid[] {Guid.Empty} ;
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         T001615_A359UserID = new Guid[] {Guid.Empty} ;
         T001616_A361RoleID = new Guid[] {Guid.Empty} ;
         isValidOutput = new GxUnknownObjectCollection();
         pr_datastore1 = new DataStoreProvider(context, new GeneXus.Programs.sys_userrole__datastore1(),
            new Object[][] {
                new Object[] {
               T00162_A359UserID, T00162_A361RoleID
               }
               , new Object[] {
               T00163_A359UserID, T00163_A361RoleID
               }
               , new Object[] {
               T00164_A359UserID
               }
               , new Object[] {
               T00165_A361RoleID
               }
               , new Object[] {
               T00166_A359UserID, T00166_A361RoleID
               }
               , new Object[] {
               T00167_A359UserID
               }
               , new Object[] {
               T00168_A361RoleID
               }
               , new Object[] {
               T00169_A359UserID, T00169_A361RoleID
               }
               , new Object[] {
               T001610_A359UserID, T001610_A361RoleID
               }
               , new Object[] {
               T001611_A359UserID, T001611_A361RoleID
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               T001614_A359UserID, T001614_A361RoleID
               }
               , new Object[] {
               T001615_A359UserID
               }
               , new Object[] {
               T001616_A361RoleID
               }
            }
         );
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.sys_userrole__default(),
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
      private short RcdFound43 ;
      private short Gx_BScreen ;
      private short gxajaxcallmode ;
      private short wbTemp ;
      private int trnEnded ;
      private int bttBtn_first_Visible ;
      private int bttBtn_previous_Visible ;
      private int bttBtn_next_Visible ;
      private int bttBtn_last_Visible ;
      private int bttBtn_select_Visible ;
      private int edtUserID_Enabled ;
      private int edtRoleID_Enabled ;
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
      private String edtUserID_Internalname ;
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
      private String edtUserID_Jsonclick ;
      private String edtRoleID_Internalname ;
      private String edtRoleID_Jsonclick ;
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
      private String sMode43 ;
      private String sDynURL ;
      private String FormProcess ;
      private String bodyStyle ;
      private bool entryPointCalled ;
      private bool toggleJsOutput ;
      private bool wbErr ;
      private Guid Z359UserID ;
      private Guid Z361RoleID ;
      private Guid A359UserID ;
      private Guid A361RoleID ;
      private GxUnknownObjectCollection isValidOutput ;
      private IGxDataStore dsDataStore1 ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_datastore1 ;
      private Guid[] T00166_A359UserID ;
      private Guid[] T00166_A361RoleID ;
      private Guid[] T00164_A359UserID ;
      private Guid[] T00165_A361RoleID ;
      private Guid[] T00167_A359UserID ;
      private Guid[] T00168_A361RoleID ;
      private Guid[] T00169_A359UserID ;
      private Guid[] T00169_A361RoleID ;
      private Guid[] T00163_A359UserID ;
      private Guid[] T00163_A361RoleID ;
      private Guid[] T001610_A359UserID ;
      private Guid[] T001610_A361RoleID ;
      private Guid[] T001611_A359UserID ;
      private Guid[] T001611_A361RoleID ;
      private Guid[] T00162_A359UserID ;
      private Guid[] T00162_A361RoleID ;
      private IDataStoreProvider pr_default ;
      private Guid[] T001614_A359UserID ;
      private Guid[] T001614_A361RoleID ;
      private Guid[] T001615_A359UserID ;
      private Guid[] T001616_A361RoleID ;
      private GXWebForm Form ;
   }

   public class sys_userrole__datastore1 : DataStoreHelperBase, IDataStoreHelper
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
         ,new ForEachCursor(def[7])
         ,new ForEachCursor(def[8])
         ,new ForEachCursor(def[9])
         ,new UpdateCursor(def[10])
         ,new UpdateCursor(def[11])
         ,new ForEachCursor(def[12])
         ,new ForEachCursor(def[13])
         ,new ForEachCursor(def[14])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmT00166 ;
          prmT00166 = new Object[] {
          new Object[] {"@UserID",SqlDbType.UniqueIdentifier,16,0} ,
          new Object[] {"@RoleID",SqlDbType.UniqueIdentifier,16,0}
          } ;
          Object[] prmT00164 ;
          prmT00164 = new Object[] {
          new Object[] {"@UserID",SqlDbType.UniqueIdentifier,16,0}
          } ;
          Object[] prmT00165 ;
          prmT00165 = new Object[] {
          new Object[] {"@RoleID",SqlDbType.UniqueIdentifier,16,0}
          } ;
          Object[] prmT00167 ;
          prmT00167 = new Object[] {
          new Object[] {"@UserID",SqlDbType.UniqueIdentifier,16,0}
          } ;
          Object[] prmT00168 ;
          prmT00168 = new Object[] {
          new Object[] {"@RoleID",SqlDbType.UniqueIdentifier,16,0}
          } ;
          Object[] prmT00169 ;
          prmT00169 = new Object[] {
          new Object[] {"@UserID",SqlDbType.UniqueIdentifier,16,0} ,
          new Object[] {"@RoleID",SqlDbType.UniqueIdentifier,16,0}
          } ;
          Object[] prmT00163 ;
          prmT00163 = new Object[] {
          new Object[] {"@UserID",SqlDbType.UniqueIdentifier,16,0} ,
          new Object[] {"@RoleID",SqlDbType.UniqueIdentifier,16,0}
          } ;
          Object[] prmT001610 ;
          prmT001610 = new Object[] {
          new Object[] {"@UserID",SqlDbType.UniqueIdentifier,16,0} ,
          new Object[] {"@RoleID",SqlDbType.UniqueIdentifier,16,0}
          } ;
          Object[] prmT001611 ;
          prmT001611 = new Object[] {
          new Object[] {"@UserID",SqlDbType.UniqueIdentifier,16,0} ,
          new Object[] {"@RoleID",SqlDbType.UniqueIdentifier,16,0}
          } ;
          Object[] prmT00162 ;
          prmT00162 = new Object[] {
          new Object[] {"@UserID",SqlDbType.UniqueIdentifier,16,0} ,
          new Object[] {"@RoleID",SqlDbType.UniqueIdentifier,16,0}
          } ;
          Object[] prmT001612 ;
          prmT001612 = new Object[] {
          new Object[] {"@UserID",SqlDbType.UniqueIdentifier,16,0} ,
          new Object[] {"@RoleID",SqlDbType.UniqueIdentifier,16,0}
          } ;
          Object[] prmT001613 ;
          prmT001613 = new Object[] {
          new Object[] {"@UserID",SqlDbType.UniqueIdentifier,16,0} ,
          new Object[] {"@RoleID",SqlDbType.UniqueIdentifier,16,0}
          } ;
          Object[] prmT001614 ;
          prmT001614 = new Object[] {
          } ;
          Object[] prmT001615 ;
          prmT001615 = new Object[] {
          new Object[] {"@UserID",SqlDbType.UniqueIdentifier,16,0}
          } ;
          Object[] prmT001616 ;
          prmT001616 = new Object[] {
          new Object[] {"@RoleID",SqlDbType.UniqueIdentifier,16,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("T00162", "SELECT [UserID], [RoleID] FROM dbo.[SYS_UserRole] WITH (UPDLOCK) WHERE [UserID] = @UserID AND [RoleID] = @RoleID ",true, GxErrorMask.GX_NOMASK, false, this,prmT00162,1,0,true,false )
             ,new CursorDef("T00163", "SELECT [UserID], [RoleID] FROM dbo.[SYS_UserRole] WITH (NOLOCK) WHERE [UserID] = @UserID AND [RoleID] = @RoleID ",true, GxErrorMask.GX_NOMASK, false, this,prmT00163,1,0,true,false )
             ,new CursorDef("T00164", "SELECT [UserID] FROM dbo.[SYS_User] WITH (NOLOCK) WHERE [UserID] = @UserID ",true, GxErrorMask.GX_NOMASK, false, this,prmT00164,1,0,true,false )
             ,new CursorDef("T00165", "SELECT [RoleID] FROM dbo.[SYS_Role] WITH (NOLOCK) WHERE [RoleID] = @RoleID ",true, GxErrorMask.GX_NOMASK, false, this,prmT00165,1,0,true,false )
             ,new CursorDef("T00166", "SELECT TM1.[UserID], TM1.[RoleID] FROM dbo.[SYS_UserRole] TM1 WITH (NOLOCK) WHERE TM1.[UserID] = @UserID and TM1.[RoleID] = @RoleID ORDER BY TM1.[UserID], TM1.[RoleID]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT00166,100,0,true,false )
             ,new CursorDef("T00167", "SELECT [UserID] FROM dbo.[SYS_User] WITH (NOLOCK) WHERE [UserID] = @UserID ",true, GxErrorMask.GX_NOMASK, false, this,prmT00167,1,0,true,false )
             ,new CursorDef("T00168", "SELECT [RoleID] FROM dbo.[SYS_Role] WITH (NOLOCK) WHERE [RoleID] = @RoleID ",true, GxErrorMask.GX_NOMASK, false, this,prmT00168,1,0,true,false )
             ,new CursorDef("T00169", "SELECT [UserID], [RoleID] FROM dbo.[SYS_UserRole] WITH (NOLOCK) WHERE [UserID] = @UserID AND [RoleID] = @RoleID  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT00169,1,0,true,false )
             ,new CursorDef("T001610", "SELECT TOP 1 [UserID], [RoleID] FROM dbo.[SYS_UserRole] WITH (NOLOCK) WHERE ( [UserID] > @UserID or [UserID] = @UserID and [RoleID] > @RoleID) ORDER BY [UserID], [RoleID]  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT001610,1,0,true,true )
             ,new CursorDef("T001611", "SELECT TOP 1 [UserID], [RoleID] FROM dbo.[SYS_UserRole] WITH (NOLOCK) WHERE ( [UserID] < @UserID or [UserID] = @UserID and [RoleID] < @RoleID) ORDER BY [UserID] DESC, [RoleID] DESC  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT001611,1,0,true,true )
             ,new CursorDef("T001612", "INSERT INTO dbo.[SYS_UserRole]([UserID], [RoleID]) VALUES(@UserID, @RoleID)", GxErrorMask.GX_NOMASK,prmT001612)
             ,new CursorDef("T001613", "DELETE FROM dbo.[SYS_UserRole]  WHERE [UserID] = @UserID AND [RoleID] = @RoleID", GxErrorMask.GX_NOMASK,prmT001613)
             ,new CursorDef("T001614", "SELECT [UserID], [RoleID] FROM dbo.[SYS_UserRole] WITH (NOLOCK) ORDER BY [UserID], [RoleID]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT001614,100,0,true,false )
             ,new CursorDef("T001615", "SELECT [UserID] FROM dbo.[SYS_User] WITH (NOLOCK) WHERE [UserID] = @UserID ",true, GxErrorMask.GX_NOMASK, false, this,prmT001615,1,0,true,false )
             ,new CursorDef("T001616", "SELECT [RoleID] FROM dbo.[SYS_Role] WITH (NOLOCK) WHERE [RoleID] = @RoleID ",true, GxErrorMask.GX_NOMASK, false, this,prmT001616,1,0,true,false )
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
                return;
             case 1 :
                ((Guid[]) buf[0])[0] = rslt.getGuid(1) ;
                ((Guid[]) buf[1])[0] = rslt.getGuid(2) ;
                return;
             case 2 :
                ((Guid[]) buf[0])[0] = rslt.getGuid(1) ;
                return;
             case 3 :
                ((Guid[]) buf[0])[0] = rslt.getGuid(1) ;
                return;
             case 4 :
                ((Guid[]) buf[0])[0] = rslt.getGuid(1) ;
                ((Guid[]) buf[1])[0] = rslt.getGuid(2) ;
                return;
             case 5 :
                ((Guid[]) buf[0])[0] = rslt.getGuid(1) ;
                return;
             case 6 :
                ((Guid[]) buf[0])[0] = rslt.getGuid(1) ;
                return;
             case 7 :
                ((Guid[]) buf[0])[0] = rslt.getGuid(1) ;
                ((Guid[]) buf[1])[0] = rslt.getGuid(2) ;
                return;
             case 8 :
                ((Guid[]) buf[0])[0] = rslt.getGuid(1) ;
                ((Guid[]) buf[1])[0] = rslt.getGuid(2) ;
                return;
             case 9 :
                ((Guid[]) buf[0])[0] = rslt.getGuid(1) ;
                ((Guid[]) buf[1])[0] = rslt.getGuid(2) ;
                return;
             case 12 :
                ((Guid[]) buf[0])[0] = rslt.getGuid(1) ;
                ((Guid[]) buf[1])[0] = rslt.getGuid(2) ;
                return;
             case 13 :
                ((Guid[]) buf[0])[0] = rslt.getGuid(1) ;
                return;
             case 14 :
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
                stmt.SetParameter(2, (Guid)parms[1]);
                return;
             case 1 :
                stmt.SetParameter(1, (Guid)parms[0]);
                stmt.SetParameter(2, (Guid)parms[1]);
                return;
             case 2 :
                stmt.SetParameter(1, (Guid)parms[0]);
                return;
             case 3 :
                stmt.SetParameter(1, (Guid)parms[0]);
                return;
             case 4 :
                stmt.SetParameter(1, (Guid)parms[0]);
                stmt.SetParameter(2, (Guid)parms[1]);
                return;
             case 5 :
                stmt.SetParameter(1, (Guid)parms[0]);
                return;
             case 6 :
                stmt.SetParameter(1, (Guid)parms[0]);
                return;
             case 7 :
                stmt.SetParameter(1, (Guid)parms[0]);
                stmt.SetParameter(2, (Guid)parms[1]);
                return;
             case 8 :
                stmt.SetParameter(1, (Guid)parms[0]);
                stmt.SetParameter(2, (Guid)parms[1]);
                return;
             case 9 :
                stmt.SetParameter(1, (Guid)parms[0]);
                stmt.SetParameter(2, (Guid)parms[1]);
                return;
             case 10 :
                stmt.SetParameter(1, (Guid)parms[0]);
                stmt.SetParameter(2, (Guid)parms[1]);
                return;
             case 11 :
                stmt.SetParameter(1, (Guid)parms[0]);
                stmt.SetParameter(2, (Guid)parms[1]);
                return;
             case 13 :
                stmt.SetParameter(1, (Guid)parms[0]);
                return;
             case 14 :
                stmt.SetParameter(1, (Guid)parms[0]);
                return;
       }
    }

    public String getDataStoreName( )
    {
       return "DATASTORE1";
    }

 }

 public class sys_userrole__default : DataStoreHelperBase, IDataStoreHelper
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
