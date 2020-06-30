/*
               File: JC_ProviderSecUser
        Description: 医院账号关系表
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/27/2020 11:57:0.71
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
   public class jc_providersecuser : GXDataArea, System.Web.SessionState.IRequiresSessionState
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
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxExecAct_"+"gxLoad_2") == 0 )
         {
            A6SecUserId = (short)(NumberUtil.Val( GetNextPar( ), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A6SecUserId", StringUtil.LTrim( StringUtil.Str( (decimal)(A6SecUserId), 4, 0)));
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            gxLoad_2( A6SecUserId) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxExecAct_"+"gxLoad_3") == 0 )
         {
            A87JC_ProviderID = (long)(NumberUtil.Val( GetNextPar( ), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A87JC_ProviderID", StringUtil.LTrim( StringUtil.Str( (decimal)(A87JC_ProviderID), 18, 0)));
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            gxLoad_3( A87JC_ProviderID) ;
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
            Form.Meta.addItem("description", "医院账号关系表", 0) ;
         }
         context.wjLoc = "";
         context.nUserReturn = 0;
         context.wbHandled = 0;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         GX_FocusControl = edtSecUserId_Internalname;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         wbErr = false;
         context.SetDefaultTheme("WorkWithPlusTheme");
         if ( ! context.IsLocalStorageSupported( ) )
         {
            context.PushCurrentUrl();
         }
      }

      public jc_providersecuser( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public jc_providersecuser( IGxContext context )
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
            GxWebStd.gx_label_ctrl( context, lblTitle_Internalname, "医院账号关系表", "", "", lblTitle_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Title", 0, "", 1, 1, 0, "HLP_JC_ProviderSecUser.htm");
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
            GxWebStd.gx_button_ctrl( context, bttBtn_first_Internalname, "", "|<", bttBtn_first_Jsonclick, 5, "|<", "", StyleString, ClassString, bttBtn_first_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"EFIRST."+"'", TempTags, "", context.GetButtonType( ), "HLP_JC_ProviderSecUser.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 14,'',false,'',0)\"";
            ClassString = "BtnPrevious";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_previous_Internalname, "", "<", bttBtn_previous_Jsonclick, 5, "<", "", StyleString, ClassString, bttBtn_previous_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"EPREVIOUS."+"'", TempTags, "", context.GetButtonType( ), "HLP_JC_ProviderSecUser.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 16,'',false,'',0)\"";
            ClassString = "BtnNext";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_next_Internalname, "", ">", bttBtn_next_Jsonclick, 5, ">", "", StyleString, ClassString, bttBtn_next_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ENEXT."+"'", TempTags, "", context.GetButtonType( ), "HLP_JC_ProviderSecUser.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 18,'',false,'',0)\"";
            ClassString = "BtnLast";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_last_Internalname, "", ">|", bttBtn_last_Jsonclick, 5, ">|", "", StyleString, ClassString, bttBtn_last_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ELAST."+"'", TempTags, "", context.GetButtonType( ), "HLP_JC_ProviderSecUser.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 20,'',false,'',0)\"";
            ClassString = "BtnSelect";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_select_Internalname, "", "选择", bttBtn_select_Jsonclick, 5, "选择", "", StyleString, ClassString, bttBtn_select_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ESELECT."+"'", TempTags, "", 2, "HLP_JC_ProviderSecUser.htm");
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
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtSecUserId_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtSecUserId_Internalname, "账号主键", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 28,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtSecUserId_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A6SecUserId), 4, 0, ".", "")), ((edtSecUserId_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A6SecUserId), "ZZZ9")) : context.localUtil.Format( (decimal)(A6SecUserId), "ZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,28);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtSecUserId_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtSecUserId_Enabled, 0, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_JC_ProviderSecUser.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtJC_ProviderID_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtJC_ProviderID_Internalname, "就诊医院", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 33,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtJC_ProviderID_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A87JC_ProviderID), 18, 0, ".", "")), ((edtJC_ProviderID_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A87JC_ProviderID), "ZZZZZZZZZZZZZZZZZZ")) : context.localUtil.Format( (decimal)(A87JC_ProviderID), "ZZZZZZZZZZZZZZZZZZ")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,33);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtJC_ProviderID_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtJC_ProviderID_Enabled, 0, "number", "1", 18, "chr", 1, "row", 18, 0, 0, 0, 1, -1, 0, true, "ID", "right", false, "HLP_JC_ProviderSecUser.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtSecUserName_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtSecUserName_Internalname, "姓名", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtSecUserName_Internalname, A14SecUserName, StringUtil.RTrim( context.localUtil.Format( A14SecUserName, "")), "", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtSecUserName_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtSecUserName_Enabled, 0, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_JC_ProviderSecUser.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtJC_ProviderName_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtJC_ProviderName_Internalname, "医院名称", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtJC_ProviderName_Internalname, A89JC_ProviderName, StringUtil.RTrim( context.localUtil.Format( A89JC_ProviderName, "")), "", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtJC_ProviderName_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtJC_ProviderName_Enabled, 0, "text", "", 80, "chr", 1, "row", 200, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_JC_ProviderSecUser.htm");
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
            GxWebStd.gx_button_ctrl( context, bttBtn_enter_Internalname, "", "确认", bttBtn_enter_Jsonclick, 5, "确认", "", StyleString, ClassString, bttBtn_enter_Visible, bttBtn_enter_Enabled, "standard", "'"+""+"'"+",false,"+"'"+"EENTER."+"'", TempTags, "", context.GetButtonType( ), "HLP_JC_ProviderSecUser.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 50,'',false,'',0)\"";
            ClassString = "BtnCancel";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_cancel_Internalname, "", "取消", bttBtn_cancel_Jsonclick, 1, "取消", "", StyleString, ClassString, bttBtn_cancel_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ECANCEL."+"'", TempTags, "", context.GetButtonType( ), "HLP_JC_ProviderSecUser.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 52,'',false,'',0)\"";
            ClassString = "BtnDelete";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_delete_Internalname, "", "删除", bttBtn_delete_Jsonclick, 5, "删除", "", StyleString, ClassString, bttBtn_delete_Visible, bttBtn_delete_Enabled, "standard", "'"+""+"'"+",false,"+"'"+"EDELETE."+"'", TempTags, "", context.GetButtonType( ), "HLP_JC_ProviderSecUser.htm");
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
               if ( ( ( context.localUtil.CToN( cgiGet( edtSecUserId_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtSecUserId_Internalname), ".", ",") > Convert.ToDecimal( 9999 )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "SECUSERID");
                  AnyError = 1;
                  GX_FocusControl = edtSecUserId_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A6SecUserId = 0;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A6SecUserId", StringUtil.LTrim( StringUtil.Str( (decimal)(A6SecUserId), 4, 0)));
               }
               else
               {
                  A6SecUserId = (short)(context.localUtil.CToN( cgiGet( edtSecUserId_Internalname), ".", ","));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A6SecUserId", StringUtil.LTrim( StringUtil.Str( (decimal)(A6SecUserId), 4, 0)));
               }
               if ( ( ( context.localUtil.CToN( cgiGet( edtJC_ProviderID_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtJC_ProviderID_Internalname), ".", ",") > Convert.ToDecimal( 999999999999999999L )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "JC_PROVIDERID");
                  AnyError = 1;
                  GX_FocusControl = edtJC_ProviderID_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A87JC_ProviderID = 0;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A87JC_ProviderID", StringUtil.LTrim( StringUtil.Str( (decimal)(A87JC_ProviderID), 18, 0)));
               }
               else
               {
                  A87JC_ProviderID = (long)(context.localUtil.CToN( cgiGet( edtJC_ProviderID_Internalname), ".", ","));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A87JC_ProviderID", StringUtil.LTrim( StringUtil.Str( (decimal)(A87JC_ProviderID), 18, 0)));
               }
               A14SecUserName = cgiGet( edtSecUserName_Internalname);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A14SecUserName", A14SecUserName);
               A89JC_ProviderName = cgiGet( edtJC_ProviderName_Internalname);
               n89JC_ProviderName = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A89JC_ProviderName", A89JC_ProviderName);
               /* Read saved values. */
               Z6SecUserId = (short)(context.localUtil.CToN( cgiGet( "Z6SecUserId"), ".", ","));
               Z87JC_ProviderID = (long)(context.localUtil.CToN( cgiGet( "Z87JC_ProviderID"), ".", ","));
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
                  A6SecUserId = (short)(NumberUtil.Val( GetNextPar( ), "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A6SecUserId", StringUtil.LTrim( StringUtil.Str( (decimal)(A6SecUserId), 4, 0)));
                  A87JC_ProviderID = (long)(NumberUtil.Val( GetNextPar( ), "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A87JC_ProviderID", StringUtil.LTrim( StringUtil.Str( (decimal)(A87JC_ProviderID), 18, 0)));
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
               InitAll0P26( ) ;
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
         DisableAttributes0P26( ) ;
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

      protected void ResetCaption0P0( )
      {
      }

      protected void ZM0P26( short GX_JID )
      {
         if ( ( GX_JID == 1 ) || ( GX_JID == 0 ) )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
            {
            }
            else
            {
            }
         }
         if ( GX_JID == -1 )
         {
            Z6SecUserId = A6SecUserId;
            Z87JC_ProviderID = A87JC_ProviderID;
            Z14SecUserName = A14SecUserName;
            Z89JC_ProviderName = A89JC_ProviderName;
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

      protected void Load0P26( )
      {
         /* Using cursor T000P6 */
         pr_default.execute(4, new Object[] {A6SecUserId, A87JC_ProviderID});
         if ( (pr_default.getStatus(4) != 101) )
         {
            RcdFound26 = 1;
            A14SecUserName = T000P6_A14SecUserName[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A14SecUserName", A14SecUserName);
            A89JC_ProviderName = T000P6_A89JC_ProviderName[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A89JC_ProviderName", A89JC_ProviderName);
            n89JC_ProviderName = T000P6_n89JC_ProviderName[0];
            ZM0P26( -1) ;
         }
         pr_default.close(4);
         OnLoadActions0P26( ) ;
      }

      protected void OnLoadActions0P26( )
      {
      }

      protected void CheckExtendedTable0P26( )
      {
         Gx_BScreen = 1;
         standaloneModal( ) ;
         /* Using cursor T000P4 */
         pr_default.execute(2, new Object[] {A6SecUserId});
         if ( (pr_default.getStatus(2) == 101) )
         {
            GX_msglist.addItem("不匹配'User'", "ForeignKeyNotFound", 1, "SECUSERID");
            AnyError = 1;
            GX_FocusControl = edtSecUserId_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         A14SecUserName = T000P4_A14SecUserName[0];
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A14SecUserName", A14SecUserName);
         pr_default.close(2);
         /* Using cursor T000P5 */
         pr_default.execute(3, new Object[] {A87JC_ProviderID});
         if ( (pr_default.getStatus(3) == 101) )
         {
            GX_msglist.addItem("不匹配' T21'", "ForeignKeyNotFound", 1, "JC_PROVIDERID");
            AnyError = 1;
            GX_FocusControl = edtJC_ProviderID_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         A89JC_ProviderName = T000P5_A89JC_ProviderName[0];
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A89JC_ProviderName", A89JC_ProviderName);
         n89JC_ProviderName = T000P5_n89JC_ProviderName[0];
         pr_default.close(3);
      }

      protected void CloseExtendedTableCursors0P26( )
      {
         pr_default.close(2);
         pr_default.close(3);
      }

      protected void enableDisable( )
      {
      }

      protected void gxLoad_2( short A6SecUserId )
      {
         /* Using cursor T000P7 */
         pr_default.execute(5, new Object[] {A6SecUserId});
         if ( (pr_default.getStatus(5) == 101) )
         {
            GX_msglist.addItem("不匹配'User'", "ForeignKeyNotFound", 1, "SECUSERID");
            AnyError = 1;
            GX_FocusControl = edtSecUserId_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         A14SecUserName = T000P7_A14SecUserName[0];
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A14SecUserName", A14SecUserName);
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("[[");
         context.GX_webresponse.AddString("\""+GXUtil.EncodeJSConstant( A14SecUserName)+"\"");
         context.GX_webresponse.AddString("]");
         if ( (pr_default.getStatus(5) == 101) )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString("]");
         pr_default.close(5);
      }

      protected void gxLoad_3( long A87JC_ProviderID )
      {
         /* Using cursor T000P8 */
         pr_default.execute(6, new Object[] {A87JC_ProviderID});
         if ( (pr_default.getStatus(6) == 101) )
         {
            GX_msglist.addItem("不匹配' T21'", "ForeignKeyNotFound", 1, "JC_PROVIDERID");
            AnyError = 1;
            GX_FocusControl = edtJC_ProviderID_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         A89JC_ProviderName = T000P8_A89JC_ProviderName[0];
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A89JC_ProviderName", A89JC_ProviderName);
         n89JC_ProviderName = T000P8_n89JC_ProviderName[0];
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("[[");
         context.GX_webresponse.AddString("\""+GXUtil.EncodeJSConstant( A89JC_ProviderName)+"\"");
         context.GX_webresponse.AddString("]");
         if ( (pr_default.getStatus(6) == 101) )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString("]");
         pr_default.close(6);
      }

      protected void GetKey0P26( )
      {
         /* Using cursor T000P9 */
         pr_default.execute(7, new Object[] {A6SecUserId, A87JC_ProviderID});
         if ( (pr_default.getStatus(7) != 101) )
         {
            RcdFound26 = 1;
         }
         else
         {
            RcdFound26 = 0;
         }
         pr_default.close(7);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor T000P3 */
         pr_default.execute(1, new Object[] {A6SecUserId, A87JC_ProviderID});
         if ( (pr_default.getStatus(1) != 101) )
         {
            ZM0P26( 1) ;
            RcdFound26 = 1;
            A6SecUserId = T000P3_A6SecUserId[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A6SecUserId", StringUtil.LTrim( StringUtil.Str( (decimal)(A6SecUserId), 4, 0)));
            A87JC_ProviderID = T000P3_A87JC_ProviderID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A87JC_ProviderID", StringUtil.LTrim( StringUtil.Str( (decimal)(A87JC_ProviderID), 18, 0)));
            Z6SecUserId = A6SecUserId;
            Z87JC_ProviderID = A87JC_ProviderID;
            sMode26 = Gx_mode;
            Gx_mode = "DSP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            standaloneModal( ) ;
            Load0P26( ) ;
            if ( AnyError == 1 )
            {
               RcdFound26 = 0;
               InitializeNonKey0P26( ) ;
            }
            Gx_mode = sMode26;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         else
         {
            RcdFound26 = 0;
            InitializeNonKey0P26( ) ;
            sMode26 = Gx_mode;
            Gx_mode = "DSP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            standaloneModal( ) ;
            Gx_mode = sMode26;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         pr_default.close(1);
      }

      protected void getEqualNoModal( )
      {
         GetKey0P26( ) ;
         if ( RcdFound26 == 0 )
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
         RcdFound26 = 0;
         /* Using cursor T000P10 */
         pr_default.execute(8, new Object[] {A6SecUserId, A87JC_ProviderID});
         if ( (pr_default.getStatus(8) != 101) )
         {
            while ( (pr_default.getStatus(8) != 101) && ( ( T000P10_A6SecUserId[0] < A6SecUserId ) || ( T000P10_A6SecUserId[0] == A6SecUserId ) && ( T000P10_A87JC_ProviderID[0] < A87JC_ProviderID ) ) )
            {
               pr_default.readNext(8);
            }
            if ( (pr_default.getStatus(8) != 101) && ( ( T000P10_A6SecUserId[0] > A6SecUserId ) || ( T000P10_A6SecUserId[0] == A6SecUserId ) && ( T000P10_A87JC_ProviderID[0] > A87JC_ProviderID ) ) )
            {
               A6SecUserId = T000P10_A6SecUserId[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A6SecUserId", StringUtil.LTrim( StringUtil.Str( (decimal)(A6SecUserId), 4, 0)));
               A87JC_ProviderID = T000P10_A87JC_ProviderID[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A87JC_ProviderID", StringUtil.LTrim( StringUtil.Str( (decimal)(A87JC_ProviderID), 18, 0)));
               RcdFound26 = 1;
            }
         }
         pr_default.close(8);
      }

      protected void move_previous( )
      {
         RcdFound26 = 0;
         /* Using cursor T000P11 */
         pr_default.execute(9, new Object[] {A6SecUserId, A87JC_ProviderID});
         if ( (pr_default.getStatus(9) != 101) )
         {
            while ( (pr_default.getStatus(9) != 101) && ( ( T000P11_A6SecUserId[0] > A6SecUserId ) || ( T000P11_A6SecUserId[0] == A6SecUserId ) && ( T000P11_A87JC_ProviderID[0] > A87JC_ProviderID ) ) )
            {
               pr_default.readNext(9);
            }
            if ( (pr_default.getStatus(9) != 101) && ( ( T000P11_A6SecUserId[0] < A6SecUserId ) || ( T000P11_A6SecUserId[0] == A6SecUserId ) && ( T000P11_A87JC_ProviderID[0] < A87JC_ProviderID ) ) )
            {
               A6SecUserId = T000P11_A6SecUserId[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A6SecUserId", StringUtil.LTrim( StringUtil.Str( (decimal)(A6SecUserId), 4, 0)));
               A87JC_ProviderID = T000P11_A87JC_ProviderID[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A87JC_ProviderID", StringUtil.LTrim( StringUtil.Str( (decimal)(A87JC_ProviderID), 18, 0)));
               RcdFound26 = 1;
            }
         }
         pr_default.close(9);
      }

      protected void btn_enter( )
      {
         nKeyPressed = 1;
         GetKey0P26( ) ;
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            /* Insert record */
            GX_FocusControl = edtSecUserId_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            Insert0P26( ) ;
            if ( AnyError == 1 )
            {
               GX_FocusControl = "";
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
         }
         else
         {
            if ( RcdFound26 == 1 )
            {
               if ( ( A6SecUserId != Z6SecUserId ) || ( A87JC_ProviderID != Z87JC_ProviderID ) )
               {
                  A6SecUserId = Z6SecUserId;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A6SecUserId", StringUtil.LTrim( StringUtil.Str( (decimal)(A6SecUserId), 4, 0)));
                  A87JC_ProviderID = Z87JC_ProviderID;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A87JC_ProviderID", StringUtil.LTrim( StringUtil.Str( (decimal)(A87JC_ProviderID), 18, 0)));
                  GX_msglist.addItem(context.GetMessage( "GXM_getbeforeupd", ""), "CandidateKeyNotFound", 1, "SECUSERID");
                  AnyError = 1;
                  GX_FocusControl = edtSecUserId_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
               else if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
               {
                  delete( ) ;
                  AfterTrn( ) ;
                  GX_FocusControl = edtSecUserId_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
               else
               {
                  Gx_mode = "UPD";
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                  /* Update record */
                  Update0P26( ) ;
                  GX_FocusControl = edtSecUserId_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
            }
            else
            {
               if ( ( A6SecUserId != Z6SecUserId ) || ( A87JC_ProviderID != Z87JC_ProviderID ) )
               {
                  Gx_mode = "INS";
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                  /* Insert record */
                  GX_FocusControl = edtSecUserId_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  Insert0P26( ) ;
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
                     GX_msglist.addItem(context.GetMessage( "GXM_recdeleted", ""), 1, "SECUSERID");
                     AnyError = 1;
                     GX_FocusControl = edtSecUserId_Internalname;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  }
                  else
                  {
                     Gx_mode = "INS";
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                     /* Insert record */
                     GX_FocusControl = edtSecUserId_Internalname;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                     Insert0P26( ) ;
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
         if ( ( A6SecUserId != Z6SecUserId ) || ( A87JC_ProviderID != Z87JC_ProviderID ) )
         {
            A6SecUserId = Z6SecUserId;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A6SecUserId", StringUtil.LTrim( StringUtil.Str( (decimal)(A6SecUserId), 4, 0)));
            A87JC_ProviderID = Z87JC_ProviderID;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A87JC_ProviderID", StringUtil.LTrim( StringUtil.Str( (decimal)(A87JC_ProviderID), 18, 0)));
            GX_msglist.addItem(context.GetMessage( "GXM_getbeforedlt", ""), 1, "SECUSERID");
            AnyError = 1;
            GX_FocusControl = edtSecUserId_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         else
         {
            delete( ) ;
            AfterTrn( ) ;
            GX_FocusControl = edtSecUserId_Internalname;
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
         if ( RcdFound26 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_keynfound", ""), "PrimaryKeyNotFound", 1, "SECUSERID");
            AnyError = 1;
            GX_FocusControl = edtSecUserId_Internalname;
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
         ScanStart0P26( ) ;
         if ( RcdFound26 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "", true);
         }
         else
         {
            Gx_mode = "UPD";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         ScanEnd0P26( ) ;
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
         if ( RcdFound26 == 0 )
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
         if ( RcdFound26 == 0 )
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
         ScanStart0P26( ) ;
         if ( RcdFound26 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "", true);
         }
         else
         {
            while ( RcdFound26 != 0 )
            {
               ScanNext0P26( ) ;
            }
            Gx_mode = "UPD";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         ScanEnd0P26( ) ;
         getByPrimaryKey( ) ;
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_select( )
      {
         getEqualNoModal( ) ;
      }

      protected void CheckOptimisticConcurrency0P26( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor T000P2 */
            pr_default.execute(0, new Object[] {A6SecUserId, A87JC_ProviderID});
            if ( (pr_default.getStatus(0) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"JC_ProviderSecUser"}), "RecordIsLocked", 1, "");
               AnyError = 1;
               return  ;
            }
            if ( (pr_default.getStatus(0) == 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"JC_ProviderSecUser"}), "RecordWasChanged", 1, "");
               AnyError = 1;
               return  ;
            }
         }
      }

      protected void Insert0P26( )
      {
         BeforeValidate0P26( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0P26( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM0P26( 0) ;
            CheckOptimisticConcurrency0P26( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0P26( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert0P26( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000P12 */
                     pr_default.execute(10, new Object[] {A6SecUserId, A87JC_ProviderID});
                     pr_default.close(10);
                     dsDefault.SmartCacheProvider.SetUpdated("JC_ProviderSecUser") ;
                     if ( (pr_default.getStatus(10) == 1) )
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
                           ResetCaption0P0( ) ;
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
               Load0P26( ) ;
            }
            EndLevel0P26( ) ;
         }
         CloseExtendedTableCursors0P26( ) ;
      }

      protected void Update0P26( )
      {
         BeforeValidate0P26( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0P26( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0P26( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0P26( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate0P26( ) ;
                  if ( AnyError == 0 )
                  {
                     /* No attributes to update on table [JC_ProviderSecUser] */
                     DeferredUpdate0P26( ) ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( update) rules */
                        /* End of After( update) rules */
                        if ( AnyError == 0 )
                        {
                           getByPrimaryKey( ) ;
                           GX_msglist.addItem(context.GetMessage( "GXM_sucupdated", ""), "SuccessfullyUpdated", 0, "", true);
                           ResetCaption0P0( ) ;
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
            EndLevel0P26( ) ;
         }
         CloseExtendedTableCursors0P26( ) ;
      }

      protected void DeferredUpdate0P26( )
      {
      }

      protected void delete( )
      {
         Gx_mode = "DLT";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         BeforeValidate0P26( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0P26( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls0P26( ) ;
            AfterConfirm0P26( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete0P26( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor T000P13 */
                  pr_default.execute(11, new Object[] {A6SecUserId, A87JC_ProviderID});
                  pr_default.close(11);
                  dsDefault.SmartCacheProvider.SetUpdated("JC_ProviderSecUser") ;
                  if ( AnyError == 0 )
                  {
                     /* Start of After( delete) rules */
                     /* End of After( delete) rules */
                     if ( AnyError == 0 )
                     {
                        move_next( ) ;
                        if ( RcdFound26 == 0 )
                        {
                           InitAll0P26( ) ;
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
                        ResetCaption0P0( ) ;
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
         sMode26 = Gx_mode;
         Gx_mode = "DLT";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         EndLevel0P26( ) ;
         Gx_mode = sMode26;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
      }

      protected void OnDeleteControls0P26( )
      {
         standaloneModal( ) ;
         if ( AnyError == 0 )
         {
            /* Delete mode formulas */
            /* Using cursor T000P14 */
            pr_default.execute(12, new Object[] {A6SecUserId});
            A14SecUserName = T000P14_A14SecUserName[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A14SecUserName", A14SecUserName);
            pr_default.close(12);
            /* Using cursor T000P15 */
            pr_default.execute(13, new Object[] {A87JC_ProviderID});
            A89JC_ProviderName = T000P15_A89JC_ProviderName[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A89JC_ProviderName", A89JC_ProviderName);
            n89JC_ProviderName = T000P15_n89JC_ProviderName[0];
            pr_default.close(13);
         }
      }

      protected void EndLevel0P26( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            pr_default.close(0);
         }
         if ( AnyError == 0 )
         {
            BeforeComplete0P26( ) ;
         }
         if ( AnyError == 0 )
         {
            pr_default.close(1);
            pr_default.close(12);
            pr_default.close(13);
            context.CommitDataStores("jc_providersecuser",pr_default);
            if ( AnyError == 0 )
            {
               ConfirmValues0P0( ) ;
            }
            /* After transaction rules */
            /* Execute 'After Trn' event if defined. */
            trnEnded = 1;
         }
         else
         {
            pr_default.close(1);
            pr_default.close(12);
            pr_default.close(13);
            context.RollbackDataStores("jc_providersecuser",pr_default);
         }
         IsModified = 0;
         if ( AnyError != 0 )
         {
            context.wjLoc = "";
            context.nUserReturn = 0;
         }
      }

      public void ScanStart0P26( )
      {
         /* Using cursor T000P16 */
         pr_default.execute(14);
         RcdFound26 = 0;
         if ( (pr_default.getStatus(14) != 101) )
         {
            RcdFound26 = 1;
            A6SecUserId = T000P16_A6SecUserId[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A6SecUserId", StringUtil.LTrim( StringUtil.Str( (decimal)(A6SecUserId), 4, 0)));
            A87JC_ProviderID = T000P16_A87JC_ProviderID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A87JC_ProviderID", StringUtil.LTrim( StringUtil.Str( (decimal)(A87JC_ProviderID), 18, 0)));
         }
         /* Load Subordinate Levels */
      }

      protected void ScanNext0P26( )
      {
         /* Scan next routine */
         pr_default.readNext(14);
         RcdFound26 = 0;
         if ( (pr_default.getStatus(14) != 101) )
         {
            RcdFound26 = 1;
            A6SecUserId = T000P16_A6SecUserId[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A6SecUserId", StringUtil.LTrim( StringUtil.Str( (decimal)(A6SecUserId), 4, 0)));
            A87JC_ProviderID = T000P16_A87JC_ProviderID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A87JC_ProviderID", StringUtil.LTrim( StringUtil.Str( (decimal)(A87JC_ProviderID), 18, 0)));
         }
      }

      protected void ScanEnd0P26( )
      {
         pr_default.close(14);
      }

      protected void AfterConfirm0P26( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert0P26( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate0P26( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete0P26( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete0P26( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate0P26( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes0P26( )
      {
         edtSecUserId_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtSecUserId_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtSecUserId_Enabled), 5, 0)), true);
         edtJC_ProviderID_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtJC_ProviderID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtJC_ProviderID_Enabled), 5, 0)), true);
         edtSecUserName_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtSecUserName_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtSecUserName_Enabled), 5, 0)), true);
         edtJC_ProviderName_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtJC_ProviderName_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtJC_ProviderName_Enabled), 5, 0)), true);
      }

      protected void send_integrity_lvl_hashes0P26( )
      {
      }

      protected void assign_properties_default( )
      {
      }

      protected void ConfirmValues0P0( )
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
         context.AddJavascriptSource("gxcfg.js", "?20202271157216", false);
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" autocomplete=\"off\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("jc_providersecuser.aspx") +"\">") ;
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
         GxWebStd.gx_hidden_field( context, "Z6SecUserId", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z6SecUserId), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "Z87JC_ProviderID", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z87JC_ProviderID), 18, 0, ".", "")));
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
         return formatLink("jc_providersecuser.aspx")  ;
      }

      public override String GetPgmname( )
      {
         return "JC_ProviderSecUser" ;
      }

      public override String GetPgmdesc( )
      {
         return "医院账号关系表" ;
      }

      protected void InitializeNonKey0P26( )
      {
         A14SecUserName = "";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A14SecUserName", A14SecUserName);
         A89JC_ProviderName = "";
         n89JC_ProviderName = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A89JC_ProviderName", A89JC_ProviderName);
      }

      protected void InitAll0P26( )
      {
         A6SecUserId = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A6SecUserId", StringUtil.LTrim( StringUtil.Str( (decimal)(A6SecUserId), 4, 0)));
         A87JC_ProviderID = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A87JC_ProviderID", StringUtil.LTrim( StringUtil.Str( (decimal)(A87JC_ProviderID), 18, 0)));
         InitializeNonKey0P26( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?20202271157223", true);
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
         context.AddJavascriptSource("jc_providersecuser.js", "?20202271157224", false);
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
         edtSecUserId_Internalname = "SECUSERID";
         edtJC_ProviderID_Internalname = "JC_PROVIDERID";
         edtSecUserName_Internalname = "SECUSERNAME";
         edtJC_ProviderName_Internalname = "JC_PROVIDERNAME";
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
         Form.Caption = "医院账号关系表";
         bttBtn_delete_Enabled = 1;
         bttBtn_delete_Visible = 1;
         bttBtn_cancel_Visible = 1;
         bttBtn_enter_Enabled = 1;
         bttBtn_enter_Visible = 1;
         edtJC_ProviderName_Jsonclick = "";
         edtJC_ProviderName_Enabled = 0;
         edtSecUserName_Jsonclick = "";
         edtSecUserName_Enabled = 0;
         edtJC_ProviderID_Jsonclick = "";
         edtJC_ProviderID_Enabled = 1;
         edtSecUserId_Jsonclick = "";
         edtSecUserId_Enabled = 1;
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
         /* Using cursor T000P14 */
         pr_default.execute(12, new Object[] {A6SecUserId});
         if ( (pr_default.getStatus(12) == 101) )
         {
            GX_msglist.addItem("不匹配'User'", "ForeignKeyNotFound", 1, "SECUSERID");
            AnyError = 1;
            GX_FocusControl = edtSecUserId_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         A14SecUserName = T000P14_A14SecUserName[0];
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A14SecUserName", A14SecUserName);
         pr_default.close(12);
         /* Using cursor T000P15 */
         pr_default.execute(13, new Object[] {A87JC_ProviderID});
         if ( (pr_default.getStatus(13) == 101) )
         {
            GX_msglist.addItem("不匹配' T21'", "ForeignKeyNotFound", 1, "JC_PROVIDERID");
            AnyError = 1;
            GX_FocusControl = edtJC_ProviderID_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         A89JC_ProviderName = T000P15_A89JC_ProviderName[0];
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A89JC_ProviderName", A89JC_ProviderName);
         n89JC_ProviderName = T000P15_n89JC_ProviderName[0];
         pr_default.close(13);
         if ( AnyError == 0 )
         {
            GX_FocusControl = "";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         standaloneNotModal( ) ;
         standaloneModal( ) ;
         /* End function AfterKeyLoadScreen */
      }

      public void Valid_Secuserid( short GX_Parm1 ,
                                   String GX_Parm2 )
      {
         A6SecUserId = GX_Parm1;
         A14SecUserName = GX_Parm2;
         /* Using cursor T000P14 */
         pr_default.execute(12, new Object[] {A6SecUserId});
         if ( (pr_default.getStatus(12) == 101) )
         {
            GX_msglist.addItem("不匹配'User'", "ForeignKeyNotFound", 1, "SECUSERID");
            AnyError = 1;
            GX_FocusControl = edtSecUserId_Internalname;
         }
         A14SecUserName = T000P14_A14SecUserName[0];
         pr_default.close(12);
         dynload_actions( ) ;
         if ( AnyError == 1 )
         {
            A14SecUserName = "";
         }
         isValidOutput.Add(A14SecUserName);
         isValidOutput.Add(context.GX_msglist.ToJavascriptSource());
         isValidOutput.Add(context.httpAjaxContext.ajax_rsp_get_hiddens( ));
         context.GX_webresponse.AddString(isValidOutput.ToJSonString());
         wbTemp = context.ResponseContentType( "application/json");
      }

      public void Valid_Jc_providerid( short GX_Parm1 ,
                                       long GX_Parm2 ,
                                       String GX_Parm3 )
      {
         A6SecUserId = GX_Parm1;
         A87JC_ProviderID = GX_Parm2;
         A89JC_ProviderName = GX_Parm3;
         n89JC_ProviderName = false;
         context.wbHandled = 1;
         AfterKeyLoadScreen( ) ;
         Draw( ) ;
         send_integrity_footer_hashes( ) ;
         /* Using cursor T000P15 */
         pr_default.execute(13, new Object[] {A87JC_ProviderID});
         if ( (pr_default.getStatus(13) == 101) )
         {
            GX_msglist.addItem("不匹配' T21'", "ForeignKeyNotFound", 1, "JC_PROVIDERID");
            AnyError = 1;
            GX_FocusControl = edtJC_ProviderID_Internalname;
         }
         A89JC_ProviderName = T000P15_A89JC_ProviderName[0];
         n89JC_ProviderName = T000P15_n89JC_ProviderName[0];
         pr_default.close(13);
         dynload_actions( ) ;
         if ( AnyError == 1 )
         {
            A14SecUserName = "";
            A89JC_ProviderName = "";
            n89JC_ProviderName = false;
         }
         isValidOutput.Add(A14SecUserName);
         isValidOutput.Add(A89JC_ProviderName);
         isValidOutput.Add(StringUtil.RTrim( Gx_mode));
         isValidOutput.Add(StringUtil.LTrim( StringUtil.NToC( (decimal)(Z6SecUserId), 4, 0, ".", "")));
         isValidOutput.Add(StringUtil.LTrim( StringUtil.NToC( (decimal)(Z87JC_ProviderID), 18, 0, ".", "")));
         isValidOutput.Add(Z14SecUserName);
         isValidOutput.Add(Z89JC_ProviderName);
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
         pr_default.close(1);
         pr_default.close(12);
         pr_default.close(13);
      }

      public override void initialize( )
      {
         sPrefix = "";
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
         A14SecUserName = "";
         A89JC_ProviderName = "";
         bttBtn_enter_Jsonclick = "";
         bttBtn_cancel_Jsonclick = "";
         bttBtn_delete_Jsonclick = "";
         Gx_mode = "";
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         Z14SecUserName = "";
         Z89JC_ProviderName = "";
         T000P6_A14SecUserName = new String[] {""} ;
         T000P6_A89JC_ProviderName = new String[] {""} ;
         T000P6_n89JC_ProviderName = new bool[] {false} ;
         T000P6_A6SecUserId = new short[1] ;
         T000P6_A87JC_ProviderID = new long[1] ;
         T000P4_A14SecUserName = new String[] {""} ;
         T000P5_A89JC_ProviderName = new String[] {""} ;
         T000P5_n89JC_ProviderName = new bool[] {false} ;
         T000P7_A14SecUserName = new String[] {""} ;
         T000P8_A89JC_ProviderName = new String[] {""} ;
         T000P8_n89JC_ProviderName = new bool[] {false} ;
         T000P9_A6SecUserId = new short[1] ;
         T000P9_A87JC_ProviderID = new long[1] ;
         T000P3_A6SecUserId = new short[1] ;
         T000P3_A87JC_ProviderID = new long[1] ;
         sMode26 = "";
         T000P10_A6SecUserId = new short[1] ;
         T000P10_A87JC_ProviderID = new long[1] ;
         T000P11_A6SecUserId = new short[1] ;
         T000P11_A87JC_ProviderID = new long[1] ;
         T000P2_A6SecUserId = new short[1] ;
         T000P2_A87JC_ProviderID = new long[1] ;
         T000P14_A14SecUserName = new String[] {""} ;
         T000P15_A89JC_ProviderName = new String[] {""} ;
         T000P15_n89JC_ProviderName = new bool[] {false} ;
         T000P16_A6SecUserId = new short[1] ;
         T000P16_A87JC_ProviderID = new long[1] ;
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         isValidOutput = new GxUnknownObjectCollection();
         pr_datastore1 = new DataStoreProvider(context, new GeneXus.Programs.jc_providersecuser__datastore1(),
            new Object[][] {
            }
         );
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.jc_providersecuser__default(),
            new Object[][] {
                new Object[] {
               T000P2_A6SecUserId, T000P2_A87JC_ProviderID
               }
               , new Object[] {
               T000P3_A6SecUserId, T000P3_A87JC_ProviderID
               }
               , new Object[] {
               T000P4_A14SecUserName
               }
               , new Object[] {
               T000P5_A89JC_ProviderName, T000P5_n89JC_ProviderName
               }
               , new Object[] {
               T000P6_A14SecUserName, T000P6_A89JC_ProviderName, T000P6_n89JC_ProviderName, T000P6_A6SecUserId, T000P6_A87JC_ProviderID
               }
               , new Object[] {
               T000P7_A14SecUserName
               }
               , new Object[] {
               T000P8_A89JC_ProviderName, T000P8_n89JC_ProviderName
               }
               , new Object[] {
               T000P9_A6SecUserId, T000P9_A87JC_ProviderID
               }
               , new Object[] {
               T000P10_A6SecUserId, T000P10_A87JC_ProviderID
               }
               , new Object[] {
               T000P11_A6SecUserId, T000P11_A87JC_ProviderID
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               T000P14_A14SecUserName
               }
               , new Object[] {
               T000P15_A89JC_ProviderName, T000P15_n89JC_ProviderName
               }
               , new Object[] {
               T000P16_A6SecUserId, T000P16_A87JC_ProviderID
               }
            }
         );
      }

      private short Z6SecUserId ;
      private short GxWebError ;
      private short A6SecUserId ;
      private short gxcookieaux ;
      private short IsConfirmed ;
      private short IsModified ;
      private short AnyError ;
      private short nKeyPressed ;
      private short initialized ;
      private short GX_JID ;
      private short RcdFound26 ;
      private short Gx_BScreen ;
      private short gxajaxcallmode ;
      private short wbTemp ;
      private int trnEnded ;
      private int bttBtn_first_Visible ;
      private int bttBtn_previous_Visible ;
      private int bttBtn_next_Visible ;
      private int bttBtn_last_Visible ;
      private int bttBtn_select_Visible ;
      private int edtSecUserId_Enabled ;
      private int edtJC_ProviderID_Enabled ;
      private int edtSecUserName_Enabled ;
      private int edtJC_ProviderName_Enabled ;
      private int bttBtn_enter_Visible ;
      private int bttBtn_enter_Enabled ;
      private int bttBtn_cancel_Visible ;
      private int bttBtn_delete_Visible ;
      private int bttBtn_delete_Enabled ;
      private int idxLst ;
      private long Z87JC_ProviderID ;
      private long A87JC_ProviderID ;
      private String sPrefix ;
      private String scmdbuf ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String GXKey ;
      private String PreviousTooltip ;
      private String PreviousCaption ;
      private String GX_FocusControl ;
      private String edtSecUserId_Internalname ;
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
      private String edtSecUserId_Jsonclick ;
      private String edtJC_ProviderID_Internalname ;
      private String edtJC_ProviderID_Jsonclick ;
      private String edtSecUserName_Internalname ;
      private String edtSecUserName_Jsonclick ;
      private String edtJC_ProviderName_Internalname ;
      private String edtJC_ProviderName_Jsonclick ;
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
      private String sMode26 ;
      private String sDynURL ;
      private String FormProcess ;
      private String bodyStyle ;
      private bool entryPointCalled ;
      private bool toggleJsOutput ;
      private bool wbErr ;
      private bool n89JC_ProviderName ;
      private String A14SecUserName ;
      private String A89JC_ProviderName ;
      private String Z14SecUserName ;
      private String Z89JC_ProviderName ;
      private GxUnknownObjectCollection isValidOutput ;
      private IGxDataStore dsDataStore1 ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private String[] T000P6_A14SecUserName ;
      private String[] T000P6_A89JC_ProviderName ;
      private bool[] T000P6_n89JC_ProviderName ;
      private short[] T000P6_A6SecUserId ;
      private long[] T000P6_A87JC_ProviderID ;
      private String[] T000P4_A14SecUserName ;
      private String[] T000P5_A89JC_ProviderName ;
      private bool[] T000P5_n89JC_ProviderName ;
      private String[] T000P7_A14SecUserName ;
      private String[] T000P8_A89JC_ProviderName ;
      private bool[] T000P8_n89JC_ProviderName ;
      private short[] T000P9_A6SecUserId ;
      private long[] T000P9_A87JC_ProviderID ;
      private short[] T000P3_A6SecUserId ;
      private long[] T000P3_A87JC_ProviderID ;
      private short[] T000P10_A6SecUserId ;
      private long[] T000P10_A87JC_ProviderID ;
      private short[] T000P11_A6SecUserId ;
      private long[] T000P11_A87JC_ProviderID ;
      private short[] T000P2_A6SecUserId ;
      private long[] T000P2_A87JC_ProviderID ;
      private String[] T000P14_A14SecUserName ;
      private String[] T000P15_A89JC_ProviderName ;
      private bool[] T000P15_n89JC_ProviderName ;
      private short[] T000P16_A6SecUserId ;
      private long[] T000P16_A87JC_ProviderID ;
      private IDataStoreProvider pr_datastore1 ;
      private GXWebForm Form ;
   }

   public class jc_providersecuser__datastore1 : DataStoreHelperBase, IDataStoreHelper
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

 public class jc_providersecuser__default : DataStoreHelperBase, IDataStoreHelper
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
        Object[] prmT000P6 ;
        prmT000P6 = new Object[] {
        new Object[] {"@SecUserId",SqlDbType.SmallInt,4,0} ,
        new Object[] {"@JC_ProviderID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000P4 ;
        prmT000P4 = new Object[] {
        new Object[] {"@SecUserId",SqlDbType.SmallInt,4,0}
        } ;
        Object[] prmT000P5 ;
        prmT000P5 = new Object[] {
        new Object[] {"@JC_ProviderID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000P7 ;
        prmT000P7 = new Object[] {
        new Object[] {"@SecUserId",SqlDbType.SmallInt,4,0}
        } ;
        Object[] prmT000P8 ;
        prmT000P8 = new Object[] {
        new Object[] {"@JC_ProviderID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000P9 ;
        prmT000P9 = new Object[] {
        new Object[] {"@SecUserId",SqlDbType.SmallInt,4,0} ,
        new Object[] {"@JC_ProviderID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000P3 ;
        prmT000P3 = new Object[] {
        new Object[] {"@SecUserId",SqlDbType.SmallInt,4,0} ,
        new Object[] {"@JC_ProviderID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000P10 ;
        prmT000P10 = new Object[] {
        new Object[] {"@SecUserId",SqlDbType.SmallInt,4,0} ,
        new Object[] {"@JC_ProviderID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000P11 ;
        prmT000P11 = new Object[] {
        new Object[] {"@SecUserId",SqlDbType.SmallInt,4,0} ,
        new Object[] {"@JC_ProviderID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000P2 ;
        prmT000P2 = new Object[] {
        new Object[] {"@SecUserId",SqlDbType.SmallInt,4,0} ,
        new Object[] {"@JC_ProviderID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000P12 ;
        prmT000P12 = new Object[] {
        new Object[] {"@SecUserId",SqlDbType.SmallInt,4,0} ,
        new Object[] {"@JC_ProviderID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000P13 ;
        prmT000P13 = new Object[] {
        new Object[] {"@SecUserId",SqlDbType.SmallInt,4,0} ,
        new Object[] {"@JC_ProviderID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000P16 ;
        prmT000P16 = new Object[] {
        } ;
        Object[] prmT000P14 ;
        prmT000P14 = new Object[] {
        new Object[] {"@SecUserId",SqlDbType.SmallInt,4,0}
        } ;
        Object[] prmT000P15 ;
        prmT000P15 = new Object[] {
        new Object[] {"@JC_ProviderID",SqlDbType.Decimal,18,0}
        } ;
        def= new CursorDef[] {
            new CursorDef("T000P2", "SELECT [SecUserId], [JC_ProviderID] FROM [JC_ProviderSecUser] WITH (UPDLOCK) WHERE [SecUserId] = @SecUserId AND [JC_ProviderID] = @JC_ProviderID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000P2,1,0,true,false )
           ,new CursorDef("T000P3", "SELECT [SecUserId], [JC_ProviderID] FROM [JC_ProviderSecUser] WITH (NOLOCK) WHERE [SecUserId] = @SecUserId AND [JC_ProviderID] = @JC_ProviderID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000P3,1,0,true,false )
           ,new CursorDef("T000P4", "SELECT [SecUserName] FROM [SecUser] WITH (NOLOCK) WHERE [SecUserId] = @SecUserId ",true, GxErrorMask.GX_NOMASK, false, this,prmT000P4,1,0,true,false )
           ,new CursorDef("T000P5", "SELECT [JC_ProviderName] FROM [JC_Provider] WITH (NOLOCK) WHERE [JC_ProviderID] = @JC_ProviderID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000P5,1,0,true,false )
           ,new CursorDef("T000P6", "SELECT T2.[SecUserName], T3.[JC_ProviderName], TM1.[SecUserId], TM1.[JC_ProviderID] FROM (([JC_ProviderSecUser] TM1 WITH (NOLOCK) INNER JOIN [SecUser] T2 WITH (NOLOCK) ON T2.[SecUserId] = TM1.[SecUserId]) INNER JOIN [JC_Provider] T3 WITH (NOLOCK) ON T3.[JC_ProviderID] = TM1.[JC_ProviderID]) WHERE TM1.[SecUserId] = @SecUserId and TM1.[JC_ProviderID] = @JC_ProviderID ORDER BY TM1.[SecUserId], TM1.[JC_ProviderID]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT000P6,100,0,true,false )
           ,new CursorDef("T000P7", "SELECT [SecUserName] FROM [SecUser] WITH (NOLOCK) WHERE [SecUserId] = @SecUserId ",true, GxErrorMask.GX_NOMASK, false, this,prmT000P7,1,0,true,false )
           ,new CursorDef("T000P8", "SELECT [JC_ProviderName] FROM [JC_Provider] WITH (NOLOCK) WHERE [JC_ProviderID] = @JC_ProviderID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000P8,1,0,true,false )
           ,new CursorDef("T000P9", "SELECT [SecUserId], [JC_ProviderID] FROM [JC_ProviderSecUser] WITH (NOLOCK) WHERE [SecUserId] = @SecUserId AND [JC_ProviderID] = @JC_ProviderID  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000P9,1,0,true,false )
           ,new CursorDef("T000P10", "SELECT TOP 1 [SecUserId], [JC_ProviderID] FROM [JC_ProviderSecUser] WITH (NOLOCK) WHERE ( [SecUserId] > @SecUserId or [SecUserId] = @SecUserId and [JC_ProviderID] > @JC_ProviderID) ORDER BY [SecUserId], [JC_ProviderID]  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000P10,1,0,true,true )
           ,new CursorDef("T000P11", "SELECT TOP 1 [SecUserId], [JC_ProviderID] FROM [JC_ProviderSecUser] WITH (NOLOCK) WHERE ( [SecUserId] < @SecUserId or [SecUserId] = @SecUserId and [JC_ProviderID] < @JC_ProviderID) ORDER BY [SecUserId] DESC, [JC_ProviderID] DESC  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000P11,1,0,true,true )
           ,new CursorDef("T000P12", "INSERT INTO [JC_ProviderSecUser]([SecUserId], [JC_ProviderID]) VALUES(@SecUserId, @JC_ProviderID)", GxErrorMask.GX_NOMASK,prmT000P12)
           ,new CursorDef("T000P13", "DELETE FROM [JC_ProviderSecUser]  WHERE [SecUserId] = @SecUserId AND [JC_ProviderID] = @JC_ProviderID", GxErrorMask.GX_NOMASK,prmT000P13)
           ,new CursorDef("T000P14", "SELECT [SecUserName] FROM [SecUser] WITH (NOLOCK) WHERE [SecUserId] = @SecUserId ",true, GxErrorMask.GX_NOMASK, false, this,prmT000P14,1,0,true,false )
           ,new CursorDef("T000P15", "SELECT [JC_ProviderName] FROM [JC_Provider] WITH (NOLOCK) WHERE [JC_ProviderID] = @JC_ProviderID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000P15,1,0,true,false )
           ,new CursorDef("T000P16", "SELECT [SecUserId], [JC_ProviderID] FROM [JC_ProviderSecUser] WITH (NOLOCK) ORDER BY [SecUserId], [JC_ProviderID]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT000P16,100,0,true,false )
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
              ((short[]) buf[0])[0] = rslt.getShort(1) ;
              ((long[]) buf[1])[0] = rslt.getLong(2) ;
              return;
           case 1 :
              ((short[]) buf[0])[0] = rslt.getShort(1) ;
              ((long[]) buf[1])[0] = rslt.getLong(2) ;
              return;
           case 2 :
              ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
              return;
           case 3 :
              ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
              ((bool[]) buf[1])[0] = rslt.wasNull(1);
              return;
           case 4 :
              ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
              ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
              ((bool[]) buf[2])[0] = rslt.wasNull(2);
              ((short[]) buf[3])[0] = rslt.getShort(3) ;
              ((long[]) buf[4])[0] = rslt.getLong(4) ;
              return;
           case 5 :
              ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
              return;
           case 6 :
              ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
              ((bool[]) buf[1])[0] = rslt.wasNull(1);
              return;
           case 7 :
              ((short[]) buf[0])[0] = rslt.getShort(1) ;
              ((long[]) buf[1])[0] = rslt.getLong(2) ;
              return;
           case 8 :
              ((short[]) buf[0])[0] = rslt.getShort(1) ;
              ((long[]) buf[1])[0] = rslt.getLong(2) ;
              return;
           case 9 :
              ((short[]) buf[0])[0] = rslt.getShort(1) ;
              ((long[]) buf[1])[0] = rslt.getLong(2) ;
              return;
           case 12 :
              ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
              return;
           case 13 :
              ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
              ((bool[]) buf[1])[0] = rslt.wasNull(1);
              return;
           case 14 :
              ((short[]) buf[0])[0] = rslt.getShort(1) ;
              ((long[]) buf[1])[0] = rslt.getLong(2) ;
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
              stmt.SetParameter(1, (short)parms[0]);
              stmt.SetParameter(2, (long)parms[1]);
              return;
           case 1 :
              stmt.SetParameter(1, (short)parms[0]);
              stmt.SetParameter(2, (long)parms[1]);
              return;
           case 2 :
              stmt.SetParameter(1, (short)parms[0]);
              return;
           case 3 :
              stmt.SetParameter(1, (long)parms[0]);
              return;
           case 4 :
              stmt.SetParameter(1, (short)parms[0]);
              stmt.SetParameter(2, (long)parms[1]);
              return;
           case 5 :
              stmt.SetParameter(1, (short)parms[0]);
              return;
           case 6 :
              stmt.SetParameter(1, (long)parms[0]);
              return;
           case 7 :
              stmt.SetParameter(1, (short)parms[0]);
              stmt.SetParameter(2, (long)parms[1]);
              return;
           case 8 :
              stmt.SetParameter(1, (short)parms[0]);
              stmt.SetParameter(2, (long)parms[1]);
              return;
           case 9 :
              stmt.SetParameter(1, (short)parms[0]);
              stmt.SetParameter(2, (long)parms[1]);
              return;
           case 10 :
              stmt.SetParameter(1, (short)parms[0]);
              stmt.SetParameter(2, (long)parms[1]);
              return;
           case 11 :
              stmt.SetParameter(1, (short)parms[0]);
              stmt.SetParameter(2, (long)parms[1]);
              return;
           case 12 :
              stmt.SetParameter(1, (short)parms[0]);
              return;
           case 13 :
              stmt.SetParameter(1, (long)parms[0]);
              return;
     }
  }

}

}
