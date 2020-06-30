/*
               File: SecFunctionality
        Description: 权限
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/28/2020 15:6:19.35
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
   public class secfunctionality : GXDataArea, System.Web.SessionState.IRequiresSessionState
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
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxExecAct_"+"gxLoad_11") == 0 )
         {
            A2SecParentFunctionalityId = (long)(NumberUtil.Val( GetNextPar( ), "."));
            n2SecParentFunctionalityId = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A2SecParentFunctionalityId", StringUtil.LTrim( StringUtil.Str( (decimal)(A2SecParentFunctionalityId), 10, 0)));
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            gxLoad_11( A2SecParentFunctionalityId) ;
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
               AV7SecFunctionalityId = (long)(NumberUtil.Val( GetNextPar( ), "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7SecFunctionalityId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV7SecFunctionalityId), 10, 0)));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vSECFUNCTIONALITYID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV7SecFunctionalityId), "ZZZZZZZZZ9"), context));
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
            Form.Meta.addItem("description", "权限", 0) ;
         }
         context.wjLoc = "";
         context.nUserReturn = 0;
         context.wbHandled = 0;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         GX_FocusControl = edtSecFunctionalityKey_Internalname;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         wbErr = false;
         context.SetDefaultTheme("WorkWithPlusTheme");
         if ( ! context.IsLocalStorageSupported( ) )
         {
            context.PushCurrentUrl();
         }
      }

      public secfunctionality( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public secfunctionality( IGxContext context )
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
                           long aP1_SecFunctionalityId )
      {
         this.Gx_mode = aP0_Gx_mode;
         this.AV7SecFunctionalityId = aP1_SecFunctionalityId;
         executePrivate();
      }

      void executePrivate( )
      {
         isStatic = false;
         webExecute();
      }

      protected override void createObjects( )
      {
         cmbSecFunctionalityType = new GXCombobox();
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
         if ( cmbSecFunctionalityType.ItemCount > 0 )
         {
            A9SecFunctionalityType = (short)(NumberUtil.Val( cmbSecFunctionalityType.getValidValue(StringUtil.Trim( StringUtil.Str( (decimal)(A9SecFunctionalityType), 2, 0))), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A9SecFunctionalityType", StringUtil.LTrim( StringUtil.Str( (decimal)(A9SecFunctionalityType), 2, 0)));
         }
         if ( context.isAjaxRequest( ) )
         {
            cmbSecFunctionalityType.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(A9SecFunctionalityType), 2, 0));
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbSecFunctionalityType_Internalname, "Values", cmbSecFunctionalityType.ToJavascriptSource(), true);
         }
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
            GxWebStd.gx_msg_list( context, "", context.GX_msglist.DisplayMode, "", "", "", "false");
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
            /* Div Control */
            GxWebStd.gx_div_start( context, divTablecontent_Internalname, 1, 0, "px", 0, "px", "TableContent", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
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
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtSecFunctionalityKey_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtSecFunctionalityKey_Internalname, "名称", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 22,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtSecFunctionalityKey_Internalname, A3SecFunctionalityKey, StringUtil.RTrim( context.localUtil.Format( A3SecFunctionalityKey, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,22);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtSecFunctionalityKey_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtSecFunctionalityKey_Enabled, 0, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_WWPBaseObjects\\SecFunctionality.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtSecFunctionalityDescription_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtSecFunctionalityDescription_Internalname, "描述", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 26,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtSecFunctionalityDescription_Internalname, A8SecFunctionalityDescription, StringUtil.RTrim( context.localUtil.Format( A8SecFunctionalityDescription, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,26);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtSecFunctionalityDescription_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtSecFunctionalityDescription_Enabled, 0, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_WWPBaseObjects\\SecFunctionality.htm");
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
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 31,'',false,'',0)\"";
            ClassString = "ButtonMaterial";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtntrn_enter_Internalname, "", "保存", bttBtntrn_enter_Jsonclick, 5, "确认", "", StyleString, ClassString, bttBtntrn_enter_Visible, bttBtntrn_enter_Enabled, "standard", "'"+""+"'"+",false,"+"'"+"EENTER."+"'", TempTags, "", context.GetButtonType( ), "HLP_WWPBaseObjects\\SecFunctionality.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 33,'',false,'',0)\"";
            ClassString = "ButtonMaterialDefault";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtntrn_cancel_Internalname, "", "取消", bttBtntrn_cancel_Jsonclick, 1, "取消", "", StyleString, ClassString, bttBtntrn_cancel_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ECANCEL."+"'", TempTags, "", context.GetButtonType( ), "HLP_WWPBaseObjects\\SecFunctionality.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 35,'',false,'',0)\"";
            ClassString = "ButtonMaterialDefault";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtntrn_delete_Internalname, "", "删除", bttBtntrn_delete_Jsonclick, 5, "删除", "", StyleString, ClassString, bttBtntrn_delete_Visible, bttBtntrn_delete_Enabled, "standard", "'"+""+"'"+",false,"+"'"+"EDELETE."+"'", TempTags, "", context.GetButtonType( ), "HLP_WWPBaseObjects\\SecFunctionality.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
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
            GxWebStd.gx_div_start( context, divHtml_bottomauxiliarcontrols_Internalname, 1, 0, "px", 0, "px", "Section", "left", "top", "", "", "div");
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtSecFunctionalityId_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A1SecFunctionalityId), 10, 0, ".", "")), ((edtSecFunctionalityId_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A1SecFunctionalityId), "ZZZZZZZZZ9")) : context.localUtil.Format( (decimal)(A1SecFunctionalityId), "ZZZZZZZZZ9")), "", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtSecFunctionalityId_Jsonclick, 0, "Attribute", "", "", "", "", edtSecFunctionalityId_Visible, edtSecFunctionalityId_Enabled, 0, "number", "1", 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_WWPBaseObjects\\SecFunctionality.htm");
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, cmbSecFunctionalityType, cmbSecFunctionalityType_Internalname, StringUtil.Trim( StringUtil.Str( (decimal)(A9SecFunctionalityType), 2, 0)), 1, cmbSecFunctionalityType_Jsonclick, 0, "'"+""+"'"+",false,"+"'"+""+"'", "int", "", cmbSecFunctionalityType.Visible, cmbSecFunctionalityType.Enabled, 0, 0, 0, "em", 0, "", "", "Attribute", "", "", "", "", true, "HLP_WWPBaseObjects\\SecFunctionality.htm");
            cmbSecFunctionalityType.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(A9SecFunctionalityType), 2, 0));
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbSecFunctionalityType_Internalname, "Values", (String)(cmbSecFunctionalityType.ToJavascriptSource()), true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 41,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtSecParentFunctionalityId_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A2SecParentFunctionalityId), 10, 0, ".", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(A2SecParentFunctionalityId), "ZZZZZZZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,41);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtSecParentFunctionalityId_Jsonclick, 0, "Attribute", "", "", "", "", edtSecParentFunctionalityId_Visible, edtSecParentFunctionalityId_Enabled, 1, "number", "1", 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_WWPBaseObjects\\SecFunctionality.htm");
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtSecParentFunctionalityDescription_Internalname, A11SecParentFunctionalityDescription, StringUtil.RTrim( context.localUtil.Format( A11SecParentFunctionalityDescription, "")), "", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtSecParentFunctionalityDescription_Jsonclick, 0, "Attribute", "", "", "", "", edtSecParentFunctionalityDescription_Visible, edtSecParentFunctionalityDescription_Enabled, 0, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_WWPBaseObjects\\SecFunctionality.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 43,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtSecFunctionalityActive_Internalname, StringUtil.BoolToStr( A7SecFunctionalityActive), StringUtil.BoolToStr( A7SecFunctionalityActive), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,43);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtSecFunctionalityActive_Jsonclick, 0, "Attribute", "", "", "", "", edtSecFunctionalityActive_Visible, edtSecFunctionalityActive_Enabled, 0, "text", "", 4, "chr", 1, "row", 4, 0, 0, 0, 1, 0, 0, true, "", "right", false, "HLP_WWPBaseObjects\\SecFunctionality.htm");
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
         E11012 ();
         context.wbGlbDoneStart = 1;
         assign_properties_default( ) ;
         if ( AnyError == 0 )
         {
            if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
            {
               /* Read saved SDTs. */
               /* Read variables values. */
               A3SecFunctionalityKey = cgiGet( edtSecFunctionalityKey_Internalname);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A3SecFunctionalityKey", A3SecFunctionalityKey);
               A8SecFunctionalityDescription = cgiGet( edtSecFunctionalityDescription_Internalname);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A8SecFunctionalityDescription", A8SecFunctionalityDescription);
               A1SecFunctionalityId = (long)(context.localUtil.CToN( cgiGet( edtSecFunctionalityId_Internalname), ".", ","));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1SecFunctionalityId", StringUtil.LTrim( StringUtil.Str( (decimal)(A1SecFunctionalityId), 10, 0)));
               cmbSecFunctionalityType.CurrentValue = cgiGet( cmbSecFunctionalityType_Internalname);
               A9SecFunctionalityType = (short)(NumberUtil.Val( cgiGet( cmbSecFunctionalityType_Internalname), "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A9SecFunctionalityType", StringUtil.LTrim( StringUtil.Str( (decimal)(A9SecFunctionalityType), 2, 0)));
               if ( ( ( context.localUtil.CToN( cgiGet( edtSecParentFunctionalityId_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtSecParentFunctionalityId_Internalname), ".", ",") > Convert.ToDecimal( 9999999999L )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "SECPARENTFUNCTIONALITYID");
                  AnyError = 1;
                  GX_FocusControl = edtSecParentFunctionalityId_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A2SecParentFunctionalityId = 0;
                  n2SecParentFunctionalityId = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A2SecParentFunctionalityId", StringUtil.LTrim( StringUtil.Str( (decimal)(A2SecParentFunctionalityId), 10, 0)));
               }
               else
               {
                  A2SecParentFunctionalityId = (long)(context.localUtil.CToN( cgiGet( edtSecParentFunctionalityId_Internalname), ".", ","));
                  n2SecParentFunctionalityId = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A2SecParentFunctionalityId", StringUtil.LTrim( StringUtil.Str( (decimal)(A2SecParentFunctionalityId), 10, 0)));
               }
               n2SecParentFunctionalityId = ((0==A2SecParentFunctionalityId) ? true : false);
               A11SecParentFunctionalityDescription = cgiGet( edtSecParentFunctionalityDescription_Internalname);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A11SecParentFunctionalityDescription", A11SecParentFunctionalityDescription);
               A7SecFunctionalityActive = StringUtil.StrToBool( cgiGet( edtSecFunctionalityActive_Internalname));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A7SecFunctionalityActive", A7SecFunctionalityActive);
               /* Read saved values. */
               Z1SecFunctionalityId = (long)(context.localUtil.CToN( cgiGet( "Z1SecFunctionalityId"), ".", ","));
               Z3SecFunctionalityKey = cgiGet( "Z3SecFunctionalityKey");
               Z8SecFunctionalityDescription = cgiGet( "Z8SecFunctionalityDescription");
               Z9SecFunctionalityType = (short)(context.localUtil.CToN( cgiGet( "Z9SecFunctionalityType"), ".", ","));
               Z7SecFunctionalityActive = StringUtil.StrToBool( cgiGet( "Z7SecFunctionalityActive"));
               Z2SecParentFunctionalityId = (long)(context.localUtil.CToN( cgiGet( "Z2SecParentFunctionalityId"), ".", ","));
               n2SecParentFunctionalityId = ((0==A2SecParentFunctionalityId) ? true : false);
               IsConfirmed = (short)(context.localUtil.CToN( cgiGet( "IsConfirmed"), ".", ","));
               IsModified = (short)(context.localUtil.CToN( cgiGet( "IsModified"), ".", ","));
               Gx_mode = cgiGet( "Mode");
               N2SecParentFunctionalityId = (long)(context.localUtil.CToN( cgiGet( "N2SecParentFunctionalityId"), ".", ","));
               n2SecParentFunctionalityId = ((0==A2SecParentFunctionalityId) ? true : false);
               AV7SecFunctionalityId = (long)(context.localUtil.CToN( cgiGet( "vSECFUNCTIONALITYID"), ".", ","));
               AV12Insert_SecParentFunctionalityId = (long)(context.localUtil.CToN( cgiGet( "vINSERT_SECPARENTFUNCTIONALITYID"), ".", ","));
               AV19Pgmname = cgiGet( "vPGMNAME");
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
               forbiddenHiddens = "hsh" + "SecFunctionality";
               A1SecFunctionalityId = (long)(context.localUtil.CToN( cgiGet( edtSecFunctionalityId_Internalname), ".", ","));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1SecFunctionalityId", StringUtil.LTrim( StringUtil.Str( (decimal)(A1SecFunctionalityId), 10, 0)));
               forbiddenHiddens = forbiddenHiddens + context.localUtil.Format( (decimal)(A1SecFunctionalityId), "ZZZZZZZZZ9");
               forbiddenHiddens = forbiddenHiddens + context.localUtil.Format( (decimal)(AV12Insert_SecParentFunctionalityId), "ZZZZZZZZZ9");
               forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!"));
               A9SecFunctionalityType = (short)(NumberUtil.Val( cgiGet( cmbSecFunctionalityType_Internalname), "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A9SecFunctionalityType", StringUtil.LTrim( StringUtil.Str( (decimal)(A9SecFunctionalityType), 2, 0)));
               forbiddenHiddens = forbiddenHiddens + context.localUtil.Format( (decimal)(A9SecFunctionalityType), "Z9");
               hsh = cgiGet( "hsh");
               if ( ( ! ( ( A1SecFunctionalityId != Z1SecFunctionalityId ) ) || ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) ) && ! GXUtil.CheckEncryptedHash( forbiddenHiddens, hsh, GXKey) )
               {
                  GXUtil.WriteLog("wwpbaseobjects.secfunctionality:[SecurityCheckFailed value for]"+"SecFunctionalityId:"+context.localUtil.Format( (decimal)(A1SecFunctionalityId), "ZZZZZZZZZ9"));
                  GXUtil.WriteLog("wwpbaseobjects.secfunctionality:[SecurityCheckFailed value for]"+"Insert_SecParentFunctionalityId:"+context.localUtil.Format( (decimal)(AV12Insert_SecParentFunctionalityId), "ZZZZZZZZZ9"));
                  GXUtil.WriteLog("wwpbaseobjects.secfunctionality:[SecurityCheckFailed value for]"+"Gx_mode:"+StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")));
                  GXUtil.WriteLog("wwpbaseobjects.secfunctionality:[SecurityCheckFailed value for]"+"SecFunctionalityType:"+context.localUtil.Format( (decimal)(A9SecFunctionalityType), "Z9"));
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
                  A1SecFunctionalityId = (long)(NumberUtil.Val( GetNextPar( ), "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1SecFunctionalityId", StringUtil.LTrim( StringUtil.Str( (decimal)(A1SecFunctionalityId), 10, 0)));
                  getEqualNoModal( ) ;
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
                     sMode1 = Gx_mode;
                     Gx_mode = "UPD";
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                     Gx_mode = sMode1;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                  }
                  standaloneModal( ) ;
                  if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
                  {
                     getByPrimaryKey( ) ;
                     if ( RcdFound1 == 1 )
                     {
                        if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
                        {
                           /* Confirm record */
                           CONFIRM_010( ) ;
                           if ( AnyError == 0 )
                           {
                              GX_FocusControl = bttBtntrn_enter_Internalname;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                           }
                        }
                     }
                     else
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_noinsert", ""), 1, "SECFUNCTIONALITYID");
                        AnyError = 1;
                        GX_FocusControl = edtSecFunctionalityId_Internalname;
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
                           E11012 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "AFTER TRN") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           /* Execute user event: After Trn */
                           E12012 ();
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
            E12012 ();
            trnEnded = 0;
            standaloneNotModal( ) ;
            standaloneModal( ) ;
            if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  )
            {
               /* Clear variables for new insertion. */
               InitAll011( ) ;
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
            DisableAttributes011( ) ;
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

      protected void CONFIRM_010( )
      {
         BeforeValidate011( ) ;
         if ( AnyError == 0 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
            {
               OnDeleteControls011( ) ;
            }
            else
            {
               CheckExtendedTable011( ) ;
               CloseExtendedTableCursors011( ) ;
            }
         }
         if ( AnyError == 0 )
         {
            IsConfirmed = 1;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "IsConfirmed", StringUtil.LTrim( StringUtil.Str( (decimal)(IsConfirmed), 4, 0)));
         }
      }

      protected void ResetCaption010( )
      {
      }

      protected void E11012( )
      {
         /* Start Routine */
         new GeneXus.Programs.wwpbaseobjects.loadwwpcontext(context ).execute( out  AV18WWPContext) ;
         AV10TrnContext.FromXml(AV11WebSession.Get("TrnContext"), null, "WWPTransactionContext", "DataAnalysisPlatform");
         if ( ( StringUtil.StrCmp(AV10TrnContext.gxTpr_Transactionname, AV19Pgmname) == 0 ) && ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) )
         {
            AV20GXV1 = 1;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV20GXV1", StringUtil.LTrim( StringUtil.Str( (decimal)(AV20GXV1), 8, 0)));
            while ( AV20GXV1 <= AV10TrnContext.gxTpr_Attributes.Count )
            {
               AV13TrnContextAtt = ((GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext_Attribute)AV10TrnContext.gxTpr_Attributes.Item(AV20GXV1));
               if ( StringUtil.StrCmp(AV13TrnContextAtt.gxTpr_Attributename, "SecParentFunctionalityId") == 0 )
               {
                  AV12Insert_SecParentFunctionalityId = (long)(NumberUtil.Val( AV13TrnContextAtt.gxTpr_Attributevalue, "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12Insert_SecParentFunctionalityId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV12Insert_SecParentFunctionalityId), 10, 0)));
               }
               AV20GXV1 = (int)(AV20GXV1+1);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV20GXV1", StringUtil.LTrim( StringUtil.Str( (decimal)(AV20GXV1), 8, 0)));
            }
         }
         edtSecFunctionalityId_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtSecFunctionalityId_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtSecFunctionalityId_Visible), 5, 0)), true);
         cmbSecFunctionalityType.Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbSecFunctionalityType_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(cmbSecFunctionalityType.Visible), 5, 0)), true);
         edtSecParentFunctionalityId_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtSecParentFunctionalityId_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtSecParentFunctionalityId_Visible), 5, 0)), true);
         edtSecParentFunctionalityDescription_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtSecParentFunctionalityDescription_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtSecParentFunctionalityDescription_Visible), 5, 0)), true);
         edtSecFunctionalityActive_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtSecFunctionalityActive_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtSecFunctionalityActive_Visible), 5, 0)), true);
      }

      protected void E12012( )
      {
         /* After Trn Routine */
         if ( ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 ) && ! AV10TrnContext.gxTpr_Callerondelete )
         {
            CallWebObject(formatLink("wwpbaseobjects.secfunctionalityww.aspx") );
            context.wjLocDisableFrm = 1;
         }
         context.setWebReturnParms(new Object[] {});
         context.setWebReturnParmsMetadata(new Object[] {});
         context.wjLocDisableFrm = 1;
         context.nUserReturn = 1;
         returnInSub = true;
         if (true) return;
      }

      protected void ZM011( short GX_JID )
      {
         if ( ( GX_JID == 9 ) || ( GX_JID == 0 ) )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
            {
               Z3SecFunctionalityKey = T00013_A3SecFunctionalityKey[0];
               Z8SecFunctionalityDescription = T00013_A8SecFunctionalityDescription[0];
               Z9SecFunctionalityType = T00013_A9SecFunctionalityType[0];
               Z7SecFunctionalityActive = T00013_A7SecFunctionalityActive[0];
               Z2SecParentFunctionalityId = T00013_A2SecParentFunctionalityId[0];
            }
            else
            {
               Z3SecFunctionalityKey = A3SecFunctionalityKey;
               Z8SecFunctionalityDescription = A8SecFunctionalityDescription;
               Z9SecFunctionalityType = A9SecFunctionalityType;
               Z7SecFunctionalityActive = A7SecFunctionalityActive;
               Z2SecParentFunctionalityId = A2SecParentFunctionalityId;
            }
         }
         if ( GX_JID == -9 )
         {
            Z1SecFunctionalityId = A1SecFunctionalityId;
            Z3SecFunctionalityKey = A3SecFunctionalityKey;
            Z8SecFunctionalityDescription = A8SecFunctionalityDescription;
            Z9SecFunctionalityType = A9SecFunctionalityType;
            Z7SecFunctionalityActive = A7SecFunctionalityActive;
            Z2SecParentFunctionalityId = A2SecParentFunctionalityId;
            Z11SecParentFunctionalityDescription = A11SecParentFunctionalityDescription;
         }
      }

      protected void standaloneNotModal( )
      {
         edtSecFunctionalityId_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtSecFunctionalityId_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtSecFunctionalityId_Enabled), 5, 0)), true);
         cmbSecFunctionalityType.Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbSecFunctionalityType_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(cmbSecFunctionalityType.Enabled), 5, 0)), true);
         AV19Pgmname = "WWPBaseObjects.SecFunctionality";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV19Pgmname", AV19Pgmname);
         edtSecFunctionalityId_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtSecFunctionalityId_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtSecFunctionalityId_Enabled), 5, 0)), true);
         cmbSecFunctionalityType.Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbSecFunctionalityType_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(cmbSecFunctionalityType.Enabled), 5, 0)), true);
         bttBtntrn_delete_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtntrn_delete_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtntrn_delete_Enabled), 5, 0)), true);
         if ( ! (0==AV7SecFunctionalityId) )
         {
            A1SecFunctionalityId = AV7SecFunctionalityId;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1SecFunctionalityId", StringUtil.LTrim( StringUtil.Str( (decimal)(A1SecFunctionalityId), 10, 0)));
         }
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) && ! (0==AV12Insert_SecParentFunctionalityId) )
         {
            edtSecParentFunctionalityId_Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtSecParentFunctionalityId_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtSecParentFunctionalityId_Enabled), 5, 0)), true);
         }
         else
         {
            edtSecParentFunctionalityId_Enabled = 1;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtSecParentFunctionalityId_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtSecParentFunctionalityId_Enabled), 5, 0)), true);
         }
      }

      protected void standaloneModal( )
      {
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) && ! (0==AV12Insert_SecParentFunctionalityId) )
         {
            A2SecParentFunctionalityId = AV12Insert_SecParentFunctionalityId;
            n2SecParentFunctionalityId = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A2SecParentFunctionalityId", StringUtil.LTrim( StringUtil.Str( (decimal)(A2SecParentFunctionalityId), 10, 0)));
         }
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
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) && ( Gx_BScreen == 0 ) )
         {
            /* Using cursor T00014 */
            pr_default.execute(2, new Object[] {n2SecParentFunctionalityId, A2SecParentFunctionalityId});
            A11SecParentFunctionalityDescription = T00014_A11SecParentFunctionalityDescription[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A11SecParentFunctionalityDescription", A11SecParentFunctionalityDescription);
            pr_default.close(2);
         }
      }

      protected void Load011( )
      {
         /* Using cursor T00015 */
         pr_default.execute(3, new Object[] {A1SecFunctionalityId});
         if ( (pr_default.getStatus(3) != 101) )
         {
            RcdFound1 = 1;
            A3SecFunctionalityKey = T00015_A3SecFunctionalityKey[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A3SecFunctionalityKey", A3SecFunctionalityKey);
            A8SecFunctionalityDescription = T00015_A8SecFunctionalityDescription[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A8SecFunctionalityDescription", A8SecFunctionalityDescription);
            A9SecFunctionalityType = T00015_A9SecFunctionalityType[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A9SecFunctionalityType", StringUtil.LTrim( StringUtil.Str( (decimal)(A9SecFunctionalityType), 2, 0)));
            A11SecParentFunctionalityDescription = T00015_A11SecParentFunctionalityDescription[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A11SecParentFunctionalityDescription", A11SecParentFunctionalityDescription);
            A7SecFunctionalityActive = T00015_A7SecFunctionalityActive[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A7SecFunctionalityActive", A7SecFunctionalityActive);
            A2SecParentFunctionalityId = T00015_A2SecParentFunctionalityId[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A2SecParentFunctionalityId", StringUtil.LTrim( StringUtil.Str( (decimal)(A2SecParentFunctionalityId), 10, 0)));
            n2SecParentFunctionalityId = T00015_n2SecParentFunctionalityId[0];
            ZM011( -9) ;
         }
         pr_default.close(3);
         OnLoadActions011( ) ;
      }

      protected void OnLoadActions011( )
      {
      }

      protected void CheckExtendedTable011( )
      {
         Gx_BScreen = 1;
         standaloneModal( ) ;
         /* Using cursor T00016 */
         pr_default.execute(4, new Object[] {A3SecFunctionalityKey, A1SecFunctionalityId});
         if ( (pr_default.getStatus(4) != 101) )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_1004", new   object[]  {"权限名称"}), 1, "SECFUNCTIONALITYKEY");
            AnyError = 1;
            GX_FocusControl = edtSecFunctionalityKey_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         pr_default.close(4);
         /* Using cursor T00014 */
         pr_default.execute(2, new Object[] {n2SecParentFunctionalityId, A2SecParentFunctionalityId});
         if ( (pr_default.getStatus(2) == 101) )
         {
            if ( ! ( (0==A2SecParentFunctionalityId) ) )
            {
               GX_msglist.addItem("不匹配'Sec Functionality Functionality'", "ForeignKeyNotFound", 1, "SECPARENTFUNCTIONALITYID");
               AnyError = 1;
               GX_FocusControl = edtSecParentFunctionalityId_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
         }
         A11SecParentFunctionalityDescription = T00014_A11SecParentFunctionalityDescription[0];
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A11SecParentFunctionalityDescription", A11SecParentFunctionalityDescription);
         pr_default.close(2);
      }

      protected void CloseExtendedTableCursors011( )
      {
         pr_default.close(2);
      }

      protected void enableDisable( )
      {
      }

      protected void gxLoad_11( long A2SecParentFunctionalityId )
      {
         /* Using cursor T00017 */
         pr_default.execute(5, new Object[] {n2SecParentFunctionalityId, A2SecParentFunctionalityId});
         if ( (pr_default.getStatus(5) == 101) )
         {
            if ( ! ( (0==A2SecParentFunctionalityId) ) )
            {
               GX_msglist.addItem("不匹配'Sec Functionality Functionality'", "ForeignKeyNotFound", 1, "SECPARENTFUNCTIONALITYID");
               AnyError = 1;
               GX_FocusControl = edtSecParentFunctionalityId_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
         }
         A11SecParentFunctionalityDescription = T00017_A11SecParentFunctionalityDescription[0];
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A11SecParentFunctionalityDescription", A11SecParentFunctionalityDescription);
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("[[");
         context.GX_webresponse.AddString("\""+GXUtil.EncodeJSConstant( A11SecParentFunctionalityDescription)+"\"");
         context.GX_webresponse.AddString("]");
         if ( (pr_default.getStatus(5) == 101) )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString("]");
         pr_default.close(5);
      }

      protected void GetKey011( )
      {
         /* Using cursor T00018 */
         pr_default.execute(6, new Object[] {A1SecFunctionalityId});
         if ( (pr_default.getStatus(6) != 101) )
         {
            RcdFound1 = 1;
         }
         else
         {
            RcdFound1 = 0;
         }
         pr_default.close(6);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor T00013 */
         pr_default.execute(1, new Object[] {A1SecFunctionalityId});
         if ( (pr_default.getStatus(1) != 101) )
         {
            ZM011( 9) ;
            RcdFound1 = 1;
            A1SecFunctionalityId = T00013_A1SecFunctionalityId[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1SecFunctionalityId", StringUtil.LTrim( StringUtil.Str( (decimal)(A1SecFunctionalityId), 10, 0)));
            A3SecFunctionalityKey = T00013_A3SecFunctionalityKey[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A3SecFunctionalityKey", A3SecFunctionalityKey);
            A8SecFunctionalityDescription = T00013_A8SecFunctionalityDescription[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A8SecFunctionalityDescription", A8SecFunctionalityDescription);
            A9SecFunctionalityType = T00013_A9SecFunctionalityType[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A9SecFunctionalityType", StringUtil.LTrim( StringUtil.Str( (decimal)(A9SecFunctionalityType), 2, 0)));
            A7SecFunctionalityActive = T00013_A7SecFunctionalityActive[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A7SecFunctionalityActive", A7SecFunctionalityActive);
            A2SecParentFunctionalityId = T00013_A2SecParentFunctionalityId[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A2SecParentFunctionalityId", StringUtil.LTrim( StringUtil.Str( (decimal)(A2SecParentFunctionalityId), 10, 0)));
            n2SecParentFunctionalityId = T00013_n2SecParentFunctionalityId[0];
            Z1SecFunctionalityId = A1SecFunctionalityId;
            sMode1 = Gx_mode;
            Gx_mode = "DSP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
            Load011( ) ;
            if ( AnyError == 1 )
            {
               RcdFound1 = 0;
               InitializeNonKey011( ) ;
            }
            Gx_mode = sMode1;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         }
         else
         {
            RcdFound1 = 0;
            InitializeNonKey011( ) ;
            sMode1 = Gx_mode;
            Gx_mode = "DSP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
            standaloneModal( ) ;
            Gx_mode = sMode1;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         }
         pr_default.close(1);
      }

      protected void getEqualNoModal( )
      {
         GetKey011( ) ;
         if ( RcdFound1 == 0 )
         {
         }
         else
         {
         }
         getByPrimaryKey( ) ;
      }

      protected void move_next( )
      {
         RcdFound1 = 0;
         /* Using cursor T00019 */
         pr_default.execute(7, new Object[] {A1SecFunctionalityId});
         if ( (pr_default.getStatus(7) != 101) )
         {
            while ( (pr_default.getStatus(7) != 101) && ( ( T00019_A1SecFunctionalityId[0] < A1SecFunctionalityId ) ) )
            {
               pr_default.readNext(7);
            }
            if ( (pr_default.getStatus(7) != 101) && ( ( T00019_A1SecFunctionalityId[0] > A1SecFunctionalityId ) ) )
            {
               A1SecFunctionalityId = T00019_A1SecFunctionalityId[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1SecFunctionalityId", StringUtil.LTrim( StringUtil.Str( (decimal)(A1SecFunctionalityId), 10, 0)));
               RcdFound1 = 1;
            }
         }
         pr_default.close(7);
      }

      protected void move_previous( )
      {
         RcdFound1 = 0;
         /* Using cursor T000110 */
         pr_default.execute(8, new Object[] {A1SecFunctionalityId});
         if ( (pr_default.getStatus(8) != 101) )
         {
            while ( (pr_default.getStatus(8) != 101) && ( ( T000110_A1SecFunctionalityId[0] > A1SecFunctionalityId ) ) )
            {
               pr_default.readNext(8);
            }
            if ( (pr_default.getStatus(8) != 101) && ( ( T000110_A1SecFunctionalityId[0] < A1SecFunctionalityId ) ) )
            {
               A1SecFunctionalityId = T000110_A1SecFunctionalityId[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1SecFunctionalityId", StringUtil.LTrim( StringUtil.Str( (decimal)(A1SecFunctionalityId), 10, 0)));
               RcdFound1 = 1;
            }
         }
         pr_default.close(8);
      }

      protected void btn_enter( )
      {
         nKeyPressed = 1;
         GetKey011( ) ;
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            /* Insert record */
            GX_FocusControl = edtSecFunctionalityKey_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            Insert011( ) ;
            if ( AnyError == 1 )
            {
               GX_FocusControl = "";
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
         }
         else
         {
            if ( RcdFound1 == 1 )
            {
               if ( A1SecFunctionalityId != Z1SecFunctionalityId )
               {
                  A1SecFunctionalityId = Z1SecFunctionalityId;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1SecFunctionalityId", StringUtil.LTrim( StringUtil.Str( (decimal)(A1SecFunctionalityId), 10, 0)));
                  GX_msglist.addItem(context.GetMessage( "GXM_getbeforeupd", ""), "CandidateKeyNotFound", 1, "SECFUNCTIONALITYID");
                  AnyError = 1;
                  GX_FocusControl = edtSecFunctionalityId_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
               else if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
               {
                  delete( ) ;
                  AfterTrn( ) ;
                  GX_FocusControl = edtSecFunctionalityKey_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
               else
               {
                  /* Update record */
                  Update011( ) ;
                  GX_FocusControl = edtSecFunctionalityKey_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
            }
            else
            {
               if ( A1SecFunctionalityId != Z1SecFunctionalityId )
               {
                  /* Insert record */
                  GX_FocusControl = edtSecFunctionalityKey_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  Insert011( ) ;
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
                     GX_msglist.addItem(context.GetMessage( "GXM_recdeleted", ""), 1, "SECFUNCTIONALITYID");
                     AnyError = 1;
                     GX_FocusControl = edtSecFunctionalityId_Internalname;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  }
                  else
                  {
                     /* Insert record */
                     GX_FocusControl = edtSecFunctionalityKey_Internalname;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                     Insert011( ) ;
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
         if ( A1SecFunctionalityId != Z1SecFunctionalityId )
         {
            A1SecFunctionalityId = Z1SecFunctionalityId;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1SecFunctionalityId", StringUtil.LTrim( StringUtil.Str( (decimal)(A1SecFunctionalityId), 10, 0)));
            GX_msglist.addItem(context.GetMessage( "GXM_getbeforedlt", ""), 1, "SECFUNCTIONALITYID");
            AnyError = 1;
            GX_FocusControl = edtSecFunctionalityId_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         else
         {
            delete( ) ;
            AfterTrn( ) ;
            GX_FocusControl = edtSecFunctionalityKey_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( AnyError != 0 )
         {
         }
      }

      protected void CheckOptimisticConcurrency011( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor T00012 */
            pr_default.execute(0, new Object[] {A1SecFunctionalityId});
            if ( (pr_default.getStatus(0) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"SecFunctionality"}), "RecordIsLocked", 1, "");
               AnyError = 1;
               return  ;
            }
            if ( (pr_default.getStatus(0) == 101) || ( StringUtil.StrCmp(Z3SecFunctionalityKey, T00012_A3SecFunctionalityKey[0]) != 0 ) || ( StringUtil.StrCmp(Z8SecFunctionalityDescription, T00012_A8SecFunctionalityDescription[0]) != 0 ) || ( Z9SecFunctionalityType != T00012_A9SecFunctionalityType[0] ) || ( Z7SecFunctionalityActive != T00012_A7SecFunctionalityActive[0] ) || ( Z2SecParentFunctionalityId != T00012_A2SecParentFunctionalityId[0] ) )
            {
               if ( StringUtil.StrCmp(Z3SecFunctionalityKey, T00012_A3SecFunctionalityKey[0]) != 0 )
               {
                  GXUtil.WriteLog("wwpbaseobjects.secfunctionality:[seudo value changed for attri]"+"SecFunctionalityKey");
                  GXUtil.WriteLogRaw("Old: ",Z3SecFunctionalityKey);
                  GXUtil.WriteLogRaw("Current: ",T00012_A3SecFunctionalityKey[0]);
               }
               if ( StringUtil.StrCmp(Z8SecFunctionalityDescription, T00012_A8SecFunctionalityDescription[0]) != 0 )
               {
                  GXUtil.WriteLog("wwpbaseobjects.secfunctionality:[seudo value changed for attri]"+"SecFunctionalityDescription");
                  GXUtil.WriteLogRaw("Old: ",Z8SecFunctionalityDescription);
                  GXUtil.WriteLogRaw("Current: ",T00012_A8SecFunctionalityDescription[0]);
               }
               if ( Z9SecFunctionalityType != T00012_A9SecFunctionalityType[0] )
               {
                  GXUtil.WriteLog("wwpbaseobjects.secfunctionality:[seudo value changed for attri]"+"SecFunctionalityType");
                  GXUtil.WriteLogRaw("Old: ",Z9SecFunctionalityType);
                  GXUtil.WriteLogRaw("Current: ",T00012_A9SecFunctionalityType[0]);
               }
               if ( Z7SecFunctionalityActive != T00012_A7SecFunctionalityActive[0] )
               {
                  GXUtil.WriteLog("wwpbaseobjects.secfunctionality:[seudo value changed for attri]"+"SecFunctionalityActive");
                  GXUtil.WriteLogRaw("Old: ",Z7SecFunctionalityActive);
                  GXUtil.WriteLogRaw("Current: ",T00012_A7SecFunctionalityActive[0]);
               }
               if ( Z2SecParentFunctionalityId != T00012_A2SecParentFunctionalityId[0] )
               {
                  GXUtil.WriteLog("wwpbaseobjects.secfunctionality:[seudo value changed for attri]"+"SecParentFunctionalityId");
                  GXUtil.WriteLogRaw("Old: ",Z2SecParentFunctionalityId);
                  GXUtil.WriteLogRaw("Current: ",T00012_A2SecParentFunctionalityId[0]);
               }
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"SecFunctionality"}), "RecordWasChanged", 1, "");
               AnyError = 1;
               return  ;
            }
         }
      }

      protected void Insert011( )
      {
         BeforeValidate011( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable011( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM011( 0) ;
            CheckOptimisticConcurrency011( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm011( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert011( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000111 */
                     pr_default.execute(9, new Object[] {A3SecFunctionalityKey, A8SecFunctionalityDescription, A9SecFunctionalityType, A7SecFunctionalityActive, n2SecParentFunctionalityId, A2SecParentFunctionalityId});
                     A1SecFunctionalityId = T000111_A1SecFunctionalityId[0];
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1SecFunctionalityId", StringUtil.LTrim( StringUtil.Str( (decimal)(A1SecFunctionalityId), 10, 0)));
                     pr_default.close(9);
                     dsDefault.SmartCacheProvider.SetUpdated("SecFunctionality") ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( Insert) rules */
                        /* End of After( Insert) rules */
                        if ( AnyError == 0 )
                        {
                           /* Save values for previous() function. */
                           GX_msglist.addItem(context.GetMessage( "GXM_sucadded", ""), "SuccessfullyAdded", 0, "", true);
                           ResetCaption010( ) ;
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
               Load011( ) ;
            }
            EndLevel011( ) ;
         }
         CloseExtendedTableCursors011( ) ;
      }

      protected void Update011( )
      {
         BeforeValidate011( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable011( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency011( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm011( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate011( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000112 */
                     pr_default.execute(10, new Object[] {A3SecFunctionalityKey, A8SecFunctionalityDescription, A9SecFunctionalityType, A7SecFunctionalityActive, n2SecParentFunctionalityId, A2SecParentFunctionalityId, A1SecFunctionalityId});
                     pr_default.close(10);
                     dsDefault.SmartCacheProvider.SetUpdated("SecFunctionality") ;
                     if ( (pr_default.getStatus(10) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"SecFunctionality"}), "RecordIsLocked", 1, "");
                        AnyError = 1;
                     }
                     DeferredUpdate011( ) ;
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
            EndLevel011( ) ;
         }
         CloseExtendedTableCursors011( ) ;
      }

      protected void DeferredUpdate011( )
      {
      }

      protected void delete( )
      {
         BeforeValidate011( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency011( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls011( ) ;
            AfterConfirm011( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete011( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor T000113 */
                  pr_default.execute(11, new Object[] {A1SecFunctionalityId});
                  pr_default.close(11);
                  dsDefault.SmartCacheProvider.SetUpdated("SecFunctionality") ;
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
         sMode1 = Gx_mode;
         Gx_mode = "DLT";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         EndLevel011( ) ;
         Gx_mode = sMode1;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
      }

      protected void OnDeleteControls011( )
      {
         standaloneModal( ) ;
         if ( AnyError == 0 )
         {
            /* Delete mode formulas */
            /* Using cursor T000114 */
            pr_default.execute(12, new Object[] {n2SecParentFunctionalityId, A2SecParentFunctionalityId});
            A11SecParentFunctionalityDescription = T000114_A11SecParentFunctionalityDescription[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A11SecParentFunctionalityDescription", A11SecParentFunctionalityDescription);
            pr_default.close(12);
         }
         if ( AnyError == 0 )
         {
            /* Using cursor T000115 */
            pr_default.execute(13, new Object[] {A1SecFunctionalityId});
            if ( (pr_default.getStatus(13) != 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_del", new   object[]  {"Functionality"}), "CannotDeleteReferencedRecord", 1, "");
               AnyError = 1;
            }
            pr_default.close(13);
            /* Using cursor T000116 */
            pr_default.execute(14, new Object[] {A1SecFunctionalityId});
            if ( (pr_default.getStatus(14) != 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_del", new   object[]  {"Functionalities"}), "CannotDeleteReferencedRecord", 1, "");
               AnyError = 1;
            }
            pr_default.close(14);
            /* Using cursor T000117 */
            pr_default.execute(15, new Object[] {A1SecFunctionalityId});
            if ( (pr_default.getStatus(15) != 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_del", new   object[]  {"Functionality Role"}), "CannotDeleteReferencedRecord", 1, "");
               AnyError = 1;
            }
            pr_default.close(15);
         }
      }

      protected void EndLevel011( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            pr_default.close(0);
         }
         if ( AnyError == 0 )
         {
            BeforeComplete011( ) ;
         }
         if ( AnyError == 0 )
         {
            pr_default.close(1);
            pr_default.close(12);
            context.CommitDataStores("wwpbaseobjects.secfunctionality",pr_default);
            if ( AnyError == 0 )
            {
               ConfirmValues010( ) ;
            }
            /* After transaction rules */
            /* Execute 'After Trn' event if defined. */
            trnEnded = 1;
         }
         else
         {
            pr_default.close(1);
            pr_default.close(12);
            context.RollbackDataStores("wwpbaseobjects.secfunctionality",pr_default);
         }
         IsModified = 0;
         if ( AnyError != 0 )
         {
            context.wjLoc = "";
            context.nUserReturn = 0;
         }
      }

      public void ScanStart011( )
      {
         /* Scan By routine */
         /* Using cursor T000118 */
         pr_default.execute(16);
         RcdFound1 = 0;
         if ( (pr_default.getStatus(16) != 101) )
         {
            RcdFound1 = 1;
            A1SecFunctionalityId = T000118_A1SecFunctionalityId[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1SecFunctionalityId", StringUtil.LTrim( StringUtil.Str( (decimal)(A1SecFunctionalityId), 10, 0)));
         }
         /* Load Subordinate Levels */
      }

      protected void ScanNext011( )
      {
         /* Scan next routine */
         pr_default.readNext(16);
         RcdFound1 = 0;
         if ( (pr_default.getStatus(16) != 101) )
         {
            RcdFound1 = 1;
            A1SecFunctionalityId = T000118_A1SecFunctionalityId[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1SecFunctionalityId", StringUtil.LTrim( StringUtil.Str( (decimal)(A1SecFunctionalityId), 10, 0)));
         }
      }

      protected void ScanEnd011( )
      {
         pr_default.close(16);
      }

      protected void AfterConfirm011( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert011( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate011( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete011( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete011( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate011( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes011( )
      {
         edtSecFunctionalityKey_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtSecFunctionalityKey_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtSecFunctionalityKey_Enabled), 5, 0)), true);
         edtSecFunctionalityDescription_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtSecFunctionalityDescription_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtSecFunctionalityDescription_Enabled), 5, 0)), true);
         edtSecFunctionalityId_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtSecFunctionalityId_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtSecFunctionalityId_Enabled), 5, 0)), true);
         cmbSecFunctionalityType.Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbSecFunctionalityType_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(cmbSecFunctionalityType.Enabled), 5, 0)), true);
         edtSecParentFunctionalityId_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtSecParentFunctionalityId_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtSecParentFunctionalityId_Enabled), 5, 0)), true);
         edtSecParentFunctionalityDescription_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtSecParentFunctionalityDescription_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtSecParentFunctionalityDescription_Enabled), 5, 0)), true);
         edtSecFunctionalityActive_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtSecFunctionalityActive_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtSecFunctionalityActive_Enabled), 5, 0)), true);
      }

      protected void send_integrity_lvl_hashes011( )
      {
      }

      protected void assign_properties_default( )
      {
      }

      protected void ConfirmValues010( )
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
         context.AddJavascriptSource("gxcfg.js", "?20202281562119", false);
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" autocomplete=\"off\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("wwpbaseobjects.secfunctionality.aspx") + "?" + UrlEncode(StringUtil.RTrim(Gx_mode)) + "," + UrlEncode("" +AV7SecFunctionalityId)+"\">") ;
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
         forbiddenHiddens = "hsh" + "SecFunctionality";
         forbiddenHiddens = forbiddenHiddens + context.localUtil.Format( (decimal)(A1SecFunctionalityId), "ZZZZZZZZZ9");
         forbiddenHiddens = forbiddenHiddens + context.localUtil.Format( (decimal)(AV12Insert_SecParentFunctionalityId), "ZZZZZZZZZ9");
         forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!"));
         forbiddenHiddens = forbiddenHiddens + context.localUtil.Format( (decimal)(A9SecFunctionalityType), "Z9");
         GxWebStd.gx_hidden_field( context, "hsh", GetEncryptedHash( forbiddenHiddens, GXKey));
         GXUtil.WriteLog("wwpbaseobjects.secfunctionality:[SendSecurityCheck value for]"+"SecFunctionalityId:"+context.localUtil.Format( (decimal)(A1SecFunctionalityId), "ZZZZZZZZZ9"));
         GXUtil.WriteLog("wwpbaseobjects.secfunctionality:[SendSecurityCheck value for]"+"Insert_SecParentFunctionalityId:"+context.localUtil.Format( (decimal)(AV12Insert_SecParentFunctionalityId), "ZZZZZZZZZ9"));
         GXUtil.WriteLog("wwpbaseobjects.secfunctionality:[SendSecurityCheck value for]"+"Gx_mode:"+StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")));
         GXUtil.WriteLog("wwpbaseobjects.secfunctionality:[SendSecurityCheck value for]"+"SecFunctionalityType:"+context.localUtil.Format( (decimal)(A9SecFunctionalityType), "Z9"));
      }

      protected void SendCloseFormHiddens( )
      {
         /* Send hidden variables. */
         /* Send saved values. */
         send_integrity_footer_hashes( ) ;
         GxWebStd.gx_hidden_field( context, "Z1SecFunctionalityId", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z1SecFunctionalityId), 10, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "Z3SecFunctionalityKey", Z3SecFunctionalityKey);
         GxWebStd.gx_hidden_field( context, "Z8SecFunctionalityDescription", Z8SecFunctionalityDescription);
         GxWebStd.gx_hidden_field( context, "Z9SecFunctionalityType", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z9SecFunctionalityType), 2, 0, ".", "")));
         GxWebStd.gx_boolean_hidden_field( context, "Z7SecFunctionalityActive", Z7SecFunctionalityActive);
         GxWebStd.gx_hidden_field( context, "Z2SecParentFunctionalityId", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z2SecParentFunctionalityId), 10, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "IsConfirmed", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsConfirmed), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "IsModified", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsModified), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "Mode", StringUtil.RTrim( Gx_mode));
         GxWebStd.gx_hidden_field( context, "gxhash_Mode", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         GxWebStd.gx_hidden_field( context, "N2SecParentFunctionalityId", StringUtil.LTrim( StringUtil.NToC( (decimal)(A2SecParentFunctionalityId), 10, 0, ".", "")));
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vTRNCONTEXT", AV10TrnContext);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vTRNCONTEXT", AV10TrnContext);
         }
         GxWebStd.gx_hidden_field( context, "vSECFUNCTIONALITYID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV7SecFunctionalityId), 10, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "gxhash_vSECFUNCTIONALITYID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV7SecFunctionalityId), "ZZZZZZZZZ9"), context));
         GxWebStd.gx_hidden_field( context, "vINSERT_SECPARENTFUNCTIONALITYID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV12Insert_SecParentFunctionalityId), 10, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "vPGMNAME", StringUtil.RTrim( AV19Pgmname));
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
         return formatLink("wwpbaseobjects.secfunctionality.aspx") + "?" + UrlEncode(StringUtil.RTrim(Gx_mode)) + "," + UrlEncode("" +AV7SecFunctionalityId) ;
      }

      public override String GetPgmname( )
      {
         return "WWPBaseObjects.SecFunctionality" ;
      }

      public override String GetPgmdesc( )
      {
         return "权限" ;
      }

      protected void InitializeNonKey011( )
      {
         A2SecParentFunctionalityId = 0;
         n2SecParentFunctionalityId = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A2SecParentFunctionalityId", StringUtil.LTrim( StringUtil.Str( (decimal)(A2SecParentFunctionalityId), 10, 0)));
         n2SecParentFunctionalityId = ((0==A2SecParentFunctionalityId) ? true : false);
         A3SecFunctionalityKey = "";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A3SecFunctionalityKey", A3SecFunctionalityKey);
         A8SecFunctionalityDescription = "";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A8SecFunctionalityDescription", A8SecFunctionalityDescription);
         A9SecFunctionalityType = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A9SecFunctionalityType", StringUtil.LTrim( StringUtil.Str( (decimal)(A9SecFunctionalityType), 2, 0)));
         A11SecParentFunctionalityDescription = "";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A11SecParentFunctionalityDescription", A11SecParentFunctionalityDescription);
         A7SecFunctionalityActive = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A7SecFunctionalityActive", A7SecFunctionalityActive);
         Z3SecFunctionalityKey = "";
         Z8SecFunctionalityDescription = "";
         Z9SecFunctionalityType = 0;
         Z7SecFunctionalityActive = false;
         Z2SecParentFunctionalityId = 0;
      }

      protected void InitAll011( )
      {
         A1SecFunctionalityId = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A1SecFunctionalityId", StringUtil.LTrim( StringUtil.Str( (decimal)(A1SecFunctionalityId), 10, 0)));
         InitializeNonKey011( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?20202281562151", true);
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
         context.AddJavascriptSource("wwpbaseobjects/secfunctionality.js", "?20202281562152", false);
         context.AddJavascriptSource("DVelop/Bootstrap/Shared/DVelopBootstrap.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/Panel/BootstrapPanelRender.js", "", false);
         /* End function include_jscripts */
      }

      protected void init_default_properties( )
      {
         edtSecFunctionalityKey_Internalname = "SECFUNCTIONALITYKEY";
         edtSecFunctionalityDescription_Internalname = "SECFUNCTIONALITYDESCRIPTION";
         divTableattributes_Internalname = "TABLEATTRIBUTES";
         divLayout_tableattributes_Internalname = "LAYOUT_TABLEATTRIBUTES";
         Dvpanel_tableattributes_Internalname = "DVPANEL_TABLEATTRIBUTES";
         divHtml_dvpanel_tableattributes_Internalname = "HTML_DVPANEL_TABLEATTRIBUTES";
         divTablecontent_Internalname = "TABLECONTENT";
         bttBtntrn_enter_Internalname = "BTNTRN_ENTER";
         bttBtntrn_cancel_Internalname = "BTNTRN_CANCEL";
         bttBtntrn_delete_Internalname = "BTNTRN_DELETE";
         divTablemain_Internalname = "TABLEMAIN";
         edtSecFunctionalityId_Internalname = "SECFUNCTIONALITYID";
         cmbSecFunctionalityType_Internalname = "SECFUNCTIONALITYTYPE";
         edtSecParentFunctionalityId_Internalname = "SECPARENTFUNCTIONALITYID";
         edtSecParentFunctionalityDescription_Internalname = "SECPARENTFUNCTIONALITYDESCRIPTION";
         edtSecFunctionalityActive_Internalname = "SECFUNCTIONALITYACTIVE";
         divHtml_bottomauxiliarcontrols_Internalname = "HTML_BOTTOMAUXILIARCONTROLS";
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
         Form.Caption = "权限";
         edtSecFunctionalityActive_Jsonclick = "";
         edtSecFunctionalityActive_Enabled = 1;
         edtSecFunctionalityActive_Visible = 1;
         edtSecParentFunctionalityDescription_Jsonclick = "";
         edtSecParentFunctionalityDescription_Enabled = 0;
         edtSecParentFunctionalityDescription_Visible = 1;
         edtSecParentFunctionalityId_Jsonclick = "";
         edtSecParentFunctionalityId_Enabled = 1;
         edtSecParentFunctionalityId_Visible = 1;
         cmbSecFunctionalityType_Jsonclick = "";
         cmbSecFunctionalityType.Enabled = 0;
         cmbSecFunctionalityType.Visible = 1;
         edtSecFunctionalityId_Jsonclick = "";
         edtSecFunctionalityId_Enabled = 0;
         edtSecFunctionalityId_Visible = 1;
         bttBtntrn_delete_Enabled = 0;
         bttBtntrn_delete_Visible = 1;
         bttBtntrn_cancel_Visible = 1;
         bttBtntrn_enter_Enabled = 1;
         bttBtntrn_enter_Visible = 1;
         edtSecFunctionalityDescription_Jsonclick = "";
         edtSecFunctionalityDescription_Enabled = 1;
         edtSecFunctionalityKey_Jsonclick = "";
         edtSecFunctionalityKey_Enabled = 1;
         Dvpanel_tableattributes_Autoscroll = Convert.ToBoolean( 0);
         Dvpanel_tableattributes_Iconposition = "left";
         Dvpanel_tableattributes_Showcollapseicon = Convert.ToBoolean( 0);
         Dvpanel_tableattributes_Collapsed = Convert.ToBoolean( 0);
         Dvpanel_tableattributes_Collapsible = Convert.ToBoolean( 0);
         Dvpanel_tableattributes_Title = "权限";
         Dvpanel_tableattributes_Cls = "PanelCard_BaseColor";
         Dvpanel_tableattributes_Autoheight = Convert.ToBoolean( -1);
         Dvpanel_tableattributes_Autowidth = Convert.ToBoolean( 0);
         Dvpanel_tableattributes_Width = "100%";
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
         cmbSecFunctionalityType.Name = "SECFUNCTIONALITYTYPE";
         cmbSecFunctionalityType.WebTags = "";
         cmbSecFunctionalityType.addItem("1", "Mode", 0);
         cmbSecFunctionalityType.addItem("2", "Action", 0);
         cmbSecFunctionalityType.addItem("3", "Tab", 0);
         cmbSecFunctionalityType.addItem("4", "Object", 0);
         cmbSecFunctionalityType.addItem("5", "Attribute", 0);
         if ( cmbSecFunctionalityType.ItemCount > 0 )
         {
            A9SecFunctionalityType = (short)(NumberUtil.Val( cmbSecFunctionalityType.getValidValue(StringUtil.Trim( StringUtil.Str( (decimal)(A9SecFunctionalityType), 2, 0))), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A9SecFunctionalityType", StringUtil.LTrim( StringUtil.Str( (decimal)(A9SecFunctionalityType), 2, 0)));
         }
         /* End function init_web_controls */
      }

      public void Valid_Secfunctionalitykey( String GX_Parm1 ,
                                             long GX_Parm2 )
      {
         A3SecFunctionalityKey = GX_Parm1;
         A1SecFunctionalityId = GX_Parm2;
         /* Using cursor T000119 */
         pr_default.execute(17, new Object[] {A3SecFunctionalityKey, A1SecFunctionalityId});
         if ( (pr_default.getStatus(17) != 101) )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_1004", new   object[]  {"权限名称"}), 1, "SECFUNCTIONALITYKEY");
            AnyError = 1;
            GX_FocusControl = edtSecFunctionalityKey_Internalname;
         }
         pr_default.close(17);
         dynload_actions( ) ;
         isValidOutput.Add(context.GX_msglist.ToJavascriptSource());
         isValidOutput.Add(context.httpAjaxContext.ajax_rsp_get_hiddens( ));
         context.GX_webresponse.AddString(isValidOutput.ToJSonString());
         wbTemp = context.ResponseContentType( "application/json");
      }

      public void Valid_Secparentfunctionalityid( long GX_Parm1 ,
                                                  String GX_Parm2 )
      {
         A2SecParentFunctionalityId = GX_Parm1;
         n2SecParentFunctionalityId = false;
         A11SecParentFunctionalityDescription = GX_Parm2;
         /* Using cursor T000114 */
         pr_default.execute(12, new Object[] {n2SecParentFunctionalityId, A2SecParentFunctionalityId});
         if ( (pr_default.getStatus(12) == 101) )
         {
            if ( ! ( (0==A2SecParentFunctionalityId) ) )
            {
               GX_msglist.addItem("不匹配'Sec Functionality Functionality'", "ForeignKeyNotFound", 1, "SECPARENTFUNCTIONALITYID");
               AnyError = 1;
               GX_FocusControl = edtSecParentFunctionalityId_Internalname;
            }
         }
         A11SecParentFunctionalityDescription = T000114_A11SecParentFunctionalityDescription[0];
         pr_default.close(12);
         dynload_actions( ) ;
         if ( AnyError == 1 )
         {
            A11SecParentFunctionalityDescription = "";
         }
         isValidOutput.Add(A11SecParentFunctionalityDescription);
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
         setEventMetadata("ENTER","{handler:'UserMainFullajax',iparms:[{postForm:true},{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV7SecFunctionalityId',fld:'vSECFUNCTIONALITYID',pic:'ZZZZZZZZZ9',hsh:true}]");
         setEventMetadata("ENTER",",oparms:[]}");
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV7SecFunctionalityId',fld:'vSECFUNCTIONALITYID',pic:'ZZZZZZZZZ9',hsh:true},{av:'A1SecFunctionalityId',fld:'SECFUNCTIONALITYID',pic:'ZZZZZZZZZ9'},{av:'AV12Insert_SecParentFunctionalityId',fld:'vINSERT_SECPARENTFUNCTIONALITYID',pic:'ZZZZZZZZZ9'},{av:'cmbSecFunctionalityType'},{av:'A9SecFunctionalityType',fld:'SECFUNCTIONALITYTYPE',pic:'Z9'}]");
         setEventMetadata("REFRESH",",oparms:[]}");
         setEventMetadata("AFTER TRN","{handler:'E12012',iparms:[{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV10TrnContext',fld:'vTRNCONTEXT',pic:''}]");
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
         pr_default.close(1);
         pr_default.close(12);
      }

      public override void initialize( )
      {
         sPrefix = "";
         wcpOGx_mode = "";
         Z3SecFunctionalityKey = "";
         Z8SecFunctionalityDescription = "";
         scmdbuf = "";
         gxfirstwebparm = "";
         gxfirstwebparm_bkp = "";
         GXKey = "";
         PreviousTooltip = "";
         PreviousCaption = "";
         Form = new GXWebForm();
         GX_FocusControl = "";
         ucDvpanel_tableattributes = new GXUserControl();
         TempTags = "";
         A3SecFunctionalityKey = "";
         A8SecFunctionalityDescription = "";
         ClassString = "";
         StyleString = "";
         bttBtntrn_enter_Jsonclick = "";
         bttBtntrn_cancel_Jsonclick = "";
         bttBtntrn_delete_Jsonclick = "";
         A11SecParentFunctionalityDescription = "";
         AV19Pgmname = "";
         Dvpanel_tableattributes_Objectcall = "";
         Dvpanel_tableattributes_Class = "";
         Dvpanel_tableattributes_Height = "";
         forbiddenHiddens = "";
         hsh = "";
         sMode1 = "";
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         AV18WWPContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPContext(context);
         AV10TrnContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext(context);
         AV11WebSession = context.GetSession();
         AV13TrnContextAtt = new GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext_Attribute(context);
         Z11SecParentFunctionalityDescription = "";
         T00014_A11SecParentFunctionalityDescription = new String[] {""} ;
         T00015_A1SecFunctionalityId = new long[1] ;
         T00015_A3SecFunctionalityKey = new String[] {""} ;
         T00015_A8SecFunctionalityDescription = new String[] {""} ;
         T00015_A9SecFunctionalityType = new short[1] ;
         T00015_A11SecParentFunctionalityDescription = new String[] {""} ;
         T00015_A7SecFunctionalityActive = new bool[] {false} ;
         T00015_A2SecParentFunctionalityId = new long[1] ;
         T00015_n2SecParentFunctionalityId = new bool[] {false} ;
         T00016_A3SecFunctionalityKey = new String[] {""} ;
         T00017_A11SecParentFunctionalityDescription = new String[] {""} ;
         T00018_A1SecFunctionalityId = new long[1] ;
         T00013_A1SecFunctionalityId = new long[1] ;
         T00013_A3SecFunctionalityKey = new String[] {""} ;
         T00013_A8SecFunctionalityDescription = new String[] {""} ;
         T00013_A9SecFunctionalityType = new short[1] ;
         T00013_A7SecFunctionalityActive = new bool[] {false} ;
         T00013_A2SecParentFunctionalityId = new long[1] ;
         T00013_n2SecParentFunctionalityId = new bool[] {false} ;
         T00019_A1SecFunctionalityId = new long[1] ;
         T000110_A1SecFunctionalityId = new long[1] ;
         T00012_A1SecFunctionalityId = new long[1] ;
         T00012_A3SecFunctionalityKey = new String[] {""} ;
         T00012_A8SecFunctionalityDescription = new String[] {""} ;
         T00012_A9SecFunctionalityType = new short[1] ;
         T00012_A7SecFunctionalityActive = new bool[] {false} ;
         T00012_A2SecParentFunctionalityId = new long[1] ;
         T00012_n2SecParentFunctionalityId = new bool[] {false} ;
         T000111_A1SecFunctionalityId = new long[1] ;
         T000114_A11SecParentFunctionalityDescription = new String[] {""} ;
         T000115_A2SecParentFunctionalityId = new long[1] ;
         T000115_n2SecParentFunctionalityId = new bool[] {false} ;
         T000116_A5SecObjectName = new String[] {""} ;
         T000116_A1SecFunctionalityId = new long[1] ;
         T000117_A1SecFunctionalityId = new long[1] ;
         T000117_A4SecRoleId = new short[1] ;
         T000118_A1SecFunctionalityId = new long[1] ;
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         T000119_A3SecFunctionalityKey = new String[] {""} ;
         isValidOutput = new GxUnknownObjectCollection();
         pr_datastore1 = new DataStoreProvider(context, new GeneXus.Programs.wwpbaseobjects.secfunctionality__datastore1(),
            new Object[][] {
            }
         );
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.wwpbaseobjects.secfunctionality__default(),
            new Object[][] {
                new Object[] {
               T00012_A1SecFunctionalityId, T00012_A3SecFunctionalityKey, T00012_A8SecFunctionalityDescription, T00012_A9SecFunctionalityType, T00012_A7SecFunctionalityActive, T00012_A2SecParentFunctionalityId, T00012_n2SecParentFunctionalityId
               }
               , new Object[] {
               T00013_A1SecFunctionalityId, T00013_A3SecFunctionalityKey, T00013_A8SecFunctionalityDescription, T00013_A9SecFunctionalityType, T00013_A7SecFunctionalityActive, T00013_A2SecParentFunctionalityId, T00013_n2SecParentFunctionalityId
               }
               , new Object[] {
               T00014_A11SecParentFunctionalityDescription
               }
               , new Object[] {
               T00015_A1SecFunctionalityId, T00015_A3SecFunctionalityKey, T00015_A8SecFunctionalityDescription, T00015_A9SecFunctionalityType, T00015_A11SecParentFunctionalityDescription, T00015_A7SecFunctionalityActive, T00015_A2SecParentFunctionalityId, T00015_n2SecParentFunctionalityId
               }
               , new Object[] {
               T00016_A3SecFunctionalityKey
               }
               , new Object[] {
               T00017_A11SecParentFunctionalityDescription
               }
               , new Object[] {
               T00018_A1SecFunctionalityId
               }
               , new Object[] {
               T00019_A1SecFunctionalityId
               }
               , new Object[] {
               T000110_A1SecFunctionalityId
               }
               , new Object[] {
               T000111_A1SecFunctionalityId
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               T000114_A11SecParentFunctionalityDescription
               }
               , new Object[] {
               T000115_A2SecParentFunctionalityId
               }
               , new Object[] {
               T000116_A5SecObjectName, T000116_A1SecFunctionalityId
               }
               , new Object[] {
               T000117_A1SecFunctionalityId, T000117_A4SecRoleId
               }
               , new Object[] {
               T000118_A1SecFunctionalityId
               }
               , new Object[] {
               T000119_A3SecFunctionalityKey
               }
            }
         );
         AV19Pgmname = "WWPBaseObjects.SecFunctionality";
      }

      private short Z9SecFunctionalityType ;
      private short GxWebError ;
      private short gxcookieaux ;
      private short IsConfirmed ;
      private short IsModified ;
      private short AnyError ;
      private short nKeyPressed ;
      private short initialized ;
      private short A9SecFunctionalityType ;
      private short RcdFound1 ;
      private short GX_JID ;
      private short Gx_BScreen ;
      private short gxajaxcallmode ;
      private short wbTemp ;
      private int trnEnded ;
      private int edtSecFunctionalityKey_Enabled ;
      private int edtSecFunctionalityDescription_Enabled ;
      private int bttBtntrn_enter_Visible ;
      private int bttBtntrn_enter_Enabled ;
      private int bttBtntrn_cancel_Visible ;
      private int bttBtntrn_delete_Visible ;
      private int bttBtntrn_delete_Enabled ;
      private int edtSecFunctionalityId_Enabled ;
      private int edtSecFunctionalityId_Visible ;
      private int edtSecParentFunctionalityId_Visible ;
      private int edtSecParentFunctionalityId_Enabled ;
      private int edtSecParentFunctionalityDescription_Visible ;
      private int edtSecParentFunctionalityDescription_Enabled ;
      private int edtSecFunctionalityActive_Visible ;
      private int edtSecFunctionalityActive_Enabled ;
      private int AV20GXV1 ;
      private int idxLst ;
      private long wcpOAV7SecFunctionalityId ;
      private long Z1SecFunctionalityId ;
      private long Z2SecParentFunctionalityId ;
      private long N2SecParentFunctionalityId ;
      private long A2SecParentFunctionalityId ;
      private long AV7SecFunctionalityId ;
      private long A1SecFunctionalityId ;
      private long AV12Insert_SecParentFunctionalityId ;
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
      private String edtSecFunctionalityKey_Internalname ;
      private String cmbSecFunctionalityType_Internalname ;
      private String divLayoutmaintable_Internalname ;
      private String divTablemain_Internalname ;
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
      private String edtSecFunctionalityKey_Jsonclick ;
      private String edtSecFunctionalityDescription_Internalname ;
      private String edtSecFunctionalityDescription_Jsonclick ;
      private String ClassString ;
      private String StyleString ;
      private String bttBtntrn_enter_Internalname ;
      private String bttBtntrn_enter_Jsonclick ;
      private String bttBtntrn_cancel_Internalname ;
      private String bttBtntrn_cancel_Jsonclick ;
      private String bttBtntrn_delete_Internalname ;
      private String bttBtntrn_delete_Jsonclick ;
      private String divHtml_bottomauxiliarcontrols_Internalname ;
      private String edtSecFunctionalityId_Internalname ;
      private String edtSecFunctionalityId_Jsonclick ;
      private String cmbSecFunctionalityType_Jsonclick ;
      private String edtSecParentFunctionalityId_Internalname ;
      private String edtSecParentFunctionalityId_Jsonclick ;
      private String edtSecParentFunctionalityDescription_Internalname ;
      private String edtSecParentFunctionalityDescription_Jsonclick ;
      private String edtSecFunctionalityActive_Internalname ;
      private String edtSecFunctionalityActive_Jsonclick ;
      private String AV19Pgmname ;
      private String Dvpanel_tableattributes_Objectcall ;
      private String Dvpanel_tableattributes_Class ;
      private String Dvpanel_tableattributes_Height ;
      private String forbiddenHiddens ;
      private String hsh ;
      private String sMode1 ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String sDynURL ;
      private String FormProcess ;
      private String bodyStyle ;
      private bool Z7SecFunctionalityActive ;
      private bool entryPointCalled ;
      private bool n2SecParentFunctionalityId ;
      private bool toggleJsOutput ;
      private bool wbErr ;
      private bool Dvpanel_tableattributes_Autowidth ;
      private bool Dvpanel_tableattributes_Autoheight ;
      private bool Dvpanel_tableattributes_Collapsible ;
      private bool Dvpanel_tableattributes_Collapsed ;
      private bool Dvpanel_tableattributes_Showcollapseicon ;
      private bool Dvpanel_tableattributes_Autoscroll ;
      private bool A7SecFunctionalityActive ;
      private bool Dvpanel_tableattributes_Enabled ;
      private bool Dvpanel_tableattributes_Showheader ;
      private bool Dvpanel_tableattributes_Visible ;
      private bool returnInSub ;
      private String Z3SecFunctionalityKey ;
      private String Z8SecFunctionalityDescription ;
      private String A3SecFunctionalityKey ;
      private String A8SecFunctionalityDescription ;
      private String A11SecParentFunctionalityDescription ;
      private String Z11SecParentFunctionalityDescription ;
      private IGxSession AV11WebSession ;
      private GxUnknownObjectCollection isValidOutput ;
      private GXUserControl ucDvpanel_tableattributes ;
      private IGxDataStore dsDataStore1 ;
      private IGxDataStore dsDefault ;
      private GXCombobox cmbSecFunctionalityType ;
      private IDataStoreProvider pr_default ;
      private String[] T00014_A11SecParentFunctionalityDescription ;
      private long[] T00015_A1SecFunctionalityId ;
      private String[] T00015_A3SecFunctionalityKey ;
      private String[] T00015_A8SecFunctionalityDescription ;
      private short[] T00015_A9SecFunctionalityType ;
      private String[] T00015_A11SecParentFunctionalityDescription ;
      private bool[] T00015_A7SecFunctionalityActive ;
      private long[] T00015_A2SecParentFunctionalityId ;
      private bool[] T00015_n2SecParentFunctionalityId ;
      private String[] T00016_A3SecFunctionalityKey ;
      private String[] T00017_A11SecParentFunctionalityDescription ;
      private long[] T00018_A1SecFunctionalityId ;
      private long[] T00013_A1SecFunctionalityId ;
      private String[] T00013_A3SecFunctionalityKey ;
      private String[] T00013_A8SecFunctionalityDescription ;
      private short[] T00013_A9SecFunctionalityType ;
      private bool[] T00013_A7SecFunctionalityActive ;
      private long[] T00013_A2SecParentFunctionalityId ;
      private bool[] T00013_n2SecParentFunctionalityId ;
      private long[] T00019_A1SecFunctionalityId ;
      private long[] T000110_A1SecFunctionalityId ;
      private long[] T00012_A1SecFunctionalityId ;
      private String[] T00012_A3SecFunctionalityKey ;
      private String[] T00012_A8SecFunctionalityDescription ;
      private short[] T00012_A9SecFunctionalityType ;
      private bool[] T00012_A7SecFunctionalityActive ;
      private long[] T00012_A2SecParentFunctionalityId ;
      private bool[] T00012_n2SecParentFunctionalityId ;
      private long[] T000111_A1SecFunctionalityId ;
      private String[] T000114_A11SecParentFunctionalityDescription ;
      private long[] T000115_A2SecParentFunctionalityId ;
      private bool[] T000115_n2SecParentFunctionalityId ;
      private String[] T000116_A5SecObjectName ;
      private long[] T000116_A1SecFunctionalityId ;
      private long[] T000117_A1SecFunctionalityId ;
      private short[] T000117_A4SecRoleId ;
      private long[] T000118_A1SecFunctionalityId ;
      private String[] T000119_A3SecFunctionalityKey ;
      private IDataStoreProvider pr_datastore1 ;
      private GXWebForm Form ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPContext AV18WWPContext ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext AV10TrnContext ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext_Attribute AV13TrnContextAtt ;
   }

   public class secfunctionality__datastore1 : DataStoreHelperBase, IDataStoreHelper
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

 public class secfunctionality__default : DataStoreHelperBase, IDataStoreHelper
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
        Object[] prmT00015 ;
        prmT00015 = new Object[] {
        new Object[] {"@SecFunctionalityId",SqlDbType.Decimal,10,0}
        } ;
        Object[] prmT00016 ;
        prmT00016 = new Object[] {
        new Object[] {"@SecFunctionalityKey",SqlDbType.NVarChar,100,0} ,
        new Object[] {"@SecFunctionalityId",SqlDbType.Decimal,10,0}
        } ;
        Object[] prmT00014 ;
        prmT00014 = new Object[] {
        new Object[] {"@SecParentFunctionalityId",SqlDbType.Decimal,10,0}
        } ;
        Object[] prmT00017 ;
        prmT00017 = new Object[] {
        new Object[] {"@SecParentFunctionalityId",SqlDbType.Decimal,10,0}
        } ;
        Object[] prmT00018 ;
        prmT00018 = new Object[] {
        new Object[] {"@SecFunctionalityId",SqlDbType.Decimal,10,0}
        } ;
        Object[] prmT00013 ;
        prmT00013 = new Object[] {
        new Object[] {"@SecFunctionalityId",SqlDbType.Decimal,10,0}
        } ;
        Object[] prmT00019 ;
        prmT00019 = new Object[] {
        new Object[] {"@SecFunctionalityId",SqlDbType.Decimal,10,0}
        } ;
        Object[] prmT000110 ;
        prmT000110 = new Object[] {
        new Object[] {"@SecFunctionalityId",SqlDbType.Decimal,10,0}
        } ;
        Object[] prmT00012 ;
        prmT00012 = new Object[] {
        new Object[] {"@SecFunctionalityId",SqlDbType.Decimal,10,0}
        } ;
        Object[] prmT000111 ;
        prmT000111 = new Object[] {
        new Object[] {"@SecFunctionalityKey",SqlDbType.NVarChar,100,0} ,
        new Object[] {"@SecFunctionalityDescription",SqlDbType.NVarChar,100,0} ,
        new Object[] {"@SecFunctionalityType",SqlDbType.SmallInt,2,0} ,
        new Object[] {"@SecFunctionalityActive",SqlDbType.Bit,4,0} ,
        new Object[] {"@SecParentFunctionalityId",SqlDbType.Decimal,10,0}
        } ;
        Object[] prmT000112 ;
        prmT000112 = new Object[] {
        new Object[] {"@SecFunctionalityKey",SqlDbType.NVarChar,100,0} ,
        new Object[] {"@SecFunctionalityDescription",SqlDbType.NVarChar,100,0} ,
        new Object[] {"@SecFunctionalityType",SqlDbType.SmallInt,2,0} ,
        new Object[] {"@SecFunctionalityActive",SqlDbType.Bit,4,0} ,
        new Object[] {"@SecParentFunctionalityId",SqlDbType.Decimal,10,0} ,
        new Object[] {"@SecFunctionalityId",SqlDbType.Decimal,10,0}
        } ;
        Object[] prmT000113 ;
        prmT000113 = new Object[] {
        new Object[] {"@SecFunctionalityId",SqlDbType.Decimal,10,0}
        } ;
        Object[] prmT000115 ;
        prmT000115 = new Object[] {
        new Object[] {"@SecFunctionalityId",SqlDbType.Decimal,10,0}
        } ;
        Object[] prmT000116 ;
        prmT000116 = new Object[] {
        new Object[] {"@SecFunctionalityId",SqlDbType.Decimal,10,0}
        } ;
        Object[] prmT000117 ;
        prmT000117 = new Object[] {
        new Object[] {"@SecFunctionalityId",SqlDbType.Decimal,10,0}
        } ;
        Object[] prmT000118 ;
        prmT000118 = new Object[] {
        } ;
        Object[] prmT000119 ;
        prmT000119 = new Object[] {
        new Object[] {"@SecFunctionalityKey",SqlDbType.NVarChar,100,0} ,
        new Object[] {"@SecFunctionalityId",SqlDbType.Decimal,10,0}
        } ;
        Object[] prmT000114 ;
        prmT000114 = new Object[] {
        new Object[] {"@SecParentFunctionalityId",SqlDbType.Decimal,10,0}
        } ;
        def= new CursorDef[] {
            new CursorDef("T00012", "SELECT [SecFunctionalityId], [SecFunctionalityKey], [SecFunctionalityDescription], [SecFunctionalityType], [SecFunctionalityActive], [SecParentFunctionalityId] AS SecParentFunctionalityId FROM [SecFunctionality] WITH (UPDLOCK) WHERE [SecFunctionalityId] = @SecFunctionalityId ",true, GxErrorMask.GX_NOMASK, false, this,prmT00012,1,0,true,false )
           ,new CursorDef("T00013", "SELECT [SecFunctionalityId], [SecFunctionalityKey], [SecFunctionalityDescription], [SecFunctionalityType], [SecFunctionalityActive], [SecParentFunctionalityId] AS SecParentFunctionalityId FROM [SecFunctionality] WITH (NOLOCK) WHERE [SecFunctionalityId] = @SecFunctionalityId ",true, GxErrorMask.GX_NOMASK, false, this,prmT00013,1,0,true,false )
           ,new CursorDef("T00014", "SELECT [SecFunctionalityDescription] AS SecParentFunctionalityDescription FROM [SecFunctionality] WITH (NOLOCK) WHERE [SecFunctionalityId] = @SecParentFunctionalityId ",true, GxErrorMask.GX_NOMASK, false, this,prmT00014,1,0,true,false )
           ,new CursorDef("T00015", "SELECT TM1.[SecFunctionalityId], TM1.[SecFunctionalityKey], TM1.[SecFunctionalityDescription], TM1.[SecFunctionalityType], T2.[SecFunctionalityDescription] AS SecParentFunctionalityDescription, TM1.[SecFunctionalityActive], TM1.[SecParentFunctionalityId] AS SecParentFunctionalityId FROM ([SecFunctionality] TM1 WITH (NOLOCK) LEFT JOIN [SecFunctionality] T2 WITH (NOLOCK) ON T2.[SecFunctionalityId] = TM1.[SecParentFunctionalityId]) WHERE TM1.[SecFunctionalityId] = @SecFunctionalityId ORDER BY TM1.[SecFunctionalityId]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT00015,100,0,true,false )
           ,new CursorDef("T00016", "SELECT [SecFunctionalityKey] FROM [SecFunctionality] WITH (NOLOCK) WHERE ([SecFunctionalityKey] = @SecFunctionalityKey) AND (Not ( [SecFunctionalityId] = @SecFunctionalityId)) ",true, GxErrorMask.GX_NOMASK, false, this,prmT00016,1,0,true,false )
           ,new CursorDef("T00017", "SELECT [SecFunctionalityDescription] AS SecParentFunctionalityDescription FROM [SecFunctionality] WITH (NOLOCK) WHERE [SecFunctionalityId] = @SecParentFunctionalityId ",true, GxErrorMask.GX_NOMASK, false, this,prmT00017,1,0,true,false )
           ,new CursorDef("T00018", "SELECT [SecFunctionalityId] FROM [SecFunctionality] WITH (NOLOCK) WHERE [SecFunctionalityId] = @SecFunctionalityId  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT00018,1,0,true,false )
           ,new CursorDef("T00019", "SELECT TOP 1 [SecFunctionalityId] FROM [SecFunctionality] WITH (NOLOCK) WHERE ( [SecFunctionalityId] > @SecFunctionalityId) ORDER BY [SecFunctionalityId]  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT00019,1,0,true,true )
           ,new CursorDef("T000110", "SELECT TOP 1 [SecFunctionalityId] FROM [SecFunctionality] WITH (NOLOCK) WHERE ( [SecFunctionalityId] < @SecFunctionalityId) ORDER BY [SecFunctionalityId] DESC  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000110,1,0,true,true )
           ,new CursorDef("T000111", "INSERT INTO [SecFunctionality]([SecFunctionalityKey], [SecFunctionalityDescription], [SecFunctionalityType], [SecFunctionalityActive], [SecParentFunctionalityId]) VALUES(@SecFunctionalityKey, @SecFunctionalityDescription, @SecFunctionalityType, @SecFunctionalityActive, @SecParentFunctionalityId); SELECT SCOPE_IDENTITY()", GxErrorMask.GX_NOMASK,prmT000111)
           ,new CursorDef("T000112", "UPDATE [SecFunctionality] SET [SecFunctionalityKey]=@SecFunctionalityKey, [SecFunctionalityDescription]=@SecFunctionalityDescription, [SecFunctionalityType]=@SecFunctionalityType, [SecFunctionalityActive]=@SecFunctionalityActive, [SecParentFunctionalityId]=@SecParentFunctionalityId  WHERE [SecFunctionalityId] = @SecFunctionalityId", GxErrorMask.GX_NOMASK,prmT000112)
           ,new CursorDef("T000113", "DELETE FROM [SecFunctionality]  WHERE [SecFunctionalityId] = @SecFunctionalityId", GxErrorMask.GX_NOMASK,prmT000113)
           ,new CursorDef("T000114", "SELECT [SecFunctionalityDescription] AS SecParentFunctionalityDescription FROM [SecFunctionality] WITH (NOLOCK) WHERE [SecFunctionalityId] = @SecParentFunctionalityId ",true, GxErrorMask.GX_NOMASK, false, this,prmT000114,1,0,true,false )
           ,new CursorDef("T000115", "SELECT TOP 1 [SecFunctionalityId] AS SecParentFunctionalityId FROM [SecFunctionality] WITH (NOLOCK) WHERE [SecParentFunctionalityId] = @SecFunctionalityId ",true, GxErrorMask.GX_NOMASK, false, this,prmT000115,1,0,true,true )
           ,new CursorDef("T000116", "SELECT TOP 1 [SecObjectName], [SecFunctionalityId] FROM [SecObjectFunctionalities] WITH (NOLOCK) WHERE [SecFunctionalityId] = @SecFunctionalityId ",true, GxErrorMask.GX_NOMASK, false, this,prmT000116,1,0,true,true )
           ,new CursorDef("T000117", "SELECT TOP 1 [SecFunctionalityId], [SecRoleId] FROM [SecFunctionalityRole] WITH (NOLOCK) WHERE [SecFunctionalityId] = @SecFunctionalityId ",true, GxErrorMask.GX_NOMASK, false, this,prmT000117,1,0,true,true )
           ,new CursorDef("T000118", "SELECT [SecFunctionalityId] FROM [SecFunctionality] WITH (NOLOCK) ORDER BY [SecFunctionalityId]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT000118,100,0,true,false )
           ,new CursorDef("T000119", "SELECT [SecFunctionalityKey] FROM [SecFunctionality] WITH (NOLOCK) WHERE ([SecFunctionalityKey] = @SecFunctionalityKey) AND (Not ( [SecFunctionalityId] = @SecFunctionalityId)) ",true, GxErrorMask.GX_NOMASK, false, this,prmT000119,1,0,true,false )
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
              ((String[]) buf[2])[0] = rslt.getVarchar(3) ;
              ((short[]) buf[3])[0] = rslt.getShort(4) ;
              ((bool[]) buf[4])[0] = rslt.getBool(5) ;
              ((long[]) buf[5])[0] = rslt.getLong(6) ;
              ((bool[]) buf[6])[0] = rslt.wasNull(6);
              return;
           case 1 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
              ((String[]) buf[2])[0] = rslt.getVarchar(3) ;
              ((short[]) buf[3])[0] = rslt.getShort(4) ;
              ((bool[]) buf[4])[0] = rslt.getBool(5) ;
              ((long[]) buf[5])[0] = rslt.getLong(6) ;
              ((bool[]) buf[6])[0] = rslt.wasNull(6);
              return;
           case 2 :
              ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
              return;
           case 3 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
              ((String[]) buf[2])[0] = rslt.getVarchar(3) ;
              ((short[]) buf[3])[0] = rslt.getShort(4) ;
              ((String[]) buf[4])[0] = rslt.getVarchar(5) ;
              ((bool[]) buf[5])[0] = rslt.getBool(6) ;
              ((long[]) buf[6])[0] = rslt.getLong(7) ;
              ((bool[]) buf[7])[0] = rslt.wasNull(7);
              return;
           case 4 :
              ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
              return;
           case 5 :
              ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
              return;
           case 6 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              return;
           case 7 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              return;
           case 8 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              return;
           case 9 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              return;
           case 12 :
              ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
              return;
           case 13 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              return;
           case 14 :
              ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
              ((long[]) buf[1])[0] = rslt.getLong(2) ;
              return;
           case 15 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              ((short[]) buf[1])[0] = rslt.getShort(2) ;
              return;
           case 16 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              return;
           case 17 :
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
              stmt.SetParameter(1, (long)parms[0]);
              return;
           case 1 :
              stmt.SetParameter(1, (long)parms[0]);
              return;
           case 2 :
              if ( (bool)parms[0] )
              {
                 stmt.setNull( 1 , SqlDbType.Decimal );
              }
              else
              {
                 stmt.SetParameter(1, (long)parms[1]);
              }
              return;
           case 3 :
              stmt.SetParameter(1, (long)parms[0]);
              return;
           case 4 :
              stmt.SetParameter(1, (String)parms[0]);
              stmt.SetParameter(2, (long)parms[1]);
              return;
           case 5 :
              if ( (bool)parms[0] )
              {
                 stmt.setNull( 1 , SqlDbType.Decimal );
              }
              else
              {
                 stmt.SetParameter(1, (long)parms[1]);
              }
              return;
           case 6 :
              stmt.SetParameter(1, (long)parms[0]);
              return;
           case 7 :
              stmt.SetParameter(1, (long)parms[0]);
              return;
           case 8 :
              stmt.SetParameter(1, (long)parms[0]);
              return;
           case 9 :
              stmt.SetParameter(1, (String)parms[0]);
              stmt.SetParameter(2, (String)parms[1]);
              stmt.SetParameter(3, (short)parms[2]);
              stmt.SetParameter(4, (bool)parms[3]);
              if ( (bool)parms[4] )
              {
                 stmt.setNull( 5 , SqlDbType.Decimal );
              }
              else
              {
                 stmt.SetParameter(5, (long)parms[5]);
              }
              return;
           case 10 :
              stmt.SetParameter(1, (String)parms[0]);
              stmt.SetParameter(2, (String)parms[1]);
              stmt.SetParameter(3, (short)parms[2]);
              stmt.SetParameter(4, (bool)parms[3]);
              if ( (bool)parms[4] )
              {
                 stmt.setNull( 5 , SqlDbType.Decimal );
              }
              else
              {
                 stmt.SetParameter(5, (long)parms[5]);
              }
              stmt.SetParameter(6, (long)parms[6]);
              return;
           case 11 :
              stmt.SetParameter(1, (long)parms[0]);
              return;
           case 12 :
              if ( (bool)parms[0] )
              {
                 stmt.setNull( 1 , SqlDbType.Decimal );
              }
              else
              {
                 stmt.SetParameter(1, (long)parms[1]);
              }
              return;
           case 13 :
              stmt.SetParameter(1, (long)parms[0]);
              return;
           case 14 :
              stmt.SetParameter(1, (long)parms[0]);
              return;
           case 15 :
              stmt.SetParameter(1, (long)parms[0]);
              return;
           case 17 :
              stmt.SetParameter(1, (String)parms[0]);
              stmt.SetParameter(2, (long)parms[1]);
              return;
     }
  }

}

}
