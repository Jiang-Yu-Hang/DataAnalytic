/*
               File: SecUser
        Description: 账号
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/27/2020 9:35:54.91
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
   public class secuser : GXDataArea, System.Web.SessionState.IRequiresSessionState
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
               AV7SecUserId = (short)(NumberUtil.Val( GetNextPar( ), "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7SecUserId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV7SecUserId), 4, 0)));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vSECUSERID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV7SecUserId), "ZZZ9"), context));
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
            Form.Meta.addItem("description", "账号", 0) ;
         }
         context.wjLoc = "";
         context.nUserReturn = 0;
         context.wbHandled = 0;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         GX_FocusControl = edtSecUserName_Internalname;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         wbErr = false;
         context.SetDefaultTheme("WorkWithPlusTheme");
         if ( ! context.IsLocalStorageSupported( ) )
         {
            context.PushCurrentUrl();
         }
      }

      public secuser( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public secuser( IGxContext context )
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
                           short aP1_SecUserId )
      {
         this.Gx_mode = aP0_Gx_mode;
         this.AV7SecUserId = aP1_SecUserId;
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
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 RequiredDataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divUnnamedtablesecusername_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 MergeLabelCell CellWidth_12_5", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblocksecusername_Internalname, "姓名", "", "", lblTextblocksecusername_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_WWPBaseObjects\\SecUser.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 CellWidth_87_5", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtSecUserName_Internalname, "姓名", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 26,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtSecUserName_Internalname, A14SecUserName, StringUtil.RTrim( context.localUtil.Format( A14SecUserName, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,26);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtSecUserName_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtSecUserName_Enabled, 0, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_WWPBaseObjects\\SecUser.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 RequiredDataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divUnnamedtablevsecuserpassword_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 MergeLabelCell CellWidth_12_5", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblockvsecuserpassword_Internalname, "密码", "", "", lblTextblockvsecuserpassword_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_WWPBaseObjects\\SecUser.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 CellWidth_87_5", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavSecuserpassword_Internalname, "密码", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 35,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavSecuserpassword_Internalname, AV16SecUserPassword, StringUtil.RTrim( context.localUtil.Format( AV16SecUserPassword, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,35);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavSecuserpassword_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtavSecuserpassword_Enabled, 0, "text", "", 80, "chr", 1, "row", 100, -1, 0, 0, 1, 0, -1, true, "", "left", true, "HLP_WWPBaseObjects\\SecUser.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
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
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 40,'',false,'',0)\"";
            ClassString = "ButtonMaterial";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtntrn_enter_Internalname, "", "保存", bttBtntrn_enter_Jsonclick, 5, "确认", "", StyleString, ClassString, bttBtntrn_enter_Visible, bttBtntrn_enter_Enabled, "standard", "'"+""+"'"+",false,"+"'"+"EENTER."+"'", TempTags, "", context.GetButtonType( ), "HLP_WWPBaseObjects\\SecUser.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 42,'',false,'',0)\"";
            ClassString = "ButtonMaterialDefault";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtntrn_cancel_Internalname, "", "取消", bttBtntrn_cancel_Jsonclick, 1, "取消", "", StyleString, ClassString, bttBtntrn_cancel_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ECANCEL."+"'", TempTags, "", context.GetButtonType( ), "HLP_WWPBaseObjects\\SecUser.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 44,'',false,'',0)\"";
            ClassString = "ButtonMaterialDefault";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtntrn_delete_Internalname, "", "删除", bttBtntrn_delete_Jsonclick, 5, "删除", "", StyleString, ClassString, bttBtntrn_delete_Visible, bttBtntrn_delete_Enabled, "standard", "'"+""+"'"+",false,"+"'"+"EDELETE."+"'", TempTags, "", context.GetButtonType( ), "HLP_WWPBaseObjects\\SecUser.htm");
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
            GxWebStd.gx_single_line_edit( context, edtSecUserId_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A6SecUserId), 4, 0, ".", "")), ((edtSecUserId_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A6SecUserId), "ZZZ9")) : context.localUtil.Format( (decimal)(A6SecUserId), "ZZZ9")), "", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtSecUserId_Jsonclick, 0, "Attribute", "", "", "", "", edtSecUserId_Visible, edtSecUserId_Enabled, 0, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_WWPBaseObjects\\SecUser.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 49,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtSecUserPassword_Internalname, A15SecUserPassword, StringUtil.RTrim( context.localUtil.Format( A15SecUserPassword, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,49);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtSecUserPassword_Jsonclick, 0, "Attribute", "", "", "", "", edtSecUserPassword_Visible, edtSecUserPassword_Enabled, 0, "text", "", 80, "chr", 1, "row", 100, -1, 0, 0, 1, 0, -1, true, "", "left", true, "HLP_WWPBaseObjects\\SecUser.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 50,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtSecUserCrtUser_Internalname, A178SecUserCrtUser, StringUtil.RTrim( context.localUtil.Format( A178SecUserCrtUser, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,50);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtSecUserCrtUser_Jsonclick, 0, "Attribute", "", "", "", "", edtSecUserCrtUser_Visible, edtSecUserCrtUser_Enabled, 0, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, -1, true, "CrtUser", "left", true, "HLP_WWPBaseObjects\\SecUser.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 51,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtSecUserUpdUser_Internalname, A179SecUserUpdUser, StringUtil.RTrim( context.localUtil.Format( A179SecUserUpdUser, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,51);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtSecUserUpdUser_Jsonclick, 0, "Attribute", "", "", "", "", edtSecUserUpdUser_Visible, edtSecUserUpdUser_Enabled, 0, "text", "", 40, "chr", 1, "row", 40, 0, 0, 0, 1, -1, -1, true, "UpdUser", "left", true, "HLP_WWPBaseObjects\\SecUser.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 52,'',false,'',0)\"";
            context.WriteHtmlText( "<div id=\""+edtSecUserCrtDate_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtSecUserCrtDate_Internalname, context.localUtil.TToC( A180SecUserCrtDate, 10, 8, 0, 0, "/", ":", " "), context.localUtil.Format( A180SecUserCrtDate, "99/99/99 99:99"), TempTags+" onchange=\""+"gx.date.valid_date(this, 8,'YMD',5,24,'chs',false,1);"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,52);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtSecUserCrtDate_Jsonclick, 0, "Attribute", "", "", "", "", edtSecUserCrtDate_Visible, edtSecUserCrtDate_Enabled, 0, "text", "", 14, "chr", 1, "row", 14, 0, 0, 0, 1, -1, 0, true, "CrtDate", "right", false, "HLP_WWPBaseObjects\\SecUser.htm");
            GxWebStd.gx_bitmap( context, edtSecUserCrtDate_Internalname+"_dp_trigger", context.GetImagePath( "61b9b5d3-dff6-4d59-9b00-da61bc2cbe93", "", context.GetTheme( )), "", "", "", "", ((edtSecUserCrtDate_Visible==0)||(edtSecUserCrtDate_Enabled==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;", "", "", "", "", "", "", "", "", 1, false, false, "", "HLP_WWPBaseObjects\\SecUser.htm");
            context.WriteHtmlTextNl( "</div>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 53,'',false,'',0)\"";
            context.WriteHtmlText( "<div id=\""+edtSecUserUpdDate_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtSecUserUpdDate_Internalname, context.localUtil.TToC( A181SecUserUpdDate, 10, 8, 0, 0, "/", ":", " "), context.localUtil.Format( A181SecUserUpdDate, "9999/99/99 99:99:99"), TempTags+" onchange=\""+"gx.date.valid_date(this, 10,'YMD',8,24,'chs',false,1);"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,53);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtSecUserUpdDate_Jsonclick, 0, "Attribute", "", "", "", "", edtSecUserUpdDate_Visible, edtSecUserUpdDate_Enabled, 0, "text", "", 19, "chr", 1, "row", 19, 0, 0, 0, 1, -1, 0, true, "UpdDate", "right", false, "HLP_WWPBaseObjects\\SecUser.htm");
            GxWebStd.gx_bitmap( context, edtSecUserUpdDate_Internalname+"_dp_trigger", context.GetImagePath( "61b9b5d3-dff6-4d59-9b00-da61bc2cbe93", "", context.GetTheme( )), "", "", "", "", ((edtSecUserUpdDate_Visible==0)||(edtSecUserUpdDate_Enabled==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;", "", "", "", "", "", "", "", "", 1, false, false, "", "HLP_WWPBaseObjects\\SecUser.htm");
            context.WriteHtmlTextNl( "</div>") ;
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
         E11052 ();
         context.wbGlbDoneStart = 1;
         assign_properties_default( ) ;
         if ( AnyError == 0 )
         {
            if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
            {
               /* Read saved SDTs. */
               /* Read variables values. */
               A14SecUserName = cgiGet( edtSecUserName_Internalname);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A14SecUserName", A14SecUserName);
               AV16SecUserPassword = cgiGet( edtavSecuserpassword_Internalname);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV16SecUserPassword", AV16SecUserPassword);
               A6SecUserId = (short)(context.localUtil.CToN( cgiGet( edtSecUserId_Internalname), ".", ","));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A6SecUserId", StringUtil.LTrim( StringUtil.Str( (decimal)(A6SecUserId), 4, 0)));
               A15SecUserPassword = cgiGet( edtSecUserPassword_Internalname);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A15SecUserPassword", A15SecUserPassword);
               A178SecUserCrtUser = cgiGet( edtSecUserCrtUser_Internalname);
               n178SecUserCrtUser = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A178SecUserCrtUser", A178SecUserCrtUser);
               n178SecUserCrtUser = (String.IsNullOrEmpty(StringUtil.RTrim( A178SecUserCrtUser)) ? true : false);
               A179SecUserUpdUser = cgiGet( edtSecUserUpdUser_Internalname);
               n179SecUserUpdUser = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A179SecUserUpdUser", A179SecUserUpdUser);
               n179SecUserUpdUser = (String.IsNullOrEmpty(StringUtil.RTrim( A179SecUserUpdUser)) ? true : false);
               if ( context.localUtil.VCDateTime( cgiGet( edtSecUserCrtDate_Internalname), 0, 0) == 0 )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_baddatetime", new   object[]  {"创建时间"}), 1, "SECUSERCRTDATE");
                  AnyError = 1;
                  GX_FocusControl = edtSecUserCrtDate_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A180SecUserCrtDate = (DateTime)(DateTime.MinValue);
                  n180SecUserCrtDate = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A180SecUserCrtDate", context.localUtil.TToC( A180SecUserCrtDate, 8, 5, 0, 0, "/", ":", " "));
               }
               else
               {
                  A180SecUserCrtDate = context.localUtil.CToT( cgiGet( edtSecUserCrtDate_Internalname));
                  n180SecUserCrtDate = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A180SecUserCrtDate", context.localUtil.TToC( A180SecUserCrtDate, 8, 5, 0, 0, "/", ":", " "));
               }
               n180SecUserCrtDate = ((DateTime.MinValue==A180SecUserCrtDate) ? true : false);
               if ( context.localUtil.VCDateTime( cgiGet( edtSecUserUpdDate_Internalname), 0, 0) == 0 )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_baddatetime", new   object[]  {"更新时间"}), 1, "SECUSERUPDDATE");
                  AnyError = 1;
                  GX_FocusControl = edtSecUserUpdDate_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A181SecUserUpdDate = (DateTime)(DateTime.MinValue);
                  n181SecUserUpdDate = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A181SecUserUpdDate", context.localUtil.TToC( A181SecUserUpdDate, 10, 8, 0, 0, "/", ":", " "));
               }
               else
               {
                  A181SecUserUpdDate = context.localUtil.CToT( cgiGet( edtSecUserUpdDate_Internalname));
                  n181SecUserUpdDate = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A181SecUserUpdDate", context.localUtil.TToC( A181SecUserUpdDate, 10, 8, 0, 0, "/", ":", " "));
               }
               n181SecUserUpdDate = ((DateTime.MinValue==A181SecUserUpdDate) ? true : false);
               /* Read saved values. */
               Z6SecUserId = (short)(context.localUtil.CToN( cgiGet( "Z6SecUserId"), ".", ","));
               Z178SecUserCrtUser = cgiGet( "Z178SecUserCrtUser");
               n178SecUserCrtUser = (String.IsNullOrEmpty(StringUtil.RTrim( A178SecUserCrtUser)) ? true : false);
               Z180SecUserCrtDate = context.localUtil.CToT( cgiGet( "Z180SecUserCrtDate"), 0);
               n180SecUserCrtDate = ((DateTime.MinValue==A180SecUserCrtDate) ? true : false);
               Z14SecUserName = cgiGet( "Z14SecUserName");
               Z15SecUserPassword = cgiGet( "Z15SecUserPassword");
               Z179SecUserUpdUser = cgiGet( "Z179SecUserUpdUser");
               n179SecUserUpdUser = (String.IsNullOrEmpty(StringUtil.RTrim( A179SecUserUpdUser)) ? true : false);
               Z181SecUserUpdDate = context.localUtil.CToT( cgiGet( "Z181SecUserUpdDate"), 0);
               n181SecUserUpdDate = ((DateTime.MinValue==A181SecUserUpdDate) ? true : false);
               Z194SecUserWorkload = (long)(context.localUtil.CToN( cgiGet( "Z194SecUserWorkload"), ".", ","));
               n194SecUserWorkload = ((0==A194SecUserWorkload) ? true : false);
               A194SecUserWorkload = (long)(context.localUtil.CToN( cgiGet( "Z194SecUserWorkload"), ".", ","));
               n194SecUserWorkload = false;
               n194SecUserWorkload = ((0==A194SecUserWorkload) ? true : false);
               IsConfirmed = (short)(context.localUtil.CToN( cgiGet( "IsConfirmed"), ".", ","));
               IsModified = (short)(context.localUtil.CToN( cgiGet( "IsModified"), ".", ","));
               Gx_mode = cgiGet( "Mode");
               AV7SecUserId = (short)(context.localUtil.CToN( cgiGet( "vSECUSERID"), ".", ","));
               A194SecUserWorkload = (long)(context.localUtil.CToN( cgiGet( "SECUSERWORKLOAD"), ".", ","));
               n194SecUserWorkload = ((0==A194SecUserWorkload) ? true : false);
               AV17Pgmname = cgiGet( "vPGMNAME");
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
               forbiddenHiddens = "hsh" + "SecUser";
               A6SecUserId = (short)(context.localUtil.CToN( cgiGet( edtSecUserId_Internalname), ".", ","));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A6SecUserId", StringUtil.LTrim( StringUtil.Str( (decimal)(A6SecUserId), 4, 0)));
               forbiddenHiddens = forbiddenHiddens + context.localUtil.Format( (decimal)(A6SecUserId), "ZZZ9");
               forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!"));
               forbiddenHiddens = forbiddenHiddens + context.localUtil.Format( (decimal)(A194SecUserWorkload), "ZZZZZZZZZ9");
               hsh = cgiGet( "hsh");
               if ( ( ! ( ( A6SecUserId != Z6SecUserId ) ) || ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) ) && ! GXUtil.CheckEncryptedHash( forbiddenHiddens, hsh, GXKey) )
               {
                  GXUtil.WriteLog("wwpbaseobjects.secuser:[SecurityCheckFailed value for]"+"SecUserId:"+context.localUtil.Format( (decimal)(A6SecUserId), "ZZZ9"));
                  GXUtil.WriteLog("wwpbaseobjects.secuser:[SecurityCheckFailed value for]"+"Gx_mode:"+StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")));
                  GXUtil.WriteLog("wwpbaseobjects.secuser:[SecurityCheckFailed value for]"+"SecUserWorkload:"+context.localUtil.Format( (decimal)(A194SecUserWorkload), "ZZZZZZZZZ9"));
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
                  A6SecUserId = (short)(NumberUtil.Val( GetNextPar( ), "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A6SecUserId", StringUtil.LTrim( StringUtil.Str( (decimal)(A6SecUserId), 4, 0)));
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
                     sMode6 = Gx_mode;
                     Gx_mode = "UPD";
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                     Gx_mode = sMode6;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                  }
                  standaloneModal( ) ;
                  if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
                  {
                     getByPrimaryKey( ) ;
                     if ( RcdFound6 == 1 )
                     {
                        if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
                        {
                           /* Confirm record */
                           CONFIRM_050( ) ;
                           if ( AnyError == 0 )
                           {
                              GX_FocusControl = bttBtntrn_enter_Internalname;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                           }
                        }
                     }
                     else
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_noinsert", ""), 1, "SECUSERID");
                        AnyError = 1;
                        GX_FocusControl = edtSecUserId_Internalname;
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
                           E11052 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "AFTER TRN") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           /* Execute user event: After Trn */
                           E12052 ();
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
            E12052 ();
            trnEnded = 0;
            standaloneNotModal( ) ;
            standaloneModal( ) ;
            if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  )
            {
               /* Clear variables for new insertion. */
               InitAll056( ) ;
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
            DisableAttributes056( ) ;
         }
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavSecuserpassword_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavSecuserpassword_Enabled), 5, 0)), true);
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

      protected void CONFIRM_050( )
      {
         BeforeValidate056( ) ;
         if ( AnyError == 0 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
            {
               OnDeleteControls056( ) ;
            }
            else
            {
               CheckExtendedTable056( ) ;
               CloseExtendedTableCursors056( ) ;
            }
         }
         if ( AnyError == 0 )
         {
            IsConfirmed = 1;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "IsConfirmed", StringUtil.LTrim( StringUtil.Str( (decimal)(IsConfirmed), 4, 0)));
         }
      }

      protected void ResetCaption050( )
      {
      }

      protected void E11052( )
      {
         /* Start Routine */
         new GeneXus.Programs.wwpbaseobjects.loadwwpcontext(context ).execute( out  AV15WWPContext) ;
         AV9IsAuthorized = true;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9IsAuthorized", AV9IsAuthorized);
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            GXt_boolean1 = AV9IsAuthorized;
            new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "WWSecUser_Insert", out  GXt_boolean1) ;
            AV9IsAuthorized = GXt_boolean1;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9IsAuthorized", AV9IsAuthorized);
         }
         if ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 )
         {
            GXt_boolean1 = AV9IsAuthorized;
            new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "WWSecUser_Update", out  GXt_boolean1) ;
            AV9IsAuthorized = GXt_boolean1;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9IsAuthorized", AV9IsAuthorized);
         }
         if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
         {
            GXt_boolean1 = AV9IsAuthorized;
            new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "WWSecUser_Delete", out  GXt_boolean1) ;
            AV9IsAuthorized = GXt_boolean1;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9IsAuthorized", AV9IsAuthorized);
         }
         if ( ! AV9IsAuthorized )
         {
            CallWebObject(formatLink("wwpbaseobjects.notauthorized.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV17Pgmname)));
            context.wjLocDisableFrm = 1;
         }
         AV11TrnContext.FromXml(AV12WebSession.Get("TrnContext"), null, "WWPTransactionContext", "DataAnalysisPlatform");
         edtSecUserId_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtSecUserId_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtSecUserId_Visible), 5, 0)), true);
         edtSecUserPassword_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtSecUserPassword_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtSecUserPassword_Visible), 5, 0)), true);
         edtSecUserCrtUser_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtSecUserCrtUser_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtSecUserCrtUser_Visible), 5, 0)), true);
         edtSecUserUpdUser_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtSecUserUpdUser_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtSecUserUpdUser_Visible), 5, 0)), true);
         edtSecUserCrtDate_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtSecUserCrtDate_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtSecUserCrtDate_Visible), 5, 0)), true);
         edtSecUserUpdDate_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtSecUserUpdDate_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtSecUserUpdDate_Visible), 5, 0)), true);
      }

      protected void E12052( )
      {
         /* After Trn Routine */
         if ( ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 ) && ! AV11TrnContext.gxTpr_Callerondelete )
         {
            CallWebObject(formatLink("wwpbaseobjects.secuserww.aspx") );
            context.wjLocDisableFrm = 1;
         }
         context.setWebReturnParms(new Object[] {});
         context.setWebReturnParmsMetadata(new Object[] {});
         context.wjLocDisableFrm = 1;
         context.nUserReturn = 1;
         returnInSub = true;
         if (true) return;
      }

      protected void ZM056( short GX_JID )
      {
         if ( ( GX_JID == 9 ) || ( GX_JID == 0 ) )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
            {
               Z178SecUserCrtUser = T00053_A178SecUserCrtUser[0];
               Z180SecUserCrtDate = T00053_A180SecUserCrtDate[0];
               Z14SecUserName = T00053_A14SecUserName[0];
               Z15SecUserPassword = T00053_A15SecUserPassword[0];
               Z179SecUserUpdUser = T00053_A179SecUserUpdUser[0];
               Z181SecUserUpdDate = T00053_A181SecUserUpdDate[0];
               Z194SecUserWorkload = T00053_A194SecUserWorkload[0];
            }
            else
            {
               Z178SecUserCrtUser = A178SecUserCrtUser;
               Z180SecUserCrtDate = A180SecUserCrtDate;
               Z14SecUserName = A14SecUserName;
               Z15SecUserPassword = A15SecUserPassword;
               Z179SecUserUpdUser = A179SecUserUpdUser;
               Z181SecUserUpdDate = A181SecUserUpdDate;
               Z194SecUserWorkload = A194SecUserWorkload;
            }
         }
         if ( GX_JID == -9 )
         {
            Z6SecUserId = A6SecUserId;
            Z178SecUserCrtUser = A178SecUserCrtUser;
            Z180SecUserCrtDate = A180SecUserCrtDate;
            Z14SecUserName = A14SecUserName;
            Z15SecUserPassword = A15SecUserPassword;
            Z179SecUserUpdUser = A179SecUserUpdUser;
            Z181SecUserUpdDate = A181SecUserUpdDate;
            Z194SecUserWorkload = A194SecUserWorkload;
         }
      }

      protected void standaloneNotModal( )
      {
         edtSecUserId_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtSecUserId_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtSecUserId_Enabled), 5, 0)), true);
         edtSecUserId_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtSecUserId_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtSecUserId_Enabled), 5, 0)), true);
         bttBtntrn_delete_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtntrn_delete_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtntrn_delete_Enabled), 5, 0)), true);
         if ( ! (0==AV7SecUserId) )
         {
            A6SecUserId = AV7SecUserId;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A6SecUserId", StringUtil.LTrim( StringUtil.Str( (decimal)(A6SecUserId), 4, 0)));
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
      }

      protected void Load056( )
      {
         /* Using cursor T00054 */
         pr_default.execute(2, new Object[] {A6SecUserId});
         if ( (pr_default.getStatus(2) != 101) )
         {
            RcdFound6 = 1;
            A178SecUserCrtUser = T00054_A178SecUserCrtUser[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A178SecUserCrtUser", A178SecUserCrtUser);
            n178SecUserCrtUser = T00054_n178SecUserCrtUser[0];
            A180SecUserCrtDate = T00054_A180SecUserCrtDate[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A180SecUserCrtDate", context.localUtil.TToC( A180SecUserCrtDate, 8, 5, 0, 0, "/", ":", " "));
            n180SecUserCrtDate = T00054_n180SecUserCrtDate[0];
            A14SecUserName = T00054_A14SecUserName[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A14SecUserName", A14SecUserName);
            A15SecUserPassword = T00054_A15SecUserPassword[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A15SecUserPassword", A15SecUserPassword);
            A179SecUserUpdUser = T00054_A179SecUserUpdUser[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A179SecUserUpdUser", A179SecUserUpdUser);
            n179SecUserUpdUser = T00054_n179SecUserUpdUser[0];
            A181SecUserUpdDate = T00054_A181SecUserUpdDate[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A181SecUserUpdDate", context.localUtil.TToC( A181SecUserUpdDate, 10, 8, 0, 0, "/", ":", " "));
            n181SecUserUpdDate = T00054_n181SecUserUpdDate[0];
            A194SecUserWorkload = T00054_A194SecUserWorkload[0];
            n194SecUserWorkload = T00054_n194SecUserWorkload[0];
            ZM056( -9) ;
         }
         pr_default.close(2);
         OnLoadActions056( ) ;
      }

      protected void OnLoadActions056( )
      {
         AV17Pgmname = "WWPBaseObjects.SecUser";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV17Pgmname", AV17Pgmname);
      }

      protected void CheckExtendedTable056( )
      {
         Gx_BScreen = 1;
         standaloneModal( ) ;
         AV17Pgmname = "WWPBaseObjects.SecUser";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV17Pgmname", AV17Pgmname);
         if ( String.IsNullOrEmpty(StringUtil.RTrim( A14SecUserName)) )
         {
            GX_msglist.addItem("姓名是必须填写的。", 1, "SECUSERNAME");
            AnyError = 1;
            GX_FocusControl = edtSecUserName_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( ! ( (DateTime.MinValue==A180SecUserCrtDate) || ( A180SecUserCrtDate >= context.localUtil.YMDHMSToT( 1753, 1, 1, 0, 0, 0) ) ) )
         {
            GX_msglist.addItem("域������������超界", "OutOfRange", 1, "SECUSERCRTDATE");
            AnyError = 1;
            GX_FocusControl = edtSecUserCrtDate_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( ! ( (DateTime.MinValue==A181SecUserUpdDate) || ( A181SecUserUpdDate >= context.localUtil.YMDHMSToT( 1753, 1, 1, 0, 0, 0) ) ) )
         {
            GX_msglist.addItem("域������������超界", "OutOfRange", 1, "SECUSERUPDDATE");
            AnyError = 1;
            GX_FocusControl = edtSecUserUpdDate_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV16SecUserPassword)) )
         {
            GX_msglist.addItem("密码是必须填写的。", 1, "vSECUSERPASSWORD");
            AnyError = 1;
            GX_FocusControl = edtavSecuserpassword_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
      }

      protected void CloseExtendedTableCursors056( )
      {
      }

      protected void enableDisable( )
      {
      }

      protected void GetKey056( )
      {
         /* Using cursor T00055 */
         pr_default.execute(3, new Object[] {A6SecUserId});
         if ( (pr_default.getStatus(3) != 101) )
         {
            RcdFound6 = 1;
         }
         else
         {
            RcdFound6 = 0;
         }
         pr_default.close(3);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor T00053 */
         pr_default.execute(1, new Object[] {A6SecUserId});
         if ( (pr_default.getStatus(1) != 101) )
         {
            ZM056( 9) ;
            RcdFound6 = 1;
            A6SecUserId = T00053_A6SecUserId[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A6SecUserId", StringUtil.LTrim( StringUtil.Str( (decimal)(A6SecUserId), 4, 0)));
            A178SecUserCrtUser = T00053_A178SecUserCrtUser[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A178SecUserCrtUser", A178SecUserCrtUser);
            n178SecUserCrtUser = T00053_n178SecUserCrtUser[0];
            A180SecUserCrtDate = T00053_A180SecUserCrtDate[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A180SecUserCrtDate", context.localUtil.TToC( A180SecUserCrtDate, 8, 5, 0, 0, "/", ":", " "));
            n180SecUserCrtDate = T00053_n180SecUserCrtDate[0];
            A14SecUserName = T00053_A14SecUserName[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A14SecUserName", A14SecUserName);
            A15SecUserPassword = T00053_A15SecUserPassword[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A15SecUserPassword", A15SecUserPassword);
            A179SecUserUpdUser = T00053_A179SecUserUpdUser[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A179SecUserUpdUser", A179SecUserUpdUser);
            n179SecUserUpdUser = T00053_n179SecUserUpdUser[0];
            A181SecUserUpdDate = T00053_A181SecUserUpdDate[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A181SecUserUpdDate", context.localUtil.TToC( A181SecUserUpdDate, 10, 8, 0, 0, "/", ":", " "));
            n181SecUserUpdDate = T00053_n181SecUserUpdDate[0];
            A194SecUserWorkload = T00053_A194SecUserWorkload[0];
            n194SecUserWorkload = T00053_n194SecUserWorkload[0];
            Z6SecUserId = A6SecUserId;
            sMode6 = Gx_mode;
            Gx_mode = "DSP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
            Load056( ) ;
            if ( AnyError == 1 )
            {
               RcdFound6 = 0;
               InitializeNonKey056( ) ;
            }
            Gx_mode = sMode6;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         }
         else
         {
            RcdFound6 = 0;
            InitializeNonKey056( ) ;
            sMode6 = Gx_mode;
            Gx_mode = "DSP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
            standaloneModal( ) ;
            Gx_mode = sMode6;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         }
         pr_default.close(1);
      }

      protected void getEqualNoModal( )
      {
         GetKey056( ) ;
         if ( RcdFound6 == 0 )
         {
         }
         else
         {
         }
         getByPrimaryKey( ) ;
      }

      protected void move_next( )
      {
         RcdFound6 = 0;
         /* Using cursor T00056 */
         pr_default.execute(4, new Object[] {A6SecUserId});
         if ( (pr_default.getStatus(4) != 101) )
         {
            while ( (pr_default.getStatus(4) != 101) && ( ( T00056_A6SecUserId[0] < A6SecUserId ) ) )
            {
               pr_default.readNext(4);
            }
            if ( (pr_default.getStatus(4) != 101) && ( ( T00056_A6SecUserId[0] > A6SecUserId ) ) )
            {
               A6SecUserId = T00056_A6SecUserId[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A6SecUserId", StringUtil.LTrim( StringUtil.Str( (decimal)(A6SecUserId), 4, 0)));
               RcdFound6 = 1;
            }
         }
         pr_default.close(4);
      }

      protected void move_previous( )
      {
         RcdFound6 = 0;
         /* Using cursor T00057 */
         pr_default.execute(5, new Object[] {A6SecUserId});
         if ( (pr_default.getStatus(5) != 101) )
         {
            while ( (pr_default.getStatus(5) != 101) && ( ( T00057_A6SecUserId[0] > A6SecUserId ) ) )
            {
               pr_default.readNext(5);
            }
            if ( (pr_default.getStatus(5) != 101) && ( ( T00057_A6SecUserId[0] < A6SecUserId ) ) )
            {
               A6SecUserId = T00057_A6SecUserId[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A6SecUserId", StringUtil.LTrim( StringUtil.Str( (decimal)(A6SecUserId), 4, 0)));
               RcdFound6 = 1;
            }
         }
         pr_default.close(5);
      }

      protected void btn_enter( )
      {
         nKeyPressed = 1;
         GetKey056( ) ;
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            /* Insert record */
            GX_FocusControl = edtSecUserName_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            Insert056( ) ;
            if ( AnyError == 1 )
            {
               GX_FocusControl = "";
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
         }
         else
         {
            if ( RcdFound6 == 1 )
            {
               if ( A6SecUserId != Z6SecUserId )
               {
                  A6SecUserId = Z6SecUserId;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A6SecUserId", StringUtil.LTrim( StringUtil.Str( (decimal)(A6SecUserId), 4, 0)));
                  GX_msglist.addItem(context.GetMessage( "GXM_getbeforeupd", ""), "CandidateKeyNotFound", 1, "SECUSERID");
                  AnyError = 1;
                  GX_FocusControl = edtSecUserId_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
               else if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
               {
                  delete( ) ;
                  AfterTrn( ) ;
                  GX_FocusControl = edtSecUserName_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
               else
               {
                  /* Update record */
                  Update056( ) ;
                  GX_FocusControl = edtSecUserName_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
            }
            else
            {
               if ( A6SecUserId != Z6SecUserId )
               {
                  /* Insert record */
                  GX_FocusControl = edtSecUserName_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  Insert056( ) ;
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
                     /* Insert record */
                     GX_FocusControl = edtSecUserName_Internalname;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                     Insert056( ) ;
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
         if ( A6SecUserId != Z6SecUserId )
         {
            A6SecUserId = Z6SecUserId;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A6SecUserId", StringUtil.LTrim( StringUtil.Str( (decimal)(A6SecUserId), 4, 0)));
            GX_msglist.addItem(context.GetMessage( "GXM_getbeforedlt", ""), 1, "SECUSERID");
            AnyError = 1;
            GX_FocusControl = edtSecUserId_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         else
         {
            delete( ) ;
            AfterTrn( ) ;
            GX_FocusControl = edtSecUserName_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( AnyError != 0 )
         {
         }
      }

      protected void CheckOptimisticConcurrency056( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor T00052 */
            pr_default.execute(0, new Object[] {A6SecUserId});
            if ( (pr_default.getStatus(0) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"SecUser"}), "RecordIsLocked", 1, "");
               AnyError = 1;
               return  ;
            }
            Gx_longc = false;
            if ( (pr_default.getStatus(0) == 101) || ( StringUtil.StrCmp(Z178SecUserCrtUser, T00052_A178SecUserCrtUser[0]) != 0 ) || ( Z180SecUserCrtDate != T00052_A180SecUserCrtDate[0] ) || ( StringUtil.StrCmp(Z14SecUserName, T00052_A14SecUserName[0]) != 0 ) || ( StringUtil.StrCmp(Z15SecUserPassword, T00052_A15SecUserPassword[0]) != 0 ) || ( StringUtil.StrCmp(Z179SecUserUpdUser, T00052_A179SecUserUpdUser[0]) != 0 ) )
            {
               Gx_longc = true;
            }
            if ( Gx_longc || ( Z181SecUserUpdDate != T00052_A181SecUserUpdDate[0] ) || ( Z194SecUserWorkload != T00052_A194SecUserWorkload[0] ) )
            {
               if ( StringUtil.StrCmp(Z178SecUserCrtUser, T00052_A178SecUserCrtUser[0]) != 0 )
               {
                  GXUtil.WriteLog("wwpbaseobjects.secuser:[seudo value changed for attri]"+"SecUserCrtUser");
                  GXUtil.WriteLogRaw("Old: ",Z178SecUserCrtUser);
                  GXUtil.WriteLogRaw("Current: ",T00052_A178SecUserCrtUser[0]);
               }
               if ( Z180SecUserCrtDate != T00052_A180SecUserCrtDate[0] )
               {
                  GXUtil.WriteLog("wwpbaseobjects.secuser:[seudo value changed for attri]"+"SecUserCrtDate");
                  GXUtil.WriteLogRaw("Old: ",Z180SecUserCrtDate);
                  GXUtil.WriteLogRaw("Current: ",T00052_A180SecUserCrtDate[0]);
               }
               if ( StringUtil.StrCmp(Z14SecUserName, T00052_A14SecUserName[0]) != 0 )
               {
                  GXUtil.WriteLog("wwpbaseobjects.secuser:[seudo value changed for attri]"+"SecUserName");
                  GXUtil.WriteLogRaw("Old: ",Z14SecUserName);
                  GXUtil.WriteLogRaw("Current: ",T00052_A14SecUserName[0]);
               }
               if ( StringUtil.StrCmp(Z15SecUserPassword, T00052_A15SecUserPassword[0]) != 0 )
               {
                  GXUtil.WriteLog("wwpbaseobjects.secuser:[seudo value changed for attri]"+"SecUserPassword");
                  GXUtil.WriteLogRaw("Old: ",Z15SecUserPassword);
                  GXUtil.WriteLogRaw("Current: ",T00052_A15SecUserPassword[0]);
               }
               if ( StringUtil.StrCmp(Z179SecUserUpdUser, T00052_A179SecUserUpdUser[0]) != 0 )
               {
                  GXUtil.WriteLog("wwpbaseobjects.secuser:[seudo value changed for attri]"+"SecUserUpdUser");
                  GXUtil.WriteLogRaw("Old: ",Z179SecUserUpdUser);
                  GXUtil.WriteLogRaw("Current: ",T00052_A179SecUserUpdUser[0]);
               }
               if ( Z181SecUserUpdDate != T00052_A181SecUserUpdDate[0] )
               {
                  GXUtil.WriteLog("wwpbaseobjects.secuser:[seudo value changed for attri]"+"SecUserUpdDate");
                  GXUtil.WriteLogRaw("Old: ",Z181SecUserUpdDate);
                  GXUtil.WriteLogRaw("Current: ",T00052_A181SecUserUpdDate[0]);
               }
               if ( Z194SecUserWorkload != T00052_A194SecUserWorkload[0] )
               {
                  GXUtil.WriteLog("wwpbaseobjects.secuser:[seudo value changed for attri]"+"SecUserWorkload");
                  GXUtil.WriteLogRaw("Old: ",Z194SecUserWorkload);
                  GXUtil.WriteLogRaw("Current: ",T00052_A194SecUserWorkload[0]);
               }
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"SecUser"}), "RecordWasChanged", 1, "");
               AnyError = 1;
               return  ;
            }
         }
      }

      protected void Insert056( )
      {
         BeforeValidate056( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable056( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM056( 0) ;
            CheckOptimisticConcurrency056( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm056( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert056( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T00058 */
                     pr_default.execute(6, new Object[] {n178SecUserCrtUser, A178SecUserCrtUser, n180SecUserCrtDate, A180SecUserCrtDate, A14SecUserName, A15SecUserPassword, n179SecUserUpdUser, A179SecUserUpdUser, n181SecUserUpdDate, A181SecUserUpdDate, n194SecUserWorkload, A194SecUserWorkload});
                     A6SecUserId = T00058_A6SecUserId[0];
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A6SecUserId", StringUtil.LTrim( StringUtil.Str( (decimal)(A6SecUserId), 4, 0)));
                     pr_default.close(6);
                     dsDefault.SmartCacheProvider.SetUpdated("SecUser") ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( Insert) rules */
                        /* End of After( Insert) rules */
                        if ( AnyError == 0 )
                        {
                           /* Save values for previous() function. */
                           GX_msglist.addItem(context.GetMessage( "GXM_sucadded", ""), "SuccessfullyAdded", 0, "", true);
                           ResetCaption050( ) ;
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
               Load056( ) ;
            }
            EndLevel056( ) ;
         }
         CloseExtendedTableCursors056( ) ;
      }

      protected void Update056( )
      {
         BeforeValidate056( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable056( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency056( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm056( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate056( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T00059 */
                     pr_default.execute(7, new Object[] {n178SecUserCrtUser, A178SecUserCrtUser, n180SecUserCrtDate, A180SecUserCrtDate, A14SecUserName, A15SecUserPassword, n179SecUserUpdUser, A179SecUserUpdUser, n181SecUserUpdDate, A181SecUserUpdDate, n194SecUserWorkload, A194SecUserWorkload, A6SecUserId});
                     pr_default.close(7);
                     dsDefault.SmartCacheProvider.SetUpdated("SecUser") ;
                     if ( (pr_default.getStatus(7) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"SecUser"}), "RecordIsLocked", 1, "");
                        AnyError = 1;
                     }
                     DeferredUpdate056( ) ;
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
            EndLevel056( ) ;
         }
         CloseExtendedTableCursors056( ) ;
      }

      protected void DeferredUpdate056( )
      {
      }

      protected void delete( )
      {
         BeforeValidate056( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency056( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls056( ) ;
            AfterConfirm056( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete056( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor T000510 */
                  pr_default.execute(8, new Object[] {A6SecUserId});
                  pr_default.close(8);
                  dsDefault.SmartCacheProvider.SetUpdated("SecUser") ;
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
         sMode6 = Gx_mode;
         Gx_mode = "DLT";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         EndLevel056( ) ;
         Gx_mode = sMode6;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
      }

      protected void OnDeleteControls056( )
      {
         standaloneModal( ) ;
         if ( AnyError == 0 )
         {
            /* Delete mode formulas */
            AV17Pgmname = "WWPBaseObjects.SecUser";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV17Pgmname", AV17Pgmname);
         }
         if ( AnyError == 0 )
         {
            /* Using cursor T000511 */
            pr_default.execute(9, new Object[] {A6SecUserId});
            if ( (pr_default.getStatus(9) != 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_del", new   object[]  {"医院账号关系表"}), "CannotDeleteReferencedRecord", 1, "");
               AnyError = 1;
            }
            pr_default.close(9);
            /* Using cursor T000512 */
            pr_default.execute(10, new Object[] {A6SecUserId});
            if ( (pr_default.getStatus(10) != 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_del", new   object[]  {"Sec User Role"}), "CannotDeleteReferencedRecord", 1, "");
               AnyError = 1;
            }
            pr_default.close(10);
         }
      }

      protected void EndLevel056( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            pr_default.close(0);
         }
         if ( AnyError == 0 )
         {
            BeforeComplete056( ) ;
         }
         if ( AnyError == 0 )
         {
            pr_default.close(1);
            context.CommitDataStores("wwpbaseobjects.secuser",pr_default);
            if ( AnyError == 0 )
            {
               ConfirmValues050( ) ;
            }
            /* After transaction rules */
            /* Execute 'After Trn' event if defined. */
            trnEnded = 1;
         }
         else
         {
            pr_default.close(1);
            context.RollbackDataStores("wwpbaseobjects.secuser",pr_default);
         }
         IsModified = 0;
         if ( AnyError != 0 )
         {
            context.wjLoc = "";
            context.nUserReturn = 0;
         }
      }

      public void ScanStart056( )
      {
         /* Scan By routine */
         /* Using cursor T000513 */
         pr_default.execute(11);
         RcdFound6 = 0;
         if ( (pr_default.getStatus(11) != 101) )
         {
            RcdFound6 = 1;
            A6SecUserId = T000513_A6SecUserId[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A6SecUserId", StringUtil.LTrim( StringUtil.Str( (decimal)(A6SecUserId), 4, 0)));
         }
         /* Load Subordinate Levels */
      }

      protected void ScanNext056( )
      {
         /* Scan next routine */
         pr_default.readNext(11);
         RcdFound6 = 0;
         if ( (pr_default.getStatus(11) != 101) )
         {
            RcdFound6 = 1;
            A6SecUserId = T000513_A6SecUserId[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A6SecUserId", StringUtil.LTrim( StringUtil.Str( (decimal)(A6SecUserId), 4, 0)));
         }
      }

      protected void ScanEnd056( )
      {
         pr_default.close(11);
      }

      protected void AfterConfirm056( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert056( )
      {
         /* Before Insert Rules */
         A180SecUserCrtDate = DateTimeUtil.ServerNow( context, pr_default);
         n180SecUserCrtDate = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A180SecUserCrtDate", context.localUtil.TToC( A180SecUserCrtDate, 8, 5, 0, 0, "/", ":", " "));
         A178SecUserCrtUser = AV15WWPContext.gxTpr_Username;
         n178SecUserCrtUser = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A178SecUserCrtUser", A178SecUserCrtUser);
      }

      protected void BeforeUpdate056( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete056( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete056( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate056( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes056( )
      {
         edtSecUserName_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtSecUserName_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtSecUserName_Enabled), 5, 0)), true);
         edtavSecuserpassword_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavSecuserpassword_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavSecuserpassword_Enabled), 5, 0)), true);
         edtSecUserId_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtSecUserId_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtSecUserId_Enabled), 5, 0)), true);
         edtSecUserPassword_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtSecUserPassword_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtSecUserPassword_Enabled), 5, 0)), true);
         edtSecUserCrtUser_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtSecUserCrtUser_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtSecUserCrtUser_Enabled), 5, 0)), true);
         edtSecUserUpdUser_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtSecUserUpdUser_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtSecUserUpdUser_Enabled), 5, 0)), true);
         edtSecUserCrtDate_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtSecUserCrtDate_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtSecUserCrtDate_Enabled), 5, 0)), true);
         edtSecUserUpdDate_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtSecUserUpdDate_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtSecUserUpdDate_Enabled), 5, 0)), true);
      }

      protected void send_integrity_lvl_hashes056( )
      {
      }

      protected void assign_properties_default( )
      {
      }

      protected void ConfirmValues050( )
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
         context.AddJavascriptSource("gxcfg.js", "?20202279355743", false);
         if ( context.isSpaRequest( ) )
         {
            enableOutput();
         }
         context.AddJavascriptSource("calendar.js", "?"+context.GetBuildNumber( 127771), false);
         context.AddJavascriptSource("calendar-setup.js", "?"+context.GetBuildNumber( 127771), false);
         context.AddJavascriptSource("calendar-zh.js", "?"+context.GetBuildNumber( 127771), false);
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" autocomplete=\"off\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("wwpbaseobjects.secuser.aspx") + "?" + UrlEncode(StringUtil.RTrim(Gx_mode)) + "," + UrlEncode("" +AV7SecUserId)+"\">") ;
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
         forbiddenHiddens = "hsh" + "SecUser";
         forbiddenHiddens = forbiddenHiddens + context.localUtil.Format( (decimal)(A6SecUserId), "ZZZ9");
         forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!"));
         forbiddenHiddens = forbiddenHiddens + context.localUtil.Format( (decimal)(A194SecUserWorkload), "ZZZZZZZZZ9");
         GxWebStd.gx_hidden_field( context, "hsh", GetEncryptedHash( forbiddenHiddens, GXKey));
         GXUtil.WriteLog("wwpbaseobjects.secuser:[SendSecurityCheck value for]"+"SecUserId:"+context.localUtil.Format( (decimal)(A6SecUserId), "ZZZ9"));
         GXUtil.WriteLog("wwpbaseobjects.secuser:[SendSecurityCheck value for]"+"Gx_mode:"+StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")));
         GXUtil.WriteLog("wwpbaseobjects.secuser:[SendSecurityCheck value for]"+"SecUserWorkload:"+context.localUtil.Format( (decimal)(A194SecUserWorkload), "ZZZZZZZZZ9"));
      }

      protected void SendCloseFormHiddens( )
      {
         /* Send hidden variables. */
         /* Send saved values. */
         send_integrity_footer_hashes( ) ;
         GxWebStd.gx_hidden_field( context, "Z6SecUserId", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z6SecUserId), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "Z178SecUserCrtUser", Z178SecUserCrtUser);
         GxWebStd.gx_hidden_field( context, "Z180SecUserCrtDate", context.localUtil.TToC( Z180SecUserCrtDate, 10, 8, 0, 0, "/", ":", " "));
         GxWebStd.gx_hidden_field( context, "Z14SecUserName", Z14SecUserName);
         GxWebStd.gx_hidden_field( context, "Z15SecUserPassword", Z15SecUserPassword);
         GxWebStd.gx_hidden_field( context, "Z179SecUserUpdUser", Z179SecUserUpdUser);
         GxWebStd.gx_hidden_field( context, "Z181SecUserUpdDate", context.localUtil.TToC( Z181SecUserUpdDate, 10, 8, 0, 0, "/", ":", " "));
         GxWebStd.gx_hidden_field( context, "Z194SecUserWorkload", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z194SecUserWorkload), 10, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "IsConfirmed", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsConfirmed), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "IsModified", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsModified), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "Mode", StringUtil.RTrim( Gx_mode));
         GxWebStd.gx_hidden_field( context, "gxhash_Mode", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vTRNCONTEXT", AV11TrnContext);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vTRNCONTEXT", AV11TrnContext);
         }
         GxWebStd.gx_hidden_field( context, "vSECUSERID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV7SecUserId), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "gxhash_vSECUSERID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV7SecUserId), "ZZZ9"), context));
         GxWebStd.gx_hidden_field( context, "SECUSERWORKLOAD", StringUtil.LTrim( StringUtil.NToC( (decimal)(A194SecUserWorkload), 10, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "vPGMNAME", StringUtil.RTrim( AV17Pgmname));
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
         return formatLink("wwpbaseobjects.secuser.aspx") + "?" + UrlEncode(StringUtil.RTrim(Gx_mode)) + "," + UrlEncode("" +AV7SecUserId) ;
      }

      public override String GetPgmname( )
      {
         return "WWPBaseObjects.SecUser" ;
      }

      public override String GetPgmdesc( )
      {
         return "账号" ;
      }

      protected void InitializeNonKey056( )
      {
         AV16SecUserPassword = "";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV16SecUserPassword", AV16SecUserPassword);
         A178SecUserCrtUser = "";
         n178SecUserCrtUser = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A178SecUserCrtUser", A178SecUserCrtUser);
         n178SecUserCrtUser = (String.IsNullOrEmpty(StringUtil.RTrim( A178SecUserCrtUser)) ? true : false);
         A180SecUserCrtDate = (DateTime)(DateTime.MinValue);
         n180SecUserCrtDate = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A180SecUserCrtDate", context.localUtil.TToC( A180SecUserCrtDate, 8, 5, 0, 0, "/", ":", " "));
         n180SecUserCrtDate = ((DateTime.MinValue==A180SecUserCrtDate) ? true : false);
         A14SecUserName = "";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A14SecUserName", A14SecUserName);
         A15SecUserPassword = "";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A15SecUserPassword", A15SecUserPassword);
         A179SecUserUpdUser = "";
         n179SecUserUpdUser = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A179SecUserUpdUser", A179SecUserUpdUser);
         n179SecUserUpdUser = (String.IsNullOrEmpty(StringUtil.RTrim( A179SecUserUpdUser)) ? true : false);
         A181SecUserUpdDate = (DateTime)(DateTime.MinValue);
         n181SecUserUpdDate = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A181SecUserUpdDate", context.localUtil.TToC( A181SecUserUpdDate, 10, 8, 0, 0, "/", ":", " "));
         n181SecUserUpdDate = ((DateTime.MinValue==A181SecUserUpdDate) ? true : false);
         A194SecUserWorkload = 0;
         n194SecUserWorkload = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A194SecUserWorkload", StringUtil.LTrim( StringUtil.Str( (decimal)(A194SecUserWorkload), 10, 0)));
         Z178SecUserCrtUser = "";
         Z180SecUserCrtDate = (DateTime)(DateTime.MinValue);
         Z14SecUserName = "";
         Z15SecUserPassword = "";
         Z179SecUserUpdUser = "";
         Z181SecUserUpdDate = (DateTime)(DateTime.MinValue);
         Z194SecUserWorkload = 0;
      }

      protected void InitAll056( )
      {
         A6SecUserId = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A6SecUserId", StringUtil.LTrim( StringUtil.Str( (decimal)(A6SecUserId), 4, 0)));
         InitializeNonKey056( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?2020227935587", true);
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
         context.AddJavascriptSource("wwpbaseobjects/secuser.js", "?2020227935588", false);
         context.AddJavascriptSource("DVelop/Bootstrap/Shared/DVelopBootstrap.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/Panel/BootstrapPanelRender.js", "", false);
         /* End function include_jscripts */
      }

      protected void init_default_properties( )
      {
         lblTextblocksecusername_Internalname = "TEXTBLOCKSECUSERNAME";
         edtSecUserName_Internalname = "SECUSERNAME";
         divUnnamedtablesecusername_Internalname = "UNNAMEDTABLESECUSERNAME";
         lblTextblockvsecuserpassword_Internalname = "TEXTBLOCKVSECUSERPASSWORD";
         edtavSecuserpassword_Internalname = "vSECUSERPASSWORD";
         divUnnamedtablevsecuserpassword_Internalname = "UNNAMEDTABLEVSECUSERPASSWORD";
         divTableattributes_Internalname = "TABLEATTRIBUTES";
         divLayout_tableattributes_Internalname = "LAYOUT_TABLEATTRIBUTES";
         Dvpanel_tableattributes_Internalname = "DVPANEL_TABLEATTRIBUTES";
         divHtml_dvpanel_tableattributes_Internalname = "HTML_DVPANEL_TABLEATTRIBUTES";
         divTablecontent_Internalname = "TABLECONTENT";
         bttBtntrn_enter_Internalname = "BTNTRN_ENTER";
         bttBtntrn_cancel_Internalname = "BTNTRN_CANCEL";
         bttBtntrn_delete_Internalname = "BTNTRN_DELETE";
         divTablemain_Internalname = "TABLEMAIN";
         edtSecUserId_Internalname = "SECUSERID";
         edtSecUserPassword_Internalname = "SECUSERPASSWORD";
         edtSecUserCrtUser_Internalname = "SECUSERCRTUSER";
         edtSecUserUpdUser_Internalname = "SECUSERUPDUSER";
         edtSecUserCrtDate_Internalname = "SECUSERCRTDATE";
         edtSecUserUpdDate_Internalname = "SECUSERUPDDATE";
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
         Form.Caption = "账号";
         edtSecUserUpdDate_Jsonclick = "";
         edtSecUserUpdDate_Enabled = 1;
         edtSecUserUpdDate_Visible = 1;
         edtSecUserCrtDate_Jsonclick = "";
         edtSecUserCrtDate_Enabled = 1;
         edtSecUserCrtDate_Visible = 1;
         edtSecUserUpdUser_Jsonclick = "";
         edtSecUserUpdUser_Enabled = 1;
         edtSecUserUpdUser_Visible = 1;
         edtSecUserCrtUser_Jsonclick = "";
         edtSecUserCrtUser_Enabled = 1;
         edtSecUserCrtUser_Visible = 1;
         edtSecUserPassword_Jsonclick = "";
         edtSecUserPassword_Enabled = 1;
         edtSecUserPassword_Visible = 1;
         edtSecUserId_Jsonclick = "";
         edtSecUserId_Enabled = 0;
         edtSecUserId_Visible = 1;
         bttBtntrn_delete_Enabled = 0;
         bttBtntrn_delete_Visible = 1;
         bttBtntrn_cancel_Visible = 1;
         bttBtntrn_enter_Enabled = 1;
         bttBtntrn_enter_Visible = 1;
         edtavSecuserpassword_Jsonclick = "";
         edtavSecuserpassword_Enabled = 1;
         edtSecUserName_Jsonclick = "";
         edtSecUserName_Enabled = 1;
         Dvpanel_tableattributes_Autoscroll = Convert.ToBoolean( 0);
         Dvpanel_tableattributes_Iconposition = "left";
         Dvpanel_tableattributes_Showcollapseicon = Convert.ToBoolean( 0);
         Dvpanel_tableattributes_Collapsed = Convert.ToBoolean( 0);
         Dvpanel_tableattributes_Collapsible = Convert.ToBoolean( 0);
         Dvpanel_tableattributes_Title = "用户信息";
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
         /* End function init_web_controls */
      }

      public override bool SupportAjaxEvent( )
      {
         return true ;
      }

      public override void InitializeDynEvents( )
      {
         setEventMetadata("ENTER","{handler:'UserMainFullajax',iparms:[{postForm:true},{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV7SecUserId',fld:'vSECUSERID',pic:'ZZZ9',hsh:true}]");
         setEventMetadata("ENTER",",oparms:[]}");
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV7SecUserId',fld:'vSECUSERID',pic:'ZZZ9',hsh:true},{av:'A6SecUserId',fld:'SECUSERID',pic:'ZZZ9'},{av:'A194SecUserWorkload',fld:'SECUSERWORKLOAD',pic:'ZZZZZZZZZ9'}]");
         setEventMetadata("REFRESH",",oparms:[]}");
         setEventMetadata("AFTER TRN","{handler:'E12052',iparms:[{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV11TrnContext',fld:'vTRNCONTEXT',pic:''}]");
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
      }

      public override void initialize( )
      {
         sPrefix = "";
         wcpOGx_mode = "";
         Z178SecUserCrtUser = "";
         Z180SecUserCrtDate = (DateTime)(DateTime.MinValue);
         Z14SecUserName = "";
         Z15SecUserPassword = "";
         Z179SecUserUpdUser = "";
         Z181SecUserUpdDate = (DateTime)(DateTime.MinValue);
         scmdbuf = "";
         gxfirstwebparm = "";
         gxfirstwebparm_bkp = "";
         GXKey = "";
         PreviousTooltip = "";
         PreviousCaption = "";
         Form = new GXWebForm();
         GX_FocusControl = "";
         ucDvpanel_tableattributes = new GXUserControl();
         lblTextblocksecusername_Jsonclick = "";
         TempTags = "";
         A14SecUserName = "";
         lblTextblockvsecuserpassword_Jsonclick = "";
         AV16SecUserPassword = "";
         ClassString = "";
         StyleString = "";
         bttBtntrn_enter_Jsonclick = "";
         bttBtntrn_cancel_Jsonclick = "";
         bttBtntrn_delete_Jsonclick = "";
         A15SecUserPassword = "";
         A178SecUserCrtUser = "";
         A179SecUserUpdUser = "";
         A180SecUserCrtDate = (DateTime)(DateTime.MinValue);
         A181SecUserUpdDate = (DateTime)(DateTime.MinValue);
         AV17Pgmname = "";
         Dvpanel_tableattributes_Objectcall = "";
         Dvpanel_tableattributes_Class = "";
         Dvpanel_tableattributes_Height = "";
         forbiddenHiddens = "";
         hsh = "";
         sMode6 = "";
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         AV15WWPContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPContext(context);
         AV11TrnContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext(context);
         AV12WebSession = context.GetSession();
         T00054_A6SecUserId = new short[1] ;
         T00054_A178SecUserCrtUser = new String[] {""} ;
         T00054_n178SecUserCrtUser = new bool[] {false} ;
         T00054_A180SecUserCrtDate = new DateTime[] {DateTime.MinValue} ;
         T00054_n180SecUserCrtDate = new bool[] {false} ;
         T00054_A14SecUserName = new String[] {""} ;
         T00054_A15SecUserPassword = new String[] {""} ;
         T00054_A179SecUserUpdUser = new String[] {""} ;
         T00054_n179SecUserUpdUser = new bool[] {false} ;
         T00054_A181SecUserUpdDate = new DateTime[] {DateTime.MinValue} ;
         T00054_n181SecUserUpdDate = new bool[] {false} ;
         T00054_A194SecUserWorkload = new long[1] ;
         T00054_n194SecUserWorkload = new bool[] {false} ;
         T00055_A6SecUserId = new short[1] ;
         T00053_A6SecUserId = new short[1] ;
         T00053_A178SecUserCrtUser = new String[] {""} ;
         T00053_n178SecUserCrtUser = new bool[] {false} ;
         T00053_A180SecUserCrtDate = new DateTime[] {DateTime.MinValue} ;
         T00053_n180SecUserCrtDate = new bool[] {false} ;
         T00053_A14SecUserName = new String[] {""} ;
         T00053_A15SecUserPassword = new String[] {""} ;
         T00053_A179SecUserUpdUser = new String[] {""} ;
         T00053_n179SecUserUpdUser = new bool[] {false} ;
         T00053_A181SecUserUpdDate = new DateTime[] {DateTime.MinValue} ;
         T00053_n181SecUserUpdDate = new bool[] {false} ;
         T00053_A194SecUserWorkload = new long[1] ;
         T00053_n194SecUserWorkload = new bool[] {false} ;
         T00056_A6SecUserId = new short[1] ;
         T00057_A6SecUserId = new short[1] ;
         T00052_A6SecUserId = new short[1] ;
         T00052_A178SecUserCrtUser = new String[] {""} ;
         T00052_n178SecUserCrtUser = new bool[] {false} ;
         T00052_A180SecUserCrtDate = new DateTime[] {DateTime.MinValue} ;
         T00052_n180SecUserCrtDate = new bool[] {false} ;
         T00052_A14SecUserName = new String[] {""} ;
         T00052_A15SecUserPassword = new String[] {""} ;
         T00052_A179SecUserUpdUser = new String[] {""} ;
         T00052_n179SecUserUpdUser = new bool[] {false} ;
         T00052_A181SecUserUpdDate = new DateTime[] {DateTime.MinValue} ;
         T00052_n181SecUserUpdDate = new bool[] {false} ;
         T00052_A194SecUserWorkload = new long[1] ;
         T00052_n194SecUserWorkload = new bool[] {false} ;
         T00058_A6SecUserId = new short[1] ;
         T000511_A6SecUserId = new short[1] ;
         T000511_A87JC_ProviderID = new long[1] ;
         T000512_A6SecUserId = new short[1] ;
         T000512_A4SecRoleId = new short[1] ;
         T000513_A6SecUserId = new short[1] ;
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         pr_datastore1 = new DataStoreProvider(context, new GeneXus.Programs.wwpbaseobjects.secuser__datastore1(),
            new Object[][] {
            }
         );
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.wwpbaseobjects.secuser__default(),
            new Object[][] {
                new Object[] {
               T00052_A6SecUserId, T00052_A178SecUserCrtUser, T00052_n178SecUserCrtUser, T00052_A180SecUserCrtDate, T00052_n180SecUserCrtDate, T00052_A14SecUserName, T00052_A15SecUserPassword, T00052_A179SecUserUpdUser, T00052_n179SecUserUpdUser, T00052_A181SecUserUpdDate,
               T00052_n181SecUserUpdDate, T00052_A194SecUserWorkload, T00052_n194SecUserWorkload
               }
               , new Object[] {
               T00053_A6SecUserId, T00053_A178SecUserCrtUser, T00053_n178SecUserCrtUser, T00053_A180SecUserCrtDate, T00053_n180SecUserCrtDate, T00053_A14SecUserName, T00053_A15SecUserPassword, T00053_A179SecUserUpdUser, T00053_n179SecUserUpdUser, T00053_A181SecUserUpdDate,
               T00053_n181SecUserUpdDate, T00053_A194SecUserWorkload, T00053_n194SecUserWorkload
               }
               , new Object[] {
               T00054_A6SecUserId, T00054_A178SecUserCrtUser, T00054_n178SecUserCrtUser, T00054_A180SecUserCrtDate, T00054_n180SecUserCrtDate, T00054_A14SecUserName, T00054_A15SecUserPassword, T00054_A179SecUserUpdUser, T00054_n179SecUserUpdUser, T00054_A181SecUserUpdDate,
               T00054_n181SecUserUpdDate, T00054_A194SecUserWorkload, T00054_n194SecUserWorkload
               }
               , new Object[] {
               T00055_A6SecUserId
               }
               , new Object[] {
               T00056_A6SecUserId
               }
               , new Object[] {
               T00057_A6SecUserId
               }
               , new Object[] {
               T00058_A6SecUserId
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               T000511_A6SecUserId, T000511_A87JC_ProviderID
               }
               , new Object[] {
               T000512_A6SecUserId, T000512_A4SecRoleId
               }
               , new Object[] {
               T000513_A6SecUserId
               }
            }
         );
         AV17Pgmname = "WWPBaseObjects.SecUser";
      }

      private short wcpOAV7SecUserId ;
      private short Z6SecUserId ;
      private short GxWebError ;
      private short AV7SecUserId ;
      private short gxcookieaux ;
      private short IsConfirmed ;
      private short IsModified ;
      private short AnyError ;
      private short nKeyPressed ;
      private short initialized ;
      private short A6SecUserId ;
      private short RcdFound6 ;
      private short GX_JID ;
      private short Gx_BScreen ;
      private short gxajaxcallmode ;
      private int trnEnded ;
      private int edtSecUserName_Enabled ;
      private int edtavSecuserpassword_Enabled ;
      private int bttBtntrn_enter_Visible ;
      private int bttBtntrn_enter_Enabled ;
      private int bttBtntrn_cancel_Visible ;
      private int bttBtntrn_delete_Visible ;
      private int bttBtntrn_delete_Enabled ;
      private int edtSecUserId_Enabled ;
      private int edtSecUserId_Visible ;
      private int edtSecUserPassword_Visible ;
      private int edtSecUserPassword_Enabled ;
      private int edtSecUserCrtUser_Visible ;
      private int edtSecUserCrtUser_Enabled ;
      private int edtSecUserUpdUser_Visible ;
      private int edtSecUserUpdUser_Enabled ;
      private int edtSecUserCrtDate_Visible ;
      private int edtSecUserCrtDate_Enabled ;
      private int edtSecUserUpdDate_Visible ;
      private int edtSecUserUpdDate_Enabled ;
      private int idxLst ;
      private long Z194SecUserWorkload ;
      private long A194SecUserWorkload ;
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
      private String edtSecUserName_Internalname ;
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
      private String divUnnamedtablesecusername_Internalname ;
      private String lblTextblocksecusername_Internalname ;
      private String lblTextblocksecusername_Jsonclick ;
      private String TempTags ;
      private String edtSecUserName_Jsonclick ;
      private String divUnnamedtablevsecuserpassword_Internalname ;
      private String lblTextblockvsecuserpassword_Internalname ;
      private String lblTextblockvsecuserpassword_Jsonclick ;
      private String edtavSecuserpassword_Internalname ;
      private String edtavSecuserpassword_Jsonclick ;
      private String ClassString ;
      private String StyleString ;
      private String bttBtntrn_enter_Internalname ;
      private String bttBtntrn_enter_Jsonclick ;
      private String bttBtntrn_cancel_Internalname ;
      private String bttBtntrn_cancel_Jsonclick ;
      private String bttBtntrn_delete_Internalname ;
      private String bttBtntrn_delete_Jsonclick ;
      private String divHtml_bottomauxiliarcontrols_Internalname ;
      private String edtSecUserId_Internalname ;
      private String edtSecUserId_Jsonclick ;
      private String edtSecUserPassword_Internalname ;
      private String edtSecUserPassword_Jsonclick ;
      private String edtSecUserCrtUser_Internalname ;
      private String edtSecUserCrtUser_Jsonclick ;
      private String edtSecUserUpdUser_Internalname ;
      private String edtSecUserUpdUser_Jsonclick ;
      private String edtSecUserCrtDate_Internalname ;
      private String edtSecUserCrtDate_Jsonclick ;
      private String edtSecUserUpdDate_Internalname ;
      private String edtSecUserUpdDate_Jsonclick ;
      private String AV17Pgmname ;
      private String Dvpanel_tableattributes_Objectcall ;
      private String Dvpanel_tableattributes_Class ;
      private String Dvpanel_tableattributes_Height ;
      private String forbiddenHiddens ;
      private String hsh ;
      private String sMode6 ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String sDynURL ;
      private String FormProcess ;
      private String bodyStyle ;
      private DateTime Z180SecUserCrtDate ;
      private DateTime Z181SecUserUpdDate ;
      private DateTime A180SecUserCrtDate ;
      private DateTime A181SecUserUpdDate ;
      private bool entryPointCalled ;
      private bool toggleJsOutput ;
      private bool wbErr ;
      private bool Dvpanel_tableattributes_Autowidth ;
      private bool Dvpanel_tableattributes_Autoheight ;
      private bool Dvpanel_tableattributes_Collapsible ;
      private bool Dvpanel_tableattributes_Collapsed ;
      private bool Dvpanel_tableattributes_Showcollapseicon ;
      private bool Dvpanel_tableattributes_Autoscroll ;
      private bool n178SecUserCrtUser ;
      private bool n179SecUserUpdUser ;
      private bool n180SecUserCrtDate ;
      private bool n181SecUserUpdDate ;
      private bool n194SecUserWorkload ;
      private bool Dvpanel_tableattributes_Enabled ;
      private bool Dvpanel_tableattributes_Showheader ;
      private bool Dvpanel_tableattributes_Visible ;
      private bool AV9IsAuthorized ;
      private bool GXt_boolean1 ;
      private bool returnInSub ;
      private bool Gx_longc ;
      private String Z178SecUserCrtUser ;
      private String Z14SecUserName ;
      private String Z15SecUserPassword ;
      private String Z179SecUserUpdUser ;
      private String A14SecUserName ;
      private String AV16SecUserPassword ;
      private String A15SecUserPassword ;
      private String A178SecUserCrtUser ;
      private String A179SecUserUpdUser ;
      private IGxSession AV12WebSession ;
      private GXUserControl ucDvpanel_tableattributes ;
      private IGxDataStore dsDataStore1 ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private short[] T00054_A6SecUserId ;
      private String[] T00054_A178SecUserCrtUser ;
      private bool[] T00054_n178SecUserCrtUser ;
      private DateTime[] T00054_A180SecUserCrtDate ;
      private bool[] T00054_n180SecUserCrtDate ;
      private String[] T00054_A14SecUserName ;
      private String[] T00054_A15SecUserPassword ;
      private String[] T00054_A179SecUserUpdUser ;
      private bool[] T00054_n179SecUserUpdUser ;
      private DateTime[] T00054_A181SecUserUpdDate ;
      private bool[] T00054_n181SecUserUpdDate ;
      private long[] T00054_A194SecUserWorkload ;
      private bool[] T00054_n194SecUserWorkload ;
      private short[] T00055_A6SecUserId ;
      private short[] T00053_A6SecUserId ;
      private String[] T00053_A178SecUserCrtUser ;
      private bool[] T00053_n178SecUserCrtUser ;
      private DateTime[] T00053_A180SecUserCrtDate ;
      private bool[] T00053_n180SecUserCrtDate ;
      private String[] T00053_A14SecUserName ;
      private String[] T00053_A15SecUserPassword ;
      private String[] T00053_A179SecUserUpdUser ;
      private bool[] T00053_n179SecUserUpdUser ;
      private DateTime[] T00053_A181SecUserUpdDate ;
      private bool[] T00053_n181SecUserUpdDate ;
      private long[] T00053_A194SecUserWorkload ;
      private bool[] T00053_n194SecUserWorkload ;
      private short[] T00056_A6SecUserId ;
      private short[] T00057_A6SecUserId ;
      private short[] T00052_A6SecUserId ;
      private String[] T00052_A178SecUserCrtUser ;
      private bool[] T00052_n178SecUserCrtUser ;
      private DateTime[] T00052_A180SecUserCrtDate ;
      private bool[] T00052_n180SecUserCrtDate ;
      private String[] T00052_A14SecUserName ;
      private String[] T00052_A15SecUserPassword ;
      private String[] T00052_A179SecUserUpdUser ;
      private bool[] T00052_n179SecUserUpdUser ;
      private DateTime[] T00052_A181SecUserUpdDate ;
      private bool[] T00052_n181SecUserUpdDate ;
      private long[] T00052_A194SecUserWorkload ;
      private bool[] T00052_n194SecUserWorkload ;
      private short[] T00058_A6SecUserId ;
      private short[] T000511_A6SecUserId ;
      private long[] T000511_A87JC_ProviderID ;
      private short[] T000512_A6SecUserId ;
      private short[] T000512_A4SecRoleId ;
      private short[] T000513_A6SecUserId ;
      private IDataStoreProvider pr_datastore1 ;
      private GXWebForm Form ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPContext AV15WWPContext ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext AV11TrnContext ;
   }

   public class secuser__datastore1 : DataStoreHelperBase, IDataStoreHelper
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

 public class secuser__default : DataStoreHelperBase, IDataStoreHelper
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
       ,new ForEachCursor(def[9])
       ,new ForEachCursor(def[10])
       ,new ForEachCursor(def[11])
     };
  }

  private static CursorDef[] def;
  private void cursorDefinitions( )
  {
     if ( def == null )
     {
        Object[] prmT00054 ;
        prmT00054 = new Object[] {
        new Object[] {"@SecUserId",SqlDbType.SmallInt,4,0}
        } ;
        Object[] prmT00055 ;
        prmT00055 = new Object[] {
        new Object[] {"@SecUserId",SqlDbType.SmallInt,4,0}
        } ;
        Object[] prmT00053 ;
        prmT00053 = new Object[] {
        new Object[] {"@SecUserId",SqlDbType.SmallInt,4,0}
        } ;
        Object[] prmT00056 ;
        prmT00056 = new Object[] {
        new Object[] {"@SecUserId",SqlDbType.SmallInt,4,0}
        } ;
        Object[] prmT00057 ;
        prmT00057 = new Object[] {
        new Object[] {"@SecUserId",SqlDbType.SmallInt,4,0}
        } ;
        Object[] prmT00052 ;
        prmT00052 = new Object[] {
        new Object[] {"@SecUserId",SqlDbType.SmallInt,4,0}
        } ;
        Object[] prmT00058 ;
        prmT00058 = new Object[] {
        new Object[] {"@SecUserCrtUser",SqlDbType.NVarChar,100,0} ,
        new Object[] {"@SecUserCrtDate",SqlDbType.DateTime,8,5} ,
        new Object[] {"@SecUserName",SqlDbType.NVarChar,100,0} ,
        new Object[] {"@SecUserPassword",SqlDbType.NVarChar,100,0} ,
        new Object[] {"@SecUserUpdUser",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@SecUserUpdDate",SqlDbType.DateTime,10,8} ,
        new Object[] {"@SecUserWorkload",SqlDbType.Decimal,10,0}
        } ;
        Object[] prmT00059 ;
        prmT00059 = new Object[] {
        new Object[] {"@SecUserCrtUser",SqlDbType.NVarChar,100,0} ,
        new Object[] {"@SecUserCrtDate",SqlDbType.DateTime,8,5} ,
        new Object[] {"@SecUserName",SqlDbType.NVarChar,100,0} ,
        new Object[] {"@SecUserPassword",SqlDbType.NVarChar,100,0} ,
        new Object[] {"@SecUserUpdUser",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@SecUserUpdDate",SqlDbType.DateTime,10,8} ,
        new Object[] {"@SecUserWorkload",SqlDbType.Decimal,10,0} ,
        new Object[] {"@SecUserId",SqlDbType.SmallInt,4,0}
        } ;
        Object[] prmT000510 ;
        prmT000510 = new Object[] {
        new Object[] {"@SecUserId",SqlDbType.SmallInt,4,0}
        } ;
        Object[] prmT000511 ;
        prmT000511 = new Object[] {
        new Object[] {"@SecUserId",SqlDbType.SmallInt,4,0}
        } ;
        Object[] prmT000512 ;
        prmT000512 = new Object[] {
        new Object[] {"@SecUserId",SqlDbType.SmallInt,4,0}
        } ;
        Object[] prmT000513 ;
        prmT000513 = new Object[] {
        } ;
        def= new CursorDef[] {
            new CursorDef("T00052", "SELECT [SecUserId], [SecUserCrtUser], [SecUserCrtDate], [SecUserName], [SecUserPassword], [SecUserUpdUser], [SecUserUpdDate], [SecUserWorkload] FROM [SecUser] WITH (UPDLOCK) WHERE [SecUserId] = @SecUserId ",true, GxErrorMask.GX_NOMASK, false, this,prmT00052,1,0,true,false )
           ,new CursorDef("T00053", "SELECT [SecUserId], [SecUserCrtUser], [SecUserCrtDate], [SecUserName], [SecUserPassword], [SecUserUpdUser], [SecUserUpdDate], [SecUserWorkload] FROM [SecUser] WITH (NOLOCK) WHERE [SecUserId] = @SecUserId ",true, GxErrorMask.GX_NOMASK, false, this,prmT00053,1,0,true,false )
           ,new CursorDef("T00054", "SELECT TM1.[SecUserId], TM1.[SecUserCrtUser], TM1.[SecUserCrtDate], TM1.[SecUserName], TM1.[SecUserPassword], TM1.[SecUserUpdUser], TM1.[SecUserUpdDate], TM1.[SecUserWorkload] FROM [SecUser] TM1 WITH (NOLOCK) WHERE TM1.[SecUserId] = @SecUserId ORDER BY TM1.[SecUserId]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT00054,100,0,true,false )
           ,new CursorDef("T00055", "SELECT [SecUserId] FROM [SecUser] WITH (NOLOCK) WHERE [SecUserId] = @SecUserId  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT00055,1,0,true,false )
           ,new CursorDef("T00056", "SELECT TOP 1 [SecUserId] FROM [SecUser] WITH (NOLOCK) WHERE ( [SecUserId] > @SecUserId) ORDER BY [SecUserId]  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT00056,1,0,true,true )
           ,new CursorDef("T00057", "SELECT TOP 1 [SecUserId] FROM [SecUser] WITH (NOLOCK) WHERE ( [SecUserId] < @SecUserId) ORDER BY [SecUserId] DESC  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT00057,1,0,true,true )
           ,new CursorDef("T00058", "INSERT INTO [SecUser]([SecUserCrtUser], [SecUserCrtDate], [SecUserName], [SecUserPassword], [SecUserUpdUser], [SecUserUpdDate], [SecUserWorkload]) VALUES(@SecUserCrtUser, @SecUserCrtDate, @SecUserName, @SecUserPassword, @SecUserUpdUser, @SecUserUpdDate, @SecUserWorkload); SELECT SCOPE_IDENTITY()", GxErrorMask.GX_NOMASK,prmT00058)
           ,new CursorDef("T00059", "UPDATE [SecUser] SET [SecUserCrtUser]=@SecUserCrtUser, [SecUserCrtDate]=@SecUserCrtDate, [SecUserName]=@SecUserName, [SecUserPassword]=@SecUserPassword, [SecUserUpdUser]=@SecUserUpdUser, [SecUserUpdDate]=@SecUserUpdDate, [SecUserWorkload]=@SecUserWorkload  WHERE [SecUserId] = @SecUserId", GxErrorMask.GX_NOMASK,prmT00059)
           ,new CursorDef("T000510", "DELETE FROM [SecUser]  WHERE [SecUserId] = @SecUserId", GxErrorMask.GX_NOMASK,prmT000510)
           ,new CursorDef("T000511", "SELECT TOP 1 [SecUserId], [JC_ProviderID] FROM [JC_ProviderSecUser] WITH (NOLOCK) WHERE [SecUserId] = @SecUserId ",true, GxErrorMask.GX_NOMASK, false, this,prmT000511,1,0,true,true )
           ,new CursorDef("T000512", "SELECT TOP 1 [SecUserId], [SecRoleId] FROM [SecUserRole] WITH (NOLOCK) WHERE [SecUserId] = @SecUserId ",true, GxErrorMask.GX_NOMASK, false, this,prmT000512,1,0,true,true )
           ,new CursorDef("T000513", "SELECT [SecUserId] FROM [SecUser] WITH (NOLOCK) ORDER BY [SecUserId]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT000513,100,0,true,false )
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
              ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
              ((bool[]) buf[2])[0] = rslt.wasNull(2);
              ((DateTime[]) buf[3])[0] = rslt.getGXDateTime(3) ;
              ((bool[]) buf[4])[0] = rslt.wasNull(3);
              ((String[]) buf[5])[0] = rslt.getVarchar(4) ;
              ((String[]) buf[6])[0] = rslt.getVarchar(5) ;
              ((String[]) buf[7])[0] = rslt.getVarchar(6) ;
              ((bool[]) buf[8])[0] = rslt.wasNull(6);
              ((DateTime[]) buf[9])[0] = rslt.getGXDateTime(7) ;
              ((bool[]) buf[10])[0] = rslt.wasNull(7);
              ((long[]) buf[11])[0] = rslt.getLong(8) ;
              ((bool[]) buf[12])[0] = rslt.wasNull(8);
              return;
           case 1 :
              ((short[]) buf[0])[0] = rslt.getShort(1) ;
              ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
              ((bool[]) buf[2])[0] = rslt.wasNull(2);
              ((DateTime[]) buf[3])[0] = rslt.getGXDateTime(3) ;
              ((bool[]) buf[4])[0] = rslt.wasNull(3);
              ((String[]) buf[5])[0] = rslt.getVarchar(4) ;
              ((String[]) buf[6])[0] = rslt.getVarchar(5) ;
              ((String[]) buf[7])[0] = rslt.getVarchar(6) ;
              ((bool[]) buf[8])[0] = rslt.wasNull(6);
              ((DateTime[]) buf[9])[0] = rslt.getGXDateTime(7) ;
              ((bool[]) buf[10])[0] = rslt.wasNull(7);
              ((long[]) buf[11])[0] = rslt.getLong(8) ;
              ((bool[]) buf[12])[0] = rslt.wasNull(8);
              return;
           case 2 :
              ((short[]) buf[0])[0] = rslt.getShort(1) ;
              ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
              ((bool[]) buf[2])[0] = rslt.wasNull(2);
              ((DateTime[]) buf[3])[0] = rslt.getGXDateTime(3) ;
              ((bool[]) buf[4])[0] = rslt.wasNull(3);
              ((String[]) buf[5])[0] = rslt.getVarchar(4) ;
              ((String[]) buf[6])[0] = rslt.getVarchar(5) ;
              ((String[]) buf[7])[0] = rslt.getVarchar(6) ;
              ((bool[]) buf[8])[0] = rslt.wasNull(6);
              ((DateTime[]) buf[9])[0] = rslt.getGXDateTime(7) ;
              ((bool[]) buf[10])[0] = rslt.wasNull(7);
              ((long[]) buf[11])[0] = rslt.getLong(8) ;
              ((bool[]) buf[12])[0] = rslt.wasNull(8);
              return;
           case 3 :
              ((short[]) buf[0])[0] = rslt.getShort(1) ;
              return;
           case 4 :
              ((short[]) buf[0])[0] = rslt.getShort(1) ;
              return;
           case 5 :
              ((short[]) buf[0])[0] = rslt.getShort(1) ;
              return;
           case 6 :
              ((short[]) buf[0])[0] = rslt.getShort(1) ;
              return;
           case 9 :
              ((short[]) buf[0])[0] = rslt.getShort(1) ;
              ((long[]) buf[1])[0] = rslt.getLong(2) ;
              return;
           case 10 :
              ((short[]) buf[0])[0] = rslt.getShort(1) ;
              ((short[]) buf[1])[0] = rslt.getShort(2) ;
              return;
           case 11 :
              ((short[]) buf[0])[0] = rslt.getShort(1) ;
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
              return;
           case 1 :
              stmt.SetParameter(1, (short)parms[0]);
              return;
           case 2 :
              stmt.SetParameter(1, (short)parms[0]);
              return;
           case 3 :
              stmt.SetParameter(1, (short)parms[0]);
              return;
           case 4 :
              stmt.SetParameter(1, (short)parms[0]);
              return;
           case 5 :
              stmt.SetParameter(1, (short)parms[0]);
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
              if ( (bool)parms[2] )
              {
                 stmt.setNull( 2 , SqlDbType.DateTime );
              }
              else
              {
                 stmt.SetParameterDatetime(2, (DateTime)parms[3]);
              }
              stmt.SetParameter(3, (String)parms[4]);
              stmt.SetParameter(4, (String)parms[5]);
              if ( (bool)parms[6] )
              {
                 stmt.setNull( 5 , SqlDbType.NVarChar );
              }
              else
              {
                 stmt.SetParameter(5, (String)parms[7]);
              }
              if ( (bool)parms[8] )
              {
                 stmt.setNull( 6 , SqlDbType.DateTime );
              }
              else
              {
                 stmt.SetParameterDatetime(6, (DateTime)parms[9]);
              }
              if ( (bool)parms[10] )
              {
                 stmt.setNull( 7 , SqlDbType.Decimal );
              }
              else
              {
                 stmt.SetParameter(7, (long)parms[11]);
              }
              return;
           case 7 :
              if ( (bool)parms[0] )
              {
                 stmt.setNull( 1 , SqlDbType.NVarChar );
              }
              else
              {
                 stmt.SetParameter(1, (String)parms[1]);
              }
              if ( (bool)parms[2] )
              {
                 stmt.setNull( 2 , SqlDbType.DateTime );
              }
              else
              {
                 stmt.SetParameterDatetime(2, (DateTime)parms[3]);
              }
              stmt.SetParameter(3, (String)parms[4]);
              stmt.SetParameter(4, (String)parms[5]);
              if ( (bool)parms[6] )
              {
                 stmt.setNull( 5 , SqlDbType.NVarChar );
              }
              else
              {
                 stmt.SetParameter(5, (String)parms[7]);
              }
              if ( (bool)parms[8] )
              {
                 stmt.setNull( 6 , SqlDbType.DateTime );
              }
              else
              {
                 stmt.SetParameterDatetime(6, (DateTime)parms[9]);
              }
              if ( (bool)parms[10] )
              {
                 stmt.setNull( 7 , SqlDbType.Decimal );
              }
              else
              {
                 stmt.SetParameter(7, (long)parms[11]);
              }
              stmt.SetParameter(8, (short)parms[12]);
              return;
           case 8 :
              stmt.SetParameter(1, (short)parms[0]);
              return;
           case 9 :
              stmt.SetParameter(1, (short)parms[0]);
              return;
           case 10 :
              stmt.SetParameter(1, (short)parms[0]);
              return;
     }
  }

}

}
