/*
               File: SecUserRole
        Description: 用户角色关系表
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/27/2020 11:55:29.83
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
namespace GeneXus.Programs.wwpbaseobjects {
   public class secuserrole : GXDataArea, System.Web.SessionState.IRequiresSessionState
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
            A4SecRoleId = (short)(NumberUtil.Val( GetNextPar( ), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A4SecRoleId", StringUtil.LTrim( StringUtil.Str( (decimal)(A4SecRoleId), 4, 0)));
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            gxLoad_3( A4SecRoleId) ;
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
            Form.Meta.addItem("description", "用户角色关系表", 0) ;
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

      public secuserrole( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public secuserrole( IGxContext context )
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
            GxWebStd.gx_label_ctrl( context, lblTitle_Internalname, "用户角色关系表", "", "", lblTitle_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Title", 0, "", 1, 1, 0, "HLP_WWPBaseObjects\\SecUserRole.htm");
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
            GxWebStd.gx_button_ctrl( context, bttBtn_first_Internalname, "", "|<", bttBtn_first_Jsonclick, 5, "|<", "", StyleString, ClassString, bttBtn_first_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"EFIRST."+"'", TempTags, "", context.GetButtonType( ), "HLP_WWPBaseObjects\\SecUserRole.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 14,'',false,'',0)\"";
            ClassString = "BtnPrevious";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_previous_Internalname, "", "<", bttBtn_previous_Jsonclick, 5, "<", "", StyleString, ClassString, bttBtn_previous_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"EPREVIOUS."+"'", TempTags, "", context.GetButtonType( ), "HLP_WWPBaseObjects\\SecUserRole.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 16,'',false,'',0)\"";
            ClassString = "BtnNext";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_next_Internalname, "", ">", bttBtn_next_Jsonclick, 5, ">", "", StyleString, ClassString, bttBtn_next_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ENEXT."+"'", TempTags, "", context.GetButtonType( ), "HLP_WWPBaseObjects\\SecUserRole.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 18,'',false,'',0)\"";
            ClassString = "BtnLast";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_last_Internalname, "", ">|", bttBtn_last_Jsonclick, 5, ">|", "", StyleString, ClassString, bttBtn_last_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ELAST."+"'", TempTags, "", context.GetButtonType( ), "HLP_WWPBaseObjects\\SecUserRole.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 20,'',false,'',0)\"";
            ClassString = "BtnSelect";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_select_Internalname, "", "选择", bttBtn_select_Jsonclick, 5, "选择", "", StyleString, ClassString, bttBtn_select_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ESELECT."+"'", TempTags, "", 2, "HLP_WWPBaseObjects\\SecUserRole.htm");
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
            GxWebStd.gx_single_line_edit( context, edtSecUserId_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A6SecUserId), 4, 0, ".", "")), ((edtSecUserId_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A6SecUserId), "ZZZ9")) : context.localUtil.Format( (decimal)(A6SecUserId), "ZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,28);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtSecUserId_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtSecUserId_Enabled, 0, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_WWPBaseObjects\\SecUserRole.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtSecRoleId_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtSecRoleId_Internalname, "角色编号", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 33,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtSecRoleId_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A4SecRoleId), 4, 0, ".", "")), ((edtSecRoleId_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A4SecRoleId), "ZZZ9")) : context.localUtil.Format( (decimal)(A4SecRoleId), "ZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,33);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtSecRoleId_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtSecRoleId_Enabled, 0, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_WWPBaseObjects\\SecUserRole.htm");
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
            GxWebStd.gx_single_line_edit( context, edtSecUserName_Internalname, A14SecUserName, StringUtil.RTrim( context.localUtil.Format( A14SecUserName, "")), "", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtSecUserName_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtSecUserName_Enabled, 0, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_WWPBaseObjects\\SecUserRole.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtSecRoleName_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtSecRoleName_Internalname, "角色名称", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtSecRoleName_Internalname, A13SecRoleName, StringUtil.RTrim( context.localUtil.Format( A13SecRoleName, "")), "", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtSecRoleName_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtSecRoleName_Enabled, 0, "text", "", 40, "chr", 1, "row", 40, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_WWPBaseObjects\\SecUserRole.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtSecRoleDescription_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtSecRoleDescription_Internalname, "角色描述", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtSecRoleDescription_Internalname, A12SecRoleDescription, StringUtil.RTrim( context.localUtil.Format( A12SecRoleDescription, "")), "", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtSecRoleDescription_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtSecRoleDescription_Enabled, 0, "text", "", 80, "chr", 1, "row", 120, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_WWPBaseObjects\\SecUserRole.htm");
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
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 53,'',false,'',0)\"";
            ClassString = "BtnEnter";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_enter_Internalname, "", "确认", bttBtn_enter_Jsonclick, 5, "确认", "", StyleString, ClassString, bttBtn_enter_Visible, bttBtn_enter_Enabled, "standard", "'"+""+"'"+",false,"+"'"+"EENTER."+"'", TempTags, "", context.GetButtonType( ), "HLP_WWPBaseObjects\\SecUserRole.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 55,'',false,'',0)\"";
            ClassString = "BtnCancel";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_cancel_Internalname, "", "取消", bttBtn_cancel_Jsonclick, 1, "取消", "", StyleString, ClassString, bttBtn_cancel_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ECANCEL."+"'", TempTags, "", context.GetButtonType( ), "HLP_WWPBaseObjects\\SecUserRole.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 57,'',false,'',0)\"";
            ClassString = "BtnDelete";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_delete_Internalname, "", "删除", bttBtn_delete_Jsonclick, 5, "删除", "", StyleString, ClassString, bttBtn_delete_Visible, bttBtn_delete_Enabled, "standard", "'"+""+"'"+",false,"+"'"+"EDELETE."+"'", TempTags, "", context.GetButtonType( ), "HLP_WWPBaseObjects\\SecUserRole.htm");
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
               if ( ( ( context.localUtil.CToN( cgiGet( edtSecRoleId_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtSecRoleId_Internalname), ".", ",") > Convert.ToDecimal( 9999 )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "SECROLEID");
                  AnyError = 1;
                  GX_FocusControl = edtSecRoleId_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A4SecRoleId = 0;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A4SecRoleId", StringUtil.LTrim( StringUtil.Str( (decimal)(A4SecRoleId), 4, 0)));
               }
               else
               {
                  A4SecRoleId = (short)(context.localUtil.CToN( cgiGet( edtSecRoleId_Internalname), ".", ","));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A4SecRoleId", StringUtil.LTrim( StringUtil.Str( (decimal)(A4SecRoleId), 4, 0)));
               }
               A14SecUserName = cgiGet( edtSecUserName_Internalname);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A14SecUserName", A14SecUserName);
               A13SecRoleName = cgiGet( edtSecRoleName_Internalname);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A13SecRoleName", A13SecRoleName);
               A12SecRoleDescription = cgiGet( edtSecRoleDescription_Internalname);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A12SecRoleDescription", A12SecRoleDescription);
               /* Read saved values. */
               Z6SecUserId = (short)(context.localUtil.CToN( cgiGet( "Z6SecUserId"), ".", ","));
               Z4SecRoleId = (short)(context.localUtil.CToN( cgiGet( "Z4SecRoleId"), ".", ","));
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
                  A4SecRoleId = (short)(NumberUtil.Val( GetNextPar( ), "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A4SecRoleId", StringUtil.LTrim( StringUtil.Str( (decimal)(A4SecRoleId), 4, 0)));
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
               InitAll067( ) ;
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
         DisableAttributes067( ) ;
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

      protected void ResetCaption060( )
      {
      }

      protected void ZM067( short GX_JID )
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
            Z4SecRoleId = A4SecRoleId;
            Z14SecUserName = A14SecUserName;
            Z13SecRoleName = A13SecRoleName;
            Z12SecRoleDescription = A12SecRoleDescription;
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

      protected void Load067( )
      {
         /* Using cursor T00066 */
         pr_default.execute(4, new Object[] {A6SecUserId, A4SecRoleId});
         if ( (pr_default.getStatus(4) != 101) )
         {
            RcdFound7 = 1;
            A14SecUserName = T00066_A14SecUserName[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A14SecUserName", A14SecUserName);
            A13SecRoleName = T00066_A13SecRoleName[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A13SecRoleName", A13SecRoleName);
            A12SecRoleDescription = T00066_A12SecRoleDescription[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A12SecRoleDescription", A12SecRoleDescription);
            ZM067( -1) ;
         }
         pr_default.close(4);
         OnLoadActions067( ) ;
      }

      protected void OnLoadActions067( )
      {
      }

      protected void CheckExtendedTable067( )
      {
         Gx_BScreen = 1;
         standaloneModal( ) ;
         /* Using cursor T00064 */
         pr_default.execute(2, new Object[] {A6SecUserId});
         if ( (pr_default.getStatus(2) == 101) )
         {
            GX_msglist.addItem("不匹配'User'", "ForeignKeyNotFound", 1, "SECUSERID");
            AnyError = 1;
            GX_FocusControl = edtSecUserId_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         A14SecUserName = T00064_A14SecUserName[0];
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A14SecUserName", A14SecUserName);
         pr_default.close(2);
         /* Using cursor T00065 */
         pr_default.execute(3, new Object[] {A4SecRoleId});
         if ( (pr_default.getStatus(3) == 101) )
         {
            GX_msglist.addItem("不匹配'Role'", "ForeignKeyNotFound", 1, "SECROLEID");
            AnyError = 1;
            GX_FocusControl = edtSecRoleId_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         A13SecRoleName = T00065_A13SecRoleName[0];
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A13SecRoleName", A13SecRoleName);
         A12SecRoleDescription = T00065_A12SecRoleDescription[0];
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A12SecRoleDescription", A12SecRoleDescription);
         pr_default.close(3);
      }

      protected void CloseExtendedTableCursors067( )
      {
         pr_default.close(2);
         pr_default.close(3);
      }

      protected void enableDisable( )
      {
      }

      protected void gxLoad_2( short A6SecUserId )
      {
         /* Using cursor T00067 */
         pr_default.execute(5, new Object[] {A6SecUserId});
         if ( (pr_default.getStatus(5) == 101) )
         {
            GX_msglist.addItem("不匹配'User'", "ForeignKeyNotFound", 1, "SECUSERID");
            AnyError = 1;
            GX_FocusControl = edtSecUserId_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         A14SecUserName = T00067_A14SecUserName[0];
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

      protected void gxLoad_3( short A4SecRoleId )
      {
         /* Using cursor T00068 */
         pr_default.execute(6, new Object[] {A4SecRoleId});
         if ( (pr_default.getStatus(6) == 101) )
         {
            GX_msglist.addItem("不匹配'Role'", "ForeignKeyNotFound", 1, "SECROLEID");
            AnyError = 1;
            GX_FocusControl = edtSecRoleId_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         A13SecRoleName = T00068_A13SecRoleName[0];
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A13SecRoleName", A13SecRoleName);
         A12SecRoleDescription = T00068_A12SecRoleDescription[0];
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A12SecRoleDescription", A12SecRoleDescription);
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("[[");
         context.GX_webresponse.AddString("\""+GXUtil.EncodeJSConstant( A13SecRoleName)+"\""+","+"\""+GXUtil.EncodeJSConstant( A12SecRoleDescription)+"\"");
         context.GX_webresponse.AddString("]");
         if ( (pr_default.getStatus(6) == 101) )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString("]");
         pr_default.close(6);
      }

      protected void GetKey067( )
      {
         /* Using cursor T00069 */
         pr_default.execute(7, new Object[] {A6SecUserId, A4SecRoleId});
         if ( (pr_default.getStatus(7) != 101) )
         {
            RcdFound7 = 1;
         }
         else
         {
            RcdFound7 = 0;
         }
         pr_default.close(7);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor T00063 */
         pr_default.execute(1, new Object[] {A6SecUserId, A4SecRoleId});
         if ( (pr_default.getStatus(1) != 101) )
         {
            ZM067( 1) ;
            RcdFound7 = 1;
            A6SecUserId = T00063_A6SecUserId[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A6SecUserId", StringUtil.LTrim( StringUtil.Str( (decimal)(A6SecUserId), 4, 0)));
            A4SecRoleId = T00063_A4SecRoleId[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A4SecRoleId", StringUtil.LTrim( StringUtil.Str( (decimal)(A4SecRoleId), 4, 0)));
            Z6SecUserId = A6SecUserId;
            Z4SecRoleId = A4SecRoleId;
            sMode7 = Gx_mode;
            Gx_mode = "DSP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            standaloneModal( ) ;
            Load067( ) ;
            if ( AnyError == 1 )
            {
               RcdFound7 = 0;
               InitializeNonKey067( ) ;
            }
            Gx_mode = sMode7;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         else
         {
            RcdFound7 = 0;
            InitializeNonKey067( ) ;
            sMode7 = Gx_mode;
            Gx_mode = "DSP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            standaloneModal( ) ;
            Gx_mode = sMode7;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         pr_default.close(1);
      }

      protected void getEqualNoModal( )
      {
         GetKey067( ) ;
         if ( RcdFound7 == 0 )
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
         RcdFound7 = 0;
         /* Using cursor T000610 */
         pr_default.execute(8, new Object[] {A6SecUserId, A4SecRoleId});
         if ( (pr_default.getStatus(8) != 101) )
         {
            while ( (pr_default.getStatus(8) != 101) && ( ( T000610_A6SecUserId[0] < A6SecUserId ) || ( T000610_A6SecUserId[0] == A6SecUserId ) && ( T000610_A4SecRoleId[0] < A4SecRoleId ) ) )
            {
               pr_default.readNext(8);
            }
            if ( (pr_default.getStatus(8) != 101) && ( ( T000610_A6SecUserId[0] > A6SecUserId ) || ( T000610_A6SecUserId[0] == A6SecUserId ) && ( T000610_A4SecRoleId[0] > A4SecRoleId ) ) )
            {
               A6SecUserId = T000610_A6SecUserId[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A6SecUserId", StringUtil.LTrim( StringUtil.Str( (decimal)(A6SecUserId), 4, 0)));
               A4SecRoleId = T000610_A4SecRoleId[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A4SecRoleId", StringUtil.LTrim( StringUtil.Str( (decimal)(A4SecRoleId), 4, 0)));
               RcdFound7 = 1;
            }
         }
         pr_default.close(8);
      }

      protected void move_previous( )
      {
         RcdFound7 = 0;
         /* Using cursor T000611 */
         pr_default.execute(9, new Object[] {A6SecUserId, A4SecRoleId});
         if ( (pr_default.getStatus(9) != 101) )
         {
            while ( (pr_default.getStatus(9) != 101) && ( ( T000611_A6SecUserId[0] > A6SecUserId ) || ( T000611_A6SecUserId[0] == A6SecUserId ) && ( T000611_A4SecRoleId[0] > A4SecRoleId ) ) )
            {
               pr_default.readNext(9);
            }
            if ( (pr_default.getStatus(9) != 101) && ( ( T000611_A6SecUserId[0] < A6SecUserId ) || ( T000611_A6SecUserId[0] == A6SecUserId ) && ( T000611_A4SecRoleId[0] < A4SecRoleId ) ) )
            {
               A6SecUserId = T000611_A6SecUserId[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A6SecUserId", StringUtil.LTrim( StringUtil.Str( (decimal)(A6SecUserId), 4, 0)));
               A4SecRoleId = T000611_A4SecRoleId[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A4SecRoleId", StringUtil.LTrim( StringUtil.Str( (decimal)(A4SecRoleId), 4, 0)));
               RcdFound7 = 1;
            }
         }
         pr_default.close(9);
      }

      protected void btn_enter( )
      {
         nKeyPressed = 1;
         GetKey067( ) ;
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            /* Insert record */
            GX_FocusControl = edtSecUserId_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            Insert067( ) ;
            if ( AnyError == 1 )
            {
               GX_FocusControl = "";
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
         }
         else
         {
            if ( RcdFound7 == 1 )
            {
               if ( ( A6SecUserId != Z6SecUserId ) || ( A4SecRoleId != Z4SecRoleId ) )
               {
                  A6SecUserId = Z6SecUserId;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A6SecUserId", StringUtil.LTrim( StringUtil.Str( (decimal)(A6SecUserId), 4, 0)));
                  A4SecRoleId = Z4SecRoleId;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A4SecRoleId", StringUtil.LTrim( StringUtil.Str( (decimal)(A4SecRoleId), 4, 0)));
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
                  Update067( ) ;
                  GX_FocusControl = edtSecUserId_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
            }
            else
            {
               if ( ( A6SecUserId != Z6SecUserId ) || ( A4SecRoleId != Z4SecRoleId ) )
               {
                  Gx_mode = "INS";
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                  /* Insert record */
                  GX_FocusControl = edtSecUserId_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  Insert067( ) ;
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
                     Insert067( ) ;
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
         if ( ( A6SecUserId != Z6SecUserId ) || ( A4SecRoleId != Z4SecRoleId ) )
         {
            A6SecUserId = Z6SecUserId;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A6SecUserId", StringUtil.LTrim( StringUtil.Str( (decimal)(A6SecUserId), 4, 0)));
            A4SecRoleId = Z4SecRoleId;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A4SecRoleId", StringUtil.LTrim( StringUtil.Str( (decimal)(A4SecRoleId), 4, 0)));
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
         if ( RcdFound7 == 0 )
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
         ScanStart067( ) ;
         if ( RcdFound7 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "", true);
         }
         else
         {
            Gx_mode = "UPD";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         ScanEnd067( ) ;
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
         if ( RcdFound7 == 0 )
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
         if ( RcdFound7 == 0 )
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
         ScanStart067( ) ;
         if ( RcdFound7 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "", true);
         }
         else
         {
            while ( RcdFound7 != 0 )
            {
               ScanNext067( ) ;
            }
            Gx_mode = "UPD";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         ScanEnd067( ) ;
         getByPrimaryKey( ) ;
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_select( )
      {
         getEqualNoModal( ) ;
      }

      protected void CheckOptimisticConcurrency067( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor T00062 */
            pr_default.execute(0, new Object[] {A6SecUserId, A4SecRoleId});
            if ( (pr_default.getStatus(0) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"SecUserRole"}), "RecordIsLocked", 1, "");
               AnyError = 1;
               return  ;
            }
            if ( (pr_default.getStatus(0) == 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"SecUserRole"}), "RecordWasChanged", 1, "");
               AnyError = 1;
               return  ;
            }
         }
      }

      protected void Insert067( )
      {
         BeforeValidate067( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable067( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM067( 0) ;
            CheckOptimisticConcurrency067( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm067( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert067( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000612 */
                     pr_default.execute(10, new Object[] {A6SecUserId, A4SecRoleId});
                     pr_default.close(10);
                     dsDefault.SmartCacheProvider.SetUpdated("SecUserRole") ;
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
                           ResetCaption060( ) ;
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
               Load067( ) ;
            }
            EndLevel067( ) ;
         }
         CloseExtendedTableCursors067( ) ;
      }

      protected void Update067( )
      {
         BeforeValidate067( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable067( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency067( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm067( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate067( ) ;
                  if ( AnyError == 0 )
                  {
                     /* No attributes to update on table [SecUserRole] */
                     DeferredUpdate067( ) ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( update) rules */
                        /* End of After( update) rules */
                        if ( AnyError == 0 )
                        {
                           getByPrimaryKey( ) ;
                           GX_msglist.addItem(context.GetMessage( "GXM_sucupdated", ""), "SuccessfullyUpdated", 0, "", true);
                           ResetCaption060( ) ;
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
            EndLevel067( ) ;
         }
         CloseExtendedTableCursors067( ) ;
      }

      protected void DeferredUpdate067( )
      {
      }

      protected void delete( )
      {
         Gx_mode = "DLT";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         BeforeValidate067( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency067( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls067( ) ;
            AfterConfirm067( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete067( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor T000613 */
                  pr_default.execute(11, new Object[] {A6SecUserId, A4SecRoleId});
                  pr_default.close(11);
                  dsDefault.SmartCacheProvider.SetUpdated("SecUserRole") ;
                  if ( AnyError == 0 )
                  {
                     /* Start of After( delete) rules */
                     /* End of After( delete) rules */
                     if ( AnyError == 0 )
                     {
                        move_next( ) ;
                        if ( RcdFound7 == 0 )
                        {
                           InitAll067( ) ;
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
                        ResetCaption060( ) ;
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
         sMode7 = Gx_mode;
         Gx_mode = "DLT";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         EndLevel067( ) ;
         Gx_mode = sMode7;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
      }

      protected void OnDeleteControls067( )
      {
         standaloneModal( ) ;
         if ( AnyError == 0 )
         {
            /* Delete mode formulas */
            /* Using cursor T000614 */
            pr_default.execute(12, new Object[] {A6SecUserId});
            A14SecUserName = T000614_A14SecUserName[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A14SecUserName", A14SecUserName);
            pr_default.close(12);
            /* Using cursor T000615 */
            pr_default.execute(13, new Object[] {A4SecRoleId});
            A13SecRoleName = T000615_A13SecRoleName[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A13SecRoleName", A13SecRoleName);
            A12SecRoleDescription = T000615_A12SecRoleDescription[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A12SecRoleDescription", A12SecRoleDescription);
            pr_default.close(13);
         }
      }

      protected void EndLevel067( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            pr_default.close(0);
         }
         if ( AnyError == 0 )
         {
            BeforeComplete067( ) ;
         }
         if ( AnyError == 0 )
         {
            pr_default.close(1);
            pr_default.close(12);
            pr_default.close(13);
            context.CommitDataStores("wwpbaseobjects.secuserrole",pr_default);
            if ( AnyError == 0 )
            {
               ConfirmValues060( ) ;
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
            context.RollbackDataStores("wwpbaseobjects.secuserrole",pr_default);
         }
         IsModified = 0;
         if ( AnyError != 0 )
         {
            context.wjLoc = "";
            context.nUserReturn = 0;
         }
      }

      public void ScanStart067( )
      {
         /* Using cursor T000616 */
         pr_default.execute(14);
         RcdFound7 = 0;
         if ( (pr_default.getStatus(14) != 101) )
         {
            RcdFound7 = 1;
            A6SecUserId = T000616_A6SecUserId[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A6SecUserId", StringUtil.LTrim( StringUtil.Str( (decimal)(A6SecUserId), 4, 0)));
            A4SecRoleId = T000616_A4SecRoleId[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A4SecRoleId", StringUtil.LTrim( StringUtil.Str( (decimal)(A4SecRoleId), 4, 0)));
         }
         /* Load Subordinate Levels */
      }

      protected void ScanNext067( )
      {
         /* Scan next routine */
         pr_default.readNext(14);
         RcdFound7 = 0;
         if ( (pr_default.getStatus(14) != 101) )
         {
            RcdFound7 = 1;
            A6SecUserId = T000616_A6SecUserId[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A6SecUserId", StringUtil.LTrim( StringUtil.Str( (decimal)(A6SecUserId), 4, 0)));
            A4SecRoleId = T000616_A4SecRoleId[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A4SecRoleId", StringUtil.LTrim( StringUtil.Str( (decimal)(A4SecRoleId), 4, 0)));
         }
      }

      protected void ScanEnd067( )
      {
         pr_default.close(14);
      }

      protected void AfterConfirm067( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert067( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate067( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete067( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete067( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate067( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes067( )
      {
         edtSecUserId_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtSecUserId_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtSecUserId_Enabled), 5, 0)), true);
         edtSecRoleId_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtSecRoleId_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtSecRoleId_Enabled), 5, 0)), true);
         edtSecUserName_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtSecUserName_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtSecUserName_Enabled), 5, 0)), true);
         edtSecRoleName_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtSecRoleName_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtSecRoleName_Enabled), 5, 0)), true);
         edtSecRoleDescription_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtSecRoleDescription_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtSecRoleDescription_Enabled), 5, 0)), true);
      }

      protected void send_integrity_lvl_hashes067( )
      {
      }

      protected void assign_properties_default( )
      {
      }

      protected void ConfirmValues060( )
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
         context.AddJavascriptSource("gxcfg.js", "?202022711553139", false);
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" autocomplete=\"off\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("wwpbaseobjects.secuserrole.aspx") +"\">") ;
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
         GxWebStd.gx_hidden_field( context, "Z4SecRoleId", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z4SecRoleId), 4, 0, ".", "")));
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
         return formatLink("wwpbaseobjects.secuserrole.aspx")  ;
      }

      public override String GetPgmname( )
      {
         return "WWPBaseObjects.SecUserRole" ;
      }

      public override String GetPgmdesc( )
      {
         return "用户角色关系表" ;
      }

      protected void InitializeNonKey067( )
      {
         A14SecUserName = "";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A14SecUserName", A14SecUserName);
         A13SecRoleName = "";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A13SecRoleName", A13SecRoleName);
         A12SecRoleDescription = "";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A12SecRoleDescription", A12SecRoleDescription);
      }

      protected void InitAll067( )
      {
         A6SecUserId = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A6SecUserId", StringUtil.LTrim( StringUtil.Str( (decimal)(A6SecUserId), 4, 0)));
         A4SecRoleId = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A4SecRoleId", StringUtil.LTrim( StringUtil.Str( (decimal)(A4SecRoleId), 4, 0)));
         InitializeNonKey067( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?202022711553147", true);
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
         context.AddJavascriptSource("wwpbaseobjects/secuserrole.js", "?202022711553147", false);
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
         edtSecRoleId_Internalname = "SECROLEID";
         edtSecUserName_Internalname = "SECUSERNAME";
         edtSecRoleName_Internalname = "SECROLENAME";
         edtSecRoleDescription_Internalname = "SECROLEDESCRIPTION";
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
         Form.Caption = "用户角色关系表";
         bttBtn_delete_Enabled = 1;
         bttBtn_delete_Visible = 1;
         bttBtn_cancel_Visible = 1;
         bttBtn_enter_Enabled = 1;
         bttBtn_enter_Visible = 1;
         edtSecRoleDescription_Jsonclick = "";
         edtSecRoleDescription_Enabled = 0;
         edtSecRoleName_Jsonclick = "";
         edtSecRoleName_Enabled = 0;
         edtSecUserName_Jsonclick = "";
         edtSecUserName_Enabled = 0;
         edtSecRoleId_Jsonclick = "";
         edtSecRoleId_Enabled = 1;
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
         /* Using cursor T000614 */
         pr_default.execute(12, new Object[] {A6SecUserId});
         if ( (pr_default.getStatus(12) == 101) )
         {
            GX_msglist.addItem("不匹配'User'", "ForeignKeyNotFound", 1, "SECUSERID");
            AnyError = 1;
            GX_FocusControl = edtSecUserId_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         A14SecUserName = T000614_A14SecUserName[0];
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A14SecUserName", A14SecUserName);
         pr_default.close(12);
         /* Using cursor T000615 */
         pr_default.execute(13, new Object[] {A4SecRoleId});
         if ( (pr_default.getStatus(13) == 101) )
         {
            GX_msglist.addItem("不匹配'Role'", "ForeignKeyNotFound", 1, "SECROLEID");
            AnyError = 1;
            GX_FocusControl = edtSecRoleId_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         A13SecRoleName = T000615_A13SecRoleName[0];
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A13SecRoleName", A13SecRoleName);
         A12SecRoleDescription = T000615_A12SecRoleDescription[0];
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A12SecRoleDescription", A12SecRoleDescription);
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
         /* Using cursor T000614 */
         pr_default.execute(12, new Object[] {A6SecUserId});
         if ( (pr_default.getStatus(12) == 101) )
         {
            GX_msglist.addItem("不匹配'User'", "ForeignKeyNotFound", 1, "SECUSERID");
            AnyError = 1;
            GX_FocusControl = edtSecUserId_Internalname;
         }
         A14SecUserName = T000614_A14SecUserName[0];
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

      public void Valid_Secroleid( short GX_Parm1 ,
                                   short GX_Parm2 ,
                                   String GX_Parm3 ,
                                   String GX_Parm4 )
      {
         A6SecUserId = GX_Parm1;
         A4SecRoleId = GX_Parm2;
         A13SecRoleName = GX_Parm3;
         A12SecRoleDescription = GX_Parm4;
         context.wbHandled = 1;
         AfterKeyLoadScreen( ) ;
         Draw( ) ;
         send_integrity_footer_hashes( ) ;
         /* Using cursor T000615 */
         pr_default.execute(13, new Object[] {A4SecRoleId});
         if ( (pr_default.getStatus(13) == 101) )
         {
            GX_msglist.addItem("不匹配'Role'", "ForeignKeyNotFound", 1, "SECROLEID");
            AnyError = 1;
            GX_FocusControl = edtSecRoleId_Internalname;
         }
         A13SecRoleName = T000615_A13SecRoleName[0];
         A12SecRoleDescription = T000615_A12SecRoleDescription[0];
         pr_default.close(13);
         dynload_actions( ) ;
         if ( AnyError == 1 )
         {
            A14SecUserName = "";
            A13SecRoleName = "";
            A12SecRoleDescription = "";
         }
         isValidOutput.Add(A14SecUserName);
         isValidOutput.Add(A13SecRoleName);
         isValidOutput.Add(A12SecRoleDescription);
         isValidOutput.Add(StringUtil.RTrim( Gx_mode));
         isValidOutput.Add(StringUtil.LTrim( StringUtil.NToC( (decimal)(Z6SecUserId), 4, 0, ".", "")));
         isValidOutput.Add(StringUtil.LTrim( StringUtil.NToC( (decimal)(Z4SecRoleId), 4, 0, ".", "")));
         isValidOutput.Add(Z14SecUserName);
         isValidOutput.Add(Z13SecRoleName);
         isValidOutput.Add(Z12SecRoleDescription);
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
         A13SecRoleName = "";
         A12SecRoleDescription = "";
         bttBtn_enter_Jsonclick = "";
         bttBtn_cancel_Jsonclick = "";
         bttBtn_delete_Jsonclick = "";
         Gx_mode = "";
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         Z14SecUserName = "";
         Z13SecRoleName = "";
         Z12SecRoleDescription = "";
         T00066_A14SecUserName = new String[] {""} ;
         T00066_A13SecRoleName = new String[] {""} ;
         T00066_A12SecRoleDescription = new String[] {""} ;
         T00066_A6SecUserId = new short[1] ;
         T00066_A4SecRoleId = new short[1] ;
         T00064_A14SecUserName = new String[] {""} ;
         T00065_A13SecRoleName = new String[] {""} ;
         T00065_A12SecRoleDescription = new String[] {""} ;
         T00067_A14SecUserName = new String[] {""} ;
         T00068_A13SecRoleName = new String[] {""} ;
         T00068_A12SecRoleDescription = new String[] {""} ;
         T00069_A6SecUserId = new short[1] ;
         T00069_A4SecRoleId = new short[1] ;
         T00063_A6SecUserId = new short[1] ;
         T00063_A4SecRoleId = new short[1] ;
         sMode7 = "";
         T000610_A6SecUserId = new short[1] ;
         T000610_A4SecRoleId = new short[1] ;
         T000611_A6SecUserId = new short[1] ;
         T000611_A4SecRoleId = new short[1] ;
         T00062_A6SecUserId = new short[1] ;
         T00062_A4SecRoleId = new short[1] ;
         T000614_A14SecUserName = new String[] {""} ;
         T000615_A13SecRoleName = new String[] {""} ;
         T000615_A12SecRoleDescription = new String[] {""} ;
         T000616_A6SecUserId = new short[1] ;
         T000616_A4SecRoleId = new short[1] ;
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         isValidOutput = new GxUnknownObjectCollection();
         pr_datastore1 = new DataStoreProvider(context, new GeneXus.Programs.wwpbaseobjects.secuserrole__datastore1(),
            new Object[][] {
            }
         );
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.wwpbaseobjects.secuserrole__default(),
            new Object[][] {
                new Object[] {
               T00062_A6SecUserId, T00062_A4SecRoleId
               }
               , new Object[] {
               T00063_A6SecUserId, T00063_A4SecRoleId
               }
               , new Object[] {
               T00064_A14SecUserName
               }
               , new Object[] {
               T00065_A13SecRoleName, T00065_A12SecRoleDescription
               }
               , new Object[] {
               T00066_A14SecUserName, T00066_A13SecRoleName, T00066_A12SecRoleDescription, T00066_A6SecUserId, T00066_A4SecRoleId
               }
               , new Object[] {
               T00067_A14SecUserName
               }
               , new Object[] {
               T00068_A13SecRoleName, T00068_A12SecRoleDescription
               }
               , new Object[] {
               T00069_A6SecUserId, T00069_A4SecRoleId
               }
               , new Object[] {
               T000610_A6SecUserId, T000610_A4SecRoleId
               }
               , new Object[] {
               T000611_A6SecUserId, T000611_A4SecRoleId
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               T000614_A14SecUserName
               }
               , new Object[] {
               T000615_A13SecRoleName, T000615_A12SecRoleDescription
               }
               , new Object[] {
               T000616_A6SecUserId, T000616_A4SecRoleId
               }
            }
         );
      }

      private short Z6SecUserId ;
      private short Z4SecRoleId ;
      private short GxWebError ;
      private short A6SecUserId ;
      private short A4SecRoleId ;
      private short gxcookieaux ;
      private short IsConfirmed ;
      private short IsModified ;
      private short AnyError ;
      private short nKeyPressed ;
      private short initialized ;
      private short GX_JID ;
      private short RcdFound7 ;
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
      private int edtSecRoleId_Enabled ;
      private int edtSecUserName_Enabled ;
      private int edtSecRoleName_Enabled ;
      private int edtSecRoleDescription_Enabled ;
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
      private String edtSecRoleId_Internalname ;
      private String edtSecRoleId_Jsonclick ;
      private String edtSecUserName_Internalname ;
      private String edtSecUserName_Jsonclick ;
      private String edtSecRoleName_Internalname ;
      private String edtSecRoleName_Jsonclick ;
      private String edtSecRoleDescription_Internalname ;
      private String edtSecRoleDescription_Jsonclick ;
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
      private String sMode7 ;
      private String sDynURL ;
      private String FormProcess ;
      private String bodyStyle ;
      private bool entryPointCalled ;
      private bool toggleJsOutput ;
      private bool wbErr ;
      private String A14SecUserName ;
      private String A13SecRoleName ;
      private String A12SecRoleDescription ;
      private String Z14SecUserName ;
      private String Z13SecRoleName ;
      private String Z12SecRoleDescription ;
      private GxUnknownObjectCollection isValidOutput ;
      private IGxDataStore dsDataStore1 ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private String[] T00066_A14SecUserName ;
      private String[] T00066_A13SecRoleName ;
      private String[] T00066_A12SecRoleDescription ;
      private short[] T00066_A6SecUserId ;
      private short[] T00066_A4SecRoleId ;
      private String[] T00064_A14SecUserName ;
      private String[] T00065_A13SecRoleName ;
      private String[] T00065_A12SecRoleDescription ;
      private String[] T00067_A14SecUserName ;
      private String[] T00068_A13SecRoleName ;
      private String[] T00068_A12SecRoleDescription ;
      private short[] T00069_A6SecUserId ;
      private short[] T00069_A4SecRoleId ;
      private short[] T00063_A6SecUserId ;
      private short[] T00063_A4SecRoleId ;
      private short[] T000610_A6SecUserId ;
      private short[] T000610_A4SecRoleId ;
      private short[] T000611_A6SecUserId ;
      private short[] T000611_A4SecRoleId ;
      private short[] T00062_A6SecUserId ;
      private short[] T00062_A4SecRoleId ;
      private String[] T000614_A14SecUserName ;
      private String[] T000615_A13SecRoleName ;
      private String[] T000615_A12SecRoleDescription ;
      private short[] T000616_A6SecUserId ;
      private short[] T000616_A4SecRoleId ;
      private IDataStoreProvider pr_datastore1 ;
      private GXWebForm Form ;
   }

   public class secuserrole__datastore1 : DataStoreHelperBase, IDataStoreHelper
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

 public class secuserrole__default : DataStoreHelperBase, IDataStoreHelper
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
        Object[] prmT00066 ;
        prmT00066 = new Object[] {
        new Object[] {"@SecUserId",SqlDbType.SmallInt,4,0} ,
        new Object[] {"@SecRoleId",SqlDbType.SmallInt,4,0}
        } ;
        Object[] prmT00064 ;
        prmT00064 = new Object[] {
        new Object[] {"@SecUserId",SqlDbType.SmallInt,4,0}
        } ;
        Object[] prmT00065 ;
        prmT00065 = new Object[] {
        new Object[] {"@SecRoleId",SqlDbType.SmallInt,4,0}
        } ;
        Object[] prmT00067 ;
        prmT00067 = new Object[] {
        new Object[] {"@SecUserId",SqlDbType.SmallInt,4,0}
        } ;
        Object[] prmT00068 ;
        prmT00068 = new Object[] {
        new Object[] {"@SecRoleId",SqlDbType.SmallInt,4,0}
        } ;
        Object[] prmT00069 ;
        prmT00069 = new Object[] {
        new Object[] {"@SecUserId",SqlDbType.SmallInt,4,0} ,
        new Object[] {"@SecRoleId",SqlDbType.SmallInt,4,0}
        } ;
        Object[] prmT00063 ;
        prmT00063 = new Object[] {
        new Object[] {"@SecUserId",SqlDbType.SmallInt,4,0} ,
        new Object[] {"@SecRoleId",SqlDbType.SmallInt,4,0}
        } ;
        Object[] prmT000610 ;
        prmT000610 = new Object[] {
        new Object[] {"@SecUserId",SqlDbType.SmallInt,4,0} ,
        new Object[] {"@SecRoleId",SqlDbType.SmallInt,4,0}
        } ;
        Object[] prmT000611 ;
        prmT000611 = new Object[] {
        new Object[] {"@SecUserId",SqlDbType.SmallInt,4,0} ,
        new Object[] {"@SecRoleId",SqlDbType.SmallInt,4,0}
        } ;
        Object[] prmT00062 ;
        prmT00062 = new Object[] {
        new Object[] {"@SecUserId",SqlDbType.SmallInt,4,0} ,
        new Object[] {"@SecRoleId",SqlDbType.SmallInt,4,0}
        } ;
        Object[] prmT000612 ;
        prmT000612 = new Object[] {
        new Object[] {"@SecUserId",SqlDbType.SmallInt,4,0} ,
        new Object[] {"@SecRoleId",SqlDbType.SmallInt,4,0}
        } ;
        Object[] prmT000613 ;
        prmT000613 = new Object[] {
        new Object[] {"@SecUserId",SqlDbType.SmallInt,4,0} ,
        new Object[] {"@SecRoleId",SqlDbType.SmallInt,4,0}
        } ;
        Object[] prmT000616 ;
        prmT000616 = new Object[] {
        } ;
        Object[] prmT000614 ;
        prmT000614 = new Object[] {
        new Object[] {"@SecUserId",SqlDbType.SmallInt,4,0}
        } ;
        Object[] prmT000615 ;
        prmT000615 = new Object[] {
        new Object[] {"@SecRoleId",SqlDbType.SmallInt,4,0}
        } ;
        def= new CursorDef[] {
            new CursorDef("T00062", "SELECT [SecUserId], [SecRoleId] FROM [SecUserRole] WITH (UPDLOCK) WHERE [SecUserId] = @SecUserId AND [SecRoleId] = @SecRoleId ",true, GxErrorMask.GX_NOMASK, false, this,prmT00062,1,0,true,false )
           ,new CursorDef("T00063", "SELECT [SecUserId], [SecRoleId] FROM [SecUserRole] WITH (NOLOCK) WHERE [SecUserId] = @SecUserId AND [SecRoleId] = @SecRoleId ",true, GxErrorMask.GX_NOMASK, false, this,prmT00063,1,0,true,false )
           ,new CursorDef("T00064", "SELECT [SecUserName] FROM [SecUser] WITH (NOLOCK) WHERE [SecUserId] = @SecUserId ",true, GxErrorMask.GX_NOMASK, false, this,prmT00064,1,0,true,false )
           ,new CursorDef("T00065", "SELECT [SecRoleName], [SecRoleDescription] FROM [SecRole] WITH (NOLOCK) WHERE [SecRoleId] = @SecRoleId ",true, GxErrorMask.GX_NOMASK, false, this,prmT00065,1,0,true,false )
           ,new CursorDef("T00066", "SELECT T2.[SecUserName], T3.[SecRoleName], T3.[SecRoleDescription], TM1.[SecUserId], TM1.[SecRoleId] FROM (([SecUserRole] TM1 WITH (NOLOCK) INNER JOIN [SecUser] T2 WITH (NOLOCK) ON T2.[SecUserId] = TM1.[SecUserId]) INNER JOIN [SecRole] T3 WITH (NOLOCK) ON T3.[SecRoleId] = TM1.[SecRoleId]) WHERE TM1.[SecUserId] = @SecUserId and TM1.[SecRoleId] = @SecRoleId ORDER BY TM1.[SecUserId], TM1.[SecRoleId]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT00066,100,0,true,false )
           ,new CursorDef("T00067", "SELECT [SecUserName] FROM [SecUser] WITH (NOLOCK) WHERE [SecUserId] = @SecUserId ",true, GxErrorMask.GX_NOMASK, false, this,prmT00067,1,0,true,false )
           ,new CursorDef("T00068", "SELECT [SecRoleName], [SecRoleDescription] FROM [SecRole] WITH (NOLOCK) WHERE [SecRoleId] = @SecRoleId ",true, GxErrorMask.GX_NOMASK, false, this,prmT00068,1,0,true,false )
           ,new CursorDef("T00069", "SELECT [SecUserId], [SecRoleId] FROM [SecUserRole] WITH (NOLOCK) WHERE [SecUserId] = @SecUserId AND [SecRoleId] = @SecRoleId  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT00069,1,0,true,false )
           ,new CursorDef("T000610", "SELECT TOP 1 [SecUserId], [SecRoleId] FROM [SecUserRole] WITH (NOLOCK) WHERE ( [SecUserId] > @SecUserId or [SecUserId] = @SecUserId and [SecRoleId] > @SecRoleId) ORDER BY [SecUserId], [SecRoleId]  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000610,1,0,true,true )
           ,new CursorDef("T000611", "SELECT TOP 1 [SecUserId], [SecRoleId] FROM [SecUserRole] WITH (NOLOCK) WHERE ( [SecUserId] < @SecUserId or [SecUserId] = @SecUserId and [SecRoleId] < @SecRoleId) ORDER BY [SecUserId] DESC, [SecRoleId] DESC  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000611,1,0,true,true )
           ,new CursorDef("T000612", "INSERT INTO [SecUserRole]([SecUserId], [SecRoleId]) VALUES(@SecUserId, @SecRoleId)", GxErrorMask.GX_NOMASK,prmT000612)
           ,new CursorDef("T000613", "DELETE FROM [SecUserRole]  WHERE [SecUserId] = @SecUserId AND [SecRoleId] = @SecRoleId", GxErrorMask.GX_NOMASK,prmT000613)
           ,new CursorDef("T000614", "SELECT [SecUserName] FROM [SecUser] WITH (NOLOCK) WHERE [SecUserId] = @SecUserId ",true, GxErrorMask.GX_NOMASK, false, this,prmT000614,1,0,true,false )
           ,new CursorDef("T000615", "SELECT [SecRoleName], [SecRoleDescription] FROM [SecRole] WITH (NOLOCK) WHERE [SecRoleId] = @SecRoleId ",true, GxErrorMask.GX_NOMASK, false, this,prmT000615,1,0,true,false )
           ,new CursorDef("T000616", "SELECT [SecUserId], [SecRoleId] FROM [SecUserRole] WITH (NOLOCK) ORDER BY [SecUserId], [SecRoleId]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT000616,100,0,true,false )
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
              ((short[]) buf[1])[0] = rslt.getShort(2) ;
              return;
           case 1 :
              ((short[]) buf[0])[0] = rslt.getShort(1) ;
              ((short[]) buf[1])[0] = rslt.getShort(2) ;
              return;
           case 2 :
              ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
              return;
           case 3 :
              ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
              ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
              return;
           case 4 :
              ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
              ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
              ((String[]) buf[2])[0] = rslt.getVarchar(3) ;
              ((short[]) buf[3])[0] = rslt.getShort(4) ;
              ((short[]) buf[4])[0] = rslt.getShort(5) ;
              return;
           case 5 :
              ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
              return;
           case 6 :
              ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
              ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
              return;
           case 7 :
              ((short[]) buf[0])[0] = rslt.getShort(1) ;
              ((short[]) buf[1])[0] = rslt.getShort(2) ;
              return;
           case 8 :
              ((short[]) buf[0])[0] = rslt.getShort(1) ;
              ((short[]) buf[1])[0] = rslt.getShort(2) ;
              return;
           case 9 :
              ((short[]) buf[0])[0] = rslt.getShort(1) ;
              ((short[]) buf[1])[0] = rslt.getShort(2) ;
              return;
           case 12 :
              ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
              return;
           case 13 :
              ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
              ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
              return;
           case 14 :
              ((short[]) buf[0])[0] = rslt.getShort(1) ;
              ((short[]) buf[1])[0] = rslt.getShort(2) ;
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
              stmt.SetParameter(2, (short)parms[1]);
              return;
           case 1 :
              stmt.SetParameter(1, (short)parms[0]);
              stmt.SetParameter(2, (short)parms[1]);
              return;
           case 2 :
              stmt.SetParameter(1, (short)parms[0]);
              return;
           case 3 :
              stmt.SetParameter(1, (short)parms[0]);
              return;
           case 4 :
              stmt.SetParameter(1, (short)parms[0]);
              stmt.SetParameter(2, (short)parms[1]);
              return;
           case 5 :
              stmt.SetParameter(1, (short)parms[0]);
              return;
           case 6 :
              stmt.SetParameter(1, (short)parms[0]);
              return;
           case 7 :
              stmt.SetParameter(1, (short)parms[0]);
              stmt.SetParameter(2, (short)parms[1]);
              return;
           case 8 :
              stmt.SetParameter(1, (short)parms[0]);
              stmt.SetParameter(2, (short)parms[1]);
              return;
           case 9 :
              stmt.SetParameter(1, (short)parms[0]);
              stmt.SetParameter(2, (short)parms[1]);
              return;
           case 10 :
              stmt.SetParameter(1, (short)parms[0]);
              stmt.SetParameter(2, (short)parms[1]);
              return;
           case 11 :
              stmt.SetParameter(1, (short)parms[0]);
              stmt.SetParameter(2, (short)parms[1]);
              return;
           case 12 :
              stmt.SetParameter(1, (short)parms[0]);
              return;
           case 13 :
              stmt.SetParameter(1, (short)parms[0]);
              return;
     }
  }

}

}
