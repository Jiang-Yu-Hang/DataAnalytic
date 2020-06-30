/*
               File: SYS_Permission
        Description: SYS_Permission
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/27/2020 9:38:51.75
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
   public class sys_permission : GXDataArea, System.Web.SessionState.IRequiresSessionState
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
            Form.Meta.addItem("description", "SYS_Permission", 0) ;
         }
         context.wjLoc = "";
         context.nUserReturn = 0;
         context.wbHandled = 0;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         GX_FocusControl = edtPermissionCode_Internalname;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         wbErr = false;
         context.SetDefaultTheme("WorkWithPlusTheme");
         if ( ! context.IsLocalStorageSupported( ) )
         {
            context.PushCurrentUrl();
         }
      }

      public sys_permission( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public sys_permission( IGxContext context )
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
            GxWebStd.gx_label_ctrl( context, lblTitle_Internalname, "SYS_Permission", "", "", lblTitle_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Title", 0, "", 1, 1, 0, "HLP_SYS_Permission.htm");
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
            GxWebStd.gx_button_ctrl( context, bttBtn_first_Internalname, "", "|<", bttBtn_first_Jsonclick, 5, "|<", "", StyleString, ClassString, bttBtn_first_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"EFIRST."+"'", TempTags, "", context.GetButtonType( ), "HLP_SYS_Permission.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 14,'',false,'',0)\"";
            ClassString = "BtnPrevious";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_previous_Internalname, "", "<", bttBtn_previous_Jsonclick, 5, "<", "", StyleString, ClassString, bttBtn_previous_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"EPREVIOUS."+"'", TempTags, "", context.GetButtonType( ), "HLP_SYS_Permission.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 16,'',false,'',0)\"";
            ClassString = "BtnNext";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_next_Internalname, "", ">", bttBtn_next_Jsonclick, 5, ">", "", StyleString, ClassString, bttBtn_next_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ENEXT."+"'", TempTags, "", context.GetButtonType( ), "HLP_SYS_Permission.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 18,'',false,'',0)\"";
            ClassString = "BtnLast";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_last_Internalname, "", ">|", bttBtn_last_Jsonclick, 5, ">|", "", StyleString, ClassString, bttBtn_last_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ELAST."+"'", TempTags, "", context.GetButtonType( ), "HLP_SYS_Permission.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 20,'',false,'',0)\"";
            ClassString = "BtnSelect";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_select_Internalname, "", "选择", bttBtn_select_Jsonclick, 5, "选择", "", StyleString, ClassString, bttBtn_select_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ESELECT."+"'", TempTags, "", 2, "HLP_SYS_Permission.htm");
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
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtPermissionCode_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtPermissionCode_Internalname, "Permission Code", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 28,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtPermissionCode_Internalname, A362PermissionCode, StringUtil.RTrim( context.localUtil.Format( A362PermissionCode, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,28);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtPermissionCode_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtPermissionCode_Enabled, 0, "text", "", 64, "chr", 1, "row", 64, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_SYS_Permission.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtPermissionName_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtPermissionName_Internalname, "Permission Name", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 33,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtPermissionName_Internalname, A403PermissionName, StringUtil.RTrim( context.localUtil.Format( A403PermissionName, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,33);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtPermissionName_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtPermissionName_Enabled, 0, "text", "", 64, "chr", 1, "row", 64, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_SYS_Permission.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtOrderIndex_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtOrderIndex_Internalname, "Order Index", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 38,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtOrderIndex_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A404OrderIndex), 9, 0, ".", "")), ((edtOrderIndex_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A404OrderIndex), "ZZZZZZZZ9")) : context.localUtil.Format( (decimal)(A404OrderIndex), "ZZZZZZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,38);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtOrderIndex_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtOrderIndex_Enabled, 0, "number", "1", 9, "chr", 1, "row", 9, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_SYS_Permission.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtSYS_PermissionDescription_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtSYS_PermissionDescription_Internalname, "Description", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 43,'',false,'',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtSYS_PermissionDescription_Internalname, A405SYS_PermissionDescription, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,43);\"", 0, 1, edtSYS_PermissionDescription_Enabled, 0, 80, "chr", 10, "row", StyleString, ClassString, "", "", "2048", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_SYS_Permission.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtSYS_PermissionModuleCode_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtSYS_PermissionModuleCode_Internalname, "Module Code", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 48,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtSYS_PermissionModuleCode_Internalname, A406SYS_PermissionModuleCode, StringUtil.RTrim( context.localUtil.Format( A406SYS_PermissionModuleCode, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,48);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtSYS_PermissionModuleCode_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtSYS_PermissionModuleCode_Enabled, 0, "text", "", 32, "chr", 1, "row", 32, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_SYS_Permission.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtSYS_PermissionIsDeleted_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtSYS_PermissionIsDeleted_Internalname, "Is Deleted", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 53,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtSYS_PermissionIsDeleted_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A407SYS_PermissionIsDeleted), 1, 0, ".", "")), ((edtSYS_PermissionIsDeleted_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A407SYS_PermissionIsDeleted), "9")) : context.localUtil.Format( (decimal)(A407SYS_PermissionIsDeleted), "9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,53);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtSYS_PermissionIsDeleted_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtSYS_PermissionIsDeleted_Enabled, 0, "number", "1", 1, "chr", 1, "row", 1, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_SYS_Permission.htm");
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
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 58,'',false,'',0)\"";
            ClassString = "BtnEnter";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_enter_Internalname, "", "确认", bttBtn_enter_Jsonclick, 5, "确认", "", StyleString, ClassString, bttBtn_enter_Visible, bttBtn_enter_Enabled, "standard", "'"+""+"'"+",false,"+"'"+"EENTER."+"'", TempTags, "", context.GetButtonType( ), "HLP_SYS_Permission.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 60,'',false,'',0)\"";
            ClassString = "BtnCancel";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_cancel_Internalname, "", "取消", bttBtn_cancel_Jsonclick, 1, "取消", "", StyleString, ClassString, bttBtn_cancel_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ECANCEL."+"'", TempTags, "", context.GetButtonType( ), "HLP_SYS_Permission.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 62,'',false,'',0)\"";
            ClassString = "BtnDelete";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_delete_Internalname, "", "删除", bttBtn_delete_Jsonclick, 5, "删除", "", StyleString, ClassString, bttBtn_delete_Visible, bttBtn_delete_Enabled, "standard", "'"+""+"'"+",false,"+"'"+"EDELETE."+"'", TempTags, "", context.GetButtonType( ), "HLP_SYS_Permission.htm");
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
               A362PermissionCode = cgiGet( edtPermissionCode_Internalname);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A362PermissionCode", A362PermissionCode);
               A403PermissionName = cgiGet( edtPermissionName_Internalname);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A403PermissionName", A403PermissionName);
               if ( ( ( context.localUtil.CToN( cgiGet( edtOrderIndex_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtOrderIndex_Internalname), ".", ",") > Convert.ToDecimal( 999999999 )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "ORDERINDEX");
                  AnyError = 1;
                  GX_FocusControl = edtOrderIndex_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A404OrderIndex = 0;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A404OrderIndex", StringUtil.LTrim( StringUtil.Str( (decimal)(A404OrderIndex), 9, 0)));
               }
               else
               {
                  A404OrderIndex = (int)(context.localUtil.CToN( cgiGet( edtOrderIndex_Internalname), ".", ","));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A404OrderIndex", StringUtil.LTrim( StringUtil.Str( (decimal)(A404OrderIndex), 9, 0)));
               }
               A405SYS_PermissionDescription = cgiGet( edtSYS_PermissionDescription_Internalname);
               n405SYS_PermissionDescription = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A405SYS_PermissionDescription", A405SYS_PermissionDescription);
               n405SYS_PermissionDescription = (String.IsNullOrEmpty(StringUtil.RTrim( A405SYS_PermissionDescription)) ? true : false);
               A406SYS_PermissionModuleCode = cgiGet( edtSYS_PermissionModuleCode_Internalname);
               n406SYS_PermissionModuleCode = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A406SYS_PermissionModuleCode", A406SYS_PermissionModuleCode);
               n406SYS_PermissionModuleCode = (String.IsNullOrEmpty(StringUtil.RTrim( A406SYS_PermissionModuleCode)) ? true : false);
               if ( ( ( context.localUtil.CToN( cgiGet( edtSYS_PermissionIsDeleted_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtSYS_PermissionIsDeleted_Internalname), ".", ",") > Convert.ToDecimal( 9 )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "SYS_PERMISSIONISDELETED");
                  AnyError = 1;
                  GX_FocusControl = edtSYS_PermissionIsDeleted_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A407SYS_PermissionIsDeleted = 0;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A407SYS_PermissionIsDeleted", StringUtil.Str( (decimal)(A407SYS_PermissionIsDeleted), 1, 0));
               }
               else
               {
                  A407SYS_PermissionIsDeleted = (short)(context.localUtil.CToN( cgiGet( edtSYS_PermissionIsDeleted_Internalname), ".", ","));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A407SYS_PermissionIsDeleted", StringUtil.Str( (decimal)(A407SYS_PermissionIsDeleted), 1, 0));
               }
               /* Read saved values. */
               Z362PermissionCode = cgiGet( "Z362PermissionCode");
               Z403PermissionName = cgiGet( "Z403PermissionName");
               Z404OrderIndex = (int)(context.localUtil.CToN( cgiGet( "Z404OrderIndex"), ".", ","));
               Z406SYS_PermissionModuleCode = cgiGet( "Z406SYS_PermissionModuleCode");
               n406SYS_PermissionModuleCode = (String.IsNullOrEmpty(StringUtil.RTrim( A406SYS_PermissionModuleCode)) ? true : false);
               Z407SYS_PermissionIsDeleted = (short)(context.localUtil.CToN( cgiGet( "Z407SYS_PermissionIsDeleted"), ".", ","));
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
                  A362PermissionCode = GetNextPar( );
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A362PermissionCode", A362PermissionCode);
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
               InitAll1946( ) ;
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
         DisableAttributes1946( ) ;
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

      protected void ResetCaption190( )
      {
      }

      protected void ZM1946( short GX_JID )
      {
         if ( ( GX_JID == 1 ) || ( GX_JID == 0 ) )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
            {
               Z403PermissionName = T00193_A403PermissionName[0];
               Z404OrderIndex = T00193_A404OrderIndex[0];
               Z406SYS_PermissionModuleCode = T00193_A406SYS_PermissionModuleCode[0];
               Z407SYS_PermissionIsDeleted = T00193_A407SYS_PermissionIsDeleted[0];
            }
            else
            {
               Z403PermissionName = A403PermissionName;
               Z404OrderIndex = A404OrderIndex;
               Z406SYS_PermissionModuleCode = A406SYS_PermissionModuleCode;
               Z407SYS_PermissionIsDeleted = A407SYS_PermissionIsDeleted;
            }
         }
         if ( GX_JID == -1 )
         {
            Z362PermissionCode = A362PermissionCode;
            Z403PermissionName = A403PermissionName;
            Z404OrderIndex = A404OrderIndex;
            Z405SYS_PermissionDescription = A405SYS_PermissionDescription;
            Z406SYS_PermissionModuleCode = A406SYS_PermissionModuleCode;
            Z407SYS_PermissionIsDeleted = A407SYS_PermissionIsDeleted;
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

      protected void Load1946( )
      {
         /* Using cursor T00194 */
         pr_datastore1.execute(2, new Object[] {A362PermissionCode});
         if ( (pr_datastore1.getStatus(2) != 101) )
         {
            RcdFound46 = 1;
            A403PermissionName = T00194_A403PermissionName[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A403PermissionName", A403PermissionName);
            A404OrderIndex = T00194_A404OrderIndex[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A404OrderIndex", StringUtil.LTrim( StringUtil.Str( (decimal)(A404OrderIndex), 9, 0)));
            A405SYS_PermissionDescription = T00194_A405SYS_PermissionDescription[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A405SYS_PermissionDescription", A405SYS_PermissionDescription);
            n405SYS_PermissionDescription = T00194_n405SYS_PermissionDescription[0];
            A406SYS_PermissionModuleCode = T00194_A406SYS_PermissionModuleCode[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A406SYS_PermissionModuleCode", A406SYS_PermissionModuleCode);
            n406SYS_PermissionModuleCode = T00194_n406SYS_PermissionModuleCode[0];
            A407SYS_PermissionIsDeleted = T00194_A407SYS_PermissionIsDeleted[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A407SYS_PermissionIsDeleted", StringUtil.Str( (decimal)(A407SYS_PermissionIsDeleted), 1, 0));
            ZM1946( -1) ;
         }
         pr_datastore1.close(2);
         OnLoadActions1946( ) ;
      }

      protected void OnLoadActions1946( )
      {
      }

      protected void CheckExtendedTable1946( )
      {
         Gx_BScreen = 1;
         standaloneModal( ) ;
      }

      protected void CloseExtendedTableCursors1946( )
      {
      }

      protected void enableDisable( )
      {
      }

      protected void GetKey1946( )
      {
         /* Using cursor T00195 */
         pr_datastore1.execute(3, new Object[] {A362PermissionCode});
         if ( (pr_datastore1.getStatus(3) != 101) )
         {
            RcdFound46 = 1;
         }
         else
         {
            RcdFound46 = 0;
         }
         pr_datastore1.close(3);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor T00193 */
         pr_datastore1.execute(1, new Object[] {A362PermissionCode});
         if ( (pr_datastore1.getStatus(1) != 101) )
         {
            ZM1946( 1) ;
            RcdFound46 = 1;
            A362PermissionCode = T00193_A362PermissionCode[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A362PermissionCode", A362PermissionCode);
            A403PermissionName = T00193_A403PermissionName[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A403PermissionName", A403PermissionName);
            A404OrderIndex = T00193_A404OrderIndex[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A404OrderIndex", StringUtil.LTrim( StringUtil.Str( (decimal)(A404OrderIndex), 9, 0)));
            A405SYS_PermissionDescription = T00193_A405SYS_PermissionDescription[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A405SYS_PermissionDescription", A405SYS_PermissionDescription);
            n405SYS_PermissionDescription = T00193_n405SYS_PermissionDescription[0];
            A406SYS_PermissionModuleCode = T00193_A406SYS_PermissionModuleCode[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A406SYS_PermissionModuleCode", A406SYS_PermissionModuleCode);
            n406SYS_PermissionModuleCode = T00193_n406SYS_PermissionModuleCode[0];
            A407SYS_PermissionIsDeleted = T00193_A407SYS_PermissionIsDeleted[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A407SYS_PermissionIsDeleted", StringUtil.Str( (decimal)(A407SYS_PermissionIsDeleted), 1, 0));
            Z362PermissionCode = A362PermissionCode;
            sMode46 = Gx_mode;
            Gx_mode = "DSP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            standaloneModal( ) ;
            Load1946( ) ;
            if ( AnyError == 1 )
            {
               RcdFound46 = 0;
               InitializeNonKey1946( ) ;
            }
            Gx_mode = sMode46;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         else
         {
            RcdFound46 = 0;
            InitializeNonKey1946( ) ;
            sMode46 = Gx_mode;
            Gx_mode = "DSP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            standaloneModal( ) ;
            Gx_mode = sMode46;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         pr_datastore1.close(1);
      }

      protected void getEqualNoModal( )
      {
         GetKey1946( ) ;
         if ( RcdFound46 == 0 )
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
         RcdFound46 = 0;
         /* Using cursor T00196 */
         pr_datastore1.execute(4, new Object[] {A362PermissionCode});
         if ( (pr_datastore1.getStatus(4) != 101) )
         {
            while ( (pr_datastore1.getStatus(4) != 101) && ( ( StringUtil.StrCmp(T00196_A362PermissionCode[0], A362PermissionCode) < 0 ) ) )
            {
               pr_datastore1.readNext(4);
            }
            if ( (pr_datastore1.getStatus(4) != 101) && ( ( StringUtil.StrCmp(T00196_A362PermissionCode[0], A362PermissionCode) > 0 ) ) )
            {
               A362PermissionCode = T00196_A362PermissionCode[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A362PermissionCode", A362PermissionCode);
               RcdFound46 = 1;
            }
         }
         pr_datastore1.close(4);
      }

      protected void move_previous( )
      {
         RcdFound46 = 0;
         /* Using cursor T00197 */
         pr_datastore1.execute(5, new Object[] {A362PermissionCode});
         if ( (pr_datastore1.getStatus(5) != 101) )
         {
            while ( (pr_datastore1.getStatus(5) != 101) && ( ( StringUtil.StrCmp(T00197_A362PermissionCode[0], A362PermissionCode) > 0 ) ) )
            {
               pr_datastore1.readNext(5);
            }
            if ( (pr_datastore1.getStatus(5) != 101) && ( ( StringUtil.StrCmp(T00197_A362PermissionCode[0], A362PermissionCode) < 0 ) ) )
            {
               A362PermissionCode = T00197_A362PermissionCode[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A362PermissionCode", A362PermissionCode);
               RcdFound46 = 1;
            }
         }
         pr_datastore1.close(5);
      }

      protected void btn_enter( )
      {
         nKeyPressed = 1;
         GetKey1946( ) ;
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            /* Insert record */
            GX_FocusControl = edtPermissionCode_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            Insert1946( ) ;
            if ( AnyError == 1 )
            {
               GX_FocusControl = "";
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
         }
         else
         {
            if ( RcdFound46 == 1 )
            {
               if ( StringUtil.StrCmp(A362PermissionCode, Z362PermissionCode) != 0 )
               {
                  A362PermissionCode = Z362PermissionCode;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A362PermissionCode", A362PermissionCode);
                  GX_msglist.addItem(context.GetMessage( "GXM_getbeforeupd", ""), "CandidateKeyNotFound", 1, "PERMISSIONCODE");
                  AnyError = 1;
                  GX_FocusControl = edtPermissionCode_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
               else if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
               {
                  delete( ) ;
                  AfterTrn( ) ;
                  GX_FocusControl = edtPermissionCode_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
               else
               {
                  Gx_mode = "UPD";
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                  /* Update record */
                  Update1946( ) ;
                  GX_FocusControl = edtPermissionCode_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
            }
            else
            {
               if ( StringUtil.StrCmp(A362PermissionCode, Z362PermissionCode) != 0 )
               {
                  Gx_mode = "INS";
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                  /* Insert record */
                  GX_FocusControl = edtPermissionCode_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  Insert1946( ) ;
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
                     GX_msglist.addItem(context.GetMessage( "GXM_recdeleted", ""), 1, "PERMISSIONCODE");
                     AnyError = 1;
                     GX_FocusControl = edtPermissionCode_Internalname;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  }
                  else
                  {
                     Gx_mode = "INS";
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                     /* Insert record */
                     GX_FocusControl = edtPermissionCode_Internalname;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                     Insert1946( ) ;
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
         if ( StringUtil.StrCmp(A362PermissionCode, Z362PermissionCode) != 0 )
         {
            A362PermissionCode = Z362PermissionCode;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A362PermissionCode", A362PermissionCode);
            GX_msglist.addItem(context.GetMessage( "GXM_getbeforedlt", ""), 1, "PERMISSIONCODE");
            AnyError = 1;
            GX_FocusControl = edtPermissionCode_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         else
         {
            delete( ) ;
            AfterTrn( ) ;
            GX_FocusControl = edtPermissionCode_Internalname;
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
         if ( RcdFound46 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_keynfound", ""), "PrimaryKeyNotFound", 1, "PERMISSIONCODE");
            AnyError = 1;
            GX_FocusControl = edtPermissionCode_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         GX_FocusControl = edtPermissionName_Internalname;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_first( )
      {
         nKeyPressed = 2;
         IsConfirmed = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "IsConfirmed", StringUtil.LTrim( StringUtil.Str( (decimal)(IsConfirmed), 4, 0)));
         ScanStart1946( ) ;
         if ( RcdFound46 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "", true);
         }
         else
         {
            Gx_mode = "UPD";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtPermissionName_Internalname;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         ScanEnd1946( ) ;
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
         if ( RcdFound46 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "", true);
         }
         else
         {
            Gx_mode = "UPD";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtPermissionName_Internalname;
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
         if ( RcdFound46 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "", true);
         }
         else
         {
            Gx_mode = "UPD";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtPermissionName_Internalname;
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
         ScanStart1946( ) ;
         if ( RcdFound46 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "", true);
         }
         else
         {
            while ( RcdFound46 != 0 )
            {
               ScanNext1946( ) ;
            }
            Gx_mode = "UPD";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtPermissionName_Internalname;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         ScanEnd1946( ) ;
         getByPrimaryKey( ) ;
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_select( )
      {
         getEqualNoModal( ) ;
      }

      protected void CheckOptimisticConcurrency1946( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor T00192 */
            pr_datastore1.execute(0, new Object[] {A362PermissionCode});
            if ( (pr_datastore1.getStatus(0) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"SYS_PERMISSION"}), "RecordIsLocked", 1, "");
               AnyError = 1;
               return  ;
            }
            if ( (pr_datastore1.getStatus(0) == 101) || ( StringUtil.StrCmp(Z403PermissionName, T00192_A403PermissionName[0]) != 0 ) || ( Z404OrderIndex != T00192_A404OrderIndex[0] ) || ( StringUtil.StrCmp(Z406SYS_PermissionModuleCode, T00192_A406SYS_PermissionModuleCode[0]) != 0 ) || ( Z407SYS_PermissionIsDeleted != T00192_A407SYS_PermissionIsDeleted[0] ) )
            {
               if ( StringUtil.StrCmp(Z403PermissionName, T00192_A403PermissionName[0]) != 0 )
               {
                  GXUtil.WriteLog("sys_permission:[seudo value changed for attri]"+"PermissionName");
                  GXUtil.WriteLogRaw("Old: ",Z403PermissionName);
                  GXUtil.WriteLogRaw("Current: ",T00192_A403PermissionName[0]);
               }
               if ( Z404OrderIndex != T00192_A404OrderIndex[0] )
               {
                  GXUtil.WriteLog("sys_permission:[seudo value changed for attri]"+"OrderIndex");
                  GXUtil.WriteLogRaw("Old: ",Z404OrderIndex);
                  GXUtil.WriteLogRaw("Current: ",T00192_A404OrderIndex[0]);
               }
               if ( StringUtil.StrCmp(Z406SYS_PermissionModuleCode, T00192_A406SYS_PermissionModuleCode[0]) != 0 )
               {
                  GXUtil.WriteLog("sys_permission:[seudo value changed for attri]"+"SYS_PermissionModuleCode");
                  GXUtil.WriteLogRaw("Old: ",Z406SYS_PermissionModuleCode);
                  GXUtil.WriteLogRaw("Current: ",T00192_A406SYS_PermissionModuleCode[0]);
               }
               if ( Z407SYS_PermissionIsDeleted != T00192_A407SYS_PermissionIsDeleted[0] )
               {
                  GXUtil.WriteLog("sys_permission:[seudo value changed for attri]"+"SYS_PermissionIsDeleted");
                  GXUtil.WriteLogRaw("Old: ",Z407SYS_PermissionIsDeleted);
                  GXUtil.WriteLogRaw("Current: ",T00192_A407SYS_PermissionIsDeleted[0]);
               }
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"SYS_PERMISSION"}), "RecordWasChanged", 1, "");
               AnyError = 1;
               return  ;
            }
         }
      }

      protected void Insert1946( )
      {
         BeforeValidate1946( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable1946( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM1946( 0) ;
            CheckOptimisticConcurrency1946( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm1946( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert1946( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T00198 */
                     pr_datastore1.execute(6, new Object[] {A362PermissionCode, A403PermissionName, A404OrderIndex, n405SYS_PermissionDescription, A405SYS_PermissionDescription, n406SYS_PermissionModuleCode, A406SYS_PermissionModuleCode, A407SYS_PermissionIsDeleted});
                     pr_datastore1.close(6);
                     dsDataStore1.SmartCacheProvider.SetUpdated("SYS_PERMISSION") ;
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
                           ResetCaption190( ) ;
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
               Load1946( ) ;
            }
            EndLevel1946( ) ;
         }
         CloseExtendedTableCursors1946( ) ;
      }

      protected void Update1946( )
      {
         BeforeValidate1946( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable1946( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency1946( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm1946( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate1946( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T00199 */
                     pr_datastore1.execute(7, new Object[] {A403PermissionName, A404OrderIndex, n405SYS_PermissionDescription, A405SYS_PermissionDescription, n406SYS_PermissionModuleCode, A406SYS_PermissionModuleCode, A407SYS_PermissionIsDeleted, A362PermissionCode});
                     pr_datastore1.close(7);
                     dsDataStore1.SmartCacheProvider.SetUpdated("SYS_PERMISSION") ;
                     if ( (pr_datastore1.getStatus(7) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"SYS_PERMISSION"}), "RecordIsLocked", 1, "");
                        AnyError = 1;
                     }
                     DeferredUpdate1946( ) ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( update) rules */
                        /* End of After( update) rules */
                        if ( AnyError == 0 )
                        {
                           getByPrimaryKey( ) ;
                           GX_msglist.addItem(context.GetMessage( "GXM_sucupdated", ""), "SuccessfullyUpdated", 0, "", true);
                           ResetCaption190( ) ;
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
            EndLevel1946( ) ;
         }
         CloseExtendedTableCursors1946( ) ;
      }

      protected void DeferredUpdate1946( )
      {
      }

      protected void delete( )
      {
         Gx_mode = "DLT";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         BeforeValidate1946( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency1946( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls1946( ) ;
            AfterConfirm1946( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete1946( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor T001910 */
                  pr_datastore1.execute(8, new Object[] {A362PermissionCode});
                  pr_datastore1.close(8);
                  dsDataStore1.SmartCacheProvider.SetUpdated("SYS_PERMISSION") ;
                  if ( AnyError == 0 )
                  {
                     /* Start of After( delete) rules */
                     /* End of After( delete) rules */
                     if ( AnyError == 0 )
                     {
                        move_next( ) ;
                        if ( RcdFound46 == 0 )
                        {
                           InitAll1946( ) ;
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
                        ResetCaption190( ) ;
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
         sMode46 = Gx_mode;
         Gx_mode = "DLT";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         EndLevel1946( ) ;
         Gx_mode = sMode46;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
      }

      protected void OnDeleteControls1946( )
      {
         standaloneModal( ) ;
         /* No delete mode formulas found. */
      }

      protected void EndLevel1946( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            pr_datastore1.close(0);
         }
         if ( AnyError == 0 )
         {
            BeforeComplete1946( ) ;
         }
         if ( AnyError == 0 )
         {
            pr_datastore1.close(1);
            context.CommitDataStores("sys_permission",pr_default);
            if ( AnyError == 0 )
            {
               ConfirmValues190( ) ;
            }
            /* After transaction rules */
            /* Execute 'After Trn' event if defined. */
            trnEnded = 1;
         }
         else
         {
            pr_datastore1.close(1);
            context.RollbackDataStores("sys_permission",pr_default);
         }
         IsModified = 0;
         if ( AnyError != 0 )
         {
            context.wjLoc = "";
            context.nUserReturn = 0;
         }
      }

      public void ScanStart1946( )
      {
         /* Using cursor T001911 */
         pr_datastore1.execute(9);
         RcdFound46 = 0;
         if ( (pr_datastore1.getStatus(9) != 101) )
         {
            RcdFound46 = 1;
            A362PermissionCode = T001911_A362PermissionCode[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A362PermissionCode", A362PermissionCode);
         }
         /* Load Subordinate Levels */
      }

      protected void ScanNext1946( )
      {
         /* Scan next routine */
         pr_datastore1.readNext(9);
         RcdFound46 = 0;
         if ( (pr_datastore1.getStatus(9) != 101) )
         {
            RcdFound46 = 1;
            A362PermissionCode = T001911_A362PermissionCode[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A362PermissionCode", A362PermissionCode);
         }
      }

      protected void ScanEnd1946( )
      {
         pr_datastore1.close(9);
      }

      protected void AfterConfirm1946( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert1946( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate1946( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete1946( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete1946( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate1946( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes1946( )
      {
         edtPermissionCode_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtPermissionCode_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtPermissionCode_Enabled), 5, 0)), true);
         edtPermissionName_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtPermissionName_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtPermissionName_Enabled), 5, 0)), true);
         edtOrderIndex_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtOrderIndex_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtOrderIndex_Enabled), 5, 0)), true);
         edtSYS_PermissionDescription_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtSYS_PermissionDescription_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtSYS_PermissionDescription_Enabled), 5, 0)), true);
         edtSYS_PermissionModuleCode_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtSYS_PermissionModuleCode_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtSYS_PermissionModuleCode_Enabled), 5, 0)), true);
         edtSYS_PermissionIsDeleted_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtSYS_PermissionIsDeleted_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtSYS_PermissionIsDeleted_Enabled), 5, 0)), true);
      }

      protected void send_integrity_lvl_hashes1946( )
      {
      }

      protected void assign_properties_default( )
      {
      }

      protected void ConfirmValues190( )
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
         context.AddJavascriptSource("gxcfg.js", "?20202279385264", false);
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" autocomplete=\"off\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("sys_permission.aspx") +"\">") ;
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
         GxWebStd.gx_hidden_field( context, "Z362PermissionCode", Z362PermissionCode);
         GxWebStd.gx_hidden_field( context, "Z403PermissionName", Z403PermissionName);
         GxWebStd.gx_hidden_field( context, "Z404OrderIndex", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z404OrderIndex), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "Z406SYS_PermissionModuleCode", Z406SYS_PermissionModuleCode);
         GxWebStd.gx_hidden_field( context, "Z407SYS_PermissionIsDeleted", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z407SYS_PermissionIsDeleted), 1, 0, ".", "")));
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
         return formatLink("sys_permission.aspx")  ;
      }

      public override String GetPgmname( )
      {
         return "SYS_Permission" ;
      }

      public override String GetPgmdesc( )
      {
         return "SYS_Permission" ;
      }

      protected void InitializeNonKey1946( )
      {
         A403PermissionName = "";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A403PermissionName", A403PermissionName);
         A404OrderIndex = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A404OrderIndex", StringUtil.LTrim( StringUtil.Str( (decimal)(A404OrderIndex), 9, 0)));
         A405SYS_PermissionDescription = "";
         n405SYS_PermissionDescription = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A405SYS_PermissionDescription", A405SYS_PermissionDescription);
         n405SYS_PermissionDescription = (String.IsNullOrEmpty(StringUtil.RTrim( A405SYS_PermissionDescription)) ? true : false);
         A406SYS_PermissionModuleCode = "";
         n406SYS_PermissionModuleCode = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A406SYS_PermissionModuleCode", A406SYS_PermissionModuleCode);
         n406SYS_PermissionModuleCode = (String.IsNullOrEmpty(StringUtil.RTrim( A406SYS_PermissionModuleCode)) ? true : false);
         A407SYS_PermissionIsDeleted = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A407SYS_PermissionIsDeleted", StringUtil.Str( (decimal)(A407SYS_PermissionIsDeleted), 1, 0));
         Z403PermissionName = "";
         Z404OrderIndex = 0;
         Z406SYS_PermissionModuleCode = "";
         Z407SYS_PermissionIsDeleted = 0;
      }

      protected void InitAll1946( )
      {
         A362PermissionCode = "";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A362PermissionCode", A362PermissionCode);
         InitializeNonKey1946( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?20202279385269", true);
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
         context.AddJavascriptSource("sys_permission.js", "?20202279385270", false);
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
         edtPermissionCode_Internalname = "PERMISSIONCODE";
         edtPermissionName_Internalname = "PERMISSIONNAME";
         edtOrderIndex_Internalname = "ORDERINDEX";
         edtSYS_PermissionDescription_Internalname = "SYS_PERMISSIONDESCRIPTION";
         edtSYS_PermissionModuleCode_Internalname = "SYS_PERMISSIONMODULECODE";
         edtSYS_PermissionIsDeleted_Internalname = "SYS_PERMISSIONISDELETED";
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
         Form.Caption = "SYS_Permission";
         bttBtn_delete_Enabled = 1;
         bttBtn_delete_Visible = 1;
         bttBtn_cancel_Visible = 1;
         bttBtn_enter_Enabled = 1;
         bttBtn_enter_Visible = 1;
         edtSYS_PermissionIsDeleted_Jsonclick = "";
         edtSYS_PermissionIsDeleted_Enabled = 1;
         edtSYS_PermissionModuleCode_Jsonclick = "";
         edtSYS_PermissionModuleCode_Enabled = 1;
         edtSYS_PermissionDescription_Enabled = 1;
         edtOrderIndex_Jsonclick = "";
         edtOrderIndex_Enabled = 1;
         edtPermissionName_Jsonclick = "";
         edtPermissionName_Enabled = 1;
         edtPermissionCode_Jsonclick = "";
         edtPermissionCode_Enabled = 1;
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
         GX_FocusControl = edtPermissionName_Internalname;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         standaloneNotModal( ) ;
         standaloneModal( ) ;
         /* End function AfterKeyLoadScreen */
      }

      public void Valid_Permissioncode( String GX_Parm1 ,
                                        String GX_Parm2 ,
                                        int GX_Parm3 ,
                                        String GX_Parm4 ,
                                        String GX_Parm5 ,
                                        short GX_Parm6 )
      {
         A362PermissionCode = GX_Parm1;
         A403PermissionName = GX_Parm2;
         A404OrderIndex = GX_Parm3;
         A405SYS_PermissionDescription = GX_Parm4;
         n405SYS_PermissionDescription = false;
         A406SYS_PermissionModuleCode = GX_Parm5;
         n406SYS_PermissionModuleCode = false;
         A407SYS_PermissionIsDeleted = GX_Parm6;
         context.wbHandled = 1;
         AfterKeyLoadScreen( ) ;
         Draw( ) ;
         send_integrity_footer_hashes( ) ;
         dynload_actions( ) ;
         if ( AnyError == 1 )
         {
         }
         isValidOutput.Add(A403PermissionName);
         isValidOutput.Add(StringUtil.LTrim( StringUtil.NToC( (decimal)(A404OrderIndex), 9, 0, ".", "")));
         isValidOutput.Add(A405SYS_PermissionDescription);
         isValidOutput.Add(A406SYS_PermissionModuleCode);
         isValidOutput.Add(StringUtil.LTrim( StringUtil.NToC( (decimal)(A407SYS_PermissionIsDeleted), 1, 0, ".", "")));
         isValidOutput.Add(StringUtil.RTrim( Gx_mode));
         isValidOutput.Add(Z362PermissionCode);
         isValidOutput.Add(Z403PermissionName);
         isValidOutput.Add(StringUtil.LTrim( StringUtil.NToC( (decimal)(Z404OrderIndex), 9, 0, ".", "")));
         isValidOutput.Add(Z405SYS_PermissionDescription);
         isValidOutput.Add(Z406SYS_PermissionModuleCode);
         isValidOutput.Add(StringUtil.LTrim( StringUtil.NToC( (decimal)(Z407SYS_PermissionIsDeleted), 1, 0, ".", "")));
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
         Z362PermissionCode = "";
         Z403PermissionName = "";
         Z406SYS_PermissionModuleCode = "";
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
         A362PermissionCode = "";
         A403PermissionName = "";
         A405SYS_PermissionDescription = "";
         A406SYS_PermissionModuleCode = "";
         bttBtn_enter_Jsonclick = "";
         bttBtn_cancel_Jsonclick = "";
         bttBtn_delete_Jsonclick = "";
         Gx_mode = "";
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         Z405SYS_PermissionDescription = "";
         T00194_A362PermissionCode = new String[] {""} ;
         T00194_A403PermissionName = new String[] {""} ;
         T00194_A404OrderIndex = new int[1] ;
         T00194_A405SYS_PermissionDescription = new String[] {""} ;
         T00194_n405SYS_PermissionDescription = new bool[] {false} ;
         T00194_A406SYS_PermissionModuleCode = new String[] {""} ;
         T00194_n406SYS_PermissionModuleCode = new bool[] {false} ;
         T00194_A407SYS_PermissionIsDeleted = new short[1] ;
         T00195_A362PermissionCode = new String[] {""} ;
         T00193_A362PermissionCode = new String[] {""} ;
         T00193_A403PermissionName = new String[] {""} ;
         T00193_A404OrderIndex = new int[1] ;
         T00193_A405SYS_PermissionDescription = new String[] {""} ;
         T00193_n405SYS_PermissionDescription = new bool[] {false} ;
         T00193_A406SYS_PermissionModuleCode = new String[] {""} ;
         T00193_n406SYS_PermissionModuleCode = new bool[] {false} ;
         T00193_A407SYS_PermissionIsDeleted = new short[1] ;
         sMode46 = "";
         T00196_A362PermissionCode = new String[] {""} ;
         T00197_A362PermissionCode = new String[] {""} ;
         T00192_A362PermissionCode = new String[] {""} ;
         T00192_A403PermissionName = new String[] {""} ;
         T00192_A404OrderIndex = new int[1] ;
         T00192_A405SYS_PermissionDescription = new String[] {""} ;
         T00192_n405SYS_PermissionDescription = new bool[] {false} ;
         T00192_A406SYS_PermissionModuleCode = new String[] {""} ;
         T00192_n406SYS_PermissionModuleCode = new bool[] {false} ;
         T00192_A407SYS_PermissionIsDeleted = new short[1] ;
         T001911_A362PermissionCode = new String[] {""} ;
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         isValidOutput = new GxUnknownObjectCollection();
         pr_datastore1 = new DataStoreProvider(context, new GeneXus.Programs.sys_permission__datastore1(),
            new Object[][] {
                new Object[] {
               T00192_A362PermissionCode, T00192_A403PermissionName, T00192_A404OrderIndex, T00192_A405SYS_PermissionDescription, T00192_n405SYS_PermissionDescription, T00192_A406SYS_PermissionModuleCode, T00192_n406SYS_PermissionModuleCode, T00192_A407SYS_PermissionIsDeleted
               }
               , new Object[] {
               T00193_A362PermissionCode, T00193_A403PermissionName, T00193_A404OrderIndex, T00193_A405SYS_PermissionDescription, T00193_n405SYS_PermissionDescription, T00193_A406SYS_PermissionModuleCode, T00193_n406SYS_PermissionModuleCode, T00193_A407SYS_PermissionIsDeleted
               }
               , new Object[] {
               T00194_A362PermissionCode, T00194_A403PermissionName, T00194_A404OrderIndex, T00194_A405SYS_PermissionDescription, T00194_n405SYS_PermissionDescription, T00194_A406SYS_PermissionModuleCode, T00194_n406SYS_PermissionModuleCode, T00194_A407SYS_PermissionIsDeleted
               }
               , new Object[] {
               T00195_A362PermissionCode
               }
               , new Object[] {
               T00196_A362PermissionCode
               }
               , new Object[] {
               T00197_A362PermissionCode
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               T001911_A362PermissionCode
               }
            }
         );
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.sys_permission__default(),
            new Object[][] {
            }
         );
      }

      private short Z407SYS_PermissionIsDeleted ;
      private short GxWebError ;
      private short gxcookieaux ;
      private short IsConfirmed ;
      private short IsModified ;
      private short AnyError ;
      private short nKeyPressed ;
      private short initialized ;
      private short A407SYS_PermissionIsDeleted ;
      private short GX_JID ;
      private short RcdFound46 ;
      private short Gx_BScreen ;
      private short gxajaxcallmode ;
      private short wbTemp ;
      private int Z404OrderIndex ;
      private int trnEnded ;
      private int bttBtn_first_Visible ;
      private int bttBtn_previous_Visible ;
      private int bttBtn_next_Visible ;
      private int bttBtn_last_Visible ;
      private int bttBtn_select_Visible ;
      private int edtPermissionCode_Enabled ;
      private int edtPermissionName_Enabled ;
      private int A404OrderIndex ;
      private int edtOrderIndex_Enabled ;
      private int edtSYS_PermissionDescription_Enabled ;
      private int edtSYS_PermissionModuleCode_Enabled ;
      private int edtSYS_PermissionIsDeleted_Enabled ;
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
      private String edtPermissionCode_Internalname ;
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
      private String edtPermissionCode_Jsonclick ;
      private String edtPermissionName_Internalname ;
      private String edtPermissionName_Jsonclick ;
      private String edtOrderIndex_Internalname ;
      private String edtOrderIndex_Jsonclick ;
      private String edtSYS_PermissionDescription_Internalname ;
      private String edtSYS_PermissionModuleCode_Internalname ;
      private String edtSYS_PermissionModuleCode_Jsonclick ;
      private String edtSYS_PermissionIsDeleted_Internalname ;
      private String edtSYS_PermissionIsDeleted_Jsonclick ;
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
      private String sMode46 ;
      private String sDynURL ;
      private String FormProcess ;
      private String bodyStyle ;
      private bool entryPointCalled ;
      private bool toggleJsOutput ;
      private bool wbErr ;
      private bool n405SYS_PermissionDescription ;
      private bool n406SYS_PermissionModuleCode ;
      private String A405SYS_PermissionDescription ;
      private String Z405SYS_PermissionDescription ;
      private String Z362PermissionCode ;
      private String Z403PermissionName ;
      private String Z406SYS_PermissionModuleCode ;
      private String A362PermissionCode ;
      private String A403PermissionName ;
      private String A406SYS_PermissionModuleCode ;
      private GxUnknownObjectCollection isValidOutput ;
      private IGxDataStore dsDataStore1 ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_datastore1 ;
      private String[] T00194_A362PermissionCode ;
      private String[] T00194_A403PermissionName ;
      private int[] T00194_A404OrderIndex ;
      private String[] T00194_A405SYS_PermissionDescription ;
      private bool[] T00194_n405SYS_PermissionDescription ;
      private String[] T00194_A406SYS_PermissionModuleCode ;
      private bool[] T00194_n406SYS_PermissionModuleCode ;
      private short[] T00194_A407SYS_PermissionIsDeleted ;
      private String[] T00195_A362PermissionCode ;
      private String[] T00193_A362PermissionCode ;
      private String[] T00193_A403PermissionName ;
      private int[] T00193_A404OrderIndex ;
      private String[] T00193_A405SYS_PermissionDescription ;
      private bool[] T00193_n405SYS_PermissionDescription ;
      private String[] T00193_A406SYS_PermissionModuleCode ;
      private bool[] T00193_n406SYS_PermissionModuleCode ;
      private short[] T00193_A407SYS_PermissionIsDeleted ;
      private String[] T00196_A362PermissionCode ;
      private String[] T00197_A362PermissionCode ;
      private String[] T00192_A362PermissionCode ;
      private String[] T00192_A403PermissionName ;
      private int[] T00192_A404OrderIndex ;
      private String[] T00192_A405SYS_PermissionDescription ;
      private bool[] T00192_n405SYS_PermissionDescription ;
      private String[] T00192_A406SYS_PermissionModuleCode ;
      private bool[] T00192_n406SYS_PermissionModuleCode ;
      private short[] T00192_A407SYS_PermissionIsDeleted ;
      private IDataStoreProvider pr_default ;
      private String[] T001911_A362PermissionCode ;
      private GXWebForm Form ;
   }

   public class sys_permission__datastore1 : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmT00194 ;
          prmT00194 = new Object[] {
          new Object[] {"@PermissionCode",SqlDbType.NVarChar,64,0}
          } ;
          Object[] prmT00195 ;
          prmT00195 = new Object[] {
          new Object[] {"@PermissionCode",SqlDbType.NVarChar,64,0}
          } ;
          Object[] prmT00193 ;
          prmT00193 = new Object[] {
          new Object[] {"@PermissionCode",SqlDbType.NVarChar,64,0}
          } ;
          Object[] prmT00196 ;
          prmT00196 = new Object[] {
          new Object[] {"@PermissionCode",SqlDbType.NVarChar,64,0}
          } ;
          Object[] prmT00197 ;
          prmT00197 = new Object[] {
          new Object[] {"@PermissionCode",SqlDbType.NVarChar,64,0}
          } ;
          Object[] prmT00192 ;
          prmT00192 = new Object[] {
          new Object[] {"@PermissionCode",SqlDbType.NVarChar,64,0}
          } ;
          Object[] prmT00198 ;
          prmT00198 = new Object[] {
          new Object[] {"@PermissionCode",SqlDbType.NVarChar,64,0} ,
          new Object[] {"@PermissionName",SqlDbType.NVarChar,64,0} ,
          new Object[] {"@OrderIndex",SqlDbType.Int,9,0} ,
          new Object[] {"@SYS_PermissionDescription",SqlDbType.NVarChar,2048,0} ,
          new Object[] {"@SYS_PermissionModuleCode",SqlDbType.NVarChar,32,0} ,
          new Object[] {"@SYS_PermissionIsDeleted",SqlDbType.SmallInt,1,0}
          } ;
          Object[] prmT00199 ;
          prmT00199 = new Object[] {
          new Object[] {"@PermissionName",SqlDbType.NVarChar,64,0} ,
          new Object[] {"@OrderIndex",SqlDbType.Int,9,0} ,
          new Object[] {"@SYS_PermissionDescription",SqlDbType.NVarChar,2048,0} ,
          new Object[] {"@SYS_PermissionModuleCode",SqlDbType.NVarChar,32,0} ,
          new Object[] {"@SYS_PermissionIsDeleted",SqlDbType.SmallInt,1,0} ,
          new Object[] {"@PermissionCode",SqlDbType.NVarChar,64,0}
          } ;
          Object[] prmT001910 ;
          prmT001910 = new Object[] {
          new Object[] {"@PermissionCode",SqlDbType.NVarChar,64,0}
          } ;
          Object[] prmT001911 ;
          prmT001911 = new Object[] {
          } ;
          def= new CursorDef[] {
              new CursorDef("T00192", "SELECT [PermissionCode], [PermissionName], [OrderIndex], [SYS_PermissionDescription], [SYS_PermissionModuleCode], [SYS_PermissionIsDeleted] FROM dbo.[SYS_Permission] WITH (UPDLOCK) WHERE [PermissionCode] = @PermissionCode ",true, GxErrorMask.GX_NOMASK, false, this,prmT00192,1,0,true,false )
             ,new CursorDef("T00193", "SELECT [PermissionCode], [PermissionName], [OrderIndex], [SYS_PermissionDescription], [SYS_PermissionModuleCode], [SYS_PermissionIsDeleted] FROM dbo.[SYS_Permission] WITH (NOLOCK) WHERE [PermissionCode] = @PermissionCode ",true, GxErrorMask.GX_NOMASK, false, this,prmT00193,1,0,true,false )
             ,new CursorDef("T00194", "SELECT TM1.[PermissionCode], TM1.[PermissionName], TM1.[OrderIndex], TM1.[SYS_PermissionDescription], TM1.[SYS_PermissionModuleCode], TM1.[SYS_PermissionIsDeleted] FROM dbo.[SYS_Permission] TM1 WITH (NOLOCK) WHERE TM1.[PermissionCode] = @PermissionCode ORDER BY TM1.[PermissionCode]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT00194,100,0,true,false )
             ,new CursorDef("T00195", "SELECT [PermissionCode] FROM dbo.[SYS_Permission] WITH (NOLOCK) WHERE [PermissionCode] = @PermissionCode  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT00195,1,0,true,false )
             ,new CursorDef("T00196", "SELECT TOP 1 [PermissionCode] FROM dbo.[SYS_Permission] WITH (NOLOCK) WHERE ( [PermissionCode] > @PermissionCode) ORDER BY [PermissionCode]  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT00196,1,0,true,true )
             ,new CursorDef("T00197", "SELECT TOP 1 [PermissionCode] FROM dbo.[SYS_Permission] WITH (NOLOCK) WHERE ( [PermissionCode] < @PermissionCode) ORDER BY [PermissionCode] DESC  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT00197,1,0,true,true )
             ,new CursorDef("T00198", "INSERT INTO dbo.[SYS_Permission]([PermissionCode], [PermissionName], [OrderIndex], [SYS_PermissionDescription], [SYS_PermissionModuleCode], [SYS_PermissionIsDeleted]) VALUES(@PermissionCode, @PermissionName, @OrderIndex, @SYS_PermissionDescription, @SYS_PermissionModuleCode, @SYS_PermissionIsDeleted)", GxErrorMask.GX_NOMASK,prmT00198)
             ,new CursorDef("T00199", "UPDATE dbo.[SYS_Permission] SET [PermissionName]=@PermissionName, [OrderIndex]=@OrderIndex, [SYS_PermissionDescription]=@SYS_PermissionDescription, [SYS_PermissionModuleCode]=@SYS_PermissionModuleCode, [SYS_PermissionIsDeleted]=@SYS_PermissionIsDeleted  WHERE [PermissionCode] = @PermissionCode", GxErrorMask.GX_NOMASK,prmT00199)
             ,new CursorDef("T001910", "DELETE FROM dbo.[SYS_Permission]  WHERE [PermissionCode] = @PermissionCode", GxErrorMask.GX_NOMASK,prmT001910)
             ,new CursorDef("T001911", "SELECT [PermissionCode] FROM dbo.[SYS_Permission] WITH (NOLOCK) ORDER BY [PermissionCode]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT001911,100,0,true,false )
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
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((int[]) buf[2])[0] = rslt.getInt(3) ;
                ((String[]) buf[3])[0] = rslt.getLongVarchar(4) ;
                ((bool[]) buf[4])[0] = rslt.wasNull(4);
                ((String[]) buf[5])[0] = rslt.getVarchar(5) ;
                ((bool[]) buf[6])[0] = rslt.wasNull(5);
                ((short[]) buf[7])[0] = rslt.getShort(6) ;
                return;
             case 1 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((int[]) buf[2])[0] = rslt.getInt(3) ;
                ((String[]) buf[3])[0] = rslt.getLongVarchar(4) ;
                ((bool[]) buf[4])[0] = rslt.wasNull(4);
                ((String[]) buf[5])[0] = rslt.getVarchar(5) ;
                ((bool[]) buf[6])[0] = rslt.wasNull(5);
                ((short[]) buf[7])[0] = rslt.getShort(6) ;
                return;
             case 2 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((int[]) buf[2])[0] = rslt.getInt(3) ;
                ((String[]) buf[3])[0] = rslt.getLongVarchar(4) ;
                ((bool[]) buf[4])[0] = rslt.wasNull(4);
                ((String[]) buf[5])[0] = rslt.getVarchar(5) ;
                ((bool[]) buf[6])[0] = rslt.wasNull(5);
                ((short[]) buf[7])[0] = rslt.getShort(6) ;
                return;
             case 3 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                return;
             case 4 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                return;
             case 5 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                return;
             case 9 :
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
                stmt.SetParameter(1, (String)parms[0]);
                return;
             case 1 :
                stmt.SetParameter(1, (String)parms[0]);
                return;
             case 2 :
                stmt.SetParameter(1, (String)parms[0]);
                return;
             case 3 :
                stmt.SetParameter(1, (String)parms[0]);
                return;
             case 4 :
                stmt.SetParameter(1, (String)parms[0]);
                return;
             case 5 :
                stmt.SetParameter(1, (String)parms[0]);
                return;
             case 6 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                stmt.SetParameter(3, (int)parms[2]);
                if ( (bool)parms[3] )
                {
                   stmt.setNull( 4 , SqlDbType.NVarChar );
                }
                else
                {
                   stmt.SetParameter(4, (String)parms[4]);
                }
                if ( (bool)parms[5] )
                {
                   stmt.setNull( 5 , SqlDbType.NVarChar );
                }
                else
                {
                   stmt.SetParameter(5, (String)parms[6]);
                }
                stmt.SetParameter(6, (short)parms[7]);
                return;
             case 7 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (int)parms[1]);
                if ( (bool)parms[2] )
                {
                   stmt.setNull( 3 , SqlDbType.NVarChar );
                }
                else
                {
                   stmt.SetParameter(3, (String)parms[3]);
                }
                if ( (bool)parms[4] )
                {
                   stmt.setNull( 4 , SqlDbType.NVarChar );
                }
                else
                {
                   stmt.SetParameter(4, (String)parms[5]);
                }
                stmt.SetParameter(5, (short)parms[6]);
                stmt.SetParameter(6, (String)parms[7]);
                return;
             case 8 :
                stmt.SetParameter(1, (String)parms[0]);
                return;
       }
    }

    public String getDataStoreName( )
    {
       return "DATASTORE1";
    }

 }

 public class sys_permission__default : DataStoreHelperBase, IDataStoreHelper
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
