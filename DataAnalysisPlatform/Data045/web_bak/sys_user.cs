/*
               File: SYS_User
        Description: SYS_User
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/27/2020 9:38:55.58
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
   public class sys_user : GXDataArea, System.Web.SessionState.IRequiresSessionState
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
            Form.Meta.addItem("description", "SYS_User", 0) ;
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

      public sys_user( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public sys_user( IGxContext context )
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
            GxWebStd.gx_label_ctrl( context, lblTitle_Internalname, "SYS_User", "", "", lblTitle_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Title", 0, "", 1, 1, 0, "HLP_SYS_User.htm");
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
            GxWebStd.gx_button_ctrl( context, bttBtn_first_Internalname, "", "|<", bttBtn_first_Jsonclick, 5, "|<", "", StyleString, ClassString, bttBtn_first_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"EFIRST."+"'", TempTags, "", context.GetButtonType( ), "HLP_SYS_User.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 14,'',false,'',0)\"";
            ClassString = "BtnPrevious";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_previous_Internalname, "", "<", bttBtn_previous_Jsonclick, 5, "<", "", StyleString, ClassString, bttBtn_previous_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"EPREVIOUS."+"'", TempTags, "", context.GetButtonType( ), "HLP_SYS_User.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 16,'',false,'',0)\"";
            ClassString = "BtnNext";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_next_Internalname, "", ">", bttBtn_next_Jsonclick, 5, ">", "", StyleString, ClassString, bttBtn_next_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ENEXT."+"'", TempTags, "", context.GetButtonType( ), "HLP_SYS_User.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 18,'',false,'',0)\"";
            ClassString = "BtnLast";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_last_Internalname, "", ">|", bttBtn_last_Jsonclick, 5, ">|", "", StyleString, ClassString, bttBtn_last_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ELAST."+"'", TempTags, "", context.GetButtonType( ), "HLP_SYS_User.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 20,'',false,'',0)\"";
            ClassString = "BtnSelect";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_select_Internalname, "", "选择", bttBtn_select_Jsonclick, 5, "选择", "", StyleString, ClassString, bttBtn_select_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ESELECT."+"'", TempTags, "", 2, "HLP_SYS_User.htm");
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
            GxWebStd.gx_single_line_edit( context, edtUserID_Internalname, A359UserID.ToString(), A359UserID.ToString(), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,28);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtUserID_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtUserID_Enabled, 0, "text", "", 36, "chr", 1, "row", 36, 0, 0, 0, 1, 0, 0, true, "", "", false, "HLP_SYS_User.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtDisplayName_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtDisplayName_Internalname, "Display Name", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 33,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtDisplayName_Internalname, A416DisplayName, StringUtil.RTrim( context.localUtil.Format( A416DisplayName, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,33);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtDisplayName_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtDisplayName_Enabled, 0, "text", "", 50, "chr", 1, "row", 50, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_SYS_User.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtUserType_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtUserType_Internalname, "Roche/Institute/Tenant", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 38,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtUserType_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A417UserType), 9, 0, ".", "")), ((edtUserType_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A417UserType), "ZZZZZZZZ9")) : context.localUtil.Format( (decimal)(A417UserType), "ZZZZZZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,38);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtUserType_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtUserType_Enabled, 0, "number", "1", 9, "chr", 1, "row", 9, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_SYS_User.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtAccount_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtAccount_Internalname, "Account", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 43,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtAccount_Internalname, A364Account, StringUtil.RTrim( context.localUtil.Format( A364Account, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,43);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtAccount_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtAccount_Enabled, 0, "text", "", 50, "chr", 1, "row", 50, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_SYS_User.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtPasswordHash_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtPasswordHash_Internalname, "Password Hash", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 48,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtPasswordHash_Internalname, A418PasswordHash, StringUtil.RTrim( context.localUtil.Format( A418PasswordHash, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,48);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtPasswordHash_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtPasswordHash_Enabled, 0, "text", "", 50, "chr", 1, "row", 50, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_SYS_User.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtLoginIP_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtLoginIP_Internalname, "Login IP", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 53,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtLoginIP_Internalname, A419LoginIP, StringUtil.RTrim( context.localUtil.Format( A419LoginIP, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,53);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtLoginIP_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtLoginIP_Enabled, 0, "text", "", 20, "chr", 1, "row", 20, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_SYS_User.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtLoginTime_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtLoginTime_Internalname, "Login Time", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 58,'',false,'',0)\"";
            context.WriteHtmlText( "<div id=\""+edtLoginTime_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtLoginTime_Internalname, context.localUtil.TToC( A420LoginTime, 10, 8, 0, 0, "/", ":", " "), context.localUtil.Format( A420LoginTime, "9999/99/99 99:99:99"), TempTags+" onchange=\""+"gx.date.valid_date(this, 10,'YMD',8,24,'chs',false,1);"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,58);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtLoginTime_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtLoginTime_Enabled, 0, "text", "", 19, "chr", 1, "row", 19, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_SYS_User.htm");
            GxWebStd.gx_bitmap( context, edtLoginTime_Internalname+"_dp_trigger", context.GetImagePath( "61b9b5d3-dff6-4d59-9b00-da61bc2cbe93", "", context.GetTheme( )), "", "", "", "", ((1==0)||(edtLoginTime_Enabled==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;", "", "", "", "", "", "", "", "", 1, false, false, "", "HLP_SYS_User.htm");
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
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtSYS_UserCreator_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtSYS_UserCreator_Internalname, "Creator", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 63,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtSYS_UserCreator_Internalname, A421SYS_UserCreator, StringUtil.RTrim( context.localUtil.Format( A421SYS_UserCreator, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,63);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtSYS_UserCreator_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtSYS_UserCreator_Enabled, 0, "text", "", 50, "chr", 1, "row", 50, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_SYS_User.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtSYS_UserCreateTime_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtSYS_UserCreateTime_Internalname, "Create Time", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 68,'',false,'',0)\"";
            context.WriteHtmlText( "<div id=\""+edtSYS_UserCreateTime_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtSYS_UserCreateTime_Internalname, context.localUtil.TToC( A422SYS_UserCreateTime, 10, 8, 0, 0, "/", ":", " "), context.localUtil.Format( A422SYS_UserCreateTime, "9999/99/99 99:99:99"), TempTags+" onchange=\""+"gx.date.valid_date(this, 10,'YMD',8,24,'chs',false,1);"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,68);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtSYS_UserCreateTime_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtSYS_UserCreateTime_Enabled, 0, "text", "", 19, "chr", 1, "row", 19, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_SYS_User.htm");
            GxWebStd.gx_bitmap( context, edtSYS_UserCreateTime_Internalname+"_dp_trigger", context.GetImagePath( "61b9b5d3-dff6-4d59-9b00-da61bc2cbe93", "", context.GetTheme( )), "", "", "", "", ((1==0)||(edtSYS_UserCreateTime_Enabled==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;", "", "", "", "", "", "", "", "", 1, false, false, "", "HLP_SYS_User.htm");
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
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtSYS_UserModifier_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtSYS_UserModifier_Internalname, "Modifier", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 73,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtSYS_UserModifier_Internalname, A423SYS_UserModifier, StringUtil.RTrim( context.localUtil.Format( A423SYS_UserModifier, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,73);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtSYS_UserModifier_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtSYS_UserModifier_Enabled, 0, "text", "", 50, "chr", 1, "row", 50, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_SYS_User.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtSYS_UserModifyTime_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtSYS_UserModifyTime_Internalname, "Modify Time", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 78,'',false,'',0)\"";
            context.WriteHtmlText( "<div id=\""+edtSYS_UserModifyTime_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtSYS_UserModifyTime_Internalname, context.localUtil.TToC( A424SYS_UserModifyTime, 10, 8, 0, 0, "/", ":", " "), context.localUtil.Format( A424SYS_UserModifyTime, "9999/99/99 99:99:99"), TempTags+" onchange=\""+"gx.date.valid_date(this, 10,'YMD',8,24,'chs',false,1);"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,78);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtSYS_UserModifyTime_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtSYS_UserModifyTime_Enabled, 0, "text", "", 19, "chr", 1, "row", 19, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_SYS_User.htm");
            GxWebStd.gx_bitmap( context, edtSYS_UserModifyTime_Internalname+"_dp_trigger", context.GetImagePath( "61b9b5d3-dff6-4d59-9b00-da61bc2cbe93", "", context.GetTheme( )), "", "", "", "", ((1==0)||(edtSYS_UserModifyTime_Enabled==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;", "", "", "", "", "", "", "", "", 1, false, false, "", "HLP_SYS_User.htm");
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
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtSYS_UserIsDeleted_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtSYS_UserIsDeleted_Internalname, "Is Deleted", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 83,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtSYS_UserIsDeleted_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A425SYS_UserIsDeleted), 1, 0, ".", "")), ((edtSYS_UserIsDeleted_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A425SYS_UserIsDeleted), "9")) : context.localUtil.Format( (decimal)(A425SYS_UserIsDeleted), "9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,83);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtSYS_UserIsDeleted_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtSYS_UserIsDeleted_Enabled, 0, "number", "1", 1, "chr", 1, "row", 1, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_SYS_User.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtEmail_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtEmail_Internalname, "Email", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 88,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtEmail_Internalname, A426Email, StringUtil.RTrim( context.localUtil.Format( A426Email, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,88);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtEmail_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtEmail_Enabled, 0, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_SYS_User.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtSYS_UserDescription_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtSYS_UserDescription_Internalname, "Description", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 93,'',false,'',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtSYS_UserDescription_Internalname, A427SYS_UserDescription, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,93);\"", 0, 1, edtSYS_UserDescription_Enabled, 0, 80, "chr", 10, "row", StyleString, ClassString, "", "", "2048", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_SYS_User.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtRocheAccount_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtRocheAccount_Internalname, "Roche Account", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 98,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtRocheAccount_Internalname, A428RocheAccount, StringUtil.RTrim( context.localUtil.Format( A428RocheAccount, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,98);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtRocheAccount_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtRocheAccount_Enabled, 0, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_SYS_User.htm");
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
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 103,'',false,'',0)\"";
            ClassString = "BtnEnter";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_enter_Internalname, "", "确认", bttBtn_enter_Jsonclick, 5, "确认", "", StyleString, ClassString, bttBtn_enter_Visible, bttBtn_enter_Enabled, "standard", "'"+""+"'"+",false,"+"'"+"EENTER."+"'", TempTags, "", context.GetButtonType( ), "HLP_SYS_User.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 105,'',false,'',0)\"";
            ClassString = "BtnCancel";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_cancel_Internalname, "", "取消", bttBtn_cancel_Jsonclick, 1, "取消", "", StyleString, ClassString, bttBtn_cancel_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ECANCEL."+"'", TempTags, "", context.GetButtonType( ), "HLP_SYS_User.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 107,'',false,'',0)\"";
            ClassString = "BtnDelete";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_delete_Internalname, "", "删除", bttBtn_delete_Jsonclick, 5, "删除", "", StyleString, ClassString, bttBtn_delete_Visible, bttBtn_delete_Enabled, "standard", "'"+""+"'"+",false,"+"'"+"EDELETE."+"'", TempTags, "", context.GetButtonType( ), "HLP_SYS_User.htm");
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
               A416DisplayName = cgiGet( edtDisplayName_Internalname);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A416DisplayName", A416DisplayName);
               if ( ( ( context.localUtil.CToN( cgiGet( edtUserType_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtUserType_Internalname), ".", ",") > Convert.ToDecimal( 999999999 )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "USERTYPE");
                  AnyError = 1;
                  GX_FocusControl = edtUserType_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A417UserType = 0;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A417UserType", StringUtil.LTrim( StringUtil.Str( (decimal)(A417UserType), 9, 0)));
               }
               else
               {
                  A417UserType = (int)(context.localUtil.CToN( cgiGet( edtUserType_Internalname), ".", ","));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A417UserType", StringUtil.LTrim( StringUtil.Str( (decimal)(A417UserType), 9, 0)));
               }
               A364Account = cgiGet( edtAccount_Internalname);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A364Account", A364Account);
               A418PasswordHash = cgiGet( edtPasswordHash_Internalname);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A418PasswordHash", A418PasswordHash);
               A419LoginIP = cgiGet( edtLoginIP_Internalname);
               n419LoginIP = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A419LoginIP", A419LoginIP);
               n419LoginIP = (String.IsNullOrEmpty(StringUtil.RTrim( A419LoginIP)) ? true : false);
               if ( context.localUtil.VCDateTime( cgiGet( edtLoginTime_Internalname), 0, 0) == 0 )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_baddatetime", new   object[]  {"Login Time"}), 1, "LOGINTIME");
                  AnyError = 1;
                  GX_FocusControl = edtLoginTime_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A420LoginTime = (DateTime)(DateTime.MinValue);
                  n420LoginTime = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A420LoginTime", context.localUtil.TToC( A420LoginTime, 10, 8, 0, 0, "/", ":", " "));
               }
               else
               {
                  A420LoginTime = context.localUtil.CToT( cgiGet( edtLoginTime_Internalname));
                  n420LoginTime = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A420LoginTime", context.localUtil.TToC( A420LoginTime, 10, 8, 0, 0, "/", ":", " "));
               }
               n420LoginTime = ((DateTime.MinValue==A420LoginTime) ? true : false);
               A421SYS_UserCreator = cgiGet( edtSYS_UserCreator_Internalname);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A421SYS_UserCreator", A421SYS_UserCreator);
               if ( context.localUtil.VCDateTime( cgiGet( edtSYS_UserCreateTime_Internalname), 0, 0) == 0 )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_baddatetime", new   object[]  {"SYS_User Create Time"}), 1, "SYS_USERCREATETIME");
                  AnyError = 1;
                  GX_FocusControl = edtSYS_UserCreateTime_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A422SYS_UserCreateTime = (DateTime)(DateTime.MinValue);
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A422SYS_UserCreateTime", context.localUtil.TToC( A422SYS_UserCreateTime, 10, 8, 0, 0, "/", ":", " "));
               }
               else
               {
                  A422SYS_UserCreateTime = context.localUtil.CToT( cgiGet( edtSYS_UserCreateTime_Internalname));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A422SYS_UserCreateTime", context.localUtil.TToC( A422SYS_UserCreateTime, 10, 8, 0, 0, "/", ":", " "));
               }
               A423SYS_UserModifier = cgiGet( edtSYS_UserModifier_Internalname);
               n423SYS_UserModifier = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A423SYS_UserModifier", A423SYS_UserModifier);
               n423SYS_UserModifier = (String.IsNullOrEmpty(StringUtil.RTrim( A423SYS_UserModifier)) ? true : false);
               if ( context.localUtil.VCDateTime( cgiGet( edtSYS_UserModifyTime_Internalname), 0, 0) == 0 )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_baddatetime", new   object[]  {"SYS_User Modify Time"}), 1, "SYS_USERMODIFYTIME");
                  AnyError = 1;
                  GX_FocusControl = edtSYS_UserModifyTime_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A424SYS_UserModifyTime = (DateTime)(DateTime.MinValue);
                  n424SYS_UserModifyTime = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A424SYS_UserModifyTime", context.localUtil.TToC( A424SYS_UserModifyTime, 10, 8, 0, 0, "/", ":", " "));
               }
               else
               {
                  A424SYS_UserModifyTime = context.localUtil.CToT( cgiGet( edtSYS_UserModifyTime_Internalname));
                  n424SYS_UserModifyTime = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A424SYS_UserModifyTime", context.localUtil.TToC( A424SYS_UserModifyTime, 10, 8, 0, 0, "/", ":", " "));
               }
               n424SYS_UserModifyTime = ((DateTime.MinValue==A424SYS_UserModifyTime) ? true : false);
               if ( ( ( context.localUtil.CToN( cgiGet( edtSYS_UserIsDeleted_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtSYS_UserIsDeleted_Internalname), ".", ",") > Convert.ToDecimal( 9 )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "SYS_USERISDELETED");
                  AnyError = 1;
                  GX_FocusControl = edtSYS_UserIsDeleted_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A425SYS_UserIsDeleted = 0;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A425SYS_UserIsDeleted", StringUtil.Str( (decimal)(A425SYS_UserIsDeleted), 1, 0));
               }
               else
               {
                  A425SYS_UserIsDeleted = (short)(context.localUtil.CToN( cgiGet( edtSYS_UserIsDeleted_Internalname), ".", ","));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A425SYS_UserIsDeleted", StringUtil.Str( (decimal)(A425SYS_UserIsDeleted), 1, 0));
               }
               A426Email = cgiGet( edtEmail_Internalname);
               n426Email = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A426Email", A426Email);
               n426Email = (String.IsNullOrEmpty(StringUtil.RTrim( A426Email)) ? true : false);
               A427SYS_UserDescription = cgiGet( edtSYS_UserDescription_Internalname);
               n427SYS_UserDescription = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A427SYS_UserDescription", A427SYS_UserDescription);
               n427SYS_UserDescription = (String.IsNullOrEmpty(StringUtil.RTrim( A427SYS_UserDescription)) ? true : false);
               A428RocheAccount = cgiGet( edtRocheAccount_Internalname);
               n428RocheAccount = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A428RocheAccount", A428RocheAccount);
               n428RocheAccount = (String.IsNullOrEmpty(StringUtil.RTrim( A428RocheAccount)) ? true : false);
               /* Read saved values. */
               Z359UserID = (Guid)(StringUtil.StrToGuid( cgiGet( "Z359UserID")));
               Z416DisplayName = cgiGet( "Z416DisplayName");
               Z417UserType = (int)(context.localUtil.CToN( cgiGet( "Z417UserType"), ".", ","));
               Z364Account = cgiGet( "Z364Account");
               Z418PasswordHash = cgiGet( "Z418PasswordHash");
               Z419LoginIP = cgiGet( "Z419LoginIP");
               n419LoginIP = (String.IsNullOrEmpty(StringUtil.RTrim( A419LoginIP)) ? true : false);
               Z420LoginTime = context.localUtil.CToT( cgiGet( "Z420LoginTime"), 0);
               n420LoginTime = ((DateTime.MinValue==A420LoginTime) ? true : false);
               Z421SYS_UserCreator = cgiGet( "Z421SYS_UserCreator");
               Z422SYS_UserCreateTime = context.localUtil.CToT( cgiGet( "Z422SYS_UserCreateTime"), 0);
               Z423SYS_UserModifier = cgiGet( "Z423SYS_UserModifier");
               n423SYS_UserModifier = (String.IsNullOrEmpty(StringUtil.RTrim( A423SYS_UserModifier)) ? true : false);
               Z424SYS_UserModifyTime = context.localUtil.CToT( cgiGet( "Z424SYS_UserModifyTime"), 0);
               n424SYS_UserModifyTime = ((DateTime.MinValue==A424SYS_UserModifyTime) ? true : false);
               Z425SYS_UserIsDeleted = (short)(context.localUtil.CToN( cgiGet( "Z425SYS_UserIsDeleted"), ".", ","));
               Z426Email = cgiGet( "Z426Email");
               n426Email = (String.IsNullOrEmpty(StringUtil.RTrim( A426Email)) ? true : false);
               Z428RocheAccount = cgiGet( "Z428RocheAccount");
               n428RocheAccount = (String.IsNullOrEmpty(StringUtil.RTrim( A428RocheAccount)) ? true : false);
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
                  A359UserID = (Guid)(StringUtil.StrToGuid( GetNextPar( )));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A359UserID", A359UserID.ToString());
                  getEqualNoModal( ) ;
                  if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  && (Guid.Empty==A359UserID) && ( Gx_BScreen == 0 ) )
                  {
                     A359UserID = (Guid)(Guid.NewGuid( ));
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A359UserID", A359UserID.ToString());
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
               InitAll1D50( ) ;
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
         DisableAttributes1D50( ) ;
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

      protected void ResetCaption1D0( )
      {
      }

      protected void ZM1D50( short GX_JID )
      {
         if ( ( GX_JID == 6 ) || ( GX_JID == 0 ) )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
            {
               Z416DisplayName = T001D3_A416DisplayName[0];
               Z417UserType = T001D3_A417UserType[0];
               Z364Account = T001D3_A364Account[0];
               Z418PasswordHash = T001D3_A418PasswordHash[0];
               Z419LoginIP = T001D3_A419LoginIP[0];
               Z420LoginTime = T001D3_A420LoginTime[0];
               Z421SYS_UserCreator = T001D3_A421SYS_UserCreator[0];
               Z422SYS_UserCreateTime = T001D3_A422SYS_UserCreateTime[0];
               Z423SYS_UserModifier = T001D3_A423SYS_UserModifier[0];
               Z424SYS_UserModifyTime = T001D3_A424SYS_UserModifyTime[0];
               Z425SYS_UserIsDeleted = T001D3_A425SYS_UserIsDeleted[0];
               Z426Email = T001D3_A426Email[0];
               Z428RocheAccount = T001D3_A428RocheAccount[0];
            }
            else
            {
               Z416DisplayName = A416DisplayName;
               Z417UserType = A417UserType;
               Z364Account = A364Account;
               Z418PasswordHash = A418PasswordHash;
               Z419LoginIP = A419LoginIP;
               Z420LoginTime = A420LoginTime;
               Z421SYS_UserCreator = A421SYS_UserCreator;
               Z422SYS_UserCreateTime = A422SYS_UserCreateTime;
               Z423SYS_UserModifier = A423SYS_UserModifier;
               Z424SYS_UserModifyTime = A424SYS_UserModifyTime;
               Z425SYS_UserIsDeleted = A425SYS_UserIsDeleted;
               Z426Email = A426Email;
               Z428RocheAccount = A428RocheAccount;
            }
         }
         if ( GX_JID == -6 )
         {
            Z359UserID = (Guid)(A359UserID);
            Z416DisplayName = A416DisplayName;
            Z417UserType = A417UserType;
            Z364Account = A364Account;
            Z418PasswordHash = A418PasswordHash;
            Z419LoginIP = A419LoginIP;
            Z420LoginTime = A420LoginTime;
            Z421SYS_UserCreator = A421SYS_UserCreator;
            Z422SYS_UserCreateTime = A422SYS_UserCreateTime;
            Z423SYS_UserModifier = A423SYS_UserModifier;
            Z424SYS_UserModifyTime = A424SYS_UserModifyTime;
            Z425SYS_UserIsDeleted = A425SYS_UserIsDeleted;
            Z426Email = A426Email;
            Z427SYS_UserDescription = A427SYS_UserDescription;
            Z428RocheAccount = A428RocheAccount;
         }
      }

      protected void standaloneNotModal( )
      {
         Gx_BScreen = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_BScreen", StringUtil.Str( (decimal)(Gx_BScreen), 1, 0));
      }

      protected void standaloneModal( )
      {
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  && (Guid.Empty==A359UserID) && ( Gx_BScreen == 0 ) )
         {
            A359UserID = (Guid)(Guid.NewGuid( ));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A359UserID", A359UserID.ToString());
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

      protected void Load1D50( )
      {
         /* Using cursor T001D4 */
         pr_datastore1.execute(2, new Object[] {A359UserID});
         if ( (pr_datastore1.getStatus(2) != 101) )
         {
            RcdFound50 = 1;
            A416DisplayName = T001D4_A416DisplayName[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A416DisplayName", A416DisplayName);
            A417UserType = T001D4_A417UserType[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A417UserType", StringUtil.LTrim( StringUtil.Str( (decimal)(A417UserType), 9, 0)));
            A364Account = T001D4_A364Account[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A364Account", A364Account);
            A418PasswordHash = T001D4_A418PasswordHash[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A418PasswordHash", A418PasswordHash);
            A419LoginIP = T001D4_A419LoginIP[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A419LoginIP", A419LoginIP);
            n419LoginIP = T001D4_n419LoginIP[0];
            A420LoginTime = T001D4_A420LoginTime[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A420LoginTime", context.localUtil.TToC( A420LoginTime, 10, 8, 0, 0, "/", ":", " "));
            n420LoginTime = T001D4_n420LoginTime[0];
            A421SYS_UserCreator = T001D4_A421SYS_UserCreator[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A421SYS_UserCreator", A421SYS_UserCreator);
            A422SYS_UserCreateTime = T001D4_A422SYS_UserCreateTime[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A422SYS_UserCreateTime", context.localUtil.TToC( A422SYS_UserCreateTime, 10, 8, 0, 0, "/", ":", " "));
            A423SYS_UserModifier = T001D4_A423SYS_UserModifier[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A423SYS_UserModifier", A423SYS_UserModifier);
            n423SYS_UserModifier = T001D4_n423SYS_UserModifier[0];
            A424SYS_UserModifyTime = T001D4_A424SYS_UserModifyTime[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A424SYS_UserModifyTime", context.localUtil.TToC( A424SYS_UserModifyTime, 10, 8, 0, 0, "/", ":", " "));
            n424SYS_UserModifyTime = T001D4_n424SYS_UserModifyTime[0];
            A425SYS_UserIsDeleted = T001D4_A425SYS_UserIsDeleted[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A425SYS_UserIsDeleted", StringUtil.Str( (decimal)(A425SYS_UserIsDeleted), 1, 0));
            A426Email = T001D4_A426Email[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A426Email", A426Email);
            n426Email = T001D4_n426Email[0];
            A427SYS_UserDescription = T001D4_A427SYS_UserDescription[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A427SYS_UserDescription", A427SYS_UserDescription);
            n427SYS_UserDescription = T001D4_n427SYS_UserDescription[0];
            A428RocheAccount = T001D4_A428RocheAccount[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A428RocheAccount", A428RocheAccount);
            n428RocheAccount = T001D4_n428RocheAccount[0];
            ZM1D50( -6) ;
         }
         pr_datastore1.close(2);
         OnLoadActions1D50( ) ;
      }

      protected void OnLoadActions1D50( )
      {
      }

      protected void CheckExtendedTable1D50( )
      {
         Gx_BScreen = 1;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_BScreen", StringUtil.Str( (decimal)(Gx_BScreen), 1, 0));
         standaloneModal( ) ;
         /* Using cursor T001D5 */
         pr_datastore1.execute(3, new Object[] {A364Account, A359UserID});
         if ( (pr_datastore1.getStatus(3) != 101) )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_1004", new   object[]  {"Account"}), 1, "ACCOUNT");
            AnyError = 1;
            GX_FocusControl = edtAccount_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         pr_datastore1.close(3);
         if ( ! ( (DateTime.MinValue==A420LoginTime) || ( A420LoginTime >= context.localUtil.YMDHMSToT( 1753, 1, 1, 0, 0, 0) ) ) )
         {
            GX_msglist.addItem("域Login Time超界", "OutOfRange", 1, "LOGINTIME");
            AnyError = 1;
            GX_FocusControl = edtLoginTime_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( ! ( (DateTime.MinValue==A422SYS_UserCreateTime) || ( A422SYS_UserCreateTime >= context.localUtil.YMDHMSToT( 1753, 1, 1, 0, 0, 0) ) ) )
         {
            GX_msglist.addItem("域SYS_User Create Time超界", "OutOfRange", 1, "SYS_USERCREATETIME");
            AnyError = 1;
            GX_FocusControl = edtSYS_UserCreateTime_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( ! ( (DateTime.MinValue==A424SYS_UserModifyTime) || ( A424SYS_UserModifyTime >= context.localUtil.YMDHMSToT( 1753, 1, 1, 0, 0, 0) ) ) )
         {
            GX_msglist.addItem("域SYS_User Modify Time超界", "OutOfRange", 1, "SYS_USERMODIFYTIME");
            AnyError = 1;
            GX_FocusControl = edtSYS_UserModifyTime_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
      }

      protected void CloseExtendedTableCursors1D50( )
      {
      }

      protected void enableDisable( )
      {
      }

      protected void GetKey1D50( )
      {
         /* Using cursor T001D6 */
         pr_datastore1.execute(4, new Object[] {A359UserID});
         if ( (pr_datastore1.getStatus(4) != 101) )
         {
            RcdFound50 = 1;
         }
         else
         {
            RcdFound50 = 0;
         }
         pr_datastore1.close(4);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor T001D3 */
         pr_datastore1.execute(1, new Object[] {A359UserID});
         if ( (pr_datastore1.getStatus(1) != 101) )
         {
            ZM1D50( 6) ;
            RcdFound50 = 1;
            A359UserID = (Guid)((Guid)(T001D3_A359UserID[0]));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A359UserID", A359UserID.ToString());
            A416DisplayName = T001D3_A416DisplayName[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A416DisplayName", A416DisplayName);
            A417UserType = T001D3_A417UserType[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A417UserType", StringUtil.LTrim( StringUtil.Str( (decimal)(A417UserType), 9, 0)));
            A364Account = T001D3_A364Account[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A364Account", A364Account);
            A418PasswordHash = T001D3_A418PasswordHash[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A418PasswordHash", A418PasswordHash);
            A419LoginIP = T001D3_A419LoginIP[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A419LoginIP", A419LoginIP);
            n419LoginIP = T001D3_n419LoginIP[0];
            A420LoginTime = T001D3_A420LoginTime[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A420LoginTime", context.localUtil.TToC( A420LoginTime, 10, 8, 0, 0, "/", ":", " "));
            n420LoginTime = T001D3_n420LoginTime[0];
            A421SYS_UserCreator = T001D3_A421SYS_UserCreator[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A421SYS_UserCreator", A421SYS_UserCreator);
            A422SYS_UserCreateTime = T001D3_A422SYS_UserCreateTime[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A422SYS_UserCreateTime", context.localUtil.TToC( A422SYS_UserCreateTime, 10, 8, 0, 0, "/", ":", " "));
            A423SYS_UserModifier = T001D3_A423SYS_UserModifier[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A423SYS_UserModifier", A423SYS_UserModifier);
            n423SYS_UserModifier = T001D3_n423SYS_UserModifier[0];
            A424SYS_UserModifyTime = T001D3_A424SYS_UserModifyTime[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A424SYS_UserModifyTime", context.localUtil.TToC( A424SYS_UserModifyTime, 10, 8, 0, 0, "/", ":", " "));
            n424SYS_UserModifyTime = T001D3_n424SYS_UserModifyTime[0];
            A425SYS_UserIsDeleted = T001D3_A425SYS_UserIsDeleted[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A425SYS_UserIsDeleted", StringUtil.Str( (decimal)(A425SYS_UserIsDeleted), 1, 0));
            A426Email = T001D3_A426Email[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A426Email", A426Email);
            n426Email = T001D3_n426Email[0];
            A427SYS_UserDescription = T001D3_A427SYS_UserDescription[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A427SYS_UserDescription", A427SYS_UserDescription);
            n427SYS_UserDescription = T001D3_n427SYS_UserDescription[0];
            A428RocheAccount = T001D3_A428RocheAccount[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A428RocheAccount", A428RocheAccount);
            n428RocheAccount = T001D3_n428RocheAccount[0];
            Z359UserID = (Guid)(A359UserID);
            sMode50 = Gx_mode;
            Gx_mode = "DSP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            standaloneModal( ) ;
            Load1D50( ) ;
            if ( AnyError == 1 )
            {
               RcdFound50 = 0;
               InitializeNonKey1D50( ) ;
            }
            Gx_mode = sMode50;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         else
         {
            RcdFound50 = 0;
            InitializeNonKey1D50( ) ;
            sMode50 = Gx_mode;
            Gx_mode = "DSP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            standaloneModal( ) ;
            Gx_mode = sMode50;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         pr_datastore1.close(1);
      }

      protected void getEqualNoModal( )
      {
         GetKey1D50( ) ;
         if ( RcdFound50 == 0 )
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
         RcdFound50 = 0;
         /* Using cursor T001D7 */
         pr_datastore1.execute(5, new Object[] {A359UserID});
         if ( (pr_datastore1.getStatus(5) != 101) )
         {
            while ( (pr_datastore1.getStatus(5) != 101) && ( ( GuidUtil.Compare(T001D7_A359UserID[0], A359UserID, 1) < 0 ) ) )
            {
               pr_datastore1.readNext(5);
            }
            if ( (pr_datastore1.getStatus(5) != 101) && ( ( GuidUtil.Compare(T001D7_A359UserID[0], A359UserID, 1) > 0 ) ) )
            {
               A359UserID = (Guid)((Guid)(T001D7_A359UserID[0]));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A359UserID", A359UserID.ToString());
               RcdFound50 = 1;
            }
         }
         pr_datastore1.close(5);
      }

      protected void move_previous( )
      {
         RcdFound50 = 0;
         /* Using cursor T001D8 */
         pr_datastore1.execute(6, new Object[] {A359UserID});
         if ( (pr_datastore1.getStatus(6) != 101) )
         {
            while ( (pr_datastore1.getStatus(6) != 101) && ( ( GuidUtil.Compare(T001D8_A359UserID[0], A359UserID, 1) > 0 ) ) )
            {
               pr_datastore1.readNext(6);
            }
            if ( (pr_datastore1.getStatus(6) != 101) && ( ( GuidUtil.Compare(T001D8_A359UserID[0], A359UserID, 1) < 0 ) ) )
            {
               A359UserID = (Guid)((Guid)(T001D8_A359UserID[0]));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A359UserID", A359UserID.ToString());
               RcdFound50 = 1;
            }
         }
         pr_datastore1.close(6);
      }

      protected void btn_enter( )
      {
         nKeyPressed = 1;
         GetKey1D50( ) ;
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            /* Insert record */
            GX_FocusControl = edtUserID_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            Insert1D50( ) ;
            if ( AnyError == 1 )
            {
               GX_FocusControl = "";
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
         }
         else
         {
            if ( RcdFound50 == 1 )
            {
               if ( A359UserID != Z359UserID )
               {
                  A359UserID = (Guid)(Z359UserID);
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A359UserID", A359UserID.ToString());
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
                  Update1D50( ) ;
                  GX_FocusControl = edtUserID_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
            }
            else
            {
               if ( A359UserID != Z359UserID )
               {
                  Gx_mode = "INS";
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                  /* Insert record */
                  GX_FocusControl = edtUserID_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  Insert1D50( ) ;
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
                     Insert1D50( ) ;
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
         if ( A359UserID != Z359UserID )
         {
            A359UserID = (Guid)(Z359UserID);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A359UserID", A359UserID.ToString());
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
         if ( RcdFound50 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_keynfound", ""), "PrimaryKeyNotFound", 1, "USERID");
            AnyError = 1;
            GX_FocusControl = edtUserID_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         GX_FocusControl = edtDisplayName_Internalname;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_first( )
      {
         nKeyPressed = 2;
         IsConfirmed = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "IsConfirmed", StringUtil.LTrim( StringUtil.Str( (decimal)(IsConfirmed), 4, 0)));
         ScanStart1D50( ) ;
         if ( RcdFound50 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "", true);
         }
         else
         {
            Gx_mode = "UPD";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtDisplayName_Internalname;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         ScanEnd1D50( ) ;
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
         if ( RcdFound50 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "", true);
         }
         else
         {
            Gx_mode = "UPD";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtDisplayName_Internalname;
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
         if ( RcdFound50 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "", true);
         }
         else
         {
            Gx_mode = "UPD";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtDisplayName_Internalname;
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
         ScanStart1D50( ) ;
         if ( RcdFound50 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "", true);
         }
         else
         {
            while ( RcdFound50 != 0 )
            {
               ScanNext1D50( ) ;
            }
            Gx_mode = "UPD";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtDisplayName_Internalname;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         ScanEnd1D50( ) ;
         getByPrimaryKey( ) ;
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_select( )
      {
         getEqualNoModal( ) ;
      }

      protected void CheckOptimisticConcurrency1D50( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor T001D2 */
            pr_datastore1.execute(0, new Object[] {A359UserID});
            if ( (pr_datastore1.getStatus(0) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"SYS_USER"}), "RecordIsLocked", 1, "");
               AnyError = 1;
               return  ;
            }
            Gx_longc = false;
            if ( (pr_datastore1.getStatus(0) == 101) || ( StringUtil.StrCmp(Z416DisplayName, T001D2_A416DisplayName[0]) != 0 ) || ( Z417UserType != T001D2_A417UserType[0] ) || ( StringUtil.StrCmp(Z364Account, T001D2_A364Account[0]) != 0 ) || ( StringUtil.StrCmp(Z418PasswordHash, T001D2_A418PasswordHash[0]) != 0 ) || ( StringUtil.StrCmp(Z419LoginIP, T001D2_A419LoginIP[0]) != 0 ) )
            {
               Gx_longc = true;
            }
            if ( Gx_longc || ( Z420LoginTime != T001D2_A420LoginTime[0] ) || ( StringUtil.StrCmp(Z421SYS_UserCreator, T001D2_A421SYS_UserCreator[0]) != 0 ) || ( Z422SYS_UserCreateTime != T001D2_A422SYS_UserCreateTime[0] ) || ( StringUtil.StrCmp(Z423SYS_UserModifier, T001D2_A423SYS_UserModifier[0]) != 0 ) || ( Z424SYS_UserModifyTime != T001D2_A424SYS_UserModifyTime[0] ) )
            {
               Gx_longc = true;
            }
            if ( Gx_longc || ( Z425SYS_UserIsDeleted != T001D2_A425SYS_UserIsDeleted[0] ) || ( StringUtil.StrCmp(Z426Email, T001D2_A426Email[0]) != 0 ) || ( StringUtil.StrCmp(Z428RocheAccount, T001D2_A428RocheAccount[0]) != 0 ) )
            {
               if ( StringUtil.StrCmp(Z416DisplayName, T001D2_A416DisplayName[0]) != 0 )
               {
                  GXUtil.WriteLog("sys_user:[seudo value changed for attri]"+"DisplayName");
                  GXUtil.WriteLogRaw("Old: ",Z416DisplayName);
                  GXUtil.WriteLogRaw("Current: ",T001D2_A416DisplayName[0]);
               }
               if ( Z417UserType != T001D2_A417UserType[0] )
               {
                  GXUtil.WriteLog("sys_user:[seudo value changed for attri]"+"UserType");
                  GXUtil.WriteLogRaw("Old: ",Z417UserType);
                  GXUtil.WriteLogRaw("Current: ",T001D2_A417UserType[0]);
               }
               if ( StringUtil.StrCmp(Z364Account, T001D2_A364Account[0]) != 0 )
               {
                  GXUtil.WriteLog("sys_user:[seudo value changed for attri]"+"Account");
                  GXUtil.WriteLogRaw("Old: ",Z364Account);
                  GXUtil.WriteLogRaw("Current: ",T001D2_A364Account[0]);
               }
               if ( StringUtil.StrCmp(Z418PasswordHash, T001D2_A418PasswordHash[0]) != 0 )
               {
                  GXUtil.WriteLog("sys_user:[seudo value changed for attri]"+"PasswordHash");
                  GXUtil.WriteLogRaw("Old: ",Z418PasswordHash);
                  GXUtil.WriteLogRaw("Current: ",T001D2_A418PasswordHash[0]);
               }
               if ( StringUtil.StrCmp(Z419LoginIP, T001D2_A419LoginIP[0]) != 0 )
               {
                  GXUtil.WriteLog("sys_user:[seudo value changed for attri]"+"LoginIP");
                  GXUtil.WriteLogRaw("Old: ",Z419LoginIP);
                  GXUtil.WriteLogRaw("Current: ",T001D2_A419LoginIP[0]);
               }
               if ( Z420LoginTime != T001D2_A420LoginTime[0] )
               {
                  GXUtil.WriteLog("sys_user:[seudo value changed for attri]"+"LoginTime");
                  GXUtil.WriteLogRaw("Old: ",Z420LoginTime);
                  GXUtil.WriteLogRaw("Current: ",T001D2_A420LoginTime[0]);
               }
               if ( StringUtil.StrCmp(Z421SYS_UserCreator, T001D2_A421SYS_UserCreator[0]) != 0 )
               {
                  GXUtil.WriteLog("sys_user:[seudo value changed for attri]"+"SYS_UserCreator");
                  GXUtil.WriteLogRaw("Old: ",Z421SYS_UserCreator);
                  GXUtil.WriteLogRaw("Current: ",T001D2_A421SYS_UserCreator[0]);
               }
               if ( Z422SYS_UserCreateTime != T001D2_A422SYS_UserCreateTime[0] )
               {
                  GXUtil.WriteLog("sys_user:[seudo value changed for attri]"+"SYS_UserCreateTime");
                  GXUtil.WriteLogRaw("Old: ",Z422SYS_UserCreateTime);
                  GXUtil.WriteLogRaw("Current: ",T001D2_A422SYS_UserCreateTime[0]);
               }
               if ( StringUtil.StrCmp(Z423SYS_UserModifier, T001D2_A423SYS_UserModifier[0]) != 0 )
               {
                  GXUtil.WriteLog("sys_user:[seudo value changed for attri]"+"SYS_UserModifier");
                  GXUtil.WriteLogRaw("Old: ",Z423SYS_UserModifier);
                  GXUtil.WriteLogRaw("Current: ",T001D2_A423SYS_UserModifier[0]);
               }
               if ( Z424SYS_UserModifyTime != T001D2_A424SYS_UserModifyTime[0] )
               {
                  GXUtil.WriteLog("sys_user:[seudo value changed for attri]"+"SYS_UserModifyTime");
                  GXUtil.WriteLogRaw("Old: ",Z424SYS_UserModifyTime);
                  GXUtil.WriteLogRaw("Current: ",T001D2_A424SYS_UserModifyTime[0]);
               }
               if ( Z425SYS_UserIsDeleted != T001D2_A425SYS_UserIsDeleted[0] )
               {
                  GXUtil.WriteLog("sys_user:[seudo value changed for attri]"+"SYS_UserIsDeleted");
                  GXUtil.WriteLogRaw("Old: ",Z425SYS_UserIsDeleted);
                  GXUtil.WriteLogRaw("Current: ",T001D2_A425SYS_UserIsDeleted[0]);
               }
               if ( StringUtil.StrCmp(Z426Email, T001D2_A426Email[0]) != 0 )
               {
                  GXUtil.WriteLog("sys_user:[seudo value changed for attri]"+"Email");
                  GXUtil.WriteLogRaw("Old: ",Z426Email);
                  GXUtil.WriteLogRaw("Current: ",T001D2_A426Email[0]);
               }
               if ( StringUtil.StrCmp(Z428RocheAccount, T001D2_A428RocheAccount[0]) != 0 )
               {
                  GXUtil.WriteLog("sys_user:[seudo value changed for attri]"+"RocheAccount");
                  GXUtil.WriteLogRaw("Old: ",Z428RocheAccount);
                  GXUtil.WriteLogRaw("Current: ",T001D2_A428RocheAccount[0]);
               }
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"SYS_USER"}), "RecordWasChanged", 1, "");
               AnyError = 1;
               return  ;
            }
         }
      }

      protected void Insert1D50( )
      {
         BeforeValidate1D50( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable1D50( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM1D50( 0) ;
            CheckOptimisticConcurrency1D50( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm1D50( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert1D50( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T001D9 */
                     pr_datastore1.execute(7, new Object[] {A416DisplayName, A417UserType, A364Account, A418PasswordHash, n419LoginIP, A419LoginIP, n420LoginTime, A420LoginTime, A421SYS_UserCreator, A422SYS_UserCreateTime, n423SYS_UserModifier, A423SYS_UserModifier, n424SYS_UserModifyTime, A424SYS_UserModifyTime, A425SYS_UserIsDeleted, n426Email, A426Email, n427SYS_UserDescription, A427SYS_UserDescription, n428RocheAccount, A428RocheAccount, A359UserID});
                     pr_datastore1.close(7);
                     dsDataStore1.SmartCacheProvider.SetUpdated("SYS_USER") ;
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
                           ResetCaption1D0( ) ;
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
               Load1D50( ) ;
            }
            EndLevel1D50( ) ;
         }
         CloseExtendedTableCursors1D50( ) ;
      }

      protected void Update1D50( )
      {
         BeforeValidate1D50( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable1D50( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency1D50( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm1D50( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate1D50( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T001D10 */
                     pr_datastore1.execute(8, new Object[] {A416DisplayName, A417UserType, A364Account, A418PasswordHash, n419LoginIP, A419LoginIP, n420LoginTime, A420LoginTime, A421SYS_UserCreator, A422SYS_UserCreateTime, n423SYS_UserModifier, A423SYS_UserModifier, n424SYS_UserModifyTime, A424SYS_UserModifyTime, A425SYS_UserIsDeleted, n426Email, A426Email, n427SYS_UserDescription, A427SYS_UserDescription, n428RocheAccount, A428RocheAccount, A359UserID});
                     pr_datastore1.close(8);
                     dsDataStore1.SmartCacheProvider.SetUpdated("SYS_USER") ;
                     if ( (pr_datastore1.getStatus(8) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"SYS_USER"}), "RecordIsLocked", 1, "");
                        AnyError = 1;
                     }
                     DeferredUpdate1D50( ) ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( update) rules */
                        /* End of After( update) rules */
                        if ( AnyError == 0 )
                        {
                           getByPrimaryKey( ) ;
                           GX_msglist.addItem(context.GetMessage( "GXM_sucupdated", ""), "SuccessfullyUpdated", 0, "", true);
                           ResetCaption1D0( ) ;
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
            EndLevel1D50( ) ;
         }
         CloseExtendedTableCursors1D50( ) ;
      }

      protected void DeferredUpdate1D50( )
      {
      }

      protected void delete( )
      {
         Gx_mode = "DLT";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         BeforeValidate1D50( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency1D50( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls1D50( ) ;
            AfterConfirm1D50( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete1D50( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor T001D11 */
                  pr_datastore1.execute(9, new Object[] {A359UserID});
                  pr_datastore1.close(9);
                  dsDataStore1.SmartCacheProvider.SetUpdated("SYS_USER") ;
                  if ( AnyError == 0 )
                  {
                     /* Start of After( delete) rules */
                     /* End of After( delete) rules */
                     if ( AnyError == 0 )
                     {
                        move_next( ) ;
                        if ( RcdFound50 == 0 )
                        {
                           InitAll1D50( ) ;
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
                        ResetCaption1D0( ) ;
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
         sMode50 = Gx_mode;
         Gx_mode = "DLT";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         EndLevel1D50( ) ;
         Gx_mode = sMode50;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
      }

      protected void OnDeleteControls1D50( )
      {
         standaloneModal( ) ;
         /* No delete mode formulas found. */
         if ( AnyError == 0 )
         {
            /* Using cursor T001D12 */
            pr_datastore1.execute(10, new Object[] {A359UserID});
            if ( (pr_datastore1.getStatus(10) != 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_del", new   object[]  {"SYS_Institute User"}), "CannotDeleteReferencedRecord", 1, "");
               AnyError = 1;
            }
            pr_datastore1.close(10);
            /* Using cursor T001D13 */
            pr_datastore1.execute(11, new Object[] {A359UserID});
            if ( (pr_datastore1.getStatus(11) != 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_del", new   object[]  {"SYS_Tenant User"}), "CannotDeleteReferencedRecord", 1, "");
               AnyError = 1;
            }
            pr_datastore1.close(11);
            /* Using cursor T001D14 */
            pr_datastore1.execute(12, new Object[] {A359UserID});
            if ( (pr_datastore1.getStatus(12) != 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_del", new   object[]  {"SYS_User Role"}), "CannotDeleteReferencedRecord", 1, "");
               AnyError = 1;
            }
            pr_datastore1.close(12);
         }
      }

      protected void EndLevel1D50( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            pr_datastore1.close(0);
         }
         if ( AnyError == 0 )
         {
            BeforeComplete1D50( ) ;
         }
         if ( AnyError == 0 )
         {
            pr_datastore1.close(1);
            context.CommitDataStores("sys_user",pr_default);
            if ( AnyError == 0 )
            {
               ConfirmValues1D0( ) ;
            }
            /* After transaction rules */
            /* Execute 'After Trn' event if defined. */
            trnEnded = 1;
         }
         else
         {
            pr_datastore1.close(1);
            context.RollbackDataStores("sys_user",pr_default);
         }
         IsModified = 0;
         if ( AnyError != 0 )
         {
            context.wjLoc = "";
            context.nUserReturn = 0;
         }
      }

      public void ScanStart1D50( )
      {
         /* Using cursor T001D15 */
         pr_datastore1.execute(13);
         RcdFound50 = 0;
         if ( (pr_datastore1.getStatus(13) != 101) )
         {
            RcdFound50 = 1;
            A359UserID = (Guid)((Guid)(T001D15_A359UserID[0]));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A359UserID", A359UserID.ToString());
         }
         /* Load Subordinate Levels */
      }

      protected void ScanNext1D50( )
      {
         /* Scan next routine */
         pr_datastore1.readNext(13);
         RcdFound50 = 0;
         if ( (pr_datastore1.getStatus(13) != 101) )
         {
            RcdFound50 = 1;
            A359UserID = (Guid)((Guid)(T001D15_A359UserID[0]));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A359UserID", A359UserID.ToString());
         }
      }

      protected void ScanEnd1D50( )
      {
         pr_datastore1.close(13);
      }

      protected void AfterConfirm1D50( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert1D50( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate1D50( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete1D50( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete1D50( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate1D50( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes1D50( )
      {
         edtUserID_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtUserID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtUserID_Enabled), 5, 0)), true);
         edtDisplayName_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtDisplayName_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtDisplayName_Enabled), 5, 0)), true);
         edtUserType_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtUserType_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtUserType_Enabled), 5, 0)), true);
         edtAccount_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtAccount_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtAccount_Enabled), 5, 0)), true);
         edtPasswordHash_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtPasswordHash_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtPasswordHash_Enabled), 5, 0)), true);
         edtLoginIP_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtLoginIP_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtLoginIP_Enabled), 5, 0)), true);
         edtLoginTime_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtLoginTime_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtLoginTime_Enabled), 5, 0)), true);
         edtSYS_UserCreator_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtSYS_UserCreator_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtSYS_UserCreator_Enabled), 5, 0)), true);
         edtSYS_UserCreateTime_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtSYS_UserCreateTime_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtSYS_UserCreateTime_Enabled), 5, 0)), true);
         edtSYS_UserModifier_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtSYS_UserModifier_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtSYS_UserModifier_Enabled), 5, 0)), true);
         edtSYS_UserModifyTime_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtSYS_UserModifyTime_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtSYS_UserModifyTime_Enabled), 5, 0)), true);
         edtSYS_UserIsDeleted_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtSYS_UserIsDeleted_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtSYS_UserIsDeleted_Enabled), 5, 0)), true);
         edtEmail_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtEmail_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtEmail_Enabled), 5, 0)), true);
         edtSYS_UserDescription_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtSYS_UserDescription_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtSYS_UserDescription_Enabled), 5, 0)), true);
         edtRocheAccount_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtRocheAccount_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtRocheAccount_Enabled), 5, 0)), true);
      }

      protected void send_integrity_lvl_hashes1D50( )
      {
      }

      protected void assign_properties_default( )
      {
      }

      protected void ConfirmValues1D0( )
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
         context.AddJavascriptSource("gxcfg.js", "?20202279385779", false);
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" autocomplete=\"off\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("sys_user.aspx") +"\">") ;
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
         GxWebStd.gx_hidden_field( context, "Z416DisplayName", Z416DisplayName);
         GxWebStd.gx_hidden_field( context, "Z417UserType", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z417UserType), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "Z364Account", Z364Account);
         GxWebStd.gx_hidden_field( context, "Z418PasswordHash", Z418PasswordHash);
         GxWebStd.gx_hidden_field( context, "Z419LoginIP", Z419LoginIP);
         GxWebStd.gx_hidden_field( context, "Z420LoginTime", context.localUtil.TToC( Z420LoginTime, 10, 8, 0, 0, "/", ":", " "));
         GxWebStd.gx_hidden_field( context, "Z421SYS_UserCreator", Z421SYS_UserCreator);
         GxWebStd.gx_hidden_field( context, "Z422SYS_UserCreateTime", context.localUtil.TToC( Z422SYS_UserCreateTime, 10, 8, 0, 0, "/", ":", " "));
         GxWebStd.gx_hidden_field( context, "Z423SYS_UserModifier", Z423SYS_UserModifier);
         GxWebStd.gx_hidden_field( context, "Z424SYS_UserModifyTime", context.localUtil.TToC( Z424SYS_UserModifyTime, 10, 8, 0, 0, "/", ":", " "));
         GxWebStd.gx_hidden_field( context, "Z425SYS_UserIsDeleted", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z425SYS_UserIsDeleted), 1, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "Z426Email", Z426Email);
         GxWebStd.gx_hidden_field( context, "Z428RocheAccount", Z428RocheAccount);
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
         return formatLink("sys_user.aspx")  ;
      }

      public override String GetPgmname( )
      {
         return "SYS_User" ;
      }

      public override String GetPgmdesc( )
      {
         return "SYS_User" ;
      }

      protected void InitializeNonKey1D50( )
      {
         A416DisplayName = "";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A416DisplayName", A416DisplayName);
         A417UserType = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A417UserType", StringUtil.LTrim( StringUtil.Str( (decimal)(A417UserType), 9, 0)));
         A364Account = "";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A364Account", A364Account);
         A418PasswordHash = "";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A418PasswordHash", A418PasswordHash);
         A419LoginIP = "";
         n419LoginIP = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A419LoginIP", A419LoginIP);
         n419LoginIP = (String.IsNullOrEmpty(StringUtil.RTrim( A419LoginIP)) ? true : false);
         A420LoginTime = (DateTime)(DateTime.MinValue);
         n420LoginTime = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A420LoginTime", context.localUtil.TToC( A420LoginTime, 10, 8, 0, 0, "/", ":", " "));
         n420LoginTime = ((DateTime.MinValue==A420LoginTime) ? true : false);
         A421SYS_UserCreator = "";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A421SYS_UserCreator", A421SYS_UserCreator);
         A422SYS_UserCreateTime = (DateTime)(DateTime.MinValue);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A422SYS_UserCreateTime", context.localUtil.TToC( A422SYS_UserCreateTime, 10, 8, 0, 0, "/", ":", " "));
         A423SYS_UserModifier = "";
         n423SYS_UserModifier = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A423SYS_UserModifier", A423SYS_UserModifier);
         n423SYS_UserModifier = (String.IsNullOrEmpty(StringUtil.RTrim( A423SYS_UserModifier)) ? true : false);
         A424SYS_UserModifyTime = (DateTime)(DateTime.MinValue);
         n424SYS_UserModifyTime = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A424SYS_UserModifyTime", context.localUtil.TToC( A424SYS_UserModifyTime, 10, 8, 0, 0, "/", ":", " "));
         n424SYS_UserModifyTime = ((DateTime.MinValue==A424SYS_UserModifyTime) ? true : false);
         A425SYS_UserIsDeleted = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A425SYS_UserIsDeleted", StringUtil.Str( (decimal)(A425SYS_UserIsDeleted), 1, 0));
         A426Email = "";
         n426Email = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A426Email", A426Email);
         n426Email = (String.IsNullOrEmpty(StringUtil.RTrim( A426Email)) ? true : false);
         A427SYS_UserDescription = "";
         n427SYS_UserDescription = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A427SYS_UserDescription", A427SYS_UserDescription);
         n427SYS_UserDescription = (String.IsNullOrEmpty(StringUtil.RTrim( A427SYS_UserDescription)) ? true : false);
         A428RocheAccount = "";
         n428RocheAccount = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A428RocheAccount", A428RocheAccount);
         n428RocheAccount = (String.IsNullOrEmpty(StringUtil.RTrim( A428RocheAccount)) ? true : false);
         Z416DisplayName = "";
         Z417UserType = 0;
         Z364Account = "";
         Z418PasswordHash = "";
         Z419LoginIP = "";
         Z420LoginTime = (DateTime)(DateTime.MinValue);
         Z421SYS_UserCreator = "";
         Z422SYS_UserCreateTime = (DateTime)(DateTime.MinValue);
         Z423SYS_UserModifier = "";
         Z424SYS_UserModifyTime = (DateTime)(DateTime.MinValue);
         Z425SYS_UserIsDeleted = 0;
         Z426Email = "";
         Z428RocheAccount = "";
      }

      protected void InitAll1D50( )
      {
         A359UserID = (Guid)(Guid.NewGuid( ));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A359UserID", A359UserID.ToString());
         InitializeNonKey1D50( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?20202279385790", true);
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
         context.AddJavascriptSource("sys_user.js", "?20202279385790", false);
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
         edtDisplayName_Internalname = "DISPLAYNAME";
         edtUserType_Internalname = "USERTYPE";
         edtAccount_Internalname = "ACCOUNT";
         edtPasswordHash_Internalname = "PASSWORDHASH";
         edtLoginIP_Internalname = "LOGINIP";
         edtLoginTime_Internalname = "LOGINTIME";
         edtSYS_UserCreator_Internalname = "SYS_USERCREATOR";
         edtSYS_UserCreateTime_Internalname = "SYS_USERCREATETIME";
         edtSYS_UserModifier_Internalname = "SYS_USERMODIFIER";
         edtSYS_UserModifyTime_Internalname = "SYS_USERMODIFYTIME";
         edtSYS_UserIsDeleted_Internalname = "SYS_USERISDELETED";
         edtEmail_Internalname = "EMAIL";
         edtSYS_UserDescription_Internalname = "SYS_USERDESCRIPTION";
         edtRocheAccount_Internalname = "ROCHEACCOUNT";
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
         Form.Caption = "SYS_User";
         bttBtn_delete_Enabled = 1;
         bttBtn_delete_Visible = 1;
         bttBtn_cancel_Visible = 1;
         bttBtn_enter_Enabled = 1;
         bttBtn_enter_Visible = 1;
         edtRocheAccount_Jsonclick = "";
         edtRocheAccount_Enabled = 1;
         edtSYS_UserDescription_Enabled = 1;
         edtEmail_Jsonclick = "";
         edtEmail_Enabled = 1;
         edtSYS_UserIsDeleted_Jsonclick = "";
         edtSYS_UserIsDeleted_Enabled = 1;
         edtSYS_UserModifyTime_Jsonclick = "";
         edtSYS_UserModifyTime_Enabled = 1;
         edtSYS_UserModifier_Jsonclick = "";
         edtSYS_UserModifier_Enabled = 1;
         edtSYS_UserCreateTime_Jsonclick = "";
         edtSYS_UserCreateTime_Enabled = 1;
         edtSYS_UserCreator_Jsonclick = "";
         edtSYS_UserCreator_Enabled = 1;
         edtLoginTime_Jsonclick = "";
         edtLoginTime_Enabled = 1;
         edtLoginIP_Jsonclick = "";
         edtLoginIP_Enabled = 1;
         edtPasswordHash_Jsonclick = "";
         edtPasswordHash_Enabled = 1;
         edtAccount_Jsonclick = "";
         edtAccount_Enabled = 1;
         edtUserType_Jsonclick = "";
         edtUserType_Enabled = 1;
         edtDisplayName_Jsonclick = "";
         edtDisplayName_Enabled = 1;
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
         GX_FocusControl = edtDisplayName_Internalname;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         standaloneNotModal( ) ;
         standaloneModal( ) ;
         /* End function AfterKeyLoadScreen */
      }

      public void Valid_Userid( Guid GX_Parm1 ,
                                String GX_Parm2 ,
                                int GX_Parm3 ,
                                String GX_Parm4 ,
                                String GX_Parm5 ,
                                String GX_Parm6 ,
                                DateTime GX_Parm7 ,
                                String GX_Parm8 ,
                                DateTime GX_Parm9 ,
                                String GX_Parm10 ,
                                DateTime GX_Parm11 ,
                                short GX_Parm12 ,
                                String GX_Parm13 ,
                                String GX_Parm14 ,
                                String GX_Parm15 )
      {
         A359UserID = (Guid)(GX_Parm1);
         A416DisplayName = GX_Parm2;
         A417UserType = GX_Parm3;
         A364Account = GX_Parm4;
         A418PasswordHash = GX_Parm5;
         A419LoginIP = GX_Parm6;
         n419LoginIP = false;
         A420LoginTime = GX_Parm7;
         n420LoginTime = false;
         A421SYS_UserCreator = GX_Parm8;
         A422SYS_UserCreateTime = GX_Parm9;
         A423SYS_UserModifier = GX_Parm10;
         n423SYS_UserModifier = false;
         A424SYS_UserModifyTime = GX_Parm11;
         n424SYS_UserModifyTime = false;
         A425SYS_UserIsDeleted = GX_Parm12;
         A426Email = GX_Parm13;
         n426Email = false;
         A427SYS_UserDescription = GX_Parm14;
         n427SYS_UserDescription = false;
         A428RocheAccount = GX_Parm15;
         n428RocheAccount = false;
         context.wbHandled = 1;
         AfterKeyLoadScreen( ) ;
         Draw( ) ;
         send_integrity_footer_hashes( ) ;
         dynload_actions( ) ;
         if ( AnyError == 1 )
         {
         }
         isValidOutput.Add(A416DisplayName);
         isValidOutput.Add(StringUtil.LTrim( StringUtil.NToC( (decimal)(A417UserType), 9, 0, ".", "")));
         isValidOutput.Add(A364Account);
         isValidOutput.Add(A418PasswordHash);
         isValidOutput.Add(A419LoginIP);
         isValidOutput.Add(context.localUtil.TToC( A420LoginTime, 10, 8, 0, 0, "/", ":", " "));
         isValidOutput.Add(A421SYS_UserCreator);
         isValidOutput.Add(context.localUtil.TToC( A422SYS_UserCreateTime, 10, 8, 0, 0, "/", ":", " "));
         isValidOutput.Add(A423SYS_UserModifier);
         isValidOutput.Add(context.localUtil.TToC( A424SYS_UserModifyTime, 10, 8, 0, 0, "/", ":", " "));
         isValidOutput.Add(StringUtil.LTrim( StringUtil.NToC( (decimal)(A425SYS_UserIsDeleted), 1, 0, ".", "")));
         isValidOutput.Add(A426Email);
         isValidOutput.Add(A427SYS_UserDescription);
         isValidOutput.Add(A428RocheAccount);
         isValidOutput.Add(StringUtil.RTrim( Gx_mode));
         isValidOutput.Add(Z359UserID.ToString());
         isValidOutput.Add(Z416DisplayName);
         isValidOutput.Add(StringUtil.LTrim( StringUtil.NToC( (decimal)(Z417UserType), 9, 0, ".", "")));
         isValidOutput.Add(Z364Account);
         isValidOutput.Add(Z418PasswordHash);
         isValidOutput.Add(Z419LoginIP);
         isValidOutput.Add(context.localUtil.TToC( Z420LoginTime, 10, 8, 0, 0, "/", ":", " "));
         isValidOutput.Add(Z421SYS_UserCreator);
         isValidOutput.Add(context.localUtil.TToC( Z422SYS_UserCreateTime, 10, 8, 0, 0, "/", ":", " "));
         isValidOutput.Add(Z423SYS_UserModifier);
         isValidOutput.Add(context.localUtil.TToC( Z424SYS_UserModifyTime, 10, 8, 0, 0, "/", ":", " "));
         isValidOutput.Add(StringUtil.LTrim( StringUtil.NToC( (decimal)(Z425SYS_UserIsDeleted), 1, 0, ".", "")));
         isValidOutput.Add(Z426Email);
         isValidOutput.Add(Z427SYS_UserDescription);
         isValidOutput.Add(Z428RocheAccount);
         isValidOutput.Add(bttBtn_delete_Enabled);
         isValidOutput.Add(bttBtn_enter_Enabled);
         isValidOutput.Add(context.GX_msglist.ToJavascriptSource());
         isValidOutput.Add(context.httpAjaxContext.ajax_rsp_get_hiddens( ));
         context.GX_webresponse.AddString(isValidOutput.ToJSonString());
         wbTemp = context.ResponseContentType( "application/json");
      }

      public void Valid_Account( String GX_Parm1 ,
                                 Guid GX_Parm2 )
      {
         A364Account = GX_Parm1;
         A359UserID = (Guid)(GX_Parm2);
         /* Using cursor T001D16 */
         pr_datastore1.execute(14, new Object[] {A364Account, A359UserID});
         if ( (pr_datastore1.getStatus(14) != 101) )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_1004", new   object[]  {"Account"}), 1, "ACCOUNT");
            AnyError = 1;
            GX_FocusControl = edtAccount_Internalname;
         }
         pr_datastore1.close(14);
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
         Z359UserID = (Guid)(Guid.Empty);
         Z416DisplayName = "";
         Z364Account = "";
         Z418PasswordHash = "";
         Z419LoginIP = "";
         Z420LoginTime = (DateTime)(DateTime.MinValue);
         Z421SYS_UserCreator = "";
         Z422SYS_UserCreateTime = (DateTime)(DateTime.MinValue);
         Z423SYS_UserModifier = "";
         Z424SYS_UserModifyTime = (DateTime)(DateTime.MinValue);
         Z426Email = "";
         Z428RocheAccount = "";
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
         A359UserID = (Guid)(Guid.Empty);
         A416DisplayName = "";
         A364Account = "";
         A418PasswordHash = "";
         A419LoginIP = "";
         A420LoginTime = (DateTime)(DateTime.MinValue);
         A421SYS_UserCreator = "";
         A422SYS_UserCreateTime = (DateTime)(DateTime.MinValue);
         A423SYS_UserModifier = "";
         A424SYS_UserModifyTime = (DateTime)(DateTime.MinValue);
         A426Email = "";
         A427SYS_UserDescription = "";
         A428RocheAccount = "";
         bttBtn_enter_Jsonclick = "";
         bttBtn_cancel_Jsonclick = "";
         bttBtn_delete_Jsonclick = "";
         Gx_mode = "";
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         Z427SYS_UserDescription = "";
         T001D4_A359UserID = new Guid[] {Guid.Empty} ;
         T001D4_A416DisplayName = new String[] {""} ;
         T001D4_A417UserType = new int[1] ;
         T001D4_A364Account = new String[] {""} ;
         T001D4_A418PasswordHash = new String[] {""} ;
         T001D4_A419LoginIP = new String[] {""} ;
         T001D4_n419LoginIP = new bool[] {false} ;
         T001D4_A420LoginTime = new DateTime[] {DateTime.MinValue} ;
         T001D4_n420LoginTime = new bool[] {false} ;
         T001D4_A421SYS_UserCreator = new String[] {""} ;
         T001D4_A422SYS_UserCreateTime = new DateTime[] {DateTime.MinValue} ;
         T001D4_A423SYS_UserModifier = new String[] {""} ;
         T001D4_n423SYS_UserModifier = new bool[] {false} ;
         T001D4_A424SYS_UserModifyTime = new DateTime[] {DateTime.MinValue} ;
         T001D4_n424SYS_UserModifyTime = new bool[] {false} ;
         T001D4_A425SYS_UserIsDeleted = new short[1] ;
         T001D4_A426Email = new String[] {""} ;
         T001D4_n426Email = new bool[] {false} ;
         T001D4_A427SYS_UserDescription = new String[] {""} ;
         T001D4_n427SYS_UserDescription = new bool[] {false} ;
         T001D4_A428RocheAccount = new String[] {""} ;
         T001D4_n428RocheAccount = new bool[] {false} ;
         T001D5_A364Account = new String[] {""} ;
         T001D6_A359UserID = new Guid[] {Guid.Empty} ;
         T001D3_A359UserID = new Guid[] {Guid.Empty} ;
         T001D3_A416DisplayName = new String[] {""} ;
         T001D3_A417UserType = new int[1] ;
         T001D3_A364Account = new String[] {""} ;
         T001D3_A418PasswordHash = new String[] {""} ;
         T001D3_A419LoginIP = new String[] {""} ;
         T001D3_n419LoginIP = new bool[] {false} ;
         T001D3_A420LoginTime = new DateTime[] {DateTime.MinValue} ;
         T001D3_n420LoginTime = new bool[] {false} ;
         T001D3_A421SYS_UserCreator = new String[] {""} ;
         T001D3_A422SYS_UserCreateTime = new DateTime[] {DateTime.MinValue} ;
         T001D3_A423SYS_UserModifier = new String[] {""} ;
         T001D3_n423SYS_UserModifier = new bool[] {false} ;
         T001D3_A424SYS_UserModifyTime = new DateTime[] {DateTime.MinValue} ;
         T001D3_n424SYS_UserModifyTime = new bool[] {false} ;
         T001D3_A425SYS_UserIsDeleted = new short[1] ;
         T001D3_A426Email = new String[] {""} ;
         T001D3_n426Email = new bool[] {false} ;
         T001D3_A427SYS_UserDescription = new String[] {""} ;
         T001D3_n427SYS_UserDescription = new bool[] {false} ;
         T001D3_A428RocheAccount = new String[] {""} ;
         T001D3_n428RocheAccount = new bool[] {false} ;
         sMode50 = "";
         T001D7_A359UserID = new Guid[] {Guid.Empty} ;
         T001D8_A359UserID = new Guid[] {Guid.Empty} ;
         T001D2_A359UserID = new Guid[] {Guid.Empty} ;
         T001D2_A416DisplayName = new String[] {""} ;
         T001D2_A417UserType = new int[1] ;
         T001D2_A364Account = new String[] {""} ;
         T001D2_A418PasswordHash = new String[] {""} ;
         T001D2_A419LoginIP = new String[] {""} ;
         T001D2_n419LoginIP = new bool[] {false} ;
         T001D2_A420LoginTime = new DateTime[] {DateTime.MinValue} ;
         T001D2_n420LoginTime = new bool[] {false} ;
         T001D2_A421SYS_UserCreator = new String[] {""} ;
         T001D2_A422SYS_UserCreateTime = new DateTime[] {DateTime.MinValue} ;
         T001D2_A423SYS_UserModifier = new String[] {""} ;
         T001D2_n423SYS_UserModifier = new bool[] {false} ;
         T001D2_A424SYS_UserModifyTime = new DateTime[] {DateTime.MinValue} ;
         T001D2_n424SYS_UserModifyTime = new bool[] {false} ;
         T001D2_A425SYS_UserIsDeleted = new short[1] ;
         T001D2_A426Email = new String[] {""} ;
         T001D2_n426Email = new bool[] {false} ;
         T001D2_A427SYS_UserDescription = new String[] {""} ;
         T001D2_n427SYS_UserDescription = new bool[] {false} ;
         T001D2_A428RocheAccount = new String[] {""} ;
         T001D2_n428RocheAccount = new bool[] {false} ;
         T001D12_A358InstituteCode = new String[] {""} ;
         T001D12_A359UserID = new Guid[] {Guid.Empty} ;
         T001D13_A360BAS_TenantTenantCode = new String[] {""} ;
         T001D13_A359UserID = new Guid[] {Guid.Empty} ;
         T001D14_A359UserID = new Guid[] {Guid.Empty} ;
         T001D14_A361RoleID = new Guid[] {Guid.Empty} ;
         T001D15_A359UserID = new Guid[] {Guid.Empty} ;
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         isValidOutput = new GxUnknownObjectCollection();
         T001D16_A364Account = new String[] {""} ;
         pr_datastore1 = new DataStoreProvider(context, new GeneXus.Programs.sys_user__datastore1(),
            new Object[][] {
                new Object[] {
               T001D2_A359UserID, T001D2_A416DisplayName, T001D2_A417UserType, T001D2_A364Account, T001D2_A418PasswordHash, T001D2_A419LoginIP, T001D2_n419LoginIP, T001D2_A420LoginTime, T001D2_n420LoginTime, T001D2_A421SYS_UserCreator,
               T001D2_A422SYS_UserCreateTime, T001D2_A423SYS_UserModifier, T001D2_n423SYS_UserModifier, T001D2_A424SYS_UserModifyTime, T001D2_n424SYS_UserModifyTime, T001D2_A425SYS_UserIsDeleted, T001D2_A426Email, T001D2_n426Email, T001D2_A427SYS_UserDescription, T001D2_n427SYS_UserDescription,
               T001D2_A428RocheAccount, T001D2_n428RocheAccount
               }
               , new Object[] {
               T001D3_A359UserID, T001D3_A416DisplayName, T001D3_A417UserType, T001D3_A364Account, T001D3_A418PasswordHash, T001D3_A419LoginIP, T001D3_n419LoginIP, T001D3_A420LoginTime, T001D3_n420LoginTime, T001D3_A421SYS_UserCreator,
               T001D3_A422SYS_UserCreateTime, T001D3_A423SYS_UserModifier, T001D3_n423SYS_UserModifier, T001D3_A424SYS_UserModifyTime, T001D3_n424SYS_UserModifyTime, T001D3_A425SYS_UserIsDeleted, T001D3_A426Email, T001D3_n426Email, T001D3_A427SYS_UserDescription, T001D3_n427SYS_UserDescription,
               T001D3_A428RocheAccount, T001D3_n428RocheAccount
               }
               , new Object[] {
               T001D4_A359UserID, T001D4_A416DisplayName, T001D4_A417UserType, T001D4_A364Account, T001D4_A418PasswordHash, T001D4_A419LoginIP, T001D4_n419LoginIP, T001D4_A420LoginTime, T001D4_n420LoginTime, T001D4_A421SYS_UserCreator,
               T001D4_A422SYS_UserCreateTime, T001D4_A423SYS_UserModifier, T001D4_n423SYS_UserModifier, T001D4_A424SYS_UserModifyTime, T001D4_n424SYS_UserModifyTime, T001D4_A425SYS_UserIsDeleted, T001D4_A426Email, T001D4_n426Email, T001D4_A427SYS_UserDescription, T001D4_n427SYS_UserDescription,
               T001D4_A428RocheAccount, T001D4_n428RocheAccount
               }
               , new Object[] {
               T001D5_A364Account
               }
               , new Object[] {
               T001D6_A359UserID
               }
               , new Object[] {
               T001D7_A359UserID
               }
               , new Object[] {
               T001D8_A359UserID
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               T001D12_A358InstituteCode, T001D12_A359UserID
               }
               , new Object[] {
               T001D13_A360BAS_TenantTenantCode, T001D13_A359UserID
               }
               , new Object[] {
               T001D14_A359UserID, T001D14_A361RoleID
               }
               , new Object[] {
               T001D15_A359UserID
               }
               , new Object[] {
               T001D16_A364Account
               }
            }
         );
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.sys_user__default(),
            new Object[][] {
            }
         );
         Z359UserID = (Guid)(Guid.NewGuid( ));
         A359UserID = (Guid)(Guid.NewGuid( ));
      }

      private short Z425SYS_UserIsDeleted ;
      private short GxWebError ;
      private short gxcookieaux ;
      private short IsConfirmed ;
      private short IsModified ;
      private short AnyError ;
      private short nKeyPressed ;
      private short initialized ;
      private short A425SYS_UserIsDeleted ;
      private short Gx_BScreen ;
      private short GX_JID ;
      private short RcdFound50 ;
      private short gxajaxcallmode ;
      private short wbTemp ;
      private int Z417UserType ;
      private int trnEnded ;
      private int bttBtn_first_Visible ;
      private int bttBtn_previous_Visible ;
      private int bttBtn_next_Visible ;
      private int bttBtn_last_Visible ;
      private int bttBtn_select_Visible ;
      private int edtUserID_Enabled ;
      private int edtDisplayName_Enabled ;
      private int A417UserType ;
      private int edtUserType_Enabled ;
      private int edtAccount_Enabled ;
      private int edtPasswordHash_Enabled ;
      private int edtLoginIP_Enabled ;
      private int edtLoginTime_Enabled ;
      private int edtSYS_UserCreator_Enabled ;
      private int edtSYS_UserCreateTime_Enabled ;
      private int edtSYS_UserModifier_Enabled ;
      private int edtSYS_UserModifyTime_Enabled ;
      private int edtSYS_UserIsDeleted_Enabled ;
      private int edtEmail_Enabled ;
      private int edtSYS_UserDescription_Enabled ;
      private int edtRocheAccount_Enabled ;
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
      private String edtDisplayName_Internalname ;
      private String edtDisplayName_Jsonclick ;
      private String edtUserType_Internalname ;
      private String edtUserType_Jsonclick ;
      private String edtAccount_Internalname ;
      private String edtAccount_Jsonclick ;
      private String edtPasswordHash_Internalname ;
      private String edtPasswordHash_Jsonclick ;
      private String edtLoginIP_Internalname ;
      private String edtLoginIP_Jsonclick ;
      private String edtLoginTime_Internalname ;
      private String edtLoginTime_Jsonclick ;
      private String edtSYS_UserCreator_Internalname ;
      private String edtSYS_UserCreator_Jsonclick ;
      private String edtSYS_UserCreateTime_Internalname ;
      private String edtSYS_UserCreateTime_Jsonclick ;
      private String edtSYS_UserModifier_Internalname ;
      private String edtSYS_UserModifier_Jsonclick ;
      private String edtSYS_UserModifyTime_Internalname ;
      private String edtSYS_UserModifyTime_Jsonclick ;
      private String edtSYS_UserIsDeleted_Internalname ;
      private String edtSYS_UserIsDeleted_Jsonclick ;
      private String edtEmail_Internalname ;
      private String edtEmail_Jsonclick ;
      private String edtSYS_UserDescription_Internalname ;
      private String edtRocheAccount_Internalname ;
      private String edtRocheAccount_Jsonclick ;
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
      private String sMode50 ;
      private String sDynURL ;
      private String FormProcess ;
      private String bodyStyle ;
      private DateTime Z420LoginTime ;
      private DateTime Z422SYS_UserCreateTime ;
      private DateTime Z424SYS_UserModifyTime ;
      private DateTime A420LoginTime ;
      private DateTime A422SYS_UserCreateTime ;
      private DateTime A424SYS_UserModifyTime ;
      private bool entryPointCalled ;
      private bool toggleJsOutput ;
      private bool wbErr ;
      private bool n419LoginIP ;
      private bool n420LoginTime ;
      private bool n423SYS_UserModifier ;
      private bool n424SYS_UserModifyTime ;
      private bool n426Email ;
      private bool n427SYS_UserDescription ;
      private bool n428RocheAccount ;
      private bool Gx_longc ;
      private String A427SYS_UserDescription ;
      private String Z427SYS_UserDescription ;
      private String Z416DisplayName ;
      private String Z364Account ;
      private String Z418PasswordHash ;
      private String Z419LoginIP ;
      private String Z421SYS_UserCreator ;
      private String Z423SYS_UserModifier ;
      private String Z426Email ;
      private String Z428RocheAccount ;
      private String A416DisplayName ;
      private String A364Account ;
      private String A418PasswordHash ;
      private String A419LoginIP ;
      private String A421SYS_UserCreator ;
      private String A423SYS_UserModifier ;
      private String A426Email ;
      private String A428RocheAccount ;
      private Guid Z359UserID ;
      private Guid A359UserID ;
      private GxUnknownObjectCollection isValidOutput ;
      private IGxDataStore dsDataStore1 ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_datastore1 ;
      private Guid[] T001D4_A359UserID ;
      private String[] T001D4_A416DisplayName ;
      private int[] T001D4_A417UserType ;
      private String[] T001D4_A364Account ;
      private String[] T001D4_A418PasswordHash ;
      private String[] T001D4_A419LoginIP ;
      private bool[] T001D4_n419LoginIP ;
      private DateTime[] T001D4_A420LoginTime ;
      private bool[] T001D4_n420LoginTime ;
      private String[] T001D4_A421SYS_UserCreator ;
      private DateTime[] T001D4_A422SYS_UserCreateTime ;
      private String[] T001D4_A423SYS_UserModifier ;
      private bool[] T001D4_n423SYS_UserModifier ;
      private DateTime[] T001D4_A424SYS_UserModifyTime ;
      private bool[] T001D4_n424SYS_UserModifyTime ;
      private short[] T001D4_A425SYS_UserIsDeleted ;
      private String[] T001D4_A426Email ;
      private bool[] T001D4_n426Email ;
      private String[] T001D4_A427SYS_UserDescription ;
      private bool[] T001D4_n427SYS_UserDescription ;
      private String[] T001D4_A428RocheAccount ;
      private bool[] T001D4_n428RocheAccount ;
      private String[] T001D5_A364Account ;
      private Guid[] T001D6_A359UserID ;
      private Guid[] T001D3_A359UserID ;
      private String[] T001D3_A416DisplayName ;
      private int[] T001D3_A417UserType ;
      private String[] T001D3_A364Account ;
      private String[] T001D3_A418PasswordHash ;
      private String[] T001D3_A419LoginIP ;
      private bool[] T001D3_n419LoginIP ;
      private DateTime[] T001D3_A420LoginTime ;
      private bool[] T001D3_n420LoginTime ;
      private String[] T001D3_A421SYS_UserCreator ;
      private DateTime[] T001D3_A422SYS_UserCreateTime ;
      private String[] T001D3_A423SYS_UserModifier ;
      private bool[] T001D3_n423SYS_UserModifier ;
      private DateTime[] T001D3_A424SYS_UserModifyTime ;
      private bool[] T001D3_n424SYS_UserModifyTime ;
      private short[] T001D3_A425SYS_UserIsDeleted ;
      private String[] T001D3_A426Email ;
      private bool[] T001D3_n426Email ;
      private String[] T001D3_A427SYS_UserDescription ;
      private bool[] T001D3_n427SYS_UserDescription ;
      private String[] T001D3_A428RocheAccount ;
      private bool[] T001D3_n428RocheAccount ;
      private Guid[] T001D7_A359UserID ;
      private Guid[] T001D8_A359UserID ;
      private Guid[] T001D2_A359UserID ;
      private String[] T001D2_A416DisplayName ;
      private int[] T001D2_A417UserType ;
      private String[] T001D2_A364Account ;
      private String[] T001D2_A418PasswordHash ;
      private String[] T001D2_A419LoginIP ;
      private bool[] T001D2_n419LoginIP ;
      private DateTime[] T001D2_A420LoginTime ;
      private bool[] T001D2_n420LoginTime ;
      private String[] T001D2_A421SYS_UserCreator ;
      private DateTime[] T001D2_A422SYS_UserCreateTime ;
      private String[] T001D2_A423SYS_UserModifier ;
      private bool[] T001D2_n423SYS_UserModifier ;
      private DateTime[] T001D2_A424SYS_UserModifyTime ;
      private bool[] T001D2_n424SYS_UserModifyTime ;
      private short[] T001D2_A425SYS_UserIsDeleted ;
      private String[] T001D2_A426Email ;
      private bool[] T001D2_n426Email ;
      private String[] T001D2_A427SYS_UserDescription ;
      private bool[] T001D2_n427SYS_UserDescription ;
      private String[] T001D2_A428RocheAccount ;
      private bool[] T001D2_n428RocheAccount ;
      private String[] T001D12_A358InstituteCode ;
      private Guid[] T001D12_A359UserID ;
      private String[] T001D13_A360BAS_TenantTenantCode ;
      private Guid[] T001D13_A359UserID ;
      private Guid[] T001D14_A359UserID ;
      private Guid[] T001D14_A361RoleID ;
      private IDataStoreProvider pr_default ;
      private Guid[] T001D15_A359UserID ;
      private String[] T001D16_A364Account ;
      private GXWebForm Form ;
   }

   public class sys_user__datastore1 : DataStoreHelperBase, IDataStoreHelper
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
         ,new ForEachCursor(def[13])
         ,new ForEachCursor(def[14])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmT001D4 ;
          prmT001D4 = new Object[] {
          new Object[] {"@UserID",SqlDbType.UniqueIdentifier,16,0}
          } ;
          Object[] prmT001D5 ;
          prmT001D5 = new Object[] {
          new Object[] {"@Account",SqlDbType.NVarChar,50,0} ,
          new Object[] {"@UserID",SqlDbType.UniqueIdentifier,16,0}
          } ;
          Object[] prmT001D6 ;
          prmT001D6 = new Object[] {
          new Object[] {"@UserID",SqlDbType.UniqueIdentifier,16,0}
          } ;
          Object[] prmT001D3 ;
          prmT001D3 = new Object[] {
          new Object[] {"@UserID",SqlDbType.UniqueIdentifier,16,0}
          } ;
          Object[] prmT001D7 ;
          prmT001D7 = new Object[] {
          new Object[] {"@UserID",SqlDbType.UniqueIdentifier,16,0}
          } ;
          Object[] prmT001D8 ;
          prmT001D8 = new Object[] {
          new Object[] {"@UserID",SqlDbType.UniqueIdentifier,16,0}
          } ;
          Object[] prmT001D2 ;
          prmT001D2 = new Object[] {
          new Object[] {"@UserID",SqlDbType.UniqueIdentifier,16,0}
          } ;
          Object[] prmT001D9 ;
          prmT001D9 = new Object[] {
          new Object[] {"@DisplayName",SqlDbType.NVarChar,50,0} ,
          new Object[] {"@UserType",SqlDbType.Int,9,0} ,
          new Object[] {"@Account",SqlDbType.NVarChar,50,0} ,
          new Object[] {"@PasswordHash",SqlDbType.NVarChar,50,0} ,
          new Object[] {"@LoginIP",SqlDbType.NVarChar,20,0} ,
          new Object[] {"@LoginTime",SqlDbType.DateTime,10,8} ,
          new Object[] {"@SYS_UserCreator",SqlDbType.NVarChar,50,0} ,
          new Object[] {"@SYS_UserCreateTime",SqlDbType.DateTime,10,8} ,
          new Object[] {"@SYS_UserModifier",SqlDbType.NVarChar,50,0} ,
          new Object[] {"@SYS_UserModifyTime",SqlDbType.DateTime,10,8} ,
          new Object[] {"@SYS_UserIsDeleted",SqlDbType.SmallInt,1,0} ,
          new Object[] {"@Email",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@SYS_UserDescription",SqlDbType.NVarChar,2048,0} ,
          new Object[] {"@RocheAccount",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@UserID",SqlDbType.UniqueIdentifier,16,0}
          } ;
          Object[] prmT001D10 ;
          prmT001D10 = new Object[] {
          new Object[] {"@DisplayName",SqlDbType.NVarChar,50,0} ,
          new Object[] {"@UserType",SqlDbType.Int,9,0} ,
          new Object[] {"@Account",SqlDbType.NVarChar,50,0} ,
          new Object[] {"@PasswordHash",SqlDbType.NVarChar,50,0} ,
          new Object[] {"@LoginIP",SqlDbType.NVarChar,20,0} ,
          new Object[] {"@LoginTime",SqlDbType.DateTime,10,8} ,
          new Object[] {"@SYS_UserCreator",SqlDbType.NVarChar,50,0} ,
          new Object[] {"@SYS_UserCreateTime",SqlDbType.DateTime,10,8} ,
          new Object[] {"@SYS_UserModifier",SqlDbType.NVarChar,50,0} ,
          new Object[] {"@SYS_UserModifyTime",SqlDbType.DateTime,10,8} ,
          new Object[] {"@SYS_UserIsDeleted",SqlDbType.SmallInt,1,0} ,
          new Object[] {"@Email",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@SYS_UserDescription",SqlDbType.NVarChar,2048,0} ,
          new Object[] {"@RocheAccount",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@UserID",SqlDbType.UniqueIdentifier,16,0}
          } ;
          Object[] prmT001D11 ;
          prmT001D11 = new Object[] {
          new Object[] {"@UserID",SqlDbType.UniqueIdentifier,16,0}
          } ;
          Object[] prmT001D12 ;
          prmT001D12 = new Object[] {
          new Object[] {"@UserID",SqlDbType.UniqueIdentifier,16,0}
          } ;
          Object[] prmT001D13 ;
          prmT001D13 = new Object[] {
          new Object[] {"@UserID",SqlDbType.UniqueIdentifier,16,0}
          } ;
          Object[] prmT001D14 ;
          prmT001D14 = new Object[] {
          new Object[] {"@UserID",SqlDbType.UniqueIdentifier,16,0}
          } ;
          Object[] prmT001D15 ;
          prmT001D15 = new Object[] {
          } ;
          Object[] prmT001D16 ;
          prmT001D16 = new Object[] {
          new Object[] {"@Account",SqlDbType.NVarChar,50,0} ,
          new Object[] {"@UserID",SqlDbType.UniqueIdentifier,16,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("T001D2", "SELECT [UserID], [DisplayName], [UserType], [Account], [PasswordHash], [LoginIP], [LoginTime], [Creator], [CreateTime], [Modifier], [ModifyTime], [IsDeleted], [Email], [Description], [RocheAccount] FROM dbo.[SYS_User] WITH (UPDLOCK) WHERE [UserID] = @UserID ",true, GxErrorMask.GX_NOMASK, false, this,prmT001D2,1,0,true,false )
             ,new CursorDef("T001D3", "SELECT [UserID], [DisplayName], [UserType], [Account], [PasswordHash], [LoginIP], [LoginTime], [Creator], [CreateTime], [Modifier], [ModifyTime], [IsDeleted], [Email], [Description], [RocheAccount] FROM dbo.[SYS_User] WITH (NOLOCK) WHERE [UserID] = @UserID ",true, GxErrorMask.GX_NOMASK, false, this,prmT001D3,1,0,true,false )
             ,new CursorDef("T001D4", "SELECT TM1.[UserID], TM1.[DisplayName], TM1.[UserType], TM1.[Account], TM1.[PasswordHash], TM1.[LoginIP], TM1.[LoginTime], TM1.[Creator], TM1.[CreateTime], TM1.[Modifier], TM1.[ModifyTime], TM1.[IsDeleted], TM1.[Email], TM1.[Description], TM1.[RocheAccount] FROM dbo.[SYS_User] TM1 WITH (NOLOCK) WHERE TM1.[UserID] = @UserID ORDER BY TM1.[UserID]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT001D4,100,0,true,false )
             ,new CursorDef("T001D5", "SELECT [Account] FROM dbo.[SYS_User] WITH (NOLOCK) WHERE ([Account] = @Account) AND (Not ( [UserID] = @UserID)) ",true, GxErrorMask.GX_NOMASK, false, this,prmT001D5,1,0,true,false )
             ,new CursorDef("T001D6", "SELECT [UserID] FROM dbo.[SYS_User] WITH (NOLOCK) WHERE [UserID] = @UserID  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT001D6,1,0,true,false )
             ,new CursorDef("T001D7", "SELECT TOP 1 [UserID] FROM dbo.[SYS_User] WITH (NOLOCK) WHERE ( [UserID] > @UserID) ORDER BY [UserID]  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT001D7,1,0,true,true )
             ,new CursorDef("T001D8", "SELECT TOP 1 [UserID] FROM dbo.[SYS_User] WITH (NOLOCK) WHERE ( [UserID] < @UserID) ORDER BY [UserID] DESC  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT001D8,1,0,true,true )
             ,new CursorDef("T001D9", "INSERT INTO dbo.[SYS_User]([DisplayName], [UserType], [Account], [PasswordHash], [LoginIP], [LoginTime], [Creator], [CreateTime], [Modifier], [ModifyTime], [IsDeleted], [Email], [Description], [RocheAccount], [UserID]) VALUES(@DisplayName, @UserType, @Account, @PasswordHash, @LoginIP, @LoginTime, @SYS_UserCreator, @SYS_UserCreateTime, @SYS_UserModifier, @SYS_UserModifyTime, @SYS_UserIsDeleted, @Email, @SYS_UserDescription, @RocheAccount, @UserID)", GxErrorMask.GX_NOMASK,prmT001D9)
             ,new CursorDef("T001D10", "UPDATE dbo.[SYS_User] SET [DisplayName]=@DisplayName, [UserType]=@UserType, [Account]=@Account, [PasswordHash]=@PasswordHash, [LoginIP]=@LoginIP, [LoginTime]=@LoginTime, [Creator]=@SYS_UserCreator, [CreateTime]=@SYS_UserCreateTime, [Modifier]=@SYS_UserModifier, [ModifyTime]=@SYS_UserModifyTime, [IsDeleted]=@SYS_UserIsDeleted, [Email]=@Email, [Description]=@SYS_UserDescription, [RocheAccount]=@RocheAccount  WHERE [UserID] = @UserID", GxErrorMask.GX_NOMASK,prmT001D10)
             ,new CursorDef("T001D11", "DELETE FROM dbo.[SYS_User]  WHERE [UserID] = @UserID", GxErrorMask.GX_NOMASK,prmT001D11)
             ,new CursorDef("T001D12", "SELECT TOP 1 [InstituteCode], [UserID] FROM dbo.[SYS_InstituteUser] WITH (NOLOCK) WHERE [UserID] = @UserID ",true, GxErrorMask.GX_NOMASK, false, this,prmT001D12,1,0,true,true )
             ,new CursorDef("T001D13", "SELECT TOP 1 [TenantCode], [UserID] FROM dbo.[SYS_TenantUser] WITH (NOLOCK) WHERE [UserID] = @UserID ",true, GxErrorMask.GX_NOMASK, false, this,prmT001D13,1,0,true,true )
             ,new CursorDef("T001D14", "SELECT TOP 1 [UserID], [RoleID] FROM dbo.[SYS_UserRole] WITH (NOLOCK) WHERE [UserID] = @UserID ",true, GxErrorMask.GX_NOMASK, false, this,prmT001D14,1,0,true,true )
             ,new CursorDef("T001D15", "SELECT [UserID] FROM dbo.[SYS_User] WITH (NOLOCK) ORDER BY [UserID]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT001D15,100,0,true,false )
             ,new CursorDef("T001D16", "SELECT [Account] FROM dbo.[SYS_User] WITH (NOLOCK) WHERE ([Account] = @Account) AND (Not ( [UserID] = @UserID)) ",true, GxErrorMask.GX_NOMASK, false, this,prmT001D16,1,0,true,false )
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
                ((int[]) buf[2])[0] = rslt.getInt(3) ;
                ((String[]) buf[3])[0] = rslt.getVarchar(4) ;
                ((String[]) buf[4])[0] = rslt.getVarchar(5) ;
                ((String[]) buf[5])[0] = rslt.getVarchar(6) ;
                ((bool[]) buf[6])[0] = rslt.wasNull(6);
                ((DateTime[]) buf[7])[0] = rslt.getGXDateTime(7) ;
                ((bool[]) buf[8])[0] = rslt.wasNull(7);
                ((String[]) buf[9])[0] = rslt.getVarchar(8) ;
                ((DateTime[]) buf[10])[0] = rslt.getGXDateTime(9) ;
                ((String[]) buf[11])[0] = rslt.getVarchar(10) ;
                ((bool[]) buf[12])[0] = rslt.wasNull(10);
                ((DateTime[]) buf[13])[0] = rslt.getGXDateTime(11) ;
                ((bool[]) buf[14])[0] = rslt.wasNull(11);
                ((short[]) buf[15])[0] = rslt.getShort(12) ;
                ((String[]) buf[16])[0] = rslt.getVarchar(13) ;
                ((bool[]) buf[17])[0] = rslt.wasNull(13);
                ((String[]) buf[18])[0] = rslt.getLongVarchar(14) ;
                ((bool[]) buf[19])[0] = rslt.wasNull(14);
                ((String[]) buf[20])[0] = rslt.getVarchar(15) ;
                ((bool[]) buf[21])[0] = rslt.wasNull(15);
                return;
             case 1 :
                ((Guid[]) buf[0])[0] = rslt.getGuid(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((int[]) buf[2])[0] = rslt.getInt(3) ;
                ((String[]) buf[3])[0] = rslt.getVarchar(4) ;
                ((String[]) buf[4])[0] = rslt.getVarchar(5) ;
                ((String[]) buf[5])[0] = rslt.getVarchar(6) ;
                ((bool[]) buf[6])[0] = rslt.wasNull(6);
                ((DateTime[]) buf[7])[0] = rslt.getGXDateTime(7) ;
                ((bool[]) buf[8])[0] = rslt.wasNull(7);
                ((String[]) buf[9])[0] = rslt.getVarchar(8) ;
                ((DateTime[]) buf[10])[0] = rslt.getGXDateTime(9) ;
                ((String[]) buf[11])[0] = rslt.getVarchar(10) ;
                ((bool[]) buf[12])[0] = rslt.wasNull(10);
                ((DateTime[]) buf[13])[0] = rslt.getGXDateTime(11) ;
                ((bool[]) buf[14])[0] = rslt.wasNull(11);
                ((short[]) buf[15])[0] = rslt.getShort(12) ;
                ((String[]) buf[16])[0] = rslt.getVarchar(13) ;
                ((bool[]) buf[17])[0] = rslt.wasNull(13);
                ((String[]) buf[18])[0] = rslt.getLongVarchar(14) ;
                ((bool[]) buf[19])[0] = rslt.wasNull(14);
                ((String[]) buf[20])[0] = rslt.getVarchar(15) ;
                ((bool[]) buf[21])[0] = rslt.wasNull(15);
                return;
             case 2 :
                ((Guid[]) buf[0])[0] = rslt.getGuid(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((int[]) buf[2])[0] = rslt.getInt(3) ;
                ((String[]) buf[3])[0] = rslt.getVarchar(4) ;
                ((String[]) buf[4])[0] = rslt.getVarchar(5) ;
                ((String[]) buf[5])[0] = rslt.getVarchar(6) ;
                ((bool[]) buf[6])[0] = rslt.wasNull(6);
                ((DateTime[]) buf[7])[0] = rslt.getGXDateTime(7) ;
                ((bool[]) buf[8])[0] = rslt.wasNull(7);
                ((String[]) buf[9])[0] = rslt.getVarchar(8) ;
                ((DateTime[]) buf[10])[0] = rslt.getGXDateTime(9) ;
                ((String[]) buf[11])[0] = rslt.getVarchar(10) ;
                ((bool[]) buf[12])[0] = rslt.wasNull(10);
                ((DateTime[]) buf[13])[0] = rslt.getGXDateTime(11) ;
                ((bool[]) buf[14])[0] = rslt.wasNull(11);
                ((short[]) buf[15])[0] = rslt.getShort(12) ;
                ((String[]) buf[16])[0] = rslt.getVarchar(13) ;
                ((bool[]) buf[17])[0] = rslt.wasNull(13);
                ((String[]) buf[18])[0] = rslt.getLongVarchar(14) ;
                ((bool[]) buf[19])[0] = rslt.wasNull(14);
                ((String[]) buf[20])[0] = rslt.getVarchar(15) ;
                ((bool[]) buf[21])[0] = rslt.wasNull(15);
                return;
             case 3 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
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
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((Guid[]) buf[1])[0] = rslt.getGuid(2) ;
                return;
             case 11 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
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
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
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
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (Guid)parms[1]);
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
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (int)parms[1]);
                stmt.SetParameter(3, (String)parms[2]);
                stmt.SetParameter(4, (String)parms[3]);
                if ( (bool)parms[4] )
                {
                   stmt.setNull( 5 , SqlDbType.NVarChar );
                }
                else
                {
                   stmt.SetParameter(5, (String)parms[5]);
                }
                if ( (bool)parms[6] )
                {
                   stmt.setNull( 6 , SqlDbType.DateTime );
                }
                else
                {
                   stmt.SetParameterDatetime(6, (DateTime)parms[7]);
                }
                stmt.SetParameter(7, (String)parms[8]);
                stmt.SetParameterDatetime(8, (DateTime)parms[9]);
                if ( (bool)parms[10] )
                {
                   stmt.setNull( 9 , SqlDbType.NVarChar );
                }
                else
                {
                   stmt.SetParameter(9, (String)parms[11]);
                }
                if ( (bool)parms[12] )
                {
                   stmt.setNull( 10 , SqlDbType.DateTime );
                }
                else
                {
                   stmt.SetParameterDatetime(10, (DateTime)parms[13]);
                }
                stmt.SetParameter(11, (short)parms[14]);
                if ( (bool)parms[15] )
                {
                   stmt.setNull( 12 , SqlDbType.NVarChar );
                }
                else
                {
                   stmt.SetParameter(12, (String)parms[16]);
                }
                if ( (bool)parms[17] )
                {
                   stmt.setNull( 13 , SqlDbType.NVarChar );
                }
                else
                {
                   stmt.SetParameter(13, (String)parms[18]);
                }
                if ( (bool)parms[19] )
                {
                   stmt.setNull( 14 , SqlDbType.NVarChar );
                }
                else
                {
                   stmt.SetParameter(14, (String)parms[20]);
                }
                stmt.SetParameter(15, (Guid)parms[21]);
                return;
             case 8 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (int)parms[1]);
                stmt.SetParameter(3, (String)parms[2]);
                stmt.SetParameter(4, (String)parms[3]);
                if ( (bool)parms[4] )
                {
                   stmt.setNull( 5 , SqlDbType.NVarChar );
                }
                else
                {
                   stmt.SetParameter(5, (String)parms[5]);
                }
                if ( (bool)parms[6] )
                {
                   stmt.setNull( 6 , SqlDbType.DateTime );
                }
                else
                {
                   stmt.SetParameterDatetime(6, (DateTime)parms[7]);
                }
                stmt.SetParameter(7, (String)parms[8]);
                stmt.SetParameterDatetime(8, (DateTime)parms[9]);
                if ( (bool)parms[10] )
                {
                   stmt.setNull( 9 , SqlDbType.NVarChar );
                }
                else
                {
                   stmt.SetParameter(9, (String)parms[11]);
                }
                if ( (bool)parms[12] )
                {
                   stmt.setNull( 10 , SqlDbType.DateTime );
                }
                else
                {
                   stmt.SetParameterDatetime(10, (DateTime)parms[13]);
                }
                stmt.SetParameter(11, (short)parms[14]);
                if ( (bool)parms[15] )
                {
                   stmt.setNull( 12 , SqlDbType.NVarChar );
                }
                else
                {
                   stmt.SetParameter(12, (String)parms[16]);
                }
                if ( (bool)parms[17] )
                {
                   stmt.setNull( 13 , SqlDbType.NVarChar );
                }
                else
                {
                   stmt.SetParameter(13, (String)parms[18]);
                }
                if ( (bool)parms[19] )
                {
                   stmt.setNull( 14 , SqlDbType.NVarChar );
                }
                else
                {
                   stmt.SetParameter(14, (String)parms[20]);
                }
                stmt.SetParameter(15, (Guid)parms[21]);
                return;
             case 9 :
                stmt.SetParameter(1, (Guid)parms[0]);
                return;
             case 10 :
                stmt.SetParameter(1, (Guid)parms[0]);
                return;
             case 11 :
                stmt.SetParameter(1, (Guid)parms[0]);
                return;
             case 12 :
                stmt.SetParameter(1, (Guid)parms[0]);
                return;
             case 14 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (Guid)parms[1]);
                return;
       }
    }

    public String getDataStoreName( )
    {
       return "DATASTORE1";
    }

 }

 public class sys_user__default : DataStoreHelperBase, IDataStoreHelper
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
