/*
               File: BAS_Institute
        Description: BAS_Institute
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/27/2020 9:39:2.78
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
   public class bas_institute : GXDataArea, System.Web.SessionState.IRequiresSessionState
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
            Form.Meta.addItem("description", "BAS_Institute", 0) ;
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

      public bas_institute( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public bas_institute( IGxContext context )
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
            GxWebStd.gx_label_ctrl( context, lblTitle_Internalname, "BAS_Institute", "", "", lblTitle_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Title", 0, "", 1, 1, 0, "HLP_BAS_Institute.htm");
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
            GxWebStd.gx_button_ctrl( context, bttBtn_first_Internalname, "", "|<", bttBtn_first_Jsonclick, 5, "|<", "", StyleString, ClassString, bttBtn_first_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"EFIRST."+"'", TempTags, "", context.GetButtonType( ), "HLP_BAS_Institute.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 14,'',false,'',0)\"";
            ClassString = "BtnPrevious";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_previous_Internalname, "", "<", bttBtn_previous_Jsonclick, 5, "<", "", StyleString, ClassString, bttBtn_previous_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"EPREVIOUS."+"'", TempTags, "", context.GetButtonType( ), "HLP_BAS_Institute.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 16,'',false,'',0)\"";
            ClassString = "BtnNext";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_next_Internalname, "", ">", bttBtn_next_Jsonclick, 5, ">", "", StyleString, ClassString, bttBtn_next_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ENEXT."+"'", TempTags, "", context.GetButtonType( ), "HLP_BAS_Institute.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 18,'',false,'',0)\"";
            ClassString = "BtnLast";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_last_Internalname, "", ">|", bttBtn_last_Jsonclick, 5, ">|", "", StyleString, ClassString, bttBtn_last_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ELAST."+"'", TempTags, "", context.GetButtonType( ), "HLP_BAS_Institute.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 20,'',false,'',0)\"";
            ClassString = "BtnSelect";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_select_Internalname, "", "选择", bttBtn_select_Jsonclick, 5, "选择", "", StyleString, ClassString, bttBtn_select_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ESELECT."+"'", TempTags, "", 2, "HLP_BAS_Institute.htm");
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
            GxWebStd.gx_single_line_edit( context, edtInstituteCode_Internalname, A358InstituteCode, StringUtil.RTrim( context.localUtil.Format( A358InstituteCode, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,28);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtInstituteCode_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtInstituteCode_Enabled, 0, "text", "", 20, "chr", 1, "row", 20, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_BAS_Institute.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtInstituteName_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtInstituteName_Internalname, "Institute Name", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 33,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtInstituteName_Internalname, A386InstituteName, StringUtil.RTrim( context.localUtil.Format( A386InstituteName, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,33);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtInstituteName_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtInstituteName_Enabled, 0, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_BAS_Institute.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtBAS_InstituteLogo_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtBAS_InstituteLogo_Internalname, "Logo", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            ClassString = "Attribute";
            StyleString = "";
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 38,'',false,'',0)\"";
            edtBAS_InstituteLogo_Filetype = "tmp";
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBAS_InstituteLogo_Internalname, "Filetype", edtBAS_InstituteLogo_Filetype, true);
            if ( ! String.IsNullOrEmpty(StringUtil.RTrim( A387BAS_InstituteLogo)) )
            {
               gxblobfileaux.Source = A387BAS_InstituteLogo;
               if ( ! gxblobfileaux.HasExtension() || ( StringUtil.StrCmp(edtBAS_InstituteLogo_Filetype, "tmp") != 0 ) )
               {
                  gxblobfileaux.SetExtension(StringUtil.Trim( edtBAS_InstituteLogo_Filetype));
               }
               if ( gxblobfileaux.ErrCode == 0 )
               {
                  A387BAS_InstituteLogo = gxblobfileaux.GetURI();
                  n387BAS_InstituteLogo = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A387BAS_InstituteLogo", A387BAS_InstituteLogo);
                  context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBAS_InstituteLogo_Internalname, "URL", context.PathToRelativeUrl( A387BAS_InstituteLogo), true);
                  edtBAS_InstituteLogo_Filetype = gxblobfileaux.GetExtension();
                  context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBAS_InstituteLogo_Internalname, "Filetype", edtBAS_InstituteLogo_Filetype, true);
               }
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBAS_InstituteLogo_Internalname, "URL", context.PathToRelativeUrl( A387BAS_InstituteLogo), true);
            }
            GxWebStd.gx_blob_field( context, edtBAS_InstituteLogo_Internalname, StringUtil.RTrim( A387BAS_InstituteLogo), context.PathToRelativeUrl( A387BAS_InstituteLogo), (String.IsNullOrEmpty(StringUtil.RTrim( edtBAS_InstituteLogo_Contenttype)) ? context.GetContentType( (String.IsNullOrEmpty(StringUtil.RTrim( edtBAS_InstituteLogo_Filetype)) ? A387BAS_InstituteLogo : edtBAS_InstituteLogo_Filetype)) : edtBAS_InstituteLogo_Contenttype), false, "", edtBAS_InstituteLogo_Parameters, 0, edtBAS_InstituteLogo_Enabled, 1, "", "", 0, -1, 250, "px", 60, "px", 0, 0, 0, edtBAS_InstituteLogo_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", StyleString, ClassString, "", "", ""+TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,38);\"", "", "", "HLP_BAS_Institute.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtBAS_InstituteCreator_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtBAS_InstituteCreator_Internalname, "Creator", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 43,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtBAS_InstituteCreator_Internalname, A388BAS_InstituteCreator, StringUtil.RTrim( context.localUtil.Format( A388BAS_InstituteCreator, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,43);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBAS_InstituteCreator_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtBAS_InstituteCreator_Enabled, 0, "text", "", 50, "chr", 1, "row", 50, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_BAS_Institute.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtBAS_InstituteCreateTime_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtBAS_InstituteCreateTime_Internalname, "Create Time", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 48,'',false,'',0)\"";
            context.WriteHtmlText( "<div id=\""+edtBAS_InstituteCreateTime_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtBAS_InstituteCreateTime_Internalname, context.localUtil.TToC( A389BAS_InstituteCreateTime, 10, 8, 0, 0, "/", ":", " "), context.localUtil.Format( A389BAS_InstituteCreateTime, "9999/99/99 99:99:99"), TempTags+" onchange=\""+"gx.date.valid_date(this, 10,'YMD',8,24,'chs',false,1);"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,48);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBAS_InstituteCreateTime_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtBAS_InstituteCreateTime_Enabled, 0, "text", "", 19, "chr", 1, "row", 19, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_BAS_Institute.htm");
            GxWebStd.gx_bitmap( context, edtBAS_InstituteCreateTime_Internalname+"_dp_trigger", context.GetImagePath( "61b9b5d3-dff6-4d59-9b00-da61bc2cbe93", "", context.GetTheme( )), "", "", "", "", ((1==0)||(edtBAS_InstituteCreateTime_Enabled==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;", "", "", "", "", "", "", "", "", 1, false, false, "", "HLP_BAS_Institute.htm");
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
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtBAS_InstituteModifier_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtBAS_InstituteModifier_Internalname, "Modifier", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 53,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtBAS_InstituteModifier_Internalname, A390BAS_InstituteModifier, StringUtil.RTrim( context.localUtil.Format( A390BAS_InstituteModifier, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,53);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBAS_InstituteModifier_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtBAS_InstituteModifier_Enabled, 0, "text", "", 50, "chr", 1, "row", 50, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_BAS_Institute.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtBAS_InstituteModifyTime_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtBAS_InstituteModifyTime_Internalname, "Modify Time", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 58,'',false,'',0)\"";
            context.WriteHtmlText( "<div id=\""+edtBAS_InstituteModifyTime_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtBAS_InstituteModifyTime_Internalname, context.localUtil.TToC( A391BAS_InstituteModifyTime, 10, 8, 0, 0, "/", ":", " "), context.localUtil.Format( A391BAS_InstituteModifyTime, "9999/99/99 99:99:99"), TempTags+" onchange=\""+"gx.date.valid_date(this, 10,'YMD',8,24,'chs',false,1);"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,58);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBAS_InstituteModifyTime_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtBAS_InstituteModifyTime_Enabled, 0, "text", "", 19, "chr", 1, "row", 19, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_BAS_Institute.htm");
            GxWebStd.gx_bitmap( context, edtBAS_InstituteModifyTime_Internalname+"_dp_trigger", context.GetImagePath( "61b9b5d3-dff6-4d59-9b00-da61bc2cbe93", "", context.GetTheme( )), "", "", "", "", ((1==0)||(edtBAS_InstituteModifyTime_Enabled==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;", "", "", "", "", "", "", "", "", 1, false, false, "", "HLP_BAS_Institute.htm");
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
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtBAS_InstituteIsDeleted_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtBAS_InstituteIsDeleted_Internalname, "Is Deleted", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 63,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtBAS_InstituteIsDeleted_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A392BAS_InstituteIsDeleted), 1, 0, ".", "")), ((edtBAS_InstituteIsDeleted_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A392BAS_InstituteIsDeleted), "9")) : context.localUtil.Format( (decimal)(A392BAS_InstituteIsDeleted), "9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,63);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBAS_InstituteIsDeleted_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtBAS_InstituteIsDeleted_Enabled, 0, "number", "1", 1, "chr", 1, "row", 1, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_BAS_Institute.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtBAS_InstituteDescription_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtBAS_InstituteDescription_Internalname, "Description", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 68,'',false,'',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtBAS_InstituteDescription_Internalname, A393BAS_InstituteDescription, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,68);\"", 0, 1, edtBAS_InstituteDescription_Enabled, 0, 80, "chr", 10, "row", StyleString, ClassString, "", "", "2048", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BAS_Institute.htm");
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
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 73,'',false,'',0)\"";
            ClassString = "BtnEnter";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_enter_Internalname, "", "确认", bttBtn_enter_Jsonclick, 5, "确认", "", StyleString, ClassString, bttBtn_enter_Visible, bttBtn_enter_Enabled, "standard", "'"+""+"'"+",false,"+"'"+"EENTER."+"'", TempTags, "", context.GetButtonType( ), "HLP_BAS_Institute.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 75,'',false,'',0)\"";
            ClassString = "BtnCancel";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_cancel_Internalname, "", "取消", bttBtn_cancel_Jsonclick, 1, "取消", "", StyleString, ClassString, bttBtn_cancel_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ECANCEL."+"'", TempTags, "", context.GetButtonType( ), "HLP_BAS_Institute.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 77,'',false,'',0)\"";
            ClassString = "BtnDelete";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_delete_Internalname, "", "删除", bttBtn_delete_Jsonclick, 5, "删除", "", StyleString, ClassString, bttBtn_delete_Visible, bttBtn_delete_Enabled, "standard", "'"+""+"'"+",false,"+"'"+"EDELETE."+"'", TempTags, "", context.GetButtonType( ), "HLP_BAS_Institute.htm");
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
               n358InstituteCode = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A358InstituteCode", A358InstituteCode);
               A386InstituteName = cgiGet( edtInstituteName_Internalname);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A386InstituteName", A386InstituteName);
               A387BAS_InstituteLogo = cgiGet( edtBAS_InstituteLogo_Internalname);
               n387BAS_InstituteLogo = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A387BAS_InstituteLogo", A387BAS_InstituteLogo);
               n387BAS_InstituteLogo = (String.IsNullOrEmpty(StringUtil.RTrim( A387BAS_InstituteLogo)) ? true : false);
               A388BAS_InstituteCreator = cgiGet( edtBAS_InstituteCreator_Internalname);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A388BAS_InstituteCreator", A388BAS_InstituteCreator);
               if ( context.localUtil.VCDateTime( cgiGet( edtBAS_InstituteCreateTime_Internalname), 0, 0) == 0 )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_baddatetime", new   object[]  {"BAS_Institute Create Time"}), 1, "BAS_INSTITUTECREATETIME");
                  AnyError = 1;
                  GX_FocusControl = edtBAS_InstituteCreateTime_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A389BAS_InstituteCreateTime = (DateTime)(DateTime.MinValue);
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A389BAS_InstituteCreateTime", context.localUtil.TToC( A389BAS_InstituteCreateTime, 10, 8, 0, 0, "/", ":", " "));
               }
               else
               {
                  A389BAS_InstituteCreateTime = context.localUtil.CToT( cgiGet( edtBAS_InstituteCreateTime_Internalname));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A389BAS_InstituteCreateTime", context.localUtil.TToC( A389BAS_InstituteCreateTime, 10, 8, 0, 0, "/", ":", " "));
               }
               A390BAS_InstituteModifier = cgiGet( edtBAS_InstituteModifier_Internalname);
               n390BAS_InstituteModifier = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A390BAS_InstituteModifier", A390BAS_InstituteModifier);
               n390BAS_InstituteModifier = (String.IsNullOrEmpty(StringUtil.RTrim( A390BAS_InstituteModifier)) ? true : false);
               if ( context.localUtil.VCDateTime( cgiGet( edtBAS_InstituteModifyTime_Internalname), 0, 0) == 0 )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_baddatetime", new   object[]  {"BAS_Institute Modify Time"}), 1, "BAS_INSTITUTEMODIFYTIME");
                  AnyError = 1;
                  GX_FocusControl = edtBAS_InstituteModifyTime_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A391BAS_InstituteModifyTime = (DateTime)(DateTime.MinValue);
                  n391BAS_InstituteModifyTime = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A391BAS_InstituteModifyTime", context.localUtil.TToC( A391BAS_InstituteModifyTime, 10, 8, 0, 0, "/", ":", " "));
               }
               else
               {
                  A391BAS_InstituteModifyTime = context.localUtil.CToT( cgiGet( edtBAS_InstituteModifyTime_Internalname));
                  n391BAS_InstituteModifyTime = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A391BAS_InstituteModifyTime", context.localUtil.TToC( A391BAS_InstituteModifyTime, 10, 8, 0, 0, "/", ":", " "));
               }
               n391BAS_InstituteModifyTime = ((DateTime.MinValue==A391BAS_InstituteModifyTime) ? true : false);
               if ( ( ( context.localUtil.CToN( cgiGet( edtBAS_InstituteIsDeleted_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtBAS_InstituteIsDeleted_Internalname), ".", ",") > Convert.ToDecimal( 9 )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "BAS_INSTITUTEISDELETED");
                  AnyError = 1;
                  GX_FocusControl = edtBAS_InstituteIsDeleted_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A392BAS_InstituteIsDeleted = 0;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A392BAS_InstituteIsDeleted", StringUtil.Str( (decimal)(A392BAS_InstituteIsDeleted), 1, 0));
               }
               else
               {
                  A392BAS_InstituteIsDeleted = (short)(context.localUtil.CToN( cgiGet( edtBAS_InstituteIsDeleted_Internalname), ".", ","));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A392BAS_InstituteIsDeleted", StringUtil.Str( (decimal)(A392BAS_InstituteIsDeleted), 1, 0));
               }
               A393BAS_InstituteDescription = cgiGet( edtBAS_InstituteDescription_Internalname);
               n393BAS_InstituteDescription = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A393BAS_InstituteDescription", A393BAS_InstituteDescription);
               n393BAS_InstituteDescription = (String.IsNullOrEmpty(StringUtil.RTrim( A393BAS_InstituteDescription)) ? true : false);
               /* Read saved values. */
               Z358InstituteCode = cgiGet( "Z358InstituteCode");
               Z386InstituteName = cgiGet( "Z386InstituteName");
               Z388BAS_InstituteCreator = cgiGet( "Z388BAS_InstituteCreator");
               Z389BAS_InstituteCreateTime = context.localUtil.CToT( cgiGet( "Z389BAS_InstituteCreateTime"), 0);
               Z390BAS_InstituteModifier = cgiGet( "Z390BAS_InstituteModifier");
               n390BAS_InstituteModifier = (String.IsNullOrEmpty(StringUtil.RTrim( A390BAS_InstituteModifier)) ? true : false);
               Z391BAS_InstituteModifyTime = context.localUtil.CToT( cgiGet( "Z391BAS_InstituteModifyTime"), 0);
               n391BAS_InstituteModifyTime = ((DateTime.MinValue==A391BAS_InstituteModifyTime) ? true : false);
               Z392BAS_InstituteIsDeleted = (short)(context.localUtil.CToN( cgiGet( "Z392BAS_InstituteIsDeleted"), ".", ","));
               IsConfirmed = (short)(context.localUtil.CToN( cgiGet( "IsConfirmed"), ".", ","));
               IsModified = (short)(context.localUtil.CToN( cgiGet( "IsModified"), ".", ","));
               Gx_mode = cgiGet( "Mode");
               Gx_mode = cgiGet( "vMODE");
               edtBAS_InstituteLogo_Filename = cgiGet( "BAS_INSTITUTELOGO_Filename");
               edtBAS_InstituteLogo_Filetype = cgiGet( "BAS_INSTITUTELOGO_Filetype");
               /* Read subfile selected row values. */
               /* Read hidden variables. */
               if ( ! String.IsNullOrEmpty(StringUtil.RTrim( A387BAS_InstituteLogo)) )
               {
                  edtBAS_InstituteLogo_Filename = (String)(CGIGetFileName(edtBAS_InstituteLogo_Internalname));
                  edtBAS_InstituteLogo_Filetype = (String)(CGIGetFileType(edtBAS_InstituteLogo_Internalname));
               }
               if ( String.IsNullOrEmpty(StringUtil.RTrim( A387BAS_InstituteLogo)) )
               {
                  GXCCtlgxBlob = "BAS_INSTITUTELOGO" + "_gxBlob";
                  A387BAS_InstituteLogo = cgiGet( GXCCtlgxBlob);
                  n387BAS_InstituteLogo = false;
                  n387BAS_InstituteLogo = (String.IsNullOrEmpty(StringUtil.RTrim( A387BAS_InstituteLogo)) ? true : false);
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
                  A358InstituteCode = GetNextPar( );
                  n358InstituteCode = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A358InstituteCode", A358InstituteCode);
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
               InitAll1K57( ) ;
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
         DisableAttributes1K57( ) ;
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

      protected void ResetCaption1K0( )
      {
      }

      protected void ZM1K57( short GX_JID )
      {
         if ( ( GX_JID == 3 ) || ( GX_JID == 0 ) )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
            {
               Z386InstituteName = T001K3_A386InstituteName[0];
               Z388BAS_InstituteCreator = T001K3_A388BAS_InstituteCreator[0];
               Z389BAS_InstituteCreateTime = T001K3_A389BAS_InstituteCreateTime[0];
               Z390BAS_InstituteModifier = T001K3_A390BAS_InstituteModifier[0];
               Z391BAS_InstituteModifyTime = T001K3_A391BAS_InstituteModifyTime[0];
               Z392BAS_InstituteIsDeleted = T001K3_A392BAS_InstituteIsDeleted[0];
            }
            else
            {
               Z386InstituteName = A386InstituteName;
               Z388BAS_InstituteCreator = A388BAS_InstituteCreator;
               Z389BAS_InstituteCreateTime = A389BAS_InstituteCreateTime;
               Z390BAS_InstituteModifier = A390BAS_InstituteModifier;
               Z391BAS_InstituteModifyTime = A391BAS_InstituteModifyTime;
               Z392BAS_InstituteIsDeleted = A392BAS_InstituteIsDeleted;
            }
         }
         if ( GX_JID == -3 )
         {
            Z358InstituteCode = A358InstituteCode;
            Z386InstituteName = A386InstituteName;
            Z387BAS_InstituteLogo = A387BAS_InstituteLogo;
            Z388BAS_InstituteCreator = A388BAS_InstituteCreator;
            Z389BAS_InstituteCreateTime = A389BAS_InstituteCreateTime;
            Z390BAS_InstituteModifier = A390BAS_InstituteModifier;
            Z391BAS_InstituteModifyTime = A391BAS_InstituteModifyTime;
            Z392BAS_InstituteIsDeleted = A392BAS_InstituteIsDeleted;
            Z393BAS_InstituteDescription = A393BAS_InstituteDescription;
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

      protected void Load1K57( )
      {
         /* Using cursor T001K4 */
         pr_datastore1.execute(2, new Object[] {n358InstituteCode, A358InstituteCode});
         if ( (pr_datastore1.getStatus(2) != 101) )
         {
            RcdFound57 = 1;
            A386InstituteName = T001K4_A386InstituteName[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A386InstituteName", A386InstituteName);
            A388BAS_InstituteCreator = T001K4_A388BAS_InstituteCreator[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A388BAS_InstituteCreator", A388BAS_InstituteCreator);
            A389BAS_InstituteCreateTime = T001K4_A389BAS_InstituteCreateTime[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A389BAS_InstituteCreateTime", context.localUtil.TToC( A389BAS_InstituteCreateTime, 10, 8, 0, 0, "/", ":", " "));
            A390BAS_InstituteModifier = T001K4_A390BAS_InstituteModifier[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A390BAS_InstituteModifier", A390BAS_InstituteModifier);
            n390BAS_InstituteModifier = T001K4_n390BAS_InstituteModifier[0];
            A391BAS_InstituteModifyTime = T001K4_A391BAS_InstituteModifyTime[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A391BAS_InstituteModifyTime", context.localUtil.TToC( A391BAS_InstituteModifyTime, 10, 8, 0, 0, "/", ":", " "));
            n391BAS_InstituteModifyTime = T001K4_n391BAS_InstituteModifyTime[0];
            A392BAS_InstituteIsDeleted = T001K4_A392BAS_InstituteIsDeleted[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A392BAS_InstituteIsDeleted", StringUtil.Str( (decimal)(A392BAS_InstituteIsDeleted), 1, 0));
            A393BAS_InstituteDescription = T001K4_A393BAS_InstituteDescription[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A393BAS_InstituteDescription", A393BAS_InstituteDescription);
            n393BAS_InstituteDescription = T001K4_n393BAS_InstituteDescription[0];
            A387BAS_InstituteLogo = T001K4_A387BAS_InstituteLogo[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A387BAS_InstituteLogo", A387BAS_InstituteLogo);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBAS_InstituteLogo_Internalname, "URL", context.PathToRelativeUrl( A387BAS_InstituteLogo), true);
            n387BAS_InstituteLogo = T001K4_n387BAS_InstituteLogo[0];
            ZM1K57( -3) ;
         }
         pr_datastore1.close(2);
         OnLoadActions1K57( ) ;
      }

      protected void OnLoadActions1K57( )
      {
      }

      protected void CheckExtendedTable1K57( )
      {
         Gx_BScreen = 1;
         standaloneModal( ) ;
         if ( ! ( (DateTime.MinValue==A389BAS_InstituteCreateTime) || ( A389BAS_InstituteCreateTime >= context.localUtil.YMDHMSToT( 1753, 1, 1, 0, 0, 0) ) ) )
         {
            GX_msglist.addItem("域BAS_Institute Create Time超界", "OutOfRange", 1, "BAS_INSTITUTECREATETIME");
            AnyError = 1;
            GX_FocusControl = edtBAS_InstituteCreateTime_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( ! ( (DateTime.MinValue==A391BAS_InstituteModifyTime) || ( A391BAS_InstituteModifyTime >= context.localUtil.YMDHMSToT( 1753, 1, 1, 0, 0, 0) ) ) )
         {
            GX_msglist.addItem("域BAS_Institute Modify Time超界", "OutOfRange", 1, "BAS_INSTITUTEMODIFYTIME");
            AnyError = 1;
            GX_FocusControl = edtBAS_InstituteModifyTime_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
      }

      protected void CloseExtendedTableCursors1K57( )
      {
      }

      protected void enableDisable( )
      {
      }

      protected void GetKey1K57( )
      {
         /* Using cursor T001K5 */
         pr_datastore1.execute(3, new Object[] {n358InstituteCode, A358InstituteCode});
         if ( (pr_datastore1.getStatus(3) != 101) )
         {
            RcdFound57 = 1;
         }
         else
         {
            RcdFound57 = 0;
         }
         pr_datastore1.close(3);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor T001K3 */
         pr_datastore1.execute(1, new Object[] {n358InstituteCode, A358InstituteCode});
         if ( (pr_datastore1.getStatus(1) != 101) )
         {
            ZM1K57( 3) ;
            RcdFound57 = 1;
            A358InstituteCode = T001K3_A358InstituteCode[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A358InstituteCode", A358InstituteCode);
            n358InstituteCode = T001K3_n358InstituteCode[0];
            A386InstituteName = T001K3_A386InstituteName[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A386InstituteName", A386InstituteName);
            A388BAS_InstituteCreator = T001K3_A388BAS_InstituteCreator[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A388BAS_InstituteCreator", A388BAS_InstituteCreator);
            A389BAS_InstituteCreateTime = T001K3_A389BAS_InstituteCreateTime[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A389BAS_InstituteCreateTime", context.localUtil.TToC( A389BAS_InstituteCreateTime, 10, 8, 0, 0, "/", ":", " "));
            A390BAS_InstituteModifier = T001K3_A390BAS_InstituteModifier[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A390BAS_InstituteModifier", A390BAS_InstituteModifier);
            n390BAS_InstituteModifier = T001K3_n390BAS_InstituteModifier[0];
            A391BAS_InstituteModifyTime = T001K3_A391BAS_InstituteModifyTime[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A391BAS_InstituteModifyTime", context.localUtil.TToC( A391BAS_InstituteModifyTime, 10, 8, 0, 0, "/", ":", " "));
            n391BAS_InstituteModifyTime = T001K3_n391BAS_InstituteModifyTime[0];
            A392BAS_InstituteIsDeleted = T001K3_A392BAS_InstituteIsDeleted[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A392BAS_InstituteIsDeleted", StringUtil.Str( (decimal)(A392BAS_InstituteIsDeleted), 1, 0));
            A393BAS_InstituteDescription = T001K3_A393BAS_InstituteDescription[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A393BAS_InstituteDescription", A393BAS_InstituteDescription);
            n393BAS_InstituteDescription = T001K3_n393BAS_InstituteDescription[0];
            A387BAS_InstituteLogo = T001K3_A387BAS_InstituteLogo[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A387BAS_InstituteLogo", A387BAS_InstituteLogo);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBAS_InstituteLogo_Internalname, "URL", context.PathToRelativeUrl( A387BAS_InstituteLogo), true);
            n387BAS_InstituteLogo = T001K3_n387BAS_InstituteLogo[0];
            Z358InstituteCode = A358InstituteCode;
            sMode57 = Gx_mode;
            Gx_mode = "DSP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            standaloneModal( ) ;
            Load1K57( ) ;
            if ( AnyError == 1 )
            {
               RcdFound57 = 0;
               InitializeNonKey1K57( ) ;
            }
            Gx_mode = sMode57;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         else
         {
            RcdFound57 = 0;
            InitializeNonKey1K57( ) ;
            sMode57 = Gx_mode;
            Gx_mode = "DSP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            standaloneModal( ) ;
            Gx_mode = sMode57;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         pr_datastore1.close(1);
      }

      protected void getEqualNoModal( )
      {
         GetKey1K57( ) ;
         if ( RcdFound57 == 0 )
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
         RcdFound57 = 0;
         /* Using cursor T001K6 */
         pr_datastore1.execute(4, new Object[] {n358InstituteCode, A358InstituteCode});
         if ( (pr_datastore1.getStatus(4) != 101) )
         {
            while ( (pr_datastore1.getStatus(4) != 101) && ( ( StringUtil.StrCmp(T001K6_A358InstituteCode[0], A358InstituteCode) < 0 ) ) )
            {
               pr_datastore1.readNext(4);
            }
            if ( (pr_datastore1.getStatus(4) != 101) && ( ( StringUtil.StrCmp(T001K6_A358InstituteCode[0], A358InstituteCode) > 0 ) ) )
            {
               A358InstituteCode = T001K6_A358InstituteCode[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A358InstituteCode", A358InstituteCode);
               n358InstituteCode = T001K6_n358InstituteCode[0];
               RcdFound57 = 1;
            }
         }
         pr_datastore1.close(4);
      }

      protected void move_previous( )
      {
         RcdFound57 = 0;
         /* Using cursor T001K7 */
         pr_datastore1.execute(5, new Object[] {n358InstituteCode, A358InstituteCode});
         if ( (pr_datastore1.getStatus(5) != 101) )
         {
            while ( (pr_datastore1.getStatus(5) != 101) && ( ( StringUtil.StrCmp(T001K7_A358InstituteCode[0], A358InstituteCode) > 0 ) ) )
            {
               pr_datastore1.readNext(5);
            }
            if ( (pr_datastore1.getStatus(5) != 101) && ( ( StringUtil.StrCmp(T001K7_A358InstituteCode[0], A358InstituteCode) < 0 ) ) )
            {
               A358InstituteCode = T001K7_A358InstituteCode[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A358InstituteCode", A358InstituteCode);
               n358InstituteCode = T001K7_n358InstituteCode[0];
               RcdFound57 = 1;
            }
         }
         pr_datastore1.close(5);
      }

      protected void btn_enter( )
      {
         nKeyPressed = 1;
         GetKey1K57( ) ;
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            /* Insert record */
            GX_FocusControl = edtInstituteCode_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            Insert1K57( ) ;
            if ( AnyError == 1 )
            {
               GX_FocusControl = "";
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
         }
         else
         {
            if ( RcdFound57 == 1 )
            {
               if ( StringUtil.StrCmp(A358InstituteCode, Z358InstituteCode) != 0 )
               {
                  A358InstituteCode = Z358InstituteCode;
                  n358InstituteCode = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A358InstituteCode", A358InstituteCode);
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
                  Update1K57( ) ;
                  GX_FocusControl = edtInstituteCode_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
            }
            else
            {
               if ( StringUtil.StrCmp(A358InstituteCode, Z358InstituteCode) != 0 )
               {
                  Gx_mode = "INS";
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                  /* Insert record */
                  GX_FocusControl = edtInstituteCode_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  Insert1K57( ) ;
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
                     Insert1K57( ) ;
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
         if ( StringUtil.StrCmp(A358InstituteCode, Z358InstituteCode) != 0 )
         {
            A358InstituteCode = Z358InstituteCode;
            n358InstituteCode = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A358InstituteCode", A358InstituteCode);
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
         if ( RcdFound57 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_keynfound", ""), "PrimaryKeyNotFound", 1, "INSTITUTECODE");
            AnyError = 1;
            GX_FocusControl = edtInstituteCode_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         GX_FocusControl = edtInstituteName_Internalname;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_first( )
      {
         nKeyPressed = 2;
         IsConfirmed = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "IsConfirmed", StringUtil.LTrim( StringUtil.Str( (decimal)(IsConfirmed), 4, 0)));
         ScanStart1K57( ) ;
         if ( RcdFound57 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "", true);
         }
         else
         {
            Gx_mode = "UPD";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtInstituteName_Internalname;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         ScanEnd1K57( ) ;
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
         if ( RcdFound57 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "", true);
         }
         else
         {
            Gx_mode = "UPD";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtInstituteName_Internalname;
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
         if ( RcdFound57 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "", true);
         }
         else
         {
            Gx_mode = "UPD";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtInstituteName_Internalname;
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
         ScanStart1K57( ) ;
         if ( RcdFound57 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "", true);
         }
         else
         {
            while ( RcdFound57 != 0 )
            {
               ScanNext1K57( ) ;
            }
            Gx_mode = "UPD";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtInstituteName_Internalname;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         ScanEnd1K57( ) ;
         getByPrimaryKey( ) ;
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_select( )
      {
         getEqualNoModal( ) ;
      }

      protected void CheckOptimisticConcurrency1K57( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor T001K2 */
            pr_datastore1.execute(0, new Object[] {n358InstituteCode, A358InstituteCode});
            if ( (pr_datastore1.getStatus(0) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"BAS_INSTITUTE"}), "RecordIsLocked", 1, "");
               AnyError = 1;
               return  ;
            }
            Gx_longc = false;
            if ( (pr_datastore1.getStatus(0) == 101) || ( StringUtil.StrCmp(Z386InstituteName, T001K2_A386InstituteName[0]) != 0 ) || ( StringUtil.StrCmp(Z388BAS_InstituteCreator, T001K2_A388BAS_InstituteCreator[0]) != 0 ) || ( Z389BAS_InstituteCreateTime != T001K2_A389BAS_InstituteCreateTime[0] ) || ( StringUtil.StrCmp(Z390BAS_InstituteModifier, T001K2_A390BAS_InstituteModifier[0]) != 0 ) || ( Z391BAS_InstituteModifyTime != T001K2_A391BAS_InstituteModifyTime[0] ) )
            {
               Gx_longc = true;
            }
            if ( Gx_longc || ( Z392BAS_InstituteIsDeleted != T001K2_A392BAS_InstituteIsDeleted[0] ) )
            {
               if ( StringUtil.StrCmp(Z386InstituteName, T001K2_A386InstituteName[0]) != 0 )
               {
                  GXUtil.WriteLog("bas_institute:[seudo value changed for attri]"+"InstituteName");
                  GXUtil.WriteLogRaw("Old: ",Z386InstituteName);
                  GXUtil.WriteLogRaw("Current: ",T001K2_A386InstituteName[0]);
               }
               if ( StringUtil.StrCmp(Z388BAS_InstituteCreator, T001K2_A388BAS_InstituteCreator[0]) != 0 )
               {
                  GXUtil.WriteLog("bas_institute:[seudo value changed for attri]"+"BAS_InstituteCreator");
                  GXUtil.WriteLogRaw("Old: ",Z388BAS_InstituteCreator);
                  GXUtil.WriteLogRaw("Current: ",T001K2_A388BAS_InstituteCreator[0]);
               }
               if ( Z389BAS_InstituteCreateTime != T001K2_A389BAS_InstituteCreateTime[0] )
               {
                  GXUtil.WriteLog("bas_institute:[seudo value changed for attri]"+"BAS_InstituteCreateTime");
                  GXUtil.WriteLogRaw("Old: ",Z389BAS_InstituteCreateTime);
                  GXUtil.WriteLogRaw("Current: ",T001K2_A389BAS_InstituteCreateTime[0]);
               }
               if ( StringUtil.StrCmp(Z390BAS_InstituteModifier, T001K2_A390BAS_InstituteModifier[0]) != 0 )
               {
                  GXUtil.WriteLog("bas_institute:[seudo value changed for attri]"+"BAS_InstituteModifier");
                  GXUtil.WriteLogRaw("Old: ",Z390BAS_InstituteModifier);
                  GXUtil.WriteLogRaw("Current: ",T001K2_A390BAS_InstituteModifier[0]);
               }
               if ( Z391BAS_InstituteModifyTime != T001K2_A391BAS_InstituteModifyTime[0] )
               {
                  GXUtil.WriteLog("bas_institute:[seudo value changed for attri]"+"BAS_InstituteModifyTime");
                  GXUtil.WriteLogRaw("Old: ",Z391BAS_InstituteModifyTime);
                  GXUtil.WriteLogRaw("Current: ",T001K2_A391BAS_InstituteModifyTime[0]);
               }
               if ( Z392BAS_InstituteIsDeleted != T001K2_A392BAS_InstituteIsDeleted[0] )
               {
                  GXUtil.WriteLog("bas_institute:[seudo value changed for attri]"+"BAS_InstituteIsDeleted");
                  GXUtil.WriteLogRaw("Old: ",Z392BAS_InstituteIsDeleted);
                  GXUtil.WriteLogRaw("Current: ",T001K2_A392BAS_InstituteIsDeleted[0]);
               }
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"BAS_INSTITUTE"}), "RecordWasChanged", 1, "");
               AnyError = 1;
               return  ;
            }
         }
      }

      protected void Insert1K57( )
      {
         BeforeValidate1K57( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable1K57( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM1K57( 0) ;
            CheckOptimisticConcurrency1K57( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm1K57( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert1K57( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T001K8 */
                     pr_datastore1.execute(6, new Object[] {n358InstituteCode, A358InstituteCode, A386InstituteName, n387BAS_InstituteLogo, A387BAS_InstituteLogo, A388BAS_InstituteCreator, A389BAS_InstituteCreateTime, n390BAS_InstituteModifier, A390BAS_InstituteModifier, n391BAS_InstituteModifyTime, A391BAS_InstituteModifyTime, A392BAS_InstituteIsDeleted, n393BAS_InstituteDescription, A393BAS_InstituteDescription});
                     pr_datastore1.close(6);
                     dsDataStore1.SmartCacheProvider.SetUpdated("BAS_INSTITUTE") ;
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
                           ResetCaption1K0( ) ;
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
               Load1K57( ) ;
            }
            EndLevel1K57( ) ;
         }
         CloseExtendedTableCursors1K57( ) ;
      }

      protected void Update1K57( )
      {
         BeforeValidate1K57( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable1K57( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency1K57( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm1K57( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate1K57( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T001K9 */
                     pr_datastore1.execute(7, new Object[] {A386InstituteName, A388BAS_InstituteCreator, A389BAS_InstituteCreateTime, n390BAS_InstituteModifier, A390BAS_InstituteModifier, n391BAS_InstituteModifyTime, A391BAS_InstituteModifyTime, A392BAS_InstituteIsDeleted, n393BAS_InstituteDescription, A393BAS_InstituteDescription, n358InstituteCode, A358InstituteCode});
                     pr_datastore1.close(7);
                     dsDataStore1.SmartCacheProvider.SetUpdated("BAS_INSTITUTE") ;
                     if ( (pr_datastore1.getStatus(7) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"BAS_INSTITUTE"}), "RecordIsLocked", 1, "");
                        AnyError = 1;
                     }
                     DeferredUpdate1K57( ) ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( update) rules */
                        /* End of After( update) rules */
                        if ( AnyError == 0 )
                        {
                           getByPrimaryKey( ) ;
                           GX_msglist.addItem(context.GetMessage( "GXM_sucupdated", ""), "SuccessfullyUpdated", 0, "", true);
                           ResetCaption1K0( ) ;
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
            EndLevel1K57( ) ;
         }
         CloseExtendedTableCursors1K57( ) ;
      }

      protected void DeferredUpdate1K57( )
      {
         if ( AnyError == 0 )
         {
            /* Using cursor T001K10 */
            pr_datastore1.execute(8, new Object[] {n387BAS_InstituteLogo, A387BAS_InstituteLogo, n358InstituteCode, A358InstituteCode});
            pr_datastore1.close(8);
            dsDataStore1.SmartCacheProvider.SetUpdated("BAS_INSTITUTE") ;
         }
      }

      protected void delete( )
      {
         Gx_mode = "DLT";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         BeforeValidate1K57( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency1K57( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls1K57( ) ;
            AfterConfirm1K57( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete1K57( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor T001K11 */
                  pr_datastore1.execute(9, new Object[] {n358InstituteCode, A358InstituteCode});
                  pr_datastore1.close(9);
                  dsDataStore1.SmartCacheProvider.SetUpdated("BAS_INSTITUTE") ;
                  if ( AnyError == 0 )
                  {
                     /* Start of After( delete) rules */
                     /* End of After( delete) rules */
                     if ( AnyError == 0 )
                     {
                        move_next( ) ;
                        if ( RcdFound57 == 0 )
                        {
                           InitAll1K57( ) ;
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
                        ResetCaption1K0( ) ;
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
         sMode57 = Gx_mode;
         Gx_mode = "DLT";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         EndLevel1K57( ) ;
         Gx_mode = sMode57;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
      }

      protected void OnDeleteControls1K57( )
      {
         standaloneModal( ) ;
         /* No delete mode formulas found. */
         if ( AnyError == 0 )
         {
            /* Using cursor T001K12 */
            pr_datastore1.execute(10, new Object[] {n358InstituteCode, A358InstituteCode});
            if ( (pr_datastore1.getStatus(10) != 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_del", new   object[]  {"BAS_Tenant"}), "CannotDeleteReferencedRecord", 1, "");
               AnyError = 1;
            }
            pr_datastore1.close(10);
            /* Using cursor T001K13 */
            pr_datastore1.execute(11, new Object[] {n358InstituteCode, A358InstituteCode});
            if ( (pr_datastore1.getStatus(11) != 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_del", new   object[]  {"SYS_Institute User"}), "CannotDeleteReferencedRecord", 1, "");
               AnyError = 1;
            }
            pr_datastore1.close(11);
         }
      }

      protected void EndLevel1K57( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            pr_datastore1.close(0);
         }
         if ( AnyError == 0 )
         {
            BeforeComplete1K57( ) ;
         }
         if ( AnyError == 0 )
         {
            pr_datastore1.close(1);
            context.CommitDataStores("bas_institute",pr_default);
            if ( AnyError == 0 )
            {
               ConfirmValues1K0( ) ;
            }
            /* After transaction rules */
            /* Execute 'After Trn' event if defined. */
            trnEnded = 1;
         }
         else
         {
            pr_datastore1.close(1);
            context.RollbackDataStores("bas_institute",pr_default);
         }
         IsModified = 0;
         if ( AnyError != 0 )
         {
            context.wjLoc = "";
            context.nUserReturn = 0;
         }
      }

      public void ScanStart1K57( )
      {
         /* Using cursor T001K14 */
         pr_datastore1.execute(12);
         RcdFound57 = 0;
         if ( (pr_datastore1.getStatus(12) != 101) )
         {
            RcdFound57 = 1;
            A358InstituteCode = T001K14_A358InstituteCode[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A358InstituteCode", A358InstituteCode);
            n358InstituteCode = T001K14_n358InstituteCode[0];
         }
         /* Load Subordinate Levels */
      }

      protected void ScanNext1K57( )
      {
         /* Scan next routine */
         pr_datastore1.readNext(12);
         RcdFound57 = 0;
         if ( (pr_datastore1.getStatus(12) != 101) )
         {
            RcdFound57 = 1;
            A358InstituteCode = T001K14_A358InstituteCode[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A358InstituteCode", A358InstituteCode);
            n358InstituteCode = T001K14_n358InstituteCode[0];
         }
      }

      protected void ScanEnd1K57( )
      {
         pr_datastore1.close(12);
      }

      protected void AfterConfirm1K57( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert1K57( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate1K57( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete1K57( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete1K57( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate1K57( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes1K57( )
      {
         edtInstituteCode_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtInstituteCode_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtInstituteCode_Enabled), 5, 0)), true);
         edtInstituteName_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtInstituteName_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtInstituteName_Enabled), 5, 0)), true);
         edtBAS_InstituteLogo_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBAS_InstituteLogo_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBAS_InstituteLogo_Enabled), 5, 0)), true);
         edtBAS_InstituteCreator_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBAS_InstituteCreator_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBAS_InstituteCreator_Enabled), 5, 0)), true);
         edtBAS_InstituteCreateTime_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBAS_InstituteCreateTime_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBAS_InstituteCreateTime_Enabled), 5, 0)), true);
         edtBAS_InstituteModifier_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBAS_InstituteModifier_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBAS_InstituteModifier_Enabled), 5, 0)), true);
         edtBAS_InstituteModifyTime_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBAS_InstituteModifyTime_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBAS_InstituteModifyTime_Enabled), 5, 0)), true);
         edtBAS_InstituteIsDeleted_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBAS_InstituteIsDeleted_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBAS_InstituteIsDeleted_Enabled), 5, 0)), true);
         edtBAS_InstituteDescription_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBAS_InstituteDescription_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBAS_InstituteDescription_Enabled), 5, 0)), true);
      }

      protected void send_integrity_lvl_hashes1K57( )
      {
      }

      protected void assign_properties_default( )
      {
      }

      protected void ConfirmValues1K0( )
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
         context.AddJavascriptSource("gxcfg.js", "?202022793949", false);
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" autocomplete=\"off\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("bas_institute.aspx") +"\">") ;
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
         GxWebStd.gx_hidden_field( context, "Z386InstituteName", Z386InstituteName);
         GxWebStd.gx_hidden_field( context, "Z388BAS_InstituteCreator", Z388BAS_InstituteCreator);
         GxWebStd.gx_hidden_field( context, "Z389BAS_InstituteCreateTime", context.localUtil.TToC( Z389BAS_InstituteCreateTime, 10, 8, 0, 0, "/", ":", " "));
         GxWebStd.gx_hidden_field( context, "Z390BAS_InstituteModifier", Z390BAS_InstituteModifier);
         GxWebStd.gx_hidden_field( context, "Z391BAS_InstituteModifyTime", context.localUtil.TToC( Z391BAS_InstituteModifyTime, 10, 8, 0, 0, "/", ":", " "));
         GxWebStd.gx_hidden_field( context, "Z392BAS_InstituteIsDeleted", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z392BAS_InstituteIsDeleted), 1, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "IsConfirmed", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsConfirmed), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "IsModified", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsModified), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "Mode", StringUtil.RTrim( Gx_mode));
         GxWebStd.gx_hidden_field( context, "vMODE", StringUtil.RTrim( Gx_mode));
         GXCCtlgxBlob = "BAS_INSTITUTELOGO" + "_gxBlob";
         GxWebStd.gx_hidden_field( context, GXCCtlgxBlob, A387BAS_InstituteLogo);
         GxWebStd.gx_hidden_field( context, "BAS_INSTITUTELOGO_Filename", StringUtil.RTrim( edtBAS_InstituteLogo_Filename));
         GxWebStd.gx_hidden_field( context, "BAS_INSTITUTELOGO_Filetype", StringUtil.RTrim( edtBAS_InstituteLogo_Filetype));
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
         return formatLink("bas_institute.aspx")  ;
      }

      public override String GetPgmname( )
      {
         return "BAS_Institute" ;
      }

      public override String GetPgmdesc( )
      {
         return "BAS_Institute" ;
      }

      protected void InitializeNonKey1K57( )
      {
         A386InstituteName = "";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A386InstituteName", A386InstituteName);
         A387BAS_InstituteLogo = "";
         n387BAS_InstituteLogo = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A387BAS_InstituteLogo", A387BAS_InstituteLogo);
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBAS_InstituteLogo_Internalname, "URL", context.PathToRelativeUrl( A387BAS_InstituteLogo), true);
         n387BAS_InstituteLogo = (String.IsNullOrEmpty(StringUtil.RTrim( A387BAS_InstituteLogo)) ? true : false);
         A388BAS_InstituteCreator = "";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A388BAS_InstituteCreator", A388BAS_InstituteCreator);
         A389BAS_InstituteCreateTime = (DateTime)(DateTime.MinValue);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A389BAS_InstituteCreateTime", context.localUtil.TToC( A389BAS_InstituteCreateTime, 10, 8, 0, 0, "/", ":", " "));
         A390BAS_InstituteModifier = "";
         n390BAS_InstituteModifier = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A390BAS_InstituteModifier", A390BAS_InstituteModifier);
         n390BAS_InstituteModifier = (String.IsNullOrEmpty(StringUtil.RTrim( A390BAS_InstituteModifier)) ? true : false);
         A391BAS_InstituteModifyTime = (DateTime)(DateTime.MinValue);
         n391BAS_InstituteModifyTime = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A391BAS_InstituteModifyTime", context.localUtil.TToC( A391BAS_InstituteModifyTime, 10, 8, 0, 0, "/", ":", " "));
         n391BAS_InstituteModifyTime = ((DateTime.MinValue==A391BAS_InstituteModifyTime) ? true : false);
         A392BAS_InstituteIsDeleted = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A392BAS_InstituteIsDeleted", StringUtil.Str( (decimal)(A392BAS_InstituteIsDeleted), 1, 0));
         A393BAS_InstituteDescription = "";
         n393BAS_InstituteDescription = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A393BAS_InstituteDescription", A393BAS_InstituteDescription);
         n393BAS_InstituteDescription = (String.IsNullOrEmpty(StringUtil.RTrim( A393BAS_InstituteDescription)) ? true : false);
         Z386InstituteName = "";
         Z388BAS_InstituteCreator = "";
         Z389BAS_InstituteCreateTime = (DateTime)(DateTime.MinValue);
         Z390BAS_InstituteModifier = "";
         Z391BAS_InstituteModifyTime = (DateTime)(DateTime.MinValue);
         Z392BAS_InstituteIsDeleted = 0;
      }

      protected void InitAll1K57( )
      {
         A358InstituteCode = "";
         n358InstituteCode = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A358InstituteCode", A358InstituteCode);
         InitializeNonKey1K57( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?2020227939418", true);
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
         context.AddJavascriptSource("bas_institute.js", "?2020227939418", false);
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
         edtInstituteName_Internalname = "INSTITUTENAME";
         edtBAS_InstituteLogo_Internalname = "BAS_INSTITUTELOGO";
         edtBAS_InstituteCreator_Internalname = "BAS_INSTITUTECREATOR";
         edtBAS_InstituteCreateTime_Internalname = "BAS_INSTITUTECREATETIME";
         edtBAS_InstituteModifier_Internalname = "BAS_INSTITUTEMODIFIER";
         edtBAS_InstituteModifyTime_Internalname = "BAS_INSTITUTEMODIFYTIME";
         edtBAS_InstituteIsDeleted_Internalname = "BAS_INSTITUTEISDELETED";
         edtBAS_InstituteDescription_Internalname = "BAS_INSTITUTEDESCRIPTION";
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
         edtBAS_InstituteLogo_Filename = "";
         Form.Headerrawhtml = "";
         Form.Background = "";
         Form.Textcolor = 0;
         Form.Backcolor = (int)(0xFFFFFF);
         Form.Caption = "BAS_Institute";
         bttBtn_delete_Enabled = 1;
         bttBtn_delete_Visible = 1;
         bttBtn_cancel_Visible = 1;
         bttBtn_enter_Enabled = 1;
         bttBtn_enter_Visible = 1;
         edtBAS_InstituteDescription_Enabled = 1;
         edtBAS_InstituteIsDeleted_Jsonclick = "";
         edtBAS_InstituteIsDeleted_Enabled = 1;
         edtBAS_InstituteModifyTime_Jsonclick = "";
         edtBAS_InstituteModifyTime_Enabled = 1;
         edtBAS_InstituteModifier_Jsonclick = "";
         edtBAS_InstituteModifier_Enabled = 1;
         edtBAS_InstituteCreateTime_Jsonclick = "";
         edtBAS_InstituteCreateTime_Enabled = 1;
         edtBAS_InstituteCreator_Jsonclick = "";
         edtBAS_InstituteCreator_Enabled = 1;
         edtBAS_InstituteLogo_Jsonclick = "";
         edtBAS_InstituteLogo_Parameters = "";
         edtBAS_InstituteLogo_Contenttype = "";
         edtBAS_InstituteLogo_Filetype = "";
         edtBAS_InstituteLogo_Enabled = 1;
         edtInstituteName_Jsonclick = "";
         edtInstituteName_Enabled = 1;
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
         GX_FocusControl = edtInstituteName_Internalname;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         standaloneNotModal( ) ;
         standaloneModal( ) ;
         /* End function AfterKeyLoadScreen */
      }

      public void Valid_Institutecode( String GX_Parm1 ,
                                       String GX_Parm2 ,
                                       String GX_Parm3 ,
                                       String GX_Parm4 ,
                                       DateTime GX_Parm5 ,
                                       String GX_Parm6 ,
                                       DateTime GX_Parm7 ,
                                       short GX_Parm8 ,
                                       String GX_Parm9 )
      {
         A358InstituteCode = GX_Parm1;
         n358InstituteCode = false;
         A386InstituteName = GX_Parm2;
         A387BAS_InstituteLogo = GX_Parm3;
         n387BAS_InstituteLogo = false;
         A388BAS_InstituteCreator = GX_Parm4;
         A389BAS_InstituteCreateTime = GX_Parm5;
         A390BAS_InstituteModifier = GX_Parm6;
         n390BAS_InstituteModifier = false;
         A391BAS_InstituteModifyTime = GX_Parm7;
         n391BAS_InstituteModifyTime = false;
         A392BAS_InstituteIsDeleted = GX_Parm8;
         A393BAS_InstituteDescription = GX_Parm9;
         n393BAS_InstituteDescription = false;
         context.wbHandled = 1;
         AfterKeyLoadScreen( ) ;
         Draw( ) ;
         send_integrity_footer_hashes( ) ;
         dynload_actions( ) ;
         if ( AnyError == 1 )
         {
         }
         isValidOutput.Add(A386InstituteName);
         isValidOutput.Add(context.PathToRelativeUrl( A387BAS_InstituteLogo));
         isValidOutput.Add(A387BAS_InstituteLogo);
         isValidOutput.Add(A388BAS_InstituteCreator);
         isValidOutput.Add(context.localUtil.TToC( A389BAS_InstituteCreateTime, 10, 8, 0, 0, "/", ":", " "));
         isValidOutput.Add(A390BAS_InstituteModifier);
         isValidOutput.Add(context.localUtil.TToC( A391BAS_InstituteModifyTime, 10, 8, 0, 0, "/", ":", " "));
         isValidOutput.Add(StringUtil.LTrim( StringUtil.NToC( (decimal)(A392BAS_InstituteIsDeleted), 1, 0, ".", "")));
         isValidOutput.Add(A393BAS_InstituteDescription);
         isValidOutput.Add(edtBAS_InstituteLogo_Filetype);
         isValidOutput.Add(edtBAS_InstituteLogo_Filename);
         isValidOutput.Add(StringUtil.RTrim( Gx_mode));
         isValidOutput.Add(Z358InstituteCode);
         isValidOutput.Add(Z386InstituteName);
         isValidOutput.Add(context.PathToRelativeUrl( Z387BAS_InstituteLogo));
         isValidOutput.Add(Z388BAS_InstituteCreator);
         isValidOutput.Add(context.localUtil.TToC( Z389BAS_InstituteCreateTime, 10, 8, 0, 0, "/", ":", " "));
         isValidOutput.Add(Z390BAS_InstituteModifier);
         isValidOutput.Add(context.localUtil.TToC( Z391BAS_InstituteModifyTime, 10, 8, 0, 0, "/", ":", " "));
         isValidOutput.Add(StringUtil.LTrim( StringUtil.NToC( (decimal)(Z392BAS_InstituteIsDeleted), 1, 0, ".", "")));
         isValidOutput.Add(Z393BAS_InstituteDescription);
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
         Z358InstituteCode = "";
         Z386InstituteName = "";
         Z388BAS_InstituteCreator = "";
         Z389BAS_InstituteCreateTime = (DateTime)(DateTime.MinValue);
         Z390BAS_InstituteModifier = "";
         Z391BAS_InstituteModifyTime = (DateTime)(DateTime.MinValue);
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
         A358InstituteCode = "";
         A386InstituteName = "";
         gxblobfileaux = new GxFile(context.GetPhysicalPath());
         A387BAS_InstituteLogo = "";
         A388BAS_InstituteCreator = "";
         A389BAS_InstituteCreateTime = (DateTime)(DateTime.MinValue);
         A390BAS_InstituteModifier = "";
         A391BAS_InstituteModifyTime = (DateTime)(DateTime.MinValue);
         A393BAS_InstituteDescription = "";
         bttBtn_enter_Jsonclick = "";
         bttBtn_cancel_Jsonclick = "";
         bttBtn_delete_Jsonclick = "";
         Gx_mode = "";
         GXCCtlgxBlob = "";
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         Z387BAS_InstituteLogo = "";
         Z393BAS_InstituteDescription = "";
         T001K4_A358InstituteCode = new String[] {""} ;
         T001K4_n358InstituteCode = new bool[] {false} ;
         T001K4_A386InstituteName = new String[] {""} ;
         T001K4_A388BAS_InstituteCreator = new String[] {""} ;
         T001K4_A389BAS_InstituteCreateTime = new DateTime[] {DateTime.MinValue} ;
         T001K4_A390BAS_InstituteModifier = new String[] {""} ;
         T001K4_n390BAS_InstituteModifier = new bool[] {false} ;
         T001K4_A391BAS_InstituteModifyTime = new DateTime[] {DateTime.MinValue} ;
         T001K4_n391BAS_InstituteModifyTime = new bool[] {false} ;
         T001K4_A392BAS_InstituteIsDeleted = new short[1] ;
         T001K4_A393BAS_InstituteDescription = new String[] {""} ;
         T001K4_n393BAS_InstituteDescription = new bool[] {false} ;
         T001K4_A387BAS_InstituteLogo = new String[] {""} ;
         T001K4_n387BAS_InstituteLogo = new bool[] {false} ;
         T001K5_A358InstituteCode = new String[] {""} ;
         T001K5_n358InstituteCode = new bool[] {false} ;
         T001K3_A358InstituteCode = new String[] {""} ;
         T001K3_n358InstituteCode = new bool[] {false} ;
         T001K3_A386InstituteName = new String[] {""} ;
         T001K3_A388BAS_InstituteCreator = new String[] {""} ;
         T001K3_A389BAS_InstituteCreateTime = new DateTime[] {DateTime.MinValue} ;
         T001K3_A390BAS_InstituteModifier = new String[] {""} ;
         T001K3_n390BAS_InstituteModifier = new bool[] {false} ;
         T001K3_A391BAS_InstituteModifyTime = new DateTime[] {DateTime.MinValue} ;
         T001K3_n391BAS_InstituteModifyTime = new bool[] {false} ;
         T001K3_A392BAS_InstituteIsDeleted = new short[1] ;
         T001K3_A393BAS_InstituteDescription = new String[] {""} ;
         T001K3_n393BAS_InstituteDescription = new bool[] {false} ;
         T001K3_A387BAS_InstituteLogo = new String[] {""} ;
         T001K3_n387BAS_InstituteLogo = new bool[] {false} ;
         sMode57 = "";
         T001K6_A358InstituteCode = new String[] {""} ;
         T001K6_n358InstituteCode = new bool[] {false} ;
         T001K7_A358InstituteCode = new String[] {""} ;
         T001K7_n358InstituteCode = new bool[] {false} ;
         T001K2_A358InstituteCode = new String[] {""} ;
         T001K2_n358InstituteCode = new bool[] {false} ;
         T001K2_A386InstituteName = new String[] {""} ;
         T001K2_A388BAS_InstituteCreator = new String[] {""} ;
         T001K2_A389BAS_InstituteCreateTime = new DateTime[] {DateTime.MinValue} ;
         T001K2_A390BAS_InstituteModifier = new String[] {""} ;
         T001K2_n390BAS_InstituteModifier = new bool[] {false} ;
         T001K2_A391BAS_InstituteModifyTime = new DateTime[] {DateTime.MinValue} ;
         T001K2_n391BAS_InstituteModifyTime = new bool[] {false} ;
         T001K2_A392BAS_InstituteIsDeleted = new short[1] ;
         T001K2_A393BAS_InstituteDescription = new String[] {""} ;
         T001K2_n393BAS_InstituteDescription = new bool[] {false} ;
         T001K2_A387BAS_InstituteLogo = new String[] {""} ;
         T001K2_n387BAS_InstituteLogo = new bool[] {false} ;
         T001K12_A360BAS_TenantTenantCode = new String[] {""} ;
         T001K13_A358InstituteCode = new String[] {""} ;
         T001K13_n358InstituteCode = new bool[] {false} ;
         T001K13_A359UserID = new Guid[] {Guid.Empty} ;
         T001K14_A358InstituteCode = new String[] {""} ;
         T001K14_n358InstituteCode = new bool[] {false} ;
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         isValidOutput = new GxUnknownObjectCollection();
         pr_datastore1 = new DataStoreProvider(context, new GeneXus.Programs.bas_institute__datastore1(),
            new Object[][] {
                new Object[] {
               T001K2_A358InstituteCode, T001K2_A386InstituteName, T001K2_A388BAS_InstituteCreator, T001K2_A389BAS_InstituteCreateTime, T001K2_A390BAS_InstituteModifier, T001K2_n390BAS_InstituteModifier, T001K2_A391BAS_InstituteModifyTime, T001K2_n391BAS_InstituteModifyTime, T001K2_A392BAS_InstituteIsDeleted, T001K2_A393BAS_InstituteDescription,
               T001K2_n393BAS_InstituteDescription, T001K2_A387BAS_InstituteLogo, T001K2_n387BAS_InstituteLogo
               }
               , new Object[] {
               T001K3_A358InstituteCode, T001K3_A386InstituteName, T001K3_A388BAS_InstituteCreator, T001K3_A389BAS_InstituteCreateTime, T001K3_A390BAS_InstituteModifier, T001K3_n390BAS_InstituteModifier, T001K3_A391BAS_InstituteModifyTime, T001K3_n391BAS_InstituteModifyTime, T001K3_A392BAS_InstituteIsDeleted, T001K3_A393BAS_InstituteDescription,
               T001K3_n393BAS_InstituteDescription, T001K3_A387BAS_InstituteLogo, T001K3_n387BAS_InstituteLogo
               }
               , new Object[] {
               T001K4_A358InstituteCode, T001K4_A386InstituteName, T001K4_A388BAS_InstituteCreator, T001K4_A389BAS_InstituteCreateTime, T001K4_A390BAS_InstituteModifier, T001K4_n390BAS_InstituteModifier, T001K4_A391BAS_InstituteModifyTime, T001K4_n391BAS_InstituteModifyTime, T001K4_A392BAS_InstituteIsDeleted, T001K4_A393BAS_InstituteDescription,
               T001K4_n393BAS_InstituteDescription, T001K4_A387BAS_InstituteLogo, T001K4_n387BAS_InstituteLogo
               }
               , new Object[] {
               T001K5_A358InstituteCode
               }
               , new Object[] {
               T001K6_A358InstituteCode
               }
               , new Object[] {
               T001K7_A358InstituteCode
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
               T001K12_A360BAS_TenantTenantCode
               }
               , new Object[] {
               T001K13_A358InstituteCode, T001K13_A359UserID
               }
               , new Object[] {
               T001K14_A358InstituteCode
               }
            }
         );
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.bas_institute__default(),
            new Object[][] {
            }
         );
      }

      private short Z392BAS_InstituteIsDeleted ;
      private short GxWebError ;
      private short gxcookieaux ;
      private short IsConfirmed ;
      private short IsModified ;
      private short AnyError ;
      private short nKeyPressed ;
      private short initialized ;
      private short A392BAS_InstituteIsDeleted ;
      private short GX_JID ;
      private short RcdFound57 ;
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
      private int edtInstituteName_Enabled ;
      private int edtBAS_InstituteLogo_Enabled ;
      private int edtBAS_InstituteCreator_Enabled ;
      private int edtBAS_InstituteCreateTime_Enabled ;
      private int edtBAS_InstituteModifier_Enabled ;
      private int edtBAS_InstituteModifyTime_Enabled ;
      private int edtBAS_InstituteIsDeleted_Enabled ;
      private int edtBAS_InstituteDescription_Enabled ;
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
      private String edtInstituteName_Internalname ;
      private String edtInstituteName_Jsonclick ;
      private String edtBAS_InstituteLogo_Internalname ;
      private String edtBAS_InstituteLogo_Filetype ;
      private String edtBAS_InstituteLogo_Contenttype ;
      private String edtBAS_InstituteLogo_Parameters ;
      private String edtBAS_InstituteLogo_Jsonclick ;
      private String edtBAS_InstituteCreator_Internalname ;
      private String edtBAS_InstituteCreator_Jsonclick ;
      private String edtBAS_InstituteCreateTime_Internalname ;
      private String edtBAS_InstituteCreateTime_Jsonclick ;
      private String edtBAS_InstituteModifier_Internalname ;
      private String edtBAS_InstituteModifier_Jsonclick ;
      private String edtBAS_InstituteModifyTime_Internalname ;
      private String edtBAS_InstituteModifyTime_Jsonclick ;
      private String edtBAS_InstituteIsDeleted_Internalname ;
      private String edtBAS_InstituteIsDeleted_Jsonclick ;
      private String edtBAS_InstituteDescription_Internalname ;
      private String bttBtn_enter_Internalname ;
      private String bttBtn_enter_Jsonclick ;
      private String bttBtn_cancel_Internalname ;
      private String bttBtn_cancel_Jsonclick ;
      private String bttBtn_delete_Internalname ;
      private String bttBtn_delete_Jsonclick ;
      private String Gx_mode ;
      private String edtBAS_InstituteLogo_Filename ;
      private String GXCCtlgxBlob ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String sMode57 ;
      private String sDynURL ;
      private String FormProcess ;
      private String bodyStyle ;
      private DateTime Z389BAS_InstituteCreateTime ;
      private DateTime Z391BAS_InstituteModifyTime ;
      private DateTime A389BAS_InstituteCreateTime ;
      private DateTime A391BAS_InstituteModifyTime ;
      private bool entryPointCalled ;
      private bool toggleJsOutput ;
      private bool wbErr ;
      private bool n387BAS_InstituteLogo ;
      private bool n358InstituteCode ;
      private bool n390BAS_InstituteModifier ;
      private bool n391BAS_InstituteModifyTime ;
      private bool n393BAS_InstituteDescription ;
      private bool Gx_longc ;
      private String A393BAS_InstituteDescription ;
      private String Z393BAS_InstituteDescription ;
      private String Z358InstituteCode ;
      private String Z386InstituteName ;
      private String Z388BAS_InstituteCreator ;
      private String Z390BAS_InstituteModifier ;
      private String A358InstituteCode ;
      private String A386InstituteName ;
      private String A388BAS_InstituteCreator ;
      private String A390BAS_InstituteModifier ;
      private String A387BAS_InstituteLogo ;
      private String Z387BAS_InstituteLogo ;
      private GxUnknownObjectCollection isValidOutput ;
      private GxFile gxblobfileaux ;
      private IGxDataStore dsDataStore1 ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_datastore1 ;
      private String[] T001K4_A358InstituteCode ;
      private bool[] T001K4_n358InstituteCode ;
      private String[] T001K4_A386InstituteName ;
      private String[] T001K4_A388BAS_InstituteCreator ;
      private DateTime[] T001K4_A389BAS_InstituteCreateTime ;
      private String[] T001K4_A390BAS_InstituteModifier ;
      private bool[] T001K4_n390BAS_InstituteModifier ;
      private DateTime[] T001K4_A391BAS_InstituteModifyTime ;
      private bool[] T001K4_n391BAS_InstituteModifyTime ;
      private short[] T001K4_A392BAS_InstituteIsDeleted ;
      private String[] T001K4_A393BAS_InstituteDescription ;
      private bool[] T001K4_n393BAS_InstituteDescription ;
      private String[] T001K4_A387BAS_InstituteLogo ;
      private bool[] T001K4_n387BAS_InstituteLogo ;
      private String[] T001K5_A358InstituteCode ;
      private bool[] T001K5_n358InstituteCode ;
      private String[] T001K3_A358InstituteCode ;
      private bool[] T001K3_n358InstituteCode ;
      private String[] T001K3_A386InstituteName ;
      private String[] T001K3_A388BAS_InstituteCreator ;
      private DateTime[] T001K3_A389BAS_InstituteCreateTime ;
      private String[] T001K3_A390BAS_InstituteModifier ;
      private bool[] T001K3_n390BAS_InstituteModifier ;
      private DateTime[] T001K3_A391BAS_InstituteModifyTime ;
      private bool[] T001K3_n391BAS_InstituteModifyTime ;
      private short[] T001K3_A392BAS_InstituteIsDeleted ;
      private String[] T001K3_A393BAS_InstituteDescription ;
      private bool[] T001K3_n393BAS_InstituteDescription ;
      private String[] T001K3_A387BAS_InstituteLogo ;
      private bool[] T001K3_n387BAS_InstituteLogo ;
      private String[] T001K6_A358InstituteCode ;
      private bool[] T001K6_n358InstituteCode ;
      private String[] T001K7_A358InstituteCode ;
      private bool[] T001K7_n358InstituteCode ;
      private String[] T001K2_A358InstituteCode ;
      private bool[] T001K2_n358InstituteCode ;
      private String[] T001K2_A386InstituteName ;
      private String[] T001K2_A388BAS_InstituteCreator ;
      private DateTime[] T001K2_A389BAS_InstituteCreateTime ;
      private String[] T001K2_A390BAS_InstituteModifier ;
      private bool[] T001K2_n390BAS_InstituteModifier ;
      private DateTime[] T001K2_A391BAS_InstituteModifyTime ;
      private bool[] T001K2_n391BAS_InstituteModifyTime ;
      private short[] T001K2_A392BAS_InstituteIsDeleted ;
      private String[] T001K2_A393BAS_InstituteDescription ;
      private bool[] T001K2_n393BAS_InstituteDescription ;
      private String[] T001K2_A387BAS_InstituteLogo ;
      private bool[] T001K2_n387BAS_InstituteLogo ;
      private String[] T001K12_A360BAS_TenantTenantCode ;
      private String[] T001K13_A358InstituteCode ;
      private bool[] T001K13_n358InstituteCode ;
      private Guid[] T001K13_A359UserID ;
      private IDataStoreProvider pr_default ;
      private String[] T001K14_A358InstituteCode ;
      private bool[] T001K14_n358InstituteCode ;
      private GXWebForm Form ;
   }

   public class bas_institute__datastore1 : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmT001K4 ;
          prmT001K4 = new Object[] {
          new Object[] {"@InstituteCode",SqlDbType.NVarChar,20,0}
          } ;
          Object[] prmT001K5 ;
          prmT001K5 = new Object[] {
          new Object[] {"@InstituteCode",SqlDbType.NVarChar,20,0}
          } ;
          Object[] prmT001K3 ;
          prmT001K3 = new Object[] {
          new Object[] {"@InstituteCode",SqlDbType.NVarChar,20,0}
          } ;
          Object[] prmT001K6 ;
          prmT001K6 = new Object[] {
          new Object[] {"@InstituteCode",SqlDbType.NVarChar,20,0}
          } ;
          Object[] prmT001K7 ;
          prmT001K7 = new Object[] {
          new Object[] {"@InstituteCode",SqlDbType.NVarChar,20,0}
          } ;
          Object[] prmT001K2 ;
          prmT001K2 = new Object[] {
          new Object[] {"@InstituteCode",SqlDbType.NVarChar,20,0}
          } ;
          Object[] prmT001K8 ;
          prmT001K8 = new Object[] {
          new Object[] {"@InstituteCode",SqlDbType.NVarChar,20,0} ,
          new Object[] {"@InstituteName",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@BAS_InstituteLogo",SqlDbType.VarBinary,1024,0} ,
          new Object[] {"@BAS_InstituteCreator",SqlDbType.NVarChar,50,0} ,
          new Object[] {"@BAS_InstituteCreateTime",SqlDbType.DateTime,10,8} ,
          new Object[] {"@BAS_InstituteModifier",SqlDbType.NVarChar,50,0} ,
          new Object[] {"@BAS_InstituteModifyTime",SqlDbType.DateTime,10,8} ,
          new Object[] {"@BAS_InstituteIsDeleted",SqlDbType.SmallInt,1,0} ,
          new Object[] {"@BAS_InstituteDescription",SqlDbType.NVarChar,2048,0}
          } ;
          Object[] prmT001K9 ;
          prmT001K9 = new Object[] {
          new Object[] {"@InstituteName",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@BAS_InstituteCreator",SqlDbType.NVarChar,50,0} ,
          new Object[] {"@BAS_InstituteCreateTime",SqlDbType.DateTime,10,8} ,
          new Object[] {"@BAS_InstituteModifier",SqlDbType.NVarChar,50,0} ,
          new Object[] {"@BAS_InstituteModifyTime",SqlDbType.DateTime,10,8} ,
          new Object[] {"@BAS_InstituteIsDeleted",SqlDbType.SmallInt,1,0} ,
          new Object[] {"@BAS_InstituteDescription",SqlDbType.NVarChar,2048,0} ,
          new Object[] {"@InstituteCode",SqlDbType.NVarChar,20,0}
          } ;
          Object[] prmT001K10 ;
          prmT001K10 = new Object[] {
          new Object[] {"@BAS_InstituteLogo",SqlDbType.VarBinary,1024,0} ,
          new Object[] {"@InstituteCode",SqlDbType.NVarChar,20,0}
          } ;
          Object[] prmT001K11 ;
          prmT001K11 = new Object[] {
          new Object[] {"@InstituteCode",SqlDbType.NVarChar,20,0}
          } ;
          Object[] prmT001K12 ;
          prmT001K12 = new Object[] {
          new Object[] {"@InstituteCode",SqlDbType.NVarChar,20,0}
          } ;
          Object[] prmT001K13 ;
          prmT001K13 = new Object[] {
          new Object[] {"@InstituteCode",SqlDbType.NVarChar,20,0}
          } ;
          Object[] prmT001K14 ;
          prmT001K14 = new Object[] {
          } ;
          def= new CursorDef[] {
              new CursorDef("T001K2", "SELECT [InstituteCode], [InstituteName], [Creator] AS BAS_InstituteCreator, [CreateTime] AS BAS_InstituteCreateTime, [Modifier] AS BAS_InstituteModifier, [ModifyTime] AS BAS_InstituteModifyTime, [IsDeleted] AS BAS_InstituteIsDeleted, [Description] AS BAS_InstituteDescription, [Logo] AS BAS_InstituteLogo FROM dbo.[BAS_Institute] WITH (UPDLOCK) WHERE [InstituteCode] = @InstituteCode ",true, GxErrorMask.GX_NOMASK, false, this,prmT001K2,1,0,true,false )
             ,new CursorDef("T001K3", "SELECT [InstituteCode], [InstituteName], [Creator] AS BAS_InstituteCreator, [CreateTime] AS BAS_InstituteCreateTime, [Modifier] AS BAS_InstituteModifier, [ModifyTime] AS BAS_InstituteModifyTime, [IsDeleted] AS BAS_InstituteIsDeleted, [Description] AS BAS_InstituteDescription, [Logo] AS BAS_InstituteLogo FROM dbo.[BAS_Institute] WITH (NOLOCK) WHERE [InstituteCode] = @InstituteCode ",true, GxErrorMask.GX_NOMASK, false, this,prmT001K3,1,0,true,false )
             ,new CursorDef("T001K4", "SELECT TM1.[InstituteCode], TM1.[InstituteName], TM1.[Creator] AS BAS_InstituteCreator, TM1.[CreateTime] AS BAS_InstituteCreateTime, TM1.[Modifier] AS BAS_InstituteModifier, TM1.[ModifyTime] AS BAS_InstituteModifyTime, TM1.[IsDeleted] AS BAS_InstituteIsDeleted, TM1.[Description] AS BAS_InstituteDescription, TM1.[Logo] AS BAS_InstituteLogo FROM dbo.[BAS_Institute] TM1 WITH (NOLOCK) WHERE TM1.[InstituteCode] = @InstituteCode ORDER BY TM1.[InstituteCode]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT001K4,100,0,true,false )
             ,new CursorDef("T001K5", "SELECT [InstituteCode] FROM dbo.[BAS_Institute] WITH (NOLOCK) WHERE [InstituteCode] = @InstituteCode  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT001K5,1,0,true,false )
             ,new CursorDef("T001K6", "SELECT TOP 1 [InstituteCode] FROM dbo.[BAS_Institute] WITH (NOLOCK) WHERE ( [InstituteCode] > @InstituteCode) ORDER BY [InstituteCode]  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT001K6,1,0,true,true )
             ,new CursorDef("T001K7", "SELECT TOP 1 [InstituteCode] FROM dbo.[BAS_Institute] WITH (NOLOCK) WHERE ( [InstituteCode] < @InstituteCode) ORDER BY [InstituteCode] DESC  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT001K7,1,0,true,true )
             ,new CursorDef("T001K8", "INSERT INTO dbo.[BAS_Institute]([InstituteCode], [InstituteName], [Logo], [Creator], [CreateTime], [Modifier], [ModifyTime], [IsDeleted], [Description]) VALUES(@InstituteCode, @InstituteName, @BAS_InstituteLogo, @BAS_InstituteCreator, @BAS_InstituteCreateTime, @BAS_InstituteModifier, @BAS_InstituteModifyTime, @BAS_InstituteIsDeleted, @BAS_InstituteDescription)", GxErrorMask.GX_NOMASK,prmT001K8)
             ,new CursorDef("T001K9", "UPDATE dbo.[BAS_Institute] SET [InstituteName]=@InstituteName, [Creator]=@BAS_InstituteCreator, [CreateTime]=@BAS_InstituteCreateTime, [Modifier]=@BAS_InstituteModifier, [ModifyTime]=@BAS_InstituteModifyTime, [IsDeleted]=@BAS_InstituteIsDeleted, [Description]=@BAS_InstituteDescription  WHERE [InstituteCode] = @InstituteCode", GxErrorMask.GX_NOMASK,prmT001K9)
             ,new CursorDef("T001K10", "UPDATE dbo.[BAS_Institute] SET [Logo]=@BAS_InstituteLogo  WHERE [InstituteCode] = @InstituteCode", GxErrorMask.GX_NOMASK,prmT001K10)
             ,new CursorDef("T001K11", "DELETE FROM dbo.[BAS_Institute]  WHERE [InstituteCode] = @InstituteCode", GxErrorMask.GX_NOMASK,prmT001K11)
             ,new CursorDef("T001K12", "SELECT TOP 1 [TenantCode] FROM dbo.[BAS_Tenant] WITH (NOLOCK) WHERE [InstituteCode] = @InstituteCode ",true, GxErrorMask.GX_NOMASK, false, this,prmT001K12,1,0,true,true )
             ,new CursorDef("T001K13", "SELECT TOP 1 [InstituteCode], [UserID] FROM dbo.[SYS_InstituteUser] WITH (NOLOCK) WHERE [InstituteCode] = @InstituteCode ",true, GxErrorMask.GX_NOMASK, false, this,prmT001K13,1,0,true,true )
             ,new CursorDef("T001K14", "SELECT [InstituteCode] FROM dbo.[BAS_Institute] WITH (NOLOCK) ORDER BY [InstituteCode]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT001K14,100,0,true,false )
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
                ((DateTime[]) buf[3])[0] = rslt.getGXDateTime(4) ;
                ((String[]) buf[4])[0] = rslt.getVarchar(5) ;
                ((bool[]) buf[5])[0] = rslt.wasNull(5);
                ((DateTime[]) buf[6])[0] = rslt.getGXDateTime(6) ;
                ((bool[]) buf[7])[0] = rslt.wasNull(6);
                ((short[]) buf[8])[0] = rslt.getShort(7) ;
                ((String[]) buf[9])[0] = rslt.getLongVarchar(8) ;
                ((bool[]) buf[10])[0] = rslt.wasNull(8);
                ((String[]) buf[11])[0] = rslt.getBLOBFile(9, "tmp", "") ;
                ((bool[]) buf[12])[0] = rslt.wasNull(9);
                return;
             case 1 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((String[]) buf[2])[0] = rslt.getVarchar(3) ;
                ((DateTime[]) buf[3])[0] = rslt.getGXDateTime(4) ;
                ((String[]) buf[4])[0] = rslt.getVarchar(5) ;
                ((bool[]) buf[5])[0] = rslt.wasNull(5);
                ((DateTime[]) buf[6])[0] = rslt.getGXDateTime(6) ;
                ((bool[]) buf[7])[0] = rslt.wasNull(6);
                ((short[]) buf[8])[0] = rslt.getShort(7) ;
                ((String[]) buf[9])[0] = rslt.getLongVarchar(8) ;
                ((bool[]) buf[10])[0] = rslt.wasNull(8);
                ((String[]) buf[11])[0] = rslt.getBLOBFile(9, "tmp", "") ;
                ((bool[]) buf[12])[0] = rslt.wasNull(9);
                return;
             case 2 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((String[]) buf[2])[0] = rslt.getVarchar(3) ;
                ((DateTime[]) buf[3])[0] = rslt.getGXDateTime(4) ;
                ((String[]) buf[4])[0] = rslt.getVarchar(5) ;
                ((bool[]) buf[5])[0] = rslt.wasNull(5);
                ((DateTime[]) buf[6])[0] = rslt.getGXDateTime(6) ;
                ((bool[]) buf[7])[0] = rslt.wasNull(6);
                ((short[]) buf[8])[0] = rslt.getShort(7) ;
                ((String[]) buf[9])[0] = rslt.getLongVarchar(8) ;
                ((bool[]) buf[10])[0] = rslt.wasNull(8);
                ((String[]) buf[11])[0] = rslt.getBLOBFile(9, "tmp", "") ;
                ((bool[]) buf[12])[0] = rslt.wasNull(9);
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
             case 10 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                return;
             case 11 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((Guid[]) buf[1])[0] = rslt.getGuid(2) ;
                return;
             case 12 :
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
                if ( (bool)parms[0] )
                {
                   stmt.setNull( 1 , SqlDbType.NVarChar );
                }
                else
                {
                   stmt.SetParameter(1, (String)parms[1]);
                }
                return;
             case 1 :
                if ( (bool)parms[0] )
                {
                   stmt.setNull( 1 , SqlDbType.NVarChar );
                }
                else
                {
                   stmt.SetParameter(1, (String)parms[1]);
                }
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
                if ( (bool)parms[0] )
                {
                   stmt.setNull( 1 , SqlDbType.NVarChar );
                }
                else
                {
                   stmt.SetParameter(1, (String)parms[1]);
                }
                return;
             case 4 :
                if ( (bool)parms[0] )
                {
                   stmt.setNull( 1 , SqlDbType.NVarChar );
                }
                else
                {
                   stmt.SetParameter(1, (String)parms[1]);
                }
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
                if ( (bool)parms[0] )
                {
                   stmt.setNull( 1 , SqlDbType.NVarChar );
                }
                else
                {
                   stmt.SetParameter(1, (String)parms[1]);
                }
                stmt.SetParameter(2, (String)parms[2]);
                if ( (bool)parms[3] )
                {
                   stmt.setNull( 3 , SqlDbType.VarBinary );
                }
                else
                {
                   stmt.SetParameterBlob(3, (String)parms[4], true);
                }
                stmt.SetParameter(4, (String)parms[5]);
                stmt.SetParameterDatetime(5, (DateTime)parms[6]);
                if ( (bool)parms[7] )
                {
                   stmt.setNull( 6 , SqlDbType.NVarChar );
                }
                else
                {
                   stmt.SetParameter(6, (String)parms[8]);
                }
                if ( (bool)parms[9] )
                {
                   stmt.setNull( 7 , SqlDbType.DateTime );
                }
                else
                {
                   stmt.SetParameterDatetime(7, (DateTime)parms[10]);
                }
                stmt.SetParameter(8, (short)parms[11]);
                if ( (bool)parms[12] )
                {
                   stmt.setNull( 9 , SqlDbType.NVarChar );
                }
                else
                {
                   stmt.SetParameter(9, (String)parms[13]);
                }
                return;
             case 7 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                stmt.SetParameterDatetime(3, (DateTime)parms[2]);
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
                   stmt.setNull( 5 , SqlDbType.DateTime );
                }
                else
                {
                   stmt.SetParameterDatetime(5, (DateTime)parms[6]);
                }
                stmt.SetParameter(6, (short)parms[7]);
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
                   stmt.setNull( 8 , SqlDbType.NVarChar );
                }
                else
                {
                   stmt.SetParameter(8, (String)parms[11]);
                }
                return;
             case 8 :
                if ( (bool)parms[0] )
                {
                   stmt.setNull( 1 , SqlDbType.VarBinary );
                }
                else
                {
                   stmt.SetParameterBlob(1, (String)parms[1], true);
                }
                if ( (bool)parms[2] )
                {
                   stmt.setNull( 2 , SqlDbType.NVarChar );
                }
                else
                {
                   stmt.SetParameter(2, (String)parms[3]);
                }
                return;
             case 9 :
                if ( (bool)parms[0] )
                {
                   stmt.setNull( 1 , SqlDbType.NVarChar );
                }
                else
                {
                   stmt.SetParameter(1, (String)parms[1]);
                }
                return;
             case 10 :
                if ( (bool)parms[0] )
                {
                   stmt.setNull( 1 , SqlDbType.NVarChar );
                }
                else
                {
                   stmt.SetParameter(1, (String)parms[1]);
                }
                return;
             case 11 :
                if ( (bool)parms[0] )
                {
                   stmt.setNull( 1 , SqlDbType.NVarChar );
                }
                else
                {
                   stmt.SetParameter(1, (String)parms[1]);
                }
                return;
       }
    }

    public String getDataStoreName( )
    {
       return "DATASTORE1";
    }

 }

 public class bas_institute__default : DataStoreHelperBase, IDataStoreHelper
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
