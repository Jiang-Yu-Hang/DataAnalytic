/*
               File: XT_DefineCode
        Description: 数据字典数据
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/27/2020 11:56:49.92
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
   public class xt_definecode : GXDataArea, System.Web.SessionState.IRequiresSessionState
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
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxJX_Action10") == 0 )
         {
            A168XT_DefineCodeName = GetNextPar( );
            n168XT_DefineCodeName = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A168XT_DefineCodeName", A168XT_DefineCodeName);
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            XC_10_0N24( A168XT_DefineCodeName) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxJX_Action11") == 0 )
         {
            A168XT_DefineCodeName = GetNextPar( );
            n168XT_DefineCodeName = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A168XT_DefineCodeName", A168XT_DefineCodeName);
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            XC_11_0N24( A168XT_DefineCodeName) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxJX_Action12") == 0 )
         {
            A168XT_DefineCodeName = GetNextPar( );
            n168XT_DefineCodeName = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A168XT_DefineCodeName", A168XT_DefineCodeName);
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            XC_12_0N24( A168XT_DefineCodeName) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxExecAct_"+"gxLoad_14") == 0 )
         {
            A165XT_DefindcodeTypeID = (long)(NumberUtil.Val( GetNextPar( ), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A165XT_DefindcodeTypeID", StringUtil.LTrim( StringUtil.Str( (decimal)(A165XT_DefindcodeTypeID), 18, 0)));
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            gxLoad_14( A165XT_DefindcodeTypeID) ;
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
               AV7XT_DefineCodeID = (long)(NumberUtil.Val( GetNextPar( ), "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7XT_DefineCodeID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV7XT_DefineCodeID), 18, 0)));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vXT_DEFINECODEID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV7XT_DefineCodeID), "ZZZZZZZZZZZZZZZZZZ"), context));
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
            Form.Meta.addItem("description", "数据字典数据", 0) ;
         }
         context.wjLoc = "";
         context.nUserReturn = 0;
         context.wbHandled = 0;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         GX_FocusControl = edtXT_DefineCodeName_Internalname;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         wbErr = false;
         context.SetDefaultTheme("WorkWithPlusTheme");
         if ( ! context.IsLocalStorageSupported( ) )
         {
            context.PushCurrentUrl();
         }
      }

      public xt_definecode( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public xt_definecode( IGxContext context )
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
                           long aP1_XT_DefineCodeID )
      {
         this.Gx_mode = aP0_Gx_mode;
         this.AV7XT_DefineCodeID = aP1_XT_DefineCodeID;
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
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtXT_DefineCodeName_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtXT_DefineCodeName_Internalname, "数据字典名称", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 25,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtXT_DefineCodeName_Internalname, A168XT_DefineCodeName, StringUtil.RTrim( context.localUtil.Format( A168XT_DefineCodeName, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,25);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtXT_DefineCodeName_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtXT_DefineCodeName_Enabled, 0, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_XT_DefineCode.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 RequiredDataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtXT_DefindcodeTypeID_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtXT_DefindcodeTypeID_Internalname, "数据字典类型编号", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 30,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtXT_DefindcodeTypeID_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A165XT_DefindcodeTypeID), 18, 0, ".", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(A165XT_DefindcodeTypeID), "ZZZZZZZZZZZZZZZZZZ")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,30);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtXT_DefindcodeTypeID_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtXT_DefindcodeTypeID_Enabled, 1, "number", "1", 18, "chr", 1, "row", 18, 0, 0, 0, 1, -1, 0, true, "ID", "right", false, "HLP_XT_DefineCode.htm");
            /* Static images/pictures */
            ClassString = "gx-prompt Image";
            StyleString = "";
            sImgUrl = (String)(context.GetImagePath( "f5b04895-0024-488b-8e3b-b687ca4598ee", "", context.GetTheme( )));
            GxWebStd.gx_bitmap( context, imgprompt_165_Internalname, sImgUrl, imgprompt_165_Link, "", "", context.GetTheme( ), imgprompt_165_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 0, "", "", StyleString, ClassString, "", "", "", "", "", "", "", 1, false, false, context.GetImageSrcSet( sImgUrl), "HLP_XT_DefineCode.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtXT_DefindcodeTypeName_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtXT_DefindcodeTypeName_Internalname, "数据字典类型名称", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtXT_DefindcodeTypeName_Internalname, A166XT_DefindcodeTypeName, StringUtil.RTrim( context.localUtil.Format( A166XT_DefindcodeTypeName, "")), "", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtXT_DefindcodeTypeName_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtXT_DefindcodeTypeName_Enabled, 0, "text", "", 40, "chr", 1, "row", 40, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_XT_DefineCode.htm");
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
            GxWebStd.gx_button_ctrl( context, bttBtntrn_enter_Internalname, "", "保存", bttBtntrn_enter_Jsonclick, 5, "确认", "", StyleString, ClassString, bttBtntrn_enter_Visible, bttBtntrn_enter_Enabled, "standard", "'"+""+"'"+",false,"+"'"+"EENTER."+"'", TempTags, "", context.GetButtonType( ), "HLP_XT_DefineCode.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 42,'',false,'',0)\"";
            ClassString = "ButtonMaterialDefault";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtntrn_cancel_Internalname, "", "取消", bttBtntrn_cancel_Jsonclick, 1, "取消", "", StyleString, ClassString, bttBtntrn_cancel_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ECANCEL."+"'", TempTags, "", context.GetButtonType( ), "HLP_XT_DefineCode.htm");
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
            GxWebStd.gx_single_line_edit( context, edtXT_DefineCodeID_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A167XT_DefineCodeID), 18, 0, ".", "")), ((edtXT_DefineCodeID_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A167XT_DefineCodeID), "ZZZZZZZZZZZZZZZZZZ")) : context.localUtil.Format( (decimal)(A167XT_DefineCodeID), "ZZZZZZZZZZZZZZZZZZ")), "", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtXT_DefineCodeID_Jsonclick, 0, "Attribute", "", "", "", "", edtXT_DefineCodeID_Visible, edtXT_DefineCodeID_Enabled, 0, "number", "1", 18, "chr", 1, "row", 18, 0, 0, 0, 1, -1, 0, true, "ID", "right", false, "HLP_XT_DefineCode.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 47,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtXT_DefineCodeOrder_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A171XT_DefineCodeOrder), 4, 0, ".", "")), ((edtXT_DefineCodeOrder_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A171XT_DefineCodeOrder), "ZZZZ")) : context.localUtil.Format( (decimal)(A171XT_DefineCodeOrder), "ZZZZ")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,47);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtXT_DefineCodeOrder_Jsonclick, 0, "Attribute", "", "", "", "", edtXT_DefineCodeOrder_Visible, edtXT_DefineCodeOrder_Enabled, 0, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_XT_DefineCode.htm");
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
         E110N2 ();
         context.wbGlbDoneStart = 1;
         assign_properties_default( ) ;
         if ( AnyError == 0 )
         {
            if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
            {
               /* Read saved SDTs. */
               /* Read variables values. */
               A168XT_DefineCodeName = cgiGet( edtXT_DefineCodeName_Internalname);
               n168XT_DefineCodeName = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A168XT_DefineCodeName", A168XT_DefineCodeName);
               n168XT_DefineCodeName = (String.IsNullOrEmpty(StringUtil.RTrim( A168XT_DefineCodeName)) ? true : false);
               if ( ( ( context.localUtil.CToN( cgiGet( edtXT_DefindcodeTypeID_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtXT_DefindcodeTypeID_Internalname), ".", ",") > Convert.ToDecimal( 999999999999999999L )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "XT_DEFINDCODETYPEID");
                  AnyError = 1;
                  GX_FocusControl = edtXT_DefindcodeTypeID_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A165XT_DefindcodeTypeID = 0;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A165XT_DefindcodeTypeID", StringUtil.LTrim( StringUtil.Str( (decimal)(A165XT_DefindcodeTypeID), 18, 0)));
               }
               else
               {
                  A165XT_DefindcodeTypeID = (long)(context.localUtil.CToN( cgiGet( edtXT_DefindcodeTypeID_Internalname), ".", ","));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A165XT_DefindcodeTypeID", StringUtil.LTrim( StringUtil.Str( (decimal)(A165XT_DefindcodeTypeID), 18, 0)));
               }
               A166XT_DefindcodeTypeName = cgiGet( edtXT_DefindcodeTypeName_Internalname);
               n166XT_DefindcodeTypeName = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A166XT_DefindcodeTypeName", A166XT_DefindcodeTypeName);
               A167XT_DefineCodeID = (long)(context.localUtil.CToN( cgiGet( edtXT_DefineCodeID_Internalname), ".", ","));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A167XT_DefineCodeID", StringUtil.LTrim( StringUtil.Str( (decimal)(A167XT_DefineCodeID), 18, 0)));
               if ( ( ( context.localUtil.CToN( cgiGet( edtXT_DefineCodeOrder_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtXT_DefineCodeOrder_Internalname), ".", ",") > Convert.ToDecimal( 9999 )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "XT_DEFINECODEORDER");
                  AnyError = 1;
                  GX_FocusControl = edtXT_DefineCodeOrder_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A171XT_DefineCodeOrder = 0;
                  n171XT_DefineCodeOrder = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A171XT_DefineCodeOrder", StringUtil.LTrim( StringUtil.Str( (decimal)(A171XT_DefineCodeOrder), 4, 0)));
               }
               else
               {
                  A171XT_DefineCodeOrder = (short)(context.localUtil.CToN( cgiGet( edtXT_DefineCodeOrder_Internalname), ".", ","));
                  n171XT_DefineCodeOrder = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A171XT_DefineCodeOrder", StringUtil.LTrim( StringUtil.Str( (decimal)(A171XT_DefineCodeOrder), 4, 0)));
               }
               n171XT_DefineCodeOrder = ((0==A171XT_DefineCodeOrder) ? true : false);
               /* Read saved values. */
               Z167XT_DefineCodeID = (long)(context.localUtil.CToN( cgiGet( "Z167XT_DefineCodeID"), ".", ","));
               Z168XT_DefineCodeName = cgiGet( "Z168XT_DefineCodeName");
               n168XT_DefineCodeName = (String.IsNullOrEmpty(StringUtil.RTrim( A168XT_DefineCodeName)) ? true : false);
               Z171XT_DefineCodeOrder = (short)(context.localUtil.CToN( cgiGet( "Z171XT_DefineCodeOrder"), ".", ","));
               n171XT_DefineCodeOrder = ((0==A171XT_DefineCodeOrder) ? true : false);
               Z431XT_TypeCode = cgiGet( "Z431XT_TypeCode");
               n431XT_TypeCode = (String.IsNullOrEmpty(StringUtil.RTrim( A431XT_TypeCode)) ? true : false);
               Z432XT_TenantCode = cgiGet( "Z432XT_TenantCode");
               n432XT_TenantCode = (String.IsNullOrEmpty(StringUtil.RTrim( A432XT_TenantCode)) ? true : false);
               Z510XT_DefineCodeIntialType = (short)(context.localUtil.CToN( cgiGet( "Z510XT_DefineCodeIntialType"), ".", ","));
               n510XT_DefineCodeIntialType = ((0==A510XT_DefineCodeIntialType) ? true : false);
               Z165XT_DefindcodeTypeID = (long)(context.localUtil.CToN( cgiGet( "Z165XT_DefindcodeTypeID"), ".", ","));
               A431XT_TypeCode = cgiGet( "Z431XT_TypeCode");
               n431XT_TypeCode = false;
               n431XT_TypeCode = (String.IsNullOrEmpty(StringUtil.RTrim( A431XT_TypeCode)) ? true : false);
               A432XT_TenantCode = cgiGet( "Z432XT_TenantCode");
               n432XT_TenantCode = false;
               n432XT_TenantCode = (String.IsNullOrEmpty(StringUtil.RTrim( A432XT_TenantCode)) ? true : false);
               A510XT_DefineCodeIntialType = (short)(context.localUtil.CToN( cgiGet( "Z510XT_DefineCodeIntialType"), ".", ","));
               n510XT_DefineCodeIntialType = false;
               n510XT_DefineCodeIntialType = ((0==A510XT_DefineCodeIntialType) ? true : false);
               IsConfirmed = (short)(context.localUtil.CToN( cgiGet( "IsConfirmed"), ".", ","));
               IsModified = (short)(context.localUtil.CToN( cgiGet( "IsModified"), ".", ","));
               Gx_mode = cgiGet( "Mode");
               N165XT_DefindcodeTypeID = (long)(context.localUtil.CToN( cgiGet( "N165XT_DefindcodeTypeID"), ".", ","));
               AV7XT_DefineCodeID = (long)(context.localUtil.CToN( cgiGet( "vXT_DEFINECODEID"), ".", ","));
               AV13Insert_XT_DefindcodeTypeID = (long)(context.localUtil.CToN( cgiGet( "vINSERT_XT_DEFINDCODETYPEID"), ".", ","));
               A431XT_TypeCode = cgiGet( "XT_TYPECODE");
               n431XT_TypeCode = (String.IsNullOrEmpty(StringUtil.RTrim( A431XT_TypeCode)) ? true : false);
               A432XT_TenantCode = cgiGet( "XT_TENANTCODE");
               n432XT_TenantCode = (String.IsNullOrEmpty(StringUtil.RTrim( A432XT_TenantCode)) ? true : false);
               A510XT_DefineCodeIntialType = (short)(context.localUtil.CToN( cgiGet( "XT_DEFINECODEINTIALTYPE"), ".", ","));
               n510XT_DefineCodeIntialType = ((0==A510XT_DefineCodeIntialType) ? true : false);
               AV15Pgmname = cgiGet( "vPGMNAME");
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
               forbiddenHiddens = "hsh" + "XT_DefineCode";
               A167XT_DefineCodeID = (long)(context.localUtil.CToN( cgiGet( edtXT_DefineCodeID_Internalname), ".", ","));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A167XT_DefineCodeID", StringUtil.LTrim( StringUtil.Str( (decimal)(A167XT_DefineCodeID), 18, 0)));
               forbiddenHiddens = forbiddenHiddens + context.localUtil.Format( (decimal)(A167XT_DefineCodeID), "ZZZZZZZZZZZZZZZZZZ");
               forbiddenHiddens = forbiddenHiddens + context.localUtil.Format( (decimal)(AV13Insert_XT_DefindcodeTypeID), "ZZZZZZZZZZZZZZZZZZ");
               forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!"));
               forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( A431XT_TypeCode, ""));
               forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( A432XT_TenantCode, ""));
               forbiddenHiddens = forbiddenHiddens + context.localUtil.Format( (decimal)(A510XT_DefineCodeIntialType), "ZZZ9");
               hsh = cgiGet( "hsh");
               if ( ( ! ( ( A167XT_DefineCodeID != Z167XT_DefineCodeID ) ) || ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) ) && ! GXUtil.CheckEncryptedHash( forbiddenHiddens, hsh, GXKey) )
               {
                  GXUtil.WriteLog("xt_definecode:[SecurityCheckFailed value for]"+"XT_DefineCodeID:"+context.localUtil.Format( (decimal)(A167XT_DefineCodeID), "ZZZZZZZZZZZZZZZZZZ"));
                  GXUtil.WriteLog("xt_definecode:[SecurityCheckFailed value for]"+"Insert_XT_DefindcodeTypeID:"+context.localUtil.Format( (decimal)(AV13Insert_XT_DefindcodeTypeID), "ZZZZZZZZZZZZZZZZZZ"));
                  GXUtil.WriteLog("xt_definecode:[SecurityCheckFailed value for]"+"Gx_mode:"+StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")));
                  GXUtil.WriteLog("xt_definecode:[SecurityCheckFailed value for]"+"XT_TypeCode:"+StringUtil.RTrim( context.localUtil.Format( A431XT_TypeCode, "")));
                  GXUtil.WriteLog("xt_definecode:[SecurityCheckFailed value for]"+"XT_TenantCode:"+StringUtil.RTrim( context.localUtil.Format( A432XT_TenantCode, "")));
                  GXUtil.WriteLog("xt_definecode:[SecurityCheckFailed value for]"+"XT_DefineCodeIntialType:"+context.localUtil.Format( (decimal)(A510XT_DefineCodeIntialType), "ZZZ9"));
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
                  A167XT_DefineCodeID = (long)(NumberUtil.Val( GetNextPar( ), "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A167XT_DefineCodeID", StringUtil.LTrim( StringUtil.Str( (decimal)(A167XT_DefineCodeID), 18, 0)));
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
                     sMode24 = Gx_mode;
                     Gx_mode = "UPD";
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                     Gx_mode = sMode24;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                  }
                  standaloneModal( ) ;
                  if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
                  {
                     getByPrimaryKey( ) ;
                     if ( RcdFound24 == 1 )
                     {
                        if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
                        {
                           /* Confirm record */
                           CONFIRM_0N0( ) ;
                           if ( AnyError == 0 )
                           {
                              GX_FocusControl = bttBtntrn_enter_Internalname;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                           }
                        }
                     }
                     else
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_noinsert", ""), 1, "XT_DEFINECODEID");
                        AnyError = 1;
                        GX_FocusControl = edtXT_DefineCodeID_Internalname;
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
                           E110N2 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "AFTER TRN") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           /* Execute user event: After Trn */
                           E120N2 ();
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
            E120N2 ();
            trnEnded = 0;
            standaloneNotModal( ) ;
            standaloneModal( ) ;
            if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  )
            {
               /* Clear variables for new insertion. */
               InitAll0N24( ) ;
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
         if ( ( StringUtil.StrCmp(Gx_mode, "DSP") == 0 ) || ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 ) )
         {
            if ( StringUtil.StrCmp(Gx_mode, "DSP") == 0 )
            {
               bttBtntrn_enter_Visible = 0;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtntrn_enter_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtntrn_enter_Visible), 5, 0)), true);
            }
            DisableAttributes0N24( ) ;
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

      protected void CONFIRM_0N0( )
      {
         BeforeValidate0N24( ) ;
         if ( AnyError == 0 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
            {
               OnDeleteControls0N24( ) ;
            }
            else
            {
               CheckExtendedTable0N24( ) ;
               CloseExtendedTableCursors0N24( ) ;
            }
         }
         if ( AnyError == 0 )
         {
            IsConfirmed = 1;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "IsConfirmed", StringUtil.LTrim( StringUtil.Str( (decimal)(IsConfirmed), 4, 0)));
         }
      }

      protected void ResetCaption0N0( )
      {
      }

      protected void E110N2( )
      {
         /* Start Routine */
         new GeneXus.Programs.wwpbaseobjects.loadwwpcontext(context ).execute( out  AV8WWPContext) ;
         AV9IsAuthorized = true;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9IsAuthorized", AV9IsAuthorized);
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            GXt_boolean1 = AV9IsAuthorized;
            new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "Check_DefineCode", out  GXt_boolean1) ;
            AV9IsAuthorized = GXt_boolean1;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9IsAuthorized", AV9IsAuthorized);
         }
         if ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 )
         {
            GXt_boolean1 = AV9IsAuthorized;
            new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "Check_DefineCode", out  GXt_boolean1) ;
            AV9IsAuthorized = GXt_boolean1;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9IsAuthorized", AV9IsAuthorized);
         }
         if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
         {
            GXt_boolean1 = AV9IsAuthorized;
            new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "Check_DefineCode", out  GXt_boolean1) ;
            AV9IsAuthorized = GXt_boolean1;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9IsAuthorized", AV9IsAuthorized);
         }
         if ( ! AV9IsAuthorized )
         {
            CallWebObject(formatLink("wwpbaseobjects.notauthorized.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV15Pgmname)));
            context.wjLocDisableFrm = 1;
         }
         AV11TrnContext.FromXml(AV12WebSession.Get("TrnContext"), null, "WWPTransactionContext", "DataAnalysisPlatform");
         if ( ( StringUtil.StrCmp(AV11TrnContext.gxTpr_Transactionname, AV15Pgmname) == 0 ) && ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) )
         {
            AV16GXV1 = 1;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV16GXV1", StringUtil.LTrim( StringUtil.Str( (decimal)(AV16GXV1), 8, 0)));
            while ( AV16GXV1 <= AV11TrnContext.gxTpr_Attributes.Count )
            {
               AV14TrnContextAtt = ((GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext_Attribute)AV11TrnContext.gxTpr_Attributes.Item(AV16GXV1));
               if ( StringUtil.StrCmp(AV14TrnContextAtt.gxTpr_Attributename, "XT_DefindcodeTypeID") == 0 )
               {
                  AV13Insert_XT_DefindcodeTypeID = (long)(NumberUtil.Val( AV14TrnContextAtt.gxTpr_Attributevalue, "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13Insert_XT_DefindcodeTypeID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13Insert_XT_DefindcodeTypeID), 18, 0)));
               }
               AV16GXV1 = (int)(AV16GXV1+1);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV16GXV1", StringUtil.LTrim( StringUtil.Str( (decimal)(AV16GXV1), 8, 0)));
            }
         }
         edtXT_DefineCodeID_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtXT_DefineCodeID_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtXT_DefineCodeID_Visible), 5, 0)), true);
         edtXT_DefineCodeOrder_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtXT_DefineCodeOrder_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtXT_DefineCodeOrder_Visible), 5, 0)), true);
      }

      protected void E120N2( )
      {
         /* After Trn Routine */
         if ( ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 ) && ! AV11TrnContext.gxTpr_Callerondelete )
         {
            CallWebObject(formatLink("xt_definecodeww.aspx") );
            context.wjLocDisableFrm = 1;
         }
         context.setWebReturnParms(new Object[] {});
         context.setWebReturnParmsMetadata(new Object[] {});
         context.wjLocDisableFrm = 1;
         context.nUserReturn = 1;
         returnInSub = true;
         if (true) return;
      }

      protected void ZM0N24( short GX_JID )
      {
         if ( ( GX_JID == 13 ) || ( GX_JID == 0 ) )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
            {
               Z168XT_DefineCodeName = T000N3_A168XT_DefineCodeName[0];
               Z171XT_DefineCodeOrder = T000N3_A171XT_DefineCodeOrder[0];
               Z431XT_TypeCode = T000N3_A431XT_TypeCode[0];
               Z432XT_TenantCode = T000N3_A432XT_TenantCode[0];
               Z510XT_DefineCodeIntialType = T000N3_A510XT_DefineCodeIntialType[0];
               Z165XT_DefindcodeTypeID = T000N3_A165XT_DefindcodeTypeID[0];
            }
            else
            {
               Z168XT_DefineCodeName = A168XT_DefineCodeName;
               Z171XT_DefineCodeOrder = A171XT_DefineCodeOrder;
               Z431XT_TypeCode = A431XT_TypeCode;
               Z432XT_TenantCode = A432XT_TenantCode;
               Z510XT_DefineCodeIntialType = A510XT_DefineCodeIntialType;
               Z165XT_DefindcodeTypeID = A165XT_DefindcodeTypeID;
            }
         }
         if ( GX_JID == -13 )
         {
            Z167XT_DefineCodeID = A167XT_DefineCodeID;
            Z168XT_DefineCodeName = A168XT_DefineCodeName;
            Z171XT_DefineCodeOrder = A171XT_DefineCodeOrder;
            Z431XT_TypeCode = A431XT_TypeCode;
            Z432XT_TenantCode = A432XT_TenantCode;
            Z510XT_DefineCodeIntialType = A510XT_DefineCodeIntialType;
            Z165XT_DefindcodeTypeID = A165XT_DefindcodeTypeID;
            Z166XT_DefindcodeTypeName = A166XT_DefindcodeTypeName;
         }
      }

      protected void standaloneNotModal( )
      {
         edtXT_DefineCodeID_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtXT_DefineCodeID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtXT_DefineCodeID_Enabled), 5, 0)), true);
         imgprompt_165_Link = ((StringUtil.StrCmp(Gx_mode, "DSP")==0) ? "" : "javascript:"+"gx.popup.openPrompt('"+"xt_defindcodetypeprompt.aspx"+"',["+"{Ctrl:gx.dom.el('"+"XT_DEFINDCODETYPEID"+"'), id:'"+"XT_DEFINDCODETYPEID"+"'"+",IOType:'inout'}"+","+"{Ctrl:gx.dom.el('"+"XT_DEFINDCODETYPENAME"+"'), id:'"+"XT_DEFINDCODETYPENAME"+"'"+",IOType:'inout'}"+"],"+"null"+","+"'', false"+","+"false"+");");
         edtXT_DefineCodeID_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtXT_DefineCodeID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtXT_DefineCodeID_Enabled), 5, 0)), true);
         if ( ! (0==AV7XT_DefineCodeID) )
         {
            A167XT_DefineCodeID = AV7XT_DefineCodeID;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A167XT_DefineCodeID", StringUtil.LTrim( StringUtil.Str( (decimal)(A167XT_DefineCodeID), 18, 0)));
         }
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) && ! (0==AV13Insert_XT_DefindcodeTypeID) )
         {
            edtXT_DefindcodeTypeID_Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtXT_DefindcodeTypeID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtXT_DefindcodeTypeID_Enabled), 5, 0)), true);
         }
         else
         {
            edtXT_DefindcodeTypeID_Enabled = 1;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtXT_DefindcodeTypeID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtXT_DefindcodeTypeID_Enabled), 5, 0)), true);
         }
      }

      protected void standaloneModal( )
      {
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) && ! (0==AV13Insert_XT_DefindcodeTypeID) )
         {
            A165XT_DefindcodeTypeID = AV13Insert_XT_DefindcodeTypeID;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A165XT_DefindcodeTypeID", StringUtil.LTrim( StringUtil.Str( (decimal)(A165XT_DefindcodeTypeID), 18, 0)));
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
            AV15Pgmname = "XT_DefineCode";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV15Pgmname", AV15Pgmname);
            /* Using cursor T000N4 */
            pr_default.execute(2, new Object[] {A165XT_DefindcodeTypeID});
            A166XT_DefindcodeTypeName = T000N4_A166XT_DefindcodeTypeName[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A166XT_DefindcodeTypeName", A166XT_DefindcodeTypeName);
            n166XT_DefindcodeTypeName = T000N4_n166XT_DefindcodeTypeName[0];
            pr_default.close(2);
         }
      }

      protected void Load0N24( )
      {
         /* Using cursor T000N5 */
         pr_default.execute(3, new Object[] {A167XT_DefineCodeID});
         if ( (pr_default.getStatus(3) != 101) )
         {
            RcdFound24 = 1;
            A168XT_DefineCodeName = T000N5_A168XT_DefineCodeName[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A168XT_DefineCodeName", A168XT_DefineCodeName);
            n168XT_DefineCodeName = T000N5_n168XT_DefineCodeName[0];
            A166XT_DefindcodeTypeName = T000N5_A166XT_DefindcodeTypeName[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A166XT_DefindcodeTypeName", A166XT_DefindcodeTypeName);
            n166XT_DefindcodeTypeName = T000N5_n166XT_DefindcodeTypeName[0];
            A171XT_DefineCodeOrder = T000N5_A171XT_DefineCodeOrder[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A171XT_DefineCodeOrder", StringUtil.LTrim( StringUtil.Str( (decimal)(A171XT_DefineCodeOrder), 4, 0)));
            n171XT_DefineCodeOrder = T000N5_n171XT_DefineCodeOrder[0];
            A431XT_TypeCode = T000N5_A431XT_TypeCode[0];
            n431XT_TypeCode = T000N5_n431XT_TypeCode[0];
            A432XT_TenantCode = T000N5_A432XT_TenantCode[0];
            n432XT_TenantCode = T000N5_n432XT_TenantCode[0];
            A510XT_DefineCodeIntialType = T000N5_A510XT_DefineCodeIntialType[0];
            n510XT_DefineCodeIntialType = T000N5_n510XT_DefineCodeIntialType[0];
            A165XT_DefindcodeTypeID = T000N5_A165XT_DefindcodeTypeID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A165XT_DefindcodeTypeID", StringUtil.LTrim( StringUtil.Str( (decimal)(A165XT_DefindcodeTypeID), 18, 0)));
            ZM0N24( -13) ;
         }
         pr_default.close(3);
         OnLoadActions0N24( ) ;
      }

      protected void OnLoadActions0N24( )
      {
         AV15Pgmname = "XT_DefineCode";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV15Pgmname", AV15Pgmname);
      }

      protected void CheckExtendedTable0N24( )
      {
         Gx_BScreen = 1;
         standaloneModal( ) ;
         AV15Pgmname = "XT_DefineCode";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV15Pgmname", AV15Pgmname);
         if ( String.IsNullOrEmpty(StringUtil.RTrim( A168XT_DefineCodeName)) )
         {
            GX_msglist.addItem("数据字典名称是必须填写的。", 1, "XT_DEFINECODENAME");
            AnyError = 1;
            GX_FocusControl = edtXT_DefineCodeName_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         /* Using cursor T000N4 */
         pr_default.execute(2, new Object[] {A165XT_DefindcodeTypeID});
         if ( (pr_default.getStatus(2) == 101) )
         {
            GX_msglist.addItem("不匹配'������������������'", "ForeignKeyNotFound", 1, "XT_DEFINDCODETYPEID");
            AnyError = 1;
            GX_FocusControl = edtXT_DefindcodeTypeID_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         A166XT_DefindcodeTypeName = T000N4_A166XT_DefindcodeTypeName[0];
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A166XT_DefindcodeTypeName", A166XT_DefindcodeTypeName);
         n166XT_DefindcodeTypeName = T000N4_n166XT_DefindcodeTypeName[0];
         pr_default.close(2);
         if ( (0==A165XT_DefindcodeTypeID) )
         {
            GX_msglist.addItem("数据字典类型主键是必须填写的。", 1, "XT_DEFINDCODETYPEID");
            AnyError = 1;
            GX_FocusControl = edtXT_DefindcodeTypeID_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
      }

      protected void CloseExtendedTableCursors0N24( )
      {
         pr_default.close(2);
      }

      protected void enableDisable( )
      {
      }

      protected void gxLoad_14( long A165XT_DefindcodeTypeID )
      {
         /* Using cursor T000N6 */
         pr_default.execute(4, new Object[] {A165XT_DefindcodeTypeID});
         if ( (pr_default.getStatus(4) == 101) )
         {
            GX_msglist.addItem("不匹配'������������������'", "ForeignKeyNotFound", 1, "XT_DEFINDCODETYPEID");
            AnyError = 1;
            GX_FocusControl = edtXT_DefindcodeTypeID_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         A166XT_DefindcodeTypeName = T000N6_A166XT_DefindcodeTypeName[0];
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A166XT_DefindcodeTypeName", A166XT_DefindcodeTypeName);
         n166XT_DefindcodeTypeName = T000N6_n166XT_DefindcodeTypeName[0];
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("[[");
         context.GX_webresponse.AddString("\""+GXUtil.EncodeJSConstant( A166XT_DefindcodeTypeName)+"\"");
         context.GX_webresponse.AddString("]");
         if ( (pr_default.getStatus(4) == 101) )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString("]");
         pr_default.close(4);
      }

      protected void GetKey0N24( )
      {
         /* Using cursor T000N7 */
         pr_default.execute(5, new Object[] {A167XT_DefineCodeID});
         if ( (pr_default.getStatus(5) != 101) )
         {
            RcdFound24 = 1;
         }
         else
         {
            RcdFound24 = 0;
         }
         pr_default.close(5);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor T000N3 */
         pr_default.execute(1, new Object[] {A167XT_DefineCodeID});
         if ( (pr_default.getStatus(1) != 101) )
         {
            ZM0N24( 13) ;
            RcdFound24 = 1;
            A167XT_DefineCodeID = T000N3_A167XT_DefineCodeID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A167XT_DefineCodeID", StringUtil.LTrim( StringUtil.Str( (decimal)(A167XT_DefineCodeID), 18, 0)));
            A168XT_DefineCodeName = T000N3_A168XT_DefineCodeName[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A168XT_DefineCodeName", A168XT_DefineCodeName);
            n168XT_DefineCodeName = T000N3_n168XT_DefineCodeName[0];
            A171XT_DefineCodeOrder = T000N3_A171XT_DefineCodeOrder[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A171XT_DefineCodeOrder", StringUtil.LTrim( StringUtil.Str( (decimal)(A171XT_DefineCodeOrder), 4, 0)));
            n171XT_DefineCodeOrder = T000N3_n171XT_DefineCodeOrder[0];
            A431XT_TypeCode = T000N3_A431XT_TypeCode[0];
            n431XT_TypeCode = T000N3_n431XT_TypeCode[0];
            A432XT_TenantCode = T000N3_A432XT_TenantCode[0];
            n432XT_TenantCode = T000N3_n432XT_TenantCode[0];
            A510XT_DefineCodeIntialType = T000N3_A510XT_DefineCodeIntialType[0];
            n510XT_DefineCodeIntialType = T000N3_n510XT_DefineCodeIntialType[0];
            A165XT_DefindcodeTypeID = T000N3_A165XT_DefindcodeTypeID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A165XT_DefindcodeTypeID", StringUtil.LTrim( StringUtil.Str( (decimal)(A165XT_DefindcodeTypeID), 18, 0)));
            Z167XT_DefineCodeID = A167XT_DefineCodeID;
            sMode24 = Gx_mode;
            Gx_mode = "DSP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
            Load0N24( ) ;
            if ( AnyError == 1 )
            {
               RcdFound24 = 0;
               InitializeNonKey0N24( ) ;
            }
            Gx_mode = sMode24;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         }
         else
         {
            RcdFound24 = 0;
            InitializeNonKey0N24( ) ;
            sMode24 = Gx_mode;
            Gx_mode = "DSP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
            standaloneModal( ) ;
            Gx_mode = sMode24;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         }
         pr_default.close(1);
      }

      protected void getEqualNoModal( )
      {
         GetKey0N24( ) ;
         if ( RcdFound24 == 0 )
         {
         }
         else
         {
         }
         getByPrimaryKey( ) ;
      }

      protected void move_next( )
      {
         RcdFound24 = 0;
         /* Using cursor T000N8 */
         pr_default.execute(6, new Object[] {A167XT_DefineCodeID});
         if ( (pr_default.getStatus(6) != 101) )
         {
            while ( (pr_default.getStatus(6) != 101) && ( ( T000N8_A167XT_DefineCodeID[0] < A167XT_DefineCodeID ) ) )
            {
               pr_default.readNext(6);
            }
            if ( (pr_default.getStatus(6) != 101) && ( ( T000N8_A167XT_DefineCodeID[0] > A167XT_DefineCodeID ) ) )
            {
               A167XT_DefineCodeID = T000N8_A167XT_DefineCodeID[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A167XT_DefineCodeID", StringUtil.LTrim( StringUtil.Str( (decimal)(A167XT_DefineCodeID), 18, 0)));
               RcdFound24 = 1;
            }
         }
         pr_default.close(6);
      }

      protected void move_previous( )
      {
         RcdFound24 = 0;
         /* Using cursor T000N9 */
         pr_default.execute(7, new Object[] {A167XT_DefineCodeID});
         if ( (pr_default.getStatus(7) != 101) )
         {
            while ( (pr_default.getStatus(7) != 101) && ( ( T000N9_A167XT_DefineCodeID[0] > A167XT_DefineCodeID ) ) )
            {
               pr_default.readNext(7);
            }
            if ( (pr_default.getStatus(7) != 101) && ( ( T000N9_A167XT_DefineCodeID[0] < A167XT_DefineCodeID ) ) )
            {
               A167XT_DefineCodeID = T000N9_A167XT_DefineCodeID[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A167XT_DefineCodeID", StringUtil.LTrim( StringUtil.Str( (decimal)(A167XT_DefineCodeID), 18, 0)));
               RcdFound24 = 1;
            }
         }
         pr_default.close(7);
      }

      protected void btn_enter( )
      {
         nKeyPressed = 1;
         GetKey0N24( ) ;
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            /* Insert record */
            GX_FocusControl = edtXT_DefineCodeName_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            Insert0N24( ) ;
            if ( AnyError == 1 )
            {
               GX_FocusControl = "";
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
         }
         else
         {
            if ( RcdFound24 == 1 )
            {
               if ( A167XT_DefineCodeID != Z167XT_DefineCodeID )
               {
                  A167XT_DefineCodeID = Z167XT_DefineCodeID;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A167XT_DefineCodeID", StringUtil.LTrim( StringUtil.Str( (decimal)(A167XT_DefineCodeID), 18, 0)));
                  GX_msglist.addItem(context.GetMessage( "GXM_getbeforeupd", ""), "CandidateKeyNotFound", 1, "XT_DEFINECODEID");
                  AnyError = 1;
                  GX_FocusControl = edtXT_DefineCodeID_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
               else if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
               {
                  delete( ) ;
                  AfterTrn( ) ;
                  GX_FocusControl = edtXT_DefineCodeName_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
               else
               {
                  /* Update record */
                  Update0N24( ) ;
                  GX_FocusControl = edtXT_DefineCodeName_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
            }
            else
            {
               if ( A167XT_DefineCodeID != Z167XT_DefineCodeID )
               {
                  /* Insert record */
                  GX_FocusControl = edtXT_DefineCodeName_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  Insert0N24( ) ;
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
                     GX_msglist.addItem(context.GetMessage( "GXM_recdeleted", ""), 1, "XT_DEFINECODEID");
                     AnyError = 1;
                     GX_FocusControl = edtXT_DefineCodeID_Internalname;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  }
                  else
                  {
                     /* Insert record */
                     GX_FocusControl = edtXT_DefineCodeName_Internalname;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                     Insert0N24( ) ;
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
         if ( A167XT_DefineCodeID != Z167XT_DefineCodeID )
         {
            A167XT_DefineCodeID = Z167XT_DefineCodeID;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A167XT_DefineCodeID", StringUtil.LTrim( StringUtil.Str( (decimal)(A167XT_DefineCodeID), 18, 0)));
            GX_msglist.addItem(context.GetMessage( "GXM_getbeforedlt", ""), 1, "XT_DEFINECODEID");
            AnyError = 1;
            GX_FocusControl = edtXT_DefineCodeID_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         else
         {
            delete( ) ;
            AfterTrn( ) ;
            GX_FocusControl = edtXT_DefineCodeName_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( AnyError != 0 )
         {
         }
      }

      protected void CheckOptimisticConcurrency0N24( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor T000N2 */
            pr_default.execute(0, new Object[] {A167XT_DefineCodeID});
            if ( (pr_default.getStatus(0) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"XT_DefineCode"}), "RecordIsLocked", 1, "");
               AnyError = 1;
               return  ;
            }
            Gx_longc = false;
            if ( (pr_default.getStatus(0) == 101) || ( StringUtil.StrCmp(Z168XT_DefineCodeName, T000N2_A168XT_DefineCodeName[0]) != 0 ) || ( Z171XT_DefineCodeOrder != T000N2_A171XT_DefineCodeOrder[0] ) || ( StringUtil.StrCmp(Z431XT_TypeCode, T000N2_A431XT_TypeCode[0]) != 0 ) || ( StringUtil.StrCmp(Z432XT_TenantCode, T000N2_A432XT_TenantCode[0]) != 0 ) || ( Z510XT_DefineCodeIntialType != T000N2_A510XT_DefineCodeIntialType[0] ) )
            {
               Gx_longc = true;
            }
            if ( Gx_longc || ( Z165XT_DefindcodeTypeID != T000N2_A165XT_DefindcodeTypeID[0] ) )
            {
               if ( StringUtil.StrCmp(Z168XT_DefineCodeName, T000N2_A168XT_DefineCodeName[0]) != 0 )
               {
                  GXUtil.WriteLog("xt_definecode:[seudo value changed for attri]"+"XT_DefineCodeName");
                  GXUtil.WriteLogRaw("Old: ",Z168XT_DefineCodeName);
                  GXUtil.WriteLogRaw("Current: ",T000N2_A168XT_DefineCodeName[0]);
               }
               if ( Z171XT_DefineCodeOrder != T000N2_A171XT_DefineCodeOrder[0] )
               {
                  GXUtil.WriteLog("xt_definecode:[seudo value changed for attri]"+"XT_DefineCodeOrder");
                  GXUtil.WriteLogRaw("Old: ",Z171XT_DefineCodeOrder);
                  GXUtil.WriteLogRaw("Current: ",T000N2_A171XT_DefineCodeOrder[0]);
               }
               if ( StringUtil.StrCmp(Z431XT_TypeCode, T000N2_A431XT_TypeCode[0]) != 0 )
               {
                  GXUtil.WriteLog("xt_definecode:[seudo value changed for attri]"+"XT_TypeCode");
                  GXUtil.WriteLogRaw("Old: ",Z431XT_TypeCode);
                  GXUtil.WriteLogRaw("Current: ",T000N2_A431XT_TypeCode[0]);
               }
               if ( StringUtil.StrCmp(Z432XT_TenantCode, T000N2_A432XT_TenantCode[0]) != 0 )
               {
                  GXUtil.WriteLog("xt_definecode:[seudo value changed for attri]"+"XT_TenantCode");
                  GXUtil.WriteLogRaw("Old: ",Z432XT_TenantCode);
                  GXUtil.WriteLogRaw("Current: ",T000N2_A432XT_TenantCode[0]);
               }
               if ( Z510XT_DefineCodeIntialType != T000N2_A510XT_DefineCodeIntialType[0] )
               {
                  GXUtil.WriteLog("xt_definecode:[seudo value changed for attri]"+"XT_DefineCodeIntialType");
                  GXUtil.WriteLogRaw("Old: ",Z510XT_DefineCodeIntialType);
                  GXUtil.WriteLogRaw("Current: ",T000N2_A510XT_DefineCodeIntialType[0]);
               }
               if ( Z165XT_DefindcodeTypeID != T000N2_A165XT_DefindcodeTypeID[0] )
               {
                  GXUtil.WriteLog("xt_definecode:[seudo value changed for attri]"+"XT_DefindcodeTypeID");
                  GXUtil.WriteLogRaw("Old: ",Z165XT_DefindcodeTypeID);
                  GXUtil.WriteLogRaw("Current: ",T000N2_A165XT_DefindcodeTypeID[0]);
               }
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"XT_DefineCode"}), "RecordWasChanged", 1, "");
               AnyError = 1;
               return  ;
            }
         }
      }

      protected void Insert0N24( )
      {
         BeforeValidate0N24( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0N24( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM0N24( 0) ;
            CheckOptimisticConcurrency0N24( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0N24( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert0N24( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000N10 */
                     pr_default.execute(8, new Object[] {n168XT_DefineCodeName, A168XT_DefineCodeName, n171XT_DefineCodeOrder, A171XT_DefineCodeOrder, n431XT_TypeCode, A431XT_TypeCode, n432XT_TenantCode, A432XT_TenantCode, n510XT_DefineCodeIntialType, A510XT_DefineCodeIntialType, A165XT_DefindcodeTypeID});
                     A167XT_DefineCodeID = T000N10_A167XT_DefineCodeID[0];
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A167XT_DefineCodeID", StringUtil.LTrim( StringUtil.Str( (decimal)(A167XT_DefineCodeID), 18, 0)));
                     pr_default.close(8);
                     dsDefault.SmartCacheProvider.SetUpdated("XT_DefineCode") ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( Insert) rules */
                        new zutil_recordlog(context ).execute(  A168XT_DefineCodeName,  "数据字典信息",  "Create",  1) ;
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A168XT_DefineCodeName", A168XT_DefineCodeName);
                        /* End of After( Insert) rules */
                        if ( AnyError == 0 )
                        {
                           /* Save values for previous() function. */
                           GX_msglist.addItem(context.GetMessage( "GXM_sucadded", ""), "SuccessfullyAdded", 0, "", true);
                           ResetCaption0N0( ) ;
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
               Load0N24( ) ;
            }
            EndLevel0N24( ) ;
         }
         CloseExtendedTableCursors0N24( ) ;
      }

      protected void Update0N24( )
      {
         BeforeValidate0N24( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0N24( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0N24( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0N24( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate0N24( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000N11 */
                     pr_default.execute(9, new Object[] {n168XT_DefineCodeName, A168XT_DefineCodeName, n171XT_DefineCodeOrder, A171XT_DefineCodeOrder, n431XT_TypeCode, A431XT_TypeCode, n432XT_TenantCode, A432XT_TenantCode, n510XT_DefineCodeIntialType, A510XT_DefineCodeIntialType, A165XT_DefindcodeTypeID, A167XT_DefineCodeID});
                     pr_default.close(9);
                     dsDefault.SmartCacheProvider.SetUpdated("XT_DefineCode") ;
                     if ( (pr_default.getStatus(9) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"XT_DefineCode"}), "RecordIsLocked", 1, "");
                        AnyError = 1;
                     }
                     DeferredUpdate0N24( ) ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( update) rules */
                        new zutil_recordlog(context ).execute(  A168XT_DefineCodeName,  "数据字典信息",  "Update",  1) ;
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A168XT_DefineCodeName", A168XT_DefineCodeName);
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
            EndLevel0N24( ) ;
         }
         CloseExtendedTableCursors0N24( ) ;
      }

      protected void DeferredUpdate0N24( )
      {
      }

      protected void delete( )
      {
         BeforeValidate0N24( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0N24( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls0N24( ) ;
            AfterConfirm0N24( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete0N24( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor T000N12 */
                  pr_default.execute(10, new Object[] {A167XT_DefineCodeID});
                  pr_default.close(10);
                  dsDefault.SmartCacheProvider.SetUpdated("XT_DefineCode") ;
                  if ( AnyError == 0 )
                  {
                     /* Start of After( delete) rules */
                     new zutil_recordlog(context ).execute(  A168XT_DefineCodeName,  "数据字典信息",  "Delete",  1) ;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A168XT_DefineCodeName", A168XT_DefineCodeName);
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
         sMode24 = Gx_mode;
         Gx_mode = "DLT";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         EndLevel0N24( ) ;
         Gx_mode = sMode24;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
      }

      protected void OnDeleteControls0N24( )
      {
         standaloneModal( ) ;
         if ( AnyError == 0 )
         {
            /* Delete mode formulas */
            AV15Pgmname = "XT_DefineCode";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV15Pgmname", AV15Pgmname);
            /* Using cursor T000N13 */
            pr_default.execute(11, new Object[] {A165XT_DefindcodeTypeID});
            A166XT_DefindcodeTypeName = T000N13_A166XT_DefindcodeTypeName[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A166XT_DefindcodeTypeName", A166XT_DefindcodeTypeName);
            n166XT_DefindcodeTypeName = T000N13_n166XT_DefindcodeTypeName[0];
            pr_default.close(11);
         }
      }

      protected void EndLevel0N24( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            pr_default.close(0);
         }
         if ( AnyError == 0 )
         {
            BeforeComplete0N24( ) ;
         }
         if ( AnyError == 0 )
         {
            pr_default.close(1);
            pr_default.close(11);
            context.CommitDataStores("xt_definecode",pr_default);
            if ( AnyError == 0 )
            {
               ConfirmValues0N0( ) ;
            }
            /* After transaction rules */
            /* Execute 'After Trn' event if defined. */
            trnEnded = 1;
         }
         else
         {
            pr_default.close(1);
            pr_default.close(11);
            context.RollbackDataStores("xt_definecode",pr_default);
         }
         IsModified = 0;
         if ( AnyError != 0 )
         {
            context.wjLoc = "";
            context.nUserReturn = 0;
         }
      }

      public void ScanStart0N24( )
      {
         /* Scan By routine */
         /* Using cursor T000N14 */
         pr_default.execute(12);
         RcdFound24 = 0;
         if ( (pr_default.getStatus(12) != 101) )
         {
            RcdFound24 = 1;
            A167XT_DefineCodeID = T000N14_A167XT_DefineCodeID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A167XT_DefineCodeID", StringUtil.LTrim( StringUtil.Str( (decimal)(A167XT_DefineCodeID), 18, 0)));
         }
         /* Load Subordinate Levels */
      }

      protected void ScanNext0N24( )
      {
         /* Scan next routine */
         pr_default.readNext(12);
         RcdFound24 = 0;
         if ( (pr_default.getStatus(12) != 101) )
         {
            RcdFound24 = 1;
            A167XT_DefineCodeID = T000N14_A167XT_DefineCodeID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A167XT_DefineCodeID", StringUtil.LTrim( StringUtil.Str( (decimal)(A167XT_DefineCodeID), 18, 0)));
         }
      }

      protected void ScanEnd0N24( )
      {
         pr_default.close(12);
      }

      protected void AfterConfirm0N24( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert0N24( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate0N24( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete0N24( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete0N24( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate0N24( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes0N24( )
      {
         edtXT_DefineCodeName_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtXT_DefineCodeName_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtXT_DefineCodeName_Enabled), 5, 0)), true);
         edtXT_DefindcodeTypeID_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtXT_DefindcodeTypeID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtXT_DefindcodeTypeID_Enabled), 5, 0)), true);
         edtXT_DefindcodeTypeName_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtXT_DefindcodeTypeName_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtXT_DefindcodeTypeName_Enabled), 5, 0)), true);
         edtXT_DefineCodeID_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtXT_DefineCodeID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtXT_DefineCodeID_Enabled), 5, 0)), true);
         edtXT_DefineCodeOrder_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtXT_DefineCodeOrder_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtXT_DefineCodeOrder_Enabled), 5, 0)), true);
      }

      protected void send_integrity_lvl_hashes0N24( )
      {
      }

      protected void assign_properties_default( )
      {
      }

      protected void ConfirmValues0N0( )
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
         context.AddJavascriptSource("gxcfg.js", "?20202271156526", false);
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" autocomplete=\"off\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("xt_definecode.aspx") + "?" + UrlEncode(StringUtil.RTrim(Gx_mode)) + "," + UrlEncode("" +AV7XT_DefineCodeID)+"\">") ;
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
         forbiddenHiddens = "hsh" + "XT_DefineCode";
         forbiddenHiddens = forbiddenHiddens + context.localUtil.Format( (decimal)(A167XT_DefineCodeID), "ZZZZZZZZZZZZZZZZZZ");
         forbiddenHiddens = forbiddenHiddens + context.localUtil.Format( (decimal)(AV13Insert_XT_DefindcodeTypeID), "ZZZZZZZZZZZZZZZZZZ");
         forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!"));
         forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( A431XT_TypeCode, ""));
         forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( A432XT_TenantCode, ""));
         forbiddenHiddens = forbiddenHiddens + context.localUtil.Format( (decimal)(A510XT_DefineCodeIntialType), "ZZZ9");
         GxWebStd.gx_hidden_field( context, "hsh", GetEncryptedHash( forbiddenHiddens, GXKey));
         GXUtil.WriteLog("xt_definecode:[SendSecurityCheck value for]"+"XT_DefineCodeID:"+context.localUtil.Format( (decimal)(A167XT_DefineCodeID), "ZZZZZZZZZZZZZZZZZZ"));
         GXUtil.WriteLog("xt_definecode:[SendSecurityCheck value for]"+"Insert_XT_DefindcodeTypeID:"+context.localUtil.Format( (decimal)(AV13Insert_XT_DefindcodeTypeID), "ZZZZZZZZZZZZZZZZZZ"));
         GXUtil.WriteLog("xt_definecode:[SendSecurityCheck value for]"+"Gx_mode:"+StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")));
         GXUtil.WriteLog("xt_definecode:[SendSecurityCheck value for]"+"XT_TypeCode:"+StringUtil.RTrim( context.localUtil.Format( A431XT_TypeCode, "")));
         GXUtil.WriteLog("xt_definecode:[SendSecurityCheck value for]"+"XT_TenantCode:"+StringUtil.RTrim( context.localUtil.Format( A432XT_TenantCode, "")));
         GXUtil.WriteLog("xt_definecode:[SendSecurityCheck value for]"+"XT_DefineCodeIntialType:"+context.localUtil.Format( (decimal)(A510XT_DefineCodeIntialType), "ZZZ9"));
      }

      protected void SendCloseFormHiddens( )
      {
         /* Send hidden variables. */
         /* Send saved values. */
         send_integrity_footer_hashes( ) ;
         GxWebStd.gx_hidden_field( context, "Z167XT_DefineCodeID", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z167XT_DefineCodeID), 18, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "Z168XT_DefineCodeName", Z168XT_DefineCodeName);
         GxWebStd.gx_hidden_field( context, "Z171XT_DefineCodeOrder", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z171XT_DefineCodeOrder), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "Z431XT_TypeCode", Z431XT_TypeCode);
         GxWebStd.gx_hidden_field( context, "Z432XT_TenantCode", Z432XT_TenantCode);
         GxWebStd.gx_hidden_field( context, "Z510XT_DefineCodeIntialType", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z510XT_DefineCodeIntialType), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "Z165XT_DefindcodeTypeID", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z165XT_DefindcodeTypeID), 18, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "IsConfirmed", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsConfirmed), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "IsModified", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsModified), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "Mode", StringUtil.RTrim( Gx_mode));
         GxWebStd.gx_hidden_field( context, "gxhash_Mode", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         GxWebStd.gx_hidden_field( context, "N165XT_DefindcodeTypeID", StringUtil.LTrim( StringUtil.NToC( (decimal)(A165XT_DefindcodeTypeID), 18, 0, ".", "")));
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vTRNCONTEXT", AV11TrnContext);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vTRNCONTEXT", AV11TrnContext);
         }
         GxWebStd.gx_hidden_field( context, "vXT_DEFINECODEID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV7XT_DefineCodeID), 18, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "gxhash_vXT_DEFINECODEID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV7XT_DefineCodeID), "ZZZZZZZZZZZZZZZZZZ"), context));
         GxWebStd.gx_hidden_field( context, "vINSERT_XT_DEFINDCODETYPEID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV13Insert_XT_DefindcodeTypeID), 18, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "XT_TYPECODE", A431XT_TypeCode);
         GxWebStd.gx_hidden_field( context, "XT_TENANTCODE", A432XT_TenantCode);
         GxWebStd.gx_hidden_field( context, "XT_DEFINECODEINTIALTYPE", StringUtil.LTrim( StringUtil.NToC( (decimal)(A510XT_DefineCodeIntialType), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "vPGMNAME", StringUtil.RTrim( AV15Pgmname));
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
         return formatLink("xt_definecode.aspx") + "?" + UrlEncode(StringUtil.RTrim(Gx_mode)) + "," + UrlEncode("" +AV7XT_DefineCodeID) ;
      }

      public override String GetPgmname( )
      {
         return "XT_DefineCode" ;
      }

      public override String GetPgmdesc( )
      {
         return "数据字典数据" ;
      }

      protected void InitializeNonKey0N24( )
      {
         A165XT_DefindcodeTypeID = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A165XT_DefindcodeTypeID", StringUtil.LTrim( StringUtil.Str( (decimal)(A165XT_DefindcodeTypeID), 18, 0)));
         A168XT_DefineCodeName = "";
         n168XT_DefineCodeName = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A168XT_DefineCodeName", A168XT_DefineCodeName);
         n168XT_DefineCodeName = (String.IsNullOrEmpty(StringUtil.RTrim( A168XT_DefineCodeName)) ? true : false);
         A166XT_DefindcodeTypeName = "";
         n166XT_DefindcodeTypeName = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A166XT_DefindcodeTypeName", A166XT_DefindcodeTypeName);
         A171XT_DefineCodeOrder = 0;
         n171XT_DefineCodeOrder = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A171XT_DefineCodeOrder", StringUtil.LTrim( StringUtil.Str( (decimal)(A171XT_DefineCodeOrder), 4, 0)));
         n171XT_DefineCodeOrder = ((0==A171XT_DefineCodeOrder) ? true : false);
         A431XT_TypeCode = "";
         n431XT_TypeCode = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A431XT_TypeCode", A431XT_TypeCode);
         A432XT_TenantCode = "";
         n432XT_TenantCode = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A432XT_TenantCode", A432XT_TenantCode);
         A510XT_DefineCodeIntialType = 0;
         n510XT_DefineCodeIntialType = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A510XT_DefineCodeIntialType", StringUtil.LTrim( StringUtil.Str( (decimal)(A510XT_DefineCodeIntialType), 4, 0)));
         Z168XT_DefineCodeName = "";
         Z171XT_DefineCodeOrder = 0;
         Z431XT_TypeCode = "";
         Z432XT_TenantCode = "";
         Z510XT_DefineCodeIntialType = 0;
         Z165XT_DefindcodeTypeID = 0;
      }

      protected void InitAll0N24( )
      {
         A167XT_DefineCodeID = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A167XT_DefineCodeID", StringUtil.LTrim( StringUtil.Str( (decimal)(A167XT_DefineCodeID), 18, 0)));
         InitializeNonKey0N24( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?202022711565241", true);
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
         context.AddJavascriptSource("xt_definecode.js", "?202022711565242", false);
         context.AddJavascriptSource("DVelop/Bootstrap/Shared/DVelopBootstrap.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/Panel/BootstrapPanelRender.js", "", false);
         /* End function include_jscripts */
      }

      protected void init_default_properties( )
      {
         edtXT_DefineCodeName_Internalname = "XT_DEFINECODENAME";
         edtXT_DefindcodeTypeID_Internalname = "XT_DEFINDCODETYPEID";
         edtXT_DefindcodeTypeName_Internalname = "XT_DEFINDCODETYPENAME";
         divTableattributes_Internalname = "TABLEATTRIBUTES";
         divLayout_tableattributes_Internalname = "LAYOUT_TABLEATTRIBUTES";
         Dvpanel_tableattributes_Internalname = "DVPANEL_TABLEATTRIBUTES";
         divHtml_dvpanel_tableattributes_Internalname = "HTML_DVPANEL_TABLEATTRIBUTES";
         divTablecontent_Internalname = "TABLECONTENT";
         bttBtntrn_enter_Internalname = "BTNTRN_ENTER";
         bttBtntrn_cancel_Internalname = "BTNTRN_CANCEL";
         divTablemain_Internalname = "TABLEMAIN";
         edtXT_DefineCodeID_Internalname = "XT_DEFINECODEID";
         edtXT_DefineCodeOrder_Internalname = "XT_DEFINECODEORDER";
         divHtml_bottomauxiliarcontrols_Internalname = "HTML_BOTTOMAUXILIARCONTROLS";
         divLayoutmaintable_Internalname = "LAYOUTMAINTABLE";
         Form.Internalname = "FORM";
         imgprompt_165_Internalname = "PROMPT_165";
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
         Form.Caption = "数据字典数据";
         edtXT_DefineCodeOrder_Jsonclick = "";
         edtXT_DefineCodeOrder_Enabled = 1;
         edtXT_DefineCodeOrder_Visible = 1;
         edtXT_DefineCodeID_Jsonclick = "";
         edtXT_DefineCodeID_Enabled = 0;
         edtXT_DefineCodeID_Visible = 1;
         bttBtntrn_cancel_Visible = 1;
         bttBtntrn_enter_Enabled = 1;
         bttBtntrn_enter_Visible = 1;
         edtXT_DefindcodeTypeName_Jsonclick = "";
         edtXT_DefindcodeTypeName_Enabled = 0;
         imgprompt_165_Visible = 1;
         imgprompt_165_Link = "";
         edtXT_DefindcodeTypeID_Jsonclick = "";
         edtXT_DefindcodeTypeID_Enabled = 1;
         edtXT_DefineCodeName_Jsonclick = "";
         edtXT_DefineCodeName_Enabled = 1;
         Dvpanel_tableattributes_Autoscroll = Convert.ToBoolean( 0);
         Dvpanel_tableattributes_Iconposition = "left";
         Dvpanel_tableattributes_Showcollapseicon = Convert.ToBoolean( 0);
         Dvpanel_tableattributes_Collapsed = Convert.ToBoolean( 0);
         Dvpanel_tableattributes_Collapsible = Convert.ToBoolean( 0);
         Dvpanel_tableattributes_Title = "数据字典信息";
         Dvpanel_tableattributes_Cls = "PanelCard_BaseColor";
         Dvpanel_tableattributes_Autoheight = Convert.ToBoolean( -1);
         Dvpanel_tableattributes_Autowidth = Convert.ToBoolean( 0);
         Dvpanel_tableattributes_Width = "100%";
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

      protected void XC_10_0N24( String A168XT_DefineCodeName )
      {
         new zutil_recordlog(context ).execute(  A168XT_DefineCodeName,  "数据字典信息",  "Create",  1) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A168XT_DefineCodeName", A168XT_DefineCodeName);
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("[[");
         context.GX_webresponse.AddString("");
         context.GX_webresponse.AddString("]");
         if ( true )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString("]");
      }

      protected void XC_11_0N24( String A168XT_DefineCodeName )
      {
         new zutil_recordlog(context ).execute(  A168XT_DefineCodeName,  "数据字典信息",  "Update",  1) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A168XT_DefineCodeName", A168XT_DefineCodeName);
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("[[");
         context.GX_webresponse.AddString("");
         context.GX_webresponse.AddString("]");
         if ( true )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString("]");
      }

      protected void XC_12_0N24( String A168XT_DefineCodeName )
      {
         new zutil_recordlog(context ).execute(  A168XT_DefineCodeName,  "数据字典信息",  "Delete",  1) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A168XT_DefineCodeName", A168XT_DefineCodeName);
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("[[");
         context.GX_webresponse.AddString("");
         context.GX_webresponse.AddString("]");
         if ( true )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString("]");
      }

      protected void init_web_controls( )
      {
         /* End function init_web_controls */
      }

      public void Valid_Xt_defindcodetypeid( long GX_Parm1 ,
                                             String GX_Parm2 )
      {
         A165XT_DefindcodeTypeID = GX_Parm1;
         A166XT_DefindcodeTypeName = GX_Parm2;
         n166XT_DefindcodeTypeName = false;
         /* Using cursor T000N13 */
         pr_default.execute(11, new Object[] {A165XT_DefindcodeTypeID});
         if ( (pr_default.getStatus(11) == 101) )
         {
            GX_msglist.addItem("不匹配'������������������'", "ForeignKeyNotFound", 1, "XT_DEFINDCODETYPEID");
            AnyError = 1;
            GX_FocusControl = edtXT_DefindcodeTypeID_Internalname;
         }
         A166XT_DefindcodeTypeName = T000N13_A166XT_DefindcodeTypeName[0];
         n166XT_DefindcodeTypeName = T000N13_n166XT_DefindcodeTypeName[0];
         pr_default.close(11);
         if ( (0==A165XT_DefindcodeTypeID) )
         {
            GX_msglist.addItem("数据字典类型主键是必须填写的。", 1, "XT_DEFINDCODETYPEID");
            AnyError = 1;
            GX_FocusControl = edtXT_DefindcodeTypeID_Internalname;
         }
         dynload_actions( ) ;
         if ( AnyError == 1 )
         {
            A166XT_DefindcodeTypeName = "";
            n166XT_DefindcodeTypeName = false;
         }
         isValidOutput.Add(A166XT_DefindcodeTypeName);
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
         setEventMetadata("ENTER","{handler:'UserMainFullajax',iparms:[{postForm:true},{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV7XT_DefineCodeID',fld:'vXT_DEFINECODEID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true}]");
         setEventMetadata("ENTER",",oparms:[]}");
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV7XT_DefineCodeID',fld:'vXT_DEFINECODEID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true},{av:'A167XT_DefineCodeID',fld:'XT_DEFINECODEID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV13Insert_XT_DefindcodeTypeID',fld:'vINSERT_XT_DEFINDCODETYPEID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'A431XT_TypeCode',fld:'XT_TYPECODE',pic:''},{av:'A432XT_TenantCode',fld:'XT_TENANTCODE',pic:''},{av:'A510XT_DefineCodeIntialType',fld:'XT_DEFINECODEINTIALTYPE',pic:'ZZZ9'}]");
         setEventMetadata("REFRESH",",oparms:[]}");
         setEventMetadata("AFTER TRN","{handler:'E120N2',iparms:[{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV11TrnContext',fld:'vTRNCONTEXT',pic:''}]");
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
         pr_default.close(11);
      }

      public override void initialize( )
      {
         sPrefix = "";
         wcpOGx_mode = "";
         Z168XT_DefineCodeName = "";
         Z431XT_TypeCode = "";
         Z432XT_TenantCode = "";
         scmdbuf = "";
         gxfirstwebparm = "";
         gxfirstwebparm_bkp = "";
         A168XT_DefineCodeName = "";
         GXKey = "";
         PreviousTooltip = "";
         PreviousCaption = "";
         Form = new GXWebForm();
         GX_FocusControl = "";
         ClassString = "";
         StyleString = "";
         ucDvpanel_tableattributes = new GXUserControl();
         TempTags = "";
         sImgUrl = "";
         A166XT_DefindcodeTypeName = "";
         bttBtntrn_enter_Jsonclick = "";
         bttBtntrn_cancel_Jsonclick = "";
         A431XT_TypeCode = "";
         A432XT_TenantCode = "";
         AV15Pgmname = "";
         Dvpanel_tableattributes_Objectcall = "";
         Dvpanel_tableattributes_Class = "";
         Dvpanel_tableattributes_Height = "";
         forbiddenHiddens = "";
         hsh = "";
         sMode24 = "";
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         AV8WWPContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPContext(context);
         AV11TrnContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext(context);
         AV12WebSession = context.GetSession();
         AV14TrnContextAtt = new GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext_Attribute(context);
         Z166XT_DefindcodeTypeName = "";
         T000N4_A166XT_DefindcodeTypeName = new String[] {""} ;
         T000N4_n166XT_DefindcodeTypeName = new bool[] {false} ;
         T000N5_A167XT_DefineCodeID = new long[1] ;
         T000N5_A168XT_DefineCodeName = new String[] {""} ;
         T000N5_n168XT_DefineCodeName = new bool[] {false} ;
         T000N5_A166XT_DefindcodeTypeName = new String[] {""} ;
         T000N5_n166XT_DefindcodeTypeName = new bool[] {false} ;
         T000N5_A171XT_DefineCodeOrder = new short[1] ;
         T000N5_n171XT_DefineCodeOrder = new bool[] {false} ;
         T000N5_A431XT_TypeCode = new String[] {""} ;
         T000N5_n431XT_TypeCode = new bool[] {false} ;
         T000N5_A432XT_TenantCode = new String[] {""} ;
         T000N5_n432XT_TenantCode = new bool[] {false} ;
         T000N5_A510XT_DefineCodeIntialType = new short[1] ;
         T000N5_n510XT_DefineCodeIntialType = new bool[] {false} ;
         T000N5_A165XT_DefindcodeTypeID = new long[1] ;
         T000N6_A166XT_DefindcodeTypeName = new String[] {""} ;
         T000N6_n166XT_DefindcodeTypeName = new bool[] {false} ;
         T000N7_A167XT_DefineCodeID = new long[1] ;
         T000N3_A167XT_DefineCodeID = new long[1] ;
         T000N3_A168XT_DefineCodeName = new String[] {""} ;
         T000N3_n168XT_DefineCodeName = new bool[] {false} ;
         T000N3_A171XT_DefineCodeOrder = new short[1] ;
         T000N3_n171XT_DefineCodeOrder = new bool[] {false} ;
         T000N3_A431XT_TypeCode = new String[] {""} ;
         T000N3_n431XT_TypeCode = new bool[] {false} ;
         T000N3_A432XT_TenantCode = new String[] {""} ;
         T000N3_n432XT_TenantCode = new bool[] {false} ;
         T000N3_A510XT_DefineCodeIntialType = new short[1] ;
         T000N3_n510XT_DefineCodeIntialType = new bool[] {false} ;
         T000N3_A165XT_DefindcodeTypeID = new long[1] ;
         T000N8_A167XT_DefineCodeID = new long[1] ;
         T000N9_A167XT_DefineCodeID = new long[1] ;
         T000N2_A167XT_DefineCodeID = new long[1] ;
         T000N2_A168XT_DefineCodeName = new String[] {""} ;
         T000N2_n168XT_DefineCodeName = new bool[] {false} ;
         T000N2_A171XT_DefineCodeOrder = new short[1] ;
         T000N2_n171XT_DefineCodeOrder = new bool[] {false} ;
         T000N2_A431XT_TypeCode = new String[] {""} ;
         T000N2_n431XT_TypeCode = new bool[] {false} ;
         T000N2_A432XT_TenantCode = new String[] {""} ;
         T000N2_n432XT_TenantCode = new bool[] {false} ;
         T000N2_A510XT_DefineCodeIntialType = new short[1] ;
         T000N2_n510XT_DefineCodeIntialType = new bool[] {false} ;
         T000N2_A165XT_DefindcodeTypeID = new long[1] ;
         T000N10_A167XT_DefineCodeID = new long[1] ;
         T000N13_A166XT_DefindcodeTypeName = new String[] {""} ;
         T000N13_n166XT_DefindcodeTypeName = new bool[] {false} ;
         T000N14_A167XT_DefineCodeID = new long[1] ;
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         isValidOutput = new GxUnknownObjectCollection();
         pr_datastore1 = new DataStoreProvider(context, new GeneXus.Programs.xt_definecode__datastore1(),
            new Object[][] {
            }
         );
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.xt_definecode__default(),
            new Object[][] {
                new Object[] {
               T000N2_A167XT_DefineCodeID, T000N2_A168XT_DefineCodeName, T000N2_n168XT_DefineCodeName, T000N2_A171XT_DefineCodeOrder, T000N2_n171XT_DefineCodeOrder, T000N2_A431XT_TypeCode, T000N2_n431XT_TypeCode, T000N2_A432XT_TenantCode, T000N2_n432XT_TenantCode, T000N2_A510XT_DefineCodeIntialType,
               T000N2_n510XT_DefineCodeIntialType, T000N2_A165XT_DefindcodeTypeID
               }
               , new Object[] {
               T000N3_A167XT_DefineCodeID, T000N3_A168XT_DefineCodeName, T000N3_n168XT_DefineCodeName, T000N3_A171XT_DefineCodeOrder, T000N3_n171XT_DefineCodeOrder, T000N3_A431XT_TypeCode, T000N3_n431XT_TypeCode, T000N3_A432XT_TenantCode, T000N3_n432XT_TenantCode, T000N3_A510XT_DefineCodeIntialType,
               T000N3_n510XT_DefineCodeIntialType, T000N3_A165XT_DefindcodeTypeID
               }
               , new Object[] {
               T000N4_A166XT_DefindcodeTypeName, T000N4_n166XT_DefindcodeTypeName
               }
               , new Object[] {
               T000N5_A167XT_DefineCodeID, T000N5_A168XT_DefineCodeName, T000N5_n168XT_DefineCodeName, T000N5_A166XT_DefindcodeTypeName, T000N5_n166XT_DefindcodeTypeName, T000N5_A171XT_DefineCodeOrder, T000N5_n171XT_DefineCodeOrder, T000N5_A431XT_TypeCode, T000N5_n431XT_TypeCode, T000N5_A432XT_TenantCode,
               T000N5_n432XT_TenantCode, T000N5_A510XT_DefineCodeIntialType, T000N5_n510XT_DefineCodeIntialType, T000N5_A165XT_DefindcodeTypeID
               }
               , new Object[] {
               T000N6_A166XT_DefindcodeTypeName, T000N6_n166XT_DefindcodeTypeName
               }
               , new Object[] {
               T000N7_A167XT_DefineCodeID
               }
               , new Object[] {
               T000N8_A167XT_DefineCodeID
               }
               , new Object[] {
               T000N9_A167XT_DefineCodeID
               }
               , new Object[] {
               T000N10_A167XT_DefineCodeID
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               T000N13_A166XT_DefindcodeTypeName, T000N13_n166XT_DefindcodeTypeName
               }
               , new Object[] {
               T000N14_A167XT_DefineCodeID
               }
            }
         );
         AV15Pgmname = "XT_DefineCode";
      }

      private short Z171XT_DefineCodeOrder ;
      private short Z510XT_DefineCodeIntialType ;
      private short GxWebError ;
      private short gxcookieaux ;
      private short IsConfirmed ;
      private short IsModified ;
      private short AnyError ;
      private short nKeyPressed ;
      private short initialized ;
      private short A171XT_DefineCodeOrder ;
      private short A510XT_DefineCodeIntialType ;
      private short RcdFound24 ;
      private short GX_JID ;
      private short Gx_BScreen ;
      private short gxajaxcallmode ;
      private short wbTemp ;
      private int trnEnded ;
      private int edtXT_DefineCodeName_Enabled ;
      private int edtXT_DefindcodeTypeID_Enabled ;
      private int imgprompt_165_Visible ;
      private int edtXT_DefindcodeTypeName_Enabled ;
      private int bttBtntrn_enter_Visible ;
      private int bttBtntrn_enter_Enabled ;
      private int bttBtntrn_cancel_Visible ;
      private int edtXT_DefineCodeID_Enabled ;
      private int edtXT_DefineCodeID_Visible ;
      private int edtXT_DefineCodeOrder_Enabled ;
      private int edtXT_DefineCodeOrder_Visible ;
      private int AV16GXV1 ;
      private int idxLst ;
      private long wcpOAV7XT_DefineCodeID ;
      private long Z167XT_DefineCodeID ;
      private long Z165XT_DefindcodeTypeID ;
      private long N165XT_DefindcodeTypeID ;
      private long A165XT_DefindcodeTypeID ;
      private long AV7XT_DefineCodeID ;
      private long A167XT_DefineCodeID ;
      private long AV13Insert_XT_DefindcodeTypeID ;
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
      private String edtXT_DefineCodeName_Internalname ;
      private String divLayoutmaintable_Internalname ;
      private String divTablemain_Internalname ;
      private String ClassString ;
      private String StyleString ;
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
      private String edtXT_DefineCodeName_Jsonclick ;
      private String edtXT_DefindcodeTypeID_Internalname ;
      private String edtXT_DefindcodeTypeID_Jsonclick ;
      private String sImgUrl ;
      private String imgprompt_165_Internalname ;
      private String imgprompt_165_Link ;
      private String edtXT_DefindcodeTypeName_Internalname ;
      private String edtXT_DefindcodeTypeName_Jsonclick ;
      private String bttBtntrn_enter_Internalname ;
      private String bttBtntrn_enter_Jsonclick ;
      private String bttBtntrn_cancel_Internalname ;
      private String bttBtntrn_cancel_Jsonclick ;
      private String divHtml_bottomauxiliarcontrols_Internalname ;
      private String edtXT_DefineCodeID_Internalname ;
      private String edtXT_DefineCodeID_Jsonclick ;
      private String edtXT_DefineCodeOrder_Internalname ;
      private String edtXT_DefineCodeOrder_Jsonclick ;
      private String AV15Pgmname ;
      private String Dvpanel_tableattributes_Objectcall ;
      private String Dvpanel_tableattributes_Class ;
      private String Dvpanel_tableattributes_Height ;
      private String forbiddenHiddens ;
      private String hsh ;
      private String sMode24 ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String sDynURL ;
      private String FormProcess ;
      private String bodyStyle ;
      private bool entryPointCalled ;
      private bool n168XT_DefineCodeName ;
      private bool toggleJsOutput ;
      private bool wbErr ;
      private bool Dvpanel_tableattributes_Autowidth ;
      private bool Dvpanel_tableattributes_Autoheight ;
      private bool Dvpanel_tableattributes_Collapsible ;
      private bool Dvpanel_tableattributes_Collapsed ;
      private bool Dvpanel_tableattributes_Showcollapseicon ;
      private bool Dvpanel_tableattributes_Autoscroll ;
      private bool n166XT_DefindcodeTypeName ;
      private bool n171XT_DefineCodeOrder ;
      private bool n431XT_TypeCode ;
      private bool n432XT_TenantCode ;
      private bool n510XT_DefineCodeIntialType ;
      private bool Dvpanel_tableattributes_Enabled ;
      private bool Dvpanel_tableattributes_Showheader ;
      private bool Dvpanel_tableattributes_Visible ;
      private bool AV9IsAuthorized ;
      private bool GXt_boolean1 ;
      private bool returnInSub ;
      private bool Gx_longc ;
      private String Z168XT_DefineCodeName ;
      private String Z431XT_TypeCode ;
      private String Z432XT_TenantCode ;
      private String A168XT_DefineCodeName ;
      private String A166XT_DefindcodeTypeName ;
      private String A431XT_TypeCode ;
      private String A432XT_TenantCode ;
      private String Z166XT_DefindcodeTypeName ;
      private IGxSession AV12WebSession ;
      private GxUnknownObjectCollection isValidOutput ;
      private GXUserControl ucDvpanel_tableattributes ;
      private IGxDataStore dsDataStore1 ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private String[] T000N4_A166XT_DefindcodeTypeName ;
      private bool[] T000N4_n166XT_DefindcodeTypeName ;
      private long[] T000N5_A167XT_DefineCodeID ;
      private String[] T000N5_A168XT_DefineCodeName ;
      private bool[] T000N5_n168XT_DefineCodeName ;
      private String[] T000N5_A166XT_DefindcodeTypeName ;
      private bool[] T000N5_n166XT_DefindcodeTypeName ;
      private short[] T000N5_A171XT_DefineCodeOrder ;
      private bool[] T000N5_n171XT_DefineCodeOrder ;
      private String[] T000N5_A431XT_TypeCode ;
      private bool[] T000N5_n431XT_TypeCode ;
      private String[] T000N5_A432XT_TenantCode ;
      private bool[] T000N5_n432XT_TenantCode ;
      private short[] T000N5_A510XT_DefineCodeIntialType ;
      private bool[] T000N5_n510XT_DefineCodeIntialType ;
      private long[] T000N5_A165XT_DefindcodeTypeID ;
      private String[] T000N6_A166XT_DefindcodeTypeName ;
      private bool[] T000N6_n166XT_DefindcodeTypeName ;
      private long[] T000N7_A167XT_DefineCodeID ;
      private long[] T000N3_A167XT_DefineCodeID ;
      private String[] T000N3_A168XT_DefineCodeName ;
      private bool[] T000N3_n168XT_DefineCodeName ;
      private short[] T000N3_A171XT_DefineCodeOrder ;
      private bool[] T000N3_n171XT_DefineCodeOrder ;
      private String[] T000N3_A431XT_TypeCode ;
      private bool[] T000N3_n431XT_TypeCode ;
      private String[] T000N3_A432XT_TenantCode ;
      private bool[] T000N3_n432XT_TenantCode ;
      private short[] T000N3_A510XT_DefineCodeIntialType ;
      private bool[] T000N3_n510XT_DefineCodeIntialType ;
      private long[] T000N3_A165XT_DefindcodeTypeID ;
      private long[] T000N8_A167XT_DefineCodeID ;
      private long[] T000N9_A167XT_DefineCodeID ;
      private long[] T000N2_A167XT_DefineCodeID ;
      private String[] T000N2_A168XT_DefineCodeName ;
      private bool[] T000N2_n168XT_DefineCodeName ;
      private short[] T000N2_A171XT_DefineCodeOrder ;
      private bool[] T000N2_n171XT_DefineCodeOrder ;
      private String[] T000N2_A431XT_TypeCode ;
      private bool[] T000N2_n431XT_TypeCode ;
      private String[] T000N2_A432XT_TenantCode ;
      private bool[] T000N2_n432XT_TenantCode ;
      private short[] T000N2_A510XT_DefineCodeIntialType ;
      private bool[] T000N2_n510XT_DefineCodeIntialType ;
      private long[] T000N2_A165XT_DefindcodeTypeID ;
      private long[] T000N10_A167XT_DefineCodeID ;
      private String[] T000N13_A166XT_DefindcodeTypeName ;
      private bool[] T000N13_n166XT_DefindcodeTypeName ;
      private long[] T000N14_A167XT_DefineCodeID ;
      private IDataStoreProvider pr_datastore1 ;
      private GXWebForm Form ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPContext AV8WWPContext ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext AV11TrnContext ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext_Attribute AV14TrnContextAtt ;
   }

   public class xt_definecode__datastore1 : DataStoreHelperBase, IDataStoreHelper
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

 public class xt_definecode__default : DataStoreHelperBase, IDataStoreHelper
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
       ,new UpdateCursor(def[9])
       ,new UpdateCursor(def[10])
       ,new ForEachCursor(def[11])
       ,new ForEachCursor(def[12])
     };
  }

  private static CursorDef[] def;
  private void cursorDefinitions( )
  {
     if ( def == null )
     {
        Object[] prmT000N5 ;
        prmT000N5 = new Object[] {
        new Object[] {"@XT_DefineCodeID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000N4 ;
        prmT000N4 = new Object[] {
        new Object[] {"@XT_DefindcodeTypeID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000N6 ;
        prmT000N6 = new Object[] {
        new Object[] {"@XT_DefindcodeTypeID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000N7 ;
        prmT000N7 = new Object[] {
        new Object[] {"@XT_DefineCodeID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000N3 ;
        prmT000N3 = new Object[] {
        new Object[] {"@XT_DefineCodeID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000N8 ;
        prmT000N8 = new Object[] {
        new Object[] {"@XT_DefineCodeID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000N9 ;
        prmT000N9 = new Object[] {
        new Object[] {"@XT_DefineCodeID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000N2 ;
        prmT000N2 = new Object[] {
        new Object[] {"@XT_DefineCodeID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000N10 ;
        prmT000N10 = new Object[] {
        new Object[] {"@XT_DefineCodeName",SqlDbType.NVarChar,100,0} ,
        new Object[] {"@XT_DefineCodeOrder",SqlDbType.SmallInt,4,0} ,
        new Object[] {"@XT_TypeCode",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@XT_TenantCode",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@XT_DefineCodeIntialType",SqlDbType.SmallInt,4,0} ,
        new Object[] {"@XT_DefindcodeTypeID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000N11 ;
        prmT000N11 = new Object[] {
        new Object[] {"@XT_DefineCodeName",SqlDbType.NVarChar,100,0} ,
        new Object[] {"@XT_DefineCodeOrder",SqlDbType.SmallInt,4,0} ,
        new Object[] {"@XT_TypeCode",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@XT_TenantCode",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@XT_DefineCodeIntialType",SqlDbType.SmallInt,4,0} ,
        new Object[] {"@XT_DefindcodeTypeID",SqlDbType.Decimal,18,0} ,
        new Object[] {"@XT_DefineCodeID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000N12 ;
        prmT000N12 = new Object[] {
        new Object[] {"@XT_DefineCodeID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000N14 ;
        prmT000N14 = new Object[] {
        } ;
        Object[] prmT000N13 ;
        prmT000N13 = new Object[] {
        new Object[] {"@XT_DefindcodeTypeID",SqlDbType.Decimal,18,0}
        } ;
        def= new CursorDef[] {
            new CursorDef("T000N2", "SELECT [XT_DefineCodeID], [XT_DefineCodeName], [XT_DefineCodeOrder], [XT_TypeCode], [XT_TenantCode], [XT_DefineCodeIntialType], [XT_DefindcodeTypeID] FROM [XT_DefineCode] WITH (UPDLOCK) WHERE [XT_DefineCodeID] = @XT_DefineCodeID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000N2,1,0,true,false )
           ,new CursorDef("T000N3", "SELECT [XT_DefineCodeID], [XT_DefineCodeName], [XT_DefineCodeOrder], [XT_TypeCode], [XT_TenantCode], [XT_DefineCodeIntialType], [XT_DefindcodeTypeID] FROM [XT_DefineCode] WITH (NOLOCK) WHERE [XT_DefineCodeID] = @XT_DefineCodeID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000N3,1,0,true,false )
           ,new CursorDef("T000N4", "SELECT [XT_DefindcodeTypeName] FROM [XT_DefindcodeType] WITH (NOLOCK) WHERE [XT_DefindcodeTypeID] = @XT_DefindcodeTypeID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000N4,1,0,true,false )
           ,new CursorDef("T000N5", "SELECT TM1.[XT_DefineCodeID], TM1.[XT_DefineCodeName], T2.[XT_DefindcodeTypeName], TM1.[XT_DefineCodeOrder], TM1.[XT_TypeCode], TM1.[XT_TenantCode], TM1.[XT_DefineCodeIntialType], TM1.[XT_DefindcodeTypeID] FROM ([XT_DefineCode] TM1 WITH (NOLOCK) INNER JOIN [XT_DefindcodeType] T2 WITH (NOLOCK) ON T2.[XT_DefindcodeTypeID] = TM1.[XT_DefindcodeTypeID]) WHERE TM1.[XT_DefineCodeID] = @XT_DefineCodeID ORDER BY TM1.[XT_DefineCodeID]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT000N5,100,0,true,false )
           ,new CursorDef("T000N6", "SELECT [XT_DefindcodeTypeName] FROM [XT_DefindcodeType] WITH (NOLOCK) WHERE [XT_DefindcodeTypeID] = @XT_DefindcodeTypeID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000N6,1,0,true,false )
           ,new CursorDef("T000N7", "SELECT [XT_DefineCodeID] FROM [XT_DefineCode] WITH (NOLOCK) WHERE [XT_DefineCodeID] = @XT_DefineCodeID  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000N7,1,0,true,false )
           ,new CursorDef("T000N8", "SELECT TOP 1 [XT_DefineCodeID] FROM [XT_DefineCode] WITH (NOLOCK) WHERE ( [XT_DefineCodeID] > @XT_DefineCodeID) ORDER BY [XT_DefineCodeID]  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000N8,1,0,true,true )
           ,new CursorDef("T000N9", "SELECT TOP 1 [XT_DefineCodeID] FROM [XT_DefineCode] WITH (NOLOCK) WHERE ( [XT_DefineCodeID] < @XT_DefineCodeID) ORDER BY [XT_DefineCodeID] DESC  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000N9,1,0,true,true )
           ,new CursorDef("T000N10", "INSERT INTO [XT_DefineCode]([XT_DefineCodeName], [XT_DefineCodeOrder], [XT_TypeCode], [XT_TenantCode], [XT_DefineCodeIntialType], [XT_DefindcodeTypeID]) VALUES(@XT_DefineCodeName, @XT_DefineCodeOrder, @XT_TypeCode, @XT_TenantCode, @XT_DefineCodeIntialType, @XT_DefindcodeTypeID); SELECT SCOPE_IDENTITY()", GxErrorMask.GX_NOMASK,prmT000N10)
           ,new CursorDef("T000N11", "UPDATE [XT_DefineCode] SET [XT_DefineCodeName]=@XT_DefineCodeName, [XT_DefineCodeOrder]=@XT_DefineCodeOrder, [XT_TypeCode]=@XT_TypeCode, [XT_TenantCode]=@XT_TenantCode, [XT_DefineCodeIntialType]=@XT_DefineCodeIntialType, [XT_DefindcodeTypeID]=@XT_DefindcodeTypeID  WHERE [XT_DefineCodeID] = @XT_DefineCodeID", GxErrorMask.GX_NOMASK,prmT000N11)
           ,new CursorDef("T000N12", "DELETE FROM [XT_DefineCode]  WHERE [XT_DefineCodeID] = @XT_DefineCodeID", GxErrorMask.GX_NOMASK,prmT000N12)
           ,new CursorDef("T000N13", "SELECT [XT_DefindcodeTypeName] FROM [XT_DefindcodeType] WITH (NOLOCK) WHERE [XT_DefindcodeTypeID] = @XT_DefindcodeTypeID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000N13,1,0,true,false )
           ,new CursorDef("T000N14", "SELECT [XT_DefineCodeID] FROM [XT_DefineCode] WITH (NOLOCK) ORDER BY [XT_DefineCodeID]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT000N14,100,0,true,false )
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
              ((bool[]) buf[2])[0] = rslt.wasNull(2);
              ((short[]) buf[3])[0] = rslt.getShort(3) ;
              ((bool[]) buf[4])[0] = rslt.wasNull(3);
              ((String[]) buf[5])[0] = rslt.getVarchar(4) ;
              ((bool[]) buf[6])[0] = rslt.wasNull(4);
              ((String[]) buf[7])[0] = rslt.getVarchar(5) ;
              ((bool[]) buf[8])[0] = rslt.wasNull(5);
              ((short[]) buf[9])[0] = rslt.getShort(6) ;
              ((bool[]) buf[10])[0] = rslt.wasNull(6);
              ((long[]) buf[11])[0] = rslt.getLong(7) ;
              return;
           case 1 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
              ((bool[]) buf[2])[0] = rslt.wasNull(2);
              ((short[]) buf[3])[0] = rslt.getShort(3) ;
              ((bool[]) buf[4])[0] = rslt.wasNull(3);
              ((String[]) buf[5])[0] = rslt.getVarchar(4) ;
              ((bool[]) buf[6])[0] = rslt.wasNull(4);
              ((String[]) buf[7])[0] = rslt.getVarchar(5) ;
              ((bool[]) buf[8])[0] = rslt.wasNull(5);
              ((short[]) buf[9])[0] = rslt.getShort(6) ;
              ((bool[]) buf[10])[0] = rslt.wasNull(6);
              ((long[]) buf[11])[0] = rslt.getLong(7) ;
              return;
           case 2 :
              ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
              ((bool[]) buf[1])[0] = rslt.wasNull(1);
              return;
           case 3 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
              ((bool[]) buf[2])[0] = rslt.wasNull(2);
              ((String[]) buf[3])[0] = rslt.getVarchar(3) ;
              ((bool[]) buf[4])[0] = rslt.wasNull(3);
              ((short[]) buf[5])[0] = rslt.getShort(4) ;
              ((bool[]) buf[6])[0] = rslt.wasNull(4);
              ((String[]) buf[7])[0] = rslt.getVarchar(5) ;
              ((bool[]) buf[8])[0] = rslt.wasNull(5);
              ((String[]) buf[9])[0] = rslt.getVarchar(6) ;
              ((bool[]) buf[10])[0] = rslt.wasNull(6);
              ((short[]) buf[11])[0] = rslt.getShort(7) ;
              ((bool[]) buf[12])[0] = rslt.wasNull(7);
              ((long[]) buf[13])[0] = rslt.getLong(8) ;
              return;
           case 4 :
              ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
              ((bool[]) buf[1])[0] = rslt.wasNull(1);
              return;
           case 5 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
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
           case 11 :
              ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
              ((bool[]) buf[1])[0] = rslt.wasNull(1);
              return;
           case 12 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
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
              stmt.SetParameter(1, (long)parms[0]);
              return;
           case 3 :
              stmt.SetParameter(1, (long)parms[0]);
              return;
           case 4 :
              stmt.SetParameter(1, (long)parms[0]);
              return;
           case 5 :
              stmt.SetParameter(1, (long)parms[0]);
              return;
           case 6 :
              stmt.SetParameter(1, (long)parms[0]);
              return;
           case 7 :
              stmt.SetParameter(1, (long)parms[0]);
              return;
           case 8 :
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
                 stmt.setNull( 2 , SqlDbType.SmallInt );
              }
              else
              {
                 stmt.SetParameter(2, (short)parms[3]);
              }
              if ( (bool)parms[4] )
              {
                 stmt.setNull( 3 , SqlDbType.NVarChar );
              }
              else
              {
                 stmt.SetParameter(3, (String)parms[5]);
              }
              if ( (bool)parms[6] )
              {
                 stmt.setNull( 4 , SqlDbType.NVarChar );
              }
              else
              {
                 stmt.SetParameter(4, (String)parms[7]);
              }
              if ( (bool)parms[8] )
              {
                 stmt.setNull( 5 , SqlDbType.SmallInt );
              }
              else
              {
                 stmt.SetParameter(5, (short)parms[9]);
              }
              stmt.SetParameter(6, (long)parms[10]);
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
              if ( (bool)parms[2] )
              {
                 stmt.setNull( 2 , SqlDbType.SmallInt );
              }
              else
              {
                 stmt.SetParameter(2, (short)parms[3]);
              }
              if ( (bool)parms[4] )
              {
                 stmt.setNull( 3 , SqlDbType.NVarChar );
              }
              else
              {
                 stmt.SetParameter(3, (String)parms[5]);
              }
              if ( (bool)parms[6] )
              {
                 stmt.setNull( 4 , SqlDbType.NVarChar );
              }
              else
              {
                 stmt.SetParameter(4, (String)parms[7]);
              }
              if ( (bool)parms[8] )
              {
                 stmt.setNull( 5 , SqlDbType.SmallInt );
              }
              else
              {
                 stmt.SetParameter(5, (short)parms[9]);
              }
              stmt.SetParameter(6, (long)parms[10]);
              stmt.SetParameter(7, (long)parms[11]);
              return;
           case 10 :
              stmt.SetParameter(1, (long)parms[0]);
              return;
           case 11 :
              stmt.SetParameter(1, (long)parms[0]);
              return;
     }
  }

}

}
