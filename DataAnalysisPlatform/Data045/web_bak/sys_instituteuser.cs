/*
               File: SYS_InstituteUser
        Description: SYS_Institute User
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/27/2020 9:38:57.55
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
   public class sys_instituteuser : GXDataArea, System.Web.SessionState.IRequiresSessionState
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
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxExecAct_"+"gxLoad_3") == 0 )
         {
            A358InstituteCode = GetNextPar( );
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A358InstituteCode", A358InstituteCode);
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            gxLoad_3( A358InstituteCode) ;
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
            Form.Meta.addItem("description", "SYS_Institute User", 0) ;
         }
         context.wjLoc = "";
         context.nUserReturn = 0;
         context.wbHandled = 0;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         GX_FocusControl = edtInstituteCode_Internalname;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         wbErr = false;
         context.SetDefaultTheme("WorkWithPlusTheme");
         if ( ! context.IsLocalStorageSupported( ) )
         {
            context.PushCurrentUrl();
         }
      }

      public sys_instituteuser( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public sys_instituteuser( IGxContext context )
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
            GxWebStd.gx_label_ctrl( context, lblTitle_Internalname, "SYS_Institute User", "", "", lblTitle_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Title", 0, "", 1, 1, 0, "HLP_SYS_InstituteUser.htm");
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
            GxWebStd.gx_button_ctrl( context, bttBtn_first_Internalname, "", "|<", bttBtn_first_Jsonclick, 5, "|<", "", StyleString, ClassString, bttBtn_first_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"EFIRST."+"'", TempTags, "", context.GetButtonType( ), "HLP_SYS_InstituteUser.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 14,'',false,'',0)\"";
            ClassString = "BtnPrevious";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_previous_Internalname, "", "<", bttBtn_previous_Jsonclick, 5, "<", "", StyleString, ClassString, bttBtn_previous_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"EPREVIOUS."+"'", TempTags, "", context.GetButtonType( ), "HLP_SYS_InstituteUser.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 16,'',false,'',0)\"";
            ClassString = "BtnNext";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_next_Internalname, "", ">", bttBtn_next_Jsonclick, 5, ">", "", StyleString, ClassString, bttBtn_next_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ENEXT."+"'", TempTags, "", context.GetButtonType( ), "HLP_SYS_InstituteUser.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 18,'',false,'',0)\"";
            ClassString = "BtnLast";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_last_Internalname, "", ">|", bttBtn_last_Jsonclick, 5, ">|", "", StyleString, ClassString, bttBtn_last_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ELAST."+"'", TempTags, "", context.GetButtonType( ), "HLP_SYS_InstituteUser.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 20,'',false,'',0)\"";
            ClassString = "BtnSelect";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_select_Internalname, "", "选择", bttBtn_select_Jsonclick, 5, "选择", "", StyleString, ClassString, bttBtn_select_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ESELECT."+"'", TempTags, "", 2, "HLP_SYS_InstituteUser.htm");
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
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtInstituteCode_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtInstituteCode_Internalname, "Institute Code", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 28,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtInstituteCode_Internalname, A358InstituteCode, StringUtil.RTrim( context.localUtil.Format( A358InstituteCode, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,28);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtInstituteCode_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtInstituteCode_Enabled, 0, "text", "", 20, "chr", 1, "row", 20, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_SYS_InstituteUser.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
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
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 33,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtUserID_Internalname, A359UserID.ToString(), A359UserID.ToString(), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,33);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtUserID_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtUserID_Enabled, 0, "text", "", 36, "chr", 1, "row", 36, 0, 0, 0, 1, 0, 0, true, "", "", false, "HLP_SYS_InstituteUser.htm");
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
            GxWebStd.gx_button_ctrl( context, bttBtn_enter_Internalname, "", "确认", bttBtn_enter_Jsonclick, 5, "确认", "", StyleString, ClassString, bttBtn_enter_Visible, bttBtn_enter_Enabled, "standard", "'"+""+"'"+",false,"+"'"+"EENTER."+"'", TempTags, "", context.GetButtonType( ), "HLP_SYS_InstituteUser.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 40,'',false,'',0)\"";
            ClassString = "BtnCancel";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_cancel_Internalname, "", "取消", bttBtn_cancel_Jsonclick, 1, "取消", "", StyleString, ClassString, bttBtn_cancel_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ECANCEL."+"'", TempTags, "", context.GetButtonType( ), "HLP_SYS_InstituteUser.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 42,'',false,'',0)\"";
            ClassString = "BtnDelete";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_delete_Internalname, "", "删除", bttBtn_delete_Jsonclick, 5, "删除", "", StyleString, ClassString, bttBtn_delete_Visible, bttBtn_delete_Enabled, "standard", "'"+""+"'"+",false,"+"'"+"EDELETE."+"'", TempTags, "", context.GetButtonType( ), "HLP_SYS_InstituteUser.htm");
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
               A358InstituteCode = cgiGet( edtInstituteCode_Internalname);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A358InstituteCode", A358InstituteCode);
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
               /* Read saved values. */
               Z358InstituteCode = cgiGet( "Z358InstituteCode");
               Z359UserID = (Guid)(StringUtil.StrToGuid( cgiGet( "Z359UserID")));
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
                  A358InstituteCode = GetNextPar( );
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A358InstituteCode", A358InstituteCode);
                  A359UserID = (Guid)(StringUtil.StrToGuid( GetNextPar( )));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A359UserID", A359UserID.ToString());
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
               InitAll1C49( ) ;
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
         DisableAttributes1C49( ) ;
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

      protected void ResetCaption1C0( )
      {
      }

      protected void ZM1C49( short GX_JID )
      {
         if ( ( GX_JID == 2 ) || ( GX_JID == 0 ) )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
            {
            }
            else
            {
            }
         }
         if ( GX_JID == -2 )
         {
            Z358InstituteCode = A358InstituteCode;
            Z359UserID = (Guid)(A359UserID);
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

      protected void Load1C49( )
      {
         /* Using cursor T001C6 */
         pr_datastore1.execute(4, new Object[] {A358InstituteCode, A359UserID});
         if ( (pr_datastore1.getStatus(4) != 101) )
         {
            RcdFound49 = 1;
            ZM1C49( -2) ;
         }
         pr_datastore1.close(4);
         OnLoadActions1C49( ) ;
      }

      protected void OnLoadActions1C49( )
      {
      }

      protected void CheckExtendedTable1C49( )
      {
         Gx_BScreen = 1;
         standaloneModal( ) ;
         /* Using cursor T001C4 */
         pr_datastore1.execute(2, new Object[] {A358InstituteCode});
         if ( (pr_datastore1.getStatus(2) == 101) )
         {
            GX_msglist.addItem("不匹配'BAS_Institute'", "ForeignKeyNotFound", 1, "INSTITUTECODE");
            AnyError = 1;
            GX_FocusControl = edtInstituteCode_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         pr_datastore1.close(2);
         /* Using cursor T001C5 */
         pr_datastore1.execute(3, new Object[] {A359UserID});
         if ( (pr_datastore1.getStatus(3) == 101) )
         {
            GX_msglist.addItem("不匹配'SYS_User'", "ForeignKeyNotFound", 1, "USERID");
            AnyError = 1;
            GX_FocusControl = edtUserID_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         pr_datastore1.close(3);
      }

      protected void CloseExtendedTableCursors1C49( )
      {
         pr_datastore1.close(2);
         pr_datastore1.close(3);
      }

      protected void enableDisable( )
      {
      }

      protected void gxLoad_3( String A358InstituteCode )
      {
         /* Using cursor T001C7 */
         pr_datastore1.execute(5, new Object[] {A358InstituteCode});
         if ( (pr_datastore1.getStatus(5) == 101) )
         {
            GX_msglist.addItem("不匹配'BAS_Institute'", "ForeignKeyNotFound", 1, "INSTITUTECODE");
            AnyError = 1;
            GX_FocusControl = edtInstituteCode_Internalname;
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

      protected void gxLoad_4( Guid A359UserID )
      {
         /* Using cursor T001C8 */
         pr_datastore1.execute(6, new Object[] {A359UserID});
         if ( (pr_datastore1.getStatus(6) == 101) )
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
         if ( (pr_datastore1.getStatus(6) == 101) )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString("]");
         pr_datastore1.close(6);
      }

      protected void GetKey1C49( )
      {
         /* Using cursor T001C9 */
         pr_datastore1.execute(7, new Object[] {A358InstituteCode, A359UserID});
         if ( (pr_datastore1.getStatus(7) != 101) )
         {
            RcdFound49 = 1;
         }
         else
         {
            RcdFound49 = 0;
         }
         pr_datastore1.close(7);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor T001C3 */
         pr_datastore1.execute(1, new Object[] {A358InstituteCode, A359UserID});
         if ( (pr_datastore1.getStatus(1) != 101) )
         {
            ZM1C49( 2) ;
            RcdFound49 = 1;
            A358InstituteCode = T001C3_A358InstituteCode[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A358InstituteCode", A358InstituteCode);
            A359UserID = (Guid)((Guid)(T001C3_A359UserID[0]));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A359UserID", A359UserID.ToString());
            Z358InstituteCode = A358InstituteCode;
            Z359UserID = (Guid)(A359UserID);
            sMode49 = Gx_mode;
            Gx_mode = "DSP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            standaloneModal( ) ;
            Load1C49( ) ;
            if ( AnyError == 1 )
            {
               RcdFound49 = 0;
               InitializeNonKey1C49( ) ;
            }
            Gx_mode = sMode49;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         else
         {
            RcdFound49 = 0;
            InitializeNonKey1C49( ) ;
            sMode49 = Gx_mode;
            Gx_mode = "DSP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            standaloneModal( ) ;
            Gx_mode = sMode49;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         pr_datastore1.close(1);
      }

      protected void getEqualNoModal( )
      {
         GetKey1C49( ) ;
         if ( RcdFound49 == 0 )
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
         RcdFound49 = 0;
         /* Using cursor T001C10 */
         pr_datastore1.execute(8, new Object[] {A358InstituteCode, A359UserID});
         if ( (pr_datastore1.getStatus(8) != 101) )
         {
            while ( (pr_datastore1.getStatus(8) != 101) && ( ( StringUtil.StrCmp(T001C10_A358InstituteCode[0], A358InstituteCode) < 0 ) || ( StringUtil.StrCmp(T001C10_A358InstituteCode[0], A358InstituteCode) == 0 ) && ( GuidUtil.Compare(T001C10_A359UserID[0], A359UserID, 1) < 0 ) ) )
            {
               pr_datastore1.readNext(8);
            }
            if ( (pr_datastore1.getStatus(8) != 101) && ( ( StringUtil.StrCmp(T001C10_A358InstituteCode[0], A358InstituteCode) > 0 ) || ( StringUtil.StrCmp(T001C10_A358InstituteCode[0], A358InstituteCode) == 0 ) && ( GuidUtil.Compare(T001C10_A359UserID[0], A359UserID, 1) > 0 ) ) )
            {
               A358InstituteCode = T001C10_A358InstituteCode[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A358InstituteCode", A358InstituteCode);
               A359UserID = (Guid)((Guid)(T001C10_A359UserID[0]));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A359UserID", A359UserID.ToString());
               RcdFound49 = 1;
            }
         }
         pr_datastore1.close(8);
      }

      protected void move_previous( )
      {
         RcdFound49 = 0;
         /* Using cursor T001C11 */
         pr_datastore1.execute(9, new Object[] {A358InstituteCode, A359UserID});
         if ( (pr_datastore1.getStatus(9) != 101) )
         {
            while ( (pr_datastore1.getStatus(9) != 101) && ( ( StringUtil.StrCmp(T001C11_A358InstituteCode[0], A358InstituteCode) > 0 ) || ( StringUtil.StrCmp(T001C11_A358InstituteCode[0], A358InstituteCode) == 0 ) && ( GuidUtil.Compare(T001C11_A359UserID[0], A359UserID, 1) > 0 ) ) )
            {
               pr_datastore1.readNext(9);
            }
            if ( (pr_datastore1.getStatus(9) != 101) && ( ( StringUtil.StrCmp(T001C11_A358InstituteCode[0], A358InstituteCode) < 0 ) || ( StringUtil.StrCmp(T001C11_A358InstituteCode[0], A358InstituteCode) == 0 ) && ( GuidUtil.Compare(T001C11_A359UserID[0], A359UserID, 1) < 0 ) ) )
            {
               A358InstituteCode = T001C11_A358InstituteCode[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A358InstituteCode", A358InstituteCode);
               A359UserID = (Guid)((Guid)(T001C11_A359UserID[0]));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A359UserID", A359UserID.ToString());
               RcdFound49 = 1;
            }
         }
         pr_datastore1.close(9);
      }

      protected void btn_enter( )
      {
         nKeyPressed = 1;
         GetKey1C49( ) ;
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            /* Insert record */
            GX_FocusControl = edtInstituteCode_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            Insert1C49( ) ;
            if ( AnyError == 1 )
            {
               GX_FocusControl = "";
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
         }
         else
         {
            if ( RcdFound49 == 1 )
            {
               if ( ( StringUtil.StrCmp(A358InstituteCode, Z358InstituteCode) != 0 ) || ( A359UserID != Z359UserID ) )
               {
                  A358InstituteCode = Z358InstituteCode;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A358InstituteCode", A358InstituteCode);
                  A359UserID = (Guid)(Z359UserID);
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A359UserID", A359UserID.ToString());
                  GX_msglist.addItem(context.GetMessage( "GXM_getbeforeupd", ""), "CandidateKeyNotFound", 1, "INSTITUTECODE");
                  AnyError = 1;
                  GX_FocusControl = edtInstituteCode_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
               else if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
               {
                  delete( ) ;
                  AfterTrn( ) ;
                  GX_FocusControl = edtInstituteCode_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
               else
               {
                  Gx_mode = "UPD";
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                  /* Update record */
                  Update1C49( ) ;
                  GX_FocusControl = edtInstituteCode_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
            }
            else
            {
               if ( ( StringUtil.StrCmp(A358InstituteCode, Z358InstituteCode) != 0 ) || ( A359UserID != Z359UserID ) )
               {
                  Gx_mode = "INS";
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                  /* Insert record */
                  GX_FocusControl = edtInstituteCode_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  Insert1C49( ) ;
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
                     GX_msglist.addItem(context.GetMessage( "GXM_recdeleted", ""), 1, "INSTITUTECODE");
                     AnyError = 1;
                     GX_FocusControl = edtInstituteCode_Internalname;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  }
                  else
                  {
                     Gx_mode = "INS";
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                     /* Insert record */
                     GX_FocusControl = edtInstituteCode_Internalname;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                     Insert1C49( ) ;
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
         if ( ( StringUtil.StrCmp(A358InstituteCode, Z358InstituteCode) != 0 ) || ( A359UserID != Z359UserID ) )
         {
            A358InstituteCode = Z358InstituteCode;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A358InstituteCode", A358InstituteCode);
            A359UserID = (Guid)(Z359UserID);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A359UserID", A359UserID.ToString());
            GX_msglist.addItem(context.GetMessage( "GXM_getbeforedlt", ""), 1, "INSTITUTECODE");
            AnyError = 1;
            GX_FocusControl = edtInstituteCode_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         else
         {
            delete( ) ;
            AfterTrn( ) ;
            GX_FocusControl = edtInstituteCode_Internalname;
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
         if ( RcdFound49 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_keynfound", ""), "PrimaryKeyNotFound", 1, "INSTITUTECODE");
            AnyError = 1;
            GX_FocusControl = edtInstituteCode_Internalname;
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
         ScanStart1C49( ) ;
         if ( RcdFound49 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "", true);
         }
         else
         {
            Gx_mode = "UPD";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         ScanEnd1C49( ) ;
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
         if ( RcdFound49 == 0 )
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
         if ( RcdFound49 == 0 )
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
         ScanStart1C49( ) ;
         if ( RcdFound49 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "", true);
         }
         else
         {
            while ( RcdFound49 != 0 )
            {
               ScanNext1C49( ) ;
            }
            Gx_mode = "UPD";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         ScanEnd1C49( ) ;
         getByPrimaryKey( ) ;
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_select( )
      {
         getEqualNoModal( ) ;
      }

      protected void CheckOptimisticConcurrency1C49( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor T001C2 */
            pr_datastore1.execute(0, new Object[] {A358InstituteCode, A359UserID});
            if ( (pr_datastore1.getStatus(0) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"SYS_INSTITUTEUSER"}), "RecordIsLocked", 1, "");
               AnyError = 1;
               return  ;
            }
            if ( (pr_datastore1.getStatus(0) == 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"SYS_INSTITUTEUSER"}), "RecordWasChanged", 1, "");
               AnyError = 1;
               return  ;
            }
         }
      }

      protected void Insert1C49( )
      {
         BeforeValidate1C49( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable1C49( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM1C49( 0) ;
            CheckOptimisticConcurrency1C49( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm1C49( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert1C49( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T001C12 */
                     pr_datastore1.execute(10, new Object[] {A358InstituteCode, A359UserID});
                     pr_datastore1.close(10);
                     dsDataStore1.SmartCacheProvider.SetUpdated("SYS_INSTITUTEUSER") ;
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
                           ResetCaption1C0( ) ;
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
               Load1C49( ) ;
            }
            EndLevel1C49( ) ;
         }
         CloseExtendedTableCursors1C49( ) ;
      }

      protected void Update1C49( )
      {
         BeforeValidate1C49( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable1C49( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency1C49( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm1C49( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate1C49( ) ;
                  if ( AnyError == 0 )
                  {
                     /* No attributes to update on table dbo.[SYS_InstituteUser] */
                     DeferredUpdate1C49( ) ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( update) rules */
                        /* End of After( update) rules */
                        if ( AnyError == 0 )
                        {
                           getByPrimaryKey( ) ;
                           GX_msglist.addItem(context.GetMessage( "GXM_sucupdated", ""), "SuccessfullyUpdated", 0, "", true);
                           ResetCaption1C0( ) ;
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
            EndLevel1C49( ) ;
         }
         CloseExtendedTableCursors1C49( ) ;
      }

      protected void DeferredUpdate1C49( )
      {
      }

      protected void delete( )
      {
         Gx_mode = "DLT";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         BeforeValidate1C49( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency1C49( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls1C49( ) ;
            AfterConfirm1C49( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete1C49( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor T001C13 */
                  pr_datastore1.execute(11, new Object[] {A358InstituteCode, A359UserID});
                  pr_datastore1.close(11);
                  dsDataStore1.SmartCacheProvider.SetUpdated("SYS_INSTITUTEUSER") ;
                  if ( AnyError == 0 )
                  {
                     /* Start of After( delete) rules */
                     /* End of After( delete) rules */
                     if ( AnyError == 0 )
                     {
                        move_next( ) ;
                        if ( RcdFound49 == 0 )
                        {
                           InitAll1C49( ) ;
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
                        ResetCaption1C0( ) ;
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
         sMode49 = Gx_mode;
         Gx_mode = "DLT";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         EndLevel1C49( ) ;
         Gx_mode = sMode49;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
      }

      protected void OnDeleteControls1C49( )
      {
         standaloneModal( ) ;
         /* No delete mode formulas found. */
      }

      protected void EndLevel1C49( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            pr_datastore1.close(0);
         }
         if ( AnyError == 0 )
         {
            BeforeComplete1C49( ) ;
         }
         if ( AnyError == 0 )
         {
            pr_datastore1.close(1);
            context.CommitDataStores("sys_instituteuser",pr_default);
            if ( AnyError == 0 )
            {
               ConfirmValues1C0( ) ;
            }
            /* After transaction rules */
            /* Execute 'After Trn' event if defined. */
            trnEnded = 1;
         }
         else
         {
            pr_datastore1.close(1);
            context.RollbackDataStores("sys_instituteuser",pr_default);
         }
         IsModified = 0;
         if ( AnyError != 0 )
         {
            context.wjLoc = "";
            context.nUserReturn = 0;
         }
      }

      public void ScanStart1C49( )
      {
         /* Using cursor T001C14 */
         pr_datastore1.execute(12);
         RcdFound49 = 0;
         if ( (pr_datastore1.getStatus(12) != 101) )
         {
            RcdFound49 = 1;
            A358InstituteCode = T001C14_A358InstituteCode[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A358InstituteCode", A358InstituteCode);
            A359UserID = (Guid)((Guid)(T001C14_A359UserID[0]));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A359UserID", A359UserID.ToString());
         }
         /* Load Subordinate Levels */
      }

      protected void ScanNext1C49( )
      {
         /* Scan next routine */
         pr_datastore1.readNext(12);
         RcdFound49 = 0;
         if ( (pr_datastore1.getStatus(12) != 101) )
         {
            RcdFound49 = 1;
            A358InstituteCode = T001C14_A358InstituteCode[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A358InstituteCode", A358InstituteCode);
            A359UserID = (Guid)((Guid)(T001C14_A359UserID[0]));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A359UserID", A359UserID.ToString());
         }
      }

      protected void ScanEnd1C49( )
      {
         pr_datastore1.close(12);
      }

      protected void AfterConfirm1C49( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert1C49( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate1C49( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete1C49( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete1C49( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate1C49( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes1C49( )
      {
         edtInstituteCode_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtInstituteCode_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtInstituteCode_Enabled), 5, 0)), true);
         edtUserID_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtUserID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtUserID_Enabled), 5, 0)), true);
      }

      protected void send_integrity_lvl_hashes1C49( )
      {
      }

      protected void assign_properties_default( )
      {
      }

      protected void ConfirmValues1C0( )
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
         context.AddJavascriptSource("gxcfg.js", "?20202279385824", false);
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" autocomplete=\"off\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("sys_instituteuser.aspx") +"\">") ;
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
         GxWebStd.gx_hidden_field( context, "Z358InstituteCode", Z358InstituteCode);
         GxWebStd.gx_hidden_field( context, "Z359UserID", Z359UserID.ToString());
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
         return formatLink("sys_instituteuser.aspx")  ;
      }

      public override String GetPgmname( )
      {
         return "SYS_InstituteUser" ;
      }

      public override String GetPgmdesc( )
      {
         return "SYS_Institute User" ;
      }

      protected void InitializeNonKey1C49( )
      {
      }

      protected void InitAll1C49( )
      {
         A358InstituteCode = "";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A358InstituteCode", A358InstituteCode);
         A359UserID = (Guid)(Guid.Empty);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A359UserID", A359UserID.ToString());
         InitializeNonKey1C49( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?20202279385828", true);
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
         context.AddJavascriptSource("sys_instituteuser.js", "?20202279385828", false);
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
         edtInstituteCode_Internalname = "INSTITUTECODE";
         edtUserID_Internalname = "USERID";
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
         Form.Caption = "SYS_Institute User";
         bttBtn_delete_Enabled = 1;
         bttBtn_delete_Visible = 1;
         bttBtn_cancel_Visible = 1;
         bttBtn_enter_Enabled = 1;
         bttBtn_enter_Visible = 1;
         edtUserID_Jsonclick = "";
         edtUserID_Enabled = 1;
         edtInstituteCode_Jsonclick = "";
         edtInstituteCode_Enabled = 1;
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
         /* Using cursor T001C15 */
         pr_datastore1.execute(13, new Object[] {A358InstituteCode});
         if ( (pr_datastore1.getStatus(13) == 101) )
         {
            GX_msglist.addItem("不匹配'BAS_Institute'", "ForeignKeyNotFound", 1, "INSTITUTECODE");
            AnyError = 1;
            GX_FocusControl = edtInstituteCode_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         pr_datastore1.close(13);
         /* Using cursor T001C16 */
         pr_datastore1.execute(14, new Object[] {A359UserID});
         if ( (pr_datastore1.getStatus(14) == 101) )
         {
            GX_msglist.addItem("不匹配'SYS_User'", "ForeignKeyNotFound", 1, "USERID");
            AnyError = 1;
            GX_FocusControl = edtUserID_Internalname;
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

      public void Valid_Institutecode( String GX_Parm1 )
      {
         A358InstituteCode = GX_Parm1;
         /* Using cursor T001C15 */
         pr_datastore1.execute(13, new Object[] {A358InstituteCode});
         if ( (pr_datastore1.getStatus(13) == 101) )
         {
            GX_msglist.addItem("不匹配'BAS_Institute'", "ForeignKeyNotFound", 1, "INSTITUTECODE");
            AnyError = 1;
            GX_FocusControl = edtInstituteCode_Internalname;
         }
         pr_datastore1.close(13);
         dynload_actions( ) ;
         isValidOutput.Add(context.GX_msglist.ToJavascriptSource());
         isValidOutput.Add(context.httpAjaxContext.ajax_rsp_get_hiddens( ));
         context.GX_webresponse.AddString(isValidOutput.ToJSonString());
         wbTemp = context.ResponseContentType( "application/json");
      }

      public void Valid_Userid( String GX_Parm1 ,
                                Guid GX_Parm2 )
      {
         A358InstituteCode = GX_Parm1;
         A359UserID = (Guid)(GX_Parm2);
         context.wbHandled = 1;
         AfterKeyLoadScreen( ) ;
         Draw( ) ;
         send_integrity_footer_hashes( ) ;
         /* Using cursor T001C16 */
         pr_datastore1.execute(14, new Object[] {A359UserID});
         if ( (pr_datastore1.getStatus(14) == 101) )
         {
            GX_msglist.addItem("不匹配'SYS_User'", "ForeignKeyNotFound", 1, "USERID");
            AnyError = 1;
            GX_FocusControl = edtUserID_Internalname;
         }
         pr_datastore1.close(14);
         dynload_actions( ) ;
         if ( AnyError == 1 )
         {
         }
         isValidOutput.Add(StringUtil.RTrim( Gx_mode));
         isValidOutput.Add(Z358InstituteCode);
         isValidOutput.Add(Z359UserID.ToString());
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
         Z358InstituteCode = "";
         Z359UserID = (Guid)(Guid.Empty);
         scmdbuf = "";
         gxfirstwebparm = "";
         gxfirstwebparm_bkp = "";
         A358InstituteCode = "";
         A359UserID = (Guid)(Guid.Empty);
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
         T001C6_A358InstituteCode = new String[] {""} ;
         T001C6_A359UserID = new Guid[] {Guid.Empty} ;
         T001C4_A358InstituteCode = new String[] {""} ;
         T001C5_A359UserID = new Guid[] {Guid.Empty} ;
         T001C7_A358InstituteCode = new String[] {""} ;
         T001C8_A359UserID = new Guid[] {Guid.Empty} ;
         T001C9_A358InstituteCode = new String[] {""} ;
         T001C9_A359UserID = new Guid[] {Guid.Empty} ;
         T001C3_A358InstituteCode = new String[] {""} ;
         T001C3_A359UserID = new Guid[] {Guid.Empty} ;
         sMode49 = "";
         T001C10_A358InstituteCode = new String[] {""} ;
         T001C10_A359UserID = new Guid[] {Guid.Empty} ;
         T001C11_A358InstituteCode = new String[] {""} ;
         T001C11_A359UserID = new Guid[] {Guid.Empty} ;
         T001C2_A358InstituteCode = new String[] {""} ;
         T001C2_A359UserID = new Guid[] {Guid.Empty} ;
         T001C14_A358InstituteCode = new String[] {""} ;
         T001C14_A359UserID = new Guid[] {Guid.Empty} ;
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         T001C15_A358InstituteCode = new String[] {""} ;
         T001C16_A359UserID = new Guid[] {Guid.Empty} ;
         isValidOutput = new GxUnknownObjectCollection();
         pr_datastore1 = new DataStoreProvider(context, new GeneXus.Programs.sys_instituteuser__datastore1(),
            new Object[][] {
                new Object[] {
               T001C2_A358InstituteCode, T001C2_A359UserID
               }
               , new Object[] {
               T001C3_A358InstituteCode, T001C3_A359UserID
               }
               , new Object[] {
               T001C4_A358InstituteCode
               }
               , new Object[] {
               T001C5_A359UserID
               }
               , new Object[] {
               T001C6_A358InstituteCode, T001C6_A359UserID
               }
               , new Object[] {
               T001C7_A358InstituteCode
               }
               , new Object[] {
               T001C8_A359UserID
               }
               , new Object[] {
               T001C9_A358InstituteCode, T001C9_A359UserID
               }
               , new Object[] {
               T001C10_A358InstituteCode, T001C10_A359UserID
               }
               , new Object[] {
               T001C11_A358InstituteCode, T001C11_A359UserID
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               T001C14_A358InstituteCode, T001C14_A359UserID
               }
               , new Object[] {
               T001C15_A358InstituteCode
               }
               , new Object[] {
               T001C16_A359UserID
               }
            }
         );
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.sys_instituteuser__default(),
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
      private short RcdFound49 ;
      private short Gx_BScreen ;
      private short gxajaxcallmode ;
      private short wbTemp ;
      private int trnEnded ;
      private int bttBtn_first_Visible ;
      private int bttBtn_previous_Visible ;
      private int bttBtn_next_Visible ;
      private int bttBtn_last_Visible ;
      private int bttBtn_select_Visible ;
      private int edtInstituteCode_Enabled ;
      private int edtUserID_Enabled ;
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
      private String edtInstituteCode_Internalname ;
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
      private String edtInstituteCode_Jsonclick ;
      private String edtUserID_Internalname ;
      private String edtUserID_Jsonclick ;
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
      private String sMode49 ;
      private String sDynURL ;
      private String FormProcess ;
      private String bodyStyle ;
      private bool entryPointCalled ;
      private bool toggleJsOutput ;
      private bool wbErr ;
      private String Z358InstituteCode ;
      private String A358InstituteCode ;
      private Guid Z359UserID ;
      private Guid A359UserID ;
      private GxUnknownObjectCollection isValidOutput ;
      private IGxDataStore dsDataStore1 ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_datastore1 ;
      private String[] T001C6_A358InstituteCode ;
      private Guid[] T001C6_A359UserID ;
      private String[] T001C4_A358InstituteCode ;
      private Guid[] T001C5_A359UserID ;
      private String[] T001C7_A358InstituteCode ;
      private Guid[] T001C8_A359UserID ;
      private String[] T001C9_A358InstituteCode ;
      private Guid[] T001C9_A359UserID ;
      private String[] T001C3_A358InstituteCode ;
      private Guid[] T001C3_A359UserID ;
      private String[] T001C10_A358InstituteCode ;
      private Guid[] T001C10_A359UserID ;
      private String[] T001C11_A358InstituteCode ;
      private Guid[] T001C11_A359UserID ;
      private String[] T001C2_A358InstituteCode ;
      private Guid[] T001C2_A359UserID ;
      private IDataStoreProvider pr_default ;
      private String[] T001C14_A358InstituteCode ;
      private Guid[] T001C14_A359UserID ;
      private String[] T001C15_A358InstituteCode ;
      private Guid[] T001C16_A359UserID ;
      private GXWebForm Form ;
   }

   public class sys_instituteuser__datastore1 : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmT001C6 ;
          prmT001C6 = new Object[] {
          new Object[] {"@InstituteCode",SqlDbType.NVarChar,20,0} ,
          new Object[] {"@UserID",SqlDbType.UniqueIdentifier,16,0}
          } ;
          Object[] prmT001C4 ;
          prmT001C4 = new Object[] {
          new Object[] {"@InstituteCode",SqlDbType.NVarChar,20,0}
          } ;
          Object[] prmT001C5 ;
          prmT001C5 = new Object[] {
          new Object[] {"@UserID",SqlDbType.UniqueIdentifier,16,0}
          } ;
          Object[] prmT001C7 ;
          prmT001C7 = new Object[] {
          new Object[] {"@InstituteCode",SqlDbType.NVarChar,20,0}
          } ;
          Object[] prmT001C8 ;
          prmT001C8 = new Object[] {
          new Object[] {"@UserID",SqlDbType.UniqueIdentifier,16,0}
          } ;
          Object[] prmT001C9 ;
          prmT001C9 = new Object[] {
          new Object[] {"@InstituteCode",SqlDbType.NVarChar,20,0} ,
          new Object[] {"@UserID",SqlDbType.UniqueIdentifier,16,0}
          } ;
          Object[] prmT001C3 ;
          prmT001C3 = new Object[] {
          new Object[] {"@InstituteCode",SqlDbType.NVarChar,20,0} ,
          new Object[] {"@UserID",SqlDbType.UniqueIdentifier,16,0}
          } ;
          Object[] prmT001C10 ;
          prmT001C10 = new Object[] {
          new Object[] {"@InstituteCode",SqlDbType.NVarChar,20,0} ,
          new Object[] {"@UserID",SqlDbType.UniqueIdentifier,16,0}
          } ;
          Object[] prmT001C11 ;
          prmT001C11 = new Object[] {
          new Object[] {"@InstituteCode",SqlDbType.NVarChar,20,0} ,
          new Object[] {"@UserID",SqlDbType.UniqueIdentifier,16,0}
          } ;
          Object[] prmT001C2 ;
          prmT001C2 = new Object[] {
          new Object[] {"@InstituteCode",SqlDbType.NVarChar,20,0} ,
          new Object[] {"@UserID",SqlDbType.UniqueIdentifier,16,0}
          } ;
          Object[] prmT001C12 ;
          prmT001C12 = new Object[] {
          new Object[] {"@InstituteCode",SqlDbType.NVarChar,20,0} ,
          new Object[] {"@UserID",SqlDbType.UniqueIdentifier,16,0}
          } ;
          Object[] prmT001C13 ;
          prmT001C13 = new Object[] {
          new Object[] {"@InstituteCode",SqlDbType.NVarChar,20,0} ,
          new Object[] {"@UserID",SqlDbType.UniqueIdentifier,16,0}
          } ;
          Object[] prmT001C14 ;
          prmT001C14 = new Object[] {
          } ;
          Object[] prmT001C15 ;
          prmT001C15 = new Object[] {
          new Object[] {"@InstituteCode",SqlDbType.NVarChar,20,0}
          } ;
          Object[] prmT001C16 ;
          prmT001C16 = new Object[] {
          new Object[] {"@UserID",SqlDbType.UniqueIdentifier,16,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("T001C2", "SELECT [InstituteCode], [UserID] FROM dbo.[SYS_InstituteUser] WITH (UPDLOCK) WHERE [InstituteCode] = @InstituteCode AND [UserID] = @UserID ",true, GxErrorMask.GX_NOMASK, false, this,prmT001C2,1,0,true,false )
             ,new CursorDef("T001C3", "SELECT [InstituteCode], [UserID] FROM dbo.[SYS_InstituteUser] WITH (NOLOCK) WHERE [InstituteCode] = @InstituteCode AND [UserID] = @UserID ",true, GxErrorMask.GX_NOMASK, false, this,prmT001C3,1,0,true,false )
             ,new CursorDef("T001C4", "SELECT [InstituteCode] FROM dbo.[BAS_Institute] WITH (NOLOCK) WHERE [InstituteCode] = @InstituteCode ",true, GxErrorMask.GX_NOMASK, false, this,prmT001C4,1,0,true,false )
             ,new CursorDef("T001C5", "SELECT [UserID] FROM dbo.[SYS_User] WITH (NOLOCK) WHERE [UserID] = @UserID ",true, GxErrorMask.GX_NOMASK, false, this,prmT001C5,1,0,true,false )
             ,new CursorDef("T001C6", "SELECT TM1.[InstituteCode], TM1.[UserID] FROM dbo.[SYS_InstituteUser] TM1 WITH (NOLOCK) WHERE TM1.[InstituteCode] = @InstituteCode and TM1.[UserID] = @UserID ORDER BY TM1.[InstituteCode], TM1.[UserID]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT001C6,100,0,true,false )
             ,new CursorDef("T001C7", "SELECT [InstituteCode] FROM dbo.[BAS_Institute] WITH (NOLOCK) WHERE [InstituteCode] = @InstituteCode ",true, GxErrorMask.GX_NOMASK, false, this,prmT001C7,1,0,true,false )
             ,new CursorDef("T001C8", "SELECT [UserID] FROM dbo.[SYS_User] WITH (NOLOCK) WHERE [UserID] = @UserID ",true, GxErrorMask.GX_NOMASK, false, this,prmT001C8,1,0,true,false )
             ,new CursorDef("T001C9", "SELECT [InstituteCode], [UserID] FROM dbo.[SYS_InstituteUser] WITH (NOLOCK) WHERE [InstituteCode] = @InstituteCode AND [UserID] = @UserID  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT001C9,1,0,true,false )
             ,new CursorDef("T001C10", "SELECT TOP 1 [InstituteCode], [UserID] FROM dbo.[SYS_InstituteUser] WITH (NOLOCK) WHERE ( [InstituteCode] > @InstituteCode or [InstituteCode] = @InstituteCode and [UserID] > @UserID) ORDER BY [InstituteCode], [UserID]  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT001C10,1,0,true,true )
             ,new CursorDef("T001C11", "SELECT TOP 1 [InstituteCode], [UserID] FROM dbo.[SYS_InstituteUser] WITH (NOLOCK) WHERE ( [InstituteCode] < @InstituteCode or [InstituteCode] = @InstituteCode and [UserID] < @UserID) ORDER BY [InstituteCode] DESC, [UserID] DESC  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT001C11,1,0,true,true )
             ,new CursorDef("T001C12", "INSERT INTO dbo.[SYS_InstituteUser]([InstituteCode], [UserID]) VALUES(@InstituteCode, @UserID)", GxErrorMask.GX_NOMASK,prmT001C12)
             ,new CursorDef("T001C13", "DELETE FROM dbo.[SYS_InstituteUser]  WHERE [InstituteCode] = @InstituteCode AND [UserID] = @UserID", GxErrorMask.GX_NOMASK,prmT001C13)
             ,new CursorDef("T001C14", "SELECT [InstituteCode], [UserID] FROM dbo.[SYS_InstituteUser] WITH (NOLOCK) ORDER BY [InstituteCode], [UserID]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT001C14,100,0,true,false )
             ,new CursorDef("T001C15", "SELECT [InstituteCode] FROM dbo.[BAS_Institute] WITH (NOLOCK) WHERE [InstituteCode] = @InstituteCode ",true, GxErrorMask.GX_NOMASK, false, this,prmT001C15,1,0,true,false )
             ,new CursorDef("T001C16", "SELECT [UserID] FROM dbo.[SYS_User] WITH (NOLOCK) WHERE [UserID] = @UserID ",true, GxErrorMask.GX_NOMASK, false, this,prmT001C16,1,0,true,false )
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
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((Guid[]) buf[1])[0] = rslt.getGuid(2) ;
                return;
             case 1 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((Guid[]) buf[1])[0] = rslt.getGuid(2) ;
                return;
             case 2 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                return;
             case 3 :
                ((Guid[]) buf[0])[0] = rslt.getGuid(1) ;
                return;
             case 4 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((Guid[]) buf[1])[0] = rslt.getGuid(2) ;
                return;
             case 5 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                return;
             case 6 :
                ((Guid[]) buf[0])[0] = rslt.getGuid(1) ;
                return;
             case 7 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((Guid[]) buf[1])[0] = rslt.getGuid(2) ;
                return;
             case 8 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((Guid[]) buf[1])[0] = rslt.getGuid(2) ;
                return;
             case 9 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((Guid[]) buf[1])[0] = rslt.getGuid(2) ;
                return;
             case 12 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((Guid[]) buf[1])[0] = rslt.getGuid(2) ;
                return;
             case 13 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
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
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (Guid)parms[1]);
                return;
             case 1 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (Guid)parms[1]);
                return;
             case 2 :
                stmt.SetParameter(1, (String)parms[0]);
                return;
             case 3 :
                stmt.SetParameter(1, (Guid)parms[0]);
                return;
             case 4 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (Guid)parms[1]);
                return;
             case 5 :
                stmt.SetParameter(1, (String)parms[0]);
                return;
             case 6 :
                stmt.SetParameter(1, (Guid)parms[0]);
                return;
             case 7 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (Guid)parms[1]);
                return;
             case 8 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (Guid)parms[1]);
                return;
             case 9 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (Guid)parms[1]);
                return;
             case 10 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (Guid)parms[1]);
                return;
             case 11 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (Guid)parms[1]);
                return;
             case 13 :
                stmt.SetParameter(1, (String)parms[0]);
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

 public class sys_instituteuser__default : DataStoreHelperBase, IDataStoreHelper
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
