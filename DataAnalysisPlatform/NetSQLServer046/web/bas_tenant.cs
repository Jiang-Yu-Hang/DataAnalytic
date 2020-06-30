/*
               File: BAS_Tenant
        Description: BAS_Tenant
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/27/2020 11:58:12.16
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
   public class bas_tenant : GXDataArea, System.Web.SessionState.IRequiresSessionState
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
            A358InstituteCode = GetNextPar( );
            n358InstituteCode = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A358InstituteCode", A358InstituteCode);
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            gxLoad_4( A358InstituteCode) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxExecAct_"+"gxLoad_5") == 0 )
         {
            A365DatabaseID = (int)(NumberUtil.Val( GetNextPar( ), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A365DatabaseID", StringUtil.LTrim( StringUtil.Str( (decimal)(A365DatabaseID), 9, 0)));
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            gxLoad_5( A365DatabaseID) ;
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
            Form.Meta.addItem("description", "BAS_Tenant", 0) ;
         }
         context.wjLoc = "";
         context.nUserReturn = 0;
         context.wbHandled = 0;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         GX_FocusControl = edtBAS_TenantTenantCode_Internalname;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         wbErr = false;
         context.SetDefaultTheme("WorkWithPlusTheme");
         if ( ! context.IsLocalStorageSupported( ) )
         {
            context.PushCurrentUrl();
         }
      }

      public bas_tenant( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public bas_tenant( IGxContext context )
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
            GxWebStd.gx_label_ctrl( context, lblTitle_Internalname, "BAS_Tenant", "", "", lblTitle_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Title", 0, "", 1, 1, 0, "HLP_BAS_Tenant.htm");
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
            GxWebStd.gx_button_ctrl( context, bttBtn_first_Internalname, "", "|<", bttBtn_first_Jsonclick, 5, "|<", "", StyleString, ClassString, bttBtn_first_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"EFIRST."+"'", TempTags, "", context.GetButtonType( ), "HLP_BAS_Tenant.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 14,'',false,'',0)\"";
            ClassString = "BtnPrevious";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_previous_Internalname, "", "<", bttBtn_previous_Jsonclick, 5, "<", "", StyleString, ClassString, bttBtn_previous_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"EPREVIOUS."+"'", TempTags, "", context.GetButtonType( ), "HLP_BAS_Tenant.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 16,'',false,'',0)\"";
            ClassString = "BtnNext";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_next_Internalname, "", ">", bttBtn_next_Jsonclick, 5, ">", "", StyleString, ClassString, bttBtn_next_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ENEXT."+"'", TempTags, "", context.GetButtonType( ), "HLP_BAS_Tenant.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 18,'',false,'',0)\"";
            ClassString = "BtnLast";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_last_Internalname, "", ">|", bttBtn_last_Jsonclick, 5, ">|", "", StyleString, ClassString, bttBtn_last_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ELAST."+"'", TempTags, "", context.GetButtonType( ), "HLP_BAS_Tenant.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 20,'',false,'',0)\"";
            ClassString = "BtnSelect";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_select_Internalname, "", "选择", bttBtn_select_Jsonclick, 5, "选择", "", StyleString, ClassString, bttBtn_select_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ESELECT."+"'", TempTags, "", 2, "HLP_BAS_Tenant.htm");
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
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtBAS_TenantTenantCode_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtBAS_TenantTenantCode_Internalname, "Tenant Code", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 28,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtBAS_TenantTenantCode_Internalname, A360BAS_TenantTenantCode, StringUtil.RTrim( context.localUtil.Format( A360BAS_TenantTenantCode, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,28);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBAS_TenantTenantCode_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtBAS_TenantTenantCode_Enabled, 0, "text", "", 20, "chr", 1, "row", 20, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_BAS_Tenant.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtTenantName_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtTenantName_Internalname, "Tenant Name", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 33,'',false,'',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtTenantName_Internalname, A394TenantName, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,33);\"", 0, 1, edtTenantName_Enabled, 0, 80, "chr", 3, "row", StyleString, ClassString, "", "", "200", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BAS_Tenant.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
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
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 38,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtInstituteCode_Internalname, A358InstituteCode, StringUtil.RTrim( context.localUtil.Format( A358InstituteCode, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,38);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtInstituteCode_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtInstituteCode_Enabled, 0, "text", "", 20, "chr", 1, "row", 20, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_BAS_Tenant.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtHospitalName_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtHospitalName_Internalname, "Hospital Name", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 43,'',false,'',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtHospitalName_Internalname, A395HospitalName, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,43);\"", 0, 1, edtHospitalName_Enabled, 0, 80, "chr", 3, "row", StyleString, ClassString, "", "", "200", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BAS_Tenant.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtDatabaseID_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtDatabaseID_Internalname, "Database ID", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 48,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtDatabaseID_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A365DatabaseID), 9, 0, ".", "")), ((edtDatabaseID_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A365DatabaseID), "ZZZZZZZZ9")) : context.localUtil.Format( (decimal)(A365DatabaseID), "ZZZZZZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,48);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtDatabaseID_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtDatabaseID_Enabled, 0, "number", "1", 9, "chr", 1, "row", 9, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_BAS_Tenant.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtBAS_TenantLogo_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtBAS_TenantLogo_Internalname, "Logo", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            ClassString = "Attribute";
            StyleString = "";
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 53,'',false,'',0)\"";
            edtBAS_TenantLogo_Filetype = "tmp";
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBAS_TenantLogo_Internalname, "Filetype", edtBAS_TenantLogo_Filetype, true);
            if ( ! String.IsNullOrEmpty(StringUtil.RTrim( A396BAS_TenantLogo)) )
            {
               gxblobfileaux.Source = A396BAS_TenantLogo;
               if ( ! gxblobfileaux.HasExtension() || ( StringUtil.StrCmp(edtBAS_TenantLogo_Filetype, "tmp") != 0 ) )
               {
                  gxblobfileaux.SetExtension(StringUtil.Trim( edtBAS_TenantLogo_Filetype));
               }
               if ( gxblobfileaux.ErrCode == 0 )
               {
                  A396BAS_TenantLogo = gxblobfileaux.GetURI();
                  n396BAS_TenantLogo = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A396BAS_TenantLogo", A396BAS_TenantLogo);
                  context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBAS_TenantLogo_Internalname, "URL", context.PathToRelativeUrl( A396BAS_TenantLogo), true);
                  edtBAS_TenantLogo_Filetype = gxblobfileaux.GetExtension();
                  context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBAS_TenantLogo_Internalname, "Filetype", edtBAS_TenantLogo_Filetype, true);
               }
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBAS_TenantLogo_Internalname, "URL", context.PathToRelativeUrl( A396BAS_TenantLogo), true);
            }
            GxWebStd.gx_blob_field( context, edtBAS_TenantLogo_Internalname, StringUtil.RTrim( A396BAS_TenantLogo), context.PathToRelativeUrl( A396BAS_TenantLogo), (String.IsNullOrEmpty(StringUtil.RTrim( edtBAS_TenantLogo_Contenttype)) ? context.GetContentType( (String.IsNullOrEmpty(StringUtil.RTrim( edtBAS_TenantLogo_Filetype)) ? A396BAS_TenantLogo : edtBAS_TenantLogo_Filetype)) : edtBAS_TenantLogo_Contenttype), false, "", edtBAS_TenantLogo_Parameters, 0, edtBAS_TenantLogo_Enabled, 1, "", "", 0, -1, 250, "px", 60, "px", 0, 0, 0, edtBAS_TenantLogo_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", StyleString, ClassString, "", "", ""+TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,53);\"", "", "", "HLP_BAS_Tenant.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtBAS_TenantCreator_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtBAS_TenantCreator_Internalname, "Creator", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 58,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtBAS_TenantCreator_Internalname, A397BAS_TenantCreator, StringUtil.RTrim( context.localUtil.Format( A397BAS_TenantCreator, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,58);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBAS_TenantCreator_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtBAS_TenantCreator_Enabled, 0, "text", "", 50, "chr", 1, "row", 50, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_BAS_Tenant.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtBAS_TenantCreateTime_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtBAS_TenantCreateTime_Internalname, "Create Time", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 63,'',false,'',0)\"";
            context.WriteHtmlText( "<div id=\""+edtBAS_TenantCreateTime_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtBAS_TenantCreateTime_Internalname, context.localUtil.TToC( A398BAS_TenantCreateTime, 10, 8, 0, 0, "/", ":", " "), context.localUtil.Format( A398BAS_TenantCreateTime, "9999/99/99 99:99:99"), TempTags+" onchange=\""+"gx.date.valid_date(this, 10,'YMD',8,24,'chs',false,0);"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,63);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBAS_TenantCreateTime_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtBAS_TenantCreateTime_Enabled, 0, "text", "", 19, "chr", 1, "row", 19, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_BAS_Tenant.htm");
            GxWebStd.gx_bitmap( context, edtBAS_TenantCreateTime_Internalname+"_dp_trigger", context.GetImagePath( "61b9b5d3-dff6-4d59-9b00-da61bc2cbe93", "", context.GetTheme( )), "", "", "", "", ((1==0)||(edtBAS_TenantCreateTime_Enabled==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;", "", "", "", "", "", "", "", "", 1, false, false, "", "HLP_BAS_Tenant.htm");
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
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtBAS_TenantModifier_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtBAS_TenantModifier_Internalname, "Modifier", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 68,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtBAS_TenantModifier_Internalname, A399BAS_TenantModifier, StringUtil.RTrim( context.localUtil.Format( A399BAS_TenantModifier, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,68);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBAS_TenantModifier_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtBAS_TenantModifier_Enabled, 0, "text", "", 50, "chr", 1, "row", 50, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_BAS_Tenant.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtBAS_TenantModifyTime_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtBAS_TenantModifyTime_Internalname, "Modify Time", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 73,'',false,'',0)\"";
            context.WriteHtmlText( "<div id=\""+edtBAS_TenantModifyTime_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtBAS_TenantModifyTime_Internalname, context.localUtil.TToC( A400BAS_TenantModifyTime, 10, 8, 0, 0, "/", ":", " "), context.localUtil.Format( A400BAS_TenantModifyTime, "9999/99/99 99:99:99"), TempTags+" onchange=\""+"gx.date.valid_date(this, 10,'YMD',8,24,'chs',false,0);"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,73);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBAS_TenantModifyTime_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtBAS_TenantModifyTime_Enabled, 0, "text", "", 19, "chr", 1, "row", 19, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_BAS_Tenant.htm");
            GxWebStd.gx_bitmap( context, edtBAS_TenantModifyTime_Internalname+"_dp_trigger", context.GetImagePath( "61b9b5d3-dff6-4d59-9b00-da61bc2cbe93", "", context.GetTheme( )), "", "", "", "", ((1==0)||(edtBAS_TenantModifyTime_Enabled==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;", "", "", "", "", "", "", "", "", 1, false, false, "", "HLP_BAS_Tenant.htm");
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
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtBAS_TenantIsDeleted_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtBAS_TenantIsDeleted_Internalname, "Is Deleted", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 78,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtBAS_TenantIsDeleted_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A401BAS_TenantIsDeleted), 1, 0, ".", "")), ((edtBAS_TenantIsDeleted_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A401BAS_TenantIsDeleted), "9")) : context.localUtil.Format( (decimal)(A401BAS_TenantIsDeleted), "9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,78);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBAS_TenantIsDeleted_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtBAS_TenantIsDeleted_Enabled, 0, "number", "1", 1, "chr", 1, "row", 1, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_BAS_Tenant.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtBAS_TenantDescription_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtBAS_TenantDescription_Internalname, "Description", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 83,'',false,'',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtBAS_TenantDescription_Internalname, A402BAS_TenantDescription, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,83);\"", 0, 1, edtBAS_TenantDescription_Enabled, 0, 80, "chr", 10, "row", StyleString, ClassString, "", "", "2048", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BAS_Tenant.htm");
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
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 88,'',false,'',0)\"";
            ClassString = "BtnEnter";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_enter_Internalname, "", "确认", bttBtn_enter_Jsonclick, 5, "确认", "", StyleString, ClassString, bttBtn_enter_Visible, bttBtn_enter_Enabled, "standard", "'"+""+"'"+",false,"+"'"+"EENTER."+"'", TempTags, "", context.GetButtonType( ), "HLP_BAS_Tenant.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 90,'',false,'',0)\"";
            ClassString = "BtnCancel";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_cancel_Internalname, "", "取消", bttBtn_cancel_Jsonclick, 1, "取消", "", StyleString, ClassString, bttBtn_cancel_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ECANCEL."+"'", TempTags, "", context.GetButtonType( ), "HLP_BAS_Tenant.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 92,'',false,'',0)\"";
            ClassString = "BtnDelete";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_delete_Internalname, "", "删除", bttBtn_delete_Jsonclick, 5, "删除", "", StyleString, ClassString, bttBtn_delete_Visible, bttBtn_delete_Enabled, "standard", "'"+""+"'"+",false,"+"'"+"EDELETE."+"'", TempTags, "", context.GetButtonType( ), "HLP_BAS_Tenant.htm");
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
               A360BAS_TenantTenantCode = cgiGet( edtBAS_TenantTenantCode_Internalname);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A360BAS_TenantTenantCode", A360BAS_TenantTenantCode);
               A394TenantName = cgiGet( edtTenantName_Internalname);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A394TenantName", A394TenantName);
               A358InstituteCode = cgiGet( edtInstituteCode_Internalname);
               n358InstituteCode = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A358InstituteCode", A358InstituteCode);
               n358InstituteCode = (String.IsNullOrEmpty(StringUtil.RTrim( A358InstituteCode)) ? true : false);
               A395HospitalName = cgiGet( edtHospitalName_Internalname);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A395HospitalName", A395HospitalName);
               if ( ( ( context.localUtil.CToN( cgiGet( edtDatabaseID_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtDatabaseID_Internalname), ".", ",") > Convert.ToDecimal( 999999999 )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "DATABASEID");
                  AnyError = 1;
                  GX_FocusControl = edtDatabaseID_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A365DatabaseID = 0;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A365DatabaseID", StringUtil.LTrim( StringUtil.Str( (decimal)(A365DatabaseID), 9, 0)));
               }
               else
               {
                  A365DatabaseID = (int)(context.localUtil.CToN( cgiGet( edtDatabaseID_Internalname), ".", ","));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A365DatabaseID", StringUtil.LTrim( StringUtil.Str( (decimal)(A365DatabaseID), 9, 0)));
               }
               A396BAS_TenantLogo = cgiGet( edtBAS_TenantLogo_Internalname);
               n396BAS_TenantLogo = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A396BAS_TenantLogo", A396BAS_TenantLogo);
               n396BAS_TenantLogo = (String.IsNullOrEmpty(StringUtil.RTrim( A396BAS_TenantLogo)) ? true : false);
               A397BAS_TenantCreator = cgiGet( edtBAS_TenantCreator_Internalname);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A397BAS_TenantCreator", A397BAS_TenantCreator);
               if ( context.localUtil.VCDateTime( cgiGet( edtBAS_TenantCreateTime_Internalname), 0, 0) == 0 )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_baddatetime", new   object[]  {"BAS_Tenant Create Time"}), 1, "BAS_TENANTCREATETIME");
                  AnyError = 1;
                  GX_FocusControl = edtBAS_TenantCreateTime_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A398BAS_TenantCreateTime = (DateTime)(DateTime.MinValue);
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A398BAS_TenantCreateTime", context.localUtil.TToC( A398BAS_TenantCreateTime, 10, 8, 0, 0, "/", ":", " "));
               }
               else
               {
                  A398BAS_TenantCreateTime = context.localUtil.CToT( cgiGet( edtBAS_TenantCreateTime_Internalname));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A398BAS_TenantCreateTime", context.localUtil.TToC( A398BAS_TenantCreateTime, 10, 8, 0, 0, "/", ":", " "));
               }
               A399BAS_TenantModifier = cgiGet( edtBAS_TenantModifier_Internalname);
               n399BAS_TenantModifier = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A399BAS_TenantModifier", A399BAS_TenantModifier);
               n399BAS_TenantModifier = (String.IsNullOrEmpty(StringUtil.RTrim( A399BAS_TenantModifier)) ? true : false);
               if ( context.localUtil.VCDateTime( cgiGet( edtBAS_TenantModifyTime_Internalname), 0, 0) == 0 )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_baddatetime", new   object[]  {"BAS_Tenant Modify Time"}), 1, "BAS_TENANTMODIFYTIME");
                  AnyError = 1;
                  GX_FocusControl = edtBAS_TenantModifyTime_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A400BAS_TenantModifyTime = (DateTime)(DateTime.MinValue);
                  n400BAS_TenantModifyTime = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A400BAS_TenantModifyTime", context.localUtil.TToC( A400BAS_TenantModifyTime, 10, 8, 0, 0, "/", ":", " "));
               }
               else
               {
                  A400BAS_TenantModifyTime = context.localUtil.CToT( cgiGet( edtBAS_TenantModifyTime_Internalname));
                  n400BAS_TenantModifyTime = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A400BAS_TenantModifyTime", context.localUtil.TToC( A400BAS_TenantModifyTime, 10, 8, 0, 0, "/", ":", " "));
               }
               n400BAS_TenantModifyTime = ((DateTime.MinValue==A400BAS_TenantModifyTime) ? true : false);
               if ( ( ( context.localUtil.CToN( cgiGet( edtBAS_TenantIsDeleted_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtBAS_TenantIsDeleted_Internalname), ".", ",") > Convert.ToDecimal( 9 )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "BAS_TENANTISDELETED");
                  AnyError = 1;
                  GX_FocusControl = edtBAS_TenantIsDeleted_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A401BAS_TenantIsDeleted = 0;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A401BAS_TenantIsDeleted", StringUtil.Str( (decimal)(A401BAS_TenantIsDeleted), 1, 0));
               }
               else
               {
                  A401BAS_TenantIsDeleted = (short)(context.localUtil.CToN( cgiGet( edtBAS_TenantIsDeleted_Internalname), ".", ","));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A401BAS_TenantIsDeleted", StringUtil.Str( (decimal)(A401BAS_TenantIsDeleted), 1, 0));
               }
               A402BAS_TenantDescription = cgiGet( edtBAS_TenantDescription_Internalname);
               n402BAS_TenantDescription = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A402BAS_TenantDescription", A402BAS_TenantDescription);
               n402BAS_TenantDescription = (String.IsNullOrEmpty(StringUtil.RTrim( A402BAS_TenantDescription)) ? true : false);
               /* Read saved values. */
               Z360BAS_TenantTenantCode = cgiGet( "Z360BAS_TenantTenantCode");
               Z394TenantName = cgiGet( "Z394TenantName");
               Z395HospitalName = cgiGet( "Z395HospitalName");
               Z397BAS_TenantCreator = cgiGet( "Z397BAS_TenantCreator");
               Z398BAS_TenantCreateTime = context.localUtil.CToT( cgiGet( "Z398BAS_TenantCreateTime"), 0);
               Z399BAS_TenantModifier = cgiGet( "Z399BAS_TenantModifier");
               n399BAS_TenantModifier = (String.IsNullOrEmpty(StringUtil.RTrim( A399BAS_TenantModifier)) ? true : false);
               Z400BAS_TenantModifyTime = context.localUtil.CToT( cgiGet( "Z400BAS_TenantModifyTime"), 0);
               n400BAS_TenantModifyTime = ((DateTime.MinValue==A400BAS_TenantModifyTime) ? true : false);
               Z401BAS_TenantIsDeleted = (short)(context.localUtil.CToN( cgiGet( "Z401BAS_TenantIsDeleted"), ".", ","));
               Z358InstituteCode = cgiGet( "Z358InstituteCode");
               n358InstituteCode = (String.IsNullOrEmpty(StringUtil.RTrim( A358InstituteCode)) ? true : false);
               Z365DatabaseID = (int)(context.localUtil.CToN( cgiGet( "Z365DatabaseID"), ".", ","));
               IsConfirmed = (short)(context.localUtil.CToN( cgiGet( "IsConfirmed"), ".", ","));
               IsModified = (short)(context.localUtil.CToN( cgiGet( "IsModified"), ".", ","));
               Gx_mode = cgiGet( "Mode");
               Gx_mode = cgiGet( "vMODE");
               edtBAS_TenantLogo_Filename = cgiGet( "BAS_TENANTLOGO_Filename");
               edtBAS_TenantLogo_Filetype = cgiGet( "BAS_TENANTLOGO_Filetype");
               /* Read subfile selected row values. */
               /* Read hidden variables. */
               if ( ! String.IsNullOrEmpty(StringUtil.RTrim( A396BAS_TenantLogo)) )
               {
                  edtBAS_TenantLogo_Filename = (String)(CGIGetFileName(edtBAS_TenantLogo_Internalname));
                  edtBAS_TenantLogo_Filetype = (String)(CGIGetFileType(edtBAS_TenantLogo_Internalname));
               }
               if ( String.IsNullOrEmpty(StringUtil.RTrim( A396BAS_TenantLogo)) )
               {
                  GXCCtlgxBlob = "BAS_TENANTLOGO" + "_gxBlob";
                  A396BAS_TenantLogo = cgiGet( GXCCtlgxBlob);
                  n396BAS_TenantLogo = false;
                  n396BAS_TenantLogo = (String.IsNullOrEmpty(StringUtil.RTrim( A396BAS_TenantLogo)) ? true : false);
               }
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
                  A360BAS_TenantTenantCode = GetNextPar( );
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A360BAS_TenantTenantCode", A360BAS_TenantTenantCode);
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
               InitAll1F52( ) ;
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
         DisableAttributes1F52( ) ;
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

      protected void ResetCaption1F0( )
      {
      }

      protected void ZM1F52( short GX_JID )
      {
         if ( ( GX_JID == 3 ) || ( GX_JID == 0 ) )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
            {
               Z394TenantName = T001F3_A394TenantName[0];
               Z395HospitalName = T001F3_A395HospitalName[0];
               Z397BAS_TenantCreator = T001F3_A397BAS_TenantCreator[0];
               Z398BAS_TenantCreateTime = T001F3_A398BAS_TenantCreateTime[0];
               Z399BAS_TenantModifier = T001F3_A399BAS_TenantModifier[0];
               Z400BAS_TenantModifyTime = T001F3_A400BAS_TenantModifyTime[0];
               Z401BAS_TenantIsDeleted = T001F3_A401BAS_TenantIsDeleted[0];
               Z358InstituteCode = T001F3_A358InstituteCode[0];
               Z365DatabaseID = T001F3_A365DatabaseID[0];
            }
            else
            {
               Z394TenantName = A394TenantName;
               Z395HospitalName = A395HospitalName;
               Z397BAS_TenantCreator = A397BAS_TenantCreator;
               Z398BAS_TenantCreateTime = A398BAS_TenantCreateTime;
               Z399BAS_TenantModifier = A399BAS_TenantModifier;
               Z400BAS_TenantModifyTime = A400BAS_TenantModifyTime;
               Z401BAS_TenantIsDeleted = A401BAS_TenantIsDeleted;
               Z358InstituteCode = A358InstituteCode;
               Z365DatabaseID = A365DatabaseID;
            }
         }
         if ( GX_JID == -3 )
         {
            Z360BAS_TenantTenantCode = A360BAS_TenantTenantCode;
            Z394TenantName = A394TenantName;
            Z395HospitalName = A395HospitalName;
            Z396BAS_TenantLogo = A396BAS_TenantLogo;
            Z397BAS_TenantCreator = A397BAS_TenantCreator;
            Z398BAS_TenantCreateTime = A398BAS_TenantCreateTime;
            Z399BAS_TenantModifier = A399BAS_TenantModifier;
            Z400BAS_TenantModifyTime = A400BAS_TenantModifyTime;
            Z401BAS_TenantIsDeleted = A401BAS_TenantIsDeleted;
            Z402BAS_TenantDescription = A402BAS_TenantDescription;
            Z358InstituteCode = A358InstituteCode;
            Z365DatabaseID = A365DatabaseID;
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

      protected void Load1F52( )
      {
         /* Using cursor T001F6 */
         pr_datastore1.execute(4, new Object[] {A360BAS_TenantTenantCode});
         if ( (pr_datastore1.getStatus(4) != 101) )
         {
            RcdFound52 = 1;
            A394TenantName = T001F6_A394TenantName[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A394TenantName", A394TenantName);
            A395HospitalName = T001F6_A395HospitalName[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A395HospitalName", A395HospitalName);
            A397BAS_TenantCreator = T001F6_A397BAS_TenantCreator[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A397BAS_TenantCreator", A397BAS_TenantCreator);
            A398BAS_TenantCreateTime = T001F6_A398BAS_TenantCreateTime[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A398BAS_TenantCreateTime", context.localUtil.TToC( A398BAS_TenantCreateTime, 10, 8, 0, 0, "/", ":", " "));
            A399BAS_TenantModifier = T001F6_A399BAS_TenantModifier[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A399BAS_TenantModifier", A399BAS_TenantModifier);
            n399BAS_TenantModifier = T001F6_n399BAS_TenantModifier[0];
            A400BAS_TenantModifyTime = T001F6_A400BAS_TenantModifyTime[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A400BAS_TenantModifyTime", context.localUtil.TToC( A400BAS_TenantModifyTime, 10, 8, 0, 0, "/", ":", " "));
            n400BAS_TenantModifyTime = T001F6_n400BAS_TenantModifyTime[0];
            A401BAS_TenantIsDeleted = T001F6_A401BAS_TenantIsDeleted[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A401BAS_TenantIsDeleted", StringUtil.Str( (decimal)(A401BAS_TenantIsDeleted), 1, 0));
            A402BAS_TenantDescription = T001F6_A402BAS_TenantDescription[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A402BAS_TenantDescription", A402BAS_TenantDescription);
            n402BAS_TenantDescription = T001F6_n402BAS_TenantDescription[0];
            A358InstituteCode = T001F6_A358InstituteCode[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A358InstituteCode", A358InstituteCode);
            n358InstituteCode = T001F6_n358InstituteCode[0];
            A365DatabaseID = T001F6_A365DatabaseID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A365DatabaseID", StringUtil.LTrim( StringUtil.Str( (decimal)(A365DatabaseID), 9, 0)));
            A396BAS_TenantLogo = T001F6_A396BAS_TenantLogo[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A396BAS_TenantLogo", A396BAS_TenantLogo);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBAS_TenantLogo_Internalname, "URL", context.PathToRelativeUrl( A396BAS_TenantLogo), true);
            n396BAS_TenantLogo = T001F6_n396BAS_TenantLogo[0];
            ZM1F52( -3) ;
         }
         pr_datastore1.close(4);
         OnLoadActions1F52( ) ;
      }

      protected void OnLoadActions1F52( )
      {
      }

      protected void CheckExtendedTable1F52( )
      {
         Gx_BScreen = 1;
         standaloneModal( ) ;
         /* Using cursor T001F4 */
         pr_datastore1.execute(2, new Object[] {n358InstituteCode, A358InstituteCode});
         if ( (pr_datastore1.getStatus(2) == 101) )
         {
            if ( ! ( String.IsNullOrEmpty(StringUtil.RTrim( A358InstituteCode)) ) )
            {
               GX_msglist.addItem("不匹配'BAS_Institute'", "ForeignKeyNotFound", 1, "INSTITUTECODE");
               AnyError = 1;
               GX_FocusControl = edtInstituteCode_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
         }
         pr_datastore1.close(2);
         /* Using cursor T001F5 */
         pr_datastore1.execute(3, new Object[] {A365DatabaseID});
         if ( (pr_datastore1.getStatus(3) == 101) )
         {
            GX_msglist.addItem("不匹配'SYS_Database'", "ForeignKeyNotFound", 1, "DATABASEID");
            AnyError = 1;
            GX_FocusControl = edtDatabaseID_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         pr_datastore1.close(3);
         if ( ! ( (DateTime.MinValue==A398BAS_TenantCreateTime) || ( A398BAS_TenantCreateTime >= context.localUtil.YMDHMSToT( 1753, 1, 1, 0, 0, 0) ) ) )
         {
            GX_msglist.addItem("域BAS_Tenant Create Time超界", "OutOfRange", 1, "BAS_TENANTCREATETIME");
            AnyError = 1;
            GX_FocusControl = edtBAS_TenantCreateTime_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( ! ( (DateTime.MinValue==A400BAS_TenantModifyTime) || ( A400BAS_TenantModifyTime >= context.localUtil.YMDHMSToT( 1753, 1, 1, 0, 0, 0) ) ) )
         {
            GX_msglist.addItem("域BAS_Tenant Modify Time超界", "OutOfRange", 1, "BAS_TENANTMODIFYTIME");
            AnyError = 1;
            GX_FocusControl = edtBAS_TenantModifyTime_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
      }

      protected void CloseExtendedTableCursors1F52( )
      {
         pr_datastore1.close(2);
         pr_datastore1.close(3);
      }

      protected void enableDisable( )
      {
      }

      protected void gxLoad_4( String A358InstituteCode )
      {
         /* Using cursor T001F7 */
         pr_datastore1.execute(5, new Object[] {n358InstituteCode, A358InstituteCode});
         if ( (pr_datastore1.getStatus(5) == 101) )
         {
            if ( ! ( String.IsNullOrEmpty(StringUtil.RTrim( A358InstituteCode)) ) )
            {
               GX_msglist.addItem("不匹配'BAS_Institute'", "ForeignKeyNotFound", 1, "INSTITUTECODE");
               AnyError = 1;
               GX_FocusControl = edtInstituteCode_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
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

      protected void gxLoad_5( int A365DatabaseID )
      {
         /* Using cursor T001F8 */
         pr_datastore1.execute(6, new Object[] {A365DatabaseID});
         if ( (pr_datastore1.getStatus(6) == 101) )
         {
            GX_msglist.addItem("不匹配'SYS_Database'", "ForeignKeyNotFound", 1, "DATABASEID");
            AnyError = 1;
            GX_FocusControl = edtDatabaseID_Internalname;
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

      protected void GetKey1F52( )
      {
         /* Using cursor T001F9 */
         pr_datastore1.execute(7, new Object[] {A360BAS_TenantTenantCode});
         if ( (pr_datastore1.getStatus(7) != 101) )
         {
            RcdFound52 = 1;
         }
         else
         {
            RcdFound52 = 0;
         }
         pr_datastore1.close(7);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor T001F3 */
         pr_datastore1.execute(1, new Object[] {A360BAS_TenantTenantCode});
         if ( (pr_datastore1.getStatus(1) != 101) )
         {
            ZM1F52( 3) ;
            RcdFound52 = 1;
            A360BAS_TenantTenantCode = T001F3_A360BAS_TenantTenantCode[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A360BAS_TenantTenantCode", A360BAS_TenantTenantCode);
            A394TenantName = T001F3_A394TenantName[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A394TenantName", A394TenantName);
            A395HospitalName = T001F3_A395HospitalName[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A395HospitalName", A395HospitalName);
            A397BAS_TenantCreator = T001F3_A397BAS_TenantCreator[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A397BAS_TenantCreator", A397BAS_TenantCreator);
            A398BAS_TenantCreateTime = T001F3_A398BAS_TenantCreateTime[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A398BAS_TenantCreateTime", context.localUtil.TToC( A398BAS_TenantCreateTime, 10, 8, 0, 0, "/", ":", " "));
            A399BAS_TenantModifier = T001F3_A399BAS_TenantModifier[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A399BAS_TenantModifier", A399BAS_TenantModifier);
            n399BAS_TenantModifier = T001F3_n399BAS_TenantModifier[0];
            A400BAS_TenantModifyTime = T001F3_A400BAS_TenantModifyTime[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A400BAS_TenantModifyTime", context.localUtil.TToC( A400BAS_TenantModifyTime, 10, 8, 0, 0, "/", ":", " "));
            n400BAS_TenantModifyTime = T001F3_n400BAS_TenantModifyTime[0];
            A401BAS_TenantIsDeleted = T001F3_A401BAS_TenantIsDeleted[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A401BAS_TenantIsDeleted", StringUtil.Str( (decimal)(A401BAS_TenantIsDeleted), 1, 0));
            A402BAS_TenantDescription = T001F3_A402BAS_TenantDescription[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A402BAS_TenantDescription", A402BAS_TenantDescription);
            n402BAS_TenantDescription = T001F3_n402BAS_TenantDescription[0];
            A358InstituteCode = T001F3_A358InstituteCode[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A358InstituteCode", A358InstituteCode);
            n358InstituteCode = T001F3_n358InstituteCode[0];
            A365DatabaseID = T001F3_A365DatabaseID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A365DatabaseID", StringUtil.LTrim( StringUtil.Str( (decimal)(A365DatabaseID), 9, 0)));
            A396BAS_TenantLogo = T001F3_A396BAS_TenantLogo[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A396BAS_TenantLogo", A396BAS_TenantLogo);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBAS_TenantLogo_Internalname, "URL", context.PathToRelativeUrl( A396BAS_TenantLogo), true);
            n396BAS_TenantLogo = T001F3_n396BAS_TenantLogo[0];
            Z360BAS_TenantTenantCode = A360BAS_TenantTenantCode;
            sMode52 = Gx_mode;
            Gx_mode = "DSP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            standaloneModal( ) ;
            Load1F52( ) ;
            if ( AnyError == 1 )
            {
               RcdFound52 = 0;
               InitializeNonKey1F52( ) ;
            }
            Gx_mode = sMode52;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         else
         {
            RcdFound52 = 0;
            InitializeNonKey1F52( ) ;
            sMode52 = Gx_mode;
            Gx_mode = "DSP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            standaloneModal( ) ;
            Gx_mode = sMode52;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         pr_datastore1.close(1);
      }

      protected void getEqualNoModal( )
      {
         GetKey1F52( ) ;
         if ( RcdFound52 == 0 )
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
         RcdFound52 = 0;
         /* Using cursor T001F10 */
         pr_datastore1.execute(8, new Object[] {A360BAS_TenantTenantCode});
         if ( (pr_datastore1.getStatus(8) != 101) )
         {
            while ( (pr_datastore1.getStatus(8) != 101) && ( ( StringUtil.StrCmp(T001F10_A360BAS_TenantTenantCode[0], A360BAS_TenantTenantCode) < 0 ) ) )
            {
               pr_datastore1.readNext(8);
            }
            if ( (pr_datastore1.getStatus(8) != 101) && ( ( StringUtil.StrCmp(T001F10_A360BAS_TenantTenantCode[0], A360BAS_TenantTenantCode) > 0 ) ) )
            {
               A360BAS_TenantTenantCode = T001F10_A360BAS_TenantTenantCode[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A360BAS_TenantTenantCode", A360BAS_TenantTenantCode);
               RcdFound52 = 1;
            }
         }
         pr_datastore1.close(8);
      }

      protected void move_previous( )
      {
         RcdFound52 = 0;
         /* Using cursor T001F11 */
         pr_datastore1.execute(9, new Object[] {A360BAS_TenantTenantCode});
         if ( (pr_datastore1.getStatus(9) != 101) )
         {
            while ( (pr_datastore1.getStatus(9) != 101) && ( ( StringUtil.StrCmp(T001F11_A360BAS_TenantTenantCode[0], A360BAS_TenantTenantCode) > 0 ) ) )
            {
               pr_datastore1.readNext(9);
            }
            if ( (pr_datastore1.getStatus(9) != 101) && ( ( StringUtil.StrCmp(T001F11_A360BAS_TenantTenantCode[0], A360BAS_TenantTenantCode) < 0 ) ) )
            {
               A360BAS_TenantTenantCode = T001F11_A360BAS_TenantTenantCode[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A360BAS_TenantTenantCode", A360BAS_TenantTenantCode);
               RcdFound52 = 1;
            }
         }
         pr_datastore1.close(9);
      }

      protected void btn_enter( )
      {
         nKeyPressed = 1;
         GetKey1F52( ) ;
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            /* Insert record */
            GX_FocusControl = edtBAS_TenantTenantCode_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            Insert1F52( ) ;
            if ( AnyError == 1 )
            {
               GX_FocusControl = "";
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
         }
         else
         {
            if ( RcdFound52 == 1 )
            {
               if ( StringUtil.StrCmp(A360BAS_TenantTenantCode, Z360BAS_TenantTenantCode) != 0 )
               {
                  A360BAS_TenantTenantCode = Z360BAS_TenantTenantCode;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A360BAS_TenantTenantCode", A360BAS_TenantTenantCode);
                  GX_msglist.addItem(context.GetMessage( "GXM_getbeforeupd", ""), "CandidateKeyNotFound", 1, "BAS_TENANTTENANTCODE");
                  AnyError = 1;
                  GX_FocusControl = edtBAS_TenantTenantCode_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
               else if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
               {
                  delete( ) ;
                  AfterTrn( ) ;
                  GX_FocusControl = edtBAS_TenantTenantCode_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
               else
               {
                  Gx_mode = "UPD";
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                  /* Update record */
                  Update1F52( ) ;
                  GX_FocusControl = edtBAS_TenantTenantCode_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
            }
            else
            {
               if ( StringUtil.StrCmp(A360BAS_TenantTenantCode, Z360BAS_TenantTenantCode) != 0 )
               {
                  Gx_mode = "INS";
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                  /* Insert record */
                  GX_FocusControl = edtBAS_TenantTenantCode_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  Insert1F52( ) ;
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
                     GX_msglist.addItem(context.GetMessage( "GXM_recdeleted", ""), 1, "BAS_TENANTTENANTCODE");
                     AnyError = 1;
                     GX_FocusControl = edtBAS_TenantTenantCode_Internalname;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  }
                  else
                  {
                     Gx_mode = "INS";
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                     /* Insert record */
                     GX_FocusControl = edtBAS_TenantTenantCode_Internalname;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                     Insert1F52( ) ;
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
         if ( StringUtil.StrCmp(A360BAS_TenantTenantCode, Z360BAS_TenantTenantCode) != 0 )
         {
            A360BAS_TenantTenantCode = Z360BAS_TenantTenantCode;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A360BAS_TenantTenantCode", A360BAS_TenantTenantCode);
            GX_msglist.addItem(context.GetMessage( "GXM_getbeforedlt", ""), 1, "BAS_TENANTTENANTCODE");
            AnyError = 1;
            GX_FocusControl = edtBAS_TenantTenantCode_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         else
         {
            delete( ) ;
            AfterTrn( ) ;
            GX_FocusControl = edtBAS_TenantTenantCode_Internalname;
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
         if ( RcdFound52 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_keynfound", ""), "PrimaryKeyNotFound", 1, "BAS_TENANTTENANTCODE");
            AnyError = 1;
            GX_FocusControl = edtBAS_TenantTenantCode_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         GX_FocusControl = edtTenantName_Internalname;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_first( )
      {
         nKeyPressed = 2;
         IsConfirmed = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "IsConfirmed", StringUtil.LTrim( StringUtil.Str( (decimal)(IsConfirmed), 4, 0)));
         ScanStart1F52( ) ;
         if ( RcdFound52 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "", true);
         }
         else
         {
            Gx_mode = "UPD";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtTenantName_Internalname;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         ScanEnd1F52( ) ;
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
         if ( RcdFound52 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "", true);
         }
         else
         {
            Gx_mode = "UPD";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtTenantName_Internalname;
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
         if ( RcdFound52 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "", true);
         }
         else
         {
            Gx_mode = "UPD";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtTenantName_Internalname;
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
         ScanStart1F52( ) ;
         if ( RcdFound52 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "", true);
         }
         else
         {
            while ( RcdFound52 != 0 )
            {
               ScanNext1F52( ) ;
            }
            Gx_mode = "UPD";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtTenantName_Internalname;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         ScanEnd1F52( ) ;
         getByPrimaryKey( ) ;
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_select( )
      {
         getEqualNoModal( ) ;
      }

      protected void CheckOptimisticConcurrency1F52( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor T001F2 */
            pr_datastore1.execute(0, new Object[] {A360BAS_TenantTenantCode});
            if ( (pr_datastore1.getStatus(0) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"BAS_TENANT"}), "RecordIsLocked", 1, "");
               AnyError = 1;
               return  ;
            }
            Gx_longc = false;
            if ( (pr_datastore1.getStatus(0) == 101) || ( StringUtil.StrCmp(Z394TenantName, T001F2_A394TenantName[0]) != 0 ) || ( StringUtil.StrCmp(Z395HospitalName, T001F2_A395HospitalName[0]) != 0 ) || ( StringUtil.StrCmp(Z397BAS_TenantCreator, T001F2_A397BAS_TenantCreator[0]) != 0 ) || ( Z398BAS_TenantCreateTime != T001F2_A398BAS_TenantCreateTime[0] ) || ( StringUtil.StrCmp(Z399BAS_TenantModifier, T001F2_A399BAS_TenantModifier[0]) != 0 ) )
            {
               Gx_longc = true;
            }
            if ( Gx_longc || ( Z400BAS_TenantModifyTime != T001F2_A400BAS_TenantModifyTime[0] ) || ( Z401BAS_TenantIsDeleted != T001F2_A401BAS_TenantIsDeleted[0] ) || ( StringUtil.StrCmp(Z358InstituteCode, T001F2_A358InstituteCode[0]) != 0 ) || ( Z365DatabaseID != T001F2_A365DatabaseID[0] ) )
            {
               if ( StringUtil.StrCmp(Z394TenantName, T001F2_A394TenantName[0]) != 0 )
               {
                  GXUtil.WriteLog("bas_tenant:[seudo value changed for attri]"+"TenantName");
                  GXUtil.WriteLogRaw("Old: ",Z394TenantName);
                  GXUtil.WriteLogRaw("Current: ",T001F2_A394TenantName[0]);
               }
               if ( StringUtil.StrCmp(Z395HospitalName, T001F2_A395HospitalName[0]) != 0 )
               {
                  GXUtil.WriteLog("bas_tenant:[seudo value changed for attri]"+"HospitalName");
                  GXUtil.WriteLogRaw("Old: ",Z395HospitalName);
                  GXUtil.WriteLogRaw("Current: ",T001F2_A395HospitalName[0]);
               }
               if ( StringUtil.StrCmp(Z397BAS_TenantCreator, T001F2_A397BAS_TenantCreator[0]) != 0 )
               {
                  GXUtil.WriteLog("bas_tenant:[seudo value changed for attri]"+"BAS_TenantCreator");
                  GXUtil.WriteLogRaw("Old: ",Z397BAS_TenantCreator);
                  GXUtil.WriteLogRaw("Current: ",T001F2_A397BAS_TenantCreator[0]);
               }
               if ( Z398BAS_TenantCreateTime != T001F2_A398BAS_TenantCreateTime[0] )
               {
                  GXUtil.WriteLog("bas_tenant:[seudo value changed for attri]"+"BAS_TenantCreateTime");
                  GXUtil.WriteLogRaw("Old: ",Z398BAS_TenantCreateTime);
                  GXUtil.WriteLogRaw("Current: ",T001F2_A398BAS_TenantCreateTime[0]);
               }
               if ( StringUtil.StrCmp(Z399BAS_TenantModifier, T001F2_A399BAS_TenantModifier[0]) != 0 )
               {
                  GXUtil.WriteLog("bas_tenant:[seudo value changed for attri]"+"BAS_TenantModifier");
                  GXUtil.WriteLogRaw("Old: ",Z399BAS_TenantModifier);
                  GXUtil.WriteLogRaw("Current: ",T001F2_A399BAS_TenantModifier[0]);
               }
               if ( Z400BAS_TenantModifyTime != T001F2_A400BAS_TenantModifyTime[0] )
               {
                  GXUtil.WriteLog("bas_tenant:[seudo value changed for attri]"+"BAS_TenantModifyTime");
                  GXUtil.WriteLogRaw("Old: ",Z400BAS_TenantModifyTime);
                  GXUtil.WriteLogRaw("Current: ",T001F2_A400BAS_TenantModifyTime[0]);
               }
               if ( Z401BAS_TenantIsDeleted != T001F2_A401BAS_TenantIsDeleted[0] )
               {
                  GXUtil.WriteLog("bas_tenant:[seudo value changed for attri]"+"BAS_TenantIsDeleted");
                  GXUtil.WriteLogRaw("Old: ",Z401BAS_TenantIsDeleted);
                  GXUtil.WriteLogRaw("Current: ",T001F2_A401BAS_TenantIsDeleted[0]);
               }
               if ( StringUtil.StrCmp(Z358InstituteCode, T001F2_A358InstituteCode[0]) != 0 )
               {
                  GXUtil.WriteLog("bas_tenant:[seudo value changed for attri]"+"InstituteCode");
                  GXUtil.WriteLogRaw("Old: ",Z358InstituteCode);
                  GXUtil.WriteLogRaw("Current: ",T001F2_A358InstituteCode[0]);
               }
               if ( Z365DatabaseID != T001F2_A365DatabaseID[0] )
               {
                  GXUtil.WriteLog("bas_tenant:[seudo value changed for attri]"+"DatabaseID");
                  GXUtil.WriteLogRaw("Old: ",Z365DatabaseID);
                  GXUtil.WriteLogRaw("Current: ",T001F2_A365DatabaseID[0]);
               }
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"BAS_TENANT"}), "RecordWasChanged", 1, "");
               AnyError = 1;
               return  ;
            }
         }
      }

      protected void Insert1F52( )
      {
         BeforeValidate1F52( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable1F52( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM1F52( 0) ;
            CheckOptimisticConcurrency1F52( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm1F52( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert1F52( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T001F12 */
                     pr_datastore1.execute(10, new Object[] {A360BAS_TenantTenantCode, A394TenantName, A395HospitalName, n396BAS_TenantLogo, A396BAS_TenantLogo, A397BAS_TenantCreator, A398BAS_TenantCreateTime, n399BAS_TenantModifier, A399BAS_TenantModifier, n400BAS_TenantModifyTime, A400BAS_TenantModifyTime, A401BAS_TenantIsDeleted, n402BAS_TenantDescription, A402BAS_TenantDescription, n358InstituteCode, A358InstituteCode, A365DatabaseID});
                     pr_datastore1.close(10);
                     dsDataStore1.SmartCacheProvider.SetUpdated("BAS_TENANT") ;
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
                           ResetCaption1F0( ) ;
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
               Load1F52( ) ;
            }
            EndLevel1F52( ) ;
         }
         CloseExtendedTableCursors1F52( ) ;
      }

      protected void Update1F52( )
      {
         BeforeValidate1F52( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable1F52( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency1F52( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm1F52( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate1F52( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T001F13 */
                     pr_datastore1.execute(11, new Object[] {A394TenantName, A395HospitalName, A397BAS_TenantCreator, A398BAS_TenantCreateTime, n399BAS_TenantModifier, A399BAS_TenantModifier, n400BAS_TenantModifyTime, A400BAS_TenantModifyTime, A401BAS_TenantIsDeleted, n402BAS_TenantDescription, A402BAS_TenantDescription, n358InstituteCode, A358InstituteCode, A365DatabaseID, A360BAS_TenantTenantCode});
                     pr_datastore1.close(11);
                     dsDataStore1.SmartCacheProvider.SetUpdated("BAS_TENANT") ;
                     if ( (pr_datastore1.getStatus(11) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"BAS_TENANT"}), "RecordIsLocked", 1, "");
                        AnyError = 1;
                     }
                     DeferredUpdate1F52( ) ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( update) rules */
                        /* End of After( update) rules */
                        if ( AnyError == 0 )
                        {
                           getByPrimaryKey( ) ;
                           GX_msglist.addItem(context.GetMessage( "GXM_sucupdated", ""), "SuccessfullyUpdated", 0, "", true);
                           ResetCaption1F0( ) ;
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
            EndLevel1F52( ) ;
         }
         CloseExtendedTableCursors1F52( ) ;
      }

      protected void DeferredUpdate1F52( )
      {
         if ( AnyError == 0 )
         {
            /* Using cursor T001F14 */
            pr_datastore1.execute(12, new Object[] {n396BAS_TenantLogo, A396BAS_TenantLogo, A360BAS_TenantTenantCode});
            pr_datastore1.close(12);
            dsDataStore1.SmartCacheProvider.SetUpdated("BAS_TENANT") ;
         }
      }

      protected void delete( )
      {
         Gx_mode = "DLT";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         BeforeValidate1F52( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency1F52( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls1F52( ) ;
            AfterConfirm1F52( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete1F52( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor T001F15 */
                  pr_datastore1.execute(13, new Object[] {A360BAS_TenantTenantCode});
                  pr_datastore1.close(13);
                  dsDataStore1.SmartCacheProvider.SetUpdated("BAS_TENANT") ;
                  if ( AnyError == 0 )
                  {
                     /* Start of After( delete) rules */
                     /* End of After( delete) rules */
                     if ( AnyError == 0 )
                     {
                        move_next( ) ;
                        if ( RcdFound52 == 0 )
                        {
                           InitAll1F52( ) ;
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
                        ResetCaption1F0( ) ;
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
         sMode52 = Gx_mode;
         Gx_mode = "DLT";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         EndLevel1F52( ) ;
         Gx_mode = sMode52;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
      }

      protected void OnDeleteControls1F52( )
      {
         standaloneModal( ) ;
         /* No delete mode formulas found. */
         if ( AnyError == 0 )
         {
            /* Using cursor T001F16 */
            pr_default.execute(0, new Object[] {A360BAS_TenantTenantCode});
            if ( (pr_default.getStatus(0) != 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_del", new   object[]  {" T64"}), "CannotDeleteReferencedRecord", 1, "");
               AnyError = 1;
            }
            pr_default.close(0);
            /* Using cursor T001F17 */
            pr_datastore1.execute(14, new Object[] {A360BAS_TenantTenantCode});
            if ( (pr_datastore1.getStatus(14) != 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_del", new   object[]  {"SYS_Tenant User"}), "CannotDeleteReferencedRecord", 1, "");
               AnyError = 1;
            }
            pr_datastore1.close(14);
         }
      }

      protected void EndLevel1F52( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            pr_datastore1.close(0);
         }
         if ( AnyError == 0 )
         {
            BeforeComplete1F52( ) ;
         }
         if ( AnyError == 0 )
         {
            pr_datastore1.close(1);
            context.CommitDataStores("bas_tenant",pr_default);
            if ( AnyError == 0 )
            {
               ConfirmValues1F0( ) ;
            }
            /* After transaction rules */
            /* Execute 'After Trn' event if defined. */
            trnEnded = 1;
         }
         else
         {
            pr_datastore1.close(1);
            context.RollbackDataStores("bas_tenant",pr_default);
         }
         IsModified = 0;
         if ( AnyError != 0 )
         {
            context.wjLoc = "";
            context.nUserReturn = 0;
         }
      }

      public void ScanStart1F52( )
      {
         /* Using cursor T001F18 */
         pr_datastore1.execute(15);
         RcdFound52 = 0;
         if ( (pr_datastore1.getStatus(15) != 101) )
         {
            RcdFound52 = 1;
            A360BAS_TenantTenantCode = T001F18_A360BAS_TenantTenantCode[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A360BAS_TenantTenantCode", A360BAS_TenantTenantCode);
         }
         /* Load Subordinate Levels */
      }

      protected void ScanNext1F52( )
      {
         /* Scan next routine */
         pr_datastore1.readNext(15);
         RcdFound52 = 0;
         if ( (pr_datastore1.getStatus(15) != 101) )
         {
            RcdFound52 = 1;
            A360BAS_TenantTenantCode = T001F18_A360BAS_TenantTenantCode[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A360BAS_TenantTenantCode", A360BAS_TenantTenantCode);
         }
      }

      protected void ScanEnd1F52( )
      {
         pr_datastore1.close(15);
      }

      protected void AfterConfirm1F52( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert1F52( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate1F52( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete1F52( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete1F52( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate1F52( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes1F52( )
      {
         edtBAS_TenantTenantCode_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBAS_TenantTenantCode_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBAS_TenantTenantCode_Enabled), 5, 0)), true);
         edtTenantName_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtTenantName_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtTenantName_Enabled), 5, 0)), true);
         edtInstituteCode_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtInstituteCode_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtInstituteCode_Enabled), 5, 0)), true);
         edtHospitalName_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtHospitalName_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtHospitalName_Enabled), 5, 0)), true);
         edtDatabaseID_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtDatabaseID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtDatabaseID_Enabled), 5, 0)), true);
         edtBAS_TenantLogo_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBAS_TenantLogo_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBAS_TenantLogo_Enabled), 5, 0)), true);
         edtBAS_TenantCreator_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBAS_TenantCreator_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBAS_TenantCreator_Enabled), 5, 0)), true);
         edtBAS_TenantCreateTime_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBAS_TenantCreateTime_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBAS_TenantCreateTime_Enabled), 5, 0)), true);
         edtBAS_TenantModifier_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBAS_TenantModifier_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBAS_TenantModifier_Enabled), 5, 0)), true);
         edtBAS_TenantModifyTime_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBAS_TenantModifyTime_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBAS_TenantModifyTime_Enabled), 5, 0)), true);
         edtBAS_TenantIsDeleted_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBAS_TenantIsDeleted_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBAS_TenantIsDeleted_Enabled), 5, 0)), true);
         edtBAS_TenantDescription_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBAS_TenantDescription_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBAS_TenantDescription_Enabled), 5, 0)), true);
      }

      protected void send_integrity_lvl_hashes1F52( )
      {
      }

      protected void assign_properties_default( )
      {
      }

      protected void ConfirmValues1F0( )
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
         context.AddJavascriptSource("gxcfg.js", "?202022711581376", false);
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" autocomplete=\"off\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("bas_tenant.aspx") +"\">") ;
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
         GxWebStd.gx_hidden_field( context, "Z360BAS_TenantTenantCode", Z360BAS_TenantTenantCode);
         GxWebStd.gx_hidden_field( context, "Z394TenantName", Z394TenantName);
         GxWebStd.gx_hidden_field( context, "Z395HospitalName", Z395HospitalName);
         GxWebStd.gx_hidden_field( context, "Z397BAS_TenantCreator", Z397BAS_TenantCreator);
         GxWebStd.gx_hidden_field( context, "Z398BAS_TenantCreateTime", context.localUtil.TToC( Z398BAS_TenantCreateTime, 10, 8, 0, 0, "/", ":", " "));
         GxWebStd.gx_hidden_field( context, "Z399BAS_TenantModifier", Z399BAS_TenantModifier);
         GxWebStd.gx_hidden_field( context, "Z400BAS_TenantModifyTime", context.localUtil.TToC( Z400BAS_TenantModifyTime, 10, 8, 0, 0, "/", ":", " "));
         GxWebStd.gx_hidden_field( context, "Z401BAS_TenantIsDeleted", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z401BAS_TenantIsDeleted), 1, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "Z358InstituteCode", Z358InstituteCode);
         GxWebStd.gx_hidden_field( context, "Z365DatabaseID", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z365DatabaseID), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "IsConfirmed", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsConfirmed), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "IsModified", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsModified), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "Mode", StringUtil.RTrim( Gx_mode));
         GxWebStd.gx_hidden_field( context, "vMODE", StringUtil.RTrim( Gx_mode));
         GXCCtlgxBlob = "BAS_TENANTLOGO" + "_gxBlob";
         GxWebStd.gx_hidden_field( context, GXCCtlgxBlob, A396BAS_TenantLogo);
         GxWebStd.gx_hidden_field( context, "BAS_TENANTLOGO_Filename", StringUtil.RTrim( edtBAS_TenantLogo_Filename));
         GxWebStd.gx_hidden_field( context, "BAS_TENANTLOGO_Filetype", StringUtil.RTrim( edtBAS_TenantLogo_Filetype));
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
         return formatLink("bas_tenant.aspx")  ;
      }

      public override String GetPgmname( )
      {
         return "BAS_Tenant" ;
      }

      public override String GetPgmdesc( )
      {
         return "BAS_Tenant" ;
      }

      protected void InitializeNonKey1F52( )
      {
         A394TenantName = "";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A394TenantName", A394TenantName);
         A358InstituteCode = "";
         n358InstituteCode = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A358InstituteCode", A358InstituteCode);
         n358InstituteCode = (String.IsNullOrEmpty(StringUtil.RTrim( A358InstituteCode)) ? true : false);
         A395HospitalName = "";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A395HospitalName", A395HospitalName);
         A365DatabaseID = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A365DatabaseID", StringUtil.LTrim( StringUtil.Str( (decimal)(A365DatabaseID), 9, 0)));
         A396BAS_TenantLogo = "";
         n396BAS_TenantLogo = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A396BAS_TenantLogo", A396BAS_TenantLogo);
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBAS_TenantLogo_Internalname, "URL", context.PathToRelativeUrl( A396BAS_TenantLogo), true);
         n396BAS_TenantLogo = (String.IsNullOrEmpty(StringUtil.RTrim( A396BAS_TenantLogo)) ? true : false);
         A397BAS_TenantCreator = "";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A397BAS_TenantCreator", A397BAS_TenantCreator);
         A398BAS_TenantCreateTime = (DateTime)(DateTime.MinValue);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A398BAS_TenantCreateTime", context.localUtil.TToC( A398BAS_TenantCreateTime, 10, 8, 0, 0, "/", ":", " "));
         A399BAS_TenantModifier = "";
         n399BAS_TenantModifier = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A399BAS_TenantModifier", A399BAS_TenantModifier);
         n399BAS_TenantModifier = (String.IsNullOrEmpty(StringUtil.RTrim( A399BAS_TenantModifier)) ? true : false);
         A400BAS_TenantModifyTime = (DateTime)(DateTime.MinValue);
         n400BAS_TenantModifyTime = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A400BAS_TenantModifyTime", context.localUtil.TToC( A400BAS_TenantModifyTime, 10, 8, 0, 0, "/", ":", " "));
         n400BAS_TenantModifyTime = ((DateTime.MinValue==A400BAS_TenantModifyTime) ? true : false);
         A401BAS_TenantIsDeleted = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A401BAS_TenantIsDeleted", StringUtil.Str( (decimal)(A401BAS_TenantIsDeleted), 1, 0));
         A402BAS_TenantDescription = "";
         n402BAS_TenantDescription = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A402BAS_TenantDescription", A402BAS_TenantDescription);
         n402BAS_TenantDescription = (String.IsNullOrEmpty(StringUtil.RTrim( A402BAS_TenantDescription)) ? true : false);
         Z394TenantName = "";
         Z395HospitalName = "";
         Z397BAS_TenantCreator = "";
         Z398BAS_TenantCreateTime = (DateTime)(DateTime.MinValue);
         Z399BAS_TenantModifier = "";
         Z400BAS_TenantModifyTime = (DateTime)(DateTime.MinValue);
         Z401BAS_TenantIsDeleted = 0;
         Z358InstituteCode = "";
         Z365DatabaseID = 0;
      }

      protected void InitAll1F52( )
      {
         A360BAS_TenantTenantCode = "";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A360BAS_TenantTenantCode", A360BAS_TenantTenantCode);
         InitializeNonKey1F52( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?202022711581385", true);
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
         context.AddJavascriptSource("bas_tenant.js", "?202022711581385", false);
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
         edtBAS_TenantTenantCode_Internalname = "BAS_TENANTTENANTCODE";
         edtTenantName_Internalname = "TENANTNAME";
         edtInstituteCode_Internalname = "INSTITUTECODE";
         edtHospitalName_Internalname = "HOSPITALNAME";
         edtDatabaseID_Internalname = "DATABASEID";
         edtBAS_TenantLogo_Internalname = "BAS_TENANTLOGO";
         edtBAS_TenantCreator_Internalname = "BAS_TENANTCREATOR";
         edtBAS_TenantCreateTime_Internalname = "BAS_TENANTCREATETIME";
         edtBAS_TenantModifier_Internalname = "BAS_TENANTMODIFIER";
         edtBAS_TenantModifyTime_Internalname = "BAS_TENANTMODIFYTIME";
         edtBAS_TenantIsDeleted_Internalname = "BAS_TENANTISDELETED";
         edtBAS_TenantDescription_Internalname = "BAS_TENANTDESCRIPTION";
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
         edtBAS_TenantLogo_Filename = "";
         Form.Headerrawhtml = "";
         Form.Background = "";
         Form.Textcolor = 0;
         Form.Backcolor = (int)(0xFFFFFF);
         Form.Caption = "BAS_Tenant";
         bttBtn_delete_Enabled = 1;
         bttBtn_delete_Visible = 1;
         bttBtn_cancel_Visible = 1;
         bttBtn_enter_Enabled = 1;
         bttBtn_enter_Visible = 1;
         edtBAS_TenantDescription_Enabled = 1;
         edtBAS_TenantIsDeleted_Jsonclick = "";
         edtBAS_TenantIsDeleted_Enabled = 1;
         edtBAS_TenantModifyTime_Jsonclick = "";
         edtBAS_TenantModifyTime_Enabled = 1;
         edtBAS_TenantModifier_Jsonclick = "";
         edtBAS_TenantModifier_Enabled = 1;
         edtBAS_TenantCreateTime_Jsonclick = "";
         edtBAS_TenantCreateTime_Enabled = 1;
         edtBAS_TenantCreator_Jsonclick = "";
         edtBAS_TenantCreator_Enabled = 1;
         edtBAS_TenantLogo_Jsonclick = "";
         edtBAS_TenantLogo_Parameters = "";
         edtBAS_TenantLogo_Contenttype = "";
         edtBAS_TenantLogo_Filetype = "";
         edtBAS_TenantLogo_Enabled = 1;
         edtDatabaseID_Jsonclick = "";
         edtDatabaseID_Enabled = 1;
         edtHospitalName_Enabled = 1;
         edtInstituteCode_Jsonclick = "";
         edtInstituteCode_Enabled = 1;
         edtTenantName_Enabled = 1;
         edtBAS_TenantTenantCode_Jsonclick = "";
         edtBAS_TenantTenantCode_Enabled = 1;
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
         GX_FocusControl = edtTenantName_Internalname;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         standaloneNotModal( ) ;
         standaloneModal( ) ;
         /* End function AfterKeyLoadScreen */
      }

      public void Valid_Bas_tenanttenantcode( String GX_Parm1 ,
                                              String GX_Parm2 ,
                                              String GX_Parm3 ,
                                              String GX_Parm4 ,
                                              String GX_Parm5 ,
                                              DateTime GX_Parm6 ,
                                              String GX_Parm7 ,
                                              DateTime GX_Parm8 ,
                                              short GX_Parm9 ,
                                              String GX_Parm10 ,
                                              String GX_Parm11 ,
                                              int GX_Parm12 )
      {
         A360BAS_TenantTenantCode = GX_Parm1;
         A394TenantName = GX_Parm2;
         A395HospitalName = GX_Parm3;
         A396BAS_TenantLogo = GX_Parm4;
         n396BAS_TenantLogo = false;
         A397BAS_TenantCreator = GX_Parm5;
         A398BAS_TenantCreateTime = GX_Parm6;
         A399BAS_TenantModifier = GX_Parm7;
         n399BAS_TenantModifier = false;
         A400BAS_TenantModifyTime = GX_Parm8;
         n400BAS_TenantModifyTime = false;
         A401BAS_TenantIsDeleted = GX_Parm9;
         A402BAS_TenantDescription = GX_Parm10;
         n402BAS_TenantDescription = false;
         A358InstituteCode = GX_Parm11;
         n358InstituteCode = false;
         A365DatabaseID = GX_Parm12;
         context.wbHandled = 1;
         AfterKeyLoadScreen( ) ;
         Draw( ) ;
         send_integrity_footer_hashes( ) ;
         dynload_actions( ) ;
         if ( AnyError == 1 )
         {
         }
         isValidOutput.Add(A394TenantName);
         isValidOutput.Add(A358InstituteCode);
         isValidOutput.Add(A395HospitalName);
         isValidOutput.Add(StringUtil.LTrim( StringUtil.NToC( (decimal)(A365DatabaseID), 9, 0, ".", "")));
         isValidOutput.Add(context.PathToRelativeUrl( A396BAS_TenantLogo));
         isValidOutput.Add(A396BAS_TenantLogo);
         isValidOutput.Add(A397BAS_TenantCreator);
         isValidOutput.Add(context.localUtil.TToC( A398BAS_TenantCreateTime, 10, 8, 0, 0, "/", ":", " "));
         isValidOutput.Add(A399BAS_TenantModifier);
         isValidOutput.Add(context.localUtil.TToC( A400BAS_TenantModifyTime, 10, 8, 0, 0, "/", ":", " "));
         isValidOutput.Add(StringUtil.LTrim( StringUtil.NToC( (decimal)(A401BAS_TenantIsDeleted), 1, 0, ".", "")));
         isValidOutput.Add(A402BAS_TenantDescription);
         isValidOutput.Add(edtBAS_TenantLogo_Filetype);
         isValidOutput.Add(edtBAS_TenantLogo_Filename);
         isValidOutput.Add(StringUtil.RTrim( Gx_mode));
         isValidOutput.Add(Z360BAS_TenantTenantCode);
         isValidOutput.Add(Z394TenantName);
         isValidOutput.Add(Z358InstituteCode);
         isValidOutput.Add(Z395HospitalName);
         isValidOutput.Add(StringUtil.LTrim( StringUtil.NToC( (decimal)(Z365DatabaseID), 9, 0, ".", "")));
         isValidOutput.Add(context.PathToRelativeUrl( Z396BAS_TenantLogo));
         isValidOutput.Add(Z397BAS_TenantCreator);
         isValidOutput.Add(context.localUtil.TToC( Z398BAS_TenantCreateTime, 10, 8, 0, 0, "/", ":", " "));
         isValidOutput.Add(Z399BAS_TenantModifier);
         isValidOutput.Add(context.localUtil.TToC( Z400BAS_TenantModifyTime, 10, 8, 0, 0, "/", ":", " "));
         isValidOutput.Add(StringUtil.LTrim( StringUtil.NToC( (decimal)(Z401BAS_TenantIsDeleted), 1, 0, ".", "")));
         isValidOutput.Add(Z402BAS_TenantDescription);
         isValidOutput.Add(bttBtn_delete_Enabled);
         isValidOutput.Add(bttBtn_enter_Enabled);
         isValidOutput.Add(context.GX_msglist.ToJavascriptSource());
         isValidOutput.Add(context.httpAjaxContext.ajax_rsp_get_hiddens( ));
         context.GX_webresponse.AddString(isValidOutput.ToJSonString());
         wbTemp = context.ResponseContentType( "application/json");
      }

      public void Valid_Institutecode( String GX_Parm1 )
      {
         A358InstituteCode = GX_Parm1;
         n358InstituteCode = false;
         /* Using cursor T001F19 */
         pr_datastore1.execute(16, new Object[] {n358InstituteCode, A358InstituteCode});
         if ( (pr_datastore1.getStatus(16) == 101) )
         {
            if ( ! ( String.IsNullOrEmpty(StringUtil.RTrim( A358InstituteCode)) ) )
            {
               GX_msglist.addItem("不匹配'BAS_Institute'", "ForeignKeyNotFound", 1, "INSTITUTECODE");
               AnyError = 1;
               GX_FocusControl = edtInstituteCode_Internalname;
            }
         }
         pr_datastore1.close(16);
         dynload_actions( ) ;
         isValidOutput.Add(context.GX_msglist.ToJavascriptSource());
         isValidOutput.Add(context.httpAjaxContext.ajax_rsp_get_hiddens( ));
         context.GX_webresponse.AddString(isValidOutput.ToJSonString());
         wbTemp = context.ResponseContentType( "application/json");
      }

      public void Valid_Databaseid( int GX_Parm1 )
      {
         A365DatabaseID = GX_Parm1;
         /* Using cursor T001F20 */
         pr_datastore1.execute(17, new Object[] {A365DatabaseID});
         if ( (pr_datastore1.getStatus(17) == 101) )
         {
            GX_msglist.addItem("不匹配'SYS_Database'", "ForeignKeyNotFound", 1, "DATABASEID");
            AnyError = 1;
            GX_FocusControl = edtDatabaseID_Internalname;
         }
         pr_datastore1.close(17);
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
         pr_datastore1.close(16);
         pr_datastore1.close(17);
      }

      public override void initialize( )
      {
         sPrefix = "";
         Z360BAS_TenantTenantCode = "";
         Z394TenantName = "";
         Z395HospitalName = "";
         Z397BAS_TenantCreator = "";
         Z398BAS_TenantCreateTime = (DateTime)(DateTime.MinValue);
         Z399BAS_TenantModifier = "";
         Z400BAS_TenantModifyTime = (DateTime)(DateTime.MinValue);
         Z358InstituteCode = "";
         scmdbuf = "";
         gxfirstwebparm = "";
         gxfirstwebparm_bkp = "";
         A358InstituteCode = "";
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
         A360BAS_TenantTenantCode = "";
         A394TenantName = "";
         A395HospitalName = "";
         gxblobfileaux = new GxFile(context.GetPhysicalPath());
         A396BAS_TenantLogo = "";
         A397BAS_TenantCreator = "";
         A398BAS_TenantCreateTime = (DateTime)(DateTime.MinValue);
         A399BAS_TenantModifier = "";
         A400BAS_TenantModifyTime = (DateTime)(DateTime.MinValue);
         A402BAS_TenantDescription = "";
         bttBtn_enter_Jsonclick = "";
         bttBtn_cancel_Jsonclick = "";
         bttBtn_delete_Jsonclick = "";
         Gx_mode = "";
         GXCCtlgxBlob = "";
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         Z396BAS_TenantLogo = "";
         Z402BAS_TenantDescription = "";
         T001F6_A360BAS_TenantTenantCode = new String[] {""} ;
         T001F6_A394TenantName = new String[] {""} ;
         T001F6_A395HospitalName = new String[] {""} ;
         T001F6_A397BAS_TenantCreator = new String[] {""} ;
         T001F6_A398BAS_TenantCreateTime = new DateTime[] {DateTime.MinValue} ;
         T001F6_A399BAS_TenantModifier = new String[] {""} ;
         T001F6_n399BAS_TenantModifier = new bool[] {false} ;
         T001F6_A400BAS_TenantModifyTime = new DateTime[] {DateTime.MinValue} ;
         T001F6_n400BAS_TenantModifyTime = new bool[] {false} ;
         T001F6_A401BAS_TenantIsDeleted = new short[1] ;
         T001F6_A402BAS_TenantDescription = new String[] {""} ;
         T001F6_n402BAS_TenantDescription = new bool[] {false} ;
         T001F6_A358InstituteCode = new String[] {""} ;
         T001F6_n358InstituteCode = new bool[] {false} ;
         T001F6_A365DatabaseID = new int[1] ;
         T001F6_A396BAS_TenantLogo = new String[] {""} ;
         T001F6_n396BAS_TenantLogo = new bool[] {false} ;
         T001F4_A358InstituteCode = new String[] {""} ;
         T001F4_n358InstituteCode = new bool[] {false} ;
         T001F5_A365DatabaseID = new int[1] ;
         T001F7_A358InstituteCode = new String[] {""} ;
         T001F7_n358InstituteCode = new bool[] {false} ;
         T001F8_A365DatabaseID = new int[1] ;
         T001F9_A360BAS_TenantTenantCode = new String[] {""} ;
         T001F3_A360BAS_TenantTenantCode = new String[] {""} ;
         T001F3_A394TenantName = new String[] {""} ;
         T001F3_A395HospitalName = new String[] {""} ;
         T001F3_A397BAS_TenantCreator = new String[] {""} ;
         T001F3_A398BAS_TenantCreateTime = new DateTime[] {DateTime.MinValue} ;
         T001F3_A399BAS_TenantModifier = new String[] {""} ;
         T001F3_n399BAS_TenantModifier = new bool[] {false} ;
         T001F3_A400BAS_TenantModifyTime = new DateTime[] {DateTime.MinValue} ;
         T001F3_n400BAS_TenantModifyTime = new bool[] {false} ;
         T001F3_A401BAS_TenantIsDeleted = new short[1] ;
         T001F3_A402BAS_TenantDescription = new String[] {""} ;
         T001F3_n402BAS_TenantDescription = new bool[] {false} ;
         T001F3_A358InstituteCode = new String[] {""} ;
         T001F3_n358InstituteCode = new bool[] {false} ;
         T001F3_A365DatabaseID = new int[1] ;
         T001F3_A396BAS_TenantLogo = new String[] {""} ;
         T001F3_n396BAS_TenantLogo = new bool[] {false} ;
         sMode52 = "";
         T001F10_A360BAS_TenantTenantCode = new String[] {""} ;
         T001F11_A360BAS_TenantTenantCode = new String[] {""} ;
         T001F2_A360BAS_TenantTenantCode = new String[] {""} ;
         T001F2_A394TenantName = new String[] {""} ;
         T001F2_A395HospitalName = new String[] {""} ;
         T001F2_A397BAS_TenantCreator = new String[] {""} ;
         T001F2_A398BAS_TenantCreateTime = new DateTime[] {DateTime.MinValue} ;
         T001F2_A399BAS_TenantModifier = new String[] {""} ;
         T001F2_n399BAS_TenantModifier = new bool[] {false} ;
         T001F2_A400BAS_TenantModifyTime = new DateTime[] {DateTime.MinValue} ;
         T001F2_n400BAS_TenantModifyTime = new bool[] {false} ;
         T001F2_A401BAS_TenantIsDeleted = new short[1] ;
         T001F2_A402BAS_TenantDescription = new String[] {""} ;
         T001F2_n402BAS_TenantDescription = new bool[] {false} ;
         T001F2_A358InstituteCode = new String[] {""} ;
         T001F2_n358InstituteCode = new bool[] {false} ;
         T001F2_A365DatabaseID = new int[1] ;
         T001F2_A396BAS_TenantLogo = new String[] {""} ;
         T001F2_n396BAS_TenantLogo = new bool[] {false} ;
         T001F16_A85BR_Information_ID = new long[1] ;
         T001F16_A360BAS_TenantTenantCode = new String[] {""} ;
         T001F17_A360BAS_TenantTenantCode = new String[] {""} ;
         T001F17_A359UserID = new Guid[] {Guid.Empty} ;
         T001F18_A360BAS_TenantTenantCode = new String[] {""} ;
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         isValidOutput = new GxUnknownObjectCollection();
         T001F19_A358InstituteCode = new String[] {""} ;
         T001F19_n358InstituteCode = new bool[] {false} ;
         T001F20_A365DatabaseID = new int[1] ;
         pr_datastore1 = new DataStoreProvider(context, new GeneXus.Programs.bas_tenant__datastore1(),
            new Object[][] {
                new Object[] {
               T001F2_A360BAS_TenantTenantCode, T001F2_A394TenantName, T001F2_A395HospitalName, T001F2_A397BAS_TenantCreator, T001F2_A398BAS_TenantCreateTime, T001F2_A399BAS_TenantModifier, T001F2_n399BAS_TenantModifier, T001F2_A400BAS_TenantModifyTime, T001F2_n400BAS_TenantModifyTime, T001F2_A401BAS_TenantIsDeleted,
               T001F2_A402BAS_TenantDescription, T001F2_n402BAS_TenantDescription, T001F2_A358InstituteCode, T001F2_n358InstituteCode, T001F2_A365DatabaseID, T001F2_A396BAS_TenantLogo, T001F2_n396BAS_TenantLogo
               }
               , new Object[] {
               T001F3_A360BAS_TenantTenantCode, T001F3_A394TenantName, T001F3_A395HospitalName, T001F3_A397BAS_TenantCreator, T001F3_A398BAS_TenantCreateTime, T001F3_A399BAS_TenantModifier, T001F3_n399BAS_TenantModifier, T001F3_A400BAS_TenantModifyTime, T001F3_n400BAS_TenantModifyTime, T001F3_A401BAS_TenantIsDeleted,
               T001F3_A402BAS_TenantDescription, T001F3_n402BAS_TenantDescription, T001F3_A358InstituteCode, T001F3_n358InstituteCode, T001F3_A365DatabaseID, T001F3_A396BAS_TenantLogo, T001F3_n396BAS_TenantLogo
               }
               , new Object[] {
               T001F4_A358InstituteCode
               }
               , new Object[] {
               T001F5_A365DatabaseID
               }
               , new Object[] {
               T001F6_A360BAS_TenantTenantCode, T001F6_A394TenantName, T001F6_A395HospitalName, T001F6_A397BAS_TenantCreator, T001F6_A398BAS_TenantCreateTime, T001F6_A399BAS_TenantModifier, T001F6_n399BAS_TenantModifier, T001F6_A400BAS_TenantModifyTime, T001F6_n400BAS_TenantModifyTime, T001F6_A401BAS_TenantIsDeleted,
               T001F6_A402BAS_TenantDescription, T001F6_n402BAS_TenantDescription, T001F6_A358InstituteCode, T001F6_n358InstituteCode, T001F6_A365DatabaseID, T001F6_A396BAS_TenantLogo, T001F6_n396BAS_TenantLogo
               }
               , new Object[] {
               T001F7_A358InstituteCode
               }
               , new Object[] {
               T001F8_A365DatabaseID
               }
               , new Object[] {
               T001F9_A360BAS_TenantTenantCode
               }
               , new Object[] {
               T001F10_A360BAS_TenantTenantCode
               }
               , new Object[] {
               T001F11_A360BAS_TenantTenantCode
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               T001F17_A360BAS_TenantTenantCode, T001F17_A359UserID
               }
               , new Object[] {
               T001F18_A360BAS_TenantTenantCode
               }
               , new Object[] {
               T001F19_A358InstituteCode
               }
               , new Object[] {
               T001F20_A365DatabaseID
               }
            }
         );
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.bas_tenant__default(),
            new Object[][] {
                new Object[] {
               T001F16_A85BR_Information_ID, T001F16_A360BAS_TenantTenantCode
               }
            }
         );
      }

      private short Z401BAS_TenantIsDeleted ;
      private short GxWebError ;
      private short gxcookieaux ;
      private short IsConfirmed ;
      private short IsModified ;
      private short AnyError ;
      private short nKeyPressed ;
      private short initialized ;
      private short A401BAS_TenantIsDeleted ;
      private short GX_JID ;
      private short RcdFound52 ;
      private short Gx_BScreen ;
      private short gxajaxcallmode ;
      private short wbTemp ;
      private int Z365DatabaseID ;
      private int A365DatabaseID ;
      private int trnEnded ;
      private int bttBtn_first_Visible ;
      private int bttBtn_previous_Visible ;
      private int bttBtn_next_Visible ;
      private int bttBtn_last_Visible ;
      private int bttBtn_select_Visible ;
      private int edtBAS_TenantTenantCode_Enabled ;
      private int edtTenantName_Enabled ;
      private int edtInstituteCode_Enabled ;
      private int edtHospitalName_Enabled ;
      private int edtDatabaseID_Enabled ;
      private int edtBAS_TenantLogo_Enabled ;
      private int edtBAS_TenantCreator_Enabled ;
      private int edtBAS_TenantCreateTime_Enabled ;
      private int edtBAS_TenantModifier_Enabled ;
      private int edtBAS_TenantModifyTime_Enabled ;
      private int edtBAS_TenantIsDeleted_Enabled ;
      private int edtBAS_TenantDescription_Enabled ;
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
      private String edtBAS_TenantTenantCode_Internalname ;
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
      private String edtBAS_TenantTenantCode_Jsonclick ;
      private String edtTenantName_Internalname ;
      private String edtInstituteCode_Internalname ;
      private String edtInstituteCode_Jsonclick ;
      private String edtHospitalName_Internalname ;
      private String edtDatabaseID_Internalname ;
      private String edtDatabaseID_Jsonclick ;
      private String edtBAS_TenantLogo_Internalname ;
      private String edtBAS_TenantLogo_Filetype ;
      private String edtBAS_TenantLogo_Contenttype ;
      private String edtBAS_TenantLogo_Parameters ;
      private String edtBAS_TenantLogo_Jsonclick ;
      private String edtBAS_TenantCreator_Internalname ;
      private String edtBAS_TenantCreator_Jsonclick ;
      private String edtBAS_TenantCreateTime_Internalname ;
      private String edtBAS_TenantCreateTime_Jsonclick ;
      private String edtBAS_TenantModifier_Internalname ;
      private String edtBAS_TenantModifier_Jsonclick ;
      private String edtBAS_TenantModifyTime_Internalname ;
      private String edtBAS_TenantModifyTime_Jsonclick ;
      private String edtBAS_TenantIsDeleted_Internalname ;
      private String edtBAS_TenantIsDeleted_Jsonclick ;
      private String edtBAS_TenantDescription_Internalname ;
      private String bttBtn_enter_Internalname ;
      private String bttBtn_enter_Jsonclick ;
      private String bttBtn_cancel_Internalname ;
      private String bttBtn_cancel_Jsonclick ;
      private String bttBtn_delete_Internalname ;
      private String bttBtn_delete_Jsonclick ;
      private String Gx_mode ;
      private String edtBAS_TenantLogo_Filename ;
      private String GXCCtlgxBlob ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String sMode52 ;
      private String sDynURL ;
      private String FormProcess ;
      private String bodyStyle ;
      private DateTime Z398BAS_TenantCreateTime ;
      private DateTime Z400BAS_TenantModifyTime ;
      private DateTime A398BAS_TenantCreateTime ;
      private DateTime A400BAS_TenantModifyTime ;
      private bool entryPointCalled ;
      private bool n358InstituteCode ;
      private bool toggleJsOutput ;
      private bool wbErr ;
      private bool n396BAS_TenantLogo ;
      private bool n399BAS_TenantModifier ;
      private bool n400BAS_TenantModifyTime ;
      private bool n402BAS_TenantDescription ;
      private bool Gx_longc ;
      private String A402BAS_TenantDescription ;
      private String Z402BAS_TenantDescription ;
      private String Z360BAS_TenantTenantCode ;
      private String Z394TenantName ;
      private String Z395HospitalName ;
      private String Z397BAS_TenantCreator ;
      private String Z399BAS_TenantModifier ;
      private String Z358InstituteCode ;
      private String A358InstituteCode ;
      private String A360BAS_TenantTenantCode ;
      private String A394TenantName ;
      private String A395HospitalName ;
      private String A397BAS_TenantCreator ;
      private String A399BAS_TenantModifier ;
      private String A396BAS_TenantLogo ;
      private String Z396BAS_TenantLogo ;
      private GxUnknownObjectCollection isValidOutput ;
      private GxFile gxblobfileaux ;
      private IGxDataStore dsDataStore1 ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_datastore1 ;
      private String[] T001F6_A360BAS_TenantTenantCode ;
      private String[] T001F6_A394TenantName ;
      private String[] T001F6_A395HospitalName ;
      private String[] T001F6_A397BAS_TenantCreator ;
      private DateTime[] T001F6_A398BAS_TenantCreateTime ;
      private String[] T001F6_A399BAS_TenantModifier ;
      private bool[] T001F6_n399BAS_TenantModifier ;
      private DateTime[] T001F6_A400BAS_TenantModifyTime ;
      private bool[] T001F6_n400BAS_TenantModifyTime ;
      private short[] T001F6_A401BAS_TenantIsDeleted ;
      private String[] T001F6_A402BAS_TenantDescription ;
      private bool[] T001F6_n402BAS_TenantDescription ;
      private String[] T001F6_A358InstituteCode ;
      private bool[] T001F6_n358InstituteCode ;
      private int[] T001F6_A365DatabaseID ;
      private String[] T001F6_A396BAS_TenantLogo ;
      private bool[] T001F6_n396BAS_TenantLogo ;
      private String[] T001F4_A358InstituteCode ;
      private bool[] T001F4_n358InstituteCode ;
      private int[] T001F5_A365DatabaseID ;
      private String[] T001F7_A358InstituteCode ;
      private bool[] T001F7_n358InstituteCode ;
      private int[] T001F8_A365DatabaseID ;
      private String[] T001F9_A360BAS_TenantTenantCode ;
      private String[] T001F3_A360BAS_TenantTenantCode ;
      private String[] T001F3_A394TenantName ;
      private String[] T001F3_A395HospitalName ;
      private String[] T001F3_A397BAS_TenantCreator ;
      private DateTime[] T001F3_A398BAS_TenantCreateTime ;
      private String[] T001F3_A399BAS_TenantModifier ;
      private bool[] T001F3_n399BAS_TenantModifier ;
      private DateTime[] T001F3_A400BAS_TenantModifyTime ;
      private bool[] T001F3_n400BAS_TenantModifyTime ;
      private short[] T001F3_A401BAS_TenantIsDeleted ;
      private String[] T001F3_A402BAS_TenantDescription ;
      private bool[] T001F3_n402BAS_TenantDescription ;
      private String[] T001F3_A358InstituteCode ;
      private bool[] T001F3_n358InstituteCode ;
      private int[] T001F3_A365DatabaseID ;
      private String[] T001F3_A396BAS_TenantLogo ;
      private bool[] T001F3_n396BAS_TenantLogo ;
      private String[] T001F10_A360BAS_TenantTenantCode ;
      private String[] T001F11_A360BAS_TenantTenantCode ;
      private String[] T001F2_A360BAS_TenantTenantCode ;
      private String[] T001F2_A394TenantName ;
      private String[] T001F2_A395HospitalName ;
      private String[] T001F2_A397BAS_TenantCreator ;
      private DateTime[] T001F2_A398BAS_TenantCreateTime ;
      private String[] T001F2_A399BAS_TenantModifier ;
      private bool[] T001F2_n399BAS_TenantModifier ;
      private DateTime[] T001F2_A400BAS_TenantModifyTime ;
      private bool[] T001F2_n400BAS_TenantModifyTime ;
      private short[] T001F2_A401BAS_TenantIsDeleted ;
      private String[] T001F2_A402BAS_TenantDescription ;
      private bool[] T001F2_n402BAS_TenantDescription ;
      private String[] T001F2_A358InstituteCode ;
      private bool[] T001F2_n358InstituteCode ;
      private int[] T001F2_A365DatabaseID ;
      private String[] T001F2_A396BAS_TenantLogo ;
      private bool[] T001F2_n396BAS_TenantLogo ;
      private IDataStoreProvider pr_default ;
      private long[] T001F16_A85BR_Information_ID ;
      private String[] T001F16_A360BAS_TenantTenantCode ;
      private String[] T001F17_A360BAS_TenantTenantCode ;
      private Guid[] T001F17_A359UserID ;
      private String[] T001F18_A360BAS_TenantTenantCode ;
      private String[] T001F19_A358InstituteCode ;
      private bool[] T001F19_n358InstituteCode ;
      private int[] T001F20_A365DatabaseID ;
      private GXWebForm Form ;
   }

   public class bas_tenant__datastore1 : DataStoreHelperBase, IDataStoreHelper
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
         ,new UpdateCursor(def[12])
         ,new UpdateCursor(def[13])
         ,new ForEachCursor(def[14])
         ,new ForEachCursor(def[15])
         ,new ForEachCursor(def[16])
         ,new ForEachCursor(def[17])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmT001F6 ;
          prmT001F6 = new Object[] {
          new Object[] {"@BAS_TenantTenantCode",SqlDbType.NVarChar,20,0}
          } ;
          Object[] prmT001F4 ;
          prmT001F4 = new Object[] {
          new Object[] {"@InstituteCode",SqlDbType.NVarChar,20,0}
          } ;
          Object[] prmT001F5 ;
          prmT001F5 = new Object[] {
          new Object[] {"@DatabaseID",SqlDbType.Int,9,0}
          } ;
          Object[] prmT001F7 ;
          prmT001F7 = new Object[] {
          new Object[] {"@InstituteCode",SqlDbType.NVarChar,20,0}
          } ;
          Object[] prmT001F8 ;
          prmT001F8 = new Object[] {
          new Object[] {"@DatabaseID",SqlDbType.Int,9,0}
          } ;
          Object[] prmT001F9 ;
          prmT001F9 = new Object[] {
          new Object[] {"@BAS_TenantTenantCode",SqlDbType.NVarChar,20,0}
          } ;
          Object[] prmT001F3 ;
          prmT001F3 = new Object[] {
          new Object[] {"@BAS_TenantTenantCode",SqlDbType.NVarChar,20,0}
          } ;
          Object[] prmT001F10 ;
          prmT001F10 = new Object[] {
          new Object[] {"@BAS_TenantTenantCode",SqlDbType.NVarChar,20,0}
          } ;
          Object[] prmT001F11 ;
          prmT001F11 = new Object[] {
          new Object[] {"@BAS_TenantTenantCode",SqlDbType.NVarChar,20,0}
          } ;
          Object[] prmT001F2 ;
          prmT001F2 = new Object[] {
          new Object[] {"@BAS_TenantTenantCode",SqlDbType.NVarChar,20,0}
          } ;
          Object[] prmT001F12 ;
          prmT001F12 = new Object[] {
          new Object[] {"@BAS_TenantTenantCode",SqlDbType.NVarChar,20,0} ,
          new Object[] {"@TenantName",SqlDbType.NVarChar,200,0} ,
          new Object[] {"@HospitalName",SqlDbType.NVarChar,200,0} ,
          new Object[] {"@BAS_TenantLogo",SqlDbType.VarBinary,1024,0} ,
          new Object[] {"@BAS_TenantCreator",SqlDbType.NVarChar,50,0} ,
          new Object[] {"@BAS_TenantCreateTime",SqlDbType.DateTime,10,8} ,
          new Object[] {"@BAS_TenantModifier",SqlDbType.NVarChar,50,0} ,
          new Object[] {"@BAS_TenantModifyTime",SqlDbType.DateTime,10,8} ,
          new Object[] {"@BAS_TenantIsDeleted",SqlDbType.SmallInt,1,0} ,
          new Object[] {"@BAS_TenantDescription",SqlDbType.NVarChar,2048,0} ,
          new Object[] {"@InstituteCode",SqlDbType.NVarChar,20,0} ,
          new Object[] {"@DatabaseID",SqlDbType.Int,9,0}
          } ;
          Object[] prmT001F13 ;
          prmT001F13 = new Object[] {
          new Object[] {"@TenantName",SqlDbType.NVarChar,200,0} ,
          new Object[] {"@HospitalName",SqlDbType.NVarChar,200,0} ,
          new Object[] {"@BAS_TenantCreator",SqlDbType.NVarChar,50,0} ,
          new Object[] {"@BAS_TenantCreateTime",SqlDbType.DateTime,10,8} ,
          new Object[] {"@BAS_TenantModifier",SqlDbType.NVarChar,50,0} ,
          new Object[] {"@BAS_TenantModifyTime",SqlDbType.DateTime,10,8} ,
          new Object[] {"@BAS_TenantIsDeleted",SqlDbType.SmallInt,1,0} ,
          new Object[] {"@BAS_TenantDescription",SqlDbType.NVarChar,2048,0} ,
          new Object[] {"@InstituteCode",SqlDbType.NVarChar,20,0} ,
          new Object[] {"@DatabaseID",SqlDbType.Int,9,0} ,
          new Object[] {"@BAS_TenantTenantCode",SqlDbType.NVarChar,20,0}
          } ;
          Object[] prmT001F14 ;
          prmT001F14 = new Object[] {
          new Object[] {"@BAS_TenantLogo",SqlDbType.VarBinary,1024,0} ,
          new Object[] {"@BAS_TenantTenantCode",SqlDbType.NVarChar,20,0}
          } ;
          Object[] prmT001F15 ;
          prmT001F15 = new Object[] {
          new Object[] {"@BAS_TenantTenantCode",SqlDbType.NVarChar,20,0}
          } ;
          Object[] prmT001F17 ;
          prmT001F17 = new Object[] {
          new Object[] {"@BAS_TenantTenantCode",SqlDbType.NVarChar,20,0}
          } ;
          Object[] prmT001F18 ;
          prmT001F18 = new Object[] {
          } ;
          Object[] prmT001F19 ;
          prmT001F19 = new Object[] {
          new Object[] {"@InstituteCode",SqlDbType.NVarChar,20,0}
          } ;
          Object[] prmT001F20 ;
          prmT001F20 = new Object[] {
          new Object[] {"@DatabaseID",SqlDbType.Int,9,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("T001F2", "SELECT [TenantCode] AS BAS_TenantTenantCode, [TenantName], [HospitalName], [Creator] AS BAS_TenantCreator, [CreateTime] AS BAS_TenantCreateTime, [Modifier] AS BAS_TenantModifier, [ModifyTime] AS BAS_TenantModifyTime, [IsDeleted] AS BAS_TenantIsDeleted, [Description] AS BAS_TenantDescription, [InstituteCode], [DatabaseID], [Logo] AS BAS_TenantLogo FROM dbo.[BAS_Tenant] WITH (UPDLOCK) WHERE [TenantCode] = @BAS_TenantTenantCode ",true, GxErrorMask.GX_NOMASK, false, this,prmT001F2,1,0,true,false )
             ,new CursorDef("T001F3", "SELECT [TenantCode] AS BAS_TenantTenantCode, [TenantName], [HospitalName], [Creator] AS BAS_TenantCreator, [CreateTime] AS BAS_TenantCreateTime, [Modifier] AS BAS_TenantModifier, [ModifyTime] AS BAS_TenantModifyTime, [IsDeleted] AS BAS_TenantIsDeleted, [Description] AS BAS_TenantDescription, [InstituteCode], [DatabaseID], [Logo] AS BAS_TenantLogo FROM dbo.[BAS_Tenant] WITH (NOLOCK) WHERE [TenantCode] = @BAS_TenantTenantCode ",true, GxErrorMask.GX_NOMASK, false, this,prmT001F3,1,0,true,false )
             ,new CursorDef("T001F4", "SELECT [InstituteCode] FROM dbo.[BAS_Institute] WITH (NOLOCK) WHERE [InstituteCode] = @InstituteCode ",true, GxErrorMask.GX_NOMASK, false, this,prmT001F4,1,0,true,false )
             ,new CursorDef("T001F5", "SELECT [DatabaseID] FROM dbo.[SYS_Database] WITH (NOLOCK) WHERE [DatabaseID] = @DatabaseID ",true, GxErrorMask.GX_NOMASK, false, this,prmT001F5,1,0,true,false )
             ,new CursorDef("T001F6", "SELECT TM1.[TenantCode] AS BAS_TenantTenantCode, TM1.[TenantName], TM1.[HospitalName], TM1.[Creator] AS BAS_TenantCreator, TM1.[CreateTime] AS BAS_TenantCreateTime, TM1.[Modifier] AS BAS_TenantModifier, TM1.[ModifyTime] AS BAS_TenantModifyTime, TM1.[IsDeleted] AS BAS_TenantIsDeleted, TM1.[Description] AS BAS_TenantDescription, TM1.[InstituteCode], TM1.[DatabaseID], TM1.[Logo] AS BAS_TenantLogo FROM dbo.[BAS_Tenant] TM1 WITH (NOLOCK) WHERE TM1.[TenantCode] = @BAS_TenantTenantCode ORDER BY TM1.[TenantCode]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT001F6,100,0,true,false )
             ,new CursorDef("T001F7", "SELECT [InstituteCode] FROM dbo.[BAS_Institute] WITH (NOLOCK) WHERE [InstituteCode] = @InstituteCode ",true, GxErrorMask.GX_NOMASK, false, this,prmT001F7,1,0,true,false )
             ,new CursorDef("T001F8", "SELECT [DatabaseID] FROM dbo.[SYS_Database] WITH (NOLOCK) WHERE [DatabaseID] = @DatabaseID ",true, GxErrorMask.GX_NOMASK, false, this,prmT001F8,1,0,true,false )
             ,new CursorDef("T001F9", "SELECT [TenantCode] AS BAS_TenantTenantCode FROM dbo.[BAS_Tenant] WITH (NOLOCK) WHERE [TenantCode] = @BAS_TenantTenantCode  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT001F9,1,0,true,false )
             ,new CursorDef("T001F10", "SELECT TOP 1 [TenantCode] AS BAS_TenantTenantCode FROM dbo.[BAS_Tenant] WITH (NOLOCK) WHERE ( [TenantCode] > @BAS_TenantTenantCode) ORDER BY [TenantCode]  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT001F10,1,0,true,true )
             ,new CursorDef("T001F11", "SELECT TOP 1 [TenantCode] AS BAS_TenantTenantCode FROM dbo.[BAS_Tenant] WITH (NOLOCK) WHERE ( [TenantCode] < @BAS_TenantTenantCode) ORDER BY [TenantCode] DESC  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT001F11,1,0,true,true )
             ,new CursorDef("T001F12", "INSERT INTO dbo.[BAS_Tenant]([TenantCode], [TenantName], [HospitalName], [Logo], [Creator], [CreateTime], [Modifier], [ModifyTime], [IsDeleted], [Description], [InstituteCode], [DatabaseID]) VALUES(@BAS_TenantTenantCode, @TenantName, @HospitalName, @BAS_TenantLogo, @BAS_TenantCreator, @BAS_TenantCreateTime, @BAS_TenantModifier, @BAS_TenantModifyTime, @BAS_TenantIsDeleted, @BAS_TenantDescription, @InstituteCode, @DatabaseID)", GxErrorMask.GX_NOMASK,prmT001F12)
             ,new CursorDef("T001F13", "UPDATE dbo.[BAS_Tenant] SET [TenantName]=@TenantName, [HospitalName]=@HospitalName, [Creator]=@BAS_TenantCreator, [CreateTime]=@BAS_TenantCreateTime, [Modifier]=@BAS_TenantModifier, [ModifyTime]=@BAS_TenantModifyTime, [IsDeleted]=@BAS_TenantIsDeleted, [Description]=@BAS_TenantDescription, [InstituteCode]=@InstituteCode, [DatabaseID]=@DatabaseID  WHERE [TenantCode] = @BAS_TenantTenantCode", GxErrorMask.GX_NOMASK,prmT001F13)
             ,new CursorDef("T001F14", "UPDATE dbo.[BAS_Tenant] SET [Logo]=@BAS_TenantLogo  WHERE [TenantCode] = @BAS_TenantTenantCode", GxErrorMask.GX_NOMASK,prmT001F14)
             ,new CursorDef("T001F15", "DELETE FROM dbo.[BAS_Tenant]  WHERE [TenantCode] = @BAS_TenantTenantCode", GxErrorMask.GX_NOMASK,prmT001F15)
             ,new CursorDef("T001F17", "SELECT TOP 1 [TenantCode] AS BAS_TenantTenantCode, [UserID] FROM dbo.[SYS_TenantUser] WITH (NOLOCK) WHERE [TenantCode] = @BAS_TenantTenantCode ",true, GxErrorMask.GX_NOMASK, false, this,prmT001F17,1,0,true,true )
             ,new CursorDef("T001F18", "SELECT [TenantCode] AS BAS_TenantTenantCode FROM dbo.[BAS_Tenant] WITH (NOLOCK) ORDER BY [TenantCode]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT001F18,100,0,true,false )
             ,new CursorDef("T001F19", "SELECT [InstituteCode] FROM dbo.[BAS_Institute] WITH (NOLOCK) WHERE [InstituteCode] = @InstituteCode ",true, GxErrorMask.GX_NOMASK, false, this,prmT001F19,1,0,true,false )
             ,new CursorDef("T001F20", "SELECT [DatabaseID] FROM dbo.[SYS_Database] WITH (NOLOCK) WHERE [DatabaseID] = @DatabaseID ",true, GxErrorMask.GX_NOMASK, false, this,prmT001F20,1,0,true,false )
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
                ((String[]) buf[2])[0] = rslt.getVarchar(3) ;
                ((String[]) buf[3])[0] = rslt.getVarchar(4) ;
                ((DateTime[]) buf[4])[0] = rslt.getGXDateTime(5) ;
                ((String[]) buf[5])[0] = rslt.getVarchar(6) ;
                ((bool[]) buf[6])[0] = rslt.wasNull(6);
                ((DateTime[]) buf[7])[0] = rslt.getGXDateTime(7) ;
                ((bool[]) buf[8])[0] = rslt.wasNull(7);
                ((short[]) buf[9])[0] = rslt.getShort(8) ;
                ((String[]) buf[10])[0] = rslt.getLongVarchar(9) ;
                ((bool[]) buf[11])[0] = rslt.wasNull(9);
                ((String[]) buf[12])[0] = rslt.getVarchar(10) ;
                ((bool[]) buf[13])[0] = rslt.wasNull(10);
                ((int[]) buf[14])[0] = rslt.getInt(11) ;
                ((String[]) buf[15])[0] = rslt.getBLOBFile(12, "tmp", "") ;
                ((bool[]) buf[16])[0] = rslt.wasNull(12);
                return;
             case 1 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((String[]) buf[2])[0] = rslt.getVarchar(3) ;
                ((String[]) buf[3])[0] = rslt.getVarchar(4) ;
                ((DateTime[]) buf[4])[0] = rslt.getGXDateTime(5) ;
                ((String[]) buf[5])[0] = rslt.getVarchar(6) ;
                ((bool[]) buf[6])[0] = rslt.wasNull(6);
                ((DateTime[]) buf[7])[0] = rslt.getGXDateTime(7) ;
                ((bool[]) buf[8])[0] = rslt.wasNull(7);
                ((short[]) buf[9])[0] = rslt.getShort(8) ;
                ((String[]) buf[10])[0] = rslt.getLongVarchar(9) ;
                ((bool[]) buf[11])[0] = rslt.wasNull(9);
                ((String[]) buf[12])[0] = rslt.getVarchar(10) ;
                ((bool[]) buf[13])[0] = rslt.wasNull(10);
                ((int[]) buf[14])[0] = rslt.getInt(11) ;
                ((String[]) buf[15])[0] = rslt.getBLOBFile(12, "tmp", "") ;
                ((bool[]) buf[16])[0] = rslt.wasNull(12);
                return;
             case 2 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                return;
             case 3 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                return;
             case 4 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((String[]) buf[2])[0] = rslt.getVarchar(3) ;
                ((String[]) buf[3])[0] = rslt.getVarchar(4) ;
                ((DateTime[]) buf[4])[0] = rslt.getGXDateTime(5) ;
                ((String[]) buf[5])[0] = rslt.getVarchar(6) ;
                ((bool[]) buf[6])[0] = rslt.wasNull(6);
                ((DateTime[]) buf[7])[0] = rslt.getGXDateTime(7) ;
                ((bool[]) buf[8])[0] = rslt.wasNull(7);
                ((short[]) buf[9])[0] = rslt.getShort(8) ;
                ((String[]) buf[10])[0] = rslt.getLongVarchar(9) ;
                ((bool[]) buf[11])[0] = rslt.wasNull(9);
                ((String[]) buf[12])[0] = rslt.getVarchar(10) ;
                ((bool[]) buf[13])[0] = rslt.wasNull(10);
                ((int[]) buf[14])[0] = rslt.getInt(11) ;
                ((String[]) buf[15])[0] = rslt.getBLOBFile(12, "tmp", "") ;
                ((bool[]) buf[16])[0] = rslt.wasNull(12);
                return;
             case 5 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                return;
             case 6 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                return;
             case 7 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                return;
             case 8 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                return;
             case 9 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                return;
             case 14 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((Guid[]) buf[1])[0] = rslt.getGuid(2) ;
                return;
             case 15 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                return;
             case 16 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                return;
             case 17 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
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
                if ( (bool)parms[0] )
                {
                   stmt.setNull( 1 , SqlDbType.NVarChar );
                }
                else
                {
                   stmt.SetParameter(1, (String)parms[1]);
                }
                return;
             case 3 :
                stmt.SetParameter(1, (int)parms[0]);
                return;
             case 4 :
                stmt.SetParameter(1, (String)parms[0]);
                return;
             case 5 :
                if ( (bool)parms[0] )
                {
                   stmt.setNull( 1 , SqlDbType.NVarChar );
                }
                else
                {
                   stmt.SetParameter(1, (String)parms[1]);
                }
                return;
             case 6 :
                stmt.SetParameter(1, (int)parms[0]);
                return;
             case 7 :
                stmt.SetParameter(1, (String)parms[0]);
                return;
             case 8 :
                stmt.SetParameter(1, (String)parms[0]);
                return;
             case 9 :
                stmt.SetParameter(1, (String)parms[0]);
                return;
             case 10 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                stmt.SetParameter(3, (String)parms[2]);
                if ( (bool)parms[3] )
                {
                   stmt.setNull( 4 , SqlDbType.VarBinary );
                }
                else
                {
                   stmt.SetParameterBlob(4, (String)parms[4], true);
                }
                stmt.SetParameter(5, (String)parms[5]);
                stmt.SetParameterDatetime(6, (DateTime)parms[6]);
                if ( (bool)parms[7] )
                {
                   stmt.setNull( 7 , SqlDbType.NVarChar );
                }
                else
                {
                   stmt.SetParameter(7, (String)parms[8]);
                }
                if ( (bool)parms[9] )
                {
                   stmt.setNull( 8 , SqlDbType.DateTime );
                }
                else
                {
                   stmt.SetParameterDatetime(8, (DateTime)parms[10]);
                }
                stmt.SetParameter(9, (short)parms[11]);
                if ( (bool)parms[12] )
                {
                   stmt.setNull( 10 , SqlDbType.NVarChar );
                }
                else
                {
                   stmt.SetParameter(10, (String)parms[13]);
                }
                if ( (bool)parms[14] )
                {
                   stmt.setNull( 11 , SqlDbType.NVarChar );
                }
                else
                {
                   stmt.SetParameter(11, (String)parms[15]);
                }
                stmt.SetParameter(12, (int)parms[16]);
                return;
             case 11 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                stmt.SetParameter(3, (String)parms[2]);
                stmt.SetParameterDatetime(4, (DateTime)parms[3]);
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
                stmt.SetParameter(7, (short)parms[8]);
                if ( (bool)parms[9] )
                {
                   stmt.setNull( 8 , SqlDbType.NVarChar );
                }
                else
                {
                   stmt.SetParameter(8, (String)parms[10]);
                }
                if ( (bool)parms[11] )
                {
                   stmt.setNull( 9 , SqlDbType.NVarChar );
                }
                else
                {
                   stmt.SetParameter(9, (String)parms[12]);
                }
                stmt.SetParameter(10, (int)parms[13]);
                stmt.SetParameter(11, (String)parms[14]);
                return;
             case 12 :
                if ( (bool)parms[0] )
                {
                   stmt.setNull( 1 , SqlDbType.VarBinary );
                }
                else
                {
                   stmt.SetParameterBlob(1, (String)parms[1], true);
                }
                stmt.SetParameter(2, (String)parms[2]);
                return;
             case 13 :
                stmt.SetParameter(1, (String)parms[0]);
                return;
             case 14 :
                stmt.SetParameter(1, (String)parms[0]);
                return;
             case 16 :
                if ( (bool)parms[0] )
                {
                   stmt.setNull( 1 , SqlDbType.NVarChar );
                }
                else
                {
                   stmt.SetParameter(1, (String)parms[1]);
                }
                return;
             case 17 :
                stmt.SetParameter(1, (int)parms[0]);
                return;
       }
    }

    public String getDataStoreName( )
    {
       return "DATASTORE1";
    }

 }

 public class bas_tenant__default : DataStoreHelperBase, IDataStoreHelper
 {
    public ICursor[] getCursors( )
    {
       cursorDefinitions();
       return new Cursor[] {
        new ForEachCursor(def[0])
     };
  }

  private static CursorDef[] def;
  private void cursorDefinitions( )
  {
     if ( def == null )
     {
        Object[] prmT001F16 ;
        prmT001F16 = new Object[] {
        new Object[] {"@BAS_TenantTenantCode",SqlDbType.NVarChar,20,0}
        } ;
        def= new CursorDef[] {
            new CursorDef("T001F16", "SELECT TOP 1 [BR_Information_ID], [BAS_TenantTenantCode] AS BAS_TenantTenantCode FROM [BR_PatientReTenant] WITH (NOLOCK) WHERE [BAS_TenantTenantCode] = @BAS_TenantTenantCode ",true, GxErrorMask.GX_NOMASK, false, this,prmT001F16,1,0,true,true )
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
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
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
              stmt.SetParameter(1, (String)parms[0]);
              return;
     }
  }

}

}
